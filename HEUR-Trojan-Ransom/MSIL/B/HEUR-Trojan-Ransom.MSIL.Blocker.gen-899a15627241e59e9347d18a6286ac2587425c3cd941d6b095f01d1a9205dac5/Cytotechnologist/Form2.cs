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
			int num = 1565869610;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7C9B6812u) % 5u)
				{
				case 3u:
					InitializeComponent();
					num = (int)((num2 * 1558964111) ^ 0x6F00E463);
					continue;
				case 2u:
					Form2.smethod_1((Control)(object)label1, "Введите любое число от 0 до 9 включительно.\nВаш соперник уже загадал число (N) из этого\nже диапазона. Если сумма ваших чисел будет\nчетным числом, то первым ход делаете Вы,\nиначе - ваш соперник Компьютер!");
					num = ((int)num2 * -1360288831) ^ -2111953945;
					continue;
				case 1u:
					num = ((int)num2 * -952645420) ^ -1561875499;
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
			int num = -1024011247;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF4B72901u) % 3u)
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
				num = ((int)num2 * -340491065) ^ 0x7DDFB2ED;
			}
		}
	}

	private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -155836528;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDD079DFDu) % 11u)
				{
				case 10u:
					flag2 = Form2.smethod_4(e) == '\r';
					num = -702702667;
					continue;
				case 9u:
					Form2.smethod_1((Control)(object)textBox1, "");
					num = -1358678370;
					continue;
				case 8u:
					flag = !char.IsDigit(Form2.smethod_4(e));
					num = ((int)num2 * -332100797) ^ 0x1C0E4032;
					continue;
				case 6u:
					Form2.smethod_5(e, bool_0: true);
					num = ((int)num2 * -1392352094) ^ -1831476468;
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = -1358252591;
						num6 = -1358252591;
					}
					else
					{
						num5 = -1475671329;
						num6 = -1475671329;
					}
					num = num5 ^ (int)(num2 * 262986069);
					continue;
				}
				case 3u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -832134093;
						num4 = -832134093;
					}
					else
					{
						num3 = -1260611768;
						num4 = -1260611768;
					}
					num = num3 ^ ((int)num2 * -905589130);
					continue;
				}
				case 2u:
					Button1_Click(this, Form2.smethod_6());
					num = ((int)num2 * -1918675888) ^ 0x51B5DCDA;
					continue;
				case 1u:
					num = (int)((num2 * 280403436) ^ 0x4A4D6E7A);
					continue;
				case 0u:
					num = (int)(num2 * 1149243757) ^ -490915348;
					continue;
				default:
					return;
				case 7u:
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
		int num7 = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = -1145464679;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD6462F00u) % 33u)
				{
				case 32u:
					num = (int)(num2 * 1348588919) ^ -937404394;
					continue;
				case 31u:
					Form2.smethod_1((Control)(object)label3, "Поздравляем! Ваш ход первый.");
					num = (int)(num2 * 1980631139) ^ -1863834570;
					continue;
				case 30u:
				{
					Form control_2 = Form2.smethod_2((Form)(object)this);
					num7 = Form2.smethod_12((Control)(object)control_2) - 1;
					Form2.smethod_13((Control)(object)control_2, num7);
					num = -573874567;
					continue;
				}
				case 29u:
					num = ((int)num2 * -1937388092) ^ 0x6CAEB080;
					continue;
				case 28u:
					num = (int)((num2 * 895556404) ^ 0x3641B6FB);
					continue;
				case 27u:
				{
					int num10;
					int num11;
					if (flag)
					{
						num10 = -1587062445;
						num11 = -1587062445;
					}
					else
					{
						num10 = -652736394;
						num11 = -652736394;
					}
					num = num10 ^ ((int)num2 * -928336231);
					continue;
				}
				case 26u:
					num = ((int)num2 * -978326849) ^ 0x664C59C2;
					continue;
				case 25u:
					this.flag = false;
					num = -1772364191;
					continue;
				case 24u:
					num = -1405690408;
					continue;
				case 23u:
					Form2.smethod_15((Form)(object)this);
					num = (int)((num2 * 1255567865) ^ 0x752CD5DF);
					continue;
				case 22u:
					flag2 = Form2.smethod_8(Form2.smethod_7((Control)(object)textBox1), "");
					num = (int)(num2 * 2057143640) ^ -487287816;
					continue;
				case 21u:
				{
					int num12;
					int num13;
					if (!flag2)
					{
						num12 = 832152181;
						num13 = 832152181;
					}
					else
					{
						num12 = 1492200733;
						num13 = 1492200733;
					}
					num = num12 ^ ((int)num2 * -379889695);
					continue;
				}
				case 20u:
					num = ((int)num2 * -1075739796) ^ 0x28BED669;
					continue;
				case 19u:
					num = -922298306;
					continue;
				case 18u:
					num3 = int.Parse(Form2.smethod_7((Control)(object)textBox1));
					num4 = Form2.smethod_9(rnd, 10);
					num = ((int)num2 * -1316517574) ^ 0x7BBD7F5B;
					continue;
				case 17u:
				{
					int num8;
					int num9;
					if (num7 <= 1)
					{
						num8 = -1316496664;
						num9 = -1316496664;
					}
					else
					{
						num8 = -1347860748;
						num9 = -1347860748;
					}
					num = num8 ^ ((int)num2 * -715442843);
					continue;
				}
				case 16u:
					num = ((int)num2 * -547058295) ^ 0x20078DEF;
					continue;
				case 15u:
				{
					Label control_ = label2;
					string string_ = num4.ToString();
					num7 = num3 + num4;
					Form2.smethod_1((Control)(object)control_, Form2.smethod_10("+", string_, "=", num7.ToString()));
					num = (int)((num2 * 919171870) ^ 0x397FF8DF);
					continue;
				}
				case 14u:
				{
					int num5;
					int num6;
					if (!this.flag)
					{
						num5 = -295360098;
						num6 = -295360098;
					}
					else
					{
						num5 = -1268489151;
						num6 = -1268489151;
					}
					num = num5 ^ ((int)num2 * -860790515);
					continue;
				}
				case 13u:
					(Form2.smethod_2((Form)(object)this) as Form3).Button_Continue();
					num = ((int)num2 * -1813810589) ^ 0x27248E0;
					continue;
				case 12u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).StartGame();
					num = ((int)num2 * -709972230) ^ 0x441CFFE0;
					continue;
				case 11u:
					num = -10648093;
					continue;
				case 10u:
					flag = (num3 + num4) % 2 == 0;
					num = ((int)num2 * -1783374180) ^ 0x17983B60;
					continue;
				case 9u:
					num = -1950754027;
					continue;
				case 8u:
					num = ((int)num2 * -2106624662) ^ -1305165677;
					continue;
				case 7u:
					num = (int)((num2 * 1724354863) ^ 0x25583DE5);
					continue;
				case 5u:
					Form2.smethod_1((Control)(object)label3, "Первым ход делает Компьютер.");
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = false;
					num = ((int)num2 * -269361411) ^ 0x552EEAAA;
					continue;
				case 3u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = true;
					num = ((int)num2 * -1502256047) ^ -1195061280;
					continue;
				case 2u:
					num = ((int)num2 * -314892520) ^ -261983019;
					continue;
				case 1u:
					num = (int)((num2 * 1514819991) ^ 0x1947C2E5);
					continue;
				case 0u:
					Form2.smethod_14(Form2.smethod_11(Form2.smethod_2((Form)(object)this)));
					num = ((int)num2 * -1606454907) ^ -1333817669;
					continue;
				default:
					return;
				case 6u:
					break;
				case 4u:
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
		goto IL_00b3;
		IL_00b3:
		bool flag = (byte)num != 0;
		int num2 = -491779339;
		goto IL_0079;
		IL_0009:
		num2 = -543244302;
		goto IL_0079;
		IL_0079:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0xC19438E0u) % 8u)
			{
			case 7u:
				break;
			case 6u:
				Form2.smethod_16((IDisposable)components);
				num2 = ((int)num3 * -1576230874) ^ -1150610640;
				continue;
			case 5u:
			{
				int num4;
				int num5;
				if (!flag)
				{
					num4 = 178286690;
					num5 = 178286690;
				}
				else
				{
					num4 = 400941467;
					num5 = 400941467;
				}
				num2 = num4 ^ ((int)num3 * -1906501694);
				continue;
			}
			case 4u:
				num2 = (int)(num3 * 388890108) ^ -1533930749;
				continue;
			case 3u:
				num2 = (int)((num3 * 253654219) ^ 0x1FC9DBD9);
				continue;
			case 1u:
				num2 = ((int)num3 * -1822003840) ^ -1166616922;
				continue;
			case 2u:
				goto IL_00aa;
			default:
				((Form)this).Dispose(disposing);
				return;
			}
			break;
		}
		goto IL_0009;
		IL_00aa:
		num = ((components != null) ? 1 : 0);
		goto IL_00b3;
	}

	private void InitializeComponent()
	{
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected O, but got Unknown
		label1 = Form2.smethod_17();
		while (true)
		{
			int num = -127590046;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB46731F2u) % 60u)
				{
				case 59u:
					num = ((int)num2 * -1755495801) ^ 0xFF45F24;
					continue;
				case 58u:
					Form2.smethod_21((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -1751095898) ^ 0x4DE9AC09;
					continue;
				case 57u:
					Form2.smethod_23((Control)(object)button1, "button1");
					num = (int)(num2 * 1774709449) ^ -2074740920;
					continue;
				case 56u:
					Form2.smethod_25((Control)(object)label2, 2);
					num = ((int)num2 * -1526640786) ^ -1950887443;
					continue;
				case 55u:
					Form2.smethod_23((Control)(object)label3, "label3");
					num = (int)(num2 * 1601126350) ^ -1843969905;
					continue;
				case 54u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label2);
					num = (int)(num2 * 736440475) ^ -971957696;
					continue;
				case 53u:
					Form2.smethod_23((Control)(object)textBox1, "textBox1");
					Form2.smethod_24((Control)(object)textBox1, new Size(42, 80));
					num = (int)(num2 * 463040302) ^ -297206305;
					continue;
				case 52u:
					num = ((int)num2 * -892732167) ^ 0x3DA345DC;
					continue;
				case 51u:
					Form2.smethod_22((Control)(object)label1, new Point(10, 10));
					num = (int)((num2 * 1239510842) ^ 0x473FC9B2);
					continue;
				case 50u:
					num = ((int)num2 * -699441690) ^ 0x4023810C;
					continue;
				case 49u:
					num = ((int)num2 * -1033843613) ^ -89532651;
					continue;
				case 48u:
					num = (int)(num2 * 300456790) ^ -1353569947;
					continue;
				case 47u:
					num = ((int)num2 * -1724815024) ^ -1475201214;
					continue;
				case 46u:
					Form2.smethod_28((Control)(object)textBox1, new KeyPressEventHandler(TextBox1_KeyPress));
					num = (int)(num2 * 2082502216) ^ -2045558153;
					continue;
				case 45u:
					num = ((int)num2 * -1413878379) ^ -1776793256;
					continue;
				case 44u:
					Form2.smethod_25((Control)(object)button1, 3);
					num = ((int)num2 * -1404878081) ^ -389741682;
					continue;
				case 43u:
					num = (int)((num2 * 788009374) ^ 0x280369AC);
					continue;
				case 42u:
					Form2.smethod_27((Control)(object)textBox1, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form2.smethod_22((Control)(object)textBox1, new Point(24, 86));
					num = (int)(num2 * 764857232) ^ -2120288113;
					continue;
				case 41u:
					Form2.smethod_30((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -1905916587) ^ -1121355489;
					continue;
				case 40u:
					Form2.smethod_33((Form)(object)this, new Size(255, 224));
					num = (int)(num2 * 1946044755) ^ -915203362;
					continue;
				case 39u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label3);
					num = (int)((num2 * 1914668725) ^ 0x34776167);
					continue;
				case 38u:
					Form2.smethod_24((Control)(object)label2, new Size(188, 73));
					num = (int)((num2 * 947038774) ^ 0x5BC219A1);
					continue;
				case 37u:
					Form2.smethod_42((Control)(object)this, bool_0: false);
					num = ((int)num2 * -920546474) ^ -1358525267;
					continue;
				case 36u:
					Form2.smethod_37((Form)(object)this, bool_0: false);
					num = (int)((num2 * 1743373172) ^ 0x3E0FB1DC);
					continue;
				case 35u:
					Form2.smethod_1((Control)(object)this, "Жеребьёвка");
					Form2.smethod_41((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
					num = ((int)num2 * -592664315) ^ 0x1CA4629C;
					continue;
				case 33u:
					Form2.smethod_43((Control)(object)this);
					num = ((int)num2 * -1683868299) ^ -503158135;
					continue;
				case 32u:
					Form2.smethod_31((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -1358641959) ^ -1605513007;
					continue;
				case 31u:
					Form2.smethod_1((Control)(object)button1, "OK");
					num = ((int)num2 * -81226679) ^ -347387008;
					continue;
				case 30u:
					Form2.smethod_25((Control)(object)label3, 4);
					num = (int)(num2 * 657274367) ^ -15644267;
					continue;
				case 29u:
					num = (int)(num2 * 1698046452) ^ -1979536890;
					continue;
				case 28u:
					textBox1 = Form2.smethod_18();
					num = (int)((num2 * 1206900579) ^ 0x1D8EFB5F);
					continue;
				case 27u:
					Form2.smethod_1((Control)(object)label2, "+N=?");
					Form2.smethod_22((Control)(object)button1, new Point(86, 193));
					num = ((int)num2 * -589709210) ^ -171880679;
					continue;
				case 26u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)button1);
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)textBox1);
					num = ((int)num2 * -791876259) ^ 0x790BA3C4;
					continue;
				case 25u:
					button1 = Form2.smethod_19();
					label3 = Form2.smethod_17();
					Form2.smethod_20((Control)(object)this);
					num = (int)(num2 * 1986415555) ^ -197466928;
					continue;
				case 24u:
					Form2.smethod_21((Control)(object)label3, bool_0: true);
					Form2.smethod_22((Control)(object)label3, new Point(47, 177));
					num = (int)(num2 * 1436044309) ^ -1739764226;
					continue;
				case 23u:
					Form2.smethod_24((Control)(object)button1, new Size(73, 23));
					num = ((int)num2 * -422659361) ^ -1241275852;
					continue;
				case 22u:
					Form2.smethod_1((Control)(object)label1, "label1");
					num = ((int)num2 * -1088441241) ^ -517731322;
					continue;
				case 21u:
					Form2.smethod_29((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -1368556370) ^ 0x2FA3F9C1;
					continue;
				case 19u:
					Form2.smethod_32((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -804793968) ^ -1275473855;
					continue;
				case 18u:
					Form2.smethod_23((Control)(object)label1, "label1");
					num = (int)(num2 * 1336255945) ^ -1197984942;
					continue;
				case 17u:
					Form2.smethod_25((Control)(object)label1, 0);
					num = ((int)num2 * -174470558) ^ -1921458238;
					continue;
				case 16u:
					num = ((int)num2 * -42621759) ^ 0x19154FB1;
					continue;
				case 15u:
					num = (int)((num2 * 484146242) ^ 0x64AD12);
					continue;
				case 14u:
					Form2.smethod_24((Control)(object)label1, new Size(35, 13));
					num = (int)((num2 * 881893175) ^ 0x3AE2A585);
					continue;
				case 13u:
					num = (int)(num2 * 1697619957) ^ -955856419;
					continue;
				case 12u:
					num = ((int)num2 * -317313767) ^ 0x6B0C03E1;
					continue;
				case 11u:
					Form2.smethod_22((Control)(object)label2, new Point(53, 89));
					Form2.smethod_23((Control)(object)label2, "label2");
					num = ((int)num2 * -2083256587) ^ -110380148;
					continue;
				case 10u:
					Form2.smethod_38((Form)(object)this, bool_0: false);
					Form2.smethod_39((Control)(object)this, "Form2");
					Form2.smethod_40((Form)(object)this, bool_0: false);
					num = (int)(num2 * 2099346583) ^ -1500036793;
					continue;
				case 9u:
					Form2.smethod_36((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -107399291) ^ 0x78376D31;
					continue;
				case 8u:
					Form2.smethod_21((Control)(object)label2, bool_0: true);
					Form2.smethod_27((Control)(object)label2, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1697156651) ^ -1750863221;
					continue;
				case 7u:
					num = (int)((num2 * 1090226007) ^ 0xE2F0443);
					continue;
				case 6u:
					Form2.smethod_25((Control)(object)textBox1, 1);
					num = ((int)num2 * -260676954) ^ -1140232524;
					continue;
				case 5u:
					num = (int)((num2 * 2068051045) ^ 0xA30A5D1);
					continue;
				case 4u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label1);
					num = (int)((num2 * 849006026) ^ 0x478709E3);
					continue;
				case 3u:
					Form2.smethod_24((Control)(object)label3, new Size(0, 13));
					num = ((int)num2 * -1060901629) ^ -1555222011;
					continue;
				case 2u:
					num = (int)((num2 * 1325316836) ^ 0x4FD0D902);
					continue;
				case 1u:
					label2 = Form2.smethod_17();
					num = ((int)num2 * -1671056987) ^ -9853066;
					continue;
				case 0u:
					num = (int)(num2 * 471006154) ^ -453101606;
					continue;
				default:
					return;
				case 20u:
					break;
				case 34u:
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
