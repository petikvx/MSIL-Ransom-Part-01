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
		Form val = default(Form);
		while (true)
		{
			int num = -1869941473;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE82E6418u) % 6u)
				{
				case 5u:
					num = (int)((num2 * 2084060865) ^ 0x79BAACF1);
					continue;
				case 2u:
					Form3.smethod_4((Control)(object)val);
					num = (int)((num2 * 1727755708) ^ 0x20455E17);
					continue;
				case 1u:
				{
					Form3.smethod_1(errorProvider1);
					Form4 form = new Form4();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					num = (int)(num2 * 1692015145) ^ -674235575;
					continue;
				}
				case 0u:
					Form3.smethod_10(val, new Point(Form3.smethod_5((Form)(object)this).X + (Form3.smethod_6((Control)(object)this) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_5((Form)(object)this).Y + (Form3.smethod_8((Control)(object)this) - Form3.smethod_9((Control)(object)val)) / 2 + 70));
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = ((int)num2 * -159955009) ^ 0x2349A6AE;
					continue;
				default:
					return;
				case 3u:
					break;
				case 4u:
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
			int num = 872728703;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4C97D701u) % 7u)
				{
				case 6u:
				{
					Form3.smethod_0((Control)(object)NullButton);
					Form2 form = new Form2();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					num = (int)(num2 * 155342580) ^ -1307204868;
					continue;
				}
				case 3u:
					Form3.smethod_4((Control)(object)val);
					num = (int)(num2 * 693357335) ^ -1982132586;
					continue;
				case 2u:
					num = (int)((num2 * 588919379) ^ 0x1DC2ED50);
					continue;
				case 1u:
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = ((int)num2 * -1500253951) ^ -216856339;
					continue;
				case 0u:
					Form3.smethod_10(val, new Point(Form3.smethod_13(Form3.smethod_12((Form)(object)this)).X + (Form3.smethod_7((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_13(Form3.smethod_12((Form)(object)this)).Y + (Form3.smethod_9((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_9((Control)(object)val)) / 2));
					num = (int)((num2 * 1190753904) ^ 0x52CF17B8);
					continue;
				default:
					return;
				case 4u:
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
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = Form3.smethod_8((Control)(object)this) - 1;
			int num2 = -1362197500;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xD80ADCD2u) % 8u)
				{
				case 7u:
					num2 = -862591938;
					continue;
				case 6u:
					Form3.smethod_15((Control)(object)this, num);
					num2 = ((int)num3 * -2068063107) ^ 0x40420285;
					continue;
				case 5u:
					Form3.smethod_16(Form3.smethod_12((Form)(object)this));
					num2 = ((int)num3 * -1361989177) ^ 0x56487303;
					continue;
				case 4u:
					num2 = -1566352822;
					continue;
				case 2u:
					Form3.smethod_17((Form3.smethod_12((Form)(object)this) as Form1).timer1);
					num2 = ((int)num3 * -193447853) ^ -575810937;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (num <= 1)
					{
						num4 = -333657426;
						num5 = -333657426;
					}
					else
					{
						num4 = -107806289;
						num5 = -107806289;
					}
					num2 = num4 ^ (int)(num3 * 285749545);
					continue;
				}
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

	private void Button1_Click(object sender, EventArgs e)
	{
	}

	private void TextBox_TextChanged(object sender, EventArgs e)
	{
		Form3.smethod_1(errorProvider1);
		while (true)
		{
			int num = -1101795715;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB1190485u) % 3u)
				{
				case 1u:
					goto IL_000d;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_000d:
				num = ((int)num2 * -1491193462) ^ 0x2F31C501;
			}
		}
	}

	public void ContinueLock()
	{
		Form3.smethod_14((Control)(object)button5, bool_0: false);
	}

	public void AchivUnlock()
	{
		Form3.smethod_14((Control)(object)button7, bool_0: true);
	}

	private void Button7_Click(object sender, EventArgs e)
	{
		Form3.smethod_0((Control)(object)NullButton);
		Form3.smethod_14((Control)(object)button7, bool_0: false);
	}

	protected override void Dispose(bool disposing)
	{
		while (true)
		{
			int num = -1495267188;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xD1AC2F6Au) % 9u)
				{
				case 8u:
					num = (int)(num2 * 1325127586) ^ -1724483790;
					continue;
				case 6u:
					num = ((int)num2 * -1209190132) ^ 0x2A1E473C;
					continue;
				case 5u:
					Form3.smethod_18((IDisposable)components);
					num = ((int)num2 * -1796596108) ^ -829061089;
					continue;
				case 4u:
					num = (int)((num2 * 1038923411) ^ 0x320DD12C);
					continue;
				case 2u:
					if (disposing)
					{
						num = (int)((num2 * 1804479379) ^ 0x6E7AB063);
						continue;
					}
					goto IL_0062;
				case 1u:
					if (components != null)
					{
						num = -207280915;
						num3 = -207280915;
						continue;
					}
					goto IL_0062;
				case 0u:
					((Form)this).Dispose(disposing);
					num = -2001329605;
					continue;
				default:
					return;
				case 7u:
					break;
				case 3u:
					return;
					IL_0062:
					num = -870925301;
					num3 = -870925301;
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
			int num = 1803095852;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC3B3FB8u) % 117u)
				{
				case 116u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox2);
					num = (int)(num2 * 375513008) ^ -1954422532;
					continue;
				case 115u:
					Form3.smethod_39((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = (int)((num2 * 1545791556) ^ 0x61747C6);
					continue;
				case 114u:
					Form3.smethod_38((Control)(object)button7, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 702064082) ^ -1730871665;
					continue;
				case 113u:
					Form3.smethod_31((Control)(object)button2, "button2");
					num = ((int)num2 * -1642400043) ^ -1874051873;
					continue;
				case 111u:
					Form3.smethod_53((Form)(object)this, bool_0: false);
					num = (int)((num2 * 243574382) ^ 0x422304CD);
					continue;
				case 110u:
					Form3.smethod_41(textBox2, bool_0: true);
					num = ((int)num2 * -963517264) ^ -1904983440;
					continue;
				case 109u:
					NullButton = Form3.smethod_20();
					button1 = Form3.smethod_20();
					button2 = Form3.smethod_20();
					num = ((int)num2 * -1347856605) ^ 0x39786CFE;
					continue;
				case 108u:
					Form3.smethod_32((Control)(object)button4, new Size(140, 50));
					Form3.smethod_33((Control)(object)button4, 4);
					num = ((int)num2 * -2088689275) ^ -66825890;
					continue;
				case 107u:
					Form3.smethod_42(errorProvider1, (ContainerControl)(object)this);
					num = ((int)num2 * -651294643) ^ -1956838922;
					continue;
				case 106u:
					Form3.smethod_34((ButtonBase)(object)button7, bool_0: true);
					Form3.smethod_36((Control)(object)button7, (EventHandler)Button7_Click);
					num = (int)(num2 * 1362363799) ^ -307942214;
					continue;
				case 105u:
					Form3.smethod_40((Control)(object)label1, bool_0: true);
					num = (int)((num2 * 479757756) ^ 0x1EECBD30);
					continue;
				case 104u:
					Form3.smethod_38((Control)(object)button5, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 1616220556) ^ -947446931;
					continue;
				case 103u:
					Form3.smethod_34((ButtonBase)(object)button2, bool_0: true);
					num = ((int)num2 * -1820313630) ^ 0x6E6030AA;
					continue;
				case 102u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)label1);
					num = (int)((num2 * 2130544403) ^ 0x4C6FF063);
					continue;
				case 101u:
					Form3.smethod_34((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -374123545) ^ -1968896441;
					continue;
				case 100u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button7), 0);
					num = ((int)num2 * -1537499028) ^ 0x1B0A6613;
					continue;
				case 99u:
					Form3.smethod_43((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)((num2 * 1591763650) ^ 0x36AC0ADA);
					continue;
				case 98u:
					num = ((int)num2 * -15053240) ^ 0x36B9D72F;
					continue;
				case 97u:
					Form3.smethod_35((Control)(object)button1, "Вход");
					num = (int)(num2 * 1216041822) ^ -418109957;
					continue;
				case 96u:
					Form3.smethod_51((Control)(object)this, "Form3");
					num = ((int)num2 * -739775258) ^ 0x63C9CA19;
					continue;
				case 95u:
					Form3.smethod_56((Control)(object)this, bool_0: false);
					Form3.smethod_57((Control)(object)this);
					num = ((int)num2 * -1308150685) ^ -1954184822;
					continue;
				case 94u:
					Form3.smethod_35((Control)(object)label1, "QUARTO");
					num = (int)(num2 * 530706371) ^ -971266975;
					continue;
				case 93u:
					Form3.smethod_33((Control)(object)textBox2, 8);
					num = ((int)num2 * -617992823) ^ 0x3397C20F;
					continue;
				case 92u:
					Form3.smethod_33((Control)(object)button5, 5);
					num = (int)((num2 * 1536340381) ^ 0x1C4C040B);
					continue;
				case 91u:
					num = (int)(num2 * 10479581) ^ -863870637;
					continue;
				case 90u:
					textBox1 = Form3.smethod_21();
					num = ((int)num2 * -609643603) ^ -163048450;
					continue;
				case 89u:
					Form3.smethod_30((Control)(object)textBox2, new Point(174, 26));
					num = ((int)num2 * -1248099212) ^ 0x7B8141E;
					continue;
				case 88u:
					num = (int)(num2 * 1728512695) ^ -1131587150;
					continue;
				case 87u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox1);
					num = ((int)num2 * -843537380) ^ -1096456546;
					continue;
				case 86u:
					Form3.smethod_33((Control)(object)label1, 7);
					num = ((int)num2 * -587026540) ^ -1605112855;
					continue;
				case 85u:
					num = (int)(num2 * 1973898935) ^ -108750584;
					continue;
				case 84u:
					textBox2 = Form3.smethod_21();
					errorProvider1 = Form3.smethod_23(components);
					num = ((int)num2 * -658520117) ^ 0x2E53F2A3;
					continue;
				case 83u:
					num = (int)(num2 * 84942492) ^ -2050647583;
					continue;
				case 82u:
					Form3.smethod_14((Control)(object)button5, bool_0: false);
					num = (int)((num2 * 759735298) ^ 0x280F4F5A);
					continue;
				case 81u:
					num = (int)((num2 * 7872447) ^ 0x67EFAA86);
					continue;
				case 80u:
					Form3.smethod_31((Control)(object)NullButton, "NullButton");
					num = ((int)num2 * -38600655) ^ -2100533775;
					continue;
				case 79u:
					Form3.smethod_33((Control)(object)textBox1, 7);
					Form3.smethod_39((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = (int)((num2 * 79731784) ^ 0x6665ABB);
					continue;
				case 78u:
					num = ((int)num2 * -418338125) ^ -1063534795;
					continue;
				case 77u:
					num = ((int)num2 * -1597132206) ^ 0x57EE09F2;
					continue;
				case 76u:
					num = (int)((num2 * 802848854) ^ 0xB55C03D);
					continue;
				case 75u:
					Form3.smethod_44((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -2074829789) ^ -10136028;
					continue;
				case 74u:
					Form3.smethod_14((Control)(object)button4, bool_0: false);
					num = ((int)num2 * -1042190878) ^ -1311805292;
					continue;
				case 73u:
					Form3.smethod_36((Control)(object)button4, (EventHandler)Button4_Click);
					num = (int)((num2 * 407773984) ^ 0xE5787A1);
					continue;
				case 72u:
					num = ((int)num2 * -1632770621) ^ -2014964039;
					continue;
				case 70u:
					num = (int)((num2 * 1460223010) ^ 0x2A5822DD);
					continue;
				case 69u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button4);
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button2);
					num = (int)((num2 * 683408352) ^ 0x5B03A94D);
					continue;
				case 68u:
					Form3.smethod_32((Control)(object)textBox1, new Size(140, 20));
					num = ((int)num2 * -22213658) ^ -1558095229;
					continue;
				case 67u:
					Form3.smethod_38((Control)(object)button4, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -331635229) ^ 0x5B367422;
					continue;
				case 66u:
					Form3.smethod_32((Control)(object)button2, new Size(85, 21));
					Form3.smethod_33((Control)(object)button2, 1);
					Form3.smethod_35((Control)(object)button2, "Регистрация");
					num = (int)(num2 * 1718063242) ^ -1120709479;
					continue;
				case 65u:
					num = ((int)num2 * -1195333569) ^ -908309063;
					continue;
				case 64u:
					Form3.smethod_30((Control)(object)button4, new Point(174, 137));
					num = (int)((num2 * 1381243461) ^ 0x210F7FCF);
					continue;
				case 63u:
					num = (int)(num2 * 216564400) ^ -1242678702;
					continue;
				case 62u:
					Form3.smethod_36((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)(num2 * 1865137043) ^ -272885342;
					continue;
				case 61u:
					Form3.smethod_45((Form)(object)this, new Size(486, 296));
					num = (int)(num2 * 167485267) ^ -1699719836;
					continue;
				case 60u:
					Form3.smethod_38((Control)(object)label1, Form3.smethod_37("Mistral", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 1891468018) ^ 0x393A062B);
					continue;
				case 59u:
					Form3.smethod_35((Control)(object)button7, "Достижения");
					num = ((int)num2 * -2004493501) ^ 0x3688CBB3;
					continue;
				case 58u:
					Form3.smethod_34((ButtonBase)(object)button4, bool_0: true);
					num = (int)(num2 * 1866054955) ^ -908703830;
					continue;
				case 57u:
					Form3.smethod_26((Control)(object)label1, Color.Transparent);
					num = ((int)num2 * -259450371) ^ -821647616;
					continue;
				case 56u:
					num = ((int)num2 * -63709969) ^ 0x76427854;
					continue;
				case 55u:
					Form3.smethod_34((ButtonBase)(object)button5, bool_0: true);
					Form3.smethod_36((Control)(object)button5, (EventHandler)Button5_Click);
					num = ((int)num2 * -1067342990) ^ -1077033142;
					continue;
				case 54u:
					Form3.smethod_33((Control)(object)button7, 6);
					num = (int)(num2 * 117986567) ^ -109327532;
					continue;
				case 53u:
					num = (int)(num2 * 176223114) ^ -427218578;
					continue;
				case 52u:
					button7 = Form3.smethod_20();
					num = (int)((num2 * 1913286596) ^ 0x1C339E2F);
					continue;
				case 51u:
					Form3.smethod_29((ButtonBase)(object)button4, (FlatStyle)0);
					num = ((int)num2 * -145960842) ^ -485495242;
					continue;
				case 50u:
					num = (int)(num2 * 1049477660) ^ -803544424;
					continue;
				case 49u:
					Form3.smethod_33((Control)(object)NullButton, 3);
					num = ((int)num2 * -1772024623) ^ -179949350;
					continue;
				case 48u:
					Form3.smethod_24((ISupportInitialize)errorProvider1);
					num = (int)(num2 * 262448971) ^ -1499541627;
					continue;
				case 47u:
					Form3.smethod_29((ButtonBase)(object)button5, (FlatStyle)0);
					num = ((int)num2 * -1352061751) ^ -881880275;
					continue;
				case 46u:
					Form3.smethod_31((Control)(object)button5, "button5");
					Form3.smethod_32((Control)(object)button5, new Size(140, 50));
					num = (int)((num2 * 1396855047) ^ 0x65EE14D0);
					continue;
				case 45u:
					num = (int)(num2 * 1555772993) ^ -243109193;
					continue;
				case 44u:
					Form3.smethod_25((Control)(object)this);
					num = (int)((num2 * 669548663) ^ 0x7C558A2);
					continue;
				case 43u:
					Form3.smethod_26((Control)(object)NullButton, Color.Transparent);
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)NullButton), 0);
					Form3.smethod_29((ButtonBase)(object)NullButton, (FlatStyle)0);
					num = (int)((num2 * 497541827) ^ 0x28D2961B);
					continue;
				case 42u:
					num = ((int)num2 * -610288478) ^ -1406787018;
					continue;
				case 41u:
					num = (int)(num2 * 1606101046) ^ -1774203833;
					continue;
				case 40u:
					num = (int)(num2 * 1306546963) ^ -128401089;
					continue;
				case 39u:
					Form3.smethod_26((Control)(object)this, Color.White);
					num = (int)((num2 * 2139675499) ^ 0x4ACEFCBB);
					continue;
				case 38u:
					Form3.smethod_30((Control)(object)NullButton, new Point(-1, -1));
					num = ((int)num2 * -1197340120) ^ 0x33905999;
					continue;
				case 37u:
					num = ((int)num2 * -1331494530) ^ -697398673;
					continue;
				case 36u:
					Form3.smethod_31((Control)(object)label1, "label1");
					num = (int)((num2 * 631178472) ^ 0x124EC91);
					continue;
				case 35u:
					Form3.smethod_36((Control)(object)button2, (EventHandler)Button2_Click);
					num = ((int)num2 * -1023642072) ^ -2129042379;
					continue;
				case 34u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button1);
					num = (int)(num2 * 1714531777) ^ -1055547328;
					continue;
				case 33u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button7);
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button5);
					num = (int)(num2 * 1252597852) ^ -1947360623;
					continue;
				case 32u:
					Form3.smethod_32((Control)(object)label1, new Size(207, 76));
					num = (int)(num2 * 1024161758) ^ -602295076;
					continue;
				case 31u:
					Form3.smethod_31((Control)(object)button4, "button4");
					num = ((int)num2 * -2017769207) ^ -1482965457;
					continue;
				case 30u:
					Form3.smethod_49((Form)(object)this, bool_0: false);
					Form3.smethod_50((Form)(object)this, bool_0: false);
					num = (int)((num2 * 318571421) ^ 0x4C9D5E7A);
					continue;
				case 29u:
					Form3.smethod_32((Control)(object)NullButton, new Size(1, 1));
					num = (int)(num2 * 1126276267) ^ -991228889;
					continue;
				case 28u:
					num = (int)((num2 * 1352720517) ^ 0x54E1E3C9);
					continue;
				case 27u:
					Form3.smethod_30((Control)(object)label1, new Point(140, 70));
					num = ((int)num2 * -622091437) ^ -980955080;
					continue;
				case 26u:
					Form3.smethod_30((Control)(object)button7, new Point(174, 243));
					Form3.smethod_31((Control)(object)button7, "button7");
					Form3.smethod_32((Control)(object)button7, new Size(140, 50));
					num = (int)(num2 * 901028501) ^ -1567542089;
					continue;
				case 25u:
					Form3.smethod_31((Control)(object)textBox2, "textBox2");
					Form3.smethod_32((Control)(object)textBox2, new Size(140, 20));
					num = ((int)num2 * -176940381) ^ -346119172;
					continue;
				case 24u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)NullButton);
					num = (int)((num2 * 1775289057) ^ 0x580FEED1);
					continue;
				case 23u:
					components = Form3.smethod_19();
					num = (int)(num2 * 1415340860) ^ -598315316;
					continue;
				case 22u:
					label1 = Form3.smethod_22();
					num = (int)(num2 * 1540151273) ^ -1470689131;
					continue;
				case 21u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button4), 0);
					num = (int)((num2 * 629908934) ^ 0x4F0FABDB);
					continue;
				case 20u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button5), 0);
					num = (int)((num2 * 92482422) ^ 0x46599C8A);
					continue;
				case 19u:
					Form3.smethod_30((Control)(object)button2, new Point(174, 49));
					num = (int)(num2 * 1485327124) ^ -1505768687;
					continue;
				case 18u:
					num = ((int)num2 * -508021413) ^ 0x4F3BDAFE;
					continue;
				case 17u:
					Form3.smethod_52((Form)(object)this, bool_0: false);
					num = (int)((num2 * 1716766133) ^ 0x7F14885B);
					continue;
				case 16u:
					Form3.smethod_30((Control)(object)textBox1, new Point(174, 2));
					num = ((int)num2 * -1130205756) ^ 0xD11E248;
					continue;
				case 15u:
					Form3.smethod_30((Control)(object)button5, new Point(174, 190));
					num = ((int)num2 * -847670796) ^ 0x11301AED;
					continue;
				case 14u:
					Form3.smethod_32((Control)(object)button1, new Size(49, 21));
					num = (int)(num2 * 1871912342) ^ -1810818509;
					continue;
				case 13u:
					num = ((int)num2 * -1940767218) ^ -906164080;
					continue;
				case 12u:
					Form3.smethod_35((Control)(object)button5, "Продолжить");
					num = (int)((num2 * 1287982798) ^ 0x2B53F658);
					continue;
				case 11u:
					num = ((int)num2 * -2032412566) ^ 0x5EF5909D;
					continue;
				case 10u:
					Form3.smethod_35((Control)(object)button4, "Начало игры");
					num = (int)((num2 * 1583781424) ^ 0x268B9D6A);
					continue;
				case 9u:
					button4 = Form3.smethod_20();
					button5 = Form3.smethod_20();
					num = ((int)num2 * -1189223928) ^ 0x728505F9;
					continue;
				case 8u:
					num = ((int)num2 * -363178978) ^ -404997892;
					continue;
				case 7u:
					Form3.smethod_29((ButtonBase)(object)button7, (FlatStyle)0);
					num = ((int)num2 * -360451950) ^ -1416511760;
					continue;
				case 6u:
					Form3.smethod_34((ButtonBase)(object)NullButton, bool_0: false);
					Form3.smethod_30((Control)(object)button1, new Point(265, 49));
					Form3.smethod_31((Control)(object)button1, "button1");
					num = (int)((num2 * 85033188) ^ 0x74051274);
					continue;
				case 5u:
					Form3.smethod_31((Control)(object)textBox1, "textBox1");
					num = (int)(num2 * 1987772360) ^ -235127034;
					continue;
				case 4u:
					Form3.smethod_33((Control)(object)button1, 0);
					num = ((int)num2 * -1554734158) ^ -183444601;
					continue;
				case 3u:
					Form3.smethod_54((Form)(object)this, bool_0: true);
					Form3.smethod_55((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -1411119820) ^ 0x517273DB;
					continue;
				case 2u:
					num = ((int)num2 * -219628642) ^ 0x71CCE704;
					continue;
				case 1u:
					num = (int)(num2 * 284743257) ^ -634075445;
					continue;
				case 0u:
					Form3.smethod_48((Form)(object)this, (FormBorderStyle)0);
					num = (int)((num2 * 652380466) ^ 0x777F5930);
					continue;
				default:
					return;
				case 112u:
					break;
				case 71u:
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
