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
			int num = 1109399266;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC82B4Fu) % 6u)
				{
				case 5u:
					InitializeComponent();
					num = (int)((num2 * 1790779724) ^ 0x61F17B03);
					continue;
				case 4u:
					Form2.smethod_1((Control)(object)label1, "Введите любое число от 0 до 9 включительно.\nВаш соперник уже загадал число (N) из этого\nже диапазона. Если сумма ваших чисел будет\nчетным числом, то первым ход делаете Вы,\nиначе - ваш соперник Компьютер!");
					num = (int)((num2 * 2072130504) ^ 0x3E957CA6);
					continue;
				case 3u:
					num = ((int)num2 * -518707388) ^ -1388153319;
					continue;
				case 1u:
					num = ((int)num2 * -103795273) ^ 0x20642CE5;
					continue;
				default:
					return;
				case 0u:
					break;
				case 2u:
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
			int num = 1388903299;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x12C32E03u) % 3u)
				{
				case 2u:
					goto IL_000e;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_000e:
				num = (int)((num2 * 329661038) ^ 0x198B01D1);
			}
		}
	}

	private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsDigit(Form2.smethod_4(e)))
		{
			goto IL_0036;
		}
		goto IL_00eb;
		IL_00eb:
		Form2.smethod_1((Control)(object)textBox1, "");
		int num = -88147122;
		goto IL_00b1;
		IL_00b1:
		bool flag = default(bool);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x97443906u) % 10u)
			{
			case 9u:
				num = ((int)num2 * -1349202479) ^ -118339771;
				continue;
			case 8u:
				num = ((int)num2 * -1889567784) ^ 0x7840D23;
				continue;
			case 7u:
				break;
			case 5u:
				Button1_Click(this, Form2.smethod_6());
				num = (int)(num2 * 449608474) ^ -1954189452;
				continue;
			case 3u:
			{
				int num3;
				int num4;
				if (!flag)
				{
					num3 = 1622403595;
					num4 = 1622403595;
				}
				else
				{
					num3 = 176365392;
					num4 = 176365392;
				}
				num = num3 ^ ((int)num2 * -401631061);
				continue;
			}
			case 2u:
				flag = Form2.smethod_4(e) == '\r';
				num = -1569913171;
				continue;
			case 1u:
				Form2.smethod_5(e, bool_0: true);
				num = (int)((num2 * 600910916) ^ 0x7524E6BE);
				continue;
			case 0u:
				num = (int)(num2 * 662482385) ^ -520695720;
				continue;
			default:
				return;
			case 4u:
				goto IL_00eb;
			case 6u:
				return;
			}
			break;
		}
		goto IL_0036;
		IL_0036:
		num = -399865107;
		goto IL_00b1;
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		int num6 = default(int);
		int num5 = default(int);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -298642523;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x817FA935u) % 34u)
				{
				case 33u:
					num = -2033007721;
					continue;
				case 32u:
					(Form2.smethod_2((Form)(object)this) as Form3).Button_Continue();
					num = (int)((num2 * 707903104) ^ 0xF802DF8);
					continue;
				case 31u:
					num6 = Form2.smethod_9(rnd, 10);
					Form2.smethod_1((Control)(object)label2, Form2.smethod_10("+", num6.ToString(), "=", (num5 + num6).ToString()));
					num = ((int)num2 * -847778175) ^ -1173232648;
					continue;
				case 30u:
				{
					int num9;
					int num10;
					if (!flag3)
					{
						num9 = 1617541459;
						num10 = 1617541459;
					}
					else
					{
						num9 = 1700257910;
						num10 = 1700257910;
					}
					num = num9 ^ ((int)num2 * -1132658515);
					continue;
				}
				case 29u:
					num = ((int)num2 * -70426922) ^ 0x2A820013;
					continue;
				case 28u:
					num = (int)(num2 * 14320290) ^ -2052221176;
					continue;
				case 27u:
					num = (int)(num2 * 1024273879) ^ -1995346361;
					continue;
				case 26u:
					num = -309167839;
					continue;
				case 25u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).StartGame();
					num = ((int)num2 * -1291302052) ^ 0x3B0FBD12;
					continue;
				case 24u:
					flag3 = Form2.smethod_8(Form2.smethod_7((Control)(object)textBox1), "");
					num = ((int)num2 * -148513738) ^ -53667893;
					continue;
				case 23u:
					num = (int)(num2 * 1236753020) ^ -804707580;
					continue;
				case 22u:
					num = (int)(num2 * 1861414567) ^ -1422090663;
					continue;
				case 21u:
				{
					int num11;
					int num12;
					if (!flag2)
					{
						num11 = -417791156;
						num12 = -417791156;
					}
					else
					{
						num11 = -1785720738;
						num12 = -1785720738;
					}
					num = num11 ^ ((int)num2 * -1279008842);
					continue;
				}
				case 20u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = false;
					num = (int)(num2 * 416616488) ^ -1124995527;
					continue;
				case 19u:
					num = (int)((num2 * 385332151) ^ 0x504378E0);
					continue;
				case 18u:
					num5 = int.Parse(Form2.smethod_7((Control)(object)textBox1));
					num = (int)(num2 * 1952959118) ^ -892808488;
					continue;
				case 17u:
					num = ((int)num2 * -1608721573) ^ -62870190;
					continue;
				case 16u:
					Form2.smethod_14(Form2.smethod_11(Form2.smethod_2((Form)(object)this)));
					num = ((int)num2 * -541902965) ^ -291428166;
					continue;
				case 15u:
					num = ((int)num2 * -448960364) ^ 0x58388DC8;
					continue;
				case 14u:
					num = (int)(num2 * 2076787865) ^ -467566009;
					continue;
				case 12u:
				{
					Form control_ = Form2.smethod_2((Form)(object)this);
					int num7 = Form2.smethod_12((Control)(object)control_) - 1;
					Form2.smethod_13((Control)(object)control_, num7);
					int num8;
					if (num7 <= 1)
					{
						num = -98710113;
						num8 = -98710113;
					}
					else
					{
						num = -1664096529;
						num8 = -1664096529;
					}
					continue;
				}
				case 11u:
					num = -573864043;
					continue;
				case 10u:
					num = ((int)num2 * -1771226603) ^ -637926883;
					continue;
				case 9u:
					num = -2029303812;
					continue;
				case 8u:
					flag2 = (num5 + num6) % 2 == 0;
					num = (int)(num2 * 862614663) ^ -1590012420;
					continue;
				case 7u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1564452046;
						num4 = 1564452046;
					}
					else
					{
						num3 = 831210327;
						num4 = 831210327;
					}
					num = num3 ^ ((int)num2 * -1692953954);
					continue;
				}
				case 6u:
					Form2.smethod_1((Control)(object)label3, "Первым ход делает Компьютер.");
					num = (int)((num2 * 1693418938) ^ 0x508ACF8F);
					continue;
				case 5u:
					Form2.smethod_15((Form)(object)this);
					num = ((int)num2 * -2060255647) ^ 0x498E0CFE;
					continue;
				case 4u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = true;
					num = (int)((num2 * 1806888150) ^ 0x17CEAA70);
					continue;
				case 3u:
					flag = this.flag;
					num = (int)((num2 * 788564759) ^ 0x727A450F);
					continue;
				case 1u:
					Form2.smethod_1((Control)(object)label3, "Поздравляем! Ваш ход первый.");
					num = ((int)num2 * -487300724) ^ -2144125927;
					continue;
				case 0u:
					this.flag = false;
					num = -1067652420;
					continue;
				default:
					return;
				case 13u:
					break;
				case 2u:
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
			goto IL_0009;
		}
		int num = 0;
		goto IL_009f;
		IL_009f:
		bool flag = (byte)num != 0;
		int num2 = -28787047;
		goto IL_0069;
		IL_0009:
		num2 = -2135405784;
		goto IL_0069;
		IL_0069:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0xBC1FC9FBu) % 7u)
			{
			case 6u:
				break;
			case 4u:
				((Form)this).Dispose(disposing);
				num2 = -1129050713;
				continue;
			case 3u:
				num2 = ((int)num3 * -1894855205) ^ 0x1BE1D1CA;
				continue;
			case 2u:
			{
				int num4;
				int num5;
				if (!flag)
				{
					num4 = 1714459220;
					num5 = 1714459220;
				}
				else
				{
					num4 = 1928794357;
					num5 = 1928794357;
				}
				num2 = num4 ^ ((int)num3 * -676259973);
				continue;
			}
			case 1u:
				Form2.smethod_16((IDisposable)components);
				num2 = (int)((num3 * 1601567974) ^ 0x7CB1D874);
				continue;
			default:
				return;
			case 5u:
				goto IL_0096;
			case 0u:
				return;
			}
			break;
		}
		goto IL_0009;
		IL_0096:
		num = ((components != null) ? 1 : 0);
		goto IL_009f;
	}

	private void InitializeComponent()
	{
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected O, but got Unknown
		//IL_0760: Unknown result type (might be due to invalid IL or missing references)
		//IL_076a: Expected O, but got Unknown
		label1 = Form2.smethod_17();
		while (true)
		{
			int num = 1676659269;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5F871269u) % 66u)
				{
				case 65u:
					Form2.smethod_22((Control)(object)button1, new Point(86, 193));
					num = ((int)num2 * -979960) ^ 0xC51B35F;
					continue;
				case 64u:
					Form2.smethod_21((Control)(object)label2, bool_0: true);
					num = (int)(num2 * 554474483) ^ -607892310;
					continue;
				case 63u:
					Form2.smethod_30((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -1960180336) ^ -1029112765;
					continue;
				case 62u:
					Form2.smethod_23((Control)(object)button1, "button1");
					num = (int)(num2 * 343546776) ^ -2095275497;
					continue;
				case 61u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label3);
					num = ((int)num2 * -1777438980) ^ -1172920828;
					continue;
				case 60u:
					Form2.smethod_23((Control)(object)textBox1, "textBox1");
					num = ((int)num2 * -846490352) ^ 0x9F5094B;
					continue;
				case 59u:
					num = (int)(num2 * 1740258163) ^ -354794167;
					continue;
				case 58u:
					textBox1 = Form2.smethod_18();
					label2 = Form2.smethod_17();
					button1 = Form2.smethod_19();
					num = (int)(num2 * 366723722) ^ -120989298;
					continue;
				case 57u:
					num = (int)(num2 * 74505825) ^ -1382510715;
					continue;
				case 56u:
					num = ((int)num2 * -685496517) ^ -1527998378;
					continue;
				case 55u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label1);
					Form2.smethod_36((Form)(object)this, (FormBorderStyle)1);
					num = (int)((num2 * 1593323227) ^ 0x2CE84965);
					continue;
				case 54u:
					Form2.smethod_25((Control)(object)textBox1, 1);
					num = ((int)num2 * -1720807740) ^ 0x5031F240;
					continue;
				case 53u:
					num = ((int)num2 * -1225054603) ^ -1853324051;
					continue;
				case 52u:
					num = ((int)num2 * -1240819757) ^ 0x610EA4AC;
					continue;
				case 51u:
					Form2.smethod_32((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -1409158459) ^ 0x5EBC5764;
					continue;
				case 50u:
					Form2.smethod_37((Form)(object)this, bool_0: false);
					num = ((int)num2 * -900287198) ^ -3078735;
					continue;
				case 49u:
					num = (int)(num2 * 1426531939) ^ -2130346775;
					continue;
				case 48u:
					Form2.smethod_33((Form)(object)this, new Size(255, 224));
					num = ((int)num2 * -1303174864) ^ -629657632;
					continue;
				case 46u:
					Form2.smethod_1((Control)(object)this, "Жеребьёвка");
					num = (int)(num2 * 834250528) ^ -183600747;
					continue;
				case 45u:
					Form2.smethod_42((Control)(object)this, bool_0: false);
					Form2.smethod_43((Control)(object)this);
					num = ((int)num2 * -72385056) ^ -560372834;
					continue;
				case 44u:
					num = (int)((num2 * 1435375406) ^ 0x689A0088);
					continue;
				case 43u:
					label3 = Form2.smethod_17();
					num = (int)((num2 * 1834531699) ^ 0x50A69E7E);
					continue;
				case 42u:
					Form2.smethod_41((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
					num = ((int)num2 * -26799806) ^ 0x5140D35E;
					continue;
				case 41u:
					num = ((int)num2 * -1300947956) ^ -2071508316;
					continue;
				case 40u:
					num = (int)(num2 * 1358701043) ^ -1504648310;
					continue;
				case 39u:
					num = ((int)num2 * -471544211) ^ -26840740;
					continue;
				case 38u:
					Form2.smethod_39((Control)(object)this, "Form2");
					num = (int)((num2 * 2090109279) ^ 0x6D22F94C);
					continue;
				case 37u:
					Form2.smethod_22((Control)(object)label3, new Point(47, 177));
					num = (int)(num2 * 1183296562) ^ -1328127337;
					continue;
				case 36u:
					num = (int)(num2 * 2131593811) ^ -783985847;
					continue;
				case 35u:
					num = (int)((num2 * 1725676172) ^ 0x6615AC5A);
					continue;
				case 34u:
					num = (int)((num2 * 857374090) ^ 0x93E9FA8);
					continue;
				case 33u:
					Form2.smethod_29((ButtonBase)(object)button1, bool_0: true);
					num = (int)(num2 * 552850312) ^ -1262173460;
					continue;
				case 32u:
					Form2.smethod_25((Control)(object)button1, 3);
					num = (int)(num2 * 287031577) ^ -922018655;
					continue;
				case 31u:
					Form2.smethod_24((Control)(object)label1, new Size(35, 13));
					num = (int)((num2 * 1511411974) ^ 0x25E37747);
					continue;
				case 30u:
					Form2.smethod_23((Control)(object)label3, "label3");
					num = ((int)num2 * -1643709399) ^ 0x7DA78420;
					continue;
				case 29u:
					Form2.smethod_1((Control)(object)label1, "label1");
					num = ((int)num2 * -1420051071) ^ -2023083315;
					continue;
				case 28u:
					Form2.smethod_24((Control)(object)button1, new Size(73, 23));
					num = (int)((num2 * 1143689644) ^ 0x42B5D2FA);
					continue;
				case 27u:
					Form2.smethod_40((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1684896744) ^ 0x3F29E559;
					continue;
				case 26u:
					Form2.smethod_20((Control)(object)this);
					num = ((int)num2 * -224521184) ^ -575981319;
					continue;
				case 25u:
					Form2.smethod_22((Control)(object)label1, new Point(10, 10));
					num = ((int)num2 * -1996236738) ^ 0x48F0F528;
					continue;
				case 24u:
					Form2.smethod_31((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)(num2 * 1253160915) ^ -1943437203;
					continue;
				case 23u:
					Form2.smethod_27((Control)(object)textBox1, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 1610062794) ^ 0x171DB611);
					continue;
				case 22u:
					num = ((int)num2 * -2091849654) ^ 0x3272F8C8;
					continue;
				case 21u:
					Form2.smethod_25((Control)(object)label1, 0);
					num = (int)(num2 * 996336914) ^ -1034137986;
					continue;
				case 20u:
					Form2.smethod_22((Control)(object)label2, new Point(53, 89));
					Form2.smethod_23((Control)(object)label2, "label2");
					num = ((int)num2 * -2091015960) ^ 0x2BAD3D8D;
					continue;
				case 19u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)button1);
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)textBox1);
					num = ((int)num2 * -687629603) ^ -2112979128;
					continue;
				case 18u:
					Form2.smethod_25((Control)(object)label3, 4);
					num = (int)((num2 * 142279740) ^ 0x2D2EFBFD);
					continue;
				case 17u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label2);
					num = ((int)num2 * -117391785) ^ -1108322047;
					continue;
				case 16u:
					Form2.smethod_22((Control)(object)textBox1, new Point(24, 86));
					num = ((int)num2 * -1719098234) ^ -1435537387;
					continue;
				case 15u:
					Form2.smethod_24((Control)(object)label3, new Size(0, 13));
					num = (int)(num2 * 359520843) ^ -1665136674;
					continue;
				case 14u:
					Form2.smethod_24((Control)(object)label2, new Size(188, 73));
					Form2.smethod_25((Control)(object)label2, 2);
					num = (int)(num2 * 2101072555) ^ -689865699;
					continue;
				case 13u:
					Form2.smethod_21((Control)(object)label3, bool_0: true);
					num = ((int)num2 * -66611585) ^ 0x524C0925;
					continue;
				case 12u:
					Form2.smethod_21((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -1178823252) ^ -1003734466;
					continue;
				case 11u:
					Form2.smethod_27((Control)(object)label2, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 1272193149) ^ -1290357576;
					continue;
				case 10u:
					Form2.smethod_1((Control)(object)label2, "+N=?");
					num = ((int)num2 * -1586547575) ^ -109945530;
					continue;
				case 8u:
					num = (int)(num2 * 1452574976) ^ -1616739923;
					continue;
				case 7u:
					Form2.smethod_38((Form)(object)this, bool_0: false);
					num = ((int)num2 * -780524783) ^ -1359025880;
					continue;
				case 6u:
					num = ((int)num2 * -1139423323) ^ 0x6F124A39;
					continue;
				case 5u:
					Form2.smethod_23((Control)(object)label1, "label1");
					num = (int)(num2 * 2031319083) ^ -1674528654;
					continue;
				case 4u:
					Form2.smethod_24((Control)(object)textBox1, new Size(42, 80));
					num = ((int)num2 * -616481707) ^ 0x398EF4D9;
					continue;
				case 3u:
					Form2.smethod_28((Control)(object)textBox1, new KeyPressEventHandler(TextBox1_KeyPress));
					num = (int)(num2 * 1230015487) ^ -44591324;
					continue;
				case 2u:
					Form2.smethod_1((Control)(object)button1, "OK");
					num = ((int)num2 * -318531716) ^ -235546653;
					continue;
				case 1u:
					num = ((int)num2 * -287788592) ^ -1794549029;
					continue;
				case 0u:
					num = (int)((num2 * 1533459050) ^ 0x52463174);
					continue;
				default:
					return;
				case 47u:
					break;
				case 9u:
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
