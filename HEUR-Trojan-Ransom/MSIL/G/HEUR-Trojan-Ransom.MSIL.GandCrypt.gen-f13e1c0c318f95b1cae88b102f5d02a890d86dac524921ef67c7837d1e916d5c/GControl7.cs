using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class GControl7 : Control
{
	public delegate void GDelegate2(object sender);

	private Rectangle rectangle_0;

	private LinearGradientBrush linearGradientBrush_0;

	private Enum0 enum0_0;

	[CompilerGenerated]
	private GDelegate2 gdelegate2_0;

	internal static Struct14 struct14_0/* Not supported: data(70 D6 88 BE 9F 85 9B 63 2A E3 DF 18 80 33 8B 4C 1E DB 31 67 FF B1 62 85 13 BA 07 9F AF 7E 39 DB 5A EC 58 65 7A C9 DE 96 DC BC D1 00 5C 72 87 E6 37 F5 10 F4 3D EA 9D 98 BF 1F 77 7A DF B0 CB 12 52 96 DD BB AD F8 CE 22 5A 03 A3 1D 64 4D 55 69 3A 86 93 66 2D F2 98 E9 1B B2 DE F9 3E CD CE 14 CE 1B E1 3C 82 23 0C C6 79 75 74 F5 90 5A 96 5D BF CA 1B 1C 74 58 43 01 B4 78 38 C4 12 3D 8C 03 3A 20 58 0E 2B CC 40 0B 9E CC FB BB 52 53 A7 BC F9 93 FA A7 D6 80 06 D7 70 7E 6F 12 26 D1 2A 4F E8 DD 44 3A CD 6B 6C A9 2E 67 D0 8F 21 75 B3 07 60 74 E9 82 25 2B BF E4 DB A1 11 3E 8C C6 45 48 C1 94 39 99 76 78 8D 10 99 CC 9D F9 20 5F 75 D5 D4 C5 EC 53 06 7C 19 99 EE 97 BB 80 B1 2C 1D 3D 64 0F 7E 54 EC AA B5 19 F3 D4 B4 F6 76 C5 3F A4 41 9C AF 90 2E B6 D7 2E 08 FD 21 30 05 F4 C6 7B D1 DC 7A 47 4F B3 51 81 71 6D A2 FC 4D 62 D3 8E 60 F1 99 60 FA 94 B6 92 13 28 D9 D7 B0 3F FE CC CC 32 97 6B DE 03 E7 83 DB FB 7C 91 C2 40 A9 40 87 B8 B5 64 79 86 B0 84 38 3E 40 7A 07 E6 5A 94 52 9F 14 52 A4 F6 D4 20 5B 29 28 3C 53 92 E4 F1 71 5E 73 05 16 5F 05 BA 76 5A 7E 06 F5 9E 3E 9C 6A BE B8 87 0B 2D EE FA E4 58 30 89 34 9E 92 C4 E0 04 1B D0 A9 FC 89 2C ED 15 AA 4A E9 8C F9 D6 48 30 C3 8C 15 B6 61 4E 97 6A 43 B2 38 43 A5 D0 F3 67 5F D0 A0 0A 70 9C 82 41 E1 06 F7 51 0A B1 22 57 C5 04 B6 56 87 D4 5C 90 27 78 8B 74 FD 57 C8 CC 02 7F 55 9F 20 20 3F 8A 37 A1 AF 7C 02 5D 3D 40 6B 17 61 AD 51 8B F0 F9 B4 07 F2 31 8E 16 99 A5 DB 09 6B 6B B5 3D E3 D1 A2 CF F8 8D A2 4F 4A A4 C6 AB 8F 43 47 A0 CB 41 78 23 E9 68 EF AD A5 A4 45 EE D1 F7 D6 94 51 A2 1C 70 C9 EF 9A 22 95 A1 FE 16 2E 86 FB 2C 81 ED DB CA BA A7 1F 9D A0 AA 34 AD 1D 25 90 73 06 9D 7A C6 26 2B AE D9 88 B6 AE F3 5B 05 F3 14 F4 85 9B 76 F4 DE 6A 6A 79 24 F8 16 ED A8 DA CA E1 7D 42 3C 07 1F F3 E6 11 75 13 F5 9C B3 29 1E 70 22 66 19 0D 1E 1F 91 2D 39 06 99 C4 07 57 BE 1F 25 58 EF 64 80 75 92 1E 6B A3 EA 55 63 76 A7 F6 91 58 34 18 CB 3D 1A 73 BF 21 85 29 2C 1A 9C 59 7D 94 9C EA 56 D5 F1 97 7C 3D 1D 95 97 AB 98 C5 E7 B6 7F 2E 5B 20 A6 16 29 EC F5 81 F0 35 84 8C 81 CA 6D C2 09 68 2D AB F4 B4 19 E9 E9 8E 3E 7C F9 1F 61 9B B5 48 6B 1F 32 62 A9 FE D4 82 BF B3 B1 01 E7 23 0C BB 29 AE C6 8E 2F F0 92 6B 66 93 90 79 AD 88 54 F3 6E ED EF 81 D6 1D B5 3C DD 14 09 6B F8 BD D4 24 D8 17 33 A5 A8 F1 3E F2 DA 74 A3 D2 A8 BC 4F B2 67 7F B3 72 E8 AC 10 B0 BC 16 7E 13 92 05 60 77 6C CB 5E 79 B4 01 AD 18 F3 D7 AB 85 1A AA 22 3E FB 1C 42 63 C1 CB C1 BC 44 AE 54 FB 1F 2B 67 7B 94 67 DD D3 2B 8E 51 47 0C D6 DB EB 2A 9D F4 79 89 F4 38 86 78 01 FE B6 75 60 84 8C 59 52 6D 20 A2 09 16 B2 50 DA B9 AC F7 15 EE 67 D6 48 D5 D8 06 FF CB 7F 2A 7A A5 F6 2F CB 65 0A 6E 69 E6 5C 6D F0 76 99 05 93 C2 27 90 C4 83 E9 57 12 E6 91 24 EA 34 B3 5F CA 55 BC 07 95 86 6B 59 2A A0 0D 1C 32 CE 87 9A AE 2C 9C F7 32 AB 5F C0 DF BE BD BC 30 DA 5B 90 8C BE 48 57 2C F2 00 7E 8A 1D A8 04 74 6A 0E 44 C0 F6 D5 7B D0 70 83 9E CE 89 D3 33 E3 FA 74 14 74 0C 85 16 F9 B4 9D 7D 77 DB 54 8A 6B 56 85 50 B7 E9 75 31 16 B5 2B 58 B6 E4 8A 64 1E 2A 13 0D 58 4D CA 12 68 D6 17 04 7F 26 42 C2 67 44 D7 45 89 A1 03 9A 56 29 36 A3 2F 59 66 95 FF AF 8E 29 96 2F 41 60 F7 BF 93 54 47 DE 7B 8B A9 9B C2 11 07 8B CE 99 7A C5 03 9B 9D 45 0D ED 3C 57 B6 37 91 F8 8D 48 A8 A1 CE 41 E8 CB CE 17 BE 49 E7 72 A4 B4 89 81 05 7A 51 0F 94 A0 36 F2 E5 47 CF BF B2 20 62 77 06 63 05 5C 6D 3A BD F1 EE 26 EC 27 BA 11 22 FB 40 C9 65 B4 7D 0A CC E2 9E 05 74 05 2C 3E 0F B2 E6 38 36 AF BE 71 6E D9 9A 87 44 82 7F D2 2A CE DA D0 93 CA AD D0 7A DA) */;

	internal static char[] char_0;

	private GControl1.Class11 class11_0;

	public bool Boolean_0
	{
		get; set
		{
			_ = (double)/*Error near IL_0001: Stack underflow*/;
			/*Error: Unexpected end of block*/;
		}
	}

	public extern event GDelegate2 Event_0;

	protected override extern void vmethod_0(EventArgs eventArgs_0);

	protected override extern void vmethod_1(MouseEventArgs mouseEventArgs_0);

	protected override extern void vmethod_2(EventArgs eventArgs_0);

	protected override extern void vmethod_3(MouseEventArgs mouseEventArgs_0);

	protected override extern void vmethod_4(EventArgs eventArgs_0);

	protected override void vmethod_5(EventArgs eventArgs_0)
	{
		//Discarded unreachable code: IL_000b, IL_0010, IL_0017
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		while (/*Error near IL_0005: Stack underflow*/ > /*Error near IL_0005: Stack underflow*/)
		{
		}
		checked
		{
			_ = /*Error near IL_0006: Stack underflow*/- /*Error near IL_0006: Stack underflow*/;
			/*Error near IL_0006: Invalid metadata token*/;
		}
	}

	protected override extern void vmethod_6(EventArgs eventArgs_0);

	protected override extern void vmethod_7();

	private extern void method_0();

	public unsafe GControl7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unsupported input type for neg.
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_0010: Unsupported input type for neg.
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected I4, but got Unknown
		while (true)
		{
			byte num = *(byte*)(nint)(-(/*Error near IL_0001: Stack underflow*/ % /*Error near IL_0001: Stack underflow*/));
			short num3;
			checked
			{
				_003F val = /*Error near IL_0005: Stack underflow*/+ num;
				ushort num2 = ((ushort[])/*Error near IL_0006: Stack underflow*/)[val];
				num3 = (short)((ushort[])((double[])/*Error near IL_0007: Stack underflow*/)[num2])[/*Error near IL_0007: ldloc 1 (out-of-bounds)*/];
			}
			if ((int)/*Error near IL_0010: Stack underflow*/ == num3)
			{
				_003F val2 = 0 - /*Error near IL_0011: Stack underflow*/;
				*(short*)(nuint)checked(/*Error near IL_0012: Stack underflow*/ + val2) = (short)(int)/*Error near IL_0014: ldarg 3 (out-of-bounds)*/;
				if ((int)/*Error near IL_0018: ldloca 0 (out-of-bounds)*/ == 0)
				{
					break;
				}
			}
		}
		_ = *(byte*)(nint)/*Error near IL_0021: Stack underflow*/;
		/*Error near IL_0021: Invalid metadata token*/;
	}

	protected override extern void vmethod_8(PaintEventArgs paintEventArgs_0);
}
