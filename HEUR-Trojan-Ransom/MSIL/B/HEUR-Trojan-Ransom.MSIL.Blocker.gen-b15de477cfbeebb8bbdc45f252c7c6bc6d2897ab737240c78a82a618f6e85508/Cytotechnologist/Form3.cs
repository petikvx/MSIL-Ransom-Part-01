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
			int num = 1311422709;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB52DAC9u) % 10u)
				{
				case 9u:
					num = (int)((num2 * 1750492781) ^ 0x50952A31);
					continue;
				case 8u:
					Form3.smethod_1(errorProvider1);
					num = ((int)num2 * -998627243) ^ 0x25490DB6;
					continue;
				case 6u:
					Form3.smethod_4((Control)(object)val);
					num = (int)((num2 * 1432255719) ^ 0x25E4231C);
					continue;
				case 5u:
					num = ((int)num2 * -271152326) ^ 0x23DC9983;
					continue;
				case 4u:
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = (int)(num2 * 286895115) ^ -1586831414;
					continue;
				case 3u:
					Form3.smethod_10(val, new Point(Form3.smethod_5((Form)(object)this).X + (Form3.smethod_6((Control)(object)this) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_5((Form)(object)this).Y + (Form3.smethod_8((Control)(object)this) - Form3.smethod_9((Control)(object)val)) / 2 + 70));
					num = ((int)num2 * -2102750429) ^ 0x653F71D1;
					continue;
				case 2u:
					Form3.smethod_0((Control)(object)NullButton);
					num = (int)((num2 * 547497519) ^ 0x1188E0EB);
					continue;
				case 1u:
				{
					Form4 form = new Form4();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					num = (int)(num2 * 1959990028) ^ -2024354091;
					continue;
				}
				default:
					return;
				case 0u:
					break;
				case 7u:
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
			int num = 569112005;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4E0F512Au) % 7u)
				{
				case 6u:
					Form3.smethod_4((Control)(object)val);
					num = ((int)num2 * -1060874904) ^ -1712549540;
					continue;
				case 5u:
					Form3.smethod_10(val, new Point(Form3.smethod_13(Form3.smethod_12((Form)(object)this)).X + (Form3.smethod_7((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_13(Form3.smethod_12((Form)(object)this)).Y + (Form3.smethod_9((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_9((Control)(object)val)) / 2));
					num = ((int)num2 * -112459968) ^ -1103818844;
					continue;
				case 3u:
					num = ((int)num2 * -1793942614) ^ 0x1BDE6C5F;
					continue;
				case 2u:
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = ((int)num2 * -966607151) ^ 0x6508A6AE;
					continue;
				case 0u:
					num = ((int)num2 * -572599257) ^ 0x10199714;
					continue;
				default:
					return;
				case 4u:
					break;
				case 1u:
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
		int num3 = default(int);
		while (true)
		{
			int num = -1981509810;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF3272395u) % 8u)
				{
				case 7u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -237815491;
						num5 = -237815491;
					}
					else
					{
						num4 = -598010348;
						num5 = -598010348;
					}
					num = num4 ^ (int)(num2 * 1599583603);
					continue;
				}
				case 6u:
					num3 = Form3.smethod_8((Control)(object)this) - 1;
					Form3.smethod_15((Control)(object)this, num3);
					num = -1166024260;
					continue;
				case 5u:
					num = -940882933;
					continue;
				case 4u:
					Form3.smethod_16(Form3.smethod_12((Form)(object)this));
					num = (int)(num2 * 56556633) ^ -9308885;
					continue;
				case 3u:
					num = (int)((num2 * 451840909) ^ 0x9D05994);
					continue;
				case 1u:
					flag = num3 > 1;
					num = ((int)num2 * -380915165) ^ 0xAEF87F9;
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
		while (true)
		{
			int num = 1850386552;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF276457u) % 3u)
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
				num = (int)(num2 * 133128737) ^ -1946172355;
			}
		}
	}

	public void ContinueLock()
	{
		Form3.smethod_14((Control)(object)button5, bool_0: false);
		while (true)
		{
			int num = -399492607;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBB9D1B47u) % 3u)
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
				num = ((int)num2 * -1556045213) ^ 0x3622270D;
			}
		}
	}

	public void AchivUnlock()
	{
		Form3.smethod_14((Control)(object)button7, bool_0: true);
		while (true)
		{
			int num = 1102651224;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4F0B8D90u) % 3u)
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
				num = (int)(num2 * 52226891) ^ -546433412;
			}
		}
	}

	private void Button7_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -1208843339;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC7924E2Cu) % 5u)
				{
				case 2u:
					num = ((int)num2 * -215578699) ^ 0x68B0421A;
					continue;
				case 1u:
					Form3.smethod_0((Control)(object)NullButton);
					num = ((int)num2 * -414317072) ^ 0x1DCC6AAF;
					continue;
				case 0u:
					Form3.smethod_14((Control)(object)button7, bool_0: false);
					num = (int)(num2 * 801186) ^ -1578150511;
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

	protected override void Dispose(bool disposing)
	{
		while (true)
		{
			int num = -1378198375;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xC6108538u) % 8u)
				{
				case 7u:
					Form3.smethod_18((IDisposable)components);
					num = ((int)num2 * -1257134561) ^ 0x635D3A93;
					continue;
				case 6u:
					if (components != null)
					{
						num = -1648046713;
						num3 = -1648046713;
						continue;
					}
					goto IL_002b;
				case 5u:
					num = (int)((num2 * 1167486367) ^ 0x3AA55787);
					continue;
				case 3u:
					((Form)this).Dispose(disposing);
					num = -1572429075;
					continue;
				case 2u:
					num = (int)(num2 * 1789086074) ^ -102557985;
					continue;
				case 1u:
					if (disposing)
					{
						num = ((int)num2 * -318900785) ^ 0x747F5F79;
						continue;
					}
					goto IL_002b;
				default:
					return;
				case 0u:
					break;
				case 4u:
					return;
					IL_002b:
					num = -886505189;
					num3 = -886505189;
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
			int num = -1505119983;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDC814651u) % 116u)
				{
				case 115u:
					Form3.smethod_31((Control)(object)label1, "label1");
					num = ((int)num2 * -1770726062) ^ -1411376999;
					continue;
				case 114u:
					Form3.smethod_39((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = (int)(num2 * 1121174609) ^ -1228442587;
					continue;
				case 113u:
					num = ((int)num2 * -1282448061) ^ 0x5C2178C9;
					continue;
				case 112u:
					num = ((int)num2 * -1481499340) ^ 0x68BBD094;
					continue;
				case 111u:
					Form3.smethod_34((ButtonBase)(object)button7, bool_0: true);
					Form3.smethod_36((Control)(object)button7, (EventHandler)Button7_Click);
					num = ((int)num2 * -1006978622) ^ -445926924;
					continue;
				case 110u:
					num = (int)((num2 * 1522536979) ^ 0xC44A67E);
					continue;
				case 109u:
					num = (int)(num2 * 810666069) ^ -1048379586;
					continue;
				case 108u:
					Form3.smethod_32((Control)(object)button2, new Size(85, 21));
					num = ((int)num2 * -1687208447) ^ 0x3AC78168;
					continue;
				case 107u:
					num = ((int)num2 * -713563178) ^ -1441837931;
					continue;
				case 106u:
					num = (int)(num2 * 892217506) ^ -2014776527;
					continue;
				case 105u:
					num = (int)(num2 * 1717005946) ^ -375867527;
					continue;
				case 104u:
					Form3.smethod_33((Control)(object)NullButton, 3);
					num = ((int)num2 * -1133062177) ^ -1891940216;
					continue;
				case 103u:
					Form3.smethod_34((ButtonBase)(object)button5, bool_0: true);
					Form3.smethod_36((Control)(object)button5, (EventHandler)Button5_Click);
					num = ((int)num2 * -64001801) ^ 0x6F9DE2CB;
					continue;
				case 102u:
					Form3.smethod_32((Control)(object)NullButton, new Size(1, 1));
					num = ((int)num2 * -21818120) ^ 0x4259C5D5;
					continue;
				case 101u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)NullButton), 0);
					Form3.smethod_29((ButtonBase)(object)NullButton, (FlatStyle)0);
					num = (int)(num2 * 1766417987) ^ -2140320815;
					continue;
				case 100u:
					num = (int)(num2 * 2145518033) ^ -1220251069;
					continue;
				case 99u:
					num = (int)(num2 * 395420806) ^ -1838402808;
					continue;
				case 98u:
					num = (int)((num2 * 523198190) ^ 0xA919819);
					continue;
				case 97u:
					num = ((int)num2 * -325706101) ^ -788908412;
					continue;
				case 96u:
					Form3.smethod_53((Form)(object)this, bool_0: false);
					num = (int)(num2 * 871816798) ^ -344522840;
					continue;
				case 95u:
					Form3.smethod_29((ButtonBase)(object)button4, (FlatStyle)0);
					num = ((int)num2 * -1193522574) ^ -1848216340;
					continue;
				case 94u:
					Form3.smethod_32((Control)(object)button4, new Size(140, 50));
					num = ((int)num2 * -1678288911) ^ 0x446C4D9C;
					continue;
				case 93u:
					Form3.smethod_25((Control)(object)this);
					num = (int)((num2 * 1333300418) ^ 0x1E83857F);
					continue;
				case 92u:
					components = Form3.smethod_19();
					NullButton = Form3.smethod_20();
					num = (int)((num2 * 1292981373) ^ 0xED6A7BC);
					continue;
				case 91u:
					num = ((int)num2 * -1135581072) ^ 0x1153219A;
					continue;
				case 90u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button4);
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button2);
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button1);
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)label1);
					num = (int)((num2 * 1946709977) ^ 0x4C42F44D);
					continue;
				case 89u:
					Form3.smethod_31((Control)(object)textBox1, "textBox1");
					num = (int)(num2 * 1291053723) ^ -1785384689;
					continue;
				case 88u:
					Form3.smethod_33((Control)(object)label1, 7);
					Form3.smethod_35((Control)(object)label1, "QUARTO");
					Form3.smethod_30((Control)(object)textBox2, new Point(174, 26));
					num = ((int)num2 * -1431334239) ^ 0x16356618;
					continue;
				case 87u:
					Form3.smethod_55((ISupportInitialize)errorProvider1);
					num = (int)(num2 * 1082358460) ^ -673611198;
					continue;
				case 86u:
					Form3.smethod_26((Control)(object)this, Color.White);
					Form3.smethod_45((Form)(object)this, new Size(486, 296));
					num = ((int)num2 * -1354690354) ^ 0x73536FE5;
					continue;
				case 85u:
					Form3.smethod_29((ButtonBase)(object)button7, (FlatStyle)0);
					Form3.smethod_38((Control)(object)button7, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -540341026) ^ -1981083800;
					continue;
				case 84u:
					Form3.smethod_31((Control)(object)NullButton, "NullButton");
					num = ((int)num2 * -1191276323) ^ 0x3B655499;
					continue;
				case 82u:
					num = ((int)num2 * -1014412804) ^ -622324090;
					continue;
				case 81u:
					Form3.smethod_34((ButtonBase)(object)NullButton, bool_0: false);
					num = ((int)num2 * -1813172934) ^ 0x1B98353D;
					continue;
				case 80u:
					num = (int)((num2 * 1146870573) ^ 0x6C697ABC);
					continue;
				case 79u:
					Form3.smethod_36((Control)(object)button4, (EventHandler)Button4_Click);
					num = ((int)num2 * -2095713600) ^ -1844695131;
					continue;
				case 78u:
					Form3.smethod_30((Control)(object)button2, new Point(174, 49));
					Form3.smethod_31((Control)(object)button2, "button2");
					num = ((int)num2 * -1104839195) ^ 0x3F5057F8;
					continue;
				case 77u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button5), 0);
					num = (int)((num2 * 1161644403) ^ 0x4834CC7B);
					continue;
				case 76u:
					Form3.smethod_35((Control)(object)button7, "Достижения");
					num = (int)(num2 * 459449214) ^ -506208016;
					continue;
				case 75u:
					Form3.smethod_49((Form)(object)this, bool_0: false);
					num = (int)(num2 * 767473822) ^ -593823432;
					continue;
				case 74u:
					Form3.smethod_33((Control)(object)button1, 0);
					num = ((int)num2 * -1078338855) ^ -1953275673;
					continue;
				case 73u:
					num = ((int)num2 * -570094029) ^ 0x380516B8;
					continue;
				case 72u:
					Form3.smethod_26((Control)(object)NullButton, Color.Transparent);
					num = (int)((num2 * 1326877116) ^ 0x1606D0E5);
					continue;
				case 71u:
					Form3.smethod_31((Control)(object)button4, "button4");
					num = ((int)num2 * -1297336555) ^ -1425800328;
					continue;
				case 70u:
					textBox1 = Form3.smethod_21();
					num = ((int)num2 * -2057234142) ^ 0x435B6B72;
					continue;
				case 69u:
					num = ((int)num2 * -1037627628) ^ -921087441;
					continue;
				case 68u:
					num = ((int)num2 * -1194048239) ^ -434738751;
					continue;
				case 67u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox1);
					num = ((int)num2 * -1062065627) ^ -1525539822;
					continue;
				case 66u:
					Form3.smethod_33((Control)(object)button5, 5);
					num = (int)((num2 * 1940218204) ^ 0x5BB4A38A);
					continue;
				case 65u:
					Form3.smethod_32((Control)(object)button7, new Size(140, 50));
					Form3.smethod_33((Control)(object)button7, 6);
					num = ((int)num2 * -164004411) ^ -1355759760;
					continue;
				case 64u:
					num = (int)(num2 * 96370683) ^ -1861238264;
					continue;
				case 63u:
					Form3.smethod_40((Control)(object)label1, bool_0: true);
					num = (int)((num2 * 1806999605) ^ 0x32B807B2);
					continue;
				case 62u:
					Form3.smethod_32((Control)(object)label1, new Size(207, 76));
					num = (int)((num2 * 1462814301) ^ 0x54D50D2D);
					continue;
				case 61u:
					Form3.smethod_32((Control)(object)button5, new Size(140, 50));
					num = ((int)num2 * -801132603) ^ 0x2FCCDC4E;
					continue;
				case 60u:
					num = (int)(num2 * 859086526) ^ -277511069;
					continue;
				case 59u:
					Form3.smethod_32((Control)(object)button1, new Size(49, 21));
					num = (int)(num2 * 1660611928) ^ -1342179595;
					continue;
				case 58u:
					Form3.smethod_31((Control)(object)button7, "button7");
					num = ((int)num2 * -1337393448) ^ -2135865736;
					continue;
				case 57u:
					num = (int)((num2 * 670944822) ^ 0x44FC9F31);
					continue;
				case 56u:
					Form3.smethod_52((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1235228675) ^ 0x78F9C153;
					continue;
				case 55u:
					Form3.smethod_35((Control)(object)button5, "Продолжить");
					num = (int)(num2 * 1863697414) ^ -2036720536;
					continue;
				case 54u:
					num = ((int)num2 * -1136215318) ^ 0x4BBE0D32;
					continue;
				case 53u:
					Form3.smethod_31((Control)(object)textBox2, "textBox2");
					num = (int)(num2 * 366681096) ^ -150673595;
					continue;
				case 52u:
					Form3.smethod_31((Control)(object)button5, "button5");
					num = (int)((num2 * 1927626437) ^ 0x107A058C);
					continue;
				case 51u:
					Form3.smethod_30((Control)(object)textBox1, new Point(174, 2));
					num = (int)((num2 * 1469351135) ^ 0xD7A2BBD);
					continue;
				case 50u:
					Form3.smethod_54((Form)(object)this, bool_0: true);
					num = ((int)num2 * -2055331256) ^ -334886758;
					continue;
				case 49u:
					Form3.smethod_32((Control)(object)textBox1, new Size(140, 20));
					num = (int)((num2 * 1012320013) ^ 0x4AEFF118);
					continue;
				case 48u:
					num = (int)((num2 * 937546886) ^ 0x18DB779B);
					continue;
				case 47u:
					num = (int)((num2 * 30734289) ^ 0x7F59D452);
					continue;
				case 46u:
					Form3.smethod_50((Form)(object)this, bool_0: false);
					num = (int)((num2 * 278118873) ^ 0x70D8AA2C);
					continue;
				case 44u:
					Form3.smethod_32((Control)(object)textBox2, new Size(140, 20));
					num = (int)((num2 * 196943325) ^ 0x17927E9);
					continue;
				case 43u:
					Form3.smethod_30((Control)(object)NullButton, new Point(-1, -1));
					num = (int)(num2 * 33354137) ^ -1319487170;
					continue;
				case 42u:
					Form3.smethod_30((Control)(object)button4, new Point(174, 137));
					num = (int)((num2 * 1841918273) ^ 0x4E0CFD58);
					continue;
				case 41u:
					Form3.smethod_43((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -1670263086) ^ 0x1A1F1047;
					continue;
				case 40u:
					Form3.smethod_26((Control)(object)label1, Color.Transparent);
					Form3.smethod_38((Control)(object)label1, Form3.smethod_37("Mistral", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form3.smethod_30((Control)(object)label1, new Point(140, 70));
					num = ((int)num2 * -1878046043) ^ -1201574946;
					continue;
				case 39u:
					Form3.smethod_33((Control)(object)textBox1, 7);
					num = (int)(num2 * 552852216) ^ -1490764169;
					continue;
				case 38u:
					Form3.smethod_35((Control)(object)button1, "Вход");
					num = ((int)num2 * -634333725) ^ -1426184861;
					continue;
				case 37u:
					button1 = Form3.smethod_20();
					button2 = Form3.smethod_20();
					button4 = Form3.smethod_20();
					num = ((int)num2 * -2123991433) ^ 0x407F6AA0;
					continue;
				case 36u:
					Form3.smethod_48((Form)(object)this, (FormBorderStyle)0);
					num = (int)(num2 * 476740993) ^ -1068403990;
					continue;
				case 35u:
					Form3.smethod_56((Control)(object)this, bool_0: false);
					Form3.smethod_57((Control)(object)this);
					num = ((int)num2 * -697808103) ^ -1683781893;
					continue;
				case 34u:
					num = (int)(num2 * 1937455993) ^ -1092392319;
					continue;
				case 33u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button7);
					num = (int)((num2 * 285312775) ^ 0x51CE37D6);
					continue;
				case 32u:
					num = (int)((num2 * 545924783) ^ 0x38417AE9);
					continue;
				case 31u:
					Form3.smethod_31((Control)(object)button1, "button1");
					num = (int)((num2 * 120627222) ^ 0xA6BF1D8);
					continue;
				case 30u:
					Form3.smethod_44((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -622538295) ^ 0x329A9F6;
					continue;
				case 29u:
					num = (int)(num2 * 1714716375) ^ -1627605351;
					continue;
				case 28u:
					Form3.smethod_34((ButtonBase)(object)button1, bool_0: true);
					num = (int)(num2 * 1080692224) ^ -265682376;
					continue;
				case 27u:
					Form3.smethod_30((Control)(object)button7, new Point(174, 243));
					num = (int)((num2 * 1220277781) ^ 0x3B41A728);
					continue;
				case 26u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button4), 0);
					num = (int)((num2 * 1217075016) ^ 0x4C8B832F);
					continue;
				case 25u:
					Form3.smethod_24((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -1520016321) ^ 0x38735A6;
					continue;
				case 24u:
					Form3.smethod_14((Control)(object)button5, bool_0: false);
					num = ((int)num2 * -612668159) ^ -415428280;
					continue;
				case 23u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button7), 0);
					num = (int)(num2 * 1523536030) ^ -939207070;
					continue;
				case 22u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)NullButton);
					num = ((int)num2 * -1765611450) ^ -1184043403;
					continue;
				case 21u:
					num = ((int)num2 * -454675919) ^ 0x679D9C1B;
					continue;
				case 20u:
					Form3.smethod_33((Control)(object)textBox2, 8);
					Form3.smethod_41(textBox2, bool_0: true);
					num = ((int)num2 * -1112456410) ^ -1926072467;
					continue;
				case 19u:
					label1 = Form3.smethod_22();
					textBox2 = Form3.smethod_21();
					errorProvider1 = Form3.smethod_23(components);
					num = (int)((num2 * 61594843) ^ 0x10C551AD);
					continue;
				case 18u:
					Form3.smethod_30((Control)(object)button1, new Point(265, 49));
					num = ((int)num2 * -1167806186) ^ 0x58278202;
					continue;
				case 17u:
					Form3.smethod_36((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -1742045191) ^ 0x30123182;
					continue;
				case 16u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox2);
					num = (int)((num2 * 505554084) ^ 0x7234B1EE);
					continue;
				case 15u:
					Form3.smethod_33((Control)(object)button4, 4);
					num = (int)((num2 * 1273641925) ^ 0xDD6B53);
					continue;
				case 14u:
					Form3.smethod_33((Control)(object)button2, 1);
					num = (int)(num2 * 50158559) ^ -1002044371;
					continue;
				case 13u:
					Form3.smethod_35((Control)(object)button2, "Регистрация");
					Form3.smethod_34((ButtonBase)(object)button2, bool_0: true);
					Form3.smethod_36((Control)(object)button2, (EventHandler)Button2_Click);
					Form3.smethod_14((Control)(object)button4, bool_0: false);
					num = (int)((num2 * 1005747114) ^ 0x39DA783A);
					continue;
				case 12u:
					Form3.smethod_39((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = (int)((num2 * 808556208) ^ 0x2169AC74);
					continue;
				case 11u:
					Form3.smethod_38((Control)(object)button4, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -101698721) ^ 0x5806F529;
					continue;
				case 10u:
					button5 = Form3.smethod_20();
					button7 = Form3.smethod_20();
					num = ((int)num2 * -100415308) ^ 0x7B22C6EF;
					continue;
				case 9u:
					Form3.smethod_29((ButtonBase)(object)button5, (FlatStyle)0);
					num = ((int)num2 * -607509910) ^ -872722906;
					continue;
				case 8u:
					num = ((int)num2 * -501167068) ^ -695749890;
					continue;
				case 7u:
					Form3.smethod_42(errorProvider1, (ContainerControl)(object)this);
					num = ((int)num2 * -1181328820) ^ -2121481228;
					continue;
				case 6u:
					Form3.smethod_51((Control)(object)this, "Form3");
					num = (int)((num2 * 330192244) ^ 0x26345AF9);
					continue;
				case 5u:
					num = ((int)num2 * -1532458774) ^ -543886943;
					continue;
				case 4u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button5);
					num = (int)(num2 * 1074782470) ^ -285072;
					continue;
				case 3u:
					num = (int)(num2 * 383188260) ^ -181944249;
					continue;
				case 2u:
					Form3.smethod_35((Control)(object)button4, "Начало игры");
					Form3.smethod_34((ButtonBase)(object)button4, bool_0: true);
					num = (int)((num2 * 1831449723) ^ 0x1E2DD3D2);
					continue;
				case 1u:
					Form3.smethod_38((Control)(object)button5, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form3.smethod_30((Control)(object)button5, new Point(174, 190));
					num = ((int)num2 * -1339222157) ^ 0x351083EE;
					continue;
				case 0u:
					num = (int)(num2 * 723070926) ^ -1535291329;
					continue;
				default:
					return;
				case 83u:
					break;
				case 45u:
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
