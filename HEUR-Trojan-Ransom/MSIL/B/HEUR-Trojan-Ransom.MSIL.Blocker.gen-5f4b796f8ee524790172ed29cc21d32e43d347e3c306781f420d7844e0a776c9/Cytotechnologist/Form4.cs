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
			int num = -829420464;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC6CE070Cu) % 3u)
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
				num = (int)(num2 * 518659312) ^ -1495395642;
			}
		}
	}

	private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
	{
		while (true)
		{
			int num = -883978908;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x81260FCBu) % 5u)
				{
				case 4u:
				{
					int num3;
					int num4;
					if (Form4.smethod_2(e) != ' ')
					{
						num3 = 1059777474;
						num4 = 1059777474;
					}
					else
					{
						num3 = 586926;
						num4 = 586926;
					}
					num = num3 ^ ((int)num2 * -453045326);
					continue;
				}
				case 2u:
					num = ((int)num2 * -714491771) ^ 0x14622F3F;
					continue;
				case 1u:
					Form4.smethod_3(e, bool_0: true);
					num = (int)((num2 * 15244620) ^ 0x58041678);
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
			int num = 1025447917;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x8B19CBu) % 10u)
				{
				case 9u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1986016782;
						num5 = 1986016782;
					}
					else
					{
						num4 = 254072387;
						num5 = 254072387;
					}
					num = num4 ^ ((int)num2 * -1777862432);
					continue;
				}
				case 8u:
					num = ((int)num2 * -1915146049) ^ -2048546584;
					continue;
				case 7u:
					Form4.smethod_5((IDisposable)components);
					num = ((int)num2 * -1777825616) ^ -2042970991;
					continue;
				case 6u:
					if (disposing)
					{
						num = (int)((num2 * 327358382) ^ 0x15252CE9);
						continue;
					}
					num3 = 0;
					goto IL_0066;
				case 5u:
					((Form)this).Dispose(disposing);
					num = 1310272048;
					continue;
				case 4u:
					num = (int)((num2 * 1624703249) ^ 0x7BAFD066);
					continue;
				case 3u:
					num = (int)((num2 * 918506196) ^ 0x7E66838A);
					continue;
				case 2u:
					num3 = ((components != null) ? 1 : 0);
					goto IL_0066;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
					IL_0066:
					flag = (byte)num3 != 0;
					num = 1073566630;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected O, but got Unknown
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected O, but got Unknown
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected O, but got Unknown
		//IL_0741: Unknown result type (might be due to invalid IL or missing references)
		//IL_074b: Expected O, but got Unknown
		while (true)
		{
			int num = 2012041417;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5ADCA1A0u) % 63u)
				{
				case 62u:
					num = ((int)num2 * -884732067) ^ -1495737984;
					continue;
				case 61u:
					Form4.smethod_19((Control)(object)button1, "Добавить");
					num = ((int)num2 * -1756349601) ^ -38097504;
					continue;
				case 60u:
					num = (int)((num2 * 1134202568) ^ 0x7419A59E);
					continue;
				case 59u:
					textBox2 = Form4.smethod_7();
					textBox3 = Form4.smethod_7();
					button1 = Form4.smethod_8();
					errorProvider1 = Form4.smethod_9(components);
					num = (int)((num2 * 404890844) ^ 0x7F9A491A);
					continue;
				case 58u:
					Form4.smethod_14((Control)(object)button1, new Size(70, 23));
					num = (int)((num2 * 837225154) ^ 0x6551CA5E);
					continue;
				case 57u:
					Form4.smethod_13((Control)(object)button1, "button1");
					num = ((int)num2 * -246622416) ^ 0x27DBEC45;
					continue;
				case 56u:
					num = (int)((num2 * 1713223293) ^ 0x50ECC2EE);
					continue;
				case 55u:
					num = ((int)num2 * -1936441022) ^ -594064045;
					continue;
				case 54u:
					num = ((int)num2 * -1915789297) ^ 0xCA630BD;
					continue;
				case 53u:
					num = ((int)num2 * -983125633) ^ 0xB8B7963;
					continue;
				case 52u:
					num = (int)(num2 * 696992534) ^ -2089490913;
					continue;
				case 51u:
					num = (int)(num2 * 1974853030) ^ -48359163;
					continue;
				case 50u:
					Form4.smethod_16((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					Form4.smethod_17((Control)(object)textBox2, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)(num2 * 317584484) ^ -1762233754;
					continue;
				case 49u:
					num = (int)((num2 * 1991063639) ^ 0x5E61893C);
					continue;
				case 48u:
					num = ((int)num2 * -1503354080) ^ -989455244;
					continue;
				case 47u:
					num = (int)((num2 * 2088397497) ^ 0x485EBEE4);
					continue;
				case 46u:
					Form4.smethod_15((Control)(object)textBox3, 3);
					num = ((int)num2 * -1001963966) ^ 0x21CF81AD;
					continue;
				case 45u:
					Form4.smethod_14((Control)(object)textBox2, new Size(140, 20));
					num = (int)(num2 * 1575749254) ^ -1333152876;
					continue;
				case 44u:
					Form4.smethod_33((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1930317488) ^ 0x1A8E1EAD;
					continue;
				case 42u:
					Form4.smethod_20((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -1197697796) ^ -2037789488;
					continue;
				case 41u:
					Form4.smethod_35((ISupportInitialize)errorProvider1);
					num = (int)(num2 * 1185173672) ^ -683989425;
					continue;
				case 40u:
					Form4.smethod_15((Control)(object)button1, 0);
					num = ((int)num2 * -1845589573) ^ -1270946775;
					continue;
				case 39u:
					Form4.smethod_24((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 1299967574) ^ -1529285772;
					continue;
				case 38u:
					Form4.smethod_14((Control)(object)textBox3, new Size(140, 20));
					num = ((int)num2 * -1631538850) ^ 0x7E663EF;
					continue;
				case 37u:
					Form4.smethod_15((Control)(object)textBox1, 1);
					num = ((int)num2 * -1464227611) ^ -830841932;
					continue;
				case 36u:
					Form4.smethod_17((Control)(object)textBox3, new KeyPressEventHandler(TextBox_KeyPress));
					Form4.smethod_12((Control)(object)button1, new Point(52, 85));
					num = (int)(num2 * 1230019546) ^ -408132669;
					continue;
				case 35u:
					Form4.smethod_25((Form)(object)this, new Size(176, 114));
					num = ((int)num2 * -995491063) ^ 0x2D37B3CD;
					continue;
				case 34u:
					num = ((int)num2 * -580179689) ^ 0x4B340856;
					continue;
				case 33u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)button1);
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox3);
					num = (int)((num2 * 52059197) ^ 0x4A0EB320);
					continue;
				case 32u:
					Form4.smethod_34((Form)(object)this, new FormClosingEventHandler(Form4_FormClosing));
					num = ((int)num2 * -2081007649) ^ -290717041;
					continue;
				case 31u:
					Form4.smethod_13((Control)(object)textBox2, "textBox2");
					num = (int)((num2 * 444297977) ^ 0x6433F114);
					continue;
				case 30u:
					Form4.smethod_36((Control)(object)this, bool_0: false);
					Form4.smethod_37((Control)(object)this);
					num = (int)(num2 * 819095781) ^ -1385740204;
					continue;
				case 29u:
					num = (int)(num2 * 952204493) ^ -996782798;
					continue;
				case 28u:
					Form4.smethod_18(textBox3, bool_0: true);
					num = ((int)num2 * -27971499) ^ 0x6A8E5D92;
					continue;
				case 27u:
					Form4.smethod_13((Control)(object)textBox1, "textBox1");
					num = (int)((num2 * 54390905) ^ 0x504DED79);
					continue;
				case 26u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox2);
					num = ((int)num2 * -232411596) ^ -1576417694;
					continue;
				case 25u:
					Form4.smethod_28((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -652708808) ^ 0x2388AF84;
					continue;
				case 24u:
					Form4.smethod_29((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1828325041) ^ -689236943;
					continue;
				case 23u:
					Form4.smethod_12((Control)(object)textBox3, new Point(17, 59));
					num = (int)(num2 * 1782284032) ^ -754733651;
					continue;
				case 22u:
					Form4.smethod_11((Control)(object)this);
					num = ((int)num2 * -1670455997) ^ -378315807;
					continue;
				case 21u:
					Form4.smethod_10((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -1262775973) ^ -283784442;
					continue;
				case 20u:
					Form4.smethod_16((Control)(object)textBox3, (EventHandler)TextBox_TextChanged);
					num = (int)((num2 * 1830317602) ^ 0x3DA61CB4);
					continue;
				case 19u:
					Form4.smethod_22(errorProvider1, (ContainerControl)(object)this);
					Form4.smethod_23((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -1297630736) ^ -1872265329;
					continue;
				case 18u:
					num = ((int)num2 * -350158811) ^ 0xA7FD05C;
					continue;
				case 17u:
					Form4.smethod_15((Control)(object)textBox2, 2);
					num = (int)((num2 * 724974011) ^ 0x56ED0B33);
					continue;
				case 16u:
					Form4.smethod_12((Control)(object)textBox1, new Point(17, 7));
					num = (int)((num2 * 617904639) ^ 0x6E95C459);
					continue;
				case 15u:
					Form4.smethod_31((Control)(object)this, "Form4");
					num = (int)(num2 * 1999139464) ^ -1804201007;
					continue;
				case 14u:
					Form4.smethod_32((Form)(object)this, bool_0: false);
					num = (int)(num2 * 419466294) ^ -705545678;
					continue;
				case 12u:
					num = ((int)num2 * -373785127) ^ -1626063859;
					continue;
				case 11u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox1);
					num = ((int)num2 * -65432938) ^ -1219219741;
					continue;
				case 10u:
					num = (int)((num2 * 1440535595) ^ 0x3119673C);
					continue;
				case 9u:
					Form4.smethod_18(textBox2, bool_0: true);
					num = (int)(num2 * 1841183352) ^ -1837531962;
					continue;
				case 8u:
					components = Form4.smethod_6();
					textBox1 = Form4.smethod_7();
					num = (int)(num2 * 1569860105) ^ -1296117547;
					continue;
				case 7u:
					num = ((int)num2 * -95067925) ^ -2031775274;
					continue;
				case 6u:
					Form4.smethod_30((Form)(object)this, bool_0: false);
					num = (int)(num2 * 143539982) ^ -1544831274;
					continue;
				case 5u:
					Form4.smethod_19((Control)(object)this, "Регистрация");
					num = (int)((num2 * 1252168127) ^ 0x2B004DBE);
					continue;
				case 4u:
					Form4.smethod_14((Control)(object)textBox1, new Size(140, 20));
					num = (int)(num2 * 1029317650) ^ -2077775796;
					continue;
				case 3u:
					Form4.smethod_13((Control)(object)textBox3, "textBox3");
					num = (int)((num2 * 493310762) ^ 0x12960F06);
					continue;
				case 2u:
					Form4.smethod_21((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)(num2 * 1727268902) ^ -1827525927;
					continue;
				case 1u:
					Form4.smethod_16((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -2080574092) ^ -103634968;
					continue;
				case 0u:
					Form4.smethod_17((Control)(object)textBox1, new KeyPressEventHandler(TextBox_KeyPress));
					Form4.smethod_12((Control)(object)textBox2, new Point(17, 33));
					num = (int)((num2 * 1807199616) ^ 0x315F29E5);
					continue;
				default:
					return;
				case 13u:
					break;
				case 43u:
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
