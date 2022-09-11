using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.XPath;
using HtmlAgilityPack;

[DebuggerDisplay("Name: {OriginalName}}")]
internal class Class23 : IXPathNavigable
{
	internal Class11 class11_0;

	internal Class14 class14_0;

	internal Class23 class23_0;

	internal bool bool_0;

	internal string string_0;

	internal int int_0;

	internal int int_1;

	internal int int_2;

	internal int int_3;

	private string string_1;

	internal int int_4;

	internal int int_5;

	internal Class23 class23_1;

	internal HtmlNodeType htmlNodeType_0;

	internal bool bool_1;

	internal string string_2;

	internal int int_6;

	internal int int_7;

	internal Class9 class9_0;

	internal Class23 class23_2;

	internal Class23 class23_3;

	internal Class23 class23_4;

	internal bool bool_2;

	internal int int_8;

	public static readonly string string_3;

	public static readonly string string_4;

	public static readonly string string_5;

	public static Hashtable hashtable_0;

	public Class11 Class11_0
	{
		get
		{
			if (!Delegate388.smethod_0(this) && 0 == 0)
			{
				class11_0 = Delegate389.smethod_0(this);
			}
			return class11_0;
		}
		internal set
		{
			class11_0 = value;
		}
	}

	public Class14 Class14_0
	{
		get
		{
			if (class14_0 == null && 0 == 0)
			{
				class14_0 = Delegate390.smethod_0(this);
			}
			return class14_0;
		}
		internal set
		{
			class14_0 = value;
		}
	}

	public bool Boolean_0 => ((class23_0 == null) ? 1 : 0) == Class84.smethod_0(0);

	public Class11 Class11_1
	{
		get
		{
			if (!Delegate391.smethod_0(this) && 0 == 0)
			{
				return Delegate389.smethod_0(this);
			}
			return Delegate201.smethod_0(class23_0);
		}
	}

	internal Class23 Class23_0 => class23_0;

	public Class23 Class23_1
	{
		get
		{
			if (!Delegate392.smethod_0(this) && 0 == 0)
			{
				return null;
			}
			return Delegate219.smethod_0(class14_0, Class84.smethod_0(0));
		}
	}

	public bool Boolean_1
	{
		get
		{
			if (class11_0 == null && 0 == 0)
			{
				return (byte)Class84.smethod_0(0) != 0;
			}
			if (Delegate202.smethod_0(class11_0) <= Class84.smethod_0(0))
			{
				return (byte)Class84.smethod_0(0) != 0;
			}
			return (byte)Class84.smethod_0(1) != 0;
		}
	}

	public bool Boolean_2
	{
		get
		{
			if (class14_0 == null && 0 == 0)
			{
				return (byte)Class84.smethod_0(0) != 0;
			}
			if (Delegate204.smethod_0(class14_0) <= Class84.smethod_0(0))
			{
				return (byte)Class84.smethod_0(0) != 0;
			}
			return (byte)Class84.smethod_0(1) != 0;
		}
	}

	public bool Boolean_3
	{
		get
		{
			if ((class23_0 != null || 1 == 0) && class23_0 != this)
			{
				if (class23_0.class11_0 == null && 0 == 0)
				{
					return (byte)Class84.smethod_0(0) != 0;
				}
				if (Delegate202.smethod_0(class23_0.class11_0) <= Class84.smethod_0(0))
				{
					return (byte)Class84.smethod_0(0) != 0;
				}
				return (byte)Class84.smethod_0(1) != 0;
			}
			return (byte)Class84.smethod_0(0) != 0;
		}
	}

	public string String_0
	{
		get
		{
			if (class9_0.hashtable_1 == null && 0 == 0)
			{
				throw new Exception(Class9.string_4);
			}
			return Delegate393.smethod_0(this);
		}
		set
		{
			if (class9_0.hashtable_1 == null && 0 == 0)
			{
				throw new Exception(Class9.string_4);
			}
			if (value == null && 0 == 0)
			{
				throw new ArgumentNullException(Class86.smethod_0("\uf429\uf43e\uf433\uf42a\uf43a", 62529));
			}
			Delegate394.smethod_0(this, value);
		}
	}

	public virtual string String_5
	{
		get
		{
			if (bool_0 || 1 == 0)
			{
				while (true)
				{
					int num = Class89.smethod_1(54);
					int num2 = 11;
					while (true)
					{
						switch (num2 ^ Class84.smethod_0(404))
						{
						case 108:
							num ^= Class84.smethod_0(404);
							goto default;
						default:
							num2 = Class84.smethod_0(42);
							continue;
						case 106:
							switch (num)
							{
							default:
								num2 = Class84.smethod_0(31);
								continue;
							case -102:
								bool_0 = (byte)Class84.smethod_0(0) != 0;
								num = -6;
								break;
							case -101:
								string_0 = Delegate395.smethod_0(this);
								num = Class46.Class47.smethod_0(75);
								break;
							case -100:
								num = -5;
								break;
							case -99:
								return string_0;
							}
							goto case 108;
						case 105:
							num2 = 14;
							continue;
						case 107:
							break;
						}
						break;
					}
				}
			}
			if (string_0 != null || 1 == 0)
			{
				return string_0;
			}
			if (int_1 < Class84.smethod_0(0))
			{
				return string.Empty;
			}
			return class9_0.string_1.Substring(int_1, int_0);
		}
		set
		{
			Class9 object_ = Delegate185.smethod_0();
			while (true)
			{
				int num = Class89.smethod_1(57);
				while (true)
				{
					switch (num ^ Class84.smethod_0(408))
					{
					case -111:
						num = -31;
						continue;
					case -112:
						Delegate398.smethod_0(this, Delegate203.smethod_0(Delegate223.smethod_0(object_)));
						num = -30;
						continue;
					case -113:
						Delegate396.smethod_0(object_, value);
						num = -2;
						continue;
					case -114:
						Delegate397.smethod_0(this);
						num = Class49.smethod_0(80);
						continue;
					case -110:
						return;
					}
					break;
				}
			}
		}
	}

	public virtual string String_4
	{
		get
		{
			if (htmlNodeType_0 == (HtmlNodeType)Class84.smethod_0(7))
			{
				return Delegate399.smethod_0((Class25)this);
			}
			if (htmlNodeType_0 == (HtmlNodeType)Class84.smethod_0(6))
			{
				return Delegate400.smethod_0((Class24)this);
			}
			if (!Delegate392.smethod_0(this) && 0 == 0)
			{
				return string.Empty;
			}
			string text = null;
			IEnumerator<Class23> enumerator = ((IEnumerable<Class23>)Delegate401.smethod_0(this)).GetEnumerator();
			try
			{
				while (true)
				{
					if (enumerator.MoveNext() ? true : false)
					{
						Class23 current = enumerator.Current;
						text += Delegate212.smethod_0(current);
						continue;
					}
					return text;
				}
			}
			finally
			{
				if (enumerator != null || 1 == 0)
				{
					enumerator.Dispose();
				}
			}
		}
	}

	public Class23 Class23_2
	{
		get
		{
			if (Delegate392.smethod_0(this) || 1 == 0)
			{
				return Delegate219.smethod_0(class14_0, Delegate204.smethod_0(class14_0) - Class84.smethod_0(1));
			}
			return null;
		}
	}

	public int Int32_0
	{
		get
		{
			return int_2;
		}
		internal set
		{
			int_2 = value;
		}
	}

	public int Int32_1
	{
		get
		{
			return int_3;
		}
		internal set
		{
			int_3 = value;
		}
	}

	public string String_1
	{
		get
		{
			if (string_1 == null && 0 == 0)
			{
				Delegate386.smethod_0(this, class9_0.string_1.Substring(int_5, int_4));
			}
			if (string_1 == null && 0 == 0)
			{
				return string.Empty;
			}
			return string_1.ToLower();
		}
		set
		{
			string_1 = value;
		}
	}

	public Class23 Class23_3
	{
		get
		{
			return class23_1;
		}
		internal set
		{
			class23_1 = value;
		}
	}

	public HtmlNodeType HtmlNodeType_0
	{
		get
		{
			return htmlNodeType_0;
		}
		internal set
		{
			htmlNodeType_0 = value;
		}
	}

	public string String_2 => string_1;

	public virtual string String_6
	{
		get
		{
			if (bool_1 || 1 == 0)
			{
				while (true)
				{
					int num = Class89.smethod_1(61);
					int num2 = -10;
					while (true)
					{
						switch (num2 ^ Class84.smethod_0(93))
						{
						case -110:
							num ^= Class84.smethod_0(409);
							goto default;
						default:
							num2 = Class89.smethod_2(86);
							continue;
						case -112:
							num2 = -12;
							continue;
						case -113:
							switch (num)
							{
							default:
								num2 = -11;
								continue;
							case -112:
								string_2 = Delegate402.smethod_0(this);
								num = -8;
								break;
							case -111:
								num = -5;
								break;
							case -110:
								bool_1 = (byte)Class84.smethod_0(0) != 0;
								num = -7;
								break;
							case -109:
								return string_2;
							}
							goto case -110;
						case -111:
							break;
						}
						break;
					}
				}
			}
			if (string_2 != null || 1 == 0)
			{
				return string_2;
			}
			if (int_7 < Class84.smethod_0(0))
			{
				return string.Empty;
			}
			return class9_0.string_1.Substring(int_7, int_6);
		}
	}

	public Class9 Class9_0
	{
		get
		{
			return class9_0;
		}
		internal set
		{
			class9_0 = value;
		}
	}

	public Class23 Class23_4
	{
		get
		{
			return class23_2;
		}
		internal set
		{
			class23_2 = value;
		}
	}

	public Class23 Class23_5
	{
		get
		{
			return class23_3;
		}
		internal set
		{
			class23_3 = value;
		}
	}

	public int Int32_2 => int_8;

	public string String_3
	{
		get
		{
			string text = ((Delegate403.smethod_0(this) == null || ((Delegate208.smethod_0(Delegate403.smethod_0(this)) == HtmlNodeType.Document) ? true : false)) ? Class86.smethod_0("\ue398", 58295) : (Delegate404.smethod_0(Delegate403.smethod_0(this)) + Class86.smethod_0("\ue398", 58295)));
			return text + Delegate405.smethod_0(this);
		}
	}

