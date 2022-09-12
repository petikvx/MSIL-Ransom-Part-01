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
		while (true)
		{
			int num = 1256803823;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x61383840u) % 3u)
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
				num = (int)(num2 * 1548235145) ^ -2141470235;
			}
		}
	}

	private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -1677462394;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBD50FB43u) % 12u)
				{
				case 11u:
					num = ((int)num2 * -1025238780) ^ -2009849561;
					continue;
				case 9u:
					num = ((int)num2 * -1827983764) ^ -1474743799;
					continue;
				case 8u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = -159886892;
						num6 = -159886892;
					}
					else
					{
						num5 = -1695338507;
						num6 = -1695338507;
					}
					num = num5 ^ ((int)num2 * -1895385456);
					continue;
				}
				case 7u:
					Button1_Click(this, Form2.smethod_6());
					num = ((int)num2 * -1155797392) ^ 0x736C819E;
					continue;
				case 5u:
					Form2.smethod_1((Control)(object)textBox1, "");
					num = -1321716449;
					continue;
				case 4u:
					flag2 = Form2.smethod_4(e) == '\r';
					num = -508964453;
					continue;
				case 3u:
					Form2.smethod_5(e, bool_0: true);
					num = ((int)num2 * -1558305796) ^ 0x78CF3410;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 824859060;
						num4 = 824859060;
					}
					else
					{
						num3 = 980889882;
						num4 = 980889882;
					}
					num = num3 ^ ((int)num2 * -356068264);
					continue;
				}
				case 1u:
					flag = !char.IsDigit(Form2.smethod_4(e));
					num = ((int)num2 * -936580424) ^ -1213108799;
					continue;
				case 0u:
					num = ((int)num2 * -1642613227) ^ 0x52C2577;
					continue;
				default:
					return;
				case 10u:
					break;
				case 6u:
					return;
				}
				break;
			}
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		bool flag = default(bool);
		int num8 = default(int);
		int num9 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = 551030679;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5F31BDC5u) % 34u)
				{
				case 33u:
					num = (int)(num2 * 727547261) ^ -997320856;
					continue;
				case 32u:
					Form2.smethod_15((Form)(object)this);
					num = ((int)num2 * -1440360398) ^ -394868132;
					continue;
				case 31u:
					num = 1007674435;
					continue;
				case 30u:
					(Form2.smethod_2((Form)(object)this) as Form3).Button_Continue();
					num = (int)((num2 * 1885576837) ^ 0x38E35BCC);
					continue;
				case 29u:
				{
					int num12;
					int num13;
					if (flag)
					{
						num12 = -1931488642;
						num13 = -1931488642;
					}
					else
					{
						num12 = -1348815424;
						num13 = -1348815424;
					}
					num = num12 ^ ((int)num2 * -434496253);
					continue;
				}
				case 28u:
				{
					int num6;
					int num7;
					if (!this.flag)
					{
						num6 = -1884113673;
						num7 = -1884113673;
					}
					else
					{
						num6 = -509126314;
						num7 = -509126314;
					}
					num = num6 ^ (int)(num2 * 425814134);
					continue;
				}
				case 26u:
					Form2.smethod_14(Form2.smethod_11(Form2.smethod_2((Form)(object)this)));
					num = ((int)num2 * -1485959273) ^ 0x6B43BCA8;
					continue;
				case 25u:
					num = (int)((num2 * 1937203367) ^ 0x787FA94C);
					continue;
				case 24u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = false;
					num = (int)(num2 * 405386969) ^ -2020932434;
					continue;
				case 23u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = true;
					num = (int)((num2 * 1038954027) ^ 0x218186CC);
					continue;
				case 22u:
					num = ((int)num2 * -1120019988) ^ -884653310;
					continue;
				case 21u:
					flag = num8 > 1;
					num = ((int)num2 * -650690898) ^ -1365120748;
					continue;
				case 20u:
					this.flag = false;
					num = 1716017672;
					continue;
				case 19u:
					num = ((int)num2 * -83690272) ^ 0x436D3C86;
					continue;
				case 18u:
					num = ((int)num2 * -110762522) ^ -2087947747;
					continue;
				case 17u:
					num = ((int)num2 * -236979550) ^ -186839852;
					continue;
				case 16u:
					num9 = int.Parse(Form2.smethod_7((Control)(object)textBox1));
					num = (int)((num2 * 509903041) ^ 0x5CDB9BE);
					continue;
				case 15u:
					Form2.smethod_1((Control)(object)label3, "Поздравляем! Ваш ход первый.");
					num = (int)((num2 * 1183116588) ^ 0x18E83FC9);
					continue;
				case 14u:
				{
					Label control_2 = label2;
					string string_ = num3.ToString();
					num8 = num9 + num3;
					Form2.smethod_1((Control)(object)control_2, Form2.smethod_10("+", string_, "=", num8.ToString()));
					num = (int)(num2 * 2099896641) ^ -614986482;
					continue;
				}
				case 13u:
				{
					int num10;
					int num11;
					if ((num9 + num3) % 2 == 0)
					{
						num10 = -381519207;
						num11 = -381519207;
					}
					else
					{
						num10 = -1083943523;
						num11 = -1083943523;
					}
					num = num10 ^ (int)(num2 * 1809719499);
					continue;
				}
				case 12u:
				{
					Form control_ = Form2.smethod_2((Form)(object)this);
					num8 = Form2.smethod_12((Control)(object)control_) - 1;
					Form2.smethod_13((Control)(object)control_, num8);
					num = 225011769;
					continue;
				}
				case 11u:
					num = (int)((num2 * 1995095350) ^ 0x53D211D9);
					continue;
				case 9u:
					num = ((int)num2 * -1824970794) ^ -1762804939;
					continue;
				case 8u:
				{
					int num4;
					int num5;
					if (Form2.smethod_8(Form2.smethod_7((Control)(object)textBox1), ""))
					{
						num4 = 893367372;
						num5 = 893367372;
					}
					else
					{
						num4 = 1320787691;
						num5 = 1320787691;
					}
					num = num4 ^ ((int)num2 * -994232012);
					continue;
				}
				case 7u:
					num = 783237568;
					continue;
				case 6u:
					num = ((int)num2 * -142140760) ^ 0x6B643656;
					continue;
				case 5u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).StartGame();
					num = ((int)num2 * -829963334) ^ 0x12792B43;
					continue;
				case 4u:
					num = 2019675653;
					continue;
				case 3u:
					num3 = Form2.smethod_9(rnd, 10);
					num = ((int)num2 * -1715358691) ^ 0x2D4E3FEA;
					continue;
				case 2u:
					num = 924765341;
					continue;
				case 1u:
					Form2.smethod_1((Control)(object)label3, "Первым ход делает Компьютер.");
					num = (int)(num2 * 1864008859) ^ -1085403656;
					continue;
				case 0u:
					num = (int)(num2 * 255335230) ^ -664797101;
					continue;
				default:
					return;
				case 27u:
					break;
				case 10u:
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
			goto IL_0018;
		}
		int num = 0;
		goto IL_00a0;
		IL_00a0:
		bool flag = (byte)num != 0;
		int num2 = -1068787469;
		goto IL_006a;
		IL_0018:
		num2 = -1693970986;
		goto IL_006a;
		IL_006a:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0xF717EC54u) % 7u)
			{
			case 6u:
				num2 = ((int)num3 * -1119609885) ^ 0x129A66C9;
				continue;
			case 5u:
				break;
			case 4u:
				num2 = ((int)num3 * -396911112) ^ 0x2E16AD66;
				continue;
			case 2u:
			{
				int num4;
				int num5;
				if (!flag)
				{
					num4 = 1245605423;
					num5 = 1245605423;
				}
				else
				{
					num4 = 1537436237;
					num5 = 1537436237;
				}
				num2 = num4 ^ ((int)num3 * -1507820169);
				continue;
			}
			case 0u:
				Form2.smethod_16((IDisposable)components);
				num2 = ((int)num3 * -1893972131) ^ 0x6384C5D6;
				continue;
			case 3u:
				goto IL_0097;
			default:
				((Form)this).Dispose(disposing);
				return;
			}
			break;
		}
		goto IL_0018;
		IL_0097:
		num = ((components != null) ? 1 : 0);
		goto IL_00a0;
	}

	private void InitializeComponent()
	{
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Expected O, but got Unknown
		//IL_0898: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a2: Expected O, but got Unknown
		label1 = Form2.smethod_17();
		textBox1 = Form2.smethod_18();
		while (true)
		{
			int num = -1095703737;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF27E34E1u) % 64u)
				{
				case 63u:
					Form2.smethod_25((Control)(object)button1, 3);
					num = ((int)num2 * -1922744860) ^ -287010154;
					continue;
				case 61u:
					Form2.smethod_23((Control)(object)label3, "label3");
					Form2.smethod_24((Control)(object)label3, new Size(0, 13));
					num = ((int)num2 * -1416465861) ^ 0x34F6825;
					continue;
				case 60u:
					num = (int)((num2 * 1640562320) ^ 0x25F15177);
					continue;
				case 59u:
					num = ((int)num2 * -872617131) ^ 0x1F1D0088;
					continue;
				case 58u:
					Form2.smethod_38((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1304945404) ^ -416267031;
					continue;
				case 57u:
					Form2.smethod_33((Form)(object)this, new Size(255, 224));
					num = ((int)num2 * -1677845228) ^ -1679109876;
					continue;
				case 56u:
					Form2.smethod_22((Control)(object)label2, new Point(53, 89));
					num = (int)((num2 * 528443675) ^ 0x4FA8E935);
					continue;
				case 55u:
					Form2.smethod_24((Control)(object)button1, new Size(73, 23));
					num = (int)((num2 * 2062428080) ^ 0x5479DB02);
					continue;
				case 54u:
					num = (int)(num2 * 1088740443) ^ -2021368312;
					continue;
				case 53u:
					num = (int)(num2 * 536023811) ^ -793782467;
					continue;
				case 52u:
					Form2.smethod_37((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1860850045) ^ 0x2B2CEFF5;
					continue;
				case 51u:
					num = (int)((num2 * 1600849048) ^ 0x2316CC16);
					continue;
				case 50u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)button1);
					num = (int)(num2 * 329860405) ^ -1671574153;
					continue;
				case 49u:
					num = (int)(num2 * 763576048) ^ -878466868;
					continue;
				case 48u:
					label3 = Form2.smethod_17();
					Form2.smethod_20((Control)(object)this);
					num = (int)(num2 * 897484598) ^ -163616000;
					continue;
				case 47u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label3);
					num = ((int)num2 * -1248203827) ^ 0x75E558B0;
					continue;
				case 46u:
					Form2.smethod_24((Control)(object)label2, new Size(188, 73));
					num = ((int)num2 * -692358875) ^ -2120183658;
					continue;
				case 45u:
					Form2.smethod_22((Control)(object)label1, new Point(10, 10));
					Form2.smethod_23((Control)(object)label1, "label1");
					num = (int)((num2 * 993847428) ^ 0x6C47F3D);
					continue;
				case 44u:
					num = ((int)num2 * -1803081429) ^ 0x9740807;
					continue;
				case 43u:
					Form2.smethod_1((Control)(object)button1, "OK");
					num = (int)(num2 * 257877237) ^ -1249428096;
					continue;
				case 42u:
					Form2.smethod_24((Control)(object)textBox1, new Size(42, 80));
					num = ((int)num2 * -1613281766) ^ 0x3B70C662;
					continue;
				case 41u:
					Form2.smethod_1((Control)(object)label2, "+N=?");
					num = (int)(num2 * 425681585) ^ -1617023193;
					continue;
				case 40u:
					Form2.smethod_24((Control)(object)label1, new Size(35, 13));
					num = (int)(num2 * 319165519) ^ -1002354244;
					continue;
				case 39u:
					num = ((int)num2 * -712105054) ^ 0x41C4374F;
					continue;
				case 38u:
					label2 = Form2.smethod_17();
					num = ((int)num2 * -1818562041) ^ 0x208691A2;
					continue;
				case 37u:
					Form2.smethod_36((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -1555213785) ^ -166589450;
					continue;
				case 36u:
					Form2.smethod_23((Control)(object)button1, "button1");
					num = (int)((num2 * 1559744971) ^ 0x52B54D5A);
					continue;
				case 35u:
					Form2.smethod_29((ButtonBase)(object)button1, bool_0: true);
					num = (int)((num2 * 1248607155) ^ 0x1FF5078F);
					continue;
				case 34u:
					num = (int)((num2 * 1810526768) ^ 0x4BA327E0);
					continue;
				case 33u:
					Form2.smethod_21((Control)(object)label2, bool_0: true);
					num = ((int)num2 * -978893544) ^ 0x338402DE;
					continue;
				case 32u:
					Form2.smethod_39((Control)(object)this, "Form2");
					num = (int)(num2 * 26992657) ^ -130815732;
					continue;
				case 31u:
					num = (int)((num2 * 135252303) ^ 0x4785AFB4);
					continue;
				case 30u:
					Form2.smethod_40((Form)(object)this, bool_0: false);
					num = ((int)num2 * -113712512) ^ 0x43DCDFCD;
					continue;
				case 29u:
					Form2.smethod_22((Control)(object)textBox1, new Point(24, 86));
					Form2.smethod_23((Control)(object)textBox1, "textBox1");
					num = (int)((num2 * 48290063) ^ 0x4CC6E8B8);
					continue;
				case 28u:
					num = ((int)num2 * -146438046) ^ -1960940256;
					continue;
				case 27u:
					Form2.smethod_22((Control)(object)label3, new Point(47, 177));
					num = (int)(num2 * 148762411) ^ -429346539;
					continue;
				case 26u:
					Form2.smethod_28((Control)(object)textBox1, new KeyPressEventHandler(TextBox1_KeyPress));
					num = ((int)num2 * -1687689316) ^ 0x33B96E5B;
					continue;
				case 25u:
					num = ((int)num2 * -554850966) ^ 0x487744D4;
					continue;
				case 24u:
					Form2.smethod_30((Control)(object)button1, (EventHandler)Button1_Click);
					Form2.smethod_21((Control)(object)label3, bool_0: true);
					num = ((int)num2 * -1464761968) ^ 0x31418317;
					continue;
				case 23u:
					num = ((int)num2 * -863949948) ^ 0x15D3B7E5;
					continue;
				case 22u:
					Form2.smethod_23((Control)(object)label2, "label2");
					num = ((int)num2 * -1014071486) ^ -1104665629;
					continue;
				case 21u:
					Form2.smethod_1((Control)(object)label1, "label1");
					Form2.smethod_27((Control)(object)textBox1, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -9047220) ^ -2135731092;
					continue;
				case 20u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -1623283852) ^ -654487532;
					continue;
				case 19u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label2);
					num = (int)(num2 * 701386948) ^ -1258278855;
					continue;
				case 17u:
					Form2.smethod_25((Control)(object)label2, 2);
					num = ((int)num2 * -1496352235) ^ 0x773557ED;
					continue;
				case 16u:
					Form2.smethod_32((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 1709478209) ^ -898729875;
					continue;
				case 15u:
					num = (int)(num2 * 743661756) ^ -1825996875;
					continue;
				case 14u:
					Form2.smethod_25((Control)(object)label3, 4);
					num = (int)(num2 * 273688534) ^ -953286048;
					continue;
				case 13u:
					num = ((int)num2 * -347915841) ^ -1566219316;
					continue;
				case 12u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)textBox1);
					num = ((int)num2 * -1710516036) ^ 0x75F93662;
					continue;
				case 11u:
					num = (int)((num2 * 1510079443) ^ 0x5406A07E);
					continue;
				case 10u:
					Form2.smethod_25((Control)(object)label1, 0);
					num = ((int)num2 * -1748738045) ^ 0x42F2202A;
					continue;
				case 9u:
					button1 = Form2.smethod_19();
					num = (int)(num2 * 322855832) ^ -62463927;
					continue;
				case 8u:
					num = (int)((num2 * 227664469) ^ 0x25C38473);
					continue;
				case 7u:
					Form2.smethod_25((Control)(object)textBox1, 1);
					num = ((int)num2 * -1997476124) ^ -438175993;
					continue;
				case 6u:
					num = (int)(num2 * 1217670789) ^ -571810788;
					continue;
				case 5u:
					num = ((int)num2 * -1800046138) ^ -2091353163;
					continue;
				case 4u:
					Form2.smethod_22((Control)(object)button1, new Point(86, 193));
					num = (int)(num2 * 2064065472) ^ -276171515;
					continue;
				case 3u:
					Form2.smethod_31((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)((num2 * 598640862) ^ 0x56951CF4);
					continue;
				case 2u:
					Form2.smethod_1((Control)(object)this, "Жеребьёвка");
					num = (int)(num2 * 446291019) ^ -1483476788;
					continue;
				case 1u:
					Form2.smethod_21((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -1419058984) ^ 0x76BB2214;
					continue;
				case 0u:
					Form2.smethod_27((Control)(object)label2, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1582192991) ^ 0x8F6D399;
					continue;
				case 18u:
					break;
				default:
					Form2.smethod_41((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
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
