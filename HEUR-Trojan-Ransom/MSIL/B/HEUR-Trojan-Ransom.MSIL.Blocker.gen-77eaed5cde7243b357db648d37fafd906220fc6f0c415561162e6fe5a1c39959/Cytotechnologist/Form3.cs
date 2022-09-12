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
			int num = 183447244;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6457B276u) % 8u)
				{
				case 5u:
				{
					Form4 form = new Form4();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					num = ((int)num2 * -344077271) ^ -2092185409;
					continue;
				}
				case 4u:
					Form3.smethod_4((Control)(object)val);
					num = (int)(num2 * 207193573) ^ -24208238;
					continue;
				case 3u:
					num = (int)((num2 * 1658707190) ^ 0x6A4FA1E2);
					continue;
				case 2u:
					Form3.smethod_0((Control)(object)NullButton);
					Form3.smethod_1(errorProvider1);
					num = ((int)num2 * -1073501752) ^ -862164645;
					continue;
				case 1u:
					Form3.smethod_10(val, new Point(Form3.smethod_5((Form)(object)this).X + (Form3.smethod_6((Control)(object)this) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_5((Form)(object)this).Y + (Form3.smethod_8((Control)(object)this) - Form3.smethod_9((Control)(object)val)) / 2 + 70));
					num = (int)((num2 * 664272840) ^ 0x78D6677D);
					continue;
				case 0u:
					num = ((int)num2 * -1333405924) ^ -1395814105;
					continue;
				case 7u:
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
			int num = 1929482499;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x26FC09BFu) % 8u)
				{
				case 6u:
					num = ((int)num2 * -1250258827) ^ 0x33F8F2EC;
					continue;
				case 4u:
				{
					Form2 form = new Form2();
					Form3.smethod_2((Form)(object)form, bool_0: true);
					Form3.smethod_3((Form)(object)form, (Form)(object)this);
					val = (Form)(object)form;
					num = (int)((num2 * 868445402) ^ 0x3EC7A125);
					continue;
				}
				case 3u:
					Form3.smethod_10(val, new Point(Form3.smethod_13(Form3.smethod_12((Form)(object)this)).X + (Form3.smethod_7((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_7((Control)(object)val)) / 2, Form3.smethod_13(Form3.smethod_12((Form)(object)this)).Y + (Form3.smethod_9((Control)(object)Form3.smethod_12((Form)(object)this)) - Form3.smethod_9((Control)(object)val)) / 2));
					num = ((int)num2 * -1578740203) ^ 0x35FF43F1;
					continue;
				case 2u:
					Form3.smethod_4((Control)(object)val);
					num = (int)(num2 * 1383572793) ^ -167532970;
					continue;
				case 1u:
					num = ((int)num2 * -1653620353) ^ 0x1E412648;
					continue;
				case 0u:
					Form3.smethod_11((Control)(object)this, bool_0: false);
					num = (int)(num2 * 524113434) ^ -1226065583;
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

	public void Button_Continue()
	{
		Form3.smethod_14((Control)(object)button5, bool_0: true);
		while (true)
		{
			int num = -1594541913;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC1FBC42Eu) % 3u)
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
				num = (int)(num2 * 591562334) ^ -369421085;
			}
		}
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		int num3 = default(int);
		while (true)
		{
			int num = 1223395138;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x324314F4u) % 9u)
				{
				case 8u:
					num3 = Form3.smethod_8((Control)(object)this) - 1;
					Form3.smethod_15((Control)(object)this, num3);
					num = 896785134;
					continue;
				case 7u:
					num = ((int)num2 * -910573155) ^ -1318906634;
					continue;
				case 5u:
					num = (int)((num2 * 2075781603) ^ 0x6ADAAAD8);
					continue;
				case 4u:
					Form3.smethod_16(Form3.smethod_12((Form)(object)this));
					num = ((int)num2 * -1422013899) ^ -714902119;
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (num3 > 1)
					{
						num4 = -330618842;
						num5 = -330618842;
					}
					else
					{
						num4 = -1280803625;
						num5 = -1280803625;
					}
					num = num4 ^ ((int)num2 * -1193587381);
					continue;
				}
				case 1u:
					Form3.smethod_17((Form3.smethod_12((Form)(object)this) as Form1).timer1);
					num = (int)((num2 * 1876939558) ^ 0x1D66D2F9);
					continue;
				case 0u:
					num = 1143461992;
					continue;
				default:
					return;
				case 2u:
					break;
				case 6u:
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
			int num = -1967428660;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x928756C5u) % 3u)
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
				num = (int)(num2 * 1354053505) ^ -1526984993;
			}
		}
	}

	private void Button7_Click(object sender, EventArgs e)
	{
		Form3.smethod_0((Control)(object)NullButton);
		Form3.smethod_14((Control)(object)button7, bool_0: false);
		while (true)
		{
			int num = 490872752;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x63B0DB25u) % 3u)
				{
				case 2u:
					goto IL_001a;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_001a:
				num = (int)(num2 * 333216268) ^ -820203236;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -1611311706;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0xF78FFF12u) % 8u)
				{
				case 6u:
					Form3.smethod_18((IDisposable)components);
					num = ((int)num2 * -977212468) ^ -2038857701;
					continue;
				case 5u:
					num5 = ((components != null) ? 1 : 0);
					goto IL_0029;
				case 4u:
					if (disposing)
					{
						num = (int)(num2 * 1597865492) ^ -1909634073;
						continue;
					}
					num5 = 0;
					goto IL_0029;
				case 3u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 243472120;
						num4 = 243472120;
					}
					else
					{
						num3 = 697571084;
						num4 = 697571084;
					}
					num = num3 ^ (int)(num2 * 20951232);
					continue;
				}
				case 2u:
					((Form)this).Dispose(disposing);
					num = -2064613131;
					continue;
				case 1u:
					num = (int)(num2 * 1292607669) ^ -471593811;
					continue;
				default:
					return;
				case 0u:
					break;
				case 7u:
					return;
					IL_0029:
					flag = (byte)num5 != 0;
					num = -2019878551;
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
			int num = 579633360;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3F03E78Au) % 130u)
				{
				case 129u:
					Form3.smethod_45((Form)(object)this, new Size(486, 296));
					num = (int)((num2 * 694021654) ^ 0x2864A266);
					continue;
				case 128u:
					Form3.smethod_44((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 356377888) ^ 0x6BC8685B);
					continue;
				case 127u:
					Form3.smethod_35((Control)(object)label1, "QUARTO");
					num = ((int)num2 * -1258803079) ^ -1208167591;
					continue;
				case 126u:
					Form3.smethod_32((Control)(object)button4, new Size(140, 50));
					num = (int)((num2 * 1962599918) ^ 0x13BE931F);
					continue;
				case 125u:
					Form3.smethod_52((Form)(object)this, bool_0: false);
					Form3.smethod_53((Form)(object)this, bool_0: false);
					num = (int)((num2 * 827622422) ^ 0xC24BF54);
					continue;
				case 124u:
					num = (int)((num2 * 1917222883) ^ 0xEC1B08A);
					continue;
				case 123u:
					Form3.smethod_38((Control)(object)button4, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -645919534) ^ 0x351D13D5;
					continue;
				case 122u:
					num = ((int)num2 * -2040604477) ^ -1993770426;
					continue;
				case 121u:
					button5 = Form3.smethod_20();
					num = ((int)num2 * -1832751153) ^ -1932415466;
					continue;
				case 120u:
					Form3.smethod_31((Control)(object)textBox1, "textBox1");
					num = ((int)num2 * -248306973) ^ -1371074759;
					continue;
				case 119u:
					Form3.smethod_32((Control)(object)label1, new Size(207, 76));
					Form3.smethod_33((Control)(object)label1, 7);
					num = (int)(num2 * 1463742709) ^ -1803831892;
					continue;
				case 118u:
					Form3.smethod_36((Control)(object)button4, (EventHandler)Button4_Click);
					Form3.smethod_14((Control)(object)button5, bool_0: false);
					num = (int)((num2 * 1332600519) ^ 0xC3DEB0C);
					continue;
				case 117u:
					Form3.smethod_32((Control)(object)textBox2, new Size(140, 20));
					num = ((int)num2 * -1520489817) ^ -538222215;
					continue;
				case 116u:
					Form3.smethod_33((Control)(object)NullButton, 3);
					Form3.smethod_34((ButtonBase)(object)NullButton, bool_0: false);
					num = ((int)num2 * -1674751362) ^ 0x3309D3F7;
					continue;
				case 115u:
					num = (int)((num2 * 223149637) ^ 0x2ADA4EAE);
					continue;
				case 114u:
					Form3.smethod_55((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -1043889774) ^ -1123225198;
					continue;
				case 112u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)NullButton);
					num = (int)(num2 * 1889392417) ^ -766861031;
					continue;
				case 111u:
					Form3.smethod_29((ButtonBase)(object)button4, (FlatStyle)0);
					num = (int)((num2 * 638311290) ^ 0x3822F982);
					continue;
				case 110u:
					NullButton = Form3.smethod_20();
					button1 = Form3.smethod_20();
					num = (int)((num2 * 1306324133) ^ 0x73A2FC69);
					continue;
				case 109u:
					Form3.smethod_30((Control)(object)button4, new Point(174, 137));
					num = ((int)num2 * -294885697) ^ -1336023403;
					continue;
				case 108u:
					Form3.smethod_32((Control)(object)button2, new Size(85, 21));
					num = ((int)num2 * -2053976192) ^ 0x4C8CC006;
					continue;
				case 107u:
					Form3.smethod_39((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = (int)(num2 * 2027829466) ^ -749214866;
					continue;
				case 106u:
					Form3.smethod_29((ButtonBase)(object)button7, (FlatStyle)0);
					num = (int)(num2 * 1660676171) ^ -111583520;
					continue;
				case 105u:
					Form3.smethod_31((Control)(object)textBox2, "textBox2");
					num = (int)(num2 * 1205205093) ^ -1987232814;
					continue;
				case 104u:
					Form3.smethod_33((Control)(object)button2, 1);
					num = (int)(num2 * 1814188642) ^ -620899593;
					continue;
				case 103u:
					Form3.smethod_33((Control)(object)button4, 4);
					num = ((int)num2 * -1589719832) ^ -1920684983;
					continue;
				case 102u:
					num = ((int)num2 * -390869351) ^ -91651909;
					continue;
				case 101u:
					Form3.smethod_36((Control)(object)button2, (EventHandler)Button2_Click);
					num = ((int)num2 * -1785781828) ^ -35513184;
					continue;
				case 100u:
					num = ((int)num2 * -2054996063) ^ 0x50D252DD;
					continue;
				case 99u:
					Form3.smethod_26((Control)(object)this, Color.White);
					num = (int)(num2 * 1117122882) ^ -2139341091;
					continue;
				case 98u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button7);
					num = ((int)num2 * -1435959529) ^ -1693675791;
					continue;
				case 97u:
					num = ((int)num2 * -1722174283) ^ -1575449982;
					continue;
				case 96u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox2);
					num = (int)(num2 * 866273334) ^ -143569992;
					continue;
				case 95u:
					num = (int)((num2 * 107910835) ^ 0x6D56F986);
					continue;
				case 94u:
					Form3.smethod_30((Control)(object)button7, new Point(174, 243));
					num = (int)(num2 * 1675744873) ^ -579530239;
					continue;
				case 93u:
					Form3.smethod_36((Control)(object)button7, (EventHandler)Button7_Click);
					num = ((int)num2 * -1189106390) ^ 0x50FF4FC4;
					continue;
				case 92u:
					Form3.smethod_26((Control)(object)NullButton, Color.Transparent);
					num = (int)(num2 * 1555254774) ^ -1025333906;
					continue;
				case 91u:
					num = ((int)num2 * -1908673531) ^ -1779411310;
					continue;
				case 90u:
					Form3.smethod_51((Control)(object)this, "Form3");
					num = (int)(num2 * 686279814) ^ -23911723;
					continue;
				case 89u:
					Form3.smethod_31((Control)(object)label1, "label1");
					num = (int)((num2 * 1896631404) ^ 0x49FD7BC6);
					continue;
				case 87u:
					num = (int)(num2 * 1951773888) ^ -1184070217;
					continue;
				case 86u:
					Form3.smethod_34((ButtonBase)(object)button4, bool_0: true);
					num = ((int)num2 * -2107963423) ^ -1736738893;
					continue;
				case 85u:
					num = (int)((num2 * 1278846916) ^ 0x3F41B639);
					continue;
				case 84u:
					num = ((int)num2 * -1223116215) ^ -1206151253;
					continue;
				case 83u:
					Form3.smethod_35((Control)(object)button1, "Вход");
					num = (int)(num2 * 884085911) ^ -1572257409;
					continue;
				case 82u:
					Form3.smethod_26((Control)(object)label1, Color.Transparent);
					num = (int)((num2 * 619032787) ^ 0x40FDDF64);
					continue;
				case 81u:
					Form3.smethod_33((Control)(object)button1, 0);
					num = ((int)num2 * -1362701780) ^ -1094384773;
					continue;
				case 80u:
					num = ((int)num2 * -587713605) ^ -678497318;
					continue;
				case 79u:
					textBox2 = Form3.smethod_21();
					errorProvider1 = Form3.smethod_23(components);
					Form3.smethod_24((ISupportInitialize)errorProvider1);
					num = (int)((num2 * 1755673109) ^ 0x7BAE61AF);
					continue;
				case 78u:
					num = ((int)num2 * -1381430485) ^ -81974514;
					continue;
				case 77u:
					num = ((int)num2 * -387046634) ^ -650287768;
					continue;
				case 76u:
					num = ((int)num2 * -1957843344) ^ 0x5BEACDF1;
					continue;
				case 75u:
					Form3.smethod_34((ButtonBase)(object)button2, bool_0: true);
					num = ((int)num2 * -1278782021) ^ 0x60CBDA20;
					continue;
				case 74u:
					Form3.smethod_29((ButtonBase)(object)button5, (FlatStyle)0);
					num = ((int)num2 * -155452389) ^ -1665416545;
					continue;
				case 73u:
					Form3.smethod_35((Control)(object)button2, "Регистрация");
					num = (int)((num2 * 724596523) ^ 0x4CF98758);
					continue;
				case 72u:
					num = (int)((num2 * 1285140241) ^ 0x7360A852);
					continue;
				case 71u:
					Form3.smethod_43((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)((num2 * 975629753) ^ 0x60E1141);
					continue;
				case 70u:
					num = ((int)num2 * -873782838) ^ 0x588DF4AA;
					continue;
				case 69u:
					Form3.smethod_49((Form)(object)this, bool_0: false);
					Form3.smethod_50((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1296410928) ^ -2027853620;
					continue;
				case 68u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button5), 0);
					num = ((int)num2 * -67794415) ^ -1463192942;
					continue;
				case 67u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button2);
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button1);
					num = (int)(num2 * 1416078174) ^ -2013301061;
					continue;
				case 66u:
					num = (int)(num2 * 1232370974) ^ -1029337127;
					continue;
				case 65u:
					Form3.smethod_38((Control)(object)button7, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 286391805) ^ -1990641465;
					continue;
				case 64u:
					Form3.smethod_40((Control)(object)label1, bool_0: true);
					num = (int)((num2 * 1685654269) ^ 0x51A983CC);
					continue;
				case 63u:
					Form3.smethod_31((Control)(object)button7, "button7");
					Form3.smethod_32((Control)(object)button7, new Size(140, 50));
					num = ((int)num2 * -387176464) ^ -577389409;
					continue;
				case 62u:
					Form3.smethod_42(errorProvider1, (ContainerControl)(object)this);
					num = (int)((num2 * 1547498392) ^ 0x26BB7333);
					continue;
				case 61u:
					num = (int)((num2 * 1091250129) ^ 0x5244B81);
					continue;
				case 60u:
					Form3.smethod_30((Control)(object)textBox1, new Point(174, 2));
					num = ((int)num2 * -1106674388) ^ -1862366040;
					continue;
				case 59u:
					button2 = Form3.smethod_20();
					num = (int)(num2 * 525070886) ^ -217849557;
					continue;
				case 58u:
					num = (int)((num2 * 1946840115) ^ 0xB33F3B3);
					continue;
				case 57u:
					num = (int)((num2 * 1163310344) ^ 0x37569E25);
					continue;
				case 56u:
					Form3.smethod_33((Control)(object)textBox1, 7);
					num = ((int)num2 * -394566931) ^ -1831101738;
					continue;
				case 55u:
					button4 = Form3.smethod_20();
					num = ((int)num2 * -1787958465) ^ 0x473BBBDE;
					continue;
				case 54u:
					Form3.smethod_33((Control)(object)textBox2, 8);
					num = ((int)num2 * -1565611191) ^ -164070759;
					continue;
				case 53u:
					Form3.smethod_38((Control)(object)button5, Form3.smethod_37("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form3.smethod_30((Control)(object)button5, new Point(174, 190));
					num = (int)(num2 * 811542113) ^ -958766763;
					continue;
				case 52u:
					num = (int)((num2 * 1601037322) ^ 0x499B3C32);
					continue;
				case 51u:
					Form3.smethod_35((Control)(object)button5, "Продолжить");
					num = (int)(num2 * 419563247) ^ -688051708;
					continue;
				case 50u:
					Form3.smethod_30((Control)(object)textBox2, new Point(174, 26));
					num = ((int)num2 * -1072975947) ^ 0x249E99F;
					continue;
				case 49u:
					Form3.smethod_33((Control)(object)button7, 6);
					num = ((int)num2 * -1770046722) ^ -2049424188;
					continue;
				case 48u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -663197717) ^ 0x49242F62;
					continue;
				case 47u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button5);
					num = ((int)num2 * -1091840599) ^ 0x5331BFE4;
					continue;
				case 46u:
					Form3.smethod_56((Control)(object)this, bool_0: false);
					Form3.smethod_57((Control)(object)this);
					num = ((int)num2 * -595421572) ^ 0x69C930BA;
					continue;
				case 45u:
					num = (int)((num2 * 841353863) ^ 0x2BE6A786);
					continue;
				case 44u:
					Form3.smethod_31((Control)(object)button5, "button5");
					Form3.smethod_32((Control)(object)button5, new Size(140, 50));
					num = (int)(num2 * 1459776375) ^ -1057574577;
					continue;
				case 43u:
					num = ((int)num2 * -1442299539) ^ -1928462038;
					continue;
				case 42u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button7), 0);
					num = ((int)num2 * -97352619) ^ -1065150371;
					continue;
				case 41u:
					Form3.smethod_39((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = (int)((num2 * 377149941) ^ 0x5B0135B7);
					continue;
				case 40u:
					Form3.smethod_35((Control)(object)button7, "Достижения");
					num = ((int)num2 * -1496205770) ^ -2017014890;
					continue;
				case 39u:
					Form3.smethod_36((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)((num2 * 363088364) ^ 0x479D5316);
					continue;
				case 38u:
					Form3.smethod_30((Control)(object)NullButton, new Point(-1, -1));
					Form3.smethod_31((Control)(object)NullButton, "NullButton");
					num = (int)((num2 * 525976784) ^ 0x625D99EA);
					continue;
				case 37u:
					textBox1 = Form3.smethod_21();
					label1 = Form3.smethod_22();
					num = ((int)num2 * -1057706360) ^ -723690053;
					continue;
				case 36u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)textBox1);
					num = ((int)num2 * -2059487979) ^ 0x7A5E15C6;
					continue;
				case 35u:
					Form3.smethod_38((Control)(object)label1, Form3.smethod_37("Mistral", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 640779656) ^ 0x74FCFD9B);
					continue;
				case 34u:
					num = ((int)num2 * -1430637811) ^ -1684356246;
					continue;
				case 33u:
					button7 = Form3.smethod_20();
					num = ((int)num2 * -1463141754) ^ -789100711;
					continue;
				case 32u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)NullButton), 0);
					num = (int)((num2 * 340967342) ^ 0x6C01B147);
					continue;
				case 31u:
					num = (int)(num2 * 2068968666) ^ -707342433;
					continue;
				case 30u:
					num = (int)(num2 * 209736305) ^ -966623298;
					continue;
				case 29u:
					Form3.smethod_30((Control)(object)button1, new Point(265, 49));
					num = ((int)num2 * -901814545) ^ -458015459;
					continue;
				case 28u:
					Form3.smethod_54((Form)(object)this, bool_0: true);
					num = ((int)num2 * -1713244705) ^ -316864916;
					continue;
				case 27u:
					Form3.smethod_35((Control)(object)button4, "Начало игры");
					num = (int)((num2 * 686630850) ^ 0x74FAC28C);
					continue;
				case 26u:
					Form3.smethod_32((Control)(object)button1, new Size(49, 21));
					num = (int)((num2 * 672308839) ^ 0x5F18D151);
					continue;
				case 25u:
					Form3.smethod_30((Control)(object)label1, new Point(140, 70));
					num = (int)((num2 * 1927872418) ^ 0x19ADBBE5);
					continue;
				case 24u:
					Form3.smethod_31((Control)(object)button1, "button1");
					num = (int)(num2 * 760283894) ^ -1398266590;
					continue;
				case 23u:
					Form3.smethod_14((Control)(object)button4, bool_0: false);
					num = (int)((num2 * 1684609295) ^ 0x68661815);
					continue;
				case 22u:
					Form3.smethod_34((ButtonBase)(object)button7, bool_0: true);
					num = (int)((num2 * 499833778) ^ 0x4984BD2F);
					continue;
				case 21u:
					Form3.smethod_29((ButtonBase)(object)NullButton, (FlatStyle)0);
					num = (int)(num2 * 2088218580) ^ -120966634;
					continue;
				case 20u:
					num = ((int)num2 * -1733333055) ^ -989796432;
					continue;
				case 19u:
					Form3.smethod_28(Form3.smethod_27((ButtonBase)(object)button4), 0);
					num = (int)(num2 * 1673117442) ^ -1668689797;
					continue;
				case 18u:
					Form3.smethod_34((ButtonBase)(object)button1, bool_0: true);
					num = (int)(num2 * 1266420417) ^ -20983999;
					continue;
				case 17u:
					Form3.smethod_34((ButtonBase)(object)button5, bool_0: true);
					num = ((int)num2 * -1435718971) ^ -811109555;
					continue;
				case 16u:
					Form3.smethod_48((Form)(object)this, (FormBorderStyle)0);
					num = (int)(num2 * 297007972) ^ -1126923577;
					continue;
				case 15u:
					num = (int)(num2 * 1649476791) ^ -1161946491;
					continue;
				case 14u:
					Form3.smethod_31((Control)(object)button4, "button4");
					num = (int)(num2 * 1406808013) ^ -811059470;
					continue;
				case 13u:
					num = ((int)num2 * -1462493258) ^ -207656680;
					continue;
				case 12u:
					num = ((int)num2 * -1860374396) ^ 0x3F9CF523;
					continue;
				case 11u:
					Form3.smethod_47(Form3.smethod_46((Control)(object)this), (Control)(object)button4);
					num = (int)((num2 * 1547719916) ^ 0x6E19999D);
					continue;
				case 10u:
					Form3.smethod_30((Control)(object)button2, new Point(174, 49));
					Form3.smethod_31((Control)(object)button2, "button2");
					num = (int)(num2 * 1745701241) ^ -31411194;
					continue;
				case 9u:
					Form3.smethod_41(textBox2, bool_0: true);
					num = ((int)num2 * -694817782) ^ 0x38688E25;
					continue;
				case 8u:
					num = (int)(num2 * 856031778) ^ -568115141;
					continue;
				case 7u:
					Form3.smethod_36((Control)(object)button5, (EventHandler)Button5_Click);
					num = ((int)num2 * -3106936) ^ -871710638;
					continue;
				case 6u:
					num = (int)(num2 * 373793288) ^ -214147774;
					continue;
				case 5u:
					Form3.smethod_32((Control)(object)textBox1, new Size(140, 20));
					num = (int)(num2 * 1146065049) ^ -60098261;
					continue;
				case 4u:
					Form3.smethod_25((Control)(object)this);
					num = ((int)num2 * -622785992) ^ -1145220302;
					continue;
				case 3u:
					Form3.smethod_33((Control)(object)button5, 5);
					num = ((int)num2 * -1882976136) ^ -1112343928;
					continue;
				case 2u:
					num = ((int)num2 * -537283564) ^ 0x6BE72215;
					continue;
				case 1u:
					num = (int)((num2 * 1621862860) ^ 0x69E4F309);
					continue;
				case 0u:
					Form3.smethod_32((Control)(object)NullButton, new Size(1, 1));
					num = (int)((num2 * 1407817970) ^ 0x30C48AA4);
					continue;
				default:
					return;
				case 113u:
					break;
				case 88u:
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
