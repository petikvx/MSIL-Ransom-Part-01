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
			int num = -1398419762;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8947966Fu) % 7u)
				{
				case 6u:
					Form2.smethod_1((Control)(object)label1, "Введите любое число от 0 до 9 включительно.\nВаш соперник уже загадал число (N) из этого\nже диапазона. Если сумма ваших чисел будет\nчетным числом, то первым ход делаете Вы,\nиначе - ваш соперник Компьютер!");
					num = ((int)num2 * -1789517007) ^ -1341836292;
					continue;
				case 4u:
					num = (int)(num2 * 1818112116) ^ -2123670280;
					continue;
				case 2u:
					num = ((int)num2 * -1060395427) ^ 0x13F27F19;
					continue;
				case 1u:
					num = ((int)num2 * -497983933) ^ -1577350042;
					continue;
				case 0u:
					InitializeComponent();
					num = (int)((num2 * 1354332998) ^ 0x267121EA);
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

	private void Form2_FormClosed(object sender, FormClosedEventArgs e)
	{
		Form2.smethod_3((Control)(object)Form2.smethod_2((Form)(object)this), bool_0: true);
	}

	private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		while (true)
		{
			int num = 1120264208;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEA17335u) % 11u)
				{
				case 10u:
					num = (int)(num2 * 1524214247) ^ -166522325;
					continue;
				case 9u:
				{
					int num4;
					int num5;
					if (char.IsDigit(Form2.smethod_4(e)))
					{
						num4 = 1857847946;
						num5 = 1857847946;
					}
					else
					{
						num4 = 1572818719;
						num5 = 1572818719;
					}
					num = num4 ^ (int)(num2 * 933031665);
					continue;
				}
				case 7u:
					num = (int)((num2 * 1124666910) ^ 0x6F93998F);
					continue;
				case 6u:
					Form2.smethod_1((Control)(object)textBox1, "");
					num = 1763588919;
					continue;
				case 4u:
					Form2.smethod_5(e, bool_0: true);
					num = ((int)num2 * -12281258) ^ -1607814762;
					continue;
				case 3u:
					num = ((int)num2 * -1175309398) ^ 0x4631A56F;
					continue;
				case 2u:
					Button1_Click(this, Form2.smethod_6());
					num = ((int)num2 * -1904962189) ^ 0x3F3B9B2E;
					continue;
				case 1u:
				{
					int num3;
					if (Form2.smethod_4(e) == '\r')
					{
						num = 862051976;
						num3 = 862051976;
					}
					else
					{
						num = 1993671687;
						num3 = 1993671687;
					}
					continue;
				}
				case 0u:
					num = (int)((num2 * 1413189041) ^ 0x68EBEBBD);
					continue;
				default:
					return;
				case 8u:
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
		int num3 = default(int);
		bool flag2 = default(bool);
		bool flag = default(bool);
		int num4 = default(int);
		int num5 = default(int);
		while (true)
		{
			int num = 2057293324;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5926FD61u) % 28u)
				{
				case 27u:
					num3 = Form2.smethod_9(rnd, 10);
					num = (int)((num2 * 1593597089) ^ 0x68E1DE0B);
					continue;
				case 26u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).StartGame();
					num = ((int)num2 * -1328924402) ^ 0x497CD8C4;
					continue;
				case 25u:
					flag2 = Form2.smethod_8(Form2.smethod_7((Control)(object)textBox1), "");
					num = ((int)num2 * -2022173470) ^ -1373779592;
					continue;
				case 24u:
					Form2.smethod_14(Form2.smethod_11(Form2.smethod_2((Form)(object)this)));
					num = ((int)num2 * -1440091327) ^ -1076540837;
					continue;
				case 23u:
				{
					int num10;
					int num11;
					if (!flag2)
					{
						num10 = 1223223408;
						num11 = 1223223408;
					}
					else
					{
						num10 = 956081635;
						num11 = 956081635;
					}
					num = num10 ^ ((int)num2 * -649086622);
					continue;
				}
				case 22u:
					num = 1023523862;
					continue;
				case 21u:
					num = ((int)num2 * -1002395301) ^ -1163359436;
					continue;
				case 20u:
				{
					int num12;
					int num13;
					if (this.flag)
					{
						num12 = -1716080653;
						num13 = -1716080653;
					}
					else
					{
						num12 = -219907207;
						num13 = -219907207;
					}
					num = num12 ^ (int)(num2 * 1450933491);
					continue;
				}
				case 19u:
					num = ((int)num2 * -166011962) ^ 0x21E83D27;
					continue;
				case 18u:
					(Form2.smethod_2((Form)(object)this) as Form3).Button_Continue();
					num = (int)(num2 * 559960860) ^ -1101233447;
					continue;
				case 17u:
					flag = (num4 + num3) % 2 == 0;
					num = (int)(num2 * 711645961) ^ -1310778313;
					continue;
				case 16u:
				{
					int num8;
					int num9;
					if (num5 > 1)
					{
						num8 = -680229957;
						num9 = -680229957;
					}
					else
					{
						num8 = -1885596913;
						num9 = -1885596913;
					}
					num = num8 ^ ((int)num2 * -678827635);
					continue;
				}
				case 15u:
					this.flag = false;
					num = 995569732;
					continue;
				case 14u:
					num = 312073015;
					continue;
				case 13u:
					Form2.smethod_15((Form)(object)this);
					num = (int)((num2 * 924261020) ^ 0x7E56E104);
					continue;
				case 12u:
					num = 1565068320;
					continue;
				case 10u:
					num4 = int.Parse(Form2.smethod_7((Control)(object)textBox1));
					num = ((int)num2 * -1132037441) ^ -1412897356;
					continue;
				case 9u:
				{
					Form control_2 = Form2.smethod_2((Form)(object)this);
					num5 = Form2.smethod_12((Control)(object)control_2) - 1;
					Form2.smethod_13((Control)(object)control_2, num5);
					num = 1022027125;
					continue;
				}
				case 8u:
					Form2.smethod_1((Control)(object)label3, "Поздравляем! Ваш ход первый.");
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = true;
					num = ((int)num2 * -29505462) ^ -1832529858;
					continue;
				case 7u:
				{
					int num6;
					int num7;
					if (!flag)
					{
						num6 = 193790499;
						num7 = 193790499;
					}
					else
					{
						num6 = 248983089;
						num7 = 248983089;
					}
					num = num6 ^ (int)(num2 * 881463456);
					continue;
				}
				case 6u:
					num = 1565068320;
					continue;
				case 5u:
					num = (int)((num2 * 820164458) ^ 0xF2D8E85);
					continue;
				case 4u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = false;
					num = ((int)num2 * -1514671113) ^ -1968301818;
					continue;
				case 3u:
					num = ((int)num2 * -1399150809) ^ -1099502149;
					continue;
				case 2u:
					Form2.smethod_1((Control)(object)label3, "Первым ход делает Компьютер.");
					num = (int)((num2 * 121021012) ^ 0x26C2C226);
					continue;
				case 1u:
				{
					Label control_ = label2;
					string string_ = num3.ToString();
					num5 = num4 + num3;
					Form2.smethod_1((Control)(object)control_, Form2.smethod_10("+", string_, "=", num5.ToString()));
					num = ((int)num2 * -540248530) ^ -674810090;
					continue;
				}
				default:
					return;
				case 0u:
					break;
				case 11u:
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
			int num = -794980665;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x9A48131Au) % 9u)
				{
				case 8u:
					num = ((int)num2 * -1382719600) ^ 0x3DFCFBFA;
					continue;
				case 5u:
					num = (int)((num2 * 184884317) ^ 0x5914FD08);
					continue;
				case 4u:
					((Form)this).Dispose(disposing);
					num = -1488255290;
					continue;
				case 3u:
					num = ((int)num2 * -312086242) ^ -846553176;
					continue;
				case 2u:
					if (disposing)
					{
						num = ((int)num2 * -1951624327) ^ -1549912883;
						continue;
					}
					goto IL_0062;
				case 1u:
					if (components != null)
					{
						num = -30568217;
						num3 = -30568217;
						continue;
					}
					goto IL_0062;
				case 0u:
					Form2.smethod_16((IDisposable)components);
					num = ((int)num2 * -1688909543) ^ 0x537536F6;
					continue;
				default:
					return;
				case 7u:
					break;
				case 6u:
					return;
					IL_0062:
					num = -1941078556;
					num3 = -1941078556;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_059d: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a7: Expected O, but got Unknown
		label1 = Form2.smethod_17();
		while (true)
		{
			int num = -2052411879;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x849FD947u) % 57u)
				{
				case 56u:
					Form2.smethod_41((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
					num = (int)((num2 * 1153484517) ^ 0x3441823B);
					continue;
				case 55u:
					Form2.smethod_25((Control)(object)textBox1, 1);
					num = ((int)num2 * -1954525832) ^ -661604605;
					continue;
				case 54u:
					Form2.smethod_21((Control)(object)label2, bool_0: true);
					num = ((int)num2 * -722219957) ^ -1328606395;
					continue;
				case 53u:
					label3 = Form2.smethod_17();
					num = (int)(num2 * 329327037) ^ -1690247899;
					continue;
				case 52u:
					num = ((int)num2 * -1752091479) ^ 0x63073BAD;
					continue;
				case 51u:
					Form2.smethod_21((Control)(object)label3, bool_0: true);
					Form2.smethod_22((Control)(object)label3, new Point(47, 177));
					num = (int)((num2 * 1345705255) ^ 0x4C1B6150);
					continue;
				case 50u:
					Form2.smethod_1((Control)(object)label2, "+N=?");
					Form2.smethod_22((Control)(object)button1, new Point(86, 193));
					num = (int)(num2 * 593477018) ^ -1597951337;
					continue;
				case 49u:
					Form2.smethod_23((Control)(object)label3, "label3");
					num = (int)(num2 * 1108308998) ^ -745279718;
					continue;
				case 47u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -676782990) ^ -1124074951;
					continue;
				case 46u:
					num = ((int)num2 * -455837609) ^ -1550069647;
					continue;
				case 45u:
					Form2.smethod_25((Control)(object)button1, 3);
					num = (int)((num2 * 639476800) ^ 0x41791263);
					continue;
				case 44u:
					Form2.smethod_1((Control)(object)this, "Жеребьёвка");
					num = ((int)num2 * -28161766) ^ -1750910634;
					continue;
				case 43u:
					Form2.smethod_25((Control)(object)label3, 4);
					num = (int)((num2 * 1586550835) ^ 0x31E68BC1);
					continue;
				case 42u:
					Form2.smethod_42((Control)(object)this, bool_0: false);
					num = ((int)num2 * -1519341360) ^ 0x5BCE7E7C;
					continue;
				case 41u:
					num = ((int)num2 * -965534501) ^ -1677072258;
					continue;
				case 40u:
					Form2.smethod_39((Control)(object)this, "Form2");
					num = ((int)num2 * -1323310548) ^ -562363253;
					continue;
				case 39u:
					Form2.smethod_23((Control)(object)label1, "label1");
					Form2.smethod_24((Control)(object)label1, new Size(35, 13));
					num = (int)(num2 * 1508588128) ^ -249304286;
					continue;
				case 38u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label2);
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label1);
					Form2.smethod_36((Form)(object)this, (FormBorderStyle)1);
					Form2.smethod_37((Form)(object)this, bool_0: false);
					Form2.smethod_38((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1056791904) ^ -2089992994;
					continue;
				case 37u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label3);
					num = (int)((num2 * 1157384356) ^ 0x792E7DBF);
					continue;
				case 36u:
					Form2.smethod_22((Control)(object)textBox1, new Point(24, 86));
					num = ((int)num2 * -1200348065) ^ -1577490748;
					continue;
				case 35u:
					Form2.smethod_25((Control)(object)label2, 2);
					num = (int)((num2 * 702956601) ^ 0x77603B74);
					continue;
				case 34u:
					Form2.smethod_30((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)((num2 * 1528925636) ^ 0x3D14A2E);
					continue;
				case 33u:
					num = ((int)num2 * -168608165) ^ 0xCB25B6F;
					continue;
				case 32u:
					num = ((int)num2 * -925298060) ^ 0x2B1C4934;
					continue;
				case 31u:
					Form2.smethod_24((Control)(object)button1, new Size(73, 23));
					num = ((int)num2 * -703095166) ^ -300980568;
					continue;
				case 30u:
					Form2.smethod_25((Control)(object)label1, 0);
					Form2.smethod_1((Control)(object)label1, "label1");
					num = ((int)num2 * -380884888) ^ -823052581;
					continue;
				case 29u:
					num = ((int)num2 * -760204682) ^ 0x17511B1A;
					continue;
				case 28u:
					Form2.smethod_23((Control)(object)label2, "label2");
					num = ((int)num2 * -271256907) ^ -1544179936;
					continue;
				case 27u:
					Form2.smethod_32((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 381371805) ^ 0x120F4F57);
					continue;
				case 26u:
					Form2.smethod_27((Control)(object)textBox1, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 287018784) ^ -1283616182;
					continue;
				case 25u:
					num = (int)(num2 * 1040631413) ^ -1057048696;
					continue;
				case 24u:
					num = ((int)num2 * -592712339) ^ -792926402;
					continue;
				case 23u:
					num = ((int)num2 * -1523782409) ^ 0x501421A3;
					continue;
				case 22u:
					Form2.smethod_1((Control)(object)button1, "OK");
					num = (int)((num2 * 1203809828) ^ 0x76296102);
					continue;
				case 21u:
					Form2.smethod_20((Control)(object)this);
					Form2.smethod_21((Control)(object)label1, bool_0: true);
					num = (int)(num2 * 1629133080) ^ -1771827520;
					continue;
				case 20u:
					num = (int)((num2 * 1705638200) ^ 0x1A52BAFB);
					continue;
				case 19u:
					Form2.smethod_24((Control)(object)label3, new Size(0, 13));
					num = ((int)num2 * -248348615) ^ 0x785C4F28;
					continue;
				case 18u:
					Form2.smethod_29((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -1658666362) ^ -91528735;
					continue;
				case 17u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)textBox1);
					num = ((int)num2 * -864210410) ^ -1748575551;
					continue;
				case 16u:
					label2 = Form2.smethod_17();
					button1 = Form2.smethod_19();
					num = ((int)num2 * -2137955299) ^ 0x32F0A0BC;
					continue;
				case 15u:
					num = (int)(num2 * 599628433) ^ -334614012;
					continue;
				case 14u:
					Form2.smethod_31((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -2141868130) ^ -853519968;
					continue;
				case 13u:
					num = (int)(num2 * 2108063480) ^ -1266143011;
					continue;
				case 12u:
					textBox1 = Form2.smethod_18();
					num = (int)((num2 * 346868682) ^ 0x5592448C);
					continue;
				case 11u:
					Form2.smethod_28((Control)(object)textBox1, new KeyPressEventHandler(TextBox1_KeyPress));
					num = ((int)num2 * -959548938) ^ 0x55DE7F03;
					continue;
				case 10u:
					Form2.smethod_27((Control)(object)label2, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 127130292) ^ -1616157547;
					continue;
				case 8u:
					Form2.smethod_23((Control)(object)button1, "button1");
					num = (int)((num2 * 870407435) ^ 0x748C6E4A);
					continue;
				case 7u:
					Form2.smethod_24((Control)(object)label2, new Size(188, 73));
					num = ((int)num2 * -517153728) ^ 0x6FDAB9A;
					continue;
				case 6u:
					num = ((int)num2 * -1347024351) ^ -2009410927;
					continue;
				case 5u:
					Form2.smethod_23((Control)(object)textBox1, "textBox1");
					Form2.smethod_24((Control)(object)textBox1, new Size(42, 80));
					num = (int)((num2 * 1997796850) ^ 0x7FB7C2FD);
					continue;
				case 4u:
					Form2.smethod_40((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1820772679) ^ 0x7E331C6B;
					continue;
				case 3u:
					Form2.smethod_22((Control)(object)label1, new Point(10, 10));
					num = (int)((num2 * 191030480) ^ 0x978A019);
					continue;
				case 2u:
					num = (int)((num2 * 1460328722) ^ 0x7EBF8BE3);
					continue;
				case 1u:
					Form2.smethod_33((Form)(object)this, new Size(255, 224));
					num = (int)((num2 * 327172328) ^ 0x13972CE);
					continue;
				case 0u:
					Form2.smethod_22((Control)(object)label2, new Point(53, 89));
					num = ((int)num2 * -1736244820) ^ 0x655AFF0E;
					continue;
				case 9u:
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
