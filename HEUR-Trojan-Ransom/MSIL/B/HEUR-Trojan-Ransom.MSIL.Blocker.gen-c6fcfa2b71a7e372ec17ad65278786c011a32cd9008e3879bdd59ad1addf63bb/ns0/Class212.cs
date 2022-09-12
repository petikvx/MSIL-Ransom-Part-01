using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Linq.JsonPath;
using ns1;
using ns13;
using ns15;
using ns18;
using ns19;
using ns5;

namespace ns0;

internal class Class212
{
	private static readonly char[] char_0 = new char[3] { '.', 'E', 'e' };

	internal readonly string string_0;

	[CompilerGenerated]
	private readonly List<Class198> list_0;

	internal int int_0;

	public List<Class198> Filters
	{
		[CompilerGenerated]
		get
		{
			return list_0;
		}
	}

	public Class212(string string_1)
	{
		Class112.smethod_0(string_1, "expression");
		string_0 = string_1;
		list_0 = new List<Class198>();
		method_0();
	}

	private void method_0()
	{
		int int_ = int_0;
		Class131.smethod_737(this);
		if (string_0.Length == int_0)
		{
			return;
		}
		if (string_0[int_0] == '$')
		{
			if (string_0.Length == 1)
			{
				return;
			}
			char c = string_0[int_0 + 1];
			if (c == '.' || c == '[')
			{
				int_0++;
				int_ = int_0;
			}
		}
		if (!method_1(Filters, int_, bool_0: false))
		{
			int index = int_0;
			Class131.smethod_737(this);
			if (int_0 < string_0.Length)
			{
				throw new JsonException("Unexpected character while parsing path: " + string_0[index]);
			}
		}
	}

	internal bool method_1(List<Class198> list_1, int int_1, bool bool_0)
	{
		bool bool_ = false;
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		while (int_0 < string_0.Length && !flag3)
		{
			char c = string_0[int_0];
			switch (c)
			{
			case ' ':
				if (int_0 < string_0.Length)
				{
					flag3 = true;
				}
				break;
			default:
				if (bool_0 && (c == '=' || c == '<' || c == '!' || c == '>' || c == '|' || c == '&'))
				{
					flag3 = true;
					break;
				}
				if (!flag)
				{
					int_0++;
					break;
				}
				throw new JsonException("Unexpected character following indexer: " + c);
			case ')':
			case ']':
				flag3 = true;
				break;
			case '(':
			case '[':
				if (int_0 > int_1)
				{
					string text2 = string_0.Substring(int_1, int_0 - int_1);
					if (text2 == "*")
					{
						text2 = null;
					}
					list_1.Add(Class131.smethod_296(text2, bool_));
					bool_ = false;
				}
				list_1.Add(Class131.smethod_88(c, bool_, this));
				bool_ = false;
				int_0++;
				int_1 = int_0;
				flag = true;
				flag2 = false;
				break;
			case '.':
				if (int_0 > int_1)
				{
					string text = string_0.Substring(int_1, int_0 - int_1);
					if (text == "*")
					{
						text = null;
					}
					list_1.Add(Class131.smethod_296(text, bool_));
					bool_ = false;
				}
				if (int_0 + 1 < string_0.Length && string_0[int_0 + 1] == '.')
				{
					bool_ = true;
					int_0++;
				}
				int_0++;
				int_1 = int_0;
				flag = false;
				flag2 = true;
				break;
			}
		}
		bool flag4 = int_0 == string_0.Length;
		if (int_0 > int_1)
		{
			string text3 = string_0.Substring(int_1, int_0 - int_1).TrimEnd(new char[0]);
			if (text3 == "*")
			{
				text3 = null;
			}
			list_1.Add(Class131.smethod_296(text3, bool_));
		}
		else if (flag2 && (flag4 || bool_0))
		{
			throw new JsonException("Unexpected end while parsing path.");
		}
		return flag4;
	}

