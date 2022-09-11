using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Xml;

internal class Class30 : Class27
{
	private int int_0;

	private XmlReader xmlReader_0;

	private Stream0 stream0_0;

	private bool bool_0;

	private string string_0;

	internal override XmlReader XmlReader_0
	{
		get
		{
			if (xmlReader_0 == null && 0 == 0)
			{
				throw Delegate57.smethod_0(Delegate173.smethod_0(this), "Reading has not commenced yet");
			}
			return xmlReader_0;
		}
	}

	public Class30(GClass16 gclass16_1)
		: base(gclass16_1)
	{
		int_0 = 0;
	}

	public override void Dispose()
	{
		Class6 @class = Delegate61.smethod_0(Delegate51.smethod_0(Delegate173.smethod_0(this)));
		try
		{
			Delegate533.smethod_0(this);
		}
		finally
		{
			if (@class != null || 1 == 0)
			{
				((IDisposable)@class).Dispose();
			}
		}
		Delegate303.smethod_0(this);
	}

	private void method_12()
	{
		if (stream0_0 != null || 1 == 0)
		{
			while (true)
			{
				int num = 5;
				int num2 = Class8.smethod_0(42);
				while (true)
				{
					num2 ^= 0x66;
					while (true)
					{
						int num3 = Class8.smethod_0(42);
						int num4 = -10;
						while (true)
						{
							num4 ^= 0x68;
							while (true)
							{
								int num5 = 11;
								int num6 = -13;
								while (true)
								{
									num6 ^= 0x69;
									while (true)
									{
										int num7 = 4;
										int num8 = 1;
										while (true)
										{
											num8 ^= 0x66;
											int num9 = 6;
											int num10 = -11;
											num10 = -105;
											while (true)
											{
												IL_0203:
												num9 ^= 0x65;
												while (true)
												{
													num10 = GEventArgs2.smethod_0(46);
													while (true)
													{
														switch (num10 ^ 0x62)
														{
														case -108:
															num10 = GEventArgs2.smethod_0(49);
															continue;
														case -107:
															goto end_IL_0040;
														case -106:
															goto IL_01f8;
														case -105:
															goto IL_0203;
														}
														break;
													}
													continue;
													end_IL_0040:
													break;
												}
												switch (num9)
												{
												case 99:
													goto IL_0072;
												case 100:
													goto IL_01eb;
												case 101:
													goto IL_01f3;
												case 102:
													goto end_IL_0203;
												}
												num10 = -12;
												num10 = -106;
												goto IL_01f8;
												IL_01c0:
												num4 = Class8.smethod_0(58);
												num5 = 10;
												goto IL_01cc;
												IL_01eb:
												num8 = 0;
												num9 = 3;
												continue;
												IL_01f3:
												num9 = 0;
												continue;
												IL_0072:
												switch (num8)
												{
												case 102:
													goto IL_0094;
												case 103:
													goto IL_01e4;
												case 100:
													goto IL_020f;
												case 101:
													goto end_IL_0217;
												}
												num9 = 1;
												continue;
												IL_020f:
												num8 = 2;
												break;
												IL_0094:
												switch (num7)
												{
												case 108:
													break;
												case 107:
													goto IL_01d3;
												case 109:
													goto IL_01e1;
												default:
													goto IL_0214;
												case 110:
													goto end_IL_022b;
												}
												switch (num6)
												{
												case -103:
													goto IL_00d5;
												case -102:
													goto IL_01cc;
												case -105:
													goto IL_0233;
												case -104:
													goto end_IL_023d;
												}
												num7 = 3;
												goto IL_01e4;
												IL_0214:
												num8 = 3;
												break;
												IL_01e1:
												num7 = 5;
												goto IL_01e4;
												IL_01d3:
												num6 = Class8.smethod_0(37);
												num7 = 6;
												goto IL_01e4;
												IL_0233:
												num6 = -2;
												goto end_IL_022b;
												IL_00d5:
												switch (num5)
												{
												case 103:
													break;
												case 104:
													goto IL_00fc;
												case 102:
													goto IL_01c0;
												default:
													goto IL_0239;
												case 105:
													goto end_IL_0246;
												}
												num5 = 4;
												goto IL_01cc;
												IL_0239:
												num6 = -15;
												goto end_IL_022b;
												IL_00fc:
												switch (num4)
												{
												case -101:
													goto IL_011d;
												case -98:
													goto IL_01bb;
												case -100:
													goto IL_025a;
												case -99:
													goto end_IL_025d;
												}
												num5 = 5;
												goto IL_01cc;
												IL_025a:
												num4 = -12;
												goto end_IL_0246;
												IL_011d:
												switch (num3)
												{
												case -105:
													break;
												case -104:
													goto IL_01ab;
												case -103:
													goto IL_01b8;
												default:
													goto IL_0250;
												case -102:
													goto end_IL_0264;
												}
												switch (num2)
												{
												case -107:
													goto IL_015e;
												case -104:
													goto IL_01a6;
												case -105:
													goto IL_0276;
												case -106:
													goto end_IL_0279;
												}
												num3 = Class55.smethod_1(72);
												goto IL_01bb;
												IL_0250:
												num4 = GEventArgs2.smethod_0(40);
												goto end_IL_0246;
												IL_01b8:
												num3 = -16;
												goto IL_01bb;
												IL_01cc:
												num5 ^= 0x63;
												goto IL_01d3;
												IL_0276:
												num2 = -15;
												goto end_IL_0264;
												IL_015e:
												switch (num)
												{
												case 104:
													break;
												case 105:
													goto IL_018b;
												case 106:
													goto IL_01a4;
												default:
													goto IL_0271;
												case 107:
													goto end_IL_0280;
												}
												stream0_0.Dispose();
												num = 7;
												goto IL_01a6;
												IL_0271:
												num2 = -16;
												goto end_IL_0264;
												IL_01a4:
												num = 6;
												goto IL_01a6;
												IL_018b:
												Delegate79.smethod_0(Delegate51.smethod_0(Delegate173.smethod_0(this)), "Closing log");
												num = 4;
												goto IL_01a6;
												IL_01f8:
												num9 = 6;
												num10 = -11;
												num10 = -105;
												continue;
												IL_01a6:
												num ^= 0x6C;
												goto IL_01ab;
												IL_01ab:
												num2 = Class8.smethod_0(58);
												num3 = -13;
												goto IL_01bb;
												IL_01e4:
												num7 ^= 0x68;
												goto IL_01eb;
												IL_01bb:
												num3 ^= 0x69;
												goto IL_01c0;
												continue;
												end_IL_0203:
												break;
											}
											continue;
											end_IL_0217:
											break;
										}
										continue;
										end_IL_022b:
										break;
									}
									continue;
									end_IL_023d:
									break;
								}
								continue;
								end_IL_0246:
								break;
							}
							continue;
							end_IL_025d:
							break;
						}
						continue;
						end_IL_0264:
						break;
					}
					continue;
					end_IL_0279:
					break;
				}
				continue;
				end_IL_0280:
				break;
			}
			stream0_0 = null;
		}
		if (xmlReader_0 != null || 1 == 0)
		{
			((IDisposable)xmlReader_0).Dispose();
			xmlReader_0 = null;
		}
	}

