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
			int num = 2128122118;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x650B568Bu) % 4u)
				{
				case 2u:
					num = (int)(num2 * 1409029332) ^ -1217524629;
					continue;
				case 1u:
					num = ((int)num2 * -893758497) ^ 0x441CAAAA;
					continue;
				case 3u:
					break;
				default:
					InitializeComponent();
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
			int num = 715018191;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7EF84E81u) % 9u)
				{
				case 8u:
				{
					Form4 form = new Form4();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					Form3.smethod_4((Control)(object)val);
					num = ((int)num2 * -759198083) ^ 0x51F55048;
					continue;
				}
				case 7u:
					Form3.smethod_0((Control)(object)NullButton);
					num = ((int)num2 * -1575622480) ^ -1978006566;
					continue;
				case 6u:
					Form3.smethod_10(val, new Point(Form3.smethod_5((Form)(object)this).X + (Form3.smethod_6((Control)(object)this) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_5((Form)(object)this).Y + (Form3.smethod_8((Control)(object)this) - Form3.smethod_9((Control)(object)val)) / 2 + 70));
					num = ((int)num2 * -28590172) ^ 0x230CB9CD;
					continue;
				case 5u:
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = (int)((num2 * 494560166) ^ 0x79E1FFE0);
					continue;
				case 4u:
					Form3.smethod_1(errorProvider1);
					num = ((int)num2 * -1264519268) ^ -1124377588;
					continue;
				case 3u:
					num = (int)(num2 * 1896680463) ^ -780431643;
					continue;
				case 1u:
					num = ((int)num2 * -224066819) ^ 0x5B27ABB1;
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
		Form val = default(Form);
		while (true)
		{
			int num = 1696845319;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x546C7330u) % 5u)
				{
				case 3u:
					Form3.smethod_10(val, new Point(Form3.smethod_13(Form3.smethod_12((Form)(object)this)).X + (Form3.smethod_7((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_13(Form3.smethod_12((Form)(object)this)).Y + (Form3.smethod_9((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_9((Control)(object)val)) / 2));
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = (int)(num2 * 1190895553) ^ -610278900;
					continue;
				case 2u:
					Form3.smethod_0((Control)(object)NullButton);
					num = ((int)num2 * -1254382076) ^ -349937378;
					continue;
				case 1u:
				{
					Form2 form = new Form2();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					Form3.smethod_4((Control)(object)val);
					num = ((int)num2 * -527847758) ^ 0x311677B9;
					continue;
				}
				default:
					return;
				case 4u:
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
		while (true)
		{
			int num = 1046159938;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x492F54E4u) % 9u)
				{
				case 8u:
					Form3.smethod_16(Form3.smethod_12((Form)(object)this));
					num = ((int)num2 * -227413991) ^ -636300751;
					continue;
				case 7u:
					Form3.smethod_15((Control)(object)this, num3);
					num = ((int)num2 * -916076738) ^ -35971521;
					continue;
				case 6u:
					num = 1967879254;
					continue;
				case 4u:
					num3 = Form3.smethod_8((Control)(object)this) - 1;
					num = 1008905709;
					continue;
				case 3u:
					num = ((int)num2 * -542131684) ^ 0x1120E27E;
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (num3 <= 1)
					{
						num4 = 439250568;
						num5 = 439250568;
					}
					else
					{
						num4 = 1395345399;
						num5 = 1395345399;
					}
					num = num4 ^ ((int)num2 * -456325866);
					continue;
				}
				case 0u:
					num = ((int)num2 * -1223968683) ^ -748670815;
					continue;
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
			int num = 11922552;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2538896Bu) % 3u)
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
				num = ((int)num2 * -15337450) ^ 0x659F0254;
			}
		}
	}

	public void ContinueLock()
	{
		Form3.smethod_14((Control)(object)button5, bool_0: false);
		while (true)
		{
			int num = -1088777058;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD6D1B8A1u) % 3u)
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
				num = ((int)num2 * -312054549) ^ 0x7050E4F6;
			}
		}
	}

	public void AchivUnlock()
	{
		Form3.smethod_14((Control)(object)button7, bool_0: true);
		while (true)
		{
			int num = -994824099;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x99E4F7B3u) % 3u)
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
				num = (int)((num2 * 1126387717) ^ 0x3CA1BD6F);
			}
		}
	}

	private void Button7_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 894856761;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6F9B8E5Cu) % 4u)
				{
				case 2u:
					Form3.smethod_14((Control)(object)button7, bool_0: false);
					num = ((int)num2 * -860766463) ^ 0x64EA177D;
					continue;
				case 1u:
					Form3.smethod_0((Control)(object)NullButton);
					num = ((int)num2 * -256446601) ^ -2048904839;
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
			goto IL_0056;
		}
		int num = 0;
		goto IL_008d;
		IL_0084:
		num = ((components != null) ? 1 : 0);
		goto IL_008d;
		IL_0056:
		int num2 = 1198824529;
		goto IL_005b;
		IL_005b:
		bool flag = default(bool);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x96A1983u) % 6u)
			{
			case 5u:
			{
				int num4;
				int num5;
				if (flag)
				{
					num4 = -696046862;
					num5 = -696046862;
				}
				else
				{
					num4 = -175417090;
					num5 = -175417090;
				}
				num2 = num4 ^ ((int)num3 * -1083934436);
				continue;
			}
			case 3u:
				Form3.smethod_18((IDisposable)components);
				num2 = ((int)num3 * -458026521) ^ 0x4AB09FE;
				continue;
			case 2u:
				num2 = (int)(num3 * 2130245449) ^ -1256023788;
				continue;
			case 0u:
				break;
			case 4u:
				goto IL_0084;
			default:
				((Form)this).Dispose(disposing);
				return;
			}
			break;
		}
		goto IL_0056;
		IL_008d:
		flag = (byte)num != 0;
		num2 = 2130988678;
		goto IL_005b;
	}

	private void InitializeComponent()
	{
		components = Form3.smethod_19();
		NullButton = Form3.smethod_20();
		while (true)
		{
			int num = 1606082580;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4944A9C9u) % 126u)
				{
				case 125u:
					button2 = Form3.smethod_20();
					num = (int)((num2 * 2099111413) ^ 0x36655148);
					continue;
				case 124u:
					Form3.smethod_41(textBox2, bool_0: true);
					num = (int)(num2 * 1167684585) ^ -991693603;
					continue;
				case 123u:
					Form3.smethod_53((Form)(object)this, bool_0: false);
					num = ((int)num2 * -343500015) ^ -1785356876;
					continue;
				case 122u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button4);
					num = ((int)num2 * -1732677816) ^ -1378688232;
					continue;
				case 121u:
					Form3.smethod_29((ButtonBase)(object)NullButton, (FlatStyle)0);
					num = (int)(num2 * 3373461) ^ -1713370631;
					continue;
				case 119u:
					Form3.smethod_33((Control)(object)textBox2, 8);
					num = (int)(num2 * 1690021844) ^ -1483207762;
					continue;
				case 118u:
					Form3.smethod_35((Control)(object)button7, "Достижения");
					Form3.smethod_34((ButtonBase)(object)button7, bool_0: true);
					Form3.smethod_36((Control)(object)button7, (EventHandler)Button7_Click);
					Form3.smethod_30((Control)(object)textBox1, new Point(174, 2));
					num = ((int)num2 * -1409712121) ^ -1690537037;
					continue;
				case 117u:
					Form3.smethod_30((Control)(object)NullButton, new Point(-1, -1));
					num = ((int)num2 * -955991716) ^ 0x5C1B7044;
					continue;
				case 116u:
					Form3.smethod_33((Control)(object)textBox1, 7);
					Form3.smethod_39((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					Form3.smethod_40((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -282335304) ^ 0x48BADBA4;
					continue;
				case 115u:
					num = (int)((num2 * 380911452) ^ 0x22F7B6E4);
					continue;
				case 114u:
					Form3.smethod_32((Control)(object)textBox2, new Size(140, 20));
					num = (int)((num2 * 1041724757) ^ 0x7B1D5CDE);
					continue;
				case 113u:
					num = (int)((num2 * 846979913) ^ 0x2AAA47B2);
					continue;
				case 112u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button2);
					num = ((int)num2 * -2123473294) ^ 0x5FED7193;
					continue;
				case 111u:
					Form3.smethod_31((Control)(object)NullButton, "NullButton");
					Form3.smethod_32((Control)(object)NullButton, new Size(1, 1));
					Form3.smethod_33((Control)(object)NullButton, 3);
					num = ((int)num2 * -1062373070) ^ -1496941232;
					continue;
				case 110u:
					button4 = Form3.smethod_20();
					button5 = Form3.smethod_20();
					button7 = Form3.smethod_20();
					num = ((int)num2 * -1372530769) ^ 0x3B48AF2D;
					continue;
				case 109u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)label1);
					num = (int)(num2 * 1465427379) ^ -463413919;
					continue;
				case 108u:
					Form3.smethod_30((Control)(object)button4, new Point(174, 137));
					Form3.smethod_31((Control)(object)button4, "button4");
					num = ((int)num2 * -589333082) ^ -1669654255;
					continue;
				case 107u:
					num = (int)((num2 * 719056184) ^ 0x5BF1BBF9);
					continue;
				case 106u:
					Form3.smethod_38((Control)(object)label1, Form3.smethod_37("Mistral", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1751589156) ^ 0x172C3DE4;
					continue;
				case 105u:
					Form3.smethod_34((ButtonBase)(object)button5, bool_0: true);
					num = (int)(num2 * 1515324605) ^ -553877623;
					continue;
				case 104u:
					num = (int)(num2 * 494385270) ^ -2060914211;
					continue;
				case 103u:
					Form3.smethod_34((ButtonBase)(object)NullButton, bool_0: false);
					num = ((int)num2 * -985710713) ^ 0x4FA540A8;
					continue;
				case 102u:
					Form3.smethod_34((ButtonBase)(object)button2, bool_0: true);
					num = (int)(num2 * 1670737786) ^ -441051745;
					continue;
				case 101u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox2);
					num = ((int)num2 * -1058751607) ^ -390375578;
					continue;
				case 100u:
					Form3.smethod_38((Control)(object)button5, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 1275981823) ^ -910538201;
					continue;
				case 99u:
					num = ((int)num2 * -531252582) ^ 0x2208AC5F;
					continue;
				case 98u:
					num = (int)(num2 * 823679974) ^ -205064573;
					continue;
				case 97u:
					Form3.smethod_36((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)((num2 * 2051847142) ^ 0xB58E6FD);
					continue;
				case 96u:
					Form3.smethod_48((Form)(object)this, (FormBorderStyle)0);
					num = (int)(num2 * 1989363997) ^ -1814036246;
					continue;
				case 95u:
					Form3.smethod_35((Control)(object)button2, "Регистрация");
					num = ((int)num2 * -983432801) ^ 0x38D70A06;
					continue;
				case 94u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)NullButton), 0);
					num = ((int)num2 * -200725903) ^ 0x3D3F5962;
					continue;
				case 93u:
					Form3.smethod_57((Control)(object)this);
					num = (int)(num2 * 856450267) ^ -766487938;
					continue;
				case 92u:
					Form3.smethod_38((Control)(object)button4, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -334584854) ^ 0x1F3336F3;
					continue;
				case 91u:
					num = (int)((num2 * 2103059388) ^ 0x7CF790D3);
					continue;
				case 90u:
					Form3.smethod_26((Control)(object)NullButton, Color.Transparent);
					num = ((int)num2 * -545999851) ^ -692953763;
					continue;
				case 89u:
					num = ((int)num2 * -1773692574) ^ 0x346D83E4;
					continue;
				case 88u:
					Form3.smethod_31((Control)(object)textBox1, "textBox1");
					num = ((int)num2 * -1616716120) ^ 0x622A9F3A;
					continue;
				case 87u:
					Form3.smethod_52((Form)(object)this, bool_0: false);
					num = ((int)num2 * -958099090) ^ -1615467046;
					continue;
				case 86u:
					Form3.smethod_33((Control)(object)button2, 1);
					num = ((int)num2 * -1514081522) ^ 0x7B6513BC;
					continue;
				case 85u:
					num = ((int)num2 * -677874739) ^ 0x740993D6;
					continue;
				case 84u:
					Form3.smethod_31((Control)(object)button2, "button2");
					num = (int)((num2 * 1502711099) ^ 0x32A35BC1);
					continue;
				case 83u:
					Form3.smethod_43((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)(num2 * 1974282263) ^ -1001329072;
					continue;
				case 82u:
					Form3.smethod_35((Control)(object)label1, "QUARTO");
					num = (int)((num2 * 2061953867) ^ 0x681BD339);
					continue;
				case 81u:
					num = ((int)num2 * -546751025) ^ 0x44A21CE6;
					continue;
				case 80u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button5);
					num = (int)((num2 * 1177361499) ^ 0x6E68050B);
					continue;
				case 79u:
					errorProvider1 = Form3.smethod_23(components);
					Form3.smethod_24((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -1848968387) ^ 0x25A2D957;
					continue;
				case 78u:
					num = ((int)num2 * -518658610) ^ 0x81B57D7;
					continue;
				case 77u:
					Form3.smethod_36((Control)(object)button4, (EventHandler)Button4_Click);
					num = ((int)num2 * -284228305) ^ 0x6DBD2241;
					continue;
				case 76u:
					Form3.smethod_31((Control)(object)label1, "label1");
					num = ((int)num2 * -2015700604) ^ 0x13A65CCA;
					continue;
				case 75u:
					Form3.smethod_30((Control)(object)label1, new Point(140, 70));
					num = ((int)num2 * -1540392537) ^ 0x3F73CCB3;
					continue;
				case 74u:
					Form3.smethod_31((Control)(object)button7, "button7");
					Form3.smethod_32((Control)(object)button7, new Size(140, 50));
					num = ((int)num2 * -1042089309) ^ 0x7B85CB3C;
					continue;
				case 73u:
					num = (int)(num2 * 1196285234) ^ -154359834;
					continue;
				case 72u:
					Form3.smethod_30((Control)(object)button1, new Point(265, 49));
					num = ((int)num2 * -1507976455) ^ 0xC6D2930;
					continue;
				case 71u:
					Form3.smethod_30((Control)(object)button7, new Point(174, 243));
					num = ((int)num2 * -1359448088) ^ -1001484568;
					continue;
				case 70u:
					num = (int)(num2 * 682719996) ^ -257420179;
					continue;
				case 69u:
					num = ((int)num2 * -470241459) ^ 0x2482289E;
					continue;
				case 68u:
					Form3.smethod_31((Control)(object)button1, "button1");
					Form3.smethod_32((Control)(object)button1, new Size(49, 21));
					num = (int)(num2 * 892028439) ^ -1368632841;
					continue;
				case 67u:
					label1 = Form3.smethod_22();
					textBox2 = Form3.smethod_21();
					num = (int)((num2 * 704959951) ^ 0x6060E88F);
					continue;
				case 66u:
					Form3.smethod_26((Control)(object)label1, Color.Transparent);
					num = (int)((num2 * 1973537222) ^ 0x5A43AF1B);
					continue;
				case 65u:
					num = ((int)num2 * -1813527874) ^ 0x5D4BEC35;
					continue;
				case 64u:
					num = ((int)num2 * -177384631) ^ -1454562547;
					continue;
				case 63u:
					button1 = Form3.smethod_20();
					num = ((int)num2 * -500208785) ^ -1148965651;
					continue;
				case 62u:
					Form3.smethod_36((Control)(object)button2, (EventHandler)Button2_Click);
					num = (int)((num2 * 701247266) ^ 0x5840F6E);
					continue;
				case 61u:
					Form3.smethod_35((Control)(object)button4, "Начало игры");
					num = ((int)num2 * -1274115370) ^ -973096330;
					continue;
				case 60u:
					Form3.smethod_30((Control)(object)textBox2, new Point(174, 26));
					num = ((int)num2 * -231463013) ^ -191302563;
					continue;
				case 59u:
					Form3.smethod_36((Control)(object)button5, (EventHandler)Button5_Click);
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button7), 0);
					num = (int)(num2 * 1207835900) ^ -1284827093;
					continue;
				case 58u:
					Form3.smethod_33((Control)(object)button4, 4);
					num = (int)(num2 * 1121029833) ^ -975444602;
					continue;
				case 57u:
					Form3.smethod_31((Control)(object)button5, "button5");
					Form3.smethod_32((Control)(object)button5, new Size(140, 50));
					num = ((int)num2 * -937619208) ^ -783690078;
					continue;
				case 56u:
					Form3.smethod_39((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -1170143177) ^ -487305938;
					continue;
				case 55u:
					Form3.smethod_25((Control)(object)this);
					num = (int)(num2 * 771279929) ^ -1838073386;
					continue;
				case 54u:
					Form3.smethod_29((ButtonBase)(object)button7, (FlatStyle)0);
					Form3.smethod_38((Control)(object)button7, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1037074848) ^ -539671456;
					continue;
				case 53u:
					num = (int)((num2 * 923560393) ^ 0x2C231DF2);
					continue;
				case 52u:
					num = ((int)num2 * -1916919181) ^ -164598961;
					continue;
				case 51u:
					Form3.smethod_32((Control)(object)label1, new Size(207, 76));
					num = ((int)num2 * -2042628092) ^ 0x6D2BA1CD;
					continue;
				case 50u:
					Form3.smethod_33((Control)(object)button7, 6);
					num = ((int)num2 * -792817405) ^ 0x6C351514;
					continue;
				case 49u:
					num = ((int)num2 * -786323615) ^ -1997671904;
					continue;
				case 48u:
					Form3.smethod_31((Control)(object)textBox2, "textBox2");
					num = ((int)num2 * -496242680) ^ -215815137;
					continue;
				case 47u:
					Form3.smethod_14((Control)(object)button4, bool_0: false);
					num = (int)((num2 * 1230289047) ^ 0x1BD577B8);
					continue;
				case 46u:
					Form3.smethod_33((Control)(object)label1, 7);
					num = (int)((num2 * 1353842877) ^ 0x4DEB072);
					continue;
				case 45u:
					Form3.smethod_55((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -832506761) ^ -1529847351;
					continue;
				case 44u:
					Form3.smethod_30((Control)(object)button5, new Point(174, 190));
					num = ((int)num2 * -1715919702) ^ -1286700336;
					continue;
				case 43u:
					Form3.smethod_49((Form)(object)this, bool_0: false);
					num = ((int)num2 * -181545124) ^ -300424519;
					continue;
				case 42u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button1);
					num = (int)(num2 * 465071206) ^ -1035145230;
					continue;
				case 41u:
					Form3.smethod_56((Control)(object)this, bool_0: false);
					num = ((int)num2 * -290166957) ^ 0x33151925;
					continue;
				case 40u:
					num = (int)((num2 * 1938583470) ^ 0x1D788834);
					continue;
				case 39u:
					num = (int)((num2 * 36275559) ^ 0x53B08269);
					continue;
				case 38u:
					Form3.smethod_32((Control)(object)button4, new Size(140, 50));
					num = (int)((num2 * 1802491405) ^ 0x4D8A10DE);
					continue;
				case 37u:
					num = (int)((num2 * 298720371) ^ 0x721D26A9);
					continue;
				case 36u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button7);
					num = (int)(num2 * 1322443579) ^ -77933828;
					continue;
				case 35u:
					num = ((int)num2 * -2122473434) ^ -2060131877;
					continue;
				case 34u:
					Form3.smethod_54((Form)(object)this, bool_0: true);
					num = ((int)num2 * -1087917007) ^ 0x3288E74F;
					continue;
				case 33u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox1);
					num = (int)(num2 * 1634354865) ^ -1050575414;
					continue;
				case 32u:
					num = ((int)num2 * -1949598148) ^ 0x64DB7A2;
					continue;
				case 31u:
					num = ((int)num2 * -1339698696) ^ 0x1FA3FFE1;
					continue;
				case 30u:
					num = (int)(num2 * 629887860) ^ -1827409556;
					continue;
				case 29u:
					num = (int)(num2 * 674505806) ^ -1697198939;
					continue;
				case 28u:
					Form3.smethod_32((Control)(object)button2, new Size(85, 21));
					num = (int)((num2 * 1458119836) ^ 0x47CC3FD9);
					continue;
				case 27u:
					Form3.smethod_45((Form)(object)this, new Size(486, 296));
					num = (int)((num2 * 1431954030) ^ 0x1A904124);
					continue;
				case 26u:
					Form3.smethod_44((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -915069435) ^ -1453088924;
					continue;
				case 25u:
					Form3.smethod_34((ButtonBase)(object)button4, bool_0: true);
					num = (int)((num2 * 1492104447) ^ 0x7F119BEB);
					continue;
				case 24u:
					textBox1 = Form3.smethod_21();
					num = ((int)num2 * -1160963311) ^ -1511984022;
					continue;
				case 23u:
					num = (int)(num2 * 1226004829) ^ -865263081;
					continue;
				case 22u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)NullButton);
					num = ((int)num2 * -1180684378) ^ -1048193252;
					continue;
				case 21u:
					num = (int)(num2 * 1592418670) ^ -865992762;
					continue;
				case 20u:
					Form3.smethod_26((Control)(object)this, Color.White);
					num = (int)((num2 * 2082138675) ^ 0x31FE14FA);
					continue;
				case 19u:
					num = (int)(num2 * 63484774) ^ -568479412;
					continue;
				case 18u:
					Form3.smethod_30((Control)(object)button2, new Point(174, 49));
					num = (int)((num2 * 2028871149) ^ 0x111DE86);
					continue;
				case 17u:
					Form3.smethod_33((Control)(object)button1, 0);
					Form3.smethod_35((Control)(object)button1, "Вход");
					num = ((int)num2 * -1420434361) ^ -956792867;
					continue;
				case 16u:
					Form3.smethod_29((ButtonBase)(object)button5, (FlatStyle)0);
					num = (int)(num2 * 94425910) ^ -2093445773;
					continue;
				case 15u:
					Form3.smethod_14((Control)(object)button5, bool_0: false);
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button5), 0);
					num = ((int)num2 * -583674568) ^ -2048364523;
					continue;
				case 13u:
					num = ((int)num2 * -1970447402) ^ -408830259;
					continue;
				case 12u:
					Form3.smethod_50((Form)(object)this, bool_0: false);
					num = (int)((num2 * 1229197759) ^ 0x3608B602);
					continue;
				case 11u:
					num = (int)(num2 * 822873603) ^ -1374176038;
					continue;
				case 10u:
					Form3.smethod_29((ButtonBase)(object)button4, (FlatStyle)0);
					num = ((int)num2 * -1044473601) ^ 0x2F192703;
					continue;
				case 9u:
					num = ((int)num2 * -1656371451) ^ -2116600250;
					continue;
				case 8u:
					Form3.smethod_33((Control)(object)button5, 5);
					Form3.smethod_35((Control)(object)button5, "Продолжить");
					num = ((int)num2 * -1952770409) ^ -520601338;
					continue;
				case 7u:
					Form3.smethod_34((ButtonBase)(object)button1, bool_0: true);
					num = (int)(num2 * 1591653820) ^ -1825783040;
					continue;
				case 6u:
					Form3.smethod_32((Control)(object)textBox1, new Size(140, 20));
					num = (int)((num2 * 1367872062) ^ 0xF943F59);
					continue;
				case 5u:
					num = ((int)num2 * -885578552) ^ -524328177;
					continue;
				case 4u:
					num = (int)(num2 * 1874301871) ^ -165450876;
					continue;
				case 3u:
					Form3.smethod_42(errorProvider1, (ContainerControl)(object)this);
					num = ((int)num2 * -451438241) ^ 0x2F6881D1;
					continue;
				case 2u:
					num = ((int)num2 * -316492269) ^ 0x33A2C57D;
					continue;
				case 1u:
					Form3.smethod_51((Control)(object)this, "Form3");
					num = (int)(num2 * 1613477260) ^ -1023875703;
					continue;
				case 0u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button4), 0);
					num = ((int)num2 * -629979273) ^ -537238633;
					continue;
				default:
					return;
				case 120u:
					break;
				case 14u:
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