	static Class23()
	{
		string_3 = Class86.smethod_0("\ue95d\ue91d\ue911\ue913\ue913\ue91b\ue910\ue90a", 59718);
		while (true)
		{
			int num = Class94.smethod_0(89);
			while (true)
			{
				num ^= Class84.smethod_0(410);
				switch (num)
				{
				case -88:
					hashtable_0.Add(Class86.smethod_0("\uedbe\uedba\uedb0", 60885), (Enum10)Class84.smethod_0(6));
					hashtable_0.Add(Class86.smethod_0("\uee8c\uee9d\uee8e\uee9d\uee91", 61052), (Enum10)Class84.smethod_0(6));
					num = -53;
					continue;
				case -89:
					hashtable_0.Add(Class86.smethod_0("\uec08\uec1d\uec0d", 60513), (Enum10)Class84.smethod_0(6));
					hashtable_0.Add(Class86.smethod_0("\ue2c9\ue2cc\ue2d8\ue2c4\ue2de\ue2c5\ue2cf", 58027), (Enum10)Class84.smethod_0(6));
					num = -56;
					continue;
				case -90:
					hashtable_0.Add(Class86.smethod_0("\ue978\ue96b\ue97c\ue978", 59673), (Enum10)Class84.smethod_0(6));
					hashtable_0.Add(Class86.smethod_0("\ue29f\ue298\ue286\ue283\ue282", 57904), (Enum10)Class84.smethod_0(6));
					num = -52;
					continue;
				case -91:
					hashtable_0.Add(Class86.smethod_0("\ue0dd\ue0de\ue0cc\ue0da\ue0d9\ue0d0\ue0d1\ue0cb", 57534), (Enum10)Class84.smethod_0(6));
					hashtable_0.Add(Class86.smethod_0("\uf5ba\uf5b3\uf5ae\uf5b1", 62860), (Enum10)Class84.smethod_0(80));
					num = -9;
					continue;
				case -92:
					hashtable_0.Add(Class86.smethod_0("\uefd6\uefde\uefcf\uefda", 61226), (Enum10)Class84.smethod_0(6));
					hashtable_0.Add(Class86.smethod_0("\ue596\ue58c\ue596\ue591\ue59b\ue59a\ue587", 58801), (Enum10)Class84.smethod_0(6));
					num = -11;
					continue;
				case -93:
					num = -54;
					continue;
				case -94:
					hashtable_0.Add(Class86.smethod_0("\ue2a2\ue2aa\ue2a5\ue2a2\ue2a3", 58053), (Enum10)Class84.smethod_0(6));
					hashtable_0.Add(Class86.smethod_0("\uf6d1\uf6c5\uf6d6\uf6da\uf6d2", 63029), (Enum10)Class84.smethod_0(6));
					num = -50;
					continue;
				case -95:
					hashtable_0.Add(Class86.smethod_0("\ue385\ue386\ue397\ue395\ue393\ue384", 58256), (Enum10)Class84.smethod_0(6));
					hashtable_0.Add(Class86.smethod_0("\uec84\uec8a\uec96\uec88\uec8a\uec81", 60654), (Enum10)Class84.smethod_0(6));
					num = -49;
					continue;
				case -96:
					string_4 = Class86.smethod_0("\ue99c\ue9db\ue9d0\ue9dc\ue9ca\ue9d2\ue9da\ue9d1\ue9cb", 59838);
					string_5 = Class86.smethod_0("\uf2f4\uf2a3\uf2b2\uf2af\uf2a3", 62165);
					num = -10;
					continue;
				case -97:
					hashtable_0 = new Hashtable();
					hashtable_0.Add(Class86.smethod_0("\uf68e\uf69e\uf68f\uf694\uf68d\uf689", 63028), (Enum10)Class84.smethod_0(1));
					num = -12;
					continue;
				case -98:
					hashtable_0.Add(Class86.smethod_0("\ue992\ue98d\ue989\ue994\ue992\ue993", 59892), (Enum10)Class84.smethod_0(6));
					hashtable_0.Add(Class86.smethod_0("\ue1b5\ue1a5", 57813), (Enum10)Class84.smethod_0(5));
					num = -64;
					continue;
				case -99:
					hashtable_0.Add(Class86.smethod_0("\uf38f\uf388\uf385\uf390\uf399", 62316), (Enum10)Class84.smethod_0(1));
					hashtable_0.Add(Class86.smethod_0("\uebb3\uebb2\ueba5\uebb5\ueba9\uebb0\uebb1", 60372), (Enum10)Class84.smethod_0(1));
					num = -14;
					continue;
				case -100:
					hashtable_0.Add(Class86.smethod_0("\ue293\ue289", 58056), (Enum10)Class84.smethod_0(6));
					while (true)
					{
						int num3 = Class49.smethod_0(74);
						while (true)
						{
							switch (num3 ^ Class84.smethod_0(413))
							{
							case -101:
								num3 = -24;
								continue;
							case -102:
								num = Class94.smethod_0(99);
								num3 = -17;
								continue;
							case -103:
								hashtable_0.Add(Class86.smethod_0("\ue598\ue594\ue597", 58824), (Enum10)Class84.smethod_0(6));
								num3 = Class49.smethod_0(81);
								continue;
							case -100:
								goto end_IL_03e2;
							}
							break;
						}
						continue;
						end_IL_03e2:
						break;
					}
					continue;
				case -101:
					hashtable_0.Add(Class86.smethod_0("\ue794\ue797\ue785\ue793", 59280), (Enum10)Class84.smethod_0(6));
					while (true)
					{
						int num2 = Class89.smethod_1(54);
						while (true)
						{
							switch (num2 ^ Class84.smethod_0(67))
							{
							case -107:
								num = -51;
								num2 = Class49.smethod_0(83);
								continue;
							case -108:
								hashtable_0.Add(Class86.smethod_0("\uf4b3\uf4b6\uf4b1\uf4b4", 62559), (Enum10)Class84.smethod_0(6));
								num2 = -3;
								continue;
							case -109:
								num2 = -5;
								continue;
							case -106:
								goto end_IL_046e;
							}
							break;
						}
						continue;
						end_IL_046e:
						break;
					}
					continue;
				case -87:
					hashtable_0.Add(Class86.smethod_0("\ued8f", 60926), (Enum10)Class84.smethod_0(5));
					return;
				}
				break;
			}
		}
	}

	public Class23(HtmlNodeType htmlNodeType_1, Class9 class9_1, int int_9)
	{
		htmlNodeType_0 = htmlNodeType_1;
		HtmlNodeType htmlNodeType = default(HtmlNodeType);
		while (true)
		{
			int num = Class89.smethod_2(90);
			while (true)
			{
				switch (num ^ Class84.smethod_0(50))
				{
				case -96:
					int_7 = int_9;
					num = -18;
					continue;
				case -97:
					num = -19;
					continue;
				case -98:
					switch (htmlNodeType)
					{
					default:
						num = Class76.smethod_0(107);
						continue;
					case HtmlNodeType.Document:
						Delegate386.smethod_0(this, string_4);
						class23_0 = this;
						break;
					case HtmlNodeType.Comment:
						Delegate386.smethod_0(this, string_3);
						class23_0 = this;
						break;
					case HtmlNodeType.Text:
						Delegate386.smethod_0(this, string_5);
						class23_0 = this;
						break;
					case HtmlNodeType.Element:
						break;
					}
					goto case -95;
				case -99:
					class9_0 = class9_1;
					num = -46;
					continue;
				case -100:
					htmlNodeType = htmlNodeType_1;
					num = -20;
					continue;
				case -95:
					if ((class9_0.hashtable_2 != null || 1 == 0) && !Delegate387.smethod_0(this) && 0 == 0 && -1 != int_9)
					{
						class9_0.hashtable_2.Add(int_9, this);
					}
					if (-1 == int_9 && htmlNodeType_1 != (HtmlNodeType)Class84.smethod_0(6) && htmlNodeType_1 != (HtmlNodeType)Class84.smethod_0(7))
					{
						bool_1 = (byte)Class84.smethod_0(1) != 0;
						bool_0 = (byte)Class84.smethod_0(1) != 0;
					}
					return;
				}
				break;
			}
		}
	}

	public XPathNavigator CreateNavigator()
	{
		return Delegate229.smethod_0(class9_0, this);
	}

	public static bool smethod_0(string string_6)
	{
		if (string_6 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\ueab5\ueaba\ueab6\ueabe", 60106));
		}
		object obj = hashtable_0[string_6.ToLower()];
		if (obj == null && 0 == 0)
		{
			return (byte)Class84.smethod_0(0) != 0;
		}
		return ((((uint)(Enum10)obj & (uint)Class84.smethod_0(75)) == (uint)Class84.smethod_0(0)) ? 1 : 0) == Class84.smethod_0(0);
	}

	public static Class23 smethod_1(string string_6)
	{
		Class9 object_ = Delegate185.smethod_0();
		Delegate396.smethod_0(object_, string_6);
		return Delegate217.smethod_0(Delegate223.smethod_0(object_));
	}

	public static bool smethod_2(string string_6)
	{
		if (string_6 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\ueab5\ueaba\ueab6\ueabe", 60106));
		}
		object obj = hashtable_0[string_6.ToLower()];
		if (obj == null && 0 == 0)
		{
			return (byte)Class84.smethod_0(0) != 0;
		}
		return ((((uint)(Enum10)obj & (uint)Class84.smethod_0(1)) == (uint)Class84.smethod_0(0)) ? 1 : 0) == Class84.smethod_0(0);
	}

	public static bool smethod_3(string string_6)
	{
		if (string_6 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\ueab5\ueaba\ueab6\ueabe", 60106));
		}
		object obj = hashtable_0[string_6.ToLower()];
		if (obj == null && 0 == 0)
		{
			return (byte)Class84.smethod_0(0) != 0;
		}
		return ((((uint)(Enum10)obj & (uint)Class84.smethod_0(8)) == (uint)Class84.smethod_0(0)) ? 1 : 0) == Class84.smethod_0(0);
	}

	public static bool smethod_4(string string_6)
	{
		if (string_6 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\ueab5\ueaba\ueab6\ueabe", 60106));
		}
		if (string_6.Length == 0 && 0 == 0)
		{
			return (byte)Class84.smethod_0(1) != 0;
		}
		if (Class84.smethod_0(126) == string_6[Class84.smethod_0(0)])
		{
			return (byte)Class84.smethod_0(1) != 0;
		}
		if (Class84.smethod_0(129) == string_6[Class84.smethod_0(0)])
		{
			return (byte)Class84.smethod_0(1) != 0;
		}
		object obj = hashtable_0[string_6.ToLower()];
		if (obj == null && 0 == 0)
		{
			return (byte)Class84.smethod_0(0) != 0;
		}
		return ((((uint)(Enum10)obj & (uint)Class84.smethod_0(6)) == (uint)Class84.smethod_0(0)) ? 1 : 0) == Class84.smethod_0(0);
	}

	public static bool smethod_5(string string_6)
	{
		if (string_6 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\uec03\uec12\uec0f\uec03", 60419));
		}
		if (string_6.Length <= Class84.smethod_0(8))
		{
			return (byte)Class84.smethod_0(0) != 0;
		}
		if (string_6[Class84.smethod_0(0)] == Class84.smethod_0(124))
		{
			while (true)
			{
				int num = Class84.smethod_0(46);
				int num2 = -31;
				while (true)
				{
					num2 ^= Class84.smethod_0(50);
					while (true)
					{
						int num3 = Class49.smethod_0(81);
						while (true)
						{
							switch (num3 ^ Class84.smethod_0(50))
							{
							case -100:
								break;
							case -101:
								goto IL_0060;
							case -102:
								num3 = -24;
								continue;
							default:
								goto end_IL_0102;
							case -99:
								goto end_IL_0125;
							}
							goto IL_0050;
							IL_0060:
							switch (num2)
							{
							case -110:
								goto IL_0083;
							case -109:
								goto IL_00ed;
							case -112:
								goto IL_012f;
							case -111:
								goto end_IL_0137;
							}
							num3 = Class46.Class47.smethod_0(79);
							continue;
							IL_012f:
							num2 = -30;
							goto end_IL_0125;
							IL_0083:
							switch (num)
							{
							case 101:
								break;
							case 102:
								goto IL_00be;
							case 103:
								goto IL_00c8;
							default:
								goto IL_0134;
							case 104:
								goto end_IL_0143;
							}
							if (string_6[Class84.smethod_0(1)] != Class84.smethod_0(127))
							{
								num = 27;
								goto IL_00ed;
							}
							string text = string_6.Substring(Class84.smethod_0(6), string_6.Length - Class84.smethod_0(7));
							return Delegate265.smethod_0(text);
							IL_0134:
							num2 = -29;
							goto end_IL_0125;
							IL_00c8:
							if (string_6[string_6.Length - Class84.smethod_0(1)] != Class84.smethod_0(128))
							{
								goto end_IL_0143;
							}
							num = 22;
							goto IL_00ed;
							IL_0050:
							num2 = Class49.smethod_0(80);
							num3 = -17;
							continue;
							IL_00be:
							num = Class84.smethod_0(54);
							goto IL_00ed;
							IL_00ed:
							num ^= Class84.smethod_0(413);
							goto IL_0050;
							continue;
							end_IL_0102:
							break;
						}
						continue;
						end_IL_0125:
						break;
					}
					continue;
					end_IL_0137:
					break;
				}
				continue;
				end_IL_0143:
				break;
			}
		}
		return (byte)Class84.smethod_0(0) != 0;
	}

