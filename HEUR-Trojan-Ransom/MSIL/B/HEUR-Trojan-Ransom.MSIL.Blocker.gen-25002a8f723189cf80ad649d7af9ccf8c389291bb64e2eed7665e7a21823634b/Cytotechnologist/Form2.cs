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
		if (!char.IsDigit(Form2.smethod_4(e)))
		{
			goto IL_009b;
		}
		goto IL_00d6;
		IL_00d6:
		Form2.smethod_1((Control)(object)textBox1, "");
		int num = -1723610807;
		goto IL_00a0;
		IL_00a0:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xB11341BDu) % 9u)
			{
			case 8u:
				num = ((int)num2 * -640016156) ^ -80448257;
				continue;
			case 7u:
				num = ((int)num2 * -1239250874) ^ 0x5B787503;
				continue;
			case 6u:
				break;
			case 4u:
				Button1_Click(this, Form2.smethod_6());
				num = ((int)num2 * -2108312610) ^ -1222408893;
				continue;
			case 3u:
				Form2.smethod_5(e, bool_0: true);
				num = (int)(num2 * 662423492) ^ -445557103;
				continue;
			case 2u:
				num = ((int)num2 * -1305087002) ^ 0x367A47FB;
				continue;
			case 0u:
				goto end_IL_00a0;
			default:
				return;
			case 5u:
				goto IL_00d6;
			case 1u:
				return;
			}
			int num3;
			if (Form2.smethod_4(e) == '\r')
			{
				num = -1868464585;
				num3 = -1868464585;
			}
			else
			{
				num = -1763442185;
				num3 = -1763442185;
			}
			continue;
			end_IL_00a0:
			break;
		}
		goto IL_009b;
		IL_009b:
		num = -1085041938;
		goto IL_00a0;
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		bool flag = Form2.smethod_8(Form2.smethod_7((Control)(object)textBox1), "");
		bool flag2 = default(bool);
		int num3 = default(int);
		int num6 = default(int);
		while (true)
		{
			int num = 880492913;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x41383142u) % 32u)
				{
				case 31u:
					(Form2.smethod_2((Form)(object)this) as Form3).Button_Continue();
					num = ((int)num2 * -1448582659) ^ 0x3CBB06B7;
					continue;
				case 30u:
					num = 1640026944;
					continue;
				case 29u:
					num = ((int)num2 * -380253847) ^ -1085102347;
					continue;
				case 28u:
					flag2 = num3 > 1;
					num = (int)(num2 * 316766002) ^ -793417454;
					continue;
				case 27u:
					num = (int)(num2 * 1366661931) ^ -919306079;
					continue;
				case 26u:
				{
					int num9 = Form2.smethod_9(rnd, 10);
					Label control_2 = label2;
					string string_ = num9.ToString();
					num3 = num6 + num9;
					Form2.smethod_1((Control)(object)control_2, Form2.smethod_10("+", string_, "=", num3.ToString()));
					int num10;
					int num11;
					if ((num6 + num9) % 2 == 0)
					{
						num10 = -692104419;
						num11 = -692104419;
					}
					else
					{
						num10 = -1103576663;
						num11 = -1103576663;
					}
					num = num10 ^ (int)(num2 * 1803411210);
					continue;
				}
				case 25u:
				{
					int num12;
					int num13;
					if (!this.flag)
					{
						num12 = -1465198325;
						num13 = -1465198325;
					}
					else
					{
						num12 = -278765732;
						num13 = -278765732;
					}
					num = num12 ^ ((int)num2 * -570038962);
					continue;
				}
				case 24u:
					num = ((int)num2 * -830989176) ^ -1071807357;
					continue;
				case 23u:
					num = 1423996709;
					continue;
				case 22u:
					num = (int)(num2 * 558974800) ^ -845069934;
					continue;
				case 21u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).StartGame();
					num = (int)(num2 * 406884127) ^ -80257492;
					continue;
				case 20u:
					num = (int)(num2 * 307318396) ^ -1380381049;
					continue;
				case 19u:
				{
					int num7;
					int num8;
					if (flag)
					{
						num7 = -658806512;
						num8 = -658806512;
					}
					else
					{
						num7 = -580675406;
						num8 = -580675406;
					}
					num = num7 ^ ((int)num2 * -1409682870);
					continue;
				}
				case 18u:
					this.flag = false;
					num = 80714970;
					continue;
				case 17u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = false;
					num = (int)(num2 * 332346966) ^ -1192669207;
					continue;
				case 16u:
					Form2.smethod_14(Form2.smethod_11(Form2.smethod_2((Form)(object)this)));
					num = (int)((num2 * 2126495332) ^ 0x408B8DD6);
					continue;
				case 15u:
					num = 699021935;
					continue;
				case 13u:
					Form2.smethod_1((Control)(object)label3, "Первым ход делает Компьютер.");
					num = (int)(num2 * 2146785245) ^ -758320918;
					continue;
				case 12u:
					num = ((int)num2 * -797945588) ^ -1967470837;
					continue;
				case 11u:
					num6 = int.Parse(Form2.smethod_7((Control)(object)textBox1));
					num = (int)(num2 * 1935392422) ^ -1396308934;
					continue;
				case 10u:
					Form2.smethod_1((Control)(object)label3, "Поздравляем! Ваш ход первый.");
					num = ((int)num2 * -499296359) ^ -1302690498;
					continue;
				case 9u:
					num = ((int)num2 * -530892730) ^ -2053543898;
					continue;
				case 8u:
				{
					int num4;
					int num5;
					if (flag2)
					{
						num4 = -361067516;
						num5 = -361067516;
					}
					else
					{
						num4 = -213157819;
						num5 = -213157819;
					}
					num = num4 ^ (int)(num2 * 632670447);
					continue;
				}
				case 7u:
					num = ((int)num2 * -826174001) ^ -515820791;
					continue;
				case 6u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = true;
					num = (int)((num2 * 1366829850) ^ 0x482013D7);
					continue;
				case 5u:
					Form2.smethod_15((Form)(object)this);
					num = (int)((num2 * 1609502617) ^ 0x12AA12FC);
					continue;
				case 3u:
					num = (int)(num2 * 29341832) ^ -1281629733;
					continue;
				case 2u:
				{
					Form control_ = Form2.smethod_2((Form)(object)this);
					num3 = Form2.smethod_12((Control)(object)control_) - 1;
					Form2.smethod_13((Control)(object)control_, num3);
					num = 1645681566;
					continue;
				}
				case 1u:
					num = 88751116;
					continue;
				case 0u:
					num = (int)((num2 * 1839112721) ^ 0x77DF40A9);
					continue;
				default:
					return;
				case 4u:
					break;
				case 14u:
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
			int num = 323860463;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x687CB904u) % 10u)
				{
				case 9u:
					((Form)this).Dispose(disposing);
					num = 80079486;
					continue;
				case 8u:
					num = (int)(num2 * 96220420) ^ -1810496676;
					continue;
				case 6u:
					num = ((int)num2 * -823070263) ^ 0x6164030D;
					continue;
				case 5u:
					num = (int)(num2 * 1008609810) ^ -932070716;
					continue;
				case 3u:
					Form2.smethod_16((IDisposable)components);
					num = ((int)num2 * -964832666) ^ -1855312919;
					continue;
				case 2u:
					if (components != null)
					{
						num = 688227036;
						num3 = 688227036;
						continue;
					}
					goto IL_0069;
				case 1u:
					if (disposing)
					{
						num = ((int)num2 * -1485859599) ^ 0x793E6BE1;
						continue;
					}
					goto IL_0069;
				case 0u:
					num = ((int)num2 * -1439510876) ^ -33267487;
					continue;
				default:
					return;
				case 7u:
					break;
				case 4u:
					return;
					IL_0069:
					num = 1080676921;
					num3 = 1080676921;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_0543: Unknown result type (might be due to invalid IL or missing references)
		//IL_054d: Expected O, but got Unknown
		//IL_0567: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Expected O, but got Unknown
		label1 = Form2.smethod_17();
		textBox1 = Form2.smethod_18();
		label2 = Form2.smethod_17();
		button1 = Form2.smethod_19();
		label3 = Form2.smethod_17();
		while (true)
		{
			int num = 2129880844;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x207BB0D1u) % 54u)
				{
				case 53u:
					Form2.smethod_40((Form)(object)this, bool_0: false);
					num = ((int)num2 * -720321320) ^ -2144941886;
					continue;
				case 52u:
					num = (int)((num2 * 873165541) ^ 0x2A52F7A9);
					continue;
				case 51u:
					num = (int)(num2 * 1121249796) ^ -210916300;
					continue;
				case 50u:
					Form2.smethod_25((Control)(object)button1, 3);
					num = ((int)num2 * -1891040395) ^ 0x2253B57C;
					continue;
				case 49u:
					Form2.smethod_22((Control)(object)textBox1, new Point(24, 86));
					num = (int)((num2 * 367843531) ^ 0x33B0E63A);
					continue;
				case 48u:
					num = ((int)num2 * -488061157) ^ -1246707434;
					continue;
				case 47u:
					num = (int)(num2 * 931027231) ^ -94834668;
					continue;
				case 46u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label2);
					num = ((int)num2 * -73448742) ^ 0x2DBC7A3;
					continue;
				case 45u:
					Form2.smethod_29((ButtonBase)(object)button1, bool_0: true);
					Form2.smethod_30((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)(num2 * 404651337) ^ -2071311173;
					continue;
				case 44u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)textBox1);
					num = ((int)num2 * -861888859) ^ 0x6C25D4EF;
					continue;
				case 43u:
					num = (int)((num2 * 2080055728) ^ 0x39FB315A);
					continue;
				case 41u:
					Form2.smethod_25((Control)(object)label3, 4);
					num = (int)(num2 * 488245874) ^ -625865201;
					continue;
				case 40u:
					Form2.smethod_1((Control)(object)label2, "+N=?");
					Form2.smethod_22((Control)(object)button1, new Point(86, 193));
					num = ((int)num2 * -1859997663) ^ -307852330;
					continue;
				case 39u:
					Form2.smethod_1((Control)(object)label1, "label1");
					num = ((int)num2 * -1214595531) ^ 0x2C665BF4;
					continue;
				case 38u:
					Form2.smethod_24((Control)(object)label3, new Size(0, 13));
					num = ((int)num2 * -1875123806) ^ 0x60CC5ABE;
					continue;
				case 37u:
					num = ((int)num2 * -1728372047) ^ -908639494;
					continue;
				case 36u:
					Form2.smethod_39((Control)(object)this, "Form2");
					num = (int)((num2 * 124322136) ^ 0x555D7A88);
					continue;
				case 35u:
					Form2.smethod_23((Control)(object)label2, "label2");
					num = ((int)num2 * -1482569972) ^ 0xD585E90;
					continue;
				case 34u:
					Form2.smethod_36((Form)(object)this, (FormBorderStyle)1);
					num = (int)(num2 * 793251645) ^ -822644361;
					continue;
				case 33u:
					Form2.smethod_21((Control)(object)label3, bool_0: true);
					num = ((int)num2 * -1792825150) ^ 0x23F0C754;
					continue;
				case 32u:
					Form2.smethod_23((Control)(object)button1, "button1");
					Form2.smethod_24((Control)(object)button1, new Size(73, 23));
					num = ((int)num2 * -1548258735) ^ -1250622521;
					continue;
				case 31u:
					Form2.smethod_1((Control)(object)button1, "OK");
					num = ((int)num2 * -1780148796) ^ 0x3E87D57F;
					continue;
				case 30u:
					Form2.smethod_22((Control)(object)label1, new Point(10, 10));
					num = (int)((num2 * 1755312251) ^ 0x1AE41375);
					continue;
				case 29u:
					num = ((int)num2 * -407006579) ^ -1798743572;
					continue;
				case 28u:
					Form2.smethod_1((Control)(object)this, "Жеребьёвка");
					num = ((int)num2 * -1307804911) ^ -1856474182;
					continue;
				case 27u:
					num = ((int)num2 * -1878018900) ^ -1274029962;
					continue;
				case 26u:
					Form2.smethod_23((Control)(object)label1, "label1");
					Form2.smethod_24((Control)(object)label1, new Size(35, 13));
					num = (int)((num2 * 24083210) ^ 0x33D8F8F3);
					continue;
				case 25u:
					Form2.smethod_27((Control)(object)label2, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form2.smethod_22((Control)(object)label2, new Point(53, 89));
					num = ((int)num2 * -850736422) ^ -1592432891;
					continue;
				case 24u:
					num = ((int)num2 * -845922762) ^ 0x16181D4;
					continue;
				case 22u:
					Form2.smethod_33((Form)(object)this, new Size(255, 224));
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label3);
					num = ((int)num2 * -1589320907) ^ 0x7C92B42E;
					continue;
				case 21u:
					Form2.smethod_20((Control)(object)this);
					Form2.smethod_21((Control)(object)label1, bool_0: true);
					num = (int)((num2 * 2097381318) ^ 0x6080C65B);
					continue;
				case 20u:
					Form2.smethod_23((Control)(object)label3, "label3");
					num = (int)(num2 * 999417363) ^ -98145319;
					continue;
				case 19u:
					Form2.smethod_25((Control)(object)textBox1, 1);
					num = (int)((num2 * 363213566) ^ 0x2E6927F5);
					continue;
				case 18u:
					Form2.smethod_37((Form)(object)this, bool_0: false);
					Form2.smethod_38((Form)(object)this, bool_0: false);
					num = ((int)num2 * -2030307215) ^ -1818990108;
					continue;
				case 17u:
					num = (int)(num2 * 1321281269) ^ -77542939;
					continue;
				case 16u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label1);
					num = (int)((num2 * 1079742830) ^ 0x38DFAAB4);
					continue;
				case 15u:
					num = ((int)num2 * -951047227) ^ 0x6FAF1E41;
					continue;
				case 14u:
					Form2.smethod_27((Control)(object)textBox1, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1103530112) ^ -1014227916;
					continue;
				case 13u:
					Form2.smethod_21((Control)(object)label2, bool_0: true);
					num = (int)((num2 * 1447827612) ^ 0x26CEDC2C);
					continue;
				case 12u:
					Form2.smethod_28((Control)(object)textBox1, new KeyPressEventHandler(TextBox1_KeyPress));
					num = (int)((num2 * 1927497300) ^ 0x43480AAC);
					continue;
				case 11u:
					Form2.smethod_41((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
					Form2.smethod_42((Control)(object)this, bool_0: false);
					num = (int)(num2 * 446145497) ^ -1074415476;
					continue;
				case 10u:
					Form2.smethod_23((Control)(object)textBox1, "textBox1");
					num = ((int)num2 * -1704177414) ^ 0x520CD6;
					continue;
				case 9u:
					num = (int)((num2 * 584818153) ^ 0x4D84F3C0);
					continue;
				case 8u:
					Form2.smethod_25((Control)(object)label1, 0);
					num = ((int)num2 * -1516641828) ^ -475865190;
					continue;
				case 7u:
					Form2.smethod_22((Control)(object)label3, new Point(47, 177));
					num = (int)((num2 * 1503087533) ^ 0x1B02D036);
					continue;
				case 6u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)button1);
					num = (int)((num2 * 1942866979) ^ 0x7993584F);
					continue;
				case 5u:
					Form2.smethod_24((Control)(object)textBox1, new Size(42, 80));
					num = ((int)num2 * -666613128) ^ -1992942360;
					continue;
				case 4u:
					Form2.smethod_31((ContainerControl)(object)this, new SizeF(6f, 13f));
					Form2.smethod_32((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -202708157) ^ -1528553771;
					continue;
				case 3u:
					num = (int)((num2 * 735754490) ^ 0x1338519F);
					continue;
				case 2u:
					num = (int)(num2 * 1576733240) ^ -886143217;
					continue;
				case 1u:
					Form2.smethod_24((Control)(object)label2, new Size(188, 73));
					num = ((int)num2 * -1263215165) ^ 0x1503F2A2;
					continue;
				case 0u:
					Form2.smethod_25((Control)(object)label2, 2);
					num = ((int)num2 * -561572374) ^ -822532081;
					continue;
				case 23u:
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
