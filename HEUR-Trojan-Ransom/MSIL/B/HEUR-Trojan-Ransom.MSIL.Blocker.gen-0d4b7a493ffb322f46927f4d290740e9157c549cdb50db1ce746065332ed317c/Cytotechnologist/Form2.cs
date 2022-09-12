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
			int num = 1998846541;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x393FFF7Fu) % 4u)
				{
				case 3u:
					InitializeComponent();
					Form2.smethod_1((Control)(object)label1, "Введите любое число от 0 до 9 включительно.\nВаш соперник уже загадал число (N) из этого\nже диапазона. Если сумма ваших чисел будет\nчетным числом, то первым ход делаете Вы,\nиначе - ваш соперник Компьютер!");
					num = (int)((num2 * 1400771656) ^ 0x5FF8EEBA);
					continue;
				case 2u:
					num = (int)(num2 * 1308155584) ^ -1243745008;
					continue;
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

	private void Form2_FormClosed(object sender, FormClosedEventArgs e)
	{
		Form2.smethod_3((Control)(object)Form2.smethod_2((Form)(object)this), bool_0: true);
		while (true)
		{
			int num = -1290053886;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB5A3E332u) % 3u)
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
				num = (int)(num2 * 108314845) ^ -341098006;
			}
		}
	}

	private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		bool flag = !char.IsDigit(Form2.smethod_4(e));
		while (true)
		{
			int num = -2024053291;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE700FE3Au) % 9u)
				{
				case 8u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 146952143;
						num5 = 146952143;
					}
					else
					{
						num4 = 1939453609;
						num5 = 1939453609;
					}
					num = num4 ^ ((int)num2 * -417274975);
					continue;
				}
				case 7u:
					num = (int)((num2 * 1872811716) ^ 0x5A135D24);
					continue;
				case 6u:
					num = ((int)num2 * -718442634) ^ 0x363AF0DE;
					continue;
				case 5u:
					Button1_Click(this, Form2.smethod_6());
					num = ((int)num2 * -1318177600) ^ 0x1A3E8594;
					continue;
				case 3u:
					Form2.smethod_5(e, bool_0: true);
					num = (int)(num2 * 510125701) ^ -18217359;
					continue;
				case 2u:
				{
					int num3;
					if (Form2.smethod_4(e) == '\r')
					{
						num = -435996550;
						num3 = -435996550;
					}
					else
					{
						num = -2113624854;
						num3 = -2113624854;
					}
					continue;
				}
				case 1u:
					Form2.smethod_1((Control)(object)textBox1, "");
					num = -1697519296;
					continue;
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

	private void Button1_Click(object sender, EventArgs e)
	{
		bool flag = Form2.smethod_8(Form2.smethod_7((Control)(object)textBox1), "");
		bool flag4 = default(bool);
		int num6 = default(int);
		int num9 = default(int);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 1163713306;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5E465CE0u) % 29u)
				{
				case 28u:
					num = (int)((num2 * 1436022936) ^ 0x5CC5B694);
					continue;
				case 27u:
					(Form2.smethod_2((Form)(object)this) as Form3).Button_Continue();
					Form2.smethod_14(Form2.smethod_11(Form2.smethod_2((Form)(object)this)));
					num = (int)(num2 * 1381240669) ^ -1378415578;
					continue;
				case 26u:
					num = (int)((num2 * 1499934304) ^ 0x4DEF3131);
					continue;
				case 25u:
					num = 1559267457;
					continue;
				case 23u:
					Form2.smethod_1((Control)(object)label3, "Поздравляем! Ваш ход первый.");
					num = ((int)num2 * -774690955) ^ 0x1DDCDF70;
					continue;
				case 22u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).StartGame();
					Form2.smethod_15((Form)(object)this);
					num = ((int)num2 * -670853906) ^ 0x2B15C79C;
					continue;
				case 21u:
					flag4 = (num6 + num9) % 2 == 0;
					num = (int)((num2 * 782438697) ^ 0x400D3D53);
					continue;
				case 20u:
					num = ((int)num2 * -2125011610) ^ -470110299;
					continue;
				case 19u:
					num = ((int)num2 * -52962423) ^ -1052717329;
					continue;
				case 18u:
					this.flag = false;
					num = 31156703;
					continue;
				case 17u:
					flag3 = this.flag;
					num = (int)(num2 * 1897310121) ^ -401457076;
					continue;
				case 16u:
				{
					int num12;
					int num13;
					if (flag2)
					{
						num12 = -2131462302;
						num13 = -2131462302;
					}
					else
					{
						num12 = -1581916997;
						num13 = -1581916997;
					}
					num = num12 ^ ((int)num2 * -637536864);
					continue;
				}
				case 15u:
					num9 = Form2.smethod_9(rnd, 10);
					Form2.smethod_1((Control)(object)label2, Form2.smethod_10("+", num9.ToString(), "=", (num6 + num9).ToString()));
					num = ((int)num2 * -476183571) ^ -1870079707;
					continue;
				case 14u:
					num = (int)((num2 * 270306464) ^ 0x3E6158D6);
					continue;
				case 13u:
				{
					int num10;
					int num11;
					if (flag4)
					{
						num10 = -1979244918;
						num11 = -1979244918;
					}
					else
					{
						num10 = -2143371360;
						num11 = -2143371360;
					}
					num = num10 ^ (int)(num2 * 1794283730);
					continue;
				}
				case 12u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = false;
					num = (int)((num2 * 1097524216) ^ 0x590EEF56);
					continue;
				case 11u:
				{
					int num7;
					int num8;
					if (flag)
					{
						num7 = 696839732;
						num8 = 696839732;
					}
					else
					{
						num7 = 16417413;
						num8 = 16417413;
					}
					num = num7 ^ ((int)num2 * -2115375059);
					continue;
				}
				case 10u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = true;
					num = ((int)num2 * -207297303) ^ -423013139;
					continue;
				case 9u:
					num = 1149463966;
					continue;
				case 8u:
					num6 = int.Parse(Form2.smethod_7((Control)(object)textBox1));
					num = ((int)num2 * -1998984637) ^ 0x392E394F;
					continue;
				case 7u:
					num = (int)((num2 * 1080494145) ^ 0x56744398);
					continue;
				case 5u:
					num = 1599390839;
					continue;
				case 4u:
					num = 1371433591;
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (flag3)
					{
						num4 = 357510198;
						num5 = 357510198;
					}
					else
					{
						num4 = 583343938;
						num5 = 583343938;
					}
					num = num4 ^ ((int)num2 * -1045079076);
					continue;
				}
				case 2u:
				{
					Form control_ = Form2.smethod_2((Form)(object)this);
					int num3 = Form2.smethod_12((Control)(object)control_) - 1;
					Form2.smethod_13((Control)(object)control_, num3);
					flag2 = num3 > 1;
					num = 1132484702;
					continue;
				}
				case 1u:
					Form2.smethod_1((Control)(object)label3, "Первым ход делает Компьютер.");
					num = (int)((num2 * 1846305472) ^ 0x7133AFA0);
					continue;
				case 0u:
					num = (int)((num2 * 1489295050) ^ 0x56667E2D);
					continue;
				default:
					return;
				case 24u:
					break;
				case 6u:
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
			int num = 1840610832;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x4F3DF337u) % 9u)
				{
				case 8u:
					num = ((int)num2 * -924439481) ^ 0x4F6E8E43;
					continue;
				case 6u:
					((Form)this).Dispose(disposing);
					num = 732660439;
					continue;
				case 5u:
					if (disposing)
					{
						num = (int)(num2 * 1349132079) ^ -1004569725;
						continue;
					}
					num3 = 0;
					goto IL_0036;
				case 4u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -529417178;
						num5 = -529417178;
					}
					else
					{
						num4 = -1540739805;
						num5 = -1540739805;
					}
					num = num4 ^ ((int)num2 * -1416529877);
					continue;
				}
				case 3u:
					num3 = ((components != null) ? 1 : 0);
					goto IL_0036;
				case 1u:
					Form2.smethod_16((IDisposable)components);
					num = (int)(num2 * 1536384579) ^ -963556675;
					continue;
				case 0u:
					num = (int)(num2 * 714975950) ^ -1552351790;
					continue;
				default:
					return;
				case 2u:
					break;
				case 7u:
					return;
					IL_0036:
					flag = (byte)num3 != 0;
					num = 1233535780;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Expected O, but got Unknown
		label1 = Form2.smethod_17();
		while (true)
		{
			int num = -881479088;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB1AB60FDu) % 64u)
				{
				case 63u:
					Form2.smethod_22((Control)(object)label1, new Point(10, 10));
					num = (int)((num2 * 337739338) ^ 0x2D4C35CF);
					continue;
				case 62u:
					Form2.smethod_41((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
					num = ((int)num2 * -1260163830) ^ -856612704;
					continue;
				case 61u:
					Form2.smethod_22((Control)(object)button1, new Point(86, 193));
					num = (int)((num2 * 1452164779) ^ 0x3077B929);
					continue;
				case 60u:
					Form2.smethod_27((Control)(object)textBox1, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 578558917) ^ -1323081849;
					continue;
				case 59u:
					Form2.smethod_29((ButtonBase)(object)button1, bool_0: true);
					Form2.smethod_30((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)((num2 * 962129834) ^ 0x3B66165F);
					continue;
				case 58u:
					num = ((int)num2 * -1367228889) ^ 0x21BC69D5;
					continue;
				case 57u:
					num = (int)((num2 * 377642803) ^ 0x50AE6A8F);
					continue;
				case 56u:
					num = (int)(num2 * 405006682) ^ -1701971961;
					continue;
				case 55u:
					Form2.smethod_32((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -418755968) ^ -1512072904;
					continue;
				case 54u:
					num = ((int)num2 * -1539512692) ^ 0x49153DA4;
					continue;
				case 53u:
					num = ((int)num2 * -1419809876) ^ -1043218324;
					continue;
				case 52u:
					Form2.smethod_24((Control)(object)label3, new Size(0, 13));
					num = (int)((num2 * 2130403520) ^ 0x544B407A);
					continue;
				case 51u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label3);
					num = ((int)num2 * -1497177486) ^ 0x7D08AEFD;
					continue;
				case 50u:
					Form2.smethod_24((Control)(object)textBox1, new Size(42, 80));
					num = (int)((num2 * 1871376726) ^ 0x3773C919);
					continue;
				case 49u:
					num = ((int)num2 * -1844271371) ^ 0x216F5068;
					continue;
				case 48u:
					Form2.smethod_42((Control)(object)this, bool_0: false);
					num = (int)(num2 * 1176179514) ^ -2105656664;
					continue;
				case 47u:
					Form2.smethod_1((Control)(object)label1, "label1");
					num = ((int)num2 * -2108391959) ^ -150158497;
					continue;
				case 46u:
					Form2.smethod_31((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -1451209067) ^ 0x18F6628C;
					continue;
				case 45u:
					textBox1 = Form2.smethod_18();
					label2 = Form2.smethod_17();
					num = ((int)num2 * -1244955224) ^ 0x4DE7F0E0;
					continue;
				case 44u:
					Form2.smethod_22((Control)(object)textBox1, new Point(24, 86));
					num = (int)(num2 * 1754159003) ^ -427924229;
					continue;
				case 43u:
					Form2.smethod_23((Control)(object)button1, "button1");
					Form2.smethod_24((Control)(object)button1, new Size(73, 23));
					num = (int)(num2 * 1513672305) ^ -1777178809;
					continue;
				case 42u:
					num = (int)((num2 * 926235919) ^ 0x425ED764);
					continue;
				case 41u:
					Form2.smethod_1((Control)(object)this, "Жеребьёвка");
					num = ((int)num2 * -270607167) ^ 0x5E172C6E;
					continue;
				case 40u:
					num = ((int)num2 * -266269621) ^ -700029602;
					continue;
				case 39u:
					num = ((int)num2 * -1407343855) ^ -1379627751;
					continue;
				case 38u:
					Form2.smethod_25((Control)(object)label2, 2);
					num = ((int)num2 * -1421871132) ^ -1806562517;
					continue;
				case 37u:
					num = (int)(num2 * 629649087) ^ -1923620070;
					continue;
				case 36u:
					Form2.smethod_40((Form)(object)this, bool_0: false);
					num = ((int)num2 * -2056695472) ^ -1567539260;
					continue;
				case 35u:
					num = (int)((num2 * 526137197) ^ 0x2FCC8EFC);
					continue;
				case 34u:
					Form2.smethod_23((Control)(object)textBox1, "textBox1");
					num = (int)(num2 * 939806630) ^ -387218621;
					continue;
				case 33u:
					Form2.smethod_24((Control)(object)label1, new Size(35, 13));
					num = ((int)num2 * -824393886) ^ -2060655541;
					continue;
				case 32u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label2);
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -1016429203) ^ 0x7E96BB40;
					continue;
				case 31u:
					num = (int)((num2 * 918429808) ^ 0x415967BF);
					continue;
				case 30u:
					Form2.smethod_22((Control)(object)label2, new Point(53, 89));
					num = ((int)num2 * -1113497622) ^ 0x6236298B;
					continue;
				case 29u:
					Form2.smethod_36((Form)(object)this, (FormBorderStyle)1);
					num = (int)(num2 * 1728248290) ^ -270584852;
					continue;
				case 28u:
					Form2.smethod_27((Control)(object)label2, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1384282889) ^ 0x61FEB227;
					continue;
				case 27u:
					Form2.smethod_25((Control)(object)textBox1, 1);
					Form2.smethod_28((Control)(object)textBox1, new KeyPressEventHandler(TextBox1_KeyPress));
					num = (int)(num2 * 1656633636) ^ -1822909144;
					continue;
				case 26u:
					Form2.smethod_23((Control)(object)label2, "label2");
					num = ((int)num2 * -1149794305) ^ -823356136;
					continue;
				case 25u:
					Form2.smethod_21((Control)(object)label2, bool_0: true);
					num = (int)(num2 * 445078116) ^ -1191286038;
					continue;
				case 24u:
					label3 = Form2.smethod_17();
					Form2.smethod_20((Control)(object)this);
					num = (int)((num2 * 852957940) ^ 0x4DB2DE25);
					continue;
				case 23u:
					num = ((int)num2 * -1377264006) ^ -1266659276;
					continue;
				case 22u:
					num = ((int)num2 * -367742520) ^ -2140625055;
					continue;
				case 21u:
					button1 = Form2.smethod_19();
					num = ((int)num2 * -1686296156) ^ -1966240943;
					continue;
				case 20u:
					Form2.smethod_25((Control)(object)label1, 0);
					num = ((int)num2 * -248283787) ^ 0xF86F633;
					continue;
				case 19u:
					num = ((int)num2 * -1803908430) ^ -108394601;
					continue;
				case 18u:
					Form2.smethod_39((Control)(object)this, "Form2");
					num = (int)((num2 * 261835693) ^ 0x6F269A73);
					continue;
				case 17u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)button1);
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)textBox1);
					num = (int)((num2 * 1035931731) ^ 0x5E49AE1E);
					continue;
				case 15u:
					num = ((int)num2 * -742070098) ^ 0x729D74EE;
					continue;
				case 14u:
					Form2.smethod_1((Control)(object)label2, "+N=?");
					num = (int)(num2 * 20082166) ^ -344748428;
					continue;
				case 12u:
					Form2.smethod_21((Control)(object)label3, bool_0: true);
					Form2.smethod_22((Control)(object)label3, new Point(47, 177));
					num = (int)((num2 * 1804156038) ^ 0x380E0D37);
					continue;
				case 11u:
					Form2.smethod_37((Form)(object)this, bool_0: false);
					Form2.smethod_38((Form)(object)this, bool_0: false);
					num = ((int)num2 * -377382390) ^ -1540290612;
					continue;
				case 10u:
					Form2.smethod_21((Control)(object)label1, bool_0: true);
					num = (int)((num2 * 667752803) ^ 0x4AA98874);
					continue;
				case 9u:
					Form2.smethod_24((Control)(object)label2, new Size(188, 73));
					num = (int)((num2 * 924024533) ^ 0x3FD7C223);
					continue;
				case 8u:
					Form2.smethod_33((Form)(object)this, new Size(255, 224));
					num = ((int)num2 * -1788960521) ^ 0x343C6F62;
					continue;
				case 7u:
					num = (int)(num2 * 2017749096) ^ -549669853;
					continue;
				case 6u:
					Form2.smethod_25((Control)(object)label3, 4);
					num = ((int)num2 * -1228732461) ^ -312535711;
					continue;
				case 5u:
					num = ((int)num2 * -1203313505) ^ 0x3553506E;
					continue;
				case 4u:
					Form2.smethod_23((Control)(object)label1, "label1");
					num = ((int)num2 * -1494875249) ^ -1970590514;
					continue;
				case 3u:
					num = ((int)num2 * -1279771460) ^ -1038590080;
					continue;
				case 2u:
					Form2.smethod_23((Control)(object)label3, "label3");
					num = ((int)num2 * -1376721604) ^ 0x78B718B1;
					continue;
				case 1u:
					Form2.smethod_25((Control)(object)button1, 3);
					num = (int)(num2 * 1565190332) ^ -1507916351;
					continue;
				case 0u:
					Form2.smethod_1((Control)(object)button1, "OK");
					num = (int)(num2 * 1553519878) ^ -1542197754;
					continue;
				case 16u:
					break;
				default:
					Form2.smethod_43((Control)(object)this);
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
