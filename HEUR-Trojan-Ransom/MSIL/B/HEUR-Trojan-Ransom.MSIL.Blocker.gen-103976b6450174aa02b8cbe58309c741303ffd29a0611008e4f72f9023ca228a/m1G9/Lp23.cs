using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace m1G9;

[DesignerGenerated]
public class Lp23 : Form
{
	private BindingSource _TblBookingsBindingSource;

	private DataGridViewTextBoxColumn _BookingIDDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn _CustomerDataGridViewTextBoxColumn;

	internal IContainer g;

	internal DataGridView d;

	internal Label H;

	internal PictureBox c;

	internal DataGridViewTextBoxColumn a;

	public Lp23()
	{
		((Form)this).add_Load((EventHandler)y0LD);
		n9S8();
	}

	protected override void Cy17(bool t4G0)
	{
		try
		{
			if (t4G0 && g != null)
			{
				g.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(t4G0);
		}
	}

	private void n9S8()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		IContainer container = (g = new Container());
		Xn3d(new DataGridView());
		x8S3(new DataGridViewTextBoxColumn());
		Wn27(new DataGridViewTextBoxColumn());
		z7Q1(new DataGridViewTextBoxColumn());
		e6M1(new BindingSource(g));
		((ISupportInitialize)Hj2z()).BeginInit();
		((Control)this).SuspendLayout();
		n3M4().set_AutoGenerateColumns(false);
		n3M4().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		n3M4().get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[3]
		{
			(DataGridViewColumn)w1JB(),
			(DataGridViewColumn)Ai4b(),
			(DataGridViewColumn)Mx80()
		});
		n3M4().set_DataSource((object)Nj0a());
		((Control)n3M4()).set_Location(new Point(3, 65));
		((Control)n3M4()).set_Name("DataGridView1");
		((Control)n3M4()).set_Size(new Size(240, 141));
		((Control)n3M4()).set_TabIndex(1010);
		((DataGridViewColumn)w1JB()).set_DataPropertyName("BookingID");
		((DataGridViewColumn)w1JB()).set_HeaderText("BookingID");
		((DataGridViewColumn)w1JB()).set_Name("BookingIDDataGridViewTextBoxColumn");
		((DataGridViewColumn)Ai4b()).set_DataPropertyName("Customer");
		((DataGridViewColumn)Ai4b()).set_HeaderText("Customer");
		((DataGridViewColumn)Ai4b()).set_Name("CustomerDataGridViewTextBoxColumn");
		((DataGridViewColumn)Mx80()).set_DataPropertyName("Seat");
		((DataGridViewColumn)Mx80()).set_HeaderText("Seat");
		((DataGridViewColumn)Mx80()).set_Name("SeatDataGridViewTextBoxColumn");
		Nj0a().set_DataMember("tblBookings");
		Yx6j().set_AutoSize(true);
		((Control)Yx6j()).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Yx6j()).set_ForeColor(SystemColors.ControlLight);
		((Control)Yx6j()).set_Location(new Point(34, 19));
		((Control)Yx6j()).set_Name("Label6");
		((Control)Yx6j()).set_Size(new Size(156, 24));
		((Control)Yx6j()).set_TabIndex(1012);
		Yx6j().set_Text("Reserved Seats");
		((Control)Hj2z()).set_Dock((DockStyle)1);
		((Control)Hj2z()).set_Location(new Point(0, 0));
		((Control)Hj2z()).set_Name("PictureBox1");
		((Control)Hj2z()).set_Size(new Size(248, 50));
		Hj2z().set_TabIndex(1011);
		Hj2z().set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(248, 237));
		((Control)this).get_Controls().Add((Control)(object)n3M4());
		((Control)this).get_Controls().Add((Control)(object)Yx6j());
		((Control)this).get_Controls().Add((Control)(object)Hj2z());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("ReservedSeats3");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("ReservedSeats");
		((ISupportInitialize)n3M4()).EndInit();
		((ISupportInitialize)Nj0a()).EndInit();
		((ISupportInitialize)Hj2z()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual DataGridView n3M4()
	{
		return d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xn3d(DataGridView w5BX)
	{
		DataGridView val = (d = w5BX);
	}

	[SpecialName]
	internal virtual Label Yx6j()
	{
		return H;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b4S2(Label Ao70)
	{
		Label val = (H = Ao70);
	}

	[SpecialName]
	internal virtual PictureBox Hj2z()
	{
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j9M8(PictureBox k1LF)
	{
		PictureBox val = (c = k1LF);
	}

	[SpecialName]
	internal virtual BindingSource Nj0a()
	{
		return _TblBookingsBindingSource;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e6M1(BindingSource z4HA)
	{
		_TblBookingsBindingSource = z4HA;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn w1JB()
	{
		return _BookingIDDataGridViewTextBoxColumn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x8S3(DataGridViewTextBoxColumn Nd14)
	{
		_BookingIDDataGridViewTextBoxColumn = Nd14;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Ai4b()
	{
		return _CustomerDataGridViewTextBoxColumn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wn27(DataGridViewTextBoxColumn Tp7g)
	{
		_CustomerDataGridViewTextBoxColumn = Tp7g;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Mx80()
	{
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z7Q1(DataGridViewTextBoxColumn Np01)
	{
		DataGridViewTextBoxColumn val = (a = Np01);
	}

	private void y0LD(object sender, EventArgs e)
	{
	}
}
