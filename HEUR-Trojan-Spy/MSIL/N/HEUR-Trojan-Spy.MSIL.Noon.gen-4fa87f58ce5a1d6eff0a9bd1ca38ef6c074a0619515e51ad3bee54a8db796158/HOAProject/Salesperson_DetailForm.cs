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
public class Salesperson_DetailForm : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("GetMgrnameBindingSource")]
	internal virtual BindingSource GetMgrnameBindingSource
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProjectDataSetBindingSource")]
	internal virtual BindingSource ProjectDataSetBindingSource
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("EmployeeManagerBindingSource")]
	internal virtual BindingSource EmployeeManagerBindingSource
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DataGridView SalespersonManagerGrid
	{
		[CompilerGenerated]
		get
		{
			return _SalespersonManagerGrid;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			DataGridViewCellEventHandler val = new DataGridViewCellEventHandler(SalespersonManagerGrid_CellContentClick);
			DataGridView salespersonManagerGrid = _SalespersonManagerGrid;
			if (salespersonManagerGrid != null)
			{
				salespersonManagerGrid.remove_CellContentClick(val);
			}
			_SalespersonManagerGrid = value;
			salespersonManagerGrid = _SalespersonManagerGrid;
			if (salespersonManagerGrid != null)
			{
				salespersonManagerGrid.add_CellContentClick(val);
			}
		}
	}

	[field: AccessedThroughProperty("SALESPERSONIDDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn SALESPERSONIDDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SPFIRSTNAMEDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn SPFIRSTNAMEDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SPLASTNAMEDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn SPLASTNAMEDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SPCONTACTDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn SPCONTACTDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SPEMAILDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn SPEMAILDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ManagerNameDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn ManagerNameDataGridViewTextBoxColumn
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

	[field: AccessedThroughProperty("ComboBox1")]
	internal virtual ComboBox ComboBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("EmployeeLabel")]
	internal virtual Label EmployeeLabel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FillToolStrip1")]
	internal virtual ToolStrip FillToolStrip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button EmployeeName_Button
	{
		[CompilerGenerated]
		get
		{
			return _EmployeeName_Button;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = EmployeeName_Button_Click;
			Button employeeName_Button = _EmployeeName_Button;
			if (employeeName_Button != null)
			{
				((Control)employeeName_Button).remove_Click(eventHandler);
			}
			_EmployeeName_Button = value;
			employeeName_Button = _EmployeeName_Button;
			if (employeeName_Button != null)
			{
				((Control)employeeName_Button).add_Click(eventHandler);
			}
		}
	}

	internal virtual TextBox TextBox1
	{
		[CompilerGenerated]
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = TextBox1_TextChanged;
			TextBox textBox = _TextBox1;
			if (textBox != null)
			{
				((Control)textBox).remove_TextChanged(eventHandler);
			}
			_TextBox1 = value;
			textBox = _TextBox1;
			if (textBox != null)
			{
				((Control)textBox).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual ComboBox ComboBox2
	{
		[CompilerGenerated]
		get
		{
			return _ComboBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = ComboBox2_SelectedIndexChanged;
			ComboBox comboBox = _ComboBox2;
			if (comboBox != null)
			{
				comboBox.remove_SelectedIndexChanged(eventHandler);
			}
			_ComboBox2 = value;
			comboBox = _ComboBox2;
			if (comboBox != null)
			{
				comboBox.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual Label Label1
	{
		[CompilerGenerated]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Label1_Click;
			Label label = _Label1;
			if (label != null)
			{
				((Control)label).remove_Click(eventHandler);
			}
			_Label1 = value;
			label = _Label1;
			if (label != null)
			{
				((Control)label).add_Click(eventHandler);
			}
		}
	}

	public Salesperson_DetailForm()
	{
		((Form)this).add_Load((EventHandler)Salesperson_DetailForm_Load);
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
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		components = new Container();
		GetMgrnameBindingSource = new BindingSource(components);
		EmployeeManagerBindingSource = new BindingSource(components);
		SalespersonManagerGrid = new DataGridView();
		SALESPERSONIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		SPFIRSTNAMEDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		SPLASTNAMEDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		SPCONTACTDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		SPEMAILDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		ManagerNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		BackButton = new Button();
		ComboBox1 = new ComboBox();
		EmployeeLabel = new Label();
		FillToolStrip1 = new ToolStrip();
		EmployeeName_Button = new Button();
		TextBox1 = new TextBox();
		ComboBox2 = new ComboBox();
		Label1 = new Label();
		((ISupportInitialize)ProjectDataSetBindingSource).BeginInit();
		((ISupportInitialize)GetMgrnameBindingSource).BeginInit();
		((ISupportInitialize)EmployeeManagerBindingSource).BeginInit();
		((ISupportInitialize)SalespersonManagerGrid).BeginInit();
		((Control)this).SuspendLayout();
		GetMgrnameBindingSource.set_DataMember("get_Mgrname");
		EmployeeManagerBindingSource.set_DataMember("EmployeeManager");
		SalespersonManagerGrid.set_AllowUserToAddRows(false);
		SalespersonManagerGrid.set_AutoGenerateColumns(false);
		SalespersonManagerGrid.set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)6);
		SalespersonManagerGrid.set_AutoSizeRowsMode((DataGridViewAutoSizeRowsMode)7);
		SalespersonManagerGrid.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		SalespersonManagerGrid.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[6]
		{
			(DataGridViewColumn)SALESPERSONIDDataGridViewTextBoxColumn,
			(DataGridViewColumn)SPFIRSTNAMEDataGridViewTextBoxColumn,
			(DataGridViewColumn)SPLASTNAMEDataGridViewTextBoxColumn,
			(DataGridViewColumn)SPCONTACTDataGridViewTextBoxColumn,
			(DataGridViewColumn)SPEMAILDataGridViewTextBoxColumn,
			(DataGridViewColumn)ManagerNameDataGridViewTextBoxColumn
		});
		SalespersonManagerGrid.set_DataSource((object)EmployeeManagerBindingSource);
		((Control)SalespersonManagerGrid).set_Location(new Point(185, 87));
		((Control)SalespersonManagerGrid).set_Name("SalespersonManagerGrid");
		SalespersonManagerGrid.set_RowHeadersVisible(false);
		SalespersonManagerGrid.set_RowHeadersWidth(51);
		SalespersonManagerGrid.get_RowTemplate().set_Height(24);
		((Control)SalespersonManagerGrid).set_Size(new Size(828, 330));
		((Control)SalespersonManagerGrid).set_TabIndex(0);
		((DataGridViewColumn)SALESPERSONIDDataGridViewTextBoxColumn).set_DataPropertyName("SALESPERSON_ID");
		((DataGridViewColumn)SALESPERSONIDDataGridViewTextBoxColumn).set_HeaderText("SALESPERSON_ID");
		((DataGridViewColumn)SALESPERSONIDDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)SALESPERSONIDDataGridViewTextBoxColumn).set_Name("SALESPERSONIDDataGridViewTextBoxColumn");
		((DataGridViewColumn)SALESPERSONIDDataGridViewTextBoxColumn).set_Width(160);
		((DataGridViewColumn)SPFIRSTNAMEDataGridViewTextBoxColumn).set_DataPropertyName("SP_FIRST_NAME");
		((DataGridViewColumn)SPFIRSTNAMEDataGridViewTextBoxColumn).set_HeaderText("SP_FIRST_NAME");
		((DataGridViewColumn)SPFIRSTNAMEDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)SPFIRSTNAMEDataGridViewTextBoxColumn).set_Name("SPFIRSTNAMEDataGridViewTextBoxColumn");
		((DataGridViewColumn)SPFIRSTNAMEDataGridViewTextBoxColumn).set_Width(149);
		((DataGridViewColumn)SPLASTNAMEDataGridViewTextBoxColumn).set_DataPropertyName("SP_LAST_NAME");
		((DataGridViewColumn)SPLASTNAMEDataGridViewTextBoxColumn).set_HeaderText("SP_LAST_NAME");
		((DataGridViewColumn)SPLASTNAMEDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)SPLASTNAMEDataGridViewTextBoxColumn).set_Name("SPLASTNAMEDataGridViewTextBoxColumn");
		((DataGridViewColumn)SPLASTNAMEDataGridViewTextBoxColumn).set_Width(145);
		((DataGridViewColumn)SPCONTACTDataGridViewTextBoxColumn).set_DataPropertyName("SP_CONTACT");
		((DataGridViewColumn)SPCONTACTDataGridViewTextBoxColumn).set_HeaderText("SP_CONTACT");
		((DataGridViewColumn)SPCONTACTDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)SPCONTACTDataGridViewTextBoxColumn).set_Name("SPCONTACTDataGridViewTextBoxColumn");
		((DataGridViewColumn)SPCONTACTDataGridViewTextBoxColumn).set_Width(129);
		((DataGridViewColumn)SPEMAILDataGridViewTextBoxColumn).set_DataPropertyName("SP_EMAIL");
		((DataGridViewColumn)SPEMAILDataGridViewTextBoxColumn).set_HeaderText("SP_EMAIL");
		((DataGridViewColumn)SPEMAILDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)SPEMAILDataGridViewTextBoxColumn).set_Name("SPEMAILDataGridViewTextBoxColumn");
		((DataGridViewColumn)SPEMAILDataGridViewTextBoxColumn).set_Width(103);
		((DataGridViewColumn)ManagerNameDataGridViewTextBoxColumn).set_DataPropertyName("Manager_Name");
		((DataGridViewColumn)ManagerNameDataGridViewTextBoxColumn).set_HeaderText("Manager_Name");
		((DataGridViewColumn)ManagerNameDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)ManagerNameDataGridViewTextBoxColumn).set_Name("ManagerNameDataGridViewTextBoxColumn");
		((DataGridViewColumn)ManagerNameDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)ManagerNameDataGridViewTextBoxColumn).set_Width(138);
		((Control)BackButton).set_Location(new Point(554, 634));
		((Control)BackButton).set_Margin(new Padding(3, 2, 3, 2));
		((Control)BackButton).set_Name("BackButton");
		((Control)BackButton).set_Size(new Size(91, 23));
		((Control)BackButton).set_TabIndex(3);
		((ButtonBase)BackButton).set_Text("&Back");
		((ButtonBase)BackButton).set_UseVisualStyleBackColor(true);
		ComboBox1.set_DataSource((object)GetMgrnameBindingSource);
		((ListControl)ComboBox1).set_DisplayMember("Manager_Name");
		((ListControl)ComboBox1).set_FormattingEnabled(true);
		((Control)ComboBox1).set_Location(new Point(598, 562));
		((Control)ComboBox1).set_Name("ComboBox1");
		((Control)ComboBox1).set_Size(new Size(121, 24));
		((Control)ComboBox1).set_TabIndex(5);
		((ListControl)ComboBox1).set_ValueMember("Manager_Name");
		EmployeeLabel.set_AutoSize(true);
		((Control)EmployeeLabel).set_ForeColor(Color.Lime);
		((Control)EmployeeLabel).set_Location(new Point(450, 565));
		((Control)EmployeeLabel).set_Name("EmployeeLabel");
		((Control)EmployeeLabel).set_Size(new Size(105, 17));
		((Control)EmployeeLabel).set_TabIndex(6);
		EmployeeLabel.set_Text("Manager Name");
		FillToolStrip1.set_ImageScalingSize(new Size(20, 20));
		((Control)FillToolStrip1).set_Location(new Point(0, 0));
		((Control)FillToolStrip1).set_Name("FillToolStrip1");
		((Control)FillToolStrip1).set_Size(new Size(1441, 25));
		((Control)FillToolStrip1).set_TabIndex(7);
		((Control)FillToolStrip1).set_Text("FillToolStrip1");
		((Control)EmployeeName_Button).set_Location(new Point(205, 491));
		((Control)EmployeeName_Button).set_Name("EmployeeName_Button");
		((Control)EmployeeName_Button).set_Size(new Size(167, 24));
		((Control)EmployeeName_Button).set_TabIndex(8);
		((ButtonBase)EmployeeName_Button).set_Text("Enter Employee Name:");
		((ButtonBase)EmployeeName_Button).set_UseVisualStyleBackColor(true);
		((Control)TextBox1).set_Location(new Point(409, 491));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(123, 22));
		((Control)TextBox1).set_TabIndex(9);
		ComboBox2.set_DataSource((object)EmployeeManagerBindingSource);
		((ListControl)ComboBox2).set_DisplayMember("SP_FIRST_NAME");
		((ListControl)ComboBox2).set_FormattingEnabled(true);
		((Control)ComboBox2).set_Location(new Point(892, 488));
		((Control)ComboBox2).set_Name("ComboBox2");
		((Control)ComboBox2).set_Size(new Size(121, 24));
		((Control)ComboBox2).set_TabIndex(10);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Location(new Point(567, 491));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(301, 17));
		((Control)Label1).set_TabIndex(11);
		Label1.set_Text("OR     Select Employee Name from DropDown:");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1441, 797));
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)ComboBox2);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)EmployeeName_Button);
		((Control)this).get_Controls().Add((Control)(object)FillToolStrip1);
		((Control)this).get_Controls().Add((Control)(object)EmployeeLabel);
		((Control)this).get_Controls().Add((Control)(object)ComboBox1);
		((Control)this).get_Controls().Add((Control)(object)BackButton);
		((Control)this).get_Controls().Add((Control)(object)SalespersonManagerGrid);
		((Control)this).set_Name("Salesperson_DetailForm");
		((Form)this).set_Text("Salesperson_DetailForm");
		((ISupportInitialize)ProjectDataSetBindingSource).EndInit();
		((ISupportInitialize)GetMgrnameBindingSource).EndInit();
		((ISupportInitialize)EmployeeManagerBindingSource).EndInit();
		((ISupportInitialize)SalespersonManagerGrid).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Salesperson_DetailForm_Load(object sender, EventArgs e)
	{
	}

	private void BackButton_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Control)MyProject.Forms.WelcomePage).Show();
	}

	private void SalespersonManagerGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void EmployeeName_Button_Click(object sender, EventArgs e)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			MessageBox.Show("No Such Employee Exist");
			ProjectData.ClearProjectError();
		}
	}

	private void TextBox1_TextChanged(object sender, EventArgs e)
	{
	}

	private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			MessageBox.Show("No Such Employee Exist");
			ProjectData.ClearProjectError();
		}
	}

	private void Label1_Click(object sender, EventArgs e)
	{
	}
}
