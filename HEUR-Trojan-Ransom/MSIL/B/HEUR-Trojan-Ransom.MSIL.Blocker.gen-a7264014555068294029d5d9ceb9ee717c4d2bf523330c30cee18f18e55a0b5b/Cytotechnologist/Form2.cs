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
			int num = -1783899620;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x90069FF9u) % 6u)
				{
				case 5u:
					num = ((int)num2 * -1474170330) ^ 0x1A1F439;
					continue;
				case 4u:
					Form2.smethod_1((Control)(object)label1, "Введите любое число от 0 до 9 включительно.\nВаш соперник уже загадал число (N) из этого\nже диапазона. Если сумма ваших чисел будет\nчетным числом, то первым ход делаете Вы,\nиначе - ваш соперник Компьютер!");
					num = (int)((num2 * 1682649939) ^ 0x2D59516);
					continue;
				case 2u:
					num = (int)((num2 * 414138404) ^ 0x48645A08);
					continue;
				case 1u:
					InitializeComponent();
					num = ((int)num2 * -1067347871) ^ -1998157922;
					continue;
				default:
					return;
				case 0u:
					break;
				case 3u:
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
			int num = 1806267671;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1FC4D62u) % 3u)
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
				num = (int)((num2 * 1249805868) ^ 0x4B68D9A);
			}
		}
	}

	private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsDigit(Form2.smethod_4(e)))
		{
			goto IL_0055;
		}
		goto IL_00bf;
		IL_00bf:
		Form2.smethod_1((Control)(object)textBox1, "");
		int num = -1034905766;
		goto IL_008e;
		IL_008e:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xACCC8332u) % 8u)
			{
			case 7u:
				num = (int)((num2 * 114325198) ^ 0x688DF831);
				continue;
			case 6u:
				Button1_Click(this, Form2.smethod_6());
				num = (int)(num2 * 674333358) ^ -1449490791;
				continue;
			case 5u:
				Form2.smethod_5(e, bool_0: true);
				num = ((int)num2 * -1920615952) ^ -1939267544;
				continue;
			case 4u:
				break;
			case 2u:
				num = ((int)num2 * -1883753441) ^ -455560116;
				continue;
			case 0u:
				goto IL_006b;
			default:
				return;
			case 3u:
				goto IL_00bf;
			case 1u:
				return;
			}
			break;
			IL_006b:
			int num3;
			if (Form2.smethod_4(e) != '\r')
			{
				num = -1303116893;
				num3 = -1303116893;
			}
			else
			{
				num = -178825236;
				num3 = -178825236;
			}
		}
		goto IL_0055;
		IL_0055:
		num = -434817601;
		goto IL_008e;
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		bool flag4 = default(bool);
		bool flag2 = default(bool);
		bool flag = default(bool);
		bool flag3 = default(bool);
		int num5 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 129293633;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x42F2C2Bu) % 29u)
				{
				case 28u:
					num = (int)((num2 * 1951531303) ^ 0x1628D397);
					continue;
				case 27u:
					Form2.smethod_1((Control)(object)label3, "Первым ход делает Компьютер.");
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = false;
					num = 897430808;
					continue;
				case 25u:
					num = (int)((num2 * 1541222733) ^ 0x58449E19);
					continue;
				case 23u:
					flag4 = Form2.smethod_8(Form2.smethod_7((Control)(object)textBox1), "");
					num = (int)((num2 * 2115420551) ^ 0x1ED67134);
					continue;
				case 22u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).StartGame();
					num = (int)(num2 * 1541038344) ^ -1180393037;
					continue;
				case 21u:
					Form2.smethod_15((Form)(object)this);
					num = ((int)num2 * -1163393851) ^ -1962524648;
					continue;
				case 20u:
					Form2.smethod_14(Form2.smethod_11(Form2.smethod_2((Form)(object)this)));
					num = (int)(num2 * 846475989) ^ -711417100;
					continue;
				case 19u:
				{
					int num8;
					int num9;
					if (!flag2)
					{
						num8 = -1240129968;
						num9 = -1240129968;
					}
					else
					{
						num8 = -1489007446;
						num9 = -1489007446;
					}
					num = num8 ^ ((int)num2 * -1722543966);
					continue;
				}
				case 18u:
				{
					int num12;
					int num13;
					if (flag)
					{
						num12 = -1941964245;
						num13 = -1941964245;
					}
					else
					{
						num12 = -1486480311;
						num13 = -1486480311;
					}
					num = num12 ^ ((int)num2 * -1528955606);
					continue;
				}
				case 17u:
					num = (int)(num2 * 517427969) ^ -1565074535;
					continue;
				case 16u:
				{
					int num10;
					int num11;
					if (flag4)
					{
						num10 = 728133551;
						num11 = 728133551;
					}
					else
					{
						num10 = 1521802272;
						num11 = 1521802272;
					}
					num = num10 ^ (int)(num2 * 771935255);
					continue;
				}
				case 15u:
				{
					int num6;
					int num7;
					if (!flag3)
					{
						num6 = -37377711;
						num7 = -37377711;
					}
					else
					{
						num6 = -1338339602;
						num7 = -1338339602;
					}
					num = num6 ^ ((int)num2 * -1529382226);
					continue;
				}
				case 14u:
					num = ((int)num2 * -495261019) ^ 0x69A56F8F;
					continue;
				case 13u:
					num = ((int)num2 * -768851177) ^ -924379095;
					continue;
				case 12u:
					this.flag = false;
					num = 1494520768;
					continue;
				case 11u:
					(Form2.smethod_2((Form)(object)this) as Form3).Button_Continue();
					num = ((int)num2 * -9467930) ^ 0xA7791DA;
					continue;
				case 10u:
					num = 2071746928;
					continue;
				case 9u:
					num = 2071746928;
					continue;
				case 8u:
					flag3 = this.flag;
					num = (int)(num2 * 1516874803) ^ -1549614962;
					continue;
				case 7u:
					num5 = int.Parse(Form2.smethod_7((Control)(object)textBox1));
					num4 = Form2.smethod_9(rnd, 10);
					num = (int)((num2 * 313914522) ^ 0x79ECCA67);
					continue;
				case 6u:
					Form2.smethod_1((Control)(object)label3, "Поздравляем! Ваш ход первый.");
					num = ((int)num2 * -273223133) ^ 0x65511C95;
					continue;
				case 5u:
					num = (int)((num2 * 1473049149) ^ 0x1368B53D);
					continue;
				case 4u:
					Form2.smethod_1((Control)(object)label2, Form2.smethod_10("+", num4.ToString(), "=", (num5 + num4).ToString()));
					flag2 = (num5 + num4) % 2 == 0;
					num = (int)((num2 * 1134699671) ^ 0x60BBCABB);
					continue;
				case 3u:
				{
					Form control_ = Form2.smethod_2((Form)(object)this);
					int num3 = Form2.smethod_12((Control)(object)control_) - 1;
					Form2.smethod_13((Control)(object)control_, num3);
					flag = num3 > 1;
					num = 1346018830;
					continue;
				}
				case 2u:
					num = ((int)num2 * -79295545) ^ 0xEF7B6B6;
					continue;
				case 1u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = true;
					num = ((int)num2 * -1262867698) ^ 0x743D53C2;
					continue;
				case 0u:
					num = 304695679;
					continue;
				default:
					return;
				case 26u:
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
		if (disposing)
		{
			goto IL_004d;
		}
		goto IL_00ac;
		IL_004d:
		int num = 788102481;
		goto IL_0070;
		IL_0070:
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xDC9A546u) % 8u)
			{
			case 6u:
				((Form)this).Dispose(disposing);
				num = 1860600090;
				continue;
			case 5u:
				Form2.smethod_16((IDisposable)components);
				num = ((int)num2 * -1181436208) ^ -684802850;
				continue;
			case 4u:
				num = (int)(num2 * 791215421) ^ -1664317088;
				continue;
			case 3u:
				break;
			case 1u:
				num = ((int)num2 * -1872578618) ^ 0x3475F3AE;
				continue;
			case 0u:
				num = ((int)num2 * -609465626) ^ -1484502137;
				continue;
			default:
				return;
			case 7u:
				goto IL_00a1;
			case 2u:
				return;
			}
			break;
			IL_00a1:
			if (components != null)
			{
				num = 471071915;
				num3 = 471071915;
				continue;
			}
			goto IL_00ac;
		}
		goto IL_004d;
		IL_00ac:
		num = 302721224;
		num3 = 302721224;
		goto IL_0070;
	}

	private void InitializeComponent()
	{
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Expected O, but got Unknown
		//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04df: Expected O, but got Unknown
		while (true)
		{
			int num = 656899723;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7FFDF5F1u) % 61u)
				{
				case 60u:
					Form2.smethod_25((Control)(object)label1, 0);
					num = ((int)num2 * -1625757713) ^ -234957977;
					continue;
				case 59u:
					Form2.smethod_23((Control)(object)label1, "label1");
					num = ((int)num2 * -1820024924) ^ 0x4A8BDFCD;
					continue;
				case 58u:
					Form2.smethod_25((Control)(object)label3, 4);
					Form2.smethod_31((ContainerControl)(object)this, new SizeF(6f, 13f));
					Form2.smethod_32((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -1893806428) ^ 0x31B9319B;
					continue;
				case 57u:
					Form2.smethod_22((Control)(object)textBox1, new Point(24, 86));
					Form2.smethod_23((Control)(object)textBox1, "textBox1");
					Form2.smethod_24((Control)(object)textBox1, new Size(42, 80));
					Form2.smethod_25((Control)(object)textBox1, 1);
					num = (int)(num2 * 570962039) ^ -2123474741;
					continue;
				case 56u:
					Form2.smethod_22((Control)(object)button1, new Point(86, 193));
					num = ((int)num2 * -1066388440) ^ -1301044204;
					continue;
				case 55u:
					num = (int)(num2 * 166063429) ^ -1183746337;
					continue;
				case 54u:
					Form2.smethod_22((Control)(object)label2, new Point(53, 89));
					num = ((int)num2 * -794281889) ^ -1073894783;
					continue;
				case 53u:
					num = (int)(num2 * 592461703) ^ -1743423327;
					continue;
				case 52u:
					Form2.smethod_24((Control)(object)button1, new Size(73, 23));
					num = (int)(num2 * 1523499468) ^ -229195243;
					continue;
				case 51u:
					num = (int)((num2 * 380876583) ^ 0x72156EEB);
					continue;
				case 50u:
					label1 = Form2.smethod_17();
					num = ((int)num2 * -398835378) ^ -1044609453;
					continue;
				case 49u:
					Form2.smethod_21((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -1315407228) ^ -1428023620;
					continue;
				case 48u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label2);
					num = ((int)num2 * -1460572700) ^ -1346735851;
					continue;
				case 47u:
					Form2.smethod_24((Control)(object)label1, new Size(35, 13));
					num = ((int)num2 * -1762255868) ^ -141161778;
					continue;
				case 46u:
					Form2.smethod_27((Control)(object)textBox1, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1317291778) ^ -1351153348;
					continue;
				case 45u:
					Form2.smethod_33((Form)(object)this, new Size(255, 224));
					num = (int)(num2 * 1474720022) ^ -774169202;
					continue;
				case 44u:
					Form2.smethod_29((ButtonBase)(object)button1, bool_0: true);
					num = (int)(num2 * 1316083851) ^ -1243422094;
					continue;
				case 43u:
					num = ((int)num2 * -2138396780) ^ -1748258818;
					continue;
				case 42u:
					label2 = Form2.smethod_17();
					button1 = Form2.smethod_19();
					num = ((int)num2 * -623445388) ^ 0x33BCBA39;
					continue;
				case 41u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)button1);
					num = (int)(num2 * 990799379) ^ -6110106;
					continue;
				case 40u:
					Form2.smethod_22((Control)(object)label1, new Point(10, 10));
					num = (int)(num2 * 1567945905) ^ -1055434605;
					continue;
				case 39u:
					num = ((int)num2 * -448010742) ^ -1841569171;
					continue;
				case 38u:
					num = (int)(num2 * 943907026) ^ -9248052;
					continue;
				case 37u:
					num = ((int)num2 * -172240715) ^ -886483877;
					continue;
				case 36u:
					Form2.smethod_25((Control)(object)button1, 3);
					num = (int)(num2 * 1395122124) ^ -2107806476;
					continue;
				case 35u:
					Form2.smethod_42((Control)(object)this, bool_0: false);
					num = ((int)num2 * -443654135) ^ 0x60E408D2;
					continue;
				case 34u:
					num = ((int)num2 * -826549593) ^ 0x29AFBBFF;
					continue;
				case 33u:
					num = (int)((num2 * 533446224) ^ 0x6D1B637);
					continue;
				case 32u:
					Form2.smethod_28((Control)(object)textBox1, new KeyPressEventHandler(TextBox1_KeyPress));
					num = (int)(num2 * 132376749) ^ -71787773;
					continue;
				case 31u:
					num = ((int)num2 * -537372158) ^ 0x603C1A1D;
					continue;
				case 30u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label3);
					num = ((int)num2 * -429917820) ^ -944813605;
					continue;
				case 29u:
					num = (int)(num2 * 351221104) ^ -669708513;
					continue;
				case 28u:
					Form2.smethod_21((Control)(object)label2, bool_0: true);
					Form2.smethod_27((Control)(object)label2, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -2043988434) ^ 0x4E78FA36;
					continue;
				case 27u:
					Form2.smethod_43((Control)(object)this);
					num = ((int)num2 * -644262339) ^ -174942452;
					continue;
				case 26u:
					num = (int)((num2 * 862787579) ^ 0x33566A76);
					continue;
				case 25u:
					label3 = Form2.smethod_17();
					num = (int)((num2 * 1766364886) ^ 0x2BF6FD77);
					continue;
				case 24u:
					Form2.smethod_1((Control)(object)label2, "+N=?");
					num = ((int)num2 * -1634500234) ^ 0x16CDBAD3;
					continue;
				case 23u:
					num = ((int)num2 * -12059549) ^ -1552339600;
					continue;
				case 22u:
					Form2.smethod_40((Form)(object)this, bool_0: false);
					Form2.smethod_1((Control)(object)this, "Жеребьёвка");
					Form2.smethod_41((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
					num = ((int)num2 * -1707341024) ^ 0x625951C7;
					continue;
				case 21u:
					Form2.smethod_24((Control)(object)label3, new Size(0, 13));
					num = (int)((num2 * 1717126725) ^ 0x7AA3D6DF);
					continue;
				case 19u:
					Form2.smethod_20((Control)(object)this);
					num = ((int)num2 * -1654897254) ^ -1221880464;
					continue;
				case 18u:
					Form2.smethod_1((Control)(object)label1, "label1");
					num = (int)(num2 * 1993986736) ^ -147216114;
					continue;
				case 17u:
					num = (int)((num2 * 1860140066) ^ 0xBA03429);
					continue;
				case 16u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label1);
					num = (int)((num2 * 1216018106) ^ 0xBD1B5D3);
					continue;
				case 14u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)textBox1);
					num = (int)((num2 * 849212990) ^ 0x5AAC5192);
					continue;
				case 13u:
					num = ((int)num2 * -1380495415) ^ -1328629982;
					continue;
				case 12u:
					Form2.smethod_36((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -1074503826) ^ 0x58687EF5;
					continue;
				case 11u:
					textBox1 = Form2.smethod_18();
					num = ((int)num2 * -944188463) ^ 0x30D92859;
					continue;
				case 10u:
					num = (int)((num2 * 219487392) ^ 0x66278183);
					continue;
				case 9u:
					num = (int)((num2 * 1701197408) ^ 0x25EFFF5D);
					continue;
				case 8u:
					Form2.smethod_37((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1034548397) ^ 0x53C0FAFE;
					continue;
				case 7u:
					Form2.smethod_21((Control)(object)label3, bool_0: true);
					Form2.smethod_22((Control)(object)label3, new Point(47, 177));
					num = (int)(num2 * 403260875) ^ -878660237;
					continue;
				case 6u:
					Form2.smethod_23((Control)(object)label3, "label3");
					num = ((int)num2 * -1842311124) ^ 0x5075827C;
					continue;
				case 5u:
					Form2.smethod_1((Control)(object)button1, "OK");
					num = (int)(num2 * 120713566) ^ -1189603868;
					continue;
				case 4u:
					Form2.smethod_23((Control)(object)button1, "button1");
					num = ((int)num2 * -1853512309) ^ -1964487635;
					continue;
				case 3u:
					Form2.smethod_24((Control)(object)label2, new Size(188, 73));
					Form2.smethod_25((Control)(object)label2, 2);
					num = (int)((num2 * 179469849) ^ 0x11418190);
					continue;
				case 2u:
					Form2.smethod_30((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)((num2 * 1485341038) ^ 0x1B45304C);
					continue;
				case 1u:
					Form2.smethod_38((Form)(object)this, bool_0: false);
					Form2.smethod_39((Control)(object)this, "Form2");
					num = ((int)num2 * -1308521714) ^ -655617650;
					continue;
				case 0u:
					Form2.smethod_23((Control)(object)label2, "label2");
					num = ((int)num2 * -1120548835) ^ 0x79AACB39;
					continue;
				default:
					return;
				case 15u:
					break;
				case 20u:
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
