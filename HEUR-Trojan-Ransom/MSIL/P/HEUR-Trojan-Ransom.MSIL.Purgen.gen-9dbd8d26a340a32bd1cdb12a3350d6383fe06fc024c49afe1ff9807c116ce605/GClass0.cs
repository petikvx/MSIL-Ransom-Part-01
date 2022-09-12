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
			return bool_0;
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
			int result = default(int);
			while (true)
			{
				int num = -1407608648;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF2A39C56u) % 11u)
					{
					case 10u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -1877147795;
							num4 = -1877147795;
						}
						else
						{
							num3 = -1931239999;
							num4 = -1931239999;
						}
						num = num3 ^ (int)(num2 * 2135671842);
						continue;
					}
					case 9u:
						num = ((int)num2 * -606842846) ^ 0x206638DA;
						continue;
					case 8u:
						string_ = GClass0.smethod_8(string_, "\0", "", 1, -1, (CompareMethod)0);
						num = ((int)num2 * -1114771230) ^ -686236142;
						continue;
					case 7u:
					{
						string string_2 = "set audiofile time format milliseconds";
						string string_3 = null;
						mciSendStringA(ref string_2, ref string_3, 0, (int)IntPtr.Zero);
						string_3 = "status audiofile length";
						mciSendStringA(ref string_3, ref string_, 255, (int)IntPtr.Zero);
						num = (int)(num2 * 535633711) ^ -64304913;
						continue;
					}
					case 6u:
						num = -1445576295;
						continue;
					case 4u:
						flag = GClass0.smethod_0(string_, "", bool_2: false) == 0;
						num = (int)((num2 * 1068618667) ^ 0x505362B5);
						continue;
					case 3u:
						num = ((int)num2 * -1309636081) ^ 0x2B817F8A;
						continue;
					case 2u:
						result = GClass0.smethod_9(string_);
						num = (int)(num2 * 1514453716) ^ -497054162;
						continue;
					case 0u:
						result = 0;
						num = ((int)num2 * -91429248) ^ 0x58850C08;
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
	}

	public string String_0
	{
		get
		{
			string string_ = default(string);
			string result = default(string);
			while (true)
			{
				int num = 395059195;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x30B1F7A0u) % 5u)
					{
					case 3u:
					{
						string_ = GClass0.smethod_7(255);
						string string_2 = "status audiofile mode";
						mciSendStringA(ref string_2, ref string_, 255, (int)IntPtr.Zero);
						num = (int)(num2 * 1240811339) ^ -298972737;
						continue;
					}
					case 1u:
						result = string_;
						num = ((int)num2 * -433032101) ^ 0x27B18595;
						continue;
					case 0u:
						string_ = GClass0.smethod_8(string_, "\0", "", 1, -1, (CompareMethod)0);
						num = ((int)num2 * -1994418571) ^ 0x3352F56;
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

	public int Int32_1
	{
		get
		{
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Expected I4, but got Unknown
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Expected I4, but got Unknown
			//IL_005f: Incompatible stack heights: 0 vs 1
			//IL_006e: Incompatible stack heights: 0 vs 1
			//IL_007f: Incompatible stack heights: 0 vs 1
			//IL_0086: Incompatible stack heights: 0 vs 1
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
					_ = -1188461478;
					while (true)
					{
						_003F val = /*Error near IL_002e: Stack underflow*/^ -1295340121;
						uint num = (uint)(int)val;
						switch (val % 5)
						{
						case 4:
							GClass0.smethod_14();
							_ = ((int)num * -391336554) ^ -1276881171;
							continue;
						case 2:
							_ = (num * 1524380450) ^ 0x75B78CC5;
							continue;
						case 1:
							result = 0;
							_ = (num * 1521452811) ^ 0x92E23D60u;
							continue;
						case 0:
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
			bool flag = default(bool);
			string string_ = default(string);
			int result = default(int);
			while (true)
			{
				int num = 143614038;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3E5C2C4Eu) % 11u)
					{
					case 9u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 309714281;
							num4 = 309714281;
						}
						else
						{
							num3 = 1020142350;
							num4 = 1020142350;
						}
						num = num3 ^ (int)(num2 * 1088412451);
						continue;
					}
					case 8u:
					{
						string string_2 = "status audiofile channels";
						mciSendStringA(ref string_2, ref string_, 255, (int)IntPtr.Zero);
						num = (int)((num2 * 1720675242) ^ 0x385E8A09);
						continue;
					}
					case 7u:
						num = 759969979;
						continue;
					case 5u:
						result = -1;
						num = (int)(num2 * 235963106) ^ -1657442632;
						continue;
					case 4u:
						result = GClass0.smethod_9(string_);
						num = (int)(num2 * 1948092234) ^ -1958191678;
						continue;
					case 3u:
						num = ((int)num2 * -1556517219) ^ -572710326;
						continue;
					case 2u:
						flag = GClass0.smethod_15((object)string_);
						num = ((int)num2 * -1056899327) ^ 0x7165652D;
						continue;
					case 1u:
						string_ = GClass0.smethod_7(255);
						num = ((int)num2 * -670521900) ^ 0x6E6F66C1;
						continue;
					case 0u:
						num = ((int)num2 * -2056301704) ^ -1486197404;
						continue;
					case 10u:
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
			while (true)
			{
				int num = -1471579946;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x826821F3u) % 5u)
					{
					case 3u:
						result = GClass0.smethod_16((object)string_2);
						num = (int)(num2 * 2099939142) ^ -222734183;
						continue;
					case 1u:
						string_2 = GClass0.smethod_7(255);
						num = (int)(num2 * 208353765) ^ -586773274;
						continue;
					case 0u:
					{
						string string_ = "status audiofile channels";
						mciSendStringA(ref string_, ref string_2, 255, (int)IntPtr.Zero);
						num = (int)(num2 * 125385326) ^ -2102903435;
						continue;
					}
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

	public bool Boolean_1
	{
		get
		{
			bool result = default(bool);
			while (true)
			{
				int num = -1165319675;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEA8EF090u) % 4u)
					{
					case 1u:
						result = bool_1;
						num = ((int)num2 * -1269612500) ^ -1212064112;
						continue;
					case 0u:
						num = (int)((num2 * 1909408979) ^ 0x3D14BEEA);
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
		set
		{
			while (true)
			{
				int num = -1936664253;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFEDEABD7u) % 3u)
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
					num = (int)((num2 * 255136164) ^ 0x7AD141B4);
				}
			}
		}
	}

	public string String_2
	{
		get
		{
			return string_0;
		}
		set
		{
			bool flag = default(bool);
			while (true)
			{
				int num = 1909926599;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x70A911C2u) % 5u)
					{
					case 4u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -245499607;
							num4 = -245499607;
						}
						else
						{
							num3 = -1438038710;
							num4 = -1438038710;
						}
						num = num3 ^ ((int)num2 * -946045092);
						continue;
					}
					case 1u:
						flag = !GClass0.smethod_17(GClass0.smethod_10((ServerComputer)(object)Class2.Class1_0), value);
						num = (int)(num2 * 1290048079) ^ -1128837080;
						continue;
					case 2u:
						break;
					case 3u:
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
		string string_3 = default(string);
		string string_4 = default(string);
		string string_2 = default(string);
		bool flag = default(bool);
		string string_ = default(string);
		while (true)
		{
			int num = -1962362657;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA562416Du) % 31u)
				{
				case 30u:
					num = -517106513;
					continue;
				case 29u:
				{
					int num13;
					int num14;
					if (GClass0.smethod_0(string_3, "idi", bool_2: false) == 0)
					{
						num13 = -164647534;
						num14 = -164647534;
					}
					else
					{
						num13 = -1503836701;
						num14 = -1503836701;
					}
					num = num13 ^ (int)(num2 * 447165299);
					continue;
				}
				case 28u:
					string_4 = GClass0.smethod_5(string_4, " wait");
					num = (int)((num2 * 980343640) ^ 0x11033C9F);
					continue;
				case 27u:
					num = -134968503;
					continue;
				case 26u:
					Boolean_1 = false;
					num = -1727605759;
					continue;
				case 25u:
					string_2 = null;
					mciSendStringA(ref string_4, ref string_2, 0, (int)IntPtr.Zero);
					num = -1484534915;
					continue;
				case 24u:
					num = -1111431240;
					continue;
				case 23u:
					num = -1213253006;
					continue;
				case 22u:
					num = (int)(num2 * 538446349) ^ -918973512;
					continue;
				case 21u:
					num = (int)((num2 * 733026350) ^ 0x24132AA0);
					continue;
				case 20u:
					string_ = "";
					mciSendStringA(ref string_2, ref string_, 0, 0);
					num = (int)((num2 * 1477314765) ^ 0x5ED29E93);
					continue;
				case 19u:
					num = (int)((num2 * 1999834036) ^ 0x46454DCC);
					continue;
				case 18u:
					flag = (GClass0.smethod_0(string_0, "", bool_2: false) == 0) | (GClass0.smethod_1(String_2) <= 4);
					num = ((int)num2 * -2125755631) ^ -449783624;
					continue;
				case 17u:
					string_2 = "stop midi";
					num = ((int)num2 * -640325204) ^ 0x54E1356B;
					continue;
				case 16u:
				{
					int num11;
					int num12;
					if (!flag)
					{
						num11 = 628137278;
						num12 = 628137278;
					}
					else
					{
						num11 = 970624849;
						num12 = 970624849;
					}
					num = num11 ^ (int)(num2 * 105063273);
					continue;
				}
				case 15u:
					num = -154073223;
					continue;
				case 14u:
					string_ = "close midi";
					string_2 = "";
					mciSendStringA(ref string_, ref string_2, 0, 0);
					num = (int)((num2 * 193458011) ^ 0x79FDD95);
					continue;
				case 13u:
					string_ = GClass0.smethod_4("open \"", string_0, "\" type mpegvideo alias audiofile");
					num = ((int)num2 * -1838803293) ^ -300733164;
					continue;
				case 12u:
				{
					int num9;
					int num10;
					if (GClass0.smethod_0(string_3, "mid", bool_2: false) != 0)
					{
						num9 = -1508781466;
						num10 = -1508781466;
					}
					else
					{
						num9 = -1883585893;
						num10 = -1883585893;
					}
					num = num9 ^ (int)(num2 * 2105024705);
					continue;
				}
				case 10u:
					num = (int)(num2 * 981150263) ^ -349460796;
					continue;
				case 9u:
				{
					string_3 = GClass0.smethod_3(GClass0.smethod_2(String_2, 3));
					int num7;
					int num8;
					if (GClass0.smethod_0(string_3, "mp3", bool_2: false) != 0)
					{
						num7 = 463444295;
						num8 = 463444295;
					}
					else
					{
						num7 = 1164371310;
						num8 = 1164371310;
					}
					num = num7 ^ ((int)num2 * -879110922);
					continue;
				}
				case 8u:
					string_2 = GClass0.smethod_4("open \"", string_0, "\" type waveaudio alias audiofile");
					num = (int)(num2 * 1850170506) ^ -1351405919;
					continue;
				case 6u:
					string_2 = GClass0.smethod_4("open sequencer!", string_0, " alias midi");
					num = (int)(num2 * 1209462229) ^ -1871357932;
					continue;
				case 5u:
					num = ((int)num2 * -2049621727) ^ -411993325;
					continue;
				case 4u:
					string_ = null;
					mciSendStringA(ref string_2, ref string_, 0, (int)IntPtr.Zero);
					string_ = "play audiofile from 0";
					string_2 = null;
					mciSendStringA(ref string_, ref string_2, 0, (int)IntPtr.Zero);
					num = (int)((num2 * 774727430) ^ 0xBA7AF3E);
					continue;
				case 2u:
				{
					string_2 = null;
					mciSendStringA(ref string_, ref string_2, 0, (int)IntPtr.Zero);
					string_4 = "play audiofile from 0";
					int num5;
					int num6;
					if (bool_0)
					{
						num5 = 981100540;
						num6 = 981100540;
					}
					else
					{
						num5 = 1455940564;
						num6 = 1455940564;
					}
					num = num5 ^ ((int)num2 * -1170081851);
					continue;
				}
				case 1u:
				{
					int num3;
					int num4;
					if (GClass0.smethod_0(string_3, "wav", bool_2: false) == 0)
					{
						num3 = -1492118595;
						num4 = -1492118595;
					}
					else
					{
						num3 = -1601689111;
						num4 = -1601689111;
					}
					num = num3 ^ ((int)num2 * -91326725);
					continue;
				}
				case 0u:
					string_ = "";
					mciSendStringA(ref string_2, ref string_, 0, 0);
					string_ = "play midi";
					string_2 = "";
					mciSendStringA(ref string_, ref string_2, 0, 0);
					num = (int)((num2 * 471431874) ^ 0x6ECC8D1F);
					continue;
				default:
					return;
				case 7u:
					break;
				case 3u:
					throw GClass0.smethod_6("File type not supported.");
				case 11u:
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
			int num = -1540511392;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB5116924u) % 3u)
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
				num = (int)(num2 * 1177611997) ^ -1733330928;
			}
		}
	}

	public void method_2()
	{
		string string_ = default(string);
		while (true)
		{
			int num = 984168369;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6D6C9480u) % 6u)
				{
				case 5u:
					num = (int)(num2 * 383126697) ^ -167653479;
					continue;
				case 3u:
					Boolean_1 = false;
					num = ((int)num2 * -1280649410) ^ -658960517;
					continue;
				case 2u:
				{
					string string_2 = null;
					mciSendStringA(ref string_, ref string_2, 0, (int)IntPtr.Zero);
					num = (int)(num2 * 1311217398) ^ -731382219;
					continue;
				}
				case 1u:
					string_ = "resume audiofile";
					num = ((int)num2 * -1936714196) ^ -1914036168;
					continue;
				default:
					return;
				case 4u:
					break;
				case 0u:
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
