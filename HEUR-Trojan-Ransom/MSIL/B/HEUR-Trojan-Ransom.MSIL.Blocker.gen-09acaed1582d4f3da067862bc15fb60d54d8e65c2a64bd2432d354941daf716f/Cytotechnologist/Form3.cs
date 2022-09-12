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
			int num = -1903763273;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAF5AEE40u) % 5u)
				{
				case 4u:
					num = ((int)num2 * -274702697) ^ 0x5116BE0C;
					continue;
				case 3u:
					InitializeComponent();
					num = (int)((num2 * 538115659) ^ 0x7D96DAD2);
					continue;
				case 1u:
					num = ((int)num2 * -2021820094) ^ 0x77C62D1A;
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
			int num = 426608918;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x57E7A7E8u) % 7u)
				{
				case 6u:
					Form3.smethod_10(val, new Point(Form3.smethod_5((Form)(object)this).X + (Form3.smethod_6((Control)(object)this) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_5((Form)(object)this).Y + (Form3.smethod_8((Control)(object)this) - Form3.smethod_9((Control)(object)val)) / 2 + 70));
					num = (int)((num2 * 1610422105) ^ 0x7EEA13E6);
					continue;
				case 4u:
					Form3.smethod_4((Control)(object)val);
					num = ((int)num2 * -1773824493) ^ -1711928178;
					continue;
				case 3u:
					num = ((int)num2 * -496183595) ^ 0x7CEC2924;
					continue;
				case 1u:
				{
					Form4 form = new Form4();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					num = ((int)num2 * -1990220202) ^ 0x2535C204;
					continue;
				}
				case 0u:
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = ((int)num2 * -761167887) ^ 0x415F57D4;
					continue;
				default:
					return;
				case 2u:
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
		Form3.smethod_0((Control)(object)NullButton);
		Form val = default(Form);
		while (true)
		{
			int num = -2054667370;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA3BDCD0Fu) % 5u)
				{
				case 2u:
					Form3.smethod_10(val, new Point(Form3.smethod_13(Form3.smethod_12((Form)(object)this)).X + (Form3.smethod_7((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_13(Form3.smethod_12((Form)(object)this)).Y + (Form3.smethod_9((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_9((Control)(object)val)) / 2));
					num = ((int)num2 * -1401133490) ^ 0x64D0D836;
					continue;
				case 1u:
				{
					Form2 form = new Form2();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					Form3.smethod_4((Control)(object)val);
					num = (int)(num2 * 1539978638) ^ -573467433;
					continue;
				}
				case 0u:
					num = (int)(num2 * 1247918496) ^ -961147824;
					continue;
				case 3u:
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
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = Form3.smethod_8((Control)(object)this) - 1;
			Form3.smethod_15((Control)(object)this, num);
			int num2 = 1619533952;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x44C8AF06u) % 6u)
				{
				case 5u:
					num2 = 291867413;
					continue;
				case 3u:
					Form3.smethod_16(Form3.smethod_12((Form)(object)this));
					num2 = (int)((num3 * 581393540) ^ 0x3858A0E8);
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (num <= 1)
					{
						num4 = -1249577285;
						num5 = -1249577285;
					}
					else
					{
						num4 = -776379267;
						num5 = -776379267;
					}
					num2 = num4 ^ ((int)num3 * -1816698308);
					continue;
				}
				case 1u:
					num2 = 671878938;
					continue;
				case 0u:
					break;
				default:
					Form3.smethod_17((Form3.smethod_12((Form)(object)this) as Form1).timer1);
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
			int num = 1538403925;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x167DA54u) % 4u)
				{
				case 1u:
					Form3.smethod_0((Control)(object)NullButton);
					Form3.smethod_14((Control)(object)button7, bool_0: false);
					num = ((int)num2 * -1890299291) ^ -344684671;
					continue;
				case 0u:
					num = ((int)num2 * -1299444511) ^ 0x687DEEB3;
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
			int num = -1189963624;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xB7C216B5u) % 8u)
				{
				case 7u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -1275281384;
						num5 = -1275281384;
					}
					else
					{
						num4 = -1041116719;
						num5 = -1041116719;
					}
					num = num4 ^ (int)(num2 * 94023209);
					continue;
				}
				case 5u:
					if (disposing)
					{
						num = ((int)num2 * -680918738) ^ -814800189;
						continue;
					}
					num3 = 0;
					goto IL_003d;
				case 4u:
					Form3.smethod_18((IDisposable)components);
					num = ((int)num2 * -1398039078) ^ -76583641;
					continue;
				case 3u:
					num = (int)(num2 * 1480951288) ^ -1969822879;
					continue;
				case 2u:
					((Form)this).Dispose(disposing);
					num = -234633972;
					continue;
				case 0u:
					num3 = ((components != null) ? 1 : 0);
					goto IL_003d;
				default:
					return;
				case 6u:
					break;
				case 1u:
					return;
					IL_003d:
					flag = (byte)num3 != 0;
					num = -590322310;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		components = Form3.smethod_19();
		while (true)
		{
			int num = -427554206;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB016072Au) % 123u)
				{
				case 122u:
					errorProvider1 = Form3.smethod_23(components);
					num = (int)((num2 * 71379946) ^ 0x29DE4AA3);
					continue;
				case 121u:
					num = ((int)num2 * -162529677) ^ 0x62F9C932;
					continue;
				case 120u:
					Form3.smethod_36((Control)(object)button4, (EventHandler)Button4_Click);
					num = (int)((num2 * 1126892131) ^ 0x28FDCF75);
					continue;
				case 119u:
					Form3.smethod_35((Control)(object)button2, "Регистрация");
					num = ((int)num2 * -1353574309) ^ -1335330195;
					continue;
				case 117u:
					num = (int)((num2 * 1844093072) ^ 0x3F4E6683);
					continue;
				case 116u:
					Form3.smethod_31((Control)(object)button7, "button7");
					Form3.smethod_32((Control)(object)button7, new Size(140, 50));
					num = ((int)num2 * -1249314836) ^ -1804743450;
					continue;
				case 115u:
					num = ((int)num2 * -34071317) ^ -572513140;
					continue;
				case 114u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button5), 0);
					Form3.smethod_29((ButtonBase)(object)button5, (FlatStyle)0);
					num = (int)(num2 * 1868955861) ^ -354489062;
					continue;
				case 113u:
					Form3.smethod_34((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -1919457261) ^ -1849288040;
					continue;
				case 112u:
					Form3.smethod_29((ButtonBase)(object)button4, (FlatStyle)0);
					Form3.smethod_38((Control)(object)button4, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -937865911) ^ 0x635A7472;
					continue;
				case 111u:
					num = (int)((num2 * 335437449) ^ 0x4BAB8F9C);
					continue;
				case 110u:
					Form3.smethod_36((Control)(object)button7, (EventHandler)Button7_Click);
					num = (int)(num2 * 2057493369) ^ -168369328;
					continue;
				case 109u:
					Form3.smethod_42(errorProvider1, (ContainerControl)(object)this);
					num = (int)((num2 * 963552325) ^ 0x3742B0AE);
					continue;
				case 108u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)NullButton);
					num = (int)((num2 * 86499164) ^ 0x7C83D654);
					continue;
				case 107u:
					Form3.smethod_35((Control)(object)label1, "QUARTO");
					num = (int)(num2 * 463989985) ^ -1567586691;
					continue;
				case 106u:
					Form3.smethod_29((ButtonBase)(object)button7, (FlatStyle)0);
					num = ((int)num2 * -480623029) ^ 0x24D5FFCC;
					continue;
				case 105u:
					num = (int)(num2 * 9736756) ^ -1779894069;
					continue;
				case 104u:
					Form3.smethod_38((Control)(object)button5, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 574374133) ^ 0x2113271C);
					continue;
				case 103u:
					num = (int)((num2 * 1160479207) ^ 0xB1F5345);
					continue;
				case 102u:
					num = (int)(num2 * 902663162) ^ -925570539;
					continue;
				case 101u:
					Form3.smethod_38((Control)(object)button7, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -135900565) ^ -840063395;
					continue;
				case 100u:
					num = ((int)num2 * -1063898693) ^ -559267504;
					continue;
				case 99u:
					Form3.smethod_49((Form)(object)this, bool_0: false);
					Form3.smethod_50((Form)(object)this, bool_0: false);
					num = ((int)num2 * -320750781) ^ -1485670466;
					continue;
				case 98u:
					Form3.smethod_26((Control)(object)NullButton, Color.Transparent);
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)NullButton), 0);
					num = ((int)num2 * -1635116925) ^ 0x1FA79BF5;
					continue;
				case 97u:
					Form3.smethod_57((Control)(object)this);
					num = ((int)num2 * -859408223) ^ 0x20845845;
					continue;
				case 96u:
					Form3.smethod_32((Control)(object)label1, new Size(207, 76));
					num = ((int)num2 * -1387095771) ^ 0x536C32F7;
					continue;
				case 95u:
					Form3.smethod_33((Control)(object)button1, 0);
					num = ((int)num2 * -2028558384) ^ -1467323809;
					continue;
				case 94u:
					num = ((int)num2 * -481018771) ^ -1588321598;
					continue;
				case 93u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button5);
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button4);
					num = ((int)num2 * -1784346308) ^ 0x11922C18;
					continue;
				case 92u:
					num = (int)(num2 * 953226584) ^ -1255930739;
					continue;
				case 91u:
					Form3.smethod_30((Control)(object)NullButton, new Point(-1, -1));
					num = ((int)num2 * -1783464340) ^ -165030456;
					continue;
				case 90u:
					Form3.smethod_48((Form)(object)this, (FormBorderStyle)0);
					num = (int)(num2 * 1556426325) ^ -1364642606;
					continue;
				case 89u:
					num = (int)((num2 * 799983673) ^ 0x79C33109);
					continue;
				case 88u:
					button1 = Form3.smethod_20();
					num = (int)((num2 * 406690605) ^ 0x65838AEA);
					continue;
				case 87u:
					num = ((int)num2 * -133576056) ^ -866550629;
					continue;
				case 86u:
					Form3.smethod_32((Control)(object)button2, new Size(85, 21));
					Form3.smethod_33((Control)(object)button2, 1);
					num = (int)(num2 * 474192840) ^ -1259058365;
					continue;
				case 85u:
					Form3.smethod_40((Control)(object)label1, bool_0: true);
					num = (int)((num2 * 1299172462) ^ 0x732F626F);
					continue;
				case 84u:
					Form3.smethod_30((Control)(object)button5, new Point(174, 190));
					num = ((int)num2 * -977331006) ^ 0x1B4F575D;
					continue;
				case 83u:
					num = (int)(num2 * 1034186843) ^ -1499809538;
					continue;
				case 82u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox2);
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox1);
					num = (int)(num2 * 422230201) ^ -344836566;
					continue;
				case 81u:
					Form3.smethod_33((Control)(object)button7, 6);
					num = (int)(num2 * 1620078449) ^ -1644548751;
					continue;
				case 80u:
					num = ((int)num2 * -1896130596) ^ -608332568;
					continue;
				case 79u:
					button2 = Form3.smethod_20();
					button4 = Form3.smethod_20();
					num = ((int)num2 * -1524777049) ^ 0x3C548B33;
					continue;
				case 78u:
					Form3.smethod_55((ISupportInitialize)errorProvider1);
					Form3.smethod_56((Control)(object)this, bool_0: false);
					num = ((int)num2 * -1150454922) ^ -173269892;
					continue;
				case 77u:
					Form3.smethod_36((Control)(object)button1, (EventHandler)Button1_Click);
					Form3.smethod_30((Control)(object)button2, new Point(174, 49));
					num = ((int)num2 * -478548005) ^ -1344480268;
					continue;
				case 76u:
					Form3.smethod_30((Control)(object)label1, new Point(140, 70));
					Form3.smethod_31((Control)(object)label1, "label1");
					num = ((int)num2 * -1464062315) ^ 0x16C446DF;
					continue;
				case 75u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button1);
					num = (int)(num2 * 1445109880) ^ -1249110105;
					continue;
				case 74u:
					num = (int)((num2 * 171213300) ^ 0x39B61A25);
					continue;
				case 73u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button4), 0);
					num = ((int)num2 * -450537983) ^ -708431283;
					continue;
				case 72u:
					Form3.smethod_36((Control)(object)button5, (EventHandler)Button5_Click);
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button7), 0);
					num = ((int)num2 * -1560178600) ^ -650122959;
					continue;
				case 71u:
					Form3.smethod_35((Control)(object)button1, "Вход");
					num = (int)((num2 * 455435048) ^ 0x793E23D2);
					continue;
				case 70u:
					label1 = Form3.smethod_22();
					num = ((int)num2 * -799406031) ^ 0x68BBA26E;
					continue;
				case 69u:
					Form3.smethod_54((Form)(object)this, bool_0: true);
					num = (int)((num2 * 20925458) ^ 0x2AC1AE7E);
					continue;
				case 68u:
					Form3.smethod_33((Control)(object)textBox1, 7);
					num = (int)(num2 * 1238294543) ^ -1602496784;
					continue;
				case 67u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button7);
					num = ((int)num2 * -732279242) ^ 0x725D556F;
					continue;
				case 66u:
					Form3.smethod_32((Control)(object)button4, new Size(140, 50));
					num = ((int)num2 * -1622919476) ^ 0x1B220D67;
					continue;
				case 65u:
					NullButton = Form3.smethod_20();
					num = ((int)num2 * -1982875017) ^ 0x3F4ADBDE;
					continue;
				case 64u:
					Form3.smethod_41(textBox2, bool_0: true);
					num = (int)(num2 * 1714091188) ^ -322299574;
					continue;
				case 63u:
					num = ((int)num2 * -1647836993) ^ -1643398833;
					continue;
				case 62u:
					Form3.smethod_34((ButtonBase)(object)button2, bool_0: true);
					num = ((int)num2 * -1495136719) ^ -480439352;
					continue;
				case 61u:
					Form3.smethod_30((Control)(object)textBox1, new Point(174, 2));
					Form3.smethod_31((Control)(object)textBox1, "textBox1");
					num = (int)((num2 * 1378424856) ^ 0x7657F557);
					continue;
				case 60u:
					num = (int)(num2 * 1638495848) ^ -436505411;
					continue;
				case 59u:
					Form3.smethod_29((ButtonBase)(object)NullButton, (FlatStyle)0);
					num = ((int)num2 * -36228057) ^ -1752861398;
					continue;
				case 58u:
					Form3.smethod_26((Control)(object)this, Color.White);
					Form3.smethod_45((Form)(object)this, new Size(486, 296));
					num = (int)((num2 * 1342630125) ^ 0x13B470D8);
					continue;
				case 57u:
					num = ((int)num2 * -127845676) ^ -844442070;
					continue;
				case 56u:
					Form3.smethod_35((Control)(object)button7, "Достижения");
					Form3.smethod_34((ButtonBase)(object)button7, bool_0: true);
					num = ((int)num2 * -1794550794) ^ 0x220BF925;
					continue;
				case 55u:
					Form3.smethod_32((Control)(object)button5, new Size(140, 50));
					num = (int)((num2 * 2032309895) ^ 0x6BBD7D69);
					continue;
				case 54u:
					num = (int)(num2 * 17512967) ^ -2104061051;
					continue;
				case 53u:
					Form3.smethod_53((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1604202100) ^ -1047624512;
					continue;
				case 52u:
					num = ((int)num2 * -661668191) ^ 0x7A0B5E5F;
					continue;
				case 51u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button2);
					num = (int)((num2 * 459308224) ^ 0x44765DBE);
					continue;
				case 50u:
					Form3.smethod_14((Control)(object)button4, bool_0: false);
					num = (int)(num2 * 185963264) ^ -268560655;
					continue;
				case 49u:
					num = (int)(num2 * 1706564834) ^ -1576393867;
					continue;
				case 48u:
					num = ((int)num2 * -383909985) ^ -1872613148;
					continue;
				case 47u:
					Form3.smethod_33((Control)(object)NullButton, 3);
					Form3.smethod_34((ButtonBase)(object)NullButton, bool_0: false);
					Form3.smethod_30((Control)(object)button1, new Point(265, 49));
					num = ((int)num2 * -347548901) ^ -861903567;
					continue;
				case 46u:
					Form3.smethod_39((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -1811147825) ^ 0x32FBBB6B;
					continue;
				case 45u:
					Form3.smethod_39((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -488040177) ^ -704797061;
					continue;
				case 44u:
					Form3.smethod_36((Control)(object)button2, (EventHandler)Button2_Click);
					num = (int)((num2 * 1213436061) ^ 0x401E415);
					continue;
				case 43u:
					num = (int)((num2 * 1895701986) ^ 0x7E2AB122);
					continue;
				case 42u:
					num = ((int)num2 * -1955474213) ^ 0x775639E2;
					continue;
				case 41u:
					Form3.smethod_25((Control)(object)this);
					num = (int)((num2 * 1039767693) ^ 0x70A10109);
					continue;
				case 40u:
					Form3.smethod_52((Form)(object)this, bool_0: false);
					num = ((int)num2 * -485693207) ^ 0x4BE69032;
					continue;
				case 39u:
					num = (int)(num2 * 840731123) ^ -859350347;
					continue;
				case 38u:
					Form3.smethod_44((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -1417081430) ^ -1194972908;
					continue;
				case 37u:
					Form3.smethod_31((Control)(object)button4, "button4");
					num = (int)((num2 * 119166015) ^ 0x968D492);
					continue;
				case 36u:
					Form3.smethod_30((Control)(object)textBox2, new Point(174, 26));
					Form3.smethod_31((Control)(object)textBox2, "textBox2");
					num = ((int)num2 * -661660276) ^ 0xCE116E3;
					continue;
				case 35u:
					Form3.smethod_26((Control)(object)label1, Color.Transparent);
					num = ((int)num2 * -327107768) ^ -1772101271;
					continue;
				case 34u:
					Form3.smethod_32((Control)(object)NullButton, new Size(1, 1));
					num = ((int)num2 * -1916809376) ^ -326029121;
					continue;
				case 33u:
					num = (int)((num2 * 282289712) ^ 0x306785E8);
					continue;
				case 32u:
					Form3.smethod_24((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -1316293163) ^ -444094298;
					continue;
				case 31u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)label1);
					num = (int)((num2 * 608413202) ^ 0x302C0588);
					continue;
				case 30u:
					button5 = Form3.smethod_20();
					button7 = Form3.smethod_20();
					textBox1 = Form3.smethod_21();
					num = ((int)num2 * -2100105144) ^ 0x9C889E;
					continue;
				case 29u:
					Form3.smethod_30((Control)(object)button7, new Point(174, 243));
					num = (int)(num2 * 1980029684) ^ -444419708;
					continue;
				case 27u:
					Form3.smethod_31((Control)(object)button1, "button1");
					Form3.smethod_32((Control)(object)button1, new Size(49, 21));
					num = ((int)num2 * -1813937430) ^ 0x19A70DE2;
					continue;
				case 26u:
					Form3.smethod_43((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -1052749122) ^ 0x5F145D96;
					continue;
				case 25u:
					num = (int)(num2 * 1127470213) ^ -331137170;
					continue;
				case 24u:
					Form3.smethod_31((Control)(object)button5, "button5");
					num = (int)((num2 * 798385346) ^ 0x5C2281B1);
					continue;
				case 23u:
					textBox2 = Form3.smethod_21();
					num = (int)(num2 * 67579112) ^ -777231497;
					continue;
				case 22u:
					num = ((int)num2 * -715837835) ^ -1161753905;
					continue;
				case 21u:
					Form3.smethod_31((Control)(object)button2, "button2");
					num = ((int)num2 * -1808416438) ^ 0x2BE99CD5;
					continue;
				case 20u:
					num = (int)(num2 * 10313282) ^ -1224028188;
					continue;
				case 19u:
					Form3.smethod_33((Control)(object)button5, 5);
					num = ((int)num2 * -877078965) ^ 0x300CEBE6;
					continue;
				case 18u:
					num = (int)(num2 * 881620638) ^ -320235235;
					continue;
				case 17u:
					num = (int)(num2 * 187833948) ^ -397933870;
					continue;
				case 16u:
					Form3.smethod_14((Control)(object)button5, bool_0: false);
					num = (int)((num2 * 1730981419) ^ 0x72C308BD);
					continue;
				case 15u:
					Form3.smethod_33((Control)(object)label1, 7);
					num = ((int)num2 * -1219525936) ^ -1728269694;
					continue;
				case 14u:
					Form3.smethod_32((Control)(object)textBox1, new Size(140, 20));
					num = ((int)num2 * -1387921958) ^ 0x622D0A33;
					continue;
				case 13u:
					Form3.smethod_34((ButtonBase)(object)button5, bool_0: true);
					num = ((int)num2 * -658244657) ^ -462446237;
					continue;
				case 12u:
					Form3.smethod_31((Control)(object)NullButton, "NullButton");
					num = ((int)num2 * -1696091595) ^ 0x75D96E52;
					continue;
				case 11u:
					num = (int)((num2 * 1954923467) ^ 0x66F535BB);
					continue;
				case 10u:
					Form3.smethod_51((Control)(object)this, "Form3");
					num = ((int)num2 * -1125758784) ^ -202254456;
					continue;
				case 9u:
					num = ((int)num2 * -1981071983) ^ -1250261526;
					continue;
				case 8u:
					num = (int)(num2 * 1139474536) ^ -600680815;
					continue;
				case 7u:
					num = (int)((num2 * 1452046392) ^ 0x3A88A65D);
					continue;
				case 6u:
					Form3.smethod_33((Control)(object)button4, 4);
					Form3.smethod_35((Control)(object)button4, "Начало игры");
					num = (int)(num2 * 887663264) ^ -346560351;
					continue;
				case 5u:
					Form3.smethod_30((Control)(object)button4, new Point(174, 137));
					num = ((int)num2 * -19147369) ^ 0x75E3ADA8;
					continue;
				case 4u:
					Form3.smethod_35((Control)(object)button5, "Продолжить");
					num = (int)((num2 * 30488410) ^ 0x74478545);
					continue;
				case 3u:
					Form3.smethod_32((Control)(object)textBox2, new Size(140, 20));
					Form3.smethod_33((Control)(object)textBox2, 8);
					num = ((int)num2 * -59063412) ^ 0x33C3E431;
					continue;
				case 2u:
					Form3.smethod_38((Control)(object)label1, Form3.smethod_37("Mistral", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -567243958) ^ -1487658074;
					continue;
				case 1u:
					num = (int)(num2 * 1882290197) ^ -62779805;
					continue;
				case 0u:
					Form3.smethod_34((ButtonBase)(object)button4, bool_0: true);
					num = ((int)num2 * -1548088932) ^ 0x3FC4E4C;
					continue;
				default:
					return;
				case 28u:
					break;
				case 118u:
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
