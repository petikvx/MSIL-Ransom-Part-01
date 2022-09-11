using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class GControl11 : Control
{
	public delegate void GDelegate3(object sender);

	private static bool bool_0;

	[CompilerGenerated]
	private GDelegate3 gdelegate3_0;

	private Color color_0;

	internal static Struct10 struct10_0/* Not supported: data(85 62 70 55 F7 8B 27 9E A1 AC F5 10 AD E9 96 52 34 B0 2D E2 2E CF D4 65 BB 34 01 13 00 84 E7 A4 03 7F 32 11 56 57 A9 D9 66 B1 CA 32 58 1E 5A 84 44 9E 21 9F 2A 83 29 66 B8 D0 F1 7C C7 65 E0 CA F2 00 95 AA B3 27 D5 78 CA 55 79 32 21 F0 9A A2 2F 3C 5A 3C 09 12 B2 A7 2D 32 D0 A1 90 3B B7 AA 39 BD 2B 6C FF E4 8D D9 A8 8C 9E B3 08 6D B2 C5 EC 54 92 A1 49 D8 2E 26 78 69 37 69 75 24 3A 58 8B 6F 38 B1 88 93 B9 21 8F B8 50 99 05 33 1B CF 66 33 B6 19 5A 71 93 23 5C BA BA 72 E3 C0 12 7A AE FD 87 B3 51 CE 34 B5 D8 DF 9B BF EF 5F 22 C4 40 73 B1 54 E7 10 C8 67 2E 98 EF FA 90 ED 32 85 BF ED 5F 7A 1D 06 E5 4A 80 F5 6B D7 B6 D9 69 3C F9 AC 33 3B C8 EE 7D 93 D6 95 0C D4 77 CF B2 52 C5 FF EA 11 A7 9A A8 85 A0 17 40 FA 8E 6D 61 F6 C0 15 99 86 E4 B1 EC 9C 99 18 B6 1F 27 30 FE 39 5B D7 AB 82 D5 62 CD C3 ED F2 9F 98 F8 7C B9 62 AA 42 67 EA 17 BC EF 2F E9 6A 5E C9 3B B8 A7 39 AE 43 A3 64 DE E8 77 EA F6 D0 2D 1E D1 95 1F 47 FD 92 AA 01 0A 5F 94 DA C9 37 49 14 A0 0F D0 A7 C7 B9 CF BC 41 A5 7B 3D 90 0C 47 0A 1B 53 3E EC B2 09 13 7C BD 3B 6C 10 22 CF B7 E1 E2 C0 9C C2 8F AE 46 7D 0A C4 EA 85 F2 05 91 A7 2B B6 77 1C 2F 81 BB E6 6B 1B 39 31 23 59 00 2F A6 96 0B AB 49 DB 01 20 79 75 6A 21 40 9C B5 5A 00 E9 AB A1 31 05 1D 64 77 A6 3A D5 7C BD DD 9D 18 FE 23 C8 EF 73 F6 6B CA D6 C7 5B 32 5A 4A 4F 2E 0D 0B 10 A0 D9 77 B3 3E 41 42 53 E8 BE 28 A0 37 FB AA 0E 72 B0 B0 CC 8E DE B6 DE D2 EA 28 5E 0D 1C F6 6D A9 61 73 ED 4E B6 DF 0D 42 D3 3A AB 54 68 56 B2 F3 5E 63 7A CE 7A 4B AC 51 C0 B8 85 02 EF 64 DD 98 06 D9 9C 25 80 15 81 FC E8 9D 89 2E 6B 03 24 C0 40 5F D5 AB EE 4B A5 79 2D AA 0E CF DD 5F 75 20 4A 79 A3 19 95 14 6C 7C CA B5 5C 0C 83 57 F0 90 CF 2E F3 5D D8 06 86 0C A0 CD CC 4A B3 73 B1 77 98 ED 68 4C D2 70 7E F1 CD 72 3C D4 31 DA 99 F5 6C 63 03 1A 90 A5 B4 07 DD 4E D9 1E 72 B7 9E D0 4B 09 44 D7 CC 0D 10 A8 4F C7 28 5E F4 CD 7C 21 AD C5 D9 3C C9 0E 07 E6 11 F4 D6 9D C4 A2 67 72 FA 10 9B 17 F8 33 31 D1 EC 6A A3 E7 5B 23 1F CC 70 07 12 52 9B CE D2 42 28 B7 AC 87 ED 02 6F D1 A0 C9 CC E7 C6 E0 EE 19 EA 0C 8C 63 F1 86 BE C7 87 13 30 42 97 7F B7 1F 08 69 C9 17 F2 F2 82 F2 D2 9C 26 F0 3C 33 24 52 86 FA 0B D0 96 7E 3C D6 3B EF E6 95 10 AD 7A 0E DF BF D4 DC 30 77 32 96 B9 5E 1F 92 1E 2E A0 56 B8 1D B5 CE F3 11 AC 42 FF AF 93 41 85 7D 06 08 43 76 09 E6 8C 55 C7 73 CF E6 9F 3A 55 FE 4E 96 30 66 65) */;

	internal static char[] char_0;

	private GControl17.Class15 class15_0;

	public bool Boolean_0
	{
		get
		{
			//Discarded unreachable code: IL_0005, IL_000d, IL_000f, IL_0014, IL_0019, IL_0022, IL_0029
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			_ = (int)checked((ushort)(/*Error near IL_0002: Stack underflow*/ & /*Error near IL_0002: Stack underflow*/));
			/*Error near IL_0004: Unknown opcode: 0xFA*/;
		}
		set; }

	public extern Color Color_0 { get; set; }

	public unsafe Color Color_1
	{
		get; set
		{
			uint num = ((uint[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
			*(IntPtr*)(nint)/*Error near IL_0002: Stack underflow*/ = (IntPtr)(int)num;
			/*Error: Unexpected end of block*/;
		}
	}

	public unsafe event GDelegate3 Event_0
	{
		[CompilerGenerated]
		add
		{
			//Discarded unreachable code: IL_0012, IL_0018, IL_001e
			//IL_0005: Expected I4, but got Unknown
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Expected I4, but got Unknown
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
			((IntPtr[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = (IntPtr)1;
			_003F val = /*Error near IL_0003: Stack underflow*/;
			*(int*)(nint)/*Error near IL_0005: Stack underflow*/ = (int)val;
			_003F val2 = /*Error near IL_0007: Stack underflow*/* /*Error near IL_0007: Stack underflow*/;
			((sbyte[])/*Error near IL_0009: Stack underflow*/)[/*Error near IL_0009: Stack underflow*/] = (sbyte)(int)val2;
			checked
			{
				_ = (byte)(nint)((IntPtr[])/*Error near IL_000a: Stack underflow*/)[/*Error near IL_000a: Stack underflow*/];
				/*Error near IL_000d: Invalid metadata token*/;
			}
		}
		[CompilerGenerated]
		remove;
	}

	public GControl11()
	{
		//Discarded unreachable code: IL_0024, IL_002a, IL_0032
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and F8
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			if ((int)/*Error near IL_0005: Stack underflow*/ != 0)
			{
				continue;
			}
			IntPtr intPtr = ((IntPtr[])/*Error near IL_0006: Stack underflow*/)[/*Error near IL_0006: Stack underflow*/];
			checked
			{
				_003F val = /*Error near IL_0007: Stack underflow*/- unchecked((nint)intPtr);
				if (/*Error near IL_000c: Stack underflow*/ == val)
				{
					double num = (double)/*Error near IL_000d: Stack underflow*/;
					if (!((double)/*Error near IL_0013: Stack underflow*/ >= num))
					{
						break;
					}
				}
			}
		}
		_003F val2 = /*Error near IL_0014: Stack underflow*/| /*Error near IL_0014: Stack underflow*/;
		_ = (double)(/*Error near IL_0015: Stack underflow*/ & val2);
		_ = -4.368716106873229E-152;
		/*Error near IL_001f: Invalid metadata token*/;
	}

	protected override extern void vmethod_0(PaintEventArgs paintEventArgs_0);

	protected unsafe override void vmethod_1(EventArgs eventArgs_0)
	{
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		/*Error: Unexpected end of block*/;
	}

	protected override extern void vmethod_2(EventArgs eventArgs_0);

	static extern Delegate ictCcjHWDlbZOtUbsAOlgodKTnEqc(Delegate delegate_0, Delegate delegate_1);

	static extern Delegate IqHWaiBnODQbxRqadgRPqdJwyCre(Delegate delegate_0, Delegate delegate_1);

	static extern void tXnVZazMlGiZRoOwiHhlwvMeweib(Control control_0);

	static extern Cursor lELSdwUjHBuLBGYjCUuidkLbsVAN();

	static extern void qflhcoJvZHbhrHtIBQjTkLpevIHYA(Control control_0, Cursor cursor_0);

	static extern int fphCDGOszkSfNNWdEoQRSlKfcqJCA(Control control_0);

	static extern int QxNodydoLxyYaImwbPDlvXZrZQri(Control control_0);

	static extern Bitmap LCApTmcLeSsikSmpCXtILVTUUBF(int int_0, int int_1);

	static extern Graphics qrnxPYceaRKfoipIcWQiefoMgpFR(Image image_0);

	static void tZgWORGnGlICtOVsbUnqBETANcRG(Graphics graphics_0, TextRenderingHint textRenderingHint_0)
	{
		//Discarded unreachable code: IL_0009, IL_0011, IL_0018, IL_001e, IL_002a, IL_0031
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and F4
		//IL_0022: Expected I, but got F8
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected I4, but got Unknown
		//IL_0039: Invalid comparison between Unknown and I4
		long num = ((long[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		checked
		{
			_ = /*Error near IL_0003: Stack underflow*/* num;
			/*Error near IL_0004: Invalid metadata token*/;
		}
	}

	unsafe static void duaGfxYvsFuDhZNhtwdYkVCtUPyL(Graphics graphics_0, SmoothingMode smoothingMode_0)
	{
		//Discarded unreachable code: IL_001f, IL_0026, IL_002d
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected I4, but got Unknown
		//IL_0019: Expected I4, but got I8
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		while (/*Error near IL_0006: Stack underflow*/ < /*Error near IL_0006: Stack underflow*/)
		{
		}
		long num = (long)/*Error near IL_0007: Stack underflow*/;
		long num2 = ((ushort[])/*Error near IL_0008: Stack underflow*/)[num];
		_003F val = /*Error near IL_000a: Stack underflow*/* num2;
		((int[])/*Error near IL_000b: Stack underflow*/)[/*Error near IL_000b: Stack underflow*/] = (int)val;
		*(_003F*)(nint)/*Error near IL_000d: Stack underflow*/ = /*Error near IL_000d: Stack underflow*/;
		((int[])/*Error near IL_0019: Stack underflow*/)[/*Error near IL_0019: Stack underflow*/] = 0;
		/*Error near IL_001a: Invalid metadata token*/;
	}

	static void nGzKRMVBrUEAszZzxPQaxIXmgNY(Control control_0, int int_0)
	{
		//Discarded unreachable code: IL_0005, IL_000a, IL_000b, IL_0013, IL_001c, IL_0022, IL_0028, IL_002f, IL_0034, IL_003b
		//IL_002a: Expected native int or pointer, but got F4
		//IL_0036: Invalid comparison between Unknown and I4
		while (true)
		{
		}
	}
}
