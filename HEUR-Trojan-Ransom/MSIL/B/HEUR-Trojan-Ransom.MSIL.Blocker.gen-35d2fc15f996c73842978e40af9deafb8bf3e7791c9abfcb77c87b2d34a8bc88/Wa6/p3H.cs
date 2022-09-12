using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Wa6;

[DesignerGenerated]
public class p3H : Form
{
	private IContainer components;

	private BindingSource _TblCustomersBindingSource1;

	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn4;

	internal BindingSource d;

	internal Label w;

	internal PictureBox m;

	internal DataGridView n;

	internal DataGridViewTextBoxColumn x;

	internal DataGridViewTextBoxColumn H;

	internal DataGridViewTextBoxColumn K;

	public p3H()
	{
		((Form)this).add_Load((EventHandler)Ab9);
		n4G();
	}

	protected override void n0S(bool a7Y)
	{
		try
		{
			if (a7Y && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(a7Y);
		}
	}

	private void n4G()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		components = new Container();
		Jj5(new BindingSource(components));
		q0N(new Label());
		t3N(new PictureBox());
		Gq0(new DataGridView());
		Eb5(new DataGridViewTextBoxColumn());
		a1N(new DataGridViewTextBoxColumn());
		z1K(new DataGridViewTextBoxColumn());
		Pq2(new DataGridViewTextBoxColumn());
		((ISupportInitialize)k1T()).BeginInit();
		((ISupportInitialize)y2A()).BeginInit();
		((ISupportInitialize)q8X()).BeginInit();
		((Control)this).SuspendLayout();
		k1T().set_DataMember("tblCustomers");
		b7S().set_AutoSize(true);
		((Control)b7S()).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)b7S()).set_ForeColor(SystemColors.ControlLight);
		((Control)b7S()).set_Location(new Point(17, 15));
		((Control)b7S()).set_Name("Label6");
		((Control)b7S()).set_Size(new Size(216, 24));
		((Control)b7S()).set_TabIndex(1009);
		b7S().set_Text("Registered Customers");
		((Control)n6B()).set_Dock((DockStyle)1);
		((Control)n6B()).set_Location(new Point(0, 0));
		((Control)n6B()).set_Name("PictureBox1");
		((Control)n6B()).set_Size(new Size(266, 50));
		n6B().set_TabIndex(1008);
		n6B().set_TabStop(false);
		y2A().set_DataMember("tblCustomers");
		q8X().set_AutoGenerateColumns(false);
		q8X().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		q8X().get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[4]
		{
			(DataGridViewColumn)w5B(),
			(DataGridViewColumn)a8W(),
			(DataGridViewColumn)k6Y(),
			(DataGridViewColumn)Pd0()
		});
		q8X().set_DataSource((object)y2A());
		((Control)q8X()).set_Location(new Point(21, 68));
		((Control)q8X()).set_Name("TblCustomersDataGridView");
		((Control)q8X()).set_Size(new Size(212, 171));
		((Control)q8X()).set_TabIndex(1009);
		((DataGridViewColumn)w5B()).set_DataPropertyName("CustomerID");
		((DataGridViewColumn)w5B()).set_HeaderText("CustomerID");
		((DataGridViewColumn)w5B()).set_Name("DataGridViewTextBoxColumn1");
		((DataGridViewColumn)a8W()).set_DataPropertyName("FirstName");
		((DataGridViewColumn)a8W()).set_HeaderText("FirstName");
		((DataGridViewColumn)a8W()).set_Name("DataGridViewTextBoxColumn2");
		((DataGridViewColumn)k6Y()).set_DataPropertyName("LastName");
		((DataGridViewColumn)k6Y()).set_HeaderText("LastName");
		((DataGridViewColumn)k6Y()).set_Name("DataGridViewTextBoxColumn3");
		((DataGridViewColumn)Pd0()).set_DataPropertyName("Email Address");
		((DataGridViewColumn)Pd0()).set_HeaderText("Email Address");
		((DataGridViewColumn)Pd0()).set_Name("DataGridViewTextBoxColumn4");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(266, 280));
		((Control)this).get_Controls().Add((Control)(object)q8X());
		((Control)this).get_Controls().Add((Control)(object)b7S());
		((Control)this).get_Controls().Add((Control)(object)n6B());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Customers2");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Select A Customer");
		((ISupportInitialize)k1T()).EndInit();
		((ISupportInitialize)n6B()).EndInit();
		((ISupportInitialize)y2A()).EndInit();
		((ISupportInitialize)q8X()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual BindingSource k1T()
	{
		return d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jj5(BindingSource Rd0)
	{
		BindingSource val = (d = Rd0);
	}

	[SpecialName]
	internal virtual Label b7S()
	{
		return w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q0N(Label Pf1)
	{
		Label val = (w = Pf1);
	}

	[SpecialName]
	internal virtual PictureBox n6B()
	{
		return m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t3N(PictureBox Fk8)
	{
		PictureBox val = (m = Fk8);
	}

	[SpecialName]
	internal virtual BindingSource y2A()
	{
		return _TblCustomersBindingSource1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b0E(BindingSource Tr4)
	{
		_TblCustomersBindingSource1 = Tr4;
	}

	[SpecialName]
	internal virtual DataGridView q8X()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gq0(DataGridView t8G)
	{
		DataGridView val = (n = t8G);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn w5B()
	{
		return x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Eb5(DataGridViewTextBoxColumn f4Z)
	{
		DataGridViewTextBoxColumn val = (x = f4Z);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn a8W()
	{
		return H;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a1N(DataGridViewTextBoxColumn Qb3)
	{
		DataGridViewTextBoxColumn val = (H = Qb3);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn k6Y()
	{
		return K;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z1K(DataGridViewTextBoxColumn Gg9)
	{
		DataGridViewTextBoxColumn val = (K = Gg9);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Pd0()
	{
		return _DataGridViewTextBoxColumn4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pq2(DataGridViewTextBoxColumn b8M)
	{
		_DataGridViewTextBoxColumn4 = b8M;
	}

	private void Ab9(object sender, EventArgs e)
	{
	}
}
