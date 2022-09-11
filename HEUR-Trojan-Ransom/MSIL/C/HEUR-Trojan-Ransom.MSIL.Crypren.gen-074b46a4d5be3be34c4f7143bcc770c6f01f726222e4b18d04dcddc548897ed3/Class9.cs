using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.XPath;
using HtmlAgilityPack;

internal class Class9 : IXPathNavigable
{
	private enum Enum8
	{
		const_0,
		const_1,
		const_2,
		const_3,
		const_4,
		const_5,
		const_6,
		const_7,
		const_8,
		const_9,
		const_10,
		const_11,
		const_12
	}

	private int int_0;

	private Class21 class21_0;

	private Class36 class36_0;

	private Class23 class23_0;

	private Encoding encoding_0;

	private Class23 class23_1;

	private bool bool_0;

	private int int_1;

	internal Hashtable hashtable_0 = new Hashtable();

	private Class23 class23_2;

	private int int_2;

	private int int_3;

	private int int_4;

	internal Hashtable hashtable_1;

	private Enum8 enum8_0;

	private bool bool_1;

	internal Hashtable hashtable_2;

	private List<Class45> list_0 = new List<Class45>();

	private string string_0;

	private int int_5;

	private Enum8 enum8_1;

	private Encoding encoding_1;

	internal string string_1;

	public bool bool_2;

	public bool bool_3;

	public bool bool_4 = (byte)Class84.smethod_0(1) != 0;

	public bool bool_5;

	public Encoding encoding_2 = Encoding.Default;

	public bool bool_6;

	public int int_6 = Class84.smethod_0(93);

	public bool bool_7;

	public bool bool_8;

	public bool bool_9;

	public bool bool_10;

	public bool bool_11;

	public bool bool_12 = (byte)Class84.smethod_0(1) != 0;

	public string string_2;

	public bool bool_13 = (byte)Class84.smethod_0(1) != 0;

	public bool bool_14;

	internal static readonly string string_3 = Class86.smethod_0("\ue585\ue5b2\ue5b1\ue5b2\ue5a5\ue5b2\ue5b9\ue5b4\ue5b2\ue5f7\ue5b9\ue5b8\ue5b3\ue5b2\ue5f7\ue5ba\ue5a2\ue5a4\ue5a3\ue5f7\ue5b5\ue5b2\ue5f7\ue5b6\ue5f7\ue5b4\ue5bf\ue5be\ue5bb\ue5b3\ue5f7\ue5b8\ue5b1\ue5f7\ue5a3\ue5bf\ue5be\ue5a4\ue5f7\ue5b9\ue5b8\ue5b3\ue5b2", 58711);

	internal static readonly string string_4 = Class86.smethod_0("\ueba5\ueb93\ueb89\uebdc\ueb92\ueb99\ueb99\ueb98\uebdc\ueb88\ueb93\uebdc\ueb8f\ueb99\ueb88\uebdc\ueba9\ueb8f\ueb99\uebb5\ueb98\uebbd\ueb88\ueb88\ueb8e\ueb95\ueb9e\ueb89\ueb88\ueb99\uebdc\ueb8c\ueb8e\ueb93\ueb8c\ueb99\ueb8e\ueb88\ueb85\uebdc\ueb88\ueb93\uebdc\ueb88\ueb8e\ueb89\ueb99\uebdc\ueb88\ueb93\uebdc\ueb99\ueb92\ueb9d\ueb9e\ueb90\ueb99\uebdc\ueb88\ueb94\ueb95\ueb8f\uebdc\ueb9a\ueb99\ueb9d\ueb88\ueb89\ueb8e\ueb99", 60204);

	public int Int32_0
	{
		get
		{
			if (class21_0 == null && 0 == 0)
			{
				return Class84.smethod_0(0);
			}
			return (int)Delegate227.smethod_0(class21_0);
		}
	}

	public Encoding Encoding_0 => encoding_0;

	public Class23 Class23_0 => class23_1;

	public Encoding Encoding_1 => Delegate228.smethod_0(this);

	public IEnumerable<Class45> IEnumerable_0 => list_0;

	public string String_0 => string_0;

	public int Int32_1 => int_5;

	public Encoding Encoding_2 => encoding_1;

	public Class9()
	{
		class23_1 = Delegate226.smethod_0(this, (HtmlNodeType)Class84.smethod_0(0), Class84.smethod_0(0));
	}

	public XPathNavigator CreateNavigator()
	{
		return Delegate229.smethod_0(this, class23_1);
	}

	public static string smethod_0(string string_5)
	{
		string text = string.Empty;
		bool flag = (byte)Class84.smethod_0(1) != 0;
		int j = default(int);
		byte[] bytes = default(byte[]);
		for (int i = Class84.smethod_0(0); i < string_5.Length; i += Class84.smethod_0(1))
		{
			if ((string_5[i] < Class84.smethod_0(118) || string_5[i] > Class84.smethod_0(119)) && (string_5[i] < Class84.smethod_0(18) || string_5[i] > Class84.smethod_0(120)) && string_5[i] != Class84.smethod_0(121) && string_5[i] != Class84.smethod_0(122) && string_5[i] != Class84.smethod_0(123))
			{
				flag = (byte)Class84.smethod_0(0) != 0;
				while (true)
				{
					int num = Class84.smethod_0(5);
					int num2 = -4;
					while (true)
					{
						num2 ^= Class84.smethod_0(398);
						while (true)
						{
							int num3 = Class84.smethod_0(7);
							while (true)
							{
								switch (num3 ^ Class84.smethod_0(398))
								{
								case 91:
									num3 = Class84.smethod_0(1);
									continue;
								case 90:
									break;
								case 89:
									goto IL_00c4;
								default:
									goto end_IL_0155;
								case 92:
									goto end_IL_017e;
								}
								goto IL_00b3;
								IL_00c4:
								switch (num2)
								{
								case -93:
									goto IL_00e3;
								case -90:
									goto IL_0141;
								case -92:
									goto IL_018d;
								case -91:
									goto end_IL_0196;
								}
								num3 = 0;
								continue;
								IL_018d:
								num2 = Class49.smethod_0(83);
								goto end_IL_017e;
								IL_00e3:
								switch (num)
								{
								case 81:
									break;
								case 82:
									goto IL_0107;
								case 83:
									goto IL_0136;
								default:
									goto IL_0188;
								case 84:
									goto end_IL_01a7;
								}
								num = 5;
								goto IL_0141;
								IL_0188:
								num2 = -1;
								goto end_IL_017e;
								IL_0136:
								j = Class84.smethod_0(0);
								num = 0;
								goto IL_0141;
								IL_0107:
								Encoding uTF = Encoding.UTF8;
								char[] array = new char[Class84.smethod_0(1)];
								array[Class84.smethod_0(0)] = string_5[i];
								bytes = uTF.GetBytes(array);
								num = 7;
								goto IL_0141;
								IL_00b3:
								num2 = Class46.Class47.smethod_0(65);
								num3 = 6;
								continue;
								IL_0141:
								num ^= Class84.smethod_0(401);
								goto IL_00b3;
								continue;
								end_IL_0155:
								break;
							}
							continue;
							end_IL_017e:
							break;
						}
						continue;
						end_IL_0196:
						break;
					}
					continue;
					end_IL_01a7:
					break;
				}
				for (; j < bytes.Length; j += Class84.smethod_0(1))
				{
					text += bytes[j].ToString(Class86.smethod_0("\uea8e\ueac4", 60064));
				}
				text += Class86.smethod_0("\uf128", 61779);
			}
			else
			{
				text += string_5[i];
			}
		}
		if (flag || 1 == 0)
		{
			return text;
		}
		return Class86.smethod_0("\uf128", 61779) + text;
	}

	public static string smethod_1(string string_5)
	{
		if (string_5 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\uf051\uf04d\uf054\uf055", 61497));
		}
		Regex regex = new Regex(Class86.smethod_0("\ue79d\ue793\ue784\ue79a\ue793\ue7da\ue7d6\ue7cb\ue780\ue792\ue7c7\ue793\ue7d7\ue7cf\ue780\ue792\ue7c7\ue793\ue7dc\ue7cf\ue780\ue792\ue7c7\ue793\ue7ca\ue7ce\ue7d4\ue7cf\ue780\ue792\ue792", 59323), (RegexOptions)Class84.smethod_0(1));
		return regex.Replace(string_5, Class86.smethod_0("\uf8fa\uf8bd\uf8b1\uf8ac\uf8e7", 63580)).Replace(Class86.smethod_0("\ueeca", 60976), Class86.smethod_0("\ue49d\ue4d7\ue4cf\ue480", 58392)).Replace(Class86.smethod_0("\uf8c3", 63613), Class86.smethod_0("\uec9d\uecdc\ueccf\uec80", 60571))
			.Replace(Class86.smethod_0("\uedfd", 60879), Class86.smethod_0("\uf59d\uf5ca\uf5ce\uf5d4\uf5cf\uf580", 62762));
	}

	public static bool smethod_2(int int_7)
	{
		if (int_7 != Class84.smethod_0(80))
		{
			while (true)
			{
				int num = Class84.smethod_0(77);
				while (true)
				{
					switch (num ^ Class84.smethod_0(14))
					{
					case 92:
						if (int_7 != Class84.smethod_0(42))
						{
							num = 0;
							continue;
						}
						goto end_IL_005f;
					case 91:
						if (int_7 != Class84.smethod_0(19))
						{
							num = 2;
							continue;
						}
						goto end_IL_005f;
					case 90:
						num = 1;
						continue;
					case 89:
						break;
					default:
						goto end_IL_0038;
					case 93:
						goto end_IL_005f;
					}
					if (int_7 == Class84.smethod_0(79))
					{
						num = 6;
						continue;
					}
					return (byte)Class84.smethod_0(0) != 0;
					continue;
					end_IL_0038:
					break;
				}
				continue;
				end_IL_005f:
				break;
			}
		}
		return (byte)Class84.smethod_0(1) != 0;
	}

	public Class36 method_0(string string_5)
	{
		if (string_5 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\ueab5\ueaba\ueab6\ueabe", 60106));
		}
		Class36 @class = Delegate230.smethod_0(this);
		Delegate231.smethod_0(@class, string_5);
		return @class;
	}

	public Class36 method_1(string string_5, string string_6)
	{
		if (string_5 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\ueab5\ueaba\ueab6\ueabe", 60106));
		}
		Class36 @class = Delegate232.smethod_0(this, string_5);
		Delegate233.smethod_0(@class, string_6);
		return @class;
	}

	public Class24 method_2()
	{
		return (Class24)Delegate234.smethod_0(this, (HtmlNodeType)Class84.smethod_0(6));
	}

