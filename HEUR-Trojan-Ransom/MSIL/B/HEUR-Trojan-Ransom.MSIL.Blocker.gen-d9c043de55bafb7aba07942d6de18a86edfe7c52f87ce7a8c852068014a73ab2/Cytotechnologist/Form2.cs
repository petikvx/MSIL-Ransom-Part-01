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
			int num = 1447755435;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x18702A8Au) % 5u)
				{
				case 3u:
					num = (int)(num2 * 2102492583) ^ -1011083452;
					continue;
				case 2u:
					InitializeComponent();
					num = (int)((num2 * 1117198593) ^ 0x25480089);
					continue;
				case 1u:
					num = ((int)num2 * -102879010) ^ -442463623;
					continue;
				case 0u:
					break;
				default:
					Form2.smethod_1((Control)(object)label1, "Введите любое число от 0 до 9 включительно.\nВаш соперник уже загадал число (N) из этого\nже диапазона. Если сумма ваших чисел будет\nчетным числом, то первым ход делаете Вы,\nиначе - ваш соперник Компьютер!");
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
			int num = -1033977560;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8B137841u) % 9u)
				{
				case 8u:
				{
					int num4;
					int num5;
					if (char.IsDigit(Form2.smethod_4(e)))
					{
						num4 = -488067954;
						num5 = -488067954;
					}
					else
					{
						num4 = -1872712067;
						num5 = -1872712067;
					}
					num = num4 ^ (int)(num2 * 561277945);
					continue;
				}
				case 7u:
					num = (int)((num2 * 2086032041) ^ 0x165AB4A3);
					continue;
				case 6u:
				{
					int num3;
					if (Form2.smethod_4(e) == '\r')
					{
						num = -481101197;
						num3 = -481101197;
					}
					else
					{
						num = -401974752;
						num3 = -401974752;
					}
					continue;
				}
				case 5u:
					Form2.smethod_1((Control)(object)textBox1, "");
					num = -10069534;
					continue;
				case 4u:
					Button1_Click(this, Form2.smethod_6());
					num = (int)(num2 * 253454601) ^ -1927073080;
					continue;
				case 2u:
					Form2.smethod_5(e, bool_0: true);
					num = (int)(num2 * 2067173654) ^ -1314247336;
					continue;
				case 1u:
					num = ((int)num2 * -1962030096) ^ -840911758;
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
		if (!Form2.smethod_8(Form2.smethod_7((Control)(object)textBox1), ""))
		{
			return;
		}
		int num5 = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = -1490201228;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD7678AE2u) % 35u)
				{
				case 34u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = true;
					num = ((int)num2 * -434834249) ^ -1051437862;
					continue;
				case 33u:
					Form2.smethod_1((Control)(object)label3, "Поздравляем! Ваш ход первый.");
					num = ((int)num2 * -2080502900) ^ 0x4118DB18;
					continue;
				case 32u:
					num = -1209592314;
					continue;
				case 31u:
					(Form2.smethod_2((Form)(object)this) as Form3).Button_Continue();
					num = ((int)num2 * -40476996) ^ -1341314763;
					continue;
				case 30u:
					Form2.smethod_14(Form2.smethod_11(Form2.smethod_2((Form)(object)this)));
					num = ((int)num2 * -1046331066) ^ -1817249627;
					continue;
				case 29u:
					Form2.smethod_15((Form)(object)this);
					num = ((int)num2 * -277191377) ^ -363480142;
					continue;
				case 28u:
					Form2.smethod_1((Control)(object)label3, "Первым ход делает Компьютер.");
					num = (int)((num2 * 307458769) ^ 0x614CE201);
					continue;
				case 27u:
				{
					Form control_2 = Form2.smethod_2((Form)(object)this);
					num5 = Form2.smethod_12((Control)(object)control_2) - 1;
					Form2.smethod_13((Control)(object)control_2, num5);
					num = -1006502909;
					continue;
				}
				case 25u:
					num = ((int)num2 * -929879381) ^ -1946864668;
					continue;
				case 24u:
				{
					int num10;
					int num11;
					if (num5 <= 1)
					{
						num10 = 1457504547;
						num11 = 1457504547;
					}
					else
					{
						num10 = 124763560;
						num11 = 124763560;
					}
					num = num10 ^ ((int)num2 * -1996926439);
					continue;
				}
				case 23u:
					num = (int)((num2 * 1728522192) ^ 0x3FB184FC);
					continue;
				case 22u:
					num = (int)((num2 * 1609364455) ^ 0x78400AB3);
					continue;
				case 21u:
					num = (int)(num2 * 1177667723) ^ -203635584;
					continue;
				case 20u:
					num = ((int)num2 * -801955871) ^ 0x406DD758;
					continue;
				case 19u:
					num = ((int)num2 * -656864794) ^ 0x76ECF761;
					continue;
				case 18u:
					flag = this.flag;
					num = (int)(num2 * 13266257) ^ -1707490664;
					continue;
				case 17u:
					num = ((int)num2 * -1584822777) ^ 0x16F6E6E;
					continue;
				case 16u:
					num = ((int)num2 * -1909012111) ^ -1490419800;
					continue;
				case 15u:
				{
					int num8;
					int num9;
					if (!flag2)
					{
						num8 = -2113944504;
						num9 = -2113944504;
					}
					else
					{
						num8 = -1277260085;
						num9 = -1277260085;
					}
					num = num8 ^ ((int)num2 * -1781155257);
					continue;
				}
				case 14u:
					num = (int)((num2 * 557075978) ^ 0x7EA46AA1);
					continue;
				case 13u:
					num3 = Form2.smethod_9(rnd, 10);
					num = ((int)num2 * -1457390224) ^ 0x5A890B71;
					continue;
				case 11u:
					this.flag = false;
					num = -657575647;
					continue;
				case 10u:
					num = -1107984718;
					continue;
				case 9u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).StartGame();
					num = ((int)num2 * -812762669) ^ -1182035608;
					continue;
				case 8u:
					flag2 = (num4 + num3) % 2 == 0;
					num = ((int)num2 * -221937270) ^ 0x40A5802C;
					continue;
				case 7u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = false;
					num = ((int)num2 * -947890906) ^ -1718221300;
					continue;
				case 6u:
					num = ((int)num2 * -1012233082) ^ -1416410444;
					continue;
				case 5u:
					num4 = int.Parse(Form2.smethod_7((Control)(object)textBox1));
					num = ((int)num2 * -758200957) ^ 0x6EE9DF83;
					continue;
				case 4u:
				{
					int num6;
					int num7;
					if (!flag)
					{
						num6 = 1205988986;
						num7 = 1205988986;
					}
					else
					{
						num6 = 895619686;
						num7 = 895619686;
					}
					num = num6 ^ ((int)num2 * -1650218263);
					continue;
				}
				case 3u:
					num = -115785023;
					continue;
				case 2u:
					num = -1894854820;
					continue;
				case 1u:
					num = (int)(num2 * 335992937) ^ -462125631;
					continue;
				case 0u:
				{
					Label control_ = label2;
					string string_ = num3.ToString();
					num5 = num4 + num3;
					Form2.smethod_1((Control)(object)control_, Form2.smethod_10("+", string_, "=", num5.ToString()));
					num = (int)((num2 * 1031464465) ^ 0x26B99416);
					continue;
				}
				default:
					return;
				case 12u:
					break;
				case 26u:
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
		IL_00b2:
		bool flag = (byte)num != 0;
		int num2 = -548237174;
		goto IL_0078;
		IL_0009:
		num2 = -1595802224;
		goto IL_0078;
		IL_0078:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0xDFD4F849u) % 8u)
			{
			case 7u:
				break;
			case 6u:
				Form2.smethod_16((IDisposable)components);
				num2 = (int)((num3 * 775698552) ^ 0x3DB5E521);
				continue;
			case 4u:
				((Form)this).Dispose(disposing);
				num2 = -874109388;
				continue;
			case 3u:
			{
				int num4;
				int num5;
				if (!flag)
				{
					num4 = 17422766;
					num5 = 17422766;
				}
				else
				{
					num4 = 644889860;
					num5 = 644889860;
				}
				num2 = num4 ^ (int)(num3 * 1328012793);
				continue;
			}
			case 2u:
				num2 = ((int)num3 * -118370514) ^ 0xCBB9AE9;
				continue;
			case 0u:
				num2 = (int)(num3 * 901431322) ^ -1802622845;
				continue;
			default:
				return;
			case 1u:
				goto IL_00a9;
			case 5u:
				return;
			}
			break;
		}
		goto IL_0009;
		IL_00a9:
		num = ((components != null) ? 1 : 0);
		goto IL_00b2;
	}

	private void InitializeComponent()
	{
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Expected O, but got Unknown
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_0512: Expected O, but got Unknown
		while (true)
		{
			int num = 1546650931;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x223C1A2Au) % 59u)
				{
				case 58u:
					num = (int)((num2 * 530860031) ^ 0x6EFB88F);
					continue;
				case 57u:
					num = ((int)num2 * -1136642496) ^ 0x28762CE6;
					continue;
				case 56u:
					Form2.smethod_25((Control)(object)button1, 3);
					num = ((int)num2 * -1456043311) ^ 0xCDC938C;
					continue;
				case 55u:
					Form2.smethod_24((Control)(object)label3, new Size(0, 13));
					Form2.smethod_25((Control)(object)label3, 4);
					num = (int)(num2 * 2108010337) ^ -560122912;
					continue;
				case 54u:
					Form2.smethod_21((Control)(object)label3, bool_0: true);
					Form2.smethod_22((Control)(object)label3, new Point(47, 177));
					num = ((int)num2 * -1992878663) ^ -1899963796;
					continue;
				case 53u:
					Form2.smethod_33((Form)(object)this, new Size(255, 224));
					num = (int)((num2 * 1909177627) ^ 0xEB48F4E);
					continue;
				case 52u:
					Form2.smethod_24((Control)(object)label2, new Size(188, 73));
					num = ((int)num2 * -1791485044) ^ 0x204F2F1E;
					continue;
				case 51u:
					num = ((int)num2 * -1375043612) ^ -483004386;
					continue;
				case 50u:
					num = ((int)num2 * -1205925929) ^ -1951767092;
					continue;
				case 49u:
					Form2.smethod_42((Control)(object)this, bool_0: false);
					num = (int)((num2 * 1190937772) ^ 0x7D89EF8);
					continue;
				case 48u:
					Form2.smethod_24((Control)(object)button1, new Size(73, 23));
					num = ((int)num2 * -112808525) ^ 0x6DDA7C33;
					continue;
				case 47u:
					num = (int)(num2 * 865866003) ^ -1185548134;
					continue;
				case 45u:
					num = ((int)num2 * -125483158) ^ 0x7462833E;
					continue;
				case 44u:
					Form2.smethod_23((Control)(object)label1, "label1");
					num = ((int)num2 * -153807358) ^ 0x1B3AF868;
					continue;
				case 43u:
					Form2.smethod_22((Control)(object)button1, new Point(86, 193));
					num = ((int)num2 * -1792476545) ^ -1865564539;
					continue;
				case 42u:
					button1 = Form2.smethod_19();
					label3 = Form2.smethod_17();
					num = (int)((num2 * 513514846) ^ 0x7026DC80);
					continue;
				case 41u:
					num = ((int)num2 * -459320540) ^ 0x7D867F4E;
					continue;
				case 40u:
					Form2.smethod_40((Form)(object)this, bool_0: false);
					num = (int)((num2 * 642179898) ^ 0x65EC14AD);
					continue;
				case 39u:
					Form2.smethod_20((Control)(object)this);
					num = (int)((num2 * 1119470372) ^ 0x3F990D37);
					continue;
				case 38u:
					Form2.smethod_1((Control)(object)button1, "OK");
					Form2.smethod_29((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -51511774) ^ 0x78876FCD;
					continue;
				case 37u:
					Form2.smethod_22((Control)(object)textBox1, new Point(24, 86));
					Form2.smethod_23((Control)(object)textBox1, "textBox1");
					num = ((int)num2 * -1754019178) ^ -391789450;
					continue;
				case 36u:
					num = ((int)num2 * -784271081) ^ 0x23BD0589;
					continue;
				case 35u:
					Form2.smethod_27((Control)(object)textBox1, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 1325624018) ^ 0xD070E);
					continue;
				case 34u:
					Form2.smethod_38((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1796976333) ^ -602773992;
					continue;
				case 33u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -540908591) ^ -2063651641;
					continue;
				case 32u:
					Form2.smethod_23((Control)(object)button1, "button1");
					num = ((int)num2 * -1118666447) ^ 0x2C8625D9;
					continue;
				case 31u:
					Form2.smethod_23((Control)(object)label2, "label2");
					num = ((int)num2 * -450836323) ^ 0x5F6897C4;
					continue;
				case 30u:
					Form2.smethod_1((Control)(object)label1, "label1");
					num = ((int)num2 * -1777535767) ^ 0x6AAE24A4;
					continue;
				case 29u:
					Form2.smethod_36((Form)(object)this, (FormBorderStyle)1);
					num = (int)(num2 * 1300666784) ^ -947964041;
					continue;
				case 28u:
					Form2.smethod_25((Control)(object)textBox1, 1);
					Form2.smethod_28((Control)(object)textBox1, new KeyPressEventHandler(TextBox1_KeyPress));
					Form2.smethod_21((Control)(object)label2, bool_0: true);
					num = (int)(num2 * 2093661218) ^ -830557419;
					continue;
				case 27u:
					Form2.smethod_27((Control)(object)label2, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -243558589) ^ -1518675167;
					continue;
				case 26u:
					num = ((int)num2 * -284902118) ^ 0x5A7962E7;
					continue;
				case 25u:
					Form2.smethod_23((Control)(object)label3, "label3");
					num = ((int)num2 * -1555886326) ^ 0x37477DA6;
					continue;
				case 24u:
					Form2.smethod_21((Control)(object)label1, bool_0: true);
					num = (int)(num2 * 281772098) ^ -1429834529;
					continue;
				case 23u:
					Form2.smethod_31((ContainerControl)(object)this, new SizeF(6f, 13f));
					Form2.smethod_32((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 701256746) ^ 0x72BDC413);
					continue;
				case 22u:
					Form2.smethod_1((Control)(object)label2, "+N=?");
					num = ((int)num2 * -205073399) ^ 0x4BC6977A;
					continue;
				case 21u:
					Form2.smethod_37((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1754502269) ^ 0x2228B94C;
					continue;
				case 20u:
					Form2.smethod_24((Control)(object)label1, new Size(35, 13));
					Form2.smethod_25((Control)(object)label1, 0);
					num = ((int)num2 * -1599012969) ^ 0x67AE340E;
					continue;
				case 19u:
					Form2.smethod_41((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
					num = (int)(num2 * 1390239954) ^ -1008650577;
					continue;
				case 17u:
					textBox1 = Form2.smethod_18();
					label2 = Form2.smethod_17();
					num = (int)(num2 * 1522425823) ^ -1036654911;
					continue;
				case 16u:
					num = (int)(num2 * 1676006536) ^ -1877613557;
					continue;
				case 15u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label3);
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)button1);
					num = (int)((num2 * 1171229826) ^ 0x5FD56675);
					continue;
				case 14u:
					Form2.smethod_1((Control)(object)this, "Жеребьёвка");
					num = ((int)num2 * -988355793) ^ 0x3FB682E6;
					continue;
				case 13u:
					Form2.smethod_39((Control)(object)this, "Form2");
					num = (int)(num2 * 359694466) ^ -1753647392;
					continue;
				case 12u:
					num = ((int)num2 * -1282102470) ^ 0x3BD806B;
					continue;
				case 11u:
					Form2.smethod_30((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -972078537) ^ -665500549;
					continue;
				case 10u:
					Form2.smethod_24((Control)(object)textBox1, new Size(42, 80));
					num = ((int)num2 * -348206097) ^ -2100132664;
					continue;
				case 9u:
					Form2.smethod_25((Control)(object)label2, 2);
					num = ((int)num2 * -84798418) ^ 0x4C4B64E7;
					continue;
				case 8u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)textBox1);
					num = ((int)num2 * -1781150999) ^ -856703420;
					continue;
				case 7u:
					num = (int)(num2 * 781377555) ^ -369504428;
					continue;
				case 6u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label2);
					num = (int)((num2 * 1768987702) ^ 0x6BA83616);
					continue;
				case 5u:
					Form2.smethod_43((Control)(object)this);
					num = (int)(num2 * 2027973440) ^ -1590218463;
					continue;
				case 4u:
					num = (int)(num2 * 1260964339) ^ -412364369;
					continue;
				case 3u:
					Form2.smethod_22((Control)(object)label2, new Point(53, 89));
					num = ((int)num2 * -1904339657) ^ -1665480018;
					continue;
				case 2u:
					label1 = Form2.smethod_17();
					num = ((int)num2 * -1434859938) ^ -1429978638;
					continue;
				case 1u:
					num = ((int)num2 * -1541442256) ^ -1019094163;
					continue;
				case 0u:
					Form2.smethod_22((Control)(object)label1, new Point(10, 10));
					num = ((int)num2 * -2002887429) ^ -780493243;
					continue;
				default:
					return;
				case 18u:
					break;
				case 46u:
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
