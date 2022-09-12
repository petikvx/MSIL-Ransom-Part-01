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
			int num = -486907066;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE11C230Fu) % 11u)
				{
				case 10u:
					num = (int)(num2 * 1320124992) ^ -1872081149;
					continue;
				case 9u:
					num = (int)(num2 * 224747789) ^ -1948911476;
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (char.IsDigit(Form2.smethod_4(e)))
					{
						num5 = -632101474;
						num6 = -632101474;
					}
					else
					{
						num5 = -477291216;
						num6 = -477291216;
					}
					num = num5 ^ (int)(num2 * 1501182984);
					continue;
				}
				case 6u:
					flag = Form2.smethod_4(e) == '\r';
					num = -354064116;
					continue;
				case 5u:
					Form2.smethod_1((Control)(object)textBox1, "");
					num = -1278015333;
					continue;
				case 4u:
					Button1_Click(this, Form2.smethod_6());
					num = (int)(num2 * 2055114056) ^ -479789372;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 65651065;
						num4 = 65651065;
					}
					else
					{
						num3 = 1994188748;
						num4 = 1994188748;
					}
					num = num3 ^ (int)(num2 * 2063197189);
					continue;
				}
				case 1u:
					Form2.smethod_5(e, bool_0: true);
					num = ((int)num2 * -2041209191) ^ -736229737;
					continue;
				case 0u:
					num = ((int)num2 * -1682670131) ^ 0x37709113;
					continue;
				default:
					return;
				case 3u:
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
		int num7 = default(int);
		bool flag = default(bool);
		int num3 = default(int);
		int num4 = default(int);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 1082107101;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2ECC3161u) % 30u)
				{
				case 29u:
					Form2.smethod_15((Form)(object)this);
					num = ((int)num2 * -1345406426) ^ 0x3D1CF3FF;
					continue;
				case 28u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = false;
					num = (int)(num2 * 1488462992) ^ -1967157193;
					continue;
				case 27u:
				{
					Form control_2 = Form2.smethod_2((Form)(object)this);
					num7 = Form2.smethod_12((Control)(object)control_2) - 1;
					Form2.smethod_13((Control)(object)control_2, num7);
					num = 1941818219;
					continue;
				}
				case 26u:
					flag = this.flag;
					num = ((int)num2 * -1252796095) ^ -143992940;
					continue;
				case 25u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = true;
					num = (int)(num2 * 1628280055) ^ -814185648;
					continue;
				case 24u:
					this.flag = false;
					num = 1257425006;
					continue;
				case 23u:
					Form2.smethod_14(Form2.smethod_11(Form2.smethod_2((Form)(object)this)));
					num = (int)((num2 * 1505778679) ^ 0x54716ED3);
					continue;
				case 22u:
					Form2.smethod_1((Control)(object)label3, "Поздравляем! Ваш ход первый.");
					num = (int)(num2 * 1183288495) ^ -131248724;
					continue;
				case 21u:
					num = 1622957528;
					continue;
				case 20u:
					num = (int)((num2 * 1675178781) ^ 0x42C1D812);
					continue;
				case 19u:
				{
					int num10;
					int num11;
					if ((num3 + num4) % 2 != 0)
					{
						num10 = 731430881;
						num11 = 731430881;
					}
					else
					{
						num10 = 1888165534;
						num11 = 1888165534;
					}
					num = num10 ^ ((int)num2 * -1468590753);
					continue;
				}
				case 18u:
				{
					Label control_ = label2;
					string string_ = num4.ToString();
					num7 = num3 + num4;
					Form2.smethod_1((Control)(object)control_, Form2.smethod_10("+", string_, "=", num7.ToString()));
					num = ((int)num2 * -1764078794) ^ -538182145;
					continue;
				}
				case 17u:
				{
					int num8;
					int num9;
					if (!flag2)
					{
						num8 = -1548272407;
						num9 = -1548272407;
					}
					else
					{
						num8 = -926802145;
						num9 = -926802145;
					}
					num = num8 ^ ((int)num2 * -1693278551);
					continue;
				}
				case 16u:
					flag2 = num7 > 1;
					num = (int)((num2 * 302956343) ^ 0x3714498C);
					continue;
				case 15u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = -499593460;
						num6 = -499593460;
					}
					else
					{
						num5 = -373336823;
						num6 = -373336823;
					}
					num = num5 ^ ((int)num2 * -764977116);
					continue;
				}
				case 14u:
					num = ((int)num2 * -1904907847) ^ 0x73C88879;
					continue;
				case 13u:
					num = ((int)num2 * -1200507484) ^ -1001156047;
					continue;
				case 12u:
					num = (int)(num2 * 558605664) ^ -238369700;
					continue;
				case 11u:
					num = 738227694;
					continue;
				case 10u:
					num = 738227694;
					continue;
				case 9u:
					(Form2.smethod_2((Form)(object)this) as Form3).Button_Continue();
					num = (int)(num2 * 349294290) ^ -295571195;
					continue;
				case 8u:
					num3 = int.Parse(Form2.smethod_7((Control)(object)textBox1));
					num4 = Form2.smethod_9(rnd, 10);
					num = ((int)num2 * -1368357716) ^ 0x78D6E20B;
					continue;
				case 7u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).StartGame();
					num = (int)(num2 * 1442430123) ^ -1428865479;
					continue;
				case 6u:
					Form2.smethod_1((Control)(object)label3, "Первым ход делает Компьютер.");
					num = ((int)num2 * -1878362724) ^ 0x415351A5;
					continue;
				case 5u:
					num = ((int)num2 * -383148309) ^ -2059932273;
					continue;
				case 4u:
					num = ((int)num2 * -124785813) ^ 0x7790B279;
					continue;
				case 1u:
					num = 1276498461;
					continue;
				case 0u:
					num = ((int)num2 * -872852183) ^ 0x1DCEC122;
					continue;
				default:
					return;
				case 2u:
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
			goto IL_0025;
		}
		goto IL_00ac;
		IL_0025:
		int num = -550319593;
		goto IL_0070;
		IL_0070:
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xD82616B6u) % 8u)
			{
			case 6u:
				num = (int)((num2 * 601160398) ^ 0x6B6D63D2);
				continue;
			case 5u:
				break;
			case 4u:
				((Form)this).Dispose(disposing);
				num = -83609859;
				continue;
			case 3u:
				num = (int)(num2 * 1119804902) ^ -445883797;
				continue;
			case 2u:
				num = (int)(num2 * 1079157723) ^ -43899268;
				continue;
			case 0u:
				Form2.smethod_16((IDisposable)components);
				num = ((int)num2 * -1372420186) ^ 0x5EDF57E4;
				continue;
			default:
				return;
			case 1u:
				goto IL_00a1;
			case 7u:
				return;
			}
			break;
			IL_00a1:
			if (components != null)
			{
				num = -691506672;
				num3 = -691506672;
				continue;
			}
			goto IL_00ac;
		}
		goto IL_0025;
		IL_00ac:
		num = -971223686;
		num3 = -971223686;
		goto IL_0070;
	}

	private void InitializeComponent()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0507: Expected O, but got Unknown
		while (true)
		{
			int num = 374903726;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x66E80D33u) % 76u)
				{
				case 75u:
					Form2.smethod_21((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -669543523) ^ 0x4FC99770;
					continue;
				case 74u:
					Form2.smethod_41((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
					num = (int)((num2 * 1654463991) ^ 0x7DA38C56);
					continue;
				case 73u:
					Form2.smethod_25((Control)(object)label2, 2);
					num = (int)((num2 * 1247831286) ^ 0x69B60D72);
					continue;
				case 72u:
					num = (int)((num2 * 1383190677) ^ 0x317A542C);
					continue;
				case 71u:
					Form2.smethod_30((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -2142702342) ^ -500592384;
					continue;
				case 70u:
					Form2.smethod_1((Control)(object)label2, "+N=?");
					num = (int)(num2 * 122674639) ^ -1089010585;
					continue;
				case 69u:
					Form2.smethod_22((Control)(object)label1, new Point(10, 10));
					num = (int)(num2 * 1604496897) ^ -98740224;
					continue;
				case 68u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label1);
					num = (int)((num2 * 2026342757) ^ 0xB197372);
					continue;
				case 67u:
					Form2.smethod_23((Control)(object)label1, "label1");
					num = ((int)num2 * -1376672956) ^ 0x7819C7D6;
					continue;
				case 66u:
					Form2.smethod_24((Control)(object)label1, new Size(35, 13));
					num = ((int)num2 * -1084823920) ^ -994706243;
					continue;
				case 65u:
					num = ((int)num2 * -396248116) ^ 0x4EA4B8AB;
					continue;
				case 64u:
					Form2.smethod_37((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1274549790) ^ 0x3B664BB8;
					continue;
				case 63u:
					num = (int)((num2 * 1136177275) ^ 0x58B553B8);
					continue;
				case 62u:
					Form2.smethod_25((Control)(object)label1, 0);
					num = ((int)num2 * -359339672) ^ 0x17011970;
					continue;
				case 61u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)textBox1);
					num = ((int)num2 * -937637471) ^ 0x1D0FD27F;
					continue;
				case 60u:
					num = (int)(num2 * 723773485) ^ -1567065445;
					continue;
				case 59u:
					Form2.smethod_38((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1090268928) ^ -115010378;
					continue;
				case 58u:
					Form2.smethod_1((Control)(object)button1, "OK");
					num = ((int)num2 * -404806144) ^ 0xBFC7836;
					continue;
				case 57u:
					Form2.smethod_22((Control)(object)label3, new Point(47, 177));
					num = (int)(num2 * 1468022202) ^ -288404306;
					continue;
				case 56u:
					Form2.smethod_29((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -1319140144) ^ 0x6E92CE60;
					continue;
				case 55u:
					Form2.smethod_27((Control)(object)label2, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -463319013) ^ -932323204;
					continue;
				case 54u:
					Form2.smethod_42((Control)(object)this, bool_0: false);
					num = ((int)num2 * -2147065713) ^ 0x629D21D5;
					continue;
				case 53u:
					Form2.smethod_1((Control)(object)label1, "label1");
					num = ((int)num2 * -215163593) ^ 0x77D1E7E7;
					continue;
				case 52u:
					num = ((int)num2 * -2142559416) ^ 0x101256A2;
					continue;
				case 51u:
					num = ((int)num2 * -1450426273) ^ -1258100845;
					continue;
				case 49u:
					num = ((int)num2 * -233176979) ^ -1945201311;
					continue;
				case 48u:
					Form2.smethod_32((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -1523003668) ^ 0x76D809F7;
					continue;
				case 47u:
					Form2.smethod_21((Control)(object)label3, bool_0: true);
					num = ((int)num2 * -540635067) ^ 0x31FAF6EA;
					continue;
				case 46u:
					Form2.smethod_24((Control)(object)button1, new Size(73, 23));
					num = ((int)num2 * -1719187531) ^ 0x38B8C5A1;
					continue;
				case 45u:
					num = (int)((num2 * 2040551983) ^ 0x74D7CECF);
					continue;
				case 44u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label2);
					num = (int)((num2 * 1287996711) ^ 0x1B58CC70);
					continue;
				case 43u:
					num = (int)(num2 * 832816061) ^ -557000656;
					continue;
				case 42u:
					num = ((int)num2 * -647074577) ^ 0x2D8A08D7;
					continue;
				case 41u:
					num = (int)(num2 * 522441422) ^ -2009388454;
					continue;
				case 40u:
					Form2.smethod_23((Control)(object)textBox1, "textBox1");
					Form2.smethod_24((Control)(object)textBox1, new Size(42, 80));
					num = (int)(num2 * 1147852872) ^ -1389838803;
					continue;
				case 39u:
					num = (int)(num2 * 386727235) ^ -482165644;
					continue;
				case 38u:
					num = ((int)num2 * -2114582168) ^ 0x567882F9;
					continue;
				case 37u:
					num = ((int)num2 * -595456133) ^ -1490299900;
					continue;
				case 36u:
					Form2.smethod_40((Form)(object)this, bool_0: false);
					Form2.smethod_1((Control)(object)this, "Жеребьёвка");
					num = (int)(num2 * 399148647) ^ -1339073968;
					continue;
				case 35u:
					num = ((int)num2 * -190649176) ^ 0x4E7E5BE5;
					continue;
				case 34u:
					num = (int)((num2 * 1058241973) ^ 0x4D46F91B);
					continue;
				case 33u:
					Form2.smethod_24((Control)(object)label2, new Size(188, 73));
					num = (int)((num2 * 322726880) ^ 0x7084EF16);
					continue;
				case 32u:
					num = ((int)num2 * -41546962) ^ -574408050;
					continue;
				case 31u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -240339476) ^ 0x17124153;
					continue;
				case 30u:
					Form2.smethod_25((Control)(object)textBox1, 1);
					Form2.smethod_28((Control)(object)textBox1, new KeyPressEventHandler(TextBox1_KeyPress));
					Form2.smethod_21((Control)(object)label2, bool_0: true);
					num = (int)(num2 * 819704159) ^ -1320114424;
					continue;
				case 29u:
					Form2.smethod_36((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -668552769) ^ 0x4A220F1C;
					continue;
				case 28u:
					Form2.smethod_23((Control)(object)button1, "button1");
					num = ((int)num2 * -853609199) ^ -1410576289;
					continue;
				case 27u:
					Form2.smethod_25((Control)(object)label3, 4);
					num = (int)(num2 * 409935330) ^ -768706393;
					continue;
				case 26u:
					Form2.smethod_22((Control)(object)label2, new Point(53, 89));
					num = ((int)num2 * -694404124) ^ -1884164109;
					continue;
				case 25u:
					num = (int)((num2 * 532780614) ^ 0x3B473CF0);
					continue;
				case 24u:
					num = ((int)num2 * -1937828325) ^ 0x33260E8D;
					continue;
				case 23u:
					Form2.smethod_20((Control)(object)this);
					num = ((int)num2 * -379350634) ^ 0x176B7B86;
					continue;
				case 22u:
					num = (int)((num2 * 1882943176) ^ 0x603302E6);
					continue;
				case 21u:
					num = (int)(num2 * 2135328025) ^ -2087427108;
					continue;
				case 20u:
					Form2.smethod_43((Control)(object)this);
					num = (int)(num2 * 1703281778) ^ -1617080597;
					continue;
				case 19u:
					Form2.smethod_39((Control)(object)this, "Form2");
					num = ((int)num2 * -276544494) ^ 0x1D49CD89;
					continue;
				case 18u:
					num = (int)((num2 * 972904142) ^ 0x4A702B78);
					continue;
				case 17u:
					num = ((int)num2 * -751855963) ^ -1835288939;
					continue;
				case 16u:
					num = (int)((num2 * 760457388) ^ 0x25115314);
					continue;
				case 15u:
					num = (int)(num2 * 2084054980) ^ -665124566;
					continue;
				case 13u:
					label1 = Form2.smethod_17();
					textBox1 = Form2.smethod_18();
					num = ((int)num2 * -1815510405) ^ -1623695205;
					continue;
				case 12u:
					Form2.smethod_27((Control)(object)textBox1, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form2.smethod_22((Control)(object)textBox1, new Point(24, 86));
					num = (int)((num2 * 1784218005) ^ 0x7A05EAA3);
					continue;
				case 11u:
					num = (int)(num2 * 6083859) ^ -1414080390;
					continue;
				case 10u:
					Form2.smethod_31((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -625849870) ^ -1240413461;
					continue;
				case 9u:
					label3 = Form2.smethod_17();
					num = (int)((num2 * 1580812850) ^ 0x2C659BF2);
					continue;
				case 8u:
					num = (int)((num2 * 695074412) ^ 0xB9F00ED);
					continue;
				case 7u:
					label2 = Form2.smethod_17();
					button1 = Form2.smethod_19();
					num = ((int)num2 * -40923851) ^ 0x2937F769;
					continue;
				case 6u:
					num = ((int)num2 * -1217630178) ^ 0x810CE7D;
					continue;
				case 5u:
					Form2.smethod_23((Control)(object)label3, "label3");
					Form2.smethod_24((Control)(object)label3, new Size(0, 13));
					num = ((int)num2 * -924065682) ^ 0x477145F9;
					continue;
				case 4u:
					Form2.smethod_33((Form)(object)this, new Size(255, 224));
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label3);
					num = ((int)num2 * -204296674) ^ -31927478;
					continue;
				case 3u:
					Form2.smethod_25((Control)(object)button1, 3);
					num = ((int)num2 * -1989594550) ^ 0x43ECA177;
					continue;
				case 2u:
					Form2.smethod_22((Control)(object)button1, new Point(86, 193));
					num = (int)((num2 * 1515186266) ^ 0x4FC25066);
					continue;
				case 1u:
					num = (int)((num2 * 1465883169) ^ 0x6A09D07A);
					continue;
				case 0u:
					Form2.smethod_23((Control)(object)label2, "label2");
					num = (int)(num2 * 1791782235) ^ -2113159482;
					continue;
				default:
					return;
				case 50u:
					break;
				case 14u:
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