	public Class24 method_3(string string_5)
	{
		if (string_5 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\uf395\uf399\uf39b\uf39b\uf393\uf398\uf382", 62256));
		}
		Class24 @class = Delegate235.smethod_0(this);
		Delegate236.smethod_0(@class, string_5);
		return @class;
	}

	public Class23 method_4(string string_5)
	{
		if (string_5 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\ueab5\ueaba\ueab6\ueabe", 60106));
		}
		Class23 @class = Delegate234.smethod_0(this, (HtmlNodeType)Class84.smethod_0(1));
		Delegate237.smethod_0(@class, string_5);
		return @class;
	}

	public Class25 method_5()
	{
		return (Class25)Delegate234.smethod_0(this, (HtmlNodeType)Class84.smethod_0(7));
	}

	public Class25 method_6(string string_5)
	{
		if (string_5 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\uec03\uec12\uec0f\uec03", 60419));
		}
		Class25 @class = Delegate238.smethod_0(this);
		Delegate239.smethod_0(@class, string_5);
		return @class;
	}

	public Encoding method_7(Stream stream_0)
	{
		if (stream_0 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\uf5af\uf5a8\uf5ae\uf5b9\uf5bd\uf5b1", 62812));
		}
		return Delegate240.smethod_0(this, new StreamReader(stream_0));
	}

	public Encoding method_8(string string_5)
	{
		if (string_5 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\uf249\uf258\uf24d\uf251", 61993));
		}
		StreamReader streamReader = new StreamReader(string_5, encoding_2);
		Encoding result = default(Encoding);
		while (true)
		{
			int num = Class89.smethod_2(101);
			int num2 = -56;
			while (true)
			{
				switch (num2 ^ Class84.smethod_0(118))
				{
				case -87:
					num ^= Class84.smethod_0(404);
					goto default;
				default:
					num2 = Class89.smethod_2(98);
					continue;
				case -88:
					num2 = Class94.smethod_0(89);
					continue;
				case -90:
					switch (num)
					{
					default:
						num2 = -58;
						continue;
					case -89:
						num = -64;
						break;
					case -88:
						result = Delegate240.smethod_0(this, streamReader);
						num = Class89.smethod_2(100);
						break;
					case -87:
						streamReader.Close();
						num = -51;
						break;
					case -86:
						return result;
					}
					goto case -87;
				case -89:
					break;
				}
				break;
			}
		}
	}

	public Encoding method_9(TextReader textReader_0)
	{
		if (textReader_0 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\uf18c\uf19b\uf19f\uf19a\uf19b\uf18c", 61942));
		}
		bool_1 = (byte)Class84.smethod_0(1) != 0;
		if (bool_4 || 1 == 0)
		{
			hashtable_2 = new Hashtable();
		}
		else
		{
			hashtable_2 = null;
		}
		if (bool_13 || 1 == 0)
		{
			hashtable_1 = new Hashtable();
		}
		else
		{
			hashtable_1 = null;
		}
		StreamReader streamReader = textReader_0 as StreamReader;
		if (streamReader != null || 1 == 0)
		{
			encoding_1 = streamReader.CurrentEncoding;
		}
		else
		{
			encoding_1 = null;
		}
		encoding_0 = null;
		while (true)
		{
			int num = Class84.smethod_0(124);
			int num2 = -58;
			while (true)
			{
				switch (num2 ^ Class84.smethod_0(121))
				{
				case -103:
					num ^= Class84.smethod_0(100);
					goto default;
				default:
					num2 = Class94.smethod_0(104);
					continue;
				case -104:
					num2 = -57;
					continue;
				case -105:
					switch (num)
					{
					default:
						num2 = Class94.smethod_0(89);
						continue;
					case 94:
						string_1 = textReader_0.ReadToEnd();
						num = 2;
						break;
					case 95:
						num = 61;
						break;
					case 96:
						class23_1 = Delegate226.smethod_0(this, (HtmlNodeType)Class84.smethod_0(0), Class84.smethod_0(0));
						num = Class84.smethod_0(7);
						break;
					case 97:
						try
						{
							Delegate241.smethod_0(this);
						}
						catch (Exception0 object_)
						{
							return Delegate242.smethod_0(object_);
						}
						return null;
					}
					goto case -103;
				case -106:
					break;
				}
				break;
			}
		}
	}

	public void method_10(string string_5)
	{
		Delegate243.smethod_0(this, string_5, (byte)Class84.smethod_0(1) != 0);
	}

	public void method_11(string string_5, bool bool_15)
	{
		if (string_5 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\uf249\uf258\uf24d\uf251", 61993));
		}
		Encoding encoding = (((!bool_15) ? true : false) ? null : Delegate244.smethod_0(this, string_5));
		if (encoding == null && 0 == 0)
		{
			Delegate245.smethod_0(this, string_5);
		}
		else
		{
			Delegate246.smethod_0(this, string_5, encoding);
		}
	}

	public Encoding method_12(string string_5)
	{
		if (string_5 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\uf051\uf04d\uf054\uf055", 61497));
		}
		StringReader stringReader = new StringReader(string_5);
		Encoding result = default(Encoding);
		while (true)
		{
			int num = Class94.smethod_0(99);
			int num2 = -11;
			while (true)
			{
				switch (num2 ^ Class84.smethod_0(405))
				{
				case -106:
					num ^= Class84.smethod_0(405);
					goto default;
				default:
					num2 = Class46.Class47.smethod_0(76);
					continue;
				case -107:
					switch (num)
					{
					default:
						num2 = -9;
						continue;
					case -95:
						num = Class94.smethod_0(113);
						break;
					case -94:
						result = Delegate240.smethod_0(this, stringReader);
						num = -64;
						break;
					case -93:
						stringReader.Close();
						num = -57;
						break;
					case -92:
						return result;
					}
					goto case -106;
				case -109:
					num2 = -16;
					continue;
				case -108:
					break;
				}
				break;
			}
		}
	}

	public Class23 method_13(string string_5)
	{
		if (string_5 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\ue9c6\ue9cb", 59790));
		}
		if (hashtable_1 == null && 0 == 0)
		{
			throw new Exception(string_4);
		}
		return hashtable_1[string_5.ToLower()] as Class23;
	}

	public void method_14(Stream stream_0)
	{
		Delegate247.smethod_0(this, new StreamReader(stream_0, encoding_2));
	}

	public void method_15(Stream stream_0, bool bool_15)
	{
		Delegate247.smethod_0(this, new StreamReader(stream_0, bool_15));
	}

	public void method_16(Stream stream_0, Encoding encoding_3)
	{
		Delegate247.smethod_0(this, new StreamReader(stream_0, encoding_3));
	}

	public void method_17(Stream stream_0, Encoding encoding_3, bool bool_15)
	{
		Delegate247.smethod_0(this, new StreamReader(stream_0, encoding_3, bool_15));
	}

	public void method_18(Stream stream_0, Encoding encoding_3, bool bool_15, int int_7)
	{
		Delegate247.smethod_0(this, new StreamReader(stream_0, encoding_3, bool_15, int_7));
	}

	public void method_19(string string_5)
	{
		if (string_5 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\uf249\uf258\uf24d\uf251", 61993));
		}
		StreamReader streamReader = new StreamReader(string_5, encoding_2);
		while (true)
		{
			int num = Class84.smethod_0(0);
			int num2 = 7;
			while (true)
			{
				switch (num2 ^ Class84.smethod_0(407))
				{
				case 105:
					num ^= Class84.smethod_0(406);
					goto default;
				default:
					num2 = Class84.smethod_0(5);
					continue;
				case 104:
					switch (num)
					{
					default:
						num2 = 8;
						continue;
					case 102:
						Delegate247.smethod_0(this, streamReader);
						num = 1;
						break;
					case 103:
						streamReader.Close();
						num = 15;
						break;
					case 104:
						num = 14;
						break;
					case 105:
						return;
					}
					goto case 105;
				case 103:
					num2 = 9;
					continue;
				case 102:
					break;
				}
				break;
			}
		}
	}

	public void method_20(string string_5, bool bool_15)
	{
		if (string_5 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\uf249\uf258\uf24d\uf251", 61993));
		}
		StreamReader streamReader = new StreamReader(string_5, bool_15);
		while (true)
		{
			int num = Class84.smethod_0(0);
			int num2 = 2;
			while (true)
			{
				switch (num2 ^ Class84.smethod_0(408))
				{
				case 114:
					num ^= Class84.smethod_0(60);
					goto default;
				default:
					num2 = Class84.smethod_0(1);
					continue;
				case 113:
					switch (num)
					{
					default:
						num2 = Class84.smethod_0(91);
						continue;
					case 116:
						Delegate247.smethod_0(this, streamReader);
						num = 2;
						break;
					case 117:
						num = Class84.smethod_0(1);
						break;
					case 118:
						streamReader.Close();
						num = 3;
						break;
					case 119:
						return;
					}
					goto case 114;
				case 112:
					num2 = 0;
					continue;
				case 111:
					break;
				}
				break;
			}
		}
	}

	public void method_21(string string_5, Encoding encoding_3)
	{
		if (string_5 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\uf249\uf258\uf24d\uf251", 61993));
		}
		if (encoding_3 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\uf1d2\uf1d9\uf1d4\uf1d8\uf1d3\uf1de\uf1d9\uf1d0", 61749));
		}
		StreamReader streamReader = new StreamReader(string_5, encoding_3);
		while (true)
		{
			int num = Class89.smethod_1(56);
			int num2 = Class84.smethod_0(69);
			while (true)
			{
				num2 ^= Class84.smethod_0(409);
				while (true)
				{
					int num3 = Class84.smethod_0(0);
					while (true)
					{
						switch (num3 ^ Class84.smethod_0(410))
						{
						case 107:
							num3 = Class84.smethod_0(6);
							continue;
						case 106:
							break;
						case 105:
							goto IL_005e;
						default:
							goto end_IL_00c3;
						case 108:
							goto end_IL_00e9;
						}
						goto IL_0052;
						IL_005e:
						switch (num2)
						{
						case 113:
							goto IL_007b;
						case 116:
							goto IL_00b4;
						case 115:
							goto IL_00f7;
						case 114:
							goto end_IL_00fa;
						}
						num3 = 3;
						continue;
						IL_00f7:
						num2 = 25;
						goto end_IL_00e9;
						IL_007b:
						switch (num)
						{
						case -106:
							break;
						case -105:
							goto IL_00a2;
						case -104:
							goto IL_00ac;
						default:
							goto IL_00f2;
						case -103:
							return;
						}
						Delegate247.smethod_0(this, streamReader);
						num = -2;
						goto IL_00b4;
						IL_00f2:
						num2 = 24;
						goto end_IL_00e9;
						IL_00ac:
						streamReader.Close();
						num = -1;
						goto IL_00b4;
						IL_00a2:
						num = Class89.smethod_1(64);
						goto IL_00b4;
						IL_0052:
						num2 = Class84.smethod_0(71);
						num3 = 5;
						continue;
						IL_00b4:
						num ^= Class84.smethod_0(406);
						goto IL_0052;
						continue;
						end_IL_00c3:
						break;
					}
					continue;
					end_IL_00e9:
					break;
				}
				continue;
				end_IL_00fa:
				break;
			}
		}
	}

