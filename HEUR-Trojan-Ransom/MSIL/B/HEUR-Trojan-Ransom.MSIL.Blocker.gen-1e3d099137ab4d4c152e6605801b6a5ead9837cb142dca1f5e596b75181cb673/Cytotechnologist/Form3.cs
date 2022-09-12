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
		Form3.smethod_0((Control)(object)NullButton);
		Form val = default(Form);
		while (true)
		{
			int num = -653476069;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD775A945u) % 6u)
				{
				case 3u:
					Form3.smethod_10(val, new Point(Form3.smethod_5((Form)(object)this).X + (Form3.smethod_6((Control)(object)this) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_5((Form)(object)this).Y + (Form3.smethod_8((Control)(object)this) - Form3.smethod_9((Control)(object)val)) / 2 + 70));
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = (int)(num2 * 2095020756) ^ -280872658;
					continue;
				case 2u:
					Form3.smethod_1(errorProvider1);
					num = (int)(num2 * 431556060) ^ -1128565576;
					continue;
				case 1u:
				{
					Form4 form = new Form4();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					Form3.smethod_4((Control)(object)val);
					num = ((int)num2 * -435308519) ^ 0x12F8A064;
					continue;
				}
				case 0u:
					num = ((int)num2 * -387373524) ^ -618318594;
					continue;
				default:
					return;
				case 4u:
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
		Form val = default(Form);
		while (true)
		{
			int num = -1990826445;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA2AC84ACu) % 8u)
				{
				case 7u:
					Form3.smethod_0((Control)(object)NullButton);
					num = (int)(num2 * 1262797669) ^ -1368089810;
					continue;
				case 6u:
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = (int)(num2 * 52455405) ^ -1426780903;
					continue;
				case 5u:
					num = ((int)num2 * -895481426) ^ -699010632;
					continue;
				case 4u:
					Form3.smethod_4((Control)(object)val);
					num = ((int)num2 * -959033926) ^ -2051057047;
					continue;
				case 2u:
					Form3.smethod_10(val, new Point(Form3.smethod_13(Form3.smethod_12((Form)(object)this)).X + (Form3.smethod_7((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_13(Form3.smethod_12((Form)(object)this)).Y + (Form3.smethod_9((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_9((Control)(object)val)) / 2));
					num = ((int)num2 * -1926264119) ^ -1501332096;
					continue;
				case 1u:
				{
					Form2 form = new Form2();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					num = (int)(num2 * 271029554) ^ -561486310;
					continue;
				}
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

	public void Button_Continue()
	{
		Form3.smethod_14((Control)(object)button5, bool_0: true);
		while (true)
		{
			int num = -1049068295;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF019E5AAu) % 3u)
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
				num = ((int)num2 * -900586530) ^ 0x5257A122;
			}
		}
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		bool flag = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = -482823764;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB2365C68u) % 11u)
				{
				case 10u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -38825788;
						num5 = -38825788;
					}
					else
					{
						num4 = -985775743;
						num5 = -985775743;
					}
					num = num4 ^ (int)(num2 * 1489710296);
					continue;
				}
				case 9u:
					Form3.smethod_16(Form3.smethod_12((Form)(object)this));
					num = (int)(num2 * 1623251231) ^ -247826212;
					continue;
				case 8u:
					num = ((int)num2 * -1280279117) ^ -1464301751;
					continue;
				case 7u:
					Form3.smethod_15((Control)(object)this, num3);
					num = ((int)num2 * -1473084864) ^ -700000900;
					continue;
				case 6u:
					num3 = Form3.smethod_8((Control)(object)this) - 1;
					num = -1888499456;
					continue;
				case 5u:
					num = -755993787;
					continue;
				case 2u:
					Form3.smethod_17((Form3.smethod_12((Form)(object)this) as Form1).timer1);
					num = ((int)num2 * -751907442) ^ -1273697490;
					continue;
				case 1u:
					flag = num3 > 1;
					num = ((int)num2 * -1570709468) ^ -116573646;
					continue;
				case 0u:
					num = (int)((num2 * 1607930759) ^ 0x6DD05744);
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
			int num = 975825901;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3261BE34u) % 3u)
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
				num = ((int)num2 * -1016854337) ^ 0x699B6795;
			}
		}
	}

	private void Button7_Click(object sender, EventArgs e)
	{
		Form3.smethod_0((Control)(object)NullButton);
		while (true)
		{
			int num = 234297520;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x796FD15Eu) % 4u)
				{
				case 2u:
					Form3.smethod_14((Control)(object)button7, bool_0: false);
					num = ((int)num2 * -1047409617) ^ -2040521175;
					continue;
				case 1u:
					num = (int)(num2 * 973845396) ^ -1874105994;
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
		if (!disposing)
		{
			goto IL_0009;
		}
		goto IL_004d;
		IL_004d:
		int num = -1367911999;
		goto IL_007f;
		IL_007f:
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x9AEA97F9u) % 9u)
			{
			case 8u:
				Form3.smethod_18((IDisposable)components);
				num = (int)((num2 * 187732323) ^ 0x7E0D951F);
				continue;
			case 7u:
				num = (int)((num2 * 1455196915) ^ 0xB8E0FC9);
				continue;
			case 6u:
				((Form)this).Dispose(disposing);
				num = -1409617980;
				continue;
			case 5u:
				break;
			case 4u:
				num = ((int)num2 * -551626802) ^ 0xA511326;
				continue;
			case 2u:
				num = (int)((num2 * 497168142) ^ 0x18476D2A);
				continue;
			case 0u:
				num = (int)(num2 * 1575110705) ^ -591959059;
				continue;
			default:
				return;
			case 1u:
				goto IL_00b5;
			case 3u:
				return;
			}
			break;
			IL_00b5:
			if (components != null)
			{
				num = -1586463073;
				num3 = -1586463073;
				continue;
			}
			goto IL_0009;
		}
		goto IL_004d;
		IL_0009:
		num = -894312026;
		num3 = -894312026;
		goto IL_007f;
	}

	private void InitializeComponent()
	{
		while (true)
		{
			int num = -88594643;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA91E955Cu) % 142u)
				{
				case 141u:
					Form3.smethod_26((Control)(object)NullButton, Color.Transparent);
					num = (int)((num2 * 1588122082) ^ 0x73568980);
					continue;
				case 140u:
					Form3.smethod_42(errorProvider1, (ContainerControl)(object)this);
					Form3.smethod_43((ContainerControl)(object)this, new SizeF(6f, 13f));
					Form3.smethod_44((ContainerControl)(object)this, (AutoScaleMode)1);
					Form3.smethod_26((Control)(object)this, Color.White);
					num = ((int)num2 * -2067788885) ^ 0x7E347972;
					continue;
				case 139u:
					Form3.smethod_38((Control)(object)label1, Form3.smethod_37("Mistral", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -850390981) ^ -1702310667;
					continue;
				case 138u:
					Form3.smethod_32((Control)(object)button1, new Size(49, 21));
					num = ((int)num2 * -775357962) ^ -948248079;
					continue;
				case 137u:
					num = ((int)num2 * -249988708) ^ -1286160435;
					continue;
				case 136u:
					Form3.smethod_49((Form)(object)this, bool_0: false);
					Form3.smethod_50((Form)(object)this, bool_0: false);
					num = (int)((num2 * 372290587) ^ 0x4020A44E);
					continue;
				case 135u:
					Form3.smethod_33((Control)(object)button2, 1);
					num = (int)(num2 * 189319114) ^ -437568060;
					continue;
				case 134u:
					Form3.smethod_29((ButtonBase)(object)button7, (FlatStyle)0);
					Form3.smethod_38((Control)(object)button7, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 1384821536) ^ -378402158;
					continue;
				case 133u:
					num = (int)((num2 * 1337353662) ^ 0x1AA04640);
					continue;
				case 132u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)label1);
					num = (int)(num2 * 678465166) ^ -1183073548;
					continue;
				case 131u:
					Form3.smethod_35((Control)(object)label1, "QUARTO");
					num = (int)(num2 * 1500038493) ^ -1456698802;
					continue;
				case 130u:
					Form3.smethod_34((ButtonBase)(object)button4, bool_0: true);
					num = (int)((num2 * 300219107) ^ 0x34D27BE2);
					continue;
				case 129u:
					Form3.smethod_31((Control)(object)button1, "button1");
					num = (int)(num2 * 2052642877) ^ -1060912117;
					continue;
				case 128u:
					Form3.smethod_33((Control)(object)button5, 5);
					num = ((int)num2 * -945904390) ^ -1533228778;
					continue;
				case 127u:
					num = (int)(num2 * 1227835587) ^ -836905896;
					continue;
				case 126u:
					num = ((int)num2 * -1199081917) ^ 0x35118342;
					continue;
				case 125u:
					Form3.smethod_30((Control)(object)button2, new Point(174, 49));
					Form3.smethod_31((Control)(object)button2, "button2");
					num = ((int)num2 * -1528671782) ^ -1102999182;
					continue;
				case 124u:
					Form3.smethod_32((Control)(object)textBox1, new Size(140, 20));
					Form3.smethod_33((Control)(object)textBox1, 7);
					num = (int)(num2 * 1781815335) ^ -502033487;
					continue;
				case 123u:
					num = (int)((num2 * 1048861703) ^ 0x79B6D2A5);
					continue;
				case 122u:
					num = ((int)num2 * -338296151) ^ 0x5ABBA079;
					continue;
				case 121u:
					Form3.smethod_34((ButtonBase)(object)button5, bool_0: true);
					num = ((int)num2 * -207157613) ^ -2138513029;
					continue;
				case 120u:
					num = (int)((num2 * 1121085109) ^ 0x5F654D3D);
					continue;
				case 119u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button2);
					num = ((int)num2 * -1381862219) ^ 0x546AC01A;
					continue;
				case 118u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)NullButton), 0);
					num = ((int)num2 * -456873630) ^ 0x4D3F84DB;
					continue;
				case 117u:
					num = ((int)num2 * -1808899904) ^ -1940455168;
					continue;
				case 116u:
					num = (int)(num2 * 1479840986) ^ -1920838212;
					continue;
				case 115u:
					num = ((int)num2 * -1438387814) ^ -951270871;
					continue;
				case 114u:
					Form3.smethod_51((Control)(object)this, "Form3");
					num = ((int)num2 * -543986704) ^ 0x68844994;
					continue;
				case 113u:
					num = (int)(num2 * 1177043623) ^ -1651200570;
					continue;
				case 112u:
					num = ((int)num2 * -1412632284) ^ -973583393;
					continue;
				case 111u:
					button4 = Form3.smethod_20();
					button5 = Form3.smethod_20();
					num = (int)((num2 * 2140109826) ^ 0xE38713A);
					continue;
				case 110u:
					Form3.smethod_31((Control)(object)button5, "button5");
					num = ((int)num2 * -732046829) ^ 0x4DF3E07F;
					continue;
				case 109u:
					num = (int)(num2 * 543086611) ^ -1562255514;
					continue;
				case 108u:
					num = ((int)num2 * -315966957) ^ -481023015;
					continue;
				case 107u:
					num = (int)((num2 * 601394826) ^ 0x248810CB);
					continue;
				case 106u:
					Form3.smethod_32((Control)(object)button5, new Size(140, 50));
					num = (int)(num2 * 853858212) ^ -633739820;
					continue;
				case 105u:
					Form3.smethod_48((Form)(object)this, (FormBorderStyle)0);
					num = (int)((num2 * 1532420635) ^ 0x7344DD29);
					continue;
				case 104u:
					Form3.smethod_34((ButtonBase)(object)button7, bool_0: true);
					num = ((int)num2 * -40587432) ^ 0x6135ACB7;
					continue;
				case 103u:
					num = (int)((num2 * 1784420650) ^ 0x5D2B0FEB);
					continue;
				case 102u:
					Form3.smethod_33((Control)(object)NullButton, 3);
					num = ((int)num2 * -1304010345) ^ -1757041839;
					continue;
				case 101u:
					Form3.smethod_31((Control)(object)NullButton, "NullButton");
					num = (int)((num2 * 956185371) ^ 0x29EC8385);
					continue;
				case 100u:
					Form3.smethod_36((Control)(object)button2, (EventHandler)Button2_Click);
					Form3.smethod_14((Control)(object)button4, bool_0: false);
					num = ((int)num2 * -1529098967) ^ -1534777283;
					continue;
				case 99u:
					num = (int)((num2 * 1257559439) ^ 0x5DF94641);
					continue;
				case 98u:
					Form3.smethod_29((ButtonBase)(object)NullButton, (FlatStyle)0);
					Form3.smethod_30((Control)(object)NullButton, new Point(-1, -1));
					num = (int)(num2 * 866885861) ^ -885869895;
					continue;
				case 97u:
					num = (int)(num2 * 111423685) ^ -1929368766;
					continue;
				case 96u:
					num = ((int)num2 * -1427623741) ^ 0x1B91F25A;
					continue;
				case 95u:
					Form3.smethod_33((Control)(object)textBox2, 8);
					num = (int)(num2 * 2097781221) ^ -2043231849;
					continue;
				case 94u:
					Form3.smethod_14((Control)(object)button5, bool_0: false);
					num = ((int)num2 * -579049931) ^ -254182284;
					continue;
				case 93u:
					num = (int)((num2 * 2017528693) ^ 0x5D6FE3CD);
					continue;
				case 92u:
					Form3.smethod_57((Control)(object)this);
					num = ((int)num2 * -958091554) ^ -2141720055;
					continue;
				case 91u:
					Form3.smethod_29((ButtonBase)(object)button5, (FlatStyle)0);
					num = (int)(num2 * 260694623) ^ -1788439647;
					continue;
				case 90u:
					num = ((int)num2 * -1893492323) ^ 0x866ABC5;
					continue;
				case 89u:
					num = (int)(num2 * 1602006129) ^ -1569621090;
					continue;
				case 88u:
					Form3.smethod_31((Control)(object)textBox1, "textBox1");
					num = (int)(num2 * 319018452) ^ -1233783572;
					continue;
				case 87u:
					num = ((int)num2 * -1228228896) ^ 0x7A20098E;
					continue;
				case 86u:
					button1 = Form3.smethod_20();
					button2 = Form3.smethod_20();
					num = ((int)num2 * -167194504) ^ 0x5FA2232F;
					continue;
				case 85u:
					Form3.smethod_30((Control)(object)button5, new Point(174, 190));
					num = ((int)num2 * -170579525) ^ 0x4C9AE001;
					continue;
				case 84u:
					Form3.smethod_31((Control)(object)label1, "label1");
					num = (int)(num2 * 1907885146) ^ -2134666294;
					continue;
				case 83u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button4);
					num = ((int)num2 * -480877482) ^ -1419966773;
					continue;
				case 82u:
					Form3.smethod_54((Form)(object)this, bool_0: true);
					num = ((int)num2 * -2127486312) ^ -790165287;
					continue;
				case 81u:
					Form3.smethod_55((ISupportInitialize)errorProvider1);
					num = (int)((num2 * 462073953) ^ 0x14151E62);
					continue;
				case 80u:
					num = (int)(num2 * 1612509177) ^ -1536487741;
					continue;
				case 79u:
					Form3.smethod_39((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -475758860) ^ 0x5A75471D;
					continue;
				case 78u:
					button7 = Form3.smethod_20();
					textBox1 = Form3.smethod_21();
					label1 = Form3.smethod_22();
					textBox2 = Form3.smethod_21();
					num = ((int)num2 * -239238750) ^ 0x2A0EF566;
					continue;
				case 77u:
					Form3.smethod_35((Control)(object)button5, "Продолжить");
					num = (int)(num2 * 178517229) ^ -604273292;
					continue;
				case 76u:
					num = ((int)num2 * -1135402359) ^ -1657243949;
					continue;
				case 75u:
					num = ((int)num2 * -1844608344) ^ 0x10AF6EC1;
					continue;
				case 74u:
					Form3.smethod_38((Control)(object)button5, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1314661578) ^ 0x76EA4D15;
					continue;
				case 73u:
					Form3.smethod_34((ButtonBase)(object)NullButton, bool_0: false);
					num = (int)(num2 * 1871222790) ^ -1346396012;
					continue;
				case 72u:
					Form3.smethod_35((Control)(object)button1, "Вход");
					num = ((int)num2 * -513790735) ^ 0x39FEF441;
					continue;
				case 71u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button5), 0);
					num = (int)(num2 * 1782729834) ^ -1080532895;
					continue;
				case 70u:
					Form3.smethod_39((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = (int)((num2 * 1809821948) ^ 0x6606D51E);
					continue;
				case 69u:
					num = ((int)num2 * -1420004953) ^ 0x38EA7054;
					continue;
				case 68u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox1);
					num = (int)((num2 * 1718220719) ^ 0x7E345A73);
					continue;
				case 67u:
					num = ((int)num2 * -1712376012) ^ -899285155;
					continue;
				case 66u:
					Form3.smethod_36((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -1354149355) ^ 0x7B561975;
					continue;
				case 65u:
					num = (int)(num2 * 1440363612) ^ -1136025926;
					continue;
				case 64u:
					num = ((int)num2 * -117307427) ^ -1248862379;
					continue;
				case 62u:
					num = ((int)num2 * -747832917) ^ 0x20BEDFFF;
					continue;
				case 61u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button5);
					num = (int)(num2 * 1966848450) ^ -12835996;
					continue;
				case 60u:
					Form3.smethod_30((Control)(object)button4, new Point(174, 137));
					num = (int)(num2 * 2030315483) ^ -1387453869;
					continue;
				case 59u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button1);
					num = (int)(num2 * 371086119) ^ -2141222417;
					continue;
				case 58u:
					Form3.smethod_32((Control)(object)NullButton, new Size(1, 1));
					num = ((int)num2 * -34723914) ^ 0x1FA6D79;
					continue;
				case 57u:
					num = (int)((num2 * 1738954506) ^ 0x5B55832A);
					continue;
				case 56u:
					Form3.smethod_36((Control)(object)button7, (EventHandler)Button7_Click);
					num = ((int)num2 * -1798740806) ^ 0x6DDF07E1;
					continue;
				case 55u:
					Form3.smethod_32((Control)(object)textBox2, new Size(140, 20));
					num = (int)(num2 * 566138477) ^ -1435026777;
					continue;
				case 54u:
					Form3.smethod_56((Control)(object)this, bool_0: false);
					num = (int)((num2 * 83016170) ^ 0x5720E52C);
					continue;
				case 53u:
					num = (int)((num2 * 1162451540) ^ 0x69CF1465);
					continue;
				case 52u:
					num = ((int)num2 * -108231301) ^ 0x36138AA4;
					continue;
				case 51u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button4), 0);
					Form3.smethod_29((ButtonBase)(object)button4, (FlatStyle)0);
					Form3.smethod_38((Control)(object)button4, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 2113757967) ^ -972188573;
					continue;
				case 50u:
					errorProvider1 = Form3.smethod_23(components);
					Form3.smethod_24((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -284874123) ^ -495430639;
					continue;
				case 49u:
					num = (int)((num2 * 918994021) ^ 0x482E1971);
					continue;
				case 48u:
					Form3.smethod_32((Control)(object)button7, new Size(140, 50));
					num = ((int)num2 * -845679638) ^ -6229848;
					continue;
				case 47u:
					num = ((int)num2 * -1234959692) ^ -1275282839;
					continue;
				case 46u:
					Form3.smethod_36((Control)(object)button4, (EventHandler)Button4_Click);
					num = (int)(num2 * 1433338066) ^ -1350252938;
					continue;
				case 45u:
					Form3.smethod_35((Control)(object)button4, "Начало игры");
					num = ((int)num2 * -1112644273) ^ 0x5E84D616;
					continue;
				case 44u:
					Form3.smethod_26((Control)(object)label1, Color.Transparent);
					num = ((int)num2 * -990093946) ^ -760602723;
					continue;
				case 43u:
					Form3.smethod_35((Control)(object)button2, "Регистрация");
					num = ((int)num2 * -1549610218) ^ -1579718323;
					continue;
				case 42u:
					num = ((int)num2 * -186246378) ^ -9121048;
					continue;
				case 41u:
					Form3.smethod_25((Control)(object)this);
					num = ((int)num2 * -1134264300) ^ 0x39585A9D;
					continue;
				case 40u:
					Form3.smethod_52((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1579339262) ^ 0x489E0B87;
					continue;
				case 39u:
					num = (int)(num2 * 1745364152) ^ -1677603178;
					continue;
				case 38u:
					Form3.smethod_30((Control)(object)button7, new Point(174, 243));
					num = ((int)num2 * -1122995269) ^ 0x879692C;
					continue;
				case 37u:
					num = ((int)num2 * -481924460) ^ -623034692;
					continue;
				case 36u:
					num = (int)((num2 * 1327536711) ^ 0x4423EA62);
					continue;
				case 35u:
					num = (int)((num2 * 1020496322) ^ 0x4D950E14);
					continue;
				case 34u:
					Form3.smethod_36((Control)(object)button5, (EventHandler)Button5_Click);
					num = ((int)num2 * -167320409) ^ 0x694F692;
					continue;
				case 33u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox2);
					num = ((int)num2 * -1812505281) ^ -1271831061;
					continue;
				case 32u:
					num = (int)((num2 * 168463082) ^ 0x38A2650D);
					continue;
				case 31u:
					Form3.smethod_33((Control)(object)button1, 0);
					num = ((int)num2 * -729929622) ^ -1527915734;
					continue;
				case 30u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)NullButton);
					num = ((int)num2 * -1240894853) ^ -169811307;
					continue;
				case 29u:
					num = (int)((num2 * 879162236) ^ 0x699722E4);
					continue;
				case 28u:
					Form3.smethod_30((Control)(object)textBox2, new Point(174, 26));
					num = (int)(num2 * 1896142383) ^ -535220219;
					continue;
				case 27u:
					num = ((int)num2 * -1084647134) ^ 0xD2606FB;
					continue;
				case 26u:
					Form3.smethod_32((Control)(object)button2, new Size(85, 21));
					num = ((int)num2 * -1612501529) ^ -303866040;
					continue;
				case 25u:
					num = ((int)num2 * -1287928003) ^ 0x6BAA5333;
					continue;
				case 24u:
					Form3.smethod_33((Control)(object)button4, 4);
					num = (int)((num2 * 1553593790) ^ 0x43F3BB82);
					continue;
				case 22u:
					Form3.smethod_30((Control)(object)button1, new Point(265, 49));
					num = ((int)num2 * -1278537256) ^ 0x69DB019A;
					continue;
				case 21u:
					Form3.smethod_53((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1838002386) ^ -1434657894;
					continue;
				case 20u:
					Form3.smethod_31((Control)(object)button7, "button7");
					num = ((int)num2 * -408507455) ^ -1254590984;
					continue;
				case 19u:
					Form3.smethod_33((Control)(object)button7, 6);
					Form3.smethod_35((Control)(object)button7, "Достижения");
					num = ((int)num2 * -714166463) ^ 0x4323DBA;
					continue;
				case 18u:
					num = ((int)num2 * -1965190943) ^ -1420485202;
					continue;
				case 17u:
					Form3.smethod_34((ButtonBase)(object)button1, bool_0: true);
					num = (int)(num2 * 654824092) ^ -1441924299;
					continue;
				case 16u:
					Form3.smethod_34((ButtonBase)(object)button2, bool_0: true);
					num = (int)(num2 * 1018333797) ^ -582834992;
					continue;
				case 15u:
					components = Form3.smethod_19();
					NullButton = Form3.smethod_20();
					num = (int)((num2 * 2122680424) ^ 0x5F321D58);
					continue;
				case 14u:
					num = (int)(num2 * 242410233) ^ -191657835;
					continue;
				case 13u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button7);
					num = (int)(num2 * 1699115566) ^ -1400523145;
					continue;
				case 12u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button7), 0);
					num = ((int)num2 * -120133328) ^ -1932635078;
					continue;
				case 11u:
					Form3.smethod_32((Control)(object)button4, new Size(140, 50));
					num = ((int)num2 * -134131266) ^ -1547477786;
					continue;
				case 10u:
					Form3.smethod_33((Control)(object)label1, 7);
					num = (int)(num2 * 1286940097) ^ -1031821429;
					continue;
				case 9u:
					Form3.smethod_31((Control)(object)button4, "button4");
					num = ((int)num2 * -157686120) ^ -1357466617;
					continue;
				case 8u:
					Form3.smethod_32((Control)(object)label1, new Size(207, 76));
					num = ((int)num2 * -2040703170) ^ -683988415;
					continue;
				case 7u:
					Form3.smethod_30((Control)(object)textBox1, new Point(174, 2));
					num = ((int)num2 * -600109086) ^ -182718191;
					continue;
				case 6u:
					num = ((int)num2 * -1211645435) ^ -2005337890;
					continue;
				case 5u:
					Form3.smethod_30((Control)(object)label1, new Point(140, 70));
					num = ((int)num2 * -710742883) ^ -1078954485;
					continue;
				case 4u:
					Form3.smethod_41(textBox2, bool_0: true);
					num = ((int)num2 * -1808733150) ^ -323807161;
					continue;
				case 3u:
					num = (int)(num2 * 1461792732) ^ -2121525166;
					continue;
				case 2u:
					Form3.smethod_45((Form)(object)this, new Size(486, 296));
					num = (int)((num2 * 731148671) ^ 0x4C2EF165);
					continue;
				case 1u:
					Form3.smethod_40((Control)(object)label1, bool_0: true);
					num = (int)((num2 * 572227859) ^ 0x660C6E93);
					continue;
				case 0u:
					Form3.smethod_31((Control)(object)textBox2, "textBox2");
					num = (int)((num2 * 1453934103) ^ 0x588EB525);
					continue;
				default:
					return;
				case 63u:
					break;
				case 23u:
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
