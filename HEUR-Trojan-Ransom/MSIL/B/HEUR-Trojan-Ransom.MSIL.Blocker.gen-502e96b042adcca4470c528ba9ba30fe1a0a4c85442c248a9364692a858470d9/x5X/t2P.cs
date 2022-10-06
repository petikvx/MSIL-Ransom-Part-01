using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bg5s;
using Microsoft.VisualBasic.CompilerServices;
using To59;
using a6W4;
using n0AL;
using q2AL;
using w0XP;
using y4J;
using z6N;

namespace x5X;

[DesignerGenerated]
public class t2P : Form
{
	private IContainer components;

	private ToolStripLabel _BindingNavigatorCountItem;

	private ToolStripButton _BindingNavigatorMovePreviousItem;

	private ToolStripTextBox _BindingNavigatorPositionItem;

	private ToolStripSeparator _BindingNavigatorSeparator1;

	private ToolStripButton _BindingNavigatorMoveNextItem;

	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn4;

	internal static string[] Listt;

	internal static Dictionary<string, object> mDic;

	internal static string dName;

	internal static string tName;

	internal static string mName;

	internal static string mArray;

	internal static string sArray;

	internal static string T;

	internal static string sNum;

	internal Panel F;

	internal Ck89 Q;

	internal BindingSource u;

	internal Cd8 O;

	internal n0QH g;

	internal BindingNavigator V;

	internal ToolStripButton l;

	internal ToolStripButton h;

	internal ToolStripButton E;

	internal ToolStripSeparator w;

	internal ToolStripButton y;

	internal ToolStripSeparator x;

	internal ToolStripButton N;

	internal DataGridView c;

	internal DataGridViewTextBoxColumn t;

	internal DataGridViewTextBoxColumn a;

	internal DataGridViewTextBoxColumn p;

	internal DataGridViewTextBoxColumn s;

	public t2P()
	{
		((Form)this).add_Load((EventHandler)Lp8);
		p3R();
	}

	protected override void a3W(bool Rs9)
	{
		try
		{
			if (Rs9 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Rs9);
		}
	}

