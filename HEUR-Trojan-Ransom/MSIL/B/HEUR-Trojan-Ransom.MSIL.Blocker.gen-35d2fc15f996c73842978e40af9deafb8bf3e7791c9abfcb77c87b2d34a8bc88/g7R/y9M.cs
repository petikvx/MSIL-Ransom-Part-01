using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace g7R;

[DesignerGenerated]
public class y9M : Form
{
	private DataGridView _DataGridView1;

	private Label _Label6;

	private DataGridViewTextBoxColumn _CustomerDataGridViewTextBoxColumn;

	internal IContainer U;

	internal PictureBox R;

	internal BindingSource O;

	internal DataGridViewTextBoxColumn X;

	internal DataGridViewTextBoxColumn S;

	public y9M()
	{
		((Form)this).add_Load((EventHandler)Ke8);
		Sd9();
	}

	protected override void o2C(bool Rp7)
	{
		try
		{
			if (Rp7 && U != null)
			{
				U.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Rp7);
		}
	}

	private void Sd9()
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
		IContainer container = (U = new Container());
		w2T(new DataGridView());
		No7(new DataGridViewTextBoxColumn());
		Hx1(new DataGridViewTextBoxColumn());
		Dt6(new DataGridViewTextBoxColumn());
		f5Y(new BindingSource(U));
		((ISupportInitialize)Ke4()).BeginInit();
		((Control)this).SuspendLayout();
		Ts4().set_AutoGenerateColumns(false);
		Ts4().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		Ts4().get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[3]
		{
			(DataGridViewColumn)w5F(),
			(DataGridViewColumn)Nq9(),
			(DataGridViewColumn)Fz4()
		});
		Ts4().set_DataSource((object)b7Q());
		((Control)Ts4()).set_Location(new Point(3, 65));
		((Control)Ts4()).set_Name("DataGridView1");
		((Control)Ts4()).set_Size(new Size(240, 141));
		((Control)Ts4()).set_TabIndex(1010);
		((DataGridViewColumn)w5F()).set_DataPropertyName("BookingID");
		((DataGridViewColumn)w5F()).set_HeaderText("BookingID");
		((DataGridViewColumn)w5F()).set_Name("BookingIDDataGridViewTextBoxColumn");
		((DataGridViewColumn)Nq9()).set_DataPropertyName("Customer");
		((DataGridViewColumn)Nq9()).set_HeaderText("Customer");
		((DataGridViewColumn)Nq9()).set_Name("CustomerDataGridViewTextBoxColumn");
		((DataGridViewColumn)Fz4()).set_DataPropertyName("Seat");
		((DataGridViewColumn)Fz4()).set_HeaderText("Seat");
		((DataGridViewColumn)Fz4()).set_Name("SeatDataGridViewTextBoxColumn");
		b7Q().set_DataMember("tblBookings");
		n2X().set_AutoSize(true);
		((Control)n2X()).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)n2X()).set_ForeColor(SystemColors.ControlLight);
		((Control)n2X()).set_Location(new Point(34, 19));
		((Control)n2X()).set_Name("Label6");
		((Control)n2X()).set_Size(new Size(156, 24));
		((Control)n2X()).set_TabIndex(1012);
		n2X().set_Text("Reserved Seats");
		((Control)Ke4()).set_Dock((DockStyle)1);
		((Control)Ke4()).set_Location(new Point(0, 0));
		((Control)Ke4()).set_Name("PictureBox1");
		((Control)Ke4()).set_Size(new Size(248, 50));
		Ke4().set_TabIndex(1011);
		Ke4().set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(248, 237));
		((Control)this).get_Controls().Add((Control)(object)Ts4());
		((Control)this).get_Controls().Add((Control)(object)n2X());
		((Control)this).get_Controls().Add((Control)(object)Ke4());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("ReservedSeats3");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("ReservedSeats");
		((ISupportInitialize)Ts4()).EndInit();
		((ISupportInitialize)b7Q()).EndInit();
		((ISupportInitialize)Ke4()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual DataGridView Ts4()
	{
		return _DataGridView1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w2T(DataGridView Pp3)
	{
		_DataGridView1 = Pp3;
	}

	[SpecialName]
	internal virtual Label n2X()
	{
		return _Label6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yi9(Label Eg0)
	{
		_Label6 = Eg0;
	}

	[SpecialName]
	internal virtual PictureBox Ke4()
	{
		return R;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ak2(PictureBox g5Q)
	{
		PictureBox val = (R = g5Q);
	}

	[SpecialName]
	internal virtual BindingSource b7Q()
	{
		return O;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f5Y(BindingSource k4Z)
	{
		BindingSource val = (O = k4Z);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn w5F()
	{
		return X;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void No7(DataGridViewTextBoxColumn p4F)
	{
		DataGridViewTextBoxColumn val = (X = p4F);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Nq9()
	{
		return _CustomerDataGridViewTextBoxColumn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hx1(DataGridViewTextBoxColumn g7G)
	{
		_CustomerDataGridViewTextBoxColumn = g7G;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Fz4()
	{
		return S;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dt6(DataGridViewTextBoxColumn Bp8)
	{
		DataGridViewTextBoxColumn val = (S = Bp8);
	}

	private void Ke8(object sender, EventArgs e)
	{
	}
}
