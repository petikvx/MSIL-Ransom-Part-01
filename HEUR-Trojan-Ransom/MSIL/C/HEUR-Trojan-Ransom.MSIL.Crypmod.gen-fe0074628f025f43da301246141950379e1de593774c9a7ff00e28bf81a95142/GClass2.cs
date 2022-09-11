using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

public class GClass2 : ComboBox
{
	private int int_0;

	private Color color_0;

	private Color color_1;

	internal static Struct11 struct11_0/* Not supported: data(56 A2 EA 4B 7D 5B 94 47 3B 48 9F 97 E5 6C B0 FA 9C 07 1A E5 C3 CE F1 5D AF 3E 15 AC DA 29 91 46 6B 95 DE 8D 1B 9A 5F 23 E5 A3 16 7A 23 59 72 D9 87 C1 75 30 BA 6F EA 8E 3B 4B 24 43 56 4E C8 8E 30 5D A5 89 B4 FC 4F 85 6D C9 5A D5 34 39 6B 38 BE DE D5 22 22 01 AC 9B 30 6E D0 E9 6F 74 4C 84 4B D8 99 CB 1A DD 1A 61 FC 85 D1 B7 2E A6 2D 17 46 6D 30 6E A1 54 A5 CC DF A0 DF 80 98 20 83 CC 42 F2 60 C7 8E B4 0B C3 3F 32 15 13 ED 88 26 76 32 27 91 60 94 37 67 D9 BA E4 8B 27 B6 2C 07 C2 63 90 55 09 91 DA D6 9E A2 60 8C F5 D3 BE E8 54 DC EC EB AB 1B 77 60 0A 7F F9 9A BE ED B1 3E 0A 3C EA 1C 05 BD A7 C6 00 04 16 D0 50 FC 6F E1 B3 D3 3B 4C 9E 3E D4 22 17 F9 95 47 65 CA 3F C2 FF 14 91 10 47 51 A3 92 DC 9D 5C 47 33 73 C7 A3 92 86 3C A7 E9 CA CD 1B 48 25 59 56 FC 86 C9 F9 47 43 0D D8 42 EB 0A 81 3E 56 94 8B 8E F3 C3 9C F1 00 9B 07 DC 62 E5 DD 54 D3 C5 02 A3 53 1F 7D 3D 02 B5 CB 84 90 C3 4D 1A 75 99 02 71 E5 FE 5E D0 D8 4D 62 27 80 6D D6 85 29 2D 11 3A B1 AB B4 85 F9 D8 93 80 A1 67 3C 7C C6 8A 46 CC C7 E5 57 2F 0C B4 C2 19 F4 F9 99 92 B2 0F BD E0 1B AC 38 7B 03 2A 86 C2 1D B3 08 58 B9 01 BD AE 17 59 1A 0E 76 3F 1D 65 CD C4 91 C3 89 D2 CC 77 C2 EE 6F C3 F7 67 4F BE 8D 34 F7 B9 A1 E3 01 0A A5 B9 13 6D 70 BD 7D 57 AD F7 55 D0 A4 37 78 1E 05 03 F3 B8 44 AD 41 00 9D 08 C3 95 18 FB 78 EC AD EA D5 4B 40 0A D8 A2 26 6B 4C 01 1C BB 87 B5 DF 87 2B 01 F2 65 0A FC 5E 25 B2 F7 42 38 BD 47 73 32 CE AA DD F9 38 95 37 71 11 0E D4 C3 33 5C 9B 01 AE F6 83 37 FC 3D 65 8E 7E D3 FD 47 34 2A FE B2 91 89 A4 6A 93 E0 E9 68 07 3F 1D CD 42 F3 22 15 E6 3E 25 0F C5 39 CE AD 6D 35 D9 CA 78 85 82 34 89 E8 13 67 F4 D2 81 6E CC 4B 3A 13 EE 99 B1 31 69 34 A9 0B B7 7B 09 E9 39 11 64 7A EF 67 7F 78 4C C7 79 B3 4E 1E C2 E7 C2 7C 91 88 FD 30 6C 52 A1 7C CB 21 80 77 D4 FA 28 73 F4 78 33 C3 16 8C 44 26 77 92 AF 10 67 25 87 89 E0 1B A9 D7 38 AE 24 72 0C 2D 72 B9 DA 37 F5 4E 18 73 AA A5 19 02 07 05 41 AB 09 5C EE 6F 7E BA 9E CE B8 6E 04 79 5C BA 67 EC 3B B5 1D 35 E4 B0 60 4B EE 00 3B 39 FF 63 AC 67 6A 4E 2F 9E 42 C7 E6 09 64 15 5E 28 DF AF 3A D4 2D F7 00 44 B0 8C A6 E4 65 E3 EE 96 C2 42 25 B7 C4 99 07 61 39 F8 77 FE 73 AC 00 CD 17 F8 AB 55 F7 F2 45 A8 9F EE 3A FA A9 3E 9D 48 BA A1 15 FE 25 8C D1 9B FD 04 81 AC 1F 53 47 9D 9A ED 55 3C E8 34 96 DE 6B CA 80 43 21 21 EB A0 7D 80 52 F9 7F D7 76 DF F4 35 A0 81 2F EA E7 06 D2 35 85 9C B2 30 AF D6 5A 2C B7 DF 65 7C 65 79 75 DF 7F AA E1 C9 78 33 B8 42 83 46 DA 90 25 86 55 2B 7C 81 A3 72 5A 8D 27 08 F7 24 DC 5E 6C C8 38 BE 0E 15 3B 15 59 64 B0 73 CA 3A EA 27 CC 0A 8D 73 A6 DA 6D 6E 8F 9B 15 6A 85 66 21 BA 20 DA 30 1D 69 04 9C 07 FB 0F 73 80 33 FF 95 CE D7 E9 10 69 E4 D3 5E B0 4E A8 E2 45 1D 80 97 9C 28 DA F3 FB 48 B9 F6 52 41 A6 6B B1 40 B5 A5 65 2C 18 48 B1 7E 76 29 AC 30 48 D0 A7 07 55 DC F7 B7 5F EC 5A 99 D7 57 45 FF C6 2E BE 86 F8 51 0C 68 41 CC A6 A7 98 19 EE 9A 95 9D 83 83 EC 52 DA 98 E7 AF 39 4A EF B1 90 4C 52 26 EF 93 45 60 A3 75 1C 03 EF 8B 81 E4 E9 3B 59 8B E5 94 7C 97 35 F3 46 A7 98 B2 0A 12 83 CA C4 E9 FB 92 3D 0D 4A 56 E5 87 E4 80 B5 D4 2B 49 08 58 C1 FD 9B 0E 18 A5 60 6B 77 E7 34 6D CE 09 1D E1 2C 79 D3 1B E1 51 FE BE 2C F5 1D 9F 27 F1 A5 46 23 08 28 52 73 C0 C7 62 D6 F0 BA CD C0 06 D9 A4 39 1B 4F C8 87 24 12 43 22 E5 58 8F 69 DF 20 13 FF 12 DC C9 55 4A 18 26 B5 B4 52 28 0C F6 EE 9C 6A 2F C2 D6 1E 33 F8 7A 6A 7F C2 5A 65 D7 BE 01 61 B0 5B 0D B1 25 B5 1D 14 77 CB 88 FE 60 17 60 77 FC 42 83 C5 D2 72 FE 5F 74 EE 4A A7 3A 06 CE 3C 67 EC 85 93 43 05 E1 F2 44 15 E3 49 B9 67 58 A8 5B C7 91 5C A0 DB 36 A8 BF 6D 15 A3 25 6F BC 9E 41 B2 C8 EE BB 34 D8 51 E1 FC 43 3C 84 D0 1B B5 E6 B8 3E 03 DE 73 B9 9D) */;

