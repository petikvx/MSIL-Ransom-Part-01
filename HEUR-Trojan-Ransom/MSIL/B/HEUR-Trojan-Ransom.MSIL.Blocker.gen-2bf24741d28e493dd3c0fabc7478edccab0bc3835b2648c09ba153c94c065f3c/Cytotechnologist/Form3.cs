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
			int num = 47736256;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6F722126u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -861896916) ^ -339343785;
					continue;
				case 1u:
					InitializeComponent();
					num = (int)(num2 * 488764248) ^ -1822448326;
					continue;
				default:
					return;
				case 3u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		Form3.smethod_0((Control)(object)NullButton);
		Form val = default(Form);
		while (true)
		{
			int num = 501529625;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC1E24ACu) % 7u)
				{
				case 5u:
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = ((int)num2 * -1329006697) ^ 0x55F2FDCB;
					continue;
				case 4u:
					Form3.smethod_1(errorProvider1);
					num = ((int)num2 * -790814219) ^ 0x1A3E4C87;
					continue;
				case 3u:
					Form3.smethod_10(val, new Point(Form3.smethod_5((Form)(object)this).X + (Form3.smethod_6((Control)(object)this) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_5((Form)(object)this).Y + (Form3.smethod_8((Control)(object)this) - Form3.smethod_9((Control)(object)val)) / 2 + 70));
					num = ((int)num2 * -1640843891) ^ -1886159576;
					continue;
				case 1u:
					num = (int)((num2 * 1619369280) ^ 0x1269DB1B);
					continue;
				case 0u:
				{
					Form4 form = new Form4();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					Form3.smethod_4((Control)(object)val);
					num = (int)(num2 * 662121582) ^ -184183398;
					continue;
				}
				default:
					return;
				case 2u:
					break;
				case 6u:
					return;
				}
				break;
			}
		}
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		Form3.smethod_0((Control)(object)NullButton);
		Form val = default(Form);
		while (true)
		{
			int num = 108776349;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6AEC513u) % 5u)
				{
				case 4u:
				{
					Form2 form = new Form2();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					Form3.smethod_4((Control)(object)val);
					num = (int)(num2 * 1125257263) ^ -1914919678;
					continue;
				}
				case 1u:
					Form3.smethod_10(val, new Point(Form3.smethod_13(Form3.smethod_12((Form)(object)this)).X + (Form3.smethod_7((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_13(Form3.smethod_12((Form)(object)this)).Y + (Form3.smethod_9((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_9((Control)(object)val)) / 2));
					num = (int)((num2 * 1865800611) ^ 0x2D98EC5A);
					continue;
				case 0u:
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = (int)((num2 * 377536086) ^ 0x4AABB81C);
					continue;
				default:
					return;
				case 3u:
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
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		int num3 = default(int);
		while (true)
		{
			int num = 686394752;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2D8BD100u) % 9u)
				{
				case 8u:
					num = (int)((num2 * 1977384018) ^ 0x783ED57C);
					continue;
				case 7u:
					Form3.smethod_17((Form3.smethod_12((Form)(object)this) as Form1).timer1);
					num = (int)((num2 * 740941243) ^ 0x6E6115D1);
					continue;
				case 5u:
					num3 = Form3.smethod_8((Control)(object)this) - 1;
					num = 618266762;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (num3 <= 1)
					{
						num4 = 1020564917;
						num5 = 1020564917;
					}
					else
					{
						num4 = 782346452;
						num5 = 782346452;
					}
					num = num4 ^ ((int)num2 * -1618913004);
					continue;
				}
				case 3u:
					num = 611415164;
					continue;
				case 2u:
					Form3.smethod_15((Control)(object)this, num3);
					num = (int)(num2 * 1679128221) ^ -1403030412;
					continue;
				case 0u:
					Form3.smethod_16(Form3.smethod_12((Form)(object)this));
					num = (int)((num2 * 1784162207) ^ 0x7922B0BA);
					continue;
				default:
					return;
				case 6u:
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
		Form3.smethod_0((Control)(object)NullButton);
		Form3.smethod_14((Control)(object)button7, bool_0: false);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			goto IL_0023;
		}
		int num = 0;
		goto IL_00c6;
		IL_00bd:
		num = ((components != null) ? 1 : 0);
		goto IL_00c6;
		IL_0023:
		int num2 = -241720762;
		goto IL_0087;
		IL_0087:
		bool flag = default(bool);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0xD57702BDu) % 9u)
			{
			case 8u:
				Form3.smethod_18((IDisposable)components);
				num2 = ((int)num3 * -404113900) ^ 0x3A9CB866;
				continue;
			case 7u:
				break;
			case 6u:
				num2 = ((int)num3 * -579879205) ^ -1676532697;
				continue;
			case 5u:
				num2 = ((int)num3 * -983206183) ^ 0x2C5A0A40;
				continue;
			case 4u:
			{
				int num4;
				int num5;
				if (flag)
				{
					num4 = 521471376;
					num5 = 521471376;
				}
				else
				{
					num4 = 105204047;
					num5 = 105204047;
				}
				num2 = num4 ^ (int)(num3 * 64036561);
				continue;
			}
			case 3u:
				num2 = (int)((num3 * 790374765) ^ 0x31067B05);
				continue;
			case 0u:
				((Form)this).Dispose(disposing);
				num2 = -668008072;
				continue;
			default:
				return;
			case 2u:
				goto IL_00bd;
			case 1u:
				return;
			}
			break;
		}
		goto IL_0023;
		IL_00c6:
		flag = (byte)num != 0;
		num2 = -1604970363;
		goto IL_0087;
	}

	private void InitializeComponent()
	{
		while (true)
		{
			int num = 1527102535;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x541551EEu) % 128u)
				{
				case 127u:
					Form3.smethod_38((Control)(object)label1, Form3.smethod_37("Mistral", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form3.smethod_30((Control)(object)label1, new Point(140, 70));
					num = (int)((num2 * 320098665) ^ 0x7066B77C);
					continue;
				case 126u:
					Form3.smethod_48((Form)(object)this, (FormBorderStyle)0);
					Form3.smethod_49((Form)(object)this, bool_0: false);
					num = (int)((num2 * 1588122163) ^ 0x10FE7D30);
					continue;
				case 125u:
					num = (int)(num2 * 2084462891) ^ -627129663;
					continue;
				case 124u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button7), 0);
					num = (int)(num2 * 260630636) ^ -1176723980;
					continue;
				case 123u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox1);
					num = (int)(num2 * 1928006614) ^ -729073301;
					continue;
				case 122u:
					num = ((int)num2 * -1084971334) ^ 0x3F84B6E0;
					continue;
				case 121u:
					Form3.smethod_33((Control)(object)button4, 4);
					num = (int)(num2 * 1066002935) ^ -197125828;
					continue;
				case 120u:
					num = ((int)num2 * -1759195407) ^ 0x6B7898B0;
					continue;
				case 119u:
					Form3.smethod_40((Control)(object)label1, bool_0: true);
					num = (int)((num2 * 1284437291) ^ 0x77D48F05);
					continue;
				case 118u:
					Form3.smethod_31((Control)(object)textBox1, "textBox1");
					num = ((int)num2 * -893971723) ^ 0x39CE3671;
					continue;
				case 117u:
					num = ((int)num2 * -737231452) ^ -1755803690;
					continue;
				case 116u:
					Form3.smethod_31((Control)(object)button2, "button2");
					num = (int)((num2 * 2030386951) ^ 0x2B8E0F71);
					continue;
				case 115u:
					Form3.smethod_31((Control)(object)textBox2, "textBox2");
					num = ((int)num2 * -506095309) ^ -1608291944;
					continue;
				case 114u:
					Form3.smethod_26((Control)(object)label1, Color.Transparent);
					num = (int)(num2 * 271053940) ^ -502741959;
					continue;
				case 113u:
					num = (int)(num2 * 1162257543) ^ -743753015;
					continue;
				case 112u:
					num = (int)((num2 * 1020474704) ^ 0x6628CAB3);
					continue;
				case 111u:
					Form3.smethod_30((Control)(object)textBox2, new Point(174, 26));
					num = ((int)num2 * -1249861114) ^ 0x22F086C6;
					continue;
				case 110u:
					Form3.smethod_38((Control)(object)button4, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form3.smethod_30((Control)(object)button4, new Point(174, 137));
					num = (int)((num2 * 518731124) ^ 0x1D3483BF);
					continue;
				case 109u:
					Form3.smethod_35((Control)(object)button4, "Начало игры");
					num = ((int)num2 * -694195366) ^ -1235645098;
					continue;
				case 108u:
					num = (int)((num2 * 652978293) ^ 0x384D11ED);
					continue;
				case 107u:
					Form3.smethod_35((Control)(object)button1, "Вход");
					num = ((int)num2 * -726563846) ^ 0x130FAEA9;
					continue;
				case 106u:
					Form3.smethod_34((ButtonBase)(object)button4, bool_0: true);
					num = ((int)num2 * -1035340541) ^ -2145965667;
					continue;
				case 105u:
					Form3.smethod_43((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)(num2 * 246571932) ^ -2068104170;
					continue;
				case 104u:
					num = (int)((num2 * 1590826832) ^ 0x41088D15);
					continue;
				case 103u:
					Form3.smethod_32((Control)(object)label1, new Size(207, 76));
					num = (int)(num2 * 1700908109) ^ -16261105;
					continue;
				case 102u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button2);
					num = ((int)num2 * -357673778) ^ -1815518193;
					continue;
				case 101u:
					num = ((int)num2 * -1441849114) ^ -467347307;
					continue;
				case 100u:
					num = ((int)num2 * -1196654637) ^ 0x18BE1B4C;
					continue;
				case 99u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox2);
					num = (int)(num2 * 594891937) ^ -478014139;
					continue;
				case 98u:
					num = ((int)num2 * -1872516625) ^ 0x384C27F6;
					continue;
				case 97u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)NullButton), 0);
					num = ((int)num2 * -1409586473) ^ -819383650;
					continue;
				case 96u:
					num = (int)(num2 * 1880778608) ^ -121140855;
					continue;
				case 95u:
					Form3.smethod_33((Control)(object)button2, 1);
					num = ((int)num2 * -84783146) ^ -445937010;
					continue;
				case 94u:
					Form3.smethod_36((Control)(object)button2, (EventHandler)Button2_Click);
					num = (int)(num2 * 805626168) ^ -2026728085;
					continue;
				case 93u:
					Form3.smethod_36((Control)(object)button7, (EventHandler)Button7_Click);
					num = ((int)num2 * -1781460050) ^ 0x682C81F8;
					continue;
				case 92u:
					num = (int)((num2 * 1505603483) ^ 0x7996D5EB);
					continue;
				case 91u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button5), 0);
					num = (int)(num2 * 496198204) ^ -1954888037;
					continue;
				case 90u:
					Form3.smethod_44((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 2005173325) ^ 0x153F5DFA);
					continue;
				case 89u:
					num = (int)((num2 * 1690789847) ^ 0x432DC49E);
					continue;
				case 88u:
					num = ((int)num2 * -307079488) ^ -787558683;
					continue;
				case 87u:
					num = (int)(num2 * 76312492) ^ -874491884;
					continue;
				case 86u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button4);
					num = (int)((num2 * 699478658) ^ 0xA2FAF20);
					continue;
				case 85u:
					num = ((int)num2 * -2042529435) ^ 0x3A03EFC4;
					continue;
				case 84u:
					button1 = Form3.smethod_20();
					button2 = Form3.smethod_20();
					button4 = Form3.smethod_20();
					button5 = Form3.smethod_20();
					button7 = Form3.smethod_20();
					textBox1 = Form3.smethod_21();
					label1 = Form3.smethod_22();
					textBox2 = Form3.smethod_21();
					num = ((int)num2 * -1983879847) ^ -348877481;
					continue;
				case 83u:
					Form3.smethod_51((Control)(object)this, "Form3");
					Form3.smethod_52((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1598738196) ^ -819503047;
					continue;
				case 82u:
					Form3.smethod_30((Control)(object)button5, new Point(174, 190));
					num = (int)((num2 * 1586062629) ^ 0x6F913D03);
					continue;
				case 81u:
					num = ((int)num2 * -1280748793) ^ -1039402057;
					continue;
				case 80u:
					Form3.smethod_32((Control)(object)NullButton, new Size(1, 1));
					num = ((int)num2 * -1528976727) ^ -937401309;
					continue;
				case 79u:
					Form3.smethod_57((Control)(object)this);
					num = ((int)num2 * -894759592) ^ -1041361395;
					continue;
				case 78u:
					Form3.smethod_41(textBox2, bool_0: true);
					num = (int)(num2 * 1373894185) ^ -339593624;
					continue;
				case 77u:
					num = ((int)num2 * -498215312) ^ 0x1E39E8F9;
					continue;
				case 76u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -2118818461) ^ -1913108522;
					continue;
				case 74u:
					Form3.smethod_29((ButtonBase)(object)button7, (FlatStyle)0);
					num = ((int)num2 * -272342866) ^ -1878304669;
					continue;
				case 73u:
					num = (int)(num2 * 1632244441) ^ -1620879837;
					continue;
				case 72u:
					Form3.smethod_33((Control)(object)button7, 6);
					num = (int)((num2 * 1080904501) ^ 0x5CCE66BB);
					continue;
				case 71u:
					num = ((int)num2 * -1360832492) ^ 0x53C5C3B9;
					continue;
				case 70u:
					Form3.smethod_34((ButtonBase)(object)button5, bool_0: true);
					num = ((int)num2 * -1372810817) ^ -84529802;
					continue;
				case 69u:
					Form3.smethod_33((Control)(object)textBox1, 7);
					num = ((int)num2 * -1842279788) ^ -752606190;
					continue;
				case 68u:
					num = ((int)num2 * -544735523) ^ -1037547495;
					continue;
				case 67u:
					Form3.smethod_50((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1711820973) ^ 0x1F2CF604;
					continue;
				case 66u:
					Form3.smethod_34((ButtonBase)(object)button2, bool_0: true);
					num = (int)(num2 * 1177351323) ^ -1989813434;
					continue;
				case 65u:
					Form3.smethod_38((Control)(object)button7, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 276321) ^ 0x2A05B97);
					continue;
				case 63u:
					num = ((int)num2 * -520421616) ^ -1936970774;
					continue;
				case 62u:
					Form3.smethod_14((Control)(object)button5, bool_0: false);
					num = (int)((num2 * 575548517) ^ 0x2DAC62DF);
					continue;
				case 61u:
					Form3.smethod_35((Control)(object)button7, "Достижения");
					Form3.smethod_34((ButtonBase)(object)button7, bool_0: true);
					num = (int)((num2 * 1355571385) ^ 0x2654990B);
					continue;
				case 60u:
					num = (int)(num2 * 1800185008) ^ -869938426;
					continue;
				case 59u:
					Form3.smethod_33((Control)(object)button1, 0);
					num = ((int)num2 * -722878415) ^ -1599136767;
					continue;
				case 58u:
					num = (int)(num2 * 572016994) ^ -1712132903;
					continue;
				case 57u:
					num = (int)((num2 * 180810324) ^ 0x13B09CF5);
					continue;
				case 56u:
					Form3.smethod_56((Control)(object)this, bool_0: false);
					num = (int)((num2 * 1856777578) ^ 0x48DED007);
					continue;
				case 55u:
					Form3.smethod_31((Control)(object)button5, "button5");
					num = (int)(num2 * 1009579636) ^ -516262453;
					continue;
				case 54u:
					Form3.smethod_34((ButtonBase)(object)NullButton, bool_0: false);
					Form3.smethod_30((Control)(object)button1, new Point(265, 49));
					Form3.smethod_31((Control)(object)button1, "button1");
					num = ((int)num2 * -1553707680) ^ 0x4A1A4C22;
					continue;
				case 53u:
					Form3.smethod_30((Control)(object)NullButton, new Point(-1, -1));
					num = (int)(num2 * 79889444) ^ -953244919;
					continue;
				case 52u:
					Form3.smethod_33((Control)(object)label1, 7);
					num = (int)((num2 * 557572140) ^ 0x28317A96);
					continue;
				case 51u:
					num = (int)(num2 * 1217962715) ^ -1374032448;
					continue;
				case 50u:
					num = (int)(num2 * 1870158289) ^ -1126361521;
					continue;
				case 49u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)label1);
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)NullButton);
					num = ((int)num2 * -306133254) ^ -1454571062;
					continue;
				case 48u:
					Form3.smethod_32((Control)(object)textBox1, new Size(140, 20));
					num = ((int)num2 * -1085892588) ^ -92164021;
					continue;
				case 47u:
					Form3.smethod_34((ButtonBase)(object)button1, bool_0: true);
					num = (int)(num2 * 323421439) ^ -1482763645;
					continue;
				case 46u:
					Form3.smethod_29((ButtonBase)(object)button4, (FlatStyle)0);
					num = (int)((num2 * 1652663184) ^ 0x5D0C54DF);
					continue;
				case 45u:
					Form3.smethod_30((Control)(object)textBox1, new Point(174, 2));
					num = (int)(num2 * 365678218) ^ -1993765670;
					continue;
				case 44u:
					Form3.smethod_32((Control)(object)button5, new Size(140, 50));
					num = (int)((num2 * 10877633) ^ 0x6478B697);
					continue;
				case 43u:
					Form3.smethod_53((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1997736430) ^ 0x6B6A4CF4;
					continue;
				case 42u:
					Form3.smethod_35((Control)(object)button5, "Продолжить");
					num = ((int)num2 * -1675764855) ^ 0x7242DE52;
					continue;
				case 41u:
					components = Form3.smethod_19();
					NullButton = Form3.smethod_20();
					num = ((int)num2 * -1575559488) ^ 0x2AA6E87A;
					continue;
				case 40u:
					Form3.smethod_36((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)(num2 * 1563676076) ^ -1588634475;
					continue;
				case 39u:
					Form3.smethod_36((Control)(object)button4, (EventHandler)Button4_Click);
					num = ((int)num2 * -1399727632) ^ -1767438144;
					continue;
				case 38u:
					Form3.smethod_39((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					Form3.smethod_42(errorProvider1, (ContainerControl)(object)this);
					num = ((int)num2 * -1508741875) ^ 0x75E6A1E9;
					continue;
				case 37u:
					num = (int)(num2 * 1544205893) ^ -285330578;
					continue;
				case 36u:
					num = (int)((num2 * 541266792) ^ 0x15B9BC25);
					continue;
				case 35u:
					Form3.smethod_33((Control)(object)button5, 5);
					num = (int)((num2 * 1319304382) ^ 0xE032A6E);
					continue;
				case 34u:
					Form3.smethod_36((Control)(object)button5, (EventHandler)Button5_Click);
					num = (int)(num2 * 321980386) ^ -863004138;
					continue;
				case 33u:
					Form3.smethod_29((ButtonBase)(object)button5, (FlatStyle)0);
					num = (int)(num2 * 1775285708) ^ -52502493;
					continue;
				case 32u:
					num = (int)(num2 * 780458143) ^ -1306151005;
					continue;
				case 31u:
					Form3.smethod_32((Control)(object)textBox2, new Size(140, 20));
					Form3.smethod_33((Control)(object)textBox2, 8);
					num = (int)(num2 * 1916804255) ^ -365604277;
					continue;
				case 30u:
					Form3.smethod_54((Form)(object)this, bool_0: true);
					num = (int)((num2 * 284576137) ^ 0x5797ECF0);
					continue;
				case 29u:
					Form3.smethod_33((Control)(object)NullButton, 3);
					num = (int)(num2 * 1472866770) ^ -538477294;
					continue;
				case 28u:
					num = (int)(num2 * 1015705020) ^ -1664448672;
					continue;
				case 27u:
					Form3.smethod_30((Control)(object)button2, new Point(174, 49));
					num = ((int)num2 * -837642896) ^ -1941232255;
					continue;
				case 26u:
					num = (int)(num2 * 1937404539) ^ -1485962844;
					continue;
				case 25u:
					num = ((int)num2 * -1346046507) ^ -1385595882;
					continue;
				case 24u:
					Form3.smethod_39((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -448413205) ^ -1763135087;
					continue;
				case 23u:
					Form3.smethod_32((Control)(object)button7, new Size(140, 50));
					num = (int)((num2 * 2021190575) ^ 0x4592839F);
					continue;
				case 22u:
					num = (int)((num2 * 431266593) ^ 0x5E0F42CA);
					continue;
				case 21u:
					num = ((int)num2 * -1316562779) ^ 0xB88D2F5;
					continue;
				case 20u:
					Form3.smethod_32((Control)(object)button1, new Size(49, 21));
					num = ((int)num2 * -605567848) ^ -632556619;
					continue;
				case 19u:
					Form3.smethod_31((Control)(object)NullButton, "NullButton");
					num = ((int)num2 * -100420902) ^ 0x7EADE6BD;
					continue;
				case 18u:
					Form3.smethod_14((Control)(object)button4, bool_0: false);
					num = (int)((num2 * 748528978) ^ 0x631E83A8);
					continue;
				case 17u:
					Form3.smethod_38((Control)(object)button5, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -811716726) ^ 0x5F19B416;
					continue;
				case 16u:
					Form3.smethod_55((ISupportInitialize)errorProvider1);
					num = (int)((num2 * 1828917505) ^ 0x65854CC6);
					continue;
				case 15u:
					Form3.smethod_32((Control)(object)button2, new Size(85, 21));
					num = ((int)num2 * -1053994616) ^ 0x6ECEE47A;
					continue;
				case 14u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button7);
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button5);
					num = ((int)num2 * -1564855499) ^ -1613573410;
					continue;
				case 13u:
					errorProvider1 = Form3.smethod_23(components);
					Form3.smethod_24((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -707237438) ^ 0x33C8E98E;
					continue;
				case 12u:
					num = (int)(num2 * 1721993039) ^ -1556436402;
					continue;
				case 11u:
					Form3.smethod_30((Control)(object)button7, new Point(174, 243));
					Form3.smethod_31((Control)(object)button7, "button7");
					num = (int)(num2 * 1203252881) ^ -1540255787;
					continue;
				case 10u:
					Form3.smethod_35((Control)(object)button2, "Регистрация");
					num = ((int)num2 * -1349527182) ^ -965259176;
					continue;
				case 9u:
					Form3.smethod_31((Control)(object)button4, "button4");
					Form3.smethod_32((Control)(object)button4, new Size(140, 50));
					num = ((int)num2 * -1271344432) ^ -2069574373;
					continue;
				case 8u:
					Form3.smethod_35((Control)(object)label1, "QUARTO");
					num = (int)((num2 * 1596101366) ^ 0x4A4A6F31);
					continue;
				case 7u:
					Form3.smethod_29((ButtonBase)(object)NullButton, (FlatStyle)0);
					num = (int)(num2 * 1277474694) ^ -1021391651;
					continue;
				case 6u:
					Form3.smethod_26((Control)(object)this, Color.White);
					Form3.smethod_45((Form)(object)this, new Size(486, 296));
					num = ((int)num2 * -423711973) ^ -1633875793;
					continue;
				case 5u:
					Form3.smethod_31((Control)(object)label1, "label1");
					num = (int)((num2 * 1772055940) ^ 0x499EE49A);
					continue;
				case 4u:
					num = ((int)num2 * -1711516067) ^ -609011008;
					continue;
				case 3u:
					Form3.smethod_25((Control)(object)this);
					Form3.smethod_26((Control)(object)NullButton, Color.Transparent);
					num = (int)((num2 * 453548937) ^ 0x7CCD1794);
					continue;
				case 2u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button4), 0);
					num = ((int)num2 * -1721468539) ^ 0x181AA0CA;
					continue;
				case 1u:
					num = ((int)num2 * -1120439127) ^ -1653012650;
					continue;
				case 0u:
					num = (int)(num2 * 397203058) ^ -1834586375;
					continue;
				default:
					return;
				case 64u:
					break;
				case 75u:
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
