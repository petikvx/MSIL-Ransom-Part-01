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
public class AvailableLotform : Form
{
	private IContainer components;

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

	[field: AccessedThroughProperty("Availablelotformgrid")]
	internal virtual DataGridView Availablelotformgrid
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("AVAILABLELOTSBindingSource")]
	internal virtual BindingSource AVAILABLELOTSBindingSource
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

	[field: AccessedThroughProperty("SUBDIVISIONIDDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn SUBDIVISIONIDDataGridViewTextBoxColumn
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

	[field: AccessedThroughProperty("ISFENCEDDataGridViewCheckBoxColumn")]
	internal virtual DataGridViewCheckBoxColumn ISFENCEDDataGridViewCheckBoxColumn
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

	public AvailableLotform()
	{
		((Form)this).add_Load((EventHandler)AvailableLotform_Load);
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
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		components = new Container();
		BackButton = new Button();
		Availablelotformgrid = new DataGridView();
		LOTIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		SUBDIVISIONIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		NUMOFTREESDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		ISFENCEDDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
		ISCULDESACDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
		AVAILABLELOTSBindingSource = new BindingSource(components);
		((ISupportInitialize)Availablelotformgrid).BeginInit();
		((ISupportInitialize)AVAILABLELOTSBindingSource).BeginInit();
		((Control)this).SuspendLayout();
		((Control)BackButton).set_Location(new Point(273, 327));
		((Control)BackButton).set_Margin(new Padding(2));
		((Control)BackButton).set_Name("BackButton");
		((Control)BackButton).set_Size(new Size(68, 19));
		((Control)BackButton).set_TabIndex(0);
		((ButtonBase)BackButton).set_Text("&Back");
		((ButtonBase)BackButton).set_UseVisualStyleBackColor(true);
		Availablelotformgrid.set_AutoGenerateColumns(false);
		Availablelotformgrid.set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)6);
		Availablelotformgrid.set_AutoSizeRowsMode((DataGridViewAutoSizeRowsMode)7);
		Availablelotformgrid.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		Availablelotformgrid.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[5]
		{
			(DataGridViewColumn)LOTIDDataGridViewTextBoxColumn,
			(DataGridViewColumn)SUBDIVISIONIDDataGridViewTextBoxColumn,
			(DataGridViewColumn)NUMOFTREESDataGridViewTextBoxColumn,
			(DataGridViewColumn)ISFENCEDDataGridViewCheckBoxColumn,
			(DataGridViewColumn)ISCULDESACDataGridViewCheckBoxColumn
		});
		Availablelotformgrid.set_DataSource((object)AVAILABLELOTSBindingSource);
		((Control)Availablelotformgrid).set_Location(new Point(64, 52));
		((Control)Availablelotformgrid).set_Margin(new Padding(2));
		((Control)Availablelotformgrid).set_Name("Availablelotformgrid");
		Availablelotformgrid.set_RowHeadersVisible(false);
		Availablelotformgrid.set_RowHeadersWidth(51);
		Availablelotformgrid.get_RowTemplate().set_Height(24);
		((Control)Availablelotformgrid).set_Size(new Size(473, 251));
		((Control)Availablelotformgrid).set_TabIndex(1);
		((DataGridViewColumn)LOTIDDataGridViewTextBoxColumn).set_DataPropertyName("LOT_ID");
		((DataGridViewColumn)LOTIDDataGridViewTextBoxColumn).set_HeaderText("LOT_ID");
		((DataGridViewColumn)LOTIDDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)LOTIDDataGridViewTextBoxColumn).set_Name("LOTIDDataGridViewTextBoxColumn");
		((DataGridViewColumn)LOTIDDataGridViewTextBoxColumn).set_Width(70);
		((DataGridViewColumn)SUBDIVISIONIDDataGridViewTextBoxColumn).set_DataPropertyName("SUBDIVISION_ID");
		((DataGridViewColumn)SUBDIVISIONIDDataGridViewTextBoxColumn).set_HeaderText("SUBDIVISION_ID");
		((DataGridViewColumn)SUBDIVISIONIDDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)SUBDIVISIONIDDataGridViewTextBoxColumn).set_Name("SUBDIVISIONIDDataGridViewTextBoxColumn");
		((DataGridViewColumn)SUBDIVISIONIDDataGridViewTextBoxColumn).set_Width(118);
		((DataGridViewColumn)NUMOFTREESDataGridViewTextBoxColumn).set_DataPropertyName("NUM_OF_TREES");
		((DataGridViewColumn)NUMOFTREESDataGridViewTextBoxColumn).set_HeaderText("NUM_OF_TREES");
		((DataGridViewColumn)NUMOFTREESDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)NUMOFTREESDataGridViewTextBoxColumn).set_Name("NUMOFTREESDataGridViewTextBoxColumn");
		((DataGridViewColumn)NUMOFTREESDataGridViewTextBoxColumn).set_Width(119);
		((DataGridViewColumn)ISFENCEDDataGridViewCheckBoxColumn).set_DataPropertyName("IS_FENCED");
		((DataGridViewColumn)ISFENCEDDataGridViewCheckBoxColumn).set_HeaderText("IS_FENCED");
		((DataGridViewColumn)ISFENCEDDataGridViewCheckBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)ISFENCEDDataGridViewCheckBoxColumn).set_Name("ISFENCEDDataGridViewCheckBoxColumn");
		((DataGridViewColumn)ISFENCEDDataGridViewCheckBoxColumn).set_Width(72);
		((DataGridViewColumn)ISCULDESACDataGridViewCheckBoxColumn).set_DataPropertyName("IS_CULDESAC");
		((DataGridViewColumn)ISCULDESACDataGridViewCheckBoxColumn).set_HeaderText("IS_CULDESAC");
		((DataGridViewColumn)ISCULDESACDataGridViewCheckBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)ISCULDESACDataGridViewCheckBoxColumn).set_Name("ISCULDESACDataGridViewCheckBoxColumn");
		((DataGridViewColumn)ISCULDESACDataGridViewCheckBoxColumn).set_Width(86);
		AVAILABLELOTSBindingSource.set_DataMember("AVAILABLE_LOTS");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(600, 366));
		((Control)this).get_Controls().Add((Control)(object)Availablelotformgrid);
		((Control)this).get_Controls().Add((Control)(object)BackButton);
		((Form)this).set_Margin(new Padding(2));
		((Control)this).set_Name("AvailableLotform");
		((Form)this).set_Text("Available Lots");
		((ISupportInitialize)Availablelotformgrid).EndInit();
		((ISupportInitialize)AVAILABLELOTSBindingSource).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void BackButton_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Control)MyProject.Forms.WelcomePage).Show();
	}

	private void AvailableLotform_Load(object sender, EventArgs e)
	{
	}
}