	public IEnumerable<Class23> method_0()
	{
		Class26 @class = Delegate406.smethod_0(Class84.smethod_0(134));
		@class.class23_1 = this;
		return @class;
	}

	public IEnumerable<Class23> method_1(string string_6)
	{
		Class27 @class = Delegate407.smethod_0(Class84.smethod_0(134));
		while (true)
		{
			int num = Class84.smethod_0(75);
			while (true)
			{
				switch (num ^ Class84.smethod_0(405))
				{
				case 107:
					@class.class23_1 = this;
					num = 9;
					continue;
				case 106:
					@class.string_1 = string_6;
					num = 15;
					continue;
				case 105:
					num = Class84.smethod_0(80);
					continue;
				case 108:
					return @class;
				}
				break;
			}
		}
	}

	public IEnumerable<Class23> method_2()
	{
		Class28 @class = Delegate408.smethod_0(Class84.smethod_0(134));
		@class.class23_1 = this;
		return @class;
	}

	public IEnumerable<Class23> method_3(string string_6)
	{
		Class29 @class = Delegate409.smethod_0(Class84.smethod_0(134));
		while (true)
		{
			int num = Class84.smethod_0(56);
			while (true)
			{
				switch (num ^ Class84.smethod_0(406))
				{
				case 116:
					@class.class23_1 = this;
					num = 20;
					continue;
				case 115:
					num = Class84.smethod_0(54);
					continue;
				case 114:
					@class.string_1 = string_6;
					num = 19;
					continue;
				case 117:
					return @class;
				}
				break;
			}
		}
	}

	public Class23 method_4(Class23 class23_5)
	{
		if (class23_5 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\ue392\ue399\ue38b\ue3bf\ue394\ue395\ue390\ue398", 58236));
		}
		Delegate410.smethod_0(Delegate401.smethod_0(this), class23_5);
		while (true)
		{
			int num = Class84.smethod_0(56);
			int num2 = 14;
			while (true)
			{
				switch (num2 ^ Class84.smethod_0(405))
				{
				case 109:
					num ^= Class84.smethod_0(406);
					goto default;
				default:
					num2 = Class84.smethod_0(79);
					continue;
				case 108:
					num2 = 15;
					continue;
				case 106:
					switch (num)
					{
					default:
						num2 = 8;
						continue;
					case 113:
						bool_1 = (byte)Class84.smethod_0(1) != 0;
						num = Class84.smethod_0(54);
						break;
					case 114:
						num = 20;
						break;
					case 115:
						bool_0 = (byte)Class84.smethod_0(1) != 0;
						num = 19;
						break;
					case 116:
						Delegate412.smethod_0(class9_0, class23_5, Delegate411.smethod_0(class23_5));
						num = 23;
						break;
					case 117:
						return class23_5;
					}
					goto case 109;
				case 107:
					break;
				}
				break;
			}
		}
	}

	public void method_5(Class14 class14_1)
	{
		if (class14_1 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\uf7c1\uf7ca\uf7d8\uf7ec\uf7c7\uf7c6\uf7c3\uf7cb\uf7dd\uf7ca\uf7c1\uf7cb", 63406));
		}
		IEnumerator<Class23> enumerator = ((IEnumerable<Class23>)class14_1).GetEnumerator();
		try
		{
			while (enumerator.MoveNext() ? true : false)
			{
				Class23 current = enumerator.Current;
				Delegate413.smethod_0(this, current);
			}
		}
		finally
		{
			if (enumerator != null || 1 == 0)
			{
				enumerator.Dispose();
			}
		}
	}

	public IEnumerable<Class36> method_6(string string_6)
	{
		return Delegate415.smethod_0(Delegate414.smethod_0(this), string_6);
	}

	public Class23 method_7()
	{
		return Delegate416.smethod_0(this, (byte)Class84.smethod_0(1) != 0);
	}

	public Class23 method_8(string string_6)
	{
		return Delegate417.smethod_0(this, string_6, (byte)Class84.smethod_0(1) != 0);
	}

	public Class23 method_9(string string_6, bool bool_3)
	{
		if (string_6 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\ue977\ue97c\ue96e\ue957\ue978\ue974\ue97c", 59657));
		}
		Class23 @class = Delegate416.smethod_0(this, bool_3);
		Delegate237.smethod_0(@class, string_6);
		return @class;
	}

	public Class23 method_10(bool bool_3)
	{
		Class23 @class = Delegate418.smethod_0(class9_0, htmlNodeType_0);
		HtmlNodeType htmlNodeType = default(HtmlNodeType);
		while (true)
		{
			int num = Class84.smethod_0(69);
			while (true)
			{
				switch (num ^ Class84.smethod_0(51))
				{
				case 117:
					num = 24;
					continue;
				case 116:
					switch (htmlNodeType - Class84.smethod_0(6))
					{
					default:
						num = 27;
						break;
					case HtmlNodeType.Document:
						Delegate236.smethod_0((Class24)@class, Delegate400.smethod_0((Class24)this));
						return @class;
					case HtmlNodeType.Element:
						Delegate239.smethod_0((Class25)@class, Delegate399.smethod_0((Class25)this));
						return @class;
					}
					continue;
				case 115:
					Delegate237.smethod_0(@class, Delegate419.smethod_0(this));
					num = 31;
					continue;
				case 114:
					htmlNodeType = htmlNodeType_0;
					num = 25;
					continue;
				case 118:
				{
					if (Delegate388.smethod_0(this) || 1 == 0)
					{
						IEnumerator<Class36> enumerator = ((IEnumerable<Class36>)class11_0).GetEnumerator();
						try
						{
							while (enumerator.MoveNext() ? true : false)
							{
								Class36 current = enumerator.Current;
								Class36 class36_ = Delegate420.smethod_0(current);
								Delegate288.smethod_0(Delegate201.smethod_0(@class), class36_);
							}
						}
						finally
						{
							if (enumerator != null || 1 == 0)
							{
								enumerator.Dispose();
							}
						}
					}
					if (Delegate391.smethod_0(this) || 1 == 0)
					{
						@class.class23_0 = Delegate224.smethod_0(class23_0, (byte)Class84.smethod_0(0) != 0);
						IEnumerator<Class36> enumerator2 = ((IEnumerable<Class36>)class23_0.class11_0).GetEnumerator();
						try
						{
							while (enumerator2.MoveNext() ? true : false)
							{
								Class36 current2 = enumerator2.Current;
								Class36 class36_2 = Delegate420.smethod_0(current2);
								Delegate288.smethod_0(@class.class23_0.class11_0, class36_2);
							}
						}
						finally
						{
							if (enumerator2 != null || 1 == 0)
							{
								enumerator2.Dispose();
							}
						}
					}
					if (!bool_3 && 0 == 0)
					{
						return @class;
					}
					if (!Delegate392.smethod_0(this) && 0 == 0)
					{
						return @class;
					}
					IEnumerator<Class23> enumerator3 = ((IEnumerable<Class23>)class14_0).GetEnumerator();
					try
					{
						while (true)
						{
							if (enumerator3.MoveNext() ? true : false)
							{
								Class23 current3 = enumerator3.Current;
								Class23 class2 = Delegate421.smethod_0(current3);
								Delegate264.smethod_0(@class, class2);
								continue;
							}
							return @class;
						}
					}
					finally
					{
						if (enumerator3 != null || 1 == 0)
						{
							enumerator3.Dispose();
						}
					}
				}
				}
				break;
			}
		}
	}

	public void method_11(Class23 class23_5)
	{
		Delegate422.smethod_0(this, class23_5, (byte)Class84.smethod_0(1) != 0);
	}

	public void method_12(Class23 class23_5, bool bool_3)
	{
		if (class23_5 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\ueb91\ueb90\ueb9b\ueb9a", 60337));
		}
		Delegate423.smethod_0(Delegate414.smethod_0(this));
		if (Delegate424.smethod_0(class23_5) || 1 == 0)
		{
			IEnumerator<Class36> enumerator = ((IEnumerable<Class36>)Delegate201.smethod_0(class23_5)).GetEnumerator();
			try
			{
				while (enumerator.MoveNext() ? true : false)
				{
					Class36 current = enumerator.Current;
					Delegate425.smethod_0(this, Delegate206.smethod_0(current), Delegate211.smethod_0(current));
				}
			}
			finally
			{
				if (enumerator != null || 1 == 0)
				{
					enumerator.Dispose();
				}
			}
		}
		if (bool_3 ? true : false)
		{
			return;
		}
		while (true)
		{
			int num = Class46.Class47.smethod_0(76);
			int num2 = Class89.smethod_1(52);
			while (true)
			{
				switch (num2 ^ Class84.smethod_0(410))
				{
				case -101:
					num ^= Class84.smethod_0(414);
					goto default;
				default:
					num2 = Class89.smethod_1(63);
					continue;
				case -102:
					switch (num)
					{
					default:
						num2 = -15;
						continue;
					case -99:
						Delegate397.smethod_0(this);
						num = -11;
						break;
					case -98:
						if (Delegate218.smethod_0(class23_5))
						{
							num = -53;
							break;
						}
						if (true)
						{
							return;
						}
						goto case -96;
					case -97:
						num = Class89.smethod_1(66);
						break;
					case -96:
					{
						IEnumerator<Class23> enumerator2 = ((IEnumerable<Class23>)Delegate203.smethod_0(class23_5)).GetEnumerator();
						try
						{
							while (enumerator2.MoveNext() ? true : false)
							{
								Class23 current2 = enumerator2.Current;
								Delegate413.smethod_0(this, Delegate224.smethod_0(current2, (byte)Class84.smethod_0(1) != 0));
							}
							return;
						}
						finally
						{
							if (enumerator2 != null || 1 == 0)
							{
								enumerator2.Dispose();
							}
						}
					}
					}
					goto case -101;
				case -103:
					num2 = -16;
					continue;
				case -104:
					break;
				}
				break;
			}
		}
	}

	public XPathNavigator method_13()
	{
		return Delegate229.smethod_0(class9_0, Delegate223.smethod_0(class9_0));
	}

	public IEnumerable<Class23> method_14()
	{
		Class30 @class = Delegate426.smethod_0(Class84.smethod_0(134));
		@class.class23_1 = this;
		return @class;
	}

	public IEnumerable<Class23> method_15()
	{
		return Delegate427.smethod_0(this);
	}

	public IEnumerable<Class23> method_16()
	{
		Class31 @class = Delegate428.smethod_0(Class84.smethod_0(134));
		@class.class23_1 = this;
		return @class;
	}

	public IEnumerable<Class23> method_17(string string_6)
	{
		Class32 @class = Delegate429.smethod_0(Class84.smethod_0(134));
		while (true)
		{
			int num = Class89.smethod_1(66);
			while (true)
			{
				switch (num ^ Class84.smethod_0(48))
				{
				case -109:
					num = Class46.Class47.smethod_0(76);
					continue;
				case -110:
					@class.string_1 = string_6;
					num = -15;
					continue;
				case -111:
					@class.class23_1 = this;
					num = -9;
					continue;
				case -108:
					return @class;
				}
				break;
			}
		}
	}

	public IEnumerable<Class23> method_18()
	{
		Class33 @class = Delegate430.smethod_0(Class84.smethod_0(134));
		@class.class23_1 = this;
		return @class;
	}

