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
			int num = 175468622;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x38A644Fu) % 4u)
				{
				case 3u:
					InitializeComponent();
					num = ((int)num2 * -1481743611) ^ 0x2F168394;
					continue;
				case 1u:
					num = ((int)num2 * -548915974) ^ 0x1692FD6A;
					continue;
				case 2u:
					break;
				default:
					Form2.smethod_1((Control)(object)label1, "Введите любое число от 0 до 9 включительно.\nВаш соперник уже загадал число (N) из этого\nже диапазона. Если сумма ваших чисел будет\nчетным числом, то первым ход делаете Вы,\nиначе - ваш соперник Компьютер!");
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
			int num = -1838051010;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDD1DCCB0u) % 3u)
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
				num = (int)((num2 * 1326583152) ^ 0x2A080272);
			}
		}
	}

	private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = 1701488912;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4BDCA92Du) % 11u)
				{
				case 10u:
					num = ((int)num2 * -276287433) ^ 0x6EDA2FDD;
					continue;
				case 8u:
				{
					int num5;
					if (Form2.smethod_4(e) != '\r')
					{
						num = 1428902488;
						num5 = 1428902488;
					}
					else
					{
						num = 634680415;
						num5 = 634680415;
					}
					continue;
				}
				case 7u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 746527434;
						num4 = 746527434;
					}
					else
					{
						num3 = 1445510778;
						num4 = 1445510778;
					}
					num = num3 ^ (int)(num2 * 1040865695);
					continue;
				}
				case 6u:
					num = ((int)num2 * -259208299) ^ -81817132;
					continue;
				case 5u:
					Form2.smethod_5(e, bool_0: true);
					num = ((int)num2 * -1296450622) ^ -222661899;
					continue;
				case 4u:
					flag = !char.IsDigit(Form2.smethod_4(e));
					num = (int)((num2 * 1068431770) ^ 0x61D2449C);
					continue;
				case 3u:
					Form2.smethod_1((Control)(object)textBox1, "");
					num = 1594966775;
					continue;
				case 2u:
					Button1_Click(this, Form2.smethod_6());
					num = (int)(num2 * 474495521) ^ -813056836;
					continue;
				case 1u:
					num = (int)((num2 * 689035141) ^ 0x196ADA86);
					continue;
				default:
					return;
				case 0u:
					break;
				case 9u:
					return;
				}
				break;
			}
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		bool flag4 = default(bool);
		bool flag2 = default(bool);
		int num5 = default(int);
		int num4 = default(int);
		bool flag3 = default(bool);
		bool flag = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = -469052851;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xADACD1D3u) % 32u)
				{
				case 30u:
					flag4 = Form2.smethod_8(Form2.smethod_7((Control)(object)textBox1), "");
					num = (int)(num2 * 179377808) ^ -1541954982;
					continue;
				case 29u:
					Form2.smethod_15((Form)(object)this);
					num = (int)((num2 * 1394584552) ^ 0x50D08FEF);
					continue;
				case 28u:
					flag2 = num5 > 1;
					num = ((int)num2 * -588853406) ^ -527834292;
					continue;
				case 27u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = false;
					num = (int)((num2 * 1327535711) ^ 0x70C774E3);
					continue;
				case 25u:
					Form2.smethod_14(Form2.smethod_11(Form2.smethod_2((Form)(object)this)));
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).StartGame();
					num = (int)(num2 * 571309245) ^ -806283429;
					continue;
				case 24u:
					Form2.smethod_1((Control)(object)label3, "Поздравляем! Ваш ход первый.");
					num = (int)(num2 * 1228580869) ^ -422253754;
					continue;
				case 23u:
					num = ((int)num2 * -584949759) ^ -1504290537;
					continue;
				case 22u:
					Form2.smethod_1((Control)(object)label3, "Первым ход делает Компьютер.");
					num = (int)(num2 * 207913920) ^ -1597550392;
					continue;
				case 21u:
					this.flag = false;
					num = -2117480575;
					continue;
				case 20u:
					num = ((int)num2 * -886928677) ^ -465955126;
					continue;
				case 19u:
					num4 = int.Parse(Form2.smethod_7((Control)(object)textBox1));
					num = (int)(num2 * 705766995) ^ -400163365;
					continue;
				case 18u:
					num = -299942548;
					continue;
				case 17u:
					num = (int)((num2 * 75966571) ^ 0x90327E0);
					continue;
				case 16u:
					num = -1146521613;
					continue;
				case 15u:
				{
					int num12;
					int num13;
					if (flag3)
					{
						num12 = 1222333652;
						num13 = 1222333652;
					}
					else
					{
						num12 = 918292787;
						num13 = 918292787;
					}
					num = num12 ^ (int)(num2 * 155292144);
					continue;
				}
				case 14u:
				{
					Form control_2 = Form2.smethod_2((Form)(object)this);
					num5 = Form2.smethod_12((Control)(object)control_2) - 1;
					Form2.smethod_13((Control)(object)control_2, num5);
					num = -550543505;
					continue;
				}
				case 13u:
					num = ((int)num2 * -432621673) ^ -730213190;
					continue;
				case 12u:
					num = -286703259;
					continue;
				case 11u:
					num = (int)(num2 * 1407812284) ^ -1538136802;
					continue;
				case 10u:
					(Form2.smethod_2((Form)(object)this) as Form3).Button_Continue();
					num = (int)((num2 * 1071178121) ^ 0x634A2B82);
					continue;
				case 9u:
				{
					int num10;
					int num11;
					if (flag4)
					{
						num10 = -1633982317;
						num11 = -1633982317;
					}
					else
					{
						num10 = -1946651587;
						num11 = -1946651587;
					}
					num = num10 ^ (int)(num2 * 1175500201);
					continue;
				}
				case 8u:
					flag3 = this.flag;
					num = (int)(num2 * 1164405814) ^ -1981170836;
					continue;
				case 7u:
				{
					int num8;
					int num9;
					if (flag2)
					{
						num8 = -754929926;
						num9 = -754929926;
					}
					else
					{
						num8 = -2052750252;
						num9 = -2052750252;
					}
					num = num8 ^ ((int)num2 * -2000328469);
					continue;
				}
				case 6u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = 665098011;
						num7 = 665098011;
					}
					else
					{
						num6 = 632306479;
						num7 = 632306479;
					}
					num = num6 ^ ((int)num2 * -890379128);
					continue;
				}
				case 5u:
					num = (int)((num2 * 1389092161) ^ 0x5B62B5E4);
					continue;
				case 4u:
					num = -1321631459;
					continue;
				case 3u:
				{
					Label control_ = label2;
					string string_ = num3.ToString();
					num5 = num4 + num3;
					Form2.smethod_1((Control)(object)control_, Form2.smethod_10("+", string_, "=", num5.ToString()));
					flag = (num4 + num3) % 2 == 0;
					num = ((int)num2 * -1126488075) ^ -1176024694;
					continue;
				}
				case 2u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = true;
					num = ((int)num2 * -837355485) ^ 0x55574D20;
					continue;
				case 1u:
					num3 = Form2.smethod_9(rnd, 10);
					num = (int)(num2 * 2047115711) ^ -2103313937;
					continue;
				case 0u:
					num = (int)((num2 * 131478191) ^ 0x56374EFD);
					continue;
				default:
					return;
				case 26u:
					break;
				case 31u:
					return;
				}
				break;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		while (true)
		{
			int num = 1328791854;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x17004438u) % 7u)
				{
				case 5u:
					num = (int)(num2 * 1543758487) ^ -653436724;
					continue;
				case 4u:
					((Form)this).Dispose(disposing);
					num = 1809950850;
					continue;
				case 2u:
					if (disposing)
					{
						num = (int)(num2 * 823338838) ^ -1448613401;
						continue;
					}
					goto IL_0044;
				case 1u:
					if (components != null)
					{
						num = 1463969309;
						num3 = 1463969309;
						continue;
					}
					goto IL_0044;
				case 0u:
					Form2.smethod_16((IDisposable)components);
					num = (int)(num2 * 1143595439) ^ -1909569830;
					continue;
				default:
					return;
				case 6u:
					break;
				case 3u:
					return;
					IL_0044:
					num = 1084687987;
					num3 = 1084687987;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected O, but got Unknown
		while (true)
		{
			int num = 1030632717;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x35FBDCA7u) % 68u)
				{
				case 67u:
					Form2.smethod_39((Control)(object)this, "Form2");
					num = (int)((num2 * 175656964) ^ 0x99E70C9);
					continue;
				case 66u:
					Form2.smethod_1((Control)(object)label1, "label1");
					Form2.smethod_27((Control)(object)textBox1, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 279665315) ^ -140117414;
					continue;
				case 65u:
					Form2.smethod_22((Control)(object)label3, new Point(47, 177));
					num = ((int)num2 * -422575706) ^ -612323911;
					continue;
				case 64u:
					Form2.smethod_25((Control)(object)label2, 2);
					num = (int)(num2 * 1063437857) ^ -653067100;
					continue;
				case 63u:
					Form2.smethod_23((Control)(object)label2, "label2");
					num = ((int)num2 * -179511735) ^ 0xC356D55;
					continue;
				case 62u:
					Form2.smethod_41((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
					num = ((int)num2 * -328874059) ^ 0x31301725;
					continue;
				case 60u:
					textBox1 = Form2.smethod_18();
					label2 = Form2.smethod_17();
					num = ((int)num2 * -883335725) ^ 0x367E8CAF;
					continue;
				case 59u:
					Form2.smethod_24((Control)(object)textBox1, new Size(42, 80));
					num = (int)(num2 * 462026647) ^ -1904043726;
					continue;
				case 58u:
					label3 = Form2.smethod_17();
					Form2.smethod_20((Control)(object)this);
					num = ((int)num2 * -1540021470) ^ 0x61B95D00;
					continue;
				case 57u:
					num = (int)((num2 * 632643566) ^ 0x4EF074FC);
					continue;
				case 56u:
					button1 = Form2.smethod_19();
					num = ((int)num2 * -80821077) ^ -1743980215;
					continue;
				case 55u:
					Form2.smethod_1((Control)(object)label2, "+N=?");
					num = ((int)num2 * -249462482) ^ 0x77CE5FB2;
					continue;
				case 54u:
					Form2.smethod_42((Control)(object)this, bool_0: false);
					Form2.smethod_43((Control)(object)this);
					num = ((int)num2 * -2018641738) ^ 0x5620609E;
					continue;
				case 53u:
					Form2.smethod_23((Control)(object)textBox1, "textBox1");
					num = (int)(num2 * 1573843119) ^ -992178797;
					continue;
				case 52u:
					num = ((int)num2 * -1010284192) ^ -122086866;
					continue;
				case 51u:
					Form2.smethod_21((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -470347301) ^ 0x4D7FD962;
					continue;
				case 50u:
					label1 = Form2.smethod_17();
					num = (int)(num2 * 698960117) ^ -1256724219;
					continue;
				case 49u:
					Form2.smethod_25((Control)(object)label1, 0);
					num = (int)(num2 * 2063936642) ^ -1616893932;
					continue;
				case 48u:
					num = ((int)num2 * -956101027) ^ 0x13F43B79;
					continue;
				case 47u:
					num = (int)((num2 * 266201106) ^ 0x218C05F0);
					continue;
				case 46u:
					num = (int)((num2 * 1628665360) ^ 0x79FE6326);
					continue;
				case 45u:
					num = ((int)num2 * -336073641) ^ 0x5B3762F2;
					continue;
				case 44u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -601332778) ^ 0x7233B108;
					continue;
				case 43u:
					Form2.smethod_28((Control)(object)textBox1, new KeyPressEventHandler(TextBox1_KeyPress));
					num = ((int)num2 * -1628492244) ^ -661551839;
					continue;
				case 42u:
					num = ((int)num2 * -14463216) ^ 0x1626811B;
					continue;
				case 41u:
					num = (int)(num2 * 965189323) ^ -482263410;
					continue;
				case 40u:
					Form2.smethod_25((Control)(object)textBox1, 1);
					num = (int)((num2 * 252449050) ^ 0x479384E4);
					continue;
				case 39u:
					Form2.smethod_30((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)((num2 * 1608871564) ^ 0x420F228E);
					continue;
				case 38u:
					num = (int)(num2 * 993039019) ^ -1775828514;
					continue;
				case 37u:
					num = (int)(num2 * 1627869054) ^ -1413602378;
					continue;
				case 36u:
					num = ((int)num2 * -671712841) ^ 0x10CAA70D;
					continue;
				case 35u:
					Form2.smethod_23((Control)(object)button1, "button1");
					num = (int)((num2 * 838885688) ^ 0x32FDA7ED);
					continue;
				case 34u:
					num = (int)((num2 * 1495553187) ^ 0x59C760CF);
					continue;
				case 33u:
					Form2.smethod_24((Control)(object)label3, new Size(0, 13));
					num = ((int)num2 * -1365239571) ^ 0x56D78AB7;
					continue;
				case 32u:
					Form2.smethod_23((Control)(object)label3, "label3");
					num = ((int)num2 * -1120880639) ^ -488884426;
					continue;
				case 31u:
					num = ((int)num2 * -1128042466) ^ -1592020051;
					continue;
				case 30u:
					Form2.smethod_1((Control)(object)button1, "OK");
					num = ((int)num2 * -411922582) ^ -1094752945;
					continue;
				case 29u:
					Form2.smethod_21((Control)(object)label2, bool_0: true);
					num = (int)((num2 * 1034504728) ^ 0x4D693DE3);
					continue;
				case 28u:
					num = ((int)num2 * -2083537860) ^ -1787112633;
					continue;
				case 27u:
					Form2.smethod_22((Control)(object)textBox1, new Point(24, 86));
					num = (int)(num2 * 1464108855) ^ -1980208433;
					continue;
				case 26u:
					Form2.smethod_24((Control)(object)button1, new Size(73, 23));
					Form2.smethod_25((Control)(object)button1, 3);
					num = (int)(num2 * 44163705) ^ -1422667933;
					continue;
				case 25u:
					num = (int)(num2 * 2060520853) ^ -1423896850;
					continue;
				case 24u:
					Form2.smethod_37((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1038107933) ^ -1187230336;
					continue;
				case 23u:
					Form2.smethod_38((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1704884745) ^ -289706929;
					continue;
				case 22u:
					Form2.smethod_1((Control)(object)this, "Жеребьёвка");
					num = (int)((num2 * 477052006) ^ 0x694521CB);
					continue;
				case 21u:
					num = (int)(num2 * 125839541) ^ -18943373;
					continue;
				case 20u:
					Form2.smethod_27((Control)(object)label2, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 1744189010) ^ -186787048;
					continue;
				case 19u:
					num = ((int)num2 * -1131997636) ^ -715147315;
					continue;
				case 18u:
					num = (int)((num2 * 662037916) ^ 0x25CDF4C7);
					continue;
				case 17u:
					Form2.smethod_22((Control)(object)label1, new Point(10, 10));
					Form2.smethod_23((Control)(object)label1, "label1");
					num = ((int)num2 * -1063982221) ^ 0x7006416;
					continue;
				case 16u:
					Form2.smethod_24((Control)(object)label1, new Size(35, 13));
					num = ((int)num2 * -996643913) ^ -332142072;
					continue;
				case 14u:
					Form2.smethod_36((Form)(object)this, (FormBorderStyle)1);
					num = (int)(num2 * 565590416) ^ -456154863;
					continue;
				case 13u:
					Form2.smethod_32((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -74954169) ^ -265493944;
					continue;
				case 12u:
					Form2.smethod_40((Form)(object)this, bool_0: false);
					num = ((int)num2 * -967332864) ^ 0x61039B99;
					continue;
				case 11u:
					num = (int)(num2 * 216647929) ^ -1766390239;
					continue;
				case 10u:
					Form2.smethod_24((Control)(object)label2, new Size(188, 73));
					num = (int)((num2 * 1431558474) ^ 0x1570BD8A);
					continue;
				case 9u:
					num = ((int)num2 * -366823778) ^ -1106030905;
					continue;
				case 8u:
					Form2.smethod_33((Form)(object)this, new Size(255, 224));
					num = (int)(num2 * 324630717) ^ -558956614;
					continue;
				case 7u:
					num = ((int)num2 * -973850831) ^ 0x39C54CA3;
					continue;
				case 6u:
					Form2.smethod_25((Control)(object)label3, 4);
					Form2.smethod_31((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -483321513) ^ 0x6B97FFB4;
					continue;
				case 5u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label3);
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)button1);
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)textBox1);
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label2);
					num = ((int)num2 * -196171630) ^ 0x16876005;
					continue;
				case 4u:
					Form2.smethod_22((Control)(object)button1, new Point(86, 193));
					num = (int)(num2 * 2089507723) ^ -1722896364;
					continue;
				case 3u:
					Form2.smethod_22((Control)(object)label2, new Point(53, 89));
					num = (int)(num2 * 1409787749) ^ -2067797979;
					continue;
				case 2u:
					num = (int)(num2 * 578074531) ^ -1889836431;
					continue;
				case 1u:
					Form2.smethod_21((Control)(object)label3, bool_0: true);
					num = ((int)num2 * -1016362796) ^ -63977808;
					continue;
				case 0u:
					Form2.smethod_29((ButtonBase)(object)button1, bool_0: true);
					num = (int)(num2 * 881051459) ^ -1673123267;
					continue;
				default:
					return;
				case 15u:
					break;
				case 61u:
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
