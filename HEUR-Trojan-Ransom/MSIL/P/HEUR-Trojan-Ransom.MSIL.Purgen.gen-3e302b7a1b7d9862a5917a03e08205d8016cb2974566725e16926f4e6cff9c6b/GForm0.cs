using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public class GForm0 : Form
{
	private IContainer icontainer_0;

	[AccessedThroughProperty("MemoryCleaner")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Timer timer_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PictureBox1")]
	[CompilerGenerated]
	private PictureBox pictureBox_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Introduce")]
	private Timer timer_1;

	private bool bool_0;

	private float float_0;

	private int int_0;

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
				goto IL_0082;
			}
			goto IL_00b4;
			IL_00b4:
			timer_0 = value;
			int num = -2036157915;
			goto IL_0087;
			IL_0087:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCCA74461u) % 7u)
				{
				case 6u:
					GForm0.smethod_33(val, eventHandler_);
					num = (int)((num2 * 1665331837) ^ 0x7B77A23);
					continue;
				case 4u:
					GForm0.smethod_34(val, eventHandler_);
					num = (int)((num2 * 1206254494) ^ 0x1A4C41D8);
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (val == null)
					{
						num3 = -135514844;
						num4 = -135514844;
					}
					else
					{
						num3 = -1924855125;
						num4 = -1924855125;
					}
					num = num3 ^ ((int)num2 * -706083986);
					continue;
				}
				case 2u:
					val = timer_0;
					num = ((int)num2 * -1346759167) ^ -342211891;
					continue;
				case 0u:
					break;
				default:
					return;
				case 5u:
					goto IL_00b4;
				case 1u:
					return;
				}
				break;
			}
			goto IL_0082;
			IL_0082:
			num = -1160394127;
			goto IL_0087;
		}
	}

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

	internal virtual Timer Timer_1
	{
		[CompilerGenerated]
		get
		{
			return timer_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = method_5;
			Timer val = timer_1;
			while (true)
			{
				int num = -2016248869;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA8AA7737u) % 7u)
					{
					case 6u:
						GForm0.smethod_34(val, eventHandler_);
						num = ((int)num2 * -1297928109) ^ -1823291763;
						continue;
					case 4u:
					{
						int num5;
						int num6;
						if (val == null)
						{
							num5 = 641103422;
							num6 = 641103422;
						}
						else
						{
							num5 = 1435192635;
							num6 = 1435192635;
						}
						num = num5 ^ (int)(num2 * 235493145);
						continue;
					}
					case 2u:
						GForm0.smethod_33(val, eventHandler_);
						num = (int)(num2 * 511934156) ^ -740532942;
						continue;
					case 1u:
					{
						val = timer_1;
						int num3;
						int num4;
						if (val != null)
						{
							num3 = -1005361255;
							num4 = -1005361255;
						}
						else
						{
							num3 = -1959447445;
							num4 = -1959447445;
						}
						num = num3 ^ ((int)num2 * -609715998);
						continue;
					}
					case 0u:
						timer_1 = value;
						num = -250107954;
						continue;
					default:
						return;
					case 3u:
						break;
					case 5u:
						return;
					}
					break;
				}
			}
		}
	}

	public GForm0()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		GForm0.smethod_1((Form)(object)this, (EventHandler)method_1);
		GForm0.smethod_2((Form)(object)this, new FormClosingEventHandler(method_3));
		bool_0 = false;
		float_0 = 0.1f;
		int_0 = 0;
		method_0();
	}

	[DebuggerNonUserCode]
	void Form.Dispose(bool disposing)
	{
		try
		{
			if (disposing)
			{
				goto IL_0066;
			}
			int num = 0;
			goto IL_00a1;
			IL_00a1:
			bool flag = (byte)num != 0;
			int num2 = -1141264281;
			goto IL_006b;
			IL_0066:
			num2 = -715823238;
			goto IL_006b;
			IL_006b:
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x881B7A2Du) % 7u)
				{
				case 6u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 15401121;
						num5 = 15401121;
					}
					else
					{
						num4 = 1150364356;
						num5 = 1150364356;
					}
					num2 = num4 ^ (int)(num3 * 1309738981);
					continue;
				}
				case 5u:
					GForm0.smethod_3((IDisposable)icontainer_0);
					num2 = (int)(num3 * 350547974) ^ -1797089590;
					continue;
				case 3u:
					num2 = (int)(num3 * 1659689562) ^ -510572424;
					continue;
				case 1u:
					num2 = ((int)num3 * -1395206311) ^ 0x2B7D916C;
					continue;
				case 0u:
					break;
				default:
					return;
				case 4u:
					goto IL_0098;
				case 2u:
					return;
				}
				break;
			}
			goto IL_0066;
			IL_0098:
			num = ((icontainer_0 != null) ? 1 : 0);
			goto IL_00a1;
		}
		finally
		{
			while (true)
			{
				IL_00df:
				int num6 = -1600455421;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num6 ^ 0x881B7A2Du) % 3u)
					{
					case 2u:
						goto IL_00ae;
					default:
						goto end_IL_00c2;
					case 0u:
						break;
					case 1u:
						goto end_IL_00c2;
					}
					goto IL_00df;
					IL_00ae:
					((Form)this).Dispose(disposing);
					num6 = (int)(num3 * 1235805931) ^ -1948767;
					continue;
					end_IL_00c2:
					break;
				}
				break;
			}
		}
	}

	[DebuggerStepThrough]
	private void method_0()
	{
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			int num = 1793809510;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x32078146u) % 37u)
				{
				case 36u:
					GForm0.smethod_12((Control)(object)PictureBox_0, new Point(365, 415));
					num = ((int)num2 * -4690703) ^ 0x6E2A2C7D;
					continue;
				case 35u:
					Timer_0 = GForm0.smethod_5(icontainer_0);
					PictureBox_0 = GForm0.smethod_6();
					num = ((int)num2 * -972966911) ^ 0x8B36991;
					continue;
				case 34u:
					num = (int)(num2 * 1186930766) ^ -2095464994;
					continue;
				case 33u:
					GForm0.smethod_10((Control)(object)PictureBox_0, Color.Transparent);
					num = (int)(num2 * 794196890) ^ -456221926;
					continue;
				case 32u:
					GForm0.smethod_8((Control)(object)this);
					num = (int)(num2 * 658821640) ^ -1032568909;
					continue;
				case 31u:
					GForm0.smethod_18((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 998462024) ^ -1254768357;
					continue;
				case 30u:
					((Control)this).set_DoubleBuffered(true);
					num = ((int)num2 * -865556717) ^ 0x36F994ED;
					continue;
				case 29u:
					num = ((int)num2 * -1690567458) ^ -88788414;
					continue;
				case 27u:
					GForm0.smethod_15(PictureBox_0, 0);
					num = ((int)num2 * -192499213) ^ 0x2B487D1D;
					continue;
				case 26u:
					GForm0.smethod_16(PictureBox_0, bool_1: false);
					num = (int)(num2 * 149100362) ^ -1531949528;
					continue;
				case 25u:
					num = (int)((num2 * 1593228861) ^ 0x1B219DC3);
					continue;
				case 24u:
					num = ((int)num2 * -1004633137) ^ -887170163;
					continue;
				case 23u:
					GForm0.smethod_13((Control)(object)PictureBox_0, "PictureBox1");
					num = ((int)num2 * -226313453) ^ 0x23C7BC8B;
					continue;
				case 21u:
					GForm0.smethod_11((Control)(object)PictureBox_0, (ImageLayout)3);
					num = (int)(num2 * 587321014) ^ -1514866996;
					continue;
				case 20u:
					num = ((int)num2 * -271186989) ^ -1224586330;
					continue;
				case 19u:
					GForm0.smethod_31((ISupportInitialize)PictureBox_0);
					num = ((int)num2 * -1527020397) ^ -450402762;
					continue;
				case 18u:
					GForm0.smethod_26((Form)(object)this, new Padding(4));
					GForm0.smethod_27((Form)(object)this, bool_1: false);
					num = ((int)num2 * -246309622) ^ -631826290;
					continue;
				case 17u:
					GForm0.smethod_9(Timer_0, 1000);
					num = (int)(num2 * 799649399) ^ -1415722134;
					continue;
				case 16u:
					num = ((int)num2 * -714968875) ^ 0x1F7CF268;
					continue;
				case 15u:
					GForm0.smethod_17((ContainerControl)(object)this, new SizeF(10f, 22f));
					num = ((int)num2 * -1163969968) ^ 0x49B233FE;
					continue;
				case 14u:
					GForm0.smethod_7((ISupportInitialize)PictureBox_0);
					num = ((int)num2 * -2004302649) ^ -1897402651;
					continue;
				case 13u:
					GForm0.smethod_25((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -902273070) ^ -972534182;
					continue;
				case 12u:
					GForm0.smethod_22(GForm0.smethod_21((Control)(object)this), (Control)(object)PictureBox_0);
					num = ((int)num2 * -1133477149) ^ 0x75779FD2;
					continue;
				case 11u:
					GForm0.smethod_9(Timer_1, 500);
					num = ((int)num2 * -165471436) ^ 0x32940935;
					continue;
				case 10u:
					GForm0.smethod_24((Control)(object)this, GForm0.smethod_23("Consolas", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1885286692) ^ 0x7EF9301F);
					continue;
				case 9u:
					GForm0.smethod_11((Control)(object)this, (ImageLayout)3);
					num = (int)(num2 * 1284044257) ^ -2067528171;
					continue;
				case 8u:
					num = ((int)num2 * -153152933) ^ 0x66311E13;
					continue;
				case 7u:
					GForm0.smethod_28((Control)(object)this, "Introduction");
					GForm0.smethod_29((Form)(object)this, (FormStartPosition)1);
					GForm0.smethod_30((Form)(object)this, "The Omegle Game");
					num = (int)((num2 * 203509350) ^ 0x2C2A5EFF);
					continue;
				case 6u:
					GForm0.smethod_19((Form)(object)this, Color.White);
					num = ((int)num2 * -1950512111) ^ 0x5D9C8F99;
					continue;
				case 5u:
					icontainer_0 = GForm0.smethod_4();
					num = (int)(num2 * 633086753) ^ -276993586;
					continue;
				case 4u:
					GForm0.smethod_20((Form)(object)this, new Size(1025, 638));
					num = (int)(num2 * 1105041442) ^ -234863963;
					continue;
				case 3u:
					GForm0.smethod_32((Control)(object)this, bool_1: false);
					num = ((int)num2 * -2083142396) ^ 0x3AC0FC20;
					continue;
				case 2u:
					GForm0.smethod_14((Control)(object)PictureBox_0, new Size(302, 211));
					num = ((int)num2 * -1803285642) ^ 0x2B4A9DBE;
					continue;
				case 1u:
					Timer_1 = GForm0.smethod_5(icontainer_0);
					num = (int)(num2 * 2008167607) ^ -164927672;
					continue;
				case 0u:
					num = (int)(num2 * 1301611441) ^ -1795567501;
					continue;
				default:
					return;
				case 22u:
					break;
				case 28u:
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
			int num = -1065026420;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF31E6515u) % 8u)
				{
				case 7u:
					GForm0.smethod_40((Control)(object)this, GForm0.smethod_39(GForm0.smethod_38(GForm0.smethod_37(), "\\data\\Images\\schermata_omegle.png")));
					num = (int)(num2 * 895712838) ^ -996761831;
					continue;
				case 6u:
					num = ((int)num2 * -261772244) ^ -1702532257;
					continue;
				case 5u:
					num = (int)(num2 * 1316013017) ^ -1703724205;
					continue;
				case 2u:
					GForm0.smethod_40((Control)(object)PictureBox_0, (Image)(object)smethod_0(GForm0.smethod_39(GForm0.smethod_38(GForm0.smethod_37(), "\\data\\Images\\marco_introduzione.png")), float_0));
					GClass1.smethod_0();
					num = (int)(num2 * 1333900138) ^ -1203230567;
					continue;
				case 1u:
					GForm0.smethod_36(GForm0.smethod_35(), ProcessPriorityClass.RealTime);
					num = ((int)num2 * -1122636970) ^ 0x33576E84;
					continue;
				case 0u:
					GClass1.smethod_3().method_0();
					num = ((int)num2 * -1972686395) ^ -858073544;
					continue;
				case 4u:
					break;
				default:
					GForm0.smethod_41(Timer_1);
					return;
				}
				break;
			}
		}
	}

	public static Bitmap smethod_0(Image image_0, float float_1)
	{
		Graphics graphics_ = default(Graphics);
		Bitmap result = default(Bitmap);
		Bitmap val = default(Bitmap);
		ColorMatrix colorMatrix_ = default(ColorMatrix);
		ImageAttributes imageAttributes_ = default(ImageAttributes);
		while (true)
		{
			int num = 1180323264;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3C3E97F0u) % 11u)
				{
				case 10u:
					GForm0.smethod_51(graphics_);
					result = val;
					num = ((int)num2 * -817640436) ^ 0x5BFB102A;
					continue;
				case 9u:
					GForm0.smethod_47(colorMatrix_, float_1);
					num = (int)((num2 * 804417995) ^ 0x671BFBC5);
					continue;
				case 7u:
					num = ((int)num2 * -100674289) ^ -1724380758;
					continue;
				case 6u:
					num = ((int)num2 * -1640033407) ^ -769030446;
					continue;
				case 5u:
					GForm0.smethod_50(graphics_, image_0, new Rectangle(0, 0, GForm0.smethod_42((Image)(object)val), GForm0.smethod_43((Image)(object)val)), 0, 0, GForm0.smethod_42(image_0), GForm0.smethod_43(image_0), (GraphicsUnit)2, imageAttributes_);
					num = (int)(num2 * 1215655754) ^ -573647961;
					continue;
				case 4u:
					num = ((int)num2 * -686303234) ^ 0x337C4D5E;
					continue;
				case 3u:
					imageAttributes_ = GForm0.smethod_48();
					GForm0.smethod_49(imageAttributes_, colorMatrix_, (ColorMatrixFlag)0, (ColorAdjustType)1);
					num = (int)(num2 * 1457557810) ^ -423735205;
					continue;
				case 1u:
					val = GForm0.smethod_44(GForm0.smethod_42(image_0), GForm0.smethod_43(image_0));
					graphics_ = GForm0.smethod_45((Image)(object)val);
					colorMatrix_ = GForm0.smethod_46();
					num = ((int)num2 * -1690648410) ^ 0x2061A4C9;
					continue;
				case 0u:
					num = (int)((num2 * 508539145) ^ 0x7FC5F417);
					continue;
				case 2u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	private void method_2(object sender, EventArgs e)
	{
		GForm0.smethod_52();
	}

	private void method_3(object sender, FormClosingEventArgs e)
	{
		while (true)
		{
			int num = 1791620943;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7106870Eu) % 8u)
				{
				case 5u:
					num = (int)((num2 * 1548822981) ^ 0x97A17E5);
					continue;
				case 4u:
					num = ((int)num2 * -1836472558) ^ -1582955442;
					continue;
				case 3u:
					GForm0.smethod_53((CancelEventArgs)(object)e, bool_1: true);
					num = (int)(num2 * 371860434) ^ -1875172548;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!bool_0)
					{
						num3 = -250845759;
						num4 = -250845759;
					}
					else
					{
						num3 = -1646966702;
						num4 = -1646966702;
					}
					num = num3 ^ ((int)num2 * -1885910438);
					continue;
				}
				case 1u:
					method_4();
					num = (int)(num2 * 1258183062) ^ -1241880275;
					continue;
				case 0u:
					num = 1899010017;
					continue;
				default:
					return;
				case 6u:
					break;
				case 7u:
					return;
				}
				break;
			}
		}
	}

	public void method_4()
	{
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Invalid comparison between Unknown and I4
		bool flag = !bool_0;
		bool flag2 = default(bool);
		while (true)
		{
			int num = 1601966967;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4D26B439u) % 25u)
				{
				case 24u:
					num = (int)((num2 * 1756591559) ^ 0x78DBC223);
					continue;
				case 23u:
					num = (int)((num2 * 1732144034) ^ 0x2FBF21F);
					continue;
				case 22u:
					GForm0.smethod_56((object)bool_0);
					num = (int)(num2 * 1423547787) ^ -1032661857;
					continue;
				case 21u:
					GForm0.smethod_52();
					num = ((int)num2 * -9610835) ^ 0x7D55B8CB;
					continue;
				case 20u:
					num = ((int)num2 * -196944847) ^ 0x1C828E9B;
					continue;
				case 19u:
					num = (int)((num2 * 2115564067) ^ 0x4175CCAF);
					continue;
				case 18u:
					num = ((int)num2 * -1549965800) ^ -111893690;
					continue;
				case 16u:
					flag2 = (int)GForm0.smethod_54("Sei sicuro di voler uscire dal gioco?", "The Omegle Game", (MessageBoxButtons)4, (MessageBoxIcon)32) == 6;
					num = (int)((num2 * 626785591) ^ 0x35F89D2);
					continue;
				case 15u:
					GForm0.smethod_55(Timer_0);
					num = 248865649;
					continue;
				case 14u:
					GForm0.smethod_56((object)bool_0);
					num = (int)((num2 * 1749573437) ^ 0x7457CACC);
					continue;
				case 13u:
					GForm0.smethod_56((object)Timer_0);
					num = ((int)num2 * -1421125863) ^ -2078918384;
					continue;
				case 12u:
					num = (int)(num2 * 815566230) ^ -1320389257;
					continue;
				case 11u:
					GForm0.smethod_57(GForm0.smethod_35());
					num = ((int)num2 * -1595891835) ^ -335171191;
					continue;
				case 9u:
					num = 302774123;
					continue;
				case 8u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = 201983956;
						num6 = 201983956;
					}
					else
					{
						num5 = 1385514688;
						num6 = 1385514688;
					}
					num = num5 ^ (int)(num2 * 1401722830);
					continue;
				}
				case 7u:
					num = (int)((num2 * 113324143) ^ 0x1A80EEA4);
					continue;
				case 6u:
					num = ((int)num2 * -659341498) ^ -1230922215;
					continue;
				case 5u:
					GForm0.smethod_55(Timer_0);
					num = (int)(num2 * 1928281451) ^ -562650629;
					continue;
				case 4u:
					GForm0.smethod_52();
					num = ((int)num2 * -1941038290) ^ 0x7C3AE88D;
					continue;
				case 3u:
					num = (int)((num2 * 1130667117) ^ 0x219DD85B);
					continue;
				case 2u:
					GForm0.smethod_56((object)Timer_0);
					num = (int)(num2 * 954774670) ^ -1535263183;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag2)
					{
						num3 = 605625875;
						num4 = 605625875;
					}
					else
					{
						num3 = 958051205;
						num4 = 958051205;
					}
					num = num3 ^ (int)(num2 * 1250235054);
					continue;
				}
				case 0u:
					num = ((int)num2 * -388132111) ^ -113667990;
					continue;
				default:
					return;
				case 10u:
					break;
				case 17u:
					return;
				}
				break;
			}
		}
	}

	private void method_5(object sender, EventArgs e)
	{
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -1126593155;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA93A7880u) % 42u)
				{
				case 41u:
					num = (int)(num2 * 956601653) ^ -1154632247;
					continue;
				case 40u:
					num = ((int)num2 * -964031731) ^ 0x2C9F59D0;
					continue;
				case 39u:
				{
					int num9;
					if ((int_0 >= 16) & (int_0 <= 20))
					{
						num = -748159034;
						num9 = -748159034;
					}
					else
					{
						num = -859209709;
						num9 = -859209709;
					}
					continue;
				}
				case 38u:
					num = (int)((num2 * 1021020742) ^ 0x4E45C33E);
					continue;
				case 37u:
					checked
					{
						int_0++;
					}
					num = ((int)num2 * -282675484) ^ -1844372708;
					continue;
				case 36u:
					checked
					{
						int_0++;
					}
					num = (int)(num2 * 376997779) ^ -2055632843;
					continue;
				case 35u:
					flag3 = int_0 <= 15;
					num = ((int)num2 * -1379611080) ^ 0x3A895C28;
					continue;
				case 34u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = 775610026;
						num6 = 775610026;
					}
					else
					{
						num5 = 1559937491;
						num6 = 1559937491;
					}
					num = num5 ^ ((int)num2 * -92451408);
					continue;
				}
				case 33u:
					GForm0.smethod_56((object)int_0);
					GClass1.smethod_3().method_3();
					num = (int)(num2 * 980158742) ^ -520589845;
					continue;
				case 32u:
				{
					ref float reference = ref float_0;
					reference = (float)((double)reference + 0.3);
					checked
					{
						int_0++;
					}
					num = ((int)num2 * -1041275519) ^ -808320358;
					continue;
				}
				case 31u:
				{
					PictureBox control_;
					GForm0.smethod_65((Control)(object)(control_ = PictureBox_0), checked(GForm0.smethod_64((Control)(object)control_) + 30));
					num = (int)((num2 * 1095359318) ^ 0x5C58E8B4);
					continue;
				}
				case 30u:
					GForm0.smethod_56((object)float_0);
					num = ((int)num2 * -395994652) ^ 0x5ED70074;
					continue;
				case 29u:
					GForm0.smethod_52();
					num = (int)((num2 * 589047495) ^ 0xC3426E0);
					continue;
				case 28u:
					num = (int)(num2 * 1628397833) ^ -2017437734;
					continue;
				case 27u:
					flag = (int_0 >= 50) & (int_0 <= 57);
					num = -1946926838;
					continue;
				case 26u:
					GForm0.smethod_56((object)Timer_1);
					num = ((int)num2 * -992532663) ^ -272070915;
					continue;
				case 25u:
				{
					int num10;
					if ((int_0 >= 21) & (int_0 <= 49))
					{
						num = -1067423505;
						num10 = -1067423505;
					}
					else
					{
						num = -335321269;
						num10 = -335321269;
					}
					continue;
				}
				case 24u:
					num = ((int)num2 * -622250172) ^ -1590015526;
					continue;
				case 23u:
					GClass1.smethod_3().method_4();
					num = ((int)num2 * -1262496291) ^ 0x2C4AABD8;
					continue;
				case 21u:
					flag2 = (int_0 >= 57) & (int_0 <= 65);
					num = -1321597138;
					continue;
				case 20u:
					num = ((int)num2 * -958723966) ^ -1693317357;
					continue;
				case 19u:
					GForm0.smethod_40((Control)(object)PictureBox_0, GForm0.smethod_39(GForm0.smethod_38(GForm0.smethod_37(), "\\data\\Images\\marco_introduzione.png")));
					num = (int)((num2 * 2058632351) ^ 0x7836C391);
					continue;
				case 18u:
					GForm0.smethod_55(Timer_1);
					num = (int)(num2 * 1543239078) ^ -1563156582;
					continue;
				case 17u:
					num = (int)(num2 * 574444792) ^ -223769206;
					continue;
				case 16u:
					GForm0.smethod_40((Control)(object)PictureBox_0, (Image)(object)smethod_0(GForm0.smethod_58((Control)(object)PictureBox_0), float_0));
					num = (int)((num2 * 1170418162) ^ 0x50B1DCD);
					continue;
				case 15u:
					checked
					{
						int_0++;
					}
					num = ((int)num2 * -1995247367) ^ 0x543AB679;
					continue;
				case 14u:
				{
					int num7;
					int num8;
					if (!flag3)
					{
						num7 = -2056970591;
						num8 = -2056970591;
					}
					else
					{
						num7 = -942930272;
						num8 = -942930272;
					}
					num = num7 ^ ((int)num2 * -1504229952);
					continue;
				}
				case 13u:
					GForm0.smethod_12((Control)(object)PictureBox_0, checked(new Point((int)GForm0.smethod_61((double)((float)GForm0.smethod_59((Control)(object)PictureBox_0).X + GForm0.smethod_60() * 10f)), (int)GForm0.smethod_61((double)((float)GForm0.smethod_59((Control)(object)PictureBox_0).Y - GForm0.smethod_60() * 10f)))));
					num = (int)((num2 * 1385431762) ^ 0x42D04FDD);
					continue;
				case 12u:
					num = (int)((num2 * 1034781395) ^ 0x2C081423);
					continue;
				case 10u:
					num = ((int)num2 * -1639799768) ^ -1056628798;
					continue;
				case 9u:
					num = -697483956;
					continue;
				case 8u:
					num = ((int)num2 * -1940166556) ^ -543435362;
					continue;
				case 7u:
					num = (int)((num2 * 923368530) ^ 0x2A2A8C43);
					continue;
				case 6u:
					GForm0.smethod_12((Control)(object)PictureBox_0, new Point(512, 0));
					num = (int)((num2 * 1809581079) ^ 0x43B5D991);
					continue;
				case 5u:
					num = (int)((num2 * 561093260) ^ 0x6F18AFDC);
					continue;
				case 4u:
				{
					PictureBox control_;
					GForm0.smethod_65((Control)(object)(control_ = PictureBox_0), checked(GForm0.smethod_64((Control)(object)control_) + 22));
					GForm0.smethod_40((Control)(object)PictureBox_0, GForm0.smethod_39(GForm0.smethod_38(GForm0.smethod_37(), "\\data\\Images\\marco_introduzione.png")));
					num = (int)(num2 * 833988032) ^ -778267989;
					continue;
				}
				case 3u:
					num = (int)((num2 * 1028991939) ^ 0x3B1A5481);
					continue;
				case 2u:
					checked
					{
						int_0++;
					}
					num = ((int)num2 * -1772414075) ^ -1062678608;
					continue;
				case 1u:
				{
					PictureBox control_;
					GForm0.smethod_63((Control)(object)(control_ = PictureBox_0), checked(GForm0.smethod_62((Control)(object)control_) + 30));
					num = ((int)num2 * -273826575) ^ 0x4F26B0F9;
					continue;
				}
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1464665349;
						num4 = 1464665349;
					}
					else
					{
						num3 = 387191393;
						num4 = 387191393;
					}
					num = num3 ^ (int)(num2 * 1160059797);
					continue;
				}
				default:
					return;
				case 11u:
					break;
				case 22u:
					return;
				}
				break;
			}
		}
	}

	static void smethod_1(Form form_0, EventHandler eventHandler_0)
	{
		form_0.add_Load(eventHandler_0);
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

	static Timer smethod_5(IContainer icontainer_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new Timer(icontainer_1);
	}

	static PictureBox smethod_6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new PictureBox();
	}

	static void smethod_7(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.BeginInit();
	}

	static void smethod_8(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_9(Timer timer_2, int int_1)
	{
		timer_2.set_Interval(int_1);
	}

	static void smethod_10(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static void smethod_11(Control control_0, ImageLayout imageLayout_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_BackgroundImageLayout(imageLayout_0);
	}

	static void smethod_12(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_13(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_14(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_15(PictureBox pictureBox_1, int int_1)
	{
		pictureBox_1.set_TabIndex(int_1);
	}

	static void smethod_16(PictureBox pictureBox_1, bool bool_1)
	{
		pictureBox_1.set_TabStop(bool_1);
	}

	static void smethod_17(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_18(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_19(Form form_0, Color color_0)
	{
		form_0.set_BackColor(color_0);
	}

	static void smethod_20(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static ControlCollection smethod_21(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_22(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static Font smethod_23(string string_0, float float_1, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_1, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_24(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_25(Form form_0, FormBorderStyle formBorderStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_FormBorderStyle(formBorderStyle_0);
	}

	static void smethod_26(Form form_0, Padding padding_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_Margin(padding_0);
	}

	static void smethod_27(Form form_0, bool bool_1)
	{
		form_0.set_MaximizeBox(bool_1);
	}

	static void smethod_28(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_29(Form form_0, FormStartPosition formStartPosition_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_StartPosition(formStartPosition_0);
	}

	static void smethod_30(Form form_0, string string_0)
	{
		form_0.set_Text(string_0);
	}

	static void smethod_31(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_32(Control control_0, bool bool_1)
	{
		control_0.ResumeLayout(bool_1);
	}

	static void smethod_33(Timer timer_2, EventHandler eventHandler_0)
	{
		timer_2.remove_Tick(eventHandler_0);
	}

	static void smethod_34(Timer timer_2, EventHandler eventHandler_0)
	{
		timer_2.add_Tick(eventHandler_0);
	}

	static Process smethod_35()
	{
		return Process.GetCurrentProcess();
	}

	static void smethod_36(Process process_0, ProcessPriorityClass processPriorityClass_0)
	{
		process_0.PriorityClass = processPriorityClass_0;
	}

	static string smethod_37()
	{
		return Application.get_StartupPath();
	}

	static string smethod_38(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static Image smethod_39(string string_0)
	{
		return Image.FromFile(string_0);
	}

	static void smethod_40(Control control_0, Image image_0)
	{
		control_0.set_BackgroundImage(image_0);
	}

	static void smethod_41(Timer timer_2)
	{
		timer_2.Start();
	}

	static int smethod_42(Image image_0)
	{
		return image_0.get_Width();
	}

	static int smethod_43(Image image_0)
	{
		return image_0.get_Height();
	}

	static Bitmap smethod_44(int int_1, int int_2)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new Bitmap(int_1, int_2);
	}

	static Graphics smethod_45(Image image_0)
	{
		return Graphics.FromImage(image_0);
	}

	static ColorMatrix smethod_46()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ColorMatrix();
	}

	static void smethod_47(ColorMatrix colorMatrix_0, float float_1)
	{
		colorMatrix_0.set_Matrix33(float_1);
	}

	static ImageAttributes smethod_48()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ImageAttributes();
	}

	static void smethod_49(ImageAttributes imageAttributes_0, ColorMatrix colorMatrix_0, ColorMatrixFlag colorMatrixFlag_0, ColorAdjustType colorAdjustType_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		imageAttributes_0.SetColorMatrix(colorMatrix_0, colorMatrixFlag_0, colorAdjustType_0);
	}

	static void smethod_50(Graphics graphics_0, Image image_0, Rectangle rectangle_0, int int_1, int int_2, int int_3, int int_4, GraphicsUnit graphicsUnit_0, ImageAttributes imageAttributes_0)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		graphics_0.DrawImage(image_0, rectangle_0, int_1, int_2, int_3, int_4, graphicsUnit_0, imageAttributes_0);
	}

	static void smethod_51(Graphics graphics_0)
	{
		graphics_0.Dispose();
	}

	static void smethod_52()
	{
		GC.Collect();
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

	static void smethod_55(Timer timer_2)
	{
		timer_2.Stop();
	}

	static void smethod_56(object object_0)
	{
		GC.SuppressFinalize(object_0);
	}

	static void smethod_57(Process process_0)
	{
		process_0.Kill();
	}

	static Image smethod_58(Control control_0)
	{
		return control_0.get_BackgroundImage();
	}

	static Point smethod_59(Control control_0)
	{
		return control_0.get_Location();
	}

	static float smethod_60()
	{
		return VBMath.Rnd();
	}

	static double smethod_61(double double_0)
	{
		return Math.Round(double_0);
	}

	static int smethod_62(Control control_0)
	{
		return control_0.get_Width();
	}

	static void smethod_63(Control control_0, int int_1)
	{
		control_0.set_Width(int_1);
	}

	static int smethod_64(Control control_0)
	{
		return control_0.get_Height();
	}

	static void smethod_65(Control control_0, int int_1)
	{
		control_0.set_Height(int_1);
	}
}
