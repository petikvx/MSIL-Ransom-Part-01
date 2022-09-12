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
		Form val = default(Form);
		while (true)
		{
			int num = 292872054;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5ACC9DCu) % 8u)
				{
				case 5u:
					Form3.smethod_10(val, new Point(Form3.smethod_5((Form)(object)this).X + (Form3.smethod_6((Control)(object)this) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_5((Form)(object)this).Y + (Form3.smethod_8((Control)(object)this) - Form3.smethod_9((Control)(object)val)) / 2 + 70));
					num = ((int)num2 * -1590991203) ^ 0x27D0C06E;
					continue;
				case 4u:
				{
					Form3.smethod_1(errorProvider1);
					Form4 form = new Form4();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					num = (int)((num2 * 1256125628) ^ 0x29894DBC);
					continue;
				}
				case 3u:
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = (int)((num2 * 506411729) ^ 0x696ECDA8);
					continue;
				case 2u:
					Form3.smethod_0((Control)(object)NullButton);
					num = (int)(num2 * 1338153361) ^ -1740734310;
					continue;
				case 1u:
					num = (int)(num2 * 837124779) ^ -498623510;
					continue;
				case 0u:
					Form3.smethod_4((Control)(object)val);
					num = (int)((num2 * 1337340583) ^ 0x2A43855);
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

	private void Button4_Click(object sender, EventArgs e)
	{
		Form3.smethod_0((Control)(object)NullButton);
		Form val = default(Form);
		while (true)
		{
			int num = 467796444;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x360D4430u) % 6u)
				{
				case 5u:
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = ((int)num2 * -1898641034) ^ 0xE06FB59;
					continue;
				case 4u:
				{
					Form2 form = new Form2();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					num = ((int)num2 * -123476410) ^ -1949419734;
					continue;
				}
				case 2u:
					Form3.smethod_4((Control)(object)val);
					Form3.smethod_10(val, new Point(Form3.smethod_13(Form3.smethod_12((Form)(object)this)).X + (Form3.smethod_7((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_13(Form3.smethod_12((Form)(object)this)).Y + (Form3.smethod_9((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_9((Control)(object)val)) / 2));
					num = (int)((num2 * 2125691907) ^ 0x2EFCBF21);
					continue;
				case 1u:
					num = ((int)num2 * -1139805091) ^ -1440326286;
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

	public void Button_Continue()
	{
		Form3.smethod_14((Control)(object)button5, bool_0: true);
		while (true)
		{
			int num = 1346545692;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1BDB89u) % 3u)
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
				num = (int)(num2 * 1106696591) ^ -1574243143;
			}
		}
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = Form3.smethod_8((Control)(object)this) - 1;
			Form3.smethod_15((Control)(object)this, num);
			int num2;
			int num3;
			if (num <= 1)
			{
				num2 = -2072461968;
				num3 = -2072461968;
			}
			else
			{
				num2 = -2029413096;
				num3 = -2029413096;
			}
			while (true)
			{
				uint num4;
				switch ((num4 = (uint)num2 ^ 0xA420A869u) % 7u)
				{
				case 6u:
					num2 = -2029413096;
					continue;
				case 5u:
					Form3.smethod_17((Form3.smethod_12((Form)(object)this) as Form1).timer1);
					num2 = ((int)num4 * -293161064) ^ 0x3141D5C6;
					continue;
				case 2u:
					Form3.smethod_16(Form3.smethod_12((Form)(object)this));
					num2 = (int)((num4 * 79100372) ^ 0x59461012);
					continue;
				case 1u:
					num2 = -1948707057;
					continue;
				case 0u:
					num2 = ((int)num4 * -1020044190) ^ 0x5A896808;
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
			int num = -1268452745;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x86E65B5Fu) % 3u)
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
				num = ((int)num2 * -1165796895) ^ -576434197;
			}
		}
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
			int num = -1004733011;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xEE5BB31Fu) % 7u)
				{
				case 5u:
					if (components != null)
					{
						num = -1631115379;
						num3 = -1631115379;
						continue;
					}
					goto IL_0011;
				case 4u:
					num = (int)(num2 * 2028981350) ^ -1610418447;
					continue;
				case 2u:
					if (disposing)
					{
						num = (int)((num2 * 441606112) ^ 0x732D4D59);
						continue;
					}
					goto IL_0011;
				case 1u:
					((Form)this).Dispose(disposing);
					num = -903116214;
					continue;
				case 0u:
					Form3.smethod_18((IDisposable)components);
					num = ((int)num2 * -1538797511) ^ -271232047;
					continue;
				default:
					return;
				case 3u:
					break;
				case 6u:
					return;
					IL_0011:
					num = -1080110919;
					num3 = -1080110919;
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
			int num = 927134309;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4685B3F9u) % 132u)
				{
				case 131u:
					NullButton = Form3.smethod_20();
					button1 = Form3.smethod_20();
					button2 = Form3.smethod_20();
					num = (int)((num2 * 596228603) ^ 0x3046EBFD);
					continue;
				case 130u:
					button5 = Form3.smethod_20();
					button7 = Form3.smethod_20();
					num = ((int)num2 * -1410447436) ^ 0x154C778A;
					continue;
				case 129u:
					Form3.smethod_33((Control)(object)button2, 1);
					num = (int)(num2 * 1796527000) ^ -151866766;
					continue;
				case 128u:
					Form3.smethod_32((Control)(object)button4, new Size(140, 50));
					num = ((int)num2 * -689376336) ^ -1073634208;
					continue;
				case 127u:
					Form3.smethod_24((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -2013668832) ^ 0x2799F8F0;
					continue;
				case 126u:
					num = (int)(num2 * 627494074) ^ -374882164;
					continue;
				case 125u:
					Form3.smethod_25((Control)(object)this);
					num = (int)(num2 * 531422657) ^ -997002400;
					continue;
				case 124u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button5), 0);
					num = (int)((num2 * 1482423466) ^ 0x15556741);
					continue;
				case 123u:
					Form3.smethod_35((Control)(object)button2, "Регистрация");
					num = ((int)num2 * -308188246) ^ -1687489558;
					continue;
				case 122u:
					Form3.smethod_32((Control)(object)textBox2, new Size(140, 20));
					num = ((int)num2 * -1844418925) ^ -1661662650;
					continue;
				case 121u:
					num = ((int)num2 * -786537638) ^ -1190297706;
					continue;
				case 120u:
					Form3.smethod_14((Control)(object)button5, bool_0: false);
					num = (int)(num2 * 829432831) ^ -941217877;
					continue;
				case 119u:
					textBox1 = Form3.smethod_21();
					num = (int)(num2 * 1246012238) ^ -2078371097;
					continue;
				case 118u:
					Form3.smethod_29((ButtonBase)(object)button7, (FlatStyle)0);
					num = (int)((num2 * 317715310) ^ 0x68A2F4D9);
					continue;
				case 117u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button7);
					num = (int)((num2 * 2027097209) ^ 0x5AFD9400);
					continue;
				case 116u:
					Form3.smethod_34((ButtonBase)(object)button5, bool_0: true);
					num = (int)(num2 * 745099429) ^ -602739693;
					continue;
				case 115u:
					num = ((int)num2 * -1795483864) ^ -1436054779;
					continue;
				case 114u:
					num = ((int)num2 * -491185888) ^ -332555459;
					continue;
				case 113u:
					Form3.smethod_33((Control)(object)button4, 4);
					num = ((int)num2 * -1152786135) ^ 0x2ED67A33;
					continue;
				case 112u:
					num = ((int)num2 * -296155871) ^ -881085691;
					continue;
				case 111u:
					Form3.smethod_31((Control)(object)button2, "button2");
					num = (int)((num2 * 443302989) ^ 0x5EB0BC4B);
					continue;
				case 110u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox1);
					num = ((int)num2 * -1508684446) ^ -495107776;
					continue;
				case 109u:
					num = ((int)num2 * -1807204491) ^ 0x34657C01;
					continue;
				case 108u:
					num = ((int)num2 * -2014203247) ^ -987609599;
					continue;
				case 107u:
					num = ((int)num2 * -972503578) ^ 0x17427E80;
					continue;
				case 106u:
					Form3.smethod_14((Control)(object)button4, bool_0: false);
					num = (int)((num2 * 1900435615) ^ 0x6C570D18);
					continue;
				case 105u:
					num = (int)((num2 * 1663035201) ^ 0x3ED03960);
					continue;
				case 104u:
					Form3.smethod_29((ButtonBase)(object)NullButton, (FlatStyle)0);
					num = ((int)num2 * -111855374) ^ -983381247;
					continue;
				case 103u:
					num = ((int)num2 * -1584335817) ^ -1971499805;
					continue;
				case 102u:
					num = ((int)num2 * -86138910) ^ 0x55FA341A;
					continue;
				case 101u:
					Form3.smethod_31((Control)(object)button5, "button5");
					num = (int)((num2 * 924139462) ^ 0x9E48895);
					continue;
				case 100u:
					Form3.smethod_30((Control)(object)button4, new Point(174, 137));
					Form3.smethod_31((Control)(object)button4, "button4");
					num = ((int)num2 * -482794679) ^ -1025476325;
					continue;
				case 99u:
					Form3.smethod_34((ButtonBase)(object)button2, bool_0: true);
					num = (int)(num2 * 805276003) ^ -860373885;
					continue;
				case 98u:
					num = (int)((num2 * 1173711433) ^ 0x66DA1F47);
					continue;
				case 97u:
					Form3.smethod_31((Control)(object)textBox1, "textBox1");
					num = (int)((num2 * 804876174) ^ 0x3E66B001);
					continue;
				case 96u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)NullButton), 0);
					num = (int)((num2 * 1271682277) ^ 0x19DA523D);
					continue;
				case 95u:
					Form3.smethod_42(errorProvider1, (ContainerControl)(object)this);
					num = (int)(num2 * 1894671812) ^ -654187738;
					continue;
				case 94u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button4), 0);
					num = (int)((num2 * 840163857) ^ 0x103F549C);
					continue;
				case 93u:
					Form3.smethod_38((Control)(object)button4, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 1161440867) ^ -1964006262;
					continue;
				case 92u:
					Form3.smethod_29((ButtonBase)(object)button5, (FlatStyle)0);
					num = ((int)num2 * -903043608) ^ -628128026;
					continue;
				case 91u:
					Form3.smethod_31((Control)(object)NullButton, "NullButton");
					Form3.smethod_32((Control)(object)NullButton, new Size(1, 1));
					Form3.smethod_33((Control)(object)NullButton, 3);
					num = (int)((num2 * 585669712) ^ 0x44D03639);
					continue;
				case 90u:
					Form3.smethod_31((Control)(object)button7, "button7");
					num = ((int)num2 * -1287932361) ^ -1997642845;
					continue;
				case 89u:
					Form3.smethod_38((Control)(object)button5, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 2098501456) ^ 0x5F51273F);
					continue;
				case 88u:
					Form3.smethod_31((Control)(object)button1, "button1");
					num = (int)((num2 * 969342218) ^ 0x3153F701);
					continue;
				case 87u:
					Form3.smethod_30((Control)(object)button2, new Point(174, 49));
					num = ((int)num2 * -1519254184) ^ 0x74C0B35B;
					continue;
				case 86u:
					Form3.smethod_39((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = (int)(num2 * 1887833219) ^ -1121484146;
					continue;
				case 85u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -1319749519) ^ 0x1680AB0D;
					continue;
				case 84u:
					Form3.smethod_26((Control)(object)this, Color.White);
					num = (int)(num2 * 1392063751) ^ -760059266;
					continue;
				case 83u:
					Form3.smethod_36((Control)(object)button2, (EventHandler)Button2_Click);
					num = ((int)num2 * -1861742659) ^ -823238595;
					continue;
				case 82u:
					Form3.smethod_52((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1041567535) ^ -1987384528;
					continue;
				case 81u:
					Form3.smethod_35((Control)(object)button7, "Достижения");
					num = ((int)num2 * -520894327) ^ -1974383196;
					continue;
				case 80u:
					Form3.smethod_26((Control)(object)NullButton, Color.Transparent);
					num = (int)((num2 * 1850862332) ^ 0x55CA0C45);
					continue;
				case 79u:
					Form3.smethod_49((Form)(object)this, bool_0: false);
					Form3.smethod_50((Form)(object)this, bool_0: false);
					num = (int)((num2 * 1444745062) ^ 0x11E08C15);
					continue;
				case 78u:
					Form3.smethod_30((Control)(object)button5, new Point(174, 190));
					num = (int)((num2 * 2108602616) ^ 0x3356D864);
					continue;
				case 77u:
					num = ((int)num2 * -1451725920) ^ 0x2C095B88;
					continue;
				case 76u:
					num = (int)(num2 * 1102022156) ^ -239567723;
					continue;
				case 75u:
					num = ((int)num2 * -1908984230) ^ 0x4CD37A3E;
					continue;
				case 74u:
					Form3.smethod_32((Control)(object)textBox1, new Size(140, 20));
					Form3.smethod_33((Control)(object)textBox1, 7);
					num = ((int)num2 * -725734397) ^ -41181719;
					continue;
				case 73u:
					Form3.smethod_45((Form)(object)this, new Size(486, 296));
					num = ((int)num2 * -640901047) ^ -1700399974;
					continue;
				case 72u:
					label1 = Form3.smethod_22();
					num = (int)(num2 * 999822495) ^ -2074961941;
					continue;
				case 71u:
					num = (int)((num2 * 727058242) ^ 0x45BA2BEA);
					continue;
				case 70u:
					num = ((int)num2 * -1054647447) ^ -1987234198;
					continue;
				case 69u:
					Form3.smethod_34((ButtonBase)(object)button4, bool_0: true);
					num = (int)(num2 * 979868317) ^ -2021336114;
					continue;
				case 68u:
					Form3.smethod_30((Control)(object)NullButton, new Point(-1, -1));
					num = (int)(num2 * 930322255) ^ -688961226;
					continue;
				case 67u:
					num = (int)((num2 * 1139973005) ^ 0x3E1922A9);
					continue;
				case 66u:
					num = (int)(num2 * 592580187) ^ -1792598801;
					continue;
				case 65u:
					num = (int)(num2 * 1228509192) ^ -618946218;
					continue;
				case 64u:
					Form3.smethod_35((Control)(object)label1, "QUARTO");
					num = (int)(num2 * 1060354658) ^ -1199276070;
					continue;
				case 63u:
					Form3.smethod_33((Control)(object)textBox2, 8);
					Form3.smethod_41(textBox2, bool_0: true);
					num = ((int)num2 * -526292808) ^ 0x12F6734A;
					continue;
				case 62u:
					num = (int)(num2 * 1645854137) ^ -416490664;
					continue;
				case 61u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox2);
					num = (int)((num2 * 1455640459) ^ 0x7203B904);
					continue;
				case 60u:
					Form3.smethod_32((Control)(object)button7, new Size(140, 50));
					num = (int)(num2 * 1359484860) ^ -1489603593;
					continue;
				case 59u:
					num = (int)(num2 * 193960108) ^ -1916615476;
					continue;
				case 58u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)NullButton);
					Form3.smethod_48((Form)(object)this, (FormBorderStyle)0);
					num = (int)((num2 * 239403219) ^ 0x7542C6A5);
					continue;
				case 57u:
					Form3.smethod_36((Control)(object)button7, (EventHandler)Button7_Click);
					num = (int)((num2 * 669029508) ^ 0x70240C55);
					continue;
				case 56u:
					components = Form3.smethod_19();
					num = ((int)num2 * -2062719535) ^ -569000418;
					continue;
				case 55u:
					Form3.smethod_35((Control)(object)button4, "Начало игры");
					num = (int)(num2 * 407661453) ^ -1621726101;
					continue;
				case 54u:
					num = ((int)num2 * -403956796) ^ -678324698;
					continue;
				case 53u:
					Form3.smethod_36((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)(num2 * 243665922) ^ -2035103988;
					continue;
				case 52u:
					Form3.smethod_32((Control)(object)button1, new Size(49, 21));
					num = (int)((num2 * 632060797) ^ 0x1F355CD7);
					continue;
				case 51u:
					num = ((int)num2 * -559983493) ^ -544960358;
					continue;
				case 50u:
					Form3.smethod_35((Control)(object)button1, "Вход");
					num = (int)(num2 * 589337263) ^ -1483654870;
					continue;
				case 49u:
					Form3.smethod_30((Control)(object)label1, new Point(140, 70));
					num = ((int)num2 * -1491227425) ^ -1497151740;
					continue;
				case 48u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button5);
					num = (int)((num2 * 1707680127) ^ 0xE6251EF);
					continue;
				case 47u:
					num = (int)(num2 * 310711538) ^ -972291812;
					continue;
				case 46u:
					Form3.smethod_36((Control)(object)button5, (EventHandler)Button5_Click);
					num = ((int)num2 * -1298881206) ^ 0x2D0AD820;
					continue;
				case 45u:
					num = ((int)num2 * -365383254) ^ 0x556B9665;
					continue;
				case 44u:
					Form3.smethod_30((Control)(object)textBox1, new Point(174, 2));
					num = ((int)num2 * -472372174) ^ 0xB3D6BB4;
					continue;
				case 43u:
					Form3.smethod_31((Control)(object)textBox2, "textBox2");
					num = ((int)num2 * -1476501091) ^ -1835334368;
					continue;
				case 42u:
					num = ((int)num2 * -719894098) ^ -1130917424;
					continue;
				case 41u:
					Form3.smethod_33((Control)(object)button5, 5);
					num = ((int)num2 * -649641249) ^ 0x5E63F4F4;
					continue;
				case 40u:
					Form3.smethod_30((Control)(object)textBox2, new Point(174, 26));
					num = (int)((num2 * 900554915) ^ 0x703A736E);
					continue;
				case 39u:
					Form3.smethod_29((ButtonBase)(object)button4, (FlatStyle)0);
					num = (int)((num2 * 505197573) ^ 0x4EE369DD);
					continue;
				case 38u:
					Form3.smethod_54((Form)(object)this, bool_0: true);
					Form3.smethod_55((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -1838697993) ^ -1824411784;
					continue;
				case 37u:
					num = (int)(num2 * 381060361) ^ -1347456153;
					continue;
				case 36u:
					num = (int)((num2 * 991310078) ^ 0x21D808B5);
					continue;
				case 35u:
					Form3.smethod_56((Control)(object)this, bool_0: false);
					Form3.smethod_57((Control)(object)this);
					num = ((int)num2 * -1491164315) ^ 0x7C772999;
					continue;
				case 34u:
					num = (int)(num2 * 919111182) ^ -551620271;
					continue;
				case 33u:
					num = (int)(num2 * 1265987961) ^ -1537019371;
					continue;
				case 32u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button4);
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button2);
					num = (int)(num2 * 556116464) ^ -1145975502;
					continue;
				case 31u:
					Form3.smethod_35((Control)(object)button5, "Продолжить");
					num = ((int)num2 * -2100319857) ^ 0x20CC1E90;
					continue;
				case 30u:
					Form3.smethod_33((Control)(object)button1, 0);
					num = (int)(num2 * 1183800245) ^ -668014391;
					continue;
				case 29u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button7), 0);
					num = (int)((num2 * 140096262) ^ 0x25BD838F);
					continue;
				case 27u:
					num = ((int)num2 * -439116887) ^ -49912730;
					continue;
				case 26u:
					num = (int)(num2 * 1796862348) ^ -2116705132;
					continue;
				case 25u:
					num = ((int)num2 * -1712956160) ^ 0x29D89A1F;
					continue;
				case 24u:
					Form3.smethod_26((Control)(object)label1, Color.Transparent);
					Form3.smethod_38((Control)(object)label1, Form3.smethod_37("Mistral", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 465179598) ^ 0x50C1B459);
					continue;
				case 23u:
					Form3.smethod_53((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1125349) ^ -181363181;
					continue;
				case 22u:
					Form3.smethod_32((Control)(object)button5, new Size(140, 50));
					num = (int)(num2 * 143546212) ^ -593766744;
					continue;
				case 21u:
					Form3.smethod_51((Control)(object)this, "Form3");
					num = ((int)num2 * -1981553757) ^ -2005479832;
					continue;
				case 20u:
					Form3.smethod_39((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -28714950) ^ 0x604983AE;
					continue;
				case 19u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -471443872) ^ 0x45268CE7;
					continue;
				case 18u:
					textBox2 = Form3.smethod_21();
					errorProvider1 = Form3.smethod_23(components);
					num = ((int)num2 * -1846823444) ^ -488938530;
					continue;
				case 17u:
					Form3.smethod_32((Control)(object)button2, new Size(85, 21));
					num = (int)(num2 * 1579808557) ^ -1019267279;
					continue;
				case 16u:
					Form3.smethod_34((ButtonBase)(object)NullButton, bool_0: false);
					Form3.smethod_30((Control)(object)button1, new Point(265, 49));
					num = ((int)num2 * -1821634274) ^ 0x49973F21;
					continue;
				case 14u:
					num = ((int)num2 * -2007209326) ^ -725694010;
					continue;
				case 13u:
					Form3.smethod_40((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -208104686) ^ 0xE2DCB73;
					continue;
				case 12u:
					Form3.smethod_34((ButtonBase)(object)button7, bool_0: true);
					num = (int)((num2 * 1437542043) ^ 0x7C033BA8);
					continue;
				case 11u:
					num = (int)((num2 * 207854885) ^ 0x76A0C6A0);
					continue;
				case 10u:
					Form3.smethod_32((Control)(object)label1, new Size(207, 76));
					Form3.smethod_33((Control)(object)label1, 7);
					num = (int)((num2 * 1303130586) ^ 0x24F97C24);
					continue;
				case 9u:
					Form3.smethod_34((ButtonBase)(object)button1, bool_0: true);
					num = (int)((num2 * 1091539664) ^ 0x29492F1F);
					continue;
				case 8u:
					Form3.smethod_38((Control)(object)button7, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 1337817584) ^ 0x59F496B8);
					continue;
				case 7u:
					Form3.smethod_43((ContainerControl)(object)this, new SizeF(6f, 13f));
					Form3.smethod_44((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -609674676) ^ 0x43187E6D;
					continue;
				case 6u:
					Form3.smethod_36((Control)(object)button4, (EventHandler)Button4_Click);
					num = ((int)num2 * -945375647) ^ -1444961231;
					continue;
				case 5u:
					button4 = Form3.smethod_20();
					num = (int)((num2 * 576374922) ^ 0x50EBA3B1);
					continue;
				case 4u:
					num = (int)((num2 * 814550271) ^ 0x3540804F);
					continue;
				case 3u:
					Form3.smethod_31((Control)(object)label1, "label1");
					num = (int)(num2 * 857946193) ^ -1229342812;
					continue;
				case 2u:
					Form3.smethod_33((Control)(object)button7, 6);
					num = ((int)num2 * -1713256839) ^ 0x21431CFA;
					continue;
				case 1u:
					Form3.smethod_30((Control)(object)button7, new Point(174, 243));
					num = ((int)num2 * -2138837670) ^ -1191161315;
					continue;
				case 0u:
					num = (int)((num2 * 1922698879) ^ 0x30C9CF4C);
					continue;
				default:
					return;
				case 28u:
					break;
				case 15u:
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
