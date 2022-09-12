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
		InitializeComponent();
		Form2.smethod_1((Control)(object)label1, "Введите любое число от 0 до 9 включительно.\nВаш соперник уже загадал число (N) из этого\nже диапазона. Если сумма ваших чисел будет\nчетным числом, то первым ход делаете Вы,\nиначе - ваш соперник Компьютер!");
	}

	private void Form2_FormClosed(object sender, FormClosedEventArgs e)
	{
		Form2.smethod_3((Control)(object)Form2.smethod_2((Form)(object)this), bool_0: true);
		while (true)
		{
			int num = 156879437;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1DF4B98Bu) % 3u)
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
				num = (int)((num2 * 1829953769) ^ 0x54DD383F);
			}
		}
	}

	private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		bool flag = !char.IsDigit(Form2.smethod_4(e));
		bool flag2 = default(bool);
		while (true)
		{
			int num = -110162591;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8C5FA5F8u) % 10u)
				{
				case 7u:
					Button1_Click(this, Form2.smethod_6());
					num = ((int)num2 * -1159679756) ^ -1870804841;
					continue;
				case 6u:
					num = ((int)num2 * -460194558) ^ -645807524;
					continue;
				case 5u:
					num = (int)(num2 * 84788030) ^ -929676901;
					continue;
				case 4u:
					Form2.smethod_5(e, bool_0: true);
					num = ((int)num2 * -1726038822) ^ -2114633572;
					continue;
				case 3u:
					Form2.smethod_1((Control)(object)textBox1, "");
					num = -764648116;
					continue;
				case 2u:
					flag2 = Form2.smethod_4(e) == '\r';
					num = -647600824;
					continue;
				case 1u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = -648126712;
						num6 = -648126712;
					}
					else
					{
						num5 = -1384737789;
						num6 = -1384737789;
					}
					num = num5 ^ (int)(num2 * 2095068221);
					continue;
				}
				case 0u:
				{
					int num3;
					int num4;
					if (!flag2)
					{
						num3 = -617185055;
						num4 = -617185055;
					}
					else
					{
						num3 = -1476721971;
						num4 = -1476721971;
					}
					num = num3 ^ (int)(num2 * 2129892803);
					continue;
				}
				default:
					return;
				case 8u:
					break;
				case 9u:
					return;
				}
				break;
			}
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		int num9 = default(int);
		int num4 = default(int);
		bool flag = default(bool);
		int num3 = default(int);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -1195159231;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB7434427u) % 32u)
				{
				case 31u:
					num = -934814435;
					continue;
				case 30u:
				{
					int num12;
					int num13;
					if (num9 > 1)
					{
						num12 = 533960014;
						num13 = 533960014;
					}
					else
					{
						num12 = 191670736;
						num13 = 191670736;
					}
					num = num12 ^ ((int)num2 * -1915268075);
					continue;
				}
				case 29u:
					num = -1311519851;
					continue;
				case 27u:
					num = ((int)num2 * -2053755737) ^ 0x3F1E496D;
					continue;
				case 26u:
				{
					Form control_ = Form2.smethod_2((Form)(object)this);
					num9 = Form2.smethod_12((Control)(object)control_) - 1;
					Form2.smethod_13((Control)(object)control_, num9);
					num = -424640839;
					continue;
				}
				case 25u:
					Form2.smethod_14(Form2.smethod_11(Form2.smethod_2((Form)(object)this)));
					num = (int)(num2 * 459819454) ^ -240991095;
					continue;
				case 24u:
					num4 = Form2.smethod_9(rnd, 10);
					num = ((int)num2 * -1023581198) ^ 0x4DC580B9;
					continue;
				case 23u:
					num = ((int)num2 * -1578398461) ^ -1499793450;
					continue;
				case 22u:
					num = ((int)num2 * -123738740) ^ 0x3B454102;
					continue;
				case 21u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).StartGame();
					num = (int)((num2 * 1782216264) ^ 0x779F1CC8);
					continue;
				case 20u:
					num = -315653181;
					continue;
				case 19u:
					num = (int)((num2 * 365523316) ^ 0x4BF18198);
					continue;
				case 18u:
					num = (int)((num2 * 710036508) ^ 0x153B5265);
					continue;
				case 17u:
				{
					int num10;
					int num11;
					if (flag)
					{
						num10 = 1295339361;
						num11 = 1295339361;
					}
					else
					{
						num10 = 1300325203;
						num11 = 1300325203;
					}
					num = num10 ^ (int)(num2 * 664711568);
					continue;
				}
				case 16u:
					num = (int)((num2 * 434270815) ^ 0x37999DDF);
					continue;
				case 15u:
					num3 = int.Parse(Form2.smethod_7((Control)(object)textBox1));
					num = (int)(num2 * 856061553) ^ -789379200;
					continue;
				case 14u:
				{
					Label control_2 = label2;
					string string_ = num4.ToString();
					num9 = num3 + num4;
					Form2.smethod_1((Control)(object)control_2, Form2.smethod_10("+", string_, "=", num9.ToString()));
					num = ((int)num2 * -2147283436) ^ -428663764;
					continue;
				}
				case 13u:
					flag2 = this.flag;
					num = (int)(num2 * 2039081298) ^ -1676565337;
					continue;
				case 12u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = false;
					num = (int)((num2 * 1819044494) ^ 0x11B02E1F);
					continue;
				case 11u:
					Form2.smethod_1((Control)(object)label3, "Поздравляем! Ваш ход первый.");
					num = (int)((num2 * 1111768283) ^ 0x73D4C72B);
					continue;
				case 10u:
				{
					int num7;
					int num8;
					if (!flag2)
					{
						num7 = -850203346;
						num8 = -850203346;
					}
					else
					{
						num7 = -935328004;
						num8 = -935328004;
					}
					num = num7 ^ ((int)num2 * -1429625246);
					continue;
				}
				case 9u:
					num = ((int)num2 * -1780962946) ^ -1224819838;
					continue;
				case 8u:
					this.flag = false;
					num = -887777092;
					continue;
				case 7u:
					Form2.smethod_15((Form)(object)this);
					num = ((int)num2 * -568828403) ^ 0x7E0EFC88;
					continue;
				case 6u:
					flag = Form2.smethod_8(Form2.smethod_7((Control)(object)textBox1), "");
					num = (int)((num2 * 1926947068) ^ 0x41917C3E);
					continue;
				case 5u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = true;
					num = ((int)num2 * -1226600179) ^ -1945050802;
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if ((num3 + num4) % 2 == 0)
					{
						num5 = -1283235648;
						num6 = -1283235648;
					}
					else
					{
						num5 = -1665573973;
						num6 = -1665573973;
					}
					num = num5 ^ ((int)num2 * -1880207750);
					continue;
				}
				case 2u:
					Form2.smethod_1((Control)(object)label3, "Первым ход делает Компьютер.");
					num = -1322314325;
					continue;
				case 1u:
					(Form2.smethod_2((Form)(object)this) as Form3).Button_Continue();
					num = (int)(num2 * 1434264410) ^ -277747132;
					continue;
				case 0u:
					num = (int)((num2 * 1730602518) ^ 0x66DA14B2);
					continue;
				default:
					return;
				case 28u:
					break;
				case 4u:
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
			int num = 1473551397;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0x2C6A11Eu) % 10u)
				{
				case 8u:
					num = (int)(num2 * 1693093339) ^ -947886418;
					continue;
				case 7u:
					num5 = ((components != null) ? 1 : 0);
					goto IL_0021;
				case 6u:
					num = (int)((num2 * 193114509) ^ 0x59520401);
					continue;
				case 4u:
					Form2.smethod_16((IDisposable)components);
					num = (int)(num2 * 236639637) ^ -1251081858;
					continue;
				case 3u:
					if (disposing)
					{
						num = (int)((num2 * 1045922523) ^ 0x737500BA);
						continue;
					}
					num5 = 0;
					goto IL_0021;
				case 2u:
					((Form)this).Dispose(disposing);
					num = 1287196392;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1335072625;
						num4 = -1335072625;
					}
					else
					{
						num3 = -1086593445;
						num4 = -1086593445;
					}
					num = num3 ^ (int)(num2 * 1819583457);
					continue;
				}
				case 0u:
					num = (int)((num2 * 1644829475) ^ 0x783A1D42);
					continue;
				default:
					return;
				case 5u:
					break;
				case 9u:
					return;
					IL_0021:
					flag = (byte)num5 != 0;
					num = 882418569;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Expected O, but got Unknown
		//IL_04ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f7: Expected O, but got Unknown
		while (true)
		{
			int num = 313173719;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7CCAE17Eu) % 64u)
				{
				case 63u:
					num = ((int)num2 * -1661032722) ^ 0x455BA663;
					continue;
				case 62u:
					num = ((int)num2 * -21491397) ^ -1510756698;
					continue;
				case 61u:
					num = ((int)num2 * -945736363) ^ 0x3A82AFE2;
					continue;
				case 60u:
					Form2.smethod_24((Control)(object)textBox1, new Size(42, 80));
					num = ((int)num2 * -1772748199) ^ -1123553026;
					continue;
				case 59u:
					Form2.smethod_32((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 418253689) ^ -1143597253;
					continue;
				case 58u:
					Form2.smethod_23((Control)(object)button1, "button1");
					Form2.smethod_24((Control)(object)button1, new Size(73, 23));
					num = (int)((num2 * 1594930816) ^ 0x1FE1B965);
					continue;
				case 57u:
					Form2.smethod_31((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)((num2 * 2071470628) ^ 0x1B881725);
					continue;
				case 55u:
					textBox1 = Form2.smethod_18();
					num = (int)(num2 * 1905581767) ^ -1652044360;
					continue;
				case 54u:
					Form2.smethod_22((Control)(object)label3, new Point(47, 177));
					num = ((int)num2 * -1352845106) ^ -1483413041;
					continue;
				case 53u:
					Form2.smethod_27((Control)(object)textBox1, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form2.smethod_22((Control)(object)textBox1, new Point(24, 86));
					Form2.smethod_23((Control)(object)textBox1, "textBox1");
					num = ((int)num2 * -1646482968) ^ 0x6E07928A;
					continue;
				case 52u:
					num = ((int)num2 * -1368004381) ^ 0x51D571D7;
					continue;
				case 51u:
					num = (int)(num2 * 312938205) ^ -251033248;
					continue;
				case 50u:
					Form2.smethod_21((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -1185518396) ^ 0x62E2D896;
					continue;
				case 49u:
					Form2.smethod_24((Control)(object)label2, new Size(188, 73));
					num = ((int)num2 * -999558315) ^ -229860884;
					continue;
				case 48u:
					Form2.smethod_24((Control)(object)label1, new Size(35, 13));
					num = (int)(num2 * 226582099) ^ -810540627;
					continue;
				case 47u:
					Form2.smethod_22((Control)(object)label2, new Point(53, 89));
					num = (int)((num2 * 1159258010) ^ 0x872F5B2);
					continue;
				case 46u:
					num = (int)((num2 * 1222450459) ^ 0x10E284DD);
					continue;
				case 45u:
					Form2.smethod_42((Control)(object)this, bool_0: false);
					num = (int)(num2 * 1308265953) ^ -1932408494;
					continue;
				case 44u:
					Form2.smethod_43((Control)(object)this);
					num = ((int)num2 * -1111112892) ^ -234313482;
					continue;
				case 43u:
					Form2.smethod_29((ButtonBase)(object)button1, bool_0: true);
					Form2.smethod_30((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)(num2 * 629984885) ^ -383487811;
					continue;
				case 42u:
					Form2.smethod_21((Control)(object)label2, bool_0: true);
					num = (int)((num2 * 2005183516) ^ 0x1D677AE0);
					continue;
				case 41u:
					label1 = Form2.smethod_17();
					num = (int)(num2 * 1903442395) ^ -311341414;
					continue;
				case 39u:
					Form2.smethod_1((Control)(object)button1, "OK");
					num = ((int)num2 * -2072764539) ^ -387066346;
					continue;
				case 38u:
					num = (int)(num2 * 1821857256) ^ -1519554145;
					continue;
				case 37u:
					Form2.smethod_24((Control)(object)label3, new Size(0, 13));
					num = (int)(num2 * 222113905) ^ -972730454;
					continue;
				case 36u:
					Form2.smethod_21((Control)(object)label3, bool_0: true);
					num = (int)((num2 * 1889603818) ^ 0x7DDE2E60);
					continue;
				case 35u:
					Form2.smethod_40((Form)(object)this, bool_0: false);
					Form2.smethod_1((Control)(object)this, "Жеребьёвка");
					num = ((int)num2 * -1571803742) ^ -714805044;
					continue;
				case 34u:
					Form2.smethod_1((Control)(object)label1, "label1");
					num = ((int)num2 * -1665049860) ^ -761055566;
					continue;
				case 33u:
					num = (int)((num2 * 815512486) ^ 0x207BBDF4);
					continue;
				case 32u:
					Form2.smethod_22((Control)(object)label1, new Point(10, 10));
					num = (int)(num2 * 1664288605) ^ -1277325680;
					continue;
				case 31u:
					num = ((int)num2 * -2005104663) ^ -366382926;
					continue;
				case 30u:
					num = (int)(num2 * 1022015150) ^ -1970561355;
					continue;
				case 29u:
					Form2.smethod_28((Control)(object)textBox1, new KeyPressEventHandler(TextBox1_KeyPress));
					num = ((int)num2 * -1874557592) ^ -18214052;
					continue;
				case 28u:
					Form2.smethod_25((Control)(object)textBox1, 1);
					num = (int)(num2 * 1562254915) ^ -318240553;
					continue;
				case 27u:
					Form2.smethod_25((Control)(object)button1, 3);
					num = ((int)num2 * -2028544863) ^ -1122187306;
					continue;
				case 26u:
					num = ((int)num2 * -1055804638) ^ 0x1A197E70;
					continue;
				case 25u:
					Form2.smethod_39((Control)(object)this, "Form2");
					num = (int)(num2 * 1252935553) ^ -731627471;
					continue;
				case 24u:
					num = (int)(num2 * 690831341) ^ -351159113;
					continue;
				case 23u:
					num = ((int)num2 * -1594889790) ^ 0x40DA85DC;
					continue;
				case 22u:
					num = (int)((num2 * 373061786) ^ 0x19A2ADE1);
					continue;
				case 21u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label3);
					num = (int)(num2 * 2045469666) ^ -1971902518;
					continue;
				case 20u:
					Form2.smethod_41((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
					num = ((int)num2 * -1984093632) ^ 0x55335613;
					continue;
				case 19u:
					num = ((int)num2 * -183031736) ^ -186782591;
					continue;
				case 18u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -1946420212) ^ -143115175;
					continue;
				case 17u:
					Form2.smethod_33((Form)(object)this, new Size(255, 224));
					num = ((int)num2 * -1973860143) ^ 0x392C9A0A;
					continue;
				case 16u:
					Form2.smethod_1((Control)(object)label2, "+N=?");
					Form2.smethod_22((Control)(object)button1, new Point(86, 193));
					num = ((int)num2 * -2066074849) ^ -1772996140;
					continue;
				case 15u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)textBox1);
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label2);
					num = ((int)num2 * -725410592) ^ 0x34DCA496;
					continue;
				case 14u:
					Form2.smethod_23((Control)(object)label1, "label1");
					num = ((int)num2 * -581889) ^ -1178234180;
					continue;
				case 13u:
					Form2.smethod_20((Control)(object)this);
					num = ((int)num2 * -2077091282) ^ 0x5261369A;
					continue;
				case 12u:
					Form2.smethod_25((Control)(object)label2, 2);
					num = ((int)num2 * -167087638) ^ 0x116494D6;
					continue;
				case 11u:
					Form2.smethod_25((Control)(object)label1, 0);
					num = (int)((num2 * 1583866955) ^ 0x60465AA5);
					continue;
				case 10u:
					Form2.smethod_23((Control)(object)label2, "label2");
					num = (int)((num2 * 1204450537) ^ 0x703E4EBC);
					continue;
				case 9u:
					button1 = Form2.smethod_19();
					label3 = Form2.smethod_17();
					num = ((int)num2 * -685938059) ^ 0x138AF12E;
					continue;
				case 8u:
					num = ((int)num2 * -399188839) ^ 0xEF7BA76;
					continue;
				case 7u:
					label2 = Form2.smethod_17();
					num = ((int)num2 * -1081949983) ^ 0x191EA150;
					continue;
				case 6u:
					Form2.smethod_27((Control)(object)label2, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 1955118651) ^ 0x6E0C7B02);
					continue;
				case 5u:
					Form2.smethod_23((Control)(object)label3, "label3");
					num = ((int)num2 * -223077246) ^ 0x129541D1;
					continue;
				case 4u:
					Form2.smethod_37((Form)(object)this, bool_0: false);
					Form2.smethod_38((Form)(object)this, bool_0: false);
					num = ((int)num2 * -138107978) ^ 0x313691D5;
					continue;
				case 3u:
					num = (int)(num2 * 925858725) ^ -779399846;
					continue;
				case 2u:
					Form2.smethod_25((Control)(object)label3, 4);
					num = (int)((num2 * 993979832) ^ 0x54343A60);
					continue;
				case 1u:
					num = ((int)num2 * -337960397) ^ -1171260529;
					continue;
				case 0u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label1);
					Form2.smethod_36((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -1157929963) ^ -1169934534;
					continue;
				default:
					return;
				case 40u:
					break;
				case 56u:
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
