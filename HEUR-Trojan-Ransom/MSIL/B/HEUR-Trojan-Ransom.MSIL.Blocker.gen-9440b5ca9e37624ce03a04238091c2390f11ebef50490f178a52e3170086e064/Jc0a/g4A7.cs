using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Pw5;
using b8D;
using k0ZX;

namespace Jc0a;

[DesignerGenerated]
public class g4A7 : Form
{
	private IContainer components;

	private Dr4 _TableAdapterManager;

	private DataGridView _ScheduleDataGridView;

	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn2;

	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn3;

	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn5;

	internal Panel T;

	internal s1D b;

	internal BindingSource U;

	internal Mk2d X;

	internal DataGridViewTextBoxColumn j;

	internal DataGridViewTextBoxColumn e;

	internal DataGridViewTextBoxColumn a;

	public g4A7()
	{
		((Form)this).add_Load((EventHandler)Et34);
		x0A3();
	}

	protected override void n3J8(bool f9H7)
	{
		try
		{
			if (f9H7 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(f9H7);
		}
	}

	private void x0A3()
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
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		components = new Container();
		Dx61(new Panel());
		Nt96(new DataGridView());
		a0A9(new DataGridViewTextBoxColumn());
		Fj7p(new DataGridViewTextBoxColumn());
		f0Z5(new DataGridViewTextBoxColumn());
		x1P4(new DataGridViewTextBoxColumn());
		Po6x(new DataGridViewTextBoxColumn());
		o5PQ(new DataGridViewTextBoxColumn());
		r0C2(new BindingSource(components));
		Qs5m(new s1D());
		Yz2o(new Mk2d());
		Da06(new Dr4());
		((Control)s3XK()).SuspendLayout();
		((ISupportInitialize)i3FB()).BeginInit();
		((ISupportInitialize)y7T4()).BeginInit();
		((ISupportInitialize)Ey53()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)s3XK()).get_Controls().Add((Control)(object)i3FB());
		((Control)s3XK()).set_Location(new Point(12, 12));
		((Control)s3XK()).set_Name("SchedulePanel");
		((Control)s3XK()).set_Size(new Size(649, 231));
		((Control)s3XK()).set_TabIndex(3);
		i3FB().set_AutoGenerateColumns(false);
		i3FB().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		i3FB().get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[6]
		{
			(DataGridViewColumn)Qs19(),
			(DataGridViewColumn)t7TP(),
			(DataGridViewColumn)w9ZS(),
			(DataGridViewColumn)Yf37(),
			(DataGridViewColumn)c7ZB(),
			(DataGridViewColumn)Jn45()
		});
		i3FB().set_DataSource((object)y7T4());
		((Control)i3FB()).set_Location(new Point(3, 3));
		((Control)i3FB()).set_Name("ScheduleDataGridView");
		((Control)i3FB()).set_Size(new Size(641, 220));
		((Control)i3FB()).set_TabIndex(0);
		((DataGridViewColumn)Qs19()).set_DataPropertyName("Student_ID");
		((DataGridViewColumn)Qs19()).set_HeaderText("Student_ID");
		((DataGridViewColumn)Qs19()).set_Name("DataGridViewTextBoxColumn1");
		((DataGridViewColumn)t7TP()).set_DataPropertyName("Name");
		((DataGridViewColumn)t7TP()).set_HeaderText("Name");
		((DataGridViewColumn)t7TP()).set_Name("DataGridViewTextBoxColumn2");
		((DataGridViewColumn)w9ZS()).set_DataPropertyName("Email");
		((DataGridViewColumn)w9ZS()).set_HeaderText("Email");
		((DataGridViewColumn)w9ZS()).set_Name("DataGridViewTextBoxColumn3");
		((DataGridViewColumn)Yf37()).set_DataPropertyName("Schedule");
		((DataGridViewColumn)Yf37()).set_HeaderText("Schedule");
		((DataGridViewColumn)Yf37()).set_Name("DataGridViewTextBoxColumn4");
		((DataGridViewColumn)c7ZB()).set_DataPropertyName("Appointment");
		((DataGridViewColumn)c7ZB()).set_HeaderText("Appointment");
		((DataGridViewColumn)c7ZB()).set_Name("DataGridViewTextBoxColumn5");
		((DataGridViewColumn)Jn45()).set_DataPropertyName("Faculty_ID");
		((DataGridViewColumn)Jn45()).set_HeaderText("Faculty_ID");
		((DataGridViewColumn)Jn45()).set_Name("DataGridViewTextBoxColumn6");
		y7T4().set_DataMember("Schedule");
		y7T4().set_DataSource((object)Ey53());
		Ey53().DataSetName = "Database1DataSet";
		Ey53().SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		Fk0i().ClearBeforeFill = true;
		m8LB().BackupDataSetBeforeUpdate = false;
		m8LB().FloginTableAdapter = null;
		m8LB().HistoryTableAdapter = null;
		m8LB().PendingTableAdapter = null;
		m8LB().ScheduleTableAdapter = Fk0i();
		m8LB().SloginTableAdapter = null;
		m8LB().TableTableAdapter = null;
		m8LB().UpdateOrder = Dr4.Dx1.InsertUpdateDelete;
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(664, 245));
		((Control)this).get_Controls().Add((Control)(object)s3XK());
		((Control)this).set_Name("Schedule");
		((Form)this).set_Text("Schedule");
		((Control)s3XK()).ResumeLayout(false);
		((ISupportInitialize)i3FB()).EndInit();
		((ISupportInitialize)y7T4()).EndInit();
		((ISupportInitialize)Ey53()).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual Panel s3XK()
	{
		return T;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dx61(Panel Ap61)
	{
		Panel val = (T = Ap61);
	}

	[SpecialName]
	internal virtual s1D Ey53()
	{
		return b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qs5m(s1D Go48)
	{
		s1D s1D = (b = Go48);
	}

	[SpecialName]
	internal virtual BindingSource y7T4()
	{
		return U;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r0C2(BindingSource e2JD)
	{
		BindingSource val = (U = e2JD);
	}

	[SpecialName]
	internal virtual Mk2d Fk0i()
	{
		return X;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yz2o(Mk2d e8Y0)
	{
		Mk2d mk2d = (X = e8Y0);
	}

	[SpecialName]
	internal virtual Dr4 m8LB()
	{
		return _TableAdapterManager;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Da06(Dr4 Rf98)
	{
		_TableAdapterManager = Rf98;
	}

	[SpecialName]
	internal virtual DataGridView i3FB()
	{
		return _ScheduleDataGridView;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nt96(DataGridView c3G1)
	{
		_ScheduleDataGridView = c3G1;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Qs19()
	{
		return j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a0A9(DataGridViewTextBoxColumn Tq7r)
	{
		DataGridViewTextBoxColumn val = (j = Tq7r);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn t7TP()
	{
		return _DataGridViewTextBoxColumn2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fj7p(DataGridViewTextBoxColumn Mn69)
	{
		_DataGridViewTextBoxColumn2 = Mn69;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn w9ZS()
	{
		return _DataGridViewTextBoxColumn3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f0Z5(DataGridViewTextBoxColumn Eo51)
	{
		_DataGridViewTextBoxColumn3 = Eo51;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Yf37()
	{
		return e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x1P4(DataGridViewTextBoxColumn Tc26)
	{
		DataGridViewTextBoxColumn val = (e = Tc26);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn c7ZB()
	{
		return _DataGridViewTextBoxColumn5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Po6x(DataGridViewTextBoxColumn o5RG)
	{
		_DataGridViewTextBoxColumn5 = o5RG;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Jn45()
	{
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o5PQ(DataGridViewTextBoxColumn Yz5q)
	{
		DataGridViewTextBoxColumn val = (a = Yz5q);
	}

	private void Et34(object sender, EventArgs e)
	{
		Fk0i().Dj6i(Ey53().Schedule);
	}
}
