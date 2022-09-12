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
				int num = -438546986;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBC9C0B0Au) % 3u)
					{
					case 2u:
						goto IL_0009;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0009:
					num = ((int)num2 * -1717923788) ^ -56932740;
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
			string string_2 = "set audiofile time format milliseconds";
			string string_3 = null;
			mciSendStringA(ref string_2, ref string_3, 0, (int)IntPtr.Zero);
			bool flag = default(bool);
			int result = default(int);
			while (true)
			{
				int num = -457506988;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9F58925Bu) % 8u)
					{
					case 7u:
						string_3 = "status audiofile length";
						mciSendStringA(ref string_3, ref string_, 255, (int)IntPtr.Zero);
						string_ = GClass0.smethod_8(string_, "\0", "", 1, -1, (CompareMethod)0);
						flag = GClass0.smethod_0(string_, "", bool_2: false) == 0;
						num = (int)(num2 * 1183800283) ^ -986515174;
						continue;
					case 6u:
						num = ((int)num2 * -882692129) ^ 0x741C8FD3;
						continue;
					case 5u:
						num = ((int)num2 * -85595041) ^ -115109598;
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 1088333932;
							num4 = 1088333932;
						}
						else
						{
							num3 = 2084607238;
							num4 = 2084607238;
						}
						num = num3 ^ ((int)num2 * -614391207);
						continue;
					}
					case 3u:
						result = 0;
						num = ((int)num2 * -531704099) ^ 0x2C165CAA;
						continue;
					case 1u:
						result = GClass0.smethod_9(string_);
						num = -1905332050;
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

	public string String_0
	{
		get
		{
			string string_ = GClass0.smethod_7(255);
			string string_2 = "status audiofile mode";
			mciSendStringA(ref string_2, ref string_, 255, (int)IntPtr.Zero);
			string result = default(string);
			while (true)
			{
				int num = -200531495;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBE4BAFE8u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -417507680) ^ 0x7D57F804;
						continue;
					case 1u:
						string_ = GClass0.smethod_8(string_, "\0", "", 1, -1, (CompareMethod)0);
						result = string_;
						num = ((int)num2 * -1380892810) ^ -455600015;
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
					int num = 1738109755;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x7FFD2DBCu) % 3u)
						{
						case 2u:
							goto IL_0004;
						case 0u:
							break;
						default:
							return result;
						case 1u:
							return result;
						}
						break;
						IL_0004:
						result = checked((int)GClass0.smethod_12(GClass0.smethod_11(GClass0.smethod_10((ServerComputer)(object)Class2.Class1_0), string_0)));
						num = (int)(num2 * 1414978165) ^ -1938501211;
					}
				}
			}
			catch (Exception exception_)
			{
				GClass0.smethod_13(exception_);
				while (true)
				{
					_ = 1069295756;
					while (true)
					{
						_003F val = /*Error near IL_0062: Stack underflow*/^ 0x7FFD2DBC;
						uint num2 = (uint)(int)val;
						switch (val % 3)
						{
						case 2:
							result = 0;
							_ = ((int)num2 * -450519244) ^ 0x7A74007C;
							continue;
						case 0:
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
			int result = default(int);
			string string_ = default(string);
			bool flag = default(bool);
			while (true)
			{
				int num = -2075764378;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE3ADEB1Fu) % 8u)
					{
					case 6u:
						result = GClass0.smethod_9(string_);
						num = ((int)num2 * -585147249) ^ 0x6EEA4D6E;
						continue;
					case 5u:
						result = -1;
						num = -1090508977;
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1000855938;
							num4 = 1000855938;
						}
						else
						{
							num3 = 678938105;
							num4 = 678938105;
						}
						num = num3 ^ ((int)num2 * -2136654372);
						continue;
					}
					case 3u:
						num = (int)(num2 * 1888779730) ^ -525686237;
						continue;
					case 1u:
					{
						string_ = GClass0.smethod_7(255);
						string string_2 = "status audiofile channels";
						mciSendStringA(ref string_2, ref string_, 255, (int)IntPtr.Zero);
						flag = GClass0.smethod_15((object)string_);
						num = ((int)num2 * -445695889) ^ -334759828;
						continue;
					}
					case 0u:
						num = (int)((num2 * 483085949) ^ 0x2B57155);
						continue;
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

	public string String_1
	{
		get
		{
			string string_ = GClass0.smethod_7(255);
			string string_2 = default(string);
			string result = default(string);
			while (true)
			{
				int num = 1920045718;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x330C1F06u) % 6u)
					{
					case 5u:
						mciSendStringA(ref string_2, ref string_, 255, (int)IntPtr.Zero);
						num = ((int)num2 * -235444674) ^ -843390594;
						continue;
					case 4u:
						string_2 = "status audiofile channels";
						num = ((int)num2 * -436727716) ^ 0x146E9285;
						continue;
					case 2u:
						result = GClass0.smethod_16((object)string_);
						num = (int)(num2 * 699942207) ^ -1759388359;
						continue;
					case 1u:
						num = ((int)num2 * -92013915) ^ -1595499996;
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
			bool result = bool_1;
			while (true)
			{
				int num = -1849257972;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDC910104u) % 3u)
					{
					case 2u:
						goto IL_0009;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0009:
					num = (int)((num2 * 1143806272) ^ 0x4DB5FB13);
				}
			}
		}
		set
		{
			while (true)
			{
				int num = -1515865606;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x800640BEu) % 3u)
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
					num = (int)((num2 * 1768430971) ^ 0x1D3F71FF);
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
				int num = 2101376512;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5195DE4Au) % 3u)
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
					result = string_0;
					num = ((int)num2 * -1607281398) ^ -1966610141;
				}
			}
		}
		set
		{
			while (true)
			{
				int num = 1319273137;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x38D92C7Eu) % 5u)
					{
					case 2u:
					{
						int num3;
						int num4;
						if (!GClass0.smethod_17(GClass0.smethod_10((ServerComputer)(object)Class2.Class1_0), value))
						{
							num3 = -1352343473;
							num4 = -1352343473;
						}
						else
						{
							num3 = -2123250202;
							num4 = -2123250202;
						}
						num = num3 ^ (int)(num2 * 1845499835);
						continue;
					}
					case 0u:
						string_0 = value;
						num = 657010495;
						continue;
					default:
						return;
					case 3u:
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
			int num = -1522391167;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xED42A41Cu) % 6u)
				{
				case 5u:
					num = (int)((num2 * 1047598178) ^ 0x1EB32B05);
					continue;
				case 4u:
					bool_1 = false;
					String_2 = string_1;
					num = (int)(num2 * 1778867626) ^ -1687426421;
					continue;
				case 3u:
					num = ((int)num2 * -1462572936) ^ -1626408276;
					continue;
				case 0u:
					bool_0 = false;
					num = ((int)num2 * -1378377570) ^ -292359194;
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

	public void method_0()
	{
		string string_4 = default(string);
		string string_3 = default(string);
		bool flag2 = default(bool);
		bool flag = default(bool);
		string string_2 = default(string);
		string string_ = default(string);
		while (true)
		{
			int num = 196969059;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7C56245Cu) % 31u)
				{
				case 30u:
					string_2 = "play audiofile from 0";
					num = (int)((num2 * 2143222888) ^ 0x18A784C9);
					continue;
				case 29u:
				{
					int num5;
					int num6;
					if (GClass0.smethod_0(string_4, "mp3", bool_2: false) != 0)
					{
						num5 = 1506380201;
						num6 = 1506380201;
					}
					else
					{
						num5 = 1630995382;
						num6 = 1630995382;
					}
					num = num5 ^ ((int)num2 * -11868975);
					continue;
				}
				case 28u:
				{
					int num11;
					int num12;
					if (GClass0.smethod_0(string_4, "wav", bool_2: false) != 0)
					{
						num11 = -202139973;
						num12 = -202139973;
					}
					else
					{
						num11 = -296034030;
						num12 = -296034030;
					}
					num = num11 ^ (int)(num2 * 765880610);
					continue;
				}
				case 27u:
					string_ = "stop midi";
					num = ((int)num2 * -1575833005) ^ -988079947;
					continue;
				case 26u:
					string_2 = "play midi";
					num = (int)((num2 * 283468196) ^ 0x4F05FCFC);
					continue;
				case 25u:
					string_2 = GClass0.smethod_4("open \"", string_0, "\" type mpegvideo alias audiofile");
					string_ = null;
					mciSendStringA(ref string_2, ref string_, 0, (int)IntPtr.Zero);
					string_3 = "play audiofile from 0";
					num = ((int)num2 * -1762680229) ^ 0x374202A8;
					continue;
				case 24u:
					string_3 = GClass0.smethod_5(string_3, " wait");
					num = ((int)num2 * -1828378031) ^ -660689271;
					continue;
				case 23u:
					num = 219134695;
					continue;
				case 22u:
				{
					int num7;
					int num8;
					if (!flag2)
					{
						num7 = -1669100358;
						num8 = -1669100358;
					}
					else
					{
						num7 = -780016445;
						num8 = -780016445;
					}
					num = num7 ^ ((int)num2 * -1636846365);
					continue;
				}
				case 21u:
					string_ = "";
					mciSendStringA(ref string_2, ref string_, 0, 0);
					num = ((int)num2 * -44450280) ^ 0x41129205;
					continue;
				case 20u:
				{
					int num13;
					int num14;
					if (flag)
					{
						num13 = -1576650328;
						num14 = -1576650328;
					}
					else
					{
						num13 = -753331267;
						num14 = -753331267;
					}
					num = num13 ^ (int)(num2 * 1582463420);
					continue;
				}
				case 19u:
					num = 1042165988;
					continue;
				case 18u:
				{
					int num9;
					int num10;
					if (GClass0.smethod_0(string_4, "mid", bool_2: false) != 0)
					{
						num9 = 24684558;
						num10 = 24684558;
					}
					else
					{
						num9 = 1911827896;
						num10 = 1911827896;
					}
					num = num9 ^ (int)(num2 * 1685396126);
					continue;
				}
				case 17u:
					string_2 = null;
					mciSendStringA(ref string_, ref string_2, 0, (int)IntPtr.Zero);
					num = ((int)num2 * -236815273) ^ 0xE1A1D81;
					continue;
				case 16u:
					num = (int)(num2 * 315244195) ^ -512629653;
					continue;
				case 15u:
				{
					int num3;
					int num4;
					if (GClass0.smethod_0(string_4, "idi", bool_2: false) == 0)
					{
						num3 = 1663667546;
						num4 = 1663667546;
					}
					else
					{
						num3 = 554690364;
						num4 = 554690364;
					}
					num = num3 ^ (int)(num2 * 270713661);
					continue;
				}
				case 14u:
					flag2 = (GClass0.smethod_0(string_0, "", bool_2: false) == 0) | (GClass0.smethod_1(String_2) <= 4);
					num = ((int)num2 * -618137177) ^ -1854081688;
					continue;
				case 13u:
					flag = bool_0;
					num = ((int)num2 * -1126704293) ^ -620255596;
					continue;
				case 12u:
					num = 1837440786;
					continue;
				case 11u:
					string_4 = GClass0.smethod_3(GClass0.smethod_2(String_2, 3));
					num = 349130638;
					continue;
				case 10u:
					num = 1923473778;
					continue;
				case 9u:
					num = ((int)num2 * -1850739713) ^ -29816283;
					continue;
				case 8u:
					num = ((int)num2 * -1984268498) ^ -947919214;
					continue;
				case 7u:
					Boolean_1 = false;
					num = ((int)num2 * -926678419) ^ 0x4257F394;
					continue;
				case 4u:
					string_ = GClass0.smethod_4("open \"", string_0, "\" type waveaudio alias audiofile");
					num = ((int)num2 * -185963426) ^ 0x614BE5E5;
					continue;
				case 3u:
					string_2 = "";
					mciSendStringA(ref string_, ref string_2, 0, 0);
					string_2 = "close midi";
					string_ = "";
					mciSendStringA(ref string_2, ref string_, 0, 0);
					string_ = GClass0.smethod_4("open sequencer!", string_0, " alias midi");
					string_2 = "";
					mciSendStringA(ref string_, ref string_2, 0, 0);
					num = ((int)num2 * -1422637998) ^ 0x4FBDA443;
					continue;
				case 2u:
					string_ = null;
					mciSendStringA(ref string_3, ref string_, 0, (int)IntPtr.Zero);
					num = 1843474978;
					continue;
				case 1u:
					string_ = null;
					mciSendStringA(ref string_2, ref string_, 0, (int)IntPtr.Zero);
					num = (int)(num2 * 1448296794) ^ -243672160;
					continue;
				default:
					return;
				case 0u:
					break;
				case 5u:
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
		string string_2 = null;
		mciSendStringA(ref string_, ref string_2, 0, (int)IntPtr.Zero);
		while (true)
		{
			int num = 1004459047;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1F2062CCu) % 3u)
				{
				case 2u:
					goto IL_001f;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_001f:
				Boolean_1 = true;
				num = ((int)num2 * -1065607545) ^ 0x5B7C6D85;
			}
		}
	}

	public void method_2()
	{
		string string_ = default(string);
		while (true)
		{
			int num = 1552572549;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x535FBDD9u) % 5u)
				{
				case 3u:
				{
					string string_2 = null;
					mciSendStringA(ref string_, ref string_2, 0, (int)IntPtr.Zero);
					num = ((int)num2 * -2023817162) ^ -2021351876;
					continue;
				}
				case 1u:
					string_ = "resume audiofile";
					num = (int)(num2 * 404115495) ^ -76431446;
					continue;
				case 0u:
					Boolean_1 = false;
					num = (int)((num2 * 1570617060) ^ 0x4FE1756E);
					continue;
				default:
					return;
				case 4u:
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
		string string_ = default(string);
		while (true)
		{
			int num = 717664648;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x34DCEBC1u) % 4u)
				{
				case 3u:
				{
					string string_2 = null;
					mciSendStringA(ref string_, ref string_2, 0, (int)IntPtr.Zero);
					num = (int)((num2 * 1876148672) ^ 0x5F5EBEA3);
					continue;
				}
				case 1u:
					string_ = "stop audiofile";
					num = ((int)num2 * -608747996) ^ -1097166630;
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
