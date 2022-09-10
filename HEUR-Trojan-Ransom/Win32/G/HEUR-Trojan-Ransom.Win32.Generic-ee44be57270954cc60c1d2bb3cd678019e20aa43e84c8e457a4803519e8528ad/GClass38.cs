using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;

public class GClass38 : GClass37
{
	[Serializable]
	[CompilerGenerated]
	private sealed class Class15
	{
		public static readonly Class15 _003C_003E9 = new Class15();

		public static GDelegate1<string, GClass38> _003C_003E9__18_0;

		public static GDelegate1<string, GClass38> _003C_003E9__21_0;

		public static GDelegate1<string, GClass38> _003C_003E9__22_0;

		public static GDelegate1<string, GClass38> _003C_003E9__23_0;

		public static GDelegate1<string, GClass39> _003C_003E9__24_0;

		public static GDelegate1<string, GClass39> _003C_003E9__25_0;

		public static GDelegate1<string, GClass39> _003C_003E9__26_0;

		public static GDelegate1<string, GClass37> _003C_003E9__27_0;

		public static GDelegate1<string, GClass37> _003C_003E9__28_0;

		public static GDelegate1<string, GClass37> _003C_003E9__29_0;

		internal GClass38 method_0(string string_0)
		{
			return new GClass38(string_0);
		}

		internal GClass38 method_1(string string_0)
		{
			return new GClass38(string_0);
		}

		internal GClass38 method_2(string string_0)
		{
			return new GClass38(string_0);
		}

		internal GClass38 method_3(string string_0)
		{
			return new GClass38(string_0);
		}

		internal GClass39 method_4(string string_0)
		{
			return new GClass39(string_0);
		}

		internal GClass39 method_5(string string_0)
		{
			return new GClass39(string_0);
		}

		internal GClass39 method_6(string string_0)
		{
			return new GClass39(string_0);
		}

		internal GClass37 method_7(string string_0)
		{
			return GClass34.smethod_4(string_0) ? ((GClass37)new GClass38(string_0)) : ((GClass37)new GClass39(string_0));
		}

		internal GClass37 method_8(string string_0)
		{
			return GClass34.smethod_4(string_0) ? ((GClass37)new GClass38(string_0)) : ((GClass37)new GClass39(string_0));
		}

		internal GClass37 method_9(string string_0)
		{
			return GClass34.smethod_4(string_0) ? ((GClass37)new GClass38(string_0)) : ((GClass37)new GClass39(string_0));
		}
	}

	private readonly string string_3;

