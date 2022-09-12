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
				int num = -1396147244;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBE1CED28u) % 8u)
					{
					case 7u:
						GForm2.smethod_37(val, eventHandler_);
						num = (int)((num2 * 1426364361) ^ 0x368B158E);
						continue;
					case 6u:
						GForm2.smethod_38(val, eventHandler_);
						num = ((int)num2 * -458976538) ^ -726733609;
						continue;
					case 5u:
					{
						int num5;
						int num6;
						if (val != null)
						{
							num5 = 2081953443;
							num6 = 2081953443;
						}
						else
						{
							num5 = 1139288814;
							num6 = 1139288814;
						}
						num = num5 ^ ((int)num2 * -1427750751);
						continue;
					}
					case 4u:
						val = timer_0;
						num = (int)((num2 * 1115899627) ^ 0x43A54DDE);
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (val != null)
						{
							num3 = 13586015;
							num4 = 13586015;
						}
						else
						{
							num3 = 680567265;
							num4 = 680567265;
						}
						num = num3 ^ ((int)num2 * -1205701808);
						continue;
					}
					case 1u:
						timer_0 = value;
						val = timer_0;
						num = -1094333515;
						continue;
					default:
						return;
					case 0u:
						break;
					case 3u:
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
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			EventHandler eventHandler_ = method_4;
			EventHandler eventHandler_2 = method_5;
			MouseEventHandler mouseEventHandler_ = new MouseEventHandler(method_10);
			PictureBox val = pictureBox_3;
			while (true)
			{
				int num = -872440906;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xABA89293u) % 10u)
					{
					case 9u:
					{
						int num5;
						int num6;
						if (val != null)
						{
							num5 = 583511577;
							num6 = 583511577;
						}
						else
						{
							num5 = 1333049634;
							num6 = 1333049634;
						}
						num = num5 ^ (int)(num2 * 704323900);
						continue;
					}
					case 8u:
						GForm2.smethod_44((Control)(object)val, mouseEventHandler_);
						num = ((int)num2 * -848630354) ^ -1959215342;
						continue;
					case 7u:
					{
						int num3;
						int num4;
						if (val != null)
						{
							num3 = 1337953404;
							num4 = 1337953404;
						}
						else
						{
							num3 = 16717015;
							num4 = 16717015;
						}
						num = num3 ^ ((int)num2 * -900247643);
						continue;
					}
					case 6u:
						GForm2.smethod_40((Control)(object)val, eventHandler_2);
						num = ((int)num2 * -1721871401) ^ -656585199;
						continue;
					case 4u:
						GForm2.smethod_39((Control)(object)val, eventHandler_);
						num = (int)(num2 * 1425331018) ^ -928763489;
						continue;
					case 3u:
						pictureBox_3 = value;
						val = pictureBox_3;
						num = -966625058;
						continue;
					case 2u:
						GForm2.smethod_42((Control)(object)val, eventHandler_);
						GForm2.smethod_43((Control)(object)val, eventHandler_2);
						num = ((int)num2 * -2007775496) ^ -1315299427;
						continue;
					case 0u:
						GForm2.smethod_41((Control)(object)val, mouseEventHandler_);
						num = ((int)num2 * -703726519) ^ 0x16D945AC;
						continue;
					default:
						return;
					case 5u:
						break;
					case 1u:
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
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Expected O, but got Unknown
			EventHandler eventHandler_ = method_6;
			PictureBox val = default(PictureBox);
			EventHandler eventHandler_2 = default(EventHandler);
			MouseEventHandler mouseEventHandler_ = default(MouseEventHandler);
			while (true)
			{
				int num = -715919671;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFB07398Du) % 12u)
					{
					case 10u:
					{
						int num5;
						int num6;
						if (val == null)
						{
							num5 = 1707939625;
							num6 = 1707939625;
						}
						else
						{
							num5 = 456186560;
							num6 = 456186560;
						}
						num = num5 ^ (int)(num2 * 995076096);
						continue;
					}
					case 9u:
						GForm2.smethod_39((Control)(object)val, eventHandler_);
						num = ((int)num2 * -963685582) ^ -1344310368;
						continue;
					case 8u:
						eventHandler_2 = method_7;
						num = (int)(num2 * 1052377339) ^ -151832425;
						continue;
					case 6u:
						mouseEventHandler_ = new MouseEventHandler(method_11);
						val = pictureBox_4;
						num = ((int)num2 * -1365237486) ^ -1529943381;
						continue;
					case 5u:
						GForm2.smethod_44((Control)(object)val, mouseEventHandler_);
						num = (int)((num2 * 7437278) ^ 0x3401F56C);
						continue;
					case 4u:
					{
						val = pictureBox_4;
						int num3;
						int num4;
						if (val == null)
						{
							num3 = 687383274;
							num4 = 687383274;
						}
						else
						{
							num3 = 1667847148;
							num4 = 1667847148;
						}
						num = num3 ^ ((int)num2 * -1559904980);
						continue;
					}
					case 3u:
						GForm2.smethod_40((Control)(object)val, eventHandler_2);
						num = ((int)num2 * -1507413966) ^ 0x58A5CD09;
						continue;
					case 2u:
						GForm2.smethod_41((Control)(object)val, mouseEventHandler_);
						num = (int)(num2 * 1985083468) ^ -565801839;
						continue;
					case 1u:
						GForm2.smethod_42((Control)(object)val, eventHandler_);
						GForm2.smethod_43((Control)(object)val, eventHandler_2);
						num = (int)(num2 * 136657337) ^ -1052784631;
						continue;
					case 0u:
						pictureBox_4 = value;
						num = -1789572411;
						continue;
					default:
						return;
					case 7u:
						break;
					case 11u:
						return;
					}
					break;
				}
			}
		}
	}

	public GForm2()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		while (true)
		{
			int num = 1849601568;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD31E955u) % 9u)
				{
				case 8u:
					int_0 = 0;
					num = (int)(num2 * 757671660) ^ -374037729;
					continue;
				case 7u:
					GForm2.smethod_2((Form)(object)this, new FormClosingEventHandler(method_8));
					num = (int)(num2 * 2104575974) ^ -413933895;
					continue;
				case 6u:
					method_0();
					num = (int)(num2 * 2127813491) ^ -254400893;
					continue;
				case 4u:
					num = (int)((num2 * 701492418) ^ 0x376D0D8C);
					continue;
				case 3u:
					GForm2.smethod_0((Form)(object)this, (EventHandler)method_1);
					GForm2.smethod_1((Control)(object)this, new KeyEventHandler(method_3));
					num = ((int)num2 * -224312402) ^ -2058639716;
					continue;
				case 2u:
					num = (int)((num2 * 1355290808) ^ 0x636F5371);
					continue;
				case 1u:
					bool_0 = false;
					num = (int)((num2 * 1862490449) ^ 0x1D710170);
					continue;
				default:
					return;
				case 5u:
					break;
				case 0u:
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
				int num = -1467040556;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x97212441u) % 7u)
					{
					case 6u:
						if (icontainer_0 != null)
						{
							num = -610085677;
							num3 = -610085677;
							continue;
						}
						goto IL_001e;
					case 5u:
						num = ((int)num2 * -62618710) ^ -236601713;
						continue;
					case 3u:
						num = -1047039682;
						continue;
					case 2u:
						GForm2.smethod_3((IDisposable)icontainer_0);
						num = ((int)num2 * -370845575) ^ 0x2E3EC0E9;
						continue;
					case 1u:
						if (disposing)
						{
							num = (int)((num2 * 634832696) ^ 0xF2ACC2);
							continue;
						}
						goto IL_001e;
					default:
						return;
					case 4u:
						break;
					case 0u:
						return;
						IL_001e:
						num = -647190933;
						num3 = -647190933;
						continue;
					}
					break;
				}
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void method_0()
	{
		//IL_061b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0625: Expected O, but got Unknown
		//IL_0686: Unknown result type (might be due to invalid IL or missing references)
		//IL_0690: Expected O, but got Unknown
		//IL_07f1: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager resourceManager_ = default(ComponentResourceManager);
		while (true)
		{
			int num = 2081465903;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x60C47DB2u) % 81u)
				{
				case 80u:
					GForm2.smethod_15((Control)(object)PictureBox_0, new Size(617, 69));
					num = ((int)num2 * -94587891) ^ 0xCD36AD7;
					continue;
				case 79u:
					GForm2.smethod_17(PictureBox_4, bool_1: false);
					num = (int)((num2 * 426458926) ^ 0x2454ABAF);
					continue;
				case 78u:
					GForm2.smethod_18(Timer_0, 1000);
					GForm2.smethod_11((Control)(object)PictureBox_1, Color.Transparent);
					num = ((int)num2 * -1068273910) ^ -115905035;
					continue;
				case 76u:
					GForm2.smethod_17(PictureBox_2, bool_1: false);
					num = (int)(num2 * 1467425827) ^ -1271072504;
					continue;
				case 75u:
					GForm2.smethod_16(PictureBox_3, 4);
					num = (int)(num2 * 1509932711) ^ -610633764;
					continue;
				case 74u:
					GForm2.smethod_13((Control)(object)PictureBox_3, new Point(268, 492));
					num = (int)((num2 * 96815147) ^ 0x15E8B6FB);
					continue;
				case 73u:
					GForm2.smethod_15((Control)(object)PictureBox_3, new Size(504, 57));
					num = ((int)num2 * -2060055370) ^ -978108194;
					continue;
				case 72u:
					GForm2.smethod_35((ISupportInitialize)PictureBox_3);
					GForm2.smethod_35((ISupportInitialize)PictureBox_4);
					GForm2.smethod_36((Control)(object)this, bool_1: false);
					num = ((int)num2 * -85760378) ^ 0x6564AE4D;
					continue;
				case 71u:
					PictureBox_2 = GForm2.smethod_7();
					num = (int)(num2 * 1049410057) ^ -993468274;
					continue;
				case 70u:
					icontainer_0 = GForm2.smethod_4();
					resourceManager_ = GForm2.smethod_6(GForm2.smethod_5(typeof(GForm2).TypeHandle));
					num = (int)(num2 * 919348123) ^ -146545135;
					continue;
				case 69u:
					num = (int)((num2 * 1852865680) ^ 0x38A59DD7);
					continue;
				case 68u:
					GForm2.smethod_26(GForm2.smethod_25((Control)(object)this), (Control)(object)PictureBox_2);
					GForm2.smethod_26(GForm2.smethod_25((Control)(object)this), (Control)(object)PictureBox_1);
					num = ((int)num2 * -400384502) ^ 0x87168A8;
					continue;
				case 67u:
					GForm2.smethod_12((Control)(object)PictureBox_0, (ImageLayout)3);
					num = ((int)num2 * -393443729) ^ 0x45A54008;
					continue;
				case 66u:
					GForm2.smethod_17(PictureBox_3, bool_1: false);
					num = (int)((num2 * 793625536) ^ 0x5D024E48);
					continue;
				case 65u:
					GForm2.smethod_13((Control)(object)PictureBox_0, new Point(214, 12));
					num = (int)(num2 * 1790792246) ^ -808351812;
					continue;
				case 64u:
					num = (int)(num2 * 1447880282) ^ -352713818;
					continue;
				case 63u:
					GForm2.smethod_12((Control)(object)PictureBox_2, (ImageLayout)3);
					num = (int)(num2 * 1528676080) ^ -1787453912;
					continue;
				case 62u:
					GForm2.smethod_35((ISupportInitialize)PictureBox_0);
					num = (int)((num2 * 858064639) ^ 0x6B7872A1);
					continue;
				case 61u:
					num = ((int)num2 * -2005280609) ^ -1662933980;
					continue;
				case 60u:
					GForm2.smethod_9((ISupportInitialize)PictureBox_4);
					num = (int)((num2 * 898120615) ^ 0x2EB36213);
					continue;
				case 59u:
					PictureBox_0 = GForm2.smethod_7();
					Timer_0 = GForm2.smethod_8(icontainer_0);
					num = (int)(num2 * 119510610) ^ -1309601267;
					continue;
				case 58u:
					GForm2.smethod_21((ContainerControl)(object)this, new SizeF(10f, 22f));
					num = (int)(num2 * 1696181940) ^ -1818755372;
					continue;
				case 57u:
					GForm2.smethod_12((Control)(object)PictureBox_1, (ImageLayout)3);
					num = ((int)num2 * -1748266953) ^ -737787589;
					continue;
				case 56u:
					num = ((int)num2 * -313362166) ^ 0x4DE52FE8;
					continue;
				case 55u:
					num = (int)(num2 * 1594964027) ^ -1410226949;
					continue;
				case 54u:
					num = ((int)num2 * -1396643048) ^ -1581634569;
					continue;
				case 53u:
					GForm2.smethod_26(GForm2.smethod_25((Control)(object)this), (Control)(object)PictureBox_4);
					num = (int)(num2 * 1066273362) ^ -617392973;
					continue;
				case 52u:
					GForm2.smethod_15((Control)(object)PictureBox_2, new Size(353, 42));
					num = (int)(num2 * 192302497) ^ -1825093623;
					continue;
				case 51u:
					GForm2.smethod_16(PictureBox_2, 3);
					num = ((int)num2 * -1096069909) ^ -2060123252;
					continue;
				case 50u:
					num = (int)(num2 * 109925554) ^ -768210980;
					continue;
				case 49u:
					GForm2.smethod_15((Control)(object)PictureBox_4, new Size(504, 57));
					num = ((int)num2 * -186882334) ^ 0x633D40B1;
					continue;
				case 48u:
					GForm2.smethod_9((ISupportInitialize)PictureBox_0);
					GForm2.smethod_9((ISupportInitialize)PictureBox_1);
					num = ((int)num2 * -1945891243) ^ 0x1DFDE864;
					continue;
				case 47u:
					num = (int)((num2 * 73849640) ^ 0x55CD3DAD);
					continue;
				case 46u:
					GForm2.smethod_14((Control)(object)PictureBox_0, "PictureBox1");
					num = ((int)num2 * -1890479592) ^ -797765718;
					continue;
				case 45u:
					GForm2.smethod_13((Control)(object)PictureBox_1, new Point(268, 168));
					num = (int)(num2 * 205715730) ^ -1586164374;
					continue;
				case 44u:
					GForm2.smethod_13((Control)(object)PictureBox_4, new Point(268, 555));
					GForm2.smethod_14((Control)(object)PictureBox_4, "PictureBox5");
					num = (int)(num2 * 42349015) ^ -1465978817;
					continue;
				case 43u:
					num = ((int)num2 * -112425775) ^ -1793567653;
					continue;
				case 42u:
					GForm2.smethod_10((Control)(object)this);
					GForm2.smethod_11((Control)(object)PictureBox_0, Color.Transparent);
					num = ((int)num2 * -948220427) ^ -1518633942;
					continue;
				case 41u:
					num = ((int)num2 * -189688443) ^ -630909638;
					continue;
				case 40u:
					GForm2.smethod_35((ISupportInitialize)PictureBox_1);
					num = (int)(num2 * 1433287308) ^ -1512326512;
					continue;
				case 39u:
					GForm2.smethod_14((Control)(object)PictureBox_1, "PictureBox2");
					num = ((int)num2 * -1944736848) ^ 0x3EB6B70;
					continue;
				case 38u:
					PictureBox_1 = GForm2.smethod_7();
					num = ((int)num2 * -222795163) ^ -756316980;
					continue;
				case 37u:
					GForm2.smethod_28((Control)(object)this, GForm2.smethod_27("Consolas", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
					GForm2.smethod_29((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -1641669352) ^ -884016760;
					continue;
				case 36u:
					GForm2.smethod_17(PictureBox_0, bool_1: false);
					num = (int)(num2 * 554908000) ^ -984003913;
					continue;
				case 35u:
					GForm2.smethod_26(GForm2.smethod_25((Control)(object)this), (Control)(object)PictureBox_3);
					num = ((int)num2 * -650302984) ^ 0x33B6E386;
					continue;
				case 34u:
					GForm2.smethod_17(PictureBox_1, bool_1: false);
					num = ((int)num2 * -32963590) ^ 0x6E446F52;
					continue;
				case 33u:
					GForm2.smethod_11((Control)(object)PictureBox_4, Color.Transparent);
					GForm2.smethod_20((Control)(object)PictureBox_4, (Image)GForm2.smethod_19((ResourceManager)resourceManager_, "PictureBox5.BackgroundImage"));
					num = ((int)num2 * -2061380764) ^ 0x313E0D59;
					continue;
				case 32u:
					num = ((int)num2 * -1044518743) ^ 0x37D2A029;
					continue;
				case 31u:
					GForm2.smethod_13((Control)(object)PictureBox_2, new Point(338, 306));
					num = (int)(num2 * 798865333) ^ -874670338;
					continue;
				case 30u:
					GForm2.smethod_20((Control)(object)PictureBox_3, (Image)GForm2.smethod_19((ResourceManager)resourceManager_, "PictureBox4.BackgroundImage"));
					num = (int)((num2 * 1689835182) ^ 0x2EEE0B12);
					continue;
				case 29u:
					GForm2.smethod_11((Control)(object)PictureBox_3, Color.Transparent);
					num = ((int)num2 * -2058428886) ^ 0xBCCC119;
					continue;
				case 28u:
					num = ((int)num2 * -1865926448) ^ -1455951645;
					continue;
				case 27u:
					GForm2.smethod_34((Form)(object)this, "The Omegle Game");
					num = ((int)num2 * -1307839195) ^ -999753329;
					continue;
				case 26u:
					GForm2.smethod_12((Control)(object)this, (ImageLayout)3);
					num = (int)(num2 * 1290194526) ^ -989414655;
					continue;
				case 24u:
					GForm2.smethod_15((Control)(object)PictureBox_1, new Size(504, 57));
					num = ((int)num2 * -15878741) ^ 0x5C7DCEFA;
					continue;
				case 23u:
					GForm2.smethod_16(PictureBox_4, 5);
					num = ((int)num2 * -299879320) ^ 0x7C9A1CCA;
					continue;
				case 22u:
					num = ((int)num2 * -325488666) ^ 0xD59F0F4;
					continue;
				case 21u:
					num = ((int)num2 * -764494575) ^ -257631041;
					continue;
				case 20u:
					GForm2.smethod_24((Form)(object)this, new Size(1025, 638));
					num = (int)(num2 * 1858599081) ^ -1561484947;
					continue;
				case 19u:
					GForm2.smethod_35((ISupportInitialize)PictureBox_2);
					num = ((int)num2 * -1543546267) ^ 0x3F30D79D;
					continue;
				case 18u:
					GForm2.smethod_14((Control)(object)PictureBox_3, "PictureBox4");
					num = (int)((num2 * 41686040) ^ 0x43D9DDEE);
					continue;
				case 17u:
					num = ((int)num2 * -1100545223) ^ -777205094;
					continue;
				case 16u:
					GForm2.smethod_30((Form)(object)this, new Padding(4));
					GForm2.smethod_31((Form)(object)this, bool_1: false);
					GForm2.smethod_32((Control)(object)this, "SelectDuelType");
					GForm2.smethod_33((Form)(object)this, (FormStartPosition)1);
					num = ((int)num2 * -129634255) ^ 0x3204AB23;
					continue;
				case 15u:
					num = ((int)num2 * -88317988) ^ -17564263;
					continue;
				case 14u:
					GForm2.smethod_26(GForm2.smethod_25((Control)(object)this), (Control)(object)PictureBox_0);
					((Control)this).set_DoubleBuffered(true);
					num = ((int)num2 * -2114602670) ^ -325783469;
					continue;
				case 13u:
					GForm2.smethod_16(PictureBox_1, 2);
					num = (int)(num2 * 132446634) ^ -505930469;
					continue;
				case 12u:
					num = (int)((num2 * 1754129667) ^ 0x24D07487);
					continue;
				case 11u:
					num = ((int)num2 * -1510563064) ^ -738359060;
					continue;
				case 10u:
					GForm2.smethod_11((Control)(object)PictureBox_2, Color.Transparent);
					num = (int)((num2 * 225334417) ^ 0x7892CE95);
					continue;
				case 9u:
					num = (int)((num2 * 1092495552) ^ 0x59D59B56);
					continue;
				case 8u:
					num = ((int)num2 * -1916975836) ^ 0x7BD96953;
					continue;
				case 7u:
					PictureBox_3 = GForm2.smethod_7();
					PictureBox_4 = GForm2.smethod_7();
					num = ((int)num2 * -1521716463) ^ 0x3D51BDE6;
					continue;
				case 6u:
					GForm2.smethod_22((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 1422901979) ^ -203162352;
					continue;
				case 5u:
					GForm2.smethod_16(PictureBox_0, 1);
					num = (int)((num2 * 1799258371) ^ 0x10AC06AA);
					continue;
				case 4u:
					GForm2.smethod_12((Control)(object)PictureBox_4, (ImageLayout)3);
					num = ((int)num2 * -1397695851) ^ 0x1BE37CE1;
					continue;
				case 3u:
					GForm2.smethod_12((Control)(object)PictureBox_3, (ImageLayout)3);
					num = (int)(num2 * 1845921929) ^ -118755847;
					continue;
				case 2u:
					GForm2.smethod_9((ISupportInitialize)PictureBox_2);
					GForm2.smethod_9((ISupportInitialize)PictureBox_3);
					num = (int)(num2 * 571092977) ^ -1731378730;
					continue;
				case 1u:
					GForm2.smethod_23((Form)(object)this, Color.White);
					num = ((int)num2 * -1873855247) ^ -1682605936;
					continue;
				case 0u:
					GForm2.smethod_14((Control)(object)PictureBox_2, "PictureBox3");
					num = ((int)num2 * -1409621756) ^ 0x244EF785;
					continue;
				default:
					return;
				case 25u:
					break;
				case 77u:
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
			int num = -1716330151;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC17AEC6Fu) % 9u)
				{
				case 8u:
					GForm2.smethod_20((Control)(object)PictureBox_1, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\seleziona_una_modalita.png")));
					GForm2.smethod_20((Control)(object)PictureBox_2, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\con_la_cpu_hover.png")));
					num = ((int)num2 * -1051133746) ^ -423572409;
					continue;
				case 7u:
					GForm2.smethod_20((Control)(object)PictureBox_3, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\fai_un_duello.png")));
					num = (int)(num2 * 1874968876) ^ -1759826378;
					continue;
				case 6u:
					GForm2.smethod_50(Timer_0);
					num = (int)((num2 * 838265076) ^ 0x3EA8B451);
					continue;
				case 5u:
					GForm2.smethod_20((Control)(object)PictureBox_4, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\torna_indietro.png")));
					num = ((int)num2 * -652996160) ^ -1193828852;
					continue;
				case 4u:
					num = ((int)num2 * -790437956) ^ 0x39BF0B3B;
					continue;
				case 3u:
					num = (int)((num2 * 1167346848) ^ 0x35F90F8D);
					continue;
				case 1u:
					GForm2.smethod_20((Control)(object)this, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\main_menu.jpg")));
					GForm2.smethod_20((Control)(object)PictureBox_0, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\logo.png")));
					num = (int)(num2 * 564948366) ^ -1024243673;
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

	private void method_2(object sender, EventArgs e)
	{
		GForm2.smethod_51();
		while (true)
		{
			int num = -2126778959;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x946B88C3u) % 3u)
				{
				case 1u:
					goto IL_0007;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0007:
				num = (int)((num2 * 202486136) ^ 0x546C059A);
			}
		}
	}

	private void method_3(object sender, KeyEventArgs e)
	{
		bool flag = (GForm2.smethod_52(e) == 37) | (GForm2.smethod_52(e) == 39);
		bool flag4 = default(bool);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -1314350710;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x95F23D83u) % 21u)
				{
				case 20u:
				{
					int num9;
					int num10;
					if (flag)
					{
						num9 = -545322370;
						num10 = -545322370;
					}
					else
					{
						num9 = -137801561;
						num10 = -137801561;
					}
					num = num9 ^ (int)(num2 * 51030693);
					continue;
				}
				case 19u:
					num = (int)(num2 * 184750561) ^ -684721558;
					continue;
				case 18u:
					num = ((int)num2 * -348660112) ^ 0x4B72BFCE;
					continue;
				case 17u:
					int_0 = 1;
					num = ((int)num2 * -926933552) ^ -502857829;
					continue;
				case 16u:
					num = (int)((num2 * 948891489) ^ 0x4DA37650);
					continue;
				case 15u:
					flag4 = int_0 == 1;
					num = -445541720;
					continue;
				case 14u:
					flag3 = int_0 == 0;
					num = ((int)num2 * -1272384135) ^ -1795397547;
					continue;
				case 13u:
					flag2 = int_0 == 0;
					num = ((int)num2 * -1705114635) ^ 0x3D4E8EDF;
					continue;
				case 12u:
				{
					int num7;
					int num8;
					if (flag3)
					{
						num7 = -756069782;
						num8 = -756069782;
					}
					else
					{
						num7 = -2059484217;
						num8 = -2059484217;
					}
					num = num7 ^ (int)(num2 * 664931270);
					continue;
				}
				case 11u:
				{
					int num5;
					int num6;
					if (flag4)
					{
						num5 = -1480714834;
						num6 = -1480714834;
					}
					else
					{
						num5 = -132944579;
						num6 = -132944579;
					}
					num = num5 ^ ((int)num2 * -561993050);
					continue;
				}
				case 10u:
					GForm2.smethod_20((Control)(object)PictureBox_2, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\con_gli_altri.png")));
					num = ((int)num2 * -1341527007) ^ -2043559035;
					continue;
				case 9u:
					int_0 = 0;
					num = (int)(num2 * 554791321) ^ -223998879;
					continue;
				case 8u:
					GForm2.smethod_20((Control)(object)PictureBox_2, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\con_la_cpu_hover.png")));
					num = (int)((num2 * 1849413721) ^ 0x36BC230D);
					continue;
				case 7u:
					num = -1301751009;
					continue;
				case 6u:
					num = -713366678;
					continue;
				case 5u:
					num = ((int)num2 * -1811782303) ^ 0x3B387AD6;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (!flag2)
					{
						num3 = 580666035;
						num4 = 580666035;
					}
					else
					{
						num3 = 349726640;
						num4 = 349726640;
					}
					num = num3 ^ (int)(num2 * 440675872);
					continue;
				}
				case 1u:
					num = -86242984;
					continue;
				case 0u:
					num = (int)(num2 * 1007021129) ^ -383442001;
					continue;
				default:
					return;
				case 4u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	private void method_4(object sender, EventArgs e)
	{
		GForm2.smethod_20((Control)(object)PictureBox_3, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\fai_un_duello_hover.png")));
	}

	private void method_5(object sender, EventArgs e)
	{
		GForm2.smethod_20((Control)(object)PictureBox_3, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\fai_un_duello.png")));
	}

	private void method_6(object sender, EventArgs e)
	{
		GForm2.smethod_20((Control)(object)PictureBox_4, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\torna_indietro_hover.png")));
		while (true)
		{
			int num = -2010868157;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCB94FAB1u) % 3u)
				{
				case 2u:
					goto IL_0021;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0021:
				num = (int)(num2 * 71735303) ^ -1659966955;
			}
		}
	}

	private void method_7(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -1569216955;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB0D77AC1u) % 3u)
				{
				case 2u:
					goto IL_0003;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0003:
				GForm2.smethod_20((Control)(object)PictureBox_4, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\torna_indietro.png")));
				num = ((int)num2 * -1245713694) ^ -696758714;
			}
		}
	}

	private void method_8(object sender, FormClosingEventArgs e)
	{
		method_9();
		bool flag = default(bool);
		while (true)
		{
			int num = 2076791872;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x47768FD8u) % 9u)
				{
				case 8u:
					GForm2.smethod_53((CancelEventArgs)(object)e, bool_1: true);
					num = (int)(num2 * 1783239122) ^ -840571582;
					continue;
				case 7u:
					num = 566076634;
					continue;
				case 6u:
					flag = !bool_0;
					num = ((int)num2 * -37094918) ^ 0x1D8399A0;
					continue;
				case 4u:
					num = (int)((num2 * 1100914579) ^ 0x746FA128);
					continue;
				case 3u:
					num = (int)(num2 * 36127468) ^ -31954189;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -189686813;
						num4 = -189686813;
					}
					else
					{
						num3 = -573645098;
						num4 = -573645098;
					}
					num = num3 ^ (int)(num2 * 922788162);
					continue;
				}
				case 0u:
					num = (int)((num2 * 976410668) ^ 0x17791462);
					continue;
				default:
					return;
				case 2u:
					break;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	public void method_9()
	{
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Invalid comparison between Unknown and I4
		bool flag = !bool_0;
		bool flag2 = default(bool);
		while (true)
		{
			int num = -690231263;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA3F2873Cu) % 23u)
				{
				case 22u:
					GForm2.smethod_55(Timer_0);
					num = ((int)num2 * -319217243) ^ -1346879383;
					continue;
				case 21u:
					GForm2.smethod_57(GForm2.smethod_45());
					num = (int)((num2 * 527929471) ^ 0x3734482B);
					continue;
				case 20u:
					num = ((int)num2 * -1508642245) ^ 0x77AAB0B6;
					continue;
				case 19u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = -1609501339;
						num6 = -1609501339;
					}
					else
					{
						num5 = -1932063245;
						num6 = -1932063245;
					}
					num = num5 ^ ((int)num2 * -1314311706);
					continue;
				}
				case 18u:
					GForm2.smethod_51();
					num = ((int)num2 * -971809912) ^ -1882928011;
					continue;
				case 17u:
					GForm2.smethod_56((object)Timer_0);
					num = (int)((num2 * 142515079) ^ 0x48169137);
					continue;
				case 16u:
					flag2 = (int)GForm2.smethod_54("Sei sicuro di voler uscire dal gioco?", "The Omegle Game", (MessageBoxButtons)4, (MessageBoxIcon)32) == 6;
					num = ((int)num2 * -17182303) ^ 0x5BD0A1D6;
					continue;
				case 15u:
					GForm2.smethod_55(Timer_0);
					num = (int)(num2 * 1020595613) ^ -890131220;
					continue;
				case 14u:
					num = ((int)num2 * -95741138) ^ -1141784173;
					continue;
				case 13u:
					num = (int)((num2 * 577102872) ^ 0x74A0BB9F);
					continue;
				case 12u:
					num = (int)(num2 * 891804522) ^ -1080208341;
					continue;
				case 11u:
					GForm2.smethod_56((object)int_0);
					GForm2.smethod_56((object)bool_0);
					num = ((int)num2 * -2144516531) ^ -483531019;
					continue;
				case 10u:
					GForm2.smethod_56((object)bool_0);
					num = ((int)num2 * -647319012) ^ 0xAAB4DC6;
					continue;
				case 9u:
					GForm2.smethod_51();
					num = (int)(num2 * 1135669550) ^ -755790265;
					continue;
				case 8u:
					num = ((int)num2 * -266873949) ^ 0x51C6D58B;
					continue;
				case 6u:
					num = (int)(num2 * 410838033) ^ -1158618787;
					continue;
				case 5u:
					num = -366295129;
					continue;
				case 4u:
					GForm2.smethod_56((object)int_0);
					num = ((int)num2 * -1205355016) ^ 0x70529186;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 850916996;
						num4 = 850916996;
					}
					else
					{
						num3 = 1425423999;
						num4 = 1425423999;
					}
					num = num3 ^ ((int)num2 * -1388839151);
					continue;
				}
				case 2u:
					GForm2.smethod_56((object)Timer_0);
					num = ((int)num2 * -724519111) ^ -1699304498;
					continue;
				case 1u:
					num = -1367417326;
					continue;
				default:
					return;
				case 0u:
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
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			int num = 276734748;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x74412B49u) % 4u)
				{
				case 1u:
					bool_0 = true;
					num = ((int)num2 * -555183736) ^ -2103281527;
					continue;
				case 0u:
					GForm2.smethod_54("Ci dispiace, ma la modalità duello non è attualmente disponibile.", "The Omegle Game", (MessageBoxButtons)0, (MessageBoxIcon)48);
					num = ((int)num2 * -740133266) ^ -1633312194;
					continue;
				default:
					return;
				case 2u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	private void method_11(object sender, MouseEventArgs e)
	{
		bool_0 = true;
		while (true)
		{
			int num = 1417539823;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6D3DCD03u) % 3u)
				{
				case 1u:
					goto IL_0009;
				case 0u:
					break;
				default:
					GForm2.smethod_59((Form)(object)this);
					return;
				}
				break;
				IL_0009:
				GForm2.smethod_58((Control)(object)Class2.Class3_0.GForm1_0);
				num = ((int)num2 * -1564155486) ^ 0x75092A3B;
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
