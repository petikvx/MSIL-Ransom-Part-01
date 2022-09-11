using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;

[Serializable]
public abstract class GClass0
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

	public GClass0 this[string string_0]
	{
		get
		{
			if (this is GClass2)
			{
				return ((GClass2)this)[string_0];
			}
			return null;
		}
		set
		{
			if (this is GClass2)
			{
				((GClass2)this)[string_0] = value;
			}
		}
	}

	public GClass0 this[int int_0]
	{
		get
		{
			if (this is GClass3)
			{
				return ((GClass3)this)[int_0];
			}
			return null;
		}
		set
		{
			if (this is GClass3)
			{
				((GClass3)this)[int_0] = value;
			}
		}
	}

	public bool method_0(string string_0)
	{
		if (this is GClass2)
		{
			return ((GClass2)this).method_4(string_0);
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
				stringBuilder.Append("\\\"");
				continue;
			case '\b':
				stringBuilder.Append("\\b");
				continue;
			case '\t':
				stringBuilder.Append("\\t");
				continue;
			case '\n':
				stringBuilder.Append("\\n");
				continue;
			case '\f':
				stringBuilder.Append("\\f");
				continue;
			case '\r':
				stringBuilder.Append("\\r");
				continue;
			case '\\':
				stringBuilder.Append("\\\\");
				continue;
			case '/':
				stringBuilder.Append(c);
				continue;
			}
			if (c < ' ')
			{
				stringBuilder.Append("\\u00" + Convert.ToByte(c).ToString("x2").ToUpper());
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
			if (string_0[i] != '\\')
			{
				stringBuilder.Append(string_0[i]);
				continue;
			}
			i++;
			switch (string_0[i])
			{
			case '"':
				stringBuilder.Append(string_0[i]);
				break;
			case '\\':
				stringBuilder.Append(string_0[i]);
				break;
			case '/':
				stringBuilder.Append(string_0[i]);
				break;
			case 'f':
				stringBuilder.Append('\f');
				break;
			case 'b':
				stringBuilder.Append('\b');
				break;
			case 'n':
				stringBuilder.Append('\n');
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
			}
		}
		return stringBuilder.ToString();
	}

	[SpecialName]
	public static GClass0 smethod_2(string string_0)
	{
		return new GClass1(string_0);
	}

	[SpecialName]
	public static GClass0 smethod_3(int int_0)
	{
		return new GClass1(int_0);
	}

	[SpecialName]
	public static GClass0 smethod_4(long long_0)
	{
		return new GClass1(long_0);
	}

	[SpecialName]
	public static GClass0 smethod_5(float float_0)
	{
		return new GClass1(float_0);
	}

	[SpecialName]
	public static GClass0 smethod_6(double double_0)
	{
		return new GClass1(double_0);
	}

	[SpecialName]
	public static GClass0 smethod_7(decimal decimal_0)
	{
		return new GClass1(decimal_0);
	}

	[SpecialName]
	public static GClass0 smethod_8(bool bool_0)
	{
		return new GClass1(bool_0);
	}

	[SpecialName]
	public static string smethod_9(GClass0 gclass0_0)
	{
		return gclass0_0?.ToString();
	}

	[SpecialName]
	public static int smethod_10(GClass0 gclass0_0)
	{
		return (int)Convert.ChangeType(((GClass1)gclass0_0).Object_0, typeof(int));
	}

	[SpecialName]
	public static long smethod_11(GClass0 gclass0_0)
	{
		return (long)Convert.ChangeType(((GClass1)gclass0_0).Object_0, typeof(long));
	}

	[SpecialName]
	public static float smethod_12(GClass0 gclass0_0)
	{
		return (float)Convert.ChangeType(((GClass1)gclass0_0).Object_0, typeof(float));
	}

	[SpecialName]
	public static double smethod_13(GClass0 gclass0_0)
	{
		return (double)Convert.ChangeType(((GClass1)gclass0_0).Object_0, typeof(double));
	}

	[SpecialName]
	public static decimal smethod_14(GClass0 gclass0_0)
	{
		return (decimal)Convert.ChangeType(((GClass1)gclass0_0).Object_0, typeof(decimal));
	}

	[SpecialName]
	public static bool smethod_15(GClass0 gclass0_0)
	{
		return (bool)Convert.ChangeType(((GClass1)gclass0_0).Object_0, typeof(bool));
	}

	public static GClass0 smethod_16(string string_0)
	{
		return smethod_17(smethod_20(string_0));
	}

	private static GClass0 smethod_17(string string_0)
	{
		GClass0 result = null;
		if (string_0.Length == 0)
		{
			return result;
		}
		_ = string_0[0];
		switch (string_0[0])
		{
		case '{':
		{
			GClass2 gClass2 = new GClass2();
			List<string> list = smethod_18(string_0.Substring(1, string_0.Length - 2));
			string[] array = new string[2];
			foreach (string item in list)
			{
				array = smethod_19(item);
				if (array[0] != null)
				{
					gClass2[smethod_1(array[0])] = smethod_17(array[1]);
				}
			}
			result = gClass2;
			break;
		}
		case 't':
			result = new GClass1(true);
			break;
		case 'n':
			result = null;
			break;
		default:
		{
			long result2 = 0L;
			if (long.TryParse(string_0, NumberStyles.Any, CultureInfo.InvariantCulture, out result2))
			{
				result = ((result2 > 2147483647L || result2 < -2147483648L) ? new GClass1(result2) : new GClass1((int)result2));
				break;
			}
			decimal result3 = default(decimal);
			if (decimal.TryParse(string_0, NumberStyles.Any, CultureInfo.InvariantCulture, out result3))
			{
				result = new GClass1(result3);
			}
			break;
		}
		case 'f':
			result = new GClass1(false);
			break;
		case '[':
		{
			GClass3 gClass = new GClass3();
			foreach (string item2 in smethod_18(string_0.Substring(1, string_0.Length - 2)))
			{
				if (item2.Length > 0)
				{
					gClass.method_2(smethod_17(item2));
				}
			}
			result = gClass;
			break;
		}
		case '"':
			result = new GClass1(smethod_1(string_0.Substring(1, string_0.Length - 2)));
			break;
		}
		return result;
	}

	private static List<string> smethod_18(string string_0)
	{
		List<string> list = new List<string>();
		int num = 0;
		int num2 = 0;
		bool flag = false;
		for (int i = 0; i < string_0.Length; i++)
		{
			switch (string_0[i])
			{
			case ']':
			case '}':
				if (!flag)
				{
					num--;
				}
				break;
			case '"':
				if (i == 0 || string_0[i - 1] != '\\')
				{
					flag = !flag;
				}
				break;
			case ',':
				if (!flag && num == 0)
				{
					list.Add(string_0.Substring(num2, i - num2));
					num2 = i + 1;
				}
				break;
			case '[':
			case '{':
				if (!flag)
				{
					num++;
				}
				break;
			}
		}
		list.Add(string_0.Substring(num2));
		return list;
	}

	private static string[] smethod_19(string string_0)
	{
		string[] array = new string[2];
		bool flag = false;
		bool flag2 = false;
		int num = 0;
		while (num < string_0.Length && !flag2)
		{
			if (string_0[num] == '"' && (num == 0 || string_0[num - 1] != '\\'))
			{
				if (flag)
				{
					array[0] = string_0.Substring(1, num - 1);
					array[1] = string_0.Substring(num + 2);
					flag2 = true;
				}
				else
				{
					flag = true;
					num++;
				}
			}
			else
			{
				num++;
			}
		}
		return array;
	}

	private static string smethod_20(string string_0)
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
			text2 += "\t";
		}
		bool flag = false;
		string text3 = string.Empty;
		for (int j = 0; j < text.Length; j++)
		{
			switch (text[j])
			{
			case ']':
			case '}':
				if (!flag)
				{
					text3 = text3.Substring(0, text3.Length - text2.Length);
					text = text.Insert(j, "\n" + text3);
					j += text3.Length + 1;
				}
				break;
			case '[':
			case '{':
				if (!flag)
				{
					text3 += text2;
					text = text.Insert(j + 1, "\n" + text3);
				}
				break;
			case '"':
				if (j == 0 || text[j - 1] != '\\')
				{
					flag = !flag;
				}
				break;
			case ',':
				if (!flag)
				{
					text = text.Insert(j + 1, "\n" + text3);
				}
				break;
			case ':':
				if (!flag)
				{
					text = text.Insert(j + 1, " ");
				}
				break;
			}
		}
		return text;
	}
}
