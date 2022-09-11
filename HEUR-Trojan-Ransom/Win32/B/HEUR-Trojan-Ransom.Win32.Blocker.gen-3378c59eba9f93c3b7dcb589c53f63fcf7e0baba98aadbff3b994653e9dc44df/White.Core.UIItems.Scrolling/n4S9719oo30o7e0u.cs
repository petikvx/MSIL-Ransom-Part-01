using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace White.Core.UIItems.Scrolling;

internal class n4S9719oo30o7e0u
{
	private static readonly object FQt21lNZ2IQGi5rq1;

	private static readonly object Y62n6XV0HN8gz8k;

	private static int C79EQguDZ7Mx3r;

	private static readonly Dictionary<Guid, Match> E1b3lxZiH6aAmi;

	private static readonly Dictionary<Guid, Assembly> RuUev11U6hBD90vt;

	public static object object_0;

	public static object un9fRVF3ZFmhFWKUZR;

	public static object MSeArrDW2DogV;

	public static object IWxd4J9NXGfOsJLRQ;

	public static object ctxepNsXn8n0;

	public static object object_1;

	public static object kKW7dB6EGKVh5BA76Gx;

	public static object ML4aw37ykSrPYtYCdN5;

	public static object object_2;

	public static object jei3Y2fslM84tl8d;

	static n4S9719oo30o7e0u()
	{
		pCpSLJmtK76hgnWFC3();
		if (WQXYtPZCqGrvyVEv87())
		{
			while (true)
			{
				FQt21lNZ2IQGi5rq1 = new Regex((string)ea4GOGFPJegsQrKWYP("61736d7a3a2f2f283f3c677569643e5b302d39612d66412d465d7b33327d292f283f3c73697a653e5b302d395d2b29282f283f3c666c6167733e5b612d7a412d5a302d395d2a29293f"), RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture);
				if (!pCpSLJmtK76hgnWFC3())
				{
					switch (1)
					{
					case 0:
					case 5:
						break;
					case 1:
						goto IL_0052;
					case 4:
						goto IL_0066;
					default:
						goto end_IL_000d;
					case 6:
						return;
					}
					continue;
				}
				goto IL_0052;
				IL_0066:
				E1b3lxZiH6aAmi = new Dictionary<Guid, Match>();
				break;
				IL_0052:
				Y62n6XV0HN8gz8k = Tw19IHXvOf45Ff0mCK(typeof(n4S9719oo30o7e0u).TypeHandle).Assembly;
				goto IL_0066;
				continue;
				end_IL_000d:
				break;
			}
		}
		RuUev11U6hBD90vt = new Dictionary<Guid, Assembly>();
	}

	public static void smethod_0()
	{
		WQXYtPZCqGrvyVEv87();
		if (!pCpSLJmtK76hgnWFC3())
		{
			goto IL_00bd;
		}
		goto IL_0137;
		IL_0137:
		bool flag = default(bool);
		Guid key = default(Guid);
		Match match = default(Match);
		bool flag2 = default(bool);
		int num2 = default(int);
		while (true)
		{
			if (!flag)
			{
				key = new Guid((string)wPYcORMgLB0cKy9EoG(CCpm27EtIAZSK2cI6D(vsxkiXYiksUOxiTC7M(match), "guid")));
				goto IL_00a0;
			}
			int num = 5;
			if (WQXYtPZCqGrvyVEv87())
			{
				goto IL_0046;
			}
			goto IL_00e9;
			IL_00c9:
			if (!flag2)
			{
				E1b3lxZiH6aAmi[key] = match;
			}
			goto IL_00e9;
			IL_00e9:
			num2++;
			goto IL_010f;
			IL_00a0:
			flag2 = E1b3lxZiH6aAmi.ContainsKey(key);
			num = 11;
			if (!pCpSLJmtK76hgnWFC3())
			{
				goto IL_0046;
			}
			goto IL_00c9;
			IL_0046:
			switch (num)
			{
			case 4:
				break;
			case 0:
			case 3:
				goto end_IL_0137;
			case 11:
				goto IL_00c9;
			case 16:
				goto IL_00dd;
			case 5:
			case 13:
			case 17:
				goto IL_00e9;
			case 18:
				goto IL_00ef;
			case 6:
				goto IL_00ff;
			case 12:
				goto IL_010d;
			case 1:
			case 2:
				goto IL_010f;
			case 10:
				goto IL_0119;
			case 14:
				goto IL_0126;
			default:
				continue;
			case 15:
				goto IL_0143;
			case 7:
			case 19:
				return;
			}
			goto IL_00a0;
			continue;
			end_IL_0137:
			break;
		}
		goto IL_00bd;
		IL_0143:
		nURS4IuUKsxVVmDsMP();
		return;
		IL_0126:
		flag = !i7ou7VAsimqtNdCGD1(match);
		goto IL_0137;
		IL_0119:
		string object_ = default(string);
		match = (Match)VMTZnrINQf0bnmUMoS(FQt21lNZ2IQGi5rq1, object_);
		goto IL_0126;
		IL_00ff:
		bool flag3 = default(bool);
		string[] array = default(string[]);
		if (!flag3)
		{
			array = (string[])s4gOSlyX8wtM6vCBjJ(Y62n6XV0HN8gz8k);
			goto IL_010d;
		}
		return;
		IL_010f:
		if (num2 < array.Length)
		{
			object_ = array[num2];
			goto IL_0119;
		}
		goto IL_0143;
		IL_010d:
		num2 = 0;
		goto IL_010f;
		IL_00ef:
		flag3 = Interlocked.CompareExchange(ref C79EQguDZ7Mx3r, 1, 0) != 0;
		goto IL_00ff;
		IL_00bd:
		smethod_9(out System.Runtime.CompilerServices.Unsafe.As<object, string>(ref object_2));
		goto IL_00dd;
		IL_00dd:
		smethod_10(out System.Runtime.CompilerServices.Unsafe.As<object, string>(ref jei3Y2fslM84tl8d));
		goto IL_00ef;
	}

