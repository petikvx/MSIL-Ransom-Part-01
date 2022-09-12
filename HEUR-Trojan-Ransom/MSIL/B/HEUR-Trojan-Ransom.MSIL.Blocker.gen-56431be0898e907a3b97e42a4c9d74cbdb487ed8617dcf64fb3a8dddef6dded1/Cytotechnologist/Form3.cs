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
			int num = 1032194818;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3DC2535Au) % 11u)
				{
				case 10u:
				{
					Form4 form = new Form4();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					num = (int)((num2 * 1243547394) ^ 0x55AB5D8);
					continue;
				}
				case 9u:
					num = (int)(num2 * 843527688) ^ -335992445;
					continue;
				case 7u:
					Form3.smethod_0((Control)(object)NullButton);
					num = ((int)num2 * -1477709118) ^ 0x531C49C8;
					continue;
				case 6u:
					num = ((int)num2 * -1518793641) ^ -1722053047;
					continue;
				case 5u:
					Form3.smethod_10(val, new Point(Form3.smethod_5((Form)(object)this).X + (Form3.smethod_6((Control)(object)this) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_5((Form)(object)this).Y + (Form3.smethod_8((Control)(object)this) - Form3.smethod_9((Control)(object)val)) / 2 + 70));
					num = ((int)num2 * -1564835988) ^ -976770998;
					continue;
				case 4u:
					num = (int)((num2 * 931442605) ^ 0x42C9C7EA);
					continue;
				case 3u:
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = ((int)num2 * -1256299294) ^ 0x117EA177;
					continue;
				case 2u:
					Form3.smethod_1(errorProvider1);
					num = (int)((num2 * 1899697290) ^ 0x659F8D84);
					continue;
				case 1u:
					Form3.smethod_4((Control)(object)val);
					num = (int)(num2 * 2099083192) ^ -53943599;
					continue;
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

	private void Button4_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 1037597262;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4A608FEu) % 6u)
				{
				case 5u:
					num = ((int)num2 * -2100258664) ^ 0x641134A9;
					continue;
				case 4u:
				{
					Form2 form = new Form2();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					Form val = (Form)(object)form;
					Form3.smethod_4((Control)(object)val);
					Form3.smethod_10(val, new Point(Form3.smethod_13(Form3.smethod_12((Form)(object)this)).X + (Form3.smethod_7((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_13(Form3.smethod_12((Form)(object)this)).Y + (Form3.smethod_9((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_9((Control)(object)val)) / 2));
					num = ((int)num2 * -307774505) ^ 0x31DB1A23;
					continue;
				}
				case 2u:
					Form3.smethod_0((Control)(object)NullButton);
					num = ((int)num2 * -2035527716) ^ -147425178;
					continue;
				case 1u:
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = (int)((num2 * 955786125) ^ 0x48CEE831);
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

	public void Button_Continue()
	{
		Form3.smethod_14((Control)(object)button5, bool_0: true);
		while (true)
		{
			int num = 961979355;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3AA5D73Bu) % 3u)
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
				num = ((int)num2 * -672421726) ^ -1308436025;
			}
		}
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = Form3.smethod_8((Control)(object)this) - 1;
			int num2 = -121730544;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x9111F0EFu) % 8u)
				{
				case 7u:
					Form3.smethod_15((Control)(object)this, num);
					num2 = ((int)num3 * -855012932) ^ -315908531;
					continue;
				case 6u:
					num2 = ((int)num3 * -1235721686) ^ -1824964865;
					continue;
				case 5u:
					num2 = -1167351140;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (num <= 1)
					{
						num4 = 1074630550;
						num5 = 1074630550;
					}
					else
					{
						num4 = 626877018;
						num5 = 626877018;
					}
					num2 = num4 ^ ((int)num3 * -1822209044);
					continue;
				}
				case 1u:
					Form3.smethod_16(Form3.smethod_12((Form)(object)this));
					Form3.smethod_17((Form3.smethod_12((Form)(object)this) as Form1).timer1);
					num2 = ((int)num3 * -2105634139) ^ 0x2C88B648;
					continue;
				case 0u:
					num2 = -372550454;
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

	private void Button1_Click(object sender, EventArgs e)
	{
	}

	private void TextBox_TextChanged(object sender, EventArgs e)
	{
		Form3.smethod_1(errorProvider1);
		while (true)
		{
			int num = -1750451507;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF3A19313u) % 3u)
				{
				case 1u:
					goto IL_000d;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_000d:
				num = ((int)num2 * -649989908) ^ -1890949449;
			}
		}
	}

	public void ContinueLock()
	{
		Form3.smethod_14((Control)(object)button5, bool_0: false);
		while (true)
		{
			int num = 701810207;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x282387Cu) % 3u)
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
				num = (int)(num2 * 237233035) ^ -1958295303;
			}
		}
	}

	public void AchivUnlock()
	{
		Form3.smethod_14((Control)(object)button7, bool_0: true);
		while (true)
		{
			int num = -1214472024;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA330878Bu) % 3u)
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
				num = ((int)num2 * -54875314) ^ -1925153452;
			}
		}
	}

	private void Button7_Click(object sender, EventArgs e)
	{
		Form3.smethod_0((Control)(object)NullButton);
		while (true)
		{
			int num = 541792059;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x64BD51E4u) % 3u)
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
				Form3.smethod_14((Control)(object)button7, bool_0: false);
				num = ((int)num2 * -1001660620) ^ 0x3376794C;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			goto IL_0065;
		}
		int num = 0;
		goto IL_00c6;
		IL_00c6:
		bool flag = (byte)num != 0;
		int num2 = 1509723884;
		goto IL_0087;
		IL_0065:
		num2 = 1567502387;
		goto IL_0087;
		IL_0087:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x43675A89u) % 9u)
			{
			case 8u:
			{
				int num4;
				int num5;
				if (!flag)
				{
					num4 = -1690805515;
					num5 = -1690805515;
				}
				else
				{
					num4 = -1146838452;
					num5 = -1146838452;
				}
				num2 = num4 ^ (int)(num3 * 145079713);
				continue;
			}
			case 7u:
				Form3.smethod_18((IDisposable)components);
				num2 = (int)((num3 * 156955018) ^ 0x205C0E3B);
				continue;
			case 6u:
				num2 = ((int)num3 * -761151769) ^ 0x6301815E;
				continue;
			case 5u:
				num2 = ((int)num3 * -2143324501) ^ 0x1A66F1EC;
				continue;
			case 4u:
				break;
			case 3u:
				((Form)this).Dispose(disposing);
				num2 = 1610224802;
				continue;
			case 2u:
				num2 = ((int)num3 * -2120361253) ^ 0x7B1F45DE;
				continue;
			default:
				return;
			case 1u:
				goto IL_00bd;
			case 0u:
				return;
			}
			break;
		}
		goto IL_0065;
		IL_00bd:
		num = ((components != null) ? 1 : 0);
		goto IL_00c6;
	}

	private void InitializeComponent()
	{
		while (true)
		{
			int num = -1497180801;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF1E40281u) % 120u)
				{
				case 119u:
					Form3.smethod_31((Control)(object)button1, "button1");
					num = ((int)num2 * -1686518689) ^ -394287600;
					continue;
				case 118u:
					NullButton = Form3.smethod_20();
					button1 = Form3.smethod_20();
					num = (int)(num2 * 2133262388) ^ -217622480;
					continue;
				case 117u:
					num = (int)((num2 * 17162645) ^ 0x775FD99A);
					continue;
				case 116u:
					Form3.smethod_30((Control)(object)button5, new Point(174, 190));
					num = ((int)num2 * -1483292140) ^ -1010888522;
					continue;
				case 115u:
					Form3.smethod_32((Control)(object)button5, new Size(140, 50));
					Form3.smethod_33((Control)(object)button5, 5);
					num = ((int)num2 * -431411224) ^ 0x722DA093;
					continue;
				case 114u:
					Form3.smethod_38((Control)(object)button5, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -180793279) ^ -1444797089;
					continue;
				case 113u:
					Form3.smethod_49((Form)(object)this, bool_0: false);
					Form3.smethod_50((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1483215655) ^ -1720145099;
					continue;
				case 112u:
					Form3.smethod_38((Control)(object)button4, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form3.smethod_30((Control)(object)button4, new Point(174, 137));
					num = ((int)num2 * -1112486045) ^ -1737456844;
					continue;
				case 111u:
					num = ((int)num2 * -964709855) ^ 0x60AEE9D5;
					continue;
				case 110u:
					Form3.smethod_55((ISupportInitialize)errorProvider1);
					Form3.smethod_56((Control)(object)this, bool_0: false);
					num = (int)((num2 * 1180192879) ^ 0x5851CD54);
					continue;
				case 109u:
					num = (int)((num2 * 175583422) ^ 0x1993D693);
					continue;
				case 108u:
					num = (int)(num2 * 1544193299) ^ -1449337811;
					continue;
				case 107u:
					Form3.smethod_33((Control)(object)label1, 7);
					num = ((int)num2 * -728722134) ^ 0x1F4649B;
					continue;
				case 106u:
					Form3.smethod_32((Control)(object)button4, new Size(140, 50));
					Form3.smethod_33((Control)(object)button4, 4);
					Form3.smethod_35((Control)(object)button4, "Начало игры");
					num = ((int)num2 * -180831770) ^ -487318972;
					continue;
				case 105u:
					Form3.smethod_30((Control)(object)textBox2, new Point(174, 26));
					Form3.smethod_31((Control)(object)textBox2, "textBox2");
					num = ((int)num2 * -1868665759) ^ -1165577144;
					continue;
				case 104u:
					num = ((int)num2 * -961224367) ^ 0x648606C0;
					continue;
				case 103u:
					Form3.smethod_40((Control)(object)label1, bool_0: true);
					Form3.smethod_26((Control)(object)label1, Color.Transparent);
					num = ((int)num2 * -937442527) ^ -1050257771;
					continue;
				case 102u:
					num = (int)((num2 * 1594211638) ^ 0x2507DC2);
					continue;
				case 101u:
					Form3.smethod_29((ButtonBase)(object)button5, (FlatStyle)0);
					num = ((int)num2 * -2090794481) ^ -788558656;
					continue;
				case 100u:
					num = (int)(num2 * 1899643900) ^ -7641628;
					continue;
				case 99u:
					Form3.smethod_31((Control)(object)button2, "button2");
					Form3.smethod_32((Control)(object)button2, new Size(85, 21));
					Form3.smethod_33((Control)(object)button2, 1);
					num = (int)((num2 * 1978132250) ^ 0x590C3CF0);
					continue;
				case 98u:
					num = ((int)num2 * -2054027884) ^ 0x4F6D495D;
					continue;
				case 97u:
					num = (int)(num2 * 840557757) ^ -1326873677;
					continue;
				case 96u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -879801940) ^ 0x4FAEE9BC;
					continue;
				case 95u:
					Form3.smethod_34((ButtonBase)(object)button4, bool_0: true);
					num = (int)(num2 * 1976938205) ^ -1388643864;
					continue;
				case 94u:
					Form3.smethod_33((Control)(object)button7, 6);
					num = (int)((num2 * 568411809) ^ 0x35C5510D);
					continue;
				case 93u:
					Form3.smethod_34((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -1285700047) ^ 0x71CA03B1;
					continue;
				case 92u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)NullButton);
					num = ((int)num2 * -2091267672) ^ 0x4FAF14B5;
					continue;
				case 91u:
					num = ((int)num2 * -1934795308) ^ -579037466;
					continue;
				case 90u:
					Form3.smethod_52((Form)(object)this, bool_0: false);
					num = ((int)num2 * -953257044) ^ 0x340E3156;
					continue;
				case 89u:
					Form3.smethod_31((Control)(object)textBox1, "textBox1");
					Form3.smethod_32((Control)(object)textBox1, new Size(140, 20));
					num = ((int)num2 * -1607550845) ^ 0x1099A64B;
					continue;
				case 88u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button4);
					num = ((int)num2 * -471302421) ^ -690990857;
					continue;
				case 87u:
					Form3.smethod_36((Control)(object)button5, (EventHandler)Button5_Click);
					num = ((int)num2 * -1936349427) ^ 0x1A3EAB6A;
					continue;
				case 86u:
					textBox1 = Form3.smethod_21();
					label1 = Form3.smethod_22();
					num = (int)(num2 * 252381771) ^ -445014994;
					continue;
				case 85u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button5);
					num = (int)(num2 * 1529059918) ^ -1815806310;
					continue;
				case 84u:
					Form3.smethod_24((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -1453495016) ^ -1814330869;
					continue;
				case 83u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -248020517) ^ -1876060112;
					continue;
				case 82u:
					Form3.smethod_36((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)((num2 * 392979613) ^ 0x226F36DF);
					continue;
				case 81u:
					Form3.smethod_33((Control)(object)button1, 0);
					Form3.smethod_35((Control)(object)button1, "Вход");
					num = (int)(num2 * 931575967) ^ -1420864621;
					continue;
				case 80u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox1);
					num = (int)((num2 * 755679257) ^ 0x163394C6);
					continue;
				case 79u:
					num = ((int)num2 * -1225705822) ^ -1685648975;
					continue;
				case 78u:
					Form3.smethod_30((Control)(object)label1, new Point(140, 70));
					Form3.smethod_31((Control)(object)label1, "label1");
					num = (int)((num2 * 949501264) ^ 0x6FF5472B);
					continue;
				case 77u:
					num = ((int)num2 * -1192312846) ^ 0x44F2FF27;
					continue;
				case 76u:
					Form3.smethod_30((Control)(object)button2, new Point(174, 49));
					num = ((int)num2 * -359623104) ^ -1365252022;
					continue;
				case 75u:
					Form3.smethod_34((ButtonBase)(object)button5, bool_0: true);
					num = (int)((num2 * 1941160619) ^ 0x104B57DE);
					continue;
				case 74u:
					Form3.smethod_26((Control)(object)NullButton, Color.Transparent);
					num = ((int)num2 * -1667586746) ^ 0x6CDC4A11;
					continue;
				case 73u:
					Form3.smethod_34((ButtonBase)(object)NullButton, bool_0: false);
					num = ((int)num2 * -750076001) ^ -442900849;
					continue;
				case 72u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button2);
					num = ((int)num2 * -1100709557) ^ 0x1DBEE199;
					continue;
				case 71u:
					num = (int)((num2 * 1732246258) ^ 0x2C607DBE);
					continue;
				case 70u:
					Form3.smethod_29((ButtonBase)(object)button4, (FlatStyle)0);
					num = ((int)num2 * -1820433600) ^ 0x221F7D2C;
					continue;
				case 69u:
					Form3.smethod_48((Form)(object)this, (FormBorderStyle)0);
					num = ((int)num2 * -1087635519) ^ 0x70D3A31F;
					continue;
				case 68u:
					Form3.smethod_45((Form)(object)this, new Size(486, 296));
					num = (int)(num2 * 746462381) ^ -935812855;
					continue;
				case 67u:
					num = (int)((num2 * 1373474396) ^ 0x42B074CC);
					continue;
				case 66u:
					num = (int)(num2 * 1928802557) ^ -780485920;
					continue;
				case 64u:
					num = (int)((num2 * 1415349575) ^ 0x5DDF12BA);
					continue;
				case 63u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button7);
					num = (int)(num2 * 191225262) ^ -777663442;
					continue;
				case 62u:
					Form3.smethod_31((Control)(object)NullButton, "NullButton");
					Form3.smethod_32((Control)(object)NullButton, new Size(1, 1));
					num = ((int)num2 * -1161870869) ^ -1373165610;
					continue;
				case 61u:
					Form3.smethod_31((Control)(object)button4, "button4");
					num = (int)((num2 * 1815984405) ^ 0x6F9FF7B2);
					continue;
				case 60u:
					num = (int)((num2 * 754673727) ^ 0x3CBA27F6);
					continue;
				case 59u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox2);
					num = (int)((num2 * 1739053571) ^ 0x74E962B0);
					continue;
				case 58u:
					Form3.smethod_35((Control)(object)label1, "QUARTO");
					num = ((int)num2 * -1840772074) ^ -529939340;
					continue;
				case 57u:
					Form3.smethod_30((Control)(object)button1, new Point(265, 49));
					num = ((int)num2 * -1577963) ^ -2043736405;
					continue;
				case 56u:
					Form3.smethod_32((Control)(object)button1, new Size(49, 21));
					num = ((int)num2 * -942842930) ^ -258337655;
					continue;
				case 55u:
					Form3.smethod_32((Control)(object)textBox2, new Size(140, 20));
					num = (int)(num2 * 942020320) ^ -585263442;
					continue;
				case 54u:
					components = Form3.smethod_19();
					num = ((int)num2 * -1582184806) ^ 0x7195C87B;
					continue;
				case 53u:
					Form3.smethod_26((Control)(object)this, Color.White);
					num = (int)((num2 * 866679621) ^ 0x55FEDBC5);
					continue;
				case 52u:
					Form3.smethod_32((Control)(object)label1, new Size(207, 76));
					num = (int)((num2 * 2102987937) ^ 0x3FE1997);
					continue;
				case 51u:
					num = ((int)num2 * -11731792) ^ -941207451;
					continue;
				case 50u:
					Form3.smethod_54((Form)(object)this, bool_0: true);
					num = ((int)num2 * -1273579358) ^ 0x523B76BB;
					continue;
				case 49u:
					button2 = Form3.smethod_20();
					num = (int)((num2 * 517204332) ^ 0x51981456);
					continue;
				case 48u:
					Form3.smethod_32((Control)(object)button7, new Size(140, 50));
					num = ((int)num2 * -1884833498) ^ -1287134689;
					continue;
				case 47u:
					num = ((int)num2 * -644136048) ^ 0x252C64D0;
					continue;
				case 46u:
					Form3.smethod_41(textBox2, bool_0: true);
					num = ((int)num2 * -1325278518) ^ 0x37D5EF09;
					continue;
				case 45u:
					Form3.smethod_29((ButtonBase)(object)NullButton, (FlatStyle)0);
					num = ((int)num2 * -1658322640) ^ 0x12F5B97A;
					continue;
				case 44u:
					Form3.smethod_43((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -11087865) ^ -1240039314;
					continue;
				case 43u:
					Form3.smethod_38((Control)(object)label1, Form3.smethod_37("Mistral", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 136226124) ^ 0x19B163DB);
					continue;
				case 42u:
					num = ((int)num2 * -844188302) ^ 0x2E90715B;
					continue;
				case 41u:
					Form3.smethod_57((Control)(object)this);
					num = (int)(num2 * 938655392) ^ -791371184;
					continue;
				case 40u:
					num = ((int)num2 * -1774838660) ^ -898518010;
					continue;
				case 39u:
					Form3.smethod_34((ButtonBase)(object)button2, bool_0: true);
					Form3.smethod_36((Control)(object)button2, (EventHandler)Button2_Click);
					num = ((int)num2 * -656381153) ^ -816305728;
					continue;
				case 38u:
					num = ((int)num2 * -366298271) ^ 0x561DC247;
					continue;
				case 37u:
					num = ((int)num2 * -1341873013) ^ -1014240434;
					continue;
				case 36u:
					Form3.smethod_44((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -436068875) ^ 0x4E48DAF0;
					continue;
				case 35u:
					button5 = Form3.smethod_20();
					num = ((int)num2 * -735541610) ^ 0x4580CDEC;
					continue;
				case 34u:
					num = (int)(num2 * 1113366542) ^ -1843494793;
					continue;
				case 33u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button7), 0);
					Form3.smethod_29((ButtonBase)(object)button7, (FlatStyle)0);
					Form3.smethod_38((Control)(object)button7, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -240310506) ^ -1342248497;
					continue;
				case 32u:
					Form3.smethod_14((Control)(object)button4, bool_0: false);
					num = ((int)num2 * -1970794304) ^ -1550303147;
					continue;
				case 31u:
					Form3.smethod_33((Control)(object)textBox2, 8);
					num = ((int)num2 * -937326925) ^ 0x1952BB89;
					continue;
				case 30u:
					Form3.smethod_14((Control)(object)button5, bool_0: false);
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button5), 0);
					num = (int)(num2 * 1110133376) ^ -281465844;
					continue;
				case 29u:
					textBox2 = Form3.smethod_21();
					num = (int)(num2 * 20003119) ^ -805245268;
					continue;
				case 28u:
					Form3.smethod_39((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					Form3.smethod_42(errorProvider1, (ContainerControl)(object)this);
					num = (int)(num2 * 2105371031) ^ -1269535503;
					continue;
				case 27u:
					num = ((int)num2 * -1190696239) ^ 0x19FC8FCB;
					continue;
				case 26u:
					num = ((int)num2 * -1098136337) ^ -1454662113;
					continue;
				case 25u:
					Form3.smethod_30((Control)(object)NullButton, new Point(-1, -1));
					num = (int)(num2 * 825396459) ^ -1576688524;
					continue;
				case 24u:
					num = ((int)num2 * -2071855868) ^ 0x60D8D930;
					continue;
				case 23u:
					Form3.smethod_31((Control)(object)button5, "button5");
					num = ((int)num2 * -688236554) ^ -164521611;
					continue;
				case 22u:
					Form3.smethod_35((Control)(object)button7, "Достижения");
					Form3.smethod_34((ButtonBase)(object)button7, bool_0: true);
					Form3.smethod_36((Control)(object)button7, (EventHandler)Button7_Click);
					Form3.smethod_30((Control)(object)textBox1, new Point(174, 2));
					num = (int)((num2 * 930956459) ^ 0x26A26372);
					continue;
				case 21u:
					num = (int)(num2 * 453701275) ^ -2019417642;
					continue;
				case 20u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button4), 0);
					num = (int)((num2 * 976265930) ^ 0x1F46DD2E);
					continue;
				case 19u:
					Form3.smethod_51((Control)(object)this, "Form3");
					num = ((int)num2 * -370819255) ^ 0x203F42E8;
					continue;
				case 18u:
					Form3.smethod_35((Control)(object)button5, "Продолжить");
					num = (int)(num2 * 316773791) ^ -1580517385;
					continue;
				case 17u:
					Form3.smethod_33((Control)(object)textBox1, 7);
					Form3.smethod_39((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -227600663) ^ 0x7CC1E55F;
					continue;
				case 16u:
					Form3.smethod_30((Control)(object)button7, new Point(174, 243));
					Form3.smethod_31((Control)(object)button7, "button7");
					num = (int)(num2 * 1601230637) ^ -918166635;
					continue;
				case 15u:
					button7 = Form3.smethod_20();
					num = (int)(num2 * 1218381288) ^ -254212793;
					continue;
				case 14u:
					errorProvider1 = Form3.smethod_23(components);
					num = ((int)num2 * -1784214087) ^ -584598125;
					continue;
				case 13u:
					Form3.smethod_33((Control)(object)NullButton, 3);
					num = (int)(num2 * 957678126) ^ -40863642;
					continue;
				case 12u:
					num = (int)(num2 * 1476940117) ^ -891899097;
					continue;
				case 11u:
					Form3.smethod_35((Control)(object)button2, "Регистрация");
					num = (int)((num2 * 86922553) ^ 0x50DF0B4D);
					continue;
				case 10u:
					num = (int)(num2 * 1925726888) ^ -864008637;
					continue;
				case 9u:
					Form3.smethod_53((Form)(object)this, bool_0: false);
					num = (int)((num2 * 1917512707) ^ 0x5BD02D30);
					continue;
				case 8u:
					Form3.smethod_36((Control)(object)button4, (EventHandler)Button4_Click);
					num = (int)(num2 * 1861078630) ^ -117272361;
					continue;
				case 7u:
					num = (int)((num2 * 1951541708) ^ 0x5DB82E6A);
					continue;
				case 6u:
					num = ((int)num2 * -775630116) ^ -1617951238;
					continue;
				case 5u:
					num = (int)((num2 * 1496296753) ^ 0x2B256F02);
					continue;
				case 4u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)NullButton), 0);
					num = (int)(num2 * 1334465411) ^ -783334664;
					continue;
				case 3u:
					button4 = Form3.smethod_20();
					num = (int)((num2 * 1308945355) ^ 0xEA73FFB);
					continue;
				case 2u:
					Form3.smethod_25((Control)(object)this);
					num = (int)((num2 * 1107488710) ^ 0x1C64F827);
					continue;
				case 0u:
					num = ((int)num2 * -756122514) ^ 0x23CC008A;
					continue;
				default:
					return;
				case 65u:
					break;
				case 1u:
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
