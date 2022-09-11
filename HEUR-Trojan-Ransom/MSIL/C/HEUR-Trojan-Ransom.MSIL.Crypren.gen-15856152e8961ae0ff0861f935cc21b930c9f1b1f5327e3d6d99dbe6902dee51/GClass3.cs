using System;
using System.Globalization;
using System.Runtime.InteropServices;

[ComVisible(true)]
[Guid("90A290B2-C8CE-4900-8C42-7736F9E435C6")]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
public sealed class GClass3
{
	private const string string_0 = "rwxrwxrwx";

	private const string string_1 = "--s--s--t";

	private const string string_2 = "--S--S--T";

	private const char char_0 = '-';

	private int int_0;

	private bool bool_0;

	public int Int32_0
	{
		get
		{
			return int_0;
		}
		set
		{
			if (bool_0 || 1 == 0)
			{
				throw new InvalidOperationException("Cannot change read-only permissions");
			}
			if (value < 0 || value > 4095)
			{
				throw new ArgumentOutOfRangeException(string.Format(CultureInfo.CurrentCulture, "{0} is not valid numerical permissions", new object[1] { value }));
			}
			int_0 = value;
		}
	}

	public string String_0
	{
		get
		{
			return Delegate183.smethod_0(Delegate182.smethod_0(this));
		}
		set
		{
			Delegate185.smethod_0(this, Delegate184.smethod_0(value));
		}
	}

