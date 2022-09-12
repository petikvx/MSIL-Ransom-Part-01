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
			int num = 1927316567;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x40E8D46u) % 6u)
				{
				case 5u:
					num = ((int)num2 * -1769598455) ^ -83764340;
					continue;
				case 3u:
					Form2.smethod_1((Control)(object)label1, "Введите любое число от 0 до 9 включительно.\nВаш соперник уже загадал число (N) из этого\nже диапазона. Если сумма ваших чисел будет\nчетным числом, то первым ход делаете Вы,\nиначе - ваш соперник Компьютер!");
					num = ((int)num2 * -286027545) ^ 0x623F9215;
					continue;
				case 1u:
					num = ((int)num2 * -1337768298) ^ -26676456;
					continue;
				case 0u:
					InitializeComponent();
					num = ((int)num2 * -1356116688) ^ 0x2F3B3387;
					continue;
				default:
					return;
				case 2u:
					break;
				case 4u:
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
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 1200502020;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE1C2E94u) % 13u)
				{
				case 11u:
					num = (int)((num2 * 551022953) ^ 0x78795DB2);
					continue;
				case 9u:
					Form2.smethod_1((Control)(object)textBox1, "");
					num = 2020282924;
					continue;
				case 8u:
					num = (int)((num2 * 143926298) ^ 0x33BAF11);
					continue;
				case 7u:
					Form2.smethod_5(e, bool_0: true);
					num = (int)(num2 * 1380377707) ^ -1944561410;
					continue;
				case 6u:
					flag2 = Form2.smethod_4(e) == '\r';
					num = 15966728;
					continue;
				case 5u:
					num = ((int)num2 * -1781051413) ^ 0x642FF0A5;
					continue;
				case 4u:
					Button1_Click(this, Form2.smethod_6());
					num = (int)((num2 * 386845753) ^ 0x280F215E);
					continue;
				case 3u:
					num = ((int)num2 * -781076868) ^ 0x7EB500D3;
					continue;
				case 2u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = -832033094;
						num6 = -832033094;
					}
					else
					{
						num5 = -1153656231;
						num6 = -1153656231;
					}
					num = num5 ^ (int)(num2 * 886091860);
					continue;
				}
				case 1u:
					flag = !char.IsDigit(Form2.smethod_4(e));
					num = ((int)num2 * -666687467) ^ -1322522634;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -750581139;
						num4 = -750581139;
					}
					else
					{
						num3 = -1594605381;
						num4 = -1594605381;
					}
					num = num3 ^ (int)(num2 * 1010688366);
					continue;
				}
				default:
					return;
				case 12u:
					break;
				case 10u:
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
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = -826384392;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x877061ECu) % 32u)
				{
				case 31u:
					num = ((int)num2 * -1609450880) ^ -1514625;
					continue;
				case 30u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = false;
					num = (int)(num2 * 1173588640) ^ -1921050546;
					continue;
				case 29u:
					num = ((int)num2 * -2145834122) ^ 0x7F2E990;
					continue;
				case 27u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).StartGame();
					num = (int)((num2 * 1103442910) ^ 0x80646CD);
					continue;
				case 26u:
					Form2.smethod_1((Control)(object)label3, "Первым ход делает Компьютер.");
					num = (int)((num2 * 642590359) ^ 0x498E187C);
					continue;
				case 25u:
				{
					int num10;
					int num11;
					if (!flag2)
					{
						num10 = 1785712908;
						num11 = 1785712908;
					}
					else
					{
						num10 = 1423449805;
						num11 = 1423449805;
					}
					num = num10 ^ (int)(num2 * 170885320);
					continue;
				}
				case 24u:
					num = (int)((num2 * 2078646079) ^ 0x78DEB714);
					continue;
				case 23u:
					(Form2.smethod_2((Form)(object)this) as Form3).Button_Continue();
					num = ((int)num2 * -122070806) ^ 0x5ED518A6;
					continue;
				case 22u:
					num = (int)((num2 * 1903892649) ^ 0x55B4B8C0);
					continue;
				case 21u:
				{
					int num12;
					int num13;
					if (!flag)
					{
						num12 = -2111177675;
						num13 = -2111177675;
					}
					else
					{
						num12 = -1880176604;
						num13 = -1880176604;
					}
					num = num12 ^ ((int)num2 * -697050458);
					continue;
				}
				case 20u:
				{
					int num8;
					int num9;
					if (!Form2.smethod_8(Form2.smethod_7((Control)(object)textBox1), ""))
					{
						num8 = -1102334277;
						num9 = -1102334277;
					}
					else
					{
						num8 = -304750600;
						num9 = -304750600;
					}
					num = num8 ^ ((int)num2 * -965239079);
					continue;
				}
				case 19u:
					num = ((int)num2 * -1198402072) ^ -25033285;
					continue;
				case 18u:
					num = ((int)num2 * -1364132979) ^ 0x8BE0A7;
					continue;
				case 17u:
					flag2 = this.flag;
					num = (int)(num2 * 1341359796) ^ -698413663;
					continue;
				case 16u:
				{
					int num6;
					int num7;
					if (num5 > 1)
					{
						num6 = 133030289;
						num7 = 133030289;
					}
					else
					{
						num6 = 14538155;
						num7 = 14538155;
					}
					num = num6 ^ (int)(num2 * 1081214383);
					continue;
				}
				case 15u:
					num = -1826275249;
					continue;
				case 14u:
				{
					Label control_2 = label2;
					string string_ = num4.ToString();
					num5 = num3 + num4;
					Form2.smethod_1((Control)(object)control_2, Form2.smethod_10("+", string_, "=", num5.ToString()));
					num = ((int)num2 * -31823878) ^ 0xC3C2B24;
					continue;
				}
				case 13u:
					num = -2012105623;
					continue;
				case 12u:
					Form2.smethod_14(Form2.smethod_11(Form2.smethod_2((Form)(object)this)));
					num = (int)(num2 * 1539813798) ^ -841557633;
					continue;
				case 11u:
					Form2.smethod_15((Form)(object)this);
					num = (int)(num2 * 1679453633) ^ -1604873931;
					continue;
				case 10u:
					Form2.smethod_1((Control)(object)label3, "Поздравляем! Ваш ход первый.");
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = true;
					num = (int)((num2 * 723606042) ^ 0x75228715);
					continue;
				case 9u:
					num3 = int.Parse(Form2.smethod_7((Control)(object)textBox1));
					num4 = Form2.smethod_9(rnd, 10);
					num = (int)(num2 * 361530059) ^ -1432003519;
					continue;
				case 8u:
					num = -2012105623;
					continue;
				case 7u:
					num = -1999306794;
					continue;
				case 6u:
					num = (int)(num2 * 1933352223) ^ -1179823608;
					continue;
				case 5u:
				{
					Form control_ = Form2.smethod_2((Form)(object)this);
					num5 = Form2.smethod_12((Control)(object)control_) - 1;
					Form2.smethod_13((Control)(object)control_, num5);
					num = -2093876108;
					continue;
				}
				case 4u:
					flag = (num3 + num4) % 2 == 0;
					num = (int)((num2 * 1747251542) ^ 0x6AA2DFA1);
					continue;
				case 2u:
					this.flag = false;
					num = -1346202381;
					continue;
				case 1u:
					num = (int)((num2 * 834800406) ^ 0x790647D5);
					continue;
				case 0u:
					num = ((int)num2 * -980895933) ^ -2110971875;
					continue;
				default:
					return;
				case 28u:
					break;
				case 3u:
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
			int num = -1208431386;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xF81A5153u) % 6u)
				{
				case 5u:
					if (components != null)
					{
						num = -1624443999;
						num3 = -1624443999;
						continue;
					}
					goto IL_0011;
				case 2u:
					((Form)this).Dispose(disposing);
					num = -760730727;
					continue;
				case 1u:
					if (disposing)
					{
						num = (int)(num2 * 1454497197) ^ -1045411699;
						continue;
					}
					goto IL_0011;
				case 0u:
					Form2.smethod_16((IDisposable)components);
					num = (int)(num2 * 134524471) ^ -1960614877;
					continue;
				default:
					return;
				case 3u:
					break;
				case 4u:
					return;
					IL_0011:
					num = -530179619;
					num3 = -530179619;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected O, but got Unknown
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Expected O, but got Unknown
		label1 = Form2.smethod_17();
		while (true)
		{
			int num = -874790086;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8FCEADC7u) % 55u)
				{
				case 54u:
					Form2.smethod_27((Control)(object)textBox1, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form2.smethod_22((Control)(object)textBox1, new Point(24, 86));
					num = (int)(num2 * 541233044) ^ -465872015;
					continue;
				case 53u:
					Form2.smethod_25((Control)(object)textBox1, 1);
					num = (int)((num2 * 450242376) ^ 0x66573F9B);
					continue;
				case 52u:
					Form2.smethod_22((Control)(object)label1, new Point(10, 10));
					num = ((int)num2 * -1838261445) ^ 0x6AD64D8A;
					continue;
				case 51u:
					Form2.smethod_21((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -1703736317) ^ 0x4F5AE15E;
					continue;
				case 50u:
					num = (int)((num2 * 1262358746) ^ 0x4D537F0E);
					continue;
				case 49u:
					Form2.smethod_29((ButtonBase)(object)button1, bool_0: true);
					Form2.smethod_30((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -125123968) ^ 0x7DE80DE2;
					continue;
				case 48u:
					num = (int)(num2 * 786931531) ^ -1482096575;
					continue;
				case 46u:
					num = (int)((num2 * 557699545) ^ 0x2D154F57);
					continue;
				case 45u:
					Form2.smethod_23((Control)(object)textBox1, "textBox1");
					num = ((int)num2 * -215659993) ^ 0xDC7EBA1;
					continue;
				case 43u:
					num = ((int)num2 * -1867518872) ^ -1206862684;
					continue;
				case 42u:
					num = (int)(num2 * 1914388794) ^ -478137390;
					continue;
				case 41u:
					num = (int)(num2 * 222472075) ^ -2018079322;
					continue;
				case 40u:
					Form2.smethod_1((Control)(object)button1, "OK");
					num = (int)((num2 * 298233781) ^ 0x22F80042);
					continue;
				case 39u:
					num = ((int)num2 * -1748450848) ^ 0x35CC1273;
					continue;
				case 38u:
					Form2.smethod_24((Control)(object)button1, new Size(73, 23));
					Form2.smethod_25((Control)(object)button1, 3);
					num = ((int)num2 * -848626556) ^ -2012600733;
					continue;
				case 37u:
					Form2.smethod_23((Control)(object)label1, "label1");
					num = (int)((num2 * 249035942) ^ 0x7A8104A4);
					continue;
				case 36u:
					num = ((int)num2 * -57616367) ^ 0x710131DA;
					continue;
				case 35u:
					Form2.smethod_23((Control)(object)label2, "label2");
					num = (int)((num2 * 2104273146) ^ 0xFEDA1EF);
					continue;
				case 34u:
					Form2.smethod_23((Control)(object)label3, "label3");
					num = (int)(num2 * 670907812) ^ -1119693230;
					continue;
				case 33u:
					num = (int)((num2 * 939277290) ^ 0xDA879FC);
					continue;
				case 32u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label3);
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)button1);
					num = (int)((num2 * 995215711) ^ 0x3A1056FE);
					continue;
				case 31u:
					Form2.smethod_32((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 1993814200) ^ 0x5EAFE6D0);
					continue;
				case 30u:
					Form2.smethod_24((Control)(object)label2, new Size(188, 73));
					Form2.smethod_25((Control)(object)label2, 2);
					num = (int)((num2 * 633080364) ^ 0x6FCBE4AD);
					continue;
				case 29u:
					Form2.smethod_1((Control)(object)this, "Жеребьёвка");
					Form2.smethod_41((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
					num = (int)((num2 * 25709070) ^ 0x520214E7);
					continue;
				case 28u:
					num = (int)(num2 * 1406930940) ^ -1067851355;
					continue;
				case 27u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)textBox1);
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label2);
					num = ((int)num2 * -307747218) ^ -1084747730;
					continue;
				case 26u:
					Form2.smethod_42((Control)(object)this, bool_0: false);
					num = ((int)num2 * -811625497) ^ 0x107C1C3E;
					continue;
				case 25u:
					num = ((int)num2 * -1122759612) ^ 0x51D8DC0;
					continue;
				case 24u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -1466439647) ^ -1872357562;
					continue;
				case 23u:
					num = (int)((num2 * 1300322611) ^ 0x3E98E45B);
					continue;
				case 22u:
					Form2.smethod_33((Form)(object)this, new Size(255, 224));
					num = ((int)num2 * -1627242298) ^ -1030334170;
					continue;
				case 21u:
					Form2.smethod_43((Control)(object)this);
					num = (int)((num2 * 953485418) ^ 0x22A29F59);
					continue;
				case 20u:
					Form2.smethod_28((Control)(object)textBox1, new KeyPressEventHandler(TextBox1_KeyPress));
					num = ((int)num2 * -1830894893) ^ -935173716;
					continue;
				case 19u:
					Form2.smethod_22((Control)(object)label2, new Point(53, 89));
					num = (int)(num2 * 2099974870) ^ -2011504683;
					continue;
				case 18u:
					Form2.smethod_22((Control)(object)label3, new Point(47, 177));
					num = (int)(num2 * 125932806) ^ -536308652;
					continue;
				case 17u:
					num = (int)((num2 * 2105090099) ^ 0xCF90CBC);
					continue;
				case 16u:
					Form2.smethod_36((Form)(object)this, (FormBorderStyle)1);
					num = (int)(num2 * 1030844770) ^ -2057792539;
					continue;
				case 15u:
					Form2.smethod_37((Form)(object)this, bool_0: false);
					num = ((int)num2 * -130863761) ^ -220738360;
					continue;
				case 14u:
					Form2.smethod_22((Control)(object)button1, new Point(86, 193));
					num = (int)((num2 * 1929172614) ^ 0x74B4A25E);
					continue;
				case 13u:
					Form2.smethod_24((Control)(object)textBox1, new Size(42, 80));
					num = ((int)num2 * -1833081726) ^ -2002493067;
					continue;
				case 12u:
					textBox1 = Form2.smethod_18();
					label2 = Form2.smethod_17();
					num = (int)(num2 * 623284970) ^ -864467103;
					continue;
				case 11u:
					num = ((int)num2 * -2039415698) ^ -536943655;
					continue;
				case 10u:
					Form2.smethod_39((Control)(object)this, "Form2");
					Form2.smethod_40((Form)(object)this, bool_0: false);
					num = (int)((num2 * 1692729018) ^ 0x372EEE13);
					continue;
				case 9u:
					Form2.smethod_21((Control)(object)label2, bool_0: true);
					Form2.smethod_27((Control)(object)label2, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 1450105860) ^ 0x22084B62);
					continue;
				case 8u:
					button1 = Form2.smethod_19();
					label3 = Form2.smethod_17();
					Form2.smethod_20((Control)(object)this);
					num = (int)((num2 * 1874482648) ^ 0x2B50FF9);
					continue;
				case 7u:
					Form2.smethod_1((Control)(object)label2, "+N=?");
					num = (int)((num2 * 925192950) ^ 0x7E4C6323);
					continue;
				case 6u:
					Form2.smethod_23((Control)(object)button1, "button1");
					num = (int)((num2 * 229531168) ^ 0x304E8C78);
					continue;
				case 5u:
					Form2.smethod_21((Control)(object)label3, bool_0: true);
					num = ((int)num2 * -1884244111) ^ -1078908076;
					continue;
				case 4u:
					Form2.smethod_38((Form)(object)this, bool_0: false);
					num = (int)(num2 * 337466667) ^ -1496943715;
					continue;
				case 3u:
					num = ((int)num2 * -132473471) ^ -1551146850;
					continue;
				case 2u:
					Form2.smethod_1((Control)(object)label1, "label1");
					num = (int)((num2 * 69297632) ^ 0x26FF48A4);
					continue;
				case 1u:
					Form2.smethod_24((Control)(object)label1, new Size(35, 13));
					Form2.smethod_25((Control)(object)label1, 0);
					num = ((int)num2 * -253766420) ^ 0x7494CF1;
					continue;
				case 0u:
					Form2.smethod_24((Control)(object)label3, new Size(0, 13));
					Form2.smethod_25((Control)(object)label3, 4);
					Form2.smethod_31((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -590941274) ^ -1843772953;
					continue;
				default:
					return;
				case 47u:
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
