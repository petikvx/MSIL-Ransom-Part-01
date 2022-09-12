using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Tm7;

[DesignerGenerated]
public class w9Q : Form
{
	private DataGridViewTextBoxColumn _CustomerIDDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn _LastNameDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn _EmailAddressDataGridViewTextBoxColumn;

	private Label _Label6;

	internal IContainer i;

	internal DataGridView Q;

	internal BindingSource D;

	internal DataGridViewTextBoxColumn X;

	internal PictureBox S;

	public w9Q()
	{
		((Form)this).add_Load((EventHandler)s1P);
		Qs6();
	}

	protected override void a7L(bool Zt3)
	{
		try
		{
			if (Zt3 && i != null)
			{
				i.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Zt3);
		}
	}

	private void Qs6()
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
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		IContainer container = (i = new Container());
		o7M(new DataGridView());
		Qk1(new DataGridViewTextBoxColumn());
		Nf2(new DataGridViewTextBoxColumn());
		Qm8(new DataGridViewTextBoxColumn());
		b8M(new DataGridViewTextBoxColumn());
		z0Z(new BindingSource(i));
		b9P(new PictureBox());
		Hy6(new Label());
		((ISupportInitialize)Qq9()).BeginInit();
		((ISupportInitialize)Cf2()).BeginInit();
		((ISupportInitialize)Pz5()).BeginInit();
		((Control)this).SuspendLayout();
		Qq9().set_AutoGenerateColumns(false);
		Qq9().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		Qq9().get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[4]
		{
			(DataGridViewColumn)Yr9(),
			(DataGridViewColumn)m2K(),
			(DataGridViewColumn)w5B(),
			(DataGridViewColumn)j8B()
		});
		Qq9().set_DataSource((object)Cf2());
		((Control)Qq9()).set_Location(new Point(3, 54));
		((Control)Qq9()).set_Name("DataGridView1");
		((Control)Qq9()).set_Size(new Size(240, 141));
		((Control)Qq9()).set_TabIndex(0);
		((DataGridViewColumn)Yr9()).set_DataPropertyName("CustomerID");
		((DataGridViewColumn)Yr9()).set_HeaderText("CustomerID");
		((DataGridViewColumn)Yr9()).set_Name("CustomerIDDataGridViewTextBoxColumn");
		((DataGridViewColumn)m2K()).set_DataPropertyName("FirstName");
		((DataGridViewColumn)m2K()).set_HeaderText("FirstName");
		((DataGridViewColumn)m2K()).set_Name("FirstNameDataGridViewTextBoxColumn");
		((DataGridViewColumn)w5B()).set_DataPropertyName("LastName");
		((DataGridViewColumn)w5B()).set_HeaderText("LastName");
		((DataGridViewColumn)w5B()).set_Name("LastNameDataGridViewTextBoxColumn");
		((DataGridViewColumn)j8B()).set_DataPropertyName("Email Address");
		((DataGridViewColumn)j8B()).set_HeaderText("Email Address");
		((DataGridViewColumn)j8B()).set_Name("EmailAddressDataGridViewTextBoxColumn");
		Cf2().set_DataMember("tblCustomers");
		((Control)Pz5()).set_Dock((DockStyle)1);
		((Control)Pz5()).set_Location(new Point(0, 0));
		((Control)Pz5()).set_Name("PictureBox1");
		((Control)Pz5()).set_Size(new Size(248, 50));
		Pz5().set_TabIndex(1);
		Pz5().set_TabStop(false);
		Jq6().set_AutoSize(true);
		((Control)Jq6()).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Jq6()).set_ForeColor(SystemColors.ControlLight);
		((Control)Jq6()).set_Location(new Point(17, 9));
		((Control)Jq6()).set_Name("Label6");
		((Control)Jq6()).set_Size(new Size(216, 24));
		((Control)Jq6()).set_TabIndex(1006);
		Jq6().set_Text("Registered Customers");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(248, 237));
		((Control)this).get_Controls().Add((Control)(object)Jq6());
		((Control)this).get_Controls().Add((Control)(object)Pz5());
		((Control)this).get_Controls().Add((Control)(object)Qq9());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Customers1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Select A Customer");
		((ISupportInitialize)Qq9()).EndInit();
		((ISupportInitialize)Cf2()).EndInit();
		((ISupportInitialize)Pz5()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual DataGridView Qq9()
	{
		return Q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o7M(DataGridView Ty3)
	{
		DataGridView val = (Q = Ty3);
	}

	[SpecialName]
	internal virtual BindingSource Cf2()
	{
		return D;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z0Z(BindingSource Tb9)
	{
		BindingSource val = (D = Tb9);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Yr9()
	{
		return _CustomerIDDataGridViewTextBoxColumn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qk1(DataGridViewTextBoxColumn z9N)
	{
		_CustomerIDDataGridViewTextBoxColumn = z9N;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn m2K()
	{
		return X;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nf2(DataGridViewTextBoxColumn Ri3)
	{
		DataGridViewTextBoxColumn val = (X = Ri3);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn w5B()
	{
		return _LastNameDataGridViewTextBoxColumn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qm8(DataGridViewTextBoxColumn Ja0)
	{
		_LastNameDataGridViewTextBoxColumn = Ja0;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn j8B()
	{
		return _EmailAddressDataGridViewTextBoxColumn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b8M(DataGridViewTextBoxColumn p6C)
	{
		_EmailAddressDataGridViewTextBoxColumn = p6C;
	}

	[SpecialName]
	internal virtual PictureBox Pz5()
	{
		return S;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b9P(PictureBox o8Q)
	{
		PictureBox val = (S = o8Q);
	}

	[SpecialName]
	internal virtual Label Jq6()
	{
		return _Label6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hy6(Label Fm5)
	{
		_Label6 = Fm5;
	}

	private void s1P(object sender, EventArgs e)
	{
	}
}
