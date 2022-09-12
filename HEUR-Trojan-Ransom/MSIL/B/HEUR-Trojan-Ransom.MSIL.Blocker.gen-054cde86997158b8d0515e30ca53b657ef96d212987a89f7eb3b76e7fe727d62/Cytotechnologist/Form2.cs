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
			int num = -977516397;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE4A4EC17u) % 6u)
				{
				case 5u:
					num = ((int)num2 * -1870121304) ^ -1111712596;
					continue;
				case 3u:
					Form2.smethod_1((Control)(object)label1, "Введите любое число от 0 до 9 включительно.\nВаш соперник уже загадал число (N) из этого\nже диапазона. Если сумма ваших чисел будет\nчетным числом, то первым ход делаете Вы,\nиначе - ваш соперник Компьютер!");
					num = ((int)num2 * -1997647557) ^ 0x3027863D;
					continue;
				case 2u:
					InitializeComponent();
					num = ((int)num2 * -889616154) ^ 0x1E7E9890;
					continue;
				case 1u:
					num = (int)(num2 * 1026366412) ^ -1459454361;
					continue;
				default:
					return;
				case 0u:
					break;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	private void Form2_FormClosed(object sender, FormClosedEventArgs e)
	{
		Form2.smethod_3((Control)(object)Form2.smethod_2((Form)(object)this), bool_0: true);
		while (true)
		{
			int num = -308541781;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCE73A959u) % 3u)
				{
				case 1u:
					goto IL_000e;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_000e:
				num = (int)((num2 * 1292189457) ^ 0x6763B97F);
			}
		}
	}

	private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		while (true)
		{
			int num = -1716284801;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA9B420CFu) % 11u)
				{
				case 9u:
					num = (int)((num2 * 468663048) ^ 0x188C8EA5);
					continue;
				case 8u:
					num = ((int)num2 * -1525274841) ^ 0x7545164C;
					continue;
				case 6u:
					Form2.smethod_1((Control)(object)textBox1, "");
					num = -456278688;
					continue;
				case 5u:
				{
					int num5;
					if (Form2.smethod_4(e) != '\r')
					{
						num = -2126338136;
						num5 = -2126338136;
					}
					else
					{
						num = -133595151;
						num5 = -133595151;
					}
					continue;
				}
				case 4u:
					num = ((int)num2 * -1125148450) ^ 0x6B6D6B82;
					continue;
				case 3u:
					Form2.smethod_5(e, bool_0: true);
					num = (int)(num2 * 1233691977) ^ -1454188254;
					continue;
				case 2u:
					num = (int)((num2 * 1320180826) ^ 0x5F887BB5);
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (char.IsDigit(Form2.smethod_4(e)))
					{
						num3 = -495870881;
						num4 = -495870881;
					}
					else
					{
						num3 = -1021423521;
						num4 = -1021423521;
					}
					num = num3 ^ ((int)num2 * -1978325762);
					continue;
				}
				case 0u:
					Button1_Click(this, Form2.smethod_6());
					num = (int)((num2 * 74087253) ^ 0x7E46B6E2);
					continue;
				default:
					return;
				case 10u:
					break;
				case 7u:
					return;
				}
				break;
			}
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		bool flag4 = default(bool);
		int num3 = default(int);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		int num4 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 1785379122;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x753A6E82u) % 33u)
				{
				case 32u:
				{
					int num10;
					int num11;
					if (flag4)
					{
						num10 = 2016839301;
						num11 = 2016839301;
					}
					else
					{
						num10 = 1020213852;
						num11 = 1020213852;
					}
					num = num10 ^ ((int)num2 * -924860600);
					continue;
				}
				case 31u:
					num = ((int)num2 * -1463960604) ^ 0x27F93523;
					continue;
				case 30u:
					Form2.smethod_1((Control)(object)label3, "Поздравляем! Ваш ход первый.");
					num = (int)(num2 * 1610654141) ^ -1554687857;
					continue;
				case 29u:
					num3 = int.Parse(Form2.smethod_7((Control)(object)textBox1));
					num = (int)((num2 * 278804574) ^ 0x60CA537D);
					continue;
				case 28u:
				{
					int num8;
					int num9;
					if (flag2)
					{
						num8 = -994179943;
						num9 = -994179943;
					}
					else
					{
						num8 = -983511273;
						num9 = -983511273;
					}
					num = num8 ^ ((int)num2 * -38191104);
					continue;
				}
				case 27u:
				{
					int num12;
					int num13;
					if (!flag3)
					{
						num12 = -1090383206;
						num13 = -1090383206;
					}
					else
					{
						num12 = -1503437271;
						num13 = -1503437271;
					}
					num = num12 ^ (int)(num2 * 2087152472);
					continue;
				}
				case 26u:
					num4 = Form2.smethod_9(rnd, 10);
					Form2.smethod_1((Control)(object)label2, Form2.smethod_10("+", num4.ToString(), "=", (num3 + num4).ToString()));
					num = ((int)num2 * -1285190201) ^ 0x2031DEFC;
					continue;
				case 25u:
					num = 1900051835;
					continue;
				case 24u:
					(Form2.smethod_2((Form)(object)this) as Form3).Button_Continue();
					num = ((int)num2 * -414050836) ^ -218617330;
					continue;
				case 22u:
				{
					int num6;
					int num7;
					if (!flag)
					{
						num6 = 1697099726;
						num7 = 1697099726;
					}
					else
					{
						num6 = 25280170;
						num7 = 25280170;
					}
					num = num6 ^ ((int)num2 * -852201583);
					continue;
				}
				case 21u:
				{
					Form control_ = Form2.smethod_2((Form)(object)this);
					int num5 = Form2.smethod_12((Control)(object)control_) - 1;
					Form2.smethod_13((Control)(object)control_, num5);
					flag4 = num5 > 1;
					num = 94499516;
					continue;
				}
				case 20u:
					num = ((int)num2 * -1419798283) ^ -1646407050;
					continue;
				case 19u:
					this.flag = false;
					num = 1572867028;
					continue;
				case 18u:
					num = (int)((num2 * 11039725) ^ 0x354E327B);
					continue;
				case 17u:
					num = ((int)num2 * -1080091461) ^ 0x1D4B7283;
					continue;
				case 16u:
					Form2.smethod_1((Control)(object)label3, "Первым ход делает Компьютер.");
					num = (int)((num2 * 2070893041) ^ 0x28A710C6);
					continue;
				case 15u:
					Form2.smethod_15((Form)(object)this);
					num = ((int)num2 * -1942622192) ^ -1038315362;
					continue;
				case 14u:
					num = 76728025;
					continue;
				case 13u:
					flag3 = Form2.smethod_8(Form2.smethod_7((Control)(object)textBox1), "");
					num = (int)((num2 * 1796604901) ^ 0x2CED42D4);
					continue;
				case 12u:
					num = (int)(num2 * 304631736) ^ -638940461;
					continue;
				case 11u:
					flag2 = this.flag;
					num = (int)(num2 * 356258687) ^ -696704001;
					continue;
				case 10u:
					num = 678516840;
					continue;
				case 9u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).StartGame();
					num = (int)((num2 * 288740709) ^ 0x65537B86);
					continue;
				case 8u:
					Form2.smethod_14(Form2.smethod_11(Form2.smethod_2((Form)(object)this)));
					num = (int)(num2 * 1246419899) ^ -1857048903;
					continue;
				case 6u:
					num = ((int)num2 * -2077871657) ^ 0x6A8D3468;
					continue;
				case 5u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = true;
					num = (int)(num2 * 1694467388) ^ -247825288;
					continue;
				case 4u:
					num = 1710693770;
					continue;
				case 3u:
					num = ((int)num2 * -1107120486) ^ -676404497;
					continue;
				case 2u:
					num = ((int)num2 * -396021798) ^ 0x425BA833;
					continue;
				case 1u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = false;
					num = (int)((num2 * 1465566996) ^ 0x1E49939F);
					continue;
				case 0u:
					flag = (num3 + num4) % 2 == 0;
					num = (int)(num2 * 497053922) ^ -1143334224;
					continue;
				default:
					return;
				case 7u:
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
		if (!disposing)
		{
			goto IL_0009;
		}
		goto IL_004e;
		IL_004e:
		int num = -1720675556;
		goto IL_007f;
		IL_007f:
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x8BAF1532u) % 9u)
			{
			case 8u:
				num = (int)((num2 * 796995927) ^ 0xC3F9466);
				continue;
			case 6u:
				Form2.smethod_16((IDisposable)components);
				num = ((int)num2 * -57581692) ^ 0x5A9C7CD1;
				continue;
			case 5u:
				num = (int)((num2 * 363497478) ^ 0x51FD6BCF);
				continue;
			case 4u:
				break;
			case 3u:
				num = ((int)num2 * -2110286996) ^ 0x59FE4D56;
				continue;
			case 2u:
				num = (int)((num2 * 296726165) ^ 0x27D72726);
				continue;
			case 0u:
				((Form)this).Dispose(disposing);
				num = -818152107;
				continue;
			default:
				return;
			case 1u:
				goto IL_00b5;
			case 7u:
				return;
			}
			break;
			IL_00b5:
			if (components != null)
			{
				num = -2008525297;
				num3 = -2008525297;
				continue;
			}
			goto IL_0009;
		}
		goto IL_004e;
		IL_0009:
		num = -172047434;
		num3 = -172047434;
		goto IL_007f;
	}

	private void InitializeComponent()
	{
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected O, but got Unknown
		//IL_06c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d0: Expected O, but got Unknown
		while (true)
		{
			int num = 672132865;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2DC49188u) % 62u)
				{
				case 61u:
					label2 = Form2.smethod_17();
					num = (int)(num2 * 1707991443) ^ -583497053;
					continue;
				case 60u:
					Form2.smethod_43((Control)(object)this);
					num = ((int)num2 * -2032702217) ^ -491002168;
					continue;
				case 59u:
					Form2.smethod_32((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 963652711) ^ 0x19882EB);
					continue;
				case 58u:
					Form2.smethod_20((Control)(object)this);
					num = ((int)num2 * -249432017) ^ 0x79FCFC69;
					continue;
				case 57u:
					Form2.smethod_25((Control)(object)label3, 4);
					Form2.smethod_31((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -1381639696) ^ -997903531;
					continue;
				case 56u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label2);
					num = (int)((num2 * 710596117) ^ 0x7CE51C7E);
					continue;
				case 55u:
					num = (int)((num2 * 1015896636) ^ 0x5181F7D);
					continue;
				case 54u:
					num = (int)(num2 * 2117654481) ^ -2004821952;
					continue;
				case 53u:
					Form2.smethod_25((Control)(object)button1, 3);
					num = (int)(num2 * 629161263) ^ -645872756;
					continue;
				case 52u:
					Form2.smethod_23((Control)(object)label3, "label3");
					num = (int)(num2 * 1255306281) ^ -1556742786;
					continue;
				case 51u:
					Form2.smethod_22((Control)(object)button1, new Point(86, 193));
					num = ((int)num2 * -1352725199) ^ -1237303960;
					continue;
				case 50u:
					Form2.smethod_1((Control)(object)label2, "+N=?");
					num = (int)((num2 * 1235720788) ^ 0x4CDE81DD);
					continue;
				case 49u:
					num = (int)((num2 * 57033591) ^ 0x49A2DD9F);
					continue;
				case 48u:
					num = (int)((num2 * 776885844) ^ 0x314FC248);
					continue;
				case 47u:
					num = ((int)num2 * -160871) ^ -759601945;
					continue;
				case 46u:
					Form2.smethod_25((Control)(object)label2, 2);
					num = ((int)num2 * -1122031366) ^ 0x5E174A20;
					continue;
				case 45u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)textBox1);
					num = (int)(num2 * 480668457) ^ -373922923;
					continue;
				case 44u:
					Form2.smethod_33((Form)(object)this, new Size(255, 224));
					num = ((int)num2 * -1608957928) ^ -958181680;
					continue;
				case 43u:
					Form2.smethod_30((Control)(object)button1, (EventHandler)Button1_Click);
					Form2.smethod_21((Control)(object)label3, bool_0: true);
					num = (int)(num2 * 1960915154) ^ -14040914;
					continue;
				case 42u:
					num = ((int)num2 * -1762672051) ^ 0x1F4DD563;
					continue;
				case 41u:
					num = ((int)num2 * -810048398) ^ 0x31284411;
					continue;
				case 40u:
					num = ((int)num2 * -935898291) ^ -351675292;
					continue;
				case 39u:
					Form2.smethod_24((Control)(object)button1, new Size(73, 23));
					num = ((int)num2 * -321320364) ^ -1305458477;
					continue;
				case 38u:
					num = (int)((num2 * 47079358) ^ 0x40B054F6);
					continue;
				case 37u:
					Form2.smethod_23((Control)(object)textBox1, "textBox1");
					num = (int)((num2 * 1309772413) ^ 0x5A8D13FD);
					continue;
				case 36u:
					Form2.smethod_41((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
					num = ((int)num2 * -2073139701) ^ -2093955432;
					continue;
				case 35u:
					num = ((int)num2 * -963261208) ^ 0x7EDCA92F;
					continue;
				case 34u:
					textBox1 = Form2.smethod_18();
					num = ((int)num2 * -42908184) ^ 0x3D5D3273;
					continue;
				case 33u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label3);
					num = ((int)num2 * -152218769) ^ -174674614;
					continue;
				case 32u:
					Form2.smethod_22((Control)(object)textBox1, new Point(24, 86));
					num = ((int)num2 * -1444855719) ^ -1295527505;
					continue;
				case 31u:
					num = ((int)num2 * -2030260179) ^ -190131222;
					continue;
				case 30u:
					num = ((int)num2 * -1185939857) ^ -1793541747;
					continue;
				case 29u:
					num = (int)(num2 * 963533011) ^ -717706914;
					continue;
				case 28u:
					Form2.smethod_24((Control)(object)textBox1, new Size(42, 80));
					Form2.smethod_25((Control)(object)textBox1, 1);
					num = ((int)num2 * -160515738) ^ 0x33BF0F58;
					continue;
				case 27u:
					Form2.smethod_22((Control)(object)label2, new Point(53, 89));
					num = (int)((num2 * 1245053682) ^ 0x40120CA3);
					continue;
				case 26u:
					num = (int)(num2 * 246035551) ^ -849261018;
					continue;
				case 25u:
					Form2.smethod_1((Control)(object)button1, "OK");
					num = ((int)num2 * -225486441) ^ -1324441982;
					continue;
				case 24u:
					button1 = Form2.smethod_19();
					label3 = Form2.smethod_17();
					num = (int)((num2 * 2037816883) ^ 0x1775F50A);
					continue;
				case 23u:
					Form2.smethod_23((Control)(object)label1, "label1");
					Form2.smethod_24((Control)(object)label1, new Size(35, 13));
					Form2.smethod_25((Control)(object)label1, 0);
					Form2.smethod_1((Control)(object)label1, "label1");
					Form2.smethod_27((Control)(object)textBox1, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -2048611224) ^ -816859927;
					continue;
				case 22u:
					Form2.smethod_39((Control)(object)this, "Form2");
					num = ((int)num2 * -1287605682) ^ 0x122D1D4C;
					continue;
				case 21u:
					Form2.smethod_1((Control)(object)this, "Жеребьёвка");
					num = (int)((num2 * 628834573) ^ 0x7378737);
					continue;
				case 20u:
					Form2.smethod_24((Control)(object)label3, new Size(0, 13));
					num = ((int)num2 * -1157515608) ^ -1711585745;
					continue;
				case 19u:
					label1 = Form2.smethod_17();
					num = (int)(num2 * 79548931) ^ -210149111;
					continue;
				case 18u:
					num = (int)((num2 * 571957234) ^ 0xE898153);
					continue;
				case 17u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)button1);
					num = (int)(num2 * 305109908) ^ -842296499;
					continue;
				case 16u:
					Form2.smethod_37((Form)(object)this, bool_0: false);
					Form2.smethod_38((Form)(object)this, bool_0: false);
					num = ((int)num2 * -2139984247) ^ -2061613493;
					continue;
				case 15u:
					Form2.smethod_22((Control)(object)label3, new Point(47, 177));
					num = (int)(num2 * 1426129378) ^ -1198170692;
					continue;
				case 14u:
					Form2.smethod_40((Form)(object)this, bool_0: false);
					num = (int)(num2 * 366656538) ^ -1045484765;
					continue;
				case 13u:
					num = (int)((num2 * 1929302259) ^ 0x3502C737);
					continue;
				case 12u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label1);
					Form2.smethod_36((Form)(object)this, (FormBorderStyle)1);
					num = (int)((num2 * 863303943) ^ 0x2245E9AF);
					continue;
				case 11u:
					Form2.smethod_23((Control)(object)label2, "label2");
					Form2.smethod_24((Control)(object)label2, new Size(188, 73));
					num = ((int)num2 * -791578568) ^ 0xA8C7572;
					continue;
				case 10u:
					num = ((int)num2 * -336342048) ^ 0x5A903778;
					continue;
				case 9u:
					Form2.smethod_23((Control)(object)button1, "button1");
					num = ((int)num2 * -1207795729) ^ 0x513B3029;
					continue;
				case 8u:
					num = (int)((num2 * 2082793744) ^ 0x6026D476);
					continue;
				case 7u:
					Form2.smethod_29((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -1465902105) ^ -609633412;
					continue;
				case 6u:
					Form2.smethod_28((Control)(object)textBox1, new KeyPressEventHandler(TextBox1_KeyPress));
					Form2.smethod_21((Control)(object)label2, bool_0: true);
					Form2.smethod_27((Control)(object)label2, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1209279571) ^ -1639917959;
					continue;
				case 5u:
					Form2.smethod_22((Control)(object)label1, new Point(10, 10));
					num = (int)((num2 * 561447871) ^ 0x39C2B546);
					continue;
				case 3u:
					num = (int)((num2 * 1991397669) ^ 0x6648982A);
					continue;
				case 1u:
					Form2.smethod_21((Control)(object)label1, bool_0: true);
					num = (int)(num2 * 2124559434) ^ -1286109211;
					continue;
				case 0u:
					Form2.smethod_42((Control)(object)this, bool_0: false);
					num = (int)(num2 * 448352853) ^ -1580781510;
					continue;
				default:
					return;
				case 2u:
					break;
				case 4u:
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
