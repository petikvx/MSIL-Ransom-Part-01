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
			int num = 1271406970;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3B805EE4u) % 8u)
				{
				case 6u:
					num = (int)(num2 * 2060132213) ^ -1800070352;
					continue;
				case 4u:
					num = ((int)num2 * -840515823) ^ -2067297632;
					continue;
				case 3u:
					num = (int)((num2 * 1378689954) ^ 0x4629D77);
					continue;
				case 2u:
					num = (int)(num2 * 1027999305) ^ -550217217;
					continue;
				case 1u:
					InitializeComponent();
					num = (int)((num2 * 1568698275) ^ 0x3342AA9B);
					continue;
				case 0u:
					Form2.smethod_1((Control)(object)label1, "Введите любое число от 0 до 9 включительно.\nВаш соперник уже загадал число (N) из этого\nже диапазона. Если сумма ваших чисел будет\nчетным числом, то первым ход делаете Вы,\nиначе - ваш соперник Компьютер!");
					num = (int)((num2 * 1977432132) ^ 0x5507255F);
					continue;
				default:
					return;
				case 7u:
					break;
				case 5u:
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
		bool flag = default(bool);
		while (true)
		{
			int num = -1414673912;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE733DA03u) % 10u)
				{
				case 7u:
				{
					int num5;
					if (Form2.smethod_4(e) != '\r')
					{
						num = -1845389224;
						num5 = -1845389224;
					}
					else
					{
						num = -1288294067;
						num5 = -1288294067;
					}
					continue;
				}
				case 6u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1154651300;
						num4 = 1154651300;
					}
					else
					{
						num3 = 679808705;
						num4 = 679808705;
					}
					num = num3 ^ ((int)num2 * -468789337);
					continue;
				}
				case 5u:
					Form2.smethod_5(e, bool_0: true);
					num = (int)((num2 * 1366357617) ^ 0xFA9FF0F);
					continue;
				case 4u:
					num = ((int)num2 * -328078412) ^ 0x50127DA6;
					continue;
				case 3u:
					num = ((int)num2 * -1523339640) ^ 0x1DD67250;
					continue;
				case 2u:
					Button1_Click(this, Form2.smethod_6());
					num = ((int)num2 * -1686510878) ^ 0x784570AE;
					continue;
				case 1u:
					flag = !char.IsDigit(Form2.smethod_4(e));
					num = (int)((num2 * 858717715) ^ 0xFC59160);
					continue;
				case 0u:
					Form2.smethod_1((Control)(object)textBox1, "");
					num = -20673277;
					continue;
				default:
					return;
				case 8u:
					break;
				case 9u:
					return;
				}
				break;
			}
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		int num5 = default(int);
		int num4 = default(int);
		int num3 = default(int);
		bool flag = default(bool);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -1769666245;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE6B82FE9u) % 31u)
				{
				case 30u:
				{
					Form control_2 = Form2.smethod_2((Form)(object)this);
					num5 = Form2.smethod_12((Control)(object)control_2) - 1;
					Form2.smethod_13((Control)(object)control_2, num5);
					num = -237617963;
					continue;
				}
				case 29u:
					Form2.smethod_14(Form2.smethod_11(Form2.smethod_2((Form)(object)this)));
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).StartGame();
					num = ((int)num2 * -1851733702) ^ 0x32C2D3E5;
					continue;
				case 28u:
				{
					int num12;
					int num13;
					if ((num4 + num3) % 2 == 0)
					{
						num12 = 981521878;
						num13 = 981521878;
					}
					else
					{
						num12 = 1415233346;
						num13 = 1415233346;
					}
					num = num12 ^ ((int)num2 * -503558361);
					continue;
				}
				case 27u:
				{
					int num8;
					int num9;
					if (flag)
					{
						num8 = -187446309;
						num9 = -187446309;
					}
					else
					{
						num8 = -825876240;
						num9 = -825876240;
					}
					num = num8 ^ ((int)num2 * -794977935);
					continue;
				}
				case 26u:
					num = -100574460;
					continue;
				case 25u:
					flag3 = num5 > 1;
					num = (int)((num2 * 1680550828) ^ 0x526CFA0F);
					continue;
				case 24u:
				{
					int num10;
					int num11;
					if (flag2)
					{
						num10 = 508543477;
						num11 = 508543477;
					}
					else
					{
						num10 = 242758299;
						num11 = 242758299;
					}
					num = num10 ^ (int)(num2 * 1520033084);
					continue;
				}
				case 22u:
					num = (int)((num2 * 1344496942) ^ 0x1927D170);
					continue;
				case 21u:
					num4 = int.Parse(Form2.smethod_7((Control)(object)textBox1));
					num = ((int)num2 * -1866905592) ^ -215465667;
					continue;
				case 20u:
					num = (int)((num2 * 5737370) ^ 0x2278837D);
					continue;
				case 19u:
					num = ((int)num2 * -925689441) ^ 0x54BEE796;
					continue;
				case 18u:
					num = ((int)num2 * -57142353) ^ 0x6FE78439;
					continue;
				case 17u:
					Form2.smethod_1((Control)(object)label3, "Поздравляем! Ваш ход первый.");
					num = ((int)num2 * -928182678) ^ 0x72813DDF;
					continue;
				case 16u:
					num = ((int)num2 * -1272640694) ^ -1761116357;
					continue;
				case 15u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = true;
					num = (int)(num2 * 1251719832) ^ -1422986380;
					continue;
				case 14u:
				{
					int num6;
					int num7;
					if (!flag3)
					{
						num6 = -160337647;
						num7 = -160337647;
					}
					else
					{
						num6 = -1717970240;
						num7 = -1717970240;
					}
					num = num6 ^ (int)(num2 * 1540563521);
					continue;
				}
				case 13u:
					num = (int)((num2 * 1137659376) ^ 0x33514F9E);
					continue;
				case 12u:
					flag2 = this.flag;
					num = (int)(num2 * 264726835) ^ -1714924576;
					continue;
				case 11u:
					(Form2.smethod_2((Form)(object)this) as Form3).Button_Continue();
					num = (int)((num2 * 316003087) ^ 0xF18F24F);
					continue;
				case 10u:
					flag = Form2.smethod_8(Form2.smethod_7((Control)(object)textBox1), "");
					num = ((int)num2 * -1804407880) ^ 0xE72A1C;
					continue;
				case 9u:
					num = ((int)num2 * -960599906) ^ -1073299257;
					continue;
				case 8u:
					num = (int)(num2 * 312039779) ^ -357555341;
					continue;
				case 7u:
				{
					num3 = Form2.smethod_9(rnd, 10);
					Label control_ = label2;
					string string_ = num3.ToString();
					num5 = num4 + num3;
					Form2.smethod_1((Control)(object)control_, Form2.smethod_10("+", string_, "=", num5.ToString()));
					num = (int)(num2 * 664719190) ^ -682300256;
					continue;
				}
				case 6u:
					Form2.smethod_1((Control)(object)label3, "Первым ход делает Компьютер.");
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = false;
					num = -1468822325;
					continue;
				case 5u:
					num = -100574460;
					continue;
				case 3u:
					num = -1340950331;
					continue;
				case 2u:
					this.flag = false;
					num = -1700922858;
					continue;
				case 1u:
					num = ((int)num2 * -1962187303) ^ 0x35BDACAB;
					continue;
				case 0u:
					Form2.smethod_15((Form)(object)this);
					num = ((int)num2 * -672900350) ^ -577100795;
					continue;
				default:
					return;
				case 4u:
					break;
				case 23u:
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
			int num = 65644679;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x30BF4383u) % 7u)
				{
				case 6u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1002543642;
						num5 = 1002543642;
					}
					else
					{
						num4 = 804034838;
						num5 = 804034838;
					}
					num = num4 ^ ((int)num2 * -1396293474);
					continue;
				}
				case 5u:
					if (disposing)
					{
						num = (int)((num2 * 1881630967) ^ 0x5A115CA0);
						continue;
					}
					num3 = 0;
					goto IL_003d;
				case 3u:
					num3 = ((components != null) ? 1 : 0);
					goto IL_003d;
				case 2u:
					Form2.smethod_16((IDisposable)components);
					num = (int)(num2 * 1279725941) ^ -708885677;
					continue;
				case 1u:
					((Form)this).Dispose(disposing);
					num = 8642888;
					continue;
				default:
					return;
				case 0u:
					break;
				case 4u:
					return;
					IL_003d:
					flag = (byte)num3 != 0;
					num = 56799014;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		label1 = Form2.smethod_17();
		textBox1 = Form2.smethod_18();
		label2 = Form2.smethod_17();
		while (true)
		{
			int num = 1193390287;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x30B83469u) % 60u)
				{
				case 59u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label2);
					num = ((int)num2 * -402326172) ^ 0x20186D65;
					continue;
				case 58u:
					num = (int)((num2 * 1174603794) ^ 0x6195843C);
					continue;
				case 57u:
					Form2.smethod_39((Control)(object)this, "Form2");
					num = ((int)num2 * -440698636) ^ 0x568D1E8E;
					continue;
				case 56u:
					Form2.smethod_21((Control)(object)label2, bool_0: true);
					num = ((int)num2 * -363598014) ^ -338879783;
					continue;
				case 55u:
					Form2.smethod_41((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
					num = (int)((num2 * 1219361838) ^ 0x52E057CD);
					continue;
				case 54u:
					Form2.smethod_28((Control)(object)textBox1, new KeyPressEventHandler(TextBox1_KeyPress));
					num = ((int)num2 * -587760864) ^ 0x2121132C;
					continue;
				case 53u:
					Form2.smethod_22((Control)(object)textBox1, new Point(24, 86));
					num = ((int)num2 * -1329531302) ^ -1437908736;
					continue;
				case 52u:
					Form2.smethod_25((Control)(object)label3, 4);
					Form2.smethod_31((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)(num2 * 1296019219) ^ -314098478;
					continue;
				case 51u:
					Form2.smethod_1((Control)(object)label2, "+N=?");
					num = ((int)num2 * -1170385684) ^ -159411806;
					continue;
				case 49u:
					num = (int)(num2 * 499071997) ^ -372844876;
					continue;
				case 48u:
					num = (int)((num2 * 1138735149) ^ 0x7E1A7E90);
					continue;
				case 47u:
					Form2.smethod_29((ButtonBase)(object)button1, bool_0: true);
					num = (int)((num2 * 1441110089) ^ 0x1D8AB385);
					continue;
				case 46u:
					Form2.smethod_36((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -1858087930) ^ 0x280156B5;
					continue;
				case 45u:
					num = ((int)num2 * -1483157212) ^ -2095158706;
					continue;
				case 44u:
					Form2.smethod_25((Control)(object)label1, 0);
					num = (int)(num2 * 1393558988) ^ -594513739;
					continue;
				case 43u:
					Form2.smethod_24((Control)(object)label3, new Size(0, 13));
					num = ((int)num2 * -1095766811) ^ -741855210;
					continue;
				case 42u:
					Form2.smethod_23((Control)(object)label3, "label3");
					num = (int)((num2 * 1469728488) ^ 0x5A5B63FA);
					continue;
				case 41u:
					num = (int)((num2 * 791626958) ^ 0x7DEFA7F7);
					continue;
				case 40u:
					label3 = Form2.smethod_17();
					Form2.smethod_20((Control)(object)this);
					num = ((int)num2 * -415379652) ^ 0x22A76064;
					continue;
				case 39u:
					num = ((int)num2 * -1479040297) ^ 0x1B4B9467;
					continue;
				case 38u:
					num = ((int)num2 * -1801917739) ^ -1067587432;
					continue;
				case 37u:
					Form2.smethod_21((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -561009459) ^ 0x286895A6;
					continue;
				case 36u:
					Form2.smethod_21((Control)(object)label3, bool_0: true);
					num = (int)((num2 * 386316312) ^ 0x4C68F86D);
					continue;
				case 35u:
					Form2.smethod_23((Control)(object)textBox1, "textBox1");
					num = ((int)num2 * -1654295297) ^ -554560167;
					continue;
				case 34u:
					Form2.smethod_22((Control)(object)label1, new Point(10, 10));
					Form2.smethod_23((Control)(object)label1, "label1");
					num = ((int)num2 * -854254731) ^ -1300816842;
					continue;
				case 33u:
					num = (int)(num2 * 1829792984) ^ -210763197;
					continue;
				case 32u:
					Form2.smethod_25((Control)(object)button1, 3);
					num = ((int)num2 * -1069585506) ^ -427271736;
					continue;
				case 31u:
					Form2.smethod_40((Form)(object)this, bool_0: false);
					num = ((int)num2 * -2136888059) ^ -1845033952;
					continue;
				case 30u:
					button1 = Form2.smethod_19();
					num = ((int)num2 * -772996112) ^ 0x6F832451;
					continue;
				case 29u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label3);
					num = (int)(num2 * 2123805796) ^ -22887763;
					continue;
				case 28u:
					num = ((int)num2 * -547927082) ^ 0x542067E8;
					continue;
				case 27u:
					Form2.smethod_22((Control)(object)button1, new Point(86, 193));
					num = (int)((num2 * 1258221162) ^ 0x5F3A4F71);
					continue;
				case 26u:
					Form2.smethod_23((Control)(object)button1, "button1");
					num = (int)((num2 * 550787408) ^ 0x3550295F);
					continue;
				case 25u:
					Form2.smethod_1((Control)(object)label1, "label1");
					num = (int)(num2 * 719529901) ^ -1047584906;
					continue;
				case 24u:
					num = (int)(num2 * 1336269150) ^ -1510210809;
					continue;
				case 23u:
					Form2.smethod_32((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -771063027) ^ -486387953;
					continue;
				case 22u:
					Form2.smethod_24((Control)(object)button1, new Size(73, 23));
					num = (int)((num2 * 1023862003) ^ 0x695573F7);
					continue;
				case 21u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)button1);
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)textBox1);
					num = ((int)num2 * -1055544758) ^ 0x1004D270;
					continue;
				case 20u:
					Form2.smethod_37((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1281664708) ^ -2121670647;
					continue;
				case 19u:
					Form2.smethod_30((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)((num2 * 1007519405) ^ 0x6BB964B6);
					continue;
				case 17u:
					Form2.smethod_33((Form)(object)this, new Size(255, 224));
					num = ((int)num2 * -1417406960) ^ -1414488032;
					continue;
				case 16u:
					num = (int)(num2 * 1857180932) ^ -1673473053;
					continue;
				case 15u:
					Form2.smethod_1((Control)(object)this, "Жеребьёвка");
					num = (int)(num2 * 1741228580) ^ -33070810;
					continue;
				case 14u:
					Form2.smethod_43((Control)(object)this);
					num = (int)(num2 * 607799622) ^ -367935697;
					continue;
				case 13u:
					Form2.smethod_24((Control)(object)textBox1, new Size(42, 80));
					Form2.smethod_25((Control)(object)textBox1, 1);
					num = (int)(num2 * 1445145906) ^ -1662467371;
					continue;
				case 12u:
					num = (int)(num2 * 1593972492) ^ -762160052;
					continue;
				case 11u:
					Form2.smethod_38((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1190933625) ^ -1969023038;
					continue;
				case 10u:
					Form2.smethod_27((Control)(object)textBox1, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 1216319113) ^ -230763954;
					continue;
				case 9u:
					num = (int)(num2 * 274362071) ^ -1731859663;
					continue;
				case 8u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -284503889) ^ -1190683979;
					continue;
				case 7u:
					Form2.smethod_23((Control)(object)label2, "label2");
					Form2.smethod_24((Control)(object)label2, new Size(188, 73));
					Form2.smethod_25((Control)(object)label2, 2);
					num = (int)((num2 * 1357145012) ^ 0x134B4FEA);
					continue;
				case 6u:
					Form2.smethod_22((Control)(object)label3, new Point(47, 177));
					num = ((int)num2 * -689974539) ^ 0x18F46416;
					continue;
				case 5u:
					Form2.smethod_27((Control)(object)label2, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form2.smethod_22((Control)(object)label2, new Point(53, 89));
					num = (int)((num2 * 22584687) ^ 0x462D742F);
					continue;
				case 4u:
					num = ((int)num2 * -1859150976) ^ -1089517646;
					continue;
				case 3u:
					Form2.smethod_1((Control)(object)button1, "OK");
					num = ((int)num2 * -674364312) ^ 0x2ECF4DB0;
					continue;
				case 2u:
					Form2.smethod_42((Control)(object)this, bool_0: false);
					num = (int)(num2 * 1854300027) ^ -454796347;
					continue;
				case 1u:
					num = (int)((num2 * 348318385) ^ 0x2ADF51CF);
					continue;
				case 0u:
					Form2.smethod_24((Control)(object)label1, new Size(35, 13));
					num = (int)(num2 * 618600684) ^ -1797285991;
					continue;
				default:
					return;
				case 50u:
					break;
				case 18u:
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
