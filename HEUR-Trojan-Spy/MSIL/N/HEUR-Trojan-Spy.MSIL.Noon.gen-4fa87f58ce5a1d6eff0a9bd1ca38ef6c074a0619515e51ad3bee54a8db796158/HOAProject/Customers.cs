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
public class Customers : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("DataGridView1")]
	internal virtual DataGridView DataGridView1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CUSTOMERBindingSource")]
	internal virtual BindingSource CUSTOMERBindingSource
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

	[field: AccessedThroughProperty("CUSFIRSTNAMEDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn CUSFIRSTNAMEDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CUSLASTNAMEDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn CUSLASTNAMEDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CUSINITIALDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn CUSINITIALDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CUSADDRESSDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn CUSADDRESSDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CUSCONTACTDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn CUSCONTACTDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CUSEMAILDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn CUSEMAILDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CUSCOMMENTSDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn CUSCOMMENTSDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button BackButton
	{
		[CompilerGenerated]
		get
		{
			return _BackButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = BackButton_Click;
			Button backButton = _BackButton;
			if (backButton != null)
			{
				((Control)backButton).remove_Click(eventHandler);
			}
			_BackButton = value;
			backButton = _BackButton;
			if (backButton != null)
			{
				((Control)backButton).add_Click(eventHandler);
			}
		}
	}

	public Customers()
	{
		((Form)this).add_Load((EventHandler)Customers_Load);
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
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		components = new Container();
		DataGridView1 = new DataGridView();
		CUSTOMERBindingSource = new BindingSource(components);
		CUSTOMERIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		CUSFIRSTNAMEDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		CUSLASTNAMEDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		CUSINITIALDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		CUSADDRESSDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		CUSCONTACTDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		CUSEMAILDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		CUSCOMMENTSDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		BackButton = new Button();
		((ISupportInitialize)DataGridView1).BeginInit();
		((ISupportInitialize)CUSTOMERBindingSource).BeginInit();
		((Control)this).SuspendLayout();
		DataGridView1.set_AllowUserToAddRows(false);
		DataGridView1.set_AutoGenerateColumns(false);
		DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		DataGridView1.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[8]
		{
			(DataGridViewColumn)CUSTOMERIDDataGridViewTextBoxColumn,
			(DataGridViewColumn)CUSFIRSTNAMEDataGridViewTextBoxColumn,
			(DataGridViewColumn)CUSLASTNAMEDataGridViewTextBoxColumn,
			(DataGridViewColumn)CUSINITIALDataGridViewTextBoxColumn,
			(DataGridViewColumn)CUSADDRESSDataGridViewTextBoxColumn,
			(DataGridViewColumn)CUSCONTACTDataGridViewTextBoxColumn,
			(DataGridViewColumn)CUSEMAILDataGridViewTextBoxColumn,
			(DataGridViewColumn)CUSCOMMENTSDataGridViewTextBoxColumn
		});
		DataGridView1.set_DataSource((object)CUSTOMERBindingSource);
		((Control)DataGridView1).set_Location(new Point(12, 3));
		((Control)DataGridView1).set_Name("DataGridView1");
		DataGridView1.set_RowHeadersVisible(false);
		((Control)DataGridView1).set_Size(new Size(802, 358));
		((Control)DataGridView1).set_TabIndex(0);
		((DataGridViewColumn)CUSTOMERIDDataGridViewTextBoxColumn).set_DataPropertyName("CUSTOMER_ID");
		((DataGridViewColumn)CUSTOMERIDDataGridViewTextBoxColumn).set_HeaderText("CUSTOMER_ID");
		((DataGridViewColumn)CUSTOMERIDDataGridViewTextBoxColumn).set_Name("CUSTOMERIDDataGridViewTextBoxColumn");
		((DataGridViewColumn)CUSFIRSTNAMEDataGridViewTextBoxColumn).set_DataPropertyName("CUS_FIRST_NAME");
		((DataGridViewColumn)CUSFIRSTNAMEDataGridViewTextBoxColumn).set_HeaderText("CUS_FIRST_NAME");
		((DataGridViewColumn)CUSFIRSTNAMEDataGridViewTextBoxColumn).set_Name("CUSFIRSTNAMEDataGridViewTextBoxColumn");
		((DataGridViewColumn)CUSLASTNAMEDataGridViewTextBoxColumn).set_DataPropertyName("CUS_LAST_NAME");
		((DataGridViewColumn)CUSLASTNAMEDataGridViewTextBoxColumn).set_HeaderText("CUS_LAST_NAME");
		((DataGridViewColumn)CUSLASTNAMEDataGridViewTextBoxColumn).set_Name("CUSLASTNAMEDataGridViewTextBoxColumn");
		((DataGridViewColumn)CUSINITIALDataGridViewTextBoxColumn).set_DataPropertyName("CUS_INITIAL");
		((DataGridViewColumn)CUSINITIALDataGridViewTextBoxColumn).set_HeaderText("CUS_INITIAL");
		((DataGridViewColumn)CUSINITIALDataGridViewTextBoxColumn).set_Name("CUSINITIALDataGridViewTextBoxColumn");
		((DataGridViewColumn)CUSADDRESSDataGridViewTextBoxColumn).set_DataPropertyName("CUS_ADDRESS");
		((DataGridViewColumn)CUSADDRESSDataGridViewTextBoxColumn).set_HeaderText("CUS_ADDRESS");
		((DataGridViewColumn)CUSADDRESSDataGridViewTextBoxColumn).set_Name("CUSADDRESSDataGridViewTextBoxColumn");
		((DataGridViewColumn)CUSCONTACTDataGridViewTextBoxColumn).set_DataPropertyName("CUS_CONTACT");
		((DataGridViewColumn)CUSCONTACTDataGridViewTextBoxColumn).set_HeaderText("CUS_CONTACT");
		((DataGridViewColumn)CUSCONTACTDataGridViewTextBoxColumn).set_Name("CUSCONTACTDataGridViewTextBoxColumn");
		((DataGridViewColumn)CUSEMAILDataGridViewTextBoxColumn).set_DataPropertyName("CUS_EMAIL");
		((DataGridViewColumn)CUSEMAILDataGridViewTextBoxColumn).set_HeaderText("CUS_EMAIL");
		((DataGridViewColumn)CUSEMAILDataGridViewTextBoxColumn).set_Name("CUSEMAILDataGridViewTextBoxColumn");
		((DataGridViewColumn)CUSCOMMENTSDataGridViewTextBoxColumn).set_DataPropertyName("CUS_COMMENTS");
		((DataGridViewColumn)CUSCOMMENTSDataGridViewTextBoxColumn).set_HeaderText("CUS_COMMENTS");
		((DataGridViewColumn)CUSCOMMENTSDataGridViewTextBoxColumn).set_Name("CUSCOMMENTSDataGridViewTextBoxColumn");
		((Control)BackButton).set_Location(new Point(391, 420));
		((Control)BackButton).set_Margin(new Padding(2));
		((Control)BackButton).set_Name("BackButton");
		((Control)BackButton).set_Size(new Size(68, 19));
		((Control)BackButton).set_TabIndex(6);
		((ButtonBase)BackButton).set_Text("Back");
		((ButtonBase)BackButton).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(836, 473));
		((Control)this).get_Controls().Add((Control)(object)BackButton);
		((Control)this).get_Controls().Add((Control)(object)DataGridView1);
		((Control)this).set_Name("Customers");
		((Form)this).set_Text("Customers");
		((ISupportInitialize)DataGridView1).EndInit();
		((ISupportInitialize)CUSTOMERBindingSource).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void Customers_Load(object sender, EventArgs e)
	{
	}

	private void BackButton_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Control)MyProject.Forms.WelcomePage).Show();
	}
}
