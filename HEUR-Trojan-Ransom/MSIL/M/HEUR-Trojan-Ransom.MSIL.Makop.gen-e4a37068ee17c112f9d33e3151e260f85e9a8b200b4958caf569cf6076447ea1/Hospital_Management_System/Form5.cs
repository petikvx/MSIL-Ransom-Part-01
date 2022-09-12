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
			int num = -623957806;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9F10AAF2u) % 3u)
				{
				case 1u:
					goto IL_0008;
				case 0u:
					break;
				default:
					InitializeComponent();
					return;
				}
				break;
				IL_0008:
				Form5.smethod_0((Form)(object)this, (EventHandler)Form5_Load);
				myconnection = Form5.smethod_1();
				num = ((int)num2 * -1076370877) ^ 0x2BE0D605;
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
				int num = 652776899;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x689D2EA1u) % 7u)
					{
					case 6u:
						num = 872174392;
						continue;
					case 5u:
						if (components != null)
						{
							num = 281409317;
							num3 = 281409317;
							continue;
						}
						goto IL_0025;
					case 4u:
						num = (int)(num2 * 1952996945) ^ -1050362174;
						continue;
					case 3u:
						if (disposing)
						{
							num = ((int)num2 * -1600170901) ^ 0x454D6C04;
							continue;
						}
						goto IL_0025;
					case 1u:
						Form5.smethod_2((IDisposable)components);
						num = ((int)num2 * -785342718) ^ -1174210479;
						continue;
					default:
						return;
					case 2u:
						break;
					case 0u:
						return;
						IL_0025:
						num = 1966086586;
						num3 = 1966086586;
						continue;
					}
					break;
				}
			}
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
			int num = -1720137191;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD98525ADu) % 27u)
				{
				case 26u:
					Form5.smethod_21((Form)(object)this, bool_0: false);
					num = (int)((num2 * 1702828247) ^ 0x159C3A0B);
					continue;
				case 25u:
					Form5.smethod_4((ISupportInitialize)SearchResultGrid);
					num = ((int)num2 * -1763499615) ^ -398854114;
					continue;
				case 24u:
					num = ((int)num2 * -734243229) ^ 0x55275EC7;
					continue;
				case 23u:
					Form5.smethod_24((Form)(object)this, "Form5");
					num = ((int)num2 * -618498988) ^ 0x133F18A3;
					continue;
				case 22u:
					Form5.smethod_15((ContainerControl)(object)this, new SizeF(8f, 16f));
					Form5.smethod_16((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -1165984105) ^ 0x73C8AE01;
					continue;
				case 21u:
					Form5.smethod_17((Form)(object)this, new Size(832, 375));
					num = ((int)num2 * -834928156) ^ -259616049;
					continue;
				case 20u:
					num = ((int)num2 * -1631509407) ^ 0x1FF44094;
					continue;
				case 19u:
					Form5.smethod_9((Control)(object)SearchResultGrid, "SearchResultGrid");
					num = (int)(num2 * 500207082) ^ -703437737;
					continue;
				case 18u:
					Form5.smethod_19(Form5.smethod_18((Control)(object)this), (Control)(object)SearchResultGrid);
					num = ((int)num2 * -161272232) ^ 0x4562A6BC;
					continue;
				case 17u:
					num = ((int)num2 * -993900495) ^ 0x13D58DC6;
					continue;
				case 16u:
					Form5.smethod_20((Form)(object)this, (FormBorderStyle)3);
					num = ((int)num2 * -1403443437) ^ -1305609884;
					continue;
				case 15u:
					Form5.smethod_22((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1435157338) ^ -768087337;
					continue;
				case 14u:
					num = ((int)num2 * -1378860247) ^ -825413788;
					continue;
				case 12u:
					Form5.smethod_8((Control)(object)SearchResultGrid, new Point(3, 1));
					num = (int)((num2 * 305845743) ^ 0x764423F1);
					continue;
				case 11u:
					Form5.smethod_10(SearchResultGrid, bool_0: true);
					Form5.smethod_12(Form5.smethod_11(SearchResultGrid), 24);
					Form5.smethod_13((Control)(object)SearchResultGrid, new Size(827, 372));
					num = (int)(num2 * 2016358958) ^ -622701497;
					continue;
				case 10u:
					Form5.smethod_6(SearchResultGrid, Color.White);
					Form5.smethod_7(SearchResultGrid, (DataGridViewColumnHeadersHeightSizeMode)2);
					num = (int)(num2 * 1311371944) ^ -931034803;
					continue;
				case 9u:
					Form5.smethod_26((Control)(object)this, bool_0: false);
					num = (int)((num2 * 631599879) ^ 0x14464C3B);
					continue;
				case 7u:
					num = ((int)num2 * -48387709) ^ 0x7F071A5F;
					continue;
				case 6u:
					Form5.smethod_25((ISupportInitialize)SearchResultGrid);
					num = ((int)num2 * -1115299136) ^ -1110054288;
					continue;
				case 5u:
					Form5.smethod_14((Control)(object)SearchResultGrid, 0);
					num = (int)((num2 * 1886742382) ^ 0x7AF4DBB8);
					continue;
				case 4u:
					num = ((int)num2 * -547213565) ^ -1937758044;
					continue;
				case 3u:
					num = (int)((num2 * 85276388) ^ 0x6DFA4068);
					continue;
				case 2u:
					Form5.smethod_5((Control)(object)this);
					num = (int)((num2 * 960347931) ^ 0x19CB0E7);
					continue;
				case 1u:
					SearchResultGrid = Form5.smethod_3();
					num = ((int)num2 * -1308655497) ^ -1641344891;
					continue;
				case 0u:
					Form5.smethod_23((Control)(object)this, "Form5");
					num = ((int)num2 * -1537876642) ^ 0x1347282A;
					continue;
				default:
					return;
				case 13u:
					break;
				case 8u:
					return;
				}
				break;
			}
		}
	}

	private void Form5_Load(object sender, EventArgs e)
	{
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected I4, but got Unknown
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected I4, but got Unknown
		//IL_0309: Incompatible stack heights: 0 vs 1
		//IL_0319: Incompatible stack heights: 0 vs 1
		//IL_0329: Incompatible stack heights: 0 vs 1
		//IL_0330: Incompatible stack heights: 0 vs 1
		string string_ = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num = 19058067;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2A334EBAu) % 9u)
				{
				case 8u:
				{
					int num6;
					int num7;
					if (Form5.smethod_29(MyProject.Forms.Form2.PID_Value, "", bool_0: false) == 0)
					{
						num6 = 1817079463;
						num7 = 1817079463;
					}
					else
					{
						num6 = 1105450385;
						num7 = 1105450385;
					}
					num = num6 ^ (int)(num2 * 1728121993);
					continue;
				}
				case 7u:
					Form5.smethod_28(myconnection, Form5.smethod_27(MyProject.Forms.Form1.provider, MyProject.Forms.Form1.datafile));
					num = ((int)num2 * -869698012) ^ -1983610751;
					continue;
				case 5u:
					num = ((int)num2 * -1761825607) ^ -1849417915;
					continue;
				case 3u:
					string_ = Form5.smethod_32("Select * From [Admit-Discharge] Where [PID] = ", MyProject.Forms.Form2.PID_Value, ";");
					num = (int)((num2 * 881662408) ^ 0x1BE2CF3A);
					continue;
				case 1u:
					Form5.smethod_31();
					num = ((int)num2 * -1882995965) ^ 0x1782CB0C;
					continue;
				case 0u:
					num = 2090850491;
					continue;
				case 4u:
					break;
				case 2u:
					Form5.smethod_30("No Patient Selected");
					return;
				default:
				{
					DataTable dataTable = Form5.smethod_33();
					Form5.smethod_34(myconnection);
					try
					{
						OleDbDataAdapter dbDataAdapter_ = Form5.smethod_35(string_, myconnection);
						while (true)
						{
							int num3 = 2032359584;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x2A334EBAu) % 13u)
								{
								case 12u:
									num3 = (int)(num2 * 2072522705) ^ -530693930;
									continue;
								case 11u:
									Form5.smethod_37(SearchResultGrid, (object)dataTable);
									num3 = ((int)num2 * -579198688) ^ 0x7C58939B;
									continue;
								case 10u:
									num3 = 982522112;
									continue;
								case 9u:
									Form5.smethod_42(myconnection);
									num3 = (int)((num2 * 581482004) ^ 0x37CCCECD);
									continue;
								case 6u:
									Form5.smethod_30("No Previous Patient History Found");
									num3 = (int)((num2 * 2028550419) ^ 0x70B265AD);
									continue;
								case 5u:
									Form5.smethod_41((Control)(object)SearchResultGrid, bool_0: true);
									num3 = ((int)num2 * -1314095894) ^ -1690131615;
									continue;
								case 4u:
									Form5.smethod_36((DbDataAdapter)(object)dbDataAdapter_, dataTable);
									num3 = (int)((num2 * 1115696423) ^ 0x6493E8C3);
									continue;
								case 3u:
									num3 = ((int)num2 * -1380200980) ^ -795231110;
									continue;
								case 2u:
								{
									int num4;
									int num5;
									if (flag)
									{
										num4 = 987815648;
										num5 = 987815648;
									}
									else
									{
										num4 = 1838800791;
										num5 = 1838800791;
									}
									num3 = num4 ^ (int)(num2 * 1310621900);
									continue;
								}
								case 1u:
									flag = Form5.smethod_39(Form5.smethod_38(SearchResultGrid)) == 1;
									num3 = ((int)num2 * -1104740618) ^ -1047871575;
									continue;
								case 0u:
									Form5.smethod_40((Form)(object)this);
									num3 = (int)((num2 * 1851030918) ^ 0x7FC0EAF0);
									continue;
								default:
									return;
								case 7u:
									break;
								case 8u:
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
							_ = 1273587448;
							while (true)
							{
								_003F val = /*Error near IL_02d0: Stack underflow*/^ 0x2A334EBA;
								num2 = (uint)(int)val;
								switch (val % 5)
								{
								case 4:
									Form5.smethod_42(myconnection);
									_ = (num2 * 1497965766) ^ 0xA337916Fu;
									continue;
								case 2:
									_ = ((int)num2 * -3308535) ^ -1740710011;
									continue;
								case 1:
									_ = ((int)num2 * -1272402850) ^ 0x70F4216C;
									continue;
								case 0:
									break;
								default:
									Form5.smethod_44();
									return;
								}
								break;
							}
						}
					}
				}
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
