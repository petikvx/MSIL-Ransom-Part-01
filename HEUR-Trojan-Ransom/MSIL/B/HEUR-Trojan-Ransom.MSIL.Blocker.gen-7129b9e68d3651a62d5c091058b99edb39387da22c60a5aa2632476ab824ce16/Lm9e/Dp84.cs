using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using o0N8;
using t5MS;
using x4J2;

namespace Lm9e;

[DesignerGenerated]
public class Dp84 : Form
{
	private IContainer components;

	private BindingSource _ScheduleBindingSource;

	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn3;

	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn4;

	internal Panel I;

	internal q6SX E;

	internal Qb24 f;

	internal Gw8q B;

	internal DataGridView L;

	internal DataGridViewTextBoxColumn J;

	internal DataGridViewTextBoxColumn X;

	internal DataGridViewTextBoxColumn T;

	internal DataGridViewTextBoxColumn U;

	public Dp84()
	{
		((Form)this).add_Load((EventHandler)Si79);
		Sj08();
	}

	protected override void z7H1(bool x4RJ)
	{
		try
		{
			if (x4RJ && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(x4RJ);
		}
	}

	private void Sj08()
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
		Sr7f(new Panel());
		Jo3g(new DataGridView());
		k8R6(new DataGridViewTextBoxColumn());
		Ln4y(new DataGridViewTextBoxColumn());
		p8QL(new DataGridViewTextBoxColumn());
		j1S9(new DataGridViewTextBoxColumn());
		t8XN(new DataGridViewTextBoxColumn());
		Qw34(new DataGridViewTextBoxColumn());
		Ff81(new BindingSource(components));
		Sa6m(new q6SX());
		t6C8(new Qb24());
		n4W0(new Gw8q());
		((Control)f2H0()).SuspendLayout();
		((ISupportInitialize)y2BF()).BeginInit();
		((ISupportInitialize)Pn85()).BeginInit();
		((ISupportInitialize)e5CS()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)f2H0()).get_Controls().Add((Control)(object)y2BF());
		((Control)f2H0()).set_Location(new Point(12, 12));
		((Control)f2H0()).set_Name("SchedulePanel");
		((Control)f2H0()).set_Size(new Size(649, 231));
		((Control)f2H0()).set_TabIndex(3);
		y2BF().set_AutoGenerateColumns(false);
		y2BF().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		y2BF().get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[6]
		{
			(DataGridViewColumn)y8RJ(),
			(DataGridViewColumn)Zf0g(),
			(DataGridViewColumn)En7c(),
			(DataGridViewColumn)p1R7(),
			(DataGridViewColumn)Zp7o(),
			(DataGridViewColumn)r7YN()
		});
		y2BF().set_DataSource((object)Pn85());
		((Control)y2BF()).set_Location(new Point(3, 3));
		((Control)y2BF()).set_Name("ScheduleDataGridView");
		((Control)y2BF()).set_Size(new Size(641, 220));
		((Control)y2BF()).set_TabIndex(0);
		((DataGridViewColumn)y8RJ()).set_DataPropertyName("Student_ID");
		((DataGridViewColumn)y8RJ()).set_HeaderText("Student_ID");
		((DataGridViewColumn)y8RJ()).set_Name("DataGridViewTextBoxColumn1");
		((DataGridViewColumn)Zf0g()).set_DataPropertyName("Name");
		((DataGridViewColumn)Zf0g()).set_HeaderText("Name");
		((DataGridViewColumn)Zf0g()).set_Name("DataGridViewTextBoxColumn2");
		((DataGridViewColumn)En7c()).set_DataPropertyName("Email");
		((DataGridViewColumn)En7c()).set_HeaderText("Email");
		((DataGridViewColumn)En7c()).set_Name("DataGridViewTextBoxColumn3");
		((DataGridViewColumn)p1R7()).set_DataPropertyName("Schedule");
		((DataGridViewColumn)p1R7()).set_HeaderText("Schedule");
		((DataGridViewColumn)p1R7()).set_Name("DataGridViewTextBoxColumn4");
		((DataGridViewColumn)Zp7o()).set_DataPropertyName("Appointment");
		((DataGridViewColumn)Zp7o()).set_HeaderText("Appointment");
		((DataGridViewColumn)Zp7o()).set_Name("DataGridViewTextBoxColumn5");
		((DataGridViewColumn)r7YN()).set_DataPropertyName("Faculty_ID");
		((DataGridViewColumn)r7YN()).set_HeaderText("Faculty_ID");
		((DataGridViewColumn)r7YN()).set_Name("DataGridViewTextBoxColumn6");
		Pn85().set_DataMember("Schedule");
		Pn85().set_DataSource((object)e5CS());
		e5CS().DataSetName = "Database1DataSet";
		e5CS().SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		Nm64().ClearBeforeFill = true;
		q4XD().BackupDataSetBeforeUpdate = false;
		q4XD().FloginTableAdapter = null;
		q4XD().HistoryTableAdapter = null;
		q4XD().PendingTableAdapter = null;
		q4XD().ScheduleTableAdapter = Nm64();
		q4XD().SloginTableAdapter = null;
		q4XD().TableTableAdapter = null;
		q4XD().UpdateOrder = Gw8q.w1F.InsertUpdateDelete;
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(664, 245));
		((Control)this).get_Controls().Add((Control)(object)f2H0());
		((Control)this).set_Name("Schedule");
		((Form)this).set_Text("Schedule");
		((Control)f2H0()).ResumeLayout(false);
		((ISupportInitialize)y2BF()).EndInit();
		((ISupportInitialize)Pn85()).EndInit();
		((ISupportInitialize)e5CS()).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual Panel f2H0()
	{
		return I;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sr7f(Panel o1WB)
	{
		Panel val = (I = o1WB);
	}

	[SpecialName]
	internal virtual q6SX e5CS()
	{
		return E;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sa6m(q6SX Ja9i)
	{
		q6SX q6SX = (E = Ja9i);
	}

	[SpecialName]
	internal virtual BindingSource Pn85()
	{
		return _ScheduleBindingSource;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ff81(BindingSource k8SD)
	{
		_ScheduleBindingSource = k8SD;
	}

	[SpecialName]
	internal virtual Qb24 Nm64()
	{
		return f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t6C8(Qb24 Za9b)
	{
		Qb24 qb = (f = Za9b);
	}

	[SpecialName]
	internal virtual Gw8q q4XD()
	{
		return B;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n4W0(Gw8q s0YN)
	{
		Gw8q gw8q = (B = s0YN);
	}

	[SpecialName]
	internal virtual DataGridView y2BF()
	{
		return L;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jo3g(DataGridView Wr1j)
	{
		DataGridView val = (L = Wr1j);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn y8RJ()
	{
		return J;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k8R6(DataGridViewTextBoxColumn Mg5o)
	{
		DataGridViewTextBoxColumn val = (J = Mg5o);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Zf0g()
	{
		return X;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ln4y(DataGridViewTextBoxColumn e7P0)
	{
		DataGridViewTextBoxColumn val = (X = e7P0);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn En7c()
	{
		return _DataGridViewTextBoxColumn3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p8QL(DataGridViewTextBoxColumn Mi0x)
	{
		_DataGridViewTextBoxColumn3 = Mi0x;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn p1R7()
	{
		return _DataGridViewTextBoxColumn4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j1S9(DataGridViewTextBoxColumn Jb6f)
	{
		_DataGridViewTextBoxColumn4 = Jb6f;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Zp7o()
	{
		return T;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t8XN(DataGridViewTextBoxColumn x7ET)
	{
		DataGridViewTextBoxColumn val = (T = x7ET);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn r7YN()
	{
		return U;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qw34(DataGridViewTextBoxColumn r0M6)
	{
		DataGridViewTextBoxColumn val = (U = r0M6);
	}

	private void Si79(object sender, EventArgs e)
	{
		Nm64().g5X6(e5CS().Schedule);
	}
}
