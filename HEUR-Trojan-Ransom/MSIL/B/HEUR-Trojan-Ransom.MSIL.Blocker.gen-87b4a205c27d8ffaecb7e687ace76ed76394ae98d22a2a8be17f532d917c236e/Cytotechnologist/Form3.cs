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
			int num = 1842377606;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x14F82C2Du) % 6u)
				{
				case 4u:
				{
					Form4 form = new Form4();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					Form3.smethod_4((Control)(object)val);
					num = ((int)num2 * -2111393295) ^ 0x5F57F055;
					continue;
				}
				case 3u:
					num = (int)((num2 * 819683790) ^ 0x433C9D01);
					continue;
				case 2u:
					Form3.smethod_10(val, new Point(Form3.smethod_5((Form)(object)this).X + (Form3.smethod_6((Control)(object)this) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_5((Form)(object)this).Y + (Form3.smethod_8((Control)(object)this) - Form3.smethod_9((Control)(object)val)) / 2 + 70));
					num = (int)((num2 * 1832669027) ^ 0x79320AE5);
					continue;
				case 1u:
					Form3.smethod_0((Control)(object)NullButton);
					Form3.smethod_1(errorProvider1);
					num = ((int)num2 * -1697860499) ^ 0x2768CA09;
					continue;
				case 5u:
					break;
				default:
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
		Form val = default(Form);
		while (true)
		{
			int num = 1593653659;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7C0D1C14u) % 6u)
				{
				case 5u:
					Form3.smethod_4((Control)(object)val);
					Form3.smethod_10(val, new Point(Form3.smethod_13(Form3.smethod_12((Form)(object)this)).X + (Form3.smethod_7((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_13(Form3.smethod_12((Form)(object)this)).Y + (Form3.smethod_9((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_9((Control)(object)val)) / 2));
					num = ((int)num2 * -326332258) ^ 0x2726B2AC;
					continue;
				case 3u:
					num = (int)(num2 * 562437911) ^ -933326465;
					continue;
				case 2u:
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = ((int)num2 * -1270556088) ^ -1218947391;
					continue;
				case 1u:
				{
					Form2 form = new Form2();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					num = (int)((num2 * 149759086) ^ 0x527DD79F);
					continue;
				}
				default:
					return;
				case 4u:
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
		bool flag = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = -434255127;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD77DA9C2u) % 9u)
				{
				case 8u:
					num = ((int)num2 * -42427319) ^ 0x62141CB0;
					continue;
				case 7u:
					Form3.smethod_16(Form3.smethod_12((Form)(object)this));
					num = (int)((num2 * 554084021) ^ 0x82A63E6);
					continue;
				case 6u:
					Form3.smethod_17((Form3.smethod_12((Form)(object)this) as Form1).timer1);
					num = ((int)num2 * -2075596403) ^ 0x6E3FF7FF;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1706227402;
						num5 = 1706227402;
					}
					else
					{
						num4 = 1938106072;
						num5 = 1938106072;
					}
					num = num4 ^ ((int)num2 * -1581758949);
					continue;
				}
				case 4u:
					flag = num3 > 1;
					num = ((int)num2 * -1919751746) ^ -1307773222;
					continue;
				case 2u:
					num = -1375311885;
					continue;
				case 1u:
					num3 = Form3.smethod_8((Control)(object)this) - 1;
					Form3.smethod_15((Control)(object)this, num3);
					num = -1609712808;
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
			int num = -2022405473;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC3B7F448u) % 3u)
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
				num = ((int)num2 * -74190089) ^ 0x5D1631DD;
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
			int num = 204793814;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x82D2FC8u) % 4u)
				{
				case 2u:
					Form3.smethod_0((Control)(object)NullButton);
					num = (int)((num2 * 1962999847) ^ 0x5A49D7CB);
					continue;
				case 1u:
					Form3.smethod_14((Control)(object)button7, bool_0: false);
					num = (int)((num2 * 1197157483) ^ 0x3C4F0D94);
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
			int num = 976389545;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x6DCA76DDu) % 9u)
				{
				case 7u:
					if (components != null)
					{
						num = 24963731;
						num3 = 24963731;
						continue;
					}
					goto IL_0011;
				case 6u:
					((Form)this).Dispose(disposing);
					num = 1577127956;
					continue;
				case 5u:
					num = (int)((num2 * 481280487) ^ 0x1709F45B);
					continue;
				case 4u:
					if (disposing)
					{
						num = ((int)num2 * -225995366) ^ -1502516486;
						continue;
					}
					goto IL_0011;
				case 2u:
					num = (int)(num2 * 855926044) ^ -1486904787;
					continue;
				case 1u:
					Form3.smethod_18((IDisposable)components);
					num = (int)((num2 * 737844195) ^ 0x1CCB3CA);
					continue;
				case 0u:
					num = ((int)num2 * -1826468666) ^ -1391238378;
					continue;
				default:
					return;
				case 8u:
					break;
				case 3u:
					return;
					IL_0011:
					num = 1620694196;
					num3 = 1620694196;
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
			int num = 1605344030;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6B12F932u) % 134u)
				{
				case 133u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)NullButton);
					num = ((int)num2 * -2122523368) ^ -715497228;
					continue;
				case 132u:
					Form3.smethod_29((ButtonBase)(object)button5, (FlatStyle)0);
					num = ((int)num2 * -1764339627) ^ -1014676069;
					continue;
				case 131u:
					Form3.smethod_35((Control)(object)button5, "Продолжить");
					num = ((int)num2 * -2113148068) ^ -1907935407;
					continue;
				case 130u:
					num = (int)(num2 * 1396276896) ^ -665062927;
					continue;
				case 129u:
					Form3.smethod_33((Control)(object)textBox2, 8);
					num = (int)((num2 * 498795102) ^ 0x60CEA9A4);
					continue;
				case 128u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button4), 0);
					num = ((int)num2 * -1247041567) ^ -671370039;
					continue;
				case 127u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -646958589) ^ 0x6DEFC880;
					continue;
				case 126u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button2);
					num = ((int)num2 * -791928851) ^ -1752393904;
					continue;
				case 125u:
					num = ((int)num2 * -1295646980) ^ -1633123861;
					continue;
				case 124u:
					Form3.smethod_26((Control)(object)label1, Color.Transparent);
					num = (int)(num2 * 1081739596) ^ -1751003703;
					continue;
				case 123u:
					Form3.smethod_30((Control)(object)button1, new Point(265, 49));
					num = ((int)num2 * -1340864462) ^ -686193240;
					continue;
				case 122u:
					num = (int)((num2 * 836879282) ^ 0x15C1ADFD);
					continue;
				case 121u:
					num = (int)((num2 * 239945732) ^ 0x6281BD);
					continue;
				case 120u:
					num = ((int)num2 * -389528856) ^ 0x59906EEB;
					continue;
				case 119u:
					num = ((int)num2 * -1887587855) ^ -2032544725;
					continue;
				case 118u:
					num = (int)((num2 * 79431407) ^ 0x70CD9078);
					continue;
				case 117u:
					num = (int)((num2 * 1139464382) ^ 0x5218E848);
					continue;
				case 116u:
					Form3.smethod_33((Control)(object)NullButton, 3);
					Form3.smethod_34((ButtonBase)(object)NullButton, bool_0: false);
					num = ((int)num2 * -1247878271) ^ 0x2F4E3E1F;
					continue;
				case 115u:
					textBox2 = Form3.smethod_21();
					num = (int)((num2 * 1010471025) ^ 0x2AC9239E);
					continue;
				case 114u:
					num = (int)(num2 * 1009860687) ^ -1080924912;
					continue;
				case 113u:
					Form3.smethod_29((ButtonBase)(object)button7, (FlatStyle)0);
					num = ((int)num2 * -64512309) ^ 0x172E64FB;
					continue;
				case 112u:
					Form3.smethod_42(errorProvider1, (ContainerControl)(object)this);
					num = ((int)num2 * -1828984917) ^ 0x35DAC2D0;
					continue;
				case 111u:
					Form3.smethod_45((Form)(object)this, new Size(486, 296));
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox2);
					num = ((int)num2 * -1957927731) ^ -1137141441;
					continue;
				case 110u:
					Form3.smethod_31((Control)(object)button5, "button5");
					num = (int)(num2 * 1478941478) ^ -379608316;
					continue;
				case 109u:
					num = ((int)num2 * -287136182) ^ -1710631391;
					continue;
				case 108u:
					Form3.smethod_33((Control)(object)button4, 4);
					num = ((int)num2 * -151700523) ^ 0x41CC2365;
					continue;
				case 107u:
					Form3.smethod_32((Control)(object)textBox1, new Size(140, 20));
					num = (int)((num2 * 1577650652) ^ 0x62A440CE);
					continue;
				case 106u:
					Form3.smethod_36((Control)(object)button7, (EventHandler)Button7_Click);
					num = ((int)num2 * -1722120187) ^ -1231148036;
					continue;
				case 105u:
					Form3.smethod_39((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = (int)(num2 * 855094596) ^ -1565076214;
					continue;
				case 104u:
					Form3.smethod_31((Control)(object)button7, "button7");
					num = (int)((num2 * 1146566269) ^ 0x4F1C7E8A);
					continue;
				case 103u:
					Form3.smethod_54((Form)(object)this, bool_0: true);
					num = ((int)num2 * -301586034) ^ -1284226475;
					continue;
				case 102u:
					Form3.smethod_29((ButtonBase)(object)NullButton, (FlatStyle)0);
					num = ((int)num2 * -383625983) ^ -1319146250;
					continue;
				case 101u:
					Form3.smethod_44((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -436562554) ^ -832181449;
					continue;
				case 100u:
					Form3.smethod_25((Control)(object)this);
					num = (int)((num2 * 1188201488) ^ 0x548F9F13);
					continue;
				case 99u:
					Form3.smethod_40((Control)(object)label1, bool_0: true);
					num = (int)((num2 * 101596216) ^ 0x1B698EC0);
					continue;
				case 98u:
					num = ((int)num2 * -999077310) ^ -598605562;
					continue;
				case 97u:
					Form3.smethod_32((Control)(object)button2, new Size(85, 21));
					num = (int)(num2 * 817357722) ^ -1786482910;
					continue;
				case 96u:
					Form3.smethod_32((Control)(object)textBox2, new Size(140, 20));
					num = ((int)num2 * -1303050564) ^ 0x2C60F125;
					continue;
				case 95u:
					Form3.smethod_33((Control)(object)button2, 1);
					num = (int)((num2 * 1462140365) ^ 0x4BBDC8DF);
					continue;
				case 93u:
					Form3.smethod_36((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)((num2 * 940961877) ^ 0x5203CDBE);
					continue;
				case 92u:
					Form3.smethod_38((Control)(object)button7, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 796121351) ^ -1323141732;
					continue;
				case 91u:
					num = (int)(num2 * 1412197995) ^ -1926940195;
					continue;
				case 90u:
					Form3.smethod_31((Control)(object)button2, "button2");
					num = (int)((num2 * 294705795) ^ 0x52A9C34);
					continue;
				case 89u:
					Form3.smethod_30((Control)(object)button2, new Point(174, 49));
					num = ((int)num2 * -523703569) ^ 0x23DD72AB;
					continue;
				case 88u:
					Form3.smethod_30((Control)(object)button5, new Point(174, 190));
					num = ((int)num2 * -835097975) ^ 0x6F6B3FE2;
					continue;
				case 87u:
					Form3.smethod_24((ISupportInitialize)errorProvider1);
					num = (int)(num2 * 1399118034) ^ -886407182;
					continue;
				case 86u:
					num = ((int)num2 * -890093833) ^ 0x38DE151F;
					continue;
				case 85u:
					button2 = Form3.smethod_20();
					button4 = Form3.smethod_20();
					button5 = Form3.smethod_20();
					num = (int)(num2 * 1210585552) ^ -378606228;
					continue;
				case 84u:
					Form3.smethod_35((Control)(object)label1, "QUARTO");
					num = ((int)num2 * -464188692) ^ 0x191058FF;
					continue;
				case 83u:
					num = ((int)num2 * -1215890016) ^ -157758146;
					continue;
				case 82u:
					Form3.smethod_55((ISupportInitialize)errorProvider1);
					Form3.smethod_56((Control)(object)this, bool_0: false);
					num = ((int)num2 * -794303229) ^ 0x17D3F3D9;
					continue;
				case 81u:
					Form3.smethod_36((Control)(object)button2, (EventHandler)Button2_Click);
					num = (int)((num2 * 814057018) ^ 0x154F2735);
					continue;
				case 80u:
					Form3.smethod_31((Control)(object)NullButton, "NullButton");
					num = (int)((num2 * 2051691162) ^ 0x7CBBCCBD);
					continue;
				case 79u:
					num = ((int)num2 * -1301635695) ^ -859640983;
					continue;
				case 78u:
					Form3.smethod_35((Control)(object)button2, "Регистрация");
					num = (int)((num2 * 2105977518) ^ 0x18D6D91F);
					continue;
				case 77u:
					Form3.smethod_38((Control)(object)label1, Form3.smethod_37("Mistral", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form3.smethod_30((Control)(object)label1, new Point(140, 70));
					num = (int)(num2 * 822124661) ^ -1677304244;
					continue;
				case 76u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button7);
					num = ((int)num2 * -1664120957) ^ 0x1F057D57;
					continue;
				case 75u:
					Form3.smethod_30((Control)(object)button4, new Point(174, 137));
					Form3.smethod_31((Control)(object)button4, "button4");
					num = ((int)num2 * -1417276865) ^ -1404771934;
					continue;
				case 74u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox1);
					num = (int)((num2 * 39191857) ^ 0x654BD612);
					continue;
				case 73u:
					Form3.smethod_30((Control)(object)textBox1, new Point(174, 2));
					Form3.smethod_31((Control)(object)textBox1, "textBox1");
					num = ((int)num2 * -713922168) ^ -1099518080;
					continue;
				case 72u:
					Form3.smethod_14((Control)(object)button5, bool_0: false);
					num = ((int)num2 * -513100549) ^ 0x139142FA;
					continue;
				case 71u:
					Form3.smethod_26((Control)(object)NullButton, Color.Transparent);
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)NullButton), 0);
					num = (int)((num2 * 84567473) ^ 0x549F5CB2);
					continue;
				case 70u:
					num = ((int)num2 * -381556933) ^ 0x7E225450;
					continue;
				case 69u:
					num = (int)(num2 * 568905284) ^ -952256107;
					continue;
				case 68u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button5), 0);
					num = (int)((num2 * 392412497) ^ 0x44719610);
					continue;
				case 67u:
					Form3.smethod_32((Control)(object)button4, new Size(140, 50));
					num = (int)((num2 * 294562903) ^ 0x75A23F76);
					continue;
				case 66u:
					num = (int)((num2 * 1495993006) ^ 0x4D30C802);
					continue;
				case 65u:
					Form3.smethod_43((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -263793190) ^ -851125641;
					continue;
				case 64u:
					num = (int)(num2 * 1667114298) ^ -969025308;
					continue;
				case 63u:
					num = ((int)num2 * -2145820045) ^ -1849282850;
					continue;
				case 62u:
					textBox1 = Form3.smethod_21();
					num = ((int)num2 * -749771738) ^ -759575616;
					continue;
				case 61u:
					Form3.smethod_35((Control)(object)button4, "Начало игры");
					Form3.smethod_34((ButtonBase)(object)button4, bool_0: true);
					Form3.smethod_36((Control)(object)button4, (EventHandler)Button4_Click);
					num = (int)((num2 * 1589550311) ^ 0x573E46CB);
					continue;
				case 60u:
					num = (int)(num2 * 1909035596) ^ -36028076;
					continue;
				case 59u:
					Form3.smethod_38((Control)(object)button5, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 1197435085) ^ 0x64990871);
					continue;
				case 58u:
					label1 = Form3.smethod_22();
					num = ((int)num2 * -2064725749) ^ 0x735E12E1;
					continue;
				case 57u:
					Form3.smethod_31((Control)(object)label1, "label1");
					num = (int)(num2 * 223361596) ^ -1336162982;
					continue;
				case 56u:
					num = (int)((num2 * 393049735) ^ 0x5BC568B4);
					continue;
				case 55u:
					Form3.smethod_29((ButtonBase)(object)button4, (FlatStyle)0);
					num = ((int)num2 * -1385306125) ^ 0x57F4CCE8;
					continue;
				case 54u:
					Form3.smethod_33((Control)(object)button7, 6);
					num = ((int)num2 * -992637718) ^ 0x760EC043;
					continue;
				case 53u:
					Form3.smethod_34((ButtonBase)(object)button2, bool_0: true);
					num = (int)(num2 * 829272392) ^ -1730414622;
					continue;
				case 52u:
					Form3.smethod_30((Control)(object)NullButton, new Point(-1, -1));
					num = ((int)num2 * -1838645496) ^ -1813318570;
					continue;
				case 51u:
					Form3.smethod_32((Control)(object)NullButton, new Size(1, 1));
					num = ((int)num2 * -403142263) ^ -949416887;
					continue;
				case 50u:
					Form3.smethod_33((Control)(object)button5, 5);
					num = (int)((num2 * 1658633603) ^ 0x53F0EAB5);
					continue;
				case 49u:
					Form3.smethod_32((Control)(object)label1, new Size(207, 76));
					num = (int)((num2 * 119071301) ^ 0x5A44134C);
					continue;
				case 48u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button4);
					num = (int)(num2 * 2096523038) ^ -1176818744;
					continue;
				case 47u:
					num = (int)((num2 * 1409750187) ^ 0x2EC178D0);
					continue;
				case 46u:
					num = ((int)num2 * -1506608290) ^ 0x6DC57551;
					continue;
				case 45u:
					Form3.smethod_33((Control)(object)label1, 7);
					num = ((int)num2 * -94138031) ^ -1100472787;
					continue;
				case 44u:
					Form3.smethod_48((Form)(object)this, (FormBorderStyle)0);
					num = ((int)num2 * -1037387598) ^ 0x5FC082B6;
					continue;
				case 43u:
					Form3.smethod_41(textBox2, bool_0: true);
					Form3.smethod_39((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = (int)(num2 * 2087047866) ^ -1619910258;
					continue;
				case 42u:
					Form3.smethod_31((Control)(object)textBox2, "textBox2");
					num = ((int)num2 * -1076811732) ^ 0x6972137E;
					continue;
				case 41u:
					num = (int)(num2 * 986135159) ^ -621974008;
					continue;
				case 40u:
					Form3.smethod_31((Control)(object)button1, "button1");
					Form3.smethod_32((Control)(object)button1, new Size(49, 21));
					num = (int)(num2 * 1876514954) ^ -8642361;
					continue;
				case 39u:
					Form3.smethod_34((ButtonBase)(object)button7, bool_0: true);
					num = ((int)num2 * -1516237442) ^ -80096176;
					continue;
				case 38u:
					Form3.smethod_50((Form)(object)this, bool_0: false);
					num = (int)((num2 * 1086753723) ^ 0x7C8C5848);
					continue;
				case 37u:
					Form3.smethod_33((Control)(object)button1, 0);
					num = ((int)num2 * -2050899016) ^ 0x26F9D31B;
					continue;
				case 36u:
					num = (int)(num2 * 1079315811) ^ -498013629;
					continue;
				case 35u:
					Form3.smethod_36((Control)(object)button5, (EventHandler)Button5_Click);
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button7), 0);
					num = (int)((num2 * 618268073) ^ 0x21EB6910);
					continue;
				case 34u:
					num = ((int)num2 * -61003973) ^ 0x77BE6A6B;
					continue;
				case 33u:
					Form3.smethod_52((Form)(object)this, bool_0: false);
					num = ((int)num2 * -661040947) ^ 0x5A52DFEF;
					continue;
				case 32u:
					num = (int)((num2 * 709121753) ^ 0x3542617B);
					continue;
				case 31u:
					num = (int)((num2 * 1104986046) ^ 0x30400CAA);
					continue;
				case 30u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button1);
					num = (int)((num2 * 2096793383) ^ 0x25FBF8B9);
					continue;
				case 29u:
					Form3.smethod_14((Control)(object)button4, bool_0: false);
					num = (int)(num2 * 44444) ^ -526817493;
					continue;
				case 28u:
					num = (int)(num2 * 441218640) ^ -1626950602;
					continue;
				case 27u:
					Form3.smethod_33((Control)(object)textBox1, 7);
					num = (int)(num2 * 379032482) ^ -1528772269;
					continue;
				case 26u:
					Form3.smethod_32((Control)(object)button7, new Size(140, 50));
					num = ((int)num2 * -197805171) ^ -840155156;
					continue;
				case 25u:
					Form3.smethod_34((ButtonBase)(object)button5, bool_0: true);
					num = ((int)num2 * -1111377777) ^ -1114077702;
					continue;
				case 24u:
					Form3.smethod_51((Control)(object)this, "Form3");
					num = ((int)num2 * -1154183900) ^ -874500929;
					continue;
				case 23u:
					num = ((int)num2 * -392732922) ^ 0x61B80AA2;
					continue;
				case 22u:
					num = ((int)num2 * -348765776) ^ -1216777001;
					continue;
				case 21u:
					num = ((int)num2 * -550277442) ^ 0x24037995;
					continue;
				case 20u:
					button7 = Form3.smethod_20();
					num = ((int)num2 * -158803891) ^ 0x55766CA0;
					continue;
				case 19u:
					num = (int)((num2 * 919047465) ^ 0x52E78C);
					continue;
				case 18u:
					Form3.smethod_30((Control)(object)textBox2, new Point(174, 26));
					num = (int)(num2 * 884072855) ^ -170880462;
					continue;
				case 17u:
					num = ((int)num2 * -1927414776) ^ 0x7510A187;
					continue;
				case 16u:
					Form3.smethod_35((Control)(object)button1, "Вход");
					num = ((int)num2 * -1827038828) ^ 0x7A23E4AD;
					continue;
				case 15u:
					Form3.smethod_38((Control)(object)button4, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 109489380) ^ 0x606CD399);
					continue;
				case 14u:
					Form3.smethod_34((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -242579436) ^ 0x72658EFF;
					continue;
				case 13u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button5);
					num = (int)((num2 * 489128921) ^ 0x4535756D);
					continue;
				case 12u:
					components = Form3.smethod_19();
					NullButton = Form3.smethod_20();
					button1 = Form3.smethod_20();
					num = ((int)num2 * -1304146110) ^ -395798937;
					continue;
				case 11u:
					num = ((int)num2 * -2079252949) ^ -323171331;
					continue;
				case 10u:
					Form3.smethod_49((Form)(object)this, bool_0: false);
					num = ((int)num2 * -2082880638) ^ -730900454;
					continue;
				case 9u:
					Form3.smethod_26((Control)(object)this, Color.White);
					num = ((int)num2 * -494438835) ^ 0x18476FA4;
					continue;
				case 8u:
					Form3.smethod_53((Form)(object)this, bool_0: false);
					num = (int)(num2 * 63024764) ^ -1905608075;
					continue;
				case 7u:
					errorProvider1 = Form3.smethod_23(components);
					num = ((int)num2 * -338872519) ^ 0x8C09D60;
					continue;
				case 6u:
					num = (int)((num2 * 2072747001) ^ 0x13DDDADC);
					continue;
				case 4u:
					Form3.smethod_30((Control)(object)button7, new Point(174, 243));
					num = (int)((num2 * 1047022359) ^ 0x72B1FE36);
					continue;
				case 3u:
					Form3.smethod_32((Control)(object)button5, new Size(140, 50));
					num = ((int)num2 * -1759799280) ^ -34698893;
					continue;
				case 2u:
					num = (int)(num2 * 553170561) ^ -1905240711;
					continue;
				case 1u:
					Form3.smethod_35((Control)(object)button7, "Достижения");
					num = (int)(num2 * 262762049) ^ -1694009084;
					continue;
				case 0u:
					num = ((int)num2 * -749719374) ^ -1326523479;
					continue;
				case 94u:
					break;
				default:
					Form3.smethod_57((Control)(object)this);
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
