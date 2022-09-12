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
			int num = 1518167670;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7211779Eu) % 5u)
				{
				case 3u:
					num = (int)(num2 * 804823647) ^ -661409777;
					continue;
				case 2u:
					num = ((int)num2 * -263094254) ^ 0x73F7853E;
					continue;
				case 1u:
					InitializeComponent();
					num = ((int)num2 * -629884201) ^ 0x2DB72994;
					continue;
				default:
					return;
				case 4u:
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
		Form3.smethod_1(errorProvider1);
		Form val = default(Form);
		while (true)
		{
			int num = -482067519;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAF5FA0E1u) % 7u)
				{
				case 6u:
					num = ((int)num2 * -1608565341) ^ 0x799EA1B1;
					continue;
				case 5u:
				{
					Form4 form = new Form4();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					num = ((int)num2 * -190210655) ^ 0x7B0ED12C;
					continue;
				}
				case 4u:
					Form3.smethod_10(val, new Point(Form3.smethod_5((Form)(object)this).X + (Form3.smethod_6((Control)(object)this) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_5((Form)(object)this).Y + (Form3.smethod_8((Control)(object)this) - Form3.smethod_9((Control)(object)val)) / 2 + 70));
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = (int)(num2 * 309755419) ^ -1402922993;
					continue;
				case 2u:
					num = (int)((num2 * 903674323) ^ 0x5F6548D0);
					continue;
				case 1u:
					Form3.smethod_4((Control)(object)val);
					num = (int)((num2 * 273032047) ^ 0x112CF106);
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

	private void Button4_Click(object sender, EventArgs e)
	{
		Form3.smethod_0((Control)(object)NullButton);
		Form val = default(Form);
		while (true)
		{
			int num = -116448909;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8082356Au) % 6u)
				{
				case 5u:
					Form3.smethod_10(val, new Point(Form3.smethod_13(Form3.smethod_12((Form)(object)this)).X + (Form3.smethod_7((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_13(Form3.smethod_12((Form)(object)this)).Y + (Form3.smethod_9((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_9((Control)(object)val)) / 2));
					num = (int)((num2 * 1430502200) ^ 0x3BC30F56);
					continue;
				case 2u:
					num = (int)(num2 * 160102017) ^ -1975921845;
					continue;
				case 1u:
				{
					Form2 form = new Form2();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					Form3.smethod_4((Control)(object)val);
					num = ((int)num2 * -1808932231) ^ 0x213D7B3B;
					continue;
				}
				case 0u:
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = (int)((num2 * 407485545) ^ 0xBA5E6F);
					continue;
				default:
					return;
				case 4u:
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
			int num = -1530738601;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE3441298u) % 8u)
				{
				case 7u:
					num = ((int)num2 * -1164261279) ^ -2075604084;
					continue;
				case 6u:
					Form3.smethod_17((Form3.smethod_12((Form)(object)this) as Form1).timer1);
					num = ((int)num2 * -1255917659) ^ -1582751237;
					continue;
				case 4u:
					Form3.smethod_16(Form3.smethod_12((Form)(object)this));
					num = (int)((num2 * 1285959026) ^ 0x779D6B6);
					continue;
				case 3u:
					num3 = Form3.smethod_8((Control)(object)this) - 1;
					num = -1564134750;
					continue;
				case 2u:
				{
					Form3.smethod_15((Control)(object)this, num3);
					int num4;
					int num5;
					if (num3 <= 1)
					{
						num4 = -1429455846;
						num5 = -1429455846;
					}
					else
					{
						num4 = -88128913;
						num5 = -88128913;
					}
					num = num4 ^ (int)(num2 * 359688927);
					continue;
				}
				case 1u:
					num = -2593821;
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

	private void Button1_Click(object sender, EventArgs e)
	{
	}

	private void TextBox_TextChanged(object sender, EventArgs e)
	{
		Form3.smethod_1(errorProvider1);
		while (true)
		{
			int num = 2056207101;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2608D851u) % 3u)
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
				num = (int)(num2 * 588118830) ^ -894032513;
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
	}

	private void Button7_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 2083513314;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x578CA527u) % 4u)
				{
				case 1u:
					Form3.smethod_0((Control)(object)NullButton);
					num = ((int)num2 * -1406686790) ^ -1415240219;
					continue;
				case 0u:
					Form3.smethod_14((Control)(object)button7, bool_0: false);
					num = (int)((num2 * 1764840204) ^ 0x31C95978);
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
		bool flag = default(bool);
		while (true)
		{
			int num = 1297416667;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x52FB2221u) % 8u)
				{
				case 7u:
					num3 = ((components != null) ? 1 : 0);
					goto IL_000f;
				case 6u:
					num = ((int)num2 * -1453264091) ^ 0x97B40D7;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 2011432641;
						num5 = 2011432641;
					}
					else
					{
						num4 = 1422226107;
						num5 = 1422226107;
					}
					num = num4 ^ (int)(num2 * 1988454646);
					continue;
				}
				case 4u:
					((Form)this).Dispose(disposing);
					num = 1732171056;
					continue;
				case 2u:
					if (disposing)
					{
						num = ((int)num2 * -626654219) ^ -97720252;
						continue;
					}
					num3 = 0;
					goto IL_000f;
				case 0u:
					Form3.smethod_18((IDisposable)components);
					num = ((int)num2 * -787082977) ^ 0x495A4B45;
					continue;
				default:
					return;
				case 3u:
					break;
				case 1u:
					return;
					IL_000f:
					flag = (byte)num3 != 0;
					num = 294949588;
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
			int num = -1552558739;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB740F5DBu) % 121u)
				{
				case 120u:
					num = (int)(num2 * 1264489623) ^ -1485913536;
					continue;
				case 119u:
					Form3.smethod_31((Control)(object)button1, "button1");
					num = (int)((num2 * 1127701566) ^ 0x3CEFDECB);
					continue;
				case 118u:
					Form3.smethod_38((Control)(object)button7, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form3.smethod_30((Control)(object)button7, new Point(174, 243));
					num = (int)(num2 * 595742253) ^ -1726377148;
					continue;
				case 117u:
					label1 = Form3.smethod_22();
					num = ((int)num2 * -880218803) ^ -581421900;
					continue;
				case 116u:
					Form3.smethod_39((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -557404044) ^ -2059486952;
					continue;
				case 115u:
					button2 = Form3.smethod_20();
					num = ((int)num2 * -72135517) ^ -610678050;
					continue;
				case 114u:
					Form3.smethod_30((Control)(object)button2, new Point(174, 49));
					num = (int)(num2 * 1794458217) ^ -590205658;
					continue;
				case 113u:
					Form3.smethod_44((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 1112870921) ^ 0x6212F7DB);
					continue;
				case 112u:
					num = ((int)num2 * -111077222) ^ 0x5DA6A5E7;
					continue;
				case 111u:
					Form3.smethod_35((Control)(object)button7, "Достижения");
					num = (int)((num2 * 2118610187) ^ 0x61C044DA);
					continue;
				case 110u:
					Form3.smethod_50((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1449617418) ^ 0x282411A1;
					continue;
				case 109u:
					Form3.smethod_43((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)((num2 * 1389844289) ^ 0x5FC8F6AD);
					continue;
				case 108u:
					num = (int)(num2 * 367988584) ^ -1716665349;
					continue;
				case 107u:
					Form3.smethod_35((Control)(object)button5, "Продолжить");
					num = (int)(num2 * 862861553) ^ -615746651;
					continue;
				case 106u:
					Form3.smethod_34((ButtonBase)(object)button7, bool_0: true);
					num = ((int)num2 * -1750964132) ^ -1692472220;
					continue;
				case 105u:
					Form3.smethod_32((Control)(object)NullButton, new Size(1, 1));
					num = (int)(num2 * 1653976883) ^ -1487456277;
					continue;
				case 104u:
					Form3.smethod_14((Control)(object)button5, bool_0: false);
					num = (int)((num2 * 818154993) ^ 0x72956344);
					continue;
				case 103u:
					Form3.smethod_52((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1036716962) ^ 0x118DCE03;
					continue;
				case 102u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)label1);
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)NullButton);
					num = ((int)num2 * -522026460) ^ -1310339018;
					continue;
				case 101u:
					Form3.smethod_32((Control)(object)textBox1, new Size(140, 20));
					num = ((int)num2 * -1031411098) ^ 0x4619EE4B;
					continue;
				case 100u:
					Form3.smethod_31((Control)(object)textBox2, "textBox2");
					num = (int)(num2 * 1593671846) ^ -106056693;
					continue;
				case 99u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox1);
					num = ((int)num2 * -1098074227) ^ 0x66BC7D69;
					continue;
				case 98u:
					num = (int)((num2 * 50357018) ^ 0x67A8A8A4);
					continue;
				case 97u:
					Form3.smethod_33((Control)(object)button5, 5);
					num = (int)(num2 * 1412845889) ^ -1629620120;
					continue;
				case 96u:
					Form3.smethod_33((Control)(object)textBox2, 8);
					Form3.smethod_41(textBox2, bool_0: true);
					num = (int)((num2 * 1215108766) ^ 0x19C2C34E);
					continue;
				case 95u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -465303715) ^ -1097858561;
					continue;
				case 94u:
					num = (int)(num2 * 875803316) ^ -36626019;
					continue;
				case 93u:
					num = (int)((num2 * 708971314) ^ 0x764E7221);
					continue;
				case 92u:
					num = (int)(num2 * 148482002) ^ -1415995232;
					continue;
				case 91u:
					Form3.smethod_35((Control)(object)button2, "Регистрация");
					Form3.smethod_34((ButtonBase)(object)button2, bool_0: true);
					num = ((int)num2 * -2120466571) ^ 0x60AFB991;
					continue;
				case 90u:
					errorProvider1 = Form3.smethod_23(components);
					Form3.smethod_24((ISupportInitialize)errorProvider1);
					num = (int)(num2 * 1763730438) ^ -1423962873;
					continue;
				case 89u:
					Form3.smethod_33((Control)(object)button7, 6);
					num = (int)((num2 * 1762633213) ^ 0x3A04E33A);
					continue;
				case 88u:
					Form3.smethod_32((Control)(object)button5, new Size(140, 50));
					num = ((int)num2 * -1195401935) ^ 0x71B03E61;
					continue;
				case 87u:
					Form3.smethod_31((Control)(object)button2, "button2");
					num = (int)((num2 * 163358290) ^ 0x4724AF9C);
					continue;
				case 86u:
					num = ((int)num2 * -1746021190) ^ -2040944927;
					continue;
				case 85u:
					num = (int)((num2 * 1772802609) ^ 0x7A78E620);
					continue;
				case 84u:
					Form3.smethod_36((Control)(object)button7, (EventHandler)Button7_Click);
					num = ((int)num2 * -1915200077) ^ -1741265500;
					continue;
				case 83u:
					num = ((int)num2 * -603297603) ^ 0x1C77F6E1;
					continue;
				case 82u:
					Form3.smethod_14((Control)(object)button4, bool_0: false);
					num = (int)((num2 * 1358233920) ^ 0x5E853B46);
					continue;
				case 81u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button5);
					num = ((int)num2 * -1072228054) ^ 0x2B10E73C;
					continue;
				case 80u:
					num = (int)(num2 * 865085649) ^ -1061915759;
					continue;
				case 79u:
					num = ((int)num2 * -1372456937) ^ -2021945120;
					continue;
				case 78u:
					Form3.smethod_54((Form)(object)this, bool_0: true);
					num = ((int)num2 * -1243627171) ^ 0x35E9D6B5;
					continue;
				case 77u:
					num = ((int)num2 * -1959898781) ^ -1451450028;
					continue;
				case 76u:
					Form3.smethod_30((Control)(object)label1, new Point(140, 70));
					Form3.smethod_31((Control)(object)label1, "label1");
					num = ((int)num2 * -643865792) ^ 0x1D30F161;
					continue;
				case 75u:
					Form3.smethod_55((ISupportInitialize)errorProvider1);
					num = (int)((num2 * 1639936967) ^ 0x78698FE1);
					continue;
				case 74u:
					components = Form3.smethod_19();
					NullButton = Form3.smethod_20();
					num = ((int)num2 * -822474959) ^ 0x16E1D67A;
					continue;
				case 73u:
					Form3.smethod_51((Control)(object)this, "Form3");
					num = (int)(num2 * 1783026672) ^ -609076313;
					continue;
				case 72u:
					num = ((int)num2 * -1448523515) ^ -1357193367;
					continue;
				case 71u:
					Form3.smethod_32((Control)(object)button2, new Size(85, 21));
					Form3.smethod_33((Control)(object)button2, 1);
					num = (int)((num2 * 1082984845) ^ 0x54AFF8C6);
					continue;
				case 70u:
					Form3.smethod_26((Control)(object)NullButton, Color.Transparent);
					num = ((int)num2 * -1497421009) ^ 0x627B7958;
					continue;
				case 69u:
					Form3.smethod_39((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -500469945) ^ 0x2808B5D;
					continue;
				case 68u:
					num = ((int)num2 * -491841201) ^ -741836836;
					continue;
				case 67u:
					Form3.smethod_32((Control)(object)textBox2, new Size(140, 20));
					num = ((int)num2 * -1008094689) ^ 0x362C301;
					continue;
				case 66u:
					num = ((int)num2 * -1778917846) ^ 0x758D4415;
					continue;
				case 65u:
					Form3.smethod_57((Control)(object)this);
					num = ((int)num2 * -1727952860) ^ -276847612;
					continue;
				case 64u:
					Form3.smethod_32((Control)(object)button1, new Size(49, 21));
					num = ((int)num2 * -1907527762) ^ -2126112647;
					continue;
				case 63u:
					Form3.smethod_30((Control)(object)NullButton, new Point(-1, -1));
					num = (int)((num2 * 1014055345) ^ 0x13ED8196);
					continue;
				case 62u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button5), 0);
					num = ((int)num2 * -826627519) ^ -736557363;
					continue;
				case 61u:
					Form3.smethod_31((Control)(object)button7, "button7");
					Form3.smethod_32((Control)(object)button7, new Size(140, 50));
					num = ((int)num2 * -1420146806) ^ 0x12D2D404;
					continue;
				case 60u:
					Form3.smethod_29((ButtonBase)(object)button5, (FlatStyle)0);
					num = (int)(num2 * 1285305921) ^ -1153630858;
					continue;
				case 59u:
					Form3.smethod_30((Control)(object)button5, new Point(174, 190));
					num = (int)(num2 * 1990040116) ^ -1496119100;
					continue;
				case 58u:
					num = ((int)num2 * -229295291) ^ 0x74F9AEFF;
					continue;
				case 57u:
					Form3.smethod_25((Control)(object)this);
					num = (int)((num2 * 1535994659) ^ 0x2908D42F);
					continue;
				case 56u:
					Form3.smethod_33((Control)(object)textBox1, 7);
					num = ((int)num2 * -59564488) ^ -1332115451;
					continue;
				case 55u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button4);
					num = ((int)num2 * -1424308438) ^ -308175032;
					continue;
				case 54u:
					Form3.smethod_38((Control)(object)label1, Form3.smethod_37("Mistral", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -2072885570) ^ -81688873;
					continue;
				case 53u:
					Form3.smethod_40((Control)(object)label1, bool_0: true);
					Form3.smethod_26((Control)(object)label1, Color.Transparent);
					num = (int)(num2 * 384534306) ^ -1883403294;
					continue;
				case 52u:
					num = ((int)num2 * -875107590) ^ -1178367218;
					continue;
				case 51u:
					num = ((int)num2 * -1768178626) ^ -444179282;
					continue;
				case 50u:
					Form3.smethod_29((ButtonBase)(object)button7, (FlatStyle)0);
					num = (int)(num2 * 1854750059) ^ -1169452426;
					continue;
				case 49u:
					Form3.smethod_30((Control)(object)button4, new Point(174, 137));
					Form3.smethod_31((Control)(object)button4, "button4");
					num = (int)((num2 * 848859527) ^ 0x472B74DB);
					continue;
				case 48u:
					num = ((int)num2 * -540837073) ^ 0x1B27CEB2;
					continue;
				case 47u:
					num = ((int)num2 * -575888110) ^ -1319519938;
					continue;
				case 46u:
					Form3.smethod_30((Control)(object)textBox1, new Point(174, 2));
					Form3.smethod_31((Control)(object)textBox1, "textBox1");
					num = ((int)num2 * -418094076) ^ -2098492193;
					continue;
				case 45u:
					Form3.smethod_32((Control)(object)button4, new Size(140, 50));
					num = (int)(num2 * 835361331) ^ -687684280;
					continue;
				case 44u:
					Form3.smethod_29((ButtonBase)(object)NullButton, (FlatStyle)0);
					num = (int)(num2 * 1125949193) ^ -1288760576;
					continue;
				case 43u:
					num = ((int)num2 * -1084581009) ^ -393556291;
					continue;
				case 42u:
					Form3.smethod_56((Control)(object)this, bool_0: false);
					num = ((int)num2 * -1077271774) ^ -1786166623;
					continue;
				case 41u:
					Form3.smethod_32((Control)(object)label1, new Size(207, 76));
					Form3.smethod_33((Control)(object)label1, 7);
					num = ((int)num2 * -524404794) ^ -2060149417;
					continue;
				case 40u:
					Form3.smethod_31((Control)(object)button5, "button5");
					num = ((int)num2 * -1902431141) ^ -918873745;
					continue;
				case 39u:
					num = ((int)num2 * -1036546435) ^ -1224155420;
					continue;
				case 38u:
					Form3.smethod_35((Control)(object)label1, "QUARTO");
					Form3.smethod_30((Control)(object)textBox2, new Point(174, 26));
					num = ((int)num2 * -1309414583) ^ -69801175;
					continue;
				case 37u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button2);
					num = ((int)num2 * -599650256) ^ 0x878BE94;
					continue;
				case 36u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button4), 0);
					num = (int)(num2 * 764460741) ^ -598066940;
					continue;
				case 35u:
					num = (int)(num2 * 1780167186) ^ -499877946;
					continue;
				case 34u:
					num = (int)(num2 * 1003793112) ^ -886058665;
					continue;
				case 33u:
					num = (int)((num2 * 1949744573) ^ 0x7E396128);
					continue;
				case 32u:
					Form3.smethod_34((ButtonBase)(object)button4, bool_0: true);
					num = ((int)num2 * -334429309) ^ -647402687;
					continue;
				case 31u:
					Form3.smethod_30((Control)(object)button1, new Point(265, 49));
					num = ((int)num2 * -1552859664) ^ -1544655962;
					continue;
				case 30u:
					Form3.smethod_53((Form)(object)this, bool_0: false);
					num = (int)((num2 * 1630520601) ^ 0x79B1A828);
					continue;
				case 29u:
					Form3.smethod_29((ButtonBase)(object)button4, (FlatStyle)0);
					num = (int)((num2 * 1523061008) ^ 0x25526C35);
					continue;
				case 28u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button7);
					num = (int)(num2 * 824283563) ^ -1565692434;
					continue;
				case 27u:
					Form3.smethod_34((ButtonBase)(object)button5, bool_0: true);
					Form3.smethod_36((Control)(object)button5, (EventHandler)Button5_Click);
					num = ((int)num2 * -1920599163) ^ 0x57552496;
					continue;
				case 26u:
					num = ((int)num2 * -839226187) ^ 0x1D1FA01D;
					continue;
				case 25u:
					textBox2 = Form3.smethod_21();
					num = (int)((num2 * 1406917738) ^ 0xF1BF494);
					continue;
				case 24u:
					Form3.smethod_34((ButtonBase)(object)NullButton, bool_0: false);
					num = ((int)num2 * -142298627) ^ -409004313;
					continue;
				case 23u:
					num = (int)(num2 * 972437425) ^ -52813879;
					continue;
				case 22u:
					Form3.smethod_38((Control)(object)button4, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -2140804556) ^ 0x41308734;
					continue;
				case 21u:
					num = (int)((num2 * 1121628024) ^ 0xAFB0136);
					continue;
				case 20u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox2);
					num = ((int)num2 * -1347259450) ^ -885019675;
					continue;
				case 19u:
					Form3.smethod_48((Form)(object)this, (FormBorderStyle)0);
					Form3.smethod_49((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1497279107) ^ -82581484;
					continue;
				case 18u:
					button4 = Form3.smethod_20();
					button5 = Form3.smethod_20();
					button7 = Form3.smethod_20();
					textBox1 = Form3.smethod_21();
					num = (int)((num2 * 515322411) ^ 0x26820289);
					continue;
				case 17u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)NullButton), 0);
					num = (int)((num2 * 807381858) ^ 0x4A91C3DF);
					continue;
				case 16u:
					num = (int)(num2 * 949581346) ^ -1573904471;
					continue;
				case 15u:
					Form3.smethod_36((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -1944532846) ^ 0x329600A0;
					continue;
				case 14u:
					Form3.smethod_33((Control)(object)NullButton, 3);
					num = (int)(num2 * 2090092284) ^ -1983385005;
					continue;
				case 13u:
					Form3.smethod_31((Control)(object)NullButton, "NullButton");
					num = (int)(num2 * 1771536386) ^ -273008593;
					continue;
				case 12u:
					Form3.smethod_33((Control)(object)button1, 0);
					Form3.smethod_35((Control)(object)button1, "Вход");
					Form3.smethod_34((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -941645889) ^ 0x7DD32EE0;
					continue;
				case 11u:
					Form3.smethod_38((Control)(object)button5, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -489308171) ^ -455140024;
					continue;
				case 9u:
					Form3.smethod_36((Control)(object)button2, (EventHandler)Button2_Click);
					num = (int)(num2 * 790317793) ^ -1803420101;
					continue;
				case 8u:
					Form3.smethod_35((Control)(object)button4, "Начало игры");
					num = (int)(num2 * 1227451711) ^ -786003870;
					continue;
				case 7u:
					Form3.smethod_33((Control)(object)button4, 4);
					num = ((int)num2 * -237843363) ^ 0x27D23B51;
					continue;
				case 6u:
					num = (int)(num2 * 1275159239) ^ -1243413118;
					continue;
				case 5u:
					button1 = Form3.smethod_20();
					num = ((int)num2 * -1444718036) ^ 0x744841BA;
					continue;
				case 4u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button7), 0);
					num = ((int)num2 * -1809701615) ^ -586090894;
					continue;
				case 3u:
					Form3.smethod_42(errorProvider1, (ContainerControl)(object)this);
					num = (int)((num2 * 583803888) ^ 0x4D332567);
					continue;
				case 2u:
					Form3.smethod_36((Control)(object)button4, (EventHandler)Button4_Click);
					num = ((int)num2 * -1757123831) ^ -270364680;
					continue;
				case 1u:
					Form3.smethod_26((Control)(object)this, Color.White);
					Form3.smethod_45((Form)(object)this, new Size(486, 296));
					num = (int)(num2 * 440557709) ^ -1541376663;
					continue;
				default:
					return;
				case 10u:
					break;
				case 0u:
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
