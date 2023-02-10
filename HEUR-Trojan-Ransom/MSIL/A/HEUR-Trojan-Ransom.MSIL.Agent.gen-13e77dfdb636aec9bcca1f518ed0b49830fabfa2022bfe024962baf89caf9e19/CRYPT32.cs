using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading;

internal class CRYPT32
{
	private class System_LazyDebugView : IDisposable
	{
		private Process Get_Exceptions;

		private StreamWriter IsCallConvCdecl;

		private AutoResetEvent Get_TypeSig;

		private string set_ObjectName;

		public System_LazyDebugView(string P_0)
		{
			ProcessStartInfo processStartInfo = default(ProcessStartInfo);
			while (true)
			{
				int num = -741210452;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)_003CModule_003E.IsAutoLayout(num)) % 25u)
					{
					case 11u:
						break;
					default:
						return;
					case 8u:
						_003CModule_003E._0029_00A5_00A0mN(processStartInfo, true);
						num = (int)(num2 * 2018373659) ^ -1335940099;
						continue;
					case 2u:
						Get_TypeSig = (AutoResetEvent)_003CModule_003E.Ø_0082Ëì_(false);
						num = (int)(num2 * 1045528483) ^ -129299193;
						continue;
					case 3u:
						_003CModule_003E.ûÒ_000Fh_0004(processStartInfo, false);
						num = ((int)num2 * -357021151) ^ 0x6B691F30;
						continue;
					case 7u:
						_003CModule_003E.còÒg_0089(Get_Exceptions);
						num = ((int)num2 * -1725235514) ^ 0x79AC492;
						continue;
					case 18u:
						num = (int)((num2 * 1884145556) ^ 0x3955BDC2);
						continue;
					case 9u:
						num = (int)(num2 * 1056337399) ^ -172347564;
						continue;
					case 20u:
						num = ((int)num2 * -1828138537) ^ -1075712853;
						continue;
					case 13u:
						_003CModule_003E._001Aý_001E_008F_0085(Get_Exceptions, processStartInfo);
						num = (int)((num2 * 1579722358) ^ 0x3844AA16);
						continue;
					case 24u:
						set_ObjectName = string.Empty;
						num = ((int)num2 * -480628332) ^ 0x5194F8A9;
						continue;
					case 4u:
						_003CModule_003E._000DÛhyð(processStartInfo, true);
						num = ((int)num2 * -1588720694) ^ 0x1CA401C1;
						continue;
					case 10u:
						num = ((int)num2 * -988117616) ^ 0x4FD95877;
						continue;
					case 16u:
						_003CModule_003E.óÊ_0085_008CA(processStartInfo, P_0);
						num = ((int)num2 * -969573607) ^ -534526850;
						continue;
					case 5u:
						_003CModule_003E._000Bt_0020_007C_0099(processStartInfo, true);
						num = ((int)num2 * -2013709132) ^ 0x2F1E7C6E;
						continue;
					case 19u:
						num = (int)((num2 * 1621756390) ^ 0x6B3ABAD);
						continue;
					case 17u:
						num = ((int)num2 * -2087869156) ^ 0x299202F3;
						continue;
					case 1u:
						IsCallConvCdecl = (StreamWriter)_003CModule_003E.ãóÒ7_00BF(Get_Exceptions);
						num = (int)(num2 * 502741654) ^ -778200779;
						continue;
					case 6u:
						num = (int)((num2 * 1713084770) ^ 0x3FBC5DB8);
						continue;
					case 12u:
						num = (int)((num2 * 1302812957) ^ 0x1B652A56);
						continue;
					case 21u:
						_003CModule_003E._0081r_0018Bi(Get_Exceptions, new DataReceivedEventHandler(NIsTransientInternal));
						num = ((int)num2 * -374904143) ^ 0x4ED1D2DB;
						continue;
					case 15u:
						processStartInfo = (ProcessStartInfo)_003CModule_003E.e_00B0_002BÀ_0006();
						num = (int)(num2 * 1691637375) ^ -1193553642;
						continue;
					case 14u:
						Get_Exceptions = (Process)_003CModule_003E.ìç1t_002F();
						num = (int)((num2 * 455943889) ^ 0x7047E96);
						continue;
					case 23u:
						_003CModule_003E.îÔ_00B4fÀ(Get_Exceptions);
						num = ((int)num2 * -1051694441) ^ -725988199;
						continue;
					case 0u:
						num = (int)((num2 * 1723974885) ^ 0x4790638E);
						continue;
					case 22u:
						return;
					}
					break;
				}
			}
		}

		public void Dispose()
		{
			while (true)
			{
				int num = -1591169212;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)_003CModule_003E.IsAutoLayout(num)) % 10u)
					{
					case 6u:
						break;
					default:
						return;
					case 5u:
						_003CModule_003E.R_00265_00B2Y(IsCallConvCdecl);
						num = (int)((num2 * 988990557) ^ 0x1BF5587D);
						continue;
					case 7u:
						num = ((int)num2 * -1712605337) ^ 0x6AB167D4;
						continue;
					case 8u:
						_003CModule_003E.Àí_003D_00A0_00A2(Get_Exceptions);
						num = (int)(num2 * 742047335) ^ -369165213;
						continue;
					case 1u:
						_003CModule_003E._00BE_0089_000Ds_009D(IsCallConvCdecl);
						num = ((int)num2 * -1336421900) ^ -2012482491;
						continue;
					case 4u:
						num = ((int)num2 * -1046079099) ^ -1423860034;
						continue;
					case 2u:
						num = (int)((num2 * 542744176) ^ 0x7DE9CE0F);
						continue;
					case 9u:
						num = (int)((num2 * 1475185870) ^ 0x1A6CDD98);
						continue;
					case 3u:
						_003CModule_003E._0082ö_001FÖ_002D(Get_Exceptions);
						num = (int)(num2 * 1421635240) ^ -2023929798;
						continue;
					case 0u:
						return;
					}
					break;
				}
			}
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Dispose
			this.Dispose();
		}

		public unsafe string Get_IFIRSTWEEKOFYEAR(string P_0)
		{
			while (true)
			{
				int num = 1165711126;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)_003CModule_003E.IsAutoLayout(num)) % 10u)
					{
					case 5u:
						break;
					case 1u:
						set_ObjectName = string.Empty;
						num = ((int)num2 * -748850597) ^ -745800856;
						continue;
					case 0u:
						_003CModule_003E._00BBº_0004_001F_00AE(IsCallConvCdecl, _003CModule_003E.Get_AsyncWaitHandle<string>((uint)(-1987351685 + sizeof(Guid) + 632), "\a\n\t\u000faZI\u0015WK", (uint)(6691 + sizeof(ushort) - 695), "Why are black black?"));
						num = (int)(num2 * 1362993208) ^ -465368927;
						continue;
					case 6u:
						_003CModule_003E.GetModule2_NoLock = set_ObjectName;
						num = ((int)num2 * -1205924656) ^ -2130325372;
						continue;
					case 9u:
						num = (int)((num2 * 1213716188) ^ 0x535E8773);
						continue;
					case 2u:
						num = (int)((num2 * 255114986) ^ 0x29242B19);
						continue;
					case 7u:
						num = ((int)num2 * -75522984) ^ 0x1BE8F642;
						continue;
					case 8u:
						_003CModule_003E._00BBº_0004_001F_00AE(IsCallConvCdecl, P_0);
						num = (int)((num2 * 42771543) ^ 0x3C09B262);
						continue;
					case 4u:
						_003CModule_003E.é_000C_00B1þ_00B8(Get_TypeSig);
						num = ((int)num2 * -906371391) ^ -817293407;
						continue;
					default:
						return _003CModule_003E.GetModule2_NoLock;
					}
					break;
				}
			}
		}

		private unsafe void NIsTransientInternal(object P_0, DataReceivedEventArgs P_1)
		{
			while (true)
			{
				int num = 1090368354;
				while (true)
				{
					uint num2;
					int expandEnvironmentStrings;
					switch ((num2 = (uint)_003CModule_003E.IsAutoLayout(num)) % 8u)
					{
					case 7u:
						break;
					default:
						return;
					case 5u:
						num = (int)((num2 * 1131876182) ^ 0x182786C1);
						continue;
					case 3u:
						expandEnvironmentStrings = (_003CModule_003E._001Ebú_009D_008A(_003CModule_003E.V_0013_0017_000E_0026(P_1), _003CModule_003E.Control<string>((uint)(976421846 + sizeof(bool) + 960), "\f\u000f\u0005\a}zq\u0005\b", (uint)(5777 + sizeof(long) + 48), "OOF")) ? 1 : 0);
						goto IL_00a3;
					case 1u:
						if (_003CModule_003E.V_0013_0017_000E_0026(P_1) == null)
						{
							expandEnvironmentStrings = -957 + sizeof(double) + 950;
							goto IL_00a3;
						}
						num = (int)(num2 * 365578468) ^ -702404156;
						continue;
					case 6u:
						set_ObjectName = _003CModule_003E._005DH8x_009E(set_ObjectName, _003CModule_003E.V_0013_0017_000E_0026(P_1), _003CModule_003E.Ô_00AF_000A_0094u());
						num = 1377268239;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (!_003CModule_003E.ExpandEnvironmentStrings)
						{
							num3 = 1571334701;
							num4 = num3;
						}
						else
						{
							num3 = -2012172527;
							num4 = num3;
						}
						num = num3 ^ (int)(num2 * 1778754489);
						continue;
					}
					case 2u:
						_003CModule_003E.V3_0096üO(Get_TypeSig);
						num = (int)(num2 * 244453893) ^ -543621564;
						continue;
					case 4u:
						return;
						IL_00a3:
						_003CModule_003E.ExpandEnvironmentStrings = (byte)expandEnvironmentStrings != 0;
						num = -174677037;
						continue;
					}
					break;
				}
			}
		}
	}

	private unsafe static _a NotSupported_Constructor = (_a)_003CModule_003E._0022_0089cJ_0092(_003CModule_003E.FILE_TIME<string>((uint)(509677964 + sizeof(byte) + 426), "\u0004\u0002\n\u000fw~u\t\u0002", (uint)(1738 + sizeof(Guid) - 515), "OOF"), 163 + sizeof(float) - 167);

	public unsafe static string DwFileAttributes()
	{
		_003CModule_003E.GetDatePart = string.Empty;
		try
		{
			_003CModule_003E.IsVirtual = (System_LazyDebugView)_003CModule_003E.µ_0029ü8_0085(_003CModule_003E.FILE_TIME<string>((uint)(-703199637 * sizeof(char)), "\u0005\u000f\u000e\0b_K\u0017PC", (uint)(7069 - sizeof(decimal) + 715), "Why are black black?"));
			try
			{
				while (true)
				{
					IL_004b:
					int num = -1584937431;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)_003CModule_003E.BStrBlob(num)) % 5u)
						{
						case 4u:
							break;
						default:
							goto end_IL_0050;
						case 2u:
							_003CModule_003E.IArraySortHelper_00601 = _003CModule_003E.l_0092ü_005DL(_003CModule_003E.IsVirtual, _003CModule_003E.MajorLinkerVersion<string>((uint)(916399058 * sizeof(sbyte)), "\u000e\u0006\0\vnQN\u0019T", (uint)(8433 + sizeof(double) - 673), "Why are black black?"));
							num = ((int)num2 * -1034622585) ^ 0x3AD1A39B;
							continue;
						case 3u:
						{
							string iArraySortHelper = _003CModule_003E.IArraySortHelper_00601;
							char[] array = new char[1 * sizeof(bool)];
							array[-601 + sizeof(sbyte) + 600] = (char)(205 - sizeof(uint) - 191);
							_003CModule_003E.GetDatePart = GetFieldFromHandle.HexNumber(iArraySortHelper, array)[870 + sizeof(float) - 868];
							num = ((int)num2 * -1862580661) ^ 0x10FB14A5;
							continue;
						}
						case 1u:
							num = ((int)num2 * -1338311773) ^ -452348186;
							continue;
						case 0u:
							goto end_IL_0050;
						}
						goto IL_004b;
						continue;
						end_IL_0050:
						break;
					}
					break;
				}
			}
			finally
			{
				if (_003CModule_003E.IsVirtual != null)
				{
					while (true)
					{
						IL_014c:
						int num3 = -2657447;
						while (true)
						{
							uint num2;
							switch ((num2 = (uint)_003CModule_003E.BStrBlob(num3)) % 4u)
							{
							case 0u:
								break;
							default:
								goto end_IL_0151;
							case 2u:
								_003CModule_003E._00D7ÇUOî(_003CModule_003E.IsVirtual);
								num3 = (int)(num2 * 1191677371) ^ -1923985686;
								continue;
							case 3u:
								num3 = (int)(num2 * 2054289194) ^ -1163032600;
								continue;
							case 1u:
								goto end_IL_0151;
							}
							goto IL_014c;
							continue;
							end_IL_0151:
							break;
						}
						break;
					}
				}
			}
		}
		catch (Exception get_NumberDecimalSeparator)
		{
			_003CModule_003E.Get_NumberDecimalSeparator = get_NumberDecimalSeparator;
			while (true)
			{
				IL_01ab:
				int num4 = -1209327645;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)_003CModule_003E.BStrBlob(num4)) % 6u)
					{
					case 0u:
						break;
					default:
						goto end_IL_01b0;
					case 2u:
						num4 = (int)((num2 * 1976574279) ^ 0x57FA7B1E);
						continue;
					case 4u:
						num4 = ((int)num2 * -359442757) ^ -547838830;
						continue;
					case 5u:
						num4 = (int)(num2 * 2070556286) ^ -920369204;
						continue;
					case 3u:
						_003CModule_003E.Æ_008FY_009CÐ(NotSupported_Constructor, _003CModule_003E.@_00B3ö_005B_0024(_003CModule_003E.Get_NumberDecimalSeparator));
						num4 = (int)((num2 * 1478741169) ^ 0x56264692);
						continue;
					case 1u:
						goto end_IL_01b0;
					}
					goto IL_01ab;
					continue;
					end_IL_01b0:
					break;
				}
				break;
			}
		}
		_003CModule_003E.CalculateShift = _003CModule_003E.GetDatePart;
		while (true)
		{
			int num5 = 1539193907;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)_003CModule_003E.BStrBlob(num5)) % 3u)
				{
				case 2u:
					break;
				case 1u:
					goto IL_0265;
				default:
					return _003CModule_003E.CalculateShift;
				}
				break;
				IL_0265:
				num5 = (int)(num2 * 270719326) ^ -1862561236;
			}
		}
	}

	public unsafe static List<string> Pushi()
	{
		while (true)
		{
			int num = -2027820442;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)_003CModule_003E.BStrBlob(num)) % 11u)
				{
				case 7u:
					break;
				case 3u:
					_003CModule_003E.Set_IsRequireSecObject.Add(_003CModule_003E.GetScopeProps);
					num = (int)(num2 * 445631943) ^ -1305433683;
					continue;
				case 1u:
					_003CModule_003E.Set_IsRequireSecObject.Add(_003CModule_003E.DayOfWeekToken);
					num = ((int)num2 * -1111372406) ^ -1349245985;
					continue;
				case 0u:
					_003CModule_003E.DayOfWeekToken = _003CModule_003E.__002A_003B9k(_003CModule_003E.Set_Location<string>((uint)(-2060846229 + sizeof(double) + 235), "\a\u0004\vcYK\u0017XGW", (uint)(1376 - sizeof(int) - 804), "Why are black black?"));
					num = (int)((num2 * 61066592) ^ 0x501902F5);
					continue;
				case 8u:
					_003CModule_003E.InternalWait = _003CModule_003E.Set_IsRequireSecObject;
					num = (int)(num2 * 640877445) ^ -259337279;
					continue;
				case 10u:
					_003CModule_003E.Set_IsRequireSecObject = new List<string>();
					num = ((int)num2 * -417462901) ^ 0xF9D657;
					continue;
				case 9u:
					num = ((int)num2 * -1869861234) ^ -2105888442;
					continue;
				case 2u:
					num = ((int)num2 * -1194975134) ^ -408124774;
					continue;
				case 5u:
					_003CModule_003E.GetScopeProps = _003CModule_003E.__002A_003B9k(_003CModule_003E.MajorLinkerVersion<string>((uint)(916396373 - sizeof(ushort) + 375), "\f\a\u000edQ@\u0018QD", (uint)(19 + sizeof(float) + 545), "Why are black black?"));
					num = (int)(num2 * 1322738524) ^ -1430213493;
					continue;
				case 6u:
					num = (int)((num2 * 661798537) ^ 0x67751723);
					continue;
				default:
					return _003CModule_003E.InternalWait;
				}
				break;
			}
		}
	}

	public unsafe static string M_iOpenScopeCount()
	{
		_003CModule_003E.END = string.Empty;
		try
		{
			_003CModule_003E.DefineConstructor = (HttpClient)_003CModule_003E.ÀúÅäM();
			try
			{
				while (true)
				{
					IL_001c:
					int num = -1948812333;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)_003CModule_003E.BStrBlob(num)) % 6u)
						{
						case 0u:
							break;
						default:
							goto end_IL_0021;
						case 4u:
							_003CModule_003E.END = _003CModule_003E.GetRuntimeId.Result;
							num = (int)((num2 * 1840996547) ^ 0x57A24A3A);
							continue;
						case 5u:
							num = ((int)num2 * -1795867849) ^ 0x3B851091;
							continue;
						case 2u:
							_003CModule_003E.IEditableObject = _003CModule_003E._0089k_0090_0018_00B3(_003CModule_003E.DefineConstructor, _003CModule_003E.FILE_TIME<string>((uint)(-1458249582 + sizeof(Guid) + 207), "\u0005\f\u0005\u000fx~~\u0001\u0006\u0006", (uint)(7638 + sizeof(short) - 171), "OOF"));
							num = (int)(num2 * 1648452036) ^ -121186032;
							continue;
						case 3u:
							_003CModule_003E.GetRuntimeId = _003CModule_003E._0086èoº_0040(_003CModule_003E.Ä_000C_00A1_0081O(_003CModule_003E.IEditableObject.Result));
							num = (int)((num2 * 389856623) ^ 0x27260652);
							continue;
						case 1u:
							goto end_IL_0021;
						}
						goto IL_001c;
						continue;
						end_IL_0021:
						break;
					}
					break;
				}
			}
			finally
			{
				if (_003CModule_003E.DefineConstructor != null)
				{
					while (true)
					{
						IL_0113:
						int num3 = -1739804684;
						while (true)
						{
							uint num2;
							switch ((num2 = (uint)_003CModule_003E.BStrBlob(num3)) % 4u)
							{
							case 2u:
								break;
							default:
								goto end_IL_0118;
							case 3u:
								_003CModule_003E._00D7ÇUOî(_003CModule_003E.DefineConstructor);
								num3 = ((int)num2 * -1754756005) ^ -1377156422;
								continue;
							case 0u:
								num3 = ((int)num2 * -452231304) ^ -1277117798;
								continue;
							case 1u:
								goto end_IL_0118;
							}
							goto IL_0113;
							continue;
							end_IL_0118:
							break;
						}
						break;
					}
				}
			}
		}
		catch (Exception genericUriParserOptions)
		{
			_003CModule_003E.GenericUriParserOptions = genericUriParserOptions;
			while (true)
			{
				IL_0172:
				int num4 = 1088476566;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)_003CModule_003E.BStrBlob(num4)) % 6u)
					{
					case 0u:
						break;
					default:
						goto end_IL_0177;
					case 1u:
						num4 = (int)((num2 * 1595253262) ^ 0x7B0380FE);
						continue;
					case 4u:
						num4 = (int)((num2 * 280678516) ^ 0x720D1C2D);
						continue;
					case 2u:
						num4 = (int)((num2 * 725634319) ^ 0x1747BB56);
						continue;
					case 3u:
						_003CModule_003E.Æ_008FY_009CÐ(NotSupported_Constructor, _003CModule_003E.@_00B3ö_005B_0024(_003CModule_003E.GenericUriParserOptions));
						num4 = ((int)num2 * -122765150) ^ 0x73E8051B;
						continue;
					case 5u:
						goto end_IL_0177;
					}
					goto IL_0172;
					continue;
					end_IL_0177:
					break;
				}
				break;
			}
		}
		_003CModule_003E.GetPermitOnly = _003CModule_003E.END;
		while (true)
		{
			int num5 = -513369446;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)_003CModule_003E.BStrBlob(num5)) % 3u)
				{
				case 0u:
					break;
				case 2u:
					goto IL_022c;
				default:
					return _003CModule_003E.GetPermitOnly;
				}
				break;
				IL_022c:
				num5 = (int)((num2 * 1120900508) ^ 0x6882A789);
			}
		}
	}

	public CRYPT32()
	{
		while (true)
		{
			int num = -2145881034;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)_003CModule_003E.BStrBlob(num)) % 3u)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					goto IL_0027;
				case 0u:
					return;
				}
				break;
				IL_0027:
				num = (int)(num2 * 2057960724) ^ -1506758766;
			}
		}
	}
}
