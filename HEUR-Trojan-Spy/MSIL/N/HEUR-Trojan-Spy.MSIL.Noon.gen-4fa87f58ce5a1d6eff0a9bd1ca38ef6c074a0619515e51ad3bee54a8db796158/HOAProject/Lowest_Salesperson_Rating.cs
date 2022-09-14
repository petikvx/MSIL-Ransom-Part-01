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
public class Lowest_Salesperson_Rating : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("DataGridView1")]
	internal virtual DataGridView DataGridView1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SALESPERSONRATINGSBindingSource")]
	internal virtual BindingSource SALESPERSONRATINGSBindingSource
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

	[field: AccessedThroughProperty("Worst_ReviewsToolStrip")]
	internal virtual ToolStrip Worst_ReviewsToolStrip
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripButton Worst_ReviewsToolStripButton
	{
		[CompilerGenerated]
		get
		{
			return _Worst_ReviewsToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Worst_ReviewsToolStripButton_Click;
			ToolStripButton worst_ReviewsToolStripButton = _Worst_ReviewsToolStripButton;
			if (worst_ReviewsToolStripButton != null)
			{
				((ToolStripItem)worst_ReviewsToolStripButton).remove_Click(eventHandler);
			}
			_Worst_ReviewsToolStripButton = value;
			worst_ReviewsToolStripButton = _Worst_ReviewsToolStripButton;
			if (worst_ReviewsToolStripButton != null)
			{
				((ToolStripItem)worst_ReviewsToolStripButton).add_Click(eventHandler);
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

	public Lowest_Salesperson_Rating()
	{
		((Form)this).add_Load((EventHandler)Lowest_Salesperson_Rating_Load);
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
		components = new Container();
		DataGridView1 = new DataGridView();
		SALESPERSONIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		CUSTOMERIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		RATINGVALUEDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		RATINGCOMMENTSDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		RATINGDATEDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		SALESPERSONRATINGSBindingSource = new BindingSource(components);
		Worst_ReviewsToolStrip = new ToolStrip();
		Worst_ReviewsToolStripButton = new ToolStripButton();
		ReturnButton = new Button();
		((ISupportInitialize)DataGridView1).BeginInit();
		((ISupportInitialize)SALESPERSONRATINGSBindingSource).BeginInit();
		((Control)Worst_ReviewsToolStrip).SuspendLayout();
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
		DataGridView1.set_DataSource((object)SALESPERSONRATINGSBindingSource);
		((Control)DataGridView1).set_Location(new Point(89, 129));
		((Control)DataGridView1).set_Name("DataGridView1");
		DataGridView1.set_RowHeadersVisible(false);
		DataGridView1.set_RowHeadersWidth(51);
		((Control)DataGridView1).set_Size(new Size(565, 172));
		((Control)DataGridView1).set_TabIndex(0);
		((DataGridViewColumn)SALESPERSONIDDataGridViewTextBoxColumn).set_DataPropertyName("SALESPERSON_ID");
		((DataGridViewColumn)SALESPERSONIDDataGridViewTextBoxColumn).set_HeaderText("SALESPERSON_ID");
		((DataGridViewColumn)SALESPERSONIDDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)SALESPERSONIDDataGridViewTextBoxColumn).set_Name("SALESPERSONIDDataGridViewTextBoxColumn");
		((DataGridViewColumn)SALESPERSONIDDataGridViewTextBoxColumn).set_Width(128);
		((DataGridViewColumn)CUSTOMERIDDataGridViewTextBoxColumn).set_DataPropertyName("CUSTOMER_ID");
		((DataGridViewColumn)CUSTOMERIDDataGridViewTextBoxColumn).set_HeaderText("CUSTOMER_ID");
		((DataGridViewColumn)CUSTOMERIDDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)CUSTOMERIDDataGridViewTextBoxColumn).set_Name("CUSTOMERIDDataGridViewTextBoxColumn");
		((DataGridViewColumn)CUSTOMERIDDataGridViewTextBoxColumn).set_Width(110);
		((DataGridViewColumn)RATINGVALUEDataGridViewTextBoxColumn).set_DataPropertyName("RATING_VALUE");
		((DataGridViewColumn)RATINGVALUEDataGridViewTextBoxColumn).set_HeaderText("RATING_VALUE");
		((DataGridViewColumn)RATINGVALUEDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)RATINGVALUEDataGridViewTextBoxColumn).set_Name("RATINGVALUEDataGridViewTextBoxColumn");
		((DataGridViewColumn)RATINGVALUEDataGridViewTextBoxColumn).set_Width(114);
		((DataGridViewColumn)RATINGCOMMENTSDataGridViewTextBoxColumn).set_DataPropertyName("RATING_COMMENTS");
		((DataGridViewColumn)RATINGCOMMENTSDataGridViewTextBoxColumn).set_HeaderText("RATING_COMMENTS");
		((DataGridViewColumn)RATINGCOMMENTSDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)RATINGCOMMENTSDataGridViewTextBoxColumn).set_Name("RATINGCOMMENTSDataGridViewTextBoxColumn");
		((DataGridViewColumn)RATINGCOMMENTSDataGridViewTextBoxColumn).set_Width(141);
		((DataGridViewColumn)RATINGDATEDataGridViewTextBoxColumn).set_DataPropertyName("RATING_DATE");
		((DataGridViewColumn)RATINGDATEDataGridViewTextBoxColumn).set_HeaderText("RATING_DATE");
		((DataGridViewColumn)RATINGDATEDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)RATINGDATEDataGridViewTextBoxColumn).set_Name("RATINGDATEDataGridViewTextBoxColumn");
		((DataGridViewColumn)RATINGDATEDataGridViewTextBoxColumn).set_Width(108);
		SALESPERSONRATINGSBindingSource.set_DataMember("SALESPERSON_RATINGS");
		Worst_ReviewsToolStrip.set_ImageScalingSize(new Size(20, 20));
		Worst_ReviewsToolStrip.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)Worst_ReviewsToolStripButton });
		((Control)Worst_ReviewsToolStrip).set_Location(new Point(0, 0));
		((Control)Worst_ReviewsToolStrip).set_Name("Worst_ReviewsToolStrip");
		((Control)Worst_ReviewsToolStrip).set_Size(new Size(800, 25));
		((Control)Worst_ReviewsToolStrip).set_TabIndex(1);
		((Control)Worst_ReviewsToolStrip).set_Text("Worst_ReviewsToolStrip");
		((ToolStripItem)Worst_ReviewsToolStripButton).set_DisplayStyle((ToolStripItemDisplayStyle)1);
		((ToolStripItem)Worst_ReviewsToolStripButton).set_Name("Worst_ReviewsToolStripButton");
		((ToolStripItem)Worst_ReviewsToolStripButton).set_Size(new Size(104, 22));
		((ToolStripItem)Worst_ReviewsToolStripButton).set_Text("LOWEST REVIEWS");
		((Control)ReturnButton).set_Location(new Point(346, 365));
		((Control)ReturnButton).set_Name("ReturnButton");
		((Control)ReturnButton).set_Size(new Size(114, 46));
		((Control)ReturnButton).set_TabIndex(3);
		((ButtonBase)ReturnButton).set_Text("Return to All Reviews");
		((ButtonBase)ReturnButton).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)ReturnButton);
		((Control)this).get_Controls().Add((Control)(object)Worst_ReviewsToolStrip);
		((Control)this).get_Controls().Add((Control)(object)DataGridView1);
		((Control)this).set_Name("Lowest_Salesperson_Rating");
		((Form)this).set_Text("z");
		((ISupportInitialize)DataGridView1).EndInit();
		((ISupportInitialize)SALESPERSONRATINGSBindingSource).EndInit();
		((Control)Worst_ReviewsToolStrip).ResumeLayout(false);
		((Control)Worst_ReviewsToolStrip).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Lowest_Salesperson_Rating_Load(object sender, EventArgs e)
	{
	}

	private void Worst_ReviewsToolStripButton_Click(object sender, EventArgs e)
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
