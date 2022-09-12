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
			int num = 915651006;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8D2315Du) % 11u)
				{
				case 10u:
					num = ((int)num2 * -1513101566) ^ -1356431428;
					continue;
				case 8u:
					Form3.smethod_10(val, new Point(Form3.smethod_5((Form)(object)this).X + (Form3.smethod_6((Control)(object)this) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_5((Form)(object)this).Y + (Form3.smethod_8((Control)(object)this) - Form3.smethod_9((Control)(object)val)) / 2 + 70));
					num = (int)(num2 * 927540667) ^ -1270126019;
					continue;
				case 6u:
					num = ((int)num2 * -1895014101) ^ -1428270492;
					continue;
				case 5u:
					num = (int)((num2 * 927114629) ^ 0x6308B543);
					continue;
				case 4u:
				{
					Form4 form = new Form4();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					Form3.smethod_4((Control)(object)val);
					num = ((int)num2 * -1049585705) ^ 0x37E48491;
					continue;
				}
				case 3u:
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = ((int)num2 * -10692166) ^ 0x792097C5;
					continue;
				case 2u:
					num = ((int)num2 * -274641933) ^ -1496206012;
					continue;
				case 1u:
					Form3.smethod_0((Control)(object)NullButton);
					num = ((int)num2 * -32326692) ^ 0x20341BBC;
					continue;
				case 0u:
					Form3.smethod_1(errorProvider1);
					num = (int)((num2 * 682149601) ^ 0x7649F5FC);
					continue;
				default:
					return;
				case 7u:
					break;
				case 9u:
					return;
				}
				break;
			}
		}
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		Form3.smethod_0((Control)(object)NullButton);
		Form2 form = new Form2();
		Form3.smethod_2((Form)(object)form, bool_0: true);
		Form3.smethod_3((Form)(object)form, (Form)(object)this);
		Form val = (Form)(object)form;
		while (true)
		{
			int num = 1256863672;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1E5B1FDEu) % 4u)
				{
				case 2u:
					Form3.smethod_4((Control)(object)val);
					num = ((int)num2 * -138770180) ^ 0x6AA2C14F;
					continue;
				case 1u:
					num = (int)((num2 * 1537110090) ^ 0x11D1B907);
					continue;
				case 0u:
					break;
				default:
					Form3.smethod_10(val, new Point(Form3.smethod_13(Form3.smethod_12((Form)(object)this)).X + (Form3.smethod_7((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_13(Form3.smethod_12((Form)(object)this)).Y + (Form3.smethod_9((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_9((Control)(object)val)) / 2));
					Form3.smethod_11((Control)(object)this, bool_0: false);
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
		while (true)
		{
			int num = Form3.smethod_8((Control)(object)this) - 1;
			Form3.smethod_15((Control)(object)this, num);
			int num2 = 190313751;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x6D08DEEBu) % 7u)
				{
				case 5u:
				{
					int num4;
					int num5;
					if (num > 1)
					{
						num4 = -1358903180;
						num5 = -1358903180;
					}
					else
					{
						num4 = -1019098667;
						num5 = -1019098667;
					}
					num2 = num4 ^ (int)(num3 * 1303387974);
					continue;
				}
				case 3u:
					Form3.smethod_16(Form3.smethod_12((Form)(object)this));
					Form3.smethod_17((Form3.smethod_12((Form)(object)this) as Form1).timer1);
					num2 = (int)((num3 * 1454801055) ^ 0x1B1BFC68);
					continue;
				case 2u:
					num2 = ((int)num3 * -263431366) ^ 0x33DCF9C5;
					continue;
				case 1u:
					num2 = 480151877;
					continue;
				case 0u:
					num2 = 1907189936;
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

	private void Button1_Click(object sender, EventArgs e)
	{
	}

	private void TextBox_TextChanged(object sender, EventArgs e)
	{
		Form3.smethod_1(errorProvider1);
		while (true)
		{
			int num = 1448438788;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4E5FD169u) % 3u)
				{
				case 2u:
					goto IL_000d;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_000d:
				num = ((int)num2 * -497226437) ^ -1936752493;
			}
		}
	}

	public void ContinueLock()
	{
		Form3.smethod_14((Control)(object)button5, bool_0: false);
		while (true)
		{
			int num = -1553118770;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA3C4E13Du) % 3u)
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
				num = ((int)num2 * -1556417907) ^ 0x1CF6492C;
			}
		}
	}

	public void AchivUnlock()
	{
		Form3.smethod_14((Control)(object)button7, bool_0: true);
	}

	private void Button7_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 1569705750;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x54EEB6FBu) % 5u)
				{
				case 4u:
					Form3.smethod_0((Control)(object)NullButton);
					num = (int)((num2 * 737866625) ^ 0x5F7BFC09);
					continue;
				case 3u:
					Form3.smethod_14((Control)(object)button7, bool_0: false);
					num = (int)((num2 * 85324253) ^ 0x62D0190F);
					continue;
				case 0u:
					num = ((int)num2 * -1629584690) ^ 0x7A0C7D4B;
					continue;
				default:
					return;
				case 2u:
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
		if (disposing)
		{
			goto IL_0032;
		}
		int num = 0;
		goto IL_00a0;
		IL_00a0:
		bool flag = (byte)num != 0;
		int num2 = -632893597;
		goto IL_006a;
		IL_0032:
		num2 = -1361263045;
		goto IL_006a;
		IL_006a:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0xE3A09CC3u) % 7u)
			{
			case 6u:
				num2 = (int)((num3 * 1334166981) ^ 0x1B459E3);
				continue;
			case 4u:
				Form3.smethod_18((IDisposable)components);
				num2 = ((int)num3 * -1944781018) ^ -806136049;
				continue;
			case 3u:
				break;
			case 1u:
			{
				int num4;
				int num5;
				if (flag)
				{
					num4 = -500550565;
					num5 = -500550565;
				}
				else
				{
					num4 = -1992855333;
					num5 = -1992855333;
				}
				num2 = num4 ^ ((int)num3 * -550627690);
				continue;
			}
			case 0u:
				num2 = (int)((num3 * 956248540) ^ 0x1A13B74B);
				continue;
			case 2u:
				goto IL_0097;
			default:
				((Form)this).Dispose(disposing);
				return;
			}
			break;
		}
		goto IL_0032;
		IL_0097:
		num = ((components != null) ? 1 : 0);
		goto IL_00a0;
	}

	private void InitializeComponent()
	{
		while (true)
		{
			int num = 123110197;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x431EDA0Cu) % 131u)
				{
				case 130u:
					num = (int)(num2 * 465970432) ^ -276543613;
					continue;
				case 129u:
					num = (int)((num2 * 1936130071) ^ 0x14F6DA1F);
					continue;
				case 128u:
					Form3.smethod_14((Control)(object)button4, bool_0: false);
					num = ((int)num2 * -1412877094) ^ -179436412;
					continue;
				case 127u:
					Form3.smethod_32((Control)(object)button2, new Size(85, 21));
					num = ((int)num2 * -1281778972) ^ 0x4A3B8C5D;
					continue;
				case 126u:
					num = ((int)num2 * -1467410935) ^ 0xC3EC70A;
					continue;
				case 125u:
					num = (int)((num2 * 1618160246) ^ 0xC609670);
					continue;
				case 124u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -206789588) ^ -1957966217;
					continue;
				case 123u:
					Form3.smethod_25((Control)(object)this);
					num = (int)((num2 * 1300238001) ^ 0xBCDB720);
					continue;
				case 122u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button7), 0);
					num = ((int)num2 * -1848475734) ^ 0x55ECEBC7;
					continue;
				case 121u:
					Form3.smethod_35((Control)(object)button1, "Вход");
					num = (int)((num2 * 1887554837) ^ 0x2267B13C);
					continue;
				case 120u:
					num = (int)(num2 * 1521087206) ^ -749833210;
					continue;
				case 119u:
					Form3.smethod_39((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = (int)(num2 * 1521740965) ^ -674190656;
					continue;
				case 118u:
					Form3.smethod_51((Control)(object)this, "Form3");
					num = ((int)num2 * -812506780) ^ 0x63503A1E;
					continue;
				case 117u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button1);
					num = (int)((num2 * 226604903) ^ 0x19833889);
					continue;
				case 116u:
					Form3.smethod_30((Control)(object)button2, new Point(174, 49));
					num = ((int)num2 * -1375337524) ^ 0x58C39EE4;
					continue;
				case 115u:
					Form3.smethod_57((Control)(object)this);
					num = ((int)num2 * -135800081) ^ 0x34C81502;
					continue;
				case 114u:
					button7 = Form3.smethod_20();
					textBox1 = Form3.smethod_21();
					num = ((int)num2 * -392853773) ^ 0x17074EAA;
					continue;
				case 113u:
					Form3.smethod_33((Control)(object)button1, 0);
					num = (int)((num2 * 264605445) ^ 0x388C771);
					continue;
				case 112u:
					num = ((int)num2 * -804361210) ^ -1702256230;
					continue;
				case 111u:
					Form3.smethod_48((Form)(object)this, (FormBorderStyle)0);
					num = ((int)num2 * -37167151) ^ 0x615DEFF6;
					continue;
				case 110u:
					Form3.smethod_56((Control)(object)this, bool_0: false);
					num = (int)((num2 * 1117156390) ^ 0x5E93F65F);
					continue;
				case 109u:
					Form3.smethod_36((Control)(object)button4, (EventHandler)Button4_Click);
					num = ((int)num2 * -1686242139) ^ 0x5FFE18AF;
					continue;
				case 108u:
					Form3.smethod_32((Control)(object)label1, new Size(207, 76));
					num = (int)((num2 * 1741284121) ^ 0x3CDFA874);
					continue;
				case 107u:
					Form3.smethod_53((Form)(object)this, bool_0: false);
					Form3.smethod_54((Form)(object)this, bool_0: true);
					num = ((int)num2 * -1639765740) ^ -1169939146;
					continue;
				case 106u:
					Form3.smethod_36((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -1466630808) ^ 0x6889DE74;
					continue;
				case 105u:
					num = (int)((num2 * 1122265562) ^ 0x36F1BB11);
					continue;
				case 104u:
					label1 = Form3.smethod_22();
					num = ((int)num2 * -1124606712) ^ -1874278535;
					continue;
				case 103u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox2);
					num = ((int)num2 * -546070290) ^ -182736010;
					continue;
				case 102u:
					Form3.smethod_31((Control)(object)button4, "button4");
					Form3.smethod_32((Control)(object)button4, new Size(140, 50));
					num = ((int)num2 * -53361023) ^ 0x5A6A8707;
					continue;
				case 101u:
					num = ((int)num2 * -1152763261) ^ -689742342;
					continue;
				case 100u:
					Form3.smethod_32((Control)(object)button1, new Size(49, 21));
					num = (int)((num2 * 192786433) ^ 0x12BB2DA5);
					continue;
				case 99u:
					num = (int)(num2 * 1846726605) ^ -2039018544;
					continue;
				case 98u:
					num = (int)((num2 * 1906210557) ^ 0x1FFFB6CF);
					continue;
				case 97u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button4), 0);
					Form3.smethod_29((ButtonBase)(object)button4, (FlatStyle)0);
					num = (int)(num2 * 1189793719) ^ -624549231;
					continue;
				case 96u:
					Form3.smethod_33((Control)(object)NullButton, 3);
					Form3.smethod_34((ButtonBase)(object)NullButton, bool_0: false);
					Form3.smethod_30((Control)(object)button1, new Point(265, 49));
					num = (int)(num2 * 1265292132) ^ -610222676;
					continue;
				case 95u:
					Form3.smethod_50((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1073778411) ^ -985900670;
					continue;
				case 94u:
					Form3.smethod_26((Control)(object)NullButton, Color.Transparent);
					num = (int)((num2 * 852630961) ^ 0x96C62EA);
					continue;
				case 93u:
					textBox2 = Form3.smethod_21();
					errorProvider1 = Form3.smethod_23(components);
					Form3.smethod_24((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -600717805) ^ -148709319;
					continue;
				case 92u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)NullButton);
					num = ((int)num2 * -727022571) ^ 0x6BE5AE26;
					continue;
				case 91u:
					num = (int)((num2 * 1437504547) ^ 0x185FEAD2);
					continue;
				case 90u:
					Form3.smethod_33((Control)(object)label1, 7);
					Form3.smethod_35((Control)(object)label1, "QUARTO");
					num = ((int)num2 * -1760581665) ^ -58215192;
					continue;
				case 89u:
					Form3.smethod_29((ButtonBase)(object)button7, (FlatStyle)0);
					num = (int)((num2 * 1320829585) ^ 0x702DFA87);
					continue;
				case 88u:
					Form3.smethod_38((Control)(object)button7, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -469596624) ^ -540415519;
					continue;
				case 87u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button2);
					num = ((int)num2 * -1151838402) ^ 0x42C4E23B;
					continue;
				case 86u:
					Form3.smethod_40((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -1411653589) ^ 0x2006FE8;
					continue;
				case 85u:
					Form3.smethod_29((ButtonBase)(object)button5, (FlatStyle)0);
					num = ((int)num2 * -1710363528) ^ -698255225;
					continue;
				case 84u:
					num = ((int)num2 * -1317278469) ^ -2048710608;
					continue;
				case 83u:
					Form3.smethod_36((Control)(object)button7, (EventHandler)Button7_Click);
					num = ((int)num2 * -762798360) ^ -1438222174;
					continue;
				case 82u:
					Form3.smethod_29((ButtonBase)(object)NullButton, (FlatStyle)0);
					num = (int)(num2 * 1205228418) ^ -1734592269;
					continue;
				case 81u:
					Form3.smethod_34((ButtonBase)(object)button4, bool_0: true);
					num = (int)((num2 * 199855473) ^ 0x2661136);
					continue;
				case 80u:
					num = ((int)num2 * -866792169) ^ 0x15580AE8;
					continue;
				case 79u:
					Form3.smethod_36((Control)(object)button2, (EventHandler)Button2_Click);
					num = ((int)num2 * -181731502) ^ 0x44165BF2;
					continue;
				case 78u:
					num = (int)(num2 * 1895062361) ^ -1842789611;
					continue;
				case 77u:
					Form3.smethod_33((Control)(object)textBox2, 8);
					num = ((int)num2 * -734547962) ^ 0x59B4099D;
					continue;
				case 76u:
					Form3.smethod_35((Control)(object)button5, "Продолжить");
					Form3.smethod_34((ButtonBase)(object)button5, bool_0: true);
					num = (int)((num2 * 353788268) ^ 0xD97411);
					continue;
				case 75u:
					Form3.smethod_44((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 1123691878) ^ -775437461;
					continue;
				case 74u:
					Form3.smethod_30((Control)(object)button7, new Point(174, 243));
					num = (int)((num2 * 1426057931) ^ 0x45B4AC08);
					continue;
				case 73u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox1);
					num = ((int)num2 * -659779304) ^ 0x4DF97AF4;
					continue;
				case 72u:
					num = (int)(num2 * 2001873971) ^ -434942838;
					continue;
				case 71u:
					num = (int)(num2 * 1057349373) ^ -352238630;
					continue;
				case 70u:
					num = (int)(num2 * 1977494210) ^ -1656370258;
					continue;
				case 69u:
					num = (int)((num2 * 1318496838) ^ 0xD0748B6);
					continue;
				case 68u:
					num = ((int)num2 * -1368740546) ^ 0x4B70121;
					continue;
				case 67u:
					button2 = Form3.smethod_20();
					num = (int)((num2 * 469188963) ^ 0x24DD8C03);
					continue;
				case 66u:
					Form3.smethod_36((Control)(object)button5, (EventHandler)Button5_Click);
					num = (int)(num2 * 655145874) ^ -1293216415;
					continue;
				case 65u:
					Form3.smethod_38((Control)(object)label1, Form3.smethod_37("Mistral", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -83629980) ^ -969998661;
					continue;
				case 64u:
					num = (int)((num2 * 1844703626) ^ 0x7AB363CA);
					continue;
				case 63u:
					num = ((int)num2 * -1115149553) ^ 0x547FE088;
					continue;
				case 62u:
					Form3.smethod_33((Control)(object)textBox1, 7);
					Form3.smethod_39((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -929835955) ^ 0x6A408B36;
					continue;
				case 61u:
					Form3.smethod_30((Control)(object)button4, new Point(174, 137));
					num = ((int)num2 * -1831281096) ^ -656161862;
					continue;
				case 60u:
					Form3.smethod_32((Control)(object)button5, new Size(140, 50));
					num = (int)((num2 * 1532398288) ^ 0x6E0AFB5C);
					continue;
				case 59u:
					Form3.smethod_34((ButtonBase)(object)button7, bool_0: true);
					num = ((int)num2 * -25120792) ^ -1908478118;
					continue;
				case 58u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button7);
					num = (int)((num2 * 1660469821) ^ 0x3B909221);
					continue;
				case 57u:
					Form3.smethod_41(textBox2, bool_0: true);
					num = (int)((num2 * 1852006929) ^ 0x532BD345);
					continue;
				case 56u:
					Form3.smethod_32((Control)(object)NullButton, new Size(1, 1));
					num = ((int)num2 * -279918790) ^ -392020106;
					continue;
				case 55u:
					Form3.smethod_33((Control)(object)button4, 4);
					num = (int)((num2 * 782715899) ^ 0x77380647);
					continue;
				case 53u:
					Form3.smethod_31((Control)(object)button7, "button7");
					num = ((int)num2 * -1613850268) ^ -524092474;
					continue;
				case 52u:
					Form3.smethod_35((Control)(object)button7, "Достижения");
					num = (int)((num2 * 1857989008) ^ 0x7EFBE1B2);
					continue;
				case 51u:
					Form3.smethod_30((Control)(object)textBox1, new Point(174, 2));
					num = (int)((num2 * 1382886310) ^ 0x7005F73A);
					continue;
				case 50u:
					Form3.smethod_55((ISupportInitialize)errorProvider1);
					num = (int)(num2 * 1687726302) ^ -528099826;
					continue;
				case 49u:
					Form3.smethod_30((Control)(object)textBox2, new Point(174, 26));
					num = (int)(num2 * 567558270) ^ -919266949;
					continue;
				case 48u:
					num = (int)((num2 * 1197187529) ^ 0x4B2D8FD3);
					continue;
				case 47u:
					Form3.smethod_38((Control)(object)button4, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -85468449) ^ -800692047;
					continue;
				case 46u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button5), 0);
					num = (int)(num2 * 329227643) ^ -727575782;
					continue;
				case 45u:
					Form3.smethod_31((Control)(object)button2, "button2");
					num = (int)(num2 * 1515218148) ^ -296921546;
					continue;
				case 44u:
					Form3.smethod_35((Control)(object)button2, "Регистрация");
					Form3.smethod_34((ButtonBase)(object)button2, bool_0: true);
					num = ((int)num2 * -1615658091) ^ -2042368089;
					continue;
				case 43u:
					num = (int)(num2 * 820226252) ^ -502818196;
					continue;
				case 42u:
					num = (int)((num2 * 1419110899) ^ 0x1127DF04);
					continue;
				case 41u:
					num = (int)((num2 * 781700729) ^ 0x4685CC88);
					continue;
				case 40u:
					button1 = Form3.smethod_20();
					num = (int)(num2 * 1585438155) ^ -914886;
					continue;
				case 39u:
					num = ((int)num2 * -1365329138) ^ 0x48C64BE;
					continue;
				case 38u:
					Form3.smethod_35((Control)(object)button4, "Начало игры");
					num = ((int)num2 * -1827819801) ^ 0x790E372B;
					continue;
				case 37u:
					num = ((int)num2 * -2099129039) ^ 0x597A5846;
					continue;
				case 36u:
					Form3.smethod_34((ButtonBase)(object)button1, bool_0: true);
					num = (int)(num2 * 762842348) ^ -813147513;
					continue;
				case 35u:
					Form3.smethod_49((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1951922260) ^ -583405073;
					continue;
				case 33u:
					Form3.smethod_45((Form)(object)this, new Size(486, 296));
					num = ((int)num2 * -212558452) ^ -18878301;
					continue;
				case 32u:
					Form3.smethod_33((Control)(object)button2, 1);
					num = (int)(num2 * 2101115967) ^ -1827827406;
					continue;
				case 31u:
					Form3.smethod_42(errorProvider1, (ContainerControl)(object)this);
					num = (int)(num2 * 633725257) ^ -1920807370;
					continue;
				case 30u:
					Form3.smethod_52((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1403798014) ^ -1558628359;
					continue;
				case 29u:
					num = (int)(num2 * 1154665949) ^ -246816795;
					continue;
				case 28u:
					num = (int)(num2 * 2002480691) ^ -360769738;
					continue;
				case 27u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button5);
					num = ((int)num2 * -1551582798) ^ 0xC747E22;
					continue;
				case 26u:
					num = ((int)num2 * -568503350) ^ 0x3562ADC5;
					continue;
				case 25u:
					Form3.smethod_30((Control)(object)NullButton, new Point(-1, -1));
					num = (int)(num2 * 1732033108) ^ -1729328732;
					continue;
				case 24u:
					Form3.smethod_33((Control)(object)button5, 5);
					num = (int)((num2 * 1492719851) ^ 0x54E83141);
					continue;
				case 23u:
					num = ((int)num2 * -2095344067) ^ -2095249787;
					continue;
				case 22u:
					num = (int)(num2 * 575375138) ^ -1825352150;
					continue;
				case 21u:
					Form3.smethod_14((Control)(object)button5, bool_0: false);
					num = (int)((num2 * 633414523) ^ 0x348756C4);
					continue;
				case 20u:
					num = ((int)num2 * -1406015006) ^ -76196234;
					continue;
				case 19u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button4);
					num = ((int)num2 * -1383178869) ^ -1976931039;
					continue;
				case 18u:
					num = ((int)num2 * -1691437847) ^ -797385425;
					continue;
				case 17u:
					num = ((int)num2 * -2012479692) ^ -1164806940;
					continue;
				case 16u:
					Form3.smethod_31((Control)(object)NullButton, "NullButton");
					num = (int)((num2 * 277516022) ^ 0x68E2A308);
					continue;
				case 15u:
					Form3.smethod_26((Control)(object)this, Color.White);
					num = (int)((num2 * 58994452) ^ 0x7917FEEC);
					continue;
				case 14u:
					button4 = Form3.smethod_20();
					button5 = Form3.smethod_20();
					num = ((int)num2 * -1586046364) ^ 0x75046F2B;
					continue;
				case 13u:
					Form3.smethod_43((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -546754914) ^ 0x1DF154BA;
					continue;
				case 12u:
					Form3.smethod_38((Control)(object)button5, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form3.smethod_30((Control)(object)button5, new Point(174, 190));
					Form3.smethod_31((Control)(object)button5, "button5");
					num = ((int)num2 * -843977712) ^ 0x7AAC0462;
					continue;
				case 11u:
					Form3.smethod_32((Control)(object)textBox1, new Size(140, 20));
					num = ((int)num2 * -252129714) ^ -319349774;
					continue;
				case 10u:
					Form3.smethod_31((Control)(object)textBox2, "textBox2");
					Form3.smethod_32((Control)(object)textBox2, new Size(140, 20));
					num = (int)((num2 * 1799383186) ^ 0x2829E227);
					continue;
				case 9u:
					Form3.smethod_30((Control)(object)label1, new Point(140, 70));
					Form3.smethod_31((Control)(object)label1, "label1");
					num = ((int)num2 * -343973008) ^ -66806057;
					continue;
				case 8u:
					num = (int)(num2 * 1276198851) ^ -1333448372;
					continue;
				case 7u:
					num = (int)((num2 * 2096150059) ^ 0x377F108B);
					continue;
				case 6u:
					num = ((int)num2 * -298875758) ^ 0x4EBD36C2;
					continue;
				case 5u:
					Form3.smethod_32((Control)(object)button7, new Size(140, 50));
					Form3.smethod_33((Control)(object)button7, 6);
					num = (int)((num2 * 989306946) ^ 0x73E1820C);
					continue;
				case 4u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)NullButton), 0);
					num = ((int)num2 * -1729451561) ^ -1618494243;
					continue;
				case 3u:
					components = Form3.smethod_19();
					NullButton = Form3.smethod_20();
					num = (int)(num2 * 1515748314) ^ -2103902991;
					continue;
				case 2u:
					Form3.smethod_31((Control)(object)button1, "button1");
					num = (int)(num2 * 463367752) ^ -722375323;
					continue;
				case 1u:
					Form3.smethod_31((Control)(object)textBox1, "textBox1");
					num = ((int)num2 * -168095422) ^ 0x16AC6B24;
					continue;
				case 0u:
					Form3.smethod_26((Control)(object)label1, Color.Transparent);
					num = ((int)num2 * -658255240) ^ -852105402;
					continue;
				default:
					return;
				case 34u:
					break;
				case 54u:
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
