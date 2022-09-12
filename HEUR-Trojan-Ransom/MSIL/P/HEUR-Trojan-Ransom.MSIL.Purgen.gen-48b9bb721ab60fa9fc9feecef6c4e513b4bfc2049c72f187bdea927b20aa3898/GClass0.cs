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
			bool result = default(bool);
			while (true)
			{
				int num = 736175137;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1CB0E958u) % 4u)
					{
					case 2u:
						num = ((int)num2 * -822975183) ^ -1248845403;
						continue;
					case 1u:
						result = bool_0;
						num = ((int)num2 * -2106622060) ^ 0x3EA0FA02;
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
			while (true)
			{
				int num = 1353085611;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2EE01B5Fu) % 3u)
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
					bool_0 = value;
					num = ((int)num2 * -955649187) ^ 0x198443D4;
				}
			}
		}
	}

	public int Int32_0
	{
		get
		{
			string string_ = GClass0.smethod_7(255);
			string string_2 = default(string);
			int result = default(int);
			while (true)
			{
				int num = -187146417;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC21FAE48u) % 9u)
					{
					case 8u:
						num = (int)(num2 * 447566442) ^ -386201535;
						continue;
					case 6u:
						string_2 = "set audiofile time format milliseconds";
						num = ((int)num2 * -1761886219) ^ -1517991834;
						continue;
					case 5u:
						num = (int)((num2 * 1699210338) ^ 0x55917C37);
						continue;
					case 4u:
						result = 0;
						num = (int)((num2 * 23059022) ^ 0x44DDFBF1);
						continue;
					case 2u:
						result = GClass0.smethod_9(string_);
						num = -1942648282;
						continue;
					case 1u:
					{
						string string_3 = null;
						mciSendStringA(ref string_2, ref string_3, 0, (int)IntPtr.Zero);
						string_3 = "status audiofile length";
						mciSendStringA(ref string_3, ref string_, 255, (int)IntPtr.Zero);
						string_ = GClass0.smethod_8(string_, "\0", "", 1, -1, (CompareMethod)0);
						num = (int)(num2 * 67090338) ^ -2057652523;
						continue;
					}
					case 0u:
					{
						int num3;
						int num4;
						if (GClass0.smethod_0(string_, "", bool_2: false) != 0)
						{
							num3 = 905799829;
							num4 = 905799829;
						}
						else
						{
							num3 = 171858708;
							num4 = 171858708;
						}
						num = num3 ^ (int)(num2 * 62278056);
						continue;
					}
					case 7u:
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
				int num = 1595896398;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3BB360B2u) % 5u)
					{
					case 4u:
						mciSendStringA(ref string_2, ref string_, 255, (int)IntPtr.Zero);
						string_ = GClass0.smethod_8(string_, "\0", "", 1, -1, (CompareMethod)0);
						num = (int)((num2 * 1377543640) ^ 0x70450EEF);
						continue;
					case 2u:
						string_ = GClass0.smethod_7(255);
						string_2 = "status audiofile mode";
						num = (int)((num2 * 1743503175) ^ 0x3F16C7AA);
						continue;
					case 0u:
						result = string_;
						num = ((int)num2 * -741560786) ^ 0x2785AE67;
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

	public int Int32_1
	{
		get
		{
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected I4, but got Unknown
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected I4, but got Unknown
			//IL_0093: Incompatible stack heights: 0 vs 1
			//IL_00a2: Incompatible stack heights: 0 vs 1
			//IL_00b3: Incompatible stack heights: 0 vs 1
			//IL_00ba: Incompatible stack heights: 0 vs 1
			int result = default(int);
			try
			{
				while (true)
				{
					int num = 819031451;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x2B0296BEu) % 3u)
						{
						case 1u:
							goto IL_0004;
						case 2u:
							break;
						default:
							return result;
						case 0u:
							return result;
						}
						break;
						IL_0004:
						result = checked((int)GClass0.smethod_12(GClass0.smethod_11(GClass0.smethod_10((ServerComputer)(object)Class2.Class1_0), string_0)));
						num = ((int)num2 * -150704659) ^ -631903317;
					}
				}
			}
			catch (Exception exception_)
			{
				GClass0.smethod_13(exception_);
				while (true)
				{
					_ = 476796926;
					while (true)
					{
						_003F val = /*Error near IL_0062: Stack underflow*/^ 0x2B0296BE;
						uint num2 = (uint)(int)val;
						switch (val % 5)
						{
						case 3:
							GClass0.smethod_14();
							_ = ((int)num2 * -1236626657) ^ 0x27129A3E;
							continue;
						case 2:
							_ = (num2 * 559866148) ^ 0xCFC376A9u;
							continue;
						case 1:
							result = 0;
							_ = ((int)num2 * -2102392152) ^ 0x49290A9C;
							continue;
						case 0:
							break;
						default:
							return result;
						case 4:
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
			bool flag = default(bool);
			int result = default(int);
			while (true)
			{
				int num = 396398791;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x658F6941u) % 8u)
					{
					case 7u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -1116270900;
							num4 = -1116270900;
						}
						else
						{
							num3 = -787663417;
							num4 = -787663417;
						}
						num = num3 ^ (int)(num2 * 454771825);
						continue;
					}
					case 6u:
						mciSendStringA(ref string_2, ref string_, 255, (int)IntPtr.Zero);
						flag = GClass0.smethod_15((object)string_);
						num = ((int)num2 * -1460093610) ^ 0x22468832;
						continue;
					case 5u:
						num = (int)((num2 * 1638788269) ^ 0x6E8A5B23);
						continue;
					case 2u:
						result = -1;
						num = 877043420;
						continue;
					case 1u:
						result = GClass0.smethod_9(string_);
						num = (int)(num2 * 1196687932) ^ -965917843;
						continue;
					case 0u:
						num = ((int)num2 * -401330625) ^ 0x79A21CA;
						continue;
					case 4u:
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
			string result = default(string);
			string string_2 = default(string);
			string string_ = default(string);
			while (true)
			{
				int num = -1930957674;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFABAAEC1u) % 6u)
					{
					case 4u:
						result = GClass0.smethod_16((object)string_2);
						num = (int)((num2 * 201462666) ^ 0x268CAE19);
						continue;
					case 2u:
						num = (int)((num2 * 1329889519) ^ 0x9FDD70A);
						continue;
					case 1u:
						string_2 = GClass0.smethod_7(255);
						string_ = "status audiofile channels";
						num = (int)((num2 * 1247454759) ^ 0xEE2DF58);
						continue;
					case 0u:
						mciSendStringA(ref string_, ref string_2, 255, (int)IntPtr.Zero);
						num = ((int)num2 * -10598123) ^ 0x7B34E83D;
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
			bool result = default(bool);
			while (true)
			{
				int num = -1099967268;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x99CEA5A1u) % 4u)
					{
					case 1u:
						result = bool_1;
						num = ((int)num2 * -1708039796) ^ 0x44C99679;
						continue;
					case 0u:
						num = (int)(num2 * 654578044) ^ -597236298;
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
		set
		{
			while (true)
			{
				int num = 589777410;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5F9DBF75u) % 3u)
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
					num = ((int)num2 * -1368743919) ^ -1103226710;
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
				int num = 1757483415;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5EC289F2u) % 4u)
					{
					case 2u:
						num = ((int)num2 * -709525737) ^ -343044761;
						continue;
					case 1u:
						result = string_0;
						num = ((int)num2 * -1918071181) ^ 0x2705913F;
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
				int num = -1237793704;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8A1CB6E7u) % 7u)
					{
					case 4u:
						num = -268000625;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -553857107;
							num4 = -553857107;
						}
						else
						{
							num3 = -2002223805;
							num4 = -2002223805;
						}
						num = num3 ^ ((int)num2 * -1536309011);
						continue;
					}
					case 2u:
						flag = !GClass0.smethod_17(GClass0.smethod_10((ServerComputer)(object)Class2.Class1_0), value);
						num = ((int)num2 * -740999371) ^ -540861547;
						continue;
					case 1u:
						string_0 = value;
						num = (int)(num2 * 1048345192) ^ -427800719;
						continue;
					default:
						return;
					case 0u:
						break;
					case 5u:
						throw GClass0.smethod_18();
					case 6u:
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
			int num = -646608376;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC682EAE4u) % 6u)
				{
				case 5u:
					bool_1 = false;
					String_2 = string_1;
					num = ((int)num2 * -1041844840) ^ -1408254754;
					continue;
				case 4u:
					num = (int)((num2 * 229008019) ^ 0x5B37A7BB);
					continue;
				case 3u:
					bool_0 = false;
					num = (int)((num2 * 455016486) ^ 0x5D9D4955);
					continue;
				case 2u:
					num = ((int)num2 * -320954996) ^ 0x780210C7;
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

	public void method_0()
	{
		string string_4 = default(string);
		string string_3 = default(string);
		string string_2 = default(string);
		string string_ = default(string);
		while (true)
		{
			int num = 120341897;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6A56DEE6u) % 28u)
				{
				case 27u:
				{
					int num11;
					int num12;
					if ((GClass0.smethod_0(string_0, "", bool_2: false) == 0) | (GClass0.smethod_1(String_2) <= 4))
					{
						num11 = 1914209334;
						num12 = 1914209334;
					}
					else
					{
						num11 = 1659312729;
						num12 = 1659312729;
					}
					num = num11 ^ ((int)num2 * -784478620);
					continue;
				}
				case 26u:
					string_2 = "";
					mciSendStringA(ref string_, ref string_2, 0, 0);
					num = ((int)num2 * -293287486) ^ -1536236382;
					continue;
				case 25u:
					num = 1878872896;
					continue;
				case 24u:
					string_2 = null;
					mciSendStringA(ref string_4, ref string_2, 0, (int)IntPtr.Zero);
					num = 2038712297;
					continue;
				case 23u:
					Boolean_1 = false;
					num = 1305921360;
					continue;
				case 22u:
					num = ((int)num2 * -1385538088) ^ -262046183;
					continue;
				case 20u:
					num = ((int)num2 * -440246383) ^ -85638801;
					continue;
				case 19u:
				{
					int num7;
					int num8;
					if (GClass0.smethod_0(string_3, "idi", bool_2: false) != 0)
					{
						num7 = -1377669072;
						num8 = -1377669072;
					}
					else
					{
						num7 = -1241434407;
						num8 = -1241434407;
					}
					num = num7 ^ (int)(num2 * 1959716461);
					continue;
				}
				case 18u:
					num = 577217643;
					continue;
				case 17u:
				{
					int num13;
					int num14;
					if (GClass0.smethod_0(string_3, "wav", bool_2: false) != 0)
					{
						num13 = -2056247156;
						num14 = -2056247156;
					}
					else
					{
						num13 = -1226442558;
						num14 = -1226442558;
					}
					num = num13 ^ (int)(num2 * 91541317);
					continue;
				}
				case 16u:
					string_4 = GClass0.smethod_5(string_4, " wait");
					num = ((int)num2 * -1501468953) ^ -916272994;
					continue;
				case 15u:
					string_2 = "stop midi";
					string_ = "";
					mciSendStringA(ref string_2, ref string_, 0, 0);
					string_ = "close midi";
					num = (int)(num2 * 1590689974) ^ -328424958;
					continue;
				case 13u:
					num = ((int)num2 * -1111214660) ^ -2120689616;
					continue;
				case 12u:
					string_2 = GClass0.smethod_4("open sequencer!", string_0, " alias midi");
					string_ = "";
					mciSendStringA(ref string_2, ref string_, 0, 0);
					string_ = "play midi";
					string_2 = "";
					mciSendStringA(ref string_, ref string_2, 0, 0);
					num = (int)((num2 * 505136235) ^ 0x5FE2151E);
					continue;
				case 11u:
				{
					int num9;
					int num10;
					if (GClass0.smethod_0(string_3, "mid", bool_2: false) == 0)
					{
						num9 = -1218907719;
						num10 = -1218907719;
					}
					else
					{
						num9 = -467053350;
						num10 = -467053350;
					}
					num = num9 ^ (int)(num2 * 449269609);
					continue;
				}
				case 10u:
					num = ((int)num2 * -1675657242) ^ 0x2C3A64A7;
					continue;
				case 9u:
					string_ = "play audiofile from 0";
					string_2 = null;
					mciSendStringA(ref string_, ref string_2, 0, (int)IntPtr.Zero);
					num = (int)((num2 * 1889997163) ^ 0xC255FDF);
					continue;
				case 8u:
					num = 1744074241;
					continue;
				case 7u:
					num = 1610668517;
					continue;
				case 6u:
					string_2 = GClass0.smethod_4("open \"", string_0, "\" type waveaudio alias audiofile");
					num = (int)(num2 * 1889605576) ^ -127400348;
					continue;
				case 5u:
					string_ = GClass0.smethod_4("open \"", string_0, "\" type mpegvideo alias audiofile");
					string_2 = null;
					mciSendStringA(ref string_, ref string_2, 0, (int)IntPtr.Zero);
					string_4 = "play audiofile from 0";
					num = 1832984026;
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (bool_0)
					{
						num5 = 1550969818;
						num6 = 1550969818;
					}
					else
					{
						num5 = 189623482;
						num6 = 189623482;
					}
					num = num5 ^ (int)(num2 * 570275500);
					continue;
				}
				case 3u:
				{
					string_3 = GClass0.smethod_3(GClass0.smethod_2(String_2, 3));
					int num3;
					int num4;
					if (GClass0.smethod_0(string_3, "mp3", bool_2: false) == 0)
					{
						num3 = -1541378019;
						num4 = -1541378019;
					}
					else
					{
						num3 = -1343891291;
						num4 = -1343891291;
					}
					num = num3 ^ (int)(num2 * 611871042);
					continue;
				}
				case 2u:
					string_ = null;
					mciSendStringA(ref string_2, ref string_, 0, (int)IntPtr.Zero);
					num = ((int)num2 * -1380103168) ^ -734824561;
					continue;
				case 0u:
					num = ((int)num2 * -1318337129) ^ -251669927;
					continue;
				default:
					return;
				case 14u:
					break;
				case 1u:
					throw GClass0.smethod_6("File type not supported.");
				case 21u:
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
			int num = -183659571;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAC22E766u) % 4u)
				{
				case 3u:
				{
					string string_2 = null;
					mciSendStringA(ref string_, ref string_2, 0, (int)IntPtr.Zero);
					Boolean_1 = true;
					num = ((int)num2 * -113293702) ^ 0x24394B25;
					continue;
				}
				case 1u:
					num = (int)((num2 * 417078520) ^ 0x6A4963FC);
					continue;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	public void method_2()
	{
		string string_ = default(string);
		while (true)
		{
			int num = -62612394;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBFDD682Bu) % 4u)
				{
				case 2u:
				{
					string string_2 = null;
					mciSendStringA(ref string_, ref string_2, 0, (int)IntPtr.Zero);
					Boolean_1 = false;
					num = ((int)num2 * -1310678592) ^ 0x7990AF94;
					continue;
				}
				case 1u:
					string_ = "resume audiofile";
					num = ((int)num2 * -42796863) ^ 0x1B623C74;
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

	public void method_3()
	{
		string string_ = "stop audiofile";
		string string_2 = null;
		mciSendStringA(ref string_, ref string_2, 0, (int)IntPtr.Zero);
	}

	public void method_4()
	{
		string string_2 = default(string);
		while (true)
		{
			int num = 1768369539;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x612C5857u) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 0u:
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
				string_2 = "close audiofile";
				num = ((int)num2 * -458411612) ^ 0x69AAA71;
			}
		}
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
