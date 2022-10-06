using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bg5s;
using Microsoft.VisualBasic.CompilerServices;
using To59;
using g8B;

namespace Xx4q;

[DesignerGenerated]
public class Cb91 : Form
{
	private w8K _ScheduleTableAdapter;

	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn1;

	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn4;

	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn6;

	internal IContainer Y;

	internal Panel u;

	internal Ck89 V;

	internal BindingSource t;

	internal n0QH r;

	internal DataGridView C;

	internal DataGridViewTextBoxColumn f;

	internal DataGridViewTextBoxColumn N;

	internal DataGridViewTextBoxColumn G;

	public Cb91()
	{
		((Form)this).add_Load((EventHandler)o8DK);
		g7A2();
	}

	protected override void k9FN(bool m5N2)
	{
		try
		{
			if (m5N2 && Y != null)
			{
				Y.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(m5N2);
		}
	}

	private void g7A2()
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
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		IContainer container = (Y = new Container());
		Te52(new Panel());
		Gy81(new DataGridView());
		Wm56(new DataGridViewTextBoxColumn());
		i1C6(new DataGridViewTextBoxColumn());
		Aq83(new DataGridViewTextBoxColumn());
		m5R1(new DataGridViewTextBoxColumn());
		Lz0w(new DataGridViewTextBoxColumn());
		g6D4(new DataGridViewTextBoxColumn());
		Ym4p(new BindingSource(Y));
		k1RN(new Ck89());
		Aj6m(new w8K());
		Sp0r(new n0QH());
		((Control)Mc0k()).SuspendLayout();
		((ISupportInitialize)r2TF()).BeginInit();
		((ISupportInitialize)d2QE()).BeginInit();
		((ISupportInitialize)Zz15()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Mc0k()).get_Controls().Add((Control)(object)r2TF());
		((Control)Mc0k()).set_Location(new Point(12, 12));
		((Control)Mc0k()).set_Name("SchedulePanel");
		((Control)Mc0k()).set_Size(new Size(649, 231));
		((Control)Mc0k()).set_TabIndex(3);
		r2TF().set_AutoGenerateColumns(false);
		r2TF().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		r2TF().get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[6]
		{
			(DataGridViewColumn)a5KQ(),
			(DataGridViewColumn)r9E5(),
			(DataGridViewColumn)e7W1(),
			(DataGridViewColumn)Yp96(),
			(DataGridViewColumn)Tx3b(),
			(DataGridViewColumn)t0D4()
		});
		r2TF().set_DataSource((object)d2QE());
		((Control)r2TF()).set_Location(new Point(3, 3));
		((Control)r2TF()).set_Name("ScheduleDataGridView");
		((Control)r2TF()).set_Size(new Size(641, 220));
		((Control)r2TF()).set_TabIndex(0);
		((DataGridViewColumn)a5KQ()).set_DataPropertyName("Student_ID");
		((DataGridViewColumn)a5KQ()).set_HeaderText("Student_ID");
		((DataGridViewColumn)a5KQ()).set_Name("DataGridViewTextBoxColumn1");
		((DataGridViewColumn)r9E5()).set_DataPropertyName("Name");
		((DataGridViewColumn)r9E5()).set_HeaderText("Name");
		((DataGridViewColumn)r9E5()).set_Name("DataGridViewTextBoxColumn2");
		((DataGridViewColumn)e7W1()).set_DataPropertyName("Email");
		((DataGridViewColumn)e7W1()).set_HeaderText("Email");
		((DataGridViewColumn)e7W1()).set_Name("DataGridViewTextBoxColumn3");
		((DataGridViewColumn)Yp96()).set_DataPropertyName("Schedule");
		((DataGridViewColumn)Yp96()).set_HeaderText("Schedule");
		((DataGridViewColumn)Yp96()).set_Name("DataGridViewTextBoxColumn4");
		((DataGridViewColumn)Tx3b()).set_DataPropertyName("Appointment");
		((DataGridViewColumn)Tx3b()).set_HeaderText("Appointment");
		((DataGridViewColumn)Tx3b()).set_Name("DataGridViewTextBoxColumn5");
		((DataGridViewColumn)t0D4()).set_DataPropertyName("Faculty_ID");
		((DataGridViewColumn)t0D4()).set_HeaderText("Faculty_ID");
		((DataGridViewColumn)t0D4()).set_Name("DataGridViewTextBoxColumn6");
		d2QE().set_DataMember("Schedule");
		d2QE().set_DataSource((object)Zz15());
		Zz15().DataSetName = "Database1DataSet";
		Zz15().SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		Cs5g().ClearBeforeFill = true;
		y9C8().BackupDataSetBeforeUpdate = false;
		y9C8().FloginTableAdapter = null;
		y9C8().HistoryTableAdapter = null;
		y9C8().PendingTableAdapter = null;
		y9C8().ScheduleTableAdapter = Cs5g();
		y9C8().SloginTableAdapter = null;
		y9C8().TableTableAdapter = null;
		y9C8().UpdateOrder = n0QH.y9Q.InsertUpdateDelete;
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(664, 245));
		((Control)this).get_Controls().Add((Control)(object)Mc0k());
		((Control)this).set_Name("Schedule");
		((Form)this).set_Text("Schedule");
		((Control)Mc0k()).ResumeLayout(false);
		((ISupportInitialize)r2TF()).EndInit();
		((ISupportInitialize)d2QE()).EndInit();
		((ISupportInitialize)Zz15()).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual Panel Mc0k()
	{
		return u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Te52(Panel w2A5)
	{
		Panel val = (u = w2A5);
	}

	[SpecialName]
	internal virtual Ck89 Zz15()
	{
		return V;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k1RN(Ck89 Ja84)
	{
		Ck89 ck = (V = Ja84);
	}

	[SpecialName]
	internal virtual BindingSource d2QE()
	{
		return t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ym4p(BindingSource q4TJ)
	{
		BindingSource val = (t = q4TJ);
	}

	[SpecialName]
	internal virtual w8K Cs5g()
	{
		return _ScheduleTableAdapter;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Aj6m(w8K Zn72)
	{
		_ScheduleTableAdapter = Zn72;
	}

	[SpecialName]
	internal virtual n0QH y9C8()
	{
		return r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sp0r(n0QH Fd87)
	{
		n0QH n0QH = (r = Fd87);
	}

	[SpecialName]
	internal virtual DataGridView r2TF()
	{
		return C;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gy81(DataGridView g5D7)
	{
		DataGridView val = (C = g5D7);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn a5KQ()
	{
		return _DataGridViewTextBoxColumn1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wm56(DataGridViewTextBoxColumn d5P1)
	{
		_DataGridViewTextBoxColumn1 = d5P1;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn r9E5()
	{
		return f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i1C6(DataGridViewTextBoxColumn Pe4r)
	{
		DataGridViewTextBoxColumn val = (f = Pe4r);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn e7W1()
	{
		return N;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Aq83(DataGridViewTextBoxColumn Db02)
	{
		DataGridViewTextBoxColumn val = (N = Db02);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Yp96()
	{
		return _DataGridViewTextBoxColumn4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m5R1(DataGridViewTextBoxColumn Gp95)
	{
		_DataGridViewTextBoxColumn4 = Gp95;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Tx3b()
	{
		return G;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lz0w(DataGridViewTextBoxColumn Jz28)
	{
		DataGridViewTextBoxColumn val = (G = Jz28);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn t0D4()
	{
		return _DataGridViewTextBoxColumn6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g6D4(DataGridViewTextBoxColumn w4SF)
	{
		_DataGridViewTextBoxColumn6 = w4SF;
	}

	private void o8DK(object sender, EventArgs e)
	{
		Cs5g().Do2q(Zz15().Schedule);
	}
}
