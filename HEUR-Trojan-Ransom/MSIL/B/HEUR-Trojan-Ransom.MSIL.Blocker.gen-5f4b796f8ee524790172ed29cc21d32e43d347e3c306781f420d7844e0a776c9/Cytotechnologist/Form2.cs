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
			int num = 615434416;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6666DC07u) % 6u)
				{
				case 5u:
					Form2.smethod_1((Control)(object)label1, "Введите любое число от 0 до 9 включительно.\nВаш соперник уже загадал число (N) из этого\nже диапазона. Если сумма ваших чисел будет\nчетным числом, то первым ход делаете Вы,\nиначе - ваш соперник Компьютер!");
					num = ((int)num2 * -607544356) ^ 0x3CEDB775;
					continue;
				case 2u:
					num = ((int)num2 * -996664126) ^ -191311520;
					continue;
				case 1u:
					InitializeComponent();
					num = (int)(num2 * 342110641) ^ -1649953444;
					continue;
				case 0u:
					num = ((int)num2 * -750783086) ^ 0x4BA7699;
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

	private void Form2_FormClosed(object sender, FormClosedEventArgs e)
	{
		Form2.smethod_3((Control)(object)Form2.smethod_2((Form)(object)this), bool_0: true);
	}

	private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -1408205811;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCEE4B2F0u) % 11u)
				{
				case 10u:
					Button1_Click(this, Form2.smethod_6());
					num = ((int)num2 * -1918321289) ^ -1302731520;
					continue;
				case 9u:
					Form2.smethod_5(e, bool_0: true);
					num = (int)(num2 * 234815568) ^ -1752332280;
					continue;
				case 8u:
				{
					int num5;
					if (Form2.smethod_4(e) == '\r')
					{
						num = -1974428036;
						num5 = -1974428036;
					}
					else
					{
						num = -1308384081;
						num5 = -1308384081;
					}
					continue;
				}
				case 6u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -550100271;
						num4 = -550100271;
					}
					else
					{
						num3 = -890220505;
						num4 = -890220505;
					}
					num = num3 ^ ((int)num2 * -1925420615);
					continue;
				}
				case 5u:
					Form2.smethod_1((Control)(object)textBox1, "");
					num = -470481672;
					continue;
				case 4u:
					flag = !char.IsDigit(Form2.smethod_4(e));
					num = ((int)num2 * -1841230386) ^ 0x2E81DBE5;
					continue;
				case 3u:
					num = ((int)num2 * -733365800) ^ -1450102577;
					continue;
				case 2u:
					num = ((int)num2 * -205292364) ^ -1297236603;
					continue;
				case 1u:
					num = ((int)num2 * -886286592) ^ -696277000;
					continue;
				default:
					return;
				case 7u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		bool flag = Form2.smethod_8(Form2.smethod_7((Control)(object)textBox1), "");
		int num5 = default(int);
		int num10 = default(int);
		int num11 = default(int);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 948611368;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x25A2E6EEu) % 32u)
				{
				case 31u:
					num = (int)(num2 * 1380403627) ^ -1713080473;
					continue;
				case 29u:
					num = ((int)num2 * -1851459435) ^ -741484876;
					continue;
				case 28u:
				{
					Form control_ = Form2.smethod_2((Form)(object)this);
					num5 = Form2.smethod_12((Control)(object)control_) - 1;
					Form2.smethod_13((Control)(object)control_, num5);
					num = 1010031641;
					continue;
				}
				case 27u:
					this.flag = false;
					num = 1141511085;
					continue;
				case 26u:
					num = (int)(num2 * 2134503462) ^ -1171600791;
					continue;
				case 25u:
					num10 = int.Parse(Form2.smethod_7((Control)(object)textBox1));
					num11 = Form2.smethod_9(rnd, 10);
					num = (int)((num2 * 730362283) ^ 0x71AA9C53);
					continue;
				case 24u:
					num = (int)(num2 * 451789543) ^ -607366646;
					continue;
				case 23u:
					num = ((int)num2 * -428966283) ^ 0x2FBA674A;
					continue;
				case 22u:
					num = (int)(num2 * 382425217) ^ -944694235;
					continue;
				case 21u:
					num = 1354818275;
					continue;
				case 20u:
				{
					int num12;
					int num13;
					if (!flag3)
					{
						num12 = -1627556301;
						num13 = -1627556301;
					}
					else
					{
						num12 = -175803376;
						num13 = -175803376;
					}
					num = num12 ^ (int)(num2 * 1915283271);
					continue;
				}
				case 19u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).StartGame();
					num = ((int)num2 * -2057573154) ^ 0x32E9972C;
					continue;
				case 18u:
					Form2.smethod_1((Control)(object)label3, "Поздравляем! Ваш ход первый.");
					num = ((int)num2 * -34516388) ^ 0x75F88293;
					continue;
				case 17u:
					Form2.smethod_1((Control)(object)label3, "Первым ход делает Компьютер.");
					num = 486473054;
					continue;
				case 16u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = false;
					num = ((int)num2 * -787865122) ^ 0x8B11694;
					continue;
				case 15u:
					num = ((int)num2 * -304210546) ^ 0x6DDB5134;
					continue;
				case 14u:
				{
					Label control_2 = label2;
					string string_ = num11.ToString();
					num5 = num10 + num11;
					Form2.smethod_1((Control)(object)control_2, Form2.smethod_10("+", string_, "=", num5.ToString()));
					num = (int)(num2 * 1028656167) ^ -1261791961;
					continue;
				}
				case 12u:
					Form2.smethod_15((Form)(object)this);
					num = ((int)num2 * -2139227927) ^ 0x3F7D01F7;
					continue;
				case 11u:
					num = ((int)num2 * -1833325831) ^ -1689382284;
					continue;
				case 10u:
					num = 1968591377;
					continue;
				case 9u:
					flag3 = (num10 + num11) % 2 == 0;
					num = ((int)num2 * -1332148104) ^ -539277438;
					continue;
				case 8u:
					flag2 = this.flag;
					num = (int)(num2 * 746634323) ^ -1934870734;
					continue;
				case 7u:
				{
					int num8;
					int num9;
					if (num5 > 1)
					{
						num8 = 427189235;
						num9 = 427189235;
					}
					else
					{
						num8 = 161109009;
						num9 = 161109009;
					}
					num = num8 ^ (int)(num2 * 1699222267);
					continue;
				}
				case 6u:
				{
					int num6;
					int num7;
					if (!flag)
					{
						num6 = 1577588845;
						num7 = 1577588845;
					}
					else
					{
						num6 = 1381108047;
						num7 = 1381108047;
					}
					num = num6 ^ ((int)num2 * -1101665715);
					continue;
				}
				case 5u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = true;
					num = (int)((num2 * 328406455) ^ 0x29FAD70B);
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (flag2)
					{
						num3 = -1161006105;
						num4 = -1161006105;
					}
					else
					{
						num3 = -957245460;
						num4 = -957245460;
					}
					num = num3 ^ ((int)num2 * -94999870);
					continue;
				}
				case 3u:
					num = ((int)num2 * -891506806) ^ -1060220315;
					continue;
				case 2u:
					(Form2.smethod_2((Form)(object)this) as Form3).Button_Continue();
					Form2.smethod_14(Form2.smethod_11(Form2.smethod_2((Form)(object)this)));
					num = ((int)num2 * -1284515169) ^ 0x15F92343;
					continue;
				case 1u:
					num = ((int)num2 * -2033685949) ^ -826317580;
					continue;
				case 0u:
					num = 573499954;
					continue;
				default:
					return;
				case 30u:
					break;
				case 13u:
					return;
				}
				break;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			goto IL_0082;
		}
		int num = 0;
		goto IL_00c6;
		IL_00c6:
		bool flag = (byte)num != 0;
		int num2 = 1288323288;
		goto IL_0087;
		IL_0082:
		num2 = 722224286;
		goto IL_0087;
		IL_0087:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x53010413u) % 9u)
			{
			case 8u:
				num2 = ((int)num3 * -140038965) ^ 0xC131397;
				continue;
			case 6u:
				((Form)this).Dispose(disposing);
				num2 = 758783206;
				continue;
			case 4u:
				Form2.smethod_16((IDisposable)components);
				num2 = (int)(num3 * 1151096148) ^ -1373673284;
				continue;
			case 3u:
				num2 = ((int)num3 * -1694556420) ^ -528805939;
				continue;
			case 2u:
				num2 = (int)(num3 * 372114068) ^ -989777092;
				continue;
			case 1u:
			{
				int num4;
				int num5;
				if (!flag)
				{
					num4 = 907696841;
					num5 = 907696841;
				}
				else
				{
					num4 = 1805701687;
					num5 = 1805701687;
				}
				num2 = num4 ^ (int)(num3 * 913605072);
				continue;
			}
			case 0u:
				break;
			default:
				return;
			case 5u:
				goto IL_00bd;
			case 7u:
				return;
			}
			break;
		}
		goto IL_0082;
		IL_00bd:
		num = ((components != null) ? 1 : 0);
		goto IL_00c6;
	}

	private void InitializeComponent()
	{
		//IL_05ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b5: Expected O, but got Unknown
		//IL_0721: Unknown result type (might be due to invalid IL or missing references)
		//IL_072b: Expected O, but got Unknown
		label1 = Form2.smethod_17();
		while (true)
		{
			int num = -1382901766;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x92DB5CE7u) % 63u)
				{
				case 62u:
					Form2.smethod_29((ButtonBase)(object)button1, bool_0: true);
					num = (int)((num2 * 29603334) ^ 0x828FEC0);
					continue;
				case 61u:
					Form2.smethod_1((Control)(object)label2, "+N=?");
					num = ((int)num2 * -296620617) ^ -1450354426;
					continue;
				case 60u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label3);
					num = ((int)num2 * -1180055221) ^ -26291057;
					continue;
				case 58u:
					Form2.smethod_32((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -1982728782) ^ -210870228;
					continue;
				case 57u:
					Form2.smethod_40((Form)(object)this, bool_0: false);
					Form2.smethod_1((Control)(object)this, "Жеребьёвка");
					num = (int)((num2 * 73968801) ^ 0x1BB35C4E);
					continue;
				case 56u:
					textBox1 = Form2.smethod_18();
					label2 = Form2.smethod_17();
					button1 = Form2.smethod_19();
					label3 = Form2.smethod_17();
					num = (int)((num2 * 2070200401) ^ 0x4D547292);
					continue;
				case 55u:
					num = ((int)num2 * -1782516447) ^ 0x29EED7AB;
					continue;
				case 54u:
					num = ((int)num2 * -1806787287) ^ 0x392E0547;
					continue;
				case 53u:
					num = ((int)num2 * -1036295976) ^ -620388501;
					continue;
				case 52u:
					num = ((int)num2 * -1730498616) ^ -1254039630;
					continue;
				case 51u:
					Form2.smethod_37((Form)(object)this, bool_0: false);
					num = ((int)num2 * -296246867) ^ 0x34618680;
					continue;
				case 50u:
					num = ((int)num2 * -856253339) ^ 0x558F7B08;
					continue;
				case 49u:
					num = (int)(num2 * 592803005) ^ -1086837448;
					continue;
				case 48u:
					Form2.smethod_23((Control)(object)label2, "label2");
					num = ((int)num2 * -495032150) ^ -2014519469;
					continue;
				case 47u:
					Form2.smethod_25((Control)(object)button1, 3);
					num = (int)((num2 * 1293888142) ^ 0x15F8BE29);
					continue;
				case 46u:
					Form2.smethod_24((Control)(object)button1, new Size(73, 23));
					num = ((int)num2 * -1420925025) ^ -2044604987;
					continue;
				case 45u:
					Form2.smethod_21((Control)(object)label3, bool_0: true);
					num = (int)(num2 * 1723978185) ^ -997730433;
					continue;
				case 44u:
					Form2.smethod_24((Control)(object)textBox1, new Size(42, 80));
					num = ((int)num2 * -415600527) ^ 0x6E0D4F5A;
					continue;
				case 43u:
					Form2.smethod_33((Form)(object)this, new Size(255, 224));
					num = (int)((num2 * 1169015158) ^ 0x6E5754BA);
					continue;
				case 42u:
					Form2.smethod_21((Control)(object)label2, bool_0: true);
					num = (int)((num2 * 1715173760) ^ 0x60316919);
					continue;
				case 41u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)textBox1);
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label2);
					num = (int)((num2 * 1570755476) ^ 0x2CADC0B8);
					continue;
				case 40u:
					num = ((int)num2 * -1656039575) ^ -1936284591;
					continue;
				case 39u:
					num = ((int)num2 * -1519012121) ^ -2044658233;
					continue;
				case 38u:
					Form2.smethod_22((Control)(object)textBox1, new Point(24, 86));
					num = ((int)num2 * -565175288) ^ -841502310;
					continue;
				case 37u:
					Form2.smethod_39((Control)(object)this, "Form2");
					num = (int)(num2 * 1307957055) ^ -1614432498;
					continue;
				case 36u:
					num = ((int)num2 * -1218815860) ^ -171148339;
					continue;
				case 35u:
					Form2.smethod_20((Control)(object)this);
					Form2.smethod_21((Control)(object)label1, bool_0: true);
					num = (int)((num2 * 1314599619) ^ 0x65F8EBEB);
					continue;
				case 34u:
					num = ((int)num2 * -1647639756) ^ 0x69462147;
					continue;
				case 33u:
					num = (int)((num2 * 1472029562) ^ 0x2CA62770);
					continue;
				case 32u:
					Form2.smethod_23((Control)(object)textBox1, "textBox1");
					num = ((int)num2 * -13959727) ^ 0x6F26DA4A;
					continue;
				case 31u:
					Form2.smethod_1((Control)(object)label1, "label1");
					Form2.smethod_27((Control)(object)textBox1, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 1456611744) ^ 0x54FF1995);
					continue;
				case 30u:
					num = ((int)num2 * -605009415) ^ 0x1FFCB152;
					continue;
				case 29u:
					Form2.smethod_30((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)(num2 * 234565334) ^ -1581016006;
					continue;
				case 28u:
					Form2.smethod_23((Control)(object)label1, "label1");
					num = ((int)num2 * -1125376348) ^ 0x4747AFFB;
					continue;
				case 27u:
					Form2.smethod_23((Control)(object)button1, "button1");
					num = (int)((num2 * 215152398) ^ 0x43F59E99);
					continue;
				case 26u:
					Form2.smethod_1((Control)(object)button1, "OK");
					num = (int)((num2 * 2040958785) ^ 0x7CA30B6D);
					continue;
				case 25u:
					Form2.smethod_25((Control)(object)label2, 2);
					num = (int)(num2 * 2035109745) ^ -202627127;
					continue;
				case 24u:
					Form2.smethod_27((Control)(object)label2, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1047898194) ^ -1367404616;
					continue;
				case 23u:
					num = ((int)num2 * -241046708) ^ 0x1A70BE20;
					continue;
				case 22u:
					Form2.smethod_22((Control)(object)button1, new Point(86, 193));
					num = ((int)num2 * -360118733) ^ -1420056014;
					continue;
				case 21u:
					Form2.smethod_31((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -1090379615) ^ -1481838775;
					continue;
				case 20u:
					Form2.smethod_24((Control)(object)label1, new Size(35, 13));
					Form2.smethod_25((Control)(object)label1, 0);
					num = ((int)num2 * -1653626026) ^ -346540152;
					continue;
				case 19u:
					Form2.smethod_22((Control)(object)label2, new Point(53, 89));
					num = ((int)num2 * -45620741) ^ 0x4F2407DC;
					continue;
				case 18u:
					Form2.smethod_24((Control)(object)label2, new Size(188, 73));
					num = ((int)num2 * -1087412849) ^ 0x861AA56;
					continue;
				case 17u:
					num = ((int)num2 * -705217270) ^ -1302860438;
					continue;
				case 16u:
					Form2.smethod_41((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
					num = ((int)num2 * -1851596953) ^ 0x16314731;
					continue;
				case 15u:
					Form2.smethod_43((Control)(object)this);
					num = ((int)num2 * -590562226) ^ 0x738FEFE4;
					continue;
				case 14u:
					Form2.smethod_25((Control)(object)textBox1, 1);
					num = ((int)num2 * -1369762003) ^ 0x64E97BC3;
					continue;
				case 13u:
					Form2.smethod_22((Control)(object)label3, new Point(47, 177));
					Form2.smethod_23((Control)(object)label3, "label3");
					num = ((int)num2 * -899720540) ^ -699468962;
					continue;
				case 11u:
					Form2.smethod_24((Control)(object)label3, new Size(0, 13));
					num = (int)(num2 * 355436191) ^ -1341645046;
					continue;
				case 10u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label1);
					num = (int)(num2 * 229263680) ^ -142178122;
					continue;
				case 9u:
					Form2.smethod_25((Control)(object)label3, 4);
					num = ((int)num2 * -2128148076) ^ 0x3F733EEC;
					continue;
				case 8u:
					Form2.smethod_22((Control)(object)label1, new Point(10, 10));
					num = ((int)num2 * -318565990) ^ -1529960097;
					continue;
				case 7u:
					Form2.smethod_42((Control)(object)this, bool_0: false);
					num = (int)((num2 * 1638024858) ^ 0x5035C63C);
					continue;
				case 6u:
					Form2.smethod_36((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -1356125034) ^ 0x5BB26B1A;
					continue;
				case 5u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -2114904521) ^ -655673053;
					continue;
				case 4u:
					Form2.smethod_28((Control)(object)textBox1, new KeyPressEventHandler(TextBox1_KeyPress));
					num = ((int)num2 * -150632749) ^ 0xE17341B;
					continue;
				case 3u:
					num = ((int)num2 * -1358825325) ^ -1124347951;
					continue;
				case 2u:
					Form2.smethod_38((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1880699137) ^ 0x2F82C919;
					continue;
				case 1u:
					num = ((int)num2 * -383920070) ^ -846914933;
					continue;
				case 0u:
					num = ((int)num2 * -1514219464) ^ -133074725;
					continue;
				default:
					return;
				case 59u:
					break;
				case 12u:
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