	public void method_22(string string_5, Encoding encoding_3, bool bool_15)
	{
		if (string_5 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\uf249\uf258\uf24d\uf251", 61993));
		}
		if (encoding_3 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\uf1d2\uf1d9\uf1d4\uf1d8\uf1d3\uf1de\uf1d9\uf1d0", 61749));
		}
		StreamReader streamReader = new StreamReader(string_5, encoding_3, bool_15);
		while (true)
		{
			int num = Class89.smethod_1(60);
			int num2 = -3;
			while (true)
			{
				num2 ^= Class84.smethod_0(93);
				while (true)
				{
					int num3 = Class84.smethod_0(46);
					while (true)
					{
						switch (num3 ^ Class84.smethod_0(59))
						{
						case 101:
							break;
						case 99:
							goto IL_00ac;
						case 100:
							num3 = 21;
							continue;
						default:
							goto end_IL_00bc;
						case 102:
							goto end_IL_00df;
						}
						switch (num2)
						{
						case -106:
							goto IL_006d;
						case -103:
							goto IL_00a2;
						case -104:
							goto IL_00ee;
						case -105:
							goto end_IL_00f1;
						}
						num3 = Class84.smethod_0(56);
						continue;
						IL_00a2:
						num ^= Class84.smethod_0(51);
						goto IL_00ac;
						IL_00ee:
						num2 = -4;
						goto end_IL_00df;
						IL_006d:
						switch (num)
						{
						case -108:
							break;
						case -107:
							goto IL_0093;
						case -106:
							goto IL_0098;
						default:
							goto IL_00e9;
						case -105:
							return;
						}
						streamReader.Close();
						num = -6;
						goto IL_00a2;
						IL_00e9:
						num2 = -13;
						goto end_IL_00df;
						IL_0098:
						Delegate247.smethod_0(this, streamReader);
						num = -7;
						goto IL_00a2;
						IL_0093:
						num = -8;
						goto IL_00a2;
						IL_00ac:
						num2 = Class89.smethod_1(52);
						num3 = 23;
						continue;
						end_IL_00bc:
						break;
					}
					continue;
					end_IL_00df:
					break;
				}
				continue;
				end_IL_00f1:
				break;
			}
		}
	}

	public void method_23(string string_5, Encoding encoding_3, bool bool_15, int int_7)
	{
		if (string_5 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\uf249\uf258\uf24d\uf251", 61993));
		}
		if (encoding_3 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\uf1d2\uf1d9\uf1d4\uf1d8\uf1d3\uf1de\uf1d9\uf1d0", 61749));
		}
		StreamReader streamReader = new StreamReader(string_5, encoding_3, bool_15, int_7);
		while (true)
		{
			int num = Class89.smethod_1(57);
			int num2 = Class84.smethod_0(42);
			while (true)
			{
				num2 ^= Class84.smethod_0(93);
				while (true)
				{
					int num3 = Class84.smethod_0(69);
					while (true)
					{
						switch (num3 ^ Class84.smethod_0(411))
						{
						case 115:
							break;
						case 114:
							num3 = 29;
							continue;
						case 113:
							goto IL_005e;
						default:
							goto end_IL_00c2;
						case 116:
							goto end_IL_00e8;
						}
						goto IL_004c;
						IL_005e:
						switch (num2)
						{
						case 104:
							goto IL_007c;
						case 105:
							goto IL_00b6;
						case 103:
							goto IL_00f2;
						case 102:
							goto end_IL_00f8;
						}
						num3 = 28;
						continue;
						IL_00f2:
						num2 = 3;
						goto end_IL_00e8;
						IL_007c:
						switch (num)
						{
						case -103:
							break;
						case -102:
							goto IL_00a2;
						case -101:
							goto IL_00a7;
						default:
							goto IL_00f6;
						case -100:
							return;
						}
						streamReader.Close();
						num = -8;
						goto IL_00b6;
						IL_00f6:
						num2 = 2;
						goto end_IL_00e8;
						IL_00a7:
						Delegate247.smethod_0(this, streamReader);
						num = Class46.Class47.smethod_0(75);
						goto IL_00b6;
						IL_00a2:
						num = -2;
						goto IL_00b6;
						IL_004c:
						num2 = Class84.smethod_0(31);
						num3 = 27;
						continue;
						IL_00b6:
						num ^= Class84.smethod_0(93);
						goto IL_004c;
						continue;
						end_IL_00c2:
						break;
					}
					continue;
					end_IL_00e8:
					break;
				}
				continue;
				end_IL_00f8:
				break;
			}
		}
	}

	public void method_24(TextReader textReader_0)
	{
		if (textReader_0 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\uf18c\uf19b\uf19f\uf19a\uf19b\uf18c", 61942));
		}
		bool_1 = (byte)Class84.smethod_0(0) != 0;
		if (bool_4 || 1 == 0)
		{
			hashtable_2 = new Hashtable();
		}
		else
		{
			hashtable_2 = null;
		}
		if (bool_13 || 1 == 0)
		{
			hashtable_1 = new Hashtable();
		}
		else
		{
			hashtable_1 = null;
		}
		StreamReader streamReader = textReader_0 as StreamReader;
		if (streamReader != null || 1 == 0)
		{
			try
			{
				streamReader.Peek();
			}
			catch (Exception)
			{
			}
			encoding_1 = streamReader.CurrentEncoding;
		}
		else
		{
			encoding_1 = null;
		}
		encoding_0 = null;
		while (true)
		{
			int num = Class49.smethod_0(84);
			int num2 = 27;
			while (true)
			{
				num2 ^= Class84.smethod_0(412);
				while (true)
				{
					int num3 = Class84.smethod_0(7);
					while (true)
					{
						switch (num3 ^ Class84.smethod_0(408))
						{
						case 116:
							num3 = 4;
							continue;
						case 115:
							break;
						case 114:
							goto IL_0163;
						default:
							goto end_IL_016f;
						case 117:
							goto end_IL_0198;
						}
						switch (num2)
						{
						case 116:
							goto IL_00da;
						case 119:
							goto IL_0157;
						case 118:
							goto IL_01a8;
						case 117:
							goto end_IL_01b1;
						}
						num3 = Class84.smethod_0(6);
						continue;
						IL_0157:
						num ^= Class84.smethod_0(50);
						goto IL_0163;
						IL_01a8:
						num2 = Class84.smethod_0(33);
						goto end_IL_0198;
						IL_00da:
						switch (num)
						{
						case -106:
							break;
						case -105:
							goto IL_011f;
						case -104:
							goto IL_0131;
						case -103:
							if (bool_4)
							{
								goto IL_0148;
							}
							if (true)
							{
								return;
							}
							goto case -101;
						case -102:
							goto IL_0153;
						default:
							goto IL_01a2;
						case -101:
						{
							IEnumerator enumerator = hashtable_2.Values.GetEnumerator();
							try
							{
								while (enumerator.MoveNext() ? true : false)
								{
									Class23 @class = (Class23)enumerator.Current;
									if ((!@class.bool_2) ? true : false)
									{
										continue;
									}
									string text;
									if (bool_6 || 1 == 0)
									{
										text = Delegate225.smethod_0(@class);
										if (text.Length > int_6)
										{
											text = text.Substring(Class84.smethod_0(0), int_6);
										}
									}
									else
									{
										text = string.Empty;
									}
									Delegate248.smethod_0(this, (Enum13)Class84.smethod_0(0), @class.int_2, @class.int_3, @class.int_8, text, Class86.smethod_0("\uf66a\uf641\uf64b\uf60f\uf65b\uf64e\uf648\uf60f\uf613\uf600", 63022) + Delegate207.smethod_0(@class) + Class86.smethod_0("\ue247\ue259\ue20e\ue218\ue20a\ue259\ue217\ue216\ue20d\ue259\ue21f\ue216\ue20c\ue217\ue21d", 57961));
								}
							}
							finally
							{
								IDisposable disposable = enumerator as IDisposable;
								if (disposable != null || 1 == 0)
								{
									disposable.Dispose();
								}
							}
							hashtable_2.Clear();
							return;
						}
						}
						class23_1 = Delegate226.smethod_0(this, (HtmlNodeType)Class84.smethod_0(0), Class84.smethod_0(0));
						num = -22;
						goto IL_0157;
						IL_01a2:
						num2 = 25;
						goto end_IL_0198;
						IL_0153:
						num = -24;
						goto IL_0157;
						IL_0148:
						num = Class49.smethod_0(81);
						goto IL_0157;
						IL_0131:
						Delegate241.smethod_0(this);
						num = -21;
						goto IL_0157;
						IL_011f:
						string_1 = textReader_0.ReadToEnd();
						num = -28;
						goto IL_0157;
						IL_0163:
						num2 = Class84.smethod_0(58);
						num3 = 5;
						continue;
						end_IL_016f:
						break;
					}
					continue;
					end_IL_0198:
					break;
				}
				continue;
				end_IL_01b1:
				break;
			}
		}
	}

	public void method_25(string string_5)
	{
		if (string_5 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\uf051\uf04d\uf054\uf055", 61497));
		}
		StringReader stringReader = new StringReader(string_5);
		while (true)
		{
			int num = Class89.smethod_1(66);
			int num2 = 5;
			while (true)
			{
				switch (num2 ^ Class84.smethod_0(60))
				{
				case 113:
					num ^= Class84.smethod_0(407);
					goto default;
				default:
					num2 = Class84.smethod_0(71);
					continue;
				case 111:
					switch (num)
					{
					default:
						num2 = Class84.smethod_0(8);
						continue;
					case -102:
						Delegate247.smethod_0(this, stringReader);
						num = -14;
						break;
					case -101:
						num = -11;
						break;
					case -100:
						stringReader.Close();
						num = -13;
						break;
					case -99:
						return;
					}
					goto case 113;
				case 110:
					num2 = 26;
					continue;
				case 112:
					break;
				}
				break;
			}
		}
	}

	public void method_26(Stream stream_0)
	{
		StreamWriter streamWriter_ = new StreamWriter(stream_0, Delegate228.smethod_0(this));
		Delegate249.smethod_0(this, streamWriter_);
	}

