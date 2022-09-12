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
			Timer val = timer_0;
			if (val != null)
			{
				goto IL_006c;
			}
			goto IL_009a;
			IL_009a:
			timer_0 = value;
			val = timer_0;
			int num = -283496728;
			goto IL_0071;
			IL_0071:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x84C8ED41u) % 6u)
				{
				case 4u:
					GForm2.smethod_38(val, eventHandler_);
					num = (int)((num2 * 2045015112) ^ 0x3E10F4A6);
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (val != null)
					{
						num3 = -1553429647;
						num4 = -1553429647;
					}
					else
					{
						num3 = -1873174584;
						num4 = -1873174584;
					}
					num = num3 ^ ((int)num2 * -892296850);
					continue;
				}
				case 2u:
					GForm2.smethod_37(val, eventHandler_);
					num = (int)(num2 * 1789152306) ^ -101098004;
					continue;
				case 0u:
					break;
				default:
					return;
				case 5u:
					goto IL_009a;
				case 1u:
					return;
				}
				break;
			}
			goto IL_006c;
			IL_006c:
			num = -806854549;
			goto IL_0071;
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
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Expected O, but got Unknown
			EventHandler eventHandler_ = method_4;
			PictureBox val = default(PictureBox);
			EventHandler eventHandler_2 = default(EventHandler);
			MouseEventHandler mouseEventHandler_ = default(MouseEventHandler);
			while (true)
			{
				int num = -1143888163;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBBD39D3Eu) % 13u)
					{
					case 12u:
					{
						val = pictureBox_3;
						int num5;
						int num6;
						if (val == null)
						{
							num5 = 148973467;
							num6 = 148973467;
						}
						else
						{
							num5 = 2106146355;
							num6 = 2106146355;
						}
						num = num5 ^ (int)(num2 * 1619302559);
						continue;
					}
					case 11u:
					{
						int num3;
						int num4;
						if (val != null)
						{
							num3 = 1128860204;
							num4 = 1128860204;
						}
						else
						{
							num3 = 1947653950;
							num4 = 1947653950;
						}
						num = num3 ^ (int)(num2 * 1061576824);
						continue;
					}
					case 10u:
						eventHandler_2 = method_5;
						mouseEventHandler_ = new MouseEventHandler(method_10);
						num = ((int)num2 * -2114224451) ^ -174972673;
						continue;
					case 9u:
						GForm2.smethod_40((Control)(object)val, eventHandler_2);
						num = ((int)num2 * -254947165) ^ 0x120E8DD7;
						continue;
					case 8u:
						GForm2.smethod_44((Control)(object)val, mouseEventHandler_);
						num = (int)(num2 * 1520905187) ^ -1392776319;
						continue;
					case 7u:
						GForm2.smethod_42((Control)(object)val, eventHandler_);
						num = ((int)num2 * -2009589804) ^ -1652556826;
						continue;
					case 5u:
						GForm2.smethod_43((Control)(object)val, eventHandler_2);
						num = ((int)num2 * -47409820) ^ 0x7C4C9DB5;
						continue;
					case 4u:
						GForm2.smethod_39((Control)(object)val, eventHandler_);
						num = ((int)num2 * -2077118736) ^ 0x2B7BE6B5;
						continue;
					case 2u:
						GForm2.smethod_41((Control)(object)val, mouseEventHandler_);
						num = (int)((num2 * 1905342392) ^ 0x6E78680E);
						continue;
					case 1u:
						pictureBox_3 = value;
						num = -1785295237;
						continue;
					case 0u:
						val = pictureBox_3;
						num = (int)((num2 * 1149137027) ^ 0x45D11F3E);
						continue;
					default:
						return;
					case 6u:
						break;
					case 3u:
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
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Expected O, but got Unknown
			EventHandler eventHandler_ = method_6;
			PictureBox val = default(PictureBox);
			EventHandler eventHandler_2 = default(EventHandler);
			MouseEventHandler mouseEventHandler_ = default(MouseEventHandler);
			while (true)
			{
				int num = 1543749140;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1A940DD8u) % 9u)
					{
					case 8u:
					{
						int num5;
						int num6;
						if (val == null)
						{
							num5 = 1978135005;
							num6 = 1978135005;
						}
						else
						{
							num5 = 2039168079;
							num6 = 2039168079;
						}
						num = num5 ^ ((int)num2 * -1343001173);
						continue;
					}
					case 7u:
						GForm2.smethod_39((Control)(object)val, eventHandler_);
						GForm2.smethod_40((Control)(object)val, eventHandler_2);
						GForm2.smethod_41((Control)(object)val, mouseEventHandler_);
						num = (int)((num2 * 2057639223) ^ 0x7F486157);
						continue;
					case 6u:
					{
						int num3;
						int num4;
						if (val == null)
						{
							num3 = 2097222314;
							num4 = 2097222314;
						}
						else
						{
							num3 = 2097065877;
							num4 = 2097065877;
						}
						num = num3 ^ ((int)num2 * -496360437);
						continue;
					}
					case 5u:
						val = pictureBox_4;
						num = ((int)num2 * -1843711329) ^ 0x4DD417A6;
						continue;
					case 4u:
						eventHandler_2 = method_7;
						mouseEventHandler_ = new MouseEventHandler(method_11);
						val = pictureBox_4;
						num = (int)((num2 * 1251190093) ^ 0x1C9F8FBB);
						continue;
					case 3u:
						pictureBox_4 = value;
						num = 1870036767;
						continue;
					case 1u:
						GForm2.smethod_42((Control)(object)val, eventHandler_);
						GForm2.smethod_43((Control)(object)val, eventHandler_2);
						GForm2.smethod_44((Control)(object)val, mouseEventHandler_);
						num = (int)((num2 * 97031473) ^ 0x6217C52A);
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
	}

	public GForm2()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		while (true)
		{
			int num = -132900751;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xACBB357Fu) % 5u)
				{
				case 3u:
					num = ((int)num2 * -756270293) ^ 0x31776CAB;
					continue;
				case 1u:
					GForm2.smethod_1((Control)(object)this, new KeyEventHandler(method_3));
					num = ((int)num2 * -151724970) ^ -835429749;
					continue;
				case 0u:
					GForm2.smethod_0((Form)(object)this, (EventHandler)method_1);
					num = (int)((num2 * 425109206) ^ 0x5183329B);
					continue;
				case 2u:
					break;
				default:
					GForm2.smethod_2((Form)(object)this, new FormClosingEventHandler(method_8));
					int_0 = 0;
					bool_0 = false;
					method_0();
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
			while (true)
			{
				int num = 298954257;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x1E783E89u) % 7u)
					{
					case 5u:
						GForm2.smethod_3((IDisposable)icontainer_0);
						num = ((int)num2 * -1389709510) ^ 0x6ABB7F24;
						continue;
					case 4u:
						num = ((int)num2 * -188798498) ^ -483760033;
						continue;
					case 3u:
						if (disposing)
						{
							num = (int)((num2 * 876710189) ^ 0x370257CB);
							continue;
						}
						goto IL_0051;
					case 1u:
						num = 2027042448;
						continue;
					case 0u:
						if (icontainer_0 != null)
						{
							num = 987290785;
							num3 = 987290785;
							continue;
						}
						goto IL_0051;
					default:
						return;
					case 6u:
						break;
					case 2u:
						return;
						IL_0051:
						num = 1234184377;
						num3 = 1234184377;
						continue;
					}
					break;
				}
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
			while (true)
			{
				IL_00d9:
				int num4 = 1093218671;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num4 ^ 0x1E783E89u) % 3u)
					{
					case 1u:
						goto IL_00af;
					default:
						goto end_IL_00bc;
					case 0u:
						break;
					case 2u:
						goto end_IL_00bc;
					}
					goto IL_00d9;
					IL_00af:
					num4 = (int)(num2 * 680214536) ^ -905733604;
					continue;
					end_IL_00bc:
					break;
				}
				break;
			}
		}
	}

	[DebuggerStepThrough]
	private void method_0()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_072f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0739: Expected O, but got Unknown
		//IL_0827: Unknown result type (might be due to invalid IL or missing references)
		//IL_0831: Expected O, but got Unknown
		ComponentResourceManager resourceManager_ = default(ComponentResourceManager);
		while (true)
		{
			int num = -922275006;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF1BEB579u) % 87u)
				{
				case 86u:
					GForm2.smethod_9((ISupportInitialize)PictureBox_3);
					num = (int)(num2 * 604299776) ^ -1587686618;
					continue;
				case 85u:
					num = ((int)num2 * -743499264) ^ -1553576348;
					continue;
				case 84u:
					GForm2.smethod_30((Form)(object)this, new Padding(4));
					num = (int)(num2 * 945868912) ^ -1462524853;
					continue;
				case 83u:
					num = (int)(num2 * 38131895) ^ -2082525894;
					continue;
				case 82u:
					GForm2.smethod_16(PictureBox_2, 3);
					num = ((int)num2 * -550945940) ^ 0x25CC11A3;
					continue;
				case 81u:
					GForm2.smethod_16(PictureBox_1, 2);
					num = (int)((num2 * 1464887048) ^ 0x6012DC80);
					continue;
				case 80u:
					num = (int)((num2 * 1315208641) ^ 0x639D4ACC);
					continue;
				case 79u:
					num = ((int)num2 * -336403018) ^ 0x71E433AB;
					continue;
				case 78u:
					GForm2.smethod_13((Control)(object)PictureBox_3, new Point(268, 492));
					num = (int)(num2 * 451825697) ^ -198431638;
					continue;
				case 77u:
					GForm2.smethod_18(Timer_0, 1000);
					num = ((int)num2 * -2008301357) ^ 0x63B8364D;
					continue;
				case 76u:
					GForm2.smethod_11((Control)(object)PictureBox_0, Color.Transparent);
					num = ((int)num2 * -807434200) ^ 0x1E2C1A0A;
					continue;
				case 75u:
					GForm2.smethod_14((Control)(object)PictureBox_2, "PictureBox3");
					num = ((int)num2 * -676666717) ^ 0x6AF4D326;
					continue;
				case 74u:
					num = ((int)num2 * -4618767) ^ -1943919814;
					continue;
				case 73u:
					GForm2.smethod_34((Form)(object)this, "The Omegle Game");
					num = (int)((num2 * 1060919923) ^ 0x344C5877);
					continue;
				case 72u:
					GForm2.smethod_11((Control)(object)PictureBox_3, Color.Transparent);
					num = (int)((num2 * 1666958473) ^ 0x59E5866A);
					continue;
				case 71u:
					GForm2.smethod_21((ContainerControl)(object)this, new SizeF(10f, 22f));
					GForm2.smethod_22((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -1115593714) ^ -2026581895;
					continue;
				case 70u:
					GForm2.smethod_12((Control)(object)PictureBox_2, (ImageLayout)3);
					num = (int)(num2 * 70354352) ^ -670956154;
					continue;
				case 69u:
					GForm2.smethod_14((Control)(object)PictureBox_1, "PictureBox2");
					GForm2.smethod_15((Control)(object)PictureBox_1, new Size(504, 57));
					num = (int)(num2 * 703915568) ^ -1359872399;
					continue;
				case 68u:
					GForm2.smethod_9((ISupportInitialize)PictureBox_4);
					num = ((int)num2 * -1553017453) ^ 0x5874B899;
					continue;
				case 67u:
					GForm2.smethod_17(PictureBox_0, bool_1: false);
					num = ((int)num2 * -1912083802) ^ 0x43962CD0;
					continue;
				case 66u:
					GForm2.smethod_17(PictureBox_1, bool_1: false);
					num = (int)((num2 * 1305880177) ^ 0x439AE2F0);
					continue;
				case 65u:
					num = ((int)num2 * -587486502) ^ -1636137815;
					continue;
				case 64u:
					GForm2.smethod_13((Control)(object)PictureBox_1, new Point(268, 168));
					num = (int)((num2 * 755309473) ^ 0x55F1DD2A);
					continue;
				case 63u:
					num = ((int)num2 * -799595966) ^ -621509207;
					continue;
				case 62u:
					((Control)this).set_DoubleBuffered(true);
					GForm2.smethod_28((Control)(object)this, GForm2.smethod_27("Consolas", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
					GForm2.smethod_29((Form)(object)this, (FormBorderStyle)1);
					num = (int)((num2 * 1002273661) ^ 0x1E7DC3F4);
					continue;
				case 61u:
					GForm2.smethod_35((ISupportInitialize)PictureBox_1);
					GForm2.smethod_35((ISupportInitialize)PictureBox_2);
					num = (int)((num2 * 1992388311) ^ 0x513BA7C1);
					continue;
				case 60u:
					GForm2.smethod_36((Control)(object)this, bool_1: false);
					num = ((int)num2 * -1046776226) ^ 0x280DDCE5;
					continue;
				case 59u:
					icontainer_0 = GForm2.smethod_4();
					resourceManager_ = GForm2.smethod_6(GForm2.smethod_5(typeof(GForm2).TypeHandle));
					num = (int)(num2 * 1327498684) ^ -852242064;
					continue;
				case 58u:
					GForm2.smethod_12((Control)(object)PictureBox_4, (ImageLayout)3);
					GForm2.smethod_13((Control)(object)PictureBox_4, new Point(268, 555));
					num = ((int)num2 * -1415369731) ^ 0x6DDEBDEF;
					continue;
				case 57u:
					GForm2.smethod_12((Control)(object)PictureBox_1, (ImageLayout)3);
					num = (int)((num2 * 2015721669) ^ 0x356D77CE);
					continue;
				case 56u:
					GForm2.smethod_32((Control)(object)this, "SelectDuelType");
					GForm2.smethod_33((Form)(object)this, (FormStartPosition)1);
					num = ((int)num2 * -711621079) ^ -53021431;
					continue;
				case 55u:
					GForm2.smethod_9((ISupportInitialize)PictureBox_0);
					num = ((int)num2 * -1936808949) ^ -1949785231;
					continue;
				case 54u:
					Timer_0 = GForm2.smethod_8(icontainer_0);
					num = ((int)num2 * -1303905936) ^ -384572;
					continue;
				case 53u:
					GForm2.smethod_31((Form)(object)this, bool_1: false);
					num = ((int)num2 * -1668351907) ^ -1809502471;
					continue;
				case 52u:
					GForm2.smethod_13((Control)(object)PictureBox_0, new Point(214, 12));
					GForm2.smethod_14((Control)(object)PictureBox_0, "PictureBox1");
					num = ((int)num2 * -2135995798) ^ 0x13D5BB8E;
					continue;
				case 51u:
					num = (int)(num2 * 1650186286) ^ -863275718;
					continue;
				case 50u:
					GForm2.smethod_35((ISupportInitialize)PictureBox_0);
					num = (int)(num2 * 1025810518) ^ -1847721191;
					continue;
				case 49u:
					GForm2.smethod_24((Form)(object)this, new Size(1025, 638));
					num = (int)((num2 * 1770306104) ^ 0x27762B7C);
					continue;
				case 48u:
					num = ((int)num2 * -648417952) ^ -1832150635;
					continue;
				case 47u:
					GForm2.smethod_15((Control)(object)PictureBox_4, new Size(504, 57));
					num = ((int)num2 * -149392602) ^ 0x68D7BE3D;
					continue;
				case 46u:
					GForm2.smethod_11((Control)(object)PictureBox_1, Color.Transparent);
					num = (int)(num2 * 1814159826) ^ -311038526;
					continue;
				case 45u:
					PictureBox_1 = GForm2.smethod_7();
					num = (int)(num2 * 856405560) ^ -374905951;
					continue;
				case 44u:
					GForm2.smethod_15((Control)(object)PictureBox_3, new Size(504, 57));
					num = ((int)num2 * -1816684479) ^ 0x401874CC;
					continue;
				case 43u:
					num = ((int)num2 * -285712922) ^ 0xF9EDB61;
					continue;
				case 42u:
					GForm2.smethod_35((ISupportInitialize)PictureBox_3);
					GForm2.smethod_35((ISupportInitialize)PictureBox_4);
					num = ((int)num2 * -277751963) ^ 0x242F3277;
					continue;
				case 41u:
					PictureBox_0 = GForm2.smethod_7();
					num = (int)(num2 * 262674496) ^ -167103091;
					continue;
				case 40u:
					num = ((int)num2 * -1231933413) ^ 0x5F692057;
					continue;
				case 39u:
					num = (int)(num2 * 1679357256) ^ -746990667;
					continue;
				case 38u:
					GForm2.smethod_11((Control)(object)PictureBox_4, Color.Transparent);
					num = ((int)num2 * -124060417) ^ -2052919024;
					continue;
				case 37u:
					num = (int)((num2 * 977668622) ^ 0x596F34C2);
					continue;
				case 36u:
					GForm2.smethod_11((Control)(object)PictureBox_2, Color.Transparent);
					num = (int)(num2 * 490486638) ^ -1437675821;
					continue;
				case 35u:
					num = ((int)num2 * -1256798496) ^ -245496298;
					continue;
				case 34u:
					GForm2.smethod_14((Control)(object)PictureBox_3, "PictureBox4");
					num = (int)(num2 * 553846371) ^ -628557588;
					continue;
				case 33u:
					GForm2.smethod_16(PictureBox_3, 4);
					num = ((int)num2 * -1912730297) ^ -718236217;
					continue;
				case 32u:
					GForm2.smethod_12((Control)(object)PictureBox_0, (ImageLayout)3);
					num = (int)(num2 * 1789742697) ^ -1039297143;
					continue;
				case 31u:
					GForm2.smethod_17(PictureBox_4, bool_1: false);
					num = (int)((num2 * 1936192685) ^ 0x478E6770);
					continue;
				case 30u:
					GForm2.smethod_13((Control)(object)PictureBox_2, new Point(338, 306));
					num = ((int)num2 * -1110588742) ^ -409590057;
					continue;
				case 29u:
					num = ((int)num2 * -345170351) ^ -1462453820;
					continue;
				case 28u:
					GForm2.smethod_20((Control)(object)PictureBox_3, (Image)GForm2.smethod_19((ResourceManager)resourceManager_, "PictureBox4.BackgroundImage"));
					num = (int)((num2 * 1302844928) ^ 0x7E747F9);
					continue;
				case 26u:
					num = (int)(num2 * 1747274365) ^ -2101131777;
					continue;
				case 25u:
					num = ((int)num2 * -1801144077) ^ 0x6B80A8F2;
					continue;
				case 24u:
					num = ((int)num2 * -1408865861) ^ -1989021201;
					continue;
				case 23u:
					GForm2.smethod_12((Control)(object)this, (ImageLayout)3);
					num = (int)((num2 * 556643398) ^ 0x54DCC22F);
					continue;
				case 22u:
					GForm2.smethod_15((Control)(object)PictureBox_0, new Size(617, 69));
					num = ((int)num2 * -1799508238) ^ 0x36AC92E5;
					continue;
				case 21u:
					GForm2.smethod_16(PictureBox_0, 1);
					num = ((int)num2 * -10692275) ^ -148363287;
					continue;
				case 20u:
					GForm2.smethod_26(GForm2.smethod_25((Control)(object)this), (Control)(object)PictureBox_4);
					num = ((int)num2 * -425513080) ^ 0xA075AE3;
					continue;
				case 19u:
					num = (int)(num2 * 1876523680) ^ -1708962913;
					continue;
				case 18u:
					GForm2.smethod_20((Control)(object)PictureBox_4, (Image)GForm2.smethod_19((ResourceManager)resourceManager_, "PictureBox5.BackgroundImage"));
					num = ((int)num2 * -1713429278) ^ 0x5FDD6826;
					continue;
				case 17u:
					PictureBox_2 = GForm2.smethod_7();
					PictureBox_3 = GForm2.smethod_7();
					num = ((int)num2 * -1907515031) ^ -1325653362;
					continue;
				case 16u:
					GForm2.smethod_17(PictureBox_3, bool_1: false);
					num = (int)((num2 * 1971983769) ^ 0x20A2804A);
					continue;
				case 15u:
					num = (int)(num2 * 403072488) ^ -1576954812;
					continue;
				case 14u:
					GForm2.smethod_12((Control)(object)PictureBox_3, (ImageLayout)3);
					num = ((int)num2 * -169430418) ^ -651206588;
					continue;
				case 13u:
					PictureBox_4 = GForm2.smethod_7();
					num = (int)((num2 * 70196480) ^ 0x5EE66381);
					continue;
				case 12u:
					GForm2.smethod_17(PictureBox_2, bool_1: false);
					num = (int)(num2 * 1909601065) ^ -852785206;
					continue;
				case 11u:
					num = ((int)num2 * -1989153020) ^ 0x732A2F0A;
					continue;
				case 10u:
					GForm2.smethod_15((Control)(object)PictureBox_2, new Size(353, 42));
					num = (int)(num2 * 30400664) ^ -214596173;
					continue;
				case 9u:
					GForm2.smethod_10((Control)(object)this);
					num = ((int)num2 * -1146044751) ^ -1692101230;
					continue;
				case 8u:
					GForm2.smethod_14((Control)(object)PictureBox_4, "PictureBox5");
					num = (int)(num2 * 1811237201) ^ -1309907646;
					continue;
				case 7u:
					GForm2.smethod_9((ISupportInitialize)PictureBox_1);
					GForm2.smethod_9((ISupportInitialize)PictureBox_2);
					num = ((int)num2 * -591389243) ^ 0x70090E12;
					continue;
				case 5u:
					GForm2.smethod_16(PictureBox_4, 5);
					num = ((int)num2 * -687010836) ^ 0x6E30AAB;
					continue;
				case 4u:
					GForm2.smethod_26(GForm2.smethod_25((Control)(object)this), (Control)(object)PictureBox_3);
					GForm2.smethod_26(GForm2.smethod_25((Control)(object)this), (Control)(object)PictureBox_2);
					num = (int)(num2 * 1049221846) ^ -311520671;
					continue;
				case 3u:
					GForm2.smethod_26(GForm2.smethod_25((Control)(object)this), (Control)(object)PictureBox_1);
					num = (int)(num2 * 828956477) ^ -705182149;
					continue;
				case 2u:
					GForm2.smethod_26(GForm2.smethod_25((Control)(object)this), (Control)(object)PictureBox_0);
					num = ((int)num2 * -1183901711) ^ -777596925;
					continue;
				case 1u:
					GForm2.smethod_23((Form)(object)this, Color.White);
					num = (int)(num2 * 1205255293) ^ -423654959;
					continue;
				case 0u:
					num = (int)((num2 * 177591666) ^ 0x7B208CE5);
					continue;
				default:
					return;
				case 6u:
					break;
				case 27u:
					return;
				}
				break;
			}
		}
	}

	private void method_1(object sender, EventArgs e)
	{
		GForm2.smethod_46(GForm2.smethod_45(), ProcessPriorityClass.RealTime);
		while (true)
		{
			int num = -1672058930;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDFD3D0F7u) % 10u)
				{
				case 9u:
					GForm2.smethod_20((Control)(object)PictureBox_0, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\logo.png")));
					num = (int)((num2 * 2070209799) ^ 0x60558D5F);
					continue;
				case 7u:
					num = ((int)num2 * -1251890052) ^ 0x101CC33A;
					continue;
				case 6u:
					num = ((int)num2 * -661017381) ^ 0x5775232F;
					continue;
				case 5u:
					GForm2.smethod_20((Control)(object)this, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\main_menu.jpg")));
					num = ((int)num2 * -1200760805) ^ 0x3B73D66F;
					continue;
				case 4u:
					GForm2.smethod_50(Timer_0);
					num = ((int)num2 * -1443034520) ^ 0xF5C6823;
					continue;
				case 3u:
					GForm2.smethod_20((Control)(object)PictureBox_1, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\seleziona_una_modalita.png")));
					GForm2.smethod_20((Control)(object)PictureBox_2, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\con_la_cpu_hover.png")));
					GForm2.smethod_20((Control)(object)PictureBox_3, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\fai_un_duello.png")));
					num = (int)(num2 * 992017367) ^ -1111492757;
					continue;
				case 1u:
					GForm2.smethod_20((Control)(object)PictureBox_4, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\torna_indietro.png")));
					num = (int)((num2 * 1866671259) ^ 0x76BBEDEC);
					continue;
				case 0u:
					num = (int)(num2 * 884918402) ^ -1797713035;
					continue;
				default:
					return;
				case 2u:
					break;
				case 8u:
					return;
				}
				break;
			}
		}
	}

	private void method_2(object sender, EventArgs e)
	{
		GForm2.smethod_51();
	}

	private void method_3(object sender, KeyEventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -341169309;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA5B2AC99u) % 20u)
				{
				case 19u:
					num = (int)(num2 * 1294207567) ^ -1462937253;
					continue;
				case 18u:
				{
					int num9;
					if (int_0 == 1)
					{
						num = -1996850149;
						num9 = -1996850149;
					}
					else
					{
						num = -366381092;
						num9 = -366381092;
					}
					continue;
				}
				case 16u:
					GForm2.smethod_20((Control)(object)PictureBox_2, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\con_la_cpu_hover.png")));
					num = ((int)num2 * -691031730) ^ -149299470;
					continue;
				case 15u:
					int_0 = 0;
					num = ((int)num2 * -788816740) ^ -1458976740;
					continue;
				case 14u:
					int_0 = 1;
					num = (int)(num2 * 1870128037) ^ -816341345;
					continue;
				case 13u:
					num = -127973480;
					continue;
				case 12u:
					num = -1824565670;
					continue;
				case 11u:
				{
					int num7;
					int num8;
					if (int_0 != 0)
					{
						num7 = 655251520;
						num8 = 655251520;
					}
					else
					{
						num7 = 1959862366;
						num8 = 1959862366;
					}
					num = num7 ^ (int)(num2 * 462396803);
					continue;
				}
				case 10u:
					GForm2.smethod_20((Control)(object)PictureBox_2, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\con_gli_altri.png")));
					num = ((int)num2 * -1638466261) ^ 0x69F31C4A;
					continue;
				case 9u:
					num = ((int)num2 * -1869771545) ^ -1782186401;
					continue;
				case 8u:
					num = (int)((num2 * 479781940) ^ 0x4EE30AF9);
					continue;
				case 7u:
					num = ((int)num2 * -2047468579) ^ -813378752;
					continue;
				case 6u:
					num = (int)((num2 * 469910420) ^ 0x143C1774);
					continue;
				case 5u:
					num = ((int)num2 * -768222735) ^ -274341576;
					continue;
				case 4u:
					num = -485814520;
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = -144631662;
						num6 = -144631662;
					}
					else
					{
						num5 = -762075808;
						num6 = -762075808;
					}
					num = num5 ^ (int)(num2 * 1466811007);
					continue;
				}
				case 2u:
				{
					int num3;
					int num4;
					if ((GForm2.smethod_52(e) == 37) | (GForm2.smethod_52(e) == 39))
					{
						num3 = 1339586342;
						num4 = 1339586342;
					}
					else
					{
						num3 = 1144867220;
						num4 = 1144867220;
					}
					num = num3 ^ (int)(num2 * 1015064294);
					continue;
				}
				case 1u:
					flag = int_0 == 0;
					num = ((int)num2 * -515207678) ^ 0xB860784;
					continue;
				default:
					return;
				case 0u:
					break;
				case 17u:
					return;
				}
				break;
			}
		}
	}

	private void method_4(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 367050968;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x42434042u) % 3u)
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
				GForm2.smethod_20((Control)(object)PictureBox_3, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\fai_un_duello_hover.png")));
				num = ((int)num2 * -131761152) ^ -1340313215;
			}
		}
	}

	private void method_5(object sender, EventArgs e)
	{
		GForm2.smethod_20((Control)(object)PictureBox_3, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\fai_un_duello.png")));
	}

	private void method_6(object sender, EventArgs e)
	{
		GForm2.smethod_20((Control)(object)PictureBox_4, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\torna_indietro_hover.png")));
	}

	private void method_7(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -276764408;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA9F8516Du) % 3u)
				{
				case 1u:
					goto IL_0003;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0003:
				GForm2.smethod_20((Control)(object)PictureBox_4, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\torna_indietro.png")));
				num = (int)(num2 * 1481812496) ^ -610285213;
			}
		}
	}

	private void method_8(object sender, FormClosingEventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -1048681430;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x92C69471u) % 6u)
				{
				case 4u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 588341110;
						num4 = 588341110;
					}
					else
					{
						num3 = 970787493;
						num4 = 970787493;
					}
					num = num3 ^ ((int)num2 * -383943871);
					continue;
				}
				case 3u:
					num = -2121184469;
					continue;
				case 1u:
					method_9();
					flag = !bool_0;
					num = (int)(num2 * 127317610) ^ -107808491;
					continue;
				case 0u:
					GForm2.smethod_53((CancelEventArgs)(object)e, bool_1: true);
					num = ((int)num2 * -301582429) ^ 0x22CA41A6;
					continue;
				default:
					return;
				case 5u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	public void method_9()
	{
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Invalid comparison between Unknown and I4
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -1969367178;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF2818995u) % 23u)
				{
				case 22u:
					flag2 = !bool_0;
					num = ((int)num2 * -1971180034) ^ 0x6AF797BB;
					continue;
				case 21u:
					GForm2.smethod_51();
					num = (int)(num2 * 897828421) ^ -1889509151;
					continue;
				case 20u:
					GForm2.smethod_56((object)bool_0);
					num = ((int)num2 * -1024307650) ^ -462514189;
					continue;
				case 19u:
					GForm2.smethod_55(Timer_0);
					num = ((int)num2 * -1385447023) ^ 0x76CEDB03;
					continue;
				case 18u:
					num = ((int)num2 * -138045319) ^ 0x76C45D5E;
					continue;
				case 17u:
					GForm2.smethod_56((object)Timer_0);
					num = ((int)num2 * -1559341323) ^ 0x78D2118D;
					continue;
				case 16u:
					num = (int)((num2 * 934948288) ^ 0x7BD06A4B);
					continue;
				case 14u:
					num = (int)(num2 * 1107280332) ^ -490546833;
					continue;
				case 13u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = 1516112317;
						num6 = 1516112317;
					}
					else
					{
						num5 = 1178727513;
						num6 = 1178727513;
					}
					num = num5 ^ (int)(num2 * 1091610665);
					continue;
				}
				case 12u:
					num = (int)(num2 * 1174406296) ^ -1432831045;
					continue;
				case 11u:
				{
					int num3;
					int num4;
					if (flag2)
					{
						num3 = 2102195402;
						num4 = 2102195402;
					}
					else
					{
						num3 = 1203271952;
						num4 = 1203271952;
					}
					num = num3 ^ (int)(num2 * 1166534987);
					continue;
				}
				case 10u:
					num = -1397566548;
					continue;
				case 9u:
					GForm2.smethod_56((object)int_0);
					num = (int)((num2 * 755816901) ^ 0x3A3AE0D1);
					continue;
				case 8u:
					GForm2.smethod_56((object)bool_0);
					GForm2.smethod_51();
					num = (int)((num2 * 1146093629) ^ 0x39EA30F9);
					continue;
				case 6u:
					GForm2.smethod_56((object)Timer_0);
					GForm2.smethod_56((object)int_0);
					num = ((int)num2 * -1985625176) ^ 0x43A5AF5A;
					continue;
				case 5u:
					num = ((int)num2 * -553542613) ^ 0x5F15712E;
					continue;
				case 4u:
					num = ((int)num2 * -186953703) ^ -293863773;
					continue;
				case 3u:
					GForm2.smethod_57(GForm2.smethod_45());
					num = (int)(num2 * 815445303) ^ -157871970;
					continue;
				case 2u:
					GForm2.smethod_55(Timer_0);
					num = (int)((num2 * 529168782) ^ 0x11202C2);
					continue;
				case 1u:
					flag = (int)GForm2.smethod_54("Sei sicuro di voler uscire dal gioco?", "The Omegle Game", (MessageBoxButtons)4, (MessageBoxIcon)32) == 6;
					num = (int)(num2 * 1028921486) ^ -34776750;
					continue;
				case 0u:
					num = -1678102571;
					continue;
				default:
					return;
				case 15u:
					break;
				case 7u:
					return;
				}
				break;
			}
		}
	}

	private void method_10(object sender, MouseEventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		bool_0 = true;
		GForm2.smethod_54("Ci dispiace, ma la modalità duello non è attualmente disponibile.", "The Omegle Game", (MessageBoxButtons)0, (MessageBoxIcon)48);
	}

	private void method_11(object sender, MouseEventArgs e)
	{
		bool_0 = true;
		while (true)
		{
			int num = -1618047101;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDF326EF6u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -646945929) ^ 0x56A6F75;
					continue;
				case 1u:
					GForm2.smethod_58((Control)(object)Class2.Class3_0.GForm1_0);
					GForm2.smethod_59((Form)(object)this);
					num = (int)((num2 * 97183093) ^ 0x2A525140);
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
