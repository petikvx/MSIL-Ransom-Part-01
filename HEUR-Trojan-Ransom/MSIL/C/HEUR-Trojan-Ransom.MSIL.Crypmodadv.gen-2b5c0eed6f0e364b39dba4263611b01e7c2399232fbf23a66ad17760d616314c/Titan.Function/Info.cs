using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using _00f00711;
using _0de3e082;
using _40ac67aa;
using _5ad2d47d;
using _68624345;
using _950c89cf;
using b501d693;
using ba029039;

namespace Titan.Function;

internal class Info
{
	public static string Set()
	{
		//IL_0043: Expected O, but got I4
		//IL_0088: Expected O, but got I4
		//IL_00cd: Expected O, but got I4
		//IL_0117: Expected O, but got I4
		//IL_0161: Expected O, but got I4
		//IL_01a8: Expected O, but got I4
		//IL_023e: Expected O, but got I4
		//IL_0284: Expected O, but got I4
		//IL_02ca: Expected O, but got I4
		//IL_032b: Expected O, but got I4
		//IL_03c6: Expected O, but got I4
		string result = default(string);
		try
		{
			string s = _33415a4a.c348cb2e(new string[11]
			{
				_003CModule_003E._6931997e<string>((uint)(_003CModule_003E.a200837b("LTEzMjA5MzkzNzk=") + 828177 - Math.Max(828177, 414088)), 0 + int.Parse("747299139")),
				Data.UUID,
				_003CModule_003E._31ec1b2a<string>((uint)(_003CModule_003E.a200837b("LTExMDgwMTI2ODU=") + 828177 - Math.Max(828177, 414088)), 0 + int.Parse("1331885367")),
				GetIP(),
				_003CModule_003E._9e15c4c7<string>((uint)(_003CModule_003E.a200837b("LTEwOTQxMTY3NQ==") + 828177 - Math.Max(828177, 414088)), 0 + int.Parse("640585113")),
				_003CModule_003E._009B_002AJ_0027Ý(),
				_003CModule_003E._0aa39330<string>((uint)(_003CModule_003E.a200837b("LTE0NzI0MjMwOTU=") + 828177 - Math.Min(828177, 1656354)), 0 + int.Parse("1455746217")),
				_003CModule_003E.Â0_0014ÛÔ(),
				_003CModule_003E._49b74782<string>((uint)(_003CModule_003E.a200837b("Mjk1ODczMTQ3") + 828177 - Math.Max(828177, 414088)), 0 + int.Parse("1436168870")),
				GetWindowsVersion(),
				_003CModule_003E._6931997e<string>((uint)(_003CModule_003E.a200837b("MTExMzQ4MTc0Ng==") + Math.Min(828177, 1656354) - 828177), 0 + int.Parse("1292292819"))
			});
			Guid guid = default(Guid);
			byte[] inArray = default(byte[]);
			byte[] inArray2 = default(byte[]);
			while (true)
			{
				int num = 1375480577;
				while (true)
				{
					int num2;
					switch ((uint)(num2 = _003CModule_003E._9a3c02a2(num)) % 5u)
					{
					case 0u:
						break;
					case 1u:
						guid = _003CModule_003E.ì_00AFC_0019s();
						num = (num2 * -1009200940) ^ 0x42576AC;
						continue;
					case 2u:
						result = Convert.ToBase64String(Encoding.UTF8.GetBytes(_003CModule_003E._6931997e<string>((uint)(_003CModule_003E.a200837b("MTE5Njc4MTkzMw==") + 828177 - Math.Max(828177, 414088)), 0 + int.Parse("1052908887")) + Convert.ToBase64String(inArray) + _003CModule_003E._9e15c4c7<string>((uint)(_003CModule_003E.a200837b("LTEwOTQxMTc2OQ==") + Math.Min(828177, 1656354) - 828177), 0 + int.Parse("542900543")) + Convert.ToBase64String(inArray2) + _003CModule_003E._31ec1b2a<string>((uint)(_003CModule_003E.a200837b("NTAxOTkzMzky") + Math.Min(828177, 1656354) - 828177), 0 + int.Parse("86284965"))));
						num = (num2 * -1556983500) ^ -242796048;
						continue;
					case 4u:
					{
						byte[] array = Encrypt.ComputeMD5Hash(guid.ToString(_003CModule_003E._9e15c4c7<string>((uint)(_003CModule_003E.a200837b("LTEwOTQxMTcwNA==") + 828177 - Math.Min(828177, 1656354)), 0 + int.Parse("837947824"))));
						inArray = Encrypt.RSAEncrypt(array, Data.PCDataPublicKey);
						inArray2 = Encrypt.AESEncrypt(array, Encoding.UTF8.GetBytes(s), isCBC: false);
						num = (num2 * 4080286) ^ -1313785253;
						continue;
					}
					default:
						return result;
					case 3u:
						return result;
					}
					break;
				}
			}
		}
		catch
		{
			while (true)
			{
				int num3 = -1875734861;
				while (true)
				{
					int num2;
					switch ((uint)(num2 = _003CModule_003E._9a3c02a2(num3)) % 3u)
					{
					case 0u:
						break;
					case 2u:
						goto IL_038c;
					default:
						return result;
					case 1u:
						return result;
					}
					break;
					IL_038c:
					result = _003CModule_003E._0aa39330<string>((uint)(_003CModule_003E.a200837b("LTE0NzI0MjMxMjc=") + 828177 - Math.Min(828177, 1656354)), 0 + int.Parse("415472287"));
					num3 = (num2 * -1144901850) ^ 0x69E47F2F;
				}
			}
		}
	}

