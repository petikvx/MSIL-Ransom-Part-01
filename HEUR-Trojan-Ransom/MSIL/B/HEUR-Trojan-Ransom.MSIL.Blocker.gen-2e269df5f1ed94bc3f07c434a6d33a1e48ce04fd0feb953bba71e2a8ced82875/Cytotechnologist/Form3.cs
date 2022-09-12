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
			int num = -1504075496;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x92FCEA6Eu) % 3u)
				{
				case 2u:
					goto IL_000f;
				case 0u:
					break;
				default:
					InitializeComponent();
					return;
				}
				break;
				IL_000f:
				num = (int)(num2 * 472142368) ^ -1592583548;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		Form val = default(Form);
		while (true)
		{
			int num = -933887048;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC406EC8Au) % 5u)
				{
				case 3u:
				{
					Form4 form = new Form4();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					num = ((int)num2 * -1167505741) ^ 0x7B72A98;
					continue;
				}
				case 2u:
					Form3.smethod_4((Control)(object)val);
					Form3.smethod_10(val, new Point(Form3.smethod_5((Form)(object)this).X + (Form3.smethod_6((Control)(object)this) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_5((Form)(object)this).Y + (Form3.smethod_8((Control)(object)this) - Form3.smethod_9((Control)(object)val)) / 2 + 70));
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = (int)((num2 * 411422708) ^ 0x6C470AAD);
					continue;
				case 1u:
					Form3.smethod_0((Control)(object)NullButton);
					Form3.smethod_1(errorProvider1);
					num = ((int)num2 * -940986830) ^ 0x5C6DB405;
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

	private void Button4_Click(object sender, EventArgs e)
	{
		Form val = default(Form);
		while (true)
		{
			int num = 1090936398;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x335390CBu) % 6u)
				{
				case 4u:
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = (int)(num2 * 788279688) ^ -1337386229;
					continue;
				case 2u:
					num = ((int)num2 * -2031108966) ^ 0x53949DAE;
					continue;
				case 1u:
				{
					Form3.smethod_0((Control)(object)NullButton);
					Form2 form = new Form2();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					Form3.smethod_4((Control)(object)val);
					num = (int)((num2 * 562827967) ^ 0x76832F6C);
					continue;
				}
				case 0u:
					Form3.smethod_10(val, new Point(Form3.smethod_13(Form3.smethod_12((Form)(object)this)).X + (Form3.smethod_7((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_13(Form3.smethod_12((Form)(object)this)).Y + (Form3.smethod_9((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_9((Control)(object)val)) / 2));
					num = (int)((num2 * 1873520031) ^ 0x2F40F759);
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
		while (true)
		{
			int num = -227257260;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA9CC5EEBu) % 3u)
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
				num = (int)((num2 * 278074506) ^ 0x513D6C77);
			}
		}
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = Form3.smethod_8((Control)(object)this) - 1;
			int num2 = 2001201452;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x742C1C57u) % 8u)
				{
				case 7u:
					num2 = 1492994682;
					continue;
				case 6u:
					num2 = 2024003184;
					continue;
				case 4u:
					flag = num > 1;
					num2 = ((int)num3 * -1449190682) ^ -1319755697;
					continue;
				case 3u:
					Form3.smethod_15((Control)(object)this, num);
					num2 = (int)((num3 * 1979391535) ^ 0x2103ABDE);
					continue;
				case 2u:
					Form3.smethod_16(Form3.smethod_12((Form)(object)this));
					num2 = (int)((num3 * 1521672872) ^ 0x2371BBD6);
					continue;
				case 0u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 2031784960;
						num5 = 2031784960;
					}
					else
					{
						num4 = 626748397;
						num5 = 626748397;
					}
					num2 = num4 ^ (int)(num3 * 690926173);
					continue;
				}
				case 5u:
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
		while (true)
		{
			int num = 800737691;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x536BEE54u) % 3u)
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
				num = ((int)num2 * -1296674303) ^ -1527530007;
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
		Form3.smethod_0((Control)(object)NullButton);
		while (true)
		{
			int num = 1049158817;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5213B030u) % 4u)
				{
				case 1u:
					Form3.smethod_14((Control)(object)button7, bool_0: false);
					num = (int)(num2 * 1786584249) ^ -1739175463;
					continue;
				case 0u:
					num = (int)(num2 * 1791678410) ^ -527046470;
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

	protected override void Dispose(bool disposing)
	{
		while (true)
		{
			int num = 1583359999;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x6CE2A82u) % 7u)
				{
				case 5u:
					Form3.smethod_18((IDisposable)components);
					num = (int)(num2 * 354393868) ^ -217274779;
					continue;
				case 4u:
					if (disposing)
					{
						num = ((int)num2 * -877922456) ^ 0x7894450E;
						continue;
					}
					goto IL_0041;
				case 3u:
					if (components != null)
					{
						num = 1580233906;
						num3 = 1580233906;
						continue;
					}
					goto IL_0041;
				case 2u:
					((Form)this).Dispose(disposing);
					num = 495849039;
					continue;
				case 1u:
					num = (int)((num2 * 892127725) ^ 0x728383AE);
					continue;
				default:
					return;
				case 6u:
					break;
				case 0u:
					return;
					IL_0041:
					num = 1131394101;
					num3 = 1131394101;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		components = Form3.smethod_19();
		NullButton = Form3.smethod_20();
		while (true)
		{
			int num = 93627464;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x40810F19u) % 139u)
				{
				case 138u:
					num = (int)((num2 * 400609641) ^ 0x38563D7B);
					continue;
				case 137u:
					num = (int)((num2 * 565386817) ^ 0x499DC8E7);
					continue;
				case 136u:
					Form3.smethod_36((Control)(object)button2, (EventHandler)Button2_Click);
					Form3.smethod_14((Control)(object)button4, bool_0: false);
					num = ((int)num2 * -1419130019) ^ 0x671F2E16;
					continue;
				case 135u:
					num = ((int)num2 * -1752469059) ^ 0x5FD59625;
					continue;
				case 134u:
					Form3.smethod_42(errorProvider1, (ContainerControl)(object)this);
					num = (int)((num2 * 783104109) ^ 0x1D2B0F04);
					continue;
				case 133u:
					button5 = Form3.smethod_20();
					num = ((int)num2 * -1913089772) ^ 0x7A276BAC;
					continue;
				case 132u:
					Form3.smethod_35((Control)(object)button2, "Регистрация");
					num = (int)(num2 * 1511058205) ^ -479916414;
					continue;
				case 131u:
					button1 = Form3.smethod_20();
					num = ((int)num2 * -1039271867) ^ -1689799704;
					continue;
				case 130u:
					Form3.smethod_31((Control)(object)button5, "button5");
					num = (int)((num2 * 1228058154) ^ 0x45FCBF37);
					continue;
				case 129u:
					Form3.smethod_35((Control)(object)label1, "QUARTO");
					num = (int)(num2 * 711246884) ^ -907000492;
					continue;
				case 128u:
					Form3.smethod_31((Control)(object)button4, "button4");
					num = ((int)num2 * -593708076) ^ 0x67098D45;
					continue;
				case 127u:
					num = ((int)num2 * -68412872) ^ 0x34CB95D9;
					continue;
				case 126u:
					Form3.smethod_57((Control)(object)this);
					num = ((int)num2 * -23691389) ^ 0x5BF4D6E0;
					continue;
				case 125u:
					Form3.smethod_31((Control)(object)label1, "label1");
					num = (int)((num2 * 423695926) ^ 0x4678F0CA);
					continue;
				case 124u:
					Form3.smethod_29((ButtonBase)(object)button5, (FlatStyle)0);
					num = (int)((num2 * 596799060) ^ 0x400F60F4);
					continue;
				case 123u:
					Form3.smethod_31((Control)(object)button7, "button7");
					num = ((int)num2 * -1119079715) ^ -1413155340;
					continue;
				case 122u:
					Form3.smethod_31((Control)(object)NullButton, "NullButton");
					num = (int)((num2 * 1776964969) ^ 0x16DFE99D);
					continue;
				case 121u:
					Form3.smethod_34((ButtonBase)(object)button7, bool_0: true);
					num = (int)(num2 * 1687027425) ^ -1193854825;
					continue;
				case 120u:
					Form3.smethod_41(textBox2, bool_0: true);
					num = ((int)num2 * -1915233122) ^ -50652076;
					continue;
				case 119u:
					Form3.smethod_35((Control)(object)button1, "Вход");
					Form3.smethod_34((ButtonBase)(object)button1, bool_0: true);
					num = (int)(num2 * 1384475002) ^ -306292270;
					continue;
				case 118u:
					Form3.smethod_51((Control)(object)this, "Form3");
					num = (int)((num2 * 83375185) ^ 0x6850472A);
					continue;
				case 117u:
					num = (int)(num2 * 555339073) ^ -212361695;
					continue;
				case 116u:
					num = ((int)num2 * -1273976745) ^ 0x2A1B1413;
					continue;
				case 115u:
					num = ((int)num2 * -2104174371) ^ 0x6AFAFA3C;
					continue;
				case 114u:
					Form3.smethod_29((ButtonBase)(object)button7, (FlatStyle)0);
					Form3.smethod_38((Control)(object)button7, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -275698223) ^ 0x2F2ABD58;
					continue;
				case 113u:
					Form3.smethod_30((Control)(object)button5, new Point(174, 190));
					num = ((int)num2 * -479102577) ^ -1350677409;
					continue;
				case 112u:
					Form3.smethod_32((Control)(object)textBox2, new Size(140, 20));
					num = (int)((num2 * 1817471919) ^ 0x7EF33413);
					continue;
				case 111u:
					Form3.smethod_56((Control)(object)this, bool_0: false);
					num = (int)(num2 * 718535950) ^ -164517541;
					continue;
				case 110u:
					Form3.smethod_33((Control)(object)NullButton, 3);
					num = (int)(num2 * 687825874) ^ -1049781829;
					continue;
				case 109u:
					num = (int)(num2 * 797331587) ^ -599212516;
					continue;
				case 108u:
					num = (int)(num2 * 603745730) ^ -172217970;
					continue;
				case 107u:
					Form3.smethod_33((Control)(object)button7, 6);
					num = (int)(num2 * 1996596298) ^ -951039053;
					continue;
				case 106u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button4), 0);
					num = ((int)num2 * -2139231134) ^ 0x557DC453;
					continue;
				case 105u:
					Form3.smethod_33((Control)(object)label1, 7);
					num = (int)(num2 * 922588816) ^ -792902734;
					continue;
				case 104u:
					num = (int)(num2 * 364438305) ^ -2047919768;
					continue;
				case 103u:
					Form3.smethod_35((Control)(object)button5, "Продолжить");
					num = ((int)num2 * -655873782) ^ -1988397598;
					continue;
				case 102u:
					Form3.smethod_35((Control)(object)button7, "Достижения");
					num = ((int)num2 * -939470144) ^ 0x314A334E;
					continue;
				case 101u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)NullButton), 0);
					num = (int)((num2 * 1004289391) ^ 0x5EEF81A7);
					continue;
				case 100u:
					Form3.smethod_30((Control)(object)NullButton, new Point(-1, -1));
					num = (int)(num2 * 984129181) ^ -1929223060;
					continue;
				case 99u:
					Form3.smethod_30((Control)(object)label1, new Point(140, 70));
					num = (int)(num2 * 173255897) ^ -52454872;
					continue;
				case 98u:
					Form3.smethod_31((Control)(object)textBox2, "textBox2");
					num = ((int)num2 * -810260386) ^ -1505263183;
					continue;
				case 97u:
					num = (int)(num2 * 1609252661) ^ -904067188;
					continue;
				case 96u:
					num = (int)(num2 * 1574367018) ^ -406298393;
					continue;
				case 95u:
					Form3.smethod_38((Control)(object)button5, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 1974187745) ^ 0x7567F4D6);
					continue;
				case 94u:
					num = (int)((num2 * 160224117) ^ 0x76A2F28C);
					continue;
				case 93u:
					Form3.smethod_35((Control)(object)button4, "Начало игры");
					num = ((int)num2 * -1509447771) ^ 0x278B6429;
					continue;
				case 92u:
					Form3.smethod_48((Form)(object)this, (FormBorderStyle)0);
					Form3.smethod_49((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1898483624) ^ -471371299;
					continue;
				case 91u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button7);
					num = (int)((num2 * 128329698) ^ 0x59F06503);
					continue;
				case 90u:
					num = (int)((num2 * 142596470) ^ 0x4EE5A8ED);
					continue;
				case 89u:
					Form3.smethod_45((Form)(object)this, new Size(486, 296));
					num = (int)(num2 * 98506876) ^ -523849721;
					continue;
				case 88u:
					Form3.smethod_32((Control)(object)button4, new Size(140, 50));
					num = ((int)num2 * -2143460448) ^ 0x6D455CFD;
					continue;
				case 87u:
					Form3.smethod_32((Control)(object)textBox1, new Size(140, 20));
					num = (int)(num2 * 938115701) ^ -464435246;
					continue;
				case 86u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button5), 0);
					num = (int)((num2 * 369815335) ^ 0x5658C9B7);
					continue;
				case 85u:
					button2 = Form3.smethod_20();
					num = (int)((num2 * 1352555702) ^ 0x4AAB6F32);
					continue;
				case 84u:
					num = (int)((num2 * 1569385381) ^ 0x1633D0CA);
					continue;
				case 83u:
					Form3.smethod_29((ButtonBase)(object)button4, (FlatStyle)0);
					num = (int)((num2 * 1018341779) ^ 0x10B45D7);
					continue;
				case 82u:
					Form3.smethod_54((Form)(object)this, bool_0: true);
					num = ((int)num2 * -1419621996) ^ -2075968465;
					continue;
				case 81u:
					Form3.smethod_39((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = (int)(num2 * 1782576528) ^ -1468245017;
					continue;
				case 79u:
					Form3.smethod_52((Form)(object)this, bool_0: false);
					num = (int)((num2 * 166884048) ^ 0x2B9EC0E8);
					continue;
				case 78u:
					Form3.smethod_26((Control)(object)NullButton, Color.Transparent);
					num = ((int)num2 * -850163224) ^ -605495953;
					continue;
				case 77u:
					num = (int)((num2 * 2058203353) ^ 0x42D2181D);
					continue;
				case 76u:
					Form3.smethod_33((Control)(object)button4, 4);
					num = (int)((num2 * 1698843644) ^ 0xB19ABCA);
					continue;
				case 75u:
					Form3.smethod_34((ButtonBase)(object)button4, bool_0: true);
					num = (int)((num2 * 1162864349) ^ 0x37BDFA5B);
					continue;
				case 74u:
					Form3.smethod_33((Control)(object)textBox2, 8);
					num = ((int)num2 * -1442176965) ^ -1735928579;
					continue;
				case 73u:
					num = (int)((num2 * 1327761967) ^ 0x7C50153A);
					continue;
				case 72u:
					num = ((int)num2 * -528769727) ^ -1746426520;
					continue;
				case 71u:
					Form3.smethod_32((Control)(object)button2, new Size(85, 21));
					num = (int)(num2 * 104426923) ^ -926108463;
					continue;
				case 70u:
					num = ((int)num2 * -189186318) ^ -15672525;
					continue;
				case 69u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)NullButton);
					num = ((int)num2 * -1210079467) ^ 0x7A5269A1;
					continue;
				case 68u:
					Form3.smethod_33((Control)(object)button2, 1);
					num = ((int)num2 * -707471840) ^ 0x7C493524;
					continue;
				case 67u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button5);
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button4);
					num = ((int)num2 * -367462786) ^ -219551370;
					continue;
				case 66u:
					num = (int)((num2 * 10218342) ^ 0x1ADE00D2);
					continue;
				case 65u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox1);
					num = ((int)num2 * -1330939178) ^ -1546655286;
					continue;
				case 64u:
					Form3.smethod_34((ButtonBase)(object)button2, bool_0: true);
					num = (int)(num2 * 1267920738) ^ -499877264;
					continue;
				case 63u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button1);
					num = (int)((num2 * 1186025444) ^ 0x2924AED3);
					continue;
				case 62u:
					Form3.smethod_26((Control)(object)this, Color.White);
					num = (int)((num2 * 1607931930) ^ 0x1DD492C1);
					continue;
				case 61u:
					num = ((int)num2 * -992576209) ^ 0x60B37686;
					continue;
				case 60u:
					Form3.smethod_14((Control)(object)button5, bool_0: false);
					num = (int)(num2 * 249225266) ^ -912944556;
					continue;
				case 59u:
					num = (int)((num2 * 1152690704) ^ 0x75CF8BDA);
					continue;
				case 58u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox2);
					num = ((int)num2 * -878756854) ^ -512316105;
					continue;
				case 57u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button2);
					num = (int)((num2 * 1889613555) ^ 0x328454C6);
					continue;
				case 56u:
					Form3.smethod_32((Control)(object)button5, new Size(140, 50));
					num = ((int)num2 * -1205068950) ^ -46252881;
					continue;
				case 55u:
					num = ((int)num2 * -642736297) ^ -546596767;
					continue;
				case 54u:
					num = (int)(num2 * 3754758) ^ -680096078;
					continue;
				case 53u:
					Form3.smethod_30((Control)(object)textBox2, new Point(174, 26));
					num = ((int)num2 * -2037118276) ^ 0x60490A17;
					continue;
				case 52u:
					Form3.smethod_50((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1242818628) ^ -1780746850;
					continue;
				case 51u:
					Form3.smethod_32((Control)(object)NullButton, new Size(1, 1));
					num = ((int)num2 * -1452694764) ^ 0x54E8DD3B;
					continue;
				case 50u:
					Form3.smethod_34((ButtonBase)(object)button5, bool_0: true);
					Form3.smethod_36((Control)(object)button5, (EventHandler)Button5_Click);
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button7), 0);
					num = (int)((num2 * 1304182117) ^ 0x72013B9D);
					continue;
				case 49u:
					num = (int)(num2 * 1965055451) ^ -682550083;
					continue;
				case 48u:
					Form3.smethod_53((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1983878880) ^ -1724426516;
					continue;
				case 47u:
					num = ((int)num2 * -1966067151) ^ 0x66CB7A48;
					continue;
				case 46u:
					textBox2 = Form3.smethod_21();
					errorProvider1 = Form3.smethod_23(components);
					Form3.smethod_24((ISupportInitialize)errorProvider1);
					num = (int)(num2 * 1559294140) ^ -2022175782;
					continue;
				case 45u:
					Form3.smethod_30((Control)(object)button4, new Point(174, 137));
					num = (int)((num2 * 1602029809) ^ 0x4C18355F);
					continue;
				case 44u:
					num = (int)((num2 * 1101527770) ^ 0x7561D67C);
					continue;
				case 43u:
					Form3.smethod_25((Control)(object)this);
					num = ((int)num2 * -45013411) ^ -1961119607;
					continue;
				case 42u:
					Form3.smethod_43((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)(num2 * 126315907) ^ -719815662;
					continue;
				case 41u:
					num = ((int)num2 * -110353679) ^ -1337856853;
					continue;
				case 40u:
					Form3.smethod_36((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)(num2 * 351445025) ^ -2034892713;
					continue;
				case 39u:
					Form3.smethod_36((Control)(object)button7, (EventHandler)Button7_Click);
					num = ((int)num2 * -602429586) ^ 0x53AA34AB;
					continue;
				case 38u:
					Form3.smethod_32((Control)(object)label1, new Size(207, 76));
					num = ((int)num2 * -139450133) ^ 0x253EB118;
					continue;
				case 37u:
					num = (int)((num2 * 353178738) ^ 0x27292F7F);
					continue;
				case 36u:
					num = (int)(num2 * 1591507044) ^ -2048406031;
					continue;
				case 35u:
					Form3.smethod_29((ButtonBase)(object)NullButton, (FlatStyle)0);
					num = (int)(num2 * 53370801) ^ -1329573785;
					continue;
				case 34u:
					Form3.smethod_30((Control)(object)button2, new Point(174, 49));
					num = ((int)num2 * -809517664) ^ 0x463A35F;
					continue;
				case 33u:
					Form3.smethod_32((Control)(object)button7, new Size(140, 50));
					num = ((int)num2 * -750173880) ^ 0x29F4C6AB;
					continue;
				case 32u:
					Form3.smethod_30((Control)(object)button7, new Point(174, 243));
					num = (int)((num2 * 1132481006) ^ 0x4FA3535A);
					continue;
				case 31u:
					num = (int)((num2 * 1571533532) ^ 0x724CDD7A);
					continue;
				case 30u:
					Form3.smethod_40((Control)(object)label1, bool_0: true);
					Form3.smethod_26((Control)(object)label1, Color.Transparent);
					num = ((int)num2 * -1773533380) ^ 0x46C1E446;
					continue;
				case 29u:
					num = ((int)num2 * -2099150265) ^ -1025783048;
					continue;
				case 28u:
					num = ((int)num2 * -1266275351) ^ 0x7B962499;
					continue;
				case 27u:
					num = (int)(num2 * 1944680963) ^ -237525946;
					continue;
				case 26u:
					num = (int)((num2 * 405491704) ^ 0x5A7E9586);
					continue;
				case 25u:
					num = (int)((num2 * 803656538) ^ 0x1F6D9A2E);
					continue;
				case 24u:
					num = ((int)num2 * -1375701307) ^ -1790999758;
					continue;
				case 23u:
					Form3.smethod_33((Control)(object)button1, 0);
					num = (int)((num2 * 1341152980) ^ 0x3E10BDA8);
					continue;
				case 22u:
					num = (int)((num2 * 1931283466) ^ 0x49239071);
					continue;
				case 20u:
					num = ((int)num2 * -1868322172) ^ 0x47912AC8;
					continue;
				case 19u:
					Form3.smethod_55((ISupportInitialize)errorProvider1);
					num = (int)(num2 * 2128439812) ^ -1661444197;
					continue;
				case 18u:
					Form3.smethod_31((Control)(object)textBox1, "textBox1");
					num = (int)((num2 * 1720095379) ^ 0x316A8F93);
					continue;
				case 17u:
					Form3.smethod_36((Control)(object)button4, (EventHandler)Button4_Click);
					num = (int)(num2 * 1577932406) ^ -425667256;
					continue;
				case 16u:
					Form3.smethod_34((ButtonBase)(object)NullButton, bool_0: false);
					num = (int)(num2 * 790458774) ^ -1770001708;
					continue;
				case 15u:
					Form3.smethod_33((Control)(object)button5, 5);
					num = ((int)num2 * -896720207) ^ 0x1615AF07;
					continue;
				case 14u:
					Form3.smethod_38((Control)(object)label1, Form3.smethod_37("Mistral", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 1282728901) ^ 0x3728AB8D);
					continue;
				case 13u:
					button4 = Form3.smethod_20();
					num = (int)((num2 * 1587325332) ^ 0x5FC8A414);
					continue;
				case 12u:
					num = ((int)num2 * -1681405590) ^ -1658454549;
					continue;
				case 11u:
					button7 = Form3.smethod_20();
					textBox1 = Form3.smethod_21();
					label1 = Form3.smethod_22();
					num = (int)((num2 * 61186357) ^ 0x415AFB34);
					continue;
				case 10u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)label1);
					num = (int)(num2 * 385035968) ^ -484550672;
					continue;
				case 9u:
					Form3.smethod_30((Control)(object)textBox1, new Point(174, 2));
					num = (int)(num2 * 1670196390) ^ -876194451;
					continue;
				case 8u:
					Form3.smethod_33((Control)(object)textBox1, 7);
					Form3.smethod_39((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = (int)(num2 * 1499899257) ^ -944154848;
					continue;
				case 7u:
					num = (int)((num2 * 1229251057) ^ 0x119ECB8);
					continue;
				case 6u:
					num = (int)(num2 * 1115353514) ^ -2101977371;
					continue;
				case 5u:
					num = (int)(num2 * 1433660529) ^ -221576435;
					continue;
				case 4u:
					Form3.smethod_30((Control)(object)button1, new Point(265, 49));
					Form3.smethod_31((Control)(object)button1, "button1");
					Form3.smethod_32((Control)(object)button1, new Size(49, 21));
					num = (int)(num2 * 1834650521) ^ -188314873;
					continue;
				case 3u:
					Form3.smethod_31((Control)(object)button2, "button2");
					num = ((int)num2 * -1690183841) ^ 0x33DC0F87;
					continue;
				case 2u:
					Form3.smethod_44((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 2053679371) ^ -891410472;
					continue;
				case 1u:
					num = (int)((num2 * 543556460) ^ 0x2AB13A82);
					continue;
				case 0u:
					Form3.smethod_38((Control)(object)button4, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -116726887) ^ -424137379;
					continue;
				default:
					return;
				case 80u:
					break;
				case 21u:
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
