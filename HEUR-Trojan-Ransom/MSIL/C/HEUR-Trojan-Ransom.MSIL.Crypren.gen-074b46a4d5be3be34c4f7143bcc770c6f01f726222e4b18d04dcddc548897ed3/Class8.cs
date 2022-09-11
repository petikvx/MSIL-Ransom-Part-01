using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.XPath;
using HtmlAgilityPack;

internal class Class8 : XPathNavigator
{
	private int int_0;

	private Class23 class23_0;

	private Class9 class9_0 = Delegate185.smethod_0();

	private Class37 class37_0 = Delegate186.smethod_0();

	internal bool bool_0;

	public override string BaseURI => Delegate200.smethod_0(class37_0, string.Empty);

	public Class9 Class9_0 => class9_0;

	public Class23 Class23_0 => class23_0;

	public override bool HasAttributes => Delegate202.smethod_0(Delegate201.smethod_0(class23_0)) > Class84.smethod_0(0);

	public override bool HasChildren => Delegate204.smethod_0(Delegate203.smethod_0(class23_0)) > Class84.smethod_0(0);

	public override bool IsEmptyElement => (HasChildren ? 1 : 0) == Class84.smethod_0(0);

	public override string LocalName
	{
		get
		{
			if (int_0 != -1)
			{
				return Delegate200.smethod_0(class37_0, Delegate206.smethod_0(Delegate205.smethod_0(Delegate201.smethod_0(class23_0), int_0)));
			}
			return Delegate200.smethod_0(class37_0, Delegate207.smethod_0(class23_0));
		}
	}

	public override string Name => Delegate200.smethod_0(class37_0, Delegate207.smethod_0(class23_0));

	public override string NamespaceURI => Delegate200.smethod_0(class37_0, string.Empty);

	public override XmlNameTable NameTable => class37_0;

	public override XPathNodeType NodeType
	{
		get
		{
			switch (Delegate208.smethod_0(class23_0))
			{
			default:
				throw new NotImplementedException(Class86.smethod_0("\ue137\ue110\ue10a\ue11b\ue10c\ue110\ue11f\ue112\ue15e\ue11b\ue10c\ue10c\ue111\ue10c\ue144\ue15e\ue12b\ue110\ue116\ue11f\ue110\ue11a\ue112\ue11b\ue11a\ue15e\ue136\ue10a\ue113\ue112\ue130\ue111\ue11a\ue11b\ue12a\ue107\ue10e\ue11b\ue144\ue15e", 57702) + Delegate208.smethod_0(class23_0));
			case HtmlNodeType.Document:
				return (XPathNodeType)Class84.smethod_0(0);
			case HtmlNodeType.Element:
				if (int_0 != -1)
				{
					return (XPathNodeType)Class84.smethod_0(6);
				}
				return (XPathNodeType)Class84.smethod_0(1);
			case HtmlNodeType.Comment:
				return (XPathNodeType)Class84.smethod_0(75);
			case HtmlNodeType.Text:
				return (XPathNodeType)Class84.smethod_0(8);
			}
		}
	}

	public override string Prefix => Delegate200.smethod_0(class37_0, string.Empty);

	public override string Value
	{
		get
		{
			switch (Delegate208.smethod_0(class23_0))
			{
			default:
				throw new NotImplementedException(Class86.smethod_0("\ue137\ue110\ue10a\ue11b\ue10c\ue110\ue11f\ue112\ue15e\ue11b\ue10c\ue10c\ue111\ue10c\ue144\ue15e\ue12b\ue110\ue116\ue11f\ue110\ue11a\ue112\ue11b\ue11a\ue15e\ue136\ue10a\ue113\ue112\ue130\ue111\ue11a\ue11b\ue12a\ue107\ue10e\ue11b\ue144\ue15e", 57702) + Delegate208.smethod_0(class23_0));
			case HtmlNodeType.Document:
				return "";
			case HtmlNodeType.Element:
				if (int_0 != -1)
				{
					return Delegate211.smethod_0(Delegate205.smethod_0(Delegate201.smethod_0(class23_0), int_0));
				}
				return Delegate212.smethod_0(class23_0);
			case HtmlNodeType.Comment:
				return Delegate209.smethod_0((Class24)class23_0);
			case HtmlNodeType.Text:
				return Delegate210.smethod_0((Class25)class23_0);
			}
		}
	}

