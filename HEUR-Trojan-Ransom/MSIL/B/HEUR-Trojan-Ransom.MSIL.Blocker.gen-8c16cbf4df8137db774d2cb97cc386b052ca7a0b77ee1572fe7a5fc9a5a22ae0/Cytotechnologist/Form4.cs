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
		while (true)
		{
			int num = -2040717349;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD52743FAu) % 4u)
				{
				case 3u:
					InitializeComponent();
					num = (int)((num2 * 1291999157) ^ 0x4B827BD);
					continue;
				case 1u:
					num = ((int)num2 * -1784891741) ^ -1122694866;
					continue;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	private void Form4_FormClosing(object sender, FormClosingEventArgs e)
	{
		Form4.smethod_1((Control)(object)Form4.smethod_0((Form)(object)this), bool_0: true);
		while (true)
		{
			int num = -537885201;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA15D5AA3u) % 3u)
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
				num = ((int)num2 * -850446132) ^ 0x31C20AAA;
			}
		}
	}

	private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
	{
		while (true)
		{
			int num = -1050526148;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD2E6D465u) % 4u)
				{
				case 2u:
					Form4.smethod_3(e, bool_0: true);
					num = ((int)num2 * -1689846913) ^ -461586193;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (Form4.smethod_2(e) == ' ')
					{
						num3 = 1171369158;
						num4 = 1171369158;
					}
					else
					{
						num3 = 1153682608;
						num4 = 1153682608;
					}
					num = num3 ^ ((int)num2 * -111352695);
					continue;
				}
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
		while (true)
		{
			int num = -312290753;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD8F3AEE4u) % 3u)
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
				num = ((int)num2 * -489193982) ^ -600134928;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			goto IL_0016;
		}
		goto IL_009a;
		IL_0016:
		int num = -1687505914;
		goto IL_0062;
		IL_0062:
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x8CEB77F4u) % 7u)
			{
			case 6u:
				break;
			case 5u:
				num = (int)(num2 * 687835281) ^ -1987202113;
				continue;
			case 4u:
				num = (int)((num2 * 1236135799) ^ 0x31E4AACF);
				continue;
			case 3u:
				num = ((int)num2 * -518134098) ^ -1001118194;
				continue;
			case 2u:
				Form4.smethod_5((IDisposable)components);
				num = ((int)num2 * -911066710) ^ -2086852504;
				continue;
			case 1u:
				goto IL_008f;
			default:
				((Form)this).Dispose(disposing);
				return;
			}
			break;
			IL_008f:
			if (components != null)
			{
				num = -692311303;
				num3 = -692311303;
				continue;
			}
			goto IL_009a;
		}
		goto IL_0016;
		IL_009a:
		num = -166990828;
		num3 = -166990828;
		goto IL_0062;
	}

	private void InitializeComponent()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Expected O, but got Unknown
		//IL_0684: Unknown result type (might be due to invalid IL or missing references)
		//IL_068e: Expected O, but got Unknown
		//IL_0713: Unknown result type (might be due to invalid IL or missing references)
		//IL_071d: Expected O, but got Unknown
		while (true)
		{
			int num = 2122735604;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x403CFDA6u) % 60u)
				{
				case 59u:
					Form4.smethod_28((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -967589815) ^ -1849359657;
					continue;
				case 58u:
					Form4.smethod_29((Form)(object)this, bool_0: false);
					num = ((int)num2 * -2024767666) ^ 0x2AE16E04;
					continue;
				case 57u:
					Form4.smethod_20((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -509102154) ^ -2032645822;
					continue;
				case 56u:
					Form4.smethod_17((Control)(object)textBox2, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)((num2 * 886096791) ^ 0x5268929B);
					continue;
				case 55u:
					Form4.smethod_33((Form)(object)this, bool_0: false);
					Form4.smethod_19((Control)(object)this, "Регистрация");
					num = (int)(num2 * 2110278942) ^ -1100922432;
					continue;
				case 54u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox2);
					num = (int)((num2 * 100294013) ^ 0x68814381);
					continue;
				case 52u:
					Form4.smethod_14((Control)(object)textBox1, new Size(140, 20));
					num = (int)(num2 * 303541501) ^ -1340120371;
					continue;
				case 51u:
					num = (int)((num2 * 1127917888) ^ 0x54585FF5);
					continue;
				case 50u:
					Form4.smethod_10((ISupportInitialize)errorProvider1);
					num = (int)(num2 * 850086615) ^ -2024332865;
					continue;
				case 49u:
					num = (int)((num2 * 1361358144) ^ 0x680F830);
					continue;
				case 48u:
					Form4.smethod_24((ContainerControl)(object)this, (AutoScaleMode)1);
					Form4.smethod_25((Form)(object)this, new Size(176, 114));
					num = ((int)num2 * -1738548320) ^ -1665594532;
					continue;
				case 47u:
					textBox3 = Form4.smethod_7();
					button1 = Form4.smethod_8();
					errorProvider1 = Form4.smethod_9(components);
					num = (int)(num2 * 859272157) ^ -629032613;
					continue;
				case 46u:
					Form4.smethod_35((ISupportInitialize)errorProvider1);
					num = (int)(num2 * 67454842) ^ -589068903;
					continue;
				case 45u:
					num = ((int)num2 * -1223340306) ^ -693776770;
					continue;
				case 44u:
					Form4.smethod_15((Control)(object)textBox3, 3);
					Form4.smethod_18(textBox3, bool_0: true);
					num = (int)((num2 * 1428546861) ^ 0x142F2421);
					continue;
				case 43u:
					num = ((int)num2 * -1343814847) ^ -960247380;
					continue;
				case 42u:
					components = Form4.smethod_6();
					num = (int)(num2 * 1864825967) ^ -1567834925;
					continue;
				case 41u:
					Form4.smethod_15((Control)(object)textBox2, 2);
					num = ((int)num2 * -1496526354) ^ 0x7563DB05;
					continue;
				case 40u:
					num = ((int)num2 * -452310980) ^ 0x627CD9FA;
					continue;
				case 39u:
					textBox1 = Form4.smethod_7();
					textBox2 = Form4.smethod_7();
					num = ((int)num2 * -427057501) ^ -426394808;
					continue;
				case 38u:
					Form4.smethod_12((Control)(object)textBox2, new Point(17, 33));
					num = (int)(num2 * 1446922297) ^ -1436010216;
					continue;
				case 37u:
					num = ((int)num2 * -836815368) ^ 0x639E057F;
					continue;
				case 36u:
					Form4.smethod_19((Control)(object)button1, "Добавить");
					num = ((int)num2 * -1863028783) ^ 0x75194BBB;
					continue;
				case 35u:
					Form4.smethod_15((Control)(object)button1, 0);
					num = ((int)num2 * -207841555) ^ -1422664307;
					continue;
				case 34u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)button1);
					num = (int)(num2 * 986572140) ^ -2060857387;
					continue;
				case 33u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox3);
					num = (int)(num2 * 1394788584) ^ -1217545040;
					continue;
				case 32u:
					Form4.smethod_12((Control)(object)textBox1, new Point(17, 7));
					num = ((int)num2 * -2126058325) ^ 0x638971FC;
					continue;
				case 31u:
					num = (int)(num2 * 394194376) ^ -596100793;
					continue;
				case 30u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox1);
					num = (int)(num2 * 18865812) ^ -315828691;
					continue;
				case 29u:
					num = ((int)num2 * -1825510848) ^ -2141422650;
					continue;
				case 28u:
					Form4.smethod_14((Control)(object)textBox3, new Size(140, 20));
					num = ((int)num2 * -208188024) ^ -831686254;
					continue;
				case 27u:
					Form4.smethod_13((Control)(object)textBox3, "textBox3");
					num = (int)(num2 * 1968262555) ^ -1158441677;
					continue;
				case 26u:
					Form4.smethod_30((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1011254915) ^ -1497120297;
					continue;
				case 25u:
					Form4.smethod_12((Control)(object)button1, new Point(52, 85));
					Form4.smethod_13((Control)(object)button1, "button1");
					num = (int)(num2 * 586885032) ^ -467567744;
					continue;
				case 24u:
					Form4.smethod_34((Form)(object)this, new FormClosingEventHandler(Form4_FormClosing));
					num = (int)(num2 * 579300453) ^ -1165869799;
					continue;
				case 23u:
					num = (int)(num2 * 1223492387) ^ -1312474138;
					continue;
				case 22u:
					Form4.smethod_14((Control)(object)button1, new Size(70, 23));
					num = ((int)num2 * -1052665069) ^ 0x39FCD2BB;
					continue;
				case 21u:
					num = ((int)num2 * -1596941306) ^ -732231169;
					continue;
				case 20u:
					Form4.smethod_13((Control)(object)textBox2, "textBox2");
					Form4.smethod_14((Control)(object)textBox2, new Size(140, 20));
					num = ((int)num2 * -1960480920) ^ -1283212898;
					continue;
				case 19u:
					Form4.smethod_16((Control)(object)textBox3, (EventHandler)TextBox_TextChanged);
					num = (int)(num2 * 418028720) ^ -975098155;
					continue;
				case 18u:
					Form4.smethod_21((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -1878249095) ^ -670318996;
					continue;
				case 17u:
					Form4.smethod_12((Control)(object)textBox3, new Point(17, 59));
					num = (int)(num2 * 1791956442) ^ -1982925777;
					continue;
				case 15u:
					num = ((int)num2 * -2140494001) ^ 0x59C406F5;
					continue;
				case 14u:
					Form4.smethod_11((Control)(object)this);
					num = ((int)num2 * -647167378) ^ 0x5D62EE9A;
					continue;
				case 13u:
					Form4.smethod_18(textBox2, bool_0: true);
					Form4.smethod_16((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = (int)(num2 * 118984616) ^ -1870234329;
					continue;
				case 12u:
					num = (int)(num2 * 1887049203) ^ -403432609;
					continue;
				case 11u:
					num = ((int)num2 * -1594970408) ^ 0x1D92393C;
					continue;
				case 10u:
					Form4.smethod_31((Control)(object)this, "Form4");
					num = ((int)num2 * -1197519917) ^ 0x1D44DAA0;
					continue;
				case 9u:
					num = ((int)num2 * -427111950) ^ 0x12217DFD;
					continue;
				case 8u:
					Form4.smethod_22(errorProvider1, (ContainerControl)(object)this);
					Form4.smethod_23((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -677058149) ^ -1723749606;
					continue;
				case 7u:
					Form4.smethod_36((Control)(object)this, bool_0: false);
					num = (int)(num2 * 68613993) ^ -590673283;
					continue;
				case 6u:
					Form4.smethod_13((Control)(object)textBox1, "textBox1");
					num = (int)(num2 * 1224862998) ^ -364393278;
					continue;
				case 5u:
					Form4.smethod_17((Control)(object)textBox3, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)((num2 * 1151010924) ^ 0x72892A2B);
					continue;
				case 4u:
					Form4.smethod_32((Form)(object)this, bool_0: false);
					num = (int)(num2 * 2192274) ^ -1592701121;
					continue;
				case 3u:
					num = ((int)num2 * -890115031) ^ -772438993;
					continue;
				case 2u:
					num = (int)((num2 * 1586939172) ^ 0x69A7AE22);
					continue;
				case 1u:
					Form4.smethod_15((Control)(object)textBox1, 1);
					num = ((int)num2 * -775396745) ^ -1748485033;
					continue;
				case 0u:
					Form4.smethod_16((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					Form4.smethod_17((Control)(object)textBox1, new KeyPressEventHandler(TextBox_KeyPress));
					num = ((int)num2 * -1885626521) ^ 0xC11B157;
					continue;
				case 53u:
					break;
				default:
					Form4.smethod_37((Control)(object)this);
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
