using System;
using System.Diagnostics.SymbolStore;
using System.Reflection;

internal sealed class Class9
{
	private int[] int_0;

	private int[] int_1;

	private int[] int_2;

	internal ISymbolDocumentWriter isymbolDocumentWriter_0;

	private int int_3;

	private const int int_4 = 16;

	internal static Struct12 struct12_0/* Not supported: data(87 D4 F8 25 C2 D5 65 E0 8A 8E 79 CD 9F 64 80 00 3B FF 00 00 28 C4 FF FF 43 E9 00 00 F6 CC 00 00 40 9F FF FF E0 95 00 00 BA D6 00 00 A4 DD FF FF 86 84 00 00 74 FB 00 00 B5 09 FF FF 72 02 00 00 FB FF B3 63 31 CA 20 1E D7 49 34 0B D3 0E 3B 3E C9 1B BC 3D 83 58 BA 3D 05 93 BC 3D E2 6C BB 3D 22 C0 BA 3D 29 25 BB 3D F3 DE BB 3D 16 BD BB 3D 34 E8 BB 3D FD 0C BC 3D F2 63 BA 3D 80 66 BB 3D 67 AF 6F A1 99 B3 DB 5B 67 71 EF 48 45 32 F6 7B C5 B9 77 7B 2A D9 75 7B C5 27 77 7B 07 2D 76 7B FD FC 75 7B 1C 26 76 7B 3C 50 77 7B BF 6F 76 7B 9B 49 77 7B CF 3F 77 7B B9 1D 75 7B 70 D5 76 7B 84 E5 2A DF A8 60 96 99 24 EC AA 86 55 00 B1 B9 FB A5 32 B9 61 E0 31 B9 E5 03 32 B9 46 BE 31 B9 C8 75 31 B9 58 CE 31 B9 4F 25 32 B9 B1 F1 31 B9 01 6A 32 B9 70 57 32 B9 99 CD 30 B9 C7 CC 31 B9 3E 4E E6 1C 6E 02 51 D7 D8 8E 66 C4 DC 6A 6C F7 C9 34 ED F6 DB F9 ED F6 B7 23 ED F6 FB 4F EC F6 EF 06 EC F6 09 B3 EC F6 CD 20 ED F6 F4 C8 ED F6 88 CF ED F6 41 88 ED F6 A4 B5 EB F6 41 08 EC F6 4A 71 A1 5A B2 EE 0C 15 57 30 21 02 65 1B 27 35 29 E5 A8 34 C4 D9 A9 34 35 4C A8 34 5B DE A7 34 9E DA A7 34 0D CE A7 34 2C FB A8 34 B4 88 A8 34 3B 0B A8 34 2B 86 A8 34 FB 43 A6 34 76 D4 A7 34 72 7A 5C 98 29 33 C8 52 9C 1E DC 3F 58 8C E2 72 B0 62 64 72 22 4F 65 72 45 15 63 72 15 46 63 72 67 B0 63 72 D8 3D 62 72 BE 9D 64 72 61 4E 63 72 29 40 63 72 B8 D4 63 72 C0 E1 61 72 9A A5 62 72 DC E2 17 D6 3A 3B 83 90 FE 19 97 7D 0E E3 9D B0 39 23 1F B0 81 89 20 B0 DC 4A 1E B0 5C 25 1E B0 49 5A 1E B0 64 91 1D B0 CD 88 1F B0 D4 93 1E B0 95 55 1E B0 5F 72 1E B0 D0 A4 1D B0 2F A9 1D B0 C5 AD D3 13 24 EA 3E CE 3C AC 52 BB 97 3C 59 EE 89 FB DA ED 75 C1 DB ED 5A FE D9 ED 69 F5 D9 ED 48 E1 D9 ED 39 FF D8 ED 58 66 DA ED 26 56 D9 ED 9A 44 D9 ED 40 93 D9 ED 38 FE D8 ED D2 AB D8 ED 87 52 8E 51 89 48 FA 0B 37 ED 0D F9 91 F8 14 2C 87 F4 96 2B 48 AF 96 2B 4F 1C 95 2B D4 F9 95 2B 3E A7 95 2B 2B DC 94 2B 2D C2 95 2B 63 05 94 2B 56 6D 94 2B 02 C0 94 2B DB 24 94 2B AA F7 93 2B 54 64 49 8F FD 2A B5 49 2C 42 C9 36 AF CA D0 69 6F 90 52 69 45 81 51 69 50 EC 50 69 8B EE 51 69 9F 1C 50 69 69 A3 50 69 12 1E 50 69 D7 4E 4F 69 94 B2 4F 69 AE 61 4F 69 CA 5E 4F 69 52 66 4F 69 AE 4D 04 CD 69 81 70 87 11 34 84 74 E9 11 8B A7 A4 ED 0D A7 B9 B9 0C A7 1F 99 0C A7 CD 76 0D A7 83 0B 0B A7 57 C2 0B A7 64 CF 0B A7 91 C3 0A A7 3E FE 0A A7 94 98 0A A7 D4 30 0A A7 A6 69 0A A7 7D 36 BF 0A FE 1B 2B C5 FC 92 3F B2 D6 E4 46 E5 07 A4 C9 E4 19 A9 C7 E4 F1 2C C7 E4 D3 AF C8 E4 E7 81 C6 E4 8B 83 C6 E4 25 3F C6 E4 52 C4 C5 E4 26 74 C6 E4 22 16 C5 E4 B7 E4 C5 E4 16 B5 C5 E4 AC B7 7A 48 DE 96 E6 02 82 02 FA EF 8B 23 02 23 27 D1 84 22 55 CE 82 22 1E 9A 82 22 E1 D9 83 22 E8 66 81 22 B5 5C 81 22 F4 FD 81 22 91 6E 80 22 EC 50 81 22 EE CC 80 22 02 A6 81 22 5A 1F 80 22 31 2F 35 86 70 B2 A1 40 6A 35 B5 2D D9 3E BD 60 9D 43 3F 60 07 C5 3D 60 E2 05 3D 60 0D 79 3F 60 B4 6B 3C 60 D1 A9 3C 60 AB 16 3D 60 85 7D 3B 60 8B 31 3C 60 7A A8 3B 60 E3 C3 3C 60 D9 3F 3B 60 30 1A F0 C3 2F BE 5C 7E A6 91 70 6B 3A 37 78 9E 0C 3C FA 9D F3 6B F8 9D 3E E7 F8 9D 75 85 FA 9D AA 70 F7 9D 23 11 F7 9D 2F 2F F8 9D 36 1F F6 9D A4 F7 F7 9D 5C BA F6 9D 9C 8F F7 9D 57 D8 F6 9D 6E FD AB 01 AB E3 17 BC BD 86 2B A9 BA 1A 33 DC BB D2 B5 DB D0 D2 B3 DB 9C 66 B4 DB 5F 18 B5 DB 30 92 B2 DB A3 79 B2 DB E6 1D B3 DB A9 A8 B1 DB 7D F1 B3 DB 96 01 B1 DB C8 72 B2 DB 1A 6F B2 DB 9F CC 67 3F DB 29 D3 F9 56 9B E6 E6 FE 2A EE 19 7B DC 70 19 E3 A3 6E 19 0F E4 6F 19 59 2A 70 19 89 FB 6D 19 21 5A 6D 19 EA D7 6E 19 D1 2A 6C 19 EB 38 6F 19 82 24 6C 19 17 50 6D 19 D6 EE 6D 19 06 3C 22 7D F4 20 8E 37 67 EF A1 24 BD 11 A9 57 EF 1A 2C 57 F1 03 29 57 23 CE 2B 57 EF 54 2B 57 78 D9 29 57 6E 94 28 57 D7 46 2A 57 F0 45 27 57 20 5D 2A 57 46 96 27 57 A1 4D 28 57 6D E9 29 57 55 9F DD BA 8D EB 49 75 0E C6 5D 62 36 B2 64 95 47 76 E7 94 38 D0 E4 94 C9 6E E6 94 15 1B E6 94 B6 9A E5 94 67 68 E3 94 D8 6A E5 94 09 D5 E2 94 FF 31 E5 94 E9 D1 E2 94 EE E1 E3 94 43 EC E5 94 C6 B2 98 F8 61 C3 05 B3 0F C9 18 A0 8F A7 1F D3 BB 29 A2 D2 82 7A 9F D2) */;