	public static Match NPd2LEND9HiTv(object object_3)
	{
		return (Match)VMTZnrINQf0bnmUMoS(FQt21lNZ2IQGi5rq1, object_3);
	}

	public static bool smethod_1(Guid f911X1czJDg7A1NYF)
	{
		return !E1b3lxZiH6aAmi.ContainsKey(f911X1czJDg7A1NYF);
	}

	public static string[] ZAxlQ0lHo3RH8lj0I()
	{
		return (string[])s4gOSlyX8wtM6vCBjJ(Y62n6XV0HN8gz8k);
	}

	public static void XCc2rIKJwtlX810()
	{
		rPKIAppbslUWGhfAv3(nAFgXpNIcgIFpla0Fc(), new ResolveEventHandler(v0Wt9BP3L5xTwNs));
	}

	public static AppDomain smethod_2()
	{
		return (AppDomain)tZMAXR8CXNo661Gwuw();
	}

	public static Guid O6sPAhe160(object zQBoz5ORxxXPIaIE16b)
	{
		return new Guid((string)zQBoz5ORxxXPIaIE16b);
	}

	private static Assembly v0Wt9BP3L5xTwNs(object DQ8oD5NQ0RKP2, object M54VJ83sPXpvf19)
	{
		Assembly assembly = default(Assembly);
		string object_2 = default(string);
		bool flag2 = default(bool);
		object obj = default(object);
		bool flag = default(bool);
		string text5 = default(string);
		Assembly result = default(Assembly);
		while (true)
		{
			string text = (string)rvCJfvvtJmoqr5xi1Z("a", 3.ToString());
			while (true)
			{
				int num = 63;
				while (true)
				{
					string text2 = num.ToString();
					while (true)
					{
						num = 83;
						while (true)
						{
							string text3 = num.ToString();
							while (true)
							{
								num = 87;
								_ = 0;
								if (WQXYtPZCqGrvyVEv87())
								{
									while (true)
									{
										IL_0136:
										string text4 = num.ToString();
										while (true)
										{
											IL_00f6:
											string object_ = (string)ea4GOGFPJegsQrKWYP(yOF1oAV9HCuZTpyFhZ(AYed3lLZivba6iuaXv("{0}{1}{2}{3}", new object[4] { text, text2, text3, text4 })));
											int num2 = 4;
											if (!pCpSLJmtK76hgnWFC3())
											{
											}
											while (true)
											{
												switch (num2)
												{
												case 1:
													break;
												case 18:
													assembly = (Assembly)SOFs1GSvJMP9kYI1Nr(object_2);
													goto case 15;
												case 15:
													flag2 = assembly == obj;
													goto case 10;
												case 10:
													if (flag2)
													{
														num2 = 21;
														if (WQXYtPZCqGrvyVEv87())
														{
															continue;
														}
														goto end_IL_0140;
													}
													goto IL_0187;
												case 17:
													flag = assembly == obj;
													num2 = 2;
													if (pCpSLJmtK76hgnWFC3())
													{
													}
													continue;
												case 12:
													object_2 = (string)MshoX3RgRTNEMjO3XK(M54VJ83sPXpvf19);
													goto case 18;
												case 11:
													object_2 = text5;
													goto case 0;
												case 0:
													assembly = (Assembly)SOFs1GSvJMP9kYI1Nr(object_2);
													goto default;
												default:
													obj = null;
													goto case 17;
												case 4:
													text5 = (string)rvCJfvvtJmoqr5xi1Z(object_, MshoX3RgRTNEMjO3XK(M54VJ83sPXpvf19));
													goto case 11;
												case 2:
													if (flag)
													{
														goto case 12;
													}
													goto IL_0187;
												case 9:
													goto IL_00f6;
												case 6:
												case 7:
													goto IL_0136;
												case 13:
													goto end_IL_0006;
												case 16:
													goto end_IL_0140;
												case 20:
													goto end_IL_014e;
												case 5:
													goto end_IL_0154;
												case 3:
													goto end_IL_015e;
												case 21:
													assembly = (Assembly)SOFs1GSvJMP9kYI1Nr(text5);
													goto IL_0187;
												case 14:
												case 19:
													goto IL_0187;
												case 22:
													return result;
												}
												break;
											}
											break;
										}
										break;
									}
									continue;
								}
								goto IL_0187;
								IL_0187:
								return assembly;
								continue;
								end_IL_0006:
								break;
							}
							continue;
							end_IL_0140:
							break;
						}
						continue;
						end_IL_014e:
						break;
					}
					continue;
					end_IL_0154:
					break;
				}
				continue;
				end_IL_015e:
				break;
			}
		}
	}

