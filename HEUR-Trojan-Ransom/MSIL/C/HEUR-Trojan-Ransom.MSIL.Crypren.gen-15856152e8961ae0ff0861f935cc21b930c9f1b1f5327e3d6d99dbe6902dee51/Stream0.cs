using System.IO;

internal class Stream0 : FileStream
{
	private GClass16 gclass16_0;

	public Stream0(GClass16 gclass16_1, string string_0, FileMode fileMode_0, FileAccess fileAccess_0, FileShare fileShare_0)
		: base(string_0, fileMode_0, fileAccess_0, fileShare_0)
	{
		gclass16_0 = gclass16_1;
	}

	public override int Read(byte[] array, int offset, int count)
	{
		int num = 50;
		int num2;
		do
		{
			num2 = base.Read(array, offset, count);
			if ((num2 != 0) ? true : false)
			{
				continue;
			}
			Delegate45.smethod_0(Delegate51.smethod_0(gclass16_0), "Waiting for log update and dispatching events for {0}", new object[1] { num });
			while (true)
			{
				int num3 = 26;
				int num4 = 11;
				while (true)
				{
					num4 ^= 0x58;
					while (true)
					{
						int num5 = Class10.smethod_0(84);
						int num6 = 5;
						while (true)
						{
							num6 ^= 0x56;
							while (true)
							{
								int num7 = 1;
								int num8 = -14;
								while (true)
								{
									num8 ^= 0x58;
									while (true)
									{
										int num9 = 1;
										int num10 = 6;
										while (true)
										{
											num10 ^= 0x54;
											int num11 = Class8.smethod_0(42);
											int num12 = -5;
											num12 = -82;
											while (true)
											{
												num11 ^= 0x4F;
												while (true)
												{
													num12 = Class8.smethod_0(57);
													while (true)
													{
														switch (num12 ^ 0x55)
														{
														case -84:
															break;
														default:
															goto end_IL_005a;
														case -83:
															num11 = Class8.smethod_0(42);
															num12 = -5;
															num12 = -82;
															goto end_IL_007b;
														case -82:
															goto end_IL_007b;
														case -85:
															while (true)
															{
																num12 = -2;
																num12 = -85;
															}
														}
														switch (num11)
														{
														case -80:
															goto IL_0086;
														case -79:
															goto IL_008e;
														case -81:
															goto IL_0215;
														case -78:
															goto end_IL_022f;
														}
														num12 = GEventArgs2.smethod_0(43);
														continue;
														IL_0086:
														num11 = -1;
														goto end_IL_007b;
														continue;
														end_IL_005a:
														break;
													}
													continue;
													end_IL_007b:
													break;
												}
												continue;
												IL_01f5:
												num6 = 7;
												num7 = 2;
												goto IL_01fb;
												IL_008e:
												switch (num10)
												{
												case 80:
													goto IL_00b1;
												case 82:
													goto IL_020e;
												case 79:
													goto IL_023b;
												case 81:
													goto end_IL_0244;
												}
												num11 = -32;
												continue;
												IL_023b:
												num10 = 27;
												break;
												IL_00b1:
												switch (num9)
												{
												case 88:
													break;
												case 89:
													goto IL_00d8;
												case 90:
													goto IL_0202;
												default:
													goto IL_0241;
												case 91:
													goto end_IL_025e;
												}
												num9 = 0;
												goto IL_020e;
												IL_0241:
												num10 = 5;
												break;
												IL_00d8:
												switch (num8)
												{
												case -87:
													goto IL_00fa;
												case -86:
													goto IL_01fb;
												case -89:
													goto IL_0266;
												case -88:
													goto end_IL_026f;
												}
												num9 = 2;
												goto IL_020e;
												IL_0266:
												num8 = -1;
												goto end_IL_025e;
												IL_00fa:
												switch (num7)
												{
												case 80:
													break;
												case 81:
													goto IL_0121;
												case 79:
													goto IL_01f5;
												default:
													goto IL_026b;
												case 82:
													goto end_IL_0278;
												}
												num7 = 0;
												goto IL_01fb;
												IL_026b:
												num8 = -16;
												goto end_IL_025e;
												IL_0121:
												switch (num6)
												{
												case 81:
													goto IL_0144;
												case 83:
													goto IL_01ee;
												case 80:
													goto IL_0281;
												case 82:
													goto end_IL_0289;
												}
												num7 = 31;
												goto IL_01fb;
												IL_0281:
												num6 = 6;
												goto end_IL_0278;
												IL_0144:
												switch (num5)
												{
												case -79:
													break;
												case -78:
													goto IL_016c;
												case -77:
													goto IL_01e7;
												default:
													goto IL_0286;
												case -76:
													goto end_IL_0292;
												}
												num5 = -25;
												goto IL_01ee;
												IL_0286:
												num6 = 4;
												goto end_IL_0278;
												IL_016c:
												switch (num4)
												{
												case 82:
													goto IL_018b;
												case 83:
													goto IL_01e2;
												case 80:
													goto IL_02a0;
												case 81:
													goto end_IL_02a7;
												}
												num5 = -27;
												goto IL_01ee;
												IL_02a0:
												num4 = 8;
												goto end_IL_0292;
												IL_018b:
												switch (num3)
												{
												case 81:
													break;
												case 82:
													goto IL_01b2;
												case 83:
													goto IL_01c2;
												case 84:
													goto IL_01d3;
												default:
													goto IL_02a4;
												case 85:
													goto IL_02b6;
												}
												num3 = 31;
												goto IL_01e2;
												IL_02b6:
												num *= 2;
												goto end_IL_02ae;
												IL_02a4:
												num4 = 9;
												goto end_IL_0292;
												IL_01d3:
												Delegate168.smethod_0(gclass16_0, num);
												num3 = 29;
												goto IL_01e2;
												IL_01c2:
												Delegate169.smethod_0(gclass16_0, null);
												num3 = 28;
												goto IL_01e2;
												IL_01b2:
												if (num >= 500)
												{
													goto end_IL_02ae;
												}
												num3 = 27;
												goto IL_01e2;
												IL_01fb:
												num7 ^= 0x50;
												goto IL_0202;
												IL_0215:
												num10 = 4;
												num11 = -3;
												continue;
												IL_01e2:
												num3 ^= 0x4E;
												goto IL_01e7;
												IL_01e7:
												num4 = 10;
												num5 = -30;
												goto IL_01ee;
												IL_020e:
												num9 ^= 0x58;
												goto IL_0215;
												IL_0202:
												num8 = Class55.smethod_1(72);
												num9 = 3;
												goto IL_020e;
												IL_01ee:
												num5 ^= 0x56;
												goto IL_01f5;
												continue;
												end_IL_022f:
												break;
											}
											continue;
											end_IL_0244:
											break;
										}
										continue;
										end_IL_025e:
										break;
									}
									continue;
									end_IL_026f:
									break;
								}
								continue;
								end_IL_0278:
								break;
							}
							continue;
							end_IL_0289:
							break;
						}
						continue;
						end_IL_0292:
						break;
					}
					continue;
					end_IL_02a7:
					break;
				}
				continue;
				end_IL_02ae:
				break;
			}
		}
		while ((num2 == 0) ? true : false);
		return num2;
	}
}
