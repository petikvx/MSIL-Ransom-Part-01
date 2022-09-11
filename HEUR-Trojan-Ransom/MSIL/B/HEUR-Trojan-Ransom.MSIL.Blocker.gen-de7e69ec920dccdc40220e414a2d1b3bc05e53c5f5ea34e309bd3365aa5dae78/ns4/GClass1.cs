using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Markup;
using ns5;
using ns8;
using ns9;

namespace ns4;

public class GClass1 : Window, IComponentConnector
{
	[CompilerGenerated]
	private static int[] int_0;

	private static bool _contentLoaded;

	internal static Struct1 struct1_0/* Not supported: data(DA 8C F1 1B EA 61 72 59 D7 5E C4 AA DA 66 CC 9E 3D 83 FE 99 99 1D 41 E4 2E 07 D4 45 A9 45 2B 36 E9 0A D5 68 5A 86 C7 2A 4E B5 08 4F 22 B3 A2 51 E7 44 CB 37 44 28 9C BC 4A 0C EB E2 8B 2D AF 91 32 8D C0 D0 8F 64 43 B6 BA D4 4B E3 15 F1 C2 79 64 83 5D 64 78 F3 F1 C0 6D 19 1D 4E 99 E4 9D 21 05 75 1C 93 F2 D0 C0 82 00 15 7B 6F DC B8 A7 58 49 71 7E 08 CE 4A 19 3D 9B FE 63 76 46 F4 1D D5 36 29 DD 9F D4 2E 86 92 C1 D9 64 63 77 81 E3 B3 70 C4 04 27 66 95 51 BA 5C DD F7 F2 6C 49 3C 0A F7 A5 38 B2 D9 07 82 1A EA EA 45 F3 E5 B4 C5 19 1B AE 05 81 EF F4 6F A0 D6 23 42 F5 35 93 25 78 9D 5A 6A D1 49 30 D9 69 42 E9 3C 7A 4F 5D D3 A6 18 DD D7 BD 43 B9 19 02 36 97 DB B6 C4 8B E3 57 C4 CC 56 8A 4A F3 CF EA D4 9B 3E 06 B8 F3 50 79 4E 9A DD 57 BA 67 35 E2 40 67 9A B0 54 22 A3 B6 05 E3 B5 82 06 49 5C 24 0E EB E7 A6 7A 13 49 42 46 61 68 29 AC 8C 9B 5C 97 72 4A E1 58 1E 95 B2 F6 87 01 D3 3D CD 73 05 3E B8 48 CD 7F 8D 67 2D 1E 58 6A F1 B8 7A 09 77 48 59 EA 93 FD 79 CA EE 55 34 AF F2 11 74 04 77 ED 63 E9 F2 44 CC DB 09 0A 1D C3 00 B3 A3 F9 7C 7E 89 8B E3 E2 DE 06 C3 ED 58 78 4A DD 74 1B A8 53 F1 04 54 8F 15 33 7A 7C E0 88 DF B5 CA 3B B1 3A 32 73 87 E8 1F 94 0E 5D 26 05 EA 54 90 2B 95 02 1A AB C1 9F A4 EB 69 56 10 67 01 56 25 0D 22 1D C5 10 AA 01 93 BF 33 5C F4 F6 69 0F 47 26 EA B4 F1 DD 9A 1F 79 12 95 46 09 30 D7 B7 92 B6 37 18 E2 CC 8E 80 80 93 6D 5A 77 64 A9 AC 81 5A 0E E9 7C 4C 63 47 72 03 A3 B2 7A 63 F6 62 E7 7B C8 3D BF 51 2B 7A 97 69 34 5D 6F 40 A6 15 67 E7 C4) */;

	internal static byte[] byte_0;

	internal static int[] Int32_0
	{
		[CompilerGenerated]
		get
		{
			int num = 0;
			do
			{
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 1);
			return int_0;
		}
		[CompilerGenerated]
		set
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					int_0 = value;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}
	}

	public GClass1()
	{
		p_00243K6eD_X8();
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public static void p_00243K6eD_X8()
	{
		byte[] array = byte_0;
		int num = 11;
		while (true)
		{
			int num2 = 0;
			num = 7;
			while (true)
			{
				num = 4;
				while (true)
				{
					if (num2 == 3)
					{
						switch (array[334])
						{
						case 220:
							break;
						case 219:
							_contentLoaded = true;
							num2 = 4;
							num = 15;
							goto IL_0083;
						case 231:
							goto IL_0083;
						case 216:
							goto IL_00ad;
						case 221:
						case 224:
							goto IL_00ba;
						case 228:
							goto IL_00c3;
						case 230:
							goto IL_00cd;
						case 226:
							goto IL_00d7;
						case 232:
							goto IL_00e0;
						case 225:
							goto IL_00ea;
						case 223:
							goto end_IL_006b;
						default:
							goto end_IL_00f2;
						case 229:
							goto IL_0106;
						case 217:
						case 218:
							return;
						}
						continue;
					}
					num = 15;
					goto IL_0083;
					IL_00e0:
					num2 = 1;
					num = 9;
					goto IL_00ea;
					IL_00cd:
					num2 = 3;
					num = 10;
					goto IL_00d7;
					IL_0083:
					int num3 = num2;
					Class9.byte_0[493] = (byte)((Class9.byte_0[493] | Class9.byte_0[55]) & 0x7E);
					if (num3 == 1)
					{
						num = 0;
						goto IL_00ad;
					}
					num = 8;
					goto IL_00ba;
					IL_0106:
					num = 1;
					return;
					IL_00ad:
					Class3.smethod_0();
					num2 = 2;
					num = 8;
					goto IL_00ba;
					IL_00ea:
					if (num2 != 4)
					{
						num = 7;
						break;
					}
					num = 13;
					goto IL_0106;
					IL_00ba:
					if (num2 == 2)
					{
						num = 12;
						goto IL_00c3;
					}
					num = 10;
					goto IL_00d7;
					IL_00d7:
					if (num2 == 0)
					{
						num = 16;
						goto IL_00e0;
					}
					num = 9;
					goto IL_00ea;
					IL_00c3:
					if (!_contentLoaded)
					{
						num = 14;
						goto IL_00cd;
					}
					num = 1;
					return;
					continue;
					end_IL_006b:
					break;
				}
				continue;
				end_IL_00f2:
				break;
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num = 0;
		int num2;
		do
		{
			if (num == 1)
			{
				_contentLoaded = true;
				num = 2;
			}
			if (num == 0)
			{
				num = 1;
			}
			num2 = num;
			byte_0[79] = (byte)(byte_0[79] & Class9.byte_0[383] & 0x2A);
		}
		while (num2 != 2);
	}

	void IComponentConnector.InitializeComponent()
	{
		int num = 0;
		do
		{
			if (num == 1)
			{
				p_00243K6eD_X8();
				num = 2;
			}
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 2);
	}
}
