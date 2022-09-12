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
			int num = -785945424;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9506489Fu) % 3u)
				{
				case 1u:
					goto IL_0021;
				case 2u:
					break;
				default:
					Form2.smethod_1((Control)(object)label1, "Введите любое число от 0 до 9 включительно.\nВаш соперник уже загадал число (N) из этого\nже диапазона. Если сумма ваших чисел будет\nчетным числом, то первым ход делаете Вы,\nиначе - ваш соперник Компьютер!");
					return;
				}
				break;
				IL_0021:
				InitializeComponent();
				num = ((int)num2 * -1200516142) ^ 0x7AB22DC1;
			}
		}
	}

	private void Form2_FormClosed(object sender, FormClosedEventArgs e)
	{
		Form2.smethod_3((Control)(object)Form2.smethod_2((Form)(object)this), bool_0: true);
		while (true)
		{
			int num = 2147262233;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x69E1A0BFu) % 3u)
				{
				case 1u:
					goto IL_000e;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_000e:
				num = (int)(num2 * 1917726312) ^ -1251112745;
			}
		}
	}

	private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		bool flag = !char.IsDigit(Form2.smethod_4(e));
		bool flag2 = default(bool);
		while (true)
		{
			int num = -1796901082;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8B73B979u) % 12u)
				{
				case 11u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = -576997046;
						num6 = -576997046;
					}
					else
					{
						num5 = -929042896;
						num6 = -929042896;
					}
					num = num5 ^ (int)(num2 * 80922887);
					continue;
				}
				case 10u:
					num = ((int)num2 * -1408489353) ^ -2045705964;
					continue;
				case 9u:
				{
					int num3;
					int num4;
					if (flag2)
					{
						num3 = 87173520;
						num4 = 87173520;
					}
					else
					{
						num3 = 1682771931;
						num4 = 1682771931;
					}
					num = num3 ^ ((int)num2 * -496586648);
					continue;
				}
				case 8u:
					Form2.smethod_5(e, bool_0: true);
					num = ((int)num2 * -1160427572) ^ -286042907;
					continue;
				case 6u:
					Form2.smethod_1((Control)(object)textBox1, "");
					num = -1586242668;
					continue;
				case 5u:
					num = (int)(num2 * 2121213756) ^ -1964189826;
					continue;
				case 4u:
					num = ((int)num2 * -1081409860) ^ 0x395A5B23;
					continue;
				case 3u:
					flag2 = Form2.smethod_4(e) == '\r';
					num = -843109248;
					continue;
				case 1u:
					Button1_Click(this, Form2.smethod_6());
					num = (int)((num2 * 896558709) ^ 0x18A0F36C);
					continue;
				case 0u:
					num = (int)(num2 * 608940290) ^ -1282017101;
					continue;
				default:
					return;
				case 7u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		bool flag = Form2.smethod_8(Form2.smethod_7((Control)(object)textBox1), "");
		bool flag3 = default(bool);
		int num5 = default(int);
		int num4 = default(int);
		int num3 = default(int);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -981255651;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC48326E9u) % 32u)
				{
				case 31u:
					Form2.smethod_1((Control)(object)label3, "Первым ход делает Компьютер.");
					num = (int)(num2 * 1498786698) ^ -1213010664;
					continue;
				case 30u:
					num = (int)(num2 * 371420817) ^ -996027868;
					continue;
				case 29u:
					num = (int)(num2 * 1380783912) ^ -666000902;
					continue;
				case 28u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).StartGame();
					Form2.smethod_15((Form)(object)this);
					num = ((int)num2 * -1386168955) ^ 0x5EF281C8;
					continue;
				case 27u:
					num = -748245343;
					continue;
				case 26u:
					num = (int)((num2 * 1072855107) ^ 0x13248CE6);
					continue;
				case 25u:
					(Form2.smethod_2((Form)(object)this) as Form3).Button_Continue();
					Form2.smethod_14(Form2.smethod_11(Form2.smethod_2((Form)(object)this)));
					num = ((int)num2 * -1195199416) ^ -155049191;
					continue;
				case 24u:
					num = ((int)num2 * -1505900367) ^ -292923987;
					continue;
				case 23u:
					flag3 = num5 > 1;
					num = (int)(num2 * 737000955) ^ -379663409;
					continue;
				case 22u:
					num = (int)(num2 * 456482987) ^ -673036136;
					continue;
				case 21u:
					num = -457759654;
					continue;
				case 20u:
				{
					int num12;
					int num13;
					if (!flag)
					{
						num12 = 499178073;
						num13 = 499178073;
					}
					else
					{
						num12 = 1123901077;
						num13 = 1123901077;
					}
					num = num12 ^ (int)(num2 * 1783420438);
					continue;
				}
				case 19u:
				{
					Form control_2 = Form2.smethod_2((Form)(object)this);
					num5 = Form2.smethod_12((Control)(object)control_2) - 1;
					Form2.smethod_13((Control)(object)control_2, num5);
					num = -1217647362;
					continue;
				}
				case 18u:
					num = ((int)num2 * -2084838999) ^ 0x5A6C2E5;
					continue;
				case 17u:
					this.flag = false;
					num = -571969946;
					continue;
				case 16u:
					num = -158822537;
					continue;
				case 15u:
					num = ((int)num2 * -2040251306) ^ 0x5439ED78;
					continue;
				case 14u:
				{
					int num10;
					int num11;
					if ((num4 + num3) % 2 != 0)
					{
						num10 = 183301461;
						num11 = 183301461;
					}
					else
					{
						num10 = 499223931;
						num11 = 499223931;
					}
					num = num10 ^ ((int)num2 * -554085864);
					continue;
				}
				case 13u:
					num = ((int)num2 * -1014041021) ^ 0x2C928933;
					continue;
				case 12u:
					num = -1586414922;
					continue;
				case 11u:
				{
					int num8;
					int num9;
					if (flag3)
					{
						num8 = 1876048890;
						num9 = 1876048890;
					}
					else
					{
						num8 = 652279190;
						num9 = 652279190;
					}
					num = num8 ^ ((int)num2 * -1071045262);
					continue;
				}
				case 10u:
					flag2 = this.flag;
					num = ((int)num2 * -1708704328) ^ -1317681412;
					continue;
				case 9u:
					num = (int)((num2 * 557183700) ^ 0x6EC9F24C);
					continue;
				case 7u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = false;
					num = (int)((num2 * 839431108) ^ 0x25EF21E4);
					continue;
				case 5u:
				{
					int num6;
					int num7;
					if (flag2)
					{
						num6 = 1086208042;
						num7 = 1086208042;
					}
					else
					{
						num6 = 861263372;
						num7 = 861263372;
					}
					num = num6 ^ ((int)num2 * -1863957711);
					continue;
				}
				case 4u:
					num = ((int)num2 * -1550936389) ^ 0x68AC12EF;
					continue;
				case 3u:
					num4 = int.Parse(Form2.smethod_7((Control)(object)textBox1));
					num = (int)((num2 * 1349198256) ^ 0x2DF7DAF9);
					continue;
				case 2u:
					Form2.smethod_1((Control)(object)label3, "Поздравляем! Ваш ход первый.");
					num = (int)((num2 * 1294111965) ^ 0x31DD8489);
					continue;
				case 1u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = true;
					num = (int)(num2 * 2108428107) ^ -690872181;
					continue;
				case 0u:
				{
					num3 = Form2.smethod_9(rnd, 10);
					Label control_ = label2;
					string string_ = num3.ToString();
					num5 = num4 + num3;
					Form2.smethod_1((Control)(object)control_, Form2.smethod_10("+", string_, "=", num5.ToString()));
					num = (int)((num2 * 796338741) ^ 0x312BED1B);
					continue;
				}
				default:
					return;
				case 6u:
					break;
				case 8u:
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
			int num = 1506030443;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x48D22414u) % 6u)
				{
				case 5u:
					if (components != null)
					{
						num = 1626532303;
						num3 = 1626532303;
						continue;
					}
					goto IL_0011;
				case 4u:
					Form2.smethod_16((IDisposable)components);
					num = (int)((num2 * 1959891524) ^ 0x4898C0EE);
					continue;
				case 3u:
					if (disposing)
					{
						num = ((int)num2 * -2020485902) ^ -1501202367;
						continue;
					}
					goto IL_0011;
				case 1u:
					num = ((int)num2 * -1178790747) ^ -69434031;
					continue;
				case 0u:
					break;
				default:
					{
						((Form)this).Dispose(disposing);
						return;
					}
					IL_0011:
					num = 367831782;
					num3 = 367831782;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Expected O, but got Unknown
		while (true)
		{
			int num = -136043653;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE3153434u) % 58u)
				{
				case 57u:
					Form2.smethod_25((Control)(object)label2, 2);
					num = ((int)num2 * -1329896839) ^ 0x6D509797;
					continue;
				case 56u:
					num = ((int)num2 * -285319872) ^ 0x4C2D10AE;
					continue;
				case 55u:
					Form2.smethod_36((Form)(object)this, (FormBorderStyle)1);
					num = (int)(num2 * 1873047866) ^ -1674984282;
					continue;
				case 54u:
					num = (int)(num2 * 233203613) ^ -1747384582;
					continue;
				case 53u:
					Form2.smethod_21((Control)(object)label2, bool_0: true);
					num = ((int)num2 * -611409059) ^ -611874140;
					continue;
				case 52u:
					Form2.smethod_25((Control)(object)textBox1, 1);
					num = ((int)num2 * -933915360) ^ -886908529;
					continue;
				case 51u:
					num = (int)(num2 * 1446864472) ^ -1599442660;
					continue;
				case 50u:
					Form2.smethod_25((Control)(object)label1, 0);
					num = ((int)num2 * -1550458801) ^ 0x3D8218E5;
					continue;
				case 49u:
					Form2.smethod_22((Control)(object)label3, new Point(47, 177));
					num = ((int)num2 * -616154769) ^ 0x7D2C108;
					continue;
				case 48u:
					Form2.smethod_27((Control)(object)label2, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1783592804) ^ 0x6C00FBCF;
					continue;
				case 47u:
					button1 = Form2.smethod_19();
					num = (int)(num2 * 41252629) ^ -1880149802;
					continue;
				case 46u:
					Form2.smethod_25((Control)(object)label3, 4);
					num = (int)((num2 * 1158127118) ^ 0x1F7E429E);
					continue;
				case 45u:
					Form2.smethod_38((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1562337676) ^ 0x591AA125;
					continue;
				case 44u:
					num = (int)(num2 * 448399903) ^ -732414591;
					continue;
				case 43u:
					Form2.smethod_23((Control)(object)label2, "label2");
					num = (int)((num2 * 1789477882) ^ 0x656E8846);
					continue;
				case 42u:
					Form2.smethod_24((Control)(object)label2, new Size(188, 73));
					num = ((int)num2 * -1036233614) ^ 0x4DDA1B5F;
					continue;
				case 41u:
					Form2.smethod_1((Control)(object)label1, "label1");
					num = (int)((num2 * 530862707) ^ 0x34DD646);
					continue;
				case 40u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label3);
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -837138808) ^ -221813217;
					continue;
				case 39u:
					Form2.smethod_28((Control)(object)textBox1, new KeyPressEventHandler(TextBox1_KeyPress));
					num = ((int)num2 * -235314731) ^ -1478010593;
					continue;
				case 38u:
					Form2.smethod_31((ContainerControl)(object)this, new SizeF(6f, 13f));
					Form2.smethod_32((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -721116156) ^ -911257560;
					continue;
				case 37u:
					num = ((int)num2 * -1481431620) ^ 0x6B8E0F19;
					continue;
				case 36u:
					Form2.smethod_22((Control)(object)label2, new Point(53, 89));
					num = ((int)num2 * -1752079639) ^ 0x4237395B;
					continue;
				case 35u:
					Form2.smethod_24((Control)(object)label3, new Size(0, 13));
					num = (int)(num2 * 1973281724) ^ -400805157;
					continue;
				case 34u:
					Form2.smethod_21((Control)(object)label1, bool_0: true);
					num = (int)((num2 * 1796293703) ^ 0x72DDA94B);
					continue;
				case 33u:
					Form2.smethod_24((Control)(object)button1, new Size(73, 23));
					num = (int)((num2 * 746164359) ^ 0xB4A5417);
					continue;
				case 32u:
					Form2.smethod_37((Form)(object)this, bool_0: false);
					num = (int)((num2 * 1443390196) ^ 0x4F6349E3);
					continue;
				case 31u:
					num = (int)((num2 * 977342804) ^ 0x3B1218C2);
					continue;
				case 30u:
					Form2.smethod_1((Control)(object)label2, "+N=?");
					Form2.smethod_22((Control)(object)button1, new Point(86, 193));
					num = ((int)num2 * -562438358) ^ -1073732772;
					continue;
				case 29u:
					num = (int)((num2 * 708097716) ^ 0x6464A010);
					continue;
				case 28u:
					Form2.smethod_23((Control)(object)label3, "label3");
					num = ((int)num2 * -1312678126) ^ -699898493;
					continue;
				case 27u:
					num = ((int)num2 * -2077453037) ^ 0x41F81925;
					continue;
				case 26u:
					num = (int)((num2 * 1248398422) ^ 0x7175ACD2);
					continue;
				case 25u:
					Form2.smethod_41((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
					num = (int)(num2 * 1628239716) ^ -982512261;
					continue;
				case 23u:
					num = (int)((num2 * 1420924379) ^ 0x733A19EB);
					continue;
				case 22u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -605541169) ^ -941607285;
					continue;
				case 21u:
					Form2.smethod_22((Control)(object)label1, new Point(10, 10));
					num = ((int)num2 * -955086457) ^ 0x6009C15F;
					continue;
				case 20u:
					Form2.smethod_22((Control)(object)textBox1, new Point(24, 86));
					num = (int)(num2 * 1085528044) ^ -1299278294;
					continue;
				case 19u:
					Form2.smethod_39((Control)(object)this, "Form2");
					num = (int)(num2 * 1048031462) ^ -1692271390;
					continue;
				case 18u:
					Form2.smethod_33((Form)(object)this, new Size(255, 224));
					num = (int)((num2 * 151198756) ^ 0x5919FC6);
					continue;
				case 17u:
					Form2.smethod_30((Control)(object)button1, (EventHandler)Button1_Click);
					Form2.smethod_21((Control)(object)label3, bool_0: true);
					num = (int)(num2 * 1878741870) ^ -1623532455;
					continue;
				case 16u:
					Form2.smethod_25((Control)(object)button1, 3);
					num = ((int)num2 * -1760940988) ^ 0x48E69D84;
					continue;
				case 15u:
					num = ((int)num2 * -194890908) ^ 0x748C6E52;
					continue;
				case 14u:
					Form2.smethod_23((Control)(object)button1, "button1");
					num = (int)(num2 * 65263631) ^ -41743357;
					continue;
				case 13u:
					num = (int)(num2 * 471233546) ^ -892958437;
					continue;
				case 12u:
					num = ((int)num2 * -833459083) ^ -857561963;
					continue;
				case 10u:
					Form2.smethod_23((Control)(object)textBox1, "textBox1");
					Form2.smethod_24((Control)(object)textBox1, new Size(42, 80));
					num = ((int)num2 * -2018323025) ^ 0x4CB8A7;
					continue;
				case 9u:
					label1 = Form2.smethod_17();
					textBox1 = Form2.smethod_18();
					num = (int)(num2 * 1635546046) ^ -1185812650;
					continue;
				case 8u:
					label2 = Form2.smethod_17();
					num = (int)(num2 * 1976005513) ^ -1895646435;
					continue;
				case 7u:
					Form2.smethod_27((Control)(object)textBox1, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 789364002) ^ 0x7EE34BF2);
					continue;
				case 6u:
					Form2.smethod_23((Control)(object)label1, "label1");
					num = ((int)num2 * -651734777) ^ 0x2DCD9C7A;
					continue;
				case 5u:
					label3 = Form2.smethod_17();
					num = ((int)num2 * -414839033) ^ -977640676;
					continue;
				case 4u:
					Form2.smethod_24((Control)(object)label1, new Size(35, 13));
					num = (int)(num2 * 1856166719) ^ -688964743;
					continue;
				case 3u:
					Form2.smethod_20((Control)(object)this);
					num = ((int)num2 * -1112161255) ^ -45028547;
					continue;
				case 2u:
					Form2.smethod_1((Control)(object)button1, "OK");
					Form2.smethod_29((ButtonBase)(object)button1, bool_0: true);
					num = (int)((num2 * 882066145) ^ 0x4137A904);
					continue;
				case 1u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)textBox1);
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label2);
					num = (int)((num2 * 1837732164) ^ 0x35000362);
					continue;
				case 0u:
					Form2.smethod_40((Form)(object)this, bool_0: false);
					Form2.smethod_1((Control)(object)this, "Жеребьёвка");
					num = ((int)num2 * -2137094953) ^ -1880812981;
					continue;
				case 24u:
					break;
				default:
					Form2.smethod_42((Control)(object)this, bool_0: false);
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
