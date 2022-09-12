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
			int num = -383331276;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCD2B7F52u) % 7u)
				{
				case 6u:
					InitializeComponent();
					num = (int)(num2 * 1304420370) ^ -469386016;
					continue;
				case 5u:
					Form2.smethod_1((Control)(object)label1, "Введите любое число от 0 до 9 включительно.\nВаш соперник уже загадал число (N) из этого\nже диапазона. Если сумма ваших чисел будет\nчетным числом, то первым ход делаете Вы,\nиначе - ваш соперник Компьютер!");
					num = ((int)num2 * -311637116) ^ -545663267;
					continue;
				case 4u:
					num = ((int)num2 * -1402657172) ^ 0x3F1DF99F;
					continue;
				case 3u:
					num = (int)(num2 * 709841797) ^ -633781627;
					continue;
				case 1u:
					num = ((int)num2 * -1606862266) ^ 0x29419FAE;
					continue;
				default:
					return;
				case 2u:
					break;
				case 0u:
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
			int num = 854087537;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x139BAE78u) % 3u)
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
				num = (int)((num2 * 50929726) ^ 0x375031A5);
			}
		}
	}

	private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		bool flag = !char.IsDigit(Form2.smethod_4(e));
		while (true)
		{
			int num = -706951895;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFCFCE5E8u) % 9u)
				{
				case 7u:
					Form2.smethod_5(e, bool_0: true);
					num = ((int)num2 * -1046505148) ^ 0x64B01AD7;
					continue;
				case 6u:
					Form2.smethod_1((Control)(object)textBox1, "");
					num = -1579653978;
					continue;
				case 5u:
				{
					int num5;
					if (Form2.smethod_4(e) != '\r')
					{
						num = -1218298374;
						num5 = -1218298374;
					}
					else
					{
						num = -577311184;
						num5 = -577311184;
					}
					continue;
				}
				case 4u:
					num = (int)((num2 * 709341601) ^ 0x6F1D898D);
					continue;
				case 3u:
					num = ((int)num2 * -2002016889) ^ -1898268892;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -649253657;
						num4 = -649253657;
					}
					else
					{
						num3 = -1193232432;
						num4 = -1193232432;
					}
					num = num3 ^ (int)(num2 * 1260137562);
					continue;
				}
				case 0u:
					Button1_Click(this, Form2.smethod_6());
					num = (int)(num2 * 1537068036) ^ -1510837606;
					continue;
				default:
					return;
				case 8u:
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
		int num7 = default(int);
		bool flag2 = default(bool);
		int num5 = default(int);
		int num6 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 2078901781;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF34CD6Au) % 29u)
				{
				case 28u:
				{
					int num12;
					int num13;
					if (!Form2.smethod_8(Form2.smethod_7((Control)(object)textBox1), ""))
					{
						num12 = 95250136;
						num13 = 95250136;
					}
					else
					{
						num12 = 1806624019;
						num13 = 1806624019;
					}
					num = num12 ^ (int)(num2 * 1355572691);
					continue;
				}
				case 27u:
				{
					Form control_2 = Form2.smethod_2((Form)(object)this);
					num7 = Form2.smethod_12((Control)(object)control_2) - 1;
					Form2.smethod_13((Control)(object)control_2, num7);
					num = 1942559074;
					continue;
				}
				case 26u:
					num = ((int)num2 * -230913365) ^ -1021893000;
					continue;
				case 24u:
					num = 1585712494;
					continue;
				case 23u:
					num = 1199880198;
					continue;
				case 22u:
					num = ((int)num2 * -1187428514) ^ 0x51684259;
					continue;
				case 20u:
					this.flag = false;
					num = 1765329766;
					continue;
				case 19u:
					flag2 = (num5 + num6) % 2 == 0;
					num = (int)((num2 * 108928980) ^ 0x3F94BCE0);
					continue;
				case 18u:
					Form2.smethod_1((Control)(object)label3, "Первым ход делает Компьютер.");
					num = (int)(num2 * 2026759255) ^ -553891203;
					continue;
				case 17u:
				{
					int num10;
					int num11;
					if (flag2)
					{
						num10 = 681981919;
						num11 = 681981919;
					}
					else
					{
						num10 = 634923984;
						num11 = 634923984;
					}
					num = num10 ^ (int)(num2 * 1122438414);
					continue;
				}
				case 16u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).StartGame();
					Form2.smethod_15((Form)(object)this);
					num = (int)((num2 * 1728567382) ^ 0x2BAF1029);
					continue;
				case 15u:
					num5 = int.Parse(Form2.smethod_7((Control)(object)textBox1));
					num6 = Form2.smethod_9(rnd, 10);
					num = ((int)num2 * -1582347861) ^ 0x1E66B74A;
					continue;
				case 14u:
					(Form2.smethod_2((Form)(object)this) as Form3).Button_Continue();
					num = (int)((num2 * 1281421037) ^ 0x293819F9);
					continue;
				case 13u:
					num = ((int)num2 * -1474189774) ^ 0x3003F31C;
					continue;
				case 12u:
					flag = this.flag;
					num = ((int)num2 * -330242797) ^ 0x78043464;
					continue;
				case 11u:
				{
					Label control_ = label2;
					string string_ = num6.ToString();
					num7 = num5 + num6;
					Form2.smethod_1((Control)(object)control_, Form2.smethod_10("+", string_, "=", num7.ToString()));
					num = ((int)num2 * -998136289) ^ 0x3ABE6D9B;
					continue;
				}
				case 10u:
				{
					int num8;
					int num9;
					if (num7 > 1)
					{
						num8 = 87582823;
						num9 = 87582823;
					}
					else
					{
						num8 = 1195909944;
						num9 = 1195909944;
					}
					num = num8 ^ (int)(num2 * 614640471);
					continue;
				}
				case 9u:
					Form2.smethod_14(Form2.smethod_11(Form2.smethod_2((Form)(object)this)));
					num = (int)((num2 * 163237229) ^ 0x6DA293A8);
					continue;
				case 8u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -180018721;
						num4 = -180018721;
					}
					else
					{
						num3 = -716337155;
						num4 = -716337155;
					}
					num = num3 ^ ((int)num2 * -986388357);
					continue;
				}
				case 7u:
					num = (int)(num2 * 1073433221) ^ -214823547;
					continue;
				case 6u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = true;
					num = ((int)num2 * -1165479685) ^ -1648627827;
					continue;
				case 5u:
					num = (int)((num2 * 1820627075) ^ 0x11567C9D);
					continue;
				case 4u:
					Form2.smethod_1((Control)(object)label3, "Поздравляем! Ваш ход первый.");
					num = ((int)num2 * -768485131) ^ 0xC8F1390;
					continue;
				case 3u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = false;
					num = (int)(num2 * 1000446454) ^ -1022498758;
					continue;
				case 2u:
					num = 2144285301;
					continue;
				case 1u:
					num = 1199880198;
					continue;
				case 0u:
					num = ((int)num2 * -1548787052) ^ -1975584813;
					continue;
				default:
					return;
				case 25u:
					break;
				case 21u:
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
		goto IL_0016;
		IL_0016:
		int num = 1189858523;
		goto IL_0061;
		IL_0061:
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x6A7A9EA0u) % 7u)
			{
			case 6u:
				break;
			case 5u:
				Form2.smethod_16((IDisposable)components);
				num = ((int)num2 * -2102383604) ^ 0x5569A8C3;
				continue;
			case 4u:
				((Form)this).Dispose(disposing);
				num = 688460598;
				continue;
			case 2u:
				num = ((int)num2 * -1950594276) ^ 0x2CDF9968;
				continue;
			case 0u:
				num = ((int)num2 * -1758442367) ^ -846440488;
				continue;
			default:
				return;
			case 1u:
				goto IL_008e;
			case 3u:
				return;
			}
			break;
			IL_008e:
			if (components != null)
			{
				num = 768554228;
				num3 = 768554228;
				continue;
			}
			goto IL_0009;
		}
		goto IL_0016;
		IL_0009:
		num = 300664060;
		num3 = 300664060;
		goto IL_0061;
	}

	private void InitializeComponent()
	{
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got Unknown
		//IL_0723: Unknown result type (might be due to invalid IL or missing references)
		//IL_072d: Expected O, but got Unknown
		while (true)
		{
			int num = -1356338757;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x94A033E8u) % 69u)
				{
				case 68u:
					num = ((int)num2 * -163969808) ^ -419370649;
					continue;
				case 67u:
					Form2.smethod_27((Control)(object)textBox1, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1913823151) ^ 0x4150B8B;
					continue;
				case 66u:
					num = ((int)num2 * -71958251) ^ -2004512050;
					continue;
				case 65u:
					Form2.smethod_42((Control)(object)this, bool_0: false);
					Form2.smethod_43((Control)(object)this);
					num = ((int)num2 * -253417474) ^ 0x66F709B9;
					continue;
				case 64u:
					num = (int)(num2 * 262341008) ^ -1059327337;
					continue;
				case 63u:
					num = ((int)num2 * -931583282) ^ 0x40DB79A6;
					continue;
				case 62u:
					Form2.smethod_24((Control)(object)label1, new Size(35, 13));
					num = ((int)num2 * -1796941) ^ 0xC6BFFD5;
					continue;
				case 61u:
					Form2.smethod_31((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -1131005545) ^ -1515368752;
					continue;
				case 60u:
					num = ((int)num2 * -333463793) ^ -780950895;
					continue;
				case 59u:
					Form2.smethod_25((Control)(object)button1, 3);
					num = (int)((num2 * 80247006) ^ 0x4C1AE8A3);
					continue;
				case 58u:
					Form2.smethod_25((Control)(object)label3, 4);
					num = (int)((num2 * 1497581125) ^ 0x4E1CDC62);
					continue;
				case 57u:
					Form2.smethod_1((Control)(object)button1, "OK");
					num = (int)(num2 * 898273823) ^ -1534202751;
					continue;
				case 56u:
					Form2.smethod_21((Control)(object)label3, bool_0: true);
					num = (int)(num2 * 726794173) ^ -563053586;
					continue;
				case 54u:
					Form2.smethod_38((Form)(object)this, bool_0: false);
					num = (int)(num2 * 129445263) ^ -1233110944;
					continue;
				case 53u:
					num = ((int)num2 * -944200361) ^ 0x492154C4;
					continue;
				case 52u:
					Form2.smethod_25((Control)(object)label1, 0);
					num = (int)((num2 * 133732789) ^ 0x41BFCFA6);
					continue;
				case 51u:
					Form2.smethod_23((Control)(object)button1, "button1");
					num = ((int)num2 * -1569336130) ^ -277010303;
					continue;
				case 50u:
					num = ((int)num2 * -125100687) ^ -514437799;
					continue;
				case 49u:
					Form2.smethod_33((Form)(object)this, new Size(255, 224));
					num = ((int)num2 * -1178981263) ^ -572424359;
					continue;
				case 48u:
					Form2.smethod_22((Control)(object)label2, new Point(53, 89));
					Form2.smethod_23((Control)(object)label2, "label2");
					Form2.smethod_24((Control)(object)label2, new Size(188, 73));
					num = ((int)num2 * -1248817285) ^ 0x4E096A3C;
					continue;
				case 46u:
					Form2.smethod_32((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -514524980) ^ 0x1DA7B583;
					continue;
				case 45u:
					num = ((int)num2 * -1128366414) ^ 0x481C8197;
					continue;
				case 44u:
					Form2.smethod_23((Control)(object)label1, "label1");
					num = (int)((num2 * 591913605) ^ 0x61C73F52);
					continue;
				case 43u:
					Form2.smethod_41((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
					num = ((int)num2 * -364868160) ^ -1013606944;
					continue;
				case 42u:
					Form2.smethod_1((Control)(object)label2, "+N=?");
					num = (int)(num2 * 902418725) ^ -1576217111;
					continue;
				case 41u:
					num = (int)((num2 * 1513557555) ^ 0x20E76C61);
					continue;
				case 40u:
					Form2.smethod_1((Control)(object)label1, "label1");
					num = (int)(num2 * 1440568051) ^ -2143217204;
					continue;
				case 39u:
					Form2.smethod_24((Control)(object)label3, new Size(0, 13));
					num = (int)(num2 * 1130210175) ^ -931513715;
					continue;
				case 38u:
					Form2.smethod_22((Control)(object)label1, new Point(10, 10));
					num = (int)(num2 * 555362446) ^ -315648711;
					continue;
				case 37u:
					textBox1 = Form2.smethod_18();
					label2 = Form2.smethod_17();
					num = ((int)num2 * -1427534942) ^ 0x490E81D0;
					continue;
				case 36u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label2);
					num = (int)(num2 * 719410962) ^ -240150484;
					continue;
				case 35u:
					num = ((int)num2 * -1911060195) ^ -1819000812;
					continue;
				case 34u:
					Form2.smethod_22((Control)(object)textBox1, new Point(24, 86));
					Form2.smethod_23((Control)(object)textBox1, "textBox1");
					num = ((int)num2 * -1398662970) ^ 0x366927FE;
					continue;
				case 33u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label1);
					num = (int)((num2 * 1800432481) ^ 0x4DC6A5E2);
					continue;
				case 32u:
					num = ((int)num2 * -939910688) ^ 0x6A3F7146;
					continue;
				case 31u:
					Form2.smethod_1((Control)(object)this, "Жеребьёвка");
					num = ((int)num2 * -1553748846) ^ -1501981642;
					continue;
				case 30u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)textBox1);
					num = ((int)num2 * -33704418) ^ 0x5584335B;
					continue;
				case 29u:
					num = (int)((num2 * 446097633) ^ 0x4684334C);
					continue;
				case 28u:
					num = (int)(num2 * 382639397) ^ -380960356;
					continue;
				case 27u:
					Form2.smethod_21((Control)(object)label1, bool_0: true);
					num = (int)(num2 * 1488071589) ^ -1063930043;
					continue;
				case 26u:
					Form2.smethod_22((Control)(object)label3, new Point(47, 177));
					Form2.smethod_23((Control)(object)label3, "label3");
					num = ((int)num2 * -552499701) ^ -1329520174;
					continue;
				case 25u:
					Form2.smethod_24((Control)(object)textBox1, new Size(42, 80));
					num = (int)(num2 * 588300965) ^ -1824106453;
					continue;
				case 24u:
					Form2.smethod_25((Control)(object)label2, 2);
					num = ((int)num2 * -1391620743) ^ -1332213949;
					continue;
				case 23u:
					num = ((int)num2 * -262204438) ^ -585806914;
					continue;
				case 22u:
					Form2.smethod_30((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -1303082025) ^ 0x7C80E206;
					continue;
				case 21u:
					Form2.smethod_27((Control)(object)label2, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 1194809720) ^ 0x7C931490);
					continue;
				case 20u:
					Form2.smethod_29((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -117317181) ^ 0x2C5E69DA;
					continue;
				case 19u:
					num = (int)((num2 * 989912514) ^ 0x7DD2FE19);
					continue;
				case 18u:
					button1 = Form2.smethod_19();
					label3 = Form2.smethod_17();
					num = (int)(num2 * 505143477) ^ -1999630051;
					continue;
				case 17u:
					num = (int)(num2 * 1177871656) ^ -2102007256;
					continue;
				case 16u:
					Form2.smethod_22((Control)(object)button1, new Point(86, 193));
					num = ((int)num2 * -102212236) ^ 0x31C9D9ED;
					continue;
				case 15u:
					num = ((int)num2 * -1980843558) ^ -1704934636;
					continue;
				case 14u:
					Form2.smethod_39((Control)(object)this, "Form2");
					num = (int)(num2 * 152960637) ^ -485332964;
					continue;
				case 13u:
					num = ((int)num2 * -957176362) ^ 0x5276C605;
					continue;
				case 12u:
					Form2.smethod_25((Control)(object)textBox1, 1);
					num = (int)(num2 * 1690742729) ^ -1075793961;
					continue;
				case 11u:
					num = (int)(num2 * 818745952) ^ -482994157;
					continue;
				case 10u:
					Form2.smethod_37((Form)(object)this, bool_0: false);
					num = (int)(num2 * 757771872) ^ -976882611;
					continue;
				case 9u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)button1);
					num = (int)((num2 * 161930753) ^ 0x6CA346E3);
					continue;
				case 8u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label3);
					num = (int)(num2 * 935795440) ^ -1462923041;
					continue;
				case 7u:
					Form2.smethod_28((Control)(object)textBox1, new KeyPressEventHandler(TextBox1_KeyPress));
					Form2.smethod_21((Control)(object)label2, bool_0: true);
					num = ((int)num2 * -1994869316) ^ 0x47C6DDBC;
					continue;
				case 6u:
					num = ((int)num2 * -1006563199) ^ 0x67E51A12;
					continue;
				case 5u:
					Form2.smethod_36((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -1291948256) ^ -887193217;
					continue;
				case 4u:
					Form2.smethod_20((Control)(object)this);
					num = (int)(num2 * 694642981) ^ -316310284;
					continue;
				case 3u:
					label1 = Form2.smethod_17();
					num = ((int)num2 * -294033651) ^ -658213941;
					continue;
				case 2u:
					num = (int)((num2 * 2128357432) ^ 0x3AC3F258);
					continue;
				case 1u:
					Form2.smethod_24((Control)(object)button1, new Size(73, 23));
					num = ((int)num2 * -368372340) ^ 0x1E8DC8A6;
					continue;
				case 0u:
					Form2.smethod_40((Form)(object)this, bool_0: false);
					num = ((int)num2 * -119733804) ^ -1550929582;
					continue;
				default:
					return;
				case 55u:
					break;
				case 47u:
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
