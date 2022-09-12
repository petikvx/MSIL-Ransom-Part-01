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
				int num = 1019971711;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6C0998C9u) % 9u)
					{
					case 8u:
					{
						int num5;
						int num6;
						if (val == null)
						{
							num5 = 652518513;
							num6 = 652518513;
						}
						else
						{
							num5 = 1442773970;
							num6 = 1442773970;
						}
						num = num5 ^ (int)(num2 * 295328422);
						continue;
					}
					case 7u:
						val = timer_0;
						num = ((int)num2 * -142131988) ^ 0x12F5FD75;
						continue;
					case 6u:
					{
						int num3;
						int num4;
						if (val != null)
						{
							num3 = 66269719;
							num4 = 66269719;
						}
						else
						{
							num3 = 1819964451;
							num4 = 1819964451;
						}
						num = num3 ^ ((int)num2 * -994910361);
						continue;
					}
					case 5u:
						GForm2.smethod_37(val, eventHandler_);
						num = (int)((num2 * 57196233) ^ 0x40578842);
						continue;
					case 4u:
						timer_0 = value;
						num = 173395942;
						continue;
					case 2u:
						GForm2.smethod_38(val, eventHandler_);
						num = ((int)num2 * -2109708956) ^ -1635554013;
						continue;
					case 1u:
						val = timer_0;
						num = ((int)num2 * -656957235) ^ -902313897;
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
			//IL_0131: Unknown result type (might be due to invalid IL or missing references)
			//IL_0137: Expected O, but got Unknown
			EventHandler eventHandler_ = method_4;
			PictureBox val = default(PictureBox);
			EventHandler eventHandler_2 = default(EventHandler);
			MouseEventHandler mouseEventHandler_ = default(MouseEventHandler);
			while (true)
			{
				int num = 1432904307;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x68A0D62Eu) % 13u)
					{
					case 12u:
						val = pictureBox_3;
						num = ((int)num2 * -758419969) ^ 0xF61DED2;
						continue;
					case 11u:
						pictureBox_3 = value;
						num = 985800502;
						continue;
					case 10u:
						GForm2.smethod_40((Control)(object)val, eventHandler_2);
						GForm2.smethod_41((Control)(object)val, mouseEventHandler_);
						num = (int)(num2 * 1928083123) ^ -111974100;
						continue;
					case 8u:
						eventHandler_2 = method_5;
						num = (int)(num2 * 804963220) ^ -1967027123;
						continue;
					case 7u:
						GForm2.smethod_43((Control)(object)val, eventHandler_2);
						num = (int)(num2 * 350875313) ^ -372088308;
						continue;
					case 6u:
					{
						int num5;
						int num6;
						if (val == null)
						{
							num5 = 603818546;
							num6 = 603818546;
						}
						else
						{
							num5 = 2099728676;
							num6 = 2099728676;
						}
						num = num5 ^ (int)(num2 * 1159570582);
						continue;
					}
					case 5u:
						GForm2.smethod_42((Control)(object)val, eventHandler_);
						num = (int)(num2 * 1078931101) ^ -1705457017;
						continue;
					case 3u:
						GForm2.smethod_39((Control)(object)val, eventHandler_);
						num = (int)(num2 * 1393455827) ^ -588935102;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (val != null)
						{
							num3 = -322327450;
							num4 = -322327450;
						}
						else
						{
							num3 = -1302023848;
							num4 = -1302023848;
						}
						num = num3 ^ ((int)num2 * -73684599);
						continue;
					}
					case 1u:
						GForm2.smethod_44((Control)(object)val, mouseEventHandler_);
						num = ((int)num2 * -439820695) ^ 0x2E1D2613;
						continue;
					case 0u:
						mouseEventHandler_ = new MouseEventHandler(method_10);
						val = pictureBox_3;
						num = (int)(num2 * 673662118) ^ -503364450;
						continue;
					default:
						return;
					case 9u:
						break;
					case 4u:
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
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Expected O, but got Unknown
			EventHandler eventHandler_ = method_6;
			EventHandler eventHandler_2 = default(EventHandler);
			MouseEventHandler mouseEventHandler_ = default(MouseEventHandler);
			PictureBox val = default(PictureBox);
			while (true)
			{
				int num = -1382099576;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xABBE4623u) % 12u)
					{
					case 11u:
						eventHandler_2 = method_7;
						num = (int)((num2 * 1083473633) ^ 0x4815903A);
						continue;
					case 10u:
						mouseEventHandler_ = new MouseEventHandler(method_11);
						num = ((int)num2 * -194235276) ^ 0x3DEE94D5;
						continue;
					case 8u:
						GForm2.smethod_41((Control)(object)val, mouseEventHandler_);
						num = ((int)num2 * -715380306) ^ 0x77C747D1;
						continue;
					case 6u:
						pictureBox_4 = value;
						num = -94251170;
						continue;
					case 5u:
					{
						int num5;
						int num6;
						if (val != null)
						{
							num5 = -947168030;
							num6 = -947168030;
						}
						else
						{
							num5 = -1268156042;
							num6 = -1268156042;
						}
						num = num5 ^ ((int)num2 * -223141670);
						continue;
					}
					case 4u:
						GForm2.smethod_39((Control)(object)val, eventHandler_);
						num = (int)(num2 * 1503540183) ^ -2119524045;
						continue;
					case 3u:
						GForm2.smethod_42((Control)(object)val, eventHandler_);
						GForm2.smethod_43((Control)(object)val, eventHandler_2);
						GForm2.smethod_44((Control)(object)val, mouseEventHandler_);
						num = (int)((num2 * 1037261171) ^ 0xA3DCAED);
						continue;
					case 2u:
					{
						val = pictureBox_4;
						int num3;
						int num4;
						if (val == null)
						{
							num3 = -314823573;
							num4 = -314823573;
						}
						else
						{
							num3 = -463773475;
							num4 = -463773475;
						}
						num = num3 ^ ((int)num2 * -655237593);
						continue;
					}
					case 1u:
						val = pictureBox_4;
						num = (int)((num2 * 1178139388) ^ 0x2782ED2A);
						continue;
					case 0u:
						GForm2.smethod_40((Control)(object)val, eventHandler_2);
						num = ((int)num2 * -240372637) ^ 0x553C6D63;
						continue;
					default:
						return;
					case 9u:
						break;
					case 7u:
						return;
					}
					break;
				}
			}
		}
	}

	public GForm2()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		while (true)
		{
			int num = -1813113460;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA72142C6u) % 9u)
				{
				case 8u:
					GForm2.smethod_2((Form)(object)this, new FormClosingEventHandler(method_8));
					num = ((int)num2 * -862226257) ^ -775781455;
					continue;
				case 6u:
					GForm2.smethod_0((Form)(object)this, (EventHandler)method_1);
					num = ((int)num2 * -1736818999) ^ -527315464;
					continue;
				case 4u:
					num = (int)((num2 * 1412384843) ^ 0x88148FA);
					continue;
				case 3u:
					int_0 = 0;
					num = ((int)num2 * -987360305) ^ 0x68346926;
					continue;
				case 2u:
					bool_0 = false;
					method_0();
					num = (int)(num2 * 537688453) ^ -1639684258;
					continue;
				case 1u:
					GForm2.smethod_1((Control)(object)this, new KeyEventHandler(method_3));
					num = ((int)num2 * -2013386410) ^ -1226393943;
					continue;
				case 0u:
					num = ((int)num2 * -1167004888) ^ 0x27B77C4C;
					continue;
				default:
					return;
				case 5u:
					break;
				case 7u:
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
			if (!disposing)
			{
				goto IL_000a;
			}
			goto IL_0031;
			IL_0031:
			int num = 1575312070;
			goto IL_004c;
			IL_004c:
			int num3;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x59CA8026u) % 6u)
				{
				case 5u:
					GForm2.smethod_3((IDisposable)icontainer_0);
					num = ((int)num2 * -1153431233) ^ 0x34B7AD85;
					continue;
				case 3u:
					break;
				case 2u:
					num = (int)(num2 * 410883355) ^ -1515207525;
					continue;
				case 1u:
					num = 346815610;
					continue;
				default:
					return;
				case 4u:
					goto IL_0075;
				case 0u:
					return;
				}
				break;
				IL_0075:
				if (icontainer_0 != null)
				{
					num = 359374533;
					num3 = 359374533;
					continue;
				}
				goto IL_000a;
			}
			goto IL_0031;
			IL_000a:
			num = 470098641;
			num3 = 470098641;
			goto IL_004c;
		}
		finally
		{
			while (true)
			{
				IL_00dc:
				int num4 = 1339434027;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num4 ^ 0x59CA8026u) % 4u)
					{
					case 1u:
						((Form)this).Dispose(disposing);
						num4 = ((int)num2 * -1062921555) ^ 0x4468B56B;
						continue;
					case 0u:
						num4 = (int)(num2 * 669488472) ^ -1956794411;
						continue;
					default:
						goto end_IL_00bb;
					case 2u:
						break;
					case 3u:
						goto end_IL_00bb;
					}
					goto IL_00dc;
					continue;
					end_IL_00bb:
					break;
				}
				break;
			}
		}
	}

	[DebuggerStepThrough]
	private void method_0()
	{
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0505: Expected O, but got Unknown
		//IL_08f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fe: Expected O, but got Unknown
		ComponentResourceManager resourceManager_ = default(ComponentResourceManager);
		while (true)
		{
			int num = 263038770;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x43E8705Du) % 90u)
				{
				case 89u:
					num = (int)(num2 * 1046429204) ^ -352970115;
					continue;
				case 88u:
					GForm2.smethod_11((Control)(object)PictureBox_0, Color.Transparent);
					num = ((int)num2 * -997259641) ^ -1223506656;
					continue;
				case 87u:
					GForm2.smethod_15((Control)(object)PictureBox_1, new Size(504, 57));
					num = (int)((num2 * 1720012291) ^ 0x347D3C94);
					continue;
				case 85u:
					GForm2.smethod_12((Control)(object)PictureBox_0, (ImageLayout)3);
					num = (int)(num2 * 1323507863) ^ -1558411486;
					continue;
				case 84u:
					GForm2.smethod_13((Control)(object)PictureBox_4, new Point(268, 555));
					num = ((int)num2 * -1618507602) ^ 0x58A65418;
					continue;
				case 83u:
					GForm2.smethod_9((ISupportInitialize)PictureBox_0);
					num = ((int)num2 * -1226519704) ^ 0x44C58A87;
					continue;
				case 82u:
					num = (int)((num2 * 1003659348) ^ 0x459DF0AC);
					continue;
				case 81u:
					icontainer_0 = GForm2.smethod_4();
					resourceManager_ = GForm2.smethod_6(GForm2.smethod_5(typeof(GForm2).TypeHandle));
					PictureBox_0 = GForm2.smethod_7();
					num = ((int)num2 * -2117737074) ^ 0x2317307E;
					continue;
				case 80u:
					GForm2.smethod_11((Control)(object)PictureBox_2, Color.Transparent);
					num = ((int)num2 * -2077510699) ^ 0x1A7FEECE;
					continue;
				case 79u:
					num = (int)((num2 * 1933039379) ^ 0x5B9EB795);
					continue;
				case 78u:
					GForm2.smethod_14((Control)(object)PictureBox_1, "PictureBox2");
					num = (int)((num2 * 88153739) ^ 0x2F9995E0);
					continue;
				case 77u:
					GForm2.smethod_21((ContainerControl)(object)this, new SizeF(10f, 22f));
					num = ((int)num2 * -2048310563) ^ 0x2B680591;
					continue;
				case 76u:
					GForm2.smethod_16(PictureBox_0, 1);
					num = (int)(num2 * 1345798150) ^ -1939923208;
					continue;
				case 75u:
					GForm2.smethod_12((Control)(object)this, (ImageLayout)3);
					num = ((int)num2 * -155201572) ^ -1733377277;
					continue;
				case 74u:
					PictureBox_1 = GForm2.smethod_7();
					num = (int)((num2 * 1961429159) ^ 0x7E25C9DB);
					continue;
				case 73u:
					num = ((int)num2 * -952546065) ^ -33197090;
					continue;
				case 72u:
					PictureBox_2 = GForm2.smethod_7();
					num = (int)(num2 * 1530331542) ^ -213698976;
					continue;
				case 71u:
					GForm2.smethod_10((Control)(object)this);
					num = ((int)num2 * -677703780) ^ -597671525;
					continue;
				case 70u:
					GForm2.smethod_14((Control)(object)PictureBox_2, "PictureBox3");
					num = ((int)num2 * -2030165574) ^ 0x25B85EE2;
					continue;
				case 69u:
					GForm2.smethod_35((ISupportInitialize)PictureBox_2);
					GForm2.smethod_35((ISupportInitialize)PictureBox_3);
					num = (int)((num2 * 1350514730) ^ 0x12019268);
					continue;
				case 68u:
					GForm2.smethod_32((Control)(object)this, "SelectDuelType");
					num = (int)(num2 * 985459318) ^ -1142168820;
					continue;
				case 67u:
					GForm2.smethod_30((Form)(object)this, new Padding(4));
					GForm2.smethod_31((Form)(object)this, bool_1: false);
					num = ((int)num2 * -1771326901) ^ 0x18158460;
					continue;
				case 66u:
					GForm2.smethod_14((Control)(object)PictureBox_0, "PictureBox1");
					num = (int)((num2 * 229356911) ^ 0x4E9A6A7C);
					continue;
				case 65u:
					num = ((int)num2 * -90006619) ^ 0x67C832FA;
					continue;
				case 64u:
					num = (int)(num2 * 1735814704) ^ -536818862;
					continue;
				case 63u:
					GForm2.smethod_26(GForm2.smethod_25((Control)(object)this), (Control)(object)PictureBox_4);
					num = ((int)num2 * -2014889808) ^ 0x696BD178;
					continue;
				case 62u:
					num = ((int)num2 * -259833543) ^ -1430172446;
					continue;
				case 61u:
					num = (int)(num2 * 1797756390) ^ -2085414835;
					continue;
				case 60u:
					num = ((int)num2 * -640670751) ^ 0x323CBA66;
					continue;
				case 59u:
					GForm2.smethod_26(GForm2.smethod_25((Control)(object)this), (Control)(object)PictureBox_3);
					num = ((int)num2 * -556893085) ^ -1057055220;
					continue;
				case 58u:
					GForm2.smethod_35((ISupportInitialize)PictureBox_4);
					num = ((int)num2 * -1280723412) ^ 0x5F84F7B2;
					continue;
				case 57u:
					GForm2.smethod_33((Form)(object)this, (FormStartPosition)1);
					num = ((int)num2 * -2109252457) ^ -1664690252;
					continue;
				case 56u:
					GForm2.smethod_13((Control)(object)PictureBox_2, new Point(338, 306));
					num = ((int)num2 * -1595844494) ^ -1122201723;
					continue;
				case 55u:
					GForm2.smethod_36((Control)(object)this, bool_1: false);
					num = (int)((num2 * 379815219) ^ 0xC9FB16A);
					continue;
				case 54u:
					num = ((int)num2 * -751357563) ^ 0x3F380E4C;
					continue;
				case 53u:
					GForm2.smethod_11((Control)(object)PictureBox_3, Color.Transparent);
					num = (int)((num2 * 784430849) ^ 0x2CE87ECE);
					continue;
				case 52u:
					GForm2.smethod_12((Control)(object)PictureBox_1, (ImageLayout)3);
					num = ((int)num2 * -1453132616) ^ 0x6278064F;
					continue;
				case 51u:
					GForm2.smethod_14((Control)(object)PictureBox_4, "PictureBox5");
					num = (int)(num2 * 927431515) ^ -584173856;
					continue;
				case 50u:
					GForm2.smethod_17(PictureBox_4, bool_1: false);
					num = ((int)num2 * -2098618871) ^ -1972322855;
					continue;
				case 49u:
					GForm2.smethod_14((Control)(object)PictureBox_3, "PictureBox4");
					num = (int)(num2 * 1419874357) ^ -3750414;
					continue;
				case 48u:
					GForm2.smethod_26(GForm2.smethod_25((Control)(object)this), (Control)(object)PictureBox_2);
					num = (int)(num2 * 703069134) ^ -327548937;
					continue;
				case 47u:
					GForm2.smethod_17(PictureBox_0, bool_1: false);
					num = ((int)num2 * -420491424) ^ 0x44842339;
					continue;
				case 45u:
					GForm2.smethod_20((Control)(object)PictureBox_3, (Image)GForm2.smethod_19((ResourceManager)resourceManager_, "PictureBox4.BackgroundImage"));
					num = (int)(num2 * 1300691514) ^ -96361554;
					continue;
				case 44u:
					GForm2.smethod_35((ISupportInitialize)PictureBox_1);
					num = (int)((num2 * 324538185) ^ 0x68CEE920);
					continue;
				case 43u:
					((Control)this).set_DoubleBuffered(true);
					GForm2.smethod_28((Control)(object)this, GForm2.smethod_27("Consolas", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -299619164) ^ 0x260A52A;
					continue;
				case 42u:
					GForm2.smethod_15((Control)(object)PictureBox_4, new Size(504, 57));
					num = (int)((num2 * 1525080523) ^ 0x48F04D85);
					continue;
				case 41u:
					PictureBox_4 = GForm2.smethod_7();
					num = (int)((num2 * 1117340696) ^ 0x331324A4);
					continue;
				case 40u:
					GForm2.smethod_16(PictureBox_2, 3);
					GForm2.smethod_17(PictureBox_2, bool_1: false);
					num = ((int)num2 * -1221983040) ^ -744279668;
					continue;
				case 39u:
					GForm2.smethod_13((Control)(object)PictureBox_3, new Point(268, 492));
					num = ((int)num2 * -316209521) ^ -1560437561;
					continue;
				case 38u:
					GForm2.smethod_34((Form)(object)this, "The Omegle Game");
					GForm2.smethod_35((ISupportInitialize)PictureBox_0);
					num = (int)(num2 * 1842412015) ^ -11140861;
					continue;
				case 37u:
					GForm2.smethod_15((Control)(object)PictureBox_0, new Size(617, 69));
					num = ((int)num2 * -1064474925) ^ -1366215376;
					continue;
				case 36u:
					num = ((int)num2 * -797257501) ^ 0x144D0140;
					continue;
				case 35u:
					num = ((int)num2 * -2125601889) ^ 0x37BE3B08;
					continue;
				case 34u:
					GForm2.smethod_24((Form)(object)this, new Size(1025, 638));
					num = ((int)num2 * -769862623) ^ -1938845198;
					continue;
				case 33u:
					GForm2.smethod_22((ContainerControl)(object)this, (AutoScaleMode)1);
					GForm2.smethod_23((Form)(object)this, Color.White);
					num = (int)((num2 * 245450480) ^ 0x186D31BB);
					continue;
				case 32u:
					GForm2.smethod_9((ISupportInitialize)PictureBox_3);
					num = (int)(num2 * 781851526) ^ -361339894;
					continue;
				case 31u:
					num = ((int)num2 * -290904147) ^ 0x6096EFBD;
					continue;
				case 30u:
					GForm2.smethod_9((ISupportInitialize)PictureBox_4);
					num = (int)(num2 * 422391556) ^ -1346716175;
					continue;
				case 29u:
					GForm2.smethod_12((Control)(object)PictureBox_2, (ImageLayout)3);
					num = ((int)num2 * -1579285036) ^ 0x63D7250D;
					continue;
				case 28u:
					num = (int)((num2 * 909318910) ^ 0x3A704200);
					continue;
				case 27u:
					num = (int)(num2 * 857819819) ^ -1091569593;
					continue;
				case 26u:
					GForm2.smethod_9((ISupportInitialize)PictureBox_1);
					GForm2.smethod_9((ISupportInitialize)PictureBox_2);
					num = (int)((num2 * 2008973311) ^ 0x2392FF93);
					continue;
				case 25u:
					GForm2.smethod_12((Control)(object)PictureBox_4, (ImageLayout)3);
					num = ((int)num2 * -30428697) ^ 0xBA77B86;
					continue;
				case 24u:
					GForm2.smethod_16(PictureBox_1, 2);
					num = ((int)num2 * -434372124) ^ 0x55A4B290;
					continue;
				case 23u:
					GForm2.smethod_13((Control)(object)PictureBox_1, new Point(268, 168));
					num = (int)(num2 * 1413614565) ^ -305428120;
					continue;
				case 22u:
					GForm2.smethod_26(GForm2.smethod_25((Control)(object)this), (Control)(object)PictureBox_1);
					num = (int)((num2 * 1496985712) ^ 0x4A0C4DA0);
					continue;
				case 21u:
					GForm2.smethod_26(GForm2.smethod_25((Control)(object)this), (Control)(object)PictureBox_0);
					num = ((int)num2 * -997520349) ^ 0x1C7AEA6B;
					continue;
				case 20u:
					num = ((int)num2 * -1317515571) ^ 0x323389BA;
					continue;
				case 19u:
					num = (int)(num2 * 123049854) ^ -1654887903;
					continue;
				case 18u:
					Timer_0 = GForm2.smethod_8(icontainer_0);
					num = ((int)num2 * -1740777554) ^ -1208171760;
					continue;
				case 17u:
					num = (int)(num2 * 202700784) ^ -3680582;
					continue;
				case 16u:
					GForm2.smethod_17(PictureBox_3, bool_1: false);
					num = ((int)num2 * -384461551) ^ 0x57EE4386;
					continue;
				case 15u:
					GForm2.smethod_13((Control)(object)PictureBox_0, new Point(214, 12));
					num = (int)(num2 * 108464968) ^ -66286255;
					continue;
				case 14u:
					GForm2.smethod_12((Control)(object)PictureBox_3, (ImageLayout)3);
					num = ((int)num2 * -1779786468) ^ -755366697;
					continue;
				case 13u:
					GForm2.smethod_20((Control)(object)PictureBox_4, (Image)GForm2.smethod_19((ResourceManager)resourceManager_, "PictureBox5.BackgroundImage"));
					num = ((int)num2 * -539255736) ^ -618228326;
					continue;
				case 12u:
					num = ((int)num2 * -1053529888) ^ -205563643;
					continue;
				case 11u:
					GForm2.smethod_17(PictureBox_1, bool_1: false);
					num = (int)(num2 * 575763680) ^ -1015404291;
					continue;
				case 10u:
					GForm2.smethod_15((Control)(object)PictureBox_2, new Size(353, 42));
					num = ((int)num2 * -156795740) ^ 0x4631D30A;
					continue;
				case 9u:
					PictureBox_3 = GForm2.smethod_7();
					num = (int)((num2 * 264551682) ^ 0x588CEC54);
					continue;
				case 8u:
					GForm2.smethod_16(PictureBox_4, 5);
					num = (int)(num2 * 1842650084) ^ -981239733;
					continue;
				case 7u:
					GForm2.smethod_11((Control)(object)PictureBox_4, Color.Transparent);
					num = ((int)num2 * -110311240) ^ 0x2D2718A4;
					continue;
				case 6u:
					num = ((int)num2 * -181287517) ^ -1937402187;
					continue;
				case 5u:
					num = (int)((num2 * 153886303) ^ 0x3CC8C079);
					continue;
				case 4u:
					GForm2.smethod_18(Timer_0, 1000);
					GForm2.smethod_11((Control)(object)PictureBox_1, Color.Transparent);
					num = (int)((num2 * 2009471844) ^ 0x35B8D7FD);
					continue;
				case 3u:
					num = ((int)num2 * -597877746) ^ -693044859;
					continue;
				case 2u:
					GForm2.smethod_15((Control)(object)PictureBox_3, new Size(504, 57));
					GForm2.smethod_16(PictureBox_3, 4);
					num = (int)(num2 * 489767414) ^ -2118563631;
					continue;
				case 1u:
					GForm2.smethod_29((Form)(object)this, (FormBorderStyle)1);
					num = (int)(num2 * 1744980114) ^ -570951663;
					continue;
				case 0u:
					num = ((int)num2 * -916963975) ^ -624613013;
					continue;
				default:
					return;
				case 86u:
					break;
				case 46u:
					return;
				}
				break;
			}
		}
	}

	private void method_1(object sender, EventArgs e)
	{
		GForm2.smethod_46(GForm2.smethod_45(), ProcessPriorityClass.RealTime);
		GForm2.smethod_20((Control)(object)this, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\main_menu.jpg")));
		GForm2.smethod_20((Control)(object)PictureBox_0, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\logo.png")));
		while (true)
		{
			int num = 1258494674;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x68CA7A23u) % 8u)
				{
				case 7u:
					GForm2.smethod_50(Timer_0);
					num = (int)(num2 * 1575514431) ^ -2007226316;
					continue;
				case 5u:
					num = (int)((num2 * 1219553843) ^ 0x1AF81C73);
					continue;
				case 3u:
					GForm2.smethod_20((Control)(object)PictureBox_3, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\fai_un_duello.png")));
					num = (int)(num2 * 694315006) ^ -612240173;
					continue;
				case 2u:
					GForm2.smethod_20((Control)(object)PictureBox_4, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\torna_indietro.png")));
					num = (int)(num2 * 1482141493) ^ -1321777220;
					continue;
				case 1u:
					GForm2.smethod_20((Control)(object)PictureBox_1, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\seleziona_una_modalita.png")));
					GForm2.smethod_20((Control)(object)PictureBox_2, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\con_la_cpu_hover.png")));
					num = (int)(num2 * 1478355261) ^ -1298457994;
					continue;
				case 0u:
					num = (int)(num2 * 2021898799) ^ -1573988256;
					continue;
				default:
					return;
				case 4u:
					break;
				case 6u:
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
			int num = -1048360492;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDE278218u) % 3u)
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
				GForm2.smethod_51();
				num = (int)((num2 * 1487091798) ^ 0x463604B2);
			}
		}
	}

	private void method_3(object sender, KeyEventArgs e)
	{
		bool flag = default(bool);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -1099905730;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x85980A57u) % 19u)
				{
				case 18u:
				{
					int num9;
					int num10;
					if (!flag)
					{
						num9 = 738396686;
						num10 = 738396686;
					}
					else
					{
						num9 = 1781375120;
						num10 = 1781375120;
					}
					num = num9 ^ (int)(num2 * 1590816668);
					continue;
				}
				case 17u:
					num = -1827227766;
					continue;
				case 16u:
					int_0 = 1;
					num = ((int)num2 * -2080223626) ^ 0x37F24601;
					continue;
				case 15u:
				{
					int num5;
					int num6;
					if (int_0 == 0)
					{
						num5 = -213477377;
						num6 = -213477377;
					}
					else
					{
						num5 = -94746594;
						num6 = -94746594;
					}
					num = num5 ^ (int)(num2 * 296768625);
					continue;
				}
				case 14u:
					GForm2.smethod_20((Control)(object)PictureBox_2, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\con_gli_altri.png")));
					num = ((int)num2 * -763285523) ^ 0xB054DA6;
					continue;
				case 13u:
				{
					int num7;
					int num8;
					if (flag3)
					{
						num7 = -553947966;
						num8 = -553947966;
					}
					else
					{
						num7 = -1868628079;
						num8 = -1868628079;
					}
					num = num7 ^ ((int)num2 * -1184330929);
					continue;
				}
				case 12u:
					flag3 = int_0 == 0;
					num = (int)(num2 * 2031028816) ^ -585060913;
					continue;
				case 11u:
					int_0 = 0;
					num = (int)(num2 * 71234165) ^ -560706180;
					continue;
				case 10u:
				{
					int num3;
					int num4;
					if (flag2)
					{
						num3 = -1458060267;
						num4 = -1458060267;
					}
					else
					{
						num3 = -1760116032;
						num4 = -1760116032;
					}
					num = num3 ^ ((int)num2 * -1734870298);
					continue;
				}
				case 9u:
					GForm2.smethod_20((Control)(object)PictureBox_2, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\con_la_cpu_hover.png")));
					num = (int)(num2 * 1289773546) ^ -552085098;
					continue;
				case 8u:
					flag2 = int_0 == 1;
					num = -1435790988;
					continue;
				case 7u:
					flag = (GForm2.smethod_52(e) == 37) | (GForm2.smethod_52(e) == 39);
					num = (int)(num2 * 1558763041) ^ -1283419131;
					continue;
				case 5u:
					num = ((int)num2 * -1430559162) ^ -69114208;
					continue;
				case 3u:
					num = ((int)num2 * -1150867711) ^ -1997199977;
					continue;
				case 2u:
					num = -116495228;
					continue;
				case 1u:
					num = (int)(num2 * 1686252806) ^ -58390092;
					continue;
				case 0u:
					num = -771882886;
					continue;
				default:
					return;
				case 6u:
					break;
				case 4u:
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
			int num = -754791693;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA5C9D04Eu) % 3u)
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
				GForm2.smethod_20((Control)(object)PictureBox_3, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\fai_un_duello_hover.png")));
				num = ((int)num2 * -1672516614) ^ -337835629;
			}
		}
	}

	private void method_5(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -96346293;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBA218B81u) % 3u)
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
				GForm2.smethod_20((Control)(object)PictureBox_3, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\fai_un_duello.png")));
				num = ((int)num2 * -743590728) ^ 0x72A7C673;
			}
		}
	}

	private void method_6(object sender, EventArgs e)
	{
		GForm2.smethod_20((Control)(object)PictureBox_4, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\torna_indietro_hover.png")));
	}

	private void method_7(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -1933290224;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBCAE4599u) % 4u)
				{
				case 1u:
					GForm2.smethod_20((Control)(object)PictureBox_4, GForm2.smethod_49(GForm2.smethod_48(GForm2.smethod_47(), "\\data\\Images\\torna_indietro.png")));
					num = (int)(num2 * 2095383323) ^ -229917662;
					continue;
				case 0u:
					num = ((int)num2 * -677864116) ^ -1760126837;
					continue;
				default:
					return;
				case 3u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	private void method_8(object sender, FormClosingEventArgs e)
	{
		method_9();
		bool flag = default(bool);
		while (true)
		{
			int num = 596231165;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x41EED5F9u) % 8u)
				{
				case 7u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1586605747;
						num4 = -1586605747;
					}
					else
					{
						num3 = -1249587812;
						num4 = -1249587812;
					}
					num = num3 ^ ((int)num2 * -1368609372);
					continue;
				}
				case 5u:
					num = ((int)num2 * -845978105) ^ -792203830;
					continue;
				case 4u:
					num = (int)((num2 * 532517115) ^ 0x29640EAE);
					continue;
				case 3u:
					flag = !bool_0;
					num = ((int)num2 * -696086498) ^ -1526450956;
					continue;
				case 2u:
					num = ((int)num2 * -1979917634) ^ -884842968;
					continue;
				case 1u:
					GForm2.smethod_53((CancelEventArgs)(object)e, bool_1: true);
					num = (int)((num2 * 1994951556) ^ 0x594AD63F);
					continue;
				default:
					return;
				case 6u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public void method_9()
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Invalid comparison between Unknown and I4
		bool flag = !bool_0;
		bool flag2 = default(bool);
		while (true)
		{
			int num = -2127702159;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x84831693u) % 21u)
				{
				case 20u:
					num = ((int)num2 * -1006619875) ^ -1918885751;
					continue;
				case 19u:
					GForm2.smethod_51();
					num = (int)((num2 * 1131424040) ^ 0x44283DDB);
					continue;
				case 18u:
					num = ((int)num2 * -1722965378) ^ -424854203;
					continue;
				case 17u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = -322329785;
						num6 = -322329785;
					}
					else
					{
						num5 = -114426647;
						num6 = -114426647;
					}
					num = num5 ^ ((int)num2 * -66881117);
					continue;
				}
				case 16u:
					flag2 = (int)GForm2.smethod_54("Sei sicuro di voler uscire dal gioco?", "The Omegle Game", (MessageBoxButtons)4, (MessageBoxIcon)32) == 6;
					num = ((int)num2 * -1105710944) ^ -935969552;
					continue;
				case 15u:
					GForm2.smethod_55(Timer_0);
					num = -635384297;
					continue;
				case 14u:
					GForm2.smethod_55(Timer_0);
					GForm2.smethod_56((object)Timer_0);
					num = (int)(num2 * 549695163) ^ -2102666283;
					continue;
				case 13u:
					GForm2.smethod_56((object)bool_0);
					num = ((int)num2 * -80539645) ^ 0x7B554626;
					continue;
				case 11u:
					GForm2.smethod_57(GForm2.smethod_45());
					num = (int)((num2 * 239013939) ^ 0x350DC770);
					continue;
				case 10u:
					GForm2.smethod_56((object)int_0);
					num = ((int)num2 * -2009132079) ^ 0x57F5E79B;
					continue;
				case 9u:
					GForm2.smethod_56((object)bool_0);
					GForm2.smethod_51();
					num = (int)((num2 * 1086131295) ^ 0x5EF96B44);
					continue;
				case 8u:
					num = (int)(num2 * 936717106) ^ -585157481;
					continue;
				case 7u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -109953493;
						num4 = -109953493;
					}
					else
					{
						num3 = -1830711629;
						num4 = -1830711629;
					}
					num = num3 ^ (int)(num2 * 2020087858);
					continue;
				}
				case 6u:
					num = -1940404069;
					continue;
				case 5u:
					num = ((int)num2 * -704060399) ^ -1287004831;
					continue;
				case 4u:
					num = (int)(num2 * 1957545149) ^ -2027624086;
					continue;
				case 2u:
					GForm2.smethod_56((object)Timer_0);
					num = (int)((num2 * 366988687) ^ 0x4C87AD8);
					continue;
				case 1u:
					GForm2.smethod_56((object)int_0);
					num = ((int)num2 * -1764428414) ^ 0x653C9F5;
					continue;
				case 0u:
					num = ((int)num2 * -468458137) ^ -1202315310;
					continue;
				default:
					return;
				case 3u:
					break;
				case 12u:
					return;
				}
				break;
			}
		}
	}

	private void method_10(object sender, MouseEventArgs e)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		bool_0 = true;
		while (true)
		{
			int num = 566808916;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1384C234u) % 3u)
				{
				case 1u:
					goto IL_0009;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0009:
				GForm2.smethod_54("Ci dispiace, ma la modalità duello non è attualmente disponibile.", "The Omegle Game", (MessageBoxButtons)0, (MessageBoxIcon)48);
				num = (int)(num2 * 280707671) ^ -583242523;
			}
		}
	}

	private void method_11(object sender, MouseEventArgs e)
	{
		bool_0 = true;
		while (true)
		{
			int num = -815382920;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8606F2DBu) % 5u)
				{
				case 3u:
					num = ((int)num2 * -2135532998) ^ 0x224D1B7B;
					continue;
				case 2u:
					GForm2.smethod_59((Form)(object)this);
					num = ((int)num2 * -648187742) ^ -181228082;
					continue;
				case 1u:
					GForm2.smethod_58((Control)(object)Class2.Class3_0.GForm1_0);
					num = ((int)num2 * -666095530) ^ -2133629966;
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
