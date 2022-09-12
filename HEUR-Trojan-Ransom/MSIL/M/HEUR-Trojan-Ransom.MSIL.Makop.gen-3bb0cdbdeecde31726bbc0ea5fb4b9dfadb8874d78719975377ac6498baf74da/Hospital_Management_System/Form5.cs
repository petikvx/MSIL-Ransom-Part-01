using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hospital_Management_System.My;
using Microsoft.VisualBasic.CompilerServices;

namespace Hospital_Management_System;

[DesignerGenerated]
public class Form5 : Form
{
	private IContainer components;

	private OleDbConnection myconnection;

	[field: AccessedThroughProperty("SearchResultGrid")]
	internal virtual DataGridView SearchResultGrid
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Form5()
	{
		while (true)
		{
			int num = -1191467910;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA63B1EA1u) % 5u)
				{
				case 4u:
					InitializeComponent();
					num = ((int)num2 * -346813219) ^ -1132576831;
					continue;
				case 2u:
					Form5.smethod_0((Form)(object)this, (EventHandler)Form5_Load);
					myconnection = Form5.smethod_1();
					num = ((int)num2 * -799379690) ^ 0x6034B790;
					continue;
				case 1u:
					num = (int)((num2 * 2009992843) ^ 0x6B22BFD5);
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

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			while (true)
			{
				int num = 2131877561;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x10A50395u) % 8u)
					{
					case 7u:
						num = 304091444;
						continue;
					case 6u:
						num = ((int)num2 * -1691949356) ^ 0x4F3E5A8A;
						continue;
					case 5u:
						num = ((int)num2 * -2011702194) ^ -689727331;
						continue;
					case 4u:
						if (disposing)
						{
							num = ((int)num2 * -1892235462) ^ 0x40574CED;
							continue;
						}
						goto IL_004d;
					case 3u:
						Form5.smethod_2((IDisposable)components);
						num = (int)(num2 * 1517490986) ^ -1933908122;
						continue;
					case 0u:
						if (components != null)
						{
							num = 1494692742;
							num3 = 1494692742;
							continue;
						}
						goto IL_004d;
					default:
						return;
					case 2u:
						break;
					case 1u:
						return;
						IL_004d:
						num = 1115834834;
						num3 = 1115834834;
						continue;
					}
					break;
				}
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
			while (true)
			{
				IL_00ec:
				int num4 = 1163257598;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num4 ^ 0x10A50395u) % 3u)
					{
					case 1u:
						goto IL_00c2;
					default:
						goto end_IL_00cf;
					case 2u:
						break;
					case 0u:
						goto end_IL_00cf;
					}
					goto IL_00ec;
					IL_00c2:
					num4 = (int)(num2 * 208966214) ^ -2027451074;
					continue;
					end_IL_00cf:
					break;
				}
				break;
			}
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		SearchResultGrid = Form5.smethod_3();
		while (true)
		{
			int num = 965612444;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x66DED81Au) % 33u)
				{
				case 32u:
					Form5.smethod_16((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -527579650) ^ 0x505F0007;
					continue;
				case 31u:
					Form5.smethod_5((Control)(object)this);
					num = (int)((num2 * 1004643898) ^ 0x3FCF8CE8);
					continue;
				case 30u:
					num = (int)((num2 * 2082489640) ^ 0x30F3B821);
					continue;
				case 29u:
					Form5.smethod_20((Form)(object)this, (FormBorderStyle)3);
					num = ((int)num2 * -1883211167) ^ -1597203084;
					continue;
				case 28u:
					Form5.smethod_21((Form)(object)this, bool_0: false);
					num = (int)((num2 * 1096126296) ^ 0x22970934);
					continue;
				case 27u:
					Form5.smethod_19(Form5.smethod_18((Control)(object)this), (Control)(object)SearchResultGrid);
					num = ((int)num2 * -145555220) ^ 0x7DC889F1;
					continue;
				case 26u:
					Form5.smethod_23((Control)(object)this, "Form5");
					num = ((int)num2 * -306382141) ^ -342182253;
					continue;
				case 25u:
					Form5.smethod_13((Control)(object)SearchResultGrid, new Size(827, 372));
					num = (int)((num2 * 1541238548) ^ 0x5F8BCF38);
					continue;
				case 24u:
					Form5.smethod_6(SearchResultGrid, Color.White);
					num = (int)((num2 * 2032844838) ^ 0x3879600D);
					continue;
				case 23u:
					num = ((int)num2 * -316329429) ^ 0x70FC6769;
					continue;
				case 22u:
					Form5.smethod_26((Control)(object)this, bool_0: false);
					num = (int)((num2 * 738916004) ^ 0x6D2C238A);
					continue;
				case 21u:
					Form5.smethod_12(Form5.smethod_11(SearchResultGrid), 24);
					num = ((int)num2 * -1862216935) ^ -1000294218;
					continue;
				case 20u:
					num = ((int)num2 * -1377946726) ^ -1932496114;
					continue;
				case 18u:
					num = ((int)num2 * -1774649233) ^ 0x6C46E6FB;
					continue;
				case 17u:
					num = (int)(num2 * 1790697194) ^ -1335409287;
					continue;
				case 16u:
					Form5.smethod_7(SearchResultGrid, (DataGridViewColumnHeadersHeightSizeMode)2);
					num = ((int)num2 * -1612365393) ^ 0x7307D8F5;
					continue;
				case 15u:
					Form5.smethod_24((Form)(object)this, "Form5");
					num = (int)(num2 * 2023186819) ^ -1629094935;
					continue;
				case 14u:
					num = ((int)num2 * -1503782760) ^ -1879148484;
					continue;
				case 13u:
					Form5.smethod_9((Control)(object)SearchResultGrid, "SearchResultGrid");
					num = ((int)num2 * -1757019440) ^ -282062150;
					continue;
				case 12u:
					Form5.smethod_22((Form)(object)this, bool_0: false);
					num = ((int)num2 * -2098652466) ^ 0x1615296D;
					continue;
				case 11u:
					num = (int)(num2 * 733071222) ^ -247319882;
					continue;
				case 10u:
					Form5.smethod_17((Form)(object)this, new Size(832, 375));
					num = ((int)num2 * -1094578192) ^ -1804759460;
					continue;
				case 9u:
					Form5.smethod_25((ISupportInitialize)SearchResultGrid);
					num = ((int)num2 * -372373780) ^ 0x447FD5A6;
					continue;
				case 8u:
					num = ((int)num2 * -407673741) ^ -1665373598;
					continue;
				case 6u:
					Form5.smethod_14((Control)(object)SearchResultGrid, 0);
					num = (int)(num2 * 1199252322) ^ -1114758798;
					continue;
				case 5u:
					Form5.smethod_8((Control)(object)SearchResultGrid, new Point(3, 1));
					num = (int)(num2 * 543498345) ^ -782388009;
					continue;
				case 4u:
					num = ((int)num2 * -248532661) ^ 0x7A27D9CD;
					continue;
				case 3u:
					num = (int)((num2 * 161497932) ^ 0x427F9D47);
					continue;
				case 2u:
					Form5.smethod_4((ISupportInitialize)SearchResultGrid);
					num = (int)(num2 * 26436847) ^ -1325506536;
					continue;
				case 1u:
					Form5.smethod_10(SearchResultGrid, bool_0: true);
					num = (int)((num2 * 1991846967) ^ 0xD671CC9);
					continue;
				case 0u:
					Form5.smethod_15((ContainerControl)(object)this, new SizeF(8f, 16f));
					num = (int)((num2 * 1267708325) ^ 0x36EF487C);
					continue;
				default:
					return;
				case 7u:
					break;
				case 19u:
					return;
				}
				break;
			}
		}
	}

	private void Form5_Load(object sender, EventArgs e)
	{
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected I4, but got Unknown
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected I4, but got Unknown
		//IL_025a: Incompatible stack heights: 0 vs 1
		//IL_026f: Incompatible stack heights: 0 vs 1
		//IL_0276: Incompatible stack heights: 0 vs 1
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		Form5.smethod_28(myconnection, Form5.smethod_27(MyProject.Forms.Form1.provider, MyProject.Forms.Form1.datafile));
		bool flag = Form5.smethod_29(MyProject.Forms.Form2.PID_Value, "", bool_0: false) == 0;
		string string_ = default(string);
		DataTable dataTable = default(DataTable);
		OleDbDataAdapter dbDataAdapter_ = default(OleDbDataAdapter);
		while (true)
		{
			int num = 96211372;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1AFA28DBu) % 5u)
				{
				case 3u:
					Form5.smethod_31();
					string_ = Form5.smethod_32("Select * From [Admit-Discharge] Where [PID] = ", MyProject.Forms.Form2.PID_Value, ";");
					dataTable = Form5.smethod_33();
					Form5.smethod_34(myconnection);
					num = 940076276;
					continue;
				case 2u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = -549645894;
						num7 = -549645894;
					}
					else
					{
						num6 = -1958055244;
						num7 = -1958055244;
					}
					num = num6 ^ ((int)num2 * -1131244717);
					continue;
				}
				case 0u:
					break;
				default:
					try
					{
						while (true)
						{
							int num3 = 1302897780;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x1AFA28DBu) % 10u)
								{
								case 9u:
									dbDataAdapter_ = Form5.smethod_35(string_, myconnection);
									num3 = (int)(num2 * 137758260) ^ -1966918047;
									continue;
								case 8u:
									Form5.smethod_41((Control)(object)SearchResultGrid, bool_0: true);
									num3 = 1600080283;
									continue;
								case 7u:
								{
									int num4;
									int num5;
									if (Form5.smethod_39(Form5.smethod_38(SearchResultGrid)) == 1)
									{
										num4 = -12166626;
										num5 = -12166626;
									}
									else
									{
										num4 = -2100014397;
										num5 = -2100014397;
									}
									num3 = num4 ^ ((int)num2 * -1881398254);
									continue;
								}
								case 5u:
									Form5.smethod_40((Form)(object)this);
									num3 = ((int)num2 * -25340887) ^ 0x21AD85C1;
									continue;
								case 3u:
									Form5.smethod_30("No Previous Patient History Found");
									num3 = (int)(num2 * 1376523183) ^ -1020443835;
									continue;
								case 2u:
									Form5.smethod_36((DbDataAdapter)(object)dbDataAdapter_, dataTable);
									Form5.smethod_37(SearchResultGrid, (object)dataTable);
									num3 = (int)(num2 * 724220152) ^ -54796764;
									continue;
								case 1u:
									num3 = ((int)num2 * -1415839558) ^ -975847033;
									continue;
								case 0u:
									Form5.smethod_42(myconnection);
									num3 = (int)(num2 * 122550365) ^ -1936153389;
									continue;
								default:
									return;
								case 4u:
									break;
								case 6u:
									return;
								}
								break;
							}
						}
					}
					catch (Exception exception_)
					{
						Form5.smethod_43(exception_);
						while (true)
						{
							_ = 1392211516;
							while (true)
							{
								_003F val = /*Error near IL_0225: Stack underflow*/^ 0x1AFA28DB;
								num2 = (uint)(int)val;
								switch (val % 4)
								{
								default:
									return;
								case 3:
									Form5.smethod_42(myconnection);
									_ = (num2 * 93831379) ^ 0xA5AB7252u;
									continue;
								case 0:
									Form5.smethod_44();
									_ = (num2 * 2127286926) ^ 0xFBB37A52u;
									continue;
								case 2:
									break;
								case 1:
									return;
								}
								break;
							}
						}
					}
				case 4u:
					Form5.smethod_30("No Patient Selected");
					return;
				}
				break;
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

	static DataGridView smethod_3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new DataGridView();
	}

	static void smethod_4(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.BeginInit();
	}

	static void smethod_5(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_6(DataGridView dataGridView_0, Color color_0)
	{
		dataGridView_0.set_BackgroundColor(color_0);
	}

	static void smethod_7(DataGridView dataGridView_0, DataGridViewColumnHeadersHeightSizeMode dataGridViewColumnHeadersHeightSizeMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		dataGridView_0.set_ColumnHeadersHeightSizeMode(dataGridViewColumnHeadersHeightSizeMode_0);
	}

	static void smethod_8(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_9(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_10(DataGridView dataGridView_0, bool bool_0)
	{
		dataGridView_0.set_ReadOnly(bool_0);
	}

	static DataGridViewRow smethod_11(DataGridView dataGridView_0)
	{
		return dataGridView_0.get_RowTemplate();
	}

	static void smethod_12(DataGridViewRow dataGridViewRow_0, int int_0)
	{
		dataGridViewRow_0.set_Height(int_0);
	}

	static void smethod_13(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_14(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_15(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_16(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_17(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static ControlCollection smethod_18(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_19(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_20(Form form_0, FormBorderStyle formBorderStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_FormBorderStyle(formBorderStyle_0);
	}

	static void smethod_21(Form form_0, bool bool_0)
	{
		form_0.set_MaximizeBox(bool_0);
	}

	static void smethod_22(Form form_0, bool bool_0)
	{
		form_0.set_MinimizeBox(bool_0);
	}

	static void smethod_23(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_24(Form form_0, string string_0)
	{
		form_0.set_Text(string_0);
	}

	static void smethod_25(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_26(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static string smethod_27(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static void smethod_28(OleDbConnection oleDbConnection_0, string string_0)
	{
		oleDbConnection_0.set_ConnectionString(string_0);
	}

	static int smethod_29(string string_0, string string_1, bool bool_0)
	{
		return Operators.CompareString(string_0, string_1, bool_0);
	}

	static DialogResult smethod_30(string string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0);
	}

	static OleDbCommand smethod_31()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new OleDbCommand();
	}

	static string smethod_32(string string_0, string string_1, string string_2)
	{
		return string_0 + string_1 + string_2;
	}

	static DataTable smethod_33()
	{
		return new DataTable();
	}

	static void smethod_34(OleDbConnection oleDbConnection_0)
	{
		oleDbConnection_0.Open();
	}

	static OleDbDataAdapter smethod_35(string string_0, OleDbConnection oleDbConnection_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new OleDbDataAdapter(string_0, oleDbConnection_0);
	}

	static int smethod_36(DbDataAdapter dbDataAdapter_0, DataTable dataTable_0)
	{
		return dbDataAdapter_0.Fill(dataTable_0);
	}

	static void smethod_37(DataGridView dataGridView_0, object object_0)
	{
		dataGridView_0.set_DataSource(object_0);
	}

	static DataGridViewRowCollection smethod_38(DataGridView dataGridView_0)
	{
		return dataGridView_0.get_Rows();
	}

	static int smethod_39(DataGridViewRowCollection dataGridViewRowCollection_0)
	{
		return dataGridViewRowCollection_0.get_Count();
	}

	static void smethod_40(Form form_0)
	{
		form_0.Close();
	}

	static void smethod_41(Control control_0, bool bool_0)
	{
		control_0.set_Visible(bool_0);
	}

	static void smethod_42(OleDbConnection oleDbConnection_0)
	{
		oleDbConnection_0.Close();
	}

	static void smethod_43(Exception exception_0)
	{
		ProjectData.SetProjectError(exception_0);
	}

	static void smethod_44()
	{
		ProjectData.ClearProjectError();
	}
}
