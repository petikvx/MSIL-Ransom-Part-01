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
			int num = 488871327;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6444FCADu) % 3u)
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
				num = (int)(num2 * 223093299) ^ -2005959551;
			}
		}
	}

	private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
	{
		bool flag = Form4.smethod_2(e) == ' ';
		while (true)
		{
			int num = 1588721338;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7039793Fu) % 5u)
				{
				case 4u:
					num = ((int)num2 * -1285229662) ^ 0x1BF6A407;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 488881414;
						num4 = 488881414;
					}
					else
					{
						num3 = 229612248;
						num4 = 229612248;
					}
					num = num3 ^ (int)(num2 * 1780238143);
					continue;
				}
				case 1u:
					Form4.smethod_3(e, bool_0: true);
					num = ((int)num2 * -615310714) ^ -1127699039;
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
		Form4.smethod_4(errorProvider1);
	}

	protected override void Dispose(bool disposing)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = 827019538;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x58930A0Eu) % 9u)
				{
				case 8u:
					num3 = ((components != null) ? 1 : 0);
					goto IL_000f;
				case 7u:
					num = ((int)num2 * -1879194543) ^ 0x7B236746;
					continue;
				case 6u:
					Form4.smethod_5((IDisposable)components);
					num = ((int)num2 * -317936694) ^ 0x6EA246ED;
					continue;
				case 5u:
					((Form)this).Dispose(disposing);
					num = 680604012;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1019228646;
						num5 = 1019228646;
					}
					else
					{
						num4 = 660416063;
						num5 = 660416063;
					}
					num = num4 ^ (int)(num2 * 521573280);
					continue;
				}
				case 2u:
					if (disposing)
					{
						num = ((int)num2 * -960873229) ^ 0x1B9ED640;
						continue;
					}
					num3 = 0;
					goto IL_000f;
				case 0u:
					num = ((int)num2 * -1253828441) ^ 0x66787831;
					continue;
				default:
					return;
				case 3u:
					break;
				case 1u:
					return;
					IL_000f:
					flag = (byte)num3 != 0;
					num = 42042014;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected O, but got Unknown
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Expected O, but got Unknown
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d5: Expected O, but got Unknown
		while (true)
		{
			int num = -87926311;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAB8C10EBu) % 55u)
				{
				case 54u:
					num = (int)(num2 * 688880642) ^ -998656017;
					continue;
				case 53u:
					Form4.smethod_12((Control)(object)textBox1, new Point(17, 7));
					Form4.smethod_13((Control)(object)textBox1, "textBox1");
					num = (int)(num2 * 274533347) ^ -70663844;
					continue;
				case 52u:
					num = ((int)num2 * -1531680069) ^ -879334555;
					continue;
				case 51u:
					Form4.smethod_21((Control)(object)button1, (EventHandler)Button1_Click);
					Form4.smethod_22(errorProvider1, (ContainerControl)(object)this);
					num = ((int)num2 * -1276856180) ^ -1023610648;
					continue;
				case 50u:
					Form4.smethod_14((Control)(object)textBox2, new Size(140, 20));
					num = (int)((num2 * 1826603460) ^ 0x64038B77);
					continue;
				case 49u:
					Form4.smethod_12((Control)(object)textBox3, new Point(17, 59));
					Form4.smethod_13((Control)(object)textBox3, "textBox3");
					num = ((int)num2 * -678606803) ^ -1991337873;
					continue;
				case 48u:
					Form4.smethod_12((Control)(object)textBox2, new Point(17, 33));
					num = ((int)num2 * -1404243638) ^ 0x1DE4613B;
					continue;
				case 47u:
					Form4.smethod_37((Control)(object)this);
					num = ((int)num2 * -589871073) ^ -1862683400;
					continue;
				case 46u:
					errorProvider1 = Form4.smethod_9(components);
					Form4.smethod_10((ISupportInitialize)errorProvider1);
					num = (int)(num2 * 379546866) ^ -1727122633;
					continue;
				case 45u:
					Form4.smethod_23((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -63642864) ^ 0x1D5BA6A6;
					continue;
				case 44u:
					Form4.smethod_17((Control)(object)textBox3, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)(num2 * 482077932) ^ -1708756091;
					continue;
				case 43u:
					Form4.smethod_15((Control)(object)textBox2, 2);
					Form4.smethod_18(textBox2, bool_0: true);
					num = ((int)num2 * -1959922619) ^ -471726170;
					continue;
				case 42u:
					Form4.smethod_34((Form)(object)this, new FormClosingEventHandler(Form4_FormClosing));
					Form4.smethod_35((ISupportInitialize)errorProvider1);
					num = (int)((num2 * 764009471) ^ 0x42BED72D);
					continue;
				case 41u:
					num = ((int)num2 * -1292691934) ^ -1488045072;
					continue;
				case 40u:
					Form4.smethod_25((Form)(object)this, new Size(176, 114));
					num = (int)((num2 * 159342429) ^ 0x39C3BD1F);
					continue;
				case 38u:
					Form4.smethod_12((Control)(object)button1, new Point(52, 85));
					num = ((int)num2 * -177044888) ^ -972135175;
					continue;
				case 37u:
					Form4.smethod_28((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -1995038798) ^ -1816479828;
					continue;
				case 36u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox1);
					num = ((int)num2 * -1066776809) ^ 0x3363148A;
					continue;
				case 35u:
					Form4.smethod_18(textBox3, bool_0: true);
					num = ((int)num2 * -1453785994) ^ -922756965;
					continue;
				case 34u:
					Form4.smethod_11((Control)(object)this);
					num = ((int)num2 * -883851582) ^ -1573071638;
					continue;
				case 32u:
					Form4.smethod_15((Control)(object)textBox1, 1);
					num = (int)(num2 * 656191827) ^ -1215398824;
					continue;
				case 31u:
					num = ((int)num2 * -1148573305) ^ 0xC39FFA8;
					continue;
				case 30u:
					Form4.smethod_16((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -1647274844) ^ -1572193230;
					continue;
				case 29u:
					num = ((int)num2 * -199711750) ^ -664360766;
					continue;
				case 28u:
					num = (int)(num2 * 1921590775) ^ -568049579;
					continue;
				case 27u:
					num = ((int)num2 * -898955610) ^ -1943800013;
					continue;
				case 26u:
					Form4.smethod_16((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					Form4.smethod_17((Control)(object)textBox2, new KeyPressEventHandler(TextBox_KeyPress));
					num = ((int)num2 * -2085786867) ^ 0x4AA31098;
					continue;
				case 25u:
					Form4.smethod_32((Form)(object)this, bool_0: false);
					num = ((int)num2 * -423945841) ^ 0x7AEC4ED3;
					continue;
				case 24u:
					Form4.smethod_29((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1340332653) ^ -1305232906;
					continue;
				case 23u:
					Form4.smethod_15((Control)(object)button1, 0);
					Form4.smethod_19((Control)(object)button1, "Добавить");
					num = (int)(num2 * 419320296) ^ -1319843692;
					continue;
				case 22u:
					num = (int)(num2 * 1142766021) ^ -997356770;
					continue;
				case 21u:
					Form4.smethod_30((Form)(object)this, bool_0: false);
					num = ((int)num2 * -192900911) ^ 0x3575A7C1;
					continue;
				case 20u:
					Form4.smethod_33((Form)(object)this, bool_0: false);
					num = (int)((num2 * 81144407) ^ 0x5C4EB948);
					continue;
				case 19u:
					Form4.smethod_15((Control)(object)textBox3, 3);
					num = (int)(num2 * 1138350205) ^ -135393037;
					continue;
				case 18u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -515594735) ^ -206057051;
					continue;
				case 17u:
					num = (int)((num2 * 301859458) ^ 0x5A780D7);
					continue;
				case 16u:
					Form4.smethod_13((Control)(object)button1, "button1");
					num = ((int)num2 * -1847614753) ^ -759235288;
					continue;
				case 15u:
					Form4.smethod_17((Control)(object)textBox1, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)((num2 * 668182252) ^ 0x75897E57);
					continue;
				case 14u:
					Form4.smethod_36((Control)(object)this, bool_0: false);
					num = (int)((num2 * 1099912314) ^ 0x6E358D34);
					continue;
				case 13u:
					num = ((int)num2 * -752696914) ^ -1270171665;
					continue;
				case 12u:
					components = Form4.smethod_6();
					textBox1 = Form4.smethod_7();
					textBox2 = Form4.smethod_7();
					textBox3 = Form4.smethod_7();
					button1 = Form4.smethod_8();
					num = ((int)num2 * -946960172) ^ -2058555954;
					continue;
				case 11u:
					Form4.smethod_13((Control)(object)textBox2, "textBox2");
					num = (int)((num2 * 696367996) ^ 0x3B92ECC3);
					continue;
				case 10u:
					Form4.smethod_19((Control)(object)this, "Регистрация");
					num = (int)(num2 * 1436102878) ^ -41964240;
					continue;
				case 9u:
					Form4.smethod_20((ButtonBase)(object)button1, bool_0: true);
					num = (int)(num2 * 869107776) ^ -251034475;
					continue;
				case 8u:
					Form4.smethod_14((Control)(object)textBox3, new Size(140, 20));
					num = (int)((num2 * 593821178) ^ 0x18D043DF);
					continue;
				case 7u:
					num = (int)((num2 * 759938138) ^ 0x28984216);
					continue;
				case 6u:
					Form4.smethod_31((Control)(object)this, "Form4");
					num = ((int)num2 * -920606963) ^ -1879118598;
					continue;
				case 5u:
					Form4.smethod_14((Control)(object)textBox1, new Size(140, 20));
					num = ((int)num2 * -1609380438) ^ -1435840961;
					continue;
				case 4u:
					Form4.smethod_16((Control)(object)textBox3, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -925626791) ^ 0x2C1C943D;
					continue;
				case 3u:
					num = ((int)num2 * -1245628232) ^ -119831152;
					continue;
				case 2u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox3);
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox2);
					num = (int)(num2 * 1184731361) ^ -495191595;
					continue;
				case 1u:
					Form4.smethod_14((Control)(object)button1, new Size(70, 23));
					num = ((int)num2 * -573145474) ^ 0xD16661A;
					continue;
				case 0u:
					Form4.smethod_24((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 1233967906) ^ 0x29B43242);
					continue;
				default:
					return;
				case 39u:
					break;
				case 33u:
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