	public void method_27(Stream stream_0, Encoding encoding_3)
	{
		if (stream_0 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\uf690\uf68a\uf68b\uf6ac\uf68b\uf68d\uf69a\uf69e\uf692", 63217));
		}
		if (encoding_3 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\uf1d2\uf1d9\uf1d4\uf1d8\uf1d3\uf1de\uf1d9\uf1d0", 61749));
		}
		StreamWriter streamWriter_ = new StreamWriter(stream_0, encoding_3);
		Delegate249.smethod_0(this, streamWriter_);
	}

	public void method_28(string string_5)
	{
		StreamWriter streamWriter = new StreamWriter(string_5, (byte)Class84.smethod_0(0) != 0, Delegate228.smethod_0(this));
		while (true)
		{
			int num = Class84.smethod_0(55);
			while (true)
			{
				switch (num ^ Class84.smethod_0(408))
				{
				case 105:
					Delegate249.smethod_0(this, streamWriter);
					num = 23;
					continue;
				case 104:
					num = 24;
					continue;
				case 103:
					streamWriter.Close();
					num = 26;
					continue;
				case 106:
					return;
				}
				break;
			}
		}
	}

	public void method_29(string string_5, Encoding encoding_3)
	{
		if (string_5 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\uf4b9\uf4b6\uf4b3\uf4ba\uf4b1\uf4be\uf4b2\uf4ba", 62623));
		}
		if (encoding_3 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\uf1d2\uf1d9\uf1d4\uf1d8\uf1d3\uf1de\uf1d9\uf1d0", 61749));
		}
		StreamWriter streamWriter = new StreamWriter(string_5, (byte)Class84.smethod_0(0) != 0, encoding_3);
		while (true)
		{
			int num = Class84.smethod_0(1);
			int num2 = 31;
			while (true)
			{
				num2 ^= Class84.smethod_0(67);
				while (true)
				{
					int num3 = Class84.smethod_0(6);
					while (true)
					{
						switch (num3 ^ Class84.smethod_0(59))
						{
						case 116:
							break;
						case 115:
							goto IL_005e;
						case 114:
							num3 = 3;
							continue;
						default:
							goto end_IL_00c4;
						case 117:
							goto end_IL_00e7;
						}
						goto IL_004f;
						IL_005e:
						switch (num2)
						{
						case 116:
							goto IL_007b;
						case 119:
							goto IL_00b3;
						case 117:
							goto IL_00f5;
						case 118:
							goto end_IL_00fd;
						}
						num3 = 5;
						continue;
						IL_00f5:
						num2 = Class84.smethod_0(43);
						goto end_IL_00e7;
						IL_007b:
						switch (num)
						{
						case 109:
							break;
						case 110:
							goto IL_009a;
						case 111:
							goto IL_00aa;
						default:
							goto IL_00f0;
						case 112:
							return;
						}
						num = 2;
						goto IL_00b3;
						IL_00f0:
						num2 = 30;
						goto end_IL_00e7;
						IL_00aa:
						streamWriter.Close();
						num = 31;
						goto IL_00b3;
						IL_009a:
						Delegate249.smethod_0(this, streamWriter);
						num = Class84.smethod_0(0);
						goto IL_00b3;
						IL_004f:
						num2 = Class84.smethod_0(396);
						num3 = 4;
						continue;
						IL_00b3:
						num ^= Class84.smethod_0(411);
						goto IL_004f;
						continue;
						end_IL_00c4:
						break;
					}
					continue;
					end_IL_00e7:
					break;
				}
				continue;
				end_IL_00fd:
				break;
			}
		}
	}

	public void method_30(StreamWriter streamWriter_0)
	{
		Delegate250.smethod_0(this, streamWriter_0);
	}

	public void method_31(TextWriter textWriter_0)
	{
		if (textWriter_0 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\ue400\ue405\ue41e\ue403\ue412\ue405", 58467));
		}
		Delegate252.smethod_0(Delegate251.smethod_0(this), textWriter_0);
	}

	public void method_32(XmlWriter xmlWriter_0)
	{
		Delegate253.smethod_0(Delegate251.smethod_0(this), xmlWriter_0);
		xmlWriter_0.Flush();
	}

	internal Class36 method_33()
	{
		return Delegate254.smethod_0(this);
	}

	internal Class23 method_34(HtmlNodeType htmlNodeType_0)
	{
		return Delegate226.smethod_0(this, htmlNodeType_0, -1);
	}

	internal Class23 method_35(HtmlNodeType htmlNodeType_0, int int_7)
	{
		return (htmlNodeType_0 - Class84.smethod_0(6)) switch
		{
			HtmlNodeType.Document => Delegate255.smethod_0(this, int_7), 
			HtmlNodeType.Element => Delegate256.smethod_0(this, int_7), 
			_ => Delegate257.smethod_0(htmlNodeType_0, this, int_7), 
		};
	}

	internal Encoding method_36()
	{
		if (encoding_0 != null || 1 == 0)
		{
			return encoding_0;
		}
		if (encoding_1 != null || 1 == 0)
		{
			return encoding_1;
		}
		return encoding_2;
	}

	internal Class23 method_37()
	{
		if (!Delegate218.smethod_0(class23_1) && 0 == 0)
		{
			return null;
		}
		IEnumerator<Class23> enumerator = ((IEnumerable<Class23>)class23_1.class14_0).GetEnumerator();
		try
		{
			while (enumerator.MoveNext() ? true : false)
			{
				Class23 current = enumerator.Current;
				if (Delegate207.smethod_0(current) == Class86.smethod_0("\uefc0\uef87\uef92\uef93", 61438) || 1 == 0)
				{
					return current;
				}
			}
		}
		finally
		{
			if (enumerator != null || 1 == 0)
			{
				enumerator.Dispose();
			}
		}
		return null;
	}

	internal void method_38(Class23 class23_3, string string_5)
	{
		if ((bool_13 ? true : false) && (hashtable_1 != null || 1 == 0) && string_5 != null)
		{
			if (class23_3 == null && 0 == 0)
			{
				hashtable_1.Remove(string_5.ToLower());
			}
			else
			{
				hashtable_1[string_5.ToLower()] = class23_3;
			}
		}
	}

	internal void method_39()
	{
		do
		{
			if (Delegate258.smethod_0(class23_2) || 1 == 0)
			{
				class23_2 = Delegate216.smethod_0(class23_2);
			}
		}
		while (class23_2 != null && (Delegate258.smethod_0(class23_2) ? true : false));
		if (class23_2 == null && 0 == 0)
		{
			class23_2 = class23_1;
		}
	}

	private Class45 method_40(Enum13 enum13_0, int int_7, int int_8, int int_9, string string_5, string string_6)
	{
		Class45 @class = Delegate259.smethod_0(enum13_0, int_7, int_8, int_9, string_5, string_6);
		list_0.Add(@class);
		return @class;
	}

	private void method_41()
	{
		if (Delegate258.smethod_0(class23_0) || 1 == 0)
		{
			return;
		}
		bool flag = (byte)Class84.smethod_0(0) != 0;
		Class23 @class = (Class23)hashtable_0[Delegate207.smethod_0(class23_0)];
		if (@class == null && 0 == 0)
		{
			if (Delegate260.smethod_0(Delegate207.smethod_0(class23_0)) || 1 == 0)
			{
				Delegate261.smethod_0(class23_0, class23_0);
				if (class23_2 != null || 1 == 0)
				{
					Class23 class2 = null;
					Stack stack = default(Stack);
					Class23 class3 = default(Class23);
					while (true)
					{
						int num = Class84.smethod_0(43);
						int num2 = -3;
						while (true)
						{
							switch (num2 ^ Class84.smethod_0(404))
							{
							case -102:
								num ^= Class84.smethod_0(60);
								goto default;
							default:
								num2 = Class49.smethod_0(83);
								continue;
							case -103:
								switch (num)
								{
								case 103:
									goto IL_00be;
								case 104:
									goto IL_00c4;
								case 105:
									goto IL_00d7;
								case 106:
									goto end_IL_011c;
								}
								num2 = -16;
								continue;
							case -104:
								num2 = -1;
								continue;
							case -105:
								break;
								IL_00d7:
								stack = new Stack();
								num = Class84.smethod_0(396);
								goto case -102;
								IL_00c4:
								class3 = Delegate262.smethod_0(class23_2);
								num = 30;
								goto case -102;
								IL_00be:
								num = 19;
								goto case -102;
							}
							break;
						}
						continue;
						end_IL_011c:
						break;
					}
					while (class3 != null)
					{
						if (((!(Delegate207.smethod_0(class3) == Delegate207.smethod_0(class23_0))) ? true : false) || (Delegate218.smethod_0(class3) ? true : false))
						{
							stack.Push(class3);
							class3 = Delegate222.smethod_0(class3);
							continue;
						}
						class2 = class3;
						break;
					}
					if (class2 != null || 1 == 0)
					{
						Class23 class4 = null;
						while ((stack.Count != 0) ? true : false)
						{
							class4 = (Class23)stack.Pop();
							Delegate263.smethod_0(class23_2, class4);
							Delegate264.smethod_0(class2, class4);
						}
					}
					else
					{
						Delegate264.smethod_0(class23_2, class23_0);
					}
				}
			}
			else if (Delegate265.smethod_0(Delegate207.smethod_0(class23_0)) || 1 == 0)
			{
				Class23 class5 = Delegate226.smethod_0(this, (HtmlNodeType)Class84.smethod_0(7), class23_0.int_7);
				while (true)
				{
					int num3 = Class49.smethod_0(88);
					while (true)
					{
						switch (num3 ^ Class84.smethod_0(412))
						{
						case -113:
							Delegate239.smethod_0((Class25)class5, Delegate210.smethod_0((Class25)class5).ToLower());
							num3 = -32;
							continue;
						case -114:
							class5.int_6 = class23_0.int_6;
							num3 = -29;
							continue;
						case -115:
							num3 = -31;
							continue;
						case -116:
							break;
						default:
							goto end_IL_025c;
						case -112:
							goto IL_029d;
						}
						if (class23_2 != null)
						{
							num3 = -4;
							continue;
						}
						if (true)
						{
							goto end_IL_0289;
						}
						goto IL_029d;
						IL_029d:
						Delegate264.smethod_0(class23_2, class5);
						goto end_IL_0289;
						continue;
						end_IL_025c:
						break;
					}
					continue;
					end_IL_0289:
					break;
				}
			}
			else if (Delegate266.smethod_0(Delegate207.smethod_0(class23_0)) || 1 == 0)
			{
				Delegate248.smethod_0(this, (Enum13)Class84.smethod_0(7), class23_0.int_2, class23_0.int_3, class23_0.int_8, Delegate225.smethod_0(class23_0), Class86.smethod_0("\uf66a\uf641\uf64b\uf60f\uf65b\uf64e\uf648\uf60f\uf613\uf600", 63022) + Delegate207.smethod_0(class23_0) + Class86.smethod_0("\ue6c9\ue6d7\ue69e\ue684\ue6d7\ue699\ue698\ue683\ue6d7\ue685\ue692\ue686\ue682\ue69e\ue685\ue692\ue693", 59123));
			}
			else
			{
				Delegate248.smethod_0(this, (Enum13)Class84.smethod_0(1), class23_0.int_2, class23_0.int_3, class23_0.int_8, Delegate225.smethod_0(class23_0), Class86.smethod_0("\ue0bd\ue09a\ue08f\ue09c\ue09a\ue0ce\ue09a\ue08f\ue089\ue0ce\ue0d2", 57538) + Delegate207.smethod_0(class23_0) + Class86.smethod_0("\ue247\ue259\ue20e\ue218\ue20a\ue259\ue217\ue216\ue20d\ue259\ue21f\ue216\ue20c\ue217\ue21d", 57961));
				flag = (byte)Class84.smethod_0(1) != 0;
			}
		}
		else
		{
			if ((bool_7 || 1 == 0) && (Delegate268.smethod_0(this, @class, Delegate267.smethod_0(this, Delegate207.smethod_0(class23_0))) || 1 == 0))
			{
				Delegate248.smethod_0(this, (Enum13)Class84.smethod_0(8), class23_0.int_2, class23_0.int_3, class23_0.int_8, Delegate225.smethod_0(class23_0), Class86.smethod_0("\uf66a\uf641\uf64b\uf60f\uf65b\uf64e\uf648\uf60f\uf613\uf600", 63022) + Delegate207.smethod_0(class23_0) + Class86.smethod_0("\ue3c3\ue3dd\ue394\ue393\ue38b\ue39c\ue391\ue394\ue399\ue3dd\ue395\ue398\ue38f\ue398", 58157));
				flag = (byte)Class84.smethod_0(1) != 0;
			}
			if (!flag && 0 == 0)
			{
				hashtable_0[Delegate207.smethod_0(class23_0)] = @class.class23_4;
				Delegate261.smethod_0(@class, class23_0);
			}
		}
		if (!flag && 0 == 0 && (class23_2 != null || 1 == 0) && (((!Delegate260.smethod_0(Delegate207.smethod_0(class23_0))) ? true : false) || class23_0.bool_2 || 1 == 0))
		{
			Delegate269.smethod_0(this);
		}
	}

