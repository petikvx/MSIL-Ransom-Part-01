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
			int num = 1911918831;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1E792FA0u) % 7u)
				{
				case 5u:
					num = ((int)num2 * -1057109446) ^ -1091568596;
					continue;
				case 4u:
					InitializeComponent();
					num = ((int)num2 * -1136698899) ^ -1504005355;
					continue;
				case 3u:
					Form2.smethod_1((Control)(object)label1, "Введите любое число от 0 до 9 включительно.\nВаш соперник уже загадал число (N) из этого\nже диапазона. Если сумма ваших чисел будет\nчетным числом, то первым ход делаете Вы,\nиначе - ваш соперник Компьютер!");
					num = (int)((num2 * 1159169831) ^ 0xC196B76);
					continue;
				case 2u:
					num = ((int)num2 * -376095325) ^ -48619030;
					continue;
				case 1u:
					num = ((int)num2 * -603105948) ^ 0x2BED6202;
					continue;
				default:
					return;
				case 0u:
					break;
				case 6u:
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
			int num = -1572751101;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8475DD2Du) % 3u)
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
				num = (int)((num2 * 460292398) ^ 0x5A75623);
			}
		}
	}

	private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -1216588848;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFE04177Du) % 10u)
				{
				case 9u:
				{
					int num5;
					int num6;
					if (!char.IsDigit(Form2.smethod_4(e)))
					{
						num5 = 1597424929;
						num6 = 1597424929;
					}
					else
					{
						num5 = 214284604;
						num6 = 214284604;
					}
					num = num5 ^ ((int)num2 * -1108886159);
					continue;
				}
				case 8u:
					Form2.smethod_1((Control)(object)textBox1, "");
					num = -2069843448;
					continue;
				case 7u:
					Form2.smethod_5(e, bool_0: true);
					num = ((int)num2 * -2024144270) ^ 0x545BD923;
					continue;
				case 6u:
					num = ((int)num2 * -1862742226) ^ -770421481;
					continue;
				case 4u:
					Button1_Click(this, Form2.smethod_6());
					num = (int)((num2 * 473322581) ^ 0x39F29CC2);
					continue;
				case 3u:
					num = ((int)num2 * -50174976) ^ -1491740929;
					continue;
				case 2u:
					flag = Form2.smethod_4(e) == '\r';
					num = -1572592234;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -945562300;
						num4 = -945562300;
					}
					else
					{
						num3 = -1041472117;
						num4 = -1041472117;
					}
					num = num3 ^ (int)(num2 * 723847655);
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
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		int num9 = default(int);
		int num10 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 156891411;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4F8682CFu) % 30u)
				{
				case 29u:
					num = 56896162;
					continue;
				case 28u:
					num = 56896162;
					continue;
				case 27u:
					num = (int)(num2 * 940290174) ^ -1049127215;
					continue;
				case 26u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = true;
					num = ((int)num2 * -358182030) ^ 0x694C021C;
					continue;
				case 25u:
				{
					int num7;
					int num8;
					if (flag2)
					{
						num7 = 51958026;
						num8 = 51958026;
					}
					else
					{
						num7 = 1119083518;
						num8 = 1119083518;
					}
					num = num7 ^ (int)(num2 * 472161835);
					continue;
				}
				case 24u:
					num = 903809367;
					continue;
				case 23u:
					num = (int)((num2 * 2085694534) ^ 0x33D60A73);
					continue;
				case 22u:
					Form2.smethod_1((Control)(object)label3, "Первым ход делает Компьютер.");
					num = (int)((num2 * 1703381030) ^ 0x5F10770C);
					continue;
				case 21u:
				{
					int num11;
					int num12;
					if (!flag3)
					{
						num11 = 113918625;
						num12 = 113918625;
					}
					else
					{
						num11 = 215827031;
						num12 = 215827031;
					}
					num = num11 ^ ((int)num2 * -1544353508);
					continue;
				}
				case 20u:
					num = (int)((num2 * 776770926) ^ 0x4C58E7A8);
					continue;
				case 19u:
					num = 1837057748;
					continue;
				case 18u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).StartGame();
					num = (int)((num2 * 1334772538) ^ 0x73B96C86);
					continue;
				case 17u:
					flag2 = (num9 + num10) % 2 == 0;
					num = (int)(num2 * 464309652) ^ -800276026;
					continue;
				case 16u:
					num = (int)((num2 * 979789091) ^ 0x3B5A2C0);
					continue;
				case 15u:
					num = (int)((num2 * 325504932) ^ 0x1BE0342F);
					continue;
				case 14u:
					num = (int)(num2 * 443975174) ^ -1091329280;
					continue;
				case 13u:
					num9 = int.Parse(Form2.smethod_7((Control)(object)textBox1));
					num10 = Form2.smethod_9(rnd, 10);
					Form2.smethod_1((Control)(object)label2, Form2.smethod_10("+", num10.ToString(), "=", (num9 + num10).ToString()));
					num = (int)(num2 * 809554118) ^ -1396361205;
					continue;
				case 12u:
					num = (int)(num2 * 2121445599) ^ -903528186;
					continue;
				case 10u:
					flag3 = this.flag;
					num = ((int)num2 * -2079053281) ^ -2027649496;
					continue;
				case 9u:
				{
					Form control_ = Form2.smethod_2((Form)(object)this);
					int num5 = Form2.smethod_12((Control)(object)control_) - 1;
					Form2.smethod_13((Control)(object)control_, num5);
					int num6;
					if (num5 <= 1)
					{
						num = 2052710620;
						num6 = 2052710620;
					}
					else
					{
						num = 838239024;
						num6 = 838239024;
					}
					continue;
				}
				case 8u:
					Form2.smethod_1((Control)(object)label3, "Поздравляем! Ваш ход первый.");
					num = (int)(num2 * 1693850741) ^ -1499463131;
					continue;
				case 7u:
					Form2.smethod_15((Form)(object)this);
					num = ((int)num2 * -2063082899) ^ 0x31CE2223;
					continue;
				case 6u:
					flag = Form2.smethod_8(Form2.smethod_7((Control)(object)textBox1), "");
					num = (int)((num2 * 1009033330) ^ 0x42FA4B68);
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -602068214;
						num4 = -602068214;
					}
					else
					{
						num3 = -2083516431;
						num4 = -2083516431;
					}
					num = num3 ^ (int)(num2 * 105366242);
					continue;
				}
				case 4u:
					num = (int)((num2 * 1582785123) ^ 0x21B2D0F5);
					continue;
				case 3u:
					(Form2.smethod_2((Form)(object)this) as Form3).Button_Continue();
					Form2.smethod_14(Form2.smethod_11(Form2.smethod_2((Form)(object)this)));
					num = (int)(num2 * 1073789677) ^ -2039513457;
					continue;
				case 1u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = false;
					num = ((int)num2 * -95439093) ^ 0x372C9262;
					continue;
				case 0u:
					this.flag = false;
					num = 51877521;
					continue;
				default:
					return;
				case 2u:
					break;
				case 11u:
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
			goto IL_0082;
		}
		int num = 0;
		goto IL_00c6;
		IL_00bd:
		num = ((components != null) ? 1 : 0);
		goto IL_00c6;
		IL_0082:
		int num2 = 1966706656;
		goto IL_0087;
		IL_0087:
		bool flag = default(bool);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x66E0DC00u) % 9u)
			{
			case 7u:
			{
				int num4;
				int num5;
				if (!flag)
				{
					num4 = 1015384746;
					num5 = 1015384746;
				}
				else
				{
					num4 = 392918991;
					num5 = 392918991;
				}
				num2 = num4 ^ ((int)num3 * -1782710953);
				continue;
			}
			case 5u:
				num2 = (int)((num3 * 1700520695) ^ 0x71C2F86A);
				continue;
			case 4u:
				((Form)this).Dispose(disposing);
				num2 = 1463756077;
				continue;
			case 3u:
				num2 = (int)(num3 * 365927573) ^ -1779749080;
				continue;
			case 2u:
				num2 = ((int)num3 * -251569227) ^ -1086402149;
				continue;
			case 1u:
				Form2.smethod_16((IDisposable)components);
				num2 = ((int)num3 * -354641928) ^ 0x247CEBBB;
				continue;
			case 0u:
				break;
			default:
				return;
			case 6u:
				goto IL_00bd;
			case 8u:
				return;
			}
			break;
		}
		goto IL_0082;
		IL_00c6:
		flag = (byte)num != 0;
		num2 = 1287624474;
		goto IL_0087;
	}

	private void InitializeComponent()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cc: Expected O, but got Unknown
		while (true)
		{
			int num = 1432985988;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x76ED4D68u) % 60u)
				{
				case 59u:
					Form2.smethod_41((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
					num = (int)((num2 * 1116314074) ^ 0x5C0DFE6C);
					continue;
				case 58u:
					num = (int)(num2 * 1680983445) ^ -1627380311;
					continue;
				case 56u:
					Form2.smethod_23((Control)(object)button1, "button1");
					num = ((int)num2 * -1514961995) ^ 0x85F4520;
					continue;
				case 55u:
					num = ((int)num2 * -1677625214) ^ 0x4229E745;
					continue;
				case 54u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)textBox1);
					num = (int)((num2 * 526166084) ^ 0x20BD8DA8);
					continue;
				case 52u:
					num = (int)(num2 * 922161191) ^ -545129894;
					continue;
				case 51u:
					Form2.smethod_37((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1691411931) ^ -991095239;
					continue;
				case 50u:
					textBox1 = Form2.smethod_18();
					label2 = Form2.smethod_17();
					num = (int)(num2 * 1121001416) ^ -999731339;
					continue;
				case 49u:
					num = ((int)num2 * -1432224937) ^ -638011616;
					continue;
				case 48u:
					Form2.smethod_24((Control)(object)button1, new Size(73, 23));
					num = (int)((num2 * 1190277539) ^ 0x7A5A776);
					continue;
				case 47u:
					Form2.smethod_23((Control)(object)label2, "label2");
					num = ((int)num2 * -795948169) ^ -127416854;
					continue;
				case 46u:
					Form2.smethod_23((Control)(object)label3, "label3");
					num = (int)(num2 * 1886142710) ^ -114785014;
					continue;
				case 45u:
					Form2.smethod_22((Control)(object)label3, new Point(47, 177));
					num = (int)((num2 * 110395991) ^ 0x1CD459E9);
					continue;
				case 44u:
					num = ((int)num2 * -972128913) ^ 0x1A35E30F;
					continue;
				case 43u:
					Form2.smethod_38((Form)(object)this, bool_0: false);
					Form2.smethod_39((Control)(object)this, "Form2");
					num = ((int)num2 * -237331594) ^ -267006607;
					continue;
				case 42u:
					Form2.smethod_22((Control)(object)button1, new Point(86, 193));
					num = ((int)num2 * -129441929) ^ -1919851938;
					continue;
				case 41u:
					Form2.smethod_25((Control)(object)label2, 2);
					num = (int)((num2 * 212975001) ^ 0x746053D);
					continue;
				case 40u:
					num = ((int)num2 * -606592950) ^ 0x4DBD782F;
					continue;
				case 39u:
					Form2.smethod_22((Control)(object)label2, new Point(53, 89));
					num = (int)(num2 * 665382711) ^ -1919098842;
					continue;
				case 38u:
					Form2.smethod_31((ContainerControl)(object)this, new SizeF(6f, 13f));
					Form2.smethod_32((ContainerControl)(object)this, (AutoScaleMode)1);
					Form2.smethod_33((Form)(object)this, new Size(255, 224));
					num = ((int)num2 * -301147956) ^ 0x6CA2BB69;
					continue;
				case 37u:
					num = (int)((num2 * 338047185) ^ 0x2F8A3C1A);
					continue;
				case 36u:
					num = (int)((num2 * 1391119779) ^ 0x5609B544);
					continue;
				case 35u:
					Form2.smethod_25((Control)(object)button1, 3);
					Form2.smethod_1((Control)(object)button1, "OK");
					num = (int)((num2 * 2096855386) ^ 0x120B7288);
					continue;
				case 34u:
					Form2.smethod_1((Control)(object)label1, "label1");
					num = (int)(num2 * 1011986196) ^ -1352206411;
					continue;
				case 33u:
					num = (int)((num2 * 2036736995) ^ 0x613088EF);
					continue;
				case 32u:
					Form2.smethod_22((Control)(object)label1, new Point(10, 10));
					num = (int)((num2 * 1264783980) ^ 0x3E42D8F2);
					continue;
				case 31u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -53927278) ^ 0x14662406;
					continue;
				case 30u:
					Form2.smethod_29((ButtonBase)(object)button1, bool_0: true);
					Form2.smethod_30((Control)(object)button1, (EventHandler)Button1_Click);
					Form2.smethod_21((Control)(object)label3, bool_0: true);
					num = (int)(num2 * 75492203) ^ -207988501;
					continue;
				case 29u:
					button1 = Form2.smethod_19();
					label3 = Form2.smethod_17();
					num = (int)(num2 * 808868353) ^ -1746001292;
					continue;
				case 28u:
					Form2.smethod_43((Control)(object)this);
					num = ((int)num2 * -1680106089) ^ 0x4DBF35D9;
					continue;
				case 27u:
					Form2.smethod_40((Form)(object)this, bool_0: false);
					num = ((int)num2 * -959226824) ^ 0x64DCEA2C;
					continue;
				case 26u:
					Form2.smethod_21((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -425834418) ^ 0x54FAB71F;
					continue;
				case 25u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -67769429) ^ -1338116131;
					continue;
				case 24u:
					label1 = Form2.smethod_17();
					num = (int)((num2 * 1746607765) ^ 0x19B0DB2);
					continue;
				case 23u:
					Form2.smethod_24((Control)(object)label2, new Size(188, 73));
					num = (int)((num2 * 1182568803) ^ 0x1800A4FC);
					continue;
				case 22u:
					num = ((int)num2 * -431002595) ^ -998413077;
					continue;
				case 21u:
					Form2.smethod_23((Control)(object)textBox1, "textBox1");
					Form2.smethod_24((Control)(object)textBox1, new Size(42, 80));
					Form2.smethod_25((Control)(object)textBox1, 1);
					Form2.smethod_28((Control)(object)textBox1, new KeyPressEventHandler(TextBox1_KeyPress));
					Form2.smethod_21((Control)(object)label2, bool_0: true);
					num = ((int)num2 * -1948796844) ^ 0x5F648AC8;
					continue;
				case 20u:
					Form2.smethod_27((Control)(object)label2, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 448599010) ^ 0x13FA9E55);
					continue;
				case 19u:
					num = (int)((num2 * 1082701563) ^ 0x52C8AF6D);
					continue;
				case 18u:
					num = ((int)num2 * -446581767) ^ -213326625;
					continue;
				case 17u:
					num = ((int)num2 * -779579293) ^ 0x3E681FB1;
					continue;
				case 16u:
					Form2.smethod_27((Control)(object)textBox1, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form2.smethod_22((Control)(object)textBox1, new Point(24, 86));
					num = (int)(num2 * 786042256) ^ -377389338;
					continue;
				case 15u:
					num = ((int)num2 * -1502404681) ^ -423124582;
					continue;
				case 14u:
					num = (int)((num2 * 514093165) ^ 0x356575C5);
					continue;
				case 13u:
					Form2.smethod_23((Control)(object)label1, "label1");
					num = (int)((num2 * 813264871) ^ 0x70936333);
					continue;
				case 12u:
					Form2.smethod_36((Form)(object)this, (FormBorderStyle)1);
					num = (int)((num2 * 2087783719) ^ 0x66CD6C25);
					continue;
				case 11u:
					Form2.smethod_1((Control)(object)label2, "+N=?");
					num = (int)((num2 * 994488963) ^ 0x5987A853);
					continue;
				case 10u:
					Form2.smethod_25((Control)(object)label1, 0);
					num = (int)(num2 * 941921079) ^ -613840802;
					continue;
				case 9u:
					num = (int)(num2 * 597851038) ^ -1126054927;
					continue;
				case 8u:
					Form2.smethod_24((Control)(object)label1, new Size(35, 13));
					num = ((int)num2 * -1464696354) ^ -1130005110;
					continue;
				case 7u:
					Form2.smethod_1((Control)(object)this, "Жеребьёвка");
					num = (int)((num2 * 677671835) ^ 0x5284D332);
					continue;
				case 6u:
					Form2.smethod_42((Control)(object)this, bool_0: false);
					num = ((int)num2 * -842181039) ^ 0x3DA5CC02;
					continue;
				case 5u:
					Form2.smethod_25((Control)(object)label3, 4);
					num = (int)(num2 * 398189106) ^ -294155720;
					continue;
				case 4u:
					num = ((int)num2 * -895299527) ^ 0x2AC6BED3;
					continue;
				case 3u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label3);
					num = (int)((num2 * 206746056) ^ 0x22095F1);
					continue;
				case 2u:
					Form2.smethod_24((Control)(object)label3, new Size(0, 13));
					num = (int)((num2 * 605995783) ^ 0x516ED1FB);
					continue;
				case 1u:
					Form2.smethod_20((Control)(object)this);
					num = (int)((num2 * 553837107) ^ 0x6B1BBB12);
					continue;
				case 0u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label2);
					num = (int)(num2 * 1739509513) ^ -1766170720;
					continue;
				default:
					return;
				case 53u:
					break;
				case 57u:
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
