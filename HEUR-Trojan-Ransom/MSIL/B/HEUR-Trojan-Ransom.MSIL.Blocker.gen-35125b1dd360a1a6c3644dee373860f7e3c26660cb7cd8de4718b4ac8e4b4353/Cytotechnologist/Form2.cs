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
			int num = -1966221096;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xED23CD75u) % 3u)
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
				num = (int)(num2 * 349607833) ^ -652418216;
			}
		}
	}

	private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		bool flag = !char.IsDigit(Form2.smethod_4(e));
		bool flag2 = default(bool);
		while (true)
		{
			int num = -832953371;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x90735E97u) % 10u)
				{
				case 9u:
					flag2 = Form2.smethod_4(e) == '\r';
					num = -1595746863;
					continue;
				case 8u:
					Form2.smethod_1((Control)(object)textBox1, "");
					num = -1727617784;
					continue;
				case 6u:
					Form2.smethod_5(e, bool_0: true);
					num = ((int)num2 * -1024815193) ^ 0x22A7458A;
					continue;
				case 5u:
					Button1_Click(this, Form2.smethod_6());
					num = (int)((num2 * 417031396) ^ 0x49EB1C32);
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = 1247106887;
						num6 = 1247106887;
					}
					else
					{
						num5 = 559215331;
						num6 = 559215331;
					}
					num = num5 ^ ((int)num2 * -969407913);
					continue;
				}
				case 3u:
					num = (int)((num2 * 2071954176) ^ 0x778D60E2);
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!flag2)
					{
						num3 = -1815429790;
						num4 = -1815429790;
					}
					else
					{
						num3 = -1711179000;
						num4 = -1711179000;
					}
					num = num3 ^ (int)(num2 * 2006764480);
					continue;
				}
				case 1u:
					num = (int)(num2 * 590496498) ^ -1655401978;
					continue;
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
		int num4 = default(int);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		int num3 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 1422875452;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x34084B6Bu) % 35u)
				{
				case 34u:
					num = ((int)num2 * -465918198) ^ 0x3A29ACAB;
					continue;
				case 33u:
					num4 = int.Parse(Form2.smethod_7((Control)(object)textBox1));
					num = ((int)num2 * -707185190) ^ 0x256959BF;
					continue;
				case 32u:
					num = 354970413;
					continue;
				case 31u:
					num = ((int)num2 * -854041785) ^ -1341472227;
					continue;
				case 30u:
					Form2.smethod_14(Form2.smethod_11(Form2.smethod_2((Form)(object)this)));
					num = (int)(num2 * 557589069) ^ -955274834;
					continue;
				case 29u:
				{
					int num9;
					int num10;
					if (flag3)
					{
						num9 = -1085962174;
						num10 = -1085962174;
					}
					else
					{
						num9 = -926099215;
						num10 = -926099215;
					}
					num = num9 ^ ((int)num2 * -196343743);
					continue;
				}
				case 28u:
					num = ((int)num2 * -1735097566) ^ 0x3226F5A3;
					continue;
				case 27u:
					num = ((int)num2 * -698270168) ^ -855925817;
					continue;
				case 26u:
					num = ((int)num2 * -1479551438) ^ -1143165131;
					continue;
				case 24u:
					flag2 = (num4 + num3) % 2 == 0;
					num = (int)((num2 * 860837049) ^ 0x5BD92919);
					continue;
				case 23u:
					num = (int)(num2 * 655877204) ^ -258680427;
					continue;
				case 22u:
					num = (int)((num2 * 1730908843) ^ 0x41ACA573);
					continue;
				case 21u:
					num = (int)((num2 * 1758737211) ^ 0x76CFBC76);
					continue;
				case 20u:
					num = (int)((num2 * 257871951) ^ 0x46DD70F5);
					continue;
				case 19u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).StartGame();
					Form2.smethod_15((Form)(object)this);
					num = (int)(num2 * 2126180836) ^ -2043880136;
					continue;
				case 18u:
					num = 1228136369;
					continue;
				case 17u:
					num = 1909609059;
					continue;
				case 15u:
				{
					int num12;
					int num13;
					if (this.flag)
					{
						num12 = 1909000085;
						num13 = 1909000085;
					}
					else
					{
						num12 = 688997063;
						num13 = 688997063;
					}
					num = num12 ^ ((int)num2 * -638893031);
					continue;
				}
				case 14u:
					(Form2.smethod_2((Form)(object)this) as Form3).Button_Continue();
					num = ((int)num2 * -1105840579) ^ 0x4EE66320;
					continue;
				case 13u:
					this.flag = false;
					num = 231700949;
					continue;
				case 12u:
					num = ((int)num2 * -372667032) ^ 0x589BCAA9;
					continue;
				case 11u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = true;
					num = (int)(num2 * 325725784) ^ -654917110;
					continue;
				case 10u:
				{
					Form control_ = Form2.smethod_2((Form)(object)this);
					int num11 = Form2.smethod_12((Control)(object)control_) - 1;
					Form2.smethod_13((Control)(object)control_, num11);
					flag = num11 > 1;
					num = 1953978213;
					continue;
				}
				case 9u:
					num = (int)((num2 * 1808251879) ^ 0x65B85B06);
					continue;
				case 8u:
					flag3 = Form2.smethod_8(Form2.smethod_7((Control)(object)textBox1), "");
					num = ((int)num2 * -1659516603) ^ 0x666E8B0A;
					continue;
				case 7u:
					Form2.smethod_1((Control)(object)label3, "Поздравляем! Ваш ход первый.");
					num = ((int)num2 * -999844581) ^ 0x48614429;
					continue;
				case 6u:
				{
					int num7;
					int num8;
					if (flag2)
					{
						num7 = -851351846;
						num8 = -851351846;
					}
					else
					{
						num7 = -904389109;
						num8 = -904389109;
					}
					num = num7 ^ (int)(num2 * 48852456);
					continue;
				}
				case 5u:
					Form2.smethod_1((Control)(object)label3, "Первым ход делает Компьютер.");
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = false;
					num = 1660787706;
					continue;
				case 4u:
					num = (int)((num2 * 926373665) ^ 0x59F6BFEC);
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = -430376057;
						num6 = -430376057;
					}
					else
					{
						num5 = -1349046484;
						num6 = -1349046484;
					}
					num = num5 ^ ((int)num2 * -282212679);
					continue;
				}
				case 2u:
					num = (int)(num2 * 1639137676) ^ -1040448650;
					continue;
				case 1u:
					Form2.smethod_1((Control)(object)label2, Form2.smethod_10("+", num3.ToString(), "=", (num4 + num3).ToString()));
					num = ((int)num2 * -1275349829) ^ -1580239239;
					continue;
				case 0u:
					num3 = Form2.smethod_9(rnd, 10);
					num = (int)((num2 * 5635132) ^ 0x4F9FF1F2);
					continue;
				default:
					return;
				case 16u:
					break;
				case 25u:
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
			goto IL_0009;
		}
		int num = 0;
		goto IL_00b2;
		IL_00a9:
		num = ((components != null) ? 1 : 0);
		goto IL_00b2;
		IL_0009:
		int num2 = -2102251457;
		goto IL_0078;
		IL_0078:
		bool flag = default(bool);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0xD9C0DBDBu) % 8u)
			{
			case 7u:
				break;
			case 6u:
				num2 = (int)((num3 * 1009050418) ^ 0x5684B0EA);
				continue;
			case 3u:
				num2 = ((int)num3 * -41572016) ^ 0x67D7D389;
				continue;
			case 2u:
				((Form)this).Dispose(disposing);
				num2 = -7386491;
				continue;
			case 1u:
				Form2.smethod_16((IDisposable)components);
				num2 = ((int)num3 * -242072578) ^ -2021444626;
				continue;
			case 0u:
			{
				int num4;
				int num5;
				if (flag)
				{
					num4 = 1523197954;
					num5 = 1523197954;
				}
				else
				{
					num4 = 1121190409;
					num5 = 1121190409;
				}
				num2 = num4 ^ ((int)num3 * -1675403697);
				continue;
			}
			default:
				return;
			case 4u:
				goto IL_00a9;
			case 5u:
				return;
			}
			break;
		}
		goto IL_0009;
		IL_00b2:
		flag = (byte)num != 0;
		num2 = -975250997;
		goto IL_0078;
	}

	private void InitializeComponent()
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f1: Expected O, but got Unknown
		label1 = Form2.smethod_17();
		while (true)
		{
			int num = 629164307;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x697DE0A6u) % 66u)
				{
				case 64u:
					Form2.smethod_23((Control)(object)textBox1, "textBox1");
					num = ((int)num2 * -539239085) ^ -956199834;
					continue;
				case 63u:
					Form2.smethod_24((Control)(object)label3, new Size(0, 13));
					num = ((int)num2 * -251642391) ^ -452513840;
					continue;
				case 62u:
					Form2.smethod_36((Form)(object)this, (FormBorderStyle)1);
					Form2.smethod_37((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1687618097) ^ 0x769CAED8;
					continue;
				case 61u:
					Form2.smethod_41((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
					num = ((int)num2 * -120265683) ^ 0x36DFFF2C;
					continue;
				case 60u:
					num = ((int)num2 * -847294149) ^ 0x3E2C543A;
					continue;
				case 59u:
					num = (int)(num2 * 1539406994) ^ -1251585919;
					continue;
				case 57u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label2);
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label1);
					num = (int)(num2 * 157335713) ^ -557066765;
					continue;
				case 56u:
					Form2.smethod_22((Control)(object)label2, new Point(53, 89));
					num = ((int)num2 * -1563459907) ^ -709123649;
					continue;
				case 55u:
					Form2.smethod_23((Control)(object)label2, "label2");
					num = (int)(num2 * 1753941152) ^ -41337328;
					continue;
				case 54u:
					num = (int)((num2 * 2050397333) ^ 0x70DE6AA0);
					continue;
				case 53u:
					Form2.smethod_22((Control)(object)textBox1, new Point(24, 86));
					num = (int)((num2 * 1367301854) ^ 0x49574370);
					continue;
				case 52u:
					Form2.smethod_24((Control)(object)textBox1, new Size(42, 80));
					num = (int)(num2 * 1647050967) ^ -156746881;
					continue;
				case 51u:
					num = (int)((num2 * 119579559) ^ 0x6FB0130D);
					continue;
				case 50u:
					Form2.smethod_1((Control)(object)label2, "+N=?");
					num = ((int)num2 * -1279296495) ^ 0x2E7D2CF9;
					continue;
				case 49u:
					num = ((int)num2 * -34497534) ^ 0x17B06868;
					continue;
				case 48u:
					Form2.smethod_31((ContainerControl)(object)this, new SizeF(6f, 13f));
					Form2.smethod_32((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 4780353) ^ -323681950;
					continue;
				case 47u:
					num = (int)(num2 * 1219494866) ^ -2019527020;
					continue;
				case 46u:
					Form2.smethod_25((Control)(object)label1, 0);
					num = ((int)num2 * -881563802) ^ -1217894849;
					continue;
				case 45u:
					Form2.smethod_22((Control)(object)label3, new Point(47, 177));
					num = (int)((num2 * 493396484) ^ 0x1ACDF9F);
					continue;
				case 44u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)textBox1);
					num = (int)(num2 * 1854513125) ^ -1898572957;
					continue;
				case 43u:
					num = (int)(num2 * 762404800) ^ -440752179;
					continue;
				case 42u:
					Form2.smethod_24((Control)(object)label2, new Size(188, 73));
					num = (int)((num2 * 1586426101) ^ 0x45667E45);
					continue;
				case 41u:
					Form2.smethod_42((Control)(object)this, bool_0: false);
					num = ((int)num2 * -1415554824) ^ 0x21D4514D;
					continue;
				case 40u:
					num = (int)(num2 * 1465596764) ^ -2014032164;
					continue;
				case 39u:
					Form2.smethod_27((Control)(object)label2, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 1489434748) ^ -1097727463;
					continue;
				case 38u:
					Form2.smethod_38((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1570142420) ^ -1885354245;
					continue;
				case 37u:
					Form2.smethod_1((Control)(object)label1, "label1");
					num = ((int)num2 * -266468804) ^ -759216319;
					continue;
				case 36u:
					Form2.smethod_23((Control)(object)button1, "button1");
					num = ((int)num2 * -107565806) ^ 0x54534C53;
					continue;
				case 35u:
					Form2.smethod_25((Control)(object)button1, 3);
					Form2.smethod_1((Control)(object)button1, "OK");
					num = (int)((num2 * 802610124) ^ 0x905CE6A);
					continue;
				case 34u:
					Form2.smethod_30((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -473906258) ^ 0x683CF45;
					continue;
				case 33u:
					Form2.smethod_21((Control)(object)label2, bool_0: true);
					num = (int)(num2 * 406181436) ^ -1962774543;
					continue;
				case 32u:
					label2 = Form2.smethod_17();
					button1 = Form2.smethod_19();
					num = (int)((num2 * 1848654515) ^ 0x185F501E);
					continue;
				case 31u:
					Form2.smethod_25((Control)(object)label2, 2);
					num = ((int)num2 * -23789073) ^ -1029370094;
					continue;
				case 30u:
					Form2.smethod_24((Control)(object)label1, new Size(35, 13));
					num = ((int)num2 * -1366824894) ^ -1645722972;
					continue;
				case 29u:
					Form2.smethod_22((Control)(object)button1, new Point(86, 193));
					num = (int)(num2 * 2087577813) ^ -71963153;
					continue;
				case 28u:
					Form2.smethod_23((Control)(object)label1, "label1");
					num = (int)(num2 * 1769142610) ^ -1630229494;
					continue;
				case 27u:
					Form2.smethod_24((Control)(object)button1, new Size(73, 23));
					num = ((int)num2 * -1323286440) ^ 0x636AB8B;
					continue;
				case 26u:
					num = (int)(num2 * 1721451602) ^ -2025324978;
					continue;
				case 25u:
					num = ((int)num2 * -1873204304) ^ 0x5915DA37;
					continue;
				case 24u:
					num = ((int)num2 * -943157624) ^ -1872301371;
					continue;
				case 23u:
					Form2.smethod_21((Control)(object)label3, bool_0: true);
					num = ((int)num2 * -608854350) ^ -472725108;
					continue;
				case 22u:
					Form2.smethod_29((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -1069431961) ^ 0x6641B492;
					continue;
				case 21u:
					num = (int)(num2 * 27844130) ^ -1166513015;
					continue;
				case 20u:
					Form2.smethod_33((Form)(object)this, new Size(255, 224));
					num = ((int)num2 * -1194430839) ^ 0x5BAB18D5;
					continue;
				case 19u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)button1);
					num = (int)(num2 * 1046630131) ^ -1481094291;
					continue;
				case 18u:
					num = ((int)num2 * -161049914) ^ -1936278303;
					continue;
				case 17u:
					Form2.smethod_39((Control)(object)this, "Form2");
					num = (int)((num2 * 526238868) ^ 0x5CD3F504);
					continue;
				case 16u:
					Form2.smethod_25((Control)(object)textBox1, 1);
					Form2.smethod_28((Control)(object)textBox1, new KeyPressEventHandler(TextBox1_KeyPress));
					num = ((int)num2 * -549828528) ^ 0x7C0C1CF3;
					continue;
				case 15u:
					num = ((int)num2 * -580884330) ^ -269569423;
					continue;
				case 14u:
					num = (int)(num2 * 1011782635) ^ -625937006;
					continue;
				case 13u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label3);
					num = (int)((num2 * 1641475029) ^ 0x30357E51);
					continue;
				case 12u:
					num = ((int)num2 * -93980205) ^ 0x5B9BF0B4;
					continue;
				case 11u:
					Form2.smethod_43((Control)(object)this);
					num = ((int)num2 * -692705615) ^ 0x4FA501C9;
					continue;
				case 10u:
					Form2.smethod_22((Control)(object)label1, new Point(10, 10));
					num = ((int)num2 * -472103819) ^ -160683440;
					continue;
				case 9u:
					Form2.smethod_23((Control)(object)label3, "label3");
					num = ((int)num2 * -1059398709) ^ -819627376;
					continue;
				case 8u:
					num = ((int)num2 * -1444449843) ^ -1066276024;
					continue;
				case 7u:
					num = ((int)num2 * -1827577917) ^ 0xD8897D8;
					continue;
				case 6u:
					Form2.smethod_40((Form)(object)this, bool_0: false);
					num = (int)((num2 * 444626426) ^ 0x34744F2C);
					continue;
				case 5u:
					Form2.smethod_27((Control)(object)textBox1, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -796130222) ^ 0x4AFCC337;
					continue;
				case 4u:
					Form2.smethod_25((Control)(object)label3, 4);
					num = ((int)num2 * -862760733) ^ -1134354258;
					continue;
				case 3u:
					num = ((int)num2 * -140076640) ^ -931023698;
					continue;
				case 2u:
					Form2.smethod_1((Control)(object)this, "Жеребьёвка");
					num = (int)(num2 * 901499751) ^ -995559161;
					continue;
				case 1u:
					textBox1 = Form2.smethod_18();
					num = (int)((num2 * 83426870) ^ 0x470751B0);
					continue;
				case 0u:
					label3 = Form2.smethod_17();
					Form2.smethod_20((Control)(object)this);
					Form2.smethod_21((Control)(object)label1, bool_0: true);
					num = (int)(num2 * 179808033) ^ -69024958;
					continue;
				default:
					return;
				case 65u:
					break;
				case 58u:
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