	public override bool GClass37_002E_206C_206A_206B_206C_200D_206C_202E_202C_200F_206A_200E_202D_206D_200F_206A_200B_206C_206B_206F_206C_206A_200D_206A_206E_202E_202D_206B_200D_206D_200F_200E_202C_202D_206B_206F_202E_206D_200C_200B_202C_202E
	{
		get
		{
			bool flag = default(bool);
			bool result = default(bool);
			while (true)
			{
				int num = -153225619;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x935BC7BEu) % 8u)
					{
					case 6u:
						if (genum14_0 == GEnum14.Initialized)
						{
							num = -1374630002;
							continue;
						}
						num3 = 0;
						goto IL_0017;
					case 5u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = -1296466983;
							num5 = -1296466983;
						}
						else
						{
							num4 = -1979618082;
							num5 = -1979618082;
						}
						num = num4 ^ ((int)num2 * -550680019);
						continue;
					}
					case 4u:
						num = (int)((num2 * 587761646) ^ 0x44C86F69);
						continue;
					case 3u:
						flag = genum14_0 == GEnum14.Uninitialized;
						num = ((int)num2 * -65931968) ^ 0x3C5EC623;
						continue;
					case 1u:
						method_0();
						num = ((int)num2 * -411209727) ^ 0x3AE120B9;
						continue;
					case 0u:
						num3 = (((gclass40_0.fileAttributes_0 & FileAttributes.Directory) == FileAttributes.Directory) ? 1 : 0);
						goto IL_0017;
					case 2u:
						break;
					default:
						{
							return result;
						}
						IL_0017:
						result = (byte)num3 != 0;
						num = -216589094;
						continue;
					}
					break;
				}
			}
		}
	}

	public override string GClass37_002E_200F_206C_206C_200C_200E_200B_202D_202D_202E_206C_200C_200D_200F_206D_206D_202C_206F_200B_200B_206A_200F_202B_200B_206B_202A_202A_202A_206E_202C_206E_202C_202D_200D_206D_202E_200E_206F_202B_206B_206C_202E
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = 1855891346;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4D67B913u) % 3u)
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
					result = string_3;
					num = ((int)num2 * -794814174) ^ -1842841832;
				}
			}
		}
	}

	public GClass38 GClass38_0
	{
		get
		{
			string text = string_1;
			if (text.Length > 3)
			{
				goto IL_0029;
			}
			int num = 0;
			goto IL_0108;
			IL_0108:
			bool flag = (byte)num != 0;
			int num2 = 1587882975;
			goto IL_00c2;
			IL_0029:
			num2 = 1585370623;
			goto IL_00c2;
			IL_00c2:
			string text2 = default(string);
			GClass38 result = default(GClass38);
			while (true)
			{
				uint num3;
				object obj;
				switch ((num3 = (uint)num2 ^ 0x22BA872Du) % 10u)
				{
				case 9u:
					num2 = (int)(num3 * 533182404) ^ -1761124848;
					continue;
				case 8u:
					break;
				case 7u:
					if (text2 != null)
					{
						num2 = ((int)num3 * -576839727) ^ -1861808086;
						continue;
					}
					obj = null;
					goto IL_0047;
				case 6u:
					obj = new GClass38(text2);
					goto IL_0047;
				case 5u:
					text2 = GClass41.smethod_14(text);
					num2 = 1667114328;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 718306642;
						num5 = 718306642;
					}
					else
					{
						num4 = 786310042;
						num5 = 786310042;
					}
					num2 = num4 ^ ((int)num3 * -2107618145);
					continue;
				}
				case 3u:
					text = string_1.Substring(0, string_1.Length - 1);
					num2 = ((int)num3 * -26423600) ^ 0x29BCA0E;
					continue;
				case 0u:
					num2 = ((int)num3 * -473592427) ^ -2081751648;
					continue;
				case 2u:
					goto IL_00fd;
				default:
					{
						return result;
					}
					IL_0047:
					result = (GClass38)obj;
					num2 = 649718211;
					continue;
				}
				break;
			}
			goto IL_0029;
			IL_00fd:
			num = (GClass35.smethod_0(text, GClass41.char_2) ? 1 : 0);
			goto IL_0108;
		}
	}

	public GClass38 GClass38_1
	{
		get
		{
			int num3 = default(int);
			GClass38 result = default(GClass38);
			while (true)
			{
				int num = -1019132584;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAB4BB099u) % 5u)
					{
					case 4u:
						num = ((int)num2 * -459136131) ^ -1611143594;
						continue;
					case 3u:
					{
						string string_ = string_1.Substring(0, num3 - (GClass33.smethod_17(string_1) ? 1 : 0));
						result = new GClass38(string_);
						num = -851768392;
						continue;
					}
					case 2u:
						num3 = GClass41.smethod_16(string_1);
						num = (int)((num2 * 896069188) ^ 0x5ADF2875);
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

	public GClass38(string string_4)
	{
		if (string_4 == null)
		{
			throw new ArgumentNullException("path");
		}
		string_0 = string_4;
		string_1 = GClass41.smethod_13(string_4);
		string_3 = ((string_0.Length != 2 || string_0[1] != ':') ? method_4(string_1) : ".");
	}

	public void method_1()
	{
		GClass34.smethod_14(string_1);
	}

	public GClass38 method_2(string string_4)
	{
		string string_5 = GClass41.smethod_6(string_1, string_4);
		string strB = GClass41.smethod_13(string_5);
		GClass38 result = default(GClass38);
		while (true)
		{
			int num = -306670311;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEE6F6840u) % 7u)
				{
				case 6u:
					num = (int)((num2 * 1635435490) ^ 0x46E491EE);
					continue;
				case 4u:
					result = new GClass38(string_5);
					num = ((int)num2 * -1148001398) ^ 0x1E5D4837;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (string.Compare(string_1, 0, strB, 0, string_1.Length, StringComparison.OrdinalIgnoreCase) == 0)
					{
						num3 = -1948610310;
						num4 = -1948610310;
					}
					else
					{
						num3 = -366644242;
						num4 = -366644242;
					}
					num = num3 ^ ((int)num2 * -70495068);
					continue;
				}
				case 0u:
					GClass34.smethod_14(string_5);
					num = -422000396;
					continue;
				case 3u:
					break;
				case 2u:
					throw new ArgumentException("Invalid subpath", string_4);
				default:
					return result;
				}
				break;
			}
		}
	}

	public override void GClass37_002E_200E_206A_206A_206C_206A_206A_206E_206B_200F_200F_202B_200D_206A_206F_200E_200B_206D_200C_206D_206B_200B_202C_202C_206C_206E_206A_206C_206C_202B_206A_202B_206E_200B_202D_202E_206D_206A_202B_200F_200F_202E()
	{
		while (true)
		{
			int num = -113337010;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBA37E2C3u) % 4u)
				{
				case 1u:
					GClass34.smethod_3(string_1);
					num = (int)((num2 * 1148596669) ^ 0xF00B4A2);
					continue;
				case 0u:
					num = ((int)num2 * -1105418597) ^ 0x2391F229;
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

	public void method_3(bool bool_0)
	{
		GClass34.smethod_2(string_1, bool_0);
	}

	private string method_4(string string_4)
	{
		string text = default(string);
		string result = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num = 235729814;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7A9BD5F9u) % 10u)
				{
				case 9u:
					text = text.Substring(0, text.Length - 1);
					num = ((int)num2 * -26784685) ^ 0x66F6D78C;
					continue;
				case 8u:
					result = GClass41.smethod_12(text);
					num = 1800099754;
					continue;
				case 6u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = -2060904651;
						num6 = -2060904651;
					}
					else
					{
						num5 = -618219528;
						num6 = -618219528;
					}
					num = num5 ^ ((int)num2 * -208833073);
					continue;
				}
				case 5u:
					text = string_4;
					num = 540067659;
					continue;
				case 4u:
					result = string_4;
					num = ((int)num2 * -1480687301) ^ 0x107BE9F0;
					continue;
				case 3u:
					num = (int)((num2 * 192974005) ^ 0x26167743);
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (GClass35.smethod_0(text, GClass41.char_2))
					{
						num3 = 1381689740;
						num4 = 1381689740;
					}
					else
					{
						num3 = 880742699;
						num4 = 880742699;
					}
					num = num3 ^ (int)(num2 * 1741094661);
					continue;
				}
				case 1u:
					flag = string_4.Length <= 3;
					num = ((int)num2 * -319023426) ^ -1558338637;
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

	public void method_5(string string_4)
	{
		bool flag = string_4 == null;
		string text = default(string);
		string strA = default(string);
		bool flag3 = default(bool);
		bool flag4 = default(bool);
		string strA2 = default(string);
		bool flag2 = default(bool);
		string strB = default(string);
		while (true)
		{
			int num = 2042307026;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7E8DE305u) % 24u)
				{
				case 23u:
				{
					int num10;
					int num11;
					if (flag)
					{
						num10 = -738966155;
						num11 = -738966155;
					}
					else
					{
						num10 = -1303732287;
						num11 = -1303732287;
					}
					num = num10 ^ (int)(num2 * 1670935020);
					continue;
				}
				case 22u:
				{
					string text3 = text;
					char char_ = GClass41.char_2;
					text = text3 + char_;
					num = ((int)num2 * -706016707) ^ -700156002;
					continue;
				}
				case 21u:
				{
					string text2 = string_1;
					char char_ = GClass41.char_2;
					strA = text2 + char_;
					num = 362272562;
					continue;
				}
				case 18u:
					flag3 = !GClass35.smethod_0(text, GClass41.char_2);
					num = (int)(num2 * 2008530589) ^ -384556375;
					continue;
				case 17u:
				{
					int num12;
					int num13;
					if (!flag4)
					{
						num12 = -91209823;
						num13 = -91209823;
					}
					else
					{
						num12 = -2028191126;
						num13 = -2028191126;
					}
					num = num12 ^ (int)(num2 * 311155306);
					continue;
				}
				case 16u:
					flag4 = string.IsNullOrEmpty(string_4);
					num = 723003820;
					continue;
				case 15u:
				{
					int num5;
					if (string.Compare(strA, text, StringComparison.OrdinalIgnoreCase) != 0)
					{
						num = 2008695182;
						num5 = 2008695182;
					}
					else
					{
						num = 182192130;
						num5 = 182192130;
					}
					continue;
				}
				case 14u:
					text = GClass41.smethod_13(string_4);
					num = 1227802007;
					continue;
				case 12u:
					num = ((int)num2 * -203776843) ^ -866792682;
					continue;
				case 11u:
					strA2 = GClass41.smethod_21(strA);
					num = 1528409436;
					continue;
				case 10u:
					strA = string_1;
					num = ((int)num2 * -53980511) ^ -1134184701;
					continue;
				case 8u:
					num = ((int)num2 * -1941340272) ^ 0x275E997C;
					continue;
				case 6u:
				{
					int num8;
					int num9;
					if (!flag3)
					{
						num8 = -914204632;
						num9 = -914204632;
					}
					else
					{
						num8 = -634578805;
						num9 = -634578805;
					}
					num = num8 ^ (int)(num2 * 2075577400);
					continue;
				}
				case 5u:
					flag2 = GClass35.smethod_0(string_1, GClass41.char_2);
					num = 216262813;
					continue;
				case 3u:
					GClass36.smethod_52(strA, text);
					num = 982757789;
					continue;
				case 2u:
				{
					int num6;
					int num7;
					if (string.Compare(strA2, strB, StringComparison.OrdinalIgnoreCase) != 0)
					{
						num6 = -975277076;
						num7 = -975277076;
					}
					else
					{
						num6 = -932876684;
						num7 = -932876684;
					}
					num = num6 ^ ((int)num2 * -2043411851);
					continue;
				}
				case 1u:
					strB = GClass41.smethod_21(text);
					num = ((int)num2 * -904637337) ^ 0x692F5050;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag2)
					{
						num3 = -1869460657;
						num4 = -1869460657;
					}
					else
					{
						num3 = -808736472;
						num4 = -808736472;
					}
					num = num3 ^ (int)(num2 * 528864673);
					continue;
				}
				default:
					return;
				case 4u:
					break;
				case 7u:
					throw new IOException("source and destination directories must be different");
				case 13u:
					throw new ArgumentException("Empty filename", "destDirName");
				case 19u:
					throw new IOException("Source and destination directories must have same root");
				case 20u:
					throw new ArgumentNullException("destDirName");
				case 9u:
					return;
				}
				break;
			}
		}
	}

	public void method_6(DirectorySecurity directorySecurity_0)
	{
		GClass34.smethod_21(string_1, directorySecurity_0);
	}

	public GClass38 method_7(string string_4, DirectorySecurity directorySecurity_0)
	{
		string string_5 = GClass41.smethod_6(string_1, string_4);
		GClass38 result = default(GClass38);
		while (true)
		{
			int num = -788579562;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE67A8DD2u) % 7u)
				{
				case 5u:
				{
					string strB = GClass41.smethod_13(string_5);
					int num3;
					int num4;
					if (string.Compare(string_1, 0, strB, 0, string_1.Length, StringComparison.OrdinalIgnoreCase) == 0)
					{
						num3 = -128504530;
						num4 = -128504530;
					}
					else
					{
						num3 = -1585508687;
						num4 = -1585508687;
					}
					num = num3 ^ ((int)num2 * -645559661);
					continue;
				}
				case 2u:
					num = ((int)num2 * -621264023) ^ 0x5F6AF42C;
					continue;
				case 1u:
					num = ((int)num2 * -2085596528) ^ -89347223;
					continue;
				case 0u:
					GClass34.smethod_21(string_5, directorySecurity_0);
					result = new GClass38(string_5);
					num = -2095173957;
					continue;
				case 4u:
					break;
				case 3u:
					throw new ArgumentException("Invalid subpath", string_4);
				default:
					return result;
				}
				break;
			}
		}
	}

	public IEnumerable<GClass38> method_8()
	{
		IEnumerable<GClass38> result = default(IEnumerable<GClass38>);
		while (true)
		{
			int num = 1285137617;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x616EE3Eu) % 4u)
				{
				case 3u:
					result = GClass43.smethod_2(GClass34.smethod_5(string_1, "*", bool_0: true, bool_1: false, SearchOption.TopDirectoryOnly), (string string_0) => new GClass38(string_0));
					num = 428575018;
					continue;
				case 0u:
					num = (int)(num2 * 1556640539) ^ -180847693;
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

	public DirectorySecurity method_9()
	{
		DirectorySecurity result = GClass34.smethod_22(string_1);
		while (true)
		{
			int num = 32278027;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB7FB3D8u) % 3u)
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
				num = (int)(num2 * 1147379537) ^ -1534248240;
			}
		}
	}

	public DirectorySecurity method_10(AccessControlSections accessControlSections_0)
	{
		DirectorySecurity result = default(DirectorySecurity);
		while (true)
		{
			int num = -352303197;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA74487BCu) % 3u)
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
				result = GClass34.smethod_24(string_1, accessControlSections_0);
				num = (int)(num2 * 127036345) ^ -2098246410;
			}
		}
	}

	public GClass38[] method_11()
	{
		GClass38[] result = default(GClass38[]);
		while (true)
		{
			int num = -1424658822;
			while (true)
			{
				string[] ienumerable_;
				GDelegate1<string, GClass38> gdelegate1_;
				switch ((uint)(num ^ -299558270) % 3u)
				{
				case 1u:
					ienumerable_ = GClass34.smethod_27(string_1);
					gdelegate1_ = (string string_0) => new GClass38(string_0);
					goto IL_002d;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_002d:
				result = GClass43.smethod_0(GClass43.smethod_2(ienumerable_, gdelegate1_));
				num = -1232770292;
			}
		}
	}

	public GClass38[] method_12(string string_4)
	{
		GClass38[] result = default(GClass38[]);
		while (true)
		{
			int num = 1865994272;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1778ED5Du) % 4u)
				{
				case 1u:
					result = GClass43.smethod_0(GClass43.smethod_2(GClass34.smethod_28(string_1, string_4), (string string_0) => new GClass38(string_0)));
					num = 273553541;
					continue;
				case 0u:
					num = ((int)num2 * -518017884) ^ 0x7183DBD3;
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

	public GClass38[] method_13(string string_4, SearchOption searchOption_0)
	{
		GClass38[] result = default(GClass38[]);
		while (true)
		{
			int num = 998265679;
			while (true)
			{
				string[] ienumerable_;
				GDelegate1<string, GClass38> gdelegate1_;
				switch ((uint)(num ^ 0x77C6B070) % 3u)
				{
				case 1u:
					ienumerable_ = GClass34.smethod_15(string_1, string_4, searchOption_0);
					gdelegate1_ = (string string_0) => new GClass38(string_0);
					goto IL_002f;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_002f:
				result = GClass43.smethod_0(GClass43.smethod_2(ienumerable_, gdelegate1_));
				num = 180853785;
			}
		}
	}

	public GClass39[] method_14(string string_4)
	{
		return GClass43.smethod_0(GClass43.smethod_2(GClass34.smethod_30(string_1, string_4), (string string_0) => new GClass39(string_0)));
	}

	public GClass39[] method_15(string string_4, SearchOption searchOption_0)
	{
		return GClass43.smethod_0(GClass43.smethod_2(GClass34.smethod_31(string_1, string_4, searchOption_0), (string string_0) => new GClass39(string_0)));
	}

	public GClass39[] method_16()
	{
		GClass39[] result = GClass43.smethod_0(GClass43.smethod_2(GClass34.smethod_5(string_1, "*", bool_0: false, bool_1: true, SearchOption.TopDirectoryOnly), (string string_0) => new GClass39(string_0)));
		while (true)
		{
			int num = 884702220;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x75E94FE2u) % 3u)
				{
				case 1u:
					goto IL_003f;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_003f:
				num = (int)(num2 * 1082339463) ^ -210236435;
			}
		}
	}

	public GClass37[] method_17(string string_4)
	{
		GClass37[] result = GClass43.smethod_0(GClass43.smethod_2(GClass34.smethod_5(string_1, string_4, bool_0: true, bool_1: true, SearchOption.TopDirectoryOnly), (string string_0) => GClass34.smethod_4(string_0) ? ((GClass37)new GClass38(string_0)) : ((GClass37)new GClass39(string_0))));
		while (true)
		{
			int num = -922758710;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFC9202E4u) % 3u)
				{
				case 1u:
					goto IL_003b;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_003b:
				num = (int)(num2 * 1400582452) ^ -418037754;
			}
		}
	}

	public GClass37[] method_18(string string_4, SearchOption searchOption_0)
	{
		return GClass43.smethod_0(GClass43.smethod_2(GClass34.smethod_5(string_1, string_4, bool_0: true, bool_1: true, searchOption_0), (string string_0) => GClass34.smethod_4(string_0) ? ((GClass37)new GClass38(string_0)) : ((GClass37)new GClass39(string_0))));
	}

	public GClass37[] method_19()
	{
		GClass37[] result = default(GClass37[]);
		while (true)
		{
			int num = -936208756;
			while (true)
			{
				IEnumerable<string> ienumerable_;
				GDelegate1<string, GClass37> gdelegate1_;
				switch ((uint)(num ^ -938540471) % 3u)
				{
				case 1u:
					ienumerable_ = GClass34.smethod_5(string_1, "*", bool_0: true, bool_1: true, SearchOption.TopDirectoryOnly);
					gdelegate1_ = (string string_0) => GClass34.smethod_4(string_0) ? ((GClass37)new GClass38(string_0)) : ((GClass37)new GClass39(string_0));
					goto IL_0035;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0035:
				result = GClass43.smethod_0(GClass43.smethod_2(ienumerable_, gdelegate1_));
				num = -1269314533;
			}
		}
	}

	public void method_20(DirectorySecurity directorySecurity_0)
	{
		while (true)
		{
			int num = -405427287;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xECA56C62u) % 4u)
				{
				case 3u:
					GClass34.smethod_40(string_1, directorySecurity_0);
					num = (int)((num2 * 236543526) ^ 0x5E9A2ABA);
					continue;
				case 2u:
					num = ((int)num2 * -505713830) ^ 0x71633D83;
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

	string object.ToString()
	{
		string result = base.String_1;
		while (true)
		{
			int num = 1344392515;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4AFB8885u) % 3u)
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
				num = ((int)num2 * -511069357) ^ -92066264;
			}
		}
	}
}
