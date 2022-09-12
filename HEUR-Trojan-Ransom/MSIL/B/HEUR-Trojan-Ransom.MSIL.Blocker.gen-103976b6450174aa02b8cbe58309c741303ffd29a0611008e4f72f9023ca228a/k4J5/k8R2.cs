using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace k4J5;

[DesignerGenerated]
public class k8R2 : Form
{
	private IContainer components;

	private Label _Label6;

	private DataGridViewTextBoxColumn _LastNameDataGridViewTextBoxColumn;

	internal PictureBox s;

	internal DataGridView x;

	internal BindingSource O;

	internal DataGridViewTextBoxColumn e;

	internal DataGridViewTextBoxColumn F;

	internal DataGridViewTextBoxColumn c;

	public k8R2()
	{
		((Form)this).add_Load((EventHandler)b3Y);
		Wf9n();
	}

	protected override void b5SB(bool f1Y0)
	{
		try
		{
			if (f1Y0 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(f1Y0);
		}
	}

	private void Wf9n()
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
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		components = new Container();
		Hz83(new Label());
		Qz76(new PictureBox());
		Xk63(new DataGridView());
		Bd4(new DataGridViewTextBoxColumn());
		Zk4(new DataGridViewTextBoxColumn());
		Qa4(new DataGridViewTextBoxColumn());
		Ro6(new DataGridViewTextBoxColumn());
		c0MA(new BindingSource(components));
		((ISupportInitialize)r0A8()).BeginInit();
		((ISupportInitialize)i7ZB()).BeginInit();
		((ISupportInitialize)Qz09()).BeginInit();
		((Control)this).SuspendLayout();
		Ed2p().set_AutoSize(true);
		((Control)Ed2p()).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Ed2p()).set_ForeColor(SystemColors.ControlLight);
		((Control)Ed2p()).set_Location(new Point(17, 13));
		((Control)Ed2p()).set_Name("Label6");
		((Control)Ed2p()).set_Size(new Size(216, 24));
		((Control)Ed2p()).set_TabIndex(1011);
		Ed2p().set_Text("Registered Customers");
		((Control)r0A8()).set_Dock((DockStyle)1);
		((Control)r0A8()).set_Location(new Point(0, 0));
		((Control)r0A8()).set_Name("PictureBox1");
		((Control)r0A8()).set_Size(new Size(266, 50));
		r0A8().set_TabIndex(1010);
		r0A8().set_TabStop(false);
		i7ZB().set_AutoGenerateColumns(false);
		i7ZB().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		i7ZB().get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[4]
		{
			(DataGridViewColumn)Yn0(),
			(DataGridViewColumn)z6Y(),
			(DataGridViewColumn)Cj3(),
			(DataGridViewColumn)Mq5()
		});
		i7ZB().set_DataSource((object)Qz09());
		((Control)i7ZB()).set_Location(new Point(21, 79));
		((Control)i7ZB()).set_Name("TblCustomersDataGridView");
		((Control)i7ZB()).set_Size(new Size(212, 171));
		((Control)i7ZB()).set_TabIndex(1012);
		((DataGridViewColumn)Yn0()).set_DataPropertyName("CustomerID");
		((DataGridViewColumn)Yn0()).set_HeaderText("CustomerID");
		((DataGridViewColumn)Yn0()).set_Name("CustomerIDDataGridViewTextBoxColumn");
		((DataGridViewColumn)z6Y()).set_DataPropertyName("FirstName");
		((DataGridViewColumn)z6Y()).set_HeaderText("FirstName");
		((DataGridViewColumn)z6Y()).set_Name("FirstNameDataGridViewTextBoxColumn");
		((DataGridViewColumn)Cj3()).set_DataPropertyName("LastName");
		((DataGridViewColumn)Cj3()).set_HeaderText("LastName");
		((DataGridViewColumn)Cj3()).set_Name("LastNameDataGridViewTextBoxColumn");
		((DataGridViewColumn)Mq5()).set_DataPropertyName("Email Address");
		((DataGridViewColumn)Mq5()).set_HeaderText("Email Address");
		((DataGridViewColumn)Mq5()).set_Name("EmailAddressDataGridViewTextBoxColumn");
		Qz09().set_DataMember("tblCustomers");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(266, 280));
		((Control)this).get_Controls().Add((Control)(object)Ed2p());
		((Control)this).get_Controls().Add((Control)(object)r0A8());
		((Control)this).get_Controls().Add((Control)(object)i7ZB());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Customers3");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Select A Customer");
		((ISupportInitialize)r0A8()).EndInit();
		((ISupportInitialize)i7ZB()).EndInit();
		((ISupportInitialize)Qz09()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label Ed2p()
	{
		return _Label6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hz83(Label Tn34)
	{
		_Label6 = Tn34;
	}

	[SpecialName]
	internal virtual PictureBox r0A8()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qz76(PictureBox Qy35)
	{
		PictureBox val = (s = Qy35);
	}

	[SpecialName]
	internal virtual DataGridView i7ZB()
	{
		return x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xk63(DataGridView k8HF)
	{
		DataGridView val = (x = k8HF);
	}

	[SpecialName]
	internal virtual BindingSource Qz09()
	{
		return O;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c0MA(BindingSource Qt7)
	{
		BindingSource val = (O = Qt7);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Yn0()
	{
		return e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bd4(DataGridViewTextBoxColumn Xn8)
	{
		DataGridViewTextBoxColumn val = (e = Xn8);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn z6Y()
	{
		return F;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zk4(DataGridViewTextBoxColumn d8A)
	{
		DataGridViewTextBoxColumn val = (F = d8A);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Cj3()
	{
		return _LastNameDataGridViewTextBoxColumn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qa4(DataGridViewTextBoxColumn Ra7)
	{
		_LastNameDataGridViewTextBoxColumn = Ra7;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Mq5()
	{
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ro6(DataGridViewTextBoxColumn o0N)
	{
		DataGridViewTextBoxColumn val = (c = o0N);
	}

	private void b3Y(object sender, EventArgs e)
	{
	}
}
