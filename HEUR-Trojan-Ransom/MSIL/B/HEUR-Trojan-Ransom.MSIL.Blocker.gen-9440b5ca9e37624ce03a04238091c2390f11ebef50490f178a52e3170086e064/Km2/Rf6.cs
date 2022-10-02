using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Pw5;
using Tx27;
using Zi72;
using b3NB;
using b8D;
using d5N;
using f7R9;
using j7P;

namespace Km2;

[DesignerGenerated]
public class Rf6 : Form
{
	private s1D _Database1DataSet;

	private Yq4 _HistoryTableAdapter;

	private Dr4 _TableAdapterManager;

	private ToolStripButton _BindingNavigatorAddNewItem;

	private ToolStripButton _BindingNavigatorDeleteItem;

	private ToolStripButton _BindingNavigatorMoveFirstItem;

	private ToolStripTextBox _BindingNavigatorPositionItem;

	private ToolStripButton _HistoryBindingNavigatorSaveItem;

	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn1;

	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn2;

	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn3;

	internal static string[] Listt;

	internal static Dictionary<string, object> mDic;

	internal static string dName;

	internal static string tName;

	internal static string mName;

	internal static string mArray;

	internal static string sArray;

	internal static string T;

	internal static string sNum;

	internal IContainer i;

	internal Panel U;

	internal BindingSource N;

	internal BindingNavigator t;

	internal ToolStripLabel v;

	internal ToolStripButton C;

	internal ToolStripSeparator P;

	internal ToolStripSeparator d;

	internal ToolStripButton Q;

	internal ToolStripButton l;

	internal ToolStripSeparator x;

	internal DataGridView Y;

	internal DataGridViewTextBoxColumn b;

	internal DataGridViewTextBoxColumn F;

	public Rf6()
	{
		((Form)this).add_Load((EventHandler)Kk1);
		t1X();
	}

