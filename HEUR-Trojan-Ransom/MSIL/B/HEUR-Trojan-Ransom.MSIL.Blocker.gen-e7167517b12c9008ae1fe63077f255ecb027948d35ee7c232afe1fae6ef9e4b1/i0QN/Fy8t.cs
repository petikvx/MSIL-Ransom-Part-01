using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Sr8;
using c5T;
using d6D;
using k2H;

namespace i0QN;

[DesignerGenerated]
public class Fy8t : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button1")]
	internal virtual Button Button1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button2
	{
		[CompilerGenerated]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Xj13;
			Button button = _Button2;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button2 = value;
			button = _Button2;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("PaidFully")]
	internal virtual RadioButton PaidFully
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PaidPartially")]
	internal virtual RadioButton PaidPartially
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RentDetailsBindingSource")]
	internal virtual BindingSource RentDetailsBindingSource
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

	[field: AccessedThroughProperty("HouseentryBindingSource")]
	internal virtual BindingSource HouseentryBindingSource
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PhoneDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn PhoneDataGridViewTextBoxColumn
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

	[field: AccessedThroughProperty("NoofPersoninFamilyDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn NoofPersoninFamilyDataGridViewTextBoxColumn
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

	[field: AccessedThroughProperty("FlatnoDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn FlatnoDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FlattypeDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn FlattypeDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RentAmountDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn RentAmountDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PaymentStatusDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn PaymentStatusDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("HouseentryBindingSource1")]
	internal virtual BindingSource HouseentryBindingSource1
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

	public Fy8t()
	{
		((Form)this).add_Load((EventHandler)Yj32);
		Rc51();
	}

	[DebuggerNonUserCode]
	protected override void Yb94(bool Ki63)
	{
		try
		{
			if (Ki63 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Ki63);
		}
	}

	[DebuggerStepThrough]
	private void Rc51()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
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
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_076e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0778: Expected O, but got Unknown
		components = new Container();
		Panel1 = new Panel();
		PaidPartially = new RadioButton();
		PaidFully = new RadioButton();
		Button1 = new Button();
		Button2 = new Button();
		RentDetailsBindingSource = new BindingSource(components);
		DataGridView1 = new DataGridView();
		HouseentryBindingSource = new BindingSource(components);
		PhoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		TenantIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		NoofPersoninFamilyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		BlockNoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		FlatnoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		FlattypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		RentAmountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		PaymentStatusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		HouseentryBindingSource1 = new BindingSource(components);
		Label1 = new Label();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)RentDetailsBindingSource).BeginInit();
		((ISupportInitialize)DataGridView1).BeginInit();
		((ISupportInitialize)HouseentryBindingSource).BeginInit();
		((ISupportInitialize)HouseentryBindingSource1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Panel1).get_Controls().Add((Control)(object)PaidPartially);
		((Control)Panel1).get_Controls().Add((Control)(object)PaidFully);
		((Control)Panel1).set_Location(new Point(47, 38));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(139, 116));
		((Control)Panel1).set_TabIndex(0);
		((ButtonBase)PaidPartially).set_AutoSize(true);
		((Control)PaidPartially).set_ForeColor(SystemColors.ControlText);
		((Control)PaidPartially).set_Location(new Point(13, 67));
		((Control)PaidPartially).set_Name("PaidPartially");
		((Control)PaidPartially).set_Size(new Size(111, 21));
		((Control)PaidPartially).set_TabIndex(24);
		PaidPartially.set_TabStop(true);
		((ButtonBase)PaidPartially).set_Text("Paid Partially");
		((ButtonBase)PaidPartially).set_UseVisualStyleBackColor(true);
		((ButtonBase)PaidFully).set_AutoSize(true);
		((Control)PaidFully).set_ForeColor(SystemColors.ControlText);
		((Control)PaidFully).set_Location(new Point(13, 18));
		((Control)PaidFully).set_Name("PaidFully");
		((Control)PaidFully).set_Size(new Size(90, 21));
		((Control)PaidFully).set_TabIndex(23);
		PaidFully.set_TabStop(true);
		((ButtonBase)PaidFully).set_Text("Paid Fully");
		((ButtonBase)PaidFully).set_UseVisualStyleBackColor(true);
		((Control)Button1).set_Location(new Point(248, 78));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(155, 48));
		((Control)Button1).set_TabIndex(1);
		((ButtonBase)Button1).set_Text("View Details");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((Control)Button2).set_Location(new Point(442, 78));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(155, 48));
		((Control)Button2).set_TabIndex(2);
		((ButtonBase)Button2).set_Text("Back");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		RentDetailsBindingSource.set_DataMember("RentDetails");
		DataGridView1.set_AutoGenerateColumns(false);
		DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		DataGridView1.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[8]
		{
			(DataGridViewColumn)PhoneDataGridViewTextBoxColumn,
			(DataGridViewColumn)TenantIDDataGridViewTextBoxColumn,
			(DataGridViewColumn)NoofPersoninFamilyDataGridViewTextBoxColumn,
			(DataGridViewColumn)BlockNoDataGridViewTextBoxColumn,
			(DataGridViewColumn)FlatnoDataGridViewTextBoxColumn,
			(DataGridViewColumn)FlattypeDataGridViewTextBoxColumn,
			(DataGridViewColumn)RentAmountDataGridViewTextBoxColumn,
			(DataGridViewColumn)PaymentStatusDataGridViewTextBoxColumn
		});
		DataGridView1.set_DataSource((object)HouseentryBindingSource1);
		((Control)DataGridView1).set_Location(new Point(25, 190));
		((Control)DataGridView1).set_Name("DataGridView1");
		DataGridView1.set_RowHeadersWidth(51);
		DataGridView1.get_RowTemplate().set_Height(24);
		((Control)DataGridView1).set_Size(new Size(1053, 176));
		((Control)DataGridView1).set_TabIndex(3);
		HouseentryBindingSource.set_DataMember("houseentry");
		((DataGridViewColumn)PhoneDataGridViewTextBoxColumn).set_DataPropertyName("Phone");
		((DataGridViewColumn)PhoneDataGridViewTextBoxColumn).set_HeaderText("Phone");
		((DataGridViewColumn)PhoneDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)PhoneDataGridViewTextBoxColumn).set_Name("PhoneDataGridViewTextBoxColumn");
		((DataGridViewColumn)PhoneDataGridViewTextBoxColumn).set_Width(125);
		((DataGridViewColumn)TenantIDDataGridViewTextBoxColumn).set_DataPropertyName("TenantID");
		((DataGridViewColumn)TenantIDDataGridViewTextBoxColumn).set_HeaderText("TenantID");
		((DataGridViewColumn)TenantIDDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)TenantIDDataGridViewTextBoxColumn).set_Name("TenantIDDataGridViewTextBoxColumn");
		((DataGridViewColumn)TenantIDDataGridViewTextBoxColumn).set_Width(125);
		((DataGridViewColumn)NoofPersoninFamilyDataGridViewTextBoxColumn).set_DataPropertyName("NoofPersoninFamily");
		((DataGridViewColumn)NoofPersoninFamilyDataGridViewTextBoxColumn).set_HeaderText("NoofPersoninFamily");
		((DataGridViewColumn)NoofPersoninFamilyDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)NoofPersoninFamilyDataGridViewTextBoxColumn).set_Name("NoofPersoninFamilyDataGridViewTextBoxColumn");
		((DataGridViewColumn)NoofPersoninFamilyDataGridViewTextBoxColumn).set_Width(125);
		((DataGridViewColumn)BlockNoDataGridViewTextBoxColumn).set_DataPropertyName("BlockNo");
		((DataGridViewColumn)BlockNoDataGridViewTextBoxColumn).set_HeaderText("BlockNo");
		((DataGridViewColumn)BlockNoDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)BlockNoDataGridViewTextBoxColumn).set_Name("BlockNoDataGridViewTextBoxColumn");
		((DataGridViewColumn)BlockNoDataGridViewTextBoxColumn).set_Width(125);
		((DataGridViewColumn)FlatnoDataGridViewTextBoxColumn).set_DataPropertyName("Flatno");
		((DataGridViewColumn)FlatnoDataGridViewTextBoxColumn).set_HeaderText("Flatno");
		((DataGridViewColumn)FlatnoDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)FlatnoDataGridViewTextBoxColumn).set_Name("FlatnoDataGridViewTextBoxColumn");
		((DataGridViewColumn)FlatnoDataGridViewTextBoxColumn).set_Width(125);
		((DataGridViewColumn)FlattypeDataGridViewTextBoxColumn).set_DataPropertyName("Flattype");
		((DataGridViewColumn)FlattypeDataGridViewTextBoxColumn).set_HeaderText("Flattype");
		((DataGridViewColumn)FlattypeDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)FlattypeDataGridViewTextBoxColumn).set_Name("FlattypeDataGridViewTextBoxColumn");
		((DataGridViewColumn)FlattypeDataGridViewTextBoxColumn).set_Width(125);
		((DataGridViewColumn)RentAmountDataGridViewTextBoxColumn).set_DataPropertyName("RentAmount");
		((DataGridViewColumn)RentAmountDataGridViewTextBoxColumn).set_HeaderText("RentAmount");
		((DataGridViewColumn)RentAmountDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)RentAmountDataGridViewTextBoxColumn).set_Name("RentAmountDataGridViewTextBoxColumn");
		((DataGridViewColumn)RentAmountDataGridViewTextBoxColumn).set_Width(125);
		((DataGridViewColumn)PaymentStatusDataGridViewTextBoxColumn).set_DataPropertyName("PaymentStatus");
		((DataGridViewColumn)PaymentStatusDataGridViewTextBoxColumn).set_HeaderText("PaymentStatus");
		((DataGridViewColumn)PaymentStatusDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)PaymentStatusDataGridViewTextBoxColumn).set_Name("PaymentStatusDataGridViewTextBoxColumn");
		((DataGridViewColumn)PaymentStatusDataGridViewTextBoxColumn).set_Width(125);
		HouseentryBindingSource1.set_DataMember("houseentry");
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Microsoft YaHei", 28.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_Location(new Point(347, 9));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(445, 64));
		((Control)Label1).set_TabIndex(4);
		Label1.set_Text("Rent Information");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1108, 537));
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)DataGridView1);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).set_Name("Rent_Info");
		((Form)this).set_Text("Rent_Info");
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((ISupportInitialize)RentDetailsBindingSource).EndInit();
		((ISupportInitialize)DataGridView1).EndInit();
		((ISupportInitialize)HouseentryBindingSource).EndInit();
		((ISupportInitialize)HouseentryBindingSource1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Yj32(object w9AP, EventArgs Rk93)
	{
	}

	private void Si5y(object Aq0r, DataGridViewCellEventArgs Ym69)
	{
	}

	private void r1E5(object b4Z6, DataGridViewCellEventArgs Zt8i)
	{
	}

	private void Xj13(object x9PC, EventArgs x5RL)
	{
		((Form)this).Close();
		((Control)b8G.Forms.Admin_Function).Show();
	}

	[STAThread]
	public static void k1QN()
	{
		int try0001_dispatch = -1;
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				}
				int d6J;
				do
				{
					d6J = 2;
				}
				while (!g8J.Mj3(d6J) || !My5.Tr8());
				int t2K = 1;
				Yw2.Mk7(t2K);
				break;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
				try0001_dispatch = 2;
			}
		}
	}
}
