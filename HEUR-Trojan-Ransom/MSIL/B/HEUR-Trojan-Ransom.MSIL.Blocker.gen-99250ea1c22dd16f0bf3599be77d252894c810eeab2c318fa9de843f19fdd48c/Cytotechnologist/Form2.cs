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
			int num = 1722645669;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2F8CF544u) % 7u)
				{
				case 5u:
					Form2.smethod_1((Control)(object)label1, "Введите любое число от 0 до 9 включительно.\nВаш соперник уже загадал число (N) из этого\nже диапазона. Если сумма ваших чисел будет\nчетным числом, то первым ход делаете Вы,\nиначе - ваш соперник Компьютер!");
					num = (int)((num2 * 873912267) ^ 0x6FF889FD);
					continue;
				case 3u:
					InitializeComponent();
					num = ((int)num2 * -1474016220) ^ 0x3106A7AD;
					continue;
				case 2u:
					num = ((int)num2 * -764398357) ^ -2021494240;
					continue;
				case 1u:
					num = (int)(num2 * 896762081) ^ -1894531471;
					continue;
				case 0u:
					num = (int)((num2 * 626316033) ^ 0x12BB4686);
					continue;
				default:
					return;
				case 4u:
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
			int num = 224841958;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x66725D99u) % 3u)
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
				num = ((int)num2 * -1687292593) ^ -1884791994;
			}
		}
	}

	private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -746993465;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8E607396u) % 12u)
				{
				case 10u:
					flag = Form2.smethod_4(e) == '\r';
					num = -1829704281;
					continue;
				case 9u:
					num = (int)((num2 * 1018800989) ^ 0x3138619F);
					continue;
				case 8u:
					Form2.smethod_1((Control)(object)textBox1, "");
					num = -324694500;
					continue;
				case 7u:
					Button1_Click(this, Form2.smethod_6());
					num = (int)((num2 * 994675267) ^ 0x733AEAAA);
					continue;
				case 6u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = 304841900;
						num6 = 304841900;
					}
					else
					{
						num5 = 130884728;
						num6 = 130884728;
					}
					num = num5 ^ ((int)num2 * -589910565);
					continue;
				}
				case 5u:
					flag2 = !char.IsDigit(Form2.smethod_4(e));
					num = ((int)num2 * -2094068058) ^ 0x262FC726;
					continue;
				case 3u:
					num = (int)((num2 * 280798683) ^ 0x50031619);
					continue;
				case 2u:
					num = (int)((num2 * 1171710070) ^ 0x487D3A50);
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1606314760;
						num4 = -1606314760;
					}
					else
					{
						num3 = -1644973389;
						num4 = -1644973389;
					}
					num = num3 ^ (int)(num2 * 1519080078);
					continue;
				}
				case 0u:
					Form2.smethod_5(e, bool_0: true);
					num = ((int)num2 * -890110713) ^ 0x6BA628A1;
					continue;
				default:
					return;
				case 11u:
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
		int num5 = default(int);
		int num6 = default(int);
		bool flag = default(bool);
		int num7 = default(int);
		while (true)
		{
			int num = -816627234;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCCE99F35u) % 30u)
				{
				case 29u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = false;
					num = (int)(num2 * 1873548174) ^ -730527025;
					continue;
				case 28u:
					num = ((int)num2 * -1472184000) ^ -1698164447;
					continue;
				case 27u:
					num = -944112065;
					continue;
				case 26u:
					num5 = int.Parse(Form2.smethod_7((Control)(object)textBox1));
					num6 = Form2.smethod_9(rnd, 10);
					num = ((int)num2 * -577307664) ^ 0xA92B381;
					continue;
				case 25u:
				{
					int num10;
					int num11;
					if (this.flag)
					{
						num10 = -40412475;
						num11 = -40412475;
					}
					else
					{
						num10 = -434327868;
						num11 = -434327868;
					}
					num = num10 ^ ((int)num2 * -1879300346);
					continue;
				}
				case 24u:
					num = ((int)num2 * -1402295461) ^ 0x69BB4252;
					continue;
				case 23u:
					num = (int)(num2 * 559414061) ^ -505991688;
					continue;
				case 22u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).StartGame();
					num = (int)(num2 * 1897015095) ^ -722859862;
					continue;
				case 21u:
					flag = (num5 + num6) % 2 == 0;
					num = ((int)num2 * -1992959626) ^ 0xAF07041;
					continue;
				case 20u:
					num = (int)(num2 * 1263776078) ^ -1200919511;
					continue;
				case 19u:
					num = -1102676064;
					continue;
				case 18u:
				{
					Form control_2 = Form2.smethod_2((Form)(object)this);
					num7 = Form2.smethod_12((Control)(object)control_2) - 1;
					Form2.smethod_13((Control)(object)control_2, num7);
					num = -1711493537;
					continue;
				}
				case 17u:
					Form2.smethod_1((Control)(object)label3, "Первым ход делает Компьютер.");
					num = ((int)num2 * -2061529381) ^ -1949080329;
					continue;
				case 16u:
					num = ((int)num2 * -535043244) ^ -635592691;
					continue;
				case 14u:
					(Form2.smethod_2((Form)(object)this) as Form3).Button_Continue();
					num = ((int)num2 * -129703737) ^ 0x26B45571;
					continue;
				case 13u:
					num = -944112065;
					continue;
				case 12u:
					Form2.smethod_1((Control)(object)label3, "Поздравляем! Ваш ход первый.");
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = true;
					num = (int)(num2 * 2014029767) ^ -408863363;
					continue;
				case 11u:
				{
					int num12;
					int num13;
					if (num7 <= 1)
					{
						num12 = -1396883570;
						num13 = -1396883570;
					}
					else
					{
						num12 = -1049740331;
						num13 = -1049740331;
					}
					num = num12 ^ (int)(num2 * 723567557);
					continue;
				}
				case 10u:
				{
					int num8;
					int num9;
					if (!flag)
					{
						num8 = -1442220584;
						num9 = -1442220584;
					}
					else
					{
						num8 = -1578888728;
						num9 = -1578888728;
					}
					num = num8 ^ ((int)num2 * -1278774090);
					continue;
				}
				case 9u:
					Form2.smethod_14(Form2.smethod_11(Form2.smethod_2((Form)(object)this)));
					num = (int)((num2 * 911150360) ^ 0x2D1035B8);
					continue;
				case 7u:
					num = (int)((num2 * 910463120) ^ 0x6ED6EC23);
					continue;
				case 6u:
					num = (int)((num2 * 555035601) ^ 0x727F8854);
					continue;
				case 5u:
					num = ((int)num2 * -44084257) ^ 0x13BDAF20;
					continue;
				case 4u:
				{
					Label control_ = label2;
					string string_ = num6.ToString();
					num7 = num5 + num6;
					Form2.smethod_1((Control)(object)control_, Form2.smethod_10("+", string_, "=", num7.ToString()));
					num = (int)(num2 * 574638742) ^ -567111358;
					continue;
				}
				case 3u:
					Form2.smethod_15((Form)(object)this);
					num = (int)((num2 * 1076675062) ^ 0x268B5353);
					continue;
				case 2u:
					num = -1102861550;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (Form2.smethod_8(Form2.smethod_7((Control)(object)textBox1), ""))
					{
						num3 = -2111129837;
						num4 = -2111129837;
					}
					else
					{
						num3 = -1378245617;
						num4 = -1378245617;
					}
					num = num3 ^ ((int)num2 * -1270999017);
					continue;
				}
				case 0u:
					this.flag = false;
					num = -1816002218;
					continue;
				default:
					return;
				case 8u:
					break;
				case 15u:
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
			int num = 1924601504;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x2CB6B95u) % 7u)
				{
				case 5u:
					num3 = ((components != null) ? 1 : 0);
					goto IL_000f;
				case 4u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1192584786;
						num5 = 1192584786;
					}
					else
					{
						num4 = 1201365672;
						num5 = 1201365672;
					}
					num = num4 ^ (int)(num2 * 1934410223);
					continue;
				}
				case 3u:
					if (disposing)
					{
						num = (int)((num2 * 453135275) ^ 0x28799480);
						continue;
					}
					num3 = 0;
					goto IL_000f;
				case 2u:
					num = ((int)num2 * -1519190855) ^ -734363568;
					continue;
				case 1u:
					Form2.smethod_16((IDisposable)components);
					num = ((int)num2 * -812762530) ^ 0xF52570D;
					continue;
				case 6u:
					break;
				default:
					{
						((Form)this).Dispose(disposing);
						return;
					}
					IL_000f:
					flag = (byte)num3 != 0;
					num = 232011831;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected O, but got Unknown
		while (true)
		{
			int num = -1514919682;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA45A812Bu) % 59u)
				{
				case 58u:
					Form2.smethod_24((Control)(object)button1, new Size(73, 23));
					num = (int)((num2 * 41788986) ^ 0x2614DA4D);
					continue;
				case 57u:
					Form2.smethod_36((Form)(object)this, (FormBorderStyle)1);
					num = (int)(num2 * 315449341) ^ -187754861;
					continue;
				case 56u:
					textBox1 = Form2.smethod_18();
					label2 = Form2.smethod_17();
					button1 = Form2.smethod_19();
					label3 = Form2.smethod_17();
					Form2.smethod_20((Control)(object)this);
					Form2.smethod_21((Control)(object)label1, bool_0: true);
					num = (int)(num2 * 558993014) ^ -478871666;
					continue;
				case 55u:
					Form2.smethod_33((Form)(object)this, new Size(255, 224));
					num = ((int)num2 * -1376042156) ^ -684236323;
					continue;
				case 54u:
					Form2.smethod_22((Control)(object)button1, new Point(86, 193));
					num = (int)(num2 * 1144510205) ^ -1593572421;
					continue;
				case 53u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)textBox1);
					num = ((int)num2 * -324667545) ^ 0x66E69D0C;
					continue;
				case 52u:
					num = ((int)num2 * -399587676) ^ 0x3E1B9AF1;
					continue;
				case 51u:
					Form2.smethod_37((Form)(object)this, bool_0: false);
					Form2.smethod_38((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1158488400) ^ -99722191;
					continue;
				case 50u:
					Form2.smethod_28((Control)(object)textBox1, new KeyPressEventHandler(TextBox1_KeyPress));
					num = (int)(num2 * 1457020345) ^ -777110596;
					continue;
				case 49u:
					Form2.smethod_24((Control)(object)label3, new Size(0, 13));
					num = ((int)num2 * -1116126838) ^ -593804796;
					continue;
				case 48u:
					Form2.smethod_25((Control)(object)label3, 4);
					num = ((int)num2 * -209130914) ^ 0x78C85D18;
					continue;
				case 47u:
					num = (int)((num2 * 237980895) ^ 0x4DC83A6);
					continue;
				case 46u:
					Form2.smethod_21((Control)(object)label2, bool_0: true);
					num = ((int)num2 * -996839180) ^ -2078984258;
					continue;
				case 45u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label2);
					num = ((int)num2 * -1330406368) ^ -390671312;
					continue;
				case 44u:
					num = ((int)num2 * -1628039771) ^ 0x16A99D3B;
					continue;
				case 43u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -1502231396) ^ -1919951808;
					continue;
				case 42u:
					Form2.smethod_29((ButtonBase)(object)button1, bool_0: true);
					num = (int)(num2 * 419252558) ^ -2102811298;
					continue;
				case 41u:
					Form2.smethod_22((Control)(object)textBox1, new Point(24, 86));
					num = ((int)num2 * -896192100) ^ -1103327106;
					continue;
				case 40u:
					num = (int)((num2 * 132944749) ^ 0x12CE56B0);
					continue;
				case 39u:
					Form2.smethod_23((Control)(object)textBox1, "textBox1");
					Form2.smethod_24((Control)(object)textBox1, new Size(42, 80));
					num = (int)(num2 * 1797377384) ^ -352484921;
					continue;
				case 37u:
					Form2.smethod_24((Control)(object)label2, new Size(188, 73));
					num = (int)((num2 * 1124196551) ^ 0x38641D9E);
					continue;
				case 36u:
					Form2.smethod_41((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
					Form2.smethod_42((Control)(object)this, bool_0: false);
					num = ((int)num2 * -1707516135) ^ -1536470874;
					continue;
				case 35u:
					num = (int)((num2 * 320677965) ^ 0x62D5C5A0);
					continue;
				case 34u:
					Form2.smethod_40((Form)(object)this, bool_0: false);
					num = ((int)num2 * -727598007) ^ -2011854405;
					continue;
				case 33u:
					Form2.smethod_1((Control)(object)label1, "label1");
					Form2.smethod_27((Control)(object)textBox1, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 1835265953) ^ -1070885762;
					continue;
				case 32u:
					num = (int)((num2 * 750516286) ^ 0x197877D);
					continue;
				case 31u:
					Form2.smethod_1((Control)(object)this, "Жеребьёвка");
					num = ((int)num2 * -1107384040) ^ -11818551;
					continue;
				case 30u:
					Form2.smethod_39((Control)(object)this, "Form2");
					num = ((int)num2 * -257766070) ^ -1077530294;
					continue;
				case 29u:
					Form2.smethod_25((Control)(object)label1, 0);
					num = ((int)num2 * -1247076603) ^ -478879733;
					continue;
				case 28u:
					Form2.smethod_25((Control)(object)label2, 2);
					num = ((int)num2 * -1471059441) ^ 0x27187032;
					continue;
				case 27u:
					Form2.smethod_27((Control)(object)label2, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form2.smethod_22((Control)(object)label2, new Point(53, 89));
					Form2.smethod_23((Control)(object)label2, "label2");
					num = ((int)num2 * -680004345) ^ -829159937;
					continue;
				case 26u:
					Form2.smethod_22((Control)(object)label1, new Point(10, 10));
					num = ((int)num2 * -259098701) ^ 0x1F57795;
					continue;
				case 25u:
					num = ((int)num2 * -1233134785) ^ 0x2894FB29;
					continue;
				case 24u:
					Form2.smethod_23((Control)(object)button1, "button1");
					num = (int)((num2 * 1796090182) ^ 0x5005F525);
					continue;
				case 23u:
					Form2.smethod_23((Control)(object)label1, "label1");
					Form2.smethod_24((Control)(object)label1, new Size(35, 13));
					num = (int)(num2 * 426752266) ^ -1365764499;
					continue;
				case 22u:
					num = (int)((num2 * 491028137) ^ 0x1F362000);
					continue;
				case 21u:
					Form2.smethod_30((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -729309404) ^ -785191280;
					continue;
				case 20u:
					num = ((int)num2 * -755197837) ^ 0x2DA20B89;
					continue;
				case 19u:
					Form2.smethod_25((Control)(object)button1, 3);
					num = (int)((num2 * 1333408822) ^ 0x4777FE65);
					continue;
				case 18u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label3);
					num = (int)((num2 * 59326297) ^ 0x78BB4EBB);
					continue;
				case 17u:
					Form2.smethod_31((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -1476777099) ^ 0x4D74207D;
					continue;
				case 16u:
					Form2.smethod_1((Control)(object)button1, "OK");
					num = ((int)num2 * -1717074284) ^ 0x634DD26;
					continue;
				case 15u:
					num = ((int)num2 * -1948236835) ^ -245340246;
					continue;
				case 14u:
					Form2.smethod_1((Control)(object)label2, "+N=?");
					num = ((int)num2 * -1741424223) ^ 0x4523ADA0;
					continue;
				case 13u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -1313994226) ^ 0x1E30A335;
					continue;
				case 11u:
					num = ((int)num2 * -1575250126) ^ -930455438;
					continue;
				case 10u:
					Form2.smethod_23((Control)(object)label3, "label3");
					num = (int)((num2 * 1862856448) ^ 0x17E637DC);
					continue;
				case 9u:
					Form2.smethod_32((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 1750183524) ^ -224537649;
					continue;
				case 8u:
					num = (int)(num2 * 636627190) ^ -70757666;
					continue;
				case 7u:
					Form2.smethod_25((Control)(object)textBox1, 1);
					num = ((int)num2 * -1169145028) ^ 0x3DEDF340;
					continue;
				case 6u:
					num = (int)(num2 * 1669110661) ^ -617723008;
					continue;
				case 5u:
					Form2.smethod_21((Control)(object)label3, bool_0: true);
					num = (int)(num2 * 1496095894) ^ -670264927;
					continue;
				case 4u:
					num = (int)((num2 * 1615051857) ^ 0x7746DBE7);
					continue;
				case 3u:
					label1 = Form2.smethod_17();
					num = ((int)num2 * -1607300926) ^ 0x367BDD98;
					continue;
				case 2u:
					Form2.smethod_22((Control)(object)label3, new Point(47, 177));
					num = ((int)num2 * -405485136) ^ 0x37EEB1C3;
					continue;
				case 1u:
					num = (int)(num2 * 1518922438) ^ -1797093480;
					continue;
				case 0u:
					num = ((int)num2 * -123652526) ^ 0x39B29E1E;
					continue;
				case 38u:
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
