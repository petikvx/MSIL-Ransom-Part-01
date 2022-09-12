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
			int num = -1899844130;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD8552B26u) % 5u)
				{
				case 4u:
					num = (int)(num2 * 2027518723) ^ -2097369855;
					continue;
				case 3u:
					num = (int)(num2 * 297744444) ^ -901725581;
					continue;
				case 1u:
					InitializeComponent();
					num = (int)((num2 * 1819286130) ^ 0x141D794);
					continue;
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

	private void Button2_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 1362840631;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2300BC85u) % 7u)
				{
				case 6u:
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = (int)(num2 * 1866911958) ^ -1726633492;
					continue;
				case 5u:
					Form3.smethod_0((Control)(object)NullButton);
					num = (int)((num2 * 1658610847) ^ 0x4864B40);
					continue;
				case 4u:
					Form3.smethod_1(errorProvider1);
					num = (int)((num2 * 357226207) ^ 0xB2BEE9A);
					continue;
				case 3u:
					num = ((int)num2 * -1666134516) ^ -1714185687;
					continue;
				case 2u:
				{
					Form4 form = new Form4();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					Form val = (Form)(object)form;
					Form3.smethod_4((Control)(object)val);
					Form3.smethod_10(val, new Point(Form3.smethod_5((Form)(object)this).X + (Form3.smethod_6((Control)(object)this) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_5((Form)(object)this).Y + (Form3.smethod_8((Control)(object)this) - Form3.smethod_9((Control)(object)val)) / 2 + 70));
					num = ((int)num2 * -1680615173) ^ 0x15B158F2;
					continue;
				}
				default:
					return;
				case 0u:
					break;
				case 1u:
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
			int num = 2008285964;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7434BB6Du) % 6u)
				{
				case 5u:
					Form3.smethod_10(val, new Point(Form3.smethod_13(Form3.smethod_12((Form)(object)this)).X + (Form3.smethod_7((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_13(Form3.smethod_12((Form)(object)this)).Y + (Form3.smethod_9((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_9((Control)(object)val)) / 2));
					num = ((int)num2 * -510449371) ^ 0x49BC4E9F;
					continue;
				case 3u:
					num = (int)(num2 * 1080874851) ^ -1906100490;
					continue;
				case 2u:
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = (int)((num2 * 1434975212) ^ 0x7BEA6C77);
					continue;
				case 1u:
				{
					Form2 form = new Form2();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					Form3.smethod_4((Control)(object)val);
					num = (int)((num2 * 127128070) ^ 0x158BD874);
					continue;
				}
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
		int num3 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -1517407780;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE2F7D3A0u) % 10u)
				{
				case 9u:
					num = (int)(num2 * 177812208) ^ -533414587;
					continue;
				case 8u:
					Form3.smethod_16(Form3.smethod_12((Form)(object)this));
					num = (int)((num2 * 1994988855) ^ 0x68AAC765);
					continue;
				case 7u:
					Form3.smethod_17((Form3.smethod_12((Form)(object)this) as Form1).timer1);
					num = (int)((num2 * 4147677) ^ 0x2F40AE20);
					continue;
				case 6u:
					num = -57218676;
					continue;
				case 4u:
					num3 = Form3.smethod_8((Control)(object)this) - 1;
					Form3.smethod_15((Control)(object)this, num3);
					num = -1438135932;
					continue;
				case 2u:
					num = ((int)num2 * -359379469) ^ 0x3517AE38;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1829052292;
						num5 = 1829052292;
					}
					else
					{
						num4 = 1216880940;
						num5 = 1216880940;
					}
					num = num4 ^ ((int)num2 * -1999911760);
					continue;
				}
				case 0u:
					flag = num3 > 1;
					num = (int)((num2 * 1652274376) ^ 0x765FB971);
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
		while (true)
		{
			int num = -825356083;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xED29CBC2u) % 3u)
				{
				case 2u:
					goto IL_000d;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_000d:
				num = ((int)num2 * -1308233628) ^ -191886197;
			}
		}
	}

	public void ContinueLock()
	{
		Form3.smethod_14((Control)(object)button5, bool_0: false);
		while (true)
		{
			int num = -1036940962;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBB8DF4C6u) % 3u)
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
				num = (int)(num2 * 615525553) ^ -695605449;
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
			int num = 1861652704;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD6D8713u) % 4u)
				{
				case 3u:
					Form3.smethod_0((Control)(object)NullButton);
					num = (int)((num2 * 1522063642) ^ 0x32358010);
					continue;
				case 1u:
					Form3.smethod_14((Control)(object)button7, bool_0: false);
					num = ((int)num2 * -226985962) ^ 0x44C251B;
					continue;
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

	protected override void Dispose(bool disposing)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -566631515;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xEDC2513Fu) % 10u)
				{
				case 9u:
					((Form)this).Dispose(disposing);
					num = -128007538;
					continue;
				case 8u:
					num3 = ((components != null) ? 1 : 0);
					goto IL_0020;
				case 7u:
					num = ((int)num2 * -1457198428) ^ 0x502AF6DC;
					continue;
				case 6u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1320882244;
						num5 = -1320882244;
					}
					else
					{
						num4 = -2058712280;
						num5 = -2058712280;
					}
					num = num4 ^ (int)(num2 * 1737559586);
					continue;
				}
				case 5u:
					num = ((int)num2 * -404918604) ^ -2070962772;
					continue;
				case 4u:
					if (disposing)
					{
						num = (int)(num2 * 900837198) ^ -1689519129;
						continue;
					}
					num3 = 0;
					goto IL_0020;
				case 3u:
					Form3.smethod_18((IDisposable)components);
					num = ((int)num2 * -1333444446) ^ 0x7150C798;
					continue;
				case 1u:
					num = ((int)num2 * -1804494378) ^ -1455316869;
					continue;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
					IL_0020:
					flag = (byte)num3 != 0;
					num = -139398729;
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
			int num = 1757615162;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7CC367A9u) % 131u)
				{
				case 130u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button4), 0);
					num = ((int)num2 * -1488092626) ^ 0x6EAFAFF;
					continue;
				case 129u:
					num = (int)((num2 * 1240733373) ^ 0x94E770);
					continue;
				case 128u:
					num = (int)((num2 * 268997850) ^ 0x27043859);
					continue;
				case 127u:
					Form3.smethod_30((Control)(object)button7, new Point(174, 243));
					num = ((int)num2 * -845724136) ^ 0x2A1C865B;
					continue;
				case 126u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox2);
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox1);
					num = (int)(num2 * 694180042) ^ -1029349132;
					continue;
				case 125u:
					Form3.smethod_31((Control)(object)button4, "button4");
					num = (int)((num2 * 1980810239) ^ 0x6E4F175D);
					continue;
				case 124u:
					Form3.smethod_35((Control)(object)button7, "Достижения");
					Form3.smethod_34((ButtonBase)(object)button7, bool_0: true);
					Form3.smethod_36((Control)(object)button7, (EventHandler)Button7_Click);
					Form3.smethod_30((Control)(object)textBox1, new Point(174, 2));
					num = ((int)num2 * -1746240707) ^ 0xB3DED64;
					continue;
				case 123u:
					Form3.smethod_31((Control)(object)button1, "button1");
					num = (int)(num2 * 2045207039) ^ -131159082;
					continue;
				case 122u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button4);
					num = (int)(num2 * 1974717423) ^ -43262397;
					continue;
				case 121u:
					Form3.smethod_43((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -498384009) ^ -358120846;
					continue;
				case 120u:
					num = ((int)num2 * -1804784701) ^ 0x74B8478;
					continue;
				case 119u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button7), 0);
					num = (int)((num2 * 1182573902) ^ 0x4920C333);
					continue;
				case 118u:
					Form3.smethod_24((ISupportInitialize)errorProvider1);
					num = (int)((num2 * 1821646690) ^ 0x67BB2DBC);
					continue;
				case 117u:
					Form3.smethod_38((Control)(object)button4, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1573355542) ^ 0x51DB5ADA;
					continue;
				case 116u:
					Form3.smethod_35((Control)(object)button4, "Начало игры");
					num = (int)((num2 * 2102770390) ^ 0x3A235346);
					continue;
				case 115u:
					components = Form3.smethod_19();
					NullButton = Form3.smethod_20();
					num = (int)(num2 * 2134955530) ^ -1868763913;
					continue;
				case 114u:
					num = ((int)num2 * -1868760220) ^ 0x309E8266;
					continue;
				case 113u:
					Form3.smethod_14((Control)(object)button5, bool_0: false);
					num = (int)(num2 * 1210187061) ^ -31262532;
					continue;
				case 112u:
					Form3.smethod_56((Control)(object)this, bool_0: false);
					Form3.smethod_57((Control)(object)this);
					num = (int)((num2 * 472597466) ^ 0x2B9A1B93);
					continue;
				case 111u:
					Form3.smethod_30((Control)(object)textBox2, new Point(174, 26));
					Form3.smethod_31((Control)(object)textBox2, "textBox2");
					num = ((int)num2 * -431453736) ^ -508303817;
					continue;
				case 110u:
					num = (int)((num2 * 348903173) ^ 0xA00AD2F);
					continue;
				case 109u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)NullButton), 0);
					num = ((int)num2 * -2018699271) ^ 0x42BC88CB;
					continue;
				case 108u:
					Form3.smethod_30((Control)(object)button5, new Point(174, 190));
					num = (int)((num2 * 2016557877) ^ 0x41BA2E67);
					continue;
				case 107u:
					Form3.smethod_39((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					Form3.smethod_42(errorProvider1, (ContainerControl)(object)this);
					num = (int)(num2 * 779969066) ^ -572924001;
					continue;
				case 106u:
					Form3.smethod_48((Form)(object)this, (FormBorderStyle)0);
					num = ((int)num2 * -2114662823) ^ -1515756216;
					continue;
				case 105u:
					Form3.smethod_14((Control)(object)button4, bool_0: false);
					num = (int)((num2 * 25564537) ^ 0x556648F8);
					continue;
				case 104u:
					num = ((int)num2 * -1831415123) ^ 0x34056593;
					continue;
				case 103u:
					Form3.smethod_26((Control)(object)this, Color.White);
					num = (int)(num2 * 1342881654) ^ -438833703;
					continue;
				case 102u:
					num = (int)((num2 * 1148270434) ^ 0x43AD07CD);
					continue;
				case 101u:
					num = ((int)num2 * -1468471229) ^ -2108831253;
					continue;
				case 100u:
					num = ((int)num2 * -145083354) ^ 0x74DCC374;
					continue;
				case 99u:
					Form3.smethod_35((Control)(object)button2, "Регистрация");
					Form3.smethod_34((ButtonBase)(object)button2, bool_0: true);
					Form3.smethod_36((Control)(object)button2, (EventHandler)Button2_Click);
					num = ((int)num2 * -18448109) ^ -690723772;
					continue;
				case 98u:
					Form3.smethod_38((Control)(object)button7, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -586245850) ^ -623066983;
					continue;
				case 97u:
					Form3.smethod_36((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -1073263000) ^ -190140990;
					continue;
				case 96u:
					num = (int)(num2 * 272940005) ^ -619428546;
					continue;
				case 95u:
					num = ((int)num2 * -1699257576) ^ 0x5820DD6D;
					continue;
				case 94u:
					Form3.smethod_33((Control)(object)button5, 5);
					num = ((int)num2 * -1019160602) ^ 0x46FE0B0A;
					continue;
				case 93u:
					num = ((int)num2 * -1157243608) ^ -1286404927;
					continue;
				case 92u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button5), 0);
					num = ((int)num2 * -1304416074) ^ -1649252622;
					continue;
				case 91u:
					num = (int)((num2 * 740887050) ^ 0x44CF1DA9);
					continue;
				case 90u:
					num = ((int)num2 * -1380786126) ^ -1414732095;
					continue;
				case 89u:
					Form3.smethod_29((ButtonBase)(object)button7, (FlatStyle)0);
					num = (int)(num2 * 1060782702) ^ -1231829635;
					continue;
				case 88u:
					num = ((int)num2 * -1089031696) ^ 0x48134FF4;
					continue;
				case 86u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button7);
					num = (int)(num2 * 1629461884) ^ -1295361490;
					continue;
				case 85u:
					num = (int)((num2 * 1281210530) ^ 0x5051F036);
					continue;
				case 84u:
					Form3.smethod_30((Control)(object)button4, new Point(174, 137));
					num = (int)((num2 * 601044946) ^ 0x5CA046A3);
					continue;
				case 83u:
					num = ((int)num2 * -649495608) ^ -228422961;
					continue;
				case 82u:
					Form3.smethod_51((Control)(object)this, "Form3");
					num = ((int)num2 * -1953669942) ^ -832610092;
					continue;
				case 81u:
					num = ((int)num2 * -2023257308) ^ 0x5E5E186A;
					continue;
				case 80u:
					num = (int)((num2 * 1351585099) ^ 0x4478CC48);
					continue;
				case 79u:
					Form3.smethod_33((Control)(object)button7, 6);
					num = (int)((num2 * 1579940669) ^ 0x5BE8D9C6);
					continue;
				case 78u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -1935920145) ^ -1993253840;
					continue;
				case 77u:
					Form3.smethod_32((Control)(object)button1, new Size(49, 21));
					num = ((int)num2 * -1912919591) ^ 0x2AB57FE6;
					continue;
				case 76u:
					num = ((int)num2 * -48048684) ^ -392092560;
					continue;
				case 75u:
					button1 = Form3.smethod_20();
					num = ((int)num2 * -1140091601) ^ 0x17FF2415;
					continue;
				case 74u:
					Form3.smethod_39((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = (int)((num2 * 2114474429) ^ 0x6404C6D2);
					continue;
				case 73u:
					num = ((int)num2 * -1622725857) ^ -783876492;
					continue;
				case 72u:
					num = (int)(num2 * 632360248) ^ -561461590;
					continue;
				case 71u:
					Form3.smethod_32((Control)(object)button2, new Size(85, 21));
					num = ((int)num2 * -35999939) ^ 0x2CCBB99B;
					continue;
				case 70u:
					Form3.smethod_32((Control)(object)textBox2, new Size(140, 20));
					num = (int)(num2 * 1102914813) ^ -588931779;
					continue;
				case 69u:
					Form3.smethod_32((Control)(object)textBox1, new Size(140, 20));
					num = ((int)num2 * -304819208) ^ -193733136;
					continue;
				case 67u:
					Form3.smethod_30((Control)(object)button2, new Point(174, 49));
					num = ((int)num2 * -1281703212) ^ -954368990;
					continue;
				case 66u:
					Form3.smethod_31((Control)(object)button7, "button7");
					Form3.smethod_32((Control)(object)button7, new Size(140, 50));
					num = ((int)num2 * -1739979455) ^ 0x6619DB75;
					continue;
				case 65u:
					Form3.smethod_52((Form)(object)this, bool_0: false);
					Form3.smethod_53((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1362434256) ^ -1584949726;
					continue;
				case 64u:
					Form3.smethod_32((Control)(object)button5, new Size(140, 50));
					num = ((int)num2 * -167701588) ^ -1238495382;
					continue;
				case 63u:
					Form3.smethod_32((Control)(object)NullButton, new Size(1, 1));
					num = (int)((num2 * 709366586) ^ 0x34577CBE);
					continue;
				case 62u:
					Form3.smethod_32((Control)(object)button4, new Size(140, 50));
					num = ((int)num2 * -118071680) ^ 0x6502F9BF;
					continue;
				case 61u:
					Form3.smethod_34((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -2056809126) ^ -46397700;
					continue;
				case 60u:
					num = (int)((num2 * 1405183217) ^ 0x1DA9CCBA);
					continue;
				case 59u:
					errorProvider1 = Form3.smethod_23(components);
					num = ((int)num2 * -2055638038) ^ -1970377091;
					continue;
				case 58u:
					Form3.smethod_38((Control)(object)label1, Form3.smethod_37("Mistral", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 215656903) ^ -608935384;
					continue;
				case 57u:
					Form3.smethod_41(textBox2, bool_0: true);
					num = (int)(num2 * 1274633666) ^ -909863787;
					continue;
				case 56u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button2);
					num = ((int)num2 * -111526056) ^ -520961455;
					continue;
				case 55u:
					Form3.smethod_31((Control)(object)label1, "label1");
					num = (int)(num2 * 1845271643) ^ -1797739535;
					continue;
				case 54u:
					button2 = Form3.smethod_20();
					button4 = Form3.smethod_20();
					button5 = Form3.smethod_20();
					button7 = Form3.smethod_20();
					num = ((int)num2 * -803073268) ^ 0x6C6C5019;
					continue;
				case 53u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button5);
					num = (int)((num2 * 1902625997) ^ 0xA0DA57D);
					continue;
				case 52u:
					Form3.smethod_33((Control)(object)textBox1, 7);
					num = (int)((num2 * 252040156) ^ 0x4F6DA424);
					continue;
				case 51u:
					num = (int)((num2 * 1856442043) ^ 0xB6787B2);
					continue;
				case 50u:
					num = ((int)num2 * -1000732096) ^ 0x145444CF;
					continue;
				case 49u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)label1);
					num = (int)((num2 * 867590263) ^ 0x16B4246E);
					continue;
				case 48u:
					label1 = Form3.smethod_22();
					textBox2 = Form3.smethod_21();
					num = ((int)num2 * -331448208) ^ -1132644698;
					continue;
				case 47u:
					num = (int)((num2 * 2129988704) ^ 0xAACE665);
					continue;
				case 46u:
					Form3.smethod_29((ButtonBase)(object)NullButton, (FlatStyle)0);
					Form3.smethod_30((Control)(object)NullButton, new Point(-1, -1));
					num = (int)((num2 * 1522364626) ^ 0xF5BCE17);
					continue;
				case 45u:
					Form3.smethod_31((Control)(object)button5, "button5");
					num = ((int)num2 * -1729499075) ^ -315069751;
					continue;
				case 44u:
					Form3.smethod_33((Control)(object)button2, 1);
					num = ((int)num2 * -1967182240) ^ -666184470;
					continue;
				case 43u:
					num = ((int)num2 * -511702216) ^ -1781288149;
					continue;
				case 42u:
					Form3.smethod_50((Form)(object)this, bool_0: false);
					num = ((int)num2 * -206440358) ^ -1858664900;
					continue;
				case 41u:
					Form3.smethod_30((Control)(object)button1, new Point(265, 49));
					num = (int)(num2 * 2028748083) ^ -1056323655;
					continue;
				case 40u:
					Form3.smethod_32((Control)(object)label1, new Size(207, 76));
					num = (int)(num2 * 1331522483) ^ -1327597089;
					continue;
				case 39u:
					num = (int)(num2 * 1838753158) ^ -918157352;
					continue;
				case 38u:
					num = ((int)num2 * -598636909) ^ -61131207;
					continue;
				case 37u:
					num = (int)(num2 * 190722507) ^ -1417851592;
					continue;
				case 36u:
					Form3.smethod_33((Control)(object)button4, 4);
					num = ((int)num2 * -373047987) ^ 0x51630BE4;
					continue;
				case 35u:
					textBox1 = Form3.smethod_21();
					num = ((int)num2 * -1917795100) ^ 0x3A24E5EB;
					continue;
				case 34u:
					Form3.smethod_34((ButtonBase)(object)button5, bool_0: true);
					Form3.smethod_36((Control)(object)button5, (EventHandler)Button5_Click);
					num = ((int)num2 * -1308137484) ^ 0x7BDDCD1D;
					continue;
				case 33u:
					Form3.smethod_31((Control)(object)button2, "button2");
					num = ((int)num2 * -624352312) ^ -358704895;
					continue;
				case 32u:
					num = (int)((num2 * 2017655943) ^ 0x50938788);
					continue;
				case 31u:
					Form3.smethod_33((Control)(object)NullButton, 3);
					num = (int)((num2 * 328452256) ^ 0x72C55C67);
					continue;
				case 30u:
					Form3.smethod_25((Control)(object)this);
					num = (int)(num2 * 168327744) ^ -136120971;
					continue;
				case 29u:
					Form3.smethod_33((Control)(object)label1, 7);
					num = (int)(num2 * 1115462706) ^ -395205473;
					continue;
				case 28u:
					Form3.smethod_34((ButtonBase)(object)NullButton, bool_0: false);
					num = (int)(num2 * 2113750878) ^ -242668128;
					continue;
				case 27u:
					Form3.smethod_44((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -216958345) ^ 0x625AE961;
					continue;
				case 26u:
					Form3.smethod_40((Control)(object)label1, bool_0: true);
					num = (int)(num2 * 1521421136) ^ -74074932;
					continue;
				case 25u:
					Form3.smethod_29((ButtonBase)(object)button5, (FlatStyle)0);
					num = (int)((num2 * 685899938) ^ 0x5C44A74);
					continue;
				case 24u:
					num = (int)((num2 * 410153055) ^ 0x2F594EB5);
					continue;
				case 23u:
					Form3.smethod_35((Control)(object)button5, "Продолжить");
					num = ((int)num2 * -2014376689) ^ 0x26D45CA7;
					continue;
				case 22u:
					Form3.smethod_54((Form)(object)this, bool_0: true);
					num = ((int)num2 * -1627722688) ^ 0x3A46A114;
					continue;
				case 21u:
					Form3.smethod_29((ButtonBase)(object)button4, (FlatStyle)0);
					num = ((int)num2 * -47831627) ^ -949339369;
					continue;
				case 20u:
					num = ((int)num2 * -919554489) ^ 0x151157B9;
					continue;
				case 19u:
					num = (int)(num2 * 981089155) ^ -739867540;
					continue;
				case 18u:
					Form3.smethod_49((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1306618762) ^ -907358534;
					continue;
				case 17u:
					Form3.smethod_31((Control)(object)NullButton, "NullButton");
					num = (int)(num2 * 146373734) ^ -1202351020;
					continue;
				case 16u:
					Form3.smethod_38((Control)(object)button5, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 92465505) ^ -1801606823;
					continue;
				case 15u:
					num = (int)((num2 * 1238555774) ^ 0x41E96047);
					continue;
				case 14u:
					num = (int)((num2 * 1674234385) ^ 0xABC371A);
					continue;
				case 13u:
					Form3.smethod_35((Control)(object)label1, "QUARTO");
					num = (int)(num2 * 229642726) ^ -831098855;
					continue;
				case 12u:
					num = ((int)num2 * -1279923021) ^ -955969387;
					continue;
				case 11u:
					Form3.smethod_31((Control)(object)textBox1, "textBox1");
					num = (int)(num2 * 1982237002) ^ -22375624;
					continue;
				case 10u:
					num = ((int)num2 * -722047375) ^ -1320277428;
					continue;
				case 9u:
					Form3.smethod_34((ButtonBase)(object)button4, bool_0: true);
					num = ((int)num2 * -1975839012) ^ 0x5BB867BF;
					continue;
				case 8u:
					Form3.smethod_33((Control)(object)button1, 0);
					Form3.smethod_35((Control)(object)button1, "Вход");
					num = ((int)num2 * -1325143934) ^ 0x5B1311A3;
					continue;
				case 7u:
					Form3.smethod_45((Form)(object)this, new Size(486, 296));
					num = ((int)num2 * -148257227) ^ -1929342134;
					continue;
				case 6u:
					Form3.smethod_36((Control)(object)button4, (EventHandler)Button4_Click);
					num = ((int)num2 * -1081913305) ^ 0x537A0082;
					continue;
				case 5u:
					Form3.smethod_26((Control)(object)NullButton, Color.Transparent);
					num = ((int)num2 * -630417853) ^ -115291066;
					continue;
				case 4u:
					Form3.smethod_30((Control)(object)label1, new Point(140, 70));
					num = ((int)num2 * -2060267766) ^ -1396629515;
					continue;
				case 3u:
					Form3.smethod_55((ISupportInitialize)errorProvider1);
					num = (int)((num2 * 588595367) ^ 0xACAC466);
					continue;
				case 2u:
					Form3.smethod_33((Control)(object)textBox2, 8);
					num = ((int)num2 * -641738549) ^ -1758814394;
					continue;
				case 1u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)NullButton);
					num = ((int)num2 * -1848316594) ^ 0x44444C77;
					continue;
				case 0u:
					Form3.smethod_26((Control)(object)label1, Color.Transparent);
					num = (int)((num2 * 1240540436) ^ 0x38F111AF);
					continue;
				default:
					return;
				case 87u:
					break;
				case 68u:
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
