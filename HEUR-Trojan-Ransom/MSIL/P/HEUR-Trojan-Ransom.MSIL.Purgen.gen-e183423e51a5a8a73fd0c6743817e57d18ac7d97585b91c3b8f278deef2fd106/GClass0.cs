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
			string string_ = default(string);
			string string_2 = default(string);
			int result = default(int);
			while (true)
			{
				int num = -1222547679;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA04F951Eu) % 11u)
					{
					case 10u:
						string_ = "status audiofile length";
						num = (int)(num2 * 1344672189) ^ -1411138822;
						continue;
					case 9u:
					{
						int num3;
						int num4;
						if (GClass0.smethod_0(string_2, "", bool_2: false) == 0)
						{
							num3 = 20798014;
							num4 = 20798014;
						}
						else
						{
							num3 = 324333673;
							num4 = 324333673;
						}
						num = num3 ^ (int)(num2 * 1749451494);
						continue;
					}
					case 8u:
						num = ((int)num2 * -1844716149) ^ 0xDC14900;
						continue;
					case 7u:
						result = 0;
						num = (int)(num2 * 1475273931) ^ -512924325;
						continue;
					case 6u:
						num = ((int)num2 * -281487774) ^ -479457213;
						continue;
					case 3u:
						result = GClass0.smethod_9(string_2);
						num = (int)((num2 * 169414932) ^ 0x307BAA7E);
						continue;
					case 2u:
					{
						string_2 = GClass0.smethod_7(255);
						string string_3 = "set audiofile time format milliseconds";
						string_ = null;
						mciSendStringA(ref string_3, ref string_, 0, (int)IntPtr.Zero);
						num = (int)(num2 * 542942515) ^ -1370534858;
						continue;
					}
					case 1u:
						num = -1686836094;
						continue;
					case 0u:
						mciSendStringA(ref string_, ref string_2, 255, (int)IntPtr.Zero);
						string_2 = GClass0.smethod_8(string_2, "\0", "", 1, -1, (CompareMethod)0);
						num = (int)(num2 * 971740023) ^ -809435797;
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
				int num = -10327029;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA0EB2264u) % 3u)
					{
					case 1u:
						goto IL_002c;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_002c:
					string_ = GClass0.smethod_8(string_, "\0", "", 1, -1, (CompareMethod)0);
					result = string_;
					num = ((int)num2 * -1820675419) ^ -280364983;
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
					_ = 729871643;
					while (true)
					{
						_003F val = /*Error near IL_002e: Stack underflow*/^ 0x53C79D66;
						uint num = (uint)(int)val;
						switch (val % 4)
						{
						case 2:
							GClass0.smethod_14();
							_ = ((int)num * -1668502942) ^ 0x60BA4E32;
							continue;
						case 1:
							result = 0;
							_ = (num * 487661286) ^ 0x83B4E876u;
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
			string string_2 = default(string);
			string string_ = default(string);
			bool flag = default(bool);
			int result = default(int);
			while (true)
			{
				int num = 16589151;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x79618DCAu) % 9u)
					{
					case 8u:
						mciSendStringA(ref string_2, ref string_, 255, (int)IntPtr.Zero);
						num = (int)(num2 * 55866582) ^ -281886439;
						continue;
					case 7u:
						string_ = GClass0.smethod_7(255);
						string_2 = "status audiofile channels";
						num = (int)((num2 * 896644867) ^ 0x4CBFD632);
						continue;
					case 6u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1483015174;
							num4 = 1483015174;
						}
						else
						{
							num3 = 926678723;
							num4 = 926678723;
						}
						num = num3 ^ (int)(num2 * 1928152482);
						continue;
					}
					case 4u:
						flag = GClass0.smethod_15((object)string_);
						num = (int)((num2 * 1363751686) ^ 0x1493B1FB);
						continue;
					case 3u:
						num = (int)((num2 * 1000612008) ^ 0x536CFEE1);
						continue;
					case 2u:
						result = -1;
						num = 828875505;
						continue;
					case 0u:
						result = GClass0.smethod_9(string_);
						num = ((int)num2 * -154012961) ^ -919421559;
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

	public string String_1
	{
		get
		{
			string string_2 = default(string);
			string string_ = default(string);
			string result = default(string);
			while (true)
			{
				int num = -32974317;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCEB2C7A6u) % 6u)
					{
					case 4u:
						mciSendStringA(ref string_2, ref string_, 255, (int)IntPtr.Zero);
						num = (int)(num2 * 1569174947) ^ -111862413;
						continue;
					case 3u:
						string_ = GClass0.smethod_7(255);
						string_2 = "status audiofile channels";
						num = ((int)num2 * -1763983170) ^ -1419178668;
						continue;
					case 2u:
						num = ((int)num2 * -1408643477) ^ 0xB5C6E57;
						continue;
					case 1u:
						result = GClass0.smethod_16((object)string_);
						num = (int)((num2 * 50226388) ^ 0x3C797D6E);
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
				int num = -804357265;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCBD6E5D6u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -887225984) ^ 0x3EA03D8;
						continue;
					case 1u:
						result = bool_1;
						num = (int)(num2 * 1482008850) ^ -894484021;
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
			bool_1 = value;
		}
	}

	public string String_2
	{
		get
		{
			string result = string_0;
			while (true)
			{
				int num = 1769878681;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x28E675FBu) % 3u)
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
					num = ((int)num2 * -915566838) ^ 0x69C1CFDF;
				}
			}
		}
		set
		{
			bool flag = default(bool);
			while (true)
			{
				int num = -1083965859;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8E900098u) % 7u)
					{
					case 5u:
						flag = !GClass0.smethod_17(GClass0.smethod_10((ServerComputer)(object)Class2.Class1_0), value);
						num = (int)(num2 * 1181301358) ^ -1464371047;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -2047583330;
							num4 = -2047583330;
						}
						else
						{
							num3 = -2124633371;
							num4 = -2124633371;
						}
						num = num3 ^ ((int)num2 * -1203279356);
						continue;
					}
					case 2u:
						string_0 = value;
						num = ((int)num2 * -2045885732) ^ -704263277;
						continue;
					case 0u:
						num = -1070665442;
						continue;
					default:
						return;
					case 4u:
						break;
					case 6u:
						throw GClass0.smethod_18();
					case 1u:
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
		bool flag = (GClass0.smethod_0(string_0, "", bool_2: false) == 0) | (GClass0.smethod_1(String_2) <= 4);
		string string_3 = default(string);
		string string_4 = default(string);
		bool flag2 = default(bool);
		string string_2 = default(string);
		string string_ = default(string);
		while (true)
		{
			int num = 1244413017;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1FDBD756u) % 29u)
				{
				case 28u:
					string_ = null;
					mciSendStringA(ref string_3, ref string_, 0, (int)IntPtr.Zero);
					num = 1344498966;
					continue;
				case 27u:
					string_4 = GClass0.smethod_3(GClass0.smethod_2(String_2, 3));
					num = 1278694485;
					continue;
				case 26u:
				{
					int num5;
					int num6;
					if (GClass0.smethod_0(string_4, "wav", bool_2: false) != 0)
					{
						num5 = -234305932;
						num6 = -234305932;
					}
					else
					{
						num5 = -2106520183;
						num6 = -2106520183;
					}
					num = num5 ^ ((int)num2 * -1172380103);
					continue;
				}
				case 25u:
					string_2 = "play midi";
					string_ = "";
					mciSendStringA(ref string_2, ref string_, 0, 0);
					num = (int)(num2 * 1894210127) ^ -1692221213;
					continue;
				case 23u:
					num = 1395116753;
					continue;
				case 22u:
				{
					int num11;
					int num12;
					if (!flag2)
					{
						num11 = 114448618;
						num12 = 114448618;
					}
					else
					{
						num11 = 875541690;
						num12 = 875541690;
					}
					num = num11 ^ ((int)num2 * -444093334);
					continue;
				}
				case 21u:
					num = ((int)num2 * -1257219824) ^ 0x2095F48C;
					continue;
				case 20u:
					string_2 = GClass0.smethod_4("open \"", string_0, "\" type mpegvideo alias audiofile");
					num = 330235831;
					continue;
				case 19u:
					num = (int)((num2 * 221462294) ^ 0x1E2E8F4);
					continue;
				case 18u:
					string_3 = GClass0.smethod_5(string_3, " wait");
					num = ((int)num2 * -1235566042) ^ 0x283E9FE8;
					continue;
				case 17u:
					num = ((int)num2 * -186468008) ^ -256577434;
					continue;
				case 16u:
				{
					int num13;
					int num14;
					if (flag)
					{
						num13 = 66505701;
						num14 = 66505701;
					}
					else
					{
						num13 = 824285254;
						num14 = 824285254;
					}
					num = num13 ^ (int)(num2 * 51123118);
					continue;
				}
				case 15u:
					string_2 = "";
					mciSendStringA(ref string_, ref string_2, 0, 0);
					string_2 = "close midi";
					num = (int)((num2 * 1315857819) ^ 0x36656646);
					continue;
				case 14u:
					string_ = null;
					mciSendStringA(ref string_2, ref string_, 0, (int)IntPtr.Zero);
					num = (int)((num2 * 1462928954) ^ 0x6671E0A1);
					continue;
				case 13u:
				{
					int num9;
					int num10;
					if (GClass0.smethod_0(string_4, "idi", bool_2: false) != 0)
					{
						num9 = 1631457872;
						num10 = 1631457872;
					}
					else
					{
						num9 = 1375748145;
						num10 = 1375748145;
					}
					num = num9 ^ ((int)num2 * -1113210749);
					continue;
				}
				case 12u:
					Boolean_1 = false;
					num = 661931420;
					continue;
				case 11u:
					num = 1713178622;
					continue;
				case 10u:
					num = (int)((num2 * 2104122640) ^ 0x26EAF041);
					continue;
				case 7u:
					string_2 = null;
					mciSendStringA(ref string_, ref string_2, 0, (int)IntPtr.Zero);
					string_2 = "play audiofile from 0";
					num = (int)((num2 * 1187232476) ^ 0x3D8A0C24);
					continue;
				case 6u:
				{
					int num7;
					int num8;
					if (GClass0.smethod_0(string_4, "mp3", bool_2: false) != 0)
					{
						num7 = 139119301;
						num8 = 139119301;
					}
					else
					{
						num7 = 1922973826;
						num8 = 1922973826;
					}
					num = num7 ^ ((int)num2 * -422855241);
					continue;
				}
				case 5u:
				{
					int num3;
					int num4;
					if (GClass0.smethod_0(string_4, "mid", bool_2: false) == 0)
					{
						num3 = -373715438;
						num4 = -373715438;
					}
					else
					{
						num3 = -915674785;
						num4 = -915674785;
					}
					num = num3 ^ (int)(num2 * 10299137);
					continue;
				}
				case 4u:
					string_3 = "play audiofile from 0";
					flag2 = bool_0;
					num = ((int)num2 * -1363879130) ^ 0x74B8CDA3;
					continue;
				case 3u:
					string_ = "stop midi";
					num = 576513697;
					continue;
				case 2u:
					string_ = GClass0.smethod_4("open \"", string_0, "\" type waveaudio alias audiofile");
					num = (int)(num2 * 1644813275) ^ -893788;
					continue;
				case 1u:
					string_ = "";
					mciSendStringA(ref string_2, ref string_, 0, 0);
					string_ = GClass0.smethod_4("open sequencer!", string_0, " alias midi");
					string_2 = "";
					mciSendStringA(ref string_, ref string_2, 0, 0);
					num = ((int)num2 * -507098384) ^ 0x2AD761F7;
					continue;
				case 0u:
					string_ = null;
					mciSendStringA(ref string_2, ref string_, 0, (int)IntPtr.Zero);
					num = (int)(num2 * 1282076759) ^ -1182607612;
					continue;
				default:
					return;
				case 24u:
					break;
				case 9u:
					throw GClass0.smethod_6("File type not supported.");
				case 8u:
					return;
				}
				break;
			}
		}
	}

	public void method_1()
	{
		string string_2 = default(string);
		while (true)
		{
			int num = 194386236;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3F3DDB4Bu) % 6u)
				{
				case 5u:
					string_2 = "pause audiofile";
					num = ((int)num2 * -940023297) ^ 0x71D14535;
					continue;
				case 4u:
					num = (int)((num2 * 933481731) ^ 0x19EF81EB);
					continue;
				case 1u:
				{
					string string_ = null;
					mciSendStringA(ref string_2, ref string_, 0, (int)IntPtr.Zero);
					num = ((int)num2 * -1972578798) ^ 0x77EA2BD3;
					continue;
				}
				case 0u:
					Boolean_1 = true;
					num = ((int)num2 * -440578995) ^ -1328521261;
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

	public void method_2()
	{
		string string_ = default(string);
		while (true)
		{
			int num = -1207335954;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEF705DABu) % 4u)
				{
				case 2u:
				{
					string string_2 = null;
					mciSendStringA(ref string_, ref string_2, 0, (int)IntPtr.Zero);
					Boolean_1 = false;
					num = (int)((num2 * 1563614317) ^ 0x6C977CA);
					continue;
				}
				case 1u:
					string_ = "resume audiofile";
					num = ((int)num2 * -31115695) ^ 0x51B4A414;
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
		string string_ = "close audiofile";
		while (true)
		{
			int num = -380997978;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB79CB5F6u) % 3u)
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
				num = ((int)num2 * -2095407047) ^ 0x1A80C659;
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