	public override bool vmethod_0(Enum10 enum10_0)
	{
		Class6 @class = Delegate61.smethod_0(Delegate51.smethod_0(Delegate173.smethod_0(this)));
		try
		{
			bool flag;
			bool flag2;
			GException2 gException = default(GException2);
			do
			{
				flag = Delegate534.smethod_0(this);
				flag2 = false;
				if (!flag || false || ((!Delegate295.smethod_0(this, "failure")) ? true : false))
				{
					continue;
				}
				while (true)
				{
					int num = Class55.smethod_1(72);
					int num2 = 11;
					while (true)
					{
						num2 ^= 0x6C;
						while (true)
						{
							int num3 = 14;
							int num4 = -15;
							while (true)
							{
								num4 ^= 0x6B;
								while (true)
								{
									int num5 = GEventArgs2.smethod_0(44);
									int num6 = -5;
									while (true)
									{
										num6 ^= 0x61;
										int num7 = Class8.smethod_0(47);
										int num8 = -10;
										num8 = -105;
										while (true)
										{
											IL_0201:
											num7 ^= 0x6C;
											num8 = GEventArgs2.smethod_0(40);
											while (true)
											{
												switch (num8 ^ 0x61)
												{
												case -106:
													num8 = GEventArgs2.smethod_0(46);
													continue;
												default:
													num8 = GEventArgs2.smethod_0(40);
													continue;
												case -108:
													break;
												case -107:
													goto IL_01f0;
												case -105:
													goto IL_0201;
												}
												break;
											}
											switch (num7)
											{
											case -105:
												goto IL_009f;
											case -104:
												goto IL_01db;
											case -103:
												goto IL_01ea;
											case -102:
												goto end_IL_0201;
											}
											num8 = -12;
											num8 = -107;
											goto IL_01f0;
											IL_01a1:
											num ^= 0x68;
											goto IL_01b0;
											IL_01b0:
											num2 = 10;
											num3 = 13;
											goto IL_01b8;
											IL_01ea:
											num7 = -11;
											continue;
											IL_009f:
											switch (num6)
											{
											case -103:
												goto IL_00c7;
											case -102:
												goto IL_01d4;
											case -104:
												goto IL_0216;
											case -105:
												goto end_IL_0225;
											}
											num7 = Class55.smethod_1(71);
											continue;
											IL_0216:
											num6 = Class8.smethod_0(57);
											break;
											IL_00c7:
											switch (num5)
											{
											case -97:
												break;
											case -96:
												goto IL_01c1;
											case -95:
												goto IL_01c7;
											default:
												goto IL_0221;
											case -94:
												goto end_IL_023f;
											}
											switch (num4)
											{
											case -104:
												goto IL_010e;
											case -102:
												goto IL_01b8;
											case -105:
												goto IL_024e;
											case -103:
												goto end_IL_025d;
											}
											num5 = Class9.smethod_0(101);
											goto IL_01d4;
											IL_0221:
											num6 = -10;
											break;
											IL_01c1:
											num5 = -51;
											goto IL_01d4;
											IL_01c7:
											num4 = Class8.smethod_0(58);
											num5 = -49;
											goto IL_01d4;
											IL_024e:
											num4 = Class8.smethod_0(38);
											goto end_IL_023f;
											IL_010e:
											switch (num3)
											{
											case 104:
												break;
											case 105:
												goto IL_01aa;
											case 106:
												goto IL_01b0;
											default:
												goto IL_0259;
											case 107:
												goto end_IL_0266;
											}
											switch (num2)
											{
											case 102:
												goto IL_014d;
											case 103:
												goto IL_01a1;
											case 100:
												goto IL_0270;
											case 101:
												goto end_IL_0279;
											}
											num3 = 12;
											goto IL_01b8;
											IL_0259:
											num4 = -14;
											goto end_IL_023f;
											IL_01aa:
											num3 = 15;
											goto IL_01b8;
											IL_01d4:
											num5 ^= 0x6D;
											goto IL_01db;
											IL_0270:
											num2 = 8;
											goto end_IL_0266;
											IL_014d:
											switch (num)
											{
											case -104:
												break;
											case -103:
												goto IL_0176;
											case -102:
												goto IL_0183;
											case -101:
												goto IL_0195;
											default:
												goto IL_0275;
											case -100:
												goto IL_02ad;
											}
											num = -16;
											goto IL_01a1;
											IL_0275:
											num2 = 9;
											goto end_IL_0266;
											IL_0195:
											if ((enum10_0 & Enum10.flag_0) != 0)
											{
												num = -12;
												goto IL_01a1;
											}
											if (0 == 0)
											{
												goto end_IL_0282;
											}
											goto IL_02ad;
											IL_01db:
											num6 = GEventArgs2.smethod_0(43);
											num7 = -10;
											continue;
											IL_01f0:
											num7 = Class8.smethod_0(47);
											num8 = -10;
											num8 = -105;
											continue;
											IL_02ad:
											throw gException;
											IL_0183:
											Delegate536.smethod_0(Delegate173.smethod_0(this), gException);
											num = -13;
											goto IL_01a1;
											IL_0176:
											gException = Delegate535.smethod_0(this);
											num = -14;
											goto IL_01a1;
											IL_01b8:
											num3 ^= 0x66;
											goto IL_01c7;
											continue;
											end_IL_0201:
											break;
										}
										continue;
										end_IL_0225:
										break;
									}
									continue;
									end_IL_023f:
									break;
								}
								continue;
								end_IL_025d:
								break;
							}
							continue;
							end_IL_0266:
							break;
						}
						continue;
						end_IL_0279:
						break;
					}
					continue;
					end_IL_0282:
					break;
				}
				flag2 = true;
			}
			while (flag2 ? true : false);
			return flag;
		}
		finally
		{
			if (@class != null || 1 == 0)
			{
				((IDisposable)@class).Dispose();
			}
		}
	}

