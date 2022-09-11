using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class GControl3 : Control
{
	public delegate void GDelegate0(object sender);

	[CompilerGenerated]
	private GDelegate0 gdelegate0_0;

	internal static Struct9 struct9_0/* Not supported: data(F8 0C 83 0D 90 46 6F 83 6B 16 F4 A3 04 E3 0C 42 0B C8 42 BA 11 43 AC 2B AF ED 5D 07 30 4B A2 17 6A 97 A6 A5 C6 86 31 D2 A5 F4 C9 28 51 DA D1 6E 1E 2A 3F F7 98 3C 4B A2 06 DC 79 69 54 9D 1E 67 F9 3D 1E 1F 26 43 68 B8 AB 58 68 CE 8A 5A 43 AB 52 C0 D5 B3 35 B4 02 57 4F 41 75 A7 DA 64 E6 AA 75 02 58 A5 B6 93 06 5B 2D 55 35 0F 55 24 9E BB 59 FA EB CD D3 76 FB 33 A0 6E 53 08 9B B3 56 98 2B D4 46 83 E3 98 E2 35 6F BC 22 BA 3A 47 66 55 52 C6 C0 B0 57 87 32 83 0C 8D 40 27 15 65 24 F3 F4 EF 3F 75 40 B0 49 2E 1A 8B 05 E2 AC 3D 6E 66 92 0F DB 1D 3F 4E AA 1C DC 8B 97 3B 7F B2 1E 57 74 31 8E 63 D7 4C 7A 07 07 0A 0D A4 5C AC D4 94 F5 6E AB 91 C1 89 AF C8 B3 BB 4B 6A 83 BF 23 D5 27 17 20 44 DB D6 95 B8 E4 10 AD DF F4 23 6A A7 77 5A 32 0F B8 E3 4A 7C D8 56 2E 21 AB 7A 47 24 09 8E 40 7B AE 3E E1 04 65 04 37 95 80 F8 26 A3 15 44 FF CC 33 84 E6 70 88 6B 79 C1 3D 77 EE 0D 8D DC 0E 6B 06 A3 D8 D0 EB 57 51 88 3B 91 E7 E9 CD DE 0A C4 DB 0C EC 23 1F C3 36 C2 03 80 20 4A BE 69 EA CE 7A 56 10 76 2E E8 25 22 2E 8F C8 7A C8 A5 62 96 39 AD 9C 0E 25 19 90 30 A8 E5 F4 4F A4 C0 7A DE 7E 89 C5 F4 8D 7A A6 BF DC F8 E8 65 37 FA 5D 3C 82 D1 FA CC CC 86 F8 6C A5 1B E7 B1 06 71 62 01 7C E8 F8 A1 86 28 F5 03 98 ED 77 4A FF F6 DB 17 F3 89 6A 9E FD D2 B2 52 FC 8F 08 01 54 E5 98 1E 70 64 BE 75 D8 F8 0E D5 62 0D 55 C6 D9 16 68 94 21 CE 00 8C 84 A5 E9 A8 8B 6F 7E D9 02 70 25 F4 FE AF 09 A3 2B 68 7B 29 2B DE DE EF C8 04 FC 1A 34 0D E7 EA 1F E6 24 FF 93 16 1B 81 31 B6 E9 04 FD 13 3E D8 D0 9D B1 7E C7 EE 71 BC DC DE DE E2 92 2B F5 83 C7 E9 8D 32 37 70 FD 2F 8A 0F 24 14 08 31 4D 28 C8 ED B6 62 47 52 86 88 F0 1B 4E 35 23 1E B1 23 0D 67 33 CA 4B 76 E8 7B A1 E1 45 35 41 F7 5A A7 0C A7 81 7C 5A 6F 8F 86 8E E9 93 27 26 CF 06 C6 C1 9A 05 F1 C3 DB 1E 2A 74 50 AB D7 11 C6 4B 91 C8 93 8E 45 2B 38 9D 73 B0 40 5F 89 09 72 4B 2E 2B CE 46 D7 4F D1 F9 50 AF E1 6B 6B 39 15 61 49 F7 C7 D3 8E AE 42 E8 12 AE BD 32 09 33 2E 43 75 28 AA 8C 62 27 1A 1E D2 EB 52 A0 F6 11 4D C6 2D 43 EC EA D2 50 5F B5 E8 5C 5D 60 D2 CB 37 8B 04 F3 7A 93 3F FD C2 67 90 14 BE 15 1A F2 22 AA F5 F8 86 94 5B 14 54 44 62 52 55 61 8E 76 1D 52 AB AE DE 80 6B AA 0E B5 B7 5E 9B 2B 4A EB 51 C4 36 30 39 CC 7C DE 16 01 B0 21 5C 6E A0 06 29 10 B1 09 24 1E 10 FD A2 54 4F C5 D6 E9 ED AE F5 DB 86 BA 83 0C 3E F1 42 B5 0C 99 D9 48 BC A5 77 19 66 AF 00 54 8C 3E 7A BC 9C F8 0B 9D 72 36 F2 38 7A 98 64 C9 64 92 CF CE A6 41 A5 07 57 7F C8 B9 28 1A 6C A5 06 F6 60 4A CE 7F 80 67 E2 04 F5 22 96 F1 A6 ED EC CA E0 66 73 26 3E 72 6B EF 27 C3 1E F7 12 AD C8 5E 32 9B 69 66 57 4D BD 88 30 7C 26 AD 69 20 99 0F 8C 11 B6 89 05 F0 E7 DB 64 08 C5 D0 99 08 3C 1E FA 73 55 EB 6C C6 CE 6E 0D 7A EF A9 F3 EF D0 49 54 46 80 84 0F 36 E6 B9 9E 24 28 ED 1E 25 32 45 4B 8E B9 5C 86 7B 1E 5B 3A 14 77 72 B1 8C CC 0F EA 30 B1 BC 63 80 B3 14 05 2D 9B 0E C3 81 91 04 09 05 54 60 8B 5B 52 25 CD 6F 66 EF E9 CF 5D 2B 0B 2E D7 F4 87 93 DA 1F E1 DE F3 F7 2B AA 68 C4 5F CC 63 8A CF 5C 29 23 C8 A0 9C E5 CC A9 55 EA 2A F7 44 69 1B 4E 3C A9 C3 9F 7E 41 9B 86 0D 61 1F B7 10 91 90 91 97 CB A0 08 63 A1 29 5C 5E ED 1F 56 B1) */;

	internal static char[] char_0;

	private Class16.Class18 class18_0;

	public unsafe bool Boolean_0
	{
		get; set
		{
			//Discarded unreachable code: IL_0007
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			_ = *(long*)(nint)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public extern event GDelegate0 Event_0;

	protected override extern void vmethod_0(EventArgs eventArgs_0);

	protected override extern void vmethod_1(MouseEventArgs mouseEventArgs_0);

	protected override extern void vmethod_2(EventArgs eventArgs_0);

	protected override extern void vmethod_3(MouseEventArgs mouseEventArgs_0);

	protected override extern void vmethod_4(EventArgs eventArgs_0);

	protected override extern void vmethod_5(EventArgs eventArgs_0);

	protected override void vmethod_6(EventArgs eventArgs_0)
	{
		//Discarded unreachable code: IL_0006
		/*Error near IL_0001: Invalid metadata token*/;
	}

	public unsafe GControl3()
	{
		//Discarded unreachable code: IL_000a, IL_0011, IL_0017, IL_0020, IL_0025, IL_0027, IL_002c
		//IL_0004: Expected native int or pointer, but got O
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		*(sbyte*)unchecked((nint)null) = (sbyte)(int)/*Error near IL_0002: ldloc 3 (out-of-bounds)*/;
		/*Error near IL_0005: Invalid metadata token*/;
	}

	protected unsafe override void vmethod_7(PaintEventArgs paintEventArgs_0)
	{
		//Discarded unreachable code: IL_0010
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Invalid comparison between Unknown and I4
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		ushort num2;
		do
		{
			uint num = ((uint[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
			num2 = ((ushort[])checked(/*Error near IL_0004: Stack underflow*/ * num))[6];
		}
		while ((int)/*Error near IL_000b: Stack underflow*/ == num2);
		*(_003F*)(nint)/*Error near IL_000c: Stack underflow*/ = /*Error near IL_000c: Stack underflow*/;
		_ = *(int*)(nint)checked(/*Error near IL_000d: Stack underflow*/ - /*Error near IL_000d: Stack underflow*/);
		/*Error near IL_000f: Unknown opcode: 0xFB*/;
	}

	static extern void lQdAJZQIPbBNxyumcnppaNiaKOvU(Control control_0);

	static extern void BzTLAFXBcuutxierjysjfzrUOPNc(Control control_0, int int_0);

	static extern void KWoyoYgAeXHWnoqqfnLpscDxxdfY(Control control_0, int int_0);

	static extern Delegate FPXNWUwEVkdhiLvsnPNGDaTUeUmi(Delegate delegate_0, Delegate delegate_1);

	static extern Delegate FVfGrVUUwDFWchMdgTQbEIXeHgPHA(Delegate delegate_0, Delegate delegate_1);

	static void pLorFfPChETlyiEzKZbYCPxmOhmS(Control control_0, Color color_0)
	{
		//Discarded unreachable code: IL_0004
		_ = (long)/*Error near IL_0001: Stack underflow*/;
		_ = -97;
		/*Error near IL_0003: Unknown opcode: 0xFF*/;
	}

	static extern void hHBSlXaWpadKcSlIMbLOBUsABsBI(Control control_0, Color color_0);

	static extern int dsFhnTzvypmZHydCibNkTMHLCVeD(Control control_0);

	static extern int TzxEwMxUYljfysFFCBZPkwxAclVF(Control control_0);

	static extern Bitmap IKCRgXHaMKPkfbAvrfjibxTKEHAIA(int int_0, int int_1);

	static extern Graphics HFIJEILuofUTqOdbVNIAxgymhtlf(Image image_0);

	static extern void YVkrBkxpQtKzYHBYEAfTaWYsuuVPA(Graphics graphics_0, SmoothingMode smoothingMode_0);

	static extern void dUIcPtuEDdoEgtszWhruFxwceNtv(Graphics graphics_0, CompositingQuality compositingQuality_0);

	static extern void EGeDsNYemqWNLlrCCbbmCsRuBPMn(Graphics graphics_0, Color color_0);

	unsafe static LinearGradientBrush JXPtURlDZnDNiiLavsCkTfBCiAzVA(Rectangle rectangle_0, Color color_0, Color color_1, float float_0)
	{
		//Discarded unreachable code: IL_001a
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_0014: Incompatible stack heights: 0 vs 3
		while (true)
		{
			byte num = ((byte[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
			if ((int)/*Error near IL_0004: Stack underflow*/ != num)
			{
				break;
			}
			((short[])/*Error near IL_0005: Stack underflow*/)[/*Error near IL_0005: Stack underflow*/] = (short)/*Error near IL_0005: Stack underflow*/;
			checked
			{
				if (/*Error near IL_000a: Stack underflow*/ >= /*Error near IL_000a: Stack underflow*/)
				{
					_ = (long)/*Error near IL_000c: Stack underflow*/;
					_ = uint.MaxValue;
					_ = 527028553;
					break;
				}
			}
		}
		*(_003F*)(nint)/*Error near IL_0019: Stack underflow*/ = /*Error near IL_0019: Stack underflow*/;
		/*Error near IL_0019: Unknown opcode: 0xF8*/;
	}

	static extern void aMVErerJoejAsnWqLGhjByLHAFTeb(Graphics graphics_0, Brush brush_0, GraphicsPath graphicsPath_0);

	unsafe static Pen rEikXExgrmChPCKjvrSLEcPdjaJeb(Color color_0)
	{
		//Discarded unreachable code: IL_000c, IL_0012, IL_0014, IL_001d, IL_0031, IL_0038
		//IL_0018: Invalid comparison between Unknown and F4
		//IL_0029: Expected O, but got F4
		*(int*)(nuint)/*Error near IL_0001: Stack underflow*/ = 527028553;
		/*Error near IL_000b: Unknown opcode: 0xF8*/;
	}

	static extern void FMCESdcfBESPklcIXlqZkLhrhVAZA(Graphics graphics_0, Pen pen_0, GraphicsPath graphicsPath_0);
}