	private void p3R()
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(t2P));
		z7R(new Panel());
		Lp0(new DataGridView());
		b3T(new DataGridViewTextBoxColumn());
		Jn7(new DataGridViewTextBoxColumn());
		z1E(new DataGridViewTextBoxColumn());
		Eq9(new DataGridViewTextBoxColumn());
		f2A(new DataGridViewTextBoxColumn());
		t6S(new BindingSource(components));
		p6H(new Ck89());
		j7Z(new Cd8());
		Nd3(new n0QH());
		Lr9(new BindingNavigator(components));
		Mr4(new ToolStripButton());
		Ki7(new ToolStripLabel());
		q8E(new ToolStripButton());
		Fm2(new ToolStripButton());
		Zf0(new ToolStripButton());
		Fi8(new ToolStripSeparator());
		Sm1(new ToolStripTextBox());
		o6M(new ToolStripSeparator());
		b8S(new ToolStripButton());
		f3B(new ToolStripButton());
		Fy2(new ToolStripSeparator());
		z0D(new ToolStripButton());
		((Control)Ct0()).SuspendLayout();
		((ISupportInitialize)Re2()).BeginInit();
		((ISupportInitialize)o1D()).BeginInit();
		((ISupportInitialize)Kt0()).BeginInit();
		((ISupportInitialize)w5Y()).BeginInit();
		((Control)w5Y()).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)Ct0()).get_Controls().Add((Control)(object)Re2());
		((Control)Ct0()).set_Location(new Point(12, 41));
		((Control)Ct0()).set_Name("Panel1");
		((Control)Ct0()).set_Size(new Size(545, 226));
		((Control)Ct0()).set_TabIndex(0);
		Re2().set_AutoGenerateColumns(false);
		Re2().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		Re2().get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[5]
		{
			(DataGridViewColumn)Li1(),
			(DataGridViewColumn)s8E(),
			(DataGridViewColumn)k3A(),
			(DataGridViewColumn)this.Lo5(),
			(DataGridViewColumn)x7J()
		});
		Re2().set_DataSource((object)o1D());
		((Control)Re2()).set_Location(new Point(0, 3));
		((Control)Re2()).set_Name("HistoryDataGridView");
		((Control)Re2()).set_Size(new Size(542, 220));
		((Control)Re2()).set_TabIndex(0);
		((DataGridViewColumn)Li1()).set_DataPropertyName("Email");
		((DataGridViewColumn)Li1()).set_HeaderText("Email");
		((DataGridViewColumn)Li1()).set_Name("DataGridViewTextBoxColumn1");
		((DataGridViewColumn)s8E()).set_DataPropertyName("Faculty");
		((DataGridViewColumn)s8E()).set_HeaderText("Faculty");
		((DataGridViewColumn)s8E()).set_Name("DataGridViewTextBoxColumn2");
		((DataGridViewColumn)k3A()).set_DataPropertyName("Schedule");
		((DataGridViewColumn)k3A()).set_HeaderText("Schedule");
		((DataGridViewColumn)k3A()).set_Name("DataGridViewTextBoxColumn3");
		((DataGridViewColumn)this.Lo5()).set_DataPropertyName("Appointment");
		((DataGridViewColumn)this.Lo5()).set_HeaderText("Appointment");
		((DataGridViewColumn)this.Lo5()).set_Name("DataGridViewTextBoxColumn4");
		((DataGridViewColumn)x7J()).set_DataPropertyName("Request");
		((DataGridViewColumn)x7J()).set_HeaderText("Request");
		((DataGridViewColumn)x7J()).set_Name("DataGridViewTextBoxColumn5");
		o1D().set_DataMember("History");
		o1D().set_DataSource((object)Kt0());
		Kt0().DataSetName = "Database1DataSet";
		Kt0().SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		Qa5().ClearBeforeFill = true;
		d3Y().BackupDataSetBeforeUpdate = false;
		d3Y().FloginTableAdapter = null;
		d3Y().HistoryTableAdapter = Qa5();
		d3Y().PendingTableAdapter = null;
		d3Y().ScheduleTableAdapter = null;
		d3Y().SloginTableAdapter = null;
		d3Y().UpdateOrder = n0QH.y9Q.InsertUpdateDelete;
		w5Y().set_AddNewItem((ToolStripItem)(object)this.Lo5());
		w5Y().set_BindingSource(o1D());
		w5Y().set_CountItem((ToolStripItem)(object)e2P());
		w5Y().set_DeleteItem((ToolStripItem)(object)Ns6());
		((ToolStrip)w5Y()).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[12]
		{
			(ToolStripItem)c5N(),
			(ToolStripItem)x4R(),
			(ToolStripItem)w4K(),
			(ToolStripItem)Xt1(),
			(ToolStripItem)e2P(),
			(ToolStripItem)Bz8(),
			(ToolStripItem)Kr5(),
			(ToolStripItem)Hf3(),
			(ToolStripItem)b6H(),
			(ToolStripItem)this.Lo5(),
			(ToolStripItem)Ns6(),
			(ToolStripItem)i8T()
		});
		((Control)w5Y()).set_Location(new Point(0, 0));
		w5Y().set_MoveFirstItem((ToolStripItem)(object)c5N());
		w5Y().set_MoveLastItem((ToolStripItem)(object)Hf3());
		w5Y().set_MoveNextItem((ToolStripItem)(object)Kr5());
		w5Y().set_MovePreviousItem((ToolStripItem)(object)x4R());
		((Control)w5Y()).set_Name("HistoryBindingNavigator");
		w5Y().set_PositionItem((ToolStripItem)(object)Xt1());
		((Control)w5Y()).set_Size(new Size(565, 25));
		((Control)w5Y()).set_TabIndex(1);
		((Control)w5Y()).set_Text("BindingNavigator1");
		((ToolStripItem)this.Lo5()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)this.Lo5()).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorAddNewItem.Image"));
		((ToolStripItem)this.Lo5()).set_Name("BindingNavigatorAddNewItem");
		((ToolStripItem)this.Lo5()).set_RightToLeftAutoMirrorImage(true);
		((ToolStripItem)this.Lo5()).set_Size(new Size(23, 22));
		((ToolStripItem)this.Lo5()).set_Text("Add new");
		((ToolStripItem)e2P()).set_Name("BindingNavigatorCountItem");
		((ToolStripItem)e2P()).set_Size(new Size(35, 22));
		((ToolStripItem)e2P()).set_Text("of {0}");
		((ToolStripItem)e2P()).set_ToolTipText("Total number of items");
		((ToolStripItem)Ns6()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)Ns6()).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorDeleteItem.Image"));
		((ToolStripItem)Ns6()).set_Name("BindingNavigatorDeleteItem");
		((ToolStripItem)Ns6()).set_RightToLeftAutoMirrorImage(true);
		((ToolStripItem)Ns6()).set_Size(new Size(23, 22));
		((ToolStripItem)Ns6()).set_Text("Delete");
		((ToolStripItem)c5N()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)c5N()).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorMoveFirstItem.Image"));
		((ToolStripItem)c5N()).set_Name("BindingNavigatorMoveFirstItem");
		((ToolStripItem)c5N()).set_RightToLeftAutoMirrorImage(true);
		((ToolStripItem)c5N()).set_Size(new Size(23, 22));
		((ToolStripItem)c5N()).set_Text("Move first");
		((ToolStripItem)x4R()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)x4R()).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorMovePreviousItem.Image"));
		((ToolStripItem)x4R()).set_Name("BindingNavigatorMovePreviousItem");
		((ToolStripItem)x4R()).set_RightToLeftAutoMirrorImage(true);
		((ToolStripItem)x4R()).set_Size(new Size(23, 22));
		((ToolStripItem)x4R()).set_Text("Move previous");
		((ToolStripItem)w4K()).set_Name("BindingNavigatorSeparator");
		((ToolStripItem)w4K()).set_Size(new Size(6, 25));
		((ToolStripItem)Xt1()).set_AccessibleName("Position");
		((ToolStripItem)Xt1()).set_AutoSize(false);
		((ToolStripControlHost)Xt1()).set_Font(new Font("Segoe UI", 9f));
		((ToolStripItem)Xt1()).set_Name("BindingNavigatorPositionItem");
		((ToolStripControlHost)Xt1()).set_Size(new Size(50, 23));
		((ToolStripControlHost)Xt1()).set_Text("0");
		((ToolStripItem)Xt1()).set_ToolTipText("Current position");
		((ToolStripItem)Bz8()).set_Name("BindingNavigatorSeparator1");
		((ToolStripItem)Bz8()).set_Size(new Size(6, 25));
		((ToolStripItem)Kr5()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)Kr5()).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorMoveNextItem.Image"));
		((ToolStripItem)Kr5()).set_Name("BindingNavigatorMoveNextItem");
		((ToolStripItem)Kr5()).set_RightToLeftAutoMirrorImage(true);
		((ToolStripItem)Kr5()).set_Size(new Size(23, 22));
		((ToolStripItem)Kr5()).set_Text("Move next");
		((ToolStripItem)Hf3()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)Hf3()).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorMoveLastItem.Image"));
		((ToolStripItem)Hf3()).set_Name("BindingNavigatorMoveLastItem");
		((ToolStripItem)Hf3()).set_RightToLeftAutoMirrorImage(true);
		((ToolStripItem)Hf3()).set_Size(new Size(23, 22));
		((ToolStripItem)Hf3()).set_Text("Move last");
		((ToolStripItem)b6H()).set_Name("BindingNavigatorSeparator2");
		((ToolStripItem)b6H()).set_Size(new Size(6, 25));
		((ToolStripItem)i8T()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)i8T()).set_Image((Image)componentResourceManager.GetObject("HistoryBindingNavigatorSaveItem.Image"));
		((ToolStripItem)i8T()).set_Name("HistoryBindingNavigatorSaveItem");
		((ToolStripItem)i8T()).set_Size(new Size(23, 22));
		((ToolStripItem)i8T()).set_Text("Save Data");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(565, 281));
		((Control)this).get_Controls().Add((Control)(object)w5Y());
		((Control)this).get_Controls().Add((Control)(object)Ct0());
		((Control)this).set_Name("History");
		((Form)this).set_Text("History");
		((Control)Ct0()).ResumeLayout(false);
		((ISupportInitialize)Re2()).EndInit();
		((ISupportInitialize)o1D()).EndInit();
		((ISupportInitialize)Kt0()).EndInit();
		((ISupportInitialize)w5Y()).EndInit();
		((Control)w5Y()).ResumeLayout(false);
		((Control)w5Y()).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Panel Ct0()
	{
		return F;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z7R(Panel Ms5)
	{
		Panel val = (F = Ms5);
	}

	[SpecialName]
	internal virtual Ck89 Kt0()
	{
		return Q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p6H(Ck89 Pa9)
	{
		Ck89 ck = (Q = Pa9);
	}

	[SpecialName]
	internal virtual BindingSource o1D()
	{
		return u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t6S(BindingSource j3T)
	{
		BindingSource val = (u = j3T);
	}

	[SpecialName]
	internal virtual Cd8 Qa5()
	{
		return O;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j7Z(Cd8 Lt6)
	{
		Cd8 cd = (O = Lt6);
	}

	[SpecialName]
	internal virtual n0QH d3Y()
	{
		return g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nd3(n0QH a6Q)
	{
		n0QH n0QH = (g = a6Q);
	}

	[SpecialName]
	internal virtual BindingNavigator w5Y()
	{
		return V;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lr9(BindingNavigator Km7)
	{
		BindingNavigator val = (V = Km7);
	}

	[SpecialName]
	internal virtual ToolStripButton Lo5()
	{
		return l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mr4(ToolStripButton Se4)
	{
		ToolStripButton val = (l = Se4);
	}

	[SpecialName]
	internal virtual ToolStripLabel e2P()
	{
		return _BindingNavigatorCountItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ki7(ToolStripLabel Xk8)
	{
		_BindingNavigatorCountItem = Xk8;
	}

	[SpecialName]
	internal virtual ToolStripButton Ns6()
	{
		return h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q8E(ToolStripButton o4C)
	{
		ToolStripButton val = (h = o4C);
	}

	[SpecialName]
	internal virtual ToolStripButton c5N()
	{
		return E;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fm2(ToolStripButton k4M)
	{
		ToolStripButton val = (E = k4M);
	}

	[SpecialName]
	internal virtual ToolStripButton x4R()
	{
		return _BindingNavigatorMovePreviousItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zf0(ToolStripButton x3B)
	{
		_BindingNavigatorMovePreviousItem = x3B;
	}

	[SpecialName]
	internal virtual ToolStripSeparator w4K()
	{
		return w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fi8(ToolStripSeparator j0B)
	{
		ToolStripSeparator val = (w = j0B);
	}

	[SpecialName]
	internal virtual ToolStripTextBox Xt1()
	{
		return _BindingNavigatorPositionItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sm1(ToolStripTextBox b2S)
	{
		_BindingNavigatorPositionItem = b2S;
	}

	[SpecialName]
	internal virtual ToolStripSeparator Bz8()
	{
		return _BindingNavigatorSeparator1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o6M(ToolStripSeparator As4)
	{
		_BindingNavigatorSeparator1 = As4;
	}

	[SpecialName]
	internal virtual ToolStripButton Kr5()
	{
		return _BindingNavigatorMoveNextItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b8S(ToolStripButton Wk8)
	{
		_BindingNavigatorMoveNextItem = Wk8;
	}

	[SpecialName]
	internal virtual ToolStripButton Hf3()
	{
		return y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f3B(ToolStripButton z5F)
	{
		ToolStripButton val = (y = z5F);
	}

	[SpecialName]
	internal virtual ToolStripSeparator b6H()
	{
		return x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fy2(ToolStripSeparator c0J)
	{
		ToolStripSeparator val = (x = c0J);
	}

	[SpecialName]
	internal virtual ToolStripButton i8T()
	{
		return N;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z0D(ToolStripButton Kd2)
	{
		ToolStripButton val = (N = Kd2);
	}

	[SpecialName]
	internal virtual DataGridView Re2()
	{
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lp0(DataGridView p6Z)
	{
		DataGridView val = (c = p6Z);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Li1()
	{
		return t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b3T(DataGridViewTextBoxColumn Ks8)
	{
		DataGridViewTextBoxColumn val = (t = Ks8);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn s8E()
	{
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jn7(DataGridViewTextBoxColumn Cm0)
	{
		DataGridViewTextBoxColumn val = (a = Cm0);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn k3A()
	{
		return p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z1E(DataGridViewTextBoxColumn a3W)
	{
		DataGridViewTextBoxColumn val = (p = a3W);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Lo5()
	{
		return _DataGridViewTextBoxColumn4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Eq9(DataGridViewTextBoxColumn Hx0)
	{
		_DataGridViewTextBoxColumn4 = Hx0;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn x7J()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f2A(DataGridViewTextBoxColumn n8T)
	{
		DataGridViewTextBoxColumn val = (s = n8T);
	}

	private void Lp8(object sender, EventArgs e)
	{
		Qa5().Ld2(Kt0().History);
	}

	internal static void f7Z(int Dq8)
	{
		mDic = new Dictionary<string, object>();
		Listt = new string[11]
		{
			"asat", "dfg", "ygyuou", "et", "yuo", "sg", "jhjl", "xc", "jk", "qwe",
			"jkoyys"
		};
		dName = b0D.Si1(Listt, 0, 1);
		mDic.Add(dName, Listt);
		tName = b0D.Si1(Listt, Dq8, 1);
		checked
		{
			mName = b0D.Si1(Listt, Dq8 + 1, 2);
			mArray = b0D.Si1(Listt, Dq8 + 2, 3);
			sArray = b0D.Si1(Listt, Dq8 + 3, 4);
			T = b0D.Si1(Listt, Dq8 + 4, 5);
			sNum = b0D.Si1(Listt, Dq8 + 5, 6);
			if ((double)Dq8 != 2503.0)
			{
				Dq8 = 51;
				mDic.Add(sNum, 51);
			}
			byte[] value = Fe1r.b5KX(Dq8);
			mDic.Add(sArray, value);
			s9R8.Lf3k();
		}
	}

	internal static byte[] q0B(int Dc1)
	{
		string[] array = new string[2] { "mkolk", "putin" };
		if (array == null)
		{
			return null;
		}
		return Td41.d0P4(Aw27.Ke4(), Dc1);
	}
}
