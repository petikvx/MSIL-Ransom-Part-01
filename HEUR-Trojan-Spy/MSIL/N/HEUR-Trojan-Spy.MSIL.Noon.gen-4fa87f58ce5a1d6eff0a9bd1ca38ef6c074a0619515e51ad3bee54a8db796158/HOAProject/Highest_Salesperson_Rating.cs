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
public class Highest_Salesperson_Rating : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("SALESPERSONRATINGSBindingSource")]
	internal virtual BindingSource SALESPERSONRATINGSBindingSource
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

	[field: AccessedThroughProperty("RATINGDATEDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn RATINGDATEDataGridViewTextBoxColumn
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

	[field: AccessedThroughProperty("RATINGVALUEDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn RATINGVALUEDataGridViewTextBoxColumn
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

	[field: AccessedThroughProperty("SALESPERSONIDDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn SALESPERSONIDDataGridViewTextBoxColumn
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

	[field: AccessedThroughProperty("Highest_ReviewsToolStrip")]
	internal virtual ToolStrip Highest_ReviewsToolStrip
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripButton Highest_ReviewsToolStripButton
	{
		[CompilerGenerated]
		get
		{
			return _Highest_ReviewsToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Highest_ReviewsToolStripButton_Click;
			ToolStripButton highest_ReviewsToolStripButton = _Highest_ReviewsToolStripButton;
			if (highest_ReviewsToolStripButton != null)
			{
				((ToolStripItem)highest_ReviewsToolStripButton).remove_Click(eventHandler);
			}
			_Highest_ReviewsToolStripButton = value;
			highest_ReviewsToolStripButton = _Highest_ReviewsToolStripButton;
			if (highest_ReviewsToolStripButton != null)
			{
				((ToolStripItem)highest_ReviewsToolStripButton).add_Click(eventHandler);
			}
		}
	}

	public Highest_Salesperson_Rating()
	{
		((Form)this).add_Load((EventHandler)Highest_Salesperson_Rating_Load);
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		components = new Container();
		SALESPERSONRATINGSBindingSource = new BindingSource(components);
		SALESPERSONRATINGSBindingSource1 = new BindingSource(components);
		RATINGDATEDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		RATINGCOMMENTSDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		RATINGVALUEDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		CUSTOMERIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		SALESPERSONIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		DataGridView1 = new DataGridView();
		ReturnButton = new Button();
		Highest_ReviewsToolStrip = new ToolStrip();
		Highest_ReviewsToolStripButton = new ToolStripButton();
		((ISupportInitialize)SALESPERSONRATINGSBindingSource).BeginInit();
		((ISupportInitialize)SALESPERSONRATINGSBindingSource1).BeginInit();
		((ISupportInitialize)DataGridView1).BeginInit();
		((Control)Highest_ReviewsToolStrip).SuspendLayout();
		((Control)this).SuspendLayout();
		SALESPERSONRATINGSBindingSource.set_DataMember("SALESPERSON_RATINGS");
		SALESPERSONRATINGSBindingSource1.set_DataMember("SALESPERSON_RATINGS");
		((DataGridViewColumn)RATINGDATEDataGridViewTextBoxColumn).set_DataPropertyName("RATING_DATE");
		((DataGridViewColumn)RATINGDATEDataGridViewTextBoxColumn).set_HeaderText("RATING_DATE");
		((DataGridViewColumn)RATINGDATEDataGridViewTextBoxColumn).set_Name("RATINGDATEDataGridViewTextBoxColumn");
		((DataGridViewColumn)RATINGDATEDataGridViewTextBoxColumn).set_Width(108);
		((DataGridViewColumn)RATINGCOMMENTSDataGridViewTextBoxColumn).set_DataPropertyName("RATING_COMMENTS");
		((DataGridViewColumn)RATINGCOMMENTSDataGridViewTextBoxColumn).set_HeaderText("RATING_COMMENTS");
		((DataGridViewColumn)RATINGCOMMENTSDataGridViewTextBoxColumn).set_Name("RATINGCOMMENTSDataGridViewTextBoxColumn");
		((DataGridViewColumn)RATINGCOMMENTSDataGridViewTextBoxColumn).set_Width(141);
		((DataGridViewColumn)RATINGVALUEDataGridViewTextBoxColumn).set_DataPropertyName("RATING_VALUE");
		((DataGridViewColumn)RATINGVALUEDataGridViewTextBoxColumn).set_HeaderText("RATING_VALUE");
		((DataGridViewColumn)RATINGVALUEDataGridViewTextBoxColumn).set_Name("RATINGVALUEDataGridViewTextBoxColumn");
		((DataGridViewColumn)RATINGVALUEDataGridViewTextBoxColumn).set_Width(114);
		((DataGridViewColumn)CUSTOMERIDDataGridViewTextBoxColumn).set_DataPropertyName("CUSTOMER_ID");
		((DataGridViewColumn)CUSTOMERIDDataGridViewTextBoxColumn).set_HeaderText("CUSTOMER_ID");
		((DataGridViewColumn)CUSTOMERIDDataGridViewTextBoxColumn).set_Name("CUSTOMERIDDataGridViewTextBoxColumn");
		((DataGridViewColumn)CUSTOMERIDDataGridViewTextBoxColumn).set_Width(110);
		((DataGridViewColumn)SALESPERSONIDDataGridViewTextBoxColumn).set_DataPropertyName("SALESPERSON_ID");
		((DataGridViewColumn)SALESPERSONIDDataGridViewTextBoxColumn).set_HeaderText("SALESPERSON_ID");
		((DataGridViewColumn)SALESPERSONIDDataGridViewTextBoxColumn).set_Name("SALESPERSONIDDataGridViewTextBoxColumn");
		((DataGridViewColumn)SALESPERSONIDDataGridViewTextBoxColumn).set_Width(128);
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
		((Control)DataGridView1).set_Location(new Point(87, 131));
		((Control)DataGridView1).set_Name("DataGridView1");
		DataGridView1.set_RowHeadersVisible(false);
		((Control)DataGridView1).set_Size(new Size(606, 148));
		((Control)DataGridView1).set_TabIndex(0);
		((Control)ReturnButton).set_Location(new Point(337, 365));
		((Control)ReturnButton).set_Name("ReturnButton");
		((Control)ReturnButton).set_Size(new Size(114, 46));
		((Control)ReturnButton).set_TabIndex(2);
		((ButtonBase)ReturnButton).set_Text("Return to All Reviews");
		((ButtonBase)ReturnButton).set_UseVisualStyleBackColor(true);
		Highest_ReviewsToolStrip.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)Highest_ReviewsToolStripButton });
		((Control)Highest_ReviewsToolStrip).set_Location(new Point(0, 0));
		((Control)Highest_ReviewsToolStrip).set_Name("Highest_ReviewsToolStrip");
		((Control)Highest_ReviewsToolStrip).set_Size(new Size(111, 25));
		((Control)Highest_ReviewsToolStrip).set_TabIndex(3);
		((Control)Highest_ReviewsToolStrip).set_Text("Highest_ReviewsToolStrip");
		((ToolStripItem)Highest_ReviewsToolStripButton).set_DisplayStyle((ToolStripItemDisplayStyle)1);
		((ToolStripItem)Highest_ReviewsToolStripButton).set_Name("Highest_ReviewsToolStripButton");
		((ToolStripItem)Highest_ReviewsToolStripButton).set_Size(new Size(99, 22));
		((ToolStripItem)Highest_ReviewsToolStripButton).set_Text("Highest_Reviews");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)Highest_ReviewsToolStrip);
		((Control)this).get_Controls().Add((Control)(object)ReturnButton);
		((Control)this).get_Controls().Add((Control)(object)DataGridView1);
		((Control)this).set_Name("Highest_Salesperson_Rating");
		((Form)this).set_Text("Best Reviews");
		((ISupportInitialize)SALESPERSONRATINGSBindingSource).EndInit();
		((ISupportInitialize)SALESPERSONRATINGSBindingSource1).EndInit();
		((ISupportInitialize)DataGridView1).EndInit();
		((Control)Highest_ReviewsToolStrip).ResumeLayout(false);
		((Control)Highest_ReviewsToolStrip).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Highest_Salesperson_Rating_Load(object sender, EventArgs e)
	{
	}

	private void HIGHEST_RATINGToolStripButton_Click(object sender, EventArgs e)
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

	private void HIGHEST_RATINGToolStripButton_Click_1(object sender, EventArgs e)
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

	private void Highest_ReviewsToolStripButton_Click(object sender, EventArgs e)
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
}
