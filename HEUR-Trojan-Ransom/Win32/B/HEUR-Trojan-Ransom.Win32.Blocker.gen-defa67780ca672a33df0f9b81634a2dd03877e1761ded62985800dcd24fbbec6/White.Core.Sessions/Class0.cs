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

namespace White.Core.Sessions;

internal class Class0
{
	private static readonly object SI1M1KZt6rdYAVpT;

	private static readonly object object_0;

	private static int int_0;

	private static readonly Dictionary<Guid, Match> QUpCP0LlQ8gBTlMJUT;

	private static readonly Dictionary<Guid, Assembly> MrXtBaiWhA2zgGdCLb;

	public static object jjjddF2H5M89OE7;

	public static object E3AOCHEELxja4;

	public static object JaHtJNCnUOI2mkiaO;

	public static object Ip8Jlx8CFF2P62Npc;

	public static object object_1;

	public static object Ytuhh7VerQP7hkitZY1;

	public static object AzsZhljRhhA;

	public static object object_2;

	public static object xi98b5a5Xe7kpR9;

	public static object aAjdl9D6V4;

	static Class0()
	{
		H67Qj8cSwxv939qE8E();
		if (KKJn191vwjxs5BG2kJ())
		{
			SI1M1KZt6rdYAVpT = new Regex((string)jOs8dpBmsUgLmjt6dh("61736d7a3a2f2f283f3c677569643e5b302d39612d66412d465d7b33327d292f283f3c73697a653e5b302d395d2b29282f283f3c666c6167733e5b612d7a412d5a302d395d2a29293f"), RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture);
			object_0 = lDT3NUn8aOfLuMo7jD(typeof(Class0).TypeHandle).Assembly;
			QUpCP0LlQ8gBTlMJUT = new Dictionary<Guid, Match>();
		}
		MrXtBaiWhA2zgGdCLb = new Dictionary<Guid, Assembly>();
	}

	public static void ij16y1lLZG7KJ5wy()
	{
		bool flag2 = default(bool);
		Guid key = default(Guid);
		Match match = default(Match);
		string[] array = default(string[]);
		int num2 = default(int);
		bool flag3 = default(bool);
		string object_ = default(string);
		while (true)
		{
			Jq940wdUkb7J3ESX3H(out System.Runtime.CompilerServices.Unsafe.As<object, string>(ref xi98b5a5Xe7kpR9));
			while (true)
			{
				nq7SWuHc6OLnp(out System.Runtime.CompilerServices.Unsafe.As<object, string>(ref aAjdl9D6V4));
				while (true)
				{
					bool flag = Interlocked.CompareExchange(ref int_0, 1, 0) != 0;
					_ = 0;
					int num;
					if (!KKJn191vwjxs5BG2kJ())
					{
						num = 4;
						if (H67Qj8cSwxv939qE8E())
						{
						}
						goto IL_00d8;
					}
					goto IL_0036;
					IL_007b:
					if (!flag2)
					{
						key = new Guid((string)HfHRmDhdhYs4wklCgy(mZGZFtCk8ZteGnriPt(TKo3jR4Wy0f7iArnop(match), "guid")));
						goto IL_009c;
					}
					goto IL_00d2;
					IL_0036:
					if (flag)
					{
						num = 16;
						if (!KKJn191vwjxs5BG2kJ())
						{
							goto IL_00aa;
						}
						goto IL_00d8;
					}
					array = (string[])nCsjo1acifFV6iyU8m(object_0);
					goto IL_0056;
					IL_00d2:
					num2++;
					goto IL_0058;
					IL_009c:
					flag3 = QUpCP0LlQ8gBTlMJUT.ContainsKey(key);
					goto IL_00aa;
					IL_0056:
					num2 = 0;
					goto IL_0058;
					IL_0058:
					if (num2 < array.Length)
					{
						object_ = array[num2];
						goto IL_0062;
					}
					goto IL_00be;
					IL_00aa:
					if (!flag3)
					{
						QUpCP0LlQ8gBTlMJUT[key] = match;
					}
					goto IL_00d2;
					IL_00be:
					qHM3M26gkerFtAj950();
					num = 19;
					if (H67Qj8cSwxv939qE8E())
					{
						goto IL_006f;
					}
					goto IL_00d8;
					IL_00d8:
					switch (num)
					{
					case 12:
						break;
					case 3:
					case 17:
						goto IL_0036;
					case 10:
						goto IL_0056;
					case 7:
					case 11:
						goto IL_0058;
					case 9:
						goto IL_0062;
					case 5:
						goto IL_006f;
					default:
						goto IL_007b;
					case 1:
						goto IL_009c;
					case 15:
						goto IL_00aa;
					case 2:
						goto IL_00be;
					case 0:
					case 4:
					case 6:
					case 14:
						goto IL_00d2;
					case 13:
						goto end_IL_0006;
					case 18:
						goto end_IL_0138;
					case 16:
					case 19:
						return;
					}
					continue;
					IL_0062:
					match = (Match)XYN3ttRtGDbKKwhtuf(SI1M1KZt6rdYAVpT, object_);
					goto IL_006f;
					IL_006f:
					flag2 = !FANTMw7hP17mPeiyX2(match);
					goto IL_007b;
					continue;
					end_IL_0006:
					break;
				}
				continue;
				end_IL_0138:
				break;
			}
		}
	}

