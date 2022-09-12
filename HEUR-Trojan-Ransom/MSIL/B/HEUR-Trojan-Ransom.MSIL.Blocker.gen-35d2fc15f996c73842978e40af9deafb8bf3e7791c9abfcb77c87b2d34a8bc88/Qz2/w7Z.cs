using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Qz2;

[DesignerGenerated]
public class w7Z : Form
{
	private PictureBox _PictureBox1;

	private BindingSource _TblCustomersBindingSource;

	private DataGridViewTextBoxColumn _EmailAddressDataGridViewTextBoxColumn;

	internal IContainer V;

	internal Label b;

	internal DataGridView J;

	internal DataGridViewTextBoxColumn r;

	internal DataGridViewTextBoxColumn y;

	internal DataGridViewTextBoxColumn W;

	public w7Z()
	{
		((Form)this).add_Load((EventHandler)e6L);
		Ge7();
	}

	protected override void s0H(bool k7L)
	{
		try
		{
			if (k7L && V != null)
			{
				V.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(k7L);
		}
	}

	private void Ge7()
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
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		IContainer container = (V = new Container());
		Xn9(new Label());
		x6T(new PictureBox());
		Ab0(new DataGridView());
		Rd3(new DataGridViewTextBoxColumn());
		Pr7(new DataGridViewTextBoxColumn());
		Ty2(new DataGridViewTextBoxColumn());
		Np6(new DataGridViewTextBoxColumn());
		z4T(new BindingSource(V));
		((ISupportInitialize)k7P()).BeginInit();
		((ISupportInitialize)z9T()).BeginInit();
		((ISupportInitialize)Rx5()).BeginInit();
		((Control)this).SuspendLayout();
		n0G().set_AutoSize(true);
		((Control)n0G()).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)n0G()).set_ForeColor(SystemColors.ControlLight);
		((Control)n0G()).set_Location(new Point(17, 13));
		((Control)n0G()).set_Name("Label6");
		((Control)n0G()).set_Size(new Size(216, 24));
		((Control)n0G()).set_TabIndex(1011);
		n0G().set_Text("Registered Customers");
		((Control)k7P()).set_Dock((DockStyle)1);
		((Control)k7P()).set_Location(new Point(0, 0));
		((Control)k7P()).set_Name("PictureBox1");
		((Control)k7P()).set_Size(new Size(266, 50));
		k7P().set_TabIndex(1010);
		k7P().set_TabStop(false);
		z9T().set_AutoGenerateColumns(false);
		z9T().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		z9T().get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[4]
		{
			(DataGridViewColumn)Lw8(),
			(DataGridViewColumn)j3E(),
			(DataGridViewColumn)k1F(),
			(DataGridViewColumn)Tc9()
		});
		z9T().set_DataSource((object)Rx5());
		((Control)z9T()).set_Location(new Point(21, 79));
		((Control)z9T()).set_Name("TblCustomersDataGridView");
		((Control)z9T()).set_Size(new Size(212, 171));
		((Control)z9T()).set_TabIndex(1012);
		((DataGridViewColumn)Lw8()).set_DataPropertyName("CustomerID");
		((DataGridViewColumn)Lw8()).set_HeaderText("CustomerID");
		((DataGridViewColumn)Lw8()).set_Name("CustomerIDDataGridViewTextBoxColumn");
		((DataGridViewColumn)j3E()).set_DataPropertyName("FirstName");
		((DataGridViewColumn)j3E()).set_HeaderText("FirstName");
		((DataGridViewColumn)j3E()).set_Name("FirstNameDataGridViewTextBoxColumn");
		((DataGridViewColumn)k1F()).set_DataPropertyName("LastName");
		((DataGridViewColumn)k1F()).set_HeaderText("LastName");
		((DataGridViewColumn)k1F()).set_Name("LastNameDataGridViewTextBoxColumn");
		((DataGridViewColumn)Tc9()).set_DataPropertyName("Email Address");
		((DataGridViewColumn)Tc9()).set_HeaderText("Email Address");
		((DataGridViewColumn)Tc9()).set_Name("EmailAddressDataGridViewTextBoxColumn");
		Rx5().set_DataMember("tblCustomers");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(266, 280));
		((Control)this).get_Controls().Add((Control)(object)n0G());
		((Control)this).get_Controls().Add((Control)(object)k7P());
		((Control)this).get_Controls().Add((Control)(object)z9T());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Customers3");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Select A Customer");
		((ISupportInitialize)k7P()).EndInit();
		((ISupportInitialize)z9T()).EndInit();
		((ISupportInitialize)Rx5()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label n0G()
	{
		return b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xn9(Label Hs5)
	{
		Label val = (b = Hs5);
	}

	[SpecialName]
	internal virtual PictureBox k7P()
	{
		return _PictureBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x6T(PictureBox p0M)
	{
		_PictureBox1 = p0M;
	}

	[SpecialName]
	internal virtual DataGridView z9T()
	{
		return J;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ab0(DataGridView e7Q)
	{
		DataGridView val = (J = e7Q);
	}

	[SpecialName]
	internal virtual BindingSource Rx5()
	{
		return _TblCustomersBindingSource;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z4T(BindingSource Ys7)
	{
		_TblCustomersBindingSource = Ys7;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Lw8()
	{
		return r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rd3(DataGridViewTextBoxColumn Dz8)
	{
		DataGridViewTextBoxColumn val = (r = Dz8);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn j3E()
	{
		return y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pr7(DataGridViewTextBoxColumn My0)
	{
		DataGridViewTextBoxColumn val = (y = My0);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn k1F()
	{
		return W;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ty2(DataGridViewTextBoxColumn St8)
	{
		DataGridViewTextBoxColumn val = (W = St8);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Tc9()
	{
		return _EmailAddressDataGridViewTextBoxColumn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Np6(DataGridViewTextBoxColumn q2H)
	{
		_EmailAddressDataGridViewTextBoxColumn = q2H;
	}

	private void e6L(object sender, EventArgs e)
	{
	}
}
