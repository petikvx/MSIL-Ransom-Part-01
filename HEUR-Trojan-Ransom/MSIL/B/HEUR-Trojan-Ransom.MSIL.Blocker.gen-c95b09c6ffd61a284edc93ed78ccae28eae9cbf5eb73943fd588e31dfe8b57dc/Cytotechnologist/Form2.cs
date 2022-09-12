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
			int num = 472135558;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x368CE486u) % 12u)
				{
				case 10u:
					num = ((int)num2 * -830551596) ^ -769616845;
					continue;
				case 9u:
					num = ((int)num2 * -1416861064) ^ -786155345;
					continue;
				case 7u:
					Form2.smethod_5(e, bool_0: true);
					num = (int)(num2 * 1749213283) ^ -467018535;
					continue;
				case 6u:
					num = (int)(num2 * 1057551519) ^ -401474971;
					continue;
				case 5u:
					flag = Form2.smethod_4(e) == '\r';
					num = 1662936586;
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (char.IsDigit(Form2.smethod_4(e)))
					{
						num5 = 626076984;
						num6 = 626076984;
					}
					else
					{
						num5 = 1142995949;
						num6 = 1142995949;
					}
					num = num5 ^ ((int)num2 * -1860648278);
					continue;
				}
				case 3u:
					Button1_Click(this, Form2.smethod_6());
					num = (int)((num2 * 1319041971) ^ 0x4D59FEBA);
					continue;
				case 2u:
					Form2.smethod_1((Control)(object)textBox1, "");
					num = 576078952;
					continue;
				case 1u:
					num = (int)((num2 * 823404594) ^ 0x36C054DF);
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1736230471;
						num4 = -1736230471;
					}
					else
					{
						num3 = -2079506811;
						num4 = -2079506811;
					}
					num = num3 ^ (int)(num2 * 2046492491);
					continue;
				}
				default:
					return;
				case 8u:
					break;
				case 11u:
					return;
				}
				break;
			}
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		int num10 = default(int);
		int num11 = default(int);
		int num3 = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num = 832202594;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x43A11159u) % 32u)
				{
				case 31u:
					this.flag = false;
					num = 1845477642;
					continue;
				case 30u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = true;
					num = ((int)num2 * -1665631706) ^ 0x5EAE51FF;
					continue;
				case 29u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = false;
					num = (int)(num2 * 5940289) ^ -7061061;
					continue;
				case 28u:
				{
					num10 = int.Parse(Form2.smethod_7((Control)(object)textBox1));
					num11 = Form2.smethod_9(rnd, 10);
					Label control_2 = label2;
					string string_ = num11.ToString();
					num3 = num10 + num11;
					Form2.smethod_1((Control)(object)control_2, Form2.smethod_10("+", string_, "=", num3.ToString()));
					num = (int)(num2 * 1298027350) ^ -877608804;
					continue;
				}
				case 27u:
					flag = Form2.smethod_8(Form2.smethod_7((Control)(object)textBox1), "");
					num = (int)((num2 * 155550242) ^ 0x7DFF4CA);
					continue;
				case 26u:
					num = (int)((num2 * 942332630) ^ 0x5E44F625);
					continue;
				case 25u:
					Form2.smethod_1((Control)(object)label3, "Первым ход делает Компьютер.");
					num = 1509805636;
					continue;
				case 24u:
				{
					int num6;
					int num7;
					if (flag2)
					{
						num6 = -1309217479;
						num7 = -1309217479;
					}
					else
					{
						num6 = -382789378;
						num7 = -382789378;
					}
					num = num6 ^ ((int)num2 * -2035767981);
					continue;
				}
				case 23u:
					Form2.smethod_15((Form)(object)this);
					num = (int)(num2 * 1642151729) ^ -937180497;
					continue;
				case 22u:
					num = 1804252503;
					continue;
				case 21u:
					flag2 = num3 > 1;
					num = (int)(num2 * 743296679) ^ -834029358;
					continue;
				case 20u:
					num = ((int)num2 * -1806971550) ^ -352291213;
					continue;
				case 19u:
					num = ((int)num2 * -1489443642) ^ 0x4FE415DD;
					continue;
				case 18u:
					num = ((int)num2 * -726805416) ^ 0x5D11A7C5;
					continue;
				case 17u:
					num = (int)(num2 * 1210786779) ^ -1593723111;
					continue;
				case 15u:
					(Form2.smethod_2((Form)(object)this) as Form3).Button_Continue();
					num = (int)((num2 * 1128987824) ^ 0x36E80B4E);
					continue;
				case 13u:
				{
					int num12;
					int num13;
					if ((num10 + num11) % 2 != 0)
					{
						num12 = 903734041;
						num13 = 903734041;
					}
					else
					{
						num12 = 1514567412;
						num13 = 1514567412;
					}
					num = num12 ^ ((int)num2 * -276724035);
					continue;
				}
				case 12u:
					num = ((int)num2 * -2141728082) ^ -1120893170;
					continue;
				case 11u:
					num = ((int)num2 * -1461668858) ^ -1374676435;
					continue;
				case 10u:
				{
					int num8;
					int num9;
					if (flag3)
					{
						num8 = -75993180;
						num9 = -75993180;
					}
					else
					{
						num8 = -1621097823;
						num9 = -1621097823;
					}
					num = num8 ^ (int)(num2 * 1363128499);
					continue;
				}
				case 9u:
					flag3 = this.flag;
					num = ((int)num2 * -551430718) ^ 0x275710A1;
					continue;
				case 8u:
					num = 243842877;
					continue;
				case 7u:
					Form2.smethod_14(Form2.smethod_11(Form2.smethod_2((Form)(object)this)));
					num = (int)(num2 * 2020235564) ^ -667211433;
					continue;
				case 6u:
					num = 1886562232;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1383264457;
						num5 = 1383264457;
					}
					else
					{
						num4 = 1014724910;
						num5 = 1014724910;
					}
					num = num4 ^ ((int)num2 * -355838811);
					continue;
				}
				case 4u:
				{
					Form control_ = Form2.smethod_2((Form)(object)this);
					num3 = Form2.smethod_12((Control)(object)control_) - 1;
					Form2.smethod_13((Control)(object)control_, num3);
					num = 2145724748;
					continue;
				}
				case 3u:
					num = ((int)num2 * -1494838485) ^ 0x6D22E44;
					continue;
				case 2u:
					Form2.smethod_1((Control)(object)label3, "Поздравляем! Ваш ход первый.");
					num = ((int)num2 * -1125601595) ^ -897574483;
					continue;
				case 1u:
					num = ((int)num2 * -1024298728) ^ -1127429851;
					continue;
				case 0u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).StartGame();
					num = (int)((num2 * 1420302812) ^ 0x3138634E);
					continue;
				default:
					return;
				case 16u:
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
			goto IL_0047;
		}
		int num = 0;
		goto IL_008c;
		IL_0083:
		num = ((components != null) ? 1 : 0);
		goto IL_008c;
		IL_0047:
		int num2 = -1370254582;
		goto IL_005a;
		IL_005a:
		bool flag = default(bool);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0xFE75DC2Au) % 6u)
			{
			case 5u:
			{
				int num4;
				int num5;
				if (!flag)
				{
					num4 = 1981515830;
					num5 = 1981515830;
				}
				else
				{
					num4 = 154332720;
					num5 = 154332720;
				}
				num2 = num4 ^ (int)(num3 * 1664487991);
				continue;
			}
			case 3u:
				Form2.smethod_16((IDisposable)components);
				num2 = ((int)num3 * -1921309276) ^ 0x2BB5B647;
				continue;
			case 2u:
				break;
			case 1u:
				((Form)this).Dispose(disposing);
				num2 = -673188532;
				continue;
			default:
				return;
			case 4u:
				goto IL_0083;
			case 0u:
				return;
			}
			break;
		}
		goto IL_0047;
		IL_008c:
		flag = (byte)num != 0;
		num2 = -86926031;
		goto IL_005a;
	}

	private void InitializeComponent()
	{
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0533: Unknown result type (might be due to invalid IL or missing references)
		//IL_053d: Expected O, but got Unknown
		label1 = Form2.smethod_17();
		textBox1 = Form2.smethod_18();
		label2 = Form2.smethod_17();
		button1 = Form2.smethod_19();
		while (true)
		{
			int num = 941194529;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x70EA6100u) % 65u)
				{
				case 64u:
					num = (int)((num2 * 490151728) ^ 0x4B687EC4);
					continue;
				case 63u:
					num = ((int)num2 * -382515875) ^ -1643597631;
					continue;
				case 62u:
					Form2.smethod_21((Control)(object)label1, bool_0: true);
					num = (int)(num2 * 1717147895) ^ -873535646;
					continue;
				case 61u:
					Form2.smethod_22((Control)(object)label1, new Point(10, 10));
					num = (int)((num2 * 1003656579) ^ 0x503A2B87);
					continue;
				case 60u:
					num = ((int)num2 * -1226358176) ^ 0x667DB502;
					continue;
				case 59u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)textBox1);
					num = (int)(num2 * 1139346360) ^ -1544946725;
					continue;
				case 58u:
					Form2.smethod_38((Form)(object)this, bool_0: false);
					Form2.smethod_39((Control)(object)this, "Form2");
					Form2.smethod_40((Form)(object)this, bool_0: false);
					num = ((int)num2 * -405792020) ^ -129913240;
					continue;
				case 57u:
					Form2.smethod_25((Control)(object)textBox1, 1);
					num = (int)(num2 * 1764158255) ^ -2008846163;
					continue;
				case 56u:
					Form2.smethod_41((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
					num = ((int)num2 * -2147373396) ^ 0x465326E8;
					continue;
				case 55u:
					Form2.smethod_1((Control)(object)button1, "OK");
					num = (int)(num2 * 1297629745) ^ -1626884687;
					continue;
				case 54u:
					num = (int)((num2 * 1853362143) ^ 0x5EAA840A);
					continue;
				case 53u:
					Form2.smethod_42((Control)(object)this, bool_0: false);
					num = ((int)num2 * -1991726958) ^ 0x519E9A75;
					continue;
				case 52u:
					num = ((int)num2 * -1953403419) ^ -365183061;
					continue;
				case 51u:
					Form2.smethod_27((Control)(object)textBox1, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1411333341) ^ -1713551047;
					continue;
				case 50u:
					num = ((int)num2 * -158452960) ^ 0x5521BE14;
					continue;
				case 49u:
					Form2.smethod_1((Control)(object)label2, "+N=?");
					num = ((int)num2 * -240627046) ^ -1199743688;
					continue;
				case 48u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label1);
					num = (int)((num2 * 1760616192) ^ 0x90A4905);
					continue;
				case 47u:
					Form2.smethod_33((Form)(object)this, new Size(255, 224));
					num = (int)((num2 * 1343349081) ^ 0x46D046D1);
					continue;
				case 46u:
					label3 = Form2.smethod_17();
					num = (int)(num2 * 508355096) ^ -467914953;
					continue;
				case 45u:
					Form2.smethod_20((Control)(object)this);
					num = ((int)num2 * -791097805) ^ -2130230142;
					continue;
				case 44u:
					Form2.smethod_23((Control)(object)label1, "label1");
					num = (int)(num2 * 331711738) ^ -2141203333;
					continue;
				case 43u:
					Form2.smethod_23((Control)(object)label3, "label3");
					num = ((int)num2 * -40431340) ^ -1837635303;
					continue;
				case 42u:
					Form2.smethod_25((Control)(object)button1, 3);
					num = (int)((num2 * 812534697) ^ 0x2EF68337);
					continue;
				case 41u:
					Form2.smethod_25((Control)(object)label1, 0);
					num = ((int)num2 * -1137783083) ^ -232863412;
					continue;
				case 39u:
					num = (int)(num2 * 1571797766) ^ -1487169713;
					continue;
				case 38u:
					Form2.smethod_24((Control)(object)textBox1, new Size(42, 80));
					num = (int)((num2 * 535499926) ^ 0x7B24C331);
					continue;
				case 37u:
					Form2.smethod_22((Control)(object)textBox1, new Point(24, 86));
					num = ((int)num2 * -540191933) ^ 0x32B8C34C;
					continue;
				case 36u:
					Form2.smethod_36((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -623285137) ^ 0x385C81DD;
					continue;
				case 35u:
					Form2.smethod_27((Control)(object)label2, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -552769248) ^ -1760322941;
					continue;
				case 34u:
					Form2.smethod_24((Control)(object)label1, new Size(35, 13));
					num = (int)(num2 * 595090205) ^ -114278660;
					continue;
				case 33u:
					num = (int)((num2 * 1445581772) ^ 0x47AC771);
					continue;
				case 32u:
					num = ((int)num2 * -1716172135) ^ 0x3CA04200;
					continue;
				case 31u:
					num = ((int)num2 * -1763137843) ^ -61522149;
					continue;
				case 30u:
					Form2.smethod_23((Control)(object)label2, "label2");
					Form2.smethod_24((Control)(object)label2, new Size(188, 73));
					Form2.smethod_25((Control)(object)label2, 2);
					num = (int)((num2 * 49956068) ^ 0x72FDF848);
					continue;
				case 28u:
					Form2.smethod_24((Control)(object)label3, new Size(0, 13));
					num = ((int)num2 * -1496638672) ^ 0x5EE0B4CA;
					continue;
				case 27u:
					Form2.smethod_1((Control)(object)label1, "label1");
					num = ((int)num2 * -287859954) ^ 0x5DE18365;
					continue;
				case 26u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label2);
					num = (int)((num2 * 902132439) ^ 0x68C4744);
					continue;
				case 25u:
					num = (int)((num2 * 1025328749) ^ 0x328FC10B);
					continue;
				case 24u:
					num = ((int)num2 * -2144280467) ^ -1352004634;
					continue;
				case 23u:
					num = ((int)num2 * -1731233271) ^ 0x732ECFE;
					continue;
				case 22u:
					Form2.smethod_22((Control)(object)label3, new Point(47, 177));
					num = ((int)num2 * -354925363) ^ -2010215769;
					continue;
				case 21u:
					num = ((int)num2 * -1011176229) ^ -831555905;
					continue;
				case 20u:
					Form2.smethod_28((Control)(object)textBox1, new KeyPressEventHandler(TextBox1_KeyPress));
					Form2.smethod_21((Control)(object)label2, bool_0: true);
					num = ((int)num2 * -1074422299) ^ 0x771BE49B;
					continue;
				case 19u:
					num = ((int)num2 * -156176567) ^ -1853703543;
					continue;
				case 18u:
					Form2.smethod_37((Form)(object)this, bool_0: false);
					num = (int)((num2 * 1573114093) ^ 0x5381FB39);
					continue;
				case 17u:
					num = (int)(num2 * 1465319458) ^ -1084725146;
					continue;
				case 16u:
					num = (int)((num2 * 2083800396) ^ 0x48F9F33E);
					continue;
				case 15u:
					Form2.smethod_29((ButtonBase)(object)button1, bool_0: true);
					Form2.smethod_30((Control)(object)button1, (EventHandler)Button1_Click);
					Form2.smethod_21((Control)(object)label3, bool_0: true);
					num = (int)(num2 * 2016005867) ^ -1223816098;
					continue;
				case 14u:
					Form2.smethod_23((Control)(object)button1, "button1");
					num = (int)(num2 * 329764087) ^ -792952631;
					continue;
				case 13u:
					Form2.smethod_22((Control)(object)label2, new Point(53, 89));
					num = (int)((num2 * 945084215) ^ 0x770956E9);
					continue;
				case 12u:
					Form2.smethod_1((Control)(object)this, "Жеребьёвка");
					num = ((int)num2 * -1800880137) ^ -1856457974;
					continue;
				case 11u:
					num = ((int)num2 * -77834685) ^ 0x653E12B5;
					continue;
				case 10u:
					num = (int)(num2 * 705433022) ^ -1647786580;
					continue;
				case 9u:
					num = ((int)num2 * -2088853988) ^ 0x509FB9CE;
					continue;
				case 8u:
					Form2.smethod_31((ContainerControl)(object)this, new SizeF(6f, 13f));
					Form2.smethod_32((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 852262083) ^ -946147694;
					continue;
				case 7u:
					Form2.smethod_43((Control)(object)this);
					num = ((int)num2 * -197665419) ^ -1084439670;
					continue;
				case 6u:
					num = ((int)num2 * -136499386) ^ -1692729255;
					continue;
				case 5u:
					num = (int)(num2 * 1028641540) ^ -319218583;
					continue;
				case 4u:
					Form2.smethod_24((Control)(object)button1, new Size(73, 23));
					num = ((int)num2 * -706590324) ^ 0x2710C90D;
					continue;
				case 3u:
					Form2.smethod_22((Control)(object)button1, new Point(86, 193));
					num = ((int)num2 * -1591574153) ^ 0x710A5A8A;
					continue;
				case 2u:
					Form2.smethod_25((Control)(object)label3, 4);
					num = ((int)num2 * -979085027) ^ 0x42D5E5D1;
					continue;
				case 1u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label3);
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)button1);
					num = (int)(num2 * 1007242135) ^ -692265716;
					continue;
				case 0u:
					Form2.smethod_23((Control)(object)textBox1, "textBox1");
					num = ((int)num2 * -498140463) ^ 0x19E018DC;
					continue;
				default:
					return;
				case 40u:
					break;
				case 29u:
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