	private bool method_13()
	{
		int num = 50;
		bool flag = default(bool);
		do
		{
			if (xmlReader_0 == null || 1 == 0)
			{
				Delegate537.smethod_0(this);
			}
			try
			{
				if ((flag = xmlReader_0.Read()) || 1 == 0)
				{
					int_0++;
					Delegate45.smethod_0(Delegate51.smethod_0(Delegate173.smethod_0(this)), "Read node {0}: {1} {2}{3}{4}", new object[5]
					{
						int_0,
						xmlReader_0.NodeType,
						xmlReader_0.Name,
						(((!xmlReader_0.HasValue) ? true : false) || string.IsNullOrEmpty(xmlReader_0.Name) || false || string.IsNullOrEmpty(xmlReader_0.Value) || 1 == 0) ? string.Empty : "=",
						xmlReader_0.Value
					});
					Delegate538.smethod_0(Delegate173.smethod_0(this));
				}
				else
				{
					Delegate79.smethod_0(Delegate51.smethod_0(Delegate173.smethod_0(this)), "Cannot read");
					if (!bool_0 && 0 == 0)
					{
						bool_0 = true;
						Delegate533.smethod_0(this);
					}
					Delegate169.smethod_0(Delegate173.smethod_0(this), null);
				}
			}
			catch (XmlException exception_)
			{
				Delegate533.smethod_0(this);
				if (!bool_0 && 0 == 0)
				{
					Delegate79.smethod_0(Delegate51.smethod_0(Delegate173.smethod_0(this)), "Error parsing session log file, but it is not closed yet, will retry");
					goto IL_01ff;
				}
				goto IL_0266;
				IL_0188:
				int num2;
				int num4;
				int num3;
				while (true)
				{
					IL_0188_2:
					num2 ^= 0x61;
					num3 = Class8.smethod_0(37);
					while (true)
					{
						switch (num3 ^ 0x6A)
						{
						case -102:
							break;
						case -99:
							goto IL_0188_2;
						case -100:
							num3 = GEventArgs2.smethod_0(49);
							continue;
						default:
							num3 = Class8.smethod_0(37);
							continue;
						case -101:
							goto IL_0216;
						}
						break;
					}
					switch (num2)
					{
					case -97:
						break;
					default:
						goto IL_01d1;
					case -96:
						goto IL_01db;
					case -95:
						goto end_IL_0188;
					case -94:
						goto IL_0249;
					}
					num2 = -2;
					continue;
					IL_022c:
					num4 = GEventArgs2.smethod_0(43);
					goto IL_0249;
					IL_0216:
					num2 = Class10.smethod_0(98);
					num3 = -9;
					num3 = -99;
					continue;
					IL_01db:
					switch (num4)
					{
					case -103:
						goto IL_022c;
					case -102:
						goto IL_0237;
					case -100:
						goto IL_023f;
					case -101:
						goto IL_0266;
					case -99:
					{
						Delegate539.smethod_0(this);
						string text = "Error parsing session log file";
						Thread.Sleep(200);
						string text2 = Delegate540.smethod_0(Delegate173.smethod_0(this));
						if (!string.IsNullOrEmpty(text2) && 0 == 0)
						{
							text = text + " - " + text2;
						}
						throw Delegate82.smethod_0(Delegate173.smethod_0(this), text, exception_);
					}
					}
					num2 = -64;
					continue;
					IL_023f:
					if (flag)
					{
						num4 = -6;
						goto IL_0249;
					}
					goto end_IL_0136;
					IL_01d1:
					num3 = -15;
					num3 = -101;
					goto IL_0216;
					IL_0237:
					flag = false;
					num4 = -3;
					goto IL_0249;
					continue;
					end_IL_0188:
					break;
				}
				goto IL_01ff;
				IL_01ff:
				num4 = Class8.smethod_0(47);
				num2 = Class9.smethod_0(99);
				goto IL_0188;
				IL_0266:
				Delegate169.smethod_0(Delegate173.smethod_0(this), null);
				num4 = -4;
				goto IL_0249;
				IL_0249:
				num4 ^= 0x61;
				num2 = Class10.smethod_0(98);
				num3 = -9;
				num3 = -99;
				goto IL_0188;
				end_IL_0136:;
			}
			if (flag || false || (bool_0 ? true : false))
			{
				continue;
			}
			Delegate45.smethod_0(Delegate51.smethod_0(Delegate173.smethod_0(this)), "Waiting for log update and dispatching events for {0}", new object[1] { num });
			while (true)
			{
				int num5 = GEventArgs2.smethod_0(49);
				switch (num5 ^ 0x6A)
				{
				default:
					continue;
				case -100:
					Delegate168.smethod_0(Delegate173.smethod_0(this), num);
					num5 = -12;
					num5 = -98;
					goto case -98;
				case -98:
					if (num >= 500)
					{
						break;
					}
					num5 = -11;
					num5 = -97;
					goto case -97;
				case -97:
					num *= 2;
					break;
				case -99:
					while (true)
					{
						num5 = -9;
						num5 = -99;
					}
				}
				break;
			}
		}
		while (!flag && 0 == 0 && ((!bool_0) ? true : false));
		if (flag || 1 == 0)
		{
			Delegate539.smethod_0(this);
		}
		return flag;
	}

