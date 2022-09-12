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
		Form val = default(Form);
		while (true)
		{
			int num = 553011794;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x32AC76A5u) % 9u)
				{
				case 7u:
				{
					Form4 form = new Form4();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					num = ((int)num2 * -835486746) ^ 0x4DDC754C;
					continue;
				}
				case 6u:
					num = (int)((num2 * 1264543466) ^ 0x716D05BD);
					continue;
				case 5u:
					Form3.smethod_4((Control)(object)val);
					Form3.smethod_10(val, new Point(Form3.smethod_5((Form)(object)this).X + (Form3.smethod_6((Control)(object)this) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_5((Form)(object)this).Y + (Form3.smethod_8((Control)(object)this) - Form3.smethod_9((Control)(object)val)) / 2 + 70));
					num = ((int)num2 * -411054264) ^ -490237832;
					continue;
				case 4u:
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = ((int)num2 * -377013433) ^ -336879534;
					continue;
				case 2u:
					num = ((int)num2 * -453619680) ^ -1602152763;
					continue;
				case 1u:
					Form3.smethod_0((Control)(object)NullButton);
					num = (int)(num2 * 1837172092) ^ -1641750433;
					continue;
				case 0u:
					Form3.smethod_1(errorProvider1);
					num = (int)((num2 * 1778676711) ^ 0x1F01FFCF);
					continue;
				default:
					return;
				case 8u:
					break;
				case 3u:
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
			int num = -1642834938;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x998CA82Bu) % 7u)
				{
				case 6u:
				{
					Form3.smethod_0((Control)(object)NullButton);
					Form2 form = new Form2();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					Form3.smethod_4((Control)(object)val);
					num = ((int)num2 * -1725364846) ^ 0x2681088F;
					continue;
				}
				case 4u:
					Form3.smethod_10(val, new Point(Form3.smethod_13(Form3.smethod_12((Form)(object)this)).X + (Form3.smethod_7((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_13(Form3.smethod_12((Form)(object)this)).Y + (Form3.smethod_9((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_9((Control)(object)val)) / 2));
					num = ((int)num2 * -1555445751) ^ -432037271;
					continue;
				case 3u:
					num = (int)(num2 * 1980557429) ^ -1637151416;
					continue;
				case 1u:
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = (int)(num2 * 1722804752) ^ -512029257;
					continue;
				case 0u:
					num = (int)(num2 * 1219627448) ^ -947262553;
					continue;
				default:
					return;
				case 5u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	public void Button_Continue()
	{
		Form3.smethod_14((Control)(object)button5, bool_0: true);
		while (true)
		{
			int num = 269700952;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5C789E63u) % 3u)
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
				num = ((int)num2 * -1723489683) ^ 0x4CFEFDFD;
			}
		}
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = Form3.smethod_8((Control)(object)this) - 1;
			Form3.smethod_15((Control)(object)this, num);
			int num2 = 1976117053;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x272246C2u) % 8u)
				{
				case 7u:
				{
					int num4;
					int num5;
					if (num > 1)
					{
						num4 = 1629559952;
						num5 = 1629559952;
					}
					else
					{
						num4 = 1991428052;
						num5 = 1991428052;
					}
					num2 = num4 ^ (int)(num3 * 360973917);
					continue;
				}
				case 6u:
					num2 = ((int)num3 * -1752345172) ^ -1894711471;
					continue;
				case 5u:
					Form3.smethod_16(Form3.smethod_12((Form)(object)this));
					num2 = (int)((num3 * 2044798374) ^ 0x31D89C36);
					continue;
				case 4u:
					num2 = 2003537715;
					continue;
				case 2u:
					Form3.smethod_17((Form3.smethod_12((Form)(object)this) as Form1).timer1);
					num2 = ((int)num3 * -1259520965) ^ 0x46AB12C2;
					continue;
				case 1u:
					num2 = 1224104018;
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
	}

	public void AchivUnlock()
	{
		Form3.smethod_14((Control)(object)button7, bool_0: true);
	}

	private void Button7_Click(object sender, EventArgs e)
	{
		Form3.smethod_0((Control)(object)NullButton);
		Form3.smethod_14((Control)(object)button7, bool_0: false);
		while (true)
		{
			int num = -1751379585;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xADAE9AF2u) % 3u)
				{
				case 1u:
					goto IL_001a;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_001a:
				num = (int)(num2 * 2013580577) ^ -679196686;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		while (true)
		{
			int num = -168453856;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xBB69544Eu) % 7u)
				{
				case 5u:
					Form3.smethod_18((IDisposable)components);
					num = ((int)num2 * -1436670190) ^ -857019716;
					continue;
				case 4u:
					if (disposing)
					{
						num = ((int)num2 * -1244221932) ^ -475144420;
						continue;
					}
					goto IL_0041;
				case 3u:
					num = ((int)num2 * -956906897) ^ 0x5D707A27;
					continue;
				case 2u:
					if (components != null)
					{
						num = -901463397;
						num3 = -901463397;
						continue;
					}
					goto IL_0041;
				case 1u:
					num = (int)((num2 * 1819818658) ^ 0xE9F9D26);
					continue;
				case 0u:
					break;
				default:
					{
						((Form)this).Dispose(disposing);
						return;
					}
					IL_0041:
					num = -534963667;
					num3 = -534963667;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		while (true)
		{
			int num = 2006486919;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8B2FBCAu) % 133u)
				{
				case 132u:
					Form3.smethod_33((Control)(object)button5, 5);
					num = ((int)num2 * -1675722218) ^ -1688122753;
					continue;
				case 131u:
					num = (int)((num2 * 1613208189) ^ 0x3C8C0174);
					continue;
				case 130u:
					num = ((int)num2 * -173941132) ^ -16568846;
					continue;
				case 129u:
					Form3.smethod_33((Control)(object)textBox1, 7);
					num = ((int)num2 * -1065780506) ^ -1143766376;
					continue;
				case 128u:
					num = ((int)num2 * -1149320835) ^ -1498264723;
					continue;
				case 127u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox1);
					num = ((int)num2 * -2020566332) ^ 0x388719DA;
					continue;
				case 126u:
					Form3.smethod_30((Control)(object)textBox2, new Point(174, 26));
					Form3.smethod_31((Control)(object)textBox2, "textBox2");
					num = (int)(num2 * 1440774543) ^ -684358820;
					continue;
				case 125u:
					num = (int)(num2 * 1684576532) ^ -10713144;
					continue;
				case 124u:
					Form3.smethod_36((Control)(object)button2, (EventHandler)Button2_Click);
					num = (int)((num2 * 148550700) ^ 0x30909097);
					continue;
				case 123u:
					Form3.smethod_35((Control)(object)button2, "Регистрация");
					num = ((int)num2 * -1914272988) ^ 0x728EBEA;
					continue;
				case 122u:
					Form3.smethod_14((Control)(object)button5, bool_0: false);
					num = (int)((num2 * 114698138) ^ 0x51B2CDD2);
					continue;
				case 121u:
					Form3.smethod_39((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -718683019) ^ 0x451D726D;
					continue;
				case 120u:
					num = (int)((num2 * 959413158) ^ 0x53244438);
					continue;
				case 119u:
					num = (int)((num2 * 1654524970) ^ 0x45A77D35);
					continue;
				case 118u:
					num = (int)((num2 * 85559498) ^ 0x17CE692B);
					continue;
				case 117u:
					Form3.smethod_33((Control)(object)button1, 0);
					Form3.smethod_35((Control)(object)button1, "Вход");
					num = ((int)num2 * -1919807871) ^ -1863367064;
					continue;
				case 116u:
					button5 = Form3.smethod_20();
					button7 = Form3.smethod_20();
					textBox1 = Form3.smethod_21();
					num = ((int)num2 * -73943586) ^ 0x14252C59;
					continue;
				case 115u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)NullButton), 0);
					num = (int)((num2 * 1198524373) ^ 0x7733EAC9);
					continue;
				case 114u:
					textBox2 = Form3.smethod_21();
					num = ((int)num2 * -1658802259) ^ 0x35EB4661;
					continue;
				case 113u:
					Form3.smethod_43((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)(num2 * 2142079056) ^ -534137862;
					continue;
				case 112u:
					Form3.smethod_30((Control)(object)NullButton, new Point(-1, -1));
					num = ((int)num2 * -1698390228) ^ -943786237;
					continue;
				case 111u:
					num = ((int)num2 * -1218821224) ^ 0x2560DD3D;
					continue;
				case 110u:
					num = (int)((num2 * 867988580) ^ 0x5C994358);
					continue;
				case 109u:
					Form3.smethod_50((Form)(object)this, bool_0: false);
					num = (int)((num2 * 1139516077) ^ 0x3CEE83DB);
					continue;
				case 108u:
					Form3.smethod_32((Control)(object)textBox1, new Size(140, 20));
					num = ((int)num2 * -681166361) ^ 0x4044D078;
					continue;
				case 107u:
					num = (int)(num2 * 1544775751) ^ -139919587;
					continue;
				case 106u:
					Form3.smethod_31((Control)(object)button2, "button2");
					num = (int)(num2 * 1299760165) ^ -321075297;
					continue;
				case 104u:
					Form3.smethod_42(errorProvider1, (ContainerControl)(object)this);
					num = (int)(num2 * 1465204827) ^ -424694241;
					continue;
				case 103u:
					Form3.smethod_55((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -2104018978) ^ 0x231D2377;
					continue;
				case 102u:
					Form3.smethod_31((Control)(object)button4, "button4");
					num = (int)((num2 * 42972631) ^ 0x3926A10);
					continue;
				case 101u:
					Form3.smethod_31((Control)(object)label1, "label1");
					num = ((int)num2 * -2051268137) ^ 0x2593D830;
					continue;
				case 100u:
					num = ((int)num2 * -116928508) ^ 0x183474F4;
					continue;
				case 99u:
					Form3.smethod_29((ButtonBase)(object)NullButton, (FlatStyle)0);
					num = ((int)num2 * -322260833) ^ 0x200AC131;
					continue;
				case 98u:
					Form3.smethod_32((Control)(object)button7, new Size(140, 50));
					num = ((int)num2 * -1700229215) ^ -63706080;
					continue;
				case 97u:
					num = ((int)num2 * -1819975371) ^ 0x67244863;
					continue;
				case 96u:
					Form3.smethod_44((ContainerControl)(object)this, (AutoScaleMode)1);
					Form3.smethod_26((Control)(object)this, Color.White);
					Form3.smethod_45((Form)(object)this, new Size(486, 296));
					num = ((int)num2 * -1401130944) ^ -302533394;
					continue;
				case 95u:
					Form3.smethod_35((Control)(object)button4, "Начало игры");
					num = (int)((num2 * 753878544) ^ 0x717138FD);
					continue;
				case 94u:
					Form3.smethod_48((Form)(object)this, (FormBorderStyle)0);
					Form3.smethod_49((Form)(object)this, bool_0: false);
					num = ((int)num2 * -406648977) ^ 0x3AB91650;
					continue;
				case 93u:
					Form3.smethod_14((Control)(object)button4, bool_0: false);
					num = ((int)num2 * -1501051230) ^ 0x172540F9;
					continue;
				case 92u:
					num = ((int)num2 * -1317526477) ^ -668838382;
					continue;
				case 91u:
					Form3.smethod_32((Control)(object)button2, new Size(85, 21));
					num = ((int)num2 * -1353581983) ^ 0x6753C5D1;
					continue;
				case 90u:
					Form3.smethod_30((Control)(object)button2, new Point(174, 49));
					num = (int)(num2 * 932608255) ^ -370585508;
					continue;
				case 89u:
					num = (int)(num2 * 1702638140) ^ -7120910;
					continue;
				case 88u:
					num = (int)((num2 * 1521843716) ^ 0x7F3BC268);
					continue;
				case 87u:
					num = ((int)num2 * -939609002) ^ -1123645438;
					continue;
				case 86u:
					num = (int)((num2 * 101824713) ^ 0x34C15DA);
					continue;
				case 85u:
					Form3.smethod_30((Control)(object)textBox1, new Point(174, 2));
					num = (int)(num2 * 1301848244) ^ -719293775;
					continue;
				case 84u:
					Form3.smethod_30((Control)(object)button5, new Point(174, 190));
					Form3.smethod_31((Control)(object)button5, "button5");
					num = ((int)num2 * -1615018838) ^ 0x175EC099;
					continue;
				case 83u:
					Form3.smethod_34((ButtonBase)(object)button5, bool_0: true);
					num = (int)(num2 * 1301720181) ^ -1991773944;
					continue;
				case 82u:
					Form3.smethod_56((Control)(object)this, bool_0: false);
					num = ((int)num2 * -744530905) ^ 0x3F0893E8;
					continue;
				case 81u:
					Form3.smethod_41(textBox2, bool_0: true);
					Form3.smethod_39((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = (int)(num2 * 45551722) ^ -956738513;
					continue;
				case 80u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button5), 0);
					Form3.smethod_29((ButtonBase)(object)button5, (FlatStyle)0);
					Form3.smethod_38((Control)(object)button5, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 1770170334) ^ 0x5B69EC68);
					continue;
				case 79u:
					num = ((int)num2 * -1521361368) ^ -104425666;
					continue;
				case 78u:
					Form3.smethod_32((Control)(object)label1, new Size(207, 76));
					Form3.smethod_33((Control)(object)label1, 7);
					num = ((int)num2 * -272888498) ^ 0x4BEF6221;
					continue;
				case 77u:
					Form3.smethod_36((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)(num2 * 333625187) ^ -1861739981;
					continue;
				case 76u:
					Form3.smethod_57((Control)(object)this);
					num = ((int)num2 * -1750329196) ^ 0x1800D0DB;
					continue;
				case 75u:
					Form3.smethod_52((Form)(object)this, bool_0: false);
					num = ((int)num2 * -794683701) ^ -1783576545;
					continue;
				case 74u:
					Form3.smethod_33((Control)(object)button4, 4);
					num = ((int)num2 * -1508040525) ^ -850020976;
					continue;
				case 73u:
					components = Form3.smethod_19();
					num = ((int)num2 * -1860640039) ^ -516838663;
					continue;
				case 72u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -249510700) ^ -1062472453;
					continue;
				case 71u:
					label1 = Form3.smethod_22();
					num = (int)((num2 * 1759498122) ^ 0x339FA221);
					continue;
				case 70u:
					num = (int)(num2 * 888561396) ^ -241557564;
					continue;
				case 69u:
					Form3.smethod_32((Control)(object)button1, new Size(49, 21));
					num = (int)((num2 * 10203967) ^ 0x53A55214);
					continue;
				case 68u:
					Form3.smethod_32((Control)(object)button4, new Size(140, 50));
					num = (int)((num2 * 1244804433) ^ 0x2C238C92);
					continue;
				case 67u:
					Form3.smethod_26((Control)(object)NullButton, Color.Transparent);
					num = ((int)num2 * -852128426) ^ -759481151;
					continue;
				case 66u:
					Form3.smethod_33((Control)(object)button7, 6);
					num = (int)((num2 * 1855880887) ^ 0x114176A9);
					continue;
				case 65u:
					Form3.smethod_24((ISupportInitialize)errorProvider1);
					Form3.smethod_25((Control)(object)this);
					num = (int)((num2 * 1090817877) ^ 0x22655EDF);
					continue;
				case 64u:
					num = ((int)num2 * -853047548) ^ 0x773FF5E;
					continue;
				case 63u:
					num = ((int)num2 * -679048103) ^ 0x77202B8B;
					continue;
				case 62u:
					Form3.smethod_34((ButtonBase)(object)button2, bool_0: true);
					num = (int)(num2 * 808244938) ^ -242884133;
					continue;
				case 61u:
					Form3.smethod_30((Control)(object)label1, new Point(140, 70));
					num = (int)(num2 * 365269506) ^ -227995216;
					continue;
				case 60u:
					num = (int)((num2 * 495510427) ^ 0x697C8676);
					continue;
				case 59u:
					Form3.smethod_29((ButtonBase)(object)button4, (FlatStyle)0);
					num = (int)((num2 * 1100178882) ^ 0x295144E6);
					continue;
				case 58u:
					num = (int)((num2 * 621169456) ^ 0x7B565C3E);
					continue;
				case 57u:
					Form3.smethod_35((Control)(object)button7, "Достижения");
					num = ((int)num2 * -2146970343) ^ 0x1A32DD45;
					continue;
				case 56u:
					num = (int)((num2 * 159346676) ^ 0x2FE11C26);
					continue;
				case 55u:
					Form3.smethod_31((Control)(object)button7, "button7");
					num = (int)(num2 * 1681852825) ^ -2098709032;
					continue;
				case 54u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button1);
					num = (int)(num2 * 1137354092) ^ -1815640108;
					continue;
				case 53u:
					Form3.smethod_51((Control)(object)this, "Form3");
					num = (int)((num2 * 783168118) ^ 0x3857AAD4);
					continue;
				case 52u:
					Form3.smethod_31((Control)(object)button1, "button1");
					num = ((int)num2 * -523066086) ^ -434490011;
					continue;
				case 51u:
					Form3.smethod_35((Control)(object)button5, "Продолжить");
					num = (int)((num2 * 1924545198) ^ 0x65919073);
					continue;
				case 50u:
					num = (int)((num2 * 2012213802) ^ 0x4A2A0CE9);
					continue;
				case 49u:
					Form3.smethod_34((ButtonBase)(object)NullButton, bool_0: false);
					num = ((int)num2 * -1084406318) ^ -206876554;
					continue;
				case 48u:
					Form3.smethod_30((Control)(object)button1, new Point(265, 49));
					num = (int)((num2 * 1546095576) ^ 0x2AB0D616);
					continue;
				case 47u:
					Form3.smethod_26((Control)(object)label1, Color.Transparent);
					num = ((int)num2 * -981901276) ^ 0x1548B913;
					continue;
				case 46u:
					num = ((int)num2 * -1920021825) ^ -778510240;
					continue;
				case 45u:
					num = ((int)num2 * -1457305277) ^ -1642024536;
					continue;
				case 44u:
					num = (int)((num2 * 507961075) ^ 0x38D30A9);
					continue;
				case 43u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button2);
					num = (int)((num2 * 31973706) ^ 0x5D80D00C);
					continue;
				case 42u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)NullButton);
					num = ((int)num2 * -1047798449) ^ -945347875;
					continue;
				case 41u:
					num = ((int)num2 * -1784373936) ^ -281399667;
					continue;
				case 39u:
					num = ((int)num2 * -1743282909) ^ -164347603;
					continue;
				case 38u:
					Form3.smethod_32((Control)(object)textBox2, new Size(140, 20));
					num = (int)((num2 * 723734654) ^ 0x3EC424AC);
					continue;
				case 37u:
					Form3.smethod_34((ButtonBase)(object)button4, bool_0: true);
					Form3.smethod_36((Control)(object)button4, (EventHandler)Button4_Click);
					num = (int)((num2 * 1143602207) ^ 0x23D7EC4D);
					continue;
				case 36u:
					num = (int)((num2 * 1464359430) ^ 0x64B4D6DC);
					continue;
				case 35u:
					num = (int)((num2 * 59422196) ^ 0x62DC0E6D);
					continue;
				case 34u:
					Form3.smethod_33((Control)(object)textBox2, 8);
					num = (int)(num2 * 1365267570) ^ -1359285813;
					continue;
				case 33u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button7);
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button5);
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button4);
					num = ((int)num2 * -14887057) ^ 0xDB635B6;
					continue;
				case 32u:
					num = (int)(num2 * 111009526) ^ -24789193;
					continue;
				case 31u:
					errorProvider1 = Form3.smethod_23(components);
					num = ((int)num2 * -601759937) ^ 0xF5C66E6;
					continue;
				case 30u:
					num = ((int)num2 * -347869683) ^ -525589190;
					continue;
				case 29u:
					Form3.smethod_36((Control)(object)button5, (EventHandler)Button5_Click);
					num = ((int)num2 * -1820193101) ^ -315878297;
					continue;
				case 28u:
					num = ((int)num2 * -452488199) ^ -359746605;
					continue;
				case 27u:
					num = ((int)num2 * -609769335) ^ -1543986662;
					continue;
				case 26u:
					num = ((int)num2 * -872885090) ^ 0x4C355CA7;
					continue;
				case 25u:
					Form3.smethod_34((ButtonBase)(object)button7, bool_0: true);
					num = ((int)num2 * -740981090) ^ 0x24F66EBA;
					continue;
				case 24u:
					Form3.smethod_38((Control)(object)label1, Form3.smethod_37("Mistral", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -75218241) ^ -1958212656;
					continue;
				case 23u:
					num = (int)(num2 * 1075903159) ^ -1576022529;
					continue;
				case 22u:
					Form3.smethod_30((Control)(object)button4, new Point(174, 137));
					num = ((int)num2 * -2108766851) ^ 0x2A5B05C9;
					continue;
				case 21u:
					num = ((int)num2 * -2143971437) ^ -791999441;
					continue;
				case 20u:
					Form3.smethod_30((Control)(object)button7, new Point(174, 243));
					num = ((int)num2 * -529451895) ^ 0x79A1FF86;
					continue;
				case 19u:
					Form3.smethod_53((Form)(object)this, bool_0: false);
					num = (int)(num2 * 558201700) ^ -2013802799;
					continue;
				case 18u:
					Form3.smethod_31((Control)(object)textBox1, "textBox1");
					num = ((int)num2 * -580158528) ^ -482946484;
					continue;
				case 17u:
					Form3.smethod_38((Control)(object)button7, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1705257479) ^ 0x3F3AD39B;
					continue;
				case 16u:
					Form3.smethod_36((Control)(object)button7, (EventHandler)Button7_Click);
					num = (int)((num2 * 1852844236) ^ 0x73C4182D);
					continue;
				case 15u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button4), 0);
					num = (int)((num2 * 951706280) ^ 0x669868CF);
					continue;
				case 14u:
					Form3.smethod_38((Control)(object)button4, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 1928571669) ^ 0x5C637451);
					continue;
				case 13u:
					Form3.smethod_29((ButtonBase)(object)button7, (FlatStyle)0);
					num = (int)(num2 * 1826849372) ^ -1634799283;
					continue;
				case 12u:
					Form3.smethod_31((Control)(object)NullButton, "NullButton");
					num = ((int)num2 * -373414617) ^ -1921765610;
					continue;
				case 11u:
					Form3.smethod_33((Control)(object)button2, 1);
					num = ((int)num2 * -35692727) ^ 0x369D2265;
					continue;
				case 10u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox2);
					num = (int)(num2 * 622337074) ^ -1229034756;
					continue;
				case 9u:
					Form3.smethod_40((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -340749690) ^ -1511449725;
					continue;
				case 8u:
					Form3.smethod_35((Control)(object)label1, "QUARTO");
					num = ((int)num2 * -742437069) ^ -1818483747;
					continue;
				case 7u:
					Form3.smethod_32((Control)(object)NullButton, new Size(1, 1));
					Form3.smethod_33((Control)(object)NullButton, 3);
					num = ((int)num2 * -1370019656) ^ -273564234;
					continue;
				case 6u:
					Form3.smethod_32((Control)(object)button5, new Size(140, 50));
					num = ((int)num2 * -1836916928) ^ -2107454003;
					continue;
				case 5u:
					num = (int)((num2 * 97859110) ^ 0x7DDC3FB1);
					continue;
				case 4u:
					NullButton = Form3.smethod_20();
					button1 = Form3.smethod_20();
					button2 = Form3.smethod_20();
					button4 = Form3.smethod_20();
					num = (int)(num2 * 1697416558) ^ -1794022266;
					continue;
				case 3u:
					Form3.smethod_34((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -1043252292) ^ 0x1343515C;
					continue;
				case 2u:
					num = ((int)num2 * -777816581) ^ 0x59805FD2;
					continue;
				case 1u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button7), 0);
					num = ((int)num2 * -1384033660) ^ 0x37B9F7;
					continue;
				case 0u:
					Form3.smethod_54((Form)(object)this, bool_0: true);
					num = ((int)num2 * -1851464702) ^ 0x89B7DE5;
					continue;
				default:
					return;
				case 40u:
					break;
				case 105u:
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
