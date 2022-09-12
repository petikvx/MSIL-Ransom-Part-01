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
			int num = 1717151320;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5646EB14u) % 3u)
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
				num = (int)(num2 * 2113504225) ^ -164405869;
			}
		}
	}

	private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		bool flag = !char.IsDigit(Form2.smethod_4(e));
		bool flag2 = default(bool);
		while (true)
		{
			int num = 1846215501;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x35FFB934u) % 10u)
				{
				case 9u:
					flag2 = Form2.smethod_4(e) == '\r';
					num = 1639747963;
					continue;
				case 8u:
					Button1_Click(this, Form2.smethod_6());
					num = ((int)num2 * -1091883184) ^ -855912931;
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = -1635945438;
						num6 = -1635945438;
					}
					else
					{
						num5 = -1310347449;
						num6 = -1310347449;
					}
					num = num5 ^ (int)(num2 * 1966846020);
					continue;
				}
				case 6u:
					Form2.smethod_5(e, bool_0: true);
					num = (int)(num2 * 1733443671) ^ -1288646732;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (flag2)
					{
						num3 = -799891755;
						num4 = -799891755;
					}
					else
					{
						num3 = -1196265186;
						num4 = -1196265186;
					}
					num = num3 ^ ((int)num2 * -456655763);
					continue;
				}
				case 4u:
					num = ((int)num2 * -1153662970) ^ 0x3860C4D3;
					continue;
				case 2u:
					num = ((int)num2 * -247072441) ^ 0x2321C282;
					continue;
				case 1u:
					Form2.smethod_1((Control)(object)textBox1, "");
					num = 1571026251;
					continue;
				default:
					return;
				case 0u:
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
		int num3 = default(int);
		bool flag3 = default(bool);
		int num5 = default(int);
		bool flag4 = default(bool);
		bool flag2 = default(bool);
		int num4 = default(int);
		while (true)
		{
			int num = 1035580708;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x61309448u) % 32u)
				{
				case 31u:
					num3 = int.Parse(Form2.smethod_7((Control)(object)textBox1));
					num = ((int)num2 * -1858650984) ^ -4855721;
					continue;
				case 30u:
					flag3 = num5 > 1;
					num = ((int)num2 * -1478621719) ^ -1179753108;
					continue;
				case 29u:
					num = (int)(num2 * 1823710486) ^ -1315004903;
					continue;
				case 28u:
					flag4 = this.flag;
					num = ((int)num2 * -283956260) ^ -450156179;
					continue;
				case 27u:
					(Form2.smethod_2((Form)(object)this) as Form3).Button_Continue();
					num = (int)((num2 * 199439294) ^ 0xA9D15D3);
					continue;
				case 26u:
					num = (int)((num2 * 1208306515) ^ 0x29D13E58);
					continue;
				case 25u:
					num = 2027237016;
					continue;
				case 24u:
				{
					int num8;
					int num9;
					if (!flag2)
					{
						num8 = -1923935670;
						num9 = -1923935670;
					}
					else
					{
						num8 = -1756276070;
						num9 = -1756276070;
					}
					num = num8 ^ ((int)num2 * -330729720);
					continue;
				}
				case 23u:
				{
					num4 = Form2.smethod_9(rnd, 10);
					Label control_2 = label2;
					string string_ = num4.ToString();
					num5 = num3 + num4;
					Form2.smethod_1((Control)(object)control_2, Form2.smethod_10("+", string_, "=", num5.ToString()));
					num = ((int)num2 * -107128515) ^ 0x5C34EBB4;
					continue;
				}
				case 21u:
				{
					int num12;
					int num13;
					if (flag4)
					{
						num12 = -289223435;
						num13 = -289223435;
					}
					else
					{
						num12 = -2132087479;
						num13 = -2132087479;
					}
					num = num12 ^ ((int)num2 * -395579592);
					continue;
				}
				case 20u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = false;
					num = (int)((num2 * 1878493458) ^ 0x792F4ED);
					continue;
				case 19u:
					num = 1439636545;
					continue;
				case 18u:
					num = ((int)num2 * -1294459623) ^ -1837632863;
					continue;
				case 17u:
					Form2.smethod_14(Form2.smethod_11(Form2.smethod_2((Form)(object)this)));
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).StartGame();
					num = (int)((num2 * 1800879079) ^ 0x4E4BEFBC);
					continue;
				case 16u:
					num = (int)((num2 * 1429744153) ^ 0x705A4211);
					continue;
				case 15u:
					num = 706861502;
					continue;
				case 14u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = true;
					num = ((int)num2 * -1043865501) ^ -1866369086;
					continue;
				case 13u:
					this.flag = false;
					num = 2052263276;
					continue;
				case 12u:
				{
					int num10;
					int num11;
					if (flag)
					{
						num10 = 2090408536;
						num11 = 2090408536;
					}
					else
					{
						num10 = 1555651666;
						num11 = 1555651666;
					}
					num = num10 ^ ((int)num2 * -596650655);
					continue;
				}
				case 11u:
					Form2.smethod_1((Control)(object)label3, "Поздравляем! Ваш ход первый.");
					num = (int)((num2 * 668286997) ^ 0x120B0041);
					continue;
				case 10u:
				{
					int num6;
					int num7;
					if (flag3)
					{
						num6 = -1983196323;
						num7 = -1983196323;
					}
					else
					{
						num6 = -1869453931;
						num7 = -1869453931;
					}
					num = num6 ^ ((int)num2 * -815207881);
					continue;
				}
				case 9u:
				{
					Form control_ = Form2.smethod_2((Form)(object)this);
					num5 = Form2.smethod_12((Control)(object)control_) - 1;
					Form2.smethod_13((Control)(object)control_, num5);
					num = 1494568978;
					continue;
				}
				case 8u:
					flag2 = (num3 + num4) % 2 == 0;
					num = ((int)num2 * -1903116711) ^ 0x210810B8;
					continue;
				case 7u:
					num = (int)((num2 * 383589685) ^ 0x2801F293);
					continue;
				case 5u:
					num = (int)((num2 * 305114332) ^ 0x47F6DD9B);
					continue;
				case 4u:
					num = ((int)num2 * -939556159) ^ -1613436605;
					continue;
				case 3u:
					Form2.smethod_15((Form)(object)this);
					num = ((int)num2 * -1209045253) ^ -447742056;
					continue;
				case 2u:
					Form2.smethod_1((Control)(object)label3, "Первым ход делает Компьютер.");
					num = 1234417884;
					continue;
				case 1u:
					num = (int)((num2 * 304705890) ^ 0x248B93B7);
					continue;
				case 0u:
					num = (int)(num2 * 2114049845) ^ -1186984091;
					continue;
				default:
					return;
				case 6u:
					break;
				case 22u:
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
			int num = -2079656773;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xA852B7B1u) % 7u)
				{
				case 6u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -889536664;
						num5 = -889536664;
					}
					else
					{
						num4 = -179223974;
						num5 = -179223974;
					}
					num = num4 ^ (int)(num2 * 1643201501);
					continue;
				}
				case 4u:
					Form2.smethod_16((IDisposable)components);
					num = (int)(num2 * 1830560892) ^ -708495238;
					continue;
				case 3u:
					((Form)this).Dispose(disposing);
					num = -806148293;
					continue;
				case 2u:
					num3 = ((components != null) ? 1 : 0);
					goto IL_005b;
				case 1u:
					if (disposing)
					{
						num = (int)(num2 * 48149043) ^ -508957674;
						continue;
					}
					num3 = 0;
					goto IL_005b;
				default:
					return;
				case 0u:
					break;
				case 5u:
					return;
					IL_005b:
					flag = (byte)num3 != 0;
					num = -84377139;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected O, but got Unknown
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected O, but got Unknown
		while (true)
		{
			int num = -1946062806;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8B3FA907u) % 63u)
				{
				case 62u:
					Form2.smethod_20((Control)(object)this);
					Form2.smethod_21((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -1453318750) ^ 0x600234D1;
					continue;
				case 61u:
					Form2.smethod_27((Control)(object)label2, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 1222292854) ^ -1693284323;
					continue;
				case 60u:
					Form2.smethod_22((Control)(object)label2, new Point(53, 89));
					Form2.smethod_23((Control)(object)label2, "label2");
					num = (int)(num2 * 1242671579) ^ -689748907;
					continue;
				case 59u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label2);
					num = (int)(num2 * 951341664) ^ -426811012;
					continue;
				case 58u:
					num = (int)((num2 * 58096123) ^ 0x628969E8);
					continue;
				case 57u:
					Form2.smethod_21((Control)(object)label3, bool_0: true);
					num = (int)((num2 * 1303384545) ^ 0x1D05A569);
					continue;
				case 56u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label1);
					num = (int)(num2 * 940161903) ^ -1663088538;
					continue;
				case 55u:
					Form2.smethod_27((Control)(object)textBox1, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 533536469) ^ -1127943545;
					continue;
				case 54u:
					textBox1 = Form2.smethod_18();
					num = ((int)num2 * -1988244078) ^ 0x37C1E060;
					continue;
				case 52u:
					Form2.smethod_37((Form)(object)this, bool_0: false);
					Form2.smethod_38((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1334917065) ^ -1516984111;
					continue;
				case 51u:
					Form2.smethod_25((Control)(object)button1, 3);
					num = (int)(num2 * 2033710444) ^ -165147589;
					continue;
				case 50u:
					Form2.smethod_1((Control)(object)button1, "OK");
					num = (int)((num2 * 481987328) ^ 0x1A811608);
					continue;
				case 49u:
					Form2.smethod_40((Form)(object)this, bool_0: false);
					num = (int)((num2 * 784629108) ^ 0x3CDF7B0E);
					continue;
				case 48u:
					Form2.smethod_1((Control)(object)label1, "label1");
					num = (int)(num2 * 2005802517) ^ -828935344;
					continue;
				case 47u:
					Form2.smethod_23((Control)(object)button1, "button1");
					Form2.smethod_24((Control)(object)button1, new Size(73, 23));
					num = (int)((num2 * 101045349) ^ 0x6785D3B8);
					continue;
				case 46u:
					num = (int)(num2 * 402639085) ^ -240631769;
					continue;
				case 45u:
					num = (int)(num2 * 290091356) ^ -740480622;
					continue;
				case 44u:
					Form2.smethod_25((Control)(object)label1, 0);
					num = ((int)num2 * -479934137) ^ -496863859;
					continue;
				case 43u:
					num = (int)(num2 * 1411877192) ^ -449723761;
					continue;
				case 42u:
					Form2.smethod_41((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
					num = (int)(num2 * 362128243) ^ -2133371207;
					continue;
				case 41u:
					Form2.smethod_22((Control)(object)label1, new Point(10, 10));
					Form2.smethod_23((Control)(object)label1, "label1");
					num = ((int)num2 * -1038876104) ^ 0x12243724;
					continue;
				case 40u:
					Form2.smethod_31((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)(num2 * 1765936422) ^ -1166945519;
					continue;
				case 39u:
					Form2.smethod_1((Control)(object)this, "Жеребьёвка");
					num = (int)(num2 * 1301699324) ^ -608909016;
					continue;
				case 38u:
					Form2.smethod_28((Control)(object)textBox1, new KeyPressEventHandler(TextBox1_KeyPress));
					num = (int)((num2 * 1021403943) ^ 0x5FA517AE);
					continue;
				case 37u:
					num = ((int)num2 * -204035610) ^ 0x430DC82D;
					continue;
				case 36u:
					num = (int)((num2 * 366768734) ^ 0x4BFBBF1F);
					continue;
				case 35u:
					num = (int)((num2 * 375015392) ^ 0x4EFDA20B);
					continue;
				case 34u:
					Form2.smethod_24((Control)(object)textBox1, new Size(42, 80));
					num = ((int)num2 * -1003789201) ^ -955886722;
					continue;
				case 33u:
					num = (int)((num2 * 1956778589) ^ 0x31CC5336);
					continue;
				case 32u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -1339105185) ^ -1668307245;
					continue;
				case 31u:
					num = (int)((num2 * 1431795542) ^ 0x636280A9);
					continue;
				case 30u:
					Form2.smethod_24((Control)(object)label2, new Size(188, 73));
					num = (int)((num2 * 1472949392) ^ 0x54A38088);
					continue;
				case 29u:
					Form2.smethod_22((Control)(object)textBox1, new Point(24, 86));
					num = ((int)num2 * -2026154488) ^ 0x6D6DAE7F;
					continue;
				case 28u:
					num = (int)((num2 * 190210897) ^ 0x67D5289F);
					continue;
				case 27u:
					num = (int)(num2 * 356928433) ^ -1006098500;
					continue;
				case 26u:
					label2 = Form2.smethod_17();
					button1 = Form2.smethod_19();
					num = ((int)num2 * -1143953030) ^ 0x7A5FC3C7;
					continue;
				case 25u:
					Form2.smethod_25((Control)(object)label3, 4);
					num = (int)(num2 * 1342708079) ^ -1786353145;
					continue;
				case 24u:
					Form2.smethod_25((Control)(object)label2, 2);
					Form2.smethod_1((Control)(object)label2, "+N=?");
					Form2.smethod_22((Control)(object)button1, new Point(86, 193));
					num = ((int)num2 * -2105042747) ^ -1523783605;
					continue;
				case 23u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label3);
					num = (int)(num2 * 1630729937) ^ -1543650566;
					continue;
				case 22u:
					label1 = Form2.smethod_17();
					num = (int)(num2 * 1882750086) ^ -320906875;
					continue;
				case 21u:
					Form2.smethod_43((Control)(object)this);
					num = ((int)num2 * -1726270200) ^ -605921889;
					continue;
				case 20u:
					label3 = Form2.smethod_17();
					num = (int)(num2 * 657646055) ^ -77749537;
					continue;
				case 19u:
					num = ((int)num2 * -980865735) ^ -389993681;
					continue;
				case 18u:
					Form2.smethod_32((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 488136537) ^ 0x1056D7C9);
					continue;
				case 17u:
					Form2.smethod_22((Control)(object)label3, new Point(47, 177));
					num = ((int)num2 * -1249454267) ^ 0x4ED617F7;
					continue;
				case 15u:
					num = ((int)num2 * -1799615316) ^ 0x1E66D5AB;
					continue;
				case 14u:
					Form2.smethod_29((ButtonBase)(object)button1, bool_0: true);
					Form2.smethod_30((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)(num2 * 662740689) ^ -999406766;
					continue;
				case 13u:
					Form2.smethod_36((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -79035413) ^ 0x348A56B2;
					continue;
				case 12u:
					Form2.smethod_21((Control)(object)label2, bool_0: true);
					num = (int)(num2 * 222166998) ^ -1055412467;
					continue;
				case 11u:
					num = (int)(num2 * 2059339895) ^ -1684000159;
					continue;
				case 10u:
					Form2.smethod_23((Control)(object)label3, "label3");
					Form2.smethod_24((Control)(object)label3, new Size(0, 13));
					num = ((int)num2 * -1332430098) ^ 0x283693AD;
					continue;
				case 9u:
					Form2.smethod_33((Form)(object)this, new Size(255, 224));
					num = ((int)num2 * -462503453) ^ 0x33F50E47;
					continue;
				case 8u:
					Form2.smethod_24((Control)(object)label1, new Size(35, 13));
					num = (int)((num2 * 1222890740) ^ 0x69066143);
					continue;
				case 7u:
					num = ((int)num2 * -36367891) ^ 0x269FCA32;
					continue;
				case 6u:
					Form2.smethod_25((Control)(object)textBox1, 1);
					num = (int)((num2 * 399543508) ^ 0x3F4FAF8B);
					continue;
				case 5u:
					Form2.smethod_39((Control)(object)this, "Form2");
					num = ((int)num2 * -2072578141) ^ -639157612;
					continue;
				case 4u:
					Form2.smethod_23((Control)(object)textBox1, "textBox1");
					num = ((int)num2 * -1620975418) ^ 0x57718F69;
					continue;
				case 3u:
					Form2.smethod_42((Control)(object)this, bool_0: false);
					num = ((int)num2 * -2139572823) ^ 0x7B6A8214;
					continue;
				case 2u:
					num = ((int)num2 * -695949396) ^ -1422870147;
					continue;
				case 1u:
					num = ((int)num2 * -1700775916) ^ -1344586169;
					continue;
				case 0u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)textBox1);
					num = ((int)num2 * -140292704) ^ 0x3828494D;
					continue;
				default:
					return;
				case 16u:
					break;
				case 53u:
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
