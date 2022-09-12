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
				int num = -226289606;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF9F450CDu) % 4u)
					{
					case 3u:
						result = bool_0;
						num = (int)((num2 * 697834585) ^ 0x34CD37D7);
						continue;
					case 1u:
						num = (int)(num2 * 900076154) ^ -1823141887;
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
				int num = -398997758;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF274AB03u) % 3u)
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
					bool_0 = value;
					num = ((int)num2 * -1001454505) ^ -964162169;
				}
			}
		}
	}

	public int Int32_0
	{
		get
		{
			string string_ = default(string);
			string string_2 = default(string);
			string string_3 = default(string);
			int result = default(int);
			while (true)
			{
				int num = -1060359990;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB6C04E03u) % 9u)
					{
					case 8u:
						mciSendStringA(ref string_, ref string_2, 255, (int)IntPtr.Zero);
						num = (int)(num2 * 1491013154) ^ -274677374;
						continue;
					case 7u:
						string_2 = GClass0.smethod_7(255);
						string_3 = "set audiofile time format milliseconds";
						num = (int)(num2 * 353090949) ^ -488695156;
						continue;
					case 6u:
						result = GClass0.smethod_9(string_2);
						num = -774570774;
						continue;
					case 5u:
						result = 0;
						num = ((int)num2 * -1111931059) ^ -289808360;
						continue;
					case 4u:
						string_ = null;
						mciSendStringA(ref string_3, ref string_, 0, (int)IntPtr.Zero);
						num = (int)((num2 * 1076899170) ^ 0x351B57BD);
						continue;
					case 3u:
					{
						string_2 = GClass0.smethod_8(string_2, "\0", "", 1, -1, (CompareMethod)0);
						int num3;
						int num4;
						if (GClass0.smethod_0(string_2, "", bool_2: false) != 0)
						{
							num3 = 1696871295;
							num4 = 1696871295;
						}
						else
						{
							num3 = 1434418588;
							num4 = 1434418588;
						}
						num = num3 ^ ((int)num2 * -2019960469);
						continue;
					}
					case 1u:
						string_ = "status audiofile length";
						num = ((int)num2 * -1919758921) ^ 0x72DE8252;
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

	public string String_0
	{
		get
		{
			string string_ = GClass0.smethod_7(255);
			string result = default(string);
			while (true)
			{
				int num = -1925744533;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC464B33Bu) % 5u)
					{
					case 4u:
					{
						string string_2 = "status audiofile mode";
						mciSendStringA(ref string_2, ref string_, 255, (int)IntPtr.Zero);
						num = ((int)num2 * -1900119684) ^ -1475854776;
						continue;
					}
					case 3u:
						result = string_;
						num = ((int)num2 * -222934561) ^ 0x43C3D56;
						continue;
					case 1u:
						string_ = GClass0.smethod_8(string_, "\0", "", 1, -1, (CompareMethod)0);
						num = ((int)num2 * -125796749) ^ 0x7D02EFBF;
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
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected I4, but got Unknown
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Expected I4, but got Unknown
			//IL_0088: Incompatible stack heights: 0 vs 1
			//IL_008f: Incompatible stack heights: 0 vs 1
			int result = default(int);
			try
			{
				while (true)
				{
					int num = -1427382493;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0xB29CF040u) % 3u)
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
						num = (int)(num2 * 777777821) ^ -470454586;
					}
				}
			}
			catch (Exception exception_)
			{
				GClass0.smethod_13(exception_);
				while (true)
				{
					_ = -1470865068;
					while (true)
					{
						_003F val = /*Error near IL_0062: Stack underflow*/^ -1298337728;
						uint num2 = (uint)(int)val;
						switch (val % 3)
						{
						case 1:
							result = 0;
							_ = ((int)num2 * -1696378815) ^ -1256572210;
							continue;
						case 2:
							break;
						default:
							GClass0.smethod_14();
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
			string string_ = default(string);
			bool flag = default(bool);
			int result = default(int);
			while (true)
			{
				int num = 1254007656;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x375B697u) % 7u)
					{
					case 6u:
					{
						string_ = GClass0.smethod_7(255);
						string string_2 = "status audiofile channels";
						mciSendStringA(ref string_2, ref string_, 255, (int)IntPtr.Zero);
						flag = GClass0.smethod_15((object)string_);
						num = ((int)num2 * -1529990499) ^ -358325129;
						continue;
					}
					case 5u:
						result = -1;
						num = 587014726;
						continue;
					case 3u:
						result = GClass0.smethod_9(string_);
						num = ((int)num2 * -493215218) ^ -1957967707;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -235326102;
							num4 = -235326102;
						}
						else
						{
							num3 = -805805255;
							num4 = -805805255;
						}
						num = num3 ^ ((int)num2 * -1183720103);
						continue;
					}
					case 0u:
						num = (int)((num2 * 1654345174) ^ 0x8E62715);
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
			string string_ = default(string);
			string result = default(string);
			while (true)
			{
				int num = 1818469091;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2F63BE63u) % 5u)
					{
					case 4u:
					{
						string string_2 = "status audiofile channels";
						mciSendStringA(ref string_2, ref string_, 255, (int)IntPtr.Zero);
						result = GClass0.smethod_16((object)string_);
						num = ((int)num2 * -36598360) ^ -209039700;
						continue;
					}
					case 3u:
						string_ = GClass0.smethod_7(255);
						num = ((int)num2 * -1417655202) ^ 0x738FD550;
						continue;
					case 2u:
						num = (int)((num2 * 2098761454) ^ 0x487FB165);
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
			bool result = default(bool);
			while (true)
			{
				int num = 1905443270;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x56BD81B0u) % 3u)
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
					result = bool_1;
					num = (int)((num2 * 2143295769) ^ 0x228AE79E);
				}
			}
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
				int num = 637667426;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x572238D1u) % 4u)
					{
					case 3u:
						result = string_0;
						num = (int)(num2 * 1106351196) ^ -1777168204;
						continue;
					case 1u:
						num = (int)(num2 * 298956153) ^ -2084549078;
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
				int num = 171295217;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7CAE8F18u) % 5u)
					{
					case 4u:
					{
						int num3;
						int num4;
						if (!GClass0.smethod_17(GClass0.smethod_10((ServerComputer)(object)Class2.Class1_0), value))
						{
							num3 = -1619035874;
							num4 = -1619035874;
						}
						else
						{
							num3 = -11711422;
							num4 = -11711422;
						}
						num = num3 ^ ((int)num2 * -1162458653);
						continue;
					}
					case 1u:
						string_0 = value;
						num = 51690726;
						continue;
					default:
						return;
					case 0u:
						break;
					case 2u:
						throw GClass0.smethod_18();
					case 3u:
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
		bool flag2 = default(bool);
		string string_2 = default(string);
		string string_3 = default(string);
		string string_ = default(string);
		bool flag = default(bool);
		string string_4 = default(string);
		while (true)
		{
			int num = 446892727;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6E46C402u) % 33u)
				{
				case 30u:
					flag2 = (GClass0.smethod_0(string_0, "", bool_2: false) == 0) | (GClass0.smethod_1(String_2) <= 4);
					num = (int)(num2 * 939844039) ^ -265390813;
					continue;
				case 29u:
					num = 283490220;
					continue;
				case 28u:
					string_2 = GClass0.smethod_5(string_2, " wait");
					num = ((int)num2 * -1991093247) ^ -827254779;
					continue;
				case 27u:
				{
					int num13;
					int num14;
					if (GClass0.smethod_0(string_3, "mid", bool_2: false) != 0)
					{
						num13 = 189280841;
						num14 = 189280841;
					}
					else
					{
						num13 = 1530123082;
						num14 = 1530123082;
					}
					num = num13 ^ ((int)num2 * -742159749);
					continue;
				}
				case 26u:
					num = (int)((num2 * 886002845) ^ 0x5C4256E5);
					continue;
				case 25u:
					num = ((int)num2 * -1128344214) ^ 0x3634B60B;
					continue;
				case 24u:
					string_ = null;
					mciSendStringA(ref string_4, ref string_, 0, (int)IntPtr.Zero);
					num = ((int)num2 * -1754614586) ^ -1916727624;
					continue;
				case 23u:
					string_2 = "play audiofile from 0";
					flag = bool_0;
					num = ((int)num2 * -834803857) ^ 0x5EDD8BBF;
					continue;
				case 22u:
					string_4 = "";
					mciSendStringA(ref string_, ref string_4, 0, 0);
					num = (int)(num2 * 757442060) ^ -2137533100;
					continue;
				case 21u:
					num = 886465446;
					continue;
				case 20u:
				{
					string_3 = GClass0.smethod_3(GClass0.smethod_2(String_2, 3));
					int num5;
					int num6;
					if (GClass0.smethod_0(string_3, "mp3", bool_2: false) != 0)
					{
						num5 = 897318285;
						num6 = 897318285;
					}
					else
					{
						num5 = 1918081939;
						num6 = 1918081939;
					}
					num = num5 ^ (int)(num2 * 381000471);
					continue;
				}
				case 19u:
				{
					int num11;
					int num12;
					if (GClass0.smethod_0(string_3, "wav", bool_2: false) != 0)
					{
						num11 = -794359908;
						num12 = -794359908;
					}
					else
					{
						num11 = -1792135635;
						num12 = -1792135635;
					}
					num = num11 ^ (int)(num2 * 514313175);
					continue;
				}
				case 18u:
					string_4 = "";
					mciSendStringA(ref string_, ref string_4, 0, 0);
					num = (int)((num2 * 1694675568) ^ 0x18253DD2);
					continue;
				case 17u:
					string_4 = null;
					mciSendStringA(ref string_, ref string_4, 0, (int)IntPtr.Zero);
					string_4 = "play audiofile from 0";
					num = (int)(num2 * 283466881) ^ -643042150;
					continue;
				case 16u:
				{
					int num9;
					int num10;
					if (GClass0.smethod_0(string_3, "idi", bool_2: false) != 0)
					{
						num9 = -1795371423;
						num10 = -1795371423;
					}
					else
					{
						num9 = -663385059;
						num10 = -663385059;
					}
					num = num9 ^ (int)(num2 * 334805024);
					continue;
				}
				case 15u:
					num = 729997350;
					continue;
				case 14u:
				{
					int num7;
					int num8;
					if (flag2)
					{
						num7 = 1510184174;
						num8 = 1510184174;
					}
					else
					{
						num7 = 1864289810;
						num8 = 1864289810;
					}
					num = num7 ^ (int)(num2 * 1009902536);
					continue;
				}
				case 13u:
					Boolean_1 = false;
					num = (int)((num2 * 1757474232) ^ 0x282FCE74);
					continue;
				case 11u:
					string_ = GClass0.smethod_4("open \"", string_0, "\" type waveaudio alias audiofile");
					num = 1162216948;
					continue;
				case 10u:
					string_ = "";
					mciSendStringA(ref string_4, ref string_, 0, 0);
					num = (int)(num2 * 368773674) ^ -81531567;
					continue;
				case 9u:
					string_ = null;
					mciSendStringA(ref string_4, ref string_, 0, (int)IntPtr.Zero);
					num = (int)(num2 * 88840801) ^ -333378364;
					continue;
				case 8u:
					string_ = "stop midi";
					num = 546905902;
					continue;
				case 7u:
					num = (int)((num2 * 583159798) ^ 0x15A22DF9);
					continue;
				case 6u:
					string_ = GClass0.smethod_4("open sequencer!", string_0, " alias midi");
					num = (int)(num2 * 262254930) ^ -27031692;
					continue;
				case 5u:
					string_4 = "close midi";
					num = ((int)num2 * -1564749715) ^ -301599750;
					continue;
				case 4u:
					num = (int)(num2 * 480258311) ^ -708668087;
					continue;
				case 3u:
					string_4 = "play midi";
					string_ = "";
					mciSendStringA(ref string_4, ref string_, 0, 0);
					num = ((int)num2 * -1061015784) ^ 0x25623619;
					continue;
				case 2u:
					string_4 = GClass0.smethod_4("open \"", string_0, "\" type mpegvideo alias audiofile");
					num = 1400238568;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 2076564467;
						num4 = 2076564467;
					}
					else
					{
						num3 = 1519473652;
						num4 = 1519473652;
					}
					num = num3 ^ (int)(num2 * 1195818520);
					continue;
				}
				case 0u:
					string_ = null;
					mciSendStringA(ref string_2, ref string_, 0, (int)IntPtr.Zero);
					num = 1889737737;
					continue;
				default:
					return;
				case 32u:
					break;
				case 31u:
					throw GClass0.smethod_6("File type not supported.");
				case 12u:
					return;
				}
				break;
			}
		}
	}

	public void method_1()
	{
		while (true)
		{
			int num = -7107502;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x83E1EB38u) % 4u)
				{
				case 2u:
				{
					string string_ = "pause audiofile";
					string string_2 = null;
					mciSendStringA(ref string_, ref string_2, 0, (int)IntPtr.Zero);
					num = (int)(num2 * 1496240924) ^ -1366586539;
					continue;
				}
				case 1u:
					Boolean_1 = true;
					num = ((int)num2 * -1811573605) ^ -406525040;
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

	public void method_2()
	{
		string string_ = default(string);
		while (true)
		{
			int num = -1472927874;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDC4382DCu) % 4u)
				{
				case 3u:
				{
					string string_2 = null;
					mciSendStringA(ref string_, ref string_2, 0, (int)IntPtr.Zero);
					Boolean_1 = false;
					num = (int)((num2 * 209671297) ^ 0x1C295C36);
					continue;
				}
				case 2u:
					string_ = "resume audiofile";
					num = (int)(num2 * 1411864694) ^ -897588941;
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

	public void method_3()
	{
		string string_2 = default(string);
		while (true)
		{
			int num = -286244524;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF4719193u) % 3u)
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
				string_2 = "stop audiofile";
				num = ((int)num2 * -402526119) ^ -1326947072;
			}
		}
	}

	public void method_4()
	{
		string string_ = "close audiofile";
		while (true)
		{
			int num = 2060588317;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x13AD738u) % 3u)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0008:
				string string_2 = null;
				mciSendStringA(ref string_, ref string_2, 0, (int)IntPtr.Zero);
				num = ((int)num2 * -109646376) ^ -271495544;
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