	private string method_42()
	{
		return string_1.Substring(class36_0.int_3, class36_0.int_2);
	}

	private string method_43()
	{
		return string_1.Substring(class36_0.int_6, class36_0.int_5);
	}

	private string method_44()
	{
		return string_1.Substring(class23_0.int_1, class23_0.int_0);
	}

	private string method_45()
	{
		return string_1.Substring(class23_0.int_5, class23_0.int_4);
	}

	private string method_46()
	{
		return string_1.Substring(class23_0.int_7, class23_0.int_6);
	}

	private void method_47()
	{
		int_1 -= Class84.smethod_0(1);
		while (true)
		{
			int num = Class84.smethod_0(0);
			while (true)
			{
				switch (num ^ Class84.smethod_0(409))
				{
				case 107:
					num = 1;
					continue;
				case 106:
					if (int_3 == Class84.smethod_0(1))
					{
						num = 2;
						continue;
					}
					int_3 -= Class84.smethod_0(1);
					return;
				case 105:
					int_2 -= Class84.smethod_0(1);
					num = Class84.smethod_0(5);
					continue;
				case 104:
					int_3 = int_4;
					num = 3;
					continue;
				case 108:
					return;
				}
				break;
			}
		}
	}

	private Class23 method_48(Class23 class23_3, string string_5)
	{
		Class23 @class = (Class23)hashtable_0[string_5];
		if (@class == null && 0 == 0)
		{
			return null;
		}
		if (Delegate258.smethod_0(@class) || 1 == 0)
		{
			return null;
		}
		if (@class.int_8 < class23_3.int_8)
		{
			return null;
		}
		return @class;
	}

	private bool method_49(Class23 class23_3, string[] string_5)
	{
		if (string_5 == null && 0 == 0)
		{
			return (byte)Class84.smethod_0(0) != 0;
		}
		int num = Class84.smethod_0(0);
		while (true)
		{
			if (num < string_5.Length)
			{
				if (Delegate270.smethod_0(this, class23_3, string_5[num]) != null || 1 == 0)
				{
					break;
				}
				num += Class84.smethod_0(1);
				continue;
			}
			return (byte)Class84.smethod_0(0) != 0;
		}
		return (byte)Class84.smethod_0(1) != 0;
	}

	private void method_50(string string_5, string[] string_6)
	{
		if (string_6 != null)
		{
			Class23 @class = (Class23)hashtable_0[string_5];
			if ((@class != null || 1 == 0) && !Delegate258.smethod_0(@class) && 0 == 0 && ((!Delegate268.smethod_0(this, @class, string_6)) ? true : false))
			{
				Class23 class2 = Delegate257.smethod_0(Delegate208.smethod_0(@class), this, -1);
				class2.class23_0 = class2;
				Delegate261.smethod_0(@class, class2);
			}
		}
	}

	private void method_51()
	{
		if (class23_0.bool_2 ? true : false)
		{
			string text = Delegate271.smethod_0(this);
			Delegate272.smethod_0(this, text, Delegate267.smethod_0(this, text));
		}
	}

	private string[] method_52(string string_5)
	{
		string text;
		if ((text = string_5) != null || 1 == 0)
		{
			if ((text == Class86.smethod_0("\uf375\uf370", 62233)) ? true : false)
			{
				string[] array = new string[Class84.smethod_0(1)];
				array[Class84.smethod_0(0)] = Class86.smethod_0("\ue08e\ue097", 57544);
				return array;
			}
			if ((text == Class86.smethod_0("\uf6d3\uf6d5", 63013)) ? true : false)
			{
				string[] array2 = new string[Class84.smethod_0(1)];
				array2[Class84.smethod_0(0)] = Class86.smethod_0("\uf8a9\uf8bc\uf8bf\uf8b1\uf8b8", 63517);
				return array2;
			}
			if (text == Class86.smethod_0("\uf48b\uf497", 62705) || false || ((text == Class86.smethod_0("\uf689\uf699", 63156)) ? true : false))
			{
				string[] array3 = new string[Class84.smethod_0(6)];
				while (true)
				{
					int num = Class84.smethod_0(37);
					int num2 = Class84.smethod_0(5);
					while (true)
					{
						num2 ^= Class84.smethod_0(67);
						while (true)
						{
							int num3 = Class49.smethod_0(83);
							while (true)
							{
								switch (num3 ^ Class84.smethod_0(413))
								{
								case -113:
									break;
								case -114:
									num3 = -3;
									continue;
								case -115:
									goto IL_00b6;
								default:
									goto end_IL_014e;
								case -112:
									goto end_IL_0177;
								}
								goto IL_009c;
								IL_00b6:
								switch (num2)
								{
								case 108:
									goto IL_00db;
								case 110:
									goto IL_013d;
								case 107:
									goto IL_0182;
								case 109:
									goto end_IL_018a;
								}
								num3 = Class89.smethod_1(54);
								continue;
								IL_0182:
								num2 = 3;
								goto end_IL_0177;
								IL_00db:
								switch (num)
								{
								case 115:
									break;
								case 116:
									goto IL_0117;
								case 117:
									goto IL_0139;
								default:
									goto IL_0187;
								case 118:
									return array3;
								}
								array3[Class84.smethod_0(1)] = Class86.smethod_0("\uf8a9\uf8bc\uf8bf\uf8b1\uf8b8", 63517);
								num = 19;
								goto IL_013d;
								IL_0187:
								num2 = 5;
								goto end_IL_0177;
								IL_0139:
								num = 16;
								goto IL_013d;
								IL_0117:
								array3[Class84.smethod_0(0)] = Class86.smethod_0("\uf6d3\uf6d5", 63013);
								num = Class84.smethod_0(34);
								goto IL_013d;
								IL_009c:
								num2 = Class84.smethod_0(8);
								num3 = -29;
								continue;
								IL_013d:
								num ^= Class84.smethod_0(48);
								goto IL_009c;
								continue;
								end_IL_014e:
								break;
							}
							continue;
							end_IL_0177:
							break;
						}
						continue;
						end_IL_018a:
						break;
					}
				}
			}
		}
		return null;
	}

	private void method_53()
	{
		if (class21_0 != null || 1 == 0)
		{
			Delegate273.smethod_0(class21_0, int_0);
		}
		int_1 += Class84.smethod_0(1);
		while (true)
		{
			int num = Class89.smethod_2(92);
			int num2 = Class89.smethod_1(64);
			while (true)
			{
				num2 ^= Class84.smethod_0(51);
				while (true)
				{
					int num3 = Class84.smethod_0(399);
					while (true)
					{
						switch (num3 ^ Class84.smethod_0(409))
						{
						case 101:
							num3 = 15;
							continue;
						case 100:
							break;
						case 99:
							goto IL_00e7;
						default:
							goto end_IL_00f2;
						case 102:
							goto end_IL_0118;
						}
						switch (num2)
						{
						case -102:
							goto IL_0061;
						case -100:
							goto IL_00dd;
						case -103:
							goto IL_0125;
						case -101:
							goto end_IL_012d;
						}
						num3 = 9;
						continue;
						IL_009f:
						num = -6;
						goto IL_00dd;
						IL_0125:
						num2 = -12;
						goto end_IL_0118;
						IL_0061:
						switch (num)
						{
						case -106:
							break;
						case -105:
							goto IL_009f;
						case -104:
							goto IL_00a4;
						case -103:
							goto IL_00b5;
						case -102:
							goto IL_00cb;
						default:
							goto IL_012a;
						case -101:
							return;
						}
						int_2 += Class84.smethod_0(1);
						num = -10;
						goto IL_00dd;
						IL_012a:
						num2 = -10;
						goto end_IL_0118;
						IL_00cb:
						if (int_0 == Class84.smethod_0(80))
						{
							num = -12;
							goto IL_00dd;
						}
						int_3 += Class84.smethod_0(1);
						return;
						IL_00e7:
						num2 = Class46.Class47.smethod_0(72);
						num3 = 12;
						continue;
						IL_00dd:
						num ^= Class84.smethod_0(51);
						goto IL_00e7;
						IL_00b5:
						int_3 = Class84.smethod_0(1);
						num = Class89.smethod_1(60);
						goto IL_00dd;
						IL_00a4:
						int_4 = int_3;
						num = -9;
						goto IL_00dd;
						continue;
						end_IL_00f2:
						break;
					}
					continue;
					end_IL_0118:
					break;
				}
				continue;
				end_IL_012d:
				break;
			}
		}
	}

