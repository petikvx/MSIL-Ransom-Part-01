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
			int num = -366812949;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF1378F90u) % 5u)
				{
				case 4u:
					InitializeComponent();
					num = ((int)num2 * -1375287555) ^ 0x1A061A93;
					continue;
				case 3u:
					num = (int)((num2 * 1484050317) ^ 0x781B21E4);
					continue;
				case 2u:
					num = (int)(num2 * 1630265006) ^ -1297928197;
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

	private void Button2_Click(object sender, EventArgs e)
	{
		Form val = default(Form);
		while (true)
		{
			int num = 522896631;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x264A7DDEu) % 7u)
				{
				case 6u:
					Form3.smethod_10(val, new Point(Form3.smethod_5((Form)(object)this).X + (Form3.smethod_6((Control)(object)this) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_5((Form)(object)this).Y + (Form3.smethod_8((Control)(object)this) - Form3.smethod_9((Control)(object)val)) / 2 + 70));
					num = ((int)num2 * -906977811) ^ 0x4C5180F3;
					continue;
				case 5u:
					num = (int)(num2 * 1627269026) ^ -818457616;
					continue;
				case 2u:
					num = (int)(num2 * 467646769) ^ -1597615745;
					continue;
				case 1u:
				{
					Form3.smethod_0((Control)(object)NullButton);
					Form3.smethod_1(errorProvider1);
					Form4 form = new Form4();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					num = ((int)num2 * -1167740877) ^ -1721525097;
					continue;
				}
				case 0u:
					Form3.smethod_4((Control)(object)val);
					num = ((int)num2 * -1203995470) ^ -1198341618;
					continue;
				case 4u:
					break;
				default:
					Form3.smethod_11((Control)(object)this, bool_0: false);
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
		Form3.smethod_4((Control)(object)val);
		while (true)
		{
			int num = 44776490;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7E4C2F0Au) % 7u)
				{
				case 5u:
					Form3.smethod_10(val, new Point(Form3.smethod_13(Form3.smethod_12((Form)(object)this)).X + (Form3.smethod_7((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_13(Form3.smethod_12((Form)(object)this)).Y + (Form3.smethod_9((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_9((Control)(object)val)) / 2));
					num = (int)(num2 * 540958775) ^ -1205948747;
					continue;
				case 4u:
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = (int)(num2 * 792010683) ^ -1595103846;
					continue;
				case 2u:
					num = ((int)num2 * -976706091) ^ -2053356520;
					continue;
				case 1u:
					num = (int)((num2 * 440845498) ^ 0x5DA5BA0E);
					continue;
				case 0u:
					num = ((int)num2 * -1460790777) ^ 0x1B4B6A0B;
					continue;
				default:
					return;
				case 6u:
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
		bool flag = default(bool);
		while (true)
		{
			int num = -3656053;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x87388256u) % 11u)
				{
				case 8u:
					num3 = Form3.smethod_8((Control)(object)this) - 1;
					num = -1161923293;
					continue;
				case 7u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 484993970;
						num5 = 484993970;
					}
					else
					{
						num4 = 1458485555;
						num5 = 1458485555;
					}
					num = num4 ^ (int)(num2 * 27798372);
					continue;
				}
				case 6u:
					num = (int)(num2 * 447909686) ^ -446320934;
					continue;
				case 5u:
					num = -1732860526;
					continue;
				case 4u:
					Form3.smethod_15((Control)(object)this, num3);
					num = ((int)num2 * -403343886) ^ -1303392727;
					continue;
				case 3u:
					Form3.smethod_16(Form3.smethod_12((Form)(object)this));
					num = (int)((num2 * 235762495) ^ 0xAF5D016);
					continue;
				case 2u:
					flag = num3 > 1;
					num = ((int)num2 * -1461381766) ^ -2098868200;
					continue;
				case 1u:
					num = (int)((num2 * 537994175) ^ 0x5E488271);
					continue;
				case 0u:
					Form3.smethod_17((Form3.smethod_12((Form)(object)this) as Form1).timer1);
					num = ((int)num2 * -568159754) ^ 0x41EAAD1;
					continue;
				default:
					return;
				case 9u:
					break;
				case 10u:
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
			int num = -2075081039;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD4AE3E58u) % 4u)
				{
				case 2u:
					Form3.smethod_14((Control)(object)button7, bool_0: false);
					num = (int)((num2 * 961643274) ^ 0x18EAF0E8);
					continue;
				case 1u:
					Form3.smethod_0((Control)(object)NullButton);
					num = (int)((num2 * 1855077372) ^ 0x1E495C8E);
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

	protected override void Dispose(bool disposing)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -1233649670;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xB1785B5Au) % 9u)
				{
				case 8u:
					num = (int)((num2 * 1719165273) ^ 0xCFFEE00);
					continue;
				case 6u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -508182528;
						num5 = -508182528;
					}
					else
					{
						num4 = -1288581744;
						num5 = -1288581744;
					}
					num = num4 ^ (int)(num2 * 161396523);
					continue;
				}
				case 5u:
					Form3.smethod_18((IDisposable)components);
					num = (int)((num2 * 1455980666) ^ 0x65E375AF);
					continue;
				case 4u:
					((Form)this).Dispose(disposing);
					num = -1968090282;
					continue;
				case 3u:
					num = ((int)num2 * -387400276) ^ -841324591;
					continue;
				case 1u:
					if (disposing)
					{
						num = ((int)num2 * -1303602215) ^ 0x65FA973A;
						continue;
					}
					num3 = 0;
					goto IL_0086;
				case 0u:
					num3 = ((components != null) ? 1 : 0);
					goto IL_0086;
				default:
					return;
				case 2u:
					break;
				case 7u:
					return;
					IL_0086:
					flag = (byte)num3 != 0;
					num = -683263701;
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
			int num = -1006118042;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE294A06Bu) % 107u)
				{
				case 106u:
					Form3.smethod_51((Control)(object)this, "Form3");
					num = (int)(num2 * 204281095) ^ -1791257754;
					continue;
				case 105u:
					Form3.smethod_36((Control)(object)button2, (EventHandler)Button2_Click);
					num = ((int)num2 * -1975641585) ^ 0x2F4AC1E2;
					continue;
				case 104u:
					Form3.smethod_36((Control)(object)button5, (EventHandler)Button5_Click);
					num = ((int)num2 * -144477901) ^ 0x7CC5765;
					continue;
				case 103u:
					num = (int)(num2 * 457492794) ^ -1531904084;
					continue;
				case 102u:
					Form3.smethod_33((Control)(object)button2, 1);
					num = (int)(num2 * 2079150184) ^ -1967451971;
					continue;
				case 101u:
					num = (int)(num2 * 1839456005) ^ -745523768;
					continue;
				case 100u:
					Form3.smethod_35((Control)(object)label1, "QUARTO");
					Form3.smethod_30((Control)(object)textBox2, new Point(174, 26));
					num = ((int)num2 * -1031019128) ^ -109106265;
					continue;
				case 99u:
					num = ((int)num2 * -1403967218) ^ -1211851402;
					continue;
				case 97u:
					num = (int)((num2 * 610167478) ^ 0x21EDC780);
					continue;
				case 96u:
					Form3.smethod_35((Control)(object)button1, "Вход");
					num = ((int)num2 * -2033843664) ^ 0x4DB80422;
					continue;
				case 95u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button5), 0);
					num = ((int)num2 * -872897286) ^ 0x6117F1D8;
					continue;
				case 94u:
					Form3.smethod_35((Control)(object)button7, "Достижения");
					Form3.smethod_34((ButtonBase)(object)button7, bool_0: true);
					num = (int)((num2 * 199695453) ^ 0x184F26E7);
					continue;
				case 93u:
					Form3.smethod_32((Control)(object)textBox2, new Size(140, 20));
					num = ((int)num2 * -2144203042) ^ -2073971706;
					continue;
				case 92u:
					Form3.smethod_31((Control)(object)textBox1, "textBox1");
					Form3.smethod_32((Control)(object)textBox1, new Size(140, 20));
					num = (int)(num2 * 1411397882) ^ -1770041826;
					continue;
				case 91u:
					Form3.smethod_42(errorProvider1, (ContainerControl)(object)this);
					num = ((int)num2 * -616746753) ^ -1021476374;
					continue;
				case 90u:
					Form3.smethod_33((Control)(object)textBox1, 7);
					num = ((int)num2 * -760519047) ^ -1114915997;
					continue;
				case 89u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button7), 0);
					num = ((int)num2 * -51008462) ^ 0x59B35F8C;
					continue;
				case 88u:
					Form3.smethod_33((Control)(object)NullButton, 3);
					num = (int)((num2 * 713299645) ^ 0x270C20B6);
					continue;
				case 87u:
					Form3.smethod_38((Control)(object)button4, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 929257982) ^ -1937791205;
					continue;
				case 86u:
					Form3.smethod_32((Control)(object)button5, new Size(140, 50));
					num = (int)((num2 * 1747175082) ^ 0x3EC0440E);
					continue;
				case 85u:
					Form3.smethod_30((Control)(object)button5, new Point(174, 190));
					num = ((int)num2 * -330396428) ^ 0x5F1CCE7F;
					continue;
				case 84u:
					Form3.smethod_32((Control)(object)button7, new Size(140, 50));
					Form3.smethod_33((Control)(object)button7, 6);
					num = ((int)num2 * -376977727) ^ -1077807919;
					continue;
				case 83u:
					Form3.smethod_30((Control)(object)NullButton, new Point(-1, -1));
					num = ((int)num2 * -1578140307) ^ 0x150F74E8;
					continue;
				case 82u:
					Form3.smethod_26((Control)(object)this, Color.White);
					num = (int)(num2 * 1422985888) ^ -776403812;
					continue;
				case 81u:
					Form3.smethod_33((Control)(object)button5, 5);
					num = (int)((num2 * 488862182) ^ 0x342F0918);
					continue;
				case 80u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button2);
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button1);
					num = (int)((num2 * 1709163166) ^ 0x16D386BA);
					continue;
				case 79u:
					Form3.smethod_30((Control)(object)button1, new Point(265, 49));
					Form3.smethod_31((Control)(object)button1, "button1");
					num = ((int)num2 * -817603754) ^ 0x6928F640;
					continue;
				case 78u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button4);
					num = ((int)num2 * -1002459118) ^ 0x2B4E79DD;
					continue;
				case 77u:
					button7 = Form3.smethod_20();
					textBox1 = Form3.smethod_21();
					num = ((int)num2 * -967340405) ^ -131030684;
					continue;
				case 76u:
					Form3.smethod_34((ButtonBase)(object)NullButton, bool_0: false);
					num = (int)((num2 * 1529936369) ^ 0xB0937AB);
					continue;
				case 75u:
					num = (int)((num2 * 1499011004) ^ 0x2AA061D7);
					continue;
				case 74u:
					Form3.smethod_34((ButtonBase)(object)button5, bool_0: true);
					num = ((int)num2 * -941911313) ^ -1760757783;
					continue;
				case 73u:
					Form3.smethod_30((Control)(object)label1, new Point(140, 70));
					Form3.smethod_31((Control)(object)label1, "label1");
					num = ((int)num2 * -277937275) ^ -195271716;
					continue;
				case 72u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -1411190420) ^ 0x357E1CE1;
					continue;
				case 71u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)NullButton);
					Form3.smethod_48((Form)(object)this, (FormBorderStyle)0);
					num = (int)((num2 * 785388856) ^ 0x35B71534);
					continue;
				case 70u:
					Form3.smethod_30((Control)(object)button4, new Point(174, 137));
					num = (int)(num2 * 1218586910) ^ -117712430;
					continue;
				case 69u:
					Form3.smethod_43((ContainerControl)(object)this, new SizeF(6f, 13f));
					Form3.smethod_44((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 25174500) ^ 0x4058CFD3);
					continue;
				case 68u:
					num = ((int)num2 * -1201725709) ^ -663938344;
					continue;
				case 67u:
					num = (int)(num2 * 1147594998) ^ -623129972;
					continue;
				case 66u:
					Form3.smethod_33((Control)(object)label1, 7);
					num = ((int)num2 * -1853626554) ^ -88838286;
					continue;
				case 65u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button7);
					num = (int)((num2 * 533075655) ^ 0x77CA63CE);
					continue;
				case 64u:
					num = (int)(num2 * 1086526865) ^ -1142202541;
					continue;
				case 63u:
					Form3.smethod_49((Form)(object)this, bool_0: false);
					Form3.smethod_50((Form)(object)this, bool_0: false);
					num = ((int)num2 * -2010718700) ^ 0x1F414BE6;
					continue;
				case 62u:
					Form3.smethod_45((Form)(object)this, new Size(486, 296));
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox2);
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox1);
					num = (int)(num2 * 464864088) ^ -1975257819;
					continue;
				case 61u:
					button5 = Form3.smethod_20();
					num = ((int)num2 * -1291476135) ^ -1482931837;
					continue;
				case 60u:
					Form3.smethod_34((ButtonBase)(object)button1, bool_0: true);
					num = (int)((num2 * 1752952922) ^ 0xF3C20D5);
					continue;
				case 59u:
					Form3.smethod_26((Control)(object)label1, Color.Transparent);
					num = (int)(num2 * 36708640) ^ -1041674106;
					continue;
				case 58u:
					Form3.smethod_32((Control)(object)button4, new Size(140, 50));
					num = (int)(num2 * 1653994586) ^ -1142138017;
					continue;
				case 57u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button5);
					num = (int)((num2 * 1121099170) ^ 0x16DBF93);
					continue;
				case 56u:
					num = ((int)num2 * -563312970) ^ -1865340095;
					continue;
				case 55u:
					Form3.smethod_29((ButtonBase)(object)button5, (FlatStyle)0);
					Form3.smethod_38((Control)(object)button5, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1758026552) ^ -693064340;
					continue;
				case 54u:
					num = (int)(num2 * 1924489092) ^ -1388411810;
					continue;
				case 53u:
					num = ((int)num2 * -606505309) ^ 0x32AD2ED8;
					continue;
				case 52u:
					Form3.smethod_24((ISupportInitialize)errorProvider1);
					Form3.smethod_25((Control)(object)this);
					Form3.smethod_26((Control)(object)NullButton, Color.Transparent);
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)NullButton), 0);
					Form3.smethod_29((ButtonBase)(object)NullButton, (FlatStyle)0);
					num = ((int)num2 * -1304715518) ^ -1493500674;
					continue;
				case 51u:
					num = (int)((num2 * 1511482684) ^ 0x15C567A0);
					continue;
				case 50u:
					components = Form3.smethod_19();
					NullButton = Form3.smethod_20();
					num = ((int)num2 * -688305017) ^ 0x323D06F5;
					continue;
				case 49u:
					Form3.smethod_29((ButtonBase)(object)button7, (FlatStyle)0);
					num = (int)(num2 * 564077945) ^ -1539517510;
					continue;
				case 48u:
					button2 = Form3.smethod_20();
					button4 = Form3.smethod_20();
					num = (int)((num2 * 1709166878) ^ 0x1AA67E9F);
					continue;
				case 47u:
					Form3.smethod_31((Control)(object)button4, "button4");
					num = ((int)num2 * -258247148) ^ 0xC09D64D;
					continue;
				case 46u:
					Form3.smethod_38((Control)(object)button7, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 204483386) ^ 0x12CEB607);
					continue;
				case 45u:
					Form3.smethod_56((Control)(object)this, bool_0: false);
					num = (int)((num2 * 2041928731) ^ 0x7C773FD9);
					continue;
				case 44u:
					Form3.smethod_54((Form)(object)this, bool_0: true);
					Form3.smethod_55((ISupportInitialize)errorProvider1);
					num = (int)(num2 * 479234438) ^ -1378791287;
					continue;
				case 43u:
					Form3.smethod_38((Control)(object)label1, Form3.smethod_37("Mistral", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -501833882) ^ -506095194;
					continue;
				case 42u:
					Form3.smethod_32((Control)(object)label1, new Size(207, 76));
					num = ((int)num2 * -838478307) ^ 0x2FB55476;
					continue;
				case 41u:
					Form3.smethod_29((ButtonBase)(object)button4, (FlatStyle)0);
					num = (int)((num2 * 1393588021) ^ 0x17B70E76);
					continue;
				case 40u:
					num = ((int)num2 * -1182248334) ^ 0x28EC5A43;
					continue;
				case 39u:
					Form3.smethod_36((Control)(object)button4, (EventHandler)Button4_Click);
					num = (int)(num2 * 1619223192) ^ -1453832097;
					continue;
				case 38u:
					num = ((int)num2 * -830775558) ^ -2023469613;
					continue;
				case 37u:
					Form3.smethod_32((Control)(object)button1, new Size(49, 21));
					Form3.smethod_33((Control)(object)button1, 0);
					num = (int)((num2 * 217798804) ^ 0x37EDDC94);
					continue;
				case 36u:
					num = ((int)num2 * -1985330478) ^ 0x584109A1;
					continue;
				case 35u:
					Form3.smethod_31((Control)(object)NullButton, "NullButton");
					Form3.smethod_32((Control)(object)NullButton, new Size(1, 1));
					num = (int)(num2 * 697901909) ^ -1231090232;
					continue;
				case 34u:
					Form3.smethod_31((Control)(object)button5, "button5");
					num = (int)(num2 * 745038590) ^ -497012584;
					continue;
				case 33u:
					Form3.smethod_31((Control)(object)button7, "button7");
					num = ((int)num2 * -1280663863) ^ 0x6EDFC235;
					continue;
				case 32u:
					label1 = Form3.smethod_22();
					textBox2 = Form3.smethod_21();
					num = (int)(num2 * 1704053571) ^ -920604415;
					continue;
				case 31u:
					Form3.smethod_39((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = (int)(num2 * 1823819818) ^ -811492646;
					continue;
				case 30u:
					num = ((int)num2 * -1901272186) ^ -1528067115;
					continue;
				case 29u:
					Form3.smethod_36((Control)(object)button7, (EventHandler)Button7_Click);
					Form3.smethod_30((Control)(object)textBox1, new Point(174, 2));
					num = (int)(num2 * 2146181547) ^ -724878605;
					continue;
				case 28u:
					num = ((int)num2 * -2107926245) ^ 0x1396272A;
					continue;
				case 27u:
					Form3.smethod_35((Control)(object)button5, "Продолжить");
					num = ((int)num2 * -292886003) ^ -540351054;
					continue;
				case 26u:
					Form3.smethod_39((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -46697341) ^ -1451930462;
					continue;
				case 25u:
					Form3.smethod_53((Form)(object)this, bool_0: false);
					num = ((int)num2 * -748523296) ^ -9011845;
					continue;
				case 24u:
					Form3.smethod_14((Control)(object)button4, bool_0: false);
					num = ((int)num2 * -246618309) ^ -1908910502;
					continue;
				case 23u:
					Form3.smethod_36((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -1685272307) ^ -197497668;
					continue;
				case 22u:
					errorProvider1 = Form3.smethod_23(components);
					num = ((int)num2 * -1748442454) ^ 0x797257CB;
					continue;
				case 21u:
					Form3.smethod_33((Control)(object)textBox2, 8);
					num = (int)(num2 * 1149144423) ^ -775395441;
					continue;
				case 20u:
					Form3.smethod_41(textBox2, bool_0: true);
					num = (int)((num2 * 900500779) ^ 0x2D43D54E);
					continue;
				case 19u:
					Form3.smethod_35((Control)(object)button4, "Начало игры");
					Form3.smethod_34((ButtonBase)(object)button4, bool_0: true);
					num = ((int)num2 * -1941004581) ^ -1942660504;
					continue;
				case 18u:
					Form3.smethod_52((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1897691987) ^ -1486591432;
					continue;
				case 16u:
					Form3.smethod_32((Control)(object)button2, new Size(85, 21));
					num = (int)((num2 * 1646118793) ^ 0x56EA8A4D);
					continue;
				case 15u:
					Form3.smethod_31((Control)(object)textBox2, "textBox2");
					num = (int)((num2 * 931422186) ^ 0x74C74BB2);
					continue;
				case 14u:
					Form3.smethod_33((Control)(object)button4, 4);
					num = ((int)num2 * -1119086225) ^ 0x8E9D522;
					continue;
				case 13u:
					Form3.smethod_40((Control)(object)label1, bool_0: true);
					num = (int)(num2 * 252163514) ^ -539308925;
					continue;
				case 12u:
					Form3.smethod_35((Control)(object)button2, "Регистрация");
					Form3.smethod_34((ButtonBase)(object)button2, bool_0: true);
					num = (int)(num2 * 61116946) ^ -1445785472;
					continue;
				case 11u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button4), 0);
					num = ((int)num2 * -930550973) ^ 0x1E84142A;
					continue;
				case 10u:
					Form3.smethod_30((Control)(object)button2, new Point(174, 49));
					Form3.smethod_31((Control)(object)button2, "button2");
					num = (int)((num2 * 162020942) ^ 0x32B9A4D7);
					continue;
				case 9u:
					button1 = Form3.smethod_20();
					num = (int)((num2 * 1582968958) ^ 0x82A7BF6);
					continue;
				case 8u:
					num = ((int)num2 * -1574236296) ^ 0x5E336433;
					continue;
				case 7u:
					num = (int)(num2 * 1896855924) ^ -1576895147;
					continue;
				case 6u:
					num = ((int)num2 * -490579824) ^ 0x2B9AC7A0;
					continue;
				case 5u:
					num = ((int)num2 * -1029433060) ^ 0x3EAA74CC;
					continue;
				case 4u:
					num = ((int)num2 * -526423568) ^ 0x5450AD75;
					continue;
				case 3u:
					Form3.smethod_57((Control)(object)this);
					num = (int)((num2 * 1971787080) ^ 0x34A83013);
					continue;
				case 2u:
					Form3.smethod_30((Control)(object)button7, new Point(174, 243));
					num = ((int)num2 * -2097148280) ^ -101054972;
					continue;
				case 1u:
					Form3.smethod_14((Control)(object)button5, bool_0: false);
					num = ((int)num2 * -1682963054) ^ -93193792;
					continue;
				case 0u:
					num = ((int)num2 * -1427742155) ^ 0x369A5F14;
					continue;
				default:
					return;
				case 17u:
					break;
				case 98u:
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
