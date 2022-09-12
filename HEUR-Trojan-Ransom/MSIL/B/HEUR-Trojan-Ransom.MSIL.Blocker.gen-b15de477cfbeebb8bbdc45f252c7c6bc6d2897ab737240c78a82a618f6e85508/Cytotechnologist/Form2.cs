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
			int num = 305092823;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1E658E74u) % 6u)
				{
				case 3u:
					num = (int)((num2 * 1945063311) ^ 0x512CB290);
					continue;
				case 2u:
					num = ((int)num2 * -1216577620) ^ -1383181818;
					continue;
				case 1u:
					num = (int)((num2 * 1532297944) ^ 0x697D535A);
					continue;
				case 0u:
					InitializeComponent();
					num = ((int)num2 * -776316966) ^ -1044721231;
					continue;
				case 4u:
					break;
				default:
					Form2.smethod_1((Control)(object)label1, "Введите любое число от 0 до 9 включительно.\nВаш соперник уже загадал число (N) из этого\nже диапазона. Если сумма ваших чисел будет\nчетным числом, то первым ход делаете Вы,\nиначе - ваш соперник Компьютер!");
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
			int num = -530746694;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9DDC04AAu) % 3u)
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
				num = (int)((num2 * 823486232) ^ 0x515BFBB9);
			}
		}
	}

	private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = 1024994026;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x72D68ABFu) % 10u)
				{
				case 9u:
					flag = Form2.smethod_4(e) == '\r';
					num = 1221259441;
					continue;
				case 8u:
					Button1_Click(this, Form2.smethod_6());
					num = ((int)num2 * -1482806795) ^ -1860461072;
					continue;
				case 7u:
					num = ((int)num2 * -1691580443) ^ -482030282;
					continue;
				case 6u:
					num = ((int)num2 * -571281895) ^ 0x18062670;
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (char.IsDigit(Form2.smethod_4(e)))
					{
						num5 = 914303263;
						num6 = 914303263;
					}
					else
					{
						num5 = 654589609;
						num6 = 654589609;
					}
					num = num5 ^ ((int)num2 * -1193205973);
					continue;
				}
				case 3u:
					Form2.smethod_1((Control)(object)textBox1, "");
					num = 2058773402;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -775954085;
						num4 = -775954085;
					}
					else
					{
						num3 = -1495710287;
						num4 = -1495710287;
					}
					num = num3 ^ (int)(num2 * 1205299416);
					continue;
				}
				case 1u:
					Form2.smethod_5(e, bool_0: true);
					num = (int)(num2 * 639217078) ^ -1608957869;
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

	private void Button1_Click(object sender, EventArgs e)
	{
		if (!Form2.smethod_8(Form2.smethod_7((Control)(object)textBox1), ""))
		{
			return;
		}
		bool flag = default(bool);
		int num5 = default(int);
		bool flag2 = default(bool);
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = 1814639660;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB63546Eu) % 32u)
				{
				case 31u:
					flag = num5 > 1;
					num = (int)(num2 * 125025083) ^ -276746643;
					continue;
				case 30u:
					Form2.smethod_1((Control)(object)label3, "Первым ход делает Компьютер.");
					num = (int)(num2 * 550379757) ^ -128948206;
					continue;
				case 29u:
					Form2.smethod_1((Control)(object)label3, "Поздравляем! Ваш ход первый.");
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = true;
					num = (int)((num2 * 231001759) ^ 0x240055A3);
					continue;
				case 28u:
					Form2.smethod_14(Form2.smethod_11(Form2.smethod_2((Form)(object)this)));
					num = ((int)num2 * -1753385074) ^ -433646291;
					continue;
				case 27u:
					this.flag = false;
					num = 320119844;
					continue;
				case 26u:
					num = (int)((num2 * 1944947819) ^ 0x112A07E3);
					continue;
				case 25u:
					num = 1878345219;
					continue;
				case 24u:
				{
					int num10;
					int num11;
					if (!flag2)
					{
						num10 = -996123047;
						num11 = -996123047;
					}
					else
					{
						num10 = -1593695445;
						num11 = -1593695445;
					}
					num = num10 ^ (int)(num2 * 433424842);
					continue;
				}
				case 23u:
					num = ((int)num2 * -1237545271) ^ 0x3DD8B8E;
					continue;
				case 22u:
					(Form2.smethod_2((Form)(object)this) as Form3).Button_Continue();
					num = ((int)num2 * -304517165) ^ -937763607;
					continue;
				case 21u:
					num = (int)((num2 * 376317918) ^ 0x41DE1525);
					continue;
				case 20u:
					num = ((int)num2 * -1064254018) ^ 0x5BCEC06;
					continue;
				case 19u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = false;
					num = ((int)num2 * -308776826) ^ 0x5DDB23F4;
					continue;
				case 18u:
					num = 1542002975;
					continue;
				case 17u:
				{
					Form control_2 = Form2.smethod_2((Form)(object)this);
					num5 = Form2.smethod_12((Control)(object)control_2) - 1;
					Form2.smethod_13((Control)(object)control_2, num5);
					num = 36348401;
					continue;
				}
				case 16u:
					num = 801117026;
					continue;
				case 15u:
					num4 = int.Parse(Form2.smethod_7((Control)(object)textBox1));
					num3 = Form2.smethod_9(rnd, 10);
					num = ((int)num2 * -1428136213) ^ -1252303605;
					continue;
				case 14u:
					num = (int)(num2 * 850065479) ^ -746452795;
					continue;
				case 13u:
					num = (int)(num2 * 302694089) ^ -433437558;
					continue;
				case 11u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).StartGame();
					Form2.smethod_15((Form)(object)this);
					num = (int)(num2 * 1402798295) ^ -1056119961;
					continue;
				case 10u:
					num = (int)(num2 * 1884076687) ^ -791964856;
					continue;
				case 9u:
					num = (int)((num2 * 127608509) ^ 0x418976F0);
					continue;
				case 8u:
					num = ((int)num2 * -569150280) ^ 0x7AC033B5;
					continue;
				case 7u:
					num = 265784976;
					continue;
				case 6u:
				{
					int num8;
					int num9;
					if (flag)
					{
						num8 = 2062387448;
						num9 = 2062387448;
					}
					else
					{
						num8 = 1624175324;
						num9 = 1624175324;
					}
					num = num8 ^ ((int)num2 * -598211754);
					continue;
				}
				case 5u:
					num = ((int)num2 * -854645192) ^ -1670746134;
					continue;
				case 3u:
					flag2 = (num4 + num3) % 2 == 0;
					num = ((int)num2 * -379277351) ^ -581004899;
					continue;
				case 2u:
					num = (int)(num2 * 1182754491) ^ -949228359;
					continue;
				case 1u:
				{
					int num6;
					int num7;
					if (!this.flag)
					{
						num6 = 612701828;
						num7 = 612701828;
					}
					else
					{
						num6 = 217786634;
						num7 = 217786634;
					}
					num = num6 ^ ((int)num2 * -1347244237);
					continue;
				}
				case 0u:
				{
					Label control_ = label2;
					string string_ = num3.ToString();
					num5 = num4 + num3;
					Form2.smethod_1((Control)(object)control_, Form2.smethod_10("+", string_, "=", num5.ToString()));
					num = ((int)num2 * -283099828) ^ 0x327DFF6D;
					continue;
				}
				default:
					return;
				case 4u:
					break;
				case 12u:
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
		goto IL_007a;
		IL_007a:
		int num = 1229676973;
		goto IL_007f;
		IL_007f:
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x171B4DF0u) % 9u)
			{
			case 8u:
				num = (int)((num2 * 1871955538) ^ 0x7F0B4895);
				continue;
			case 7u:
				num = ((int)num2 * -1218550388) ^ 0x2AC53F76;
				continue;
			case 6u:
				num = ((int)num2 * -1714398203) ^ -966346085;
				continue;
			case 3u:
				Form2.smethod_16((IDisposable)components);
				num = ((int)num2 * -578620369) ^ 0x340B35E;
				continue;
			case 2u:
				((Form)this).Dispose(disposing);
				num = 1410535286;
				continue;
			case 1u:
				num = (int)((num2 * 835431294) ^ 0x35E357A3);
				continue;
			case 0u:
				break;
			default:
				return;
			case 5u:
				goto IL_00b5;
			case 4u:
				return;
			}
			break;
			IL_00b5:
			if (components != null)
			{
				num = 796320704;
				num3 = 796320704;
				continue;
			}
			goto IL_0009;
		}
		goto IL_007a;
		IL_0009:
		num = 1593151967;
		num3 = 1593151967;
		goto IL_007f;
	}

	private void InitializeComponent()
	{
		//IL_06dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Expected O, but got Unknown
		//IL_072a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0734: Expected O, but got Unknown
		while (true)
		{
			int num = -1126298190;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9336F8F8u) % 67u)
				{
				case 66u:
					Form2.smethod_43((Control)(object)this);
					num = ((int)num2 * -2132486958) ^ 0x47676B16;
					continue;
				case 65u:
					Form2.smethod_23((Control)(object)label3, "label3");
					num = (int)((num2 * 422854344) ^ 0x299957A0);
					continue;
				case 64u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label3);
					num = ((int)num2 * -890178732) ^ -227136641;
					continue;
				case 63u:
					num = (int)(num2 * 87708909) ^ -1807822916;
					continue;
				case 62u:
					Form2.smethod_24((Control)(object)button1, new Size(73, 23));
					num = (int)((num2 * 1959876899) ^ 0x6131230B);
					continue;
				case 61u:
					Form2.smethod_24((Control)(object)label1, new Size(35, 13));
					num = ((int)num2 * -1676505918) ^ -1755547530;
					continue;
				case 60u:
					Form2.smethod_24((Control)(object)label3, new Size(0, 13));
					num = ((int)num2 * -331900873) ^ -771192439;
					continue;
				case 59u:
					Form2.smethod_42((Control)(object)this, bool_0: false);
					num = (int)(num2 * 1800508858) ^ -1825680229;
					continue;
				case 58u:
					Form2.smethod_1((Control)(object)this, "Жеребьёвка");
					num = ((int)num2 * -1645807590) ^ 0x6494E7A5;
					continue;
				case 57u:
					Form2.smethod_20((Control)(object)this);
					num = (int)((num2 * 1223534258) ^ 0x6B0D30D);
					continue;
				case 56u:
					num = (int)((num2 * 439857541) ^ 0x6F6EA2DE);
					continue;
				case 55u:
					Form2.smethod_23((Control)(object)label2, "label2");
					num = (int)(num2 * 463909960) ^ -1979075199;
					continue;
				case 54u:
					num = (int)(num2 * 474515588) ^ -1132040960;
					continue;
				case 53u:
					num = (int)(num2 * 1833997376) ^ -793037329;
					continue;
				case 52u:
					Form2.smethod_23((Control)(object)label1, "label1");
					num = ((int)num2 * -1294104788) ^ -328109338;
					continue;
				case 51u:
					Form2.smethod_30((Control)(object)button1, (EventHandler)Button1_Click);
					Form2.smethod_21((Control)(object)label3, bool_0: true);
					num = ((int)num2 * -94627950) ^ -355968639;
					continue;
				case 50u:
					Form2.smethod_27((Control)(object)textBox1, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form2.smethod_22((Control)(object)textBox1, new Point(24, 86));
					num = ((int)num2 * -1487241052) ^ -714809442;
					continue;
				case 49u:
					Form2.smethod_24((Control)(object)label2, new Size(188, 73));
					num = (int)((num2 * 431157343) ^ 0x79FCB9DA);
					continue;
				case 48u:
					Form2.smethod_25((Control)(object)label1, 0);
					num = ((int)num2 * -162896330) ^ 0x5670B68C;
					continue;
				case 47u:
					Form2.smethod_27((Control)(object)label2, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form2.smethod_22((Control)(object)label2, new Point(53, 89));
					num = (int)(num2 * 2106290158) ^ -1718193342;
					continue;
				case 46u:
					num = ((int)num2 * -199638490) ^ -148245174;
					continue;
				case 45u:
					label1 = Form2.smethod_17();
					textBox1 = Form2.smethod_18();
					num = ((int)num2 * -1356383723) ^ 0x2DC7D1D1;
					continue;
				case 44u:
					num = ((int)num2 * -1374741077) ^ 0x2E8DB3C8;
					continue;
				case 43u:
					num = ((int)num2 * -1890109638) ^ 0x7EBD0ABF;
					continue;
				case 42u:
					num = ((int)num2 * -1911794561) ^ 0x504D59A0;
					continue;
				case 41u:
					Form2.smethod_22((Control)(object)label1, new Point(10, 10));
					num = (int)((num2 * 341229503) ^ 0x49D06865);
					continue;
				case 40u:
					Form2.smethod_40((Form)(object)this, bool_0: false);
					num = (int)(num2 * 2087882471) ^ -2037410222;
					continue;
				case 39u:
					num = (int)((num2 * 1866631034) ^ 0x5E788EDD);
					continue;
				case 38u:
					num = ((int)num2 * -15268776) ^ -962894129;
					continue;
				case 37u:
					Form2.smethod_25((Control)(object)label3, 4);
					Form2.smethod_31((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)((num2 * 1912935505) ^ 0x79EBD028);
					continue;
				case 36u:
					Form2.smethod_24((Control)(object)textBox1, new Size(42, 80));
					num = ((int)num2 * -99881271) ^ 0x321235F6;
					continue;
				case 35u:
					Form2.smethod_32((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 393229917) ^ 0x4C7A6770);
					continue;
				case 34u:
					Form2.smethod_21((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -1376714786) ^ -401756046;
					continue;
				case 33u:
					Form2.smethod_33((Form)(object)this, new Size(255, 224));
					num = ((int)num2 * -1760688371) ^ 0x7EFB23F4;
					continue;
				case 31u:
					num = (int)(num2 * 671126391) ^ -862393663;
					continue;
				case 29u:
					num = ((int)num2 * -2075155806) ^ 0x69D2C693;
					continue;
				case 28u:
					Form2.smethod_1((Control)(object)label1, "label1");
					num = ((int)num2 * -828205150) ^ 0x7151855C;
					continue;
				case 27u:
					Form2.smethod_23((Control)(object)button1, "button1");
					num = (int)((num2 * 497333366) ^ 0x1F328F12);
					continue;
				case 26u:
					Form2.smethod_22((Control)(object)button1, new Point(86, 193));
					num = ((int)num2 * -227456356) ^ -833409080;
					continue;
				case 25u:
					num = (int)((num2 * 727643889) ^ 0x700D644);
					continue;
				case 24u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)textBox1);
					num = (int)(num2 * 1273327562) ^ -1033686248;
					continue;
				case 23u:
					Form2.smethod_23((Control)(object)textBox1, "textBox1");
					num = ((int)num2 * -856559963) ^ -1240866254;
					continue;
				case 22u:
					num = ((int)num2 * -1854740052) ^ -893723756;
					continue;
				case 21u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)button1);
					num = (int)(num2 * 919450013) ^ -1292555730;
					continue;
				case 20u:
					Form2.smethod_25((Control)(object)button1, 3);
					Form2.smethod_1((Control)(object)button1, "OK");
					num = (int)((num2 * 1383606227) ^ 0x248AFB7E);
					continue;
				case 19u:
					Form2.smethod_38((Form)(object)this, bool_0: false);
					Form2.smethod_39((Control)(object)this, "Form2");
					num = ((int)num2 * -1610486846) ^ -255945635;
					continue;
				case 18u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label2);
					num = ((int)num2 * -1003610595) ^ 0x15668F0B;
					continue;
				case 17u:
					label2 = Form2.smethod_17();
					button1 = Form2.smethod_19();
					num = ((int)num2 * -1295237207) ^ 0x1B522EF8;
					continue;
				case 16u:
					Form2.smethod_22((Control)(object)label3, new Point(47, 177));
					num = (int)((num2 * 775786016) ^ 0x63B04021);
					continue;
				case 15u:
					num = (int)((num2 * 689311135) ^ 0x39BA0C1F);
					continue;
				case 14u:
					num = ((int)num2 * -1016434780) ^ -507440767;
					continue;
				case 13u:
					num = (int)((num2 * 464697099) ^ 0xCA5F4B3);
					continue;
				case 12u:
					num = ((int)num2 * -1964022277) ^ 0x4A2277F;
					continue;
				case 11u:
					num = (int)(num2 * 394782493) ^ -2055287732;
					continue;
				case 10u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label1);
					num = (int)(num2 * 584952939) ^ -540903795;
					continue;
				case 9u:
					Form2.smethod_1((Control)(object)label2, "+N=?");
					num = (int)((num2 * 593270200) ^ 0x7940B96D);
					continue;
				case 8u:
					Form2.smethod_25((Control)(object)textBox1, 1);
					Form2.smethod_28((Control)(object)textBox1, new KeyPressEventHandler(TextBox1_KeyPress));
					Form2.smethod_21((Control)(object)label2, bool_0: true);
					num = ((int)num2 * -792299368) ^ -89348572;
					continue;
				case 7u:
					label3 = Form2.smethod_17();
					num = ((int)num2 * -666104175) ^ -1422404237;
					continue;
				case 6u:
					Form2.smethod_41((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
					num = (int)((num2 * 1558212878) ^ 0x1C4F9C44);
					continue;
				case 5u:
					Form2.smethod_29((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -417473120) ^ -742046801;
					continue;
				case 4u:
					Form2.smethod_25((Control)(object)label2, 2);
					num = ((int)num2 * -1995077183) ^ 0x1E4DA460;
					continue;
				case 3u:
					Form2.smethod_36((Form)(object)this, (FormBorderStyle)1);
					num = (int)(num2 * 1078477377) ^ -1984855348;
					continue;
				case 2u:
					num = (int)(num2 * 766515331) ^ -1318677491;
					continue;
				case 1u:
					num = ((int)num2 * -1352353189) ^ 0x7C30D217;
					continue;
				case 0u:
					Form2.smethod_37((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1102968971) ^ -1933543234;
					continue;
				default:
					return;
				case 32u:
					break;
				case 30u:
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