	public override string XmlLang => Delegate200.smethod_0(class37_0, string.Empty);

	internal Class8()
	{
		Delegate187.smethod_0(this);
	}

	internal Class8(Class9 class9_1, Class23 class23_1)
	{
		if (class23_1 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\ue55a\ue54c\ue54b\ue54b\ue55c\ue557\ue54d\ue577\ue556\ue55d\ue55c", 58665));
		}
		if (Delegate188.smethod_0(class23_1) != class9_1)
		{
			throw new ArgumentException(Class9.string_3);
		}
		class9_0 = class9_1;
		while (true)
		{
			int num = Class84.smethod_0(399);
			while (true)
			{
				switch (num ^ Class84.smethod_0(390))
				{
				case 92:
					Delegate187.smethod_0(this);
					num = 9;
					continue;
				case 91:
					class23_0 = class23_1;
					num = 15;
					continue;
				case 90:
					num = Class84.smethod_0(75);
					continue;
				case 93:
					return;
				}
				break;
			}
		}
	}

	private Class8(Class8 class8_0)
	{
		if (class8_0 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\uf7b9\uf7b6\uf7a1", 63431));
		}
		class9_0 = class8_0.class9_0;
		while (true)
		{
			int num = Class84.smethod_0(81);
			while (true)
			{
				switch (num ^ Class84.smethod_0(393))
				{
				case 99:
					class23_0 = class8_0.class23_0;
					num = 49;
					continue;
				case 98:
					num = 51;
					continue;
				case 97:
					class37_0 = class8_0.class37_0;
					num = Class84.smethod_0(378);
					continue;
				case 96:
					int_0 = class8_0.int_0;
					num = 48;
					continue;
				case 100:
					return;
				}
				break;
			}
		}
	}

	public Class8(Stream stream_0)
	{
		Delegate189.smethod_0(class9_0, stream_0);
		Delegate187.smethod_0(this);
	}

	public Class8(Stream stream_0, bool bool_1)
	{
		Delegate190.smethod_0(class9_0, stream_0, bool_1);
		Delegate187.smethod_0(this);
	}

	public Class8(Stream stream_0, Encoding encoding_0)
	{
		Delegate191.smethod_0(class9_0, stream_0, encoding_0);
		Delegate187.smethod_0(this);
	}

	public Class8(Stream stream_0, Encoding encoding_0, bool bool_1)
	{
		Delegate192.smethod_0(class9_0, stream_0, encoding_0, bool_1);
		Delegate187.smethod_0(this);
	}

	public Class8(Stream stream_0, Encoding encoding_0, bool bool_1, int int_1)
	{
		Delegate193.smethod_0(class9_0, stream_0, encoding_0, bool_1, int_1);
		Delegate187.smethod_0(this);
	}

	public Class8(TextReader textReader_0)
	{
		Delegate194.smethod_0(class9_0, textReader_0);
		Delegate187.smethod_0(this);
	}

	public Class8(string string_0)
	{
		Delegate195.smethod_0(class9_0, string_0);
		Delegate187.smethod_0(this);
	}

	public Class8(string string_0, bool bool_1)
	{
		Delegate196.smethod_0(class9_0, string_0, bool_1);
		Delegate187.smethod_0(this);
	}

	public Class8(string string_0, Encoding encoding_0)
	{
		Delegate197.smethod_0(class9_0, string_0, encoding_0);
		Delegate187.smethod_0(this);
	}

	public Class8(string string_0, Encoding encoding_0, bool bool_1)
	{
		Delegate198.smethod_0(class9_0, string_0, encoding_0, bool_1);
		Delegate187.smethod_0(this);
	}

