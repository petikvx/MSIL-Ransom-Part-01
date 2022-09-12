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
			int num = -1879553647;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x87997FEEu) % 6u)
				{
				case 3u:
					num = (int)((num2 * 1048186820) ^ 0x2E2C5CE2);
					continue;
				case 2u:
					num = ((int)num2 * -1912748406) ^ 0x1AEF267;
					continue;
				case 1u:
					num = ((int)num2 * -66265907) ^ 0x11BCD6E4;
					continue;
				case 0u:
					InitializeComponent();
					num = (int)(num2 * 1418285110) ^ -1260055982;
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

	private void Button2_Click(object sender, EventArgs e)
	{
		Form val = default(Form);
		while (true)
		{
			int num = 1904362464;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6A4FFD9Du) % 6u)
				{
				case 5u:
					Form3.smethod_10(val, new Point(Form3.smethod_5((Form)(object)this).X + (Form3.smethod_6((Control)(object)this) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_5((Form)(object)this).Y + (Form3.smethod_8((Control)(object)this) - Form3.smethod_9((Control)(object)val)) / 2 + 70));
					num = ((int)num2 * -188999882) ^ 0x6B8AB4;
					continue;
				case 2u:
					Form3.smethod_1(errorProvider1);
					num = ((int)num2 * -777713642) ^ -2097812505;
					continue;
				case 1u:
					Form3.smethod_0((Control)(object)NullButton);
					num = (int)(num2 * 840421798) ^ -929702783;
					continue;
				case 0u:
				{
					Form4 form = new Form4();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					Form3.smethod_4((Control)(object)val);
					num = ((int)num2 * -550783801) ^ 0xD70AB3E;
					continue;
				}
				case 4u:
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
		Form val = default(Form);
		while (true)
		{
			int num = -933991551;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB4DDF658u) % 7u)
				{
				case 5u:
					Form3.smethod_10(val, new Point(Form3.smethod_13(Form3.smethod_12((Form)(object)this)).X + (Form3.smethod_7((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_13(Form3.smethod_12((Form)(object)this)).Y + (Form3.smethod_9((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_9((Control)(object)val)) / 2));
					num = (int)(num2 * 205455883) ^ -1131980936;
					continue;
				case 4u:
					Form3.smethod_0((Control)(object)NullButton);
					num = ((int)num2 * -1756766362) ^ 0x499F0348;
					continue;
				case 3u:
				{
					Form2 form = new Form2();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					Form3.smethod_4((Control)(object)val);
					num = (int)(num2 * 395775991) ^ -1702346337;
					continue;
				}
				case 2u:
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = ((int)num2 * -380751961) ^ -831778674;
					continue;
				case 1u:
					num = (int)(num2 * 1878561206) ^ -1400765857;
					continue;
				default:
					return;
				case 0u:
					break;
				case 6u:
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
			int num = 1051824677;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x36F5E621u) % 11u)
				{
				case 10u:
					Form3.smethod_16(Form3.smethod_12((Form)(object)this));
					num = (int)((num2 * 1569276254) ^ 0x3BA76A06);
					continue;
				case 9u:
					flag = num3 > 1;
					num = ((int)num2 * -475850866) ^ -1083686092;
					continue;
				case 8u:
					Form3.smethod_15((Control)(object)this, num3);
					num = ((int)num2 * -1294102483) ^ 0x1CB89147;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1109736312;
						num5 = -1109736312;
					}
					else
					{
						num4 = -1574920075;
						num5 = -1574920075;
					}
					num = num4 ^ (int)(num2 * 167126640);
					continue;
				}
				case 4u:
					num = 2114718420;
					continue;
				case 3u:
					num = ((int)num2 * -262163596) ^ 0x17935704;
					continue;
				case 2u:
					Form3.smethod_17((Form3.smethod_12((Form)(object)this) as Form1).timer1);
					num = (int)((num2 * 674179461) ^ 0xD1CFD26);
					continue;
				case 1u:
					num3 = Form3.smethod_8((Control)(object)this) - 1;
					num = 651767495;
					continue;
				case 0u:
					num = ((int)num2 * -874656463) ^ 0x521FEE57;
					continue;
				default:
					return;
				case 7u:
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
		while (true)
		{
			int num = 770502857;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x699F6AA6u) % 3u)
				{
				case 1u:
					goto IL_000d;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_000d:
				num = ((int)num2 * -918572494) ^ -603695124;
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
		bool flag = default(bool);
		while (true)
		{
			int num = -1109542565;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0xAB4A4D2Fu) % 11u)
				{
				case 9u:
					num = ((int)num2 * -676574255) ^ -453781683;
					continue;
				case 8u:
					num5 = ((components != null) ? 1 : 0);
					goto IL_0021;
				case 7u:
					if (disposing)
					{
						num = (int)((num2 * 507517810) ^ 0x1FC671CE);
						continue;
					}
					num5 = 0;
					goto IL_0021;
				case 6u:
					Form3.smethod_18((IDisposable)components);
					num = ((int)num2 * -1222454103) ^ -1257964398;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1493168908;
						num4 = -1493168908;
					}
					else
					{
						num3 = -828940116;
						num4 = -828940116;
					}
					num = num3 ^ (int)(num2 * 1979541449);
					continue;
				}
				case 3u:
					num = (int)((num2 * 424872983) ^ 0x5D4C5FB6);
					continue;
				case 2u:
					((Form)this).Dispose(disposing);
					num = -395720802;
					continue;
				case 1u:
					num = (int)(num2 * 545520284) ^ -91237835;
					continue;
				case 0u:
					num = (int)(num2 * 1133860681) ^ -1605362361;
					continue;
				default:
					return;
				case 5u:
					break;
				case 10u:
					return;
					IL_0021:
					flag = (byte)num5 != 0;
					num = -1463544020;
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
			int num = 1233474390;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x56230F1Au) % 124u)
				{
				case 123u:
					Form3.smethod_35((Control)(object)button2, "Регистрация");
					num = (int)((num2 * 1538037943) ^ 0x29560EFD);
					continue;
				case 122u:
					num = ((int)num2 * -1864022291) ^ -917059030;
					continue;
				case 121u:
					Form3.smethod_25((Control)(object)this);
					num = (int)((num2 * 197593773) ^ 0x4DEAAF32);
					continue;
				case 120u:
					Form3.smethod_31((Control)(object)button1, "button1");
					num = (int)((num2 * 1543337629) ^ 0x3B040CC0);
					continue;
				case 119u:
					num = (int)(num2 * 1503263764) ^ -1109995700;
					continue;
				case 118u:
					Form3.smethod_52((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1887311216) ^ -1858206275;
					continue;
				case 117u:
					num = ((int)num2 * -747765643) ^ 0x1607323E;
					continue;
				case 116u:
					Form3.smethod_54((Form)(object)this, bool_0: true);
					num = (int)(num2 * 77371239) ^ -1619666940;
					continue;
				case 115u:
					num = (int)(num2 * 382945097) ^ -1583607523;
					continue;
				case 114u:
					Form3.smethod_31((Control)(object)button4, "button4");
					Form3.smethod_32((Control)(object)button4, new Size(140, 50));
					Form3.smethod_33((Control)(object)button4, 4);
					num = (int)(num2 * 132748462) ^ -148836241;
					continue;
				case 113u:
					Form3.smethod_36((Control)(object)button5, (EventHandler)Button5_Click);
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button7), 0);
					num = (int)(num2 * 430015756) ^ -29075256;
					continue;
				case 112u:
					num = ((int)num2 * -1183857869) ^ -270048414;
					continue;
				case 111u:
					Form3.smethod_42(errorProvider1, (ContainerControl)(object)this);
					Form3.smethod_43((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)((num2 * 918863897) ^ 0x24D1BA1E);
					continue;
				case 110u:
					num = ((int)num2 * -263014891) ^ -1529665875;
					continue;
				case 109u:
					Form3.smethod_29((ButtonBase)(object)NullButton, (FlatStyle)0);
					num = (int)(num2 * 1832904288) ^ -1237490156;
					continue;
				case 108u:
					num = ((int)num2 * -1141507666) ^ 0x1971C79A;
					continue;
				case 107u:
					num = ((int)num2 * -71528516) ^ 0x41183CD5;
					continue;
				case 106u:
					Form3.smethod_32((Control)(object)button1, new Size(49, 21));
					num = (int)((num2 * 130888291) ^ 0x80CA600);
					continue;
				case 105u:
					Form3.smethod_39((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = (int)(num2 * 1985764642) ^ -575698643;
					continue;
				case 104u:
					Form3.smethod_30((Control)(object)textBox2, new Point(174, 26));
					num = (int)((num2 * 1771193110) ^ 0x10C764F9);
					continue;
				case 103u:
					Form3.smethod_31((Control)(object)textBox2, "textBox2");
					Form3.smethod_32((Control)(object)textBox2, new Size(140, 20));
					num = ((int)num2 * -81682076) ^ 0x46ED28A;
					continue;
				case 102u:
					Form3.smethod_24((ISupportInitialize)errorProvider1);
					num = (int)(num2 * 1728569153) ^ -339638307;
					continue;
				case 101u:
					num = ((int)num2 * -1020792387) ^ 0x1C4A8715;
					continue;
				case 100u:
					num = ((int)num2 * -1209088596) ^ 0x3223FB6D;
					continue;
				case 99u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button4);
					num = (int)(num2 * 1264025548) ^ -68784985;
					continue;
				case 98u:
					num = ((int)num2 * -221844593) ^ -583594896;
					continue;
				case 97u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)label1);
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)NullButton);
					Form3.smethod_48((Form)(object)this, (FormBorderStyle)0);
					num = ((int)num2 * -35302530) ^ -2086186507;
					continue;
				case 96u:
					Form3.smethod_41(textBox2, bool_0: true);
					Form3.smethod_39((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = (int)(num2 * 616846451) ^ -764148339;
					continue;
				case 95u:
					Form3.smethod_29((ButtonBase)(object)button5, (FlatStyle)0);
					Form3.smethod_38((Control)(object)button5, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 1932858407) ^ 0x7499DDB8);
					continue;
				case 94u:
					num = (int)(num2 * 1071778822) ^ -2115516701;
					continue;
				case 93u:
					Form3.smethod_49((Form)(object)this, bool_0: false);
					num = (int)((num2 * 1697373133) ^ 0x1A0F21EA);
					continue;
				case 92u:
					Form3.smethod_31((Control)(object)button2, "button2");
					num = (int)(num2 * 647397503) ^ -523942816;
					continue;
				case 91u:
					Form3.smethod_30((Control)(object)button2, new Point(174, 49));
					num = (int)((num2 * 708366867) ^ 0x1B09E27);
					continue;
				case 90u:
					Form3.smethod_31((Control)(object)NullButton, "NullButton");
					num = (int)(num2 * 1094445074) ^ -1885975526;
					continue;
				case 89u:
					Form3.smethod_14((Control)(object)button5, bool_0: false);
					num = ((int)num2 * -2136342586) ^ 0x5A65232C;
					continue;
				case 88u:
					Form3.smethod_30((Control)(object)NullButton, new Point(-1, -1));
					num = (int)((num2 * 1396062912) ^ 0x46E8F20D);
					continue;
				case 86u:
					num = (int)((num2 * 794634153) ^ 0x13900CA0);
					continue;
				case 85u:
					Form3.smethod_33((Control)(object)button7, 6);
					num = ((int)num2 * -1095848557) ^ 0x3C30B474;
					continue;
				case 84u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -1822935364) ^ -231072641;
					continue;
				case 83u:
					Form3.smethod_30((Control)(object)label1, new Point(140, 70));
					num = ((int)num2 * -236274836) ^ 0x4026D525;
					continue;
				case 82u:
					Form3.smethod_34((ButtonBase)(object)button4, bool_0: true);
					num = ((int)num2 * -2096108555) ^ 0x42890CA6;
					continue;
				case 81u:
					num = (int)((num2 * 988558870) ^ 0x64017128);
					continue;
				case 80u:
					Form3.smethod_32((Control)(object)label1, new Size(207, 76));
					num = (int)((num2 * 577635355) ^ 0x73A2906A);
					continue;
				case 79u:
					button1 = Form3.smethod_20();
					num = ((int)num2 * -2081006435) ^ -728576570;
					continue;
				case 78u:
					num = ((int)num2 * -1328293319) ^ -2088544444;
					continue;
				case 77u:
					Form3.smethod_35((Control)(object)button4, "Начало игры");
					num = (int)((num2 * 1778094303) ^ 0x5316D5E3);
					continue;
				case 76u:
					Form3.smethod_26((Control)(object)this, Color.White);
					num = (int)(num2 * 1027673666) ^ -362199747;
					continue;
				case 75u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button4), 0);
					num = ((int)num2 * -864464141) ^ -1136188670;
					continue;
				case 74u:
					Form3.smethod_34((ButtonBase)(object)button2, bool_0: true);
					num = ((int)num2 * -726957134) ^ 0xFA717FA;
					continue;
				case 73u:
					button7 = Form3.smethod_20();
					textBox1 = Form3.smethod_21();
					label1 = Form3.smethod_22();
					num = ((int)num2 * -948968990) ^ 0x5984CD56;
					continue;
				case 72u:
					num = (int)((num2 * 1418734453) ^ 0x3DFCD8BF);
					continue;
				case 71u:
					num = (int)((num2 * 1219871642) ^ 0x5030D6);
					continue;
				case 70u:
					num = ((int)num2 * -3836455) ^ -478527791;
					continue;
				case 69u:
					Form3.smethod_51((Control)(object)this, "Form3");
					num = ((int)num2 * -2111756349) ^ 0x19B97167;
					continue;
				case 68u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button5), 0);
					num = ((int)num2 * -64474112) ^ 0x2AF99E6F;
					continue;
				case 67u:
					num = (int)(num2 * 712778112) ^ -194485470;
					continue;
				case 66u:
					Form3.smethod_57((Control)(object)this);
					num = ((int)num2 * -1168794006) ^ 0x1D1F8146;
					continue;
				case 65u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button7);
					num = ((int)num2 * -1336466821) ^ -233145013;
					continue;
				case 64u:
					Form3.smethod_35((Control)(object)button5, "Продолжить");
					Form3.smethod_34((ButtonBase)(object)button5, bool_0: true);
					num = (int)(num2 * 2021639684) ^ -393057737;
					continue;
				case 63u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox1);
					num = ((int)num2 * -1138651391) ^ -156250937;
					continue;
				case 62u:
					Form3.smethod_55((ISupportInitialize)errorProvider1);
					Form3.smethod_56((Control)(object)this, bool_0: false);
					num = (int)(num2 * 1999533458) ^ -164100012;
					continue;
				case 61u:
					num = (int)(num2 * 1132004566) ^ -526874277;
					continue;
				case 60u:
					button4 = Form3.smethod_20();
					button5 = Form3.smethod_20();
					num = (int)((num2 * 1247958730) ^ 0x2B38743F);
					continue;
				case 59u:
					Form3.smethod_30((Control)(object)button7, new Point(174, 243));
					num = (int)(num2 * 388933589) ^ -1086059314;
					continue;
				case 58u:
					Form3.smethod_36((Control)(object)button4, (EventHandler)Button4_Click);
					num = ((int)num2 * -1448228792) ^ 0x5189CC9B;
					continue;
				case 57u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button2);
					num = ((int)num2 * -1196697481) ^ 0x7D11117D;
					continue;
				case 56u:
					Form3.smethod_36((Control)(object)button7, (EventHandler)Button7_Click);
					num = (int)((num2 * 1121731812) ^ 0x3501D094);
					continue;
				case 55u:
					Form3.smethod_31((Control)(object)textBox1, "textBox1");
					Form3.smethod_32((Control)(object)textBox1, new Size(140, 20));
					num = ((int)num2 * -1234698531) ^ -634267389;
					continue;
				case 54u:
					Form3.smethod_32((Control)(object)button2, new Size(85, 21));
					Form3.smethod_33((Control)(object)button2, 1);
					num = (int)(num2 * 922939829) ^ -1254925069;
					continue;
				case 53u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button5);
					num = ((int)num2 * -636909056) ^ -400464759;
					continue;
				case 52u:
					Form3.smethod_32((Control)(object)NullButton, new Size(1, 1));
					num = ((int)num2 * -1338586316) ^ 0x5B5AE833;
					continue;
				case 51u:
					num = (int)(num2 * 475784561) ^ -1486018183;
					continue;
				case 50u:
					Form3.smethod_30((Control)(object)button4, new Point(174, 137));
					num = ((int)num2 * -1695012059) ^ 0x7A340F46;
					continue;
				case 49u:
					Form3.smethod_35((Control)(object)button1, "Вход");
					num = (int)((num2 * 1559417706) ^ 0x2D60054E);
					continue;
				case 48u:
					Form3.smethod_38((Control)(object)label1, Form3.smethod_37("Mistral", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 1072885450) ^ 0x5AB52113);
					continue;
				case 47u:
					button2 = Form3.smethod_20();
					num = ((int)num2 * -887541489) ^ -266088073;
					continue;
				case 46u:
					num = ((int)num2 * -349769468) ^ 0x54255BE1;
					continue;
				case 45u:
					num = (int)((num2 * 1345789740) ^ 0xA49EC1);
					continue;
				case 44u:
					Form3.smethod_45((Form)(object)this, new Size(486, 296));
					num = ((int)num2 * -822003584) ^ 0x4012CDD5;
					continue;
				case 43u:
					Form3.smethod_29((ButtonBase)(object)button7, (FlatStyle)0);
					num = ((int)num2 * -965195468) ^ -54072632;
					continue;
				case 42u:
					textBox2 = Form3.smethod_21();
					num = ((int)num2 * -1260082363) ^ -388048238;
					continue;
				case 41u:
					num = (int)(num2 * 1846326898) ^ -105967969;
					continue;
				case 40u:
					Form3.smethod_30((Control)(object)button1, new Point(265, 49));
					num = (int)(num2 * 799890775) ^ -742866338;
					continue;
				case 39u:
					Form3.smethod_34((ButtonBase)(object)button7, bool_0: true);
					num = (int)((num2 * 1771664207) ^ 0x40A3F6F7);
					continue;
				case 38u:
					num = ((int)num2 * -401300999) ^ 0x3B9C1A0E;
					continue;
				case 36u:
					Form3.smethod_33((Control)(object)button1, 0);
					num = ((int)num2 * -2145129731) ^ 0x7862AD93;
					continue;
				case 35u:
					Form3.smethod_31((Control)(object)label1, "label1");
					num = ((int)num2 * -1587547933) ^ 0x4135F834;
					continue;
				case 34u:
					Form3.smethod_38((Control)(object)button7, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -2064101704) ^ 0x1992AE6F;
					continue;
				case 33u:
					Form3.smethod_50((Form)(object)this, bool_0: false);
					num = ((int)num2 * -716246421) ^ -940835512;
					continue;
				case 32u:
					NullButton = Form3.smethod_20();
					num = (int)(num2 * 1418303372) ^ -1626669951;
					continue;
				case 31u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox2);
					num = ((int)num2 * -1509936886) ^ -814277349;
					continue;
				case 30u:
					Form3.smethod_35((Control)(object)label1, "QUARTO");
					num = (int)(num2 * 1887037593) ^ -1618762880;
					continue;
				case 29u:
					Form3.smethod_40((Control)(object)label1, bool_0: true);
					Form3.smethod_26((Control)(object)label1, Color.Transparent);
					num = (int)(num2 * 1408288945) ^ -509400005;
					continue;
				case 28u:
					components = Form3.smethod_19();
					num = (int)(num2 * 1033863849) ^ -921095030;
					continue;
				case 27u:
					num = (int)((num2 * 345621747) ^ 0x57CE5609);
					continue;
				case 26u:
					Form3.smethod_53((Form)(object)this, bool_0: false);
					num = (int)(num2 * 117610392) ^ -1033888262;
					continue;
				case 25u:
					Form3.smethod_26((Control)(object)NullButton, Color.Transparent);
					num = (int)((num2 * 842563882) ^ 0x597253E2);
					continue;
				case 24u:
					Form3.smethod_33((Control)(object)textBox1, 7);
					num = (int)(num2 * 1052105808) ^ -1558656241;
					continue;
				case 23u:
					Form3.smethod_31((Control)(object)button5, "button5");
					Form3.smethod_32((Control)(object)button5, new Size(140, 50));
					num = ((int)num2 * -342395715) ^ 0x31EFE56A;
					continue;
				case 22u:
					Form3.smethod_35((Control)(object)button7, "Достижения");
					num = (int)((num2 * 1033500159) ^ 0x62C46447);
					continue;
				case 21u:
					Form3.smethod_33((Control)(object)NullButton, 3);
					num = ((int)num2 * -1670201622) ^ -320428690;
					continue;
				case 20u:
					Form3.smethod_38((Control)(object)button4, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 1904532265) ^ 0x467B4D9C);
					continue;
				case 19u:
					num = ((int)num2 * -1263985243) ^ 0x62CF0420;
					continue;
				case 18u:
					Form3.smethod_34((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -1827712571) ^ 0x3AA33C55;
					continue;
				case 17u:
					Form3.smethod_44((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -1816141962) ^ -1823391192;
					continue;
				case 16u:
					num = ((int)num2 * -520937036) ^ -1015162318;
					continue;
				case 15u:
					num = (int)((num2 * 1731660191) ^ 0x50E928EC);
					continue;
				case 14u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)NullButton), 0);
					num = (int)(num2 * 226169949) ^ -459728411;
					continue;
				case 13u:
					Form3.smethod_29((ButtonBase)(object)button4, (FlatStyle)0);
					num = ((int)num2 * -934267177) ^ 0xD1D6E40;
					continue;
				case 12u:
					Form3.smethod_33((Control)(object)textBox2, 8);
					num = ((int)num2 * -1918808253) ^ -617146734;
					continue;
				case 11u:
					Form3.smethod_33((Control)(object)label1, 7);
					num = ((int)num2 * -1646379703) ^ 0xDC5D6D3;
					continue;
				case 10u:
					Form3.smethod_31((Control)(object)button7, "button7");
					Form3.smethod_32((Control)(object)button7, new Size(140, 50));
					num = (int)(num2 * 2030324144) ^ -1416715342;
					continue;
				case 9u:
					Form3.smethod_14((Control)(object)button4, bool_0: false);
					num = ((int)num2 * -1684453251) ^ 0x2CE5904C;
					continue;
				case 8u:
					Form3.smethod_36((Control)(object)button2, (EventHandler)Button2_Click);
					num = ((int)num2 * -238982566) ^ -678655629;
					continue;
				case 7u:
					Form3.smethod_33((Control)(object)button5, 5);
					num = (int)(num2 * 639579771) ^ -1574167597;
					continue;
				case 6u:
					errorProvider1 = Form3.smethod_23(components);
					num = (int)(num2 * 1333650208) ^ -1016096700;
					continue;
				case 5u:
					Form3.smethod_36((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -460407187) ^ 0x584B8B78;
					continue;
				case 4u:
					num = ((int)num2 * -1410284583) ^ 0xCA62DA9;
					continue;
				case 3u:
					num = ((int)num2 * -918046934) ^ 0x136C89A;
					continue;
				case 2u:
					Form3.smethod_30((Control)(object)button5, new Point(174, 190));
					num = ((int)num2 * -371210564) ^ -1708267611;
					continue;
				case 1u:
					Form3.smethod_34((ButtonBase)(object)NullButton, bool_0: false);
					num = ((int)num2 * -553231779) ^ -181435604;
					continue;
				case 0u:
					Form3.smethod_30((Control)(object)textBox1, new Point(174, 2));
					num = ((int)num2 * -1325227864) ^ 0x38DC2B09;
					continue;
				default:
					return;
				case 37u:
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
