using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Bg5s;
using Microsoft.VisualBasic.CompilerServices;
using To59;
using Xj5;
using q4F8;

namespace Yn32;

[DesignerGenerated]
public class d1D9 : Form
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 4774)]
	private struct m1DJ
	{
	}

	private IContainer components;

	private Button _AcceptBtn;

	private BindingSource _PendingBindingSource;

	private w1E _PendingTableAdapter;

	private BindingNavigator _PendingBindingNavigator;

	private ToolStripLabel _BindingNavigatorCountItem;

	private ToolStripButton _BindingNavigatorDeleteItem;

	private ToolStripButton _BindingNavigatorMoveFirstItem;

	private ToolStripButton _BindingNavigatorMovePreviousItem;

	private ToolStripSeparator _BindingNavigatorSeparator;

	private ToolStripSeparator _BindingNavigatorSeparator1;

	private ToolStripButton _BindingNavigatorMoveLastItem;

	private ToolStripSeparator _BindingNavigatorSeparator2;

	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn2;

	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn3;

	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn4;

	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn5;

	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn6;

	private static readonly object L;

	private static readonly Array Q;

	private static readonly Array n;

	internal static byte D/* Not supported: data(00) */;

	internal Panel u;

	internal Button d;

	internal Ck89 p;

	internal n0QH v;

	internal ToolStripButton O;

	internal ToolStripTextBox E;

	internal ToolStripButton A;

	internal ToolStripButton K;

	internal DataGridView s;

	internal DataGridViewTextBoxColumn B;

	public d1D9()
	{
		((Form)this).add_Load((EventHandler)Dg8s);
		Yk8g();
	}

	protected override void x0AX(bool p8WY)
	{
		try
		{
			if (p8WY && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(p8WY);
		}
	}

	private void Yk8g()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_052e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0538: Expected O, but got Unknown
		//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e3: Expected O, but got Unknown
		//IL_0640: Unknown result type (might be due to invalid IL or missing references)
		//IL_064a: Expected O, but got Unknown
		//IL_06a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b1: Expected O, but got Unknown
		//IL_0740: Unknown result type (might be due to invalid IL or missing references)
		//IL_074a: Expected O, but got Unknown
		//IL_07ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d8: Expected O, but got Unknown
		//IL_0835: Unknown result type (might be due to invalid IL or missing references)
		//IL_083f: Expected O, but got Unknown
		//IL_08bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c9: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(d1D9));
		d3M0(new Panel());
		Nx1m(new BindingSource(components));
		Wa04(new Ck89());
		Sg2k(new Button());
		Go3e(new Button());
		Df73(new w1E());
		Qn7j(new n0QH());
		z5K1(new BindingNavigator(components));
		q9NM(new ToolStripButton());
		w4B0(new ToolStripLabel());
		n3H1(new ToolStripButton());
		Zn07(new ToolStripButton());
		y8H7(new ToolStripButton());
		n2TM(new ToolStripSeparator());
		y0J6(new ToolStripTextBox());
		m3DW(new ToolStripSeparator());
		j5T4(new ToolStripButton());
		s3PH(new ToolStripButton());
		Wt9a(new ToolStripSeparator());
		Hj0c(new ToolStripButton());
		Fp1r(new DataGridView());
		Lp7x(new DataGridViewTextBoxColumn());
		As9r(new DataGridViewTextBoxColumn());
		Mq82(new DataGridViewTextBoxColumn());
		c7Y6(new DataGridViewTextBoxColumn());
		j4PY(new DataGridViewTextBoxColumn());
		y3ZR(new DataGridViewTextBoxColumn());
		((Control)Em4f()).SuspendLayout();
		((ISupportInitialize)x6B5()).BeginInit();
		((ISupportInitialize)r6LE()).BeginInit();
		((ISupportInitialize)Kf9z()).BeginInit();
		((Control)Kf9z()).SuspendLayout();
		((ISupportInitialize)j5AY()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Em4f()).get_Controls().Add((Control)(object)j5AY());
		((Control)Em4f()).get_Controls().Add((Control)(object)Kn4m());
		((Control)Em4f()).get_Controls().Add((Control)(object)f4YC());
		((Control)Em4f()).set_Location(new Point(0, 28));
		((Control)Em4f()).set_Name("PendingPanel");
		((Control)Em4f()).set_Size(new Size(667, 278));
		((Control)Em4f()).set_TabIndex(1);
		x6B5().set_DataMember("Pending");
		x6B5().set_DataSource((object)r6LE());
		r6LE().DataSetName = "Database1DataSet";
		r6LE().SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		((Control)Kn4m()).set_Location(new Point(272, 229));
		((Control)Kn4m()).set_Name("RejectBtn");
		((Control)Kn4m()).set_Size(new Size(89, 26));
		((Control)Kn4m()).set_TabIndex(0);
		((ButtonBase)Kn4m()).set_Text("Reject");
		((ButtonBase)Kn4m()).set_UseVisualStyleBackColor(true);
		((Control)f4YC()).set_Location(new Point(167, 229));
		((Control)f4YC()).set_Name("AcceptBtn");
		((Control)f4YC()).set_Size(new Size(89, 26));
		((Control)f4YC()).set_TabIndex(0);
		((ButtonBase)f4YC()).set_Text("Accept");
		((ButtonBase)f4YC()).set_UseVisualStyleBackColor(true);
		Mt89().ClearBeforeFill = true;
		g4B3().BackupDataSetBeforeUpdate = false;
		g4B3().FloginTableAdapter = null;
		g4B3().HistoryTableAdapter = null;
		g4B3().PendingTableAdapter = Mt89();
		g4B3().ScheduleTableAdapter = null;
		g4B3().SloginTableAdapter = null;
		g4B3().TableTableAdapter = null;
		g4B3().UpdateOrder = n0QH.y9Q.InsertUpdateDelete;
		Kf9z().set_AddNewItem((ToolStripItem)(object)Rm96());
		Kf9z().set_BindingSource(x6B5());
		Kf9z().set_CountItem((ToolStripItem)(object)s7N6());
		Kf9z().set_DeleteItem((ToolStripItem)(object)k5W9());
		((ToolStrip)Kf9z()).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[12]
		{
			(ToolStripItem)x1S8(),
			(ToolStripItem)r2Z7(),
			(ToolStripItem)Ko2s(),
			(ToolStripItem)z8AL(),
			(ToolStripItem)s7N6(),
			(ToolStripItem)We98(),
			(ToolStripItem)Zo30(),
			(ToolStripItem)z8A4(),
			(ToolStripItem)Jb93(),
			(ToolStripItem)Rm96(),
			(ToolStripItem)k5W9(),
			(ToolStripItem)Ly4p()
		});
		((Control)Kf9z()).set_Location(new Point(0, 0));
		Kf9z().set_MoveFirstItem((ToolStripItem)(object)x1S8());
		Kf9z().set_MoveLastItem((ToolStripItem)(object)z8A4());
		Kf9z().set_MoveNextItem((ToolStripItem)(object)Zo30());
		Kf9z().set_MovePreviousItem((ToolStripItem)(object)r2Z7());
		((Control)Kf9z()).set_Name("PendingBindingNavigator");
		Kf9z().set_PositionItem((ToolStripItem)(object)z8AL());
		((Control)Kf9z()).set_Size(new Size(702, 25));
		((Control)Kf9z()).set_TabIndex(2);
		((Control)Kf9z()).set_Text("BindingNavigator1");
		((ToolStripItem)Rm96()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)Rm96()).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorAddNewItem.Image"));
		((ToolStripItem)Rm96()).set_Name("BindingNavigatorAddNewItem");
		((ToolStripItem)Rm96()).set_RightToLeftAutoMirrorImage(true);
		((ToolStripItem)Rm96()).set_Size(new Size(23, 22));
		((ToolStripItem)Rm96()).set_Text("Add new");
		((ToolStripItem)s7N6()).set_Name("BindingNavigatorCountItem");
		((ToolStripItem)s7N6()).set_Size(new Size(35, 22));
		((ToolStripItem)s7N6()).set_Text("of {0}");
		((ToolStripItem)s7N6()).set_ToolTipText("Total number of items");
		((ToolStripItem)k5W9()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)k5W9()).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorDeleteItem.Image"));
		((ToolStripItem)k5W9()).set_Name("BindingNavigatorDeleteItem");
		((ToolStripItem)k5W9()).set_RightToLeftAutoMirrorImage(true);
		((ToolStripItem)k5W9()).set_Size(new Size(23, 22));
		((ToolStripItem)k5W9()).set_Text("Delete");
		((ToolStripItem)x1S8()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)x1S8()).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorMoveFirstItem.Image"));
		((ToolStripItem)x1S8()).set_Name("BindingNavigatorMoveFirstItem");
		((ToolStripItem)x1S8()).set_RightToLeftAutoMirrorImage(true);
		((ToolStripItem)x1S8()).set_Size(new Size(23, 22));
		((ToolStripItem)x1S8()).set_Text("Move first");
		((ToolStripItem)r2Z7()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)r2Z7()).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorMovePreviousItem.Image"));
		((ToolStripItem)r2Z7()).set_Name("BindingNavigatorMovePreviousItem");
		((ToolStripItem)r2Z7()).set_RightToLeftAutoMirrorImage(true);
		((ToolStripItem)r2Z7()).set_Size(new Size(23, 22));
		((ToolStripItem)r2Z7()).set_Text("Move previous");
		((ToolStripItem)Ko2s()).set_Name("BindingNavigatorSeparator");
		((ToolStripItem)Ko2s()).set_Size(new Size(6, 25));
		((ToolStripItem)z8AL()).set_AccessibleName("Position");
		((ToolStripItem)z8AL()).set_AutoSize(false);
		((ToolStripControlHost)z8AL()).set_Font(new Font("Segoe UI", 9f));
		((ToolStripItem)z8AL()).set_Name("BindingNavigatorPositionItem");
		((ToolStripControlHost)z8AL()).set_Size(new Size(50, 23));
		((ToolStripControlHost)z8AL()).set_Text("0");
		((ToolStripItem)z8AL()).set_ToolTipText("Current position");
		((ToolStripItem)We98()).set_Name("BindingNavigatorSeparator1");
		((ToolStripItem)We98()).set_Size(new Size(6, 25));
		((ToolStripItem)Zo30()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)Zo30()).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorMoveNextItem.Image"));
		((ToolStripItem)Zo30()).set_Name("BindingNavigatorMoveNextItem");
		((ToolStripItem)Zo30()).set_RightToLeftAutoMirrorImage(true);
		((ToolStripItem)Zo30()).set_Size(new Size(23, 22));
		((ToolStripItem)Zo30()).set_Text("Move next");
		((ToolStripItem)z8A4()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)z8A4()).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorMoveLastItem.Image"));
		((ToolStripItem)z8A4()).set_Name("BindingNavigatorMoveLastItem");
		((ToolStripItem)z8A4()).set_RightToLeftAutoMirrorImage(true);
		((ToolStripItem)z8A4()).set_Size(new Size(23, 22));
		((ToolStripItem)z8A4()).set_Text("Move last");
		((ToolStripItem)Jb93()).set_Name("BindingNavigatorSeparator2");
		((ToolStripItem)Jb93()).set_Size(new Size(6, 25));
		((ToolStripItem)Ly4p()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)Ly4p()).set_Image((Image)componentResourceManager.GetObject("PendingBindingNavigatorSaveItem.Image"));
		((ToolStripItem)Ly4p()).set_Name("PendingBindingNavigatorSaveItem");
		((ToolStripItem)Ly4p()).set_Size(new Size(23, 22));
		((ToolStripItem)Ly4p()).set_Text("Save Data");
		j5AY().set_AutoGenerateColumns(false);
		j5AY().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		j5AY().get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[6]
		{
			(DataGridViewColumn)Dx7e(),
			(DataGridViewColumn)a9EA(),
			(DataGridViewColumn)t3G1(),
			(DataGridViewColumn)x6C2(),
			(DataGridViewColumn)Kz30(),
			(DataGridViewColumn)f0Q8()
		});
		j5AY().set_DataSource((object)x6B5());
		((Control)j5AY()).set_Location(new Point(12, 3));
		((Control)j5AY()).set_Name("PendingDataGridView");
		((Control)j5AY()).set_Size(new Size(628, 220));
		((Control)j5AY()).set_TabIndex(2);
		((DataGridViewColumn)Dx7e()).set_DataPropertyName("Student_ID");
		((DataGridViewColumn)Dx7e()).set_HeaderText("Student_ID");
		((DataGridViewColumn)Dx7e()).set_Name("DataGridViewTextBoxColumn1");
		((DataGridViewColumn)a9EA()).set_DataPropertyName("Name");
		((DataGridViewColumn)a9EA()).set_HeaderText("Name");
		((DataGridViewColumn)a9EA()).set_Name("DataGridViewTextBoxColumn2");
		((DataGridViewColumn)t3G1()).set_DataPropertyName("Email");
		((DataGridViewColumn)t3G1()).set_HeaderText("Email");
		((DataGridViewColumn)t3G1()).set_Name("DataGridViewTextBoxColumn3");
		((DataGridViewColumn)x6C2()).set_DataPropertyName("Schedule");
		((DataGridViewColumn)x6C2()).set_HeaderText("Schedule");
		((DataGridViewColumn)x6C2()).set_Name("DataGridViewTextBoxColumn4");
		((DataGridViewColumn)Kz30()).set_DataPropertyName("Appointment");
		((DataGridViewColumn)Kz30()).set_HeaderText("Appointment");
		((DataGridViewColumn)Kz30()).set_Name("DataGridViewTextBoxColumn5");
		((DataGridViewColumn)f0Q8()).set_DataPropertyName("Faculty_ID");
		((DataGridViewColumn)f0Q8()).set_HeaderText("Faculty_ID");
		((DataGridViewColumn)f0Q8()).set_Name("DataGridViewTextBoxColumn6");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(702, 306));
		((Control)this).get_Controls().Add((Control)(object)Kf9z());
		((Control)this).get_Controls().Add((Control)(object)Em4f());
		((Control)this).set_Name("Pending");
		((Form)this).set_Text("Pending");
		((Control)Em4f()).ResumeLayout(false);
		((ISupportInitialize)x6B5()).EndInit();
		((ISupportInitialize)r6LE()).EndInit();
		((ISupportInitialize)Kf9z()).EndInit();
		((Control)Kf9z()).ResumeLayout(false);
		((Control)Kf9z()).PerformLayout();
		((ISupportInitialize)j5AY()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Panel Em4f()
	{
		return u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d3M0(Panel q1MF)
	{
		Panel val = (u = q1MF);
	}

	[SpecialName]
	internal virtual Button Kn4m()
	{
		return d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sg2k(Button w5EW)
	{
		EventHandler eventHandler = Di7d;
		Button val = d;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (d = w5EW);
		val = d;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button f4YC()
	{
		return _AcceptBtn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Go3e(Button y6PG)
	{
		EventHandler eventHandler = a4P7;
		Button acceptBtn = _AcceptBtn;
		if (acceptBtn != null)
		{
			((Control)acceptBtn).remove_Click(eventHandler);
		}
		_AcceptBtn = y6PG;
		acceptBtn = _AcceptBtn;
		if (acceptBtn != null)
		{
			((Control)acceptBtn).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Ck89 r6LE()
	{
		return p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wa04(Ck89 g2GN)
	{
		Ck89 ck = (p = g2GN);
	}

	[SpecialName]
	internal virtual BindingSource x6B5()
	{
		return _PendingBindingSource;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nx1m(BindingSource x3SC)
	{
		_PendingBindingSource = x3SC;
	}

	[SpecialName]
	internal virtual w1E Mt89()
	{
		return _PendingTableAdapter;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Df73(w1E r6CD)
	{
		_PendingTableAdapter = r6CD;
	}

	[SpecialName]
	internal virtual n0QH g4B3()
	{
		return v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qn7j(n0QH x1SY)
	{
		n0QH n0QH = (v = x1SY);
	}

	[SpecialName]
	internal virtual BindingNavigator Kf9z()
	{
		return _PendingBindingNavigator;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z5K1(BindingNavigator Xn13)
	{
		_PendingBindingNavigator = Xn13;
	}

	[SpecialName]
	internal virtual ToolStripButton Rm96()
	{
		return O;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q9NM(ToolStripButton d1Q4)
	{
		ToolStripButton val = (O = d1Q4);
	}

	[SpecialName]
	internal virtual ToolStripLabel s7N6()
	{
		return _BindingNavigatorCountItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w4B0(ToolStripLabel m8HJ)
	{
		_BindingNavigatorCountItem = m8HJ;
	}

	[SpecialName]
	internal virtual ToolStripButton k5W9()
	{
		return _BindingNavigatorDeleteItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n3H1(ToolStripButton Fn1r)
	{
		_BindingNavigatorDeleteItem = Fn1r;
	}

	[SpecialName]
	internal virtual ToolStripButton x1S8()
	{
		return _BindingNavigatorMoveFirstItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zn07(ToolStripButton Jk6a)
	{
		_BindingNavigatorMoveFirstItem = Jk6a;
	}

	[SpecialName]
	internal virtual ToolStripButton r2Z7()
	{
		return _BindingNavigatorMovePreviousItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y8H7(ToolStripButton e8NA)
	{
		_BindingNavigatorMovePreviousItem = e8NA;
	}

	[SpecialName]
	internal virtual ToolStripSeparator Ko2s()
	{
		return _BindingNavigatorSeparator;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n2TM(ToolStripSeparator g0P4)
	{
		_BindingNavigatorSeparator = g0P4;
	}

	[SpecialName]
	internal virtual ToolStripTextBox z8AL()
	{
		return E;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y0J6(ToolStripTextBox b8RA)
	{
		ToolStripTextBox val = (E = b8RA);
	}

	[SpecialName]
	internal virtual ToolStripSeparator We98()
	{
		return _BindingNavigatorSeparator1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m3DW(ToolStripSeparator o2S4)
	{
		_BindingNavigatorSeparator1 = o2S4;
	}

	[SpecialName]
	internal virtual ToolStripButton Zo30()
	{
		return A;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j5T4(ToolStripButton Ts79)
	{
		ToolStripButton val = (A = Ts79);
	}

	[SpecialName]
	internal virtual ToolStripButton z8A4()
	{
		return _BindingNavigatorMoveLastItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s3PH(ToolStripButton g0L2)
	{
		_BindingNavigatorMoveLastItem = g0L2;
	}

	[SpecialName]
	internal virtual ToolStripSeparator Jb93()
	{
		return _BindingNavigatorSeparator2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wt9a(ToolStripSeparator w8W6)
	{
		_BindingNavigatorSeparator2 = w8W6;
	}

	[SpecialName]
	internal virtual ToolStripButton Ly4p()
	{
		return K;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hj0c(ToolStripButton An39)
	{
		ToolStripButton val = (K = An39);
	}

	[SpecialName]
	internal virtual DataGridView j5AY()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fp1r(DataGridView e9WF)
	{
		DataGridView val = (s = e9WF);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Dx7e()
	{
		return B;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lp7x(DataGridViewTextBoxColumn Xm37)
	{
		DataGridViewTextBoxColumn val = (B = Xm37);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn a9EA()
	{
		return _DataGridViewTextBoxColumn2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void As9r(DataGridViewTextBoxColumn i6E4)
	{
		_DataGridViewTextBoxColumn2 = i6E4;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn t3G1()
	{
		return _DataGridViewTextBoxColumn3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mq82(DataGridViewTextBoxColumn Bz8r)
	{
		_DataGridViewTextBoxColumn3 = Bz8r;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn x6C2()
	{
		return _DataGridViewTextBoxColumn4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c7Y6(DataGridViewTextBoxColumn w0LC)
	{
		_DataGridViewTextBoxColumn4 = w0LC;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Kz30()
	{
		return _DataGridViewTextBoxColumn5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j4PY(DataGridViewTextBoxColumn z2FM)
	{
		_DataGridViewTextBoxColumn5 = z2FM;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn f0Q8()
	{
		return _DataGridViewTextBoxColumn6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y3ZR(DataGridViewTextBoxColumn Ww29)
	{
		_DataGridViewTextBoxColumn6 = Ww29;
	}

	private void Dg8s(object sender, EventArgs e)
	{
		Mt89().x2B(r6LE().Pending);
	}

	internal static byte[] b2E3(int Ei20, int q7T2)
	{
		if (Ei20 <= 0)
		{
			return null;
		}
		checked
		{
			int[] array = new int[q7T2 + 1];
			for (int i = 0; i <= q7T2; i++)
			{
				int num = Ei20 * i;
				if (num > 255)
				{
					num = 255;
				}
				array[i] = num;
			}
			return Jy18(array, q7T2);
		}
	}

	private void a4P7(object sender, EventArgs e)
	{
		((Control)d7H8.Forms.t8JD()).Show();
	}

	private void Di7d(object sender, EventArgs e)
	{
		((Control)d7H8.Forms.Tb96()).Show();
	}

	internal static byte[] Jy18(int[] Xi17, int Ca67)
	{
		checked
		{
			byte[] array = new byte[Ca67 + 1];
			int num = Xi17.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = (byte)Xi17[i];
			}
			return array;
		}
	}

	static d1D9()
	{
		Q = new char[2387];
		char[] array = new char[8];
		array[0] = 'ᥠ';
		array[5] = 'ჸ';
		array[6] = 'ᛡ';
		array[3] = 'ຏ';
		array[7] = 'ዣ';
		array[2] = '㡲';
		array[1] = '☣';
		array[4] = '\u0dfc';
		n = new string[121];
		L = array;
	}
}
