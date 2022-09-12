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
			int num = -1862270822;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8137EA9Du) % 5u)
				{
				case 2u:
					num = ((int)num2 * -1407920040) ^ 0x53BBD80;
					continue;
				case 1u:
					InitializeComponent();
					num = (int)((num2 * 813494669) ^ 0x7A44570A);
					continue;
				case 0u:
					Form2.smethod_1((Control)(object)label1, "Введите любое число от 0 до 9 включительно.\nВаш соперник уже загадал число (N) из этого\nже диапазона. Если сумма ваших чисел будет\nчетным числом, то первым ход делаете Вы,\nиначе - ваш соперник Компьютер!");
					num = ((int)num2 * -1678097911) ^ 0x7FF3F3CB;
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

	private void Form2_FormClosed(object sender, FormClosedEventArgs e)
	{
		Form2.smethod_3((Control)(object)Form2.smethod_2((Form)(object)this), bool_0: true);
		while (true)
		{
			int num = -1082538324;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA78066ABu) % 3u)
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
				num = ((int)num2 * -313661022) ^ 0x6B757A1D;
			}
		}
	}

	private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		while (true)
		{
			int num = 33053383;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x21FCC863u) % 7u)
				{
				case 6u:
				{
					int num5;
					if (Form2.smethod_4(e) == '\r')
					{
						num = 1861699418;
						num5 = 1861699418;
					}
					else
					{
						num = 1288620901;
						num5 = 1288620901;
					}
					continue;
				}
				case 4u:
				{
					int num3;
					int num4;
					if (!char.IsDigit(Form2.smethod_4(e)))
					{
						num3 = 41680346;
						num4 = 41680346;
					}
					else
					{
						num3 = 406114191;
						num4 = 406114191;
					}
					num = num3 ^ ((int)num2 * -1884703348);
					continue;
				}
				case 2u:
					Button1_Click(this, Form2.smethod_6());
					num = (int)(num2 * 1293768174) ^ -49489765;
					continue;
				case 1u:
					Form2.smethod_1((Control)(object)textBox1, "");
					num = 311871082;
					continue;
				case 0u:
					Form2.smethod_5(e, bool_0: true);
					num = ((int)num2 * -8241848) ^ -809082398;
					continue;
				default:
					return;
				case 5u:
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
		bool flag = Form2.smethod_8(Form2.smethod_7((Control)(object)textBox1), "");
		int num4 = default(int);
		int num5 = default(int);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = 1968615346;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x70F3C431u) % 28u)
				{
				case 27u:
					num = (int)((num2 * 502138062) ^ 0x4E10E809);
					continue;
				case 26u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = true;
					num = (int)((num2 * 1653998674) ^ 0x3356711F);
					continue;
				case 25u:
					num4 = int.Parse(Form2.smethod_7((Control)(object)textBox1));
					num = ((int)num2 * -228105811) ^ -2084969334;
					continue;
				case 24u:
					Form2.smethod_1((Control)(object)label3, "Первым ход делает Компьютер.");
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = false;
					num = 179459819;
					continue;
				case 23u:
				{
					Form control_2 = Form2.smethod_2((Form)(object)this);
					num5 = Form2.smethod_12((Control)(object)control_2) - 1;
					Form2.smethod_13((Control)(object)control_2, num5);
					num = 1777057710;
					continue;
				}
				case 22u:
				{
					int num10;
					int num11;
					if (!flag3)
					{
						num10 = 2111023314;
						num11 = 2111023314;
					}
					else
					{
						num10 = 371265228;
						num11 = 371265228;
					}
					num = num10 ^ (int)(num2 * 894629565);
					continue;
				}
				case 20u:
				{
					int num12;
					int num13;
					if (!this.flag)
					{
						num12 = -1991129044;
						num13 = -1991129044;
					}
					else
					{
						num12 = -281764576;
						num13 = -281764576;
					}
					num = num12 ^ ((int)num2 * -1416587858);
					continue;
				}
				case 19u:
				{
					int num8;
					int num9;
					if (!flag)
					{
						num8 = -2101711059;
						num9 = -2101711059;
					}
					else
					{
						num8 = -2762222;
						num9 = -2762222;
					}
					num = num8 ^ ((int)num2 * -1121966127);
					continue;
				}
				case 18u:
					this.flag = false;
					num = 1708193491;
					continue;
				case 17u:
					Form2.smethod_15((Form)(object)this);
					num = ((int)num2 * -799793513) ^ 0x1783BFD6;
					continue;
				case 16u:
					flag3 = num5 > 1;
					num = (int)(num2 * 742506012) ^ -1609449949;
					continue;
				case 14u:
				{
					int num6;
					int num7;
					if (!flag2)
					{
						num6 = -1728586269;
						num7 = -1728586269;
					}
					else
					{
						num6 = -754911820;
						num7 = -754911820;
					}
					num = num6 ^ ((int)num2 * -1356676537);
					continue;
				}
				case 13u:
					(Form2.smethod_2((Form)(object)this) as Form3).Button_Continue();
					num = (int)((num2 * 1473032126) ^ 0x641FCBE0);
					continue;
				case 12u:
					num = (int)((num2 * 1104599559) ^ 0x12A60959);
					continue;
				case 11u:
					num = 1481098410;
					continue;
				case 10u:
					Form2.smethod_14(Form2.smethod_11(Form2.smethod_2((Form)(object)this)));
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).StartGame();
					num = ((int)num2 * -1284683385) ^ 0x42B79E02;
					continue;
				case 9u:
					num = (int)(num2 * 291777121) ^ -1906315651;
					continue;
				case 8u:
					flag2 = (num4 + num3) % 2 == 0;
					num = ((int)num2 * -909530551) ^ -1988609725;
					continue;
				case 7u:
					Form2.smethod_1((Control)(object)label3, "Поздравляем! Ваш ход первый.");
					num = (int)(num2 * 960435190) ^ -289217663;
					continue;
				case 6u:
					num = (int)(num2 * 1786022754) ^ -740786544;
					continue;
				case 5u:
					num = 1795365801;
					continue;
				case 4u:
					num = (int)(num2 * 2037098061) ^ -1129311214;
					continue;
				case 3u:
					num = (int)((num2 * 1124777313) ^ 0x5980326);
					continue;
				case 2u:
				{
					num3 = Form2.smethod_9(rnd, 10);
					Label control_ = label2;
					string string_ = num3.ToString();
					num5 = num4 + num3;
					Form2.smethod_1((Control)(object)control_, Form2.smethod_10("+", string_, "=", num5.ToString()));
					num = ((int)num2 * -1589457661) ^ 0x15C0436F;
					continue;
				}
				case 1u:
					num = ((int)num2 * -655334776) ^ 0x5081FD99;
					continue;
				case 0u:
					num = 1954010590;
					continue;
				default:
					return;
				case 21u:
					break;
				case 15u:
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
			int num = 672203325;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x21D53B61u) % 8u)
				{
				case 7u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1117826038;
						num5 = -1117826038;
					}
					else
					{
						num4 = -1729034015;
						num5 = -1729034015;
					}
					num = num4 ^ (int)(num2 * 974376368);
					continue;
				}
				case 6u:
					num = ((int)num2 * -1139155215) ^ -941710761;
					continue;
				case 4u:
					if (disposing)
					{
						num = (int)((num2 * 414683485) ^ 0x1529E33C);
						continue;
					}
					num3 = 0;
					goto IL_004c;
				case 3u:
					Form2.smethod_16((IDisposable)components);
					num = ((int)num2 * -1146969604) ^ 0x397FD4B3;
					continue;
				case 1u:
					num3 = ((components != null) ? 1 : 0);
					goto IL_004c;
				case 0u:
					((Form)this).Dispose(disposing);
					num = 913830371;
					continue;
				default:
					return;
				case 5u:
					break;
				case 2u:
					return;
					IL_004c:
					flag = (byte)num3 != 0;
					num = 843075862;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected O, but got Unknown
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cc: Expected O, but got Unknown
		label1 = Form2.smethod_17();
		while (true)
		{
			int num = 163734859;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x61337B67u) % 64u)
				{
				case 63u:
					num = ((int)num2 * -522675333) ^ 0x5873F74C;
					continue;
				case 62u:
					num = (int)((num2 * 42974159) ^ 0x4056177);
					continue;
				case 61u:
					num = (int)((num2 * 1645653412) ^ 0x31F0FFE6);
					continue;
				case 60u:
					num = ((int)num2 * -1079898353) ^ -866311899;
					continue;
				case 59u:
					Form2.smethod_23((Control)(object)label3, "label3");
					num = ((int)num2 * -194157591) ^ 0x6B002F18;
					continue;
				case 58u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)button1);
					num = (int)((num2 * 1343134627) ^ 0x134CAF7E);
					continue;
				case 57u:
					Form2.smethod_24((Control)(object)label2, new Size(188, 73));
					num = ((int)num2 * -323704736) ^ 0x4A13B803;
					continue;
				case 56u:
					num = (int)((num2 * 611695919) ^ 0x8C522EF);
					continue;
				case 55u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)textBox1);
					num = (int)(num2 * 659046450) ^ -1810270408;
					continue;
				case 54u:
					Form2.smethod_31((ContainerControl)(object)this, new SizeF(6f, 13f));
					Form2.smethod_32((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 950528591) ^ -1402169173;
					continue;
				case 53u:
					num = ((int)num2 * -355235897) ^ 0x2CD727F6;
					continue;
				case 52u:
					Form2.smethod_36((Form)(object)this, (FormBorderStyle)1);
					Form2.smethod_37((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1675495422) ^ -1463338771;
					continue;
				case 51u:
					Form2.smethod_24((Control)(object)textBox1, new Size(42, 80));
					num = (int)((num2 * 1729117876) ^ 0x149BA2D2);
					continue;
				case 50u:
					Form2.smethod_1((Control)(object)label2, "+N=?");
					num = ((int)num2 * -1883877789) ^ 0x38E2D67F;
					continue;
				case 49u:
					Form2.smethod_21((Control)(object)label3, bool_0: true);
					Form2.smethod_22((Control)(object)label3, new Point(47, 177));
					num = (int)(num2 * 1533500318) ^ -332632078;
					continue;
				case 48u:
					Form2.smethod_1((Control)(object)button1, "OK");
					num = (int)((num2 * 770715188) ^ 0xE2BFF33);
					continue;
				case 47u:
					Form2.smethod_24((Control)(object)button1, new Size(73, 23));
					num = ((int)num2 * -471083348) ^ 0x212767E0;
					continue;
				case 46u:
					Form2.smethod_25((Control)(object)label1, 0);
					num = (int)(num2 * 1763515741) ^ -568078208;
					continue;
				case 45u:
					Form2.smethod_23((Control)(object)button1, "button1");
					num = ((int)num2 * -2002163994) ^ 0x1D731CA6;
					continue;
				case 44u:
					textBox1 = Form2.smethod_18();
					label2 = Form2.smethod_17();
					num = (int)(num2 * 1880352955) ^ -1801911020;
					continue;
				case 43u:
					num = (int)(num2 * 1452333527) ^ -458808063;
					continue;
				case 42u:
					Form2.smethod_23((Control)(object)label2, "label2");
					num = ((int)num2 * -1931656640) ^ -137444770;
					continue;
				case 41u:
					Form2.smethod_25((Control)(object)textBox1, 1);
					num = ((int)num2 * -813277009) ^ -76483016;
					continue;
				case 40u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label3);
					num = ((int)num2 * -1525049737) ^ 0xC058F85;
					continue;
				case 38u:
					Form2.smethod_33((Form)(object)this, new Size(255, 224));
					num = (int)((num2 * 1975201170) ^ 0x42F04B23);
					continue;
				case 37u:
					num = ((int)num2 * -272962052) ^ 0x58FF7E8C;
					continue;
				case 36u:
					num = (int)(num2 * 1267033717) ^ -985101302;
					continue;
				case 35u:
					Form2.smethod_30((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)((num2 * 2080256814) ^ 0x6E19511C);
					continue;
				case 34u:
					Form2.smethod_41((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
					Form2.smethod_42((Control)(object)this, bool_0: false);
					num = ((int)num2 * -125742156) ^ -1254771789;
					continue;
				case 33u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label2);
					num = (int)((num2 * 1280332649) ^ 0x5138C48E);
					continue;
				case 32u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label1);
					num = (int)((num2 * 1901645580) ^ 0x2133FB53);
					continue;
				case 31u:
					Form2.smethod_20((Control)(object)this);
					num = ((int)num2 * -549137296) ^ -679787629;
					continue;
				case 30u:
					num = (int)((num2 * 695541743) ^ 0x2EDD706A);
					continue;
				case 29u:
					num = (int)((num2 * 164614300) ^ 0x787609CA);
					continue;
				case 28u:
					Form2.smethod_25((Control)(object)label3, 4);
					num = ((int)num2 * -1543706214) ^ 0x79CB5689;
					continue;
				case 27u:
					Form2.smethod_22((Control)(object)button1, new Point(86, 193));
					num = (int)((num2 * 626878249) ^ 0x6D0CEA19);
					continue;
				case 26u:
					Form2.smethod_21((Control)(object)label2, bool_0: true);
					num = (int)(num2 * 868225700) ^ -1176123273;
					continue;
				case 25u:
					Form2.smethod_21((Control)(object)label1, bool_0: true);
					Form2.smethod_22((Control)(object)label1, new Point(10, 10));
					num = ((int)num2 * -761315745) ^ 0x5A6264BD;
					continue;
				case 24u:
					Form2.smethod_28((Control)(object)textBox1, new KeyPressEventHandler(TextBox1_KeyPress));
					num = (int)(num2 * 472025156) ^ -1618256379;
					continue;
				case 23u:
					button1 = Form2.smethod_19();
					label3 = Form2.smethod_17();
					num = (int)((num2 * 598140507) ^ 0x26E5C895);
					continue;
				case 22u:
					num = (int)(num2 * 1073421747) ^ -2072663346;
					continue;
				case 21u:
					Form2.smethod_22((Control)(object)label2, new Point(53, 89));
					num = ((int)num2 * -861126885) ^ 0x6361B93A;
					continue;
				case 20u:
					Form2.smethod_29((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -268321219) ^ -1789890304;
					continue;
				case 19u:
					Form2.smethod_25((Control)(object)button1, 3);
					num = (int)((num2 * 1313348948) ^ 0x76971311);
					continue;
				case 18u:
					Form2.smethod_38((Form)(object)this, bool_0: false);
					num = (int)((num2 * 772745959) ^ 0x1A21F29A);
					continue;
				case 17u:
					Form2.smethod_1((Control)(object)label1, "label1");
					num = (int)(num2 * 961912375) ^ -1738559842;
					continue;
				case 16u:
					Form2.smethod_40((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1260527852) ^ -1696686270;
					continue;
				case 15u:
					Form2.smethod_27((Control)(object)textBox1, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 97291171) ^ -1968184153;
					continue;
				case 14u:
					num = ((int)num2 * -465045704) ^ 0x537B9B6C;
					continue;
				case 13u:
					num = (int)(num2 * 2139749857) ^ -883007601;
					continue;
				case 12u:
					Form2.smethod_24((Control)(object)label3, new Size(0, 13));
					num = ((int)num2 * -1031175359) ^ 0x143C3477;
					continue;
				case 11u:
					Form2.smethod_24((Control)(object)label1, new Size(35, 13));
					num = ((int)num2 * -489643015) ^ 0x7013002B;
					continue;
				case 10u:
					num = (int)((num2 * 1037785375) ^ 0x66C8B61);
					continue;
				case 8u:
					num = ((int)num2 * -1472088636) ^ 0xBFB31E0;
					continue;
				case 7u:
					Form2.smethod_1((Control)(object)this, "Жеребьёвка");
					num = (int)(num2 * 392226202) ^ -1036747292;
					continue;
				case 6u:
					Form2.smethod_43((Control)(object)this);
					num = (int)((num2 * 154221047) ^ 0x4867E3E5);
					continue;
				case 5u:
					Form2.smethod_22((Control)(object)textBox1, new Point(24, 86));
					Form2.smethod_23((Control)(object)textBox1, "textBox1");
					num = ((int)num2 * -1837234311) ^ 0x1BB682C9;
					continue;
				case 4u:
					Form2.smethod_25((Control)(object)label2, 2);
					num = ((int)num2 * -499786922) ^ 0x77257981;
					continue;
				case 3u:
					Form2.smethod_39((Control)(object)this, "Form2");
					num = (int)(num2 * 1553372934) ^ -392895771;
					continue;
				case 2u:
					num = ((int)num2 * -933560017) ^ 0x341C7AA3;
					continue;
				case 1u:
					Form2.smethod_23((Control)(object)label1, "label1");
					num = (int)(num2 * 875126157) ^ -1403267780;
					continue;
				case 0u:
					Form2.smethod_27((Control)(object)label2, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -2094474758) ^ 0x29629F1A;
					continue;
				default:
					return;
				case 9u:
					break;
				case 39u:
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
