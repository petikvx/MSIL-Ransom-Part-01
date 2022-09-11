using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using antlr;

namespace Underline.My.Resources;

[CompilerGenerated]
[StandardModule]
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
[HideModuleName]
internal sealed class Resources
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			if (object.ReferenceEquals(resourceManager_0, null) || 1 == 0)
			{
				ResourceManager resourceManager = default(ResourceManager);
				while (true)
				{
					int num = Class40.smethod_2(54);
					int num2 = -2;
					while (true)
					{
						num2 ^= 0x4C;
						while (true)
						{
							int num3 = Class24.smethod_0(46);
							int num4 = -64;
							while (true)
							{
								num4 ^= 0x5E;
								while (true)
								{
									int num5 = 62;
									int num6 = Class40.smethod_2(61);
									while (true)
									{
										num6 ^= 0x57;
										while (true)
										{
											int num7 = ANTLRPanicException.smethod_0(96);
											int num8 = 14;
											while (true)
											{
												num8 ^= 0x66;
												int num9 = 8;
												int num10 = -16;
												num10 = -89;
												while (true)
												{
													IL_0221:
													num9 ^= 0x5F;
													while (true)
													{
														num10 = Class24.smethod_0(53);
														while (true)
														{
															switch (num10 ^ 0x57)
															{
															case -90:
																num10 = Class40.smethod_2(60);
																continue;
															case -91:
																goto end_IL_0045;
															case -92:
																goto IL_0072;
															case -89:
																goto IL_0221;
															}
															break;
														}
														continue;
														end_IL_0045:
														break;
													}
													switch (num9)
													{
													case 87:
														goto IL_0082;
													case 88:
														goto IL_0216;
													case 89:
														goto IL_021b;
													case 90:
														goto end_IL_0221;
													}
													num10 = -13;
													num10 = -92;
													goto IL_0072;
													IL_021b:
													num8 = 1;
													num9 = 5;
													continue;
													IL_020d:
													num7 ^= 0x62;
													goto IL_021b;
													IL_0216:
													num9 = 7;
													continue;
													IL_0082:
													switch (num8)
													{
													case 103:
														goto IL_00a4;
													case 104:
														goto IL_020d;
													case 101:
														goto IL_022d;
													case 102:
														goto end_IL_0235;
													}
													num9 = 6;
													continue;
													IL_022d:
													num8 = 3;
													break;
													IL_00a4:
													switch (num7)
													{
													case -94:
														break;
													case -93:
														goto IL_00cc;
													case -92:
														goto IL_01fb;
													default:
														goto IL_0232;
													case -91:
														goto end_IL_0249;
													}
													num7 = -64;
													goto IL_020d;
													IL_0232:
													num8 = 0;
													break;
													IL_00cc:
													switch (num6)
													{
													case -88:
														goto IL_00ef;
													case -85:
														goto IL_01f4;
													case -87:
														goto IL_025e;
													case -86:
														goto end_IL_0262;
													}
													num7 = -58;
													goto IL_020d;
													IL_025e:
													num6 = -2;
													goto end_IL_0249;
													IL_00ef:
													switch (num5)
													{
													case 103:
														break;
													case 104:
														goto IL_0117;
													case 102:
														goto IL_01e7;
													default:
														goto IL_0258;
													case 105:
														goto end_IL_026b;
													}
													num5 = 49;
													goto IL_01f4;
													IL_0258:
													num6 = -3;
													goto end_IL_0249;
													IL_0117:
													switch (num4)
													{
													case -99:
														goto IL_013a;
													case -98:
														goto IL_01e0;
													case -101:
														goto IL_027a;
													case -100:
														goto end_IL_0284;
													}
													num5 = 48;
													goto IL_01f4;
													IL_027a:
													num4 = -59;
													goto end_IL_026b;
													IL_013a:
													switch (num3)
													{
													case -76:
														break;
													case -77:
														goto IL_01c8;
													case -75:
														goto IL_01d7;
													default:
														goto IL_0280;
													case -74:
														goto end_IL_028d;
													}
													switch (num2)
													{
													case -81:
														goto IL_0179;
													case -78:
														goto IL_01c3;
													case -80:
														goto IL_02a2;
													case -79:
														goto end_IL_02a6;
													}
													num3 = -23;
													goto IL_01e0;
													IL_0280:
													num4 = -62;
													goto end_IL_026b;
													IL_01d7:
													num3 = ANTLRPanicException.smethod_0(87);
													goto IL_01e0;
													IL_01fb:
													num6 = Class24.smethod_0(57);
													num7 = Form0.smethod_0(100);
													goto IL_020d;
													IL_02a2:
													num2 = -4;
													goto end_IL_028d;
													IL_0179:
													switch (num)
													{
													case -85:
														break;
													case -84:
														goto IL_01a1;
													case -83:
														goto IL_01c0;
													default:
														goto IL_029c;
													case -82:
														goto end_IL_02af;
													}
													resourceManager_0 = resourceManager;
													num = -1;
													goto IL_01c3;
													IL_029c:
													num2 = -3;
													goto end_IL_028d;
													IL_01c0:
													num = -4;
													goto IL_01c3;
													IL_01a1:
													resourceManager = new ResourceManager("Underline.Resources", typeof(Resources).Assembly);
													num = -6;
													goto IL_01c3;
													IL_0072:
													num9 = 8;
													num10 = -16;
													num10 = -89;
													continue;
													IL_01c3:
													num ^= 0x51;
													goto IL_01c8;
													IL_01c8:
													num2 = Class15.smethod_0(66);
													num3 = -20;
													goto IL_01e0;
													IL_01f4:
													num5 ^= 0x56;
													goto IL_01fb;
													IL_01e0:
													num3 ^= 0x5A;
													goto IL_01e7;
													IL_01e7:
													num4 = ANTLRPanicException.smethod_0(99);
													num5 = 63;
													goto IL_01f4;
													continue;
													end_IL_0221:
													break;
												}
												continue;
												end_IL_0235:
												break;
											}
											continue;
											end_IL_0249:
											break;
										}
										continue;
										end_IL_0262:
										break;
									}
									continue;
									end_IL_026b:
									break;
								}
								continue;
								end_IL_0284:
								break;
							}
							continue;
							end_IL_028d:
							break;
						}
						continue;
						end_IL_02a6:
						break;
					}
					continue;
					end_IL_02af:
					break;
				}
			}
			return resourceManager_0;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo CultureInfo_0
	{
		get
		{
			return cultureInfo_0;
		}
		set
		{
			cultureInfo_0 = value;
		}
	}

	internal static Bitmap Bitmap_0
	{
		get
		{
			//IL_0192: Unknown result type (might be due to invalid IL or missing references)
			//IL_0198: Expected O, but got Unknown
			Bitmap result = default(Bitmap);
			object objectValue = default(object);
			while (true)
			{
				int num = 53;
				int num2 = 63;
				while (true)
				{
					num2 ^= 0x64;
					while (true)
					{
						int num3 = Class40.smethod_2(58);
						int num4 = -14;
						while (true)
						{
							num4 ^= 0x5F;
							while (true)
							{
								int num5 = Class40.smethod_2(58);
								int num6 = 1;
								while (true)
								{
									num6 ^= 0x5A;
									while (true)
									{
										int num7 = 57;
										int num8 = 10;
										while (true)
										{
											num8 ^= 0x63;
											int num9 = 58;
											int num10 = -52;
											num10 = -84;
											while (true)
											{
												IL_0204:
												num9 ^= 0x65;
												while (true)
												{
													num10 = Form0.smethod_0(90);
													switch (num10 ^ 0x60)
													{
													case -85:
														goto end_IL_0007;
													case -87:
														goto IL_0055;
													case -84:
														goto IL_0204;
													case -86:
														while (true)
														{
															num10 = -54;
															num10 = -86;
														}
													}
													continue;
													end_IL_0007:
													break;
												}
												switch (num9)
												{
												case 93:
													goto IL_0066;
												case 95:
													goto IL_006f;
												case 94:
													goto IL_01fe;
												case 96:
													goto end_IL_0204;
												}
												num10 = -55;
												num10 = -87;
												goto IL_0055;
												IL_01fe:
												num8 = 5;
												num9 = 5;
												continue;
												IL_01e9:
												num5 ^= 0x5A;
												goto IL_01f0;
												IL_006f:
												switch (num8)
												{
												case 102:
													goto IL_0092;
												case 105:
													goto IL_01f7;
												case 103:
													goto IL_0216;
												case 104:
													goto end_IL_0219;
												}
												num9 = 59;
												continue;
												IL_0216:
												num8 = 4;
												break;
												IL_0092:
												switch (num7)
												{
												case 90:
													break;
												case 91:
													goto IL_00ba;
												case 89:
													goto IL_01f0;
												default:
													goto IL_0210;
												case 92:
													goto end_IL_022e;
												}
												num7 = 56;
												goto IL_01f7;
												IL_0210:
												num8 = 11;
												break;
												IL_00ba:
												switch (num6)
												{
												case 89:
													goto IL_00dd;
												case 91:
													goto IL_01e9;
												case 88:
													goto IL_0238;
												case 90:
													goto end_IL_0240;
												}
												num7 = 59;
												goto IL_01f7;
												IL_0238:
												num6 = 2;
												goto end_IL_022e;
												IL_00dd:
												switch (num5)
												{
												case -89:
													break;
												case -87:
													goto IL_0105;
												case -88:
													goto IL_01d7;
												default:
													goto IL_023d;
												case -86:
													goto end_IL_0249;
												}
												num5 = -3;
												goto IL_01e9;
												IL_023d:
												num6 = 0;
												goto end_IL_022e;
												IL_0105:
												switch (num4)
												{
												case -84:
													goto IL_0128;
												case -83:
													goto IL_01d0;
												case -85:
													goto IL_0257;
												case -86:
													goto end_IL_0266;
												}
												num5 = -14;
												goto IL_01e9;
												IL_0257:
												num4 = -12;
												goto end_IL_0249;
												IL_0128:
												switch (num3)
												{
												case -92:
													break;
												case -91:
													goto IL_0150;
												case -93:
													goto IL_01c4;
												default:
													goto IL_025d;
												case -90:
													goto end_IL_026f;
												}
												num3 = -14;
												goto IL_01d0;
												IL_025d:
												num4 = ANTLRPanicException.smethod_0(77);
												goto end_IL_0249;
												IL_0150:
												switch (num2)
												{
												case 89:
													goto IL_016f;
												case 91:
													goto IL_01bf;
												case 90:
													goto IL_0283;
												case 88:
													goto end_IL_0286;
												}
												num3 = -11;
												goto IL_01d0;
												IL_0283:
												num2 = 62;
												goto end_IL_026f;
												IL_016f:
												switch (num)
												{
												case 96:
													break;
												case 98:
													goto IL_019d;
												case 99:
													goto IL_01bc;
												default:
													goto IL_027e;
												case 97:
												case 100:
													return result;
												}
												result = (Bitmap)objectValue;
												num = 54;
												goto IL_01bf;
												IL_027e:
												num2 = 60;
												goto end_IL_026f;
												IL_01bc:
												num = 52;
												goto IL_01bf;
												IL_019d:
												objectValue = RuntimeHelpers.GetObjectValue(Delegate16.smethod_0().GetObject("dvoxrd", cultureInfo_0));
												num = 55;
												goto IL_01bf;
												IL_0055:
												num9 = 58;
												num10 = -52;
												num10 = -84;
												continue;
												IL_01bf:
												num ^= 0x57;
												goto IL_01c4;
												IL_01c4:
												num2 = 61;
												num3 = Class24.smethod_0(56);
												goto IL_01d0;
												IL_01f0:
												num6 = 3;
												num7 = 62;
												goto IL_01f7;
												IL_0066:
												num9 = 56;
												continue;
												IL_01d0:
												num3 ^= 0x56;
												goto IL_01d7;
												IL_01d7:
												num4 = Class40.smethod_2(58);
												num5 = Class24.smethod_0(56);
												goto IL_01e9;
												IL_01f7:
												num7 ^= 0x62;
												goto IL_01fe;
												continue;
												end_IL_0204:
												break;
											}
											continue;
											end_IL_0219:
											break;
										}
										continue;
										end_IL_022e:
										break;
									}
									continue;
									end_IL_0240:
									break;
								}
								continue;
								end_IL_0249:
								break;
							}
							continue;
							end_IL_0266:
							break;
						}
						continue;
						end_IL_026f:
						break;
					}
					continue;
					end_IL_0286:
					break;
				}
			}
		}
	}

	internal static Bitmap Bitmap_1
	{
		get
		{
			//IL_0126: Unknown result type (might be due to invalid IL or missing references)
			//IL_012c: Expected O, but got Unknown
			Bitmap result = default(Bitmap);
			object objectValue = default(object);
			while (true)
			{
				int num = 1;
				int num2 = 9;
				while (true)
				{
					num2 ^= 0x6D;
					while (true)
					{
						int num3 = ANTLRPanicException.smethod_0(93);
						int num4 = -1;
						while (true)
						{
							num4 ^= 0x61;
							while (true)
							{
								int num5 = 16;
								int num6 = 12;
								while (true)
								{
									num6 ^= 0x65;
									while (true)
									{
										int num7 = 12;
										int num8 = Class40.smethod_2(62);
										while (true)
										{
											switch (num8 ^ 0x67)
											{
											case -98:
												break;
											case -101:
												goto IL_001b;
											default:
												num8 = Class40.smethod_2(61);
												continue;
											case -100:
												goto end_IL_017c;
											case -99:
												while (true)
												{
													num8 = -6;
													num8 = -99;
												}
											}
											goto IL_0006;
											IL_001b:
											switch (num7)
											{
											case 103:
												break;
											case 104:
												goto IL_003f;
											case 105:
												goto IL_0166;
											default:
												goto IL_019f;
											case 106:
												goto end_IL_01a7;
											}
											num7 = 3;
											goto IL_0006;
											IL_019f:
											num8 = -5;
											num8 = -100;
											break;
											IL_003f:
											switch (num6)
											{
											case 104:
												goto IL_005f;
											case 105:
												goto IL_015f;
											case 102:
												goto IL_01b6;
											case 103:
												goto end_IL_01be;
											}
											num7 = 13;
											goto IL_0006;
											IL_01b6:
											num6 = 3;
											goto end_IL_01a7;
											IL_005f:
											switch (num5)
											{
											case 96:
												break;
											case 97:
												goto IL_014c;
											case 98:
												goto IL_0152;
											default:
												goto IL_01bb;
											case 99:
												goto end_IL_01c7;
											}
											switch (num4)
											{
											case -100:
												goto IL_00a1;
											case -98:
												goto IL_0143;
											case -101:
												goto IL_01d1;
											case -99:
												goto end_IL_01e0;
											}
											num5 = 18;
											goto IL_015f;
											IL_01bb:
											num6 = 2;
											goto end_IL_01a7;
											IL_014c:
											num5 = 17;
											goto IL_015f;
											IL_015f:
											num5 ^= 0x70;
											goto IL_0166;
											IL_01d1:
											num4 = Class24.smethod_0(50);
											goto end_IL_01c7;
											IL_00a1:
											switch (num3)
											{
											case -95:
												break;
											case -94:
												goto IL_00c6;
											case -96:
												goto IL_0137;
											default:
												goto IL_01dc;
											case -93:
												goto end_IL_01e9;
											}
											num3 = -63;
											goto IL_0143;
											IL_01dc:
											num4 = -4;
											goto end_IL_01c7;
											IL_00c6:
											switch (num2)
											{
											case 99:
												goto IL_00e5;
											case 100:
												goto IL_0132;
											case 97:
												goto IL_01f7;
											case 98:
												goto end_IL_01ff;
											}
											num3 = -64;
											goto IL_0143;
											IL_01f7:
											num2 = 12;
											goto end_IL_01e9;
											IL_00e5:
											switch (num)
											{
											case 108:
												break;
											case 110:
												goto IL_0125;
											case 111:
												goto IL_0130;
											default:
												goto IL_01fc;
											case 109:
											case 112:
												return result;
											}
											objectValue = RuntimeHelpers.GetObjectValue(Delegate16.smethod_0().GetObject("Dpool", cultureInfo_0));
											num = 3;
											goto IL_0132;
											IL_01fc:
											num2 = 15;
											goto end_IL_01e9;
											IL_0130:
											num = 2;
											goto IL_0132;
											IL_0125:
											result = (Bitmap)objectValue;
											num = 0;
											goto IL_0132;
											IL_0006:
											num7 ^= 0x64;
											num8 = Class40.smethod_2(61);
											continue;
											IL_0132:
											num ^= 0x6D;
											goto IL_0137;
											IL_0137:
											num2 = 14;
											num3 = ANTLRPanicException.smethod_0(99);
											goto IL_0143;
											IL_0152:
											num4 = Class40.smethod_2(54);
											num5 = 19;
											goto IL_015f;
											IL_0166:
											num6 = 13;
											num7 = 14;
											goto IL_0006;
											IL_0143:
											num3 ^= 0x60;
											goto IL_0152;
											continue;
											end_IL_017c:
											break;
										}
										continue;
										end_IL_01a7:
										break;
									}
									continue;
									end_IL_01be:
									break;
								}
								continue;
								end_IL_01c7:
								break;
							}
							continue;
							end_IL_01e0:
							break;
						}
						continue;
						end_IL_01e9:
						break;
					}
					continue;
					end_IL_01ff:
					break;
				}
			}
		}
	}
}
