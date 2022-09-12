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
			int num = 888585266;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7654B4F9u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -506402820) ^ 0x4E3C4F7D;
					continue;
				case 0u:
					InitializeComponent();
					num = (int)(num2 * 581157764) ^ -171005856;
					continue;
				default:
					return;
				case 2u:
					break;
				case 1u:
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
			int num = 1076591482;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x41195BC9u) % 9u)
				{
				case 7u:
					num = (int)(num2 * 1753245558) ^ -280619874;
					continue;
				case 6u:
				{
					Form4 form = new Form4();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					num = (int)((num2 * 1184999451) ^ 0xFF8E92C);
					continue;
				}
				case 5u:
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = ((int)num2 * -1155027348) ^ 0x3CDFBA2E;
					continue;
				case 4u:
					Form3.smethod_4((Control)(object)val);
					num = ((int)num2 * -1885573781) ^ -828573821;
					continue;
				case 3u:
					num = ((int)num2 * -1598164775) ^ 0x3271A2E8;
					continue;
				case 1u:
					Form3.smethod_1(errorProvider1);
					num = ((int)num2 * -1691404492) ^ 0x7441B257;
					continue;
				case 0u:
					Form3.smethod_10(val, new Point(Form3.smethod_5((Form)(object)this).X + (Form3.smethod_6((Control)(object)this) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_5((Form)(object)this).Y + (Form3.smethod_8((Control)(object)this) - Form3.smethod_9((Control)(object)val)) / 2 + 70));
					num = (int)(num2 * 1050669449) ^ -381437036;
					continue;
				default:
					return;
				case 2u:
					break;
				case 8u:
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
		while (true)
		{
			int num = 2077680786;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x60ED9241u) % 6u)
				{
				case 4u:
					num = ((int)num2 * -265269785) ^ -1852390197;
					continue;
				case 3u:
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = ((int)num2 * -1599199148) ^ 0x1FB940C;
					continue;
				case 1u:
					Form3.smethod_4((Control)(object)val);
					num = ((int)num2 * -1902795710) ^ 0x4160602F;
					continue;
				case 0u:
					Form3.smethod_10(val, new Point(Form3.smethod_13(Form3.smethod_12((Form)(object)this)).X + (Form3.smethod_7((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_13(Form3.smethod_12((Form)(object)this)).Y + (Form3.smethod_9((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_9((Control)(object)val)) / 2));
					num = ((int)num2 * -1940440987) ^ 0x874734C;
					continue;
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
			int num = -1204118934;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB56E6A08u) % 9u)
				{
				case 8u:
					flag = num5 > 1;
					num = (int)((num2 * 378318133) ^ 0x7B4BA2C3);
					continue;
				case 7u:
					Form3.smethod_15((Control)(object)this, num5);
					num = ((int)num2 * -1879307105) ^ -873327812;
					continue;
				case 6u:
					Form3.smethod_16(Form3.smethod_12((Form)(object)this));
					num = ((int)num2 * -363898290) ^ -1036709588;
					continue;
				case 5u:
					num5 = Form3.smethod_8((Control)(object)this) - 1;
					num = -794147536;
					continue;
				case 3u:
					num = (int)((num2 * 1097020234) ^ 0x59040D59);
					continue;
				case 2u:
					num = -950857971;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -975816493;
						num4 = -975816493;
					}
					else
					{
						num3 = -1565393974;
						num4 = -1565393974;
					}
					num = num3 ^ (int)(num2 * 1384723425);
					continue;
				}
				case 0u:
					break;
				default:
					Form3.smethod_17((Form3.smethod_12((Form)(object)this) as Form1).timer1);
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
		Form3.smethod_0((Control)(object)NullButton);
		while (true)
		{
			int num = 2076440755;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x593D3491u) % 3u)
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
				Form3.smethod_14((Control)(object)button7, bool_0: false);
				num = (int)(num2 * 1641999880) ^ -1853224886;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			goto IL_005c;
		}
		goto IL_0099;
		IL_005c:
		int num = -138585239;
		goto IL_0061;
		IL_0061:
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x933636EFu) % 7u)
			{
			case 6u:
				((Form)this).Dispose(disposing);
				num = -2094033598;
				continue;
			case 5u:
				num = ((int)num2 * -644958317) ^ 0x173D729B;
				continue;
			case 4u:
				Form3.smethod_18((IDisposable)components);
				num = ((int)num2 * -1888100807) ^ 0x1FEF844A;
				continue;
			case 1u:
				num = (int)(num2 * 1095467080) ^ -818846964;
				continue;
			case 0u:
				break;
			default:
				return;
			case 3u:
				goto IL_008e;
			case 2u:
				return;
			}
			break;
			IL_008e:
			if (components != null)
			{
				num = -823986715;
				num3 = -823986715;
				continue;
			}
			goto IL_0099;
		}
		goto IL_005c;
		IL_0099:
		num = -1667888716;
		num3 = -1667888716;
		goto IL_0061;
	}

	private void InitializeComponent()
	{
		components = Form3.smethod_19();
		while (true)
		{
			int num = 1829907734;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x356B6AFBu) % 123u)
				{
				case 122u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button2);
					num = ((int)num2 * -1468218102) ^ -429736288;
					continue;
				case 121u:
					Form3.smethod_35((Control)(object)button2, "Регистрация");
					num = (int)(num2 * 1829633807) ^ -1833048677;
					continue;
				case 120u:
					Form3.smethod_40((Control)(object)label1, bool_0: true);
					num = (int)(num2 * 326040079) ^ -601347945;
					continue;
				case 119u:
					Form3.smethod_33((Control)(object)label1, 7);
					num = (int)(num2 * 2096766595) ^ -64987685;
					continue;
				case 118u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)NullButton);
					num = ((int)num2 * -657631419) ^ 0x5970DE0E;
					continue;
				case 117u:
					Form3.smethod_51((Control)(object)this, "Form3");
					num = (int)(num2 * 290638396) ^ -244120218;
					continue;
				case 116u:
					Form3.smethod_30((Control)(object)button7, new Point(174, 243));
					num = ((int)num2 * -1474770347) ^ -1332470900;
					continue;
				case 115u:
					Form3.smethod_32((Control)(object)NullButton, new Size(1, 1));
					Form3.smethod_33((Control)(object)NullButton, 3);
					num = ((int)num2 * -714944592) ^ -1467428513;
					continue;
				case 114u:
					Form3.smethod_31((Control)(object)button5, "button5");
					num = (int)(num2 * 1423380106) ^ -1564117525;
					continue;
				case 113u:
					Form3.smethod_32((Control)(object)button1, new Size(49, 21));
					num = ((int)num2 * -271850885) ^ 0x5AA80840;
					continue;
				case 112u:
					Form3.smethod_34((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -1316016933) ^ -369925087;
					continue;
				case 111u:
					Form3.smethod_36((Control)(object)button5, (EventHandler)Button5_Click);
					num = (int)(num2 * 1716474257) ^ -692333702;
					continue;
				case 110u:
					Form3.smethod_54((Form)(object)this, bool_0: true);
					Form3.smethod_55((ISupportInitialize)errorProvider1);
					Form3.smethod_56((Control)(object)this, bool_0: false);
					num = ((int)num2 * -1813642699) ^ -1807207426;
					continue;
				case 109u:
					num = ((int)num2 * -1397453956) ^ -873311142;
					continue;
				case 108u:
					num = (int)(num2 * 2009216405) ^ -1281367295;
					continue;
				case 107u:
					num = (int)(num2 * 130735077) ^ -1053979189;
					continue;
				case 106u:
					Form3.smethod_34((ButtonBase)(object)button2, bool_0: true);
					Form3.smethod_36((Control)(object)button2, (EventHandler)Button2_Click);
					num = ((int)num2 * -42343687) ^ -178141587;
					continue;
				case 105u:
					Form3.smethod_29((ButtonBase)(object)button4, (FlatStyle)0);
					num = (int)(num2 * 1728943629) ^ -580478587;
					continue;
				case 104u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button7);
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button5);
					num = ((int)num2 * -1247709580) ^ 0x72C9DEE;
					continue;
				case 103u:
					Form3.smethod_43((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)((num2 * 692346485) ^ 0x33E2E373);
					continue;
				case 102u:
					Form3.smethod_14((Control)(object)button4, bool_0: false);
					num = (int)(num2 * 62488705) ^ -572866063;
					continue;
				case 101u:
					Form3.smethod_35((Control)(object)button5, "Продолжить");
					num = ((int)num2 * -1843336547) ^ 0x79CC8EB9;
					continue;
				case 100u:
					Form3.smethod_35((Control)(object)button4, "Начало игры");
					Form3.smethod_34((ButtonBase)(object)button4, bool_0: true);
					num = (int)(num2 * 683761312) ^ -1400510624;
					continue;
				case 99u:
					num = ((int)num2 * -1221959217) ^ -560917453;
					continue;
				case 98u:
					Form3.smethod_31((Control)(object)NullButton, "NullButton");
					num = ((int)num2 * -1473438621) ^ 0x3F3662FC;
					continue;
				case 97u:
					Form3.smethod_30((Control)(object)label1, new Point(140, 70));
					num = ((int)num2 * -1543691252) ^ -1545710674;
					continue;
				case 96u:
					Form3.smethod_33((Control)(object)button2, 1);
					num = ((int)num2 * -344138271) ^ 0x61011E43;
					continue;
				case 95u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox2);
					num = ((int)num2 * -825900723) ^ 0x325D36C1;
					continue;
				case 94u:
					num = (int)((num2 * 533966867) ^ 0xF52D5F1);
					continue;
				case 93u:
					Form3.smethod_14((Control)(object)button5, bool_0: false);
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button5), 0);
					Form3.smethod_29((ButtonBase)(object)button5, (FlatStyle)0);
					Form3.smethod_38((Control)(object)button5, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -740817323) ^ 0x7BD5BB;
					continue;
				case 92u:
					num = (int)((num2 * 689973321) ^ 0x47162DB9);
					continue;
				case 91u:
					Form3.smethod_30((Control)(object)button2, new Point(174, 49));
					Form3.smethod_31((Control)(object)button2, "button2");
					num = ((int)num2 * -685271488) ^ 0x8F9D4CA;
					continue;
				case 90u:
					Form3.smethod_32((Control)(object)textBox1, new Size(140, 20));
					Form3.smethod_33((Control)(object)textBox1, 7);
					num = (int)((num2 * 270797629) ^ 0x76D565EC);
					continue;
				case 89u:
					Form3.smethod_35((Control)(object)button1, "Вход");
					num = ((int)num2 * -102750000) ^ 0x6AC7BA43;
					continue;
				case 88u:
					errorProvider1 = Form3.smethod_23(components);
					Form3.smethod_24((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -1098959875) ^ -387076652;
					continue;
				case 87u:
					num = (int)((num2 * 2087024075) ^ 0x5D488031);
					continue;
				case 86u:
					num = (int)(num2 * 1199461136) ^ -712767987;
					continue;
				case 85u:
					Form3.smethod_57((Control)(object)this);
					num = (int)((num2 * 1834173021) ^ 0x443E8BE9);
					continue;
				case 84u:
					Form3.smethod_33((Control)(object)button7, 6);
					num = (int)((num2 * 903766404) ^ 0x5D7998C9);
					continue;
				case 83u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button4);
					num = ((int)num2 * -307961645) ^ -893850741;
					continue;
				case 82u:
					Form3.smethod_32((Control)(object)button5, new Size(140, 50));
					num = (int)((num2 * 821641687) ^ 0x587D3F4E);
					continue;
				case 81u:
					num = (int)((num2 * 1039607476) ^ 0x44339DB7);
					continue;
				case 80u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button7), 0);
					num = (int)((num2 * 817071681) ^ 0x5F481B7E);
					continue;
				case 79u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox1);
					num = ((int)num2 * -909193928) ^ -2043445765;
					continue;
				case 78u:
					Form3.smethod_32((Control)(object)button4, new Size(140, 50));
					num = (int)(num2 * 1919463889) ^ -1220655127;
					continue;
				case 77u:
					Form3.smethod_33((Control)(object)button5, 5);
					num = (int)((num2 * 1655006232) ^ 0x4223198);
					continue;
				case 76u:
					button7 = Form3.smethod_20();
					textBox1 = Form3.smethod_21();
					num = (int)(num2 * 1847925072) ^ -2135530948;
					continue;
				case 75u:
					Form3.smethod_50((Form)(object)this, bool_0: false);
					num = (int)(num2 * 483291066) ^ -436587859;
					continue;
				case 74u:
					Form3.smethod_30((Control)(object)button4, new Point(174, 137));
					Form3.smethod_31((Control)(object)button4, "button4");
					num = ((int)num2 * -351355098) ^ -259602532;
					continue;
				case 73u:
					num = ((int)num2 * -298007477) ^ 0xCF11E96;
					continue;
				case 72u:
					Form3.smethod_38((Control)(object)button4, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -850438948) ^ -1556650830;
					continue;
				case 71u:
					Form3.smethod_49((Form)(object)this, bool_0: false);
					num = (int)((num2 * 1923465293) ^ 0x11349114);
					continue;
				case 70u:
					num = ((int)num2 * -2082955604) ^ -1505428972;
					continue;
				case 69u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button4), 0);
					num = (int)((num2 * 790788884) ^ 0x21779E0E);
					continue;
				case 68u:
					Form3.smethod_34((ButtonBase)(object)NullButton, bool_0: false);
					num = (int)((num2 * 1872064624) ^ 0x47F6995);
					continue;
				case 67u:
					num = ((int)num2 * -1604010517) ^ 0xC1DBD7C;
					continue;
				case 66u:
					Form3.smethod_45((Form)(object)this, new Size(486, 296));
					num = ((int)num2 * -616126695) ^ 0x16B12AC3;
					continue;
				case 65u:
					num = ((int)num2 * -893957359) ^ -2126975214;
					continue;
				case 64u:
					NullButton = Form3.smethod_20();
					num = ((int)num2 * -1024515364) ^ -1276091310;
					continue;
				case 63u:
					num = (int)((num2 * 271008512) ^ 0x10B9D3E1);
					continue;
				case 62u:
					num = (int)((num2 * 968106543) ^ 0x4846A407);
					continue;
				case 61u:
					num = (int)(num2 * 239099839) ^ -1762876920;
					continue;
				case 60u:
					num = (int)(num2 * 1298867732) ^ -1338006309;
					continue;
				case 59u:
					Form3.smethod_35((Control)(object)button7, "Достижения");
					num = ((int)num2 * -1468848497) ^ -1438772710;
					continue;
				case 57u:
					num = ((int)num2 * -1072853011) ^ 0x2C190566;
					continue;
				case 55u:
					button1 = Form3.smethod_20();
					num = ((int)num2 * -716768504) ^ 0x6894969A;
					continue;
				case 54u:
					num = ((int)num2 * -511549955) ^ -845447290;
					continue;
				case 53u:
					Form3.smethod_30((Control)(object)button5, new Point(174, 190));
					num = ((int)num2 * -1281203813) ^ -191476057;
					continue;
				case 52u:
					Form3.smethod_26((Control)(object)label1, Color.Transparent);
					Form3.smethod_38((Control)(object)label1, Form3.smethod_37("Mistral", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -106533073) ^ -1081467833;
					continue;
				case 51u:
					Form3.smethod_33((Control)(object)button1, 0);
					num = ((int)num2 * -1145750805) ^ 0x6D7EB2BB;
					continue;
				case 50u:
					num = ((int)num2 * -592214404) ^ 0x3495598E;
					continue;
				case 49u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -734304332) ^ -1405591230;
					continue;
				case 48u:
					Form3.smethod_36((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -2003767339) ^ 0xD149D26;
					continue;
				case 47u:
					num = (int)(num2 * 1528429480) ^ -232729991;
					continue;
				case 46u:
					num = (int)((num2 * 978131494) ^ 0x2149864D);
					continue;
				case 45u:
					Form3.smethod_39((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = (int)(num2 * 1431904160) ^ -1417199187;
					continue;
				case 44u:
					Form3.smethod_35((Control)(object)label1, "QUARTO");
					num = ((int)num2 * -9555405) ^ -643550082;
					continue;
				case 43u:
					Form3.smethod_31((Control)(object)textBox2, "textBox2");
					Form3.smethod_32((Control)(object)textBox2, new Size(140, 20));
					Form3.smethod_33((Control)(object)textBox2, 8);
					num = ((int)num2 * -80201633) ^ -1544847666;
					continue;
				case 42u:
					num = ((int)num2 * -1690259246) ^ 0x74FF00B;
					continue;
				case 41u:
					num = ((int)num2 * -1708947266) ^ 0x38E5D451;
					continue;
				case 40u:
					num = (int)(num2 * 1522325984) ^ -1990160216;
					continue;
				case 39u:
					num = ((int)num2 * -994167439) ^ 0x423C514B;
					continue;
				case 38u:
					Form3.smethod_48((Form)(object)this, (FormBorderStyle)0);
					num = (int)((num2 * 1370621567) ^ 0x617A42E5);
					continue;
				case 37u:
					Form3.smethod_31((Control)(object)label1, "label1");
					Form3.smethod_32((Control)(object)label1, new Size(207, 76));
					num = ((int)num2 * -566833629) ^ -2008857820;
					continue;
				case 36u:
					num = ((int)num2 * -1343287074) ^ 0x61B61A31;
					continue;
				case 35u:
					num = ((int)num2 * -381432060) ^ -685084849;
					continue;
				case 34u:
					Form3.smethod_26((Control)(object)NullButton, Color.Transparent);
					num = (int)((num2 * 481091794) ^ 0x61E875C8);
					continue;
				case 33u:
					Form3.smethod_52((Form)(object)this, bool_0: false);
					num = ((int)num2 * -113344018) ^ -1622998951;
					continue;
				case 32u:
					label1 = Form3.smethod_22();
					textBox2 = Form3.smethod_21();
					num = (int)((num2 * 455974340) ^ 0x4826206D);
					continue;
				case 31u:
					Form3.smethod_31((Control)(object)button7, "button7");
					Form3.smethod_32((Control)(object)button7, new Size(140, 50));
					num = (int)((num2 * 256513536) ^ 0x1918BC33);
					continue;
				case 30u:
					num = (int)(num2 * 1620260409) ^ -1577270651;
					continue;
				case 29u:
					Form3.smethod_34((ButtonBase)(object)button5, bool_0: true);
					num = ((int)num2 * -734277097) ^ 0x11C66311;
					continue;
				case 28u:
					Form3.smethod_33((Control)(object)button4, 4);
					num = ((int)num2 * -243693969) ^ -1402616155;
					continue;
				case 27u:
					Form3.smethod_30((Control)(object)button1, new Point(265, 49));
					num = (int)(num2 * 1038360675) ^ -1540852610;
					continue;
				case 26u:
					Form3.smethod_30((Control)(object)NullButton, new Point(-1, -1));
					num = (int)((num2 * 930457011) ^ 0x3DC751F7);
					continue;
				case 25u:
					Form3.smethod_41(textBox2, bool_0: true);
					Form3.smethod_39((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					Form3.smethod_42(errorProvider1, (ContainerControl)(object)this);
					num = ((int)num2 * -1514926982) ^ -984738699;
					continue;
				case 24u:
					num = (int)((num2 * 1166033090) ^ 0x7DB10FAA);
					continue;
				case 23u:
					Form3.smethod_31((Control)(object)button1, "button1");
					num = (int)((num2 * 1118675519) ^ 0x111CCB6);
					continue;
				case 22u:
					Form3.smethod_36((Control)(object)button4, (EventHandler)Button4_Click);
					num = ((int)num2 * -582537376) ^ 0x5F8BC194;
					continue;
				case 21u:
					button4 = Form3.smethod_20();
					num = (int)(num2 * 1962392506) ^ -979684030;
					continue;
				case 20u:
					num = ((int)num2 * -830945023) ^ -1584018940;
					continue;
				case 19u:
					Form3.smethod_31((Control)(object)textBox1, "textBox1");
					num = (int)(num2 * 701731525) ^ -363622900;
					continue;
				case 18u:
					Form3.smethod_26((Control)(object)this, Color.White);
					num = (int)(num2 * 1748474005) ^ -785146862;
					continue;
				case 17u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)label1);
					num = (int)(num2 * 450033782) ^ -773011149;
					continue;
				case 16u:
					button5 = Form3.smethod_20();
					num = (int)((num2 * 803020429) ^ 0xEDCFFF6);
					continue;
				case 15u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)NullButton), 0);
					Form3.smethod_29((ButtonBase)(object)NullButton, (FlatStyle)0);
					num = (int)((num2 * 1046597733) ^ 0x3D1BD51A);
					continue;
				case 14u:
					num = ((int)num2 * -538233145) ^ -46775560;
					continue;
				case 13u:
					Form3.smethod_25((Control)(object)this);
					num = ((int)num2 * -182424337) ^ -1632438957;
					continue;
				case 12u:
					Form3.smethod_29((ButtonBase)(object)button7, (FlatStyle)0);
					num = (int)(num2 * 1035804258) ^ -603626755;
					continue;
				case 11u:
					Form3.smethod_30((Control)(object)textBox2, new Point(174, 26));
					num = ((int)num2 * -1433825210) ^ 0x44191B9;
					continue;
				case 10u:
					num = ((int)num2 * -1354842) ^ 0x518BA4E2;
					continue;
				case 9u:
					Form3.smethod_34((ButtonBase)(object)button7, bool_0: true);
					Form3.smethod_36((Control)(object)button7, (EventHandler)Button7_Click);
					Form3.smethod_30((Control)(object)textBox1, new Point(174, 2));
					num = ((int)num2 * -2043640450) ^ -763351145;
					continue;
				case 8u:
					num = (int)((num2 * 1108246124) ^ 0xE0802BE);
					continue;
				case 7u:
					num = (int)((num2 * 1269611532) ^ 0x4148A432);
					continue;
				case 6u:
					num = ((int)num2 * -1277012902) ^ 0x53105BC3;
					continue;
				case 5u:
					Form3.smethod_32((Control)(object)button2, new Size(85, 21));
					num = (int)(num2 * 141988543) ^ -1125555123;
					continue;
				case 4u:
					Form3.smethod_38((Control)(object)button7, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -834314113) ^ -1918428610;
					continue;
				case 3u:
					Form3.smethod_53((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1515530774) ^ 0x4E41EE8;
					continue;
				case 2u:
					button2 = Form3.smethod_20();
					num = (int)((num2 * 1732917299) ^ 0x462A89CC);
					continue;
				case 1u:
					Form3.smethod_44((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -638087290) ^ 0x4501CB1A;
					continue;
				case 0u:
					num = ((int)num2 * -495418710) ^ -551609130;
					continue;
				default:
					return;
				case 56u:
					break;
				case 58u:
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
