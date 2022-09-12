using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Ec0;

[DesignerGenerated]
public class g3A : Form
{
	private PictureBox _PictureBox1;

	private DataGridView _TblCustomersDataGridView;

	private DataGridViewTextBoxColumn _EmailAddressDataGridViewTextBoxColumn;

	private BindingSource _TblCustomersBindingSource1;

	internal IContainer X;

	internal Label G;

	internal DataGridViewTextBoxColumn h;

	internal DataGridViewTextBoxColumn c;

	internal DataGridViewTextBoxColumn B;

	public g3A()
	{
		((Form)this).add_Load((EventHandler)Wz8);
		Pz6();
	}

	protected override void b0D(bool y3T)
	{
		try
		{
			if (y3T && X != null)
			{
				X.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(y3T);
		}
	}

	private void Pz6()
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
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		IContainer container = (X = new Container());
		f8B(new Label());
		Hd7(new PictureBox());
		Ay2(new DataGridView());
		Tt6(new DataGridViewTextBoxColumn());
		f5R(new DataGridViewTextBoxColumn());
		d7F(new DataGridViewTextBoxColumn());
		g6S(new DataGridViewTextBoxColumn());
		((ISupportInitialize)Tk3()).BeginInit();
		((ISupportInitialize)f2E()).BeginInit();
		((ISupportInitialize)p0L()).BeginInit();
		((Control)this).SuspendLayout();
		Wk2().set_AutoSize(true);
		((Control)Wk2()).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Wk2()).set_ForeColor(SystemColors.ControlLight);
		((Control)Wk2()).set_Location(new Point(17, 16));
		((Control)Wk2()).set_Name("Label6");
		((Control)Wk2()).set_Size(new Size(216, 24));
		((Control)Wk2()).set_TabIndex(1014);
		Wk2().set_Text("Registered Customers");
		((Control)Tk3()).set_Dock((DockStyle)1);
		((Control)Tk3()).set_Location(new Point(0, 0));
		((Control)Tk3()).set_Name("PictureBox1");
		((Control)Tk3()).set_Size(new Size(266, 50));
		Tk3().set_TabIndex(1013);
		Tk3().set_TabStop(false);
		f2E().set_AutoGenerateColumns(false);
		f2E().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		f2E().get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[4]
		{
			(DataGridViewColumn)a5W(),
			(DataGridViewColumn)Yo9(),
			(DataGridViewColumn)r2F(),
			(DataGridViewColumn)s2A()
		});
		f2E().set_DataSource((object)p0L());
		((Control)f2E()).set_Location(new Point(21, 82));
		((Control)f2E()).set_Name("TblCustomersDataGridView");
		((Control)f2E()).set_Size(new Size(212, 171));
		((Control)f2E()).set_TabIndex(1015);
		((DataGridViewColumn)a5W()).set_DataPropertyName("CustomerID");
		((DataGridViewColumn)a5W()).set_HeaderText("CustomerID");
		((DataGridViewColumn)a5W()).set_Name("CustomerIDDataGridViewTextBoxColumn");
		((DataGridViewColumn)Yo9()).set_DataPropertyName("FirstName");
		((DataGridViewColumn)Yo9()).set_HeaderText("FirstName");
		((DataGridViewColumn)Yo9()).set_Name("FirstNameDataGridViewTextBoxColumn");
		((DataGridViewColumn)r2F()).set_DataPropertyName("LastName");
		((DataGridViewColumn)r2F()).set_HeaderText("LastName");
		((DataGridViewColumn)r2F()).set_Name("LastNameDataGridViewTextBoxColumn");
		((DataGridViewColumn)s2A()).set_DataPropertyName("Email Address");
		((DataGridViewColumn)s2A()).set_HeaderText("Email Address");
		((DataGridViewColumn)s2A()).set_Name("EmailAddressDataGridViewTextBoxColumn");
		p0L().set_DataMember("tblCustomers");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(266, 280));
		((Control)this).get_Controls().Add((Control)(object)Wk2());
		((Control)this).get_Controls().Add((Control)(object)Tk3());
		((Control)this).get_Controls().Add((Control)(object)f2E());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Customers4");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Select A Customer");
		((ISupportInitialize)Tk3()).EndInit();
		((ISupportInitialize)f2E()).EndInit();
		((ISupportInitialize)p0L()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label Wk2()
	{
		return G;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f8B(Label k3R)
	{
		Label val = (G = k3R);
	}

	[SpecialName]
	internal virtual PictureBox Tk3()
	{
		return _PictureBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hd7(PictureBox Zo5)
	{
		_PictureBox1 = Zo5;
	}

	[SpecialName]
	internal virtual DataGridView f2E()
	{
		return _TblCustomersDataGridView;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ay2(DataGridView Lf6)
	{
		_TblCustomersDataGridView = Lf6;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn a5W()
	{
		return h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tt6(DataGridViewTextBoxColumn Gs5)
	{
		DataGridViewTextBoxColumn val = (h = Gs5);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Yo9()
	{
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f5R(DataGridViewTextBoxColumn Qj7)
	{
		DataGridViewTextBoxColumn val = (c = Qj7);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn r2F()
	{
		return B;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d7F(DataGridViewTextBoxColumn Dd1)
	{
		DataGridViewTextBoxColumn val = (B = Dd1);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn s2A()
	{
		return _EmailAddressDataGridViewTextBoxColumn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g6S(DataGridViewTextBoxColumn m9G)
	{
		_EmailAddressDataGridViewTextBoxColumn = m9G;
	}

	[SpecialName]
	internal virtual BindingSource p0L()
	{
		return _TblCustomersBindingSource1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nr7(BindingSource Wb0)
	{
		_TblCustomersBindingSource1 = Wb0;
	}

	private void Wz8(object sender, EventArgs e)
	{
	}
}
