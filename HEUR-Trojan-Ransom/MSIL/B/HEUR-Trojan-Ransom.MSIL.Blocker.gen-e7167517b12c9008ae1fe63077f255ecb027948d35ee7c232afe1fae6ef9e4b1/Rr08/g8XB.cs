using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using d6D;

namespace Rr08;

[DesignerGenerated]
public class g8XB : Form
{
	private IContainer components;

	internal virtual Button Back
	{
		[CompilerGenerated]
		get
		{
			return _Back;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = a0L4;
			Button back = _Back;
			if (back != null)
			{
				((Control)back).remove_Click(eventHandler);
			}
			_Back = value;
			back = _Back;
			if (back != null)
			{
				((Control)back).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("EventhallBindingSource")]
	internal virtual BindingSource EventhallBindingSource
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FillByToolStrip")]
	internal virtual ToolStrip FillByToolStrip
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripButton FillByToolStripButton
	{
		[CompilerGenerated]
		get
		{
			return _FillByToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = s2SG;
			ToolStripButton fillByToolStripButton = _FillByToolStripButton;
			if (fillByToolStripButton != null)
			{
				((ToolStripItem)fillByToolStripButton).remove_Click(eventHandler);
			}
			_FillByToolStripButton = value;
			fillByToolStripButton = _FillByToolStripButton;
			if (fillByToolStripButton != null)
			{
				((ToolStripItem)fillByToolStripButton).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("DataGridView1")]
	internal virtual DataGridView DataGridView1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("EventhallBindingSource1")]
	internal virtual BindingSource EventhallBindingSource1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DateDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn DateDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PurposeDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn PurposeDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TenantIDDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn TenantIDDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("BlockNoDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn BlockNoDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FlatNoDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn FlatNoDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public g8XB()
	{
		((Form)this).add_Load((EventHandler)Ez34);
		Dr08();
	}

	[DebuggerNonUserCode]
	protected override void Cm9n(bool q2Z5)
	{
		try
		{
			if (q2Z5 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(q2Z5);
		}
	}

	[DebuggerStepThrough]
	private void Dr08()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		components = new Container();
		Back = new Button();
		FillByToolStrip = new ToolStrip();
		FillByToolStripButton = new ToolStripButton();
		EventhallBindingSource = new BindingSource(components);
		DataGridView1 = new DataGridView();
		EventhallBindingSource1 = new BindingSource(components);
		DateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		PurposeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		TenantIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		BlockNoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		FlatNoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		Label1 = new Label();
		((Control)FillByToolStrip).SuspendLayout();
		((ISupportInitialize)EventhallBindingSource).BeginInit();
		((ISupportInitialize)DataGridView1).BeginInit();
		((ISupportInitialize)EventhallBindingSource1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Back).set_Location(new Point(25, 441));
		((Control)Back).set_Name("Back");
		((Control)Back).set_Size(new Size(121, 39));
		((Control)Back).set_TabIndex(2);
		((ButtonBase)Back).set_Text("Back");
		((ButtonBase)Back).set_UseVisualStyleBackColor(true);
		FillByToolStrip.set_ImageScalingSize(new Size(20, 20));
		FillByToolStrip.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)FillByToolStripButton });
		((Control)FillByToolStrip).set_Location(new Point(0, 0));
		((Control)FillByToolStrip).set_Name("FillByToolStrip");
		((Control)FillByToolStrip).set_Size(new Size(1019, 31));
		((Control)FillByToolStrip).set_TabIndex(4);
		((Control)FillByToolStrip).set_Text("FillByToolStrip");
		((ToolStripItem)FillByToolStripButton).set_DisplayStyle((ToolStripItemDisplayStyle)1);
		((ToolStripItem)FillByToolStripButton).set_Name("FillByToolStripButton");
		((ToolStripItem)FillByToolStripButton).set_Size(new Size(48, 24));
		((ToolStripItem)FillByToolStripButton).set_Text("FillBy");
		EventhallBindingSource.set_DataMember("eventhall");
		DataGridView1.set_AllowUserToOrderColumns(true);
		DataGridView1.set_AutoGenerateColumns(false);
		DataGridView1.set_BackgroundColor(SystemColors.ButtonHighlight);
		DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		DataGridView1.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[5]
		{
			(DataGridViewColumn)DateDataGridViewTextBoxColumn,
			(DataGridViewColumn)PurposeDataGridViewTextBoxColumn,
			(DataGridViewColumn)TenantIDDataGridViewTextBoxColumn,
			(DataGridViewColumn)BlockNoDataGridViewTextBoxColumn,
			(DataGridViewColumn)FlatNoDataGridViewTextBoxColumn
		});
		DataGridView1.set_DataSource((object)EventhallBindingSource1);
		((Control)DataGridView1).set_Location(new Point(165, 167));
		((Control)DataGridView1).set_Name("DataGridView1");
		DataGridView1.set_RowHeadersWidth(51);
		DataGridView1.get_RowTemplate().set_Height(24);
		((Control)DataGridView1).set_Size(new Size(714, 313));
		((Control)DataGridView1).set_TabIndex(5);
		EventhallBindingSource1.set_DataMember("eventhall");
		((DataGridViewColumn)DateDataGridViewTextBoxColumn).set_DataPropertyName("Date");
		((DataGridViewColumn)DateDataGridViewTextBoxColumn).set_HeaderText("Date");
		((DataGridViewColumn)DateDataGridViewTextBoxColumn).set_MinimumWidth(3);
		((DataGridViewColumn)DateDataGridViewTextBoxColumn).set_Name("DateDataGridViewTextBoxColumn");
		((DataGridViewColumn)PurposeDataGridViewTextBoxColumn).set_DataPropertyName("Purpose");
		((DataGridViewColumn)PurposeDataGridViewTextBoxColumn).set_HeaderText("Purpose");
		((DataGridViewColumn)PurposeDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)PurposeDataGridViewTextBoxColumn).set_Name("PurposeDataGridViewTextBoxColumn");
		((DataGridViewColumn)PurposeDataGridViewTextBoxColumn).set_Width(200);
		((DataGridViewColumn)TenantIDDataGridViewTextBoxColumn).set_DataPropertyName("TenantID");
		((DataGridViewColumn)TenantIDDataGridViewTextBoxColumn).set_HeaderText("TenantID");
		((DataGridViewColumn)TenantIDDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)TenantIDDataGridViewTextBoxColumn).set_Name("TenantIDDataGridViewTextBoxColumn");
		((DataGridViewColumn)TenantIDDataGridViewTextBoxColumn).set_Width(75);
		((DataGridViewColumn)BlockNoDataGridViewTextBoxColumn).set_DataPropertyName("BlockNo");
		((DataGridViewColumn)BlockNoDataGridViewTextBoxColumn).set_HeaderText("BlockNo");
		((DataGridViewColumn)BlockNoDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)BlockNoDataGridViewTextBoxColumn).set_Name("BlockNoDataGridViewTextBoxColumn");
		((DataGridViewColumn)BlockNoDataGridViewTextBoxColumn).set_Width(50);
		((DataGridViewColumn)FlatNoDataGridViewTextBoxColumn).set_DataPropertyName("FlatNo");
		((DataGridViewColumn)FlatNoDataGridViewTextBoxColumn).set_HeaderText("FlatNo");
		((DataGridViewColumn)FlatNoDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)FlatNoDataGridViewTextBoxColumn).set_Name("FlatNoDataGridViewTextBoxColumn");
		((DataGridViewColumn)FlatNoDataGridViewTextBoxColumn).set_Width(50);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Location(new Point(375, 71));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(134, 17));
		((Control)Label1).set_TabIndex(6);
		Label1.set_Text("Hall Booking Details");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1019, 651));
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)DataGridView1);
		((Control)this).get_Controls().Add((Control)(object)FillByToolStrip);
		((Control)this).get_Controls().Add((Control)(object)Back);
		((Control)this).set_Name("Booking_Info");
		((Form)this).set_Text("Booking_Info");
		((Control)FillByToolStrip).ResumeLayout(false);
		((Control)FillByToolStrip).PerformLayout();
		((ISupportInitialize)EventhallBindingSource).EndInit();
		((ISupportInitialize)DataGridView1).EndInit();
		((ISupportInitialize)EventhallBindingSource1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void a0L4(object j1AZ, EventArgs Bz5k)
	{
		((Form)this).Close();
		((Control)b8G.Forms.Admin_Function).Show();
	}

	private void Wy62(object Ts3y, EventArgs z1P2)
	{
	}

	private void Ez34(object Tc09, EventArgs i4JS)
	{
	}

	internal static byte[] Hg84(int Np7q, int As30)
	{
		if (Np7q <= 0)
		{
			return null;
		}
		checked
		{
			int[] array = new int[As30 + 1];
			for (int i = 0; i <= As30; i++)
			{
				int num = Np7q * i;
				if (num > 255)
				{
					num = 255;
				}
				array[i] = num;
			}
			return Jo09(array, As30);
		}
	}

	private void s2SG(object n2JR, EventArgs Xn6a)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
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

	internal static byte[] Jo09(int[] Eo0s, int Qw3t)
	{
		checked
		{
			byte[] array = new byte[Qw3t + 1];
			int num = Eo0s.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = (byte)Eo0s[i];
			}
			return array;
		}
	}
}
