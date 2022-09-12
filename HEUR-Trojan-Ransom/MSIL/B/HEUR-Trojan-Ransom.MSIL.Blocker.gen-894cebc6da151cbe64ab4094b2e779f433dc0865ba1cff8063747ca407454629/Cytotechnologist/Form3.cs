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
		while (true)
		{
			int num = 1058917262;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x51AC6168u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -2059459343) ^ -1402201529;
					continue;
				case 1u:
					InitializeComponent();
					num = (int)(num2 * 1563657960) ^ -694296193;
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

	private void Button2_Click(object sender, EventArgs e)
	{
		Form val = default(Form);
		while (true)
		{
			int num = 895342535;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x41AF9368u) % 8u)
				{
				case 7u:
					Form3.smethod_0((Control)(object)NullButton);
					num = ((int)num2 * -1967723520) ^ -1958205519;
					continue;
				case 6u:
					Form3.smethod_10(val, new Point(Form3.smethod_5((Form)(object)this).X + (Form3.smethod_6((Control)(object)this) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_5((Form)(object)this).Y + (Form3.smethod_8((Control)(object)this) - Form3.smethod_9((Control)(object)val)) / 2 + 70));
					num = (int)((num2 * 1090257645) ^ 0x3AC30F92);
					continue;
				case 5u:
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = ((int)num2 * -890685946) ^ 0x42FD5EA4;
					continue;
				case 4u:
					num = ((int)num2 * -2021772810) ^ 0x2892CC25;
					continue;
				case 3u:
					Form3.smethod_4((Control)(object)val);
					num = ((int)num2 * -224931466) ^ -2141196116;
					continue;
				case 1u:
				{
					Form3.smethod_1(errorProvider1);
					Form4 form = new Form4();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					num = (int)((num2 * 1858616967) ^ 0x32737FFC);
					continue;
				}
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

	private void Button4_Click(object sender, EventArgs e)
	{
		Form val = default(Form);
		while (true)
		{
			int num = -66644769;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC08EACCFu) % 7u)
				{
				case 6u:
					Form3.smethod_4((Control)(object)val);
					num = ((int)num2 * -1346782002) ^ 0x650A4D3B;
					continue;
				case 4u:
					Form3.smethod_10(val, new Point(Form3.smethod_13(Form3.smethod_12((Form)(object)this)).X + (Form3.smethod_7((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_13(Form3.smethod_12((Form)(object)this)).Y + (Form3.smethod_9((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_9((Control)(object)val)) / 2));
					num = (int)((num2 * 610015760) ^ 0x14BAB5CB);
					continue;
				case 3u:
					num = ((int)num2 * -834984571) ^ -1798157518;
					continue;
				case 2u:
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = (int)((num2 * 3736392) ^ 0xDA55D93);
					continue;
				case 1u:
				{
					Form3.smethod_0((Control)(object)NullButton);
					Form2 form = new Form2();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					num = ((int)num2 * -2025295690) ^ -2030530267;
					continue;
				}
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

	public void Button_Continue()
	{
		Form3.smethod_14((Control)(object)button5, bool_0: true);
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = Form3.smethod_8((Control)(object)this) - 1;
			Form3.smethod_15((Control)(object)this, num);
			bool flag = num > 1;
			int num2 = 950351231;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x43F1239Au) % 8u)
				{
				case 7u:
					Form3.smethod_16(Form3.smethod_12((Form)(object)this));
					num2 = ((int)num3 * -927864117) ^ 0x399CC2EE;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 125393828;
						num5 = 125393828;
					}
					else
					{
						num4 = 1541718240;
						num5 = 1541718240;
					}
					num2 = num4 ^ ((int)num3 * -1642826739);
					continue;
				}
				case 3u:
					num2 = 1081287758;
					continue;
				case 2u:
					Form3.smethod_17((Form3.smethod_12((Form)(object)this) as Form1).timer1);
					num2 = (int)(num3 * 1546758572) ^ -81539580;
					continue;
				case 1u:
					num2 = ((int)num3 * -758359221) ^ -918752269;
					continue;
				case 0u:
					num2 = 644623681;
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
	}

	private void Button7_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 1658483006;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5F141FB2u) % 5u)
				{
				case 4u:
					num = (int)((num2 * 775308194) ^ 0x6B484AB5);
					continue;
				case 2u:
					Form3.smethod_0((Control)(object)NullButton);
					num = (int)(num2 * 176625741) ^ -2138130022;
					continue;
				case 1u:
					Form3.smethod_14((Control)(object)button7, bool_0: false);
					num = ((int)num2 * -1032819315) ^ -1915455446;
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

	protected override void Dispose(bool disposing)
	{
		while (true)
		{
			int num = -147606167;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xFAB0BD2Au) % 8u)
				{
				case 7u:
					num = ((int)num2 * -134346466) ^ -146438880;
					continue;
				case 5u:
					if (components != null)
					{
						num = -1203998973;
						num3 = -1203998973;
						continue;
					}
					goto IL_002c;
				case 4u:
					num = (int)((num2 * 736227946) ^ 0x7B4CA65D);
					continue;
				case 3u:
					if (disposing)
					{
						num = ((int)num2 * -927905351) ^ -706843756;
						continue;
					}
					goto IL_002c;
				case 1u:
					Form3.smethod_18((IDisposable)components);
					num = ((int)num2 * -727147276) ^ -1468845118;
					continue;
				case 0u:
					((Form)this).Dispose(disposing);
					num = -857768320;
					continue;
				default:
					return;
				case 6u:
					break;
				case 2u:
					return;
					IL_002c:
					num = -479658078;
					num3 = -479658078;
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
			int num = -742962422;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA6C240B7u) % 125u)
				{
				case 124u:
					Form3.smethod_33((Control)(object)button4, 4);
					num = (int)((num2 * 9216242) ^ 0xA8F920E);
					continue;
				case 123u:
					num = ((int)num2 * -973459739) ^ -314276779;
					continue;
				case 122u:
					Form3.smethod_54((Form)(object)this, bool_0: true);
					num = (int)(num2 * 1846850295) ^ -1131384547;
					continue;
				case 121u:
					num = (int)((num2 * 2124702197) ^ 0x30F9EF0);
					continue;
				case 120u:
					Form3.smethod_36((Control)(object)button4, (EventHandler)Button4_Click);
					num = ((int)num2 * -736911319) ^ 0x46144455;
					continue;
				case 119u:
					num = ((int)num2 * -1224760000) ^ -2133187060;
					continue;
				case 118u:
					Form3.smethod_35((Control)(object)button1, "Вход");
					Form3.smethod_34((ButtonBase)(object)button1, bool_0: true);
					num = (int)(num2 * 1897129915) ^ -524837427;
					continue;
				case 117u:
					Form3.smethod_33((Control)(object)button1, 0);
					num = ((int)num2 * -695974806) ^ -10293396;
					continue;
				case 116u:
					Form3.smethod_30((Control)(object)label1, new Point(140, 70));
					num = ((int)num2 * -330222427) ^ -51775037;
					continue;
				case 115u:
					num = (int)((num2 * 772348708) ^ 0x2B32A3E);
					continue;
				case 114u:
					components = Form3.smethod_19();
					NullButton = Form3.smethod_20();
					num = (int)(num2 * 1929628661) ^ -953650615;
					continue;
				case 113u:
					Form3.smethod_32((Control)(object)button2, new Size(85, 21));
					num = ((int)num2 * -1256313726) ^ 0x6182C747;
					continue;
				case 112u:
					Form3.smethod_31((Control)(object)textBox1, "textBox1");
					Form3.smethod_32((Control)(object)textBox1, new Size(140, 20));
					num = ((int)num2 * -1518177093) ^ -403670470;
					continue;
				case 111u:
					Form3.smethod_30((Control)(object)textBox2, new Point(174, 26));
					num = ((int)num2 * -1650767215) ^ 0x6008C63D;
					continue;
				case 110u:
					Form3.smethod_31((Control)(object)button2, "button2");
					num = ((int)num2 * -1699666977) ^ 0x66E1B7D1;
					continue;
				case 109u:
					Form3.smethod_39((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = (int)((num2 * 420606050) ^ 0x2E5236BC);
					continue;
				case 108u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button5), 0);
					num = (int)((num2 * 826418320) ^ 0x38DF140B);
					continue;
				case 107u:
					Form3.smethod_38((Control)(object)button4, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -248656892) ^ -1664891083;
					continue;
				case 106u:
					num = ((int)num2 * -22989606) ^ 0x5669210E;
					continue;
				case 105u:
					num = (int)((num2 * 275044217) ^ 0x5DAB997C);
					continue;
				case 104u:
					num = (int)(num2 * 1673861181) ^ -905985146;
					continue;
				case 103u:
					num = (int)((num2 * 2098820757) ^ 0x7855642A);
					continue;
				case 102u:
					num = ((int)num2 * -375678826) ^ 0x5B4DF993;
					continue;
				case 101u:
					Form3.smethod_32((Control)(object)label1, new Size(207, 76));
					num = (int)((num2 * 1406209759) ^ 0x1F8D26B4);
					continue;
				case 100u:
					Form3.smethod_34((ButtonBase)(object)button5, bool_0: true);
					num = ((int)num2 * -452935205) ^ -1167813195;
					continue;
				case 99u:
					Form3.smethod_25((Control)(object)this);
					num = ((int)num2 * -54486682) ^ 0x405FD209;
					continue;
				case 98u:
					Form3.smethod_44((ContainerControl)(object)this, (AutoScaleMode)1);
					Form3.smethod_26((Control)(object)this, Color.White);
					Form3.smethod_45((Form)(object)this, new Size(486, 296));
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox2);
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox1);
					num = (int)((num2 * 295631475) ^ 0x1FE10133);
					continue;
				case 97u:
					Form3.smethod_33((Control)(object)button5, 5);
					num = ((int)num2 * -1663549505) ^ 0x5A72E842;
					continue;
				case 96u:
					Form3.smethod_57((Control)(object)this);
					num = ((int)num2 * -1052697498) ^ -394263629;
					continue;
				case 95u:
					Form3.smethod_32((Control)(object)NullButton, new Size(1, 1));
					num = ((int)num2 * -1932232759) ^ 0x184059AB;
					continue;
				case 94u:
					Form3.smethod_34((ButtonBase)(object)NullButton, bool_0: false);
					num = ((int)num2 * -183962071) ^ -528724020;
					continue;
				case 93u:
					textBox1 = Form3.smethod_21();
					num = ((int)num2 * -1106967755) ^ -792193757;
					continue;
				case 92u:
					num = (int)(num2 * 946492068) ^ -1885807027;
					continue;
				case 91u:
					Form3.smethod_29((ButtonBase)(object)button4, (FlatStyle)0);
					num = ((int)num2 * -307871310) ^ -525221623;
					continue;
				case 90u:
					num = (int)((num2 * 1795444261) ^ 0x1C61EF71);
					continue;
				case 89u:
					num = ((int)num2 * -1128191606) ^ -2069794983;
					continue;
				case 88u:
					Form3.smethod_30((Control)(object)button4, new Point(174, 137));
					num = (int)((num2 * 1714724062) ^ 0xAFC0A2B);
					continue;
				case 87u:
					Form3.smethod_31((Control)(object)button1, "button1");
					Form3.smethod_32((Control)(object)button1, new Size(49, 21));
					num = (int)((num2 * 99264767) ^ 0x1C3E8A11);
					continue;
				case 86u:
					Form3.smethod_30((Control)(object)button5, new Point(174, 190));
					num = ((int)num2 * -1978315826) ^ -1280986997;
					continue;
				case 85u:
					Form3.smethod_36((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -1360258280) ^ 0x2C38A44B;
					continue;
				case 84u:
					Form3.smethod_33((Control)(object)button2, 1);
					num = ((int)num2 * -992531181) ^ -988099656;
					continue;
				case 83u:
					num = (int)(num2 * 637543245) ^ -1660310664;
					continue;
				case 82u:
					Form3.smethod_33((Control)(object)label1, 7);
					num = ((int)num2 * -1917857748) ^ 0x24441767;
					continue;
				case 81u:
					Form3.smethod_30((Control)(object)NullButton, new Point(-1, -1));
					num = (int)((num2 * 1619550626) ^ 0x333E1F46);
					continue;
				case 80u:
					num = (int)(num2 * 1912827114) ^ -1082863186;
					continue;
				case 79u:
					Form3.smethod_30((Control)(object)button7, new Point(174, 243));
					num = (int)(num2 * 1677789663) ^ -1673175412;
					continue;
				case 78u:
					button2 = Form3.smethod_20();
					num = ((int)num2 * -240733060) ^ -386249986;
					continue;
				case 77u:
					num = ((int)num2 * -1989391492) ^ 0x37C535E6;
					continue;
				case 76u:
					num = (int)((num2 * 1621236927) ^ 0x9B367AB);
					continue;
				case 75u:
					Form3.smethod_36((Control)(object)button2, (EventHandler)Button2_Click);
					Form3.smethod_14((Control)(object)button4, bool_0: false);
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button4), 0);
					num = (int)((num2 * 936838525) ^ 0x1A21831D);
					continue;
				case 74u:
					num = ((int)num2 * -200029120) ^ 0x1F8F6528;
					continue;
				case 73u:
					num = ((int)num2 * -1689826449) ^ -499729486;
					continue;
				case 72u:
					Form3.smethod_34((ButtonBase)(object)button4, bool_0: true);
					num = ((int)num2 * -697750646) ^ 0x9347B83;
					continue;
				case 71u:
					button1 = Form3.smethod_20();
					num = (int)((num2 * 1296461088) ^ 0x5BA6DAD1);
					continue;
				case 70u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -1698594329) ^ 0x5DC2165D;
					continue;
				case 69u:
					num = (int)((num2 * 738673928) ^ 0x60DEA912);
					continue;
				case 68u:
					Form3.smethod_52((Form)(object)this, bool_0: false);
					Form3.smethod_53((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1333044384) ^ -265251219;
					continue;
				case 67u:
					num = (int)(num2 * 179490964) ^ -190950643;
					continue;
				case 66u:
					Form3.smethod_48((Form)(object)this, (FormBorderStyle)0);
					num = (int)(num2 * 422719240) ^ -409981024;
					continue;
				case 65u:
					Form3.smethod_42(errorProvider1, (ContainerControl)(object)this);
					num = ((int)num2 * -976007048) ^ -644394797;
					continue;
				case 64u:
					num = ((int)num2 * -1210841209) ^ -785850867;
					continue;
				case 63u:
					num = ((int)num2 * -141391105) ^ -1173560046;
					continue;
				case 62u:
					Form3.smethod_32((Control)(object)button5, new Size(140, 50));
					num = ((int)num2 * -947486227) ^ -1010287810;
					continue;
				case 61u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button7), 0);
					Form3.smethod_29((ButtonBase)(object)button7, (FlatStyle)0);
					Form3.smethod_38((Control)(object)button7, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -825781243) ^ 0x26C06684;
					continue;
				case 60u:
					Form3.smethod_33((Control)(object)textBox1, 7);
					num = (int)(num2 * 1188202434) ^ -557048241;
					continue;
				case 59u:
					num = (int)(num2 * 670912308) ^ -1312585310;
					continue;
				case 58u:
					num = (int)((num2 * 165682110) ^ 0x5143FD1);
					continue;
				case 57u:
					Form3.smethod_40((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -1374216245) ^ -1814001850;
					continue;
				case 56u:
					Form3.smethod_31((Control)(object)textBox2, "textBox2");
					Form3.smethod_32((Control)(object)textBox2, new Size(140, 20));
					Form3.smethod_33((Control)(object)textBox2, 8);
					Form3.smethod_41(textBox2, bool_0: true);
					num = (int)((num2 * 561069642) ^ 0x1E99493E);
					continue;
				case 55u:
					num = (int)((num2 * 529317511) ^ 0x7319E242);
					continue;
				case 54u:
					Form3.smethod_35((Control)(object)label1, "QUARTO");
					num = (int)(num2 * 361947880) ^ -2124748080;
					continue;
				case 53u:
					Form3.smethod_39((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -854084154) ^ 0x1D88C7C8;
					continue;
				case 52u:
					num = (int)((num2 * 1694650569) ^ 0x4883C5D4);
					continue;
				case 51u:
					Form3.smethod_51((Control)(object)this, "Form3");
					num = (int)(num2 * 57902910) ^ -1087012581;
					continue;
				case 50u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)NullButton), 0);
					num = ((int)num2 * -247180815) ^ -577187386;
					continue;
				case 48u:
					Form3.smethod_33((Control)(object)button7, 6);
					Form3.smethod_35((Control)(object)button7, "Достижения");
					Form3.smethod_34((ButtonBase)(object)button7, bool_0: true);
					num = ((int)num2 * -424002320) ^ -45074994;
					continue;
				case 47u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button1);
					num = (int)(num2 * 553508663) ^ -381765977;
					continue;
				case 46u:
					Form3.smethod_30((Control)(object)button1, new Point(265, 49));
					num = ((int)num2 * -918465538) ^ -1373590795;
					continue;
				case 45u:
					num = (int)(num2 * 229743617) ^ -2114660941;
					continue;
				case 44u:
					num = ((int)num2 * -1327841272) ^ -293040027;
					continue;
				case 43u:
					num = (int)(num2 * 649960538) ^ -1436249965;
					continue;
				case 42u:
					Form3.smethod_35((Control)(object)button2, "Регистрация");
					num = (int)((num2 * 591931948) ^ 0x15A205BC);
					continue;
				case 41u:
					Form3.smethod_43((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -1514663701) ^ 0x10C3A39E;
					continue;
				case 40u:
					Form3.smethod_50((Form)(object)this, bool_0: false);
					num = ((int)num2 * -394501621) ^ 0x69EDA1FD;
					continue;
				case 39u:
					Form3.smethod_31((Control)(object)NullButton, "NullButton");
					num = ((int)num2 * -94311952) ^ 0x1E6CEBB0;
					continue;
				case 38u:
					Form3.smethod_30((Control)(object)button2, new Point(174, 49));
					num = ((int)num2 * -1262662758) ^ -1131393856;
					continue;
				case 37u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button5);
					num = ((int)num2 * -95095877) ^ 0x745B65E6;
					continue;
				case 36u:
					Form3.smethod_31((Control)(object)button7, "button7");
					Form3.smethod_32((Control)(object)button7, new Size(140, 50));
					num = (int)((num2 * 1364416436) ^ 0x109DE1C6);
					continue;
				case 35u:
					num = (int)((num2 * 105356792) ^ 0x455906AB);
					continue;
				case 34u:
					Form3.smethod_26((Control)(object)label1, Color.Transparent);
					num = ((int)num2 * -184167459) ^ 0x145A0BA1;
					continue;
				case 33u:
					label1 = Form3.smethod_22();
					textBox2 = Form3.smethod_21();
					errorProvider1 = Form3.smethod_23(components);
					Form3.smethod_24((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -1009075275) ^ 0x5541BF59;
					continue;
				case 32u:
					num = (int)(num2 * 1001542098) ^ -1899109386;
					continue;
				case 30u:
					num = (int)(num2 * 1544821611) ^ -791726333;
					continue;
				case 29u:
					Form3.smethod_38((Control)(object)label1, Form3.smethod_37("Mistral", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 19672938) ^ 0x14087D34);
					continue;
				case 28u:
					Form3.smethod_33((Control)(object)NullButton, 3);
					num = ((int)num2 * -1000363268) ^ 0x239DA4A2;
					continue;
				case 27u:
					Form3.smethod_35((Control)(object)button5, "Продолжить");
					num = (int)((num2 * 758666665) ^ 0x30E39E);
					continue;
				case 26u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button4);
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button2);
					num = ((int)num2 * -908771918) ^ -1837731449;
					continue;
				case 25u:
					num = (int)(num2 * 297131264) ^ -1243272906;
					continue;
				case 24u:
					num = ((int)num2 * -554196741) ^ -521381400;
					continue;
				case 23u:
					Form3.smethod_31((Control)(object)button5, "button5");
					num = (int)(num2 * 2123185685) ^ -1381749104;
					continue;
				case 22u:
					num = ((int)num2 * -251566553) ^ -2072673482;
					continue;
				case 21u:
					Form3.smethod_29((ButtonBase)(object)button5, (FlatStyle)0);
					Form3.smethod_38((Control)(object)button5, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 1556762715) ^ -1420634360;
					continue;
				case 20u:
					Form3.smethod_14((Control)(object)button5, bool_0: false);
					num = (int)(num2 * 69721892) ^ -1724830451;
					continue;
				case 19u:
					num = (int)((num2 * 1592207485) ^ 0x49A86E59);
					continue;
				case 18u:
					Form3.smethod_31((Control)(object)button4, "button4");
					num = (int)((num2 * 878376447) ^ 0x29E8322F);
					continue;
				case 17u:
					Form3.smethod_32((Control)(object)button4, new Size(140, 50));
					num = ((int)num2 * -634187703) ^ -1902293533;
					continue;
				case 16u:
					Form3.smethod_55((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -23986267) ^ 0x1832D1DA;
					continue;
				case 15u:
					Form3.smethod_56((Control)(object)this, bool_0: false);
					num = (int)(num2 * 749702643) ^ -1350107474;
					continue;
				case 14u:
					button4 = Form3.smethod_20();
					button5 = Form3.smethod_20();
					button7 = Form3.smethod_20();
					num = (int)((num2 * 1551087543) ^ 0x4DF62046);
					continue;
				case 13u:
					Form3.smethod_29((ButtonBase)(object)NullButton, (FlatStyle)0);
					num = (int)(num2 * 772291561) ^ -1551285392;
					continue;
				case 12u:
					num = (int)((num2 * 348601971) ^ 0x46AFA4B0);
					continue;
				case 11u:
					Form3.smethod_36((Control)(object)button7, (EventHandler)Button7_Click);
					Form3.smethod_30((Control)(object)textBox1, new Point(174, 2));
					num = (int)(num2 * 599668336) ^ -780947944;
					continue;
				case 10u:
					num = (int)(num2 * 2010994676) ^ -403038290;
					continue;
				case 9u:
					Form3.smethod_36((Control)(object)button5, (EventHandler)Button5_Click);
					num = ((int)num2 * -2072593349) ^ 0x58EC828A;
					continue;
				case 8u:
					Form3.smethod_49((Form)(object)this, bool_0: false);
					num = (int)((num2 * 1960202660) ^ 0x70D29DE0);
					continue;
				case 7u:
					Form3.smethod_31((Control)(object)label1, "label1");
					num = (int)(num2 * 445752671) ^ -1312546570;
					continue;
				case 6u:
					Form3.smethod_34((ButtonBase)(object)button2, bool_0: true);
					num = ((int)num2 * -2075786930) ^ 0x6DC0AF90;
					continue;
				case 5u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button7);
					num = ((int)num2 * -923728198) ^ 0xB819465;
					continue;
				case 4u:
					num = ((int)num2 * -1436167044) ^ -814340289;
					continue;
				case 3u:
					Form3.smethod_35((Control)(object)button4, "Начало игры");
					num = ((int)num2 * -1974239360) ^ 0x4CC0E9C9;
					continue;
				case 2u:
					Form3.smethod_26((Control)(object)NullButton, Color.Transparent);
					num = ((int)num2 * -738919973) ^ -725484312;
					continue;
				case 1u:
					num = ((int)num2 * -1010040326) ^ -754909466;
					continue;
				case 0u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)NullButton);
					num = (int)((num2 * 1517295295) ^ 0x45DE16AE);
					continue;
				default:
					return;
				case 49u:
					break;
				case 31u:
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