	public Class8(string string_0, Encoding encoding_0, bool bool_1, int int_1)
	{
		Delegate199.smethod_0(class9_0, string_0, encoding_0, bool_1, int_1);
		Delegate187.smethod_0(this);
	}

	public override XPathNavigator Clone()
	{
		return Delegate213.smethod_0(this);
	}

	public override string GetAttribute(string localName, string namespaceURI)
	{
		Class36 @class = Delegate214.smethod_0(Delegate201.smethod_0(class23_0), localName);
		if (@class == null && 0 == 0)
		{
			return null;
		}
		return Delegate211.smethod_0(@class);
	}

	public override string GetNamespace(string name)
	{
		return string.Empty;
	}

	public override bool IsSamePosition(XPathNavigator other)
	{
		Class8 @class = other as Class8;
		if (@class == null && 0 == 0)
		{
			return (byte)Class84.smethod_0(0) != 0;
		}
		return @class.class23_0 == class23_0;
	}

	public override bool MoveTo(XPathNavigator other)
	{
		Class8 @class = other as Class8;
		if (@class == null && 0 == 0)
		{
			return (byte)Class84.smethod_0(0) != 0;
		}
		if (@class.class9_0 == class9_0)
		{
			while (true)
			{
				int num = Class84.smethod_0(78);
				int num2 = -25;
				while (true)
				{
					num2 ^= Class84.smethod_0(29);
					while (true)
					{
						int num3 = Class84.smethod_0(1);
						while (true)
						{
							switch (num3 ^ Class84.smethod_0(99))
							{
							case 98:
								break;
							case 97:
								goto IL_0039;
							case 96:
								num3 = 0;
								continue;
							default:
								goto end_IL_00b4;
							case 99:
								goto end_IL_00d7;
							}
							goto IL_002d;
							IL_0039:
							switch (num2)
							{
							case -77:
								goto IL_005b;
							case -76:
								goto IL_00a3;
							case -78:
								goto IL_00e0;
							case -79:
								goto end_IL_00ed;
							}
							num3 = Class84.smethod_0(6);
							continue;
							IL_00e0:
							num2 = Class89.smethod_2(93);
							goto end_IL_00d7;
							IL_005b:
							switch (num)
							{
							case 96:
								break;
							case 97:
								goto IL_008f;
							case 98:
								goto IL_0094;
							default:
								goto IL_00ea;
							case 99:
								return (byte)Class84.smethod_0(1) != 0;
							}
							class23_0 = @class.class23_0;
							num = Class84.smethod_0(402);
							goto IL_00a3;
							IL_00ea:
							num2 = -30;
							goto end_IL_00d7;
							IL_0094:
							int_0 = @class.int_0;
							num = 53;
							goto IL_00a3;
							IL_008f:
							num = 55;
							goto IL_00a3;
							IL_002d:
							num2 = Class49.smethod_0(80);
							num3 = 3;
							continue;
							IL_00a3:
							num ^= Class84.smethod_0(85);
							goto IL_002d;
							continue;
							end_IL_00b4:
							break;
						}
						continue;
						end_IL_00d7:
						break;
					}
					continue;
					end_IL_00ed:
					break;
				}
			}
		}
		return (byte)Class84.smethod_0(0) != 0;
	}

	public override bool MoveToAttribute(string localName, string namespaceURI)
	{
		int num = Delegate215.smethod_0(Delegate201.smethod_0(class23_0), localName);
		if (num == -1)
		{
			return (byte)Class84.smethod_0(0) != 0;
		}
		int_0 = num;
		return (byte)Class84.smethod_0(1) != 0;
	}

	public override bool MoveToFirst()
	{
		if (Delegate216.smethod_0(class23_0) == null && 0 == 0)
		{
			return (byte)Class84.smethod_0(0) != 0;
		}
		if (Delegate217.smethod_0(Delegate216.smethod_0(class23_0)) == null && 0 == 0)
		{
			return (byte)Class84.smethod_0(0) != 0;
		}
		class23_0 = Delegate217.smethod_0(Delegate216.smethod_0(class23_0));
		return (byte)Class84.smethod_0(1) != 0;
	}

