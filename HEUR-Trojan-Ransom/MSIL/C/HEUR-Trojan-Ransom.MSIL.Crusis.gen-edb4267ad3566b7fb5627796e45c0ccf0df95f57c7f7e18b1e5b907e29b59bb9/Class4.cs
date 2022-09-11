using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.XPath;

internal sealed class Class4 : XmlDocument
{
	internal static Struct4 struct4_0/* Not supported: data(C6 94 AF B8 92 BE C9 F2 46 DB B0 14 F1 DC BB 1E B1 3A B4 67 45 3F 41 14 D1 0B C1 D0 EC E1 6D BB FB 7A 1E E2 72 5F 5A C1 7E 03 4F 8F 9A 7E 01 B9 C0 FB 9B 11 E0 D6 CD BF EA 81 A4 F0 A1 E1 45 35 E7 89 BF 57 BC F9 D4 A7 9E 97 E3 71 59 E6 95 52 DB 92 DB EE 1D 13 C1 30 54 31 45 0C 81 FB 9A 7B F9 D3 12 86 1E 0C 3E 90 9B 01 90 58 61 84 74 8B BB EA E6 3D 63 FC 4B 42 6B 5C 7D 7E 6F 39 A4 FA E1 FD F8 93 2D A8 2A 9A 8F 66 46 E6 AE F8 77 69 B2 70 69 44 D8 C4 63 83 11 CE F5 68 6F 3D 02 DB 5F 29 93 62 B2 B1 68 4E 80 4C AE BB E0 23 B2 56 D7 6D EC DA 91 E9 08 A2 71 A4 B7 9F F0 79 B1 A7 25 3F 28 3B 1A C1 DE 2B E8 F6 CB 55 BE 89 27 80 26 3A 49 10 15 48 15 00 81 63 01 93 C3 83 D1 BE C4 02 0A 00 BF 33 29 D9 05 BE 2B 54 88 6F 96 B5 16 E3 FE F2 1C 11 2E E8 60 B7 BE 09 39 7A DB 43 B8 37 E3 18 73 3B 47 C5 98 0E 3F B1 C4 5B 61 DE DC 95 74 10 8D 90 15 EF 9A 02 31 1E 2E A2 DD B5 DF 91 45 1A 8A 95 4B 96 07 DF 8B 52 F1 42 CD 9E 04 CD DA DF 60 BC 0C A8 6D AE F6 36 7B 09 B6 4F ED E5 B5 A8 09 13 A9 36 C1 55 96 D7 0E 17 1F 2D C5 0B DE C8 83 E5 FC 40 2D E6 46 0A BE 52 CF 5B 9F 59 63 EF 44 C1 6C 80 59 01 C7 C7 94 06 9F 51 B3 7F 36 79 C8 02 F0 C7 E4 4B 9C 28 FA C3 22 0B 40 BD F2 F4 AB 23 B0 FE D2 23 17 C1 C7 DA 4F EB 75 A1 D6 9B E2 C7 9E CC 0E 68 26 21 2A DA 0B ED DE D7 E2 F1 20 44 88 07 D5 DD 3D 53 0B E9 E1 ED 41 37 9D 55 1A 80 60 FB 47 21 CC 14 8C 7F DE 12 DB 71 7D E4 20 F3 71 86 CB 72 F7 F0 AE 48 2B 25 0C 18 C1 22 46 2E 70 63 26 1D 97 E5 8C 24 4D 0B 52 3C AD 5D F6 A7 26 85 40 AB 46 A8 8F 80 1B 77 81 15 95 26 76 52 80 43 2B 60 94 B5 7E 89 96 70 44 90 43 52 9A 06 5B 4B DA 2A 53 C8 A7 4B A7 2A 88 D2 21 C1 74 BE 7E 58 3F D0 2E 7D 1D 99 1D 9C F7 D8 18 12 2A EB 69 22 92 75 39 35 FB 03 15 EF BF 78 0E 38 B1 15 6A 02 9A 9B FE 3C 43 53 3F 44 28 74 50 2E CA 71 90 95 21 CF 56 91 8B 02 A1 B4 6E CC 52 7D 3A CB 68 9B CA A8 BD 22 B3 06 86 35 04 E1 FB 6A BD AE FC FF 46 36 A5 3C 57 55 A6 1A FE 65 16 B4 9A 77 C5 13 11 B4 B7 C2 3E 4F 01 43 C6 22 B0 91 3C B5 1A 20 38 08 23 76 E6 1D 1F D7 A2 EC 6C E5 EA 5A 1F FA 62 75 7A FE FC 25 91 DF CA 9D 68 2A EA 75 19 D3 EC 4F 9B 38 F1 43 45 26 7C A6 D3 D8 ED C8 72 8A 2D 91 18 1D 76 12 7C FE F4 05 D0 A5 9D 93 03 0F 25 5B ED 67 A5 A8 38 32 50 F9 92 BB B0 04 56 7A EC 39 33 6A E6 DE 68 3A 4D 73 5C F5 04 21 15 E4 D4 6C E5 33 4D DD 8C 1F AF 71 34 B8 E0 3B D2 1D 95 D8 9C 01 B5 E2 8D C6 33 D7 73 C9 B9 6F 78 76 07 CC F1 1D E5 91 50 AF ED B4 14 85 0B 2C E6 C0 42 D9 1D 57 74 DF 47 AA 6B 03 2D 03 59 6C 57 8E 8F CA FE 01 89 6C 30 54 BA 20 D5 26 62 F0 35 E7 E3 09 02 28 C0 CF D5 96 32 3F D6 8B 9E C3 AC CD D5 75 81 0D 17 6E 5F 13 25 81 AD 3C 19 0B D7 66 AA 45 89 AC C9 C7 46 26 A9 FE 69 B8 80 A9 8A FD A2 C4 0A 17 F5 08 0B 19 DB 89 07 AE 29 99 0C 5F 42 15 1C E1 8F 40 B9 AA 00 D0 B5 A7 C0 53 29 25 49 01 D0 14 5D C6 FA 10 6E F1 87 5C 51 60 6C FB E2 7C 33 3B 67 2B 23 E5 34 34 71 33 13 36 8F 2B DC 35 B3 C7 9F 6D 0D C1 6B 41 A9 20 D7 79 9B 2B 81 E9 3C 45 3D B1 F5 3F 15 BF 62 04 F3 9A 2F B4 B5 56 7E C3 EB DF F4 3B 93 B1 52 66 2C 51 3C 36 B5 71 B7 44 3E 24 51 CD 5C 5A 03 71 2B 37 22 36 E3 C0 E2 A3 79 31 1D DD 16 78 C8 7E 5E 9C 6D B8 CF B6 F7 1B 52 B4 D4 81 76 AA FC 39 FD DB E7 C1 82 8E 80 EC 4F 09 4F F9 1A 4A 45 D6 F1 11 A2 AE E0 23 04 CF 2C 8E 4A BF D9 D1 BA 67 0F EE 77 A7 1E 1A B0 9B F8 63 A7 BA 7E 9C D6 01 4F 01 03 A9 AF 8A D3 39 81 11 8B B0 83 5D 57 AB D7 C5 CE A6 FC 95 8B 6D 2A CE 5D 2F D0 8C 06 FC BA F1 90 C6 2E 76 D4 CB E0 DF 1E 39 DD A7 12 2C A6 6B 63 3B F4 A5 32 41 90 85 4B 2B E1 85 E0 47 D3 DA 49 D4 49 9A 91 D5 22 15 12 DD C1 21 A2 B0 B9 A3 C5 39 A1 35 48 C2 9D 66 E3 66 28 7D 32 A1 16 CC 97 0E 3B 30 13 06 5E 65 3F 02 59 9C D0 68 44 93 C1 B3 DF 2C 74 91 E9 8A B7 9F A4 7E 0D 6B 1B 15 F1 B8 96 91 06 DF EF D2 09 46 94 F2 06 76 BD 4D A5 93 9B 24 54 8C D0 B6 BE 51 C6 5D 7F AF A1 E0 9D 02 C7 9A 6A BD DA A9 23 0E) */;