	public static Assembly smethod_3(object g2R1aAiT2yAet1va)
	{
		return (Assembly)upIwBr4l9OZn5Nqe07(g2R1aAiT2yAet1va);
	}

	public static string smethod_4(object object_3)
	{
		_ = 0;
		char[] array = default(char[]);
		if (WQXYtPZCqGrvyVEv87())
		{
			array = (char[])mkalcLicIejHVKq223(object_3);
		}
		eiIZotqR0O8tx1o3A7(array);
		return new string(array);
	}

	public static string smethod_5(object me4GT4QQu8E6do)
	{
		_ = 1;
		byte[] array = default(byte[]);
		int i = default(int);
		if (!pCpSLJmtK76hgnWFC3())
		{
			array = new byte[TCN4pJngPeLxusyOFJ(me4GT4QQu8E6do) / 2];
			i = 0;
		}
		for (; i < array.Length; i++)
		{
			array[i] = I45aHt37o6yPBxU0ML(FaMRDCD135mo5TWRyV(me4GT4QQu8E6do, i * 2, 2), 16);
		}
		return (string)GOCuS3C1J0Osk8nGHi(fqDFSZKs6hWr9DJIdG(), array);
	}

	public static string smethod_6(int DTkZ0yn9lF90)
	{
		string result;
		string result2 = default(string);
		while (true)
		{
			result = "";
			_ = 1;
			if (pCpSLJmtK76hgnWFC3())
			{
				break;
			}
			while (true)
			{
				IL_017b:
				while (true)
				{
					IL_0177:
					int num = DTkZ0yn9lF90;
					while (true)
					{
						IL_0167:
						int num2;
						if (num > 846)
						{
							if (num <= 305144)
							{
								goto IL_01e8;
							}
							if (num != 22222226)
							{
								goto IL_015a;
							}
							num2 = 61;
							goto IL_025d;
						}
						goto IL_006b;
						IL_01fd:
						result = (string)ea4GOGFPJegsQrKWYP(num2.ToString());
						goto end_IL_0001;
						IL_0230:
						result = (string)ea4GOGFPJegsQrKWYP(num2.ToString());
						goto end_IL_0001;
						IL_015a:
						int num3;
						if (num == 98236984)
						{
							num2 = 7;
							num3 = 8;
							if (!WQXYtPZCqGrvyVEv87())
							{
								goto IL_0083;
							}
							goto IL_00b0;
						}
						goto IL_0185;
						IL_0241:
						result = (string)ea4GOGFPJegsQrKWYP(rvCJfvvtJmoqr5xi1Z(num2.ToString(), "c"));
						goto end_IL_0001;
						IL_00b0:
						while (true)
						{
							switch (num3)
							{
							case 37:
								break;
							case 21:
								goto IL_0051;
							case 26:
								goto IL_006b;
							case 11:
								goto IL_0073;
							case 12:
								goto IL_0083;
							default:
								num3 = 27;
								if (WQXYtPZCqGrvyVEv87())
								{
									continue;
								}
								goto IL_0241;
							case 15:
								goto IL_015a;
							case 28:
								goto IL_0167;
							case 29:
								goto IL_0177;
							case 1:
							case 6:
								goto IL_017b;
							case 4:
								goto IL_0185;
							case 0:
								goto IL_0195;
							case 2:
								goto IL_01a7;
							case 8:
								goto IL_01ba;
							case 27:
								goto IL_01d6;
							case 33:
								goto IL_01e8;
							case 22:
								goto IL_01f0;
							case 13:
								goto IL_01fd;
							case 23:
								goto IL_020f;
							case 36:
								goto IL_021e;
							case 16:
								goto IL_0223;
							case 20:
								goto IL_0230;
							case 19:
								goto IL_0241;
							case 9:
								goto IL_025d;
							case 3:
							case 5:
							case 7:
							case 10:
							case 14:
							case 17:
							case 18:
							case 24:
							case 25:
							case 30:
							case 31:
							case 32:
							case 34:
							case 35:
							case 38:
								goto end_IL_0001;
							case 39:
								return result2;
							}
							break;
						}
						break;
						IL_0185:
						if (num != 484651651)
						{
							goto end_IL_0001;
						}
						num2 = 64;
						goto IL_0195;
						IL_025d:
						result = (string)ea4GOGFPJegsQrKWYP(num2.ToString());
						goto end_IL_0001;
						IL_0195:
						result = (string)ea4GOGFPJegsQrKWYP(num2.ToString());
						goto end_IL_0001;
						IL_0051:
						result = (string)ea4GOGFPJegsQrKWYP(num2.ToString());
						num3 = 24;
						if (!WQXYtPZCqGrvyVEv87())
						{
							goto IL_006b;
						}
						goto IL_00b0;
						IL_006b:
						if (num <= -5924)
						{
							goto IL_0073;
						}
						if (num != -94)
						{
							goto IL_021e;
						}
						num2 = 73;
						goto IL_0051;
						IL_0073:
						if (num != -7590)
						{
							goto IL_01a7;
						}
						num2 = 69;
						goto IL_0083;
						IL_01a7:
						if (num != -5924)
						{
							goto end_IL_0001;
						}
						num2 = 67;
						goto IL_01d6;
						IL_01f0:
						if (num != 305144)
						{
							goto end_IL_0001;
						}
						num2 = 65;
						goto IL_01fd;
						IL_01d6:
						result = (string)ea4GOGFPJegsQrKWYP(num2.ToString());
						goto end_IL_0001;
						IL_01e8:
						if (num != 258644)
						{
							goto IL_01f0;
						}
						num2 = 75;
						goto IL_020f;
						IL_0083:
						result = (string)ea4GOGFPJegsQrKWYP(num2.ToString());
						num3 = 18;
						if (!pCpSLJmtK76hgnWFC3())
						{
							goto IL_00b0;
						}
						goto IL_01ba;
						IL_01ba:
						result = (string)ea4GOGFPJegsQrKWYP(rvCJfvvtJmoqr5xi1Z(num2.ToString(), "a"));
						goto end_IL_0001;
						IL_020f:
						result = (string)ea4GOGFPJegsQrKWYP(num2.ToString());
						goto end_IL_0001;
						IL_021e:
						if (num != 46)
						{
							goto IL_0223;
						}
						num2 = 6;
						goto IL_0241;
						IL_0223:
						if (num != 846)
						{
							goto end_IL_0001;
						}
						num2 = 66;
						goto IL_0230;
					}
					break;
				}
				break;
			}
			continue;
			end_IL_0001:
			break;
		}
		return result;
	}

