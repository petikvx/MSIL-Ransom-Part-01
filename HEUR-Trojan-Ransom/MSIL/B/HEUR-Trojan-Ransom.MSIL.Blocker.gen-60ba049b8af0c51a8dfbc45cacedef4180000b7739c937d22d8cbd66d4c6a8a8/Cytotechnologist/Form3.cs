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
			int num = -1030779630;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBC936854u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -1889547085) ^ -341597545;
					continue;
				case 1u:
					InitializeComponent();
					num = (int)(num2 * 744446099) ^ -1978163212;
					continue;
				default:
					return;
				case 0u:
					break;
				case 3u:
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
			int num = 480284585;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC46C293u) % 7u)
				{
				case 5u:
					Form3.smethod_1(errorProvider1);
					num = ((int)num2 * -147109466) ^ -2113166372;
					continue;
				case 3u:
					Form3.smethod_10(val, new Point(Form3.smethod_5((Form)(object)this).X + (Form3.smethod_6((Control)(object)this) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_5((Form)(object)this).Y + (Form3.smethod_8((Control)(object)this) - Form3.smethod_9((Control)(object)val)) / 2 + 70));
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = ((int)num2 * -541891236) ^ -180754100;
					continue;
				case 2u:
					Form3.smethod_0((Control)(object)NullButton);
					num = (int)(num2 * 548066147) ^ -1941973983;
					continue;
				case 1u:
				{
					Form4 form = new Form4();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					Form3.smethod_4((Control)(object)val);
					num = ((int)num2 * -1996618320) ^ 0x52CE3CAB;
					continue;
				}
				case 0u:
					num = (int)(num2 * 1174710697) ^ -1701944949;
					continue;
				default:
					return;
				case 6u:
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
			int num = -594317141;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCF998644u) % 7u)
				{
				case 5u:
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = ((int)num2 * -137446665) ^ -100627998;
					continue;
				case 4u:
					num = (int)(num2 * 1317077563) ^ -347347559;
					continue;
				case 3u:
					num = ((int)num2 * -1545720408) ^ -1604197194;
					continue;
				case 2u:
				{
					Form3.smethod_0((Control)(object)NullButton);
					Form2 form = new Form2();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					Form3.smethod_4((Control)(object)val);
					num = ((int)num2 * -276045795) ^ 0x237550C1;
					continue;
				}
				case 1u:
					Form3.smethod_10(val, new Point(Form3.smethod_13(Form3.smethod_12((Form)(object)this)).X + (Form3.smethod_7((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_13(Form3.smethod_12((Form)(object)this)).Y + (Form3.smethod_9((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_9((Control)(object)val)) / 2));
					num = (int)(num2 * 1692649317) ^ -123796884;
					continue;
				default:
					return;
				case 6u:
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
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		int num3 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -654987822;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB3ACD76Eu) % 9u)
				{
				case 8u:
					num = -147553455;
					continue;
				case 6u:
					Form3.smethod_15((Control)(object)this, num3);
					flag = num3 > 1;
					num = (int)((num2 * 734241971) ^ 0x19F8ABA9);
					continue;
				case 4u:
					Form3.smethod_17((Form3.smethod_12((Form)(object)this) as Form1).timer1);
					num = ((int)num2 * -1801940497) ^ -262410127;
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -252266416;
						num5 = -252266416;
					}
					else
					{
						num4 = -2064191978;
						num5 = -2064191978;
					}
					num = num4 ^ (int)(num2 * 397104591);
					continue;
				}
				case 2u:
					num = ((int)num2 * -1703182961) ^ 0x4F09D855;
					continue;
				case 1u:
					num3 = Form3.smethod_8((Control)(object)this) - 1;
					num = -1146803812;
					continue;
				case 0u:
					Form3.smethod_16(Form3.smethod_12((Form)(object)this));
					num = (int)(num2 * 779463495) ^ -324774228;
					continue;
				default:
					return;
				case 7u:
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
	}

	public void ContinueLock()
	{
		Form3.smethod_14((Control)(object)button5, bool_0: false);
		while (true)
		{
			int num = 49713332;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4FE2595Au) % 3u)
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
				num = ((int)num2 * -740914474) ^ -1595744323;
			}
		}
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
		bool flag = default(bool);
		while (true)
		{
			int num = -1006306081;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x943849D5u) % 10u)
				{
				case 8u:
					num = (int)((num2 * 610093044) ^ 0x4B2AB2AC);
					continue;
				case 7u:
					num = (int)(num2 * 651655121) ^ -1695661627;
					continue;
				case 6u:
					if (disposing)
					{
						num = (int)(num2 * 1206918859) ^ -2035457759;
						continue;
					}
					num3 = 0;
					goto IL_003d;
				case 5u:
					Form3.smethod_18((IDisposable)components);
					num = ((int)num2 * -1485567419) ^ 0x60D7BA4A;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 167576834;
						num5 = 167576834;
					}
					else
					{
						num4 = 756317040;
						num5 = 756317040;
					}
					num = num4 ^ (int)(num2 * 2061642313);
					continue;
				}
				case 3u:
					num = (int)((num2 * 655143349) ^ 0x7144A920);
					continue;
				case 1u:
					((Form)this).Dispose(disposing);
					num = -970538424;
					continue;
				case 0u:
					num3 = ((components != null) ? 1 : 0);
					goto IL_003d;
				default:
					return;
				case 9u:
					break;
				case 2u:
					return;
					IL_003d:
					flag = (byte)num3 != 0;
					num = -192429847;
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
			int num = -287173755;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEAE720F3u) % 114u)
				{
				case 113u:
					Form3.smethod_33((Control)(object)button2, 1);
					Form3.smethod_35((Control)(object)button2, "Регистрация");
					Form3.smethod_34((ButtonBase)(object)button2, bool_0: true);
					num = (int)(num2 * 352168974) ^ -1817689086;
					continue;
				case 112u:
					Form3.smethod_31((Control)(object)button5, "button5");
					num = ((int)num2 * -1365770663) ^ 0x2D8783C7;
					continue;
				case 111u:
					Form3.smethod_14((Control)(object)button4, bool_0: false);
					num = ((int)num2 * -383345059) ^ 0x240119F8;
					continue;
				case 110u:
					num = ((int)num2 * -1615275724) ^ -1282214561;
					continue;
				case 109u:
					Form3.smethod_31((Control)(object)label1, "label1");
					num = ((int)num2 * -325787524) ^ -2039344034;
					continue;
				case 108u:
					button2 = Form3.smethod_20();
					num = ((int)num2 * -158380665) ^ -1239695176;
					continue;
				case 107u:
					Form3.smethod_14((Control)(object)button5, bool_0: false);
					num = ((int)num2 * -1243389816) ^ 0x7C113A03;
					continue;
				case 106u:
					Form3.smethod_49((Form)(object)this, bool_0: false);
					num = (int)((num2 * 767357918) ^ 0x5BEDD9F1);
					continue;
				case 105u:
					Form3.smethod_30((Control)(object)NullButton, new Point(-1, -1));
					num = (int)((num2 * 1259178696) ^ 0x75BA144);
					continue;
				case 104u:
					Form3.smethod_38((Control)(object)label1, Form3.smethod_37("Mistral", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form3.smethod_30((Control)(object)label1, new Point(140, 70));
					num = ((int)num2 * -684047741) ^ 0x3D07B9EF;
					continue;
				case 103u:
					button4 = Form3.smethod_20();
					num = ((int)num2 * -493648588) ^ -1509075466;
					continue;
				case 102u:
					num = ((int)num2 * -220330053) ^ -922061027;
					continue;
				case 101u:
					Form3.smethod_54((Form)(object)this, bool_0: true);
					Form3.smethod_55((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -538008127) ^ -1945908907;
					continue;
				case 100u:
					Form3.smethod_32((Control)(object)button5, new Size(140, 50));
					num = (int)(num2 * 1897147896) ^ -682346346;
					continue;
				case 99u:
					Form3.smethod_56((Control)(object)this, bool_0: false);
					num = ((int)num2 * -1024712129) ^ -238328739;
					continue;
				case 97u:
					Form3.smethod_44((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 12076161) ^ 0x6FABE7A1);
					continue;
				case 96u:
					num = (int)(num2 * 1380553327) ^ -426700297;
					continue;
				case 95u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)label1);
					num = (int)((num2 * 615863516) ^ 0x73B7B5E0);
					continue;
				case 94u:
					num = ((int)num2 * -227048371) ^ -1455454052;
					continue;
				case 93u:
					num = (int)((num2 * 1853747452) ^ 0x795A128);
					continue;
				case 92u:
					Form3.smethod_36((Control)(object)button2, (EventHandler)Button2_Click);
					num = (int)((num2 * 90868607) ^ 0x2E279BBC);
					continue;
				case 91u:
					Form3.smethod_50((Form)(object)this, bool_0: false);
					num = (int)((num2 * 2128335542) ^ 0x2F6F8D25);
					continue;
				case 90u:
					Form3.smethod_35((Control)(object)label1, "QUARTO");
					num = (int)((num2 * 1869605692) ^ 0x198F4B0A);
					continue;
				case 89u:
					num = ((int)num2 * -1757626169) ^ -71744330;
					continue;
				case 88u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)NullButton), 0);
					num = (int)(num2 * 1478660947) ^ -1065713223;
					continue;
				case 87u:
					Form3.smethod_32((Control)(object)textBox2, new Size(140, 20));
					num = ((int)num2 * -320713214) ^ 0xC015B02;
					continue;
				case 86u:
					num = ((int)num2 * -485054253) ^ 0x2BA69D5A;
					continue;
				case 85u:
					num = ((int)num2 * -1072595089) ^ 0x2C6E6EBF;
					continue;
				case 84u:
					Form3.smethod_32((Control)(object)textBox1, new Size(140, 20));
					num = ((int)num2 * -1066840668) ^ 0x237B59FF;
					continue;
				case 83u:
					Form3.smethod_39((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					Form3.smethod_42(errorProvider1, (ContainerControl)(object)this);
					num = ((int)num2 * -228576465) ^ 0x23487DFE;
					continue;
				case 82u:
					Form3.smethod_32((Control)(object)button4, new Size(140, 50));
					Form3.smethod_33((Control)(object)button4, 4);
					num = ((int)num2 * -1746304502) ^ -2142562331;
					continue;
				case 81u:
					Form3.smethod_33((Control)(object)button5, 5);
					num = ((int)num2 * -1898709622) ^ -1122636572;
					continue;
				case 80u:
					num = (int)(num2 * 1537036508) ^ -243591645;
					continue;
				case 79u:
					num = (int)(num2 * 1397639206) ^ -2002108744;
					continue;
				case 78u:
					num = (int)(num2 * 449534552) ^ -486764821;
					continue;
				case 77u:
					num = (int)(num2 * 896189112) ^ -298947351;
					continue;
				case 76u:
					Form3.smethod_33((Control)(object)label1, 7);
					num = ((int)num2 * -1912757974) ^ 0x11ADEF7B;
					continue;
				case 75u:
					num = ((int)num2 * -467211294) ^ -1504373635;
					continue;
				case 74u:
					Form3.smethod_35((Control)(object)button4, "Начало игры");
					Form3.smethod_34((ButtonBase)(object)button4, bool_0: true);
					num = ((int)num2 * -257674128) ^ 0x6B114858;
					continue;
				case 73u:
					Form3.smethod_30((Control)(object)button1, new Point(265, 49));
					num = ((int)num2 * -962943945) ^ -1731477445;
					continue;
				case 72u:
					Form3.smethod_32((Control)(object)NullButton, new Size(1, 1));
					Form3.smethod_33((Control)(object)NullButton, 3);
					num = (int)(num2 * 1274077768) ^ -1647080489;
					continue;
				case 71u:
					button5 = Form3.smethod_20();
					num = ((int)num2 * -247928786) ^ -1601935459;
					continue;
				case 70u:
					Form3.smethod_34((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -1110984463) ^ 0x76C82F68;
					continue;
				case 69u:
					Form3.smethod_31((Control)(object)NullButton, "NullButton");
					num = (int)((num2 * 1884230319) ^ 0x719C6C53);
					continue;
				case 68u:
					Form3.smethod_29((ButtonBase)(object)NullButton, (FlatStyle)0);
					num = (int)((num2 * 822361850) ^ 0x3C3FD7D4);
					continue;
				case 67u:
					textBox2 = Form3.smethod_21();
					errorProvider1 = Form3.smethod_23(components);
					Form3.smethod_24((ISupportInitialize)errorProvider1);
					Form3.smethod_25((Control)(object)this);
					num = ((int)num2 * -1981860117) ^ 0xE118C52;
					continue;
				case 66u:
					Form3.smethod_32((Control)(object)button1, new Size(49, 21));
					Form3.smethod_33((Control)(object)button1, 0);
					num = (int)(num2 * 1714392872) ^ -1874909033;
					continue;
				case 65u:
					num = ((int)num2 * -1519122657) ^ -2049524586;
					continue;
				case 64u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button2);
					num = (int)((num2 * 1137178625) ^ 0x7268A0D1);
					continue;
				case 63u:
					num = ((int)num2 * -1599230238) ^ -1091135938;
					continue;
				case 62u:
					Form3.smethod_36((Control)(object)button7, (EventHandler)Button7_Click);
					Form3.smethod_30((Control)(object)textBox1, new Point(174, 2));
					num = ((int)num2 * -1041334271) ^ -1801412970;
					continue;
				case 61u:
					Form3.smethod_36((Control)(object)button4, (EventHandler)Button4_Click);
					num = (int)(num2 * 637160311) ^ -2029319061;
					continue;
				case 60u:
					Form3.smethod_30((Control)(object)button4, new Point(174, 137));
					Form3.smethod_31((Control)(object)button4, "button4");
					num = (int)(num2 * 776958567) ^ -1346623656;
					continue;
				case 59u:
					Form3.smethod_30((Control)(object)textBox2, new Point(174, 26));
					Form3.smethod_31((Control)(object)textBox2, "textBox2");
					num = (int)((num2 * 40473552) ^ 0x6EFFD28A);
					continue;
				case 58u:
					Form3.smethod_33((Control)(object)button7, 6);
					num = ((int)num2 * -227089833) ^ -1537732665;
					continue;
				case 57u:
					Form3.smethod_57((Control)(object)this);
					num = (int)(num2 * 1894919657) ^ -1291412623;
					continue;
				case 56u:
					num = ((int)num2 * -1027618796) ^ 0x3CD156DC;
					continue;
				case 55u:
					num = (int)((num2 * 793653629) ^ 0x47A4B6E1);
					continue;
				case 54u:
					Form3.smethod_33((Control)(object)textBox1, 7);
					Form3.smethod_39((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					Form3.smethod_40((Control)(object)label1, bool_0: true);
					num = (int)((num2 * 549146479) ^ 0x36431947);
					continue;
				case 53u:
					Form3.smethod_29((ButtonBase)(object)button4, (FlatStyle)0);
					Form3.smethod_38((Control)(object)button4, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -2029418632) ^ 0x4EBEFD31;
					continue;
				case 52u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button5), 0);
					num = (int)(num2 * 1860403917) ^ -643000181;
					continue;
				case 51u:
					Form3.smethod_33((Control)(object)textBox2, 8);
					num = ((int)num2 * -1064826673) ^ -1240380290;
					continue;
				case 50u:
					num = ((int)num2 * -1451255284) ^ 0x5F8D8459;
					continue;
				case 49u:
					Form3.smethod_35((Control)(object)button5, "Продолжить");
					Form3.smethod_34((ButtonBase)(object)button5, bool_0: true);
					num = ((int)num2 * -1864470666) ^ 0x2DF61092;
					continue;
				case 48u:
					num = (int)(num2 * 886094202) ^ -242220310;
					continue;
				case 47u:
					num = ((int)num2 * -1561294701) ^ 0x3890CC14;
					continue;
				case 46u:
					Form3.smethod_26((Control)(object)NullButton, Color.Transparent);
					num = (int)((num2 * 1025464197) ^ 0x7006571A);
					continue;
				case 45u:
					num = ((int)num2 * -287292447) ^ 0x5B97BC3F;
					continue;
				case 44u:
					button1 = Form3.smethod_20();
					num = (int)((num2 * 1556802403) ^ 0x26F2969);
					continue;
				case 43u:
					Form3.smethod_30((Control)(object)button7, new Point(174, 243));
					num = ((int)num2 * -249230289) ^ 0x5604FAD2;
					continue;
				case 42u:
					num = (int)(num2 * 558286965) ^ -2081404459;
					continue;
				case 41u:
					Form3.smethod_26((Control)(object)this, Color.White);
					num = (int)(num2 * 2028549030) ^ -1140667163;
					continue;
				case 40u:
					Form3.smethod_36((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)((num2 * 833037431) ^ 0x2506A700);
					continue;
				case 39u:
					Form3.smethod_53((Form)(object)this, bool_0: false);
					num = (int)((num2 * 956699149) ^ 0x4D438435);
					continue;
				case 38u:
					Form3.smethod_34((ButtonBase)(object)NullButton, bool_0: false);
					num = (int)((num2 * 1516803854) ^ 0x67AA6A88);
					continue;
				case 37u:
					num = (int)(num2 * 1846408906) ^ -202024015;
					continue;
				case 36u:
					Form3.smethod_35((Control)(object)button1, "Вход");
					num = ((int)num2 * -652486163) ^ 0x58A09A57;
					continue;
				case 35u:
					num = (int)(num2 * 1266474712) ^ -1440129329;
					continue;
				case 34u:
					Form3.smethod_31((Control)(object)button7, "button7");
					Form3.smethod_32((Control)(object)button7, new Size(140, 50));
					num = (int)(num2 * 139373090) ^ -2117989271;
					continue;
				case 33u:
					num = (int)((num2 * 1342995929) ^ 0x63DE3A8E);
					continue;
				case 32u:
					Form3.smethod_41(textBox2, bool_0: true);
					num = ((int)num2 * -1932147037) ^ -139371682;
					continue;
				case 31u:
					num = (int)(num2 * 2021404582) ^ -195526530;
					continue;
				case 30u:
					button7 = Form3.smethod_20();
					textBox1 = Form3.smethod_21();
					num = ((int)num2 * -2052911063) ^ -566008537;
					continue;
				case 29u:
					Form3.smethod_31((Control)(object)button1, "button1");
					num = ((int)num2 * -1924517340) ^ 0x38F58D16;
					continue;
				case 28u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button5);
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button4);
					num = (int)((num2 * 561366721) ^ 0x64507FAA);
					continue;
				case 27u:
					num = (int)((num2 * 1918186768) ^ 0x12567492);
					continue;
				case 26u:
					Form3.smethod_43((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -997848733) ^ -230112132;
					continue;
				case 25u:
					num = ((int)num2 * -793877450) ^ 0x2F78D47;
					continue;
				case 24u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button4), 0);
					num = ((int)num2 * -1353532995) ^ 0x36196648;
					continue;
				case 23u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)NullButton);
					Form3.smethod_48((Form)(object)this, (FormBorderStyle)0);
					num = ((int)num2 * -1520034788) ^ 0x25393E83;
					continue;
				case 22u:
					components = Form3.smethod_19();
					NullButton = Form3.smethod_20();
					num = ((int)num2 * -1651199829) ^ -1114470327;
					continue;
				case 21u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button1);
					num = (int)((num2 * 1608140329) ^ 0x5DCDA11);
					continue;
				case 20u:
					label1 = Form3.smethod_22();
					num = ((int)num2 * -2084672195) ^ -1161044136;
					continue;
				case 19u:
					num = ((int)num2 * -1450239455) ^ 0x5D1B9B47;
					continue;
				case 18u:
					Form3.smethod_51((Control)(object)this, "Form3");
					Form3.smethod_52((Form)(object)this, bool_0: false);
					num = ((int)num2 * -2094353414) ^ 0x448ECC42;
					continue;
				case 16u:
					Form3.smethod_34((ButtonBase)(object)button7, bool_0: true);
					num = (int)((num2 * 1086077708) ^ 0x73AD85B1);
					continue;
				case 15u:
					Form3.smethod_32((Control)(object)label1, new Size(207, 76));
					num = ((int)num2 * -1584900471) ^ 0x538E3FF2;
					continue;
				case 14u:
					Form3.smethod_26((Control)(object)label1, Color.Transparent);
					num = (int)(num2 * 1070435165) ^ -1606730053;
					continue;
				case 13u:
					Form3.smethod_30((Control)(object)button2, new Point(174, 49));
					num = ((int)num2 * -1172127395) ^ 0x3228E78D;
					continue;
				case 12u:
					Form3.smethod_38((Control)(object)button7, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 756957244) ^ 0x426F6846);
					continue;
				case 11u:
					Form3.smethod_31((Control)(object)textBox1, "textBox1");
					num = ((int)num2 * -1295461920) ^ -1852126168;
					continue;
				case 10u:
					num = (int)(num2 * 19241739) ^ -55158054;
					continue;
				case 9u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox2);
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox1);
					num = (int)(num2 * 746271958) ^ -1868772221;
					continue;
				case 8u:
					num = (int)(num2 * 714386010) ^ -1458799582;
					continue;
				case 7u:
					Form3.smethod_36((Control)(object)button5, (EventHandler)Button5_Click);
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button7), 0);
					Form3.smethod_29((ButtonBase)(object)button7, (FlatStyle)0);
					num = (int)((num2 * 1810910646) ^ 0x332C30D4);
					continue;
				case 6u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button7);
					num = (int)((num2 * 69871423) ^ 0x68EC2DBB);
					continue;
				case 5u:
					Form3.smethod_35((Control)(object)button7, "Достижения");
					num = (int)((num2 * 660629728) ^ 0x42C9301B);
					continue;
				case 4u:
					Form3.smethod_29((ButtonBase)(object)button5, (FlatStyle)0);
					Form3.smethod_38((Control)(object)button5, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1904913152) ^ -1162495283;
					continue;
				case 3u:
					Form3.smethod_31((Control)(object)button2, "button2");
					Form3.smethod_32((Control)(object)button2, new Size(85, 21));
					num = ((int)num2 * -216013711) ^ -1886860288;
					continue;
				case 2u:
					Form3.smethod_45((Form)(object)this, new Size(486, 296));
					num = ((int)num2 * -49983918) ^ 0x415FB8CB;
					continue;
				case 1u:
					num = ((int)num2 * -550808597) ^ 0x7784C7A8;
					continue;
				case 0u:
					Form3.smethod_30((Control)(object)button5, new Point(174, 190));
					num = ((int)num2 * -942980415) ^ -805753935;
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
