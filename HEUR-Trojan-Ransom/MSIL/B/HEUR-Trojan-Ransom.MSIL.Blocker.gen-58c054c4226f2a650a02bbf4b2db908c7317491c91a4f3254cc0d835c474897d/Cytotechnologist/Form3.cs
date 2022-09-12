using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Cytotechnologist;

public class Form3 : Form
{
	private IContainer components = null;

	private Button button1;

	private Button button2;

	private Button button4;

	private Button button5;

	private Button button7;

	private TextBox textBox1;

	private Label label1;

	private TextBox textBox2;

	private Button NullButton;

	private ErrorProvider errorProvider1;

	public Form3()
	{
		InitializeComponent();
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		Form3.smethod_0((Control)(object)NullButton);
		Form val = default(Form);
		while (true)
		{
			int num = 1660928808;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6697F70Cu) % 9u)
				{
				case 7u:
				{
					Form4 form = new Form4();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					num = ((int)num2 * -1902552528) ^ 0x6B07EC4D;
					continue;
				}
				case 6u:
					num = ((int)num2 * -146969389) ^ 0x6F0C4D7D;
					continue;
				case 5u:
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = (int)(num2 * 2005027736) ^ -1149301498;
					continue;
				case 4u:
					Form3.smethod_1(errorProvider1);
					num = (int)(num2 * 971949141) ^ -536410602;
					continue;
				case 3u:
					Form3.smethod_10(val, new Point(Form3.smethod_5((Form)(object)this).X + (Form3.smethod_6((Control)(object)this) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_5((Form)(object)this).Y + (Form3.smethod_8((Control)(object)this) - Form3.smethod_9((Control)(object)val)) / 2 + 70));
					num = (int)(num2 * 1455746224) ^ -1177027971;
					continue;
				case 1u:
					Form3.smethod_4((Control)(object)val);
					num = ((int)num2 * -763618008) ^ 0x14227AEC;
					continue;
				case 0u:
					num = (int)(num2 * 1087421655) ^ -64922007;
					continue;
				default:
					return;
				case 8u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		Form val = default(Form);
		while (true)
		{
			int num = 1756848425;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1C00235Au) % 9u)
				{
				case 7u:
					num = (int)(num2 * 1118231560) ^ -1312263797;
					continue;
				case 6u:
					Form3.smethod_4((Control)(object)val);
					num = (int)(num2 * 174591850) ^ -1268090065;
					continue;
				case 5u:
					Form3.smethod_10(val, new Point(Form3.smethod_13(Form3.smethod_12((Form)(object)this)).X + (Form3.smethod_7((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_13(Form3.smethod_12((Form)(object)this)).Y + (Form3.smethod_9((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_9((Control)(object)val)) / 2));
					num = (int)(num2 * 1414697273) ^ -528135132;
					continue;
				case 3u:
				{
					Form3.smethod_0((Control)(object)NullButton);
					Form2 form = new Form2();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					num = (int)(num2 * 881182184) ^ -533376256;
					continue;
				}
				case 2u:
					num = ((int)num2 * -236984651) ^ -230714119;
					continue;
				case 1u:
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = ((int)num2 * -1508188697) ^ 0x71539729;
					continue;
				case 0u:
					num = (int)((num2 * 1776742634) ^ 0x651106C0);
					continue;
				default:
					return;
				case 4u:
					break;
				case 8u:
					return;
				}
				break;
			}
		}
	}

	public void Button_Continue()
	{
		Form3.smethod_14((Control)(object)button5, bool_0: true);
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = Form3.smethod_8((Control)(object)this) - 1;
			int num2 = 279341200;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x66D0E841u) % 10u)
				{
				case 8u:
					Form3.smethod_16(Form3.smethod_12((Form)(object)this));
					num2 = ((int)num3 * -1796535560) ^ 0x14A041A4;
					continue;
				case 7u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 511243500;
						num5 = 511243500;
					}
					else
					{
						num4 = 580322252;
						num5 = 580322252;
					}
					num2 = num4 ^ ((int)num3 * -398523763);
					continue;
				}
				case 6u:
					Form3.smethod_17((Form3.smethod_12((Form)(object)this) as Form1).timer1);
					num2 = ((int)num3 * -267021304) ^ 0x2DE50809;
					continue;
				case 5u:
					flag = num > 1;
					num2 = ((int)num3 * -864596174) ^ 0x2F1F2F5E;
					continue;
				case 4u:
					num2 = 2061677342;
					continue;
				case 3u:
					Form3.smethod_15((Control)(object)this, num);
					num2 = (int)((num3 * 1915035496) ^ 0x76600140);
					continue;
				case 1u:
					num2 = ((int)num3 * -1172258082) ^ -927958779;
					continue;
				case 0u:
					num2 = 549906325;
					continue;
				default:
					return;
				case 9u:
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
	}

