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
			int num = -1153386614;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAE597628u) % 3u)
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
				num = ((int)num2 * -1298256321) ^ 0x61312E27;
			}
		}
	}

	private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		bool flag = !char.IsDigit(Form2.smethod_4(e));
		while (true)
		{
			int num = -1910015221;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA7FB0794u) % 7u)
				{
				case 5u:
					Form2.smethod_1((Control)(object)textBox1, "");
					num = -1746946016;
					continue;
				case 3u:
					Form2.smethod_5(e, bool_0: true);
					num = ((int)num2 * -910628790) ^ 0x564D2F12;
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 850154348;
						num5 = 850154348;
					}
					else
					{
						num4 = 104124555;
						num5 = 104124555;
					}
					num = num4 ^ (int)(num2 * 27173190);
					continue;
				}
				case 1u:
					Button1_Click(this, Form2.smethod_6());
					num = ((int)num2 * -1384188521) ^ -477704545;
					continue;
				case 0u:
				{
					int num3;
					if (Form2.smethod_4(e) != '\r')
					{
						num = -211302815;
						num3 = -211302815;
					}
					else
					{
						num = -1830310618;
						num3 = -1830310618;
					}
					continue;
				}
				default:
					return;
				case 4u:
					break;
				case 6u:
					return;
				}
				break;
			}
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		int num8 = default(int);
		int num3 = default(int);
		int num9 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -856677317;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB28F7B06u) % 29u)
				{
				case 28u:
					num = -1201513769;
					continue;
				case 27u:
					this.flag = false;
					num = -672616675;
					continue;
				case 26u:
					num = -852319505;
					continue;
				case 25u:
					num = ((int)num2 * -1156735624) ^ 0x2D36B21B;
					continue;
				case 24u:
					num = ((int)num2 * -2136170651) ^ 0x3B29949E;
					continue;
				case 23u:
					Form2.smethod_1((Control)(object)label3, "Первым ход делает Компьютер.");
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = false;
					num = (int)(num2 * 2139788023) ^ -1981384208;
					continue;
				case 22u:
				{
					num8 = Form2.smethod_9(rnd, 10);
					Label control_2 = label2;
					string string_ = num8.ToString();
					num3 = num9 + num8;
					Form2.smethod_1((Control)(object)control_2, Form2.smethod_10("+", string_, "=", num3.ToString()));
					num = (int)((num2 * 255115911) ^ 0x6B900A60);
					continue;
				}
				case 21u:
				{
					Form control_ = Form2.smethod_2((Form)(object)this);
					num3 = Form2.smethod_12((Control)(object)control_) - 1;
					Form2.smethod_13((Control)(object)control_, num3);
					num = -2541957;
					continue;
				}
				case 20u:
					Form2.smethod_15((Form)(object)this);
					num = (int)(num2 * 2085624950) ^ -266117961;
					continue;
				case 19u:
				{
					int num12;
					int num13;
					if (flag)
					{
						num12 = -979802255;
						num13 = -979802255;
					}
					else
					{
						num12 = -1573521005;
						num13 = -1573521005;
					}
					num = num12 ^ ((int)num2 * -1063155586);
					continue;
				}
				case 18u:
					num = (int)((num2 * 1294074706) ^ 0x1FC16DE9);
					continue;
				case 17u:
					num9 = int.Parse(Form2.smethod_7((Control)(object)textBox1));
					num = ((int)num2 * -945817860) ^ -1387414076;
					continue;
				case 16u:
					num = (int)(num2 * 1602464070) ^ -1007119639;
					continue;
				case 15u:
					(Form2.smethod_2((Form)(object)this) as Form3).Button_Continue();
					num = ((int)num2 * -951839740) ^ 0x503E7FA1;
					continue;
				case 14u:
					num = ((int)num2 * -1534239633) ^ -566645319;
					continue;
				case 13u:
				{
					int num10;
					int num11;
					if ((num9 + num8) % 2 == 0)
					{
						num10 = -1739697508;
						num11 = -1739697508;
					}
					else
					{
						num10 = -1818518288;
						num11 = -1818518288;
					}
					num = num10 ^ ((int)num2 * -287646435);
					continue;
				}
				case 11u:
					num = -630117193;
					continue;
				case 10u:
				{
					int num6;
					int num7;
					if (this.flag)
					{
						num6 = -887048477;
						num7 = -887048477;
					}
					else
					{
						num6 = -204366395;
						num7 = -204366395;
					}
					num = num6 ^ (int)(num2 * 1607657387);
					continue;
				}
				case 9u:
					num = ((int)num2 * -1228830979) ^ -456573712;
					continue;
				case 8u:
				{
					int num4;
					int num5;
					if (num3 > 1)
					{
						num4 = -759716687;
						num5 = -759716687;
					}
					else
					{
						num4 = -1975811360;
						num5 = -1975811360;
					}
					num = num4 ^ (int)(num2 * 236918814);
					continue;
				}
				case 7u:
					Form2.smethod_1((Control)(object)label3, "Поздравляем! Ваш ход первый.");
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = true;
					num = (int)(num2 * 1142420529) ^ -582244638;
					continue;
				case 6u:
					num = -1835608749;
					continue;
				case 5u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).StartGame();
					num = ((int)num2 * -1458889431) ^ -1655485998;
					continue;
				case 3u:
					flag = Form2.smethod_8(Form2.smethod_7((Control)(object)textBox1), "");
					num = ((int)num2 * -1178977231) ^ -525240471;
					continue;
				case 2u:
					num = (int)((num2 * 431565571) ^ 0x17B91DEA);
					continue;
				case 1u:
					num = ((int)num2 * -1071869430) ^ -348275740;
					continue;
				case 0u:
					Form2.smethod_14(Form2.smethod_11(Form2.smethod_2((Form)(object)this)));
					num = (int)(num2 * 869061569) ^ -1413146701;
					continue;
				default:
					return;
				case 12u:
					break;
				case 4u:
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
			int num = 537819141;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x1D238769u) % 7u)
				{
				case 6u:
					Form2.smethod_16((IDisposable)components);
					num = ((int)num2 * -1052396608) ^ 0x5D378648;
					continue;
				case 5u:
					if (disposing)
					{
						num = ((int)num2 * -1870753670) ^ 0x3D34BB5D;
						continue;
					}
					goto IL_0041;
				case 4u:
					num = (int)((num2 * 172658417) ^ 0x153FC4F3);
					continue;
				case 3u:
					((Form)this).Dispose(disposing);
					num = 135131193;
					continue;
				case 1u:
					if (components != null)
					{
						num = 845747450;
						num3 = 845747450;
						continue;
					}
					goto IL_0041;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
					IL_0041:
					num = 1804267784;
					num3 = 1804267784;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Expected O, but got Unknown
		while (true)
		{
			int num = -1631765259;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF7B143C1u) % 57u)
				{
				case 56u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)button1);
					num = (int)(num2 * 240795906) ^ -1136199790;
					continue;
				case 55u:
					num = (int)((num2 * 1503075321) ^ 0x3EEB338D);
					continue;
				case 54u:
					Form2.smethod_32((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -163249352) ^ -973222162;
					continue;
				case 53u:
					Form2.smethod_25((Control)(object)label1, 0);
					num = ((int)num2 * -733089557) ^ -142025302;
					continue;
				case 52u:
					Form2.smethod_30((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -186110083) ^ 0xDF77F59;
					continue;
				case 51u:
					Form2.smethod_23((Control)(object)label1, "label1");
					num = (int)(num2 * 326659635) ^ -215240479;
					continue;
				case 50u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)textBox1);
					num = (int)((num2 * 1158232710) ^ 0x5290DCCA);
					continue;
				case 49u:
					num = ((int)num2 * -1425225242) ^ 0xCEBBF15;
					continue;
				case 47u:
					num = ((int)num2 * -575177787) ^ 0x70A25871;
					continue;
				case 46u:
					Form2.smethod_29((ButtonBase)(object)button1, bool_0: true);
					num = (int)(num2 * 1431103840) ^ -1023914692;
					continue;
				case 45u:
					num = ((int)num2 * -1040529653) ^ -1760358123;
					continue;
				case 44u:
					label3 = Form2.smethod_17();
					num = (int)(num2 * 1048657272) ^ -724803191;
					continue;
				case 43u:
					Form2.smethod_24((Control)(object)label3, new Size(0, 13));
					num = ((int)num2 * -209795563) ^ -775714626;
					continue;
				case 42u:
					Form2.smethod_25((Control)(object)button1, 3);
					Form2.smethod_1((Control)(object)button1, "OK");
					num = ((int)num2 * -787542939) ^ 0xF8AA171;
					continue;
				case 41u:
					Form2.smethod_22((Control)(object)textBox1, new Point(24, 86));
					Form2.smethod_23((Control)(object)textBox1, "textBox1");
					num = (int)(num2 * 1849606216) ^ -932480183;
					continue;
				case 40u:
					num = (int)((num2 * 223664500) ^ 0x10587F81);
					continue;
				case 39u:
					Form2.smethod_20((Control)(object)this);
					num = ((int)num2 * -825151512) ^ 0x25A1D9C1;
					continue;
				case 38u:
					Form2.smethod_24((Control)(object)label1, new Size(35, 13));
					num = ((int)num2 * -513371163) ^ -577461448;
					continue;
				case 37u:
					Form2.smethod_24((Control)(object)textBox1, new Size(42, 80));
					Form2.smethod_25((Control)(object)textBox1, 1);
					Form2.smethod_28((Control)(object)textBox1, new KeyPressEventHandler(TextBox1_KeyPress));
					num = ((int)num2 * -1061191296) ^ 0x2BDCE4B5;
					continue;
				case 36u:
					Form2.smethod_39((Control)(object)this, "Form2");
					num = (int)(num2 * 609689238) ^ -2064679312;
					continue;
				case 35u:
					Form2.smethod_31((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -1829773688) ^ -773637543;
					continue;
				case 34u:
					num = ((int)num2 * -794295875) ^ 0x2AB0FF2B;
					continue;
				case 33u:
					Form2.smethod_22((Control)(object)label3, new Point(47, 177));
					Form2.smethod_23((Control)(object)label3, "label3");
					num = (int)(num2 * 1001330107) ^ -364943328;
					continue;
				case 32u:
					Form2.smethod_40((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1078361746) ^ -1224774582;
					continue;
				case 30u:
					Form2.smethod_24((Control)(object)button1, new Size(73, 23));
					num = (int)((num2 * 1106695323) ^ 0x7D0ECC0D);
					continue;
				case 29u:
					Form2.smethod_1((Control)(object)label2, "+N=?");
					num = ((int)num2 * -1733705797) ^ -1764815098;
					continue;
				case 28u:
					num = (int)((num2 * 102671678) ^ 0x544C0E6);
					continue;
				case 27u:
					Form2.smethod_38((Form)(object)this, bool_0: false);
					num = ((int)num2 * -851534454) ^ -155547991;
					continue;
				case 26u:
					num = ((int)num2 * -322417748) ^ -482516434;
					continue;
				case 25u:
					Form2.smethod_36((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -2062827901) ^ -838113345;
					continue;
				case 24u:
					num = (int)(num2 * 2088258625) ^ -1168397915;
					continue;
				case 23u:
					num = ((int)num2 * -1846705794) ^ 0x670833C5;
					continue;
				case 22u:
					Form2.smethod_21((Control)(object)label3, bool_0: true);
					num = ((int)num2 * -1627250348) ^ -1365536694;
					continue;
				case 21u:
					num = (int)((num2 * 96006211) ^ 0x3BCFBE7E);
					continue;
				case 20u:
					Form2.smethod_23((Control)(object)button1, "button1");
					num = (int)(num2 * 1036880358) ^ -1271892286;
					continue;
				case 19u:
					label2 = Form2.smethod_17();
					button1 = Form2.smethod_19();
					num = (int)((num2 * 1814931159) ^ 0x1997257E);
					continue;
				case 18u:
					num = ((int)num2 * -1076979466) ^ 0x38DD6ECC;
					continue;
				case 17u:
					Form2.smethod_21((Control)(object)label2, bool_0: true);
					Form2.smethod_27((Control)(object)label2, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form2.smethod_22((Control)(object)label2, new Point(53, 89));
					num = ((int)num2 * -1744090948) ^ 0xA915DFD;
					continue;
				case 16u:
					num = ((int)num2 * -2028148638) ^ -869484687;
					continue;
				case 15u:
					num = (int)(num2 * 1451016566) ^ -586961309;
					continue;
				case 14u:
					label1 = Form2.smethod_17();
					num = (int)((num2 * 1573714560) ^ 0x1EF442EF);
					continue;
				case 13u:
					Form2.smethod_22((Control)(object)label1, new Point(10, 10));
					num = (int)(num2 * 257388735) ^ -175184003;
					continue;
				case 12u:
					Form2.smethod_21((Control)(object)label1, bool_0: true);
					num = (int)(num2 * 443106213) ^ -1882913636;
					continue;
				case 11u:
					num = ((int)num2 * -333600079) ^ 0x7AF7B8BE;
					continue;
				case 10u:
					Form2.smethod_42((Control)(object)this, bool_0: false);
					Form2.smethod_43((Control)(object)this);
					num = ((int)num2 * -724940811) ^ -990370246;
					continue;
				case 9u:
					textBox1 = Form2.smethod_18();
					num = ((int)num2 * -1850998875) ^ -220395708;
					continue;
				case 8u:
					Form2.smethod_23((Control)(object)label2, "label2");
					num = ((int)num2 * -1554410925) ^ 0x63D6318B;
					continue;
				case 7u:
					Form2.smethod_1((Control)(object)this, "Жеребьёвка");
					Form2.smethod_41((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
					num = ((int)num2 * -428335134) ^ -486453230;
					continue;
				case 6u:
					Form2.smethod_33((Form)(object)this, new Size(255, 224));
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label3);
					num = ((int)num2 * -1759322193) ^ -880828580;
					continue;
				case 5u:
					Form2.smethod_24((Control)(object)label2, new Size(188, 73));
					Form2.smethod_25((Control)(object)label2, 2);
					num = (int)(num2 * 1707005657) ^ -670516932;
					continue;
				case 4u:
					Form2.smethod_37((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1514599482) ^ -487064434;
					continue;
				case 3u:
					Form2.smethod_22((Control)(object)button1, new Point(86, 193));
					num = (int)(num2 * 2055264857) ^ -665314860;
					continue;
				case 2u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label2);
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label1);
					num = (int)(num2 * 539591549) ^ -349220326;
					continue;
				case 1u:
					Form2.smethod_1((Control)(object)label1, "label1");
					Form2.smethod_27((Control)(object)textBox1, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -508934919) ^ 0x50C54416;
					continue;
				case 0u:
					Form2.smethod_25((Control)(object)label3, 4);
					num = ((int)num2 * -1607348376) ^ 0x5BBD2298;
					continue;
				default:
					return;
				case 48u:
					break;
				case 31u:
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
