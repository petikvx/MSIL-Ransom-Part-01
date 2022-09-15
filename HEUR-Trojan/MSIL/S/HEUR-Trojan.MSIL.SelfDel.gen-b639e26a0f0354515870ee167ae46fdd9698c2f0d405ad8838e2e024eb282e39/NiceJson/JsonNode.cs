using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using RU;

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

	public JsonNode this[string key]
	{
		get
		{
			if (this is JsonObject)
			{
				return ((JsonObject)this)[key];
			}
			return null;
		}
		set
		{
			if (this is JsonObject)
			{
				((JsonObject)this)[key] = value;
			}
		}
	}

	public JsonNode this[int index]
	{
		get
		{
			if (this is JsonArray)
			{
				return ((JsonArray)this)[index];
			}
			return null;
		}
		set
		{
			if (this is JsonArray)
			{
				((JsonArray)this)[index] = value;
			}
		}
	}

	public bool method_0(string string_0)
	{
		if (this is JsonObject)
		{
			return ((JsonObject)this).method_4(string_0);
		}
		return false;
	}

	protected static string smethod_0(string string_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (char c in string_0)
		{
			switch (c)
			{
			case '"':
				stringBuilder.Append(Class22.smethod_0("\ue420\ue45e", 58464));
				continue;
			case '\b':
				stringBuilder.Append(Class22.smethod_0("\uf299\uf2a7", 62145));
				continue;
			case '\t':
				stringBuilder.Append(Class22.smethod_0("\ue525\ue50d", 58729));
				continue;
			case '\n':
				stringBuilder.Append(Class22.smethod_0("\uecf3\uecc1", 60546));
				continue;
			case '\f':
				stringBuilder.Append(Class22.smethod_0("\uf4a3\uf499", 62683));
				continue;
			case '\r':
				stringBuilder.Append(Class22.smethod_0("\ue533\ue51d", 58731));
				continue;
			case '\\':
				stringBuilder.Append(Class22.smethod_0("\ue8bb\ue8bb", 59558));
				continue;
			case '/':
				stringBuilder.Append(c);
				continue;
			}
			if (c < ' ')
			{
				stringBuilder.Append(Class22.smethod_0("\uf8ab\uf882\uf8c7\uf8c7", 63701) + Convert.ToByte(c).ToString(Class22.smethod_0("\ue0af\ue0e5", 57494)).ToUpper());
			}
			else
			{
				stringBuilder.Append(c);
			}
		}
		return stringBuilder.ToString();
	}

	protected static string smethod_1(string string_0)
	{
		StringBuilder stringBuilder = new StringBuilder(string_0.Length);
		for (int i = 0; i < string_0.Length; i++)
		{
			if (string_0[i] == '\\')
			{
				i++;
				switch (string_0[i])
				{
				case '\\':
					stringBuilder.Append(string_0[i]);
					break;
				case '/':
					stringBuilder.Append(string_0[i]);
					break;
				case '"':
					stringBuilder.Append(string_0[i]);
					break;
				case 'f':
					stringBuilder.Append('\f');
					break;
				case 'b':
					stringBuilder.Append('\b');
					break;
				case 'r':
					stringBuilder.Append('\r');
					break;
				default:
					stringBuilder.Append(string_0[i]);
					break;
				case 't':
					stringBuilder.Append('\t');
					break;
				case 'u':
					stringBuilder.Append((char)int.Parse(string_0.Substring(i + 1, 4), NumberStyles.AllowHexSpecifier));
					i += 4;
					break;
				case 'n':
					stringBuilder.Append('\n');
					break;
				}
			}
			else
			{
				stringBuilder.Append(string_0[i]);
			}
		}
		return stringBuilder.ToString();
	}

	public static implicit operator JsonNode(string value)
	{
		return new JsonBasic(value);
	}

	public static implicit operator JsonNode(int value)
	{
		return new JsonBasic(value);
	}

	public static implicit operator JsonNode(long value)
	{
		return new JsonBasic(value);
	}

	public static implicit operator JsonNode(float value)
	{
		return new JsonBasic(value);
	}

	public static implicit operator JsonNode(double value)
	{
		return new JsonBasic(value);
	}

	public static implicit operator JsonNode(decimal value)
	{
		return new JsonBasic(value);
	}

	public static implicit operator JsonNode(bool value)
	{
		return new JsonBasic(value);
	}

	public static implicit operator string(JsonNode value)
	{
		return value?.ToString();
	}

	public static implicit operator int(JsonNode value)
	{
		return (int)Convert.ChangeType(((JsonBasic)value).ValueObject, typeof(int));
	}

	public static implicit operator long(JsonNode value)
	{
		return (long)Convert.ChangeType(((JsonBasic)value).ValueObject, typeof(long));
	}

	public static implicit operator float(JsonNode value)
	{
		return (float)Convert.ChangeType(((JsonBasic)value).ValueObject, typeof(float));
	}

	public static implicit operator double(JsonNode value)
	{
		return (double)Convert.ChangeType(((JsonBasic)value).ValueObject, typeof(double));
	}

	public static implicit operator decimal(JsonNode value)
	{
		return (decimal)Convert.ChangeType(((JsonBasic)value).ValueObject, typeof(decimal));
	}

	public static implicit operator bool(JsonNode value)
	{
		return (bool)Convert.ChangeType(((JsonBasic)value).ValueObject, typeof(bool));
	}

	public static JsonNode smethod_2(string string_0)
	{
		return smethod_3(smethod_6(string_0));
	}

	private static JsonNode smethod_3(string string_0)
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
			foreach (string item in smethod_4(string_0.Substring(1, string_0.Length - 2)))
			{
				if (item.Length > 0)
				{
					jsonArray.method_2(smethod_3(item));
				}
			}
			result = jsonArray;
			break;
		}
		case '"':
			result = new JsonBasic(smethod_1(string_0.Substring(1, string_0.Length - 2)));
			break;
		case '{':
		{
			JsonObject jsonObject = new JsonObject();
			List<string> list = smethod_4(string_0.Substring(1, string_0.Length - 2));
			string[] array = new string[2];
			foreach (string item2 in list)
			{
				array = smethod_5(item2);
				if (array[0] != null)
				{
					jsonObject[smethod_1(array[0])] = smethod_3(array[1]);
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

	private static List<string> smethod_4(string string_0)
	{
		List<string> list = new List<string>();
		int num = 0;
		int num2 = 0;
		bool flag = false;
		for (int i = 0; i < string_0.Length; i++)
		{
			switch (string_0[i])
			{
			case ',':
				if (!flag && num == 0)
				{
					list.Add(string_0.Substring(num2, i - num2));
					num2 = i + 1;
				}
				break;
			case '"':
				if (i == 0 || string_0[i - 1] != '\\')
				{
					flag = !flag;
				}
				break;
			case '[':
			case '{':
				if (!flag)
				{
					num++;
				}
				break;
			case ']':
			case '}':
				if (!flag)
				{
					num--;
				}
				break;
			}
		}
		list.Add(string_0.Substring(num2));
		return list;
	}

	private static string[] smethod_5(string string_0)
	{
		string[] array = new string[2];
		bool flag = false;
		bool flag2 = false;
		int num = 0;
		while (num < string_0.Length && !flag2)
		{
			if (string_0[num] == '"' && (num == 0 || string_0[num - 1] != '\\'))
			{
				if (!flag)
				{
					flag = true;
					num++;
				}
				else
				{
					array[0] = string_0.Substring(1, num - 1);
					array[1] = string_0.Substring(num + 2);
					flag2 = true;
				}
			}
			else
			{
				num++;
			}
		}
		return array;
	}

	private static string smethod_6(string string_0)
	{
		int length = string_0.Length;
		char[] array = new char[length];
		int length2 = 0;
		bool flag = true;
		for (int i = 0; i < length; i++)
		{
			char c = string_0[i];
			if (c == '"' && (i == 0 || string_0[i - 1] != '\\'))
			{
				flag = !flag;
			}
			if (!flag || (c != ' ' && c != '\r' && c != '\n' && c != '\t' && c != '\b' && c != '\f'))
			{
				array[length2++] = c;
			}
		}
		return new string(array, 0, length2);
	}

	public abstract string vmethod_0();

	public string method_1()
	{
		string text = vmethod_0();
		string text2 = string.Empty;
		for (int i = 0; i < 1; i++)
		{
			text2 += Class22.smethod_0("\ueabe", 59943);
		}
		bool flag = false;
		string text3 = string.Empty;
		for (int j = 0; j < text.Length; j++)
		{
			switch (text[j])
			{
			case ':':
				if (!flag)
				{
					text = text.Insert(j + 1, Class22.smethod_0("\uea47", 59942));
				}
				break;
			case ',':
				if (!flag)
				{
					text = text.Insert(j + 1, Class22.smethod_0("\uf2f1", 62170) + text3);
				}
				break;
			case '"':
				if (j == 0 || text[j - 1] != '\\')
				{
					flag = !flag;
				}
				break;
			case ']':
			case '}':
				if (!flag)
				{
					text3 = text3.Substring(0, text3.Length - text2.Length);
					text = text.Insert(j, Class22.smethod_0("\uf2f1", 62170) + text3);
					j += text3.Length + 1;
				}
				break;
			case '[':
			case '{':
				if (!flag)
				{
					text3 += text2;
					text = text.Insert(j + 1, Class22.smethod_0("\uf2f1", 62170) + text3);
				}
				break;
			}
		}
		return text;
	}
}