	private void TextBox_TextChanged(object sender, EventArgs e)
	{
		Form3.smethod_1(errorProvider1);
	}

	public void ContinueLock()
	{
		Form3.smethod_14((Control)(object)button5, bool_0: false);
		while (true)
		{
			int num = -714426812;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA558C1B2u) % 3u)
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
				num = ((int)num2 * -1175431411) ^ -649807992;
			}
		}
	}

	public void AchivUnlock()
	{
		Form3.smethod_14((Control)(object)button7, bool_0: true);
		while (true)
		{
			int num = -412460836;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAAB48E1Du) % 3u)
				{
				case 1u:
					goto IL_000e;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_000e:
				num = (int)(num2 * 384277840) ^ -227676035;
			}
		}
	}

	private void Button7_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -1676297000;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEF87642Fu) % 3u)
				{
				case 1u:
					goto IL_0003;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0003:
				Form3.smethod_0((Control)(object)NullButton);
				Form3.smethod_14((Control)(object)button7, bool_0: false);
				num = (int)(num2 * 1541117269) ^ -1358204179;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			goto IL_004f;
		}
		int num = 0;
		goto IL_00c6;
		IL_00bd:
		num = ((components != null) ? 1 : 0);
		goto IL_00c6;
		IL_004f:
		int num2 = 988380672;
		goto IL_0087;
		IL_0087:
		bool flag = default(bool);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x696C7152u) % 9u)
			{
			case 8u:
				num2 = ((int)num3 * -1403023157) ^ 0x42AED45D;
				continue;
			case 7u:
				((Form)this).Dispose(disposing);
				num2 = 1503090753;
				continue;
			case 6u:
				num2 = ((int)num3 * -871716663) ^ 0xE379E48;
				continue;
			case 3u:
				Form3.smethod_18((IDisposable)components);
				num2 = (int)((num3 * 308990306) ^ 0xDFC47A8);
				continue;
			case 2u:
				break;
			case 1u:
				num2 = ((int)num3 * -247847620) ^ -1545439518;
				continue;
			case 0u:
			{
				int num4;
				int num5;
				if (!flag)
				{
					num4 = 2114220343;
					num5 = 2114220343;
				}
				else
				{
					num4 = 133307202;
					num5 = 133307202;
				}
				num2 = num4 ^ ((int)num3 * -1776139841);
				continue;
			}
			default:
				return;
			case 4u:
				goto IL_00bd;
			case 5u:
				return;
			}
			break;
		}
		goto IL_004f;
		IL_00c6:
		flag = (byte)num != 0;
		num2 = 1077578121;
		goto IL_0087;
	}

	private void InitializeComponent()
	{
		while (true)
		{
			int num = 150128060;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5667F11Fu) % 139u)
				{
				case 138u:
					textBox1 = Form3.smethod_21();
					num = ((int)num2 * -549535922) ^ -197230400;
					continue;
				case 137u:
					Form3.smethod_36((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)((num2 * 1993034981) ^ 0x5A6F4ED9);
					continue;
				case 136u:
					Form3.smethod_30((Control)(object)button1, new Point(265, 49));
					num = ((int)num2 * -1340005908) ^ -167125624;
					continue;
				case 135u:
					num = ((int)num2 * -1625760165) ^ 0x192EAF34;
					continue;
				case 134u:
					Form3.smethod_31((Control)(object)NullButton, "NullButton");
					num = (int)((num2 * 1224364559) ^ 0x2D28782);
					continue;
				case 133u:
					components = Form3.smethod_19();
					num = (int)((num2 * 1008296) ^ 0x33BBB477);
					continue;
				case 132u:
					num = (int)((num2 * 354763126) ^ 0x223B9B59);
					continue;
				case 131u:
					Form3.smethod_30((Control)(object)button2, new Point(174, 49));
					num = (int)((num2 * 657688351) ^ 0x36AD97C2);
					continue;
				case 130u:
					Form3.smethod_31((Control)(object)textBox2, "textBox2");
					num = ((int)num2 * -876373290) ^ -621534419;
					continue;
				case 129u:
					button2 = Form3.smethod_20();
					num = ((int)num2 * -1007070901) ^ -978666457;
					continue;
				case 128u:
					Form3.smethod_39((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -817910336) ^ -1402380296;
					continue;
				case 127u:
					Form3.smethod_32((Control)(object)button4, new Size(140, 50));
					Form3.smethod_33((Control)(object)button4, 4);
					Form3.smethod_35((Control)(object)button4, "Начало игры");
					num = ((int)num2 * -1861275449) ^ 0x7B4CAB23;
					continue;
				case 126u:
					button4 = Form3.smethod_20();
					button5 = Form3.smethod_20();
					num = (int)((num2 * 1699330127) ^ 0x1CC4FE2);
					continue;
				case 125u:
					Form3.smethod_14((Control)(object)button5, bool_0: false);
					num = (int)(num2 * 601855572) ^ -51339131;
					continue;
				case 124u:
					Form3.smethod_35((Control)(object)button1, "Вход");
					num = (int)((num2 * 1678048994) ^ 0x34B3DBCC);
					continue;
				case 123u:
					Form3.smethod_43((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)(num2 * 1802901984) ^ -1807175761;
					continue;
				case 122u:
					num = ((int)num2 * -1539571948) ^ 0x6AEC3164;
					continue;
				case 121u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)NullButton), 0);
					num = ((int)num2 * -292334701) ^ -1219435460;
					continue;
				case 120u:
					Form3.smethod_44((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -1887419647) ^ -429035728;
					continue;
				case 119u:
					num = (int)(num2 * 1006362392) ^ -1875053631;
					continue;
				case 118u:
					Form3.smethod_32((Control)(object)label1, new Size(207, 76));
					num = (int)((num2 * 805437803) ^ 0x5097319D);
					continue;
				case 117u:
					Form3.smethod_30((Control)(object)NullButton, new Point(-1, -1));
					num = (int)(num2 * 250276833) ^ -1032546060;
					continue;
				case 116u:
					Form3.smethod_35((Control)(object)label1, "QUARTO");
					Form3.smethod_30((Control)(object)textBox2, new Point(174, 26));
					num = ((int)num2 * -1435637750) ^ -2032886054;
					continue;
				case 114u:
					Form3.smethod_50((Form)(object)this, bool_0: false);
					num = ((int)num2 * -487481683) ^ -1755697568;
					continue;
				case 113u:
					Form3.smethod_56((Control)(object)this, bool_0: false);
					num = (int)(num2 * 579970327) ^ -1872245086;
					continue;
				case 112u:
					num = (int)(num2 * 480458777) ^ -2126035581;
					continue;
				case 111u:
					num = (int)((num2 * 800975207) ^ 0x14C11927);
					continue;
				case 110u:
					Form3.smethod_32((Control)(object)textBox2, new Size(140, 20));
					num = ((int)num2 * -912320648) ^ 0x65C9CB3E;
					continue;
				case 109u:
					num = (int)(num2 * 1631350999) ^ -215959396;
					continue;
				case 108u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -740001267) ^ 0x1AFB0B82;
					continue;
				case 107u:
					Form3.smethod_32((Control)(object)textBox1, new Size(140, 20));
					num = ((int)num2 * -1615760849) ^ 0x3A1F0BA8;
					continue;
				case 106u:
					num = (int)((num2 * 1502573200) ^ 0x443347C2);
					continue;
				case 105u:
					Form3.smethod_29((ButtonBase)(object)button4, (FlatStyle)0);
					num = ((int)num2 * -1818578992) ^ 0x47CB3959;
					continue;
				case 104u:
					Form3.smethod_33((Control)(object)button5, 5);
					Form3.smethod_35((Control)(object)button5, "Продолжить");
					num = ((int)num2 * -1962814788) ^ 0x53C55CA;
					continue;
				case 103u:
					num = ((int)num2 * -1956834185) ^ 0x53CA0496;
					continue;
				case 102u:
					num = ((int)num2 * -396437629) ^ 0x3D09D337;
					continue;
				case 101u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button1);
					num = (int)(num2 * 1159741472) ^ -1466264436;
					continue;
				case 100u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox2);
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox1);
					num = ((int)num2 * -925322052) ^ 0x10117188;
					continue;
				case 99u:
					Form3.smethod_40((Control)(object)label1, bool_0: true);
					num = (int)(num2 * 354593469) ^ -1172931195;
					continue;
				case 98u:
					Form3.smethod_34((ButtonBase)(object)NullButton, bool_0: false);
					num = ((int)num2 * -1396818527) ^ -1123238320;
					continue;
				case 97u:
					label1 = Form3.smethod_22();
					num = (int)((num2 * 2059193041) ^ 0x31C0492C);
					continue;
				case 96u:
					button7 = Form3.smethod_20();
					num = ((int)num2 * -1463778429) ^ -1935251603;
					continue;
				case 95u:
					Form3.smethod_33((Control)(object)button1, 0);
					num = (int)((num2 * 438561893) ^ 0x7F79433B);
					continue;
				case 94u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button5), 0);
					num = ((int)num2 * -696283156) ^ -911311582;
					continue;
				case 93u:
					Form3.smethod_26((Control)(object)this, Color.White);
					num = ((int)num2 * -1337303520) ^ 0x6D994595;
					continue;
				case 92u:
					Form3.smethod_30((Control)(object)button5, new Point(174, 190));
					num = (int)((num2 * 2114728607) ^ 0x228220FB);
					continue;
				case 91u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button7);
					num = ((int)num2 * -1520881828) ^ 0x5131CB87;
					continue;
				case 90u:
					Form3.smethod_35((Control)(object)button2, "Регистрация");
					Form3.smethod_34((ButtonBase)(object)button2, bool_0: true);
					num = ((int)num2 * -1229945561) ^ 0x5B6BB789;
					continue;
				case 88u:
					num = ((int)num2 * -618118059) ^ 0x2BD9FD5E;
					continue;
				case 87u:
					num = (int)((num2 * 228927544) ^ 0x2438CD4F);
					continue;
				case 86u:
					Form3.smethod_36((Control)(object)button4, (EventHandler)Button4_Click);
					num = (int)(num2 * 1109618823) ^ -1602742404;
					continue;
				case 85u:
					Form3.smethod_36((Control)(object)button5, (EventHandler)Button5_Click);
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button7), 0);
					num = (int)((num2 * 1614865126) ^ 0x27AE27FF);
					continue;
				case 84u:
					Form3.smethod_29((ButtonBase)(object)NullButton, (FlatStyle)0);
					num = ((int)num2 * -1493950563) ^ -1583726333;
					continue;
				case 83u:
					num = (int)((num2 * 1717114248) ^ 0x7D92F920);
					continue;
				case 82u:
					Form3.smethod_31((Control)(object)button2, "button2");
					num = (int)(num2 * 1552085386) ^ -420961715;
					continue;
				case 81u:
					Form3.smethod_29((ButtonBase)(object)button7, (FlatStyle)0);
					num = (int)((num2 * 35544294) ^ 0x5E86C786);
					continue;
				case 80u:
					Form3.smethod_30((Control)(object)button4, new Point(174, 137));
					num = (int)(num2 * 1792597590) ^ -508906481;
					continue;
				case 79u:
					num = (int)(num2 * 1655333670) ^ -1962776769;
					continue;
				case 78u:
					Form3.smethod_53((Form)(object)this, bool_0: false);
					num = ((int)num2 * -344372268) ^ -227906409;
					continue;
				case 77u:
					Form3.smethod_54((Form)(object)this, bool_0: true);
					num = ((int)num2 * -1718076502) ^ 0x140D8B21;
					continue;
				case 76u:
					Form3.smethod_32((Control)(object)button5, new Size(140, 50));
					num = (int)(num2 * 1448243533) ^ -1556827750;
					continue;
				case 75u:
					Form3.smethod_38((Control)(object)label1, Form3.smethod_37("Mistral", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1331041162) ^ -1112736326;
					continue;
				case 74u:
					Form3.smethod_32((Control)(object)button1, new Size(49, 21));
					num = ((int)num2 * -487675687) ^ 0x4BE96131;
					continue;
				case 73u:
					num = (int)(num2 * 1645816162) ^ -1740016482;
					continue;
				case 72u:
					num = ((int)num2 * -1429615299) ^ 0x24CE2F08;
					continue;
				case 71u:
					Form3.smethod_32((Control)(object)button2, new Size(85, 21));
					Form3.smethod_33((Control)(object)button2, 1);
					num = (int)(num2 * 184501600) ^ -1821994670;
					continue;
				case 70u:
					num = (int)((num2 * 851128691) ^ 0x2E7829F2);
					continue;
				case 69u:
					num = ((int)num2 * -1591320554) ^ -149201161;
					continue;
				case 68u:
					Form3.smethod_41(textBox2, bool_0: true);
					Form3.smethod_39((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					Form3.smethod_42(errorProvider1, (ContainerControl)(object)this);
					num = (int)(num2 * 1103555433) ^ -1464801382;
					continue;
				case 67u:
					num = (int)(num2 * 1753974770) ^ -1227091452;
					continue;
				case 66u:
					num = ((int)num2 * -1329391147) ^ 0x22968215;
					continue;
				case 65u:
					num = ((int)num2 * -1391931904) ^ 0x7348D1AA;
					continue;
				case 64u:
					Form3.smethod_30((Control)(object)label1, new Point(140, 70));
					num = (int)((num2 * 25657040) ^ 0x578E55B0);
					continue;
				case 63u:
					Form3.smethod_36((Control)(object)button2, (EventHandler)Button2_Click);
					num = (int)((num2 * 392557299) ^ 0x7C96F9A6);
					continue;
				case 62u:
					Form3.smethod_45((Form)(object)this, new Size(486, 296));
					num = ((int)num2 * -1384751865) ^ -1242424643;
					continue;
				case 61u:
					Form3.smethod_31((Control)(object)button7, "button7");
					num = (int)(num2 * 56704178) ^ -1983163828;
					continue;
				case 60u:
					errorProvider1 = Form3.smethod_23(components);
					Form3.smethod_24((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -489106870) ^ 0x207C4CBF;
					continue;
				case 59u:
					num = ((int)num2 * -1603906630) ^ -344760112;
					continue;
				case 58u:
					num = (int)(num2 * 34986305) ^ -1622773775;
					continue;
				case 57u:
					Form3.smethod_55((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -1645043458) ^ -689730788;
					continue;
				case 56u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button2);
					num = ((int)num2 * -887485450) ^ 0x7902FAC9;
					continue;
				case 55u:
					textBox2 = Form3.smethod_21();
					num = ((int)num2 * -878374822) ^ 0x2F0CFF2C;
					continue;
				case 54u:
					Form3.smethod_31((Control)(object)textBox1, "textBox1");
					num = ((int)num2 * -1733872704) ^ -961690398;
					continue;
				case 53u:
					NullButton = Form3.smethod_20();
					button1 = Form3.smethod_20();
					num = ((int)num2 * -1235214912) ^ 0x407C185F;
					continue;
				case 52u:
					num = (int)((num2 * 11523382) ^ 0x4DD9A168);
					continue;
				case 51u:
					Form3.smethod_36((Control)(object)button7, (EventHandler)Button7_Click);
					num = ((int)num2 * -50045156) ^ 0x53E7C302;
					continue;
				case 50u:
					num = ((int)num2 * -711741022) ^ 0x7D22B077;
					continue;
				case 49u:
					Form3.smethod_30((Control)(object)textBox1, new Point(174, 2));
					num = ((int)num2 * -382915113) ^ 0x6DE2009C;
					continue;
				case 48u:
					Form3.smethod_51((Control)(object)this, "Form3");
					num = ((int)num2 * -1375453021) ^ -575643094;
					continue;
				case 47u:
					Form3.smethod_33((Control)(object)NullButton, 3);
					num = (int)(num2 * 1039217478) ^ -2024717988;
					continue;
				case 46u:
					Form3.smethod_32((Control)(object)button7, new Size(140, 50));
					num = (int)(num2 * 1305682882) ^ -1425713264;
					continue;
				case 45u:
					num = (int)(num2 * 1238423285) ^ -1313783122;
					continue;
				case 44u:
					Form3.smethod_34((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -2099668035) ^ 0x785520E5;
					continue;
				case 43u:
					num = (int)((num2 * 575143061) ^ 0x12BCEE4B);
					continue;
				case 42u:
					Form3.smethod_48((Form)(object)this, (FormBorderStyle)0);
					num = ((int)num2 * -241078525) ^ 0x4B35889;
					continue;
				case 41u:
					Form3.smethod_31((Control)(object)button1, "button1");
					num = ((int)num2 * -2059151217) ^ 0x20002CF0;
					continue;
				case 40u:
					num = (int)((num2 * 620960019) ^ 0x7BC19FD1);
					continue;
				case 39u:
					Form3.smethod_34((ButtonBase)(object)button4, bool_0: true);
					num = ((int)num2 * -359416382) ^ -664132964;
					continue;
				case 38u:
					Form3.smethod_34((ButtonBase)(object)button7, bool_0: true);
					num = ((int)num2 * -1908014656) ^ -265031129;
					continue;
				case 37u:
					num = (int)((num2 * 751550499) ^ 0x495D19D1);
					continue;
				case 36u:
					Form3.smethod_35((Control)(object)button7, "Достижения");
					num = ((int)num2 * -1099794106) ^ 0x35A0B191;
					continue;
				case 35u:
					num = ((int)num2 * -1917421214) ^ 0x215CA25E;
					continue;
				case 34u:
					num = (int)(num2 * 92190347) ^ -1799435047;
					continue;
				case 33u:
					num = ((int)num2 * -721110444) ^ 0x372394E0;
					continue;
				case 32u:
					num = (int)(num2 * 1852765333) ^ -870084093;
					continue;
				case 31u:
					Form3.smethod_33((Control)(object)textBox2, 8);
					num = ((int)num2 * -668337605) ^ -1895161792;
					continue;
				case 30u:
					Form3.smethod_29((ButtonBase)(object)button5, (FlatStyle)0);
					num = (int)(num2 * 1437691374) ^ -404531137;
					continue;
				case 29u:
					Form3.smethod_25((Control)(object)this);
					num = ((int)num2 * -2114631938) ^ 0x487DEF73;
					continue;
				case 28u:
					Form3.smethod_31((Control)(object)button4, "button4");
					num = ((int)num2 * -1699914168) ^ 0x575CBD26;
					continue;
				case 27u:
					num = ((int)num2 * -1192755859) ^ 0x9248CF;
					continue;
				case 26u:
					Form3.smethod_33((Control)(object)button7, 6);
					num = ((int)num2 * -1914972761) ^ -193742413;
					continue;
				case 25u:
					Form3.smethod_52((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1360642510) ^ -1057748692;
					continue;
				case 24u:
					Form3.smethod_26((Control)(object)label1, Color.Transparent);
					num = ((int)num2 * -551391698) ^ -628022206;
					continue;
				case 23u:
					Form3.smethod_33((Control)(object)textBox1, 7);
					num = ((int)num2 * -1979917893) ^ 0x4D57C686;
					continue;
				case 22u:
					Form3.smethod_49((Form)(object)this, bool_0: false);
					num = (int)((num2 * 367497124) ^ 0x3FF3092);
					continue;
				case 21u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button5);
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button4);
					num = ((int)num2 * -296363588) ^ 0xD9838DF;
					continue;
				case 20u:
					Form3.smethod_32((Control)(object)NullButton, new Size(1, 1));
					num = (int)(num2 * 1547973249) ^ -984780891;
					continue;
				case 19u:
					Form3.smethod_38((Control)(object)button7, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form3.smethod_30((Control)(object)button7, new Point(174, 243));
					num = (int)((num2 * 708861503) ^ 0x24D618D7);
					continue;
				case 18u:
					num = ((int)num2 * -1117402848) ^ -787253211;
					continue;
				case 17u:
					Form3.smethod_14((Control)(object)button4, bool_0: false);
					num = ((int)num2 * -2080054905) ^ 0x1D576D3;
					continue;
				case 16u:
					num = (int)(num2 * 537242360) ^ -1528122279;
					continue;
				case 15u:
					num = (int)(num2 * 147653059) ^ -330868894;
					continue;
				case 14u:
					num = ((int)num2 * -1099219371) ^ 0x1D37E0C7;
					continue;
				case 13u:
					num = (int)(num2 * 1082173949) ^ -2120361183;
					continue;
				case 12u:
					Form3.smethod_31((Control)(object)button5, "button5");
					num = (int)(num2 * 1342890349) ^ -528327475;
					continue;
				case 11u:
					num = (int)((num2 * 1582796174) ^ 0x26A5C9B0);
					continue;
				case 10u:
					Form3.smethod_26((Control)(object)NullButton, Color.Transparent);
					num = ((int)num2 * -96089439) ^ 0x78B2F55D;
					continue;
				case 9u:
					Form3.smethod_34((ButtonBase)(object)button5, bool_0: true);
					num = (int)(num2 * 1203495049) ^ -872487660;
					continue;
				case 8u:
					Form3.smethod_38((Control)(object)button5, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 1095017476) ^ -973385543;
					continue;
				case 7u:
					num = (int)((num2 * 153929007) ^ 0x4F8A0F97);
					continue;
				case 6u:
					Form3.smethod_33((Control)(object)label1, 7);
					num = (int)((num2 * 591016794) ^ 0xCA13FB6);
					continue;
				case 5u:
					Form3.smethod_38((Control)(object)button4, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 801763832) ^ -1058742817;
					continue;
				case 4u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)NullButton);
					num = (int)((num2 * 1679446080) ^ 0x1F1D2AD2);
					continue;
				case 3u:
					num = (int)(num2 * 552493230) ^ -1402808847;
					continue;
				case 2u:
					num = (int)((num2 * 1037221669) ^ 0x11B6CA20);
					continue;
				case 1u:
					Form3.smethod_31((Control)(object)label1, "label1");
					num = ((int)num2 * -2106853471) ^ 0x4D67CFD2;
					continue;
				case 0u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button4), 0);
					num = (int)(num2 * 1592161970) ^ -1179743563;
					continue;
				case 115u:
					break;
				default:
					Form3.smethod_57((Control)(object)this);
					return;
				}
				break;
			}
		}
	}

	static bool smethod_0(Control control_0)
	{
		return control_0.Focus();
	}

	static void smethod_1(ErrorProvider errorProvider_0)
	{
		errorProvider_0.Clear();
	}

	static void smethod_2(Form form_0, bool bool_0)
	{
		form_0.set_TopMost(bool_0);
	}

	static void smethod_3(Form form_0, Form form_1)
	{
		form_0.set_Owner(form_1);
	}

	static void smethod_4(Control control_0)
	{
		control_0.Show();
	}

	static Point smethod_5(Form form_0)
	{
		return form_0.get_Location();
	}

	static int smethod_6(Control control_0)
	{
		return control_0.get_Width();
	}

	static int smethod_7(Control control_0)
	{
		return control_0.get_Width();
	}

	static int smethod_8(Control control_0)
	{
		return control_0.get_Height();
	}

	static int smethod_9(Control control_0)
	{
		return control_0.get_Height();
	}

	static void smethod_10(Form form_0, Point point_0)
	{
		form_0.set_Location(point_0);
	}

	static void smethod_11(Control control_0, bool bool_0)
	{
		control_0.set_Enabled(bool_0);
	}

	static Form smethod_12(Form form_0)
	{
		return form_0.get_Owner();
	}

	static Point smethod_13(Form form_0)
	{
		return form_0.get_Location();
	}

	static void smethod_14(Control control_0, bool bool_0)
	{
		control_0.set_Enabled(bool_0);
	}

	static void smethod_15(Control control_0, int int_0)
	{
		control_0.set_Height(int_0);
	}

	static void smethod_16(Form form_0)
	{
		form_0.Activate();
	}

	static void smethod_17(Timer timer_0)
	{
		timer_0.Start();
	}

	static void smethod_18(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Container smethod_19()
	{
		return new Container();
	}

	static Button smethod_20()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
	}

	static TextBox smethod_21()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TextBox();
	}

	static Label smethod_22()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Label();
	}

	static ErrorProvider smethod_23(IContainer icontainer_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new ErrorProvider(icontainer_0);
	}

	static void smethod_24(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.BeginInit();
	}

	static void smethod_25(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_26(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static FlatButtonAppearance smethod_27(ButtonBase buttonBase_0)
	{
		return buttonBase_0.get_FlatAppearance();
	}

	static void smethod_28(FlatButtonAppearance flatButtonAppearance_0, int int_0)
	{
		flatButtonAppearance_0.set_BorderSize(int_0);
	}

	static void smethod_29(ButtonBase buttonBase_0, FlatStyle flatStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		buttonBase_0.set_FlatStyle(flatStyle_0);
	}

	static void smethod_30(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_31(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_32(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_33(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_34(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_UseVisualStyleBackColor(bool_0);
	}

	static void smethod_35(Control control_0, string string_0)
	{
		control_0.set_Text(string_0);
	}

	static void smethod_36(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static Font smethod_37(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_38(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_39(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_TextChanged(eventHandler_0);
	}

	static void smethod_40(Control control_0, bool bool_0)
	{
		control_0.set_AutoSize(bool_0);
	}

	static void smethod_41(TextBox textBox_0, bool bool_0)
	{
		textBox_0.set_UseSystemPasswordChar(bool_0);
	}

	static void smethod_42(ErrorProvider errorProvider_0, ContainerControl containerControl_0)
	{
		errorProvider_0.set_ContainerControl(containerControl_0);
	}

	static void smethod_43(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_44(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_45(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static ControlCollection smethod_46(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_47(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_48(Form form_0, FormBorderStyle formBorderStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_FormBorderStyle(formBorderStyle_0);
	}

	static void smethod_49(Form form_0, bool bool_0)
	{
		form_0.set_MaximizeBox(bool_0);
	}

	static void smethod_50(Form form_0, bool bool_0)
	{
		form_0.set_MinimizeBox(bool_0);
	}

	static void smethod_51(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_52(Form form_0, bool bool_0)
	{
		form_0.set_ShowIcon(bool_0);
	}

	static void smethod_53(Form form_0, bool bool_0)
	{
		form_0.set_ShowInTaskbar(bool_0);
	}

	static void smethod_54(Form form_0, bool bool_0)
	{
		form_0.set_TopMost(bool_0);
	}

	static void smethod_55(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_56(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_57(Control control_0)
	{
		control_0.PerformLayout();
	}
}