	private static void HIcugnsA6xFt(out string string_0)
	{
		string_0 = (string)kNxPNJgr4j4CotIJIs(846);
	}

	private static void smethod_7(out string EGH42c6E4rehn1)
	{
		EGH42c6E4rehn1 = (string)kNxPNJgr4j4CotIJIs(-5924);
	}

	private static void dYw4LfG8nLSp7Y04(out string string_0)
	{
		string_0 = (string)kNxPNJgr4j4CotIJIs(46);
	}

	private static void zej01x507H4sj(out string string_0)
	{
		string_0 = (string)kNxPNJgr4j4CotIJIs(98236984);
	}

	private static void smethod_8(out string an3qz7BQ06jd4A)
	{
		an3qz7BQ06jd4A = (string)kNxPNJgr4j4CotIJIs(-94);
	}

	private static void H6i96MQrP7FbEtArGnp(out string p0k73apWEuW9nb6l)
	{
		p0k73apWEuW9nb6l = (string)kNxPNJgr4j4CotIJIs(-7590);
	}

	private static void ILSt6nsU576zoD0o2S(out string WKG574M5lgYC)
	{
		WKG574M5lgYC = (string)kNxPNJgr4j4CotIJIs(305144);
	}

	private static void z28B7ysm1N7dS6zR6u(out string spzobquytShO)
	{
		spzobquytShO = (string)kNxPNJgr4j4CotIJIs(22222226);
	}

