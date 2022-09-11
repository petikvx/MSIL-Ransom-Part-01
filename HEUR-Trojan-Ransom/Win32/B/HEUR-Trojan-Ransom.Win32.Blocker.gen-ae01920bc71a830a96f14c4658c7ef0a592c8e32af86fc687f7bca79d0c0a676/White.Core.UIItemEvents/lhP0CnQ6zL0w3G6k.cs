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

namespace White.Core.UIItemEvents;

internal class lhP0CnQ6zL0w3G6k
{
	private static readonly object dM03JCc1hzn43y5G;

	private static readonly object vw7QId1drJyuv4trr6;

	private static int h71fjOxhYj;

	private static readonly Dictionary<Guid, Match> kZ6Zs53L3c7Qoi9WCL2;

	private static readonly Dictionary<Guid, Assembly> I9012NGW53Ml27;

	public static object object_0;

	public static object RFzBzl9E6EY;

	public static object q9zvyqNA6f6Gprb;

	public static object H9D4awmgW0Ht9UAK7I;

	public static object object_1;

	public static object ikk66b3G3Xs97;

	public static object object_2;

	public static object object_3;

	public static object ueT9gwIObg6;

	public static object B060swu52juMYcofFZ;

	static lhP0CnQ6zL0w3G6k()
	{
		Q1KCgmu4xQEEPalLaA();
		if (upk7HjVwiAjnlFnIl3())
		{
			if (Q1KCgmu4xQEEPalLaA())
			{
			}
			switch (2)
			{
			case 0:
			case 2:
				dM03JCc1hzn43y5G = new Regex((string)wGZ9SnWDtUF5wDuCQ8("61736d7a3a2f2f283f3c677569643e5b302d39612d66412d465d7b33327d292f283f3c73697a653e5b302d395d2b29282f283f3c666c6167733e5b612d7a412d5a302d395d2a29293f"), RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture);
				break;
			case 1:
			case 5:
				break;
			case 3:
				goto IL_0068;
			default:
				goto IL_0072;
			case 6:
				return;
			}
		}
		vw7QId1drJyuv4trr6 = E2ZFLH6wEdspfXRV1c(typeof(lhP0CnQ6zL0w3G6k).TypeHandle).Assembly;
		goto IL_0068;
		IL_0072:
		I9012NGW53Ml27 = new Dictionary<Guid, Assembly>();
		return;
		IL_0068:
		kZ6Zs53L3c7Qoi9WCL2 = new Dictionary<Guid, Match>();
		goto IL_0072;
	}

	public static void Fd8DNpuJ0jV1()
	{
		upk7HjVwiAjnlFnIl3();
		if (Q1KCgmu4xQEEPalLaA())
		{
			goto IL_0022;
		}
		int num = 17;
		if (Q1KCgmu4xQEEPalLaA())
		{
		}
		goto IL_0126;
		IL_0126:
		bool flag = default(bool);
		int num2 = default(int);
		string[] array = default(string[]);
		Match match = default(Match);
		string object_ = default(string);
		bool flag2 = default(bool);
		while (true)
		{
			switch (num)
			{
			case 14:
				goto IL_0046;
			case 12:
				goto IL_0054;
			case 1:
			case 3:
				goto IL_006e;
			case 0:
			case 17:
				eyS0zqHujjK(out System.Runtime.CompilerServices.Unsafe.As<object, string>(ref ueT9gwIObg6));
				goto case 10;
			case 10:
				R1cnkI7PWQmrWb(out System.Runtime.CompilerServices.Unsafe.As<object, string>(ref B060swu52juMYcofFZ));
				goto case 2;
			case 2:
				flag = Interlocked.CompareExchange(ref h71fjOxhYj, 1, 0) != 0;
				num = 4;
				if (upk7HjVwiAjnlFnIl3())
				{
					continue;
				}
				goto case 11;
			case 16:
				goto IL_00bb;
			case 6:
				num2 = 0;
				num = 1;
				if (upk7HjVwiAjnlFnIl3())
				{
					continue;
				}
				goto case 10;
			case 4:
				if (!flag)
				{
					array = (string[])KFebihdflvBtRYC0af(vw7QId1drJyuv4trr6);
					goto case 6;
				}
				return;
			case 7:
			case 15:
			case 18:
				goto IL_00f8;
			case 11:
				match = (Match)UVZcOVTemtZLcxjZ5u(dM03JCc1hzn43y5G, object_);
				goto case 5;
			case 5:
				flag2 = !VLdDSD0xklcpuJElSB(match);
				break;
			case 13:
			case 19:
				return;
			}
			break;
		}
		goto IL_0022;
		IL_0022:
		Guid key = default(Guid);
		if (!flag2)
		{
			key = new Guid((string)NKGy8LUS4oAXpLfNMQ(deWXDGH2XUDQsNcPU1(xNy3qEqKnV9THn7It6(match), "guid")));
			goto IL_0046;
		}
		goto IL_00f8;
		IL_0046:
		bool flag3 = kZ6Zs53L3c7Qoi9WCL2.ContainsKey(key);
		goto IL_0054;
		IL_00f8:
		num2++;
		goto IL_006e;
		IL_006e:
		if (num2 >= array.Length)
		{
			goto IL_00bb;
		}
		object_ = array[num2];
		num = 11;
		if (!upk7HjVwiAjnlFnIl3())
		{
			goto IL_0054;
		}
		goto IL_0126;
		IL_0054:
		if (!flag3)
		{
			kZ6Zs53L3c7Qoi9WCL2[key] = match;
		}
		goto IL_00f8;
		IL_00bb:
		meKFfJFYHexG8RbwLA();
		num = 19;
		if (!upk7HjVwiAjnlFnIl3())
		{
			goto IL_006e;
		}
		goto IL_0126;
	}

