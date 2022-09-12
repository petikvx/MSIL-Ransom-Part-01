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
			int num = 1023611583;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x29997D2Bu) % 7u)
				{
				case 5u:
					num = (int)(num2 * 695045879) ^ -437973823;
					continue;
				case 3u:
					num = (int)((num2 * 358603815) ^ 0x2AE95936);
					continue;
				case 2u:
					num = (int)(num2 * 761802046) ^ -1808852944;
					continue;
				case 1u:
					InitializeComponent();
					num = ((int)num2 * -1366516314) ^ 0x6772A8E3;
					continue;
				case 0u:
					Form2.smethod_1((Control)(object)label1, "Введите любое число от 0 до 9 включительно.\nВаш соперник уже загадал число (N) из этого\nже диапазона. Если сумма ваших чисел будет\nчетным числом, то первым ход делаете Вы,\nиначе - ваш соперник Компьютер!");
					num = ((int)num2 * -1826835276) ^ -565729663;
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

	private void Form2_FormClosed(object sender, FormClosedEventArgs e)
	{
		Form2.smethod_3((Control)(object)Form2.smethod_2((Form)(object)this), bool_0: true);
	}

	private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		while (true)
		{
			int num = 1081032764;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x64CC2BADu) % 9u)
				{
				case 8u:
					num = (int)((num2 * 1851671553) ^ 0x5E8FA234);
					continue;
				case 7u:
					Form2.smethod_1((Control)(object)textBox1, "");
					num = 1990062436;
					continue;
				case 6u:
					Button1_Click(this, Form2.smethod_6());
					num = ((int)num2 * -250583091) ^ -995528290;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (char.IsDigit(Form2.smethod_4(e)))
					{
						num4 = 141435843;
						num5 = 141435843;
					}
					else
					{
						num4 = 426136805;
						num5 = 426136805;
					}
					num = num4 ^ (int)(num2 * 1980019975);
					continue;
				}
				case 3u:
					Form2.smethod_5(e, bool_0: true);
					num = ((int)num2 * -2084494531) ^ -1355228306;
					continue;
				case 2u:
					num = (int)((num2 * 1262172636) ^ 0x690B3BC8);
					continue;
				case 1u:
				{
					int num3;
					if (Form2.smethod_4(e) == '\r')
					{
						num = 2100782794;
						num3 = 2100782794;
					}
					else
					{
						num = 1937251813;
						num3 = 1937251813;
					}
					continue;
				}
				default:
					return;
				case 0u:
					break;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		int num7 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		bool flag4 = default(bool);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -1985385027;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9C3D0A77u) % 33u)
				{
				case 32u:
					num7 = int.Parse(Form2.smethod_7((Control)(object)textBox1));
					num = (int)((num2 * 1838001533) ^ 0x20237E65);
					continue;
				case 31u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = true;
					num = ((int)num2 * -1127571948) ^ 0x5CDFA90B;
					continue;
				case 30u:
					num = -669291364;
					continue;
				case 29u:
					num = -392590859;
					continue;
				case 28u:
				{
					Label control_2 = label2;
					string string_ = num3.ToString();
					num4 = num7 + num3;
					Form2.smethod_1((Control)(object)control_2, Form2.smethod_10("+", string_, "=", num4.ToString()));
					num = (int)((num2 * 111623803) ^ 0x32039999);
					continue;
				}
				case 27u:
				{
					int num10;
					int num11;
					if (!flag4)
					{
						num10 = -525778035;
						num11 = -525778035;
					}
					else
					{
						num10 = -1230018574;
						num11 = -1230018574;
					}
					num = num10 ^ ((int)num2 * -800744389);
					continue;
				}
				case 26u:
					flag3 = num4 > 1;
					num = (int)((num2 * 1874137989) ^ 0x5C93DF2A);
					continue;
				case 25u:
					num = (int)(num2 * 1412996137) ^ -166370986;
					continue;
				case 24u:
					Form2.smethod_1((Control)(object)label3, "Поздравляем! Ваш ход первый.");
					num = ((int)num2 * -1136392375) ^ 0x7D2DBBEC;
					continue;
				case 23u:
				{
					int num12;
					int num13;
					if (flag3)
					{
						num12 = -1092975082;
						num13 = -1092975082;
					}
					else
					{
						num12 = -1499645302;
						num13 = -1499645302;
					}
					num = num12 ^ (int)(num2 * 507780730);
					continue;
				}
				case 22u:
				{
					int num8;
					int num9;
					if (flag2)
					{
						num8 = 1238054305;
						num9 = 1238054305;
					}
					else
					{
						num8 = 1397415698;
						num9 = 1397415698;
					}
					num = num8 ^ (int)(num2 * 469010347);
					continue;
				}
				case 21u:
					Form2.smethod_1((Control)(object)label3, "Первым ход делает Компьютер.");
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = false;
					num = (int)((num2 * 763975509) ^ 0x6E7DD15B);
					continue;
				case 20u:
					num = (int)(num2 * 374660512) ^ -2105245779;
					continue;
				case 19u:
					num = (int)(num2 * 304377942) ^ -399057223;
					continue;
				case 18u:
					flag4 = (num7 + num3) % 2 == 0;
					num = (int)((num2 * 256281753) ^ 0x2D7B1278);
					continue;
				case 17u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = 1316029016;
						num6 = 1316029016;
					}
					else
					{
						num5 = 270244414;
						num6 = 270244414;
					}
					num = num5 ^ (int)(num2 * 1499353913);
					continue;
				}
				case 16u:
				{
					Form control_ = Form2.smethod_2((Form)(object)this);
					num4 = Form2.smethod_12((Control)(object)control_) - 1;
					Form2.smethod_13((Control)(object)control_, num4);
					num = -23416341;
					continue;
				}
				case 15u:
					Form2.smethod_14(Form2.smethod_11(Form2.smethod_2((Form)(object)this)));
					num = ((int)num2 * -464349882) ^ 0x148DD7A4;
					continue;
				case 14u:
					num = -1775367250;
					continue;
				case 13u:
					num = (int)(num2 * 933233616) ^ -1611895186;
					continue;
				case 12u:
					flag2 = Form2.smethod_8(Form2.smethod_7((Control)(object)textBox1), "");
					num = ((int)num2 * -538367641) ^ 0x6A5FC405;
					continue;
				case 11u:
					num = -522031629;
					continue;
				case 9u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).StartGame();
					num = (int)((num2 * 487861330) ^ 0x7DFD66CE);
					continue;
				case 8u:
					Form2.smethod_15((Form)(object)this);
					num = ((int)num2 * -522627351) ^ -1924461622;
					continue;
				case 7u:
					this.flag = false;
					num = -1294120339;
					continue;
				case 6u:
					(Form2.smethod_2((Form)(object)this) as Form3).Button_Continue();
					num = (int)(num2 * 875121815) ^ -864618026;
					continue;
				case 5u:
					flag = this.flag;
					num = (int)((num2 * 1272583506) ^ 0x6001A3EF);
					continue;
				case 4u:
					num3 = Form2.smethod_9(rnd, 10);
					num = (int)((num2 * 1914057181) ^ 0x7570A51E);
					continue;
				case 3u:
					num = (int)(num2 * 2001404001) ^ -77229815;
					continue;
				case 2u:
					num = ((int)num2 * -1665160332) ^ 0x6DE31289;
					continue;
				case 0u:
					num = ((int)num2 * -721758413) ^ 0x7DE3010C;
					continue;
				default:
					return;
				case 10u:
					break;
				case 1u:
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
			int num = -1916439313;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xCAD7ED32u) % 9u)
				{
				case 8u:
					num = ((int)num2 * -1178092643) ^ -1225298737;
					continue;
				case 5u:
					num = ((int)num2 * -858199521) ^ -671892313;
					continue;
				case 4u:
					if (disposing)
					{
						num = (int)(num2 * 1446608501) ^ -1754658146;
						continue;
					}
					num3 = 0;
					goto IL_003a;
				case 3u:
					((Form)this).Dispose(disposing);
					num = -219043372;
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 844025975;
						num5 = 844025975;
					}
					else
					{
						num4 = 910530350;
						num5 = 910530350;
					}
					num = num4 ^ (int)(num2 * 1384065288);
					continue;
				}
				case 1u:
					Form2.smethod_16((IDisposable)components);
					num = (int)((num2 * 683526052) ^ 0x1AE8D79A);
					continue;
				case 0u:
					num3 = ((components != null) ? 1 : 0);
					goto IL_003a;
				default:
					return;
				case 7u:
					break;
				case 6u:
					return;
					IL_003a:
					flag = (byte)num3 != 0;
					num = -969488358;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Expected O, but got Unknown
		//IL_0641: Unknown result type (might be due to invalid IL or missing references)
		//IL_064b: Expected O, but got Unknown
		while (true)
		{
			int num = 454810871;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3A563335u) % 60u)
				{
				case 59u:
					Form2.smethod_25((Control)(object)textBox1, 1);
					num = ((int)num2 * -1545357410) ^ 0x3DF847D3;
					continue;
				case 58u:
					label2 = Form2.smethod_17();
					button1 = Form2.smethod_19();
					label3 = Form2.smethod_17();
					Form2.smethod_20((Control)(object)this);
					Form2.smethod_21((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -1929716207) ^ 0x6D404E18;
					continue;
				case 57u:
					Form2.smethod_1((Control)(object)this, "Жеребьёвка");
					num = (int)(num2 * 1199791348) ^ -1100941412;
					continue;
				case 56u:
					Form2.smethod_25((Control)(object)label1, 0);
					num = ((int)num2 * -1165298796) ^ 0x20BD4BEA;
					continue;
				case 55u:
					textBox1 = Form2.smethod_18();
					num = ((int)num2 * -1952392041) ^ 0x16259CD6;
					continue;
				case 54u:
					num = (int)(num2 * 844924892) ^ -138438740;
					continue;
				case 53u:
					Form2.smethod_39((Control)(object)this, "Form2");
					Form2.smethod_40((Form)(object)this, bool_0: false);
					num = ((int)num2 * -331396953) ^ -755642637;
					continue;
				case 52u:
					num = ((int)num2 * -849495301) ^ -112573005;
					continue;
				case 51u:
					Form2.smethod_23((Control)(object)label2, "label2");
					num = ((int)num2 * -899518018) ^ -1529166690;
					continue;
				case 50u:
					Form2.smethod_25((Control)(object)label2, 2);
					Form2.smethod_1((Control)(object)label2, "+N=?");
					num = ((int)num2 * -1824572810) ^ 0x1D8B3385;
					continue;
				case 49u:
					num = (int)(num2 * 311220263) ^ -1159037439;
					continue;
				case 48u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label2);
					num = ((int)num2 * -5478229) ^ 0xB55D2B;
					continue;
				case 47u:
					num = (int)(num2 * 423229137) ^ -444947417;
					continue;
				case 46u:
					Form2.smethod_31((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)((num2 * 349695879) ^ 0x2AB93A63);
					continue;
				case 45u:
					Form2.smethod_24((Control)(object)label2, new Size(188, 73));
					num = (int)(num2 * 273598735) ^ -200979216;
					continue;
				case 44u:
					num = ((int)num2 * -2049705017) ^ 0x506B403F;
					continue;
				case 43u:
					num = (int)((num2 * 1255350332) ^ 0x175E2B00);
					continue;
				case 42u:
					Form2.smethod_21((Control)(object)label2, bool_0: true);
					num = (int)((num2 * 850271568) ^ 0x2AF9AB64);
					continue;
				case 41u:
					Form2.smethod_27((Control)(object)label2, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 1015871027) ^ 0x6E24A5A6);
					continue;
				case 40u:
					Form2.smethod_25((Control)(object)button1, 3);
					num = (int)(num2 * 1449500528) ^ -179172125;
					continue;
				case 39u:
					num = ((int)num2 * -892010812) ^ 0xD45BE86;
					continue;
				case 38u:
					Form2.smethod_22((Control)(object)textBox1, new Point(24, 86));
					num = (int)(num2 * 1025586010) ^ -776653271;
					continue;
				case 37u:
					num = ((int)num2 * -1906909197) ^ 0x3C8A36DF;
					continue;
				case 36u:
					Form2.smethod_32((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 1445843707) ^ -193727126;
					continue;
				case 35u:
					Form2.smethod_24((Control)(object)label3, new Size(0, 13));
					num = ((int)num2 * -1892420125) ^ -1023372971;
					continue;
				case 34u:
					Form2.smethod_29((ButtonBase)(object)button1, bool_0: true);
					num = (int)(num2 * 1380856746) ^ -904484931;
					continue;
				case 33u:
					Form2.smethod_38((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1224122323) ^ -23002903;
					continue;
				case 31u:
					Form2.smethod_23((Control)(object)label1, "label1");
					Form2.smethod_24((Control)(object)label1, new Size(35, 13));
					num = ((int)num2 * -334342358) ^ 0x2296041C;
					continue;
				case 30u:
					num = ((int)num2 * -2099254998) ^ -773727373;
					continue;
				case 29u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)textBox1);
					num = (int)((num2 * 1182750895) ^ 0x36040D5A);
					continue;
				case 28u:
					Form2.smethod_22((Control)(object)button1, new Point(86, 193));
					Form2.smethod_23((Control)(object)button1, "button1");
					num = ((int)num2 * -1046121031) ^ 0x18B29E99;
					continue;
				case 27u:
					num = (int)((num2 * 214571020) ^ 0x1D22A639);
					continue;
				case 26u:
					Form2.smethod_30((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)(num2 * 275839158) ^ -231250736;
					continue;
				case 25u:
					Form2.smethod_1((Control)(object)button1, "OK");
					num = (int)((num2 * 1955738478) ^ 0x781E5EE7);
					continue;
				case 24u:
					Form2.smethod_28((Control)(object)textBox1, new KeyPressEventHandler(TextBox1_KeyPress));
					num = (int)((num2 * 1654767962) ^ 0x656412F);
					continue;
				case 23u:
					num = (int)(num2 * 944345538) ^ -1887645971;
					continue;
				case 22u:
					num = ((int)num2 * -581934129) ^ -385101625;
					continue;
				case 21u:
					Form2.smethod_25((Control)(object)label3, 4);
					num = (int)((num2 * 1740190721) ^ 0x6703AD89);
					continue;
				case 20u:
					num = (int)((num2 * 494287981) ^ 0x2ED0B5AF);
					continue;
				case 19u:
					Form2.smethod_23((Control)(object)label3, "label3");
					num = (int)(num2 * 948086756) ^ -773670794;
					continue;
				case 18u:
					label1 = Form2.smethod_17();
					num = (int)(num2 * 123581727) ^ -1540120428;
					continue;
				case 17u:
					num = (int)(num2 * 620980714) ^ -1574335259;
					continue;
				case 16u:
					Form2.smethod_23((Control)(object)textBox1, "textBox1");
					Form2.smethod_24((Control)(object)textBox1, new Size(42, 80));
					num = (int)((num2 * 1280283824) ^ 0x12130B7E);
					continue;
				case 15u:
					Form2.smethod_33((Form)(object)this, new Size(255, 224));
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label3);
					num = ((int)num2 * -450521275) ^ -1419075851;
					continue;
				case 14u:
					num = (int)((num2 * 1087197340) ^ 0x6FC4E347);
					continue;
				case 13u:
					Form2.smethod_21((Control)(object)label3, bool_0: true);
					Form2.smethod_22((Control)(object)label3, new Point(47, 177));
					num = ((int)num2 * -599059374) ^ -522612208;
					continue;
				case 12u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label1);
					Form2.smethod_36((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -1264493278) ^ 0x12457F98;
					continue;
				case 11u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -834136346) ^ -1959451046;
					continue;
				case 10u:
					Form2.smethod_24((Control)(object)button1, new Size(73, 23));
					num = ((int)num2 * -1511204829) ^ -400427853;
					continue;
				case 9u:
					Form2.smethod_41((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
					num = ((int)num2 * -441050093) ^ -1789220118;
					continue;
				case 8u:
					Form2.smethod_42((Control)(object)this, bool_0: false);
					num = ((int)num2 * -675911429) ^ -1367900481;
					continue;
				case 7u:
					num = ((int)num2 * -476480653) ^ -2143929262;
					continue;
				case 6u:
					Form2.smethod_22((Control)(object)label1, new Point(10, 10));
					num = (int)(num2 * 1715711528) ^ -2092630048;
					continue;
				case 5u:
					Form2.smethod_1((Control)(object)label1, "label1");
					Form2.smethod_27((Control)(object)textBox1, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1836221261) ^ 0x12AFF729;
					continue;
				case 4u:
					Form2.smethod_22((Control)(object)label2, new Point(53, 89));
					num = (int)((num2 * 1196986903) ^ 0x7C581D0A);
					continue;
				case 3u:
					num = ((int)num2 * -747346885) ^ -1144477265;
					continue;
				case 1u:
					Form2.smethod_37((Form)(object)this, bool_0: false);
					num = ((int)num2 * -538334682) ^ 0x7A0AC3F4;
					continue;
				case 0u:
					num = (int)(num2 * 546873169) ^ -1666298807;
					continue;
				case 32u:
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
