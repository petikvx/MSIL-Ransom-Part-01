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
public class Availablelotdetailform : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("AvailableDetailformGrid")]
	internal virtual DataGridView AvailableDetailformGrid
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("AvailablelotdetailQueryBindingSource")]
	internal virtual BindingSource AvailablelotdetailQueryBindingSource
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

	[field: AccessedThroughProperty("LOTIDDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn LOTIDDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ISFENCEDDataGridViewCheckBoxColumn")]
	internal virtual DataGridViewCheckBoxColumn ISFENCEDDataGridViewCheckBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("NUMOFTREESDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn NUMOFTREESDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ISCULDESACDataGridViewCheckBoxColumn")]
	internal virtual DataGridViewCheckBoxColumn ISCULDESACDataGridViewCheckBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LOTSTREETDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn LOTSTREETDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LOTPRICEDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn LOTPRICEDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LOTSIZEDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn LOTSIZEDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LOTMODELHOMEDataGridViewCheckBoxColumn")]
	internal virtual DataGridViewCheckBoxColumn LOTMODELHOMEDataGridViewCheckBoxColumn
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

	[field: AccessedThroughProperty("GOToolStrip1")]
	internal virtual ToolStrip GOToolStrip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Subdivision_NameToolStripLabel")]
	internal virtual ToolStripLabel Subdivision_NameToolStripLabel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Subdivision_NameToolStripTextBox")]
	internal virtual ToolStripTextBox Subdivision_NameToolStripTextBox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripButton GOToolStripButton
	{
		[CompilerGenerated]
		get
		{
			return _GOToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = GOToolStripButton_Click;
			ToolStripButton gOToolStripButton = _GOToolStripButton;
			if (gOToolStripButton != null)
			{
				((ToolStripItem)gOToolStripButton).remove_Click(eventHandler);
			}
			_GOToolStripButton = value;
			gOToolStripButton = _GOToolStripButton;
			if (gOToolStripButton != null)
			{
				((ToolStripItem)gOToolStripButton).add_Click(eventHandler);
			}
		}
	}

	public Availablelotdetailform()
	{
		((Form)this).add_Load((EventHandler)Availablelotdetailform_Load);
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
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0622: Unknown result type (might be due to invalid IL or missing references)
		//IL_062c: Expected O, but got Unknown
		//IL_06f9: Unknown result type (might be due to invalid IL or missing references)
		components = new Container();
		AvailableDetailformGrid = new DataGridView();
		SUBDIVISIONNAMEDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		LOTIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		ISFENCEDDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
		NUMOFTREESDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		ISCULDESACDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
		LOTSTREETDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		LOTPRICEDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		LOTSIZEDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		LOTMODELHOMEDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
		AvailablelotdetailQueryBindingSource = new BindingSource(components);
		BackButton = new Button();
		GOToolStrip1 = new ToolStrip();
		Subdivision_NameToolStripLabel = new ToolStripLabel();
		Subdivision_NameToolStripTextBox = new ToolStripTextBox();
		GOToolStripButton = new ToolStripButton();
		((ISupportInitialize)AvailableDetailformGrid).BeginInit();
		((ISupportInitialize)AvailablelotdetailQueryBindingSource).BeginInit();
		((Control)GOToolStrip1).SuspendLayout();
		((Control)this).SuspendLayout();
		AvailableDetailformGrid.set_AutoGenerateColumns(false);
		AvailableDetailformGrid.set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)6);
		AvailableDetailformGrid.set_AutoSizeRowsMode((DataGridViewAutoSizeRowsMode)7);
		AvailableDetailformGrid.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		AvailableDetailformGrid.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[9]
		{
			(DataGridViewColumn)SUBDIVISIONNAMEDataGridViewTextBoxColumn,
			(DataGridViewColumn)LOTIDDataGridViewTextBoxColumn,
			(DataGridViewColumn)ISFENCEDDataGridViewCheckBoxColumn,
			(DataGridViewColumn)NUMOFTREESDataGridViewTextBoxColumn,
			(DataGridViewColumn)ISCULDESACDataGridViewCheckBoxColumn,
			(DataGridViewColumn)LOTSTREETDataGridViewTextBoxColumn,
			(DataGridViewColumn)LOTPRICEDataGridViewTextBoxColumn,
			(DataGridViewColumn)LOTSIZEDataGridViewTextBoxColumn,
			(DataGridViewColumn)LOTMODELHOMEDataGridViewCheckBoxColumn
		});
		AvailableDetailformGrid.set_DataSource((object)AvailablelotdetailQueryBindingSource);
		((Control)AvailableDetailformGrid).set_Location(new Point(27, 49));
		((Control)AvailableDetailformGrid).set_Margin(new Padding(3, 2, 3, 2));
		((Control)AvailableDetailformGrid).set_Name("AvailableDetailformGrid");
		AvailableDetailformGrid.set_RowHeadersVisible(false);
		AvailableDetailformGrid.set_RowHeadersWidth(51);
		AvailableDetailformGrid.get_RowTemplate().set_Height(24);
		((Control)AvailableDetailformGrid).set_Size(new Size(1177, 318));
		((Control)AvailableDetailformGrid).set_TabIndex(0);
		((DataGridViewColumn)SUBDIVISIONNAMEDataGridViewTextBoxColumn).set_DataPropertyName("SUBDIVISION_NAME");
		((DataGridViewColumn)SUBDIVISIONNAMEDataGridViewTextBoxColumn).set_HeaderText("SUBDIVISION_NAME");
		((DataGridViewColumn)SUBDIVISIONNAMEDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)SUBDIVISIONNAMEDataGridViewTextBoxColumn).set_Name("SUBDIVISIONNAMEDataGridViewTextBoxColumn");
		((DataGridViewColumn)SUBDIVISIONNAMEDataGridViewTextBoxColumn).set_Width(170);
		((DataGridViewColumn)LOTIDDataGridViewTextBoxColumn).set_DataPropertyName("LOT_ID");
		((DataGridViewColumn)LOTIDDataGridViewTextBoxColumn).set_HeaderText("LOT_ID");
		((DataGridViewColumn)LOTIDDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)LOTIDDataGridViewTextBoxColumn).set_Name("LOTIDDataGridViewTextBoxColumn");
		((DataGridViewColumn)LOTIDDataGridViewTextBoxColumn).set_Width(86);
		((DataGridViewColumn)ISFENCEDDataGridViewCheckBoxColumn).set_DataPropertyName("IS_FENCED");
		((DataGridViewColumn)ISFENCEDDataGridViewCheckBoxColumn).set_HeaderText("IS_FENCED");
		((DataGridViewColumn)ISFENCEDDataGridViewCheckBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)ISFENCEDDataGridViewCheckBoxColumn).set_Name("ISFENCEDDataGridViewCheckBoxColumn");
		((DataGridViewColumn)ISFENCEDDataGridViewCheckBoxColumn).set_Width(89);
		((DataGridViewColumn)NUMOFTREESDataGridViewTextBoxColumn).set_DataPropertyName("NUM_OF_TREES");
		((DataGridViewColumn)NUMOFTREESDataGridViewTextBoxColumn).set_HeaderText("NUM_OF_TREES");
		((DataGridViewColumn)NUMOFTREESDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)NUMOFTREESDataGridViewTextBoxColumn).set_Name("NUMOFTREESDataGridViewTextBoxColumn");
		((DataGridViewColumn)NUMOFTREESDataGridViewTextBoxColumn).set_Width(149);
		((DataGridViewColumn)ISCULDESACDataGridViewCheckBoxColumn).set_DataPropertyName("IS_CULDESAC");
		((DataGridViewColumn)ISCULDESACDataGridViewCheckBoxColumn).set_HeaderText("IS_CULDESAC");
		((DataGridViewColumn)ISCULDESACDataGridViewCheckBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)ISCULDESACDataGridViewCheckBoxColumn).set_Name("ISCULDESACDataGridViewCheckBoxColumn");
		((DataGridViewColumn)ISCULDESACDataGridViewCheckBoxColumn).set_Width(107);
		((DataGridViewColumn)LOTSTREETDataGridViewTextBoxColumn).set_DataPropertyName("LOT_STREET");
		((DataGridViewColumn)LOTSTREETDataGridViewTextBoxColumn).set_HeaderText("LOT_STREET");
		((DataGridViewColumn)LOTSTREETDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)LOTSTREETDataGridViewTextBoxColumn).set_Name("LOTSTREETDataGridViewTextBoxColumn");
		((DataGridViewColumn)LOTSTREETDataGridViewTextBoxColumn).set_Width(128);
		((DataGridViewColumn)LOTPRICEDataGridViewTextBoxColumn).set_DataPropertyName("LOT_PRICE");
		((DataGridViewColumn)LOTPRICEDataGridViewTextBoxColumn).set_HeaderText("LOT_PRICE");
		((DataGridViewColumn)LOTPRICEDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)LOTPRICEDataGridViewTextBoxColumn).set_Name("LOTPRICEDataGridViewTextBoxColumn");
		((DataGridViewColumn)LOTPRICEDataGridViewTextBoxColumn).set_Width(113);
		((DataGridViewColumn)LOTSIZEDataGridViewTextBoxColumn).set_DataPropertyName("LOT_SIZE");
		((DataGridViewColumn)LOTSIZEDataGridViewTextBoxColumn).set_HeaderText("LOT_SIZE");
		((DataGridViewColumn)LOTSIZEDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)LOTSIZEDataGridViewTextBoxColumn).set_Name("LOTSIZEDataGridViewTextBoxColumn");
		((DataGridViewColumn)LOTSIZEDataGridViewTextBoxColumn).set_Width(103);
		((DataGridViewColumn)LOTMODELHOMEDataGridViewCheckBoxColumn).set_DataPropertyName("LOT_MODEL_HOME");
		((DataGridViewColumn)LOTMODELHOMEDataGridViewCheckBoxColumn).set_HeaderText("LOT_MODEL_HOME");
		((DataGridViewColumn)LOTMODELHOMEDataGridViewCheckBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)LOTMODELHOMEDataGridViewCheckBoxColumn).set_Name("LOTMODELHOMEDataGridViewCheckBoxColumn");
		((DataGridViewColumn)LOTMODELHOMEDataGridViewCheckBoxColumn).set_Width(148);
		AvailablelotdetailQueryBindingSource.set_DataMember("Available_lot_detail_Query");
		((Control)BackButton).set_Location(new Point(587, 414));
		((Control)BackButton).set_Margin(new Padding(3, 2, 3, 2));
		((Control)BackButton).set_Name("BackButton");
		((Control)BackButton).set_Size(new Size(91, 23));
		((Control)BackButton).set_TabIndex(2);
		((ButtonBase)BackButton).set_Text("&Back");
		((ButtonBase)BackButton).set_UseVisualStyleBackColor(true);
		GOToolStrip1.set_ImageScalingSize(new Size(20, 20));
		GOToolStrip1.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)Subdivision_NameToolStripLabel,
			(ToolStripItem)Subdivision_NameToolStripTextBox,
			(ToolStripItem)GOToolStripButton
		});
		((Control)GOToolStrip1).set_Location(new Point(0, 0));
		((Control)GOToolStrip1).set_Name("GOToolStrip1");
		((Control)GOToolStrip1).set_Size(new Size(1219, 27));
		((Control)GOToolStrip1).set_TabIndex(5);
		((Control)GOToolStrip1).set_Text("GOToolStrip1");
		((ToolStripItem)Subdivision_NameToolStripLabel).set_Name("Subdivision_NameToolStripLabel");
		((ToolStripItem)Subdivision_NameToolStripLabel).set_Size(new Size(134, 24));
		((ToolStripItem)Subdivision_NameToolStripLabel).set_Text("Subdivision_Name:");
		((ToolStripControlHost)Subdivision_NameToolStripTextBox).set_Font(new Font("Segoe UI", 9f));
		((ToolStripItem)Subdivision_NameToolStripTextBox).set_Name("Subdivision_NameToolStripTextBox");
		((ToolStripControlHost)Subdivision_NameToolStripTextBox).set_Size(new Size(100, 27));
		((ToolStripItem)GOToolStripButton).set_DisplayStyle((ToolStripItemDisplayStyle)1);
		((ToolStripItem)GOToolStripButton).set_Name("GOToolStripButton");
		((ToolStripItem)GOToolStripButton).set_Size(new Size(34, 24));
		((ToolStripItem)GOToolStripButton).set_Text("GO");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1219, 450));
		((Control)this).get_Controls().Add((Control)(object)GOToolStrip1);
		((Control)this).get_Controls().Add((Control)(object)BackButton);
		((Control)this).get_Controls().Add((Control)(object)AvailableDetailformGrid);
		((Form)this).set_Margin(new Padding(3, 2, 3, 2));
		((Control)this).set_Name("Availablelotdetailform");
		((Form)this).set_Text("Details of Available Lots");
		((ISupportInitialize)AvailableDetailformGrid).EndInit();
		((ISupportInitialize)AvailablelotdetailQueryBindingSource).EndInit();
		((Control)GOToolStrip1).ResumeLayout(false);
		((Control)GOToolStrip1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Availablelotdetailform_Load(object sender, EventArgs e)
	{
	}

	private void BackButton_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Control)MyProject.Forms.WelcomePage).Show();
	}

	private void GOToolStripButton_Click(object sender, EventArgs e)
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