	public static Match dmUnETlR6UkQ(object Gb54280pIf6e)
	{
		return (Match)UVZcOVTemtZLcxjZ5u(dM03JCc1hzn43y5G, Gb54280pIf6e);
	}

	public static bool smethod_0(Guid DjsyW2JtN6qwbf4hyjg)
	{
		return !kZ6Zs53L3c7Qoi9WCL2.ContainsKey(DjsyW2JtN6qwbf4hyjg);
	}

	public static string[] QAvQomq7w3o1V1M9Xi()
	{
		return (string[])KFebihdflvBtRYC0af(vw7QId1drJyuv4trr6);
	}

	public static void gtlDPYIC9nHn()
	{
		b3EpsLtZBE9UDEGlZ5(WqXl76ik1iQLRhtmQQ(), new ResolveEventHandler(os79h2Grx8O5oMes));
	}

	public static AppDomain smethod_1()
	{
		return (AppDomain)V1uJ5pJyk9lZMs2QMm();
	}

	public static Guid smethod_2(object JqUPpH59KJLu8G4)
	{
		return new Guid((string)JqUPpH59KJLu8G4);
	}

	private static Assembly os79h2Grx8O5oMes(object Db50reK3BATu9rvf, object object_4)
	{
		int num = 0;
		if (!Q1KCgmu4xQEEPalLaA())
		{
		}
		string object_6 = default(string);
		string text2 = default(string);
		string text3 = default(string);
		string text4 = default(string);
		string text5 = default(string);
		string text = default(string);
		int num2 = default(int);
		string object_5 = default(string);
		Assembly assembly = default(Assembly);
		object obj = default(object);
		bool flag = default(bool);
		bool flag2 = default(bool);
		Assembly result = default(Assembly);
		while (true)
		{
			switch (num)
			{
			case 20:
				object_6 = (string)wGZ9SnWDtUF5wDuCQ8(vPdXuS1Uv7D0cPqMSn(sJSJmEGTat8mFHF4Q3("{0}{1}{2}{3}", new object[4] { text2, text3, text4, text5 })));
				goto case 3;
			case 3:
				text = (string)aQkp8ZywXifnGs32lB(object_6, CFn51HDEQpdtHfgBsH(object_4));
				num = 11;
				if (upk7HjVwiAjnlFnIl3())
				{
					break;
				}
				goto case 10;
			case 1:
				num2 = 87;
				goto case 18;
			case 18:
				text5 = num2.ToString();
				goto case 20;
			case 10:
				text4 = num2.ToString();
				goto case 1;
			case 15:
				text3 = num2.ToString();
				goto case 2;
			case 2:
				num2 = 83;
				goto case 10;
			case 12:
				num2 = 63;
				goto case 15;
			case 0:
				text2 = (string)aQkp8ZywXifnGs32lB("a", 3.ToString());
				goto case 12;
			case 11:
				object_5 = text;
				goto case 6;
			case 6:
				assembly = (Assembly)L3Q4o9QFE5uPROJEs5(object_5);
				goto default;
			default:
				obj = null;
				goto case 5;
			case 5:
				flag = assembly == obj;
				goto case 7;
			case 7:
				if (flag)
				{
					goto case 8;
				}
				goto case 19;
			case 8:
				object_5 = (string)CFn51HDEQpdtHfgBsH(object_4);
				goto case 13;
			case 13:
				assembly = (Assembly)L3Q4o9QFE5uPROJEs5(object_5);
				goto case 9;
			case 9:
				flag2 = assembly == obj;
				Q1KCgmu4xQEEPalLaA();
				if (upk7HjVwiAjnlFnIl3())
				{
					goto case 16;
				}
				goto case 19;
			case 16:
			case 17:
				if (flag2)
				{
					goto case 4;
				}
				goto case 19;
			case 4:
				assembly = (Assembly)L3Q4o9QFE5uPROJEs5(text);
				goto case 19;
			case 19:
			case 21:
				return assembly;
			case 22:
				return result;
			}
		}
	}

