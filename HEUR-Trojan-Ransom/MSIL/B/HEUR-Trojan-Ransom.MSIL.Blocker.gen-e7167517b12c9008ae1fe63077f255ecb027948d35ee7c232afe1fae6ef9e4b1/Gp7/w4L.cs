using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Gp7;

[DesignerGenerated]
public class w4L : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
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

	[field: AccessedThroughProperty("Column1")]
	internal virtual DataGridViewTextBoxColumn Column1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column2")]
	internal virtual DataGridViewTextBoxColumn Column2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column3")]
	internal virtual DataGridViewTextBoxColumn Column3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column4")]
	internal virtual DataGridViewTextBoxColumn Column4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column5")]
	internal virtual DataGridViewTextBoxColumn Column5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column6")]
	internal virtual DataGridViewTextBoxColumn Column6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column7")]
	internal virtual DataGridViewTextBoxColumn Column7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column8")]
	internal virtual DataGridViewTextBoxColumn Column8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Back")]
	internal virtual Button Back
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PrintC")]
	internal virtual Button PrintC
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public w4L()
	{
		r6R();
	}

	[DebuggerNonUserCode]
	protected override void p8M(bool Cd4)
	{
		try
		{
			if (Cd4 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Cd4);
		}
	}

	[DebuggerStepThrough]
	private void r6R()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		Panel1 = new Panel();
		DataGridView1 = new DataGridView();
		Column1 = new DataGridViewTextBoxColumn();
		Column2 = new DataGridViewTextBoxColumn();
		Column3 = new DataGridViewTextBoxColumn();
		Column4 = new DataGridViewTextBoxColumn();
		Column5 = new DataGridViewTextBoxColumn();
		Column6 = new DataGridViewTextBoxColumn();
		Column7 = new DataGridViewTextBoxColumn();
		Column8 = new DataGridViewTextBoxColumn();
		Back = new Button();
		PrintC = new Button();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)DataGridView1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Panel1).get_Controls().Add((Control)(object)DataGridView1);
		((Control)Panel1).set_Location(new Point(158, 217));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(963, 480));
		((Control)Panel1).set_TabIndex(3);
		DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		DataGridView1.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[8]
		{
			(DataGridViewColumn)Column1,
			(DataGridViewColumn)Column2,
			(DataGridViewColumn)Column3,
			(DataGridViewColumn)Column4,
			(DataGridViewColumn)Column5,
			(DataGridViewColumn)Column6,
			(DataGridViewColumn)Column7,
			(DataGridViewColumn)Column8
		});
		((Control)DataGridView1).set_Location(new Point(71, 50));
		((Control)DataGridView1).set_Name("DataGridView1");
		DataGridView1.get_RowTemplate().set_Height(24);
		((Control)DataGridView1).set_Size(new Size(844, 386));
		((Control)DataGridView1).set_TabIndex(0);
		((DataGridViewColumn)Column1).set_HeaderText("Tenant ID");
		((DataGridViewColumn)Column1).set_Name("Column1");
		((DataGridViewColumn)Column2).set_HeaderText("Name");
		((DataGridViewColumn)Column2).set_Name("Column2");
		((DataGridViewColumn)Column3).set_HeaderText("No. of Person");
		((DataGridViewColumn)Column3).set_Name("Column3");
		((DataGridViewColumn)Column4).set_HeaderText("Flat Number");
		((DataGridViewColumn)Column4).set_Name("Column4");
		((DataGridViewColumn)Column5).set_HeaderText("Flat Type");
		((DataGridViewColumn)Column5).set_Name("Column5");
		((DataGridViewColumn)Column6).set_HeaderText("Rent Amount");
		((DataGridViewColumn)Column6).set_Name("Column6");
		((DataGridViewColumn)Column7).set_HeaderText("Date");
		((DataGridViewColumn)Column7).set_Name("Column7");
		((DataGridViewColumn)Column8).set_HeaderText("Phone");
		((DataGridViewColumn)Column8).set_Name("Column8");
		((Control)Back).set_Location(new Point(706, 724));
		((Control)Back).set_Name("Back");
		((Control)Back).set_Size(new Size(126, 34));
		((Control)Back).set_TabIndex(5);
		((ButtonBase)Back).set_Text("Back");
		((ButtonBase)Back).set_UseVisualStyleBackColor(true);
		((Control)PrintC).set_Location(new Point(401, 724));
		((Control)PrintC).set_Name("PrintC");
		((Control)PrintC).set_Size(new Size(126, 34));
		((Control)PrintC).set_TabIndex(4);
		((ButtonBase)PrintC).set_Text("Print");
		((ButtonBase)PrintC).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1386, 773));
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).get_Controls().Add((Control)(object)Back);
		((Control)this).get_Controls().Add((Control)(object)PrintC);
		((Control)this).set_Name("Block_C");
		((Form)this).set_Text("Block_C");
		((Control)Panel1).ResumeLayout(false);
		((ISupportInitialize)DataGridView1).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
