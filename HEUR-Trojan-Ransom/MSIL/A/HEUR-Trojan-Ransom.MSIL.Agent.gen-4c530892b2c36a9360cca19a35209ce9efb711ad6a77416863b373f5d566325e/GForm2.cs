using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

public class GForm2 : Form
{
	private BindingSource bindingSource_0 = GForm2.smethod_0();

	private IContainer icontainer_0 = null;

	private DataGridView dataGridView_0;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

	public GForm2()
	{
		method_1();
	}

	private void method_0(object sender, EventArgs e)
	{
		string string_ = "Data Source = ВЛАДИМИР-ПК\\SQLEXPRESS; Initial Catalog = SnakeBase; Trusted_Connection = True";
		SqlConnection val = GForm2.smethod_1(string_);
		GForm2.smethod_2((DbConnection)(object)val);
		SqlDataAdapter dbDataAdapter_ = GForm2.smethod_3("select nickname, score from leaderboard order by score desc", val);
		DataTable dataTable = GForm2.smethod_4();
		GForm2.smethod_5((DbDataAdapter)(object)dbDataAdapter_, dataTable);
		GForm2.smethod_6(bindingSource_0, (object)dataTable);
		GForm2.smethod_7((DbConnection)(object)val);
		GForm2.smethod_9(GForm2.smethod_8(dataGridView_0), (DataGridViewContentAlignment)32);
		GForm2.smethod_9(GForm2.smethod_10(dataGridView_0), (DataGridViewContentAlignment)32);
		GForm2.smethod_11(dataGridView_0, (DataGridViewAutoSizeColumnsMode)4);
		GForm2.smethod_12(dataGridView_0, (object)bindingSource_0);
		for (int i = 0; i < GForm2.smethod_16(GForm2.smethod_15(dataGridView_0)); i++)
		{
			GForm2.smethod_14(GForm2.smethod_13(dataGridView_0, 0, i), (object)(i + 1));
		}
	}

