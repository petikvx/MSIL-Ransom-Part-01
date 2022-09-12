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
		while (true)
		{
			int num = 220023513;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x17C84109u) % 5u)
				{
				case 4u:
					num = (int)((num2 * 1920371253) ^ 0x6FC737E);
					continue;
				case 3u:
					num = ((int)num2 * -286559590) ^ 0x71BC8BA;
					continue;
				case 1u:
					InitializeComponent();
					num = ((int)num2 * -2049410370) ^ 0x45110460;
					continue;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		Form3.smethod_0((Control)(object)NullButton);
		Form3.smethod_1(errorProvider1);
		Form val = default(Form);
		while (true)
		{
			int num = 680569485;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3CDA0CABu) % 6u)
				{
				case 4u:
				{
					Form4 form = new Form4();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					num = ((int)num2 * -816443303) ^ 0x75F01583;
					continue;
				}
				case 3u:
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = (int)(num2 * 929195759) ^ -1355203685;
					continue;
				case 2u:
					Form3.smethod_4((Control)(object)val);
					Form3.smethod_10(val, new Point(Form3.smethod_5((Form)(object)this).X + (Form3.smethod_6((Control)(object)this) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_5((Form)(object)this).Y + (Form3.smethod_8((Control)(object)this) - Form3.smethod_9((Control)(object)val)) / 2 + 70));
					num = (int)((num2 * 648003014) ^ 0x6C42C482);
					continue;
				case 1u:
					num = (int)(num2 * 1013717332) ^ -1523913514;
					continue;
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

	private void Button4_Click(object sender, EventArgs e)
	{
		Form val = default(Form);
		while (true)
		{
			int num = 748487941;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x29EA1544u) % 9u)
				{
				case 7u:
					num = (int)(num2 * 1517901744) ^ -138370409;
					continue;
				case 6u:
					num = ((int)num2 * -632263493) ^ 0x60EA6AD1;
					continue;
				case 5u:
					Form3.smethod_10(val, new Point(Form3.smethod_13(Form3.smethod_12((Form)(object)this)).X + (Form3.smethod_7((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_13(Form3.smethod_12((Form)(object)this)).Y + (Form3.smethod_9((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_9((Control)(object)val)) / 2));
					num = (int)(num2 * 1218933010) ^ -575641552;
					continue;
				case 4u:
					Form3.smethod_0((Control)(object)NullButton);
					num = (int)((num2 * 1788264838) ^ 0x13445A34);
					continue;
				case 3u:
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = ((int)num2 * -1132310110) ^ 0x20E03669;
					continue;
				case 2u:
					Form3.smethod_4((Control)(object)val);
					num = (int)((num2 * 1701012178) ^ 0x50F49ECC);
					continue;
				case 1u:
				{
					Form2 form = new Form2();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					num = (int)(num2 * 1690714037) ^ -1158130738;
					continue;
				}
				default:
					return;
				case 8u:
					break;
				case 0u:
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
			int num = -1095364126;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC83101F3u) % 3u)
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
				num = (int)((num2 * 766442660) ^ 0x71808AE6);
			}
		}
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = Form3.smethod_8((Control)(object)this) - 1;
			Form3.smethod_15((Control)(object)this, num);
			int num2 = -111774409;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xA3579DF5u) % 10u)
				{
				case 9u:
					num2 = (int)(num3 * 202855240) ^ -747497503;
					continue;
				case 8u:
					Form3.smethod_17((Form3.smethod_12((Form)(object)this) as Form1).timer1);
					num2 = (int)(num3 * 1737223845) ^ -1537476020;
					continue;
				case 7u:
					flag = num > 1;
					num2 = (int)((num3 * 941818079) ^ 0x72A41BBC);
					continue;
				case 4u:
					num2 = -1013078326;
					continue;
				case 3u:
					num2 = -142568921;
					continue;
				case 2u:
					num2 = ((int)num3 * -216666904) ^ 0xD713284;
					continue;
				case 1u:
					Form3.smethod_16(Form3.smethod_12((Form)(object)this));
					num2 = ((int)num3 * -1671105715) ^ 0x8EDBAFE;
					continue;
				case 0u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 138210401;
						num5 = 138210401;
					}
					else
					{
						num4 = 558829034;
						num5 = 558829034;
					}
					num2 = num4 ^ ((int)num3 * -1035146439);
					continue;
				}
				default:
					return;
				case 5u:
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
			int num = 1194616109;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC18681Au) % 3u)
				{
				case 1u:
					goto IL_001a;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_001a:
				num = (int)(num2 * 331508733) ^ -324840238;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			goto IL_002d;
		}
		int num = 0;
		goto IL_00c6;
		IL_00c6:
		bool flag = (byte)num != 0;
		int num2 = -1804360574;
		goto IL_0087;
		IL_002d:
		num2 = -1253490646;
		goto IL_0087;
		IL_0087:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0xAF24465Bu) % 9u)
			{
			case 7u:
			{
				int num4;
				int num5;
				if (flag)
				{
					num4 = -1873754611;
					num5 = -1873754611;
				}
				else
				{
					num4 = -1820425091;
					num5 = -1820425091;
				}
				num2 = num4 ^ (int)(num3 * 1928009478);
				continue;
			}
			case 6u:
				break;
			case 5u:
				num2 = (int)(num3 * 429042930) ^ -1375073405;
				continue;
			case 4u:
				num2 = (int)(num3 * 112838718) ^ -1674280973;
				continue;
			case 2u:
				((Form)this).Dispose(disposing);
				num2 = -1088583689;
				continue;
			case 1u:
				Form3.smethod_18((IDisposable)components);
				num2 = ((int)num3 * -1661758793) ^ 0x7813E257;
				continue;
			case 0u:
				num2 = (int)((num3 * 163663614) ^ 0x36B7EEB2);
				continue;
			default:
				return;
			case 8u:
				goto IL_00bd;
			case 3u:
				return;
			}
			break;
		}
		goto IL_002d;
		IL_00bd:
		num = ((components != null) ? 1 : 0);
		goto IL_00c6;
	}

	private void InitializeComponent()
	{
		while (true)
		{
			int num = -2006046126;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEC9169A4u) % 130u)
				{
				case 129u:
					NullButton = Form3.smethod_20();
					button1 = Form3.smethod_20();
					button2 = Form3.smethod_20();
					num = (int)(num2 * 2027894455) ^ -1243723251;
					continue;
				case 128u:
					components = Form3.smethod_19();
					num = (int)((num2 * 1501707061) ^ 0x4A3DE4AD);
					continue;
				case 127u:
					Form3.smethod_36((Control)(object)button2, (EventHandler)Button2_Click);
					num = (int)((num2 * 1365548025) ^ 0x766BA189);
					continue;
				case 126u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)NullButton), 0);
					Form3.smethod_29((ButtonBase)(object)NullButton, (FlatStyle)0);
					num = (int)(num2 * 532675071) ^ -614049699;
					continue;
				case 125u:
					Form3.smethod_31((Control)(object)textBox1, "textBox1");
					num = ((int)num2 * -426937267) ^ 0x16B27DC1;
					continue;
				case 124u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button7), 0);
					num = (int)((num2 * 1523512567) ^ 0x25BA4FEC);
					continue;
				case 123u:
					Form3.smethod_35((Control)(object)button5, "Продолжить");
					num = ((int)num2 * -654040933) ^ -538445782;
					continue;
				case 122u:
					num = ((int)num2 * -73591006) ^ 0x12BA7B82;
					continue;
				case 121u:
					num = (int)(num2 * 1294029933) ^ -427803887;
					continue;
				case 120u:
					textBox2 = Form3.smethod_21();
					num = ((int)num2 * -1195192147) ^ 0x77DC6B9E;
					continue;
				case 119u:
					button5 = Form3.smethod_20();
					button7 = Form3.smethod_20();
					num = (int)((num2 * 1996019715) ^ 0x6343D84E);
					continue;
				case 118u:
					Form3.smethod_35((Control)(object)label1, "QUARTO");
					num = (int)((num2 * 2117000908) ^ 0x75B76EE9);
					continue;
				case 117u:
					Form3.smethod_53((Form)(object)this, bool_0: false);
					Form3.smethod_54((Form)(object)this, bool_0: true);
					Form3.smethod_55((ISupportInitialize)errorProvider1);
					num = (int)(num2 * 2023348822) ^ -77152514;
					continue;
				case 116u:
					Form3.smethod_36((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -802800831) ^ 0xDF085D0;
					continue;
				case 115u:
					num = ((int)num2 * -1962787308) ^ 0x7C8B09CC;
					continue;
				case 114u:
					num = ((int)num2 * -483236608) ^ -1277891611;
					continue;
				case 113u:
					Form3.smethod_31((Control)(object)textBox2, "textBox2");
					num = (int)((num2 * 901787880) ^ 0x22FCD8CB);
					continue;
				case 112u:
					Form3.smethod_33((Control)(object)button2, 1);
					num = ((int)num2 * -435555810) ^ -1868964088;
					continue;
				case 111u:
					Form3.smethod_32((Control)(object)label1, new Size(207, 76));
					num = (int)(num2 * 1860728066) ^ -1841016673;
					continue;
				case 110u:
					Form3.smethod_49((Form)(object)this, bool_0: false);
					num = (int)((num2 * 1122764161) ^ 0x2994CD5A);
					continue;
				case 109u:
					Form3.smethod_57((Control)(object)this);
					num = (int)((num2 * 1718395297) ^ 0x363B6E2);
					continue;
				case 108u:
					Form3.smethod_33((Control)(object)button7, 6);
					num = ((int)num2 * -476258096) ^ -1395115289;
					continue;
				case 107u:
					num = ((int)num2 * -1531353939) ^ -532942781;
					continue;
				case 106u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox2);
					num = (int)(num2 * 1860539162) ^ -283553012;
					continue;
				case 105u:
					Form3.smethod_35((Control)(object)button4, "Начало игры");
					num = ((int)num2 * -192579539) ^ -325066854;
					continue;
				case 104u:
					num = (int)((num2 * 148496032) ^ 0x2F3157CA);
					continue;
				case 103u:
					Form3.smethod_30((Control)(object)button5, new Point(174, 190));
					num = (int)((num2 * 1839590767) ^ 0x5BEB4362);
					continue;
				case 102u:
					Form3.smethod_42(errorProvider1, (ContainerControl)(object)this);
					num = ((int)num2 * -1514368824) ^ 0x796649D9;
					continue;
				case 101u:
					num = (int)(num2 * 1518194527) ^ -1555622414;
					continue;
				case 100u:
					Form3.smethod_30((Control)(object)button2, new Point(174, 49));
					Form3.smethod_31((Control)(object)button2, "button2");
					num = (int)(num2 * 1393835312) ^ -547349369;
					continue;
				case 99u:
					Form3.smethod_31((Control)(object)button1, "button1");
					num = ((int)num2 * -1965337094) ^ -763941524;
					continue;
				case 98u:
					Form3.smethod_30((Control)(object)textBox1, new Point(174, 2));
					num = ((int)num2 * -1479527787) ^ 0x2C3997C3;
					continue;
				case 97u:
					num = (int)((num2 * 968235823) ^ 0x4DB90EB3);
					continue;
				case 96u:
					num = ((int)num2 * -1242117897) ^ -291925323;
					continue;
				case 95u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)NullButton);
					Form3.smethod_48((Form)(object)this, (FormBorderStyle)0);
					num = ((int)num2 * -1092946627) ^ -1993793271;
					continue;
				case 94u:
					num = (int)(num2 * 1361586022) ^ -797959639;
					continue;
				case 93u:
					Form3.smethod_33((Control)(object)NullButton, 3);
					num = (int)((num2 * 936367391) ^ 0x1303E2B3);
					continue;
				case 92u:
					Form3.smethod_29((ButtonBase)(object)button4, (FlatStyle)0);
					num = (int)((num2 * 196002687) ^ 0x6723F946);
					continue;
				case 91u:
					Form3.smethod_31((Control)(object)button5, "button5");
					num = ((int)num2 * -495129951) ^ 0x3C4CE976;
					continue;
				case 90u:
					Form3.smethod_30((Control)(object)button4, new Point(174, 137));
					num = (int)((num2 * 1332104353) ^ 0x4E3735D3);
					continue;
				case 89u:
					Form3.smethod_51((Control)(object)this, "Form3");
					num = ((int)num2 * -551535377) ^ -668809936;
					continue;
				case 88u:
					num = (int)((num2 * 28418825) ^ 0x4D2FB60C);
					continue;
				case 87u:
					Form3.smethod_30((Control)(object)textBox2, new Point(174, 26));
					num = (int)(num2 * 983697910) ^ -1501324558;
					continue;
				case 86u:
					Form3.smethod_32((Control)(object)NullButton, new Size(1, 1));
					num = (int)(num2 * 761913226) ^ -616102069;
					continue;
				case 85u:
					Form3.smethod_30((Control)(object)button1, new Point(265, 49));
					num = ((int)num2 * -1799920146) ^ -1984231625;
					continue;
				case 84u:
					Form3.smethod_33((Control)(object)label1, 7);
					num = (int)((num2 * 1069182267) ^ 0x4086AB80);
					continue;
				case 83u:
					num = (int)(num2 * 1532785902) ^ -1461375351;
					continue;
				case 82u:
					Form3.smethod_56((Control)(object)this, bool_0: false);
					num = (int)(num2 * 2109944434) ^ -867318538;
					continue;
				case 81u:
					Form3.smethod_39((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = (int)((num2 * 747804726) ^ 0x15BFF948);
					continue;
				case 80u:
					num = (int)(num2 * 1233598371) ^ -923953664;
					continue;
				case 79u:
					Form3.smethod_33((Control)(object)textBox1, 7);
					num = (int)(num2 * 1776435133) ^ -1655402228;
					continue;
				case 78u:
					Form3.smethod_35((Control)(object)button2, "Регистрация");
					Form3.smethod_34((ButtonBase)(object)button2, bool_0: true);
					num = (int)(num2 * 796182193) ^ -319585955;
					continue;
				case 77u:
					Form3.smethod_40((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -1732137933) ^ 0x4A0C13BF;
					continue;
				case 76u:
					Form3.smethod_36((Control)(object)button7, (EventHandler)Button7_Click);
					num = ((int)num2 * -1250449350) ^ -1258278440;
					continue;
				case 75u:
					Form3.smethod_38((Control)(object)button5, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 1341247437) ^ -1079087347;
					continue;
				case 74u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox1);
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button7);
					num = ((int)num2 * -1801868998) ^ -1573668434;
					continue;
				case 73u:
					Form3.smethod_26((Control)(object)label1, Color.Transparent);
					num = ((int)num2 * -388076238) ^ -393992936;
					continue;
				case 72u:
					num = ((int)num2 * -1735094829) ^ 0x23FFB1AB;
					continue;
				case 70u:
					num = ((int)num2 * -1650378175) ^ -1306205172;
					continue;
				case 69u:
					Form3.smethod_34((ButtonBase)(object)button5, bool_0: true);
					num = ((int)num2 * -1900490366) ^ 0x6C1F5F67;
					continue;
				case 68u:
					num = ((int)num2 * -361348790) ^ -1851360221;
					continue;
				case 67u:
					Form3.smethod_33((Control)(object)textBox2, 8);
					num = (int)((num2 * 1596253308) ^ 0x42AA5ACD);
					continue;
				case 66u:
					Form3.smethod_34((ButtonBase)(object)button1, bool_0: true);
					num = (int)(num2 * 1263415030) ^ -2107587684;
					continue;
				case 65u:
					Form3.smethod_29((ButtonBase)(object)button5, (FlatStyle)0);
					num = (int)((num2 * 800212845) ^ 0x39702576);
					continue;
				case 64u:
					num = ((int)num2 * -1075890846) ^ 0x2A561793;
					continue;
				case 63u:
					Form3.smethod_32((Control)(object)button7, new Size(140, 50));
					num = ((int)num2 * -1557876156) ^ -1758717138;
					continue;
				case 62u:
					button4 = Form3.smethod_20();
					num = ((int)num2 * -57898698) ^ -526241823;
					continue;
				case 61u:
					num = ((int)num2 * -1505798267) ^ 0x45640D18;
					continue;
				case 60u:
					num = ((int)num2 * -873219162) ^ 0x7BBE06BD;
					continue;
				case 59u:
					Form3.smethod_30((Control)(object)button7, new Point(174, 243));
					num = ((int)num2 * -604943195) ^ -1861980299;
					continue;
				case 58u:
					num = ((int)num2 * -1880446005) ^ 0x512F73C5;
					continue;
				case 57u:
					num = ((int)num2 * -1180003581) ^ -444672547;
					continue;
				case 56u:
					num = (int)(num2 * 187990443) ^ -1884951089;
					continue;
				case 55u:
					Form3.smethod_39((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -1485194580) ^ 0x38E00F63;
					continue;
				case 54u:
					Form3.smethod_32((Control)(object)textBox2, new Size(140, 20));
					num = ((int)num2 * -1907856970) ^ 0x14E7401B;
					continue;
				case 53u:
					Form3.smethod_34((ButtonBase)(object)button7, bool_0: true);
					num = (int)(num2 * 1365344686) ^ -526418982;
					continue;
				case 52u:
					num = ((int)num2 * -903941427) ^ 0x32C52512;
					continue;
				case 51u:
					Form3.smethod_43((ContainerControl)(object)this, new SizeF(6f, 13f));
					Form3.smethod_44((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -143750027) ^ 0x5AF21695;
					continue;
				case 50u:
					num = (int)((num2 * 164829089) ^ 0x29866325);
					continue;
				case 49u:
					num = (int)(num2 * 1304552932) ^ -1580893552;
					continue;
				case 48u:
					num = ((int)num2 * -1360281858) ^ 0x2640AB4A;
					continue;
				case 47u:
					Form3.smethod_32((Control)(object)button2, new Size(85, 21));
					num = ((int)num2 * -870204922) ^ 0x5E3C4286;
					continue;
				case 46u:
					Form3.smethod_34((ButtonBase)(object)button4, bool_0: true);
					Form3.smethod_36((Control)(object)button4, (EventHandler)Button4_Click);
					num = ((int)num2 * -236556711) ^ 0x301694B8;
					continue;
				case 45u:
					Form3.smethod_34((ButtonBase)(object)NullButton, bool_0: false);
					num = ((int)num2 * -73399560) ^ 0x61F5F905;
					continue;
				case 44u:
					errorProvider1 = Form3.smethod_23(components);
					Form3.smethod_24((ISupportInitialize)errorProvider1);
					num = (int)((num2 * 1148129420) ^ 0x74B49A4C);
					continue;
				case 43u:
					Form3.smethod_31((Control)(object)NullButton, "NullButton");
					num = (int)((num2 * 1439083870) ^ 0x66BB42D8);
					continue;
				case 42u:
					num = (int)(num2 * 1634724399) ^ -2074030772;
					continue;
				case 41u:
					Form3.smethod_32((Control)(object)button4, new Size(140, 50));
					Form3.smethod_33((Control)(object)button4, 4);
					num = (int)(num2 * 280594915) ^ -75768348;
					continue;
				case 40u:
					num = ((int)num2 * -1190574830) ^ -1598324122;
					continue;
				case 39u:
					Form3.smethod_32((Control)(object)textBox1, new Size(140, 20));
					num = (int)(num2 * 1977020466) ^ -125947389;
					continue;
				case 37u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button4);
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button2);
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button1);
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)label1);
					num = (int)(num2 * 1930687383) ^ -1454015984;
					continue;
				case 36u:
					label1 = Form3.smethod_22();
					num = (int)(num2 * 174848449) ^ -1635133236;
					continue;
				case 35u:
					Form3.smethod_31((Control)(object)button4, "button4");
					num = ((int)num2 * -773367190) ^ -1037333490;
					continue;
				case 34u:
					num = ((int)num2 * -1471290232) ^ -1955990466;
					continue;
				case 33u:
					Form3.smethod_14((Control)(object)button4, bool_0: false);
					num = ((int)num2 * -1856482053) ^ 0x6DAD8ED;
					continue;
				case 32u:
					num = ((int)num2 * -644486014) ^ -1779353628;
					continue;
				case 31u:
					textBox1 = Form3.smethod_21();
					num = (int)(num2 * 65281949) ^ -300365237;
					continue;
				case 30u:
					Form3.smethod_36((Control)(object)button5, (EventHandler)Button5_Click);
					num = ((int)num2 * -1613160191) ^ 0x506FB6CA;
					continue;
				case 29u:
					num = (int)((num2 * 1103751402) ^ 0x2B5C08CB);
					continue;
				case 28u:
					Form3.smethod_25((Control)(object)this);
					num = (int)((num2 * 2035607477) ^ 0x1F8C080D);
					continue;
				case 27u:
					Form3.smethod_32((Control)(object)button5, new Size(140, 50));
					num = (int)(num2 * 1162820071) ^ -256642487;
					continue;
				case 26u:
					Form3.smethod_29((ButtonBase)(object)button7, (FlatStyle)0);
					num = ((int)num2 * -229872056) ^ -896059009;
					continue;
				case 25u:
					Form3.smethod_30((Control)(object)label1, new Point(140, 70));
					Form3.smethod_31((Control)(object)label1, "label1");
					num = ((int)num2 * -1079803992) ^ -1451791281;
					continue;
				case 24u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button5), 0);
					num = ((int)num2 * -1975603848) ^ 0xD7D5161;
					continue;
				case 23u:
					Form3.smethod_26((Control)(object)NullButton, Color.Transparent);
					num = (int)(num2 * 1011708801) ^ -531568577;
					continue;
				case 22u:
					num = ((int)num2 * -916841866) ^ 0x645B583;
					continue;
				case 21u:
					num = ((int)num2 * -782811784) ^ 0x68E7BBE3;
					continue;
				case 20u:
					Form3.smethod_33((Control)(object)button5, 5);
					num = (int)(num2 * 413909199) ^ -1357222399;
					continue;
				case 19u:
					num = ((int)num2 * -1010608820) ^ 0x31D40B52;
					continue;
				case 18u:
					Form3.smethod_50((Form)(object)this, bool_0: false);
					num = (int)((num2 * 940418195) ^ 0x11558A49);
					continue;
				case 17u:
					Form3.smethod_41(textBox2, bool_0: true);
					num = ((int)num2 * -391803600) ^ -470701361;
					continue;
				case 16u:
					Form3.smethod_31((Control)(object)button7, "button7");
					num = (int)((num2 * 477840535) ^ 0x1FFB735F);
					continue;
				case 15u:
					Form3.smethod_52((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1821301141) ^ -1062023190;
					continue;
				case 14u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button5);
					num = (int)(num2 * 634292668) ^ -1795658107;
					continue;
				case 13u:
					num = ((int)num2 * -2127074061) ^ -1795450188;
					continue;
				case 12u:
					num = ((int)num2 * -1949071798) ^ 0x70A12CA5;
					continue;
				case 11u:
					num = (int)((num2 * 1200549867) ^ 0x43C88E26);
					continue;
				case 10u:
					Form3.smethod_38((Control)(object)label1, Form3.smethod_37("Mistral", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 814517533) ^ 0x24281344);
					continue;
				case 9u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button4), 0);
					num = (int)(num2 * 1996264547) ^ -814987788;
					continue;
				case 8u:
					num = (int)(num2 * 1674028845) ^ -1338163734;
					continue;
				case 7u:
					Form3.smethod_38((Control)(object)button7, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 2109182061) ^ 0x2BE8F3CC);
					continue;
				case 6u:
					Form3.smethod_14((Control)(object)button5, bool_0: false);
					num = (int)((num2 * 843711393) ^ 0x2B03D5EA);
					continue;
				case 5u:
					Form3.smethod_32((Control)(object)button1, new Size(49, 21));
					Form3.smethod_33((Control)(object)button1, 0);
					Form3.smethod_35((Control)(object)button1, "Вход");
					num = (int)((num2 * 106250562) ^ 0x64CEFDA8);
					continue;
				case 4u:
					Form3.smethod_38((Control)(object)button4, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1591083622) ^ 0x2E67D5D;
					continue;
				case 3u:
					Form3.smethod_35((Control)(object)button7, "Достижения");
					num = (int)((num2 * 1746110173) ^ 0x697A0FD9);
					continue;
				case 2u:
					Form3.smethod_30((Control)(object)NullButton, new Point(-1, -1));
					num = ((int)num2 * -1110401419) ^ -2146131487;
					continue;
				case 1u:
					num = (int)(num2 * 834688687) ^ -1816404382;
					continue;
				case 0u:
					Form3.smethod_26((Control)(object)this, Color.White);
					Form3.smethod_45((Form)(object)this, new Size(486, 296));
					num = (int)(num2 * 124687998) ^ -1838738396;
					continue;
				default:
					return;
				case 38u:
					break;
				case 71u:
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