	private void method_14()
	{
		if ((!Delegate44.smethod_0(Delegate51.smethod_0(Delegate173.smethod_0(this)))) ? true : false)
		{
			return;
		}
		try
		{
			StreamReader streamReader = new StreamReader(new FileStream(Delegate69.smethod_0(Delegate173.smethod_0(this)), FileMode.Open, FileAccess.Read, FileShare.ReadWrite), Encoding.UTF8);
			try
			{
				string text = streamReader.ReadToEnd();
				if (string_0 != null || 1 == 0)
				{
					if ((!(string_0 != text)) ? true : false)
					{
						Delegate79.smethod_0(Delegate51.smethod_0(Delegate173.smethod_0(this)), "Log contents has not changed");
						return;
					}
					goto IL_01c2;
				}
				goto IL_02d4;
				IL_01c2:
				int num = Class55.smethod_1(71);
				int num2 = 2;
				goto IL_01f0;
				IL_01cf:
				num2 = 0;
				goto IL_01f0;
				IL_01f0:
				num2 ^= 0x64;
				goto IL_01ff;
				IL_01ff:
				int num3 = 6;
				int num4 = -16;
				goto IL_0206;
				IL_02d4:
				Delegate45.smethod_0(Delegate51.smethod_0(Delegate173.smethod_0(this)), "Log contents:\n{0}", new object[1] { text });
				num = -10;
				goto IL_02cd;
				IL_02cd:
				num ^= 0x61;
				goto IL_02b1;
				IL_02b1:
				num2 = 1;
				num3 = 5;
				goto IL_02a8;
				IL_02a8:
				num3 ^= 0x62;
				goto IL_0291;
				IL_0291:
				num4 = GEventArgs2.smethod_0(40);
				int num5 = 12;
				goto IL_0288;
				IL_0288:
				num5 ^= 0x67;
				goto IL_0275;
				IL_0275:
				int num6 = 15;
				int num7 = 5;
				goto IL_026c;
				IL_026c:
				num7 ^= 0x6A;
				goto IL_025c;
				IL_025c:
				int num8 = 6;
				int num9 = 1;
				goto IL_0250;
				IL_0250:
				int num10;
				while (true)
				{
					IL_0250_2:
					num9 ^= 0x64;
					while (true)
					{
						num10 = Class8.smethod_0(41);
						switch (num10 ^ 0x67)
						{
						case -102:
							goto end_IL_0082;
						case -101:
							goto IL_0245;
						case -99:
							goto IL_0250_2;
						case -100:
							while (true)
							{
								num10 = -5;
								num10 = -100;
							}
						}
						continue;
						end_IL_0082:
						break;
					}
					switch (num9)
					{
					case 98:
						goto IL_00d5;
					case 99:
						goto IL_022c;
					case 101:
						goto end_IL_0250;
					case 100:
						goto IL_025c;
					}
					num10 = -4;
					num10 = -101;
					goto IL_0245;
					IL_021e:
					num8 = 5;
					break;
					IL_0245:
					num9 = 6;
					num10 = -6;
					num10 = -99;
					continue;
					IL_022c:
					num9 = 7;
					continue;
					IL_00d5:
					switch (num8)
					{
					case 109:
						goto IL_00f7;
					case 110:
						goto IL_021e;
					case 111:
						goto IL_0223;
					case 112:
						goto IL_026c;
					}
					num9 = 0;
					continue;
					end_IL_0250:
					break;
				}
				goto IL_0231;
				IL_0215:
				num6 ^= 0x66;
				goto IL_0223;
				IL_027e:
				num5 = 15;
				goto IL_0288;
				IL_0223:
				num7 = 7;
				num8 = 27;
				goto IL_0231;
				IL_0231:
				num8 ^= 0x6B;
				num9 = 6;
				num10 = -6;
				num10 = -99;
				goto IL_0250;
				IL_02a0:
				num3 = 4;
				goto IL_02a8;
				IL_0269:
				num7 = 4;
				goto IL_026c;
				IL_00f7:
				switch (num7)
				{
				case 109:
					goto IL_0119;
				case 111:
					goto IL_0215;
				case 108:
					goto IL_0264;
				case 110:
					goto IL_0275;
				}
				num8 = 4;
				goto IL_0231;
				IL_0264:
				num7 = 6;
				goto IL_026c;
				IL_0119:
				switch (num6)
				{
				case 104:
					break;
				case 105:
					goto IL_0141;
				case 106:
					goto IL_020d;
				default:
					goto IL_0269;
				case 107:
					goto IL_0288;
				}
				num6 = 14;
				goto IL_0215;
				IL_0141:
				switch (num5)
				{
				case 105:
					goto IL_0164;
				case 107:
					goto IL_0206;
				case 106:
					goto IL_0284;
				case 104:
					goto IL_0291;
				}
				num6 = 12;
				goto IL_0215;
				IL_0284:
				num5 = 13;
				goto IL_0288;
				IL_0164:
				switch (num4)
				{
				case -103:
					break;
				case -102:
					goto IL_01f9;
				case -101:
					goto IL_01ff;
				default:
					goto IL_027e;
				case -100:
					goto IL_02a8;
				}
				switch (num3)
				{
				case 100:
					goto IL_01a3;
				case 103:
					goto IL_01f0;
				case 101:
					goto IL_02a5;
				case 102:
					goto IL_02b1;
				}
				num4 = -9;
				goto IL_0206;
				IL_01f9:
				num4 = -10;
				goto IL_0206;
				IL_020d:
				num5 = 14;
				num6 = 13;
				goto IL_0215;
				IL_02a5:
				num3 = 7;
				goto IL_02a8;
				IL_01a3:
				switch (num2)
				{
				case 99:
					break;
				case 100:
					goto IL_01cf;
				case 101:
					goto IL_01d4;
				default:
					goto IL_02a0;
				case 102:
					goto IL_02cd;
				}
				goto IL_01c2;
				IL_01d4:
				switch (num)
				{
				case -106:
					goto IL_02b9;
				case -105:
					goto IL_02c3;
				case -107:
					goto IL_02d4;
				case -104:
					return;
				}
				num2 = 7;
				goto IL_01f0;
				IL_02c3:
				string_0 = text;
				num = -7;
				goto IL_02cd;
				IL_02b9:
				num = GEventArgs2.smethod_0(46);
				goto IL_02cd;
				IL_0206:
				num4 ^= 0x6C;
				goto IL_020d;
			}
			finally
			{
				if (streamReader != null || 1 == 0)
				{
					((IDisposable)streamReader).Dispose();
				}
			}
		}
		catch (Exception ex)
		{
			Delegate45.smethod_0(Delegate51.smethod_0(Delegate173.smethod_0(this)), "Error logging log contents [{0}]", new object[1] { ex.Message });
		}
	}

