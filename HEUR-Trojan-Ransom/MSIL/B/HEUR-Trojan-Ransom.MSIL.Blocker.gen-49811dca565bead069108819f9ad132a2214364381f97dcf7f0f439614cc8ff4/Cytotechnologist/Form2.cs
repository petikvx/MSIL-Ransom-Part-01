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
	}

	private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		bool flag = !char.IsDigit(Form2.smethod_4(e));
		bool flag2 = default(bool);
		while (true)
		{
			int num = -192127491;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF67F21E5u) % 11u)
				{
				case 10u:
					Form2.smethod_1((Control)(object)textBox1, "");
					num = -957529634;
					continue;
				case 9u:
					num = (int)(num2 * 1131017083) ^ -1489534704;
					continue;
				case 8u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = -1571142973;
						num6 = -1571142973;
					}
					else
					{
						num5 = -1514583587;
						num6 = -1514583587;
					}
					num = num5 ^ ((int)num2 * -817797616);
					continue;
				}
				case 6u:
				{
					int num3;
					int num4;
					if (!flag2)
					{
						num3 = -1819270402;
						num4 = -1819270402;
					}
					else
					{
						num3 = -1366086411;
						num4 = -1366086411;
					}
					num = num3 ^ (int)(num2 * 1891954057);
					continue;
				}
				case 5u:
					num = ((int)num2 * -1330946503) ^ -48311844;
					continue;
				case 4u:
					Button1_Click(this, Form2.smethod_6());
					num = (int)(num2 * 163712670) ^ -14568864;
					continue;
				case 3u:
					num = (int)((num2 * 971061113) ^ 0x11F0F3BF);
					continue;
				case 1u:
					flag2 = Form2.smethod_4(e) == '\r';
					num = -296057775;
					continue;
				case 0u:
					Form2.smethod_5(e, bool_0: true);
					num = ((int)num2 * -1859429822) ^ 0x12F28114;
					continue;
				default:
					return;
				case 2u:
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
		bool flag4 = default(bool);
		bool flag = default(bool);
		bool flag3 = default(bool);
		int num4 = default(int);
		int num3 = default(int);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -23460270;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD0499D0Au) % 34u)
				{
				case 33u:
					num = (int)((num2 * 1661885778) ^ 0x7B82194D);
					continue;
				case 32u:
				{
					int num12;
					int num13;
					if (flag4)
					{
						num12 = -2060461432;
						num13 = -2060461432;
					}
					else
					{
						num12 = -349665585;
						num13 = -349665585;
					}
					num = num12 ^ ((int)num2 * -846203567);
					continue;
				}
				case 31u:
					num = -135117755;
					continue;
				case 30u:
					Form2.smethod_14(Form2.smethod_11(Form2.smethod_2((Form)(object)this)));
					num = (int)(num2 * 209422946) ^ -1507279250;
					continue;
				case 29u:
				{
					Form control_ = Form2.smethod_2((Form)(object)this);
					int num9 = Form2.smethod_12((Control)(object)control_) - 1;
					Form2.smethod_13((Control)(object)control_, num9);
					flag4 = num9 > 1;
					num = -1532122880;
					continue;
				}
				case 27u:
					Form2.smethod_1((Control)(object)label3, "Поздравляем! Ваш ход первый.");
					num = ((int)num2 * -144775991) ^ 0x1965027B;
					continue;
				case 26u:
					num = -515453636;
					continue;
				case 25u:
				{
					int num10;
					int num11;
					if (!flag)
					{
						num10 = 1757989725;
						num11 = 1757989725;
					}
					else
					{
						num10 = 714588391;
						num11 = 714588391;
					}
					num = num10 ^ ((int)num2 * -1224665264);
					continue;
				}
				case 24u:
					flag3 = Form2.smethod_8(Form2.smethod_7((Control)(object)textBox1), "");
					num = ((int)num2 * -863831964) ^ -1605377007;
					continue;
				case 23u:
					(Form2.smethod_2((Form)(object)this) as Form3).Button_Continue();
					num = (int)(num2 * 12873293) ^ -985960512;
					continue;
				case 22u:
					num = -135117755;
					continue;
				case 21u:
					num = (int)((num2 * 1390512449) ^ 0x2DE9FACD);
					continue;
				case 20u:
					Form2.smethod_1((Control)(object)label2, Form2.smethod_10("+", num4.ToString(), "=", (num3 + num4).ToString()));
					num = ((int)num2 * -943835531) ^ 0x5F5EFC44;
					continue;
				case 18u:
					num = ((int)num2 * -343107843) ^ -616590385;
					continue;
				case 17u:
				{
					int num7;
					int num8;
					if (flag3)
					{
						num7 = 674442581;
						num8 = 674442581;
					}
					else
					{
						num7 = 1856200786;
						num8 = 1856200786;
					}
					num = num7 ^ (int)(num2 * 270956010);
					continue;
				}
				case 16u:
					num3 = int.Parse(Form2.smethod_7((Control)(object)textBox1));
					num = ((int)num2 * -1503766837) ^ -940032955;
					continue;
				case 15u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).StartGame();
					num = ((int)num2 * -1399705553) ^ 0x18DDB3D5;
					continue;
				case 14u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = false;
					num = (int)((num2 * 428533200) ^ 0x614BEC6D);
					continue;
				case 13u:
					num = ((int)num2 * -1998600149) ^ -1946202731;
					continue;
				case 12u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = 1753607030;
						num6 = 1753607030;
					}
					else
					{
						num5 = 746302059;
						num6 = 746302059;
					}
					num = num5 ^ ((int)num2 * -39417583);
					continue;
				}
				case 11u:
					num = (int)(num2 * 1409581820) ^ -751608298;
					continue;
				case 10u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = true;
					num = ((int)num2 * -719475435) ^ -326611645;
					continue;
				case 9u:
					num = ((int)num2 * -1917475482) ^ -991872480;
					continue;
				case 8u:
					num = ((int)num2 * -1584143576) ^ 0x69ABD018;
					continue;
				case 7u:
					num = (int)(num2 * 207428146) ^ -750619993;
					continue;
				case 6u:
					Form2.smethod_1((Control)(object)label3, "Первым ход делает Компьютер.");
					num = -1262431286;
					continue;
				case 5u:
					num4 = Form2.smethod_9(rnd, 10);
					num = (int)((num2 * 791964180) ^ 0x3B5BC6FE);
					continue;
				case 4u:
					flag2 = (num3 + num4) % 2 == 0;
					num = ((int)num2 * -2035267790) ^ 0x3D9B2316;
					continue;
				case 3u:
					flag = this.flag;
					num = (int)((num2 * 613518615) ^ 0x2E226912);
					continue;
				case 2u:
					this.flag = false;
					num = -812053537;
					continue;
				case 1u:
					num = (int)((num2 * 366825258) ^ 0x550CDE46);
					continue;
				case 0u:
					Form2.smethod_15((Form)(object)this);
					num = (int)((num2 * 1414292435) ^ 0x37781A00);
					continue;
				default:
					return;
				case 19u:
					break;
				case 28u:
					return;
				}
				break;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (!disposing)
		{
			goto IL_0009;
		}
		goto IL_006b;
		IL_006b:
		int num = 1009618989;
		goto IL_0070;
		IL_0070:
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x326D2BD3u) % 8u)
			{
			case 5u:
				((Form)this).Dispose(disposing);
				num = 1097630952;
				continue;
			case 4u:
				num = (int)((num2 * 955296216) ^ 0x1B614F7E);
				continue;
			case 3u:
				num = (int)(num2 * 464320461) ^ -78854365;
				continue;
			case 2u:
				Form2.smethod_16((IDisposable)components);
				num = ((int)num2 * -982317962) ^ -1622711205;
				continue;
			case 1u:
				num = (int)((num2 * 1847930959) ^ 0x43957D06);
				continue;
			case 0u:
				break;
			default:
				return;
			case 6u:
				goto IL_00a1;
			case 7u:
				return;
			}
			break;
			IL_00a1:
			if (components != null)
			{
				num = 2117339858;
				num3 = 2117339858;
				continue;
			}
			goto IL_0009;
		}
		goto IL_006b;
		IL_0009:
		num = 2123625118;
		num3 = 2123625118;
		goto IL_0070;
	}

	private void InitializeComponent()
	{
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected O, but got Unknown
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Expected O, but got Unknown
		while (true)
		{
			int num = 1963123536;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1E569319u) % 71u)
				{
				case 70u:
					Form2.smethod_24((Control)(object)textBox1, new Size(42, 80));
					num = ((int)num2 * -348382656) ^ 0x310061E7;
					continue;
				case 69u:
					num = (int)((num2 * 1966819327) ^ 0x1A8A105);
					continue;
				case 68u:
					Form2.smethod_25((Control)(object)textBox1, 1);
					num = (int)((num2 * 1663058733) ^ 0x17AE3265);
					continue;
				case 67u:
					Form2.smethod_30((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)((num2 * 1736186536) ^ 0x3786FC3E);
					continue;
				case 66u:
					num = (int)(num2 * 1001890528) ^ -462196895;
					continue;
				case 65u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)textBox1);
					num = ((int)num2 * -512992591) ^ -351505424;
					continue;
				case 64u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label3);
					num = ((int)num2 * -1502461233) ^ 0x71654130;
					continue;
				case 63u:
					num = ((int)num2 * -145775759) ^ 0x19339535;
					continue;
				case 62u:
					Form2.smethod_22((Control)(object)textBox1, new Point(24, 86));
					num = (int)(num2 * 1822006968) ^ -724243177;
					continue;
				case 61u:
					Form2.smethod_33((Form)(object)this, new Size(255, 224));
					num = ((int)num2 * -1094409804) ^ -241517898;
					continue;
				case 60u:
					Form2.smethod_22((Control)(object)label1, new Point(10, 10));
					num = ((int)num2 * -1414776473) ^ 0x420D2425;
					continue;
				case 59u:
					Form2.smethod_24((Control)(object)button1, new Size(73, 23));
					num = (int)(num2 * 1710892535) ^ -1337967492;
					continue;
				case 58u:
					label1 = Form2.smethod_17();
					num = (int)((num2 * 1257142008) ^ 0x4C3F5986);
					continue;
				case 57u:
					Form2.smethod_24((Control)(object)label3, new Size(0, 13));
					num = ((int)num2 * -579916592) ^ -1127036638;
					continue;
				case 56u:
					num = (int)(num2 * 1550541888) ^ -1533803086;
					continue;
				case 55u:
					Form2.smethod_42((Control)(object)this, bool_0: false);
					num = (int)((num2 * 2049472184) ^ 0x7DEA4466);
					continue;
				case 54u:
					num = (int)(num2 * 1921975935) ^ -586058371;
					continue;
				case 53u:
					num = ((int)num2 * -970418360) ^ -728316085;
					continue;
				case 52u:
					Form2.smethod_27((Control)(object)textBox1, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 1910147199) ^ -1623476896;
					continue;
				case 51u:
					Form2.smethod_1((Control)(object)label1, "label1");
					num = ((int)num2 * -249627524) ^ -1515061955;
					continue;
				case 50u:
					Form2.smethod_23((Control)(object)textBox1, "textBox1");
					num = ((int)num2 * -1693597722) ^ 0x3018B913;
					continue;
				case 49u:
					label3 = Form2.smethod_17();
					Form2.smethod_20((Control)(object)this);
					num = (int)((num2 * 433557961) ^ 0x68C0931C);
					continue;
				case 48u:
					Form2.smethod_23((Control)(object)label1, "label1");
					Form2.smethod_24((Control)(object)label1, new Size(35, 13));
					Form2.smethod_25((Control)(object)label1, 0);
					num = (int)((num2 * 652526805) ^ 0x1DEA5EAC);
					continue;
				case 47u:
					Form2.smethod_1((Control)(object)this, "Жеребьёвка");
					num = ((int)num2 * -1095859564) ^ 0x1B0B9829;
					continue;
				case 46u:
					num = (int)((num2 * 2142519955) ^ 0x3CFA73CE);
					continue;
				case 45u:
					Form2.smethod_37((Form)(object)this, bool_0: false);
					num = (int)(num2 * 382659489) ^ -847101664;
					continue;
				case 44u:
					Form2.smethod_28((Control)(object)textBox1, new KeyPressEventHandler(TextBox1_KeyPress));
					num = (int)((num2 * 490538974) ^ 0x6EA1D3B8);
					continue;
				case 43u:
					Form2.smethod_36((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -1610621170) ^ -1971981907;
					continue;
				case 42u:
					num = (int)((num2 * 1954576575) ^ 0x565EF628);
					continue;
				case 41u:
					Form2.smethod_21((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -1229007683) ^ 0x234B7CEF;
					continue;
				case 40u:
					num = ((int)num2 * -165936016) ^ -1617857304;
					continue;
				case 39u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -431668618) ^ 0xB67A7DE;
					continue;
				case 38u:
					Form2.smethod_40((Form)(object)this, bool_0: false);
					num = ((int)num2 * -523779890) ^ -1727800620;
					continue;
				case 37u:
					Form2.smethod_31((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)(num2 * 429654856) ^ -1899642493;
					continue;
				case 36u:
					Form2.smethod_38((Form)(object)this, bool_0: false);
					num = ((int)num2 * -688298658) ^ -1478274410;
					continue;
				case 35u:
					Form2.smethod_32((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -1344498470) ^ 0x4F43502E;
					continue;
				case 34u:
					num = ((int)num2 * -1659105245) ^ 0x51E82C8E;
					continue;
				case 33u:
					Form2.smethod_21((Control)(object)label3, bool_0: true);
					num = ((int)num2 * -1612973496) ^ -283251003;
					continue;
				case 32u:
					Form2.smethod_25((Control)(object)label3, 4);
					num = ((int)num2 * -549439109) ^ 0x3152DE17;
					continue;
				case 31u:
					num = ((int)num2 * -434916107) ^ 0x4577929D;
					continue;
				case 30u:
					Form2.smethod_21((Control)(object)label2, bool_0: true);
					num = (int)((num2 * 441775808) ^ 0x67E8ABC3);
					continue;
				case 29u:
					Form2.smethod_41((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
					num = ((int)num2 * -1040968970) ^ -2059853681;
					continue;
				case 28u:
					button1 = Form2.smethod_19();
					num = (int)(num2 * 1674752585) ^ -1885844834;
					continue;
				case 27u:
					num = (int)((num2 * 1021528456) ^ 0x7C90567D);
					continue;
				case 26u:
					num = (int)(num2 * 1119230617) ^ -1476038964;
					continue;
				case 25u:
					num = (int)(num2 * 67458253) ^ -730860371;
					continue;
				case 24u:
					num = (int)((num2 * 589163592) ^ 0x15CE6320);
					continue;
				case 23u:
					textBox1 = Form2.smethod_18();
					num = (int)(num2 * 2011339581) ^ -2000255247;
					continue;
				case 22u:
					Form2.smethod_22((Control)(object)label2, new Point(53, 89));
					num = ((int)num2 * -432110940) ^ -338395414;
					continue;
				case 21u:
					Form2.smethod_22((Control)(object)label3, new Point(47, 177));
					num = ((int)num2 * -657865469) ^ -21940696;
					continue;
				case 20u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label2);
					num = ((int)num2 * -1598277079) ^ -1074488591;
					continue;
				case 19u:
					Form2.smethod_29((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -333098985) ^ -4109470;
					continue;
				case 18u:
					Form2.smethod_1((Control)(object)label2, "+N=?");
					num = (int)(num2 * 937630090) ^ -1480955104;
					continue;
				case 17u:
					Form2.smethod_27((Control)(object)label2, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1117359222) ^ -1745944205;
					continue;
				case 16u:
					num = (int)(num2 * 1595208476) ^ -298315963;
					continue;
				case 15u:
					num = (int)((num2 * 2098725379) ^ 0x6507E985);
					continue;
				case 14u:
					num = ((int)num2 * -1198083792) ^ 0x359640C1;
					continue;
				case 13u:
					num = ((int)num2 * -1616477890) ^ 0x5D726F61;
					continue;
				case 12u:
					label2 = Form2.smethod_17();
					num = ((int)num2 * -1094660871) ^ -635025710;
					continue;
				case 11u:
					Form2.smethod_22((Control)(object)button1, new Point(86, 193));
					Form2.smethod_23((Control)(object)button1, "button1");
					num = ((int)num2 * -1374495611) ^ 0x389A12BD;
					continue;
				case 9u:
					Form2.smethod_23((Control)(object)label2, "label2");
					num = (int)((num2 * 634327835) ^ 0x25736541);
					continue;
				case 8u:
					num = (int)((num2 * 1875666011) ^ 0x573F32EE);
					continue;
				case 7u:
					Form2.smethod_25((Control)(object)button1, 3);
					num = ((int)num2 * -1896747364) ^ -892203294;
					continue;
				case 5u:
					Form2.smethod_23((Control)(object)label3, "label3");
					num = ((int)num2 * -91152155) ^ -1389745955;
					continue;
				case 4u:
					Form2.smethod_24((Control)(object)label2, new Size(188, 73));
					Form2.smethod_25((Control)(object)label2, 2);
					num = ((int)num2 * -2042757532) ^ -325003912;
					continue;
				case 3u:
					num = (int)(num2 * 2106529184) ^ -1254270731;
					continue;
				case 2u:
					Form2.smethod_39((Control)(object)this, "Form2");
					num = (int)(num2 * 951488152) ^ -1908823636;
					continue;
				case 1u:
					Form2.smethod_1((Control)(object)button1, "OK");
					num = ((int)num2 * -511671122) ^ 0x4F6D6680;
					continue;
				case 0u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label1);
					num = (int)(num2 * 148678285) ^ -1596865159;
					continue;
				case 10u:
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
