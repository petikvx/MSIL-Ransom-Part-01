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
			int num = -777179394;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBE835D73u) % 4u)
				{
				case 2u:
					InitializeComponent();
					num = ((int)num2 * -425527846) ^ 0x71FEA01B;
					continue;
				case 1u:
					num = ((int)num2 * -1588285498) ^ -1455327769;
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

	private void Button2_Click(object sender, EventArgs e)
	{
		Form3.smethod_0((Control)(object)NullButton);
		Form val = default(Form);
		while (true)
		{
			int num = 1679758;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3D42E6C7u) % 5u)
				{
				case 2u:
					Form3.smethod_4((Control)(object)val);
					num = (int)(num2 * 849347204) ^ -1904006478;
					continue;
				case 1u:
					Form3.smethod_1(errorProvider1);
					num = ((int)num2 * -1983475403) ^ -94577499;
					continue;
				case 0u:
				{
					Form4 form = new Form4();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					num = ((int)num2 * -80653958) ^ -841738760;
					continue;
				}
				case 4u:
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
		Form val = default(Form);
		while (true)
		{
			int num = 1535275128;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5F1BF67Bu) % 7u)
				{
				case 6u:
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = (int)((num2 * 2058373792) ^ 0x73880BC7);
					continue;
				case 5u:
					Form3.smethod_10(val, new Point(Form3.smethod_13(Form3.smethod_12((Form)(object)this)).X + (Form3.smethod_7((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_13(Form3.smethod_12((Form)(object)this)).Y + (Form3.smethod_9((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_9((Control)(object)val)) / 2));
					num = (int)(num2 * 8763435) ^ -1986828306;
					continue;
				case 2u:
				{
					Form3.smethod_0((Control)(object)NullButton);
					Form2 form = new Form2();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					num = ((int)num2 * -363892666) ^ -974461831;
					continue;
				}
				case 1u:
					Form3.smethod_4((Control)(object)val);
					num = (int)((num2 * 1665682968) ^ 0x5D03D553);
					continue;
				case 0u:
					num = ((int)num2 * -367874578) ^ 0x329E7DF4;
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

	public void Button_Continue()
	{
		Form3.smethod_14((Control)(object)button5, bool_0: true);
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		bool flag = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = -288578683;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xED3179B9u) % 10u)
				{
				case 8u:
					Form3.smethod_16(Form3.smethod_12((Form)(object)this));
					num = (int)(num2 * 1034596851) ^ -1126282003;
					continue;
				case 6u:
					num = (int)((num2 * 265858729) ^ 0x76D6D36E);
					continue;
				case 5u:
					num = -378124739;
					continue;
				case 4u:
					num = (int)(num2 * 1539197098) ^ -1324511771;
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 625453527;
						num5 = 625453527;
					}
					else
					{
						num4 = 1496732124;
						num5 = 1496732124;
					}
					num = num4 ^ (int)(num2 * 1474753381);
					continue;
				}
				case 2u:
					Form3.smethod_17((Form3.smethod_12((Form)(object)this) as Form1).timer1);
					num = ((int)num2 * -1564314250) ^ 0xA87532D;
					continue;
				case 1u:
					flag = num3 > 1;
					num = ((int)num2 * -1640762834) ^ 0x7B42DD10;
					continue;
				case 0u:
					num3 = Form3.smethod_8((Control)(object)this) - 1;
					Form3.smethod_15((Control)(object)this, num3);
					num = -1857847246;
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
			int num = -1008740746;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF3215EE3u) % 4u)
				{
				case 1u:
					Form3.smethod_0((Control)(object)NullButton);
					num = ((int)num2 * -1643724784) ^ -255370037;
					continue;
				case 0u:
					Form3.smethod_14((Control)(object)button7, bool_0: false);
					num = (int)(num2 * 1715488123) ^ -1246481768;
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

	protected override void Dispose(bool disposing)
	{
		if (!disposing)
		{
			goto IL_0006;
		}
		goto IL_0013;
		IL_0013:
		int num = 44799404;
		goto IL_0040;
		IL_0040:
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x8812232u) % 5u)
			{
			case 4u:
				break;
			case 1u:
				((Form)this).Dispose(disposing);
				num = 1904849629;
				continue;
			case 0u:
				Form3.smethod_18((IDisposable)components);
				num = (int)(num2 * 235828516) ^ -1546336289;
				continue;
			default:
				return;
			case 3u:
				goto IL_0065;
			case 2u:
				return;
			}
			break;
			IL_0065:
			if (components != null)
			{
				num = 634133003;
				num3 = 634133003;
				continue;
			}
			goto IL_0006;
		}
		goto IL_0013;
		IL_0006:
		num = 2038379227;
		num3 = 2038379227;
		goto IL_0040;
	}

	private void InitializeComponent()
	{
		components = Form3.smethod_19();
		while (true)
		{
			int num = 945016463;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5C25D606u) % 128u)
				{
				case 127u:
					Form3.smethod_51((Control)(object)this, "Form3");
					num = ((int)num2 * -1498277171) ^ 0x24764EF3;
					continue;
				case 126u:
					Form3.smethod_30((Control)(object)NullButton, new Point(-1, -1));
					num = ((int)num2 * -989945708) ^ 0x411A6988;
					continue;
				case 125u:
					num = (int)((num2 * 1994672756) ^ 0x7405AA6B);
					continue;
				case 124u:
					num = ((int)num2 * -1957747463) ^ -1367014722;
					continue;
				case 123u:
					num = (int)(num2 * 1277024545) ^ -1483803301;
					continue;
				case 122u:
					Form3.smethod_35((Control)(object)button4, "Начало игры");
					Form3.smethod_34((ButtonBase)(object)button4, bool_0: true);
					num = (int)(num2 * 1445225906) ^ -246457444;
					continue;
				case 121u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button4), 0);
					num = ((int)num2 * -134698424) ^ 0x608367B2;
					continue;
				case 120u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox2);
					num = ((int)num2 * -1654528789) ^ -268711836;
					continue;
				case 119u:
					label1 = Form3.smethod_22();
					textBox2 = Form3.smethod_21();
					errorProvider1 = Form3.smethod_23(components);
					num = (int)(num2 * 1759145848) ^ -502336247;
					continue;
				case 118u:
					Form3.smethod_33((Control)(object)label1, 7);
					num = (int)((num2 * 209886421) ^ 0x461A249A);
					continue;
				case 117u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)NullButton);
					num = (int)((num2 * 953580571) ^ 0x21349F0A);
					continue;
				case 116u:
					num = (int)((num2 * 1287339376) ^ 0x46EE7652);
					continue;
				case 115u:
					num = (int)((num2 * 6352143) ^ 0x73BACD79);
					continue;
				case 114u:
					button1 = Form3.smethod_20();
					num = ((int)num2 * -1621563382) ^ -467027990;
					continue;
				case 113u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button7);
					num = (int)((num2 * 1134913477) ^ 0x510279D9);
					continue;
				case 112u:
					Form3.smethod_53((Form)(object)this, bool_0: false);
					Form3.smethod_54((Form)(object)this, bool_0: true);
					num = (int)((num2 * 837866283) ^ 0x413AF476);
					continue;
				case 111u:
					num = (int)(num2 * 357051275) ^ -1262600196;
					continue;
				case 110u:
					num = (int)(num2 * 1526459615) ^ -1155482964;
					continue;
				case 109u:
					Form3.smethod_45((Form)(object)this, new Size(486, 296));
					num = ((int)num2 * -1377947913) ^ -499381181;
					continue;
				case 108u:
					num = ((int)num2 * -1191837089) ^ 0x2E7F9C3F;
					continue;
				case 107u:
					num = (int)(num2 * 1599918641) ^ -600697860;
					continue;
				case 106u:
					Form3.smethod_33((Control)(object)button7, 6);
					num = ((int)num2 * -92887853) ^ -102349208;
					continue;
				case 105u:
					textBox1 = Form3.smethod_21();
					num = ((int)num2 * -1946729168) ^ -1891336127;
					continue;
				case 104u:
					Form3.smethod_30((Control)(object)button7, new Point(174, 243));
					num = (int)((num2 * 690837614) ^ 0x75F62B1A);
					continue;
				case 103u:
					Form3.smethod_32((Control)(object)button5, new Size(140, 50));
					num = ((int)num2 * -1230472718) ^ 0x6E8AEE2C;
					continue;
				case 102u:
					Form3.smethod_49((Form)(object)this, bool_0: false);
					num = (int)((num2 * 1501912797) ^ 0xEDD3A8D);
					continue;
				case 101u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button4);
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button2);
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -1361217591) ^ 0x693FEF97;
					continue;
				case 100u:
					Form3.smethod_14((Control)(object)button4, bool_0: false);
					num = (int)((num2 * 661152513) ^ 0x62D5381B);
					continue;
				case 99u:
					num = (int)((num2 * 711461750) ^ 0x607C5A5A);
					continue;
				case 98u:
					Form3.smethod_26((Control)(object)NullButton, Color.Transparent);
					num = ((int)num2 * -185842775) ^ 0xFE76BE3;
					continue;
				case 97u:
					Form3.smethod_26((Control)(object)label1, Color.Transparent);
					num = (int)(num2 * 2113478741) ^ -753261224;
					continue;
				case 96u:
					Form3.smethod_43((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -926180283) ^ -2019699237;
					continue;
				case 95u:
					num = ((int)num2 * -233894424) ^ 0x3FFA9188;
					continue;
				case 94u:
					Form3.smethod_36((Control)(object)button7, (EventHandler)Button7_Click);
					num = ((int)num2 * -220916211) ^ -100604156;
					continue;
				case 93u:
					Form3.smethod_31((Control)(object)NullButton, "NullButton");
					num = (int)(num2 * 736668936) ^ -1059504511;
					continue;
				case 92u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -2108636160) ^ 0x1E59B673;
					continue;
				case 91u:
					Form3.smethod_48((Form)(object)this, (FormBorderStyle)0);
					num = (int)((num2 * 2062558268) ^ 0x74D7BDB4);
					continue;
				case 90u:
					Form3.smethod_35((Control)(object)button5, "Продолжить");
					num = ((int)num2 * -1980662649) ^ 0x3F1590B;
					continue;
				case 89u:
					Form3.smethod_34((ButtonBase)(object)NullButton, bool_0: false);
					num = (int)((num2 * 1558711941) ^ 0x4ED58F8D);
					continue;
				case 88u:
					Form3.smethod_32((Control)(object)button2, new Size(85, 21));
					num = ((int)num2 * -1390506209) ^ 0x3547A8A0;
					continue;
				case 87u:
					num = (int)(num2 * 369642892) ^ -2086636863;
					continue;
				case 86u:
					num = (int)(num2 * 1982344163) ^ -508038759;
					continue;
				case 85u:
					Form3.smethod_25((Control)(object)this);
					num = (int)((num2 * 1264153848) ^ 0x562C1F3C);
					continue;
				case 84u:
					Form3.smethod_56((Control)(object)this, bool_0: false);
					num = ((int)num2 * -253830705) ^ -742943671;
					continue;
				case 83u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)NullButton), 0);
					num = (int)((num2 * 1002653800) ^ 0x11D8D5B2);
					continue;
				case 82u:
					Form3.smethod_36((Control)(object)button2, (EventHandler)Button2_Click);
					num = ((int)num2 * -1136458277) ^ -195706940;
					continue;
				case 81u:
					num = (int)((num2 * 1171655298) ^ 0x6C86F7A7);
					continue;
				case 80u:
					num = (int)((num2 * 946710682) ^ 0x6C83E7E7);
					continue;
				case 79u:
					num = (int)((num2 * 1935432629) ^ 0x44AB30B5);
					continue;
				case 78u:
					Form3.smethod_36((Control)(object)button4, (EventHandler)Button4_Click);
					Form3.smethod_14((Control)(object)button5, bool_0: false);
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button5), 0);
					num = ((int)num2 * -1418950397) ^ 0x5F33CBB3;
					continue;
				case 77u:
					num = (int)((num2 * 2067739677) ^ 0x1425A7E6);
					continue;
				case 76u:
					button4 = Form3.smethod_20();
					num = ((int)num2 * -778373318) ^ -974945245;
					continue;
				case 74u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox1);
					num = (int)((num2 * 2033133065) ^ 0x78EB75ED);
					continue;
				case 73u:
					Form3.smethod_36((Control)(object)button5, (EventHandler)Button5_Click);
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button7), 0);
					Form3.smethod_29((ButtonBase)(object)button7, (FlatStyle)0);
					Form3.smethod_38((Control)(object)button7, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -894144417) ^ -1205340706;
					continue;
				case 72u:
					Form3.smethod_34((ButtonBase)(object)button1, bool_0: true);
					num = (int)((num2 * 859971836) ^ 0xBF5AA15);
					continue;
				case 71u:
					Form3.smethod_24((ISupportInitialize)errorProvider1);
					num = (int)((num2 * 2033078548) ^ 0xE8BB15F);
					continue;
				case 70u:
					Form3.smethod_52((Form)(object)this, bool_0: false);
					num = (int)((num2 * 77481402) ^ 0x64C0AC48);
					continue;
				case 69u:
					num = ((int)num2 * -1929004090) ^ 0x4A600843;
					continue;
				case 68u:
					Form3.smethod_30((Control)(object)textBox1, new Point(174, 2));
					num = ((int)num2 * -1221516556) ^ -436778113;
					continue;
				case 67u:
					num = ((int)num2 * -468214081) ^ -595295727;
					continue;
				case 66u:
					Form3.smethod_36((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -1430907967) ^ -1387271496;
					continue;
				case 65u:
					Form3.smethod_32((Control)(object)textBox1, new Size(140, 20));
					Form3.smethod_33((Control)(object)textBox1, 7);
					num = ((int)num2 * -1519584679) ^ 0x55AF3290;
					continue;
				case 64u:
					num = (int)(num2 * 636804292) ^ -665187374;
					continue;
				case 63u:
					Form3.smethod_32((Control)(object)NullButton, new Size(1, 1));
					num = ((int)num2 * -1646784199) ^ 0x31B0843A;
					continue;
				case 62u:
					num = (int)((num2 * 1486257066) ^ 0x73E5135C);
					continue;
				case 61u:
					Form3.smethod_44((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 1240536748) ^ -1332828609;
					continue;
				case 60u:
					Form3.smethod_29((ButtonBase)(object)button4, (FlatStyle)0);
					num = (int)((num2 * 1741352704) ^ 0x38F0ABA7);
					continue;
				case 59u:
					Form3.smethod_33((Control)(object)NullButton, 3);
					num = (int)(num2 * 1934402317) ^ -1490917708;
					continue;
				case 58u:
					Form3.smethod_30((Control)(object)button5, new Point(174, 190));
					num = (int)(num2 * 236726399) ^ -1612214201;
					continue;
				case 57u:
					Form3.smethod_32((Control)(object)button4, new Size(140, 50));
					Form3.smethod_33((Control)(object)button4, 4);
					num = ((int)num2 * -728292826) ^ -1542289398;
					continue;
				case 56u:
					Form3.smethod_31((Control)(object)label1, "label1");
					num = ((int)num2 * -248709555) ^ -1537331007;
					continue;
				case 55u:
					num = ((int)num2 * -591039118) ^ 0x767B64E4;
					continue;
				case 54u:
					Form3.smethod_30((Control)(object)button1, new Point(265, 49));
					Form3.smethod_31((Control)(object)button1, "button1");
					Form3.smethod_32((Control)(object)button1, new Size(49, 21));
					num = ((int)num2 * -1324863441) ^ -914584741;
					continue;
				case 53u:
					num = ((int)num2 * -130848687) ^ 0x33C57B11;
					continue;
				case 52u:
					Form3.smethod_41(textBox2, bool_0: true);
					num = (int)(num2 * 502987769) ^ -912880848;
					continue;
				case 51u:
					button7 = Form3.smethod_20();
					num = ((int)num2 * -232518501) ^ -660883570;
					continue;
				case 50u:
					num = (int)((num2 * 315474765) ^ 0x3BC898A2);
					continue;
				case 49u:
					Form3.smethod_35((Control)(object)button1, "Вход");
					num = ((int)num2 * -1861393087) ^ 0x34C4033F;
					continue;
				case 48u:
					Form3.smethod_35((Control)(object)button7, "Достижения");
					num = (int)(num2 * 2060640191) ^ -643090365;
					continue;
				case 47u:
					Form3.smethod_57((Control)(object)this);
					num = ((int)num2 * -1446334483) ^ 0x78EABCE;
					continue;
				case 46u:
					Form3.smethod_35((Control)(object)label1, "QUARTO");
					Form3.smethod_30((Control)(object)textBox2, new Point(174, 26));
					num = (int)(num2 * 1852192049) ^ -990185406;
					continue;
				case 45u:
					Form3.smethod_34((ButtonBase)(object)button2, bool_0: true);
					num = (int)((num2 * 677347541) ^ 0x74E6AA42);
					continue;
				case 44u:
					Form3.smethod_31((Control)(object)button7, "button7");
					num = ((int)num2 * -31129956) ^ -1793646651;
					continue;
				case 42u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button5);
					num = (int)((num2 * 99300629) ^ 0x61942F11);
					continue;
				case 41u:
					num = (int)(num2 * 1188481725) ^ -1735930907;
					continue;
				case 40u:
					Form3.smethod_38((Control)(object)button4, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 1308219543) ^ 0x1526D915);
					continue;
				case 39u:
					Form3.smethod_33((Control)(object)textBox2, 8);
					num = ((int)num2 * -575530059) ^ 0x2D0BDA8B;
					continue;
				case 38u:
					Form3.smethod_31((Control)(object)textBox1, "textBox1");
					num = (int)(num2 * 667307644) ^ -1744969666;
					continue;
				case 37u:
					Form3.smethod_34((ButtonBase)(object)button7, bool_0: true);
					num = (int)((num2 * 1423625242) ^ 0x7363121A);
					continue;
				case 36u:
					Form3.smethod_30((Control)(object)button2, new Point(174, 49));
					num = ((int)num2 * -826570508) ^ 0x31DB3507;
					continue;
				case 35u:
					num = ((int)num2 * -538587142) ^ 0x3C2C1987;
					continue;
				case 34u:
					Form3.smethod_39((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = (int)(num2 * 385687542) ^ -2051806814;
					continue;
				case 33u:
					num = ((int)num2 * -843120085) ^ -2003980891;
					continue;
				case 32u:
					Form3.smethod_55((ISupportInitialize)errorProvider1);
					num = (int)((num2 * 237666829) ^ 0x5C86B3E6);
					continue;
				case 31u:
					Form3.smethod_32((Control)(object)label1, new Size(207, 76));
					num = (int)((num2 * 1112882487) ^ 0x7337E911);
					continue;
				case 30u:
					num = (int)((num2 * 588121987) ^ 0x62DA4468);
					continue;
				case 29u:
					button5 = Form3.smethod_20();
					num = ((int)num2 * -1445974022) ^ 0x453DD0E7;
					continue;
				case 28u:
					Form3.smethod_33((Control)(object)button1, 0);
					num = (int)(num2 * 242996532) ^ -1794038777;
					continue;
				case 27u:
					Form3.smethod_26((Control)(object)this, Color.White);
					num = (int)((num2 * 184130236) ^ 0x5734D23F);
					continue;
				case 26u:
					Form3.smethod_38((Control)(object)button5, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1620942842) ^ -1287868768;
					continue;
				case 25u:
					Form3.smethod_32((Control)(object)textBox2, new Size(140, 20));
					num = ((int)num2 * -712461024) ^ 0x46509381;
					continue;
				case 24u:
					button2 = Form3.smethod_20();
					num = ((int)num2 * -960528610) ^ -382957670;
					continue;
				case 23u:
					Form3.smethod_33((Control)(object)button2, 1);
					num = (int)(num2 * 566931069) ^ -824004929;
					continue;
				case 22u:
					Form3.smethod_29((ButtonBase)(object)button5, (FlatStyle)0);
					num = (int)((num2 * 481949064) ^ 0x336E5EAC);
					continue;
				case 21u:
					num = ((int)num2 * -261260614) ^ -281553055;
					continue;
				case 20u:
					Form3.smethod_33((Control)(object)button5, 5);
					num = (int)((num2 * 1967547812) ^ 0x3E0A068C);
					continue;
				case 19u:
					Form3.smethod_32((Control)(object)button7, new Size(140, 50));
					num = ((int)num2 * -1955204046) ^ -461142669;
					continue;
				case 18u:
					num = ((int)num2 * -388339555) ^ 0x2F0C707C;
					continue;
				case 17u:
					num = (int)((num2 * 309287817) ^ 0x376AB986);
					continue;
				case 16u:
					Form3.smethod_30((Control)(object)label1, new Point(140, 70));
					num = ((int)num2 * -1687692059) ^ -1451358117;
					continue;
				case 15u:
					Form3.smethod_39((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					Form3.smethod_40((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -3557655) ^ 0x2BFF60C0;
					continue;
				case 14u:
					num = ((int)num2 * -501354077) ^ 0x1E6770FB;
					continue;
				case 13u:
					num = ((int)num2 * -1051794564) ^ 0x4A08B672;
					continue;
				case 12u:
					Form3.smethod_29((ButtonBase)(object)NullButton, (FlatStyle)0);
					num = ((int)num2 * -2031933803) ^ 0x702FE199;
					continue;
				case 11u:
					Form3.smethod_30((Control)(object)button4, new Point(174, 137));
					Form3.smethod_31((Control)(object)button4, "button4");
					num = ((int)num2 * -1690489930) ^ 0x7EF05FED;
					continue;
				case 10u:
					Form3.smethod_31((Control)(object)textBox2, "textBox2");
					num = ((int)num2 * -102391962) ^ 0x7AED096B;
					continue;
				case 9u:
					NullButton = Form3.smethod_20();
					num = ((int)num2 * -606224644) ^ -1520631384;
					continue;
				case 8u:
					num = ((int)num2 * -1463899085) ^ 0x4DD3A11E;
					continue;
				case 7u:
					num = (int)((num2 * 1342297643) ^ 0x4357EFAF);
					continue;
				case 6u:
					Form3.smethod_34((ButtonBase)(object)button5, bool_0: true);
					num = (int)(num2 * 1233313680) ^ -1069968357;
					continue;
				case 5u:
					Form3.smethod_50((Form)(object)this, bool_0: false);
					num = (int)(num2 * 285770142) ^ -1594213521;
					continue;
				case 4u:
					Form3.smethod_31((Control)(object)button5, "button5");
					num = (int)(num2 * 1028027980) ^ -1109857071;
					continue;
				case 3u:
					Form3.smethod_31((Control)(object)button2, "button2");
					num = (int)((num2 * 1773262345) ^ 0x30653C5);
					continue;
				case 2u:
					Form3.smethod_35((Control)(object)button2, "Регистрация");
					num = (int)(num2 * 1451097737) ^ -607530120;
					continue;
				case 1u:
					Form3.smethod_38((Control)(object)label1, Form3.smethod_37("Mistral", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 1840321914) ^ 0x43FA08EC);
					continue;
				case 0u:
					Form3.smethod_42(errorProvider1, (ContainerControl)(object)this);
					num = ((int)num2 * -1543295552) ^ 0x24DB9BE6;
					continue;
				default:
					return;
				case 43u:
					break;
				case 75u:
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
