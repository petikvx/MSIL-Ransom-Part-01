using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml;
using Microsoft.Win32;

[ClassInterface(ClassInterfaceType.AutoDispatch)]
[Guid("56FFC5CE-3867-4EF0-A3B5-CFFBEB99EA35")]
[ComSourceInterfaces(typeof(GInterface0))]
[ComVisible(true)]
public sealed class GClass16 : IDisposable, IReflect
{
	private delegate void Delegate0();

	[CompilerGenerated]
	private sealed class Class33
	{
		public GEventArgs0 geventArgs0_0;

		public GClass16 gclass16_0;

		internal void method_0()
		{
			Delegate489.smethod_0(gclass16_0, Delegate458.smethod_0(geventArgs0_0), Delegate461.smethod_0(geventArgs0_0));
		}
	}

	[CompilerGenerated]
	private sealed class Class34
	{
		public GEventArgs1 geventArgs1_0;

		public GClass16 gclass16_0;

		internal void method_0()
		{
			Delegate490.smethod_0(gclass16_0, geventArgs1_0);
		}
	}

	[CompilerGenerated]
	private TimeSpan timeSpan_0;

	[CompilerGenerated]
	private GClass7 gclass7_0;

	[CompilerGenerated]
	private GDelegate1 gdelegate1_0;

	[CompilerGenerated]
	private GDelegate3 gdelegate3_0;

	[CompilerGenerated]
	private GDelegate0 gdelegate0_0;

	internal const string string_0 = "http://winscp.net/schema/session/1.0";

	[CompilerGenerated]
	private Class21 class21_0;

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private Dictionary<string, string> dictionary_0;

	private Class16 class16_0;

	private DateTime dateTime_0;

	private Class28 class28_0;

	private Class30 class30_0;

	private readonly IList<GClass10> ilist_0;

	private readonly IList<Delegate0> ilist_1;

	private AutoResetEvent autoResetEvent_0;

	private bool bool_1;

	private string string_1;

	private string string_2;

	private bool bool_2;

	private bool bool_3;

	private string string_3;

	private TimeSpan timeSpan_1;

	private string string_4;

	private bool bool_4;

	private int int_0;

	private string string_5;

	private GDelegate2 gdelegate2_0;

	private int int_1;

	private bool bool_5;

	private string string_6;

	private string string_7;

	private SecureString secureString_0;

	private GClass7 gclass7_1;

	public string String_0
	{
		get
		{
			return string_1;
		}
		set
		{
			Delegate321.smethod_0(this);
			string_1 = value;
		}
	}

	public string String_1
	{
		get
		{
			return string_7;
		}
		set
		{
			Delegate321.smethod_0(this);
			string_7 = value;
		}
	}

	public SecureString SecureString_0
	{
		get
		{
			return secureString_0;
		}
		set
		{
			Delegate321.smethod_0(this);
			secureString_0 = value;
		}
	}

	public string String_2
	{
		get
		{
			return string_2;
		}
		set
		{
			Delegate321.smethod_0(this);
			string_2 = value;
		}
	}

	[Obsolete("Use AddRawConfiguration")]
	public bool Boolean_0
	{
		get
		{
			return bool_2;
		}
		set
		{
			Delegate321.smethod_0(this);
			bool_2 = value;
		}
	}

	public bool Boolean_1
	{
		get
		{
			return Delegate322.smethod_0(this);
		}
		set
		{
			Delegate321.smethod_0(this);
			bool_3 = value;
		}
	}

	[Obsolete("Use AddRawConfiguration")]
	public string String_3
	{
		get
		{
			return string_3;
		}
		set
		{
			Delegate321.smethod_0(this);
			string_3 = value;
		}
	}

	public TimeSpan TimeSpan_0
	{
		get
		{
			return timeSpan_1;
		}
		set
		{
			Delegate321.smethod_0(this);
			timeSpan_1 = value;
		}
	}

	public int Int32_0
	{
		get
		{
			return Delegate324.smethod_0(Delegate323.smethod_0(this));
		}
		set
		{
			Delegate326.smethod_0(this, Delegate325.smethod_0(value));
		}
	}

	public string String_4
	{
		get
		{
			Delegate327.smethod_0(this);
			return Delegate329.smethod_0(Delegate328.smethod_0(this));
		}
		set
		{
			Delegate327.smethod_0(this);
			Delegate330.smethod_0(Delegate328.smethod_0(this), value);
		}
	}

	public int Int32_1
	{
		get
		{
			Delegate327.smethod_0(this);
			return Delegate91.smethod_0(Delegate328.smethod_0(this));
		}
		set
		{
			Delegate327.smethod_0(this);
			Delegate331.smethod_0(Delegate328.smethod_0(this), value);
		}
	}

	public string String_5
	{
		get
		{
			return string_4;
		}
		set
		{
			Delegate321.smethod_0(this);
			string_4 = value;
		}
	}

	public string String_6
	{
		get
		{
			return string_5;
		}
		set
		{
			Delegate321.smethod_0(this);
			string_5 = value;
		}
	}

	public string String_7
	{
		get
		{
			Delegate332.smethod_0(this);
			return string_6;
		}
	}

	public TimeSpan TimeSpan_1
	{
		[CompilerGenerated]
		get
		{
			return timeSpan_0;
		}
		[CompilerGenerated]
		set
		{
			timeSpan_0 = value;
		}
	}

	public GClass7 GClass7_0
	{
		[CompilerGenerated]
		get
		{
			return gclass7_0;
		}
		[CompilerGenerated]
		private set
		{
			gclass7_0 = value;
		}
	}

	public bool Boolean_2
	{
		get
		{
			Delegate327.smethod_0(this);
			return class16_0 != null;
		}
	}

	internal bool Boolean_3 => gdelegate2_0 != null;

	Type IReflect.UnderlyingSystemType => GetType();

	internal Class21 Class21_0
	{
		[CompilerGenerated]
		get
		{
			return class21_0;
		}
		[CompilerGenerated]
		private set
		{
			class21_0 = value;
		}
	}

	internal bool Boolean_4
	{
		get
		{
			return bool_5;
		}
		set
		{
			Delegate321.smethod_0(this);
			bool_5 = value;
		}
	}

