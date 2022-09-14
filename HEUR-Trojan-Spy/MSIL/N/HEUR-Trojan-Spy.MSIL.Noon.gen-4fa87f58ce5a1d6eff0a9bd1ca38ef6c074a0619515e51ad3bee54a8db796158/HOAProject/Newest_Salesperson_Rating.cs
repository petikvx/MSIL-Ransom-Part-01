using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using HOAProject.My;
using Microsoft.VisualBasic.CompilerServices;

namespace HOAProject;

[DesignerGenerated]
public class Newest_Salesperson_Rating : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("SALESPERSONRATINGSBindingSource")]
	internal virtual BindingSource SALESPERSONRATINGSBindingSource
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridView1")]
	internal virtual DataGridView DataGridView1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SALESPERSONIDDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn SALESPERSONIDDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CUSTOMERIDDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn CUSTOMERIDDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RATINGVALUEDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn RATINGVALUEDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RATINGCOMMENTSDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn RATINGCOMMENTSDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RATINGDATEDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn RATINGDATEDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SALESPERSONRATINGSBindingSource1")]
	internal virtual BindingSource SALESPERSONRATINGSBindingSource1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Newest_ReviewsToolStrip")]
	internal virtual ToolStrip Newest_ReviewsToolStrip
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripButton Newest_ReviewsToolStripButton
	{
		[CompilerGenerated]
		get
		{
			return _Newest_ReviewsToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Newest_ReviewsToolStripButton_Click;
			ToolStripButton newest_ReviewsToolStripButton = _Newest_ReviewsToolStripButton;
			if (newest_ReviewsToolStripButton != null)
			{
				((ToolStripItem)newest_ReviewsToolStripButton).remove_Click(eventHandler);
			}
			_Newest_ReviewsToolStripButton = value;
			newest_ReviewsToolStripButton = _Newest_ReviewsToolStripButton;
			if (newest_ReviewsToolStripButton != null)
			{
				((ToolStripItem)newest_ReviewsToolStripButton).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button ReturnButton
	{
		[CompilerGenerated]
		get
		{
			return _ReturnButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Button1_Click;
			Button returnButton = _ReturnButton;
			if (returnButton != null)
			{
				((Control)returnButton).remove_Click(eventHandler);
			}
			_ReturnButton = value;
			returnButton = _ReturnButton;
			if (returnButton != null)
			{
				((Control)returnButton).add_Click(eventHandler);
			}
		}
	}

	public Newest_Salesperson_Rating()
	{
		((Form)this).add_Load((EventHandler)Newest_Salesperson_Rating_Load);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		components = new Container();
		DataGridView1 = new DataGridView();
		SALESPERSONIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		CUSTOMERIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		RATINGVALUEDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		RATINGCOMMENTSDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		RATINGDATEDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		SALESPERSONRATINGSBindingSource1 = new BindingSource(components);
		Newest_ReviewsToolStrip = new ToolStrip();
		Newest_ReviewsToolStripButton = new ToolStripButton();
		ReturnButton = new Button();
		SALESPERSONRATINGSBindingSource = new BindingSource(components);
		((ISupportInitialize)DataGridView1).BeginInit();
		((ISupportInitialize)SALESPERSONRATINGSBindingSource1).BeginInit();
		((Control)Newest_ReviewsToolStrip).SuspendLayout();
		((ISupportInitialize)SALESPERSONRATINGSBindingSource).BeginInit();
		((Control)this).SuspendLayout();
		DataGridView1.set_AutoGenerateColumns(false);
		DataGridView1.set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)6);
		DataGridView1.set_AutoSizeRowsMode((DataGridViewAutoSizeRowsMode)7);
		DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		DataGridView1.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[5]
		{
			(DataGridViewColumn)SALESPERSONIDDataGridViewTextBoxColumn,
			(DataGridViewColumn)CUSTOMERIDDataGridViewTextBoxColumn,
			(DataGridViewColumn)RATINGVALUEDataGridViewTextBoxColumn,
			(DataGridViewColumn)RATINGCOMMENTSDataGridViewTextBoxColumn,
			(DataGridViewColumn)RATINGDATEDataGridViewTextBoxColumn
		});
		DataGridView1.set_DataSource((object)SALESPERSONRATINGSBindingSource1);
		((Control)DataGridView1).set_Location(new Point(82, 72));
		((Control)DataGridView1).set_Name("DataGridView1");
		DataGridView1.set_RowHeadersVisible(false);
		((Control)DataGridView1).set_Size(new Size(607, 223));
		((Control)DataGridView1).set_TabIndex(0);
		((DataGridViewColumn)SALESPERSONIDDataGridViewTextBoxColumn).set_DataPropertyName("SALESPERSON_ID");
		((DataGridViewColumn)SALESPERSONIDDataGridViewTextBoxColumn).set_HeaderText("SALESPERSON_ID");
		((DataGridViewColumn)SALESPERSONIDDataGridViewTextBoxColumn).set_Name("SALESPERSONIDDataGridViewTextBoxColumn");
		((DataGridViewColumn)SALESPERSONIDDataGridViewTextBoxColumn).set_Width(128);
		((DataGridViewColumn)CUSTOMERIDDataGridViewTextBoxColumn).set_DataPropertyName("CUSTOMER_ID");
		((DataGridViewColumn)CUSTOMERIDDataGridViewTextBoxColumn).set_HeaderText("CUSTOMER_ID");
		((DataGridViewColumn)CUSTOMERIDDataGridViewTextBoxColumn).set_Name("CUSTOMERIDDataGridViewTextBoxColumn");
		((DataGridViewColumn)CUSTOMERIDDataGridViewTextBoxColumn).set_Width(110);
		((DataGridViewColumn)RATINGVALUEDataGridViewTextBoxColumn).set_DataPropertyName("RATING_VALUE");
		((DataGridViewColumn)RATINGVALUEDataGridViewTextBoxColumn).set_HeaderText("RATING_VALUE");
		((DataGridViewColumn)RATINGVALUEDataGridViewTextBoxColumn).set_Name("RATINGVALUEDataGridViewTextBoxColumn");
		((DataGridViewColumn)RATINGVALUEDataGridViewTextBoxColumn).set_Width(114);
		((DataGridViewColumn)RATINGCOMMENTSDataGridViewTextBoxColumn).set_DataPropertyName("RATING_COMMENTS");
		((DataGridViewColumn)RATINGCOMMENTSDataGridViewTextBoxColumn).set_HeaderText("RATING_COMMENTS");
		((DataGridViewColumn)RATINGCOMMENTSDataGridViewTextBoxColumn).set_Name("RATINGCOMMENTSDataGridViewTextBoxColumn");
		((DataGridViewColumn)RATINGCOMMENTSDataGridViewTextBoxColumn).set_Width(141);
		((DataGridViewColumn)RATINGDATEDataGridViewTextBoxColumn).set_DataPropertyName("RATING_DATE");
		((DataGridViewColumn)RATINGDATEDataGridViewTextBoxColumn).set_HeaderText("RATING_DATE");
		((DataGridViewColumn)RATINGDATEDataGridViewTextBoxColumn).set_Name("RATINGDATEDataGridViewTextBoxColumn");
		((DataGridViewColumn)RATINGDATEDataGridViewTextBoxColumn).set_Width(108);
		SALESPERSONRATINGSBindingSource1.set_DataMember("SALESPERSON_RATINGS");
		Newest_ReviewsToolStrip.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)Newest_ReviewsToolStripButton });
		((Control)Newest_ReviewsToolStrip).set_Location(new Point(0, 0));
		((Control)Newest_ReviewsToolStrip).set_Name("Newest_ReviewsToolStrip");
		((Control)Newest_ReviewsToolStrip).set_Size(new Size(800, 25));
		((Control)Newest_ReviewsToolStrip).set_TabIndex(1);
		((Control)Newest_ReviewsToolStrip).set_Text("Newest_ReviewsToolStrip");
		((ToolStripItem)Newest_ReviewsToolStripButton).set_DisplayStyle((ToolStripItemDisplayStyle)1);
		((ToolStripItem)Newest_ReviewsToolStripButton).set_Name("Newest_ReviewsToolStripButton");
		((ToolStripItem)Newest_ReviewsToolStripButton).set_Size(new Size(104, 22));
		((ToolStripItem)Newest_ReviewsToolStripButton).set_Text("NEWEST REVIEWS");
		((Control)ReturnButton).set_Location(new Point(332, 372));
		((Control)ReturnButton).set_Name("ReturnButton");
		((Control)ReturnButton).set_Size(new Size(114, 46));
		((Control)ReturnButton).set_TabIndex(3);
		((Control)ReturnButton).set_TabStop(false);
		((ButtonBase)ReturnButton).set_Text("Return to All Reviews");
		((ButtonBase)ReturnButton).set_UseVisualStyleBackColor(true);
		SALESPERSONRATINGSBindingSource.set_DataMember("SALESPERSON_RATINGS");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)ReturnButton);
		((Control)this).get_Controls().Add((Control)(object)Newest_ReviewsToolStrip);
		((Control)this).get_Controls().Add((Control)(object)DataGridView1);
		((Control)this).set_Name("Newest_Salesperson_Rating");
		((Form)this).set_Text("Newest Reviews");
		((ISupportInitialize)DataGridView1).EndInit();
		((ISupportInitialize)SALESPERSONRATINGSBindingSource1).EndInit();
		((Control)Newest_ReviewsToolStrip).ResumeLayout(false);
		((Control)Newest_ReviewsToolStrip).PerformLayout();
		((ISupportInitialize)SALESPERSONRATINGSBindingSource).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Newest_Salesperson_Rating_Load(object sender, EventArgs e)
	{
	}

	private void Newest_ReviewsToolStripButton_Click(object sender, EventArgs e)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		try
		{
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Control)MyProject.Forms.Salesperson_Ratings).Show();
	}
}
