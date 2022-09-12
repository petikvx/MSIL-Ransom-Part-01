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
			int num = 1030523925;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2266A5D8u) % 3u)
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
				num = (int)(num2 * 164840862) ^ -1083195892;
			}
		}
	}

	private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = 824951230;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x12FAF0A0u) % 10u)
				{
				case 9u:
					Button1_Click(this, Form2.smethod_6());
					num = (int)((num2 * 1139989964) ^ 0x737F24D9);
					continue;
				case 8u:
				{
					int num5;
					int num6;
					if (char.IsDigit(Form2.smethod_4(e)))
					{
						num5 = 1228874709;
						num6 = 1228874709;
					}
					else
					{
						num5 = 1450793908;
						num6 = 1450793908;
					}
					num = num5 ^ ((int)num2 * -1132739953);
					continue;
				}
				case 7u:
					num = (int)((num2 * 928994579) ^ 0x6BDA10BF);
					continue;
				case 6u:
					Form2.smethod_5(e, bool_0: true);
					num = ((int)num2 * -294032497) ^ 0x1E456D3D;
					continue;
				case 5u:
					num = (int)(num2 * 1364071129) ^ -339482917;
					continue;
				case 4u:
					flag = Form2.smethod_4(e) == '\r';
					num = 360654673;
					continue;
				case 3u:
					Form2.smethod_1((Control)(object)textBox1, "");
					num = 1541628836;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1967124772;
						num4 = -1967124772;
					}
					else
					{
						num3 = -6850357;
						num4 = -6850357;
					}
					num = num3 ^ ((int)num2 * -225485069);
					continue;
				}
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		if (!Form2.smethod_8(Form2.smethod_7((Control)(object)textBox1), ""))
		{
			return;
		}
		int num6 = default(int);
		int num7 = default(int);
		int num3 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 1670094050;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8789601u) % 26u)
				{
				case 25u:
					num = 1584178587;
					continue;
				case 24u:
					num = ((int)num2 * -616212371) ^ 0x1A2395E5;
					continue;
				case 23u:
					this.flag = false;
					num = 80277842;
					continue;
				case 22u:
				{
					int num8;
					int num9;
					if ((num6 + num7) % 2 == 0)
					{
						num8 = 1456537005;
						num9 = 1456537005;
					}
					else
					{
						num8 = 1325736671;
						num9 = 1325736671;
					}
					num = num8 ^ (int)(num2 * 1791902614);
					continue;
				}
				case 21u:
					num = (int)((num2 * 89525797) ^ 0x1EDDB29B);
					continue;
				case 20u:
				{
					num6 = int.Parse(Form2.smethod_7((Control)(object)textBox1));
					num7 = Form2.smethod_9(rnd, 10);
					Label control_ = label2;
					string string_ = num7.ToString();
					num3 = num6 + num7;
					Form2.smethod_1((Control)(object)control_, Form2.smethod_10("+", string_, "=", num3.ToString()));
					num = ((int)num2 * -508611035) ^ -822739413;
					continue;
				}
				case 19u:
					num = (int)((num2 * 856678406) ^ 0x6515982E);
					continue;
				case 17u:
					Form2.smethod_1((Control)(object)label3, "Поздравляем! Ваш ход первый.");
					num = ((int)num2 * -940827181) ^ -1535630374;
					continue;
				case 15u:
				{
					Form control_2 = Form2.smethod_2((Form)(object)this);
					num3 = Form2.smethod_12((Control)(object)control_2) - 1;
					Form2.smethod_13((Control)(object)control_2, num3);
					num = 1074113250;
					continue;
				}
				case 14u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = true;
					num = (int)(num2 * 1520920548) ^ -1135240313;
					continue;
				case 13u:
					num = 977121048;
					continue;
				case 12u:
					(Form2.smethod_2((Form)(object)this) as Form3).Button_Continue();
					num = (int)(num2 * 581512926) ^ -564242411;
					continue;
				case 11u:
				{
					int num10;
					int num11;
					if (flag)
					{
						num10 = 1858793523;
						num11 = 1858793523;
					}
					else
					{
						num10 = 579871643;
						num11 = 579871643;
					}
					num = num10 ^ ((int)num2 * -2109226646);
					continue;
				}
				case 10u:
					num = (int)((num2 * 800929268) ^ 0x5EC89BAC);
					continue;
				case 9u:
					flag = this.flag;
					num = ((int)num2 * -1919585903) ^ -1076612073;
					continue;
				case 8u:
					num = ((int)num2 * -1233600350) ^ 0x387B0706;
					continue;
				case 7u:
					num = (int)((num2 * 1212119074) ^ 0x3488457);
					continue;
				case 6u:
					num = 132716680;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (num3 > 1)
					{
						num4 = -1919148911;
						num5 = -1919148911;
					}
					else
					{
						num4 = -1176843238;
						num5 = -1176843238;
					}
					num = num4 ^ ((int)num2 * -910237143);
					continue;
				}
				case 4u:
					Form2.smethod_14(Form2.smethod_11(Form2.smethod_2((Form)(object)this)));
					num = (int)((num2 * 1535401404) ^ 0x727F8C70);
					continue;
				case 3u:
					num = (int)(num2 * 1162902639) ^ -767437853;
					continue;
				case 2u:
					num = ((int)num2 * -1720012862) ^ 0x3AB896DE;
					continue;
				case 1u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).StartGame();
					Form2.smethod_15((Form)(object)this);
					num = ((int)num2 * -1175242817) ^ -1106992811;
					continue;
				case 0u:
					Form2.smethod_1((Control)(object)label3, "Первым ход делает Компьютер.");
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = false;
					num = 901930156;
					continue;
				default:
					return;
				case 16u:
					break;
				case 18u:
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
			int num = -1097621280;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0x91DD6647u) % 9u)
				{
				case 8u:
					num5 = ((components != null) ? 1 : 0);
					goto IL_000f;
				case 7u:
					Form2.smethod_16((IDisposable)components);
					num = (int)((num2 * 486678528) ^ 0x7E46C10D);
					continue;
				case 6u:
					num = (int)((num2 * 254418988) ^ 0x6C8F4425);
					continue;
				case 5u:
					num = (int)(num2 * 660176543) ^ -1479026683;
					continue;
				case 4u:
					if (disposing)
					{
						num = (int)(num2 * 1683399371) ^ -1943106059;
						continue;
					}
					num5 = 0;
					goto IL_000f;
				case 3u:
					num = ((int)num2 * -1958551917) ^ 0x12CC2829;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1547093982;
						num4 = 1547093982;
					}
					else
					{
						num3 = 535135832;
						num4 = 535135832;
					}
					num = num3 ^ (int)(num2 * 766270577);
					continue;
				}
				case 0u:
					break;
				default:
					{
						((Form)this).Dispose(disposing);
						return;
					}
					IL_000f:
					flag = (byte)num5 != 0;
					num = -595691078;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected O, but got Unknown
		//IL_05f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fe: Expected O, but got Unknown
		while (true)
		{
			int num = -700674430;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA347E751u) % 68u)
				{
				case 67u:
					num = (int)(num2 * 2043072181) ^ -411290195;
					continue;
				case 66u:
					Form2.smethod_27((Control)(object)textBox1, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 233607764) ^ 0x2E870839);
					continue;
				case 65u:
					num = ((int)num2 * -1302899078) ^ -194024179;
					continue;
				case 64u:
					Form2.smethod_24((Control)(object)button1, new Size(73, 23));
					num = (int)(num2 * 1346610354) ^ -1122414131;
					continue;
				case 63u:
					label1 = Form2.smethod_17();
					num = ((int)num2 * -921232954) ^ -452579991;
					continue;
				case 62u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)textBox1);
					num = ((int)num2 * -898494434) ^ -787399381;
					continue;
				case 61u:
					num = ((int)num2 * -1528439018) ^ 0x1723E4A0;
					continue;
				case 60u:
					num = (int)(num2 * 476713700) ^ -1657627771;
					continue;
				case 59u:
					Form2.smethod_22((Control)(object)button1, new Point(86, 193));
					num = (int)(num2 * 1405284233) ^ -1905814087;
					continue;
				case 58u:
					num = (int)((num2 * 1274144367) ^ 0xEEF3702);
					continue;
				case 56u:
					Form2.smethod_25((Control)(object)button1, 3);
					num = ((int)num2 * -780051452) ^ -1880777084;
					continue;
				case 55u:
					num = ((int)num2 * -1983347341) ^ 0x4EB5568;
					continue;
				case 54u:
					Form2.smethod_22((Control)(object)label1, new Point(10, 10));
					num = ((int)num2 * -1872568553) ^ -2027458620;
					continue;
				case 53u:
					Form2.smethod_43((Control)(object)this);
					num = ((int)num2 * -788092110) ^ -753790374;
					continue;
				case 52u:
					Form2.smethod_32((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -1690960166) ^ -1315386460;
					continue;
				case 51u:
					num = (int)(num2 * 1533610917) ^ -312522425;
					continue;
				case 50u:
					Form2.smethod_21((Control)(object)label3, bool_0: true);
					num = (int)(num2 * 1489515657) ^ -1230530988;
					continue;
				case 49u:
					Form2.smethod_39((Control)(object)this, "Form2");
					Form2.smethod_40((Form)(object)this, bool_0: false);
					num = ((int)num2 * -450460089) ^ -2145321376;
					continue;
				case 48u:
					num = ((int)num2 * -1709117738) ^ 0x37B7718D;
					continue;
				case 47u:
					num = (int)(num2 * 1812497178) ^ -702188391;
					continue;
				case 46u:
					Form2.smethod_23((Control)(object)label2, "label2");
					num = ((int)num2 * -1520820149) ^ -59803988;
					continue;
				case 45u:
					Form2.smethod_41((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
					Form2.smethod_42((Control)(object)this, bool_0: false);
					num = ((int)num2 * -1599336556) ^ -368659812;
					continue;
				case 44u:
					Form2.smethod_22((Control)(object)label2, new Point(53, 89));
					num = (int)((num2 * 699214291) ^ 0x4951B9C7);
					continue;
				case 43u:
					Form2.smethod_22((Control)(object)label3, new Point(47, 177));
					num = (int)((num2 * 1419349248) ^ 0x2CC5E785);
					continue;
				case 42u:
					num = (int)(num2 * 2079141400) ^ -1666119668;
					continue;
				case 41u:
					Form2.smethod_1((Control)(object)this, "Жеребьёвка");
					num = ((int)num2 * -119880121) ^ -334279099;
					continue;
				case 40u:
					Form2.smethod_21((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -619407048) ^ 0x63F83C4F;
					continue;
				case 39u:
					Form2.smethod_24((Control)(object)label1, new Size(35, 13));
					Form2.smethod_25((Control)(object)label1, 0);
					num = ((int)num2 * -1422303283) ^ -823554587;
					continue;
				case 38u:
					Form2.smethod_24((Control)(object)label3, new Size(0, 13));
					Form2.smethod_25((Control)(object)label3, 4);
					num = ((int)num2 * -1599563778) ^ -711953513;
					continue;
				case 37u:
					Form2.smethod_33((Form)(object)this, new Size(255, 224));
					num = (int)((num2 * 1083178489) ^ 0x112B20A5);
					continue;
				case 36u:
					num = ((int)num2 * -119373766) ^ 0x7C03D4E2;
					continue;
				case 35u:
					Form2.smethod_24((Control)(object)label2, new Size(188, 73));
					num = ((int)num2 * -1997480035) ^ -538858400;
					continue;
				case 34u:
					Form2.smethod_25((Control)(object)label2, 2);
					num = (int)((num2 * 1258695914) ^ 0x33416EB0);
					continue;
				case 33u:
					label3 = Form2.smethod_17();
					num = ((int)num2 * -2114118405) ^ 0x2F73DDC2;
					continue;
				case 32u:
					Form2.smethod_23((Control)(object)textBox1, "textBox1");
					num = (int)(num2 * 699122064) ^ -1098558522;
					continue;
				case 31u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -490157314) ^ -539499835;
					continue;
				case 30u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label2);
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label1);
					num = (int)(num2 * 1727506554) ^ -5079033;
					continue;
				case 29u:
					Form2.smethod_1((Control)(object)button1, "OK");
					num = ((int)num2 * -1179934986) ^ 0x21F5024D;
					continue;
				case 28u:
					Form2.smethod_37((Form)(object)this, bool_0: false);
					Form2.smethod_38((Form)(object)this, bool_0: false);
					num = ((int)num2 * -580584241) ^ 0x2C517249;
					continue;
				case 26u:
					textBox1 = Form2.smethod_18();
					label2 = Form2.smethod_17();
					num = (int)((num2 * 142662558) ^ 0x6688BF0F);
					continue;
				case 25u:
					Form2.smethod_23((Control)(object)button1, "button1");
					num = (int)((num2 * 2115914757) ^ 0x3CFE75BB);
					continue;
				case 24u:
					Form2.smethod_30((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)(num2 * 634251038) ^ -1897379324;
					continue;
				case 23u:
					Form2.smethod_1((Control)(object)label2, "+N=?");
					num = (int)(num2 * 84750646) ^ -644027908;
					continue;
				case 22u:
					Form2.smethod_1((Control)(object)label1, "label1");
					num = ((int)num2 * -104439615) ^ -274872935;
					continue;
				case 21u:
					Form2.smethod_23((Control)(object)label3, "label3");
					num = (int)((num2 * 225783675) ^ 0x44BEA16F);
					continue;
				case 20u:
					num = (int)((num2 * 1822127879) ^ 0x1A70E679);
					continue;
				case 19u:
					num = (int)(num2 * 1718317400) ^ -990193432;
					continue;
				case 18u:
					Form2.smethod_36((Form)(object)this, (FormBorderStyle)1);
					num = (int)((num2 * 400147363) ^ 0x1422FDB7);
					continue;
				case 17u:
					Form2.smethod_25((Control)(object)textBox1, 1);
					Form2.smethod_28((Control)(object)textBox1, new KeyPressEventHandler(TextBox1_KeyPress));
					num = (int)(num2 * 363112) ^ -624458535;
					continue;
				case 16u:
					Form2.smethod_20((Control)(object)this);
					num = ((int)num2 * -1460231005) ^ 0x478DE571;
					continue;
				case 15u:
					Form2.smethod_24((Control)(object)textBox1, new Size(42, 80));
					num = (int)((num2 * 911414814) ^ 0x9EAA2B2);
					continue;
				case 14u:
					num = (int)((num2 * 1505185430) ^ 0x129DEDFA);
					continue;
				case 13u:
					Form2.smethod_29((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -1072552314) ^ -24837865;
					continue;
				case 12u:
					Form2.smethod_22((Control)(object)textBox1, new Point(24, 86));
					num = (int)(num2 * 472741939) ^ -1271909499;
					continue;
				case 11u:
					num = ((int)num2 * -258098104) ^ 0x261DA559;
					continue;
				case 10u:
					num = ((int)num2 * -2142740181) ^ -1276194670;
					continue;
				case 9u:
					Form2.smethod_27((Control)(object)label2, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1542072382) ^ 0x78B73CEF;
					continue;
				case 8u:
					num = (int)((num2 * 526187622) ^ 0x561D1C88);
					continue;
				case 7u:
					Form2.smethod_23((Control)(object)label1, "label1");
					num = (int)(num2 * 1418977623) ^ -120618896;
					continue;
				case 6u:
					button1 = Form2.smethod_19();
					num = (int)(num2 * 1022174579) ^ -854355266;
					continue;
				case 5u:
					num = (int)((num2 * 1753877875) ^ 0x348936C8);
					continue;
				case 4u:
					num = ((int)num2 * -1384503616) ^ 0x6178277C;
					continue;
				case 3u:
					Form2.smethod_31((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)(num2 * 1646668582) ^ -29215508;
					continue;
				case 2u:
					num = ((int)num2 * -1247765372) ^ 0x6860522;
					continue;
				case 1u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label3);
					num = ((int)num2 * -206641139) ^ 0x52DF9402;
					continue;
				case 0u:
					Form2.smethod_21((Control)(object)label2, bool_0: true);
					num = ((int)num2 * -465210281) ^ 0x78D2556F;
					continue;
				default:
					return;
				case 27u:
					break;
				case 57u:
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
