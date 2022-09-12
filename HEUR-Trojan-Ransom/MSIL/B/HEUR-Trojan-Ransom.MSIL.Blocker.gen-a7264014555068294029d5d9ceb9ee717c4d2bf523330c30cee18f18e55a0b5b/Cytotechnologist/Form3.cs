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
			int num = -1660714066;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAFC5869Bu) % 7u)
				{
				case 6u:
					Form3.smethod_10(val, new Point(Form3.smethod_5((Form)(object)this).X + (Form3.smethod_6((Control)(object)this) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_5((Form)(object)this).Y + (Form3.smethod_8((Control)(object)this) - Form3.smethod_9((Control)(object)val)) / 2 + 70));
					num = ((int)num2 * -1323369150) ^ 0x1C3C07F5;
					continue;
				case 5u:
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = (int)(num2 * 1922563921) ^ -310505288;
					continue;
				case 2u:
					Form3.smethod_4((Control)(object)val);
					num = ((int)num2 * -113505390) ^ 0x2C69F4A0;
					continue;
				case 1u:
				{
					Form4 form = new Form4();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					num = (int)((num2 * 1752488620) ^ 0x75730FBC);
					continue;
				}
				case 0u:
					num = ((int)num2 * -1454754776) ^ -1156432708;
					continue;
				default:
					return;
				case 4u:
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
			int num = -1240476038;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9EE3631Eu) % 6u)
				{
				case 4u:
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = (int)((num2 * 2040742845) ^ 0x1217A881);
					continue;
				case 3u:
				{
					Form2 form = new Form2();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					Form3.smethod_4((Control)(object)val);
					num = ((int)num2 * -928238434) ^ 0x1AF7D8B9;
					continue;
				}
				case 2u:
					Form3.smethod_0((Control)(object)NullButton);
					num = ((int)num2 * -1759044808) ^ 0x5A4B873;
					continue;
				case 1u:
					Form3.smethod_10(val, new Point(Form3.smethod_13(Form3.smethod_12((Form)(object)this)).X + (Form3.smethod_7((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_13(Form3.smethod_12((Form)(object)this)).Y + (Form3.smethod_9((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_9((Control)(object)val)) / 2));
					num = ((int)num2 * -28551419) ^ 0xDB9F9CB;
					continue;
				default:
					return;
				case 0u:
					break;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	public void Button_Continue()
	{
		Form3.smethod_14((Control)(object)button5, bool_0: true);
		while (true)
		{
			int num = -342415833;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x85EC98F7u) % 3u)
				{
				case 1u:
					goto IL_000e;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_000e:
				num = ((int)num2 * -1380293887) ^ -1043293753;
			}
		}
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		int num3 = default(int);
		while (true)
		{
			int num = -1396921936;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDE731FB6u) % 9u)
				{
				case 8u:
					num3 = Form3.smethod_8((Control)(object)this) - 1;
					Form3.smethod_15((Control)(object)this, num3);
					num = -1419771109;
					continue;
				case 7u:
					Form3.smethod_16(Form3.smethod_12((Form)(object)this));
					num = ((int)num2 * -517019427) ^ -527829953;
					continue;
				case 6u:
					num = -2082171392;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (num3 > 1)
					{
						num4 = -500481075;
						num5 = -500481075;
					}
					else
					{
						num4 = -277915661;
						num5 = -277915661;
					}
					num = num4 ^ (int)(num2 * 2023808750);
					continue;
				}
				case 2u:
					num = ((int)num2 * -39287276) ^ -1869231496;
					continue;
				case 1u:
					num = (int)(num2 * 275628907) ^ -1576680650;
					continue;
				case 0u:
					Form3.smethod_17((Form3.smethod_12((Form)(object)this) as Form1).timer1);
					num = (int)(num2 * 29594808) ^ -329935008;
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
			int num = 2079815970;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7746A939u) % 3u)
				{
				case 1u:
					goto IL_000e;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_000e:
				num = (int)(num2 * 1818864613) ^ -650643889;
			}
		}
	}

	private void Button7_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 1060111302;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1D3EF9A3u) % 4u)
				{
				case 1u:
					Form3.smethod_0((Control)(object)NullButton);
					Form3.smethod_14((Control)(object)button7, bool_0: false);
					num = (int)(num2 * 374026556) ^ -1976652613;
					continue;
				case 0u:
					num = ((int)num2 * -864429280) ^ -1655325539;
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

	protected override void Dispose(bool disposing)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = 268693493;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x773EA682u) % 10u)
				{
				case 9u:
					((Form)this).Dispose(disposing);
					num = 1919863798;
					continue;
				case 8u:
					Form3.smethod_18((IDisposable)components);
					num = ((int)num2 * -1576827821) ^ -1510817570;
					continue;
				case 7u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1510290726;
						num5 = 1510290726;
					}
					else
					{
						num4 = 518192766;
						num5 = 518192766;
					}
					num = num4 ^ (int)(num2 * 326787159);
					continue;
				}
				case 6u:
					num = (int)((num2 * 214387190) ^ 0x9D0669F);
					continue;
				case 5u:
					num = ((int)num2 * -1389692826) ^ -1620527222;
					continue;
				case 4u:
					num3 = ((components != null) ? 1 : 0);
					goto IL_007c;
				case 2u:
					num = ((int)num2 * -504779342) ^ -482887616;
					continue;
				case 1u:
					if (disposing)
					{
						num = (int)(num2 * 718542217) ^ -512567819;
						continue;
					}
					num3 = 0;
					goto IL_007c;
				default:
					return;
				case 3u:
					break;
				case 0u:
					return;
					IL_007c:
					flag = (byte)num3 != 0;
					num = 682648433;
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
			int num = -1697504580;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x94F6772Cu) % 140u)
				{
				case 139u:
					button7 = Form3.smethod_20();
					textBox1 = Form3.smethod_21();
					num = (int)((num2 * 1689607268) ^ 0x62BFB5AA);
					continue;
				case 138u:
					Form3.smethod_53((Form)(object)this, bool_0: false);
					num = (int)((num2 * 1683215652) ^ 0x11257F2F);
					continue;
				case 137u:
					Form3.smethod_54((Form)(object)this, bool_0: true);
					num = (int)((num2 * 307956721) ^ 0x6192469B);
					continue;
				case 136u:
					button5 = Form3.smethod_20();
					num = ((int)num2 * -1084477981) ^ -349490709;
					continue;
				case 135u:
					Form3.smethod_30((Control)(object)button5, new Point(174, 190));
					num = ((int)num2 * -403106325) ^ -2026894028;
					continue;
				case 134u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)label1);
					num = (int)((num2 * 2100292409) ^ 0x10CC7263);
					continue;
				case 133u:
					Form3.smethod_34((ButtonBase)(object)button5, bool_0: true);
					Form3.smethod_36((Control)(object)button5, (EventHandler)Button5_Click);
					num = ((int)num2 * -1542522531) ^ -848449455;
					continue;
				case 132u:
					Form3.smethod_31((Control)(object)textBox1, "textBox1");
					num = ((int)num2 * -1204764909) ^ -1708929064;
					continue;
				case 131u:
					num = ((int)num2 * -863860651) ^ 0x4BC43289;
					continue;
				case 130u:
					Form3.smethod_31((Control)(object)button1, "button1");
					num = ((int)num2 * -946013190) ^ 0x3A3F3125;
					continue;
				case 129u:
					num = ((int)num2 * -1198609155) ^ -1059059560;
					continue;
				case 128u:
					num = (int)(num2 * 554133954) ^ -1262808542;
					continue;
				case 127u:
					Form3.smethod_44((ContainerControl)(object)this, (AutoScaleMode)1);
					Form3.smethod_26((Control)(object)this, Color.White);
					Form3.smethod_45((Form)(object)this, new Size(486, 296));
					num = ((int)num2 * -656659839) ^ -142636810;
					continue;
				case 126u:
					Form3.smethod_51((Control)(object)this, "Form3");
					num = (int)((num2 * 1288174198) ^ 0x6874FB6D);
					continue;
				case 125u:
					Form3.smethod_33((Control)(object)NullButton, 3);
					num = (int)(num2 * 2001500784) ^ -1522870396;
					continue;
				case 124u:
					Form3.smethod_33((Control)(object)button1, 0);
					Form3.smethod_35((Control)(object)button1, "Вход");
					num = ((int)num2 * -350376929) ^ -45001883;
					continue;
				case 123u:
					num = ((int)num2 * -1339085550) ^ 0x3FBABCC0;
					continue;
				case 122u:
					Form3.smethod_31((Control)(object)textBox2, "textBox2");
					num = (int)((num2 * 1196623168) ^ 0x1517A44);
					continue;
				case 121u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox1);
					num = (int)((num2 * 588541182) ^ 0x43467583);
					continue;
				case 120u:
					Form3.smethod_30((Control)(object)button2, new Point(174, 49));
					num = ((int)num2 * -440903748) ^ -2079369021;
					continue;
				case 119u:
					Form3.smethod_36((Control)(object)button7, (EventHandler)Button7_Click);
					num = (int)((num2 * 2118487839) ^ 0x7DD16662);
					continue;
				case 118u:
					textBox2 = Form3.smethod_21();
					errorProvider1 = Form3.smethod_23(components);
					Form3.smethod_24((ISupportInitialize)errorProvider1);
					num = (int)((num2 * 1411769727) ^ 0x122E77B0);
					continue;
				case 117u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button7);
					num = (int)(num2 * 1290903546) ^ -1287251677;
					continue;
				case 116u:
					Form3.smethod_35((Control)(object)button4, "Начало игры");
					num = ((int)num2 * -682151652) ^ 0x7B254A2C;
					continue;
				case 115u:
					Form3.smethod_26((Control)(object)NullButton, Color.Transparent);
					num = ((int)num2 * -1647671305) ^ 0x9DB269E;
					continue;
				case 114u:
					label1 = Form3.smethod_22();
					num = ((int)num2 * -1695185676) ^ 0x3480D9A;
					continue;
				case 113u:
					Form3.smethod_31((Control)(object)label1, "label1");
					num = (int)(num2 * 2072532776) ^ -1076485969;
					continue;
				case 112u:
					num = ((int)num2 * -156788978) ^ -1375256967;
					continue;
				case 111u:
					Form3.smethod_31((Control)(object)button2, "button2");
					num = (int)((num2 * 1162570179) ^ 0x3FF299A0);
					continue;
				case 110u:
					Form3.smethod_30((Control)(object)button7, new Point(174, 243));
					num = (int)(num2 * 1477076905) ^ -892952627;
					continue;
				case 109u:
					Form3.smethod_36((Control)(object)button2, (EventHandler)Button2_Click);
					num = ((int)num2 * -1280680812) ^ -1587228981;
					continue;
				case 108u:
					Form3.smethod_33((Control)(object)button2, 1);
					num = (int)(num2 * 1544351964) ^ -176667;
					continue;
				case 107u:
					Form3.smethod_38((Control)(object)label1, Form3.smethod_37("Mistral", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 801290151) ^ -520317041;
					continue;
				case 106u:
					Form3.smethod_34((ButtonBase)(object)button1, bool_0: true);
					num = (int)((num2 * 407939562) ^ 0x3B953298);
					continue;
				case 105u:
					Form3.smethod_36((Control)(object)button4, (EventHandler)Button4_Click);
					num = (int)(num2 * 1665513891) ^ -316837299;
					continue;
				case 104u:
					Form3.smethod_36((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -229527436) ^ -458790464;
					continue;
				case 103u:
					num = ((int)num2 * -1623549398) ^ 0x4983007A;
					continue;
				case 102u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button7), 0);
					num = (int)(num2 * 317433606) ^ -982727140;
					continue;
				case 101u:
					Form3.smethod_32((Control)(object)button1, new Size(49, 21));
					num = (int)((num2 * 1988602382) ^ 0x65469ACA);
					continue;
				case 100u:
					Form3.smethod_34((ButtonBase)(object)button4, bool_0: true);
					num = ((int)num2 * -396425944) ^ 0x7E686431;
					continue;
				case 99u:
					num = (int)((num2 * 1626783541) ^ 0x7FD8D82A);
					continue;
				case 98u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button2);
					num = (int)(num2 * 983574018) ^ -375319783;
					continue;
				case 97u:
					num = (int)(num2 * 443095897) ^ -229968824;
					continue;
				case 96u:
					Form3.smethod_29((ButtonBase)(object)NullButton, (FlatStyle)0);
					num = ((int)num2 * -231745356) ^ -711981096;
					continue;
				case 95u:
					Form3.smethod_52((Form)(object)this, bool_0: false);
					num = (int)((num2 * 558858023) ^ 0x1713C30F);
					continue;
				case 94u:
					Form3.smethod_35((Control)(object)button2, "Регистрация");
					num = (int)((num2 * 216549387) ^ 0x6809CEA0);
					continue;
				case 93u:
					num = (int)((num2 * 1867811280) ^ 0x197FF933);
					continue;
				case 92u:
					Form3.smethod_35((Control)(object)label1, "QUARTO");
					num = (int)(num2 * 674984924) ^ -863903210;
					continue;
				case 91u:
					Form3.smethod_14((Control)(object)button4, bool_0: false);
					num = ((int)num2 * -1691776951) ^ 0x4C4B13B7;
					continue;
				case 90u:
					Form3.smethod_33((Control)(object)button5, 5);
					num = ((int)num2 * -77263368) ^ 0x7360015E;
					continue;
				case 89u:
					Form3.smethod_29((ButtonBase)(object)button7, (FlatStyle)0);
					num = (int)(num2 * 979507530) ^ -1792716838;
					continue;
				case 88u:
					num = ((int)num2 * -216447630) ^ -988912519;
					continue;
				case 87u:
					num = (int)(num2 * 1248094283) ^ -450146369;
					continue;
				case 86u:
					Form3.smethod_33((Control)(object)label1, 7);
					num = ((int)num2 * -2074088050) ^ -1801679012;
					continue;
				case 85u:
					Form3.smethod_38((Control)(object)button5, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -982077754) ^ 0x47E047B5;
					continue;
				case 84u:
					Form3.smethod_35((Control)(object)button7, "Достижения");
					num = ((int)num2 * -676879898) ^ 0x39EA36B0;
					continue;
				case 83u:
					num = ((int)num2 * -1955529798) ^ -288212272;
					continue;
				case 82u:
					Form3.smethod_31((Control)(object)button5, "button5");
					num = ((int)num2 * -1242954460) ^ -32111877;
					continue;
				case 81u:
					num = (int)((num2 * 584208594) ^ 0x5DCC0D0C);
					continue;
				case 80u:
					Form3.smethod_57((Control)(object)this);
					num = (int)(num2 * 1097155331) ^ -272043150;
					continue;
				case 79u:
					Form3.smethod_30((Control)(object)textBox1, new Point(174, 2));
					num = (int)(num2 * 771345870) ^ -870308926;
					continue;
				case 78u:
					num = ((int)num2 * -131691523) ^ 0x1C012163;
					continue;
				case 77u:
					button4 = Form3.smethod_20();
					num = ((int)num2 * -652831197) ^ 0x1A9BEF4F;
					continue;
				case 76u:
					Form3.smethod_33((Control)(object)button4, 4);
					num = ((int)num2 * -929334091) ^ -498533556;
					continue;
				case 75u:
					Form3.smethod_38((Control)(object)button7, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 1912871859) ^ -3878358;
					continue;
				case 74u:
					Form3.smethod_34((ButtonBase)(object)button2, bool_0: true);
					num = ((int)num2 * -434873027) ^ -533686685;
					continue;
				case 73u:
					num = (int)((num2 * 44675679) ^ 0xA7DEA05);
					continue;
				case 71u:
					Form3.smethod_33((Control)(object)textBox1, 7);
					num = (int)((num2 * 1439007310) ^ 0x5819A0A4);
					continue;
				case 70u:
					Form3.smethod_31((Control)(object)button7, "button7");
					Form3.smethod_32((Control)(object)button7, new Size(140, 50));
					num = ((int)num2 * -1119686145) ^ -1110567579;
					continue;
				case 69u:
					Form3.smethod_29((ButtonBase)(object)button4, (FlatStyle)0);
					num = (int)(num2 * 1266466506) ^ -959839192;
					continue;
				case 68u:
					Form3.smethod_56((Control)(object)this, bool_0: false);
					num = (int)(num2 * 544831604) ^ -2087779752;
					continue;
				case 67u:
					Form3.smethod_32((Control)(object)label1, new Size(207, 76));
					num = ((int)num2 * -1407453931) ^ -1410955754;
					continue;
				case 66u:
					num = ((int)num2 * -1805446223) ^ 0x2F53DCA;
					continue;
				case 65u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button1);
					num = (int)(num2 * 1728147256) ^ -379442612;
					continue;
				case 64u:
					Form3.smethod_55((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -16230337) ^ 0x1A71207C;
					continue;
				case 63u:
					button1 = Form3.smethod_20();
					button2 = Form3.smethod_20();
					num = (int)((num2 * 646874859) ^ 0x24B08CE8);
					continue;
				case 62u:
					Form3.smethod_30((Control)(object)button4, new Point(174, 137));
					num = ((int)num2 * -566511297) ^ 0x66421CCB;
					continue;
				case 61u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button5), 0);
					num = ((int)num2 * -1567911910) ^ 0x361A9029;
					continue;
				case 60u:
					Form3.smethod_40((Control)(object)label1, bool_0: true);
					num = (int)((num2 * 1882363158) ^ 0x37BB9EBE);
					continue;
				case 59u:
					num = ((int)num2 * -1335194068) ^ -874815453;
					continue;
				case 58u:
					Form3.smethod_14((Control)(object)button5, bool_0: false);
					num = (int)((num2 * 57649836) ^ 0x6A81F05);
					continue;
				case 57u:
					num = (int)(num2 * 2060764860) ^ -1590240454;
					continue;
				case 56u:
					Form3.smethod_34((ButtonBase)(object)NullButton, bool_0: false);
					num = (int)(num2 * 504107937) ^ -1325634215;
					continue;
				case 55u:
					num = (int)((num2 * 2021129389) ^ 0x72D00F1A);
					continue;
				case 54u:
					Form3.smethod_35((Control)(object)button5, "Продолжить");
					num = ((int)num2 * -1005553782) ^ 0x862316F;
					continue;
				case 53u:
					num = ((int)num2 * -364093212) ^ -898678238;
					continue;
				case 52u:
					num = (int)((num2 * 1993113718) ^ 0x17B1B47F);
					continue;
				case 51u:
					num = (int)(num2 * 189228003) ^ -113484021;
					continue;
				case 50u:
					Form3.smethod_43((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -205437789) ^ 0x4F6ED19F;
					continue;
				case 49u:
					num = ((int)num2 * -508597688) ^ -1034678230;
					continue;
				case 48u:
					Form3.smethod_30((Control)(object)NullButton, new Point(-1, -1));
					Form3.smethod_31((Control)(object)NullButton, "NullButton");
					num = ((int)num2 * -1966822087) ^ -316484009;
					continue;
				case 47u:
					num = ((int)num2 * -1661749128) ^ -490556979;
					continue;
				case 46u:
					num = (int)((num2 * 953372476) ^ 0x181E1B14);
					continue;
				case 45u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)NullButton), 0);
					num = ((int)num2 * -2016515396) ^ 0x28693507;
					continue;
				case 44u:
					Form3.smethod_34((ButtonBase)(object)button7, bool_0: true);
					num = (int)((num2 * 1954696360) ^ 0x48EF7BBF);
					continue;
				case 43u:
					num = (int)((num2 * 1987767975) ^ 0x40A86D96);
					continue;
				case 42u:
					num = (int)(num2 * 2059009034) ^ -404231589;
					continue;
				case 41u:
					Form3.smethod_38((Control)(object)button4, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1478142037) ^ 0x52EA95AD;
					continue;
				case 40u:
					Form3.smethod_32((Control)(object)textBox1, new Size(140, 20));
					num = ((int)num2 * -2038967682) ^ -326741158;
					continue;
				case 39u:
					Form3.smethod_32((Control)(object)button5, new Size(140, 50));
					num = (int)(num2 * 1969712030) ^ -384379220;
					continue;
				case 38u:
					num = ((int)num2 * -1012500717) ^ -1669489515;
					continue;
				case 37u:
					num = (int)((num2 * 756120857) ^ 0x4AFA0568);
					continue;
				case 36u:
					Form3.smethod_26((Control)(object)label1, Color.Transparent);
					num = ((int)num2 * -1135625908) ^ -1565916653;
					continue;
				case 35u:
					num = (int)(num2 * 614449926) ^ -197750945;
					continue;
				case 34u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button5);
					num = (int)((num2 * 1206866353) ^ 0x2172E4CD);
					continue;
				case 33u:
					Form3.smethod_50((Form)(object)this, bool_0: false);
					num = (int)(num2 * 129437236) ^ -1388033036;
					continue;
				case 32u:
					num = (int)(num2 * 1784717442) ^ -1503180837;
					continue;
				case 31u:
					Form3.smethod_30((Control)(object)textBox2, new Point(174, 26));
					num = (int)((num2 * 1580339149) ^ 0x42145C8D);
					continue;
				case 30u:
					num = ((int)num2 * -948204026) ^ -845976101;
					continue;
				case 29u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)NullButton);
					Form3.smethod_48((Form)(object)this, (FormBorderStyle)0);
					num = (int)(num2 * 310333328) ^ -904923253;
					continue;
				case 28u:
					num = ((int)num2 * -938362640) ^ -1976031804;
					continue;
				case 27u:
					num = ((int)num2 * -1930049174) ^ -1658561634;
					continue;
				case 26u:
					Form3.smethod_31((Control)(object)button4, "button4");
					Form3.smethod_32((Control)(object)button4, new Size(140, 50));
					num = (int)(num2 * 878698224) ^ -1341782948;
					continue;
				case 25u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox2);
					num = ((int)num2 * -962760200) ^ -269360663;
					continue;
				case 24u:
					components = Form3.smethod_19();
					num = (int)(num2 * 2061088971) ^ -65280526;
					continue;
				case 23u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button4);
					num = (int)(num2 * 1351916515) ^ -820937225;
					continue;
				case 22u:
					Form3.smethod_39((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -1278945586) ^ -786900932;
					continue;
				case 21u:
					Form3.smethod_33((Control)(object)textBox2, 8);
					num = (int)(num2 * 1786932412) ^ -705503409;
					continue;
				case 20u:
					num = (int)((num2 * 453277202) ^ 0x4B008A12);
					continue;
				case 19u:
					Form3.smethod_25((Control)(object)this);
					num = (int)(num2 * 207312888) ^ -423498077;
					continue;
				case 18u:
					NullButton = Form3.smethod_20();
					num = (int)(num2 * 518527569) ^ -887084255;
					continue;
				case 17u:
					num = (int)((num2 * 364659524) ^ 0x56D1F1CA);
					continue;
				case 16u:
					num = (int)((num2 * 569459372) ^ 0x4AA7BD4D);
					continue;
				case 15u:
					Form3.smethod_33((Control)(object)button7, 6);
					num = (int)(num2 * 1455146378) ^ -1339644554;
					continue;
				case 14u:
					num = ((int)num2 * -1703354608) ^ -1908251908;
					continue;
				case 13u:
					num = (int)((num2 * 1871788798) ^ 0x3B72B0C);
					continue;
				case 12u:
					Form3.smethod_30((Control)(object)label1, new Point(140, 70));
					num = ((int)num2 * -535232754) ^ -1571426947;
					continue;
				case 11u:
					Form3.smethod_29((ButtonBase)(object)button5, (FlatStyle)0);
					num = ((int)num2 * -1995578503) ^ 0x72C5AD56;
					continue;
				case 10u:
					Form3.smethod_32((Control)(object)NullButton, new Size(1, 1));
					num = ((int)num2 * -93900179) ^ 0x62D69C57;
					continue;
				case 9u:
					Form3.smethod_30((Control)(object)button1, new Point(265, 49));
					num = (int)((num2 * 369033661) ^ 0x5AA7A110);
					continue;
				case 7u:
					Form3.smethod_49((Form)(object)this, bool_0: false);
					num = ((int)num2 * -883778143) ^ -158140041;
					continue;
				case 6u:
					Form3.smethod_41(textBox2, bool_0: true);
					Form3.smethod_39((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					Form3.smethod_42(errorProvider1, (ContainerControl)(object)this);
					num = (int)((num2 * 1925433237) ^ 0x17237055);
					continue;
				case 5u:
					Form3.smethod_32((Control)(object)button2, new Size(85, 21));
					num = (int)(num2 * 1482032955) ^ -2072497344;
					continue;
				case 4u:
					num = (int)((num2 * 1663938086) ^ 0x3280F2F6);
					continue;
				case 3u:
					Form3.smethod_32((Control)(object)textBox2, new Size(140, 20));
					num = ((int)num2 * -1385063029) ^ -2128575146;
					continue;
				case 2u:
					num = (int)(num2 * 431029925) ^ -594093814;
					continue;
				case 1u:
					num = ((int)num2 * -338641436) ^ 0x133CFBFF;
					continue;
				case 0u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button4), 0);
					num = (int)(num2 * 549690146) ^ -2028811244;
					continue;
				default:
					return;
				case 8u:
					break;
				case 72u:
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