	private void method_15()
	{
		if (bool_0 || 1 == 0)
		{
			throw new InvalidOperationException("Log was closed already");
		}
		try
		{
			Delegate79.smethod_0(Delegate51.smethod_0(Delegate173.smethod_0(this)), "Opening log without write sharing");
			while (true)
			{
				int num = 12;
				int num2 = -5;
				while (true)
				{
					num2 ^= 0x62;
					while (true)
					{
						int num3 = 10;
						int num4 = 6;
						while (true)
						{
							num4 ^= 0x63;
							while (true)
							{
								int num5 = GEventArgs2.smethod_0(44);
								int num6 = 14;
								while (true)
								{
									num6 ^= 0x66;
									int num7 = 8;
									int num8 = -55;
									num8 = -96;
									while (true)
									{
										IL_01ea:
										num7 ^= 0x67;
										while (true)
										{
											num8 = GEventArgs2.smethod_0(46);
											while (true)
											{
												switch (num8 ^ 0x69)
												{
												case -97:
													num8 = GEventArgs2.smethod_0(49);
													continue;
												case -98:
													goto end_IL_005e;
												case -99:
													goto IL_008b;
												case -96:
													goto IL_01ea;
												}
												break;
											}
											continue;
											end_IL_005e:
											break;
										}
										switch (num7)
										{
										case 110:
											goto IL_009b;
										case 111:
											goto IL_00a4;
										case 109:
											goto IL_01e3;
										case 112:
											goto end_IL_01ea;
										}
										num8 = -12;
										num8 = -99;
										goto IL_008b;
										IL_01c1:
										num3 ^= 0x6D;
										goto IL_01d5;
										IL_01d5:
										num4 = 1;
										num5 = -49;
										goto IL_01dc;
										IL_00a4:
										switch (num6)
										{
										case 101:
											goto IL_00c7;
										case 104:
											goto IL_01dc;
										case 103:
											goto IL_01fb;
										case 102:
											goto end_IL_01fe;
										}
										num7 = 10;
										continue;
										IL_01fb:
										num6 = 1;
										break;
										IL_00c7:
										switch (num5)
										{
										case -97:
											break;
										case -96:
											goto IL_01ca;
										case -95:
											goto IL_01d5;
										default:
											goto IL_01f6;
										case -94:
											goto end_IL_0212;
										}
										switch (num4)
										{
										case 98:
											goto IL_0109;
										case 101:
											goto IL_01c1;
										case 99:
											goto IL_0226;
										case 100:
											goto end_IL_0229;
										}
										num5 = -52;
										goto IL_01dc;
										IL_01f6:
										num6 = 0;
										break;
										IL_01ca:
										num5 = Class9.smethod_0(106);
										goto IL_01dc;
										IL_01e3:
										num6 = 3;
										num7 = 23;
										continue;
										IL_0226:
										num4 = 0;
										goto end_IL_0212;
										IL_0109:
										switch (num3)
										{
										case 102:
											break;
										case 103:
											goto IL_0131;
										case 101:
											goto IL_01b5;
										default:
											goto IL_0221;
										case 104:
											goto end_IL_0232;
										}
										num3 = 11;
										goto IL_01c1;
										IL_0221:
										num4 = 7;
										goto end_IL_0212;
										IL_0131:
										switch (num2)
										{
										case -105:
											goto IL_0150;
										case -103:
											goto IL_01b0;
										case -104:
											goto IL_0246;
										case -106:
											goto end_IL_024a;
										}
										num3 = 8;
										goto IL_01c1;
										IL_0246:
										num2 = -6;
										goto end_IL_0232;
										IL_0150:
										switch (num)
										{
										case 109:
											break;
										case 110:
											goto IL_0196;
										case 111:
											goto IL_01a1;
										case 112:
											goto IL_01a6;
										default:
											goto IL_023b;
										case 113:
											goto end_IL_0253;
										}
										stream0_0 = Delegate541.smethod_0(Delegate173.smethod_0(this), Delegate69.smethod_0(Delegate173.smethod_0(this)), FileMode.Open, FileAccess.Read, FileShare.Read);
										num = 17;
										goto IL_01b0;
										IL_023b:
										num2 = Class55.smethod_1(71);
										goto end_IL_0232;
										IL_01a6:
										bool_0 = true;
										num = 15;
										goto IL_01b0;
										IL_01a1:
										num = 14;
										goto IL_01b0;
										IL_0196:
										Delegate539.smethod_0(this);
										num = 16;
										goto IL_01b0;
										IL_008b:
										num7 = 8;
										num8 = -55;
										num8 = -96;
										continue;
										IL_01b0:
										num ^= 0x61;
										goto IL_01b5;
										IL_01b5:
										num2 = GEventArgs2.smethod_0(40);
										num3 = 5;
										goto IL_01c1;
										IL_01dc:
										num5 ^= 0x6D;
										goto IL_01e3;
										IL_009b:
										num7 = 9;
										continue;
										end_IL_01ea:
										break;
									}
									continue;
									end_IL_01fe:
									break;
								}
								continue;
								end_IL_0212:
								break;
							}
							continue;
							end_IL_0229:
							break;
						}
						continue;
						end_IL_0232:
						break;
					}
					continue;
					end_IL_024a:
					break;
				}
				continue;
				end_IL_0253:
				break;
			}
		}
		catch (IOException)
		{
			Delegate79.smethod_0(Delegate51.smethod_0(Delegate173.smethod_0(this)), "Opening log with write sharing");
			while (true)
			{
				IL_0277:
				int num9 = Class8.smethod_0(39);
				while (true)
				{
					switch (num9 ^ 0x69)
					{
					case -105:
						goto IL_029f;
					case -106:
						stream0_0 = Delegate541.smethod_0(Delegate173.smethod_0(this), Delegate69.smethod_0(Delegate173.smethod_0(this)), FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						num9 = -2;
						num9 = -105;
						goto IL_029f;
					case -104:
						while (true)
						{
							num9 = -15;
							num9 = -104;
						}
					case -103:
						goto end_IL_027f;
					}
					goto IL_0277;
					IL_029f:
					bool_0 = false;
					num9 = Class8.smethod_0(37);
					continue;
					end_IL_027f:
					break;
				}
				break;
			}
		}
		Delegate79.smethod_0(Delegate51.smethod_0(Delegate173.smethod_0(this)), "Log opened");
		xmlReader_0 = XmlReader.Create(stream0_0);
		int num10 = int_0;
		Delegate45.smethod_0(Delegate51.smethod_0(Delegate173.smethod_0(this)), "Skipping {0} nodes", new object[1] { num10 });
		while (true)
		{
			if (num10 > 0)
			{
				if (!xmlReader_0.Read() && 0 == 0)
				{
					break;
				}
				num10--;
				continue;
			}
			return;
		}
		throw Delegate57.smethod_0(Delegate173.smethod_0(this), "Read less nodes than in previous log parsing");
	}
}
