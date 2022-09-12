using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace f0S;

[DesignerGenerated]
public class Jg0 : Form
{
	private DataGridViewTextBoxColumn _BookingIDDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn _SeatDataGridViewTextBoxColumn;

	internal IContainer G;

	internal DataGridView y;

	internal BindingSource s;

	internal Label M;

	internal PictureBox t;

	internal BindingSource W;

	internal DataGridViewTextBoxColumn D;

	public Jg0()
	{
		((Form)this).add_Load((EventHandler)Rr7);
		j5F();
	}

	protected override void r4B(bool Dn8)
	{
		try
		{
			if (Dn8 && G != null)
			{
				G.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Dn8);
		}
	}

	private void j5F()
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
		IContainer container = (G = new Container());
		Xn1(new DataGridView());
		Bm2(new BindingSource(G));
		Jr3(new Label());
		c3Z(new PictureBox());
		w0Z(new DataGridViewTextBoxColumn());
		w2A(new DataGridViewTextBoxColumn());
		Hb2(new DataGridViewTextBoxColumn());
		((ISupportInitialize)Wx2()).BeginInit();
		((ISupportInitialize)Cn3()).BeginInit();
		((ISupportInitialize)d9D()).BeginInit();
		((ISupportInitialize)n1W()).BeginInit();
		((Control)this).SuspendLayout();
		Wx2().set_AutoGenerateColumns(false);
		Wx2().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		Wx2().get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[3]
		{
			(DataGridViewColumn)At8(),
			(DataGridViewColumn)Ez3(),
			(DataGridViewColumn)Jr9()
		});
		Wx2().set_DataSource((object)n1W());
		((Control)Wx2()).set_Location(new Point(3, 62));
		((Control)Wx2()).set_Name("DataGridView1");
		((Control)Wx2()).set_Size(new Size(240, 141));
		((Control)Wx2()).set_TabIndex(1007);
		Cn3().set_DataMember("tblCustomers");
		Nj3().set_AutoSize(true);
		((Control)Nj3()).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Nj3()).set_ForeColor(SystemColors.ControlLight);
		((Control)Nj3()).set_Location(new Point(34, 16));
		((Control)Nj3()).set_Name("Label6");
		((Control)Nj3()).set_Size(new Size(156, 24));
		((Control)Nj3()).set_TabIndex(1009);
		Nj3().set_Text("Reserved Seats");
		((Control)d9D()).set_Dock((DockStyle)1);
		((Control)d9D()).set_Location(new Point(0, 0));
		((Control)d9D()).set_Name("PictureBox1");
		((Control)d9D()).set_Size(new Size(248, 50));
		d9D().set_TabIndex(1008);
		d9D().set_TabStop(false);
		n1W().set_DataMember("tblBookings");
		((DataGridViewColumn)At8()).set_DataPropertyName("BookingID");
		((DataGridViewColumn)At8()).set_HeaderText("BookingID");
		((DataGridViewColumn)At8()).set_Name("BookingIDDataGridViewTextBoxColumn");
		((DataGridViewColumn)Ez3()).set_DataPropertyName("Customer");
		((DataGridViewColumn)Ez3()).set_HeaderText("Customer");
		((DataGridViewColumn)Ez3()).set_Name("CustomerDataGridViewTextBoxColumn");
		((DataGridViewColumn)Jr9()).set_DataPropertyName("Seat");
		((DataGridViewColumn)Jr9()).set_HeaderText("Seat");
		((DataGridViewColumn)Jr9()).set_Name("SeatDataGridViewTextBoxColumn");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(248, 237));
		((Control)this).get_Controls().Add((Control)(object)Wx2());
		((Control)this).get_Controls().Add((Control)(object)Nj3());
		((Control)this).get_Controls().Add((Control)(object)d9D());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("ReservedSeats");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("ReservedSeats");
		((ISupportInitialize)Wx2()).EndInit();
		((ISupportInitialize)Cn3()).EndInit();
		((ISupportInitialize)n1W()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual DataGridView Wx2()
	{
		return y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xn1(DataGridView c9N)
	{
		DataGridView val = (y = c9N);
	}

	[SpecialName]
	internal virtual BindingSource Cn3()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bm2(BindingSource Li3)
	{
		BindingSource val = (s = Li3);
	}

	[SpecialName]
	internal virtual Label Nj3()
	{
		return M;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jr3(Label e1K)
	{
		Label val = (M = e1K);
	}

	[SpecialName]
	internal virtual PictureBox d9D()
	{
		return t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c3Z(PictureBox c2M)
	{
		PictureBox val = (t = c2M);
	}

	[SpecialName]
	internal virtual BindingSource n1W()
	{
		return W;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wp2(BindingSource Tc3)
	{
		BindingSource val = (W = Tc3);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn At8()
	{
		return _BookingIDDataGridViewTextBoxColumn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w0Z(DataGridViewTextBoxColumn Mq4)
	{
		_BookingIDDataGridViewTextBoxColumn = Mq4;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Ez3()
	{
		return D;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w2A(DataGridViewTextBoxColumn Km9)
	{
		DataGridViewTextBoxColumn val = (D = Km9);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Jr9()
	{
		return _SeatDataGridViewTextBoxColumn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hb2(DataGridViewTextBoxColumn f2Y)
	{
		_SeatDataGridViewTextBoxColumn = f2Y;
	}

	private void Rr7(object sender, EventArgs e)
	{
	}
}