	private static void smethod_9(out string i2O7wNpVDuI9n6vm994)
	{
		i2O7wNpVDuI9n6vm994 = (string)kNxPNJgr4j4CotIJIs(258644);
	}

	private static void smethod_10(out string string_0)
	{
		string_0 = (string)kNxPNJgr4j4CotIJIs(484651651);
	}

	private static Assembly DbTAHsWB6E6d8Gibz(object gV8k54FF8msCvtkecZn)
	{
		try
		{
			if (!E1b3lxZiH6aAmi.TryGetValue(fpJZJ39FTu8DUEaIQt(gV8k54FF8msCvtkecZn), out var value))
			{
				return null;
			}
			if (RuUev11U6hBD90vt.TryGetValue(fpJZJ39FTu8DUEaIQt(gV8k54FF8msCvtkecZn), out var value2))
			{
				return value2;
			}
			gV8k54FF8msCvtkecZn = wPYcORMgLB0cKy9EoG(LyKW5sTZYBW6wwfD7h(vsxkiXYiksUOxiTC7M(value), 0));
			HIcugnsA6xFt(out System.Runtime.CompilerServices.Unsafe.As<object, string>(ref object_0));
			smethod_7(out System.Runtime.CompilerServices.Unsafe.As<object, string>(ref un9fRVF3ZFmhFWKUZR));
			dYw4LfG8nLSp7Y04(out System.Runtime.CompilerServices.Unsafe.As<object, string>(ref MSeArrDW2DogV));
			zej01x507H4sj(out System.Runtime.CompilerServices.Unsafe.As<object, string>(ref IWxd4J9NXGfOsJLRQ));
			smethod_8(out System.Runtime.CompilerServices.Unsafe.As<object, string>(ref ctxepNsXn8n0));
			H6i96MQrP7FbEtArGnp(out System.Runtime.CompilerServices.Unsafe.As<object, string>(ref object_1));
			ILSt6nsU576zoD0o2S(out System.Runtime.CompilerServices.Unsafe.As<object, string>(ref kKW7dB6EGKVh5BA76Gx));
			z28B7ysm1N7dS6zR6u(out System.Runtime.CompilerServices.Unsafe.As<object, string>(ref ML4aw37ykSrPYtYCdN5));
			cb4xbeQadkYkNWqpCY(oJu9vHaOM4Shk7erYE(value), IWxd4J9NXGfOsJLRQ);
			byte[] object_ = (byte[])T3l7ZWWc6QdMwqxpJ2(gV8k54FF8msCvtkecZn, VQNmL1whW4EnbvI180(value));
			Assembly assembly = (Assembly)ugVE21dvvgyCuaR4Nb(object_);
			Dictionary<Guid, Assembly> ruUev11U6hBD90vt = RuUev11U6hBD90vt;
			bool lockTaken = false;
			try
			{
				Monitor.Enter(ruUev11U6hBD90vt, ref lockTaken);
				bool flag2 = default(bool);
				Assembly result = default(Assembly);
				while (true)
				{
					IL_0174:
					Assembly value3;
					bool flag = RuUev11U6hBD90vt.TryGetValue(fpJZJ39FTu8DUEaIQt(gV8k54FF8msCvtkecZn), out value3);
					while (true)
					{
						IL_016b:
						if (!flag)
						{
							flag2 = FXm1EcxHReUo5qqyyQ(assembly, null);
							goto IL_0157;
						}
						int num = 6;
						if (pCpSLJmtK76hgnWFC3())
						{
							return result;
						}
						goto IL_0118;
						IL_0157:
						if (flag2)
						{
							num = 7;
							if (!WQXYtPZCqGrvyVEv87())
							{
								break;
							}
							goto IL_0118;
						}
						break;
						IL_0118:
						while (true)
						{
							switch (num)
							{
							case 7:
								RuUev11U6hBD90vt[fpJZJ39FTu8DUEaIQt(gV8k54FF8msCvtkecZn)] = assembly;
								num = 8;
								if (WQXYtPZCqGrvyVEv87())
								{
									continue;
								}
								break;
							case 6:
								result = value3;
								goto default;
							default:
								WQXYtPZCqGrvyVEv87();
								if (pCpSLJmtK76hgnWFC3())
								{
									break;
								}
								return result;
							case 4:
							case 5:
								break;
							case 0:
								goto IL_016b;
							case 2:
								goto IL_0174;
							case 8:
								goto end_IL_016b;
							case 1:
							case 3:
								return result;
							}
							break;
						}
						goto IL_0157;
						continue;
						end_IL_016b:
						break;
					}
					break;
				}
			}
			finally
			{
				if (lockTaken)
				{
					u8ZwyU2NDxhIyRhTdF(ruUev11U6hBD90vt);
				}
			}
			return assembly;
		}
		catch
		{
			return null;
		}
	}

