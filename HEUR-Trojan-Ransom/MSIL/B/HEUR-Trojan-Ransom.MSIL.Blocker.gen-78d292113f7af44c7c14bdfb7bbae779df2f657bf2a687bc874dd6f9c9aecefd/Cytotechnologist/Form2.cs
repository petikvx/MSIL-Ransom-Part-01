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
			int num = 95686331;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x43093752u) % 6u)
				{
				case 4u:
					InitializeComponent();
					num = ((int)num2 * -647031329) ^ -2143828569;
					continue;
				case 3u:
					num = (int)(num2 * 2145602982) ^ -1206009434;
					continue;
				case 1u:
					Form2.smethod_1((Control)(object)label1, "Введите любое число от 0 до 9 включительно.\nВаш соперник уже загадал число (N) из этого\nже диапазона. Если сумма ваших чисел будет\nчетным числом, то первым ход делаете Вы,\nиначе - ваш соперник Компьютер!");
					num = (int)((num2 * 1023192827) ^ 0x46380CE1);
					continue;
				case 0u:
					num = ((int)num2 * -109047731) ^ 0x3EF157EE;
					continue;
				default:
					return;
				case 5u:
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
			int num = -1304390080;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8ABDA87Du) % 12u)
				{
				case 11u:
				{
					int num5;
					if (Form2.smethod_4(e) != '\r')
					{
						num = -629643997;
						num5 = -629643997;
					}
					else
					{
						num = -385008367;
						num5 = -385008367;
					}
					continue;
				}
				case 10u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -2134458081;
						num4 = -2134458081;
					}
					else
					{
						num3 = -1475910724;
						num4 = -1475910724;
					}
					num = num3 ^ ((int)num2 * -1318006072);
					continue;
				}
				case 9u:
					flag = !char.IsDigit(Form2.smethod_4(e));
					num = (int)((num2 * 1150014904) ^ 0x7A32EBCB);
					continue;
				case 8u:
					num = ((int)num2 * -1178248140) ^ -1097068638;
					continue;
				case 7u:
					num = ((int)num2 * -285056367) ^ 0x7C57FA2A;
					continue;
				case 4u:
					Button1_Click(this, Form2.smethod_6());
					num = ((int)num2 * -1939221933) ^ 0x21E263F2;
					continue;
				case 3u:
					num = ((int)num2 * -1013599260) ^ -1046481425;
					continue;
				case 2u:
					Form2.smethod_5(e, bool_0: true);
					num = (int)((num2 * 74045099) ^ 0x121DB56C);
					continue;
				case 1u:
					Form2.smethod_1((Control)(object)textBox1, "");
					num = -1811272287;
					continue;
				case 0u:
					num = ((int)num2 * -648868560) ^ 0x401FA812;
					continue;
				default:
					return;
				case 5u:
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
		bool flag2 = default(bool);
		bool flag = default(bool);
		int num5 = default(int);
		int num6 = default(int);
		while (true)
		{
			int num = -1987945053;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA2217FA0u) % 31u)
				{
				case 30u:
					num = ((int)num2 * -149699327) ^ 0xC48B246;
					continue;
				case 29u:
					num = -1746005301;
					continue;
				case 28u:
					num = -26324999;
					continue;
				case 27u:
					num = ((int)num2 * -1333151230) ^ 0x6A677D00;
					continue;
				case 26u:
				{
					Form control_ = Form2.smethod_2((Form)(object)this);
					int num9 = Form2.smethod_12((Control)(object)control_) - 1;
					Form2.smethod_13((Control)(object)control_, num9);
					int num10;
					if (num9 > 1)
					{
						num = -1316125865;
						num10 = -1316125865;
					}
					else
					{
						num = -1511444477;
						num10 = -1511444477;
					}
					continue;
				}
				case 24u:
					num = ((int)num2 * -226340089) ^ -1691297356;
					continue;
				case 23u:
				{
					int num11;
					int num12;
					if (!flag2)
					{
						num11 = -1505614995;
						num12 = -1505614995;
					}
					else
					{
						num11 = -473004618;
						num12 = -473004618;
					}
					num = num11 ^ ((int)num2 * -260848749);
					continue;
				}
				case 22u:
					flag = this.flag;
					num = (int)((num2 * 1131413544) ^ 0x13F4B8C3);
					continue;
				case 21u:
					Form2.smethod_1((Control)(object)label3, "Первым ход делает Компьютер.");
					num = -356533474;
					continue;
				case 20u:
					num = (int)(num2 * 1702534154) ^ -2119770738;
					continue;
				case 19u:
					Form2.smethod_14(Form2.smethod_11(Form2.smethod_2((Form)(object)this)));
					num = ((int)num2 * -1209928756) ^ -1917661788;
					continue;
				case 18u:
					flag2 = Form2.smethod_8(Form2.smethod_7((Control)(object)textBox1), "");
					num = (int)(num2 * 1294229001) ^ -1452013511;
					continue;
				case 17u:
				{
					int num7;
					int num8;
					if ((num5 + num6) % 2 == 0)
					{
						num7 = -640713702;
						num8 = -640713702;
					}
					else
					{
						num7 = -1182258592;
						num8 = -1182258592;
					}
					num = num7 ^ ((int)num2 * -597047781);
					continue;
				}
				case 16u:
					num5 = int.Parse(Form2.smethod_7((Control)(object)textBox1));
					num6 = Form2.smethod_9(rnd, 10);
					Form2.smethod_1((Control)(object)label2, Form2.smethod_10("+", num6.ToString(), "=", (num5 + num6).ToString()));
					num = (int)(num2 * 1998824729) ^ -392389494;
					continue;
				case 15u:
					num = (int)(num2 * 2116818947) ^ -1675591384;
					continue;
				case 14u:
					num = ((int)num2 * -685276804) ^ -224894014;
					continue;
				case 13u:
					num = ((int)num2 * -315795541) ^ 0x7EAEF48D;
					continue;
				case 12u:
					num = ((int)num2 * -1934455081) ^ -6546306;
					continue;
				case 11u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).StartGame();
					num = ((int)num2 * -360030086) ^ 0x1A2CC046;
					continue;
				case 10u:
					Form2.smethod_1((Control)(object)label3, "Поздравляем! Ваш ход первый.");
					num = ((int)num2 * -1543899944) ^ 0x4DDC6564;
					continue;
				case 8u:
					num = -2141362117;
					continue;
				case 7u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = true;
					num = (int)((num2 * 643194074) ^ 0x880B9E3);
					continue;
				case 6u:
					num = (int)(num2 * 873493310) ^ -702332681;
					continue;
				case 5u:
					(Form2.smethod_2((Form)(object)this) as Form3).Button_Continue();
					num = (int)(num2 * 869651846) ^ -914084415;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -999047428;
						num4 = -999047428;
					}
					else
					{
						num3 = -1867578901;
						num4 = -1867578901;
					}
					num = num3 ^ ((int)num2 * -1237740919);
					continue;
				}
				case 3u:
					Form2.smethod_15((Form)(object)this);
					num = (int)((num2 * 1192819656) ^ 0x1413103B);
					continue;
				case 2u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = false;
					num = (int)((num2 * 357522493) ^ 0x7C655626);
					continue;
				case 1u:
					this.flag = false;
					num = -68933595;
					continue;
				case 0u:
					num = (int)((num2 * 1012154673) ^ 0x709A2295);
					continue;
				default:
					return;
				case 25u:
					break;
				case 9u:
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
			int num = -1805821268;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xF81A36AEu) % 7u)
				{
				case 6u:
					if (components != null)
					{
						num = -1489636929;
						num3 = -1489636929;
						continue;
					}
					goto IL_0011;
				case 5u:
					if (disposing)
					{
						num = ((int)num2 * -1306912521) ^ 0x36000D03;
						continue;
					}
					goto IL_0011;
				case 3u:
					num = ((int)num2 * -1613487868) ^ 0x727BF6E5;
					continue;
				case 2u:
					Form2.smethod_16((IDisposable)components);
					num = (int)((num2 * 1750486730) ^ 0x142FEB71);
					continue;
				case 1u:
					num = ((int)num2 * -667324589) ^ -1838075882;
					continue;
				case 4u:
					break;
				default:
					{
						((Form)this).Dispose(disposing);
						return;
					}
					IL_0011:
					num = -232978271;
					num3 = -232978271;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected O, but got Unknown
		while (true)
		{
			int num = 966116460;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x272AF5BBu) % 60u)
				{
				case 59u:
					Form2.smethod_38((Form)(object)this, bool_0: false);
					num = (int)((num2 * 704782298) ^ 0x68C4A9F);
					continue;
				case 58u:
					Form2.smethod_43((Control)(object)this);
					num = (int)(num2 * 878686289) ^ -656552502;
					continue;
				case 57u:
					num = (int)(num2 * 1728686051) ^ -1801561732;
					continue;
				case 56u:
					num = (int)((num2 * 298585849) ^ 0x567927D);
					continue;
				case 55u:
					num = (int)(num2 * 1767295145) ^ -1864875042;
					continue;
				case 54u:
					num = ((int)num2 * -30971534) ^ -186972129;
					continue;
				case 53u:
					Form2.smethod_21((Control)(object)label3, bool_0: true);
					num = ((int)num2 * -1427180918) ^ -1433049492;
					continue;
				case 52u:
					Form2.smethod_23((Control)(object)button1, "button1");
					num = ((int)num2 * -1989856040) ^ -888195850;
					continue;
				case 51u:
					num = (int)(num2 * 547499107) ^ -1111540866;
					continue;
				case 50u:
					Form2.smethod_33((Form)(object)this, new Size(255, 224));
					num = (int)((num2 * 2095909526) ^ 0x1CEB8DC4);
					continue;
				case 49u:
					label3 = Form2.smethod_17();
					Form2.smethod_20((Control)(object)this);
					num = ((int)num2 * -974899631) ^ 0x7F8D3F8;
					continue;
				case 48u:
					Form2.smethod_41((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
					num = (int)(num2 * 1250585667) ^ -1665837763;
					continue;
				case 47u:
					Form2.smethod_1((Control)(object)label2, "+N=?");
					num = ((int)num2 * -1552375984) ^ 0x452BC402;
					continue;
				case 46u:
					Form2.smethod_42((Control)(object)this, bool_0: false);
					num = ((int)num2 * -974685922) ^ -1521368083;
					continue;
				case 45u:
					Form2.smethod_22((Control)(object)label2, new Point(53, 89));
					num = (int)(num2 * 1244388435) ^ -662118312;
					continue;
				case 44u:
					Form2.smethod_28((Control)(object)textBox1, new KeyPressEventHandler(TextBox1_KeyPress));
					num = (int)((num2 * 1691148759) ^ 0x1D9DDDEE);
					continue;
				case 43u:
					Form2.smethod_1((Control)(object)this, "Жеребьёвка");
					num = (int)((num2 * 483052394) ^ 0x5C2D84E1);
					continue;
				case 42u:
					Form2.smethod_36((Form)(object)this, (FormBorderStyle)1);
					num = (int)(num2 * 1083116209) ^ -973315786;
					continue;
				case 41u:
					Form2.smethod_24((Control)(object)button1, new Size(73, 23));
					num = (int)((num2 * 136101588) ^ 0x776B92);
					continue;
				case 39u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)button1);
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)textBox1);
					num = (int)(num2 * 174914811) ^ -1962997081;
					continue;
				case 38u:
					Form2.smethod_29((ButtonBase)(object)button1, bool_0: true);
					num = (int)(num2 * 792229604) ^ -1706605061;
					continue;
				case 37u:
					Form2.smethod_37((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1831730864) ^ -572561064;
					continue;
				case 36u:
					num = (int)(num2 * 281000343) ^ -1713512546;
					continue;
				case 35u:
					label1 = Form2.smethod_17();
					textBox1 = Form2.smethod_18();
					label2 = Form2.smethod_17();
					num = ((int)num2 * -304007128) ^ 0x761E2F24;
					continue;
				case 34u:
					Form2.smethod_27((Control)(object)label2, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 1288792280) ^ 0xBAF339A);
					continue;
				case 33u:
					num = ((int)num2 * -1651348016) ^ -459467805;
					continue;
				case 32u:
					Form2.smethod_1((Control)(object)button1, "OK");
					num = ((int)num2 * -1142171854) ^ -788266963;
					continue;
				case 31u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label3);
					num = (int)(num2 * 31395604) ^ -941654776;
					continue;
				case 30u:
					Form2.smethod_23((Control)(object)textBox1, "textBox1");
					num = ((int)num2 * -1406341932) ^ 0xDB75BBC;
					continue;
				case 29u:
					num = (int)(num2 * 817220507) ^ -912070197;
					continue;
				case 28u:
					num = ((int)num2 * -402317273) ^ 0x1F52EE09;
					continue;
				case 27u:
					num = ((int)num2 * -725024761) ^ 0x18533AEC;
					continue;
				case 25u:
					Form2.smethod_21((Control)(object)label2, bool_0: true);
					num = (int)((num2 * 1738780584) ^ 0x5555AD59);
					continue;
				case 24u:
					Form2.smethod_23((Control)(object)label2, "label2");
					Form2.smethod_24((Control)(object)label2, new Size(188, 73));
					num = ((int)num2 * -55137199) ^ 0xF907E0B;
					continue;
				case 23u:
					num = (int)(num2 * 258049371) ^ -1241676237;
					continue;
				case 22u:
					Form2.smethod_23((Control)(object)label3, "label3");
					Form2.smethod_24((Control)(object)label3, new Size(0, 13));
					num = ((int)num2 * -334080859) ^ -2118979235;
					continue;
				case 21u:
					num = ((int)num2 * -93263999) ^ 0x1FCC2C73;
					continue;
				case 20u:
					num = (int)((num2 * 153476163) ^ 0x1B2A3223);
					continue;
				case 19u:
					Form2.smethod_32((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -446664936) ^ 0x7D17DCC1;
					continue;
				case 18u:
					Form2.smethod_1((Control)(object)label1, "label1");
					Form2.smethod_27((Control)(object)textBox1, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 1304974972) ^ -1444291116;
					continue;
				case 17u:
					num = ((int)num2 * -1381359145) ^ -304513139;
					continue;
				case 16u:
					Form2.smethod_39((Control)(object)this, "Form2");
					num = ((int)num2 * -1776377547) ^ -1220171406;
					continue;
				case 15u:
					button1 = Form2.smethod_19();
					num = ((int)num2 * -1205705174) ^ -1649891912;
					continue;
				case 14u:
					Form2.smethod_30((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)(num2 * 1273430898) ^ -4055116;
					continue;
				case 13u:
					Form2.smethod_40((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1934066538) ^ -29390598;
					continue;
				case 12u:
					Form2.smethod_25((Control)(object)label3, 4);
					Form2.smethod_31((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -1014215262) ^ 0x62258C76;
					continue;
				case 11u:
					Form2.smethod_24((Control)(object)textBox1, new Size(42, 80));
					Form2.smethod_25((Control)(object)textBox1, 1);
					num = ((int)num2 * -1817473980) ^ 0x78F7973;
					continue;
				case 10u:
					Form2.smethod_21((Control)(object)label1, bool_0: true);
					Form2.smethod_22((Control)(object)label1, new Point(10, 10));
					Form2.smethod_23((Control)(object)label1, "label1");
					Form2.smethod_24((Control)(object)label1, new Size(35, 13));
					num = (int)((num2 * 379992377) ^ 0xFA7D7D3);
					continue;
				case 9u:
					Form2.smethod_25((Control)(object)button1, 3);
					num = ((int)num2 * -14275599) ^ -1644706015;
					continue;
				case 8u:
					Form2.smethod_25((Control)(object)label2, 2);
					num = (int)(num2 * 1359260259) ^ -1826263864;
					continue;
				case 7u:
					num = (int)((num2 * 1533018066) ^ 0x30825FB8);
					continue;
				case 6u:
					Form2.smethod_22((Control)(object)textBox1, new Point(24, 86));
					num = ((int)num2 * -679577526) ^ 0x567B05CD;
					continue;
				case 5u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -1132854439) ^ -1386174438;
					continue;
				case 4u:
					Form2.smethod_22((Control)(object)button1, new Point(86, 193));
					num = (int)(num2 * 1833358164) ^ -903725161;
					continue;
				case 3u:
					num = (int)(num2 * 800394891) ^ -700676442;
					continue;
				case 2u:
					Form2.smethod_25((Control)(object)label1, 0);
					num = (int)(num2 * 295155404) ^ -375527976;
					continue;
				case 1u:
					Form2.smethod_22((Control)(object)label3, new Point(47, 177));
					num = (int)((num2 * 485579976) ^ 0x15DF3F85);
					continue;
				case 0u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label2);
					num = (int)((num2 * 1177172882) ^ 0x45BFB8B);
					continue;
				default:
					return;
				case 26u:
					break;
				case 40u:
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
