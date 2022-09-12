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
			int num = -1203357366;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCE4593B1u) % 7u)
				{
				case 6u:
					num = ((int)num2 * -173565977) ^ -1617125772;
					continue;
				case 5u:
					num = (int)((num2 * 86578860) ^ 0x7B301F2A);
					continue;
				case 4u:
					num = (int)(num2 * 396193296) ^ -1214247156;
					continue;
				case 2u:
					Form2.smethod_1((Control)(object)label1, "Введите любое число от 0 до 9 включительно.\nВаш соперник уже загадал число (N) из этого\nже диапазона. Если сумма ваших чисел будет\nчетным числом, то первым ход делаете Вы,\nиначе - ваш соперник Компьютер!");
					num = (int)((num2 * 105439628) ^ 0x31624EF9);
					continue;
				case 1u:
					InitializeComponent();
					num = ((int)num2 * -906083290) ^ 0x3AAD8291;
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
	}

	private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		bool flag = !char.IsDigit(Form2.smethod_4(e));
		while (true)
		{
			int num = -1585875359;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDC97203Du) % 9u)
				{
				case 8u:
					num = ((int)num2 * -696252677) ^ -1058552113;
					continue;
				case 5u:
					Form2.smethod_1((Control)(object)textBox1, "");
					num = -2096176746;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1359601210;
						num5 = -1359601210;
					}
					else
					{
						num4 = -1151753869;
						num5 = -1151753869;
					}
					num = num4 ^ ((int)num2 * -1117356169);
					continue;
				}
				case 3u:
					num = (int)((num2 * 1671606412) ^ 0x5C7CD5B5);
					continue;
				case 2u:
				{
					int num3;
					if (Form2.smethod_4(e) != '\r')
					{
						num = -1903997992;
						num3 = -1903997992;
					}
					else
					{
						num = -1425563167;
						num3 = -1425563167;
					}
					continue;
				}
				case 1u:
					Form2.smethod_5(e, bool_0: true);
					num = (int)((num2 * 330138427) ^ 0x37F932B4);
					continue;
				case 0u:
					Button1_Click(this, Form2.smethod_6());
					num = ((int)num2 * -896676386) ^ 0x13920F60;
					continue;
				default:
					return;
				case 7u:
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
		bool flag2 = default(bool);
		int num4 = default(int);
		int num5 = default(int);
		bool flag = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = -344597043;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x88CE8CACu) % 33u)
				{
				case 32u:
				{
					int num12;
					int num13;
					if (!Form2.smethod_8(Form2.smethod_7((Control)(object)textBox1), ""))
					{
						num12 = 1811524843;
						num13 = 1811524843;
					}
					else
					{
						num12 = 1820968972;
						num13 = 1820968972;
					}
					num = num12 ^ ((int)num2 * -770945379);
					continue;
				}
				case 31u:
				{
					int num10;
					int num11;
					if (!flag2)
					{
						num10 = 1873844139;
						num11 = 1873844139;
					}
					else
					{
						num10 = 1982699006;
						num11 = 1982699006;
					}
					num = num10 ^ ((int)num2 * -1345705078);
					continue;
				}
				case 30u:
					num4 = int.Parse(Form2.smethod_7((Control)(object)textBox1));
					num = (int)(num2 * 1023539648) ^ -675796540;
					continue;
				case 29u:
					(Form2.smethod_2((Form)(object)this) as Form3).Button_Continue();
					Form2.smethod_14(Form2.smethod_11(Form2.smethod_2((Form)(object)this)));
					num = ((int)num2 * -426788447) ^ -1116203163;
					continue;
				case 28u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = true;
					num = (int)(num2 * 632349958) ^ -2070706980;
					continue;
				case 27u:
					Form2.smethod_1((Control)(object)label3, "Поздравляем! Ваш ход первый.");
					num = (int)(num2 * 1426701746) ^ -265897934;
					continue;
				case 26u:
					flag2 = num5 > 1;
					num = (int)(num2 * 602856904) ^ -1438763692;
					continue;
				case 25u:
				{
					int num8;
					int num9;
					if (!flag)
					{
						num8 = -497872890;
						num9 = -497872890;
					}
					else
					{
						num8 = -914219929;
						num9 = -914219929;
					}
					num = num8 ^ ((int)num2 * -588311702);
					continue;
				}
				case 24u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = false;
					num = ((int)num2 * -1349614131) ^ -1551807051;
					continue;
				case 23u:
					Form2.smethod_1((Control)(object)label3, "Первым ход делает Компьютер.");
					num = (int)(num2 * 1295324865) ^ -931382553;
					continue;
				case 22u:
					num = ((int)num2 * -362009830) ^ -1166297373;
					continue;
				case 21u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).StartGame();
					Form2.smethod_15((Form)(object)this);
					num = ((int)num2 * -1392316910) ^ -1564869441;
					continue;
				case 20u:
				{
					Form control_2 = Form2.smethod_2((Form)(object)this);
					num5 = Form2.smethod_12((Control)(object)control_2) - 1;
					Form2.smethod_13((Control)(object)control_2, num5);
					num = -383970358;
					continue;
				}
				case 19u:
				{
					int num6;
					int num7;
					if ((num4 + num3) % 2 == 0)
					{
						num6 = 364639038;
						num7 = 364639038;
					}
					else
					{
						num6 = 1261483510;
						num7 = 1261483510;
					}
					num = num6 ^ (int)(num2 * 977011389);
					continue;
				}
				case 18u:
					num = -81302926;
					continue;
				case 17u:
					num = ((int)num2 * -949030581) ^ 0x41742977;
					continue;
				case 16u:
					num = (int)(num2 * 220376949) ^ -1102401318;
					continue;
				case 15u:
					num = ((int)num2 * -1610420741) ^ 0x15C0E49;
					continue;
				case 14u:
					num = (int)(num2 * 1980858234) ^ -84763372;
					continue;
				case 13u:
					num = ((int)num2 * -56729522) ^ -1663546017;
					continue;
				case 12u:
					num = -188622186;
					continue;
				case 11u:
					num = ((int)num2 * -1092662806) ^ 0x7DEF4596;
					continue;
				case 10u:
				{
					num3 = Form2.smethod_9(rnd, 10);
					Label control_ = label2;
					string string_ = num3.ToString();
					num5 = num4 + num3;
					Form2.smethod_1((Control)(object)control_, Form2.smethod_10("+", string_, "=", num5.ToString()));
					num = ((int)num2 * -214440590) ^ -1898551500;
					continue;
				}
				case 9u:
					this.flag = false;
					num = -1531210429;
					continue;
				case 8u:
					num = (int)((num2 * 1570814167) ^ 0x78DE4CDA);
					continue;
				case 6u:
					num = -882202763;
					continue;
				case 5u:
					num = (int)((num2 * 1442048895) ^ 0xC5051FA);
					continue;
				case 3u:
					num = -1378466892;
					continue;
				case 2u:
					flag = this.flag;
					num = ((int)num2 * -323300866) ^ 0x7CCF98E1;
					continue;
				case 1u:
					num = ((int)num2 * -1344174967) ^ -369075798;
					continue;
				case 0u:
					num = (int)(num2 * 1119812575) ^ -771898068;
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

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			goto IL_0009;
		}
		int num = 0;
		goto IL_00dc;
		IL_00d3:
		num = ((components != null) ? 1 : 0);
		goto IL_00dc;
		IL_0009:
		int num2 = 2064346781;
		goto IL_0099;
		IL_0099:
		bool flag = default(bool);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x21A14212u) % 10u)
			{
			case 9u:
				break;
			case 8u:
				num2 = (int)(num3 * 660032362) ^ -914944381;
				continue;
			case 6u:
				num2 = (int)(num3 * 1387333046) ^ -1509604111;
				continue;
			case 4u:
			{
				int num4;
				int num5;
				if (flag)
				{
					num4 = -110005289;
					num5 = -110005289;
				}
				else
				{
					num4 = -1773351253;
					num5 = -1773351253;
				}
				num2 = num4 ^ ((int)num3 * -1448343474);
				continue;
			}
			case 3u:
				num2 = ((int)num3 * -1477602663) ^ -833977655;
				continue;
			case 2u:
				num2 = (int)((num3 * 374993937) ^ 0x4D45AFF8);
				continue;
			case 1u:
				((Form)this).Dispose(disposing);
				num2 = 557808894;
				continue;
			case 0u:
				Form2.smethod_16((IDisposable)components);
				num2 = ((int)num3 * -896328276) ^ 0x7F7F8F16;
				continue;
			default:
				return;
			case 7u:
				goto IL_00d3;
			case 5u:
				return;
			}
			break;
		}
		goto IL_0009;
		IL_00dc:
		flag = (byte)num != 0;
		num2 = 1655928100;
		goto IL_0099;
	}

	private void InitializeComponent()
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		while (true)
		{
			int num = 1452407668;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7C6504E1u) % 60u)
				{
				case 59u:
					Form2.smethod_27((Control)(object)label2, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1078388327) ^ 0x7A1A300B;
					continue;
				case 57u:
					Form2.smethod_37((Form)(object)this, bool_0: false);
					Form2.smethod_38((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1470201121) ^ -148109290;
					continue;
				case 56u:
					Form2.smethod_41((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
					num = (int)((num2 * 650111922) ^ 0x31A4006F);
					continue;
				case 55u:
					Form2.smethod_29((ButtonBase)(object)button1, bool_0: true);
					num = (int)(num2 * 1850342348) ^ -1256921662;
					continue;
				case 54u:
					num = (int)(num2 * 1974674217) ^ -1476337298;
					continue;
				case 53u:
					Form2.smethod_28((Control)(object)textBox1, new KeyPressEventHandler(TextBox1_KeyPress));
					num = ((int)num2 * -1324664611) ^ -1493300700;
					continue;
				case 52u:
					Form2.smethod_25((Control)(object)label2, 2);
					num = (int)((num2 * 1865735230) ^ 0x45CD8CC5);
					continue;
				case 51u:
					Form2.smethod_40((Form)(object)this, bool_0: false);
					num = (int)(num2 * 2071609115) ^ -1091395198;
					continue;
				case 50u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)textBox1);
					num = (int)((num2 * 1299923739) ^ 0x5BAF6D65);
					continue;
				case 49u:
					num = ((int)num2 * -531049563) ^ 0x28F2479F;
					continue;
				case 48u:
					num = ((int)num2 * -627218368) ^ 0x3EEA802D;
					continue;
				case 47u:
					label2 = Form2.smethod_17();
					button1 = Form2.smethod_19();
					num = ((int)num2 * -1765310881) ^ 0x3DFB3A59;
					continue;
				case 46u:
					num = (int)((num2 * 957608304) ^ 0x114A5243);
					continue;
				case 45u:
					label1 = Form2.smethod_17();
					num = (int)((num2 * 334903486) ^ 0x58809BA);
					continue;
				case 44u:
					Form2.smethod_22((Control)(object)textBox1, new Point(24, 86));
					Form2.smethod_23((Control)(object)textBox1, "textBox1");
					num = ((int)num2 * -1460124908) ^ -1008186845;
					continue;
				case 43u:
					Form2.smethod_24((Control)(object)label2, new Size(188, 73));
					num = ((int)num2 * -1000422839) ^ 0x5A19A21A;
					continue;
				case 42u:
					Form2.smethod_1((Control)(object)button1, "OK");
					num = ((int)num2 * -1727065628) ^ -1672041908;
					continue;
				case 41u:
					label3 = Form2.smethod_17();
					Form2.smethod_20((Control)(object)this);
					num = (int)(num2 * 1151995402) ^ -1808148355;
					continue;
				case 40u:
					num = ((int)num2 * -1881902402) ^ 0x7707E61F;
					continue;
				case 39u:
					Form2.smethod_24((Control)(object)label1, new Size(35, 13));
					num = ((int)num2 * -688861879) ^ -1167322151;
					continue;
				case 38u:
					Form2.smethod_21((Control)(object)label1, bool_0: true);
					num = (int)((num2 * 582015969) ^ 0x13C1A379);
					continue;
				case 36u:
					Form2.smethod_25((Control)(object)label1, 0);
					num = (int)((num2 * 1956778236) ^ 0x451418A6);
					continue;
				case 35u:
					num = ((int)num2 * -1112980317) ^ -1417622303;
					continue;
				case 34u:
					Form2.smethod_42((Control)(object)this, bool_0: false);
					num = (int)(num2 * 1563178828) ^ -1329636564;
					continue;
				case 33u:
					textBox1 = Form2.smethod_18();
					num = ((int)num2 * -314116636) ^ 0x764249BA;
					continue;
				case 32u:
					num = ((int)num2 * -90420881) ^ 0x5DC34BC2;
					continue;
				case 31u:
					Form2.smethod_24((Control)(object)button1, new Size(73, 23));
					num = ((int)num2 * -1463989269) ^ -1590365791;
					continue;
				case 30u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label2);
					num = (int)((num2 * 2023757046) ^ 0x1A3DCF77);
					continue;
				case 29u:
					Form2.smethod_22((Control)(object)label1, new Point(10, 10));
					Form2.smethod_23((Control)(object)label1, "label1");
					num = (int)(num2 * 836103808) ^ -127194602;
					continue;
				case 28u:
					Form2.smethod_39((Control)(object)this, "Form2");
					num = ((int)num2 * -628416911) ^ 0x40305164;
					continue;
				case 27u:
					Form2.smethod_21((Control)(object)label3, bool_0: true);
					Form2.smethod_22((Control)(object)label3, new Point(47, 177));
					Form2.smethod_23((Control)(object)label3, "label3");
					Form2.smethod_24((Control)(object)label3, new Size(0, 13));
					num = (int)(num2 * 1446427189) ^ -1062079414;
					continue;
				case 26u:
					Form2.smethod_27((Control)(object)textBox1, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 948289525) ^ 0x346ED56F);
					continue;
				case 25u:
					num = ((int)num2 * -1424104595) ^ 0x540E8D89;
					continue;
				case 24u:
					num = (int)((num2 * 275793552) ^ 0x42AAD6D6);
					continue;
				case 23u:
					num = (int)(num2 * 2100241551) ^ -966480149;
					continue;
				case 22u:
					num = ((int)num2 * -938947047) ^ 0x36A4EDE4;
					continue;
				case 21u:
					num = (int)((num2 * 21564256) ^ 0x1EB8E4);
					continue;
				case 20u:
					Form2.smethod_25((Control)(object)label3, 4);
					Form2.smethod_31((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -904584649) ^ 0x7247C15E;
					continue;
				case 19u:
					Form2.smethod_30((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -1746342868) ^ -1429761635;
					continue;
				case 18u:
					Form2.smethod_25((Control)(object)textBox1, 1);
					num = (int)(num2 * 1323380750) ^ -100324272;
					continue;
				case 17u:
					num = ((int)num2 * -1269927517) ^ -1330673651;
					continue;
				case 16u:
					Form2.smethod_21((Control)(object)label2, bool_0: true);
					num = ((int)num2 * -641984385) ^ -56427949;
					continue;
				case 15u:
					Form2.smethod_32((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 389401258) ^ -368692141;
					continue;
				case 14u:
					Form2.smethod_36((Form)(object)this, (FormBorderStyle)1);
					num = (int)((num2 * 1495535065) ^ 0x95B85A4);
					continue;
				case 13u:
					num = (int)(num2 * 1698649270) ^ -329876880;
					continue;
				case 12u:
					Form2.smethod_22((Control)(object)button1, new Point(86, 193));
					Form2.smethod_23((Control)(object)button1, "button1");
					num = ((int)num2 * -768217871) ^ -1615454682;
					continue;
				case 11u:
					Form2.smethod_1((Control)(object)label1, "label1");
					num = ((int)num2 * -1447277339) ^ -1659890020;
					continue;
				case 10u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label1);
					num = (int)((num2 * 1817422931) ^ 0xF1F2DA9);
					continue;
				case 9u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label3);
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -1547126160) ^ -495715125;
					continue;
				case 8u:
					Form2.smethod_1((Control)(object)label2, "+N=?");
					num = (int)(num2 * 708626856) ^ -1935943927;
					continue;
				case 7u:
					Form2.smethod_23((Control)(object)label2, "label2");
					num = (int)((num2 * 1750691814) ^ 0x7EDCBC66);
					continue;
				case 6u:
					Form2.smethod_24((Control)(object)textBox1, new Size(42, 80));
					num = (int)(num2 * 487420404) ^ -1338228669;
					continue;
				case 5u:
					Form2.smethod_25((Control)(object)button1, 3);
					num = ((int)num2 * -578305020) ^ -1522805731;
					continue;
				case 4u:
					num = ((int)num2 * -1681347971) ^ -630584643;
					continue;
				case 3u:
					num = ((int)num2 * -244161619) ^ -916540290;
					continue;
				case 2u:
					Form2.smethod_1((Control)(object)this, "Жеребьёвка");
					num = (int)(num2 * 1358985679) ^ -673527693;
					continue;
				case 1u:
					Form2.smethod_22((Control)(object)label2, new Point(53, 89));
					num = (int)(num2 * 635158529) ^ -779967892;
					continue;
				case 0u:
					Form2.smethod_33((Form)(object)this, new Size(255, 224));
					num = (int)(num2 * 117941415) ^ -308693360;
					continue;
				case 58u:
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