	public static int tKSJD6MDE858up1(object u2GY5ctJt3sM33DtYVJ)
	{
		return Uxw64u5tTi6BiSEEnW(wPYcORMgLB0cKy9EoG(CCpm27EtIAZSK2cI6D(vsxkiXYiksUOxiTC7M(u2GY5ctJt3sM33DtYVJ), CKVVlptOP111bS2v8i(ctxepNsXn8n0, object_1, IWxd4J9NXGfOsJLRQ, kKW7dB6EGKVh5BA76Gx))));
	}

	public static string dZH9sbb9RTsg1n(object JtzIr0jzJn9Kk5mK8)
	{
		return (string)keyo0F7N6nIPKSFcrc(JtzIr0jzJn9Kk5mK8, cvBm2rfjVbbSdK6VqW(new string[5]
		{
			(string)object_0,
			(string)MSeArrDW2DogV,
			(string)ML4aw37ykSrPYtYCdN5,
			(string)un9fRVF3ZFmhFWKUZR,
			(string)ctxepNsXn8n0
		}));
	}

	public static Assembly smethod_11(object object_3)
	{
		return (Assembly)pkmJAjj2kdxjXdcLMN(object_3);
	}

	public static string smethod_12(object mmvn095XVwCkPw1, object M05uexO8l8MJaUF6zc)
	{
		return (string)wPYcORMgLB0cKy9EoG(CCpm27EtIAZSK2cI6D(vsxkiXYiksUOxiTC7M(mmvn095XVwCkPw1), M05uexO8l8MJaUF6zc));
	}

	public static byte[] smethod_13(object gyx9p6Z8Xc2xvW, int QgUM4440Wl)
	{
		WQXYtPZCqGrvyVEv87();
		byte[] array = default(byte[]);
		if (!pCpSLJmtK76hgnWFC3())
		{
			array = new byte[QgUM4440Wl];
		}
		Stream stream = (Stream)RsJwi7bYOZ353n7XVD(Y62n6XV0HN8gz8k, gyx9p6Z8Xc2xvW);
		try
		{
			if (stream != null)
			{
				Stream stream2 = new DeflateStream(stream, CompressionMode.Decompress);
				try
				{
					dAqjTBcaFXnNQ75qVF(stream2, array, 0, QgUM4440Wl);
					return array;
				}
				finally
				{
					if (stream2 != null)
					{
						C0baeRzCpAkRmoxToV(stream2);
					}
				}
			}
			return null;
		}
		finally
		{
			if (stream != null)
			{
				C0baeRzCpAkRmoxToV(stream);
			}
		}
	}

