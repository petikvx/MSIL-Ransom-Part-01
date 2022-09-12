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
				int num = 685255273;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2581EC87u) % 3u)
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
					result = bool_0;
					num = (int)(num2 * 663166406) ^ -1302453694;
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
			int result = default(int);
			string string_ = default(string);
			bool flag = default(bool);
			while (true)
			{
				int num = 223138042;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x789049A8u) % 9u)
					{
					case 8u:
						result = GClass0.smethod_9(string_);
						num = 1946207812;
						continue;
					case 7u:
						num = ((int)num2 * -966236032) ^ 0x28062A44;
						continue;
					case 6u:
						flag = GClass0.smethod_0(string_, "", bool_2: false) == 0;
						num = ((int)num2 * -1448738631) ^ -771417246;
						continue;
					case 5u:
					{
						string string_3 = "status audiofile length";
						mciSendStringA(ref string_3, ref string_, 255, (int)IntPtr.Zero);
						string_ = GClass0.smethod_8(string_, "\0", "", 1, -1, (CompareMethod)0);
						num = ((int)num2 * -1820628305) ^ 0xB3EEA6E;
						continue;
					}
					case 4u:
						result = 0;
						num = ((int)num2 * -156423817) ^ -293959002;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -578950670;
							num4 = -578950670;
						}
						else
						{
							num3 = -1068492296;
							num4 = -1068492296;
						}
						num = num3 ^ ((int)num2 * -663157440);
						continue;
					}
					case 2u:
					{
						string_ = GClass0.smethod_7(255);
						string string_2 = "set audiofile time format milliseconds";
						string string_3 = null;
						mciSendStringA(ref string_2, ref string_3, 0, (int)IntPtr.Zero);
						num = ((int)num2 * -1853293968) ^ -1978586470;
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
	}

	public string String_0
	{
		get
		{
			string string_ = GClass0.smethod_7(255);
			string string_2 = default(string);
			string result = default(string);
			while (true)
			{
				int num = 1259212493;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6A56106Fu) % 5u)
					{
					case 3u:
						string_2 = "status audiofile mode";
						num = ((int)num2 * -1525978326) ^ 0x1BAE61C4;
						continue;
					case 2u:
						num = (int)((num2 * 436937560) ^ 0x6FDFD74E);
						continue;
					case 1u:
						mciSendStringA(ref string_2, ref string_, 255, (int)IntPtr.Zero);
						string_ = GClass0.smethod_8(string_, "\0", "", 1, -1, (CompareMethod)0);
						result = string_;
						num = ((int)num2 * -183191195) ^ -1001862807;
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
			//IL_0058: Incompatible stack heights: 0 vs 1
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
					_ = 724683512;
					while (true)
					{
						_003F val = /*Error near IL_002e: Stack underflow*/^ 0x6C5CA186;
						uint num = (uint)(int)val;
						switch (val % 4)
						{
						case 2:
							result = 0;
							_ = ((int)num * -1039249662) ^ -1040630841;
							continue;
						case 1:
							GClass0.smethod_14();
							_ = (num * 1641047081) ^ 0x2A5ABB3;
							continue;
						case 3:
							break;
						default:
							return result;
						case 0:
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
			int result = default(int);
			string string_ = default(string);
			while (true)
			{
				int num = 718454769;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5E2CF9D5u) % 7u)
					{
					case 6u:
						result = -1;
						num = (int)(num2 * 972281682) ^ -1509021111;
						continue;
					case 4u:
						num = 106478420;
						continue;
					case 3u:
						num = (int)(num2 * 1555613269) ^ -429990316;
						continue;
					case 2u:
					{
						string_ = GClass0.smethod_7(255);
						string string_2 = "status audiofile channels";
						mciSendStringA(ref string_2, ref string_, 255, (int)IntPtr.Zero);
						int num3;
						int num4;
						if (GClass0.smethod_15((object)string_))
						{
							num3 = 928998160;
							num4 = 928998160;
						}
						else
						{
							num3 = 1892676103;
							num4 = 1892676103;
						}
						num = num3 ^ (int)(num2 * 1351127600);
						continue;
					}
					case 1u:
						result = GClass0.smethod_9(string_);
						num = (int)(num2 * 1134667518) ^ -1503649852;
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

	public string String_1
	{
		get
		{
			string string_ = default(string);
			string result = default(string);
			while (true)
			{
				int num = -783691324;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC097778Du) % 4u)
					{
					case 2u:
					{
						string string_2 = "status audiofile channels";
						mciSendStringA(ref string_2, ref string_, 255, (int)IntPtr.Zero);
						result = GClass0.smethod_16((object)string_);
						num = ((int)num2 * -1114351328) ^ -22524730;
						continue;
					}
					case 1u:
						string_ = GClass0.smethod_7(255);
						num = (int)(num2 * 1196972206) ^ -1438818987;
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
				int num = -1414280593;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8EEE5D36u) % 3u)
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
					bool_1 = value;
					num = (int)(num2 * 1529021024) ^ -1416680154;
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
				int num = -1509471637;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBB49F92Au) % 4u)
					{
					case 3u:
						num = (int)((num2 * 893754457) ^ 0x78CB1E75);
						continue;
					case 1u:
						result = string_0;
						num = (int)(num2 * 218071207) ^ -395347502;
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
				int num = 134498044;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x493A7B87u) % 5u)
					{
					case 3u:
						num = 1292581811;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (GClass0.smethod_17(GClass0.smethod_10((ServerComputer)(object)Class2.Class1_0), value))
						{
							num3 = -1864693082;
							num4 = -1864693082;
						}
						else
						{
							num3 = -758267205;
							num4 = -758267205;
						}
						num = num3 ^ ((int)num2 * -416675276);
						continue;
					}
					case 2u:
						break;
					case 0u:
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
		bool_0 = false;
		bool_1 = false;
		String_2 = string_1;
	}

	public void method_0()
	{
		bool flag = default(bool);
		string string_2 = default(string);
		string string_4 = default(string);
		string string_3 = default(string);
		string string_ = default(string);
		while (true)
		{
			int num = -276363697;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9A9568A7u) % 30u)
				{
				case 28u:
					Boolean_1 = false;
					num = (int)((num2 * 24095092) ^ 0x2731026D);
					continue;
				case 27u:
				{
					int num7;
					int num8;
					if (flag)
					{
						num7 = 2112159091;
						num8 = 2112159091;
					}
					else
					{
						num7 = 851671536;
						num8 = 851671536;
					}
					num = num7 ^ ((int)num2 * -849686215);
					continue;
				}
				case 26u:
					num = -283805341;
					continue;
				case 25u:
					string_2 = "stop midi";
					string_3 = "";
					mciSendStringA(ref string_2, ref string_3, 0, 0);
					string_3 = "close midi";
					num = (int)((num2 * 1195363280) ^ 0x2E21D18D);
					continue;
				case 24u:
					string_4 = GClass0.smethod_5(string_4, " wait");
					num = ((int)num2 * -1763297462) ^ -1797539669;
					continue;
				case 23u:
					num = -1582022811;
					continue;
				case 21u:
					num = ((int)num2 * -754939039) ^ 0x16E3C93;
					continue;
				case 20u:
					num = -790717850;
					continue;
				case 19u:
					string_3 = null;
					mciSendStringA(ref string_2, ref string_3, 0, (int)IntPtr.Zero);
					string_3 = "play audiofile from 0";
					string_2 = null;
					mciSendStringA(ref string_3, ref string_2, 0, (int)IntPtr.Zero);
					num = (int)((num2 * 1192929872) ^ 0x1D14C9D4);
					continue;
				case 18u:
					num = (int)(num2 * 1322951484) ^ -1612927105;
					continue;
				case 17u:
				{
					int num5;
					int num6;
					if (GClass0.smethod_0(string_, "wav", bool_2: false) != 0)
					{
						num5 = 1211152671;
						num6 = 1211152671;
					}
					else
					{
						num5 = 829930955;
						num6 = 829930955;
					}
					num = num5 ^ (int)(num2 * 102670400);
					continue;
				}
				case 16u:
					string_2 = GClass0.smethod_4("open \"", string_0, "\" type waveaudio alias audiofile");
					num = -1231539552;
					continue;
				case 14u:
					string_2 = GClass0.smethod_4("open sequencer!", string_0, " alias midi");
					num = (int)((num2 * 357761742) ^ 0x59AE0120);
					continue;
				case 13u:
					num = (int)(num2 * 1359185264) ^ -316540620;
					continue;
				case 12u:
					flag = (GClass0.smethod_0(string_0, "", bool_2: false) == 0) | (GClass0.smethod_1(String_2) <= 4);
					num = ((int)num2 * -817362619) ^ 0x5D278684;
					continue;
				case 11u:
				{
					int num13;
					int num14;
					if (GClass0.smethod_0(string_, "mp3", bool_2: false) != 0)
					{
						num13 = -458025497;
						num14 = -458025497;
					}
					else
					{
						num13 = -1957778069;
						num14 = -1957778069;
					}
					num = num13 ^ ((int)num2 * -1582296143);
					continue;
				}
				case 10u:
					string_2 = null;
					mciSendStringA(ref string_4, ref string_2, 0, (int)IntPtr.Zero);
					num = -1205108708;
					continue;
				case 9u:
					string_3 = GClass0.smethod_4("open \"", string_0, "\" type mpegvideo alias audiofile");
					num = -1590959537;
					continue;
				case 8u:
					string_ = GClass0.smethod_3(GClass0.smethod_2(String_2, 3));
					num = (int)((num2 * 2082340425) ^ 0x2BB8EB06);
					continue;
				case 7u:
					string_3 = "";
					mciSendStringA(ref string_2, ref string_3, 0, 0);
					num = ((int)num2 * -2090290247) ^ -1075499371;
					continue;
				case 6u:
					string_2 = "";
					mciSendStringA(ref string_3, ref string_2, 0, 0);
					num = (int)((num2 * 1302880190) ^ 0x621DA89D);
					continue;
				case 5u:
					string_3 = "play midi";
					string_2 = "";
					mciSendStringA(ref string_3, ref string_2, 0, 0);
					num = ((int)num2 * -604179562) ^ -1686527626;
					continue;
				case 4u:
				{
					string_2 = null;
					mciSendStringA(ref string_3, ref string_2, 0, (int)IntPtr.Zero);
					string_4 = "play audiofile from 0";
					int num11;
					int num12;
					if (!bool_0)
					{
						num11 = 1803253255;
						num12 = 1803253255;
					}
					else
					{
						num11 = 307722989;
						num12 = 307722989;
					}
					num = num11 ^ (int)(num2 * 1655937023);
					continue;
				}
				case 3u:
					num = ((int)num2 * -424178026) ^ -205681377;
					continue;
				case 2u:
					num = -1930497414;
					continue;
				case 1u:
				{
					int num9;
					int num10;
					if (GClass0.smethod_0(string_, "idi", bool_2: false) != 0)
					{
						num9 = 1251563299;
						num10 = 1251563299;
					}
					else
					{
						num9 = 1054531451;
						num10 = 1054531451;
					}
					num = num9 ^ ((int)num2 * -1189085278);
					continue;
				}
				case 0u:
				{
					int num3;
					int num4;
					if (GClass0.smethod_0(string_, "mid", bool_2: false) == 0)
					{
						num3 = 754653285;
						num4 = 754653285;
					}
					else
					{
						num3 = 1454781948;
						num4 = 1454781948;
					}
					num = num3 ^ ((int)num2 * -1739620951);
					continue;
				}
				default:
					return;
				case 15u:
					break;
				case 29u:
					throw GClass0.smethod_6("File type not supported.");
				case 22u:
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
		while (true)
		{
			int num = -659742599;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x93B8748Du) % 3u)
				{
				case 1u:
					goto IL_001f;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_001f:
				Boolean_1 = true;
				num = (int)(num2 * 1312350535) ^ -1731690614;
			}
		}
	}

	public void method_2()
	{
		string string_ = "resume audiofile";
		while (true)
		{
			int num = 1058249539;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x391AE056u) % 4u)
				{
				case 1u:
				{
					string string_2 = null;
					mciSendStringA(ref string_, ref string_2, 0, (int)IntPtr.Zero);
					num = ((int)num2 * -2027630184) ^ -1110655650;
					continue;
				}
				case 0u:
					Boolean_1 = false;
					num = (int)(num2 * 1695494773) ^ -1303025552;
					continue;
				default:
					return;
				case 3u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	public void method_3()
	{
		string string_ = "stop audiofile";
		while (true)
		{
			int num = 818337265;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7B0CBDA9u) % 3u)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0008:
				string string_2 = null;
				mciSendStringA(ref string_, ref string_2, 0, (int)IntPtr.Zero);
				num = ((int)num2 * -1672335866) ^ 0x66A64829;
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
