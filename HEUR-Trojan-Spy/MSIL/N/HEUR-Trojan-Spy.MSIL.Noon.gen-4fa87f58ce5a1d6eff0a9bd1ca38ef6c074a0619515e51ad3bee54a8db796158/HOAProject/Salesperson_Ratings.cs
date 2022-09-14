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
public class Salesperson_Ratings : Form
{
	private IContainer components;

	internal virtual DataGridView DataGridView1
	{
		[CompilerGenerated]
		get
		{
			return _DataGridView1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			DataGridViewCellEventHandler val = new DataGridViewCellEventHandler(DataGridView1_CellContentClick);
			DataGridView dataGridView = _DataGridView1;
			if (dataGridView != null)
			{
				dataGridView.remove_CellContentClick(val);
			}
			_DataGridView1 = value;
			dataGridView = _DataGridView1;
			if (dataGridView != null)
			{
				dataGridView.add_CellContentClick(val);
			}
		}
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

	internal virtual Button Exit_Salesperson_Ratings
	{
		[CompilerGenerated]
		get
		{
			return _Exit_Salesperson_Ratings;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Exit_Salesperson_Ratings_Click;
			Button exit_Salesperson_Ratings = _Exit_Salesperson_Ratings;
			if (exit_Salesperson_Ratings != null)
			{
				((Control)exit_Salesperson_Ratings).remove_Click(eventHandler);
			}
			_Exit_Salesperson_Ratings = value;
			exit_Salesperson_Ratings = _Exit_Salesperson_Ratings;
			if (exit_Salesperson_Ratings != null)
			{
				((Control)exit_Salesperson_Ratings).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("TextAverage")]
	internal virtual Label TextAverage
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("OutputAverage")]
	internal virtual Label OutputAverage
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Salesperson_Ratings()
	{
		((Form)this).add_Load((EventHandler)Salesperson_Ratings_Load);
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
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0520: Unknown result type (might be due to invalid IL or missing references)
		components = new Container();
		DataGridView1 = new DataGridView();
		SALESPERSONIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		CUSTOMERIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		RATINGVALUEDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		RATINGCOMMENTSDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		RATINGDATEDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		SALESPERSONRATINGSBindingSource = new BindingSource(components);
		Exit_Salesperson_Ratings = new Button();
		TextAverage = new Label();
		OutputAverage = new Label();
		((ISupportInitialize)DataGridView1).BeginInit();
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
		DataGridView1.set_DataSource((object)SALESPERSONRATINGSBindingSource);
		((Control)DataGridView1).set_Location(new Point(81, 42));
		((Control)DataGridView1).set_Margin(new Padding(4, 4, 4, 4));
		((Control)DataGridView1).set_Name("DataGridView1");
		DataGridView1.set_RowHeadersVisible(false);
		DataGridView1.set_RowHeadersWidth(51);
		((Control)DataGridView1).set_Size(new Size(751, 337));
		((Control)DataGridView1).set_TabIndex(0);
		((DataGridViewColumn)SALESPERSONIDDataGridViewTextBoxColumn).set_DataPropertyName("SALESPERSON_ID");
		((DataGridViewColumn)SALESPERSONIDDataGridViewTextBoxColumn).set_HeaderText("SALESPERSON_ID");
		((DataGridViewColumn)SALESPERSONIDDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)SALESPERSONIDDataGridViewTextBoxColumn).set_Name("SALESPERSONIDDataGridViewTextBoxColumn");
		((DataGridViewColumn)SALESPERSONIDDataGridViewTextBoxColumn).set_Width(160);
		((DataGridViewColumn)CUSTOMERIDDataGridViewTextBoxColumn).set_DataPropertyName("CUSTOMER_ID");
		((DataGridViewColumn)CUSTOMERIDDataGridViewTextBoxColumn).set_HeaderText("CUSTOMER_ID");
		((DataGridViewColumn)CUSTOMERIDDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)CUSTOMERIDDataGridViewTextBoxColumn).set_Name("CUSTOMERIDDataGridViewTextBoxColumn");
		((DataGridViewColumn)CUSTOMERIDDataGridViewTextBoxColumn).set_Width(136);
		((DataGridViewColumn)RATINGVALUEDataGridViewTextBoxColumn).set_DataPropertyName("RATING_VALUE");
		((DataGridViewColumn)RATINGVALUEDataGridViewTextBoxColumn).set_HeaderText("RATING_VALUE");
		((DataGridViewColumn)RATINGVALUEDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)RATINGVALUEDataGridViewTextBoxColumn).set_Name("RATINGVALUEDataGridViewTextBoxColumn");
		((DataGridViewColumn)RATINGVALUEDataGridViewTextBoxColumn).set_Width(142);
		((DataGridViewColumn)RATINGCOMMENTSDataGridViewTextBoxColumn).set_DataPropertyName("RATING_COMMENTS");
		((DataGridViewColumn)RATINGCOMMENTSDataGridViewTextBoxColumn).set_HeaderText("RATING_COMMENTS");
		((DataGridViewColumn)RATINGCOMMENTSDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)RATINGCOMMENTSDataGridViewTextBoxColumn).set_Name("RATINGCOMMENTSDataGridViewTextBoxColumn");
		((DataGridViewColumn)RATINGCOMMENTSDataGridViewTextBoxColumn).set_Width(176);
		((DataGridViewColumn)RATINGDATEDataGridViewTextBoxColumn).set_DataPropertyName("RATING_DATE");
		((DataGridViewColumn)RATINGDATEDataGridViewTextBoxColumn).set_HeaderText("RATING_DATE");
		((DataGridViewColumn)RATINGDATEDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)RATINGDATEDataGridViewTextBoxColumn).set_Name("RATINGDATEDataGridViewTextBoxColumn");
		((DataGridViewColumn)RATINGDATEDataGridViewTextBoxColumn).set_Width(134);
		SALESPERSONRATINGSBindingSource.set_DataMember("SALESPERSON_RATINGS");
		((Control)Exit_Salesperson_Ratings).set_Location(new Point(369, 460));
		((Control)Exit_Salesperson_Ratings).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Exit_Salesperson_Ratings).set_Name("Exit_Salesperson_Ratings");
		((Control)Exit_Salesperson_Ratings).set_Size(new Size(183, 28));
		((Control)Exit_Salesperson_Ratings).set_TabIndex(1);
		((ButtonBase)Exit_Salesperson_Ratings).set_Text("Return to Welcome Page");
		((ButtonBase)Exit_Salesperson_Ratings).set_UseVisualStyleBackColor(true);
		TextAverage.set_AutoSize(true);
		((Control)TextAverage).set_Location(new Point(611, 388));
		((Control)TextAverage).set_Margin(new Padding(4, 0, 4, 0));
		((Control)TextAverage).set_Name("TextAverage");
		((Control)TextAverage).set_Size(new Size(197, 17));
		((Control)TextAverage).set_TabIndex(2);
		TextAverage.set_Text("Average Salesperson Rating: ");
		OutputAverage.set_AutoSize(true);
		((Control)OutputAverage).set_BackColor(Color.Yellow);
		((Control)OutputAverage).set_Location(new Point(816, 388));
		((Control)OutputAverage).set_Margin(new Padding(4, 0, 4, 0));
		((Control)OutputAverage).set_Name("OutputAverage");
		((Control)OutputAverage).set_Size(new Size(16, 17));
		((Control)OutputAverage).set_TabIndex(3);
		OutputAverage.set_Text("0");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1067, 554));
		((Control)this).get_Controls().Add((Control)(object)OutputAverage);
		((Control)this).get_Controls().Add((Control)(object)TextAverage);
		((Control)this).get_Controls().Add((Control)(object)Exit_Salesperson_Ratings);
		((Control)this).get_Controls().Add((Control)(object)DataGridView1);
		((Form)this).set_Margin(new Padding(4, 4, 4, 4));
		((Control)this).set_Name("Salesperson_Ratings");
		((Form)this).set_Text("Salesperson_Ratings");
		((ISupportInitialize)DataGridView1).EndInit();
		((ISupportInitialize)SALESPERSONRATINGSBindingSource).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Salesperson_Ratings_Load(object sender, EventArgs e)
	{
	}

	private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void Exit_Salesperson_Ratings_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
		((Control)MyProject.Forms.WelcomePage).Show();
	}
}