	private static Guid d6qwgHRk35s7jFC8Ku(object object_3)
	{
		byte[] b = (byte[])IiNGxSPPJsXCAtXysSK(GDGitGPJtO4L82ZtLkt(object_3));
		return new Guid(b);
	}

	private static byte[] Axz32rA6UFl2F7jLg16(object gKoSYG9rV3Rfr7RJU)
	{
		return (byte[])sPtRmwPOH7VPWbGysK3(TgVtjPP0lLbM8F3turs(), eaU7PAPsR78Gk8xNJVc(gKoSYG9rV3Rfr7RJU));
	}

	private unsafe static byte[] kqjy117vtt5(object HJh120iGFWStk0Yf)
	{
		iQ904rPKSsXUCwpv(HJh120iGFWStk0Yf, out *(byte[]*)(&HJh120iGFWStk0Yf));
		return (byte[])HJh120iGFWStk0Yf;
	}

	private static void iQ904rPKSsXUCwpv(object vh80F0BnGx8, out byte[] nBD2KlC6TN11rjIvVd)
	{
		nBD2KlC6TN11rjIvVd = (byte[])KfRAvoPhUQNgv0sYoO1(iAjsPvP6uB47yts1Ngk(), vh80F0BnGx8);
	}

	public n4S9719oo30o7e0u()
	{
		ysSoslPH3R57qYExMBI(this);
	}

	internal static object ea4GOGFPJegsQrKWYP(object object_3)
	{
		return smethod_5(object_3);
	}