	public static Assembly R7nXgG1X7yR2Zovzktg(object wxYXR3RCn2zWQhs2B)
	{
		return (Assembly)TQ3jGRnQr7KSq4lW3n(wxYXR3RCn2zWQhs2B);
	}

	public static string u1zVFeAAkFMq(object object_4)
	{
		Q1KCgmu4xQEEPalLaA();
		char[] array = default(char[]);
		if (upk7HjVwiAjnlFnIl3())
		{
			array = (char[])LEa0khLMo3V5eQHDH2(object_4);
		}
		U0rXlBvaqmMN3UmYrt(array);
		return new string(array);
	}

	public static string smethod_3(object ASUxrtl07K8754)
	{
		_ = 1;
		if (!Q1KCgmu4xQEEPalLaA())
		{
			goto IL_0069;
		}
		goto IL_0079;
		IL_0079:
		int num = default(int);
		byte[] array = default(byte[]);
		string result = default(string);
		while (true)
		{
			IL_0079_2:
			bool flag = num < array.Length;
			while (true)
			{
				if (flag)
				{
					array[num] = ywCr9joBLFMPDqGsT7(bEi71r5HtS7x7SIUrA(ASUxrtl07K8754, num * 2, 2), 16);
					if (upk7HjVwiAjnlFnIl3())
					{
						switch (2)
						{
						case 1:
							break;
						case 2:
							goto IL_0063;
						case 0:
						case 6:
							goto end_IL_005d;
						case 3:
							goto IL_0077;
						default:
							goto IL_0079_2;
						case 7:
							goto IL_0082;
						case 9:
							return result;
						}
						continue;
					}
					goto IL_0063;
				}
				goto IL_0082;
				IL_0082:
				return (string)DNv4v13sTpiEXhrHnd(tU3QP5g7GQm5YyPvJZ(), array);
				IL_0063:
				num++;
				goto IL_0079_2;
				continue;
				end_IL_005d:
				break;
			}
			break;
		}
		goto IL_0069;
		IL_0069:
		array = new byte[ggLDRbC8RWtGYBLTuB(ASUxrtl07K8754) / 2];
		goto IL_0077;
		IL_0077:
		num = 0;
		goto IL_0079;
	}

