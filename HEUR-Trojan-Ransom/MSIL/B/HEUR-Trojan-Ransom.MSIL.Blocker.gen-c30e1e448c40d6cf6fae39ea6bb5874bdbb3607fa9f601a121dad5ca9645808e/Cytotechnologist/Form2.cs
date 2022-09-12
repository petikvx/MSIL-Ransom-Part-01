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
			int num = 1415685045;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1D2AC8B2u) % 3u)
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
				num = (int)((num2 * 562743525) ^ 0x1CA57BA5);
			}
		}
	}

	private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsDigit(Form2.smethod_4(e)))
		{
			goto IL_003d;
		}
		goto IL_00eb;
		IL_00eb:
		Form2.smethod_1((Control)(object)textBox1, "");
		int num = 1594547072;
		goto IL_00b1;
		IL_00b1:
		bool flag = default(bool);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x62A561F0u) % 10u)
			{
			case 8u:
				num = ((int)num2 * -233679709) ^ 0x5BB794DA;
				continue;
			case 7u:
				Form2.smethod_5(e, bool_0: true);
				num = ((int)num2 * -661832198) ^ -198550788;
				continue;
			case 5u:
				break;
			case 4u:
				num = ((int)num2 * -31596775) ^ 0x553945C0;
				continue;
			case 3u:
				Button1_Click(this, Form2.smethod_6());
				num = ((int)num2 * -1002655743) ^ -1235897195;
				continue;
			case 2u:
				flag = Form2.smethod_4(e) == '\r';
				num = 413405835;
				continue;
			case 1u:
			{
				int num3;
				int num4;
				if (flag)
				{
					num3 = -1528472469;
					num4 = -1528472469;
				}
				else
				{
					num3 = -1109902193;
					num4 = -1109902193;
				}
				num = num3 ^ ((int)num2 * -1719116596);
				continue;
			}
			case 0u:
				num = (int)((num2 * 1672783033) ^ 0x5AAFC821);
				continue;
			default:
				return;
			case 6u:
				goto IL_00eb;
			case 9u:
				return;
			}
			break;
		}
		goto IL_003d;
		IL_003d:
		num = 1621722533;
		goto IL_00b1;
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		bool flag = default(bool);
		int num7 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 1865345312;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6D65FBF8u) % 32u)
				{
				case 31u:
					num = (int)((num2 * 676095788) ^ 0x4A201992);
					continue;
				case 30u:
					Form2.smethod_14(Form2.smethod_11(Form2.smethod_2((Form)(object)this)));
					num = ((int)num2 * -1277298326) ^ -18162149;
					continue;
				case 29u:
					Form2.smethod_15((Form)(object)this);
					num = (int)(num2 * 1715523653) ^ -613617280;
					continue;
				case 28u:
				{
					int num10;
					int num11;
					if (!flag)
					{
						num10 = 599478427;
						num11 = 599478427;
					}
					else
					{
						num10 = 2072753448;
						num11 = 2072753448;
					}
					num = num10 ^ (int)(num2 * 1727804130);
					continue;
				}
				case 27u:
					(Form2.smethod_2((Form)(object)this) as Form3).Button_Continue();
					num = (int)((num2 * 1024797023) ^ 0x443723A2);
					continue;
				case 26u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).StartGame();
					num = ((int)num2 * -566970012) ^ -955208595;
					continue;
				case 24u:
				{
					int num12;
					int num13;
					if (Form2.smethod_8(Form2.smethod_7((Control)(object)textBox1), ""))
					{
						num12 = 456425957;
						num13 = 456425957;
					}
					else
					{
						num12 = 942646281;
						num13 = 942646281;
					}
					num = num12 ^ (int)(num2 * 1551857123);
					continue;
				}
				case 23u:
					num = (int)((num2 * 1240302777) ^ 0x5A9DE1C1);
					continue;
				case 22u:
					num = (int)((num2 * 1939501355) ^ 0x294CCC0B);
					continue;
				case 21u:
				{
					int num8;
					int num9;
					if (!this.flag)
					{
						num8 = -118607874;
						num9 = -118607874;
					}
					else
					{
						num8 = -456906280;
						num9 = -456906280;
					}
					num = num8 ^ (int)(num2 * 1364608635);
					continue;
				}
				case 20u:
					num = ((int)num2 * -1694889384) ^ 0x21DC1C5D;
					continue;
				case 18u:
				{
					Form control_2 = Form2.smethod_2((Form)(object)this);
					num7 = Form2.smethod_12((Control)(object)control_2) - 1;
					Form2.smethod_13((Control)(object)control_2, num7);
					num = 1712383644;
					continue;
				}
				case 17u:
					num = 681962546;
					continue;
				case 16u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = false;
					num = ((int)num2 * -862389870) ^ 0x7FD3F65F;
					continue;
				case 15u:
					num = (int)((num2 * 1868570468) ^ 0x202F117E);
					continue;
				case 14u:
					Form2.smethod_1((Control)(object)label3, "Первым ход делает Компьютер.");
					num = (int)(num2 * 571798565) ^ -1240098930;
					continue;
				case 13u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = true;
					num = ((int)num2 * -1189225932) ^ -284388088;
					continue;
				case 12u:
					num = 22129846;
					continue;
				case 11u:
					flag = num7 > 1;
					num = (int)((num2 * 1133373554) ^ 0xBBA8B22);
					continue;
				case 10u:
					num = (int)((num2 * 1436563864) ^ 0x53B3CE5A);
					continue;
				case 9u:
					num = ((int)num2 * -424352504) ^ 0x75570F86;
					continue;
				case 8u:
					num = 1277810602;
					continue;
				case 7u:
					num = ((int)num2 * -1414572599) ^ 0x35EDA182;
					continue;
				case 6u:
				{
					num3 = int.Parse(Form2.smethod_7((Control)(object)textBox1));
					num4 = Form2.smethod_9(rnd, 10);
					Label control_ = label2;
					string string_ = num4.ToString();
					num7 = num3 + num4;
					Form2.smethod_1((Control)(object)control_, Form2.smethod_10("+", string_, "=", num7.ToString()));
					num = (int)(num2 * 61800165) ^ -340762586;
					continue;
				}
				case 5u:
					this.flag = false;
					num = 1734093337;
					continue;
				case 4u:
					num = ((int)num2 * -1167186777) ^ 0x370FDF0F;
					continue;
				case 3u:
					num = ((int)num2 * -154570091) ^ -1553392443;
					continue;
				case 2u:
					Form2.smethod_1((Control)(object)label3, "Поздравляем! Ваш ход первый.");
					num = ((int)num2 * -838476101) ^ 0x4FFAA623;
					continue;
				case 1u:
					num = 1769589121;
					continue;
				case 0u:
				{
					int num5;
					int num6;
					if ((num3 + num4) % 2 == 0)
					{
						num5 = -723355941;
						num6 = -723355941;
					}
					else
					{
						num5 = -1318890060;
						num6 = -1318890060;
					}
					num = num5 ^ ((int)num2 * -1462237022);
					continue;
				}
				default:
					return;
				case 19u:
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
		bool flag = default(bool);
		while (true)
		{
			int num = -710829304;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x9004E56Fu) % 8u)
				{
				case 7u:
					if (disposing)
					{
						num = (int)(num2 * 48088242) ^ -757078423;
						continue;
					}
					num3 = 0;
					goto IL_0019;
				case 6u:
					Form2.smethod_16((IDisposable)components);
					num = ((int)num2 * -1740172515) ^ -567115309;
					continue;
				case 4u:
					num = ((int)num2 * -1591657745) ^ -1254552595;
					continue;
				case 2u:
					((Form)this).Dispose(disposing);
					num = -1190828908;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 897242455;
						num5 = 897242455;
					}
					else
					{
						num4 = 140242233;
						num5 = 140242233;
					}
					num = num4 ^ (int)(num2 * 2108803258);
					continue;
				}
				case 0u:
					num3 = ((components != null) ? 1 : 0);
					goto IL_0019;
				default:
					return;
				case 5u:
					break;
				case 3u:
					return;
					IL_0019:
					flag = (byte)num3 != 0;
					num = -1996160658;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Expected O, but got Unknown
		//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Expected O, but got Unknown
		label1 = Form2.smethod_17();
		while (true)
		{
			int num = -1456500452;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC7B5CE9Au) % 55u)
				{
				case 54u:
					Form2.smethod_31((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)((num2 * 661914517) ^ 0x775344BD);
					continue;
				case 53u:
					num = (int)((num2 * 269183430) ^ 0x7630B868);
					continue;
				case 52u:
					Form2.smethod_22((Control)(object)textBox1, new Point(24, 86));
					num = ((int)num2 * -1636800094) ^ -1969527523;
					continue;
				case 51u:
					Form2.smethod_1((Control)(object)label1, "label1");
					num = (int)((num2 * 675317825) ^ 0x5C263E61);
					continue;
				case 50u:
					Form2.smethod_32((ContainerControl)(object)this, (AutoScaleMode)1);
					Form2.smethod_33((Form)(object)this, new Size(255, 224));
					num = (int)(num2 * 2004093073) ^ -978609677;
					continue;
				case 49u:
					label3 = Form2.smethod_17();
					Form2.smethod_20((Control)(object)this);
					num = (int)((num2 * 1661432801) ^ 0x7BE23A15);
					continue;
				case 48u:
					Form2.smethod_23((Control)(object)label1, "label1");
					num = ((int)num2 * -1880072069) ^ 0x72FF204A;
					continue;
				case 47u:
					Form2.smethod_24((Control)(object)label1, new Size(35, 13));
					num = (int)(num2 * 462140980) ^ -30757670;
					continue;
				case 46u:
					Form2.smethod_40((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1883666531) ^ -1847611688;
					continue;
				case 45u:
					Form2.smethod_1((Control)(object)this, "Жеребьёвка");
					num = (int)(num2 * 1453602977) ^ -1232433714;
					continue;
				case 44u:
					num = (int)(num2 * 533207785) ^ -105563489;
					continue;
				case 43u:
					num = (int)(num2 * 1065702794) ^ -110389668;
					continue;
				case 42u:
					num = ((int)num2 * -2012315627) ^ -125635677;
					continue;
				case 41u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -1760113548) ^ -367006069;
					continue;
				case 40u:
					Form2.smethod_24((Control)(object)label2, new Size(188, 73));
					num = (int)((num2 * 1182033384) ^ 0x7C092B61);
					continue;
				case 39u:
					Form2.smethod_22((Control)(object)label1, new Point(10, 10));
					num = (int)((num2 * 1229091289) ^ 0x234E7B3D);
					continue;
				case 38u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)textBox1);
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label2);
					num = (int)((num2 * 1104403003) ^ 0x1C38240C);
					continue;
				case 37u:
					num = ((int)num2 * -1621396555) ^ 0x4D2817E0;
					continue;
				case 36u:
					Form2.smethod_37((Form)(object)this, bool_0: false);
					Form2.smethod_38((Form)(object)this, bool_0: false);
					Form2.smethod_39((Control)(object)this, "Form2");
					num = (int)((num2 * 2123292425) ^ 0x493CFE3A);
					continue;
				case 35u:
					num = ((int)num2 * -466644553) ^ 0xE296D50;
					continue;
				case 34u:
					Form2.smethod_22((Control)(object)label3, new Point(47, 177));
					num = (int)(num2 * 1700946312) ^ -2023704874;
					continue;
				case 33u:
					num = ((int)num2 * -513945700) ^ 0x470AC634;
					continue;
				case 32u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label3);
					num = ((int)num2 * -366704602) ^ -1909318365;
					continue;
				case 31u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label1);
					Form2.smethod_36((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -902202051) ^ -334820339;
					continue;
				case 30u:
					Form2.smethod_23((Control)(object)textBox1, "textBox1");
					Form2.smethod_24((Control)(object)textBox1, new Size(42, 80));
					num = ((int)num2 * -1587382685) ^ -2047733876;
					continue;
				case 29u:
					num = (int)(num2 * 38830752) ^ -2122867128;
					continue;
				case 28u:
					Form2.smethod_23((Control)(object)label2, "label2");
					num = ((int)num2 * -492741686) ^ 0x1A735E65;
					continue;
				case 27u:
					Form2.smethod_27((Control)(object)label2, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 1865382193) ^ -2137202911;
					continue;
				case 25u:
					num = ((int)num2 * -1560633271) ^ -1251297777;
					continue;
				case 24u:
					Form2.smethod_43((Control)(object)this);
					num = (int)((num2 * 618120239) ^ 0x76DFB5EA);
					continue;
				case 23u:
					textBox1 = Form2.smethod_18();
					num = ((int)num2 * -857242999) ^ 0x39BAA428;
					continue;
				case 22u:
					Form2.smethod_1((Control)(object)label2, "+N=?");
					num = ((int)num2 * -172059386) ^ 0x78B67C9;
					continue;
				case 21u:
					num = ((int)num2 * -717130345) ^ -327605914;
					continue;
				case 20u:
					Form2.smethod_30((Control)(object)button1, (EventHandler)Button1_Click);
					Form2.smethod_21((Control)(object)label3, bool_0: true);
					num = (int)(num2 * 53238434) ^ -547288943;
					continue;
				case 19u:
					Form2.smethod_41((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
					num = (int)((num2 * 1639437923) ^ 0x2981C8C9);
					continue;
				case 18u:
					num = (int)(num2 * 380467233) ^ -1868826896;
					continue;
				case 16u:
					num = (int)(num2 * 1987326016) ^ -1291056200;
					continue;
				case 15u:
					Form2.smethod_25((Control)(object)textBox1, 1);
					Form2.smethod_28((Control)(object)textBox1, new KeyPressEventHandler(TextBox1_KeyPress));
					Form2.smethod_21((Control)(object)label2, bool_0: true);
					num = (int)(num2 * 1729653852) ^ -1649059513;
					continue;
				case 14u:
					Form2.smethod_23((Control)(object)label3, "label3");
					num = ((int)num2 * -1441028713) ^ -168305858;
					continue;
				case 13u:
					Form2.smethod_27((Control)(object)textBox1, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1332725875) ^ 0x516302F6;
					continue;
				case 12u:
					label2 = Form2.smethod_17();
					button1 = Form2.smethod_19();
					num = (int)(num2 * 542945659) ^ -750664720;
					continue;
				case 11u:
					Form2.smethod_21((Control)(object)label1, bool_0: true);
					num = (int)((num2 * 1213904897) ^ 0x791F7FFE);
					continue;
				case 10u:
					Form2.smethod_24((Control)(object)label3, new Size(0, 13));
					Form2.smethod_25((Control)(object)label3, 4);
					num = (int)(num2 * 1327615823) ^ -180676542;
					continue;
				case 9u:
					Form2.smethod_42((Control)(object)this, bool_0: false);
					num = (int)(num2 * 1553523532) ^ -2020579281;
					continue;
				case 8u:
					Form2.smethod_29((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -107791519) ^ 0x36E23A6A;
					continue;
				case 7u:
					Form2.smethod_25((Control)(object)label1, 0);
					num = ((int)num2 * -1103403484) ^ -485354780;
					continue;
				case 6u:
					Form2.smethod_22((Control)(object)button1, new Point(86, 193));
					num = ((int)num2 * -1627592457) ^ 0x14866A3C;
					continue;
				case 5u:
					num = (int)((num2 * 577800844) ^ 0x21C5F6BF);
					continue;
				case 4u:
					Form2.smethod_22((Control)(object)label2, new Point(53, 89));
					num = (int)((num2 * 477591118) ^ 0x348F7A21);
					continue;
				case 3u:
					num = ((int)num2 * -968485240) ^ -1536057781;
					continue;
				case 2u:
					Form2.smethod_24((Control)(object)button1, new Size(73, 23));
					Form2.smethod_25((Control)(object)button1, 3);
					Form2.smethod_1((Control)(object)button1, "OK");
					num = (int)((num2 * 1049695739) ^ 0x6D820A96);
					continue;
				case 1u:
					Form2.smethod_23((Control)(object)button1, "button1");
					num = (int)(num2 * 1805753972) ^ -458039830;
					continue;
				case 0u:
					Form2.smethod_25((Control)(object)label2, 2);
					num = ((int)num2 * -1904633116) ^ 0x7E70481B;
					continue;
				default:
					return;
				case 17u:
					break;
				case 26u:
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
