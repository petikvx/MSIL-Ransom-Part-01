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
			int num = -1871132859;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8F19DF03u) % 5u)
				{
				case 3u:
					InitializeComponent();
					num = ((int)num2 * -1248384766) ^ 0x7BD29F2F;
					continue;
				case 2u:
					num = (int)(num2 * 308950867) ^ -1111781039;
					continue;
				case 1u:
					num = ((int)num2 * -868504525) ^ 0x2D8AC5C4;
					continue;
				default:
					return;
				case 0u:
					break;
				case 4u:
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
			int num = 1642647571;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3A0FCC3u) % 6u)
				{
				case 5u:
					num = ((int)num2 * -514338562) ^ 0xDE9E657;
					continue;
				case 3u:
					Form3.smethod_10(val, new Point(Form3.smethod_5((Form)(object)this).X + (Form3.smethod_6((Control)(object)this) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_5((Form)(object)this).Y + (Form3.smethod_8((Control)(object)this) - Form3.smethod_9((Control)(object)val)) / 2 + 70));
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = (int)((num2 * 873412820) ^ 0x206E5F44);
					continue;
				case 2u:
					num = ((int)num2 * -1302215890) ^ 0x418488;
					continue;
				case 1u:
				{
					Form4 form = new Form4();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					Form3.smethod_4((Control)(object)val);
					num = ((int)num2 * -753004746) ^ -456188;
					continue;
				}
				default:
					return;
				case 0u:
					break;
				case 4u:
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
			int num = 657682031;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1B952E20u) % 4u)
				{
				case 3u:
					Form3.smethod_4((Control)(object)val);
					num = (int)(num2 * 1694575324) ^ -1531396259;
					continue;
				case 1u:
					Form3.smethod_10(val, new Point(Form3.smethod_13(Form3.smethod_12((Form)(object)this)).X + (Form3.smethod_7((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_13(Form3.smethod_12((Form)(object)this)).Y + (Form3.smethod_9((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_9((Control)(object)val)) / 2));
					num = ((int)num2 * -1411504745) ^ -378432171;
					continue;
				case 0u:
					break;
				default:
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
		while (true)
		{
			int num = 1426840490;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6AD6FA83u) % 3u)
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
				num = (int)((num2 * 717648229) ^ 0x7D28A5C0);
			}
		}
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = Form3.smethod_8((Control)(object)this) - 1;
			int num2 = -188568700;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xDB9DBAC0u) % 11u)
				{
				case 10u:
					Form3.smethod_15((Control)(object)this, num);
					num2 = (int)((num3 * 1611346486) ^ 0x6F044FDD);
					continue;
				case 8u:
					Form3.smethod_17((Form3.smethod_12((Form)(object)this) as Form1).timer1);
					num2 = (int)((num3 * 1027960006) ^ 0x5510801);
					continue;
				case 7u:
					Form3.smethod_16(Form3.smethod_12((Form)(object)this));
					num2 = ((int)num3 * -1492751924) ^ -1879690144;
					continue;
				case 6u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 894903579;
						num5 = 894903579;
					}
					else
					{
						num4 = 2030365659;
						num5 = 2030365659;
					}
					num2 = num4 ^ (int)(num3 * 1474145161);
					continue;
				}
				case 5u:
					flag = num > 1;
					num2 = ((int)num3 * -1453379549) ^ -1220627220;
					continue;
				case 4u:
					num2 = -1302570718;
					continue;
				case 3u:
					num2 = ((int)num3 * -1948939062) ^ -1304736300;
					continue;
				case 1u:
					num2 = -1260716395;
					continue;
				case 0u:
					num2 = ((int)num3 * -2122378650) ^ -349838271;
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
		while (true)
		{
			int num = 644372562;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x27C32EF8u) % 3u)
				{
				case 1u:
					goto IL_000d;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_000d:
				num = (int)(num2 * 501782424) ^ -1110269827;
			}
		}
	}

	public void ContinueLock()
	{
		Form3.smethod_14((Control)(object)button5, bool_0: false);
	}

	public void AchivUnlock()
	{
		Form3.smethod_14((Control)(object)button7, bool_0: true);
		while (true)
		{
			int num = 559601259;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x100DA2E8u) % 3u)
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
				num = (int)(num2 * 1719378522) ^ -969294509;
			}
		}
	}

	private void Button7_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -1997180468;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF1471CE9u) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 2u:
					break;
				default:
					Form3.smethod_14((Control)(object)button7, bool_0: false);
					return;
				}
				break;
				IL_0003:
				Form3.smethod_0((Control)(object)NullButton);
				num = ((int)num2 * -1114182475) ^ 0x656B0627;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (!disposing)
		{
			goto IL_0009;
		}
		goto IL_006b;
		IL_006b:
		int num = -1653512578;
		goto IL_0070;
		IL_0070:
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xD2AD5FE2u) % 8u)
			{
			case 7u:
				num = (int)(num2 * 1058013813) ^ -375730109;
				continue;
			case 6u:
				num = (int)((num2 * 243626752) ^ 0x8405CF9);
				continue;
			case 5u:
				Form3.smethod_18((IDisposable)components);
				num = (int)((num2 * 1397678702) ^ 0x4C23789A);
				continue;
			case 3u:
				num = (int)(num2 * 1417404006) ^ -212186855;
				continue;
			case 1u:
				((Form)this).Dispose(disposing);
				num = -972793307;
				continue;
			case 0u:
				break;
			default:
				return;
			case 4u:
				goto IL_00a1;
			case 2u:
				return;
			}
			break;
			IL_00a1:
			if (components != null)
			{
				num = -725560417;
				num3 = -725560417;
				continue;
			}
			goto IL_0009;
		}
		goto IL_006b;
		IL_0009:
		num = -1510652965;
		num3 = -1510652965;
		goto IL_0070;
	}

	private void InitializeComponent()
	{
		components = Form3.smethod_19();
		while (true)
		{
			int num = -222001264;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF7E495A8u) % 142u)
				{
				case 141u:
					Form3.smethod_32((Control)(object)button4, new Size(140, 50));
					num = ((int)num2 * -1648926101) ^ -1777764905;
					continue;
				case 140u:
					Form3.smethod_30((Control)(object)textBox1, new Point(174, 2));
					num = (int)(num2 * 375138558) ^ -985037057;
					continue;
				case 139u:
					Form3.smethod_42(errorProvider1, (ContainerControl)(object)this);
					num = ((int)num2 * -2084486538) ^ -553214890;
					continue;
				case 138u:
					num = ((int)num2 * -2016001128) ^ 0x6B031DBC;
					continue;
				case 137u:
					Form3.smethod_36((Control)(object)button7, (EventHandler)Button7_Click);
					num = (int)((num2 * 1524983831) ^ 0x5B867F67);
					continue;
				case 136u:
					Form3.smethod_36((Control)(object)button4, (EventHandler)Button4_Click);
					num = (int)(num2 * 699954427) ^ -837885430;
					continue;
				case 135u:
					num = ((int)num2 * -1047402123) ^ 0x6F136FA3;
					continue;
				case 134u:
					Form3.smethod_25((Control)(object)this);
					num = ((int)num2 * -113288519) ^ -1373681244;
					continue;
				case 133u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button7), 0);
					Form3.smethod_29((ButtonBase)(object)button7, (FlatStyle)0);
					Form3.smethod_38((Control)(object)button7, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form3.smethod_30((Control)(object)button7, new Point(174, 243));
					num = (int)((num2 * 1018484699) ^ 0x154B6714);
					continue;
				case 132u:
					Form3.smethod_30((Control)(object)button4, new Point(174, 137));
					num = ((int)num2 * -1573747191) ^ 0x57768612;
					continue;
				case 131u:
					num = (int)((num2 * 886309605) ^ 0x13461EF);
					continue;
				case 130u:
					num = ((int)num2 * -813965766) ^ 0x3FFF3D7C;
					continue;
				case 129u:
					Form3.smethod_34((ButtonBase)(object)NullButton, bool_0: false);
					Form3.smethod_30((Control)(object)button1, new Point(265, 49));
					num = (int)((num2 * 56164443) ^ 0x26B34BD2);
					continue;
				case 128u:
					Form3.smethod_36((Control)(object)button5, (EventHandler)Button5_Click);
					num = (int)((num2 * 1283482023) ^ 0x7DDC11B9);
					continue;
				case 127u:
					Form3.smethod_49((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1538326922) ^ 0x1BA04082;
					continue;
				case 125u:
					Form3.smethod_36((Control)(object)button2, (EventHandler)Button2_Click);
					num = (int)(num2 * 1764014163) ^ -32970675;
					continue;
				case 124u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -1561759696) ^ -1329565734;
					continue;
				case 123u:
					Form3.smethod_41(textBox2, bool_0: true);
					num = ((int)num2 * -661937235) ^ 0xC0AE4D4;
					continue;
				case 122u:
					Form3.smethod_38((Control)(object)button4, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -50922796) ^ 0x27D310FF;
					continue;
				case 121u:
					Form3.smethod_26((Control)(object)label1, Color.Transparent);
					num = ((int)num2 * -2121295439) ^ -1980923661;
					continue;
				case 120u:
					Form3.smethod_14((Control)(object)button5, bool_0: false);
					num = ((int)num2 * -793171949) ^ 0x152B5EE5;
					continue;
				case 119u:
					num = (int)((num2 * 1744449476) ^ 0x5FC718A7);
					continue;
				case 118u:
					Form3.smethod_50((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1332054571) ^ -1891578072;
					continue;
				case 117u:
					num = (int)((num2 * 1638355838) ^ 0x4B510257);
					continue;
				case 116u:
					Form3.smethod_35((Control)(object)button2, "Регистрация");
					num = (int)(num2 * 341011932) ^ -277213566;
					continue;
				case 115u:
					errorProvider1 = Form3.smethod_23(components);
					num = ((int)num2 * -1116913364) ^ -639431014;
					continue;
				case 114u:
					num = (int)(num2 * 516021179) ^ -588773756;
					continue;
				case 113u:
					Form3.smethod_34((ButtonBase)(object)button4, bool_0: true);
					num = (int)((num2 * 1844487009) ^ 0x3A5D249C);
					continue;
				case 112u:
					Form3.smethod_34((ButtonBase)(object)button5, bool_0: true);
					num = (int)((num2 * 1486962450) ^ 0x66F79851);
					continue;
				case 111u:
					num = ((int)num2 * -1428991131) ^ 0x2F73443C;
					continue;
				case 110u:
					num = ((int)num2 * -269050924) ^ -195493757;
					continue;
				case 109u:
					Form3.smethod_29((ButtonBase)(object)button4, (FlatStyle)0);
					num = ((int)num2 * -716818954) ^ -217265687;
					continue;
				case 108u:
					num = (int)((num2 * 1155705042) ^ 0x10FA1EE9);
					continue;
				case 107u:
					num = (int)((num2 * 1819689533) ^ 0x7441C8F3);
					continue;
				case 106u:
					Form3.smethod_32((Control)(object)textBox1, new Size(140, 20));
					num = ((int)num2 * -1347510365) ^ 0x38CC64;
					continue;
				case 105u:
					Form3.smethod_33((Control)(object)NullButton, 3);
					num = (int)((num2 * 1103422035) ^ 0x32F82296);
					continue;
				case 104u:
					Form3.smethod_29((ButtonBase)(object)button5, (FlatStyle)0);
					num = (int)((num2 * 1675757794) ^ 0x7ABB89C8);
					continue;
				case 103u:
					textBox2 = Form3.smethod_21();
					num = (int)((num2 * 1123343873) ^ 0xDD7762);
					continue;
				case 102u:
					Form3.smethod_33((Control)(object)button2, 1);
					num = (int)((num2 * 273738955) ^ 0x4540FBD9);
					continue;
				case 101u:
					Form3.smethod_32((Control)(object)button7, new Size(140, 50));
					num = (int)((num2 * 793634534) ^ 0x182E009A);
					continue;
				case 100u:
					num = ((int)num2 * -1773188471) ^ -1812701120;
					continue;
				case 99u:
					Form3.smethod_29((ButtonBase)(object)NullButton, (FlatStyle)0);
					num = (int)(num2 * 1594714978) ^ -597654639;
					continue;
				case 98u:
					num = (int)(num2 * 1109816380) ^ -1224420845;
					continue;
				case 97u:
					num = (int)(num2 * 784545982) ^ -1960519506;
					continue;
				case 96u:
					Form3.smethod_31((Control)(object)button5, "button5");
					num = (int)(num2 * 958192868) ^ -1228921503;
					continue;
				case 95u:
					Form3.smethod_31((Control)(object)button7, "button7");
					num = (int)((num2 * 1386185086) ^ 0x24F33111);
					continue;
				case 94u:
					Form3.smethod_31((Control)(object)NullButton, "NullButton");
					num = (int)((num2 * 253904690) ^ 0x110B9893);
					continue;
				case 93u:
					button4 = Form3.smethod_20();
					button5 = Form3.smethod_20();
					button7 = Form3.smethod_20();
					textBox1 = Form3.smethod_21();
					num = (int)(num2 * 721498666) ^ -1264592154;
					continue;
				case 92u:
					num = ((int)num2 * -1375059149) ^ -352862171;
					continue;
				case 91u:
					Form3.smethod_26((Control)(object)NullButton, Color.Transparent);
					num = (int)(num2 * 108331723) ^ -192153435;
					continue;
				case 90u:
					Form3.smethod_31((Control)(object)button2, "button2");
					num = (int)((num2 * 2088355538) ^ 0x7CBF9DDD);
					continue;
				case 89u:
					Form3.smethod_30((Control)(object)NullButton, new Point(-1, -1));
					num = (int)(num2 * 1518021426) ^ -1745568388;
					continue;
				case 88u:
					Form3.smethod_32((Control)(object)button2, new Size(85, 21));
					num = ((int)num2 * -506007352) ^ 0x3D6BB6E;
					continue;
				case 87u:
					Form3.smethod_34((ButtonBase)(object)button7, bool_0: true);
					num = ((int)num2 * -1514167817) ^ -344943810;
					continue;
				case 86u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -872544151) ^ -433914727;
					continue;
				case 85u:
					num = ((int)num2 * -946279874) ^ -146674596;
					continue;
				case 84u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button7);
					num = ((int)num2 * -908545211) ^ 0x272A94AC;
					continue;
				case 83u:
					num = ((int)num2 * -1801819858) ^ 0x2D2B9F6E;
					continue;
				case 82u:
					Form3.smethod_35((Control)(object)button4, "Начало игры");
					num = (int)(num2 * 707263298) ^ -960351961;
					continue;
				case 81u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox2);
					num = (int)(num2 * 405099917) ^ -784900931;
					continue;
				case 80u:
					NullButton = Form3.smethod_20();
					button1 = Form3.smethod_20();
					num = (int)((num2 * 668855191) ^ 0x7059518F);
					continue;
				case 79u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button4), 0);
					num = (int)(num2 * 968568095) ^ -1506817356;
					continue;
				case 78u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)NullButton);
					num = (int)(num2 * 1778505382) ^ -861518508;
					continue;
				case 77u:
					num = ((int)num2 * -391643805) ^ 0x3EBFC6E1;
					continue;
				case 76u:
					Form3.smethod_51((Control)(object)this, "Form3");
					num = ((int)num2 * -1781493014) ^ 0x534B58A0;
					continue;
				case 75u:
					Form3.smethod_31((Control)(object)button1, "button1");
					num = (int)(num2 * 1054993063) ^ -1006525020;
					continue;
				case 74u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button4);
					num = (int)((num2 * 1642389832) ^ 0x7E1D7938);
					continue;
				case 73u:
					num = (int)(num2 * 1733373478) ^ -314273213;
					continue;
				case 72u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox1);
					num = (int)(num2 * 302023677) ^ -721700542;
					continue;
				case 71u:
					Form3.smethod_45((Form)(object)this, new Size(486, 296));
					num = ((int)num2 * -999596091) ^ -1416697632;
					continue;
				case 70u:
					Form3.smethod_35((Control)(object)button7, "Достижения");
					num = ((int)num2 * -1768183176) ^ 0x66C51C2A;
					continue;
				case 69u:
					num = (int)((num2 * 52286894) ^ 0x53FF3F00);
					continue;
				case 68u:
					Form3.smethod_31((Control)(object)label1, "label1");
					num = (int)((num2 * 1603529913) ^ 0x2C86A69F);
					continue;
				case 67u:
					num = (int)(num2 * 514721812) ^ -714470706;
					continue;
				case 66u:
					Form3.smethod_34((ButtonBase)(object)button2, bool_0: true);
					num = (int)((num2 * 1502406261) ^ 0xC8B1DB9);
					continue;
				case 65u:
					Form3.smethod_26((Control)(object)this, Color.White);
					num = (int)((num2 * 97830524) ^ 0x59BEAEF2);
					continue;
				case 64u:
					Form3.smethod_32((Control)(object)textBox2, new Size(140, 20));
					num = ((int)num2 * -1219911180) ^ 0x4C28B7F5;
					continue;
				case 63u:
					Form3.smethod_30((Control)(object)button2, new Point(174, 49));
					num = ((int)num2 * -1016463937) ^ -1947469563;
					continue;
				case 62u:
					Form3.smethod_31((Control)(object)button4, "button4");
					num = ((int)num2 * -1248247198) ^ 0x4A0AF909;
					continue;
				case 61u:
					Form3.smethod_30((Control)(object)button5, new Point(174, 190));
					num = ((int)num2 * -750792929) ^ -406001852;
					continue;
				case 60u:
					Form3.smethod_52((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1245479752) ^ 0x46162FA7;
					continue;
				case 59u:
					Form3.smethod_38((Control)(object)button5, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -287838835) ^ 0x21BC1630;
					continue;
				case 58u:
					Form3.smethod_55((ISupportInitialize)errorProvider1);
					Form3.smethod_56((Control)(object)this, bool_0: false);
					num = (int)(num2 * 557241566) ^ -1029545360;
					continue;
				case 57u:
					Form3.smethod_34((ButtonBase)(object)button1, bool_0: true);
					num = (int)(num2 * 498495674) ^ -609212580;
					continue;
				case 56u:
					label1 = Form3.smethod_22();
					num = (int)((num2 * 1079857887) ^ 0x2231DCF1);
					continue;
				case 55u:
					Form3.smethod_35((Control)(object)button5, "Продолжить");
					num = ((int)num2 * -1046539872) ^ 0x854A18A;
					continue;
				case 54u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button2);
					num = (int)((num2 * 2090964176) ^ 0x82C4DDB);
					continue;
				case 53u:
					num = ((int)num2 * -1163358902) ^ -1449583573;
					continue;
				case 52u:
					Form3.smethod_40((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -991374381) ^ -562510587;
					continue;
				case 51u:
					Form3.smethod_35((Control)(object)label1, "QUARTO");
					num = (int)(num2 * 1054643995) ^ -708082756;
					continue;
				case 50u:
					Form3.smethod_33((Control)(object)button5, 5);
					num = ((int)num2 * -1353547081) ^ 0x30BD63E5;
					continue;
				case 49u:
					Form3.smethod_31((Control)(object)textBox1, "textBox1");
					num = ((int)num2 * -1597977951) ^ -1564416083;
					continue;
				case 48u:
					num = ((int)num2 * -2022958293) ^ 0x200AE715;
					continue;
				case 47u:
					num = (int)(num2 * 1538007815) ^ -266327425;
					continue;
				case 46u:
					num = ((int)num2 * -1091182085) ^ -1369112916;
					continue;
				case 45u:
					Form3.smethod_32((Control)(object)button5, new Size(140, 50));
					num = (int)((num2 * 1994802797) ^ 0x402BBD60);
					continue;
				case 44u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button5);
					num = (int)(num2 * 888180523) ^ -577365080;
					continue;
				case 43u:
					num = ((int)num2 * -1043897401) ^ -1840576676;
					continue;
				case 42u:
					num = ((int)num2 * -785621750) ^ 0x1E123E27;
					continue;
				case 41u:
					Form3.smethod_32((Control)(object)button1, new Size(49, 21));
					num = (int)(num2 * 790047489) ^ -1727947418;
					continue;
				case 40u:
					num = (int)(num2 * 2012671233) ^ -979791024;
					continue;
				case 39u:
					num = (int)(num2 * 1923234044) ^ -739497424;
					continue;
				case 38u:
					Form3.smethod_24((ISupportInitialize)errorProvider1);
					num = (int)((num2 * 806342543) ^ 0x270E5F68);
					continue;
				case 37u:
					Form3.smethod_43((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)((num2 * 1013819091) ^ 0x5EC6A766);
					continue;
				case 36u:
					Form3.smethod_48((Form)(object)this, (FormBorderStyle)0);
					num = ((int)num2 * -262322915) ^ 0x506BB0C3;
					continue;
				case 35u:
					num = (int)((num2 * 1976795554) ^ 0x3D217014);
					continue;
				case 34u:
					Form3.smethod_54((Form)(object)this, bool_0: true);
					num = (int)(num2 * 2105535298) ^ -944539828;
					continue;
				case 33u:
					num = (int)(num2 * 1073511416) ^ -862113438;
					continue;
				case 32u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button5), 0);
					num = (int)((num2 * 1092564881) ^ 0x1073089C);
					continue;
				case 31u:
					num = (int)((num2 * 1815346114) ^ 0x63649588);
					continue;
				case 29u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)NullButton), 0);
					num = (int)(num2 * 1797007167) ^ -1371680872;
					continue;
				case 28u:
					Form3.smethod_33((Control)(object)button1, 0);
					num = ((int)num2 * -28129952) ^ 0x594626B5;
					continue;
				case 27u:
					Form3.smethod_32((Control)(object)NullButton, new Size(1, 1));
					num = (int)(num2 * 1281475850) ^ -1601578877;
					continue;
				case 26u:
					num = ((int)num2 * -1795939462) ^ -1386135716;
					continue;
				case 25u:
					button2 = Form3.smethod_20();
					num = ((int)num2 * -709498821) ^ -1662402176;
					continue;
				case 24u:
					num = ((int)num2 * -130221519) ^ -545879675;
					continue;
				case 23u:
					num = ((int)num2 * -918329080) ^ 0x4390987C;
					continue;
				case 22u:
					Form3.smethod_36((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)((num2 * 226620910) ^ 0x6425F971);
					continue;
				case 21u:
					num = ((int)num2 * -1339003757) ^ 0x103E3370;
					continue;
				case 20u:
					Form3.smethod_33((Control)(object)textBox2, 8);
					num = (int)((num2 * 1008965997) ^ 0x3408A697);
					continue;
				case 19u:
					Form3.smethod_35((Control)(object)button1, "Вход");
					num = (int)((num2 * 1518024714) ^ 0x5B128F0D);
					continue;
				case 18u:
					num = ((int)num2 * -268993042) ^ -407891331;
					continue;
				case 17u:
					Form3.smethod_33((Control)(object)button4, 4);
					num = (int)(num2 * 661276025) ^ -291195569;
					continue;
				case 16u:
					Form3.smethod_53((Form)(object)this, bool_0: false);
					num = (int)((num2 * 1790462234) ^ 0x5B4B41B3);
					continue;
				case 15u:
					Form3.smethod_32((Control)(object)label1, new Size(207, 76));
					Form3.smethod_33((Control)(object)label1, 7);
					num = ((int)num2 * -1065449058) ^ 0x1EEC9891;
					continue;
				case 14u:
					Form3.smethod_14((Control)(object)button4, bool_0: false);
					num = ((int)num2 * -1302690594) ^ -331826587;
					continue;
				case 13u:
					num = (int)((num2 * 710922039) ^ 0x2EF0B869);
					continue;
				case 12u:
					Form3.smethod_38((Control)(object)label1, Form3.smethod_37("Mistral", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form3.smethod_30((Control)(object)label1, new Point(140, 70));
					num = ((int)num2 * -1319193071) ^ 0x5AD3C803;
					continue;
				case 11u:
					num = ((int)num2 * -1627084866) ^ -1991743330;
					continue;
				case 10u:
					Form3.smethod_39((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -1602610080) ^ 0x20E7933D;
					continue;
				case 9u:
					num = (int)(num2 * 211227019) ^ -599099527;
					continue;
				case 8u:
					Form3.smethod_33((Control)(object)textBox1, 7);
					num = ((int)num2 * -1282064336) ^ -138824731;
					continue;
				case 7u:
					Form3.smethod_30((Control)(object)textBox2, new Point(174, 26));
					Form3.smethod_31((Control)(object)textBox2, "textBox2");
					num = ((int)num2 * -1361978053) ^ -1762229404;
					continue;
				case 6u:
					num = (int)((num2 * 1500166514) ^ 0x6883A94C);
					continue;
				case 5u:
					num = ((int)num2 * -1496955437) ^ 0x4A2C027B;
					continue;
				case 4u:
					num = (int)((num2 * 223109318) ^ 0x7513894E);
					continue;
				case 3u:
					Form3.smethod_44((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 340358726) ^ 0x505B2246);
					continue;
				case 2u:
					Form3.smethod_39((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = (int)(num2 * 1249789131) ^ -252229547;
					continue;
				case 1u:
					num = ((int)num2 * -2137978440) ^ -1576396810;
					continue;
				case 0u:
					Form3.smethod_33((Control)(object)button7, 6);
					num = ((int)num2 * -430019493) ^ 0x15C99CAC;
					continue;
				case 126u:
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