	private bool method_54()
	{
		if (int_0 != Class84.smethod_0(124))
		{
			return (byte)Class84.smethod_0(0) != 0;
		}
		if (int_1 < string_1.Length && string_1[int_1] == Class84.smethod_0(125))
		{
			Enum8 @enum = enum8_1;
			switch (@enum - Class84.smethod_0(1))
			{
			default:
				if (@enum == (Enum8)Class84.smethod_0(77))
				{
					Delegate274.smethod_0(this, int_1 - Class84.smethod_0(1));
				}
				break;
			case Enum8.const_0:
				Delegate276.smethod_0(this, (byte)Class84.smethod_0(1) != 0, int_1 - Class84.smethod_0(1));
				enum8_1 = (Enum8)Class84.smethod_0(6);
				break;
			case Enum8.const_2:
				Delegate275.smethod_0(this, int_1 - Class84.smethod_0(1));
				break;
			case Enum8.const_1:
				break;
			}
			enum8_0 = enum8_1;
			enum8_1 = (Enum8)Class84.smethod_0(20);
			return (byte)Class84.smethod_0(1) != 0;
		}
		if (!Delegate277.smethod_0(this, int_1 - Class84.smethod_0(1), (byte)Class84.smethod_0(1) != 0) && 0 == 0)
		{
			int_1 = string_1.Length;
			return (byte)Class84.smethod_0(1) != 0;
		}
		enum8_1 = (Enum8)Class84.smethod_0(1);
		while (true)
		{
			int num = Class84.smethod_0(72);
			int num2 = -45;
			while (true)
			{
				switch (num2 ^ Class84.smethod_0(413))
				{
				case -96:
					num ^= Class84.smethod_0(410);
					goto default;
				default:
					num2 = Class94.smethod_0(108);
					continue;
				case -98:
					switch (num)
					{
					default:
						num2 = -20;
						continue;
					case 102:
						if (int_1 - Class84.smethod_0(1) <= string_1.Length - Class84.smethod_0(6))
						{
							num = 0;
							break;
						}
						goto IL_0211;
					case 103:
						num = 14;
						break;
					case 104:
						Delegate278.smethod_0(this, (HtmlNodeType)Class84.smethod_0(6), int_1 - Class84.smethod_0(1));
						num = 3;
						break;
					case 105:
						if (string_1[int_1] == Class84.smethod_0(126))
						{
							num = 1;
							break;
						}
						goto IL_0211;
					case 106:
						{
							while (true)
							{
								int num3 = Class89.smethod_1(63);
								while (true)
								{
									switch (num3 ^ Class84.smethod_0(404))
									{
									case -106:
										Delegate279.smethod_0(this, int_1 + Class84.smethod_0(1));
										num3 = -24;
										continue;
									case -107:
										if (string_1[int_1 + Class84.smethod_0(1)] == Class84.smethod_0(122))
										{
											num3 = -11;
											continue;
										}
										goto IL_0346;
									case -108:
										Delegate276.smethod_0(this, (byte)Class84.smethod_0(1) != 0, int_1);
										num3 = Class89.smethod_1(64);
										continue;
									case -109:
										num3 = -12;
										continue;
									case -110:
										if (string_1[int_1 + Class84.smethod_0(6)] == Class84.smethod_0(122))
										{
											num3 = -9;
											continue;
										}
										goto IL_0346;
									case -111:
										if (int_1 < string_1.Length - Class84.smethod_0(6))
										{
											num3 = -14;
											continue;
										}
										goto case -105;
									case -112:
										bool_0 = (byte)Class84.smethod_0(1) != 0;
										num3 = -16;
										continue;
									case -113:
										enum8_1 = (Enum8)Class84.smethod_0(79);
										num3 = -10;
										continue;
									case -105:
										{
											return (byte)Class84.smethod_0(1) != 0;
										}
										IL_0346:
										bool_0 = (byte)Class84.smethod_0(0) != 0;
										goto case -105;
									}
									break;
								}
							}
						}
						IL_0211:
						Delegate278.smethod_0(this, (HtmlNodeType)Class84.smethod_0(1), int_1 - Class84.smethod_0(1));
						return (byte)Class84.smethod_0(1) != 0;
					}
					goto case -96;
				case -99:
					num2 = -18;
					continue;
				case -97:
					break;
				}
				break;
			}
		}
	}

