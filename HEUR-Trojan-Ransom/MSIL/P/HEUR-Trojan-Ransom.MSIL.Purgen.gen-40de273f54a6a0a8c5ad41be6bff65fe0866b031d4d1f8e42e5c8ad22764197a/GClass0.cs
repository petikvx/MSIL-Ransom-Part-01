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
				int num = -185499624;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x802DB7DEu) % 3u)
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
					result = bool_0;
					num = ((int)num2 * -137502762) ^ -1363632872;
				}
			}
		}
		set
		{
			bool_0 = value;
		}
	}

	public int Int32_0
	{
		get
		{
			string string_ = GClass0.smethod_7(255);
			bool flag = default(bool);
			string string_2 = default(string);
			string string_3 = default(string);
			int result = default(int);
			while (true)
			{
				int num = 1157499028;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x375CA89u) % 13u)
					{
					case 12u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -1914118257;
							num4 = -1914118257;
						}
						else
						{
							num3 = -2067014792;
							num4 = -2067014792;
						}
						num = num3 ^ ((int)num2 * -803646682);
						continue;
					}
					case 10u:
						string_2 = null;
						mciSendStringA(ref string_3, ref string_2, 0, (int)IntPtr.Zero);
						num = ((int)num2 * -1254558166) ^ 0xD2D1034;
						continue;
					case 9u:
						string_2 = "status audiofile length";
						num = ((int)num2 * -1629128324) ^ -673335197;
						continue;
					case 8u:
						result = GClass0.smethod_9(string_);
						num = ((int)num2 * -1536480934) ^ -658535201;
						continue;
					case 7u:
						flag = GClass0.smethod_0(string_, "", bool_2: false) == 0;
						num = ((int)num2 * -2127845975) ^ 0x298485A;
						continue;
					case 6u:
						num = (int)((num2 * 1977955263) ^ 0x5546D811);
						continue;
					case 5u:
						num = 548405052;
						continue;
					case 4u:
						string_ = GClass0.smethod_8(string_, "\0", "", 1, -1, (CompareMethod)0);
						num = ((int)num2 * -1059282647) ^ -362700687;
						continue;
					case 3u:
						result = 0;
						num = (int)(num2 * 888793875) ^ -306914557;
						continue;
					case 1u:
						string_3 = "set audiofile time format milliseconds";
						num = ((int)num2 * -1633616369) ^ 0x2A0168AD;
						continue;
					case 0u:
						mciSendStringA(ref string_2, ref string_, 255, (int)IntPtr.Zero);
						num = ((int)num2 * -975828866) ^ -556309772;
						continue;
					case 11u:
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
			string string_ = GClass0.smethod_7(255);
			string string_2 = "status audiofile mode";
			string result = default(string);
			while (true)
			{
				int num = -1523097219;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8AEC6A73u) % 5u)
					{
					case 2u:
						result = string_;
						num = ((int)num2 * -1458362897) ^ 0x52F2B547;
						continue;
					case 1u:
						mciSendStringA(ref string_2, ref string_, 255, (int)IntPtr.Zero);
						num = (int)(num2 * 1696028220) ^ -1789340202;
						continue;
					case 0u:
						string_ = GClass0.smethod_8(string_, "\0", "", 1, -1, (CompareMethod)0);
						num = (int)((num2 * 597001880) ^ 0x50F3BC56);
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
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Expected I4, but got Unknown
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected I4, but got Unknown
			//IL_005b: Incompatible stack heights: 0 vs 1
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
					_ = 2005490057;
					while (true)
					{
						_003F val = /*Error near IL_002e: Stack underflow*/^ 0xD5EBA84;
						uint num = (uint)(int)val;
						switch (val % 4)
						{
						case 3:
							GClass0.smethod_14();
							_ = ((int)num * -587534268) ^ 0x5AD74C46;
							continue;
						case 1:
							result = 0;
							_ = ((int)num * -562113613) ^ -1226204788;
							continue;
						case 0:
							break;
						default:
							return result;
						case 2:
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
			int result = default(int);
			string string_2 = default(string);
			while (true)
			{
				int num = 925522979;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x37705651u) % 9u)
					{
					case 8u:
						result = -1;
						num = 20353172;
						continue;
					case 7u:
						result = GClass0.smethod_9(string_);
						num = (int)(num2 * 843945380) ^ -1048792758;
						continue;
					case 6u:
						num = (int)((num2 * 962335343) ^ 0x50C9587);
						continue;
					case 4u:
						mciSendStringA(ref string_2, ref string_, 255, (int)IntPtr.Zero);
						num = ((int)num2 * -1488759400) ^ -313242220;
						continue;
					case 3u:
						num = ((int)num2 * -1449046756) ^ 0x5C323FB2;
						continue;
					case 1u:
						string_2 = "status audiofile channels";
						num = (int)((num2 * 1449415316) ^ 0x2DEBA0DC);
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (GClass0.smethod_15((object)string_))
						{
							num3 = 1169639496;
							num4 = 1169639496;
						}
						else
						{
							num3 = 278719225;
							num4 = 278719225;
						}
						num = num3 ^ ((int)num2 * -337968598);
						continue;
					}
					case 5u:
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
			string string_ = GClass0.smethod_7(255);
			string string_2 = default(string);
			string result = default(string);
			while (true)
			{
				int num = 1832232521;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2653B86Fu) % 6u)
					{
					case 5u:
						num = ((int)num2 * -1284674698) ^ -54391709;
						continue;
					case 2u:
						string_2 = "status audiofile channels";
						num = ((int)num2 * -629934490) ^ 0x76DD941A;
						continue;
					case 1u:
						mciSendStringA(ref string_2, ref string_, 255, (int)IntPtr.Zero);
						num = (int)(num2 * 1792992747) ^ -747230534;
						continue;
					case 0u:
						result = GClass0.smethod_16((object)string_);
						num = (int)((num2 * 399435200) ^ 0x14D71802);
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
			bool_1 = value;
		}
	}

	public string String_2
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = 94780627;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1DC7F7DCu) % 4u)
					{
					case 3u:
						result = string_0;
						num = (int)(num2 * 174579941) ^ -1530631718;
						continue;
					case 1u:
						num = (int)((num2 * 999006956) ^ 0x7E5D956E);
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
			bool flag = !GClass0.smethod_17(GClass0.smethod_10((ServerComputer)(object)Class2.Class1_0), value);
			while (true)
			{
				int num = -1482014682;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC52A755Au) % 5u)
					{
					case 3u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -1391854898;
							num4 = -1391854898;
						}
						else
						{
							num3 = -1851480467;
							num4 = -1851480467;
						}
						num = num3 ^ ((int)num2 * -1578102578);
						continue;
					}
					case 2u:
						string_0 = value;
						num = -678775003;
						continue;
					default:
						return;
					case 0u:
						break;
					case 1u:
						throw GClass0.smethod_18();
					case 4u:
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
			int num = 228762590;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3C7463E5u) % 6u)
				{
				case 3u:
					bool_0 = false;
					bool_1 = false;
					num = (int)(num2 * 562339673) ^ -538668228;
					continue;
				case 2u:
					String_2 = string_1;
					num = ((int)num2 * -1744083449) ^ 0x23D6E629;
					continue;
				case 1u:
					num = (int)(num2 * 1697756231) ^ -105190591;
					continue;
				case 0u:
					num = ((int)num2 * -1310182334) ^ -1117510712;
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

	public void method_0()
	{
		string string_3 = default(string);
		bool flag = default(bool);
		string string_ = default(string);
		string string_2 = default(string);
		string string_4 = default(string);
		while (true)
		{
			int num = 1238167846;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6ABEC439u) % 29u)
				{
				case 28u:
				{
					int num13;
					int num14;
					if (GClass0.smethod_0(string_3, "mp3", bool_2: false) == 0)
					{
						num13 = 11066336;
						num14 = 11066336;
					}
					else
					{
						num13 = 227544555;
						num14 = 227544555;
					}
					num = num13 ^ ((int)num2 * -323726629);
					continue;
				}
				case 27u:
					num = 350516609;
					continue;
				case 26u:
				{
					int num11;
					int num12;
					if (GClass0.smethod_0(string_3, "idi", bool_2: false) == 0)
					{
						num11 = 571466532;
						num12 = 571466532;
					}
					else
					{
						num11 = 165255600;
						num12 = 165255600;
					}
					num = num11 ^ ((int)num2 * -1634176223);
					continue;
				}
				case 24u:
					string_2 = "";
					mciSendStringA(ref string_, ref string_2, 0, 0);
					num = (int)(num2 * 566256267) ^ -1110666503;
					continue;
				case 23u:
				{
					int num7;
					int num8;
					if (!flag)
					{
						num7 = 1413476687;
						num8 = 1413476687;
					}
					else
					{
						num7 = 1428584137;
						num8 = 1428584137;
					}
					num = num7 ^ ((int)num2 * -52251705);
					continue;
				}
				case 22u:
					num = (int)(num2 * 513816523) ^ -543721782;
					continue;
				case 21u:
					num = 1720041147;
					continue;
				case 20u:
					num = (int)(num2 * 920723443) ^ -1803453311;
					continue;
				case 18u:
					string_ = "stop midi";
					num = ((int)num2 * -521758720) ^ -1763717551;
					continue;
				case 17u:
					Boolean_1 = false;
					num = ((int)num2 * -163499235) ^ 0x2DFFB649;
					continue;
				case 16u:
				{
					int num9;
					int num10;
					if (GClass0.smethod_0(string_3, "wav", bool_2: false) == 0)
					{
						num9 = -1704489282;
						num10 = -1704489282;
					}
					else
					{
						num9 = -2029450280;
						num10 = -2029450280;
					}
					num = num9 ^ ((int)num2 * -550432742);
					continue;
				}
				case 15u:
					num = ((int)num2 * -1843381797) ^ 0x4135F4C4;
					continue;
				case 14u:
					num = ((int)num2 * -1141489687) ^ -1149275572;
					continue;
				case 13u:
					num = 1562701980;
					continue;
				case 12u:
					string_ = GClass0.smethod_4("open \"", string_0, "\" type waveaudio alias audiofile");
					string_2 = null;
					mciSendStringA(ref string_, ref string_2, 0, (int)IntPtr.Zero);
					string_2 = "play audiofile from 0";
					string_ = null;
					mciSendStringA(ref string_2, ref string_, 0, (int)IntPtr.Zero);
					num = ((int)num2 * -2031863940) ^ 0x730DB871;
					continue;
				case 11u:
					string_4 = GClass0.smethod_5(string_4, " wait");
					num = (int)((num2 * 1090761392) ^ 0x3CA8910A);
					continue;
				case 10u:
				{
					int num5;
					int num6;
					if ((GClass0.smethod_0(string_0, "", bool_2: false) == 0) | (GClass0.smethod_1(String_2) <= 4))
					{
						num5 = -165243905;
						num6 = -165243905;
					}
					else
					{
						num5 = -516280898;
						num6 = -516280898;
					}
					num = num5 ^ ((int)num2 * -1363478418);
					continue;
				}
				case 8u:
					string_2 = GClass0.smethod_4("open \"", string_0, "\" type mpegvideo alias audiofile");
					string_ = null;
					mciSendStringA(ref string_2, ref string_, 0, (int)IntPtr.Zero);
					string_4 = "play audiofile from 0";
					flag = bool_0;
					num = 184778522;
					continue;
				case 7u:
					string_2 = "play midi";
					string_ = "";
					mciSendStringA(ref string_2, ref string_, 0, 0);
					num = ((int)num2 * -1069044815) ^ -1716975642;
					continue;
				case 6u:
					num = 2077973277;
					continue;
				case 5u:
					string_ = null;
					mciSendStringA(ref string_4, ref string_, 0, (int)IntPtr.Zero);
					num = 537593058;
					continue;
				case 4u:
					string_ = "";
					mciSendStringA(ref string_2, ref string_, 0, 0);
					num = ((int)num2 * -1484862100) ^ -1454062407;
					continue;
				case 3u:
					string_2 = "close midi";
					num = (int)((num2 * 226447491) ^ 0x12E8C719);
					continue;
				case 2u:
					string_3 = GClass0.smethod_3(GClass0.smethod_2(String_2, 3));
					num = 1239279233;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (GClass0.smethod_0(string_3, "mid", bool_2: false) == 0)
					{
						num3 = 231706979;
						num4 = 231706979;
					}
					else
					{
						num3 = 1838465918;
						num4 = 1838465918;
					}
					num = num3 ^ ((int)num2 * -2094965997);
					continue;
				}
				case 0u:
					string_ = GClass0.smethod_4("open sequencer!", string_0, " alias midi");
					string_2 = "";
					mciSendStringA(ref string_, ref string_2, 0, 0);
					num = ((int)num2 * -1458772649) ^ 0x3A2EFBF2;
					continue;
				default:
					return;
				case 19u:
					break;
				case 9u:
					throw GClass0.smethod_6("File type not supported.");
				case 25u:
					return;
				}
				break;
			}
		}
	}

	public void method_1()
	{
		string string_ = "pause audiofile";
		string string_2 = null;
		mciSendStringA(ref string_, ref string_2, 0, (int)IntPtr.Zero);
		Boolean_1 = true;
		while (true)
		{
			int num = 2134842031;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4C88FC36u) % 3u)
				{
				case 2u:
					goto IL_0026;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0026:
				num = ((int)num2 * -1008660136) ^ 0x3786C1A2;
			}
		}
	}

	public void method_2()
	{
		string string_ = default(string);
		while (true)
		{
			int num = -664671711;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEC547A76u) % 5u)
				{
				case 2u:
				{
					string string_2 = null;
					mciSendStringA(ref string_, ref string_2, 0, (int)IntPtr.Zero);
					Boolean_1 = false;
					num = (int)((num2 * 2127619062) ^ 0xAB42972);
					continue;
				}
				case 1u:
					string_ = "resume audiofile";
					num = (int)((num2 * 1807657558) ^ 0x2ABE4D44);
					continue;
				case 0u:
					num = ((int)num2 * -499992079) ^ 0x543094E8;
					continue;
				default:
					return;
				case 4u:
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
			int num = -1719663462;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE755EAFBu) % 4u)
				{
				case 1u:
					string_2 = "close audiofile";
					num = ((int)num2 * -2130210924) ^ -1971996677;
					continue;
				case 0u:
				{
					string string_ = null;
					mciSendStringA(ref string_2, ref string_, 0, (int)IntPtr.Zero);
					num = ((int)num2 * -1158820147) ^ 0x55229578;
					continue;
				}
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