	internal Class198 method_2(char char_1)
	{
		int num = int_0;
		int? num2 = null;
		List<int> list = null;
		int num3 = 0;
		int? start = null;
		int? end = null;
		int? step = null;
		while (true)
		{
			if (int_0 < string_0.Length)
			{
				char c = string_0[int_0];
				if (c == ' ')
				{
					num2 = int_0;
					Class131.smethod_737(this);
					continue;
				}
				if (c == char_1)
				{
					break;
				}
				switch (c)
				{
				case ',':
				{
					int num5 = (num2 ?? int_0) - num;
					if (num5 != 0)
					{
						if (list == null)
						{
							list = new List<int>();
						}
						string value2 = string_0.Substring(num, num5);
						list.Add(Convert.ToInt32(value2, CultureInfo.InvariantCulture));
						int_0++;
						Class131.smethod_737(this);
						num = int_0;
						num2 = null;
						continue;
					}
					throw new JsonException("Array index expected.");
				}
				case ':':
				{
					int num4 = (num2 ?? int_0) - num;
					if (num4 > 0)
					{
						int value = Convert.ToInt32(string_0.Substring(num, num4), CultureInfo.InvariantCulture);
						switch (num3)
						{
						case 0:
							start = value;
							break;
						case 1:
							end = value;
							break;
						default:
							step = value;
							break;
						}
					}
					num3++;
					int_0++;
					Class131.smethod_737(this);
					num = int_0;
					num2 = null;
					continue;
				}
				case '*':
					int_0++;
					Class131.smethod_30(this, "Path ended with open indexer.");
					Class131.smethod_737(this);
					if (string_0[int_0] != char_1)
					{
						throw new JsonException("Unexpected character while parsing path indexer: " + c);
					}
					return new Class199();
				}
				if (char.IsDigit(c) || c == '-')
				{
					if (!num2.HasValue)
					{
						int_0++;
						continue;
					}
					throw new JsonException("Unexpected character while parsing path indexer: " + c);
				}
				throw new JsonException("Unexpected character while parsing path indexer: " + c);
			}
			throw new JsonException("Path ended with open indexer.");
		}
		int num6 = (num2 ?? int_0) - num;
		if (list != null)
		{
			if (num6 == 0)
			{
				throw new JsonException("Array index expected.");
			}
			int item = Convert.ToInt32(string_0.Substring(num, num6), CultureInfo.InvariantCulture);
			list.Add(item);
			return new Class200(list);
		}
		if (num3 > 0)
		{
			if (num6 > 0)
			{
				int value3 = Convert.ToInt32(string_0.Substring(num, num6), CultureInfo.InvariantCulture);
				if (num3 == 1)
				{
					end = value3;
				}
				else
				{
					step = value3;
				}
			}
			return new Class201
			{
				Start = start,
				End = end,
				Step = step
			};
		}
		if (num6 == 0)
		{
			throw new JsonException("Array index expected.");
		}
		int value4 = Convert.ToInt32(string_0.Substring(num, num6), CultureInfo.InvariantCulture);
		return new Class199
		{
			Index = value4
		};
	}

	internal Class198 method_3(char char_1, bool bool_0)
	{
		int_0++;
		Class131.smethod_30(this, "Path ended with open indexer.");
		if (string_0[int_0] != '(')
		{
			throw new JsonException("Unexpected character while parsing path indexer: " + string_0[int_0]);
		}
		int_0++;
		Class213 class213_ = Class131.smethod_107(this);
		int_0++;
		Class131.smethod_30(this, "Path ended with open indexer.");
		Class131.smethod_737(this);
		if (string_0[int_0] != char_1)
		{
			throw new JsonException("Unexpected character while parsing path indexer: " + string_0[int_0]);
		}
		if (!bool_0)
		{
			return new Class203(class213_);
		}
		return new Class204(class213_);
	}

	internal JsonException method_4()
	{
		return new JsonException("Unexpected character while parsing path query: " + string_0[int_0]);
	}

