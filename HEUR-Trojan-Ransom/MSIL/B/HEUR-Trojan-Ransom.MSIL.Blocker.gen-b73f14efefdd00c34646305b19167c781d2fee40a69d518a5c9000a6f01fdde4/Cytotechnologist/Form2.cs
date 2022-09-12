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
			int num = 277266710;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x79F8B7BAu) % 3u)
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
				num = ((int)num2 * -1334105076) ^ -232559219;
			}
		}
	}

	private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -893108153;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC2E871ECu) % 12u)
				{
				case 11u:
					flag = !char.IsDigit(Form2.smethod_4(e));
					num = (int)((num2 * 419847171) ^ 0x6E682B53);
					continue;
				case 10u:
					num = ((int)num2 * -556076996) ^ -312329997;
					continue;
				case 9u:
					Form2.smethod_5(e, bool_0: true);
					num = (int)((num2 * 1973970653) ^ 0x67936EE9);
					continue;
				case 8u:
					num = (int)((num2 * 1053133931) ^ 0x5E4E6BEF);
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = 763451142;
						num6 = 763451142;
					}
					else
					{
						num5 = 1949280460;
						num6 = 1949280460;
					}
					num = num5 ^ (int)(num2 * 1183561319);
					continue;
				}
				case 4u:
					Form2.smethod_1((Control)(object)textBox1, "");
					num = -1189099254;
					continue;
				case 3u:
					flag2 = Form2.smethod_4(e) == '\r';
					num = -1122526823;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 797093718;
						num4 = 797093718;
					}
					else
					{
						num3 = 451950391;
						num4 = 451950391;
					}
					num = num3 ^ ((int)num2 * -327114011);
					continue;
				}
				case 1u:
					Button1_Click(this, Form2.smethod_6());
					num = (int)((num2 * 1311509895) ^ 0x103F322B);
					continue;
				case 0u:
					num = (int)(num2 * 1525247533) ^ -1496301513;
					continue;
				default:
					return;
				case 6u:
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
		int num3 = default(int);
		int num5 = default(int);
		int num4 = default(int);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -1791467656;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x90E0C275u) % 30u)
				{
				case 29u:
					num = ((int)num2 * -573556847) ^ 0x407BE4F5;
					continue;
				case 28u:
					Form2.smethod_1((Control)(object)label3, "Поздравляем! Ваш ход первый.");
					num = ((int)num2 * -1402562237) ^ -341051;
					continue;
				case 27u:
					num = ((int)num2 * -1610985603) ^ -125607931;
					continue;
				case 26u:
					num = (int)(num2 * 1394947542) ^ -1819558226;
					continue;
				case 25u:
					num3 = Form2.smethod_9(rnd, 10);
					num = ((int)num2 * -1997411317) ^ 0x4DE38792;
					continue;
				case 24u:
					num = -746798315;
					continue;
				case 23u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).StartGame();
					Form2.smethod_15((Form)(object)this);
					num = ((int)num2 * -757894807) ^ -1496241047;
					continue;
				case 22u:
					num = ((int)num2 * -276943819) ^ 0x42964463;
					continue;
				case 21u:
					num = (int)((num2 * 798963816) ^ 0x20A63DD8);
					continue;
				case 20u:
				{
					Form control_2 = Form2.smethod_2((Form)(object)this);
					num5 = Form2.smethod_12((Control)(object)control_2) - 1;
					Form2.smethod_13((Control)(object)control_2, num5);
					num = -246878571;
					continue;
				}
				case 18u:
				{
					int num12;
					int num13;
					if ((num4 + num3) % 2 == 0)
					{
						num12 = -1468449909;
						num13 = -1468449909;
					}
					else
					{
						num12 = -1333345757;
						num13 = -1333345757;
					}
					num = num12 ^ (int)(num2 * 1072934040);
					continue;
				}
				case 17u:
					flag3 = this.flag;
					num = (int)(num2 * 1769360735) ^ -1347654016;
					continue;
				case 16u:
					this.flag = false;
					num = -1806644141;
					continue;
				case 15u:
					num4 = int.Parse(Form2.smethod_7((Control)(object)textBox1));
					num = (int)(num2 * 249261536) ^ -2053135592;
					continue;
				case 14u:
					Form2.smethod_1((Control)(object)label3, "Первым ход делает Компьютер.");
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = false;
					num = -1063876264;
					continue;
				case 13u:
					(Form2.smethod_2((Form)(object)this) as Form3).Button_Continue();
					num = ((int)num2 * -253563728) ^ 0xFCC48F7;
					continue;
				case 12u:
					flag2 = num5 > 1;
					num = (int)((num2 * 1398792630) ^ 0x4D4D063D);
					continue;
				case 11u:
					num = -746798315;
					continue;
				case 10u:
				{
					int num10;
					int num11;
					if (!flag3)
					{
						num10 = -677894809;
						num11 = -677894809;
					}
					else
					{
						num10 = -792200022;
						num11 = -792200022;
					}
					num = num10 ^ (int)(num2 * 293546807);
					continue;
				}
				case 9u:
				{
					int num8;
					int num9;
					if (flag)
					{
						num8 = 787337281;
						num9 = 787337281;
					}
					else
					{
						num8 = 1007940657;
						num9 = 1007940657;
					}
					num = num8 ^ ((int)num2 * -1809981097);
					continue;
				}
				case 8u:
					num = ((int)num2 * -812175620) ^ 0x7CB11FB5;
					continue;
				case 7u:
					num = -214469488;
					continue;
				case 6u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = true;
					num = (int)(num2 * 1079224335) ^ -299184923;
					continue;
				case 4u:
					Form2.smethod_14(Form2.smethod_11(Form2.smethod_2((Form)(object)this)));
					num = (int)(num2 * 568734487) ^ -601521384;
					continue;
				case 3u:
					num = (int)((num2 * 1645140510) ^ 0x446B0435);
					continue;
				case 2u:
				{
					int num6;
					int num7;
					if (!flag2)
					{
						num6 = 1771300674;
						num7 = 1771300674;
					}
					else
					{
						num6 = 777075668;
						num7 = 777075668;
					}
					num = num6 ^ (int)(num2 * 233555004);
					continue;
				}
				case 1u:
					flag = Form2.smethod_8(Form2.smethod_7((Control)(object)textBox1), "");
					num = (int)(num2 * 1027872723) ^ -1812085755;
					continue;
				case 0u:
				{
					Label control_ = label2;
					string string_ = num3.ToString();
					num5 = num4 + num3;
					Form2.smethod_1((Control)(object)control_, Form2.smethod_10("+", string_, "=", num5.ToString()));
					num = ((int)num2 * -2041698514) ^ 0x74BADF9D;
					continue;
				}
				default:
					return;
				case 19u:
					break;
				case 5u:
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
			int num = 1226821959;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x1E0E4BC2u) % 7u)
				{
				case 6u:
					if (components != null)
					{
						num = 158365188;
						num3 = 158365188;
						continue;
					}
					goto IL_0011;
				case 3u:
					num = ((int)num2 * -1606070711) ^ -1221019941;
					continue;
				case 2u:
					if (disposing)
					{
						num = (int)((num2 * 658724284) ^ 0x6BE4722);
						continue;
					}
					goto IL_0011;
				case 1u:
					((Form)this).Dispose(disposing);
					num = 1061497690;
					continue;
				case 0u:
					Form2.smethod_16((IDisposable)components);
					num = ((int)num2 * -1514546167) ^ 0x79256C56;
					continue;
				default:
					return;
				case 4u:
					break;
				case 5u:
					return;
					IL_0011:
					num = 1994571697;
					num3 = 1994571697;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected O, but got Unknown
		//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04eb: Expected O, but got Unknown
		while (true)
		{
			int num = -161742782;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x82F3B27Cu) % 65u)
				{
				case 64u:
					Form2.smethod_1((Control)(object)label1, "label1");
					num = (int)(num2 * 1037902593) ^ -33939982;
					continue;
				case 63u:
					Form2.smethod_24((Control)(object)label1, new Size(35, 13));
					num = ((int)num2 * -1236261471) ^ -991206321;
					continue;
				case 62u:
					Form2.smethod_31((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)((num2 * 221012760) ^ 0x3C01CA69);
					continue;
				case 61u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)button1);
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)textBox1);
					num = (int)((num2 * 2041519208) ^ 0x2658514);
					continue;
				case 60u:
					Form2.smethod_23((Control)(object)label2, "label2");
					num = (int)((num2 * 1938580086) ^ 0x563AFA9C);
					continue;
				case 59u:
					Form2.smethod_32((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -1982492820) ^ 0x50EEF32;
					continue;
				case 58u:
					Form2.smethod_22((Control)(object)label1, new Point(10, 10));
					num = ((int)num2 * -1316612502) ^ 0x60C8CA9E;
					continue;
				case 57u:
					Form2.smethod_25((Control)(object)label2, 2);
					num = (int)((num2 * 889017547) ^ 0x5C2A4A8E);
					continue;
				case 56u:
					label1 = Form2.smethod_17();
					textBox1 = Form2.smethod_18();
					num = (int)(num2 * 340884309) ^ -1317838479;
					continue;
				case 55u:
					button1 = Form2.smethod_19();
					num = (int)((num2 * 858581318) ^ 0x72E61A68);
					continue;
				case 54u:
					Form2.smethod_22((Control)(object)textBox1, new Point(24, 86));
					num = ((int)num2 * -1435720736) ^ -333483763;
					continue;
				case 53u:
					num = ((int)num2 * -1786066490) ^ -282395449;
					continue;
				case 52u:
					Form2.smethod_42((Control)(object)this, bool_0: false);
					num = ((int)num2 * -490210451) ^ 0x7AFC9F5;
					continue;
				case 51u:
					Form2.smethod_23((Control)(object)textBox1, "textBox1");
					num = (int)(num2 * 1935247364) ^ -1440168382;
					continue;
				case 50u:
					Form2.smethod_23((Control)(object)label1, "label1");
					num = (int)(num2 * 697228189) ^ -390060298;
					continue;
				case 48u:
					num = (int)(num2 * 864876173) ^ -375316493;
					continue;
				case 47u:
					num = (int)(num2 * 578771672) ^ -1681360361;
					continue;
				case 46u:
					label2 = Form2.smethod_17();
					num = ((int)num2 * -178279949) ^ 0x5F173DAB;
					continue;
				case 45u:
					num = ((int)num2 * -728228521) ^ 0x57D35CA9;
					continue;
				case 43u:
					num = ((int)num2 * -1499941855) ^ 0x57D8CBF8;
					continue;
				case 42u:
					Form2.smethod_21((Control)(object)label3, bool_0: true);
					num = (int)(num2 * 2078352944) ^ -1465605983;
					continue;
				case 41u:
					Form2.smethod_25((Control)(object)label3, 4);
					num = (int)(num2 * 306831826) ^ -124627748;
					continue;
				case 40u:
					num = ((int)num2 * -175159788) ^ 0x11174C2E;
					continue;
				case 39u:
					Form2.smethod_30((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -1137813681) ^ -1690865252;
					continue;
				case 38u:
					Form2.smethod_27((Control)(object)textBox1, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 251564003) ^ -661286919;
					continue;
				case 37u:
					Form2.smethod_43((Control)(object)this);
					num = ((int)num2 * -1738469865) ^ 0xA176228;
					continue;
				case 36u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label2);
					num = ((int)num2 * -1634418345) ^ 0x77A2EB10;
					continue;
				case 35u:
					num = (int)(num2 * 2007757406) ^ -1998569035;
					continue;
				case 34u:
					Form2.smethod_41((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
					num = ((int)num2 * -1704545425) ^ -273626223;
					continue;
				case 33u:
					num = (int)((num2 * 2132854209) ^ 0x5E350707);
					continue;
				case 32u:
					Form2.smethod_25((Control)(object)button1, 3);
					num = (int)(num2 * 1087185155) ^ -1074183463;
					continue;
				case 31u:
					num = (int)((num2 * 147754951) ^ 0x452C198E);
					continue;
				case 30u:
					num = (int)(num2 * 751947388) ^ -259937509;
					continue;
				case 29u:
					num = ((int)num2 * -993107896) ^ -351207395;
					continue;
				case 28u:
					label3 = Form2.smethod_17();
					Form2.smethod_20((Control)(object)this);
					Form2.smethod_21((Control)(object)label1, bool_0: true);
					num = (int)((num2 * 971610973) ^ 0x6E2CBF6C);
					continue;
				case 27u:
					Form2.smethod_23((Control)(object)label3, "label3");
					Form2.smethod_24((Control)(object)label3, new Size(0, 13));
					num = ((int)num2 * -1818376120) ^ 0x5FEDF59A;
					continue;
				case 26u:
					num = (int)((num2 * 1213648176) ^ 0x404FC3B8);
					continue;
				case 25u:
					Form2.smethod_24((Control)(object)label2, new Size(188, 73));
					num = ((int)num2 * -1302648173) ^ -1166132341;
					continue;
				case 24u:
					Form2.smethod_22((Control)(object)label3, new Point(47, 177));
					num = ((int)num2 * -1137779657) ^ 0x1399CDA1;
					continue;
				case 23u:
					num = ((int)num2 * -1870027122) ^ -607695534;
					continue;
				case 22u:
					num = ((int)num2 * -1317853989) ^ -1448535176;
					continue;
				case 21u:
					Form2.smethod_28((Control)(object)textBox1, new KeyPressEventHandler(TextBox1_KeyPress));
					num = ((int)num2 * -1474815930) ^ 0x4130C3B2;
					continue;
				case 20u:
					Form2.smethod_25((Control)(object)label1, 0);
					num = (int)((num2 * 2137396645) ^ 0x3C46823E);
					continue;
				case 19u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label3);
					num = ((int)num2 * -361582438) ^ 0x231FA37E;
					continue;
				case 18u:
					Form2.smethod_39((Control)(object)this, "Form2");
					num = ((int)num2 * -291047304) ^ 0x5CBEFD47;
					continue;
				case 17u:
					Form2.smethod_1((Control)(object)button1, "OK");
					num = ((int)num2 * -1396510115) ^ -1015347165;
					continue;
				case 16u:
					Form2.smethod_25((Control)(object)textBox1, 1);
					num = (int)(num2 * 1727913030) ^ -737676165;
					continue;
				case 15u:
					num = ((int)num2 * -1601900514) ^ -1731656983;
					continue;
				case 14u:
					Form2.smethod_1((Control)(object)label2, "+N=?");
					Form2.smethod_22((Control)(object)button1, new Point(86, 193));
					Form2.smethod_23((Control)(object)button1, "button1");
					num = ((int)num2 * -1345754354) ^ 0x472C2BE5;
					continue;
				case 13u:
					num = (int)(num2 * 869506865) ^ -1325253661;
					continue;
				case 12u:
					Form2.smethod_37((Form)(object)this, bool_0: false);
					Form2.smethod_38((Form)(object)this, bool_0: false);
					num = (int)((num2 * 1359904293) ^ 0x622C71A6);
					continue;
				case 11u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -1209801179) ^ -581196796;
					continue;
				case 10u:
					Form2.smethod_22((Control)(object)label2, new Point(53, 89));
					num = (int)(num2 * 1561256366) ^ -1842807486;
					continue;
				case 9u:
					Form2.smethod_36((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -897577776) ^ -1644185516;
					continue;
				case 8u:
					Form2.smethod_29((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -209350095) ^ -320247410;
					continue;
				case 7u:
					num = ((int)num2 * -981815452) ^ 0x3A656691;
					continue;
				case 6u:
					Form2.smethod_24((Control)(object)button1, new Size(73, 23));
					num = ((int)num2 * -1849694465) ^ 0x34248792;
					continue;
				case 5u:
					Form2.smethod_1((Control)(object)this, "Жеребьёвка");
					num = (int)((num2 * 1031511751) ^ 0x10632D79);
					continue;
				case 4u:
					Form2.smethod_21((Control)(object)label2, bool_0: true);
					num = (int)((num2 * 933566436) ^ 0x1E23545B);
					continue;
				case 3u:
					Form2.smethod_33((Form)(object)this, new Size(255, 224));
					num = (int)(num2 * 1770746231) ^ -1691040763;
					continue;
				case 2u:
					Form2.smethod_27((Control)(object)label2, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 91566221) ^ 0x19E8F507);
					continue;
				case 1u:
					Form2.smethod_24((Control)(object)textBox1, new Size(42, 80));
					num = (int)((num2 * 1644689593) ^ 0x54115B69);
					continue;
				case 0u:
					Form2.smethod_40((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1919969446) ^ -1702935055;
					continue;
				default:
					return;
				case 49u:
					break;
				case 44u:
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
