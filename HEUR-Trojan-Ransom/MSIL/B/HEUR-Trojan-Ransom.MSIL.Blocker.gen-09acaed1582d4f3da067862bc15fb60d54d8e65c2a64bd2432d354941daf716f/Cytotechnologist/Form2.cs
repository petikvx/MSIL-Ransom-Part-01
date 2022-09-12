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
		bool flag = !char.IsDigit(Form2.smethod_4(e));
		while (true)
		{
			int num = -49651966;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD6EEE619u) % 10u)
				{
				case 9u:
					Form2.smethod_1((Control)(object)textBox1, "");
					num = -1371261684;
					continue;
				case 8u:
					num = ((int)num2 * -2105729688) ^ -2036650916;
					continue;
				case 7u:
				{
					int num5;
					if (Form2.smethod_4(e) != '\r')
					{
						num = -1874879809;
						num5 = -1874879809;
					}
					else
					{
						num = -290988520;
						num5 = -290988520;
					}
					continue;
				}
				case 6u:
					num = ((int)num2 * -1260419723) ^ 0x4E1E3D;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -692563769;
						num4 = -692563769;
					}
					else
					{
						num3 = -112924510;
						num4 = -112924510;
					}
					num = num3 ^ (int)(num2 * 1969371923);
					continue;
				}
				case 2u:
					num = ((int)num2 * -2134382761) ^ -1076466827;
					continue;
				case 1u:
					Button1_Click(this, Form2.smethod_6());
					num = (int)((num2 * 2038976428) ^ 0x1529D9F3);
					continue;
				case 0u:
					Form2.smethod_5(e, bool_0: true);
					num = (int)(num2 * 1000312247) ^ -1291216015;
					continue;
				default:
					return;
				case 5u:
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
		bool flag = Form2.smethod_8(Form2.smethod_7((Control)(object)textBox1), "");
		int num6 = default(int);
		int num5 = default(int);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 1930773768;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x78830DD4u) % 30u)
				{
				case 29u:
				{
					int num12;
					int num13;
					if (!this.flag)
					{
						num12 = -315815639;
						num13 = -315815639;
					}
					else
					{
						num12 = -2016007251;
						num13 = -2016007251;
					}
					num = num12 ^ ((int)num2 * -348812954);
					continue;
				}
				case 28u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = true;
					num = ((int)num2 * -317393658) ^ 0x7CE4EDB1;
					continue;
				case 27u:
					num = 640858732;
					continue;
				case 26u:
					num = (int)(num2 * 1647615716) ^ -91121423;
					continue;
				case 25u:
					num = ((int)num2 * -679465244) ^ 0x69E8F90;
					continue;
				case 23u:
					(Form2.smethod_2((Form)(object)this) as Form3).Button_Continue();
					num = ((int)num2 * -1098955340) ^ 0x3BE15626;
					continue;
				case 22u:
					num = ((int)num2 * -363122428) ^ 0x636AA844;
					continue;
				case 21u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).StartGame();
					num = ((int)num2 * -1624338418) ^ 0x76825755;
					continue;
				case 20u:
					Form2.smethod_1((Control)(object)label3, "Первым ход делает Компьютер.");
					num = (int)((num2 * 1516413021) ^ 0x29D3F238);
					continue;
				case 19u:
					num6 = int.Parse(Form2.smethod_7((Control)(object)textBox1));
					num = ((int)num2 * -315225606) ^ 0x2C3495A7;
					continue;
				case 18u:
				{
					int num10;
					int num11;
					if (flag)
					{
						num10 = 786884826;
						num11 = 786884826;
					}
					else
					{
						num10 = 613671656;
						num11 = 613671656;
					}
					num = num10 ^ (int)(num2 * 1663872989);
					continue;
				}
				case 17u:
					num = 1925753604;
					continue;
				case 16u:
					Form2.smethod_1((Control)(object)label3, "Поздравляем! Ваш ход первый.");
					num = ((int)num2 * -137524162) ^ 0x40C4F7DA;
					continue;
				case 15u:
					num = (int)((num2 * 1468943620) ^ 0x53A05731);
					continue;
				case 13u:
					num5 = Form2.smethod_9(rnd, 10);
					num = ((int)num2 * -1481421727) ^ -1859695104;
					continue;
				case 12u:
					num = 851590022;
					continue;
				case 11u:
					num = ((int)num2 * -385384716) ^ -1155322050;
					continue;
				case 10u:
					num = ((int)num2 * -1143011031) ^ -1982179299;
					continue;
				case 9u:
					Form2.smethod_14(Form2.smethod_11(Form2.smethod_2((Form)(object)this)));
					num = ((int)num2 * -178016264) ^ -1181149602;
					continue;
				case 8u:
				{
					Form control_ = Form2.smethod_2((Form)(object)this);
					int num9 = Form2.smethod_12((Control)(object)control_) - 1;
					Form2.smethod_13((Control)(object)control_, num9);
					flag2 = num9 > 1;
					num = 1343927753;
					continue;
				}
				case 7u:
				{
					Form2.smethod_1((Control)(object)label2, Form2.smethod_10("+", num5.ToString(), "=", (num6 + num5).ToString()));
					int num7;
					int num8;
					if ((num6 + num5) % 2 == 0)
					{
						num7 = 1396323775;
						num8 = 1396323775;
					}
					else
					{
						num7 = 264719305;
						num8 = 264719305;
					}
					num = num7 ^ (int)(num2 * 746669179);
					continue;
				}
				case 6u:
					Form2.smethod_15((Form)(object)this);
					num = ((int)num2 * -1925914992) ^ 0x1F6439BB;
					continue;
				case 5u:
					num = 640858732;
					continue;
				case 4u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = false;
					num = (int)(num2 * 430005769) ^ -1626861773;
					continue;
				case 3u:
					this.flag = false;
					num = 947367917;
					continue;
				case 2u:
					num = ((int)num2 * -82976553) ^ 0x29FB322F;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag2)
					{
						num3 = 2000861287;
						num4 = 2000861287;
					}
					else
					{
						num3 = 986735021;
						num4 = 986735021;
					}
					num = num3 ^ (int)(num2 * 134918438);
					continue;
				}
				case 0u:
					num = ((int)num2 * -192762990) ^ -1302071203;
					continue;
				default:
					return;
				case 14u:
					break;
				case 24u:
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
		goto IL_004d;
		IL_004d:
		int num = -538907583;
		goto IL_0052;
		IL_0052:
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xC0BE6BA1u) % 6u)
			{
			case 5u:
				num = (int)((num2 * 2062664175) ^ 0x50F57265);
				continue;
			case 3u:
				((Form)this).Dispose(disposing);
				num = -479808163;
				continue;
			case 1u:
				Form2.smethod_16((IDisposable)components);
				num = (int)((num2 * 301514024) ^ 0x70B87368);
				continue;
			case 0u:
				break;
			default:
				return;
			case 4u:
				goto IL_007b;
			case 2u:
				return;
			}
			break;
			IL_007b:
			if (components != null)
			{
				num = -840427358;
				num3 = -840427358;
				continue;
			}
			goto IL_0009;
		}
		goto IL_004d;
		IL_0009:
		num = -1864819366;
		num3 = -1864819366;
		goto IL_0052;
	}

	private void InitializeComponent()
	{
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Expected O, but got Unknown
		//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e2: Expected O, but got Unknown
		while (true)
		{
			int num = -2044659044;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAA39DD5Fu) % 65u)
				{
				case 64u:
					Form2.smethod_30((Control)(object)button1, (EventHandler)Button1_Click);
					Form2.smethod_21((Control)(object)label3, bool_0: true);
					num = (int)(num2 * 1102296583) ^ -1151706290;
					continue;
				case 63u:
					Form2.smethod_40((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1774973316) ^ -1512588980;
					continue;
				case 62u:
					num = (int)((num2 * 1751002063) ^ 0x11B165CC);
					continue;
				case 61u:
					num = (int)((num2 * 396921529) ^ 0x1BC40469);
					continue;
				case 60u:
					Form2.smethod_33((Form)(object)this, new Size(255, 224));
					num = (int)((num2 * 1665288965) ^ 0x57EAD3ED);
					continue;
				case 59u:
					Form2.smethod_20((Control)(object)this);
					num = (int)((num2 * 1821249493) ^ 0x16D12B6F);
					continue;
				case 58u:
					num = ((int)num2 * -1766383597) ^ -1765110323;
					continue;
				case 57u:
					num = (int)((num2 * 85753888) ^ 0x5E109861);
					continue;
				case 56u:
					Form2.smethod_42((Control)(object)this, bool_0: false);
					num = (int)(num2 * 241930627) ^ -692066973;
					continue;
				case 54u:
					Form2.smethod_24((Control)(object)label2, new Size(188, 73));
					num = ((int)num2 * -1525989286) ^ 0x23040FE7;
					continue;
				case 53u:
					Form2.smethod_23((Control)(object)label1, "label1");
					num = (int)(num2 * 1249037454) ^ -573839837;
					continue;
				case 52u:
					Form2.smethod_22((Control)(object)label1, new Point(10, 10));
					num = ((int)num2 * -1815954009) ^ -1401926233;
					continue;
				case 51u:
					Form2.smethod_25((Control)(object)textBox1, 1);
					num = (int)(num2 * 374190707) ^ -146879680;
					continue;
				case 50u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)button1);
					num = (int)(num2 * 1672858142) ^ -1199299898;
					continue;
				case 49u:
					Form2.smethod_22((Control)(object)label2, new Point(53, 89));
					num = ((int)num2 * -850273809) ^ 0x736F454;
					continue;
				case 48u:
					Form2.smethod_27((Control)(object)textBox1, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form2.smethod_22((Control)(object)textBox1, new Point(24, 86));
					Form2.smethod_23((Control)(object)textBox1, "textBox1");
					num = (int)(num2 * 645677247) ^ -1238909248;
					continue;
				case 47u:
					num = (int)((num2 * 609225783) ^ 0x469DF33F);
					continue;
				case 46u:
					Form2.smethod_36((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -1841779638) ^ -1368373993;
					continue;
				case 45u:
					num = (int)(num2 * 1465406904) ^ -695930805;
					continue;
				case 44u:
					Form2.smethod_24((Control)(object)textBox1, new Size(42, 80));
					num = ((int)num2 * -668492703) ^ 0x5BE0614C;
					continue;
				case 43u:
					Form2.smethod_25((Control)(object)button1, 3);
					num = ((int)num2 * -12222883) ^ -1519606029;
					continue;
				case 42u:
					Form2.smethod_39((Control)(object)this, "Form2");
					num = (int)(num2 * 1861176450) ^ -1657490332;
					continue;
				case 41u:
					Form2.smethod_23((Control)(object)button1, "button1");
					num = (int)((num2 * 212306664) ^ 0x8A0668D);
					continue;
				case 40u:
					Form2.smethod_22((Control)(object)label3, new Point(47, 177));
					num = ((int)num2 * -2097383617) ^ -302703085;
					continue;
				case 39u:
					Form2.smethod_23((Control)(object)label3, "label3");
					num = ((int)num2 * -672714639) ^ 0x570CF004;
					continue;
				case 38u:
					Form2.smethod_21((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -617090234) ^ 0x242851EE;
					continue;
				case 37u:
					label2 = Form2.smethod_17();
					num = (int)((num2 * 1168353455) ^ 0x2E18133E);
					continue;
				case 36u:
					num = ((int)num2 * -1458420979) ^ -1718418386;
					continue;
				case 35u:
					num = ((int)num2 * -1239069619) ^ 0x58E91F6F;
					continue;
				case 34u:
					Form2.smethod_25((Control)(object)label1, 0);
					num = ((int)num2 * -1275943891) ^ 0x4358D8EF;
					continue;
				case 33u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label3);
					num = ((int)num2 * -1394238615) ^ 0x4237DCEB;
					continue;
				case 32u:
					Form2.smethod_25((Control)(object)label2, 2);
					Form2.smethod_1((Control)(object)label2, "+N=?");
					Form2.smethod_22((Control)(object)button1, new Point(86, 193));
					num = ((int)num2 * -1901716371) ^ -967400926;
					continue;
				case 31u:
					num = (int)(num2 * 1959042843) ^ -2004025990;
					continue;
				case 30u:
					button1 = Form2.smethod_19();
					label3 = Form2.smethod_17();
					num = ((int)num2 * -1798059965) ^ 0x53BD2B4E;
					continue;
				case 29u:
					Form2.smethod_41((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
					num = ((int)num2 * -1409493650) ^ 0x4BA9E8F0;
					continue;
				case 28u:
					label1 = Form2.smethod_17();
					textBox1 = Form2.smethod_18();
					num = ((int)num2 * -1884498454) ^ 0x4666422B;
					continue;
				case 27u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)textBox1);
					num = (int)(num2 * 46902743) ^ -36114857;
					continue;
				case 26u:
					Form2.smethod_31((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -1591763575) ^ 0x7D180536;
					continue;
				case 25u:
					Form2.smethod_24((Control)(object)label3, new Size(0, 13));
					num = (int)(num2 * 913739900) ^ -1010460790;
					continue;
				case 24u:
					num = ((int)num2 * -1807696248) ^ -1831082711;
					continue;
				case 23u:
					num = ((int)num2 * -408627298) ^ -611254997;
					continue;
				case 21u:
					num = (int)(num2 * 1806151248) ^ -316095044;
					continue;
				case 20u:
					Form2.smethod_43((Control)(object)this);
					num = (int)(num2 * 346132040) ^ -2015199959;
					continue;
				case 19u:
					Form2.smethod_37((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1969187685) ^ -207286996;
					continue;
				case 18u:
					num = (int)((num2 * 1682086902) ^ 0x6EED5A6);
					continue;
				case 17u:
					num = ((int)num2 * -1015066227) ^ -1023660384;
					continue;
				case 16u:
					num = (int)(num2 * 358748211) ^ -1456055026;
					continue;
				case 15u:
					Form2.smethod_24((Control)(object)button1, new Size(73, 23));
					num = (int)(num2 * 763349867) ^ -786404476;
					continue;
				case 14u:
					Form2.smethod_28((Control)(object)textBox1, new KeyPressEventHandler(TextBox1_KeyPress));
					num = (int)(num2 * 1800427929) ^ -716426441;
					continue;
				case 13u:
					Form2.smethod_32((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -101361340) ^ -479428008;
					continue;
				case 12u:
					Form2.smethod_23((Control)(object)label2, "label2");
					num = ((int)num2 * -1628988213) ^ 0x2CE222F6;
					continue;
				case 11u:
					Form2.smethod_1((Control)(object)label1, "label1");
					num = ((int)num2 * -392060596) ^ 0x70C3BF53;
					continue;
				case 10u:
					Form2.smethod_1((Control)(object)button1, "OK");
					num = (int)(num2 * 679985343) ^ -987168062;
					continue;
				case 9u:
					num = ((int)num2 * -80305425) ^ -2117470668;
					continue;
				case 8u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label2);
					num = ((int)num2 * -1599484149) ^ 0x6429FC97;
					continue;
				case 7u:
					num = ((int)num2 * -1296216065) ^ 0x5EBD7F8E;
					continue;
				case 6u:
					Form2.smethod_38((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1778083104) ^ -391332018;
					continue;
				case 5u:
					Form2.smethod_24((Control)(object)label1, new Size(35, 13));
					num = ((int)num2 * -450177117) ^ 0x7352ADB7;
					continue;
				case 4u:
					Form2.smethod_21((Control)(object)label2, bool_0: true);
					Form2.smethod_27((Control)(object)label2, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -415678666) ^ -992927356;
					continue;
				case 3u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label1);
					num = (int)((num2 * 1950607437) ^ 0x5A605A3F);
					continue;
				case 2u:
					Form2.smethod_29((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -2128289480) ^ 0x3BB27AD6;
					continue;
				case 1u:
					Form2.smethod_25((Control)(object)label3, 4);
					num = (int)(num2 * 1728858986) ^ -1527670461;
					continue;
				case 0u:
					Form2.smethod_1((Control)(object)this, "Жеребьёвка");
					num = (int)(num2 * 2078553367) ^ -1781577611;
					continue;
				default:
					return;
				case 55u:
					break;
				case 22u:
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