	internal static Type Tw19IHXvOf45Ff0mCK(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static bool WQXYtPZCqGrvyVEv87()
	{
		return true;
	}

	internal static bool pCpSLJmtK76hgnWFC3()
	{
		return false;
	}

	internal static object s4gOSlyX8wtM6vCBjJ(object object_3)
	{
		return ((Assembly)object_3).GetManifestResourceNames();
	}

	internal static object VMTZnrINQf0bnmUMoS(object object_3, object object_4)
	{
		return ((Regex)object_3).Match((string)object_4);
	}

	internal static bool i7ou7VAsimqtNdCGD1(object object_3)
	{
		return ((Group)object_3).Success;
	}

	internal static object vsxkiXYiksUOxiTC7M(object object_3)
	{
		return ((Match)object_3).Groups;
	}

	internal static object CCpm27EtIAZSK2cI6D(object object_3, object object_4)
	{
		return ((GroupCollection)object_3)[(string)object_4];
	}

	internal static object wPYcORMgLB0cKy9EoG(object object_3)
	{
		return ((Capture)object_3).Value;
	}

	internal static void nURS4IuUKsxVVmDsMP()
	{
		XCc2rIKJwtlX810();
	}

	internal static object nAFgXpNIcgIFpla0Fc()
	{
		return smethod_2();
	}

	internal static void rPKIAppbslUWGhfAv3(object object_3, object object_4)
	{
		((AppDomain)object_3).AssemblyResolve += (ResolveEventHandler?)object_4;
	}

	internal static object tZMAXR8CXNo661Gwuw()
	{
		return AppDomain.CurrentDomain;
	}

	internal static object rvCJfvvtJmoqr5xi1Z(object object_3, object object_4)
	{
		return (string?)object_3 + (string?)object_4;
	}

	internal static object AYed3lLZivba6iuaXv(object object_3, object object_4)
	{
		return string.Format((string)object_3, (object?[])object_4);
	}

	internal static object yOF1oAV9HCuZTpyFhZ(object object_3)
	{
		return smethod_4(object_3);
	}

	internal static object MshoX3RgRTNEMjO3XK(object object_3)
	{
		return ((ResolveEventArgs)object_3).Name;
	}

	internal static object SOFs1GSvJMP9kYI1Nr(object object_3)
	{
		return smethod_3(object_3);
	}

	internal static object upIwBr4l9OZn5Nqe07(object object_3)
	{
		return DbTAHsWB6E6d8Gibz(object_3);
	}

	internal static object mkalcLicIejHVKq223(object object_3)
	{
		return ((string)object_3).ToCharArray();
	}

	internal static void eiIZotqR0O8tx1o3A7(object object_3)
	{
		Array.Reverse((Array)object_3);
	}

	internal static int TCN4pJngPeLxusyOFJ(object object_3)
	{
		return ((string)object_3).Length;
	}

	internal static object FaMRDCD135mo5TWRyV(object object_3, int int_0, int int_1)
	{
		return ((string)object_3).Substring(int_0, int_1);
	}

	internal static byte I45aHt37o6yPBxU0ML(object object_3, int int_0)
	{
		return Convert.ToByte((string?)object_3, int_0);
	}

	internal static object fqDFSZKs6hWr9DJIdG()
	{
		return Encoding.ASCII;
	}

	internal static object GOCuS3C1J0Osk8nGHi(object object_3, object object_4)
	{
		return ((Encoding)object_3).GetString((byte[])object_4);
	}

	internal static object kNxPNJgr4j4CotIJIs(int DTkZ0yn9lF90)
	{
		return smethod_6(DTkZ0yn9lF90);
	}

	internal static Guid fpJZJ39FTu8DUEaIQt(object object_3)
	{
		return d6qwgHRk35s7jFC8Ku(object_3);
	}

	internal static object LyKW5sTZYBW6wwfD7h(object object_3, int int_0)
	{
		return ((GroupCollection)object_3)[int_0];
	}

	internal static object oJu9vHaOM4Shk7erYE(object object_3)
	{
		return dZH9sbb9RTsg1n(object_3);
	}

	internal static bool cb4xbeQadkYkNWqpCY(object object_3, object object_4)
	{
		return ((string)object_3).Contains((string)object_4);
	}

	internal static int VQNmL1whW4EnbvI180(object object_3)
	{
		return tKSJD6MDE858up1(object_3);
	}

	internal static object T3l7ZWWc6QdMwqxpJ2(object object_3, int QgUM4440Wl)
	{
		return smethod_13(object_3, QgUM4440Wl);
	}

	internal static object ugVE21dvvgyCuaR4Nb(object object_3)
	{
		return smethod_11(object_3);
	}

	internal static bool FXm1EcxHReUo5qqyyQ(object object_3, object object_4)
	{
		return (Assembly?)object_3 != (Assembly?)object_4;
	}

	internal static void u8ZwyU2NDxhIyRhTdF(object object_3)
	{
		Monitor.Exit(object_3);
	}

	internal static object CKVVlptOP111bS2v8i(object object_3, object object_4, object object_5, object object_6)
	{
		return (string?)object_3 + (string?)object_4 + (string?)object_5 + (string?)object_6;
	}

	internal static int Uxw64u5tTi6BiSEEnW(object object_3)
	{
		return int.Parse((string)object_3);
	}

	internal static object cvBm2rfjVbbSdK6VqW(object object_3)
	{
		return string.Concat((string?[])object_3);
	}

	internal static object keyo0F7N6nIPKSFcrc(object object_3, object object_4)
	{
		return smethod_12(object_3, object_4);
	}

	internal static object pkmJAjj2kdxjXdcLMN(object object_3)
	{
		return Assembly.Load((byte[])object_3);
	}

	internal static object RsJwi7bYOZ353n7XVD(object object_3, object object_4)
	{
		return ((Assembly)object_3).GetManifestResourceStream((string)object_4);
	}

	internal static int dAqjTBcaFXnNQ75qVF(object object_3, object object_4, int int_0, int int_1)
	{
		return ((Stream)object_3).Read((byte[])object_4, int_0, int_1);
	}

	internal static void C0baeRzCpAkRmoxToV(object object_3)
	{
		((IDisposable)object_3).Dispose();
	}

	internal static object GDGitGPJtO4L82ZtLkt(object object_3)
	{
		return Axz32rA6UFl2F7jLg16(object_3);
	}

	internal static object IiNGxSPPJsXCAtXysSK(object object_3)
	{
		return kqjy117vtt5(object_3);
	}

	internal static object TgVtjPP0lLbM8F3turs()
	{
		return Encoding.UTF8;
	}

	internal static object eaU7PAPsR78Gk8xNJVc(object object_3)
	{
		return ((string)object_3).ToLowerInvariant();
	}

	internal static object sPtRmwPOH7VPWbGysK3(object object_3, object object_4)
	{
		return ((Encoding)object_3).GetBytes((string)object_4);
	}

	internal static object iAjsPvP6uB47yts1Ngk()
	{
		return MD5.Create();
	}

	internal static object KfRAvoPhUQNgv0sYoO1(object object_3, object object_4)
	{
		return ((HashAlgorithm)object_3).ComputeHash((byte[])object_4);
	}

	internal static void ysSoslPH3R57qYExMBI(object object_3)
	{
		object_3._002Ector();
	}
}
