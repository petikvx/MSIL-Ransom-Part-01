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
			int num = -851798761;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x81DC18D0u) % 10u)
				{
				case 9u:
					Button1_Click(this, Form2.smethod_6());
					num = ((int)num2 * -470636784) ^ 0x3936A5C3;
					continue;
				case 8u:
				{
					int num5;
					if (Form2.smethod_4(e) == '\r')
					{
						num = -1577966105;
						num5 = -1577966105;
					}
					else
					{
						num = -152694349;
						num5 = -152694349;
					}
					continue;
				}
				case 7u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1630450975;
						num4 = 1630450975;
					}
					else
					{
						num3 = 528791241;
						num4 = 528791241;
					}
					num = num3 ^ ((int)num2 * -1023743357);
					continue;
				}
				case 4u:
					num = (int)((num2 * 1081642649) ^ 0x37AFFC9A);
					continue;
				case 3u:
					num = (int)((num2 * 939621639) ^ 0x1B69BD9F);
					continue;
				case 2u:
					Form2.smethod_5(e, bool_0: true);
					num = (int)(num2 * 1363656474) ^ -1057424587;
					continue;
				case 1u:
					flag = !char.IsDigit(Form2.smethod_4(e));
					num = (int)(num2 * 1225264066) ^ -1794263469;
					continue;
				case 0u:
					Form2.smethod_1((Control)(object)textBox1, "");
					num = -652228362;
					continue;
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
		bool flag3 = default(bool);
		int num7 = default(int);
		bool flag2 = default(bool);
		bool flag = default(bool);
		int num6 = default(int);
		int num5 = default(int);
		while (true)
		{
			int num = -1338248372;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC7E7986Bu) % 31u)
				{
				case 30u:
					num = ((int)num2 * -2008042869) ^ 0x5BEA3718;
					continue;
				case 29u:
				{
					int num12;
					int num13;
					if (!flag3)
					{
						num12 = -2067939571;
						num13 = -2067939571;
					}
					else
					{
						num12 = -1895199919;
						num13 = -1895199919;
					}
					num = num12 ^ ((int)num2 * -559635995);
					continue;
				}
				case 28u:
					this.flag = false;
					num = -1264532379;
					continue;
				case 27u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).StartGame();
					num = (int)(num2 * 1615314176) ^ -1611698527;
					continue;
				case 26u:
					num = ((int)num2 * -1213165200) ^ -1894615169;
					continue;
				case 25u:
				{
					Form control_2 = Form2.smethod_2((Form)(object)this);
					num7 = Form2.smethod_12((Control)(object)control_2) - 1;
					Form2.smethod_13((Control)(object)control_2, num7);
					num = -207113880;
					continue;
				}
				case 24u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = false;
					num = (int)(num2 * 1459912399) ^ -1653502833;
					continue;
				case 23u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = true;
					num = (int)((num2 * 1669506401) ^ 0x10FBC590);
					continue;
				case 22u:
					Form2.smethod_14(Form2.smethod_11(Form2.smethod_2((Form)(object)this)));
					num = (int)((num2 * 1289754298) ^ 0x3ECE7343);
					continue;
				case 21u:
					num = ((int)num2 * -491833515) ^ 0x2FBB3AB3;
					continue;
				case 20u:
				{
					int num10;
					int num11;
					if (num7 > 1)
					{
						num10 = -249547345;
						num11 = -249547345;
					}
					else
					{
						num10 = -951607320;
						num11 = -951607320;
					}
					num = num10 ^ ((int)num2 * -277622951);
					continue;
				}
				case 19u:
					num = ((int)num2 * -1325397146) ^ 0x53F72C48;
					continue;
				case 18u:
				{
					int num8;
					int num9;
					if (!flag2)
					{
						num8 = 607599471;
						num9 = 607599471;
					}
					else
					{
						num8 = 577499465;
						num9 = 577499465;
					}
					num = num8 ^ (int)(num2 * 1983766399);
					continue;
				}
				case 17u:
					flag = this.flag;
					num = (int)(num2 * 1152233326) ^ -1454722557;
					continue;
				case 16u:
					num = -1054515568;
					continue;
				case 15u:
					flag3 = Form2.smethod_8(Form2.smethod_7((Control)(object)textBox1), "");
					num = ((int)num2 * -1625562371) ^ 0x5279E1B3;
					continue;
				case 14u:
					num = -1054515568;
					continue;
				case 13u:
					num = ((int)num2 * -1872872134) ^ -1052062771;
					continue;
				case 12u:
					num = -1996181454;
					continue;
				case 11u:
					num6 = int.Parse(Form2.smethod_7((Control)(object)textBox1));
					num5 = Form2.smethod_9(rnd, 10);
					num = ((int)num2 * -1195043321) ^ 0x1D45719C;
					continue;
				case 10u:
					Form2.smethod_1((Control)(object)label3, "Первым ход делает Компьютер.");
					num = -748121900;
					continue;
				case 9u:
					Form2.smethod_1((Control)(object)label3, "Поздравляем! Ваш ход первый.");
					num = (int)(num2 * 570318295) ^ -761328510;
					continue;
				case 8u:
					flag2 = (num6 + num5) % 2 == 0;
					num = ((int)num2 * -680220897) ^ 0x73BBBB39;
					continue;
				case 7u:
				{
					Label control_ = label2;
					string string_ = num5.ToString();
					num7 = num6 + num5;
					Form2.smethod_1((Control)(object)control_, Form2.smethod_10("+", string_, "=", num7.ToString()));
					num = ((int)num2 * -1845208387) ^ 0x6F88412A;
					continue;
				}
				case 6u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -370743842;
						num4 = -370743842;
					}
					else
					{
						num3 = -160945951;
						num4 = -160945951;
					}
					num = num3 ^ ((int)num2 * -1935747393);
					continue;
				}
				case 5u:
					num = ((int)num2 * -2035573498) ^ -2111421554;
					continue;
				case 4u:
					num = ((int)num2 * -1167557237) ^ -2062278176;
					continue;
				case 2u:
					(Form2.smethod_2((Form)(object)this) as Form3).Button_Continue();
					num = ((int)num2 * -1321855377) ^ 0xBD9D9D7;
					continue;
				case 1u:
					Form2.smethod_15((Form)(object)this);
					num = (int)((num2 * 505169470) ^ 0x5DBCE81B);
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

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			goto IL_0064;
		}
		int num = 0;
		goto IL_009f;
		IL_009f:
		bool flag = (byte)num != 0;
		int num2 = -2115088329;
		goto IL_0069;
		IL_0064:
		num2 = -903556482;
		goto IL_0069;
		IL_0069:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0xD1C056D1u) % 7u)
			{
			case 6u:
			{
				int num4;
				int num5;
				if (flag)
				{
					num4 = -810153176;
					num5 = -810153176;
				}
				else
				{
					num4 = -1707742773;
					num5 = -1707742773;
				}
				num2 = num4 ^ (int)(num3 * 1793882157);
				continue;
			}
			case 5u:
				num2 = (int)((num3 * 1997107764) ^ 0x17A1A409);
				continue;
			case 2u:
				Form2.smethod_16((IDisposable)components);
				num2 = (int)((num3 * 1869580614) ^ 0x4187401D);
				continue;
			case 1u:
				((Form)this).Dispose(disposing);
				num2 = -2111622303;
				continue;
			case 0u:
				break;
			default:
				return;
			case 3u:
				goto IL_0096;
			case 4u:
				return;
			}
			break;
		}
		goto IL_0064;
		IL_0096:
		num = ((components != null) ? 1 : 0);
		goto IL_009f;
	}

	private void InitializeComponent()
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		label1 = Form2.smethod_17();
		textBox1 = Form2.smethod_18();
		label2 = Form2.smethod_17();
		button1 = Form2.smethod_19();
		while (true)
		{
			int num = 1152876277;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6EF2B144u) % 61u)
				{
				case 60u:
					num = (int)(num2 * 595492845) ^ -1812677748;
					continue;
				case 59u:
					Form2.smethod_23((Control)(object)button1, "button1");
					num = (int)(num2 * 1997889615) ^ -1999043722;
					continue;
				case 58u:
					num = ((int)num2 * -1728481749) ^ 0x1FEABA8D;
					continue;
				case 57u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label3);
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)button1);
					num = (int)((num2 * 1718674131) ^ 0xA392BBF);
					continue;
				case 55u:
					Form2.smethod_23((Control)(object)label2, "label2");
					num = (int)((num2 * 337220923) ^ 0x34868D2);
					continue;
				case 54u:
					Form2.smethod_25((Control)(object)textBox1, 1);
					Form2.smethod_28((Control)(object)textBox1, new KeyPressEventHandler(TextBox1_KeyPress));
					num = ((int)num2 * -2059631935) ^ -282295519;
					continue;
				case 53u:
					Form2.smethod_41((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
					num = (int)((num2 * 2010633046) ^ 0x7B591CB3);
					continue;
				case 52u:
					num = ((int)num2 * -1186517053) ^ -1527595366;
					continue;
				case 51u:
					Form2.smethod_22((Control)(object)textBox1, new Point(24, 86));
					num = ((int)num2 * -412984934) ^ -1846955873;
					continue;
				case 50u:
					Form2.smethod_36((Form)(object)this, (FormBorderStyle)1);
					num = (int)(num2 * 1203139946) ^ -200264770;
					continue;
				case 49u:
					Form2.smethod_40((Form)(object)this, bool_0: false);
					Form2.smethod_1((Control)(object)this, "Жеребьёвка");
					num = (int)((num2 * 48432318) ^ 0x294DBCB4);
					continue;
				case 48u:
					Form2.smethod_23((Control)(object)label3, "label3");
					num = (int)((num2 * 504497579) ^ 0x3FB2D704);
					continue;
				case 47u:
					Form2.smethod_42((Control)(object)this, bool_0: false);
					num = ((int)num2 * -268803085) ^ 0xDFBEC65;
					continue;
				case 46u:
					Form2.smethod_24((Control)(object)textBox1, new Size(42, 80));
					num = (int)(num2 * 1922244004) ^ -945390678;
					continue;
				case 45u:
					Form2.smethod_25((Control)(object)button1, 3);
					num = ((int)num2 * -1391872283) ^ -1590955693;
					continue;
				case 44u:
					Form2.smethod_43((Control)(object)this);
					num = (int)((num2 * 906040251) ^ 0x765B9590);
					continue;
				case 43u:
					Form2.smethod_39((Control)(object)this, "Form2");
					num = (int)(num2 * 1954744429) ^ -1059380835;
					continue;
				case 42u:
					num = ((int)num2 * -792545394) ^ 0x32F23C4A;
					continue;
				case 41u:
					Form2.smethod_27((Control)(object)label2, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -623987498) ^ -1911696283;
					continue;
				case 40u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -544936693) ^ -1159249026;
					continue;
				case 39u:
					num = ((int)num2 * -2086959476) ^ 0xC4C6452;
					continue;
				case 38u:
					Form2.smethod_22((Control)(object)label3, new Point(47, 177));
					num = (int)((num2 * 26666670) ^ 0x13E1D64B);
					continue;
				case 37u:
					num = ((int)num2 * -854723008) ^ -944717372;
					continue;
				case 36u:
					Form2.smethod_22((Control)(object)label2, new Point(53, 89));
					num = (int)((num2 * 1309885584) ^ 0x35A7601B);
					continue;
				case 35u:
					Form2.smethod_32((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -912435649) ^ -1212434492;
					continue;
				case 34u:
					num = ((int)num2 * -1047520425) ^ 0x3653BB1A;
					continue;
				case 33u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)textBox1);
					num = ((int)num2 * -1718389130) ^ 0x12E38CFE;
					continue;
				case 31u:
					Form2.smethod_24((Control)(object)label2, new Size(188, 73));
					num = (int)(num2 * 1918318957) ^ -185576873;
					continue;
				case 30u:
					num = ((int)num2 * -1853625952) ^ -1062186296;
					continue;
				case 29u:
					Form2.smethod_27((Control)(object)textBox1, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 888551208) ^ -1193717727;
					continue;
				case 28u:
					num = ((int)num2 * -1627390924) ^ 0x6D1B6800;
					continue;
				case 27u:
					Form2.smethod_21((Control)(object)label2, bool_0: true);
					num = (int)((num2 * 443548137) ^ 0x42A2DBFB);
					continue;
				case 26u:
					Form2.smethod_24((Control)(object)label3, new Size(0, 13));
					num = (int)((num2 * 651374624) ^ 0x3D719B63);
					continue;
				case 25u:
					Form2.smethod_37((Form)(object)this, bool_0: false);
					num = ((int)num2 * -271681453) ^ -1281842604;
					continue;
				case 24u:
					Form2.smethod_1((Control)(object)button1, "OK");
					Form2.smethod_29((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -1231158351) ^ 0x2DC700A1;
					continue;
				case 23u:
					Form2.smethod_38((Form)(object)this, bool_0: false);
					num = (int)((num2 * 338496066) ^ 0x3B9E4A1E);
					continue;
				case 22u:
					Form2.smethod_23((Control)(object)label1, "label1");
					Form2.smethod_24((Control)(object)label1, new Size(35, 13));
					num = ((int)num2 * -427307843) ^ -525478400;
					continue;
				case 21u:
					Form2.smethod_25((Control)(object)label3, 4);
					num = ((int)num2 * -2001250531) ^ 0x120398B8;
					continue;
				case 20u:
					Form2.smethod_24((Control)(object)button1, new Size(73, 23));
					num = ((int)num2 * -832041608) ^ 0x7823AD4D;
					continue;
				case 19u:
					Form2.smethod_31((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -1112813609) ^ -224963604;
					continue;
				case 18u:
					num = (int)((num2 * 431873403) ^ 0x1446564B);
					continue;
				case 17u:
					label3 = Form2.smethod_17();
					Form2.smethod_20((Control)(object)this);
					num = (int)((num2 * 2081551841) ^ 0x789F0323);
					continue;
				case 16u:
					Form2.smethod_21((Control)(object)label1, bool_0: true);
					Form2.smethod_22((Control)(object)label1, new Point(10, 10));
					num = (int)((num2 * 1370583230) ^ 0x798DB08C);
					continue;
				case 15u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label2);
					num = (int)((num2 * 94204479) ^ 0xA761706);
					continue;
				case 14u:
					num = ((int)num2 * -754866302) ^ 0x884B9EE;
					continue;
				case 13u:
					num = ((int)num2 * -737424485) ^ 0x36F95B38;
					continue;
				case 12u:
					Form2.smethod_25((Control)(object)label1, 0);
					num = ((int)num2 * -1340063635) ^ -1059225176;
					continue;
				case 11u:
					Form2.smethod_21((Control)(object)label3, bool_0: true);
					num = ((int)num2 * -748181683) ^ 0x3E846F9;
					continue;
				case 10u:
					Form2.smethod_1((Control)(object)label1, "label1");
					num = (int)(num2 * 2105524423) ^ -1489536580;
					continue;
				case 9u:
					num = ((int)num2 * -417544647) ^ -1704887558;
					continue;
				case 8u:
					Form2.smethod_30((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -1680224848) ^ 0x332235DE;
					continue;
				case 7u:
					num = ((int)num2 * -99556067) ^ -1974109425;
					continue;
				case 6u:
					Form2.smethod_23((Control)(object)textBox1, "textBox1");
					num = (int)(num2 * 1047210902) ^ -1636870295;
					continue;
				case 5u:
					Form2.smethod_22((Control)(object)button1, new Point(86, 193));
					num = ((int)num2 * -1938988943) ^ -422306722;
					continue;
				case 4u:
					num = ((int)num2 * -190507278) ^ -802779055;
					continue;
				case 3u:
					Form2.smethod_25((Control)(object)label2, 2);
					Form2.smethod_1((Control)(object)label2, "+N=?");
					num = ((int)num2 * -330526129) ^ 0x74AA98BF;
					continue;
				case 2u:
					num = (int)(num2 * 1486269557) ^ -115989348;
					continue;
				case 1u:
					Form2.smethod_33((Form)(object)this, new Size(255, 224));
					num = (int)((num2 * 1660476374) ^ 0x2E914162);
					continue;
				case 0u:
					num = (int)(num2 * 1520555980) ^ -19103596;
					continue;
				default:
					return;
				case 32u:
					break;
				case 56u:
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
