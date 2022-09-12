using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Ms7;

[DesignerGenerated]
public class Lc1 : Form
{
	private PictureBox _PictureBox1;

	private DataGridView _TblCustomersDataGridView;

	private DataGridViewTextBoxColumn _CustomerIDDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn _EmailAddressDataGridViewTextBoxColumn;

	private BindingSource _TblCustomersBindingSource1;

	internal IContainer M;

	internal Label i;

	internal DataGridViewTextBoxColumn P;

	internal DataGridViewTextBoxColumn O;

	public Lc1()
	{
		((Form)this).add_Load((EventHandler)Qs2);
		p3B();
	}

	protected override void k6K(bool m0C)
	{
		try
		{
			if (m0C && M != null)
			{
				M.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(m0C);
		}
	}

	private void p3B()
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
		IContainer container = (M = new Container());
		Bd9(new Label());
		Qk3(new PictureBox());
		s6P(new DataGridView());
		Mb4(new DataGridViewTextBoxColumn());
		g1K(new DataGridViewTextBoxColumn());
		n4X(new DataGridViewTextBoxColumn());
		a8W(new DataGridViewTextBoxColumn());
		((ISupportInitialize)e6C()).BeginInit();
		((ISupportInitialize)Bm3()).BeginInit();
		((ISupportInitialize)z9Y()).BeginInit();
		((Control)this).SuspendLayout();
		x5L().set_AutoSize(true);
		((Control)x5L()).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)x5L()).set_ForeColor(SystemColors.ControlLight);
		((Control)x5L()).set_Location(new Point(17, 16));
		((Control)x5L()).set_Name("Label6");
		((Control)x5L()).set_Size(new Size(216, 24));
		((Control)x5L()).set_TabIndex(1014);
		x5L().set_Text("Registered Customers");
		((Control)e6C()).set_Dock((DockStyle)1);
		((Control)e6C()).set_Location(new Point(0, 0));
		((Control)e6C()).set_Name("PictureBox1");
		((Control)e6C()).set_Size(new Size(266, 50));
		e6C().set_TabIndex(1013);
		e6C().set_TabStop(false);
		Bm3().set_AutoGenerateColumns(false);
		Bm3().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		Bm3().get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[4]
		{
			(DataGridViewColumn)y0J(),
			(DataGridViewColumn)Ba0(),
			(DataGridViewColumn)d9R(),
			(DataGridViewColumn)Fb7()
		});
		Bm3().set_DataSource((object)z9Y());
		((Control)Bm3()).set_Location(new Point(21, 82));
		((Control)Bm3()).set_Name("TblCustomersDataGridView");
		((Control)Bm3()).set_Size(new Size(212, 171));
		((Control)Bm3()).set_TabIndex(1015);
		((DataGridViewColumn)y0J()).set_DataPropertyName("CustomerID");
		((DataGridViewColumn)y0J()).set_HeaderText("CustomerID");
		((DataGridViewColumn)y0J()).set_Name("CustomerIDDataGridViewTextBoxColumn");
		((DataGridViewColumn)Ba0()).set_DataPropertyName("FirstName");
		((DataGridViewColumn)Ba0()).set_HeaderText("FirstName");
		((DataGridViewColumn)Ba0()).set_Name("FirstNameDataGridViewTextBoxColumn");
		((DataGridViewColumn)d9R()).set_DataPropertyName("LastName");
		((DataGridViewColumn)d9R()).set_HeaderText("LastName");
		((DataGridViewColumn)d9R()).set_Name("LastNameDataGridViewTextBoxColumn");
		((DataGridViewColumn)Fb7()).set_DataPropertyName("Email Address");
		((DataGridViewColumn)Fb7()).set_HeaderText("Email Address");
		((DataGridViewColumn)Fb7()).set_Name("EmailAddressDataGridViewTextBoxColumn");
		z9Y().set_DataMember("tblCustomers");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(266, 280));
		((Control)this).get_Controls().Add((Control)(object)x5L());
		((Control)this).get_Controls().Add((Control)(object)e6C());
		((Control)this).get_Controls().Add((Control)(object)Bm3());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Customers4");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Select A Customer");
		((ISupportInitialize)e6C()).EndInit();
		((ISupportInitialize)Bm3()).EndInit();
		((ISupportInitialize)z9Y()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label x5L()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bd9(Label p0E)
	{
		Label val = (i = p0E);
	}

	[SpecialName]
	internal virtual PictureBox e6C()
	{
		return _PictureBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qk3(PictureBox t1N)
	{
		_PictureBox1 = t1N;
	}

	[SpecialName]
	internal virtual DataGridView Bm3()
	{
		return _TblCustomersDataGridView;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s6P(DataGridView Ex6)
	{
		_TblCustomersDataGridView = Ex6;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn y0J()
	{
		return _CustomerIDDataGridViewTextBoxColumn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mb4(DataGridViewTextBoxColumn Af0)
	{
		_CustomerIDDataGridViewTextBoxColumn = Af0;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Ba0()
	{
		return P;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g1K(DataGridViewTextBoxColumn s8K)
	{
		DataGridViewTextBoxColumn val = (P = s8K);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn d9R()
	{
		return O;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n4X(DataGridViewTextBoxColumn k2Z)
	{
		DataGridViewTextBoxColumn val = (O = k2Z);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Fb7()
	{
		return _EmailAddressDataGridViewTextBoxColumn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a8W(DataGridViewTextBoxColumn d8S)
	{
		_EmailAddressDataGridViewTextBoxColumn = d8S;
	}

	[SpecialName]
	internal virtual BindingSource z9Y()
	{
		return _TblCustomersBindingSource1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r7M(BindingSource k8L)
	{
		_TblCustomersBindingSource1 = k8L;
	}

	private void Qs2(object sender, EventArgs e)
	{
	}
}