	internal bool Boolean_5
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		set
		{
			bool_0 = value;
		}
	}

	internal Dictionary<string, string> Dictionary_0
	{
		[CompilerGenerated]
		get
		{
			return dictionary_0;
		}
		[CompilerGenerated]
		private set
		{
			dictionary_0 = value;
		}
	}

	internal bool Boolean_6 => bool_2;

	internal string String_8 => string_3;

	public event GDelegate1 Event_0
	{
		[CompilerGenerated]
		add
		{
			GDelegate1 gDelegate = gdelegate1_0;
			GDelegate1 value2 = default(GDelegate1);
			while (true)
			{
				GDelegate1 gDelegate2 = gDelegate;
				while (true)
				{
					int num = Class55.smethod_1(72);
					int num2 = Class9.smethod_0(108);
					while (true)
					{
						num2 ^= 0x64;
						while (true)
						{
							int num3 = GEventArgs2.smethod_0(44);
							int num4 = -3;
							while (true)
							{
								num4 ^= 0x65;
								while (true)
								{
									int num5 = 14;
									int num6 = 10;
									while (true)
									{
										num6 ^= 0x6C;
										while (true)
										{
											int num7 = Class9.smethod_0(104);
											int num8 = -5;
											while (true)
											{
												num8 ^= 0x63;
												int num9 = 12;
												int num10 = -1;
												num10 = -101;
												while (true)
												{
													IL_0218:
													num9 ^= 0x61;
													while (true)
													{
														num10 = Class8.smethod_0(41);
														switch (num10 ^ 0x64)
														{
														case -103:
															goto end_IL_000d;
														case -104:
															goto IL_005b;
														case -101:
															goto IL_0218;
														case -102:
															while (true)
															{
																num10 = -2;
																num10 = -102;
															}
														}
														continue;
														end_IL_000d:
														break;
													}
													switch (num9)
													{
													case 109:
														goto IL_006b;
													case 110:
														goto IL_0205;
													case 111:
														goto IL_020b;
													case 112:
														goto end_IL_0218;
													}
													num10 = -4;
													num10 = -104;
													goto IL_005b;
													IL_01e2:
													num4 = Class8.smethod_0(37);
													num5 = 0;
													goto IL_01ee;
													IL_01fc:
													num7 ^= 0x61;
													goto IL_020b;
													IL_0205:
													num9 = 15;
													continue;
													IL_006b:
													switch (num8)
													{
													case -105:
														goto IL_008e;
													case -104:
														goto IL_01fc;
													case -106:
														goto IL_0224;
													case -107:
														goto end_IL_0233;
													}
													num9 = 14;
													continue;
													IL_0224:
													num8 = GEventArgs2.smethod_0(40);
													break;
													IL_008e:
													switch (num7)
													{
													case -97:
														break;
													case -95:
														goto IL_00b6;
													case -96:
														goto IL_01f5;
													default:
														goto IL_022f;
													case -94:
														goto end_IL_0247;
													}
													num7 = -2;
													goto IL_01fc;
													IL_022f:
													num8 = -10;
													break;
													IL_00b6:
													switch (num6)
													{
													case 100:
														goto IL_00d9;
													case 102:
														goto IL_01ee;
													case 101:
														goto IL_025c;
													case 99:
														goto end_IL_0260;
													}
													num7 = -63;
													goto IL_01fc;
													IL_025c:
													num6 = 9;
													goto end_IL_0247;
													IL_00d9:
													switch (num5)
													{
													case 101:
														break;
													case 102:
														goto IL_0101;
													case 103:
														goto IL_01e2;
													default:
														goto IL_0256;
													case 104:
														goto end_IL_0269;
													}
													num5 = 13;
													goto IL_01ee;
													IL_0256:
													num6 = 15;
													goto end_IL_0247;
													IL_0101:
													switch (num4)
													{
													case -107:
														goto IL_0124;
													case -104:
														goto IL_01db;
													case -106:
														goto IL_027e;
													case -105:
														goto end_IL_0282;
													}
													num5 = 15;
													goto IL_01ee;
													IL_027e:
													num4 = -13;
													goto end_IL_0269;
													IL_0124:
													switch (num3)
													{
													case -102:
														break;
													case -103:
														goto IL_01c8;
													case -101:
														goto IL_01d7;
													default:
														goto IL_0273;
													case -100:
														goto end_IL_028b;
													}
													switch (num2)
													{
													case -99:
														goto IL_0168;
													case -96:
														goto IL_01c3;
													case -97:
														goto IL_02a0;
													case -98:
														goto end_IL_02a4;
													}
													num3 = Class55.smethod_1(72);
													goto IL_01db;
													IL_0273:
													num4 = GEventArgs2.smethod_0(44);
													goto end_IL_0269;
													IL_01d7:
													num3 = -13;
													goto IL_01db;
													IL_020b:
													num8 = Class55.smethod_1(71);
													num9 = 17;
													continue;
													IL_02a0:
													num2 = -5;
													goto end_IL_028b;
													IL_0168:
													switch (num)
													{
													case -103:
														break;
													case -102:
														goto IL_0196;
													case -101:
														goto IL_01a9;
													case -100:
														goto IL_01c0;
													default:
														goto IL_029a;
													case -99:
														return;
													}
													if ((object)gDelegate != gDelegate2)
													{
														goto end_IL_02ad;
													}
													num = -9;
													goto IL_01c3;
													IL_029a:
													num2 = -6;
													goto end_IL_028b;
													IL_01c0:
													num = -10;
													goto IL_01c3;
													IL_01a9:
													value2 = (GDelegate1)Delegate.Combine(gDelegate2, value);
													num = Class8.smethod_0(37);
													goto IL_01c3;
													IL_0196:
													gDelegate = Interlocked.CompareExchange(ref gdelegate1_0, value2, gDelegate2);
													num = -13;
													goto IL_01c3;
													IL_01f5:
													num6 = 8;
													num7 = -61;
													goto IL_01fc;
													IL_005b:
													num9 = 12;
													num10 = -1;
													num10 = -101;
													continue;
													IL_01c3:
													num ^= 0x6A;
													goto IL_01c8;
													IL_01c8:
													num2 = Class8.smethod_0(57);
													num3 = -12;
													goto IL_01db;
													IL_01ee:
													num5 ^= 0x68;
													goto IL_01f5;
													IL_01db:
													num3 ^= 0x68;
													goto IL_01e2;
													continue;
													end_IL_0218:
													break;
												}
												continue;
												end_IL_0233:
												break;
											}
											continue;
											end_IL_0247:
											break;
										}
										continue;
										end_IL_0260:
										break;
									}
									continue;
									end_IL_0269:
									break;
								}
								continue;
								end_IL_0282:
								break;
							}
							continue;
							end_IL_028b:
							break;
						}
						continue;
						end_IL_02a4:
						break;
					}
					continue;
					end_IL_02ad:
					break;
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			GDelegate1 gDelegate = gdelegate1_0;
			GDelegate1 value2 = default(GDelegate1);
			while (true)
			{
				GDelegate1 gDelegate2 = gDelegate;
				while (true)
				{
					int num = Class8.smethod_0(42);
					int num2 = GEventArgs2.smethod_0(40);
					while (true)
					{
						num2 ^= 0x63;
						while (true)
						{
							int num3 = GEventArgs2.smethod_0(40);
							int num4 = Class55.smethod_1(72);
							while (true)
							{
								num4 ^= 0x6A;
								while (true)
								{
									int num5 = GEventArgs2.smethod_0(46);
									int num6 = 7;
									while (true)
									{
										num6 ^= 0x6D;
										while (true)
										{
											int num7 = Class8.smethod_0(37);
											int num8 = -53;
											while (true)
											{
												num8 ^= 0x6A;
												int num9 = 15;
												int num10 = -7;
												num10 = -102;
												while (true)
												{
													IL_022d:
													num9 ^= 0x6A;
													while (true)
													{
														num10 = Class55.smethod_1(71);
														while (true)
														{
															switch (num10 ^ 0x63)
															{
															case -103:
																num10 = Class8.smethod_0(48);
																continue;
															case -105:
																goto end_IL_0036;
															case -104:
																goto IL_0221;
															case -102:
																goto IL_022d;
															}
															break;
														}
														continue;
														end_IL_0036:
														break;
													}
													switch (num9)
													{
													case 99:
														goto IL_0068;
													case 101:
														goto IL_0071;
													case 100:
														goto IL_0212;
													case 102:
														goto end_IL_022d;
													}
													num10 = -5;
													num10 = -104;
													goto IL_0221;
													IL_01ef:
													num4 = Class8.smethod_0(58);
													num5 = -16;
													goto IL_01fc;
													IL_0212:
													num8 = Class10.smethod_0(94);
													num9 = 12;
													continue;
													IL_0071:
													switch (num8)
													{
													case -96:
														goto IL_0094;
													case -95:
														goto IL_020b;
													case -98:
														goto IL_0239;
													case -97:
														goto end_IL_0248;
													}
													num9 = 14;
													continue;
													IL_0239:
													num8 = -12;
													break;
													IL_0094:
													switch (num7)
													{
													case -107:
														break;
													case -106:
														goto IL_00c1;
													case -105:
														goto IL_0203;
													default:
														goto IL_023f;
													case -104:
														goto end_IL_025d;
													}
													num7 = Class8.smethod_0(58);
													goto IL_020b;
													IL_023f:
													num8 = GEventArgs2.smethod_0(40);
													break;
													IL_00c1:
													switch (num6)
													{
													case 103:
														goto IL_00e4;
													case 106:
														goto IL_01fc;
													case 105:
														goto IL_0271;
													case 104:
														goto end_IL_0274;
													}
													num7 = -15;
													goto IL_020b;
													IL_0271:
													num6 = 4;
													goto end_IL_025d;
													IL_00e4:
													switch (num5)
													{
													case -102:
														break;
													case -101:
														goto IL_01e4;
													case -100:
														goto IL_01ef;
													default:
														goto IL_026c;
													case -99:
														goto end_IL_027d;
													}
													switch (num4)
													{
													case -103:
														goto IL_0126;
													case -101:
														goto IL_01db;
													case -102:
														goto IL_0291;
													case -104:
														goto end_IL_0295;
													}
													num5 = -15;
													goto IL_01fc;
													IL_026c:
													num6 = 5;
													goto end_IL_025d;
													IL_01e4:
													num5 = GEventArgs2.smethod_0(49);
													goto IL_01fc;
													IL_020b:
													num7 ^= 0x66;
													goto IL_0212;
													IL_0291:
													num4 = -16;
													goto end_IL_027d;
													IL_0126:
													switch (num3)
													{
													case -100:
														break;
													case -98:
														goto IL_014e;
													case -99:
														goto IL_01ce;
													default:
														goto IL_028b;
													case -97:
														goto end_IL_029e;
													}
													num3 = -9;
													goto IL_01db;
													IL_028b:
													num4 = -14;
													goto end_IL_027d;
													IL_014e:
													switch (num2)
													{
													case -109:
														goto IL_016e;
													case -106:
														goto IL_01c9;
													case -107:
														goto IL_02b8;
													case -108:
														goto end_IL_02bc;
													}
													num3 = -10;
													goto IL_01db;
													IL_02b8:
													num2 = -10;
													goto end_IL_029e;
													IL_016e:
													switch (num)
													{
													case -104:
														break;
													case -103:
														goto IL_0195;
													case -102:
														goto IL_01ad;
													case -101:
														goto IL_01bf;
													default:
														goto IL_02b2;
													case -100:
														return;
													}
													num = -4;
													goto IL_01c9;
													IL_02b2:
													num2 = -9;
													goto end_IL_029e;
													IL_01bf:
													if ((object)gDelegate != gDelegate2)
													{
														goto end_IL_02c5;
													}
													num = -8;
													goto IL_01c9;
													IL_0221:
													num9 = 15;
													num10 = -7;
													num10 = -102;
													continue;
													IL_01ad:
													value2 = (GDelegate1)Delegate.Remove(gDelegate2, value);
													num = -3;
													goto IL_01c9;
													IL_0195:
													gDelegate = Interlocked.CompareExchange(ref gdelegate1_0, value2, gDelegate2);
													num = Class8.smethod_0(39);
													goto IL_01c9;
													IL_01fc:
													num5 ^= 0x6D;
													goto IL_0203;
													IL_01c9:
													num ^= 0x64;
													goto IL_01ce;
													IL_01ce:
													num2 = Class8.smethod_0(37);
													num3 = -12;
													goto IL_01db;
													IL_0068:
													num9 = 9;
													continue;
													IL_0203:
													num6 = 10;
													num7 = -2;
													goto IL_020b;
													IL_01db:
													num3 ^= 0x6B;
													goto IL_01ef;
													continue;
													end_IL_022d:
													break;
												}
												continue;
												end_IL_0248:
												break;
											}
											continue;
											end_IL_025d:
											break;
										}
										continue;
										end_IL_0274:
										break;
									}
									continue;
									end_IL_027d:
									break;
								}
								continue;
								end_IL_0295:
								break;
							}
							continue;
							end_IL_029e:
							break;
						}
						continue;
						end_IL_02bc:
						break;
					}
					continue;
					end_IL_02c5:
					break;
				}
			}
		}
	}

	public event GDelegate3 Event_1
	{
		[CompilerGenerated]
		add
		{
			GDelegate3 gDelegate = gdelegate3_0;
			GDelegate3 value2 = default(GDelegate3);
			while (true)
			{
				GDelegate3 gDelegate2 = gDelegate;
				while (true)
				{
					int num = Class8.smethod_0(41);
					int num2 = 3;
					while (true)
					{
						num2 ^= 0x67;
						while (true)
						{
							int num3 = 4;
							int num4 = -14;
							while (true)
							{
								num4 ^= 0x6D;
								while (true)
								{
									int num5 = 12;
									int num6 = -5;
									while (true)
									{
										num6 ^= 0x65;
										while (true)
										{
											int num7 = 1;
											int num8 = -4;
											while (true)
											{
												num8 ^= 0x6A;
												int num9 = Class8.smethod_0(37);
												while (true)
												{
													switch (num9 ^ 0x69)
													{
													case -103:
														break;
													default:
														num9 = Class8.smethod_0(37);
														continue;
													case -104:
														num8 = Class8.smethod_0(42);
														num9 = -13;
														num9 = -102;
														goto end_IL_003a;
													case -102:
														goto end_IL_003a;
													case -105:
														while (true)
														{
															num9 = -2;
															num9 = -105;
														}
													}
													switch (num8)
													{
													case -109:
														goto IL_0073;
													case -108:
														goto IL_0081;
													case -106:
														goto IL_01eb;
													case -107:
														goto end_IL_0203;
													}
													num9 = Class55.smethod_1(72);
													continue;
													IL_0073:
													num8 = Class8.smethod_0(57);
													break;
													continue;
													end_IL_003a:
													break;
												}
												continue;
												IL_01bd:
												num3 ^= 0x62;
												goto IL_01c4;
												IL_0081:
												switch (num7)
												{
												case 103:
													goto IL_00a3;
												case 104:
													goto IL_01d8;
												case 105:
													goto IL_01e7;
												case 106:
													goto end_IL_0218;
												}
												num8 = -1;
												continue;
												IL_01e7:
												num7 = 15;
												goto IL_01eb;
												IL_00a3:
												switch (num6)
												{
												case -99:
													goto IL_00c6;
												case -98:
													goto IL_01d1;
												case -100:
													goto IL_0221;
												case -101:
													goto end_IL_0230;
												}
												num7 = 14;
												goto IL_01eb;
												IL_0221:
												num6 = Class8.smethod_0(57);
												goto end_IL_0218;
												IL_00c6:
												switch (num5)
												{
												case 100:
													break;
												case 101:
													goto IL_00ee;
												case 102:
													goto IL_01c4;
												default:
													goto IL_022c;
												case 103:
													goto end_IL_0239;
												}
												num5 = 13;
												goto IL_01d1;
												IL_022c:
												num6 = -2;
												goto end_IL_0218;
												IL_00ee:
												switch (num4)
												{
												case -100:
													goto IL_0111;
												case -97:
													goto IL_01bd;
												case -98:
													goto IL_0249;
												case -99:
													goto end_IL_024d;
												}
												num5 = 15;
												goto IL_01d1;
												IL_0249:
												num4 = -13;
												goto end_IL_0239;
												IL_0111:
												switch (num3)
												{
												case 101:
													break;
												case 102:
													goto IL_0138;
												case 100:
													goto IL_01b7;
												default:
													goto IL_0243;
												case 103:
													goto end_IL_0256;
												}
												num3 = 7;
												goto IL_01bd;
												IL_0243:
												num4 = -16;
												goto end_IL_0239;
												IL_0138:
												switch (num2)
												{
												case 97:
													goto IL_0157;
												case 100:
													goto IL_01b2;
												case 99:
													goto IL_0264;
												case 98:
													goto end_IL_0267;
												}
												num3 = 6;
												goto IL_01bd;
												IL_0264:
												num2 = 4;
												goto end_IL_0256;
												IL_0157:
												switch (num)
												{
												case -98:
													break;
												case -97:
													goto IL_018c;
												case -96:
													goto IL_01a3;
												case -95:
													goto IL_01af;
												default:
													goto IL_025f;
												case -94:
													return;
												}
												gDelegate = Interlocked.CompareExchange(ref gdelegate3_0, value2, gDelegate2);
												num = -62;
												goto IL_01b2;
												IL_025f:
												num2 = 5;
												goto end_IL_0256;
												IL_01af:
												num = -61;
												goto IL_01b2;
												IL_01a3:
												if ((object)gDelegate != gDelegate2)
												{
													goto end_IL_0270;
												}
												num = -64;
												goto IL_01b2;
												IL_01c4:
												num4 = Class55.smethod_1(72);
												num5 = 14;
												goto IL_01d1;
												IL_018c:
												value2 = (GDelegate3)Delegate.Combine(gDelegate2, value);
												num = Class8.smethod_0(38);
												goto IL_01b2;
												IL_01eb:
												num7 ^= 0x66;
												num8 = Class8.smethod_0(42);
												num9 = -13;
												num9 = -102;
												continue;
												IL_01b2:
												num ^= 0x62;
												goto IL_01b7;
												IL_01b7:
												num2 = 6;
												num3 = 5;
												goto IL_01bd;
												IL_01d1:
												num5 ^= 0x69;
												goto IL_01d8;
												IL_01d8:
												num6 = GEventArgs2.smethod_0(43);
												num7 = 12;
												goto IL_01eb;
												continue;
												end_IL_0203:
												break;
											}
											continue;
											end_IL_0218:
											break;
										}
										continue;
										end_IL_0230:
										break;
									}
									continue;
									end_IL_0239:
									break;
								}
								continue;
								end_IL_024d:
								break;
							}
							continue;
							end_IL_0256:
							break;
						}
						continue;
						end_IL_0267:
						break;
					}
					continue;
					end_IL_0270:
					break;
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			GDelegate3 gDelegate = gdelegate3_0;
			GDelegate3 value2 = default(GDelegate3);
			while (true)
			{
				GDelegate3 gDelegate2 = gDelegate;
				while (true)
				{
					int num = 3;
					int num2 = 14;
					while (true)
					{
						num2 ^= 0x62;
						while (true)
						{
							int num3 = 14;
							int num4 = 0;
							while (true)
							{
								num4 ^= 0x68;
								while (true)
								{
									int num5 = Class8.smethod_0(37);
									int num6 = 15;
									while (true)
									{
										num6 ^= 0x63;
										int num7 = 1;
										int num8 = -1;
										num8 = -101;
										while (true)
										{
											IL_019e:
											num7 ^= 0x62;
											num8 = Class8.smethod_0(42);
											while (true)
											{
												switch (num8 ^ 0x64)
												{
												default:
													num8 = Class8.smethod_0(42);
													continue;
												case -102:
													break;
												case -103:
													goto IL_005a;
												case -101:
													goto IL_019e;
												case -104:
													while (true)
													{
														num8 = -4;
														num8 = -104;
													}
												}
												break;
											}
											switch (num7)
											{
											case 99:
												goto IL_0069;
											case 98:
												goto IL_0193;
											case 100:
												goto IL_019b;
											case 101:
												goto end_IL_019e;
											}
											num8 = -3;
											num8 = -103;
											goto IL_005a;
											IL_018c:
											num5 ^= 0x69;
											goto IL_0193;
											IL_017d:
											num3 ^= 0x6C;
											goto IL_0184;
											IL_019b:
											num7 = 6;
											continue;
											IL_0069:
											switch (num6)
											{
											case 107:
												goto IL_008b;
											case 108:
												goto IL_018c;
											case 106:
												goto IL_01b3;
											case 105:
												goto end_IL_01bd;
											}
											num7 = 0;
											continue;
											IL_01b3:
											num6 = 9;
											break;
											IL_008b:
											switch (num5)
											{
											case -105:
												break;
											case -103:
												goto IL_00b3;
											case -104:
												goto IL_0184;
											default:
												goto IL_01b9;
											case -102:
												goto end_IL_01d0;
											}
											num5 = -2;
											goto IL_018c;
											IL_01b9:
											num6 = 10;
											break;
											IL_00b3:
											switch (num4)
											{
											case 101:
												goto IL_00d6;
											case 104:
												goto IL_017d;
											case 103:
												goto IL_01e5;
											case 102:
												goto end_IL_01e9;
											}
											num5 = -15;
											goto IL_018c;
											IL_01e5:
											num4 = 15;
											goto end_IL_01d0;
											IL_00d6:
											switch (num3)
											{
											case 98:
												break;
											case 99:
												goto IL_0170;
											case 100:
												goto IL_017a;
											default:
												goto IL_01df;
											case 101:
												goto end_IL_01f2;
											}
											switch (num2)
											{
											case 105:
												goto IL_0115;
											case 108:
												goto IL_016b;
											case 107:
												goto IL_0200;
											case 106:
												goto end_IL_0204;
											}
											num3 = 15;
											goto IL_017d;
											IL_01df:
											num4 = 14;
											goto end_IL_01d0;
											IL_017a:
											num3 = 8;
											goto IL_017d;
											IL_0193:
											num6 = 8;
											num7 = 7;
											continue;
											IL_0200:
											num2 = 9;
											goto end_IL_01f2;
											IL_0115:
											switch (num)
											{
											case 103:
												break;
											case 104:
												goto IL_0149;
											case 105:
												goto IL_015c;
											case 106:
												goto IL_0161;
											default:
												goto IL_01fb;
											case 107:
												return;
											}
											value2 = (GDelegate3)Delegate.Remove(gDelegate2, value);
											num = 12;
											goto IL_016b;
											IL_01fb:
											num2 = 8;
											goto end_IL_01f2;
											IL_0161:
											if ((object)gDelegate != gDelegate2)
											{
												goto end_IL_020d;
											}
											num = 15;
											goto IL_016b;
											IL_005a:
											num7 = 1;
											num8 = -1;
											num8 = -101;
											continue;
											IL_015c:
											num = 13;
											goto IL_016b;
											IL_0149:
											gDelegate = Interlocked.CompareExchange(ref gdelegate3_0, value2, gDelegate2);
											num = 14;
											goto IL_016b;
											IL_0184:
											num4 = 13;
											num5 = -13;
											goto IL_018c;
											IL_016b:
											num ^= 0x64;
											goto IL_0170;
											IL_0170:
											num2 = 11;
											num3 = 9;
											goto IL_017d;
											continue;
											end_IL_019e:
											break;
										}
										continue;
										end_IL_01bd:
										break;
									}
									continue;
									end_IL_01d0:
									break;
								}
								continue;
								end_IL_01e9:
								break;
							}
							continue;
							end_IL_01f2:
							break;
						}
						continue;
						end_IL_0204:
						break;
					}
					continue;
					end_IL_020d:
					break;
				}
			}
		}
	}

	public event GDelegate0 Event_2
	{
		[CompilerGenerated]
		add
		{
			GDelegate0 gDelegate = gdelegate0_0;
			GDelegate0 value2 = default(GDelegate0);
			while (true)
			{
				GDelegate0 gDelegate2 = gDelegate;
				while (true)
				{
					int num = GEventArgs2.smethod_0(44);
					int num2 = Class8.smethod_0(39);
					while (true)
					{
						num2 ^= 0x65;
						while (true)
						{
							int num3 = 14;
							int num4 = 0;
							while (true)
							{
								num4 ^= 0x69;
								while (true)
								{
									int num5 = 0;
									int num6 = 15;
									while (true)
									{
										num6 ^= 0x67;
										while (true)
										{
											int num7 = 12;
											int num8 = 0;
											while (true)
											{
												num8 ^= 0x68;
												int num9 = 5;
												int num10 = -2;
												num10 = -99;
												while (true)
												{
													IL_020a:
													num9 ^= 0x69;
													while (true)
													{
														num10 = Class8.smethod_0(57);
														switch (num10 ^ 0x63)
														{
														case -102:
															goto end_IL_000d;
														case -101:
															goto IL_01ff;
														case -99:
															goto IL_020a;
														case -100:
															while (true)
															{
																num10 = -1;
																num10 = -100;
															}
														}
														continue;
														end_IL_000d:
														break;
													}
													switch (num9)
													{
													case 107:
														goto IL_0060;
													case 108:
														goto IL_0068;
													case 106:
														goto IL_01f6;
													case 109:
														goto end_IL_020a;
													}
													num10 = -8;
													num10 = -101;
													goto IL_01ff;
													IL_01da:
													num4 = 1;
													num5 = 15;
													goto IL_01e1;
													IL_01f6:
													num8 = 14;
													num9 = 4;
													continue;
													IL_0068:
													switch (num8)
													{
													case 102:
														goto IL_008a;
													case 104:
														goto IL_01ef;
													case 101:
														goto IL_0216;
													case 103:
														goto end_IL_0220;
													}
													num9 = 3;
													continue;
													IL_0216:
													num8 = 13;
													break;
													IL_008a:
													switch (num7)
													{
													case 109:
														break;
													case 110:
														goto IL_00b2;
													case 111:
														goto IL_01e8;
													default:
														goto IL_021c;
													case 112:
														goto end_IL_0234;
													}
													num7 = 15;
													goto IL_01ef;
													IL_021c:
													num8 = 15;
													break;
													IL_00b2:
													switch (num6)
													{
													case 101:
														goto IL_00d5;
													case 104:
														goto IL_01e1;
													case 103:
														goto IL_0242;
													case 102:
														goto end_IL_0245;
													}
													num7 = 13;
													goto IL_01ef;
													IL_0242:
													num6 = 0;
													goto end_IL_0234;
													IL_00d5:
													switch (num5)
													{
													case 102:
														break;
													case 103:
														goto IL_01d5;
													case 104:
														goto IL_01da;
													default:
														goto IL_023d;
													case 105:
														goto end_IL_024e;
													}
													switch (num4)
													{
													case 104:
														goto IL_0117;
													case 105:
														goto IL_01cc;
													case 102:
														goto IL_0257;
													case 103:
														goto end_IL_0261;
													}
													num5 = 14;
													goto IL_01e1;
													IL_023d:
													num6 = 1;
													goto end_IL_0234;
													IL_01d5:
													num5 = 1;
													goto IL_01e1;
													IL_01ef:
													num7 ^= 0x62;
													goto IL_01f6;
													IL_0257:
													num4 = 15;
													goto end_IL_024e;
													IL_0117:
													switch (num3)
													{
													case 97:
														break;
													case 99:
														goto IL_013f;
													case 98:
														goto IL_01bf;
													default:
														goto IL_025d;
													case 100:
														goto end_IL_026a;
													}
													num3 = 12;
													goto IL_01cc;
													IL_025d:
													num4 = 14;
													goto end_IL_024e;
													IL_013f:
													switch (num2)
													{
													case -105:
														goto IL_015f;
													case -102:
														goto IL_01ba;
													case -103:
														goto IL_0279;
													case -104:
														goto end_IL_027d;
													}
													num3 = 15;
													goto IL_01cc;
													IL_0279:
													num2 = -4;
													goto end_IL_026a;
													IL_015f:
													switch (num)
													{
													case -105:
														break;
													case -104:
														goto IL_0194;
													case -103:
														goto IL_01a5;
													case -102:
														goto IL_01b7;
													default:
														goto IL_0273;
													case -101:
														return;
													}
													gDelegate = Interlocked.CompareExchange(ref gdelegate0_0, value2, gDelegate2);
													num = -13;
													goto IL_01ba;
													IL_0273:
													num2 = -3;
													goto end_IL_026a;
													IL_01b7:
													num = -15;
													goto IL_01ba;
													IL_01a5:
													value2 = (GDelegate0)Delegate.Combine(gDelegate2, value);
													num = -4;
													goto IL_01ba;
													IL_0194:
													if ((object)gDelegate != gDelegate2)
													{
														goto end_IL_0286;
													}
													num = Class8.smethod_0(37);
													goto IL_01ba;
													IL_01ff:
													num9 = 5;
													num10 = -2;
													num10 = -99;
													continue;
													IL_01e1:
													num5 ^= 0x66;
													goto IL_01e8;
													IL_01ba:
													num ^= 0x6B;
													goto IL_01bf;
													IL_01bf:
													num2 = GEventArgs2.smethod_0(44);
													num3 = 9;
													goto IL_01cc;
													IL_0060:
													num9 = 2;
													continue;
													IL_01e8:
													num6 = 2;
													num7 = 18;
													goto IL_01ef;
													IL_01cc:
													num3 ^= 0x6D;
													goto IL_01da;
													continue;
													end_IL_020a:
													break;
												}
												continue;
												end_IL_0220:
												break;
											}
											continue;
											end_IL_0234:
											break;
										}
										continue;
										end_IL_0245:
										break;
									}
									continue;
									end_IL_024e:
									break;
								}
								continue;
								end_IL_0261:
								break;
							}
							continue;
							end_IL_026a:
							break;
						}
						continue;
						end_IL_027d:
						break;
					}
					continue;
					end_IL_0286:
					break;
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			GDelegate0 gDelegate = gdelegate0_0;
			GDelegate0 value2 = default(GDelegate0);
			while (true)
			{
				GDelegate0 gDelegate2 = gDelegate;
				while (true)
				{
					int num = Class8.smethod_0(39);
					int num2 = Class9.smethod_0(106);
					while (true)
					{
						num2 ^= 0x6C;
						while (true)
						{
							int num3 = 11;
							int num4 = 15;
							while (true)
							{
								num4 ^= 0x6A;
								while (true)
								{
									int num5 = 5;
									int num6 = Class55.smethod_1(71);
									while (true)
									{
										num6 ^= 0x63;
										while (true)
										{
											int num7 = 14;
											int num8 = -7;
											while (true)
											{
												num8 ^= 0x66;
												int num9 = 0;
												int num10 = -54;
												num10 = -94;
												while (true)
												{
													IL_021a:
													num9 ^= 0x69;
													while (true)
													{
														num10 = Class9.smethod_0(93);
														while (true)
														{
															switch (num10 ^ 0x68)
															{
															case -95:
																num10 = Class10.smethod_0(90);
																continue;
															case -96:
																goto end_IL_0036;
															case -97:
																goto IL_0063;
															case -94:
																goto IL_021a;
															}
															break;
														}
														continue;
														end_IL_0036:
														break;
													}
													switch (num9)
													{
													case 103:
														goto IL_0073;
													case 105:
														goto IL_007c;
													case 104:
														goto IL_020e;
													case 106:
														goto end_IL_021a;
													}
													num10 = -9;
													num10 = -97;
													goto IL_0063;
													IL_020e:
													num8 = Class8.smethod_0(47);
													num9 = 3;
													continue;
													IL_0207:
													num7 ^= 0x64;
													goto IL_020e;
													IL_007c:
													switch (num8)
													{
													case -99:
														goto IL_009e;
													case -97:
														goto IL_0207;
													case -100:
														goto IL_0226;
													case -98:
														goto end_IL_0235;
													}
													num9 = 1;
													continue;
													IL_0226:
													num8 = Class8.smethod_0(48);
													break;
													IL_009e:
													switch (num7)
													{
													case 105:
														break;
													case 106:
														goto IL_00c6;
													case 104:
														goto IL_01fa;
													default:
														goto IL_0231;
													case 107:
														goto end_IL_0249;
													}
													num7 = 13;
													goto IL_0207;
													IL_0231:
													num8 = -8;
													break;
													IL_00c6:
													switch (num6)
													{
													case -106:
														goto IL_00e9;
													case -105:
														goto IL_01f3;
													case -107:
														goto IL_0253;
													case -108:
														goto end_IL_025d;
													}
													num7 = 12;
													goto IL_0207;
													IL_0253:
													num6 = -10;
													goto end_IL_0249;
													IL_00e9:
													switch (num5)
													{
													case 98:
														break;
													case 100:
														goto IL_0110;
													case 99:
														goto IL_01ed;
													default:
														goto IL_0259;
													case 101:
														goto end_IL_0266;
													}
													num5 = 3;
													goto IL_01f3;
													IL_0259:
													num6 = -9;
													goto end_IL_0249;
													IL_0110:
													switch (num4)
													{
													case 98:
														goto IL_0132;
													case 101:
														goto IL_01e6;
													case 100:
														goto IL_027a;
													case 99:
														goto end_IL_027e;
													}
													num5 = 2;
													goto IL_01f3;
													IL_027a:
													num4 = 14;
													goto end_IL_0266;
													IL_0132:
													switch (num3)
													{
													case 101:
														break;
													case 102:
														goto IL_0159;
													case 100:
														goto IL_01d9;
													default:
														goto IL_0274;
													case 103:
														goto end_IL_0287;
													}
													num3 = 8;
													goto IL_01e6;
													IL_0274:
													num4 = 9;
													goto end_IL_0266;
													IL_0159:
													switch (num2)
													{
													case -96:
														goto IL_0179;
													case -95:
														goto IL_01d4;
													case -98:
														goto IL_0291;
													case -97:
														goto end_IL_029b;
													}
													num3 = 9;
													goto IL_01e6;
													IL_0291:
													num2 = -14;
													goto end_IL_0287;
													IL_0179:
													switch (num)
													{
													case -106:
														break;
													case -105:
														goto IL_01ae;
													case -104:
														goto IL_01ba;
													case -103:
														goto IL_01c4;
													default:
														goto IL_0297;
													case -102:
														return;
													}
													gDelegate = Interlocked.CompareExchange(ref gdelegate0_0, value2, gDelegate2);
													num = -15;
													goto IL_01d4;
													IL_0297:
													num2 = -13;
													goto end_IL_0287;
													IL_01c4:
													value2 = (GDelegate0)Delegate.Remove(gDelegate2, value);
													num = -16;
													goto IL_01d4;
													IL_01ba:
													num = Class8.smethod_0(42);
													goto IL_01d4;
													IL_01ae:
													if ((object)gDelegate != gDelegate2)
													{
														goto end_IL_02a4;
													}
													num = -4;
													goto IL_01d4;
													IL_0063:
													num9 = 0;
													num10 = -54;
													num10 = -94;
													continue;
													IL_01f3:
													num5 ^= 0x61;
													goto IL_01fa;
													IL_01d4:
													num ^= 0x66;
													goto IL_01d9;
													IL_01d9:
													num2 = Class9.smethod_0(101);
													num3 = 10;
													goto IL_01e6;
													IL_0073:
													num9 = 14;
													continue;
													IL_01fa:
													num6 = GEventArgs2.smethod_0(40);
													num7 = 15;
													goto IL_0207;
													IL_01e6:
													num3 ^= 0x6D;
													goto IL_01ed;
													IL_01ed:
													num4 = 8;
													num5 = 4;
													goto IL_01f3;
													continue;
													end_IL_021a:
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
										end_IL_025d:
										break;
									}
									continue;
									end_IL_0266:
									break;
								}
								continue;
								end_IL_027e:
								break;
							}
							continue;
							end_IL_0287:
							break;
						}
						continue;
						end_IL_029b:
						break;
					}
					continue;
					end_IL_02a4:
					break;
				}
			}
		}
	}

	public event GDelegate2 Event_3
	{
		add
		{
			Class6 @class = Delegate333.smethod_0(Delegate328.smethod_0(this));
			try
			{
				Delegate321.smethod_0(this);
				gdelegate2_0 = (GDelegate2)Delegate.Combine(gdelegate2_0, value);
			}
			finally
			{
				if (@class != null || 1 == 0)
				{
					((IDisposable)@class).Dispose();
				}
			}
		}
		remove
		{
			Class6 @class = Delegate333.smethod_0(Delegate328.smethod_0(this));
			try
			{
				Delegate321.smethod_0(this);
				gdelegate2_0 = (GDelegate2)Delegate.Remove(gdelegate2_0, value);
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

	public GClass16()
	{
		Delegate335.smethod_0(this, Delegate334.smethod_0());
		Class6 @class = Delegate333.smethod_0(Delegate328.smethod_0(this));
		try
		{
			Delegate336.smethod_0(this, new TimeSpan(0, 1, 0));
			while (true)
			{
				int num = 0;
				int num2 = 15;
				while (true)
				{
					num2 ^= 0x69;
					while (true)
					{
						int num3 = 12;
						int num4 = 10;
						while (true)
						{
							num4 ^= 0x6D;
							while (true)
							{
								int num5 = GEventArgs2.smethod_0(43);
								int num6 = 18;
								while (true)
								{
									IL_0226:
									num6 ^= 0x62;
									int num7 = Class8.smethod_0(47);
									while (true)
									{
										switch (num7 ^ 0x67)
										{
										default:
											num7 = Class8.smethod_0(47);
											continue;
										case -100:
											break;
										case -101:
											goto IL_007e;
										case -98:
											goto IL_0226;
										case -99:
											while (true)
											{
												num7 = -6;
												num7 = -99;
											}
										}
										break;
									}
									switch (num6)
									{
									case 110:
										goto IL_008f;
									case 111:
										goto IL_020d;
									case 112:
										goto IL_0213;
									case 109:
										goto end_IL_0226;
									}
									num7 = -4;
									num7 = -101;
									goto IL_007e;
									IL_01fe:
									num3 ^= 0x65;
									goto IL_0203;
									IL_0203:
									num4 = 9;
									num5 = -57;
									goto IL_0213;
									IL_020d:
									num6 = 13;
									continue;
									IL_008f:
									switch (num5)
									{
									case -98:
										goto IL_00b2;
									case -97:
										goto IL_00c0;
									case -99:
										goto IL_0203;
									case -96:
										goto end_IL_023b;
									}
									num6 = 15;
									continue;
									IL_00c0:
									switch (num4)
									{
									case 100:
										goto IL_00e3;
									case 103:
										goto IL_01fe;
									case 102:
										goto IL_024f;
									case 101:
										goto end_IL_0253;
									}
									num5 = -6;
									goto IL_0213;
									IL_024f:
									num4 = 11;
									goto end_IL_023b;
									IL_00e3:
									switch (num3)
									{
									case 105:
										break;
									case 106:
										goto IL_01f3;
									case 107:
										goto IL_01fb;
									default:
										goto IL_024a;
									case 108:
										goto end_IL_025c;
									}
									switch (num2)
									{
									case 101:
										goto IL_0122;
									case 102:
										goto IL_01ee;
									case 100:
										goto IL_0265;
									case 99:
										goto end_IL_026d;
									}
									num3 = 15;
									goto IL_01fe;
									IL_024a:
									num4 = 8;
									goto end_IL_023b;
									IL_01fb:
									num3 = 14;
									goto IL_01fe;
									IL_00b2:
									num5 = Class8.smethod_0(57);
									goto IL_0213;
									IL_0265:
									num2 = 13;
									goto end_IL_025c;
									IL_0122:
									switch (num)
									{
									case 101:
										break;
									case 102:
										goto IL_016e;
									case 103:
										goto IL_0178;
									case 104:
										goto IL_0187;
									case 105:
										goto IL_018b;
									case 106:
										goto IL_0196;
									case 107:
										goto IL_01a6;
									case 108:
										goto IL_01b9;
									case 109:
										goto IL_01c4;
									case 110:
										goto IL_01d4;
									case 111:
										goto IL_01e0;
									default:
										goto IL_026a;
									case 112:
										return;
									}
									bool_5 = true;
									num = 6;
									goto IL_01ee;
									IL_026a:
									num2 = 10;
									goto end_IL_025c;
									IL_01e0:
									autoResetEvent_0 = new AutoResetEvent(initialState: false);
									num = 2;
									goto IL_01ee;
									IL_01d4:
									int_0 = 0;
									num = 14;
									goto IL_01ee;
									IL_01c4:
									Delegate338.smethod_0(this, new Dictionary<string, string>());
									num = 27;
									goto IL_01ee;
									IL_01b9:
									bool_2 = true;
									num = 5;
									goto IL_01ee;
									IL_01a6:
									timeSpan_1 = new TimeSpan(0, 2, 0);
									num = 13;
									goto IL_01ee;
									IL_0196:
									ilist_0 = new List<GClass10>();
									num = 12;
									goto IL_01ee;
									IL_018b:
									bool_1 = false;
									num = 7;
									goto IL_01ee;
									IL_0187:
									num = 3;
									goto IL_01ee;
									IL_0178:
									ilist_1 = new List<Delegate0>();
									num = 4;
									goto IL_01ee;
									IL_016e:
									Delegate337.smethod_0(this);
									num = 1;
									goto IL_01ee;
									IL_007e:
									num6 = 12;
									num7 = -7;
									num7 = -98;
									continue;
									IL_01ee:
									num ^= 0x6B;
									goto IL_01f3;
									IL_01f3:
									num2 = 12;
									num3 = 9;
									goto IL_01fe;
									IL_0213:
									num5 ^= 0x67;
									num6 = 12;
									num7 = -7;
									num7 = -98;
									continue;
									end_IL_0226:
									break;
								}
								continue;
								end_IL_023b:
								break;
							}
							continue;
							end_IL_0253:
							break;
						}
						continue;
						end_IL_025c:
						break;
					}
					continue;
					end_IL_026d:
					break;
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

	private void method_0()
	{
		Delegate340.smethod_0(this, Delegate339.smethod_0());
		gclass7_1 = Delegate339.smethod_0();
	}

	public void Dispose()
	{
		Class6 @class = Delegate333.smethod_0(Delegate328.smethod_0(this));
		try
		{
			bool_1 = true;
			while (true)
			{
				int num = 11;
				int num2 = 6;
				while (true)
				{
					num2 ^= 0x63;
					while (true)
					{
						int num3 = Class8.smethod_0(37);
						int num4 = -6;
						while (true)
						{
							num4 ^= 0x62;
							while (true)
							{
								int num5 = 5;
								int num6 = Class9.smethod_0(87);
								while (true)
								{
									num6 ^= 0x66;
									while (true)
									{
										int num7 = Class55.smethod_1(71);
										int num8 = 13;
										while (true)
										{
											IL_01e9:
											num8 ^= 0x68;
											int num9 = Class8.smethod_0(47);
											while (true)
											{
												switch (num9 ^ 0x67)
												{
												default:
													num9 = Class8.smethod_0(47);
													continue;
												case -100:
													break;
												case -101:
													goto IL_0066;
												case -99:
													goto IL_01e9;
												case -102:
													while (true)
													{
														num9 = -3;
														num9 = -102;
													}
												}
												break;
											}
											switch (num8)
											{
											case 98:
												goto IL_0077;
											case 99:
												goto IL_01d0;
											case 101:
												goto IL_01d6;
											case 100:
												goto end_IL_01e9;
											}
											num9 = -4;
											num9 = -101;
											goto IL_0066;
											IL_01a7:
											num4 = Class55.smethod_1(71);
											num5 = 26;
											goto IL_01b4;
											IL_01d6:
											num7 ^= 0x6A;
											num8 = 10;
											num9 = -6;
											num9 = -99;
											continue;
											IL_01d0:
											num8 = 11;
											continue;
											IL_0077:
											switch (num7)
											{
											case -98:
												goto IL_009a;
											case -97:
												goto IL_01bb;
											case -96:
												goto IL_01ca;
											case -95:
												goto end_IL_01fe;
											}
											num8 = 12;
											continue;
											IL_01ca:
											num7 = -54;
											goto IL_01d6;
											IL_009a:
											switch (num6)
											{
											case -97:
												goto IL_00c2;
											case -95:
												goto IL_01b4;
											case -96:
												goto IL_0213;
											case -98:
												goto end_IL_0217;
											}
											num7 = GEventArgs2.smethod_0(40);
											goto IL_01d6;
											IL_0213:
											num6 = -58;
											goto end_IL_01fe;
											IL_00c2:
											switch (num5)
											{
											case 110:
												break;
											case 111:
												goto IL_00e9;
											case 109:
												goto IL_01a7;
											default:
												goto IL_020d;
											case 112:
												goto end_IL_0220;
											}
											num5 = 4;
											goto IL_01b4;
											IL_020d:
											num6 = -8;
											goto end_IL_01fe;
											IL_00e9:
											switch (num4)
											{
											case -106:
												goto IL_010b;
											case -104:
												goto IL_01a2;
											case -105:
												goto IL_0234;
											case -107:
												goto end_IL_023d;
											}
											num5 = 7;
											goto IL_01b4;
											IL_0234:
											num4 = GEventArgs2.smethod_0(40);
											goto end_IL_0220;
											IL_010b:
											switch (num3)
											{
											case -106:
												break;
											case -104:
												goto IL_012e;
											case -105:
												goto IL_019d;
											default:
												goto IL_022e;
											case -103:
												goto end_IL_0246;
											}
											num3 = -2;
											goto IL_01a2;
											IL_022e:
											num4 = -9;
											goto end_IL_0220;
											IL_012e:
											switch (num2)
											{
											case 99:
												goto IL_014b;
											case 101:
												goto IL_0198;
											case 100:
												goto IL_0258;
											case 98:
												goto end_IL_025a;
											}
											num3 = -1;
											goto IL_01a2;
											IL_0258:
											num2 = 7;
											goto end_IL_0246;
											IL_014b:
											switch (num)
											{
											case 101:
												if (autoResetEvent_0 != null)
												{
													goto IL_0178;
												}
												if (1 == 0)
												{
													goto case 105;
												}
												goto IL_028a;
											case 102:
												break;
											case 103:
												goto IL_018c;
											case 104:
												goto IL_0190;
											default:
												goto IL_0254;
											case 105:
												{
													autoResetEvent_0.Close();
													autoResetEvent_0 = null;
													goto IL_028a;
												}
												IL_028a:
												GC.SuppressFinalize(this);
												return;
											}
											Delegate342.smethod_0(Delegate328.smethod_0(this));
											num = 6;
											goto IL_0198;
											IL_0254:
											num2 = 1;
											goto end_IL_0246;
											IL_0190:
											Delegate341.smethod_0(this);
											num = 5;
											goto IL_0198;
											IL_018c:
											num = 4;
											goto IL_0198;
											IL_0066:
											num8 = 10;
											num9 = -6;
											num9 = -99;
											continue;
											IL_0178:
											num = 10;
											goto IL_0198;
											IL_0198:
											num ^= 0x63;
											goto IL_019d;
											IL_019d:
											num2 = 0;
											num3 = -15;
											goto IL_01a2;
											IL_01bb:
											num6 = Class8.smethod_0(57);
											num7 = -53;
											goto IL_01d6;
											IL_01b4:
											num5 ^= 0x6A;
											goto IL_01bb;
											IL_01a2:
											num3 ^= 0x68;
											goto IL_01a7;
											continue;
											end_IL_01e9:
											break;
										}
										continue;
										end_IL_01fe:
										break;
									}
									continue;
									end_IL_0217:
									break;
								}
								continue;
								end_IL_0220:
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
					end_IL_025a:
					break;
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

	public void method_1()
	{
		Class6 @class = Delegate61.smethod_0(Delegate328.smethod_0(this));
		try
		{
			Delegate332.smethod_0(this);
			bool_4 = true;
			if (class16_0 != null || 1 == 0)
			{
				Delegate343.smethod_0(class16_0);
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

	public void method_2(GClass17 gclass17_0)
	{
		Class6 @class = Delegate333.smethod_0(Delegate328.smethod_0(this));
		try
		{
			Delegate327.smethod_0(this);
			if (Delegate344.smethod_0(this) || 1 == 0)
			{
				throw new InvalidOperationException("Session is already opened");
			}
			try
			{
				Delegate345.smethod_0(this);
				string text2 = default(string);
				string text3 = default(string);
				string text5 = default(string);
				string text6 = default(string);
				while (true)
				{
					int num = 5;
					int num2 = 0;
					while (true)
					{
						num2 ^= 0x64;
						while (true)
						{
							int num3 = Class8.smethod_0(42);
							int num4 = 8;
							while (true)
							{
								num4 ^= 0x67;
								int num5 = Class8.smethod_0(41);
								while (true)
								{
									switch (num5 ^ 0x65)
									{
									case -104:
										break;
									case -105:
										goto IL_0179;
									default:
										num5 = Class8.smethod_0(41);
										continue;
									case -103:
										goto end_IL_0191;
									case -106:
										while (true)
										{
											num5 = -13;
											num5 = -106;
										}
									}
									switch (num4)
									{
									case 108:
										goto IL_005e;
									case 111:
										goto IL_0172;
									case 109:
										goto IL_01ba;
									case 110:
										goto end_IL_01be;
									}
									num5 = -14;
									num5 = -105;
									goto IL_0179;
									IL_00fa:
									class16_0 = Delegate346.smethod_0(this);
									num = 0;
									goto IL_015e;
									IL_01ba:
									num4 = 10;
									break;
									IL_005e:
									switch (num3)
									{
									case -103:
										break;
									case -104:
										goto IL_0165;
									case -102:
										goto IL_016e;
									default:
										goto IL_01b4;
									case -101:
										goto end_IL_01d0;
									}
									switch (num2)
									{
									case 98:
										goto IL_009f;
									case 100:
										goto IL_015e;
									case 97:
										goto IL_01de;
									case 99:
										goto end_IL_01e6;
									}
									num3 = -1;
									goto IL_0172;
									IL_01b4:
									num4 = 9;
									break;
									IL_016e:
									num3 = -3;
									goto IL_0172;
									IL_015e:
									num ^= 0x61;
									goto IL_0165;
									IL_01de:
									num2 = 5;
									goto end_IL_01d0;
									IL_009f:
									switch (num)
									{
									case 97:
										break;
									case 98:
										goto IL_00fa;
									case 99:
										goto IL_010b;
									case 100:
										goto IL_0110;
									case 101:
										goto IL_011b;
									case 102:
										goto IL_012b;
									case 103:
										goto IL_0145;
									case 104:
										goto IL_0155;
									default:
										goto IL_01e3;
									case 105:
										goto IL_0207;
									}
									Delegate347.smethod_0(class16_0, method_35);
									Delegate348.smethod_0(class16_0);
									num = 9;
									goto IL_015e;
									IL_01e3:
									num2 = 7;
									goto end_IL_01d0;
									IL_0155:
									Delegate349.smethod_0(this);
									num = 4;
									goto IL_015e;
									IL_0145:
									Delegate350.smethod_0(this, "option confirm off");
									num = 7;
									goto IL_015e;
									IL_012b:
									if (Delegate323.smethod_0(this) != TimeSpan.MaxValue)
									{
										num = 8;
										goto IL_015e;
									}
									if (1 == 0)
									{
										goto IL_0207;
									}
									object obj = "off";
									goto IL_0225;
									IL_0172:
									num3 ^= 0x67;
									goto IL_0179;
									IL_0165:
									num2 = 6;
									num3 = -4;
									goto IL_0172;
									IL_0207:
									obj = (int)Delegate323.smethod_0(this).TotalSeconds;
									goto IL_0225;
									IL_0179:
									num4 = 11;
									num5 = Class8.smethod_0(38);
									continue;
									IL_0225:
									string text = string.Format(CultureInfo.InvariantCulture, "option reconnecttime {0}", new object[1] { obj });
									Delegate350.smethod_0(this, text);
									Delegate351.smethod_0(this, gclass17_0, bool_0: false, ref text2, ref text3);
									text2 = "open " + text2;
									text3 = "open " + text3;
									Delegate352.smethod_0(this, text2, text3);
									goto IL_0364;
									IL_011b:
									Delegate350.smethod_0(this, "option batch on");
									num = 6;
									goto IL_015e;
									IL_0110:
									Delegate337.smethod_0(this);
									num = 3;
									goto IL_015e;
									IL_010b:
									num = 2;
									goto IL_015e;
									continue;
									end_IL_0191:
									break;
								}
								continue;
								end_IL_01be:
								break;
							}
							continue;
							end_IL_01d0:
							break;
						}
						continue;
						IL_0364:
						do
						{
							string text4;
							lock (Delegate353.smethod_0(this))
							{
								text4 = ((Delegate354.smethod_0(gclass7_1) > 0) ? Delegate355.smethod_0(this) : ((Delegate354.smethod_0(Delegate353.smethod_0(this)) <= 0) ? "There was no output. " : string.Format(CultureInfo.CurrentCulture, "Output was \"{0}\". ", new object[1] { Delegate356.smethod_0(Delegate353.smethod_0(this)) })));
							}
							text4 += string.Format(CultureInfo.CurrentCulture, "Response log file {0} was not created. This could indicate lack of write permissions to the log folder or problems starting WinSCP itself.", new object[1] { Delegate357.smethod_0(this) });
							if (((!Delegate358.smethod_0(class16_0)) ? true : false) || (File.Exists(Delegate357.smethod_0(this)) ? true : false))
							{
								Thread.Sleep(50);
								Delegate363.smethod_0(this, string.Format(CultureInfo.CurrentCulture, "WinSCP has not responded in time.") + text4);
								continue;
							}
							Delegate359.smethod_0(Delegate328.smethod_0(this));
							while (true)
							{
								int num6 = Class9.smethod_0(108);
								while (true)
								{
									switch (num6 ^ 0x67)
									{
									case -94:
										goto IL_0385;
									case -93:
										Delegate360.smethod_0(Delegate328.smethod_0(this));
										num6 = -58;
										num6 = -95;
										goto case -95;
									case -95:
										Delegate361.smethod_0(class16_0);
										num6 = -8;
										num6 = -97;
										goto case -97;
									case -97:
										text5 = string.Format(CultureInfo.CurrentCulture, "{0}", new object[1] { Delegate362.smethod_0(class16_0) });
										num6 = -57;
										num6 = -96;
										goto case -96;
									case -96:
										if (Delegate362.smethod_0(class16_0) < 0)
										{
											num6 = -61;
											num6 = -92;
											goto case -92;
										}
										goto IL_045f;
									case -92:
										{
											text5 = string.Format(CultureInfo.CurrentCulture, "{0} ({1:X})", new object[2]
											{
												text5,
												Delegate362.smethod_0(class16_0)
											});
											goto IL_045f;
										}
										IL_045f:
										throw Delegate57.smethod_0(this, string.Format(CultureInfo.CurrentCulture, "WinSCP process terminated with exit code {0}. ", new object[1] { text5 }) + text4);
									}
									break;
									IL_0385:
									num6 = Class9.smethod_0(92);
								}
							}
						}
						while ((!File.Exists(Delegate357.smethod_0(this))) ? true : false);
						class30_0 = Delegate364.smethod_0(this);
						Delegate365.smethod_0(class30_0, "session", Enum10.flag_0);
						class28_0 = Delegate366.smethod_0(class30_0);
						Class28 class2 = Delegate367.smethod_0(class28_0);
						try
						{
							Delegate368.smethod_0(class2, Enum10.flag_0);
						}
						finally
						{
							if (class2 != null || 1 == 0)
							{
								((IDisposable)class2).Dispose();
							}
						}
						Delegate350.smethod_0(this, "pwd");
						Class28 class3 = Delegate367.smethod_0(class28_0);
						try
						{
							Class28 class4 = Delegate369.smethod_0(class3, "cwd", Enum10.flag_0);
							try
							{
								while (Delegate43.smethod_0(class4, (Enum10)0) ? true : false)
								{
									if (Delegate36.smethod_0(class4, "cwd", ref text6) || 1 == 0)
									{
										string_6 = text6;
									}
								}
								Delegate370.smethod_0(class3, Enum10.flag_0);
								return;
							}
							finally
							{
								if (class4 != null || 1 == 0)
								{
									((IDisposable)class4).Dispose();
								}
							}
						}
						finally
						{
							if (class3 != null || 1 == 0)
							{
								((IDisposable)class3).Dispose();
							}
						}
						continue;
						end_IL_01e6:
						break;
					}
				}
			}
			catch (Exception ex)
			{
				Delegate45.smethod_0(Delegate328.smethod_0(this), "Exception: {0}", new object[1] { ex });
				Delegate341.smethod_0(this);
				throw;
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

	internal string method_3()
	{
		string result = null;
		if (Delegate354.smethod_0(gclass7_1) > 0)
		{
			result = string.Format(CultureInfo.CurrentCulture, "Error output was \"{0}\". ", new object[1] { Delegate356.smethod_0(gclass7_1) });
		}
		return result;
	}

	private static string smethod_0(GClass7 gclass7_2)
	{
		string[] value = new string[Delegate354.smethod_0(gclass7_2)];
		Delegate371.smethod_0(gclass7_2, value, 0);
		return string.Join(Environment.NewLine, value);
	}

	public string method_4(GClass17 gclass17_0)
	{
		Class6 @class = Delegate333.smethod_0(Delegate328.smethod_0(this));
		try
		{
			Delegate327.smethod_0(this);
			if (Delegate344.smethod_0(this) || 1 == 0)
			{
				throw new InvalidOperationException("Session is already opened");
			}
			try
			{
				Delegate337.smethod_0(this);
				string text = default(string);
				string text2 = default(string);
				string text3 = default(string);
				while (true)
				{
					int num = Class8.smethod_0(37);
					int num2 = 15;
					while (true)
					{
						num2 ^= 0x64;
						while (true)
						{
							int num3 = Class8.smethod_0(38);
							int num4 = Class8.smethod_0(37);
							while (true)
							{
								num4 ^= 0x6D;
								while (true)
								{
									int num5 = 6;
									int num6 = -5;
									while (true)
									{
										num6 ^= 0x62;
										while (true)
										{
											int num7 = 8;
											int num8 = 13;
											while (true)
											{
												num8 ^= 0x67;
												int num9 = GEventArgs2.smethod_0(46);
												int num10 = -12;
												num10 = -106;
												while (true)
												{
													IL_0296:
													num9 ^= 0x61;
													while (true)
													{
														num10 = GEventArgs2.smethod_0(49);
														switch (num10 ^ 0x62)
														{
														case -108:
															goto end_IL_0037;
														case -109:
															goto IL_0085;
														case -106:
															goto IL_0296;
														case -107:
															while (true)
															{
																num10 = -9;
																num10 = -107;
															}
														}
														continue;
														end_IL_0037:
														break;
													}
													switch (num9)
													{
													case -107:
														goto IL_009b;
													case -106:
														goto IL_00a9;
													case -108:
														goto IL_028e;
													case -105:
														goto end_IL_0296;
													}
													num10 = -15;
													num10 = -109;
													goto IL_0085;
													IL_028e:
													num8 = 14;
													num9 = -10;
													continue;
													IL_0273:
													num5 ^= 0x6B;
													goto IL_027a;
													IL_00a9:
													switch (num8)
													{
													case 105:
														goto IL_00cc;
													case 106:
														goto IL_0287;
													case 103:
														goto IL_02a2;
													case 104:
														goto end_IL_02ab;
													}
													num9 = -11;
													continue;
													IL_02a2:
													num8 = 0;
													break;
													IL_00cc:
													switch (num7)
													{
													case 98:
														break;
													case 99:
														goto IL_00f4;
													case 97:
														goto IL_027a;
													default:
														goto IL_02a7;
													case 100:
														goto end_IL_02c5;
													}
													num7 = 9;
													goto IL_0287;
													IL_02a7:
													num8 = 15;
													break;
													IL_00f4:
													switch (num6)
													{
													case -106:
														goto IL_0117;
													case -103:
														goto IL_0273;
													case -105:
														goto IL_02d9;
													case -104:
														goto end_IL_02dd;
													}
													num7 = 10;
													goto IL_0287;
													IL_02d9:
													num6 = -11;
													goto end_IL_02c5;
													IL_0117:
													switch (num5)
													{
													case 108:
														break;
													case 109:
														goto IL_013e;
													case 107:
														goto IL_0267;
													default:
														goto IL_02ce;
													case 110:
														goto end_IL_02e6;
													}
													num5 = 7;
													goto IL_0273;
													IL_02ce:
													num6 = Class8.smethod_0(48);
													goto end_IL_02c5;
													IL_013e:
													switch (num4)
													{
													case -102:
														goto IL_0160;
													case -99:
														goto IL_0260;
													case -101:
														goto IL_02f5;
													case -100:
														goto end_IL_02f9;
													}
													num5 = 0;
													goto IL_0273;
													IL_02f5:
													num4 = -10;
													goto end_IL_02e6;
													IL_0160:
													switch (num3)
													{
													case -109:
														break;
													case -107:
														goto IL_0188;
													case -108:
														goto IL_0253;
													default:
														goto IL_02ef;
													case -106:
														goto end_IL_0302;
													}
													num3 = -6;
													goto IL_0260;
													IL_02ef:
													num4 = -15;
													goto end_IL_02e6;
													IL_0188:
													switch (num2)
													{
													case 106:
														goto IL_01ab;
													case 107:
														goto IL_024c;
													case 104:
														goto IL_0316;
													case 105:
														goto end_IL_0320;
													}
													num3 = -3;
													goto IL_0260;
													IL_0316:
													num2 = 12;
													goto end_IL_0302;
													IL_01ab:
													switch (num)
													{
													case -100:
														break;
													case -99:
														goto IL_01e8;
													case -98:
														goto IL_01fb;
													case -97:
														goto IL_020f;
													case -96:
														goto IL_023c;
													case -95:
														goto IL_0248;
													default:
														goto IL_031c;
													case -94:
														goto IL_034e;
													}
													Delegate351.smethod_0(this, gclass17_0, bool_0: true, ref text, ref text2);
													num = -15;
													goto IL_024c;
													IL_031c:
													num2 = 13;
													goto end_IL_0302;
													IL_0248:
													num = -51;
													goto IL_024c;
													IL_023c:
													Delegate349.smethod_0(this);
													num = -50;
													goto IL_024c;
													IL_020f:
													Delegate347.smethod_0(class16_0, method_35);
													Delegate348.smethod_0(class16_0);
													num = Class9.smethod_0(101);
													goto IL_024c;
													IL_01fb:
													class16_0 = Delegate372.smethod_0(this, text3);
													num = -13;
													goto IL_024c;
													IL_01e8:
													text3 = "/fingerprintscan " + text;
													num = -14;
													goto IL_024c;
													IL_0085:
													num9 = GEventArgs2.smethod_0(46);
													num10 = -12;
													num10 = -106;
													continue;
													IL_024c:
													num ^= 0x6C;
													goto IL_0253;
													IL_0253:
													num2 = 14;
													num3 = Class8.smethod_0(39);
													goto IL_0260;
													IL_027a:
													num6 = Class55.smethod_1(71);
													num7 = 15;
													goto IL_0287;
													IL_009b:
													num9 = Class55.smethod_1(71);
													continue;
													IL_0260:
													num3 ^= 0x69;
													goto IL_0267;
													IL_0267:
													num4 = GEventArgs2.smethod_0(46);
													num5 = 5;
													goto IL_0273;
													IL_0287:
													num7 ^= 0x6B;
													goto IL_028e;
													continue;
													end_IL_0296:
													break;
												}
												continue;
												end_IL_02ab:
												break;
											}
											continue;
											end_IL_02c5:
											break;
										}
										continue;
										end_IL_02dd:
										break;
									}
									continue;
									end_IL_02e6:
									break;
								}
								continue;
								end_IL_02f9:
								break;
							}
							continue;
							end_IL_0302:
							break;
						}
						continue;
						IL_034e:
						while ((!Delegate358.smethod_0(class16_0)) ? true : false)
						{
							Thread.Sleep(50);
							Delegate363.smethod_0(this, null);
						}
						string result = string.Join(Environment.NewLine, new List<string>(Delegate353.smethod_0(this)).ToArray());
						if ((Delegate362.smethod_0(class16_0) != 0) ? true : false)
						{
							throw Delegate373.smethod_0(this, result);
						}
						return result;
						continue;
						end_IL_0320:
						break;
					}
				}
			}
			catch (Exception ex)
			{
				Delegate45.smethod_0(Delegate328.smethod_0(this), "Exception: {0}", new object[1] { ex });
				throw;
			}
			finally
			{
				Delegate341.smethod_0(this);
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

	public void method_5()
	{
		Class6 @class = Delegate333.smethod_0(Delegate328.smethod_0(this));
		try
		{
			Delegate332.smethod_0(this);
			Delegate341.smethod_0(this);
		}
		finally
		{
			if (@class != null || 1 == 0)
			{
				((IDisposable)@class).Dispose();
			}
		}
	}

	public GClass2 method_6(string string_8)
	{
		Class6 @class = Delegate333.smethod_0(Delegate328.smethod_0(this));
		try
		{
			Delegate332.smethod_0(this);
			string text2 = default(string);
			GClass2 gClass2 = default(GClass2);
			while (true)
			{
				int num = GEventArgs2.smethod_0(49);
				int num2 = 0;
				while (true)
				{
					num2 ^= 0x66;
					while (true)
					{
						int num3 = Class8.smethod_0(39);
						int num4 = 14;
						while (true)
						{
							num4 ^= 0x62;
							while (true)
							{
								int num5 = 12;
								int num6 = -16;
								while (true)
								{
									num6 ^= 0x67;
									while (true)
									{
										int num7 = 9;
										int num8 = -3;
										while (true)
										{
											num8 ^= 0x6B;
											int num9 = GEventArgs2.smethod_0(43);
											while (true)
											{
												switch (num9 ^ 0x61)
												{
												case -103:
													break;
												case -105:
													goto IL_01b5;
												default:
													num9 = GEventArgs2.smethod_0(43);
													continue;
												case -102:
													goto end_IL_01d2;
												case -104:
													while (true)
													{
														num9 = -7;
														num9 = -104;
													}
												}
												switch (num8)
												{
												case -108:
													goto IL_003e;
												case -106:
													goto IL_01ae;
												case -109:
													goto IL_01f5;
												case -107:
													goto end_IL_0204;
												}
												num9 = -10;
												num9 = -105;
												goto IL_01b5;
												IL_018e:
												num4 = 8;
												num5 = 14;
												goto IL_0195;
												IL_01f5:
												num8 = -8;
												break;
												IL_003e:
												switch (num7)
												{
												case 106:
													break;
												case 105:
													goto IL_019c;
												case 107:
													goto IL_01ab;
												default:
													goto IL_01fb;
												case 108:
													goto end_IL_0216;
												}
												switch (num6)
												{
												case -107:
													goto IL_0080;
												case -105:
													goto IL_0195;
												case -106:
													goto IL_0226;
												case -108:
													goto end_IL_022f;
												}
												num7 = 10;
												goto IL_01ae;
												IL_01fb:
												num8 = Class8.smethod_0(42);
												break;
												IL_01ab:
												num7 = 8;
												goto IL_01ae;
												IL_019c:
												num6 = GEventArgs2.smethod_0(44);
												num7 = 15;
												goto IL_01ae;
												IL_0226:
												num6 = Class55.smethod_1(72);
												goto end_IL_0216;
												IL_0080:
												switch (num5)
												{
												case 103:
													break;
												case 104:
													goto IL_00a7;
												case 105:
													goto IL_018e;
												default:
													goto IL_0220;
												case 106:
													goto end_IL_0238;
												}
												num5 = 3;
												goto IL_0195;
												IL_0220:
												num6 = -13;
												goto end_IL_0216;
												IL_00a7:
												switch (num4)
												{
												case 106:
													goto IL_00ca;
												case 108:
													goto IL_0187;
												case 105:
													goto IL_0242;
												case 107:
													goto end_IL_024c;
												}
												num5 = 13;
												goto IL_0195;
												IL_0242:
												num4 = 11;
												goto end_IL_0238;
												IL_00ca:
												switch (num3)
												{
												case -104:
													break;
												case -103:
													goto IL_0175;
												case -102:
													goto IL_017b;
												default:
													goto IL_0248;
												case -101:
													goto end_IL_0255;
												}
												switch (num2)
												{
												case 100:
													goto IL_0109;
												case 102:
													goto IL_016c;
												case 99:
													goto IL_0264;
												case 101:
													goto end_IL_026c;
												}
												num3 = -3;
												goto IL_0187;
												IL_0248:
												num4 = 9;
												goto end_IL_0238;
												IL_0175:
												num3 = -2;
												goto IL_0187;
												IL_01ae:
												num7 ^= 0x63;
												goto IL_01b5;
												IL_0264:
												num2 = 5;
												goto end_IL_0255;
												IL_0109:
												switch (num)
												{
												case -97:
													break;
												case -96:
													goto IL_015c;
												case -95:
													goto IL_0162;
												default:
													goto IL_0269;
												case -94:
												{
													Class28 class2 = Delegate367.smethod_0(class28_0);
													try
													{
														Class28 class3 = Delegate369.smethod_0(class2, "ls", Enum10.flag_0);
														try
														{
															string text = null;
															if (Delegate376.smethod_0(class3, "destination", (Enum10)0) || 1 == 0)
															{
																Delegate36.smethod_0(class3, "destination", ref text);
															}
															if (text == null || ((!Delegate377.smethod_0(class3, "files", (Enum10)0)) ? true : false))
															{
																Delegate370.smethod_0(class2, Enum10.flag_0);
																throw Delegate297.smethod_0(this, "files");
															}
															text = Delegate374.smethod_0(text);
															Class28 class4 = Delegate378.smethod_0(class3);
															try
															{
																while (Delegate377.smethod_0(class4, "file", (Enum10)0) ? true : false)
																{
																	GClass15 gClass = Delegate379.smethod_0();
																	Class28 class5 = Delegate378.smethod_0(class4);
																	try
																	{
																		while (Delegate43.smethod_0(class5, (Enum10)0) ? true : false)
																		{
																			if (Delegate36.smethod_0(class5, "filename", ref text2) || 1 == 0)
																			{
																				Delegate380.smethod_0(gClass, text2);
																				Delegate381.smethod_0(gClass, text + text2);
																			}
																			else
																			{
																				Delegate382.smethod_0(this, gClass, class5);
																			}
																		}
																		Delegate383.smethod_0(gClass2, gClass);
																	}
																	finally
																	{
																		if (class5 != null || 1 == 0)
																		{
																			((IDisposable)class5).Dispose();
																		}
																	}
																}
															}
															finally
															{
																if (class4 != null || 1 == 0)
																{
																	((IDisposable)class4).Dispose();
																}
															}
															Delegate370.smethod_0(class2, Enum10.flag_0);
														}
														finally
														{
															if (class3 != null || 1 == 0)
															{
																((IDisposable)class3).Dispose();
															}
														}
													}
													finally
													{
														if (class2 != null || 1 == 0)
														{
															((IDisposable)class2).Dispose();
														}
													}
													return gClass2;
												}
												}
												Delegate350.smethod_0(this, string.Format(CultureInfo.InvariantCulture, "ls -- \"{0}\"", new object[1] { Delegate74.smethod_0(Delegate374.smethod_0(string_8)) }));
												num = Class9.smethod_0(93);
												goto IL_016c;
												IL_0269:
												num2 = 3;
												goto end_IL_0255;
												IL_0162:
												gClass2 = Delegate375.smethod_0();
												num = -53;
												goto IL_016c;
												IL_015c:
												num = -55;
												goto IL_016c;
												IL_01b5:
												num8 = Class8.smethod_0(39);
												num9 = Class8.smethod_0(47);
												continue;
												IL_016c:
												num ^= 0x69;
												goto IL_017b;
												IL_017b:
												num2 = 2;
												num3 = Class8.smethod_0(38);
												goto IL_0187;
												IL_0195:
												num5 ^= 0x64;
												goto IL_019c;
												IL_0187:
												num3 ^= 0x67;
												goto IL_018e;
												continue;
												end_IL_01d2:
												break;
											}
											continue;
											end_IL_0204:
											break;
										}
										continue;
										end_IL_0216:
										break;
									}
									continue;
									end_IL_022f:
									break;
								}
								continue;
								end_IL_0238:
								break;
							}
							continue;
							end_IL_024c:
							break;
						}
						continue;
						end_IL_0255:
						break;
					}
					continue;
					end_IL_026c:
					break;
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

	private IEnumerable<GClass15> method_7(string string_8, Regex regex_0, GEnum8 genum8_0, bool bool_6)
	{
		Class32 @class = Delegate384.smethod_0(-2);
		@class.gclass16_0 = this;
		@class.string_1 = string_8;
		@class.regex_1 = regex_0;
		@class.genum8_1 = genum8_0;
		@class.bool_1 = bool_6;
		return @class;
	}

	public IEnumerable<GClass15> method_8(string string_8, string string_9, GEnum8 genum8_0)
	{
		Class6 @class = Delegate333.smethod_0(Delegate328.smethod_0(this));
		try
		{
			Delegate332.smethod_0(this);
			IEnumerable<GClass15> result = default(IEnumerable<GClass15>);
			Regex regex_ = default(Regex);
			while (true)
			{
				int num = GEventArgs2.smethod_0(46);
				int num2 = -56;
				while (true)
				{
					num2 ^= 0x68;
					while (true)
					{
						int num3 = Class8.smethod_0(38);
						int num4 = 6;
						while (true)
						{
							num4 ^= 0x6B;
							while (true)
							{
								int num5 = Class55.smethod_1(72);
								int num6 = -10;
								while (true)
								{
									num6 ^= 0x61;
									while (true)
									{
										int num7 = GEventArgs2.smethod_0(49);
										int num8 = 7;
										while (true)
										{
											num8 ^= 0x61;
											int num9 = Class55.smethod_1(72);
											int num10 = -51;
											num10 = -96;
											while (true)
											{
												IL_0219:
												num9 ^= 0x67;
												while (true)
												{
													num10 = GEventArgs2.smethod_0(44);
													switch (num10 ^ 0x6D)
													{
													case -97:
														goto end_IL_0017;
													case -99:
														goto IL_0065;
													case -96:
														goto IL_0219;
													case -98:
														while (true)
														{
															num10 = -13;
															num10 = -98;
														}
													}
													continue;
													end_IL_0017:
													break;
												}
												switch (num9)
												{
												case -106:
													goto IL_007b;
												case -105:
													goto IL_020c;
												case -104:
													goto IL_0212;
												case -103:
													goto end_IL_0219;
												}
												num10 = -16;
												num10 = -99;
												goto IL_0065;
												IL_01de:
												num4 = 1;
												num5 = Class8.smethod_0(38);
												goto IL_01ea;
												IL_0212:
												num8 = 4;
												num9 = -2;
												continue;
												IL_020c:
												num9 = -16;
												continue;
												IL_007b:
												switch (num8)
												{
												case 101:
													goto IL_00a3;
												case 102:
													goto IL_0203;
												case 99:
													goto IL_0225;
												case 100:
													goto end_IL_022d;
												}
												num9 = Class8.smethod_0(39);
												continue;
												IL_0225:
												num8 = 2;
												break;
												IL_00a3:
												switch (num7)
												{
												case -106:
													break;
												case -105:
													goto IL_00cb;
												case -107:
													goto IL_01f1;
												default:
													goto IL_022a;
												case -104:
													goto end_IL_0247;
												}
												num7 = -9;
												goto IL_0203;
												IL_022a:
												num8 = 5;
												break;
												IL_00cb:
												switch (num6)
												{
												case -107:
													goto IL_00ee;
												case -105:
													goto IL_01ea;
												case -108:
													goto IL_0255;
												case -106:
													goto end_IL_0264;
												}
												num7 = -12;
												goto IL_0203;
												IL_0255:
												num6 = GEventArgs2.smethod_0(40);
												goto end_IL_0247;
												IL_00ee:
												switch (num5)
												{
												case -105:
													break;
												case -104:
													goto IL_01d8;
												case -103:
													goto IL_01de;
												default:
													goto IL_0260;
												case -102:
													goto end_IL_026d;
												}
												switch (num4)
												{
												case 106:
													goto IL_012f;
												case 109:
													goto IL_01cf;
												case 108:
													goto IL_0281;
												case 107:
													goto end_IL_0284;
												}
												num5 = -1;
												goto IL_01ea;
												IL_0260:
												num6 = -9;
												goto end_IL_0247;
												IL_01d8:
												num5 = -2;
												goto IL_01ea;
												IL_0203:
												num7 ^= 0x61;
												goto IL_0212;
												IL_0281:
												num4 = 7;
												goto end_IL_026d;
												IL_012f:
												switch (num3)
												{
												case -97:
													break;
												case -96:
													goto IL_01b7;
												case -95:
													goto IL_01c2;
												default:
													goto IL_027c;
												case -94:
													goto end_IL_028d;
												}
												switch (num2)
												{
												case -98:
													goto IL_016e;
												case -96:
													goto IL_01b0;
												case -97:
													goto IL_02a6;
												case -99:
													goto end_IL_02aa;
												}
												num3 = -62;
												goto IL_01cf;
												IL_027c:
												num4 = 0;
												goto end_IL_026d;
												IL_01b7:
												num3 = Class9.smethod_0(99);
												goto IL_01cf;
												IL_01f1:
												num6 = Class55.smethod_1(71);
												num7 = Class8.smethod_0(57);
												goto IL_0203;
												IL_02a6:
												num2 = -9;
												goto end_IL_028d;
												IL_016e:
												switch (num)
												{
												case -102:
													break;
												case -101:
													goto IL_019c;
												case -100:
													goto IL_01ad;
												default:
													goto IL_029b;
												case -99:
													return result;
												}
												result = Delegate386.smethod_0(this, string_8, regex_, genum8_0, bool_0: true);
												num = -15;
												goto IL_01b0;
												IL_029b:
												num2 = GEventArgs2.smethod_0(40);
												goto end_IL_028d;
												IL_01ad:
												num = -16;
												goto IL_01b0;
												IL_019c:
												regex_ = Delegate385.smethod_0(string_9);
												num = GEventArgs2.smethod_0(49);
												goto IL_01b0;
												IL_0065:
												num9 = Class55.smethod_1(72);
												num10 = -51;
												num10 = -96;
												continue;
												IL_01b0:
												num ^= 0x6C;
												goto IL_01c2;
												IL_01c2:
												num2 = GEventArgs2.smethod_0(49);
												num3 = -63;
												goto IL_01cf;
												IL_01ea:
												num5 ^= 0x66;
												goto IL_01f1;
												IL_01cf:
												num3 ^= 0x63;
												goto IL_01de;
												continue;
												end_IL_0219:
												break;
											}
											continue;
											end_IL_022d:
											break;
										}
										continue;
										end_IL_0247:
										break;
									}
									continue;
									end_IL_0264:
									break;
								}
								continue;
								end_IL_026d:
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
					end_IL_02aa:
					break;
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

	private static Regex smethod_1(string string_8)
	{
		if (string.IsNullOrEmpty(string_8) || false || string_8 == "*.*" || 1 == 0)
		{
			string_8 = "*";
		}
		return new Regex("^" + string_8.Replace(".", "[.]").Replace("*", ".*").Replace("?", ".") + "$", RegexOptions.IgnoreCase);
	}

	public GClass14 method_9(string string_8, string string_9, bool bool_6 = false, GClass9 gclass9_0 = null)
	{
		Class6 @class = Delegate333.smethod_0(Delegate328.smethod_0(this));
		try
		{
			if (gclass9_0 == null && 0 == 0)
			{
				gclass9_0 = Delegate387.smethod_0();
			}
			Delegate332.smethod_0(this);
			GClass14 gClass = default(GClass14);
			while (true)
			{
				int num = 4;
				int num2 = Class8.smethod_0(58);
				while (true)
				{
					num2 ^= 0x68;
					while (true)
					{
						int num3 = Class8.smethod_0(41);
						int num4 = 19;
						while (true)
						{
							num4 ^= 0x63;
							int num5 = 5;
							int num6 = -1;
							num6 = -106;
							while (true)
							{
								IL_0193:
								num5 ^= 0x6C;
								num6 = Class8.smethod_0(48);
								while (true)
								{
									switch (num6 ^ 0x69)
									{
									default:
										num6 = Class8.smethod_0(48);
										continue;
									case -109:
										break;
									case -107:
										goto IL_0189;
									case -106:
										goto IL_0193;
									case -108:
										while (true)
										{
											num6 = -3;
											num6 = -108;
										}
									}
									break;
								}
								switch (num5)
								{
								case 105:
									goto IL_007d;
								case 106:
									goto IL_017b;
								case 107:
									goto IL_0184;
								case 108:
									goto end_IL_0193;
								}
								num6 = -4;
								num6 = -107;
								goto IL_0189;
								IL_0174:
								num3 ^= 0x63;
								goto IL_017b;
								IL_017b:
								num4 = 13;
								num5 = 0;
								continue;
								IL_0184:
								num5 = 7;
								continue;
								IL_007d:
								switch (num4)
								{
								case 110:
									goto IL_009f;
								case 112:
									goto IL_0174;
								case 109:
									goto IL_01a8;
								case 111:
									goto end_IL_01b2;
								}
								num5 = 6;
								continue;
								IL_01a8:
								num4 = 14;
								break;
								IL_009f:
								switch (num3)
								{
								case -99:
									break;
								case -98:
									goto IL_00c7;
								case -100:
									goto IL_0167;
								default:
									goto IL_01ae;
								case -97:
									goto end_IL_01c5;
								}
								num3 = -2;
								goto IL_0174;
								IL_01ae:
								num4 = 12;
								break;
								IL_00c7:
								switch (num2)
								{
								case -102:
									goto IL_00e9;
								case -101:
									goto IL_0160;
								case -103:
									goto IL_01d4;
								case -104:
									goto end_IL_01de;
								}
								num3 = -1;
								goto IL_0174;
								IL_01d4:
								num2 = -15;
								goto end_IL_01c5;
								IL_00e9:
								switch (num)
								{
								case 98:
									break;
								case 99:
									goto IL_010d;
								case 100:
									goto IL_0157;
								default:
									goto IL_01da;
								case 101:
								{
									Class28 class2 = Delegate367.smethod_0(class28_0);
									try
									{
										IDisposable disposable = Delegate391.smethod_0(this, gClass);
										try
										{
											IDisposable disposable2 = Delegate392.smethod_0(this);
											try
											{
												GEventArgs7 gEventArgs = null;
												bool flag = false;
												while (Delegate43.smethod_0(class2, (Enum10)0) ? true : false)
												{
													if (Delegate393.smethod_0(class2, "upload") || 1 == 0)
													{
														Delegate394.smethod_0(this, gClass, gEventArgs);
														gEventArgs = Delegate395.smethod_0(class2);
														flag = false;
													}
													else if (Delegate393.smethod_0(class2, "mkdir") || 1 == 0)
													{
														Delegate394.smethod_0(this, gClass, gEventArgs);
														gEventArgs = null;
														flag = true;
													}
													else if (Delegate393.smethod_0(class2, "chmod") || 1 == 0)
													{
														if (!flag && 0 == 0)
														{
															if (gEventArgs == null && 0 == 0)
															{
																throw new InvalidOperationException("Tag chmod before tag upload");
															}
															Delegate397.smethod_0(gEventArgs, Delegate396.smethod_0(class2));
														}
													}
													else if ((Delegate393.smethod_0(class2, "touch") || 1 == 0) && !flag && 0 == 0)
													{
														if (gEventArgs == null && 0 == 0)
														{
															throw new InvalidOperationException("Tag touch before tag upload");
														}
														Delegate399.smethod_0(gEventArgs, Delegate398.smethod_0(class2));
													}
												}
												Delegate394.smethod_0(this, gClass, gEventArgs);
											}
											finally
											{
												if (disposable2 != null || 1 == 0)
												{
													disposable2.Dispose();
												}
											}
										}
										finally
										{
											if (disposable != null || 1 == 0)
											{
												disposable.Dispose();
											}
										}
									}
									finally
									{
										if (class2 != null || 1 == 0)
										{
											((IDisposable)class2).Dispose();
										}
									}
									return gClass;
								}
								}
								num = 5;
								goto IL_0160;
								IL_01da:
								num2 = -16;
								goto end_IL_01c5;
								IL_0157:
								gClass = Delegate390.smethod_0();
								num = 2;
								goto IL_0160;
								IL_010d:
								Delegate350.smethod_0(this, string.Format(CultureInfo.InvariantCulture, "put {0} {1} -- \"{2}\" \"{3}\"", Delegate388.smethod_0(bool_6, "delete"), Delegate389.smethod_0(gclass9_0), Delegate74.smethod_0(string_8), Delegate74.smethod_0(string_9)));
								num = 3;
								goto IL_0160;
								IL_0189:
								num5 = 5;
								num6 = -1;
								num6 = -106;
								continue;
								IL_0160:
								num ^= 0x67;
								goto IL_0167;
								IL_0167:
								num2 = GEventArgs2.smethod_0(44);
								num3 = -4;
								goto IL_0174;
								continue;
								end_IL_0193:
								break;
							}
							continue;
							end_IL_01b2:
							break;
						}
						continue;
						end_IL_01c5:
						break;
					}
					continue;
					end_IL_01de:
					break;
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

	private void method_10(GClass14 gclass14_0, GEventArgs7 geventArgs7_0)
	{
		if (geventArgs7_0 != null || 1 == 0)
		{
			Delegate400.smethod_0(gclass14_0, geventArgs7_0);
			Delegate401.smethod_0(this, geventArgs7_0);
		}
	}

	public GClass14 method_11(string string_8, string string_9, bool bool_6 = false, GClass9 gclass9_0 = null)
	{
		Class6 @class = Delegate333.smethod_0(Delegate328.smethod_0(this));
		try
		{
			if (gclass9_0 == null && 0 == 0)
			{
				gclass9_0 = Delegate387.smethod_0();
			}
			Delegate332.smethod_0(this);
			GClass14 gClass = default(GClass14);
			while (true)
			{
				int num = 13;
				int num2 = -15;
				while (true)
				{
					num2 ^= 0x67;
					while (true)
					{
						int num3 = 7;
						int num4 = 19;
						while (true)
						{
							num4 ^= 0x63;
							while (true)
							{
								int num5 = 2;
								int num6 = 2;
								while (true)
								{
									num6 ^= 0x6D;
									while (true)
									{
										int num7 = Class8.smethod_0(57);
										int num8 = -3;
										while (true)
										{
											num8 ^= 0x6A;
											while (true)
											{
												int num9 = GEventArgs2.smethod_0(43);
												int num10 = Class8.smethod_0(42);
												while (true)
												{
													switch (num10 ^ 0x67)
													{
													case -103:
														break;
													default:
														goto IL_0031;
													case -104:
														goto IL_003f;
													case -105:
														goto end_IL_022a;
													case -106:
														while (true)
														{
															num10 = -15;
															num10 = -106;
														}
													}
													goto IL_002a;
													IL_003f:
													switch (num9)
													{
													case -102:
														break;
													case -101:
														goto IL_0069;
													case -100:
														goto IL_0218;
													default:
														goto IL_0250;
													case -99:
														goto end_IL_0258;
													}
													num9 = Class8.smethod_0(57);
													goto IL_002a;
													IL_0250:
													num10 = -16;
													num10 = -105;
													break;
													IL_0069:
													switch (num8)
													{
													case -108:
														goto IL_0088;
													case -105:
														goto IL_0211;
													case -107:
														goto IL_0272;
													case -106:
														goto end_IL_0275;
													}
													num9 = -1;
													goto IL_002a;
													IL_0272:
													num8 = -1;
													goto end_IL_0258;
													IL_0088:
													switch (num7)
													{
													case -104:
														break;
													case -102:
														goto IL_00b0;
													case -103:
														goto IL_0205;
													default:
														goto IL_026c;
													case -101:
														goto end_IL_027e;
													}
													num7 = -5;
													goto IL_0211;
													IL_026c:
													num8 = -4;
													goto end_IL_0258;
													IL_00b0:
													switch (num6)
													{
													case 110:
														goto IL_00d3;
													case 111:
														goto IL_01fe;
													case 109:
														goto IL_028d;
													case 108:
														goto end_IL_0295;
													}
													num7 = -6;
													goto IL_0211;
													IL_028d:
													num6 = 0;
													goto end_IL_027e;
													IL_00d3:
													switch (num5)
													{
													case 106:
														break;
													case 107:
														goto IL_00fa;
													case 105:
														goto IL_01f7;
													default:
														goto IL_0292;
													case 108:
														goto end_IL_029e;
													}
													num5 = 3;
													goto IL_01fe;
													IL_0292:
													num6 = 1;
													goto end_IL_027e;
													IL_00fa:
													switch (num4)
													{
													case 109:
														goto IL_011c;
													case 112:
														goto IL_01f0;
													case 111:
														goto IL_02ac;
													case 110:
														goto end_IL_02b0;
													}
													num5 = 0;
													goto IL_01fe;
													IL_02ac:
													num4 = 12;
													goto end_IL_029e;
													IL_011c:
													switch (num3)
													{
													case 98:
														break;
													case 99:
														goto IL_01df;
													case 100:
														goto IL_01e4;
													default:
														goto IL_02a6;
													case 101:
														goto end_IL_02b9;
													}
													switch (num2)
													{
													case -108:
														goto IL_015d;
													case -106:
														goto IL_01d6;
													case -109:
														goto IL_02c2;
													case -107:
														goto end_IL_02cc;
													}
													num3 = 1;
													goto IL_01f0;
													IL_02a6:
													num4 = 13;
													goto end_IL_029e;
													IL_01df:
													num3 = 6;
													goto IL_01f0;
													IL_0205:
													num6 = 3;
													num7 = GEventArgs2.smethod_0(43);
													goto IL_0211;
													IL_02c2:
													num2 = -12;
													goto end_IL_02b9;
													IL_015d:
													switch (num)
													{
													case 97:
														break;
													case 98:
														goto IL_01c7;
													case 99:
														goto IL_01d2;
													default:
														goto IL_02c8;
													case 100:
													{
														Class28 class2 = Delegate367.smethod_0(class28_0);
														try
														{
															IDisposable disposable = Delegate391.smethod_0(this, gClass);
															try
															{
																IDisposable disposable2 = Delegate392.smethod_0(this);
																try
																{
																	GEventArgs7 gEventArgs = null;
																	while (Delegate43.smethod_0(class2, (Enum10)0) ? true : false)
																	{
																		if (Delegate393.smethod_0(class2, "download") || 1 == 0)
																		{
																			Delegate394.smethod_0(this, gClass, gEventArgs);
																			gEventArgs = Delegate395.smethod_0(class2);
																		}
																		else if ((Delegate393.smethod_0(class2, "rm") || 1 == 0) && (gEventArgs != null || 1 == 0) && Delegate402.smethod_0(gEventArgs) == null && 0 == 0)
																		{
																			Delegate404.smethod_0(gEventArgs, Delegate403.smethod_0(class2));
																		}
																	}
																	Delegate394.smethod_0(this, gClass, gEventArgs);
																}
																finally
																{
																	if (disposable2 != null || 1 == 0)
																	{
																		disposable2.Dispose();
																	}
																}
															}
															finally
															{
																if (disposable != null || 1 == 0)
																{
																	disposable.Dispose();
																}
															}
														}
														finally
														{
															if (class2 != null || 1 == 0)
															{
																((IDisposable)class2).Dispose();
															}
														}
														return gClass;
													}
													}
													Delegate350.smethod_0(this, string.Format(CultureInfo.InvariantCulture, "get {0} {1} -- \"{2}\" \"{3}\"", Delegate388.smethod_0(bool_6, "delete"), Delegate389.smethod_0(gclass9_0), Delegate74.smethod_0(string_8), Delegate74.smethod_0(string_9)));
													num = 14;
													goto IL_01d6;
													IL_02c8:
													num2 = -14;
													goto end_IL_02b9;
													IL_01d2:
													num = 15;
													goto IL_01d6;
													IL_01c7:
													gClass = Delegate390.smethod_0();
													num = 8;
													goto IL_01d6;
													IL_0031:
													num10 = Class8.smethod_0(39);
													continue;
													IL_01d6:
													num ^= 0x6C;
													goto IL_01e4;
													IL_01e4:
													num2 = Class8.smethod_0(58);
													num3 = 0;
													goto IL_01f0;
													IL_002a:
													num9 ^= 0x63;
													goto IL_0031;
													IL_01f0:
													num3 ^= 0x65;
													goto IL_01f7;
													IL_01f7:
													num4 = 14;
													num5 = 5;
													goto IL_01fe;
													IL_0211:
													num7 ^= 0x63;
													goto IL_0218;
													IL_0218:
													num8 = Class8.smethod_0(42);
													num9 = -2;
													goto IL_002a;
													IL_01fe:
													num5 ^= 0x69;
													goto IL_0205;
													continue;
													end_IL_022a:
													break;
												}
												continue;
												end_IL_0258:
												break;
											}
											continue;
											end_IL_0275:
											break;
										}
										continue;
										end_IL_027e:
										break;
									}
									continue;
									end_IL_0295:
									break;
								}
								continue;
								end_IL_029e:
								break;
							}
							continue;
							end_IL_02b0:
							break;
						}
						continue;
						end_IL_02b9:
						break;
					}
					continue;
					end_IL_02cc:
					break;
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

	public GClass12 method_12(string string_8)
	{
		Class6 @class = Delegate333.smethod_0(Delegate328.smethod_0(this));
		try
		{
			Delegate332.smethod_0(this);
			GClass12 gClass = default(GClass12);
			while (true)
			{
				int num = 12;
				int num2 = -1;
				while (true)
				{
					num2 ^= 0x66;
					while (true)
					{
						int num3 = 14;
						int num4 = 14;
						while (true)
						{
							num4 ^= 0x66;
							while (true)
							{
								int num5 = Class8.smethod_0(58);
								int num6 = 13;
								while (true)
								{
									num6 ^= 0x6B;
									while (true)
									{
										int num7 = 7;
										int num8 = 5;
										while (true)
										{
											num8 ^= 0x68;
											while (true)
											{
												int num9 = 7;
												int num10 = Class8.smethod_0(38);
												while (true)
												{
													switch (num10 ^ 0x62)
													{
													case -98:
														break;
													default:
														goto IL_001e;
													case -100:
														goto IL_002c;
													case -99:
														goto end_IL_01e7;
													case -101:
														while (true)
														{
															num10 = -7;
															num10 = -101;
														}
													}
													goto IL_0017;
													IL_002c:
													switch (num9)
													{
													case 107:
														break;
													case 108:
														goto IL_0050;
													case 106:
														goto IL_01dc;
													default:
														goto IL_020d;
													case 109:
														goto end_IL_0214;
													}
													num9 = 0;
													goto IL_0017;
													IL_020d:
													num10 = -1;
													num10 = -99;
													break;
													IL_0050:
													switch (num8)
													{
													case 107:
														goto IL_006f;
													case 109:
														goto IL_01d5;
													case 106:
														goto IL_0222;
													case 108:
														goto end_IL_022a;
													}
													num9 = 1;
													goto IL_0017;
													IL_0222:
													num8 = 2;
													goto end_IL_0214;
													IL_006f:
													switch (num7)
													{
													case 106:
														break;
													case 107:
														goto IL_01c9;
													case 108:
														goto IL_01d2;
													default:
														goto IL_0227;
													case 109:
														goto end_IL_0233;
													}
													switch (num6)
													{
													case 101:
														goto IL_00b0;
													case 102:
														goto IL_01c2;
													case 100:
														goto IL_023b;
													case 99:
														goto end_IL_0244;
													}
													num7 = 6;
													goto IL_01d5;
													IL_0227:
													num8 = 4;
													goto end_IL_0214;
													IL_01d2:
													num7 = 1;
													goto IL_01d5;
													IL_01d5:
													num7 ^= 0x6D;
													goto IL_01dc;
													IL_023b:
													num6 = 15;
													goto end_IL_0233;
													IL_00b0:
													switch (num5)
													{
													case -107:
														break;
													case -106:
														goto IL_00d8;
													case -108:
														goto IL_01b6;
													default:
														goto IL_0241;
													case -105:
														goto end_IL_024d;
													}
													num5 = -16;
													goto IL_01c2;
													IL_0241:
													num6 = 8;
													goto end_IL_0233;
													IL_00d8:
													switch (num4)
													{
													case 102:
														goto IL_00fb;
													case 104:
														goto IL_01af;
													case 103:
														goto IL_0261;
													case 101:
														goto end_IL_0264;
													}
													num5 = -15;
													goto IL_01c2;
													IL_0261:
													num4 = 1;
													goto end_IL_024d;
													IL_00fb:
													switch (num3)
													{
													case 103:
														break;
													case 105:
														goto IL_0122;
													case 104:
														goto IL_01a2;
													default:
														goto IL_025c;
													case 106:
														goto end_IL_026d;
													}
													num3 = 0;
													goto IL_01af;
													IL_025c:
													num4 = 3;
													goto end_IL_024d;
													IL_0122:
													switch (num2)
													{
													case -106:
														goto IL_0142;
													case -103:
														goto IL_019b;
													case -104:
														goto IL_027d;
													case -105:
														goto end_IL_0286;
													}
													num3 = 15;
													goto IL_01af;
													IL_027d:
													num2 = Class8.smethod_0(42);
													goto end_IL_026d;
													IL_0142:
													switch (num)
													{
													case 109:
														break;
													case 110:
														goto IL_0167;
													case 111:
														goto IL_0173;
													default:
														goto IL_0277;
													case 112:
													{
														Class28 class2 = Delegate367.smethod_0(class28_0);
														try
														{
															IDisposable disposable = Delegate391.smethod_0(this, gClass);
															try
															{
																while (Delegate43.smethod_0(class2, (Enum10)0) ? true : false)
																{
																	if (Delegate393.smethod_0(class2, "rm") || 1 == 0)
																	{
																		Delegate406.smethod_0(gClass, Delegate403.smethod_0(class2));
																	}
																}
															}
															finally
															{
																if (disposable != null || 1 == 0)
																{
																	disposable.Dispose();
																}
															}
														}
														finally
														{
															if (class2 != null || 1 == 0)
															{
																((IDisposable)class2).Dispose();
															}
														}
														return gClass;
													}
													}
													num = 14;
													goto IL_019b;
													IL_0277:
													num2 = -15;
													goto end_IL_026d;
													IL_0173:
													Delegate350.smethod_0(this, string.Format(CultureInfo.InvariantCulture, "rm -- \"{0}\"", new object[1] { Delegate74.smethod_0(string_8) }));
													num = 13;
													goto IL_019b;
													IL_0167:
													gClass = Delegate405.smethod_0();
													num = 19;
													goto IL_019b;
													IL_001e:
													num10 = Class8.smethod_0(42);
													continue;
													IL_019b:
													num ^= 0x63;
													goto IL_01a2;
													IL_01a2:
													num2 = Class8.smethod_0(37);
													num3 = 13;
													goto IL_01af;
													IL_0017:
													num9 ^= 0x6B;
													goto IL_001e;
													IL_01c2:
													num5 ^= 0x65;
													goto IL_01c9;
													IL_01af:
													num3 ^= 0x67;
													goto IL_01b6;
													IL_01b6:
													num4 = 0;
													num5 = GEventArgs2.smethod_0(44);
													goto IL_01c2;
													IL_01c9:
													num6 = 14;
													num7 = 0;
													goto IL_01d5;
													IL_01dc:
													num8 = 3;
													num9 = 6;
													goto IL_0017;
													continue;
													end_IL_01e7:
													break;
												}
												continue;
												end_IL_0214:
												break;
											}
											continue;
											end_IL_022a:
											break;
										}
										continue;
										end_IL_0233:
										break;
									}
									continue;
									end_IL_0244:
									break;
								}
								continue;
								end_IL_024d:
								break;
							}
							continue;
							end_IL_0264:
							break;
						}
						continue;
						end_IL_026d:
						break;
					}
					continue;
					end_IL_0286:
					break;
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

	public GClass13 method_13(GEnum6 genum6_0, string string_8, string string_9, bool bool_6, bool bool_7 = false, GEnum7 genum7_0 = GEnum7.flag_1, GClass9 gclass9_0 = null)
	{
		Class6 @class = Delegate333.smethod_0(Delegate328.smethod_0(this));
		try
		{
			if (gclass9_0 == null && 0 == 0)
			{
				gclass9_0 = Delegate387.smethod_0();
			}
			Delegate332.smethod_0(this);
			if ((bool_6 || 1 == 0) && genum6_0 == GEnum6.const_2)
			{
				throw new ArgumentException("Cannot delete files in synchronization mode Both");
			}
			if ((bool_7 || 1 == 0) && genum6_0 == GEnum6.const_2)
			{
				throw new ArgumentException("Cannot mirror files in synchronization mode Both");
			}
			if (genum7_0 != GEnum7.flag_1 && genum6_0 == GEnum6.const_2)
			{
				throw new ArgumentException("Only Time criteria is allowed in synchronization mode Both");
			}
			string text = genum6_0 switch
			{
				GEnum6.const_0 => "local", 
				GEnum6.const_1 => "remote", 
				GEnum6.const_2 => "both", 
				_ => throw new ArgumentOutOfRangeException("mode"), 
			};
			string text2 = genum7_0 switch
			{
				GEnum7.flag_0 => "none", 
				GEnum7.flag_1 => "time", 
				GEnum7.flag_2 => "size", 
				GEnum7.flag_3 => "either", 
				_ => throw new ArgumentOutOfRangeException("criteria"), 
			};
			Delegate350.smethod_0(this, string.Format(CultureInfo.InvariantCulture, "synchronize {0} {1} {2} {3} -criteria=\"{4}\" -- \"{5}\" \"{6}\"", text, Delegate388.smethod_0(bool_6, "delete"), Delegate388.smethod_0(bool_7, "mirror"), Delegate389.smethod_0(gclass9_0), text2, Delegate74.smethod_0(string_8), Delegate74.smethod_0(string_9)));
			return Delegate407.smethod_0(this);
		}
		finally
		{
			if (@class != null || 1 == 0)
			{
				((IDisposable)@class).Dispose();
			}
		}
	}

	private GClass13 method_14()
	{
		Class6 @class = Delegate61.smethod_0(Delegate328.smethod_0(this));
		try
		{
			GClass13 gClass = Delegate408.smethod_0();
			Class28 class2 = Delegate367.smethod_0(class28_0);
			try
			{
				IDisposable disposable = Delegate391.smethod_0(this, gClass);
				try
				{
					IDisposable disposable2 = Delegate392.smethod_0(this);
					try
					{
						bool flag = false;
						GEventArgs7 gEventArgs = null;
						while (Delegate43.smethod_0(class2, (Enum10)0) ? true : false)
						{
							bool flag2;
							if (!(flag2 = Delegate393.smethod_0(class2, "upload")) && 0 == 0 && ((!Delegate393.smethod_0(class2, "download")) ? true : false))
							{
								if (Delegate393.smethod_0(class2, "rm") || 1 == 0)
								{
									Delegate410.smethod_0(gClass, Delegate403.smethod_0(class2));
								}
								else if (Delegate393.smethod_0(class2, "chmod") || 1 == 0)
								{
									if (gEventArgs == null && 0 == 0)
									{
										throw new InvalidOperationException("Tag chmod before tag download");
									}
									Delegate397.smethod_0(gEventArgs, Delegate396.smethod_0(class2));
								}
								else if (Delegate393.smethod_0(class2, "touch") || 1 == 0)
								{
									if (gEventArgs == null && 0 == 0)
									{
										throw new InvalidOperationException("Tag touch before tag download");
									}
									Delegate399.smethod_0(gEventArgs, Delegate398.smethod_0(class2));
								}
								continue;
							}
							Delegate409.smethod_0(this, gClass, flag, gEventArgs);
							while (true)
							{
								int num = 10;
								int num2 = -5;
								while (true)
								{
									num2 ^= 0x65;
									while (true)
									{
										int num3 = 2;
										int num4 = 1;
										while (true)
										{
											num4 ^= 0x69;
											while (true)
											{
												int num5 = 0;
												int num6 = 0;
												while (true)
												{
													num6 ^= 0x67;
													while (true)
													{
														int num7 = GEventArgs2.smethod_0(46);
														int num8 = -7;
														while (true)
														{
															IL_02d6:
															num8 ^= 0x61;
															int num9 = Class55.smethod_1(71);
															while (true)
															{
																switch (num9 ^ 0x6A)
																{
																default:
																	num9 = Class55.smethod_1(71);
																	continue;
																case -98:
																	break;
																case -100:
																	goto IL_0157;
																case -97:
																	goto IL_02d6;
																case -99:
																	while (true)
																	{
																		num9 = -9;
																		num9 = -99;
																	}
																}
																break;
															}
															switch (num8)
															{
															case -106:
																goto IL_016d;
															case -105:
																goto IL_0176;
															case -104:
																goto IL_02be;
															case -107:
																goto end_IL_02d6;
															}
															num9 = -10;
															num9 = -100;
															goto IL_0157;
															IL_0199:
															num7 = -15;
															goto IL_02be;
															IL_02ab:
															num5 ^= 0x63;
															goto IL_02b2;
															IL_0176:
															switch (num7)
															{
															case -109:
																goto IL_0199;
															case -107:
																goto IL_01a2;
															case -108:
																goto IL_02b2;
															case -106:
																goto end_IL_02eb;
															}
															num8 = -12;
															continue;
															IL_01a2:
															switch (num6)
															{
															case 100:
																goto IL_01c5;
															case 103:
																goto IL_02ab;
															case 102:
																goto IL_02ff;
															case 101:
																goto end_IL_0302;
															}
															num7 = -10;
															goto IL_02be;
															IL_02ff:
															num6 = 1;
															goto end_IL_02eb;
															IL_01c5:
															switch (num5)
															{
															case 99:
																break;
															case 100:
																goto IL_029f;
															case 101:
																goto IL_02a8;
															default:
																goto IL_02fa;
															case 102:
																goto end_IL_030b;
															}
															switch (num4)
															{
															case 103:
																goto IL_0206;
															case 104:
																goto IL_0298;
															case 101:
																goto IL_0313;
															case 102:
																goto end_IL_031d;
															}
															num5 = 7;
															goto IL_02ab;
															IL_02fa:
															num6 = 2;
															goto end_IL_02eb;
															IL_02a8:
															num5 = 6;
															goto IL_02ab;
															IL_02be:
															num7 ^= 0x62;
															num8 = GEventArgs2.smethod_0(49);
															num9 = -11;
															num9 = -97;
															continue;
															IL_0313:
															num4 = 12;
															goto end_IL_030b;
															IL_0206:
															switch (num3)
															{
															case 101:
																break;
															case 103:
																goto IL_022a;
															case 102:
																goto IL_028b;
															default:
																goto IL_0319;
															case 104:
																goto end_IL_0326;
															}
															num3 = 0;
															goto IL_0298;
															IL_0319:
															num4 = 15;
															goto end_IL_030b;
															IL_022a:
															switch (num2)
															{
															case -101:
																goto IL_0249;
															case -98:
																goto IL_0284;
															case -100:
																goto IL_0339;
															case -99:
																goto end_IL_033d;
															}
															num3 = 3;
															goto IL_0298;
															IL_0339:
															num2 = -7;
															goto end_IL_0326;
															IL_0249:
															switch (num)
															{
															case 98:
																break;
															case 99:
																goto IL_0272;
															case 100:
																goto IL_0280;
															default:
																goto IL_032e;
															case 101:
																goto end_IL_0346;
															}
															flag = flag2;
															num = 12;
															goto IL_0284;
															IL_032e:
															num2 = GEventArgs2.smethod_0(43);
															goto end_IL_0326;
															IL_0280:
															num = 13;
															goto IL_0284;
															IL_0272:
															gEventArgs = Delegate395.smethod_0(class2);
															num = 11;
															goto IL_0284;
															IL_0157:
															num8 = GEventArgs2.smethod_0(49);
															num9 = -11;
															num9 = -97;
															continue;
															IL_0284:
															num ^= 0x69;
															goto IL_028b;
															IL_028b:
															num2 = Class8.smethod_0(42);
															num3 = 13;
															goto IL_0298;
															IL_02b2:
															num6 = 3;
															num7 = Class55.smethod_1(71);
															goto IL_02be;
															IL_016d:
															num8 = -9;
															continue;
															IL_0298:
															num3 ^= 0x65;
															goto IL_029f;
															IL_029f:
															num4 = 14;
															num5 = 5;
															goto IL_02ab;
															continue;
															end_IL_02d6:
															break;
														}
														continue;
														end_IL_02eb:
														break;
													}
													continue;
													end_IL_0302:
													break;
												}
												continue;
												end_IL_030b:
												break;
											}
											continue;
											end_IL_031d:
											break;
										}
										continue;
										end_IL_0326:
										break;
									}
									continue;
									end_IL_033d:
									break;
								}
								continue;
								end_IL_0346:
								break;
							}
						}
						Delegate409.smethod_0(this, gClass, flag, gEventArgs);
					}
					finally
					{
						if (disposable2 != null || 1 == 0)
						{
							disposable2.Dispose();
						}
					}
				}
				finally
				{
					if (disposable != null || 1 == 0)
					{
						disposable.Dispose();
					}
				}
			}
			finally
			{
				if (class2 != null || 1 == 0)
				{
					((IDisposable)class2).Dispose();
				}
			}
			return gClass;
		}
		finally
		{
			if (@class != null || 1 == 0)
			{
				((IDisposable)@class).Dispose();
			}
		}
	}

	public GClass11 method_15(string string_8)
	{
		Class6 @class = Delegate333.smethod_0(Delegate328.smethod_0(this));
		try
		{
			Delegate332.smethod_0(this);
			GClass11 gClass = default(GClass11);
			string s = default(string);
			while (true)
			{
				int num = Class8.smethod_0(39);
				int num2 = 4;
				while (true)
				{
					num2 ^= 0x69;
					while (true)
					{
						int num3 = Class8.smethod_0(39);
						int num4 = 0;
						while (true)
						{
							num4 ^= 0x6B;
							while (true)
							{
								int num5 = 10;
								int num6 = -6;
								while (true)
								{
									num6 ^= 0x66;
									while (true)
									{
										int num7 = Class8.smethod_0(58);
										int num8 = 15;
										while (true)
										{
											num8 ^= 0x6A;
											while (true)
											{
												int num9 = GEventArgs2.smethod_0(44);
												int num10 = GEventArgs2.smethod_0(46);
												while (true)
												{
													switch (num10 ^ 0x6B)
													{
													case -100:
														break;
													default:
														goto IL_001e;
													case -101:
														goto IL_002c;
													case -103:
														goto end_IL_01f3;
													case -102:
														while (true)
														{
															num10 = -15;
															num10 = -102;
														}
													}
													goto IL_0017;
													IL_002c:
													switch (num9)
													{
													case -99:
														break;
													case -98:
														goto IL_0056;
													case -97:
														goto IL_01e7;
													default:
														goto IL_0219;
													case -96:
														goto end_IL_0221;
													}
													num9 = Class55.smethod_1(72);
													goto IL_0017;
													IL_0219:
													num10 = -14;
													num10 = -103;
													break;
													IL_0056:
													switch (num8)
													{
													case 98:
														goto IL_0076;
													case 101:
														goto IL_01e0;
													case 100:
														goto IL_023b;
													case 99:
														goto end_IL_023f;
													}
													num9 = -13;
													goto IL_0017;
													IL_023b:
													num8 = 14;
													goto end_IL_0221;
													IL_0076:
													switch (num7)
													{
													case -103:
														break;
													case -102:
														goto IL_00a3;
													case -104:
														goto IL_01d3;
													default:
														goto IL_0235;
													case -101:
														goto end_IL_0248;
													}
													num7 = Class8.smethod_0(37);
													goto IL_01e0;
													IL_0235:
													num8 = 9;
													goto end_IL_0221;
													IL_00a3:
													switch (num6)
													{
													case -101:
														goto IL_00c6;
													case -100:
														goto IL_01cc;
													case -102:
														goto IL_0257;
													case -103:
														goto end_IL_0260;
													}
													num7 = -15;
													goto IL_01e0;
													IL_0257:
													num6 = -4;
													goto end_IL_0248;
													IL_00c6:
													switch (num5)
													{
													case 105:
														break;
													case 104:
														goto IL_01c0;
													case 106:
														goto IL_01c8;
													default:
														goto IL_025d;
													case 107:
														goto end_IL_0269;
													}
													switch (num4)
													{
													case 106:
														goto IL_0108;
													case 107:
														goto IL_01b9;
													case 105:
														goto IL_0273;
													case 104:
														goto end_IL_027b;
													}
													num5 = 11;
													goto IL_01cc;
													IL_025d:
													num6 = -1;
													goto end_IL_0248;
													IL_01c8:
													num5 = 9;
													goto IL_01cc;
													IL_01e7:
													num8 = 8;
													num9 = -52;
													goto IL_0017;
													IL_0273:
													num4 = 2;
													goto end_IL_0269;
													IL_0108:
													switch (num3)
													{
													case -106:
														break;
													case -105:
														goto IL_01a7;
													case -104:
														goto IL_01b0;
													default:
														goto IL_0278;
													case -103:
														goto end_IL_0284;
													}
													switch (num2)
													{
													case 108:
														goto IL_0147;
													case 109:
														goto IL_01a0;
													case 107:
														goto IL_0292;
													case 106:
														goto end_IL_029a;
													}
													num3 = -2;
													goto IL_01b9;
													IL_0278:
													num4 = 3;
													goto end_IL_0269;
													IL_01b0:
													num3 = Class55.smethod_1(72);
													goto IL_01b9;
													IL_01d3:
													num6 = Class8.smethod_0(41);
													num7 = -14;
													goto IL_01e0;
													IL_0292:
													num2 = 2;
													goto end_IL_0284;
													IL_0147:
													switch (num)
													{
													case -108:
														break;
													case -107:
														goto IL_0177;
													case -106:
														goto IL_017d;
													default:
														goto IL_0297;
													case -105:
													{
														IDisposable disposable = Delegate391.smethod_0(this, gClass);
														try
														{
															Class28 class2 = Delegate367.smethod_0(class28_0);
															try
															{
																Class28 class3 = Delegate369.smethod_0(class2, "call", Enum10.flag_0);
																try
																{
																	while (Delegate43.smethod_0(class3, (Enum10)0) ? true : false)
																	{
																		if (Delegate36.smethod_0(class3, "output", ref s) || 1 == 0)
																		{
																			Delegate412.smethod_0(gClass, s);
																		}
																		if (Delegate36.smethod_0(class3, "erroroutput", ref s) || 1 == 0)
																		{
																			Delegate413.smethod_0(gClass, s);
																		}
																		if (Delegate36.smethod_0(class3, "exitcode", ref s) || 1 == 0)
																		{
																			Delegate414.smethod_0(gClass, int.Parse(s, CultureInfo.InvariantCulture));
																		}
																	}
																}
																finally
																{
																	if (class3 != null || 1 == 0)
																	{
																		((IDisposable)class3).Dispose();
																	}
																}
															}
															finally
															{
																if (class2 != null || 1 == 0)
																{
																	((IDisposable)class2).Dispose();
																}
															}
														}
														finally
														{
															if (disposable != null || 1 == 0)
															{
																disposable.Dispose();
															}
														}
														return gClass;
													}
													}
													gClass = Delegate411.smethod_0();
													num = Class8.smethod_0(42);
													goto IL_01a0;
													IL_0297:
													num2 = 3;
													goto end_IL_0284;
													IL_017d:
													Delegate350.smethod_0(this, string.Format(CultureInfo.InvariantCulture, "call {0}", new object[1] { string_8 }));
													num = -3;
													goto IL_01a0;
													IL_0177:
													num = -4;
													goto IL_01a0;
													IL_001e:
													num10 = Class8.smethod_0(37);
													continue;
													IL_01a0:
													num ^= 0x69;
													goto IL_01a7;
													IL_01a7:
													num2 = 5;
													num3 = -16;
													goto IL_01b9;
													IL_0017:
													num9 ^= 0x6C;
													goto IL_001e;
													IL_01b9:
													num3 ^= 0x69;
													goto IL_01c0;
													IL_01c0:
													num4 = 1;
													num5 = 8;
													goto IL_01cc;
													IL_01e0:
													num7 ^= 0x69;
													goto IL_01e7;
													IL_01cc:
													num5 ^= 0x63;
													goto IL_01d3;
													continue;
													end_IL_01f3:
													break;
												}
												continue;
												end_IL_0221:
												break;
											}
											continue;
											end_IL_023f:
											break;
										}
										continue;
										end_IL_0248:
										break;
									}
									continue;
									end_IL_0260:
									break;
								}
								continue;
								end_IL_0269:
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
					end_IL_029a:
					break;
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

	public GClass15 method_16(string string_8)
	{
		Class6 @class = Delegate333.smethod_0(Delegate328.smethod_0(this));
		try
		{
			Delegate332.smethod_0(this);
			return Delegate415.smethod_0(this, string_8);
		}
		finally
		{
			if (@class != null || 1 == 0)
			{
				((IDisposable)@class).Dispose();
			}
		}
	}

	public bool method_17(string string_8)
	{
		Class6 @class = Delegate333.smethod_0(Delegate328.smethod_0(this));
		try
		{
			Delegate332.smethod_0(this);
			try
			{
				Delegate415.smethod_0(this, string_8);
				return true;
			}
			catch (GException2)
			{
				return false;
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

	public byte[] method_18(string string_8, string string_9)
	{
		Class6 @class = Delegate333.smethod_0(Delegate328.smethod_0(this));
		try
		{
			Delegate350.smethod_0(this, string.Format(CultureInfo.InvariantCulture, "checksum -- \"{0}\" \"{1}\"", new object[2]
			{
				Delegate74.smethod_0(string_8),
				Delegate74.smethod_0(string_9)
			}));
			string text = null;
			Class28 class2 = Delegate367.smethod_0(class28_0);
			try
			{
				Class28 class3 = Delegate369.smethod_0(class2, "checksum", Enum10.flag_0);
				try
				{
					string text2 = default(string);
					while (Delegate43.smethod_0(class3, (Enum10)0) ? true : false)
					{
						if (Delegate36.smethod_0(class3, "checksum", ref text2) || 1 == 0)
						{
							text = text2;
						}
					}
					Delegate370.smethod_0(class2, Enum10.flag_0);
				}
				finally
				{
					if (class3 != null || 1 == 0)
					{
						((IDisposable)class3).Dispose();
					}
				}
			}
			finally
			{
				if (class2 != null || 1 == 0)
				{
					((IDisposable)class2).Dispose();
				}
			}
			int length = text.Length;
			if (length % 2 != 0 || 1 == 0)
			{
				string text3 = string.Format(CultureInfo.CurrentCulture, "Invalid string representation of checksum - {0}", new object[1] { text });
				throw Delegate57.smethod_0(this, text3);
			}
			int num = length / 2;
			int num12 = default(int);
			byte[] array = default(byte[]);
			while (true)
			{
				int num2 = 14;
				int num3 = 8;
				while (true)
				{
					num3 ^= 0x61;
					while (true)
					{
						int num4 = GEventArgs2.smethod_0(43);
						int num5 = 0;
						while (true)
						{
							num5 ^= 0x65;
							while (true)
							{
								int num6 = 0;
								int num7 = -1;
								while (true)
								{
									num7 ^= 0x66;
									while (true)
									{
										int num8 = 8;
										int num9 = 6;
										while (true)
										{
											num9 ^= 0x69;
											int num10 = Class8.smethod_0(48);
											int num11 = -49;
											num11 = -94;
											while (true)
											{
												IL_0325:
												num10 ^= 0x62;
												while (true)
												{
													num11 = Class9.smethod_0(101);
													while (true)
													{
														switch (num11 ^ 0x6D)
														{
														case -96:
															num11 = Class9.smethod_0(106);
															continue;
														case -95:
															goto end_IL_011e;
														case -97:
															goto IL_014b;
														case -94:
															goto IL_0325;
														}
														break;
													}
													continue;
													end_IL_011e:
													break;
												}
												switch (num10)
												{
												case -105:
													goto IL_0161;
												case -104:
													goto IL_016a;
												case -106:
													goto IL_0319;
												case -103:
													goto end_IL_0325;
												}
												num11 = -14;
												num11 = -97;
												goto IL_014b;
												IL_02ff:
												num7 = Class55.smethod_1(72);
												num8 = 10;
												goto IL_0312;
												IL_0319:
												num9 = 4;
												num10 = Class8.smethod_0(47);
												continue;
												IL_016a:
												switch (num9)
												{
												case 109:
													goto IL_018d;
												case 111:
													goto IL_0312;
												case 110:
													goto IL_0336;
												case 108:
													goto end_IL_0339;
												}
												num10 = -12;
												continue;
												IL_0336:
												num9 = 7;
												break;
												IL_018d:
												switch (num8)
												{
												case 109:
													break;
												case 108:
													goto IL_02ff;
												case 110:
													goto IL_030e;
												default:
													goto IL_0331;
												case 111:
													goto end_IL_0353;
												}
												switch (num7)
												{
												case -105:
													goto IL_01cf;
												case -103:
													goto IL_02f8;
												case -104:
													goto IL_0361;
												case -106:
													goto end_IL_0365;
												}
												num8 = 9;
												goto IL_0312;
												IL_0331:
												num9 = 5;
												break;
												IL_030e:
												num8 = 11;
												goto IL_0312;
												IL_0312:
												num8 ^= 0x65;
												goto IL_0319;
												IL_0361:
												num7 = -2;
												goto end_IL_0353;
												IL_01cf:
												switch (num6)
												{
												case 108:
													break;
												case 109:
													goto IL_01f6;
												case 107:
													goto IL_02f2;
												default:
													goto IL_035b;
												case 110:
													goto end_IL_036e;
												}
												num6 = 1;
												goto IL_02f8;
												IL_035b:
												num7 = -16;
												goto end_IL_0353;
												IL_01f6:
												switch (num5)
												{
												case 98:
													goto IL_0218;
												case 101:
													goto IL_02eb;
												case 99:
													goto IL_037b;
												case 100:
													goto end_IL_037e;
												}
												num6 = 6;
												goto IL_02f8;
												IL_037b:
												num5 = 6;
												goto end_IL_036e;
												IL_0218:
												switch (num4)
												{
												case -98:
													break;
												case -97:
													goto IL_02de;
												case -96:
													goto IL_02e4;
												default:
													goto IL_0376;
												case -95:
													goto end_IL_0387;
												}
												switch (num3)
												{
												case 102:
													goto IL_025f;
												case 105:
													goto IL_02d5;
												case 104:
													goto IL_039a;
												case 103:
													goto end_IL_039e;
												}
												num4 = Class9.smethod_0(91);
												goto IL_02eb;
												IL_0376:
												num5 = 1;
												goto end_IL_036e;
												IL_02de:
												num4 = -7;
												goto IL_02eb;
												IL_0161:
												num10 = -11;
												continue;
												IL_039a:
												num3 = 9;
												goto end_IL_0387;
												IL_025f:
												switch (num2)
												{
												case 100:
													break;
												case 101:
													goto IL_0294;
												case 102:
													if (num12 != 0)
													{
														goto IL_029e;
													}
													goto IL_02b3;
												case 103:
													goto IL_02a4;
												case 104:
													num12++;
													goto IL_02b3;
												case 99:
													goto IL_02bb;
												default:
													goto IL_0395;
													IL_02b3:
													if (num12 >= num)
													{
														return array;
													}
													goto IL_02bb;
												}
												array = new byte[num];
												num2 = 13;
												goto IL_02d5;
												IL_0395:
												num3 = 6;
												goto end_IL_0387;
												IL_02a4:
												num12 = 0;
												num2 = 12;
												goto IL_02d5;
												IL_029e:
												num2 = 9;
												goto IL_02d5;
												IL_02bb:
												array[num12] = Convert.ToByte(text.Substring(num12 * 2, 2), 16);
												num2 = 2;
												goto IL_02d5;
												IL_0294:
												num2 = 15;
												goto IL_02d5;
												IL_014b:
												num10 = Class8.smethod_0(48);
												num11 = -49;
												num11 = -94;
												continue;
												IL_02d5:
												num2 ^= 0x6A;
												goto IL_02e4;
												IL_02e4:
												num3 = 7;
												num4 = -57;
												goto IL_02eb;
												IL_02f8:
												num6 ^= 0x6D;
												goto IL_02ff;
												IL_02eb:
												num4 ^= 0x66;
												goto IL_02f2;
												IL_02f2:
												num5 = 7;
												num6 = 3;
												goto IL_02f8;
												continue;
												end_IL_0325:
												break;
											}
											continue;
											end_IL_0339:
											break;
										}
										continue;
										end_IL_0353:
										break;
									}
									continue;
									end_IL_0365:
									break;
								}
								continue;
								end_IL_036e:
								break;
							}
							continue;
							end_IL_037e:
							break;
						}
						continue;
						end_IL_0387:
						break;
					}
					continue;
					end_IL_039e:
					break;
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

	public void method_19(string string_8)
	{
		Class6 @class = Delegate333.smethod_0(Delegate328.smethod_0(this));
		try
		{
			Delegate332.smethod_0(this);
			Delegate350.smethod_0(this, string.Format(CultureInfo.InvariantCulture, "mkdir \"{0}\"", new object[1] { Delegate74.smethod_0(string_8) }));
			Class28 class2 = Delegate367.smethod_0(class28_0);
			try
			{
				Class28 class3 = Delegate369.smethod_0(class2, "mkdir", Enum10.flag_0);
				try
				{
					Delegate368.smethod_0(class3, (Enum10)0);
					Delegate370.smethod_0(class2, Enum10.flag_0);
				}
				finally
				{
					if (class3 != null || 1 == 0)
					{
						((IDisposable)class3).Dispose();
					}
				}
			}
			finally
			{
				if (class2 != null || 1 == 0)
				{
					((IDisposable)class2).Dispose();
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

	public void method_20(string string_8, string string_9)
	{
		Class6 @class = Delegate333.smethod_0(Delegate328.smethod_0(this));
		try
		{
			Delegate332.smethod_0(this);
			Delegate350.smethod_0(this, string.Format(CultureInfo.InvariantCulture, "mv \"{0}\" \"{1}\"", new object[2]
			{
				Delegate74.smethod_0(string_8),
				Delegate74.smethod_0(string_9)
			}));
			Class28 class2 = Delegate367.smethod_0(class28_0);
			try
			{
				if (!Delegate377.smethod_0(class2, "mv", Enum10.flag_0) && 0 == 0)
				{
					throw Delegate373.smethod_0(this, string.Format(CultureInfo.CurrentCulture, "{0} not found.", new object[1] { string_8 }));
				}
				Class28 class3 = Delegate378.smethod_0(class2);
				try
				{
					Delegate368.smethod_0(class3, (Enum10)0);
					Delegate370.smethod_0(class2, Enum10.flag_0);
				}
				finally
				{
					if (class3 != null || 1 == 0)
					{
						((IDisposable)class3).Dispose();
					}
				}
			}
			finally
			{
				if (class2 != null || 1 == 0)
				{
					((IDisposable)class2).Dispose();
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

	public string method_21(string string_8)
	{
		if (string_8 == null && 0 == 0)
		{
			throw new ArgumentNullException("fileMask");
		}
		int num = string_8.LastIndexOf('/');
		string obj = ((num > 0) ? string_8.Substring(0, num + 1) : string.Empty);
		string text = ((num > 0) ? string_8.Substring(num + 1) : string_8);
		text = text.Replace("[", "[[]").Replace("*", "[*]").Replace("?", "[?]");
		return obj + text;
	}

	public string method_22(string string_8, string string_9, string string_10)
	{
		if (string_8 == null && 0 == 0)
		{
			throw new ArgumentNullException("remotePath");
		}
		if (string_9 == null && 0 == 0)
		{
			throw new ArgumentNullException("remoteRoot");
		}
		if (string_10 == null && 0 == 0)
		{
			throw new ArgumentNullException("localRoot");
		}
		if (string_10.Length > 0 && !string_10.EndsWith("\\", StringComparison.Ordinal) && 0 == 0)
		{
			string_10 += "\\";
		}
		if (string_9.Length > 0 && !string_9.EndsWith("/", StringComparison.Ordinal) && 0 == 0)
		{
			string_9 += "/";
		}
		if (string_8 == string_9 || 1 == 0)
		{
			return string_10;
		}
		if (!string_8.StartsWith(string_9, StringComparison.Ordinal) && 0 == 0)
		{
			throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, "{0} does not start with {1}", new object[2] { string_8, string_9 }));
		}
		string text = string_8.Substring(string_9.Length);
		if (text.StartsWith("/", StringComparison.Ordinal) || 1 == 0)
		{
			text = text.Substring(1);
		}
		text = text.Replace('/', '\\');
		return string_10 + text;
	}

	public string method_23(string string_8, string string_9, string string_10)
	{
		if (string_8 == null && 0 == 0)
		{
			throw new ArgumentNullException("localPath");
		}
		if (string_9 == null && 0 == 0)
		{
			throw new ArgumentNullException("localRoot");
		}
		if (string_10 == null && 0 == 0)
		{
			throw new ArgumentNullException("remoteRoot");
		}
		if (string_9.Length > 0 && !string_9.EndsWith("\\", StringComparison.Ordinal) && 0 == 0)
		{
			string_9 += "\\";
		}
		if (string_10.Length > 0 && !string_10.EndsWith("/", StringComparison.Ordinal) && 0 == 0)
		{
			string_10 += "/";
		}
		if (string_8 == string_9 || 1 == 0)
		{
			return string_10;
		}
		if (!string_8.StartsWith(string_9, StringComparison.Ordinal) && 0 == 0)
		{
			throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, "{0} does not start with {1}", new object[2] { string_8, string_9 }));
		}
		string text = string_8.Substring(string_9.Length);
		if (text.StartsWith("\\", StringComparison.Ordinal) || 1 == 0)
		{
			text = text.Substring(1);
		}
		text = text.Replace('\\', '/');
		return string_10 + text;
	}

	public string method_24(string string_8, string string_9)
	{
		if (string_8 == null && 0 == 0)
		{
			throw new ArgumentNullException("path1");
		}
		if (string_9 == null && 0 == 0)
		{
			throw new ArgumentNullException("path2");
		}
		if (string_9.StartsWith("/", StringComparison.Ordinal) || 1 == 0)
		{
			return string_9;
		}
		return string_8 + ((((string_8.Length == 0) ? true : false) || ((string_9.Length == 0) ? true : false) || (string_8.EndsWith("/", StringComparison.Ordinal) ? true : false)) ? string.Empty : "/") + string_9;
	}

	public void method_25(string string_8, string string_9)
	{
		Delegate321.smethod_0(this);
		Delegate416.smethod_0(this).Add(string_8, string_9);
	}

	[ComRegisterFunction]
	private static void smethod_2(Type type_0)
	{
		string subkey = Delegate417.smethod_0(type_0);
		object[] customAttributes = default(object[]);
		Assembly assembly = default(Assembly);
		while (true)
		{
			int num = 5;
			int num2 = -6;
			while (true)
			{
				num2 ^= 0x64;
				while (true)
				{
					int num3 = GEventArgs2.smethod_0(44);
					int num4 = -3;
					while (true)
					{
						num4 ^= 0x63;
						while (true)
						{
							int num5 = Class8.smethod_0(48);
							int num6 = -2;
							while (true)
							{
								num6 ^= 0x67;
								while (true)
								{
									int num7 = 15;
									int num8 = 11;
									while (true)
									{
										num8 ^= 0x67;
										int num9 = 0;
										int num10 = -9;
										num10 = -97;
										while (true)
										{
											num9 ^= 0x6D;
											while (true)
											{
												num10 = Class55.smethod_1(71);
												while (true)
												{
													switch (num10 ^ 0x68)
													{
													case -100:
														break;
													default:
														goto end_IL_002f;
													case -98:
														num9 = 0;
														num10 = -9;
														num10 = -97;
														goto end_IL_0050;
													case -97:
														goto end_IL_0050;
													case -99:
														while (true)
														{
															num10 = -11;
															num10 = -99;
														}
													}
													switch (num9)
													{
													case 109:
														goto IL_005b;
													case 110:
														goto IL_01fb;
													case 111:
														goto IL_0200;
													case 112:
														goto end_IL_0215;
													}
													num10 = GEventArgs2.smethod_0(49);
													continue;
													IL_01fb:
													num9 = 3;
													goto end_IL_0050;
													continue;
													end_IL_002f:
													break;
												}
												continue;
												end_IL_0050:
												break;
											}
											continue;
											IL_02ed:
											GuidAttribute guidAttribute = (GuidAttribute)customAttributes[0];
											Registry.ClassesRoot.CreateSubKey(subkey).SetValue(null, guidAttribute.Value);
											return;
											IL_005b:
											switch (num8)
											{
											case 107:
												goto IL_007d;
											case 108:
												goto IL_01f2;
											case 106:
												goto IL_0221;
											case 105:
												goto end_IL_022b;
											}
											num9 = 2;
											continue;
											IL_0221:
											num8 = 13;
											break;
											IL_007d:
											switch (num7)
											{
											case 109:
												break;
											case 110:
												goto IL_00a5;
											case 108:
												goto IL_01e5;
											default:
												goto IL_0227;
											case 111:
												goto end_IL_023f;
											}
											num7 = 12;
											goto IL_01f2;
											IL_0227:
											num8 = 14;
											break;
											IL_00a5:
											switch (num6)
											{
											case -105:
												goto IL_00c8;
											case -103:
												goto IL_01de;
											case -106:
												goto IL_0249;
											case -104:
												goto end_IL_0252;
											}
											num7 = 13;
											goto IL_01f2;
											IL_0249:
											num6 = -15;
											goto end_IL_023f;
											IL_00c8:
											switch (num5)
											{
											case -97:
												break;
											case -98:
												goto IL_01c6;
											case -96:
												goto IL_01d5;
											default:
												goto IL_024f;
											case -95:
												goto end_IL_025b;
											}
											switch (num4)
											{
											case -101:
												goto IL_010a;
											case -98:
												goto IL_01bf;
											case -99:
												goto IL_026f;
											case -100:
												goto end_IL_0278;
											}
											num5 = -5;
											goto IL_01de;
											IL_024f:
											num6 = -1;
											goto end_IL_023f;
											IL_01d5:
											num5 = Class9.smethod_0(92);
											goto IL_01de;
											IL_01de:
											num5 ^= 0x65;
											goto IL_01e5;
											IL_026f:
											num4 = Class8.smethod_0(42);
											goto end_IL_025b;
											IL_010a:
											switch (num3)
											{
											case -101:
												break;
											case -100:
												goto IL_01ac;
											case -99:
												goto IL_01bb;
											default:
												goto IL_026a;
											case -98:
												goto end_IL_0281;
											}
											switch (num2)
											{
											case -99:
												goto IL_014e;
											case -98:
												goto IL_01a5;
											case -101:
												goto IL_0290;
											case -100:
												goto end_IL_029f;
											}
											num3 = GEventArgs2.smethod_0(40);
											goto IL_01bf;
											IL_026a:
											num4 = -1;
											goto end_IL_025b;
											IL_01bb:
											num3 = -12;
											goto IL_01bf;
											IL_01e5:
											num6 = Class8.smethod_0(37);
											num7 = 14;
											goto IL_01f2;
											IL_0290:
											num2 = Class8.smethod_0(39);
											goto end_IL_0281;
											IL_014e:
											switch (num)
											{
											case 102:
												break;
											case 103:
												goto IL_017d;
											case 104:
												goto IL_0183;
											case 105:
												goto IL_018f;
											default:
												goto IL_029b;
											case 106:
												goto IL_02ed;
											}
											if (customAttributes.Length != 0)
											{
												num = 7;
												goto IL_01a5;
											}
											if (0 == 0)
											{
												throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, "Cannot find {0} attribute for assembly {1}", new object[2]
												{
													typeof(GuidAttribute),
													assembly
												}));
											}
											goto IL_02ed;
											IL_029b:
											num2 = -8;
											goto end_IL_0281;
											IL_018f:
											customAttributes = assembly.GetCustomAttributes(typeof(GuidAttribute), inherit: false);
											num = 11;
											goto IL_01a5;
											IL_0183:
											assembly = Assembly.GetAssembly(type_0);
											num = 4;
											goto IL_01a5;
											IL_017d:
											num = 10;
											goto IL_01a5;
											IL_01bf:
											num3 ^= 0x69;
											goto IL_01c6;
											IL_01f2:
											num7 ^= 0x61;
											goto IL_0200;
											IL_01a5:
											num ^= 0x6D;
											goto IL_01ac;
											IL_01ac:
											num2 = Class8.smethod_0(57);
											num3 = -9;
											goto IL_01bf;
											IL_0200:
											num8 = 12;
											num9 = 29;
											continue;
											IL_01c6:
											num4 = GEventArgs2.smethod_0(43);
											num5 = -60;
											goto IL_01de;
											continue;
											end_IL_0215:
											break;
										}
										continue;
										end_IL_022b:
										break;
									}
									continue;
									end_IL_023f:
									break;
								}
								continue;
								end_IL_0252:
								break;
							}
							continue;
							end_IL_025b:
							break;
						}
						continue;
						end_IL_0278:
						break;
					}
					continue;
					end_IL_0281:
					break;
				}
				continue;
				end_IL_029f:
				break;
			}
		}
	}

	[ComUnregisterFunction]
	private static void smethod_3(Type type_0)
	{
		string subkey = Delegate417.smethod_0(type_0);
		Registry.ClassesRoot.DeleteSubKey(subkey, throwOnMissingSubKey: false);
	}

	private void method_26(GClass15 gclass15_0, Class27 class27_0)
	{
		Class6 @class = Delegate61.smethod_0(Delegate328.smethod_0(this));
		try
		{
			string text = default(string);
			if (Delegate36.smethod_0(class27_0, "type", ref text) || 1 == 0)
			{
				Delegate418.smethod_0(gclass15_0, text[0]);
			}
			else if (Delegate36.smethod_0(class27_0, "size", ref text) || 1 == 0)
			{
				Delegate419.smethod_0(gclass15_0, long.Parse(text, CultureInfo.InvariantCulture));
			}
			else if (Delegate36.smethod_0(class27_0, "modification", ref text) || 1 == 0)
			{
				Delegate420.smethod_0(gclass15_0, XmlConvert.ToDateTime(text, XmlDateTimeSerializationMode.Local));
			}
			else if (Delegate36.smethod_0(class27_0, "permissions", ref text) || 1 == 0)
			{
				Delegate421.smethod_0(gclass15_0, Delegate38.smethod_0(text));
			}
			else if (Delegate36.smethod_0(class27_0, "owner", ref text) || 1 == 0)
			{
				Delegate422.smethod_0(gclass15_0, text);
			}
			else if (Delegate36.smethod_0(class27_0, "group", ref text) || 1 == 0)
			{
				Delegate423.smethod_0(gclass15_0, text);
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

	internal static string smethod_4(bool bool_6, string string_8)
	{
		if (!bool_6 && 0 == 0)
		{
			return null;
		}
		return string.Format(CultureInfo.InvariantCulture, "-{0}", new object[1] { string_8 });
	}

	internal static string smethod_5(bool bool_6, string string_8, string string_9)
	{
		if (!bool_6 && 0 == 0)
		{
			return string.Format(CultureInfo.InvariantCulture, "-{0}", new object[1] { string_9 });
		}
		return string.Format(CultureInfo.InvariantCulture, "-{0}", new object[1] { string_8 });
	}

	private void method_27(GClass13 gclass13_0, bool bool_6, GEventArgs7 geventArgs7_0)
	{
		if (geventArgs7_0 != null || 1 == 0)
		{
			if (bool_6 || 1 == 0)
			{
				Delegate424.smethod_0(gclass13_0, geventArgs7_0);
			}
			else
			{
				Delegate425.smethod_0(gclass13_0, geventArgs7_0);
			}
			Delegate401.smethod_0(this, geventArgs7_0);
		}
	}

	private static string smethod_6(string string_8)
	{
		if (!string.IsNullOrEmpty(string_8) && 0 == 0 && !string_8.EndsWith("/", StringComparison.Ordinal) && 0 == 0)
		{
			string_8 += "/";
		}
		return string_8;
	}

	private void method_28()
	{
		Class6 @class = Delegate61.smethod_0(Delegate328.smethod_0(this));
		try
		{
			if (class16_0 != null || 1 == 0)
			{
				Delegate79.smethod_0(Delegate328.smethod_0(this), "Terminating process");
				try
				{
					try
					{
						Delegate350.smethod_0(this, "exit");
						Delegate426.smethod_0(class16_0);
					}
					finally
					{
						Delegate427.smethod_0(class16_0);
						class16_0 = null;
					}
				}
				catch (Exception ex)
				{
					Delegate45.smethod_0(Delegate328.smethod_0(this), "Process cleanup Exception: {0}", new object[1] { ex });
				}
			}
			Delegate79.smethod_0(Delegate328.smethod_0(this), "Disposing log readers");
			if (class28_0 != null || 1 == 0)
			{
				Delegate428.smethod_0(class28_0);
				class28_0 = null;
			}
			if (class30_0 != null || 1 == 0)
			{
				Delegate428.smethod_0(class30_0);
				class30_0 = null;
			}
			if ((Delegate357.smethod_0(this) != null || 1 == 0) && (File.Exists(Delegate357.smethod_0(this)) || 1 == 0))
			{
				Delegate45.smethod_0(Delegate328.smethod_0(this), "Deleting XML log file [{0}]", new object[1] { Delegate357.smethod_0(this) });
				try
				{
					File.Delete(Delegate357.smethod_0(this));
				}
				catch (DirectoryNotFoundException ex2)
				{
					Delegate45.smethod_0(Delegate328.smethod_0(this), "XML log cleanup DirectoryNotFoundException: {0}", new object[1] { ex2 });
				}
				catch (IOException ex3)
				{
					Delegate45.smethod_0(Delegate328.smethod_0(this), "XML log cleanup IOException: {0}", new object[1] { ex3 });
				}
				catch (UnauthorizedAccessException ex4)
				{
					Delegate45.smethod_0(Delegate328.smethod_0(this), "XML log cleanup UnauthorizedAccessException: {0}", new object[1] { ex4 });
				}
				string_5 = null;
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

	private void method_29(string string_8)
	{
		Delegate352.smethod_0(this, string_8, string_8);
	}

	private void method_30(string string_8, string string_9)
	{
		Delegate45.smethod_0(Delegate328.smethod_0(this), "Command: [{0}]", new object[1] { string_9 });
		while (true)
		{
			int num = 15;
			int num2 = 9;
			while (true)
			{
				num2 ^= 0x61;
				while (true)
				{
					int num3 = Class8.smethod_0(37);
					int num4 = -4;
					while (true)
					{
						num4 ^= 0x6A;
						while (true)
						{
							int num5 = Class8.smethod_0(47);
							int num6 = 4;
							while (true)
							{
								num6 ^= 0x6D;
								while (true)
								{
									int num7 = Class55.smethod_1(72);
									int num8 = Class8.smethod_0(58);
									while (true)
									{
										switch (num8 ^ 0x6D)
										{
										case -98:
											break;
										case -101:
											goto IL_0034;
										default:
											num8 = GEventArgs2.smethod_0(49);
											continue;
										case -100:
											goto end_IL_0184;
										case -99:
											while (true)
											{
												num8 = -16;
												num8 = -99;
											}
										}
										goto IL_001f;
										IL_0034:
										switch (num7)
										{
										case -99:
											break;
										case -100:
											goto IL_0166;
										case -98:
											goto IL_0172;
										default:
											goto IL_01a7;
										case -97:
											goto end_IL_01af;
										}
										switch (num6)
										{
										case 104:
											goto IL_0078;
										case 105:
											goto IL_015f;
										case 102:
											goto IL_01c3;
										case 103:
											goto end_IL_01cd;
										}
										num7 = Class8.smethod_0(37);
										goto IL_001f;
										IL_01a7:
										num8 = -15;
										num8 = -100;
										break;
										IL_0172:
										num7 = -14;
										goto IL_001f;
										IL_0153:
										num4 = Class8.smethod_0(39);
										num5 = -7;
										goto IL_015f;
										IL_01c3:
										num6 = 11;
										goto end_IL_01af;
										IL_0078:
										switch (num5)
										{
										case -105:
											break;
										case -104:
											goto IL_00a0;
										case -103:
											goto IL_0153;
										default:
											goto IL_01c9;
										case -102:
											goto end_IL_01d6;
										}
										num5 = -12;
										goto IL_015f;
										IL_01c9:
										num6 = 10;
										goto end_IL_01af;
										IL_00a0:
										switch (num4)
										{
										case -107:
											goto IL_00c2;
										case -106:
											goto IL_014e;
										case -108:
											goto IL_01e4;
										case -109:
											goto end_IL_01ec;
										}
										num5 = -6;
										goto IL_015f;
										IL_01e4:
										num4 = -2;
										goto end_IL_01d6;
										IL_00c2:
										switch (num3)
										{
										case -108:
											break;
										case -107:
											goto IL_0144;
										case -106:
											goto IL_014b;
										default:
											goto IL_01e9;
										case -105:
											goto end_IL_01f3;
										}
										switch (num2)
										{
										case 102:
											goto IL_0103;
										case 104:
											goto IL_013f;
										case 101:
											goto IL_0200;
										case 103:
											goto end_IL_0206;
										}
										num3 = Class55.smethod_1(72);
										goto IL_014e;
										IL_01e9:
										num4 = -7;
										goto end_IL_01d6;
										IL_014b:
										num3 = -14;
										goto IL_014e;
										IL_0166:
										num6 = 5;
										num7 = -13;
										goto IL_001f;
										IL_0200:
										num2 = 4;
										goto end_IL_01f3;
										IL_0103:
										switch (num)
										{
										case 98:
											break;
										case 99:
											goto IL_012c;
										case 100:
											goto IL_0130;
										default:
											goto IL_0204;
										case 101:
											return;
										}
										Delegate349.smethod_0(this);
										num = 14;
										goto IL_013f;
										IL_0204:
										num2 = 6;
										goto end_IL_01f3;
										IL_0130:
										Delegate429.smethod_0(class16_0, string_8);
										num = 9;
										goto IL_013f;
										IL_012c:
										num = 8;
										goto IL_013f;
										IL_001f:
										num7 ^= 0x6C;
										num8 = GEventArgs2.smethod_0(49);
										continue;
										IL_013f:
										num ^= 0x6B;
										goto IL_0144;
										IL_0144:
										num2 = 7;
										num3 = -13;
										goto IL_014e;
										IL_015f:
										num5 ^= 0x63;
										goto IL_0166;
										IL_014e:
										num3 ^= 0x64;
										goto IL_0153;
										continue;
										end_IL_0184:
										break;
									}
									continue;
									end_IL_01af:
									break;
								}
								continue;
								end_IL_01cd:
								break;
							}
							continue;
							end_IL_01d6:
							break;
						}
						continue;
						end_IL_01ec:
						break;
					}
					continue;
					end_IL_01f3:
					break;
				}
				continue;
				end_IL_0206:
				break;
			}
		}
	}

	private static void smethod_7(Class27 class27_0, Enum10 enum10_0)
	{
		while (Delegate43.smethod_0(class27_0, enum10_0) ? true : false)
		{
		}
	}

	private void method_31(GClass17 gclass17_0, bool bool_6, out string string_8, out string string_9)
	{
		Class6 @class = Delegate61.smethod_0(Delegate328.smethod_0(this));
		try
		{
			if ((Delegate430.smethod_0(gclass17_0) || 1 == 0) && Delegate431.smethod_0(gclass17_0) != GEnum9.const_3)
			{
				throw new ArgumentException("SessionOptions.WebdavSecure is set, but SessionOptions.Protocol is not Protocol.Webdav.");
			}
			string text = Delegate431.smethod_0(gclass17_0) switch
			{
				GEnum9.const_0 => "sftp://", 
				GEnum9.const_1 => "scp://", 
				GEnum9.const_2 => "ftp://", 
				GEnum9.const_3 => (Delegate430.smethod_0(gclass17_0) ? true : false) ? "https://" : "http://", 
				_ => throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "{0} is not supported", new object[1] { Delegate431.smethod_0(gclass17_0) })), 
			};
			bool flag;
			if (!bool_6 && 0 == 0)
			{
				if ((flag = !string.IsNullOrEmpty(Delegate432.smethod_0(gclass17_0))) || 1 == 0)
				{
					text += Delegate433.smethod_0(Delegate432.smethod_0(gclass17_0));
				}
			}
			else
			{
				flag = false;
			}
			string text2 = text;
			string text3 = text;
			if ((Delegate434.smethod_0(gclass17_0) != null || 1 == 0) && !bool_6 && 0 == 0)
			{
				if (!flag && 0 == 0)
				{
					throw new ArgumentException("SessionOptions.Password is set, but SessionOptions.UserName is not.");
				}
				text2 = text2 + ":" + Delegate433.smethod_0(Delegate435.smethod_0(gclass17_0));
				text3 += ":***";
			}
			string text4 = string.Empty;
			if (flag || 1 == 0)
			{
				text4 += "@";
			}
			if (string.IsNullOrEmpty(Delegate436.smethod_0(gclass17_0)) || 1 == 0)
			{
				throw new ArgumentException("SessionOptions.HostName is not set.");
			}
			text4 += Delegate433.smethod_0(Delegate436.smethod_0(gclass17_0));
			if (Delegate437.smethod_0(gclass17_0) != 0 || 1 == 0)
			{
				text4 = text4 + ":" + Delegate437.smethod_0(gclass17_0).ToString(CultureInfo.InvariantCulture);
			}
			if (!string.IsNullOrEmpty(Delegate438.smethod_0(gclass17_0)) && 0 == 0 && !bool_6 && 0 == 0)
			{
				if (Delegate431.smethod_0(gclass17_0) != GEnum9.const_3)
				{
					throw new ArgumentException("SessionOptions.WebdavRoot is set, but SessionOptions.Protocol is not Protocol.Webdav.");
				}
				text4 += Delegate438.smethod_0(gclass17_0);
			}
			text2 += text4;
			string text5 = default(string);
			while (true)
			{
				int num = 6;
				int num2 = 15;
				while (true)
				{
					num2 ^= 0x64;
					while (true)
					{
						int num3 = Class8.smethod_0(48);
						int num4 = 6;
						while (true)
						{
							num4 ^= 0x61;
							while (true)
							{
								int num5 = 5;
								int num6 = 4;
								while (true)
								{
									num6 ^= 0x61;
									int num7 = GEventArgs2.smethod_0(46);
									int num8 = -13;
									num8 = -98;
									while (true)
									{
										IL_03d3:
										num7 ^= 0x61;
										num8 = Class8.smethod_0(37);
										while (true)
										{
											switch (num8 ^ 0x6D)
											{
											case -100:
												num8 = Class55.smethod_1(72);
												continue;
											default:
												num8 = Class8.smethod_0(37);
												continue;
											case -99:
												break;
											case -101:
												goto IL_025c;
											case -98:
												goto IL_03d3;
											}
											break;
										}
										switch (num7)
										{
										case -106:
											goto IL_0272;
										case -105:
											goto IL_03c6;
										case -104:
											goto IL_03cf;
										case -103:
											goto end_IL_03d3;
										}
										num8 = -10;
										num8 = -101;
										goto IL_025c;
										IL_03c6:
										num6 = 2;
										num7 = -8;
										continue;
										IL_03ac:
										num3 ^= 0x66;
										goto IL_03b3;
										IL_03cf:
										num7 = -7;
										continue;
										IL_0272:
										switch (num6)
										{
										case 99:
											goto IL_029a;
										case 101:
											goto IL_03bf;
										case 100:
											goto IL_03ed;
										case 98:
											goto end_IL_03f0;
										}
										num7 = GEventArgs2.smethod_0(49);
										continue;
										IL_03ed:
										num6 = 5;
										break;
										IL_029a:
										switch (num5)
										{
										case 102:
											break;
										case 101:
											goto IL_03b3;
										case 103:
											goto IL_03bc;
										default:
											goto IL_03e8;
										case 104:
											goto end_IL_040a;
										}
										switch (num4)
										{
										case 101:
											goto IL_02db;
										case 103:
											goto IL_03ac;
										case 100:
											goto IL_0412;
										case 102:
											goto end_IL_041a;
										}
										num5 = 6;
										goto IL_03bf;
										IL_03e8:
										num6 = 3;
										break;
										IL_03bc:
										num5 = 4;
										goto IL_03bf;
										IL_03bf:
										num5 ^= 0x63;
										goto IL_03c6;
										IL_0412:
										num4 = 5;
										goto end_IL_040a;
										IL_02db:
										switch (num3)
										{
										case -102:
											break;
										case -100:
											goto IL_0308;
										case -101:
											goto IL_03a4;
										default:
											goto IL_0417;
										case -99:
											goto end_IL_0423;
										}
										num3 = Class8.smethod_0(38);
										goto IL_03ac;
										IL_0417:
										num4 = 7;
										goto end_IL_040a;
										IL_0308:
										switch (num2)
										{
										case 106:
											goto IL_032b;
										case 107:
											goto IL_039d;
										case 104:
											goto IL_0431;
										case 105:
											goto end_IL_043b;
										}
										num3 = -3;
										goto IL_03ac;
										IL_0431:
										num2 = 12;
										goto end_IL_0423;
										IL_032b:
										switch (num)
										{
										case 99:
											if (string.IsNullOrEmpty(text5))
											{
												goto IL_035e;
											}
											if (0 == 0)
											{
												text5 = " " + text5;
											}
											goto case 104;
										case 100:
											break;
										case 101:
											goto IL_0374;
										case 102:
											goto IL_0383;
										case 103:
											goto IL_0388;
										default:
											goto IL_0437;
										case 104:
											string_8 = "\"" + Delegate74.smethod_0(text2) + "\"" + text5;
											string_9 = "\"" + Delegate74.smethod_0(text3) + "\"" + text5;
											return;
										}
										text3 += text4;
										num = 7;
										goto IL_039d;
										IL_0437:
										num2 = 13;
										goto end_IL_0423;
										IL_0388:
										Delegate73.smethod_0(ref text5, Delegate440.smethod_0(gclass17_0), "-rawsettings");
										num = 1;
										goto IL_039d;
										IL_0383:
										num = 4;
										goto IL_039d;
										IL_0374:
										text5 = Delegate439.smethod_0(this, gclass17_0, bool_6);
										num = 5;
										goto IL_039d;
										IL_025c:
										num7 = GEventArgs2.smethod_0(46);
										num8 = -13;
										num8 = -98;
										continue;
										IL_035e:
										num = 10;
										goto IL_039d;
										IL_039d:
										num ^= 0x62;
										goto IL_03a4;
										IL_03a4:
										num2 = 14;
										num3 = -5;
										goto IL_03ac;
										IL_03b3:
										num4 = 4;
										num5 = 11;
										goto IL_03bf;
										continue;
										end_IL_03d3:
										break;
									}
									continue;
									end_IL_03f0:
									break;
								}
								continue;
								end_IL_040a:
								break;
							}
							continue;
							end_IL_041a:
							break;
						}
						continue;
						end_IL_0423:
						break;
					}
					continue;
					end_IL_043b:
					break;
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

	private string method_32(GClass17 gclass17_0, bool bool_6)
	{
		Class6 @class = Delegate61.smethod_0(Delegate328.smethod_0(this));
		try
		{
			List<string> list = new List<string>();
			if ((string.IsNullOrEmpty(Delegate441.smethod_0(gclass17_0)) || 1 == 0) && (((!Delegate442.smethod_0(gclass17_0)) ? true : false) || (bool_6 ? true : false)))
			{
				if ((Delegate443.smethod_0(gclass17_0) || 1 == 0) && (Delegate445.smethod_0(this) || 1 == 0) && !bool_6 && 0 == 0)
				{
					throw new ArgumentException("SessionOptions.Protocol is Protocol.Sftp or Protocol.Scp, but SessionOptions.SshHostKeyFingerprint is not set.");
				}
			}
			else
			{
				if (!Delegate443.smethod_0(gclass17_0) && 0 == 0)
				{
					throw new ArgumentException("SessionOptions.SshHostKeyFingerprint or SessionOptions.GiveUpSecurityAndAcceptAnySshHostKey is set, but SessionOptions.Protocol is neither Protocol.Sftp nor Protocol.Scp.");
				}
				string text = Delegate441.smethod_0(gclass17_0);
				if (Delegate442.smethod_0(gclass17_0) || 1 == 0)
				{
					Delegate79.smethod_0(Delegate328.smethod_0(this), "WARNING! Giving up security and accepting any key as configured");
					text = Delegate444.smethod_0(text);
				}
				list.Add(Delegate276.smethod_0("hostkey", text));
			}
			if (!string.IsNullOrEmpty(Delegate446.smethod_0(gclass17_0)) && 0 == 0 && !bool_6 && 0 == 0)
			{
				if (!Delegate443.smethod_0(gclass17_0) && 0 == 0)
				{
					throw new ArgumentException("SessionOptions.SshPrivateKeyPath is set, but SessionOptions.Protocol is neither Protocol.Sftp nor Protocol.Scp.");
				}
				list.Add(Delegate276.smethod_0("privatekey", Delegate446.smethod_0(gclass17_0)));
			}
			if (!string.IsNullOrEmpty(Delegate447.smethod_0(gclass17_0)) && 0 == 0 && !bool_6 && 0 == 0)
			{
				if (!Delegate448.smethod_0(gclass17_0) && 0 == 0)
				{
					throw new ArgumentException("SessionOptions.TlsClientCertificatePath is set, but neither SessionOptions.FtpSecure nor SessionOptions.WebdavSecure is enabled.");
				}
				list.Add(Delegate276.smethod_0("clientcert", Delegate447.smethod_0(gclass17_0)));
			}
			if (!string.IsNullOrEmpty(Delegate449.smethod_0(gclass17_0)) && 0 == 0 && !bool_6 && 0 == 0)
			{
				if ((string.IsNullOrEmpty(Delegate446.smethod_0(gclass17_0)) || 1 == 0) && (string.IsNullOrEmpty(Delegate447.smethod_0(gclass17_0)) || 1 == 0))
				{
					throw new ArgumentException("SessionOptions.PrivateKeyPassphrase is set, but neither SessionOptions.SshPrivateKeyPath nor SessionOptions.TlsClientCertificatePath is set.");
				}
				list.Add(Delegate276.smethod_0("passphrase", Delegate449.smethod_0(gclass17_0)));
			}
			if (Delegate450.smethod_0(gclass17_0) != 0 || 1 == 0)
			{
				if (Delegate431.smethod_0(gclass17_0) != GEnum9.const_2)
				{
					throw new ArgumentException("SessionOptions.FtpSecure is not FtpSecure.None, but SessionOptions.Protocol is not Protocol.Ftp.");
				}
				GEnum11 gEnum = Delegate450.smethod_0(gclass17_0);
				while (true)
				{
					int num = 13;
					int num2 = Class8.smethod_0(48);
					while (true)
					{
						num2 ^= 0x65;
						while (true)
						{
							int num3 = 4;
							int num4 = -15;
							while (true)
							{
								num4 ^= 0x68;
								while (true)
								{
									int num5 = Class8.smethod_0(42);
									int num6 = 6;
									while (true)
									{
										num6 ^= 0x69;
										while (true)
										{
											int num7 = Class8.smethod_0(37);
											int num8 = 12;
											while (true)
											{
												num8 ^= 0x62;
												int num9 = Class8.smethod_0(57);
												int num10 = -61;
												num10 = -96;
												while (true)
												{
													IL_03e2:
													num9 ^= 0x63;
													while (true)
													{
														num10 = Class8.smethod_0(41);
														switch (num10 ^ 0x63)
														{
														case -98:
															goto end_IL_01ec;
														case -99:
															goto IL_023a;
														case -96:
															goto IL_03e2;
														case -97:
															while (true)
															{
																num10 = -4;
																num10 = -97;
															}
														}
														continue;
														end_IL_01ec:
														break;
													}
													switch (num9)
													{
													case -103:
														goto IL_0250;
													case -102:
														goto IL_0259;
													case -104:
														goto IL_03da;
													case -101:
														goto end_IL_03e2;
													}
													num10 = -2;
													num10 = -99;
													goto IL_023a;
													IL_03a6:
													num3 ^= 0x63;
													goto IL_03b4;
													IL_03b4:
													num4 = Class8.smethod_0(37);
													num5 = Class8.smethod_0(41);
													goto IL_03c6;
													IL_0259:
													switch (num8)
													{
													case 107:
														goto IL_0281;
													case 110:
														goto IL_03d3;
													case 109:
														goto IL_03f4;
													case 108:
														goto end_IL_03f8;
													}
													num9 = Class8.smethod_0(47);
													continue;
													IL_03f4:
													num8 = 15;
													break;
													IL_0281:
													switch (num7)
													{
													case -107:
														break;
													case -105:
														goto IL_02ae;
													case -106:
														goto IL_03cd;
													default:
														goto IL_03ee;
													case -104:
														goto end_IL_0412;
													}
													num7 = GEventArgs2.smethod_0(44);
													goto IL_03d3;
													IL_03ee:
													num8 = 14;
													break;
													IL_02ae:
													switch (num6)
													{
													case 109:
														goto IL_02d1;
													case 111:
														goto IL_03c6;
													case 110:
														goto IL_0426;
													case 108:
														goto end_IL_0429;
													}
													num7 = -15;
													goto IL_03d3;
													IL_0426:
													num6 = 7;
													goto end_IL_0412;
													IL_02d1:
													switch (num5)
													{
													case -100:
														break;
													case -99:
														goto IL_03af;
													case -98:
														goto IL_03b4;
													default:
														goto IL_0421;
													case -97:
														goto end_IL_0432;
													}
													switch (num4)
													{
													case -104:
														goto IL_0313;
													case -103:
														goto IL_03a6;
													case -105:
														goto IL_0440;
													case -106:
														goto end_IL_0449;
													}
													num5 = -4;
													goto IL_03c6;
													IL_0421:
													num6 = 5;
													goto end_IL_0412;
													IL_03af:
													num5 = -1;
													goto IL_03c6;
													IL_03cd:
													num6 = 4;
													num7 = -1;
													goto IL_03d3;
													IL_0440:
													num4 = -1;
													goto end_IL_0432;
													IL_0313:
													switch (num3)
													{
													case 102:
														break;
													case 103:
														goto IL_0337;
													case 101:
														goto IL_0399;
													default:
														goto IL_0445;
													case 104:
														goto end_IL_0452;
													}
													num3 = 5;
													goto IL_03a6;
													IL_0445:
													num4 = -2;
													goto end_IL_0432;
													IL_0337:
													switch (num2)
													{
													case -100:
														goto IL_0356;
													case -97:
														goto IL_0392;
													case -98:
														goto IL_0461;
													case -99:
														goto end_IL_0465;
													}
													num3 = 6;
													goto IL_03a6;
													IL_0461:
													num2 = -5;
													goto end_IL_0452;
													IL_0356:
													switch (num)
													{
													case 101:
														break;
													case 102:
														goto IL_0382;
													case 103:
														goto IL_038e;
													default:
														goto IL_045b;
													case 104:
														throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "{0} is not supported", new object[1] { Delegate450.smethod_0(gclass17_0) }));
													}
													if (gEnum != GEnum11.const_1)
													{
														num = 14;
														goto IL_0392;
													}
													goto IL_047d;
													IL_045b:
													num2 = -8;
													goto end_IL_0452;
													IL_038e:
													num = 15;
													goto IL_0392;
													IL_0382:
													if (gEnum != GEnum11.const_2)
													{
														num = 0;
														goto IL_0392;
													}
													goto IL_048f;
													IL_023a:
													num9 = Class8.smethod_0(57);
													num10 = -61;
													num10 = -96;
													continue;
													IL_0250:
													num9 = -6;
													continue;
													IL_03d3:
													num7 ^= 0x67;
													goto IL_03da;
													IL_0392:
													num ^= 0x68;
													goto IL_0399;
													IL_0399:
													num2 = Class8.smethod_0(57);
													num3 = 11;
													goto IL_03a6;
													IL_03c6:
													num5 ^= 0x62;
													goto IL_03cd;
													IL_03da:
													num8 = 9;
													num9 = -8;
													continue;
													end_IL_03e2:
													break;
												}
												continue;
												end_IL_03f8:
												break;
											}
											continue;
											end_IL_0412:
											break;
										}
										continue;
										end_IL_0429:
										break;
									}
									continue;
									end_IL_0432:
									break;
								}
								continue;
								end_IL_0449:
								break;
							}
							continue;
							end_IL_0452:
							break;
						}
						continue;
						end_IL_0465:
						break;
					}
					continue;
					IL_047d:
					list.Add(Delegate285.smethod_0("implicit"));
					break;
					IL_048f:
					list.Add(Delegate285.smethod_0("explicit"));
					break;
				}
			}
			if ((((!string.IsNullOrEmpty(Delegate451.smethod_0(gclass17_0))) ? true : false) || Delegate452.smethod_0(gclass17_0) || 1 == 0) && !bool_6 && 0 == 0)
			{
				if (!Delegate448.smethod_0(gclass17_0) && 0 == 0)
				{
					throw new ArgumentException("SessionOptions.TlsHostCertificateFingerprint or SessionOptions.GiveUpSecurityAndAcceptAnyTlsHostCertificate is set, but neither SessionOptions.FtpSecure nor SessionOptions.WebdavSecure is enabled.");
				}
				string text2 = Delegate451.smethod_0(gclass17_0);
				if (Delegate452.smethod_0(gclass17_0) || 1 == 0)
				{
					Delegate79.smethod_0(Delegate328.smethod_0(this), "WARNING! Giving up security and accepting any certificate as configured");
					text2 = Delegate444.smethod_0(text2);
				}
				list.Add(Delegate276.smethod_0("certificate", text2));
			}
			if (Delegate431.smethod_0(gclass17_0) == GEnum9.const_2 && !bool_6 && 0 == 0)
			{
				list.Add(Delegate454.smethod_0("passive", Delegate453.smethod_0(gclass17_0) == GEnum10.const_0));
			}
			list.Add(Delegate456.smethod_0("timeout", (int)Delegate455.smethod_0(gclass17_0).TotalSeconds));
			return string.Join(" ", list.ToArray());
		}
		finally
		{
			if (@class != null || 1 == 0)
			{
				((IDisposable)@class).Dispose();
			}
		}
	}

	private static string smethod_8(string string_8)
	{
		return ((string.IsNullOrEmpty(string_8) ? true : false) ? string.Empty : (string_8 + ";")) + "*";
	}

	private GClass15 method_33(string string_8)
	{
		Class6 @class = Delegate61.smethod_0(Delegate328.smethod_0(this));
		try
		{
			Delegate350.smethod_0(this, string.Format(CultureInfo.InvariantCulture, "stat -- \"{0}\"", new object[1] { Delegate74.smethod_0(string_8) }));
			GClass15 gClass = Delegate379.smethod_0();
			Class28 class2 = Delegate367.smethod_0(class28_0);
			try
			{
				Class28 class3 = Delegate369.smethod_0(class2, "stat", Enum10.flag_0);
				try
				{
					string text = default(string);
					int num9 = default(int);
					while (Delegate43.smethod_0(class3, (Enum10)0) ? true : false)
					{
						if (Delegate36.smethod_0(class3, "filename", ref text) || 1 == 0)
						{
							string text2 = text;
							while (true)
							{
								int num = 3;
								int num2 = -12;
								while (true)
								{
									num2 ^= 0x62;
									while (true)
									{
										int num3 = 1;
										int num4 = -55;
										while (true)
										{
											num4 ^= 0x69;
											while (true)
											{
												int num5 = 5;
												int num6 = -2;
												while (true)
												{
													num6 ^= 0x64;
													int num7 = GEventArgs2.smethod_0(46);
													int num8 = -56;
													num8 = -96;
													while (true)
													{
														IL_0214:
														num7 ^= 0x62;
														num8 = GEventArgs2.smethod_0(40);
														while (true)
														{
															switch (num8 ^ 0x68)
															{
															default:
																num8 = GEventArgs2.smethod_0(40);
																continue;
															case -99:
																break;
															case -97:
																goto IL_0203;
															case -96:
																goto IL_0214;
															case -98:
																while (true)
																{
																	num8 = -10;
																	num8 = -98;
																}
															}
															break;
														}
														switch (num7)
														{
														case -107:
															goto IL_00cf;
														case -106:
															goto IL_01e9;
														case -105:
															goto IL_01fd;
														case -104:
															goto end_IL_0214;
														}
														num8 = -9;
														num8 = -97;
														goto IL_0203;
														IL_01b7:
														num2 = GEventArgs2.smethod_0(49);
														num3 = 4;
														goto IL_01c8;
														IL_01d6:
														num4 = Class55.smethod_1(71);
														num5 = 0;
														goto IL_01e2;
														IL_01fd:
														num7 = -11;
														continue;
														IL_00cf:
														switch (num6)
														{
														case -103:
															goto IL_00f2;
														case -102:
															goto IL_01e2;
														case -105:
															goto IL_0229;
														case -104:
															goto end_IL_0233;
														}
														num7 = -12;
														continue;
														IL_0229:
														num6 = -13;
														break;
														IL_00f2:
														switch (num5)
														{
														case 97:
															break;
														case 98:
															goto IL_01d1;
														case 99:
															goto IL_01d6;
														default:
															goto IL_022f;
														case 100:
															goto end_IL_024d;
														}
														switch (num4)
														{
														case -99:
															goto IL_0133;
														case -96:
															goto IL_01c8;
														case -97:
															goto IL_025c;
														case -98:
															goto end_IL_0265;
														}
														num5 = 7;
														goto IL_01e2;
														IL_022f:
														num6 = -4;
														break;
														IL_01d1:
														num5 = 6;
														goto IL_01e2;
														IL_01e2:
														num5 ^= 0x64;
														goto IL_01e9;
														IL_025c:
														num4 = GEventArgs2.smethod_0(49);
														goto end_IL_024d;
														IL_0133:
														switch (num3)
														{
														case 99:
															break;
														case 100:
															goto IL_01b7;
														case 101:
															goto IL_01c5;
														default:
															goto IL_0256;
														case 102:
															goto end_IL_026e;
														}
														switch (num2)
														{
														case -108:
															goto IL_0171;
														case -106:
															goto IL_01b0;
														case -107:
															goto IL_027d;
														case -109:
															goto end_IL_0286;
														}
														num3 = 6;
														goto IL_01c8;
														IL_0256:
														num4 = -9;
														goto end_IL_024d;
														IL_01c5:
														num3 = 7;
														goto IL_01c8;
														IL_01e9:
														num6 = Class8.smethod_0(41);
														num7 = Class8.smethod_0(48);
														continue;
														IL_027d:
														num2 = GEventArgs2.smethod_0(46);
														goto end_IL_026e;
														IL_0171:
														switch (num)
														{
														case 100:
															break;
														case 101:
															goto IL_0195;
														case 102:
															goto IL_01a2;
														default:
															goto IL_0277;
														case 103:
															goto IL_0298;
														}
														num = 1;
														goto IL_01b0;
														IL_0298:
														text2 = text2.Substring(num9 + 1);
														goto IL_02a5;
														IL_0277:
														num2 = -15;
														goto end_IL_026e;
														IL_01a2:
														num9 = text2.LastIndexOf('/');
														num = 0;
														goto IL_01b0;
														IL_0195:
														if (num9 >= 0)
														{
															num = 2;
															goto IL_01b0;
														}
														goto IL_02a5;
														IL_0203:
														num7 = GEventArgs2.smethod_0(46);
														num8 = -56;
														num8 = -96;
														continue;
														IL_02a5:
														Delegate380.smethod_0(gClass, text2);
														Delegate381.smethod_0(gClass, text);
														goto end_IL_028f;
														IL_01c8:
														num3 ^= 0x62;
														goto IL_01d6;
														IL_01b0:
														num ^= 0x65;
														goto IL_01b7;
														continue;
														end_IL_0214:
														break;
													}
													continue;
													end_IL_0233:
													break;
												}
												continue;
												end_IL_024d:
												break;
											}
											continue;
											end_IL_0265:
											break;
										}
										continue;
										end_IL_026e:
										break;
									}
									continue;
									end_IL_0286:
									break;
								}
								continue;
								end_IL_028f:
								break;
							}
						}
						else
						{
							if ((!Delegate393.smethod_0(class3, "file")) ? true : false)
							{
								continue;
							}
							Class28 class4 = Delegate378.smethod_0(class3);
							try
							{
								while (Delegate43.smethod_0(class4, (Enum10)0) ? true : false)
								{
									Delegate382.smethod_0(this, gClass, class4);
								}
							}
							finally
							{
								if (class4 != null || 1 == 0)
								{
									((IDisposable)class4).Dispose();
								}
							}
						}
					}
					Delegate370.smethod_0(class2, Enum10.flag_0);
				}
				finally
				{
					if (class3 != null || 1 == 0)
					{
						((IDisposable)class3).Dispose();
					}
				}
			}
			finally
			{
				if (class2 != null || 1 == 0)
				{
					((IDisposable)class2).Dispose();
				}
			}
			return gClass;
		}
		finally
		{
			if (@class != null || 1 == 0)
			{
				((IDisposable)@class).Dispose();
			}
		}
	}

	internal static string smethod_9(string string_8)
	{
		return string.Format(CultureInfo.InvariantCulture, "-{0}", new object[1] { string_8 });
	}

	internal static string smethod_10(string string_8, string string_9)
	{
		return string.Format(CultureInfo.InvariantCulture, "-{0}=\"{1}\"", new object[2]
		{
			string_8,
			Delegate74.smethod_0(string_9)
		});
	}

	internal static string smethod_11(string string_8, int int_2)
	{
		return string.Format(CultureInfo.InvariantCulture, "-{0}={1}", new object[2]
		{
			string_8,
			int_2.ToString(CultureInfo.InvariantCulture)
		});
	}

	internal static string smethod_12(string string_8, bool bool_6)
	{
		return Delegate456.smethod_0(string_8, (bool_6 ? true : false) ? 1 : 0);
	}

	private static string smethod_13(string string_8)
	{
		return Uri.EscapeDataString(string_8);
	}

	internal void method_34()
	{
		dateTime_0 = DateTime.Now;
	}

	private void method_35(object sender, GEventArgs0 e)
	{
		Class33 CS_0024_003C_003E8__locals0 = Delegate457.smethod_0();
		while (true)
		{
			int num = 14;
			int num2 = 1;
			while (true)
			{
				num2 ^= 0x6A;
				while (true)
				{
					int num3 = Class8.smethod_0(39);
					int num4 = Class8.smethod_0(38);
					while (true)
					{
						num4 ^= 0x64;
						while (true)
						{
							int num5 = GEventArgs2.smethod_0(40);
							int num6 = 15;
							while (true)
							{
								num6 ^= 0x63;
								while (true)
								{
									int num7 = Class8.smethod_0(47);
									int num8 = GEventArgs2.smethod_0(44);
									while (true)
									{
										switch (num8 ^ 0x64)
										{
										case -106:
											break;
										case -109:
											goto IL_0020;
										default:
											num8 = GEventArgs2.smethod_0(46);
											continue;
										case -108:
											goto end_IL_0198;
										case -107:
											while (true)
											{
												num8 = -15;
												num8 = -107;
											}
										}
										goto IL_000b;
										IL_0020:
										switch (num7)
										{
										case -104:
											break;
										case -103:
											goto IL_0175;
										case -102:
											goto IL_017e;
										default:
											goto IL_01bb;
										case -101:
											goto end_IL_01c3;
										}
										switch (num6)
										{
										case 107:
											goto IL_005f;
										case 108:
											goto IL_016c;
										case 105:
											goto IL_01d7;
										case 106:
											goto end_IL_01e1;
										}
										num7 = -7;
										goto IL_000b;
										IL_01bb:
										num8 = -16;
										num8 = -108;
										break;
										IL_0175:
										num7 = -6;
										goto IL_000b;
										IL_015f:
										num4 = Class8.smethod_0(58);
										num5 = -5;
										goto IL_016c;
										IL_01d7:
										num6 = 10;
										goto end_IL_01c3;
										IL_005f:
										switch (num5)
										{
										case -106:
											break;
										case -105:
											goto IL_0087;
										case -104:
											goto IL_015f;
										default:
											goto IL_01dd;
										case -103:
											goto end_IL_01ea;
										}
										num5 = -12;
										goto IL_016c;
										IL_01dd:
										num6 = 9;
										goto end_IL_01c3;
										IL_0087:
										switch (num4)
										{
										case -105:
											goto IL_00af;
										case -104:
											goto IL_0158;
										case -106:
											goto IL_01f9;
										case -107:
											goto end_IL_0203;
										}
										num5 = Class8.smethod_0(48);
										goto IL_016c;
										IL_01f9:
										num4 = -14;
										goto end_IL_01ea;
										IL_00af:
										switch (num3)
										{
										case -103:
											break;
										case -104:
											goto IL_0146;
										case -102:
											goto IL_014f;
										default:
											goto IL_01ff;
										case -101:
											goto end_IL_020c;
										}
										switch (num2)
										{
										case 104:
											goto IL_00ee;
										case 107:
											goto IL_013f;
										case 105:
											goto IL_0225;
										case 106:
											goto end_IL_0228;
										}
										num3 = -2;
										goto IL_0158;
										IL_01ff:
										num4 = -15;
										goto end_IL_01ea;
										IL_014f:
										num3 = Class8.smethod_0(38);
										goto IL_0158;
										IL_017e:
										num6 = 8;
										num7 = GEventArgs2.smethod_0(43);
										goto IL_000b;
										IL_0225:
										num2 = 3;
										goto end_IL_020c;
										IL_00ee:
										switch (num)
										{
										case 105:
											break;
										case 106:
											goto IL_011e;
										case 107:
											goto IL_0124;
										case 108:
											if (CS_0024_003C_003E8__locals0.geventArgs0_0 != null)
											{
												goto IL_013c;
											}
											if (false)
											{
												goto case 109;
											}
											Delegate79.smethod_0(Delegate328.smethod_0(this), "Got incomplete progress output");
											goto IL_032e;
										default:
											goto IL_0220;
										case 109:
											{
												Delegate45.smethod_0(Delegate328.smethod_0(this), "Scheduling output: [{0}]", new object[1] { Delegate458.smethod_0(CS_0024_003C_003E8__locals0.geventArgs0_0) });
												string text = Delegate458.smethod_0(CS_0024_003C_003E8__locals0.geventArgs0_0).TrimEnd(new char[1] { '\r' });
												lock (Delegate353.smethod_0(this))
												{
													Delegate459.smethod_0(Delegate353.smethod_0(this), text);
													if (Delegate354.smethod_0(Delegate353.smethod_0(this)) > 1000)
													{
														Delegate460.smethod_0(Delegate353.smethod_0(this));
													}
													if (Delegate461.smethod_0(CS_0024_003C_003E8__locals0.geventArgs0_0) || 1 == 0)
													{
														Delegate459.smethod_0(gclass7_1, text);
														if (Delegate354.smethod_0(gclass7_1) > 1000)
														{
															Delegate460.smethod_0(gclass7_1);
														}
													}
												}
												Delegate462.smethod_0(this, delegate
												{
													Delegate489.smethod_0(CS_0024_003C_003E8__locals0.gclass16_0, Delegate458.smethod_0(CS_0024_003C_003E8__locals0.geventArgs0_0), Delegate461.smethod_0(CS_0024_003C_003E8__locals0.geventArgs0_0));
												});
												goto IL_032e;
											}
											IL_032e:
											Delegate349.smethod_0(this);
											return;
										}
										CS_0024_003C_003E8__locals0.geventArgs0_0 = e;
										num = 9;
										goto IL_013f;
										IL_0220:
										num2 = 0;
										goto end_IL_020c;
										IL_013c:
										num = 8;
										goto IL_013f;
										IL_0124:
										CS_0024_003C_003E8__locals0.gclass16_0 = this;
										num = 12;
										goto IL_013f;
										IL_011e:
										num = 15;
										goto IL_013f;
										IL_000b:
										num7 ^= 0x63;
										num8 = GEventArgs2.smethod_0(46);
										continue;
										IL_013f:
										num ^= 0x65;
										goto IL_0146;
										IL_0146:
										num2 = 2;
										num3 = -3;
										goto IL_0158;
										IL_016c:
										num5 ^= 0x62;
										goto IL_017e;
										IL_0158:
										num3 ^= 0x66;
										goto IL_015f;
										continue;
										end_IL_0198:
										break;
									}
									continue;
									end_IL_01c3:
									break;
								}
								continue;
								end_IL_01e1:
								break;
							}
							continue;
							end_IL_01ea:
							break;
						}
						continue;
						end_IL_0203:
						break;
					}
					continue;
					end_IL_020c:
					break;
				}
				continue;
				end_IL_0228:
				break;
			}
		}
	}

	private void method_36(Delegate0 delegate0_0)
	{
		lock (ilist_1)
		{
			ilist_1.Add(delegate0_0);
			autoResetEvent_0.Set();
		}
	}

	internal void method_37(string string_8 = null)
	{
		if (DateTime.Now - dateTime_0 > Delegate463.smethod_0(this) || 1 == 0)
		{
			string text = "Timeout waiting for WinSCP to respond";
			if (string_8 != null || 1 == 0)
			{
				text = text + " - " + string_8;
			}
			throw new TimeoutException(text);
		}
		if (bool_4 || 1 == 0)
		{
			throw Delegate57.smethod_0(this, "Aborted.");
		}
	}

	private void method_38(GEventArgs7 geventArgs7_0)
	{
		Delegate45.smethod_0(Delegate328.smethod_0(this), "FileTransferredEvent: [{0}]", new object[1] { Delegate464.smethod_0(geventArgs7_0) });
		if (gdelegate1_0 != null || 1 == 0)
		{
			Delegate465.smethod_0(gdelegate1_0, this, geventArgs7_0);
		}
	}

	internal void method_39(GException2 gexception2_0)
	{
		Delegate45.smethod_0(Delegate328.smethod_0(this), "Failed: [{0}]", new object[1] { gexception2_0 });
		if (gdelegate3_0 != null || 1 == 0)
		{
			GDelegate3 object_ = gdelegate3_0;
			GEventArgs3 gEventArgs = Delegate466.smethod_0();
			Delegate42.smethod_0(gEventArgs, gexception2_0);
			Delegate467.smethod_0(object_, this, gEventArgs);
		}
		IEnumerator<GClass10> enumerator = ilist_0.GetEnumerator();
		try
		{
			while (enumerator.MoveNext() ? true : false)
			{
				Delegate468.smethod_0(enumerator.Current, gexception2_0);
			}
		}
		finally
		{
			if (enumerator != null || 1 == 0)
			{
				enumerator.Dispose();
			}
		}
	}

	private void method_40()
	{
		if (bool_1 || 1 == 0)
		{
			throw new InvalidOperationException("Object is disposed");
		}
		if (bool_4 || 1 == 0)
		{
			throw new InvalidOperationException("Session was aborted");
		}
	}

	private void method_41()
	{
		if (!Delegate344.smethod_0(this) && 0 == 0)
		{
			throw new InvalidOperationException("Session is not opened");
		}
	}

	private void method_42()
	{
		if (Delegate344.smethod_0(this) || 1 == 0)
		{
			throw new InvalidOperationException("Session is already opened");
		}
	}

	private void method_43(string string_8, bool bool_6)
	{
		Delegate45.smethod_0(Delegate328.smethod_0(this), "Output: [{0}]", new object[1] { string_8 });
		if (gdelegate0_0 != null || 1 == 0)
		{
			Delegate108.smethod_0(gdelegate0_0, this, Delegate110.smethod_0(string_8, bool_6));
		}
	}

	internal void method_44(int int_2)
	{
		DateTime now = DateTime.Now;
		while (autoResetEvent_0.WaitOne(int_2, exitContext: false) ? true : false)
		{
			lock (ilist_1)
			{
				IEnumerator<Delegate0> enumerator = ilist_1.GetEnumerator();
				try
				{
					while (enumerator.MoveNext() ? true : false)
					{
						Delegate469.smethod_0(enumerator.Current);
					}
				}
				finally
				{
					if (enumerator != null || 1 == 0)
					{
						enumerator.Dispose();
					}
				}
				ilist_1.Clear();
			}
			int_2 -= (int)(DateTime.Now - now).TotalMilliseconds;
			if (int_2 >= 0)
			{
				now = DateTime.Now;
				continue;
			}
			break;
		}
	}

	private IDisposable method_45(GClass10 gclass10_0)
	{
		ilist_0.Add(gclass10_0);
		return Delegate470.smethod_0(this, gclass10_0);
	}

	internal void method_46(GClass10 gclass10_0)
	{
		ilist_0.Remove(gclass10_0);
	}

	private IDisposable method_47()
	{
		Class6 @class = Delegate61.smethod_0(Delegate328.smethod_0(this));
		try
		{
			int_1++;
			return Delegate471.smethod_0(this);
		}
		finally
		{
			if (@class != null || 1 == 0)
			{
				((IDisposable)@class).Dispose();
			}
		}
	}

	internal void method_48()
	{
		Class6 @class = Delegate61.smethod_0(Delegate328.smethod_0(this));
		try
		{
			if (int_1 <= 0)
			{
				throw new InvalidOperationException("Progress handling not enabled");
			}
			Delegate472.smethod_0(this, 0);
			int_1--;
		}
		finally
		{
			if (@class != null || 1 == 0)
			{
				((IDisposable)@class).Dispose();
			}
		}
	}

	internal void method_49(GEventArgs1 geventArgs1_0)
	{
		Class34 CS_0024_003C_003E8__locals0 = Delegate473.smethod_0();
		while (true)
		{
			int num = Class8.smethod_0(47);
			int num2 = 11;
			while (true)
			{
				num2 ^= 0x62;
				while (true)
				{
					int num3 = GEventArgs2.smethod_0(40);
					int num4 = 6;
					while (true)
					{
						num4 ^= 0x69;
						while (true)
						{
							int num5 = GEventArgs2.smethod_0(43);
							int num6 = -16;
							while (true)
							{
								num6 ^= 0x66;
								while (true)
								{
									int num7 = Class55.smethod_1(71);
									int num8 = 11;
									while (true)
									{
										num8 ^= 0x64;
										int num9 = Class9.smethod_0(89);
										while (true)
										{
											switch (num9 ^ 0x62)
											{
											case -96:
												break;
											default:
												num9 = Class9.smethod_0(89);
												continue;
											case -97:
												num8 = 8;
												num9 = -61;
												num9 = -95;
												goto end_IL_0039;
											case -95:
												goto end_IL_0039;
											case -98:
												while (true)
												{
													num9 = -4;
													num9 = -98;
												}
											}
											switch (num8)
											{
											case 108:
												goto IL_006c;
											case 109:
												goto IL_01bb;
											case 111:
												goto IL_01c1;
											case 110:
												goto end_IL_01d3;
											}
											num9 = Class8.smethod_0(41);
											continue;
											IL_01bb:
											num8 = 9;
											break;
											continue;
											end_IL_0039:
											break;
										}
										continue;
										IL_01a5:
										num5 ^= 0x67;
										goto IL_01ac;
										IL_006c:
										switch (num7)
										{
										case -108:
											goto IL_008f;
										case -106:
											goto IL_0098;
										case -107:
											goto IL_01ac;
										case -105:
											goto end_IL_01e8;
										}
										num8 = 10;
										continue;
										IL_0098:
										switch (num6)
										{
										case -107:
											goto IL_00bb;
										case -106:
											goto IL_01a5;
										case -109:
											goto IL_01f7;
										case -108:
											goto end_IL_0206;
										}
										num7 = -9;
										goto IL_01c1;
										IL_01f7:
										num6 = -11;
										goto end_IL_01e8;
										IL_00bb:
										switch (num5)
										{
										case -99:
											break;
										case -97:
											goto IL_00e8;
										case -98:
											goto IL_019e;
										default:
											goto IL_01fd;
										case -96:
											goto end_IL_020f;
										}
										num5 = Class8.smethod_0(48);
										goto IL_01a5;
										IL_01fd:
										num6 = GEventArgs2.smethod_0(44);
										goto end_IL_01e8;
										IL_00e8:
										switch (num4)
										{
										case 109:
											goto IL_010b;
										case 111:
											goto IL_0199;
										case 110:
											goto IL_0223;
										case 108:
											goto end_IL_0226;
										}
										num5 = -7;
										goto IL_01a5;
										IL_0223:
										num4 = 7;
										goto end_IL_020f;
										IL_010b:
										switch (num3)
										{
										case -105:
											break;
										case -104:
											goto IL_012e;
										case -106:
											goto IL_018f;
										default:
											goto IL_021e;
										case -103:
											goto end_IL_022f;
										}
										num3 = -6;
										goto IL_0199;
										IL_021e:
										num4 = 5;
										goto end_IL_020f;
										IL_012e:
										switch (num2)
										{
										case 102:
											goto IL_014c;
										case 105:
											goto IL_018a;
										case 104:
											goto IL_0240;
										case 103:
											goto end_IL_0243;
										}
										num3 = -5;
										goto IL_0199;
										IL_0240:
										num2 = 10;
										goto end_IL_022f;
										IL_014c:
										switch (num)
										{
										case -99:
											break;
										case -98:
											goto IL_016f;
										case -97:
											goto IL_0180;
										default:
											goto IL_023c;
										case -96:
											Delegate462.smethod_0(this, delegate
											{
												Delegate490.smethod_0(CS_0024_003C_003E8__locals0.gclass16_0, CS_0024_003C_003E8__locals0.geventArgs1_0);
											});
											return;
										}
										num = -7;
										goto IL_018a;
										IL_023c:
										num2 = 5;
										goto end_IL_022f;
										IL_0180:
										CS_0024_003C_003E8__locals0.gclass16_0 = this;
										num = -6;
										goto IL_018a;
										IL_016f:
										CS_0024_003C_003E8__locals0.geventArgs1_0 = geventArgs1_0;
										num = Class9.smethod_0(108);
										goto IL_018a;
										IL_01ac:
										num6 = Class8.smethod_0(58);
										num7 = -11;
										goto IL_01c1;
										IL_018a:
										num ^= 0x64;
										goto IL_018f;
										IL_018f:
										num2 = 4;
										num3 = Class55.smethod_1(71);
										goto IL_0199;
										IL_01c1:
										num7 ^= 0x62;
										num8 = 8;
										num9 = -61;
										num9 = -95;
										continue;
										IL_008f:
										num7 = -10;
										goto IL_01c1;
										IL_0199:
										num3 ^= 0x6D;
										goto IL_019e;
										IL_019e:
										num4 = 4;
										num5 = -57;
										goto IL_01a5;
										continue;
										end_IL_01d3:
										break;
									}
									continue;
									end_IL_01e8:
									break;
								}
								continue;
								end_IL_0206:
								break;
							}
							continue;
							end_IL_020f:
							break;
						}
						continue;
						end_IL_0226:
						break;
					}
					continue;
					end_IL_022f:
					break;
				}
				continue;
				end_IL_0243:
				break;
			}
		}
	}

	private void method_50(GEventArgs1 geventArgs1_0)
	{
		if (int_1 >= 0 && (Delegate474.smethod_0(this) || 1 == 0))
		{
			Delegate475.smethod_0(gdelegate2_0, this, geventArgs1_0);
		}
	}

	private void method_51()
	{
		Class6 @class = Delegate61.smethod_0(Delegate328.smethod_0(this));
		try
		{
			if (!string.IsNullOrEmpty(string_5) || 1 == 0)
			{
				bool flag = File.Exists(string_5);
				Delegate45.smethod_0(Delegate328.smethod_0(this), "Configured temporary file: {0} - Exists [{1}]", new object[2] { string_5, flag });
				if (flag || 1 == 0)
				{
					throw Delegate57.smethod_0(this, string.Format(CultureInfo.CurrentCulture, "Configured temporary file {0} already exists", new object[1] { string_5 }));
				}
				return;
			}
			string tempPath = Path.GetTempPath();
			int num6 = default(int);
			string text3 = default(string);
			while (true)
			{
				int num = GEventArgs2.smethod_0(40);
				int num2 = 11;
				while (true)
				{
					num2 ^= 0x66;
					while (true)
					{
						int num3 = Class8.smethod_0(41);
						int num4 = -14;
						while (true)
						{
							IL_0209:
							num4 ^= 0x69;
							int num5 = Class10.smethod_0(90);
							while (true)
							{
								switch (num5 ^ 0x69)
								{
								case -95:
									num5 = Class9.smethod_0(93);
									continue;
								default:
									num5 = Class10.smethod_0(90);
									continue;
								case -96:
									break;
								case -97:
									goto IL_00e8;
								case -94:
									goto IL_0209;
								}
								break;
							}
							switch (num4)
							{
							case -104:
								goto IL_00fe;
							case -102:
								goto IL_010c;
							case -101:
								goto IL_01f1;
							case -103:
								goto end_IL_0209;
							}
							num5 = -10;
							num5 = -97;
							goto IL_00e8;
							IL_012f:
							num3 = -4;
							goto IL_01f1;
							IL_01f1:
							num3 ^= 0x62;
							num4 = Class8.smethod_0(58);
							num5 = -53;
							num5 = -94;
							continue;
							IL_010c:
							switch (num3)
							{
							case -98:
								goto IL_012f;
							case -97:
								goto IL_0138;
							case -99:
								goto IL_01e9;
							case -96:
								goto end_IL_021e;
							}
							num4 = -16;
							continue;
							IL_0138:
							switch (num2)
							{
							case 106:
								goto IL_015a;
							case 109:
								goto IL_01e2;
							case 108:
								goto IL_0233;
							case 107:
								goto end_IL_0237;
							}
							num3 = -1;
							goto IL_01f1;
							IL_0233:
							num2 = 10;
							goto end_IL_021e;
							IL_015a:
							switch (num)
							{
							case -101:
								break;
							case -100:
								goto IL_018f;
							case -99:
								goto IL_01a7;
							case -98:
								goto IL_01c7;
							case -97:
								goto IL_01cd;
							default:
								goto IL_022d;
							case -96:
							{
								string text = num6.ToString("X8", CultureInfo.InvariantCulture);
								string text4;
								bool flag2;
								do
								{
									string text2 = ((int_0 <= 0) ? string.Empty : ("." + int_0.ToString(CultureInfo.InvariantCulture)));
									int_0++;
									text4 = Path.Combine(tempPath, "wscp" + text3 + "." + text + text2 + ".tmp");
									flag2 = File.Exists(text4);
									Delegate45.smethod_0(Delegate328.smethod_0(this), "Temporary file [{0}] - Exists [{1}]", new object[2] { text4, flag2 });
								}
								while (flag2 ? true : false);
								string_5 = text4;
								return;
							}
							}
							num6 = GetHashCode();
							num = -56;
							goto IL_01e2;
							IL_022d:
							num2 = 13;
							goto end_IL_021e;
							IL_01cd:
							num6 = Process.GetCurrentProcess().Id;
							num = Class55.smethod_1(71);
							goto IL_01e2;
							IL_01c7:
							num = -10;
							goto IL_01e2;
							IL_01a7:
							Delegate45.smethod_0(Delegate328.smethod_0(this), "Temporary folder: {0}", new object[1] { tempPath });
							num = -9;
							goto IL_01e2;
							IL_018f:
							text3 = num6.ToString("X4", CultureInfo.InvariantCulture);
							num = -13;
							goto IL_01e2;
							IL_00e8:
							num4 = Class8.smethod_0(58);
							num5 = -53;
							num5 = -94;
							continue;
							IL_01e2:
							num ^= 0x68;
							goto IL_01e9;
							IL_01e9:
							num2 = 12;
							num3 = -62;
							goto IL_01f1;
							IL_00fe:
							num4 = Class55.smethod_1(72);
							continue;
							end_IL_0209:
							break;
						}
						continue;
						end_IL_021e:
						break;
					}
					continue;
					end_IL_0237:
					break;
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

	private bool method_52()
	{
		return bool_3;
	}

	private static string smethod_14(Type type_0)
	{
		return "CLSID\\{" + type_0.GUID.ToString().ToUpperInvariant() + "}\\TypeLib";
	}

	FieldInfo IReflect.GetField(string name, BindingFlags bindingAttr)
	{
		Class6 @class = Delegate61.smethod_0(Delegate328.smethod_0(this));
		try
		{
			Delegate45.smethod_0(Delegate328.smethod_0(this), "Name [{0}]", new object[1] { name });
			FieldInfo field = GetType().GetField(name, bindingAttr);
			Delegate45.smethod_0(Delegate328.smethod_0(this), "Result [{0}]", new object[1] { ((object)field != null) ? field.Name : "null" });
			return field;
		}
		finally
		{
			if (@class != null || 1 == 0)
			{
				((IDisposable)@class).Dispose();
			}
		}
	}

	FieldInfo[] IReflect.GetFields(BindingFlags bindingAttr)
	{
		Class6 @class = Delegate61.smethod_0(Delegate328.smethod_0(this));
		try
		{
			FieldInfo[] fields = GetType().GetFields(bindingAttr);
			FieldInfo[] result = default(FieldInfo[]);
			while (true)
			{
				int num = GEventArgs2.smethod_0(49);
				int num2 = -14;
				while (true)
				{
					num2 ^= 0x6A;
					while (true)
					{
						int num3 = 8;
						int num4 = 27;
						while (true)
						{
							num4 ^= 0x6B;
							while (true)
							{
								int num5 = 0;
								int num6 = GEventArgs2.smethod_0(43);
								while (true)
								{
									num6 ^= 0x62;
									while (true)
									{
										int num7 = Class8.smethod_0(38);
										int num8 = 10;
										while (true)
										{
											num8 ^= 0x6D;
											int num9 = Class8.smethod_0(48);
											int num10 = -13;
											num10 = -101;
											while (true)
											{
												num9 ^= 0x6C;
												while (true)
												{
													num10 = Class8.smethod_0(37);
													while (true)
													{
														switch (num10 ^ 0x68)
														{
														case -104:
															break;
														default:
															goto end_IL_0041;
														case -103:
															num9 = Class8.smethod_0(48);
															num10 = -13;
															num10 = -101;
															goto end_IL_0062;
														case -101:
															goto end_IL_0062;
														case -102:
															while (true)
															{
																num10 = -14;
																num10 = -102;
															}
														}
														switch (num9)
														{
														case -106:
															goto IL_006d;
														case -107:
															goto IL_01f3;
														case -105:
															goto IL_0202;
														case -104:
															goto end_IL_0219;
														}
														num10 = Class55.smethod_1(72);
														continue;
														IL_0202:
														num9 = -5;
														goto end_IL_0062;
														continue;
														end_IL_0041:
														break;
													}
													continue;
													end_IL_0062:
													break;
												}
												continue;
												IL_01be:
												num3 ^= 0x6B;
												goto IL_01cc;
												IL_006d:
												switch (num8)
												{
												case 100:
													goto IL_0090;
												case 103:
													goto IL_01ec;
												case 101:
													goto IL_022b;
												case 102:
													goto end_IL_022e;
												}
												num9 = -7;
												continue;
												IL_022b:
												num8 = 8;
												break;
												IL_0090:
												switch (num7)
												{
												case -108:
													break;
												case -107:
													goto IL_01da;
												case -106:
													goto IL_01e8;
												default:
													goto IL_0225;
												case -105:
													goto end_IL_0248;
												}
												switch (num6)
												{
												case -105:
													goto IL_00d2;
												case -102:
													goto IL_01d3;
												case -104:
													goto IL_025d;
												case -103:
													goto end_IL_0261;
												}
												num7 = -3;
												goto IL_01ec;
												IL_0225:
												num8 = 11;
												break;
												IL_01e8:
												num7 = -2;
												goto IL_01ec;
												IL_01d3:
												num5 ^= 0x66;
												goto IL_01da;
												IL_025d:
												num6 = -6;
												goto end_IL_0248;
												IL_00d2:
												switch (num5)
												{
												case 102:
													break;
												case 103:
													goto IL_01c7;
												case 104:
													goto IL_01cc;
												default:
													goto IL_0257;
												case 105:
													goto end_IL_026a;
												}
												switch (num4)
												{
												case 109:
													goto IL_0114;
												case 112:
													goto IL_01be;
												case 110:
													goto IL_027d;
												case 111:
													goto end_IL_0280;
												}
												num5 = 14;
												goto IL_01d3;
												IL_0257:
												num6 = -5;
												goto end_IL_0248;
												IL_01c7:
												num5 = 1;
												goto IL_01d3;
												IL_01da:
												num6 = GEventArgs2.smethod_0(40);
												num7 = -1;
												goto IL_01ec;
												IL_027d:
												num4 = 5;
												goto end_IL_026a;
												IL_0114:
												switch (num3)
												{
												case 99:
													break;
												case 98:
													goto IL_01ab;
												case 100:
													goto IL_01ba;
												default:
													goto IL_0278;
												case 101:
													goto end_IL_0289;
												}
												switch (num2)
												{
												case -106:
													goto IL_0153;
												case -104:
													goto IL_01a6;
												case -107:
													goto IL_0292;
												case -105:
													goto end_IL_02a0;
												}
												num3 = 9;
												goto IL_01be;
												IL_0278:
												num4 = 4;
												goto end_IL_026a;
												IL_01ba:
												num3 = 15;
												goto IL_01be;
												IL_01ec:
												num7 ^= 0x68;
												goto IL_01f3;
												IL_0292:
												num2 = -1;
												goto end_IL_0289;
												IL_0153:
												switch (num)
												{
												case -102:
													break;
												case -101:
													goto IL_017d;
												case -100:
													goto IL_01a3;
												default:
													goto IL_0297;
												case -99:
													return result;
												}
												result = fields;
												num = Class8.smethod_0(37);
												goto IL_01a6;
												IL_0297:
												num2 = Class8.smethod_0(41);
												goto end_IL_0289;
												IL_01a3:
												num = -15;
												goto IL_01a6;
												IL_017d:
												Delegate45.smethod_0(Delegate328.smethod_0(this), "Fields [{0}]", new object[1] { fields.Length });
												num = -9;
												goto IL_01a6;
												IL_01cc:
												num4 = 6;
												num5 = 15;
												goto IL_01d3;
												IL_01a6:
												num ^= 0x6D;
												goto IL_01ab;
												IL_01ab:
												num2 = Class8.smethod_0(38);
												num3 = 14;
												goto IL_01be;
												IL_01f3:
												num8 = 9;
												num9 = Class55.smethod_1(71);
												continue;
												end_IL_0219:
												break;
											}
											continue;
											end_IL_022e:
											break;
										}
										continue;
										end_IL_0248:
										break;
									}
									continue;
									end_IL_0261:
									break;
								}
								continue;
								end_IL_026a:
								break;
							}
							continue;
							end_IL_0280:
							break;
						}
						continue;
						end_IL_0289:
						break;
					}
					continue;
					end_IL_02a0:
					break;
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

	MemberInfo[] IReflect.GetMember(string name, BindingFlags bindingAttr)
	{
		Class6 @class = Delegate61.smethod_0(Delegate328.smethod_0(this));
		try
		{
			Delegate45.smethod_0(Delegate328.smethod_0(this), "Name [{0}]", new object[1] { name });
			MemberInfo[] result = default(MemberInfo[]);
			MemberInfo[] member = default(MemberInfo[]);
			while (true)
			{
				int num = Class8.smethod_0(48);
				int num2 = Class8.smethod_0(48);
				while (true)
				{
					num2 ^= 0x6D;
					while (true)
					{
						int num3 = 5;
						int num4 = -11;
						while (true)
						{
							num4 ^= 0x6D;
							while (true)
							{
								int num5 = Class8.smethod_0(47);
								int num6 = -55;
								while (true)
								{
									num6 ^= 0x6B;
									while (true)
									{
										int num7 = Class8.smethod_0(39);
										int num8 = 0;
										while (true)
										{
											num8 ^= 0x68;
											int num9 = 15;
											int num10 = -52;
											num10 = -95;
											while (true)
											{
												IL_024c:
												num9 ^= 0x67;
												while (true)
												{
													num10 = GEventArgs2.smethod_0(44);
													switch (num10 ^ 0x6D)
													{
													case -97:
														goto end_IL_002b;
													case -98:
														goto IL_0079;
													case -95:
														goto IL_024c;
													case -96:
														while (true)
														{
															num10 = -51;
															num10 = -96;
														}
													}
													continue;
													end_IL_002b:
													break;
												}
												switch (num9)
												{
												case 104:
													goto IL_008a;
												case 105:
													goto IL_023e;
												case 106:
													goto IL_0248;
												case 107:
													goto end_IL_024c;
												}
												num10 = -13;
												num10 = -98;
												goto IL_0079;
												IL_023e:
												num8 = 13;
												num9 = 12;
												continue;
												IL_0237:
												num7 ^= 0x6A;
												goto IL_023e;
												IL_0248:
												num9 = 13;
												continue;
												IL_008a:
												switch (num8)
												{
												case 101:
													goto IL_00ad;
												case 104:
													goto IL_0237;
												case 103:
													goto IL_025e;
												case 102:
													goto end_IL_0262;
												}
												num9 = 14;
												continue;
												IL_025e:
												num8 = 15;
												break;
												IL_00ad:
												switch (num7)
												{
												case -108:
													break;
												case -107:
													goto IL_00d5;
												case -109:
													goto IL_0225;
												default:
													goto IL_0258;
												case -106:
													goto end_IL_0277;
												}
												num7 = -2;
												goto IL_0237;
												IL_0258:
												num8 = 14;
												break;
												IL_00d5:
												switch (num6)
												{
												case -96:
													goto IL_00f8;
												case -94:
													goto IL_021e;
												case -95:
													goto IL_028b;
												case -97:
													goto end_IL_028f;
												}
												num7 = -7;
												goto IL_0237;
												IL_028b:
												num6 = -54;
												goto end_IL_0277;
												IL_00f8:
												switch (num5)
												{
												case -107:
													break;
												case -105:
													goto IL_0120;
												case -106:
													goto IL_0211;
												default:
													goto IL_0285;
												case -104:
													goto end_IL_0298;
												}
												num5 = -7;
												goto IL_021e;
												IL_0285:
												num6 = -12;
												goto end_IL_0277;
												IL_0120:
												switch (num4)
												{
												case -105:
													goto IL_0148;
												case -104:
													goto IL_020a;
												case -107:
													goto IL_02a7;
												case -106:
													goto end_IL_02b1;
												}
												num5 = Class8.smethod_0(48);
												goto IL_021e;
												IL_02a7:
												num4 = -8;
												goto end_IL_0298;
												IL_0148:
												switch (num3)
												{
												case 110:
													break;
												case 111:
													goto IL_016f;
												case 109:
													goto IL_01fd;
												default:
													goto IL_02ad;
												case 112:
													goto end_IL_02ba;
												}
												num3 = 4;
												goto IL_020a;
												IL_02ad:
												num4 = -5;
												goto end_IL_0298;
												IL_016f:
												switch (num2)
												{
												case -108:
													goto IL_018e;
												case -105:
													goto IL_01f8;
												case -107:
													goto IL_02c9;
												case -106:
													goto end_IL_02cd;
												}
												num3 = 7;
												goto IL_020a;
												IL_02c9:
												num2 = -8;
												goto end_IL_02ba;
												IL_018e:
												switch (num)
												{
												case -99:
													break;
												case -98:
													goto IL_01c3;
												case -97:
													goto IL_01e9;
												case -96:
													goto IL_01f0;
												default:
													goto IL_02c3;
												case -95:
													return result;
												}
												member = GetType().GetMember(name, bindingAttr);
												num = -7;
												goto IL_01f8;
												IL_02c3:
												num2 = -5;
												goto end_IL_02ba;
												IL_01f0:
												num = Class9.smethod_0(87);
												goto IL_01f8;
												IL_01e9:
												result = member;
												num = -58;
												goto IL_01f8;
												IL_01c3:
												Delegate45.smethod_0(Delegate328.smethod_0(this), "Result [{0}]", new object[1] { member.Length });
												num = -8;
												goto IL_01f8;
												IL_0079:
												num9 = 15;
												num10 = -52;
												num10 = -95;
												continue;
												IL_01f8:
												num ^= 0x67;
												goto IL_01fd;
												IL_01fd:
												num2 = Class8.smethod_0(57);
												num3 = 26;
												goto IL_020a;
												IL_021e:
												num5 ^= 0x6C;
												goto IL_0225;
												IL_0225:
												num6 = Class9.smethod_0(97);
												num7 = Class8.smethod_0(38);
												goto IL_0237;
												IL_020a:
												num3 ^= 0x6A;
												goto IL_0211;
												IL_0211:
												num4 = Class8.smethod_0(48);
												num5 = -12;
												goto IL_021e;
												continue;
												end_IL_024c:
												break;
											}
											continue;
											end_IL_0262:
											break;
										}
										continue;
										end_IL_0277:
										break;
									}
									continue;
									end_IL_028f:
									break;
								}
								continue;
								end_IL_0298:
								break;
							}
							continue;
							end_IL_02b1:
							break;
						}
						continue;
						end_IL_02ba:
						break;
					}
					continue;
					end_IL_02cd:
					break;
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

	MemberInfo[] IReflect.GetMembers(BindingFlags bindingAttr)
	{
		Class6 @class = Delegate61.smethod_0(Delegate328.smethod_0(this));
		try
		{
			MemberInfo[] members = GetType().GetMembers(bindingAttr);
			MemberInfo[] result = default(MemberInfo[]);
			while (true)
			{
				int num = Class8.smethod_0(57);
				int num2 = 13;
				while (true)
				{
					num2 ^= 0x69;
					while (true)
					{
						int num3 = 8;
						int num4 = 15;
						while (true)
						{
							num4 ^= 0x67;
							while (true)
							{
								int num5 = 3;
								int num6 = -62;
								while (true)
								{
									num6 ^= 0x62;
									while (true)
									{
										int num7 = Class8.smethod_0(47);
										int num8 = -13;
										while (true)
										{
											num8 ^= 0x64;
											while (true)
											{
												int num9 = 13;
												int num10 = Class8.smethod_0(41);
												while (true)
												{
													switch (num10 ^ 0x65)
													{
													case -104:
														break;
													default:
														goto IL_0025;
													case -106:
														goto IL_0033;
													case -105:
														goto end_IL_01ea;
													case -107:
														while (true)
														{
															num10 = -16;
															num10 = -107;
														}
													}
													goto IL_001e;
													IL_0033:
													switch (num9)
													{
													case 100:
														break;
													case 101:
														goto IL_0058;
													case 102:
														goto IL_01d8;
													default:
														goto IL_0210;
													case 103:
														goto end_IL_0218;
													}
													num9 = 12;
													goto IL_001e;
													IL_0210:
													num10 = -14;
													num10 = -105;
													break;
													IL_0058:
													switch (num8)
													{
													case -106:
														goto IL_0078;
													case -105:
														goto IL_01d1;
													case -107:
														goto IL_0227;
													case -108:
														goto end_IL_0231;
													}
													num9 = 14;
													goto IL_001e;
													IL_0227:
													num8 = -15;
													goto end_IL_0218;
													IL_0078:
													switch (num7)
													{
													case -100:
														break;
													case -98:
														goto IL_00a0;
													case -99:
														goto IL_01bf;
													default:
														goto IL_022d;
													case -97:
														goto end_IL_023a;
													}
													num7 = -7;
													goto IL_01d1;
													IL_022d:
													num8 = -16;
													goto end_IL_0218;
													IL_00a0:
													switch (num6)
													{
													case -99:
														goto IL_00c3;
													case -96:
														goto IL_01b8;
													case -98:
														goto IL_024f;
													case -97:
														goto end_IL_0258;
													}
													num7 = -8;
													goto IL_01d1;
													IL_024f:
													num6 = Class8.smethod_0(38);
													goto end_IL_023a;
													IL_00c3:
													switch (num5)
													{
													case 101:
														break;
													case 102:
														goto IL_00ea;
													case 100:
														goto IL_01b2;
													default:
														goto IL_0249;
													case 103:
														goto end_IL_0261;
													}
													num5 = 0;
													goto IL_01b8;
													IL_0249:
													num6 = -3;
													goto end_IL_023a;
													IL_00ea:
													switch (num4)
													{
													case 102:
														goto IL_010c;
													case 104:
														goto IL_01ab;
													case 101:
														goto IL_026a;
													case 103:
														goto end_IL_0272;
													}
													num5 = 1;
													goto IL_01b8;
													IL_026a:
													num4 = 2;
													goto end_IL_0261;
													IL_010c:
													switch (num3)
													{
													case 103:
														break;
													case 105:
														goto IL_0130;
													case 104:
														goto IL_01a3;
													default:
														goto IL_026f;
													case 106:
														goto end_IL_027b;
													}
													num3 = 6;
													goto IL_01ab;
													IL_026f:
													num4 = 0;
													goto end_IL_0261;
													IL_0130:
													switch (num2)
													{
													case 98:
														goto IL_0150;
													case 100:
														goto IL_019e;
													case 99:
														goto IL_0289;
													case 97:
														goto end_IL_028d;
													}
													num3 = 9;
													goto IL_01ab;
													IL_0289:
													num2 = 10;
													goto end_IL_027b;
													IL_0150:
													switch (num)
													{
													case -100:
														break;
													case -99:
														goto IL_0194;
													case -98:
														goto IL_0199;
													default:
														goto IL_0284;
													case -97:
														return result;
													}
													Delegate45.smethod_0(Delegate328.smethod_0(this), "Result [{0}]", new object[1] { members.Length });
													num = -5;
													goto IL_019e;
													IL_0284:
													num2 = 8;
													goto end_IL_027b;
													IL_0199:
													result = members;
													num = -6;
													goto IL_019e;
													IL_0194:
													num = -8;
													goto IL_019e;
													IL_0025:
													num10 = Class8.smethod_0(58);
													continue;
													IL_019e:
													num ^= 0x65;
													goto IL_01a3;
													IL_01a3:
													num2 = 11;
													num3 = 11;
													goto IL_01ab;
													IL_001e:
													num9 ^= 0x68;
													goto IL_0025;
													IL_01bf:
													num6 = Class8.smethod_0(39);
													num7 = Class8.smethod_0(48);
													goto IL_01d1;
													IL_01ab:
													num3 ^= 0x61;
													goto IL_01b2;
													IL_01b2:
													num4 = 1;
													num5 = 2;
													goto IL_01b8;
													IL_01d1:
													num7 ^= 0x65;
													goto IL_01d8;
													IL_01d8:
													num8 = GEventArgs2.smethod_0(44);
													num9 = 15;
													goto IL_001e;
													IL_01b8:
													num5 ^= 0x65;
													goto IL_01bf;
													continue;
													end_IL_01ea:
													break;
												}
												continue;
												end_IL_0218:
												break;
											}
											continue;
											end_IL_0231:
											break;
										}
										continue;
										end_IL_023a:
										break;
									}
									continue;
									end_IL_0258:
									break;
								}
								continue;
								end_IL_0261:
								break;
							}
							continue;
							end_IL_0272:
							break;
						}
						continue;
						end_IL_027b:
						break;
					}
					continue;
					end_IL_028d:
					break;
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

	MethodInfo IReflect.GetMethod(string name, BindingFlags bindingAttr)
	{
		Class6 @class = Delegate61.smethod_0(Delegate328.smethod_0(this));
		try
		{
			Delegate45.smethod_0(Delegate328.smethod_0(this), "Name [{0}]", new object[1] { name });
			MethodInfo method = GetType().GetMethod(name, bindingAttr);
			Delegate45.smethod_0(Delegate328.smethod_0(this), "Result [{0}]", new object[1] { ((object)method != null) ? method.Name : "null" });
			return method;
		}
		finally
		{
			if (@class != null || 1 == 0)
			{
				((IDisposable)@class).Dispose();
			}
		}
	}

	MethodInfo IReflect.GetMethod(string name, BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers)
	{
		Class6 @class = Delegate61.smethod_0(Delegate328.smethod_0(this));
		try
		{
			Delegate45.smethod_0(Delegate328.smethod_0(this), "Name [{0}]", new object[1] { name });
			MethodInfo method = GetType().GetMethod(name, bindingAttr, binder, types, modifiers);
			Delegate45.smethod_0(Delegate328.smethod_0(this), "Result [{0}]", new object[1] { ((object)method != null) ? method.Name : "null" });
			return method;
		}
		finally
		{
			if (@class != null || 1 == 0)
			{
				((IDisposable)@class).Dispose();
			}
		}
	}

	MethodInfo[] IReflect.GetMethods(BindingFlags bindingAttr)
	{
		Class6 @class = Delegate61.smethod_0(Delegate328.smethod_0(this));
		try
		{
			MethodInfo[] methods = GetType().GetMethods(bindingAttr);
			MethodInfo[] result = default(MethodInfo[]);
			while (true)
			{
				int num = Class55.smethod_1(72);
				int num2 = -7;
				while (true)
				{
					num2 ^= 0x62;
					while (true)
					{
						int num3 = 7;
						int num4 = 6;
						while (true)
						{
							num4 ^= 0x6A;
							while (true)
							{
								int num5 = 11;
								int num6 = 25;
								while (true)
								{
									num6 ^= 0x69;
									while (true)
									{
										int num7 = 1;
										int num8 = Class8.smethod_0(38);
										while (true)
										{
											num8 ^= 0x66;
											int num9 = Class8.smethod_0(38);
											while (true)
											{
												switch (num9 ^ 0x68)
												{
												case -108:
													break;
												default:
													num9 = Class8.smethod_0(38);
													continue;
												case -106:
													num8 = Class8.smethod_0(42);
													num9 = -1;
													num9 = -105;
													goto end_IL_004c;
												case -105:
													goto end_IL_004c;
												case -107:
													while (true)
													{
														num9 = -3;
														num9 = -107;
													}
												}
												switch (num8)
												{
												case -104:
													goto IL_006f;
												case -103:
													goto IL_01cb;
												case -102:
													goto IL_01d0;
												case -105:
													goto end_IL_01f9;
												}
												num9 = Class8.smethod_0(42);
												continue;
												IL_01cb:
												num8 = -1;
												break;
												continue;
												end_IL_004c:
												break;
											}
											continue;
											IL_01b0:
											num4 = 3;
											num5 = 12;
											goto IL_01b7;
											IL_006f:
											switch (num7)
											{
											case 98:
												goto IL_0092;
											case 97:
												goto IL_01be;
											case 99:
												goto IL_01c6;
											case 100:
												goto end_IL_020e;
											}
											num8 = -15;
											continue;
											IL_01c6:
											num7 = 0;
											goto IL_01d0;
											IL_0092:
											switch (num6)
											{
											case 109:
												goto IL_00b4;
											case 112:
												goto IL_01b7;
											case 111:
												goto IL_0221;
											case 110:
												goto end_IL_0224;
											}
											num7 = 2;
											goto IL_01d0;
											IL_0221:
											num6 = 6;
											goto end_IL_020e;
											IL_00b4:
											switch (num5)
											{
											case 97:
												break;
											case 99:
												goto IL_00dc;
											case 98:
												goto IL_01b0;
											default:
												goto IL_021c;
											case 100:
												goto end_IL_022d;
											}
											num5 = 9;
											goto IL_01b7;
											IL_021c:
											num6 = 7;
											goto end_IL_020e;
											IL_00dc:
											switch (num4)
											{
											case 105:
												goto IL_00ff;
											case 108:
												goto IL_01a9;
											case 107:
												goto IL_023c;
											case 106:
												goto end_IL_023f;
											}
											num5 = 10;
											goto IL_01b7;
											IL_023c:
											num4 = 1;
											goto end_IL_022d;
											IL_00ff:
											switch (num3)
											{
											case 98:
												break;
											case 100:
												goto IL_0126;
											case 99:
												goto IL_019d;
											default:
												goto IL_0237;
											case 101:
												goto end_IL_0248;
											}
											num3 = 1;
											goto IL_01a9;
											IL_0237:
											num4 = 0;
											goto end_IL_022d;
											IL_0126:
											switch (num2)
											{
											case -102:
												goto IL_0145;
											case -101:
												goto IL_0198;
											case -104:
												goto IL_0250;
											case -103:
												goto end_IL_025f;
											}
											num3 = 0;
											goto IL_01a9;
											IL_0250:
											num2 = Class8.smethod_0(48);
											goto end_IL_0248;
											IL_0145:
											switch (num)
											{
											case -103:
												break;
											case -102:
												goto IL_0168;
											case -101:
												goto IL_018e;
											default:
												goto IL_025b;
											case -100:
												return result;
											}
											num = -14;
											goto IL_0198;
											IL_025b:
											num2 = -5;
											goto end_IL_0248;
											IL_018e:
											result = methods;
											num = GEventArgs2.smethod_0(46);
											goto IL_0198;
											IL_0168:
											Delegate45.smethod_0(Delegate328.smethod_0(this), "Result [{0}]", new object[1] { methods.Length });
											num = -16;
											goto IL_0198;
											IL_01be:
											num6 = 4;
											num7 = 7;
											goto IL_01d0;
											IL_0198:
											num ^= 0x6B;
											goto IL_019d;
											IL_019d:
											num2 = GEventArgs2.smethod_0(43);
											num3 = 6;
											goto IL_01a9;
											IL_01d0:
											num7 ^= 0x63;
											num8 = Class8.smethod_0(42);
											num9 = -1;
											num9 = -105;
											continue;
											IL_01b7:
											num5 ^= 0x68;
											goto IL_01be;
											IL_01a9:
											num3 ^= 0x63;
											goto IL_01b0;
											continue;
											end_IL_01f9:
											break;
										}
										continue;
										end_IL_020e:
										break;
									}
									continue;
									end_IL_0224:
									break;
								}
								continue;
								end_IL_022d:
								break;
							}
							continue;
							end_IL_023f:
							break;
						}
						continue;
						end_IL_0248:
						break;
					}
					continue;
					end_IL_025f:
					break;
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

	PropertyInfo[] IReflect.GetProperties(BindingFlags bindingAttr)
	{
		Class6 @class = Delegate61.smethod_0(Delegate328.smethod_0(this));
		try
		{
			PropertyInfo[] properties = GetType().GetProperties(bindingAttr);
			PropertyInfo[] result = default(PropertyInfo[]);
			while (true)
			{
				int num = Class8.smethod_0(41);
				int num2 = 11;
				while (true)
				{
					num2 ^= 0x67;
					while (true)
					{
						int num3 = Class8.smethod_0(57);
						int num4 = 13;
						while (true)
						{
							num4 ^= 0x69;
							while (true)
							{
								int num5 = 2;
								int num6 = 15;
								while (true)
								{
									num6 ^= 0x65;
									while (true)
									{
										int num7 = 5;
										int num8 = 12;
										while (true)
										{
											num8 ^= 0x66;
											while (true)
											{
												int num9 = Class8.smethod_0(57);
												int num10 = GEventArgs2.smethod_0(49);
												while (true)
												{
													switch (num10 ^ 0x6C)
													{
													case -102:
														break;
													default:
														goto IL_0025;
													case -104:
														goto IL_0033;
													case -105:
														goto end_IL_01e2;
													case -103:
														while (true)
														{
															num10 = -11;
															num10 = -103;
														}
													}
													goto IL_001e;
													IL_0033:
													switch (num9)
													{
													case -102:
														break;
													case -101:
														goto IL_0058;
													case -103:
														goto IL_01d6;
													default:
														goto IL_0208;
													case -100:
														goto end_IL_0210;
													}
													num9 = -8;
													goto IL_001e;
													IL_0208:
													num10 = -5;
													num10 = -105;
													break;
													IL_0058:
													switch (num8)
													{
													case 103:
														goto IL_007d;
													case 106:
														goto IL_01cf;
													case 104:
														goto IL_022a;
													case 105:
														goto end_IL_022e;
													}
													num9 = Class8.smethod_0(47);
													goto IL_001e;
													IL_022a:
													num8 = 14;
													goto end_IL_0210;
													IL_007d:
													switch (num7)
													{
													case 110:
														break;
													case 111:
														goto IL_00a4;
													case 109:
														goto IL_01c7;
													default:
														goto IL_0224;
													case 112:
														goto end_IL_0237;
													}
													num7 = 4;
													goto IL_01cf;
													IL_0224:
													num8 = 15;
													goto end_IL_0210;
													IL_00a4:
													switch (num6)
													{
													case 104:
														goto IL_00c6;
													case 106:
														goto IL_01c0;
													case 105:
														goto IL_0245;
													case 103:
														goto end_IL_0249;
													}
													num7 = 7;
													goto IL_01cf;
													IL_0245:
													num6 = 12;
													goto end_IL_0237;
													IL_00c6:
													switch (num5)
													{
													case 100:
														break;
													case 101:
														goto IL_00ed;
													case 102:
														goto IL_01ba;
													default:
														goto IL_0240;
													case 103:
														goto end_IL_0252;
													}
													num5 = 3;
													goto IL_01c0;
													IL_0240:
													num6 = 2;
													goto end_IL_0237;
													IL_00ed:
													switch (num4)
													{
													case 97:
														goto IL_010f;
													case 100:
														goto IL_01b3;
													case 99:
														goto IL_0261;
													case 98:
														goto end_IL_0265;
													}
													num5 = 1;
													goto IL_01c0;
													IL_0261:
													num4 = 10;
													goto end_IL_0252;
													IL_010f:
													switch (num3)
													{
													case -101:
														break;
													case -100:
														goto IL_0139;
													case -102:
														goto IL_01ab;
													default:
														goto IL_025b;
													case -99:
														goto end_IL_026e;
													}
													num3 = Class8.smethod_0(42);
													goto IL_01b3;
													IL_025b:
													num4 = 11;
													goto end_IL_0252;
													IL_0139:
													switch (num2)
													{
													case 105:
														goto IL_0158;
													case 108:
														goto IL_01a6;
													case 107:
														goto IL_0283;
													case 106:
														goto end_IL_0287;
													}
													num3 = -1;
													goto IL_01b3;
													IL_0283:
													num2 = 12;
													goto end_IL_026e;
													IL_0158:
													switch (num)
													{
													case -109:
														break;
													case -108:
														goto IL_017d;
													case -107:
														goto IL_0182;
													default:
														goto IL_027d;
													case -106:
														return result;
													}
													result = properties;
													num = -2;
													goto IL_01a6;
													IL_027d:
													num2 = 13;
													goto end_IL_026e;
													IL_0182:
													Delegate45.smethod_0(Delegate328.smethod_0(this), "Result [{0}]", new object[1] { properties.Length });
													num = -5;
													goto IL_01a6;
													IL_017d:
													num = -4;
													goto IL_01a6;
													IL_0025:
													num10 = Class55.smethod_1(71);
													continue;
													IL_01a6:
													num ^= 0x68;
													goto IL_01ab;
													IL_01ab:
													num2 = 14;
													num3 = -8;
													goto IL_01b3;
													IL_001e:
													num9 ^= 0x62;
													goto IL_0025;
													IL_01c7:
													num6 = 13;
													num7 = 26;
													goto IL_01cf;
													IL_01b3:
													num3 ^= 0x65;
													goto IL_01ba;
													IL_01ba:
													num4 = 8;
													num5 = 0;
													goto IL_01c0;
													IL_01cf:
													num7 ^= 0x6A;
													goto IL_01d6;
													IL_01d6:
													num8 = 1;
													num9 = -2;
													goto IL_001e;
													IL_01c0:
													num5 ^= 0x67;
													goto IL_01c7;
													continue;
													end_IL_01e2:
													break;
												}
												continue;
												end_IL_0210:
												break;
											}
											continue;
											end_IL_022e:
											break;
										}
										continue;
										end_IL_0237:
										break;
									}
									continue;
									end_IL_0249:
									break;
								}
								continue;
								end_IL_0252:
								break;
							}
							continue;
							end_IL_0265:
							break;
						}
						continue;
						end_IL_026e:
						break;
					}
					continue;
					end_IL_0287:
					break;
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

	PropertyInfo IReflect.GetProperty(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
	{
		Class6 @class = Delegate61.smethod_0(Delegate328.smethod_0(this));
		try
		{
			Delegate45.smethod_0(Delegate328.smethod_0(this), "Name [{0}]", new object[1] { name });
			PropertyInfo property = GetType().GetProperty(name, bindingAttr, binder, returnType, types, modifiers);
			Delegate45.smethod_0(Delegate328.smethod_0(this), "Result [{0}]", new object[1] { ((object)property != null) ? property.Name : "null" });
			return property;
		}
		finally
		{
			if (@class != null || 1 == 0)
			{
				((IDisposable)@class).Dispose();
			}
		}
	}

	PropertyInfo IReflect.GetProperty(string name, BindingFlags bindingAttr)
	{
		Class6 @class = Delegate61.smethod_0(Delegate328.smethod_0(this));
		try
		{
			Delegate45.smethod_0(Delegate328.smethod_0(this), "Name [{0}]", new object[1] { name });
			PropertyInfo property = GetType().GetProperty(name, bindingAttr);
			Delegate45.smethod_0(Delegate328.smethod_0(this), "Result [{0}]", new object[1] { ((object)property != null) ? property.Name : "null" });
			return property;
		}
		finally
		{
			if (@class != null || 1 == 0)
			{
				((IDisposable)@class).Dispose();
			}
		}
	}

	object IReflect.InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters)
	{
		Class6 @class = Delegate61.smethod_0(Delegate328.smethod_0(this));
		try
		{
			object obj;
			try
			{
				if (Delegate44.smethod_0(Delegate328.smethod_0(this)) || 1 == 0)
				{
					Delegate45.smethod_0(Delegate328.smethod_0(this), "Name [{0}]", new object[1] { name });
					while (true)
					{
						int num = 7;
						int num2 = -6;
						while (true)
						{
							num2 ^= 0x6C;
							while (true)
							{
								int num3 = 4;
								int num4 = 2;
								while (true)
								{
									num4 ^= 0x68;
									while (true)
									{
										int num5 = 4;
										int num6 = Class8.smethod_0(37);
										while (true)
										{
											switch (num6 ^ 0x6D)
											{
											case -99:
												break;
											default:
												goto IL_0048;
											case -102:
												goto IL_0056;
											case -101:
												goto end_IL_01a3;
											case -100:
												while (true)
												{
													num6 = -15;
													num6 = -100;
												}
											}
											goto IL_0041;
											IL_0056:
											switch (num5)
											{
											case 99:
												break;
											case 100:
												goto IL_0190;
											case 101:
												goto IL_019b;
											default:
												goto IL_01c9;
											case 102:
												goto end_IL_01d1;
											}
											switch (num4)
											{
											case 104:
												goto IL_0094;
											case 106:
												goto IL_0189;
											case 103:
												goto IL_01df;
											case 105:
												goto end_IL_01e8;
											}
											num5 = 3;
											goto IL_0041;
											IL_01c9:
											num6 = -10;
											num6 = -101;
											break;
											IL_019b:
											num5 = 2;
											goto IL_0041;
											IL_0190:
											num4 = 0;
											num5 = 1;
											goto IL_0041;
											IL_01df:
											num4 = 15;
											goto end_IL_01d1;
											IL_0094:
											switch (num3)
											{
											case 97:
												break;
											case 98:
												goto IL_0178;
											case 99:
												goto IL_017d;
											default:
												goto IL_01e5;
											case 100:
												goto end_IL_01f1;
											}
											switch (num2)
											{
											case -108:
												goto IL_00d5;
											case -106:
												goto IL_016f;
											case -107:
												goto IL_0204;
											case -109:
												goto end_IL_0208;
											}
											num3 = 6;
											goto IL_0189;
											IL_01e5:
											num4 = 1;
											goto end_IL_01d1;
											IL_0178:
											num3 = 7;
											goto IL_0189;
											IL_0041:
											num5 ^= 0x67;
											goto IL_0048;
											IL_0204:
											num2 = -7;
											goto end_IL_01f1;
											IL_00d5:
											switch (num)
											{
											case 103:
												break;
											case 104:
												goto IL_0102;
											case 105:
												goto IL_0121;
											case 106:
												goto IL_012d;
											case 107:
												goto IL_0151;
											default:
												goto IL_01f9;
											case 108:
												goto IL_0223;
											}
											num = 10;
											goto IL_016f;
											IL_01f9:
											num2 = Class8.smethod_0(39);
											goto end_IL_01f1;
											IL_0151:
											Delegate45.smethod_0(Delegate328.smethod_0(this), "Target [{0}]", new object[1] { target });
											num = 4;
											goto IL_016f;
											IL_012d:
											Delegate45.smethod_0(Delegate328.smethod_0(this), "BindingFlags [{0}]", new object[1] { invokeAttr });
											num = 5;
											goto IL_016f;
											IL_0121:
											if (args != null)
											{
												num = 1;
												goto IL_016f;
											}
											if (1 == 0)
											{
												goto IL_0223;
											}
											goto IL_02f7;
											IL_0102:
											Delegate45.smethod_0(Delegate328.smethod_0(this), "Binder [{0}]", new object[1] { binder });
											num = 6;
											goto IL_016f;
											IL_0048:
											num6 = GEventArgs2.smethod_0(46);
											continue;
											IL_0223:
											Delegate45.smethod_0(Delegate328.smethod_0(this), "Args [{0}] [{1}]", new object[2]
											{
												args.Length,
												(modifiers != null) ? modifiers.Length.ToString(CultureInfo.InvariantCulture) : "null"
											});
											for (int i = 0; i < args.Length; i++)
											{
												Delegate45.smethod_0(Delegate328.smethod_0(this), "Arg [{0}] [{1}] [{1}] [{2}]", new object[4]
												{
													i,
													args[i],
													(args[i] != null) ? args[i].GetType().ToString() : "null",
													(modifiers != null) ? modifiers[i].ToString() : "null"
												});
											}
											goto IL_02f7;
											IL_02f7:
											Delegate45.smethod_0(Delegate328.smethod_0(this), "Culture [{0}]", new object[1] { culture });
											if (namedParameters != null || 1 == 0)
											{
												foreach (string text in namedParameters)
												{
													Delegate45.smethod_0(Delegate328.smethod_0(this), "NamedParameter [{0}]", new object[1] { text });
												}
											}
											goto end_IL_0211;
											IL_0189:
											num3 ^= 0x65;
											goto IL_0190;
											IL_017d:
											num2 = GEventArgs2.smethod_0(43);
											num3 = 1;
											goto IL_0189;
											IL_016f:
											num ^= 0x6D;
											goto IL_017d;
											continue;
											end_IL_01a3:
											break;
										}
										continue;
										end_IL_01d1:
										break;
									}
									continue;
									end_IL_01e8:
									break;
								}
								continue;
								end_IL_01f1:
								break;
							}
							continue;
							end_IL_0208:
							break;
						}
						continue;
						end_IL_0211:
						break;
					}
				}
				if (target == null && 0 == 0)
				{
					throw new ArgumentNullException("target");
				}
				Type type = target.GetType();
				MethodInfo methodInfo = null;
				PropertyInfo propertyInfo = null;
				if (namedParameters == null && 0 == 0)
				{
					try
					{
						BindingFlags bindingAttr = invokeAttr | BindingFlags.Instance | BindingFlags.Public;
						methodInfo = type.GetMethod(name, bindingAttr);
						if (args == null && 0 == 0)
						{
							throw new ArgumentNullException("args");
						}
						if ((object)methodInfo != null || 1 == 0)
						{
							ParameterInfo[] parameters = methodInfo.GetParameters();
							while (true)
							{
								int num7 = Class8.smethod_0(58);
								switch (num7 ^ 0x68)
								{
								default:
									continue;
								case -102:
									while (true)
									{
										num7 = -14;
										num7 = -102;
									}
								case -101:
									if (args.Length < parameters.Length)
									{
										num7 = -12;
										num7 = -100;
										goto case -100;
									}
									goto end_IL_03cb;
								case -100:
									Delegate45.smethod_0(Delegate328.smethod_0(this), "Provided less parameters [{0}] than defined [{1}]", new object[2] { args.Length, parameters.Length });
									num7 = -11;
									num7 = -99;
									break;
								case -99:
									break;
								}
								object[] array = new object[parameters.Length];
								for (int k = 0; k < parameters.Length; k++)
								{
									if (k < args.Length)
									{
										array[k] = args[k];
										continue;
									}
									if (parameters[k].IsOptional ? true : false)
									{
										Delegate45.smethod_0(Delegate328.smethod_0(this), "Adding default value [{0}] for optional parameter [{1}]", new object[2]
										{
											parameters[k].DefaultValue,
											k
										});
										array[k] = parameters[k].DefaultValue;
										continue;
									}
									Delegate45.smethod_0(Delegate328.smethod_0(this), "Parameter [{0}] of [{1}] is not optional", new object[2] { k, methodInfo });
									array = null;
									break;
								}
								if (array != null || 1 == 0)
								{
									args = array;
								}
								break;
								continue;
								end_IL_03cb:
								break;
							}
						}
						else if (args.Length == 1)
						{
							propertyInfo = type.GetProperty(name, bindingAttr);
						}
					}
					catch (AmbiguousMatchException ex)
					{
						Delegate45.smethod_0(Delegate328.smethod_0(this), "Unexpected ambiguous match [{0}]", new object[1] { ex.Message });
					}
				}
				if ((object)methodInfo != null || 1 == 0)
				{
					Delegate45.smethod_0(Delegate328.smethod_0(this), "Invoking unambiguous method [{0}]", new object[1] { methodInfo });
					obj = methodInfo.Invoke(target, invokeAttr, binder, args, culture);
				}
				else if ((object)propertyInfo != null || 1 == 0)
				{
					Delegate45.smethod_0(Delegate328.smethod_0(this), "Setting unambiguous property [{0}]", new object[1] { propertyInfo });
					propertyInfo.SetValue(target, args[0], invokeAttr, binder, null, culture);
					obj = null;
				}
				else
				{
					Delegate45.smethod_0(Delegate328.smethod_0(this), "Invoking ambiguous/non-existing method 2 [{0}]", new object[1] { name });
					obj = type.InvokeMember(name, invokeAttr, binder, target, args, modifiers, culture, namedParameters);
				}
				Delegate45.smethod_0(Delegate328.smethod_0(this), "Result [{0}] [{1}]", new object[2]
				{
					obj,
					(obj != null) ? obj.GetType().ToString() : "null"
				});
			}
			catch (Exception ex2)
			{
				Delegate45.smethod_0(Delegate328.smethod_0(this), "Error [{0}]", new object[1] { ex2 });
				throw;
			}
			return obj;
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
