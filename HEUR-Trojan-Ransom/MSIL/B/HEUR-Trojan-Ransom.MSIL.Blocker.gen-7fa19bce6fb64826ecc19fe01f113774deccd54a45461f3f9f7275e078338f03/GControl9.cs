using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

public class GControl9 : TabControl
{
	public struct GStruct0
	{
		public bool bool_0;

		public Point point_0;
	}

	private GStruct0 gstruct0_0;

	private Color color_0;

	private Color color_1;

	private Color color_2;

	private Color color_3;

	internal static Struct10 struct10_0/* Not supported: data(1F F4 4E 18 82 E3 9A 31 EB 70 65 A6 B1 E7 87 A1 E1 60 17 67 09 DD 5B DA D8 3D 64 93 E1 C0 B2 82 90 74 09 7A 89 36 5A BC 9B 24 41 4B 18 52 72 4E 62 9C 4C D5 28 96 C3 A0 58 E4 17 9C 4A DE 11 EF 21 41 0A 56 14 48 56 6F 04 B0 20 E4 BC 97 43 DF E4 50 D2 A4 43 7B 17 18 F9 C2 1F D1 3E 09 6D C0 B7 5B C4 B7 38 3E 15 FA 2A 29 FC 88 39 70 2D 8C 04 AA 07 13 7A B2 7E DE F3 B1 D3 D9 63 17 CD 2C FA 45 C5 93 4E 1D 11 AD F0 63 DB 21 A8 F3 FE 1C 1C 17 8D E2 D3 7F D2 55 6B 7E DA 0E AC FA 28 FE 33 AC 7F F5 1E 4E D0 37 8B 0D B7 C6 06 40 E8 C9 AE CD C2 50 75 44 39 1C 23 AD 8E 17 32 E1 88 6A F3 C5 80 D1 37 8A CC EA D4 66 96 5F 98 60 BA 5A BA 9C 48 20 DF C1 8D 93 86 FA 95 4C 75 E7 E4 3B FE 97 3A 33 01 35 8B 75 E9 AC 72 04 B8 5E A3 07 52 32 7D 8E 93 D3 F4 59 5E F0 49 55 9D 23 44 A8 C4 F1 3B 0F 91 64 87 28 4D 66 51 9D D2 3F 75 98 0D 66 03 5E 9C 80 48 D1 F5 04 51 8A 06 8F A0 79 03 6E F5 70 19 00 46 B3 91 BD 2D 42 1F 29 5E 45 F3 7B 38 CC 1E 35 AF 97 67 DA 05 93 81 63 FF E5 B7 F0 F7 4C E5 0B 42 66 41 D0 0C DB C5 F8 30 D6 7B AF BE 9B 9D EA 03 0F 61 40 0C C8 93 71 5B B7 7D 87 B0 AE 09 DE 01 F1 61 ED E8 7F 92 7D 19 83 4E E7 F3 09 E6 03 6A D5 E6 06 C1 D0 5E FB BA 23 3C 1A B3 8A 0C 02 FD A3 D1 40 C7 18 2E 68 EC 13 D1 61 79 D9 7C AD BF 4C 15 53 C7 05 D7 DB 16 F5 73 07 6B EC 77 6C BD 2E 3E D8 A4 BD 20 E3 D4 C0 F9 F2 AF 47 CD 87 25 13 E8 8A 7C 0E 89 57 76 61 70 C3 6E C8 30 5B B8 E1 D6 25 82 56 01 D0 A7 51 1F E9 34 17 A6 53 7A 8A 57 72 82 43 6F DE D2 32 DD 46 26 2A 84 B6 78 6C 55 A6 60 FB 9B A7 90 FE 8B 7B 6B 85 58 56 E0 50 44 8E 37 4C E0 30 31 9F 14 B3 29 06 84 74 73 1F 0D E1 3D 94 BF 17 62 8F 1F 07 F0 54 A0 02 35 C8 81 EB 3D 81 17 2F 8E 70 29 25 E1 67 36 C5 33 AA 29 38 1B 39 B2 78 4B 3C 46 D7 26 C3 95 58 9B 8E B1 7E F2 89 D4 3D EC DC 0E 89 E4 43 51 0F 2E 5D A2 A2 F9 D1 F4 ED 1D CD AD 3E AB 92 A6 EE F0 05 54 1C F9 BE 87 2B 49 AE 3B 65 9C A5 A4 37 EE E7 DC BF D6 76 FB 34 06 7A 97 E6 E1 00 62 0E 56 CC 2A 47 AD C7 CB CA A7 1A 28 9C 9F 81 6B 49 E9 9A 56 27 B4 0F DC 13 D9 0A 89 99 66 D0 CE A2 AC 43 BB 1A B4 FC A5 5B 04 EC 76 72 57 E3 20 7C A9 25 90 13 91 B4 5E 18 C1 B7 5B 81 9D 3E 0A 64 11 0A FF 07 68 05 89 B0 62 58 66 9D 5A BF 50 31 A4 D8 11 15 6F 4D 39 F7 94 48 9B 8F 21 0E FF A1 67 81 79 7F 6F 3A C2 17 BF 29 71 7D 12 21 13 94 64 63 85 FC 4C F2 4D 7B 7C F5 F4 30 58 7C E3 51 CC 47 CE 3F 23 43 B0 65 1D 96 B5 FC 15 FD 48 1E 5F 16 DD B4 2A 8B B2 E9 50 86 41 8F DC 4B 02 09 22 BF 4E C2 2A 78 6A A2 7A 67 7F 91 CD 5E 53 1F 1F A1 97 F7 08 30 90 4E 37 33 B4 96 13 BA 7F B3 87 85 2C 8B DE 80 CF 5B D8 D3 E1 56 D1 3A 51 DB 1A 54 FF E7 E5 C8 39 C9 0C C4 17 83 97 89 08 24 DD FC 8B 8A E5 B5 75 0B 35 A5 CC F9 88 9C 1C 1E DA DE 61 02 C4 6D 8C B9 F2 70 8E 53 CE F7 04 F8 42 C3 C6 DD 99 BE 8A A2 93 11 3D 6D 8C 78 38 34 D6 91 98 1B A1 06 9B B9 C7 01 49 63 52 C7 FA 3D 98 3A D3 BB A0 F3 85 A5 F0 E2 12 FB 44 DA F9 FA 95 1C AD BD 7F AB 1C 4B AD AE A9 E3 89 35 A8 6F FE 00 1D C1 55 FC D8 D7 4E 4F 0B D6 47 B6 75 AD 91 CF BB 8A 5C 44 FB 1D 82 3F D4 29 0D 05 F1 50 53 78 28 6B 5B 31 28 E9 AB 20 1F C5 00 18 ED E4 51 5A 4D 53 3A E9 B6 AC 68 EC 8B AE 45 73 77 01 B9 3E 5A 59 10 3A A9 EE 09 8D DF CA 02 F4 28 64 4C 0D FB 68 17 82 72 DE 3D 7D EE EE C8 42 0B DD 0E B6 CC 9E 16 6F 12 11 67 5E 80 7E BB 55 FB A9 0D 98 9C 86 F5 26 4F A3 23 2A 9F AB 00 B1 A1 9F 74 7C 9B A8 CB 77 5F E6 C5 CA 55 66 BD 31 17 8C 07 4B D3 1A D2 BF 95 FA F9 BA 97 4D 84 80 17 77 CA F3 4F B8 D1 AC C8 E5 22 9C 14 08 76 93 DC 34 C8 D5 21 CC B0 64 11 CB DE 67 F6 68 BB EE 48 EE 2F BA 74 20 86 B5 38 4A 81 08 31 82 78 6F 4E 32 C2 88 52 37 8D FD C8 C4 B5 F8 35 00 3F BE 6C B3 85 31 1E BE 8C EA BB 92 DE D9 BA D3 31 D1 43 94 83 13 AC 9C 6B A2 9D 0E 99 A5 E8 A9 76 2C 22 07 EB F7 F7 EF 41 F3 53 42 3C 46 5C 34 33 AD 8A 9F 7D C6 BD 15 48 3B 12 48 70 36 A0 22 FA FB C8 6F 40 6F F0 50 47 28 13 78 99 17 28 C9 EC 0E 16 41 3E 51 12 2D 26 E0 8F EE 54 E3 6C 93 31 6A 28 22 A6 35 14 5D FD 30 AA 03 F7 83 49 E8 EE EA 1A 7E 38 04 F7 56 03 79 90 86 2B 74) */;