	internal static char[] char_0;

	public override extern XmlElement this[string string_0] { get; }

	public override extern XmlElement this[string string_0, string string_1] { get; }

	public override extern string String_0 { get; set; }

	public override extern XmlNodeList XmlNodeList_0 { get; }

	public override extern XmlNode XmlNode_0 { get; }

	public unsafe override XmlNode XmlNode_1
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and F4
			//IL_0007: Incompatible stack heights: 1 vs 0
			_003F val;
			do
			{
				int num = *(int*)(nint)/*Error near IL_0001: Stack underflow*/;
				val = /*Error near IL_0002: Stack underflow*/* num;
				while ((float)val >= 3.423312E-25f)
				{
				}
			}
			while ((int)val != 0);
			int num2 = *(int*)((short[])/*Error near IL_0018: Stack underflow*/)[-2.0572123605994895E-75];
			*(short*)(nint)/*Error near IL_001c: Stack underflow*/ = (short)num2;
			/*Error: Unexpected end of block*/;
		}
	}

	public unsafe override XmlAttributeCollection XmlAttributeCollection_0
	{
		get
		{
			//Discarded unreachable code: IL_001d
			//IL_0012: Invalid comparison between F4 and I4
			//IL_0027: Expected I, but got O
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected I4, but got Unknown
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			int num;
			do
			{
				((double[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (double)/*Error near IL_0001: Stack underflow*/;
				num = *(int*)(nint)/*Error near IL_0002: Stack underflow*/;
			}
			while (((float[])/*Error near IL_0007: Stack underflow*/)[num] <= (float)(*(sbyte*)2uL));
			*(_003F*)(nint)/*Error near IL_0018: Stack underflow*/ = /*Error near IL_0018: Stack underflow*/;
			/*Error near IL_0018: Invalid metadata token*/;
		}
	}

	public override extern XmlNode XmlNode_2 { get; }

	public override XmlNode XmlNode_3
	{
		get
		{
			/*Error: Unknown opcode: 0xFA*/;
		}
	}

	public override extern bool Boolean_0 { get; }

	public unsafe override string String_1
	{
		get
		{
			//Discarded unreachable code: IL_0008, IL_0010, IL_0019
			//IL_000a: Expected O, but got I4
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			_ = *(int*)(nint)/*Error: ldloc 1 (out-of-bounds)*/;
			/*Error near IL_0003: Invalid metadata token*/;
		}
	}

	public override string String_2
	{
		get; set
		{
			//Discarded unreachable code: IL_0009, IL_0010, IL_001f
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Expected O, but got Unknown
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			((float[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (float)/*Error near IL_0001: Stack underflow*/;
			/*OpCode not supported: Ckfinite*/;
			this = (Class4)/*Error near IL_0004: Stack underflow*/;
			/*Error near IL_0004: Invalid metadata token*/;
		}
	}

	public override extern string String_3 { get; }

	public override extern XmlNodeType XmlNodeType_0 { get; }

	public override extern XmlNode XmlNode_4 { get; }

	public override extern XmlDocumentType XmlDocumentType_0 { get; }

	public override extern string String_4 { get; }

	public override extern string String_5 { get; }

	public override extern XmlDocument XmlDocument_0 { get; }

	public override extern XmlResolver XmlResolver_0 { set; }

	public override extern bool Boolean_1 { get; }

	public override extern string String_6 { set; }

	public unsafe override string String_7
	{
		get; set
		{
			//Discarded unreachable code: IL_0013, IL_0019, IL_001c
			//IL_0003: Invalid comparison between Unknown and I4
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Expected I, but got Unknown
			short num;
			do
			{
				num = *(short*)(nuint)/*Error near IL_0002: Stack underflow*/;
			}
			while ((int)/*Error near IL_0008: Stack underflow*/ < (int)num);
			_ = *(float*)(nint)(/*Error near IL_000c: Stack underflow*/ >> (int)/*Error near IL_000c: Stack underflow*/);
			/*Error near IL_000e: Invalid metadata token*/;
		}
	}

	public override extern IXmlSchemaInfo IXmlSchemaInfo_0 { get; }

	public override extern string String_8 { get; }

	public override extern XmlNode vmethod_0(XmlNode xmlNode_0);

	public override extern XmlNode vmethod_1();

	public override extern XmlNode vmethod_2(bool bool_0);

	public override extern XmlAttribute vmethod_3(string string_0, string string_1, string string_2);

	public override extern XmlCDataSection vmethod_4(string string_0);

	public override extern XmlComment vmethod_5(string string_0);

	public override extern XmlDocumentFragment vmethod_6();

	public override extern XmlDocumentType vmethod_7(string string_0, string string_1, string string_2, string string_3);

	public override extern XmlElement vmethod_8(string string_0, string string_1, string string_2);

	public override extern XmlEntityReference vmethod_9(string string_0);

	public override extern XPathNavigator vmethod_10();

	public unsafe override XmlNode vmethod_11(XmlNodeType xmlNodeType_0, string string_0, string string_1, string string_2)
	{
		_ = *(int*)8;
		/*Error near IL_0002: stloc 3 (out-of-bounds)*/;
		/*Error near IL_0005: Invalid metadata token*/;
	}

	public override extern XmlNode vmethod_12(string string_0, string string_1, string string_2);

	public override XmlNode vmethod_13(XmlNodeType xmlNodeType_0, string string_0, string string_1)
	{
		checked
		{
			_ = (uint)/*Error near IL_0002: Stack underflow*/;
			_ = 6.498549956899734E-190;
			/*Error: Unexpected end of block*/;
		}
	}

	public override extern XmlProcessingInstruction vmethod_14(string string_0, string string_1);

	public override XmlSignificantWhitespace vmethod_15(string string_0)
	{
		//Discarded unreachable code: IL_000c, IL_0012
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		while (/*Error near IL_0005: Stack underflow*/ <= /*Error near IL_0005: Stack underflow*/)
		{
		}
		checked
		{
			_ = (byte)unchecked(/*Error near IL_0006: Stack underflow*/ % /*Error near IL_0006: Stack underflow*/);
			/*Error near IL_0007: Invalid metadata token*/;
		}
	}

	public override XmlText vmethod_16(string string_0)
	{
		//Discarded unreachable code: IL_0007, IL_0012
		//IL_0003: Expected O, but got Unknown
		//IL_000d: Invalid comparison between Unknown and I4
		/*Error near IL_0001: ldloc 2 (out-of-bounds)*/;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	public override extern XmlWhitespace vmethod_17(string string_0);

	public override extern XmlDeclaration vmethod_18(string string_0, string string_1, string string_2);

	public override extern bool vmethod_19(object object_0);

	public override XmlElement vmethod_20(string string_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0003: Invalid metadata token*/;
		}
	}

	public override extern XmlNodeList vmethod_21(string string_0);

	public override extern XmlNodeList vmethod_22(string string_0, string string_1);

	public override int vmethod_23()
	{
		//Discarded unreachable code: IL_0003, IL_000a
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		ulong num = checked((ulong)/*Error near IL_0001: Stack underflow*/);
		_ = /*Error near IL_0002: Stack underflow*/- num;
		/*Error near IL_0002: Unknown opcode: 0xFC*/;
	}

	public override extern string vmethod_24(string string_0);

	public override extern string vmethod_25(string string_0);

	public override extern XmlNode vmethod_26(XmlNode xmlNode_0, bool bool_0);

	public override XmlNode vmethod_27(XmlNode xmlNode_0, XmlNode xmlNode_1)
	{
		//Discarded unreachable code: IL_0005, IL_000a, IL_000f, IL_0015, IL_001b
		//IL_0027: Expected I4, but got I8
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected I4, but got Unknown
		/*Error: Invalid metadata token*/;
	}

	public override extern XmlNode vmethod_28(XmlNode xmlNode_0, XmlNode xmlNode_1);

	public override extern void vmethod_29(string string_0);

	public override extern void vmethod_30(Stream stream_0);

	public override extern void vmethod_31(TextReader textReader_0);

	public override extern void vmethod_32(XmlReader xmlReader_0);

	public override extern void vmethod_33(string string_0);

	public override extern void vmethod_34();

	public override XmlNode vmethod_35(XmlNode xmlNode_0)
	{
		//IL_0001: Invalid comparison between Unknown and I
		IntPtr intPtr;
		do
		{
			intPtr = (nint)((Array)/*Error near IL_0001: Stack underflow*/).LongLength;
		}
		while ((nint)/*Error near IL_0006: Stack underflow*/ < (nint)intPtr);
		/*Error near IL_0006: Invalid metadata token*/;
	}

	public unsafe override XmlNode vmethod_36(XmlReader xmlReader_0)
	{
		//Discarded unreachable code: IL_0009, IL_000a, IL_000f, IL_0017, IL_001f
		//IL_0007: Expected native int or pointer, but got O
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and O
		//IL_000d: Incompatible stack heights: 1 vs 0
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (short)/*Error near IL_0001: Stack underflow*/;
			_ = (ushort)/*Error near IL_0003: ldloc 1 (out-of-bounds)*/;
		}
		_ = *(float*)unchecked((nint)null);
		/*Error near IL_0008: Unknown opcode: 0xFD*/;
	}

	public override extern void vmethod_37();

	public override extern XmlNode vmethod_38(XmlNode xmlNode_0);

	public override XmlNode vmethod_39(XmlNode xmlNode_0, XmlNode xmlNode_1)
	{
		//Discarded unreachable code: IL_0013, IL_001e, IL_002e, IL_0035, IL_003a
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected I4, but got F4
		do
		{
			uint num = ((uint[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
			_ = (short)((uint[])/*Error near IL_0003: Stack underflow*/)[num];
			/*Error near IL_0004: stloc 1 (out-of-bounds)*/;
		}
		while (/*Error near IL_000a: Stack underflow*/ >= /*Error near IL_000a: Stack underflow*/);
		checked
		{
			_ = (ushort)/*Error near IL_000e: Stack underflow*/;
			/*Error near IL_000e: Invalid metadata token*/;
		}
	}

	public override extern void vmethod_40(string string_0);

	public override extern void vmethod_41(Stream stream_0);

	public unsafe override void vmethod_42(TextWriter textWriter_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		//IL_0014: Expected I4, but got Unknown
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0027: Expected I, but got F8
		while (true)
		{
			_ = /*Error near IL_0001: Stack underflow*/^ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 0 (out-of-bounds)*/;
			_003F val = /*Error near IL_0004: ldarg 2 (out-of-bounds)*/;
			*(_003F*)(nint)/*Error near IL_0006: Stack underflow*/ = val;
			if (checked(/*Error near IL_0007: Stack underflow*/ - /*Error near IL_0007: Stack underflow*/) % /*Error near IL_0007: ldloc 1 (out-of-bounds)*/< -31)
			{
				_003F val2 = /*Error near IL_0011: ldloc 1 (out-of-bounds)*/;
				((sbyte[])/*Error near IL_0014: Stack underflow*/)[/*Error near IL_0014: Stack underflow*/] = (sbyte)(int)val2;
				if ((int)/*Error near IL_0014: ldloc 2 (out-of-bounds)*/ <= 8)
				{
					break;
				}
			}
		}
		((IntPtr[])/*Error near IL_0027: Stack underflow*/)[/*Error near IL_0027: Stack underflow*/] = (IntPtr)6.111833667050721E-208;
	}

	public override extern void vmethod_43(XmlWriter xmlWriter_0);

	public override extern bool vmethod_44(string string_0, string string_1);

	public unsafe override string vmethod_45()
	{
		//Discarded unreachable code: IL_0020, IL_0029, IL_002d, IL_0034, IL_003c
		//IL_0001: Invalid comparison between Unknown and I8
		//IL_000a: Incompatible stack heights: 0 vs 1
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Invalid comparison between Unknown and F4
		while (true)
		{
			long num = checked((long)/*Error near IL_0001: Stack underflow*/);
			if ((long)/*Error near IL_0006: Stack underflow*/ >= num)
			{
				_ = (ushort)/*Error near IL_0007: Stack underflow*/;
				if (*(sbyte*)(nint)/*Error near IL_0007: ldloc 1 (out-of-bounds)*/ >= 8)
				{
					break;
				}
			}
		}
		short num2 = *(short*)(nint)/*Error near IL_0010: Stack underflow*/;
		_ = ((int[])/*Error near IL_0011: Stack underflow*/)[num2];
		/*Error near IL_0011: ldloc 1 (out-of-bounds)*/;
		_ = 69981042292364979L;
		/*Error near IL_001b: Invalid metadata token*/;
	}

	public override extern void vmethod_46(XmlWriter xmlWriter_0);

	public override extern void vmethod_47(XmlWriter xmlWriter_0);

	protected override extern XmlAttribute vmethod_48(string string_0, string string_1, string string_2);

	protected override extern XPathNavigator vmethod_49(XmlNode xmlNode_0);

	public extern Class4();

	extern XmlElement tXudPlAkkZEVxYuyWqDpXLLloKvbb(string string_0);

	extern XmlElement BSZEkyAIwWvYMLncUQsmzFZaaykkA(string string_0, string string_1);

	extern string JDcBOrDzKadasuzfFZQCSMtyIiOyA();

	extern void snLEVtrwokvFvHNdIwzuUYgQiafh(string string_0);

	unsafe XmlNodeList GijrZvyqeYKrhlvncLmjWOuMJFCM()
	{
		//IL_0003: Expected F8, but got I4
		int num = (int)/*Error near IL_0002: Stack underflow*/;
		*(double*)(nint)/*Error near IL_0003: Stack underflow*/ = num;
		switch (*(sbyte*)(nint)/*Error near IL_0004: Stack underflow*/)
		{
		default:
			;
			break;
		}
		/*Error: Unexpected end of block*/;
	}

	extern XmlNode iiEGoQdbBQHXaJGSAujrOrGTOsgA();

	unsafe XmlNode TELgOojivEnwBPAGxKhUcLzDiTRdB()
	{
		//Discarded unreachable code: IL_0022
		//IL_0007: Invalid comparison between Unknown and F4
		//IL_000e: Invalid comparison between Unknown and I8
		//IL_001c: Invalid comparison between Unknown and I4
		while (true)
		{
			if (/*Error near IL_0005: Stack underflow*/ < /*Error near IL_0005: Stack underflow*/)
			{
				continue;
			}
			float num = *(float*)(nint)/*Error near IL_0006: Stack underflow*/;
			if ((float)/*Error near IL_000c: Stack underflow*/ >= num)
			{
				continue;
			}
			ulong num2;
			checked
			{
				num2 = (ulong)unchecked((long)checked((ulong)/*Error near IL_000d: Stack underflow*/));
			}
			if ((long)/*Error near IL_0013: Stack underflow*/ < (long)num2)
			{
				short num3 = *(short*)checked(unchecked((nuint)(int)((byte[])6)[/*Error near IL_0014: ldloc 2 (out-of-bounds)*/]) - unchecked((nuint)checked((nint)4294967287u)));
				if ((int)/*Error near IL_0021: Stack underflow*/ < (int)num3)
				{
					break;
				}
			}
		}
		/*Error near IL_0021: Unknown opcode: 0xFC*/;
	}

	extern XmlAttributeCollection lNrchCFuUgdhhtLNUmCuBONkxmqLB();

	extern XmlNode MHgtxFbqoRWivNYUTmoFglVpXkNQ();

	XmlNode bVILRBxYqCKqsLdVnkMmYaoWszNH()
	{
		_ = (byte)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	extern bool DveoLAwVoNRXCyCTVlYyLUlDeEuc();

	extern string GBGYAyTqoHqkWgMqIPbYhmZIGhFR();

	extern string VTAudoxlaRaJwGaDoWLJeTXCXDvTA();

	extern void CNrQbQZjylaEJSuygagKCfULorbq(string string_0);

	extern string RTqddDKuYDmaKFpZJnZsoWiBoqfKb();

	extern XmlNodeType VwXCYpdNkubdZDqpdyaLoPiaLSyjA();

	extern XmlNode YmSrKwGPxKSymqaTgrcDoTtdofFP();

	extern XmlDocumentType pxuinlFaIJdQwfFmqdpTfNsfVGpv();

	extern string TSoVHFXxYZnIUFIFoilbbfALlCWgb();

	extern string JZiPJWXbAaIfiHeIOBmMeShddnqKb();

	extern XmlDocument CJlMSpZzFmSGMEuXTjWsZqSqweqE();

	extern void kYJpRxKzqUSvWhyyVrsbtXWYkdKo(XmlResolver xmlResolver_0);

	extern bool HpHysrbvWgpHpLhSGQAbAoiIXSFY();

	extern void PVEsGMpgrsPDEAoxCDRvasPhQqrTA(string string_0);

	string AcjtCaMbxYkLftdFXIYsdJPXbUROA()
	{
		throw /*Error near IL_0002: Stack underflow*/;
	}

	extern void AeMLDQCkOQTAIoAvQXApoJXbfEXEA(string string_0);

	extern IXmlSchemaInfo rvxAfgdWgXjejUBHSIVUADYeOUpB();

	extern string PonVIgPOBhFpJTVuhdvaHmeqaXFeb();

	extern XmlNode sQICMBCiXNPHPpSRngHXTeXsxjiOA(XmlNode xmlNode_0);

	XmlNode kpGvLCTuGAKszKWEjkqIrffkhkup()
	{
		//Discarded unreachable code: IL_0006, IL_000c, IL_000e, IL_0015, IL_001a, IL_0020, IL_0025, IL_002a
		//IL_000f: Expected native int or pointer, but got F8
		//IL_0010: Invalid comparison between Unknown and F4
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (ulong)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid metadata token*/;
		}
	}

	XmlNode UdwGfFFjyjVNvWWhRDBOIebgvyfAA(bool bool_0)
	{
		//Discarded unreachable code: IL_0003, IL_000a, IL_000f
		//IL_0004: Expected native int or pointer, but got F8
		//IL_0005: Invalid comparison between Unknown and F4
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		/*Error: stloc 1 (out-of-bounds)*/;
		/*Error near IL_0002: Unknown opcode: 0xFF*/;
	}

	extern XmlAttribute lSAeEckdfjvwHHyMwIjYlleYFYaMA(string string_0, string string_1, string string_2);

	extern XmlCDataSection zFuFywQNKLihUhtDOvqfkQXHpfNyA(string string_0);

	extern XmlComment JgQXBFsyOlBUlgNVERQpOvqeDaxX(string string_0);

	unsafe XmlDocumentFragment ezBwdZwmrUMUyurWtEPCJbpfyVBN()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0017: Invalid comparison between Unknown and I
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			((IntPtr[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (IntPtr)/*Error near IL_0001: Stack underflow*/;
			this = (Class4)/*Error near IL_0004: Stack underflow*/;
			if (/*Error near IL_0009: Stack underflow*/ <= /*Error near IL_0009: Stack underflow*/&& /*Error near IL_000e: Stack underflow*/> /*Error near IL_000e: Stack underflow*/)
			{
				byte num = checked((byte)/*Error near IL_000f: Stack underflow*/);
				_003F val = /*Error near IL_0010: ldloc 0 (out-of-bounds)*/;
				*(object*)(nint)/*Error near IL_0015: Stack underflow*/ = num - val;
				IntPtr intPtr = ((IntPtr[])/*Error near IL_0017: Stack underflow*/)[/*Error near IL_0017: Stack underflow*/];
				if ((nint)/*Error near IL_001c: Stack underflow*/ <= (nint)intPtr)
				{
					break;
				}
			}
		}
		_003F val2 = checked(/*Error near IL_001d: Stack underflow*/ * /*Error near IL_001d: Stack underflow*/);
		_ = /*Error near IL_001e: Stack underflow*/| val2;
		/*Error near IL_001f: Invalid metadata token*/;
	}

	extern XmlDocumentType OGkmpEkiliGZHGciZylVKPKxASNbA(string string_0, string string_1, string string_2, string string_3);

	extern XmlElement ClqtuJudhZiYgfpmNDCjMcnWJWTGb(string string_0, string string_1, string string_2);

	XmlEntityReference npfemSZJSYxEQSZkZurdjOPQISqiA(string string_0)
	{
		//Discarded unreachable code: IL_0017
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Invalid comparison between Unknown and F8
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		short num2;
		do
		{
			nint num = (nint)/*Error near IL_0001: Stack underflow*/;
			checked
			{
				num2 = (short)unchecked(/*Error near IL_0003: Stack underflow*/ / num);
			}
		}
		while ((double)/*Error near IL_000a: Stack underflow*/ <= (double)(uint)num2);
		((IntPtr[])/*Error near IL_000b: Stack underflow*/)[/*Error near IL_000b: Stack underflow*/] = (IntPtr)/*Error near IL_000b: Stack underflow*/;
		_003F val = /*Error near IL_000b: ldloc 1 (out-of-bounds)*/;
		_ = ((double[])/*Error near IL_000d: Stack underflow*/)[val];
		/*Error near IL_000d: stloc 3 (out-of-bounds)*/;
		/*Error near IL_0010: stloc 0 (out-of-bounds)*/;
		/*Error near IL_0012: Invalid metadata token*/;
	}

	extern XPathNavigator zoFdpgYRjfAqYiZHmuPVUWSKBQOY();

	extern XmlNode LXSCIwHllgDMlIHnBROUqEgYrpraA(XmlNodeType xmlNodeType_0, string string_0, string string_1, string string_2);

	XmlNode gEbCRfRghfmyaSHmQEcFOSGsISKL(string string_0, string string_1, string string_2)
	{
		//Discarded unreachable code: IL_0008, IL_0024, IL_0028, IL_002e
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0003: Invalid metadata token*/;
	}

	extern XmlNode MnjKQZfsmjMYGgTPwagTpjrCJuaT(XmlNodeType xmlNodeType_0, string string_0, string string_1);

	XmlProcessingInstruction CevpbvzULUHfhepovxhJrNnrbGvK(string string_0, string string_1)
	{
		//Discarded unreachable code: IL_000e, IL_0012, IL_0018, IL_001d
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		_ = (sbyte)/*Error near IL_0001: Stack underflow*/;
		_ = 27600;
		/*Error near IL_0009: Invalid metadata token*/;
	}

	extern XmlSignificantWhitespace MwFRZWzdIucBQZBIQXUXLNOHaXdU(string string_0);

	XmlText MVWmWDGZkVlqiWPtepripAGMxxq(string string_0)
	{
		//Discarded unreachable code: IL_0001, IL_0007, IL_000c, IL_0012
		/*Error: Unknown opcode: 0xF9*/;
	}

	extern XmlWhitespace HgzKcMhyWkPrTNgnMxPxZyCrKwQd(string string_0);

	extern XmlDeclaration GmXzfprUvknAiYvhvMCsUmsRcvHF(string string_0, string string_1, string string_2);

	extern bool xMjjXnQIRBNhGhiKCTModJWJHDqb(object object_0);

	extern XmlElement mYgnAhbCzZTQdQVCxdayhggXBtsJ(string string_0);

	extern XmlNodeList GkbJvZNAjHMacdFXOKaRoJdGfbxY(string string_0);

	extern XmlNodeList hGWFncGPMLysnXmwKmuHfudarRie(string string_0, string string_1);

	extern int sBHWEudEOwjFxZQGGFYWeijSRREbA();

	extern string zFWjmPJPWzFjklifVPbyUPBPBeJW(string string_0);

	extern string nLhBFRgEjfqyXOuyMAgbuieIHuEi(string string_0);

	extern XmlNode OakXmmRSLtiIypYqiXbCShNTchAx(XmlNode xmlNode_0, bool bool_0);

	extern XmlNode wTFNDtHymMTZqaUuytPAJFODgBkC(XmlNode xmlNode_0, XmlNode xmlNode_1);

	extern XmlNode sgpDOWyYvtmbgcewWEJjhICnKscuA(XmlNode xmlNode_0, XmlNode xmlNode_1);

	extern void HWPVVPYwGNAuImUmHBxIherYERIDA(string string_0);

	void ogrxRPxNgkAzsgtLlkRyqyNwajnDA(Stream stream_0)
	{
		//Discarded unreachable code: IL_0005, IL_0010, IL_0027
		/*Error: Invalid metadata token*/;
	}

	extern void nePLvtInckBpUgmdVqJBBrAFsLQrA(TextReader textReader_0);

	extern void TbULgpTHKqhMuVhTGUmycVcnTCJD(XmlReader xmlReader_0);

	extern void phbHVJciuMTGWSacmJbwPODajECFA(string string_0);

	extern void nKEaBTDzYOmYYhpSAyTJncDRzYJd();

	extern XmlNode sImepJgFjCJnrxGZBsWFYDRDnVsd(XmlNode xmlNode_0);

	extern XmlNode xqIvDlfqcgApXBbgMBSkemjAjFDDA(XmlReader xmlReader_0);

	extern void GOGgtjptuwUPcqliKupLTQMDVLVi();

	unsafe XmlNode qXVMFYNhUZoTVxAgIPQYxbjWIoGq(XmlNode xmlNode_0)
	{
		//Discarded unreachable code: IL_0015, IL_0016
		//IL_0008: Invalid comparison between Unknown and I
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			if (/*Error near IL_0006: Stack underflow*/ <= /*Error near IL_0006: Stack underflow*/)
			{
				nint num = checked((nint)/*Error near IL_0007: Stack underflow*/);
				if ((nint)/*Error near IL_000d: Stack underflow*/ > num)
				{
					break;
				}
			}
		}
		long num2 = *(long*)(nint)/*Error near IL_000f: Stack underflow*/;
		_ = /*Error near IL_0010: Stack underflow*/- num2;
		/*Error near IL_0010: Invalid metadata token*/;
	}

	extern XmlNode rGAhbHAqhWWCERHgWDdUOhrhInHX(XmlNode xmlNode_0, XmlNode xmlNode_1);

	extern void dCyBDMHUlsXuJGmgzEMsQCTKBXel(string string_0);

	extern void ESlcIyNLQzCZeDGpgAisFIyJKVvjc(Stream stream_0);

	extern void QgujjVVUqMiuJdWpvSqOqmEAUPfM(TextWriter textWriter_0);

	extern void HGwPBrzTPRAbxBroXmTicDKrBcXy(XmlWriter xmlWriter_0);

	extern bool SPHXuUBAtHytJEHoJBoIxrEZDgyx(string string_0, string string_1);

	extern string MQPaNKvUMClZXxMwOtJmwFuPBrUB();

	extern void SevFGriUNwDsLaskHIPMAxoIqzPpB(XmlWriter xmlWriter_0);

	void YVMNpVawReEzStZqcOmnNMnwzQrs(XmlWriter xmlWriter_0)
	{
		//IL_000d: Invalid comparison between Unknown and I8
		while (true)
		{
			/*OpCode not supported: Ckfinite*/;
			if (/*Error near IL_0007: Stack underflow*/ > /*Error near IL_0007: Stack underflow*/)
			{
				_003F val = /*Error near IL_0008: ldarg 2 (out-of-bounds)*/;
				long num;
				checked
				{
					num = (long)unchecked((ulong)checked((long)((double[])/*Error near IL_000b: Stack underflow*/)[val]));
				}
				if ((long)/*Error near IL_0012: Stack underflow*/ >= num)
				{
					/*Error: Could not find block for branch target IL_0012*/;
				}
			}
		}
	}
}