	private void method_55()
	{
		int num = Class84.smethod_0(0);
		if (bool_5 || 1 == 0)
		{
			class21_0 = Delegate280.smethod_0();
		}
		hashtable_0 = new Hashtable();
		Enum8 @enum = default(Enum8);
		while (true)
		{
			int num2 = Class94.smethod_0(104);
			while (true)
			{
				switch (num2 ^ Class84.smethod_0(412))
				{
				case -92:
					int_0 = Class84.smethod_0(0);
					num2 = -49;
					continue;
				case -93:
					bool_0 = (byte)Class84.smethod_0(0) != 0;
					num2 = -5;
					continue;
				case -94:
					int_5 = string_1.Length;
					num2 = -10;
					continue;
				case -95:
					class23_1.int_6 = string_1.Length;
					num2 = -50;
					continue;
				case -96:
					int_3 = Class84.smethod_0(1);
					num2 = -7;
					continue;
				case -97:
					int_2 = Class84.smethod_0(1);
					num2 = -52;
					continue;
				case -98:
					class23_0 = Delegate226.smethod_0(this, (HtmlNodeType)Class84.smethod_0(7), Class84.smethod_0(0));
					num2 = -6;
					continue;
				case -99:
					num2 = -15;
					continue;
				case -100:
					enum8_1 = (Enum8)Class84.smethod_0(0);
					num2 = Class46.Class47.smethod_0(72);
					continue;
				case -101:
					enum8_0 = enum8_1;
					num2 = -11;
					continue;
				case -102:
					class23_2 = class23_1;
					num2 = -14;
					continue;
				case -103:
					class23_1.int_0 = string_1.Length;
					num2 = -51;
					continue;
				case -104:
					int_1 = Class84.smethod_0(0);
					num2 = -8;
					continue;
				case -105:
					list_0 = new List<Class45>();
					num2 = -13;
					continue;
				case -106:
					class36_0 = null;
					num2 = -12;
					continue;
				case -107:
					int_4 = Class84.smethod_0(1);
					num2 = -16;
					continue;
				case -108:
					Delegate278.smethod_0(this, (HtmlNodeType)Class84.smethod_0(7), Class84.smethod_0(0));
					num2 = -55;
					continue;
				case -91:
					while (int_1 < string_1.Length)
					{
						int_0 = string_1[int_1];
						while (true)
						{
							int num3 = Class89.smethod_2(92);
							while (true)
							{
								switch (num3 ^ Class84.smethod_0(404))
								{
								case -107:
									@enum = enum8_1;
									num3 = -12;
									continue;
								case -108:
									num3 = Class89.smethod_1(63);
									continue;
								case -109:
									break;
								case -110:
									Delegate281.smethod_0(this);
									num3 = -14;
									continue;
								default:
									goto end_IL_0286;
								case -106:
									goto end_IL_02b3;
								}
								switch (@enum)
								{
								default:
									num3 = -15;
									continue;
								case Enum8.const_0:
									if ((!Delegate282.smethod_0(this)) ? true : false)
									{
									}
									break;
								case Enum8.const_1:
									if (!Delegate282.smethod_0(this) && 0 == 0)
									{
										if (int_0 == Class84.smethod_0(127))
										{
											Delegate276.smethod_0(this, (byte)Class84.smethod_0(0) != 0, int_1);
										}
										else
										{
											Delegate276.smethod_0(this, (byte)Class84.smethod_0(1) != 0, int_1 - Class84.smethod_0(1));
											Delegate283.smethod_0(this);
										}
										enum8_1 = (Enum8)Class84.smethod_0(6);
									}
									break;
								case Enum8.const_2:
									if (Delegate282.smethod_0(this) ? true : false)
									{
										break;
									}
									if (Delegate284.smethod_0(int_0) || 1 == 0)
									{
										Delegate279.smethod_0(this, int_1 - Class84.smethod_0(1));
										if (enum8_1 == (Enum8)Class84.smethod_0(6))
										{
											enum8_1 = (Enum8)Class84.smethod_0(7);
										}
									}
									else if (int_0 == Class84.smethod_0(127))
									{
										Delegate279.smethod_0(this, int_1 - Class84.smethod_0(1));
										if (enum8_1 == (Enum8)Class84.smethod_0(6))
										{
											enum8_1 = (Enum8)Class84.smethod_0(8);
										}
									}
									else
									{
										if (int_0 != Class84.smethod_0(128))
										{
											break;
										}
										Delegate279.smethod_0(this, int_1 - Class84.smethod_0(1));
										if (enum8_1 == (Enum8)Class84.smethod_0(6))
										{
											if (!Delegate277.smethod_0(this, int_1, (byte)Class84.smethod_0(0) != 0) && 0 == 0)
											{
												int_1 = string_1.Length;
											}
											else if (enum8_1 == (Enum8)Class84.smethod_0(6))
											{
												enum8_1 = (Enum8)Class84.smethod_0(0);
												Delegate278.smethod_0(this, (HtmlNodeType)Class84.smethod_0(7), int_1);
											}
										}
									}
									break;
								case Enum8.const_3:
									if (Delegate282.smethod_0(this) || false || (Delegate284.smethod_0(int_0) ? true : false))
									{
										break;
									}
									if (int_0 != Class84.smethod_0(127) && int_0 != Class84.smethod_0(129))
									{
										if (int_0 == Class84.smethod_0(128))
										{
											if (!Delegate277.smethod_0(this, int_1, (byte)Class84.smethod_0(0) != 0) && 0 == 0)
											{
												int_1 = string_1.Length;
											}
											else if (enum8_1 == (Enum8)Class84.smethod_0(7))
											{
												enum8_1 = (Enum8)Class84.smethod_0(0);
												Delegate278.smethod_0(this, (HtmlNodeType)Class84.smethod_0(7), int_1);
											}
										}
										else
										{
											Delegate275.smethod_0(this, int_1 - Class84.smethod_0(1));
											enum8_1 = (Enum8)Class84.smethod_0(9);
										}
									}
									else
									{
										enum8_1 = (Enum8)Class84.smethod_0(8);
									}
									break;
								case Enum8.const_4:
									if (Delegate282.smethod_0(this) ? true : false)
									{
										break;
									}
									if (int_0 == Class84.smethod_0(128))
									{
										if (!Delegate277.smethod_0(this, int_1, (byte)Class84.smethod_0(1) != 0) && 0 == 0)
										{
											int_1 = string_1.Length;
										}
										else if (enum8_1 == (Enum8)Class84.smethod_0(8))
										{
											enum8_1 = (Enum8)Class84.smethod_0(0);
											Delegate278.smethod_0(this, (HtmlNodeType)Class84.smethod_0(7), int_1);
										}
									}
									else
									{
										enum8_1 = (Enum8)Class84.smethod_0(7);
									}
									break;
								case Enum8.const_5:
									if (Delegate282.smethod_0(this) ? true : false)
									{
										break;
									}
									if (Delegate284.smethod_0(int_0) || 1 == 0)
									{
										Delegate285.smethod_0(this, int_1 - Class84.smethod_0(1));
										enum8_1 = (Enum8)Class84.smethod_0(5);
									}
									else if (int_0 == Class84.smethod_0(130))
									{
										Delegate285.smethod_0(this, int_1 - Class84.smethod_0(1));
										enum8_1 = (Enum8)Class84.smethod_0(77);
									}
									else if (int_0 == Class84.smethod_0(128))
									{
										Delegate285.smethod_0(this, int_1 - Class84.smethod_0(1));
										if (!Delegate277.smethod_0(this, int_1, (byte)Class84.smethod_0(0) != 0) && 0 == 0)
										{
											int_1 = string_1.Length;
										}
										else if (enum8_1 == (Enum8)Class84.smethod_0(9))
										{
											enum8_1 = (Enum8)Class84.smethod_0(0);
											Delegate278.smethod_0(this, (HtmlNodeType)Class84.smethod_0(7), int_1);
										}
									}
									break;
								case Enum8.const_6:
									if (Delegate282.smethod_0(this) || false || (Delegate284.smethod_0(int_0) ? true : false))
									{
										break;
									}
									if (int_0 == Class84.smethod_0(128))
									{
										if (!Delegate277.smethod_0(this, int_1, (byte)Class84.smethod_0(0) != 0) && 0 == 0)
										{
											int_1 = string_1.Length;
										}
										else if (enum8_1 == (Enum8)Class84.smethod_0(5))
										{
											enum8_1 = (Enum8)Class84.smethod_0(0);
											Delegate278.smethod_0(this, (HtmlNodeType)Class84.smethod_0(7), int_1);
										}
									}
									else if (int_0 == Class84.smethod_0(130))
									{
										enum8_1 = (Enum8)Class84.smethod_0(77);
									}
									else
									{
										enum8_1 = (Enum8)Class84.smethod_0(7);
										Delegate283.smethod_0(this);
									}
									break;
								case Enum8.const_7:
									if (Delegate282.smethod_0(this) || false || (Delegate284.smethod_0(int_0) ? true : false))
									{
										break;
									}
									if (int_0 != Class84.smethod_0(131) && int_0 != Class84.smethod_0(132))
									{
										if (int_0 == Class84.smethod_0(128))
										{
											if (!Delegate277.smethod_0(this, int_1, (byte)Class84.smethod_0(0) != 0) && 0 == 0)
											{
												int_1 = string_1.Length;
											}
											else if (enum8_1 == (Enum8)Class84.smethod_0(77))
											{
												enum8_1 = (Enum8)Class84.smethod_0(0);
												Delegate278.smethod_0(this, (HtmlNodeType)Class84.smethod_0(7), int_1);
											}
										}
										else
										{
											Delegate274.smethod_0(this, int_1 - Class84.smethod_0(1));
											enum8_1 = (Enum8)Class84.smethod_0(75);
										}
									}
									else
									{
										enum8_1 = (Enum8)Class84.smethod_0(80);
										Delegate286.smethod_0(this, int_1, int_0);
										num = int_0;
									}
									break;
								case Enum8.const_8:
									if (Delegate282.smethod_0(this) ? true : false)
									{
										break;
									}
									if (Delegate284.smethod_0(int_0) || 1 == 0)
									{
										Delegate287.smethod_0(this, int_1 - Class84.smethod_0(1));
										enum8_1 = (Enum8)Class84.smethod_0(7);
									}
									else if (int_0 == Class84.smethod_0(128))
									{
										Delegate287.smethod_0(this, int_1 - Class84.smethod_0(1));
										if (!Delegate277.smethod_0(this, int_1, (byte)Class84.smethod_0(0) != 0) && 0 == 0)
										{
											int_1 = string_1.Length;
										}
										else if (enum8_1 == (Enum8)Class84.smethod_0(75))
										{
											enum8_1 = (Enum8)Class84.smethod_0(0);
											Delegate278.smethod_0(this, (HtmlNodeType)Class84.smethod_0(7), int_1);
										}
									}
									break;
								case Enum8.const_9:
									if (int_0 == Class84.smethod_0(128) && (((!bool_0) ? true : false) || (string_1[int_1 - Class84.smethod_0(6)] == Class84.smethod_0(122) && string_1[int_1 - Class84.smethod_0(7)] == Class84.smethod_0(122))))
									{
										if (!Delegate277.smethod_0(this, int_1, (byte)Class84.smethod_0(0) != 0) && 0 == 0)
										{
											int_1 = string_1.Length;
											break;
										}
										enum8_1 = (Enum8)Class84.smethod_0(0);
										Delegate278.smethod_0(this, (HtmlNodeType)Class84.smethod_0(7), int_1);
									}
									break;
								case Enum8.const_10:
									if (int_0 == num)
									{
										Delegate287.smethod_0(this, int_1 - Class84.smethod_0(1));
										enum8_1 = (Enum8)Class84.smethod_0(7);
									}
									else if (int_0 == Class84.smethod_0(124) && int_1 < string_1.Length && string_1[int_1] == Class84.smethod_0(125))
									{
										enum8_0 = enum8_1;
										enum8_1 = (Enum8)Class84.smethod_0(20);
									}
									break;
								case Enum8.const_11:
								{
									if (int_0 != Class84.smethod_0(125) || int_1 >= string_1.Length || string_1[int_1] != Class84.smethod_0(128))
									{
										break;
									}
									Enum8 enum2 = enum8_0;
									if (enum2 != (Enum8)Class84.smethod_0(7))
									{
										if (enum2 == (Enum8)Class84.smethod_0(77))
										{
											enum8_1 = (Enum8)Class84.smethod_0(75);
										}
										else
										{
											enum8_1 = enum8_0;
										}
									}
									else
									{
										Delegate285.smethod_0(this, int_1 + Class84.smethod_0(1));
										enum8_1 = (Enum8)Class84.smethod_0(7);
									}
									Delegate281.smethod_0(this);
									break;
								}
								case Enum8.const_12:
								{
									if (class23_0.int_4 + Class84.smethod_0(7) > string_1.Length - (int_1 - Class84.smethod_0(1)) || ((string.Compare(string_1.Substring(int_1 - Class84.smethod_0(1), class23_0.int_4 + Class84.smethod_0(6)), Class86.smethod_0("\uf6e1\uf6f2", 63133) + Delegate207.smethod_0(class23_0), (byte)Class84.smethod_0(1) != 0) != 0) ? true : false))
									{
										break;
									}
									int num4 = string_1[int_1 - Class84.smethod_0(1) + Class84.smethod_0(6) + Delegate207.smethod_0(class23_0).Length];
									if (num4 != Class84.smethod_0(128) && ((!Delegate284.smethod_0(num4)) ? true : false))
									{
										break;
									}
									Class23 @class = Delegate226.smethod_0(this, (HtmlNodeType)Class84.smethod_0(7), class23_0.int_7 + class23_0.int_6);
									while (true)
									{
										int num5 = Class89.smethod_2(91);
										while (true)
										{
											switch (num5 ^ Class84.smethod_0(409))
											{
											case -111:
												Delegate276.smethod_0(this, (byte)Class84.smethod_0(0) != 0, int_1 - Class84.smethod_0(1) + Class84.smethod_0(6));
												num5 = -26;
												continue;
											case -112:
												num5 = -6;
												continue;
											case -113:
												Delegate278.smethod_0(this, (HtmlNodeType)Class84.smethod_0(1), int_1 - Class84.smethod_0(1));
												num5 = -5;
												continue;
											case -114:
												@class.int_6 = int_1 - Class84.smethod_0(1) - @class.int_7;
												num5 = -25;
												continue;
											case -115:
												Delegate264.smethod_0(class23_0, @class);
												num5 = -27;
												continue;
											case -116:
												enum8_1 = (Enum8)Class84.smethod_0(6);
												num5 = -8;
												continue;
											case -110:
												goto end_IL_0d9d;
											}
											break;
										}
										continue;
										end_IL_0d9d:
										break;
									}
									Delegate281.smethod_0(this);
									break;
								}
								}
								goto end_IL_02b3;
								continue;
								end_IL_0286:
								break;
							}
							continue;
							end_IL_02b3:
							break;
						}
					}
					if (class23_0.int_5 > Class84.smethod_0(0))
					{
						Delegate279.smethod_0(this, int_1);
					}
					Delegate277.smethod_0(this, int_1, (byte)Class84.smethod_0(0) != 0);
					hashtable_0.Clear();
					return;
				}
				break;
			}
		}
	}

	private void method_56(int int_7)
	{
		class36_0.int_2 = int_7 - class36_0.int_3;
		Delegate288.smethod_0(Delegate201.smethod_0(class23_0), class36_0);
	}

	private void method_57(int int_7)
	{
		class36_0 = Delegate230.smethod_0(this);
		while (true)
		{
			int num = Class84.smethod_0(9);
			while (true)
			{
				switch (num ^ Class84.smethod_0(51))
				{
				case 106:
					class36_0.int_1 = int_3;
					num = 11;
					continue;
				case 105:
					Delegate289.smethod_0(class36_0, int_2);
					num = Class84.smethod_0(77);
					continue;
				case 104:
					class36_0.int_3 = int_7;
					num = 4;
					continue;
				case 103:
					num = 10;
					continue;
				case 102:
					class36_0.int_4 = int_7;
					num = 6;
					continue;
				case 107:
					return;
				}
				break;
			}
		}
	}

	private void method_58(int int_7)
	{
		class36_0.int_5 = int_7 - class36_0.int_6;
	}

	private void method_59(int int_7)
	{
		Delegate286.smethod_0(this, int_7, Class84.smethod_0(0));
	}

	private void method_60(int int_7, int int_8)
	{
		class36_0.int_6 = int_7;
		if (int_8 == Class84.smethod_0(131))
		{
			Delegate290.smethod_0(class36_0, (Enum11)Class84.smethod_0(0));
		}
	}

