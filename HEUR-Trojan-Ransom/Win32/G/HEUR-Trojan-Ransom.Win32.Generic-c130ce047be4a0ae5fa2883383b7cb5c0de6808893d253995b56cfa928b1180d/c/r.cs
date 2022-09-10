using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace c;

internal sealed class r
{
	internal struct n
	{
		public string y;

		public Version w;

		public string r;

		public string k;

		public n(string string_0)
		{
			w = null;
			r = string.Empty;
			k = string.Empty;
			y = string.Empty;
			Array array = new char[1];
			((char[])array)[0] = ',';
			object obj = global::c.n.q(string_0, array as char[], 357, 316);
			for (int i = 0; i < ((string[])obj).Length; i++)
			{
				IEquatable<string> equatable = (obj as string[])[i];
				IEquatable<string> equatable2 = f.x((string)equatable, 'Ϯ', 915);
				if (e.p.l((string)equatable2, t.x(10, 427466965, 1), 155, 244))
				{
					w = n.smethod_4(t.z((string)equatable2, 8, 326, 'Ũ'));
				}
				else if (e.p.l(equatable2 as string, t.h(6, 1517859039, '8'), 9, 102))
				{
					r = t.z(equatable2 as string, 8, 379, 'ŕ');
					if (global::c.n.p(r, t.h(2, 1517859013, '\u008f'), 7, 113))
					{
						r = string.Empty;
					}
				}
				else if (e.p.l(equatable2 as string, t.x(4, 427466975, 0), 541, 626))
				{
					k = t.z(equatable2 as string, 15, 303, 'ā');
					if (n.smethod_5(k, t.x(12, 427466955, 6)))
					{
						k = string.Empty;
					}
				}
				else
				{
					y = (string)equatable2;
				}
			}
		}

		public string p(bool bool_0)
		{
			char[] array = e.e.k;
			object obj = default(object);
			int num3 = default(int);
			while (true)
			{
				int num = -653141653;
				while (true)
				{
					uint num2;
					int num4;
					int num6;
					switch ((num2 = (uint)num ^ 0xE3D71C36u) % 10u)
					{
					case 9u:
						a.k((StringBuilder)obj, y, 195, 145);
						num = ((int)num2 * -1032538129) ^ -1097051831;
						continue;
					case 7u:
						while (true)
						{
							switch (num3)
							{
							case 7:
								break;
							default:
								goto end_IL_0091;
							case 2:
								goto IL_00ca;
							case 6:
								goto IL_00e6;
							case 5:
							case 10:
								a.k(obj as StringBuilder, t.h(0, 1517859058, 'a'), 94, 12);
								num3 = 9;
								goto case 9;
							case 9:
								e.h(obj as StringBuilder, (object)w, (short)773, 827);
								num3 = 4;
								goto case 4;
							case 4:
								a.k(obj as StringBuilder, t.x(11, 427466946, 2), 693, 743);
								num3 = 3;
								goto case 3;
							case 3:
								a.k(obj as StringBuilder, (e.m.s(r, 'Ɔ', 'ǋ') == 0) ? t.h(2, 1517859013, '\u0080') : r, 122, 40);
								goto case 8;
							case 8:
								n.smethod_1(obj as StringBuilder, t.h(1, 1517859020, ' '));
								num3 = 0;
								goto case 0;
							case 0:
							case 1:
								n.smethod_1((StringBuilder)obj, (n.smethod_2(k) == 0) ? t.x(15, 427466954, 7) : k);
								return n.smethod_3((object)(StringBuilder)obj);
							}
							if (m.k<Version, Version>(w, null, 'Ǵ', 471))
							{
								num3 = array[554] - 43443;
								continue;
							}
							char num5 = array[35];
							e.e.k[543] = (char)((e.e.k[543] + e.e.k[429]) & 'l');
							num3 = num5 - 4482;
							continue;
							end_IL_0091:
							break;
						}
						num = -1925909842;
						continue;
					case 4u:
						goto IL_00ca;
					case 2u:
						goto IL_00e6;
					case 6u:
						num4 = 7;
						goto IL_00f4;
					case 5u:
						num = ((int)num2 * -1016202532) ^ 0x40C88E0F;
						continue;
					default:
						num4 = 4;
						goto IL_00f4;
					case 1u:
						num3 = 6;
						num = ((int)num2 * -1591056072) ^ -134686773;
						continue;
					case 0u:
						num3 = 2;
						num = (int)(num2 * 1501183730) ^ -1308587425;
						continue;
					case 8u:
						break;
						IL_00f4:
						num3 = num4;
						num = -883477465;
						continue;
						IL_00e6:
						obj = n.smethod_0();
						num = -14980591;
						continue;
						IL_00ca:
						if (bool_0)
						{
							num = -1166926816;
							num6 = -1166926816;
						}
						else
						{
							num = -7087331;
							num6 = -7087331;
						}
						continue;
					}
					break;
				}
			}
		}