	internal static int[] int_5;

	private Class18.Class22.Struct8 struct8_0;

	internal extern Class9(ISymbolDocumentWriter isymbolDocumentWriter_1);

	internal void method_0(ISymbolDocumentWriter isymbolDocumentWriter_1, int int_6, int int_7, int int_8, int int_9, int int_10)
	{
		//Discarded unreachable code: IL_0005, IL_000b, IL_0010, IL_001c, IL_0024, IL_002a, IL_002b, IL_0031, IL_003c
		//IL_001e: Unsupported input type for neg.
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got I4
		//IL_0037: Invalid comparison between Unknown and I8
		/*Error: Invalid metadata token*/;
	}

	private unsafe void method_1()
	{
		//Discarded unreachable code: IL_000f, IL_0014, IL_001b
		//IL_0003: Invalid comparison between Unknown and F8
		//IL_0016: Invalid comparison between Unknown and I4
		while (true)
		{
			*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
			double num = (double)/*Error near IL_0002: Stack underflow*/;
			if ((double)/*Error near IL_0008: Stack underflow*/ <= num)
			{
			}
		}
	}

	internal static bool smethod_0(ResolveEventArgs resolveEventArgs_0, out Assembly assembly_0, AppDomain appDomain_0)
	{
		//Discarded unreachable code: IL_0005, IL_0010
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got I4
		//IL_0019: Expected F8, but got I4
		//IL_001c: Expected I8, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	internal extern void method_2(ISymbolWriter isymbolWriter_0);

	static extern void smethod_1(Array array_0, Array array_1, int int_6);

	static extern string smethod_2(ResolveEventArgs resolveEventArgs_0);

	static extern bool smethod_3(string string_0, string string_1);

	static extern void smethod_4(ISymbolWriter isymbolWriter_0, ISymbolDocumentWriter isymbolDocumentWriter_1, int[] int_6, int[] int_7, int[] int_8, int[] int_9, int[] int_10);
}