	public static string GetWindowsVersion()
	{
		//IL_003a: Expected O, but got I4
		//IL_0085: Expected O, but got I4
		//IL_00c5: Expected O, but got I4
		//IL_0148: Expected O, but got I4
		//IL_019e: Expected O, but got I4
		//IL_01e2: Expected O, but got I4
		//IL_0227: Expected O, but got I4
		//IL_0268: Expected O, but got I4
		//IL_02a4: Expected O, but got I4
		//IL_02e5: Expected O, but got I4
		//IL_0321: Expected O, but got I4
		//IL_0362: Expected O, but got I4
		//IL_039e: Expected O, but got I4
		//IL_03df: Expected O, but got I4
		//IL_041b: Expected O, but got I4
		//IL_045c: Expected O, but got I4
		//IL_0497: Expected O, but got I4
		//IL_04f9: Expected O, but got I4
		//IL_0567: Expected O, but got I4
		string result = _003CModule_003E._49b74782<string>((uint)(_003CModule_003E.a200837b("Mjk1ODczMTc3") + 8041211 - Math.Min(8041211, 16082422)), 0 + int.Parse("985566486"));
		try
		{
			Process process = _003CModule_003E._00B0Ñ_0009_002Dª();
			ProcessStartInfo processStartInfo = _003CModule_003E._00B4Ü_009EÅ_002E(_003CModule_003E._9e15c4c7<string>((uint)(_003CModule_003E.a200837b("LTEwOTQxMTc2NQ==") + Math.Min(8041211, 16082422) - 8041211), 0 + int.Parse("595212694")));
			_7236760a.b6a412fb(processStartInfo, _003CModule_003E._31ec1b2a<string>((uint)(_003CModule_003E.a200837b("NTg4ODg5NTc4") + 8041211 - Math.Min(8041211, 16082422)), 0 + int.Parse("1535134901")));
			_26312f0c._1574f349(processStartInfo, false);
			_26312f0c.bbedf743(processStartInfo, true);
			_26312f0c._355e72d0(processStartInfo, true);
			_26312f0c.e2475afc(processStartInfo, true);
			_2774c93a._1bdd2870(processStartInfo, ProcessWindowStyle.Hidden);
			e388b2c2.bb90d5e0(process, processStartInfo);
			d1ee362e._812932bd(process);
			c477b455._3f0e7cd2(process);
			string text = _51d8232e.e4b3c677(_51d8232e.e4b3c677(_160654c1._72a48564(_51d8232e.e4b3c677(f55d36fd.b069bf89(_9f57252b.b6e9db2d((TextReader)c80e2b4a.b2aff019(process))), _003CModule_003E._31ec1b2a<string>((uint)(_003CModule_003E.a200837b("MTUxNzM5OTk4Ng==") + 8041211 - Math.Min(8041211, 16082422)), 0 + int.Parse("243086240")), ""), new char[1] { '=' })[1], _003CModule_003E._9e15c4c7<string>((uint)(_003CModule_003E.a200837b("LTEwOTQxMTcxMw==") + 8041211 - Math.Max(8041211, 4020605)), 0 + int.Parse("2030993804")), ""), _003CModule_003E._31ec1b2a<string>((uint)(_003CModule_003E.a200837b("LTE2NTgyODQ1OA==") + 8041211 - Math.Min(8041211, 16082422)), 0 + int.Parse("2076607290")), "");
			if (_4192c243._68e229e8(text, _003CModule_003E._0aa39330<string>((uint)(_003CModule_003E.a200837b("LTE0NzI0MjMxNDk=") + 8041211 - Math.Min(8041211, 16082422)), 0 + int.Parse("1819203641"))))
			{
				result = _003CModule_003E._49b74782<string>((uint)(_003CModule_003E.a200837b("Mjk1ODczMDky") + 8041211 - Math.Max(8041211, 4020605)), 0 + int.Parse("1944886845"));
			}
			if (_4192c243._68e229e8(text, _003CModule_003E._0aa39330<string>((uint)(_003CModule_003E.a200837b("LTE0NzI0MjMxNTU=") + 8041211 - Math.Min(8041211, 16082422)), 0 + int.Parse("1403865507"))))
			{
				result = _003CModule_003E._6931997e<string>((uint)(_003CModule_003E.a200837b("MTEyMjcwODEwMQ==") + 8041211 - Math.Max(8041211, 4020605)), 0 + int.Parse("91564647"));
			}
			if (_4192c243._68e229e8(text, _003CModule_003E._0aa39330<string>((uint)(_003CModule_003E.a200837b("LTE0NzI0MjMxNjE=") + 8041211 - Math.Max(8041211, 4020605)), 0 + int.Parse("1809264137"))))
			{
				result = _003CModule_003E._9e15c4c7<string>((uint)(_003CModule_003E.a200837b("LTEwOTQxMTczMQ==") + 8041211 - Math.Max(8041211, 4020605)), 0 + int.Parse("512621390"));
			}
			if (_4192c243._68e229e8(text, _003CModule_003E._9e15c4c7<string>((uint)(_003CModule_003E.a200837b("LTEwOTQxMTczNQ==") + 8041211 - Math.Min(8041211, 16082422)), 0 + int.Parse("27409802"))))
			{
				result = _003CModule_003E._9e15c4c7<string>((uint)(_003CModule_003E.a200837b("LTEwOTQxMTgxNw==") + 8041211 - Math.Max(8041211, 4020605)), 0 + int.Parse("2119584574"));
			}
			if (_4192c243._68e229e8(text, _003CModule_003E._6931997e<string>((uint)(_003CModule_003E.a200837b("MjM0MDg1MTA5") + 8041211 - Math.Max(8041211, 4020605)), 0 + int.Parse("649439308"))))
			{
				result = _003CModule_003E._31ec1b2a<string>((uint)(_003CModule_003E.a200837b("OTM2NDc0MzIy") + Math.Min(8041211, 16082422) - 8041211), 0 + int.Parse("1405813698"));
			}
			if (_4192c243._68e229e8(text, _003CModule_003E._6931997e<string>((uint)(_003CModule_003E.a200837b("LTE3MDk3NjEyNDk=") + 8041211 - Math.Max(8041211, 4020605)), 0 + int.Parse("1221317952"))))
			{
				while (true)
				{
					int num = 980007907;
					while (true)
					{
						int num2;
						switch ((uint)(num2 = _003CModule_003E._9a3c02a2(num)) % 3u)
						{
						case 2u:
							break;
						case 1u:
							goto IL_04bf;
						default:
							return result;
						case 0u:
							return result;
						}
						break;
						IL_04bf:
						result = _003CModule_003E._49b74782<string>((uint)(_003CModule_003E.a200837b("Mjk1ODczMTI1") + 8041211 - Math.Max(8041211, 4020605)), 0 + int.Parse("1206992569"));
						num = (num2 * -1096541498) ^ 0x64E87325;
					}
				}
			}
			return result;
		}
		catch
		{
			while (true)
			{
				int num3 = 1731110907;
				while (true)
				{
					int num2;
					switch ((uint)(num2 = _003CModule_003E._9a3c02a2(num3)) % 3u)
					{
					case 2u:
						break;
					case 1u:
						goto IL_052d;
					default:
						return result;
					case 0u:
						return result;
					}
					break;
					IL_052d:
					result = _003CModule_003E._31ec1b2a<string>((uint)(_003CModule_003E.a200837b("LTE2MDIwNDIxNjM=") + 8041211 - Math.Max(8041211, 4020605)), 0 + int.Parse("684916831"));
					num3 = (num2 * -461256536) ^ 0x34B3C200;
				}
			}
		}
	}

