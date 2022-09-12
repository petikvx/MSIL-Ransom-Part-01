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
			int num = 25580244;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x534EC973u) % 3u)
				{
				case 1u:
					goto IL_0021;
				case 0u:
					break;
				default:
					InitializeComponent();
					Form2.smethod_1((Control)(object)label1, "Введите любое число от 0 до 9 включительно.\nВаш соперник уже загадал число (N) из этого\nже диапазона. Если сумма ваших чисел будет\nчетным числом, то первым ход делаете Вы,\nиначе - ваш соперник Компьютер!");
					return;
				}
				break;
				IL_0021:
				num = ((int)num2 * -84256969) ^ 0x29F124B8;
			}
		}
	}

	private void Form2_FormClosed(object sender, FormClosedEventArgs e)
	{
		Form2.smethod_3((Control)(object)Form2.smethod_2((Form)(object)this), bool_0: true);
	}

	private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		bool flag = !char.IsDigit(Form2.smethod_4(e));
		while (true)
		{
			int num = -1645069930;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF70511EAu) % 9u)
				{
				case 8u:
					Form2.smethod_5(e, bool_0: true);
					num = ((int)num2 * -802389764) ^ -1046702821;
					continue;
				case 7u:
					num = ((int)num2 * -788876218) ^ -179509068;
					continue;
				case 6u:
					num = ((int)num2 * -1246470076) ^ 0x45023F03;
					continue;
				case 5u:
					Button1_Click(this, Form2.smethod_6());
					num = (int)((num2 * 1811936922) ^ 0x67F41489);
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -1854102723;
						num5 = -1854102723;
					}
					else
					{
						num4 = -104156516;
						num5 = -104156516;
					}
					num = num4 ^ ((int)num2 * -506057451);
					continue;
				}
				case 3u:
				{
					int num3;
					if (Form2.smethod_4(e) == '\r')
					{
						num = -690780244;
						num3 = -690780244;
					}
					else
					{
						num = -722231282;
						num3 = -722231282;
					}
					continue;
				}
				case 1u:
					Form2.smethod_1((Control)(object)textBox1, "");
					num = -1143159577;
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

	private void Button1_Click(object sender, EventArgs e)
	{
		bool flag = default(bool);
		int num4 = default(int);
		int num3 = default(int);
		int num9 = default(int);
		while (true)
		{
			int num = 309364870;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5EB0E38Eu) % 30u)
				{
				case 29u:
					Form2.smethod_14(Form2.smethod_11(Form2.smethod_2((Form)(object)this)));
					num = ((int)num2 * -2013010758) ^ -955900964;
					continue;
				case 28u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).StartGame();
					num = ((int)num2 * -1304787380) ^ -223635516;
					continue;
				case 27u:
				{
					int num7;
					int num8;
					if (!this.flag)
					{
						num7 = -1937174438;
						num8 = -1937174438;
					}
					else
					{
						num7 = -797868834;
						num8 = -797868834;
					}
					num = num7 ^ (int)(num2 * 1394263108);
					continue;
				}
				case 26u:
					Form2.smethod_1((Control)(object)label3, "Поздравляем! Ваш ход первый.");
					num = ((int)num2 * -948268498) ^ 0x4887E7EC;
					continue;
				case 25u:
					num = (int)(num2 * 1221990292) ^ -1027714361;
					continue;
				case 24u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = false;
					num = ((int)num2 * -1973302493) ^ -1209003286;
					continue;
				case 23u:
				{
					int num12;
					int num13;
					if (flag)
					{
						num12 = 668462678;
						num13 = 668462678;
					}
					else
					{
						num12 = 2031654492;
						num13 = 2031654492;
					}
					num = num12 ^ (int)(num2 * 476953255);
					continue;
				}
				case 22u:
				{
					Form control_2 = Form2.smethod_2((Form)(object)this);
					num4 = Form2.smethod_12((Control)(object)control_2) - 1;
					Form2.smethod_13((Control)(object)control_2, num4);
					num = 932238210;
					continue;
				}
				case 21u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = true;
					num = ((int)num2 * -1083648975) ^ 0x486E4B95;
					continue;
				case 20u:
					num = 1577291823;
					continue;
				case 19u:
				{
					int num10;
					int num11;
					if ((num3 + num9) % 2 != 0)
					{
						num10 = 1725251573;
						num11 = 1725251573;
					}
					else
					{
						num10 = 1396321673;
						num11 = 1396321673;
					}
					num = num10 ^ ((int)num2 * -1048467395);
					continue;
				}
				case 18u:
					num = (int)(num2 * 1479681084) ^ -45638770;
					continue;
				case 17u:
					num = 1993414840;
					continue;
				case 16u:
					num = (int)(num2 * 48282116) ^ -208241131;
					continue;
				case 15u:
					num9 = Form2.smethod_9(rnd, 10);
					num = (int)(num2 * 512504744) ^ -1358557757;
					continue;
				case 14u:
					Form2.smethod_15((Form)(object)this);
					num = ((int)num2 * -1268488644) ^ 0x74C54C81;
					continue;
				case 12u:
					Form2.smethod_1((Control)(object)label3, "Первым ход делает Компьютер.");
					num = 1884586082;
					continue;
				case 11u:
					num = ((int)num2 * -2056098454) ^ -215968498;
					continue;
				case 10u:
					num = 1460619590;
					continue;
				case 9u:
				{
					Label control_ = label2;
					string string_ = num9.ToString();
					num4 = num3 + num9;
					Form2.smethod_1((Control)(object)control_, Form2.smethod_10("+", string_, "=", num4.ToString()));
					num = ((int)num2 * -1703966990) ^ -1934221979;
					continue;
				}
				case 8u:
					flag = Form2.smethod_8(Form2.smethod_7((Control)(object)textBox1), "");
					num = ((int)num2 * -364037898) ^ 0x2E56516B;
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (num4 > 1)
					{
						num5 = 54583551;
						num6 = 54583551;
					}
					else
					{
						num5 = 1277079673;
						num6 = 1277079673;
					}
					num = num5 ^ (int)(num2 * 1959218926);
					continue;
				}
				case 6u:
					this.flag = false;
					num = 197845384;
					continue;
				case 4u:
					num3 = int.Parse(Form2.smethod_7((Control)(object)textBox1));
					num = ((int)num2 * -135976611) ^ 0x105DD619;
					continue;
				case 3u:
					(Form2.smethod_2((Form)(object)this) as Form3).Button_Continue();
					num = (int)((num2 * 1755071048) ^ 0x65D3847D);
					continue;
				case 2u:
					num = (int)(num2 * 647922582) ^ -41004959;
					continue;
				case 1u:
					num = (int)((num2 * 576789564) ^ 0x52AC65E9);
					continue;
				case 0u:
					num = ((int)num2 * -1901997696) ^ -992234312;
					continue;
				default:
					return;
				case 13u:
					break;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -72613896;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xCC534932u) % 8u)
				{
				case 7u:
					((Form)this).Dispose(disposing);
					num = -1632128638;
					continue;
				case 6u:
					num = (int)((num2 * 181217498) ^ 0x7261C792);
					continue;
				case 4u:
					Form2.smethod_16((IDisposable)components);
					num = (int)((num2 * 1011811316) ^ 0x1A93BFF5);
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1785232025;
						num5 = -1785232025;
					}
					else
					{
						num4 = -1262552906;
						num5 = -1262552906;
					}
					num = num4 ^ ((int)num2 * -799753175);
					continue;
				}
				case 2u:
					if (disposing)
					{
						num = (int)((num2 * 1533446779) ^ 0x6E017035);
						continue;
					}
					num3 = 0;
					goto IL_0074;
				case 1u:
					num3 = ((components != null) ? 1 : 0);
					goto IL_0074;
				default:
					return;
				case 5u:
					break;
				case 0u:
					return;
					IL_0074:
					flag = (byte)num3 != 0;
					num = -290193655;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected O, but got Unknown
		//IL_0620: Unknown result type (might be due to invalid IL or missing references)
		//IL_062a: Expected O, but got Unknown
		while (true)
		{
			int num = -181118487;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA97BF11Au) % 62u)
				{
				case 61u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)textBox1);
					num = (int)(num2 * 1016751202) ^ -1804976568;
					continue;
				case 60u:
					Form2.smethod_24((Control)(object)label1, new Size(35, 13));
					num = (int)((num2 * 1133780097) ^ 0x192AF36C);
					continue;
				case 59u:
					Form2.smethod_30((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)((num2 * 582709592) ^ 0x5B6815B5);
					continue;
				case 58u:
					Form2.smethod_21((Control)(object)label3, bool_0: true);
					Form2.smethod_22((Control)(object)label3, new Point(47, 177));
					Form2.smethod_23((Control)(object)label3, "label3");
					num = ((int)num2 * -1342557193) ^ -1593926932;
					continue;
				case 57u:
					Form2.smethod_22((Control)(object)button1, new Point(86, 193));
					num = (int)(num2 * 1154371321) ^ -1693678335;
					continue;
				case 56u:
					Form2.smethod_25((Control)(object)button1, 3);
					num = ((int)num2 * -969898293) ^ -1156607122;
					continue;
				case 55u:
					label1 = Form2.smethod_17();
					num = ((int)num2 * -1279675223) ^ 0x6D391CEE;
					continue;
				case 54u:
					Form2.smethod_1((Control)(object)this, "Жеребьёвка");
					num = (int)(num2 * 649750768) ^ -807204145;
					continue;
				case 53u:
					Form2.smethod_23((Control)(object)label2, "label2");
					Form2.smethod_24((Control)(object)label2, new Size(188, 73));
					num = (int)((num2 * 990802488) ^ 0x5F860CF4);
					continue;
				case 52u:
					Form2.smethod_39((Control)(object)this, "Form2");
					num = (int)((num2 * 201883736) ^ 0x3F057D1C);
					continue;
				case 51u:
					label2 = Form2.smethod_17();
					button1 = Form2.smethod_19();
					num = ((int)num2 * -107969713) ^ 0xE766E9F;
					continue;
				case 50u:
					num = (int)((num2 * 432191533) ^ 0x2B22A0B9);
					continue;
				case 49u:
					Form2.smethod_41((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
					num = (int)((num2 * 1816727008) ^ 0x79F637AD);
					continue;
				case 48u:
					Form2.smethod_33((Form)(object)this, new Size(255, 224));
					num = (int)(num2 * 63711177) ^ -1914168001;
					continue;
				case 47u:
					Form2.smethod_22((Control)(object)label2, new Point(53, 89));
					num = ((int)num2 * -606608629) ^ 0x14DDFBF2;
					continue;
				case 46u:
					Form2.smethod_23((Control)(object)label1, "label1");
					num = ((int)num2 * -1124043394) ^ 0x74F93AF4;
					continue;
				case 45u:
					num = ((int)num2 * -1166851024) ^ -1935802110;
					continue;
				case 44u:
					Form2.smethod_24((Control)(object)textBox1, new Size(42, 80));
					num = ((int)num2 * -490453566) ^ -1801658044;
					continue;
				case 43u:
					num = ((int)num2 * -1696073137) ^ 0x7936F792;
					continue;
				case 42u:
					Form2.smethod_1((Control)(object)label1, "label1");
					Form2.smethod_27((Control)(object)textBox1, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 510434170) ^ -1050887935;
					continue;
				case 41u:
					Form2.smethod_36((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -970603820) ^ -492767486;
					continue;
				case 40u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label3);
					num = (int)((num2 * 1066651012) ^ 0x2488610E);
					continue;
				case 39u:
					Form2.smethod_25((Control)(object)label1, 0);
					num = (int)(num2 * 616500435) ^ -118069321;
					continue;
				case 38u:
					Form2.smethod_1((Control)(object)button1, "OK");
					num = ((int)num2 * -10900228) ^ -239865740;
					continue;
				case 37u:
					Form2.smethod_29((ButtonBase)(object)button1, bool_0: true);
					num = (int)((num2 * 532372105) ^ 0x4E8CE958);
					continue;
				case 36u:
					Form2.smethod_40((Form)(object)this, bool_0: false);
					num = ((int)num2 * -2000473175) ^ 0x5350CD6F;
					continue;
				case 35u:
					textBox1 = Form2.smethod_18();
					num = (int)(num2 * 1110145635) ^ -1077024180;
					continue;
				case 34u:
					Form2.smethod_37((Form)(object)this, bool_0: false);
					num = (int)((num2 * 2125772536) ^ 0x193E291F);
					continue;
				case 33u:
					num = ((int)num2 * -2062657406) ^ 0x5643D632;
					continue;
				case 32u:
					Form2.smethod_25((Control)(object)label2, 2);
					Form2.smethod_1((Control)(object)label2, "+N=?");
					num = (int)((num2 * 181503032) ^ 0xA47B7E1);
					continue;
				case 31u:
					num = ((int)num2 * -1671822405) ^ -200781665;
					continue;
				case 29u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label1);
					num = (int)((num2 * 1213925168) ^ 0x30F5D03);
					continue;
				case 28u:
					num = ((int)num2 * -1039527693) ^ 0x53A33263;
					continue;
				case 27u:
					Form2.smethod_25((Control)(object)label3, 4);
					num = ((int)num2 * -1767239825) ^ -1737623458;
					continue;
				case 26u:
					Form2.smethod_25((Control)(object)textBox1, 1);
					num = ((int)num2 * -1368371148) ^ -2082702638;
					continue;
				case 25u:
					Form2.smethod_20((Control)(object)this);
					num = (int)((num2 * 475321292) ^ 0x4868B785);
					continue;
				case 23u:
					Form2.smethod_32((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -1709635863) ^ -814547282;
					continue;
				case 22u:
					num = ((int)num2 * -815420252) ^ -1035449576;
					continue;
				case 21u:
					Form2.smethod_27((Control)(object)label2, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 1097850741) ^ 0x2ACF625A);
					continue;
				case 20u:
					num = (int)((num2 * 1263867516) ^ 0x4FB420BA);
					continue;
				case 19u:
					Form2.smethod_42((Control)(object)this, bool_0: false);
					num = ((int)num2 * -610026458) ^ 0x44D3DB3C;
					continue;
				case 18u:
					num = ((int)num2 * -152706622) ^ -475339991;
					continue;
				case 17u:
					num = (int)(num2 * 1034194344) ^ -1751299051;
					continue;
				case 16u:
					num = ((int)num2 * -635884837) ^ 0x783925FA;
					continue;
				case 15u:
					num = (int)(num2 * 100800967) ^ -1117361729;
					continue;
				case 14u:
					num = (int)(num2 * 921391611) ^ -838228224;
					continue;
				case 13u:
					Form2.smethod_22((Control)(object)textBox1, new Point(24, 86));
					num = ((int)num2 * -942791491) ^ 0x713095D5;
					continue;
				case 12u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -218051331) ^ 0x2BFF9993;
					continue;
				case 11u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label2);
					num = (int)(num2 * 1823438971) ^ -1176646280;
					continue;
				case 10u:
					num = ((int)num2 * -1741374896) ^ -654431472;
					continue;
				case 9u:
					Form2.smethod_28((Control)(object)textBox1, new KeyPressEventHandler(TextBox1_KeyPress));
					Form2.smethod_21((Control)(object)label2, bool_0: true);
					num = (int)((num2 * 131042805) ^ 0x4EC99248);
					continue;
				case 8u:
					Form2.smethod_24((Control)(object)label3, new Size(0, 13));
					num = (int)(num2 * 1055850154) ^ -2080330109;
					continue;
				case 7u:
					Form2.smethod_38((Form)(object)this, bool_0: false);
					num = (int)((num2 * 365535459) ^ 0x5629BF69);
					continue;
				case 6u:
					Form2.smethod_23((Control)(object)button1, "button1");
					Form2.smethod_24((Control)(object)button1, new Size(73, 23));
					num = ((int)num2 * -1686792525) ^ -1294081238;
					continue;
				case 5u:
					Form2.smethod_31((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -1818055384) ^ 0x6546114B;
					continue;
				case 4u:
					label3 = Form2.smethod_17();
					num = (int)(num2 * 1682467230) ^ -921986045;
					continue;
				case 3u:
					Form2.smethod_21((Control)(object)label1, bool_0: true);
					Form2.smethod_22((Control)(object)label1, new Point(10, 10));
					num = (int)((num2 * 1987038551) ^ 0x669F0610);
					continue;
				case 2u:
					Form2.smethod_23((Control)(object)textBox1, "textBox1");
					num = (int)((num2 * 1283468226) ^ 0x3AF37AE2);
					continue;
				case 1u:
					num = ((int)num2 * -15562547) ^ -496434361;
					continue;
				case 0u:
					num = (int)((num2 * 646655832) ^ 0x16D7EF8F);
					continue;
				case 24u:
					break;
				default:
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