	public IEnumerable<Class23> method_19(string string_6)
	{
		Class34 @class = Delegate431.smethod_0(Class84.smethod_0(134));
		while (true)
		{
			int num = Class89.smethod_1(66);
			while (true)
			{
				switch (num ^ Class84.smethod_0(51))
				{
				case -101:
					@class.string_1 = string_6;
					num = Class89.smethod_1(64);
					continue;
				case -102:
					num = -9;
					continue;
				case -103:
					@class.class23_1 = this;
					num = -10;
					continue;
				case -100:
					return @class;
				}
				break;
			}
		}
	}

	public Class23 method_20(string string_6)
	{
		IEnumerator<Class23> enumerator = ((IEnumerable<Class23>)Delegate401.smethod_0(this)).GetEnumerator();
		try
		{
			while (enumerator.MoveNext() ? true : false)
			{
				Class23 current = enumerator.Current;
				if (Delegate207.smethod_0(current) == string_6 || 1 == 0)
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

	public IEnumerable<Class23> method_21(string string_6)
	{
		Class35 @class = Delegate432.smethod_0(Class84.smethod_0(134));
		while (true)
		{
			int num = Class89.smethod_1(61);
			while (true)
			{
				switch (num ^ Class84.smethod_0(67))
				{
				case -109:
					@class.string_1 = string_6;
					num = -4;
					continue;
				case -110:
					@class.class23_1 = this;
					num = Class89.smethod_1(60);
					continue;
				case -111:
					num = -7;
					continue;
				case -108:
					return @class;
				}
				break;
			}
		}
	}

	public string method_22(string string_6, string string_7)
	{
		if (string_6 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\ueab5\ueaba\ueab6\ueabe", 60106));
		}
		if (!Delegate388.smethod_0(this) && 0 == 0)
		{
			return string_7;
		}
		Class36 @class = Delegate214.smethod_0(Delegate414.smethod_0(this), string_6);
		if (@class == null && 0 == 0)
		{
			return string_7;
		}
		return Delegate211.smethod_0(@class);
	}

	public int method_23(string string_6, int int_9)
	{
		if (string_6 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\ueab5\ueaba\ueab6\ueabe", 60106));
		}
		if (!Delegate388.smethod_0(this) && 0 == 0)
		{
			return int_9;
		}
		Class36 @class = Delegate214.smethod_0(Delegate414.smethod_0(this), string_6);
		if (@class == null && 0 == 0)
		{
			return int_9;
		}
		try
		{
			return Convert.ToInt32(Delegate211.smethod_0(@class));
		}
		catch
		{
			return int_9;
		}
	}

	public bool method_24(string string_6, bool bool_3)
	{
		if (string_6 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\ueab5\ueaba\ueab6\ueabe", 60106));
		}
		if (!Delegate388.smethod_0(this) && 0 == 0)
		{
			return bool_3;
		}
		Class36 @class = Delegate214.smethod_0(Delegate414.smethod_0(this), string_6);
		if (@class == null && 0 == 0)
		{
			return bool_3;
		}
		try
		{
			return Convert.ToBoolean(Delegate211.smethod_0(@class));
		}
		catch
		{
			return bool_3;
		}
	}

	public Class23 method_25(Class23 class23_5, Class23 class23_6)
	{
		if (class23_5 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\ue392\ue399\ue38b\ue3bf\ue394\ue395\ue390\ue398", 58236));
		}
		if (class23_6 == null && 0 == 0)
		{
			return Delegate433.smethod_0(this, class23_5);
		}
		if (class23_5 == class23_6)
		{
			return class23_5;
		}
		int num = -1;
		if (class14_0 != null || 1 == 0)
		{
			num = Delegate434.smethod_0(class14_0, class23_6);
		}
		if (num == -1)
		{
			throw new ArgumentException(Class9.string_3);
		}
		if (class14_0 != null || 1 == 0)
		{
			Delegate435.smethod_0(class14_0, num + Class84.smethod_0(1), class23_5);
		}
		Delegate412.smethod_0(class9_0, class23_5, Delegate411.smethod_0(class23_5));
		while (true)
		{
			int num2 = Class84.smethod_0(55);
			int num3 = 20;
			while (true)
			{
				num3 ^= Class84.smethod_0(50);
				while (true)
				{
					int num4 = Class89.smethod_1(55);
					while (true)
					{
						switch (num4 ^ Class84.smethod_0(410))
						{
						case -111:
							break;
						case -112:
							goto IL_0107;
						case -113:
							num4 = -26;
							continue;
						default:
							goto end_IL_011c;
						case -110:
							goto end_IL_0142;
						}
						switch (num3)
						{
						case 100:
							goto IL_00b8;
						case 102:
							goto IL_00fd;
						case 101:
							goto IL_0151;
						case 99:
							goto end_IL_0159;
						}
						num4 = -7;
						continue;
						IL_00fd:
						num2 ^= Class84.smethod_0(50);
						goto IL_0107;
						IL_0151:
						num3 = Class84.smethod_0(49);
						goto end_IL_0142;
						IL_00b8:
						switch (num2)
						{
						case 107:
							break;
						case 108:
							goto IL_00e9;
						case 109:
							goto IL_00ee;
						default:
							goto IL_014c;
						case 110:
							return class23_5;
						}
						bool_1 = (byte)Class84.smethod_0(1) != 0;
						num2 = Class84.smethod_0(91);
						goto IL_00fd;
						IL_014c:
						num3 = 17;
						goto end_IL_0142;
						IL_00ee:
						bool_0 = (byte)Class84.smethod_0(1) != 0;
						num2 = 28;
						goto IL_00fd;
						IL_00e9:
						num2 = 30;
						goto IL_00fd;
						IL_0107:
						num3 = Class84.smethod_0(34);
						num4 = Class89.smethod_1(60);
						continue;
						end_IL_011c:
						break;
					}
					continue;
					end_IL_0142:
					break;
				}
				continue;
				end_IL_0159:
				break;
			}
		}
	}

	public Class23 method_26(Class23 class23_5, Class23 class23_6)
	{
		if (class23_5 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\ue392\ue399\ue38b\ue3bf\ue394\ue395\ue390\ue398", 58236));
		}
		if (class23_6 == null && 0 == 0)
		{
			return Delegate413.smethod_0(this, class23_5);
		}
		if (class23_5 == class23_6)
		{
			return class23_5;
		}
		int num = -1;
		if (class14_0 != null || 1 == 0)
		{
			num = Delegate434.smethod_0(class14_0, class23_6);
		}
		if (num == -1)
		{
			throw new ArgumentException(Class9.string_3);
		}
		if (class14_0 != null || 1 == 0)
		{
			Delegate435.smethod_0(class14_0, num, class23_5);
		}
		Delegate412.smethod_0(class9_0, class23_5, Delegate411.smethod_0(class23_5));
		while (true)
		{
			int num2 = Class89.smethod_1(63);
			int num3 = 25;
			while (true)
			{
				num3 ^= Class84.smethod_0(67);
				while (true)
				{
					int num4 = Class84.smethod_0(37);
					while (true)
					{
						switch (num4 ^ Class84.smethod_0(50))
						{
						case 101:
							num4 = Class84.smethod_0(49);
							continue;
						case 100:
							break;
						case 99:
							goto IL_00aa;
						default:
							goto end_IL_011c;
						case 102:
							goto end_IL_013f;
						}
						goto IL_009d;
						IL_00aa:
						switch (num3)
						{
						case 111:
							goto IL_00c8;
						case 113:
							goto IL_010d;
						case 110:
							goto IL_0149;
						case 112:
							goto end_IL_0150;
						}
						num4 = 22;
						continue;
						IL_0149:
						num3 = 6;
						goto end_IL_013f;
						IL_00c8:
						switch (num2)
						{
						case -108:
							break;
						case -107:
							goto IL_00f4;
						case -106:
							goto IL_010a;
						default:
							goto IL_014d;
						case -105:
							return class23_5;
						}
						bool_0 = (byte)Class84.smethod_0(1) != 0;
						num2 = -15;
						goto IL_010d;
						IL_014d:
						num3 = 24;
						goto end_IL_013f;
						IL_010a:
						num2 = -16;
						goto IL_010d;
						IL_00f4:
						bool_1 = (byte)Class84.smethod_0(1) != 0;
						num2 = Class89.smethod_1(52);
						goto IL_010d;
						IL_009d:
						num3 = Class84.smethod_0(77);
						num4 = 20;
						continue;
						IL_010d:
						num2 ^= Class84.smethod_0(406);
						goto IL_009d;
						continue;
						end_IL_011c:
						break;
					}
					continue;
					end_IL_013f:
					break;
				}
				continue;
				end_IL_0150:
				break;
			}
		}
	}

	public Class23 method_27(Class23 class23_5)
	{
		if (class23_5 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\ue392\ue399\ue38b\ue3bf\ue394\ue395\ue390\ue398", 58236));
		}
		Delegate436.smethod_0(Delegate401.smethod_0(this), class23_5);
		while (true)
		{
			int num = Class46.Class47.smethod_0(82);
			int num2 = -12;
			while (true)
			{
				switch (num2 ^ Class84.smethod_0(409))
				{
				case -98:
					num ^= Class84.smethod_0(413);
					goto default;
				default:
					num2 = Class46.Class47.smethod_0(72);
					continue;
				case -99:
					switch (num)
					{
					default:
						num2 = -10;
						continue;
					case -101:
						Delegate412.smethod_0(class9_0, class23_5, Delegate411.smethod_0(class23_5));
						num = -17;
						break;
					case -100:
						bool_1 = (byte)Class84.smethod_0(1) != 0;
						num = -18;
						break;
					case -99:
						bool_0 = (byte)Class84.smethod_0(1) != 0;
						num = -20;
						break;
					case -98:
						num = -19;
						break;
					case -97:
						return class23_5;
					}
					goto case -98;
				case -101:
					num2 = Class89.smethod_1(64);
					continue;
				case -100:
					break;
				}
				break;
			}
		}
	}

	public void method_28(Class14 class14_1)
	{
		if (class14_1 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\ue098\ue093\ue081\ue0b5\ue09e\ue09f\ue09a\ue092\ue084\ue093\ue098", 57584));
		}
		IEnumerator<Class23> enumerator = ((IEnumerable<Class23>)class14_1).GetEnumerator();
		try
		{
			while (enumerator.MoveNext() ? true : false)
			{
				Class23 current = enumerator.Current;
				Delegate433.smethod_0(this, current);
			}
		}
		finally
		{
			if (enumerator != null || 1 == 0)
			{
				enumerator.Dispose();
			}
		}
	}

	public void method_29()
	{
		if (Delegate403.smethod_0(this) != null || 1 == 0)
		{
			Delegate437.smethod_0(Delegate203.smethod_0(Delegate403.smethod_0(this)), this);
		}
	}

	public void method_30()
	{
		Delegate397.smethod_0(this);
		if (Delegate388.smethod_0(this) || 1 == 0)
		{
			Delegate438.smethod_0(class11_0);
		}
		if ((class23_0 != null || 1 == 0) && class23_0 != this && (class23_0.class11_0 != null || 1 == 0))
		{
			Delegate438.smethod_0(class23_0.class11_0);
		}
		bool_1 = (byte)Class84.smethod_0(1) != 0;
		bool_0 = (byte)Class84.smethod_0(1) != 0;
	}

	public void method_31()
	{
		if (!Delegate392.smethod_0(this) && 0 == 0)
		{
			return;
		}
		if (class9_0.bool_13 || 1 == 0)
		{
			IEnumerator<Class23> enumerator = ((IEnumerable<Class23>)class14_0).GetEnumerator();
			try
			{
				while (enumerator.MoveNext() ? true : false)
				{
					Class23 current = enumerator.Current;
					Delegate412.smethod_0(class9_0, null, Delegate411.smethod_0(current));
				}
			}
			finally
			{
				if (enumerator != null || 1 == 0)
				{
					enumerator.Dispose();
				}
			}
		}
		Delegate439.smethod_0(class14_0);
		while (true)
		{
			int num = Class46.Class47.smethod_0(75);
			int num2 = 4;
			while (true)
			{
				num2 ^= Class84.smethod_0(413);
				while (true)
				{
					int num3 = Class89.smethod_2(86);
					while (true)
					{
						switch (num3 ^ Class84.smethod_0(408))
						{
						case -100:
							break;
						case -101:
							goto IL_008c;
						case -102:
							num3 = -22;
							continue;
						default:
							goto end_IL_00fe;
						case -99:
							goto end_IL_0127;
						}
						goto IL_007e;
						IL_008c:
						switch (num2)
						{
						case 118:
							goto IL_00ab;
						case 119:
							goto IL_00eb;
						case 116:
							goto IL_0132;
						case 117:
							goto end_IL_0138;
						}
						num3 = -20;
						continue;
						IL_0132:
						num2 = 7;
						goto end_IL_0127;
						IL_00ab:
						switch (num)
						{
						case -102:
							break;
						case -101:
							goto IL_00d7;
						case -100:
							goto IL_00e8;
						default:
							goto IL_0136;
						case -99:
							return;
						}
						bool_0 = (byte)Class84.smethod_0(1) != 0;
						num = -5;
						goto IL_00eb;
						IL_0136:
						num2 = 6;
						goto end_IL_0127;
						IL_00e8:
						num = -6;
						goto IL_00eb;
						IL_00d7:
						bool_1 = (byte)Class84.smethod_0(1) != 0;
						num = -4;
						goto IL_00eb;
						IL_007e:
						num2 = Class84.smethod_0(9);
						num3 = -19;
						continue;
						IL_00eb:
						num ^= Class84.smethod_0(406);
						goto IL_007e;
						continue;
						end_IL_00fe:
						break;
					}
					continue;
					end_IL_0127:
					break;
				}
				continue;
				end_IL_0138:
				break;
			}
		}
	}

	public Class23 method_32(Class23 class23_5)
	{
		if (class23_5 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\ue590\ue593\ue59b\ue5bc\ue597\ue596\ue593\ue59b", 58799));
		}
		int num = -1;
		if (class14_0 != null || 1 == 0)
		{
			num = Delegate434.smethod_0(class14_0, class23_5);
		}
		if (num == -1)
		{
			throw new ArgumentException(Class9.string_3);
		}
		if (class14_0 != null || 1 == 0)
		{
			Delegate440.smethod_0(class14_0, num);
		}
		Delegate412.smethod_0(class9_0, null, Delegate411.smethod_0(class23_5));
		while (true)
		{
			int num2 = Class49.smethod_0(84);
			int num3 = 9;
			while (true)
			{
				num3 ^= Class84.smethod_0(411);
				while (true)
				{
					int num4 = Class84.smethod_0(55);
					while (true)
					{
						switch (num4 ^ Class84.smethod_0(410))
						{
						case 113:
							num4 = 24;
							continue;
						case 112:
							break;
						case 111:
							goto IL_00f0;
						default:
							goto end_IL_00fb;
						case 114:
							goto end_IL_0121;
						}
						switch (num3)
						{
						case 100:
							goto IL_00a3;
						case 102:
							goto IL_00e3;
						case 101:
							goto IL_0130;
						case 99:
							goto end_IL_0133;
						}
						num4 = Class84.smethod_0(5);
						continue;
						IL_00e3:
						num2 ^= Class84.smethod_0(408);
						goto IL_00f0;
						IL_0130:
						num3 = 10;
						goto end_IL_0121;
						IL_00a3:
						switch (num2)
						{
						case -107:
							break;
						case -106:
							goto IL_00cf;
						case -105:
							goto IL_00e0;
						default:
							goto IL_012b;
						case -104:
							return class23_5;
						}
						bool_1 = (byte)Class84.smethod_0(1) != 0;
						num2 = -26;
						goto IL_00e3;
						IL_012b:
						num3 = 12;
						goto end_IL_0121;
						IL_00e0:
						num2 = -25;
						goto IL_00e3;
						IL_00cf:
						bool_0 = (byte)Class84.smethod_0(1) != 0;
						num2 = -24;
						goto IL_00e3;
						IL_00f0:
						num3 = Class84.smethod_0(20);
						num4 = 27;
						continue;
						end_IL_00fb:
						break;
					}
					continue;
					end_IL_0121:
					break;
				}
				continue;
				end_IL_0133:
				break;
			}
		}
	}

	public Class23 method_33(Class23 class23_5, bool bool_3)
	{
		if (class23_5 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\ue590\ue593\ue59b\ue5bc\ue597\ue596\ue593\ue59b", 58799));
		}
		if ((class23_5.class14_0 != null || 1 == 0) && (bool_3 || 1 == 0))
		{
			Class23 @class = Delegate222.smethod_0(class23_5);
			IEnumerator<Class23> enumerator = ((IEnumerable<Class23>)class23_5.class14_0).GetEnumerator();
			try
			{
				while (enumerator.MoveNext() ? true : false)
				{
					Class23 current = enumerator.Current;
					Delegate441.smethod_0(this, current, @class);
				}
			}
			finally
			{
				if (enumerator != null || 1 == 0)
				{
					enumerator.Dispose();
				}
			}
		}
		Delegate442.smethod_0(this, class23_5);
		while (true)
		{
			int num = Class84.smethod_0(75);
			int num2 = 28;
			while (true)
			{
				num2 ^= Class84.smethod_0(408);
				while (true)
				{
					int num3 = Class84.smethod_0(42);
					while (true)
					{
						switch (num3 ^ Class84.smethod_0(414))
						{
						case 103:
							num3 = 12;
							continue;
						case 102:
							break;
						case 101:
							goto IL_0104;
						default:
							goto end_IL_0115;
						case 104:
							goto end_IL_013e;
						}
						switch (num2)
						{
						case 106:
							goto IL_00b5;
						case 108:
							goto IL_00fa;
						case 107:
							goto IL_014f;
						case 105:
							goto end_IL_0158;
						}
						num3 = 14;
						continue;
						IL_00fa:
						num ^= Class84.smethod_0(93);
						goto IL_0104;
						IL_014f:
						num2 = Class84.smethod_0(71);
						goto end_IL_013e;
						IL_00b5:
						switch (num)
						{
						case 107:
							break;
						case 108:
							goto IL_00e6;
						case 109:
							goto IL_00f7;
						default:
							goto IL_0149;
						case 110:
							return class23_5;
						}
						bool_0 = (byte)Class84.smethod_0(1) != 0;
						num = Class84.smethod_0(80);
						goto IL_00fa;
						IL_0149:
						num2 = 25;
						goto end_IL_013e;
						IL_00f7:
						num = 9;
						goto IL_00fa;
						IL_00e6:
						bool_1 = (byte)Class84.smethod_0(1) != 0;
						num = 15;
						goto IL_00fa;
						IL_0104:
						num2 = Class84.smethod_0(33);
						num3 = Class84.smethod_0(7);
						continue;
						end_IL_0115:
						break;
					}
					continue;
					end_IL_013e:
					break;
				}
				continue;
				end_IL_0158:
				break;
			}
		}
	}

	public Class23 method_34(Class23 class23_5, Class23 class23_6)
	{
		if (class23_5 == null && 0 == 0)
		{
			return Delegate442.smethod_0(this, class23_6);
		}
		if (class23_6 == null && 0 == 0)
		{
			return Delegate413.smethod_0(this, class23_5);
		}
		int num = -1;
		if (class14_0 != null || 1 == 0)
		{
			num = Delegate434.smethod_0(class14_0, class23_6);
		}
		if (num == -1)
		{
			throw new ArgumentException(Class9.string_3);
		}
		if (class14_0 != null || 1 == 0)
		{
			Delegate443.smethod_0(class14_0, num, class23_5);
		}
		Delegate412.smethod_0(class9_0, null, Delegate411.smethod_0(class23_6));
		while (true)
		{
			int num2 = Class84.smethod_0(0);
			int num3 = -5;
			while (true)
			{
				num3 ^= Class84.smethod_0(410);
				while (true)
				{
					int num4 = Class84.smethod_0(91);
					while (true)
					{
						switch (num4 ^ Class84.smethod_0(413))
						{
						case 109:
							break;
						case 108:
							goto IL_0090;
						case 107:
							num4 = Class84.smethod_0(58);
							continue;
						default:
							goto end_IL_011c;
						case 110:
							goto end_IL_0142;
						}
						goto IL_0080;
						IL_0090:
						switch (num3)
						{
						case -113:
							goto IL_00ae;
						case -110:
							goto IL_0105;
						case -112:
							goto IL_0151;
						case -111:
							goto end_IL_0159;
						}
						num4 = 30;
						continue;
						IL_0151:
						num3 = Class46.Class47.smethod_0(65);
						goto end_IL_0142;
						IL_00ae:
						switch (num2)
						{
						case 99:
							break;
						case 100:
							goto IL_00d1;
						case 101:
							goto IL_00e1;
						case 102:
							goto IL_00f7;
						default:
							goto IL_014c;
						case 103:
							return class23_5;
						}
						num2 = 6;
						goto IL_0105;
						IL_014c:
						num3 = -8;
						goto end_IL_0142;
						IL_00f7:
						bool_0 = (byte)Class84.smethod_0(1) != 0;
						num2 = 2;
						goto IL_0105;
						IL_00e1:
						Delegate412.smethod_0(class9_0, class23_5, Delegate411.smethod_0(class23_5));
						num2 = 1;
						goto IL_0105;
						IL_00d1:
						bool_1 = (byte)Class84.smethod_0(1) != 0;
						num2 = 3;
						goto IL_0105;
						IL_0080:
						num3 = Class49.smethod_0(94);
						num4 = 29;
						continue;
						IL_0105:
						num2 ^= Class84.smethod_0(48);
						goto IL_0080;
						continue;
						end_IL_011c:
						break;
					}
					continue;
					end_IL_0142:
					break;
				}
				continue;
				end_IL_0159:
				break;
			}
		}
	}

	public Class14 method_35(string string_6)
	{
		Class14 @class = Delegate390.smethod_0(null);
		XPathNodeIterator xPathNodeIterator = default(XPathNodeIterator);
		Class8 class2 = default(Class8);
		while (true)
		{
			int num = Class89.smethod_1(64);
			while (true)
			{
				switch (num ^ Class84.smethod_0(67))
				{
				case -101:
					xPathNodeIterator = class2.Select(string_6);
					num = -12;
					continue;
				case -102:
					num = Class89.smethod_1(52);
					continue;
				case -103:
					class2 = Delegate229.smethod_0(class9_0, this);
					num = -13;
					continue;
				case -100:
					while (xPathNodeIterator.MoveNext() ? true : false)
					{
						Class8 object_ = (Class8)xPathNodeIterator.Current;
						Delegate445.smethod_0(@class, Delegate444.smethod_0(object_));
					}
					if (Delegate204.smethod_0(@class) == 0 && 0 == 0)
					{
						return null;
					}
					return @class;
				}
				break;
			}
		}
	}

	public Class23 method_36(string string_6)
	{
		if (string_6 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\ue383\ue38b\ue39a\ue38f\ue393", 58328));
		}
		Class8 @class = Delegate229.smethod_0(class9_0, this);
		XPathNodeIterator xPathNodeIterator = @class.Select(string_6);
		if (!xPathNodeIterator.MoveNext() && 0 == 0)
		{
			return null;
		}
		Class8 object_ = (Class8)xPathNodeIterator.Current;
		return Delegate444.smethod_0(object_);
	}

	public Class36 method_37(string string_6, string string_7)
	{
		if (string_6 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\ueab5\ueaba\ueab6\ueabe", 60106));
		}
		Class36 @class = Delegate214.smethod_0(Delegate414.smethod_0(this), string_6);
		if (@class == null && 0 == 0)
		{
			return Delegate288.smethod_0(Delegate414.smethod_0(this), Delegate332.smethod_0(class9_0, string_6, string_7));
		}
		Delegate233.smethod_0(@class, string_7);
		return @class;
	}

	public void method_38(TextWriter textWriter_0)
	{
		if (class14_0 == null && 0 == 0)
		{
			return;
		}
		IEnumerator<Class23> enumerator = ((IEnumerable<Class23>)class14_0).GetEnumerator();
		try
		{
			while (enumerator.MoveNext() ? true : false)
			{
				Class23 current = enumerator.Current;
				Delegate252.smethod_0(current, textWriter_0);
			}
		}
		finally
		{
			if (enumerator != null || 1 == 0)
			{
				enumerator.Dispose();
			}
		}
	}

	public string method_39()
	{
		StringWriter stringWriter = new StringWriter();
		while (true)
		{
			int num = Class84.smethod_0(49);
			while (true)
			{
				switch (num ^ Class84.smethod_0(60))
				{
				case 101:
					stringWriter.Flush();
					num = 18;
					continue;
				case 100:
					num = 16;
					continue;
				case 99:
					Delegate446.smethod_0(this, stringWriter);
					num = Class84.smethod_0(37);
					continue;
				case 102:
					return stringWriter.ToString();
				}
				break;
			}
		}
	}

	public void method_40(TextWriter textWriter_0)
	{
		switch (htmlNodeType_0)
		{
		case HtmlNodeType.Document:
			if (class9_0.bool_8 || 1 == 0)
			{
				textWriter_0.Write(Class86.smethod_0("\ue0d3\ue0d0\ue097\ue082\ue083\ue0cf\ue099\ue08a\ue09d\ue09c\ue086\ue080\ue081\ue0d2\ue0cd\ue0de\ue0c1\ue0df\ue0cd\ue0cf\ue08a\ue081\ue08c\ue080\ue08b\ue086\ue081\ue088\ue0d2\ue0cd", 57582) + Delegate448.smethod_0(class9_0).BodyName + Class86.smethod_0("\uf78c\uf791\uf790", 63362));
				if (Delegate218.smethod_0(Delegate223.smethod_0(class9_0)) || 1 == 0)
				{
					int num = Delegate204.smethod_0(Delegate223.smethod_0(class9_0).class14_0);
					Class23 @class = default(Class23);
					while (true)
					{
						int num2 = Class84.smethod_0(69);
						while (true)
						{
							switch (num2 ^ Class84.smethod_0(407))
							{
							case 113:
								break;
							case 112:
								goto IL_00ab;
							case 111:
								num2 = 1;
								continue;
							case 110:
								@class = Delegate449.smethod_0(class9_0);
								num2 = 31;
								continue;
							default:
								goto end_IL_00d1;
							case 114:
								goto IL_010f;
							}
							if (@class != null)
							{
								num2 = 28;
								continue;
							}
							if (1 == 0)
							{
								goto IL_010f;
							}
							goto IL_0118;
							IL_00ab:
							if (num <= Class84.smethod_0(0))
							{
								goto end_IL_00fe;
							}
							num2 = 0;
							continue;
							IL_0118:
							if (num <= Class84.smethod_0(1))
							{
								goto end_IL_00fe;
							}
							goto IL_0124;
							IL_010f:
							num -= Class84.smethod_0(1);
							goto IL_0118;
							continue;
							end_IL_00d1:
							break;
						}
						continue;
						IL_0124:
						if (class9_0.bool_11 || 1 == 0)
						{
							textWriter_0.Write(Class86.smethod_0("\ue6c3\ue6ac\ue6af\ue6be\ue6b1\ue6c1", 59135));
							while (true)
							{
								int num3 = Class89.smethod_1(54);
								while (true)
								{
									switch (num3 ^ Class84.smethod_0(410))
									{
									case -105:
										textWriter_0.Write(Class86.smethod_0("\uef42\uef51\uef2d\uef2e\uef3f\uef30\uef40", 61254));
										num3 = Class89.smethod_1(64);
										continue;
									case -106:
										num3 = -1;
										continue;
									case -107:
										Delegate446.smethod_0(this, textWriter_0);
										num3 = -2;
										continue;
									case -104:
										return;
									}
									break;
								}
							}
						}
						textWriter_0.Write(Class86.smethod_0("\ue9fb\ue9b4\ue9b7\ue9a6\ue9a9\ue9f9", 59717));
						while (true)
						{
							int num4 = Class84.smethod_0(54);
							while (true)
							{
								switch (num4 ^ Class84.smethod_0(59))
								{
								case 102:
									num4 = 23;
									continue;
								case 101:
									textWriter_0.Write(Class86.smethod_0("\ue487\ue494\ue4c8\ue4cb\ue4da\ue4d5\ue485", 58554));
									num4 = 22;
									continue;
								case 100:
									Delegate446.smethod_0(this, textWriter_0);
									num4 = 20;
									continue;
								case 103:
									return;
								}
								break;
							}
						}
						continue;
						end_IL_00fe:
						break;
					}
				}
			}
			Delegate446.smethod_0(this, textWriter_0);
			break;
		case HtmlNodeType.Element:
		{
			string text = (((!class9_0.bool_11) ? true : false) ? Delegate419.smethod_0(this) : Delegate419.smethod_0(this).ToUpper());
			if (class9_0.bool_10 || 1 == 0)
			{
				text = Delegate451.smethod_0(this);
			}
			if (class9_0.bool_8 || 1 == 0)
			{
				if (text.Length <= Class84.smethod_0(0) || text[Class84.smethod_0(0)] == Class84.smethod_0(129) || text.Trim().Length == 0 || 1 == 0)
				{
					break;
				}
				text = Delegate452.smethod_0(text);
			}
			textWriter_0.Write(Class86.smethod_0("\ueeca", 60976) + text);
			Delegate453.smethod_0(this, textWriter_0, (byte)Class84.smethod_0(0) != 0);
			if (!Delegate392.smethod_0(this) && 0 == 0)
			{
				if (Delegate266.smethod_0(Delegate419.smethod_0(this)) || 1 == 0)
				{
					if (!class9_0.bool_14 && 0 == 0 && ((!class9_0.bool_8) ? true : false))
					{
						if (Delegate419.smethod_0(this).Length > Class84.smethod_0(0) && Delegate419.smethod_0(this)[Class84.smethod_0(0)] == Class84.smethod_0(129))
						{
							textWriter_0.Write(Class86.smethod_0("\ue410", 58382));
						}
						textWriter_0.Write(Class86.smethod_0("\uf8c3", 63613));
					}
					else
					{
						textWriter_0.Write(Class86.smethod_0("\ue94f\ue940\ue951", 59758));
					}
				}
				else
				{
					textWriter_0.Write(Class86.smethod_0("\ue1e2\ue1e0\ue1f3", 57612) + text + Class86.smethod_0("\uf8c3", 63613));
				}
				break;
			}
			textWriter_0.Write(Class86.smethod_0("\uf8c3", 63613));
			bool flag = (byte)Class84.smethod_0(0) != 0;
			if ((class9_0.bool_8 || 1 == 0) && (Delegate292.smethod_0(Delegate419.smethod_0(this)) || 1 == 0))
			{
				flag = (byte)Class84.smethod_0(1) != 0;
				textWriter_0.Write(Class86.smethod_0("\ueffb\ueffc\uefd9\uefd9\uefca\uefd7\uefad\uefb5\uefb2\uefb7\uefa2\uefb7\uefad\ueffb\ueffc", 61184));
			}
			if (flag || 1 == 0)
			{
				if (Delegate392.smethod_0(this) || 1 == 0)
				{
					Delegate252.smethod_0(Delegate219.smethod_0(Delegate401.smethod_0(this), Class84.smethod_0(0)), textWriter_0);
				}
				textWriter_0.Write(Class86.smethod_0("\ue29a\ue29d\ue2b8\ue2b8\ue2ca\ue2ca\ue2a9\ue2b8\ue2b8\ue29a\ue29d", 58005));
			}
			else
			{
				Delegate446.smethod_0(this, textWriter_0);
			}
			textWriter_0.Write(Class86.smethod_0("\uf6e1\uf6f2", 63133) + text);
			if (!class9_0.bool_8 && 0 == 0)
			{
				Delegate453.smethod_0(this, textWriter_0, (byte)Class84.smethod_0(1) != 0);
			}
			textWriter_0.Write(Class86.smethod_0("\uf8c3", 63613));
			break;
		}
		case HtmlNodeType.Comment:
		{
			string value = Delegate400.smethod_0((Class24)this);
			if (class9_0.bool_8 || 1 == 0)
			{
				textWriter_0.Write(Class86.smethod_0("\ue0c2\ue0df\ue0d3\ue0d3", 57590) + Delegate447.smethod_0((Class24)this) + Class86.smethod_0("\uebd7\uebda\uebda\uebc9", 60307));
			}
			else
			{
				textWriter_0.Write(value);
			}
			break;
		}
		case HtmlNodeType.Text:
		{
			string value = Delegate399.smethod_0((Class25)this);
			if (class9_0.bool_8 || 1 == 0)
			{
				textWriter_0.Write(Delegate450.smethod_0(value));
			}
			else
			{
				textWriter_0.Write(value);
			}
			break;
		}
		}
	}

	public void method_41(XmlWriter xmlWriter_0)
	{
		switch (htmlNodeType_0)
		{
		case HtmlNodeType.Document:
		{
			xmlWriter_0.WriteProcessingInstruction(Class86.smethod_0("\uf8c3\uf8d6\uf8d7", 63530), Class86.smethod_0("\uf0ad\uf0be\uf0a9\uf0a8\uf0b2\uf0b4\uf0b5\uf0e6\uf0f9\uf0ea\uf0f5\uf0eb\uf0f9\uf0fb\uf0be\uf0b5\uf0b8\uf0b4\uf0bf\uf0b2\uf0b5\uf0bc\uf0e6\uf0f9", 61530) + Delegate448.smethod_0(class9_0).BodyName + Class86.smethod_0("\uedfd", 60879));
			if ((!Delegate392.smethod_0(this)) ? true : false)
			{
				break;
			}
			IEnumerator<Class23> enumerator2 = ((IEnumerable<Class23>)Delegate401.smethod_0(this)).GetEnumerator();
			try
			{
				while (enumerator2.MoveNext() ? true : false)
				{
					Class23 current2 = enumerator2.Current;
					Delegate253.smethod_0(current2, xmlWriter_0);
				}
				break;
			}
			finally
			{
				if (enumerator2 != null || 1 == 0)
				{
					enumerator2.Dispose();
				}
			}
		}
		case HtmlNodeType.Element:
		{
			string localName = ((class9_0.bool_11 ? true : false) ? Delegate419.smethod_0(this).ToUpper() : Delegate419.smethod_0(this));
			if (class9_0.bool_10 || 1 == 0)
			{
				localName = Delegate451.smethod_0(this);
			}
			xmlWriter_0.WriteStartElement(localName);
			while (true)
			{
				int num = Class89.smethod_2(86);
				int num2 = Class84.smethod_0(6);
				while (true)
				{
					switch (num2 ^ Class84.smethod_0(411))
					{
					case 109:
						num ^= Class84.smethod_0(59);
						goto default;
					default:
						num2 = Class84.smethod_0(9);
						continue;
					case 108:
						num2 = 3;
						continue;
					case 106:
						switch (num)
						{
						default:
							num2 = 4;
							continue;
						case -102:
							Delegate454.smethod_0(xmlWriter_0, this);
							num = -22;
							break;
						case -101:
							if (Delegate392.smethod_0(this))
							{
								num = Class94.smethod_0(111);
								break;
							}
							if (1 == 0)
							{
								goto case -99;
							}
							goto IL_01fa;
						case -100:
							num = -19;
							break;
						case -99:
							{
								IEnumerator<Class23> enumerator = ((IEnumerable<Class23>)Delegate401.smethod_0(this)).GetEnumerator();
								try
								{
									while (enumerator.MoveNext() ? true : false)
									{
										Class23 current = enumerator.Current;
										Delegate253.smethod_0(current, xmlWriter_0);
									}
								}
								finally
								{
									if (enumerator != null || 1 == 0)
									{
										enumerator.Dispose();
									}
								}
								goto IL_01fa;
							}
							IL_01fa:
							xmlWriter_0.WriteEndElement();
							return;
						}
						goto case 109;
					case 107:
						break;
					}
					break;
				}
			}
		}
		case HtmlNodeType.Comment:
			xmlWriter_0.WriteComment(Delegate447.smethod_0((Class24)this));
			break;
		case HtmlNodeType.Text:
		{
			string text = Delegate399.smethod_0((Class25)this);
			xmlWriter_0.WriteString(text);
			break;
		}
		}
	}

	public string method_42()
	{
		StringWriter stringWriter = new StringWriter();
		try
		{
			Delegate455.smethod_0(this, stringWriter);
			string result = default(string);
			while (true)
			{
				int num = Class89.smethod_1(64);
				while (true)
				{
					switch (num ^ Class84.smethod_0(51))
					{
					case -98:
						num = -13;
						continue;
					case -99:
						result = stringWriter.ToString();
						num = Class89.smethod_1(52);
						continue;
					case -100:
						stringWriter.Flush();
						num = -16;
						continue;
					case -97:
						return result;
					}
					break;
				}
			}
		}
		finally
		{
			if (stringWriter != null || 1 == 0)
			{
				((IDisposable)stringWriter).Dispose();
			}
		}
	}

	internal static string smethod_6(Class24 class24_0)
	{
		string text = Delegate209.smethod_0(class24_0);
		return text.Substring(Class84.smethod_0(8), text.Length - Class84.smethod_0(77)).Replace(Class86.smethod_0("\uf6d2\uf6d2", 63153), Class86.smethod_0("\ue2d7\ue2da\ue2d7\ue2da", 58051));
	}

	internal static void smethod_7(XmlWriter xmlWriter_0, Class23 class23_5)
	{
		if (!Delegate424.smethod_0(class23_5) && 0 == 0)
		{
			return;
		}
		using Dictionary<string, Class36>.ValueCollection.Enumerator enumerator = Delegate201.smethod_0(class23_5).dictionary_0.Values.GetEnumerator();
		while (enumerator.MoveNext() ? true : false)
		{
			Class36 current = enumerator.Current;
			xmlWriter_0.WriteAttributeString(Delegate456.smethod_0(current), Delegate211.smethod_0(current));
		}
	}

	internal void method_43(Class23 class23_5)
	{
		if (!class9_0.bool_3 && 0 == 0 && (class14_0 != null || 1 == 0))
		{
			IEnumerator<Class23> enumerator = ((IEnumerable<Class23>)class14_0).GetEnumerator();
			try
			{
				while (enumerator.MoveNext() ? true : false)
				{
					Class23 current = enumerator.Current;
					if (!Delegate258.smethod_0(current) && 0 == 0)
					{
						Class23 @class = Delegate257.smethod_0(Delegate457.smethod_0(this), class9_0, -1);
						@class.class23_0 = @class;
						Delegate261.smethod_0(current, @class);
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
		}
		if (Delegate387.smethod_0(this) ? true : false)
		{
			return;
		}
		class23_0 = class23_5;
		if (class9_0.hashtable_2 != null || 1 == 0)
		{
			class9_0.hashtable_2.Remove(int_7);
		}
		Class23 class2 = class9_0.hashtable_0[Delegate419.smethod_0(this)] as Class23;
		while (true)
		{
			int num = Class46.Class47.smethod_0(76);
			int num2 = -6;
			while (true)
			{
				num2 ^= Class84.smethod_0(411);
				while (true)
				{
					int num3 = Class84.smethod_0(8);
					while (true)
					{
						switch (num3 ^ Class84.smethod_0(60))
						{
						case 113:
							break;
						case 112:
							goto IL_0102;
						case 111:
							num3 = 27;
							continue;
						default:
							goto end_IL_018d;
						case 114:
							goto end_IL_01b3;
						}
						goto IL_00f1;
						IL_0102:
						switch (num2)
						{
						case -110:
							goto IL_0127;
						case -107:
							goto IL_0175;
						case -108:
							goto IL_01c8;
						case -109:
							goto end_IL_01cc;
						}
						num3 = Class84.smethod_0(9);
						continue;
						IL_01c8:
						num2 = -5;
						goto end_IL_01b3;
						IL_0127:
						switch (num)
						{
						case -113:
							break;
						case -112:
							goto IL_015f;
						case -111:
							if (class2 == this)
							{
								goto IL_0171;
							}
							goto IL_01f7;
						default:
							goto IL_01bd;
						case -110:
							{
								Delegate458.smethod_0(class9_0);
								goto IL_01f7;
							}
							IL_01f7:
							if (class23_5 != this)
							{
								int_1 = int_7 + int_6;
								int_0 = class23_5.int_7 - int_1;
								int_6 = class23_5.int_7 + class23_5.int_6 - int_7;
							}
							return;
						}
						class9_0.hashtable_0.Remove(Delegate419.smethod_0(this));
						num = -11;
						goto IL_0175;
						IL_01bd:
						num2 = Class89.smethod_1(54);
						goto end_IL_01b3;
						IL_0171:
						num = -24;
						goto IL_0175;
						IL_015f:
						num = Class46.Class47.smethod_0(72);
						goto IL_0175;
						IL_00f1:
						num2 = Class46.Class47.smethod_0(75);
						num3 = 6;
						continue;
						IL_0175:
						num ^= Class84.smethod_0(404);
						goto IL_00f1;
						continue;
						end_IL_018d:
						break;
					}
					continue;
					end_IL_01b3:
					break;
				}
				continue;
				end_IL_01cc:
				break;
			}
		}
	}

	internal string method_44()
	{
		Class36 @class = Delegate214.smethod_0(Delegate414.smethod_0(this), Class86.smethod_0("\ue9c6\ue9cb", 59790));
		if (@class == null && 0 == 0)
		{
			return null;
		}
		return Delegate211.smethod_0(@class);
	}

	internal void method_45(string string_6)
	{
		Class36 @class = Delegate214.smethod_0(Delegate414.smethod_0(this), Class86.smethod_0("\ue9c6\ue9cb", 59790));
		if (@class == null && 0 == 0)
		{
			@class = Delegate331.smethod_0(class9_0, Class86.smethod_0("\ue9c6\ue9cb", 59790));
		}
		Delegate233.smethod_0(@class, string_6);
		while (true)
		{
			int num = Class84.smethod_0(91);
			int num2 = Class84.smethod_0(69);
			while (true)
			{
				num2 ^= Class84.smethod_0(59);
				while (true)
				{
					int num3 = Class89.smethod_1(54);
					while (true)
					{
						switch (num3 ^ Class84.smethod_0(409))
						{
						case -106:
							break;
						case -108:
							goto IL_00bf;
						case -107:
							num3 = -1;
							continue;
						default:
							goto end_IL_00d3;
						case -105:
							goto end_IL_00f9;
						}
						switch (num2)
						{
						case 110:
							goto IL_0069;
						case 111:
							goto IL_00b5;
						case 109:
							goto IL_0103;
						case 108:
							goto end_IL_010b;
						}
						num3 = -2;
						continue;
						IL_00b5:
						num ^= Class84.smethod_0(59);
						goto IL_00bf;
						IL_0103:
						num2 = 28;
						goto end_IL_00f9;
						IL_0069:
						switch (num)
						{
						case 110:
							break;
						case 111:
							goto IL_009e;
						case 112:
							goto IL_00ae;
						default:
							goto IL_0108;
						case 113:
							return;
						}
						Delegate412.smethod_0(class9_0, this, Delegate211.smethod_0(@class));
						num = 30;
						goto IL_00b5;
						IL_0108:
						num2 = 29;
						goto end_IL_00f9;
						IL_00ae:
						num = Class84.smethod_0(1);
						goto IL_00b5;
						IL_009e:
						bool_1 = (byte)Class84.smethod_0(1) != 0;
						num = 0;
						goto IL_00b5;
						IL_00bf:
						num2 = Class84.smethod_0(91);
						num3 = Class46.Class47.smethod_0(75);
						continue;
						end_IL_00d3:
						break;
					}
					continue;
					end_IL_00f9:
					break;
				}
				continue;
				end_IL_010b:
				break;
			}
		}
	}

	internal void method_46(TextWriter textWriter_0, Class36 class36_0)
	{
		string text = ((Delegate459.smethod_0(class36_0) == (Enum11)Class84.smethod_0(1)) ? Class86.smethod_0("\uedfd", 60879) : Class86.smethod_0("\ue4da", 58484));
		string text2;
		if (class9_0.bool_8 || 1 == 0)
		{
			text2 = (((!class9_0.bool_11) ? true : false) ? Delegate456.smethod_0(class36_0) : Delegate456.smethod_0(class36_0).ToUpper());
			if (class9_0.bool_10 || 1 == 0)
			{
				text2 = Delegate460.smethod_0(class36_0);
			}
			string[] array = new string[Class84.smethod_0(5)];
			array[Class84.smethod_0(0)] = Class86.smethod_0("\uefd7", 61379);
			array[Class84.smethod_0(1)] = text2;
			array[Class84.smethod_0(6)] = Class86.smethod_0("\uef44", 61289);
			array[Class84.smethod_0(7)] = text;
			array[Class84.smethod_0(8)] = Delegate450.smethod_0(Delegate461.smethod_0(class36_0));
			array[Class84.smethod_0(9)] = text;
			textWriter_0.Write(string.Concat(array));
			return;
		}
		text2 = (((!class9_0.bool_11) ? true : false) ? Delegate206.smethod_0(class36_0) : Delegate206.smethod_0(class36_0).ToUpper());
		if (Delegate206.smethod_0(class36_0).Length >= Class84.smethod_0(8) && Delegate206.smethod_0(class36_0)[Class84.smethod_0(0)] == Class84.smethod_0(124) && Delegate206.smethod_0(class36_0)[Class84.smethod_0(1)] == Class84.smethod_0(125) && Delegate206.smethod_0(class36_0)[Delegate206.smethod_0(class36_0).Length - Class84.smethod_0(1)] == Class84.smethod_0(128))
		{
			while (true)
			{
				int num = Class46.Class47.smethod_0(76);
				int num2 = 2;
				while (true)
				{
					num2 ^= Class84.smethod_0(51);
					while (true)
					{
						int num3 = Class89.smethod_1(55);
						while (true)
						{
							switch (num3 ^ Class84.smethod_0(67))
							{
							case -112:
								break;
							case -113:
								goto IL_024b;
							case -114:
								num3 = -26;
								continue;
							default:
								goto end_IL_0262;
							case -111:
								goto end_IL_0288;
							}
							switch (num2)
							{
							case 110:
								goto IL_01c9;
							case 111:
								goto IL_023c;
							case 109:
								goto IL_0293;
							case 108:
								goto end_IL_02a0;
							}
							num3 = -25;
							continue;
							IL_023c:
							num ^= Class84.smethod_0(407);
							goto IL_024b;
							IL_0293:
							num2 = 0;
							goto end_IL_0288;
							IL_01c9:
							switch (num)
							{
							case -104:
								break;
							case -103:
								goto IL_0217;
							case -102:
								goto IL_021d;
							default:
								goto IL_0298;
							case -101:
								return;
							}
							if (Delegate206.smethod_0(class36_0)[Delegate206.smethod_0(class36_0).Length - Class84.smethod_0(6)] != Class84.smethod_0(125))
							{
								goto end_IL_02ae;
							}
							num = -12;
							goto IL_023c;
							IL_0298:
							num2 = Class84.smethod_0(1);
							goto end_IL_0288;
							IL_021d:
							textWriter_0.Write(Class86.smethod_0("\uefd7", 61379) + text2);
							num = -11;
							goto IL_023c;
							IL_0217:
							num = -9;
							goto IL_023c;
							IL_024b:
							num2 = Class84.smethod_0(7);
							num3 = Class46.Class47.smethod_0(65);
							continue;
							end_IL_0262:
							break;
						}
						continue;
						end_IL_0288:
						break;
					}
					continue;
					end_IL_02a0:
					break;
				}
				continue;
				end_IL_02ae:
				break;
			}
		}
		if (class9_0.bool_9 || 1 == 0)
		{
			string text3 = Delegate211.smethod_0(class36_0);
			char[] array2 = new char[Class84.smethod_0(8)];
			RuntimeHelpers.InitializeArray(array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			if (text3.IndexOfAny(array2) < Class84.smethod_0(0))
			{
				textWriter_0.Write(Class86.smethod_0("\uefd7", 61379) + text2 + Class86.smethod_0("\uef44", 61289) + Delegate211.smethod_0(class36_0));
				return;
			}
			string[] array3 = new string[Class84.smethod_0(5)];
			array3[Class84.smethod_0(0)] = Class86.smethod_0("\uefd7", 61379);
			array3[Class84.smethod_0(1)] = text2;
			array3[Class84.smethod_0(6)] = Class86.smethod_0("\uef44", 61289);
			array3[Class84.smethod_0(7)] = text;
			array3[Class84.smethod_0(8)] = Delegate211.smethod_0(class36_0);
			array3[Class84.smethod_0(9)] = text;
			textWriter_0.Write(string.Concat(array3));
		}
		else
		{
			string[] array4 = new string[Class84.smethod_0(5)];
			array4[Class84.smethod_0(0)] = Class86.smethod_0("\uefd7", 61379);
			array4[Class84.smethod_0(1)] = text2;
			array4[Class84.smethod_0(6)] = Class86.smethod_0("\uef44", 61289);
			array4[Class84.smethod_0(7)] = text;
			array4[Class84.smethod_0(8)] = Delegate211.smethod_0(class36_0);
			array4[Class84.smethod_0(9)] = text;
			textWriter_0.Write(string.Concat(array4));
		}
	}

	internal void method_47(TextWriter textWriter_0, bool bool_3)
	{
		if (class9_0.bool_8 || 1 == 0)
		{
			if (class11_0 == null)
			{
				return;
			}
			using Dictionary<string, Class36>.ValueCollection.Enumerator enumerator = class11_0.dictionary_0.Values.GetEnumerator();
			while (enumerator.MoveNext() ? true : false)
			{
				Class36 current = enumerator.Current;
				Delegate462.smethod_0(this, textWriter_0, current);
			}
			return;
		}
		if (!bool_3 && 0 == 0)
		{
			if (class11_0 != null || 1 == 0)
			{
				IEnumerator<Class36> enumerator2 = ((IEnumerable<Class36>)class11_0).GetEnumerator();
				try
				{
					while (enumerator2.MoveNext() ? true : false)
					{
						Class36 current2 = enumerator2.Current;
						Delegate462.smethod_0(this, textWriter_0, current2);
					}
				}
				finally
				{
					if (enumerator2 != null || 1 == 0)
					{
						enumerator2.Dispose();
					}
				}
			}
			if ((!class9_0.bool_2) ? true : false)
			{
				return;
			}
			Delegate462.smethod_0(this, textWriter_0, Delegate332.smethod_0(class9_0, Class86.smethod_0("\ueee4\ueed8\ueed7\ueed4\ueec8\ueede\ueedf", 61115), Delegate387.smethod_0(this).ToString()));
			int num4 = default(int);
			while (true)
			{
				int num = Class84.smethod_0(75);
				int num2 = -16;
				while (true)
				{
					num2 ^= Class84.smethod_0(407);
					while (true)
					{
						int num3 = Class84.smethod_0(46);
						while (true)
						{
							switch (num3 ^ Class84.smethod_0(93))
							{
							case 114:
								break;
							case 113:
								num3 = 21;
								continue;
							case 112:
								goto IL_0137;
							default:
								goto end_IL_01db;
							case 115:
								goto end_IL_0201;
							}
							goto IL_011c;
							IL_0137:
							switch (num2)
							{
							case -100:
								goto IL_015a;
							case -98:
								goto IL_01ca;
							case -101:
								goto IL_020c;
							case -99:
								goto end_IL_021b;
							}
							num3 = 22;
							continue;
							IL_020c:
							num2 = Class89.smethod_2(92);
							goto end_IL_0201;
							IL_015a:
							switch (num)
							{
							case 107:
								break;
							case 108:
								goto IL_018b;
							case 109:
								goto IL_0191;
							default:
								goto IL_0217;
							case 110:
							{
								IEnumerator<Class23> enumerator3 = ((IEnumerable<Class23>)Delegate401.smethod_0(this)).GetEnumerator();
								try
								{
									while (enumerator3.MoveNext() ? true : false)
									{
										Class23 current3 = enumerator3.Current;
										Delegate462.smethod_0(this, textWriter_0, Delegate332.smethod_0(class9_0, Class86.smethod_0("\uf0a3\uf09f\uf094\uf095\uf090\uf098\uf0a3", 61628) + num4, Delegate207.smethod_0(current3)));
										num4 += Class84.smethod_0(1);
									}
									return;
								}
								finally
								{
									if (enumerator3 != null || 1 == 0)
									{
										enumerator3.Dispose();
									}
								}
							}
							}
							num4 = Class84.smethod_0(0);
							num = Class84.smethod_0(20);
							goto IL_01ca;
							IL_0217:
							num2 = -13;
							goto end_IL_0201;
							IL_0191:
							Delegate462.smethod_0(this, textWriter_0, Delegate332.smethod_0(class9_0, Class86.smethod_0("\ueca2\uec9e\uec95\uec94\uec91\uec99\uec8f\uec98\uec93", 60653), Delegate204.smethod_0(Delegate401.smethod_0(this)).ToString()));
							num = 14;
							goto IL_01ca;
							IL_018b:
							num = 9;
							goto IL_01ca;
							IL_011c:
							num2 = Class89.smethod_1(52);
							num3 = 23;
							continue;
							IL_01ca:
							num ^= Class84.smethod_0(48);
							goto IL_011c;
							continue;
							end_IL_01db:
							break;
						}
						continue;
						end_IL_0201:
						break;
					}
					continue;
					end_IL_021b:
					break;
				}
			}
		}
		if (class23_0 == null || class23_0.class11_0 == null || class23_0 == this)
		{
			return;
		}
		IEnumerator<Class36> enumerator4 = ((IEnumerable<Class36>)class23_0.class11_0).GetEnumerator();
		try
		{
			while (enumerator4.MoveNext() ? true : false)
			{
				Class36 current4 = enumerator4.Current;
				Delegate462.smethod_0(this, textWriter_0, current4);
			}
		}
		finally
		{
			if (enumerator4 != null || 1 == 0)
			{
				enumerator4.Dispose();
			}
		}
		if (class9_0.bool_2 || 1 == 0)
		{
			Delegate462.smethod_0(this, textWriter_0, Delegate332.smethod_0(class9_0, Class86.smethod_0("\ueee4\ueed8\ueed7\ueed4\ueec8\ueede\ueedf", 61115), Delegate387.smethod_0(this).ToString()));
			Delegate462.smethod_0(this, textWriter_0, Delegate332.smethod_0(class9_0, Class86.smethod_0("\ueca2\uec9e\uec95\uec94\uec91\uec99\uec8f\uec98\uec93", 60653), Delegate204.smethod_0(Delegate401.smethod_0(this)).ToString()));
		}
	}

	private string method_48()
	{
		if (Delegate403.smethod_0(this) == null && 0 == 0)
		{
			return Delegate419.smethod_0(this);
		}
		if (Delegate457.smethod_0(this) == HtmlNodeType.Document && 0 == 0)
		{
			return string.Empty;
		}
		int num = Class84.smethod_0(1);
		IEnumerator<Class23> enumerator = ((IEnumerable<Class23>)Delegate203.smethod_0(Delegate403.smethod_0(this))).GetEnumerator();
		try
		{
			while (enumerator.MoveNext() ? true : false)
			{
				Class23 current = enumerator.Current;
				if (!(Delegate207.smethod_0(current) != Delegate419.smethod_0(this)) && 0 == 0)
				{
					if (current == this)
					{
						break;
					}
					num += Class84.smethod_0(1);
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
		object[] array = new object[Class84.smethod_0(8)];
		while (true)
		{
			int num2 = Class84.smethod_0(396);
			int num3 = Class89.smethod_1(56);
			while (true)
			{
				num3 ^= Class84.smethod_0(48);
				while (true)
				{
					int num4 = Class84.smethod_0(55);
					while (true)
					{
						switch (num4 ^ Class84.smethod_0(60))
						{
						case 109:
							break;
						case 107:
							goto IL_0168;
						case 108:
							num4 = 24;
							continue;
						default:
							goto end_IL_0180;
						case 110:
							goto end_IL_01a6;
						}
						switch (num3)
						{
						case -110:
							goto IL_00c9;
						case -107:
							goto IL_0159;
						case -109:
							goto IL_01b7;
						case -108:
							goto end_IL_01bb;
						}
						num4 = 31;
						continue;
						IL_0159:
						num2 ^= Class84.smethod_0(408);
						goto IL_0168;
						IL_01b7:
						num3 = -10;
						goto end_IL_01a6;
						IL_00c9:
						switch (num2)
						{
						case 108:
							break;
						case 109:
							goto IL_0103;
						case 110:
							goto IL_0109;
						case 111:
							goto IL_0122;
						case 112:
							goto IL_013e;
						default:
							goto IL_01b1;
						case 113:
							return string.Concat(array);
						}
						array[Class84.smethod_0(0)] = Delegate419.smethod_0(this);
						num2 = 0;
						goto IL_0159;
						IL_01b1:
						num3 = -15;
						goto end_IL_01a6;
						IL_013e:
						array[Class84.smethod_0(1)] = Class86.smethod_0("\uf2a5", 62102);
						num2 = 30;
						goto IL_0159;
						IL_0122:
						array[Class84.smethod_0(7)] = Class86.smethod_0("\ue58a", 58823);
						num2 = 1;
						goto IL_0159;
						IL_0109:
						array[Class84.smethod_0(6)] = num;
						num2 = Class84.smethod_0(91);
						goto IL_0159;
						IL_0103:
						num2 = 29;
						goto IL_0159;
						IL_0168:
						num3 = Class46.Class47.smethod_0(72);
						num4 = Class84.smethod_0(33);
						continue;
						end_IL_0180:
						break;
					}
					continue;
					end_IL_01a6:
					break;
				}
				continue;
				end_IL_01bb:
				break;
			}
		}
	}
}