	private bool method_61(int int_7, bool bool_15)
	{
		class23_0.int_6 = int_7 - class23_0.int_7;
		if (class23_0.htmlNodeType_0 != (HtmlNodeType)Class84.smethod_0(7) && class23_0.htmlNodeType_0 != (HtmlNodeType)Class84.smethod_0(6))
		{
			if ((class23_0.bool_2 || 1 == 0) && class23_2 != class23_0)
			{
				if (class23_2 != null || 1 == 0)
				{
					Delegate264.smethod_0(class23_2, class23_0);
				}
				Delegate291.smethod_0(this, class23_0);
				Class23 class23_ = default(Class23);
				while (true)
				{
					int num = Class46.Class47.smethod_0(65);
					int num2 = 3;
					while (true)
					{
						switch (num2 ^ Class84.smethod_0(411))
						{
						case 108:
							break;
						default:
							goto IL_00ab;
						case 106:
							goto IL_00b8;
						case 105:
							num2 = Class84.smethod_0(5);
							continue;
						case 107:
							goto end_IL_0157;
						}
						goto IL_009e;
						IL_00b8:
						switch (num)
						{
						case -99:
							goto IL_00dd;
						case -98:
							goto IL_00ee;
						case -97:
							goto IL_010f;
						case -96:
							goto IL_0133;
						case -95:
							goto IL_0148;
						case -94:
							goto IL_0194;
						}
						num2 = 4;
						continue;
						IL_0148:
						num = -57;
						goto IL_009e;
						IL_0133:
						if (Delegate208.smethod_0(class23_0) != 0)
						{
							num = -60;
							goto IL_009e;
						}
						if (1 == 0)
						{
							goto IL_0194;
						}
						goto IL_01a7;
						IL_00dd:
						class23_0.class23_4 = class23_;
						num = -8;
						goto IL_009e;
						IL_00ee:
						hashtable_0[Delegate207.smethod_0(class23_0)] = class23_0;
						num = -58;
						goto IL_009e;
						IL_0194:
						if (Delegate208.smethod_0(class23_0) == (HtmlNodeType)Class84.smethod_0(1))
						{
							goto IL_01a7;
						}
						goto IL_01b3;
						IL_01a7:
						class23_2 = class23_0;
						goto IL_01b3;
						IL_01b3:
						if ((!Delegate292.smethod_0(Delegate271.smethod_0(this))) ? true : false)
						{
							goto end_IL_0182;
						}
						enum8_1 = (Enum8)Class84.smethod_0(31);
						return (byte)Class84.smethod_0(1) != 0;
						IL_00ab:
						num2 = Class84.smethod_0(9);
						continue;
						IL_009e:
						num ^= Class84.smethod_0(406);
						goto IL_00ab;
						IL_010f:
						class23_ = (Class23)hashtable_0[Delegate207.smethod_0(class23_0)];
						num = -5;
						goto IL_009e;
						continue;
						end_IL_0157:
						break;
					}
					continue;
					end_IL_0182:
					break;
				}
				if (Delegate260.smethod_0(Delegate207.smethod_0(class23_0)) || false || Delegate266.smethod_0(Delegate207.smethod_0(class23_0)) || 1 == 0)
				{
					bool_15 = (byte)Class84.smethod_0(1) != 0;
				}
			}
		}
		else if (class23_0.int_6 > Class84.smethod_0(0))
		{
			class23_0.int_0 = class23_0.int_6;
			class23_0.int_1 = class23_0.int_7;
			if (class23_2 != null || 1 == 0)
			{
				Delegate264.smethod_0(class23_2, class23_0);
			}
		}
		if (bool_15 || false || !class23_0.bool_2 || 1 == 0)
		{
			if ((string_2 != null || 1 == 0) && string_0 == null && 0 == 0 && string.Compare(Delegate207.smethod_0(class23_0), string_2, (byte)Class84.smethod_0(1) != 0) == 0 && 0 == 0)
			{
				int_5 = int_7;
				while (true)
				{
					int num3 = Class46.Class47.smethod_0(82);
					while (true)
					{
						switch (num3 ^ Class84.smethod_0(408))
						{
						case -103:
							num3 = -23;
							continue;
						case -104:
							string_0 = string_1.Substring(int_5);
							num3 = -25;
							continue;
						case -105:
							Delegate293.smethod_0(this);
							num3 = -22;
							continue;
						case -102:
							return (byte)Class84.smethod_0(0) != 0;
						}
						break;
					}
				}
			}
			Delegate293.smethod_0(this);
		}
		return (byte)Class84.smethod_0(1) != 0;
	}

	private void method_62(int int_7)
	{
		class23_0.int_4 = int_7 - class23_0.int_5;
		if (bool_7 || 1 == 0)
		{
			Delegate294.smethod_0(this);
		}
	}

	private void method_63(bool bool_15, int int_7)
	{
		class23_0.bool_2 = bool_15;
		class23_0.int_5 = int_7;
	}

	private void method_64(HtmlNodeType htmlNodeType_0, int int_7)
	{
		class23_0 = Delegate226.smethod_0(this, htmlNodeType_0, int_7);
		while (true)
		{
			int num = Class49.smethod_0(69);
			while (true)
			{
				switch (num ^ Class84.smethod_0(413))
				{
				case -108:
					class23_0.int_2 = int_2;
					num = -32;
					continue;
				case -109:
					class23_0.int_3 = int_3;
					num = -31;
					continue;
				case -110:
					if (htmlNodeType_0 == (HtmlNodeType)Class84.smethod_0(1))
					{
						num = -26;
						continue;
					}
					goto IL_0099;
				case -111:
					num = -30;
					continue;
				case -107:
					{
						class23_0.int_3 -= Class84.smethod_0(1);
						goto IL_0099;
					}
					IL_0099:
					class23_0.int_8 = int_7;
					return;
				}
				break;
			}
		}
	}

	private void method_65(Class23 class23_3)
	{
		if (!bool_12 || 1 == 0 || class23_3.int_4 != Class84.smethod_0(8) || ((!(Delegate207.smethod_0(class23_3) == Class86.smethod_0("\uefd6\uefde\uefcf\uefda", 61226))) ? true : false))
		{
			return;
		}
		Class36 @class = Delegate214.smethod_0(Delegate201.smethod_0(class23_3), Class86.smethod_0("\ued96\ued8a\ued8a\ued8e\uedd3\ued9b\ued8f\ued8b\ued97\ued88", 60918));
		if (@class == null || ((string.Compare(Delegate211.smethod_0(@class), Class86.smethod_0("\ue49c\ue490\ue491\ue48b\ue49a\ue491\ue48b\ue4d2\ue48b\ue486\ue48f\ue49a", 58529), (byte)Class84.smethod_0(1) != 0) != 0) ? true : false))
		{
			return;
		}
		Class36 class2 = Delegate214.smethod_0(Delegate201.smethod_0(class23_3), Class86.smethod_0("\uec84\uec88\uec89\uec93\uec82\uec89\uec93", 60645));
		if (class2 == null)
		{
			return;
		}
		string text = Delegate295.smethod_0(Delegate211.smethod_0(class2), Class86.smethod_0("\uf0dc\uf0d7\uf0de\uf0cd\uf0cc\uf0da\uf0cb", 61598));
		if (text == null)
		{
			return;
		}
		while (true)
		{
			int num = Class89.smethod_1(63);
			int num2 = -12;
			while (true)
			{
				num2 ^= Class84.smethod_0(409);
				while (true)
				{
					int num3 = Class89.smethod_1(63);
					while (true)
					{
						switch (num3 ^ Class84.smethod_0(405))
						{
						case -110:
							break;
						case -111:
							num3 = -14;
							continue;
						case -112:
							goto IL_0105;
						default:
							goto end_IL_01a1;
						case -109:
							goto end_IL_01ca;
						}
						goto IL_00ea;
						IL_0105:
						switch (num2)
						{
						case -100:
							goto IL_0125;
						case -98:
							goto IL_018f;
						case -101:
							goto IL_01d5;
						case -99:
							goto end_IL_01df;
						}
						num3 = -15;
						continue;
						IL_01d5:
						num2 = -15;
						goto end_IL_01ca;
						IL_0125:
						switch (num)
						{
						case -109:
							break;
						case -108:
							goto IL_015d;
						case -107:
							goto IL_017a;
						case -106:
							goto IL_018c;
						default:
							goto IL_01db;
						case -105:
							goto IL_0204;
						}
						encoding_0 = Encoding.GetEncoding(text.Trim());
						num = -14;
						goto IL_018f;
						IL_01db:
						num2 = -9;
						goto end_IL_01ca;
						IL_018c:
						num = -15;
						goto IL_018f;
						IL_017a:
						if (bool_1)
						{
							num = Class89.smethod_1(56);
							goto IL_018f;
						}
						if (true)
						{
							if ((encoding_1 != null || 1 == 0) && encoding_0.WindowsCodePage != encoding_1.WindowsCodePage)
							{
								Delegate248.smethod_0(this, (Enum13)Class84.smethod_0(6), int_2, int_3, int_1, Delegate225.smethod_0(class23_3), Class86.smethod_0("\ue53b\ue510\ue51d\ue511\ue51a\ue517\ue510\ue519\ue55e\ue513\ue517\ue50d\ue513\ue51f\ue50a\ue51d\ue516\ue55e\ue51c\ue51b\ue50a\ue509\ue51b\ue51b\ue510\ue55e\ue52d\ue50a\ue50c\ue51b\ue51f\ue513\ue53b\ue510\ue51d\ue511\ue51a\ue517\ue510\ue519\ue544\ue55e", 58678) + encoding_1.WebName + Class86.smethod_0("\ue3d7\ue396\ue399\ue393\ue3d7\ue3b3\ue392\ue394\ue39b\ue396\ue385\ue392\ue393\ue3b2\ue399\ue394\ue398\ue393\ue39e\ue399\ue390\ue3cd\ue3d7", 58307) + encoding_0.WebName);
							}
							return;
						}
						goto IL_0204;
						IL_018f:
						num ^= Class84.smethod_0(404);
						goto IL_00ea;
						IL_015d:
						if ((text = text.Trim()).Length > Class84.smethod_0(0))
						{
							num = -12;
							goto IL_018f;
						}
						return;
						IL_0204:
						throw Delegate296.smethod_0(encoding_0);
						IL_00ea:
						num2 = Class46.Class47.smethod_0(76);
						num3 = -16;
						continue;
						end_IL_01a1:
						break;
					}
					continue;
					end_IL_01ca:
					break;
				}
				continue;
				end_IL_01df:
				break;
			}
		}
	}
}
