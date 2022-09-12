using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hospital_Management_System.My;
using Microsoft.VisualBasic.CompilerServices;

namespace Hospital_Management_System;

[DesignerGenerated]
public class Form4 : Form
{
	private IContainer components;

	private OleDbConnection myconnection;

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button OkBtn
	{
		[CompilerGenerated]
		get
		{
			return _OkBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = Button1_Click;
			Button okBtn = _OkBtn;
			while (true)
			{
				int num = 735183550;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4DC699E3u) % 7u)
					{
					case 6u:
						Form4.smethod_32((Control)(object)okBtn, eventHandler_);
						num = (int)((num2 * 412159748) ^ 0x7A42DF37);
						continue;
					case 4u:
						Form4.smethod_31((Control)(object)okBtn, eventHandler_);
						num = ((int)num2 * -1029459039) ^ -1386713857;
						continue;
					case 3u:
						_OkBtn = value;
						num = 1544205724;
						continue;
					case 1u:
					{
						int num5;
						int num6;
						if (okBtn == null)
						{
							num5 = -1509564286;
							num6 = -1509564286;
						}
						else
						{
							num5 = -524369986;
							num6 = -524369986;
						}
						num = num5 ^ (int)(num2 * 1823820062);
						continue;
					}
					case 0u:
					{
						okBtn = _OkBtn;
						int num3;
						int num4;
						if (okBtn != null)
						{
							num3 = 557613402;
							num4 = 557613402;
						}
						else
						{
							num3 = 494515872;
							num4 = 494515872;
						}
						num = num3 ^ (int)(num2 * 2100236337);
						continue;
					}
					default:
						return;
					case 2u:
						break;
					case 5u:
						return;
					}
					break;
				}
			}
		}
	}

	public Form4()
	{
		while (true)
		{
			int num = -1568401657;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA8D174B4u) % 6u)
				{
				case 5u:
					Form4.smethod_0((Form)(object)this, (EventHandler)Form4_Load);
					num = (int)(num2 * 853978760) ^ -1572353814;
					continue;
				case 4u:
					InitializeComponent();
					num = (int)((num2 * 1701665141) ^ 0x38D67B36);
					continue;
				case 2u:
					myconnection = Form4.smethod_1();
					num = ((int)num2 * -2001009733) ^ 0x5229108;
					continue;
				case 1u:
					num = ((int)num2 * -1201256070) ^ 0x3375D49;
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

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing)
			{
				goto IL_0014;
			}
			goto IL_0072;
			IL_0014:
			int num = 1393404318;
			goto IL_0042;
			IL_0042:
			int num3;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x569D430Au) % 5u)
				{
				case 3u:
					break;
				case 2u:
					Form4.smethod_2((IDisposable)components);
					num = (int)(num2 * 1723742794) ^ -425922617;
					continue;
				case 0u:
					num = (int)((num2 * 326316555) ^ 0x27182485);
					continue;
				default:
					return;
				case 1u:
					goto IL_0067;
				case 4u:
					return;
				}
				break;
				IL_0067:
				if (components != null)
				{
					num = 1193483294;
					num3 = 1193483294;
					continue;
				}
				goto IL_0072;
			}
			goto IL_0014;
			IL_0072:
			num = 1930845106;
			num3 = 1930845106;
			goto IL_0042;
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		while (true)
		{
			int num = -1845551474;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x81846751u) % 47u)
				{
				case 46u:
					Form4.smethod_10((Control)(object)TextBox1, "TextBox1");
					Form4.smethod_11((Control)(object)TextBox1, new Size(146, 28));
					num = (int)((num2 * 1804714117) ^ 0x10E0F1C7);
					continue;
				case 44u:
					Form4.smethod_11((Control)(object)Label1, new Size(200, 49));
					num = (int)((num2 * 1701389674) ^ 0x4477505E);
					continue;
				case 43u:
					Form4.smethod_22((Form)(object)this, new Size(282, 253));
					num = ((int)num2 * -606318416) ^ 0x6207E958;
					continue;
				case 42u:
					num = (int)((num2 * 2117792694) ^ 0x490624D3);
					continue;
				case 41u:
					num = (int)(num2 * 443137516) ^ -313401721;
					continue;
				case 40u:
					Form4.smethod_30((Control)(object)this);
					num = (int)(num2 * 637647436) ^ -1061678890;
					continue;
				case 39u:
					Form4.smethod_10((Control)(object)OkBtn, "OkBtn");
					num = (int)(num2 * 770955398) ^ -1470661616;
					continue;
				case 38u:
					Form4.smethod_6((Control)(object)this);
					num = (int)(num2 * 494353188) ^ -280641720;
					continue;
				case 37u:
					Form4.smethod_18((ButtonBase)(object)OkBtn, bool_0: false);
					Form4.smethod_19((ContainerControl)(object)this, new SizeF(8f, 16f));
					num = ((int)num2 * -528464773) ^ -1161449277;
					continue;
				case 36u:
					Form4.smethod_8((Control)(object)Label1, Form4.smethod_7("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -241340273) ^ 0x2BFCD3A9;
					continue;
				case 35u:
					Form4.smethod_11((Control)(object)OkBtn, new Size(96, 37));
					num = ((int)num2 * -1384865881) ^ 0x4DEFC989;
					continue;
				case 34u:
					Form4.smethod_24(Form4.smethod_23((Control)(object)this), (Control)(object)OkBtn);
					num = (int)(num2 * 1746785925) ^ -1916764596;
					continue;
				case 33u:
					num = ((int)num2 * -2086108960) ^ -1982365347;
					continue;
				case 32u:
					Form4.smethod_9((Control)(object)Label1, new Point(32, 43));
					num = ((int)num2 * -1072319920) ^ 0x567F93F9;
					continue;
				case 31u:
					num = (int)(num2 * 1988159184) ^ -2069204013;
					continue;
				case 30u:
					num = ((int)num2 * -1139317978) ^ 0x3C9611A1;
					continue;
				case 29u:
					Form4.smethod_9((Control)(object)TextBox1, new Point(60, 107));
					num = ((int)num2 * -405831925) ^ 0x7B6A80FA;
					continue;
				case 28u:
					Label1 = Form4.smethod_3();
					TextBox1 = Form4.smethod_4();
					OkBtn = Form4.smethod_5();
					num = ((int)num2 * -839825149) ^ 0x60F97148;
					continue;
				case 27u:
					num = ((int)num2 * -377143967) ^ 0x1568CD92;
					continue;
				case 26u:
					Form4.smethod_12((Control)(object)TextBox1, 1);
					num = (int)((num2 * 1498411431) ^ 0x26A209D0);
					continue;
				case 25u:
					Form4.smethod_29((Control)(object)this, bool_0: false);
					num = (int)((num2 * 1754022717) ^ 0x1BE632);
					continue;
				case 24u:
					num = ((int)num2 * -1828035339) ^ 0x5B5A1D83;
					continue;
				case 23u:
					num = (int)(num2 * 1626117752) ^ -839679432;
					continue;
				case 22u:
					Form4.smethod_15((ButtonBase)(object)OkBtn, Color.MidnightBlue);
					num = (int)((num2 * 1069838214) ^ 0x69AD555F);
					continue;
				case 21u:
					Form4.smethod_28((Form)(object)this, "Form4");
					num = ((int)num2 * -1129332428) ^ 0x63E235D8;
					continue;
				case 20u:
					Form4.smethod_12((Control)(object)Label1, 0);
					Form4.smethod_13(Label1, "Update Amount");
					num = ((int)num2 * -1012044806) ^ -501718147;
					continue;
				case 19u:
					Form4.smethod_12((Control)(object)OkBtn, 2);
					num = ((int)num2 * -1863351397) ^ 0x6AAFB198;
					continue;
				case 18u:
					Form4.smethod_10((Control)(object)Label1, "Label1");
					num = (int)((num2 * 120503444) ^ 0x2435FDB4);
					continue;
				case 17u:
					num = ((int)num2 * -1719331500) ^ -646031207;
					continue;
				case 16u:
					Form4.smethod_25((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1388721652) ^ 0x3B257975;
					continue;
				case 15u:
					num = (int)(num2 * 677165196) ^ -937347769;
					continue;
				case 14u:
					num = ((int)num2 * -575392784) ^ -936187768;
					continue;
				case 13u:
					num = ((int)num2 * -400418270) ^ -727337161;
					continue;
				case 12u:
					Form4.smethod_9((Control)(object)OkBtn, new Point(77, 157));
					num = (int)((num2 * 570082911) ^ 0x6C3429B6);
					continue;
				case 11u:
					Form4.smethod_17((ButtonBase)(object)OkBtn, "Ok");
					num = (int)(num2 * 1333923186) ^ -1833660914;
					continue;
				case 10u:
					Form4.smethod_24(Form4.smethod_23((Control)(object)this), (Control)(object)TextBox1);
					num = ((int)num2 * -624665117) ^ -1890161292;
					continue;
				case 9u:
					Form4.smethod_8((Control)(object)OkBtn, Form4.smethod_7("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					Form4.smethod_16((Control)(object)OkBtn, Color.White);
					num = (int)(num2 * 1484344042) ^ -1631263058;
					continue;
				case 8u:
					Form4.smethod_24(Form4.smethod_23((Control)(object)this), (Control)(object)Label1);
					num = (int)((num2 * 1579879391) ^ 0x2393E203);
					continue;
				case 7u:
					num = (int)(num2 * 520290586) ^ -361073315;
					continue;
				case 6u:
					num = (int)((num2 * 1369632346) ^ 0x43A1AC2F);
					continue;
				case 5u:
					num = (int)(num2 * 543430896) ^ -443890726;
					continue;
				case 4u:
					Form4.smethod_8((Control)(object)TextBox1, Form4.smethod_7("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1576657991) ^ -772287589;
					continue;
				case 3u:
					Form4.smethod_20((ContainerControl)(object)this, (AutoScaleMode)1);
					Form4.smethod_21((Form)(object)this, Color.White);
					num = ((int)num2 * -336619253) ^ -2091694729;
					continue;
				case 2u:
					Form4.smethod_14(Label1, (ContentAlignment)32);
					num = (int)(num2 * 661293174) ^ -278844098;
					continue;
				case 1u:
					Form4.smethod_26((Form)(object)this, bool_0: false);
					Form4.smethod_27((Control)(object)this, "Form4");
					num = (int)(num2 * 506162183) ^ -623513914;
					continue;
				default:
					return;
				case 45u:
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
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected I4, but got Unknown
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected I4, but got Unknown
		//IL_023a: Incompatible stack heights: 0 vs 1
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Incompatible stack heights: 0 vs 1
		//IL_0275: Incompatible stack heights: 0 vs 1
		//IL_027c: Incompatible stack heights: 0 vs 1
		bool flag = !MyProject.Forms.Form1.Decimal_Validator(Form4.smethod_33(TextBox1));
		string string_ = default(string);
		while (true)
		{
			int num = 1582631437;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x67A7D06Eu) % 8u)
				{
				case 7u:
				{
					OleDbCommand val = Form4.smethod_35();
					num = (int)((num2 * 1419962916) ^ 0x3E87DBB);
					continue;
				}
				case 6u:
					num = 615894073;
					continue;
				case 4u:
					Form4.smethod_34("Enter Valid Amount");
					num = ((int)num2 * -1442337207) ^ -2032193201;
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1481011378;
						num5 = 1481011378;
					}
					else
					{
						num4 = 1710629248;
						num5 = 1710629248;
					}
					num = num4 ^ ((int)num2 * -526710002);
					continue;
				}
				case 1u:
					string_ = Form4.smethod_37(new string[5]
					{
						"Update [Blood_Available] Set Quantity = ",
						Form4.smethod_33(TextBox1),
						" Where [ID] =",
						Form4.smethod_36(MyProject.Forms.Form1.blood_available_id),
						";"
					});
					Form4.smethod_38(myconnection);
					num = ((int)num2 * -1120133472) ^ -304013524;
					continue;
				case 0u:
					break;
				default:
					try
					{
						while (true)
						{
							int num3 = 92355676;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x67A7D06Eu) % 7u)
								{
								case 6u:
								{
									OleDbCommand val = Form4.smethod_39(string_, myconnection);
									Form4.smethod_40(val);
									Form4.smethod_41((Component)(object)val);
									num3 = ((int)num2 * -1764912325) ^ 0x59856EF0;
									continue;
								}
								case 5u:
									MyProject.Forms.Form1.cur_blood_amount = Form4.smethod_43(Form4.smethod_33(TextBox1));
									num3 = (int)(num2 * 2122368850) ^ -945272164;
									continue;
								case 4u:
									Form4.smethod_42(myconnection);
									num3 = (int)(num2 * 601707555) ^ -748788466;
									continue;
								case 1u:
									num3 = ((int)num2 * -372296487) ^ -150557968;
									continue;
								case 0u:
									Form4.smethod_44((Form)(object)this);
									num3 = ((int)num2 * -1152770837) ^ 0x5D5B7272;
									continue;
								default:
									return;
								case 3u:
									break;
								case 2u:
									return;
								}
								break;
							}
						}
					}
					catch (Exception exception_)
					{
						Form4.smethod_45(exception_);
						while (true)
						{
							_ = 293861580;
							while (true)
							{
								_003F val2 = /*Error near IL_020c: Stack underflow*/^ 0x67A7D06E;
								num2 = (uint)(int)val2;
								switch (val2 % 5)
								{
								default:
									return;
								case 4:
									_ = (num2 * 1609798223) ^ 0xB2687209u;
									continue;
								case 1:
									Form4.smethod_34("Error Updating database");
									Form4.smethod_42(myconnection);
									_ = ((int)num2 * -895572594) ^ -1975160853;
									continue;
								case 0:
									Form4.smethod_46();
									_ = ((int)num2 * -2087227588) ^ 0x6E37B3EE;
									continue;
								case 2:
									break;
								case 3:
									return;
								}
								break;
							}
						}
					}
				case 5u:
					return;
				}
				break;
			}
		}
	}

	private void Form4_Load(object sender, EventArgs e)
	{
		Form4.smethod_48(myconnection, Form4.smethod_47(MyProject.Forms.Form1.provider, MyProject.Forms.Form1.datafile));
	}

	static void smethod_0(Form form_0, EventHandler eventHandler_0)
	{
		form_0.add_Load(eventHandler_0);
	}

	static OleDbConnection smethod_1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new OleDbConnection();
	}

	static void smethod_2(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Label smethod_3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Label();
	}

	static TextBox smethod_4()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TextBox();
	}

	static Button smethod_5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
	}

	static void smethod_6(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static Font smethod_7(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_8(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_9(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_10(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_11(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_12(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_13(Label label_0, string string_0)
	{
		label_0.set_Text(string_0);
	}

	static void smethod_14(Label label_0, ContentAlignment contentAlignment_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		label_0.set_TextAlign(contentAlignment_0);
	}

	static void smethod_15(ButtonBase buttonBase_0, Color color_0)
	{
		buttonBase_0.set_BackColor(color_0);
	}

	static void smethod_16(Control control_0, Color color_0)
	{
		control_0.set_ForeColor(color_0);
	}

	static void smethod_17(ButtonBase buttonBase_0, string string_0)
	{
		buttonBase_0.set_Text(string_0);
	}

	static void smethod_18(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_UseVisualStyleBackColor(bool_0);
	}

	static void smethod_19(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_20(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_21(Form form_0, Color color_0)
	{
		form_0.set_BackColor(color_0);
	}

	static void smethod_22(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static ControlCollection smethod_23(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_24(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_25(Form form_0, bool bool_0)
	{
		form_0.set_MaximizeBox(bool_0);
	}

	static void smethod_26(Form form_0, bool bool_0)
	{
		form_0.set_MinimizeBox(bool_0);
	}

	static void smethod_27(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_28(Form form_0, string string_0)
	{
		form_0.set_Text(string_0);
	}

	static void smethod_29(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_30(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_31(Control control_0, EventHandler eventHandler_0)
	{
		control_0.remove_Click(eventHandler_0);
	}

	static void smethod_32(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static string smethod_33(TextBox textBox_0)
	{
		return textBox_0.get_Text();
	}

	static DialogResult smethod_34(string string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0);
	}

	static OleDbCommand smethod_35()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new OleDbCommand();
	}

	static string smethod_36(int int_0)
	{
		return Conversions.ToString(int_0);
	}

	static string smethod_37(string[] string_0)
	{
		return string.Concat(string_0);
	}

	static void smethod_38(OleDbConnection oleDbConnection_0)
	{
		oleDbConnection_0.Open();
	}

	static OleDbCommand smethod_39(string string_0, OleDbConnection oleDbConnection_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new OleDbCommand(string_0, oleDbConnection_0);
	}

	static int smethod_40(OleDbCommand oleDbCommand_0)
	{
		return oleDbCommand_0.ExecuteNonQuery();
	}

	static void smethod_41(Component component_0)
	{
		component_0.Dispose();
	}

	static void smethod_42(OleDbConnection oleDbConnection_0)
	{
		oleDbConnection_0.Close();
	}

	static decimal smethod_43(string string_0)
	{
		return Conversions.ToDecimal(string_0);
	}

	static void smethod_44(Form form_0)
	{
		form_0.Close();
	}

	static void smethod_45(Exception exception_0)
	{
		ProjectData.SetProjectError(exception_0);
	}

	static void smethod_46()
	{
		ProjectData.ClearProjectError();
	}

	static string smethod_47(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static void smethod_48(OleDbConnection oleDbConnection_0, string string_0)
	{
		oleDbConnection_0.set_ConnectionString(string_0);
	}
}
