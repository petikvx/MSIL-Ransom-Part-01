using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Cytotechnologist;

public class Form3 : Form
{
	private IContainer components = null;

	private Button button1;

	private Button button2;

	private Button button4;

	private Button button5;

	private Button button7;

	private TextBox textBox1;

	private Label label1;

	private TextBox textBox2;

	private Button NullButton;

	private ErrorProvider errorProvider1;

	public Form3()
	{
		InitializeComponent();
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		Form3.smethod_0((Control)(object)NullButton);
		Form3.smethod_1(errorProvider1);
		Form val = default(Form);
		while (true)
		{
			int num = 1448297338;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x381B03D6u) % 5u)
				{
				case 4u:
				{
					Form4 form = new Form4();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					num = (int)((num2 * 762851300) ^ 0x243A7E5C);
					continue;
				}
				case 3u:
					num = ((int)num2 * -1268718975) ^ -1607094647;
					continue;
				case 1u:
					Form3.smethod_4((Control)(object)val);
					num = (int)((num2 * 1015102986) ^ 0x66A868B0);
					continue;
				case 0u:
					break;
				default:
					Form3.smethod_10(val, new Point(Form3.smethod_5((Form)(object)this).X + (Form3.smethod_6((Control)(object)this) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_5((Form)(object)this).Y + (Form3.smethod_8((Control)(object)this) - Form3.smethod_9((Control)(object)val)) / 2 + 70));
					Form3.smethod_11((Control)(object)this, bool_0: false);
					return;
				}
				break;
			}
		}
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		Form3.smethod_0((Control)(object)NullButton);
		Form2 form = new Form2();
		Form3.smethod_2((Form)(object)form, bool_0: true);
		Form3.smethod_3((Form)(object)form, (Form)(object)this);
		Form val = (Form)(object)form;
		Form3.smethod_4((Control)(object)val);
		while (true)
		{
			int num = -974813620;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF68E7AE4u) % 5u)
				{
				case 3u:
					num = (int)(num2 * 1403530899) ^ -1774911791;
					continue;
				case 2u:
					num = ((int)num2 * -713263725) ^ 0x1C9F5BDA;
					continue;
				case 1u:
					Form3.smethod_10(val, new Point(Form3.smethod_13(Form3.smethod_12((Form)(object)this)).X + (Form3.smethod_7((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_13(Form3.smethod_12((Form)(object)this)).Y + (Form3.smethod_9((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_9((Control)(object)val)) / 2));
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = (int)((num2 * 1958423665) ^ 0x57204E86);
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

	public void Button_Continue()
	{
		Form3.smethod_14((Control)(object)button5, bool_0: true);
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = Form3.smethod_8((Control)(object)this) - 1;
			Form3.smethod_15((Control)(object)this, num);
			int num2 = -618393698;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xDE80BCCAu) % 9u)
				{
				case 8u:
					Form3.smethod_17((Form3.smethod_12((Form)(object)this) as Form1).timer1);
					num2 = ((int)num3 * -70007954) ^ 0x22F91032;
					continue;
				case 7u:
					num2 = -369388418;
					continue;
				case 4u:
					Form3.smethod_16(Form3.smethod_12((Form)(object)this));
					num2 = ((int)num3 * -1471110727) ^ -1983036740;
					continue;
				case 3u:
					num2 = -1847349929;
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -444709499;
						num5 = -444709499;
					}
					else
					{
						num4 = -1927809923;
						num5 = -1927809923;
					}
					num2 = num4 ^ ((int)num3 * -284618635);
					continue;
				}
				case 1u:
					flag = num > 1;
					num2 = (int)((num3 * 709053442) ^ 0x1B15F072);
					continue;
				case 0u:
					num2 = ((int)num3 * -1234456817) ^ 0x555022DB;
					continue;
				default:
					return;
				case 5u:
					break;
				case 6u:
					return;
				}
				break;
			}
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
	}

	private void TextBox_TextChanged(object sender, EventArgs e)
	{
		Form3.smethod_1(errorProvider1);
	}

	public void ContinueLock()
	{
		Form3.smethod_14((Control)(object)button5, bool_0: false);
		while (true)
		{
			int num = 779711523;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3AD13B7Au) % 3u)
				{
				case 2u:
					goto IL_000e;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_000e:
				num = ((int)num2 * -1726543955) ^ -1637723558;
			}
		}
	}

	public void AchivUnlock()
	{
		Form3.smethod_14((Control)(object)button7, bool_0: true);
	}

	private void Button7_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 151540695;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4F057056u) % 3u)
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
				Form3.smethod_0((Control)(object)NullButton);
				Form3.smethod_14((Control)(object)button7, bool_0: false);
				num = ((int)num2 * -478320498) ^ -1816630191;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = 224936549;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x6804E44Du) % 9u)
				{
				case 8u:
					num3 = ((components != null) ? 1 : 0);
					goto IL_000f;
				case 7u:
					num = (int)((num2 * 1877807721) ^ 0x24AF736);
					continue;
				case 6u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1177265578;
						num5 = -1177265578;
					}
					else
					{
						num4 = -1797741866;
						num5 = -1797741866;
					}
					num = num4 ^ ((int)num2 * -838743749);
					continue;
				}
				case 5u:
					((Form)this).Dispose(disposing);
					num = 982365277;
					continue;
				case 4u:
					if (disposing)
					{
						num = ((int)num2 * -1431697100) ^ 0x6EBDC570;
						continue;
					}
					num3 = 0;
					goto IL_000f;
				case 2u:
					num = ((int)num2 * -810225804) ^ -86965048;
					continue;
				case 1u:
					Form3.smethod_18((IDisposable)components);
					num = (int)(num2 * 1243954191) ^ -1948104901;
					continue;
				default:
					return;
				case 3u:
					break;
				case 0u:
					return;
					IL_000f:
					flag = (byte)num3 != 0;
					num = 1071070887;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		while (true)
		{
			int num = -1469241820;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8B89311Du) % 125u)
				{
				case 124u:
					num = ((int)num2 * -64028837) ^ -1046857584;
					continue;
				case 123u:
					num = (int)(num2 * 107948827) ^ -1058362337;
					continue;
				case 122u:
					Form3.smethod_44((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 1349909845) ^ -546680573;
					continue;
				case 121u:
					Form3.smethod_50((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1471999158) ^ -1487516137;
					continue;
				case 120u:
					Form3.smethod_30((Control)(object)textBox2, new Point(174, 26));
					num = ((int)num2 * -1058718951) ^ 0x56A889AB;
					continue;
				case 119u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -1964406325) ^ 0x35DC38A1;
					continue;
				case 118u:
					Form3.smethod_32((Control)(object)button7, new Size(140, 50));
					num = ((int)num2 * -904294091) ^ 0x6BB3893B;
					continue;
				case 117u:
					Form3.smethod_30((Control)(object)button1, new Point(265, 49));
					num = (int)((num2 * 1809815494) ^ 0x829210A);
					continue;
				case 116u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox2);
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox1);
					num = ((int)num2 * -891565998) ^ 0x42451459;
					continue;
				case 115u:
					num = ((int)num2 * -720937767) ^ -1716403629;
					continue;
				case 114u:
					Form3.smethod_39((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					Form3.smethod_40((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -1348331864) ^ -1482060112;
					continue;
				case 113u:
					Form3.smethod_26((Control)(object)NullButton, Color.Transparent);
					num = (int)(num2 * 310251527) ^ -1787752628;
					continue;
				case 112u:
					Form3.smethod_45((Form)(object)this, new Size(486, 296));
					num = ((int)num2 * -936155730) ^ 0x335D5720;
					continue;
				case 111u:
					num = (int)((num2 * 427861950) ^ 0x7B160752);
					continue;
				case 110u:
					num = (int)((num2 * 1369124528) ^ 0x609484C);
					continue;
				case 109u:
					num = ((int)num2 * -1982011125) ^ -2096664814;
					continue;
				case 108u:
					num = ((int)num2 * -890079433) ^ -1855784696;
					continue;
				case 107u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button2);
					num = (int)(num2 * 1004429440) ^ -1835486560;
					continue;
				case 106u:
					button7 = Form3.smethod_20();
					num = (int)((num2 * 1330738384) ^ 0x61DC5808);
					continue;
				case 105u:
					Form3.smethod_32((Control)(object)label1, new Size(207, 76));
					num = (int)((num2 * 1487183520) ^ 0x2C5FB1F8);
					continue;
				case 104u:
					Form3.smethod_35((Control)(object)button4, "Начало игры");
					Form3.smethod_34((ButtonBase)(object)button4, bool_0: true);
					num = (int)((num2 * 1941278282) ^ 0x5554D887);
					continue;
				case 103u:
					Form3.smethod_31((Control)(object)button2, "button2");
					num = (int)(num2 * 974228553) ^ -1082567792;
					continue;
				case 102u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button5), 0);
					num = (int)(num2 * 1269990255) ^ -1542204345;
					continue;
				case 101u:
					Form3.smethod_33((Control)(object)label1, 7);
					num = (int)(num2 * 158107523) ^ -522550872;
					continue;
				case 100u:
					Form3.smethod_53((Form)(object)this, bool_0: false);
					Form3.smethod_54((Form)(object)this, bool_0: true);
					num = (int)(num2 * 932703264) ^ -828545576;
					continue;
				case 99u:
					Form3.smethod_49((Form)(object)this, bool_0: false);
					num = (int)((num2 * 1481200051) ^ 0x1F8FD6EB);
					continue;
				case 98u:
					Form3.smethod_29((ButtonBase)(object)button7, (FlatStyle)0);
					num = (int)(num2 * 644027078) ^ -1613505566;
					continue;
				case 97u:
					Form3.smethod_55((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -1545289899) ^ -1211009443;
					continue;
				case 96u:
					num = ((int)num2 * -884657892) ^ 0x3CEA80CB;
					continue;
				case 95u:
					Form3.smethod_31((Control)(object)textBox1, "textBox1");
					num = ((int)num2 * -2147301096) ^ -41349415;
					continue;
				case 94u:
					num = (int)((num2 * 263214314) ^ 0x6E5AC4D5);
					continue;
				case 93u:
					num = (int)(num2 * 1459729421) ^ -1173622831;
					continue;
				case 92u:
					num = (int)(num2 * 1222192256) ^ -509480435;
					continue;
				case 91u:
					Form3.smethod_38((Control)(object)button7, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 946836669) ^ -464701571;
					continue;
				case 90u:
					num = ((int)num2 * -1288039863) ^ -835822622;
					continue;
				case 89u:
					Form3.smethod_31((Control)(object)button7, "button7");
					num = (int)((num2 * 308492550) ^ 0x12F03532);
					continue;
				case 88u:
					components = Form3.smethod_19();
					num = (int)((num2 * 1693863565) ^ 0x317DF39F);
					continue;
				case 87u:
					num = (int)(num2 * 1361306223) ^ -675301784;
					continue;
				case 86u:
					Form3.smethod_31((Control)(object)textBox2, "textBox2");
					num = ((int)num2 * -2022055307) ^ 0x6F979596;
					continue;
				case 85u:
					Form3.smethod_33((Control)(object)button2, 1);
					Form3.smethod_35((Control)(object)button2, "Регистрация");
					num = ((int)num2 * -809157969) ^ -184605821;
					continue;
				case 83u:
					num = ((int)num2 * -1711787985) ^ -784065386;
					continue;
				case 82u:
					Form3.smethod_51((Control)(object)this, "Form3");
					num = ((int)num2 * -1550287443) ^ -1223512020;
					continue;
				case 81u:
					Form3.smethod_30((Control)(object)NullButton, new Point(-1, -1));
					num = ((int)num2 * -398613474) ^ -681217628;
					continue;
				case 79u:
					num = ((int)num2 * -237546044) ^ -679313671;
					continue;
				case 78u:
					num = ((int)num2 * -949476150) ^ 0x2119028F;
					continue;
				case 77u:
					Form3.smethod_57((Control)(object)this);
					num = (int)(num2 * 620179812) ^ -143514657;
					continue;
				case 76u:
					Form3.smethod_30((Control)(object)button7, new Point(174, 243));
					num = ((int)num2 * -2045116254) ^ 0x73FAA765;
					continue;
				case 75u:
					num = ((int)num2 * -454011696) ^ 0x20677ED0;
					continue;
				case 74u:
					Form3.smethod_31((Control)(object)button4, "button4");
					Form3.smethod_32((Control)(object)button4, new Size(140, 50));
					num = (int)(num2 * 1128369672) ^ -670410194;
					continue;
				case 73u:
					Form3.smethod_30((Control)(object)button4, new Point(174, 137));
					num = ((int)num2 * -363944619) ^ 0x3635863A;
					continue;
				case 72u:
					num = (int)((num2 * 1282338358) ^ 0x5F997839);
					continue;
				case 71u:
					Form3.smethod_26((Control)(object)this, Color.White);
					num = ((int)num2 * -405966852) ^ -1887517909;
					continue;
				case 70u:
					Form3.smethod_31((Control)(object)button5, "button5");
					Form3.smethod_32((Control)(object)button5, new Size(140, 50));
					num = ((int)num2 * -1835818561) ^ -1719749346;
					continue;
				case 69u:
					Form3.smethod_34((ButtonBase)(object)button5, bool_0: true);
					num = ((int)num2 * -1695931931) ^ 0x53405F0;
					continue;
				case 68u:
					Form3.smethod_33((Control)(object)textBox2, 8);
					num = ((int)num2 * -1051925236) ^ -1470451298;
					continue;
				case 67u:
					num = ((int)num2 * -1307612971) ^ -1017882655;
					continue;
				case 66u:
					Form3.smethod_33((Control)(object)button5, 5);
					num = ((int)num2 * -1139653188) ^ 0x5986AE6C;
					continue;
				case 65u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button7), 0);
					num = ((int)num2 * -1952511245) ^ -1898876423;
					continue;
				case 64u:
					textBox1 = Form3.smethod_21();
					label1 = Form3.smethod_22();
					textBox2 = Form3.smethod_21();
					errorProvider1 = Form3.smethod_23(components);
					num = (int)((num2 * 1100244565) ^ 0x359588D9);
					continue;
				case 63u:
					Form3.smethod_31((Control)(object)label1, "label1");
					num = ((int)num2 * -365517968) ^ 0x7FC17B6D;
					continue;
				case 62u:
					Form3.smethod_29((ButtonBase)(object)NullButton, (FlatStyle)0);
					num = ((int)num2 * -871172118) ^ -399910032;
					continue;
				case 61u:
					Form3.smethod_34((ButtonBase)(object)NullButton, bool_0: false);
					num = ((int)num2 * -454900276) ^ -2102101880;
					continue;
				case 60u:
					Form3.smethod_36((Control)(object)button4, (EventHandler)Button4_Click);
					num = ((int)num2 * -330048648) ^ -727705472;
					continue;
				case 59u:
					Form3.smethod_36((Control)(object)button2, (EventHandler)Button2_Click);
					num = ((int)num2 * -1200541031) ^ 0x5F54DE42;
					continue;
				case 58u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)NullButton);
					num = ((int)num2 * -1767948745) ^ 0xFC7E9BC;
					continue;
				case 57u:
					Form3.smethod_29((ButtonBase)(object)button4, (FlatStyle)0);
					Form3.smethod_38((Control)(object)button4, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 1944863817) ^ -1559091820;
					continue;
				case 56u:
					num = (int)(num2 * 353333587) ^ -621612440;
					continue;
				case 55u:
					Form3.smethod_35((Control)(object)button5, "Продолжить");
					num = ((int)num2 * -1643987530) ^ 0x77E4DF2F;
					continue;
				case 54u:
					Form3.smethod_31((Control)(object)button1, "button1");
					Form3.smethod_32((Control)(object)button1, new Size(49, 21));
					Form3.smethod_33((Control)(object)button1, 0);
					Form3.smethod_35((Control)(object)button1, "Вход");
					Form3.smethod_34((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -1631148977) ^ -518807554;
					continue;
				case 53u:
					Form3.smethod_36((Control)(object)button5, (EventHandler)Button5_Click);
					num = (int)((num2 * 978919807) ^ 0x780091D);
					continue;
				case 52u:
					Form3.smethod_39((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					Form3.smethod_42(errorProvider1, (ContainerControl)(object)this);
					Form3.smethod_43((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -162135933) ^ -1040391469;
					continue;
				case 51u:
					Form3.smethod_30((Control)(object)label1, new Point(140, 70));
					num = (int)((num2 * 891289263) ^ 0x4F30C151);
					continue;
				case 50u:
					Form3.smethod_34((ButtonBase)(object)button2, bool_0: true);
					num = (int)(num2 * 1429474046) ^ -1709021500;
					continue;
				case 49u:
					Form3.smethod_33((Control)(object)button4, 4);
					num = ((int)num2 * -966006367) ^ -1606192301;
					continue;
				case 48u:
					num = (int)((num2 * 1995282247) ^ 0x7099CC8D);
					continue;
				case 47u:
					num = ((int)num2 * -1866016832) ^ 0x66F18CA0;
					continue;
				case 46u:
					Form3.smethod_32((Control)(object)NullButton, new Size(1, 1));
					num = (int)((num2 * 2104055199) ^ 0x491351AA);
					continue;
				case 45u:
					num = ((int)num2 * -1332334466) ^ -756489080;
					continue;
				case 44u:
					num = ((int)num2 * -806708351) ^ -335073700;
					continue;
				case 43u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)NullButton), 0);
					num = ((int)num2 * -824394809) ^ 0x380803F1;
					continue;
				case 42u:
					Form3.smethod_33((Control)(object)button7, 6);
					num = ((int)num2 * -1442541548) ^ -699713696;
					continue;
				case 41u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button4);
					num = (int)((num2 * 1530838019) ^ 0x493BE93C);
					continue;
				case 40u:
					NullButton = Form3.smethod_20();
					button1 = Form3.smethod_20();
					button2 = Form3.smethod_20();
					num = (int)(num2 * 1412984919) ^ -907459580;
					continue;
				case 39u:
					Form3.smethod_32((Control)(object)button2, new Size(85, 21));
					num = ((int)num2 * -1657595212) ^ -664623702;
					continue;
				case 38u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button7);
					num = (int)(num2 * 528124870) ^ -265561491;
					continue;
				case 37u:
					Form3.smethod_25((Control)(object)this);
					num = (int)((num2 * 1692008416) ^ 0xB2AEF7C);
					continue;
				case 36u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button5);
					num = ((int)num2 * -1426064548) ^ 0x58DF8D68;
					continue;
				case 35u:
					Form3.smethod_41(textBox2, bool_0: true);
					num = ((int)num2 * -1123904093) ^ -712389119;
					continue;
				case 34u:
					Form3.smethod_56((Control)(object)this, bool_0: false);
					num = (int)((num2 * 217755874) ^ 0x7FDF5307);
					continue;
				case 33u:
					num = (int)((num2 * 611792282) ^ 0x348AEEFE);
					continue;
				case 32u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -1975138017) ^ -1095976342;
					continue;
				case 31u:
					num = ((int)num2 * -632432753) ^ 0x1818CC0B;
					continue;
				case 30u:
					Form3.smethod_35((Control)(object)button7, "Достижения");
					num = (int)(num2 * 1021110644) ^ -1354566574;
					continue;
				case 29u:
					Form3.smethod_29((ButtonBase)(object)button5, (FlatStyle)0);
					num = (int)(num2 * 1497320031) ^ -1865215193;
					continue;
				case 28u:
					Form3.smethod_14((Control)(object)button4, bool_0: false);
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button4), 0);
					num = (int)((num2 * 1208589897) ^ 0x7158520A);
					continue;
				case 27u:
					Form3.smethod_32((Control)(object)textBox1, new Size(140, 20));
					num = ((int)num2 * -660897318) ^ -2081151746;
					continue;
				case 26u:
					Form3.smethod_48((Form)(object)this, (FormBorderStyle)0);
					num = (int)((num2 * 421038778) ^ 0x2DB7C12F);
					continue;
				case 25u:
					num = ((int)num2 * -1818616334) ^ 0x73A4A0D8;
					continue;
				case 24u:
					Form3.smethod_14((Control)(object)button5, bool_0: false);
					num = ((int)num2 * -798011192) ^ 0x3EA83462;
					continue;
				case 23u:
					num = (int)((num2 * 1187792971) ^ 0x253A9BB1);
					continue;
				case 22u:
					num = ((int)num2 * -82110055) ^ -684143199;
					continue;
				case 21u:
					Form3.smethod_52((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1347034798) ^ -1603737491;
					continue;
				case 20u:
					button4 = Form3.smethod_20();
					button5 = Form3.smethod_20();
					num = ((int)num2 * -705868643) ^ 0x43AE893C;
					continue;
				case 19u:
					Form3.smethod_26((Control)(object)label1, Color.Transparent);
					num = (int)((num2 * 701985537) ^ 0x28C26BEF);
					continue;
				case 18u:
					num = (int)((num2 * 95850142) ^ 0x6E6F6261);
					continue;
				case 17u:
					Form3.smethod_36((Control)(object)button7, (EventHandler)Button7_Click);
					Form3.smethod_30((Control)(object)textBox1, new Point(174, 2));
					num = ((int)num2 * -1471889171) ^ 0xB5BFA2A;
					continue;
				case 16u:
					num = (int)((num2 * 481927920) ^ 0x348A0891);
					continue;
				case 15u:
					Form3.smethod_24((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -1680761355) ^ 0x4E2ECB90;
					continue;
				case 14u:
					Form3.smethod_36((Control)(object)button1, (EventHandler)Button1_Click);
					Form3.smethod_30((Control)(object)button2, new Point(174, 49));
					num = (int)((num2 * 1033616106) ^ 0x40147A89);
					continue;
				case 13u:
					Form3.smethod_33((Control)(object)textBox1, 7);
					num = (int)(num2 * 77703559) ^ -424077072;
					continue;
				case 12u:
					Form3.smethod_32((Control)(object)textBox2, new Size(140, 20));
					num = (int)((num2 * 1998595055) ^ 0x1977F269);
					continue;
				case 11u:
					Form3.smethod_38((Control)(object)button5, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -484361408) ^ -686211822;
					continue;
				case 10u:
					Form3.smethod_35((Control)(object)label1, "QUARTO");
					num = (int)(num2 * 762160811) ^ -702611268;
					continue;
				case 9u:
					num = ((int)num2 * -984035626) ^ 0x3C1F8B49;
					continue;
				case 8u:
					Form3.smethod_31((Control)(object)NullButton, "NullButton");
					num = (int)((num2 * 724209601) ^ 0x198EBD8C);
					continue;
				case 7u:
					num = (int)((num2 * 1735281994) ^ 0x203852E1);
					continue;
				case 6u:
					Form3.smethod_30((Control)(object)button5, new Point(174, 190));
					num = (int)(num2 * 59391506) ^ -1439891752;
					continue;
				case 5u:
					num = ((int)num2 * -1373369623) ^ -1260389638;
					continue;
				case 4u:
					num = (int)((num2 * 473526244) ^ 0x4179334A);
					continue;
				case 3u:
					num = ((int)num2 * -1023133927) ^ 0x3B7D0531;
					continue;
				case 2u:
					Form3.smethod_38((Control)(object)label1, Form3.smethod_37("Mistral", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 858714643) ^ -884042719;
					continue;
				case 1u:
					Form3.smethod_33((Control)(object)NullButton, 3);
					num = ((int)num2 * -2112245186) ^ -950775703;
					continue;
				case 0u:
					Form3.smethod_34((ButtonBase)(object)button7, bool_0: true);
					num = (int)((num2 * 65175679) ^ 0xFD47095);
					continue;
				default:
					return;
				case 84u:
					break;
				case 80u:
					return;
				}
				break;
			}
		}
	}

	static bool smethod_0(Control control_0)
	{
		return control_0.Focus();
	}

	static void smethod_1(ErrorProvider errorProvider_0)
	{
		errorProvider_0.Clear();
	}

	static void smethod_2(Form form_0, bool bool_0)
	{
		form_0.set_TopMost(bool_0);
	}

	static void smethod_3(Form form_0, Form form_1)
	{
		form_0.set_Owner(form_1);
	}

	static void smethod_4(Control control_0)
	{
		control_0.Show();
	}

	static Point smethod_5(Form form_0)
	{
		return form_0.get_Location();
	}

	static int smethod_6(Control control_0)
	{
		return control_0.get_Width();
	}

	static int smethod_7(Control control_0)
	{
		return control_0.get_Width();
	}

	static int smethod_8(Control control_0)
	{
		return control_0.get_Height();
	}

	static int smethod_9(Control control_0)
	{
		return control_0.get_Height();
	}

	static void smethod_10(Form form_0, Point point_0)
	{
		form_0.set_Location(point_0);
	}

	static void smethod_11(Control control_0, bool bool_0)
	{
		control_0.set_Enabled(bool_0);
	}

	static Form smethod_12(Form form_0)
	{
		return form_0.get_Owner();
	}

	static Point smethod_13(Form form_0)
	{
		return form_0.get_Location();
	}

	static void smethod_14(Control control_0, bool bool_0)
	{
		control_0.set_Enabled(bool_0);
	}

	static void smethod_15(Control control_0, int int_0)
	{
		control_0.set_Height(int_0);
	}

	static void smethod_16(Form form_0)
	{
		form_0.Activate();
	}

	static void smethod_17(Timer timer_0)
	{
		timer_0.Start();
	}

	static void smethod_18(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Container smethod_19()
	{
		return new Container();
	}

	static Button smethod_20()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
	}

	static TextBox smethod_21()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TextBox();
	}

	static Label smethod_22()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Label();
	}

	static ErrorProvider smethod_23(IContainer icontainer_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new ErrorProvider(icontainer_0);
	}

	static void smethod_24(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.BeginInit();
	}

	static void smethod_25(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_26(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static FlatButtonAppearance smethod_27(ButtonBase buttonBase_0)
	{
		return buttonBase_0.get_FlatAppearance();
	}

	static void smethod_28(FlatButtonAppearance flatButtonAppearance_0, int int_0)
	{
		flatButtonAppearance_0.set_BorderSize(int_0);
	}

	static void smethod_29(ButtonBase buttonBase_0, FlatStyle flatStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		buttonBase_0.set_FlatStyle(flatStyle_0);
	}

	static void smethod_30(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_31(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_32(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_33(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_34(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_UseVisualStyleBackColor(bool_0);
	}

	static void smethod_35(Control control_0, string string_0)
	{
		control_0.set_Text(string_0);
	}

	static void smethod_36(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static Font smethod_37(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_38(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_39(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_TextChanged(eventHandler_0);
	}

	static void smethod_40(Control control_0, bool bool_0)
	{
		control_0.set_AutoSize(bool_0);
	}

	static void smethod_41(TextBox textBox_0, bool bool_0)
	{
		textBox_0.set_UseSystemPasswordChar(bool_0);
	}

	static void smethod_42(ErrorProvider errorProvider_0, ContainerControl containerControl_0)
	{
		errorProvider_0.set_ContainerControl(containerControl_0);
	}

	static void smethod_43(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_44(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_45(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static ControlCollection smethod_46(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_47(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_48(Form form_0, FormBorderStyle formBorderStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_FormBorderStyle(formBorderStyle_0);
	}

	static void smethod_49(Form form_0, bool bool_0)
	{
		form_0.set_MaximizeBox(bool_0);
	}

	static void smethod_50(Form form_0, bool bool_0)
	{
		form_0.set_MinimizeBox(bool_0);
	}

	static void smethod_51(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_52(Form form_0, bool bool_0)
	{
		form_0.set_ShowIcon(bool_0);
	}

	static void smethod_53(Form form_0, bool bool_0)
	{
		form_0.set_ShowInTaskbar(bool_0);
	}

	static void smethod_54(Form form_0, bool bool_0)
	{
		form_0.set_TopMost(bool_0);
	}

	static void smethod_55(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_56(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_57(Control control_0)
	{
		control_0.PerformLayout();
	}
}
