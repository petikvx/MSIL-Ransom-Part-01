using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace f8K3;

[DesignerGenerated]
public class Kn6q : Form
{
	private IContainer components;

	private DataGridView _DataGridView1;

	private BindingSource _TblCustomersBindingSource;

	private DataGridViewTextBoxColumn _LastNameDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn _EmailAddressDataGridViewTextBoxColumn;

	internal DataGridViewTextBoxColumn g;

	internal DataGridViewTextBoxColumn I;

	internal PictureBox R;

	internal Label S;

	public Kn6q()
	{
		((Form)this).add_Load((EventHandler)Wc6f);
		t2DL();
	}

	protected override void Jw65(bool Ci10)
	{
		try
		{
			if (Ci10 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Ci10);
		}
	}

	private void t2DL()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected O, but got Unknown
		components = new Container();
		b9ME(new DataGridView());
		Gj1w(new DataGridViewTextBoxColumn());
		Ce5a(new DataGridViewTextBoxColumn());
		e5FJ(new DataGridViewTextBoxColumn());
		Xi18(new DataGridViewTextBoxColumn());
		o5H2(new BindingSource(components));
		x7XL(new PictureBox());
		Pf37(new Label());
		((ISupportInitialize)n8YX()).BeginInit();
		((ISupportInitialize)Gk07()).BeginInit();
		((ISupportInitialize)a9D1()).BeginInit();
		((Control)this).SuspendLayout();
		n8YX().set_AutoGenerateColumns(false);
		n8YX().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		n8YX().get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[4]
		{
			(DataGridViewColumn)f9B7(),
			(DataGridViewColumn)Pm4y(),
			(DataGridViewColumn)Xj2e(),
			(DataGridViewColumn)q0NE()
		});
		n8YX().set_DataSource((object)Gk07());
		((Control)n8YX()).set_Location(new Point(3, 54));
		((Control)n8YX()).set_Name("DataGridView1");
		((Control)n8YX()).set_Size(new Size(240, 141));
		((Control)n8YX()).set_TabIndex(0);
		((DataGridViewColumn)f9B7()).set_DataPropertyName("CustomerID");
		((DataGridViewColumn)f9B7()).set_HeaderText("CustomerID");
		((DataGridViewColumn)f9B7()).set_Name("CustomerIDDataGridViewTextBoxColumn");
		((DataGridViewColumn)Pm4y()).set_DataPropertyName("FirstName");
		((DataGridViewColumn)Pm4y()).set_HeaderText("FirstName");
		((DataGridViewColumn)Pm4y()).set_Name("FirstNameDataGridViewTextBoxColumn");
		((DataGridViewColumn)Xj2e()).set_DataPropertyName("LastName");
		((DataGridViewColumn)Xj2e()).set_HeaderText("LastName");
		((DataGridViewColumn)Xj2e()).set_Name("LastNameDataGridViewTextBoxColumn");
		((DataGridViewColumn)q0NE()).set_DataPropertyName("Email Address");
		((DataGridViewColumn)q0NE()).set_HeaderText("Email Address");
		((DataGridViewColumn)q0NE()).set_Name("EmailAddressDataGridViewTextBoxColumn");
		Gk07().set_DataMember("tblCustomers");
		((Control)a9D1()).set_Dock((DockStyle)1);
		((Control)a9D1()).set_Location(new Point(0, 0));
		((Control)a9D1()).set_Name("PictureBox1");
		((Control)a9D1()).set_Size(new Size(248, 50));
		a9D1().set_TabIndex(1);
		a9D1().set_TabStop(false);
		Lf3k().set_AutoSize(true);
		((Control)Lf3k()).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Lf3k()).set_ForeColor(SystemColors.ControlLight);
		((Control)Lf3k()).set_Location(new Point(17, 9));
		((Control)Lf3k()).set_Name("Label6");
		((Control)Lf3k()).set_Size(new Size(216, 24));
		((Control)Lf3k()).set_TabIndex(1006);
		Lf3k().set_Text("Registered Customers");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(248, 237));
		((Control)this).get_Controls().Add((Control)(object)Lf3k());
		((Control)this).get_Controls().Add((Control)(object)a9D1());
		((Control)this).get_Controls().Add((Control)(object)n8YX());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Customers1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Select A Customer");
		((ISupportInitialize)n8YX()).EndInit();
		((ISupportInitialize)Gk07()).EndInit();
		((ISupportInitialize)a9D1()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual DataGridView n8YX()
	{
		return _DataGridView1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b9ME(DataGridView e4YG)
	{
		_DataGridView1 = e4YG;
	}

	[SpecialName]
	internal virtual BindingSource Gk07()
	{
		return _TblCustomersBindingSource;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o5H2(BindingSource Fi27)
	{
		_TblCustomersBindingSource = Fi27;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn f9B7()
	{
		return g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gj1w(DataGridViewTextBoxColumn o3B4)
	{
		DataGridViewTextBoxColumn val = (g = o3B4);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Pm4y()
	{
		return I;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ce5a(DataGridViewTextBoxColumn Kg6x)
	{
		DataGridViewTextBoxColumn val = (I = Kg6x);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Xj2e()
	{
		return _LastNameDataGridViewTextBoxColumn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e5FJ(DataGridViewTextBoxColumn Po02)
	{
		_LastNameDataGridViewTextBoxColumn = Po02;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn q0NE()
	{
		return _EmailAddressDataGridViewTextBoxColumn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xi18(DataGridViewTextBoxColumn Ci1n)
	{
		_EmailAddressDataGridViewTextBoxColumn = Ci1n;
	}

	[SpecialName]
	internal virtual PictureBox a9D1()
	{
		return R;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x7XL(PictureBox Tg2y)
	{
		PictureBox val = (R = Tg2y);
	}

	[SpecialName]
	internal virtual Label Lf3k()
	{
		return S;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pf37(Label Js6r)
	{
		Label val = (S = Js6r);
	}

	private void Wc6f(object sender, EventArgs e)
	{
	}
}
