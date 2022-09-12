using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Cytotechnologist;

public class Form2 : Form
{
	private Random rnd = Form2.smethod_0();

	private bool flag = true;

	private IContainer components = null;

	private Label label1;

	private Label label2;

	private TextBox textBox1;

	private Button button1;

	private Label label3;

	public Form2()
	{
		while (true)
		{
			int num = 691255652;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2CF6A1E3u) % 5u)
				{
				case 3u:
					InitializeComponent();
					Form2.smethod_1((Control)(object)label1, "Введите любое число от 0 до 9 включительно.\nВаш соперник уже загадал число (N) из этого\nже диапазона. Если сумма ваших чисел будет\nчетным числом, то первым ход делаете Вы,\nиначе - ваш соперник Компьютер!");
					num = (int)(num2 * 615897439) ^ -1761372251;
					continue;
				case 1u:
					num = (int)(num2 * 205949826) ^ -1713909929;
					continue;
				case 0u:
					num = (int)(num2 * 1465385004) ^ -1668502535;
					continue;
				default:
					return;
				case 4u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	private void Form2_FormClosed(object sender, FormClosedEventArgs e)
	{
		Form2.smethod_3((Control)(object)Form2.smethod_2((Form)(object)this), bool_0: true);
	}

	private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = 2045097143;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x26323917u) % 10u)
				{
				case 9u:
					Form2.smethod_5(e, bool_0: true);
					num = ((int)num2 * -1156720073) ^ -780510335;
					continue;
				case 8u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 162060393;
						num5 = 162060393;
					}
					else
					{
						num4 = 216527088;
						num5 = 216527088;
					}
					num = num4 ^ ((int)num2 * -1225331053);
					continue;
				}
				case 6u:
					flag = !char.IsDigit(Form2.smethod_4(e));
					num = (int)((num2 * 1121084629) ^ 0x76A29A49);
					continue;
				case 5u:
					num = (int)((num2 * 278738550) ^ 0x52C610B4);
					continue;
				case 4u:
					Form2.smethod_1((Control)(object)textBox1, "");
					num = 727002954;
					continue;
				case 3u:
					Button1_Click(this, Form2.smethod_6());
					num = ((int)num2 * -1198837114) ^ 0x31E0105B;
					continue;
				case 2u:
					num = (int)(num2 * 1409706704) ^ -1219149548;
					continue;
				case 1u:
				{
					int num3;
					if (Form2.smethod_4(e) != '\r')
					{
						num = 1910513012;
						num3 = 1910513012;
					}
					else
					{
						num = 212579572;
						num3 = 212579572;
					}
					continue;
				}
				default:
					return;
				case 0u:
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
		int num7 = default(int);
		int num8 = default(int);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -805652116;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFF05629Au) % 34u)
				{
				case 33u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = true;
					num = (int)(num2 * 504537280) ^ -101513838;
					continue;
				case 32u:
					num7 = int.Parse(Form2.smethod_7((Control)(object)textBox1));
					num8 = Form2.smethod_9(rnd, 10);
					num = ((int)num2 * -1900834404) ^ 0x60059C9;
					continue;
				case 31u:
					num = ((int)num2 * -1870514618) ^ -1309790621;
					continue;
				case 30u:
					Form2.smethod_1((Control)(object)label3, "Поздравляем! Ваш ход первый.");
					num = (int)((num2 * 693122485) ^ 0x7A866D3);
					continue;
				case 29u:
					Form2.smethod_1((Control)(object)label2, Form2.smethod_10("+", num8.ToString(), "=", (num7 + num8).ToString()));
					num = ((int)num2 * -1324571224) ^ -2023113491;
					continue;
				case 27u:
					num = (int)((num2 * 93585853) ^ 0x1FAF87C6);
					continue;
				case 26u:
					Form2.smethod_14(Form2.smethod_11(Form2.smethod_2((Form)(object)this)));
					num = ((int)num2 * -167787783) ^ 0x59D66C84;
					continue;
				case 25u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = -2116780030;
						num6 = -2116780030;
					}
					else
					{
						num5 = -990770898;
						num6 = -990770898;
					}
					num = num5 ^ ((int)num2 * -1521936607);
					continue;
				}
				case 24u:
					(Form2.smethod_2((Form)(object)this) as Form3).Button_Continue();
					num = ((int)num2 * -1764706532) ^ -453974976;
					continue;
				case 23u:
					num = -256140271;
					continue;
				case 22u:
					num = -1811435662;
					continue;
				case 21u:
					flag2 = (num7 + num8) % 2 == 0;
					num = (int)((num2 * 2131176205) ^ 0x70BEE7EA);
					continue;
				case 20u:
					flag3 = Form2.smethod_8(Form2.smethod_7((Control)(object)textBox1), "");
					num = ((int)num2 * -960070285) ^ -910407141;
					continue;
				case 19u:
					num = ((int)num2 * -674346229) ^ 0xB6FD300;
					continue;
				case 18u:
				{
					Form control_ = Form2.smethod_2((Form)(object)this);
					int num13 = Form2.smethod_12((Control)(object)control_) - 1;
					Form2.smethod_13((Control)(object)control_, num13);
					flag = num13 > 1;
					num = -918121307;
					continue;
				}
				case 17u:
				{
					int num11;
					int num12;
					if (this.flag)
					{
						num11 = -525719103;
						num12 = -525719103;
					}
					else
					{
						num11 = -621401225;
						num12 = -621401225;
					}
					num = num11 ^ ((int)num2 * -794756817);
					continue;
				}
				case 16u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = false;
					num = ((int)num2 * -1297143274) ^ -2063688115;
					continue;
				case 15u:
					num = (int)(num2 * 184386888) ^ -1555200536;
					continue;
				case 14u:
					num = ((int)num2 * -754716256) ^ -645888345;
					continue;
				case 13u:
					num = (int)((num2 * 270173941) ^ 0x5F164E7);
					continue;
				case 12u:
					num = ((int)num2 * -1065817834) ^ 0xCF9E8C8;
					continue;
				case 11u:
				{
					int num9;
					int num10;
					if (!flag3)
					{
						num9 = 1126270659;
						num10 = 1126270659;
					}
					else
					{
						num9 = 2029176222;
						num10 = 2029176222;
					}
					num = num9 ^ (int)(num2 * 113892017);
					continue;
				}
				case 10u:
					num = -527816390;
					continue;
				case 9u:
					num = -2114239536;
					continue;
				case 7u:
					Form2.smethod_15((Form)(object)this);
					num = ((int)num2 * -938209259) ^ 0x7DDC3FCC;
					continue;
				case 6u:
					num = (int)(num2 * 1726864972) ^ -1179091373;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -2135060688;
						num4 = -2135060688;
					}
					else
					{
						num3 = -1318066226;
						num4 = -1318066226;
					}
					num = num3 ^ ((int)num2 * -2102607650);
					continue;
				}
				case 4u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).StartGame();
					num = (int)(num2 * 2140578625) ^ -1204421562;
					continue;
				case 3u:
					Form2.smethod_1((Control)(object)label3, "Первым ход делает Компьютер.");
					num = ((int)num2 * -1326615324) ^ 0x4BA6EF64;
					continue;
				case 2u:
					num = ((int)num2 * -1457340499) ^ 0x9DF14F2;
					continue;
				case 1u:
					num = (int)((num2 * 1186384068) ^ 0x7CF0F37E);
					continue;
				case 0u:
					this.flag = false;
					num = -1565263641;
					continue;
				default:
					return;
				case 8u:
					break;
				case 28u:
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
			int num = -1627988109;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xC352F0D9u) % 10u)
				{
				case 9u:
					num = (int)((num2 * 685806600) ^ 0x191D607);
					continue;
				case 8u:
					num = (int)(num2 * 1506856578) ^ -435367729;
					continue;
				case 7u:
					Form2.smethod_16((IDisposable)components);
					num = ((int)num2 * -1615306863) ^ -409830597;
					continue;
				case 6u:
					((Form)this).Dispose(disposing);
					num = -115124593;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1407587965;
						num5 = 1407587965;
					}
					else
					{
						num4 = 1058212130;
						num5 = 1058212130;
					}
					num = num4 ^ ((int)num2 * -1045217521);
					continue;
				}
				case 4u:
					if (disposing)
					{
						num = (int)((num2 * 867196164) ^ 0x356A3448);
						continue;
					}
					num3 = 0;
					goto IL_0089;
				case 3u:
					num = (int)((num2 * 1823112303) ^ 0x58B9C6A3);
					continue;
				case 1u:
					num3 = ((components != null) ? 1 : 0);
					goto IL_0089;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
					IL_0089:
					flag = (byte)num3 != 0;
					num = -1673750902;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_0411: Expected O, but got Unknown
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Expected O, but got Unknown
		while (true)
		{
			int num = -192539378;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF54A4A3Cu) % 66u)
				{
				case 65u:
					Form2.smethod_22((Control)(object)textBox1, new Point(24, 86));
					num = ((int)num2 * -1043597549) ^ 0x35A87272;
					continue;
				case 64u:
					num = ((int)num2 * -1597571870) ^ -982755360;
					continue;
				case 63u:
					Form2.smethod_39((Control)(object)this, "Form2");
					num = ((int)num2 * -425698928) ^ -91366922;
					continue;
				case 62u:
					Form2.smethod_33((Form)(object)this, new Size(255, 224));
					num = ((int)num2 * -1191085223) ^ 0x58D35DF8;
					continue;
				case 61u:
					Form2.smethod_21((Control)(object)label2, bool_0: true);
					num = ((int)num2 * -1558689238) ^ 0x2FB924BA;
					continue;
				case 60u:
					Form2.smethod_23((Control)(object)button1, "button1");
					num = (int)(num2 * 167267735) ^ -1475057386;
					continue;
				case 59u:
					Form2.smethod_23((Control)(object)textBox1, "textBox1");
					num = (int)(num2 * 1248373743) ^ -141403665;
					continue;
				case 58u:
					Form2.smethod_24((Control)(object)label1, new Size(35, 13));
					Form2.smethod_25((Control)(object)label1, 0);
					Form2.smethod_1((Control)(object)label1, "label1");
					num = ((int)num2 * -2111696926) ^ 0x3D930C5B;
					continue;
				case 57u:
					num = ((int)num2 * -1289611150) ^ 0x624E052F;
					continue;
				case 56u:
					Form2.smethod_24((Control)(object)label2, new Size(188, 73));
					num = (int)(num2 * 608151417) ^ -1955368930;
					continue;
				case 55u:
					Form2.smethod_27((Control)(object)textBox1, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -223916184) ^ 0x2C4298C6;
					continue;
				case 54u:
					Form2.smethod_25((Control)(object)label3, 4);
					num = ((int)num2 * -571454946) ^ -76358129;
					continue;
				case 53u:
					Form2.smethod_22((Control)(object)label2, new Point(53, 89));
					num = ((int)num2 * -1017428290) ^ -446521271;
					continue;
				case 52u:
					num = ((int)num2 * -358182991) ^ 0x2BB964B1;
					continue;
				case 51u:
					num = ((int)num2 * -752173552) ^ -439805431;
					continue;
				case 50u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -438375930) ^ -1032808942;
					continue;
				case 49u:
					num = ((int)num2 * -569636548) ^ 0x56C4ABE4;
					continue;
				case 48u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label3);
					num = (int)(num2 * 426521801) ^ -229922274;
					continue;
				case 47u:
					Form2.smethod_1((Control)(object)label2, "+N=?");
					Form2.smethod_22((Control)(object)button1, new Point(86, 193));
					num = ((int)num2 * -1350643503) ^ -381754116;
					continue;
				case 46u:
					Form2.smethod_42((Control)(object)this, bool_0: false);
					num = (int)(num2 * 705717527) ^ -1700870311;
					continue;
				case 45u:
					Form2.smethod_25((Control)(object)label2, 2);
					num = (int)((num2 * 1083630464) ^ 0x390E8F73);
					continue;
				case 44u:
					Form2.smethod_32((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -1214215926) ^ -1951252972;
					continue;
				case 43u:
					Form2.smethod_21((Control)(object)label3, bool_0: true);
					num = ((int)num2 * -1781893103) ^ -1478328115;
					continue;
				case 42u:
					num = (int)(num2 * 601094164) ^ -791292509;
					continue;
				case 41u:
					num = ((int)num2 * -1351421943) ^ -312929269;
					continue;
				case 40u:
					num = (int)((num2 * 259577061) ^ 0x58B9F675);
					continue;
				case 39u:
					Form2.smethod_38((Form)(object)this, bool_0: false);
					num = (int)((num2 * 1477719489) ^ 0x3A7530C9);
					continue;
				case 38u:
					Form2.smethod_21((Control)(object)label1, bool_0: true);
					num = (int)(num2 * 233762741) ^ -789193400;
					continue;
				case 37u:
					num = ((int)num2 * -683847838) ^ -1680242939;
					continue;
				case 36u:
					num = (int)((num2 * 288349613) ^ 0x467E2A2D);
					continue;
				case 35u:
					Form2.smethod_23((Control)(object)label2, "label2");
					num = (int)((num2 * 140656737) ^ 0x18B6601);
					continue;
				case 34u:
					label2 = Form2.smethod_17();
					button1 = Form2.smethod_19();
					label3 = Form2.smethod_17();
					num = ((int)num2 * -215661123) ^ -957561382;
					continue;
				case 33u:
					Form2.smethod_25((Control)(object)textBox1, 1);
					num = (int)(num2 * 701605323) ^ -915039015;
					continue;
				case 32u:
					Form2.smethod_41((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
					num = (int)(num2 * 395931761) ^ -2003661206;
					continue;
				case 31u:
					Form2.smethod_28((Control)(object)textBox1, new KeyPressEventHandler(TextBox1_KeyPress));
					num = (int)((num2 * 757690647) ^ 0x4E84217E);
					continue;
				case 30u:
					num = (int)((num2 * 72683882) ^ 0x61FC294A);
					continue;
				case 29u:
					Form2.smethod_23((Control)(object)label3, "label3");
					num = ((int)num2 * -716055357) ^ 0x74A7095E;
					continue;
				case 28u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)textBox1);
					num = (int)(num2 * 1519931867) ^ -677408770;
					continue;
				case 27u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label1);
					Form2.smethod_36((Form)(object)this, (FormBorderStyle)1);
					Form2.smethod_37((Form)(object)this, bool_0: false);
					num = ((int)num2 * -26738400) ^ 0x59992109;
					continue;
				case 26u:
					num = ((int)num2 * -1107487128) ^ 0x21AF5B33;
					continue;
				case 25u:
					Form2.smethod_23((Control)(object)label1, "label1");
					num = ((int)num2 * -2124463148) ^ -1150418224;
					continue;
				case 24u:
					Form2.smethod_40((Form)(object)this, bool_0: false);
					Form2.smethod_1((Control)(object)this, "Жеребьёвка");
					num = ((int)num2 * -477018791) ^ -1809339552;
					continue;
				case 23u:
					num = (int)(num2 * 242417568) ^ -20933082;
					continue;
				case 22u:
					num = (int)(num2 * 350826900) ^ -1875710515;
					continue;
				case 21u:
					Form2.smethod_1((Control)(object)button1, "OK");
					num = ((int)num2 * -1186412919) ^ -1077928986;
					continue;
				case 20u:
					label1 = Form2.smethod_17();
					textBox1 = Form2.smethod_18();
					num = ((int)num2 * -1555014103) ^ 0xAC99FF4;
					continue;
				case 19u:
					Form2.smethod_27((Control)(object)label2, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 589686051) ^ -324668466;
					continue;
				case 18u:
					Form2.smethod_20((Control)(object)this);
					num = (int)((num2 * 434062929) ^ 0x2BF05D10);
					continue;
				case 17u:
					num = (int)(num2 * 1810074913) ^ -1632090006;
					continue;
				case 16u:
					num = (int)(num2 * 454611067) ^ -225732639;
					continue;
				case 15u:
					Form2.smethod_22((Control)(object)label1, new Point(10, 10));
					num = (int)(num2 * 1040652966) ^ -458868897;
					continue;
				case 14u:
					num = ((int)num2 * -549385014) ^ -1339193349;
					continue;
				case 13u:
					Form2.smethod_29((ButtonBase)(object)button1, bool_0: true);
					Form2.smethod_30((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)((num2 * 2135479826) ^ 0xE0F35B1);
					continue;
				case 12u:
					Form2.smethod_31((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)(num2 * 1481516292) ^ -1841858524;
					continue;
				case 10u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label2);
					num = (int)((num2 * 380645331) ^ 0x6B0C007F);
					continue;
				case 9u:
					Form2.smethod_25((Control)(object)button1, 3);
					num = (int)((num2 * 1476914092) ^ 0x18B7CF8E);
					continue;
				case 8u:
					Form2.smethod_43((Control)(object)this);
					num = (int)((num2 * 859306410) ^ 0x1179E202);
					continue;
				case 7u:
					Form2.smethod_24((Control)(object)textBox1, new Size(42, 80));
					num = ((int)num2 * -2029292871) ^ 0x14457B7A;
					continue;
				case 6u:
					Form2.smethod_24((Control)(object)button1, new Size(73, 23));
					num = (int)(num2 * 338541247) ^ -2055757669;
					continue;
				case 4u:
					num = ((int)num2 * -1861788605) ^ -4611577;
					continue;
				case 3u:
					Form2.smethod_22((Control)(object)label3, new Point(47, 177));
					num = ((int)num2 * -2128847785) ^ 0x435CACF6;
					continue;
				case 2u:
					num = ((int)num2 * -865310845) ^ 0x3E1D3BEA;
					continue;
				case 1u:
					Form2.smethod_24((Control)(object)label3, new Size(0, 13));
					num = ((int)num2 * -745695094) ^ -403239122;
					continue;
				case 0u:
					num = ((int)num2 * -1431797213) ^ 0x512CFC17;
					continue;
				default:
					return;
				case 5u:
					break;
				case 11u:
					return;
				}
				break;
			}
		}
	}

	static Random smethod_0()
	{
		return new Random();
	}

	static void smethod_1(Control control_0, string string_0)
	{
		control_0.set_Text(string_0);
	}

	static Form smethod_2(Form form_0)
	{
		return form_0.get_Owner();
	}

	static void smethod_3(Control control_0, bool bool_0)
	{
		control_0.set_Enabled(bool_0);
	}

	static char smethod_4(KeyPressEventArgs keyPressEventArgs_0)
	{
		return keyPressEventArgs_0.get_KeyChar();
	}

	static void smethod_5(KeyPressEventArgs keyPressEventArgs_0, bool bool_0)
	{
		keyPressEventArgs_0.set_Handled(bool_0);
	}

	static EventArgs smethod_6()
	{
		return new EventArgs();
	}

	static string smethod_7(Control control_0)
	{
		return control_0.get_Text();
	}

	static bool smethod_8(string string_0, string string_1)
	{
		return string_0 != string_1;
	}

	static int smethod_9(Random random_0, int int_0)
	{
		return random_0.Next(int_0);
	}

	static string smethod_10(string string_0, string string_1, string string_2, string string_3)
	{
		return string_0 + string_1 + string_2 + string_3;
	}

	static Form smethod_11(Form form_0)
	{
		return form_0.get_Owner();
	}

	static int smethod_12(Control control_0)
	{
		return control_0.get_Height();
	}

	static void smethod_13(Control control_0, int int_0)
	{
		control_0.set_Height(int_0);
	}

	static void smethod_14(Form form_0)
	{
		form_0.Activate();
	}

	static void smethod_15(Form form_0)
	{
		form_0.Close();
	}

	static void smethod_16(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Label smethod_17()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Label();
	}

	static TextBox smethod_18()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TextBox();
	}

	static Button smethod_19()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
	}

	static void smethod_20(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_21(Control control_0, bool bool_0)
	{
		control_0.set_AutoSize(bool_0);
	}

	static void smethod_22(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_23(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_24(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_25(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static Font smethod_26(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_27(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_28(Control control_0, KeyPressEventHandler keyPressEventHandler_0)
	{
		control_0.add_KeyPress(keyPressEventHandler_0);
	}

	static void smethod_29(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_UseVisualStyleBackColor(bool_0);
	}

	static void smethod_30(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static void smethod_31(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_32(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_33(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static ControlCollection smethod_34(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_35(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_36(Form form_0, FormBorderStyle formBorderStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_FormBorderStyle(formBorderStyle_0);
	}

	static void smethod_37(Form form_0, bool bool_0)
	{
		form_0.set_MaximizeBox(bool_0);
	}

	static void smethod_38(Form form_0, bool bool_0)
	{
		form_0.set_MinimizeBox(bool_0);
	}

	static void smethod_39(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_40(Form form_0, bool bool_0)
	{
		form_0.set_ShowIcon(bool_0);
	}

	static void smethod_41(Form form_0, FormClosedEventHandler formClosedEventHandler_0)
	{
		form_0.add_FormClosed(formClosedEventHandler_0);
	}

	static void smethod_42(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_43(Control control_0)
	{
		control_0.PerformLayout();
	}
}
