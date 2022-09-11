using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class GControl14 : Control
{
	public delegate void GDelegate5(object sender);

	protected bool bool_0;

	protected GClass1.GEnum1 genum1_0;

	[CompilerGenerated]
	private GDelegate5 gdelegate5_0;

	internal static Struct10 struct10_0/* Not supported: data(8A 09 B1 73 48 A8 BE FD 41 C8 AB 8A 0E 04 49 57 2D 85 19 1B A7 7A AF 8D 3E CC 4F BE 1A 30 28 F5 70 FE DA D2 EE 9F 70 B9 F3 01 AC 6F 42 64 CF 3E CE BA 77 DF 6D E9 81 15 67 DD 62 1F 96 1B 33 70 52 E9 BD E5 B4 EF 47 26 92 D5 9C 53 73 37 C0 C0 05 FB 7B 86 A0 BF 70 05 92 16 24 8E F7 C1 58 B6 06 EE D1 6E 9A F1 E0 4A BA F6 ED 21 73 5B 5C A7 C7 BC 8C C9 84 F8 04 65 7A 4C E4 1C 93 69 3A F5 4E 0D 54 69 04 85 7B AA 86 19 33 87 9C B4 D6 31 A8 35 3C 77 7A E9 D3 BF 64 1B A4 A1 85 24 16 D8 DB 1A BE 21 7B 07 CC 37 2D 3B 3C 9D 03 4D 71 A9 47 99 BA 64 81 9F C9 F3 65 C6 85 BF 65 9A BD 26 15 81 85 63 E9 1C AE 70 FB 9E A5 0F 38 7C BB DD F4 CE 19 DD 86 B6 24 D4 BA 3E 70 05 99 FA 75 E6 DC 44 84 E3 E1 06 41 C9 74 40 1C B0 CA 47 A3 BE FC BA 17 E4 4A 97 AB B1 39 B9 47 67 C9 DE E2 55 6F 0E 3A 5B 84 0D 2A CF 91 7F 9D 78 F1 E8 0E 5A A8 1B 48 76 85 F2 D1 AD 53 7D CF E7 2C EC 46 87 00 C1 48 EA 1B 64 04 F3 29 D3 D5 A2 F7 9E D9 B5 A1 72 B7 79 98 A3 67 76 28 9B 5F 85 00 5C B3 6A BF 7B 8F ED F5 B7 AE 8F 02 36 9C E2 14 2A E3 47 9D 33 FF 53 81 CA 19 5D BC 9B 4C 53 4A 2A B5 13 DB 9E 5B 85 0D 5E 70 BB 64 B4 2D C6 E5 B2 AB AB DF 93 8C 49 3C 04 3D D4 40 DA 87 70 E5 42 29 64 62 B2 A6 19 D9 8E 6D 6B 60 7C 04 6B E3 43 AE DC EE CB 0C EB 01 77 73 49 34 BD 78 AB D5 58 9E 4B A2 DC 55 85 18 A7 0A 34 5E 92 FA CC F9 70 1F CF 7C 44 6E AD B0 55 51 83 6F 87 BD 74 D9 DD 5A 1D 84 FA B9 54 28 12 CC A2 97 A3 B6 30 C7 DF 06 36 8E 6F CF 51 6F 64 40 53 6C 44 7F 4B B3 59 BD 47 FC F0 8F 77 F8 8A 78 A3 28 28 6F F3 36 E7 7C 4E 71 E4 74 A3 B6 DB 5D 39 E4 7E 5C CD 0B D6 4F EE 10 E1 A9 5A E9 88 8F 9B 13 5E A0 90 1F 15 89 F1 A1 05 47 7B 1F BD E2 45 19 BF AD 5C 9B 04 40 D8 DF 49 4B 1E 71 2D A5 31 75 C5 43 D5 11 25 1B AB 38 89 04 83 30 81 89 C8 74 57 FE B0 26 A5 6E 30 27 AC 79 DE E2 A1 0E 01 8F 69 0F 90 79 04 31 DA 25 8C 7E 7A 8E A5 0D 1E 71 2F 62 33 BD 43 B0 A6 FD B2 41 15 0C F2 0C 49 4C 0D 9C 11 0E 6D F5 37 2C 2F 3B 4B 1D 5C 2B 35 5F 04 D7 BD FE 5D 35 B8 8A 4D 06 09 F1 F9 B6 B3 1E 55 DB 60 06 41 99 E5 80 C5 D3 10 50 E3 7F 8A 39 F4 D1 FD 09 35 CC 38 3F 28 4E 9D AC E6 89 2E 07 21 C1 7B 86 AE 1B D4 B2 72 4A B9 F0 BD F8 16 86 44 43 FE B4 FF C1 BB 19 47 59 2C CC 21 62 42 C8 05 1E 7F 8C 87 A7 36 2B 36 9E FB C5 BF E3 FF 38 C8 E6 75 52 66 37 67 FC 7C A4 C3 80 4E 5B C0 C3 1F 02 51 25 17 E5 74 5B 43 58 79 81 81 4A C6 D5 1F 8B 32 BB AE 90 92 75 40 D1 8A 18 D7 07 B9 E7 A4 17 17 0D CC C2 65 59 BF CF DF 50 2B CE 62 B8 8F 69 B0 2B 43 78 73 5E 53 4A 29 E0 41 47 AE 57 82 3E 43 72 C8 9A F8 A9 C3 82 29 E4 70 A5 EE EE 3D DF 2B 73 74 77 02 14 43 32 80 A1 F7 66 05 6D 62 87 56 8F 7C A8 23 71 52 2E 33 96 99 C5 D0 21 AC 4D 8C 0D 8E F4 64 6B BA F9 E8 54 F5 37 A7 8A 7B DC B9 EA 56 97 57 B5 02 FF 33 C1 08 14 C6 49 B4 9C 10 13 0B B1 C5 C3 28 BD 47 0C 2C 09 74 B0 71 D8 4D B4 8C 96 92 E1 E5 4A C6 E3 5A 66 98 B9 D6 08 4D 6C 98 DC E4 C3 5B 02 25 E9 34 F1 0E 48 1D E5 A0 41 7F 26 67 95 88 76 D7 F7 3A 64 59 7A AE 63 D0 A9 9D 91 38 DF C7 03 C0 78 78 5A 90 7B B7 8E 25 42 6E D1 37 25 6A B0 AC 34 29 76 CD 05 63 B9 85 BB 9F E1 40 A4 A5 75 2B 2E 6C 3B 82 E0 0A 3B 73 CD 61 9B 48 A0 4A 70 54 DE F7 76 C3 FE 19 6E C3 1E 44 7A 77 E6 E7 F1 A2 73 5F 12 73 37 85 E2 6F 9B 81 A5 7E 18 BB 68 A8 6F D3 05 1D) */;

	internal static char[] char_0;

	private GControl12.Class7 class7_0;

	public extern bool Boolean_0 { get; set; }

	public extern Color Color_0 { get; set; }

	public extern event GDelegate5 Event_0;

	protected override extern void vmethod_0(EventArgs eventArgs_0);

	protected override extern void vmethod_1(PaintEventArgs paintEventArgs_0);

	public extern GControl14();

	protected override void vmethod_2(EventArgs eventArgs_0)
	{
		//Discarded unreachable code: IL_000b, IL_0013, IL_0018, IL_0019, IL_001b, IL_0024, IL_0032, IL_0037, IL_003c
		//IL_0001: Invalid comparison between Unknown and I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Invalid comparison between Unknown and I4
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		sbyte num;
		do
		{
			num = ((sbyte[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		}
		while ((int)/*Error near IL_0006: Stack underflow*/ != num);
		/*Error near IL_0006: Invalid metadata token*/;
	}

	protected override extern void vmethod_3();

	protected override void vmethod_4(EventArgs eventArgs_0)
	{
		//Discarded unreachable code: IL_0006, IL_0010, IL_0015, IL_001a
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		((object[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (object)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	protected override extern void vmethod_5(EventArgs eventArgs_0);

	protected override extern void vmethod_6(EventArgs eventArgs_0);

	protected override extern void vmethod_7(EventArgs eventArgs_0);

	unsafe static Delegate GbvtIkrPkMYvGQsxRmMjrWigCnSK(Delegate delegate_0, Delegate delegate_1)
	{
		//Discarded unreachable code: IL_001f
		//IL_000b: Expected O, but got I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		do
		{
			*(_003F*)(nint)/*Error near IL_0002: Stack underflow*/ = /*Error near IL_0002: Stack underflow*/;
		}
		while (/*Error near IL_0008: Stack underflow*/ < /*Error near IL_0008: Stack underflow*/);
		delegate_0 = (Delegate)0;
		_ = (ushort)(uint)(checked((int)(~/*Error near IL_000c: Stack underflow*/)) | 0x3BB64875);
		/*Error near IL_001a: Invalid metadata token*/;
	}

	static Delegate axxAbRQQapKeMXFMNDvyChUTtVhiA(Delegate delegate_0, Delegate delegate_1)
	{
		//Discarded unreachable code: IL_0013
		_ = (ushort)(uint)(checked((int)/*Error: Stack underflow*/) | 0x3BB64875);
		/*Error near IL_000e: Invalid metadata token*/;
	}

	static void ABFzxjyBVjCulnmvHIPCEWWRIUQi(Control control_0)
	{
		//Discarded unreachable code: IL_0005, IL_0016
		/*Error: Invalid metadata token*/;
	}

	unsafe static int blWIZzYjiTntgYlEtbotIvZPbfLI(Control control_0)
	{
		//Discarded unreachable code: IL_000d, IL_0015, IL_001a, IL_001f
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Expected I4, but got Unknown
		//IL_0006: Expected native int or pointer, but got F8
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Invalid comparison between Unknown and I4
		double num = (double)/*Error near IL_0002: Stack underflow*/;
		_003F val = /*Error near IL_0003: Stack underflow*/<< (int)num;
		*(short*)(nint)/*Error near IL_0005: Stack underflow*/ = (short)(int)val;
		byte num2 = *(byte*)(nint)(double)/*Error near IL_0006: Stack underflow*/;
		_ = /*Error near IL_0008: Stack underflow*/& num2;
		/*Error near IL_0008: Invalid metadata token*/;
	}

	static extern int mhtPSSAuRewqcqlaQGXIOPcBTisn(Control control_0);

	static extern Bitmap uYgKCRqRHYILbRWeeDGutapnMOWC(int int_0, int int_1);

	static extern Graphics HZoUcZlsWbOBOgIclJRXGRYOaXbh(Image image_0);

	static void uEggcdhJLgqnUaoGwiyjuySPkuKZ(Graphics graphics_0, SmoothingMode smoothingMode_0)
	{
		//Discarded unreachable code: IL_0006
		//IL_0008: Unsupported input type for neg.
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Incompatible stack heights: 1 vs 0
		_ = (float)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern SolidBrush EDuBELbAkukzJvqUEXEDFeAAVOUHA(Color color_0);

	static extern Cursor DYiXCrINCeWSopOSSEcPKsWmFJmf();

	static extern void wUSLEgnPZaoqgpQshTOZdlwEBffD(Control control_0, Cursor cursor_0);
}
