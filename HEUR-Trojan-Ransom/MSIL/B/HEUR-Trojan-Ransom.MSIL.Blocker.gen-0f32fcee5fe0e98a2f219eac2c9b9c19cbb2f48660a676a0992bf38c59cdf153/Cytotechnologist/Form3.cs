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
			int num = 1961491807;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x21E044C1u) % 5u)
				{
				case 4u:
					InitializeComponent();
					num = (int)(num2 * 1174929838) ^ -1006419476;
					continue;
				case 2u:
					num = (int)(num2 * 1070695663) ^ -1071920731;
					continue;
				case 0u:
					num = ((int)num2 * -646279473) ^ -206339873;
					continue;
				default:
					return;
				case 3u:
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
		Form3.smethod_0((Control)(object)NullButton);
		Form val = default(Form);
		while (true)
		{
			int num = -843958071;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAB29FAA4u) % 7u)
				{
				case 5u:
				{
					Form4 form = new Form4();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					Form3.smethod_4((Control)(object)val);
					num = (int)(num2 * 1298249719) ^ -1323408486;
					continue;
				}
				case 4u:
					Form3.smethod_10(val, new Point(Form3.smethod_5((Form)(object)this).X + (Form3.smethod_6((Control)(object)this) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_5((Form)(object)this).Y + (Form3.smethod_8((Control)(object)this) - Form3.smethod_9((Control)(object)val)) / 2 + 70));
					num = ((int)num2 * -637890482) ^ -384556322;
					continue;
				case 3u:
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = (int)(num2 * 1847880295) ^ -2011948562;
					continue;
				case 2u:
					Form3.smethod_1(errorProvider1);
					num = ((int)num2 * -959524172) ^ 0x5427CF10;
					continue;
				case 1u:
					num = (int)((num2 * 1594185473) ^ 0x6650A017);
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

	private void Button4_Click(object sender, EventArgs e)
	{
		Form val = default(Form);
		while (true)
		{
			int num = -817964840;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA7D110C7u) % 6u)
				{
				case 5u:
					Form3.smethod_10(val, new Point(Form3.smethod_13(Form3.smethod_12((Form)(object)this)).X + (Form3.smethod_7((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_13(Form3.smethod_12((Form)(object)this)).Y + (Form3.smethod_9((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_9((Control)(object)val)) / 2));
					num = (int)(num2 * 869705970) ^ -91977026;
					continue;
				case 4u:
				{
					Form2 form = new Form2();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					num = (int)((num2 * 542080616) ^ 0x7449B15B);
					continue;
				}
				case 2u:
					Form3.smethod_4((Control)(object)val);
					num = ((int)num2 * -349110105) ^ -980818080;
					continue;
				case 1u:
					Form3.smethod_0((Control)(object)NullButton);
					num = (int)((num2 * 1931498623) ^ 0x35940470);
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
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		bool flag = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = 669812629;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1C642F48u) % 10u)
				{
				case 9u:
					num = ((int)num2 * -1577373902) ^ 0x5037789F;
					continue;
				case 8u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1328304481;
						num5 = -1328304481;
					}
					else
					{
						num4 = -1309885966;
						num5 = -1309885966;
					}
					num = num4 ^ ((int)num2 * -227825720);
					continue;
				}
				case 7u:
					Form3.smethod_17((Form3.smethod_12((Form)(object)this) as Form1).timer1);
					num = (int)((num2 * 1138396655) ^ 0x3B546151);
					continue;
				case 5u:
					num3 = Form3.smethod_8((Control)(object)this) - 1;
					num = 1020438752;
					continue;
				case 3u:
					flag = num3 > 1;
					num = ((int)num2 * -326433075) ^ 0x22182AF1;
					continue;
				case 2u:
					Form3.smethod_15((Control)(object)this, num3);
					num = (int)(num2 * 921743898) ^ -1044866127;
					continue;
				case 1u:
					num = 358086325;
					continue;
				case 0u:
					Form3.smethod_16(Form3.smethod_12((Form)(object)this));
					num = (int)((num2 * 2037092188) ^ 0x61804CF);
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

	private void Button1_Click(object sender, EventArgs e)
	{
	}

	private void TextBox_TextChanged(object sender, EventArgs e)
	{
		Form3.smethod_1(errorProvider1);
		while (true)
		{
			int num = -406612335;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE0F5382Fu) % 3u)
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
				num = (int)(num2 * 1762677818) ^ -650941947;
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
			int num = -170991401;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE1464DAAu) % 4u)
				{
				case 2u:
					Form3.smethod_14((Control)(object)button7, bool_0: false);
					num = ((int)num2 * -859780792) ^ -835578683;
					continue;
				case 1u:
					Form3.smethod_0((Control)(object)NullButton);
					num = (int)(num2 * 1999706913) ^ -2137699607;
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

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			goto IL_0017;
		}
		int num = 0;
		goto IL_00c6;
		IL_00c6:
		bool flag = (byte)num != 0;
		int num2 = 1474806586;
		goto IL_0087;
		IL_0017:
		num2 = 1356009350;
		goto IL_0087;
		IL_0087:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x4A8DB81Cu) % 9u)
			{
			case 7u:
				((Form)this).Dispose(disposing);
				num2 = 346333523;
				continue;
			case 6u:
				break;
			case 5u:
			{
				int num4;
				int num5;
				if (!flag)
				{
					num4 = -311698753;
					num5 = -311698753;
				}
				else
				{
					num4 = -1296624587;
					num5 = -1296624587;
				}
				num2 = num4 ^ ((int)num3 * -888456292);
				continue;
			}
			case 3u:
				num2 = (int)((num3 * 534355980) ^ 0x62C78855);
				continue;
			case 2u:
				num2 = ((int)num3 * -1785672375) ^ -1955838831;
				continue;
			case 1u:
				Form3.smethod_18((IDisposable)components);
				num2 = (int)((num3 * 181089512) ^ 0x5D2AE7A2);
				continue;
			case 0u:
				num2 = ((int)num3 * -1893540806) ^ 0xC84D1AB;
				continue;
			default:
				return;
			case 4u:
				goto IL_00bd;
			case 8u:
				return;
			}
			break;
		}
		goto IL_0017;
		IL_00bd:
		num = ((components != null) ? 1 : 0);
		goto IL_00c6;
	}

	private void InitializeComponent()
	{
		while (true)
		{
			int num = -710104715;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBDDF6598u) % 129u)
				{
				case 128u:
					Form3.smethod_35((Control)(object)button5, "Продолжить");
					num = ((int)num2 * -310627323) ^ 0x4D24AD53;
					continue;
				case 127u:
					num = ((int)num2 * -906223652) ^ -1641028623;
					continue;
				case 126u:
					Form3.smethod_45((Form)(object)this, new Size(486, 296));
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox2);
					num = ((int)num2 * -509594537) ^ 0x61F3E2A6;
					continue;
				case 125u:
					num = (int)(num2 * 639257651) ^ -626915132;
					continue;
				case 124u:
					num = (int)((num2 * 196144083) ^ 0x65BB9A3D);
					continue;
				case 123u:
					Form3.smethod_38((Control)(object)label1, Form3.smethod_37("Mistral", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1820831802) ^ 0x4D22F956;
					continue;
				case 122u:
					num = ((int)num2 * -883699706) ^ -541024313;
					continue;
				case 121u:
					button7 = Form3.smethod_20();
					num = (int)((num2 * 849255234) ^ 0x7F031528);
					continue;
				case 120u:
					Form3.smethod_32((Control)(object)button4, new Size(140, 50));
					num = ((int)num2 * -1605514626) ^ -522703102;
					continue;
				case 119u:
					num = ((int)num2 * -1013173522) ^ 0x4E59236D;
					continue;
				case 118u:
					num = ((int)num2 * -330471881) ^ 0xDF7D26F;
					continue;
				case 117u:
					num = (int)((num2 * 1577004362) ^ 0xABBCFFA);
					continue;
				case 116u:
					Form3.smethod_31((Control)(object)textBox2, "textBox2");
					num = (int)((num2 * 816743816) ^ 0x10C847E9);
					continue;
				case 115u:
					num = (int)((num2 * 18300895) ^ 0x28C01ED4);
					continue;
				case 114u:
					Form3.smethod_30((Control)(object)label1, new Point(140, 70));
					Form3.smethod_31((Control)(object)label1, "label1");
					Form3.smethod_32((Control)(object)label1, new Size(207, 76));
					num = (int)(num2 * 1386401911) ^ -2022818638;
					continue;
				case 113u:
					num = (int)((num2 * 1979608257) ^ 0x31950263);
					continue;
				case 112u:
					Form3.smethod_38((Control)(object)button7, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1865117411) ^ 0x3DAF8BAF;
					continue;
				case 111u:
					Form3.smethod_33((Control)(object)button4, 4);
					num = (int)(num2 * 288513872) ^ -205371608;
					continue;
				case 110u:
					button4 = Form3.smethod_20();
					num = ((int)num2 * -863137226) ^ -607287055;
					continue;
				case 109u:
					num = (int)(num2 * 1874645770) ^ -2123997156;
					continue;
				case 108u:
					Form3.smethod_50((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1295460484) ^ 0x1EFA5DA0;
					continue;
				case 107u:
					Form3.smethod_52((Form)(object)this, bool_0: false);
					num = (int)((num2 * 965190084) ^ 0x220ACACC);
					continue;
				case 106u:
					Form3.smethod_31((Control)(object)button4, "button4");
					num = (int)((num2 * 1220449423) ^ 0x62A23B27);
					continue;
				case 105u:
					num = ((int)num2 * -182406547) ^ -480735147;
					continue;
				case 104u:
					Form3.smethod_54((Form)(object)this, bool_0: true);
					num = (int)(num2 * 195049070) ^ -17630586;
					continue;
				case 103u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button4);
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button2);
					num = ((int)num2 * -127141830) ^ -1558136495;
					continue;
				case 102u:
					components = Form3.smethod_19();
					NullButton = Form3.smethod_20();
					button1 = Form3.smethod_20();
					num = ((int)num2 * -1537981695) ^ 0x5034C7B7;
					continue;
				case 101u:
					Form3.smethod_38((Control)(object)button5, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 1782275084) ^ 0x48B20553);
					continue;
				case 100u:
					Form3.smethod_34((ButtonBase)(object)button5, bool_0: true);
					num = ((int)num2 * -1071579087) ^ 0x42D7F2C8;
					continue;
				case 99u:
					Form3.smethod_34((ButtonBase)(object)button4, bool_0: true);
					Form3.smethod_36((Control)(object)button4, (EventHandler)Button4_Click);
					num = (int)(num2 * 1244035404) ^ -1391965970;
					continue;
				case 98u:
					Form3.smethod_57((Control)(object)this);
					num = ((int)num2 * -1055470488) ^ 0x3BDDD8AD;
					continue;
				case 97u:
					Form3.smethod_56((Control)(object)this, bool_0: false);
					num = ((int)num2 * -653125753) ^ -1871960784;
					continue;
				case 96u:
					textBox1 = Form3.smethod_21();
					label1 = Form3.smethod_22();
					num = ((int)num2 * -104176943) ^ -2115061548;
					continue;
				case 95u:
					errorProvider1 = Form3.smethod_23(components);
					num = (int)(num2 * 1492829096) ^ -635744241;
					continue;
				case 94u:
					Form3.smethod_42(errorProvider1, (ContainerControl)(object)this);
					Form3.smethod_43((ContainerControl)(object)this, new SizeF(6f, 13f));
					Form3.smethod_44((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -887919327) ^ -1248238145;
					continue;
				case 93u:
					Form3.smethod_30((Control)(object)button7, new Point(174, 243));
					num = ((int)num2 * -786299897) ^ -1563818195;
					continue;
				case 92u:
					Form3.smethod_31((Control)(object)button1, "button1");
					num = ((int)num2 * -623281216) ^ 0x57E56603;
					continue;
				case 91u:
					num = ((int)num2 * -711941038) ^ 0x4C6BB49C;
					continue;
				case 90u:
					num = ((int)num2 * -1442461912) ^ 0x7978DC17;
					continue;
				case 89u:
					Form3.smethod_32((Control)(object)button5, new Size(140, 50));
					num = (int)((num2 * 1142567065) ^ 0x14144A96);
					continue;
				case 88u:
					Form3.smethod_35((Control)(object)label1, "QUARTO");
					num = (int)((num2 * 387306961) ^ 0x14A6F5F1);
					continue;
				case 87u:
					Form3.smethod_35((Control)(object)button7, "Достижения");
					num = ((int)num2 * -1117857847) ^ -1184322135;
					continue;
				case 86u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button4), 0);
					num = ((int)num2 * -1689872123) ^ -920838175;
					continue;
				case 85u:
					Form3.smethod_24((ISupportInitialize)errorProvider1);
					num = (int)(num2 * 1211943674) ^ -49512072;
					continue;
				case 84u:
					Form3.smethod_34((ButtonBase)(object)button7, bool_0: true);
					num = (int)((num2 * 1853217901) ^ 0x3398A6F3);
					continue;
				case 83u:
					Form3.smethod_29((ButtonBase)(object)button7, (FlatStyle)0);
					num = (int)(num2 * 800467918) ^ -1553519076;
					continue;
				case 82u:
					num = ((int)num2 * -1634389258) ^ 0x4CAD17D0;
					continue;
				case 81u:
					button5 = Form3.smethod_20();
					num = ((int)num2 * -817434312) ^ -1504993448;
					continue;
				case 80u:
					num = ((int)num2 * -2096836573) ^ -1532345994;
					continue;
				case 79u:
					Form3.smethod_26((Control)(object)NullButton, Color.Transparent);
					num = (int)(num2 * 739317622) ^ -1164083075;
					continue;
				case 78u:
					num = ((int)num2 * -568203066) ^ 0x76B3C0E8;
					continue;
				case 77u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -980369294) ^ -1951153022;
					continue;
				case 76u:
					Form3.smethod_25((Control)(object)this);
					num = (int)((num2 * 1907992915) ^ 0x627B5D67);
					continue;
				case 75u:
					Form3.smethod_35((Control)(object)button4, "Начало игры");
					num = (int)((num2 * 1403668873) ^ 0x679BFFB1);
					continue;
				case 74u:
					Form3.smethod_26((Control)(object)this, Color.White);
					num = ((int)num2 * -911915794) ^ -941298971;
					continue;
				case 73u:
					num = (int)((num2 * 1243879042) ^ 0x7348D9A5);
					continue;
				case 72u:
					Form3.smethod_33((Control)(object)button7, 6);
					num = ((int)num2 * -1525656636) ^ -204439042;
					continue;
				case 71u:
					num = ((int)num2 * -1283916474) ^ -1413727098;
					continue;
				case 70u:
					Form3.smethod_34((ButtonBase)(object)NullButton, bool_0: false);
					num = ((int)num2 * -1538328152) ^ 0x3B147CF2;
					continue;
				case 69u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button7);
					num = ((int)num2 * -1670803590) ^ -1757192952;
					continue;
				case 68u:
					textBox2 = Form3.smethod_21();
					num = (int)(num2 * 1434167731) ^ -1394504424;
					continue;
				case 67u:
					Form3.smethod_36((Control)(object)button7, (EventHandler)Button7_Click);
					num = ((int)num2 * -2114547374) ^ 0x5C5F4103;
					continue;
				case 66u:
					num = ((int)num2 * -2132547321) ^ 0x113ADFEA;
					continue;
				case 65u:
					num = ((int)num2 * -1925175688) ^ 0x471C6C28;
					continue;
				case 64u:
					Form3.smethod_30((Control)(object)button2, new Point(174, 49));
					num = ((int)num2 * -1949558200) ^ 0x6867398F;
					continue;
				case 63u:
					Form3.smethod_30((Control)(object)textBox1, new Point(174, 2));
					Form3.smethod_31((Control)(object)textBox1, "textBox1");
					Form3.smethod_32((Control)(object)textBox1, new Size(140, 20));
					num = (int)(num2 * 130964204) ^ -1306120040;
					continue;
				case 62u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button7), 0);
					num = (int)((num2 * 672860827) ^ 0x33D8796);
					continue;
				case 61u:
					Form3.smethod_35((Control)(object)button1, "Вход");
					num = (int)(num2 * 1705505187) ^ -654878155;
					continue;
				case 60u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)NullButton), 0);
					num = (int)(num2 * 1958002699) ^ -896256703;
					continue;
				case 59u:
					Form3.smethod_29((ButtonBase)(object)NullButton, (FlatStyle)0);
					Form3.smethod_30((Control)(object)NullButton, new Point(-1, -1));
					num = ((int)num2 * -2008593558) ^ -582842636;
					continue;
				case 58u:
					num = ((int)num2 * -88958104) ^ -203629562;
					continue;
				case 57u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox1);
					num = (int)((num2 * 740604868) ^ 0x3C3ABF4A);
					continue;
				case 56u:
					Form3.smethod_32((Control)(object)button2, new Size(85, 21));
					Form3.smethod_33((Control)(object)button2, 1);
					num = (int)(num2 * 135157832) ^ -471110428;
					continue;
				case 55u:
					num = ((int)num2 * -933960219) ^ 0x72D12C27;
					continue;
				case 54u:
					Form3.smethod_32((Control)(object)button1, new Size(49, 21));
					num = (int)((num2 * 470223838) ^ 0x683E4D38);
					continue;
				case 53u:
					Form3.smethod_14((Control)(object)button5, bool_0: false);
					num = ((int)num2 * -1857190695) ^ -465208514;
					continue;
				case 52u:
					Form3.smethod_33((Control)(object)label1, 7);
					num = ((int)num2 * -1558287146) ^ 0x7A28F4DF;
					continue;
				case 51u:
					Form3.smethod_55((ISupportInitialize)errorProvider1);
					num = (int)(num2 * 1857971867) ^ -502808660;
					continue;
				case 50u:
					Form3.smethod_39((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = (int)((num2 * 1288615394) ^ 0x490D131);
					continue;
				case 49u:
					num = (int)((num2 * 1761162647) ^ 0x1BFBDC28);
					continue;
				case 48u:
					Form3.smethod_31((Control)(object)button5, "button5");
					num = (int)(num2 * 1705444433) ^ -211887691;
					continue;
				case 47u:
					Form3.smethod_29((ButtonBase)(object)button4, (FlatStyle)0);
					num = ((int)num2 * -1888369955) ^ -1846436917;
					continue;
				case 46u:
					Form3.smethod_32((Control)(object)textBox2, new Size(140, 20));
					Form3.smethod_33((Control)(object)textBox2, 8);
					Form3.smethod_41(textBox2, bool_0: true);
					num = ((int)num2 * -1604788499) ^ -1836832224;
					continue;
				case 45u:
					Form3.smethod_31((Control)(object)button2, "button2");
					num = (int)(num2 * 764193951) ^ -365839903;
					continue;
				case 44u:
					Form3.smethod_34((ButtonBase)(object)button1, bool_0: true);
					Form3.smethod_36((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)(num2 * 1313854763) ^ -814618380;
					continue;
				case 43u:
					Form3.smethod_33((Control)(object)button1, 0);
					num = ((int)num2 * -1364584535) ^ 0x718F66C4;
					continue;
				case 42u:
					Form3.smethod_14((Control)(object)button4, bool_0: false);
					num = ((int)num2 * -155786238) ^ -375457641;
					continue;
				case 41u:
					Form3.smethod_32((Control)(object)button7, new Size(140, 50));
					num = (int)((num2 * 1228220088) ^ 0x3ACEB4A);
					continue;
				case 40u:
					Form3.smethod_30((Control)(object)textBox2, new Point(174, 26));
					num = ((int)num2 * -335064593) ^ 0x338EC2D1;
					continue;
				case 39u:
					Form3.smethod_40((Control)(object)label1, bool_0: true);
					Form3.smethod_26((Control)(object)label1, Color.Transparent);
					num = ((int)num2 * -1593900439) ^ 0x5609B76D;
					continue;
				case 38u:
					Form3.smethod_49((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1361973292) ^ 0x6DEDC125;
					continue;
				case 37u:
					Form3.smethod_39((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -619476822) ^ 0x43460F98;
					continue;
				case 36u:
					Form3.smethod_38((Control)(object)button4, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 351098302) ^ -1569076769;
					continue;
				case 35u:
					num = ((int)num2 * -310125941) ^ 0x7DBDD76B;
					continue;
				case 34u:
					Form3.smethod_33((Control)(object)NullButton, 3);
					num = ((int)num2 * -871745584) ^ -1226586978;
					continue;
				case 33u:
					Form3.smethod_48((Form)(object)this, (FormBorderStyle)0);
					num = ((int)num2 * -1225461961) ^ 0x1729D238;
					continue;
				case 32u:
					num = (int)(num2 * 805023581) ^ -1487613950;
					continue;
				case 31u:
					num = (int)(num2 * 207050322) ^ -878721821;
					continue;
				case 30u:
					Form3.smethod_33((Control)(object)textBox1, 7);
					num = ((int)num2 * -2089717863) ^ 0x62AD37C6;
					continue;
				case 29u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)NullButton);
					num = ((int)num2 * -905296974) ^ -1490947029;
					continue;
				case 28u:
					Form3.smethod_31((Control)(object)button7, "button7");
					num = (int)((num2 * 1271651727) ^ 0x4F98B055);
					continue;
				case 27u:
					num = ((int)num2 * -717525138) ^ -1862244120;
					continue;
				case 26u:
					num = (int)((num2 * 105724434) ^ 0x688FE919);
					continue;
				case 25u:
					num = (int)((num2 * 797856068) ^ 0x6080522B);
					continue;
				case 24u:
					num = (int)((num2 * 306839628) ^ 0x5D2B1F7);
					continue;
				case 23u:
					Form3.smethod_35((Control)(object)button2, "Регистрация");
					Form3.smethod_34((ButtonBase)(object)button2, bool_0: true);
					Form3.smethod_36((Control)(object)button2, (EventHandler)Button2_Click);
					num = (int)((num2 * 545047948) ^ 0x7CEF50E);
					continue;
				case 21u:
					Form3.smethod_36((Control)(object)button5, (EventHandler)Button5_Click);
					num = ((int)num2 * -678775910) ^ -308809757;
					continue;
				case 20u:
					Form3.smethod_53((Form)(object)this, bool_0: false);
					num = (int)(num2 * 532050822) ^ -1723045824;
					continue;
				case 19u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button5);
					num = ((int)num2 * -412358352) ^ -1205894845;
					continue;
				case 18u:
					Form3.smethod_30((Control)(object)button1, new Point(265, 49));
					num = ((int)num2 * -1136497714) ^ -159377656;
					continue;
				case 16u:
					Form3.smethod_51((Control)(object)this, "Form3");
					num = (int)(num2 * 822728509) ^ -133629067;
					continue;
				case 15u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button1);
					num = (int)((num2 * 1384566262) ^ 0x2D1ECD65);
					continue;
				case 14u:
					num = (int)((num2 * 808085083) ^ 0x2B437D61);
					continue;
				case 13u:
					num = ((int)num2 * -664821088) ^ -1070271547;
					continue;
				case 12u:
					num = ((int)num2 * -2114685815) ^ 0x2DE121D9;
					continue;
				case 11u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button5), 0);
					Form3.smethod_29((ButtonBase)(object)button5, (FlatStyle)0);
					num = (int)(num2 * 2089882890) ^ -1496323878;
					continue;
				case 10u:
					num = (int)(num2 * 167238219) ^ -1425287559;
					continue;
				case 9u:
					num = (int)(num2 * 1963181026) ^ -1186698383;
					continue;
				case 8u:
					num = (int)(num2 * 49437679) ^ -474629444;
					continue;
				case 7u:
					Form3.smethod_30((Control)(object)button5, new Point(174, 190));
					num = ((int)num2 * -910012289) ^ -1328914547;
					continue;
				case 6u:
					Form3.smethod_30((Control)(object)button4, new Point(174, 137));
					num = ((int)num2 * -951267385) ^ 0x412D642E;
					continue;
				case 5u:
					num = (int)((num2 * 703611044) ^ 0x4607A7AE);
					continue;
				case 4u:
					num = ((int)num2 * -1636715787) ^ 0x45160DD4;
					continue;
				case 3u:
					Form3.smethod_31((Control)(object)NullButton, "NullButton");
					Form3.smethod_32((Control)(object)NullButton, new Size(1, 1));
					num = ((int)num2 * -2036147219) ^ 0x6E20E1B3;
					continue;
				case 2u:
					Form3.smethod_33((Control)(object)button5, 5);
					num = ((int)num2 * -36867525) ^ 0x42446AD3;
					continue;
				case 1u:
					button2 = Form3.smethod_20();
					num = ((int)num2 * -1231815571) ^ 0x1BEFE86A;
					continue;
				case 0u:
					num = ((int)num2 * -589838577) ^ 0x507E462E;
					continue;
				default:
					return;
				case 22u:
					break;
				case 17u:
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