	public static string tlnHd9lAfFY1IT102k(int lLycZ4N9M4a7Q)
	{
		int num3 = default(int);
		string result2 = default(string);
		while (true)
		{
			string result = "";
			while (true)
			{
				while (true)
				{
					int num = lLycZ4N9M4a7Q;
					while (true)
					{
						IL_0139:
						int num2;
						if (num > 846)
						{
							if (num <= 305144)
							{
								goto IL_0055;
							}
							if (num != 22222226)
							{
								num2 = 19;
								if (Q1KCgmu4xQEEPalLaA())
								{
								}
								goto IL_008f;
							}
							num3 = 61;
							goto IL_025f;
						}
						goto IL_0048;
						IL_01fc:
						result = (string)wGZ9SnWDtUF5wDuCQ8(num3.ToString());
						goto IL_026c;
						IL_0218:
						result = (string)wGZ9SnWDtUF5wDuCQ8(num3.ToString());
						goto IL_026c;
						IL_026c:
						return result;
						IL_0227:
						result = (string)wGZ9SnWDtUF5wDuCQ8(aQkp8ZywXifnGs32lB(num3.ToString(), "c"));
						goto IL_026c;
						IL_0055:
						if (num != 258644)
						{
							goto IL_0240;
						}
						num3 = 75;
						num2 = 9;
						if (!Q1KCgmu4xQEEPalLaA())
						{
							goto IL_008f;
						}
						goto IL_0218;
						IL_01df:
						if (num != -5924)
						{
							Q1KCgmu4xQEEPalLaA();
							if (!upk7HjVwiAjnlFnIl3())
							{
							}
							goto IL_026c;
						}
						num3 = 67;
						goto IL_01fc;
						IL_008f:
						while (true)
						{
							switch (num2)
							{
							case 23:
								break;
							case 20:
								goto IL_0048;
							case 15:
								goto IL_0055;
							case 9:
								result = (string)wGZ9SnWDtUF5wDuCQ8(num3.ToString());
								num2 = 38;
								if (!Q1KCgmu4xQEEPalLaA())
								{
								}
								continue;
							case 5:
								goto IL_0139;
							case 6:
								goto end_IL_0139;
							case 12:
								goto end_IL_0149;
							case 33:
								goto end_IL_014d;
							case 11:
								result = (string)wGZ9SnWDtUF5wDuCQ8(num3.ToString());
								goto IL_026c;
							case 19:
								if (num != 98236984)
								{
									goto case 13;
								}
								num3 = 7;
								goto case 17;
							case 13:
								if (num != 484651651)
								{
									goto IL_026c;
								}
								num3 = 64;
								goto case 3;
							case 3:
								result = (string)wGZ9SnWDtUF5wDuCQ8(num3.ToString());
								goto IL_026c;
							case 17:
								result = (string)wGZ9SnWDtUF5wDuCQ8(aQkp8ZywXifnGs32lB(num3.ToString(), "a"));
								goto IL_026c;
							case 8:
								goto IL_01bf;
							case 18:
								goto IL_01cd;
							case 0:
								goto IL_01df;
							default:
								goto IL_01fc;
							case 28:
								goto IL_020b;
							case 2:
								goto IL_0218;
							case 29:
								goto IL_0227;
							case 34:
								goto IL_0240;
							case 22:
								goto IL_024d;
							case 25:
								goto IL_025f;
							case 1:
							case 4:
							case 7:
							case 14:
							case 16:
							case 21:
							case 24:
							case 26:
							case 27:
							case 30:
							case 31:
							case 32:
							case 35:
							case 36:
							case 37:
							case 38:
								goto IL_026c;
							case 39:
								return result2;
							}
							break;
						}
						goto IL_0027;
						IL_025f:
						result = (string)wGZ9SnWDtUF5wDuCQ8(num3.ToString());
						goto IL_026c;
						IL_0240:
						if (num != 305144)
						{
							goto IL_026c;
						}
						num3 = 65;
						goto IL_024d;
						IL_01cd:
						result = (string)wGZ9SnWDtUF5wDuCQ8(num3.ToString());
						goto IL_026c;
						IL_024d:
						result = (string)wGZ9SnWDtUF5wDuCQ8(num3.ToString());
						goto IL_026c;
						IL_0048:
						if (num <= -5924)
						{
							goto IL_0027;
						}
						if (num != -94)
						{
							goto IL_01bf;
						}
						num3 = 73;
						goto IL_01cd;
						IL_0027:
						if (num != -7590)
						{
							goto IL_01df;
						}
						num3 = 69;
						num2 = 11;
						if (!upk7HjVwiAjnlFnIl3())
						{
							goto end_IL_014d;
						}
						goto IL_008f;
						IL_01bf:
						if (num != 46)
						{
							goto IL_020b;
						}
						num3 = 6;
						goto IL_0227;
						IL_020b:
						if (num != 846)
						{
							goto IL_026c;
						}
						num3 = 66;
						goto IL_0218;
						continue;
						end_IL_0139:
						break;
					}
					continue;
					end_IL_0149:
					break;
				}
				continue;
				end_IL_014d:
				break;
			}
		}
	}