	internal bool method_5(out object? object_0)
	{
		char c = string_0[int_0];
		if (c == '\'')
		{
			object_0 = method_6();
			return true;
		}
		if (!char.IsDigit(c) && c != '-')
		{
			switch (c)
			{
			case 't':
				if (Class131.smethod_730(this, "true"))
				{
					object_0 = true;
					return true;
				}
				break;
			case 'f':
				if (Class131.smethod_730(this, "false"))
				{
					object_0 = false;
					return true;
				}
				break;
			case 'n':
				if (Class131.smethod_730(this, "null"))
				{
					object_0 = null;
					return true;
				}
				break;
			case '/':
				object_0 = Class131.smethod_376(this);
				return true;
			}
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(c);
			int_0++;
			while (int_0 < string_0.Length)
			{
				c = string_0[int_0];
				if (c != ' ' && c != ')')
				{
					stringBuilder.Append(c);
					int_0++;
					continue;
				}
				string text = stringBuilder.ToString();
				if (text.IndexOfAny(char_0) != -1)
				{
					double result;
					bool result2 = double.TryParse(text, NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out result);
					object_0 = result;
					return result2;
				}
				long result3;
				bool result4 = long.TryParse(text, NumberStyles.Integer, CultureInfo.InvariantCulture, out result3);
				object_0 = result3;
				return result4;
			}
		}
		object_0 = null;
		return false;
	}

	private string method_6()
	{
		StringBuilder stringBuilder = new StringBuilder();
		int_0++;
		while (true)
		{
			char c;
			char value;
			if (int_0 < string_0.Length)
			{
				c = string_0[int_0];
				if (c == '\\' && int_0 + 1 < string_0.Length)
				{
					int_0++;
					c = string_0[int_0];
					if ((uint)c <= 92u)
					{
						if ((uint)c <= 39u)
						{
							if (c == '"' || c == '\'')
							{
								goto IL_0093;
							}
						}
						else if (c == '/' || c == '\\')
						{
							goto IL_0093;
						}
						goto IL_0125;
					}
					if ((uint)c <= 102u)
					{
						if (c != 'b')
						{
							if (c != 'f')
							{
								goto IL_0125;
							}
							value = '\f';
						}
						else
						{
							value = '\b';
						}
					}
					else if (c != 'n')
					{
						if (c != 'r')
						{
							if (c != 't')
							{
								goto IL_0125;
							}
							value = '\t';
						}
						else
						{
							value = '\r';
						}
					}
					else
					{
						value = '\n';
					}
					goto IL_00cf;
				}
				if (c == '\'')
				{
					break;
				}
				int_0++;
				stringBuilder.Append(c);
				continue;
			}
			throw new JsonException("Path ended with an open string.");
			IL_00cf:
			stringBuilder.Append(value);
			int_0++;
			continue;
			IL_0125:
			throw new JsonException("Unknown escape character: \\" + c);
			IL_0093:
			value = c;
			goto IL_00cf;
		}
		int_0++;
		return stringBuilder.ToString();
	}

	internal Class198 method_7(char char_1, bool bool_0)
	{
		List<string> list = null;
		string item;
		while (true)
		{
			if (int_0 < string_0.Length)
			{
				item = method_6();
				Class131.smethod_737(this);
				Class131.smethod_30(this, "Path ended with open indexer.");
				if (string_0[int_0] != char_1)
				{
					if (string_0[int_0] == ',')
					{
						int_0++;
						Class131.smethod_737(this);
						if (list == null)
						{
							list = new List<string>();
						}
						list.Add(item);
						continue;
					}
					throw new JsonException("Unexpected character while parsing path indexer: " + string_0[int_0]);
				}
				if (list == null)
				{
					break;
				}
				list.Add(item);
				if (!bool_0)
				{
					return new FieldMultipleFilter(list);
				}
				return new Class207(list);
			}
			throw new JsonException("Path ended with open indexer.");
		}
		return Class131.smethod_296(item, bool_0);
	}

	internal static IEnumerable<JToken> smethod_0(List<Class198> list_1, JToken jtoken_0, JToken jtoken_1, Class195? class195_0)
	{
		IEnumerable<JToken> enumerable = new JToken[1] { jtoken_1 };
		foreach (Class198 item in list_1)
		{
			enumerable = item.vmethod_0(jtoken_0, enumerable, class195_0);
		}
		return enumerable;
	}
}
