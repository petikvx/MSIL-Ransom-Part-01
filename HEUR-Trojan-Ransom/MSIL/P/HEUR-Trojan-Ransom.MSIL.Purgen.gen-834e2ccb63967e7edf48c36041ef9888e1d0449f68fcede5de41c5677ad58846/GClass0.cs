using System;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.MyServices;

public class GClass0
{
	private bool bool_0;

	private bool bool_1;

	private string string_0;

	public bool Boolean_0
	{
		get
		{
			bool result = bool_0;
			while (true)
			{
				int num = 1428336202;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5BC818Eu) % 3u)
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
					num = ((int)num2 * -659536707) ^ -1979015406;
				}
			}
		}
		set
		{
			while (true)
			{
				int num = -549074941;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA4035E4Bu) % 3u)
					{
					case 1u:
						goto IL_0003;
					default:
						return;
					case 2u:
						break;
					case 0u:
						return;
					}
					break;
					IL_0003:
					bool_0 = value;
					num = ((int)num2 * -1367676676) ^ 0x623F04E1;
				}
			}
		}
	}

	public int Int32_0
	{
		get
		{
			string string_ = GClass0.smethod_7(255);
			string string_3 = default(string);
			int result = default(int);
			bool flag = default(bool);
			while (true)
			{
				int num = -957632579;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD5C7921Fu) % 9u)
					{
					case 7u:
					{
						string string_2 = null;
						mciSendStringA(ref string_3, ref string_2, 0, (int)IntPtr.Zero);
						num = ((int)num2 * -867507923) ^ 0xC5204A2;
						continue;
					}
					case 5u:
						result = GClass0.smethod_9(string_);
						num = -852514850;
						continue;
					case 4u:
						string_3 = "set audiofile time format milliseconds";
						num = (int)(num2 * 1977725779) ^ -470142710;
						continue;
					case 3u:
						result = 0;
						num = (int)((num2 * 6800040) ^ 0x731573D7);
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -1475642113;
							num4 = -1475642113;
						}
						else
						{
							num3 = -1669656344;
							num4 = -1669656344;
						}
						num = num3 ^ ((int)num2 * -1940446467);
						continue;
					}
					case 1u:
						num = (int)((num2 * 200208199) ^ 0x1839EF90);
						continue;
					case 0u:
					{
						string string_2 = "status audiofile length";
						mciSendStringA(ref string_2, ref string_, 255, (int)IntPtr.Zero);
						string_ = GClass0.smethod_8(string_, "\0", "", 1, -1, (CompareMethod)0);
						flag = GClass0.smethod_0(string_, "", bool_2: false) == 0;
						num = (int)((num2 * 54716054) ^ 0x597AA0DB);
						continue;
					}
					case 6u:
						break;
					default:
						return result;
					}
					break;
				}
			}
		}
	}

	public string String_0
	{
		get
		{
			string string_2 = default(string);
			string string_ = default(string);
			string result = default(string);
			while (true)
			{
				int num = -1699371172;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA4B5D6BFu) % 7u)
					{
					case 6u:
						string_2 = GClass0.smethod_7(255);
						num = (int)(num2 * 1671106992) ^ -2105180613;
						continue;
					case 5u:
						mciSendStringA(ref string_, ref string_2, 255, (int)IntPtr.Zero);
						num = (int)((num2 * 641293371) ^ 0x1E742BFB);
						continue;
					case 4u:
						string_2 = GClass0.smethod_8(string_2, "\0", "", 1, -1, (CompareMethod)0);
						num = ((int)num2 * -430636661) ^ 0x2707DFBA;
						continue;
					case 2u:
						result = string_2;
						num = ((int)num2 * -1319655181) ^ -1735592022;
						continue;
					case 1u:
						string_ = "status audiofile mode";
						num = ((int)num2 * -1761933301) ^ -23969940;
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

	public int Int32_1
	{
		get
		{
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Expected I4, but got Unknown
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected I4, but got Unknown
			//IL_0056: Incompatible stack heights: 0 vs 1
			//IL_006c: Incompatible stack heights: 0 vs 1
			//IL_0073: Incompatible stack heights: 0 vs 1
			int result = default(int);
			try
			{
				result = checked((int)GClass0.smethod_12(GClass0.smethod_11(GClass0.smethod_10((ServerComputer)(object)Class2.Class1_0), string_0)));
				return result;
			}
			catch (Exception exception_)
			{
				GClass0.smethod_13(exception_);
				while (true)
				{
					_ = 922808164;
					while (true)
					{
						_003F val = /*Error near IL_002e: Stack underflow*/^ 0x2B1613E1;
						uint num = (uint)(int)val;
						switch (val % 4)
						{
						case 1:
							_ = ((int)num * -395607574) ^ 0x42388C93;
							continue;
						case 0:
							result = 0;
							GClass0.smethod_14();
							_ = (num * 941997650) ^ 0x92827F52u;
							continue;
						case 2:
							break;
						default:
							return result;
						case 3:
							return result;
						}
						break;
					}
				}
			}
		}
	}

	public int Int32_2
	{
		get
		{
			string string_ = GClass0.smethod_7(255);
			string string_2 = "status audiofile channels";
			int result = default(int);
			bool flag = default(bool);
			while (true)
			{
				int num = -1621598;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE0B87E1Eu) % 8u)
					{
					case 6u:
						result = -1;
						num = -1413240435;
						continue;
					case 5u:
						result = GClass0.smethod_9(string_);
						num = (int)((num2 * 266602190) ^ 0x58BCFBF9);
						continue;
					case 4u:
						mciSendStringA(ref string_2, ref string_, 255, (int)IntPtr.Zero);
						flag = GClass0.smethod_15((object)string_);
						num = ((int)num2 * -667811893) ^ 0x1DCFBBC2;
						continue;
					case 3u:
						num = (int)((num2 * 756413796) ^ 0x1056796D);
						continue;
					case 1u:
						num = ((int)num2 * -322084946) ^ 0x3C113C4F;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1804116752;
							num4 = 1804116752;
						}
						else
						{
							num3 = 606245619;
							num4 = 606245619;
						}
						num = num3 ^ ((int)num2 * -587249826);
						continue;
					}
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

	public string String_1
	{
		get
		{
			string string_2 = default(string);
			string string_ = default(string);
			string result = default(string);
			while (true)
			{
				int num = 1578453034;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC7E5FA8u) % 5u)
					{
					case 2u:
						string_2 = GClass0.smethod_7(255);
						num = ((int)num2 * -1160298544) ^ -2127263477;
						continue;
					case 1u:
						string_ = "status audiofile channels";
						num = (int)((num2 * 858032732) ^ 0x342F837C);
						continue;
					case 0u:
						mciSendStringA(ref string_, ref string_2, 255, (int)IntPtr.Zero);
						result = GClass0.smethod_16((object)string_2);
						num = (int)(num2 * 1366230152) ^ -293578223;
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

	public bool Boolean_1
	{
		get
		{
			return bool_1;
		}
		set
		{
			while (true)
			{
				int num = -1799945576;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD09F3786u) % 3u)
					{
					case 2u:
						goto IL_0003;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
					}
					break;
					IL_0003:
					bool_1 = value;
					num = (int)(num2 * 1258525198) ^ -1194020859;
				}
			}
		}
	}

	public string String_2
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = -1091928516;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCF4BC52Au) % 4u)
					{
					case 2u:
						result = string_0;
						num = ((int)num2 * -290069820) ^ 0x67FB6243;
						continue;
					case 1u:
						num = ((int)num2 * -1496252405) ^ -2004055438;
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
		set
		{
			bool flag = default(bool);
			while (true)
			{
				int num = 1142366791;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x54841914u) % 6u)
					{
					case 5u:
						flag = !GClass0.smethod_17(GClass0.smethod_10((ServerComputer)(object)Class2.Class1_0), value);
						num = (int)(num2 * 312945690) ^ -1191726693;
						continue;
					case 4u:
						num = 2075066577;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 1421821476;
							num4 = 1421821476;
						}
						else
						{
							num3 = 1820999712;
							num4 = 1820999712;
						}
						num = num3 ^ ((int)num2 * -1552408444);
						continue;
					}
					case 0u:
						break;
					case 2u:
						throw GClass0.smethod_18();
					default:
						string_0 = value;
						return;
					}
					break;
				}
			}
		}
	}

	[DllImport("winmm.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int mciSendStringA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_1, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_2, int int_0, int int_1);

	public GClass0(string string_1)
	{
		while (true)
		{
			int num = -1142140557;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA2D4989Du) % 6u)
				{
				case 5u:
					bool_1 = false;
					String_2 = string_1;
					num = (int)(num2 * 632027440) ^ -895850258;
					continue;
				case 4u:
					num = (int)((num2 * 929855366) ^ 0x68931493);
					continue;
				case 2u:
					bool_0 = false;
					num = (int)(num2 * 1282578162) ^ -1202197648;
					continue;
				case 1u:
					num = (int)((num2 * 1785043514) ^ 0xBFA9B23);
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

	public void method_0()
	{
		string string_ = default(string);
		string string_2 = default(string);
		string string_4 = default(string);
		string string_3 = default(string);
		while (true)
		{
			int num = 691256267;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x66416A5Au) % 32u)
				{
				case 31u:
				{
					int num12;
					int num13;
					if (GClass0.smethod_0(string_, "idi", bool_2: false) != 0)
					{
						num12 = 40674311;
						num13 = 40674311;
					}
					else
					{
						num12 = 930592208;
						num13 = 930592208;
					}
					num = num12 ^ (int)(num2 * 475726079);
					continue;
				}
				case 30u:
					string_4 = "";
					mciSendStringA(ref string_2, ref string_4, 0, 0);
					string_4 = "play midi";
					num = (int)(num2 * 464867006) ^ -245092548;
					continue;
				case 28u:
					num = (int)((num2 * 473247219) ^ 0x47C8DE00);
					continue;
				case 27u:
					string_2 = GClass0.smethod_4("open \"", string_0, "\" type waveaudio alias audiofile");
					string_4 = null;
					mciSendStringA(ref string_2, ref string_4, 0, (int)IntPtr.Zero);
					num = ((int)num2 * -571781044) ^ -401398790;
					continue;
				case 26u:
				{
					int num8;
					int num9;
					if (GClass0.smethod_0(string_, "wav", bool_2: false) == 0)
					{
						num8 = -1284095747;
						num9 = -1284095747;
					}
					else
					{
						num8 = -1145238096;
						num9 = -1145238096;
					}
					num = num8 ^ ((int)num2 * -660420999);
					continue;
				}
				case 25u:
					string_2 = "stop midi";
					num = (int)((num2 * 1709559393) ^ 0x313180E4);
					continue;
				case 24u:
					string_3 = "play audiofile from 0";
					num = ((int)num2 * -138167877) ^ 0x2BE2E211;
					continue;
				case 23u:
					string_4 = "close midi";
					num = ((int)num2 * -247463774) ^ 0x1E08EA3C;
					continue;
				case 22u:
					Boolean_1 = false;
					num = ((int)num2 * -1173357459) ^ 0x2FD704A1;
					continue;
				case 21u:
					string_2 = null;
					mciSendStringA(ref string_3, ref string_2, 0, (int)IntPtr.Zero);
					num = 1962136597;
					continue;
				case 20u:
					num = ((int)num2 * -468097087) ^ -182093951;
					continue;
				case 19u:
					num = (int)((num2 * 835162220) ^ 0x3B2DF711);
					continue;
				case 18u:
					string_2 = GClass0.smethod_4("open sequencer!", string_0, " alias midi");
					num = ((int)num2 * -442503621) ^ 0x19B8B742;
					continue;
				case 17u:
				{
					int num10;
					int num11;
					if ((GClass0.smethod_0(string_0, "", bool_2: false) == 0) | (GClass0.smethod_1(String_2) <= 4))
					{
						num10 = -628299280;
						num11 = -628299280;
					}
					else
					{
						num10 = -1978637419;
						num11 = -1978637419;
					}
					num = num10 ^ (int)(num2 * 2117616966);
					continue;
				}
				case 16u:
					string_4 = GClass0.smethod_4("open \"", string_0, "\" type mpegvideo alias audiofile");
					string_2 = null;
					mciSendStringA(ref string_4, ref string_2, 0, (int)IntPtr.Zero);
					num = 446037122;
					continue;
				case 15u:
					num = 1463509804;
					continue;
				case 14u:
					num = 348479675;
					continue;
				case 13u:
					num = 1950397569;
					continue;
				case 12u:
					num = (int)(num2 * 1422838288) ^ -1287669220;
					continue;
				case 11u:
					num = 1915211011;
					continue;
				case 10u:
					string_3 = GClass0.smethod_5(string_3, " wait");
					num = (int)((num2 * 93511520) ^ 0x722A7EEF);
					continue;
				case 9u:
				{
					string_ = GClass0.smethod_3(GClass0.smethod_2(String_2, 3));
					int num7;
					if (GClass0.smethod_0(string_, "mp3", bool_2: false) == 0)
					{
						num = 1844058890;
						num7 = 1844058890;
					}
					else
					{
						num = 367165568;
						num7 = 367165568;
					}
					continue;
				}
				case 8u:
					string_2 = "";
					mciSendStringA(ref string_4, ref string_2, 0, 0);
					num = ((int)num2 * -857569248) ^ 0x11CB2728;
					continue;
				case 7u:
					string_4 = "";
					mciSendStringA(ref string_2, ref string_4, 0, 0);
					num = (int)(num2 * 835013787) ^ -198082128;
					continue;
				case 5u:
					num = (int)((num2 * 1868257109) ^ 0x7922FBB5);
					continue;
				case 4u:
					string_4 = "play audiofile from 0";
					string_2 = null;
					mciSendStringA(ref string_4, ref string_2, 0, (int)IntPtr.Zero);
					num = ((int)num2 * -1171591764) ^ -1645636551;
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (!bool_0)
					{
						num5 = -268926771;
						num6 = -268926771;
					}
					else
					{
						num5 = -1491629006;
						num6 = -1491629006;
					}
					num = num5 ^ (int)(num2 * 1720054006);
					continue;
				}
				case 2u:
					string_2 = "";
					mciSendStringA(ref string_4, ref string_2, 0, 0);
					num = ((int)num2 * -997933373) ^ -1885471832;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (GClass0.smethod_0(string_, "mid", bool_2: false) != 0)
					{
						num3 = 1971268517;
						num4 = 1971268517;
					}
					else
					{
						num3 = 1763478225;
						num4 = 1763478225;
					}
					num = num3 ^ ((int)num2 * -2041002156);
					continue;
				}
				default:
					return;
				case 29u:
					break;
				case 1u:
					throw GClass0.smethod_6("File type not supported.");
				case 6u:
					return;
				}
				break;
			}
		}
	}

	public void method_1()
	{
		string string_ = "pause audiofile";
		while (true)
		{
			int num = 1063123737;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x340CF350u) % 5u)
				{
				case 4u:
					num = (int)((num2 * 1688481896) ^ 0x5EF404F4);
					continue;
				case 3u:
				{
					string string_2 = null;
					mciSendStringA(ref string_, ref string_2, 0, (int)IntPtr.Zero);
					num = ((int)num2 * -302484029) ^ 0x6B2709F6;
					continue;
				}
				case 2u:
					Boolean_1 = true;
					num = (int)((num2 * 917599059) ^ 0x328C3215);
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

	public void method_2()
	{
		string string_ = "resume audiofile";
		while (true)
		{
			int num = 1770618077;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3C2D40A3u) % 4u)
				{
				case 3u:
					Boolean_1 = false;
					num = (int)(num2 * 1203838798) ^ -952281612;
					continue;
				case 2u:
				{
					string string_2 = null;
					mciSendStringA(ref string_, ref string_2, 0, (int)IntPtr.Zero);
					num = ((int)num2 * -927937126) ^ 0x318D638;
					continue;
				}
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

	public void method_3()
	{
		string string_2 = default(string);
		while (true)
		{
			int num = 425907446;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x38BE294Fu) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 2u:
					break;
				default:
				{
					string string_ = null;
					mciSendStringA(ref string_2, ref string_, 0, (int)IntPtr.Zero);
					return;
				}
				}
				break;
				IL_0003:
				string_2 = "stop audiofile";
				num = (int)((num2 * 104627793) ^ 0x706CCAD6);
			}
		}
	}

	public void method_4()
	{
		string string_ = "close audiofile";
		string string_2 = null;
		mciSendStringA(ref string_, ref string_2, 0, (int)IntPtr.Zero);
	}

	static int smethod_0(string string_1, string string_2, bool bool_2)
	{
		return Operators.CompareString(string_1, string_2, bool_2);
	}

	static int smethod_1(string string_1)
	{
		return string_1.Length;
	}

	static string smethod_2(string string_1, int int_0)
	{
		return Strings.Right(string_1, int_0);
	}

	static string smethod_3(string string_1)
	{
		return string_1.ToLower();
	}

	static string smethod_4(string string_1, string string_2, string string_3)
	{
		return string_1 + string_2 + string_3;
	}

	static string smethod_5(string string_1, string string_2)
	{
		return string_1 + string_2;
	}

	static Exception smethod_6(string string_1)
	{
		return new Exception(string_1);
	}

	static string smethod_7(int int_0)
	{
		return Strings.Space(int_0);
	}

	static string smethod_8(string string_1, string string_2, string string_3, int int_0, int int_1, CompareMethod compareMethod_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		return Strings.Replace(string_1, string_2, string_3, int_0, int_1, compareMethod_0);
	}

	static int smethod_9(string string_1)
	{
		return Conversions.ToInteger(string_1);
	}

	static FileSystemProxy smethod_10(ServerComputer serverComputer_0)
	{
		return serverComputer_0.get_FileSystem();
	}

	static FileInfo smethod_11(FileSystemProxy fileSystemProxy_0, string string_1)
	{
		return fileSystemProxy_0.GetFileInfo(string_1);
	}

	static long smethod_12(FileInfo fileInfo_0)
	{
		return fileInfo_0.Length;
	}

	static void smethod_13(Exception exception_0)
	{
		ProjectData.SetProjectError(exception_0);
	}

	static void smethod_14()
	{
		ProjectData.ClearProjectError();
	}

	static bool smethod_15(object object_0)
	{
		return Versioned.IsNumeric(object_0);
	}

	static string smethod_16(object object_0)
	{
		return Conversion.Str(object_0);
	}

	static bool smethod_17(FileSystemProxy fileSystemProxy_0, string string_1)
	{
		return fileSystemProxy_0.FileExists(string_1);
	}

	static FileNotFoundException smethod_18()
	{
		return new FileNotFoundException();
	}
}
