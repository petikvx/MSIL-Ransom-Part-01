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
			int num = 1288624793;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3BB127D1u) % 3u)
				{
				case 1u:
					goto IL_000f;
				case 0u:
					break;
				default:
					InitializeComponent();
					return;
				}
				break;
				IL_000f:
				num = ((int)num2 * -1333990292) ^ -1031598805;
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
			int num = 35002284;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6DE1823u) % 7u)
				{
				case 6u:
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = ((int)num2 * -863333220) ^ -1146645813;
					continue;
				case 5u:
				{
					Form4 form = new Form4();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					Form3.smethod_4((Control)(object)val);
					num = ((int)num2 * -1914510095) ^ 0x2F6035B9;
					continue;
				}
				case 4u:
					num = ((int)num2 * -1558424234) ^ -1382231460;
					continue;
				case 3u:
					num = (int)(num2 * 1439749113) ^ -712028599;
					continue;
				case 2u:
					Form3.smethod_10(val, new Point(Form3.smethod_5((Form)(object)this).X + (Form3.smethod_6((Control)(object)this) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_5((Form)(object)this).Y + (Form3.smethod_8((Control)(object)this) - Form3.smethod_9((Control)(object)val)) / 2 + 70));
					num = ((int)num2 * -1464084012) ^ 0x2FB326CD;
					continue;
				default:
					return;
				case 0u:
					break;
				case 1u:
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
			int num = 1043422138;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x469603AEu) % 6u)
				{
				case 4u:
				{
					Form2 form = new Form2();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					Form3.smethod_4((Control)(object)val);
					num = ((int)num2 * -1836301318) ^ -710155928;
					continue;
				}
				case 2u:
					Form3.smethod_0((Control)(object)NullButton);
					num = ((int)num2 * -2112680648) ^ -439164386;
					continue;
				case 1u:
					Form3.smethod_10(val, new Point(Form3.smethod_13(Form3.smethod_12((Form)(object)this)).X + (Form3.smethod_7((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_13(Form3.smethod_12((Form)(object)this)).Y + (Form3.smethod_9((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_9((Control)(object)val)) / 2));
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = (int)(num2 * 2028359931) ^ -401655334;
					continue;
				case 0u:
					num = ((int)num2 * -1388961415) ^ -797342035;
					continue;
				default:
					return;
				case 3u:
					break;
				case 5u:
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
			Form3.smethod_15((Control)(object)this, num);
			int num2 = 1239102024;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x4BFE9574u) % 7u)
				{
				case 6u:
					flag = num > 1;
					num2 = ((int)num3 * -1934308245) ^ 0x6DAD4357;
					continue;
				case 4u:
					Form3.smethod_16(Form3.smethod_12((Form)(object)this));
					Form3.smethod_17((Form3.smethod_12((Form)(object)this) as Form1).timer1);
					num2 = ((int)num3 * -50142917) ^ -665403097;
					continue;
				case 3u:
					num2 = 313659524;
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 813754155;
						num5 = 813754155;
					}
					else
					{
						num4 = 825686146;
						num5 = 825686146;
					}
					num2 = num4 ^ ((int)num3 * -1701821531);
					continue;
				}
				case 0u:
					num2 = 1588301656;
					continue;
				default:
					return;
				case 5u:
					break;
				case 1u:
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
			int num = 915359262;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAA00C06u) % 3u)
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
				num = ((int)num2 * -359346537) ^ 0x277252D3;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			goto IL_0073;
		}
		int num = 0;
		goto IL_00b2;
		IL_00a9:
		num = ((components != null) ? 1 : 0);
		goto IL_00b2;
		IL_0073:
		int num2 = 1840940074;
		goto IL_0078;
		IL_0078:
		bool flag = default(bool);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x69CDBF69u) % 8u)
			{
			case 6u:
				num2 = (int)((num3 * 613595029) ^ 0x7B53066A);
				continue;
			case 5u:
				Form3.smethod_18((IDisposable)components);
				num2 = (int)((num3 * 877917308) ^ 0x22BEC904);
				continue;
			case 4u:
				num2 = ((int)num3 * -131790316) ^ -222663914;
				continue;
			case 2u:
			{
				int num4;
				int num5;
				if (flag)
				{
					num4 = -1413194851;
					num5 = -1413194851;
				}
				else
				{
					num4 = -696536942;
					num5 = -696536942;
				}
				num2 = num4 ^ ((int)num3 * -656486503);
				continue;
			}
			case 1u:
				((Form)this).Dispose(disposing);
				num2 = 1032253373;
				continue;
			case 0u:
				break;
			default:
				return;
			case 3u:
				goto IL_00a9;
			case 7u:
				return;
			}
			break;
		}
		goto IL_0073;
		IL_00b2:
		flag = (byte)num != 0;
		num2 = 716130787;
		goto IL_0078;
	}

	private void InitializeComponent()
	{
		while (true)
		{
			int num = 1885578294;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5BA8CBDFu) % 122u)
				{
				case 121u:
					num = ((int)num2 * -1226049032) ^ 0x29668CB7;
					continue;
				case 120u:
					Form3.smethod_33((Control)(object)label1, 7);
					num = ((int)num2 * -906249129) ^ 0x8544FCA;
					continue;
				case 119u:
					Form3.smethod_29((ButtonBase)(object)button4, (FlatStyle)0);
					num = ((int)num2 * -518168718) ^ -2129860289;
					continue;
				case 118u:
					Form3.smethod_31((Control)(object)button5, "button5");
					num = ((int)num2 * -583000433) ^ 0x695B163F;
					continue;
				case 117u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button5);
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button4);
					num = ((int)num2 * -1013522989) ^ -718318739;
					continue;
				case 116u:
					Form3.smethod_29((ButtonBase)(object)NullButton, (FlatStyle)0);
					num = ((int)num2 * -1419354891) ^ 0x42F105B5;
					continue;
				case 115u:
					label1 = Form3.smethod_22();
					num = ((int)num2 * -1243033933) ^ 0x1F091FFF;
					continue;
				case 114u:
					Form3.smethod_56((Control)(object)this, bool_0: false);
					num = (int)(num2 * 2082508122) ^ -1749617301;
					continue;
				case 113u:
					Form3.smethod_55((ISupportInitialize)errorProvider1);
					num = (int)((num2 * 1527820474) ^ 0x3B5014F3);
					continue;
				case 112u:
					Form3.smethod_26((Control)(object)NullButton, Color.Transparent);
					num = ((int)num2 * -1128107102) ^ -1193955009;
					continue;
				case 111u:
					Form3.smethod_35((Control)(object)button4, "Начало игры");
					Form3.smethod_34((ButtonBase)(object)button4, bool_0: true);
					num = ((int)num2 * -439999856) ^ 0x301BF1B6;
					continue;
				case 110u:
					Form3.smethod_41(textBox2, bool_0: true);
					num = (int)(num2 * 984070578) ^ -55434407;
					continue;
				case 109u:
					Form3.smethod_35((Control)(object)label1, "QUARTO");
					num = (int)(num2 * 1498355698) ^ -1907777037;
					continue;
				case 108u:
					num = ((int)num2 * -885837222) ^ -968086689;
					continue;
				case 107u:
					Form3.smethod_34((ButtonBase)(object)NullButton, bool_0: false);
					num = (int)(num2 * 486858726) ^ -69791602;
					continue;
				case 106u:
					Form3.smethod_35((Control)(object)button1, "Вход");
					num = ((int)num2 * -419979605) ^ 0x33B6E0D8;
					continue;
				case 105u:
					Form3.smethod_32((Control)(object)button4, new Size(140, 50));
					num = ((int)num2 * -956113310) ^ 0x47E83924;
					continue;
				case 104u:
					num = ((int)num2 * -96373413) ^ -454010470;
					continue;
				case 103u:
					num = (int)((num2 * 181004328) ^ 0x245C62A4);
					continue;
				case 102u:
					button7 = Form3.smethod_20();
					num = (int)((num2 * 1173998437) ^ 0x758FAC50);
					continue;
				case 101u:
					num = (int)((num2 * 1512060846) ^ 0x46E05B83);
					continue;
				case 100u:
					Form3.smethod_33((Control)(object)button1, 0);
					num = (int)((num2 * 1352119915) ^ 0x7245B38B);
					continue;
				case 99u:
					num = ((int)num2 * -1202417829) ^ 0x1D254CED;
					continue;
				case 98u:
					Form3.smethod_30((Control)(object)button7, new Point(174, 243));
					num = ((int)num2 * -1558561451) ^ -198283798;
					continue;
				case 97u:
					num = ((int)num2 * -12377684) ^ -279168201;
					continue;
				case 96u:
					num = ((int)num2 * -906927666) ^ -252812565;
					continue;
				case 95u:
					Form3.smethod_36((Control)(object)button5, (EventHandler)Button5_Click);
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button7), 0);
					num = (int)(num2 * 1522841655) ^ -347927559;
					continue;
				case 94u:
					Form3.smethod_32((Control)(object)button2, new Size(85, 21));
					Form3.smethod_33((Control)(object)button2, 1);
					num = ((int)num2 * -304650757) ^ 0x47682B18;
					continue;
				case 93u:
					Form3.smethod_29((ButtonBase)(object)button5, (FlatStyle)0);
					num = (int)((num2 * 113187371) ^ 0xFCD21D1);
					continue;
				case 92u:
					num = ((int)num2 * -1233728457) ^ 0x54CED454;
					continue;
				case 91u:
					Form3.smethod_30((Control)(object)textBox1, new Point(174, 2));
					Form3.smethod_31((Control)(object)textBox1, "textBox1");
					num = ((int)num2 * -670992055) ^ -1954911835;
					continue;
				case 90u:
					Form3.smethod_53((Form)(object)this, bool_0: false);
					Form3.smethod_54((Form)(object)this, bool_0: true);
					num = ((int)num2 * -2026247239) ^ 0x27897D7A;
					continue;
				case 89u:
					Form3.smethod_36((Control)(object)button7, (EventHandler)Button7_Click);
					num = ((int)num2 * -701055535) ^ 0x2EF77A9D;
					continue;
				case 88u:
					num = (int)(num2 * 1286181190) ^ -1737561069;
					continue;
				case 87u:
					Form3.smethod_38((Control)(object)button5, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 547503994) ^ -467847307;
					continue;
				case 86u:
					Form3.smethod_14((Control)(object)button5, bool_0: false);
					num = ((int)num2 * -1083333783) ^ -531904541;
					continue;
				case 85u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)label1);
					num = (int)((num2 * 1943913331) ^ 0x7283368C);
					continue;
				case 84u:
					Form3.smethod_24((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -1619758761) ^ -1280801333;
					continue;
				case 83u:
					textBox2 = Form3.smethod_21();
					num = ((int)num2 * -212017726) ^ -1547091885;
					continue;
				case 82u:
					num = ((int)num2 * -1930048338) ^ -1676083538;
					continue;
				case 81u:
					Form3.smethod_31((Control)(object)button7, "button7");
					Form3.smethod_32((Control)(object)button7, new Size(140, 50));
					num = ((int)num2 * -1893747537) ^ 0x1360A625;
					continue;
				case 80u:
					Form3.smethod_35((Control)(object)button7, "Достижения");
					Form3.smethod_34((ButtonBase)(object)button7, bool_0: true);
					num = (int)(num2 * 1168219581) ^ -1715677060;
					continue;
				case 79u:
					Form3.smethod_34((ButtonBase)(object)button1, bool_0: true);
					num = (int)(num2 * 130679807) ^ -374225201;
					continue;
				case 78u:
					num = ((int)num2 * -608997176) ^ 0x24563A3E;
					continue;
				case 77u:
					num = ((int)num2 * -159928954) ^ 0x6F264A09;
					continue;
				case 76u:
					Form3.smethod_33((Control)(object)button5, 5);
					num = (int)((num2 * 2084841638) ^ 0x2545B872);
					continue;
				case 75u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button7);
					num = ((int)num2 * -1506001831) ^ 0x3D2ACA3B;
					continue;
				case 74u:
					Form3.smethod_31((Control)(object)textBox2, "textBox2");
					num = (int)((num2 * 506186510) ^ 0x1A06F5A4);
					continue;
				case 73u:
					Form3.smethod_31((Control)(object)button4, "button4");
					num = (int)(num2 * 134157835) ^ -1833012061;
					continue;
				case 72u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)NullButton), 0);
					num = (int)(num2 * 1555013232) ^ -1787992105;
					continue;
				case 71u:
					Form3.smethod_26((Control)(object)this, Color.White);
					num = ((int)num2 * -1021524495) ^ -258182162;
					continue;
				case 70u:
					Form3.smethod_32((Control)(object)label1, new Size(207, 76));
					num = ((int)num2 * -535943628) ^ 0x26782C37;
					continue;
				case 69u:
					Form3.smethod_33((Control)(object)NullButton, 3);
					num = (int)(num2 * 584373067) ^ -871601262;
					continue;
				case 68u:
					Form3.smethod_38((Control)(object)button4, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 242712856) ^ -1794536875;
					continue;
				case 67u:
					Form3.smethod_35((Control)(object)button5, "Продолжить");
					num = ((int)num2 * -160185641) ^ -495538422;
					continue;
				case 66u:
					Form3.smethod_30((Control)(object)button4, new Point(174, 137));
					num = (int)((num2 * 1931427998) ^ 0xEEE7B48);
					continue;
				case 65u:
					Form3.smethod_33((Control)(object)button7, 6);
					num = (int)(num2 * 684425661) ^ -1868254478;
					continue;
				case 64u:
					Form3.smethod_32((Control)(object)button5, new Size(140, 50));
					num = ((int)num2 * -149415597) ^ -316849127;
					continue;
				case 63u:
					num = ((int)num2 * -778084315) ^ -887707051;
					continue;
				case 62u:
					Form3.smethod_36((Control)(object)button2, (EventHandler)Button2_Click);
					num = ((int)num2 * -1659588539) ^ -1293666516;
					continue;
				case 61u:
					Form3.smethod_29((ButtonBase)(object)button7, (FlatStyle)0);
					num = (int)(num2 * 1111767192) ^ -1003865066;
					continue;
				case 60u:
					Form3.smethod_38((Control)(object)label1, Form3.smethod_37("Mistral", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1049186373) ^ -526005381;
					continue;
				case 59u:
					components = Form3.smethod_19();
					num = (int)(num2 * 1299334506) ^ -805674981;
					continue;
				case 58u:
					button5 = Form3.smethod_20();
					num = (int)((num2 * 1016311566) ^ 0x3BA2882D);
					continue;
				case 57u:
					num = (int)(num2 * 572924930) ^ -1270223339;
					continue;
				case 56u:
					Form3.smethod_34((ButtonBase)(object)button5, bool_0: true);
					num = (int)(num2 * 1803305346) ^ -404370810;
					continue;
				case 55u:
					Form3.smethod_33((Control)(object)textBox1, 7);
					num = ((int)num2 * -522643684) ^ -1314729377;
					continue;
				case 54u:
					num = ((int)num2 * -1268842897) ^ 0x172281E4;
					continue;
				case 53u:
					num = (int)(num2 * 1488163501) ^ -2060507973;
					continue;
				case 52u:
					num = (int)(num2 * 1595041447) ^ -1178678893;
					continue;
				case 51u:
					num = (int)((num2 * 544658584) ^ 0x796D510A);
					continue;
				case 50u:
					Form3.smethod_30((Control)(object)NullButton, new Point(-1, -1));
					Form3.smethod_31((Control)(object)NullButton, "NullButton");
					num = (int)((num2 * 584515687) ^ 0x28FD44C7);
					continue;
				case 49u:
					num = (int)((num2 * 80001180) ^ 0x514102FF);
					continue;
				case 48u:
					Form3.smethod_51((Control)(object)this, "Form3");
					num = ((int)num2 * -1362650735) ^ 0x7B76767A;
					continue;
				case 47u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button2);
					num = (int)((num2 * 845696478) ^ 0x34660809);
					continue;
				case 46u:
					num = ((int)num2 * -868246414) ^ 0x302D4A4F;
					continue;
				case 45u:
					Form3.smethod_31((Control)(object)button1, "button1");
					Form3.smethod_32((Control)(object)button1, new Size(49, 21));
					num = (int)((num2 * 414753467) ^ 0x56AEB4D8);
					continue;
				case 44u:
					num = (int)((num2 * 461324657) ^ 0x70CD160B);
					continue;
				case 43u:
					num = (int)((num2 * 578061000) ^ 0xA51890A);
					continue;
				case 42u:
					Form3.smethod_30((Control)(object)textBox2, new Point(174, 26));
					num = ((int)num2 * -45189034) ^ 0x5CF0C73C;
					continue;
				case 41u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button4), 0);
					num = ((int)num2 * -1970777667) ^ 0x5DA3C6E2;
					continue;
				case 40u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button5), 0);
					num = ((int)num2 * -477539183) ^ -648206363;
					continue;
				case 39u:
					Form3.smethod_14((Control)(object)button4, bool_0: false);
					num = (int)(num2 * 1566568519) ^ -1683538667;
					continue;
				case 37u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -1407728680) ^ 0x14FDFA64;
					continue;
				case 36u:
					Form3.smethod_30((Control)(object)button5, new Point(174, 190));
					num = ((int)num2 * -384564070) ^ 0x300915A4;
					continue;
				case 35u:
					num = (int)((num2 * 267968516) ^ 0x513EAD9A);
					continue;
				case 34u:
					NullButton = Form3.smethod_20();
					num = (int)((num2 * 1996996730) ^ 0x1463E75);
					continue;
				case 33u:
					Form3.smethod_36((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -61624732) ^ 0x4CB610C3;
					continue;
				case 32u:
					Form3.smethod_26((Control)(object)label1, Color.Transparent);
					num = ((int)num2 * -953622934) ^ -1328883291;
					continue;
				case 31u:
					Form3.smethod_33((Control)(object)textBox2, 8);
					num = ((int)num2 * -284219255) ^ -1752632680;
					continue;
				case 30u:
					errorProvider1 = Form3.smethod_23(components);
					num = ((int)num2 * -1615003152) ^ 0x2119FBD9;
					continue;
				case 29u:
					Form3.smethod_45((Form)(object)this, new Size(486, 296));
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox2);
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox1);
					num = ((int)num2 * -435609749) ^ 0x1B628FD7;
					continue;
				case 28u:
					Form3.smethod_32((Control)(object)textBox2, new Size(140, 20));
					num = (int)(num2 * 985333885) ^ -1604332730;
					continue;
				case 27u:
					Form3.smethod_49((Form)(object)this, bool_0: false);
					Form3.smethod_50((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1291095803) ^ -506169532;
					continue;
				case 26u:
					Form3.smethod_39((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = (int)(num2 * 1660051683) ^ -13658223;
					continue;
				case 25u:
					Form3.smethod_52((Form)(object)this, bool_0: false);
					num = (int)((num2 * 1613182313) ^ 0x55C6988);
					continue;
				case 24u:
					Form3.smethod_43((ContainerControl)(object)this, new SizeF(6f, 13f));
					Form3.smethod_44((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -1574279856) ^ 0xA22F78C;
					continue;
				case 23u:
					Form3.smethod_32((Control)(object)textBox1, new Size(140, 20));
					num = (int)(num2 * 1364949400) ^ -1625094619;
					continue;
				case 22u:
					Form3.smethod_30((Control)(object)label1, new Point(140, 70));
					num = (int)(num2 * 745367761) ^ -208553835;
					continue;
				case 21u:
					Form3.smethod_35((Control)(object)button2, "Регистрация");
					Form3.smethod_34((ButtonBase)(object)button2, bool_0: true);
					num = (int)(num2 * 1777812495) ^ -245441488;
					continue;
				case 20u:
					Form3.smethod_31((Control)(object)button2, "button2");
					num = (int)(num2 * 1004671952) ^ -345291782;
					continue;
				case 19u:
					Form3.smethod_38((Control)(object)button7, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 1178609929) ^ 0x155BF630);
					continue;
				case 18u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)NullButton);
					num = ((int)num2 * -366676882) ^ -1475623380;
					continue;
				case 17u:
					Form3.smethod_33((Control)(object)button4, 4);
					num = ((int)num2 * -430746431) ^ -1826411195;
					continue;
				case 16u:
					num = ((int)num2 * -1687117376) ^ -2018197644;
					continue;
				case 15u:
					Form3.smethod_36((Control)(object)button4, (EventHandler)Button4_Click);
					num = (int)(num2 * 218467774) ^ -1450160357;
					continue;
				case 14u:
					button1 = Form3.smethod_20();
					button2 = Form3.smethod_20();
					button4 = Form3.smethod_20();
					num = (int)((num2 * 2004018214) ^ 0x12886433);
					continue;
				case 12u:
					num = (int)(num2 * 189171947) ^ -995005474;
					continue;
				case 11u:
					num = (int)(num2 * 1539971082) ^ -1748617130;
					continue;
				case 10u:
					Form3.smethod_25((Control)(object)this);
					num = ((int)num2 * -1701261323) ^ -2072874208;
					continue;
				case 9u:
					Form3.smethod_48((Form)(object)this, (FormBorderStyle)0);
					num = ((int)num2 * -67386469) ^ 0x6DC3AAF;
					continue;
				case 8u:
					Form3.smethod_32((Control)(object)NullButton, new Size(1, 1));
					num = ((int)num2 * -35401313) ^ 0x3D9C2C44;
					continue;
				case 7u:
					num = ((int)num2 * -659722183) ^ -1920977420;
					continue;
				case 6u:
					Form3.smethod_57((Control)(object)this);
					num = ((int)num2 * -1086691317) ^ -582544722;
					continue;
				case 5u:
					Form3.smethod_30((Control)(object)button1, new Point(265, 49));
					num = ((int)num2 * -1756236775) ^ -1927517439;
					continue;
				case 4u:
					Form3.smethod_40((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -152385524) ^ -567038050;
					continue;
				case 3u:
					Form3.smethod_30((Control)(object)button2, new Point(174, 49));
					num = ((int)num2 * -486145480) ^ -31315195;
					continue;
				case 2u:
					Form3.smethod_31((Control)(object)label1, "label1");
					num = (int)((num2 * 1165041451) ^ 0x6677F92F);
					continue;
				case 1u:
					textBox1 = Form3.smethod_21();
					num = (int)((num2 * 1531917513) ^ 0x34E795C7);
					continue;
				case 0u:
					Form3.smethod_39((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					Form3.smethod_42(errorProvider1, (ContainerControl)(object)this);
					num = ((int)num2 * -2128770128) ^ 0x9783744;
					continue;
				default:
					return;
				case 38u:
					break;
				case 13u:
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