	private static void iJMN1l4zrPS31(out string gFtGxEtm5ixnzA8)
	{
		gFtGxEtm5ixnzA8 = (string)fZWw5kRCq7kV5dM1es(846);
	}

	private static void ehhdAkPNb9(out string V4Ju6Ck2gk4kle6NEzn)
	{
		V4Ju6Ck2gk4kle6NEzn = (string)fZWw5kRCq7kV5dM1es(-5924);
	}

	private static void smethod_4(out string string_0)
	{
		string_0 = (string)fZWw5kRCq7kV5dM1es(46);
	}

	private static void smethod_5(out string string_0)
	{
		string_0 = (string)fZWw5kRCq7kV5dM1es(98236984);
	}

	private static void AQsSkEC8woQ5hL(out string string_0)
	{
		string_0 = (string)fZWw5kRCq7kV5dM1es(-94);
	}

	private static void smethod_6(out string dQfCRH8lv0pC75j6w38)
	{
		dQfCRH8lv0pC75j6w38 = (string)fZWw5kRCq7kV5dM1es(-7590);
	}

	private static void yf6xr4f7QMeN82y(out string string_0)
	{
		string_0 = (string)fZWw5kRCq7kV5dM1es(305144);
	}

	private static void kK8tSuXCa5JVBdEh(out string string_0)
	{
		string_0 = (string)fZWw5kRCq7kV5dM1es(22222226);
	}

	private static void eyS0zqHujjK(out string string_0)
	{
		string_0 = (string)fZWw5kRCq7kV5dM1es(258644);
	}

	private static void R1cnkI7PWQmrWb(out string tJ25v8VxaqPGsG1w)
	{
		tJ25v8VxaqPGsG1w = (string)fZWw5kRCq7kV5dM1es(484651651);
	}

	private static Assembly clCrg61RUK8GW(object object_4)
	{
		try
		{
			if (!kZ6Zs53L3c7Qoi9WCL2.TryGetValue(DNxZuF2cxNHt7IOmcj(object_4), out var value))
			{
				return null;
			}
			if (I9012NGW53Ml27.TryGetValue(DNxZuF2cxNHt7IOmcj(object_4), out var value2))
			{
				return value2;
			}
			object_4 = NKGy8LUS4oAXpLfNMQ(OWGWWpSVdSxXsXXKRl(xNy3qEqKnV9THn7It6(value), 0));
			iJMN1l4zrPS31(out System.Runtime.CompilerServices.Unsafe.As<object, string>(ref object_0));
			ehhdAkPNb9(out System.Runtime.CompilerServices.Unsafe.As<object, string>(ref RFzBzl9E6EY));
			smethod_4(out System.Runtime.CompilerServices.Unsafe.As<object, string>(ref q9zvyqNA6f6Gprb));
			smethod_5(out System.Runtime.CompilerServices.Unsafe.As<object, string>(ref H9D4awmgW0Ht9UAK7I));
			AQsSkEC8woQ5hL(out System.Runtime.CompilerServices.Unsafe.As<object, string>(ref object_1));
			smethod_6(out System.Runtime.CompilerServices.Unsafe.As<object, string>(ref ikk66b3G3Xs97));
			yf6xr4f7QMeN82y(out System.Runtime.CompilerServices.Unsafe.As<object, string>(ref object_2));
			kK8tSuXCa5JVBdEh(out System.Runtime.CompilerServices.Unsafe.As<object, string>(ref object_3));
			Ut3f0qcxMQ5Hbv3Egc(ncbYkTwwReAAFegEbp(value), H9D4awmgW0Ht9UAK7I);
			byte[] object_5 = (byte[])Ee6BZEsk3mWiaxkXqm(object_4, wBpC099gEiu4NBhZds(value));
			Assembly assembly = (Assembly)dPeuhhOWckCy3dGqpw(object_5);
			Dictionary<Guid, Assembly> i9012NGW53Ml = I9012NGW53Ml27;
			bool lockTaken = false;
			try
			{
				Monitor.Enter(i9012NGW53Ml, ref lockTaken);
				Assembly result = default(Assembly);
				bool flag2 = default(bool);
				while (true)
				{
					Assembly value3;
					bool flag = I9012NGW53Ml27.TryGetValue(DNxZuF2cxNHt7IOmcj(object_4), out value3);
					int num = 5;
					if (!upk7HjVwiAjnlFnIl3())
					{
						goto IL_00da;
					}
					goto IL_00f7;
					IL_00f7:
					switch (num)
					{
					case 5:
						break;
					case 4:
						continue;
					case 2:
					case 6:
						goto IL_0157;
					case 7:
						goto IL_015d;
					case 0:
						goto IL_0161;
					case 8:
						goto end_IL_0122;
					default:
						return result;
					case 1:
					case 3:
						return result;
					}
					goto IL_00da;
					IL_00da:
					if (flag)
					{
						upk7HjVwiAjnlFnIl3();
						if (Q1KCgmu4xQEEPalLaA())
						{
							num = 1;
							if (upk7HjVwiAjnlFnIl3())
							{
								goto IL_00f7;
							}
							goto IL_0161;
						}
						goto IL_0157;
					}
					flag2 = iLWwP4B4Ix4BFBDGF2(assembly, null);
					goto IL_015d;
					IL_015d:
					if (!flag2)
					{
						break;
					}
					goto IL_0161;
					IL_0161:
					I9012NGW53Ml27[DNxZuF2cxNHt7IOmcj(object_4)] = assembly;
					break;
					IL_0157:
					return value3;
					continue;
					end_IL_0122:
					break;
				}
			}
			finally
			{
				if (lockTaken)
				{
					NpAuTJNFt0TdxylbT2(i9012NGW53Ml);
				}
			}
			return assembly;
		}
		catch
		{
			return null;
		}
	}