	public string String_1
	{
		get
		{
			string text = Convert.ToString(Delegate182.smethod_0(this), 8);
			return new string('0', Math.Max(3 - text.Length, 0)) + text;
		}
		set
		{
			if (value != null || 1 == 0)
			{
				while (true)
				{
					int num = 7;
					int num2 = -12;
					while (true)
					{
						num2 ^= 0x58;
						while (true)
						{
							int num3 = 57;
							int num4 = -53;
							while (true)
							{
								num4 ^= 0x61;
								while (true)
								{
									int num5 = Class10.smethod_0(98);
									int num6 = 59;
									while (true)
									{
										num6 ^= 0x61;
										while (true)
										{
											int num7 = Class8.smethod_0(37);
											int num8 = 60;
											while (true)
											{
												num8 ^= 0x62;
												int num9 = 4;
												int num10 = -12;
												num10 = -88;
												while (true)
												{
													num9 ^= 0x5A;
													while (true)
													{
														num10 = Class8.smethod_0(48);
														while (true)
														{
															switch (num10 ^ 0x5C)
															{
															case -90:
																break;
															default:
																goto end_IL_0034;
															case -91:
																num9 = 4;
																num10 = -12;
																num10 = -88;
																goto end_IL_0055;
															case -88:
																goto end_IL_0055;
															case -89:
																while (true)
																{
																	num10 = -5;
																	num10 = -89;
																}
															}
															switch (num9)
															{
															case 94:
																goto IL_0070;
															case 95:
																goto IL_01eb;
															case 96:
																goto IL_01f5;
															case 97:
																goto end_IL_01f9;
															}
															num10 = Class8.smethod_0(57);
															continue;
															IL_01f5:
															num9 = 58;
															goto end_IL_0055;
															continue;
															end_IL_0034:
															break;
														}
														continue;
														end_IL_0055:
														break;
													}
													continue;
													IL_01ba:
													num3 ^= 0x63;
													goto IL_01bf;
													IL_0070:
													switch (num8)
													{
													case 91:
														goto IL_0092;
													case 94:
														goto IL_01e4;
													case 93:
														goto IL_020b;
													case 92:
														goto end_IL_020f;
													}
													num9 = 5;
													continue;
													IL_020b:
													num8 = 63;
													break;
													IL_0092:
													switch (num7)
													{
													case -87:
														break;
													case -86:
														goto IL_00ba;
													case -88:
														goto IL_01d7;
													default:
														goto IL_0205;
													case -85:
														goto end_IL_0223;
													}
													num7 = -13;
													goto IL_01e4;
													IL_0205:
													num8 = 62;
													break;
													IL_00ba:
													switch (num6)
													{
													case 88:
														goto IL_00dd;
													case 90:
														goto IL_01d0;
													case 89:
														goto IL_0238;
													case 87:
														goto end_IL_023c;
													}
													num7 = -14;
													goto IL_01e4;
													IL_0238:
													num6 = 56;
													goto end_IL_0223;
													IL_00dd:
													switch (num5)
													{
													case -97:
														break;
													case -95:
														goto IL_0104;
													case -96:
														goto IL_01bf;
													default:
														goto IL_0232;
													case -94:
														goto end_IL_0245;
													}
													num5 = -1;
													goto IL_01d0;
													IL_0232:
													num6 = 54;
													goto end_IL_0223;
													IL_0104:
													switch (num4)
													{
													case -88:
														goto IL_0126;
													case -86:
														goto IL_01ba;
													case -87:
														goto IL_0259;
													case -89:
														goto end_IL_025c;
													}
													num5 = -64;
													goto IL_01d0;
													IL_0259:
													num4 = -56;
													goto end_IL_0245;
													IL_0126:
													switch (num3)
													{
													case 90:
														break;
													case 91:
														goto IL_01aa;
													case 92:
														goto IL_01af;
													default:
														goto IL_0254;
													case 93:
														goto end_IL_0263;
													}
													switch (num2)
													{
													case -87:
														goto IL_0162;
													case -84:
														goto IL_01a3;
													case -85:
														goto IL_0270;
													case -86:
														goto end_IL_0273;
													}
													num3 = 63;
													goto IL_01ba;
													IL_0254:
													num4 = -58;
													goto end_IL_0245;
													IL_01aa:
													num3 = 56;
													goto IL_01ba;
													IL_01d0:
													num5 ^= 0x60;
													goto IL_01d7;
													IL_0270:
													num2 = -13;
													goto end_IL_0263;
													IL_0162:
													switch (num)
													{
													case 93:
														break;
													case 94:
														goto IL_0190;
													case 95:
														goto IL_01a1;
													default:
														goto IL_026b;
													case 96:
														goto end_IL_027a;
													}
													if (value.Length != 3)
													{
														num = 4;
														goto IL_01a3;
													}
													goto IL_02aa;
													IL_026b:
													num2 = -14;
													goto end_IL_0263;
													IL_01a1:
													num = 5;
													goto IL_01a3;
													IL_0190:
													if (value.Length != 4)
													{
														num = 58;
														goto IL_01a3;
													}
													goto IL_02aa;
													IL_01bf:
													num4 = Class10.smethod_0(90);
													num5 = Class9.smethod_0(89);
													goto IL_01d0;
													IL_01e4:
													num7 ^= 0x5A;
													goto IL_01eb;
													IL_01eb:
													num8 = 57;
													num9 = 59;
													continue;
													IL_01a3:
													num ^= 0x5A;
													goto IL_01af;
													IL_01af:
													num2 = Class55.smethod_1(72);
													num3 = 62;
													goto IL_01ba;
													IL_02aa:
													Delegate185.smethod_0(this, Convert.ToInt16(value, 8));
													return;
													IL_01d7:
													num6 = 57;
													num7 = Class55.smethod_1(72);
													goto IL_01e4;
													continue;
													end_IL_01f9:
													break;
												}
												continue;
												end_IL_020f:
												break;
											}
											continue;
											end_IL_0223:
											break;
										}
										continue;
										end_IL_023c:
										break;
									}
									continue;
									end_IL_0245:
									break;
								}
								continue;
								end_IL_025c:
								break;
							}
							continue;
							end_IL_0263:
							break;
						}
						continue;
						end_IL_0273:
						break;
					}
					continue;
					end_IL_027a:
					break;
				}
			}
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "{0} is not valid octal permissions", new object[1] { value }));
		}
	}

	public bool Boolean_0
	{
		get
		{
			return Delegate186.smethod_0(this, 0);
		}
		set
		{
			Delegate187.smethod_0(this, 0, value);
		}
	}

	public bool Boolean_1
	{
		get
		{
			return Delegate186.smethod_0(this, 1);
		}
		set
		{
			Delegate187.smethod_0(this, 1, value);
		}
	}

	public bool Boolean_2
	{
		get
		{
			return Delegate186.smethod_0(this, 2);
		}
		set
		{
			Delegate187.smethod_0(this, 2, value);
		}
	}

	public bool Boolean_3
	{
		get
		{
			return Delegate186.smethod_0(this, 3);
		}
		set
		{
			Delegate187.smethod_0(this, 3, value);
		}
	}

	public bool Boolean_4
	{
		get
		{
			return Delegate186.smethod_0(this, 4);
		}
		set
		{
			Delegate187.smethod_0(this, 4, value);
		}
	}

	public bool Boolean_5
	{
		get
		{
			return Delegate186.smethod_0(this, 5);
		}
		set
		{
			Delegate187.smethod_0(this, 5, value);
		}
	}

	public bool Boolean_6
	{
		get
		{
			return Delegate186.smethod_0(this, 6);
		}
		set
		{
			Delegate187.smethod_0(this, 6, value);
		}
	}

	public bool Boolean_7
	{
		get
		{
			return Delegate186.smethod_0(this, 7);
		}
		set
		{
			Delegate187.smethod_0(this, 7, value);
		}
	}

	public bool Boolean_8
	{
		get
		{
			return Delegate186.smethod_0(this, 8);
		}
		set
		{
			Delegate187.smethod_0(this, 8, value);
		}
	}

	public bool Boolean_9
	{
		get
		{
			return Delegate186.smethod_0(this, 9);
		}
		set
		{
			Delegate187.smethod_0(this, 9, value);
		}
	}

	public bool Boolean_10
	{
		get
		{
			return Delegate186.smethod_0(this, 10);
		}
		set
		{
			Delegate187.smethod_0(this, 10, value);
		}
	}

	public bool Boolean_11
	{
		get
		{
			return Delegate186.smethod_0(this, 11);
		}
		set
		{
			Delegate187.smethod_0(this, 11, value);
		}
	}

	public GClass3()
		: this(0)
	{
	}

	public GClass3(int int_1)
	{
		Delegate185.smethod_0(this, int_1);
	}

	public override string ToString()
	{
		return Delegate188.smethod_0(this);
	}

	internal static GClass3 smethod_0(string string_3)
	{
		GClass3 gClass = Delegate189.smethod_0();
		Delegate190.smethod_0(gClass, Delegate184.smethod_0(string_3));
		gClass.bool_0 = true;
		return gClass;
	}

	internal static int smethod_1(string string_3)
	{
		if (string_3.Length != "rwxrwxrwx".Length)
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "{0} is not valid permissions string", new object[1] { string_3 }));
		}
		int num = 0;
		int num10 = default(int);
		int num11 = default(int);
		int num12 = default(int);
		while (true)
		{
			int num2 = GEventArgs2.smethod_0(43);
			int num3 = 3;
			while (true)
			{
				num3 ^= 0x58;
				while (true)
				{
					int num4 = Class8.smethod_0(42);
					int num5 = -8;
					while (true)
					{
						num5 ^= 0x5B;
						while (true)
						{
							int num6 = Class55.smethod_1(71);
							int num7 = 7;
							while (true)
							{
								num7 ^= 0x5A;
								int num8 = Class9.smethod_0(91);
								int num9 = -2;
								num9 = -90;
								while (true)
								{
									IL_01df:
									num8 ^= 0x63;
									num9 = Class8.smethod_0(47);
									while (true)
									{
										switch (num9 ^ 0x58)
										{
										default:
											num9 = Class8.smethod_0(47);
											continue;
										case -93:
											break;
										case -92:
											goto IL_01ce;
										case -90:
											goto IL_01df;
										case -91:
											while (true)
											{
												num9 = -3;
												num9 = -91;
											}
										}
										break;
									}
									switch (num8)
									{
									case -91:
										goto IL_008b;
									case -90:
										goto IL_01bf;
									case -89:
										goto IL_01c8;
									case -88:
										goto end_IL_01df;
									}
									num9 = -4;
									num9 = -92;
									goto IL_01ce;
									IL_01a4:
									num4 ^= 0x5D;
									goto IL_01ab;
									IL_01ab:
									num5 = Class8.smethod_0(47);
									num6 = -11;
									goto IL_01b8;
									IL_01c8:
									num8 = -60;
									continue;
									IL_008b:
									switch (num7)
									{
									case 90:
										goto IL_00ae;
									case 93:
										goto IL_01b8;
									case 91:
										goto IL_01f9;
									case 92:
										goto end_IL_01fc;
									}
									num8 = -59;
									continue;
									IL_01f9:
									num7 = 1;
									break;
									IL_00ae:
									switch (num6)
									{
									case -90:
										break;
									case -88:
										goto IL_00d6;
									case -89:
										goto IL_01ab;
									default:
										goto IL_01f4;
									case -87:
										goto end_IL_0216;
									}
									num6 = -6;
									goto IL_01b8;
									IL_01f4:
									num7 = 6;
									break;
									IL_00d6:
									switch (num5)
									{
									case -96:
										goto IL_00fe;
									case -93:
										goto IL_01a4;
									case -94:
										goto IL_022a;
									case -95:
										goto end_IL_0233;
									}
									num6 = Class8.smethod_0(47);
									goto IL_01b8;
									IL_022a:
									num5 = Class8.smethod_0(57);
									goto end_IL_0216;
									IL_00fe:
									switch (num4)
									{
									case -93:
										break;
									case -94:
										goto IL_0192;
									case -92:
										goto IL_01a0;
									default:
										goto IL_0224;
									case -91:
										goto end_IL_023c;
									}
									switch (num3)
									{
									case 88:
										goto IL_013c;
									case 91:
										goto IL_018b;
									case 89:
										goto IL_0250;
									case 90:
										goto end_IL_0253;
									}
									num4 = -1;
									goto IL_01a4;
									IL_0224:
									num5 = -6;
									goto end_IL_0216;
									IL_01a0:
									num4 = -7;
									goto IL_01a4;
									IL_01b8:
									num6 ^= 0x5C;
									goto IL_01bf;
									IL_0250:
									num3 = 1;
									goto end_IL_023c;
									IL_013c:
									switch (num2)
									{
									case -93:
										break;
									case -92:
										goto IL_0165;
									case -91:
										goto IL_0179;
									case -90:
										goto IL_0185;
									default:
										goto IL_024b;
									case -89:
										while (num10 >= 0)
										{
											if (string_3[num10] != '-')
											{
												num = ((string_3[num10] == "--s--s--t"[num10]) ? (num | (num11 | num12)) : ((string_3[num10] != "--S--S--T"[num10]) ? (num | num11) : (num | num12)));
											}
											num11 <<= 1;
											if (num10 % 3 == 0 && 0 == 0)
											{
												num12 <<= 1;
											}
											num10--;
										}
										return num;
									}
									num2 = -3;
									goto IL_018b;
									IL_024b:
									num3 = 2;
									goto end_IL_023c;
									IL_0185:
									num11 = 1;
									num2 = -5;
									goto IL_018b;
									IL_0179:
									num12 = 512;
									num2 = -6;
									goto IL_018b;
									IL_0165:
									num10 = string_3.Length - 1;
									num2 = Class8.smethod_0(57);
									goto IL_018b;
									IL_01ce:
									num8 = Class9.smethod_0(91);
									num9 = -2;
									num9 = -90;
									continue;
									IL_018b:
									num2 ^= 0x5E;
									goto IL_0192;
									IL_0192:
									num3 = 0;
									num4 = GEventArgs2.smethod_0(43);
									goto IL_01a4;
									IL_01bf:
									num7 = 0;
									num8 = -53;
									continue;
									end_IL_01df:
									break;
								}
								continue;
								end_IL_01fc:
								break;
							}
							continue;
							end_IL_0216:
							break;
						}
						continue;
						end_IL_0233:
						break;
					}
					continue;
					end_IL_023c:
					break;
				}
				continue;
				end_IL_0253:
				break;
			}
		}
	}

	private static string smethod_2(int int_1)
	{
		char[] array = new char["rwxrwxrwx".Length];
		int num9 = default(int);
		bool flag = default(bool);
		int num10 = default(int);
		int num11 = default(int);
		while (true)
		{
			int num = 58;
			int num2 = 63;
			while (true)
			{
				num2 ^= 0x60;
				while (true)
				{
					int num3 = 57;
					int num4 = -15;
					while (true)
					{
						num4 ^= 0x59;
						while (true)
						{
							int num5 = 4;
							int num6 = 13;
							while (true)
							{
								num6 ^= 0x57;
								int num7 = 3;
								int num8 = -54;
								num8 = -86;
								while (true)
								{
									IL_01b5:
									num7 ^= 0x58;
									num8 = Class9.smethod_0(93);
									while (true)
									{
										switch (num8 ^ 0x60)
										{
										default:
											num8 = Class9.smethod_0(93);
											continue;
										case -88:
											break;
										case -89:
											goto IL_0063;
										case -86:
											goto IL_01b5;
										case -87:
											while (true)
											{
												num8 = -55;
												num8 = -87;
											}
										}
										break;
									}
									switch (num7)
									{
									case 89:
										goto IL_0073;
									case 91:
										goto IL_007b;
									case 90:
										goto IL_01ae;
									case 92:
										goto end_IL_01b5;
									}
									num8 = -57;
									num8 = -89;
									goto IL_0063;
									IL_018f:
									num3 ^= 0x62;
									goto IL_0196;
									IL_0196:
									num4 = Class8.smethod_0(42);
									num5 = 6;
									goto IL_01a7;
									IL_007b:
									switch (num6)
									{
									case 88:
										goto IL_009d;
									case 90:
										goto IL_01a7;
									case 89:
										goto IL_01cf;
									case 87:
										goto end_IL_01d3;
									}
									num7 = 2;
									continue;
									IL_01cf:
									num6 = 14;
									break;
									IL_009d:
									switch (num5)
									{
									case 93:
										break;
									case 92:
										goto IL_0196;
									case 94:
										goto IL_01a4;
									default:
										goto IL_01ca;
									case 95:
										goto end_IL_01e7;
									}
									switch (num4)
									{
									case -89:
										goto IL_00de;
									case -88:
										goto IL_018f;
									case -91:
										goto IL_01f0;
									case -90:
										goto end_IL_01fe;
									}
									num5 = 5;
									goto IL_01a7;
									IL_01ca:
									num6 = 0;
									break;
									IL_01a4:
									num5 = 7;
									goto IL_01a7;
									IL_01ae:
									num6 = 15;
									num7 = 4;
									continue;
									IL_01f0:
									num4 = Class8.smethod_0(38);
									goto end_IL_01e7;
									IL_00de:
									switch (num3)
									{
									case 91:
										break;
									case 92:
										goto IL_0181;
									case 93:
										goto IL_0187;
									default:
										goto IL_01fb;
									case 94:
										goto end_IL_0207;
									}
									switch (num2)
									{
									case 94:
										goto IL_011d;
									case 95:
										goto IL_0178;
									case 92:
										goto IL_0211;
									case 93:
										goto end_IL_021b;
									}
									num3 = 63;
									goto IL_018f;
									IL_01fb:
									num4 = -1;
									goto end_IL_01e7;
									IL_0181:
									num3 = 62;
									goto IL_018f;
									IL_0073:
									num7 = 1;
									continue;
									IL_0211:
									num2 = 60;
									goto end_IL_0207;
									IL_011d:
									switch (num)
									{
									case 87:
										break;
									case 88:
										goto IL_0158;
									case 89:
										goto IL_0160;
									case 90:
										goto IL_0168;
									case 91:
										goto IL_016e;
									default:
										goto IL_0217;
									case 92:
										while (num9 >= 0)
										{
											char c = (array[num9] = (((flag || 1 == 0) && (int_1 & (num10 | num11)) == (num10 | num11)) ? "--s--s--t"[num9] : (((int_1 & num10) != 0 || 1 == 0) ? "rwxrwxrwx"[num9] : ((((!flag) ? true : false) || (((int_1 & num11) == 0) ? true : false)) ? '-' : "--S--S--T"[num9]))));
											num10 <<= 1;
											num9--;
											if ((flag = num9 % 3 == 2) || 1 == 0)
											{
												num11 <<= 1;
											}
										}
										return new string(array);
									}
									num9 = "rwxrwxrwx".Length - 1;
									num = 63;
									goto IL_0178;
									IL_0217:
									num2 = 61;
									goto end_IL_0207;
									IL_016e:
									num11 = 512;
									num = 59;
									goto IL_0178;
									IL_0168:
									num = 57;
									goto IL_0178;
									IL_0160:
									num10 = 1;
									num = 56;
									goto IL_0178;
									IL_0158:
									flag = true;
									num = 52;
									goto IL_0178;
									IL_0063:
									num7 = 3;
									num8 = -54;
									num8 = -86;
									continue;
									IL_0178:
									num ^= 0x63;
									goto IL_0187;
									IL_0187:
									num2 = 62;
									num3 = 60;
									goto IL_018f;
									IL_01a7:
									num5 ^= 0x59;
									goto IL_01ae;
									continue;
									end_IL_01b5:
									break;
								}
								continue;
								end_IL_01d3:
								break;
							}
							continue;
							end_IL_01e7:
							break;
						}
						continue;
						end_IL_01fe:
						break;
					}
					continue;
					end_IL_0207:
					break;
				}
				continue;
				end_IL_021b:
				break;
			}
		}
	}

	private bool method_0(int int_1)
	{
		return (Delegate182.smethod_0(this) & (1 << int_1)) != 0;
	}

	private void method_1(int int_1, bool bool_1)
	{
		if (bool_1 || 1 == 0)
		{
			Delegate185.smethod_0(this, Delegate182.smethod_0(this) | (1 << int_1));
		}
		else
		{
			Delegate185.smethod_0(this, Delegate182.smethod_0(this) & ~(1 << int_1));
		}
	}
}