	public static Match zj33R635b0GBW9K6v(object object_3)
	{
		return (Match)XYN3ttRtGDbKKwhtuf(SI1M1KZt6rdYAVpT, object_3);
	}

	public static bool I389gO1n8Bx(Guid EjdHxNxhxGZ0dG4)
	{
		return !QUpCP0LlQ8gBTlMJUT.ContainsKey(EjdHxNxhxGZ0dG4);
	}

	public static string[] smethod_0()
	{
		return (string[])nCsjo1acifFV6iyU8m(object_0);
	}

	public static void yV8UKIfTbdh59t9WM()
	{
		SX0hS3TbCUV17NtXNg(LhtsW93CY7nEa3ZqBt(), new ResolveEventHandler(tpD27Ln35m6Vp0yvN67));
	}

	public static AppDomain rXfqkgMXQlAV9P()
	{
		return (AppDomain)wFndIs2l6Rhpau4hlp();
	}

	public static Guid Ygg1A76IP1Z3P0(object object_3)
	{
		return new Guid((string)object_3);
	}

	private static Assembly tpD27Ln35m6Vp0yvN67(object OBOCvQl7591KD, object object_3)
	{
		string text4 = default(string);
		string object_4 = default(string);
		string text5 = default(string);
		Assembly assembly = default(Assembly);
		bool flag2 = default(bool);
		Assembly result = default(Assembly);
		while (true)
		{
			string text = (string)vU9vqHwsXtf5lJPCNi("a", 3.ToString());
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
								IL_0006:
								num = 87;
								_ = 0;
								if (!KKJn191vwjxs5BG2kJ())
								{
									goto IL_00fb;
								}
								goto IL_00ab;
								IL_00ab:
								text4 = num.ToString();
								goto IL_00b3;
								IL_00b3:
								object_4 = (string)jOs8dpBmsUgLmjt6dh(oLMaCPgyZXUgMU36o3(LXf2EZIfv25gmFhjDi("{0}{1}{2}{3}", new object[4] { text, text2, text3, text4 })));
								goto IL_00df;
								IL_00df:
								text5 = (string)vU9vqHwsXtf5lJPCNi(object_4, rPPYXmy8rekO5WRN5L(object_3));
								goto IL_00ee;
								IL_00ee:
								string object_5 = text5;
								goto IL_00f2;
								IL_00f2:
								assembly = (Assembly)ke3HUv05Fxuf81Oc48(object_5);
								goto IL_00fb;
								IL_00fb:
								while (true)
								{
									IL_00fb_2:
									object obj = null;
									while (true)
									{
										IL_00a1:
										bool flag = assembly == obj;
										while (true)
										{
											IL_0095:
											if (flag)
											{
												while (true)
												{
													object_5 = (string)rPPYXmy8rekO5WRN5L(object_3);
													if (H67Qj8cSwxv939qE8E())
													{
														break;
													}
													switch (12)
													{
													case 19:
														break;
													case 10:
														continue;
													case 3:
														goto IL_0095;
													case 7:
														goto IL_00a1;
													case 6:
													case 13:
														goto IL_00ab;
													case 14:
														goto IL_00b3;
													case 16:
														goto IL_00df;
													case 9:
														goto IL_00ee;
													case 0:
														goto IL_00f2;
													default:
														goto IL_00fb_2;
													case 15:
														goto end_IL_001b;
													case 21:
														goto end_IL_0104;
													case 17:
														goto end_IL_0111;
													case 20:
														goto end_IL_0117;
													case 8:
														goto end_IL_0121;
													case 12:
														assembly = (Assembly)ke3HUv05Fxuf81Oc48(object_5);
														goto case 4;
													case 4:
														flag2 = assembly == obj;
														goto case 18;
													case 18:
														if (flag2)
														{
															goto case 5;
														}
														goto IL_015c;
													case 5:
														assembly = (Assembly)ke3HUv05Fxuf81Oc48(text5);
														goto IL_015c;
													case 2:
														goto IL_015c;
													case 22:
														return result;
													}
													goto IL_0006;
													continue;
													end_IL_001b:
													break;
												}
												break;
											}
											goto IL_015c;
											IL_015c:
											return assembly;
										}
										break;
									}
									break;
								}
								break;
							}
							continue;
							end_IL_0104:
							break;
						}
						continue;
						end_IL_0111:
						break;
					}
					continue;
					end_IL_0117:
					break;
				}
				continue;
				end_IL_0121:
				break;
			}
		}
	}

	public static Assembly yAoRBagQ9p8(object UvrA4M9LNTsK7TCMnZn)
	{
		return (Assembly)imjD1qEQbRGKqk1sHO(UvrA4M9LNTsK7TCMnZn);
	}

	public static string vpwc9Oku4C(object object_3)
	{
		H67Qj8cSwxv939qE8E();
		char[] array = default(char[]);
		if (KKJn191vwjxs5BG2kJ())
		{
			array = (char[])O0G6xaLU32n5uRs6Nx(object_3);
			NjTJKCmeZoVkkLRWuV(array);
		}
		return new string(array);
	}

	public static string sETR73CKc3KF9oa(object BPRlDxFzJYvl)
	{
		byte[] array = new byte[KuAoxsKe5goVb9Dp91(BPRlDxFzJYvl) / 2];
		int num = 0;
		while (true)
		{
			bool flag = num < array.Length;
			do
			{
				if (flag)
				{
					array[num] = jF46q0jgdDBo6H3YPZ(pyUjpkedT1UFRW58jv(BPRlDxFzJYvl, num * 2, 2), 16);
					H67Qj8cSwxv939qE8E();
					continue;
				}
				return (string)FfME9uXDNKl3saYcp4(ySP7SsbTg6o1m5KAEi(), array);
			}
			while (!KKJn191vwjxs5BG2kJ());
			num++;
		}
	}

	public static string fOSQRU543WA9F1(int int_1)
	{
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		string result2 = default(string);
		while (true)
		{
			string result = "";
			int num = 6;
			if (!H67Qj8cSwxv939qE8E())
			{
			}
			while (true)
			{
				switch (num)
				{
				case 33:
					if (num2 <= 846)
					{
						goto case 27;
					}
					if (num2 <= 305144)
					{
						goto case 8;
					}
					if (num2 != 22222226)
					{
						goto case 12;
					}
					num3 = 61;
					goto case 9;
				case 27:
					if (num2 <= -5924)
					{
						_ = 0;
						if (KKJn191vwjxs5BG2kJ())
						{
							num = 22;
							if (!H67Qj8cSwxv939qE8E())
							{
								continue;
							}
							goto case 39;
						}
						goto case 0;
					}
					if (num2 != -94)
					{
						goto case 10;
					}
					num3 = 73;
					goto case 35;
				case 8:
					if (num2 != 258644)
					{
						num = 25;
						if (KKJn191vwjxs5BG2kJ())
						{
							continue;
						}
						goto case 10;
					}
					num3 = 75;
					goto case 30;
				case 13:
					num2 = num4;
					goto case 33;
				case 6:
					num4 = int_1;
					goto case 13;
				case 15:
					break;
				case 5:
				case 22:
					if (num2 != -7590)
					{
						goto case 3;
					}
					num3 = 69;
					goto case 20;
				case 3:
					if (num2 != -5924)
					{
						goto case 0;
					}
					num3 = 67;
					goto default;
				case 20:
					result = (string)jOs8dpBmsUgLmjt6dh(num3.ToString());
					goto case 0;
				default:
					result = (string)jOs8dpBmsUgLmjt6dh(num3.ToString());
					goto case 0;
				case 25:
					if (num2 != 305144)
					{
						goto case 0;
					}
					num3 = 65;
					goto case 4;
				case 4:
					result = (string)jOs8dpBmsUgLmjt6dh(num3.ToString());
					goto case 0;
				case 10:
					if (num2 != 46)
					{
						goto case 16;
					}
					num3 = 6;
					goto case 2;
				case 16:
					if (num2 != 846)
					{
						goto case 0;
					}
					num3 = 66;
					goto case 17;
				case 17:
					result = (string)jOs8dpBmsUgLmjt6dh(num3.ToString());
					goto case 0;
				case 2:
					result = (string)jOs8dpBmsUgLmjt6dh(vU9vqHwsXtf5lJPCNi(num3.ToString(), "c"));
					goto case 0;
				case 30:
					result = (string)jOs8dpBmsUgLmjt6dh(num3.ToString());
					goto case 0;
				case 12:
					if (num2 != 98236984)
					{
						goto case 29;
					}
					num3 = 7;
					goto case 18;
				case 29:
					if (num2 != 484651651)
					{
						goto case 0;
					}
					num3 = 64;
					goto case 36;
				case 18:
					result = (string)jOs8dpBmsUgLmjt6dh(vU9vqHwsXtf5lJPCNi(num3.ToString(), "a"));
					goto case 0;
				case 9:
					result = (string)jOs8dpBmsUgLmjt6dh(num3.ToString());
					goto case 0;
				case 35:
					result = (string)jOs8dpBmsUgLmjt6dh(num3.ToString());
					goto case 0;
				case 36:
					result = (string)jOs8dpBmsUgLmjt6dh(num3.ToString());
					goto case 0;
				case 0:
				case 1:
				case 7:
				case 11:
				case 14:
				case 19:
				case 21:
				case 24:
				case 26:
				case 28:
				case 31:
				case 32:
				case 34:
				case 37:
				case 38:
					return result;
				case 39:
					return result2;
				}
				break;
			}
		}
	}

	private static void smethod_1(out string string_0)
	{
		string_0 = (string)n3ZQoRt0MQl6wWZmI9(846);
	}

	private static void smethod_2(out string d98q28k54C)
	{
		d98q28k54C = (string)n3ZQoRt0MQl6wWZmI9(-5924);
	}

	private static void iUWPXDGB4wyM2o2(out string v1tM007rN3295Xjw4mX)
	{
		v1tM007rN3295Xjw4mX = (string)n3ZQoRt0MQl6wWZmI9(46);
	}

	private static void MbRH67mQPXG(out string A9YEk0oSxF)
	{
		A9YEk0oSxF = (string)n3ZQoRt0MQl6wWZmI9(98236984);
	}

	private static void smethod_3(out string wtJMp3oQBZXz)
	{
		wtJMp3oQBZXz = (string)n3ZQoRt0MQl6wWZmI9(-94);
	}

	private static void smethod_4(out string pnE47KVEGdnGWhkH)
	{
		pnE47KVEGdnGWhkH = (string)n3ZQoRt0MQl6wWZmI9(-7590);
	}

	private static void ZOtvApuwq0CImXU7(out string TS4KO3mAndWQJsQ8)
	{
		TS4KO3mAndWQJsQ8 = (string)n3ZQoRt0MQl6wWZmI9(305144);
	}

	private static void Y0h0P7tIqUs64p2jiy2(out string string_0)
	{
		string_0 = (string)n3ZQoRt0MQl6wWZmI9(22222226);
	}

	private static void Jq940wdUkb7J3ESX3H(out string string_0)
	{
		string_0 = (string)n3ZQoRt0MQl6wWZmI9(258644);
	}

	private static void nq7SWuHc6OLnp(out string ye7gO9Yswz0PM9z)
	{
		ye7gO9Yswz0PM9z = (string)n3ZQoRt0MQl6wWZmI9(484651651);
	}

	private static Assembly X77sFH6YOIPTb83W0W6(object fD76753H2gIIM81oP)
	{
		try
		{
			if (!QUpCP0LlQ8gBTlMJUT.TryGetValue(ktriwBMJioi5Cmmo71(fD76753H2gIIM81oP), out var value))
			{
				return null;
			}
			if (MrXtBaiWhA2zgGdCLb.TryGetValue(ktriwBMJioi5Cmmo71(fD76753H2gIIM81oP), out var value2))
			{
				return value2;
			}
			fD76753H2gIIM81oP = HfHRmDhdhYs4wklCgy(WjDuybZUsXlFRyuWqe(TKo3jR4Wy0f7iArnop(value), 0));
			smethod_1(out System.Runtime.CompilerServices.Unsafe.As<object, string>(ref jjjddF2H5M89OE7));
			smethod_2(out System.Runtime.CompilerServices.Unsafe.As<object, string>(ref E3AOCHEELxja4));
			iUWPXDGB4wyM2o2(out System.Runtime.CompilerServices.Unsafe.As<object, string>(ref JaHtJNCnUOI2mkiaO));
			MbRH67mQPXG(out System.Runtime.CompilerServices.Unsafe.As<object, string>(ref Ip8Jlx8CFF2P62Npc));
			smethod_3(out System.Runtime.CompilerServices.Unsafe.As<object, string>(ref object_1));
			smethod_4(out System.Runtime.CompilerServices.Unsafe.As<object, string>(ref Ytuhh7VerQP7hkitZY1));
			ZOtvApuwq0CImXU7(out System.Runtime.CompilerServices.Unsafe.As<object, string>(ref AzsZhljRhhA));
			Y0h0P7tIqUs64p2jiy2(out System.Runtime.CompilerServices.Unsafe.As<object, string>(ref object_2));
			pmUMOWxriuEXUaDUN6(q5dTRS9wHu42xbfY6D(value), Ip8Jlx8CFF2P62Npc);
			byte[] object_ = (byte[])qB9xAvruFXkoQ3yPZd(fD76753H2gIIM81oP, zSIRcdWq8QTJ7W9CZG(value));
			Assembly assembly = (Assembly)uNDVEZ59F0aew1HJAC(object_);
			Dictionary<Guid, Assembly> mrXtBaiWhA2zgGdCLb = MrXtBaiWhA2zgGdCLb;
			bool lockTaken = false;
			try
			{
				Monitor.Enter(mrXtBaiWhA2zgGdCLb, ref lockTaken);
				if (MrXtBaiWhA2zgGdCLb.TryGetValue(ktriwBMJioi5Cmmo71(fD76753H2gIIM81oP), out var value3))
				{
					KKJn191vwjxs5BG2kJ();
					if (!H67Qj8cSwxv939qE8E())
					{
						return value3;
					}
					Assembly result = default(Assembly);
					return result;
				}
				if (EUd0bkoJ90Xp61q80c(assembly, null))
				{
					MrXtBaiWhA2zgGdCLb[ktriwBMJioi5Cmmo71(fD76753H2gIIM81oP)] = assembly;
				}
			}
			finally
			{
				if (lockTaken)
				{
					WAjeDVNDGNh0TXgjai(mrXtBaiWhA2zgGdCLb);
				}
			}
			return assembly;
		}
		catch
		{
			return null;
		}
	}

	public static int smethod_5(object VKNZ5Iaggdgph4X)
	{
		return QTAcLWPVJ71PDEEkSy(HfHRmDhdhYs4wklCgy(mZGZFtCk8ZteGnriPt(TKo3jR4Wy0f7iArnop(VKNZ5Iaggdgph4X), HpO0VjJNQv1qii77P9(object_1, Ytuhh7VerQP7hkitZY1, Ip8Jlx8CFF2P62Npc, AzsZhljRhhA))));
	}

	public static string h6l1n2OELZRSgcfHo(object lyeSNTgM8mrR)
	{
		return (string)YxuATBkkHtt8UmrSBM(lyeSNTgM8mrR, iZySd0DDT55eMvqVTn(new string[5]
		{
			(string)jjjddF2H5M89OE7,
			(string)JaHtJNCnUOI2mkiaO,
			(string)object_2,
			(string)E3AOCHEELxja4,
			(string)object_1
		}));
	}

	public static Assembly smethod_6(object ad79a2s8Kyt1)
	{
		return (Assembly)panwPBQZX1PYFrGraR(ad79a2s8Kyt1);
	}

	public static string A3Bw33WQsAj8(object object_3, object nnNRyX94WuneASC)
	{
		return (string)HfHRmDhdhYs4wklCgy(mZGZFtCk8ZteGnriPt(TKo3jR4Wy0f7iArnop(object_3), nnNRyX94WuneASC));
	}

	public static byte[] b5b9fPUm85Y8wEnZkn(object x6QqdT8iu3, int y320QuBn872At29Ahr)
	{
		_ = 0;
		if (!KKJn191vwjxs5BG2kJ())
		{
			if (H67Qj8cSwxv939qE8E())
			{
			}
			switch (2)
			{
			case 0:
			case 3:
				break;
			case 1:
			case 2:
				goto IL_003b;
			default:
				goto IL_0047;
			}
		}
		byte[] array = new byte[y320QuBn872At29Ahr];
		goto IL_003b;
		IL_003b:
		Stream stream = (Stream)XUTSsdvqsPLyb4DXBL(object_0, x6QqdT8iu3);
		goto IL_0047;
		IL_0047:
		try
		{
			if (stream != null)
			{
				Stream stream2 = new DeflateStream(stream, CompressionMode.Decompress);
				try
				{
					kjC4uXFXClOQ93x15T(stream2, array, 0, y320QuBn872At29Ahr);
					return array;
				}
				finally
				{
					if (stream2 != null)
					{
						xo7eHLztoNCFIclgll(stream2);
					}
				}
			}
			return null;
		}
		finally
		{
			if (stream != null)
			{
				xo7eHLztoNCFIclgll(stream);
			}
		}
	}

	private static Guid y4wNp2up8P(object H9sIh4g5Y2)
	{
		byte[] b = (byte[])Wq27ceAAn7NZBvfTbC7(Krm8tmAHFXNueoeGn5s(H9sIh4g5Y2));
		return new Guid(b);
	}

	private static byte[] smethod_7(object bqm85fD71Z3sKUe4m3o)
	{
		return (byte[])Ueoj0fASOwsf8a6IxMs(VSw65XAVWEAQotnghnt(), k9cNBDAqZbbyxe6GTUv(bqm85fD71Z3sKUe4m3o));
	}

	private unsafe static byte[] smethod_8(object wNNfN363XU9xRbNXD)
	{
		YO78E83l2CIoIaliGE6(wNNfN363XU9xRbNXD, out *(byte[]*)(&wNNfN363XU9xRbNXD));
		return (byte[])wNNfN363XU9xRbNXD;
	}

	private static void YO78E83l2CIoIaliGE6(object object_3, out byte[] iPLCa4UIl8lI4)
	{
		iPLCa4UIl8lI4 = (byte[])qw6kNnAlbGXUZKAQyJI(n9u8K8AibN8tkHRhxd8(), object_3);
	}

	public Class0()
	{
		TlCrwaAGQpL8yPB8W29(this);
	}

	internal static object jOs8dpBmsUgLmjt6dh(object object_3)
	{
		return sETR73CKc3KF9oa(object_3);
	}

	internal static Type lDT3NUn8aOfLuMo7jD(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static bool KKJn191vwjxs5BG2kJ()
	{
		return true;
	}

	internal static bool H67Qj8cSwxv939qE8E()
	{
		return false;
	}

	internal static object nCsjo1acifFV6iyU8m(object object_3)
	{
		return ((Assembly)object_3).GetManifestResourceNames();
	}

	internal static object XYN3ttRtGDbKKwhtuf(object object_3, object object_4)
	{
		return ((Regex)object_3).Match((string)object_4);
	}

	internal static bool FANTMw7hP17mPeiyX2(object object_3)
	{
		return ((Group)object_3).Success;
	}

	internal static object TKo3jR4Wy0f7iArnop(object object_3)
	{
		return ((Match)object_3).Groups;
	}

	internal static object mZGZFtCk8ZteGnriPt(object object_3, object object_4)
	{
		return ((GroupCollection)object_3)[(string)object_4];
	}

	internal static object HfHRmDhdhYs4wklCgy(object object_3)
	{
		return ((Capture)object_3).Value;
	}

	internal static void qHM3M26gkerFtAj950()
	{
		yV8UKIfTbdh59t9WM();
	}

	internal static object LhtsW93CY7nEa3ZqBt()
	{
		return rXfqkgMXQlAV9P();
	}

	internal static void SX0hS3TbCUV17NtXNg(object object_3, object object_4)
	{
		((AppDomain)object_3).AssemblyResolve += (ResolveEventHandler?)object_4;
	}

	internal static object wFndIs2l6Rhpau4hlp()
	{
		return AppDomain.CurrentDomain;
	}

	internal static object vU9vqHwsXtf5lJPCNi(object object_3, object object_4)
	{
		return (string?)object_3 + (string?)object_4;
	}

	internal static object LXf2EZIfv25gmFhjDi(object object_3, object object_4)
	{
		return string.Format((string)object_3, (object?[])object_4);
	}

	internal static object oLMaCPgyZXUgMU36o3(object object_3)
	{
		return vpwc9Oku4C(object_3);
	}

	internal static object rPPYXmy8rekO5WRN5L(object object_3)
	{
		return ((ResolveEventArgs)object_3).Name;
	}

	internal static object ke3HUv05Fxuf81Oc48(object object_3)
	{
		return yAoRBagQ9p8(object_3);
	}

	internal static object imjD1qEQbRGKqk1sHO(object object_3)
	{
		return X77sFH6YOIPTb83W0W6(object_3);
	}

	internal static object O0G6xaLU32n5uRs6Nx(object object_3)
	{
		return ((string)object_3).ToCharArray();
	}

	internal static void NjTJKCmeZoVkkLRWuV(object object_3)
	{
		Array.Reverse((Array)object_3);
	}

	internal static int KuAoxsKe5goVb9Dp91(object object_3)
	{
		return ((string)object_3).Length;
	}

	internal static object pyUjpkedT1UFRW58jv(object object_3, int int_1, int int_2)
	{
		return ((string)object_3).Substring(int_1, int_2);
	}

	internal static byte jF46q0jgdDBo6H3YPZ(object object_3, int int_1)
	{
		return Convert.ToByte((string?)object_3, int_1);
	}

	internal static object ySP7SsbTg6o1m5KAEi()
	{
		return Encoding.ASCII;
	}

	internal static object FfME9uXDNKl3saYcp4(object object_3, object object_4)
	{
		return ((Encoding)object_3).GetString((byte[])object_4);
	}

	internal static object n3ZQoRt0MQl6wWZmI9(int int_1)
	{
		return fOSQRU543WA9F1(int_1);
	}

	internal static Guid ktriwBMJioi5Cmmo71(object object_3)
	{
		return y4wNp2up8P(object_3);
	}

	internal static object WjDuybZUsXlFRyuWqe(object object_3, int int_1)
	{
		return ((GroupCollection)object_3)[int_1];
	}

	internal static object q5dTRS9wHu42xbfY6D(object object_3)
	{
		return h6l1n2OELZRSgcfHo(object_3);
	}

	internal static bool pmUMOWxriuEXUaDUN6(object object_3, object object_4)
	{
		return ((string)object_3).Contains((string)object_4);
	}

	internal static int zSIRcdWq8QTJ7W9CZG(object object_3)
	{
		return smethod_5(object_3);
	}

	internal static object qB9xAvruFXkoQ3yPZd(object object_3, int y320QuBn872At29Ahr)
	{
		return b5b9fPUm85Y8wEnZkn(object_3, y320QuBn872At29Ahr);
	}

	internal static object uNDVEZ59F0aew1HJAC(object object_3)
	{
		return smethod_6(object_3);
	}

	internal static bool EUd0bkoJ90Xp61q80c(object object_3, object object_4)
	{
		return (Assembly?)object_3 != (Assembly?)object_4;
	}

	internal static void WAjeDVNDGNh0TXgjai(object object_3)
	{
		Monitor.Exit(object_3);
	}

	internal static object HpO0VjJNQv1qii77P9(object object_3, object object_4, object object_5, object object_6)
	{
		return (string?)object_3 + (string?)object_4 + (string?)object_5 + (string?)object_6;
	}

	internal static int QTAcLWPVJ71PDEEkSy(object object_3)
	{
		return int.Parse((string)object_3);
	}

	internal static object iZySd0DDT55eMvqVTn(object object_3)
	{
		return string.Concat((string?[])object_3);
	}

	internal static object YxuATBkkHtt8UmrSBM(object object_3, object object_4)
	{
		return A3Bw33WQsAj8(object_3, object_4);
	}

	internal static object panwPBQZX1PYFrGraR(object object_3)
	{
		return Assembly.Load((byte[])object_3);
	}

	internal static object XUTSsdvqsPLyb4DXBL(object object_3, object object_4)
	{
		return ((Assembly)object_3).GetManifestResourceStream((string)object_4);
	}

	internal static int kjC4uXFXClOQ93x15T(object object_3, object object_4, int int_1, int int_2)
	{
		return ((Stream)object_3).Read((byte[])object_4, int_1, int_2);
	}

	internal static void xo7eHLztoNCFIclgll(object object_3)
	{
		((IDisposable)object_3).Dispose();
	}

	internal static object Krm8tmAHFXNueoeGn5s(object object_3)
	{
		return smethod_7(object_3);
	}

	internal static object Wq27ceAAn7NZBvfTbC7(object object_3)
	{
		return smethod_8(object_3);
	}

	internal static object VSw65XAVWEAQotnghnt()
	{
		return Encoding.UTF8;
	}

	internal static object k9cNBDAqZbbyxe6GTUv(object object_3)
	{
		return ((string)object_3).ToLowerInvariant();
	}

	internal static object Ueoj0fASOwsf8a6IxMs(object object_3, object object_4)
	{
		return ((Encoding)object_3).GetBytes((string)object_4);
	}

	internal static object n9u8K8AibN8tkHRhxd8()
	{
		return MD5.Create();
	}

	internal static object qw6kNnAlbGXUZKAQyJI(object object_3, object object_4)
	{
		return ((HashAlgorithm)object_3).ComputeHash((byte[])object_4);
	}

	internal static void TlCrwaAGQpL8yPB8W29(object object_3)
	{
		object_3._002Ector();
	}
}