	public static int smethod_7(object object_4)
	{
		return LmPBYB8nAG65OlJFGd(NKGy8LUS4oAXpLfNMQ(deWXDGH2XUDQsNcPU1(xNy3qEqKnV9THn7It6(object_4), nXEObukvkJSVLjjRvi(object_1, ikk66b3G3Xs97, H9D4awmgW0Ht9UAK7I, object_2))));
	}

	public static string e86PGBdmbDvgLwFK(object object_4)
	{
		return (string)o7nFXVIJqaAl3yawAk(object_4, wXFtpQr273QycpUIYL(new string[5]
		{
			(string)object_0,
			(string)q9zvyqNA6f6Gprb,
			(string)object_3,
			(string)RFzBzl9E6EY,
			(string)object_1
		}));
	}

	public static Assembly d74wtEm2749Vda9R(object object_4)
	{
		return (Assembly)F7e0Y3ejr9YA9QCumO(object_4);
	}

	public static string smethod_8(object EqRS6x42Z0, object SS1XbkH5JPFGm2huq)
	{
		return (string)NKGy8LUS4oAXpLfNMQ(deWXDGH2XUDQsNcPU1(xNy3qEqKnV9THn7It6(EqRS6x42Z0), SS1XbkH5JPFGm2huq));
	}

	public static byte[] KFzgJ8tAKIj3weyk(object Jf9wgemE08JE0Zcnsp, int int_0)
	{
		upk7HjVwiAjnlFnIl3();
		byte[] array = default(byte[]);
		if (!Q1KCgmu4xQEEPalLaA())
		{
			array = new byte[int_0];
		}
		Stream stream = (Stream)KA0F9wZirDGLeihuZ4(vw7QId1drJyuv4trr6, Jf9wgemE08JE0Zcnsp);
		try
		{
			if (stream != null)
			{
				Stream stream2 = new DeflateStream(stream, CompressionMode.Decompress);
				try
				{
					UTYpp2M1G8EDPPBvUW(stream2, array, 0, int_0);
					return array;
				}
				finally
				{
					if (stream2 != null)
					{
						ph5YdRzp45I465sn2Q(stream2);
					}
				}
			}
			return null;
		}
		finally
		{
			if (stream != null)
			{
				ph5YdRzp45I465sn2Q(stream);
			}
		}
	}

	private static Guid cE8prxDBmBt9(object object_4)
	{
		byte[] b = (byte[])JRH10T44RSCTiNm6yIN(s7rrt64X67tLMI5MW06(object_4));
		return new Guid(b);
	}