	public override bool MoveToFirstAttribute()
	{
		if (!HasAttributes && 0 == 0)
		{
			return (byte)Class84.smethod_0(0) != 0;
		}
		int_0 = Class84.smethod_0(0);
		return (byte)Class84.smethod_0(1) != 0;
	}

	public override bool MoveToFirstChild()
	{
		if (!Delegate218.smethod_0(class23_0) && 0 == 0)
		{
			return (byte)Class84.smethod_0(0) != 0;
		}
		class23_0 = Delegate219.smethod_0(Delegate203.smethod_0(class23_0), Class84.smethod_0(0));
		return (byte)Class84.smethod_0(1) != 0;
	}

	public override bool MoveToFirstNamespace(XPathNamespaceScope scope)
	{
		return (byte)Class84.smethod_0(0) != 0;
	}

	public override bool MoveToId(string id)
	{
		Class23 @class = Delegate220.smethod_0(class9_0, id);
		if (@class == null && 0 == 0)
		{
			return (byte)Class84.smethod_0(0) != 0;
		}
		class23_0 = @class;
		return (byte)Class84.smethod_0(1) != 0;
	}

	public override bool MoveToNamespace(string name)
	{
		return (byte)Class84.smethod_0(0) != 0;
	}

	public override bool MoveToNext()
	{
		if (Delegate221.smethod_0(class23_0) == null && 0 == 0)
		{
			return (byte)Class84.smethod_0(0) != 0;
		}
		class23_0 = Delegate221.smethod_0(class23_0);
		return (byte)Class84.smethod_0(1) != 0;
	}

	public override bool MoveToNextAttribute()
	{
		if (int_0 >= Delegate202.smethod_0(Delegate201.smethod_0(class23_0)) - Class84.smethod_0(1))
		{
			return (byte)Class84.smethod_0(0) != 0;
		}
		int_0 += Class84.smethod_0(1);
		return (byte)Class84.smethod_0(1) != 0;
	}

	public override bool MoveToNextNamespace(XPathNamespaceScope scope)
	{
		return (byte)Class84.smethod_0(0) != 0;
	}

	public override bool MoveToParent()
	{
		if (Delegate216.smethod_0(class23_0) == null && 0 == 0)
		{
			return (byte)Class84.smethod_0(0) != 0;
		}
		class23_0 = Delegate216.smethod_0(class23_0);
		return (byte)Class84.smethod_0(1) != 0;
	}

	public override bool MoveToPrevious()
	{
		if (Delegate222.smethod_0(class23_0) == null && 0 == 0)
		{
			return (byte)Class84.smethod_0(0) != 0;
		}
		class23_0 = Delegate222.smethod_0(class23_0);
		return (byte)Class84.smethod_0(1) != 0;
	}

	public override void MoveToRoot()
	{
		class23_0 = Delegate223.smethod_0(class9_0);
	}

	[Conditional("TRACE")]
	internal void method_0(object object_0)
	{
		if (!bool_0 || 1 == 0)
		{
			return;
		}
		StackFrame stackFrame = new StackFrame(Class84.smethod_0(1), (byte)Class84.smethod_0(1) != 0);
		_ = stackFrame.GetMethod()!.Name;
		if (class23_0 != null || 1 == 0)
		{
			Delegate207.smethod_0(class23_0);
		}
		if (class23_0 != null)
		{
			switch (Delegate208.smethod_0(class23_0))
			{
			default:
				Delegate225.smethod_0(Delegate224.smethod_0(class23_0, (byte)Class84.smethod_0(0) != 0));
				break;
			case HtmlNodeType.Document:
				break;
			case HtmlNodeType.Comment:
				Delegate209.smethod_0((Class24)class23_0);
				break;
			case HtmlNodeType.Text:
				Delegate210.smethod_0((Class25)class23_0);
				break;
			}
		}
	}

	private void method_1()
	{
		class23_0 = Delegate223.smethod_0(class9_0);
		int_0 = -1;
	}
}
