using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using Microsoft.Win32.SafeHandles;

public static class GClass36
{
	internal const int int_0 = 4096;

	private static volatile Encoding encoding_0;

	internal static Encoding Encoding_0
	{
		get
		{
			bool flag = default(bool);
			Encoding result = default(Encoding);
			while (true)
			{
				int num = -649255400;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC40B980Eu) % 7u)
					{
					case 6u:
						flag = encoding_0 == null;
						num = (int)((num2 * 2126587741) ^ 0x4EB59A4);
						continue;
					case 5u:
						num = ((int)num2 * -1799263597) ^ 0x23CE8A51;
						continue;
					case 4u:
					{
						UTF8Encoding uTF8Encoding = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true);
						Thread.MemoryBarrier();
						encoding_0 = uTF8Encoding;
						num = (int)(num2 * 1042344269) ^ -1659378970;
						continue;
					}
					case 1u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -376315039;
							num4 = -376315039;
						}
						else
						{
							num3 = -1728572102;
							num4 = -1728572102;
						}
						num = num3 ^ ((int)num2 * -81909108);
						continue;
					}
					case 0u:
						result = encoding_0;
						num = -1795521558;
						continue;
					case 3u:
						break;
					default:
						return result;
					}
					break;
				}
			}
		}
	}

	public static StreamReader smethod_0(string string_0)
	{
		FileStream stream = smethod_17(string_0, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, FileOptions.SequentialScan);
		StreamReader result = new StreamReader(stream, Encoding.UTF8, detectEncodingFromByteOrderMarks: true, 1024);
		while (true)
		{
			int num = -997402917;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC3720FC3u) % 3u)
				{
				case 1u:
					goto IL_0028;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_0028:
				num = (int)(num2 * 734484954) ^ -1177587801;
			}
		}
	}

	private static StreamReader smethod_1(string string_0, Encoding encoding_1)
	{
		StreamReader result = default(StreamReader);
		FileStream stream = default(FileStream);
		while (true)
		{
			int num = -1235343796;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE59BA33Bu) % 5u)
				{
				case 3u:
					result = new StreamReader(stream, encoding_1, detectEncodingFromByteOrderMarks: true, 1024);
					num = (int)(num2 * 1111167537) ^ -2129751164;
					continue;
				case 2u:
					stream = smethod_17(string_0, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, FileOptions.SequentialScan);
					num = ((int)num2 * -760603987) ^ 0x109DF7FF;
					continue;
				case 1u:
					num = ((int)num2 * -694348976) ^ -596780465;
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

	public static StreamWriter smethod_2(string string_0)
	{
		FileStream stream = default(FileStream);
		StreamWriter result = default(StreamWriter);
		while (true)
		{
			int num = 968785501;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x40E63328u) % 4u)
				{
				case 1u:
					stream = smethod_17(string_0, FileMode.Create, FileAccess.Write, FileShare.Read, 4096, FileOptions.SequentialScan);
					num = (int)((num2 * 354290311) ^ 0x4291DCCF);
					continue;
				case 0u:
					result = new StreamWriter(stream, Encoding_0, 4096);
					num = (int)((num2 * 1717644677) ^ 0x25A8DC7);
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

	public static StreamWriter smethod_3(string string_0)
	{
		StreamWriter result = default(StreamWriter);
		while (true)
		{
			int num = -637086502;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBFF44E9Bu) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0003:
				result = smethod_61(string_0, bool_0: true);
				num = ((int)num2 * -1590980930) ^ -1223412691;
			}
		}
	}

	public static void smethod_4(string string_0, string string_1)
	{
		smethod_5(string_0, string_1, bool_0: false);
	}

	public static void smethod_5(string string_0, string string_1, bool bool_0)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = 1966819671;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x28812A20u) % 5u)
				{
				case 2u:
				{
					string string_2 = GClass41.smethod_1(string_0, "sourcePath");
					string string_3 = GClass41.smethod_1(string_1, "destinationPath");
					flag = !Class17.CopyFile(string_2, string_3, !bool_0);
					num = ((int)num2 * -160763235) ^ 0x6ABB8404;
					continue;
				}
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 991966397;
						num4 = 991966397;
					}
					else
					{
						num3 = 1387071276;
						num4 = 1387071276;
					}
					num = num3 ^ (int)(num2 * 874508864);
					continue;
				}
				default:
					return;
				case 4u:
					break;
				case 0u:
					throw GClass33.smethod_8();
				case 3u:
					return;
				}
				break;
			}
		}
	}

	public static FileStream smethod_6(string string_0)
	{
		FileStream result = default(FileStream);
		while (true)
		{
			int num = -658640212;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCFD5E996u) % 3u)
				{
				case 2u:
					goto IL_0003;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0003:
				result = smethod_7(string_0, 4096);
				num = (int)(num2 * 994891416) ^ -1798014666;
			}
		}
	}

	public static FileStream smethod_7(string string_0, int int_1)
	{
		FileStream result = default(FileStream);
		while (true)
		{
			int num = 991110041;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2143E1EFu) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_0003:
				result = smethod_17(string_0, FileMode.Create, FileAccess.ReadWrite, FileShare.None, int_1, FileOptions.None);
				num = (int)(num2 * 1719053232) ^ -1159097574;
			}
		}
	}

	public static FileStream smethod_8(string string_0, int int_1, FileOptions fileOptions_0)
	{
		FileStream result = smethod_17(string_0, FileMode.Create, FileAccess.ReadWrite, FileShare.None, int_1, fileOptions_0);
		while (true)
		{
			int num = -1891569579;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x83A48500u) % 3u)
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
				num = (int)(num2 * 1861208656) ^ -828286101;
			}
		}
	}

	public static FileStream smethod_9(string string_0, int int_1, FileOptions fileOptions_0, FileSecurity fileSecurity_0)
	{
		FileStream fileStream = smethod_8(string_0, int_1, fileOptions_0);
		fileStream.SetAccessControl(fileSecurity_0);
		FileStream result = default(FileStream);
		while (true)
		{
			int num = -609622632;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA5CCE6FDu) % 3u)
				{
				case 1u:
					goto IL_0012;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0012:
				result = fileStream;
				num = (int)((num2 * 197978052) ^ 0x66D0667F);
			}
		}
	}

	public static void smethod_10(string string_0)
	{
		string string_ = GClass41.smethod_0(string_0);
		bool flag = default(bool);
		while (true)
		{
			int num = -1054280004;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA61F84F6u) % 6u)
				{
				case 5u:
					num = ((int)num2 * -1381131446) ^ -112918857;
					continue;
				case 4u:
					flag = !Class17.DeleteFile(string_);
					num = (int)(num2 * 916461191) ^ -377888564;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 136384571;
						num4 = 136384571;
					}
					else
					{
						num3 = 625003912;
						num4 = 625003912;
					}
					num = num3 ^ (int)(num2 * 813405617);
					continue;
				}
				default:
					return;
				case 3u:
					break;
				case 1u:
					throw GClass33.smethod_8();
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public static void smethod_11(string string_0)
	{
		string text2 = default(string);
		string text = default(string);
		bool flag2 = default(bool);
		int lastWin32Error = default(int);
		bool flag = default(bool);
		DriveInfo driveInfo = default(DriveInfo);
		while (true)
		{
			int num = 984153876;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6AC318F1u) % 15u)
				{
				case 14u:
					text2 = GClass41.smethod_0(text);
					flag2 = Class17.DecryptFile(text2, 0);
					num = ((int)num2 * -1937799672) ^ -878803958;
					continue;
				case 13u:
					num = (int)(num2 * 2017031827) ^ -969365500;
					continue;
				case 12u:
					lastWin32Error = Marshal.GetLastWin32Error();
					flag = lastWin32Error == 5;
					num = 1146721840;
					continue;
				case 11u:
					num = 800722899;
					continue;
				case 10u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = -857399974;
						num6 = -857399974;
					}
					else
					{
						num5 = -1110062125;
						num6 = -1110062125;
					}
					num = num5 ^ ((int)num2 * -1440431104);
					continue;
				}
				case 9u:
					num = ((int)num2 * -1222019426) ^ -1631507483;
					continue;
				case 8u:
				{
					int num7;
					int num8;
					if (!flag2)
					{
						num7 = 733418298;
						num8 = 733418298;
					}
					else
					{
						num7 = 1553612257;
						num8 = 1553612257;
					}
					num = num7 ^ ((int)num2 * -902852243);
					continue;
				}
				case 7u:
					GClass33.smethod_13(lastWin32Error, text);
					num = 1808828313;
					continue;
				case 5u:
					driveInfo = new DriveInfo(GClass41.smethod_21(text2));
					num = ((int)num2 * -1387663621) ^ 0x1FA82783;
					continue;
				case 4u:
					num = ((int)num2 * -361811460) ^ -1986486472;
					continue;
				case 2u:
					text = GClass41.smethod_13(string_0);
					num = ((int)num2 * -1228282528) ^ -1116357821;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!string.Equals("NTFS", driveInfo.DriveFormat))
					{
						num3 = -1565893500;
						num4 = -1565893500;
					}
					else
					{
						num3 = -1104841681;
						num4 = -1104841681;
					}
					num = num3 ^ ((int)num2 * -1276637098);
					continue;
				}
				default:
					return;
				case 3u:
					break;
				case 1u:
					throw new NotSupportedException("NTFS drive required for file encryption");
				case 6u:
					return;
				}
				break;
			}
		}
	}

	public static void smethod_12(string string_0)
	{
		int lastWin32Error = default(int);
		string text2 = default(string);
		string text = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num = 570755521;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4636FE33u) % 13u)
				{
				case 12u:
				{
					int num5;
					int num6;
					if (lastWin32Error == 5)
					{
						num5 = -1775874741;
						num6 = -1775874741;
					}
					else
					{
						num5 = -89769628;
						num6 = -89769628;
					}
					num = num5 ^ (int)(num2 * 1699518688);
					continue;
				}
				case 10u:
					num = ((int)num2 * -1430992246) ^ 0x7D5DBBBD;
					continue;
				case 9u:
				{
					DriveInfo driveInfo = new DriveInfo(GClass41.smethod_21(text2));
					int num7;
					int num8;
					if (string.Equals("NTFS", driveInfo.DriveFormat))
					{
						num7 = 1716330914;
						num8 = 1716330914;
					}
					else
					{
						num7 = 1350352382;
						num8 = 1350352382;
					}
					num = num7 ^ ((int)num2 * -1548105515);
					continue;
				}
				case 8u:
					text2 = GClass41.smethod_0(text);
					num = (int)(num2 * 464105827) ^ -572582187;
					continue;
				case 6u:
					GClass33.smethod_13(lastWin32Error, text);
					num = 1272594565;
					continue;
				case 5u:
					lastWin32Error = Marshal.GetLastWin32Error();
					num = 136402337;
					continue;
				case 4u:
					flag = Class17.EncryptFile(text2);
					num = ((int)num2 * -535097916) ^ -445712894;
					continue;
				case 3u:
					num = 290125476;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -718702162;
						num4 = -718702162;
					}
					else
					{
						num3 = -11433686;
						num4 = -11433686;
					}
					num = num3 ^ (int)(num2 * 687880253);
					continue;
				}
				case 1u:
					text = GClass41.smethod_13(string_0);
					num = ((int)num2 * -1943498253) ^ -1065115711;
					continue;
				default:
					return;
				case 11u:
					break;
				case 7u:
					throw new NotSupportedException("NTFS drive required for file encryption");
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public static bool smethod_13(string string_0)
	{
		bool flag = default(bool);
		bool bool_ = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = 1232896572;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7BCF0462u) % 9u)
				{
				case 8u:
					num = (int)((num2 * 795559818) ^ 0x2375B7B4);
					continue;
				case 7u:
					flag = GClass33.smethod_5(string_0, out bool_);
					num = (int)(num2 * 623028443) ^ -70865341;
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -178854515;
						num4 = -178854515;
					}
					else
					{
						num3 = -938208205;
						num4 = -938208205;
					}
					num = num3 ^ ((int)num2 * -122238783);
					continue;
				}
				case 5u:
					result = !bool_;
					num = ((int)num2 * -1679499194) ^ -1604050431;
					continue;
				case 3u:
					result = false;
					num = 2067275354;
					continue;
				case 2u:
					num = ((int)num2 * -1307768562) ^ -1877515849;
					continue;
				case 1u:
					num = ((int)num2 * -167309989) ^ -61233517;
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

	public static FileStream smethod_14(string string_0, FileMode fileMode_0)
	{
		FileStream result = smethod_16(string_0, fileMode_0, (fileMode_0 == FileMode.Append) ? FileAccess.Write : FileAccess.ReadWrite, FileShare.None);
		while (true)
		{
			int num = -729479473;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAEC1F366u) % 3u)
				{
				case 1u:
					goto IL_0013;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_0013:
				num = (int)(num2 * 160016197) ^ -1334116900;
			}
		}
	}

	public static FileStream smethod_15(string string_0, FileMode fileMode_0, FileAccess fileAccess_0)
	{
		return smethod_17(string_0, fileMode_0, fileAccess_0, FileShare.None, 0, FileOptions.None);
	}

	public static FileStream smethod_16(string string_0, FileMode fileMode_0, FileAccess fileAccess_0, FileShare fileShare_0)
	{
		FileStream result = default(FileStream);
		while (true)
		{
			int num = 1242566566;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x67D7A4E7u) % 4u)
				{
				case 3u:
					num = (int)((num2 * 1705103651) ^ 0x28C7D616);
					continue;
				case 1u:
					result = smethod_17(string_0, fileMode_0, fileAccess_0, fileShare_0, 0, FileOptions.None);
					num = ((int)num2 * -108022145) ^ -802432181;
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

	internal static FileStream smethod_17(string string_0, FileMode fileMode_0, FileAccess fileAccess_0, FileShare fileShare_0, int int_1, FileOptions fileOptions_0)
	{
		if (int_1 == 0)
		{
			goto IL_0030;
		}
		goto IL_005b;
		IL_005b:
		string string_ = GClass41.smethod_0(string_0);
		SafeFileHandle handle = smethod_59(string_, fileMode_0, fileAccess_0, fileShare_0, fileOptions_0);
		FileStream result = new FileStream(handle, fileAccess_0, int_1, (fileOptions_0 & FileOptions.Asynchronous) == FileOptions.Asynchronous);
		int num = 1170463641;
		goto IL_0035;
		IL_0035:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x552E99C7u) % 5u)
			{
			case 3u:
				num = (int)((num2 * 1164934570) ^ 0x34E0C84);
				continue;
			case 1u:
				int_1 = 1024;
				num = (int)((num2 * 1041033076) ^ 0x176031A5);
				continue;
			case 0u:
				break;
			case 4u:
				goto IL_005b;
			default:
				return result;
			}
			break;
		}
		goto IL_0030;
		IL_0030:
		num = 628755938;
		goto IL_0035;
	}

	public static void smethod_18(string string_0, DateTime dateTime_0)
	{
		while (true)
		{
			int num = 854595256;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x263956C7u) % 4u)
				{
				case 3u:
					smethod_19(string_0, dateTime_0.ToUniversalTime());
					num = (int)(num2 * 802810526) ^ -1300932193;
					continue;
				case 2u:
					num = ((int)num2 * -678660177) ^ 0x4FF00D94;
					continue;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	public unsafe static void smethod_19(string string_0, DateTime dateTime_0)
	{
		string string_ = default(string);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -1775812577;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8E0F17B7u) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 2u:
					break;
				default:
				{
					SafeFileHandle safeFileHandle = smethod_59(string_, FileMode.Open, FileAccess.Write, FileShare.ReadWrite, FileOptions.None);
					try
					{
						Class17.Struct7 @struct = new Class17.Struct7(dateTime_0.ToFileTimeUtc());
						bool flag = Class17.SetFileTime(safeFileHandle, &@struct, null, null);
						while (true)
						{
							int num3 = -1077608694;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x8E0F17B7u) % 8u)
								{
								case 7u:
									num3 = ((int)num2 * -1920618357) ^ -260046816;
									continue;
								case 5u:
									flag2 = !flag;
									num3 = (int)((num2 * 2082538594) ^ 0x3F5E745);
									continue;
								case 3u:
									num3 = ((int)num2 * -1049937140) ^ -510573833;
									continue;
								case 2u:
								{
									int lastWin32Error = Marshal.GetLastWin32Error();
									GClass33.smethod_13(lastWin32Error, string_0);
									num3 = (int)(num2 * 1459816374) ^ -116058174;
									continue;
								}
								case 1u:
									num3 = ((int)num2 * -1786957029) ^ 0x5E62F88F;
									continue;
								case 0u:
								{
									int num4;
									int num5;
									if (flag2)
									{
										num4 = -1545081680;
										num5 = -1545081680;
									}
									else
									{
										num4 = -1880055605;
										num5 = -1880055605;
									}
									num3 = num4 ^ ((int)num2 * -1397812685);
									continue;
								}
								default:
									return;
								case 6u:
									break;
								case 4u:
									return;
								}
								break;
							}
						}
					}
					finally
					{
						if (safeFileHandle != null)
						{
							while (true)
							{
								IL_0178:
								int num6 = -38031022;
								while (true)
								{
									switch ((num2 = (uint)num6 ^ 0x8E0F17B7u) % 4u)
									{
									case 2u:
										num6 = ((int)num2 * -1771891192) ^ 0x1C74137C;
										continue;
									case 1u:
										((IDisposable)safeFileHandle).Dispose();
										num6 = ((int)num2 * -1996745940) ^ -1330305243;
										continue;
									default:
										goto end_IL_0156;
									case 0u:
										break;
									case 3u:
										goto end_IL_0156;
									}
									goto IL_0178;
									continue;
									end_IL_0156:
									break;
								}
								break;
							}
						}
					}
				}
				}
				break;
				IL_0003:
				string_ = GClass41.smethod_0(string_0);
				num = ((int)num2 * -612723425) ^ 0x33232B20;
			}
		}
	}

	public static DateTime smethod_20(string string_0)
	{
		DateTime dateTime = smethod_21(string_0);
		DateTime result = default(DateTime);
		while (true)
		{
			int num = 276100344;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3EB7AF41u) % 3u)
				{
				case 1u:
					goto IL_0009;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_0009:
				result = dateTime.ToLocalTime();
				num = (int)(num2 * 1026760584) ^ -946154376;
			}
		}
	}

	public static DateTime smethod_21(string string_0)
	{
		GClass39 gClass = default(GClass39);
		DateTime dateTime_ = default(DateTime);
		while (true)
		{
			int num = 1301634444;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x46EFD592u) % 5u)
				{
				case 4u:
					gClass = new GClass39(string_0);
					num = ((int)num2 * -655801122) ^ -185908433;
					continue;
				case 2u:
					dateTime_ = gClass.DateTime_1;
					num = ((int)num2 * -1572234753) ^ -521417620;
					continue;
				case 0u:
					num = ((int)num2 * -954325932) ^ 0x6BFC9D93;
					continue;
				case 3u:
					break;
				default:
					return dateTime_;
				}
				break;
			}
		}
	}

	public static void smethod_22(string string_0, DateTime dateTime_0)
	{
		while (true)
		{
			int num = -162714932;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEF980956u) % 4u)
				{
				case 2u:
					smethod_23(string_0, dateTime_0.ToUniversalTime());
					num = ((int)num2 * -1122238451) ^ 0x2122F441;
					continue;
				case 1u:
					num = ((int)num2 * -1337788279) ^ 0x491547CB;
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

	public unsafe static void smethod_23(string string_0, DateTime dateTime_0)
	{
		string string_ = default(string);
		int lastWin32Error = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -2126822545;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8ED3A6A4u) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 0u:
					break;
				default:
				{
					SafeFileHandle safeFileHandle = smethod_59(string_, FileMode.Open, FileAccess.Write, FileShare.ReadWrite, FileOptions.None);
					try
					{
						while (true)
						{
							int num3 = -1859531817;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x8ED3A6A4u) % 8u)
								{
								case 7u:
									lastWin32Error = Marshal.GetLastWin32Error();
									num3 = (int)(num2 * 1935092592) ^ -524591860;
									continue;
								case 6u:
									num3 = (int)((num2 * 1136945430) ^ 0x649C85DF);
									continue;
								case 5u:
								{
									int num4;
									int num5;
									if (flag)
									{
										num4 = 2003098609;
										num5 = 2003098609;
									}
									else
									{
										num4 = 992412798;
										num5 = 992412798;
									}
									num3 = num4 ^ ((int)num2 * -1008813009);
									continue;
								}
								case 4u:
									num3 = ((int)num2 * -1038014607) ^ 0x50F51549;
									continue;
								case 3u:
								{
									Class17.Struct7 @struct = new Class17.Struct7(dateTime_0.ToFileTimeUtc());
									flag = !Class17.SetFileTime(safeFileHandle, null, null, &@struct);
									num3 = ((int)num2 * -735114707) ^ 0x35989D1E;
									continue;
								}
								case 0u:
									GClass33.smethod_13(lastWin32Error, string_0);
									num3 = (int)(num2 * 675251046) ^ -665228576;
									continue;
								default:
									return;
								case 2u:
									break;
								case 1u:
									return;
								}
								break;
							}
						}
					}
					finally
					{
						if (safeFileHandle != null)
						{
							while (true)
							{
								IL_017a:
								int num6 = -1687682579;
								while (true)
								{
									switch ((num2 = (uint)num6 ^ 0x8ED3A6A4u) % 4u)
									{
									case 3u:
										num6 = (int)((num2 * 1295322333) ^ 0x3ED3D625);
										continue;
									case 1u:
										((IDisposable)safeFileHandle).Dispose();
										num6 = ((int)num2 * -1004897719) ^ 0x63040096;
										continue;
									default:
										goto end_IL_0158;
									case 0u:
										break;
									case 2u:
										goto end_IL_0158;
									}
									goto IL_017a;
									continue;
									end_IL_0158:
									break;
								}
								break;
							}
						}
					}
				}
				}
				break;
				IL_0003:
				string_ = GClass41.smethod_0(string_0);
				num = (int)(num2 * 2134849245) ^ -1463834406;
			}
		}
	}

	public static DateTime smethod_24(string string_0)
	{
		DateTime dateTime = default(DateTime);
		DateTime result = default(DateTime);
		while (true)
		{
			int num = -890180772;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE209480Eu) % 5u)
				{
				case 4u:
					dateTime = smethod_25(string_0);
					num = (int)(num2 * 1912081395) ^ -1284107968;
					continue;
				case 2u:
					num = ((int)num2 * -1890688358) ^ -1061145509;
					continue;
				case 0u:
					result = dateTime.ToLocalTime();
					num = ((int)num2 * -1941737574) ^ -139642474;
					continue;
				case 3u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	public static DateTime smethod_25(string string_0)
	{
		GClass39 gClass = new GClass39(string_0);
		DateTime dateTime_ = default(DateTime);
		while (true)
		{
			int num = 1377529980;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7AAC282u) % 3u)
				{
				case 1u:
					goto IL_0009;
				case 0u:
					break;
				default:
					return dateTime_;
				}
				break;
				IL_0009:
				dateTime_ = gClass.DateTime_3;
				num = ((int)num2 * -1253960076) ^ -2077260598;
			}
		}
	}

	public static void smethod_26(string string_0, DateTime dateTime_0)
	{
		while (true)
		{
			int num = -1041456038;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9EDBAF8Bu) % 3u)
				{
				case 1u:
					goto IL_0003;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0003:
				smethod_27(string_0, dateTime_0.ToUniversalTime());
				num = (int)(num2 * 1427346839) ^ -2027743560;
			}
		}
	}

	public unsafe static void smethod_27(string string_0, DateTime dateTime_0)
	{
		string string_ = GClass41.smethod_0(string_0);
		SafeFileHandle safeFileHandle = smethod_59(string_, FileMode.Open, FileAccess.Write, FileShare.ReadWrite, FileOptions.None);
		try
		{
			Class17.Struct7 @struct = new Class17.Struct7(dateTime_0.ToFileTimeUtc());
			bool flag = Class17.SetFileTime(safeFileHandle, null, &@struct, null);
			bool flag2 = default(bool);
			int lastWin32Error = default(int);
			while (true)
			{
				int num = 1728378286;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1E716404u) % 7u)
					{
					case 6u:
						flag2 = !flag;
						num = (int)(num2 * 200947726) ^ -211387415;
						continue;
					case 4u:
						lastWin32Error = Marshal.GetLastWin32Error();
						num = ((int)num2 * -1384292564) ^ -1175336066;
						continue;
					case 3u:
						num = ((int)num2 * -1467472773) ^ 0x3425DE97;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (!flag2)
						{
							num3 = -1211641438;
							num4 = -1211641438;
						}
						else
						{
							num3 = -1705774988;
							num4 = -1705774988;
						}
						num = num3 ^ (int)(num2 * 1393065552);
						continue;
					}
					case 0u:
						GClass33.smethod_13(lastWin32Error, string_0);
						num = (int)((num2 * 619324101) ^ 0x70B9A7F9);
						continue;
					default:
						return;
					case 5u:
						break;
					case 2u:
						return;
					}
					break;
				}
			}
		}
		finally
		{
			if (safeFileHandle != null)
			{
				while (true)
				{
					IL_012e:
					int num5 = 293955343;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num5 ^ 0x1E716404u) % 4u)
						{
						case 3u:
							((IDisposable)safeFileHandle).Dispose();
							num5 = (int)((num2 * 259155153) ^ 0x4E0C9252);
							continue;
						case 1u:
							num5 = ((int)num2 * -1151731869) ^ -1150523975;
							continue;
						default:
							goto end_IL_010c;
						case 0u:
							break;
						case 2u:
							goto end_IL_010c;
						}
						goto IL_012e;
						continue;
						end_IL_010c:
						break;
					}
					break;
				}
			}
		}
	}

	public static DateTime smethod_28(string string_0)
	{
		DateTime dateTime = smethod_29(string_0);
		DateTime result = default(DateTime);
		while (true)
		{
			int num = -566457037;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD2A95982u) % 3u)
				{
				case 1u:
					goto IL_0009;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_0009:
				result = dateTime.ToLocalTime();
				num = (int)((num2 * 1831762307) ^ 0x3BCC3EE7);
			}
		}
	}

	public static DateTime smethod_29(string string_0)
	{
		GClass39 gClass = new GClass39(string_0);
		DateTime dateTime_ = default(DateTime);
		while (true)
		{
			int num = 1862163890;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1CFD365Bu) % 3u)
				{
				case 1u:
					goto IL_0009;
				case 0u:
					break;
				default:
					return dateTime_;
				}
				break;
				IL_0009:
				dateTime_ = gClass.DateTime_5;
				num = (int)(num2 * 276433353) ^ -1390104706;
			}
		}
	}

	public static FileAttributes smethod_30(string string_0)
	{
		FileAttributes result = default(FileAttributes);
		while (true)
		{
			int num = 1731793608;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7A8794C5u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -1797210758) ^ -669204478;
					continue;
				case 1u:
					result = GClass33.smethod_3(string_0);
					num = ((int)num2 * -1250131986) ^ 0x4F6BB531;
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

	public static void smethod_31(string string_0, FileAttributes fileAttributes_0)
	{
		while (true)
		{
			int num = 323737334;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4925E7B9u) % 4u)
				{
				case 3u:
					GClass33.smethod_0(string_0, fileAttributes_0);
					num = (int)(num2 * 268723650) ^ -522214225;
					continue;
				case 0u:
					num = ((int)num2 * -992984815) ^ -1890856816;
					continue;
				default:
					return;
				case 2u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	public static FileStream smethod_32(string string_0)
	{
		FileStream result = smethod_16(string_0, FileMode.Open, FileAccess.Read, FileShare.Read);
		while (true)
		{
			int num = -553729599;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA8814812u) % 3u)
				{
				case 2u:
					goto IL_000c;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_000c:
				num = ((int)num2 * -881406931) ^ -773410738;
			}
		}
	}

	public static FileStream smethod_33(string string_0)
	{
		FileStream result = smethod_16(string_0, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
		while (true)
		{
			int num = -1606821504;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBBE8A896u) % 3u)
				{
				case 2u:
					goto IL_000c;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_000c:
				num = (int)((num2 * 2057127200) ^ 0xF14D938);
			}
		}
	}

	public static string smethod_34(string string_0)
	{
		bool flag = string_0 == null;
		string result = default(string);
		while (true)
		{
			int num = 529155943;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6BC4177Eu) % 6u)
				{
				case 5u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 836473807;
						num4 = 836473807;
					}
					else
					{
						num3 = 1741259576;
						num4 = 1741259576;
					}
					num = num3 ^ (int)(num2 * 65889129);
					continue;
				}
				case 3u:
					result = smethod_35(string_0, Encoding.UTF8);
					num = 602434726;
					continue;
				case 2u:
					num = (int)(num2 * 821898270) ^ -1791323995;
					continue;
				case 0u:
					break;
				case 4u:
					throw new ArgumentNullException("path");
				default:
					return result;
				}
				break;
			}
		}
	}

	public static string smethod_35(string string_0, Encoding encoding_1)
	{
		StreamReader streamReader = smethod_1(string_0, encoding_1);
		try
		{
			return streamReader.ReadToEnd();
		}
		finally
		{
			if (streamReader != null)
			{
				while (true)
				{
					IL_0059:
					int num = 526577354;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x5949FE99u) % 4u)
						{
						case 3u:
							((IDisposable)streamReader).Dispose();
							num = ((int)num2 * -1131566043) ^ 0x3561A0A8;
							continue;
						case 2u:
							num = ((int)num2 * -1892139962) ^ 0x3EEB0200;
							continue;
						default:
							goto end_IL_0038;
						case 0u:
							break;
						case 1u:
							goto end_IL_0038;
						}
						goto IL_0059;
						continue;
						end_IL_0038:
						break;
					}
					break;
				}
			}
		}
	}

	public static void smethod_36(string string_0, string string_1)
	{
		while (true)
		{
			int num = 681934741;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6A2AEB6Cu) % 4u)
				{
				case 1u:
					smethod_37(string_0, string_1, Encoding_0);
					num = ((int)num2 * -1148290209) ^ 0x64C96E2F;
					continue;
				case 0u:
					num = (int)((num2 * 408910343) ^ 0x795F255F);
					continue;
				default:
					return;
				case 2u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	public static void smethod_37(string string_0, string string_1, Encoding encoding_1)
	{
		StreamWriter streamWriter = smethod_62(string_0, bool_0: false, encoding_1);
		try
		{
			while (true)
			{
				int num = -1560992835;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD4FBE3DAu) % 3u)
					{
					case 1u:
						goto IL_000c;
					default:
						return;
					case 0u:
						break;
					case 2u:
						return;
					}
					break;
					IL_000c:
					streamWriter.Write(string_1);
					num = ((int)num2 * -1438068120) ^ 0x35A7A42D;
				}
			}
		}
		finally
		{
			if (streamWriter != null)
			{
				while (true)
				{
					IL_008e:
					int num3 = -1442013616;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xD4FBE3DAu) % 4u)
						{
						case 3u:
							num3 = (int)(num2 * 866289075) ^ -374057162;
							continue;
						case 2u:
							((IDisposable)streamWriter).Dispose();
							num3 = (int)((num2 * 1804108318) ^ 0x667F2E81);
							continue;
						default:
							goto end_IL_006d;
						case 0u:
							break;
						case 1u:
							goto end_IL_006d;
						}
						goto IL_008e;
						continue;
						end_IL_006d:
						break;
					}
					break;
				}
			}
		}
	}

	public static byte[] smethod_38(string string_0)
	{
		FileStream fileStream = smethod_16(string_0, FileMode.Open, FileAccess.Read, FileShare.Read);
		try
		{
			long num = fileStream.Length;
			int num5 = default(int);
			byte[] array = default(byte[]);
			int num4 = default(int);
			byte[] result = default(byte[]);
			while (true)
			{
				int num2 = 992136667;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num2 ^ 0x6650E4D8u) % 16u)
					{
					case 15u:
					{
						int num8;
						if (num <= 0L)
						{
							num2 = 1430672543;
							num8 = 1430672543;
						}
						else
						{
							num2 = 1483005581;
							num8 = 1483005581;
						}
						continue;
					}
					case 13u:
						num2 = ((int)num3 * -2062685875) ^ 0x4049F3D7;
						continue;
					case 11u:
					{
						num5 = fileStream.Read(array, num4, (int)num);
						int num9;
						int num10;
						if (num5 == 0)
						{
							num9 = -2021938300;
							num10 = -2021938300;
						}
						else
						{
							num9 = -1657380693;
							num10 = -1657380693;
						}
						num2 = num9 ^ (int)(num3 * 416398259);
						continue;
					}
					case 10u:
						array = new byte[num];
						num2 = 1760476928;
						continue;
					case 9u:
						num2 = (int)((num3 * 1494581080) ^ 0x392202FF);
						continue;
					case 8u:
						num4 = 0;
						num2 = (int)((num3 * 916991877) ^ 0x55AFC0F1);
						continue;
					case 7u:
						result = array;
						num2 = (int)((num3 * 808136244) ^ 0x39554238);
						continue;
					case 5u:
						num2 = 999876755;
						continue;
					case 4u:
						num -= num5;
						num2 = (int)(num3 * 950462252) ^ -805836239;
						continue;
					case 3u:
					{
						int num6;
						int num7;
						if (num <= 2147483647L)
						{
							num6 = -1259037763;
							num7 = -1259037763;
						}
						else
						{
							num6 = -1737167303;
							num7 = -1737167303;
						}
						num2 = num6 ^ ((int)num3 * -207320091);
						continue;
					}
					case 2u:
						num4 += num5;
						num2 = 1853799852;
						continue;
					case 1u:
						num2 = (int)((num3 * 2128700635) ^ 0x70EFCEEC);
						continue;
					case 0u:
						break;
					case 6u:
						throw new EndOfStreamException("Read beyond end of file.");
					case 14u:
						throw new IOException("File length greater than 2GB.");
					default:
						return result;
					case 12u:
						return result;
					}
					break;
				}
			}
		}
		finally
		{
			if (fileStream != null)
			{
				while (true)
				{
					IL_01fd:
					int num11 = 393896102;
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)num11 ^ 0x6650E4D8u) % 4u)
						{
						case 3u:
							num11 = ((int)num3 * -1909689480) ^ -632526539;
							continue;
						case 2u:
							((IDisposable)fileStream).Dispose();
							num11 = ((int)num3 * -1164953216) ^ 0x3298A3E7;
							continue;
						default:
							goto end_IL_01db;
						case 0u:
							break;
						case 1u:
							goto end_IL_01db;
						}
						goto IL_01fd;
						continue;
						end_IL_01db:
						break;
					}
					break;
				}
			}
		}
	}

	public static void smethod_39(string string_0, byte[] byte_0)
	{
		FileStream fileStream = smethod_16(string_0, FileMode.Create, FileAccess.Write, FileShare.Read);
		try
		{
			while (true)
			{
				int num = 282430164;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x12D90266u) % 4u)
					{
					case 3u:
						num = (int)((num2 * 897747029) ^ 0x29F3DA30);
						continue;
					case 2u:
						fileStream.Write(byte_0, 0, byte_0.Length);
						num = ((int)num2 * -2101705098) ^ 0x645F019;
						continue;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
					}
					break;
				}
			}
		}
		finally
		{
			if (fileStream != null)
			{
				while (true)
				{
					IL_0093:
					int num3 = 821880202;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x12D90266u) % 3u)
						{
						case 1u:
							goto IL_0063;
						default:
							goto end_IL_0076;
						case 0u:
							break;
						case 2u:
							goto end_IL_0076;
						}
						goto IL_0093;
						IL_0063:
						((IDisposable)fileStream).Dispose();
						num3 = ((int)num2 * -873039817) ^ 0x56C6DE07;
						continue;
						end_IL_0076:
						break;
					}
					break;
				}
			}
		}
	}

	public static string[] smethod_40(string string_0)
	{
		string[] result = GClass43.smethod_0(smethod_42(string_0));
		while (true)
		{
			int num = 531363121;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2DE4D6D2u) % 3u)
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
				num = ((int)num2 * -1499505289) ^ -1851654962;
			}
		}
	}

	public static string[] smethod_41(string string_0, Encoding encoding_1)
	{
		return GClass43.smethod_0(smethod_43(string_0, encoding_1));
	}

	public static IEnumerable<string> smethod_42(string string_0)
	{
		IEnumerable<string> result = smethod_41(string_0, Encoding.UTF8);
		while (true)
		{
			int num = 1913907949;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x57CDBAB2u) % 3u)
				{
				case 2u:
					goto IL_000e;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_000e:
				num = (int)(num2 * 42672989) ^ -490817912;
			}
		}
	}

	public static IEnumerable<string> smethod_43(string string_0, Encoding encoding_1)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new Class16(-2)
		{
			string_2 = string_0,
			encoding_1 = encoding_1
		};
	}

	public static void smethod_44(string string_0, string[] string_1)
	{
		while (true)
		{
			int num = -300009481;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFAD47AEEu) % 4u)
				{
				case 3u:
					num = ((int)num2 * -1401840961) ^ -463822913;
					continue;
				case 1u:
					smethod_45(string_0, string_1, Encoding.UTF8);
					num = (int)(num2 * 909797846) ^ -1256162625;
					continue;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public static void smethod_45(string string_0, string[] string_1, Encoding encoding_1)
	{
		StreamWriter streamWriter = smethod_62(string_0, bool_0: false, encoding_1);
		try
		{
			int num3 = default(int);
			string[] array = default(string[]);
			string value = default(string);
			while (true)
			{
				int num = -2070779829;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAD3C931Fu) % 11u)
					{
					case 10u:
						num3++;
						num = ((int)num2 * -174407784) ^ -1600010700;
						continue;
					case 9u:
						num = (int)(num2 * 1131368909) ^ -1449536075;
						continue;
					case 8u:
						num3 = 0;
						num = (int)((num2 * 413607183) ^ 0x681F3EEF);
						continue;
					case 6u:
						array = string_1;
						num = (int)(num2 * 905128226) ^ -1785663338;
						continue;
					case 5u:
						streamWriter.WriteLine(value);
						num = (int)(num2 * 1086737587) ^ -783774959;
						continue;
					case 4u:
						num = ((int)num2 * -826626226) ^ -698872497;
						continue;
					case 2u:
						value = array[num3];
						num = -1200898494;
						continue;
					case 1u:
						num = ((int)num2 * -337977703) ^ 0x95C5DED;
						continue;
					case 0u:
					{
						int num4;
						if (num3 >= array.Length)
						{
							num = -1992489401;
							num4 = -1992489401;
						}
						else
						{
							num = -1117063179;
							num4 = -1117063179;
						}
						continue;
					}
					default:
						return;
					case 3u:
						break;
					case 7u:
						return;
					}
					break;
				}
			}
		}
		finally
		{
			if (streamWriter != null)
			{
				while (true)
				{
					IL_013f:
					int num5 = -1448389306;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num5 ^ 0xAD3C931Fu) % 3u)
						{
						case 1u:
							goto IL_010d;
						default:
							goto end_IL_0121;
						case 0u:
							break;
						case 2u:
							goto end_IL_0121;
						}
						goto IL_013f;
						IL_010d:
						((IDisposable)streamWriter).Dispose();
						num5 = ((int)num2 * -1077571374) ^ -328120537;
						continue;
						end_IL_0121:
						break;
					}
					break;
				}
			}
		}
	}

	public static void smethod_46(string string_0, IEnumerable<string> ienumerable_0)
	{
		smethod_47(string_0, ienumerable_0, Encoding.UTF8);
		while (true)
		{
			int num = -1519764495;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD8B9A4B6u) % 3u)
				{
				case 2u:
					goto IL_000e;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_000e:
				num = (int)((num2 * 864694583) ^ 0x17629FE5);
			}
		}
	}

	public static void smethod_47(string string_0, IEnumerable<string> ienumerable_0, Encoding encoding_1)
	{
		StreamWriter streamWriter = smethod_62(string_0, bool_0: false, encoding_1);
		try
		{
			string current = default(string);
			while (true)
			{
				int num = 1716868900;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2250DE33u) % 3u)
					{
					case 2u:
						goto IL_000c;
					case 0u:
						break;
					default:
					{
						IEnumerator<string> enumerator = ienumerable_0.GetEnumerator();
						try
						{
							while (true)
							{
								int num3;
								int num4;
								if (enumerator.MoveNext())
								{
									num3 = 1574422514;
									num4 = 1574422514;
								}
								else
								{
									num3 = 493132354;
									num4 = 493132354;
								}
								while (true)
								{
									switch ((num2 = (uint)num3 ^ 0x2250DE33u) % 7u)
									{
									case 5u:
										num3 = (int)(num2 * 1297140301) ^ -798482895;
										continue;
									case 4u:
										current = enumerator.Current;
										num3 = 368174349;
										continue;
									case 3u:
										streamWriter.WriteLine(current);
										num3 = (int)(num2 * 224168639) ^ -32663393;
										continue;
									case 1u:
										num3 = (int)((num2 * 400127157) ^ 0x77C2165D);
										continue;
									case 0u:
										num3 = 1574422514;
										continue;
									default:
										return;
									case 2u:
										break;
									case 6u:
										return;
									}
									break;
								}
							}
						}
						finally
						{
							if (enumerator != null)
							{
								while (true)
								{
									IL_0131:
									int num5 = 1522665570;
									while (true)
									{
										switch ((num2 = (uint)num5 ^ 0x2250DE33u) % 4u)
										{
										case 3u:
											num5 = ((int)num2 * -698357570) ^ 0x32F17135;
											continue;
										case 1u:
											enumerator.Dispose();
											num5 = ((int)num2 * -941339287) ^ 0x7CBAB625;
											continue;
										default:
											goto end_IL_0110;
										case 2u:
											break;
										case 0u:
											goto end_IL_0110;
										}
										goto IL_0131;
										continue;
										end_IL_0110:
										break;
									}
									break;
								}
							}
						}
					}
					}
					break;
					IL_000c:
					num = ((int)num2 * -1264455052) ^ 0x4A543993;
				}
			}
		}
		finally
		{
			if (streamWriter != null)
			{
				while (true)
				{
					IL_0183:
					int num6 = 524636782;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num6 ^ 0x2250DE33u) % 4u)
						{
						case 2u:
							num6 = ((int)num2 * -842554555) ^ -98218710;
							continue;
						case 1u:
							((IDisposable)streamWriter).Dispose();
							num6 = (int)(num2 * 1929872807) ^ -247421082;
							continue;
						default:
							goto end_IL_0162;
						case 0u:
							break;
						case 3u:
							goto end_IL_0162;
						}
						goto IL_0183;
						continue;
						end_IL_0162:
						break;
					}
					break;
				}
			}
		}
	}

	public static void smethod_48(string string_0, string string_1)
	{
		smethod_49(string_0, string_1, Encoding.UTF8);
	}

	public static void smethod_49(string string_0, string string_1, Encoding encoding_1)
	{
		StreamWriter streamWriter = smethod_62(string_0, bool_0: true, encoding_1);
		try
		{
			while (true)
			{
				int num = -1843091702;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFBAC5587u) % 5u)
					{
					case 4u:
						streamWriter.Write(string_1);
						num = (int)((num2 * 841293092) ^ 0xA41DFF4);
						continue;
					case 2u:
						num = ((int)num2 * -290456736) ^ 0xEF55C96;
						continue;
					case 1u:
						num = ((int)num2 * -155442244) ^ -1225095301;
						continue;
					default:
						return;
					case 0u:
						break;
					case 3u:
						return;
					}
					break;
				}
			}
		}
		finally
		{
			if (streamWriter != null)
			{
				while (true)
				{
					IL_00a1:
					int num3 = -969233502;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xFBAC5587u) % 3u)
						{
						case 1u:
							goto IL_0071;
						default:
							goto end_IL_0084;
						case 2u:
							break;
						case 0u:
							goto end_IL_0084;
						}
						goto IL_00a1;
						IL_0071:
						((IDisposable)streamWriter).Dispose();
						num3 = ((int)num2 * -1793084880) ^ 0x24B4A3B4;
						continue;
						end_IL_0084:
						break;
					}
					break;
				}
			}
		}
	}

	public static void smethod_50(string string_0, IEnumerable<string> ienumerable_0)
	{
		while (true)
		{
			int num = -1219075602;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBE3AB79Du) % 4u)
				{
				case 3u:
					smethod_51(string_0, ienumerable_0, Encoding.UTF8);
					num = ((int)num2 * -271417964) ^ 0x32C85437;
					continue;
				case 2u:
					num = (int)(num2 * 233294901) ^ -727733174;
					continue;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	public static void smethod_51(string string_0, IEnumerable<string> ienumerable_0, Encoding encoding_1)
	{
		StreamWriter streamWriter = smethod_62(string_0, bool_0: true, encoding_1);
		try
		{
			IEnumerator<string> enumerator = ienumerable_0.GetEnumerator();
			try
			{
				string current = default(string);
				while (true)
				{
					int num;
					int num2;
					if (!enumerator.MoveNext())
					{
						num = -1866526498;
						num2 = -1866526498;
					}
					else
					{
						num = -238885733;
						num2 = -238885733;
					}
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)num ^ 0x93BED913u) % 6u)
						{
						case 3u:
							num = ((int)num3 * -952790014) ^ -1279124855;
							continue;
						case 2u:
							current = enumerator.Current;
							num = -1125074854;
							continue;
						case 1u:
							streamWriter.WriteLine(current);
							num = ((int)num3 * -622119897) ^ 0x31600EE7;
							continue;
						case 0u:
							num = -238885733;
							continue;
						default:
							return;
						case 4u:
							break;
						case 5u:
							return;
						}
						break;
					}
				}
			}
			finally
			{
				if (enumerator != null)
				{
					while (true)
					{
						IL_00e4:
						int num4 = -1718128775;
						while (true)
						{
							uint num3;
							switch ((num3 = (uint)num4 ^ 0x93BED913u) % 4u)
							{
							case 2u:
								enumerator.Dispose();
								num4 = ((int)num3 * -1539929367) ^ -934794392;
								continue;
							case 1u:
								num4 = (int)(num3 * 424278462) ^ -103918806;
								continue;
							default:
								goto end_IL_00c3;
							case 0u:
								break;
							case 3u:
								goto end_IL_00c3;
							}
							goto IL_00e4;
							continue;
							end_IL_00c3:
							break;
						}
						break;
					}
				}
			}
		}
		finally
		{
			if (streamWriter != null)
			{
				while (true)
				{
					IL_0136:
					int num5 = -1847929168;
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)num5 ^ 0x93BED913u) % 4u)
						{
						case 3u:
							((IDisposable)streamWriter).Dispose();
							num5 = ((int)num3 * -1586372574) ^ -902195933;
							continue;
						case 2u:
							num5 = ((int)num3 * -1508476863) ^ 0x41919740;
							continue;
						default:
							goto end_IL_0115;
						case 0u:
							break;
						case 1u:
							goto end_IL_0115;
						}
						goto IL_0136;
						continue;
						end_IL_0115:
						break;
					}
					break;
				}
			}
		}
	}

	public static void smethod_52(string string_0, string string_1)
	{
		bool flag = default(bool);
		string string_2 = default(string);
		while (true)
		{
			int num = -909034783;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBFBFF559u) % 6u)
				{
				case 5u:
				{
					string string_3 = GClass41.smethod_1(string_1, "destinationPath");
					flag = !Class17.MoveFile(string_2, string_3);
					num = ((int)num2 * -1805836357) ^ -537986425;
					continue;
				}
				case 4u:
					string_2 = GClass41.smethod_1(string_0, "sourcePath");
					num = (int)((num2 * 74708178) ^ 0x4C68F368);
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1897697866;
						num4 = 1897697866;
					}
					else
					{
						num3 = 2086430859;
						num4 = 2086430859;
					}
					num = num3 ^ (int)(num2 * 609484012);
					continue;
				}
				default:
					return;
				case 0u:
					break;
				case 2u:
					throw GClass33.smethod_8();
				case 1u:
					return;
				}
				break;
			}
		}
	}

	public static void smethod_53(string string_0, string string_1, string string_2)
	{
		bool flag = string_0 == null;
		bool flag2 = default(bool);
		while (true)
		{
			int num = 1816826838;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x67E0E3F0u) % 9u)
				{
				case 8u:
					smethod_54(string_0, string_1, string_2, bool_0: false);
					num = 181413956;
					continue;
				case 6u:
					num = ((int)num2 * -932400676) ^ 0x47EBE289;
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = -2133915495;
						num6 = -2133915495;
					}
					else
					{
						num5 = -1569523003;
						num6 = -1569523003;
					}
					num = num5 ^ ((int)num2 * -1162447408);
					continue;
				}
				case 3u:
				{
					int num3;
					int num4;
					if (flag2)
					{
						num3 = -1714482140;
						num4 = -1714482140;
					}
					else
					{
						num3 = -1708054175;
						num4 = -1708054175;
					}
					num = num3 ^ ((int)num2 * -574499923);
					continue;
				}
				case 1u:
					flag2 = string_1 == null;
					num = 1916482165;
					continue;
				default:
					return;
				case 0u:
					break;
				case 2u:
					throw new ArgumentNullException("sourceFileName");
				case 5u:
					throw new ArgumentNullException("destinationFileName");
				case 7u:
					return;
				}
				break;
			}
		}
	}

	public static void smethod_54(string string_0, string string_1, string string_2, bool bool_0)
	{
		int num5 = default(int);
		bool flag5 = default(bool);
		string string_3 = default(string);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		string string_4 = default(string);
		string string_5 = default(string);
		bool flag4 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 1146484764;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7F6BB22Eu) % 19u)
				{
				case 18u:
					num5 |= 2;
					num = ((int)num2 * -1224979332) ^ -74679147;
					continue;
				case 15u:
				{
					int num12;
					int num13;
					if (flag5)
					{
						num12 = -709937146;
						num13 = -709937146;
					}
					else
					{
						num12 = -1256106821;
						num13 = -1256106821;
					}
					num = num12 ^ (int)(num2 * 1738606890);
					continue;
				}
				case 14u:
					flag5 = string_0 == null;
					num = ((int)num2 * -1527707761) ^ -1407933853;
					continue;
				case 12u:
				{
					string_3 = null;
					int num8;
					int num9;
					if (string_2 == null)
					{
						num8 = -1798345016;
						num9 = -1798345016;
					}
					else
					{
						num8 = -1787566551;
						num9 = -1787566551;
					}
					num = num8 ^ ((int)num2 * -315445577);
					continue;
				}
				case 10u:
					flag2 = !flag3;
					num = (int)((num2 * 2132344089) ^ 0x28DC5C30);
					continue;
				case 9u:
					GClass33.smethod_13(Marshal.GetLastWin32Error(), string.Empty);
					num = ((int)num2 * -199068447) ^ -590424730;
					continue;
				case 8u:
					string_4 = GClass41.smethod_0(GClass41.smethod_13(string_0));
					string_5 = GClass41.smethod_0(GClass41.smethod_13(string_1));
					num = 1759703105;
					continue;
				case 7u:
					num = ((int)num2 * -2127268900) ^ 0x3E5A28A4;
					continue;
				case 6u:
					flag3 = Class17.ReplaceFile(string_5, string_4, string_3, num5, IntPtr.Zero, IntPtr.Zero);
					num = 1849224590;
					continue;
				case 5u:
				{
					int num10;
					int num11;
					if (flag4)
					{
						num10 = -1849713182;
						num11 = -1849713182;
					}
					else
					{
						num10 = -807723031;
						num11 = -807723031;
					}
					num = num10 ^ (int)(num2 * 196312850);
					continue;
				}
				case 4u:
				{
					int num6;
					int num7;
					if (!flag)
					{
						num6 = -375603080;
						num7 = -375603080;
					}
					else
					{
						num6 = -1727422443;
						num7 = -1727422443;
					}
					num = num6 ^ (int)(num2 * 163562348);
					continue;
				}
				case 3u:
					num5 = 1;
					flag4 = bool_0;
					num = 142957312;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag2)
					{
						num3 = 1309345825;
						num4 = 1309345825;
					}
					else
					{
						num3 = 90123584;
						num4 = 90123584;
					}
					num = num3 ^ ((int)num2 * -698152432);
					continue;
				}
				case 1u:
					string_3 = GClass41.smethod_0(GClass41.smethod_13(string_2));
					num = ((int)num2 * -1202345073) ^ -566758893;
					continue;
				case 0u:
					flag = string_1 == null;
					num = 1026629135;
					continue;
				default:
					return;
				case 11u:
					break;
				case 13u:
					throw new ArgumentNullException("destinationFileName");
				case 16u:
					throw new ArgumentNullException("sourceFileName");
				case 17u:
					return;
				}
				break;
			}
		}
	}

	public static void smethod_55(string string_0, FileSecurity fileSecurity_0)
	{
		if (string_0 == null)
		{
			goto IL_0015;
		}
		goto IL_0049;
		IL_0049:
		int num;
		int num2;
		if (fileSecurity_0 == null)
		{
			num = -1904614798;
			num2 = -1904614798;
		}
		else
		{
			num = -177439028;
			num2 = -177439028;
		}
		goto IL_001a;
		IL_001a:
		switch ((uint)(num ^ -465764506) % 5u)
		{
		case 0u:
			break;
		case 2u:
			goto IL_0049;
		case 3u:
			throw new ArgumentNullException("path");
		case 4u:
			throw new ArgumentNullException("fileSecurity");
		default:
		{
			string string_ = GClass41.smethod_0(GClass41.smethod_13(string_0));
			GClass33.smethod_15(fileSecurity_0, string_);
			return;
		}
		}
		goto IL_0015;
		IL_0015:
		num = -70028894;
		goto IL_001a;
	}

	private static void smethod_56(int int_1, IntPtr intptr_0)
	{
		if (int_1 == 0)
		{
			goto IL_00d1;
		}
		goto IL_0163;
		IL_00d1:
		int num = 341134766;
		goto IL_00f5;
		IL_00f5:
		bool flag2 = default(bool);
		bool flag = default(bool);
		int num9;
		while (true)
		{
			uint num2;
			int num3;
			switch ((num2 = (uint)num ^ 0x670BA76Au) % 16u)
			{
			case 13u:
				break;
			case 12u:
				num = (int)((num2 * 1992419763) ^ 0x3CF2C204);
				continue;
			case 11u:
				goto IL_0055;
			case 9u:
				num3 = ((int_1 == 1314) ? 1 : 0);
				goto IL_006e;
			case 7u:
			{
				int num4;
				int num5;
				if (flag2)
				{
					num4 = -1771494638;
					num5 = -1771494638;
				}
				else
				{
					num4 = -257470441;
					num5 = -257470441;
				}
				num = num4 ^ (int)(num2 * 648890922);
				continue;
			}
			case 6u:
			{
				int num6;
				int num7;
				if (flag)
				{
					num6 = 581201247;
					num7 = 581201247;
				}
				else
				{
					num6 = 1293233186;
					num7 = 1293233186;
				}
				num = num6 ^ (int)(num2 * 1547189232);
				continue;
			}
			case 5u:
				num = ((int)num2 * -178128748) ^ 0x6F06D931;
				continue;
			case 3u:
				goto end_IL_00f5;
			case 2u:
				if (int_1 != 1300)
				{
					num = 526666483;
					continue;
				}
				num3 = 1;
				goto IL_006e;
			case 1u:
				flag = int_1 == 8;
				num = 363993756;
				continue;
			default:
				return;
			case 4u:
				goto IL_0148;
			case 0u:
				throw new UnauthorizedAccessException();
			case 10u:
				throw new InvalidOperationException("Object does not have security descriptor,");
			case 14u:
				throw new PrivilegeNotHeldException("SeSecurityPrivilege");
			case 15u:
				throw new OutOfMemoryException();
			case 8u:
				return;
				IL_006e:
				flag2 = (byte)num3 != 0;
				num = 1507029949;
				continue;
			}
			int num8;
			if (int_1 != 1347)
			{
				num = 1861340571;
				num8 = 1861340571;
				continue;
			}
			goto IL_0026;
			IL_0148:
			IntPtr zero = IntPtr.Zero;
			if (zero.Equals((object?)(nint)intptr_0))
			{
				num = 1448787638;
				num9 = 1448787638;
				continue;
			}
			goto IL_0163;
			IL_0026:
			num = 1113743514;
			num8 = 1113743514;
			continue;
			IL_0055:
			if (int_1 != 5)
			{
				num = 756052791;
				continue;
			}
			goto IL_0026;
			continue;
			end_IL_00f5:
			break;
		}
		goto IL_00d1;
		IL_0163:
		num = 36367880;
		num9 = 36367880;
		goto IL_00f5;
	}

	public static FileSecurity smethod_57(string string_0)
	{
		AccessControlSections accessControlSections_ = default(AccessControlSections);
		FileSecurity result = default(FileSecurity);
		while (true)
		{
			int num = -2059191494;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9A84D338u) % 5u)
				{
				case 4u:
					accessControlSections_ = AccessControlSections.Access | AccessControlSections.Owner | AccessControlSections.Group;
					num = ((int)num2 * -1304580460) ^ 0x728A6AF8;
					continue;
				case 3u:
					num = (int)((num2 * 1726972759) ^ 0x698434F0);
					continue;
				case 0u:
					result = smethod_58(string_0, accessControlSections_);
					num = (int)((num2 * 1417275649) ^ 0x7C8A7924);
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

	public static FileSecurity smethod_58(string string_0, AccessControlSections accessControlSections_0)
	{
		uint securityDescriptorLength = default(uint);
		IntPtr intptr_5 = default(IntPtr);
		byte[] array = default(byte[]);
		FileSecurity result = default(FileSecurity);
		string string_ = default(string);
		while (true)
		{
			int num = 638543219;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x515D8DC2u) % 8u)
				{
				case 7u:
					securityDescriptorLength = Class17.GetSecurityDescriptorLength(intptr_5);
					num = (int)(num2 * 581183039) ^ -1637098853;
					continue;
				case 6u:
				{
					FileSecurity fileSecurity = new FileSecurity();
					fileSecurity.SetSecurityDescriptorBinaryForm(array);
					result = fileSecurity;
					num = ((int)num2 * -5702005) ^ 0x58568322;
					continue;
				}
				case 4u:
					Marshal.Copy(intptr_5, array, 0, (int)securityDescriptorLength);
					Class17.LocalFree(intptr_5);
					num = ((int)num2 * -1236430011) ^ -6740472;
					continue;
				case 3u:
				{
					SecurityInfos uint_ = GClass33.smethod_14(accessControlSections_0);
					IntPtr intptr_;
					IntPtr intptr_2;
					IntPtr intptr_3;
					IntPtr intptr_4;
					int namedSecurityInfoW = (int)Class17.GetNamedSecurityInfoW(string_, 1u, (uint)uint_, out intptr_, out intptr_2, out intptr_3, out intptr_4, out intptr_5);
					smethod_56(namedSecurityInfoW, intptr_5);
					num = (int)((num2 * 2018434112) ^ 0x6844507D);
					continue;
				}
				case 1u:
					string_ = GClass41.smethod_0(GClass41.smethod_13(string_0));
					num = ((int)num2 * -1242454130) ^ 0x227D73EF;
					continue;
				case 0u:
					array = new byte[securityDescriptorLength];
					num = (int)((num2 * 199334788) ^ 0x2429C18E);
					continue;
				case 5u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	internal static SafeFileHandle smethod_59(string string_0, FileMode fileMode_0, FileAccess fileAccess_0, FileShare fileShare_0, FileOptions fileOptions_0)
	{
		SafeFileHandle safeFileHandle = default(SafeFileHandle);
		Class17.Enum3 enum3_ = default(Class17.Enum3);
		bool flag = default(bool);
		SafeFileHandle result = default(SafeFileHandle);
		Exception ex = default(Exception);
		bool isInvalid = default(bool);
		while (true)
		{
			int num = 1244536172;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3D0AE9FBu) % 18u)
				{
				case 17u:
					safeFileHandle = Class17.CreateFile(string_0, enum3_, (uint)fileShare_0, IntPtr.Zero, (uint)fileMode_0, (uint)fileOptions_0, IntPtr.Zero);
					num = ((int)num2 * -1203270966) ^ -1671970659;
					continue;
				case 16u:
					num = ((int)num2 * -979697230) ^ 0x290B9BF0;
					continue;
				case 15u:
					num = ((int)num2 * -2082964503) ^ 0x60E5989A;
					continue;
				case 13u:
					flag = fileMode_0 == FileMode.Append;
					num = (int)(num2 * 797473655) ^ -92864178;
					continue;
				case 12u:
				{
					int num5;
					if (!flag)
					{
						num = 1751238532;
						num5 = 1751238532;
					}
					else
					{
						num = 426117481;
						num5 = 426117481;
					}
					continue;
				}
				case 11u:
					result = safeFileHandle;
					num = 1263119713;
					continue;
				case 9u:
					Console.WriteLine("{0} {1} {2} {3}", fileMode_0, fileAccess_0, fileShare_0, fileOptions_0);
					num = ((int)num2 * -478041939) ^ -57532795;
					continue;
				case 8u:
				{
					int num6;
					int num7;
					if (!flag)
					{
						num6 = 1562631814;
						num7 = 1562631814;
					}
					else
					{
						num6 = 440753772;
						num7 = 440753772;
					}
					num = num6 ^ ((int)num2 * -2092003823);
					continue;
				}
				case 7u:
					fileMode_0 = FileMode.OpenOrCreate;
					num = (int)(num2 * 2023684290) ^ -1262485668;
					continue;
				case 6u:
					ex = GClass33.smethod_8();
					Console.WriteLine("error {0} with {1}\n{2}", ex.Message, string_0, ex.StackTrace);
					num = ((int)num2 * -1594228358) ^ 0x1E02DA8C;
					continue;
				case 5u:
					enum3_ = smethod_60(fileAccess_0);
					num = 1154126736;
					continue;
				case 3u:
					Class17.smethod_1(safeFileHandle, 0L, SeekOrigin.End);
					num = (int)((num2 * 1308500103) ^ 0x4638C9ED);
					continue;
				case 2u:
					isInvalid = safeFileHandle.IsInvalid;
					num = ((int)num2 * -1253277627) ^ -2009340709;
					continue;
				case 1u:
					num = (int)((num2 * 338816213) ^ 0x1B9DD59B);
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (isInvalid)
					{
						num3 = -1239003783;
						num4 = -1239003783;
					}
					else
					{
						num3 = -1218113127;
						num4 = -1218113127;
					}
					num = num3 ^ ((int)num2 * -1791555372);
					continue;
				}
				case 4u:
					break;
				case 10u:
					throw ex;
				default:
					return result;
				}
				break;
			}
		}
	}

	private static Class17.Enum3 smethod_60(FileAccess fileAccess_0)
	{
		Class17.Enum3 result = default(Class17.Enum3);
		FileAccess fileAccess = default(FileAccess);
		while (true)
		{
			int num = -1690002680;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD3453141u) % 10u)
				{
				case 8u:
					num = (int)((num2 * 1949576687) ^ 0x416393BD);
					continue;
				case 7u:
					result = Class17.Enum3.GenericRead | Class17.Enum3.GenericWrite;
					num = -651254253;
					continue;
				case 5u:
					num = ((int)num2 * -565088100) ^ 0x3635DB6A;
					continue;
				case 4u:
					goto IL_0031;
				case 3u:
					goto IL_003e;
				case 2u:
					switch (fileAccess)
					{
					case FileAccess.ReadWrite:
						break;
					case FileAccess.Read:
						goto IL_0031;
					case FileAccess.Write:
						goto IL_003e;
					default:
						goto IL_005f;
					}
					goto case 7u;
				case 1u:
					fileAccess = fileAccess_0;
					num = ((int)num2 * -1802667925) ^ 0x64E6E25C;
					continue;
				case 6u:
					break;
				case 9u:
					throw new ArgumentOutOfRangeException("access");
				default:
					{
						return result;
					}
					IL_005f:
					num = ((int)num2 * -12115149) ^ 0x22035BE;
					continue;
					IL_003e:
					result = Class17.Enum3.GenericWrite;
					num = -651254253;
					continue;
					IL_0031:
					result = Class17.Enum3.GenericRead;
					num = -1690197389;
					continue;
				}
				break;
			}
		}
	}

	internal static StreamWriter smethod_61(string string_0, bool bool_0)
	{
		if (!bool_0)
		{
			goto IL_0049;
		}
		int num = 6;
		goto IL_0074;
		IL_0073:
		num = 2;
		goto IL_0074;
		IL_0049:
		int num2 = -1447928406;
		goto IL_004e;
		IL_004e:
		StreamWriter result = default(StreamWriter);
		FileStream stream = default(FileStream);
		FileMode fileMode_ = default(FileMode);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0xE53F5387u) % 5u)
			{
			case 4u:
				result = new StreamWriter(stream, Encoding_0, 1024);
				num2 = ((int)num3 * -1695533097) ^ 0x4D872EFA;
				continue;
			case 3u:
				stream = smethod_17(string_0, fileMode_, FileAccess.Write, FileShare.Read, 4096, FileOptions.SequentialScan);
				num2 = (int)((num3 * 205600398) ^ 0x24000FF6);
				continue;
			case 0u:
				break;
			case 1u:
				goto IL_0073;
			default:
				return result;
			}
			break;
		}
		goto IL_0049;
		IL_0074:
		fileMode_ = (FileMode)num;
		num2 = -1670710957;
		goto IL_004e;
	}

	internal static StreamWriter smethod_62(string string_0, bool bool_0, Encoding encoding_1)
	{
		StreamWriter result = default(StreamWriter);
		while (true)
		{
			int num = -1953487565;
			while (true)
			{
				uint num2;
				int num3;
				FileMode fileMode_;
				FileStream stream;
				switch ((num2 = (uint)num ^ 0xC7779CE5u) % 5u)
				{
				case 4u:
					num = (int)(num2 * 1229816773) ^ -178865076;
					continue;
				case 3u:
					num3 = 2;
					goto IL_0013;
				case 1u:
					if (!bool_0)
					{
						num = ((int)num2 * -1511856799) ^ -1697110877;
						continue;
					}
					num3 = 6;
					goto IL_0013;
				case 0u:
					break;
				default:
					{
						return result;
					}
					IL_0013:
					fileMode_ = (FileMode)num3;
					stream = smethod_17(string_0, fileMode_, FileAccess.Write, FileShare.Read, 4096, FileOptions.SequentialScan);
					result = new StreamWriter(stream, encoding_1, 1024);
					num = -389820538;
					continue;
				}
				break;
			}
		}
	}

	internal static StreamWriter smethod_63(string string_0, Encoding encoding_1)
	{
		StreamWriter result = default(StreamWriter);
		while (true)
		{
			int num = 1905649529;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x52F7292Cu) % 4u)
				{
				case 3u:
					num = (int)(num2 * 401012195) ^ -1098077831;
					continue;
				case 1u:
					result = smethod_62(string_0, bool_0: false, encoding_1);
					num = (int)((num2 * 1766636838) ^ 0x17888A61);
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

	internal static StreamReader smethod_64(string string_0, Encoding encoding_1, bool bool_0, int int_1)
	{
		StreamReader result = default(StreamReader);
		while (true)
		{
			int num = -1871391593;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEF389C00u) % 4u)
				{
				case 3u:
				{
					FileStream stream = smethod_17(string_0, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, FileOptions.SequentialScan);
					result = new StreamReader(stream, encoding_1, bool_0, int_1);
					num = (int)((num2 * 175041696) ^ 0x5D4FCF71);
					continue;
				}
				case 1u:
					num = ((int)num2 * -1010565739) ^ -1459460113;
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
}
