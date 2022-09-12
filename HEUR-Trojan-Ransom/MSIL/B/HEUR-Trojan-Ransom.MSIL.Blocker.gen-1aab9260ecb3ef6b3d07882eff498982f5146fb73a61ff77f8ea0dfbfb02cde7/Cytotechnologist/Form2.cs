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
			int num = 1641050926;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDB24603u) % 4u)
				{
				case 3u:
					Form2.smethod_1((Control)(object)label1, "Введите любое число от 0 до 9 включительно.\nВаш соперник уже загадал число (N) из этого\nже диапазона. Если сумма ваших чисел будет\nчетным числом, то первым ход делаете Вы,\nиначе - ваш соперник Компьютер!");
					num = (int)(num2 * 113866794) ^ -69813703;
					continue;
				case 1u:
					InitializeComponent();
					num = ((int)num2 * -1949360464) ^ 0x625260D0;
					continue;
				default:
					return;
				case 2u:
					break;
				case 0u:
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
		bool flag = !char.IsDigit(Form2.smethod_4(e));
		while (true)
		{
			int num = 1956613179;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6CAD06A1u) % 10u)
				{
				case 9u:
					Button1_Click(this, Form2.smethod_6());
					num = (int)((num2 * 818951895) ^ 0x1A97ED6);
					continue;
				case 8u:
					Form2.smethod_1((Control)(object)textBox1, "");
					num = 1487647484;
					continue;
				case 7u:
					Form2.smethod_5(e, bool_0: true);
					num = (int)(num2 * 470249047) ^ -185793053;
					continue;
				case 6u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1601227580;
						num5 = 1601227580;
					}
					else
					{
						num4 = 1824289327;
						num5 = 1824289327;
					}
					num = num4 ^ ((int)num2 * -1952667658);
					continue;
				}
				case 3u:
					num = ((int)num2 * -776555424) ^ 0x772C89C5;
					continue;
				case 2u:
					num = (int)((num2 * 2027347258) ^ 0x34791314);
					continue;
				case 1u:
				{
					int num3;
					if (Form2.smethod_4(e) == '\r')
					{
						num = 395099446;
						num3 = 395099446;
					}
					else
					{
						num = 487554290;
						num3 = 487554290;
					}
					continue;
				}
				case 0u:
					num = ((int)num2 * -261917252) ^ -2029789414;
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

	private void Button1_Click(object sender, EventArgs e)
	{
		bool flag = Form2.smethod_8(Form2.smethod_7((Control)(object)textBox1), "");
		int num3 = default(int);
		int num11 = default(int);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 1568735196;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x586049A6u) % 33u)
				{
				case 32u:
					num = 1757245792;
					continue;
				case 31u:
				{
					int num10 = Form2.smethod_9(rnd, 10);
					Label control_2 = label2;
					string string_ = num10.ToString();
					num3 = num11 + num10;
					Form2.smethod_1((Control)(object)control_2, Form2.smethod_10("+", string_, "=", num3.ToString()));
					int num12;
					int num13;
					if ((num11 + num10) % 2 == 0)
					{
						num12 = 1852538080;
						num13 = 1852538080;
					}
					else
					{
						num12 = 26971470;
						num13 = 26971470;
					}
					num = num12 ^ ((int)num2 * -2119980488);
					continue;
				}
				case 30u:
					num = (int)(num2 * 1427784029) ^ -485441873;
					continue;
				case 29u:
					num = ((int)num2 * -1741700862) ^ -564929949;
					continue;
				case 28u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = false;
					num = (int)(num2 * 1983201125) ^ -140036403;
					continue;
				case 27u:
					Form2.smethod_15((Form)(object)this);
					num = ((int)num2 * -269031284) ^ 0x443D031C;
					continue;
				case 26u:
					this.flag = false;
					num = 668938390;
					continue;
				case 25u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = true;
					num = ((int)num2 * -517893102) ^ -653071125;
					continue;
				case 24u:
					num = 709994845;
					continue;
				case 23u:
					num11 = int.Parse(Form2.smethod_7((Control)(object)textBox1));
					num = (int)(num2 * 1277247685) ^ -854977070;
					continue;
				case 22u:
					num = (int)((num2 * 730920184) ^ 0x24BF53E9);
					continue;
				case 21u:
				{
					int num8;
					int num9;
					if (!flag3)
					{
						num8 = 1525229789;
						num9 = 1525229789;
					}
					else
					{
						num8 = 2015161945;
						num9 = 2015161945;
					}
					num = num8 ^ ((int)num2 * -1482313038);
					continue;
				}
				case 20u:
					num = ((int)num2 * -1358867985) ^ -1636566028;
					continue;
				case 19u:
					Form2.smethod_1((Control)(object)label3, "Поздравляем! Ваш ход первый.");
					num = ((int)num2 * -1354847853) ^ -401311477;
					continue;
				case 18u:
					num = ((int)num2 * -287399368) ^ -171186719;
					continue;
				case 17u:
					Form2.smethod_14(Form2.smethod_11(Form2.smethod_2((Form)(object)this)));
					num = ((int)num2 * -856624226) ^ 0x46CF8BAC;
					continue;
				case 15u:
					num = ((int)num2 * -843832382) ^ -990222013;
					continue;
				case 14u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = 1248912090;
						num7 = 1248912090;
					}
					else
					{
						num6 = 764244620;
						num7 = 764244620;
					}
					num = num6 ^ (int)(num2 * 126083374);
					continue;
				}
				case 13u:
					num = ((int)num2 * -2087821443) ^ -155014855;
					continue;
				case 12u:
				{
					Form control_ = Form2.smethod_2((Form)(object)this);
					num3 = Form2.smethod_12((Control)(object)control_) - 1;
					Form2.smethod_13((Control)(object)control_, num3);
					num = 1978160122;
					continue;
				}
				case 11u:
					num = 1153994401;
					continue;
				case 9u:
				{
					int num4;
					int num5;
					if (!flag2)
					{
						num4 = -391439405;
						num5 = -391439405;
					}
					else
					{
						num4 = -846805436;
						num5 = -846805436;
					}
					num = num4 ^ (int)(num2 * 53219702);
					continue;
				}
				case 8u:
					num = (int)(num2 * 1895346509) ^ -453120120;
					continue;
				case 7u:
					num = 506053226;
					continue;
				case 6u:
					(Form2.smethod_2((Form)(object)this) as Form3).Button_Continue();
					num = ((int)num2 * -67688256) ^ -1873658585;
					continue;
				case 5u:
					num = ((int)num2 * -1588712773) ^ -552252311;
					continue;
				case 4u:
					num = ((int)num2 * -1267142856) ^ 0x207515AF;
					continue;
				case 3u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).StartGame();
					num = ((int)num2 * -2043183355) ^ 0x7CAF56DC;
					continue;
				case 2u:
					flag3 = num3 > 1;
					num = ((int)num2 * -342127722) ^ -1228765200;
					continue;
				case 1u:
					flag2 = this.flag;
					num = ((int)num2 * -572065554) ^ -1099389107;
					continue;
				case 0u:
					Form2.smethod_1((Control)(object)label3, "Первым ход делает Компьютер.");
					num = ((int)num2 * -595512489) ^ 0x73B4E13F;
					continue;
				default:
					return;
				case 16u:
					break;
				case 10u:
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
			goto IL_004d;
		}
		goto IL_0086;
		IL_004d:
		int num = 1941549864;
		goto IL_0052;
		IL_0052:
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x2E1BF929u) % 6u)
			{
			case 5u:
				Form2.smethod_16((IDisposable)components);
				num = (int)((num2 * 1287426503) ^ 0x4770FAB2);
				continue;
			case 4u:
				num = (int)(num2 * 1728205862) ^ -24359719;
				continue;
			case 2u:
				((Form)this).Dispose(disposing);
				num = 409707796;
				continue;
			case 0u:
				break;
			default:
				return;
			case 3u:
				goto IL_007b;
			case 1u:
				return;
			}
			break;
			IL_007b:
			if (components != null)
			{
				num = 1251983960;
				num3 = 1251983960;
				continue;
			}
			goto IL_0086;
		}
		goto IL_004d;
		IL_0086:
		num = 885044113;
		num3 = 885044113;
		goto IL_0052;
	}

	private void InitializeComponent()
	{
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Expected O, but got Unknown
		//IL_07d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07db: Expected O, but got Unknown
		while (true)
		{
			int num = -2034687502;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDED159A6u) % 69u)
				{
				case 67u:
					num = (int)((num2 * 486927984) ^ 0x6B5840A1);
					continue;
				case 66u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)textBox1);
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label2);
					num = (int)((num2 * 133222333) ^ 0x5C7C5E84);
					continue;
				case 65u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -795761009) ^ 0x3F769DA8;
					continue;
				case 64u:
					Form2.smethod_39((Control)(object)this, "Form2");
					num = (int)((num2 * 629144709) ^ 0x41F6DB36);
					continue;
				case 63u:
					Form2.smethod_27((Control)(object)textBox1, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1173533585) ^ -1197307533;
					continue;
				case 62u:
					Form2.smethod_22((Control)(object)button1, new Point(86, 193));
					Form2.smethod_23((Control)(object)button1, "button1");
					num = (int)((num2 * 1703798362) ^ 0x5812D126);
					continue;
				case 61u:
					num = ((int)num2 * -1325088350) ^ 0x74F8F7FB;
					continue;
				case 60u:
					Form2.smethod_25((Control)(object)label3, 4);
					num = (int)(num2 * 164255237) ^ -118977206;
					continue;
				case 59u:
					Form2.smethod_24((Control)(object)label3, new Size(0, 13));
					num = (int)((num2 * 1775592920) ^ 0x185EACFE);
					continue;
				case 58u:
					Form2.smethod_27((Control)(object)label2, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1589009370) ^ -1920522894;
					continue;
				case 57u:
					num = ((int)num2 * -2046873317) ^ 0x3EAAAADC;
					continue;
				case 56u:
					Form2.smethod_1((Control)(object)label2, "+N=?");
					num = ((int)num2 * -1931880862) ^ -518341814;
					continue;
				case 55u:
					num = ((int)num2 * -997141075) ^ 0x34547F6D;
					continue;
				case 54u:
					Form2.smethod_22((Control)(object)label2, new Point(53, 89));
					num = (int)((num2 * 1166483765) ^ 0x594E4F0B);
					continue;
				case 53u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label3);
					num = (int)((num2 * 589923151) ^ 0x5B966958);
					continue;
				case 52u:
					Form2.smethod_38((Form)(object)this, bool_0: false);
					num = (int)(num2 * 919490289) ^ -1862441031;
					continue;
				case 51u:
					Form2.smethod_30((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)(num2 * 176673772) ^ -1913632087;
					continue;
				case 50u:
					Form2.smethod_37((Form)(object)this, bool_0: false);
					num = ((int)num2 * -2116402516) ^ -171314506;
					continue;
				case 49u:
					Form2.smethod_32((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -693832924) ^ 0x482BB872;
					continue;
				case 48u:
					Form2.smethod_22((Control)(object)textBox1, new Point(24, 86));
					num = ((int)num2 * -1243286974) ^ -1263519773;
					continue;
				case 47u:
					num = (int)(num2 * 1954392102) ^ -2083018663;
					continue;
				case 46u:
					Form2.smethod_25((Control)(object)label1, 0);
					num = ((int)num2 * -1431486101) ^ 0x31F67FA4;
					continue;
				case 45u:
					Form2.smethod_23((Control)(object)label3, "label3");
					num = (int)((num2 * 1209184392) ^ 0x30771433);
					continue;
				case 44u:
					Form2.smethod_43((Control)(object)this);
					num = (int)(num2 * 2005806021) ^ -1481363182;
					continue;
				case 43u:
					Form2.smethod_1((Control)(object)button1, "OK");
					num = ((int)num2 * -211840863) ^ -422428618;
					continue;
				case 42u:
					Form2.smethod_23((Control)(object)textBox1, "textBox1");
					num = (int)(num2 * 1114262318) ^ -1514636214;
					continue;
				case 41u:
					Form2.smethod_1((Control)(object)label1, "label1");
					num = ((int)num2 * -2023293870) ^ -135990346;
					continue;
				case 40u:
					num = ((int)num2 * -1259909732) ^ -1454783556;
					continue;
				case 39u:
					num = (int)(num2 * 360893275) ^ -785265632;
					continue;
				case 38u:
					Form2.smethod_41((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
					num = ((int)num2 * -230772185) ^ -1046821458;
					continue;
				case 37u:
					Form2.smethod_22((Control)(object)label1, new Point(10, 10));
					num = ((int)num2 * -150773074) ^ 0x1A64A4DF;
					continue;
				case 36u:
					Form2.smethod_40((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1877201217) ^ -1710147595;
					continue;
				case 35u:
					num = ((int)num2 * -11646771) ^ -1984679530;
					continue;
				case 34u:
					Form2.smethod_36((Form)(object)this, (FormBorderStyle)1);
					num = (int)(num2 * 399249452) ^ -841573082;
					continue;
				case 33u:
					Form2.smethod_24((Control)(object)textBox1, new Size(42, 80));
					num = (int)(num2 * 627216209) ^ -2092359696;
					continue;
				case 32u:
					Form2.smethod_21((Control)(object)label2, bool_0: true);
					num = ((int)num2 * -1496516331) ^ -271008551;
					continue;
				case 31u:
					num = (int)((num2 * 2049366048) ^ 0x25076DA);
					continue;
				case 30u:
					label1 = Form2.smethod_17();
					textBox1 = Form2.smethod_18();
					label2 = Form2.smethod_17();
					button1 = Form2.smethod_19();
					label3 = Form2.smethod_17();
					Form2.smethod_20((Control)(object)this);
					num = (int)(num2 * 1111500077) ^ -1466979014;
					continue;
				case 29u:
					Form2.smethod_23((Control)(object)label2, "label2");
					num = ((int)num2 * -1691025502) ^ -1298401820;
					continue;
				case 28u:
					Form2.smethod_24((Control)(object)button1, new Size(73, 23));
					num = ((int)num2 * -712530716) ^ -1673210967;
					continue;
				case 27u:
					num = ((int)num2 * -2094906211) ^ -1364407383;
					continue;
				case 26u:
					Form2.smethod_33((Form)(object)this, new Size(255, 224));
					num = (int)((num2 * 1414035111) ^ 0x14A074D1);
					continue;
				case 25u:
					Form2.smethod_25((Control)(object)button1, 3);
					num = (int)((num2 * 1820887573) ^ 0x3C504988);
					continue;
				case 24u:
					num = ((int)num2 * -839844364) ^ -1247523064;
					continue;
				case 23u:
					num = ((int)num2 * -2140996180) ^ 0x7F943C52;
					continue;
				case 22u:
					Form2.smethod_29((ButtonBase)(object)button1, bool_0: true);
					num = (int)((num2 * 1764614899) ^ 0x26533884);
					continue;
				case 21u:
					Form2.smethod_24((Control)(object)label2, new Size(188, 73));
					num = (int)(num2 * 1240784053) ^ -1395171256;
					continue;
				case 20u:
					Form2.smethod_23((Control)(object)label1, "label1");
					num = (int)(num2 * 1494516194) ^ -1332145460;
					continue;
				case 19u:
					num = (int)((num2 * 505709167) ^ 0x35B2D167);
					continue;
				case 18u:
					Form2.smethod_25((Control)(object)label2, 2);
					num = (int)((num2 * 1428057136) ^ 0x26D75424);
					continue;
				case 17u:
					Form2.smethod_24((Control)(object)label1, new Size(35, 13));
					num = (int)(num2 * 1273938580) ^ -328442502;
					continue;
				case 16u:
					num = (int)(num2 * 1343553227) ^ -1940353558;
					continue;
				case 15u:
					Form2.smethod_21((Control)(object)label1, bool_0: true);
					num = (int)((num2 * 447411440) ^ 0x5720DAD9);
					continue;
				case 14u:
					Form2.smethod_31((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -348582995) ^ 0x1A31F209;
					continue;
				case 13u:
					Form2.smethod_22((Control)(object)label3, new Point(47, 177));
					num = ((int)num2 * -1383769846) ^ 0x2E0DFA7A;
					continue;
				case 12u:
					num = ((int)num2 * -1034074917) ^ 0x249CD061;
					continue;
				case 11u:
					num = (int)(num2 * 918060107) ^ -466418586;
					continue;
				case 10u:
					num = (int)(num2 * 2077149640) ^ -1109427344;
					continue;
				case 8u:
					Form2.smethod_1((Control)(object)this, "Жеребьёвка");
					num = ((int)num2 * -869124352) ^ -1461043125;
					continue;
				case 7u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label1);
					num = (int)((num2 * 1009227675) ^ 0xE62B2C4);
					continue;
				case 6u:
					num = (int)((num2 * 97108769) ^ 0x7466F357);
					continue;
				case 5u:
					Form2.smethod_21((Control)(object)label3, bool_0: true);
					num = ((int)num2 * -776013574) ^ -1588358505;
					continue;
				case 4u:
					num = ((int)num2 * -1192048267) ^ -528710100;
					continue;
				case 3u:
					num = (int)((num2 * 1521553267) ^ 0x25B24BE3);
					continue;
				case 2u:
					num = ((int)num2 * -188086188) ^ -1825393016;
					continue;
				case 1u:
					Form2.smethod_42((Control)(object)this, bool_0: false);
					num = (int)((num2 * 1533472066) ^ 0x7DB98D05);
					continue;
				case 0u:
					Form2.smethod_25((Control)(object)textBox1, 1);
					Form2.smethod_28((Control)(object)textBox1, new KeyPressEventHandler(TextBox1_KeyPress));
					num = ((int)num2 * -309539504) ^ -1795361165;
					continue;
				default:
					return;
				case 9u:
					break;
				case 68u:
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
