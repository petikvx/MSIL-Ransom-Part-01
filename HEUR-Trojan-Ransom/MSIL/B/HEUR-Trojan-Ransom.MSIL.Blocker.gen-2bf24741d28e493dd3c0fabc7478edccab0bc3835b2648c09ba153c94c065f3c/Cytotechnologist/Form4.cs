using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Cytotechnologist;

public class Form4 : Form
{
	private IContainer components = null;

	private TextBox textBox1;

	private TextBox textBox2;

	private TextBox textBox3;

	private Button button1;

	private ErrorProvider errorProvider1;

	public Form4()
	{
		InitializeComponent();
	}

	private void Form4_FormClosing(object sender, FormClosingEventArgs e)
	{
		Form4.smethod_1((Control)(object)Form4.smethod_0((Form)(object)this), bool_0: true);
	}

	private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
	{
		bool flag = Form4.smethod_2(e) == ' ';
		while (true)
		{
			int num = -577284786;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB0750A21u) % 5u)
				{
				case 2u:
					num = ((int)num2 * -284610869) ^ -874331906;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1473493554;
						num4 = 1473493554;
					}
					else
					{
						num3 = 383106795;
						num4 = 383106795;
					}
					num = num3 ^ (int)(num2 * 418445963);
					continue;
				}
				case 0u:
					Form4.smethod_3(e, bool_0: true);
					num = ((int)num2 * -1865705667) ^ -271348151;
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

	private void Button1_Click(object sender, EventArgs e)
	{
	}

	private void TextBox_TextChanged(object sender, EventArgs e)
	{
		Form4.smethod_4(errorProvider1);
	}

	protected override void Dispose(bool disposing)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -283368998;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xEFF09C3Eu) % 8u)
				{
				case 7u:
					num3 = ((components != null) ? 1 : 0);
					goto IL_000f;
				case 6u:
					num = (int)((num2 * 1934457099) ^ 0x1B332175);
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -812876333;
						num5 = -812876333;
					}
					else
					{
						num4 = -604796623;
						num5 = -604796623;
					}
					num = num4 ^ ((int)num2 * -1837824157);
					continue;
				}
				case 4u:
					if (disposing)
					{
						num = ((int)num2 * -471697) ^ -1211216787;
						continue;
					}
					num3 = 0;
					goto IL_000f;
				case 2u:
					Form4.smethod_5((IDisposable)components);
					num = ((int)num2 * -1143715166) ^ 0x76EDDB4A;
					continue;
				case 0u:
					((Form)this).Dispose(disposing);
					num = -1687403008;
					continue;
				default:
					return;
				case 3u:
					break;
				case 1u:
					return;
					IL_000f:
					flag = (byte)num3 != 0;
					num = -907868565;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected O, but got Unknown
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected O, but got Unknown
		//IL_0719: Unknown result type (might be due to invalid IL or missing references)
		//IL_0723: Expected O, but got Unknown
		components = Form4.smethod_6();
		while (true)
		{
			int num = -1601711173;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8D2E2D46u) % 67u)
				{
				case 66u:
					num = (int)((num2 * 696741541) ^ 0x425CDDFA);
					continue;
				case 65u:
					Form4.smethod_14((Control)(object)textBox3, new Size(140, 20));
					num = ((int)num2 * -1470874739) ^ 0x3EB9016;
					continue;
				case 64u:
					Form4.smethod_11((Control)(object)this);
					num = (int)(num2 * 2120893339) ^ -870969543;
					continue;
				case 63u:
					Form4.smethod_24((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -334689641) ^ -384098027;
					continue;
				case 62u:
					num = ((int)num2 * -1246598123) ^ 0x532D4DC1;
					continue;
				case 61u:
					textBox1 = Form4.smethod_7();
					textBox2 = Form4.smethod_7();
					num = ((int)num2 * -1094525938) ^ 0x30EA3866;
					continue;
				case 60u:
					Form4.smethod_19((Control)(object)this, "Регистрация");
					num = (int)(num2 * 1797996726) ^ -1902963789;
					continue;
				case 59u:
					num = ((int)num2 * -945375772) ^ 0x68907AE4;
					continue;
				case 58u:
					num = (int)(num2 * 1733805271) ^ -652170245;
					continue;
				case 57u:
					Form4.smethod_18(textBox2, bool_0: true);
					Form4.smethod_16((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = (int)(num2 * 1355944645) ^ -1067105960;
					continue;
				case 56u:
					num = ((int)num2 * -1584726041) ^ 0x338B9C87;
					continue;
				case 55u:
					button1 = Form4.smethod_8();
					num = (int)((num2 * 146755755) ^ 0x2C89A5A4);
					continue;
				case 54u:
					num = ((int)num2 * -132288447) ^ 0x7A63A634;
					continue;
				case 53u:
					num = ((int)num2 * -2069466913) ^ 0x4C6A5D99;
					continue;
				case 52u:
					Form4.smethod_12((Control)(object)textBox1, new Point(17, 7));
					num = ((int)num2 * -2116633449) ^ 0x125D013A;
					continue;
				case 51u:
					num = ((int)num2 * -597010973) ^ -346012282;
					continue;
				case 50u:
					Form4.smethod_16((Control)(object)textBox3, (EventHandler)TextBox_TextChanged);
					Form4.smethod_17((Control)(object)textBox3, new KeyPressEventHandler(TextBox_KeyPress));
					num = ((int)num2 * -1528499770) ^ 0x77D02082;
					continue;
				case 49u:
					num = ((int)num2 * -533293537) ^ -1025264088;
					continue;
				case 48u:
					num = ((int)num2 * -1221952929) ^ 0x5DB30D55;
					continue;
				case 47u:
					Form4.smethod_13((Control)(object)textBox3, "textBox3");
					num = (int)((num2 * 10120378) ^ 0xF2F631B);
					continue;
				case 46u:
					num = (int)(num2 * 1764433273) ^ -172051220;
					continue;
				case 45u:
					Form4.smethod_32((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1975914899) ^ 0x702584EC;
					continue;
				case 44u:
					num = ((int)num2 * -2110282405) ^ -725070944;
					continue;
				case 43u:
					Form4.smethod_36((Control)(object)this, bool_0: false);
					num = ((int)num2 * -936368952) ^ 0x7CDB19EF;
					continue;
				case 42u:
					Form4.smethod_12((Control)(object)button1, new Point(52, 85));
					num = (int)((num2 * 77423189) ^ 0x66E949E3);
					continue;
				case 41u:
					Form4.smethod_37((Control)(object)this);
					num = ((int)num2 * -84894117) ^ 0x6710184A;
					continue;
				case 40u:
					num = (int)(num2 * 1815723782) ^ -322868727;
					continue;
				case 39u:
					Form4.smethod_23((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -66151648) ^ -2035949347;
					continue;
				case 38u:
					Form4.smethod_34((Form)(object)this, new FormClosingEventHandler(Form4_FormClosing));
					Form4.smethod_35((ISupportInitialize)errorProvider1);
					num = (int)(num2 * 1497241048) ^ -542703703;
					continue;
				case 37u:
					Form4.smethod_16((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					Form4.smethod_17((Control)(object)textBox1, new KeyPressEventHandler(TextBox_KeyPress));
					num = ((int)num2 * -1311061618) ^ 0x7255261D;
					continue;
				case 36u:
					Form4.smethod_25((Form)(object)this, new Size(176, 114));
					num = ((int)num2 * -531267178) ^ -1000288315;
					continue;
				case 35u:
					Form4.smethod_20((ButtonBase)(object)button1, bool_0: true);
					num = (int)(num2 * 2049674153) ^ -1354703535;
					continue;
				case 34u:
					Form4.smethod_19((Control)(object)button1, "Добавить");
					num = (int)(num2 * 607319017) ^ -1643486512;
					continue;
				case 33u:
					num = ((int)num2 * -1616535470) ^ -1469076020;
					continue;
				case 32u:
					Form4.smethod_14((Control)(object)textBox1, new Size(140, 20));
					num = ((int)num2 * -93303674) ^ 0x2F78426;
					continue;
				case 31u:
					Form4.smethod_13((Control)(object)textBox1, "textBox1");
					num = (int)(num2 * 455018184) ^ -1153840219;
					continue;
				case 30u:
					Form4.smethod_15((Control)(object)button1, 0);
					num = (int)((num2 * 2085392235) ^ 0x37C347F0);
					continue;
				case 29u:
					Form4.smethod_15((Control)(object)textBox3, 3);
					num = ((int)num2 * -1356048844) ^ -528104101;
					continue;
				case 28u:
					num = (int)((num2 * 139285681) ^ 0x6E34C7E2);
					continue;
				case 27u:
					Form4.smethod_33((Form)(object)this, bool_0: false);
					num = (int)(num2 * 2003668663) ^ -1764605900;
					continue;
				case 26u:
					textBox3 = Form4.smethod_7();
					num = (int)((num2 * 1434056093) ^ 0x255B6051);
					continue;
				case 25u:
					Form4.smethod_12((Control)(object)textBox3, new Point(17, 59));
					num = (int)((num2 * 1665449987) ^ 0x5A9E9A05);
					continue;
				case 24u:
					Form4.smethod_13((Control)(object)button1, "button1");
					num = (int)(num2 * 1276020911) ^ -1082652550;
					continue;
				case 23u:
					Form4.smethod_30((Form)(object)this, bool_0: false);
					num = ((int)num2 * -529578511) ^ -804335105;
					continue;
				case 22u:
					num = (int)((num2 * 995507531) ^ 0x4D988C72);
					continue;
				case 21u:
					Form4.smethod_29((Form)(object)this, bool_0: false);
					num = (int)((num2 * 323016809) ^ 0x4BF4428);
					continue;
				case 20u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -1428967731) ^ 0xF1720B2;
					continue;
				case 19u:
					Form4.smethod_22(errorProvider1, (ContainerControl)(object)this);
					num = (int)(num2 * 1732405170) ^ -579338923;
					continue;
				case 18u:
					num = (int)(num2 * 38411902) ^ -394050443;
					continue;
				case 17u:
					Form4.smethod_14((Control)(object)textBox2, new Size(140, 20));
					num = ((int)num2 * -1138959669) ^ 0x6E3CFE4F;
					continue;
				case 16u:
					Form4.smethod_18(textBox3, bool_0: true);
					num = ((int)num2 * -792171438) ^ 0x7FA2CB6A;
					continue;
				case 15u:
					errorProvider1 = Form4.smethod_9(components);
					Form4.smethod_10((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -40026747) ^ -268692836;
					continue;
				case 14u:
					Form4.smethod_15((Control)(object)textBox2, 2);
					num = (int)(num2 * 1574052734) ^ -323382021;
					continue;
				case 12u:
					Form4.smethod_21((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)((num2 * 97695612) ^ 0x24FA0D90);
					continue;
				case 11u:
					num = (int)(num2 * 1501916392) ^ -1677211184;
					continue;
				case 9u:
					Form4.smethod_14((Control)(object)button1, new Size(70, 23));
					num = ((int)num2 * -865973450) ^ -1682670501;
					continue;
				case 8u:
					num = ((int)num2 * -1786245829) ^ 0x3FE4C27D;
					continue;
				case 7u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox3);
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox2);
					num = ((int)num2 * -839298429) ^ -1859308581;
					continue;
				case 6u:
					Form4.smethod_12((Control)(object)textBox2, new Point(17, 33));
					Form4.smethod_13((Control)(object)textBox2, "textBox2");
					num = (int)((num2 * 1450135566) ^ 0x1D556DCC);
					continue;
				case 5u:
					Form4.smethod_17((Control)(object)textBox2, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)(num2 * 678987926) ^ -322515896;
					continue;
				case 4u:
					Form4.smethod_15((Control)(object)textBox1, 1);
					num = ((int)num2 * -1135559554) ^ 0x6A92E128;
					continue;
				case 3u:
					Form4.smethod_31((Control)(object)this, "Form4");
					num = (int)((num2 * 122500764) ^ 0x53EE6D5F);
					continue;
				case 2u:
					num = ((int)num2 * -943488557) ^ -1226288925;
					continue;
				case 1u:
					num = ((int)num2 * -406916812) ^ -495601423;
					continue;
				case 0u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox1);
					Form4.smethod_28((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -1138562526) ^ -1135082874;
					continue;
				default:
					return;
				case 13u:
					break;
				case 10u:
					return;
				}
				break;
			}
		}
	}

	static Form smethod_0(Form form_0)
	{
		return form_0.get_Owner();
	}

	static void smethod_1(Control control_0, bool bool_0)
	{
		control_0.set_Enabled(bool_0);
	}

	static char smethod_2(KeyPressEventArgs keyPressEventArgs_0)
	{
		return keyPressEventArgs_0.get_KeyChar();
	}

	static void smethod_3(KeyPressEventArgs keyPressEventArgs_0, bool bool_0)
	{
		keyPressEventArgs_0.set_Handled(bool_0);
	}

	static void smethod_4(ErrorProvider errorProvider_0)
	{
		errorProvider_0.Clear();
	}

	static void smethod_5(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Container smethod_6()
	{
		return new Container();
	}

	static TextBox smethod_7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TextBox();
	}

	static Button smethod_8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
	}

	static ErrorProvider smethod_9(IContainer icontainer_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new ErrorProvider(icontainer_0);
	}

	static void smethod_10(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.BeginInit();
	}

	static void smethod_11(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_12(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_13(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_14(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_15(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_16(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_TextChanged(eventHandler_0);
	}

	static void smethod_17(Control control_0, KeyPressEventHandler keyPressEventHandler_0)
	{
		control_0.add_KeyPress(keyPressEventHandler_0);
	}

	static void smethod_18(TextBox textBox_0, bool bool_0)
	{
		textBox_0.set_UseSystemPasswordChar(bool_0);
	}

	static void smethod_19(Control control_0, string string_0)
	{
		control_0.set_Text(string_0);
	}

	static void smethod_20(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_UseVisualStyleBackColor(bool_0);
	}

	static void smethod_21(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static void smethod_22(ErrorProvider errorProvider_0, ContainerControl containerControl_0)
	{
		errorProvider_0.set_ContainerControl(containerControl_0);
	}

	static void smethod_23(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_24(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_25(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static ControlCollection smethod_26(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_27(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_28(Form form_0, FormBorderStyle formBorderStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_FormBorderStyle(formBorderStyle_0);
	}

	static void smethod_29(Form form_0, bool bool_0)
	{
		form_0.set_MaximizeBox(bool_0);
	}

	static void smethod_30(Form form_0, bool bool_0)
	{
		form_0.set_MinimizeBox(bool_0);
	}

	static void smethod_31(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_32(Form form_0, bool bool_0)
	{
		form_0.set_ShowIcon(bool_0);
	}

	static void smethod_33(Form form_0, bool bool_0)
	{
		form_0.set_ShowInTaskbar(bool_0);
	}

	static void smethod_34(Form form_0, FormClosingEventHandler formClosingEventHandler_0)
	{
		form_0.add_FormClosing(formClosingEventHandler_0);
	}

	static void smethod_35(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_36(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_37(Control control_0)
	{
		control_0.PerformLayout();
	}
}
