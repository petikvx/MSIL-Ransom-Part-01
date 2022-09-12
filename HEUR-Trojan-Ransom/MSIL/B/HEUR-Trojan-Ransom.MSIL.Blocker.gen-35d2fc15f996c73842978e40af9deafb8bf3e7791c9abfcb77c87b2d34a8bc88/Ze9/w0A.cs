using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Ze9;

[DesignerGenerated]
public class w0A : Form
{
	private PictureBox _PictureBox1;

	private DataGridView _DataGridView1;

	private DataGridViewTextBoxColumn _CustomerDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn _SeatDataGridViewTextBoxColumn;

	internal IContainer v;

	internal Label F;

	internal BindingSource G;

	internal DataGridViewTextBoxColumn t;

	public w0A()
	{
		((Form)this).add_Load((EventHandler)Et6);
		i7P();
	}

	protected override void Yi7(bool i6R)
	{
		try
		{
			if (i6R && v != null)
			{
				v.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(i6R);
		}
	}

	private void i7P()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		IContainer container = (v = new Container());
		Aa1(new Label());
		Nd2(new PictureBox());
		Ei2(new DataGridView());
		g0W(new DataGridViewTextBoxColumn());
		Qo2(new DataGridViewTextBoxColumn());
		d6M(new DataGridViewTextBoxColumn());
		j4Q(new BindingSource(v));
		((ISupportInitialize)q7H()).BeginInit();
		((ISupportInitialize)p7D()).BeginInit();
		((ISupportInitialize)g6H()).BeginInit();
		((Control)this).SuspendLayout();
		Qt7().set_AutoSize(true);
		((Control)Qt7()).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Qt7()).set_ForeColor(SystemColors.ControlLight);
		((Control)Qt7()).set_Location(new Point(34, 20));
		((Control)Qt7()).set_Name("Label6");
		((Control)Qt7()).set_Size(new Size(156, 24));
		((Control)Qt7()).set_TabIndex(1015);
		Qt7().set_Text("Reserved Seats");
		((Control)q7H()).set_Dock((DockStyle)1);
		((Control)q7H()).set_Location(new Point(0, 0));
		((Control)q7H()).set_Name("PictureBox1");
		((Control)q7H()).set_Size(new Size(248, 50));
		q7H().set_TabIndex(1014);
		q7H().set_TabStop(false);
		p7D().set_AutoGenerateColumns(false);
		p7D().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		p7D().get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[3]
		{
			(DataGridViewColumn)Mj3(),
			(DataGridViewColumn)m9F(),
			(DataGridViewColumn)Hw0()
		});
		p7D().set_DataSource((object)g6H());
		((Control)p7D()).set_Location(new Point(16, 68));
		((Control)p7D()).set_Name("DataGridView1");
		((Control)p7D()).set_Size(new Size(216, 150));
		((Control)p7D()).set_TabIndex(1016);
		((DataGridViewColumn)Mj3()).set_DataPropertyName("BookingID");
		((DataGridViewColumn)Mj3()).set_HeaderText("BookingID");
		((DataGridViewColumn)Mj3()).set_Name("BookingIDDataGridViewTextBoxColumn");
		((DataGridViewColumn)m9F()).set_DataPropertyName("Customer");
		((DataGridViewColumn)m9F()).set_HeaderText("Customer");
		((DataGridViewColumn)m9F()).set_Name("CustomerDataGridViewTextBoxColumn");
		((DataGridViewColumn)Hw0()).set_DataPropertyName("Seat");
		((DataGridViewColumn)Hw0()).set_HeaderText("Seat");
		((DataGridViewColumn)Hw0()).set_Name("SeatDataGridViewTextBoxColumn");
		g6H().set_DataMember("tblBookings");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(248, 237));
		((Control)this).get_Controls().Add((Control)(object)p7D());
		((Control)this).get_Controls().Add((Control)(object)Qt7());
		((Control)this).get_Controls().Add((Control)(object)q7H());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("ReservedSeats4");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("ReservedSeats");
		((ISupportInitialize)q7H()).EndInit();
		((ISupportInitialize)p7D()).EndInit();
		((ISupportInitialize)g6H()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label Qt7()
	{
		return F;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Aa1(Label z0K)
	{
		Label val = (F = z0K);
	}

	[SpecialName]
	internal virtual PictureBox q7H()
	{
		return _PictureBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nd2(PictureBox y9Y)
	{
		_PictureBox1 = y9Y;
	}

	[SpecialName]
	internal virtual DataGridView p7D()
	{
		return _DataGridView1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ei2(DataGridView No4)
	{
		_DataGridView1 = No4;
	}

	[SpecialName]
	internal virtual BindingSource g6H()
	{
		return G;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j4Q(BindingSource q9P)
	{
		BindingSource val = (G = q9P);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Mj3()
	{
		return t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g0W(DataGridViewTextBoxColumn k4N)
	{
		DataGridViewTextBoxColumn val = (t = k4N);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn m9F()
	{
		return _CustomerDataGridViewTextBoxColumn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qo2(DataGridViewTextBoxColumn c5B)
	{
		_CustomerDataGridViewTextBoxColumn = c5B;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Hw0()
	{
		return _SeatDataGridViewTextBoxColumn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d6M(DataGridViewTextBoxColumn d8Y)
	{
		_SeatDataGridViewTextBoxColumn = d8Y;
	}

	private void Et6(object sender, EventArgs e)
	{
	}
}