		static StringBuilder smethod_0()
		{
			return new StringBuilder();
		}

		static StringBuilder smethod_1(StringBuilder stringBuilder_0, string string_0)
		{
			return stringBuilder_0.Append(string_0);
		}

		static int smethod_2(string string_0)
		{
			return string_0.Length;
		}

		static string smethod_3(object object_0)
		{
			return object_0.ToString();
		}

		static Version smethod_4(string string_0)
		{
			return new Version(string_0);
		}

		static bool smethod_5(string string_0, string string_1)
		{
			return string_0 == string_1;
		}
	}

	internal const string i = "{71461f04-2faa-4bb9-a0dd-28a79101b599}";

	private const int m_v = 4;

	private static Dictionary<string, Assembly> g = new Dictionary<string, Assembly>();

	internal static bool w
	{
		get
		{
			bool result = default(bool);
			try
			{
				int num = 1;
				IComparable comparable = default(IComparable);
				while (true)
				{
					IL_0123:
					int num2 = 1089986517;
					while (true)
					{
						uint num3;
						int num4;
						switch ((num3 = (uint)num2 ^ 0x2ABAF519u) % 8u)
						{
						case 7u:
						{
							int num5;
							if (!global::c.n.p(comparable as string, t.h(8, 1517858980, '1'), 506, 396))
							{
								num2 = 1123260348;
								num5 = 1123260348;
							}
							else
							{
								num2 = 1582424504;
								num5 = 1582424504;
							}
							continue;
						}
						case 6u:
							num = 4;
							num2 = (int)(num3 * 655797472) ^ -1740090987;
							continue;
						default:
							num4 = 7;
							goto IL_005c;
						case 4u:
							switch (num)
							{
							case 4:
								break;
							default:
								goto IL_0095;
							case 1:
							case 5:
							case 6:
							case 9:
								goto IL_009c;
							case 0:
								result = true;
								return result;
							case 7:
								if (r.smethod_0(comparable as string, t.x(11, 427466992, 1)))
								{
									num = 2;
									goto case 2;
								}
								num = 8;
								goto end_IL_00ef;
							case 2:
								result = true;
								return result;
							case 8:
								goto end_IL_00ef;
							case 3:
								return result;
							}
							goto case 7u;
						case 3u:
							goto IL_009c;
						case 2u:
							num2 = (int)((num3 * 1452946212) ^ 0x12375B5D);
							continue;
						case 1u:
							num4 = 0;
							goto IL_005c;
						case 0u:
							break;
							IL_009c:
							comparable = z.u(m.s(e.p.x(e.c(547, 591), 'Ǘ', 'Ƅ'), 600, 'Ȏ'), 113, '!');
							num2 = 1323918247;
							continue;
							IL_0095:
							num2 = 951611194;
							continue;
							IL_005c:
							num = num4;
							num2 = 800986635;
							continue;
						}
						goto IL_0123;
						continue;
						end_IL_00ef:
						break;
					}
					break;
				}
			}
			catch
			{
			}
			int num6 = 5;
			while (true)
			{
				int num7 = 1550603463;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num7 ^ 0x2ABAF519u) % 4u)
					{
					case 2u:
						switch (num6)
						{
						case 1:
						case 2:
						case 3:
						case 5:
							goto IL_01b1;
						case 0:
						case 4:
							goto IL_01b3;
						}
						goto IL_017c;
					case 0u:
						break;
					case 1u:
						goto IL_01b1;
					default:
						goto IL_01b3;
						IL_01b3:
						return result;
						IL_01b1:
						return false;
					}
					break;
					IL_017c:
					num7 = (int)((num3 * 1033869769) ^ 0x8444096);
				}
			}
		}
	}

	[DllImport("kernel32")]
	private static extern bool MoveFileEx(string string_0, string string_1, int int_0);

	internal static void v()
	{
		try
		{
			p.d<AppDomain, ResolveEventHandler>(e.l.i(52, 99), c, 'Ί', 998);
		}
		catch
		{
		}
	}

	internal static Assembly c(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		//IL_073f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0740: Unknown result type (might be due to invalid IL or missing references)
		//IL_0742: Expected I4, but got Unknown
		//IL_0743: Unknown result type (might be due to invalid IL or missing references)
		//IL_0755: Expected I4, but got Unknown
		//IL_0767: Incompatible stack heights: 0 vs 1
		//IL_076e: Incompatible stack heights: 0 vs 1
		char[] k = e.e.k;
		int[] x = l.x;
		n n2 = default(n);
		ICloneable cloneable = default(ICloneable);
		bool flag = default(bool);
		bool flag2 = default(bool);
		IConvertible convertible = default(IConvertible);
		Array array = default(Array);
		int num6 = default(int);
		IEnumerable<char> enumerable = default(IEnumerable<char>);
		int num3 = default(int);
		int num7 = default(int);
		IEnumerable enumerable2 = default(IEnumerable);
		int num5 = default(int);
		int num11 = default(int);
		MarshalByRefObject marshalByRefObject = default(MarshalByRefObject);
		Array array2 = default(Array);
		Stream stream = default(Stream);
		object obj4 = default(object);
		IComparable<string> comparable = default(IComparable<string>);
		object obj = default(object);
		while (true)
		{
			int num = -1856755277;
			while (true)
			{
				int num4;
				uint num2;
				string gparam_;
				object obj6;
				int num27;
				switch ((num2 = (uint)num ^ 0xC941EA59u) % 17u)
				{
				case 16u:
					num5 = 19;
					num = (int)((num2 * 1912812384) ^ 0x1FD874D7);
					continue;
				case 15u:
					n2 = new n(global::c.g.n(resolveEventArgs_0, 899, 937));
					num = -1678908237;
					continue;
				case 14u:
					num = (int)((num2 * 1236575217) ^ 0x34F426E8);
					continue;
				default:
					num4 = 16;
					goto IL_005c;
				case 12u:
					goto IL_0068;
				case 11u:
					num5 = 24;
					num = (int)((num2 * 453620367) ^ 0x1422D861);
					continue;
				case 10u:
					goto IL_008f;
				case 9u:
					cloneable = n2.p(bool_0: false);
					num = (int)(num2 * 818981270) ^ -890907219;
					continue;
				case 8u:
					goto IL_00e8;
				case 7u:
					flag = false;
					flag2 = false;
					num = ((int)num2 * -1101916002) ^ 0x47EF923;
					continue;
				case 6u:
					while (true)
					{
						int num25;
						switch (num5)
						{
						case 24:
							break;
						case 7:
							goto IL_0068;
						case 0:
							goto IL_008f;
						case 8:
							goto IL_00e8;
						case 25:
							convertible = (array as string[])[num6 + 1];
							num5 = k[272] - 53022;
							continue;
						case 23:
							if (global::c.n.p(((string[])array)[num6], enumerable as string, 396, 506))
							{
								num5 = 25;
								goto case 25;
							}
							num5 = 21;
							goto case 21;
						case 21:
							num6 += 2;
							num5 = 18;
							goto case 18;
						case 18:
							if (num6 >= (array as string[]).Length - 1)
							{
								num5 = 2;
								goto case 2;
							}
							num5 = x[264] - 49993;
							continue;
						case 2:
							if (e.m.s((string)convertible, 'ͱ', '\u033c') > 0)
							{
								num5 = 17;
								goto case 17;
							}
							goto IL_0a8e;
						case 17:
							if (global::c.v.k((string)convertible, 0, 339, 341) != '[')
							{
								num5 = k[149] - 16619;
								continue;
							}
							num5 = 22;
							goto case 22;
						case 12:
						case 16:
							num3 += 2;
							num5 = x[68] - 40583;
							continue;
						case 14:
							if (e.m.s(convertible as string, 'ı', 'ż') == 0)
							{
								num5 = 11;
								goto case 11;
							}
							num5 = 2;
							goto case 2;
						case 11:
							if (e.m.s(n2.k, 'º', '÷') == 0)
							{
								num5 = x[154] - 30108;
								continue;
							}
							num5 = 2;
							goto case 2;
						case 13:
							if (num3 >= ((string[])array).Length - 1)
							{
								num5 = 14;
								goto case 14;
							}
							num5 = 0;
							goto IL_008f;
						case 9:
							enumerable = global::c.v.q(global::c.g.a(e.w(252, 'ë'), n2.y, 692, 757), 'ʧ', 666);
							num5 = 1;
							goto case 1;
						case 1:
							num6 = 0;
							num5 = 18;
							goto case 18;
						case 3:
							convertible = ((string[])array)[num3 + 1];
							num5 = k[284] - 49194;
							continue;
						default:
							goto IL_0334;
						case 6:
							goto IL_033e;
						case 19:
							goto IL_0394;
						case 22:
							num7 = z.r((string)convertible, ']', 456, 'ƴ');
							enumerable2 = t.dg((string)convertible, 1, num7 - 1, 'Ϻ', 'Ϊ');
							num5 = 15;
							goto case 15;
						case 15:
							flag = z.r(enumerable2 as string, 'z', 273, 'ŭ') >= 0;
							num5 = 4;
							goto case 4;
						case 4:
						case 10:
							flag2 = z.r((string)enumerable2, 't', 485, 'ƙ') >= 0;
							num5 = 20;
							goto case 20;
						case 20:
							convertible = t.z(convertible as string, num7 + 1, 239, 'Á');
							num5 = 5;
							goto case 5;
						case 5:
							{
								object obj2;
								global::c.v.c(obj2 = g, 456, 478);
								try
								{
									int num8 = 12;
									while (true)
									{
										IL_069b:
										int num9 = -539037145;
										while (true)
										{
											int num10;
											switch ((num2 = (uint)num9 ^ 0xC941EA59u) % 6u)
											{
											case 5u:
											{
												int num22;
												if (!g.ContainsKey((string)convertible))
												{
													num9 = -182356592;
													num22 = -182356592;
												}
												else
												{
													num9 = -630977782;
													num22 = -630977782;
												}
												continue;
											}
											case 4u:
												while (true)
												{
													switch (num8)
													{
													case 10:
													case 12:
														break;
													case 11:
														num8 = k[242] - 49921;
														continue;
													case 9:
														num11 = (int)e.n(marshalByRefObject as Stream, 796, 783);
														array2 = new byte[num11];
														goto case 11;
													case 5:
													case 6:
														marshalByRefObject = j.u(global::c.g.x(872, 849), (string)convertible, 689, 753);
														num8 = 0;
														goto case 0;
													case 0:
														if (marshalByRefObject is Stream)
														{
															num8 = 9;
															goto case 9;
														}
														goto end_IL_0514;
													case 4:
														b.w(marshalByRefObject as Stream, array2 as byte[], 0, num11, 159, 'Ã');
														num8 = x[261] - 31527;
														continue;
													case 3:
														if (!flag)
														{
															num8 = x[183] - 6708;
															continue;
														}
														num8 = 2;
														goto case 2;
													default:
														goto IL_0643;
													case 2:
														array2 = e.s(array2 as byte[]);
														num8 = 7;
														goto case 7;
													case 7:
													{
														object obj3 = null;
														if (!flag2)
														{
															try
															{
																int num12 = 1;
																while (true)
																{
																	IL_0728:
																	int num13 = -9578248;
																	while (true)
																	{
																		switch ((num2 = (uint)num13 ^ 0xC941EA59u) % 4u)
																		{
																		case 2u:
																			obj3 = e.u.l(array2 as byte[], 'a', 55);
																			num13 = -2120003294;
																			continue;
																		case 1u:
																			switch (num12)
																			{
																			case 0:
																			case 1:
																			case 2:
																			case 3:
																			case 4:
																				break;
																			default:
																				num13 = ((int)num2 * -253096615) ^ -866724686;
																				continue;
																			}
																			goto case 2u;
																		default:
																			goto end_IL_0707;
																		case 0u:
																			break;
																		case 3u:
																			goto end_IL_0707;
																		}
																		goto IL_0728;
																		continue;
																		end_IL_0707:
																		break;
																	}
																	break;
																}
															}
															catch (FileLoadException)
															{
																flag2 = true;
															}
															catch (BadImageFormatException)
															{
																while (true)
																{
																	IL_0769:
																	_ = -1729842466;
																	while (true)
																	{
																		_003F val = /*Error near IL_0740: Stack underflow*/^ -918427047;
																		num2 = (uint)(int)val;
																		switch (val % 3)
																		{
																		default:
																			goto end_IL_073a;
																		case 1:
																			flag2 = true;
																			_ = ((int)num2 * -1011628717) ^ -678973540;
																			continue;
																		case 2:
																			break;
																		case 0:
																			goto end_IL_073a;
																		}
																		goto IL_0769;
																		continue;
																		end_IL_073a:
																		break;
																	}
																	break;
																}
															}
														}
														int num14 = 1;
														while (true)
														{
															IL_07bc:
															int num15 = -2049470949;
															while (true)
															{
																switch ((num2 = (uint)num15 ^ 0xC941EA59u) % 3u)
																{
																case 2u:
																	switch (num14)
																	{
																	default:
																		goto IL_0792;
																	case 0:
																	case 1:
																	case 2:
																	case 3:
																	case 4:
																		break;
																	}
																	goto default;
																case 0u:
																	break;
																default:
																{
																	if (flag2)
																	{
																		try
																		{
																			int num16 = 0;
																			while (true)
																			{
																				IL_0937:
																				int num17 = -54749169;
																				while (true)
																				{
																					int num18;
																					int num19;
																					switch ((num2 = (uint)num17 ^ 0xC941EA59u) % 8u)
																					{
																					default:
																						num18 = 7;
																						goto IL_07d3;
																					case 6u:
																						while (true)
																						{
																							switch (num16)
																							{
																							case 6:
																								stream = r.smethod_6((string)obj4);
																								goto case 3;
																							case 3:
																								r.smethod_7((Stream)(stream as FileStream), (byte[])array2, 0, (array2 as byte[]).Length);
																								num16 = x[19] - 4596;
																								continue;
																							case 2:
																								goto IL_084f;
																							case 5:
																								goto IL_0879;
																							case 0:
																							case 4:
																							case 9:
																								goto IL_08b5;
																							case 8:
																								r.smethod_8((Stream)(FileStream)stream);
																								goto case 1;
																							case 1:
																								MoveFileEx(obj4 as string, null, 4);
																								MoveFileEx(comparable as string, null, 4);
																								num16 = 7;
																								goto case 7;
																							case 7:
																								obj3 = r.smethod_9(obj4 as string);
																								goto end_IL_0903;
																							}
																							break;
																						}
																						num17 = -1790791224;
																						continue;
																					case 3u:
																						goto IL_084f;
																					case 4u:
																						goto IL_0879;
																					case 1u:
																						goto IL_08b5;
																					case 5u:
																						num17 = (int)(num2 * 948722400) ^ -128314513;
																						continue;
																					case 2u:
																						num18 = k[509] - 2967;
																						goto IL_07d3;
																					case 0u:
																						break;
																						IL_08b5:
																						comparable = r.smethod_2(t.h(4, 1517858999, '\u008f'), (object)r.smethod_1(), (object)(string)convertible);
																						num16 = 5;
																						num17 = -54749169;
																						continue;
																						IL_0879:
																						r.smethod_3(comparable as string);
																						obj4 = r.smethod_4(comparable as string, n2.y, t.h(4, 1517859005, 'ò'));
																						num16 = 2;
																						num17 = -101178300;
																						continue;
																						IL_084f:
																						if (r.smethod_5(obj4 as string))
																						{
																							num17 = -308108506;
																							num19 = -308108506;
																						}
																						else
																						{
																							num17 = -1187572949;
																							num19 = -1187572949;
																						}
																						continue;
																						IL_07d3:
																						num16 = num18;
																						num17 = -54749169;
																						continue;
																					}
																					goto IL_0937;
																					continue;
																					end_IL_0903:
																					break;
																				}
																				break;
																			}
																		}
																		catch
																		{
																		}
																	}
																	int num20 = 0;
																	while (true)
																	{
																		IL_09f3:
																		int num21 = -1043400762;
																		while (true)
																		{
																			switch ((num2 = (uint)num21 ^ 0xC941EA59u) % 5u)
																			{
																			case 4u:
																				switch (num20)
																				{
																				case 0:
																				case 3:
																					goto IL_09b1;
																				case 4:
																					goto IL_09fa;
																				case 1:
																				case 2:
																				case 5:
																					goto end_IL_09ce;
																				}
																				num21 = ((int)num2 * -1281716642) ^ 0x21A1A1B5;
																				continue;
																			case 0u:
																				goto IL_09b1;
																			default:
																				goto end_IL_09ce;
																			case 3u:
																				break;
																			case 2u:
																				goto IL_09fa;
																			case 1u:
																				goto end_IL_09ce;
																				IL_09fa:
																				obj = obj3 as Assembly;
																				goto end_IL_0672;
																				IL_09b1:
																				g[convertible as string] = obj3 as Assembly;
																				num21 = -1158027998;
																				continue;
																			}
																			goto IL_09f3;
																			continue;
																			end_IL_09ce:
																			break;
																		}
																		break;
																	}
																	goto end_IL_079f;
																}
																}
																goto IL_07bc;
																IL_0792:
																num15 = (int)((num2 * 2146746050) ^ 0x1748C655);
																continue;
																end_IL_079f:
																break;
															}
															break;
														}
														goto end_IL_0514;
													}
													case 1:
													case 8:
														obj = g[(string)convertible];
														goto end_IL_0672;
													}
													break;
												}
												goto case 5u;
											default:
												num10 = k[590] - 39794;
												goto IL_0657;
											case 2u:
												num9 = (int)((num2 * 1258981847) ^ 0x5EDD3761);
												continue;
											case 1u:
												num10 = 8;
												goto IL_0657;
											case 0u:
												break;
												IL_0657:
												num8 = num10;
												num9 = -39128461;
												continue;
												IL_0643:
												num9 = -12467966;
												continue;
											}
											goto IL_069b;
											continue;
											end_IL_0672:
											break;
										}
										break;
									}
									goto IL_0ae9;
									end_IL_0514:;
								}
								finally
								{
									int num23 = 1;
									while (true)
									{
										IL_0a86:
										int num24 = -1744305613;
										while (true)
										{
											switch ((num2 = (uint)num24 ^ 0xC941EA59u) % 4u)
											{
											case 3u:
												r.smethod_10((object)(obj2 as Dictionary<string, Assembly>));
												num24 = -255690176;
												continue;
											case 2u:
												switch (num23)
												{
												case 0:
												case 1:
												case 2:
												case 3:
													break;
												default:
													num24 = ((int)num2 * -669026992) ^ 0x198B8A12;
													continue;
												case 4:
													goto end_IL_0a65;
												}
												goto case 3u;
											default:
												goto end_IL_0a65;
											case 0u:
												break;
											case 1u:
												goto end_IL_0a65;
											}
											goto IL_0a86;
											continue;
											end_IL_0a65:
											break;
										}
										break;
									}
								}
								goto IL_0a8e;
							}
							IL_0ae9:
							return (Assembly)obj;
							IL_0a8e:
							num25 = 1;
							while (true)
							{
								int num26 = -170866668;
								while (true)
								{
									switch ((num2 = (uint)num26 ^ 0xC941EA59u) % 4u)
									{
									case 1u:
										switch (num25)
										{
										case 1:
										case 4:
										case 5:
											goto IL_0ae7;
										case 0:
										case 2:
										case 3:
											goto end_IL_0ae0;
										}
										num26 = (int)((num2 * 221645021) ^ 0x661CC5A2);
										continue;
									case 0u:
										break;
									case 2u:
										goto IL_0ae7;
									default:
										goto end_IL_0ae0;
										IL_0ae7:
										return null;
									}
									break;
								}
								continue;
								end_IL_0ae0:
								break;
							}
							goto IL_0ae9;
						}
						break;
					}
					goto case 15u;
				case 0u:
					goto IL_033e;
				case 1u:
					goto IL_0394;
				case 5u:
					num = (int)((num2 * 1052689719) ^ 0x47863D41);
					continue;
				case 3u:
					num4 = 3;
					goto IL_005c;
				case 2u:
					num3 = 0;
					num = ((int)num2 * -1817379181) ^ -1366937420;
					continue;
				case 4u:
					break;
					IL_0394:
					enumerable = global::c.v.q(global::c.g.a(e.w(850, '\u0345'), (string)cloneable, 978, 915), 'Á', 252);
					num5 = 6;
					num = -258609546;
					continue;
					IL_033e:
					gparam_ = t.x(12, 427466753, 0);
					obj6 = new char[1];
					(obj6 as char[])[0] = ',';
					array = global::c.n.q(gparam_, (char[])obj6, 411, 450);
					num5 = k[267] - 51158;
					num = -205915177;
					continue;
					IL_0334:
					num = -85142513;
					continue;
					IL_00e8:
					num5 = 13;
					num = -1094954173;
					continue;
					IL_008f:
					if (global::c.n.p((array as string[])[num3], (string)enumerable, 557, 603))
					{
						num = -1446547727;
						num27 = -1446547727;
					}
					else
					{
						num = -2004005223;
						num27 = -2004005223;
					}
					continue;
					IL_0068:
					convertible = string.Empty;
					num = -1634242772;
					continue;
					IL_005c:
					num5 = num4;
					num = -205915177;
					continue;
				}
				break;
			}
		}
	}

	static bool smethod_0(string string_0, string string_1)
	{
		return string_0 == string_1;
	}

	static string smethod_1()
	{
		return Path.GetTempPath();
	}

	static string smethod_2(string string_0, object object_0, object object_1)
	{
		return string.Format(string_0, object_0, object_1);
	}

	static DirectoryInfo smethod_3(string string_0)
	{
		return Directory.CreateDirectory(string_0);
	}

	static string smethod_4(string string_0, string string_1, string string_2)
	{
		return string_0 + string_1 + string_2;
	}

	static bool smethod_5(string string_0)
	{
		return File.Exists(string_0);
	}

	static FileStream smethod_6(string string_0)
	{
		return File.OpenWrite(string_0);
	}

	static void smethod_7(Stream stream_0, byte[] byte_0, int int_0, int int_1)
	{
		stream_0.Write(byte_0, int_0, int_1);
	}

	static void smethod_8(Stream stream_0)
	{
		stream_0.Close();
	}

	static Assembly smethod_9(string string_0)
	{
		return Assembly.LoadFile(string_0);
	}

	static void smethod_10(object object_0)
	{
		Monitor.Exit(object_0);
	}
}