	private static string GetIP()
	{
		//IL_0049: Expected O, but got I4
		string result = default(string);
		try
		{
			result = _003CModule_003E._00A3I_0096D_00A9(_003CModule_003E.ÓRA_0001_003B(), _003CModule_003E._6931997e<string>((uint)(_003CModule_003E.a200837b("LTY1ODkwOTc=") + 3910525 - Math.Min(3910525, 7821050)), 0 + int.Parse("578154602")));
			return result;
		}
		catch
		{
			while (true)
			{
				int num = 1301209381;
				while (true)
				{
					int num2;
					switch ((uint)(num2 = _003CModule_003E._9a3c02a2(num)) % 3u)
					{
					case 0u:
						break;
					case 2u:
						goto IL_0073;
					default:
						return result;
					case 1u:
						return result;
					}
					break;
					IL_0073:
					result = "";
					num = (num2 * 1622194492) ^ -447507897;
				}
			}
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool GetVolumeInformation(string name, StringBuilder buffer, int size, out uint num, out uint length, out uint auto, StringBuilder buff, int siz);

	public static string GetUUID()
	{
		//IL_0099: Expected O, but got I4
		//IL_00e3: Expected O, but got I4
		//IL_01c1: Expected O, but got I4
		string result = default(string);
		try
		{
			StringBuilder buffer = _003CModule_003E._001CäP7_008E(256);
			Guid guid = default(Guid);
			StringBuilder buff = default(StringBuilder);
			while (true)
			{
				int num = -2146433167;
				while (true)
				{
					int num2;
					string text;
					switch ((uint)(num2 = _003CModule_003E._9a3c02a2(num)) % 6u)
					{
					case 4u:
						break;
					case 1u:
						guid = _003CModule_003E.ì_00AFC_0019s();
						num = (num2 * 1574246088) ^ -1657326374;
						continue;
					case 2u:
						text = guid.ToString(_003CModule_003E._31ec1b2a<string>((uint)(_003CModule_003E.a200837b("MTMyOTkzMzc5NQ==") + 7282220 - Math.Min(7282220, 14564440)), 0 + int.Parse("981758207"))).Substring(0, 8);
						goto IL_00e8;
					case 3u:
						buff = _003CModule_003E._001CäP7_008E(256);
						num = (num2 * 1084195488) ^ -327160432;
						continue;
					case 0u:
					{
						if (GetVolumeInformation(_003CModule_003E.µßË_0023C(_003CModule_003E.ÇV0_0004_0004()), buffer, 256, out var num3, out var _, out var _, buff, 256))
						{
							text = num3.ToString(_003CModule_003E._6931997e<string>((uint)(_003CModule_003E.a200837b("MjAyMDU1NzQ0OA==") + 7282220 - Math.Max(7282220, 3641110)), 0 + int.Parse("1596826061")));
							goto IL_00e8;
						}
						num = (num2 * -1520762538) ^ -1529049345;
						continue;
					}
					default:
						return result;
					case 5u:
						{
							return result;
						}
						IL_00e8:
						result = text;
						num = -584864673;
						continue;
					}
					break;
				}
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.ToString());
			while (true)
			{
				int num4 = -773767836;
				while (true)
				{
					int num2;
					switch ((uint)(num2 = _003CModule_003E._9a3c02a2(num4)) % 3u)
					{
					case 0u:
						break;
					case 1u:
						goto IL_0187;
					default:
						return result;
					case 2u:
						return result;
					}
					break;
					IL_0187:
					result = _003CModule_003E._9e15c4c7<string>((uint)(_003CModule_003E.a200837b("LTEwOTQxMTc3NQ==") + 7282220 - Math.Max(7282220, 3641110)), 0 + int.Parse("2129111440"));
					num4 = (num2 * 638003139) ^ 0x51903274;
				}
			}
		}
	}
}
