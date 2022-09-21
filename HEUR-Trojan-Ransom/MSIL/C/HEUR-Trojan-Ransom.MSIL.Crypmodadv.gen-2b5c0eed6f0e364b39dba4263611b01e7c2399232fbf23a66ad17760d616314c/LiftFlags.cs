using System.Reflection;
using System.Runtime.InteropServices;

internal class LiftFlags
{
	[DllImport("kernel32.dll", EntryPoint = "VirtualProtect")]
	internal unsafe static extern bool _033a78c7(byte* P_0, int P_1, uint P_2, ref uint P_3);

	internal unsafe static void f2f0cdbe()
	{
		//Discarded unreachable code: IL_04bc
		Module module = _003CModule_003E._5_009F_00B9_008Eó(_003CModule_003E._0013X_0013w_009B(typeof(LiftFlags).TypeHandle));
		byte* ptr4 = default(byte*);
		int num4 = default(int);
		byte* ptr2 = default(byte*);
		uint[] array2 = default(uint[]);
		int num24 = default(int);
		uint num37 = default(uint);
		byte* ptr10 = default(byte*);
		uint num7 = default(uint);
		byte* ptr13 = default(byte*);
		byte* ptr6 = default(byte*);
		uint num41 = default(uint);
		uint num12 = default(uint);
		int num20 = default(int);
		byte* ptr12 = default(byte*);
		byte* ptr7 = default(byte*);
		byte* ptr = default(byte*);
		byte* ptr5 = default(byte*);
		int num43 = default(int);
		ushort num18 = default(ushort);
		byte* ptr8 = default(byte*);
		int num21 = default(int);
		byte* ptr3 = default(byte*);
		int num10 = default(int);
		int num8 = default(int);
		uint num5 = default(uint);
		int num15 = default(int);
		uint[] array = default(uint[]);
		int num13 = default(int);
		int num42 = default(int);
		ushort num53 = default(ushort);
		uint num33 = default(uint);
		int num32 = default(int);
		uint[] array3 = default(uint[]);
		byte* ptr11 = default(byte*);
		byte* ptr9 = default(byte*);
		int num3 = default(int);
		uint num28 = default(uint);
		int num9 = default(int);
		ushort num39 = default(ushort);
		ushort num16 = default(ushort);
		int num29 = default(int);
		int num27 = default(int);
		int num14 = default(int);
		while (true)
		{
			int num = -318943973;
			while (true)
			{
				int num2;
				switch ((uint)(num2 = _003CModule_003E._099c0215(num)) % 220u)
				{
				case 3u:
					break;
				default:
					return;
				case 191u:
					ptr4[10] = 0;
					num = (num2 * -355306534) ^ -1124245492;
					continue;
				case 82u:
					num = (num2 * -663123703) ^ 0x9E9AB0F;
					continue;
				case 174u:
					num4 = 0;
					num = (num2 * -1917236333) ^ -1289016102;
					continue;
				case 60u:
					*ptr2 = 0;
					num = 43294836;
					continue;
				case 111u:
				{
					int num38;
					if (array2[num24] <= num37)
					{
						num = 218446999;
						num38 = num;
					}
					else
					{
						num = 468193565;
						num38 = num;
					}
					continue;
				}
				case 210u:
					num = (num2 * -304983269) ^ -919819773;
					continue;
				case 96u:
					_033a78c7(ptr10, 11, 64u, ref num7);
					num = (num2 * -2022924598) ^ 0x1444E863;
					continue;
				case 94u:
					ptr2++;
					num = (num2 * -2089553140) ^ -787871047;
					continue;
				case 165u:
					ptr13 = ptr6 + num41;
					num = 1171069767;
					continue;
				case 61u:
					num = (num2 * -1402950811) ^ 0x6EF43D7B;
					continue;
				case 132u:
					(ptr6 + num12)[num20] = ptr4[num20];
					num = -1354196636;
					continue;
				case 152u:
					*(int*)(ptr12 + (nint)3 * (nint)4) = 0;
					num = (num2 * 202127286) ^ 0x4E92F945;
					continue;
				case 156u:
					return;
				case 167u:
				{
					int num48;
					int num49;
					if (num41 != 0)
					{
						num48 = 1921153032;
						num49 = num48;
					}
					else
					{
						num48 = 940814846;
						num49 = num48;
					}
					num = num48 ^ (num2 * -1050896931);
					continue;
				}
				case 173u:
					num = (num2 * -1026640464) ^ 0x2F0FA728;
					continue;
				case 46u:
					ptr7 = ptr6 + (uint)(*(int*)(ptr - 120));
					num = (num2 * -621903746) ^ 0x3B06A6E9;
					continue;
				case 142u:
				{
					int num25;
					if (num20 >= 11)
					{
						num = 1652993216;
						num25 = num;
					}
					else
					{
						num = -750154894;
						num25 = num;
					}
					continue;
				}
				case 182u:
					num20++;
					num = (num2 * -1516110708) ^ 0x1D79B13C;
					continue;
				case 66u:
					num = (num2 * -1172851308) ^ -619506648;
					continue;
				case 138u:
					ptr2 += 2;
					num = (num2 * -974960167) ^ -662345079;
					continue;
				case 101u:
					ptr = ptr6 + 60;
					num = (num2 * 374888337) ^ 0x1A3E18A6;
					continue;
				case 93u:
					num = (num2 * 1628740731) ^ -358267280;
					continue;
				case 212u:
					*ptr5 = 0;
					num = (num2 * -2026829567) ^ -1450774479;
					continue;
				case 5u:
				{
					int num78;
					if (num43 >= num18)
					{
						num = 840138460;
						num78 = num;
					}
					else
					{
						num = 1377390762;
						num78 = num;
					}
					continue;
				}
				case 200u:
					*(short*)(ptr4 + (nint)4 * (nint)2) = 108;
					num = (num2 * -901416013) ^ 0x455827BC;
					continue;
				case 126u:
					ptr5++;
					num = (num2 * -1704443832) ^ 0x48ED9830;
					continue;
				case 68u:
					ptr8[num21] = ptr4[num21];
					num = -545528681;
					continue;
				case 6u:
				{
					int num72;
					int num73;
					if (*ptr2 == 0)
					{
						num72 = -1321999426;
						num73 = num72;
					}
					else
					{
						num72 = 794321196;
						num73 = num72;
					}
					num = num72 ^ (num2 * 12950443);
					continue;
				}
				case 75u:
					ptr5 += 4;
					num = (num2 * 200625073) ^ -1766084856;
					continue;
				case 181u:
					*(int*)ptr2 = 0;
					num = (num2 * 424252339) ^ 0x4521FE6F;
					continue;
				case 10u:
					_033a78c7(ptr, 8, 64u, ref num7);
					num = -1503158923;
					continue;
				case 52u:
					_033a78c7(ptr, 8, 64u, ref num7);
					num = -1167709696;
					continue;
				case 124u:
					*(int*)(ptr3 + (nint)3 * (nint)4) = 0;
					num = (num2 * 592684320) ^ 0x4B5C5BF5;
					continue;
				case 202u:
					_033a78c7(ptr3, 72, 64u, ref num7);
					num = (num2 * -578132127) ^ -2030300564;
					continue;
				case 102u:
					*(int*)ptr3 = 0;
					num = (num2 * -1111775317) ^ -1633732279;
					continue;
				case 176u:
					num10++;
					num = (num2 * 1539744314) ^ 0x39DFCFE1;
					continue;
				case 140u:
					ptr5++;
					num = (num2 * 1401644691) ^ -9864248;
					continue;
				case 155u:
					num8++;
					num = (num2 * -1343653060) ^ 0x7CECFAA1;
					continue;
				case 158u:
					_033a78c7(ptr6 + num5, 11, 64u, ref num7);
					num = (num2 * 1778387279) ^ -1148579311;
					continue;
				case 162u:
					num15++;
					num = -640368254;
					continue;
				case 38u:
					ptr4[10] = 0;
					num = (num2 * 1029980321) ^ 0x6D3FA6C4;
					continue;
				case 53u:
				{
					int num60;
					int num61;
					if (num37 < array2[num24] + array[num24])
					{
						num60 = 787848408;
						num61 = num60;
					}
					else
					{
						num60 = 166102347;
						num61 = num60;
					}
					num = num60 ^ (num2 * 843425814);
					continue;
				}
				case 122u:
					num20 = 0;
					num = (num2 * 963637225) ^ 0x29737089;
					continue;
				case 180u:
				{
					int num56;
					if (num13 < num18)
					{
						num = -763698122;
						num56 = num;
					}
					else
					{
						num = 1194196418;
						num56 = num;
					}
					continue;
				}
				case 11u:
					num42++;
					num = -449777446;
					continue;
				case 137u:
					num53 = *(ushort*)ptr;
					num = (num2 * 770047897) ^ -1513153200;
					continue;
				case 0u:
					num33 = num33 - array2[num32] + array3[num32];
					num = (num2 * -1538466582) ^ -218767837;
					continue;
				case 215u:
					num32 = 0;
					num = 1577654596;
					continue;
				case 67u:
					ptr += 40;
					num43++;
					num = (num2 * -1212578781) ^ -644550634;
					continue;
				case 99u:
					*ptr2 = 0;
					num = 1035798207;
					continue;
				case 153u:
				{
					int num45;
					int num46;
					if (*ptr5 == 0)
					{
						num45 = 1635498206;
						num46 = num45;
					}
					else
					{
						num45 = -947105418;
						num46 = num45;
					}
					num = num45 ^ (num2 * 581462013);
					continue;
				}
				case 69u:
					num43 = 0;
					num = 1024676217;
					continue;
				case 48u:
					num41 = num41 - array2[num42] + array3[num42];
					num = (num2 * 328732618) ^ -512390225;
					continue;
				case 106u:
					array3 = new uint[num18];
					num = (num2 * 782217045) ^ 0x72E8F397;
					continue;
				case 190u:
				{
					int num34;
					if (array2[num32] <= num33)
					{
						num = -511829193;
						num34 = num;
					}
					else
					{
						num = 1086826409;
						num34 = num;
					}
					continue;
				}
				case 193u:
					array2 = new uint[num18];
					num = (num2 * -1231277838) ^ -957852631;
					continue;
				case 64u:
					num5 = *(uint*)ptr11 + 2;
					num = -904153060;
					continue;
				case 37u:
					ptr8 = ptr6 + (uint)(*(int*)(ptr7 + 12));
					ptr10 = ptr6 + (uint)(*(int*)ptr9) + 2;
					_033a78c7(ptr8, 11, 64u, ref num7);
					num = (num2 * -1415726615) ^ 0xDE3038E;
					continue;
				case 141u:
					ptr2++;
					num = (num2 * 626461219) ^ -1865981972;
					continue;
				case 179u:
					num24 = 0;
					num = (num2 * -247179685) ^ 0x47A57B6D;
					continue;
				case 22u:
					_003CModule_003E._0018_003EIg_007E(new byte[8], 0, _003CModule_003E._0087ÀËÏ_0027(ptr), 8);
					num = (num2 * 1594189606) ^ 0x51EA7A41;
					continue;
				case 166u:
				{
					int num19;
					if (num3 < num18)
					{
						num = -1350784080;
						num19 = num;
					}
					else
					{
						num = 1972063361;
						num19 = num;
					}
					continue;
				}
				case 29u:
					num12 = num12 - array2[num13] + array3[num13];
					num = (num2 * 150640610) ^ -528627706;
					continue;
				case 171u:
					*(int*)(ptr4 + 4) = 1852404846;
					num = (num2 * -1238145822) ^ -1474574623;
					continue;
				case 117u:
					num = (num2 * -254782923) ^ 0x1F3D026F;
					continue;
				case 168u:
				{
					int num81;
					if (num4 >= num18)
					{
						num = 827542321;
						num81 = num;
					}
					else
					{
						num = -1162898977;
						num81 = num;
					}
					continue;
				}
				case 144u:
					num28 = *(uint*)(ptr12 + 8);
					num = (num2 * -1096858798) ^ -1312661014;
					continue;
				case 189u:
					num = (num2 * -1453023188) ^ 0x5009A818;
					continue;
				case 84u:
					ptr12 = ptr6 + num33;
					num = -1779944112;
					continue;
				case 45u:
					ptr += 14;
					num = (num2 * -586897297) ^ 0x3150C994;
					continue;
				case 28u:
					num41 = *(uint*)(ptr - 120);
					num = (num2 * -1556411436) ^ -1793373229;
					continue;
				case 107u:
					ptr2 = ptr6 + num28;
					num = (num2 * 345609375) ^ -1689342955;
					continue;
				case 9u:
					num13 = 0;
					num = (num2 * 1961954754) ^ 0x421AC607;
					continue;
				case 146u:
				{
					int num80;
					if (num9 >= 8)
					{
						num = -1216884823;
						num80 = num;
					}
					else
					{
						num = 1670820091;
						num80 = num;
					}
					continue;
				}
				case 133u:
					*(int*)ptr4 = 1866691662;
					num = (num2 * -482455758) ^ 0x53D892B2;
					continue;
				case 89u:
					num42 = 0;
					num = (num2 * -1102701218) ^ 0x5228E1D3;
					continue;
				case 164u:
					ptr3 = ptr6 + (uint)(*(int*)(ptr - 16));
					num = (num2 * 1562420097) ^ -1848855255;
					continue;
				case 90u:
					*(int*)(ptr3 + (nint)2 * (nint)4) = 0;
					num = (num2 * -1153940548) ^ 0x3520D126;
					continue;
				case 63u:
					num24++;
					num = 1385392544;
					continue;
				case 104u:
					num39 = *ptr5;
					num = (num2 * 637571428) ^ -1506228570;
					continue;
				case 217u:
					*(int*)ptr4 = 1818522734;
					num = (num2 * 1543073535) ^ -758564679;
					continue;
				case 128u:
				{
					int num79;
					if (num42 >= num18)
					{
						num = 2053711383;
						num79 = num;
					}
					else
					{
						num = -2067736132;
						num79 = num;
					}
					continue;
				}
				case 163u:
					num3++;
					num = (num2 * -1470653721) ^ 0x6794EDAD;
					continue;
				case 21u:
					ptr11 = ptr6 + num37;
					num = -1862104656;
					continue;
				case 25u:
					ptr = ptr6 + (uint)(*(int*)ptr);
					num = (num2 * -2111611165) ^ 0x129C085B;
					continue;
				case 72u:
					num10 = 0;
					num = (num2 * 1495657157) ^ -634693238;
					continue;
				case 125u:
					*(int*)ptr4 = 1866691662;
					num = (num2 * 1354128044) ^ -625389707;
					continue;
				case 39u:
					_033a78c7(ptr5, 4, 64u, ref num7);
					num = (num2 * -1088418392) ^ -14873165;
					continue;
				case 204u:
					num = (num2 * 769336956) ^ -457683359;
					continue;
				case 213u:
				{
					int num77;
					if (num21 >= 11)
					{
						num = 650895154;
						num77 = num;
					}
					else
					{
						num = 1450751286;
						num77 = num;
					}
					continue;
				}
				case 201u:
					ptr2++;
					num = (num2 * 1352670466) ^ -37901234;
					continue;
				case 74u:
					num12 = *(uint*)(ptr13 + 12);
					num = (num2 * -1723473361) ^ -1702830495;
					continue;
				case 33u:
					*(int*)ptr4 = 1818522734;
					num = (num2 * 212536214) ^ -81309709;
					continue;
				case 112u:
					num = (num2 * 504247729) ^ -847299491;
					continue;
				case 150u:
					ptr2++;
					num = (num2 * -1359811774) ^ 0x75880ABD;
					continue;
				case 145u:
				{
					int num75;
					int num76;
					if (num33 >= array2[num32] + array[num32])
					{
						num75 = 347343145;
						num76 = num75;
					}
					else
					{
						num75 = -107743098;
						num76 = num75;
					}
					num = num75 ^ (num2 * 617197184);
					continue;
				}
				case 127u:
					_003CModule_003E._002DÞ6ä_0023(new byte[8], 0, _003CModule_003E._0021_001EoÕþ(ptr), 8);
					num = (num2 * -1287318431) ^ 0x23E4DAEC;
					continue;
				case 27u:
				{
					int num74;
					if (num8 >= 11)
					{
						num = 762075117;
						num74 = num;
					}
					else
					{
						num = -2008673981;
						num74 = num;
					}
					continue;
				}
				case 157u:
					_033a78c7(ptr5, 4, 64u, ref num7);
					num = 561367846;
					continue;
				case 114u:
					ptr10[num10] = ptr4[num10];
					num = 1558175266;
					continue;
				case 35u:
					num16 = *ptr2;
					num = (num2 * 1993002544) ^ 0x24944F2F;
					continue;
				case 120u:
					ptr2 += 2;
					num = (num2 * -2049387841) ^ 0x2297E689;
					continue;
				case 199u:
					num = (num2 * 422723895) ^ -44902199;
					continue;
				case 110u:
					num = (num2 * 302216899) ^ 0x7D06AA82;
					continue;
				case 147u:
					num = (num2 * -1555369050) ^ -403694728;
					continue;
				case 71u:
					num18 = *(ushort*)ptr;
					num = (num2 * 54239279) ^ -756613694;
					continue;
				case 85u:
					num37 = *(uint*)ptr13;
					num = (num2 * -1982318861) ^ -1422783470;
					continue;
				case 205u:
					ptr += 40;
					num = (num2 * 115455036) ^ 0x6A33D0D5;
					continue;
				case 20u:
					ptr2 = (byte*)(((ulong)ptr2 + 7uL) & 0xFFFFFFFFFFFFFFFCuL);
					num = (num2 * 1137751061) ^ 0x5C1DEF06;
					continue;
				case 47u:
					num = (num2 * -125594941) ^ -856035188;
					continue;
				case 91u:
					ptr2 += 4;
					num = (num2 * 620942566) ^ -567822341;
					continue;
				case 8u:
					ptr5 += 2;
					num = (num2 * 830687502) ^ 0x2DFB8E2E;
					continue;
				case 184u:
					*ptr2 = 0;
					num = (num2 * -88243032) ^ 0x3E44D843;
					continue;
				case 59u:
					ptr2 += 4;
					num = (num2 * 213341325) ^ 0x7F750AD9;
					continue;
				case 161u:
					(ptr6 + num5)[num8] = ptr4[num8];
					num = 920210249;
					continue;
				case 196u:
					num37 = num37 - array2[num24] + array3[num24];
					num = (num2 * -743789936) ^ 0x2A2E41B0;
					continue;
				case 216u:
					num15 = 0;
					num = (num2 * 829627228) ^ 0x4308C519;
					continue;
				case 197u:
					*(int*)ptr5 = 0;
					num = (num2 * -1625827300) ^ 0x72FC4B1E;
					continue;
				case 16u:
					*ptr5 = 0;
					num = 836334440;
					continue;
				case 36u:
					num29 = 0;
					num = (num2 * -227322069) ^ -338697533;
					continue;
				case 88u:
					*(int*)ptr12 = 0;
					num = -1213838231;
					continue;
				case 13u:
					num29++;
					num = 259682407;
					continue;
				case 177u:
					array = new uint[num18];
					num = (num2 * -298996894) ^ 0x2E968B8A;
					continue;
				case 18u:
					_033a78c7(ptr5, 8, 64u, ref num7);
					num = -444217527;
					continue;
				case 139u:
					*(int*)(ptr12 + 4) = 0;
					num = (num2 * -570505730) ^ 0x6CBDBB78;
					continue;
				case 97u:
					num9 = 0;
					num = (num2 * 665698972) ^ 0x16D9F3D6;
					continue;
				case 32u:
					num33 = *(uint*)(ptr - 16);
					num = -1231678390;
					continue;
				case 86u:
					*(int*)(ptr4 + 4) = 1852404846;
					num = (num2 * -1809725164) ^ -418339868;
					continue;
				case 58u:
				{
					int num70;
					int num71;
					if (num12 < array2[num13] + array[num13])
					{
						num70 = -562387959;
						num71 = num70;
					}
					else
					{
						num70 = -821175002;
						num71 = num70;
					}
					num = num70 ^ (num2 * -194965763);
					continue;
				}
				case 55u:
					ptr4 = stackalloc byte[11];
					num = (num2 * 1840709763) ^ 0x8F79DD4;
					continue;
				case 81u:
					ptr6 = (byte*)_003CModule_003E._0009_001Dù_000C_00B0(_003CModule_003E._00B9_0085Jª7(module));
					num = (num2 * -1285957457) ^ 0x2D1C5DB8;
					continue;
				case 51u:
					_033a78c7(ptr6 + num12, 11, 64u, ref num7);
					num = -1252257753;
					continue;
				case 219u:
				{
					int num68;
					int num69;
					if (_003CModule_003E.µp_00BD_008DV(_003CModule_003E.ç_0092Ä_002B_009D(module), 0) == '<')
					{
						num68 = -172355896;
						num69 = num68;
					}
					else
					{
						num68 = -1936360496;
						num69 = num68;
					}
					num = num68 ^ (num2 * -93770370);
					continue;
				}
				case 24u:
					num = (num2 * 402346455) ^ -603375372;
					continue;
				case 105u:
				{
					int num66;
					int num67;
					if (num5 >= array2[num4] + array[num4])
					{
						num66 = 787766258;
						num67 = num66;
					}
					else
					{
						num66 = 462443313;
						num67 = num66;
					}
					num = num66 ^ (num2 * 863125008);
					continue;
				}
				case 211u:
					ptr = ptr + 4 + (int)num53;
					num = (num2 * 1918768505) ^ 0x7E944812;
					continue;
				case 100u:
					ptr5 += 12;
					num = (num2 * 1133828203) ^ 0x2543F5DF;
					continue;
				case 31u:
					num27++;
					num = 1227467120;
					continue;
				case 103u:
					num3 = 0;
					num = (num2 * 2081423939) ^ -1443947695;
					continue;
				case 30u:
					num28 = num28 - array2[num29] + array3[num29];
					num = (num2 * 1395434476) ^ -732651937;
					continue;
				case 123u:
					ptr2 += (uint)(*(int*)ptr2);
					num = (num2 * -1455057624) ^ 0x18A0AA3A;
					continue;
				case 208u:
					num = (num2 * 1123584150) ^ -866008112;
					continue;
				case 160u:
					*(int*)(ptr4 + 4) = 1818504812;
					num = (num2 * -1537196076) ^ 0x3335C0B5;
					continue;
				case 15u:
					ptr5 = (byte*)(((ulong)ptr5 + 7uL) & 0xFFFFFFFFFFFFFFFCuL);
					num = (num2 * -193328244) ^ 0xA066CE2;
					continue;
				case 57u:
					*(short*)(ptr4 + (nint)4 * (nint)2) = 25973;
					num = (num2 * -1055697752) ^ -866058275;
					continue;
				case 118u:
					num = (num2 * 46556891) ^ -303434616;
					continue;
				case 92u:
				{
					int num64;
					int num65;
					if (num41 >= array2[num42] + array[num42])
					{
						num64 = 642653593;
						num65 = num64;
					}
					else
					{
						num64 = 2141515790;
						num65 = num64;
					}
					num = num64 ^ (num2 * -539908117);
					continue;
				}
				case 49u:
					ptr5 += 3;
					num = (num2 * 1759937501) ^ -1906802695;
					continue;
				case 130u:
					_033a78c7(ptr12, 72, 64u, ref num7);
					num = (num2 * 1654408984) ^ -1269718326;
					continue;
				case 17u:
					num21++;
					num = (num2 * 2084461518) ^ -1338647783;
					continue;
				case 79u:
				{
					int num63;
					if (num32 < num18)
					{
						num = -521156120;
						num63 = num;
					}
					else
					{
						num = -328805382;
						num63 = num;
					}
					continue;
				}
				case 136u:
					ptr5 = ptr6 + (uint)(*(int*)(ptr3 + 8));
					num = (num2 * 378693355) ^ -1390951740;
					continue;
				case 209u:
					ptr5 += 2;
					num = (num2 * 318899142) ^ -947808421;
					continue;
				case 192u:
				{
					int num62;
					if (array2[num13] > num12)
					{
						num = -976876728;
						num62 = num;
					}
					else
					{
						num = -1399807316;
						num62 = num;
					}
					continue;
				}
				case 207u:
				{
					int num58;
					int num59;
					if (*(uint*)(ptr - 120) != 0)
					{
						num58 = 1271817271;
						num59 = num58;
					}
					else
					{
						num58 = 396113448;
						num59 = num58;
					}
					num = num58 ^ (num2 * -1941105415);
					continue;
				}
				case 87u:
					ptr5 += 4;
					num = (num2 * 581825962) ^ 0x56CC0897;
					continue;
				case 40u:
					*ptr5 = 0;
					num = -2087075833;
					continue;
				case 83u:
					*(short*)(ptr4 + (nint)4 * (nint)2) = 108;
					num = (num2 * 1457523535) ^ 0x43DA8D1A;
					continue;
				case 143u:
					num32++;
					num = -177754079;
					continue;
				case 1u:
					ptr2 += 2;
					num = (num2 * 1928144363) ^ -1078689059;
					continue;
				case 206u:
					num = (num2 * 1219815994) ^ -1549664821;
					continue;
				case 187u:
					ptr5++;
					num = (num2 * -225782491) ^ -651807617;
					continue;
				case 183u:
					num14++;
					num = (num2 * 1617656446) ^ 0x3BDDA73F;
					continue;
				case 7u:
					num = (num2 * -810546233) ^ -378814932;
					continue;
				case 115u:
				{
					int num57;
					if (array2[num29] <= num28)
					{
						num = -1612363972;
						num57 = num;
					}
					else
					{
						num = -583758285;
						num57 = num;
					}
					continue;
				}
				case 14u:
				{
					int num54;
					int num55;
					if (*ptr2 != 0)
					{
						num54 = -1577437351;
						num55 = num54;
					}
					else
					{
						num54 = 1128273485;
						num55 = num54;
					}
					num = num54 ^ (num2 * -651431482);
					continue;
				}
				case 129u:
					ptr4[10] = 0;
					num = (num2 * -1569652631) ^ -1820079331;
					continue;
				case 178u:
					num = (num2 * -2098611186) ^ -195222006;
					continue;
				case 109u:
					num = (num2 * -1823396935) ^ -1038760434;
					continue;
				case 78u:
					ptr2++;
					num = (num2 * -1658989381) ^ -464710470;
					continue;
				case 41u:
				{
					int num51;
					int num52;
					if (*ptr2 == 0)
					{
						num51 = 666163106;
						num52 = num51;
					}
					else
					{
						num51 = 1265735742;
						num52 = num51;
					}
					num = num51 ^ (num2 * -815438854);
					continue;
				}
				case 186u:
					*ptr2 = 0;
					num = -607209772;
					continue;
				case 198u:
					_033a78c7(ptr2, 4, 64u, ref num7);
					num = 540144974;
					continue;
				case 149u:
					ptr5 += (uint)(*(int*)ptr5);
					num = (num2 * 1677376238) ^ -1799491153;
					continue;
				case 121u:
				{
					int num50;
					if (num29 < num18)
					{
						num = -887623435;
						num50 = num;
					}
					else
					{
						num = 1489933018;
						num50 = num;
					}
					continue;
				}
				case 119u:
					num = (num2 * 504110854) ^ 0x3AD6AA55;
					continue;
				case 77u:
					array2[num3] = *(uint*)(ptr + 12);
					num = (num2 * 353648227) ^ -1991277255;
					continue;
				case 43u:
					ptr4[10] = 0;
					num = (num2 * 2103226075) ^ -2142571809;
					continue;
				case 98u:
					*(short*)(ptr4 + (nint)4 * (nint)2) = 25973;
					num = (num2 * 1319686024) ^ 0x14E474B9;
					continue;
				case 44u:
					*(int*)(ptr12 + (nint)2 * (nint)4) = 0;
					num = (num2 * -236951341) ^ -2049960002;
					continue;
				case 23u:
				{
					int num47;
					if (num14 >= 8)
					{
						num = 307074648;
						num47 = num;
					}
					else
					{
						num = 1027830668;
						num47 = num;
					}
					continue;
				}
				case 34u:
				{
					int num44;
					if (array2[num42] > num41)
					{
						num = -1686618199;
						num44 = num;
					}
					else
					{
						num = 232185226;
						num44 = num;
					}
					continue;
				}
				case 134u:
				{
					int num40;
					if (num27 < num39)
					{
						num = 95823584;
						num40 = num;
					}
					else
					{
						num = -410470790;
						num40 = num;
					}
					continue;
				}
				case 169u:
					*ptr5 = 0;
					num = -13155207;
					continue;
				case 175u:
					ptr9 = ptr6 + (uint)(*(int*)ptr7);
					num = (num2 * 933304490) ^ 0x8C3597D;
					continue;
				case 170u:
				{
					int num35;
					int num36;
					if (*ptr5 != 0)
					{
						num35 = 1297209890;
						num36 = num35;
					}
					else
					{
						num35 = -1760452185;
						num36 = num35;
					}
					num = num35 ^ (num2 * -1568220152);
					continue;
				}
				case 172u:
					num = (num2 * 1232874097) ^ 0x3A6ED948;
					continue;
				case 54u:
				{
					int num30;
					int num31;
					if (num28 < array2[num29] + array[num29])
					{
						num30 = 2042433638;
						num31 = num30;
					}
					else
					{
						num30 = -309148703;
						num31 = num30;
					}
					num = num30 ^ (num2 * 1568107083);
					continue;
				}
				case 95u:
					num = (num2 * -1136485318) ^ 0x692AAC34;
					continue;
				case 113u:
					ptr5++;
					num = (num2 * 2099203559) ^ -34154257;
					continue;
				case 131u:
					ptr5++;
					num = (num2 * 784483513) ^ 0x3D652978;
					continue;
				case 73u:
					num27 = 0;
					num = (num2 * 949480628) ^ -660582378;
					continue;
				case 203u:
					ptr2 += 3;
					num = (num2 * 1049818531) ^ -1832250029;
					continue;
				case 151u:
					num5 = num5 - array2[num4] + array3[num4];
					num = (num2 * -427681960) ^ -942160634;
					continue;
				case 148u:
					num = (num2 * -1026403272) ^ -43197935;
					continue;
				case 214u:
				{
					int num26;
					if (num24 >= num18)
					{
						num = 310539967;
						num26 = num;
					}
					else
					{
						num = 857192537;
						num26 = num;
					}
					continue;
				}
				case 50u:
				{
					int num22;
					int num23;
					if (*ptr5 != 0)
					{
						num22 = -1452365752;
						num23 = num22;
					}
					else
					{
						num22 = 777465992;
						num23 = num22;
					}
					num = num22 ^ (num2 * 1851998739);
					continue;
				}
				case 56u:
					num21 = 0;
					num = (num2 * -751390678) ^ 0x29BB93AC;
					continue;
				case 62u:
					num = (num2 * 788611821) ^ 0x42A868F;
					continue;
				case 188u:
					ptr5 += 2;
					num = (num2 * -1584851423) ^ 0x6513C99F;
					continue;
				case 26u:
					num13++;
					num = 213312682;
					continue;
				case 19u:
					*(int*)(ptr4 + 4) = 1818504812;
					num = (num2 * -1962714478) ^ 0x5151538C;
					continue;
				case 80u:
				{
					int num17;
					if (num15 >= num16)
					{
						num = 261978052;
						num17 = num;
					}
					else
					{
						num = 1597527782;
						num17 = num;
					}
					continue;
				}
				case 135u:
					num = (num2 * -1294976935) ^ 0x27F2FED9;
					continue;
				case 76u:
					num4++;
					num = 77986502;
					continue;
				case 108u:
					num14 = 0;
					num = (num2 * -2002649508) ^ -1923948998;
					continue;
				case 116u:
					_033a78c7(ptr2, 8, 64u, ref num7);
					num = -1820015207;
					continue;
				case 195u:
				{
					int num11;
					if (num10 < 11)
					{
						num = -115665120;
						num11 = num;
					}
					else
					{
						num = 453892383;
						num11 = num;
					}
					continue;
				}
				case 42u:
					num = (num2 * -1649067313) ^ 0x43C137DD;
					continue;
				case 185u:
					*(int*)(ptr3 + 4) = 0;
					num = (num2 * -1807352614) ^ 0x15AE474A;
					continue;
				case 2u:
					num9++;
					num = (num2 * -1636684881) ^ 0x77E9F4BE;
					continue;
				case 218u:
					ptr2 += 12;
					num = (num2 * 1994157789) ^ -777703437;
					continue;
				case 159u:
					array3[num3] = *(uint*)(ptr + 20);
					num = (num2 * -523456907) ^ -519658884;
					continue;
				case 4u:
					num8 = 0;
					num = (num2 * -83651683) ^ 0x49DB642D;
					continue;
				case 194u:
					_033a78c7(ptr2, 4, 64u, ref num7);
					num = (num2 * 990418618) ^ -921144709;
					continue;
				case 154u:
					ptr += 6;
					num = (num2 * -415503261) ^ 0xB3FD497;
					continue;
				case 65u:
				{
					int num6;
					if (array2[num4] <= num5)
					{
						num = -1960640641;
						num6 = num;
					}
					else
					{
						num = 1229210466;
						num6 = num;
					}
					continue;
				}
				case 12u:
					array[num3] = *(uint*)(ptr + 8);
					num = (num2 * 710819576) ^ 0x6396C2C5;
					continue;
				case 70u:
					return;
				}
				break;
			}
		}
	}
}
