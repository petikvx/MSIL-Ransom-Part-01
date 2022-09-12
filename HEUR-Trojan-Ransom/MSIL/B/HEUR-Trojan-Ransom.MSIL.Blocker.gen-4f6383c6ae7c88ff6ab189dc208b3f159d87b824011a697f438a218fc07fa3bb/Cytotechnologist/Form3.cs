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
			int num = -1767866680;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF75CBF44u) % 9u)
				{
				case 8u:
					num = ((int)num2 * -985620743) ^ 0x340DE700;
					continue;
				case 6u:
					Form3.smethod_1(errorProvider1);
					num = (int)(num2 * 529956593) ^ -398499161;
					continue;
				case 5u:
				{
					Form4 form = new Form4();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					num = (int)(num2 * 1167261058) ^ -468618383;
					continue;
				}
				case 4u:
					Form3.smethod_4((Control)(object)val);
					num = (int)(num2 * 984618714) ^ -1098446489;
					continue;
				case 3u:
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = ((int)num2 * -279509974) ^ -1404117210;
					continue;
				case 1u:
					Form3.smethod_0((Control)(object)NullButton);
					num = (int)(num2 * 872910076) ^ -2143690409;
					continue;
				case 0u:
					Form3.smethod_10(val, new Point(Form3.smethod_5((Form)(object)this).X + (Form3.smethod_6((Control)(object)this) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_5((Form)(object)this).Y + (Form3.smethod_8((Control)(object)this) - Form3.smethod_9((Control)(object)val)) / 2 + 70));
					num = (int)((num2 * 234511329) ^ 0x6860AA95);
					continue;
				default:
					return;
				case 7u:
					break;
				case 2u:
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
			int num = -1231223950;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8FD2E7CCu) % 7u)
				{
				case 6u:
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = ((int)num2 * -973109903) ^ -1062285406;
					continue;
				case 4u:
					Form3.smethod_4((Control)(object)val);
					num = (int)(num2 * 2130356296) ^ -940160391;
					continue;
				case 3u:
				{
					Form2 form = new Form2();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					num = ((int)num2 * -313351429) ^ -99495747;
					continue;
				}
				case 1u:
					Form3.smethod_0((Control)(object)NullButton);
					num = ((int)num2 * -1736055042) ^ -1337019783;
					continue;
				case 0u:
					Form3.smethod_10(val, new Point(Form3.smethod_13(Form3.smethod_12((Form)(object)this)).X + (Form3.smethod_7((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_13(Form3.smethod_12((Form)(object)this)).Y + (Form3.smethod_9((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_9((Control)(object)val)) / 2));
					num = (int)(num2 * 24878123) ^ -93478796;
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

	public void Button_Continue()
	{
		Form3.smethod_14((Control)(object)button5, bool_0: true);
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		int num3 = default(int);
		while (true)
		{
			int num = -33801810;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE966C7A7u) % 10u)
				{
				case 9u:
					num3 = Form3.smethod_8((Control)(object)this) - 1;
					num = -466709739;
					continue;
				case 7u:
					num = ((int)num2 * -797244092) ^ 0x1733B95E;
					continue;
				case 6u:
					num = ((int)num2 * -460559282) ^ -77885934;
					continue;
				case 5u:
					Form3.smethod_17((Form3.smethod_12((Form)(object)this) as Form1).timer1);
					num = ((int)num2 * -1427537743) ^ -704629609;
					continue;
				case 4u:
					Form3.smethod_16(Form3.smethod_12((Form)(object)this));
					num = ((int)num2 * -1555114056) ^ -1499513897;
					continue;
				case 2u:
					Form3.smethod_15((Control)(object)this, num3);
					num = (int)(num2 * 1232039435) ^ -1266450503;
					continue;
				case 1u:
					num = -918086086;
					continue;
				case 0u:
				{
					int num4;
					int num5;
					if (num3 > 1)
					{
						num4 = -1919142822;
						num5 = -1919142822;
					}
					else
					{
						num4 = -521247309;
						num5 = -521247309;
					}
					num = num4 ^ ((int)num2 * -1851762397);
					continue;
				}
				default:
					return;
				case 8u:
					break;
				case 3u:
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
			int num = 684745441;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x20F0E834u) % 3u)
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
				num = ((int)num2 * -784814989) ^ -1695096880;
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
			int num = -1662438486;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFA08E063u) % 4u)
				{
				case 1u:
					Form3.smethod_0((Control)(object)NullButton);
					num = ((int)num2 * -1083984308) ^ 0x3C303C5F;
					continue;
				case 0u:
					Form3.smethod_14((Control)(object)button7, bool_0: false);
					num = ((int)num2 * -1687725603) ^ -1000388232;
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
		if (!disposing)
		{
			goto IL_0009;
		}
		goto IL_005d;
		IL_005d:
		int num = 26629519;
		goto IL_0062;
		IL_0062:
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x30BD3F19u) % 7u)
			{
			case 6u:
				num = (int)((num2 * 399442169) ^ 0x3E511E0F);
				continue;
			case 5u:
				num = (int)((num2 * 579091904) ^ 0x475E8784);
				continue;
			case 4u:
				Form3.smethod_18((IDisposable)components);
				num = ((int)num2 * -1532898104) ^ -1916870335;
				continue;
			case 3u:
				num = (int)(num2 * 1068036830) ^ -412299777;
				continue;
			case 0u:
				break;
			case 2u:
				goto IL_008f;
			default:
				((Form)this).Dispose(disposing);
				return;
			}
			break;
			IL_008f:
			if (components != null)
			{
				num = 1012899783;
				num3 = 1012899783;
				continue;
			}
			goto IL_0009;
		}
		goto IL_005d;
		IL_0009:
		num = 1245600516;
		num3 = 1245600516;
		goto IL_0062;
	}

	private void InitializeComponent()
	{
		components = Form3.smethod_19();
		while (true)
		{
			int num = 12222798;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3E50F9E2u) % 135u)
				{
				case 134u:
					Form3.smethod_31((Control)(object)button4, "button4");
					num = (int)((num2 * 720401451) ^ 0x6CDA004D);
					continue;
				case 133u:
					Form3.smethod_29((ButtonBase)(object)button7, (FlatStyle)0);
					Form3.smethod_38((Control)(object)button7, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form3.smethod_30((Control)(object)button7, new Point(174, 243));
					num = (int)(num2 * 1883167733) ^ -317691841;
					continue;
				case 132u:
					Form3.smethod_32((Control)(object)label1, new Size(207, 76));
					num = ((int)num2 * -1369124852) ^ 0x73EE5B0;
					continue;
				case 131u:
					num = (int)((num2 * 1631807080) ^ 0x3B146556);
					continue;
				case 130u:
					Form3.smethod_33((Control)(object)NullButton, 3);
					num = (int)(num2 * 1555608457) ^ -1822875392;
					continue;
				case 129u:
					num = ((int)num2 * -1966920101) ^ 0x630A3E3F;
					continue;
				case 128u:
					Form3.smethod_26((Control)(object)this, Color.White);
					num = ((int)num2 * -1443602751) ^ 0x5EAB887B;
					continue;
				case 127u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button4);
					num = ((int)num2 * -362120733) ^ 0x1DAC473D;
					continue;
				case 126u:
					Form3.smethod_26((Control)(object)NullButton, Color.Transparent);
					num = ((int)num2 * -1214014079) ^ -344551258;
					continue;
				case 125u:
					Form3.smethod_33((Control)(object)button1, 0);
					num = ((int)num2 * -642211356) ^ -2126991162;
					continue;
				case 124u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button5);
					num = (int)((num2 * 1075789068) ^ 0x43F09D4E);
					continue;
				case 123u:
					Form3.smethod_30((Control)(object)NullButton, new Point(-1, -1));
					Form3.smethod_31((Control)(object)NullButton, "NullButton");
					num = ((int)num2 * -530423681) ^ 0x5C0D152D;
					continue;
				case 122u:
					Form3.smethod_31((Control)(object)button1, "button1");
					Form3.smethod_32((Control)(object)button1, new Size(49, 21));
					num = (int)((num2 * 246101093) ^ 0x279EA5A4);
					continue;
				case 121u:
					num = (int)(num2 * 1834115380) ^ -1776258446;
					continue;
				case 120u:
					Form3.smethod_38((Control)(object)label1, Form3.smethod_37("Mistral", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 1458134709) ^ 0x635D60F1);
					continue;
				case 119u:
					num = ((int)num2 * -1482750123) ^ -1413534510;
					continue;
				case 118u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button1);
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)label1);
					num = (int)((num2 * 348652196) ^ 0x17AE7DE6);
					continue;
				case 117u:
					num = (int)((num2 * 1963868075) ^ 0xCDC63C);
					continue;
				case 116u:
					Form3.smethod_14((Control)(object)button5, bool_0: false);
					num = (int)(num2 * 293989259) ^ -557864324;
					continue;
				case 115u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox1);
					num = (int)(num2 * 506719381) ^ -1453892892;
					continue;
				case 114u:
					num = (int)((num2 * 628312552) ^ 0x254642F9);
					continue;
				case 113u:
					Form3.smethod_30((Control)(object)label1, new Point(140, 70));
					num = ((int)num2 * -81404127) ^ 0x572E97C0;
					continue;
				case 112u:
					Form3.smethod_30((Control)(object)button1, new Point(265, 49));
					num = (int)((num2 * 281868241) ^ 0x48B667BC);
					continue;
				case 111u:
					num = ((int)num2 * -1753899784) ^ 0x7B9EB319;
					continue;
				case 109u:
					num = ((int)num2 * -1558889445) ^ -1018146401;
					continue;
				case 108u:
					num = (int)((num2 * 628124411) ^ 0x789E95A7);
					continue;
				case 107u:
					num = ((int)num2 * -752500659) ^ 0x7155BF17;
					continue;
				case 106u:
					Form3.smethod_32((Control)(object)textBox1, new Size(140, 20));
					num = ((int)num2 * -1095890581) ^ 0x721E6C54;
					continue;
				case 105u:
					Form3.smethod_29((ButtonBase)(object)NullButton, (FlatStyle)0);
					num = (int)((num2 * 1301725413) ^ 0x3AE470B5);
					continue;
				case 104u:
					num = (int)((num2 * 2058966059) ^ 0x4F53D89D);
					continue;
				case 103u:
					Form3.smethod_35((Control)(object)button7, "Достижения");
					num = ((int)num2 * -1844219348) ^ -1165776903;
					continue;
				case 102u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button7);
					num = (int)((num2 * 440618847) ^ 0x764A6651);
					continue;
				case 101u:
					Form3.smethod_36((Control)(object)button4, (EventHandler)Button4_Click);
					num = ((int)num2 * -1679453421) ^ 0x1502D915;
					continue;
				case 100u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button4), 0);
					Form3.smethod_29((ButtonBase)(object)button4, (FlatStyle)0);
					num = (int)(num2 * 1882610871) ^ -2141256866;
					continue;
				case 99u:
					Form3.smethod_30((Control)(object)textBox2, new Point(174, 26));
					Form3.smethod_31((Control)(object)textBox2, "textBox2");
					num = ((int)num2 * -1577524771) ^ 0x65407951;
					continue;
				case 98u:
					num = ((int)num2 * -690601440) ^ 0x49C9A282;
					continue;
				case 97u:
					num = ((int)num2 * -1394828832) ^ -279793634;
					continue;
				case 96u:
					Form3.smethod_36((Control)(object)button5, (EventHandler)Button5_Click);
					num = (int)((num2 * 2145643029) ^ 0x44247CD5);
					continue;
				case 95u:
					num = ((int)num2 * -553087991) ^ -1604223294;
					continue;
				case 94u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button2);
					num = (int)((num2 * 627946549) ^ 0x13B0959B);
					continue;
				case 93u:
					num = (int)((num2 * 1831744876) ^ 0x4339849C);
					continue;
				case 92u:
					Form3.smethod_53((Form)(object)this, bool_0: false);
					num = (int)(num2 * 369843701) ^ -1047857996;
					continue;
				case 91u:
					Form3.smethod_33((Control)(object)textBox1, 7);
					num = (int)(num2 * 660078661) ^ -797655483;
					continue;
				case 90u:
					num = (int)(num2 * 1039405022) ^ -1547854609;
					continue;
				case 89u:
					Form3.smethod_33((Control)(object)button7, 6);
					num = (int)((num2 * 1006846465) ^ 0x6F359B43);
					continue;
				case 88u:
					Form3.smethod_36((Control)(object)button7, (EventHandler)Button7_Click);
					num = (int)(num2 * 1790164929) ^ -67247087;
					continue;
				case 87u:
					num = ((int)num2 * -1547384471) ^ 0x66D65A7A;
					continue;
				case 86u:
					label1 = Form3.smethod_22();
					textBox2 = Form3.smethod_21();
					errorProvider1 = Form3.smethod_23(components);
					num = (int)(num2 * 386412716) ^ -836323144;
					continue;
				case 85u:
					Form3.smethod_30((Control)(object)button5, new Point(174, 190));
					num = (int)(num2 * 348786933) ^ -1268414366;
					continue;
				case 84u:
					Form3.smethod_35((Control)(object)button1, "Вход");
					num = (int)(num2 * 526982232) ^ -1408350289;
					continue;
				case 83u:
					Form3.smethod_25((Control)(object)this);
					num = ((int)num2 * -912197359) ^ -1973482276;
					continue;
				case 82u:
					Form3.smethod_31((Control)(object)textBox1, "textBox1");
					num = (int)(num2 * 141369577) ^ -1758079898;
					continue;
				case 81u:
					Form3.smethod_50((Form)(object)this, bool_0: false);
					num = ((int)num2 * -266256310) ^ -1550039124;
					continue;
				case 80u:
					num = (int)((num2 * 865802666) ^ 0x4FF2A993);
					continue;
				case 79u:
					Form3.smethod_32((Control)(object)button7, new Size(140, 50));
					num = ((int)num2 * -287756986) ^ 0x319E417D;
					continue;
				case 78u:
					Form3.smethod_33((Control)(object)label1, 7);
					num = (int)(num2 * 1382013443) ^ -1029006499;
					continue;
				case 77u:
					Form3.smethod_33((Control)(object)textBox2, 8);
					num = ((int)num2 * -764660460) ^ -1901399695;
					continue;
				case 76u:
					num = (int)(num2 * 1244320113) ^ -507425533;
					continue;
				case 75u:
					num = ((int)num2 * -850225009) ^ -1951842487;
					continue;
				case 74u:
					Form3.smethod_32((Control)(object)button2, new Size(85, 21));
					num = (int)((num2 * 995475259) ^ 0x5363FBF4);
					continue;
				case 73u:
					num = (int)((num2 * 1884240813) ^ 0xD12B7F);
					continue;
				case 72u:
					num = (int)((num2 * 1192037091) ^ 0x427E8569);
					continue;
				case 70u:
					num = (int)(num2 * 1575277636) ^ -1377605097;
					continue;
				case 69u:
					num = ((int)num2 * -1375610976) ^ -1115790389;
					continue;
				case 68u:
					num = ((int)num2 * -72303631) ^ -1010398502;
					continue;
				case 67u:
					Form3.smethod_34((ButtonBase)(object)button4, bool_0: true);
					num = (int)(num2 * 461248920) ^ -1591797578;
					continue;
				case 66u:
					Form3.smethod_38((Control)(object)button4, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form3.smethod_30((Control)(object)button4, new Point(174, 137));
					num = ((int)num2 * -121881819) ^ -668111779;
					continue;
				case 65u:
					Form3.smethod_32((Control)(object)textBox2, new Size(140, 20));
					num = ((int)num2 * -60646125) ^ 0x6005D75C;
					continue;
				case 64u:
					Form3.smethod_31((Control)(object)button2, "button2");
					num = ((int)num2 * -1366797886) ^ 0x16A77EB;
					continue;
				case 63u:
					num = (int)(num2 * 1728034222) ^ -179301634;
					continue;
				case 62u:
					num = ((int)num2 * -1340923831) ^ 0xDA5B15E;
					continue;
				case 61u:
					num = ((int)num2 * -694264372) ^ 0x7F21F613;
					continue;
				case 60u:
					Form3.smethod_32((Control)(object)NullButton, new Size(1, 1));
					num = (int)(num2 * 199963344) ^ -879072195;
					continue;
				case 59u:
					Form3.smethod_57((Control)(object)this);
					num = ((int)num2 * -2012455353) ^ -1904743974;
					continue;
				case 58u:
					Form3.smethod_49((Form)(object)this, bool_0: false);
					num = (int)((num2 * 108545625) ^ 0x1895777E);
					continue;
				case 57u:
					Form3.smethod_55((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -657157104) ^ 0x5920AE2A;
					continue;
				case 56u:
					Form3.smethod_39((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -574617022) ^ -835627221;
					continue;
				case 55u:
					button4 = Form3.smethod_20();
					num = (int)((num2 * 1825928878) ^ 0x6670AC09);
					continue;
				case 54u:
					Form3.smethod_35((Control)(object)button5, "Продолжить");
					num = (int)(num2 * 1298023571) ^ -1743390942;
					continue;
				case 53u:
					Form3.smethod_56((Control)(object)this, bool_0: false);
					num = (int)(num2 * 1308343855) ^ -320119258;
					continue;
				case 52u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)NullButton), 0);
					num = ((int)num2 * -61110281) ^ -1736275658;
					continue;
				case 51u:
					Form3.smethod_39((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -1029870133) ^ 0x58DC9DCA;
					continue;
				case 50u:
					num = (int)((num2 * 1492750617) ^ 0x61F91EF0);
					continue;
				case 49u:
					textBox1 = Form3.smethod_21();
					num = ((int)num2 * -1429364110) ^ 0x778CD2D9;
					continue;
				case 48u:
					NullButton = Form3.smethod_20();
					button1 = Form3.smethod_20();
					num = (int)((num2 * 1609720750) ^ 0x1F5A5694);
					continue;
				case 47u:
					Form3.smethod_32((Control)(object)button4, new Size(140, 50));
					Form3.smethod_33((Control)(object)button4, 4);
					num = (int)(num2 * 189148705) ^ -1544769044;
					continue;
				case 46u:
					Form3.smethod_45((Form)(object)this, new Size(486, 296));
					num = ((int)num2 * -1148521213) ^ -347878125;
					continue;
				case 45u:
					num = ((int)num2 * -871819069) ^ 0x1BDB4E02;
					continue;
				case 44u:
					num = ((int)num2 * -1155285) ^ 0x11CD6058;
					continue;
				case 43u:
					num = (int)((num2 * 1903305297) ^ 0xB434A1F);
					continue;
				case 42u:
					Form3.smethod_33((Control)(object)button2, 1);
					num = ((int)num2 * -2103132149) ^ 0x187F0CBF;
					continue;
				case 41u:
					Form3.smethod_35((Control)(object)button2, "Регистрация");
					num = ((int)num2 * -1469531742) ^ 0x75A2A59D;
					continue;
				case 40u:
					Form3.smethod_40((Control)(object)label1, bool_0: true);
					num = (int)((num2 * 1057875881) ^ 0x377ADFCB);
					continue;
				case 39u:
					Form3.smethod_52((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1913540296) ^ 0x1D2A59C8;
					continue;
				case 38u:
					num = (int)((num2 * 2142831875) ^ 0x53222245);
					continue;
				case 37u:
					Form3.smethod_41(textBox2, bool_0: true);
					num = ((int)num2 * -18230567) ^ -12777914;
					continue;
				case 36u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button7), 0);
					num = ((int)num2 * -1353213622) ^ -674841249;
					continue;
				case 35u:
					Form3.smethod_54((Form)(object)this, bool_0: true);
					num = (int)((num2 * 328417361) ^ 0xA55D709);
					continue;
				case 34u:
					Form3.smethod_34((ButtonBase)(object)NullButton, bool_0: false);
					num = ((int)num2 * -2004241560) ^ 0x1A3C999E;
					continue;
				case 33u:
					button7 = Form3.smethod_20();
					num = (int)(num2 * 1823635863) ^ -901595065;
					continue;
				case 32u:
					num = ((int)num2 * -1811144297) ^ -1299366853;
					continue;
				case 31u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox2);
					num = ((int)num2 * -323512979) ^ 0x701146B9;
					continue;
				case 30u:
					num = ((int)num2 * -1349073963) ^ -1778613089;
					continue;
				case 29u:
					button5 = Form3.smethod_20();
					num = ((int)num2 * -492626555) ^ 0x10B30F4;
					continue;
				case 28u:
					Form3.smethod_30((Control)(object)textBox1, new Point(174, 2));
					num = (int)(num2 * 399411302) ^ -1434726349;
					continue;
				case 27u:
					Form3.smethod_43((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)((num2 * 1443234676) ^ 0x5BD721E4);
					continue;
				case 26u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)NullButton);
					Form3.smethod_48((Form)(object)this, (FormBorderStyle)0);
					num = (int)(num2 * 2029948531) ^ -452556839;
					continue;
				case 25u:
					Form3.smethod_31((Control)(object)button5, "button5");
					Form3.smethod_32((Control)(object)button5, new Size(140, 50));
					num = (int)((num2 * 1148891389) ^ 0x1936F35C);
					continue;
				case 24u:
					Form3.smethod_38((Control)(object)button5, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1120746667) ^ -1999246619;
					continue;
				case 23u:
					num = ((int)num2 * -1787775603) ^ -554581858;
					continue;
				case 22u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button5), 0);
					Form3.smethod_29((ButtonBase)(object)button5, (FlatStyle)0);
					num = (int)((num2 * 360637406) ^ 0x21C79E9D);
					continue;
				case 21u:
					button2 = Form3.smethod_20();
					num = (int)(num2 * 47733182) ^ -895262484;
					continue;
				case 20u:
					Form3.smethod_34((ButtonBase)(object)button2, bool_0: true);
					num = (int)((num2 * 1456784532) ^ 0x3D1F4106);
					continue;
				case 19u:
					Form3.smethod_51((Control)(object)this, "Form3");
					num = ((int)num2 * -1446044353) ^ 0x686D8107;
					continue;
				case 18u:
					num = ((int)num2 * -2002793451) ^ -1302022837;
					continue;
				case 17u:
					Form3.smethod_44((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -1382174648) ^ 0x67988CE2;
					continue;
				case 16u:
					Form3.smethod_36((Control)(object)button2, (EventHandler)Button2_Click);
					num = ((int)num2 * -1548966764) ^ -1841912277;
					continue;
				case 15u:
					Form3.smethod_31((Control)(object)button7, "button7");
					num = ((int)num2 * -633453079) ^ -844933624;
					continue;
				case 14u:
					Form3.smethod_35((Control)(object)button4, "Начало игры");
					num = (int)(num2 * 2137854062) ^ -971945217;
					continue;
				case 13u:
					Form3.smethod_36((Control)(object)button1, (EventHandler)Button1_Click);
					Form3.smethod_30((Control)(object)button2, new Point(174, 49));
					num = ((int)num2 * -1663622969) ^ -49803494;
					continue;
				case 12u:
					num = (int)((num2 * 831417004) ^ 0x441C4D0C);
					continue;
				case 11u:
					Form3.smethod_33((Control)(object)button5, 5);
					num = (int)((num2 * 104334181) ^ 0x6F78133);
					continue;
				case 10u:
					Form3.smethod_34((ButtonBase)(object)button7, bool_0: true);
					num = ((int)num2 * -2053039093) ^ -1145929990;
					continue;
				case 9u:
					Form3.smethod_34((ButtonBase)(object)button5, bool_0: true);
					num = ((int)num2 * -1090570884) ^ 0x42D4B034;
					continue;
				case 8u:
					Form3.smethod_31((Control)(object)label1, "label1");
					num = ((int)num2 * -588371628) ^ -151301842;
					continue;
				case 7u:
					Form3.smethod_34((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -1004213511) ^ -301892893;
					continue;
				case 6u:
					Form3.smethod_26((Control)(object)label1, Color.Transparent);
					num = ((int)num2 * -570359242) ^ 0x5F6B617F;
					continue;
				case 5u:
					num = (int)((num2 * 1636826083) ^ 0x9D596D7);
					continue;
				case 4u:
					Form3.smethod_42(errorProvider1, (ContainerControl)(object)this);
					num = ((int)num2 * -1384455287) ^ 0x6777A238;
					continue;
				case 3u:
					Form3.smethod_14((Control)(object)button4, bool_0: false);
					num = ((int)num2 * -632018686) ^ 0x3D30DFF;
					continue;
				case 2u:
					Form3.smethod_35((Control)(object)label1, "QUARTO");
					num = ((int)num2 * -609106100) ^ 0x4A7715C5;
					continue;
				case 1u:
					num = (int)(num2 * 209062120) ^ -980102609;
					continue;
				case 0u:
					Form3.smethod_24((ISupportInitialize)errorProvider1);
					num = (int)(num2 * 20170929) ^ -275420989;
					continue;
				default:
					return;
				case 71u:
					break;
				case 110u:
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
