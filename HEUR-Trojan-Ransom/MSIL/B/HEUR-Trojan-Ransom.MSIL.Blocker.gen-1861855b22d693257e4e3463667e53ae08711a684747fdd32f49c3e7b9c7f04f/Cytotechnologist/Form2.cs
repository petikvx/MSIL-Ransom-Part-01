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
		while (true)
		{
			int num = 1245468910;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x403FBC41u) % 9u)
				{
				case 8u:
					num = ((int)num2 * -1767424476) ^ -1367568122;
					continue;
				case 7u:
				{
					int num5;
					if (Form2.smethod_4(e) == '\r')
					{
						num = 1061259018;
						num5 = 1061259018;
					}
					else
					{
						num = 194003863;
						num5 = 194003863;
					}
					continue;
				}
				case 6u:
					Button1_Click(this, Form2.smethod_6());
					num = ((int)num2 * -1240864378) ^ 0xC3D0FD5;
					continue;
				case 3u:
					Form2.smethod_1((Control)(object)textBox1, "");
					num = 82391999;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 480049556;
						num4 = 480049556;
					}
					else
					{
						num3 = 193789923;
						num4 = 193789923;
					}
					num = num3 ^ ((int)num2 * -1596922690);
					continue;
				}
				case 1u:
					Form2.smethod_5(e, bool_0: true);
					num = ((int)num2 * -854755636) ^ -1391296198;
					continue;
				case 0u:
					num = (int)(num2 * 181241556) ^ -1742565213;
					continue;
				default:
					return;
				case 4u:
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
		if (!Form2.smethod_8(Form2.smethod_7((Control)(object)textBox1), ""))
		{
			return;
		}
		int num6 = default(int);
		int num7 = default(int);
		int num5 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -317935337;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFC32880Cu) % 30u)
				{
				case 29u:
					num = (int)((num2 * 1688665567) ^ 0x3BAC6599);
					continue;
				case 28u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).StartGame();
					num = ((int)num2 * -8875426) ^ -1069638401;
					continue;
				case 27u:
					Form2.smethod_1((Control)(object)label3, "Поздравляем! Ваш ход первый.");
					num = ((int)num2 * -1018363885) ^ -1646100899;
					continue;
				case 26u:
					num = ((int)num2 * -116717209) ^ -149401078;
					continue;
				case 25u:
					num = (int)(num2 * 1618517316) ^ -654890751;
					continue;
				case 24u:
				{
					Label control_2 = label2;
					string string_ = num6.ToString();
					num7 = num5 + num6;
					Form2.smethod_1((Control)(object)control_2, Form2.smethod_10("+", string_, "=", num7.ToString()));
					num = (int)(num2 * 1498416991) ^ -273367804;
					continue;
				}
				case 23u:
					Form2.smethod_15((Form)(object)this);
					num = ((int)num2 * -2089959988) ^ 0x22BFC0BF;
					continue;
				case 22u:
					flag = (num5 + num6) % 2 == 0;
					num = ((int)num2 * -955001857) ^ 0x438992CE;
					continue;
				case 21u:
				{
					int num10;
					int num11;
					if (num7 > 1)
					{
						num10 = -267452786;
						num11 = -267452786;
					}
					else
					{
						num10 = -901977179;
						num11 = -901977179;
					}
					num = num10 ^ ((int)num2 * -1803850088);
					continue;
				}
				case 20u:
				{
					int num8;
					int num9;
					if (this.flag)
					{
						num8 = -1711443638;
						num9 = -1711443638;
					}
					else
					{
						num8 = -442828561;
						num9 = -442828561;
					}
					num = num8 ^ ((int)num2 * -2051102023);
					continue;
				}
				case 19u:
					this.flag = false;
					num = -2000702029;
					continue;
				case 18u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = true;
					num = (int)((num2 * 2103005204) ^ 0x7E370627);
					continue;
				case 16u:
					num = -54941446;
					continue;
				case 15u:
					num = (int)(num2 * 1238908029) ^ -264972711;
					continue;
				case 14u:
					num = -125632269;
					continue;
				case 13u:
					num = ((int)num2 * -1433661052) ^ -1800462718;
					continue;
				case 12u:
				{
					Form control_ = Form2.smethod_2((Form)(object)this);
					num7 = Form2.smethod_12((Control)(object)control_) - 1;
					Form2.smethod_13((Control)(object)control_, num7);
					num = -293812015;
					continue;
				}
				case 11u:
					num = -54941446;
					continue;
				case 10u:
					num = (int)((num2 * 867713304) ^ 0x5D2DC580);
					continue;
				case 9u:
					(Form2.smethod_2((Form)(object)this) as Form3).Button_Continue();
					num = ((int)num2 * -540697745) ^ 0x66930B9F;
					continue;
				case 8u:
					Form2.smethod_14(Form2.smethod_11(Form2.smethod_2((Form)(object)this)));
					num = (int)(num2 * 511735261) ^ -703275980;
					continue;
				case 7u:
					num = ((int)num2 * -793326291) ^ -909837550;
					continue;
				case 6u:
					num = (int)(num2 * 114117249) ^ -342714391;
					continue;
				case 5u:
					Form2.smethod_1((Control)(object)label3, "Первым ход делает Компьютер.");
					num = -1795564990;
					continue;
				case 4u:
					num5 = int.Parse(Form2.smethod_7((Control)(object)textBox1));
					num6 = Form2.smethod_9(rnd, 10);
					num = (int)(num2 * 2017638700) ^ -2077465812;
					continue;
				case 2u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = false;
					num = (int)(num2 * 1083525889) ^ -855514490;
					continue;
				case 1u:
					num = ((int)num2 * -2131004333) ^ 0x67DEBE46;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1427190135;
						num4 = 1427190135;
					}
					else
					{
						num3 = 189508895;
						num4 = 189508895;
					}
					num = num3 ^ (int)(num2 * 191438239);
					continue;
				}
				default:
					return;
				case 3u:
					break;
				case 17u:
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
			goto IL_0040;
		}
		int num = 0;
		goto IL_00b2;
		IL_00b2:
		bool flag = (byte)num != 0;
		int num2 = -1805686543;
		goto IL_0078;
		IL_0040:
		num2 = -1156832662;
		goto IL_0078;
		IL_0078:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0xB0DD8C13u) % 8u)
			{
			case 7u:
				Form2.smethod_16((IDisposable)components);
				num2 = ((int)num3 * -1433665263) ^ -737141964;
				continue;
			case 5u:
				num2 = (int)(num3 * 1692768396) ^ -1564193471;
				continue;
			case 4u:
				((Form)this).Dispose(disposing);
				num2 = -201759218;
				continue;
			case 3u:
				break;
			case 2u:
			{
				int num4;
				int num5;
				if (flag)
				{
					num4 = -1357393412;
					num5 = -1357393412;
				}
				else
				{
					num4 = -516804505;
					num5 = -516804505;
				}
				num2 = num4 ^ (int)(num3 * 1505676272);
				continue;
			}
			case 0u:
				num2 = (int)((num3 * 1948367174) ^ 0x648DF297);
				continue;
			default:
				return;
			case 1u:
				goto IL_00a9;
			case 6u:
				return;
			}
			break;
		}
		goto IL_0040;
		IL_00a9:
		num = ((components != null) ? 1 : 0);
		goto IL_00b2;
	}

	private void InitializeComponent()
	{
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected O, but got Unknown
		//IL_052a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0534: Expected O, but got Unknown
		while (true)
		{
			int num = 822735594;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC6BA0D9u) % 64u)
				{
				case 63u:
					Form2.smethod_1((Control)(object)label1, "label1");
					num = ((int)num2 * -9560615) ^ -1056777735;
					continue;
				case 62u:
					button1 = Form2.smethod_19();
					label3 = Form2.smethod_17();
					num = (int)(num2 * 1446920998) ^ -957174068;
					continue;
				case 61u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -1943191368) ^ -2079613807;
					continue;
				case 60u:
					Form2.smethod_25((Control)(object)button1, 3);
					num = (int)((num2 * 1936887004) ^ 0x7177E64A);
					continue;
				case 59u:
					Form2.smethod_25((Control)(object)label2, 2);
					num = ((int)num2 * -191878991) ^ -1557157017;
					continue;
				case 58u:
					Form2.smethod_1((Control)(object)button1, "OK");
					num = ((int)num2 * -1138948979) ^ -1086474677;
					continue;
				case 57u:
					Form2.smethod_32((ContainerControl)(object)this, (AutoScaleMode)1);
					Form2.smethod_33((Form)(object)this, new Size(255, 224));
					num = (int)(num2 * 1586894991) ^ -460773294;
					continue;
				case 56u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)textBox1);
					num = (int)((num2 * 770216367) ^ 0x19C5C6F7);
					continue;
				case 55u:
					Form2.smethod_23((Control)(object)textBox1, "textBox1");
					Form2.smethod_24((Control)(object)textBox1, new Size(42, 80));
					num = ((int)num2 * -2133711498) ^ -9342837;
					continue;
				case 54u:
					Form2.smethod_21((Control)(object)label3, bool_0: true);
					num = ((int)num2 * -1904488097) ^ -1683492914;
					continue;
				case 53u:
					Form2.smethod_1((Control)(object)label2, "+N=?");
					num = ((int)num2 * -1788020889) ^ 0x14EE28A4;
					continue;
				case 52u:
					Form2.smethod_21((Control)(object)label2, bool_0: true);
					Form2.smethod_27((Control)(object)label2, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form2.smethod_22((Control)(object)label2, new Point(53, 89));
					num = (int)(num2 * 382201768) ^ -2009680022;
					continue;
				case 51u:
					label1 = Form2.smethod_17();
					textBox1 = Form2.smethod_18();
					num = ((int)num2 * -1211585411) ^ -815197062;
					continue;
				case 50u:
					Form2.smethod_23((Control)(object)label2, "label2");
					num = (int)(num2 * 516818912) ^ -2147233232;
					continue;
				case 49u:
					Form2.smethod_42((Control)(object)this, bool_0: false);
					num = (int)(num2 * 1308671639) ^ -233569749;
					continue;
				case 48u:
					num = (int)(num2 * 1945276657) ^ -352963691;
					continue;
				case 47u:
					num = (int)((num2 * 873290846) ^ 0x719B9AF3);
					continue;
				case 46u:
					Form2.smethod_22((Control)(object)button1, new Point(86, 193));
					Form2.smethod_23((Control)(object)button1, "button1");
					num = (int)(num2 * 131890262) ^ -255611037;
					continue;
				case 45u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)button1);
					num = (int)((num2 * 1729937382) ^ 0x62717ACF);
					continue;
				case 44u:
					Form2.smethod_22((Control)(object)textBox1, new Point(24, 86));
					num = (int)((num2 * 1942905682) ^ 0x690C8376);
					continue;
				case 43u:
					num = ((int)num2 * -1127432601) ^ -1450552178;
					continue;
				case 42u:
					num = ((int)num2 * -1464866960) ^ -900125144;
					continue;
				case 41u:
					Form2.smethod_24((Control)(object)label2, new Size(188, 73));
					num = (int)(num2 * 1137384339) ^ -893888343;
					continue;
				case 40u:
					Form2.smethod_30((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)((num2 * 1193385262) ^ 0x1A3AE79F);
					continue;
				case 39u:
					Form2.smethod_39((Control)(object)this, "Form2");
					num = (int)((num2 * 584525067) ^ 0x3826F038);
					continue;
				case 38u:
					num = ((int)num2 * -1561087690) ^ 0x209C93F8;
					continue;
				case 37u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label2);
					num = ((int)num2 * -1856545757) ^ -21429425;
					continue;
				case 36u:
					Form2.smethod_25((Control)(object)textBox1, 1);
					Form2.smethod_28((Control)(object)textBox1, new KeyPressEventHandler(TextBox1_KeyPress));
					num = ((int)num2 * -1061169362) ^ 0x4FD6E795;
					continue;
				case 35u:
					Form2.smethod_22((Control)(object)label1, new Point(10, 10));
					num = (int)(num2 * 726324820) ^ -276217686;
					continue;
				case 34u:
					Form2.smethod_29((ButtonBase)(object)button1, bool_0: true);
					num = (int)(num2 * 1553315976) ^ -1014066586;
					continue;
				case 33u:
					Form2.smethod_20((Control)(object)this);
					num = ((int)num2 * -2057230799) ^ 0x55A7F71A;
					continue;
				case 32u:
					num = (int)(num2 * 643116310) ^ -1231246725;
					continue;
				case 31u:
					Form2.smethod_27((Control)(object)textBox1, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1022779722) ^ 0x1B0A61BF;
					continue;
				case 30u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label3);
					num = ((int)num2 * -1750984521) ^ -2009396666;
					continue;
				case 29u:
					Form2.smethod_22((Control)(object)label3, new Point(47, 177));
					num = ((int)num2 * -214119634) ^ 0x43A94678;
					continue;
				case 28u:
					num = ((int)num2 * -1018850854) ^ -1701209057;
					continue;
				case 27u:
					Form2.smethod_24((Control)(object)label1, new Size(35, 13));
					Form2.smethod_25((Control)(object)label1, 0);
					num = ((int)num2 * -1446726373) ^ 0x660494D8;
					continue;
				case 26u:
					Form2.smethod_41((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
					num = ((int)num2 * -1373349659) ^ -437250966;
					continue;
				case 25u:
					num = ((int)num2 * -1357589788) ^ 0x41AFDA60;
					continue;
				case 24u:
					num = (int)(num2 * 212630836) ^ -639239226;
					continue;
				case 23u:
					Form2.smethod_23((Control)(object)label3, "label3");
					num = (int)(num2 * 2090674579) ^ -2045341114;
					continue;
				case 22u:
					num = (int)((num2 * 136273072) ^ 0x6FAF6532);
					continue;
				case 20u:
					Form2.smethod_1((Control)(object)this, "Жеребьёвка");
					num = (int)(num2 * 1500687184) ^ -1921416974;
					continue;
				case 19u:
					num = ((int)num2 * -528176724) ^ -1647624785;
					continue;
				case 18u:
					num = (int)(num2 * 166872414) ^ -1432815737;
					continue;
				case 17u:
					Form2.smethod_24((Control)(object)label3, new Size(0, 13));
					num = ((int)num2 * -2086089913) ^ 0x405258F8;
					continue;
				case 16u:
					Form2.smethod_36((Form)(object)this, (FormBorderStyle)1);
					num = (int)((num2 * 1636247123) ^ 0x28F12F20);
					continue;
				case 15u:
					num = (int)(num2 * 1654109082) ^ -1217606822;
					continue;
				case 14u:
					Form2.smethod_24((Control)(object)button1, new Size(73, 23));
					num = (int)(num2 * 1389689201) ^ -304538873;
					continue;
				case 13u:
					num = ((int)num2 * -1852855729) ^ 0x29385C1;
					continue;
				case 12u:
					Form2.smethod_40((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1303608435) ^ -898715479;
					continue;
				case 11u:
					Form2.smethod_25((Control)(object)label3, 4);
					num = (int)((num2 * 796335414) ^ 0x6374A98A);
					continue;
				case 10u:
					Form2.smethod_37((Form)(object)this, bool_0: false);
					num = (int)((num2 * 532373408) ^ 0x6EBC3A19);
					continue;
				case 9u:
					num = ((int)num2 * -1340615051) ^ -861013170;
					continue;
				case 8u:
					num = (int)(num2 * 85042635) ^ -1598324763;
					continue;
				case 7u:
					num = ((int)num2 * -2057657927) ^ 0x5DC6C849;
					continue;
				case 5u:
					Form2.smethod_23((Control)(object)label1, "label1");
					num = (int)((num2 * 1212623927) ^ 0x585A2387);
					continue;
				case 4u:
					label2 = Form2.smethod_17();
					num = (int)((num2 * 449562418) ^ 0x76E8196F);
					continue;
				case 3u:
					num = ((int)num2 * -503633213) ^ 0x313DC96A;
					continue;
				case 2u:
					Form2.smethod_21((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -687435261) ^ -1176021956;
					continue;
				case 1u:
					Form2.smethod_31((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -1758706295) ^ 0x206DA769;
					continue;
				case 0u:
					Form2.smethod_38((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1024631476) ^ -152345730;
					continue;
				case 6u:
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
