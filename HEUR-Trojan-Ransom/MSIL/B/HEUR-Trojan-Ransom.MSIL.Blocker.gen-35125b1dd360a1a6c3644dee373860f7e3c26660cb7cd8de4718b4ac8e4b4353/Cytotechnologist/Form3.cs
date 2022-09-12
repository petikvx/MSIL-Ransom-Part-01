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
			int num = 976241331;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x57E7F2D0u) % 7u)
				{
				case 6u:
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = ((int)num2 * -1420300331) ^ 0x6D32C76E;
					continue;
				case 5u:
					num = ((int)num2 * -607002702) ^ -1955388514;
					continue;
				case 4u:
					num = (int)((num2 * 1214585813) ^ 0x3B1D870F);
					continue;
				case 2u:
				{
					Form4 form = new Form4();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					Form3.smethod_4((Control)(object)val);
					num = (int)((num2 * 504041171) ^ 0x7DBF2AEC);
					continue;
				}
				case 1u:
					Form3.smethod_10(val, new Point(Form3.smethod_5((Form)(object)this).X + (Form3.smethod_6((Control)(object)this) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_5((Form)(object)this).Y + (Form3.smethod_8((Control)(object)this) - Form3.smethod_9((Control)(object)val)) / 2 + 70));
					num = (int)(num2 * 669895185) ^ -1136112766;
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

	private void Button4_Click(object sender, EventArgs e)
	{
		Form val = default(Form);
		while (true)
		{
			int num = -826381758;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8096E1E9u) % 5u)
				{
				case 3u:
				{
					Form3.smethod_0((Control)(object)NullButton);
					Form2 form = new Form2();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					num = (int)(num2 * 1161359212) ^ -1998569016;
					continue;
				}
				case 2u:
					Form3.smethod_10(val, new Point(Form3.smethod_13(Form3.smethod_12((Form)(object)this)).X + (Form3.smethod_7((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_13(Form3.smethod_12((Form)(object)this)).Y + (Form3.smethod_9((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_9((Control)(object)val)) / 2));
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = (int)(num2 * 498878962) ^ -1832067349;
					continue;
				case 1u:
					Form3.smethod_4((Control)(object)val);
					num = ((int)num2 * -1198711136) ^ -2111391973;
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
		int num5 = default(int);
		while (true)
		{
			int num = -1658584450;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF928C2B1u) % 10u)
				{
				case 9u:
					flag = num5 > 1;
					num = ((int)num2 * -1673734775) ^ -1079440484;
					continue;
				case 8u:
					num5 = Form3.smethod_8((Control)(object)this) - 1;
					num = -1570194429;
					continue;
				case 7u:
					Form3.smethod_17((Form3.smethod_12((Form)(object)this) as Form1).timer1);
					num = (int)((num2 * 1043677419) ^ 0x5D46C3AB);
					continue;
				case 6u:
					Form3.smethod_16(Form3.smethod_12((Form)(object)this));
					num = (int)(num2 * 1813610647) ^ -1547793686;
					continue;
				case 4u:
					Form3.smethod_15((Control)(object)this, num5);
					num = (int)(num2 * 236511939) ^ -1706260686;
					continue;
				case 3u:
					num = -1835750631;
					continue;
				case 1u:
					num = ((int)num2 * -614846087) ^ 0xA206BCE;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 425148947;
						num4 = 425148947;
					}
					else
					{
						num3 = 303779866;
						num4 = 303779866;
					}
					num = num3 ^ (int)(num2 * 525989983);
					continue;
				}
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
	}

	public void AchivUnlock()
	{
		Form3.smethod_14((Control)(object)button7, bool_0: true);
		while (true)
		{
			int num = -2057762405;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x96459A6Eu) % 3u)
				{
				case 1u:
					goto IL_000e;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_000e:
				num = ((int)num2 * -726084341) ^ 0x108E9F23;
			}
		}
	}

	private void Button7_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 1667033120;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x518093F1u) % 4u)
				{
				case 2u:
					Form3.smethod_14((Control)(object)button7, bool_0: false);
					num = ((int)num2 * -2010510890) ^ -947330475;
					continue;
				case 1u:
					Form3.smethod_0((Control)(object)NullButton);
					num = (int)(num2 * 72987498) ^ -538376831;
					continue;
				default:
					return;
				case 3u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			goto IL_0073;
		}
		int num = 0;
		goto IL_00b2;
		IL_00a9:
		num = ((components != null) ? 1 : 0);
		goto IL_00b2;
		IL_0073:
		int num2 = -317966246;
		goto IL_0078;
		IL_0078:
		bool flag = default(bool);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0xCEA10299u) % 8u)
			{
			case 7u:
				((Form)this).Dispose(disposing);
				num2 = -2104117139;
				continue;
			case 6u:
				num2 = ((int)num3 * -1078529004) ^ 0x5602F668;
				continue;
			case 5u:
			{
				int num4;
				int num5;
				if (flag)
				{
					num4 = 881974873;
					num5 = 881974873;
				}
				else
				{
					num4 = 1007685360;
					num5 = 1007685360;
				}
				num2 = num4 ^ ((int)num3 * -1429028186);
				continue;
			}
			case 2u:
				num2 = ((int)num3 * -854994512) ^ 0x2ED8585E;
				continue;
			case 1u:
				Form3.smethod_18((IDisposable)components);
				num2 = (int)(num3 * 822503051) ^ -1623459856;
				continue;
			case 0u:
				break;
			default:
				return;
			case 3u:
				goto IL_00a9;
			case 4u:
				return;
			}
			break;
		}
		goto IL_0073;
		IL_00b2:
		flag = (byte)num != 0;
		num2 = -1701325884;
		goto IL_0078;
	}

	private void InitializeComponent()
	{
		while (true)
		{
			int num = 626802563;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5F49E580u) % 137u)
				{
				case 136u:
					num = ((int)num2 * -1301892981) ^ -635800231;
					continue;
				case 135u:
					Form3.smethod_32((Control)(object)textBox2, new Size(140, 20));
					num = ((int)num2 * -1553820166) ^ -1332221227;
					continue;
				case 134u:
					num = (int)(num2 * 945437845) ^ -1760146674;
					continue;
				case 133u:
					Form3.smethod_35((Control)(object)label1, "QUARTO");
					num = ((int)num2 * -248354355) ^ -1292971691;
					continue;
				case 132u:
					Form3.smethod_36((Control)(object)button2, (EventHandler)Button2_Click);
					num = ((int)num2 * -1454999713) ^ -1214681349;
					continue;
				case 131u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -1923349025) ^ -1562657027;
					continue;
				case 130u:
					num = ((int)num2 * -122574234) ^ -2012612675;
					continue;
				case 129u:
					Form3.smethod_32((Control)(object)NullButton, new Size(1, 1));
					Form3.smethod_33((Control)(object)NullButton, 3);
					num = ((int)num2 * -1191457685) ^ -2004387631;
					continue;
				case 128u:
					num = ((int)num2 * -1345716810) ^ -1865542038;
					continue;
				case 127u:
					num = ((int)num2 * -1991888995) ^ -661928678;
					continue;
				case 125u:
					Form3.smethod_52((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1768421187) ^ -1297719407;
					continue;
				case 124u:
					num = ((int)num2 * -1821736078) ^ 0x2C8E2A1C;
					continue;
				case 123u:
					Form3.smethod_31((Control)(object)label1, "label1");
					num = ((int)num2 * -399583325) ^ 0x22EBAD59;
					continue;
				case 122u:
					num = (int)((num2 * 378424792) ^ 0x6C53E80B);
					continue;
				case 121u:
					num = ((int)num2 * -664807371) ^ -35731995;
					continue;
				case 120u:
					num = (int)((num2 * 2039606493) ^ 0xE304BBE);
					continue;
				case 119u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button2);
					num = ((int)num2 * -1674965821) ^ 0x6C98F915;
					continue;
				case 118u:
					num = (int)((num2 * 237849504) ^ 0x3B91B138);
					continue;
				case 117u:
					Form3.smethod_35((Control)(object)button1, "Вход");
					num = (int)((num2 * 1724791283) ^ 0x1328E1BE);
					continue;
				case 116u:
					Form3.smethod_31((Control)(object)NullButton, "NullButton");
					num = ((int)num2 * -1407817987) ^ 0x2AA8E320;
					continue;
				case 115u:
					Form3.smethod_42(errorProvider1, (ContainerControl)(object)this);
					num = ((int)num2 * -1004603812) ^ -715628850;
					continue;
				case 114u:
					Form3.smethod_45((Form)(object)this, new Size(486, 296));
					num = ((int)num2 * -461162225) ^ 0x3FC06233;
					continue;
				case 113u:
					num = (int)((num2 * 838671613) ^ 0x4FA90B8);
					continue;
				case 112u:
					Form3.smethod_31((Control)(object)textBox1, "textBox1");
					num = ((int)num2 * -1217578971) ^ -1944058709;
					continue;
				case 111u:
					Form3.smethod_33((Control)(object)textBox1, 7);
					num = ((int)num2 * -594319464) ^ 0x6DD8E533;
					continue;
				case 110u:
					Form3.smethod_35((Control)(object)button2, "Регистрация");
					num = (int)((num2 * 543129964) ^ 0x6338870D);
					continue;
				case 109u:
					Form3.smethod_29((ButtonBase)(object)button4, (FlatStyle)0);
					num = ((int)num2 * -822427239) ^ -1606443028;
					continue;
				case 108u:
					button1 = Form3.smethod_20();
					num = ((int)num2 * -1653465918) ^ 0x57F7E03B;
					continue;
				case 107u:
					button7 = Form3.smethod_20();
					textBox1 = Form3.smethod_21();
					num = ((int)num2 * -1933691011) ^ -945724136;
					continue;
				case 106u:
					button2 = Form3.smethod_20();
					button4 = Form3.smethod_20();
					button5 = Form3.smethod_20();
					num = ((int)num2 * -883598440) ^ 0x2A845708;
					continue;
				case 105u:
					Form3.smethod_33((Control)(object)button2, 1);
					num = (int)(num2 * 961878337) ^ -260560929;
					continue;
				case 104u:
					Form3.smethod_36((Control)(object)button5, (EventHandler)Button5_Click);
					num = ((int)num2 * -529426395) ^ 0x7AB33306;
					continue;
				case 103u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)NullButton), 0);
					num = (int)(num2 * 212872974) ^ -248069529;
					continue;
				case 102u:
					num = ((int)num2 * -1807698601) ^ 0x1DB8EC93;
					continue;
				case 101u:
					num = ((int)num2 * -1201597171) ^ 0x1A6D0E3B;
					continue;
				case 100u:
					num = ((int)num2 * -1373876769) ^ -335743012;
					continue;
				case 99u:
					Form3.smethod_29((ButtonBase)(object)button5, (FlatStyle)0);
					num = ((int)num2 * -1279206813) ^ 0x6A29E36B;
					continue;
				case 98u:
					Form3.smethod_35((Control)(object)button5, "Продолжить");
					num = ((int)num2 * -825549614) ^ -230625606;
					continue;
				case 97u:
					num = (int)(num2 * 1157609608) ^ -303470149;
					continue;
				case 96u:
					num = ((int)num2 * -1066254301) ^ -1602507655;
					continue;
				case 95u:
					Form3.smethod_39((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = (int)(num2 * 671838461) ^ -379616294;
					continue;
				case 94u:
					Form3.smethod_29((ButtonBase)(object)NullButton, (FlatStyle)0);
					Form3.smethod_30((Control)(object)NullButton, new Point(-1, -1));
					num = ((int)num2 * -440122952) ^ 0x75B3DCB0;
					continue;
				case 93u:
					Form3.smethod_31((Control)(object)button1, "button1");
					num = (int)(num2 * 493944260) ^ -1994719044;
					continue;
				case 92u:
					Form3.smethod_30((Control)(object)button5, new Point(174, 190));
					num = (int)(num2 * 1156883681) ^ -765068156;
					continue;
				case 91u:
					Form3.smethod_30((Control)(object)textBox2, new Point(174, 26));
					num = ((int)num2 * -976619408) ^ 0x2863503A;
					continue;
				case 90u:
					Form3.smethod_32((Control)(object)button7, new Size(140, 50));
					num = (int)(num2 * 393312539) ^ -1751164491;
					continue;
				case 89u:
					Form3.smethod_32((Control)(object)label1, new Size(207, 76));
					Form3.smethod_33((Control)(object)label1, 7);
					num = ((int)num2 * -843492223) ^ -1243365386;
					continue;
				case 88u:
					NullButton = Form3.smethod_20();
					num = ((int)num2 * -58456784) ^ 0x1442FB45;
					continue;
				case 86u:
					num = ((int)num2 * -947528386) ^ 0x5E377496;
					continue;
				case 85u:
					Form3.smethod_30((Control)(object)label1, new Point(140, 70));
					num = (int)(num2 * 77137243) ^ -1338352958;
					continue;
				case 84u:
					num = (int)((num2 * 353167121) ^ 0xCBE5638);
					continue;
				case 83u:
					Form3.smethod_53((Form)(object)this, bool_0: false);
					Form3.smethod_54((Form)(object)this, bool_0: true);
					num = (int)((num2 * 532262735) ^ 0x7BC90BBC);
					continue;
				case 82u:
					Form3.smethod_51((Control)(object)this, "Form3");
					num = ((int)num2 * -357034773) ^ 0x4629ED6;
					continue;
				case 81u:
					Form3.smethod_32((Control)(object)button2, new Size(85, 21));
					num = ((int)num2 * -432540350) ^ 0x5889AA88;
					continue;
				case 80u:
					components = Form3.smethod_19();
					num = ((int)num2 * -505575512) ^ 0x5F290224;
					continue;
				case 79u:
					Form3.smethod_57((Control)(object)this);
					num = (int)(num2 * 1539409023) ^ -1686053955;
					continue;
				case 78u:
					num = ((int)num2 * -1068292818) ^ -1432477767;
					continue;
				case 77u:
					num = (int)(num2 * 177978169) ^ -1746282874;
					continue;
				case 76u:
					Form3.smethod_26((Control)(object)NullButton, Color.Transparent);
					num = (int)(num2 * 666851620) ^ -1626247220;
					continue;
				case 75u:
					Form3.smethod_38((Control)(object)button4, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 164322261) ^ 0x3F89CC33);
					continue;
				case 74u:
					Form3.smethod_38((Control)(object)button7, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 1120935381) ^ 0x44810238);
					continue;
				case 73u:
					Form3.smethod_30((Control)(object)button4, new Point(174, 137));
					num = (int)((num2 * 1151843679) ^ 0x6C028842);
					continue;
				case 72u:
					Form3.smethod_48((Form)(object)this, (FormBorderStyle)0);
					num = (int)((num2 * 1141836552) ^ 0x29ED58E3);
					continue;
				case 71u:
					num = ((int)num2 * -1978735657) ^ -793996984;
					continue;
				case 70u:
					Form3.smethod_30((Control)(object)button2, new Point(174, 49));
					Form3.smethod_31((Control)(object)button2, "button2");
					num = ((int)num2 * -149857057) ^ 0xBC4B84A;
					continue;
				case 69u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button7);
					num = ((int)num2 * -1846199580) ^ 0x5E722CCE;
					continue;
				case 68u:
					Form3.smethod_14((Control)(object)button5, bool_0: false);
					num = ((int)num2 * -1578214365) ^ -919588441;
					continue;
				case 67u:
					Form3.smethod_31((Control)(object)button7, "button7");
					num = ((int)num2 * -1679113329) ^ -1455629579;
					continue;
				case 66u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button7), 0);
					num = ((int)num2 * -812098176) ^ -2107585679;
					continue;
				case 65u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button5);
					num = ((int)num2 * -1732217110) ^ 0x123190B8;
					continue;
				case 64u:
					num = (int)((num2 * 2139283624) ^ 0x331CD8CF);
					continue;
				case 63u:
					errorProvider1 = Form3.smethod_23(components);
					num = ((int)num2 * -1165235414) ^ -284429;
					continue;
				case 62u:
					num = ((int)num2 * -1248576594) ^ -861004060;
					continue;
				case 61u:
					Form3.smethod_34((ButtonBase)(object)button4, bool_0: true);
					num = (int)(num2 * 463845063) ^ -955528072;
					continue;
				case 60u:
					num = (int)((num2 * 2075714998) ^ 0x5032712A);
					continue;
				case 59u:
					Form3.smethod_29((ButtonBase)(object)button7, (FlatStyle)0);
					num = ((int)num2 * -854143871) ^ 0x64F7035;
					continue;
				case 58u:
					Form3.smethod_43((ContainerControl)(object)this, new SizeF(6f, 13f));
					Form3.smethod_44((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -1145457162) ^ 0x401CD6E5;
					continue;
				case 57u:
					Form3.smethod_32((Control)(object)button1, new Size(49, 21));
					num = ((int)num2 * -1133658556) ^ -98196316;
					continue;
				case 56u:
					Form3.smethod_36((Control)(object)button4, (EventHandler)Button4_Click);
					num = ((int)num2 * -1653712769) ^ 0x2E6D88AD;
					continue;
				case 55u:
					num = ((int)num2 * -891033083) ^ -2032390436;
					continue;
				case 54u:
					num = ((int)num2 * -977578160) ^ 0x2CA17DBB;
					continue;
				case 53u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button4);
					num = (int)(num2 * 195951298) ^ -1271793637;
					continue;
				case 52u:
					Form3.smethod_55((ISupportInitialize)errorProvider1);
					Form3.smethod_56((Control)(object)this, bool_0: false);
					num = ((int)num2 * -1443625887) ^ -2073394094;
					continue;
				case 51u:
					Form3.smethod_33((Control)(object)button7, 6);
					num = ((int)num2 * -1101991699) ^ 0x786D529;
					continue;
				case 50u:
					num = (int)((num2 * 1837372510) ^ 0x5D66A8E7);
					continue;
				case 49u:
					textBox2 = Form3.smethod_21();
					num = (int)(num2 * 652801433) ^ -1526398284;
					continue;
				case 48u:
					num = ((int)num2 * -1884654242) ^ 0x6321FB15;
					continue;
				case 47u:
					Form3.smethod_34((ButtonBase)(object)button5, bool_0: true);
					num = ((int)num2 * -725005605) ^ -2073324197;
					continue;
				case 46u:
					Form3.smethod_31((Control)(object)button4, "button4");
					num = (int)((num2 * 193840185) ^ 0x6EBE5F2B);
					continue;
				case 45u:
					num = (int)(num2 * 841354301) ^ -2086272972;
					continue;
				case 44u:
					Form3.smethod_30((Control)(object)button1, new Point(265, 49));
					num = (int)(num2 * 649368558) ^ -1769201509;
					continue;
				case 43u:
					num = ((int)num2 * -1427408045) ^ 0x6F4F523E;
					continue;
				case 42u:
					Form3.smethod_30((Control)(object)textBox1, new Point(174, 2));
					num = (int)(num2 * 841816100) ^ -2094339367;
					continue;
				case 41u:
					num = (int)(num2 * 1091659370) ^ -2001270657;
					continue;
				case 40u:
					Form3.smethod_24((ISupportInitialize)errorProvider1);
					Form3.smethod_25((Control)(object)this);
					num = ((int)num2 * -310388410) ^ -1751077371;
					continue;
				case 39u:
					Form3.smethod_38((Control)(object)button5, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 925814413) ^ 0x1A5E9474);
					continue;
				case 38u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button5), 0);
					num = ((int)num2 * -201628501) ^ 0x75D0EBE0;
					continue;
				case 37u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox2);
					num = ((int)num2 * -698515475) ^ 0x5D8ADB06;
					continue;
				case 36u:
					Form3.smethod_41(textBox2, bool_0: true);
					num = ((int)num2 * -1871268413) ^ -305042622;
					continue;
				case 35u:
					Form3.smethod_50((Form)(object)this, bool_0: false);
					num = ((int)num2 * -556599411) ^ -369748432;
					continue;
				case 34u:
					label1 = Form3.smethod_22();
					num = (int)((num2 * 935819606) ^ 0x635197A8);
					continue;
				case 33u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox1);
					num = (int)(num2 * 1186718611) ^ -630040238;
					continue;
				case 32u:
					Form3.smethod_34((ButtonBase)(object)button2, bool_0: true);
					num = (int)((num2 * 902623623) ^ 0x529AEDA);
					continue;
				case 31u:
					Form3.smethod_26((Control)(object)label1, Color.Transparent);
					num = ((int)num2 * -696496245) ^ 0x36B0346E;
					continue;
				case 30u:
					Form3.smethod_30((Control)(object)button7, new Point(174, 243));
					num = (int)((num2 * 1853493847) ^ 0x33CCBDAB);
					continue;
				case 29u:
					Form3.smethod_40((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -1470544169) ^ -2078810045;
					continue;
				case 28u:
					Form3.smethod_49((Form)(object)this, bool_0: false);
					num = ((int)num2 * -195250266) ^ 0x4900E7B9;
					continue;
				case 27u:
					num = (int)(num2 * 82079226) ^ -510070801;
					continue;
				case 26u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)NullButton);
					num = (int)(num2 * 576533969) ^ -2145024372;
					continue;
				case 25u:
					num = (int)(num2 * 398850694) ^ -1947352810;
					continue;
				case 24u:
					num = ((int)num2 * -921010965) ^ -1104379687;
					continue;
				case 23u:
					Form3.smethod_34((ButtonBase)(object)NullButton, bool_0: false);
					num = ((int)num2 * -360627824) ^ 0x788CAC4;
					continue;
				case 22u:
					Form3.smethod_31((Control)(object)textBox2, "textBox2");
					num = (int)((num2 * 100648408) ^ 0x2EFA4CE6);
					continue;
				case 21u:
					Form3.smethod_36((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -412591556) ^ -2083434535;
					continue;
				case 20u:
					Form3.smethod_33((Control)(object)button4, 4);
					num = ((int)num2 * -1030318947) ^ 0x7667BD51;
					continue;
				case 19u:
					Form3.smethod_35((Control)(object)button4, "Начало игры");
					num = ((int)num2 * -666164376) ^ -605603235;
					continue;
				case 18u:
					num = (int)(num2 * 1774415994) ^ -1048953897;
					continue;
				case 17u:
					Form3.smethod_14((Control)(object)button4, bool_0: false);
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button4), 0);
					num = ((int)num2 * -319273299) ^ 0x5DAED278;
					continue;
				case 16u:
					num = ((int)num2 * -1767820814) ^ 0x4BEAD118;
					continue;
				case 15u:
					Form3.smethod_26((Control)(object)this, Color.White);
					num = (int)(num2 * 876317799) ^ -1298066757;
					continue;
				case 14u:
					Form3.smethod_33((Control)(object)textBox2, 8);
					num = (int)(num2 * 1710358059) ^ -604510399;
					continue;
				case 13u:
					Form3.smethod_39((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -2095796682) ^ 0x12E5443E;
					continue;
				case 12u:
					Form3.smethod_33((Control)(object)button1, 0);
					num = ((int)num2 * -270382844) ^ -1269745425;
					continue;
				case 11u:
					Form3.smethod_31((Control)(object)button5, "button5");
					Form3.smethod_32((Control)(object)button5, new Size(140, 50));
					Form3.smethod_33((Control)(object)button5, 5);
					num = (int)(num2 * 1063057234) ^ -1272511053;
					continue;
				case 10u:
					Form3.smethod_32((Control)(object)button4, new Size(140, 50));
					num = ((int)num2 * -177110561) ^ 0x651B7765;
					continue;
				case 9u:
					num = ((int)num2 * -758339476) ^ 0x2B2CB446;
					continue;
				case 8u:
					Form3.smethod_32((Control)(object)textBox1, new Size(140, 20));
					num = (int)(num2 * 1083197347) ^ -248821578;
					continue;
				case 7u:
					Form3.smethod_35((Control)(object)button7, "Достижения");
					num = (int)((num2 * 92737312) ^ 0x314251A5);
					continue;
				case 6u:
					Form3.smethod_34((ButtonBase)(object)button7, bool_0: true);
					Form3.smethod_36((Control)(object)button7, (EventHandler)Button7_Click);
					num = ((int)num2 * -1506375233) ^ 0x5852CECC;
					continue;
				case 5u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -622859755) ^ 0x720963C8;
					continue;
				case 4u:
					num = (int)((num2 * 54287907) ^ 0x3737D814);
					continue;
				case 3u:
					num = (int)(num2 * 431573113) ^ -108356981;
					continue;
				case 2u:
					Form3.smethod_38((Control)(object)label1, Form3.smethod_37("Mistral", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 1817770905) ^ -1709785554;
					continue;
				case 1u:
					Form3.smethod_34((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -137893923) ^ 0x581EE05E;
					continue;
				case 0u:
					num = (int)((num2 * 561630826) ^ 0x6289C0ED);
					continue;
				default:
					return;
				case 126u:
					break;
				case 87u:
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
