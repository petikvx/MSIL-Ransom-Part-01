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
			int num = 762523239;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x15C46C3Fu) % 10u)
				{
				case 9u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = -1779236998;
						num6 = -1779236998;
					}
					else
					{
						num5 = -2123874266;
						num6 = -2123874266;
					}
					num = num5 ^ (int)(num2 * 1576105769);
					continue;
				}
				case 8u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1912766424;
						num4 = 1912766424;
					}
					else
					{
						num3 = 447625915;
						num4 = 447625915;
					}
					num = num3 ^ (int)(num2 * 562309589);
					continue;
				}
				case 7u:
					num = ((int)num2 * -1422336011) ^ -1444168786;
					continue;
				case 5u:
					num = (int)((num2 * 1756383250) ^ 0x3E3A24B8);
					continue;
				case 4u:
					Button1_Click(this, Form2.smethod_6());
					num = (int)(num2 * 658955557) ^ -846514210;
					continue;
				case 3u:
					flag2 = Form2.smethod_4(e) == '\r';
					num = 2000849550;
					continue;
				case 2u:
					Form2.smethod_5(e, bool_0: true);
					num = (int)((num2 * 954960312) ^ 0x23BEF74C);
					continue;
				case 1u:
					Form2.smethod_1((Control)(object)textBox1, "");
					num = 457455982;
					continue;
				default:
					return;
				case 6u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		bool flag = Form2.smethod_8(Form2.smethod_7((Control)(object)textBox1), "");
		int num4 = default(int);
		int num9 = default(int);
		int num3 = default(int);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num = 582696912;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x44251D34u) % 32u)
				{
				case 31u:
					num = ((int)num2 * -1009695225) ^ -1651732992;
					continue;
				case 30u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = false;
					num = (int)((num2 * 1694729553) ^ 0x19A8461A);
					continue;
				case 29u:
				{
					Label control_ = label2;
					string string_ = num4.ToString();
					num9 = num3 + num4;
					Form2.smethod_1((Control)(object)control_, Form2.smethod_10("+", string_, "=", num9.ToString()));
					num = (int)((num2 * 959255354) ^ 0x4D50DA44);
					continue;
				}
				case 28u:
					num = 538178091;
					continue;
				case 26u:
					flag2 = this.flag;
					num = (int)(num2 * 343126981) ^ -1318169298;
					continue;
				case 25u:
					num = (int)(num2 * 1835497966) ^ -1590449722;
					continue;
				case 24u:
				{
					int num7;
					int num8;
					if (flag2)
					{
						num7 = 148995530;
						num8 = 148995530;
					}
					else
					{
						num7 = 1502272944;
						num8 = 1502272944;
					}
					num = num7 ^ (int)(num2 * 984373081);
					continue;
				}
				case 23u:
					(Form2.smethod_2((Form)(object)this) as Form3).Button_Continue();
					num = (int)(num2 * 1203569159) ^ -392816160;
					continue;
				case 22u:
					flag3 = num9 > 1;
					num = (int)(num2 * 26863171) ^ -1198578017;
					continue;
				case 21u:
					num = ((int)num2 * -1387058888) ^ 0x258F3F24;
					continue;
				case 20u:
					num = 1383871861;
					continue;
				case 19u:
					num = ((int)num2 * -185341261) ^ -1014444616;
					continue;
				case 18u:
					num = 96374233;
					continue;
				case 17u:
					Form2.smethod_1((Control)(object)label3, "Поздравляем! Ваш ход первый.");
					num = (int)((num2 * 324680314) ^ 0x61859397);
					continue;
				case 16u:
					num = ((int)num2 * -236918829) ^ -1770030719;
					continue;
				case 15u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).StartGame();
					Form2.smethod_15((Form)(object)this);
					num = ((int)num2 * -1691496381) ^ 0x6B2ED9DA;
					continue;
				case 13u:
				{
					Form control_2 = Form2.smethod_2((Form)(object)this);
					num9 = Form2.smethod_12((Control)(object)control_2) - 1;
					Form2.smethod_13((Control)(object)control_2, num9);
					num = 366280766;
					continue;
				}
				case 12u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = true;
					num = ((int)num2 * -2014608043) ^ 0x25D5F41B;
					continue;
				case 11u:
					num4 = Form2.smethod_9(rnd, 10);
					num = (int)((num2 * 44204676) ^ 0x66A119C5);
					continue;
				case 10u:
					num = ((int)num2 * -820553551) ^ -1133886104;
					continue;
				case 9u:
				{
					int num12;
					int num13;
					if (!flag3)
					{
						num12 = 16344986;
						num13 = 16344986;
					}
					else
					{
						num12 = 1119943263;
						num13 = 1119943263;
					}
					num = num12 ^ (int)(num2 * 151153297);
					continue;
				}
				case 8u:
					Form2.smethod_14(Form2.smethod_11(Form2.smethod_2((Form)(object)this)));
					num = ((int)num2 * -121631373) ^ -206446333;
					continue;
				case 7u:
					num = 1138633690;
					continue;
				case 6u:
					num = ((int)num2 * -100052231) ^ -1873828190;
					continue;
				case 5u:
					this.flag = false;
					num = 1483739315;
					continue;
				case 4u:
				{
					int num10;
					int num11;
					if (!flag)
					{
						num10 = 592704030;
						num11 = 592704030;
					}
					else
					{
						num10 = 2129036298;
						num11 = 2129036298;
					}
					num = num10 ^ ((int)num2 * -2080829575);
					continue;
				}
				case 3u:
					num = ((int)num2 * -515292921) ^ 0x67323BC6;
					continue;
				case 2u:
				{
					int num5;
					int num6;
					if ((num3 + num4) % 2 == 0)
					{
						num5 = -274361875;
						num6 = -274361875;
					}
					else
					{
						num5 = -1492276280;
						num6 = -1492276280;
					}
					num = num5 ^ ((int)num2 * -1857577772);
					continue;
				}
				case 1u:
					Form2.smethod_1((Control)(object)label3, "Первым ход делает Компьютер.");
					num = (int)((num2 * 46680499) ^ 0x145AE399);
					continue;
				case 0u:
					num3 = int.Parse(Form2.smethod_7((Control)(object)textBox1));
					num = (int)((num2 * 117083921) ^ 0x4683757F);
					continue;
				default:
					return;
				case 27u:
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
		if (disposing)
		{
			goto IL_005c;
		}
		goto IL_0099;
		IL_005c:
		int num = 1513724904;
		goto IL_0061;
		IL_0061:
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x5FD92EE3u) % 7u)
			{
			case 6u:
				num = ((int)num2 * -334433162) ^ 0x536B3F81;
				continue;
			case 4u:
				((Form)this).Dispose(disposing);
				num = 456999200;
				continue;
			case 3u:
				Form2.smethod_16((IDisposable)components);
				num = ((int)num2 * -1812468802) ^ -1119726802;
				continue;
			case 2u:
				num = (int)(num2 * 2138691486) ^ -1811579704;
				continue;
			case 0u:
				break;
			default:
				return;
			case 5u:
				goto IL_008e;
			case 1u:
				return;
			}
			break;
			IL_008e:
			if (components != null)
			{
				num = 555104672;
				num3 = 555104672;
				continue;
			}
			goto IL_0099;
		}
		goto IL_005c;
		IL_0099:
		num = 1620944206;
		num3 = 1620944206;
		goto IL_0061;
	}

	private void InitializeComponent()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0619: Unknown result type (might be due to invalid IL or missing references)
		//IL_0623: Expected O, but got Unknown
		while (true)
		{
			int num = -865448508;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF882B7A2u) % 63u)
				{
				case 62u:
					num = ((int)num2 * -2104986491) ^ -925321949;
					continue;
				case 61u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label3);
					num = ((int)num2 * -488805518) ^ -1783915520;
					continue;
				case 60u:
					Form2.smethod_28((Control)(object)textBox1, new KeyPressEventHandler(TextBox1_KeyPress));
					Form2.smethod_21((Control)(object)label2, bool_0: true);
					num = (int)((num2 * 1787745955) ^ 0x435D228);
					continue;
				case 59u:
					Form2.smethod_1((Control)(object)label1, "label1");
					num = ((int)num2 * -1963244122) ^ -1296497005;
					continue;
				case 58u:
					num = ((int)num2 * -597854136) ^ 0x2D39C851;
					continue;
				case 57u:
					num = (int)(num2 * 1453114870) ^ -1307620053;
					continue;
				case 56u:
					num = ((int)num2 * -741810612) ^ 0x63D97662;
					continue;
				case 55u:
					Form2.smethod_24((Control)(object)textBox1, new Size(42, 80));
					Form2.smethod_25((Control)(object)textBox1, 1);
					num = (int)((num2 * 1602099272) ^ 0x7671BDE8);
					continue;
				case 54u:
					Form2.smethod_1((Control)(object)button1, "OK");
					num = (int)(num2 * 1615934309) ^ -688024082;
					continue;
				case 53u:
					num = ((int)num2 * -723176337) ^ 0x770181D4;
					continue;
				case 52u:
					Form2.smethod_27((Control)(object)label2, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 633816420) ^ -113381852;
					continue;
				case 50u:
					Form2.smethod_42((Control)(object)this, bool_0: false);
					num = ((int)num2 * -956639612) ^ -1193627902;
					continue;
				case 49u:
					num = ((int)num2 * -1384042050) ^ -1441755390;
					continue;
				case 48u:
					Form2.smethod_43((Control)(object)this);
					num = (int)((num2 * 2004814539) ^ 0x807A35C);
					continue;
				case 47u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)textBox1);
					num = (int)(num2 * 191947813) ^ -2079065260;
					continue;
				case 46u:
					Form2.smethod_25((Control)(object)label1, 0);
					num = ((int)num2 * -486706238) ^ -850458183;
					continue;
				case 45u:
					Form2.smethod_23((Control)(object)label3, "label3");
					Form2.smethod_24((Control)(object)label3, new Size(0, 13));
					num = ((int)num2 * -71420860) ^ 0x76594EAD;
					continue;
				case 44u:
					Form2.smethod_22((Control)(object)button1, new Point(86, 193));
					num = (int)(num2 * 320505727) ^ -1863639450;
					continue;
				case 43u:
					Form2.smethod_1((Control)(object)label2, "+N=?");
					num = ((int)num2 * -589256819) ^ 0x700ADF12;
					continue;
				case 42u:
					button1 = Form2.smethod_19();
					num = (int)(num2 * 1081009329) ^ -1853266417;
					continue;
				case 41u:
					num = (int)((num2 * 1360405262) ^ 0x5DFDF7D2);
					continue;
				case 40u:
					Form2.smethod_22((Control)(object)textBox1, new Point(24, 86));
					num = ((int)num2 * -917918658) ^ 0xA20A9EF;
					continue;
				case 39u:
					num = ((int)num2 * -1158688484) ^ -2007842132;
					continue;
				case 38u:
					Form2.smethod_1((Control)(object)this, "Жеребьёвка");
					num = ((int)num2 * -2036507642) ^ 0x5F9A0CD8;
					continue;
				case 37u:
					num = (int)((num2 * 1783679796) ^ 0xA1426C1);
					continue;
				case 36u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label2);
					num = (int)(num2 * 1790531961) ^ -1591580686;
					continue;
				case 35u:
					Form2.smethod_32((ContainerControl)(object)this, (AutoScaleMode)1);
					Form2.smethod_33((Form)(object)this, new Size(255, 224));
					num = ((int)num2 * -224907297) ^ -1224850106;
					continue;
				case 34u:
					Form2.smethod_23((Control)(object)label2, "label2");
					num = (int)((num2 * 327436488) ^ 0x2396BA9B);
					continue;
				case 33u:
					num = (int)(num2 * 1858009457) ^ -1006903348;
					continue;
				case 32u:
					Form2.smethod_24((Control)(object)label2, new Size(188, 73));
					num = (int)((num2 * 1954951182) ^ 0x16878248);
					continue;
				case 31u:
					Form2.smethod_25((Control)(object)button1, 3);
					num = ((int)num2 * -763302268) ^ -876746386;
					continue;
				case 30u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)button1);
					num = (int)(num2 * 899552926) ^ -1473746835;
					continue;
				case 29u:
					Form2.smethod_23((Control)(object)textBox1, "textBox1");
					num = ((int)num2 * -1157193537) ^ 0x31930401;
					continue;
				case 28u:
					Form2.smethod_23((Control)(object)button1, "button1");
					Form2.smethod_24((Control)(object)button1, new Size(73, 23));
					num = (int)((num2 * 1269699836) ^ 0x408668E9);
					continue;
				case 27u:
					Form2.smethod_20((Control)(object)this);
					Form2.smethod_21((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -733810730) ^ -1312609858;
					continue;
				case 26u:
					Form2.smethod_40((Form)(object)this, bool_0: false);
					num = (int)(num2 * 247565352) ^ -1393087794;
					continue;
				case 25u:
					Form2.smethod_22((Control)(object)label2, new Point(53, 89));
					num = (int)(num2 * 381637834) ^ -23514161;
					continue;
				case 23u:
					Form2.smethod_22((Control)(object)label3, new Point(47, 177));
					num = (int)((num2 * 1820852003) ^ 0x142C1DB6);
					continue;
				case 22u:
					Form2.smethod_37((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1211175882) ^ -1105023438;
					continue;
				case 21u:
					Form2.smethod_38((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1202205263) ^ -57042574;
					continue;
				case 20u:
					Form2.smethod_30((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)((num2 * 746937150) ^ 0x671F529D);
					continue;
				case 19u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label1);
					Form2.smethod_36((Form)(object)this, (FormBorderStyle)1);
					num = (int)((num2 * 911637801) ^ 0x6E1F794B);
					continue;
				case 18u:
					Form2.smethod_25((Control)(object)label2, 2);
					num = (int)((num2 * 1949530616) ^ 0x612D8646);
					continue;
				case 17u:
					Form2.smethod_23((Control)(object)label1, "label1");
					num = (int)(num2 * 2048389329) ^ -1098795829;
					continue;
				case 16u:
					num = (int)((num2 * 122784368) ^ 0x3C661BEB);
					continue;
				case 15u:
					label1 = Form2.smethod_17();
					textBox1 = Form2.smethod_18();
					label2 = Form2.smethod_17();
					num = (int)((num2 * 539067652) ^ 0x76C7C821);
					continue;
				case 14u:
					num = (int)(num2 * 210299331) ^ -652610069;
					continue;
				case 13u:
					Form2.smethod_31((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -153480995) ^ 0x3D78E7C8;
					continue;
				case 12u:
					Form2.smethod_41((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
					num = (int)(num2 * 1754480372) ^ -347361760;
					continue;
				case 11u:
					num = (int)((num2 * 486083748) ^ 0x56D3F69E);
					continue;
				case 10u:
					Form2.smethod_27((Control)(object)textBox1, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 854539699) ^ 0x23F9A38C);
					continue;
				case 9u:
					Form2.smethod_21((Control)(object)label3, bool_0: true);
					num = ((int)num2 * -1568782517) ^ -222070906;
					continue;
				case 8u:
					num = ((int)num2 * -923954666) ^ 0x28A01701;
					continue;
				case 7u:
					Form2.smethod_39((Control)(object)this, "Form2");
					num = ((int)num2 * -887347722) ^ -1614664108;
					continue;
				case 6u:
					Form2.smethod_22((Control)(object)label1, new Point(10, 10));
					num = ((int)num2 * -2091740411) ^ -556990482;
					continue;
				case 5u:
					Form2.smethod_24((Control)(object)label1, new Size(35, 13));
					num = ((int)num2 * -631910956) ^ -1568921974;
					continue;
				case 4u:
					Form2.smethod_29((ButtonBase)(object)button1, bool_0: true);
					num = (int)(num2 * 1683984043) ^ -1411438828;
					continue;
				case 3u:
					label3 = Form2.smethod_17();
					num = ((int)num2 * -1701904852) ^ 0x299770A;
					continue;
				case 2u:
					Form2.smethod_25((Control)(object)label3, 4);
					num = (int)((num2 * 1191325254) ^ 0x2F3A98C);
					continue;
				case 1u:
					num = ((int)num2 * -1355860574) ^ 0x30742193;
					continue;
				case 0u:
					num = (int)((num2 * 1039838466) ^ 0x5E6E2270);
					continue;
				default:
					return;
				case 51u:
					break;
				case 24u:
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
