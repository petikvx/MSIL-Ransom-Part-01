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
		while (true)
		{
			int num = -2076398887;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB698867Du) % 11u)
				{
				case 10u:
					num = (int)((num2 * 194538804) ^ 0x3AFAA5F);
					continue;
				case 9u:
				{
					int num4;
					int num5;
					if (char.IsDigit(Form2.smethod_4(e)))
					{
						num4 = -560477455;
						num5 = -560477455;
					}
					else
					{
						num4 = -1855065068;
						num5 = -1855065068;
					}
					num = num4 ^ ((int)num2 * -418828142);
					continue;
				}
				case 7u:
					Form2.smethod_1((Control)(object)textBox1, "");
					num = -1249559635;
					continue;
				case 6u:
					num = ((int)num2 * -332580815) ^ -1118702642;
					continue;
				case 5u:
				{
					int num3;
					if (Form2.smethod_4(e) == '\r')
					{
						num = -1797173678;
						num3 = -1797173678;
					}
					else
					{
						num = -1843274053;
						num3 = -1843274053;
					}
					continue;
				}
				case 4u:
					num = ((int)num2 * -316450346) ^ 0x23BA5FB6;
					continue;
				case 3u:
					Button1_Click(this, Form2.smethod_6());
					num = ((int)num2 * -2079718830) ^ -1067310866;
					continue;
				case 2u:
					Form2.smethod_5(e, bool_0: true);
					num = (int)(num2 * 106279741) ^ -879870274;
					continue;
				case 1u:
					num = (int)((num2 * 24251459) ^ 0x614196C3);
					continue;
				default:
					return;
				case 0u:
					break;
				case 8u:
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
		bool flag2 = default(bool);
		int num4 = default(int);
		int num3 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -1243944129;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE3F9CEEFu) % 28u)
				{
				case 27u:
					flag2 = this.flag;
					num = (int)(num2 * 593417776) ^ -1747390937;
					continue;
				case 25u:
					num = ((int)num2 * -1247368542) ^ -429203939;
					continue;
				case 24u:
				{
					int num9;
					int num10;
					if (flag2)
					{
						num9 = -163791017;
						num10 = -163791017;
					}
					else
					{
						num9 = -869133307;
						num10 = -869133307;
					}
					num = num9 ^ (int)(num2 * 1345089128);
					continue;
				}
				case 23u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = true;
					num = ((int)num2 * -225990654) ^ -1810371684;
					continue;
				case 22u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).StartGame();
					num = (int)((num2 * 804740427) ^ 0x5A51BD08);
					continue;
				case 21u:
					num = (int)((num2 * 1000330150) ^ 0x76A8FCA5);
					continue;
				case 20u:
				{
					int num11 = Form2.smethod_9(rnd, 10);
					Label control_2 = label2;
					string string_ = num11.ToString();
					num4 = num3 + num11;
					Form2.smethod_1((Control)(object)control_2, Form2.smethod_10("+", string_, "=", num4.ToString()));
					flag = (num3 + num11) % 2 == 0;
					num = (int)(num2 * 619624797) ^ -1836683694;
					continue;
				}
				case 18u:
				{
					int num7;
					int num8;
					if (num4 > 1)
					{
						num7 = 1414937318;
						num8 = 1414937318;
					}
					else
					{
						num7 = 2101222538;
						num8 = 2101222538;
					}
					num = num7 ^ (int)(num2 * 1741347800);
					continue;
				}
				case 17u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = 1495261352;
						num6 = 1495261352;
					}
					else
					{
						num5 = 426400526;
						num6 = 426400526;
					}
					num = num5 ^ (int)(num2 * 900491459);
					continue;
				}
				case 16u:
					Form2.smethod_15((Form)(object)this);
					num = ((int)num2 * -403216846) ^ -465155222;
					continue;
				case 15u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = false;
					num = ((int)num2 * -112212715) ^ 0x27637947;
					continue;
				case 14u:
					num = -1060888140;
					continue;
				case 13u:
					num = ((int)num2 * -894115320) ^ -1107625651;
					continue;
				case 12u:
					Form2.smethod_1((Control)(object)label3, "Поздравляем! Ваш ход первый.");
					num = (int)((num2 * 1448632862) ^ 0x31F808B0);
					continue;
				case 11u:
					Form2.smethod_14(Form2.smethod_11(Form2.smethod_2((Form)(object)this)));
					num = (int)((num2 * 629786536) ^ 0x41541CD);
					continue;
				case 10u:
					num = (int)(num2 * 244531499) ^ -2033701200;
					continue;
				case 9u:
					(Form2.smethod_2((Form)(object)this) as Form3).Button_Continue();
					num = (int)((num2 * 396596762) ^ 0x4DF519A6);
					continue;
				case 8u:
					num = ((int)num2 * -1187315451) ^ 0x11BB677C;
					continue;
				case 7u:
				{
					Form control_ = Form2.smethod_2((Form)(object)this);
					num4 = Form2.smethod_12((Control)(object)control_) - 1;
					Form2.smethod_13((Control)(object)control_, num4);
					num = -1751409887;
					continue;
				}
				case 6u:
					num = ((int)num2 * -434959655) ^ -361129159;
					continue;
				case 5u:
					this.flag = false;
					num = -143614179;
					continue;
				case 4u:
					num = -2135476776;
					continue;
				case 3u:
					num = ((int)num2 * -2094518059) ^ 0x294C33F9;
					continue;
				case 2u:
					Form2.smethod_1((Control)(object)label3, "Первым ход делает Компьютер.");
					num = -1215155144;
					continue;
				case 1u:
					num = -1060888140;
					continue;
				case 0u:
					num3 = int.Parse(Form2.smethod_7((Control)(object)textBox1));
					num = (int)((num2 * 583357235) ^ 0x1DCCEE23);
					continue;
				default:
					return;
				case 26u:
					break;
				case 19u:
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
			int num = -201950804;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xD620FCBDu) % 9u)
				{
				case 8u:
					Form2.smethod_16((IDisposable)components);
					num = ((int)num2 * -1841636575) ^ 0x57E77AAD;
					continue;
				case 7u:
					num = (int)(num2 * 1280121511) ^ -173858710;
					continue;
				case 6u:
					num = ((int)num2 * -555975922) ^ -621425767;
					continue;
				case 5u:
					if (disposing)
					{
						num = ((int)num2 * -2071022825) ^ 0x43A7BEB4;
						continue;
					}
					goto IL_005f;
				case 4u:
					if (components != null)
					{
						num = -1297259558;
						num3 = -1297259558;
						continue;
					}
					goto IL_005f;
				case 3u:
					((Form)this).Dispose(disposing);
					num = -2070118121;
					continue;
				case 1u:
					num = (int)((num2 * 1659124060) ^ 0x4780CC70);
					continue;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
					IL_005f:
					num = -1900710696;
					num3 = -1900710696;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a1: Expected O, but got Unknown
		//IL_066c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0676: Expected O, but got Unknown
		while (true)
		{
			int num = -264755091;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x993350D5u) % 61u)
				{
				case 60u:
					num = (int)((num2 * 477243838) ^ 0x53DEFF8D);
					continue;
				case 59u:
					Form2.smethod_22((Control)(object)textBox1, new Point(24, 86));
					num = ((int)num2 * -677942875) ^ 0x1BB3C682;
					continue;
				case 58u:
					Form2.smethod_22((Control)(object)button1, new Point(86, 193));
					num = (int)(num2 * 998214366) ^ -423200630;
					continue;
				case 57u:
					Form2.smethod_21((Control)(object)label3, bool_0: true);
					num = ((int)num2 * -1398655297) ^ 0x4FB44209;
					continue;
				case 56u:
					Form2.smethod_25((Control)(object)button1, 3);
					num = (int)((num2 * 967013760) ^ 0xC01D9);
					continue;
				case 55u:
					num = ((int)num2 * -1870349671) ^ -751107374;
					continue;
				case 54u:
					Form2.smethod_23((Control)(object)label1, "label1");
					Form2.smethod_24((Control)(object)label1, new Size(35, 13));
					Form2.smethod_25((Control)(object)label1, 0);
					Form2.smethod_1((Control)(object)label1, "label1");
					Form2.smethod_27((Control)(object)textBox1, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -251465985) ^ 0x75940EE1;
					continue;
				case 53u:
					Form2.smethod_24((Control)(object)label2, new Size(188, 73));
					num = ((int)num2 * -1705661030) ^ 0x7EE99E71;
					continue;
				case 52u:
					Form2.smethod_24((Control)(object)button1, new Size(73, 23));
					num = (int)(num2 * 1415086308) ^ -378506106;
					continue;
				case 51u:
					Form2.smethod_42((Control)(object)this, bool_0: false);
					num = (int)(num2 * 1866894252) ^ -1597459258;
					continue;
				case 50u:
					Form2.smethod_22((Control)(object)label1, new Point(10, 10));
					num = (int)(num2 * 1005288280) ^ -1608044784;
					continue;
				case 49u:
					Form2.smethod_27((Control)(object)label2, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 521410011) ^ 0x19D6F93F);
					continue;
				case 48u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label2);
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -1788653556) ^ -1681952651;
					continue;
				case 47u:
					num = ((int)num2 * -1142494319) ^ 0x5337475A;
					continue;
				case 46u:
					Form2.smethod_23((Control)(object)button1, "button1");
					num = ((int)num2 * -410358196) ^ 0x27107152;
					continue;
				case 45u:
					textBox1 = Form2.smethod_18();
					label2 = Form2.smethod_17();
					button1 = Form2.smethod_19();
					num = (int)((num2 * 1192522080) ^ 0x4B6B9BF2);
					continue;
				case 44u:
					Form2.smethod_20((Control)(object)this);
					Form2.smethod_21((Control)(object)label1, bool_0: true);
					num = (int)(num2 * 1112905335) ^ -1141248752;
					continue;
				case 43u:
					Form2.smethod_36((Form)(object)this, (FormBorderStyle)1);
					num = (int)((num2 * 2075760156) ^ 0x1AA1B1B6);
					continue;
				case 42u:
					num = ((int)num2 * -53410141) ^ -284692371;
					continue;
				case 41u:
					num = (int)(num2 * 449239878) ^ -680741820;
					continue;
				case 40u:
					Form2.smethod_31((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -1829420383) ^ -1992799288;
					continue;
				case 39u:
					Form2.smethod_29((ButtonBase)(object)button1, bool_0: true);
					Form2.smethod_30((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -1063132771) ^ -779644846;
					continue;
				case 38u:
					Form2.smethod_24((Control)(object)textBox1, new Size(42, 80));
					num = ((int)num2 * -783027883) ^ 0x638C6648;
					continue;
				case 37u:
					Form2.smethod_25((Control)(object)label2, 2);
					num = ((int)num2 * -1064057160) ^ 0x454F1B;
					continue;
				case 35u:
					Form2.smethod_1((Control)(object)button1, "OK");
					num = ((int)num2 * -1955209351) ^ -1207998505;
					continue;
				case 34u:
					num = ((int)num2 * -1956661084) ^ 0x7EE54D3A;
					continue;
				case 32u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)button1);
					num = (int)(num2 * 1015183578) ^ -831277511;
					continue;
				case 31u:
					Form2.smethod_25((Control)(object)label3, 4);
					num = ((int)num2 * -521061617) ^ 0xAE4802A;
					continue;
				case 30u:
					num = ((int)num2 * -1115535997) ^ 0x12B6601;
					continue;
				case 29u:
					label3 = Form2.smethod_17();
					num = (int)((num2 * 545418278) ^ 0x43BDF7EF);
					continue;
				case 28u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)textBox1);
					num = ((int)num2 * -1714447320) ^ -1456503273;
					continue;
				case 27u:
					Form2.smethod_22((Control)(object)label2, new Point(53, 89));
					num = (int)(num2 * 1051182250) ^ -1449724192;
					continue;
				case 26u:
					num = ((int)num2 * -1627132774) ^ 0x203434CC;
					continue;
				case 25u:
					num = ((int)num2 * -990262665) ^ -270883088;
					continue;
				case 24u:
					Form2.smethod_40((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1177482467) ^ -1703330892;
					continue;
				case 23u:
					Form2.smethod_1((Control)(object)label2, "+N=?");
					num = (int)((num2 * 300450881) ^ 0x1B0944E9);
					continue;
				case 22u:
					Form2.smethod_32((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 883335394) ^ 0x23DCF103);
					continue;
				case 21u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label3);
					num = ((int)num2 * -16751568) ^ -830308456;
					continue;
				case 20u:
					Form2.smethod_37((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1701490921) ^ -680274074;
					continue;
				case 19u:
					num = ((int)num2 * -2042531868) ^ -435621010;
					continue;
				case 18u:
					num = (int)(num2 * 1643715354) ^ -1075732675;
					continue;
				case 17u:
					Form2.smethod_23((Control)(object)label2, "label2");
					num = ((int)num2 * -1411598051) ^ -684189569;
					continue;
				case 16u:
					Form2.smethod_25((Control)(object)textBox1, 1);
					num = (int)((num2 * 577089369) ^ 0x231F5507);
					continue;
				case 15u:
					Form2.smethod_28((Control)(object)textBox1, new KeyPressEventHandler(TextBox1_KeyPress));
					Form2.smethod_21((Control)(object)label2, bool_0: true);
					num = (int)((num2 * 959843349) ^ 0x31C9FCCA);
					continue;
				case 14u:
					num = (int)(num2 * 1053417652) ^ -2063740011;
					continue;
				case 13u:
					num = (int)(num2 * 228099767) ^ -1218141216;
					continue;
				case 12u:
					Form2.smethod_38((Form)(object)this, bool_0: false);
					Form2.smethod_39((Control)(object)this, "Form2");
					num = ((int)num2 * -864593220) ^ -130304480;
					continue;
				case 11u:
					num = ((int)num2 * -799562900) ^ 0x360517F5;
					continue;
				case 10u:
					Form2.smethod_23((Control)(object)textBox1, "textBox1");
					num = (int)(num2 * 1087029828) ^ -1755436597;
					continue;
				case 9u:
					Form2.smethod_22((Control)(object)label3, new Point(47, 177));
					num = (int)((num2 * 1189667375) ^ 0x64EE093D);
					continue;
				case 8u:
					Form2.smethod_41((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
					num = (int)(num2 * 1232211784) ^ -1034854793;
					continue;
				case 7u:
					num = (int)(num2 * 1512510966) ^ -1802534976;
					continue;
				case 6u:
					Form2.smethod_33((Form)(object)this, new Size(255, 224));
					num = ((int)num2 * -2025966030) ^ 0x3516EB09;
					continue;
				case 5u:
					Form2.smethod_1((Control)(object)this, "Жеребьёвка");
					num = (int)(num2 * 1243813531) ^ -2138288330;
					continue;
				case 4u:
					num = (int)((num2 * 609820913) ^ 0x51BFD829);
					continue;
				case 3u:
					Form2.smethod_23((Control)(object)label3, "label3");
					Form2.smethod_24((Control)(object)label3, new Size(0, 13));
					num = ((int)num2 * -1144790830) ^ 0x24358AF;
					continue;
				case 2u:
					num = (int)((num2 * 1774216246) ^ 0x72DB380F);
					continue;
				case 1u:
					label1 = Form2.smethod_17();
					num = ((int)num2 * -1195337750) ^ 0x6CEF803F;
					continue;
				case 0u:
					num = ((int)num2 * -1738533987) ^ -1427690534;
					continue;
				case 36u:
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
