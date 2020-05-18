using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace STools
{
	public abstract class STJson
	{
        protected String _comment = null;

        public STJson(String comment)
        {
            _comment = comment;
        }

		public void addValue(Object key, Object value)
		{
			STJsonValue jsonValue = new STJsonValue(value, null);
			addJson(key, jsonValue);
		}

		public virtual void addJson(Object key, STJson json)
		{
			throw new Exception("can't add json");
		}

		protected virtual  STJson getLinkOneTail(STJson jsonRoot)
		{
			return this;
		}

		public STJson getJsonPath(String path, bool skipNFind)
		{
			try
			{
				STJson jsonRoot = this; 
				
				String[] spPath = path.Split('/');
				for(int i = 0; i < spPath.Length; i ++)
				{
					String subPath = spPath[i];
					if(subPath.Length == 0)
						continue;
					if(subPath[0] == '#')
					{
						int index = Int32.Parse(subPath.Substring(1));
						if(skipNFind && index >= jsonRoot.asJsonList().Count)
							return null;
						jsonRoot = jsonRoot.getJson(index);
					}
					else
					{
						if(skipNFind && !jsonRoot.has(spPath[i]))
							return null;
						jsonRoot = jsonRoot.getJson(spPath[i]);
					}
				}
				
				return jsonRoot;
			}
			catch(Exception ex)
			{
				throw new Exception(String.Format("get json path [{0}] error", path), ex);
			}
		}

		public String getComment()
		{
			return _comment;
		}

		public virtual Object getValue()
		{
			throw new NotImplementedException();
		}

		public virtual bool has(String key)
		{
			throw new NotImplementedException();
		}

		public virtual String asString()
		{
			return (String)getValue();
		}

		public virtual String asModifyString()
		{
			return (String)getValue();
		}

		public virtual String[] getJsonNames()
		{
			throw new NotImplementedException();
		}

		public int asInteger()
		{
			return (int)asNumber();
		}

		public double asNumber()
		{
			return (double)getValue();
		}

		public bool asBoolean()
		{
			return (bool)getValue();
		}
		
		public virtual List<STJson> asJsonList()
		{
			throw new NotImplementedException();
		}

		public virtual Dictionary<String, STJson> asJsonMap()
		{
			throw new NotImplementedException();
		}

        public virtual String getType()
        {
            throw new NotImplementedException();
        }

		public STJson getJson(Object key)
		{
			STJson value = safeGetJson(key);
			if(value == null)
				throw new Exception(String.Format("key [{0}] is not found", key.ToString()));

			return value;
		}

		public String safeGetComment(String defVal)
		{
			if (_comment == null)
				return defVal;

			return _comment;
		}

		public bool safeGetBoolean(Object key, bool defVal)
		{
			STJson json = safeGetJson(key);
			if (json == null)
				return defVal;

			return json.asBoolean();
		}

		public int safeGetInteger(Object key, int defVal)
		{
			STJson json = safeGetJson(key);
			if (json == null)
				return defVal;

			return json.asInteger();
		}

		public String safeGetString(Object key, String defVal)
		{
			STJson json = safeGetJson(key);
			if(json == null)
				return defVal;

			return json.asString();
		}

		public virtual bool isJsonMap()
		{
			return false;
		}

		public virtual bool isJsonList()
		{
			return false;
		}

		public virtual bool isJsonMacro()
		{
			return false;
		}

		public virtual bool isJsonValue()
		{
			return false;
		}

		public virtual bool isJsonString()
		{
			return false;
		}

		public virtual bool isJsonNumber()
		{
			return false;
		}

		public virtual bool isJsonBoolean()
		{
			return false;
		}

		public virtual int[] getMuliStringPos()
		{
			return null;
		}

		public virtual STJson safeGetJson(Object key)
		{
			throw new NotImplementedException();
		}

        public static STJson parse(String strJson)
        {
            return parse(strJson, false, null);
        }

		public static STJson parse(String strJson, bool modifyMode)
		{
			return parse(strJson, modifyMode, null);
		}

		public static STJson parseFile(String fileName)
		{
			return parse(readJsonFile(fileName), false, Path.GetDirectoryName(fileName) + "\\");
		}

		private static STJson parse(String strJson, bool modifyMode, String filePath)
		{
			Object value;
			ParseJsonCharIterator iterator = new ParseJsonCharIterator(strJson, modifyMode, filePath);
			JsonType type = nextJsonType(iterator, out value);
			STJson jsonRoot = parseJsonIterator(type, value, iterator);

			if (iterator._writeBackList.Count > 0)
			{
				for (int i = iterator._writeBackList.Count - 1; i >= 0; i--)
				{
					STJSonWriteBack json = iterator._writeBackList[i];
					json.writeBack((STJson)jsonRoot, false);
				}
			}

			return jsonRoot;
		}

		private static STJson parseJsonIterator(JsonType type, Object value, ParseJsonCharIterator iterator)
		{
			if(type == JsonType.String || type == JsonType.Number || type == JsonType.Boolean)
				return new STJsonValue(value, iterator.getComment(true));
			if(type == JsonType.DKH_L)
				return parseJsonMap(iterator);
			if(type == JsonType.ZKH_L)
				return parseJsonArray(iterator);
			if (type == JsonType.Macro)
			{
				if(iterator.isModifyMode())
					return new STJsonMacro(value, iterator.getComment(true));
				else
					return parseJsonMacro(value, iterator);
			}
			if (type == JsonType.XKH_L)
				return parseJsonStringJoin(iterator);
			iterator.throwError(String.Format("invalid keyword [{0}][{1}]", type, value));
			return null;
		}

		public static String cutJsonString(String text)
		{
			String findChar = "{[(tf/0123456789'\"";
			int pos = 0;
			for (; pos < text.Length; pos++)
			{
				if (findChar.IndexOf(text[pos]) >= 0)
					return text.Substring(pos);
			}
			throw new Exception("String is not json format");

		}

		public static String readJsonFile(String fileName)
		{
			try
			{
				String text = File.ReadAllText(fileName, Encoding.UTF8);
				return cutJsonString(text);
			}
			catch(Exception ex)
			{
				throw new Exception(String.Format("File {0} is not json file", fileName), ex);
			}
		}

		private static String convFileName(String fileName, ParseJsonCharIterator iterator)
		{
			if (fileName[0] == '*')
				fileName = fileName.Substring(1);
			else
				fileName = iterator.getFilePath() + fileName;
			return fileName;
		}

		private static STJson insertJsonText(ParseJsonCharIterator iterator, String text)
		{
			iterator.insertParseText(text);
			Object value;
			JsonType type = nextJsonType(iterator, out value);
			return parseJsonIterator(type, value, iterator);
		}

		private static STJson parseJsonMacro(Object value, ParseJsonCharIterator iterator)
		{
			String[] list = (String[])value;
			
			// '#include_file,[file name],[json,array,map]?'
			if ("#include_file" == list[0])
	        {
				String fileName = convFileName(list[1], iterator);

				// 对返回的字符串做转换
				String mode = "J";
				if (list.Length > 2)
					mode = list[2].ToUpper();

				// 需要对数据做处理
				if (mode[0] != 'J')
				{
					String text = readTextFileForJson(fileName, mode, null);
					return insertJsonText(iterator, "0," + text);
				}
				else
				{
					String text = STJson.readJsonFile(fileName);
					return insertJsonText(iterator, text);
				}
			}
			// replace current node to linked node
			// '#link, [link path]'
			else if ("#link" == list[0])
			{
				String link = getJsonFullPath(list[1], iterator);

				STJsonLinkOne json = new STJsonLinkOne(link);
				iterator._writeBackList.Add(json);
				return json;
			}
			// replac current node to linked node list 
			// '#link_list, [link path]'
			else if ("#link_list" == list[0])
			{
				String link = getJsonFullPath(list[1], iterator);

				STJsonLinkList json = new STJsonLinkList(link);
				iterator._writeBackList.Add(json);

				return json;
			}
			// replac current node to linked node map 
			// '#link_map, [link path], [overwrite|ignore|error]?, [regex for filter]?, [replace for filter]?'
			else if ("#link_map" == list[0])
			{
				String link = getJsonFullPath(list[1], iterator);
				char mode = 'I';

				if (list.Length > 2)
				{
					mode = list[2].ToUpper()[0];
					if (mode != 'O' && mode != 'I' && mode != 'E')
						throw new Exception(String.Format("unknow link_map mode [{0}]", list[2]));
				}

				String regFilter = (list.Length > 3) ? list[3] : null;
				String repFilter = (list.Length > 4) ? list[4] : null;

				STJsonLinkMap json = new STJsonLinkMap(link, mode, regFilter, repFilter);
				iterator._writeBackList.Add(json);

				return json;
			}

			else
				throw new Exception(String.Format("unsupport macro [{0}]", list[0]));
		}

		public static String getJsonFullPath(String path, ParseJsonCharIterator iterator)
		{
			// 切分路径
			String[] sp = path.Split('/');

			// 如果第一个路径是"."或"..", 则将基本路径复制过来
			List<String> fullPath = null;
			if ("." == sp[0] || ".." == sp[0])
			{
				// 如果是当前目录需要回退到倒数第二个，因为最后一个路径是map或索引本身
				// 所以回退位置和长度正巧一致
				int endPos = sp[0].Length;
				fullPath = new List<String>();
				for (int i = iterator._parsePath.Count - 1; i >= endPos; i--)
				{
					fullPath.Add(iterator._parsePath[i]);
				}
			}
			// 如果第一个路径不是"."或".."，则此路径为全路径
			else
			{
				return path;
			}

			// 计算以后的路径
			for (int i = 1; i < sp.Length; i++)
			{
				if ("." == sp[i])
					continue;
				else if (".." == sp[i])
				{
					if (fullPath.Count == 0)
						throw new Exception(String.Format("can't calcuate path [{0}]", path));
					fullPath.RemoveAt(fullPath.Count - 1);
				}
				else
				{
					fullPath.Add(sp[i]);
				}
			}

			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < fullPath.Count; i++)
			{
				if (sb.Length > 0)
					sb.Append("/");
				sb.Append(fullPath[i]);
			}

			return sb.ToString();
		}

		private static String readTextFileForJson(String fileName, String mode, String[] tranKeyList)
	    {
    		// 对返回的字符串做转换
			String text = STJson.readJsonFile(fileName);
    		
    		// 需要对数据做处理
    		if(mode[0] != 'J')
    		{
    			int index = 0;

				if(text[0] != '{' && text[0] != '(')
					throw new Exception(String.Format("file [{}] is not mode start json file", fileName));

				text = text.Substring(1);
    			
    			// 去掉尾部的'}'
    			for(index = text.Length - 1; index >= 0; index --)
    			{
					char ch = text[index];
					if(ch == '\r' || ch == '\n' || ch == '\t' || ch == ' ')
						continue;
					if(ch == ']' || ch == '}')
						break;
    			}
				if(index < 0)
					throw new Exception(String.Format("file [{}] is not mode end json file", fileName));
    			if(index > 0)
    				text = text.Substring(0, index);
    			
    			// 去掉尾部的逗号
    			for(index = text.Length - 1; index >= 0; index --)
    			{
					char ch = text[index];
					if(ch == '\r' || ch == '\n' || ch == '\t' || ch == ' ')
						continue;
					
					if(ch == ',')
        				text = text.Substring(0, index);

					break;
    			}
    			
				
    			if(tranKeyList != null)
				{
					String fname = Path.GetFileNameWithoutExtension(fileName);
					
					for(int i = 0; i < tranKeyList.Length; i += 2)
					{
						text = text.Replace(tranKeyList[i + 0], tranKeyList[i + 1].Replace("${TRAN_BASE}", fname));
					}
				}
        	}
			return text;
    	}

		private static STJson parseJsonStringJoin(ParseJsonCharIterator iterator)
		{
			StringBuilder sbOut = new StringBuilder();
			Object value;
			JsonType type;
			List<int> listPos = iterator.isModifyMode() ? new List<int>() : null;

			if(listPos != null)
				listPos.Add(0);

			while ((type = nextJsonType(iterator, out value)) != JsonType.XKH_R)
			{
				// 如果是字符串则追加
				if (type == JsonType.String)
				{
					sbOut.Append(value);
					if(listPos != null)
						listPos.Add(sbOut.Length - listPos[listPos.Count - 1]);
					continue;
				}

				// 如果是‘+’则忽略
				if (type == JsonType.ADD)
					continue;

				// 如果不是这两个符号则异常
				iterator.throwError("invalid json array split");
			}

			if(listPos != null)
				return new STJsonMuliValue(sbOut.ToString(), listPos.ToArray(), iterator.getComment(true));
			else
				return new STJsonValue(sbOut.ToString(), iterator.getComment(true));

		}

		private static STJson parseJsonArray(ParseJsonCharIterator iterator)
		{
			Object value;
			STJsonArray jsonArray = new STJsonArray(iterator.getComment(true));
			JsonType type;

			int index = 0;
			while((type = nextJsonType(iterator, out value)) != JsonType.ZKH_R)
			{
				// 第一个类型是值
				iterator._parsePath.Insert(0, String.Format("#{0}", index));
				STJson jsonValue = parseJsonIterator(type, value, iterator);
				if(jsonValue is STJSonWriteBack)
					((STJSonWriteBack)jsonValue).setWriteBackParent(jsonArray, index);
				iterator._parsePath.RemoveAt(0);
				jsonArray.addJson(null, jsonValue);

				index++;

				// 获取下一分割符
				type = nextJsonType(iterator, out value);

				// 如果这个符号是逗号，则继续下一条
				if (type == JsonType.DH)
					continue;

				// 如果这个符号是大括号，则直接退出
				if (type == JsonType.ZKH_R)
					break;

				// 如果不是这两个符号则异常
				iterator.throwError("invalid json array split");
			}

			return jsonArray;
		}

		private static STJson parseJsonMap(ParseJsonCharIterator iterator)
		{
			Object value;
			STJsonMap jsonMap = new STJsonMap(iterator.getComment(true));
			JsonType type;
			List<String> jsonNames = iterator.isModifyMode() ? new List<String>() : null;

			while((type = nextJsonType(iterator, out value)) != JsonType.DKH_R)
			{
				// 第一个类型是key
				if(type != JsonType.String)
					iterator.throwError("invalid JsonMap key type");

				String key = value.ToString();
				
				// 如果发现匿名map，且属于编辑模式，则自定义一个随机key
				if (key == "" && iterator.isModifyMode())
					key = "\b" + Guid.NewGuid().ToString();

				iterator._parsePath.Insert(0, key);

				// 第二个类型是':'
				if((type = nextJsonType(iterator, out value)) != JsonType.MH)
					iterator.throwError("invalid JsonMap split type");

				// 第三个类型是value
				type = nextJsonType(iterator, out value);
				STJson jsonValue = parseJsonIterator(type, value, iterator);

				if (jsonValue is STJSonWriteBack)
					((STJSonWriteBack)jsonValue).setWriteBackParent(jsonMap, key);

				// 将子项加入
				if (key.Length > 0)
				{
					if(jsonNames != null && !jsonMap.has(key))
						jsonNames.Add(key);
					jsonMap.addJson(key, jsonValue);
				}
				iterator._parsePath.RemoveAt(0);

				// 获取下一分割符
				type = nextJsonType(iterator, out value);

				// 如果这个符号是逗号，则继续下一条
				if(type == JsonType.DH)
					continue;

				// 如果这个符号是大括号，则直接退出
				if(type == JsonType.DKH_R)
					break;

				// 如果不是这两个符号则异常
				iterator.throwError("invalid json map split");
			}

			if (jsonNames != null)
				jsonMap.setJsonNames(jsonNames.ToArray());
			
			return jsonMap;
		}

		private static JsonType nextJsonType(ParseJsonCharIterator iterator, out Object rValue)
		{
			rValue = null;
            iterator.skipCTypeSpaceAndComment();
			char ch = iterator.next(true);
			if (ch == '{')
				return JsonType.DKH_L;
			if (ch == '}')
				return JsonType.DKH_R;
			if (ch == '[')
				return JsonType.ZKH_L;
			if (ch == ']')
				return JsonType.ZKH_R;
			if (ch == '(')
				return JsonType.XKH_L;
			if (ch == ')')
				return JsonType.XKH_R;
			if (ch == ',')
				return JsonType.DH;
			if (ch == ':')
				return JsonType.MH;
			if (ch == '+')
				return JsonType.ADD;
			else if (ch == '"')
			{
				rValue = iterator.nextCTypeString('"');
				return JsonType.String;
			}
			else if (ch == '\'')
			{
				rValue = iterator.parseMacroString('\'');
				return JsonType.Macro;
			}
			else if (ch == 't')
			{
				if (!iterator.nextString("rue"))
					iterator.throwError("invalid boolean value");
				rValue = true;
				return JsonType.Boolean;
			}
			else if (ch == 'f')
			{
				if (!iterator.nextString("alse"))
					iterator.throwError("invalid boolean value");
				rValue = false;
				return JsonType.Boolean;
			}
			else if (ch == '-' || (ch >= '0' && ch <= '9'))
			{
				rValue = iterator.parseNumber(ch);
				return JsonType.Boolean;
			}
			else if (ch == '\x0')
				return JsonType.END;

			iterator.throwError("invalid word");
			return JsonType.NULL;
		}

		public static String jsonStrToString(String perfix, String value)
		{
			value = value
				.Replace("\\", "\\\\")
				.Replace("\r", "\\r")
				.Replace("\n", "\\n")
				.Replace("\t", "\\t")
				.Replace("\b", "\\b")
				;

			if(!String.IsNullOrEmpty(perfix))
				value = perfix + value.Replace(perfix, "\\" + perfix) + perfix;

			return value;
		}

		private enum JsonType
		{
			NULL,
			END,
			DKH_L,
			DKH_R,
			ZKH_L,
			ZKH_R,
			XKH_L,
			XKH_R,
			ADD,
			DH,
			MH,
			String,
			Boolean,
			Number,
            Macro,
		}

		private class STJsonValue : STJson
		{
			private Object _value;

			public STJsonValue(Object value, String comment):base(comment)
			{
				_value = value;
			}

			public override bool isJsonString()
			{
				return (_value is String);
			}

			public override bool isJsonNumber()
			{
				return (_value is Double);
			}

			public override bool isJsonBoolean()
			{
				return (_value is Boolean);
			}


			public override bool isJsonValue()
			{
				return true;
			}

			public override object getValue()
			{
				return _value;
			}

			public override string getType()
			{
				if(_value is String)
					return "S";
				if(_value is Double)
					return "N";
				if(_value is Boolean)
					return "B";

				throw new Exception("unknow type");
			}

			public override string ToString()
			{
				if(_value is String)
					return STJson.jsonStrToString("\"", (String)_value);
				else if(_value is bool)
					return (bool)_value ? "true" : "false";
				return _value.ToString();
			}
		}

		private class STJsonMuliValue : STJsonValue
		{
			private int[] _posList = null;
			public STJsonMuliValue(Object value, int[] posList, String comment)
				: base(value, comment)
			{
				_posList = posList;
			}

			public override int[] getMuliStringPos()
			{
				return _posList;
			}


			public override String asModifyString()
			{
				String value = (String)getValue();
				if (_posList.Length == 1)
					return value;

				StringBuilder sb = new StringBuilder();
				sb.Append(jsonStrToString("", value.Substring(0, _posList[1])));
				for(int i = 1; i < (_posList.Length - 1); i ++)
				{
					sb.Append("\n");
					int len = _posList[i + 1] - _posList[i];
					if(len > 0)
						sb.Append(jsonStrToString("", value.Substring(_posList[i], len)));
				}
				sb.Append(jsonStrToString("", value.Substring(_posList[_posList.Length - 1])));

				return sb.ToString();
			}
		}

        private class STJsonMacro : STJson
        {
            private Object _value;

            public STJsonMacro(Object value, String comment)
                : base(comment)
            {
                _value = value;
            }

			public override bool isJsonMacro()
			{
				return true;
			}

			public override string asString()
			{
				return ToString();
			}

            public override object getValue()
            {
                return _value;
            }

            public override string getType()
            {
                return "D";
            }

            public override string ToString()
            {
                return STJson.jsonStrToString("'", _value.ToString());
            }
        }

		private class STJsonMap : STJson
		{
			private Dictionary<String, STJson> _dict = new Dictionary<string,STJson>();
			private String[] _jsonNames = null;

            public STJsonMap(String comment)
                : base(comment)
            {
            }

			public void setJsonNames(String[] jsonNames)
			{
				_jsonNames = jsonNames; 
			}

			public override String[] getJsonNames()
			{
				return _jsonNames;
			}

			public override bool isJsonMap()
			{
				return true;
			}

			public override Dictionary<string, STJson> asJsonMap()
			{
				return _dict;
			}

			public override bool has(string key)
			{
				return _dict.ContainsKey(key);
			}

			public override object getValue()
			{
				return _dict;
			}
			
			public override string getType()
			{
				return "M";
			}

			public override STJson safeGetJson(object key)
			{
				if(!_dict.ContainsKey(key.ToString()))
					return null;
				return _dict[key.ToString()];
			}

			public override void addJson(Object key, STJson json)
			{
				_dict[(String)key] = json;
			}

			public override string ToString()
			{
				StringBuilder sb = new StringBuilder();
				sb.Append("{");
				bool start = true;
				foreach (KeyValuePair<String, STJson> item in _dict)
				{
					if (start)
						start = false;
					else
						sb.Append(",");
					sb.Append(STJson.jsonStrToString("\"", item.Key) + ":" + item.Value.ToString());
				}
				sb.Append("}");

				return sb.ToString();
			}
		
			public void replaceLinkMap(String key, char mode, Dictionary<String, STJson> jsonMap, STJson jsonRoot, Regex patFilter, String replaceFilter)
			{
				if(key.Length != 0)
					this._dict.Remove(key);
				
				String[] entryKeys = new String[jsonMap.Count];
				STJson[] entryValues = new STJson[jsonMap.Count];
				int count = 0;
				foreach(KeyValuePair<String, STJson> entry in jsonMap)
				{
					entryKeys[count] = entry.Key;
					entryValues[count] = entry.Value;
					count ++;
				}
				
				for(int i = 0; i < count; i ++)
				{
					String key1 = entryKeys[i];
					
					// 如果存在复制前缀过滤，则首先对其进行过滤
					if(patFilter != null)
					{
						if (patFilter.IsMatch(key1))
							continue;
						
						if(replaceFilter != null)
							key1 = patFilter.Replace(key1, replaceFilter);
					}
					
					if(this.has(key1))
					{
						if(mode == 'I')
							continue;
						else if(mode == 'E')
							throw new Exception(String.Format("key [{0}] has been found in map", key));
					}
					
					STJson value = entryValues[i];
					if(value is STJsonLinkMap)
					{
						Dictionary<String, STJson> jsonMap1 = value.getLinkOneTail(jsonRoot).asJsonMap();
						replaceLinkMap(key1, mode, jsonMap1, jsonRoot, null, null);
					}
					else
					{
						this._dict[key1] = value.getLinkOneTail(jsonRoot);
					}
				}
			}
		}

		private class STJsonArray : STJson
		{
			private List<STJson> _list = new List<STJson>();

            public STJsonArray(String comment)
                : base(comment)
            {
            }

			public override bool isJsonList()
			{
				return true;
			}

			public override void addJson(Object key, STJson json)
			{
				_list.Add(json);
			}

			public override List<STJson> asJsonList()
			{
				return _list;
			}

			public override object getValue()
			{
				return _list;
			}

			public override string getType()
			{
				return "L";
			}

			public override STJson safeGetJson(object key)
			{
				return _list[(int)key];
			}

			public override string ToString()
			{
				StringBuilder sb = new StringBuilder();
				sb.Append("[");
				bool start = true;
				for(int i = 0; i < _list.Count; i ++)
				{
					if(start)
						start = false;
					else
						sb.Append(",");
					sb.Append(_list[i].ToString());
				}
				sb.Append("]");

				return sb.ToString();
			}

			public void replaceLinkList(int index, List<STJson> list, STJson jsonRoot)
			{
				_list.RemoveAt(index);

				if (list.Count == 0)
					return;

				STJson[] copyList = list.ToArray();
				for (int i = 0; i < copyList.Length; i++)
					index = insertLinkItem(index, copyList[i], jsonRoot);
			}

			protected int insertLinkItem(int index, STJson jsonValue, STJson jsonRoot)
			{
				if(jsonValue is STJsonLinkList)
				{
					List<STJson> jsonList = jsonValue.getLinkOneTail(jsonRoot).asJsonList();
					STJson[] copyList = jsonList.ToArray();
					for(int i = 0; i < copyList.Length; i ++)
						index = insertLinkItem(index, copyList[i], jsonRoot);

					return index;
				}
				else
				{
					_list.Insert(index, jsonValue.getLinkOneTail(jsonRoot));
					return index + 1;
				}
			}
		}

		public abstract class STJSonWriteBack : STJson
		{
			protected String _link;
    		protected STJson _parent;
    		protected Object _key;
			protected bool _writed = false;

			protected STJSonWriteBack(String link) : base(null)
			{
				_link = link;
			}
			
    		public abstract STJson writeBack(STJson rootJson, bool throwDup);

    		public void setWriteBackParent(STJson parent, Object key)
    		{
    			_parent = parent; 
    			_key = key;
    		}
	    	
    		protected bool isDupWriteBack(bool throwDup)
    		{
				if(_writed)
				{
					if(throwDup)
						throw new Exception(String.Format("dup writeBack for link [{0}]", _link));
					else
						return true;
				}
				
    			_writed = true;
	    		
    			return false;
    		}
	    	
    		protected void repaceOneJson(STJson jsonReplace, STJson jsonRoot)
    		{
    			if(_parent == null)
    				return;
	    		
    			jsonReplace = jsonReplace.getLinkOneTail(jsonRoot);
	    		
    			if(_parent is STJsonArray)
    				((STJsonArray)_parent).asJsonList()[(int)_key] = jsonReplace;
    			else if(_parent is STJsonMap)
					((STJsonMap)_parent).asJsonMap()[_key.ToString()] = jsonReplace;
    			else
    				throw new Exception("unsupport parent json");
    		}
	    	
    		protected void replaceJsonList(STJson jsonList, STJson jsonRoot)
    		{
    			if(_parent == null)
    				return;

				if (!(_parent is STJsonArray))
    				throw new Exception("parent json must be ArrayJson");
	  		
    			jsonList = jsonList.getLinkOneTail(jsonRoot);
	    		
    			if(!jsonList.isJsonList())
    				throw new Exception("linked json must be ArrayJson");

				((STJsonArray)_parent).replaceLinkList((int)_key, jsonList.asJsonList(), jsonRoot);
    		}
	    
    		protected void replaceJsonMap(STJson jsonMap, char mode, STJson jsonRoot, Regex patFilter, String replaceFilter)
    		{
    			if(_parent == null)
    				return;

				if (!(_parent is STJsonMap))
    				throw new Exception("parent json must be ObjectJson");
	  		
    			jsonMap = jsonMap.getLinkOneTail(jsonRoot);
	    		
    			if(!jsonMap.isJsonMap())
    				throw new Exception("linked json must be ObjectJson");

				((STJsonMap)_parent).replaceLinkMap((String)_key, mode, jsonMap.asJsonMap(), jsonRoot, patFilter, replaceFilter);
    		}

		}

		public class STJsonLinkOne : STJSonWriteBack
		{
			public STJsonLinkOne(String link)
				: base(link)
			{
			}

			protected override STJson getLinkOneTail(STJson rootJson)
			{
				STJson json = writeBack(rootJson, true);
				
				return json;
			}
			
			public override STJson writeBack(STJson jsonRoot, bool throwDup)
    		{
				if(isDupWriteBack(throwDup))
					return null;
				
    			STJson json = jsonRoot.getJsonPath(_link, false).getLinkOneTail(jsonRoot);
    			repaceOneJson(json, jsonRoot);
	    		
    			return json;
    		}
			
			public String toString() { return "@one:" + _link; }

		}

		class STJsonLinkList : STJSonWriteBack
		{
			public STJsonLinkList(String link) : base(link)
			{
			}

			protected override STJson getLinkOneTail(STJson rootJson)
			{
				STJson json = writeBack(rootJson, true);
				
				return json;
			}

			public override STJson writeBack(STJson rootJson, bool throwDup)
    		{
				if(isDupWriteBack(throwDup))
					return null;
				
    			STJson json = rootJson.getJsonPath(_link, false);
    			replaceJsonList(json, rootJson);
    			return _parent;
    		}
			
			public String toString() { return "@list:" + _link; }
		}

		class STJsonLinkMap : STJSonWriteBack
		{
			private char _mode;
			private Regex _patFilter;
			private String _replaceFilter;
			
			public STJsonLinkMap(String link, char mode, String regFilter, String replaceFilter) : base(link)
			{
				_mode = mode;
				_patFilter = (regFilter == null || regFilter.Length == 0) ? null : new Regex(regFilter);
				_replaceFilter = replaceFilter;
			}
			
			protected override STJson getLinkOneTail(STJson rootJson)
			{
				STJson json = writeBack(rootJson, true);
				
				return json;
			}

			public override STJson writeBack(STJson rootJson, bool throwDup)
    		{
				if(isDupWriteBack(throwDup))
					return null;
				
    			STJson json = rootJson.getJsonPath(_link, false);
    			replaceJsonMap(json, _mode, rootJson, _patFilter, _replaceFilter);
    			return _parent;
    		}

			public String toString() { return "@map:" + _link; }
		}


		public class ParseJsonCharIterator : ParseCharIterator
		{
			private String _filePath;
			public List<String> _parsePath = new List<String>();
			public List<STJSonWriteBack> _writeBackList = new List<STJSonWriteBack>();

			public ParseJsonCharIterator(String str, bool modifyMode, String filePath)
				: base(str, modifyMode)
			{
				_filePath = filePath;
			}

			public String getFilePath()
			{
				return _filePath;
			}

			public String[] parseMacroString(char end)
			{
				char ch;
				List<String> list = new List<string>();
				StringBuilder sb = new StringBuilder();
				while ((ch = this.next(true)) != '\x0')
				{
					if (ch == '\\')
					{
						ch = this.next(true);
						switch (ch)
						{
						case 'r': ch = '\r'; break;
						case 'n': ch = '\n'; break;
						case 'b': ch = '\b'; break;
						case 't': ch = '\t'; break;
						}
					}
					else if (ch == end)
					{
						list.Add(sb.ToString());
						return list.ToArray();
					}
					else if (ch == ',')
					{
						list.Add(sb.ToString());
						sb.Length = 0;
					}
					else
					{
						sb.Append(ch);
					}
				}

				this.throwError("String is not finish");
				return null;
			}

			public void skipCTypeSpaceAndComment()
			{
				while (true)
				{
					char ch = this.next(true);

					// 如果发现空格符，则搜索下一个字符
					if (ch == ' ' || ch == '\t' || ch == '\r' || ch == '\n')
						continue;

					if (ch == '/')
					{
						char chNext = this.next(false);

						// 如果发现 "//" 则跳过行注释
						if (chNext == '/')
						{
							this.next(true);
							appendComment(nextCTypeLineComment());
							continue;
						}
						// 如果发现 "/*" 则跳过块注释
						else if (chNext == '*')
						{
							this.next(true);
							appendComment(nextCTypeBlockComment());
							continue;
						}
						// 如果只是个普通的符号，则抛出异常
						else
							this.throwError("invalid char");
					}

					break;
				}

				// 退回到前一个非空字符
				this.prev();
			}



		}

	}

    public class ParseCharIterator
    {
        protected String _text;
		protected int _pos = 0;
		protected bool _modifyMode = false;
		protected StringBuilder _sbComment = null;

		public ParseCharIterator(String str, bool modifyMode)
        {
            _text = str;
			_modifyMode = modifyMode;
        }

		public bool isModifyMode()
		{
			return _modifyMode;
		}

		public void insertParseText(String text)
		{
			_text = _text.Insert(_pos, text);
		}

		public int charPos
		{
			get{return _pos;}
			set{_pos = value;}
		}

        public void throwError(String errMsg)
        {
            throw new Exception(String.Format("parse json error at [{0}]:{1}\n>>>>>>:\n{2}\n====>error\n{3}\n<<<<<<",
                _pos,
                errMsg,
				(_pos > 0 ? _text.Substring(0, Math.Min(_pos, _text.Length)) : "").Replace("\r\n", "\n").Replace("\n", "\r\n"),
				(_pos < (_text.Length - 1) ? _text.Substring(_pos) : "")).Replace("\r\n", "\n").Replace("\n", "\r\n"));
        }

		public String getComment(bool clear)
		{
			if (!_modifyMode)
				return null;

			if (_sbComment == null)
				return "";

			String ret = _sbComment.ToString();
			if (clear)
				_sbComment = null;

			return ret;
		}

        public void prev()
        {
            if (_pos == 0 || _pos > _text.Length)
                return;

            _pos--;
        }

		public String jumpToString(String value)
		{
			if ((_pos + value.Length) >= _text.Length)
				return null;

			int pos = _text.IndexOf(value, _pos);
			if(pos < 0)
				return null;

			int orgPos = _pos;
			_pos = pos + value.Length;
			int len = _pos - orgPos - value.Length;
			return len > 0 ? _text.Substring(orgPos, len) : "";
		}

        public bool nextString(String value)
        {
            if ((_pos + value.Length) > _text.Length)
                return false;

            if (_text.Substring(_pos, value.Length) != value)
                return false;

            _pos += value.Length;
            return true;
        }

        public char next(Boolean moveNext)
        {
            if (_pos >= _text.Length)
            {
                _pos = _text.Length + 1;
                return '\x0';
            }
            char ch = _text[_pos];
            if (moveNext)
                _pos++;
            return ch;
        }

		public void skipSpace()
		{
            while (true)
            {
                char ch = this.next(true);

                // 如果发现空格符，则搜索下一个字符
                if (ch == ' ' || ch == '\t' || ch == '\r' || ch == '\n')
                    continue;

				break;
			}

			// 退回到前一个非空字符
			this.prev();
		}

        protected void appendComment(String comment)
        {
			if (!_modifyMode || comment == null)
				return;

			comment = comment.Replace("\r", "");
			if (this._sbComment == null)
			{
				_sbComment = new StringBuilder();
				_sbComment.Append(comment);
			}
			else
				_sbComment.Append("\n" + comment);
        }

        public double parseNumber(char first)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(first);

            while (true)
            {
                char ch = this.next(true);
                if (ch == '.' || (ch >= '0' && ch <= '9'))
                {
                    sb.Append(ch);
                    continue;
                }
                break;
            }
            this.prev();
            double value;
            if (!Double.TryParse(sb.ToString(), out value))
                this.throwError("invalid number");

            return value;
        }

		public bool isAlphiChar(char ch)
		{
			return (ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z') || (ch >= '0' && ch <= '9') || ch == '_';
		}

		public bool isNumberChar(char ch)
		{
			return ch >= '0' && ch <= '9';
		}

		public String nextCTypeLineComment()
		{
			char ch;
			StringBuilder sbRet = _modifyMode ? new StringBuilder() : null;
			while ((ch = this.next(true)) != '\x0')
			{
				if (ch == '\n')
					return _modifyMode ? sbRet.ToString() : null;
				if (_modifyMode)
					sbRet.Append(ch);
			}
			return _modifyMode ? sbRet.ToString() : null;
		}

		public String nextCTypeBlockComment()
		{
			char ch;
			StringBuilder sbRet = _modifyMode ? new StringBuilder() : null;
			while ((ch = this.next(true)) != '\x0')
			{
				if (ch == '*' && this.next(false) == '/')
				{
					ch = this.next(true);
					return _modifyMode ? sbRet.ToString() : null;
				}

				if (_modifyMode)
					sbRet.Append(ch);
			}

			this.throwError("block comment is not finish");
			return null;
		}

		public String nextCTypeString(char end)
		{
			char ch;
			StringBuilder sb = new StringBuilder();
			while ((ch = this.next(true)) != '\x0')
			{
				if (ch == '\\')
				{
					ch = this.next(true);
					switch (ch)
					{
					case 'r': ch = '\r'; break;
					case 'n': ch = '\n'; break;
					case 'b': ch = '\b'; break;
					case 't': ch = '\t'; break;
					}
				}
				else if (ch == end)
				{
					return sb.ToString();
				}

				sb.Append(ch);
			}

			this.throwError("String is not finish");
			return null;
		}


    }

}