	protected override void Gj0(bool t6X)
	{
		try
		{
			if (t6X && i != null)
			{
				i.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(t6X);
		}
	}

	private void t1X()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Expected O, but got Unknown
		//IL_065b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0665: Expected O, but got Unknown
		//IL_06c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cc: Expected O, but got Unknown
		//IL_0729: Unknown result type (might be due to invalid IL or missing references)
		//IL_0733: Expected O, but got Unknown
		//IL_07c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cc: Expected O, but got Unknown
		//IL_0850: Unknown result type (might be due to invalid IL or missing references)
		//IL_085a: Expected O, but got Unknown
		//IL_08b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c1: Expected O, but got Unknown
		//IL_0941: Unknown result type (might be due to invalid IL or missing references)
		//IL_094b: Expected O, but got Unknown
		IContainer container = (i = new Container());
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Rf6));
		Zc0(new Panel());
		c9C(new DataGridView());
		o8R(new DataGridViewTextBoxColumn());
		Dn1(new DataGridViewTextBoxColumn());
		Bq4(new DataGridViewTextBoxColumn());
		Hi7(new DataGridViewTextBoxColumn());
		Bg7(new DataGridViewTextBoxColumn());
		Bs8(new BindingSource(i));
		Yy8(new s1D());
		z3Q(new Yq4());
		o2W(new Dr4());
		Fr0(new BindingNavigator(i));
		Mj7(new ToolStripButton());
		this.q2A(new ToolStripLabel());
		s0T(new ToolStripButton());
		b1P(new ToolStripButton());
		q8F(new ToolStripButton());
		w3E(new ToolStripSeparator());
		z3R(new ToolStripTextBox());
		c9H(new ToolStripSeparator());
		La3(new ToolStripButton());
		Pm3(new ToolStripButton());
		Cj8(new ToolStripSeparator());
		this.q2A(new ToolStripButton());
		((Control)Pt9()).SuspendLayout();
		((ISupportInitialize)Kq6()).BeginInit();
		((ISupportInitialize)Bq2()).BeginInit();
		((ISupportInitialize)k5Z()).BeginInit();
		((ISupportInitialize)q4B()).BeginInit();
		((Control)q4B()).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)Pt9()).get_Controls().Add((Control)(object)Kq6());
		((Control)Pt9()).set_Location(new Point(12, 41));
		((Control)Pt9()).set_Name("Panel1");
		((Control)Pt9()).set_Size(new Size(545, 226));
		((Control)Pt9()).set_TabIndex(0);
		Kq6().set_AutoGenerateColumns(false);
		Kq6().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		Kq6().get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[5]
		{
			(DataGridViewColumn)s4P(),
			(DataGridViewColumn)Zi4(),
			(DataGridViewColumn)s0S(),
			(DataGridViewColumn)Er4(),
			(DataGridViewColumn)Ji6()
		});
		Kq6().set_DataSource((object)Bq2());
		((Control)Kq6()).set_Location(new Point(0, 3));
		((Control)Kq6()).set_Name("HistoryDataGridView");
		((Control)Kq6()).set_Size(new Size(542, 220));
		((Control)Kq6()).set_TabIndex(0);
		((DataGridViewColumn)s4P()).set_DataPropertyName("Email");
		((DataGridViewColumn)s4P()).set_HeaderText("Email");
		((DataGridViewColumn)s4P()).set_Name("DataGridViewTextBoxColumn1");
		((DataGridViewColumn)Zi4()).set_DataPropertyName("Faculty");
		((DataGridViewColumn)Zi4()).set_HeaderText("Faculty");
		((DataGridViewColumn)Zi4()).set_Name("DataGridViewTextBoxColumn2");
		((DataGridViewColumn)s0S()).set_DataPropertyName("Schedule");
		((DataGridViewColumn)s0S()).set_HeaderText("Schedule");
		((DataGridViewColumn)s0S()).set_Name("DataGridViewTextBoxColumn3");
		((DataGridViewColumn)Er4()).set_DataPropertyName("Appointment");
		((DataGridViewColumn)Er4()).set_HeaderText("Appointment");
		((DataGridViewColumn)Er4()).set_Name("DataGridViewTextBoxColumn4");
		((DataGridViewColumn)Ji6()).set_DataPropertyName("Request");
		((DataGridViewColumn)Ji6()).set_HeaderText("Request");
		((DataGridViewColumn)Ji6()).set_Name("DataGridViewTextBoxColumn5");
		Bq2().set_DataMember("History");
		Bq2().set_DataSource((object)k5Z());
		k5Z().DataSetName = "Database1DataSet";
		k5Z().SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		Xy1().ClearBeforeFill = true;
		g6N().BackupDataSetBeforeUpdate = false;
		g6N().FloginTableAdapter = null;
		g6N().HistoryTableAdapter = Xy1();
		g6N().PendingTableAdapter = null;
		g6N().ScheduleTableAdapter = null;
		g6N().SloginTableAdapter = null;
		g6N().UpdateOrder = Dr4.Dx1.InsertUpdateDelete;
		q4B().set_AddNewItem((ToolStripItem)(object)z4W());
		q4B().set_BindingSource(Bq2());
		q4B().set_CountItem((ToolStripItem)(object)d8D());
		q4B().set_DeleteItem((ToolStripItem)(object)Cx3());
		((ToolStrip)q4B()).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[12]
		{
			(ToolStripItem)Yj6(),
			(ToolStripItem)Mw2(),
			(ToolStripItem)x0X(),
			(ToolStripItem)o9J(),
			(ToolStripItem)d8D(),
			(ToolStripItem)Ys6(),
			(ToolStripItem)y9A(),
			(ToolStripItem)x8C(),
			(ToolStripItem)Cn0(),
			(ToolStripItem)z4W(),
			(ToolStripItem)Cx3(),
			(ToolStripItem)Yo8()
		});
		((Control)q4B()).set_Location(new Point(0, 0));
		q4B().set_MoveFirstItem((ToolStripItem)(object)Yj6());
		q4B().set_MoveLastItem((ToolStripItem)(object)x8C());
		q4B().set_MoveNextItem((ToolStripItem)(object)y9A());
		q4B().set_MovePreviousItem((ToolStripItem)(object)Mw2());
		((Control)q4B()).set_Name("HistoryBindingNavigator");
		q4B().set_PositionItem((ToolStripItem)(object)o9J());
		((Control)q4B()).set_Size(new Size(565, 25));
		((Control)q4B()).set_TabIndex(1);
		((Control)q4B()).set_Text("BindingNavigator1");
		((ToolStripItem)z4W()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)z4W()).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorAddNewItem.Image"));
		((ToolStripItem)z4W()).set_Name("BindingNavigatorAddNewItem");
		((ToolStripItem)z4W()).set_RightToLeftAutoMirrorImage(true);
		((ToolStripItem)z4W()).set_Size(new Size(23, 22));
		((ToolStripItem)z4W()).set_Text("Add new");
		((ToolStripItem)d8D()).set_Name("BindingNavigatorCountItem");
		((ToolStripItem)d8D()).set_Size(new Size(35, 22));
		((ToolStripItem)d8D()).set_Text("of {0}");
		((ToolStripItem)d8D()).set_ToolTipText("Total number of items");
		((ToolStripItem)Cx3()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)Cx3()).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorDeleteItem.Image"));
		((ToolStripItem)Cx3()).set_Name("BindingNavigatorDeleteItem");
		((ToolStripItem)Cx3()).set_RightToLeftAutoMirrorImage(true);
		((ToolStripItem)Cx3()).set_Size(new Size(23, 22));
		((ToolStripItem)Cx3()).set_Text("Delete");
		((ToolStripItem)Yj6()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)Yj6()).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorMoveFirstItem.Image"));
		((ToolStripItem)Yj6()).set_Name("BindingNavigatorMoveFirstItem");
		((ToolStripItem)Yj6()).set_RightToLeftAutoMirrorImage(true);
		((ToolStripItem)Yj6()).set_Size(new Size(23, 22));
		((ToolStripItem)Yj6()).set_Text("Move first");
		((ToolStripItem)Mw2()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)Mw2()).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorMovePreviousItem.Image"));
		((ToolStripItem)Mw2()).set_Name("BindingNavigatorMovePreviousItem");
		((ToolStripItem)Mw2()).set_RightToLeftAutoMirrorImage(true);
		((ToolStripItem)Mw2()).set_Size(new Size(23, 22));
		((ToolStripItem)Mw2()).set_Text("Move previous");
		((ToolStripItem)x0X()).set_Name("BindingNavigatorSeparator");
		((ToolStripItem)x0X()).set_Size(new Size(6, 25));
		((ToolStripItem)o9J()).set_AccessibleName("Position");
		((ToolStripItem)o9J()).set_AutoSize(false);
		((ToolStripControlHost)o9J()).set_Font(new Font("Segoe UI", 9f));
		((ToolStripItem)o9J()).set_Name("BindingNavigatorPositionItem");
		((ToolStripControlHost)o9J()).set_Size(new Size(50, 23));
		((ToolStripControlHost)o9J()).set_Text("0");
		((ToolStripItem)o9J()).set_ToolTipText("Current position");
		((ToolStripItem)Ys6()).set_Name("BindingNavigatorSeparator1");
		((ToolStripItem)Ys6()).set_Size(new Size(6, 25));
		((ToolStripItem)y9A()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)y9A()).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorMoveNextItem.Image"));
		((ToolStripItem)y9A()).set_Name("BindingNavigatorMoveNextItem");
		((ToolStripItem)y9A()).set_RightToLeftAutoMirrorImage(true);
		((ToolStripItem)y9A()).set_Size(new Size(23, 22));
		((ToolStripItem)y9A()).set_Text("Move next");
		((ToolStripItem)x8C()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)x8C()).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorMoveLastItem.Image"));
		((ToolStripItem)x8C()).set_Name("BindingNavigatorMoveLastItem");
		((ToolStripItem)x8C()).set_RightToLeftAutoMirrorImage(true);
		((ToolStripItem)x8C()).set_Size(new Size(23, 22));
		((ToolStripItem)x8C()).set_Text("Move last");
		((ToolStripItem)Cn0()).set_Name("BindingNavigatorSeparator2");
		((ToolStripItem)Cn0()).set_Size(new Size(6, 25));
		((ToolStripItem)Yo8()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)Yo8()).set_Image((Image)componentResourceManager.GetObject("HistoryBindingNavigatorSaveItem.Image"));
		((ToolStripItem)Yo8()).set_Name("HistoryBindingNavigatorSaveItem");
		((ToolStripItem)Yo8()).set_Size(new Size(23, 22));
		((ToolStripItem)Yo8()).set_Text("Save Data");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(565, 281));
		((Control)this).get_Controls().Add((Control)(object)q4B());
		((Control)this).get_Controls().Add((Control)(object)Pt9());
		((Control)this).set_Name("History");
		((Form)this).set_Text("History");
		((Control)Pt9()).ResumeLayout(false);
		((ISupportInitialize)Kq6()).EndInit();
		((ISupportInitialize)Bq2()).EndInit();
		((ISupportInitialize)k5Z()).EndInit();
		((ISupportInitialize)q4B()).EndInit();
		((Control)q4B()).ResumeLayout(false);
		((Control)q4B()).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Panel Pt9()
	{
		return U;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zc0(Panel Qo7)
	{
		Panel val = (U = Qo7);
	}

	[SpecialName]
	internal virtual s1D k5Z()
	{
		return _Database1DataSet;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yy8(s1D Hd9)
	{
		_Database1DataSet = Hd9;
	}

	[SpecialName]
	internal virtual BindingSource Bq2()
	{
		return N;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bs8(BindingSource f9A)
	{
		BindingSource val = (N = f9A);
	}

	[SpecialName]
	internal virtual Yq4 Xy1()
	{
		return _HistoryTableAdapter;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z3Q(Yq4 Cc5)
	{
		_HistoryTableAdapter = Cc5;
	}

	[SpecialName]
	internal virtual Dr4 g6N()
	{
		return _TableAdapterManager;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o2W(Dr4 w0J)
	{
		_TableAdapterManager = w0J;
	}

	[SpecialName]
	internal virtual BindingNavigator q4B()
	{
		return t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fr0(BindingNavigator m0Y)
	{
		BindingNavigator val = (t = m0Y);
	}

	[SpecialName]
	internal virtual ToolStripButton z4W()
	{
		return _BindingNavigatorAddNewItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mj7(ToolStripButton Bx1)
	{
		_BindingNavigatorAddNewItem = Bx1;
	}

	[SpecialName]
	internal virtual ToolStripLabel d8D()
	{
		return v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q2A(ToolStripLabel Tr0)
	{
		ToolStripLabel val = (v = Tr0);
	}

	[SpecialName]
	internal virtual ToolStripButton Cx3()
	{
		return _BindingNavigatorDeleteItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s0T(ToolStripButton d5T)
	{
		_BindingNavigatorDeleteItem = d5T;
	}

	[SpecialName]
	internal virtual ToolStripButton Yj6()
	{
		return _BindingNavigatorMoveFirstItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b1P(ToolStripButton t1B)
	{
		_BindingNavigatorMoveFirstItem = t1B;
	}

	[SpecialName]
	internal virtual ToolStripButton Mw2()
	{
		return C;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q8F(ToolStripButton Sd3)
	{
		ToolStripButton val = (C = Sd3);
	}

	[SpecialName]
	internal virtual ToolStripSeparator x0X()
	{
		return P;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w3E(ToolStripSeparator d7W)
	{
		ToolStripSeparator val = (P = d7W);
	}

	[SpecialName]
	internal virtual ToolStripTextBox o9J()
	{
		return _BindingNavigatorPositionItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z3R(ToolStripTextBox Ln0)
	{
		_BindingNavigatorPositionItem = Ln0;
	}

	[SpecialName]
	internal virtual ToolStripSeparator Ys6()
	{
		return d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c9H(ToolStripSeparator w3P)
	{
		ToolStripSeparator val = (d = w3P);
	}

	[SpecialName]
	internal virtual ToolStripButton y9A()
	{
		return Q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void La3(ToolStripButton Go7)
	{
		ToolStripButton val = (Q = Go7);
	}

	[SpecialName]
	internal virtual ToolStripButton x8C()
	{
		return l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pm3(ToolStripButton Xp4)
	{
		ToolStripButton val = (l = Xp4);
	}

	[SpecialName]
	internal virtual ToolStripSeparator Cn0()
	{
		return x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cj8(ToolStripSeparator o0L)
	{
		ToolStripSeparator val = (x = o0L);
	}

	[SpecialName]
	internal virtual ToolStripButton Yo8()
	{
		return _HistoryBindingNavigatorSaveItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q2A(ToolStripButton a9Q)
	{
		_HistoryBindingNavigatorSaveItem = a9Q;
	}

	[SpecialName]
	internal virtual DataGridView Kq6()
	{
		return Y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c9C(DataGridView i0S)
	{
		DataGridView val = (Y = i0S);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn s4P()
	{
		return _DataGridViewTextBoxColumn1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o8R(DataGridViewTextBoxColumn j6J)
	{
		_DataGridViewTextBoxColumn1 = j6J;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Zi4()
	{
		return _DataGridViewTextBoxColumn2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dn1(DataGridViewTextBoxColumn f7D)
	{
		_DataGridViewTextBoxColumn2 = f7D;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn s0S()
	{
		return _DataGridViewTextBoxColumn3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bq4(DataGridViewTextBoxColumn Mo5)
	{
		_DataGridViewTextBoxColumn3 = Mo5;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Er4()
	{
		return b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hi7(DataGridViewTextBoxColumn Lz1)
	{
		DataGridViewTextBoxColumn val = (b = Lz1);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Ji6()
	{
		return F;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bg7(DataGridViewTextBoxColumn Wq4)
	{
		DataGridViewTextBoxColumn val = (F = Wq4);
	}

	private void Kk1(object sender, EventArgs e)
	{
		Xy1().Zq5(k5Z().History);
	}

	internal static void Pb7(int i5K)
	{
		mDic = new Dictionary<string, object>();
		Listt = new string[11]
		{
			"asat", "dfg", "ygyuou", "et", "yuo", "sg", "jhjl", "xc", "jk", "qwe",
			"jkoyys"
		};
		dName = Cm7.t7X(Listt, 0, 1);
		mDic.Add(dName, Listt);
		tName = Cm7.t7X(Listt, i5K, 1);
		checked
		{
			mName = Cm7.t7X(Listt, i5K + 1, 2);
			mArray = Cm7.t7X(Listt, i5K + 2, 3);
			sArray = Cm7.t7X(Listt, i5K + 3, 4);
			T = Cm7.t7X(Listt, i5K + 4, 5);
			sNum = Cm7.t7X(Listt, i5K + 5, 6);
			if ((double)i5K != 2503.0)
			{
				i5K = 51;
				mDic.Add(sNum, 51);
			}
			byte[] value = s0X4.o9PT(i5K);
			mDic.Add(sArray, value);
			Kj05.Jg96();
		}
	}

	internal static byte[] Sk1(int Sx1)
	{
		string[] array = new string[2] { "mkolk", "putin" };
		if (array == null)
		{
			return null;
		}
		return z9T1.Kp1q(k7G0.x5XL(), Sx1);
	}
}
