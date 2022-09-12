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
			int num = -1386580955;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA3E0881Cu) % 3u)
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
				num = (int)((num2 * 523175291) ^ 0x4A8BE198);
			}
		}
	}

	private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (Form4.smethod_2(e) != ' ')
		{
			return;
		}
		while (true)
		{
			int num = 808431435;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x63C5164u) % 4u)
				{
				case 3u:
					Form4.smethod_3(e, bool_0: true);
					num = ((int)num2 * -1965197521) ^ -363005851;
					continue;
				case 0u:
					num = ((int)num2 * -933453131) ^ 0x61AD0649;
					continue;
				default:
					return;
				case 2u:
					break;
				case 1u:
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
			goto IL_0009;
		}
		int num = 0;
		goto IL_00dc;
		IL_00dc:
		bool flag = (byte)num != 0;
		int num2 = 1943725624;
		goto IL_0099;
		IL_0009:
		num2 = 337487900;
		goto IL_0099;
		IL_0099:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x34E0B4CAu) % 10u)
			{
			case 9u:
				break;
			case 8u:
			{
				int num4;
				int num5;
				if (flag)
				{
					num4 = 503387907;
					num5 = 503387907;
				}
				else
				{
					num4 = 1350379683;
					num5 = 1350379683;
				}
				num2 = num4 ^ (int)(num3 * 2110749709);
				continue;
			}
			case 7u:
				num2 = ((int)num3 * -445393116) ^ 0x97C92BD;
				continue;
			case 6u:
				num2 = ((int)num3 * -2109357862) ^ 0x4B8E838F;
				continue;
			case 5u:
				num2 = ((int)num3 * -860500611) ^ -234335856;
				continue;
			case 4u:
				num2 = (int)(num3 * 509416220) ^ -410289512;
				continue;
			case 3u:
				((Form)this).Dispose(disposing);
				num2 = 845500794;
				continue;
			case 1u:
				Form4.smethod_5((IDisposable)components);
				num2 = (int)(num3 * 2035527450) ^ -1519298052;
				continue;
			default:
				return;
			case 2u:
				goto IL_00d3;
			case 0u:
				return;
			}
			break;
		}
		goto IL_0009;
		IL_00d3:
		num = ((components != null) ? 1 : 0);
		goto IL_00dc;
	}

	private void InitializeComponent()
	{
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected O, but got Unknown
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Expected O, but got Unknown
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_041f: Expected O, but got Unknown
		//IL_0660: Unknown result type (might be due to invalid IL or missing references)
		//IL_066a: Expected O, but got Unknown
		components = Form4.smethod_6();
		while (true)
		{
			int num = -2068970928;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xACBAC639u) % 60u)
				{
				case 59u:
					Form4.smethod_12((Control)(object)textBox3, new Point(17, 59));
					num = (int)(num2 * 1824950761) ^ -866760253;
					continue;
				case 58u:
					Form4.smethod_12((Control)(object)button1, new Point(52, 85));
					num = (int)((num2 * 487540075) ^ 0x8D70FB9);
					continue;
				case 57u:
					Form4.smethod_20((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -2059314793) ^ -918795873;
					continue;
				case 55u:
					num = ((int)num2 * -1605076101) ^ 0x3998C68A;
					continue;
				case 54u:
					Form4.smethod_18(textBox3, bool_0: true);
					Form4.smethod_16((Control)(object)textBox3, (EventHandler)TextBox_TextChanged);
					num = (int)((num2 * 878781190) ^ 0x443DFC71);
					continue;
				case 53u:
					num = ((int)num2 * -201060039) ^ 0x61829A28;
					continue;
				case 52u:
					Form4.smethod_35((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -497483597) ^ 0x636407BB;
					continue;
				case 51u:
					Form4.smethod_22(errorProvider1, (ContainerControl)(object)this);
					num = (int)(num2 * 1462172914) ^ -1244661076;
					continue;
				case 50u:
					num = ((int)num2 * -1917671839) ^ -250030472;
					continue;
				case 49u:
					num = ((int)num2 * -1366073122) ^ 0x5D7A357;
					continue;
				case 48u:
					errorProvider1 = Form4.smethod_9(components);
					num = (int)(num2 * 1808269688) ^ -1030696400;
					continue;
				case 47u:
					num = (int)(num2 * 1933714577) ^ -2060655918;
					continue;
				case 46u:
					Form4.smethod_16((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = (int)(num2 * 962786899) ^ -547610124;
					continue;
				case 45u:
					Form4.smethod_13((Control)(object)textBox3, "textBox3");
					num = (int)((num2 * 225673144) ^ 0x1FF796DE);
					continue;
				case 44u:
					Form4.smethod_13((Control)(object)textBox1, "textBox1");
					num = (int)((num2 * 1965114622) ^ 0x124CE3A8);
					continue;
				case 43u:
					Form4.smethod_18(textBox2, bool_0: true);
					num = ((int)num2 * -783334658) ^ 0x78652379;
					continue;
				case 42u:
					Form4.smethod_19((Control)(object)button1, "Добавить");
					num = ((int)num2 * -419342947) ^ -1405247166;
					continue;
				case 41u:
					Form4.smethod_11((Control)(object)this);
					Form4.smethod_12((Control)(object)textBox1, new Point(17, 7));
					num = (int)((num2 * 726619977) ^ 0x1B950DCC);
					continue;
				case 40u:
					textBox2 = Form4.smethod_7();
					num = ((int)num2 * -865696635) ^ -2041770001;
					continue;
				case 39u:
					num = ((int)num2 * -1488305547) ^ 0x1AC9A324;
					continue;
				case 38u:
					textBox3 = Form4.smethod_7();
					button1 = Form4.smethod_8();
					num = (int)((num2 * 1636299609) ^ 0x1423FE1B);
					continue;
				case 37u:
					Form4.smethod_15((Control)(object)button1, 0);
					num = (int)((num2 * 1027377305) ^ 0x525526A);
					continue;
				case 35u:
					Form4.smethod_32((Form)(object)this, bool_0: false);
					num = (int)((num2 * 544685586) ^ 0xFB60DF7);
					continue;
				case 34u:
					Form4.smethod_34((Form)(object)this, new FormClosingEventHandler(Form4_FormClosing));
					num = (int)(num2 * 893474611) ^ -1559054693;
					continue;
				case 33u:
					Form4.smethod_19((Control)(object)this, "Регистрация");
					num = (int)((num2 * 561693984) ^ 0x56F2AD1E);
					continue;
				case 32u:
					Form4.smethod_21((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -564064142) ^ 0x3B6C7E2E;
					continue;
				case 31u:
					Form4.smethod_17((Control)(object)textBox1, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)((num2 * 1512231085) ^ 0x328110A);
					continue;
				case 30u:
					num = ((int)num2 * -384711718) ^ -149511118;
					continue;
				case 29u:
					Form4.smethod_10((ISupportInitialize)errorProvider1);
					num = (int)(num2 * 2095942602) ^ -1892812712;
					continue;
				case 28u:
					num = ((int)num2 * -903827942) ^ 0x6212311F;
					continue;
				case 27u:
					Form4.smethod_29((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1763007053) ^ -1923824005;
					continue;
				case 26u:
					Form4.smethod_28((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -1662657) ^ 0x33CF12A0;
					continue;
				case 25u:
					Form4.smethod_15((Control)(object)textBox1, 1);
					Form4.smethod_16((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -1011904299) ^ 0x3CED903E;
					continue;
				case 24u:
					Form4.smethod_17((Control)(object)textBox3, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)((num2 * 1823026736) ^ 0xF86DC93);
					continue;
				case 23u:
					Form4.smethod_23((ContainerControl)(object)this, new SizeF(6f, 13f));
					Form4.smethod_24((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -751775117) ^ -1192266583;
					continue;
				case 22u:
					Form4.smethod_14((Control)(object)textBox2, new Size(140, 20));
					Form4.smethod_15((Control)(object)textBox2, 2);
					num = ((int)num2 * -293325181) ^ 0x13D2617C;
					continue;
				case 21u:
					num = ((int)num2 * -120394290) ^ 0x23D0568E;
					continue;
				case 20u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox2);
					num = (int)(num2 * 1803985475) ^ -1213658334;
					continue;
				case 19u:
					Form4.smethod_30((Form)(object)this, bool_0: false);
					num = (int)(num2 * 781981215) ^ -310268931;
					continue;
				case 18u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox1);
					num = (int)(num2 * 449510141) ^ -555089463;
					continue;
				case 17u:
					num = (int)(num2 * 528748560) ^ -874440289;
					continue;
				case 16u:
					Form4.smethod_33((Form)(object)this, bool_0: false);
					num = ((int)num2 * -69522782) ^ -673333912;
					continue;
				case 15u:
					Form4.smethod_36((Control)(object)this, bool_0: false);
					num = (int)((num2 * 622690493) ^ 0x25DA1CB4);
					continue;
				case 14u:
					Form4.smethod_13((Control)(object)button1, "button1");
					num = ((int)num2 * -734642401) ^ -1919202485;
					continue;
				case 13u:
					Form4.smethod_31((Control)(object)this, "Form4");
					num = ((int)num2 * -2129469623) ^ -1829444193;
					continue;
				case 12u:
					Form4.smethod_25((Form)(object)this, new Size(176, 114));
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)button1);
					num = (int)(num2 * 364174210) ^ -918987424;
					continue;
				case 11u:
					Form4.smethod_14((Control)(object)textBox3, new Size(140, 20));
					num = ((int)num2 * -291915266) ^ -113760663;
					continue;
				case 10u:
					Form4.smethod_15((Control)(object)textBox3, 3);
					num = (int)((num2 * 1873890199) ^ 0xE41714E);
					continue;
				case 9u:
					Form4.smethod_14((Control)(object)textBox1, new Size(140, 20));
					num = ((int)num2 * -2023806809) ^ -1744941537;
					continue;
				case 8u:
					Form4.smethod_12((Control)(object)textBox2, new Point(17, 33));
					num = (int)((num2 * 48446776) ^ 0x95F1865);
					continue;
				case 7u:
					Form4.smethod_17((Control)(object)textBox2, new KeyPressEventHandler(TextBox_KeyPress));
					num = ((int)num2 * -1231246682) ^ 0x4C0DC0B3;
					continue;
				case 6u:
					Form4.smethod_13((Control)(object)textBox2, "textBox2");
					num = (int)(num2 * 350874320) ^ -811815233;
					continue;
				case 5u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox3);
					num = ((int)num2 * -271539483) ^ 0x4CAD26FF;
					continue;
				case 4u:
					num = ((int)num2 * -1071734293) ^ 0x747B2EFA;
					continue;
				case 3u:
					num = (int)(num2 * 1995993115) ^ -1340243;
					continue;
				case 2u:
					Form4.smethod_37((Control)(object)this);
					num = ((int)num2 * -1281248241) ^ -98486909;
					continue;
				case 1u:
					textBox1 = Form4.smethod_7();
					num = ((int)num2 * -747047019) ^ 0x213D775C;
					continue;
				case 0u:
					Form4.smethod_14((Control)(object)button1, new Size(70, 23));
					num = (int)((num2 * 2035091711) ^ 0xB6A4588);
					continue;
				default:
					return;
				case 36u:
					break;
				case 56u:
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
