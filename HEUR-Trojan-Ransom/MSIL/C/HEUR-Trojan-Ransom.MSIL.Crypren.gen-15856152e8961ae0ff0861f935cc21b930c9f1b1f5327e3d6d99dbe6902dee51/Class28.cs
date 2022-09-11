using System;
using System.Xml;

internal class Class28 : Class27
{
	private readonly Class27 class27_0;

	private readonly string string_0;

	private readonly int int_0;

	protected bool bool_0;

	internal override XmlReader XmlReader_0 => Delegate286.smethod_0(class27_0);

	public Class28(Class27 class27_1)
		: base(Delegate301.smethod_0(class27_1))
	{
		class27_0 = class27_1;
		if (Delegate288.smethod_0(this) == XmlNodeType.Element && ((!Delegate293.smethod_0(this)) ? true : false))
		{
			string_0 = Delegate286.smethod_0(class27_0).LocalName;
			while (true)
			{
				int num = 14;
				int num2 = 1;
				while (true)
				{
					num2 ^= 0x67;
					while (true)
					{
						int num3 = Class9.smethod_0(93);
						int num4 = -53;
						while (true)
						{
							num4 ^= 0x6B;
							while (true)
							{
								int num5 = GEventArgs2.smethod_0(46);
								int num6 = -3;
								while (true)
								{
									num6 ^= 0x67;
									while (true)
									{
										int num7 = 3;
										int num8 = 4;
										while (true)
										{
											num8 ^= 0x6A;
											int num9 = Class8.smethod_0(47);
											while (true)
											{
												switch (num9 ^ 0x6C)
												{
												case -103:
													break;
												case -105:
													goto IL_005c;
												default:
													num9 = Class8.smethod_0(47);
													continue;
												case -102:
													goto end_IL_01e8;
												case -104:
													while (true)
													{
														num9 = -12;
														num9 = -104;
													}
												}
												goto IL_004b;
												IL_005c:
												switch (num8)
												{
												case 108:
													goto IL_0080;
												case 110:
													goto IL_01d3;
												case 107:
													goto IL_020b;
												case 109:
													goto end_IL_0213;
												}
												num9 = -11;
												num9 = -103;
												goto IL_004b;
												IL_020b:
												num8 = 1;
												break;
												IL_0080:
												switch (num7)
												{
												case 98:
													break;
												case 100:
													goto IL_00a7;
												case 99:
													goto IL_01c7;
												default:
													goto IL_0210;
												case 101:
													goto end_IL_0225;
												}
												num7 = 5;
												goto IL_01d3;
												IL_0210:
												num8 = 7;
												break;
												IL_00a7:
												switch (num6)
												{
												case -104:
													goto IL_00c9;
												case -102:
													goto IL_01c0;
												case -105:
													goto IL_022d;
												case -103:
													goto end_IL_023c;
												}
												num7 = 4;
												goto IL_01d3;
												IL_022d:
												num6 = Class8.smethod_0(37);
												goto end_IL_0225;
												IL_00c9:
												switch (num5)
												{
												case -98:
													break;
												case -97:
													goto IL_01a9;
												case -96:
													goto IL_01b4;
												default:
													goto IL_0238;
												case -95:
													goto end_IL_0245;
												}
												switch (num4)
												{
												case -98:
													goto IL_010a;
												case -96:
													goto IL_01a2;
												case -99:
													goto IL_0254;
												case -97:
													goto end_IL_025c;
												}
												num5 = -55;
												goto IL_01c0;
												IL_0238:
												num6 = -2;
												goto end_IL_0225;
												IL_01a9:
												num5 = GEventArgs2.smethod_0(49);
												goto IL_01c0;
												IL_01c7:
												num6 = Class8.smethod_0(39);
												num7 = 2;
												goto IL_01d3;
												IL_0254:
												num4 = -10;
												goto end_IL_0245;
												IL_010a:
												switch (num3)
												{
												case -97:
													break;
												case -96:
													goto IL_012d;
												case -98:
													goto IL_019d;
												default:
													goto IL_0259;
												case -95:
													goto end_IL_0263;
												}
												num3 = -9;
												goto IL_01a2;
												IL_0259:
												num4 = -12;
												goto end_IL_0245;
												IL_012d:
												switch (num2)
												{
												case 101:
													goto IL_0150;
												case 102:
													goto IL_0198;
												case 99:
													goto IL_0270;
												case 100:
													goto end_IL_0276;
												}
												num3 = GEventArgs2.smethod_0(49);
												goto IL_01a2;
												IL_0270:
												num2 = 4;
												goto end_IL_0263;
												IL_0150:
												switch (num)
												{
												case 100:
													break;
												case 101:
													goto IL_017a;
												case 102:
													goto IL_0195;
												default:
													goto IL_0274;
												case 103:
													return;
												}
												bool_0 = false;
												num = 12;
												goto IL_0198;
												IL_0274:
												num2 = 3;
												goto end_IL_0263;
												IL_0195:
												num = 13;
												goto IL_0198;
												IL_017a:
												int_0 = Delegate286.smethod_0(class27_0).Depth;
												num = 15;
												goto IL_0198;
												IL_004b:
												num8 = 6;
												num9 = GEventArgs2.smethod_0(49);
												continue;
												IL_0198:
												num ^= 0x6B;
												goto IL_019d;
												IL_019d:
												num2 = 2;
												num3 = -55;
												goto IL_01a2;
												IL_01c0:
												num5 ^= 0x69;
												goto IL_01c7;
												IL_01d3:
												num7 ^= 0x67;
												goto IL_004b;
												IL_01a2:
												num3 ^= 0x68;
												goto IL_01b4;
												IL_01b4:
												num4 = GEventArgs2.smethod_0(40);
												num5 = -56;
												goto IL_01c0;
												continue;
												end_IL_01e8:
												break;
											}
											continue;
											end_IL_0213:
											break;
										}
										continue;
										end_IL_0225:
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
					end_IL_0276:
					break;
				}
			}
		}
		throw new InvalidOperationException("Cannot use ElementLogReader with non-element node or empty element");
	}

	public override void Dispose()
	{
		Class6 @class = Delegate61.smethod_0(Delegate51.smethod_0(Delegate173.smethod_0(this)));
		try
		{
			Delegate302.smethod_0(this, (Enum10)0);
		}
		catch (Exception)
		{
			Delegate79.smethod_0(Delegate51.smethod_0(Delegate173.smethod_0(this)), "Swallowing exception");
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

	public override bool vmethod_0(Enum10 enum10_0)
	{
		if (bool_0 || 1 == 0)
		{
			throw new InvalidOperationException("Element already read to the end");
		}
		bool result;
		if (((result = Delegate43.smethod_0(class27_0, enum10_0)) || 1 == 0) && (Delegate304.smethod_0(this, string_0) || 1 == 0))
		{
			while (true)
			{
				int num = 6;
				int num2 = Class9.smethod_0(101);
				while (true)
				{
					num2 ^= 0x6D;
					while (true)
					{
						int num3 = 8;
						int num4 = -14;
						while (true)
						{
							num4 ^= 0x6B;
							while (true)
							{
								int num5 = Class9.smethod_0(93);
								int num6 = 14;
								while (true)
								{
									num6 ^= 0x66;
									while (true)
									{
										int num7 = GEventArgs2.smethod_0(43);
										int num8 = -10;
										while (true)
										{
											num8 ^= 0x69;
											int num9 = GEventArgs2.smethod_0(44);
											int num10 = -1;
											num10 = -104;
											while (true)
											{
												num9 ^= 0x65;
												while (true)
												{
													num10 = Class8.smethod_0(37);
													while (true)
													{
														switch (num10 ^ 0x67)
														{
														case -105:
															break;
														default:
															goto end_IL_0071;
														case -106:
															num9 = GEventArgs2.smethod_0(44);
															num10 = -1;
															num10 = -104;
															goto end_IL_0092;
														case -104:
															goto end_IL_0092;
														case -107:
															while (true)
															{
																num10 = -14;
																num10 = -107;
															}
														}
														switch (num9)
														{
														case -105:
															goto IL_00b2;
														case -104:
															goto IL_021e;
														case -103:
															goto IL_022c;
														case -102:
															goto end_IL_0230;
														}
														num10 = Class55.smethod_1(72);
														continue;
														IL_022c:
														num9 = -4;
														goto end_IL_0092;
														continue;
														end_IL_0071:
														break;
													}
													continue;
													end_IL_0092:
													break;
												}
												continue;
												IL_01fc:
												num4 = Class8.smethod_0(41);
												num5 = -55;
												goto IL_0209;
												IL_00b2:
												switch (num8)
												{
												case -99:
													goto IL_00d5;
												case -97:
													goto IL_0217;
												case -100:
													goto IL_023c;
												case -98:
													goto end_IL_024b;
												}
												num9 = -3;
												continue;
												IL_023c:
												num8 = GEventArgs2.smethod_0(40);
												break;
												IL_00d5:
												switch (num7)
												{
												case -108:
													break;
												case -107:
													goto IL_00fd;
												case -106:
													goto IL_0210;
												default:
													goto IL_0247;
												case -105:
													goto end_IL_0264;
												}
												num7 = -7;
												goto IL_0217;
												IL_0247:
												num8 = -9;
												break;
												IL_00fd:
												switch (num6)
												{
												case 102:
													goto IL_0120;
												case 104:
													goto IL_0209;
												case 101:
													goto IL_0273;
												case 103:
													goto end_IL_027b;
												}
												num7 = -5;
												goto IL_0217;
												IL_0273:
												num6 = 3;
												goto end_IL_0264;
												IL_0120:
												switch (num5)
												{
												case -98:
													break;
												case -96:
													goto IL_0148;
												case -97:
													goto IL_01fc;
												default:
													goto IL_0278;
												case -95:
													goto end_IL_0284;
												}
												num5 = -10;
												goto IL_0209;
												IL_0278:
												num6 = 1;
												goto end_IL_0264;
												IL_0148:
												switch (num4)
												{
												case -106:
													goto IL_016b;
												case -103:
													goto IL_01f7;
												case -105:
													goto IL_029e;
												case -104:
													goto end_IL_02a2;
												}
												num5 = -9;
												goto IL_0209;
												IL_029e:
												num4 = -4;
												goto end_IL_0284;
												IL_016b:
												switch (num3)
												{
												case 103:
													break;
												case 105:
													goto IL_018d;
												case 104:
													goto IL_01ec;
												default:
													goto IL_0293;
												case 106:
													goto end_IL_02ab;
												}
												num3 = 6;
												goto IL_01f7;
												IL_0293:
												num4 = Class8.smethod_0(58);
												goto end_IL_0284;
												IL_018d:
												switch (num2)
												{
												case -97:
													goto IL_01ab;
												case -95:
													goto IL_01e7;
												case -96:
													goto IL_02b8;
												case -98:
													goto end_IL_02bb;
												}
												num3 = 9;
												goto IL_01f7;
												IL_02b8:
												num2 = -51;
												goto end_IL_02ab;
												IL_01ab:
												switch (num)
												{
												case 101:
													break;
												case 102:
													goto IL_01de;
												case 103:
													goto IL_01e2;
												default:
													goto IL_02b3;
												case 104:
													goto IL_02d8;
												}
												if (Delegate305.smethod_0(this) != int_0)
												{
													goto end_IL_02c2;
												}
												num = 4;
												goto IL_01e7;
												IL_02d8:
												bool_0 = true;
												goto end_IL_02c2;
												IL_02b3:
												num2 = -13;
												goto end_IL_02ab;
												IL_01e2:
												result = false;
												num = 11;
												goto IL_01e7;
												IL_01de:
												num = 5;
												goto IL_01e7;
												IL_021e:
												num8 = Class55.smethod_1(71);
												num9 = -1;
												continue;
												IL_0209:
												num5 ^= 0x68;
												goto IL_0210;
												IL_01e7:
												num ^= 0x63;
												goto IL_01ec;
												IL_01ec:
												num2 = GEventArgs2.smethod_0(44);
												num3 = 11;
												goto IL_01f7;
												IL_0217:
												num7 ^= 0x6D;
												goto IL_021e;
												IL_0210:
												num6 = 0;
												num7 = -6;
												goto IL_0217;
												IL_01f7:
												num3 ^= 0x61;
												goto IL_01fc;
												continue;
												end_IL_0230:
												break;
											}
											continue;
											end_IL_024b:
											break;
										}
										continue;
										end_IL_0264:
										break;
									}
									continue;
									end_IL_027b:
									break;
								}
								continue;
								end_IL_0284:
								break;
							}
							continue;
							end_IL_02a2:
							break;
						}
						continue;
						end_IL_02ab:
						break;
					}
					continue;
					end_IL_02bb:
					break;
				}
				continue;
				end_IL_02c2:
				break;
			}
		}
		return result;
	}

	public void method_12(Enum10 enum10_0)
	{
		Class6 @class = Delegate61.smethod_0(Delegate51.smethod_0(Delegate173.smethod_0(this)));
		try
		{
			if (!bool_0 && 0 == 0)
			{
				while (Delegate43.smethod_0(this, enum10_0) ? true : false)
				{
				}
			}
		}
		finally
		{
			if (@class != null || 1 == 0)
			{
				((IDisposable)@class).Dispose();
			}
		}
	}
}
