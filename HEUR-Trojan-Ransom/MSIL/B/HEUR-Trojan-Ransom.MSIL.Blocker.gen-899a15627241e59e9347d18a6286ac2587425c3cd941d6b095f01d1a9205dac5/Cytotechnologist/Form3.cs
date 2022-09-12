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
			int num = 736734594;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x321F5A4Eu) % 5u)
				{
				case 2u:
					num = (int)(num2 * 1947509256) ^ -726702471;
					continue;
				case 1u:
					num = (int)((num2 * 1194189160) ^ 0x518F7FC3);
					continue;
				case 0u:
					InitializeComponent();
					num = (int)(num2 * 983842185) ^ -351870731;
					continue;
				default:
					return;
				case 3u:
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
			int num = -760010846;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC4BC80DDu) % 5u)
				{
				case 4u:
					Form3.smethod_10(val, new Point(Form3.smethod_5((Form)(object)this).X + (Form3.smethod_6((Control)(object)this) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_5((Form)(object)this).Y + (Form3.smethod_8((Control)(object)this) - Form3.smethod_9((Control)(object)val)) / 2 + 70));
					num = ((int)num2 * -995481776) ^ 0x39A0876A;
					continue;
				case 2u:
				{
					Form4 form = new Form4();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					Form3.smethod_4((Control)(object)val);
					num = ((int)num2 * -801995158) ^ 0x54DA1E5F;
					continue;
				}
				case 1u:
					num = ((int)num2 * -1557941490) ^ 0x34D35C67;
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

	private void Button4_Click(object sender, EventArgs e)
	{
		Form3.smethod_0((Control)(object)NullButton);
		Form val = default(Form);
		while (true)
		{
			int num = 1255314654;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x17F7023Bu) % 4u)
				{
				case 1u:
				{
					Form2 form = new Form2();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					num = ((int)num2 * -319041630) ^ 0x1A3D91C1;
					continue;
				}
				case 0u:
					Form3.smethod_4((Control)(object)val);
					num = ((int)num2 * -1215521412) ^ -294516671;
					continue;
				case 3u:
					break;
				default:
					Form3.smethod_10(val, new Point(Form3.smethod_13(Form3.smethod_12((Form)(object)this)).X + (Form3.smethod_7((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_13(Form3.smethod_12((Form)(object)this)).Y + (Form3.smethod_9((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_9((Control)(object)val)) / 2));
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
		int num3 = default(int);
		while (true)
		{
			int num = 495919646;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3F1DAB0Bu) % 8u)
				{
				case 7u:
					num = 184034277;
					continue;
				case 6u:
					num3 = Form3.smethod_8((Control)(object)this) - 1;
					Form3.smethod_15((Control)(object)this, num3);
					num = 1054590889;
					continue;
				case 5u:
					num = (int)((num2 * 1645773846) ^ 0x61C6B82B);
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (num3 > 1)
					{
						num4 = -16100368;
						num5 = -16100368;
					}
					else
					{
						num4 = -2021428746;
						num5 = -2021428746;
					}
					num = num4 ^ (int)(num2 * 767191314);
					continue;
				}
				case 1u:
					Form3.smethod_16(Form3.smethod_12((Form)(object)this));
					num = ((int)num2 * -1746330264) ^ -493923109;
					continue;
				case 0u:
					Form3.smethod_17((Form3.smethod_12((Form)(object)this) as Form1).timer1);
					num = (int)(num2 * 861570168) ^ -1734719041;
					continue;
				default:
					return;
				case 3u:
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
			int num = 156902731;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x91CC850u) % 3u)
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
				num = (int)(num2 * 597166985) ^ -2054127448;
			}
		}
	}

	private void Button7_Click(object sender, EventArgs e)
	{
		Form3.smethod_0((Control)(object)NullButton);
		Form3.smethod_14((Control)(object)button7, bool_0: false);
	}

	protected override void Dispose(bool disposing)
	{
		while (true)
		{
			int num = 1150666125;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x5B61046Bu) % 7u)
				{
				case 6u:
					Form3.smethod_18((IDisposable)components);
					num = (int)(num2 * 1740517900) ^ -1616316565;
					continue;
				case 5u:
					((Form)this).Dispose(disposing);
					num = 1033480814;
					continue;
				case 3u:
					num = ((int)num2 * -2099407683) ^ 0x70DC7720;
					continue;
				case 2u:
					if (disposing)
					{
						num = ((int)num2 * -181477336) ^ 0x3F298AA2;
						continue;
					}
					goto IL_0052;
				case 1u:
					if (components != null)
					{
						num = 774114363;
						num3 = 774114363;
						continue;
					}
					goto IL_0052;
				default:
					return;
				case 0u:
					break;
				case 4u:
					return;
					IL_0052:
					num = 791969071;
					num3 = 791969071;
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
			int num = -550454016;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFF6CEFA7u) % 124u)
				{
				case 123u:
					num = ((int)num2 * -1453302529) ^ -1185081594;
					continue;
				case 122u:
					Form3.smethod_32((Control)(object)button4, new Size(140, 50));
					num = (int)(num2 * 417993300) ^ -1785631753;
					continue;
				case 121u:
					Form3.smethod_33((Control)(object)button4, 4);
					Form3.smethod_35((Control)(object)button4, "Начало игры");
					num = ((int)num2 * -1445481846) ^ -476982400;
					continue;
				case 120u:
					Form3.smethod_26((Control)(object)label1, Color.Transparent);
					Form3.smethod_38((Control)(object)label1, Form3.smethod_37("Mistral", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 1153986148) ^ -1932634070;
					continue;
				case 119u:
					num = ((int)num2 * -1465475581) ^ 0x29AD6184;
					continue;
				case 118u:
					Form3.smethod_30((Control)(object)textBox2, new Point(174, 26));
					num = ((int)num2 * -1757794009) ^ -280854497;
					continue;
				case 117u:
					Form3.smethod_29((ButtonBase)(object)button4, (FlatStyle)0);
					num = (int)((num2 * 2059774879) ^ 0x16B305DA);
					continue;
				case 116u:
					Form3.smethod_29((ButtonBase)(object)button5, (FlatStyle)0);
					num = (int)((num2 * 1809162058) ^ 0x42090CAE);
					continue;
				case 115u:
					button7 = Form3.smethod_20();
					num = (int)(num2 * 1717027625) ^ -40594340;
					continue;
				case 114u:
					Form3.smethod_25((Control)(object)this);
					num = (int)(num2 * 476990649) ^ -589766874;
					continue;
				case 113u:
					Form3.smethod_51((Control)(object)this, "Form3");
					Form3.smethod_52((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1822686177) ^ -414678082;
					continue;
				case 112u:
					num = ((int)num2 * -909831970) ^ -169050854;
					continue;
				case 111u:
					Form3.smethod_49((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1415181408) ^ -1424804623;
					continue;
				case 110u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button4), 0);
					num = (int)((num2 * 685134153) ^ 0x1E65190);
					continue;
				case 109u:
					num = (int)(num2 * 1662732845) ^ -412145209;
					continue;
				case 108u:
					Form3.smethod_30((Control)(object)label1, new Point(140, 70));
					num = ((int)num2 * -1962527892) ^ 0x67A35CE1;
					continue;
				case 107u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox2);
					num = ((int)num2 * -1961816744) ^ -1469541218;
					continue;
				case 106u:
					Form3.smethod_36((Control)(object)button4, (EventHandler)Button4_Click);
					num = ((int)num2 * -344454046) ^ 0x545FB2A3;
					continue;
				case 105u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox1);
					num = (int)(num2 * 298951017) ^ -1899910654;
					continue;
				case 104u:
					num = ((int)num2 * -660337725) ^ -667658900;
					continue;
				case 103u:
					Form3.smethod_32((Control)(object)button7, new Size(140, 50));
					Form3.smethod_33((Control)(object)button7, 6);
					num = (int)(num2 * 890741220) ^ -938782002;
					continue;
				case 102u:
					num = (int)((num2 * 1958131036) ^ 0x42747854);
					continue;
				case 101u:
					Form3.smethod_34((ButtonBase)(object)button7, bool_0: true);
					num = ((int)num2 * -633321370) ^ -1853880370;
					continue;
				case 100u:
					Form3.smethod_30((Control)(object)NullButton, new Point(-1, -1));
					num = ((int)num2 * -171630904) ^ 0x5CF5BCBF;
					continue;
				case 99u:
					Form3.smethod_34((ButtonBase)(object)NullButton, bool_0: false);
					num = ((int)num2 * -1455549110) ^ 0x6B53F804;
					continue;
				case 98u:
					Form3.smethod_48((Form)(object)this, (FormBorderStyle)0);
					num = (int)((num2 * 242942380) ^ 0x479824D8);
					continue;
				case 97u:
					Form3.smethod_39((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = (int)(num2 * 1397738037) ^ -1789262614;
					continue;
				case 96u:
					Form3.smethod_36((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -686770684) ^ -2075516764;
					continue;
				case 95u:
					Form3.smethod_34((ButtonBase)(object)button4, bool_0: true);
					num = ((int)num2 * -1244412951) ^ 0x7AAB505E;
					continue;
				case 94u:
					Form3.smethod_32((Control)(object)label1, new Size(207, 76));
					Form3.smethod_33((Control)(object)label1, 7);
					Form3.smethod_35((Control)(object)label1, "QUARTO");
					num = (int)((num2 * 8767304) ^ 0x39C5928D);
					continue;
				case 93u:
					Form3.smethod_44((ContainerControl)(object)this, (AutoScaleMode)1);
					Form3.smethod_26((Control)(object)this, Color.White);
					num = (int)((num2 * 2119360059) ^ 0x6B857306);
					continue;
				case 92u:
					Form3.smethod_34((ButtonBase)(object)button2, bool_0: true);
					Form3.smethod_36((Control)(object)button2, (EventHandler)Button2_Click);
					Form3.smethod_14((Control)(object)button4, bool_0: false);
					num = ((int)num2 * -1269109755) ^ 0x28624620;
					continue;
				case 91u:
					Form3.smethod_33((Control)(object)NullButton, 3);
					num = (int)((num2 * 1249370832) ^ 0x79EDEC04);
					continue;
				case 90u:
					Form3.smethod_31((Control)(object)label1, "label1");
					num = (int)(num2 * 1279082747) ^ -1635662003;
					continue;
				case 89u:
					num = ((int)num2 * -415331360) ^ 0x62D35423;
					continue;
				case 88u:
					num = ((int)num2 * -308466902) ^ -870339592;
					continue;
				case 87u:
					Form3.smethod_40((Control)(object)label1, bool_0: true);
					num = (int)((num2 * 792964275) ^ 0x6CAE0A98);
					continue;
				case 86u:
					num = ((int)num2 * -1249956482) ^ -1247082304;
					continue;
				case 85u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button7);
					num = ((int)num2 * -267174062) ^ -164022689;
					continue;
				case 84u:
					Form3.smethod_35((Control)(object)button5, "Продолжить");
					Form3.smethod_34((ButtonBase)(object)button5, bool_0: true);
					num = (int)(num2 * 754635536) ^ -560606036;
					continue;
				case 83u:
					Form3.smethod_39((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -1273990946) ^ -1458927134;
					continue;
				case 82u:
					Form3.smethod_32((Control)(object)button1, new Size(49, 21));
					num = (int)(num2 * 1132872084) ^ -244899008;
					continue;
				case 81u:
					textBox2 = Form3.smethod_21();
					num = (int)(num2 * 2003647022) ^ -830329152;
					continue;
				case 80u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button5), 0);
					num = (int)((num2 * 1503772476) ^ 0x346169C7);
					continue;
				case 79u:
					Form3.smethod_41(textBox2, bool_0: true);
					num = ((int)num2 * -1045484340) ^ 0x71793273;
					continue;
				case 78u:
					Form3.smethod_31((Control)(object)button1, "button1");
					num = ((int)num2 * -1407470959) ^ -552836413;
					continue;
				case 76u:
					num = (int)((num2 * 1046970931) ^ 0xCCA090D);
					continue;
				case 75u:
					Form3.smethod_36((Control)(object)button7, (EventHandler)Button7_Click);
					num = ((int)num2 * -886346066) ^ 0x78D40FF;
					continue;
				case 74u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -598487965) ^ 0x364A2558;
					continue;
				case 73u:
					Form3.smethod_35((Control)(object)button2, "Регистрация");
					num = ((int)num2 * -912541363) ^ -213412314;
					continue;
				case 72u:
					num = ((int)num2 * -291446466) ^ 0x39D91CFE;
					continue;
				case 71u:
					num = ((int)num2 * -1463867953) ^ -1323932428;
					continue;
				case 69u:
					num = (int)(num2 * 350808195) ^ -1088701997;
					continue;
				case 68u:
					num = (int)(num2 * 1084603748) ^ -606778880;
					continue;
				case 67u:
					Form3.smethod_31((Control)(object)button7, "button7");
					num = (int)(num2 * 48926968) ^ -1527287446;
					continue;
				case 66u:
					Form3.smethod_45((Form)(object)this, new Size(486, 296));
					num = ((int)num2 * -818518382) ^ -854511811;
					continue;
				case 65u:
					Form3.smethod_30((Control)(object)button1, new Point(265, 49));
					num = (int)(num2 * 1239768957) ^ -1843694109;
					continue;
				case 64u:
					Form3.smethod_31((Control)(object)textBox1, "textBox1");
					num = (int)((num2 * 145719730) ^ 0x7B8E232D);
					continue;
				case 63u:
					num = ((int)num2 * -605675153) ^ 0x3362B9E9;
					continue;
				case 62u:
					num = (int)((num2 * 1900294974) ^ 0xF9ACA88);
					continue;
				case 61u:
					Form3.smethod_32((Control)(object)button5, new Size(140, 50));
					num = (int)((num2 * 1768255823) ^ 0x35E0A377);
					continue;
				case 60u:
					textBox1 = Form3.smethod_21();
					num = ((int)num2 * -1440487092) ^ 0x1C196D2F;
					continue;
				case 59u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button5);
					num = (int)((num2 * 666351452) ^ 0x36A3D605);
					continue;
				case 58u:
					Form3.smethod_14((Control)(object)button5, bool_0: false);
					num = (int)(num2 * 2096397506) ^ -319203256;
					continue;
				case 57u:
					num = ((int)num2 * -413891203) ^ -1186054066;
					continue;
				case 56u:
					num = (int)(num2 * 961084516) ^ -1572706894;
					continue;
				case 55u:
					num = (int)(num2 * 1037996820) ^ -1749468586;
					continue;
				case 54u:
					Form3.smethod_50((Form)(object)this, bool_0: false);
					num = ((int)num2 * -537886720) ^ -1792412434;
					continue;
				case 53u:
					Form3.smethod_32((Control)(object)NullButton, new Size(1, 1));
					num = ((int)num2 * -1941242953) ^ 0x2E06D1A7;
					continue;
				case 52u:
					Form3.smethod_38((Control)(object)button5, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form3.smethod_30((Control)(object)button5, new Point(174, 190));
					num = ((int)num2 * -1120618154) ^ -1145743694;
					continue;
				case 51u:
					Form3.smethod_33((Control)(object)button5, 5);
					num = (int)((num2 * 116373432) ^ 0x2BB4EA3);
					continue;
				case 50u:
					Form3.smethod_32((Control)(object)textBox2, new Size(140, 20));
					Form3.smethod_33((Control)(object)textBox2, 8);
					num = ((int)num2 * -1779695611) ^ 0x4517C889;
					continue;
				case 49u:
					Form3.smethod_35((Control)(object)button7, "Достижения");
					num = ((int)num2 * -1514359998) ^ -1273835776;
					continue;
				case 48u:
					label1 = Form3.smethod_22();
					num = ((int)num2 * -571829584) ^ 0x18270772;
					continue;
				case 47u:
					Form3.smethod_30((Control)(object)button2, new Point(174, 49));
					num = ((int)num2 * -1018102828) ^ -1832540131;
					continue;
				case 46u:
					Form3.smethod_55((ISupportInitialize)errorProvider1);
					num = (int)(num2 * 664459321) ^ -211417841;
					continue;
				case 45u:
					Form3.smethod_29((ButtonBase)(object)NullButton, (FlatStyle)0);
					num = ((int)num2 * -448169647) ^ 0x1E8156AE;
					continue;
				case 44u:
					Form3.smethod_43((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)((num2 * 359935590) ^ 0x4DEFB5D6);
					continue;
				case 43u:
					Form3.smethod_36((Control)(object)button5, (EventHandler)Button5_Click);
					num = (int)((num2 * 1533214446) ^ 0x1DF2F3FB);
					continue;
				case 42u:
					Form3.smethod_31((Control)(object)button2, "button2");
					num = ((int)num2 * -1934617366) ^ -970563028;
					continue;
				case 41u:
					Form3.smethod_33((Control)(object)button1, 0);
					num = ((int)num2 * -318595838) ^ 0x7FF6710D;
					continue;
				case 40u:
					num = ((int)num2 * -1205299411) ^ 0x713A9D41;
					continue;
				case 39u:
					Form3.smethod_31((Control)(object)button4, "button4");
					num = ((int)num2 * -308243040) ^ -921517231;
					continue;
				case 38u:
					num = (int)((num2 * 575378221) ^ 0x3384E68D);
					continue;
				case 37u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)NullButton);
					num = ((int)num2 * -879409668) ^ 0x466B8281;
					continue;
				case 36u:
					num = ((int)num2 * -1407462448) ^ 0x3FCBAEA5;
					continue;
				case 35u:
					Form3.smethod_26((Control)(object)NullButton, Color.Transparent);
					num = ((int)num2 * -1236622009) ^ -956665946;
					continue;
				case 34u:
					Form3.smethod_57((Control)(object)this);
					num = ((int)num2 * -886218623) ^ 0x25ACCC40;
					continue;
				case 33u:
					num = (int)(num2 * 1001235072) ^ -1890023750;
					continue;
				case 32u:
					Form3.smethod_53((Form)(object)this, bool_0: false);
					num = ((int)num2 * -63658551) ^ -1729527424;
					continue;
				case 31u:
					NullButton = Form3.smethod_20();
					button1 = Form3.smethod_20();
					button2 = Form3.smethod_20();
					button4 = Form3.smethod_20();
					button5 = Form3.smethod_20();
					num = ((int)num2 * -1356067283) ^ -1743868785;
					continue;
				case 30u:
					Form3.smethod_32((Control)(object)textBox1, new Size(140, 20));
					num = (int)((num2 * 337355446) ^ 0x4F53047F);
					continue;
				case 29u:
					num = ((int)num2 * -1185766045) ^ -1743233533;
					continue;
				case 28u:
					Form3.smethod_30((Control)(object)button7, new Point(174, 243));
					num = (int)(num2 * 1964501294) ^ -1271242892;
					continue;
				case 27u:
					Form3.smethod_32((Control)(object)button2, new Size(85, 21));
					num = (int)(num2 * 1788232495) ^ -1138375845;
					continue;
				case 26u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button4);
					num = (int)(num2 * 1197462486) ^ -52645418;
					continue;
				case 25u:
					Form3.smethod_54((Form)(object)this, bool_0: true);
					num = (int)(num2 * 409832318) ^ -2133679497;
					continue;
				case 24u:
					num = (int)(num2 * 825760111) ^ -1881723142;
					continue;
				case 23u:
					num = (int)((num2 * 2018132120) ^ 0x36CFECD4);
					continue;
				case 22u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button7), 0);
					Form3.smethod_29((ButtonBase)(object)button7, (FlatStyle)0);
					num = ((int)num2 * -2040555965) ^ -2035858481;
					continue;
				case 21u:
					Form3.smethod_31((Control)(object)button5, "button5");
					num = (int)((num2 * 322958445) ^ 0x2254DAB5);
					continue;
				case 20u:
					Form3.smethod_42(errorProvider1, (ContainerControl)(object)this);
					num = (int)((num2 * 944072894) ^ 0x598AEB2C);
					continue;
				case 19u:
					num = ((int)num2 * -331030545) ^ 0x179D31B;
					continue;
				case 18u:
					Form3.smethod_38((Control)(object)button7, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 217381898) ^ -1581704505;
					continue;
				case 17u:
					Form3.smethod_34((ButtonBase)(object)button1, bool_0: true);
					num = (int)(num2 * 1955426324) ^ -1967752253;
					continue;
				case 16u:
					Form3.smethod_38((Control)(object)button4, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form3.smethod_30((Control)(object)button4, new Point(174, 137));
					num = (int)(num2 * 1487456021) ^ -492285809;
					continue;
				case 15u:
					num = ((int)num2 * -1376120648) ^ 0x286A218B;
					continue;
				case 14u:
					num = (int)((num2 * 1288312225) ^ 0x1CCE5B29);
					continue;
				case 13u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button2);
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button1);
					num = (int)(num2 * 1961003810) ^ -449821631;
					continue;
				case 12u:
					Form3.smethod_35((Control)(object)button1, "Вход");
					num = (int)((num2 * 422913980) ^ 0x2AF384EA);
					continue;
				case 11u:
					Form3.smethod_30((Control)(object)textBox1, new Point(174, 2));
					num = ((int)num2 * -1284723701) ^ -679792866;
					continue;
				case 10u:
					num = (int)(num2 * 1203079421) ^ -818619338;
					continue;
				case 9u:
					num = ((int)num2 * -135952626) ^ -699494273;
					continue;
				case 8u:
					Form3.smethod_33((Control)(object)textBox1, 7);
					num = ((int)num2 * -920359044) ^ -1342659789;
					continue;
				case 7u:
					num = ((int)num2 * -2073262381) ^ -1497267025;
					continue;
				case 6u:
					num = (int)((num2 * 1124287825) ^ 0x7C67625B);
					continue;
				case 5u:
					Form3.smethod_33((Control)(object)button2, 1);
					num = (int)((num2 * 1782010753) ^ 0x77D481F3);
					continue;
				case 4u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)NullButton), 0);
					num = (int)((num2 * 2118532818) ^ 0x4D84F227);
					continue;
				case 3u:
					Form3.smethod_31((Control)(object)textBox2, "textBox2");
					num = ((int)num2 * -1390814987) ^ -1099774214;
					continue;
				case 2u:
					Form3.smethod_56((Control)(object)this, bool_0: false);
					num = ((int)num2 * -1288800286) ^ -507694971;
					continue;
				case 1u:
					errorProvider1 = Form3.smethod_23(components);
					Form3.smethod_24((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -2032718431) ^ -172753159;
					continue;
				case 0u:
					Form3.smethod_31((Control)(object)NullButton, "NullButton");
					num = ((int)num2 * -1281187371) ^ -2014260262;
					continue;
				default:
					return;
				case 70u:
					break;
				case 77u:
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
