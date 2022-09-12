using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace q3L6;

[DesignerGenerated]
public class q5W2 : Form
{
	private PictureBox _PictureBox1;

	private BindingSource _TblCustomersBindingSource1;

	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn1;

	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn2;

	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn4;

	internal IContainer y;

	internal BindingSource u;

	internal Label P;

	internal DataGridView O;

	internal DataGridViewTextBoxColumn k;

	public q5W2()
	{
		((Form)this).add_Load((EventHandler)c6T8);
		Ho56();
	}

	protected override void Nt82(bool e8RA)
	{
		try
		{
			if (e8RA && y != null)
			{
				y.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(e8RA);
		}
	}

	private void Ho56()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		IContainer container = (y = new Container());
		Lj7n(new BindingSource(y));
		g1A3(new Label());
		n2Z1(new PictureBox());
		g4W3(new DataGridView());
		b0B9(new DataGridViewTextBoxColumn());
		Xw0f(new DataGridViewTextBoxColumn());
		Pf51(new DataGridViewTextBoxColumn());
		p7XB(new DataGridViewTextBoxColumn());
		((ISupportInitialize)r0D9()).BeginInit();
		((ISupportInitialize)t4CS()).BeginInit();
		((ISupportInitialize)Cs8r()).BeginInit();
		((Control)this).SuspendLayout();
		r0D9().set_DataMember("tblCustomers");
		i3F4().set_AutoSize(true);
		((Control)i3F4()).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)i3F4()).set_ForeColor(SystemColors.ControlLight);
		((Control)i3F4()).set_Location(new Point(17, 15));
		((Control)i3F4()).set_Name("Label6");
		((Control)i3F4()).set_Size(new Size(216, 24));
		((Control)i3F4()).set_TabIndex(1009);
		i3F4().set_Text("Registered Customers");
		((Control)i4TQ()).set_Dock((DockStyle)1);
		((Control)i4TQ()).set_Location(new Point(0, 0));
		((Control)i4TQ()).set_Name("PictureBox1");
		((Control)i4TQ()).set_Size(new Size(266, 50));
		i4TQ().set_TabIndex(1008);
		i4TQ().set_TabStop(false);
		t4CS().set_DataMember("tblCustomers");
		Cs8r().set_AutoGenerateColumns(false);
		Cs8r().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		Cs8r().get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[4]
		{
			(DataGridViewColumn)x3HL(),
			(DataGridViewColumn)w2MQ(),
			(DataGridViewColumn)Mc35(),
			(DataGridViewColumn)An13()
		});
		Cs8r().set_DataSource((object)t4CS());
		((Control)Cs8r()).set_Location(new Point(21, 68));
		((Control)Cs8r()).set_Name("TblCustomersDataGridView");
		((Control)Cs8r()).set_Size(new Size(212, 171));
		((Control)Cs8r()).set_TabIndex(1009);
		((DataGridViewColumn)x3HL()).set_DataPropertyName("CustomerID");
		((DataGridViewColumn)x3HL()).set_HeaderText("CustomerID");
		((DataGridViewColumn)x3HL()).set_Name("DataGridViewTextBoxColumn1");
		((DataGridViewColumn)w2MQ()).set_DataPropertyName("FirstName");
		((DataGridViewColumn)w2MQ()).set_HeaderText("FirstName");
		((DataGridViewColumn)w2MQ()).set_Name("DataGridViewTextBoxColumn2");
		((DataGridViewColumn)Mc35()).set_DataPropertyName("LastName");
		((DataGridViewColumn)Mc35()).set_HeaderText("LastName");
		((DataGridViewColumn)Mc35()).set_Name("DataGridViewTextBoxColumn3");
		((DataGridViewColumn)An13()).set_DataPropertyName("Email Address");
		((DataGridViewColumn)An13()).set_HeaderText("Email Address");
		((DataGridViewColumn)An13()).set_Name("DataGridViewTextBoxColumn4");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(266, 280));
		((Control)this).get_Controls().Add((Control)(object)Cs8r());
		((Control)this).get_Controls().Add((Control)(object)i3F4());
		((Control)this).get_Controls().Add((Control)(object)i4TQ());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Customers2");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Select A Customer");
		((ISupportInitialize)r0D9()).EndInit();
		((ISupportInitialize)i4TQ()).EndInit();
		((ISupportInitialize)t4CS()).EndInit();
		((ISupportInitialize)Cs8r()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual BindingSource r0D9()
	{
		return u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lj7n(BindingSource i9YJ)
	{
		BindingSource val = (u = i9YJ);
	}

	[SpecialName]
	internal virtual Label i3F4()
	{
		return P;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g1A3(Label t0F1)
	{
		Label val = (P = t0F1);
	}

	[SpecialName]
	internal virtual PictureBox i4TQ()
	{
		return _PictureBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n2Z1(PictureBox d6K8)
	{
		_PictureBox1 = d6K8;
	}

	[SpecialName]
	internal virtual BindingSource t4CS()
	{
		return _TblCustomersBindingSource1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cd2w(BindingSource Ca02)
	{
		_TblCustomersBindingSource1 = Ca02;
	}

	[SpecialName]
	internal virtual DataGridView Cs8r()
	{
		return O;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g4W3(DataGridView p7W6)
	{
		DataGridView val = (O = p7W6);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn x3HL()
	{
		return _DataGridViewTextBoxColumn1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b0B9(DataGridViewTextBoxColumn Jf43)
	{
		_DataGridViewTextBoxColumn1 = Jf43;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn w2MQ()
	{
		return _DataGridViewTextBoxColumn2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xw0f(DataGridViewTextBoxColumn Ze23)
	{
		_DataGridViewTextBoxColumn2 = Ze23;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Mc35()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pf51(DataGridViewTextBoxColumn x5C2)
	{
		DataGridViewTextBoxColumn val = (k = x5C2);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn An13()
	{
		return _DataGridViewTextBoxColumn4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p7XB(DataGridViewTextBoxColumn Ep91)
	{
		_DataGridViewTextBoxColumn4 = Ep91;
	}

	private void c6T8(object sender, EventArgs e)
	{
	}
}
