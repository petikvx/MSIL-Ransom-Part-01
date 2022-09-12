using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Cy6;

[DesignerGenerated]
public class m1N : Form
{
	private BindingSource _TblCustomersBindingSource;

	private Label _Label6;

	private DataGridViewTextBoxColumn _BookingIDDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn _CustomerDataGridViewTextBoxColumn;

	internal IContainer s;

	internal DataGridView x;

	internal PictureBox i;

	internal BindingSource L;

	internal DataGridViewTextBoxColumn j;

	public m1N()
	{
		((Form)this).add_Load((EventHandler)w4L);
		k8C();
	}

	protected override void m5L(bool Rd3)
	{
		try
		{
			if (Rd3 && s != null)
			{
				s.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Rd3);
		}
	}

	private void k8C()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected O, but got Unknown
		IContainer container = (s = new Container());
		g4L(new DataGridView());
		k1D(new BindingSource(s));
		Gs3(new Label());
		Rs4(new PictureBox());
		Kn4(new DataGridViewTextBoxColumn());
		c4J(new DataGridViewTextBoxColumn());
		s3Y(new DataGridViewTextBoxColumn());
		((ISupportInitialize)c5J()).BeginInit();
		((ISupportInitialize)r3L()).BeginInit();
		((ISupportInitialize)Tb9()).BeginInit();
		((ISupportInitialize)Wi5()).BeginInit();
		((Control)this).SuspendLayout();
		c5J().set_AutoGenerateColumns(false);
		c5J().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		c5J().get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[3]
		{
			(DataGridViewColumn)Gk3(),
			(DataGridViewColumn)Kj7(),
			(DataGridViewColumn)s5M()
		});
		c5J().set_DataSource((object)Wi5());
		((Control)c5J()).set_Location(new Point(3, 62));
		((Control)c5J()).set_Name("DataGridView1");
		((Control)c5J()).set_Size(new Size(240, 141));
		((Control)c5J()).set_TabIndex(1007);
		r3L().set_DataMember("tblCustomers");
		Ew8().set_AutoSize(true);
		((Control)Ew8()).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Ew8()).set_ForeColor(SystemColors.ControlLight);
		((Control)Ew8()).set_Location(new Point(34, 16));
		((Control)Ew8()).set_Name("Label6");
		((Control)Ew8()).set_Size(new Size(156, 24));
		((Control)Ew8()).set_TabIndex(1009);
		Ew8().set_Text("Reserved Seats");
		((Control)Tb9()).set_Dock((DockStyle)1);
		((Control)Tb9()).set_Location(new Point(0, 0));
		((Control)Tb9()).set_Name("PictureBox1");
		((Control)Tb9()).set_Size(new Size(248, 50));
		Tb9().set_TabIndex(1008);
		Tb9().set_TabStop(false);
		Wi5().set_DataMember("tblBookings");
		((DataGridViewColumn)Gk3()).set_DataPropertyName("BookingID");
		((DataGridViewColumn)Gk3()).set_HeaderText("BookingID");
		((DataGridViewColumn)Gk3()).set_Name("BookingIDDataGridViewTextBoxColumn");
		((DataGridViewColumn)Kj7()).set_DataPropertyName("Customer");
		((DataGridViewColumn)Kj7()).set_HeaderText("Customer");
		((DataGridViewColumn)Kj7()).set_Name("CustomerDataGridViewTextBoxColumn");
		((DataGridViewColumn)s5M()).set_DataPropertyName("Seat");
		((DataGridViewColumn)s5M()).set_HeaderText("Seat");
		((DataGridViewColumn)s5M()).set_Name("SeatDataGridViewTextBoxColumn");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(248, 237));
		((Control)this).get_Controls().Add((Control)(object)c5J());
		((Control)this).get_Controls().Add((Control)(object)Ew8());
		((Control)this).get_Controls().Add((Control)(object)Tb9());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("ReservedSeats");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("ReservedSeats");
		((ISupportInitialize)c5J()).EndInit();
		((ISupportInitialize)r3L()).EndInit();
		((ISupportInitialize)Wi5()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual DataGridView c5J()
	{
		return x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g4L(DataGridView j1R)
	{
		DataGridView val = (x = j1R);
	}

	[SpecialName]
	internal virtual BindingSource r3L()
	{
		return _TblCustomersBindingSource;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k1D(BindingSource p1D)
	{
		_TblCustomersBindingSource = p1D;
	}

	[SpecialName]
	internal virtual Label Ew8()
	{
		return _Label6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gs3(Label Ri5)
	{
		_Label6 = Ri5;
	}

	[SpecialName]
	internal virtual PictureBox Tb9()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rs4(PictureBox z3S)
	{
		PictureBox val = (i = z3S);
	}

	[SpecialName]
	internal virtual BindingSource Wi5()
	{
		return L;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k3A(BindingSource y4G)
	{
		BindingSource val = (L = y4G);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Gk3()
	{
		return _BookingIDDataGridViewTextBoxColumn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kn4(DataGridViewTextBoxColumn r9A)
	{
		_BookingIDDataGridViewTextBoxColumn = r9A;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Kj7()
	{
		return _CustomerDataGridViewTextBoxColumn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c4J(DataGridViewTextBoxColumn p2F)
	{
		_CustomerDataGridViewTextBoxColumn = p2F;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn s5M()
	{
		return j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s3Y(DataGridViewTextBoxColumn b0C)
	{
		DataGridViewTextBoxColumn val = (j = b0C);
	}

	private void w4L(object sender, EventArgs e)
	{
	}
}
