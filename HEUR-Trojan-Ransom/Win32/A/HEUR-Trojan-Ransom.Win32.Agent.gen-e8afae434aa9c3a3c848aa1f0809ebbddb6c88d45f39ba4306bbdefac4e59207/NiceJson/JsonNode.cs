using System;
using System.Collections.Generic;
using System.Globalization;
using ns4;

namespace NiceJson;

[Serializable]
public abstract class JsonNode
{
	protected const char PP_IDENT_CHAR = '\t';

	protected const int PP_IDENT_COUNT = 1;

	protected const bool ESCAPE_SOLIDUS = false;

	protected const char CHAR_CURLY_OPEN = '{';

	protected const char CHAR_CURLY_CLOSED = '}';

	protected const char CHAR_SQUARED_OPEN = '[';

	protected const char CHAR_SQUARED_CLOSED = ']';

	protected const char CHAR_COLON = ':';

	protected const char CHAR_COMMA = ',';

	protected const char CHAR_QUOTE = '"';

	protected const char CHAR_NULL_LITERAL = 'n';

	protected const char CHAR_TRUE_LITERAL = 't';

	protected const char CHAR_FALSE_LITERAL = 'f';

	protected const char CHAR_SPACE = ' ';

	protected const char CHAR_BS = '\b';

	protected const char CHAR_FF = '\f';

	protected const char CHAR_RF = '\r';

	protected const char CHAR_NL = '\n';

	protected const char CHAR_HT = '\t';

	protected const char CHAR_ESCAPE = '\\';

	protected const char CHAR_SOLIDUS = '/';

	protected const char CHAR_ESCAPED_QUOTE = '"';

	protected const char CHAR_N = 'n';

	protected const char CHAR_R = 'r';

	protected const char CHAR_B = 'b';

	protected const char CHAR_T = 't';

	protected const char CHAR_F = 'f';

	protected const char CHAR_U = 'u';

	protected const string STRING_ESCAPED_BS = "\\b";

	protected const string STRING_ESCAPED_FF = "\\f";

	protected const string STRING_ESCAPED_RF = "\\r";

	protected const string STRING_ESCAPED_NL = "\\n";

	protected const string STRING_ESCAPED_TAB = "\\t";

	protected const string STRING_ESCAPED_ESCAPE = "\\\\";

	protected const string STRING_ESCAPED_SOLIDUS = "\\/";

	protected const string STRING_ESCAPED_ESCAPED_QUOTE = "\\\"";

	protected const string STRING_SPACE = " ";

	protected const string STRING_LITERAL_NULL = "null";

	protected const string STRING_LITERAL_TRUE = "true";

	protected const string STRING_LITERAL_FALSE = "false";

	protected const string STRING_ESCAPED_UNICODE_INIT = "\\u00";

	public JsonNode this[string string_0]
	{
		get
		{
			if (this is JsonObject)
			{
				return ((JsonObject)this)[string_0];
			}
			return null;
		}
		set
		{
			if (this is JsonObject)
			{
				((JsonObject)this)[string_0] = value;
			}
		}
	}

	public JsonNode this[int int_0]
	{
		get
		{
			if (this is JsonArray)
			{
				return ((JsonArray)this)[int_0];
			}
			return null;
		}
		set
		{
			if (this is JsonArray)
			{
				((JsonArray)this)[int_0] = value;
			}
		}
	}

	internal static JsonNode smethod_0(string string_0)
	{
		JsonNode result = null;
		if (string_0.Length == 0)
		{
			return result;
		}
		_ = string_0[0];
		switch (string_0[0])
		{
		case 'f':
			result = new JsonBasic(false);
			break;
		case '[':
		{
			JsonArray jsonArray = new JsonArray();
			foreach (string item in Class16.smethod_1(string_0.Substring(1, string_0.Length - 2)))
			{
				if (item.Length > 0)
				{
					jsonArray.Add(smethod_0(item));
				}
			}
			result = jsonArray;
			break;
		}
		case '"':
			result = new JsonBasic(Class16.smethod_19(string_0.Substring(1, string_0.Length - 2)));
			break;
		case '{':
		{
			JsonObject jsonObject = new JsonObject();
			List<string> list = Class16.smethod_1(string_0.Substring(1, string_0.Length - 2));
			string[] array = new string[2];
			foreach (string item2 in list)
			{
				array = Class16.smethod_58(item2);
				if (array[0] != null)
				{
					jsonObject[Class16.smethod_19(array[0])] = smethod_0(array[1]);
				}
			}
			result = jsonObject;
			break;
		}
		default:
		{
			long result2 = 0L;
			if (long.TryParse(string_0, NumberStyles.Any, CultureInfo.InvariantCulture, out result2))
			{
				result = ((result2 > 2147483647L || result2 < -2147483648L) ? new JsonBasic(result2) : new JsonBasic((int)result2));
				break;
			}
			decimal result3 = default(decimal);
			if (decimal.TryParse(string_0, NumberStyles.Any, CultureInfo.InvariantCulture, out result3))
			{
				result = new JsonBasic(result3);
			}
			break;
		}
		case 't':
			result = new JsonBasic(true);
			break;
		case 'n':
			result = null;
			break;
		}
		return result;
	}

	public abstract string vmethod_0();
}
