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
			int num = -1098492830;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x95341F38u) % 7u)
				{
				case 6u:
					Form3.smethod_10(val, new Point(Form3.smethod_5((Form)(object)this).X + (Form3.smethod_6((Control)(object)this) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_5((Form)(object)this).Y + (Form3.smethod_8((Control)(object)this) - Form3.smethod_9((Control)(object)val)) / 2 + 70));
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = ((int)num2 * -1784743263) ^ 0x250708F2;
					continue;
				case 5u:
					Form3.smethod_0((Control)(object)NullButton);
					num = (int)((num2 * 786587627) ^ 0x29BC0CAD);
					continue;
				case 4u:
					Form3.smethod_4((Control)(object)val);
					num = ((int)num2 * -951045123) ^ 0x209FB077;
					continue;
				case 3u:
				{
					Form3.smethod_1(errorProvider1);
					Form4 form = new Form4();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					num = (int)(num2 * 229551732) ^ -259961278;
					continue;
				}
				case 1u:
					num = (int)(num2 * 996704491) ^ -811966216;
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

	private void Button4_Click(object sender, EventArgs e)
	{
		Form3.smethod_0((Control)(object)NullButton);
		while (true)
		{
			int num = 1419263833;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDE56CECu) % 5u)
				{
				case 4u:
					num = ((int)num2 * -917185016) ^ 0x746DFE5F;
					continue;
				case 3u:
				{
					Form2 form = new Form2();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					Form val = (Form)(object)form;
					Form3.smethod_4((Control)(object)val);
					Form3.smethod_10(val, new Point(Form3.smethod_13(Form3.smethod_12((Form)(object)this)).X + (Form3.smethod_7((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_13(Form3.smethod_12((Form)(object)this)).Y + (Form3.smethod_9((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_9((Control)(object)val)) / 2));
					num = (int)(num2 * 1940997347) ^ -1455867122;
					continue;
				}
				case 1u:
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = ((int)num2 * -361322580) ^ 0x210FDBC;
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

	public void Button_Continue()
	{
		Form3.smethod_14((Control)(object)button5, bool_0: true);
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		int num5 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 1872802597;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4CC79408u) % 9u)
				{
				case 8u:
					num5 = Form3.smethod_8((Control)(object)this) - 1;
					Form3.smethod_15((Control)(object)this, num5);
					num = 1561632484;
					continue;
				case 7u:
					num = 248371921;
					continue;
				case 6u:
					flag = num5 > 1;
					num = ((int)num2 * -510410369) ^ -1425191778;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -919699769;
						num4 = -919699769;
					}
					else
					{
						num3 = -262245721;
						num4 = -262245721;
					}
					num = num3 ^ (int)(num2 * 2075957809);
					continue;
				}
				case 4u:
					Form3.smethod_16(Form3.smethod_12((Form)(object)this));
					num = ((int)num2 * -115561708) ^ -1935166630;
					continue;
				case 3u:
					num = (int)((num2 * 1541904027) ^ 0x37C9CCEE);
					continue;
				case 1u:
					Form3.smethod_17((Form3.smethod_12((Form)(object)this) as Form1).timer1);
					num = ((int)num2 * -904301191) ^ 0x267CA822;
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
		Form3.smethod_0((Control)(object)NullButton);
		while (true)
		{
			int num = -875652497;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA9F8AB8Cu) % 4u)
				{
				case 3u:
					Form3.smethod_14((Control)(object)button7, bool_0: false);
					num = (int)((num2 * 1484617829) ^ 0x55F9D015);
					continue;
				case 2u:
					num = ((int)num2 * -1797744728) ^ 0xD5C8CF9;
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

	protected override void Dispose(bool disposing)
	{
		while (true)
		{
			int num = -1714913727;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xEB11420Eu) % 9u)
				{
				case 8u:
					if (disposing)
					{
						num = (int)(num2 * 653819562) ^ -754104456;
						continue;
					}
					goto IL_0027;
				case 7u:
					num = (int)((num2 * 50116236) ^ 0x7BD987B3);
					continue;
				case 6u:
					((Form)this).Dispose(disposing);
					num = -1614497563;
					continue;
				case 5u:
					Form3.smethod_18((IDisposable)components);
					num = (int)((num2 * 1999676578) ^ 0x394D930A);
					continue;
				case 4u:
					if (components != null)
					{
						num = -1404881492;
						num3 = -1404881492;
						continue;
					}
					goto IL_0027;
				case 2u:
					num = ((int)num2 * -1831749982) ^ 0x28C6F597;
					continue;
				case 1u:
					num = (int)((num2 * 933192391) ^ 0x44398964);
					continue;
				default:
					return;
				case 0u:
					break;
				case 3u:
					return;
					IL_0027:
					num = -861477493;
					num3 = -861477493;
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
			int num = -2041308744;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x990B29F2u) % 126u)
				{
				case 125u:
					num = ((int)num2 * -707240540) ^ -56787281;
					continue;
				case 124u:
					Form3.smethod_40((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -128676685) ^ 0xE35F1B6;
					continue;
				case 123u:
					Form3.smethod_14((Control)(object)button4, bool_0: false);
					num = ((int)num2 * -1763566654) ^ 0x6DA48F8A;
					continue;
				case 122u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox1);
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button7);
					num = ((int)num2 * -1942699740) ^ -693347678;
					continue;
				case 121u:
					Form3.smethod_54((Form)(object)this, bool_0: true);
					num = (int)(num2 * 871437339) ^ -2142641147;
					continue;
				case 120u:
					num = (int)(num2 * 370618046) ^ -78924023;
					continue;
				case 119u:
					num = (int)((num2 * 1012358451) ^ 0x74ACFC81);
					continue;
				case 118u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button4), 0);
					num = (int)((num2 * 97939691) ^ 0x63710D41);
					continue;
				case 117u:
					Form3.smethod_30((Control)(object)textBox1, new Point(174, 2));
					num = (int)((num2 * 2105268724) ^ 0x9C1E5EF);
					continue;
				case 116u:
					components = Form3.smethod_19();
					NullButton = Form3.smethod_20();
					button1 = Form3.smethod_20();
					num = (int)(num2 * 1048264305) ^ -77377609;
					continue;
				case 115u:
					Form3.smethod_34((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -377825052) ^ -1096081559;
					continue;
				case 114u:
					num = ((int)num2 * -681112379) ^ -1529747899;
					continue;
				case 113u:
					Form3.smethod_35((Control)(object)button4, "Начало игры");
					num = ((int)num2 * -95226244) ^ -537653478;
					continue;
				case 112u:
					Form3.smethod_33((Control)(object)button2, 1);
					Form3.smethod_35((Control)(object)button2, "Регистрация");
					num = (int)(num2 * 122738448) ^ -1411562643;
					continue;
				case 111u:
					num = (int)((num2 * 176254984) ^ 0x23681B1);
					continue;
				case 110u:
					Form3.smethod_30((Control)(object)NullButton, new Point(-1, -1));
					num = ((int)num2 * -118721515) ^ 0x68DE412E;
					continue;
				case 108u:
					num = ((int)num2 * -400557908) ^ 0x7EFFB21E;
					continue;
				case 107u:
					num = (int)((num2 * 484472977) ^ 0x7D0CF904);
					continue;
				case 106u:
					errorProvider1 = Form3.smethod_23(components);
					Form3.smethod_24((ISupportInitialize)errorProvider1);
					num = (int)((num2 * 418292439) ^ 0xDDE44E7);
					continue;
				case 105u:
					Form3.smethod_48((Form)(object)this, (FormBorderStyle)0);
					num = ((int)num2 * -1458215346) ^ 0x1062B8AD;
					continue;
				case 104u:
					num = ((int)num2 * -134760884) ^ 0x666EB073;
					continue;
				case 103u:
					Form3.smethod_32((Control)(object)button7, new Size(140, 50));
					num = ((int)num2 * -1341094575) ^ -1998462744;
					continue;
				case 102u:
					Form3.smethod_26((Control)(object)this, Color.White);
					num = ((int)num2 * -952075531) ^ 0xB98933B;
					continue;
				case 101u:
					num = (int)(num2 * 97726436) ^ -577386098;
					continue;
				case 100u:
					num = (int)(num2 * 1004855660) ^ -1486985631;
					continue;
				case 99u:
					Form3.smethod_30((Control)(object)button4, new Point(174, 137));
					num = (int)((num2 * 816729621) ^ 0x48271916);
					continue;
				case 98u:
					Form3.smethod_29((ButtonBase)(object)button7, (FlatStyle)0);
					num = (int)(num2 * 382014522) ^ -179234518;
					continue;
				case 97u:
					Form3.smethod_33((Control)(object)button7, 6);
					Form3.smethod_35((Control)(object)button7, "Достижения");
					Form3.smethod_34((ButtonBase)(object)button7, bool_0: true);
					Form3.smethod_36((Control)(object)button7, (EventHandler)Button7_Click);
					num = (int)((num2 * 566452232) ^ 0x3EEBF11F);
					continue;
				case 96u:
					Form3.smethod_32((Control)(object)textBox2, new Size(140, 20));
					num = (int)((num2 * 1420207416) ^ 0x41DD2693);
					continue;
				case 95u:
					num = (int)(num2 * 596558030) ^ -502518475;
					continue;
				case 94u:
					num = (int)((num2 * 1174232203) ^ 0x1F536A93);
					continue;
				case 93u:
					Form3.smethod_32((Control)(object)button5, new Size(140, 50));
					num = (int)(num2 * 1803099707) ^ -400981321;
					continue;
				case 92u:
					num = (int)((num2 * 422659933) ^ 0x3D09074);
					continue;
				case 91u:
					Form3.smethod_31((Control)(object)button7, "button7");
					num = (int)((num2 * 1148811722) ^ 0x577970B7);
					continue;
				case 90u:
					num = (int)((num2 * 214436848) ^ 0x5AE06539);
					continue;
				case 89u:
					Form3.smethod_34((ButtonBase)(object)button2, bool_0: true);
					num = (int)((num2 * 1702533384) ^ 0x735AA7A9);
					continue;
				case 88u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)NullButton);
					num = (int)(num2 * 774434832) ^ -344031733;
					continue;
				case 87u:
					Form3.smethod_31((Control)(object)button5, "button5");
					num = (int)((num2 * 1850477754) ^ 0x1C9570F7);
					continue;
				case 86u:
					Form3.smethod_53((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1363495301) ^ -1661897639;
					continue;
				case 85u:
					Form3.smethod_41(textBox2, bool_0: true);
					num = ((int)num2 * -1489267919) ^ -944230362;
					continue;
				case 84u:
					Form3.smethod_44((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 1320175477) ^ 0x78CD0502);
					continue;
				case 83u:
					num = (int)((num2 * 595340217) ^ 0x232B46E7);
					continue;
				case 82u:
					Form3.smethod_31((Control)(object)label1, "label1");
					Form3.smethod_32((Control)(object)label1, new Size(207, 76));
					num = (int)(num2 * 507784994) ^ -655290569;
					continue;
				case 81u:
					Form3.smethod_36((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)((num2 * 1661576769) ^ 0x3CBC219B);
					continue;
				case 80u:
					Form3.smethod_33((Control)(object)button1, 0);
					num = ((int)num2 * -1473404317) ^ 0x63C127EA;
					continue;
				case 79u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button5), 0);
					num = (int)(num2 * 1475158082) ^ -1656426026;
					continue;
				case 78u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button4);
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button2);
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button1);
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -799699584) ^ -977913867;
					continue;
				case 77u:
					num = (int)(num2 * 353090036) ^ -2007491663;
					continue;
				case 76u:
					Form3.smethod_25((Control)(object)this);
					num = ((int)num2 * -2012290528) ^ -461467729;
					continue;
				case 75u:
					Form3.smethod_36((Control)(object)button2, (EventHandler)Button2_Click);
					num = ((int)num2 * -1136684048) ^ 0x4525E771;
					continue;
				case 74u:
					Form3.smethod_45((Form)(object)this, new Size(486, 296));
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox2);
					num = (int)(num2 * 785730218) ^ -119214435;
					continue;
				case 73u:
					Form3.smethod_32((Control)(object)button4, new Size(140, 50));
					Form3.smethod_33((Control)(object)button4, 4);
					num = ((int)num2 * -1239399030) ^ -1359766167;
					continue;
				case 72u:
					Form3.smethod_39((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = (int)((num2 * 1727869876) ^ 0x2BE1CE8E);
					continue;
				case 71u:
					num = ((int)num2 * -2091742219) ^ 0x12102B41;
					continue;
				case 70u:
					Form3.smethod_30((Control)(object)button7, new Point(174, 243));
					num = ((int)num2 * -1174916499) ^ -1435955471;
					continue;
				case 69u:
					num = (int)((num2 * 673999934) ^ 0x4D3F8433);
					continue;
				case 68u:
					num = ((int)num2 * -413714775) ^ -1787750492;
					continue;
				case 67u:
					Form3.smethod_30((Control)(object)textBox2, new Point(174, 26));
					Form3.smethod_31((Control)(object)textBox2, "textBox2");
					num = (int)((num2 * 1217264309) ^ 0xD06BD5F);
					continue;
				case 66u:
					Form3.smethod_50((Form)(object)this, bool_0: false);
					Form3.smethod_51((Control)(object)this, "Form3");
					num = (int)((num2 * 134763452) ^ 0x3192636E);
					continue;
				case 65u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)NullButton), 0);
					num = ((int)num2 * -822163889) ^ 0x2D42A1FB;
					continue;
				case 64u:
					num = (int)(num2 * 614438020) ^ -956259768;
					continue;
				case 63u:
					num = ((int)num2 * -1042146780) ^ 0x55E7E4F4;
					continue;
				case 62u:
					num = ((int)num2 * -984886276) ^ -1905415668;
					continue;
				case 61u:
					Form3.smethod_26((Control)(object)NullButton, Color.Transparent);
					num = ((int)num2 * -1987948779) ^ -106445800;
					continue;
				case 60u:
					num = ((int)num2 * -1906101307) ^ 0x590F0A9D;
					continue;
				case 59u:
					Form3.smethod_38((Control)(object)label1, Form3.smethod_37("Mistral", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -865254399) ^ 0x4D876C05;
					continue;
				case 58u:
					Form3.smethod_31((Control)(object)NullButton, "NullButton");
					num = (int)((num2 * 140189149) ^ 0x4C386DB8);
					continue;
				case 57u:
					Form3.smethod_57((Control)(object)this);
					num = (int)(num2 * 1721242364) ^ -1095869630;
					continue;
				case 56u:
					Form3.smethod_32((Control)(object)button1, new Size(49, 21));
					num = (int)(num2 * 1190966342) ^ -642775138;
					continue;
				case 55u:
					Form3.smethod_31((Control)(object)button2, "button2");
					num = ((int)num2 * -309882393) ^ 0x384D021D;
					continue;
				case 54u:
					Form3.smethod_39((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = (int)(num2 * 1085657798) ^ -1254400838;
					continue;
				case 53u:
					num = ((int)num2 * -1427863330) ^ -1632164828;
					continue;
				case 52u:
					Form3.smethod_35((Control)(object)button1, "Вход");
					num = (int)((num2 * 1622386776) ^ 0x1AF2AC51);
					continue;
				case 51u:
					Form3.smethod_33((Control)(object)textBox2, 8);
					num = (int)((num2 * 541897461) ^ 0x27AC4439);
					continue;
				case 50u:
					Form3.smethod_29((ButtonBase)(object)button5, (FlatStyle)0);
					num = (int)(num2 * 1442935027) ^ -1276089856;
					continue;
				case 49u:
					Form3.smethod_30((Control)(object)button1, new Point(265, 49));
					Form3.smethod_31((Control)(object)button1, "button1");
					num = (int)(num2 * 2087171802) ^ -93069746;
					continue;
				case 48u:
					num = ((int)num2 * -810414305) ^ 0x1DB262C9;
					continue;
				case 47u:
					Form3.smethod_33((Control)(object)textBox1, 7);
					num = (int)(num2 * 559079796) ^ -1131830447;
					continue;
				case 46u:
					Form3.smethod_33((Control)(object)button5, 5);
					Form3.smethod_35((Control)(object)button5, "Продолжить");
					Form3.smethod_34((ButtonBase)(object)button5, bool_0: true);
					num = ((int)num2 * -1223439981) ^ 0x16FD5802;
					continue;
				case 45u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button5);
					num = ((int)num2 * -477150749) ^ 0x3BD7D8E1;
					continue;
				case 44u:
					Form3.smethod_34((ButtonBase)(object)button4, bool_0: true);
					num = (int)(num2 * 296441075) ^ -1759020666;
					continue;
				case 43u:
					num = ((int)num2 * -910902072) ^ 0x5939DF3F;
					continue;
				case 42u:
					Form3.smethod_55((ISupportInitialize)errorProvider1);
					num = (int)(num2 * 613782298) ^ -1112994431;
					continue;
				case 41u:
					Form3.smethod_29((ButtonBase)(object)button4, (FlatStyle)0);
					Form3.smethod_38((Control)(object)button4, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 848367123) ^ 0x5F5AE7ED);
					continue;
				case 40u:
					num = (int)((num2 * 1688705097) ^ 0x27A52BE9);
					continue;
				case 39u:
					Form3.smethod_31((Control)(object)button4, "button4");
					num = (int)((num2 * 1979139410) ^ 0x78036521);
					continue;
				case 38u:
					num = (int)((num2 * 1845815283) ^ 0x3660CAEB);
					continue;
				case 37u:
					Form3.smethod_32((Control)(object)NullButton, new Size(1, 1));
					Form3.smethod_33((Control)(object)NullButton, 3);
					num = ((int)num2 * -1143060836) ^ 0x7F3D77DE;
					continue;
				case 36u:
					num = (int)(num2 * 1309834767) ^ -1599619092;
					continue;
				case 34u:
					Form3.smethod_36((Control)(object)button5, (EventHandler)Button5_Click);
					num = ((int)num2 * -958977626) ^ 0x4AFE081B;
					continue;
				case 33u:
					Form3.smethod_33((Control)(object)label1, 7);
					num = ((int)num2 * -2135876319) ^ 0x31F9AF53;
					continue;
				case 32u:
					Form3.smethod_29((ButtonBase)(object)NullButton, (FlatStyle)0);
					num = ((int)num2 * -2136175138) ^ -515278714;
					continue;
				case 31u:
					num = ((int)num2 * -680581343) ^ -1402051397;
					continue;
				case 30u:
					Form3.smethod_32((Control)(object)button2, new Size(85, 21));
					num = (int)((num2 * 112109835) ^ 0x183988D4);
					continue;
				case 29u:
					num = ((int)num2 * -829561748) ^ -1525779392;
					continue;
				case 28u:
					Form3.smethod_34((ButtonBase)(object)NullButton, bool_0: false);
					num = (int)(num2 * 1613306298) ^ -1460244644;
					continue;
				case 27u:
					label1 = Form3.smethod_22();
					textBox2 = Form3.smethod_21();
					num = (int)(num2 * 2103875926) ^ -885642118;
					continue;
				case 26u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button7), 0);
					num = (int)((num2 * 1687392629) ^ 0x58CA7687);
					continue;
				case 25u:
					button5 = Form3.smethod_20();
					num = ((int)num2 * -1536046521) ^ 0x46161A76;
					continue;
				case 24u:
					num = (int)(num2 * 2025266066) ^ -2015122301;
					continue;
				case 23u:
					num = ((int)num2 * -415028325) ^ 0x1471DE7E;
					continue;
				case 22u:
					Form3.smethod_30((Control)(object)button2, new Point(174, 49));
					num = ((int)num2 * -968279459) ^ 0xAC22696;
					continue;
				case 21u:
					button7 = Form3.smethod_20();
					textBox1 = Form3.smethod_21();
					num = (int)((num2 * 2357635) ^ 0x69F7A30);
					continue;
				case 20u:
					Form3.smethod_36((Control)(object)button4, (EventHandler)Button4_Click);
					num = (int)((num2 * 1950763151) ^ 0x7E92A38E);
					continue;
				case 19u:
					Form3.smethod_42(errorProvider1, (ContainerControl)(object)this);
					Form3.smethod_43((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)(num2 * 1571906072) ^ -1660656568;
					continue;
				case 18u:
					Form3.smethod_52((Form)(object)this, bool_0: false);
					num = (int)((num2 * 78185093) ^ 0x42C8791C);
					continue;
				case 17u:
					button2 = Form3.smethod_20();
					button4 = Form3.smethod_20();
					num = ((int)num2 * -958202821) ^ 0x68ADB28A;
					continue;
				case 16u:
					num = ((int)num2 * -1198836535) ^ -1696835627;
					continue;
				case 15u:
					Form3.smethod_56((Control)(object)this, bool_0: false);
					num = (int)((num2 * 113041505) ^ 0x4AF608AE);
					continue;
				case 14u:
					Form3.smethod_30((Control)(object)button5, new Point(174, 190));
					num = (int)(num2 * 438119949) ^ -1710921046;
					continue;
				case 13u:
					Form3.smethod_38((Control)(object)button7, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 959448386) ^ 0x271D090A);
					continue;
				case 12u:
					Form3.smethod_49((Form)(object)this, bool_0: false);
					num = ((int)num2 * -319621338) ^ 0x344809FC;
					continue;
				case 11u:
					Form3.smethod_31((Control)(object)textBox1, "textBox1");
					num = ((int)num2 * -868166049) ^ -1767238152;
					continue;
				case 10u:
					Form3.smethod_32((Control)(object)textBox1, new Size(140, 20));
					num = (int)((num2 * 151755497) ^ 0x20AB3103);
					continue;
				case 9u:
					Form3.smethod_35((Control)(object)label1, "QUARTO");
					num = (int)(num2 * 1253290791) ^ -1414951319;
					continue;
				case 8u:
					Form3.smethod_38((Control)(object)button5, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 1088941322) ^ -411620638;
					continue;
				case 7u:
					num = (int)(num2 * 1294600717) ^ -387006611;
					continue;
				case 6u:
					num = ((int)num2 * -814713218) ^ 0x2971B695;
					continue;
				case 5u:
					Form3.smethod_30((Control)(object)label1, new Point(140, 70));
					num = (int)(num2 * 2006416715) ^ -454790797;
					continue;
				case 4u:
					Form3.smethod_26((Control)(object)label1, Color.Transparent);
					num = (int)((num2 * 1400384902) ^ 0x44757445);
					continue;
				case 3u:
					num = ((int)num2 * -2054400748) ^ -495039573;
					continue;
				case 2u:
					Form3.smethod_14((Control)(object)button5, bool_0: false);
					num = (int)(num2 * 69767694) ^ -164841943;
					continue;
				case 1u:
					num = ((int)num2 * -291029341) ^ -1973856539;
					continue;
				case 0u:
					num = ((int)num2 * -1492770002) ^ 0x45741A7E;
					continue;
				default:
					return;
				case 109u:
					break;
				case 35u:
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
