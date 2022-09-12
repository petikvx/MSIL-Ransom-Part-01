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
			int num = 1949588887;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1564ED46u) % 3u)
				{
				case 1u:
					goto IL_000e;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_000e:
				num = (int)((num2 * 601677106) ^ 0x1EFD20C5);
			}
		}
	}

	private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		bool flag = !char.IsDigit(Form2.smethod_4(e));
		bool flag2 = default(bool);
		while (true)
		{
			int num = -860750567;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE3C92008u) % 9u)
				{
				case 8u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = 964046924;
						num6 = 964046924;
					}
					else
					{
						num5 = 1641502218;
						num6 = 1641502218;
					}
					num = num5 ^ ((int)num2 * -2097553981);
					continue;
				}
				case 7u:
					flag2 = Form2.smethod_4(e) == '\r';
					num = -348559455;
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1258235435;
						num4 = 1258235435;
					}
					else
					{
						num3 = 1720029344;
						num4 = 1720029344;
					}
					num = num3 ^ ((int)num2 * -255502351);
					continue;
				}
				case 4u:
					Form2.smethod_1((Control)(object)textBox1, "");
					num = -400176227;
					continue;
				case 2u:
					num = (int)((num2 * 1856951060) ^ 0x35D8AF55);
					continue;
				case 1u:
					Form2.smethod_5(e, bool_0: true);
					num = (int)((num2 * 1394585415) ^ 0x24D89A5D);
					continue;
				case 0u:
					Button1_Click(this, Form2.smethod_6());
					num = (int)((num2 * 1366415091) ^ 0x79F7F36C);
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
		bool flag2 = default(bool);
		int num7 = default(int);
		int num6 = default(int);
		bool flag3 = default(bool);
		int num5 = default(int);
		bool flag4 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -381001588;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xABB26A42u) % 34u)
				{
				case 33u:
					num = -804585322;
					continue;
				case 32u:
					flag2 = num7 > 1;
					num = (int)(num2 * 1101360796) ^ -707172842;
					continue;
				case 31u:
					num = ((int)num2 * -67020412) ^ -20286897;
					continue;
				case 30u:
					num6 = int.Parse(Form2.smethod_7((Control)(object)textBox1));
					num = ((int)num2 * -892023492) ^ 0x564E7797;
					continue;
				case 29u:
					num = (int)((num2 * 377037771) ^ 0x44D9BDAC);
					continue;
				case 28u:
					Form2.smethod_15((Form)(object)this);
					num = (int)(num2 * 1605684574) ^ -1581753955;
					continue;
				case 27u:
					num = ((int)num2 * -912329030) ^ 0x49F62707;
					continue;
				case 26u:
					flag3 = (num6 + num5) % 2 == 0;
					num = (int)((num2 * 1193256697) ^ 0x318A4919);
					continue;
				case 25u:
					num = ((int)num2 * -91519678) ^ -520039568;
					continue;
				case 24u:
					(Form2.smethod_2((Form)(object)this) as Form3).Button_Continue();
					num = (int)(num2 * 1617643038) ^ -799934395;
					continue;
				case 23u:
				{
					num5 = Form2.smethod_9(rnd, 10);
					Label control_ = label2;
					string string_ = num5.ToString();
					num7 = num6 + num5;
					Form2.smethod_1((Control)(object)control_, Form2.smethod_10("+", string_, "=", num7.ToString()));
					num = ((int)num2 * -1117696500) ^ -2038593442;
					continue;
				}
				case 22u:
					num = (int)((num2 * 1652114869) ^ 0x3E4D1A5D);
					continue;
				case 21u:
				{
					int num12;
					int num13;
					if (!flag4)
					{
						num12 = -1247468090;
						num13 = -1247468090;
					}
					else
					{
						num12 = -970850221;
						num13 = -970850221;
					}
					num = num12 ^ (int)(num2 * 1916195824);
					continue;
				}
				case 20u:
					flag4 = Form2.smethod_8(Form2.smethod_7((Control)(object)textBox1), "");
					num = ((int)num2 * -720837217) ^ -443935013;
					continue;
				case 19u:
				{
					Form control_2 = Form2.smethod_2((Form)(object)this);
					num7 = Form2.smethod_12((Control)(object)control_2) - 1;
					Form2.smethod_13((Control)(object)control_2, num7);
					num = -1229400953;
					continue;
				}
				case 18u:
					Form2.smethod_1((Control)(object)label3, "Первым ход делает Компьютер.");
					num = (int)(num2 * 542469418) ^ -1727797512;
					continue;
				case 17u:
				{
					int num10;
					int num11;
					if (!flag)
					{
						num10 = 1755006968;
						num11 = 1755006968;
					}
					else
					{
						num10 = 293645628;
						num11 = 293645628;
					}
					num = num10 ^ ((int)num2 * -1550739670);
					continue;
				}
				case 16u:
					num = -579255705;
					continue;
				case 15u:
					num = -440859601;
					continue;
				case 13u:
					num = (int)((num2 * 2079814786) ^ 0x4FA7906B);
					continue;
				case 12u:
					Form2.smethod_1((Control)(object)label3, "Поздравляем! Ваш ход первый.");
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = true;
					num = ((int)num2 * -1909519391) ^ -2109743132;
					continue;
				case 11u:
				{
					int num8;
					int num9;
					if (flag3)
					{
						num8 = 308967088;
						num9 = 308967088;
					}
					else
					{
						num8 = 890075874;
						num9 = 890075874;
					}
					num = num8 ^ (int)(num2 * 871310968);
					continue;
				}
				case 10u:
					num = ((int)num2 * -1832117791) ^ 0x16655C56;
					continue;
				case 9u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).StartGame();
					num = ((int)num2 * -1223901111) ^ 0x6DE75723;
					continue;
				case 8u:
				{
					int num3;
					int num4;
					if (flag2)
					{
						num3 = -1687594333;
						num4 = -1687594333;
					}
					else
					{
						num3 = -882351150;
						num4 = -882351150;
					}
					num = num3 ^ (int)(num2 * 1816040748);
					continue;
				}
				case 7u:
					num = ((int)num2 * -1425088255) ^ 0xBA0A90A;
					continue;
				case 6u:
					num = -406288108;
					continue;
				case 5u:
					flag = this.flag;
					num = ((int)num2 * -878460070) ^ 0x7A7018DD;
					continue;
				case 4u:
					this.flag = false;
					num = -2115633462;
					continue;
				case 3u:
					Form2.smethod_14(Form2.smethod_11(Form2.smethod_2((Form)(object)this)));
					num = ((int)num2 * -710612857) ^ 0x7B3CE2A8;
					continue;
				case 2u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = false;
					num = ((int)num2 * -1475784900) ^ 0x135DFCC7;
					continue;
				case 1u:
					num = ((int)num2 * -2136608812) ^ 0x770C1B8A;
					continue;
				default:
					return;
				case 0u:
					break;
				case 14u:
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
			int num = -1296166031;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xF606C8C1u) % 10u)
				{
				case 9u:
					if (components != null)
					{
						num = -1056834516;
						num3 = -1056834516;
						continue;
					}
					goto IL_001d;
				case 8u:
					num = (int)((num2 * 1437240880) ^ 0x24632E41);
					continue;
				case 7u:
					num = (int)(num2 * 396871047) ^ -856686023;
					continue;
				case 5u:
					((Form)this).Dispose(disposing);
					num = -847082867;
					continue;
				case 4u:
					Form2.smethod_16((IDisposable)components);
					num = ((int)num2 * -1403264122) ^ -1874918578;
					continue;
				case 3u:
					num = ((int)num2 * -419904016) ^ 0x405F212;
					continue;
				case 2u:
					if (disposing)
					{
						num = ((int)num2 * -2020251009) ^ -1991069692;
						continue;
					}
					goto IL_001d;
				case 1u:
					num = (int)(num2 * 12351689) ^ -390455944;
					continue;
				default:
					return;
				case 0u:
					break;
				case 6u:
					return;
					IL_001d:
					num = -425759902;
					num3 = -425759902;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected O, but got Unknown
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected O, but got Unknown
		while (true)
		{
			int num = 513885107;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x43559095u) % 62u)
				{
				case 61u:
					Form2.smethod_1((Control)(object)label1, "label1");
					num = (int)(num2 * 1919578870) ^ -1999645057;
					continue;
				case 60u:
					num = (int)(num2 * 1225020681) ^ -20569465;
					continue;
				case 59u:
					Form2.smethod_25((Control)(object)textBox1, 1);
					num = ((int)num2 * -288798201) ^ 0xA0F627B;
					continue;
				case 58u:
					num = ((int)num2 * -964988793) ^ 0x286B3B8;
					continue;
				case 57u:
					Form2.smethod_43((Control)(object)this);
					num = (int)((num2 * 2084738337) ^ 0x53E1F1FD);
					continue;
				case 56u:
					num = (int)(num2 * 2071511744) ^ -542880890;
					continue;
				case 55u:
					Form2.smethod_21((Control)(object)label2, bool_0: true);
					Form2.smethod_27((Control)(object)label2, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form2.smethod_22((Control)(object)label2, new Point(53, 89));
					num = ((int)num2 * -1962358189) ^ -172783579;
					continue;
				case 54u:
					Form2.smethod_40((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1738983647) ^ 0x50884B3E;
					continue;
				case 53u:
					Form2.smethod_30((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -1513259971) ^ -554150742;
					continue;
				case 52u:
					Form2.smethod_25((Control)(object)button1, 3);
					num = ((int)num2 * -286134802) ^ 0x44211EBF;
					continue;
				case 51u:
					num = ((int)num2 * -413650462) ^ -1762462796;
					continue;
				case 50u:
					Form2.smethod_24((Control)(object)label2, new Size(188, 73));
					num = (int)((num2 * 1366795874) ^ 0x5CE5C852);
					continue;
				case 49u:
					Form2.smethod_22((Control)(object)label1, new Point(10, 10));
					num = ((int)num2 * -36778735) ^ 0x10B5B6D8;
					continue;
				case 48u:
					button1 = Form2.smethod_19();
					num = (int)((num2 * 584660794) ^ 0x798B3DB3);
					continue;
				case 47u:
					Form2.smethod_28((Control)(object)textBox1, new KeyPressEventHandler(TextBox1_KeyPress));
					num = ((int)num2 * -872292323) ^ 0x4CAC87F2;
					continue;
				case 46u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label3);
					num = ((int)num2 * -514851985) ^ -1633087384;
					continue;
				case 44u:
					label1 = Form2.smethod_17();
					num = (int)(num2 * 1396745155) ^ -1545102854;
					continue;
				case 43u:
					num = (int)((num2 * 2036403728) ^ 0x480AC038);
					continue;
				case 42u:
					Form2.smethod_22((Control)(object)label3, new Point(47, 177));
					num = ((int)num2 * -1557474334) ^ 0x3E83B7BD;
					continue;
				case 41u:
					Form2.smethod_23((Control)(object)label2, "label2");
					num = (int)((num2 * 477432276) ^ 0x2390C305);
					continue;
				case 40u:
					num = ((int)num2 * -485074311) ^ -1620408476;
					continue;
				case 39u:
					Form2.smethod_39((Control)(object)this, "Form2");
					num = ((int)num2 * -30118877) ^ -591462204;
					continue;
				case 38u:
					Form2.smethod_41((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
					num = ((int)num2 * -1099467925) ^ 0x7D41F82A;
					continue;
				case 37u:
					Form2.smethod_37((Form)(object)this, bool_0: false);
					num = (int)(num2 * 224813775) ^ -1352724496;
					continue;
				case 36u:
					Form2.smethod_32((ContainerControl)(object)this, (AutoScaleMode)1);
					Form2.smethod_33((Form)(object)this, new Size(255, 224));
					num = ((int)num2 * -99487158) ^ -384519881;
					continue;
				case 35u:
					Form2.smethod_25((Control)(object)label2, 2);
					num = (int)(num2 * 258757522) ^ -1235851678;
					continue;
				case 34u:
					Form2.smethod_38((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1519306142) ^ -538700842;
					continue;
				case 33u:
					Form2.smethod_24((Control)(object)textBox1, new Size(42, 80));
					num = (int)((num2 * 179927634) ^ 0x5341E60);
					continue;
				case 32u:
					num = (int)((num2 * 2050757473) ^ 0x45B10016);
					continue;
				case 31u:
					num = (int)((num2 * 744458574) ^ 0x40EFF75D);
					continue;
				case 30u:
					Form2.smethod_27((Control)(object)textBox1, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1729095394) ^ 0x363FB713;
					continue;
				case 29u:
					Form2.smethod_22((Control)(object)textBox1, new Point(24, 86));
					num = ((int)num2 * -1531104042) ^ -194090380;
					continue;
				case 28u:
					Form2.smethod_23((Control)(object)label3, "label3");
					num = ((int)num2 * -1355481005) ^ -1768392334;
					continue;
				case 27u:
					Form2.smethod_42((Control)(object)this, bool_0: false);
					num = ((int)num2 * -1751640433) ^ -1253548088;
					continue;
				case 26u:
					Form2.smethod_24((Control)(object)button1, new Size(73, 23));
					num = ((int)num2 * -7064450) ^ 0x245B5651;
					continue;
				case 25u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label2);
					num = ((int)num2 * -624910397) ^ 0x20BF6BB2;
					continue;
				case 24u:
					num = (int)(num2 * 1789440365) ^ -404915806;
					continue;
				case 23u:
					Form2.smethod_24((Control)(object)label3, new Size(0, 13));
					num = ((int)num2 * -557906559) ^ -975225885;
					continue;
				case 22u:
					Form2.smethod_23((Control)(object)label1, "label1");
					num = (int)((num2 * 1425937633) ^ 0x342963CE);
					continue;
				case 21u:
					Form2.smethod_24((Control)(object)label1, new Size(35, 13));
					Form2.smethod_25((Control)(object)label1, 0);
					num = (int)((num2 * 1026053608) ^ 0x56AED758);
					continue;
				case 20u:
					Form2.smethod_31((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)(num2 * 1749965254) ^ -248763539;
					continue;
				case 19u:
					Form2.smethod_29((ButtonBase)(object)button1, bool_0: true);
					num = (int)((num2 * 1022057461) ^ 0x5AA6342D);
					continue;
				case 18u:
					Form2.smethod_21((Control)(object)label3, bool_0: true);
					num = (int)(num2 * 1134042669) ^ -702620583;
					continue;
				case 17u:
					num = (int)(num2 * 978510255) ^ -1747911285;
					continue;
				case 16u:
					num = (int)(num2 * 1971401163) ^ -2051713907;
					continue;
				case 15u:
					Form2.smethod_21((Control)(object)label1, bool_0: true);
					num = (int)(num2 * 1765401738) ^ -2107179043;
					continue;
				case 14u:
					Form2.smethod_1((Control)(object)button1, "OK");
					num = ((int)num2 * -376837320) ^ 0x3159F96A;
					continue;
				case 13u:
					Form2.smethod_1((Control)(object)label2, "+N=?");
					Form2.smethod_22((Control)(object)button1, new Point(86, 193));
					Form2.smethod_23((Control)(object)button1, "button1");
					num = ((int)num2 * -63637894) ^ -917769011;
					continue;
				case 12u:
					num = ((int)num2 * -1111710877) ^ -1172221979;
					continue;
				case 11u:
					Form2.smethod_25((Control)(object)label3, 4);
					num = (int)(num2 * 1866617999) ^ -951047464;
					continue;
				case 10u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label1);
					Form2.smethod_36((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -1175718406) ^ 0x378434FE;
					continue;
				case 9u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -58947047) ^ 0x5FE18E3A;
					continue;
				case 7u:
					Form2.smethod_23((Control)(object)textBox1, "textBox1");
					num = ((int)num2 * -521659334) ^ 0x7928F0E3;
					continue;
				case 6u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)textBox1);
					num = (int)((num2 * 1861787418) ^ 0x12028096);
					continue;
				case 5u:
					textBox1 = Form2.smethod_18();
					label2 = Form2.smethod_17();
					num = (int)(num2 * 1076802933) ^ -795024738;
					continue;
				case 4u:
					label3 = Form2.smethod_17();
					Form2.smethod_20((Control)(object)this);
					num = (int)((num2 * 265841161) ^ 0x43C93F4A);
					continue;
				case 3u:
					Form2.smethod_1((Control)(object)this, "Жеребьёвка");
					num = ((int)num2 * -1710973673) ^ -2087832926;
					continue;
				case 2u:
					num = (int)(num2 * 380065033) ^ -1570473857;
					continue;
				case 1u:
					num = ((int)num2 * -1104258413) ^ 0x608C73D;
					continue;
				case 0u:
					num = ((int)num2 * -1677396268) ^ 0x24438C8D;
					continue;
				default:
					return;
				case 45u:
					break;
				case 8u:
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
