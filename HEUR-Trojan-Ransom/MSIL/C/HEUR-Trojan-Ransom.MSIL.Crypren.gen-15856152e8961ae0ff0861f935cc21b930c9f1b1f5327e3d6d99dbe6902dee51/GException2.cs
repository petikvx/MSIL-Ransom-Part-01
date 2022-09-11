using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Xml;

[ComVisible(true)]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[Guid("0E8BBC73-AF4D-4E7E-995C-EB89D0BFDE9A")]
public sealed class GException2 : GException0
{
	internal GException2(GClass16 gclass16_1, string string_0)
		: base(gclass16_1, string_0)
	{
	}

	internal static bool smethod_0(Class27 class27_0)
	{
		return Delegate393.smethod_0(class27_0, "result");
	}

	internal static GException2 smethod_1(Class27 class27_0)
	{
		GException2 result = null;
		if (Delegate528.smethod_0(class27_0, "success") == "false" || 1 == 0)
		{
			result = Delegate529.smethod_0(class27_0);
		}
		return result;
	}

	internal static GException2 smethod_2(Class27 class27_0)
	{
		return Delegate529.smethod_0(class27_0);
	}

	private static GException2 smethod_3(Class27 class27_0)
	{
		Class28 @class = Delegate35.smethod_0(class27_0);
		try
		{
			string text = null;
			bool flag = default(bool);
			List<string> list = default(List<string>);
			while (true)
			{
				int num = 8;
				int num2 = 11;
				while (true)
				{
					num2 ^= 0x6C;
					while (true)
					{
						int num3 = GEventArgs2.smethod_0(43);
						int num4 = -14;
						while (true)
						{
							num4 ^= 0x69;
							while (true)
							{
								int num5 = 14;
								int num6 = 3;
								while (true)
								{
									IL_0220:
									num6 ^= 0x69;
									int num7 = Class8.smethod_0(48);
									while (true)
									{
										switch (num7 ^ 0x63)
										{
										case -101:
											num7 = GEventArgs2.smethod_0(43);
											continue;
										default:
											num7 = Class8.smethod_0(48);
											continue;
										case -103:
											break;
										case -102:
											goto IL_0216;
										case -100:
											goto IL_0220;
										}
										break;
									}
									switch (num6)
									{
									case 104:
										goto IL_006c;
									case 105:
										goto IL_0074;
									case 106:
										goto IL_0203;
									case 103:
										goto end_IL_0220;
									}
									num7 = -7;
									num7 = -102;
									goto IL_0216;
									IL_01e7:
									num3 ^= 0x67;
									goto IL_01f6;
									IL_01f6:
									num4 = Class8.smethod_0(37);
									num5 = 13;
									goto IL_0203;
									IL_0074:
									switch (num5)
									{
									case 108:
										goto IL_0097;
									case 109:
										goto IL_01f0;
									case 110:
										goto IL_01f6;
									case 111:
										goto end_IL_0235;
									}
									num6 = 14;
									continue;
									IL_01f0:
									num5 = 15;
									goto IL_0203;
									IL_0097:
									switch (num4)
									{
									case -103:
										goto IL_00ba;
									case -101:
										goto IL_01e7;
									case -104:
										goto IL_023e;
									case -102:
										goto end_IL_0248;
									}
									num5 = 12;
									goto IL_0203;
									IL_023e:
									num4 = -15;
									goto end_IL_0235;
									IL_00ba:
									switch (num3)
									{
									case -99:
										break;
									case -97:
										goto IL_00e7;
									case -98:
										goto IL_01df;
									default:
										goto IL_0244;
									case -96:
										goto end_IL_0251;
									}
									num3 = Class8.smethod_0(48);
									goto IL_01e7;
									IL_0244:
									num4 = -13;
									goto end_IL_0235;
									IL_00e7:
									switch (num2)
									{
									case 101:
										goto IL_010a;
									case 103:
										goto IL_01d8;
									case 102:
										goto IL_0265;
									case 100:
										goto end_IL_0269;
									}
									num3 = -7;
									goto IL_01e7;
									IL_0265:
									num2 = 10;
									goto end_IL_0251;
									IL_010a:
									switch (num)
									{
									case 108:
										break;
									case 109:
										goto IL_0140;
									case 110:
										goto IL_0149;
									case 111:
										if (flag)
										{
											goto IL_0157;
										}
										goto IL_01a8;
									case 107:
										if (!Delegate393.smethod_0(@class, "message"))
										{
											if (true)
											{
												if ((flag || 1 == 0) && Delegate530.smethod_0(@class) == XmlNodeType.Text)
												{
													text += Delegate531.smethod_0(@class);
												}
												else if ((flag || 1 == 0) && (Delegate532.smethod_0(@class, "message") || 1 == 0))
												{
													list.Add(text);
													text = null;
													flag = false;
												}
												goto IL_01a8;
											}
											goto case 112;
										}
										goto IL_01d4;
									case 112:
										flag = true;
										text = null;
										goto IL_01a8;
									default:
										goto IL_0260;
										IL_01a8:
										if (!Delegate43.smethod_0(@class, (Enum10)0) && 0 == 0)
										{
											string string_ = string.Join(Environment.NewLine, list.ToArray());
											return Delegate373.smethod_0(Delegate301.smethod_0(@class), string_);
										}
										goto case 107;
									}
									list = new List<string>();
									num = 10;
									goto IL_01d8;
									IL_0260:
									num2 = 8;
									goto end_IL_0251;
									IL_0157:
									num = 15;
									goto IL_01d8;
									IL_01d4:
									num = 20;
									goto IL_01d8;
									IL_0149:
									flag = false;
									num = 11;
									goto IL_01d8;
									IL_0140:
									num = 9;
									goto IL_01d8;
									IL_0216:
									num6 = 0;
									num7 = -1;
									num7 = -100;
									continue;
									IL_01d8:
									num ^= 0x64;
									goto IL_01df;
									IL_01df:
									num2 = 9;
									num3 = -57;
									goto IL_01e7;
									IL_0203:
									num5 ^= 0x62;
									num6 = 0;
									num7 = -1;
									num7 = -100;
									continue;
									IL_006c:
									num6 = 1;
									continue;
									end_IL_0220:
									break;
								}
								continue;
								end_IL_0235:
								break;
							}
							continue;
							end_IL_0248:
							break;
						}
						continue;
						end_IL_0251:
						break;
					}
					continue;
					end_IL_0269:
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
}
