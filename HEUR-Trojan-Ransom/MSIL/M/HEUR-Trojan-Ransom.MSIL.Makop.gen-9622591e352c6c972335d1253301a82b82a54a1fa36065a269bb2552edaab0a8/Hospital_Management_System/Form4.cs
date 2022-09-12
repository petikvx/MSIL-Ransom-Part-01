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
			Button okBtn = default(Button);
			while (true)
			{
				int num = -1082041623;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF13AAB0Du) % 7u)
					{
					case 6u:
						okBtn = _OkBtn;
						num = ((int)num2 * -1970510733) ^ 0x13C07354;
						continue;
					case 5u:
						Form4.smethod_32((Control)(object)okBtn, eventHandler_);
						num = ((int)num2 * -1776345003) ^ 0x25546F10;
						continue;
					case 4u:
					{
						_OkBtn = value;
						okBtn = _OkBtn;
						int num5;
						if (okBtn == null)
						{
							num = -142309412;
							num5 = -142309412;
						}
						else
						{
							num = -1643132271;
							num5 = -1643132271;
						}
						continue;
					}
					case 3u:
						Form4.smethod_31((Control)(object)okBtn, eventHandler_);
						num = (int)((num2 * 2017934475) ^ 0x7BA0B3B9);
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (okBtn == null)
						{
							num3 = -1348534276;
							num4 = -1348534276;
						}
						else
						{
							num3 = -1706117398;
							num4 = -1706117398;
						}
						num = num3 ^ ((int)num2 * -476170798);
						continue;
					}
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
					}
					break;
				}
			}
		}
	}

	public Form4()
	{
		Form4.smethod_0((Form)(object)this, (EventHandler)Form4_Load);
		myconnection = Form4.smethod_1();
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			bool flag = default(bool);
			while (true)
			{
				int num = 1511671513;
				while (true)
				{
					uint num2;
					int num5;
					switch ((num2 = (uint)num ^ 0x55CC5CD6u) % 8u)
					{
					case 7u:
						if (disposing)
						{
							num = ((int)num2 * -704837321) ^ 0x61D1442B;
							continue;
						}
						num5 = 0;
						goto IL_001a;
					case 6u:
						Form4.smethod_2((IDisposable)components);
						num = ((int)num2 * -1864071466) ^ 0x1AA910F9;
						continue;
					case 4u:
						num5 = ((components != null) ? 1 : 0);
						goto IL_001a;
					case 3u:
						num = (int)(num2 * 816526577) ^ -1732536473;
						continue;
					case 2u:
						num = 1379231223;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -810884264;
							num4 = -810884264;
						}
						else
						{
							num3 = -596608948;
							num4 = -596608948;
						}
						num = num3 ^ ((int)num2 * -1116685174);
						continue;
					}
					default:
						return;
					case 5u:
						break;
					case 1u:
						return;
						IL_001a:
						flag = (byte)num5 != 0;
						num = 35169142;
						continue;
					}
					break;
				}
			}
		}
		finally
		{
			while (true)
			{
				IL_0100:
				int num6 = 1567320413;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num6 ^ 0x55CC5CD6u) % 4u)
					{
					case 3u:
						((Form)this).Dispose(disposing);
						num6 = ((int)num2 * -262851519) ^ 0x3350A69D;
						continue;
					case 0u:
						num6 = ((int)num2 * -869664270) ^ 0x1FAC87D7;
						continue;
					default:
						goto end_IL_00df;
					case 2u:
						break;
					case 1u:
						goto end_IL_00df;
					}
					goto IL_0100;
					continue;
					end_IL_00df:
					break;
				}
				break;
			}
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		while (true)
		{
			int num = -929163809;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEB158624u) % 40u)
				{
				case 39u:
					Form4.smethod_15((ButtonBase)(object)OkBtn, Color.MidnightBlue);
					num = ((int)num2 * -1027890527) ^ 0x287BA18C;
					continue;
				case 38u:
					Form4.smethod_9((Control)(object)OkBtn, new Point(77, 157));
					num = (int)((num2 * 678789052) ^ 0x2F51A9E1);
					continue;
				case 37u:
					Form4.smethod_8((Control)(object)Label1, Form4.smethod_7("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 957392915) ^ -1050863151;
					continue;
				case 35u:
					Form4.smethod_12((Control)(object)Label1, 0);
					Form4.smethod_13(Label1, "Update Amount");
					num = (int)((num2 * 232541628) ^ 0x7EE47155);
					continue;
				case 34u:
					Form4.smethod_17((ButtonBase)(object)OkBtn, "Ok");
					Form4.smethod_18((ButtonBase)(object)OkBtn, bool_0: false);
					num = ((int)num2 * -56679269) ^ 0x5F1B9BAC;
					continue;
				case 33u:
					num = (int)((num2 * 1928378104) ^ 0x4F79AD4);
					continue;
				case 32u:
					Form4.smethod_24(Form4.smethod_23((Control)(object)this), (Control)(object)OkBtn);
					Form4.smethod_24(Form4.smethod_23((Control)(object)this), (Control)(object)TextBox1);
					num = (int)((num2 * 1120239706) ^ 0x503752DF);
					continue;
				case 31u:
					Form4.smethod_8((Control)(object)TextBox1, Form4.smethod_7("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 333263654) ^ -1562928081;
					continue;
				case 30u:
					Form4.smethod_12((Control)(object)OkBtn, 2);
					num = (int)(num2 * 617643198) ^ -299976918;
					continue;
				case 29u:
					Form4.smethod_14(Label1, (ContentAlignment)32);
					num = (int)((num2 * 594378827) ^ 0x7D4DEFFC);
					continue;
				case 28u:
					num = ((int)num2 * -417140836) ^ 0x38CA089E;
					continue;
				case 27u:
					Label1 = Form4.smethod_3();
					num = (int)((num2 * 1934699543) ^ 0x74D221DD);
					continue;
				case 26u:
					Form4.smethod_10((Control)(object)OkBtn, "OkBtn");
					num = (int)(num2 * 801210826) ^ -603783469;
					continue;
				case 25u:
					Form4.smethod_9((Control)(object)TextBox1, new Point(60, 107));
					num = ((int)num2 * -58910862) ^ 0x7972DF5E;
					continue;
				case 24u:
					Form4.smethod_6((Control)(object)this);
					num = ((int)num2 * -668480291) ^ -1620323559;
					continue;
				case 23u:
					Form4.smethod_11((Control)(object)Label1, new Size(200, 49));
					num = (int)(num2 * 1709204922) ^ -118800255;
					continue;
				case 22u:
					Form4.smethod_8((Control)(object)OkBtn, Form4.smethod_7("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1468396205) ^ -215951933;
					continue;
				case 21u:
					OkBtn = Form4.smethod_5();
					num = ((int)num2 * -1409746204) ^ 0x344A4FC7;
					continue;
				case 20u:
					Form4.smethod_21((Form)(object)this, Color.White);
					Form4.smethod_22((Form)(object)this, new Size(282, 253));
					num = (int)((num2 * 1222365558) ^ 0x7ACD604C);
					continue;
				case 19u:
					Form4.smethod_25((Form)(object)this, bool_0: false);
					num = ((int)num2 * -997500086) ^ -1473154789;
					continue;
				case 18u:
					Form4.smethod_11((Control)(object)TextBox1, new Size(146, 28));
					num = ((int)num2 * -237227804) ^ -133383592;
					continue;
				case 17u:
					Form4.smethod_29((Control)(object)this, bool_0: false);
					num = (int)(num2 * 1369307673) ^ -11587263;
					continue;
				case 16u:
					Form4.smethod_10((Control)(object)Label1, "Label1");
					num = (int)(num2 * 1003662513) ^ -171061837;
					continue;
				case 15u:
					num = (int)(num2 * 1629706282) ^ -497212996;
					continue;
				case 14u:
					Form4.smethod_19((ContainerControl)(object)this, new SizeF(8f, 16f));
					num = ((int)num2 * -1766694819) ^ -2059382436;
					continue;
				case 13u:
					num = (int)(num2 * 1299026957) ^ -904584049;
					continue;
				case 12u:
					TextBox1 = Form4.smethod_4();
					num = (int)((num2 * 520270408) ^ 0x75EDE421);
					continue;
				case 11u:
					Form4.smethod_24(Form4.smethod_23((Control)(object)this), (Control)(object)Label1);
					num = (int)(num2 * 794055685) ^ -43512736;
					continue;
				case 10u:
					Form4.smethod_9((Control)(object)Label1, new Point(32, 43));
					num = (int)(num2 * 1958045874) ^ -112086008;
					continue;
				case 9u:
					Form4.smethod_16((Control)(object)OkBtn, Color.White);
					num = ((int)num2 * -402606897) ^ -1766834307;
					continue;
				case 8u:
					Form4.smethod_27((Control)(object)this, "Form4");
					Form4.smethod_28((Form)(object)this, "Form4");
					num = (int)(num2 * 1440550333) ^ -1317841123;
					continue;
				case 7u:
					num = ((int)num2 * -2102196816) ^ 0x52CAF104;
					continue;
				case 6u:
					Form4.smethod_20((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -1299891534) ^ 0x26C85DF4;
					continue;
				case 5u:
					num = ((int)num2 * -1954952235) ^ 0x5FE0187F;
					continue;
				case 3u:
					Form4.smethod_11((Control)(object)OkBtn, new Size(96, 37));
					num = (int)(num2 * 1813054858) ^ -602002332;
					continue;
				case 2u:
					Form4.smethod_12((Control)(object)TextBox1, 1);
					num = (int)(num2 * 621181696) ^ -2028835277;
					continue;
				case 1u:
					Form4.smethod_26((Form)(object)this, bool_0: false);
					num = ((int)num2 * -342169208) ^ -424807995;
					continue;
				case 0u:
					Form4.smethod_10((Control)(object)TextBox1, "TextBox1");
					num = ((int)num2 * -1115824986) ^ 0xA7D9231;
					continue;
				case 36u:
					break;
				default:
					Form4.smethod_30((Control)(object)this);
					return;
				}
				break;
			}
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected I4, but got Unknown
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected I4, but got Unknown
		//IL_01f5: Incompatible stack heights: 0 vs 1
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Incompatible stack heights: 0 vs 1
		//IL_022b: Incompatible stack heights: 0 vs 1
		//IL_0232: Incompatible stack heights: 0 vs 1
		bool flag = !MyProject.Forms.Form1.Decimal_Validator(Form4.smethod_33(TextBox1));
		while (true)
		{
			int num = 501237189;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x672439E4u) % 6u)
				{
				case 5u:
				{
					OleDbCommand val = Form4.smethod_35();
					num = 1221281278;
					continue;
				}
				case 2u:
					Form4.smethod_34("Enter Valid Amount");
					num = (int)((num2 * 22257011) ^ 0x4988BA58);
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -78759892;
						num5 = -78759892;
					}
					else
					{
						num4 = -896484869;
						num5 = -896484869;
					}
					num = num4 ^ ((int)num2 * -302566061);
					continue;
				}
				case 3u:
					break;
				default:
				{
					string string_ = Form4.smethod_37(new string[5]
					{
						"Update [Blood_Available] Set Quantity = ",
						Form4.smethod_33(TextBox1),
						" Where [ID] =",
						Form4.smethod_36(MyProject.Forms.Form1.blood_available_id),
						";"
					});
					Form4.smethod_38(myconnection);
					try
					{
						OleDbCommand val = Form4.smethod_39(string_, myconnection);
						Form4.smethod_40(val);
						Form4.smethod_41((Component)(object)val);
						while (true)
						{
							int num3 = 683306788;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x672439E4u) % 6u)
								{
								case 4u:
									num3 = ((int)num2 * -1003790579) ^ 0x69526B11;
									continue;
								case 3u:
									MyProject.Forms.Form1.cur_blood_amount = Form4.smethod_43(Form4.smethod_33(TextBox1));
									Form4.smethod_44((Form)(object)this);
									num3 = ((int)num2 * -1935608450) ^ 0x16B5BB60;
									continue;
								case 2u:
									num3 = ((int)num2 * -897216489) ^ -1817391085;
									continue;
								case 1u:
									Form4.smethod_42(myconnection);
									num3 = ((int)num2 * -1684457008) ^ -294259008;
									continue;
								default:
									return;
								case 5u:
									break;
								case 0u:
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
							_ = 1326133268;
							while (true)
							{
								_003F val2 = /*Error near IL_01c2: Stack underflow*/^ 0x672439E4;
								num2 = (uint)(int)val2;
								switch (val2 % 5)
								{
								default:
									return;
								case 4:
									Form4.smethod_46();
									_ = ((int)num2 * -742275596) ^ 0x18413857;
									continue;
								case 1:
									Form4.smethod_34("Error Updating database");
									_ = ((int)num2 * -1168893280) ^ -1999752663;
									continue;
								case 0:
									Form4.smethod_42(myconnection);
									_ = ((int)num2 * -640059519) ^ -1323401714;
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
				}
				case 0u:
					return;
				}
				break;
			}
		}
	}

	private void Form4_Load(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -2056194760;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDAC3B809u) % 3u)
				{
				case 1u:
					goto IL_0003;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0003:
				Form4.smethod_48(myconnection, Form4.smethod_47(MyProject.Forms.Form1.provider, MyProject.Forms.Form1.datafile));
				num = (int)(num2 * 4364074) ^ -973544128;
			}
		}
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
