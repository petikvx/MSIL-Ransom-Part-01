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
			int num = -1369566902;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC1847619u) % 6u)
				{
				case 5u:
					num = ((int)num2 * -553492559) ^ -233922627;
					continue;
				case 3u:
					Form5.smethod_0((Form)(object)this, (EventHandler)Form5_Load);
					num = ((int)num2 * -819724089) ^ 0x9DC1159;
					continue;
				case 1u:
					num = (int)(num2 * 1733047355) ^ -1434021978;
					continue;
				case 0u:
					myconnection = Form5.smethod_1();
					InitializeComponent();
					num = (int)((num2 * 1491668901) ^ 0x5A7242DB);
					continue;
				default:
					return;
				case 4u:
					break;
				case 2u:
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
			int num = -1700617654;
			goto IL_0042;
			IL_0042:
			int num3;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x84B8752Du) % 5u)
				{
				case 3u:
					break;
				case 2u:
					num = ((int)num2 * -1913764357) ^ -1738783683;
					continue;
				case 0u:
					Form5.smethod_2((IDisposable)components);
					num = ((int)num2 * -1113671385) ^ -233094536;
					continue;
				default:
					return;
				case 4u:
					goto IL_0067;
				case 1u:
					return;
				}
				break;
				IL_0067:
				if (components != null)
				{
					num = -1498551955;
					num3 = -1498551955;
					continue;
				}
				goto IL_0072;
			}
			goto IL_0014;
			IL_0072:
			num = -347611862;
			num3 = -347611862;
			goto IL_0042;
		}
		finally
		{
			while (true)
			{
				IL_00cb:
				int num4 = -1093403921;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num4 ^ 0x84B8752Du) % 4u)
					{
					case 2u:
						((Form)this).Dispose(disposing);
						num4 = (int)((num2 * 3828608) ^ 0x3BF6C438);
						continue;
					case 1u:
						num4 = ((int)num2 * -2001244869) ^ 0x4873B2F2;
						continue;
					default:
						goto end_IL_00aa;
					case 3u:
						break;
					case 0u:
						goto end_IL_00aa;
					}
					goto IL_00cb;
					continue;
					end_IL_00aa:
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
			int num = 1243648048;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x21C07D72u) % 28u)
				{
				case 27u:
					Form5.smethod_17((Form)(object)this, new Size(832, 375));
					num = ((int)num2 * -458700973) ^ -338467064;
					continue;
				case 26u:
					Form5.smethod_19(Form5.smethod_18((Control)(object)this), (Control)(object)SearchResultGrid);
					Form5.smethod_20((Form)(object)this, (FormBorderStyle)3);
					num = ((int)num2 * -494108360) ^ 0x294468B6;
					continue;
				case 24u:
					Form5.smethod_8((Control)(object)SearchResultGrid, new Point(3, 1));
					num = (int)(num2 * 227074607) ^ -963003154;
					continue;
				case 23u:
					Form5.smethod_6(SearchResultGrid, Color.White);
					num = ((int)num2 * -576377931) ^ 0x4BF0C5F2;
					continue;
				case 22u:
					num = ((int)num2 * -1540602194) ^ -2088963333;
					continue;
				case 21u:
					Form5.smethod_16((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -2146809501) ^ -1147606122;
					continue;
				case 20u:
					num = (int)((num2 * 4693991) ^ 0xC78043A);
					continue;
				case 19u:
					Form5.smethod_25((ISupportInitialize)SearchResultGrid);
					num = ((int)num2 * -860528127) ^ -1617000559;
					continue;
				case 18u:
					Form5.smethod_10(SearchResultGrid, bool_0: true);
					Form5.smethod_12(Form5.smethod_11(SearchResultGrid), 24);
					num = ((int)num2 * -391105918) ^ 0x5AFE811B;
					continue;
				case 17u:
					Form5.smethod_13((Control)(object)SearchResultGrid, new Size(827, 372));
					num = (int)((num2 * 1138027323) ^ 0x105E6CDF);
					continue;
				case 16u:
					Form5.smethod_21((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1852073779) ^ 0x25B620DF;
					continue;
				case 15u:
					Form5.smethod_23((Control)(object)this, "Form5");
					num = (int)(num2 * 1792668297) ^ -631770149;
					continue;
				case 14u:
					num = ((int)num2 * -1095001590) ^ -1385018260;
					continue;
				case 13u:
					Form5.smethod_4((ISupportInitialize)SearchResultGrid);
					num = (int)(num2 * 1876415813) ^ -1308521753;
					continue;
				case 12u:
					Form5.smethod_5((Control)(object)this);
					num = ((int)num2 * -1069548365) ^ -1399547207;
					continue;
				case 11u:
					num = (int)(num2 * 315694102) ^ -1482681633;
					continue;
				case 9u:
					Form5.smethod_22((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1943176959) ^ -1167502888;
					continue;
				case 8u:
					num = ((int)num2 * -934757654) ^ 0x41780596;
					continue;
				case 7u:
					num = ((int)num2 * -630019716) ^ 0x7C1617F0;
					continue;
				case 6u:
					Form5.smethod_24((Form)(object)this, "Form5");
					num = (int)((num2 * 1402216095) ^ 0x6576F10F);
					continue;
				case 5u:
					num = (int)(num2 * 680283709) ^ -333070010;
					continue;
				case 4u:
					Form5.smethod_9((Control)(object)SearchResultGrid, "SearchResultGrid");
					num = ((int)num2 * -1152619152) ^ 0x286869D0;
					continue;
				case 3u:
					Form5.smethod_7(SearchResultGrid, (DataGridViewColumnHeadersHeightSizeMode)2);
					num = ((int)num2 * -391189857) ^ -811238073;
					continue;
				case 2u:
					Form5.smethod_14((Control)(object)SearchResultGrid, 0);
					Form5.smethod_15((ContainerControl)(object)this, new SizeF(8f, 16f));
					num = ((int)num2 * -1824264456) ^ -767098441;
					continue;
				case 1u:
					Form5.smethod_26((Control)(object)this, bool_0: false);
					num = ((int)num2 * -569399043) ^ 0x1EFF12CA;
					continue;
				case 0u:
					num = ((int)num2 * -592298770) ^ -543301293;
					continue;
				default:
					return;
				case 10u:
					break;
				case 25u:
					return;
				}
				break;
			}
		}
	}

	private void Form5_Load(object sender, EventArgs e)
	{
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected I4, but got Unknown
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected I4, but got Unknown
		//IL_02f8: Incompatible stack heights: 0 vs 1
		//IL_0308: Incompatible stack heights: 0 vs 1
		//IL_031d: Incompatible stack heights: 0 vs 1
		//IL_0324: Incompatible stack heights: 0 vs 1
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		string string_ = default(string);
		DataTable dataTable = default(DataTable);
		bool flag = default(bool);
		OleDbDataAdapter dbDataAdapter_ = default(OleDbDataAdapter);
		while (true)
		{
			int num = 1954677950;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x322FFD21u) % 11u)
				{
				case 10u:
					Form5.smethod_31();
					num = ((int)num2 * -1560729621) ^ -431549585;
					continue;
				case 9u:
					string_ = Form5.smethod_32("Select * From [Admit-Discharge] Where [PID] = ", MyProject.Forms.Form2.PID_Value, ";");
					num = ((int)num2 * -666058929) ^ 0x38F0BCE5;
					continue;
				case 8u:
					Form5.smethod_28(myconnection, Form5.smethod_27(MyProject.Forms.Form1.provider, MyProject.Forms.Form1.datafile));
					num = ((int)num2 * -205095825) ^ -1896814178;
					continue;
				case 7u:
					dataTable = Form5.smethod_33();
					num = (int)((num2 * 910666566) ^ 0x5108D191);
					continue;
				case 6u:
					num = 1810877288;
					continue;
				case 4u:
					flag = Form5.smethod_29(MyProject.Forms.Form2.PID_Value, "", bool_0: false) == 0;
					num = ((int)num2 * -594942486) ^ -842476461;
					continue;
				case 3u:
					Form5.smethod_34(myconnection);
					num = (int)((num2 * 369011595) ^ 0x682B9C0D);
					continue;
				case 1u:
				{
					int num6;
					int num7;
					if (!flag)
					{
						num6 = -1680286988;
						num7 = -1680286988;
					}
					else
					{
						num6 = -1758613599;
						num7 = -1758613599;
					}
					num = num6 ^ (int)(num2 * 1901966292);
					continue;
				}
				case 5u:
					break;
				default:
					try
					{
						while (true)
						{
							int num3 = 1644187929;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x322FFD21u) % 11u)
								{
								case 9u:
									dbDataAdapter_ = Form5.smethod_35(string_, myconnection);
									num3 = (int)((num2 * 242737287) ^ 0x7E6126C3);
									continue;
								case 8u:
								{
									int num4;
									int num5;
									if (Form5.smethod_39(Form5.smethod_38(SearchResultGrid)) != 1)
									{
										num4 = 1255973060;
										num5 = 1255973060;
									}
									else
									{
										num4 = 976561778;
										num5 = 976561778;
									}
									num3 = num4 ^ ((int)num2 * -1673235052);
									continue;
								}
								case 7u:
									Form5.smethod_36((DbDataAdapter)(object)dbDataAdapter_, dataTable);
									Form5.smethod_37(SearchResultGrid, (object)dataTable);
									num3 = (int)((num2 * 1097722692) ^ 0x482F029);
									continue;
								case 5u:
									Form5.smethod_40((Form)(object)this);
									num3 = (int)(num2 * 815402292) ^ -128123046;
									continue;
								case 4u:
									num3 = (int)((num2 * 1279209709) ^ 0x3154158E);
									continue;
								case 3u:
									num3 = 901890668;
									continue;
								case 2u:
									num3 = (int)(num2 * 2095284102) ^ -411554306;
									continue;
								case 1u:
									Form5.smethod_41((Control)(object)SearchResultGrid, bool_0: true);
									num3 = ((int)num2 * -649743235) ^ -701966664;
									continue;
								case 0u:
									Form5.smethod_30("No Previous Patient History Found");
									num3 = (int)((num2 * 438277506) ^ 0x147C0BA0);
									continue;
								case 10u:
									break;
								default:
									Form5.smethod_42(myconnection);
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
							_ = 56783380;
							while (true)
							{
								_003F val = /*Error near IL_02bf: Stack underflow*/^ 0x322FFD21;
								num2 = (uint)(int)val;
								switch (val % 5)
								{
								default:
									return;
								case 2:
									Form5.smethod_42(myconnection);
									_ = (num2 * 1524922586) ^ 0xB92DA607u;
									continue;
								case 1:
									_ = ((int)num2 * -546533841) ^ -717330349;
									continue;
								case 0:
									Form5.smethod_44();
									_ = ((int)num2 * -836142792) ^ 0x3D48FB59;
									continue;
								case 4:
									break;
								case 3:
									return;
								}
								break;
							}
						}
					}
				case 2u:
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
