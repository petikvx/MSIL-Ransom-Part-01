using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public class GForm2 : Form
{
	private IContainer icontainer_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PictureBox1")]
	private PictureBox pictureBox_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("MemoryCleaner")]
	private Timer timer_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PictureBox2")]
	private PictureBox pictureBox_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PictureBox3")]
	private PictureBox pictureBox_2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PictureBox4")]
	private PictureBox pictureBox_3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PictureBox5")]
	private PictureBox pictureBox_4;

	private int int_0;

	private bool bool_0;

	internal virtual PictureBox PictureBox_0
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			pictureBox_0 = value;
		}
	}

	internal virtual Timer Timer_0
	{
		[CompilerGenerated]
		get
		{
			return timer_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = method_2;
			Timer val = default(Timer);
			while (true)
			{
				int num = 150454903;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4981D7EEu) % 9u)
					{
					case 8u:
					{
						int num5;
						int num6;
						if (val != null)
						{
							num5 = 1511676909;
							num6 = 1511676909;
						}
						else
						{
							num5 = 1949796799;
							num6 = 1949796799;
						}
						num = num5 ^ ((int)num2 * -2076971496);
						continue;
					}
					case 7u:
					{
						int num3;
						int num4;
						if (val != null)
						{
							num3 = 1604544381;
							num4 = 1604544381;
						}
						else
						{
							num3 = 1017240037;
							num4 = 1017240037;
						}
						num = num3 ^ ((int)num2 * -871172238);
						continue;
					}
					case 6u:
						val = timer_0;
						num = ((int)num2 * -831137306) ^ -1521262178;
						continue;
					case 5u:
						GForm2.smethod_38(val, eventHandler_);
						num = (int)(num2 * 1613493346) ^ -1467423559;
						continue;
					case 3u:
						val = timer_0;
						num = (int)((num2 * 237922680) ^ 0x68E968F9);
						continue;
					case 2u:
						timer_0 = value;
						num = 1332854504;
						continue;
					case 1u:
						GForm2.smethod_37(val, eventHandler_);
						num = ((int)num2 * -1593340682) ^ 0x65D98115;
						continue;
					default:
						return;
					case 0u:
						break;
					case 4u:
						return;
					}
					break;
				}
			}
		}
	}

	internal virtual PictureBox PictureBox_1
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			pictureBox_1 = value;
		}
	}

	internal virtual PictureBox PictureBox_2
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			pictureBox_2 = value;
		}
	}

	internal virtual PictureBox PictureBox_3
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Expected O, but got Unknown
			EventHandler eventHandler_ = method_4;
			PictureBox val = default(PictureBox);
			MouseEventHandler mouseEventHandler_ = default(MouseEventHandler);
			EventHandler eventHandler_2 = default(EventHandler);
			while (true)
			{
				int num = -1505988035;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF278DC98u) % 10u)
					{
					case 9u:
					{
						pictureBox_3 = value;
						val = pictureBox_3;
						int num5;
						if (val == null)
						{
							num = -322768655;
							num5 = -322768655;
						}
						else
						{
							num = -1381774906;
							num5 = -1381774906;
						}
						continue;
					}
					case 7u:
					{
						int num3;
						int num4;
						if (val != null)
						{
							num3 = -1072732861;
							num4 = -1072732861;
						}
						else
						{
							num3 = -1416428550;
							num4 = -1416428550;
						}
						num = num3 ^ ((int)num2 * -1371107515);
						continue;
					}
					case 6u:
						GForm2.smethod_44((Control)(object)val, mouseEventHandler_);
						num = ((int)num2 * -1535609940) ^ -2106022295;
						continue;
					case 4u:
						GForm2.smethod_42((Control)(object)val, eventHandler_);
						GForm2.smethod_43((Control)(object)val, eventHandler_2);
						num = (int)((num2 * 1161148762) ^ 0x3C6B72E6);
						continue;
					case 3u:
						GForm2.smethod_41((Control)(object)val, mouseEventHandler_);
						num = (int)(num2 * 785990342) ^ -954214279;
						continue;
					case 2u:
						mouseEventHandler_ = new MouseEventHandler(method_10);
						val = pictureBox_3;
						num = ((int)num2 * -144107586) ^ -1445859523;
						continue;
					case 1u:
						eventHandler_2 = method_5;
						num = (int)((num2 * 709802337) ^ 0x4C9A9DEB);
						continue;
					case 0u:
						GForm2.smethod_39((Control)(object)val, eventHandler_);
						GForm2.smethod_40((Control)(object)val, eventHandler_2);
						num = ((int)num2 * -1942975915) ^ 0x1C103337;
						continue;
					default:
						return;
					case 8u:
						break;
					case 5u:
						return;
					}
					break;
				}
			}
		}
	}

	internal virtual PictureBox PictureBox_4
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Expected O, but got Unknown
			EventHandler eventHandler_ = method_6;
			EventHandler eventHandler_2 = method_7;
			PictureBox val = default(PictureBox);
			MouseEventHandler mouseEventHandler_ = default(MouseEventHandler);
			while (true)
			{
				int num = 126106375;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5EC4C3F6u) % 9u)
					{
					case 8u:
						GForm2.smethod_42((Control)(object)val, eventHandler_);
						num = (int)((num2 * 1889359890) ^ 0x3E3FABB7);
						continue;
					case 6u:
					{
						mouseEventHandler_ = new MouseEventHandler(method_11);
						val = pictureBox_4;
						int num4;
						int num5;
						if (val != null)
						{
							num4 = -1254799799;
							num5 = -1254799799;
						}
						else
						{
							num4 = -1431827120;
							num5 = -1431827120;
						}
						num = num4 ^ ((int)num2 * -275907244);
						continue;
					}
					case 5u:
						GForm2.smethod_41((Control)(object)val, mouseEventHandler_);
						num = (int)((num2 * 1080263911) ^ 0x38A2FB7D);
						continue;
					case 4u:
					{
						pictureBox_4 = value;
						val = pictureBox_4;
						int num3;
						if (val == null)
						{
							num = 448708304;
							num3 = 448708304;
						}
						else
						{
							num = 65973964;
							num3 = 65973964;
						}
						continue;
					}
					case 3u:
						GForm2.smethod_40((Control)(object)val, eventHandler_2);
						num = ((int)num2 * -1000898596) ^ -1939245123;
						continue;
					case 1u:
						GForm2.smethod_39((Control)(object)val, eventHandler_);
						num = ((int)num2 * -151060524) ^ 0x1BD58369;
						continue;
					case 0u:
						GForm2.smethod_43((Control)(object)val, eventHandler_2);
						GForm2.smethod_44((Control)(object)val, mouseEventHandler_);
						num = (int)(num2 * 694245831) ^ -1090996285;
						continue;
					default:
						return;
					case 7u:
						break;
					case 2u:
						return;
					}
					break;
				}
			}
		}
	}

	public GForm2()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		while (true)
		{
			int num = -1869038527;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA3BF9F00u) % 10u)
				{
				case 9u:
					GForm2.smethod_0((Form)(object)this, (EventHandler)method_1);
					num = (int)((num2 * 1302278728) ^ 0x579C3D4C);
					continue;
				case 7u:
					method_0();
					num = ((int)num2 * -648908979) ^ -591273817;
					continue;
				case 5u:
					num = ((int)num2 * -880030610) ^ 0x7BE5F297;
					continue;
				case 4u:
					GForm2.smethod_1((Control)(object)this, new KeyEventHandler(method_3));
					num = ((int)num2 * -1795541781) ^ 0x51571D6B;
					continue;
				case 3u:
					num = (int)(num2 * 1502345474) ^ -141184043;
					continue;
				case 2u:
					int_0 = 0;
					bool_0 = false;
					num = (int)((num2 * 10297953) ^ 0x6ACC3135);
					continue;
				case 1u:
					GForm2.smethod_2((Form)(object)this, new FormClosingEventHandler(method_8));
					num = ((int)num2 * -518572861) ^ 0x18DF683F;
					continue;
				case 0u:
					num = ((int)num2 * -1942164201) ^ -879593878;
					continue;
				default:
					return;
				case 8u:
					break;
				case 6u:
					return;
				}
				break;
			}
		}
	}

	[DebuggerNonUserCode]
	void Form.Dispose(bool disposing)
	{
		try
		{
			if (disposing)
			{
				goto IL_0035;
			}
			goto IL_006a;
			IL_0035:
			int num = -1791907734;
			goto IL_003a;
			IL_003a:
			int num3;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xADA71CD4u) % 5u)
				{
				case 4u:
					GForm2.smethod_3((IDisposable)icontainer_0);
					num = (int)(num2 * 2111940143) ^ -549632150;
					continue;
				case 3u:
					num = -1654978895;
					continue;
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_005f;
				case 2u:
					return;
				}
				break;
				IL_005f:
				if (icontainer_0 != null)
				{
					num = -2097247600;
					num3 = -2097247600;
					continue;
				}
				goto IL_006a;
			}
			goto IL_0035;
			IL_006a:
			num = -778311402;
			num3 = -778311402;
			goto IL_003a;
		}
		finally
		{
			while (true)
			{
				IL_00c3:
				int num4 = -2077738423;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num4 ^ 0xADA71CD4u) % 4u)
					{
					case 1u:
						((Form)this).Dispose(disposing);
						num4 = ((int)num2 * -362305757) ^ -1832515577;
						continue;
					case 0u:
						num4 = ((int)num2 * -1019085761) ^ 0x395DB023;
						continue;
					default:
						goto end_IL_00a2;
					case 2u:
						break;
					case 3u:
						goto end_IL_00a2;
					}
					goto IL_00c3;
					continue;
					end_IL_00a2:
					break;
				}
				break;
			}
		}
	}

	[DebuggerStepThrough]
	private void method_0()
	{
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Expected O, but got Unknown
		//IL_0922: Unknown result type (might be due to invalid IL or missing references)
		//IL_092c: Expected O, but got Unknown
		ComponentResourceManager resourceManager_ = default(ComponentResourceManager);
		while (true)
		{
			int num = -2082278965;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x829D2BB6u) % 91u)
				{
				case 90u:
					icontainer_0 = GForm2.smethod_4();
					num = ((int)num2 * -823159421) ^ 0x7AF64AF8;
					continue;
				case 89u:
					num = ((int)num2 * -965063179) ^ -16382502;
					continue;
				case 88u:
					resourceManager_ = GForm2.smethod_6(GForm2.smethod_5(typeof(GForm2).TypeHandle));
					PictureBox_0 = GForm2.smethod_7();
					num = ((int)num2 * -1430009695) ^ 0x46AFC5A7;
					continue;
				case 86u:
					num = (int)((num2 * 1805015560) ^ 0x39854917);
					continue;
				case 85u:
					num = ((int)num2 * -1358549007) ^ -781784726;
					continue;
				case 84u:
					num = (int)((num2 * 1611884727) ^ 0x6F3E2660);
					continue;
				case 83u:
					GForm2.smethod_11((Control)(object)PictureBox_1, Color.Transparent);
					num = (int)((num2 * 1024226547) ^ 0x3AC9B08F);
					continue;
				case 82u:
					num = ((int)num2 * -1059034105) ^ -1093343108;
					continue;
				case 81u:
					GForm2.smethod_15((Control)(object)PictureBox_3, new Size(504, 57));
					num = ((int)num2 * -1986183842) ^ -309897021;
					continue;
				case 80u:
					GForm2.smethod_12((Control)(object)PictureBox_2, (ImageLayout)3);
					num = ((int)num2 * -461515437) ^ 0x5C248CB3;
					continue;
				case 79u:
					GForm2.smethod_35((ISupportInitialize)PictureBox_0);
					num = (int)(num2 * 1566267583) ^ -327121677;
					continue;
				case 78u:
					GForm2.smethod_17(PictureBox_2, bool_1: false);
					GForm2.smethod_11((Control)(object)PictureBox_3, Color.Transparent);
					num = (int)(num2 * 125198411) ^ -1840529116;
					continue;
				case 77u:
					num = ((int)num2 * -1928190066) ^ 0x45187CC0;
					continue;
				case 76u:
					GForm2.smethod_16(PictureBox_4, 5);
					num = ((int)num2 * -1479463368) ^ 0x5FB3A8C4;
					continue;
				case 75u:
					GForm2.smethod_17(PictureBox_3, bool_1: false);
					num = (int)((num2 * 135433984) ^ 0xE34ACBB);
					continue;
				case 74u:
					num = ((int)num2 * -1243855487) ^ -1637972341;
					continue;
				case 73u:
					Timer_0 = GForm2.smethod_8(icontainer_0);
					num = ((int)num2 * -1125786316) ^ -634263844;
					continue;
				case 72u:
					GForm2.smethod_15((Control)(object)PictureBox_4, new Size(504, 57));
					num = (int)(num2 * 1264520354) ^ -295161609;
					continue;
				case 71u:
					GForm2.smethod_9((ISupportInitialize)PictureBox_4);
					GForm2.smethod_10((Control)(object)this);
					num = (int)((num2 * 1061096103) ^ 0x326570C3);
					continue;
				case 70u:
					GForm2.smethod_16(PictureBox_3, 4);
					num = ((int)num2 * -281485205) ^ 0x1513C2C1;
					continue;
				case 69u:
					num = ((int)num2 * -1539114977) ^ -921316163;
					continue;
				case 68u:
					GForm2.smethod_18(Timer_0, 1000);
					num = (int)(num2 * 1641690878) ^ -261755145;
					continue;
				case 67u:
					GForm2.smethod_16(PictureBox_2, 3);
					num = (int)(num2 * 2005202206) ^ -95679658;
					continue;
				case 66u:
					GForm2.smethod_35((ISupportInitialize)PictureBox_3);
					num = (int)(num2 * 849996324) ^ -1744157672;
					continue;
				case 65u:
					GForm2.smethod_12((Control)(object)PictureBox_4, (ImageLayout)3);
					num = (int)(num2 * 343549744) ^ -288648843;
					continue;
				case 64u:
					num = ((int)num2 * -933735137) ^ 0x4EDC79A6;
					continue;
				case 63u:
					GForm2.smethod_9((ISupportInitialize)PictureBox_1);
					num = (int)((num2 * 1818876911) ^ 0x48ACAB47);
					continue;
				case 62u:
					GForm2.smethod_16(PictureBox_0, 1);
					num = ((int)num2 * -1940049212) ^ -298483783;
					continue;
				case 61u:
					num = ((int)num2 * -2128335101) ^ 0x65294865;
					continue;
				case 60u:
					PictureBox_2 = GForm2.smethod_7();
					num = ((int)num2 * -88124554) ^ 0xE088F46;
					continue;
				case 59u:
					GForm2.smethod_30((Form)(object)this, new Padding(4));
					num = ((int)num2 * -2064309246) ^ 0x41E6FD2F;
					continue;
				case 58u:
					GForm2.smethod_35((ISupportInitialize)PictureBox_1);
					GForm2.smethod_35((ISupportInitialize)PictureBox_2);
					num = (int)(num2 * 1924161716) ^ -1709801464;
					continue;
				case 57u:
					num = (int)(num2 * 1184643306) ^ -1911178082;
					continue;
				case 56u:
					GForm2.smethod_12((Control)(object)PictureBox_3, (ImageLayout)3);
					num = (int)((num2 * 79335764) ^ 0x45B3DB90);
					continue;
				case 55u:
					num = ((int)num2 * -11624324) ^ -457257623;
					continue;
				case 54u:
					GForm2.smethod_20((Control)(object)PictureBox_3, (Image)GForm2.smethod_19((ResourceManager)resourceManager_, "PictureBox4.BackgroundImage"));
					num = ((int)num2 * -1193554478) ^ 0x13DFCB41;
					continue;
				case 53u:
					GForm2.smethod_12((Control)(object)this, (ImageLayout)3);
					num = ((int)num2 * -467920514) ^ 0x27560C0E;
					continue;
				case 52u:
					num = ((int)num2 * -387736376) ^ -1067922169;
					continue;
				case 51u:
					num = ((int)num2 * -2095021330) ^ -1172661403;
					continue;
				case 50u:
					GForm2.smethod_26(GForm2.smethod_25((Control)(object)this), (Control)(object)PictureBox_0);
					((Control)this).set_DoubleBuffered(true);
					num = ((int)num2 * -651557537) ^ 0x7E507A97;
					continue;
				case 49u:
					GForm2.smethod_24((Form)(object)this, new Size(1025, 638));
					num = ((int)num2 * -2089728417) ^ 0x2BA96F02;
					continue;
				case 48u:
					GForm2.smethod_13((Control)(object)PictureBox_4, new Point(268, 555));
					num = ((int)num2 * -75842151) ^ 0x611F251E;
					continue;
				case 47u:
					GForm2.smethod_14((Control)(object)PictureBox_3, "PictureBox4");
					num = ((int)num2 * -842015122) ^ 0x57F75C6C;
					continue;
				case 46u:
					num = (int)((num2 * 305175749) ^ 0x222F7E65);
					continue;
				case 45u:
					GForm2.smethod_11((Control)(object)PictureBox_0, Color.Transparent);
					num = ((int)num2 * -715816090) ^ 0x75BA2ED2;
					continue;
				case 44u:
					num = ((int)num2 * -1723863000) ^ -1396926314;
					continue;
				case 43u:
					GForm2.smethod_26(GForm2.smethod_25((Control)(object)this), (Control)(object)PictureBox_2);
					GForm2.smethod_26(GForm2.smethod_25((Control)(object)this), (Control)(object)PictureBox_1);
					num = ((int)num2 * -257628162) ^ -1680880819;
					continue;
				case 42u:
					GForm2.smethod_14((Control)(object)PictureBox_0, "PictureBox1");
					GForm2.smethod_15((Control)(object)PictureBox_0, new Size(617, 69));
					num = ((int)num2 * -1025326440) ^ 0x2F02AC44;
					continue;
				case 41u:
					num = ((int)num2 * -1322767000) ^ -1110979614;
					continue;
				case 40u:
					GForm2.smethod_9((ISupportInitialize)PictureBox_2);
					GForm2.smethod_9((ISupportInitialize)PictureBox_3);
					num = (int)((num2 * 1345432452) ^ 0x62FF4F33);
					continue;
				case 39u:
					GForm2.smethod_15((Control)(object)PictureBox_2, new Size(353, 42));
					num = (int)(num2 * 1051759656) ^ -1880221909;
					continue;
				case 38u:
					PictureBox_3 = GForm2.smethod_7();
					num = (int)(num2 * 265535823) ^ -1217294823;
					continue;
				case 37u:
					GForm2.smethod_17(PictureBox_0, bool_1: false);
					num = (int)(num2 * 1048391132) ^ -1944950471;
					continue;
				case 36u:
					num = ((int)num2 * -2082144387) ^ 0x503D7A7A;
					continue;
				case 35u:
					num = (int)((num2 * 1085773849) ^ 0x5C2F2088);
					continue;
				case 34u:
					GForm2.smethod_13((Control)(object)PictureBox_0, new Point(214, 12));
					num = (int)(num2 * 1407733213) ^ -1931120983;
					continue;
				case 33u:
					GForm2.smethod_21((ContainerControl)(object)this, new SizeF(10f, 22f));
					num = ((int)num2 * -963815057) ^ 0x39FCA48C;
					continue;
				case 32u:
					GForm2.smethod_17(PictureBox_1, bool_1: false);
					num = ((int)num2 * -1365112497) ^ -461271606;
					continue;
				case 31u:
					GForm2.smethod_32((Control)(object)this, "SelectDuelType");
					GForm2.smethod_33((Form)(object)this, (FormStartPosition)1);
					GForm2.smethod_34((Form)(object)this, "The Omegle Game");
					num = (int)((num2 * 1686859437) ^ 0x2C430C85);
					continue;
				case 30u:
					GForm2.smethod_13((Control)(object)PictureBox_1, new Point(268, 168));
					num = ((int)num2 * -2106060208) ^ 0x12CBC5A3;
					continue;
				case 29u:
					num = ((int)num2 * -811026148) ^ 0x2536F9B8;
					continue;
				case 28u:
					GForm2.smethod_12((Control)(object)PictureBox_1, (ImageLayout)3);
					num = ((int)num2 * -1844444167) ^ -853488379;
					continue;
				case 27u:
					num = ((int)num2 * -93241694) ^ 0x2535131E;
					continue;
				case 26u:
					GForm2.smethod_12((Control)(object)PictureBox_0, (ImageLayout)3);
					num = ((int)num2 * -1812951499) ^ 0x6404E48F;
					continue;
				case 25u:
					PictureBox_4 = GForm2.smethod_7();
					num = (int)(num2 * 428406461) ^ -613326091;
					continue;
				case 23u:
					GForm2.smethod_23((Form)(object)this, Color.White);
					num = ((int)num2 * -1886775299) ^ -220179276;
					continue;
				case 22u:
					GForm2.smethod_16(PictureBox_1, 2);
					num = ((int)num2 * -593842462) ^ -261622338;
					continue;
				case 21u:
					GForm2.smethod_35((ISupportInitialize)PictureBox_4);
					num = ((int)num2 * -1863444401) ^ 0x49D834B;
					continue;
				case 20u:
					GForm2.smethod_36((Control)(object)this, bool_1: false);
					num = (int)(num2 * 499210656) ^ -1249548472;
					continue;
				case 19u:
					num = (int)(num2 * 1310032054) ^ -1211040635;
					continue;
				case 18u:
					GForm2.smethod_26(GForm2.smethod_25((Control)(object)this), (Control)(object)PictureBox_4);
					GForm2.smethod_26(GForm2.smethod_25((Control)(object)this), (Control)(object)PictureBox_3);
					num = ((int)num2 * -1994878177) ^ -1492534543;
					continue;
				case 17u:
					num = (int)((num2 * 593061047) ^ 0x72ECCEB0);
					continue;
				case 16u:
					GForm2.smethod_15((Control)(object)PictureBox_1, new Size(504, 57));
					num = (int)((num2 * 1018630839) ^ 0x546EC776);
					continue;
				case 15u:
					GForm2.smethod_29((Form)(object)this, (FormBorderStyle)1);
					num = (int)(num2 * 824757022) ^ -1600187896;
					continue;
				case 14u:
					num = ((int)num2 * -669125847) ^ -1314225626;
					continue;
				case 13u:
					GForm2.smethod_11((Control)(object)PictureBox_2, Color.Transparent);
					num = (int)(num2 * 1801314784) ^ -1258521358;
					continue;
				case 12u:
					GForm2.smethod_14((Control)(object)PictureBox_4, "PictureBox5");
					num = ((int)num2 * -436750041) ^ -1253945531;
					continue;
				case 11u:
					GForm2.smethod_11((Control)(object)PictureBox_4, Color.Transparent);
					GForm2.smethod_20((Control)(object)PictureBox_4, (Image)GForm2.smethod_19((ResourceManager)resourceManager_, "PictureBox5.BackgroundImage"));
					num = ((int)num2 * -38936861) ^ 0x5071EB8C;
					continue;
				case 10u:
					PictureBox_1 = GForm2.smethod_7();
					num = (int)(num2 * 1317819353) ^ -1030907061;
					continue;
				case 9u:
					GForm2.smethod_13((Control)(object)PictureBox_2, new Point(338, 306));
					GForm2.smethod_14((Control)(object)PictureBox_2, "PictureBox3");
					num = (int)(num2 * 893546438) ^ -994112104;
					continue;
				case 8u:
					GForm2.smethod_9((ISupportInitialize)PictureBox_0);
					num = ((int)num2 * -326203561) ^ -1776942989;
					continue;
				case 7u:
					num = ((int)num2 * -1252067724) ^ 0x50D36134;
					continue;
				case 6u:
					num = (int)(num2 * 1129057843) ^ -1371566751;
					continue;
				case 5u:
					GForm2.smethod_13((Control)(object)PictureBox_3, new Point(268, 492));
					num = ((int)num2 * -1627498301) ^ -528078289;
					continue;
				case 4u:
					GForm2.smethod_14((Control)(object)PictureBox_1, "PictureBox2");
					num = ((int)num2 * -906629229) ^ 0x7BF725E2;
					continue;
				case 3u:
					GForm2.smethod_31((Form)(object)this, bool_1: false);
					num = (int)((num2 * 2142990098) ^ 0x2C0CE54E);
					continue;
				case 2u:
					GForm2.smethod_22((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 1732869536) ^ -139006248;
					continue;
				case 1u:
					GForm2.smethod_28((Control)(object)this, GForm2.smethod_27("Consolas", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -39108732) ^ 0x6940F2FE;
					continue;
				case 0u:
					GForm2.smethod_17(PictureBox_4, bool_1: false);
					num = ((int)num2 * -1890097375) ^ -1258982423;
					continue;
				default:
					return;
				case 87u:
					break;
				case 24u:
					return;
				}
				break;
			}
		}
	}

	private void method_1(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 231399308;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x40DEE1D7u) % 13u)
				{
				case 11u:
					num = ((int)num2 * -1436170514) ^ 0x75954D36;
					continue;
				case 10u:
					GForm2.smethod_20((Control)(object)PictureBox_1, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\seleziona_una_modalita.png")));
					num = (int)(num2 * 1950664802) ^ -622391133;
					continue;
				case 9u:
					GForm2.smethod_20((Control)(object)PictureBox_4, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\torna_indietro.png")));
					GForm2.smethod_50(Timer_0);
					num = (int)((num2 * 303602833) ^ 0x57E8D763);
					continue;
				case 8u:
					GForm2.smethod_20((Control)(object)PictureBox_3, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\fai_un_duello.png")));
					num = (int)(num2 * 1451842498) ^ -1424897509;
					continue;
				case 7u:
					num = (int)((num2 * 2003100004) ^ 0x67E1EF91);
					continue;
				case 6u:
					GForm2.smethod_46(GForm2.smethod_45(), ProcessPriorityClass.RealTime);
					num = ((int)num2 * -1677524539) ^ -2134744453;
					continue;
				case 4u:
					GForm2.smethod_20((Control)(object)PictureBox_0, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\logo.png")));
					num = (int)((num2 * 1975007318) ^ 0x722BF79D);
					continue;
				case 3u:
					GForm2.smethod_20((Control)(object)this, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\main_menu.jpg")));
					num = ((int)num2 * -828132899) ^ -996103597;
					continue;
				case 2u:
					num = (int)((num2 * 666781198) ^ 0x739ADA75);
					continue;
				case 1u:
					GForm2.smethod_20((Control)(object)PictureBox_2, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\con_la_cpu_hover.png")));
					num = (int)((num2 * 152344014) ^ 0x1D31FEB2);
					continue;
				case 0u:
					num = ((int)num2 * -774885994) ^ -1470493857;
					continue;
				default:
					return;
				case 5u:
					break;
				case 12u:
					return;
				}
				break;
			}
		}
	}

	private void method_2(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 1460292761;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x36E47C14u) % 4u)
				{
				case 3u:
					num = (int)((num2 * 1081055858) ^ 0x6B720D24);
					continue;
				case 1u:
					GForm2.smethod_51();
					num = ((int)num2 * -1087619501) ^ -1088900096;
					continue;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	private void method_3(object sender, KeyEventArgs e)
	{
		if ((GForm2.smethod_52(e) == 37) | (GForm2.smethod_52(e) == 39))
		{
			goto IL_00a0;
		}
		goto IL_01e9;
		IL_01e9:
		int num = 2028700946;
		goto IL_0196;
		IL_0196:
		bool flag = default(bool);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x435F40Eu) % 16u)
			{
			case 15u:
				flag = int_0 == 0;
				num = (int)((num2 * 861671186) ^ 0x5C80D3C3);
				continue;
			case 14u:
				int_0 = 1;
				num = (int)((num2 * 794415348) ^ 0x4AB626DF);
				continue;
			case 12u:
			{
				int num5;
				int num6;
				if (int_0 == 0)
				{
					num5 = 225106962;
					num6 = 225106962;
				}
				else
				{
					num5 = 279050411;
					num6 = 279050411;
				}
				num = num5 ^ (int)(num2 * 246916687);
				continue;
			}
			case 11u:
				int_0 = 0;
				num = ((int)num2 * -474538606) ^ 0x740AA1DA;
				continue;
			case 10u:
				break;
			case 9u:
				num = ((int)num2 * -691664722) ^ 0x15E72462;
				continue;
			case 8u:
				GForm2.smethod_20((Control)(object)PictureBox_2, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\con_la_cpu_hover.png")));
				num = (int)(num2 * 1158683589) ^ -1524223469;
				continue;
			case 7u:
				num = 849646581;
				continue;
			case 6u:
				GForm2.smethod_20((Control)(object)PictureBox_2, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\con_gli_altri.png")));
				num = (int)((num2 * 921184508) ^ 0x52429EB2);
				continue;
			case 5u:
				num = ((int)num2 * -1207719912) ^ -1471690325;
				continue;
			case 4u:
				num = ((int)num2 * -2129763853) ^ -2003280849;
				continue;
			case 3u:
			{
				int num3;
				int num4;
				if (!flag)
				{
					num3 = -1606533167;
					num4 = -1606533167;
				}
				else
				{
					num3 = -182721144;
					num4 = -182721144;
				}
				num = num3 ^ (int)(num2 * 285004296);
				continue;
			}
			case 2u:
				num = 568403486;
				continue;
			case 1u:
				goto IL_0174;
			default:
				return;
			case 0u:
				goto IL_01e9;
			case 13u:
				return;
			}
			break;
			IL_0174:
			int num7;
			if (int_0 == 1)
			{
				num = 1820933272;
				num7 = 1820933272;
			}
			else
			{
				num = 159641043;
				num7 = 159641043;
			}
		}
		goto IL_00a0;
		IL_00a0:
		num = 1911953825;
		goto IL_0196;
	}

	private void method_4(object sender, EventArgs e)
	{
		GForm2.smethod_20((Control)(object)PictureBox_3, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\fai_un_duello_hover.png")));
	}

	private void method_5(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -1079330507;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9CF30B91u) % 3u)
				{
				case 1u:
					goto IL_0003;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0003:
				GForm2.smethod_20((Control)(object)PictureBox_3, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\fai_un_duello.png")));
				num = (int)(num2 * 1357532124) ^ -1752162513;
			}
		}
	}

	private void method_6(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 1882552965;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7FBFBDF2u) % 4u)
				{
				case 3u:
					GForm2.smethod_20((Control)(object)PictureBox_4, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\torna_indietro_hover.png")));
					num = ((int)num2 * -181253058) ^ -247091487;
					continue;
				case 1u:
					num = ((int)num2 * -991757095) ^ -1357841603;
					continue;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	private void method_7(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -146912391;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBB531D86u) % 4u)
				{
				case 3u:
					GForm2.smethod_20((Control)(object)PictureBox_4, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\torna_indietro.png")));
					num = ((int)num2 * -252869391) ^ 0x1BF30C19;
					continue;
				case 0u:
					num = (int)((num2 * 163794394) ^ 0x175B80CF);
					continue;
				default:
					return;
				case 2u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	private void method_8(object sender, FormClosingEventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -589380;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB4CCA748u) % 9u)
				{
				case 8u:
					num = ((int)num2 * -1104022651) ^ -11602937;
					continue;
				case 7u:
					num = -488344251;
					continue;
				case 6u:
					GForm2.smethod_53((CancelEventArgs)(object)e, bool_1: true);
					num = (int)(num2 * 1815824232) ^ -1504708581;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1536278812;
						num4 = 1536278812;
					}
					else
					{
						num3 = 1453414248;
						num4 = 1453414248;
					}
					num = num3 ^ ((int)num2 * -1467808554);
					continue;
				}
				case 2u:
					num = ((int)num2 * -996793100) ^ -1846999486;
					continue;
				case 1u:
					method_9();
					num = (int)((num2 * 1333770386) ^ 0x185B4481);
					continue;
				case 0u:
					flag = !bool_0;
					num = (int)((num2 * 1562767094) ^ 0x1F6E3BA5);
					continue;
				default:
					return;
				case 5u:
					break;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	public void method_9()
	{
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Invalid comparison between Unknown and I4
		bool flag = !bool_0;
		bool flag2 = default(bool);
		while (true)
		{
			int num = 1745352269;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x891DD18u) % 23u)
				{
				case 22u:
					GForm2.smethod_56((object)int_0);
					num = (int)((num2 * 772760129) ^ 0x47F851F2);
					continue;
				case 21u:
					GForm2.smethod_56((object)Timer_0);
					num = (int)((num2 * 145535383) ^ 0xDA7DE81);
					continue;
				case 20u:
					num = 367435172;
					continue;
				case 19u:
					GForm2.smethod_56((object)int_0);
					num = ((int)num2 * -664306128) ^ 0x3604990C;
					continue;
				case 18u:
					GForm2.smethod_57(GForm2.smethod_45());
					num = (int)(num2 * 2102779631) ^ -164928217;
					continue;
				case 16u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = 1801417235;
						num6 = 1801417235;
					}
					else
					{
						num5 = 136284964;
						num6 = 136284964;
					}
					num = num5 ^ (int)(num2 * 637251510);
					continue;
				}
				case 15u:
				{
					int num3;
					int num4;
					if (flag2)
					{
						num3 = 1303945526;
						num4 = 1303945526;
					}
					else
					{
						num3 = 538094834;
						num4 = 538094834;
					}
					num = num3 ^ (int)(num2 * 182845661);
					continue;
				}
				case 14u:
					flag2 = (int)GForm2.smethod_54("Sei sicuro di voler uscire dal gioco?", "The Omegle Game", (MessageBoxButtons)4, (MessageBoxIcon)32) == 6;
					num = (int)(num2 * 41160725) ^ -1115706179;
					continue;
				case 13u:
					GForm2.smethod_51();
					num = ((int)num2 * -254790967) ^ 0x8CE4DD9;
					continue;
				case 12u:
					GForm2.smethod_55(Timer_0);
					num = (int)(num2 * 1833755954) ^ -869518338;
					continue;
				case 11u:
					GForm2.smethod_56((object)bool_0);
					num = (int)((num2 * 1437286524) ^ 0x98A778A);
					continue;
				case 10u:
					num = (int)(num2 * 1269759968) ^ -135258255;
					continue;
				case 9u:
					num = ((int)num2 * -97544609) ^ -633186422;
					continue;
				case 8u:
					num = (int)(num2 * 2023820268) ^ -1028079313;
					continue;
				case 7u:
					num = ((int)num2 * -600727907) ^ -1397607708;
					continue;
				case 6u:
					num = ((int)num2 * -1134341754) ^ 0x22E31AA0;
					continue;
				case 5u:
					GForm2.smethod_56((object)bool_0);
					GForm2.smethod_51();
					num = ((int)num2 * -1241674984) ^ -105179913;
					continue;
				case 3u:
					GForm2.smethod_55(Timer_0);
					GForm2.smethod_56((object)Timer_0);
					num = (int)((num2 * 55996313) ^ 0x413C2C40);
					continue;
				case 2u:
					num = (int)(num2 * 551495584) ^ -1960656131;
					continue;
				case 1u:
					num = ((int)num2 * -83253493) ^ 0x360803B0;
					continue;
				case 0u:
					num = 1543923376;
					continue;
				default:
					return;
				case 17u:
					break;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	private void method_10(object sender, MouseEventArgs e)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			int num = -738816456;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBC0AF7C7u) % 4u)
				{
				case 3u:
					bool_0 = true;
					num = ((int)num2 * -390329887) ^ 0x5DB37E79;
					continue;
				case 1u:
					GForm2.smethod_54("Ci dispiace, ma la modalità duello non è attualmente disponibile.", "The Omegle Game", (MessageBoxButtons)0, (MessageBoxIcon)48);
					num = (int)((num2 * 513900996) ^ 0x2265B211);
					continue;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	private void method_11(object sender, MouseEventArgs e)
	{
		while (true)
		{
			int num = -834461735;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD87E9368u) % 4u)
				{
				case 3u:
					GForm2.smethod_59((Form)(object)this);
					num = ((int)num2 * -236883950) ^ 0xFA7070A;
					continue;
				case 1u:
					bool_0 = true;
					GForm2.smethod_58((Control)(object)Class2.Class3_0.GForm1_0);
					num = ((int)num2 * -477545780) ^ 0x63526E2F;
					continue;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	static void smethod_0(Form form_0, EventHandler eventHandler_0)
	{
		form_0.add_Load(eventHandler_0);
	}

	static void smethod_1(Control control_0, KeyEventHandler keyEventHandler_0)
	{
		control_0.add_KeyDown(keyEventHandler_0);
	}

	static void smethod_2(Form form_0, FormClosingEventHandler formClosingEventHandler_0)
	{
		form_0.add_FormClosing(formClosingEventHandler_0);
	}

	static void smethod_3(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Container smethod_4()
	{
		return new Container();
	}

	static Type smethod_5(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static ComponentResourceManager smethod_6(Type type_0)
	{
		return new ComponentResourceManager(type_0);
	}

	static PictureBox smethod_7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new PictureBox();
	}

	static Timer smethod_8(IContainer icontainer_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new Timer(icontainer_1);
	}

	static void smethod_9(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.BeginInit();
	}

	static void smethod_10(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_11(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static void smethod_12(Control control_0, ImageLayout imageLayout_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_BackgroundImageLayout(imageLayout_0);
	}

	static void smethod_13(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_14(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_15(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_16(PictureBox pictureBox_5, int int_1)
	{
		pictureBox_5.set_TabIndex(int_1);
	}

	static void smethod_17(PictureBox pictureBox_5, bool bool_1)
	{
		pictureBox_5.set_TabStop(bool_1);
	}

	static void smethod_18(Timer timer_1, int int_1)
	{
		timer_1.set_Interval(int_1);
	}

	static object smethod_19(ResourceManager resourceManager_0, string string_0)
	{
		return resourceManager_0.GetObject(string_0);
	}

	static void smethod_20(Control control_0, Image image_0)
	{
		control_0.set_BackgroundImage(image_0);
	}

	static void smethod_21(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_22(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_23(Form form_0, Color color_0)
	{
		form_0.set_BackColor(color_0);
	}

	static void smethod_24(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static ControlCollection smethod_25(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_26(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static Font smethod_27(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_28(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_29(Form form_0, FormBorderStyle formBorderStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_FormBorderStyle(formBorderStyle_0);
	}

	static void smethod_30(Form form_0, Padding padding_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_Margin(padding_0);
	}

	static void smethod_31(Form form_0, bool bool_1)
	{
		form_0.set_MaximizeBox(bool_1);
	}

	static void smethod_32(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_33(Form form_0, FormStartPosition formStartPosition_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_StartPosition(formStartPosition_0);
	}

	static void smethod_34(Form form_0, string string_0)
	{
		form_0.set_Text(string_0);
	}

	static void smethod_35(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_36(Control control_0, bool bool_1)
	{
		control_0.ResumeLayout(bool_1);
	}

	static void smethod_37(Timer timer_1, EventHandler eventHandler_0)
	{
		timer_1.remove_Tick(eventHandler_0);
	}

	static void smethod_38(Timer timer_1, EventHandler eventHandler_0)
	{
		timer_1.add_Tick(eventHandler_0);
	}

	static void smethod_39(Control control_0, EventHandler eventHandler_0)
	{
		control_0.remove_MouseEnter(eventHandler_0);
	}

	static void smethod_40(Control control_0, EventHandler eventHandler_0)
	{
		control_0.remove_MouseLeave(eventHandler_0);
	}

	static void smethod_41(Control control_0, MouseEventHandler mouseEventHandler_0)
	{
		control_0.remove_MouseClick(mouseEventHandler_0);
	}

	static void smethod_42(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_MouseEnter(eventHandler_0);
	}

	static void smethod_43(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_MouseLeave(eventHandler_0);
	}

	static void smethod_44(Control control_0, MouseEventHandler mouseEventHandler_0)
	{
		control_0.add_MouseClick(mouseEventHandler_0);
	}

	static Process smethod_45()
	{
		return Process.GetCurrentProcess();
	}

	static void smethod_46(Process process_0, ProcessPriorityClass processPriorityClass_0)
	{
		process_0.PriorityClass = processPriorityClass_0;
	}

	static string smethod_47()
	{
		return Application.get_StartupPath();
	}

	static string smethod_48(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static Image smethod_49(string string_0)
	{
		return Image.FromFile(string_0);
	}

	static void smethod_50(Timer timer_1)
	{
		timer_1.Start();
	}

	static void smethod_51()
	{
		GC.Collect();
	}

	static int smethod_52(KeyEventArgs keyEventArgs_0)
	{
		return keyEventArgs_0.get_KeyValue();
	}

	static void smethod_53(CancelEventArgs cancelEventArgs_0, bool bool_1)
	{
		cancelEventArgs_0.Cancel = bool_1;
	}

	static DialogResult smethod_54(string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0, string_1, messageBoxButtons_0, messageBoxIcon_0);
	}

	static void smethod_55(Timer timer_1)
	{
		timer_1.Stop();
	}

	static void smethod_56(object object_0)
	{
		GC.SuppressFinalize(object_0);
	}

	static void smethod_57(Process process_0)
	{
		process_0.Kill();
	}

	static void smethod_58(Control control_0)
	{
		control_0.Show();
	}

	static void smethod_59(Form form_0)
	{
		form_0.Close();
	}
}
