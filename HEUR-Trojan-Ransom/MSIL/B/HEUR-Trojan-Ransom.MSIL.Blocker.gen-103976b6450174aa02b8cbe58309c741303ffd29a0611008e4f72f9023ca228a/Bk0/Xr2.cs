using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Bk0;

[DesignerGenerated]
public class Xr2 : Form
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 11174)]
	private struct Yr87
	{
	}

	private IContainer components;

	private DataGridViewTextBoxColumn _BookingIDDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn _CustomerDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn _SeatDataGridViewTextBoxColumn;

	private BindingSource _TblBookingsBindingSource;

	private PictureBox _PictureBox1;

	private static readonly Array W;

	private static readonly Array m;

	private static readonly object T;

	internal static byte c/* Not supported: data(00) */;

	internal DataGridView g;

	internal BindingSource N;

	internal Label h;

	internal BindingSource k;

	public Xr2()
	{
		((Form)this).add_Load((EventHandler)Jz24);
		Ca7x();
	}

	protected override void Ti8(bool Wn8)
	{
		try
		{
			if (Wn8 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Wn8);
		}
	}

	private void Ca7x()
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
		r5S6(new DataGridView());
		b1Q3(new DataGridViewTextBoxColumn());
		By75(new DataGridViewTextBoxColumn());
		Pi43(new DataGridViewTextBoxColumn());
		k2HR(new BindingSource(components));
		((ISupportInitialize)d2P7()).BeginInit();
		((Control)this).SuspendLayout();
		Xj13().set_AutoGenerateColumns(false);
		Xj13().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		Xj13().get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[3]
		{
			(DataGridViewColumn)d1QS(),
			(DataGridViewColumn)y2M4(),
			(DataGridViewColumn)m8D4()
		});
		Xj13().set_DataSource((object)d2P7());
		((Control)Xj13()).set_Location(new Point(3, 63));
		((Control)Xj13()).set_Name("DataGridView1");
		((Control)Xj13()).set_Size(new Size(240, 141));
		((Control)Xj13()).set_TabIndex(1010);
		((DataGridViewColumn)d1QS()).set_DataPropertyName("BookingID");
		((DataGridViewColumn)d1QS()).set_HeaderText("BookingID");
		((DataGridViewColumn)d1QS()).set_Name("BookingIDDataGridViewTextBoxColumn");
		((DataGridViewColumn)y2M4()).set_DataPropertyName("Customer");
		((DataGridViewColumn)y2M4()).set_HeaderText("Customer");
		((DataGridViewColumn)y2M4()).set_Name("CustomerDataGridViewTextBoxColumn");
		((DataGridViewColumn)m8D4()).set_DataPropertyName("Seat");
		((DataGridViewColumn)m8D4()).set_HeaderText("Seat");
		((DataGridViewColumn)m8D4()).set_Name("SeatDataGridViewTextBoxColumn");
		f6CB().set_DataMember("tblBookings");
		Se1o().set_DataMember("tblCustomers");
		Fi8e().set_AutoSize(true);
		((Control)Fi8e()).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Fi8e()).set_ForeColor(SystemColors.ControlLight);
		((Control)Fi8e()).set_Location(new Point(34, 17));
		((Control)Fi8e()).set_Name("Label6");
		((Control)Fi8e()).set_Size(new Size(156, 24));
		((Control)Fi8e()).set_TabIndex(1012);
		Fi8e().set_Text("Reserved Seats");
		((Control)k1GJ()).set_Dock((DockStyle)1);
		((Control)k1GJ()).set_Location(new Point(0, 0));
		((Control)k1GJ()).set_Name("PictureBox1");
		((Control)k1GJ()).set_Size(new Size(248, 50));
		k1GJ().set_TabIndex(1011);
		k1GJ().set_TabStop(false);
		d2P7().set_DataMember("tblBookings");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(248, 237));
		((Control)this).get_Controls().Add((Control)(object)Xj13());
		((Control)this).get_Controls().Add((Control)(object)Fi8e());
		((Control)this).get_Controls().Add((Control)(object)k1GJ());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("ReservedSeats2");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("ReservedSeats");
		((ISupportInitialize)Xj13()).EndInit();
		((ISupportInitialize)f6CB()).EndInit();
		((ISupportInitialize)d2P7()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual DataGridView Xj13()
	{
		return g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r5S6(DataGridView Ky42)
	{
		DataGridView val = (g = Ky42);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn d1QS()
	{
		return _BookingIDDataGridViewTextBoxColumn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b1Q3(DataGridViewTextBoxColumn Cy94)
	{
		_BookingIDDataGridViewTextBoxColumn = Cy94;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn y2M4()
	{
		return _CustomerDataGridViewTextBoxColumn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void By75(DataGridViewTextBoxColumn Tq45)
	{
		_CustomerDataGridViewTextBoxColumn = Tq45;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn m8D4()
	{
		return _SeatDataGridViewTextBoxColumn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pi43(DataGridViewTextBoxColumn m7F6)
	{
		_SeatDataGridViewTextBoxColumn = m7F6;
	}

	[SpecialName]
	internal virtual BindingSource f6CB()
	{
		return _TblBookingsBindingSource;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k2HR(BindingSource Ca9e)
	{
		_TblBookingsBindingSource = Ca9e;
	}

	[SpecialName]
	internal virtual BindingSource Se1o()
	{
		return N;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qz6t(BindingSource e1B6)
	{
		BindingSource val = (N = e1B6);
	}

	[SpecialName]
	internal virtual Label Fi8e()
	{
		return h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ks2k(Label Eg47)
	{
		Label val = (h = Eg47);
	}

	[SpecialName]
	internal virtual PictureBox k1GJ()
	{
		return _PictureBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tm5p(PictureBox Sp12)
	{
		_PictureBox1 = Sp12;
	}

	[SpecialName]
	internal virtual BindingSource d2P7()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c2T0(BindingSource y7NZ)
	{
		BindingSource val = (k = y7NZ);
	}

	private void Jz24(object sender, EventArgs e)
	{
	}

	static Xr2()
	{
		m = new char[5587];
		char[] array = new char[8];
		array[3] = '\u2069';
		array[0] = '€';
		array[2] = '㦖';
		array[7] = 'Ǡ';
		array[1] = '⺈';
		array[4] = '㷮';
		array[5] = '⼂';
		array[6] = 'ნ';
		T = new string[390];
		W = array;
	}
}
