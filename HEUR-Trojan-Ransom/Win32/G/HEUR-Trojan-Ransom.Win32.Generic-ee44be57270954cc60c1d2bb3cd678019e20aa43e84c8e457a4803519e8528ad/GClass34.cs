using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using Microsoft.Win32.SafeHandles;

public static class GClass34
{
	internal static SafeFileHandle smethod_0(string string_0)
	{
		SafeFileHandle safeFileHandle = default(SafeFileHandle);
		bool flag = default(bool);
		Exception ex = default(Exception);
		SafeFileHandle result = default(SafeFileHandle);
		while (true)
		{
			int num = 1739280011;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC9B8903u) % 9u)
				{
				case 7u:
					safeFileHandle = Class17.CreateFile(string_0, Class17.Enum3.GenericWrite, 6u, IntPtr.Zero, 3u, 33554432u, IntPtr.Zero);
					flag = !safeFileHandle.IsInvalid;
					num = ((int)num2 * -783452121) ^ 0x4B15E568;
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 2072363798;
						num4 = 2072363798;
					}
					else
					{
						num3 = 607329839;
						num4 = 607329839;
					}
					num = num3 ^ ((int)num2 * -1265651897);
					continue;
				}
				case 5u:
					ex = GClass33.smethod_8();
					num = 466933151;
					continue;
				case 2u:
					Console.WriteLine("error {0} with {1}\n{2}", ex.Message, string_0, ex.StackTrace);
					num = ((int)num2 * -1921167536) ^ -149004176;
					continue;
				case 1u:
					num = ((int)num2 * -388545395) ^ 0x2363B5D8;
					continue;
				case 0u:
					result = safeFileHandle;
					num = (int)(num2 * 977595971) ^ -1936440058;
					continue;
				case 3u:
					break;
				case 4u:
					throw ex;
				default:
					return result;
				}
				break;
			}
		}
	}

	public static string smethod_1()
	{
		string result = default(string);
		while (true)
		{
			int num = 914591356;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x22698D64u) % 3u)
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
				result = GClass41.smethod_4(GClass41.smethod_0("."));
				num = ((int)num2 * -20242729) ^ 0x67583A5C;
			}
		}
	}

	public static void smethod_2(string string_0, bool bool_0)
	{
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected I4, but got Unknown
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected I4, but got Unknown
		//IL_023d: Incompatible stack heights: 0 vs 1
		//IL_0244: Incompatible stack heights: 0 vs 1
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected I4, but got Unknown
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected I4, but got Unknown
		//IL_02b5: Incompatible stack heights: 0 vs 1
		//IL_02bc: Incompatible stack heights: 0 vs 1
		try
		{
			IEnumerator<string> enumerator = smethod_5(string_0, "*", bool_0: false, bool_1: true, SearchOption.TopDirectoryOnly).GetEnumerator();
			try
			{
				while (true)
				{
					IL_0094:
					int num;
					int num2;
					if (!enumerator.MoveNext())
					{
						num = 1009625867;
						num2 = 1009625867;
					}
					else
					{
						num = 205956154;
						num2 = 205956154;
					}
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)num ^ 0x2EAA1E2Fu) % 6u)
						{
						case 3u:
						{
							string current = enumerator.Current;
							GClass36.smethod_10(current);
							num = 2031420553;
							continue;
						}
						case 2u:
							num = ((int)num3 * -216478812) ^ -1754156656;
							continue;
						case 1u:
							num = ((int)num3 * -590510794) ^ -278937230;
							continue;
						case 0u:
							num = 205956154;
							continue;
						default:
							goto end_IL_005e;
						case 5u:
							break;
						case 4u:
							goto end_IL_005e;
						}
						goto IL_0094;
						continue;
						end_IL_005e:
						break;
					}
					break;
				}
			}
			finally
			{
				if (enumerator != null)
				{
					while (true)
					{
						IL_00ee:
						int num4 = 1633892126;
						while (true)
						{
							uint num3;
							switch ((num3 = (uint)num4 ^ 0x2EAA1E2Fu) % 4u)
							{
							case 1u:
								enumerator.Dispose();
								num4 = (int)((num3 * 1414871745) ^ 0x1E165986);
								continue;
							case 0u:
								num4 = ((int)num3 * -1402434897) ^ 0x65B8F820;
								continue;
							default:
								goto end_IL_00cc;
							case 2u:
								break;
							case 3u:
								goto end_IL_00cc;
							}
							goto IL_00ee;
							continue;
							end_IL_00cc:
							break;
						}
						break;
					}
				}
			}
		}
		catch (FileNotFoundException)
		{
		}
		try
		{
			IEnumerator<string> enumerator2 = smethod_5(string_0, "*", bool_0: true, bool_1: false, SearchOption.TopDirectoryOnly).GetEnumerator();
			try
			{
				string current2 = default(string);
				while (true)
				{
					IL_01be:
					int num5;
					int num6;
					if (enumerator2.MoveNext())
					{
						num5 = 1680204277;
						num6 = 1680204277;
					}
					else
					{
						num5 = 1804953112;
						num6 = 1804953112;
					}
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)num5 ^ 0x2EAA1E2Fu) % 8u)
						{
						case 6u:
							num5 = ((int)num3 * -1146128611) ^ 0x3CBE37B1;
							continue;
						case 4u:
							num5 = (int)(num3 * 1327687435) ^ -1415166666;
							continue;
						case 3u:
							num5 = 1680204277;
							continue;
						case 2u:
							current2 = enumerator2.Current;
							num5 = 503219865;
							continue;
						case 1u:
							num5 = (int)(num3 * 989156287) ^ -948268068;
							continue;
						case 0u:
							smethod_2(current2, bool_0: true);
							num5 = (int)(num3 * 405469188) ^ -1356590290;
							continue;
						default:
							goto end_IL_017d;
						case 5u:
							break;
						case 7u:
							goto end_IL_017d;
						}
						goto IL_01be;
						continue;
						end_IL_017d:
						break;
					}
					break;
				}
			}
			finally
			{
				if (enumerator2 != null)
				{
					while (true)
					{
						IL_0204:
						int num7 = 621636195;
						while (true)
						{
							uint num3;
							switch ((num3 = (uint)num7 ^ 0x2EAA1E2Fu) % 3u)
							{
							case 1u:
								goto IL_01d2;
							default:
								goto end_IL_01e6;
							case 2u:
								break;
							case 0u:
								goto end_IL_01e6;
							}
							goto IL_0204;
							IL_01d2:
							enumerator2.Dispose();
							num7 = (int)((num3 * 1126963592) ^ 0x7BE4B2BD);
							continue;
							end_IL_01e6:
							break;
						}
						break;
					}
				}
			}
		}
		catch (FileNotFoundException)
		{
			while (true)
			{
				IL_023f:
				_ = 1048966083;
				while (true)
				{
					_003F val = /*Error near IL_0217: Stack underflow*/^ 0x2EAA1E2F;
					uint num3 = (uint)(int)val;
					switch (val % 3)
					{
					default:
						goto end_IL_0211;
					case 2:
						_ = ((int)num3 * -736620179) ^ -1019737013;
						continue;
					case 0:
						break;
					case 1:
						goto end_IL_0211;
					}
					goto IL_023f;
					continue;
					end_IL_0211:
					break;
				}
				break;
			}
		}
		try
		{
			smethod_3(string_0);
			while (true)
			{
				int num8 = 951443907;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num8 ^ 0x2EAA1E2Fu) % 3u)
					{
					case 1u:
						goto IL_0251;
					default:
						return;
					case 0u:
						break;
					case 2u:
						return;
					}
					break;
					IL_0251:
					num8 = (int)((num3 * 686845645) ^ 0x41FE9E0D);
				}
			}
		}
		catch (FileNotFoundException)
		{
			while (true)
			{
				_ = 731650443;
				while (true)
				{
					_003F val2 = /*Error near IL_028f: Stack underflow*/^ 0x2EAA1E2F;
					uint num3 = (uint)(int)val2;
					switch (val2 % 3)
					{
					default:
						return;
					case 2:
						_ = (num3 * 117349432) ^ 0x787CC7B7;
						continue;
					case 0:
						break;
					case 1:
						return;
					}
					break;
				}
			}
		}
	}

	public static void smethod_3(string string_0)
	{
		string string_ = GClass41.smethod_0(string_0);
		bool flag = default(bool);
		while (true)
		{
			int num = 331635502;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x762F69B9u) % 6u)
				{
				case 5u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1723243178;
						num4 = 1723243178;
					}
					else
					{
						num3 = 1958727097;
						num4 = 1958727097;
					}
					num = num3 ^ (int)(num2 * 412053161);
					continue;
				}
				case 3u:
					flag = !Class17.RemoveDirectory(string_);
					num = (int)((num2 * 208575538) ^ 0x52A0E304);
					continue;
				case 1u:
					num = (int)(num2 * 1435044328) ^ -1772083485;
					continue;
				default:
					return;
				case 4u:
					break;
				case 2u:
					throw GClass33.smethod_8();
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public static bool smethod_4(string string_0)
	{
		bool bool_;
		bool result = GClass33.smethod_5(string_0, out bool_) && bool_;
		while (true)
		{
			int num = -1622634397;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8B72A699u) % 3u)
				{
				case 1u:
					goto IL_000d;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_000d:
				num = (int)(num2 * 876693834) ^ -1653467597;
			}
		}
	}

	internal static IEnumerable<string> smethod_5(string string_0, string string_1, bool bool_0, bool bool_1, SearchOption searchOption_0)
	{
		string string_3 = default(string);
		IEnumerable<string> result = default(IEnumerable<string>);
		string string_2 = default(string);
		while (true)
		{
			int num = 1394127739;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x51E3C588u) % 6u)
				{
				case 5u:
					string_3 = GClass33.smethod_4(string_1);
					num = (int)((num2 * 1015298973) ^ 0x646C9196);
					continue;
				case 4u:
					result = smethod_6(bool_0, bool_1, searchOption_0, string_2, string_3);
					num = (int)(num2 * 882535392) ^ -854061227;
					continue;
				case 3u:
					num = ((int)num2 * -1535864447) ^ -951052705;
					continue;
				case 1u:
					string_2 = GClass41.smethod_0(string_0);
					num = (int)((num2 * 1437775821) ^ 0xD6F5BAD);
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

	private static IEnumerable<string> smethod_6(bool bool_0, bool bool_1, SearchOption searchOption_0, string string_0, string string_1)
	{
		bool flag = default(bool);
		int num3 = default(int);
		IEnumerable<string> result = default(IEnumerable<string>);
		while (true)
		{
			int num = -1726084021;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD99D855Cu) % 11u)
				{
				case 10u:
					num = (int)(num2 * 957608344) ^ -1931848530;
					continue;
				case 9u:
					flag = searchOption_0 == SearchOption.AllDirectories;
					num = -70589881;
					continue;
				case 8u:
				{
					num3 = GClass33.smethod_6(string_0, out var _);
					int num6;
					int num7;
					if (num3 != 0)
					{
						num6 = -198332933;
						num7 = -198332933;
					}
					else
					{
						num6 = -1910434697;
						num7 = -1910434697;
					}
					num = num6 ^ (int)(num2 * 2028943173);
					continue;
				}
				case 7u:
					result = smethod_7(string_0, string_1, bool_0, bool_1);
					num = -1663953284;
					continue;
				case 6u:
					num = ((int)num2 * -2025866780) ^ -2052888183;
					continue;
				case 4u:
					result = smethod_8(string_0, string_1, bool_0, bool_1);
					num = (int)((num2 * 1664628351) ^ 0x4F406116);
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -1260781991;
						num5 = -1260781991;
					}
					else
					{
						num4 = -479729032;
						num5 = -479729032;
					}
					num = num4 ^ ((int)num2 * -973123387);
					continue;
				}
				case 0u:
					num = ((int)num2 * -1785885049) ^ -2046019610;
					continue;
				case 5u:
					break;
				case 1u:
					throw GClass33.smethod_10(num3);
				default:
					return result;
				}
				break;
			}
		}
	}

	private static IEnumerable<string> smethod_7(string string_0, string string_1, bool bool_0, bool bool_1)
	{
		//yield-return decompiler failed: Unexpected instruction in Iterator.Dispose()
		return new Class13(-2)
		{
			string_2 = string_0,
			string_4 = string_1,
			bool_1 = bool_0,
			bool_3 = bool_1
		};
	}

	private static IEnumerable<string> smethod_8(string string_0, string string_1, bool bool_0, bool bool_1)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new Class14(-2)
		{
			string_2 = string_0,
			string_4 = string_1,
			bool_1 = bool_0,
			bool_3 = bool_1
		};
	}

	internal static Class19 smethod_9(string string_0, out Class17.Struct6 struct6_0)
	{
		int lastWin32Error = default(int);
		bool flag = default(bool);
		Class19 result = default(Class19);
		Class19 @class = default(Class19);
		while (true)
		{
			int num = -464659029;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xFB64070Du) % 15u)
				{
				case 14u:
					if (lastWin32Error != 2)
					{
						num = (int)((num2 * 1042221622) ^ 0x218042EE);
						continue;
					}
					goto IL_0020;
				case 13u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1330630304;
						num5 = 1330630304;
					}
					else
					{
						num4 = 1880123038;
						num5 = 1880123038;
					}
					num = num4 ^ ((int)num2 * -1570611910);
					continue;
				}
				case 11u:
					result = null;
					num = -1911126992;
					continue;
				case 10u:
					result = @class;
					num = ((int)num2 * -805716378) ^ -53667645;
					continue;
				case 9u:
					flag = !@class.IsInvalid;
					num = ((int)num2 * -885814507) ^ 0x186B771B;
					continue;
				case 8u:
					lastWin32Error = Marshal.GetLastWin32Error();
					num = -1918515834;
					continue;
				case 7u:
					if (lastWin32Error != 21)
					{
						num = -360790507;
						num3 = -360790507;
						continue;
					}
					goto IL_0020;
				case 6u:
					string_0 = string_0.TrimEnd(new char[1] { '\\' });
					num = ((int)num2 * -2141191846) ^ -83641841;
					continue;
				case 4u:
					if (lastWin32Error != 3)
					{
						num = ((int)num2 * -715720624) ^ -1246028307;
						continue;
					}
					goto IL_0020;
				case 3u:
					num = (int)((num2 * 1139111031) ^ 0x23F0F03F);
					continue;
				case 2u:
					num = (int)((num2 * 827758530) ^ 0x10F0A84);
					continue;
				case 1u:
					@class = Class17.FindFirstFile(string_0, out struct6_0);
					num = ((int)num2 * -1784313761) ^ -865648910;
					continue;
				case 0u:
					break;
				case 5u:
					throw GClass33.smethod_10(lastWin32Error);
				default:
					{
						return result;
					}
					IL_0020:
					num = -1212967880;
					num3 = -1212967880;
					continue;
				}
				break;
			}
		}
	}

	internal static bool smethod_10(FileAttributes fileAttributes_0)
	{
		bool result = default(bool);
		while (true)
		{
			int num = 1538640416;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2B456C6Du) % 4u)
				{
				case 2u:
					num = ((int)num2 * -974565106) ^ 0x29B1C955;
					continue;
				case 1u:
					result = (fileAttributes_0 & FileAttributes.Directory) == FileAttributes.Directory;
					num = (int)((num2 * 28471296) ^ 0x445B307);
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

	private static bool smethod_11(string string_0)
	{
		if (!string_0.Equals(".", StringComparison.OrdinalIgnoreCase))
		{
			goto IL_0011;
		}
		int num = 1;
		goto IL_0052;
		IL_0052:
		bool result = (byte)num != 0;
		int num2 = -849971476;
		goto IL_0025;
		IL_0011:
		num2 = -1887953509;
		goto IL_0025;
		IL_0025:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0xDD1ABB91u) % 4u)
			{
			case 3u:
				break;
			case 1u:
				num2 = ((int)num3 * -2066548635) ^ 0x3AB6E45C;
				continue;
			case 2u:
				goto IL_0046;
			default:
				return result;
			}
			break;
		}
		goto IL_0011;
		IL_0046:
		num = (string_0.Equals("..", StringComparison.OrdinalIgnoreCase) ? 1 : 0);
		goto IL_0052;
	}

	public static void smethod_12(string string_0, string string_1)
	{
		string string_2 = GClass41.smethod_1(string_0, "sourcePath");
		int lastWin32Error = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 401246901;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1FAC9324u) % 9u)
				{
				case 7u:
					lastWin32Error = Marshal.GetLastWin32Error();
					num = 485755612;
					continue;
				case 6u:
					num = ((int)num2 * -1951588044) ^ -1500190287;
					continue;
				case 5u:
				{
					string string_3 = GClass41.smethod_1(string_1, "destinationPath");
					flag = Class17.MoveFile(string_2, string_3);
					num = ((int)num2 * -94077102) ^ 0x74C185B2;
					continue;
				}
				case 3u:
				{
					int num5;
					int num6;
					if (lastWin32Error == 5)
					{
						num5 = -1778004617;
						num6 = -1778004617;
					}
					else
					{
						num5 = -2096609392;
						num6 = -2096609392;
					}
					num = num5 ^ ((int)num2 * -379613637);
					continue;
				}
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 2018919539;
						num4 = 2018919539;
					}
					else
					{
						num3 = 7183867;
						num4 = 7183867;
					}
					num = num3 ^ (int)(num2 * 1189168855);
					continue;
				}
				default:
					return;
				case 4u:
					break;
				case 0u:
					throw GClass33.smethod_11(lastWin32Error, "path");
				case 2u:
					throw new IOException($"Access to the path '{string_0}'is denied.", Class17.smethod_0(lastWin32Error));
				case 8u:
					return;
				}
				break;
			}
		}
	}

	private static GClass38 smethod_13(string string_0)
	{
		int num4 = default(int);
		int num15 = default(int);
		bool flag3 = default(bool);
		int num3 = default(int);
		bool flag6 = default(bool);
		int num13 = default(int);
		bool flag2 = default(bool);
		List<string> list = default(List<string>);
		bool flag4 = default(bool);
		string text = default(string);
		bool flag7 = default(bool);
		bool flag5 = default(bool);
		bool flag = default(bool);
		GClass38 result = default(GClass38);
		string string_ = default(string);
		while (true)
		{
			int num = 505945275;
			while (true)
			{
				uint num2;
				int num20;
				int num14;
				switch ((num2 = (uint)num ^ 0x40DA74FEu) % 40u)
				{
				case 39u:
					num = ((int)num2 * -446617602) ^ -2111003601;
					continue;
				case 38u:
					if (string_0[num4] != Path.DirectorySeparatorChar)
					{
						num = (int)((num2 * 2059307663) ^ 0x1DA4AECF);
						continue;
					}
					goto IL_003b;
				case 25u:
				case 37u:
					if (num4 > num15)
					{
						num = 2097858056;
						continue;
					}
					goto IL_003b;
				case 36u:
				{
					int num11;
					int num12;
					if (flag3)
					{
						num11 = 1276052738;
						num12 = 1276052738;
					}
					else
					{
						num11 = 440513726;
						num12 = 440513726;
					}
					num = num11 ^ (int)(num2 * 1845028882);
					continue;
				}
				case 35u:
					num3 = num4 - 1;
					num = 148373951;
					continue;
				case 34u:
					num = (int)((num2 * 279556985) ^ 0x7A7CDA0F);
					continue;
				case 33u:
				{
					int num18;
					int num19;
					if (flag6)
					{
						num18 = 947980660;
						num19 = 947980660;
					}
					else
					{
						num18 = 1946456145;
						num19 = 1946456145;
					}
					num = num18 ^ ((int)num2 * -1855447035);
					continue;
				}
				case 32u:
					num = ((int)num2 * -535816688) ^ 0x6E571C40;
					continue;
				case 31u:
					num = ((int)num2 * -1102848984) ^ 0x39B5C13D;
					continue;
				case 29u:
					num13 = string_0.Length;
					num = ((int)num2 * -1830803844) ^ -628012612;
					continue;
				case 28u:
				{
					int num7;
					int num8;
					if (flag2)
					{
						num7 = 297853419;
						num8 = 297853419;
					}
					else
					{
						num7 = 418123275;
						num8 = 418123275;
					}
					num = num7 ^ (int)(num2 * 1719515734);
					continue;
				}
				case 19u:
				case 27u:
					flag3 = list.Count > 0;
					num = 54350682;
					continue;
				case 26u:
					flag4 = !smethod_4(text);
					num = ((int)num2 * -116372944) ^ -1388160500;
					continue;
				case 24u:
				{
					int num21;
					int num22;
					if (!flag7)
					{
						num21 = 2141535626;
						num22 = 2141535626;
					}
					else
					{
						num21 = 47497277;
						num22 = 47497277;
					}
					num = num21 ^ (int)(num2 * 547194423);
					continue;
				}
				case 23u:
					flag6 = num4 >= num15;
					num = 429097775;
					continue;
				case 22u:
					if (num13 >= 2)
					{
						num = ((int)num2 * -1793456178) ^ 0x748FAE;
						continue;
					}
					num20 = 0;
					goto IL_01bd;
				case 21u:
					num15 = GClass41.smethod_16(string_0);
					list = new List<string>();
					num = 1344642255;
					continue;
				case 20u:
					num20 = (GClass41.smethod_17(string_0[num13 - 1]) ? 1 : 0);
					goto IL_01bd;
				case 18u:
				{
					int num16;
					int num17;
					if (flag5)
					{
						num16 = 386443864;
						num17 = 386443864;
					}
					else
					{
						num16 = 757141091;
						num17 = 757141091;
					}
					num = num16 ^ ((int)num2 * -351700533);
					continue;
				}
				case 17u:
					flag5 = num13 > num15;
					num = ((int)num2 * -462462734) ^ 0x28404E7E;
					continue;
				case 16u:
					num4 = num13 - 1;
					num = (int)((num2 * 321975623) ^ 0x1C151A91);
					continue;
				case 15u:
					text = string_0.Substring(0, num4 + 1);
					num = 573250948;
					continue;
				case 14u:
					list.Add(text);
					num = ((int)num2 * -548222829) ^ 0x78BAE6CC;
					continue;
				case 13u:
					num3 = num13 - 1;
					num13 = num3;
					num = (int)(num2 * 1319526382) ^ -535956939;
					continue;
				case 12u:
					num3 = num4 - 1;
					num = ((int)num2 * -179706967) ^ 0x5B3A8E0F;
					continue;
				case 11u:
					num14 = ((string_0[num4] != Path.AltDirectorySeparatorChar) ? 1 : 0);
					goto IL_003c;
				case 10u:
				{
					int num9;
					int num10;
					if (flag4)
					{
						num9 = 1829219048;
						num10 = 1829219048;
					}
					else
					{
						num9 = 499961707;
						num10 = 499961707;
					}
					num = num9 ^ ((int)num2 * -1216858404);
					continue;
				}
				case 9u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = -2032263572;
						num6 = -2032263572;
					}
					else
					{
						num5 = -1795582155;
						num6 = -1795582155;
					}
					num = num5 ^ ((int)num2 * -1516264371);
					continue;
				}
				case 8u:
					result = new GClass38(string_0);
					num = ((int)num2 * -34373208) ^ -497167735;
					continue;
				case 7u:
					string_ = GClass41.smethod_0(list[list.Count - 1]);
					list.RemoveAt(list.Count - 1);
					num = ((int)num2 * -1858327433) ^ -483535489;
					continue;
				case 6u:
					flag = Class17.CreateDirectory(string_, IntPtr.Zero);
					num = (int)(num2 * 1012775273) ^ -364007095;
					continue;
				case 5u:
					num4 = num3;
					num = (int)(num2 * 1598080225) ^ -2002019276;
					continue;
				case 4u:
					num = 729711801;
					continue;
				case 1u:
					num4 = num3;
					num = (int)(num2 * 305918431) ^ -387228640;
					continue;
				case 0u:
					num = (int)(num2 * 1320737112) ^ -852917165;
					continue;
				case 2u:
					break;
				case 30u:
				{
					int lastWin32Error = Marshal.GetLastWin32Error();
					throw GClass33.smethod_10(lastWin32Error);
				}
				default:
					{
						return result;
					}
					IL_003b:
					num14 = 0;
					goto IL_003c;
					IL_003c:
					flag7 = (byte)num14 != 0;
					num = 1281800830;
					continue;
					IL_01bd:
					flag2 = (byte)num20 != 0;
					num = 1909491986;
					continue;
				}
				break;
			}
		}
	}

	public static GClass38 smethod_14(string string_0)
	{
		int num8 = default(int);
		int num12 = default(int);
		bool flag = default(bool);
		string text = default(string);
		string text2 = default(string);
		int num11 = default(int);
		bool flag2 = default(bool);
		string string_2 = default(string);
		List<string> list = default(List<string>);
		GClass38 result = default(GClass38);
		int num10 = default(int);
		int lastWin32Error = default(int);
		bool flag3 = default(bool);
		while (true)
		{
			int num = -1939901959;
			while (true)
			{
				uint num2;
				int num5;
				int num9;
				switch ((num2 = (uint)num ^ 0xC952F3EAu) % 40u)
				{
				case 38u:
					num = (int)((num2 * 1052381226) ^ 0x79FE4C4);
					continue;
				case 37u:
				{
					int num16;
					int num17;
					if (num8 > num12)
					{
						num16 = -2069345900;
						num17 = -2069345900;
					}
					else
					{
						num16 = -24284095;
						num17 = -24284095;
					}
					num = num16 ^ ((int)num2 * -1124275326);
					continue;
				}
				case 36u:
					flag = !smethod_4(text);
					num = (int)(num2 * 1410279894) ^ -324929870;
					continue;
				case 35u:
					if (text2[num11] != Path.DirectorySeparatorChar)
					{
						num = (int)((num2 * 2000704696) ^ 0x62EF0ECA);
						continue;
					}
					goto IL_0096;
				case 34u:
					flag2 = num11 >= num12;
					num = -1351955120;
					continue;
				case 33u:
					num = ((int)num2 * -1642004960) ^ -274249624;
					continue;
				case 32u:
					if (text2[num11] != Path.AltDirectorySeparatorChar)
					{
						num = -1693958118;
						num5 = -1693958118;
						continue;
					}
					goto IL_0096;
				case 31u:
					string_2 = list[list.Count - 1];
					list.RemoveAt(list.Count - 1);
					num = ((int)num2 * -2139397776) ^ -1342904153;
					continue;
				case 30u:
					result = new GClass38(text2);
					num = ((int)num2 * -180892762) ^ 0xF9E7E29;
					continue;
				case 29u:
					num10 = num11 - 1;
					num = ((int)num2 * -1709021181) ^ 0x5370BC5B;
					continue;
				case 28u:
					num = (int)((num2 * 1319035467) ^ 0x56B324E3);
					continue;
				case 27u:
					num = (int)(num2 * 627637697) ^ -1238649251;
					continue;
				case 26u:
				{
					int num6;
					int num7;
					if (flag2)
					{
						num6 = 2007739424;
						num7 = 2007739424;
					}
					else
					{
						num6 = 619298160;
						num7 = 619298160;
					}
					num = num6 ^ (int)(num2 * 1176753930);
					continue;
				}
				case 25u:
					list = new List<string>();
					num = (int)(num2 * 1651129336) ^ -977546209;
					continue;
				case 24u:
					lastWin32Error = Marshal.GetLastWin32Error();
					num = -556647987;
					continue;
				case 23u:
					num11 = num10;
					num = ((int)num2 * -1489330468) ^ 0x796577FF;
					continue;
				case 22u:
					num11 = num10;
					num = ((int)num2 * -1458261020) ^ -1290010256;
					continue;
				case 21u:
				{
					int num18;
					int num19;
					if (Class17.CreateDirectory(string_2, IntPtr.Zero))
					{
						num18 = 1438136281;
						num19 = 1438136281;
					}
					else
					{
						num18 = 2035748962;
						num19 = 2035748962;
					}
					num = num18 ^ ((int)num2 * -895125616);
					continue;
				}
				case 9u:
				case 20u:
				{
					int num15;
					if (list.Count > 0)
					{
						num = -814814110;
						num15 = -814814110;
					}
					else
					{
						num = -1845329260;
						num15 = -1845329260;
					}
					continue;
				}
				case 19u:
					result = smethod_13(string_0);
					num = (int)((num2 * 1212632470) ^ 0x162053CF);
					continue;
				case 18u:
					num12 = GClass41.smethod_16(text2);
					num = -1246005181;
					continue;
				case 17u:
				{
					string string_ = GClass41.smethod_0(string_0);
					text2 = GClass41.smethod_4(string_);
					num8 = text2.Length;
					if (num8 >= 2)
					{
						num = -865379312;
						continue;
					}
					goto IL_02a1;
				}
				case 16u:
					num10 = num11 - 1;
					num = -758579395;
					continue;
				case 15u:
				{
					int num13;
					int num14;
					if (!flag3)
					{
						num13 = -587976877;
						num14 = -587976877;
					}
					else
					{
						num13 = -246330599;
						num14 = -246330599;
					}
					num = num13 ^ (int)(num2 * 1351785944);
					continue;
				}
				case 14u:
					num = (int)(num2 * 556088175) ^ -2051387623;
					continue;
				case 13u:
					list.Add(GClass41.smethod_0(text));
					num = ((int)num2 * -2139682533) ^ -375330581;
					continue;
				case 12u:
					num11 = num8 - 1;
					num = ((int)num2 * -1162624434) ^ 0x33B0FFEB;
					continue;
				case 11u:
					flag3 = GClass33.smethod_17(string_0);
					num = ((int)num2 * -584719838) ^ -429566077;
					continue;
				case 1u:
				case 10u:
					if (num11 > num12)
					{
						num = -2095988503;
						continue;
					}
					goto IL_0096;
				case 8u:
					num = -1951886547;
					continue;
				case 6u:
					text = text2.Substring(0, num11 + 1);
					num = -552324490;
					continue;
				case 5u:
					num8 = num10;
					num = ((int)num2 * -530399103) ^ -1161310027;
					continue;
				case 4u:
					num10 = num8 - 1;
					num = (int)((num2 * 775298992) ^ 0x544131D7);
					continue;
				case 2u:
					if (GClass41.smethod_17(text2[num8 - 1]))
					{
						num = -817667098;
						num9 = -817667098;
						continue;
					}
					goto IL_02a1;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 2014352535;
						num4 = 2014352535;
					}
					else
					{
						num3 = 365407976;
						num4 = 365407976;
					}
					num = num3 ^ (int)(num2 * 216676066);
					continue;
				}
				case 3u:
					break;
				case 7u:
					throw GClass33.smethod_10(lastWin32Error);
				default:
					{
						return result;
					}
					IL_0096:
					num = -1695659250;
					num5 = -1695659250;
					continue;
					IL_02a1:
					num = -831427512;
					num9 = -831427512;
					continue;
				}
				break;
			}
		}
	}

	public static string[] smethod_15(string string_0, string string_1, SearchOption searchOption_0)
	{
		string[] result = default(string[]);
		while (true)
		{
			int num = -1841053407;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x88B67A50u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -1282572607) ^ -2057685679;
					continue;
				case 1u:
					result = GClass43.smethod_0(smethod_5(string_0, string_1, bool_0: true, bool_1: false, searchOption_0));
					num = ((int)num2 * -1565306319) ^ -134371962;
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

	public static string[] smethod_16(string string_0)
	{
		string[] result = default(string[]);
		while (true)
		{
			int num = 1457823585;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x34C06036u) % 4u)
				{
				case 3u:
					result = GClass43.smethod_0(smethod_5(string_0, "*", bool_0: false, bool_1: true, SearchOption.TopDirectoryOnly));
					num = ((int)num2 * -213434514) ^ -1981853935;
					continue;
				case 1u:
					num = ((int)num2 * -756817617) ^ -1354374825;
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

	public unsafe static void smethod_17(string string_0, DateTime dateTime_0)
	{
		string string_ = GClass41.smethod_0(GClass41.smethod_13(string_0));
		SafeFileHandle safeFileHandle = smethod_0(string_);
		try
		{
			Class17.Struct7 @struct = new Class17.Struct7(dateTime_0.ToFileTimeUtc());
			bool flag = default(bool);
			int lastWin32Error = default(int);
			while (true)
			{
				int num = 843502269;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x489A1EE6u) % 7u)
					{
					case 6u:
						flag = Class17.SetFileTime(safeFileHandle, &@struct, null, null);
						num = (int)(num2 * 943100268) ^ -1500077432;
						continue;
					case 4u:
						GClass33.smethod_13(lastWin32Error, string_0);
						num = ((int)num2 * -2030433978) ^ -566957734;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -1080342978;
							num4 = -1080342978;
						}
						else
						{
							num3 = -1326584846;
							num4 = -1326584846;
						}
						num = num3 ^ (int)(num2 * 1271715582);
						continue;
					}
					case 2u:
						lastWin32Error = Marshal.GetLastWin32Error();
						num = 482684594;
						continue;
					default:
						return;
					case 5u:
						break;
					case 0u:
						return;
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
					IL_0111:
					int num5 = 163208432;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num5 ^ 0x489A1EE6u) % 4u)
						{
						case 3u:
							num5 = ((int)num2 * -277659304) ^ 0x372D8827;
							continue;
						case 2u:
							((IDisposable)safeFileHandle).Dispose();
							num5 = (int)(num2 * 1747224825) ^ -1250148393;
							continue;
						default:
							goto end_IL_00ef;
						case 0u:
							break;
						case 1u:
							goto end_IL_00ef;
						}
						goto IL_0111;
						continue;
						end_IL_00ef:
						break;
					}
					break;
				}
			}
		}
	}

	public unsafe static void smethod_18(string string_0, DateTime dateTime_0)
	{
		string string_ = GClass41.smethod_0(GClass41.smethod_13(string_0));
		SafeFileHandle safeFileHandle = smethod_0(string_);
		try
		{
			Class17.Struct7 @struct = new Class17.Struct7(dateTime_0.ToFileTimeUtc());
			bool flag2 = default(bool);
			bool flag = default(bool);
			int lastWin32Error = default(int);
			while (true)
			{
				int num = 673088818;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x357E2DCu) % 9u)
					{
					case 8u:
						num = ((int)num2 * -1179691439) ^ 0x1502FD1B;
						continue;
					case 7u:
						flag2 = Class17.SetFileTime(safeFileHandle, null, null, &@struct);
						num = ((int)num2 * -2043801326) ^ 0x567F6536;
						continue;
					case 4u:
						flag = flag2;
						num = ((int)num2 * -2071887081) ^ 0x4286DA38;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -1519978826;
							num4 = -1519978826;
						}
						else
						{
							num3 = -484922527;
							num4 = -484922527;
						}
						num = num3 ^ (int)(num2 * 592590736);
						continue;
					}
					case 1u:
						GClass33.smethod_13(lastWin32Error, string_0);
						num = ((int)num2 * -1913838106) ^ -1734540756;
						continue;
					case 0u:
						lastWin32Error = Marshal.GetLastWin32Error();
						num = 743631353;
						continue;
					default:
						return;
					case 2u:
						break;
					case 5u:
						return;
					case 6u:
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
					IL_013e:
					int num5 = 230600289;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num5 ^ 0x357E2DCu) % 4u)
						{
						case 2u:
							num5 = (int)((num2 * 1570189634) ^ 0x34E605B7);
							continue;
						case 1u:
							((IDisposable)safeFileHandle).Dispose();
							num5 = ((int)num2 * -522922259) ^ -270562501;
							continue;
						default:
							goto end_IL_011c;
						case 0u:
							break;
						case 3u:
							goto end_IL_011c;
						}
						goto IL_013e;
						continue;
						end_IL_011c:
						break;
					}
					break;
				}
			}
		}
	}

	public unsafe static void smethod_19(string string_0, DateTime dateTime_0)
	{
		string string_ = default(string);
		Class17.Struct7 @struct = default(Class17.Struct7);
		bool flag2 = default(bool);
		bool flag = default(bool);
		int lastWin32Error = default(int);
		while (true)
		{
			int num = 748454251;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBC41FB2u) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 0u:
					break;
				default:
				{
					SafeFileHandle safeFileHandle = smethod_0(string_);
					try
					{
						while (true)
						{
							int num3 = 653033395;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xBC41FB2u) % 9u)
								{
								case 8u:
									@struct = new Class17.Struct7(dateTime_0.ToFileTimeUtc());
									num3 = (int)(num2 * 858262533) ^ -1124660828;
									continue;
								case 7u:
									flag2 = flag;
									num3 = (int)((num2 * 289294895) ^ 0x2B05EA15);
									continue;
								case 6u:
								{
									int num4;
									int num5;
									if (!flag2)
									{
										num4 = -850164103;
										num5 = -850164103;
									}
									else
									{
										num4 = -1487186187;
										num5 = -1487186187;
									}
									num3 = num4 ^ (int)(num2 * 1211868818);
									continue;
								}
								case 5u:
									lastWin32Error = Marshal.GetLastWin32Error();
									num3 = 992053626;
									continue;
								case 3u:
									GClass33.smethod_13(lastWin32Error, string_0);
									num3 = (int)(num2 * 964138724) ^ -838388596;
									continue;
								case 2u:
									flag = Class17.SetFileTime(safeFileHandle, null, &@struct, null);
									num3 = (int)(num2 * 1605625062) ^ -2141531468;
									continue;
								default:
									return;
								case 0u:
									break;
								case 1u:
									return;
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
								IL_0161:
								int num6 = 1656639159;
								while (true)
								{
									switch ((num2 = (uint)num6 ^ 0xBC41FB2u) % 3u)
									{
									case 1u:
										goto IL_012f;
									default:
										goto end_IL_0143;
									case 0u:
										break;
									case 2u:
										goto end_IL_0143;
									}
									goto IL_0161;
									IL_012f:
									((IDisposable)safeFileHandle).Dispose();
									num6 = ((int)num2 * -2129008990) ^ 0x93AB892;
									continue;
									end_IL_0143:
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
				string_ = GClass41.smethod_0(GClass41.smethod_13(string_0));
				num = (int)(num2 * 1601467399) ^ -1848440146;
			}
		}
	}

	public static GClass38 smethod_20(string string_0)
	{
		string text = default(string);
		GClass38 result = default(GClass38);
		while (true)
		{
			int num = 1708916696;
			while (true)
			{
				uint num2;
				object obj;
				switch ((num2 = (uint)num ^ 0x4D48989Bu) % 6u)
				{
				case 3u:
					text = GClass41.smethod_14(string_0);
					num = (int)(num2 * 767909385) ^ -1949907602;
					continue;
				case 2u:
					if (text != null)
					{
						num = (int)(num2 * 800381606) ^ -970848912;
						continue;
					}
					obj = null;
					goto IL_002c;
				case 1u:
					obj = new GClass38(text);
					goto IL_002c;
				case 0u:
					num = (int)((num2 * 112032013) ^ 0x38F00D72);
					continue;
				case 4u:
					break;
				default:
					{
						return result;
					}
					IL_002c:
					result = (GClass38)obj;
					num = 1991825545;
					continue;
				}
				break;
			}
		}
	}

	public static GClass38 smethod_21(string string_0, DirectorySecurity directorySecurity_0)
	{
		GClass38 result = default(GClass38);
		while (true)
		{
			int num = 1317389682;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5B948D3Bu) % 6u)
				{
				case 5u:
					result = new GClass38(string_0);
					num = (int)((num2 * 1746332247) ^ 0x134FD8AF);
					continue;
				case 3u:
					smethod_14(string_0);
					num = (int)(num2 * 424828396) ^ -769202083;
					continue;
				case 2u:
					smethod_40(string_0, directorySecurity_0);
					num = (int)(num2 * 21820920) ^ -1995715850;
					continue;
				case 1u:
					num = (int)(num2 * 1764867990) ^ -1218983917;
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

	public static DirectorySecurity smethod_22(string string_0)
	{
		DirectorySecurity result = default(DirectorySecurity);
		while (true)
		{
			int num = -930767602;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE297980Cu) % 4u)
				{
				case 3u:
					num = (int)(num2 * 887861156) ^ -1420255047;
					continue;
				case 2u:
					result = smethod_24(string_0, AccessControlSections.Access | AccessControlSections.Owner | AccessControlSections.Group);
					num = (int)(num2 * 1482073231) ^ -162043663;
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

	private static void smethod_23(int int_0, IntPtr intptr_0)
	{
		bool flag = default(bool);
		IntPtr zero = default(IntPtr);
		while (true)
		{
			int num = -2131832675;
			while (true)
			{
				uint num2;
				int num6;
				int num7;
				int num3;
				switch ((num2 = (uint)num ^ 0x99F99CFFu) % 18u)
				{
				case 17u:
					num = ((int)num2 * -2049271471) ^ -1557596598;
					continue;
				case 14u:
					flag = int_0 == 8;
					num = -577170494;
					continue;
				case 13u:
					if (int_0 != 5)
					{
						num = -1889315426;
						continue;
					}
					goto IL_003a;
				case 12u:
					if (int_0 == 0)
					{
						num = ((int)num2 * -1831342846) ^ 0x57742FA9;
						continue;
					}
					goto IL_007b;
				case 9u:
					if (zero.Equals((object?)(nint)intptr_0))
					{
						num = -1637602023;
						num6 = -1637602023;
						continue;
					}
					goto IL_007b;
				case 8u:
					if (int_0 != 1314)
					{
						num = -1757449860;
						num7 = -1757449860;
						continue;
					}
					goto IL_00aa;
				case 7u:
					if (int_0 != 1300)
					{
						num = -395811915;
						continue;
					}
					goto IL_00aa;
				case 6u:
					num = ((int)num2 * -292391527) ^ 0x21ADCD66;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -1812992226;
						num5 = -1812992226;
					}
					else
					{
						num4 = -379549068;
						num5 = -379549068;
					}
					num = num4 ^ ((int)num2 * -1555952078);
					continue;
				}
				case 3u:
					if (int_0 != 1347)
					{
						num = -196428339;
						num3 = -196428339;
						continue;
					}
					goto IL_003a;
				case 1u:
					num = ((int)num2 * -1682295580) ^ -331282621;
					continue;
				case 0u:
					zero = IntPtr.Zero;
					num = ((int)num2 * -2142313591) ^ -435547928;
					continue;
				default:
					return;
				case 4u:
					break;
				case 2u:
					throw new OutOfMemoryException();
				case 10u:
					throw new InvalidOperationException("Object does not have security descriptor,");
				case 15u:
					throw new UnauthorizedAccessException();
				case 16u:
					throw new PrivilegeNotHeldException("SeSecurityPrivilege");
				case 11u:
					return;
					IL_003a:
					num = -599586235;
					num3 = -599586235;
					continue;
					IL_007b:
					num = -1184611616;
					num6 = -1184611616;
					continue;
					IL_00aa:
					num = -1721936888;
					num7 = -1721936888;
					continue;
				}
				break;
			}
		}
	}

	public static DirectorySecurity smethod_24(string string_0, AccessControlSections accessControlSections_0)
	{
		DirectorySecurity directorySecurity = default(DirectorySecurity);
		IntPtr intptr_5 = default(IntPtr);
		byte[] array = default(byte[]);
		string string_ = default(string);
		SecurityInfos uint_ = default(SecurityInfos);
		DirectorySecurity result = default(DirectorySecurity);
		while (true)
		{
			int num = -349488635;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBA9AEACAu) % 12u)
				{
				case 11u:
					directorySecurity = new DirectorySecurity();
					num = ((int)num2 * -1021946529) ^ -683232086;
					continue;
				case 10u:
					Class17.LocalFree(intptr_5);
					num = (int)(num2 * 2010511694) ^ -652435607;
					continue;
				case 8u:
				{
					uint securityDescriptorLength = Class17.GetSecurityDescriptorLength(intptr_5);
					array = new byte[securityDescriptorLength];
					Marshal.Copy(intptr_5, array, 0, (int)securityDescriptorLength);
					num = (int)((num2 * 1866725862) ^ 0xA4C40D4);
					continue;
				}
				case 7u:
					string_ = GClass41.smethod_0(GClass41.smethod_13(string_0));
					uint_ = GClass33.smethod_14(accessControlSections_0);
					num = (int)((num2 * 1334319879) ^ 0x715FA78D);
					continue;
				case 6u:
				{
					IntPtr intptr_;
					IntPtr intptr_2;
					IntPtr intptr_3;
					IntPtr intptr_4;
					int namedSecurityInfoW = (int)Class17.GetNamedSecurityInfoW(string_, 1u, (uint)uint_, out intptr_, out intptr_2, out intptr_3, out intptr_4, out intptr_5);
					smethod_23(namedSecurityInfoW, intptr_5);
					num = ((int)num2 * -185027578) ^ 0x6C4378D1;
					continue;
				}
				case 4u:
					num = ((int)num2 * -902588652) ^ 0x3FBB7E9F;
					continue;
				case 3u:
					num = ((int)num2 * -1587146805) ^ -56899213;
					continue;
				case 2u:
					result = directorySecurity;
					num = ((int)num2 * -336925540) ^ -266668814;
					continue;
				case 1u:
					directorySecurity.SetSecurityDescriptorBinaryForm(array);
					num = (int)(num2 * 2130511901) ^ -1142636177;
					continue;
				case 0u:
					num = (int)((num2 * 562058946) ^ 0x6023A30C);
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

	public static DateTime smethod_25(string string_0)
	{
		DateTime result = default(DateTime);
		DateTime dateTime = default(DateTime);
		while (true)
		{
			int num = -351781808;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8790A4DDu) % 4u)
				{
				case 3u:
					result = dateTime.ToLocalTime();
					num = ((int)num2 * -2045121303) ^ 0x1557D2;
					continue;
				case 1u:
					dateTime = smethod_26(string_0);
					num = (int)((num2 * 1448018458) ^ 0x7C04A914);
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

	public static DateTime smethod_26(string string_0)
	{
		GClass38 gClass = default(GClass38);
		DateTime dateTime_ = default(DateTime);
		while (true)
		{
			int num = 305374424;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF56C621u) % 4u)
				{
				case 1u:
					gClass = new GClass38(string_0);
					num = ((int)num2 * -225630939) ^ -290298464;
					continue;
				case 0u:
					dateTime_ = gClass.DateTime_1;
					num = ((int)num2 * -305876109) ^ 0x74233AA;
					continue;
				case 2u:
					break;
				default:
					return dateTime_;
				}
				break;
			}
		}
	}

	public static string[] smethod_27(string string_0)
	{
		string[] result = GClass43.smethod_0(smethod_5(string_0, "*", bool_0: true, bool_1: false, SearchOption.TopDirectoryOnly));
		while (true)
		{
			int num = -1464154757;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDD563299u) % 3u)
				{
				case 1u:
					goto IL_0016;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0016:
				num = (int)((num2 * 368772731) ^ 0x421C6E27);
			}
		}
	}

	public static string[] smethod_28(string string_0, string string_1)
	{
		string[] result = GClass43.smethod_0(smethod_5(string_0, string_1, bool_0: true, bool_1: false, SearchOption.TopDirectoryOnly));
		while (true)
		{
			int num = 612275767;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x14B4C6D7u) % 3u)
				{
				case 2u:
					goto IL_0012;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0012:
				num = ((int)num2 * -1636718641) ^ 0x2B1173F1;
			}
		}
	}

	public static string smethod_29(string string_0)
	{
		string text = default(string);
		string result = default(string);
		while (true)
		{
			int num = 1759497319;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x13487E31u) % 5u)
				{
				case 3u:
					text = GClass41.smethod_13(string_0);
					num = (int)(num2 * 1112293819) ^ -258652132;
					continue;
				case 1u:
					num = (int)((num2 * 1743772262) ^ 0x57427E7F);
					continue;
				case 0u:
					result = text.Substring(0, GClass41.smethod_16(text));
					num = ((int)num2 * -2129540648) ^ 0x7F61CEE1;
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

	public static string[] smethod_30(string string_0, string string_1)
	{
		string[] result = GClass43.smethod_0(smethod_5(string_0, string_1, bool_0: false, bool_1: true, SearchOption.TopDirectoryOnly));
		while (true)
		{
			int num = -656848877;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDF5DC733u) % 3u)
				{
				case 2u:
					goto IL_0012;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0012:
				num = ((int)num2 * -702192377) ^ 0x359D93C5;
			}
		}
	}

	public static string[] smethod_31(string string_0, string string_1, SearchOption searchOption_0)
	{
		string[] result = default(string[]);
		while (true)
		{
			int num = 1909659609;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2B9A77F7u) % 3u)
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
				result = GClass43.smethod_0(smethod_5(string_0, string_1, bool_0: false, bool_1: true, searchOption_0));
				num = ((int)num2 * -2008437754) ^ 0x2FEE0F99;
			}
		}
	}

	public static string[] smethod_32(string string_0)
	{
		string[] result = default(string[]);
		while (true)
		{
			int num = 1182017608;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x531EA98Eu) % 3u)
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
				result = GClass43.smethod_0(smethod_5(string_0, null, bool_0: true, bool_1: true, SearchOption.TopDirectoryOnly));
				num = (int)((num2 * 560393238) ^ 0x382DBDCB);
			}
		}
	}

	public static string[] smethod_33(string string_0, string string_1)
	{
		string[] result = default(string[]);
		while (true)
		{
			int num = -708451113;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD32D0B76u) % 3u)
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
				result = GClass43.smethod_0(smethod_5(string_0, string_1, bool_0: true, bool_1: true, SearchOption.TopDirectoryOnly));
				num = (int)((num2 * 1260668978) ^ 0x6286A7C9);
			}
		}
	}

	public static string[] smethod_34(string string_0, string string_1, SearchOption searchOption_0)
	{
		string[] result = GClass43.smethod_0(smethod_5(string_0, string_1, bool_0: true, bool_1: true, searchOption_0));
		while (true)
		{
			int num = -55281888;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8B2C4A2Eu) % 3u)
				{
				case 1u:
					goto IL_0012;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_0012:
				num = (int)((num2 * 1673725286) ^ 0x31C79D25);
			}
		}
	}

	public static DateTime smethod_35(string string_0)
	{
		DateTime dateTime = smethod_36(string_0);
		DateTime result = default(DateTime);
		while (true)
		{
			int num = 190833326;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7444C2u) % 3u)
				{
				case 1u:
					goto IL_0009;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0009:
				result = dateTime.ToLocalTime();
				num = ((int)num2 * -1246982559) ^ -1500867014;
			}
		}
	}

	public static DateTime smethod_36(string string_0)
	{
		DateTime dateTime_ = default(DateTime);
		GClass38 gClass = default(GClass38);
		while (true)
		{
			int num = -1506646734;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x97D155F9u) % 5u)
				{
				case 4u:
					dateTime_ = gClass.DateTime_5;
					num = (int)((num2 * 844420859) ^ 0x4857EBFF);
					continue;
				case 3u:
					num = ((int)num2 * -752810206) ^ 0x431D5728;
					continue;
				case 2u:
					gClass = new GClass38(string_0);
					num = (int)((num2 * 2040851334) ^ 0x632C779D);
					continue;
				case 0u:
					break;
				default:
					return dateTime_;
				}
				break;
			}
		}
	}

	public static DateTime smethod_37(string string_0)
	{
		DateTime result = default(DateTime);
		DateTime dateTime = default(DateTime);
		while (true)
		{
			int num = 983344030;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3CA2864u) % 5u)
				{
				case 4u:
					result = dateTime.ToLocalTime();
					num = ((int)num2 * -865059350) ^ -1188247237;
					continue;
				case 3u:
					num = (int)(num2 * 1802347072) ^ -68516337;
					continue;
				case 2u:
					dateTime = smethod_38(string_0);
					num = ((int)num2 * -1637102855) ^ -1171829849;
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

	public static DateTime smethod_38(string string_0)
	{
		GClass38 gClass = new GClass38(string_0);
		DateTime dateTime_ = default(DateTime);
		while (true)
		{
			int num = -560722791;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8469896Bu) % 3u)
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
				num = (int)(num2 * 2093908225) ^ -1928496524;
			}
		}
	}

	public static string[] smethod_39()
	{
		return Directory.GetLogicalDrives();
	}

	public static void smethod_40(string string_0, DirectorySecurity directorySecurity_0)
	{
		if (string_0 == null)
		{
			goto IL_0015;
		}
		goto IL_0060;
		IL_0060:
		int num;
		int num2;
		if (directorySecurity_0 != null)
		{
			num = 216113123;
			num2 = 216113123;
		}
		else
		{
			num = 1752660943;
			num2 = 1752660943;
		}
		goto IL_002d;
		IL_002d:
		string string_ = default(string);
		while (true)
		{
			switch ((uint)(num ^ 0x501FB6F5) % 6u)
			{
			case 5u:
				break;
			case 4u:
				string_ = GClass41.smethod_0(GClass41.smethod_13(string_0));
				num = 994159296;
				continue;
			case 1u:
				goto IL_0060;
			case 0u:
				throw new ArgumentNullException("directorySecurity");
			case 2u:
				throw new ArgumentNullException("path");
			default:
				GClass33.smethod_15(directorySecurity_0, string_);
				return;
			}
			break;
		}
		goto IL_0015;
		IL_0015:
		num = 2030257983;
		goto IL_002d;
	}

	public static void smethod_41(string string_0, DateTime dateTime_0)
	{
		while (true)
		{
			int num = 216245204;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1C876842u) % 3u)
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
				smethod_17(string_0, dateTime_0.ToUniversalTime());
				num = (int)((num2 * 595756427) ^ 0x3DBEB3A5);
			}
		}
	}

	public static void smethod_42(string string_0, DateTime dateTime_0)
	{
		while (true)
		{
			int num = 825482924;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x21E7DA6Fu) % 3u)
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
				smethod_19(string_0, dateTime_0.ToUniversalTime());
				num = ((int)num2 * -778347330) ^ -1483184358;
			}
		}
	}

	public unsafe static void smethod_43(string string_0, DateTime dateTime_0)
	{
		string string_ = default(string);
		bool flag = default(bool);
		Class17.Struct7 @struct = default(Class17.Struct7);
		while (true)
		{
			int num = -327571397;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF5728145u) % 3u)
				{
				case 2u:
					goto IL_0003;
				case 0u:
					break;
				default:
				{
					SafeFileHandle safeFileHandle = smethod_0(string_);
					try
					{
						while (true)
						{
							int num3 = -1562792828;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xF5728145u) % 7u)
								{
								case 6u:
								{
									int num4;
									int num5;
									if (!flag)
									{
										num4 = -1616573661;
										num5 = -1616573661;
									}
									else
									{
										num4 = -1056959765;
										num5 = -1056959765;
									}
									num3 = num4 ^ (int)(num2 * 1871180498);
									continue;
								}
								case 5u:
								{
									int lastWin32Error = Marshal.GetLastWin32Error();
									GClass33.smethod_13(lastWin32Error, string_0);
									num3 = -2135213111;
									continue;
								}
								case 4u:
									@struct = new Class17.Struct7(dateTime_0.ToFileTimeUtc());
									num3 = (int)(num2 * 1982767878) ^ -1012269821;
									continue;
								case 0u:
									flag = Class17.SetFileTime(safeFileHandle, null, null, &@struct);
									num3 = ((int)num2 * -1435645102) ^ 0x458267AF;
									continue;
								default:
									return;
								case 2u:
									break;
								case 1u:
									return;
								case 3u:
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
								IL_0134:
								int num6 = -503857310;
								while (true)
								{
									switch ((num2 = (uint)num6 ^ 0xF5728145u) % 3u)
									{
									case 2u:
										goto IL_0102;
									default:
										goto end_IL_0116;
									case 0u:
										break;
									case 1u:
										goto end_IL_0116;
									}
									goto IL_0134;
									IL_0102:
									((IDisposable)safeFileHandle).Dispose();
									num6 = ((int)num2 * -1579149030) ^ -514168478;
									continue;
									end_IL_0116:
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
				string_ = GClass41.smethod_0(GClass41.smethod_13(string_0));
				num = ((int)num2 * -1089182757) ^ 0x10B0FA6F;
			}
		}
	}

	public static void smethod_44(string string_0)
	{
		throw new NotSupportedException("Windows does not support setting the current directory to a long path");
	}
}