	internal static int[] int_0;

	private GControl17.Class10 class10_0;

	public extern Color Color_0 { get; set; }

	public extern Color Color_1 { get; set; }

	public Color Color_2
	{
		get
		{
			throw 7;
		}
		set; }

	public Color Color_3
	{
		get
		{
			//Discarded unreachable code: IL_000c, IL_0012, IL_0018, IL_001e, IL_0024
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			long num = ((long[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
			_ = /*Error near IL_0002: Stack underflow*/- num;
			/*Error near IL_0007: Invalid metadata token*/;
		}
		set; }

	public extern Color Color_4 { get; set; }

	public extern Color Color_5 { get; set; }

	public extern Color Color_6 { get; set; }

	public extern Color Color_7 { get; set; }

	public extern Color Color_8 { get; set; }

	public extern GControl9();

	protected override void vmethod_0(EventArgs eventArgs_0)
	{
		//Discarded unreachable code: IL_0010
		//IL_0012: Expected O, but got I4
		while ((nuint)(uint)checked((short)/*Error near IL_0001: Stack underflow*/) <= (nuint)unchecked((nint)null))
		{
		}
		((sbyte[])/*Error near IL_000b: Stack underflow*/)[/*Error near IL_000b: Stack underflow*/] = (sbyte)/*Error near IL_000b: Stack underflow*/;
		_ = ((double[])(object)eventArgs_0)[/*Error near IL_000c: ldloc 2 (out-of-bounds)*/];
		/*Error near IL_000f: Unknown opcode: 0xFF*/;
	}

	protected override extern void vmethod_1(EventArgs eventArgs_0);

	protected override void vmethod_2(MouseEventArgs mouseEventArgs_0)
	{
		//Discarded unreachable code: IL_000c, IL_0016, IL_0018, IL_0025, IL_002d, IL_0033
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		if ((ushort)/*Error near IL_0001: Stack underflow*/ != 0)
		{
			ulong num = (nuint)checked((nint)/*Error near IL_0004: Stack underflow*/);
			_ = /*Error near IL_0007: Stack underflow*/>> (int)num;
		}
		/*Error near IL_0007: Invalid metadata token*/;
	}

	protected override void vmethod_3()
	{
		//Discarded unreachable code: IL_0008, IL_0011, IL_001f
		//IL_000c: Incompatible stack heights: 0 vs 1
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		while (true)
		{
		}
	}

	protected override extern void vmethod_4(PaintEventArgs paintEventArgs_0);

	unsafe static void LThEpZcgaLzdyQHhbqlUHBGdRWEEb(TabControl tabControl_0, TabSizeMode tabSizeMode_0)
	{
		//Discarded unreachable code: IL_0006, IL_000c, IL_000d, IL_0012, IL_0016, IL_001b, IL_0022, IL_0029, IL_0030
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Invalid comparison between Unknown and I4
		//IL_002b: Invalid comparison between Unknown and I4
		_ = *(ushort*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern void ieYRmMaomYwHpDxtWgPBSSwObQtiA(Control control_0, DockStyle dockStyle_0);

	static extern void oiBZPnLIAyGmKJKFggiWXSvnEqFkA(Control control_0);

	static extern TabPageCollection OwuXDTzlugynQIgsFlgOSdekLEsb(TabControl tabControl_0);

	static extern IEnumerator LPwwcXkkrgRpTrflUHfpBMsoWoHDA(TabPageCollection tabPageCollection_0);

	static extern object XSwBfhcxmJBMkaGxJzeQVWlrhoFiA(IEnumerator ienumerator_0);

	static extern Rectangle hONPeKLgiISeVnDXfdtMyoimFYECA(Control control_0);

	static extern Point IpebBbBxrRxOwDJoDvnmjekHGYfOA(MouseEventArgs mouseEventArgs_0);

	static void VJqsgsoUjbHVxzzmnFKFhQGAszBw(Control control_0, Color color_4)
	{
		//Discarded unreachable code: IL_0004
		_ = (long)/*Error near IL_0001: Stack underflow*/;
		_ = -97;
		/*Error near IL_0003: Unknown opcode: 0xFF*/;
	}

	static extern bool uAxyRDkisLWMlfFwPkuceLWddulbA(IEnumerator ienumerator_0);

	static extern void AbRNnCkuChEMwTnzIBAHwyMrOgHy(IDisposable idisposable_0);

	static extern int YDpcdibyyUrKPPTsRCtbYWIEaXGx(Control control_0);

	static extern int FVXRvYLYOIuWCyNrlNNssxOvnTVK(Control control_0);

	static extern Bitmap qEyyvKAMyyPetUscEXdelWjLpmDF(int int_1, int int_2);

	static extern Graphics VmPlQmckPENwaExvisPndbCLzdw(Image image_0);

	static void MReApujdUvACxZpJBaBgjlEtaOOpA(Graphics graphics_0, InterpolationMode interpolationMode_0)
	{
		//Discarded unreachable code: IL_000a, IL_000f, IL_001a
		while (/*Error near IL_0005: Stack underflow*/ < /*Error near IL_0005: Stack underflow*/)
		{
		}
		/*Error near IL_0005: Invalid metadata token*/;
	}

	unsafe static void MDlUsGqIOSHrTfqIUCvqXVHjtsGHA(Graphics graphics_0, TextRenderingHint textRenderingHint_0)
	{
		//Discarded unreachable code: IL_0011, IL_0018, IL_0021, IL_0029, IL_0034
		//IL_0001: Invalid comparison between Unknown and I4
		//IL_0013: Incompatible stack heights: 0 vs 1
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Invalid comparison between Unknown and I4
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		ushort num;
		do
		{
			num = *(ushort*)(nint)/*Error near IL_0001: Stack underflow*/;
		}
		while ((int)/*Error near IL_0006: Stack underflow*/ < (int)num);
		checked
		{
			int num2 = (int)/*Error near IL_0008: Stack underflow*/;
			((int[])/*Error near IL_000a: Stack underflow*/)[/*Error near IL_000a: Stack underflow*/] = num2;
			_ = ~(ushort)/*Error near IL_000b: Stack underflow*/;
			/*Error near IL_000c: Invalid metadata token*/;
		}
	}

	static extern SolidBrush abbqGBEKItVloNVLaqVsXecvDocA(Color color_4);
}