	internal static int[] int_1;

	private GControl12.Class7 class7_0;

	public extern int Int32_0 { get; set; }

	public extern Color Color_0 { get; set; }

	public extern Color Color_1 { get; set; }

	public extern Color Color_2 { get; set; }

	public GClass2()
	{
		//Discarded unreachable code: IL_0023, IL_002d
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected I4, but got Unknown
		//IL_0028: Invalid comparison between Unknown and I4
		do
		{
			ulong num = checked((ulong)(/*Error near IL_0001: Stack underflow*/ ^ /*Error near IL_0001: Stack underflow*/));
			((long[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = (long)num;
		}
		while (/*Error near IL_0008: Stack underflow*/ <= /*Error near IL_0008: Stack underflow*/|| /*Error near IL_000e: Stack underflow*/== /*Error near IL_000e: Stack underflow*/|| /*Error near IL_0013: Stack underflow*/< /*Error near IL_0013: Stack underflow*/|| /*Error near IL_0018: Stack underflow*/>= /*Error near IL_0018: Stack underflow*/);
		long num2 = (long)/*Error near IL_001a: Stack underflow*/;
		_ = -((short[])/*Error near IL_001c: Stack underflow*/)[num2];
		/*Error near IL_001e: Invalid metadata token*/;
	}

	protected override extern void vmethod_0(PaintEventArgs paintEventArgs_0);

	protected override extern void vmethod_1(DrawItemEventArgs drawItemEventArgs_0);

	protected override extern void vmethod_2();

	protected override extern void vmethod_3(EventArgs eventArgs_0);

	static extern void ABhVtFNERBmroKqhrIEtAZMQcssQ(ComboBox comboBox_0, DrawMode drawMode_0);

	extern void NtiUdwbuxxBwDMZBrqCJYjmeoLVj(int int_2);

	static void VykxDaqsRIXvaTojdctPjYupdCGEA(Control control_0)
	{
		//Discarded unreachable code: IL_0005, IL_0016
		/*Error: Invalid metadata token*/;
	}

	unsafe static int AJYphVFLnqyTkuCxnMbOclgpOqEX(Control control_0)
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

	static extern int xgPdxQFmWmifQXWCKkKEezRoqApRA(Control control_0);

	static extern Bitmap nxQAfzZkyZkbWwTyYSBurxJjpJsi(int int_2, int int_3);

	static extern Graphics tfTwzApCDTGUsbnwSfxOkcTSIbJQA(Image image_0);

	static extern void EBiCPRcVXwxKPHXVddsAJtGLPHSt(Graphics graphics_0, TextRenderingHint textRenderingHint_0);

	static void icaeARYhfpxtMtRMPRKJUklmCJQS(Graphics graphics_0, SmoothingMode smoothingMode_0)
	{
		//Discarded unreachable code: IL_0006
		//IL_0008: Unsupported input type for neg.
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Incompatible stack heights: 1 vs 0
		_ = (float)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern void UfCzgIQlhUQovgskQXdeVXwhsxbG(Graphics graphics_0, PixelOffsetMode pixelOffsetMode_0);

	static extern Graphics FITPwHxkdiegAsReDaVwbpnfPCMfA(DrawItemEventArgs drawItemEventArgs_0);

	static extern DrawItemState tFswKdoIkrFkTPpvnAxCOQitOzSd(DrawItemEventArgs drawItemEventArgs_0);

	static extern int jQIbQCrxkTnXcRtakLuSvggDTZlC(object object_0);

	static int xatybhNddVLtjiYkqsvSyeEASgLb(DrawItemEventArgs drawItemEventArgs_0)
	{
		//Discarded unreachable code: IL_0005
		/*Error: Invalid metadata token*/;
	}

	static extern Rectangle nwRhCxERRWbYrevccJmJXZBnIDLU(DrawItemEventArgs drawItemEventArgs_0);

	static void bRjgKveNudGfXjAhXSydHsAodFbu(Graphics graphics_0, Brush brush_0, Rectangle rectangle_0)
	{
		while (true)
		{
			_003F val = /*Error: ldloc 3 (out-of-bounds)*/;
			if (/*Error near IL_0007: Stack underflow*/ >= val)
			{
				/*Error: Could not find block for branch target IL_0007*/;
			}
		}
	}

	static ObjectCollection kVAMQoQinVgmFmKygPLzPGXqKvMG(ComboBox comboBox_0)
	{
		while (true)
		{
			if (/*Error near IL_0005: Stack underflow*/ < /*Error near IL_0005: Stack underflow*/)
			{
				/*Error: Could not find block for branch target IL_0005*/;
			}
		}
	}

	static object BEyRAxykwSSSkvQLGLIRrWiXsTfs(ObjectCollection objectCollection_0, int int_2)
	{
		//IL_0001: Invalid comparison between Unknown and I4
		byte num;
		do
		{
			num = ((byte[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		}
		while ((int)/*Error near IL_0006: Stack underflow*/ <= (int)num);
		checked
		{
			_ = (uint)/*Error near IL_0007: Stack underflow*/;
			/*Error near IL_0007: ldloc 3 (out-of-bounds)*/;
			/*Error near IL_0008: ldarg 3 (out-of-bounds)*/;
			_ = 4;
			/*Error: Unexpected end of block*/;
		}
	}

	static extern string ijeDxmiKuaMQXJrbiwMtAzXFUOqb(ListControl listControl_0, object object_0);

	static Font IkWEQjNdRAiigxFchjYtIelQaSdE(DrawItemEventArgs drawItemEventArgs_0)
	{
		//Discarded unreachable code: IL_0005, IL_000b, IL_0014, IL_001a, IL_0021
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	static extern SolidBrush gMegQHRvvmylnjPjkmgjodWfTJEh(Color color_2);

	static extern void NEsCtOUaiTdkGYOZPaAPBMEpNKWR(Graphics graphics_0, string string_0, Font font_0, Brush brush_0, RectangleF rectangleF_0);

	static extern Color mJeXxasugCbzNQMNKyjIwhcZXJlm(DrawItemEventArgs drawItemEventArgs_0);
}
