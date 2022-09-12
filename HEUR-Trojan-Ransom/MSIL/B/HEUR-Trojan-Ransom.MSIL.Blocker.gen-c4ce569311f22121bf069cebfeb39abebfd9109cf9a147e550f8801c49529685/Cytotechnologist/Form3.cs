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
			int num = 742807455;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8D68ACu) % 10u)
				{
				case 9u:
					Form3.smethod_4((Control)(object)val);
					num = ((int)num2 * -1781553393) ^ -1560872269;
					continue;
				case 7u:
				{
					Form4 form = new Form4();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					num = ((int)num2 * -1831122829) ^ -1237916150;
					continue;
				}
				case 5u:
					Form3.smethod_10(val, new Point(Form3.smethod_5((Form)(object)this).X + (Form3.smethod_6((Control)(object)this) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_5((Form)(object)this).Y + (Form3.smethod_8((Control)(object)this) - Form3.smethod_9((Control)(object)val)) / 2 + 70));
					num = (int)(num2 * 1431106097) ^ -1790873819;
					continue;
				case 4u:
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = ((int)num2 * -1526830946) ^ 0x18A71CB1;
					continue;
				case 3u:
					num = (int)((num2 * 1365653114) ^ 0x911BF6);
					continue;
				case 2u:
					num = ((int)num2 * -2020791528) ^ -877928494;
					continue;
				case 1u:
					Form3.smethod_1(errorProvider1);
					num = (int)((num2 * 2047938583) ^ 0x5D14EA3A);
					continue;
				case 0u:
					num = (int)(num2 * 1011261340) ^ -1956306513;
					continue;
				default:
					return;
				case 6u:
					break;
				case 8u:
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
			int num = 1897486644;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1E944BF5u) % 8u)
				{
				case 7u:
				{
					Form2 form = new Form2();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					num = ((int)num2 * -1533254476) ^ -1123648683;
					continue;
				}
				case 6u:
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = (int)((num2 * 442005701) ^ 0xF187740);
					continue;
				case 4u:
					Form3.smethod_4((Control)(object)val);
					num = (int)(num2 * 1573779534) ^ -1485176723;
					continue;
				case 2u:
					num = (int)((num2 * 1337661097) ^ 0x75071921);
					continue;
				case 1u:
					Form3.smethod_0((Control)(object)NullButton);
					num = (int)(num2 * 1868953791) ^ -536314867;
					continue;
				case 0u:
					Form3.smethod_10(val, new Point(Form3.smethod_13(Form3.smethod_12((Form)(object)this)).X + (Form3.smethod_7((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_13(Form3.smethod_12((Form)(object)this)).Y + (Form3.smethod_9((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_9((Control)(object)val)) / 2));
					num = ((int)num2 * -179339843) ^ 0x7776747;
					continue;
				default:
					return;
				case 5u:
					break;
				case 3u:
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
		int num3 = default(int);
		while (true)
		{
			int num = -794901027;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD5521E28u) % 10u)
				{
				case 8u:
					num = ((int)num2 * -350261289) ^ 0x1EC6A13B;
					continue;
				case 7u:
					Form3.smethod_17((Form3.smethod_12((Form)(object)this) as Form1).timer1);
					num = ((int)num2 * -1690677936) ^ 0x34E42A7E;
					continue;
				case 6u:
					num = ((int)num2 * -636499913) ^ 0x1D71222A;
					continue;
				case 5u:
					num = -1305478632;
					continue;
				case 4u:
					num3 = Form3.smethod_8((Control)(object)this) - 1;
					Form3.smethod_15((Control)(object)this, num3);
					num = -644623247;
					continue;
				case 3u:
					num = ((int)num2 * -708357176) ^ 0x75E0BC70;
					continue;
				case 2u:
					Form3.smethod_16(Form3.smethod_12((Form)(object)this));
					num = (int)(num2 * 265492226) ^ -578687978;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (num3 > 1)
					{
						num4 = -94736706;
						num5 = -94736706;
					}
					else
					{
						num4 = -1287836191;
						num5 = -1287836191;
					}
					num = num4 ^ (int)(num2 * 1690466247);
					continue;
				}
				default:
					return;
				case 9u:
					break;
				case 0u:
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
		while (true)
		{
			int num = 1523965635;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3F3743BCu) % 5u)
				{
				case 4u:
					Form3.smethod_14((Control)(object)button7, bool_0: false);
					num = ((int)num2 * -1707266563) ^ 0x3221DAC0;
					continue;
				case 1u:
					Form3.smethod_0((Control)(object)NullButton);
					num = (int)((num2 * 237319187) ^ 0x3CF6AAE5);
					continue;
				case 0u:
					num = (int)(num2 * 1043916113) ^ -688904136;
					continue;
				default:
					return;
				case 2u:
					break;
				case 3u:
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
		goto IL_0016;
		IL_0016:
		int num = 662289953;
		goto IL_0053;
		IL_0053:
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x1128F8A6u) % 6u)
			{
			case 5u:
				break;
			case 3u:
				num = (int)(num2 * 1374081202) ^ -1047331086;
				continue;
			case 2u:
				num = ((int)num2 * -1848633343) ^ 0x2AB589C;
				continue;
			case 0u:
				Form3.smethod_18((IDisposable)components);
				num = ((int)num2 * -1230121192) ^ -1368478153;
				continue;
			case 1u:
				goto IL_007c;
			default:
				((Form)this).Dispose(disposing);
				return;
			}
			break;
			IL_007c:
			if (components != null)
			{
				num = 1828388278;
				num3 = 1828388278;
				continue;
			}
			goto IL_0009;
		}
		goto IL_0016;
		IL_0009:
		num = 137031552;
		num3 = 137031552;
		goto IL_0053;
	}

	private void InitializeComponent()
	{
		while (true)
		{
			int num = 1265212170;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1984A85Eu) % 118u)
				{
				case 117u:
					Form3.smethod_26((Control)(object)label1, Color.Transparent);
					num = ((int)num2 * -1128684974) ^ 0x7692B285;
					continue;
				case 116u:
					Form3.smethod_14((Control)(object)button4, bool_0: false);
					num = (int)(num2 * 182027708) ^ -419674838;
					continue;
				case 115u:
					Form3.smethod_35((Control)(object)button7, "Достижения");
					num = (int)((num2 * 1629048978) ^ 0x7699B0B7);
					continue;
				case 114u:
					num = (int)(num2 * 807095463) ^ -300410233;
					continue;
				case 113u:
					Form3.smethod_36((Control)(object)button5, (EventHandler)Button5_Click);
					num = (int)((num2 * 1395008995) ^ 0x77887F04);
					continue;
				case 112u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button4);
					num = (int)(num2 * 496948753) ^ -115989732;
					continue;
				case 111u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button7);
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button5);
					num = ((int)num2 * -1616592961) ^ -862709091;
					continue;
				case 110u:
					Form3.smethod_36((Control)(object)button2, (EventHandler)Button2_Click);
					num = (int)(num2 * 943488626) ^ -85339144;
					continue;
				case 109u:
					num = ((int)num2 * -224100492) ^ 0x31C91EDF;
					continue;
				case 108u:
					Form3.smethod_29((ButtonBase)(object)button7, (FlatStyle)0);
					num = (int)(num2 * 2118679122) ^ -1743547222;
					continue;
				case 107u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button4), 0);
					num = ((int)num2 * -1030217481) ^ -371634685;
					continue;
				case 106u:
					num = (int)((num2 * 1543950434) ^ 0x28D6962E);
					continue;
				case 105u:
					Form3.smethod_30((Control)(object)textBox1, new Point(174, 2));
					num = (int)(num2 * 1685981) ^ -1163749113;
					continue;
				case 104u:
					Form3.smethod_31((Control)(object)button1, "button1");
					num = ((int)num2 * -824740341) ^ -2130966178;
					continue;
				case 103u:
					Form3.smethod_30((Control)(object)button7, new Point(174, 243));
					Form3.smethod_31((Control)(object)button7, "button7");
					Form3.smethod_32((Control)(object)button7, new Size(140, 50));
					num = ((int)num2 * -1766067188) ^ 0xD1240F2;
					continue;
				case 102u:
					Form3.smethod_31((Control)(object)NullButton, "NullButton");
					num = ((int)num2 * -409806882) ^ 0x60280DB;
					continue;
				case 101u:
					Form3.smethod_36((Control)(object)button7, (EventHandler)Button7_Click);
					num = (int)((num2 * 496680290) ^ 0x49ACFB6F);
					continue;
				case 100u:
					num = ((int)num2 * -1608174825) ^ 0x3CEDD065;
					continue;
				case 99u:
					Form3.smethod_32((Control)(object)NullButton, new Size(1, 1));
					num = (int)(num2 * 614059189) ^ -972307306;
					continue;
				case 98u:
					Form3.smethod_32((Control)(object)textBox2, new Size(140, 20));
					num = ((int)num2 * -783441019) ^ -1197215181;
					continue;
				case 97u:
					num = ((int)num2 * -221127511) ^ 0x719996EA;
					continue;
				case 96u:
					Form3.smethod_29((ButtonBase)(object)button5, (FlatStyle)0);
					num = (int)(num2 * 1188362925) ^ -1399337945;
					continue;
				case 95u:
					Form3.smethod_51((Control)(object)this, "Form3");
					Form3.smethod_52((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1941971852) ^ -2042814304;
					continue;
				case 94u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox2);
					num = ((int)num2 * -750105402) ^ 0x796646F5;
					continue;
				case 93u:
					Form3.smethod_56((Control)(object)this, bool_0: false);
					num = ((int)num2 * -303390950) ^ -1672550715;
					continue;
				case 92u:
					Form3.smethod_26((Control)(object)this, Color.White);
					num = (int)(num2 * 1588212118) ^ -1738446706;
					continue;
				case 91u:
					errorProvider1 = Form3.smethod_23(components);
					Form3.smethod_24((ISupportInitialize)errorProvider1);
					num = (int)((num2 * 90985115) ^ 0x72475EF6);
					continue;
				case 90u:
					num = (int)((num2 * 146587966) ^ 0x5D3EDA9A);
					continue;
				case 89u:
					num = (int)((num2 * 1110189002) ^ 0x3D215460);
					continue;
				case 88u:
					Form3.smethod_33((Control)(object)button2, 1);
					num = (int)(num2 * 259391668) ^ -818168111;
					continue;
				case 87u:
					Form3.smethod_33((Control)(object)button1, 0);
					num = (int)((num2 * 611819451) ^ 0x1AD03B4);
					continue;
				case 86u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)NullButton);
					num = (int)((num2 * 687052740) ^ 0x148E9C9E);
					continue;
				case 85u:
					Form3.smethod_48((Form)(object)this, (FormBorderStyle)0);
					num = ((int)num2 * -46542496) ^ -524092824;
					continue;
				case 84u:
					Form3.smethod_54((Form)(object)this, bool_0: true);
					num = ((int)num2 * -1184000892) ^ 0x32F2728E;
					continue;
				case 83u:
					num = (int)((num2 * 722876183) ^ 0x78729A23);
					continue;
				case 82u:
					Form3.smethod_55((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -664577299) ^ 0x3C5A8985;
					continue;
				case 81u:
					Form3.smethod_30((Control)(object)button1, new Point(265, 49));
					num = ((int)num2 * -2136002876) ^ -2118551022;
					continue;
				case 80u:
					Form3.smethod_35((Control)(object)button1, "Вход");
					num = ((int)num2 * -860932934) ^ 0x4D9C6DAE;
					continue;
				case 79u:
					Form3.smethod_35((Control)(object)button2, "Регистрация");
					Form3.smethod_34((ButtonBase)(object)button2, bool_0: true);
					num = ((int)num2 * -459582106) ^ 0x1CC28239;
					continue;
				case 78u:
					num = ((int)num2 * -1448230205) ^ 0x23B673FC;
					continue;
				case 77u:
					Form3.smethod_32((Control)(object)button1, new Size(49, 21));
					num = (int)(num2 * 2001052773) ^ -1026477428;
					continue;
				case 76u:
					Form3.smethod_29((ButtonBase)(object)button4, (FlatStyle)0);
					num = (int)((num2 * 1601315663) ^ 0x58D432D4);
					continue;
				case 75u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button7), 0);
					num = (int)((num2 * 1319814711) ^ 0x26F59527);
					continue;
				case 74u:
					Form3.smethod_31((Control)(object)button4, "button4");
					num = (int)((num2 * 2057534126) ^ 0x1788ABDF);
					continue;
				case 73u:
					Form3.smethod_33((Control)(object)NullButton, 3);
					num = (int)((num2 * 882547541) ^ 0x1999EE57);
					continue;
				case 72u:
					Form3.smethod_31((Control)(object)textBox1, "textBox1");
					Form3.smethod_32((Control)(object)textBox1, new Size(140, 20));
					num = (int)(num2 * 276304688) ^ -177746816;
					continue;
				case 71u:
					Form3.smethod_38((Control)(object)button5, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 1017081505) ^ -1299417323;
					continue;
				case 70u:
					Form3.smethod_35((Control)(object)button5, "Продолжить");
					num = ((int)num2 * -2058874153) ^ -1164649229;
					continue;
				case 68u:
					Form3.smethod_39((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = (int)(num2 * 455576772) ^ -1845720042;
					continue;
				case 67u:
					Form3.smethod_39((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -1863841052) ^ -2006354139;
					continue;
				case 66u:
					Form3.smethod_33((Control)(object)button5, 5);
					num = ((int)num2 * -1008881530) ^ 0x118B2E06;
					continue;
				case 65u:
					button5 = Form3.smethod_20();
					num = (int)((num2 * 1767286094) ^ 0x1F0DE319);
					continue;
				case 64u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button2);
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button1);
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -335870142) ^ -1279059356;
					continue;
				case 63u:
					num = (int)((num2 * 2103444026) ^ 0x1EC4B773);
					continue;
				case 62u:
					num = ((int)num2 * -726131475) ^ 0xDDF252F;
					continue;
				case 61u:
					Form3.smethod_31((Control)(object)label1, "label1");
					num = ((int)num2 * -1979736119) ^ -1863907038;
					continue;
				case 60u:
					num = (int)((num2 * 1774269333) ^ 0x3A86A57A);
					continue;
				case 59u:
					num = (int)(num2 * 1930709009) ^ -819721468;
					continue;
				case 58u:
					Form3.smethod_38((Control)(object)label1, Form3.smethod_37("Mistral", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form3.smethod_30((Control)(object)label1, new Point(140, 70));
					num = ((int)num2 * -578977879) ^ 0x5725C5DF;
					continue;
				case 57u:
					num = (int)(num2 * 1433554725) ^ -1091194109;
					continue;
				case 56u:
					Form3.smethod_34((ButtonBase)(object)button4, bool_0: true);
					num = ((int)num2 * -438326327) ^ 0x10AE8BE9;
					continue;
				case 55u:
					num = ((int)num2 * -1661988526) ^ -2129287980;
					continue;
				case 54u:
					Form3.smethod_30((Control)(object)NullButton, new Point(-1, -1));
					num = (int)(num2 * 773866558) ^ -1294310059;
					continue;
				case 53u:
					num = (int)(num2 * 1204410115) ^ -1679871246;
					continue;
				case 52u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button5), 0);
					num = (int)(num2 * 2006514953) ^ -1418238430;
					continue;
				case 51u:
					Form3.smethod_30((Control)(object)textBox2, new Point(174, 26));
					num = (int)((num2 * 456143037) ^ 0x2AE045BD);
					continue;
				case 50u:
					Form3.smethod_34((ButtonBase)(object)button1, bool_0: true);
					num = (int)(num2 * 1929534631) ^ -792676882;
					continue;
				case 49u:
					Form3.smethod_25((Control)(object)this);
					num = (int)((num2 * 967675854) ^ 0x6B2752EA);
					continue;
				case 48u:
					num = ((int)num2 * -764423023) ^ -1483479238;
					continue;
				case 47u:
					num = ((int)num2 * -58417785) ^ 0x1B4715AB;
					continue;
				case 46u:
					num = ((int)num2 * -46624918) ^ 0x1BA5970;
					continue;
				case 45u:
					num = (int)((num2 * 723993888) ^ 0x736E10E8);
					continue;
				case 44u:
					num = (int)(num2 * 913219975) ^ -1752084665;
					continue;
				case 42u:
					Form3.smethod_34((ButtonBase)(object)button7, bool_0: true);
					num = ((int)num2 * -1558050220) ^ 0x2631753C;
					continue;
				case 41u:
					num = ((int)num2 * -1493507179) ^ -1781590587;
					continue;
				case 40u:
					num = ((int)num2 * -195150569) ^ 0x2E4AD66;
					continue;
				case 39u:
					Form3.smethod_42(errorProvider1, (ContainerControl)(object)this);
					Form3.smethod_43((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -1475596757) ^ -1009390546;
					continue;
				case 38u:
					Form3.smethod_30((Control)(object)button5, new Point(174, 190));
					num = (int)((num2 * 2036170507) ^ 0x657301A2);
					continue;
				case 37u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)NullButton), 0);
					num = ((int)num2 * -471234708) ^ -1445693511;
					continue;
				case 36u:
					Form3.smethod_26((Control)(object)NullButton, Color.Transparent);
					num = (int)((num2 * 307217972) ^ 0x73D5ED2D);
					continue;
				case 35u:
					num = ((int)num2 * -222575677) ^ -2012631498;
					continue;
				case 34u:
					Form3.smethod_31((Control)(object)textBox2, "textBox2");
					num = (int)((num2 * 1182908561) ^ 0x14F02A93);
					continue;
				case 33u:
					Form3.smethod_29((ButtonBase)(object)NullButton, (FlatStyle)0);
					num = (int)((num2 * 967270697) ^ 0x5EAE87F5);
					continue;
				case 32u:
					Form3.smethod_34((ButtonBase)(object)NullButton, bool_0: false);
					num = (int)(num2 * 420959684) ^ -2006041989;
					continue;
				case 31u:
					num = (int)((num2 * 1142850652) ^ 0x7CA4E45F);
					continue;
				case 30u:
					Form3.smethod_38((Control)(object)button7, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 365263416) ^ 0x55FDE409);
					continue;
				case 29u:
					Form3.smethod_32((Control)(object)button4, new Size(140, 50));
					Form3.smethod_33((Control)(object)button4, 4);
					Form3.smethod_35((Control)(object)button4, "Начало игры");
					num = ((int)num2 * -1895673576) ^ 0x5ABB1F72;
					continue;
				case 28u:
					Form3.smethod_34((ButtonBase)(object)button5, bool_0: true);
					num = ((int)num2 * -166077289) ^ 0x1F2EDDA4;
					continue;
				case 27u:
					num = (int)((num2 * 575105944) ^ 0x783CE8B7);
					continue;
				case 26u:
					Form3.smethod_49((Form)(object)this, bool_0: false);
					Form3.smethod_50((Form)(object)this, bool_0: false);
					num = ((int)num2 * -550237718) ^ -1471206025;
					continue;
				case 25u:
					num = ((int)num2 * -1389139889) ^ 0x2B20D2DA;
					continue;
				case 24u:
					Form3.smethod_45((Form)(object)this, new Size(486, 296));
					num = (int)((num2 * 1012851460) ^ 0x3B841B08);
					continue;
				case 23u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox1);
					num = (int)(num2 * 423937768) ^ -1132523845;
					continue;
				case 22u:
					Form3.smethod_38((Control)(object)button4, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form3.smethod_30((Control)(object)button4, new Point(174, 137));
					num = (int)(num2 * 1558551190) ^ -1215480134;
					continue;
				case 21u:
					Form3.smethod_44((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -142821975) ^ 0x26047E3;
					continue;
				case 20u:
					Form3.smethod_33((Control)(object)textBox1, 7);
					num = (int)(num2 * 748841217) ^ -1160184361;
					continue;
				case 19u:
					Form3.smethod_33((Control)(object)textBox2, 8);
					Form3.smethod_41(textBox2, bool_0: true);
					num = ((int)num2 * -1796593244) ^ -978174491;
					continue;
				case 18u:
					num = (int)((num2 * 1927050539) ^ 0x17E150FF);
					continue;
				case 17u:
					Form3.smethod_33((Control)(object)label1, 7);
					Form3.smethod_35((Control)(object)label1, "QUARTO");
					num = ((int)num2 * -120264847) ^ 0x1D1962A8;
					continue;
				case 16u:
					Form3.smethod_53((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1683597034) ^ -1323072928;
					continue;
				case 15u:
					button7 = Form3.smethod_20();
					textBox1 = Form3.smethod_21();
					label1 = Form3.smethod_22();
					num = ((int)num2 * -1973291429) ^ -2094160347;
					continue;
				case 14u:
					Form3.smethod_32((Control)(object)button2, new Size(85, 21));
					num = ((int)num2 * -1564403089) ^ 0x58DC002A;
					continue;
				case 13u:
					Form3.smethod_32((Control)(object)label1, new Size(207, 76));
					num = (int)(num2 * 1834419256) ^ -1374021821;
					continue;
				case 12u:
					num = (int)((num2 * 1408898804) ^ 0x1980640D);
					continue;
				case 11u:
					num = ((int)num2 * -1149662422) ^ 0x7AAE68CE;
					continue;
				case 10u:
					textBox2 = Form3.smethod_21();
					num = (int)((num2 * 1344378883) ^ 0x39D2E577);
					continue;
				case 9u:
					Form3.smethod_14((Control)(object)button5, bool_0: false);
					num = ((int)num2 * -945985025) ^ -1591506499;
					continue;
				case 8u:
					components = Form3.smethod_19();
					NullButton = Form3.smethod_20();
					button1 = Form3.smethod_20();
					button2 = Form3.smethod_20();
					button4 = Form3.smethod_20();
					num = (int)(num2 * 1336571267) ^ -828069373;
					continue;
				case 7u:
					Form3.smethod_31((Control)(object)button5, "button5");
					Form3.smethod_32((Control)(object)button5, new Size(140, 50));
					num = ((int)num2 * -2043129811) ^ 0x5417F26D;
					continue;
				case 6u:
					Form3.smethod_33((Control)(object)button7, 6);
					num = ((int)num2 * -962535745) ^ -1348399025;
					continue;
				case 5u:
					Form3.smethod_40((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -1688404523) ^ 0x3761D350;
					continue;
				case 4u:
					num = (int)(num2 * 1115662354) ^ -229100502;
					continue;
				case 3u:
					Form3.smethod_36((Control)(object)button4, (EventHandler)Button4_Click);
					num = ((int)num2 * -238076308) ^ -1017008247;
					continue;
				case 2u:
					num = ((int)num2 * -294106411) ^ -1213908625;
					continue;
				case 1u:
					num = (int)((num2 * 806953516) ^ 0x64B8058F);
					continue;
				case 0u:
					Form3.smethod_36((Control)(object)button1, (EventHandler)Button1_Click);
					Form3.smethod_30((Control)(object)button2, new Point(174, 49));
					Form3.smethod_31((Control)(object)button2, "button2");
					num = ((int)num2 * -97054325) ^ 0x461FDC60;
					continue;
				case 43u:
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