	private static byte[] x771CV1X65LSplZ33G(object pobyMnu27EVC)
	{
		return (byte[])Gntrcd4bk2guNo7R3jP(Dd8GU24Kker0xYuEA76(), JREXxq4fxLXS0RJa62w(pobyMnu27EVC));
	}

	private unsafe static byte[] smethod_9(object object_4)
	{
		smethod_10(object_4, out *(byte[]*)(&object_4));
		return (byte[])object_4;
	}

	private static void smethod_10(object Rq91Q1wvtyFHH0NRdke, out byte[] aiO79Ici109KbTF1uwB)
	{
		aiO79Ici109KbTF1uwB = (byte[])lbhUkA4Exe7jjRhEsqS(gtRBhN4mmXxLB60pYdh(), Rq91Q1wvtyFHH0NRdke);
	}

	public lhP0CnQ6zL0w3G6k()
	{
		zGJT1I4Y7VZ3hh4xl6y(this);
	}

	internal static object wGZ9SnWDtUF5wDuCQ8(object object_4)
	{
		return smethod_3(object_4);
	}

	internal static Type E2ZFLH6wEdspfXRV1c(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static bool upk7HjVwiAjnlFnIl3()
	{
		return true;
	}

	internal static bool Q1KCgmu4xQEEPalLaA()
	{
		return false;
	}

	internal static object KFebihdflvBtRYC0af(object object_4)
	{
		return ((Assembly)object_4).GetManifestResourceNames();
	}

	internal static object UVZcOVTemtZLcxjZ5u(object object_4, object object_5)
	{
		return ((Regex)object_4).Match((string)object_5);
	}

	internal static bool VLdDSD0xklcpuJElSB(object object_4)
	{
		return ((Group)object_4).Success;
	}

	internal static object xNy3qEqKnV9THn7It6(object object_4)
	{
		return ((Match)object_4).Groups;
	}

	internal static object deWXDGH2XUDQsNcPU1(object object_4, object object_5)
	{
		return ((GroupCollection)object_4)[(string)object_5];
	}

	internal static object NKGy8LUS4oAXpLfNMQ(object object_4)
	{
		return ((Capture)object_4).Value;
	}

	internal static void meKFfJFYHexG8RbwLA()
	{
		gtlDPYIC9nHn();
	}

	internal static object WqXl76ik1iQLRhtmQQ()
	{
		return smethod_1();
	}

	internal static void b3EpsLtZBE9UDEGlZ5(object object_4, object object_5)
	{
		((AppDomain)object_4).AssemblyResolve += (ResolveEventHandler?)object_5;
	}

	internal static object V1uJ5pJyk9lZMs2QMm()
	{
		return AppDomain.CurrentDomain;
	}

	internal static object aQkp8ZywXifnGs32lB(object object_4, object object_5)
	{
		return (string?)object_4 + (string?)object_5;
	}

	internal static object sJSJmEGTat8mFHF4Q3(object object_4, object object_5)
	{
		return string.Format((string)object_4, (object?[])object_5);
	}

	internal static object vPdXuS1Uv7D0cPqMSn(object object_4)
	{
		return u1zVFeAAkFMq(object_4);
	}

	internal static object CFn51HDEQpdtHfgBsH(object object_4)
	{
		return ((ResolveEventArgs)object_4).Name;
	}

	internal static object L3Q4o9QFE5uPROJEs5(object object_4)
	{
		return R7nXgG1X7yR2Zovzktg(object_4);
	}

	internal static object TQ3jGRnQr7KSq4lW3n(object object_4)
	{
		return clCrg61RUK8GW(object_4);
	}

	internal static object LEa0khLMo3V5eQHDH2(object object_4)
	{
		return ((string)object_4).ToCharArray();
	}

	internal static void U0rXlBvaqmMN3UmYrt(object object_4)
	{
		Array.Reverse((Array)object_4);
	}

	internal static int ggLDRbC8RWtGYBLTuB(object object_4)
	{
		return ((string)object_4).Length;
	}

	internal static object bEi71r5HtS7x7SIUrA(object object_4, int int_0, int int_1)
	{
		return ((string)object_4).Substring(int_0, int_1);
	}

	internal static byte ywCr9joBLFMPDqGsT7(object object_4, int int_0)
	{
		return Convert.ToByte((string?)object_4, int_0);
	}

	internal static object tU3QP5g7GQm5YyPvJZ()
	{
		return Encoding.ASCII;
	}

	internal static object DNv4v13sTpiEXhrHnd(object object_4, object object_5)
	{
		return ((Encoding)object_4).GetString((byte[])object_5);
	}

	internal static object fZWw5kRCq7kV5dM1es(int lLycZ4N9M4a7Q)
	{
		return tlnHd9lAfFY1IT102k(lLycZ4N9M4a7Q);
	}

	internal static Guid DNxZuF2cxNHt7IOmcj(object object_4)
	{
		return cE8prxDBmBt9(object_4);
	}

	internal static object OWGWWpSVdSxXsXXKRl(object object_4, int int_0)
	{
		return ((GroupCollection)object_4)[int_0];
	}

	internal static object ncbYkTwwReAAFegEbp(object object_4)
	{
		return e86PGBdmbDvgLwFK(object_4);
	}

	internal static bool Ut3f0qcxMQ5Hbv3Egc(object object_4, object object_5)
	{
		return ((string)object_4).Contains((string)object_5);
	}

	internal static int wBpC099gEiu4NBhZds(object object_4)
	{
		return smethod_7(object_4);
	}

	internal static object Ee6BZEsk3mWiaxkXqm(object object_4, int int_0)
	{
		return KFzgJ8tAKIj3weyk(object_4, int_0);
	}

	internal static object dPeuhhOWckCy3dGqpw(object object_4)
	{
		return d74wtEm2749Vda9R(object_4);
	}

	internal static bool iLWwP4B4Ix4BFBDGF2(object object_4, object object_5)
	{
		return (Assembly?)object_4 != (Assembly?)object_5;
	}

	internal static void NpAuTJNFt0TdxylbT2(object object_4)
	{
		Monitor.Exit(object_4);
	}

	internal static object nXEObukvkJSVLjjRvi(object object_4, object object_5, object object_6, object object_7)
	{
		return (string?)object_4 + (string?)object_5 + (string?)object_6 + (string?)object_7;
	}

	internal static int LmPBYB8nAG65OlJFGd(object object_4)
	{
		return int.Parse((string)object_4);
	}

	internal static object wXFtpQr273QycpUIYL(object object_4)
	{
		return string.Concat((string?[])object_4);
	}

	internal static object o7nFXVIJqaAl3yawAk(object object_4, object object_5)
	{
		return smethod_8(object_4, object_5);
	}

	internal static object F7e0Y3ejr9YA9QCumO(object object_4)
	{
		return Assembly.Load((byte[])object_4);
	}

	internal static object KA0F9wZirDGLeihuZ4(object object_4, object object_5)
	{
		return ((Assembly)object_4).GetManifestResourceStream((string)object_5);
	}

	internal static int UTYpp2M1G8EDPPBvUW(object object_4, object object_5, int int_0, int int_1)
	{
		return ((Stream)object_4).Read((byte[])object_5, int_0, int_1);
	}

	internal static void ph5YdRzp45I465sn2Q(object object_4)
	{
		((IDisposable)object_4).Dispose();
	}

	internal static object s7rrt64X67tLMI5MW06(object object_4)
	{
		return x771CV1X65LSplZ33G(object_4);
	}

	internal static object JRH10T44RSCTiNm6yIN(object object_4)
	{
		return smethod_9(object_4);
	}

	internal static object Dd8GU24Kker0xYuEA76()
	{
		return Encoding.UTF8;
	}

	internal static object JREXxq4fxLXS0RJa62w(object object_4)
	{
		return ((string)object_4).ToLowerInvariant();
	}

	internal static object Gntrcd4bk2guNo7R3jP(object object_4, object object_5)
	{
		return ((Encoding)object_4).GetBytes((string)object_5);
	}

	internal static object gtRBhN4mmXxLB60pYdh()
	{
		return MD5.Create();
	}

	internal static object lbhUkA4Exe7jjRhEsqS(object object_4, object object_5)
	{
		return ((HashAlgorithm)object_4).ComputeHash((byte[])object_5);
	}

	internal static void zGJT1I4Y7VZ3hh4xl6y(object object_4)
	{
		object_4._002Ector();
	}
}
