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
		bool flag = default(bool);
		while (true)
		{
			int num = -2103007187;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB031E7B1u) % 9u)
				{
				case 8u:
					Form2.smethod_5(e, bool_0: true);
					num = ((int)num2 * -1783193588) ^ -1524595262;
					continue;
				case 7u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1329583134;
						num5 = -1329583134;
					}
					else
					{
						num4 = -1458915464;
						num5 = -1458915464;
					}
					num = num4 ^ (int)(num2 * 2110194744);
					continue;
				}
				case 4u:
					flag = !char.IsDigit(Form2.smethod_4(e));
					num = (int)(num2 * 1440501475) ^ -1965027974;
					continue;
				case 3u:
					num = (int)((num2 * 4704053) ^ 0x60BECC1D);
					continue;
				case 2u:
					Form2.smethod_1((Control)(object)textBox1, "");
					num = -1700153538;
					continue;
				case 1u:
					Button1_Click(this, Form2.smethod_6());
					num = ((int)num2 * -2132247462) ^ -412117324;
					continue;
				case 0u:
				{
					int num3;
					if (Form2.smethod_4(e) != '\r')
					{
						num = -560513252;
						num3 = -560513252;
					}
					else
					{
						num = -1546164459;
						num3 = -1546164459;
					}
					continue;
				}
				default:
					return;
				case 6u:
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
		bool flag = Form2.smethod_8(Form2.smethod_7((Control)(object)textBox1), "");
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = -210343836;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF46D6F0Du) % 34u)
				{
				case 33u:
					num = ((int)num2 * -1065184733) ^ -693271845;
					continue;
				case 32u:
				{
					int num8;
					int num9;
					if (flag2)
					{
						num8 = 311389337;
						num9 = 311389337;
					}
					else
					{
						num8 = 1381847929;
						num9 = 1381847929;
					}
					num = num8 ^ (int)(num2 * 1318744751);
					continue;
				}
				case 31u:
					Form2.smethod_15((Form)(object)this);
					num = ((int)num2 * -503295435) ^ -2000526817;
					continue;
				case 30u:
					num = ((int)num2 * -2138397857) ^ -2021045911;
					continue;
				case 29u:
					num = (int)(num2 * 1534635121) ^ -147546915;
					continue;
				case 28u:
					num = (int)((num2 * 70204032) ^ 0x5D392A0C);
					continue;
				case 27u:
				{
					int num12;
					int num13;
					if (flag)
					{
						num12 = -156702139;
						num13 = -156702139;
					}
					else
					{
						num12 = -592528833;
						num13 = -592528833;
					}
					num = num12 ^ (int)(num2 * 1918027230);
					continue;
				}
				case 25u:
					num = -732416641;
					continue;
				case 24u:
					flag3 = this.flag;
					num = (int)((num2 * 1484913328) ^ 0x370B4F26);
					continue;
				case 23u:
					num = ((int)num2 * -142236476) ^ 0x34D13DAA;
					continue;
				case 22u:
					num = -882343887;
					continue;
				case 21u:
					num = ((int)num2 * -320552787) ^ 0x9304A70;
					continue;
				case 20u:
					num = (int)((num2 * 353414674) ^ 0x4C834A7F);
					continue;
				case 19u:
				{
					int num10;
					int num11;
					if (flag3)
					{
						num10 = -1007047006;
						num11 = -1007047006;
					}
					else
					{
						num10 = -793096631;
						num11 = -793096631;
					}
					num = num10 ^ ((int)num2 * -104026344);
					continue;
				}
				case 18u:
					num = -1212934418;
					continue;
				case 17u:
					Form2.smethod_1((Control)(object)label3, "Поздравляем! Ваш ход первый.");
					num = (int)(num2 * 2033357862) ^ -1689774759;
					continue;
				case 16u:
					(Form2.smethod_2((Form)(object)this) as Form3).Button_Continue();
					num = ((int)num2 * -1677122402) ^ -104755214;
					continue;
				case 15u:
					num = ((int)num2 * -1870364792) ^ 0x2476CB19;
					continue;
				case 14u:
				{
					int num4 = int.Parse(Form2.smethod_7((Control)(object)textBox1));
					int num5 = Form2.smethod_9(rnd, 10);
					Label control_2 = label2;
					string string_ = num5.ToString();
					num3 = num4 + num5;
					Form2.smethod_1((Control)(object)control_2, Form2.smethod_10("+", string_, "=", num3.ToString()));
					int num6;
					int num7;
					if ((num4 + num5) % 2 != 0)
					{
						num6 = -1740157816;
						num7 = -1740157816;
					}
					else
					{
						num6 = -1095255000;
						num7 = -1095255000;
					}
					num = num6 ^ (int)(num2 * 622590087);
					continue;
				}
				case 13u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = false;
					num = (int)((num2 * 1738324574) ^ 0xC65C75D);
					continue;
				case 12u:
					num = -1045234516;
					continue;
				case 11u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = true;
					num = ((int)num2 * -802066328) ^ -897715084;
					continue;
				case 9u:
					num = (int)(num2 * 917259238) ^ -1840528659;
					continue;
				case 8u:
					num = (int)(num2 * 1032397275) ^ -596050585;
					continue;
				case 7u:
					num = (int)((num2 * 1703744752) ^ 0x3ABA5A61);
					continue;
				case 6u:
					this.flag = false;
					num = -1085418658;
					continue;
				case 5u:
					num = ((int)num2 * -1082250753) ^ 0x56C55B75;
					continue;
				case 4u:
					flag2 = num3 > 1;
					num = ((int)num2 * -1877687475) ^ 0x7DED77F5;
					continue;
				case 3u:
				{
					Form control_ = Form2.smethod_2((Form)(object)this);
					num3 = Form2.smethod_12((Control)(object)control_) - 1;
					Form2.smethod_13((Control)(object)control_, num3);
					num = -828680461;
					continue;
				}
				case 2u:
					num = (int)((num2 * 1522066927) ^ 0x16408D6);
					continue;
				case 1u:
					Form2.smethod_14(Form2.smethod_11(Form2.smethod_2((Form)(object)this)));
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).StartGame();
					num = ((int)num2 * -575337412) ^ 0x18CC4891;
					continue;
				case 0u:
					Form2.smethod_1((Control)(object)label3, "Первым ход делает Компьютер.");
					num = ((int)num2 * -2080559895) ^ -1847646696;
					continue;
				default:
					return;
				case 26u:
					break;
				case 10u:
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
			goto IL_0018;
		}
		int num = 0;
		goto IL_00b2;
		IL_00b2:
		bool flag = (byte)num != 0;
		int num2 = 1015142473;
		goto IL_0078;
		IL_0018:
		num2 = 1799891173;
		goto IL_0078;
		IL_0078:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x64915A6Au) % 8u)
			{
			case 6u:
				num2 = ((int)num3 * -131796884) ^ -1603287762;
				continue;
			case 5u:
				break;
			case 4u:
				((Form)this).Dispose(disposing);
				num2 = 853435851;
				continue;
			case 3u:
			{
				int num4;
				int num5;
				if (!flag)
				{
					num4 = 1429557093;
					num5 = 1429557093;
				}
				else
				{
					num4 = 122734729;
					num5 = 122734729;
				}
				num2 = num4 ^ (int)(num3 * 695954593);
				continue;
			}
			case 2u:
				Form2.smethod_16((IDisposable)components);
				num2 = (int)((num3 * 84624250) ^ 0x58316938);
				continue;
			case 0u:
				num2 = (int)(num3 * 310029226) ^ -2105506368;
				continue;
			default:
				return;
			case 7u:
				goto IL_00a9;
			case 1u:
				return;
			}
			break;
		}
		goto IL_0018;
		IL_00a9:
		num = ((components != null) ? 1 : 0);
		goto IL_00b2;
	}

	private void InitializeComponent()
	{
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Expected O, but got Unknown
		while (true)
		{
			int num = -1042104660;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD1B19D5Eu) % 64u)
				{
				case 63u:
					num = ((int)num2 * -1142693071) ^ -1578648871;
					continue;
				case 62u:
					Form2.smethod_25((Control)(object)label1, 0);
					num = (int)(num2 * 340514683) ^ -1775034142;
					continue;
				case 61u:
					Form2.smethod_42((Control)(object)this, bool_0: false);
					num = (int)(num2 * 1530566152) ^ -1821685833;
					continue;
				case 60u:
					button1 = Form2.smethod_19();
					num = ((int)num2 * -737718096) ^ 0x1C9085BF;
					continue;
				case 59u:
					Form2.smethod_24((Control)(object)label3, new Size(0, 13));
					num = (int)((num2 * 1298703128) ^ 0x7BD404DB);
					continue;
				case 58u:
					Form2.smethod_24((Control)(object)button1, new Size(73, 23));
					num = (int)(num2 * 286060135) ^ -441440989;
					continue;
				case 57u:
					Form2.smethod_32((ContainerControl)(object)this, (AutoScaleMode)1);
					Form2.smethod_33((Form)(object)this, new Size(255, 224));
					num = (int)(num2 * 1637849772) ^ -681697401;
					continue;
				case 56u:
					Form2.smethod_1((Control)(object)button1, "OK");
					num = ((int)num2 * -1566073373) ^ 0x6C834CB4;
					continue;
				case 55u:
					num = (int)(num2 * 995816546) ^ -24733016;
					continue;
				case 54u:
					num = (int)((num2 * 537929569) ^ 0x882B83F);
					continue;
				case 53u:
					Form2.smethod_21((Control)(object)label3, bool_0: true);
					num = (int)(num2 * 1286638908) ^ -476863370;
					continue;
				case 52u:
					Form2.smethod_41((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
					num = (int)((num2 * 717456256) ^ 0x64EF69A3);
					continue;
				case 51u:
					Form2.smethod_23((Control)(object)label3, "label3");
					num = ((int)num2 * -75708158) ^ -1013466589;
					continue;
				case 50u:
					label1 = Form2.smethod_17();
					textBox1 = Form2.smethod_18();
					label2 = Form2.smethod_17();
					num = ((int)num2 * -145785130) ^ -2039990418;
					continue;
				case 49u:
					num = ((int)num2 * -2024129292) ^ -401899489;
					continue;
				case 48u:
					Form2.smethod_31((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)(num2 * 1096452215) ^ -278816841;
					continue;
				case 47u:
					Form2.smethod_22((Control)(object)label1, new Point(10, 10));
					Form2.smethod_23((Control)(object)label1, "label1");
					num = ((int)num2 * -889286625) ^ 0x6F9AACCC;
					continue;
				case 46u:
					num = (int)(num2 * 1023468071) ^ -1239973296;
					continue;
				case 45u:
					Form2.smethod_27((Control)(object)textBox1, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1414410088) ^ -1374774352;
					continue;
				case 44u:
					num = ((int)num2 * -509502787) ^ 0x758C3F8F;
					continue;
				case 43u:
					num = ((int)num2 * -1951116833) ^ 0x40B2E4B4;
					continue;
				case 42u:
					Form2.smethod_24((Control)(object)textBox1, new Size(42, 80));
					Form2.smethod_25((Control)(object)textBox1, 1);
					num = ((int)num2 * -579312629) ^ -2069663969;
					continue;
				case 41u:
					num = ((int)num2 * -1270487984) ^ 0x2E3E3907;
					continue;
				case 40u:
					Form2.smethod_23((Control)(object)textBox1, "textBox1");
					num = ((int)num2 * -989002366) ^ 0x1720FFA4;
					continue;
				case 39u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label1);
					num = (int)((num2 * 1390059602) ^ 0x337DAC3E);
					continue;
				case 38u:
					Form2.smethod_23((Control)(object)label2, "label2");
					num = (int)((num2 * 102117408) ^ 0x16EDAE37);
					continue;
				case 37u:
					Form2.smethod_40((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1246420234) ^ -143958262;
					continue;
				case 36u:
					Form2.smethod_22((Control)(object)textBox1, new Point(24, 86));
					num = (int)((num2 * 867511910) ^ 0x7B9DBCEE);
					continue;
				case 35u:
					Form2.smethod_24((Control)(object)label1, new Size(35, 13));
					num = (int)((num2 * 580848671) ^ 0x716C3A5D);
					continue;
				case 34u:
					Form2.smethod_25((Control)(object)label2, 2);
					num = (int)(num2 * 382795698) ^ -69670444;
					continue;
				case 33u:
					label3 = Form2.smethod_17();
					Form2.smethod_20((Control)(object)this);
					Form2.smethod_21((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -1910613269) ^ -1775092550;
					continue;
				case 31u:
					Form2.smethod_25((Control)(object)button1, 3);
					num = (int)(num2 * 625280190) ^ -1578992277;
					continue;
				case 30u:
					Form2.smethod_36((Form)(object)this, (FormBorderStyle)1);
					Form2.smethod_37((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1394717727) ^ 0x4F99723F;
					continue;
				case 29u:
					Form2.smethod_22((Control)(object)button1, new Point(86, 193));
					num = (int)(num2 * 477844085) ^ -1718120239;
					continue;
				case 28u:
					num = (int)((num2 * 425873060) ^ 0x7E0151DE);
					continue;
				case 27u:
					num = (int)(num2 * 153355490) ^ -260546253;
					continue;
				case 26u:
					Form2.smethod_1((Control)(object)this, "Жеребьёвка");
					num = ((int)num2 * -739822466) ^ 0x487A8F26;
					continue;
				case 25u:
					num = (int)((num2 * 55687517) ^ 0x44CB7859);
					continue;
				case 24u:
					num = (int)((num2 * 345927376) ^ 0x6A7865FE);
					continue;
				case 23u:
					Form2.smethod_1((Control)(object)label1, "label1");
					num = (int)((num2 * 129073823) ^ 0x5D4E19BB);
					continue;
				case 22u:
					num = ((int)num2 * -1209600944) ^ -1566869222;
					continue;
				case 21u:
					num = ((int)num2 * -920731012) ^ 0x41A086F8;
					continue;
				case 20u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)textBox1);
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label2);
					num = ((int)num2 * -159977339) ^ 0x3E4F899D;
					continue;
				case 19u:
					num = (int)(num2 * 501134921) ^ -383462157;
					continue;
				case 18u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -1475093710) ^ -746655154;
					continue;
				case 17u:
					Form2.smethod_39((Control)(object)this, "Form2");
					num = ((int)num2 * -1886448893) ^ -544669635;
					continue;
				case 16u:
					num = (int)((num2 * 1000213784) ^ 0x70C31BFB);
					continue;
				case 15u:
					Form2.smethod_28((Control)(object)textBox1, new KeyPressEventHandler(TextBox1_KeyPress));
					num = ((int)num2 * -630041437) ^ 0x1B5EAF40;
					continue;
				case 14u:
					Form2.smethod_23((Control)(object)button1, "button1");
					num = (int)((num2 * 207743978) ^ 0x31C336E8);
					continue;
				case 13u:
					num = ((int)num2 * -1511430755) ^ -968448732;
					continue;
				case 12u:
					Form2.smethod_1((Control)(object)label2, "+N=?");
					num = (int)(num2 * 115598428) ^ -910214331;
					continue;
				case 11u:
					num = (int)(num2 * 321385972) ^ -1327296385;
					continue;
				case 10u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label3);
					num = ((int)num2 * -1024434642) ^ 0x60CE9F4B;
					continue;
				case 9u:
					Form2.smethod_24((Control)(object)label2, new Size(188, 73));
					num = ((int)num2 * -1017508236) ^ 0x2A1BF5E8;
					continue;
				case 8u:
					Form2.smethod_38((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1797543583) ^ -1395862713;
					continue;
				case 7u:
					Form2.smethod_22((Control)(object)label2, new Point(53, 89));
					num = ((int)num2 * -813516603) ^ -1757858853;
					continue;
				case 6u:
					Form2.smethod_21((Control)(object)label2, bool_0: true);
					Form2.smethod_27((Control)(object)label2, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 1075768622) ^ -40415347;
					continue;
				case 4u:
					Form2.smethod_22((Control)(object)label3, new Point(47, 177));
					num = (int)(num2 * 2073878791) ^ -29294415;
					continue;
				case 3u:
					Form2.smethod_25((Control)(object)label3, 4);
					num = ((int)num2 * -1785697961) ^ 0x34C11D87;
					continue;
				case 2u:
					Form2.smethod_29((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -445910041) ^ 0x1C65EED0;
					continue;
				case 1u:
					Form2.smethod_43((Control)(object)this);
					num = (int)(num2 * 1524172320) ^ -2031867162;
					continue;
				case 0u:
					Form2.smethod_30((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)((num2 * 216151587) ^ 0x2D906E2F);
					continue;
				default:
					return;
				case 5u:
					break;
				case 32u:
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
