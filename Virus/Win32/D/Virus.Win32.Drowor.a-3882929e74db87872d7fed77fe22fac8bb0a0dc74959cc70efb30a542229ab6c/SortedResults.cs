using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class SortedResults : Form
{
	private IContainer icontainer_0;

	private Button btnClose;

	private DataGridView dataGridViewResults;

	private DataGridViewTextBoxColumn cCoordinates;

	private DataGridViewTextBoxColumn cType;

	private DataGridViewTextBoxColumn cStatus;

	public SortedResults()
	{
		InitializeComponent();
	}

	public void method_0(List<GStruct3> list_0)
	{
		list_0.Sort();
		dataGridViewResults.get_Rows().Clear();
		for (int i = 0; i < list_0.Count; i++)
		{
			int num = dataGridViewResults.get_Rows().Add();
			DataGridViewRow val = dataGridViewResults.get_Rows().get_Item(num);
			GStruct3 gStruct = list_0[i];
			val.get_Cells().get_Item(0).set_Value((object)("( " + gStruct.int_0 + " | " + gStruct.int_1 + " )"));
			val.get_Cells().get_Item(1).set_Value((object)gStruct.string_0);
			val.get_Cells().get_Item(2).set_Value((object)gStruct.string_1);
		}
	}

	private void btnClose_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	void Form.Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		btnClose = new Button();
		dataGridViewResults = new DataGridView();
		cCoordinates = new DataGridViewTextBoxColumn();
		cType = new DataGridViewTextBoxColumn();
		cStatus = new DataGridViewTextBoxColumn();
		((ISupportInitialize)dataGridViewResults).BeginInit();
		((Control)this).SuspendLayout();
		((Control)btnClose).set_Anchor((AnchorStyles)2);
		((Control)btnClose).set_Location(new Point(217, 412));
		((Control)btnClose).set_Name("btnClose");
		((Control)btnClose).set_Size(new Size(88, 23));
		((Control)btnClose).set_TabIndex(1);
		((Control)btnClose).set_Text("Close");
		((ButtonBase)btnClose).set_UseVisualStyleBackColor(true);
		((Control)btnClose).add_Click((EventHandler)btnClose_Click);
		dataGridViewResults.set_AllowUserToDeleteRows(false);
		dataGridViewResults.set_AllowUserToOrderColumns(true);
		((Control)dataGridViewResults).set_Anchor((AnchorStyles)15);
		dataGridViewResults.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		dataGridViewResults.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[3]
		{
			(DataGridViewColumn)cCoordinates,
			(DataGridViewColumn)cType,
			(DataGridViewColumn)cStatus
		});
		dataGridViewResults.set_GridColor(SystemColors.ControlDarkDark);
		((Control)dataGridViewResults).set_Location(new Point(12, 12));
		((Control)dataGridViewResults).set_Name("dataGridViewResults");
		dataGridViewResults.set_ReadOnly(true);
		((Control)dataGridViewResults).set_Size(new Size(494, 394));
		((Control)dataGridViewResults).set_TabIndex(2);
		((DataGridViewColumn)cCoordinates).set_HeaderText("Coordinates");
		((DataGridViewColumn)cCoordinates).set_Name("cCoordinates");
		((DataGridViewBand)cCoordinates).set_ReadOnly(true);
		((DataGridViewColumn)cCoordinates).set_Width(150);
		((DataGridViewColumn)cType).set_HeaderText("Type");
		((DataGridViewColumn)cType).set_Name("cType");
		((DataGridViewBand)cType).set_ReadOnly(true);
		((DataGridViewColumn)cType).set_Width(150);
		((DataGridViewColumn)cStatus).set_HeaderText("Status");
		((DataGridViewColumn)cStatus).set_Name("cStatus");
		((DataGridViewBand)cStatus).set_ReadOnly(true);
		((DataGridViewColumn)cStatus).set_Width(150);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(518, 441));
		((Control)this).get_Controls().Add((Control)(object)dataGridViewResults);
		((Control)this).get_Controls().Add((Control)(object)btnClose);
		((Control)this).set_Name("SortedResults");
		((Form)this).set_SizeGripStyle((SizeGripStyle)1);
		((Control)this).set_Text("Sorted results");
		((ISupportInitialize)dataGridViewResults).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
