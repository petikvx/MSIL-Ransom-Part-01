using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace p1RC;

[DesignerGenerated]
public class x2LT : Form
{
	private PictureBox _PictureBox1;

	private DataGridView _DataGridView1;

	private DataGridViewTextBoxColumn _BookingIDDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn _CustomerDataGridViewTextBoxColumn;

	internal IContainer g;

	internal Label L;

	internal BindingSource w;

	internal DataGridViewTextBoxColumn f;

	public x2LT()
	{
		((Form)this).add_Load((EventHandler)y8XH);
		Bq96();
	}

	protected override void q2Q4(bool j2XW)
	{
		try
		{
			if (j2XW && g != null)
			{
				g.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(j2XW);
		}
	}

	private void Bq96()
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
		IContainer container = (g = new Container());
		g0M5(new Label());
		Eb13(new PictureBox());
		We94(new DataGridView());
		Qn3t(new DataGridViewTextBoxColumn());
		Jo8m(new DataGridViewTextBoxColumn());
		Pa12(new DataGridViewTextBoxColumn());
		Hn6k(new BindingSource(g));
		((ISupportInitialize)Eo5i()).BeginInit();
		((ISupportInitialize)g5B4()).BeginInit();
		((ISupportInitialize)p2GT()).BeginInit();
		((Control)this).SuspendLayout();
		k6L3().set_AutoSize(true);
		((Control)k6L3()).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)k6L3()).set_ForeColor(SystemColors.ControlLight);
		((Control)k6L3()).set_Location(new Point(34, 20));
		((Control)k6L3()).set_Name("Label6");
		((Control)k6L3()).set_Size(new Size(156, 24));
		((Control)k6L3()).set_TabIndex(1015);
		k6L3().set_Text("Reserved Seats");
		((Control)Eo5i()).set_Dock((DockStyle)1);
		((Control)Eo5i()).set_Location(new Point(0, 0));
		((Control)Eo5i()).set_Name("PictureBox1");
		((Control)Eo5i()).set_Size(new Size(248, 50));
		Eo5i().set_TabIndex(1014);
		Eo5i().set_TabStop(false);
		g5B4().set_AutoGenerateColumns(false);
		g5B4().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		g5B4().get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[3]
		{
			(DataGridViewColumn)Qy78(),
			(DataGridViewColumn)n7Y1(),
			(DataGridViewColumn)Lo3y()
		});
		g5B4().set_DataSource((object)p2GT());
		((Control)g5B4()).set_Location(new Point(16, 68));
		((Control)g5B4()).set_Name("DataGridView1");
		((Control)g5B4()).set_Size(new Size(216, 150));
		((Control)g5B4()).set_TabIndex(1016);
		((DataGridViewColumn)Qy78()).set_DataPropertyName("BookingID");
		((DataGridViewColumn)Qy78()).set_HeaderText("BookingID");
		((DataGridViewColumn)Qy78()).set_Name("BookingIDDataGridViewTextBoxColumn");
		((DataGridViewColumn)n7Y1()).set_DataPropertyName("Customer");
		((DataGridViewColumn)n7Y1()).set_HeaderText("Customer");
		((DataGridViewColumn)n7Y1()).set_Name("CustomerDataGridViewTextBoxColumn");
		((DataGridViewColumn)Lo3y()).set_DataPropertyName("Seat");
		((DataGridViewColumn)Lo3y()).set_HeaderText("Seat");
		((DataGridViewColumn)Lo3y()).set_Name("SeatDataGridViewTextBoxColumn");
		p2GT().set_DataMember("tblBookings");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(248, 237));
		((Control)this).get_Controls().Add((Control)(object)g5B4());
		((Control)this).get_Controls().Add((Control)(object)k6L3());
		((Control)this).get_Controls().Add((Control)(object)Eo5i());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("ReservedSeats4");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("ReservedSeats");
		((ISupportInitialize)Eo5i()).EndInit();
		((ISupportInitialize)g5B4()).EndInit();
		((ISupportInitialize)p2GT()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label k6L3()
	{
		return L;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g0M5(Label Lb54)
	{
		Label val = (L = Lb54);
	}

	[SpecialName]
	internal virtual PictureBox Eo5i()
	{
		return _PictureBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Eb13(PictureBox s3S7)
	{
		_PictureBox1 = s3S7;
	}

	[SpecialName]
	internal virtual DataGridView g5B4()
	{
		return _DataGridView1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void We94(DataGridView Qb2m)
	{
		_DataGridView1 = Qb2m;
	}

	[SpecialName]
	internal virtual BindingSource p2GT()
	{
		return w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hn6k(BindingSource Hn75)
	{
		BindingSource val = (w = Hn75);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Qy78()
	{
		return _BookingIDDataGridViewTextBoxColumn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qn3t(DataGridViewTextBoxColumn o8J7)
	{
		_BookingIDDataGridViewTextBoxColumn = o8J7;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn n7Y1()
	{
		return _CustomerDataGridViewTextBoxColumn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jo8m(DataGridViewTextBoxColumn j0NT)
	{
		_CustomerDataGridViewTextBoxColumn = j0NT;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Lo3y()
	{
		return f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pa12(DataGridViewTextBoxColumn i3R9)
	{
		DataGridViewTextBoxColumn val = (f = i3R9);
	}

	private void y8XH(object sender, EventArgs e)
	{
	}
}
