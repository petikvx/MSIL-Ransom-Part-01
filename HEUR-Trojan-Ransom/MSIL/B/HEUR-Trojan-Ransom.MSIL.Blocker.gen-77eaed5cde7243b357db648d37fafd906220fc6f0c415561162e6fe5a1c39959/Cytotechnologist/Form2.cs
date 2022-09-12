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
			int num = -1985552642;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9C682A5Au) % 3u)
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
				num = ((int)num2 * -854406329) ^ 0x1586F23C;
			}
		}
	}

	private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsDigit(Form2.smethod_4(e)))
		{
			goto IL_0089;
		}
		goto IL_00bf;
		IL_00bf:
		Form2.smethod_1((Control)(object)textBox1, "");
		int num = -414674526;
		goto IL_008e;
		IL_008e:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xD639F2C1u) % 8u)
			{
			case 7u:
				break;
			case 6u:
				num = (int)((num2 * 296897364) ^ 0x264AEE0C);
				continue;
			case 4u:
				Button1_Click(this, Form2.smethod_6());
				num = ((int)num2 * -136456364) ^ 0x48828137;
				continue;
			case 3u:
				num = (int)(num2 * 825476939) ^ -553397353;
				continue;
			case 2u:
				Form2.smethod_5(e, bool_0: true);
				num = ((int)num2 * -446763837) ^ 0x425B8230;
				continue;
			case 0u:
				goto end_IL_008e;
			default:
				return;
			case 1u:
				goto IL_00bf;
			case 5u:
				return;
			}
			int num3;
			if (Form2.smethod_4(e) != '\r')
			{
				num = -442375692;
				num3 = -442375692;
			}
			else
			{
				num = -2099296115;
				num3 = -2099296115;
			}
			continue;
			end_IL_008e:
			break;
		}
		goto IL_0089;
		IL_0089:
		num = -1611197789;
		goto IL_008e;
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		bool flag = Form2.smethod_8(Form2.smethod_7((Control)(object)textBox1), "");
		bool flag4 = default(bool);
		int num11 = default(int);
		int num5 = default(int);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		int num6 = default(int);
		while (true)
		{
			int num = -1797604387;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB7DB0460u) % 32u)
				{
				case 31u:
					this.flag = false;
					num = -868152076;
					continue;
				case 30u:
					flag4 = (num11 + num5) % 2 == 0;
					num = ((int)num2 * -2099564024) ^ 0x66910C5C;
					continue;
				case 29u:
				{
					int num12;
					int num13;
					if (flag)
					{
						num12 = 1686477690;
						num13 = 1686477690;
					}
					else
					{
						num12 = 1382960015;
						num13 = 1382960015;
					}
					num = num12 ^ (int)(num2 * 788403256);
					continue;
				}
				case 28u:
					num = ((int)num2 * -1016470610) ^ -1312375049;
					continue;
				case 27u:
					num = -1400045865;
					continue;
				case 26u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).StartGame();
					num = (int)(num2 * 329870467) ^ -1123964963;
					continue;
				case 25u:
					Form2.smethod_1((Control)(object)label3, "Первым ход делает Компьютер.");
					num = -1964563786;
					continue;
				case 24u:
					Form2.smethod_1((Control)(object)label3, "Поздравляем! Ваш ход первый.");
					num = ((int)num2 * -1416000654) ^ 0x2512EF5B;
					continue;
				case 22u:
					num = ((int)num2 * -674230242) ^ -41193998;
					continue;
				case 21u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = true;
					num = (int)(num2 * 9631754) ^ -1343461490;
					continue;
				case 20u:
					num = (int)((num2 * 558667599) ^ 0x2040DFD7);
					continue;
				case 19u:
					num = ((int)num2 * -1252181533) ^ 0x66F2F751;
					continue;
				case 18u:
					num11 = int.Parse(Form2.smethod_7((Control)(object)textBox1));
					num = (int)(num2 * 1733883260) ^ -1861508964;
					continue;
				case 17u:
					flag3 = this.flag;
					num = (int)(num2 * 747686471) ^ -1002727554;
					continue;
				case 16u:
					flag2 = num6 > 1;
					num = (int)(num2 * 230027608) ^ -1987004189;
					continue;
				case 15u:
				{
					Label control_2 = label2;
					string string_ = num5.ToString();
					num6 = num11 + num5;
					Form2.smethod_1((Control)(object)control_2, Form2.smethod_10("+", string_, "=", num6.ToString()));
					num = (int)((num2 * 995076340) ^ 0x62865F72);
					continue;
				}
				case 14u:
					num = (int)(num2 * 1632462544) ^ -1454574821;
					continue;
				case 12u:
				{
					int num9;
					int num10;
					if (!flag4)
					{
						num9 = 388227789;
						num10 = 388227789;
					}
					else
					{
						num9 = 1658550572;
						num10 = 1658550572;
					}
					num = num9 ^ (int)(num2 * 131911847);
					continue;
				}
				case 11u:
					num = (int)(num2 * 1414764951) ^ -1597098328;
					continue;
				case 10u:
					(Form2.smethod_2((Form)(object)this) as Form3).Button_Continue();
					Form2.smethod_14(Form2.smethod_11(Form2.smethod_2((Form)(object)this)));
					num = (int)((num2 * 1920084040) ^ 0x67F19BAA);
					continue;
				case 9u:
				{
					int num7;
					int num8;
					if (!flag3)
					{
						num7 = -136294789;
						num8 = -136294789;
					}
					else
					{
						num7 = -428182371;
						num8 = -428182371;
					}
					num = num7 ^ ((int)num2 * -1858802340);
					continue;
				}
				case 8u:
					Form2.smethod_15((Form)(object)this);
					num = ((int)num2 * -958448944) ^ 0x175D098E;
					continue;
				case 7u:
					num = -1534894171;
					continue;
				case 6u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = false;
					num = (int)((num2 * 483336050) ^ 0x5B8C0013);
					continue;
				case 5u:
				{
					Form control_ = Form2.smethod_2((Form)(object)this);
					num6 = Form2.smethod_12((Control)(object)control_) - 1;
					Form2.smethod_13((Control)(object)control_, num6);
					num = -1454362064;
					continue;
				}
				case 4u:
					num5 = Form2.smethod_9(rnd, 10);
					num = ((int)num2 * -1224521891) ^ 0x7E27365B;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (flag2)
					{
						num3 = -1663097624;
						num4 = -1663097624;
					}
					else
					{
						num3 = -1758501310;
						num4 = -1758501310;
					}
					num = num3 ^ (int)(num2 * 969700216);
					continue;
				}
				case 2u:
					num = ((int)num2 * -408844293) ^ -973296441;
					continue;
				case 1u:
					num = ((int)num2 * -705923383) ^ -1335530341;
					continue;
				case 0u:
					num = -1534894171;
					continue;
				default:
					return;
				case 13u:
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
			int num = 1217582416;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x5798D9F0u) % 11u)
				{
				case 9u:
					num = ((int)num2 * -388262716) ^ -570413119;
					continue;
				case 8u:
					Form2.smethod_16((IDisposable)components);
					num = (int)(num2 * 1551290526) ^ -810013546;
					continue;
				case 6u:
					num = (int)(num2 * 125550740) ^ -925844267;
					continue;
				case 5u:
					num = ((int)num2 * -1545778440) ^ 0x1531AB00;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1803878923;
						num5 = -1803878923;
					}
					else
					{
						num4 = -1591735076;
						num5 = -1591735076;
					}
					num = num4 ^ (int)(num2 * 1097308673);
					continue;
				}
				case 3u:
					((Form)this).Dispose(disposing);
					num = 1509710541;
					continue;
				case 2u:
					num3 = ((components != null) ? 1 : 0);
					goto IL_008e;
				case 1u:
					if (disposing)
					{
						num = ((int)num2 * -1005888944) ^ 0x9A8DC5C;
						continue;
					}
					num3 = 0;
					goto IL_008e;
				case 0u:
					num = (int)(num2 * 98281614) ^ -1439690477;
					continue;
				default:
					return;
				case 7u:
					break;
				case 10u:
					return;
					IL_008e:
					flag = (byte)num3 != 0;
					num = 1982007953;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected O, but got Unknown
		label1 = Form2.smethod_17();
		while (true)
		{
			int num = -1131110260;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x96070167u) % 44u)
				{
				case 43u:
					Form2.smethod_27((Control)(object)textBox1, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 2044710044) ^ -143638577;
					continue;
				case 42u:
					Form2.smethod_23((Control)(object)label2, "label2");
					num = ((int)num2 * -1340067487) ^ 0xE64B603;
					continue;
				case 41u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -752291350) ^ -690280575;
					continue;
				case 39u:
					Form2.smethod_22((Control)(object)label2, new Point(53, 89));
					num = (int)((num2 * 1303529824) ^ 0xDB77D09);
					continue;
				case 38u:
					Form2.smethod_21((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -1597839955) ^ 0x2F646C42;
					continue;
				case 37u:
					Form2.smethod_25((Control)(object)label3, 4);
					Form2.smethod_31((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -2143624935) ^ -358071841;
					continue;
				case 36u:
					Form2.smethod_37((Form)(object)this, bool_0: false);
					num = ((int)num2 * -431612279) ^ 0x699DCD43;
					continue;
				case 35u:
					Form2.smethod_20((Control)(object)this);
					num = ((int)num2 * -694173714) ^ -1335116725;
					continue;
				case 34u:
					Form2.smethod_41((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
					Form2.smethod_42((Control)(object)this, bool_0: false);
					num = (int)((num2 * 214028830) ^ 0x361C51CF);
					continue;
				case 33u:
					Form2.smethod_33((Form)(object)this, new Size(255, 224));
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label3);
					num = (int)(num2 * 2131009034) ^ -1148321024;
					continue;
				case 32u:
					num = (int)((num2 * 1158220885) ^ 0x64A2A8B9);
					continue;
				case 31u:
					num = ((int)num2 * -494750598) ^ 0x7A76CCD4;
					continue;
				case 30u:
					Form2.smethod_24((Control)(object)label1, new Size(35, 13));
					Form2.smethod_25((Control)(object)label1, 0);
					num = ((int)num2 * -1537685697) ^ -2067097836;
					continue;
				case 29u:
					Form2.smethod_25((Control)(object)button1, 3);
					Form2.smethod_1((Control)(object)button1, "OK");
					Form2.smethod_29((ButtonBase)(object)button1, bool_0: true);
					num = (int)(num2 * 119442005) ^ -463890791;
					continue;
				case 28u:
					Form2.smethod_38((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1928770518) ^ -1371806140;
					continue;
				case 27u:
					Form2.smethod_23((Control)(object)label3, "label3");
					num = ((int)num2 * -397544356) ^ -1589668908;
					continue;
				case 26u:
					Form2.smethod_40((Form)(object)this, bool_0: false);
					num = (int)((num2 * 2133207926) ^ 0x50578442);
					continue;
				case 24u:
					Form2.smethod_25((Control)(object)textBox1, 1);
					Form2.smethod_28((Control)(object)textBox1, new KeyPressEventHandler(TextBox1_KeyPress));
					num = (int)(num2 * 471881504) ^ -1136740076;
					continue;
				case 23u:
					num = (int)(num2 * 1936558101) ^ -1970583202;
					continue;
				case 22u:
					Form2.smethod_24((Control)(object)label3, new Size(0, 13));
					num = (int)((num2 * 859137085) ^ 0x599B4E6C);
					continue;
				case 21u:
					Form2.smethod_22((Control)(object)textBox1, new Point(24, 86));
					Form2.smethod_23((Control)(object)textBox1, "textBox1");
					Form2.smethod_24((Control)(object)textBox1, new Size(42, 80));
					num = (int)((num2 * 2037002364) ^ 0x723BC0E3);
					continue;
				case 20u:
					Form2.smethod_24((Control)(object)button1, new Size(73, 23));
					num = ((int)num2 * -1285212271) ^ -68071715;
					continue;
				case 19u:
					num = (int)((num2 * 795580817) ^ 0x50788E0A);
					continue;
				case 18u:
					Form2.smethod_39((Control)(object)this, "Form2");
					num = (int)(num2 * 486155967) ^ -1395931745;
					continue;
				case 17u:
					Form2.smethod_1((Control)(object)label2, "+N=?");
					Form2.smethod_22((Control)(object)button1, new Point(86, 193));
					num = ((int)num2 * -1095965048) ^ -723890221;
					continue;
				case 16u:
					Form2.smethod_22((Control)(object)label3, new Point(47, 177));
					num = (int)((num2 * 1852995764) ^ 0x1F8653AC);
					continue;
				case 15u:
					Form2.smethod_30((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)(num2 * 1247825667) ^ -2126712882;
					continue;
				case 14u:
					Form2.smethod_23((Control)(object)button1, "button1");
					num = (int)(num2 * 34699884) ^ -1282666653;
					continue;
				case 13u:
					Form2.smethod_1((Control)(object)label1, "label1");
					num = ((int)num2 * -1432842945) ^ 0x1B74EDFB;
					continue;
				case 12u:
					num = ((int)num2 * -1387488051) ^ 0x7DB12C46;
					continue;
				case 11u:
					Form2.smethod_21((Control)(object)label2, bool_0: true);
					num = ((int)num2 * -210325019) ^ 0x7885944A;
					continue;
				case 10u:
					num = (int)((num2 * 1001133385) ^ 0x7B143A1C);
					continue;
				case 9u:
					Form2.smethod_1((Control)(object)this, "Жеребьёвка");
					num = ((int)num2 * -2062714971) ^ -71863016;
					continue;
				case 8u:
					Form2.smethod_21((Control)(object)label3, bool_0: true);
					num = (int)((num2 * 1546966162) ^ 0x30FEB1C3);
					continue;
				case 7u:
					textBox1 = Form2.smethod_18();
					label2 = Form2.smethod_17();
					button1 = Form2.smethod_19();
					label3 = Form2.smethod_17();
					num = (int)(num2 * 1702417974) ^ -1531061942;
					continue;
				case 6u:
					Form2.smethod_27((Control)(object)label2, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -2123372628) ^ 0xC16B6A8;
					continue;
				case 5u:
					Form2.smethod_22((Control)(object)label1, new Point(10, 10));
					Form2.smethod_23((Control)(object)label1, "label1");
					num = (int)(num2 * 171105436) ^ -1368838319;
					continue;
				case 4u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)textBox1);
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label2);
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -929523144) ^ -1087485976;
					continue;
				case 3u:
					Form2.smethod_36((Form)(object)this, (FormBorderStyle)1);
					num = (int)(num2 * 623209712) ^ -736322337;
					continue;
				case 2u:
					Form2.smethod_24((Control)(object)label2, new Size(188, 73));
					num = (int)(num2 * 1283145822) ^ -1232005205;
					continue;
				case 1u:
					Form2.smethod_32((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 667727463) ^ -531750131;
					continue;
				case 0u:
					Form2.smethod_25((Control)(object)label2, 2);
					num = ((int)num2 * -343192777) ^ 0x63FFC1A6;
					continue;
				case 25u:
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
