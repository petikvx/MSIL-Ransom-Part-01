using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace f0F;

[DesignerGenerated]
public class Hi8 : Form
{
	private IContainer components;

	private DataGridViewTextBoxColumn _CustomerDataGridViewTextBoxColumn;

	private BindingSource _TblCustomersBindingSource;

	internal DataGridView m;

	internal DataGridViewTextBoxColumn Q;

	internal DataGridViewTextBoxColumn y;

	internal BindingSource L;

	internal Label D;

	internal PictureBox f;

	internal BindingSource s;

	public Hi8()
	{
		((Form)this).add_Load((EventHandler)s7H);
		p2A();
	}

	protected override void Kj3(bool j2X)
	{
		try
		{
			if (j2X && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(j2X);
		}
	}

	private void p2A()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		components = new Container();
		w3T(new DataGridView());
		Gd4(new DataGridViewTextBoxColumn());
		No6(new DataGridViewTextBoxColumn());
		c9A(new DataGridViewTextBoxColumn());
		Ew9(new BindingSource(components));
		((ISupportInitialize)Yo6()).BeginInit();
		((Control)this).SuspendLayout();
		x4H().set_AutoGenerateColumns(false);
		x4H().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		x4H().get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[3]
		{
			(DataGridViewColumn)Ry8(),
			(DataGridViewColumn)o7E(),
			(DataGridViewColumn)Wd9()
		});
		x4H().set_DataSource((object)Yo6());
		((Control)x4H()).set_Location(new Point(3, 63));
		((Control)x4H()).set_Name("DataGridView1");
		((Control)x4H()).set_Size(new Size(240, 141));
		((Control)x4H()).set_TabIndex(1010);
		((DataGridViewColumn)Ry8()).set_DataPropertyName("BookingID");
		((DataGridViewColumn)Ry8()).set_HeaderText("BookingID");
		((DataGridViewColumn)Ry8()).set_Name("BookingIDDataGridViewTextBoxColumn");
		((DataGridViewColumn)o7E()).set_DataPropertyName("Customer");
		((DataGridViewColumn)o7E()).set_HeaderText("Customer");
		((DataGridViewColumn)o7E()).set_Name("CustomerDataGridViewTextBoxColumn");
		((DataGridViewColumn)Wd9()).set_DataPropertyName("Seat");
		((DataGridViewColumn)Wd9()).set_HeaderText("Seat");
		((DataGridViewColumn)Wd9()).set_Name("SeatDataGridViewTextBoxColumn");
		s1F().set_DataMember("tblBookings");
		Mt3().set_DataMember("tblCustomers");
		Ww8().set_AutoSize(true);
		((Control)Ww8()).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Ww8()).set_ForeColor(SystemColors.ControlLight);
		((Control)Ww8()).set_Location(new Point(34, 17));
		((Control)Ww8()).set_Name("Label6");
		((Control)Ww8()).set_Size(new Size(156, 24));
		((Control)Ww8()).set_TabIndex(1012);
		Ww8().set_Text("Reserved Seats");
		((Control)Mr7()).set_Dock((DockStyle)1);
		((Control)Mr7()).set_Location(new Point(0, 0));
		((Control)Mr7()).set_Name("PictureBox1");
		((Control)Mr7()).set_Size(new Size(248, 50));
		Mr7().set_TabIndex(1011);
		Mr7().set_TabStop(false);
		Yo6().set_DataMember("tblBookings");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(248, 237));
		((Control)this).get_Controls().Add((Control)(object)x4H());
		((Control)this).get_Controls().Add((Control)(object)Ww8());
		((Control)this).get_Controls().Add((Control)(object)Mr7());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("ReservedSeats2");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("ReservedSeats");
		((ISupportInitialize)x4H()).EndInit();
		((ISupportInitialize)s1F()).EndInit();
		((ISupportInitialize)Yo6()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual DataGridView x4H()
	{
		return m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w3T(DataGridView Fy0)
	{
		DataGridView val = (m = Fy0);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Ry8()
	{
		return Q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gd4(DataGridViewTextBoxColumn a5Y)
	{
		DataGridViewTextBoxColumn val = (Q = a5Y);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn o7E()
	{
		return _CustomerDataGridViewTextBoxColumn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void No6(DataGridViewTextBoxColumn j9H)
	{
		_CustomerDataGridViewTextBoxColumn = j9H;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Wd9()
	{
		return y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c9A(DataGridViewTextBoxColumn Wo6)
	{
		DataGridViewTextBoxColumn val = (y = Wo6);
	}

	[SpecialName]
	internal virtual BindingSource s1F()
	{
		return L;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ew9(BindingSource Pf1)
	{
		BindingSource val = (L = Pf1);
	}

	[SpecialName]
	internal virtual BindingSource Mt3()
	{
		return _TblCustomersBindingSource;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m3T(BindingSource Ki9)
	{
		_TblCustomersBindingSource = Ki9;
	}

	[SpecialName]
	internal virtual Label Ww8()
	{
		return D;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d2L(Label q5N)
	{
		Label val = (D = q5N);
	}

	[SpecialName]
	internal virtual PictureBox Mr7()
	{
		return f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ne7(PictureBox t6J)
	{
		PictureBox val = (f = t6J);
	}

	[SpecialName]
	internal virtual BindingSource Yo6()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j6Y(BindingSource k2A)
	{
		BindingSource val = (s = k2A);
	}

	private void s7H(object sender, EventArgs e)
	{
	}
}
