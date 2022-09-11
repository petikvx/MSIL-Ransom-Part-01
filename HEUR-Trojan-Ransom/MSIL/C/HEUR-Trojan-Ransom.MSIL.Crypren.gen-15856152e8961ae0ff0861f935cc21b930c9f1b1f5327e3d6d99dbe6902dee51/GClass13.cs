using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
[Guid("D0ADB4F7-47AE-43AC-AA41-9114650EA51A")]
public sealed class GClass13 : GClass10
{
	[CompilerGenerated]
	private GClass8 gclass8_0;

	[CompilerGenerated]
	private GClass8 gclass8_1;

	[CompilerGenerated]
	private GClass5 gclass5_0;

	public GClass8 GClass8_0
	{
		[CompilerGenerated]
		get
		{
			return gclass8_0;
		}
		[CompilerGenerated]
		private set
		{
			gclass8_0 = value;
		}
	}

	public GClass8 GClass8_1
	{
		[CompilerGenerated]
		get
		{
			return gclass8_1;
		}
		[CompilerGenerated]
		private set
		{
			gclass8_1 = value;
		}
	}

	public GClass5 GClass5_0
	{
		[CompilerGenerated]
		get
		{
			return gclass5_0;
		}
		[CompilerGenerated]
		private set
		{
			gclass5_0 = value;
		}
	}

	internal GClass13()
	{
		Delegate258.smethod_0(this, Delegate257.smethod_0());
		while (true)
		{
			int num = 1;
			int num2 = 7;
			while (true)
			{
				num2 ^= 0x63;
				while (true)
				{
					int num3 = Class8.smethod_0(38);
					int num4 = 63;
					while (true)
					{
						num4 ^= 0x5B;
						while (true)
						{
							int num5 = 2;
							int num6 = 6;
							while (true)
							{
								num6 ^= 0x5B;
								while (true)
								{
									int num7 = 56;
									int num8 = 3;
									while (true)
									{
										IL_01cf:
										num8 ^= 0x58;
										int num9 = Class8.smethod_0(37);
										while (true)
										{
											switch (num9 ^ 0x5A)
											{
											case -88:
												num9 = GEventArgs2.smethod_0(44);
												continue;
											default:
												num9 = Class8.smethod_0(37);
												continue;
											case -86:
												break;
											case -87:
												goto IL_006f;
											case -85:
												goto IL_01cf;
											}
											break;
										}
										switch (num8)
										{
										case 88:
											goto IL_007f;
										case 90:
											goto IL_0087;
										case 91:
											goto IL_01bd;
										case 89:
											goto end_IL_01cf;
										}
										num9 = -13;
										num9 = -87;
										goto IL_006f;
										IL_01b0:
										num6 = 7;
										num7 = 63;
										goto IL_01bd;
										IL_01bd:
										num7 ^= 0x62;
										num8 = 2;
										num9 = -15;
										num9 = -85;
										continue;
										IL_0087:
										switch (num7)
										{
										case 90:
											goto IL_00a9;
										case 91:
											goto IL_01b0;
										case 92:
											goto IL_01b9;
										case 93:
											goto end_IL_01e4;
										}
										num8 = 1;
										continue;
										IL_01b9:
										num7 = 62;
										goto IL_01bd;
										IL_00a9:
										switch (num6)
										{
										case 92:
											goto IL_00cc;
										case 93:
											goto IL_01a9;
										case 91:
											goto IL_01ed;
										case 90:
											goto end_IL_01f5;
										}
										num7 = 57;
										goto IL_01bd;
										IL_01ed:
										num6 = 0;
										goto end_IL_01e4;
										IL_00cc:
										switch (num5)
										{
										case 88:
											break;
										case 89:
											goto IL_00f3;
										case 90:
											goto IL_01a3;
										default:
											goto IL_01f2;
										case 91:
											goto end_IL_01fe;
										}
										num5 = 3;
										goto IL_01a9;
										IL_01f2:
										num6 = 1;
										goto end_IL_01e4;
										IL_00f3:
										switch (num4)
										{
										case 98:
											goto IL_0114;
										case 100:
											goto IL_019e;
										case 99:
											goto IL_020b;
										case 97:
											goto end_IL_020e;
										}
										num5 = 1;
										goto IL_01a9;
										IL_020b:
										num4 = 56;
										goto end_IL_01fe;
										IL_0114:
										switch (num3)
										{
										case -91:
											break;
										case -92:
											goto IL_0195;
										case -90:
											goto IL_019c;
										default:
											goto IL_0206;
										case -89:
											goto end_IL_0215;
										}
										switch (num2)
										{
										case 98:
											goto IL_0150;
										case 100:
											goto IL_0190;
										case 97:
											goto IL_0222;
										case 99:
											goto end_IL_0228;
										}
										num3 = -3;
										goto IL_019e;
										IL_0206:
										num4 = 58;
										goto end_IL_01fe;
										IL_019c:
										num3 = -1;
										goto IL_019e;
										IL_007f:
										num8 = 0;
										continue;
										IL_0222:
										num2 = 2;
										goto end_IL_0215;
										IL_0150:
										switch (num)
										{
										case 94:
											break;
										case 95:
											goto IL_017e;
										case 96:
											goto IL_0182;
										default:
											goto IL_0226;
										case 97:
											return;
										}
										Delegate259.smethod_0(this, Delegate257.smethod_0());
										num = 63;
										goto IL_0190;
										IL_0226:
										num2 = 0;
										goto end_IL_0215;
										IL_0182:
										Delegate260.smethod_0(this, Delegate253.smethod_0());
										num = 62;
										goto IL_0190;
										IL_017e:
										num = 0;
										goto IL_0190;
										IL_006f:
										num8 = 2;
										num9 = -15;
										num9 = -85;
										continue;
										IL_0190:
										num ^= 0x5F;
										goto IL_0195;
										IL_0195:
										num2 = 1;
										num3 = -2;
										goto IL_019e;
										IL_01a9:
										num5 ^= 0x5B;
										goto IL_01b0;
										IL_019e:
										num3 ^= 0x59;
										goto IL_01a3;
										IL_01a3:
										num4 = 57;
										num5 = 0;
										goto IL_01a9;
										continue;
										end_IL_01cf:
										break;
									}
									continue;
									end_IL_01e4:
									break;
								}
								continue;
								end_IL_01f5:
								break;
							}
							continue;
							end_IL_01fe:
							break;
						}
						continue;
						end_IL_020e:
						break;
					}
					continue;
					end_IL_0215:
					break;
				}
				continue;
				end_IL_0228:
				break;
			}
		}
	}

	internal void method_2(GEventArgs7 geventArgs7_0)
	{
		Delegate262.smethod_0(Delegate261.smethod_0(this), geventArgs7_0);
	}

	internal void method_3(GEventArgs7 geventArgs7_0)
	{
		Delegate262.smethod_0(Delegate263.smethod_0(this), geventArgs7_0);
	}

	internal void method_4(GEventArgs6 geventArgs6_0)
	{
		Delegate256.smethod_0(Delegate264.smethod_0(this), geventArgs6_0);
	}
}
