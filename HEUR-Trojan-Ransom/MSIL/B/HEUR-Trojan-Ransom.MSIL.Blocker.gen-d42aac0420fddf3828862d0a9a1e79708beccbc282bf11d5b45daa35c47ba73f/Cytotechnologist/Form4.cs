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
		while (true)
		{
			int num = 286857704;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4BB6AD89u) % 3u)
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
				num = (int)((num2 * 1827240311) ^ 0x6BA103B0);
			}
		}
	}

	private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -53982187;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD82C3AE1u) % 5u)
				{
				case 4u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -144685257;
						num4 = -144685257;
					}
					else
					{
						num3 = -649578580;
						num4 = -649578580;
					}
					num = num3 ^ ((int)num2 * -929699168);
					continue;
				}
				case 2u:
					Form4.smethod_3(e, bool_0: true);
					num = (int)(num2 * 469593660) ^ -235351196;
					continue;
				case 1u:
					flag = Form4.smethod_2(e) == ' ';
					num = ((int)num2 * -1411245686) ^ -1386417522;
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

	private void Button1_Click(object sender, EventArgs e)
	{
	}

	private void TextBox_TextChanged(object sender, EventArgs e)
	{
		Form4.smethod_4(errorProvider1);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			goto IL_0032;
		}
		int num = 0;
		goto IL_009f;
		IL_009f:
		bool flag = (byte)num != 0;
		int num2 = 860348434;
		goto IL_0069;
		IL_0032:
		num2 = 1175694243;
		goto IL_0069;
		IL_0069:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x1A469DCEu) % 7u)
			{
			case 5u:
				num2 = ((int)num3 * -1015974777) ^ -1269674725;
				continue;
			case 4u:
				Form4.smethod_5((IDisposable)components);
				num2 = (int)((num3 * 1962330779) ^ 0x4CE2DFA3);
				continue;
			case 3u:
				break;
			case 2u:
				((Form)this).Dispose(disposing);
				num2 = 1536084236;
				continue;
			case 0u:
			{
				int num4;
				int num5;
				if (flag)
				{
					num4 = 1946578879;
					num5 = 1946578879;
				}
				else
				{
					num4 = 1639287845;
					num5 = 1639287845;
				}
				num2 = num4 ^ ((int)num3 * -379488059);
				continue;
			}
			default:
				return;
			case 6u:
				goto IL_0096;
			case 1u:
				return;
			}
			break;
		}
		goto IL_0032;
		IL_0096:
		num = ((components != null) ? 1 : 0);
		goto IL_009f;
	}

	private void InitializeComponent()
	{
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected O, but got Unknown
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0465: Expected O, but got Unknown
		//IL_061b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0625: Expected O, but got Unknown
		//IL_07b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07be: Expected O, but got Unknown
		components = Form4.smethod_6();
		while (true)
		{
			int num = -1233965112;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD596188Bu) % 73u)
				{
				case 72u:
					Form4.smethod_37((Control)(object)this);
					num = ((int)num2 * -348709329) ^ 0x65256401;
					continue;
				case 71u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox3);
					num = (int)((num2 * 1364642680) ^ 0x3F859998);
					continue;
				case 70u:
					Form4.smethod_16((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -569747944) ^ -1059193948;
					continue;
				case 69u:
					textBox3 = Form4.smethod_7();
					button1 = Form4.smethod_8();
					errorProvider1 = Form4.smethod_9(components);
					num = ((int)num2 * -494502800) ^ 0x419B655C;
					continue;
				case 68u:
					num = ((int)num2 * -2008992084) ^ -147875573;
					continue;
				case 67u:
					Form4.smethod_14((Control)(object)textBox2, new Size(140, 20));
					num = ((int)num2 * -1673603448) ^ -1048237134;
					continue;
				case 66u:
					Form4.smethod_12((Control)(object)textBox2, new Point(17, 33));
					num = (int)((num2 * 843644913) ^ 0x2DFDB424);
					continue;
				case 64u:
					Form4.smethod_15((Control)(object)button1, 0);
					num = (int)(num2 * 468429950) ^ -1117353355;
					continue;
				case 63u:
					num = ((int)num2 * -1820514501) ^ 0x1CC16059;
					continue;
				case 62u:
					num = (int)(num2 * 1069987999) ^ -1136483238;
					continue;
				case 60u:
					num = ((int)num2 * -417083811) ^ 0x323226F5;
					continue;
				case 59u:
					num = ((int)num2 * -1305323944) ^ 0x8D204;
					continue;
				case 58u:
					Form4.smethod_16((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = (int)((num2 * 1540107232) ^ 0x240A511F);
					continue;
				case 57u:
					Form4.smethod_14((Control)(object)button1, new Size(70, 23));
					num = (int)(num2 * 1370670134) ^ -2023863463;
					continue;
				case 56u:
					Form4.smethod_13((Control)(object)textBox2, "textBox2");
					num = ((int)num2 * -766738432) ^ -1054001985;
					continue;
				case 55u:
					Form4.smethod_28((Form)(object)this, (FormBorderStyle)1);
					num = (int)(num2 * 1223282325) ^ -198080171;
					continue;
				case 54u:
					num = ((int)num2 * -1743688811) ^ -1406656343;
					continue;
				case 53u:
					Form4.smethod_15((Control)(object)textBox2, 2);
					Form4.smethod_18(textBox2, bool_0: true);
					num = ((int)num2 * -138463075) ^ 0x6F3B5B74;
					continue;
				case 52u:
					Form4.smethod_16((Control)(object)textBox3, (EventHandler)TextBox_TextChanged);
					num = (int)(num2 * 540929358) ^ -1016911582;
					continue;
				case 51u:
					num = ((int)num2 * -1271417371) ^ -1518907814;
					continue;
				case 50u:
					Form4.smethod_13((Control)(object)button1, "button1");
					num = (int)((num2 * 1833230028) ^ 0x1AAF1273);
					continue;
				case 49u:
					Form4.smethod_36((Control)(object)this, bool_0: false);
					num = (int)(num2 * 718115025) ^ -146333039;
					continue;
				case 48u:
					num = (int)(num2 * 1011534359) ^ -2119657882;
					continue;
				case 47u:
					Form4.smethod_18(textBox3, bool_0: true);
					num = (int)(num2 * 846037914) ^ -1600421434;
					continue;
				case 46u:
					Form4.smethod_23((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -778695367) ^ -1527491722;
					continue;
				case 45u:
					num = ((int)num2 * -1312004813) ^ -504404346;
					continue;
				case 44u:
					num = (int)(num2 * 1305491389) ^ -1831721076;
					continue;
				case 43u:
					num = (int)((num2 * 1603596872) ^ 0x4A0F8B9E);
					continue;
				case 42u:
					Form4.smethod_17((Control)(object)textBox3, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)(num2 * 1763959996) ^ -1646032175;
					continue;
				case 41u:
					num = (int)((num2 * 884828801) ^ 0x1E640718);
					continue;
				case 40u:
					num = ((int)num2 * -826583977) ^ -1637174269;
					continue;
				case 39u:
					Form4.smethod_10((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -1089907650) ^ -419448063;
					continue;
				case 38u:
					num = (int)((num2 * 686796007) ^ 0x562465E2);
					continue;
				case 37u:
					num = (int)(num2 * 1441608859) ^ -384965138;
					continue;
				case 36u:
					Form4.smethod_19((Control)(object)button1, "Добавить");
					num = (int)(num2 * 1473598640) ^ -1533037768;
					continue;
				case 35u:
					Form4.smethod_33((Form)(object)this, bool_0: false);
					num = (int)((num2 * 434222824) ^ 0x600A3788);
					continue;
				case 34u:
					num = ((int)num2 * -1474265042) ^ 0x1C113526;
					continue;
				case 33u:
					Form4.smethod_30((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1608408914) ^ -884811340;
					continue;
				case 32u:
					Form4.smethod_31((Control)(object)this, "Form4");
					num = (int)(num2 * 1951094760) ^ -1825208672;
					continue;
				case 31u:
					Form4.smethod_17((Control)(object)textBox2, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)((num2 * 1512645002) ^ 0xD445E8B);
					continue;
				case 30u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox1);
					num = (int)(num2 * 2125682608) ^ -793970749;
					continue;
				case 29u:
					Form4.smethod_12((Control)(object)textBox1, new Point(17, 7));
					num = ((int)num2 * -732463885) ^ 0x7B67D7E2;
					continue;
				case 28u:
					num = ((int)num2 * -1897826920) ^ -969793443;
					continue;
				case 27u:
					Form4.smethod_35((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -906705608) ^ -2068023003;
					continue;
				case 26u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox2);
					num = ((int)num2 * -1223750247) ^ -973257084;
					continue;
				case 25u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -700991826) ^ -1982585515;
					continue;
				case 24u:
					Form4.smethod_21((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)((num2 * 757219543) ^ 0x27413869);
					continue;
				case 23u:
					Form4.smethod_32((Form)(object)this, bool_0: false);
					num = (int)(num2 * 256889902) ^ -620591459;
					continue;
				case 22u:
					Form4.smethod_24((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 1160201300) ^ 0x174D4F97);
					continue;
				case 21u:
					Form4.smethod_19((Control)(object)this, "Регистрация");
					num = (int)(num2 * 110881271) ^ -2122149528;
					continue;
				case 20u:
					Form4.smethod_22(errorProvider1, (ContainerControl)(object)this);
					num = (int)(num2 * 693423983) ^ -800401589;
					continue;
				case 19u:
					Form4.smethod_12((Control)(object)button1, new Point(52, 85));
					num = ((int)num2 * -258723202) ^ -1596629413;
					continue;
				case 18u:
					Form4.smethod_20((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -844625062) ^ 0x4EC643B1;
					continue;
				case 17u:
					Form4.smethod_17((Control)(object)textBox1, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)((num2 * 2094189776) ^ 0x370F0759);
					continue;
				case 16u:
					Form4.smethod_29((Form)(object)this, bool_0: false);
					num = (int)((num2 * 1662116955) ^ 0x478AD53B);
					continue;
				case 15u:
					num = (int)(num2 * 1559513517) ^ -148718262;
					continue;
				case 14u:
					num = (int)((num2 * 2101790706) ^ 0x55ECB6A5);
					continue;
				case 13u:
					num = ((int)num2 * -644464095) ^ -375363158;
					continue;
				case 12u:
					Form4.smethod_13((Control)(object)textBox1, "textBox1");
					num = (int)((num2 * 917872281) ^ 0x27CE079);
					continue;
				case 11u:
					Form4.smethod_11((Control)(object)this);
					num = (int)((num2 * 1430617274) ^ 0x61AB7D8);
					continue;
				case 10u:
					num = ((int)num2 * -1129061177) ^ -993555796;
					continue;
				case 9u:
					textBox1 = Form4.smethod_7();
					textBox2 = Form4.smethod_7();
					num = (int)(num2 * 586375183) ^ -1368665501;
					continue;
				case 8u:
					Form4.smethod_25((Form)(object)this, new Size(176, 114));
					num = ((int)num2 * -1162798462) ^ -584562135;
					continue;
				case 7u:
					Form4.smethod_12((Control)(object)textBox3, new Point(17, 59));
					Form4.smethod_13((Control)(object)textBox3, "textBox3");
					Form4.smethod_14((Control)(object)textBox3, new Size(140, 20));
					Form4.smethod_15((Control)(object)textBox3, 3);
					num = (int)((num2 * 719477212) ^ 0x3A9CA3D6);
					continue;
				case 6u:
					Form4.smethod_14((Control)(object)textBox1, new Size(140, 20));
					num = ((int)num2 * -559478142) ^ 0x4CC6BF43;
					continue;
				case 5u:
					num = ((int)num2 * -1675979467) ^ -517479229;
					continue;
				case 4u:
					Form4.smethod_34((Form)(object)this, new FormClosingEventHandler(Form4_FormClosing));
					num = (int)(num2 * 200416079) ^ -1050708476;
					continue;
				case 3u:
					num = (int)((num2 * 24369901) ^ 0x1AFB0280);
					continue;
				case 2u:
					num = ((int)num2 * -1527714126) ^ -1965297618;
					continue;
				case 1u:
					num = ((int)num2 * -1220990448) ^ -1365213181;
					continue;
				case 0u:
					Form4.smethod_15((Control)(object)textBox1, 1);
					num = (int)((num2 * 1688310460) ^ 0x2B09E43B);
					continue;
				default:
					return;
				case 61u:
					break;
				case 65u:
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