	void Form.Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			GForm2.smethod_17((IDisposable)icontainer_0);
		}
		((Form)this).Dispose(disposing);
	}

	private void method_1()
	{
		dataGridView_0 = GForm2.smethod_18();
		dataGridViewTextBoxColumn_0 = GForm2.smethod_19();
		GForm2.smethod_20((ISupportInitialize)dataGridView_0);
		GForm2.smethod_21((Control)(object)this);
		GForm2.smethod_22(dataGridView_0, bool_0: false);
		GForm2.smethod_23(dataGridView_0, bool_0: false);
		GForm2.smethod_24(dataGridView_0, bool_0: false);
		GForm2.smethod_25(dataGridView_0, bool_0: false);
		GForm2.smethod_26(dataGridView_0, (DataGridViewAutoSizeColumnsMode)6);
		GForm2.smethod_27(dataGridView_0, (DataGridViewAutoSizeRowsMode)7);
		GForm2.smethod_28(dataGridView_0, (DataGridViewColumnHeadersHeightSizeMode)2);
		GForm2.smethod_30(GForm2.smethod_29(dataGridView_0), (DataGridViewColumn[])(object)new DataGridViewColumn[1] { (DataGridViewColumn)dataGridViewTextBoxColumn_0 });
		GForm2.smethod_31((Control)(object)dataGridView_0, new Point(12, 12));
		GForm2.smethod_32((Control)(object)dataGridView_0, "dataGridView");
		GForm2.smethod_33(dataGridView_0, bool_0: true);
		GForm2.smethod_34((Control)(object)dataGridView_0, new Size(219, 223));
		GForm2.smethod_35((Control)(object)dataGridView_0, 3);
		GForm2.smethod_36((DataGridViewColumn)(object)dataGridViewTextBoxColumn_0, (DataGridViewAutoSizeColumnMode)6);
		GForm2.smethod_37((DataGridViewColumn)(object)dataGridViewTextBoxColumn_0, "#");
		GForm2.smethod_38((DataGridViewColumn)(object)dataGridViewTextBoxColumn_0, "numbers");
		GForm2.smethod_39((DataGridViewBand)(object)dataGridViewTextBoxColumn_0, bool_0: true);
		GForm2.smethod_40((DataGridViewColumn)(object)dataGridViewTextBoxColumn_0, 39);
		GForm2.smethod_41((ContainerControl)(object)this, new SizeF(6f, 13f));
		GForm2.smethod_42((ContainerControl)(object)this, (AutoScaleMode)1);
		GForm2.smethod_43((Form)(object)this, new Size(243, 249));
		GForm2.smethod_45(GForm2.smethod_44((Control)(object)this), (Control)(object)dataGridView_0);
		GForm2.smethod_46((Control)(object)this, "leaderboardForm");
		GForm2.smethod_47((Control)(object)this, "Таблица лидеров");
		GForm2.smethod_48((Form)(object)this, (EventHandler)method_0);
		GForm2.smethod_49((ISupportInitialize)dataGridView_0);
		GForm2.smethod_50((Control)(object)this, bool_0: false);
	}

	static BindingSource smethod_0()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new BindingSource();
	}

	static SqlConnection smethod_1(string string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new SqlConnection(string_0);
	}

	static void smethod_2(DbConnection dbConnection_0)
	{
		dbConnection_0.Open();
	}

	static SqlDataAdapter smethod_3(string string_0, SqlConnection sqlConnection_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new SqlDataAdapter(string_0, sqlConnection_0);
	}

	static DataTable smethod_4()
	{
		return new DataTable();
	}

	static int smethod_5(DbDataAdapter dbDataAdapter_0, DataTable dataTable_0)
	{
		return dbDataAdapter_0.Fill(dataTable_0);
	}

	static void smethod_6(BindingSource bindingSource_1, object object_0)
	{
		bindingSource_1.set_DataSource(object_0);
	}

	static void smethod_7(DbConnection dbConnection_0)
	{
		dbConnection_0.Close();
	}

	static DataGridViewCellStyle smethod_8(DataGridView dataGridView_1)
	{
		return dataGridView_1.get_ColumnHeadersDefaultCellStyle();
	}

	static void smethod_9(DataGridViewCellStyle dataGridViewCellStyle_0, DataGridViewContentAlignment dataGridViewContentAlignment_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		dataGridViewCellStyle_0.set_Alignment(dataGridViewContentAlignment_0);
	}

	static DataGridViewCellStyle smethod_10(DataGridView dataGridView_1)
	{
		return dataGridView_1.get_DefaultCellStyle();
	}

	static void smethod_11(DataGridView dataGridView_1, DataGridViewAutoSizeColumnsMode dataGridViewAutoSizeColumnsMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		dataGridView_1.AutoResizeColumns(dataGridViewAutoSizeColumnsMode_0);
	}

	static void smethod_12(DataGridView dataGridView_1, object object_0)
	{
		dataGridView_1.set_DataSource(object_0);
	}

	static DataGridViewCell smethod_13(DataGridView dataGridView_1, int int_0, int int_1)
	{
		return dataGridView_1.get_Item(int_0, int_1);
	}

	static void smethod_14(DataGridViewCell dataGridViewCell_0, object object_0)
	{
		dataGridViewCell_0.set_Value(object_0);
	}

	static DataGridViewRowCollection smethod_15(DataGridView dataGridView_1)
	{
		return dataGridView_1.get_Rows();
	}

	static int smethod_16(DataGridViewRowCollection dataGridViewRowCollection_0)
	{
		return dataGridViewRowCollection_0.get_Count();
	}

	static void smethod_17(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static DataGridView smethod_18()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new DataGridView();
	}

	static DataGridViewTextBoxColumn smethod_19()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new DataGridViewTextBoxColumn();
	}

	static void smethod_20(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.BeginInit();
	}

	static void smethod_21(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_22(DataGridView dataGridView_1, bool bool_0)
	{
		dataGridView_1.set_AllowUserToAddRows(bool_0);
	}

	static void smethod_23(DataGridView dataGridView_1, bool bool_0)
	{
		dataGridView_1.set_AllowUserToDeleteRows(bool_0);
	}

	static void smethod_24(DataGridView dataGridView_1, bool bool_0)
	{
		dataGridView_1.set_AllowUserToResizeColumns(bool_0);
	}

	static void smethod_25(DataGridView dataGridView_1, bool bool_0)
	{
		dataGridView_1.set_AllowUserToResizeRows(bool_0);
	}

	static void smethod_26(DataGridView dataGridView_1, DataGridViewAutoSizeColumnsMode dataGridViewAutoSizeColumnsMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		dataGridView_1.set_AutoSizeColumnsMode(dataGridViewAutoSizeColumnsMode_0);
	}

	static void smethod_27(DataGridView dataGridView_1, DataGridViewAutoSizeRowsMode dataGridViewAutoSizeRowsMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		dataGridView_1.set_AutoSizeRowsMode(dataGridViewAutoSizeRowsMode_0);
	}

	static void smethod_28(DataGridView dataGridView_1, DataGridViewColumnHeadersHeightSizeMode dataGridViewColumnHeadersHeightSizeMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		dataGridView_1.set_ColumnHeadersHeightSizeMode(dataGridViewColumnHeadersHeightSizeMode_0);
	}

	static DataGridViewColumnCollection smethod_29(DataGridView dataGridView_1)
	{
		return dataGridView_1.get_Columns();
	}

	static void smethod_30(DataGridViewColumnCollection dataGridViewColumnCollection_0, DataGridViewColumn[] dataGridViewColumn_0)
	{
		dataGridViewColumnCollection_0.AddRange(dataGridViewColumn_0);
	}

	static void smethod_31(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_32(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_33(DataGridView dataGridView_1, bool bool_0)
	{
		dataGridView_1.set_ReadOnly(bool_0);
	}

	static void smethod_34(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_35(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_36(DataGridViewColumn dataGridViewColumn_0, DataGridViewAutoSizeColumnMode dataGridViewAutoSizeColumnMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		dataGridViewColumn_0.set_AutoSizeMode(dataGridViewAutoSizeColumnMode_0);
	}

	static void smethod_37(DataGridViewColumn dataGridViewColumn_0, string string_0)
	{
		dataGridViewColumn_0.set_HeaderText(string_0);
	}

	static void smethod_38(DataGridViewColumn dataGridViewColumn_0, string string_0)
	{
		dataGridViewColumn_0.set_Name(string_0);
	}

	static void smethod_39(DataGridViewBand dataGridViewBand_0, bool bool_0)
	{
		dataGridViewBand_0.set_ReadOnly(bool_0);
	}

	static void smethod_40(DataGridViewColumn dataGridViewColumn_0, int int_0)
	{
		dataGridViewColumn_0.set_Width(int_0);
	}

	static void smethod_41(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_42(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_43(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static ControlCollection smethod_44(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_45(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_46(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_47(Control control_0, string string_0)
	{
		control_0.set_Text(string_0);
	}

	static void smethod_48(Form form_0, EventHandler eventHandler_0)
	{
		form_0.add_Load(eventHandler_0);
	}

	static void smethod_49(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_50(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}
}
