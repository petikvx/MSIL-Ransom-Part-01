using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Security.Principal;
using System.Text;

public class GClass33
{
	private static readonly uint uint_0 = 2147483648u;

	private static readonly uint uint_1;

	private static readonly uint uint_2;

	private static readonly uint uint_3;

	internal static void smethod_0(string string_0, FileAttributes fileAttributes_0)
	{
		string string_ = GClass41.smethod_0(string_0);
		bool flag = default(bool);
		while (true)
		{
			int num = 1210617294;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7432CF0Eu) % 5u)
				{
				case 4u:
					flag = !Class17.SetFileAttributes(string_, fileAttributes_0);
					num = (int)((num2 * 357831316) ^ 0x1136A1FD);
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1649692974;
						num4 = 1649692974;
					}
					else
					{
						num3 = 1207240825;
						num4 = 1207240825;
					}
					num = num3 ^ (int)(num2 * 1741653206);
					continue;
				}
				default:
					return;
				case 2u:
					break;
				case 0u:
					throw smethod_8();
				case 1u:
					return;
				}
				break;
			}
		}
	}

	internal static FileAttributes smethod_1(string string_0)
	{
		string string_ = GClass41.smethod_0(string_0);
		FileAttributes fileAttributes_;
		int num = smethod_6(string_, out fileAttributes_);
		FileAttributes result = default(FileAttributes);
		while (true)
		{
			int num2 = 297749900;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x1CEC5403u) % 6u)
				{
				case 4u:
					result = fileAttributes_;
					num2 = 231270928;
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (num != 0)
					{
						num4 = -1369903348;
						num5 = -1369903348;
					}
					else
					{
						num4 = -158897762;
						num5 = -158897762;
					}
					num2 = num4 ^ ((int)num3 * -1240953745);
					continue;
				}
				case 1u:
					num2 = ((int)num3 * -209465613) ^ 0x6BD3E585;
					continue;
				case 0u:
					break;
				case 2u:
					throw smethod_10(num);
				default:
					return result;
				}
				break;
			}
		}
	}

	internal static FileAttributes smethod_2(string string_0, out int int_0)
	{
		FileAttributes fileAttributes_ = default(FileAttributes);
		string string_ = default(string);
		FileAttributes result = default(FileAttributes);
		while (true)
		{
			int num = 1733054925;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7AC4DDF0u) % 5u)
				{
				case 3u:
					fileAttributes_ = (FileAttributes)(-1);
					int_0 = smethod_6(string_, out fileAttributes_);
					num = (int)((num2 * 1915412335) ^ 0xDA2AFA7);
					continue;
				case 2u:
					result = fileAttributes_;
					num = (int)((num2 * 1300357655) ^ 0x28A46333);
					continue;
				case 1u:
					string_ = GClass41.smethod_0(string_0);
					num = (int)((num2 * 852731462) ^ 0x35E61792);
					continue;
				case 0u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	internal static FileAttributes smethod_3(string string_0)
	{
		string string_ = GClass41.smethod_0(string_0);
		bool flag = default(bool);
		int num3 = default(int);
		FileAttributes fileAttributes_ = default(FileAttributes);
		FileAttributes result = default(FileAttributes);
		while (true)
		{
			int num = -1533201947;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x924961BEu) % 8u)
				{
				case 7u:
					flag = num3 != 0;
					num = (int)(num2 * 2085226432) ^ -1857328469;
					continue;
				case 6u:
					num = (int)(num2 * 352124530) ^ -1415170864;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -1347922311;
						num5 = -1347922311;
					}
					else
					{
						num4 = -1789729732;
						num5 = -1789729732;
					}
					num = num4 ^ (int)(num2 * 1248503158);
					continue;
				}
				case 3u:
					num3 = smethod_7(string_, out fileAttributes_);
					num = ((int)num2 * -24410320) ^ -1725410135;
					continue;
				case 1u:
					result = fileAttributes_;
					num = -479619016;
					continue;
				case 0u:
					break;
				case 4u:
					throw smethod_10(num3);
				default:
					return result;
				}
				break;
			}
		}
	}

	internal static string smethod_4(string string_0)
	{
		string result = default(string);
		while (true)
		{
			int num = -841220076;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xC379190Bu) % 6u)
				{
				case 5u:
					result = "*";
					num = ((int)num2 * -1132480575) ^ 0x356DF39C;
					continue;
				case 4u:
					if (!(string_0 == "."))
					{
						num = -47776332;
						num3 = -47776332;
						continue;
					}
					goto IL_0028;
				case 3u:
					result = string_0;
					num = -981029579;
					continue;
				case 1u:
					if (!string.IsNullOrEmpty(string_0))
					{
						num = ((int)num2 * -354519924) ^ 0x304BBF03;
						continue;
					}
					goto IL_0028;
				case 0u:
					break;
				default:
					{
						return result;
					}
					IL_0028:
					num = -846448158;
					num3 = -846448158;
					continue;
				}
				break;
			}
		}
	}

	internal static bool smethod_5(string string_0, out bool bool_0)
	{
		FileAttributes fileAttributes_ = default(FileAttributes);
		bool result = default(bool);
		int num5 = default(int);
		string string_ = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num = -859120822;
			while (true)
			{
				uint num2;
				int num6;
				int num7;
				switch ((num2 = (uint)num ^ 0xD40284FFu) % 16u)
				{
				case 15u:
					bool_0 = GClass34.smethod_10(fileAttributes_);
					result = true;
					num = ((int)num2 * -1603948344) ^ -1775164655;
					continue;
				case 14u:
					num = -2088053809;
					continue;
				case 13u:
					num = (int)((num2 * 289633537) ^ 0x661410FA);
					continue;
				case 10u:
					if (num5 == 0)
					{
						num = (int)(num2 * 1911323278) ^ -399336160;
						continue;
					}
					num6 = 0;
					goto IL_0058;
				case 9u:
					if (!smethod_17(string_0))
					{
						num = -2088053809;
						num7 = -2088053809;
						continue;
					}
					goto IL_006c;
				case 8u:
					num5 = smethod_7(string_, out fileAttributes_);
					num = ((int)num2 * -2080755565) ^ -175803827;
					continue;
				case 7u:
					num = (int)((num2 * 545677477) ^ 0x7FB88DB7);
					continue;
				case 6u:
					num = (int)((num2 * 596888464) ^ 0x39BA1254);
					continue;
				case 5u:
					string_ = string_0;
					num = ((int)num2 * -1764894091) ^ 0x1BBEED52;
					continue;
				case 4u:
					if (!GClass41.smethod_2(string_0, out string_))
					{
						num = ((int)num2 * -918116130) ^ 0x4150C85E;
						continue;
					}
					goto IL_006c;
				case 3u:
					num6 = ((fileAttributes_ != (FileAttributes)(-1)) ? 1 : 0);
					goto IL_0058;
				case 2u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1414321395;
						num4 = -1414321395;
					}
					else
					{
						num3 = -664377924;
						num4 = -664377924;
					}
					num = num3 ^ (int)(num2 * 876234886);
					continue;
				}
				case 1u:
					result = false;
					num = ((int)num2 * -962709451) ^ 0x33FC221D;
					continue;
				case 0u:
					bool_0 = false;
					num = -963881458;
					continue;
				case 12u:
					break;
				default:
					{
						return result;
					}
					IL_0058:
					flag = (byte)num6 != 0;
					num = -1427320323;
					continue;
					IL_006c:
					num = -617123262;
					num7 = -617123262;
					continue;
				}
				break;
			}
		}
	}

	internal static int smethod_6(string string_0, out FileAttributes fileAttributes_0)
	{
		int result = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = -326462621;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x968C2896u) % 4u)
				{
				case 3u:
					result = num3;
					num = (int)((num2 * 97841425) ^ 0x770DCE2D);
					continue;
				case 1u:
					num3 = smethod_7(string_0, out fileAttributes_0);
					num = (int)((num2 * 542240397) ^ 0x7CD9ED1C);
					continue;
				case 2u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	internal static int smethod_7(string string_0, out FileAttributes fileAttributes_0)
	{
		Class17.Struct5 struct5_ = default(Class17.Struct5);
		int int_ = default(int);
		int result = default(int);
		while (true)
		{
			int num = -1917895908;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE2D7884Au) % 4u)
				{
				case 2u:
					struct5_ = default(Class17.Struct5);
					num = ((int)num2 * -1314638964) ^ -903421797;
					continue;
				case 1u:
					int_ = Class17.smethod_3(1);
					num = ((int)num2 * -388435672) ^ 0x699D18D2;
					continue;
				case 3u:
					break;
				default:
				{
					bool flag = false;
					try
					{
						while (true)
						{
							IL_0094:
							int num3 = -173050250;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xE2D7884Au) % 3u)
								{
								case 1u:
									goto IL_005e;
								default:
									goto end_IL_0076;
								case 2u:
									break;
								case 0u:
									goto end_IL_0076;
								}
								goto IL_0094;
								IL_005e:
								flag = Class17.GetFileAttributesEx(string_0, 0, ref struct5_);
								num3 = ((int)num2 * -666103643) ^ 0x4E9F2DDA;
								continue;
								end_IL_0076:
								break;
							}
							break;
						}
					}
					finally
					{
						while (true)
						{
							IL_00d3:
							int num4 = -1922289362;
							while (true)
							{
								switch ((num2 = (uint)num4 ^ 0xE2D7884Au) % 3u)
								{
								case 1u:
									goto IL_00a0;
								default:
									goto end_IL_00b5;
								case 0u:
									break;
								case 2u:
									goto end_IL_00b5;
								}
								goto IL_00d3;
								IL_00a0:
								Class17.smethod_3(int_);
								num4 = (int)(num2 * 398427068) ^ -286480100;
								continue;
								end_IL_00b5:
								break;
							}
							break;
						}
					}
					bool flag2 = !flag;
					while (true)
					{
						int num5 = -1961317919;
						while (true)
						{
							switch ((num2 = (uint)num5 ^ 0xE2D7884Au) % 10u)
							{
							case 9u:
								fileAttributes_0 = struct5_.fileAttributes;
								num5 = -444212938;
								continue;
							case 8u:
								num5 = (int)((num2 * 2093661221) ^ 0xA9F1AED);
								continue;
							case 7u:
								fileAttributes_0 = (FileAttributes)(-1);
								num5 = ((int)num2 * -1987753325) ^ -680783224;
								continue;
							case 5u:
								num5 = ((int)num2 * -1796754516) ^ 0x63406E46;
								continue;
							case 4u:
								result = 0;
								num5 = ((int)num2 * -522823185) ^ -1452943827;
								continue;
							case 3u:
								result = Marshal.GetLastWin32Error();
								num5 = (int)((num2 * 1220503193) ^ 0x6FC2A221);
								continue;
							case 1u:
							{
								int num6;
								int num7;
								if (!flag2)
								{
									num6 = 2060042842;
									num7 = 2060042842;
								}
								else
								{
									num6 = 1352203335;
									num7 = 1352203335;
								}
								num5 = num6 ^ ((int)num2 * -162661421);
								continue;
							}
							case 0u:
								num5 = (int)(num2 * 668242605) ^ -474063374;
								continue;
							case 2u:
								break;
							default:
								return result;
							}
							break;
						}
					}
				}
				}
				break;
			}
		}
	}

	internal static Exception smethod_8()
	{
		Exception result = default(Exception);
		while (true)
		{
			int num = 706952586;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA0A80Bu) % 4u)
				{
				case 3u:
					num = (int)(num2 * 972258044) ^ -279048359;
					continue;
				case 1u:
					result = smethod_9("path");
					num = (int)(num2 * 1176912392) ^ -92235892;
					continue;
				case 0u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	internal static Exception smethod_9(string string_0)
	{
		Exception result = smethod_11(Marshal.GetLastWin32Error(), string_0);
		while (true)
		{
			int num = 1220525999;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x63294FFEu) % 3u)
				{
				case 1u:
					goto IL_000e;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_000e:
				num = (int)((num2 * 104874828) ^ 0x6B85E319);
			}
		}
	}

	internal static Exception smethod_10(int int_0)
	{
		Exception result = smethod_11(int_0, "path");
		while (true)
		{
			int num = 1499774095;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8C4254Fu) % 3u)
				{
				case 1u:
					goto IL_000e;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_000e:
				num = ((int)num2 * -133989737) ^ 0x4F8D9C5C;
			}
		}
	}

	internal static Exception smethod_11(int int_0, string string_0)
	{
		Exception result = default(Exception);
		string message = default(string);
		int num3 = default(int);
		while (true)
		{
			int num = 1855489681;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5285E809u) % 27u)
				{
				case 26u:
					result = new PathTooLongException(message);
					num = 1812206507;
					continue;
				case 25u:
					num = ((int)num2 * -542812311) ^ -1576221437;
					continue;
				case 24u:
					result = new FileNotFoundException(message);
					num = 2134864273;
					continue;
				case 22u:
					num = ((int)num2 * -1369745512) ^ -237018905;
					continue;
				case 21u:
					goto IL_004c;
				case 20u:
					result = new DriveNotFoundException(message);
					num = 1917047365;
					continue;
				case 19u:
				{
					int num5;
					int num6;
					if (num3 <= 15)
					{
						num5 = -664251793;
						num6 = -664251793;
					}
					else
					{
						num5 = -1859054618;
						num6 = -1859054618;
					}
					num = num5 ^ ((int)num2 * -752773306);
					continue;
				}
				case 18u:
					switch (num3)
					{
					case 2:
						break;
					case 3:
						goto IL_004c;
					default:
						goto IL_00af;
					case 4:
						goto IL_00c1;
					case 5:
						goto IL_00d8;
					}
					goto case 24u;
				case 11u:
					goto IL_00c1;
				case 8u:
					goto IL_00d8;
				case 17u:
				{
					int num9;
					if (num3 != 15)
					{
						num = 1992125370;
						num9 = 1992125370;
					}
					else
					{
						num = 167370066;
						num9 = 167370066;
					}
					continue;
				}
				case 16u:
					num = (int)((num2 * 29831224) ^ 0x4590F7EF);
					continue;
				case 15u:
					num = ((int)num2 * -128603948) ^ 0x509CCD78;
					continue;
				case 14u:
				{
					int num8;
					if (num3 != 995)
					{
						num = 1574127938;
						num8 = 1574127938;
					}
					else
					{
						num = 1262331183;
						num8 = 1262331183;
					}
					continue;
				}
				case 12u:
					result = new OperationCanceledException(message);
					num = 873822255;
					continue;
				case 10u:
					result = new ArgumentException(message, string_0);
					num = 873822255;
					continue;
				case 9u:
					message = smethod_12(int_0);
					num3 = int_0;
					num = (int)((num2 * 1971387965) ^ 0x1E8EF2F8);
					continue;
				case 7u:
					num = (int)((num2 * 454199695) ^ 0x75BC3951);
					continue;
				case 6u:
				{
					int num7;
					if (num3 == 206)
					{
						num = 168685350;
						num7 = 168685350;
					}
					else
					{
						num = 825529997;
						num7 = 825529997;
					}
					continue;
				}
				case 5u:
					num = ((int)num2 * -2001928005) ^ -955037145;
					continue;
				case 4u:
					num = ((int)num2 * -1503022154) ^ 0x23145916;
					continue;
				case 3u:
					num = ((int)num2 * -1191723251) ^ 0x42188FB;
					continue;
				case 2u:
				{
					int num4;
					if (num3 == 123)
					{
						num = 1253621453;
						num4 = 1253621453;
					}
					else
					{
						num = 314502586;
						num4 = 314502586;
					}
					continue;
				}
				case 1u:
					num = ((int)num2 * -343811132) ^ -863441628;
					continue;
				case 0u:
					num = (int)((num2 * 1792064780) ^ 0x2E31BFA3);
					continue;
				case 13u:
					break;
				default:
					{
						return result;
					}
					IL_00af:
					num = (int)(num2 * 2107791313) ^ -1150259085;
					continue;
					IL_004c:
					result = new DirectoryNotFoundException(message);
					num = 383117377;
					continue;
					IL_00d8:
					result = new UnauthorizedAccessException(message);
					num = 1635963112;
					continue;
					IL_00c1:
					result = new IOException(message, Class17.smethod_0(int_0));
					num = 873822255;
					continue;
				}
				break;
			}
		}
	}

	private static string smethod_12(int int_0)
	{
		string result = default(string);
		while (true)
		{
			int num = -116744259;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB8C5870Cu) % 4u)
				{
				case 2u:
					num = (int)((num2 * 1735125387) ^ 0x2505AAB5);
					continue;
				case 1u:
				{
					StringBuilder stringBuilder = new StringBuilder(512);
					Class17.FormatMessage(12800, IntPtr.Zero, int_0, 0, stringBuilder, stringBuilder.Capacity, IntPtr.Zero);
					result = stringBuilder.ToString();
					num = ((int)num2 * -2089384343) ^ -1957440513;
					continue;
				}
				case 0u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	internal static void smethod_13(int int_0, string string_0)
	{
		if (int_0 == 123)
		{
			goto IL_0010;
		}
		goto IL_01b2;
		IL_0010:
		string text = GClass41.smethod_12(string_0);
		goto IL_04a7;
		IL_04a7:
		string text2 = text;
		int num = -1793195890;
		goto IL_03c8;
		IL_03c8:
		int num3 = default(int);
		bool flag5 = default(bool);
		bool flag4 = default(bool);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xA90DC984u) % 50u)
			{
			case 49u:
				break;
			case 45u:
				num = (int)((num2 * 805427024) ^ 0x48A920A6);
				continue;
			case 43u:
				goto IL_004f;
			case 42u:
			{
				int num16;
				int num17;
				if (num3 != 87)
				{
					num16 = 1776881240;
					num17 = 1776881240;
				}
				else
				{
					num16 = 934400858;
					num17 = 934400858;
				}
				num = num16 ^ ((int)num2 * -222553851);
				continue;
			}
			case 41u:
				flag5 = text2.Length == 0;
				num = -682830181;
				continue;
			case 40u:
				flag4 = text2.Length == 0;
				num = -887313537;
				continue;
			case 39u:
				num = (int)((num2 * 1187145375) ^ 0x5A607DD5);
				continue;
			case 38u:
				goto IL_00dd;
			case 37u:
			{
				int num18;
				int num19;
				if (num3 <= 15)
				{
					num18 = 942613772;
					num19 = 942613772;
				}
				else
				{
					num18 = 1005650594;
					num19 = 1005650594;
				}
				num = num18 ^ ((int)num2 * -691256776);
				continue;
			}
			case 34u:
				goto IL_012b;
			case 33u:
				goto IL_014f;
			case 30u:
				num = (int)(num2 * 2077855481) ^ -1066429184;
				continue;
			case 29u:
			{
				int num10;
				int num11;
				if (flag2)
				{
					num10 = -80393616;
					num11 = -80393616;
				}
				else
				{
					num10 = -473091945;
					num11 = -473091945;
				}
				num = num10 ^ ((int)num2 * -344067753);
				continue;
			}
			case 28u:
				num = (int)((num2 * 1090424384) ^ 0x85A0E73);
				continue;
			case 27u:
				goto end_IL_03c8;
			case 26u:
				switch (num3)
				{
				case 5:
					break;
				case 3:
					goto IL_014f;
				default:
					goto IL_01d4;
				case 2:
					goto IL_01e7;
				case 4:
					goto IL_0545;
				}
				goto IL_004f;
			case 13u:
				goto IL_01e7;
			case 25u:
				goto IL_01fb;
			case 24u:
				num = (int)(num2 * 1138697310) ^ -2088766320;
				continue;
			case 23u:
			{
				int num14;
				int num15;
				if (!flag5)
				{
					num14 = -920423633;
					num15 = -920423633;
				}
				else
				{
					num14 = -1002714196;
					num15 = -1002714196;
				}
				num = num14 ^ ((int)num2 * -1845721233);
				continue;
			}
			case 22u:
				goto IL_0258;
			case 21u:
			{
				int num12;
				int num13;
				if (!flag3)
				{
					num12 = -840414452;
					num13 = -840414452;
				}
				else
				{
					num12 = -409982230;
					num13 = -409982230;
				}
				num = num12 ^ ((int)num2 * -711525035);
				continue;
			}
			case 20u:
				goto IL_02a5;
			case 19u:
			{
				int num8;
				int num9;
				if (!flag4)
				{
					num8 = -1300920945;
					num9 = -1300920945;
				}
				else
				{
					num8 = -1676642059;
					num9 = -1676642059;
				}
				num = num8 ^ ((int)num2 * -2134462066);
				continue;
			}
			case 18u:
				flag3 = text2.Length == 0;
				num = -1596875399;
				continue;
			case 16u:
				num = ((int)num2 * -876308598) ^ -1496739816;
				continue;
			case 12u:
			{
				int num6;
				int num7;
				if (flag)
				{
					num6 = 1836700710;
					num7 = 1836700710;
				}
				else
				{
					num6 = 1314295050;
					num7 = 1314295050;
				}
				num = num6 ^ ((int)num2 * -2137688540);
				continue;
			}
			case 10u:
			{
				num3 = int_0;
				int num4;
				int num5;
				if (num3 > 80)
				{
					num4 = -515666262;
					num5 = -515666262;
				}
				else
				{
					num4 = -1250047627;
					num5 = -1250047627;
				}
				num = num4 ^ ((int)num2 * -391278139);
				continue;
			}
			case 9u:
				num = (int)(num2 * 1944927495) ^ -1481907915;
				continue;
			case 6u:
				goto IL_0379;
			case 5u:
				num = (int)(num2 * 184132789) ^ -1925313323;
				continue;
			case 2u:
				num = (int)((num2 * 385163129) ^ 0x351ECCFA);
				continue;
			case 1u:
				num = (int)(num2 * 1738297666) ^ -530946055;
				continue;
			case 7u:
				goto IL_04a6;
			case 4u:
				goto IL_04b2;
			case 0u:
				throw new DriveNotFoundException($"Drive {text2} not found");
			case 3u:
				throw new UnauthorizedAccessException("Empty path");
			case 8u:
				throw new IOException(Class17.smethod_2(int_0), Class17.smethod_0(int_0));
			case 11u:
				throw new IOException("Sharing violation with empty filename", Class17.smethod_0(int_0));
			case 14u:
				throw new DirectoryNotFoundException($"Directory {text2} not found");
			case 15u:
				throw new FileNotFoundException("Empty filename");
			case 17u:
				throw new OperationCanceledException();
			case 31u:
				throw new IOException($"Sharing violation: {text2}", Class17.smethod_0(int_0));
			default:
				goto IL_0545;
			case 35u:
				throw new UnauthorizedAccessException($"Access denied accessing {text2}");
			case 36u:
				throw new FileNotFoundException($"File {text2} not found", text2);
			case 44u:
				throw new DirectoryNotFoundException("Empty directory");
			case 46u:
				throw new PathTooLongException("Path too long");
			case 47u:
				throw new IOException($"File exists {text2}", Class17.smethod_0(int_0));
			case 48u:
				{
					throw new IOException($"File {text2}", Class17.smethod_0(int_0));
				}
				IL_0545:
				throw new IOException(Class17.smethod_2(int_0), Class17.smethod_0(int_0));
				IL_01d4:
				num = (int)((num2 * 756183758) ^ 0x2099721B);
				continue;
				IL_01e7:
				flag2 = text2.Length == 0;
				num = -693881417;
				continue;
				IL_014f:
				flag = text2.Length == 0;
				num = -1380368008;
				continue;
			}
			int num20;
			if (num3 != 80)
			{
				num = -853166217;
				num20 = -853166217;
			}
			else
			{
				num = -1545206358;
				num20 = -1545206358;
			}
			continue;
			IL_04b2:
			if (int_0 != 161)
			{
				num = -2086587529;
				continue;
			}
			goto IL_0010;
			IL_01fb:
			int num21;
			if (num3 != 15)
			{
				num = -622610730;
				num21 = -622610730;
			}
			else
			{
				num = -120331598;
				num21 = -120331598;
			}
			continue;
			IL_0379:
			int num22;
			if (num3 != 995)
			{
				num = -511655812;
				num22 = -511655812;
			}
			else
			{
				num = -1231911333;
				num22 = -1231911333;
			}
			continue;
			IL_00dd:
			int num23;
			if (num3 > 183)
			{
				num = -836149938;
				num23 = -836149938;
			}
			else
			{
				num = -1734615506;
				num23 = -1734615506;
			}
			continue;
			IL_0258:
			int num24;
			if (num3 == 183)
			{
				num = -983967025;
				num24 = -983967025;
			}
			else
			{
				num = -576670744;
				num24 = -576670744;
			}
			continue;
			IL_02a5:
			int num25;
			if (num3 == 32)
			{
				num = -1286736846;
				num25 = -1286736846;
			}
			else
			{
				num = -1759064462;
				num25 = -1759064462;
			}
			continue;
			IL_012b:
			int num26;
			if (num3 != 206)
			{
				num = -2007827745;
				num26 = -2007827745;
			}
			else
			{
				num = -1230492660;
				num26 = -1230492660;
			}
			continue;
			IL_004f:
			int num27;
			if (text2.Length == 0)
			{
				num = -930343723;
				num27 = -930343723;
			}
			else
			{
				num = -1029943427;
				num27 = -1029943427;
			}
			continue;
			end_IL_03c8:
			break;
		}
		goto IL_01b2;
		IL_01b2:
		num = -2045398854;
		goto IL_03c8;
		IL_04a6:
		text = string_0;
		goto IL_04a7;
	}

	internal static SecurityInfos smethod_14(AccessControlSections accessControlSections_0)
	{
		SecurityInfos securityInfos = (SecurityInfos)0;
		if ((accessControlSections_0 & AccessControlSections.Owner) != 0)
		{
			goto IL_0067;
		}
		goto IL_01ab;
		IL_01ab:
		bool flag = (accessControlSections_0 & AccessControlSections.Group) != 0;
		int num = -800701434;
		goto IL_0154;
		IL_0154:
		SecurityInfos result = default(SecurityInfos);
		bool flag2 = default(bool);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xC8473BA2u) % 17u)
			{
			case 16u:
				securityInfos |= SecurityInfos.Owner;
				num = (int)(num2 * 1890480079) ^ -1223478776;
				continue;
			case 15u:
				securityInfos |= SecurityInfos.DiscretionaryAcl;
				num = (int)(num2 * 1309497522) ^ -1924525885;
				continue;
			case 14u:
				num = (int)(num2 * 208727280) ^ -497448026;
				continue;
			case 13u:
				securityInfos |= SecurityInfos.SystemAcl;
				num = ((int)num2 * -1358730016) ^ 0x64F1F977;
				continue;
			case 12u:
				break;
			case 11u:
				num = ((int)num2 * -249637146) ^ -1816114850;
				continue;
			case 10u:
			{
				int num5;
				int num6;
				if (!flag)
				{
					num5 = 768554906;
					num6 = 768554906;
				}
				else
				{
					num5 = 1835291083;
					num6 = 1835291083;
				}
				num = num5 ^ ((int)num2 * -187345634);
				continue;
			}
			case 9u:
				num = ((int)num2 * -1668061717) ^ 0x6B87491;
				continue;
			case 7u:
				result = securityInfos;
				num = -569052632;
				continue;
			case 6u:
				num = ((int)num2 * -2115830572) ^ 0x649E8615;
				continue;
			case 5u:
				num = ((int)num2 * -1568821132) ^ 0x60D5433;
				continue;
			case 4u:
				goto IL_00ec;
			case 3u:
				flag2 = (accessControlSections_0 & AccessControlSections.Audit) != 0;
				num = -45427918;
				continue;
			case 1u:
				securityInfos |= SecurityInfos.Group;
				num = ((int)num2 * -719193843) ^ 0x780435C6;
				continue;
			case 0u:
			{
				int num3;
				int num4;
				if (!flag2)
				{
					num3 = -1817317625;
					num4 = -1817317625;
				}
				else
				{
					num3 = -1688499451;
					num4 = -1688499451;
				}
				num = num3 ^ (int)(num2 * 5387443);
				continue;
			}
			case 8u:
				goto IL_01ab;
			default:
				return result;
			}
			break;
			IL_00ec:
			int num7;
			if ((accessControlSections_0 & AccessControlSections.Access) != 0)
			{
				num = -1750535374;
				num7 = -1750535374;
			}
			else
			{
				num = -302752831;
				num7 = -302752831;
			}
		}
		goto IL_0067;
		IL_0067:
		num = -274093086;
		goto IL_0154;
	}

	internal static void smethod_15(FileSystemSecurity fileSystemSecurity_0, string string_0)
	{
		bool flag7 = default(bool);
		int num3 = default(int);
		SystemAcl genericAcl_2 = default(SystemAcl);
		RawSecurityDescriptor rawSecurityDescriptor = default(RawSecurityDescriptor);
		AccessControlSections accessControlSections = default(AccessControlSections);
		SecurityInfos securityInfos = default(SecurityInfos);
		bool flag5 = default(bool);
		byte[] securityDescriptorBinaryForm = default(byte[]);
		bool flag = default(bool);
		Exception ex = default(Exception);
		bool flag6 = default(bool);
		bool flag2 = default(bool);
		SecurityIdentifier securityIdentifier2 = default(SecurityIdentifier);
		DiscretionaryAcl genericAcl_ = default(DiscretionaryAcl);
		bool flag4 = default(bool);
		bool flag3 = default(bool);
		SecurityIdentifier securityIdentifier = default(SecurityIdentifier);
		while (true)
		{
			int num = -1272187737;
			while (true)
			{
				uint num2;
				int num9;
				int num14;
				int num10;
				switch ((num2 = (uint)num ^ 0xFAE65861u) % 97u)
				{
				case 96u:
					flag7 = num3 == 5;
					num = ((int)num2 * -1385877689) ^ 0x73207DC3;
					continue;
				case 95u:
					num = ((int)num2 * -439808262) ^ -1786791249;
					continue;
				case 94u:
					genericAcl_2 = new SystemAcl(isContainer: false, isDS: false, rawSecurityDescriptor.SystemAcl);
					num = (int)(num2 * 173235422) ^ -188069314;
					continue;
				case 93u:
				{
					int num28;
					if ((accessControlSections & AccessControlSections.Audit) == 0)
					{
						num = -600114598;
						num28 = -600114598;
					}
					else
					{
						num = -768141138;
						num28 = -768141138;
					}
					continue;
				}
				case 92u:
					num = (int)(num2 * 2031498891) ^ -668177409;
					continue;
				case 91u:
				{
					int num36;
					int num37;
					if (flag7)
					{
						num36 = 1162704049;
						num37 = 1162704049;
					}
					else
					{
						num36 = 1553526621;
						num37 = 1553526621;
					}
					num = num36 ^ (int)(num2 * 1604369477);
					continue;
				}
				case 90u:
				{
					int num23;
					int num24;
					if (rawSecurityDescriptor == null)
					{
						num23 = 1196098486;
						num24 = 1196098486;
					}
					else
					{
						num23 = 1118695605;
						num24 = 1118695605;
					}
					num = num23 ^ (int)(num2 * 2005436363);
					continue;
				}
				case 89u:
					num = ((int)num2 * -262159472) ^ -640533590;
					continue;
				case 88u:
					num9 = (int)securityInfos | (int)uint_1;
					goto IL_00fc;
				case 87u:
					flag5 = (rawSecurityDescriptor.ControlFlags & ControlFlags.SystemAclPresent) != 0;
					num = (int)(num2 * 1967424262) ^ -2090245722;
					continue;
				case 86u:
					num = -417351126;
					continue;
				case 85u:
					num = (int)(num2 * 2029152798) ^ -1028056438;
					continue;
				case 84u:
					num = -600114598;
					continue;
				case 83u:
				{
					int num32;
					int num33;
					if (securityDescriptorBinaryForm != null)
					{
						num32 = -1659421634;
						num33 = -1659421634;
					}
					else
					{
						num32 = -550547474;
						num33 = -550547474;
					}
					num = num32 ^ (int)(num2 * 160975555);
					continue;
				}
				case 82u:
					rawSecurityDescriptor = new RawSecurityDescriptor(securityDescriptorBinaryForm, 0);
					flag = (rawSecurityDescriptor.ControlFlags & ControlFlags.DiscretionaryAclPresent) != 0;
					num = ((int)num2 * -1594762274) ^ -397102455;
					continue;
				case 81u:
					num = ((int)num2 * -1168341216) ^ 0x6F5D2406;
					continue;
				case 80u:
				{
					int num27;
					if (securityInfos == (SecurityInfos)0)
					{
						num = -1966263839;
						num27 = -1966263839;
					}
					else
					{
						num = -625213354;
						num27 = -625213354;
					}
					continue;
				}
				case 79u:
				{
					int num20;
					int num21;
					if (ex != null)
					{
						num20 = -1605177647;
						num21 = -1605177647;
					}
					else
					{
						num20 = -202513549;
						num21 = -202513549;
					}
					num = num20 ^ ((int)num2 * -406997329);
					continue;
				}
				case 78u:
					num = ((int)num2 * -1716252962) ^ -1926145263;
					continue;
				case 77u:
					num = -1121246261;
					continue;
				case 76u:
					ex = new InvalidOperationException("Invalid group");
					num = (int)(num2 * 1798318003) ^ -1537735957;
					continue;
				case 75u:
					if (flag5)
					{
						num = ((int)num2 * -1226023913) ^ -865152828;
						continue;
					}
					goto IL_026a;
				case 74u:
					if ((rawSecurityDescriptor.ControlFlags & ControlFlags.DiscretionaryAclProtected) != 0)
					{
						num = (int)((num2 * 337754425) ^ 0x5209CC80);
						continue;
					}
					num14 = (int)securityInfos | (int)uint_2;
					goto IL_02a3;
				case 73u:
					ex = new NotSupportedException("Invalid Handle");
					num = ((int)num2 * -2037115266) ^ -1411759499;
					continue;
				case 72u:
					if ((rawSecurityDescriptor.ControlFlags & ControlFlags.SystemAclProtected) != 0)
					{
						num = -120052701;
						continue;
					}
					num9 = (int)securityInfos | (int)uint_3;
					goto IL_00fc;
				case 71u:
					num = ((int)num2 * -271071626) ^ -925614905;
					continue;
				case 69u:
					ex = smethod_11(num3, string_0);
					num = ((int)num2 * -86424016) ^ 0x64F5D947;
					continue;
				case 68u:
					num = (int)((num2 * 795927024) ^ 0x2B63FE9D);
					continue;
				case 67u:
					ex = new FileNotFoundException();
					num = (int)(num2 * 328139733) ^ -1460220051;
					continue;
				case 66u:
					num = (int)(num2 * 351339874) ^ -973477617;
					continue;
				case 65u:
					num = -1103934171;
					continue;
				case 64u:
					ex = new InvalidOperationException("Invalid owner");
					num = ((int)num2 * -195502520) ^ 0x2A65141F;
					continue;
				case 63u:
					ex = new UnauthorizedAccessException();
					num = (int)((num2 * 516320478) ^ 0x273A41C4);
					continue;
				case 62u:
				{
					int num34;
					int num35;
					if (!flag6)
					{
						num34 = -1921732039;
						num35 = -1921732039;
					}
					else
					{
						num34 = -1741115322;
						num35 = -1741115322;
					}
					num = num34 ^ (int)(num2 * 1983530849);
					continue;
				}
				case 60u:
					flag = false;
					num = (int)(num2 * 251109910) ^ -5914407;
					continue;
				case 59u:
					num = (int)((num2 * 424212193) ^ 0x145009C);
					continue;
				case 58u:
				{
					int num30;
					int num31;
					if (!flag2)
					{
						num30 = 289708526;
						num31 = 289708526;
					}
					else
					{
						num30 = 1416695128;
						num31 = 1416695128;
					}
					num = num30 ^ (int)(num2 * 795559550);
					continue;
				}
				case 57u:
					genericAcl_2 = null;
					num = (int)((num2 * 1347842603) ^ 0x40B494A6);
					continue;
				case 56u:
				{
					int num29;
					if (num3 != 1350)
					{
						num = -692743588;
						num29 = -692743588;
					}
					else
					{
						num = -404233038;
						num29 = -404233038;
					}
					continue;
				}
				case 55u:
					num = (int)(num2 * 1210160990) ^ -793675587;
					continue;
				case 53u:
					securityInfos |= SecurityInfos.SystemAcl;
					num = (int)((num2 * 1838884990) ^ 0x301981F1);
					continue;
				case 52u:
					num = (int)(num2 * 968127563) ^ -1812066902;
					continue;
				case 51u:
					securityInfos |= SecurityInfos.Group;
					num = (int)(num2 * 1577952609) ^ -291614169;
					continue;
				case 50u:
					flag6 = (accessControlSections & AccessControlSections.Group) != 0;
					num = -2025297258;
					continue;
				case 49u:
					num = (int)(num2 * 860546541) ^ -1052974313;
					continue;
				case 48u:
				{
					int num25;
					int num26;
					if (rawSecurityDescriptor != null)
					{
						num25 = 1508474243;
						num26 = 1508474243;
					}
					else
					{
						num25 = 1153701203;
						num26 = 1153701203;
					}
					num = num25 ^ ((int)num2 * -1403415905);
					continue;
				}
				case 47u:
					ex = new InvalidOperationException("Unexpected error");
					num = ((int)num2 * -2140188798) ^ 0x7A253FCA;
					continue;
				case 46u:
					ex = new ArgumentException("Invalid name", "name");
					num = ((int)num2 * -431766218) ^ 0x63CDAE58;
					continue;
				case 45u:
					securityIdentifier2 = null;
					num = (int)(num2 * 161730223) ^ -1998198689;
					continue;
				case 44u:
					num = (int)(num2 * 264123654) ^ -1500732238;
					continue;
				case 43u:
					num = ((int)num2 * -777250467) ^ 0x344868;
					continue;
				case 42u:
					num14 = (int)securityInfos | (int)uint_0;
					goto IL_02a3;
				case 41u:
					genericAcl_ = null;
					num = (int)((num2 * 1160446365) ^ 0x48E263E7);
					continue;
				case 40u:
					num = ((int)num2 * -1318039220) ^ -1287176541;
					continue;
				case 39u:
					num = ((int)num2 * -2024869350) ^ -908446629;
					continue;
				case 38u:
					flag4 = num3 != 0;
					num = (int)(num2 * 629236477) ^ -1658062312;
					continue;
				case 37u:
					num = ((int)num2 * -280283424) ^ -310997242;
					continue;
				case 36u:
					ex = new NotSupportedException("No associated security");
					num = (int)((num2 * 1247371326) ^ 0x6CC2891F);
					continue;
				case 35u:
					securityInfos |= SecurityInfos.Owner;
					num = (int)((num2 * 308130351) ^ 0x58EAAA3F);
					continue;
				case 34u:
					rawSecurityDescriptor = null;
					num = (int)((num2 * 2004210313) ^ 0x2B7422BF);
					continue;
				case 33u:
				{
					int num22;
					if (num3 == 123)
					{
						num = -1873503637;
						num22 = -1873503637;
					}
					else
					{
						num = -1999307332;
						num22 = -1999307332;
					}
					continue;
				}
				case 32u:
				{
					int num19;
					if (num3 == 1308)
					{
						num = -1554047395;
						num19 = -1554047395;
					}
					else
					{
						num = -1409946900;
						num19 = -1409946900;
					}
					continue;
				}
				case 31u:
					num = (int)(num2 * 204780876) ^ -449914575;
					continue;
				case 30u:
					num = ((int)num2 * -1412710618) ^ 0x61568258;
					continue;
				case 29u:
				{
					int num17;
					int num18;
					if (flag3)
					{
						num17 = -1462819920;
						num18 = -1462819920;
					}
					else
					{
						num17 = -932626396;
						num18 = -932626396;
					}
					num = num17 ^ (int)(num2 * 1148145820);
					continue;
				}
				case 28u:
				{
					int num15;
					int num16;
					if (!(securityIdentifier != null))
					{
						num15 = 860652911;
						num16 = 860652911;
					}
					else
					{
						num15 = 1165105737;
						num16 = 1165105737;
					}
					num = num15 ^ ((int)num2 * -1863076907);
					continue;
				}
				case 27u:
				{
					int num12;
					int num13;
					if (!flag4)
					{
						num12 = -191140557;
						num13 = -191140557;
					}
					else
					{
						num12 = -16193420;
						num13 = -16193420;
					}
					num = num12 ^ (int)(num2 * 898804182);
					continue;
				}
				case 26u:
					securityDescriptorBinaryForm = fileSystemSecurity_0.GetSecurityDescriptorBinaryForm();
					num = -1458795983;
					continue;
				case 25u:
				{
					int num11;
					if (num3 == 1307)
					{
						num = -373303862;
						num11 = -373303862;
					}
					else
					{
						num = -465393266;
						num11 = -465393266;
					}
					continue;
				}
				case 24u:
					securityInfos |= SecurityInfos.DiscretionaryAcl;
					num = ((int)num2 * -2065906208) ^ -433879689;
					continue;
				case 23u:
					securityIdentifier = (SecurityIdentifier)fileSystemSecurity_0.GetOwner(typeof(SecurityIdentifier));
					num = ((int)num2 * -1872432967) ^ -1047382368;
					continue;
				case 22u:
					if (rawSecurityDescriptor.SystemAcl!.Count > 0)
					{
						num = -1378093688;
						num10 = -1378093688;
						continue;
					}
					goto IL_026a;
				case 21u:
					num = ((int)num2 * -1622357986) ^ 0x125CF72F;
					continue;
				case 20u:
					flag3 = num3 == 2;
					num = -1554585433;
					continue;
				case 19u:
					securityIdentifier = null;
					num = (int)((num2 * 1747821638) ^ 0x4669F429);
					continue;
				case 18u:
				{
					securityIdentifier2 = (SecurityIdentifier)fileSystemSecurity_0.GetGroup(typeof(SecurityIdentifier));
					int num7;
					int num8;
					if (securityIdentifier2 != null)
					{
						num7 = -521750757;
						num8 = -521750757;
					}
					else
					{
						num7 = -1783731304;
						num8 = -1783731304;
					}
					num = num7 ^ (int)(num2 * 42287873);
					continue;
				}
				case 17u:
					num = (int)((num2 * 1197840158) ^ 0x5E68ADB9);
					continue;
				case 16u:
					num = ((int)num2 * -886329691) ^ 0x6277635B;
					continue;
				case 15u:
					genericAcl_2 = null;
					num = ((int)num2 * -1907411192) ^ 0x33FE26AA;
					continue;
				case 14u:
					num = (int)((num2 * 972705469) ^ 0x7D8060A6);
					continue;
				case 13u:
					num = -321101166;
					continue;
				case 12u:
					num = ((int)num2 * -1503090960) ^ -1026684115;
					continue;
				case 11u:
					flag2 = (accessControlSections & AccessControlSections.Access) != 0 && flag;
					num = -1347854173;
					continue;
				case 10u:
					num = -663919954;
					continue;
				case 9u:
					accessControlSections = AccessControlSections.Audit | AccessControlSections.Owner | AccessControlSections.Group;
					num = (int)(num2 * 1063002361) ^ -824008299;
					continue;
				case 8u:
					num3 = smethod_16(ResourceType.FileObject, string_0, null, securityInfos, securityIdentifier, securityIdentifier2, genericAcl_2, genericAcl_);
					num = -1869766749;
					continue;
				case 7u:
				{
					genericAcl_ = null;
					int num5;
					int num6;
					if ((accessControlSections & AccessControlSections.Owner) == 0)
					{
						num5 = -2081791468;
						num6 = -2081791468;
					}
					else
					{
						num5 = -175077838;
						num6 = -175077838;
					}
					num = num5 ^ (int)(num2 * 115618402);
					continue;
				}
				case 6u:
					num = ((int)num2 * -2009116994) ^ 0x35A88753;
					continue;
				case 5u:
					num = (int)(num2 * 630525672) ^ -320607037;
					continue;
				case 4u:
					securityInfos = (SecurityInfos)0;
					num = ((int)num2 * -323562105) ^ 0x193BCD3C;
					continue;
				case 3u:
					genericAcl_ = new DiscretionaryAcl(isContainer: false, isDS: false, rawSecurityDescriptor.DiscretionaryAcl);
					num = ((int)num2 * -566038079) ^ 0x117AA08E;
					continue;
				case 2u:
					if (rawSecurityDescriptor.SystemAcl != null)
					{
						num = ((int)num2 * -884756377) ^ -842658246;
						continue;
					}
					goto IL_026a;
				case 1u:
				{
					int num4;
					if (num3 != 6)
					{
						num = -1217346178;
						num4 = -1217346178;
					}
					else
					{
						num = -1592479011;
						num4 = -1592479011;
					}
					continue;
				}
				case 0u:
					num = (int)((num2 * 503514156) ^ 0x32561EA1);
					continue;
				default:
					return;
				case 70u:
					break;
				case 54u:
					throw ex;
				case 61u:
					return;
					IL_00fc:
					securityInfos = (SecurityInfos)num9;
					num = -555903534;
					continue;
					IL_02a3:
					securityInfos = (SecurityInfos)num14;
					num = -1160317620;
					continue;
					IL_026a:
					num = -1084264201;
					num10 = -1084264201;
					continue;
				}
				break;
			}
		}
	}

	internal static int smethod_16(ResourceType resourceType_0, string string_0, SafeHandle safeHandle_0, SecurityInfos securityInfos_0, SecurityIdentifier securityIdentifier_0, SecurityIdentifier securityIdentifier_1, GenericAcl genericAcl_0, GenericAcl genericAcl_1)
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_078e: Unknown result type (might be due to invalid IL or missing references)
		//IL_078f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0792: Expected I4, but got Unknown
		//IL_0793: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b1: Expected I4, but got Unknown
		//IL_07c8: Incompatible stack heights: 0 vs 1
		//IL_07d8: Incompatible stack heights: 0 vs 1
		//IL_07e8: Incompatible stack heights: 0 vs 1
		//IL_07f8: Incompatible stack heights: 0 vs 1
		//IL_07ff: Incompatible stack heights: 0 vs 1
		byte[] array2 = default(byte[]);
		int binaryLength = default(int);
		byte[] array3 = default(byte[]);
		bool flag8 = default(bool);
		bool flag9 = default(bool);
		byte[] array4 = default(byte[]);
		byte[] array = default(byte[]);
		GClass42 gClass = default(GClass42);
		bool flag = default(bool);
		bool flag2 = default(bool);
		int num12 = default(int);
		bool flag5 = default(bool);
		bool flag3 = default(bool);
		bool flag4 = default(bool);
		bool flag6 = default(bool);
		int result = default(int);
		bool flag7 = default(bool);
		while (true)
		{
			int num = -425813857;
			while (true)
			{
				int num23;
				uint num2;
				switch ((num2 = (uint)num ^ 0x9337AED8u) % 36u)
				{
				case 35u:
					array2 = new byte[binaryLength];
					num = ((int)num2 * -599489060) ^ 0x66942AA5;
					continue;
				case 34u:
					num = ((int)num2 * -505361237) ^ 0x141DB69A;
					continue;
				case 33u:
					binaryLength = genericAcl_0.BinaryLength;
					num = ((int)num2 * -711829290) ^ 0x2E0CC854;
					continue;
				case 32u:
					num = ((int)num2 * -354328910) ^ 0x553D985;
					continue;
				case 31u:
					array3 = new byte[binaryLength];
					genericAcl_1.GetBinaryForm(array3, 0);
					num = ((int)num2 * -527433207) ^ 0x657BE18F;
					continue;
				case 30u:
					((CodeAccessPermission)new SecurityPermission(SecurityPermissionFlag.UnmanagedCode)).Demand();
					num = ((int)num2 * -398456593) ^ -516374476;
					continue;
				case 29u:
					flag8 = securityIdentifier_1 != null;
					num = -578993672;
					continue;
				case 28u:
					flag9 = genericAcl_1 != null;
					num = -680171508;
					continue;
				case 27u:
					array3 = null;
					num = ((int)num2 * -655953745) ^ 0x3A441300;
					continue;
				case 26u:
					num = (int)((num2 * 1017008065) ^ 0x6ED67C1A);
					continue;
				case 24u:
					num = ((int)num2 * -1947180932) ^ 0x7E7631FF;
					continue;
				case 23u:
					binaryLength = securityIdentifier_0.BinaryLength;
					num = (int)(num2 * 579244725) ^ -1362053731;
					continue;
				case 22u:
					array4 = new byte[binaryLength];
					num = (int)((num2 * 899804970) ^ 0x4E2D40F3);
					continue;
				case 21u:
					num = (int)(num2 * 1560898547) ^ -22521739;
					continue;
				case 20u:
					num = (int)((num2 * 1194045335) ^ 0x7AA7D794);
					continue;
				case 19u:
				{
					int num32;
					int num33;
					if (!(securityIdentifier_0 != null))
					{
						num32 = 834924205;
						num33 = 834924205;
					}
					else
					{
						num32 = 452191684;
						num33 = 452191684;
					}
					num = num32 ^ ((int)num2 * -1843882044);
					continue;
				}
				case 18u:
					binaryLength = securityIdentifier_1.BinaryLength;
					num = ((int)num2 * -981261409) ^ -377939199;
					continue;
				case 16u:
				{
					int num31;
					if ((securityInfos_0 & SecurityInfos.SystemAcl) == 0)
					{
						num = -426320867;
						num31 = -426320867;
					}
					else
					{
						num = -1598405756;
						num31 = -1598405756;
					}
					continue;
				}
				case 15u:
					array2 = null;
					num = (int)((num2 * 225964260) ^ 0x1C4FB2CC);
					continue;
				case 14u:
					securityIdentifier_0.GetBinaryForm(array, 0);
					num = ((int)num2 * -670402071) ^ 0xB1AC2A4;
					continue;
				case 13u:
					securityIdentifier_1.GetBinaryForm(array2, 0);
					num = ((int)num2 * -1252923160) ^ -516421526;
					continue;
				case 12u:
					array4 = null;
					num = ((int)num2 * -1616746587) ^ -26142929;
					continue;
				case 11u:
					num = (int)(num2 * 1823934609) ^ -49456094;
					continue;
				case 10u:
					num = ((int)num2 * -1540537370) ^ 0x4583863D;
					continue;
				case 9u:
					binaryLength = genericAcl_1.BinaryLength;
					num = ((int)num2 * -267938853) ^ -221449328;
					continue;
				case 8u:
					gClass = new GClass42("SeSecurityPrivilege");
					num = ((int)num2 * -269856469) ^ -1919015319;
					continue;
				case 7u:
					genericAcl_0.GetBinaryForm(array4, 0);
					num = ((int)num2 * -1875216183) ^ 0x744EAC61;
					continue;
				case 6u:
					num = ((int)num2 * -1569265322) ^ -1741692205;
					continue;
				case 5u:
					gClass = null;
					num = ((int)num2 * -1111861780) ^ -522138066;
					continue;
				case 4u:
				{
					int num29;
					int num30;
					if (!flag9)
					{
						num29 = 566902145;
						num30 = 566902145;
					}
					else
					{
						num29 = 705753445;
						num30 = 705753445;
					}
					num = num29 ^ ((int)num2 * -371250573);
					continue;
				}
				case 3u:
					array = null;
					num = ((int)num2 * -799458315) ^ -1806384164;
					continue;
				case 2u:
					array = new byte[binaryLength];
					num = ((int)num2 * -1315338196) ^ 0xC0C3AFE;
					continue;
				case 1u:
				{
					int num28;
					if (genericAcl_0 != null)
					{
						num = -911529261;
						num28 = -911529261;
					}
					else
					{
						num = -1858368892;
						num28 = -1858368892;
					}
					continue;
				}
				case 0u:
				{
					int num26;
					int num27;
					if (flag8)
					{
						num26 = -1198301743;
						num27 = -1198301743;
					}
					else
					{
						num26 = -1824969104;
						num27 = -1824969104;
					}
					num = num26 ^ ((int)num2 * -1900714897);
					continue;
				}
				case 17u:
					break;
				default:
					{
						RuntimeHelpers.PrepareConstrainedRegions();
						try
						{
							while (true)
							{
								IL_0470:
								int num3 = -1020974455;
								while (true)
								{
									int num5;
									switch ((num2 = (uint)num3 ^ 0x9337AED8u) % 4u)
									{
									case 1u:
										flag = gClass != null;
										num3 = (int)((num2 * 1153611202) ^ 0x196E0B6A);
										continue;
									case 0u:
										if (flag)
										{
											num3 = (int)((num2 * 876253704) ^ 0x74B390DF);
											continue;
										}
										goto IL_066b;
									case 2u:
										break;
									default:
										{
											try
											{
												gClass.method_0();
												while (true)
												{
													IL_04ad:
													int num4 = -2035693929;
													while (true)
													{
														switch ((num2 = (uint)num4 ^ 0x9337AED8u) % 3u)
														{
														case 2u:
															goto IL_0481;
														default:
															goto end_IL_048f;
														case 0u:
															break;
														case 1u:
															goto end_IL_048f;
														}
														goto IL_04ad;
														IL_0481:
														num4 = ((int)num2 * -1228159441) ^ -693746958;
														continue;
														end_IL_048f:
														break;
													}
													break;
												}
											}
											catch (PrivilegeNotHeldException)
											{
											}
											goto IL_0749;
										}
										IL_066b:
										flag2 = string_0 != null;
										num5 = -1041803455;
										goto IL_06c6;
										IL_06c6:
										while (true)
										{
											int num8;
											int num9;
											switch ((num2 = (uint)num5 ^ 0x9337AED8u) % 28u)
											{
											case 27u:
												if (num12 != 1300)
												{
													num5 = -1629370022;
													continue;
												}
												num8 = 1;
												goto IL_04d3;
											case 26u:
												num9 = ((num12 == 1347) ? 1 : 0);
												goto IL_04e8;
											case 25u:
												flag5 = safeHandle_0 != null;
												num5 = -1546575293;
												continue;
											case 24u:
											{
												int num17;
												int num18;
												if (!safeHandle_0.IsInvalid)
												{
													num17 = 1495284768;
													num18 = 1495284768;
												}
												else
												{
													num17 = 1297265254;
													num18 = 1297265254;
												}
												num5 = num17 ^ (int)(num2 * 1768414476);
												continue;
											}
											case 23u:
												if (num12 != 5)
												{
													num5 = -1983340874;
													continue;
												}
												num9 = 1;
												goto IL_04e8;
											case 22u:
												num5 = -546974382;
												continue;
											case 21u:
											{
												int num10;
												int num11;
												if (!flag3)
												{
													num10 = 1423319862;
													num11 = 1423319862;
												}
												else
												{
													num10 = 1286874758;
													num11 = 1286874758;
												}
												num5 = num10 ^ ((int)num2 * -1838822143);
												continue;
											}
											case 20u:
												num12 = (int)Class17.SetNamedSecurityInfoW(string_0, (uint)resourceType_0, (uint)securityInfos_0, array, array2, array3, array4);
												num5 = (int)((num2 * 1636047463) ^ 0x48E87E9C);
												continue;
											case 19u:
											{
												int num15;
												int num16;
												if (flag5)
												{
													num15 = 207782612;
													num16 = 207782612;
												}
												else
												{
													num15 = 1495895206;
													num16 = 1495895206;
												}
												num5 = num15 ^ ((int)num2 * -1040039796);
												continue;
											}
											case 18u:
												num5 = ((int)num2 * -660396128) ^ 0x2F02C37D;
												continue;
											case 17u:
											{
												int num13;
												int num14;
												if (flag4)
												{
													num13 = -2115081018;
													num14 = -2115081018;
												}
												else
												{
													num13 = -375159124;
													num14 = -375159124;
												}
												num5 = num13 ^ ((int)num2 * -823874088);
												continue;
											}
											case 16u:
												num12 = (int)Class17.SetSecurityInfo(safeHandle_0, (uint)resourceType_0, (uint)securityInfos_0, array, array2, array3, array4);
												num5 = -68653035;
												continue;
											case 12u:
												break;
											case 10u:
												num8 = ((num12 == 1314) ? 1 : 0);
												goto IL_04d3;
											case 9u:
											{
												int num6;
												int num7;
												if (flag2)
												{
													num6 = 1642159250;
													num7 = 1642159250;
												}
												else
												{
													num6 = 231598087;
													num7 = 231598087;
												}
												num5 = num6 ^ (int)(num2 * 2076964394);
												continue;
											}
											case 7u:
												goto end_IL_06c6;
											case 6u:
												num5 = ((int)num2 * -1805178694) ^ 0x5D71E5B;
												continue;
											case 5u:
												num5 = (int)((num2 * 1539336963) ^ 0x24A16958);
												continue;
											case 4u:
												num5 = (int)((num2 * 651726127) ^ 0x5BAAC024);
												continue;
											case 1u:
												num5 = (int)(num2 * 429475963) ^ -1667499325;
												continue;
											case 0u:
												num5 = ((int)num2 * -1858793429) ^ -1637936910;
												continue;
											default:
												goto end_IL_044e;
											case 3u:
												goto IL_0749;
											case 2u:
												throw new InvalidProgramException();
											case 11u:
												throw new PrivilegeNotHeldException("SeSecurityPrivilege");
											case 13u:
												throw new UnauthorizedAccessException();
											case 14u:
												throw new ArgumentException("Invalid safe handle");
											case 15u:
												goto end_IL_044e;
											case 8u:
												goto IL_095f;
												IL_04d3:
												flag3 = (byte)num8 != 0;
												num5 = -552906007;
												continue;
												IL_04e8:
												flag4 = (byte)num9 != 0;
												num5 = -545309671;
												continue;
											}
											int num19;
											if (num12 != 0)
											{
												num5 = -552268147;
												num19 = -552268147;
											}
											else
											{
												num5 = -413722233;
												num19 = -413722233;
											}
											continue;
											end_IL_06c6:
											break;
										}
										goto IL_066b;
										IL_0749:
										num5 = -97132517;
										goto IL_06c6;
									}
									goto IL_0470;
									continue;
									end_IL_044e:
									break;
								}
								break;
							}
						}
						catch
						{
							if (gClass != null)
							{
								while (true)
								{
									_ = -518793802;
									while (true)
									{
										_003F val = /*Error near IL_078f: Stack underflow*/^ -1825067304;
										num2 = (uint)(int)val;
										switch (val % 6)
										{
										case 3:
											gClass.method_1();
											_ = (num2 * 82759090) ^ 0xFB03C833u;
											continue;
										case 2:
											_ = ((int)num2 * -1380632513) ^ 0x2FE3D98D;
											continue;
										case 1:
											_ = (num2 * 1779050746) ^ 0x1402328E;
											continue;
										case 0:
											_ = (num2 * 650617887) ^ 0xD6BC2606u;
											continue;
										case 5:
											break;
										default:
											goto end_IL_07fa;
										}
										break;
									}
									continue;
									end_IL_07fa:
									break;
								}
							}
							throw;
						}
						finally
						{
							while (true)
							{
								IL_08ae:
								int num20 = -1100012534;
								while (true)
								{
									switch ((num2 = (uint)num20 ^ 0x9337AED8u) % 7u)
									{
									case 6u:
										gClass.method_1();
										num20 = (int)(num2 * 145794864) ^ -273378819;
										continue;
									case 4u:
										num20 = ((int)num2 * -301914443) ^ -349551313;
										continue;
									case 3u:
										flag6 = gClass != null;
										num20 = ((int)num2 * -380034574) ^ 0x5D2B9401;
										continue;
									case 2u:
										num20 = ((int)num2 * -567895714) ^ -1562428426;
										continue;
									case 0u:
									{
										int num21;
										int num22;
										if (!flag6)
										{
											num21 = 1992496364;
											num22 = 1992496364;
										}
										else
										{
											num21 = 1060549461;
											num22 = 1060549461;
										}
										num20 = num21 ^ ((int)num2 * -724489284);
										continue;
									}
									default:
										goto end_IL_0880;
									case 5u:
										break;
									case 1u:
										goto end_IL_0880;
									}
									goto IL_08ae;
									continue;
									end_IL_0880:
									break;
								}
								break;
							}
						}
						result = 0;
						goto IL_08f1;
					}
					IL_095f:
					num23 = -2133965842;
					goto IL_0928;
					IL_0928:
					while (true)
					{
						switch ((num2 = (uint)num23 ^ 0x9337AED8u) % 9u)
						{
						case 8u:
							num23 = ((int)num2 * -352917538) ^ -919213603;
							continue;
						case 6u:
						{
							int num24;
							int num25;
							if (flag7)
							{
								num24 = 1287441250;
								num25 = 1287441250;
							}
							else
							{
								num24 = 1358978413;
								num25 = 1358978413;
							}
							num23 = num24 ^ (int)(num2 * 578893938);
							continue;
						}
						case 5u:
							break;
						case 4u:
							num23 = (int)(num2 * 726050034) ^ -1001092847;
							continue;
						case 3u:
							result = num12;
							num23 = -892716860;
							continue;
						case 1u:
							flag7 = num12 == 8;
							num23 = ((int)num2 * -164216613) ^ -1153638308;
							continue;
						case 0u:
							goto IL_095f;
						case 2u:
							throw new OutOfMemoryException();
						default:
							return result;
						}
						break;
					}
					goto IL_08f1;
					IL_08f1:
					num23 = -1659341154;
					goto IL_0928;
				}
				break;
			}
		}
	}

	public static bool smethod_17(string string_0)
	{
		Uri result2 = default(Uri);
		bool result = default(bool);
		while (true)
		{
			int num = -720093340;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0x8107EAB7u) % 7u)
				{
				case 6u:
					if (!string_0.StartsWith("\\\\?\\UNC\\", StringComparison.InvariantCultureIgnoreCase))
					{
						num = ((int)num2 * -543213785) ^ 0x57E5F783;
						continue;
					}
					num5 = 1;
					goto IL_0024;
				case 5u:
					num5 = (result2.IsUnc ? 1 : 0);
					goto IL_0024;
				case 3u:
					if (Uri.TryCreate(string_0, UriKind.Absolute, out result2))
					{
						num = -322178695;
						continue;
					}
					num5 = 0;
					goto IL_0024;
				case 2u:
				{
					int num3;
					int num4;
					if (!string.IsNullOrEmpty(string_0))
					{
						num3 = 673676948;
						num4 = 673676948;
					}
					else
					{
						num3 = 526537814;
						num4 = 526537814;
					}
					num = num3 ^ (int)(num2 * 12443920);
					continue;
				}
				case 0u:
					num = (int)((num2 * 752592625) ^ 0x4E109EF6);
					continue;
				case 4u:
					break;
				default:
					{
						return result;
					}
					IL_0024:
					result = (byte)num5 != 0;
					num = -1889546737;
					continue;
				}
				break;
			}
		}
	}

	public static bool smethod_18(string string_0)
	{
		if (!(string_0 == "."))
		{
			goto IL_001f;
		}
		int num = 1;
		goto IL_0050;
		IL_0050:
		bool result = (byte)num != 0;
		int num2 = 715646990;
		goto IL_0024;
		IL_001f:
		num2 = 1655025568;
		goto IL_0024;
		IL_0024:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x1828AD19u) % 4u)
			{
			case 3u:
				num2 = (int)((num3 * 2000244724) ^ 0x6C25BAA7);
				continue;
			case 0u:
				break;
			case 1u:
				goto IL_0045;
			default:
				return result;
			}
			break;
		}
		goto IL_001f;
		IL_0045:
		num = ((string_0 == "..") ? 1 : 0);
		goto IL_0050;
	}

	static GClass33()
	{
		while (true)
		{
			int num = 1891891889;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB4E248u) % 4u)
				{
				case 2u:
					uint_3 = 268435456u;
					num = ((int)num2 * -349614084) ^ -39759768;
					continue;
				case 1u:
					uint_1 = 1073741824u;
					uint_2 = 536870912u;
					num = ((int)num2 * -1204582353) ^ -1065724347;
					continue;
				default:
					return;
				case 3u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}
}
