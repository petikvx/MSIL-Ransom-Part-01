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
public class Subdivisions : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("DataGridView1")]
	internal virtual DataGridView DataGridView1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SUBDIVISIONBindingSource")]
	internal virtual BindingSource SUBDIVISIONBindingSource
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SUBDIVISIONIDDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn SUBDIVISIONIDDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SUBDIVISIONNAMEDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn SUBDIVISIONNAMEDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SUBDIVISIONADDRESSDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn SUBDIVISIONADDRESSDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CITYDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn CITYDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("STATEDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn STATEDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ZIPDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn ZIPDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CONSTRUCTIONSTARTDATEDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn CONSTRUCTIONSTARTDATEDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CONSTRUCTIONENDDATEDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn CONSTRUCTIONENDDATEDataGridViewTextBoxColumn
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

	[field: AccessedThroughProperty("ShowSubdivisionStateToolStrip")]
	internal virtual ToolStrip ShowSubdivisionStateToolStrip
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripButton ShowSubdivisionStateToolStripButton
	{
		[CompilerGenerated]
		get
		{
			return _ShowSubdivisionStateToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = ShowSubdivisionStateToolStripButton_Click_1;
			ToolStripButton showSubdivisionStateToolStripButton = _ShowSubdivisionStateToolStripButton;
			if (showSubdivisionStateToolStripButton != null)
			{
				((ToolStripItem)showSubdivisionStateToolStripButton).remove_Click(eventHandler);
			}
			_ShowSubdivisionStateToolStripButton = value;
			showSubdivisionStateToolStripButton = _ShowSubdivisionStateToolStripButton;
			if (showSubdivisionStateToolStripButton != null)
			{
				((ToolStripItem)showSubdivisionStateToolStripButton).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("ToolStripSeparator1")]
	internal virtual ToolStripSeparator ToolStripSeparator1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button AlamoSalespersons
	{
		[CompilerGenerated]
		get
		{
			return _AlamoSalespersons;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = AlamoSalespersons_Click;
			Button alamoSalespersons = _AlamoSalespersons;
			if (alamoSalespersons != null)
			{
				((Control)alamoSalespersons).remove_Click(eventHandler);
			}
			_AlamoSalespersons = value;
			alamoSalespersons = _AlamoSalespersons;
			if (alamoSalespersons != null)
			{
				((Control)alamoSalespersons).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("DataGridView2")]
	internal virtual DataGridView DataGridView2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SUBDIVISIONBindingSource1")]
	internal virtual BindingSource SUBDIVISIONBindingSource1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SUBDIVISIONBindingSource2")]
	internal virtual BindingSource SUBDIVISIONBindingSource2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SUBDIVISIONTableAdapterBindingSource")]
	internal virtual BindingSource SUBDIVISIONTableAdapterBindingSource
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBySubdivisonBindingSource")]
	internal virtual BindingSource GroupBySubdivisonBindingSource
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Expr1DataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn Expr1DataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SUBDIVISIONNAMEDataGridViewTextBoxColumn1")]
	internal virtual DataGridViewTextBoxColumn SUBDIVISIONNAMEDataGridViewTextBoxColumn1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CountofSalesPersonsDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn CountofSalesPersonsDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBySubdivisonBindingSource1")]
	internal virtual BindingSource GroupBySubdivisonBindingSource1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SalesPerson_Label")]
	internal virtual Label SalesPerson_Label
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridView3")]
	internal virtual DataGridView DataGridView3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupByStateBindingSource")]
	internal virtual BindingSource GroupByStateBindingSource
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("STATEDataGridViewTextBoxColumn1")]
	internal virtual DataGridViewTextBoxColumn STATEDataGridViewTextBoxColumn1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("NumberofSubdivisionDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn NumberofSubdivisionDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Sundivision_State")]
	internal virtual Label Sundivision_State
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button ShowAllLotsButton
	{
		[CompilerGenerated]
		get
		{
			return _ShowAllLotsButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = ShowAllLotsButton_Click;
			Button showAllLotsButton = _ShowAllLotsButton;
			if (showAllLotsButton != null)
			{
				((Control)showAllLotsButton).remove_Click(eventHandler);
			}
			_ShowAllLotsButton = value;
			showAllLotsButton = _ShowAllLotsButton;
			if (showAllLotsButton != null)
			{
				((Control)showAllLotsButton).add_Click(eventHandler);
			}
		}
	}

	public Subdivisions()
	{
		((Form)this).add_Load((EventHandler)Subdivisions_Load);
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
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected O, but got Unknown
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0609: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d48: Unknown result type (might be due to invalid IL or missing references)
		components = new Container();
		DataGridView1 = new DataGridView();
		SUBDIVISIONIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		SUBDIVISIONNAMEDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		SUBDIVISIONADDRESSDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		CITYDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		STATEDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		ZIPDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		CONSTRUCTIONSTARTDATEDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		CONSTRUCTIONENDDATEDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		SALESPERSONIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		SUBDIVISIONBindingSource = new BindingSource(components);
		BackButton = new Button();
		ShowSubdivisionStateToolStrip = new ToolStrip();
		ShowSubdivisionStateToolStripButton = new ToolStripButton();
		ToolStripSeparator1 = new ToolStripSeparator();
		AlamoSalespersons = new Button();
		DataGridView2 = new DataGridView();
		GroupBySubdivisonBindingSource = new BindingSource(components);
		SUBDIVISIONBindingSource2 = new BindingSource(components);
		SUBDIVISIONBindingSource1 = new BindingSource(components);
		SUBDIVISIONTableAdapterBindingSource = new BindingSource(components);
		GroupBySubdivisonBindingSource1 = new BindingSource(components);
		SUBDIVISIONNAMEDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
		CountofSalesPersonsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		SalesPerson_Label = new Label();
		DataGridView3 = new DataGridView();
		GroupByStateBindingSource = new BindingSource(components);
		STATEDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
		NumberofSubdivisionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		Sundivision_State = new Label();
		ShowAllLotsButton = new Button();
		((ISupportInitialize)DataGridView1).BeginInit();
		((ISupportInitialize)SUBDIVISIONBindingSource).BeginInit();
		((Control)ShowSubdivisionStateToolStrip).SuspendLayout();
		((ISupportInitialize)DataGridView2).BeginInit();
		((ISupportInitialize)GroupBySubdivisonBindingSource).BeginInit();
		((ISupportInitialize)SUBDIVISIONBindingSource2).BeginInit();
		((ISupportInitialize)SUBDIVISIONBindingSource1).BeginInit();
		((ISupportInitialize)SUBDIVISIONTableAdapterBindingSource).BeginInit();
		((ISupportInitialize)GroupBySubdivisonBindingSource1).BeginInit();
		((ISupportInitialize)DataGridView3).BeginInit();
		((ISupportInitialize)GroupByStateBindingSource).BeginInit();
		((Control)this).SuspendLayout();
		DataGridView1.set_AllowUserToAddRows(false);
		DataGridView1.set_AutoGenerateColumns(false);
		DataGridView1.set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)6);
		DataGridView1.set_AutoSizeRowsMode((DataGridViewAutoSizeRowsMode)7);
		DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		DataGridView1.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[9]
		{
			(DataGridViewColumn)SUBDIVISIONIDDataGridViewTextBoxColumn,
			(DataGridViewColumn)SUBDIVISIONNAMEDataGridViewTextBoxColumn,
			(DataGridViewColumn)SUBDIVISIONADDRESSDataGridViewTextBoxColumn,
			(DataGridViewColumn)CITYDataGridViewTextBoxColumn,
			(DataGridViewColumn)STATEDataGridViewTextBoxColumn,
			(DataGridViewColumn)ZIPDataGridViewTextBoxColumn,
			(DataGridViewColumn)CONSTRUCTIONSTARTDATEDataGridViewTextBoxColumn,
			(DataGridViewColumn)CONSTRUCTIONENDDATEDataGridViewTextBoxColumn,
			(DataGridViewColumn)SALESPERSONIDDataGridViewTextBoxColumn
		});
		DataGridView1.set_DataSource((object)SUBDIVISIONBindingSource);
		((Control)DataGridView1).set_Location(new Point(41, 34));
		((Control)DataGridView1).set_Margin(new Padding(4));
		((Control)DataGridView1).set_Name("DataGridView1");
		DataGridView1.set_RowHeadersVisible(false);
		DataGridView1.set_RowHeadersWidth(51);
		((Control)DataGridView1).set_Size(new Size(1348, 247));
		((Control)DataGridView1).set_TabIndex(0);
		((DataGridViewColumn)SUBDIVISIONIDDataGridViewTextBoxColumn).set_DataPropertyName("SUBDIVISION_ID");
		((DataGridViewColumn)SUBDIVISIONIDDataGridViewTextBoxColumn).set_HeaderText("SUBDIVISION_ID");
		((DataGridViewColumn)SUBDIVISIONIDDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)SUBDIVISIONIDDataGridViewTextBoxColumn).set_Name("SUBDIVISIONIDDataGridViewTextBoxColumn");
		((DataGridViewColumn)SUBDIVISIONIDDataGridViewTextBoxColumn).set_Width(144);
		((DataGridViewColumn)SUBDIVISIONNAMEDataGridViewTextBoxColumn).set_DataPropertyName("SUBDIVISION_NAME");
		((DataGridViewColumn)SUBDIVISIONNAMEDataGridViewTextBoxColumn).set_HeaderText("SUBDIVISION_NAME");
		((DataGridViewColumn)SUBDIVISIONNAMEDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)SUBDIVISIONNAMEDataGridViewTextBoxColumn).set_Name("SUBDIVISIONNAMEDataGridViewTextBoxColumn");
		((DataGridViewColumn)SUBDIVISIONNAMEDataGridViewTextBoxColumn).set_Width(170);
		((DataGridViewColumn)SUBDIVISIONADDRESSDataGridViewTextBoxColumn).set_DataPropertyName("SUBDIVISION_ADDRESS");
		((DataGridViewColumn)SUBDIVISIONADDRESSDataGridViewTextBoxColumn).set_HeaderText("SUBDIVISION_ADDRESS");
		((DataGridViewColumn)SUBDIVISIONADDRESSDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)SUBDIVISIONADDRESSDataGridViewTextBoxColumn).set_Name("SUBDIVISIONADDRESSDataGridViewTextBoxColumn");
		((DataGridViewColumn)SUBDIVISIONADDRESSDataGridViewTextBoxColumn).set_Width(197);
		((DataGridViewColumn)CITYDataGridViewTextBoxColumn).set_DataPropertyName("CITY");
		((DataGridViewColumn)CITYDataGridViewTextBoxColumn).set_HeaderText("CITY");
		((DataGridViewColumn)CITYDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)CITYDataGridViewTextBoxColumn).set_Name("CITYDataGridViewTextBoxColumn");
		((DataGridViewColumn)CITYDataGridViewTextBoxColumn).set_Width(67);
		((DataGridViewColumn)STATEDataGridViewTextBoxColumn).set_DataPropertyName("STATE");
		((DataGridViewColumn)STATEDataGridViewTextBoxColumn).set_HeaderText("STATE");
		((DataGridViewColumn)STATEDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)STATEDataGridViewTextBoxColumn).set_Name("STATEDataGridViewTextBoxColumn");
		((DataGridViewColumn)STATEDataGridViewTextBoxColumn).set_Width(82);
		((DataGridViewColumn)ZIPDataGridViewTextBoxColumn).set_DataPropertyName("ZIP");
		((DataGridViewColumn)ZIPDataGridViewTextBoxColumn).set_HeaderText("ZIP");
		((DataGridViewColumn)ZIPDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)ZIPDataGridViewTextBoxColumn).set_Name("ZIPDataGridViewTextBoxColumn");
		((DataGridViewColumn)ZIPDataGridViewTextBoxColumn).set_Width(58);
		((DataGridViewColumn)CONSTRUCTIONSTARTDATEDataGridViewTextBoxColumn).set_DataPropertyName("CONSTRUCTION_START_DATE");
		((DataGridViewColumn)CONSTRUCTIONSTARTDATEDataGridViewTextBoxColumn).set_HeaderText("CONSTRUCTION_START_DATE");
		((DataGridViewColumn)CONSTRUCTIONSTARTDATEDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)CONSTRUCTIONSTARTDATEDataGridViewTextBoxColumn).set_Name("CONSTRUCTIONSTARTDATEDataGridViewTextBoxColumn");
		((DataGridViewColumn)CONSTRUCTIONSTARTDATEDataGridViewTextBoxColumn).set_Width(246);
		((DataGridViewColumn)CONSTRUCTIONENDDATEDataGridViewTextBoxColumn).set_DataPropertyName("CONSTRUCTION_END_DATE");
		((DataGridViewColumn)CONSTRUCTIONENDDATEDataGridViewTextBoxColumn).set_HeaderText("CONSTRUCTION_END_DATE");
		((DataGridViewColumn)CONSTRUCTIONENDDATEDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)CONSTRUCTIONENDDATEDataGridViewTextBoxColumn).set_Name("CONSTRUCTIONENDDATEDataGridViewTextBoxColumn");
		((DataGridViewColumn)CONSTRUCTIONENDDATEDataGridViewTextBoxColumn).set_Width(229);
		((DataGridViewColumn)SALESPERSONIDDataGridViewTextBoxColumn).set_DataPropertyName("SALESPERSON_ID");
		((DataGridViewColumn)SALESPERSONIDDataGridViewTextBoxColumn).set_HeaderText("SALESPERSON_ID");
		((DataGridViewColumn)SALESPERSONIDDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)SALESPERSONIDDataGridViewTextBoxColumn).set_Name("SALESPERSONIDDataGridViewTextBoxColumn");
		((DataGridViewColumn)SALESPERSONIDDataGridViewTextBoxColumn).set_Width(160);
		SUBDIVISIONBindingSource.set_DataMember("SUBDIVISION");
		((Control)BackButton).set_Location(new Point(619, 502));
		((Control)BackButton).set_Margin(new Padding(3, 2, 3, 2));
		((Control)BackButton).set_Name("BackButton");
		((Control)BackButton).set_Size(new Size(91, 23));
		((Control)BackButton).set_TabIndex(4);
		((ButtonBase)BackButton).set_Text("Back");
		((ButtonBase)BackButton).set_UseVisualStyleBackColor(true);
		ShowSubdivisionStateToolStrip.set_ImageScalingSize(new Size(20, 20));
		ShowSubdivisionStateToolStrip.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)ShowSubdivisionStateToolStripButton,
			(ToolStripItem)ToolStripSeparator1
		});
		((Control)ShowSubdivisionStateToolStrip).set_Location(new Point(0, 0));
		((Control)ShowSubdivisionStateToolStrip).set_Name("ShowSubdivisionStateToolStrip");
		((Control)ShowSubdivisionStateToolStrip).set_Size(new Size(1477, 27));
		((Control)ShowSubdivisionStateToolStrip).set_TabIndex(5);
		((Control)ShowSubdivisionStateToolStrip).set_Text("By State");
		((ToolStripItem)ShowSubdivisionStateToolStripButton).set_DisplayStyle((ToolStripItemDisplayStyle)1);
		((ToolStripItem)ShowSubdivisionStateToolStripButton).set_Name("ShowSubdivisionStateToolStripButton");
		((ToolStripItem)ShowSubdivisionStateToolStripButton).set_Size(new Size(128, 24));
		((ToolStripItem)ShowSubdivisionStateToolStripButton).set_Text("By State Demand");
		((ToolStripItem)ToolStripSeparator1).set_Name("ToolStripSeparator1");
		((ToolStripItem)ToolStripSeparator1).set_Size(new Size(6, 27));
		((ButtonBase)AlamoSalespersons).set_BackColor(Color.FromArgb(255, 192, 192));
		((Control)AlamoSalespersons).set_ForeColor(Color.Black);
		((Control)AlamoSalespersons).set_Location(new Point(1240, 341));
		((Control)AlamoSalespersons).set_Margin(new Padding(4));
		((Control)AlamoSalespersons).set_Name("AlamoSalespersons");
		((Control)AlamoSalespersons).set_Size(new Size(149, 28));
		((Control)AlamoSalespersons).set_TabIndex(6);
		((ButtonBase)AlamoSalespersons).set_Text("Alamo Salespersons");
		((ButtonBase)AlamoSalespersons).set_UseVisualStyleBackColor(false);
		DataGridView2.set_AutoGenerateColumns(false);
		DataGridView2.set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)6);
		DataGridView2.set_AutoSizeRowsMode((DataGridViewAutoSizeRowsMode)7);
		DataGridView2.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		DataGridView2.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[2]
		{
			(DataGridViewColumn)SUBDIVISIONNAMEDataGridViewTextBoxColumn1,
			(DataGridViewColumn)CountofSalesPersonsDataGridViewTextBoxColumn
		});
		DataGridView2.set_DataSource((object)GroupBySubdivisonBindingSource1);
		((Control)DataGridView2).set_Location(new Point(41, 325));
		((Control)DataGridView2).set_Name("DataGridView2");
		DataGridView2.set_RowHeadersVisible(false);
		DataGridView2.set_RowHeadersWidth(51);
		DataGridView2.get_RowTemplate().set_Height(24);
		((Control)DataGridView2).set_Size(new Size(369, 150));
		((Control)DataGridView2).set_TabIndex(7);
		GroupBySubdivisonBindingSource.set_DataMember("GroupBySubdivison");
		SUBDIVISIONBindingSource2.set_DataMember("SUBDIVISION");
		((DataGridViewColumn)SUBDIVISIONNAMEDataGridViewTextBoxColumn1).set_DataPropertyName("SUBDIVISION_NAME");
		((DataGridViewColumn)SUBDIVISIONNAMEDataGridViewTextBoxColumn1).set_HeaderText("SUBDIVISION_NAME");
		((DataGridViewColumn)SUBDIVISIONNAMEDataGridViewTextBoxColumn1).set_MinimumWidth(6);
		((DataGridViewColumn)SUBDIVISIONNAMEDataGridViewTextBoxColumn1).set_Name("SUBDIVISIONNAMEDataGridViewTextBoxColumn1");
		((DataGridViewColumn)SUBDIVISIONNAMEDataGridViewTextBoxColumn1).set_Width(170);
		((DataGridViewColumn)CountofSalesPersonsDataGridViewTextBoxColumn).set_DataPropertyName("CountofSalesPersons");
		((DataGridViewColumn)CountofSalesPersonsDataGridViewTextBoxColumn).set_HeaderText("CountofSalesPersons");
		((DataGridViewColumn)CountofSalesPersonsDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)CountofSalesPersonsDataGridViewTextBoxColumn).set_Name("CountofSalesPersonsDataGridViewTextBoxColumn");
		((DataGridViewColumn)CountofSalesPersonsDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)CountofSalesPersonsDataGridViewTextBoxColumn).set_Width(173);
		SalesPerson_Label.set_AutoSize(true);
		((Control)SalesPerson_Label).set_Location(new Point(58, 296));
		((Control)SalesPerson_Label).set_Name("SalesPerson_Label");
		((Control)SalesPerson_Label).set_Size(new Size(184, 17));
		((Control)SalesPerson_Label).set_TabIndex(8);
		SalesPerson_Label.set_Text("Sales Person by Subdivison");
		DataGridView3.set_AutoGenerateColumns(false);
		DataGridView3.set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)6);
		DataGridView3.set_AutoSizeRowsMode((DataGridViewAutoSizeRowsMode)7);
		DataGridView3.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		DataGridView3.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[2]
		{
			(DataGridViewColumn)STATEDataGridViewTextBoxColumn1,
			(DataGridViewColumn)NumberofSubdivisionDataGridViewTextBoxColumn
		});
		DataGridView3.set_DataSource((object)GroupByStateBindingSource);
		((Control)DataGridView3).set_Location(new Point(921, 325));
		((Control)DataGridView3).set_Name("DataGridView3");
		DataGridView3.set_RowHeadersVisible(false);
		DataGridView3.set_RowHeadersWidth(51);
		DataGridView3.get_RowTemplate().set_Height(24);
		((Control)DataGridView3).set_Size(new Size(273, 150));
		((Control)DataGridView3).set_TabIndex(9);
		((DataGridViewColumn)STATEDataGridViewTextBoxColumn1).set_DataPropertyName("STATE");
		((DataGridViewColumn)STATEDataGridViewTextBoxColumn1).set_HeaderText("STATE");
		((DataGridViewColumn)STATEDataGridViewTextBoxColumn1).set_MinimumWidth(6);
		((DataGridViewColumn)STATEDataGridViewTextBoxColumn1).set_Name("STATEDataGridViewTextBoxColumn1");
		((DataGridViewColumn)STATEDataGridViewTextBoxColumn1).set_Width(82);
		((DataGridViewColumn)NumberofSubdivisionDataGridViewTextBoxColumn).set_DataPropertyName("Number_of_Subdivision");
		((DataGridViewColumn)NumberofSubdivisionDataGridViewTextBoxColumn).set_HeaderText("Number_of_Subdivision");
		((DataGridViewColumn)NumberofSubdivisionDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)NumberofSubdivisionDataGridViewTextBoxColumn).set_Name("NumberofSubdivisionDataGridViewTextBoxColumn");
		((DataGridViewColumn)NumberofSubdivisionDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)NumberofSubdivisionDataGridViewTextBoxColumn).set_Width(187);
		Sundivision_State.set_AutoSize(true);
		((Control)Sundivision_State).set_Location(new Point(934, 296));
		((Control)Sundivision_State).set_Name("Sundivision_State");
		((Control)Sundivision_State).set_Size(new Size(225, 17));
		((Control)Sundivision_State).set_TabIndex(10);
		Sundivision_State.set_Text("State with more than 1 Subdivision");
		((Control)ShowAllLotsButton).set_Location(new Point(592, 369));
		((Control)ShowAllLotsButton).set_Margin(new Padding(4));
		((Control)ShowAllLotsButton).set_Name("ShowAllLotsButton");
		((Control)ShowAllLotsButton).set_Size(new Size(148, 28));
		((Control)ShowAllLotsButton).set_TabIndex(11);
		((ButtonBase)ShowAllLotsButton).set_Text("Show All Subdivision");
		((ButtonBase)ShowAllLotsButton).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_CausesValidation(false);
		((Form)this).set_ClientSize(new Size(1477, 554));
		((Control)this).get_Controls().Add((Control)(object)ShowAllLotsButton);
		((Control)this).get_Controls().Add((Control)(object)Sundivision_State);
		((Control)this).get_Controls().Add((Control)(object)DataGridView3);
		((Control)this).get_Controls().Add((Control)(object)SalesPerson_Label);
		((Control)this).get_Controls().Add((Control)(object)DataGridView2);
		((Control)this).get_Controls().Add((Control)(object)AlamoSalespersons);
		((Control)this).get_Controls().Add((Control)(object)ShowSubdivisionStateToolStrip);
		((Control)this).get_Controls().Add((Control)(object)BackButton);
		((Control)this).get_Controls().Add((Control)(object)DataGridView1);
		((Form)this).set_Margin(new Padding(4));
		((Control)this).set_Name("Subdivisions");
		((Form)this).set_Text("SubdivisionsbyState");
		((ISupportInitialize)DataGridView1).EndInit();
		((ISupportInitialize)SUBDIVISIONBindingSource).EndInit();
		((Control)ShowSubdivisionStateToolStrip).ResumeLayout(false);
		((Control)ShowSubdivisionStateToolStrip).PerformLayout();
		((ISupportInitialize)DataGridView2).EndInit();
		((ISupportInitialize)GroupBySubdivisonBindingSource).EndInit();
		((ISupportInitialize)SUBDIVISIONBindingSource2).EndInit();
		((ISupportInitialize)SUBDIVISIONBindingSource1).EndInit();
		((ISupportInitialize)SUBDIVISIONTableAdapterBindingSource).EndInit();
		((ISupportInitialize)GroupBySubdivisonBindingSource1).EndInit();
		((ISupportInitialize)DataGridView3).EndInit();
		((ISupportInitialize)GroupByStateBindingSource).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Subdivisions_Load(object sender, EventArgs e)
	{
	}

	private void BackButton_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Control)MyProject.Forms.WelcomePage).Show();
	}

	private void ShowSubdivisionStateToolStripButton_Click(object sender, EventArgs e)
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

	private void ShowSubdivisionStateToolStripButton_Click_1(object sender, EventArgs e)
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

	private void AlamoSalespersons_Click(object sender, EventArgs e)
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

	private void ShowAllLotsButton_Click(object sender, EventArgs e)
	{
	}
}
