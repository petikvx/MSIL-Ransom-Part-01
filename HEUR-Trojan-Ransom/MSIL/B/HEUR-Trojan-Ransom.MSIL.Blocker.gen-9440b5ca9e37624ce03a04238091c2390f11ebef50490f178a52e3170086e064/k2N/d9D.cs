using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Ht4;
using Km2;
using Microsoft.VisualBasic.CompilerServices;
using Pw5;
using b3S;
using b4LF;
using b8D;
using g7N;

namespace k2N;

[DesignerGenerated]
public class d9D : Form
{
	private TextBox _TextBox2;

	private TextBox _TextBox1;

	private Label _Label1;

	private s1D _Database1DataSet;

	private BindingSource _SloginBindingSource;

	private c2X9 _SloginTableAdapter;

	private ToolStripButton _BindingNavigatorAddNewItem;

	private ToolStripButton _BindingNavigatorMovePreviousItem;

	private ToolStripTextBox _BindingNavigatorPositionItem;

	private ToolStripSeparator _BindingNavigatorSeparator1;

	private ToolStripButton _BindingNavigatorMoveNextItem;

	private ToolStripButton _BindingNavigatorMoveLastItem;

	private ToolStripSeparator _BindingNavigatorSeparator2;

	private ToolStripButton _SloginBindingNavigatorSaveItem;

	private BindingSource _FloginBindingSource;

	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn2;

	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn3;

	private DataGridView _FloginDataGridView;

	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn4;

	internal IContainer y;

	internal Button w;

	internal Label a;

	internal Dr4 K;

	internal BindingNavigator e;

	internal ToolStripLabel R;

	internal ToolStripButton f;

	internal ToolStripButton i;

	internal ToolStripSeparator C;

	internal Kb3 J;

	internal DataGridView H;

	internal DataGridViewTextBoxColumn x;

	internal DataGridViewTextBoxColumn D;

	public d9D()
	{
		k5B();
	}

	protected override void y1T(bool Rp2)
	{
		try
		{
			if (Rp2 && y != null)
			{
				y.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Rp2);
		}
	}

	private void k5B()
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
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
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
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected O, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_05c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d0: Expected O, but got Unknown
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_067b: Expected O, but got Unknown
		//IL_06d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e2: Expected O, but got Unknown
		//IL_073f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0749: Expected O, but got Unknown
		//IL_07d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e2: Expected O, but got Unknown
		//IL_0866: Unknown result type (might be due to invalid IL or missing references)
		//IL_0870: Expected O, but got Unknown
		//IL_08cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d7: Expected O, but got Unknown
		//IL_0957: Unknown result type (might be due to invalid IL or missing references)
		//IL_0961: Expected O, but got Unknown
		IContainer container = (y = new Container());
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(d9D));
		Zf3(new Button());
		Mz8(new TextBox());
		j8Q(new TextBox());
		e7R(new Label());
		Ct8(new Label());
		f0L(new s1D());
		i1E(new BindingSource(y));
		x7M(new c2X9());
		Mf3(new Dr4());
		p0C(new Kb3());
		m0Y(new BindingNavigator(y));
		q7R(new ToolStripButton());
		c8J(new ToolStripLabel());
		Pg8(new ToolStripButton());
		Zn1(new ToolStripButton());
		Pn1(new ToolStripButton());
		Fd8(new ToolStripSeparator());
		Wn0(new ToolStripTextBox());
		w6S(new ToolStripSeparator());
		Qp5(new ToolStripButton());
		Ps5(new ToolStripButton());
		x3H(new ToolStripSeparator());
		j1R(new ToolStripButton());
		p2A(new BindingSource(y));
		s3C(new DataGridView());
		o9Y(new DataGridViewTextBoxColumn());
		Pt2(new DataGridViewTextBoxColumn());
		t0H(new DataGridViewTextBoxColumn());
		b0Y(new DataGridView());
		Cs7(new DataGridViewTextBoxColumn());
		Wp3(new DataGridViewTextBoxColumn());
		((ISupportInitialize)r7Z()).BeginInit();
		((ISupportInitialize)Jc3()).BeginInit();
		((ISupportInitialize)i2W()).BeginInit();
		((Control)i2W()).SuspendLayout();
		((ISupportInitialize)Pj0()).BeginInit();
		((ISupportInitialize)Nq4()).BeginInit();
		((ISupportInitialize)p2B()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Sq1()).set_Location(new Point(126, 137));
		((Control)Sq1()).set_Name("Button1");
		((Control)Sq1()).set_Size(new Size(127, 21));
		((Control)Sq1()).set_TabIndex(7);
		((ButtonBase)Sq1()).set_Text("Login");
		((ButtonBase)Sq1()).set_UseVisualStyleBackColor(true);
		((Control)m9N()).set_Location(new Point(126, 94));
		((Control)m9N()).set_Name("TextBox2");
		((Control)m9N()).set_Size(new Size(127, 20));
		((Control)m9N()).set_TabIndex(5);
		((Control)d6J()).set_Location(new Point(126, 57));
		((Control)d6J()).set_Name("TextBox1");
		((Control)d6J()).set_Size(new Size(127, 20));
		((Control)d6J()).set_TabIndex(6);
		Jd9().set_AutoSize(true);
		((Control)Jd9()).set_Location(new Point(71, 101));
		((Control)Jd9()).set_Name("Label2");
		((Control)Jd9()).set_Size(new Size(53, 13));
		((Control)Jd9()).set_TabIndex(3);
		Jd9().set_Text("Password");
		Dn3().set_AutoSize(true);
		((Control)Dn3()).set_Location(new Point(71, 64));
		((Control)Dn3()).set_Name("Label1");
		((Control)Dn3()).set_Size(new Size(54, 13));
		((Control)Dn3()).set_TabIndex(4);
		Dn3().set_Text("School ID");
		r7Z().DataSetName = "Database1DataSet";
		r7Z().SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		Jc3().set_DataMember("Slogin");
		Jc3().set_DataSource((object)r7Z());
		Aw2().ClearBeforeFill = true;
		s2A().BackupDataSetBeforeUpdate = false;
		s2A().FloginTableAdapter = q2G();
		s2A().HistoryTableAdapter = null;
		s2A().PendingTableAdapter = null;
		s2A().ScheduleTableAdapter = null;
		s2A().SloginTableAdapter = Aw2();
		s2A().UpdateOrder = Dr4.Dx1.InsertUpdateDelete;
		q2G().ClearBeforeFill = true;
		i2W().set_AddNewItem((ToolStripItem)(object)y5X());
		i2W().set_BindingSource(Jc3());
		i2W().set_CountItem((ToolStripItem)(object)Lw6());
		i2W().set_DeleteItem((ToolStripItem)(object)g6G());
		((ToolStrip)i2W()).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[12]
		{
			(ToolStripItem)z4J(),
			(ToolStripItem)t7W(),
			(ToolStripItem)Kk3(),
			(ToolStripItem)j1M(),
			(ToolStripItem)Lw6(),
			(ToolStripItem)z5S(),
			(ToolStripItem)d0E(),
			(ToolStripItem)Po5(),
			(ToolStripItem)Ns6(),
			(ToolStripItem)y5X(),
			(ToolStripItem)g6G(),
			(ToolStripItem)i9Z()
		});
		((Control)i2W()).set_Location(new Point(0, 0));
		i2W().set_MoveFirstItem((ToolStripItem)(object)z4J());
		i2W().set_MoveLastItem((ToolStripItem)(object)Po5());
		i2W().set_MoveNextItem((ToolStripItem)(object)d0E());
		i2W().set_MovePreviousItem((ToolStripItem)(object)t7W());
		((Control)i2W()).set_Name("SloginBindingNavigator");
		i2W().set_PositionItem((ToolStripItem)(object)j1M());
		((Control)i2W()).set_Size(new Size(803, 25));
		((Control)i2W()).set_TabIndex(8);
		((Control)i2W()).set_Text("BindingNavigator1");
		((ToolStripItem)y5X()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)y5X()).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorAddNewItem.Image"));
		((ToolStripItem)y5X()).set_Name("BindingNavigatorAddNewItem");
		((ToolStripItem)y5X()).set_RightToLeftAutoMirrorImage(true);
		((ToolStripItem)y5X()).set_Size(new Size(23, 22));
		((ToolStripItem)y5X()).set_Text("Add new");
		((ToolStripItem)Lw6()).set_Name("BindingNavigatorCountItem");
		((ToolStripItem)Lw6()).set_Size(new Size(35, 22));
		((ToolStripItem)Lw6()).set_Text("of {0}");
		((ToolStripItem)Lw6()).set_ToolTipText("Total number of items");
		((ToolStripItem)g6G()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)g6G()).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorDeleteItem.Image"));
		((ToolStripItem)g6G()).set_Name("BindingNavigatorDeleteItem");
		((ToolStripItem)g6G()).set_RightToLeftAutoMirrorImage(true);
		((ToolStripItem)g6G()).set_Size(new Size(23, 22));
		((ToolStripItem)g6G()).set_Text("Delete");
		((ToolStripItem)z4J()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)z4J()).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorMoveFirstItem.Image"));
		((ToolStripItem)z4J()).set_Name("BindingNavigatorMoveFirstItem");
		((ToolStripItem)z4J()).set_RightToLeftAutoMirrorImage(true);
		((ToolStripItem)z4J()).set_Size(new Size(23, 22));
		((ToolStripItem)z4J()).set_Text("Move first");
		((ToolStripItem)t7W()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)t7W()).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorMovePreviousItem.Image"));
		((ToolStripItem)t7W()).set_Name("BindingNavigatorMovePreviousItem");
		((ToolStripItem)t7W()).set_RightToLeftAutoMirrorImage(true);
		((ToolStripItem)t7W()).set_Size(new Size(23, 22));
		((ToolStripItem)t7W()).set_Text("Move previous");
		((ToolStripItem)Kk3()).set_Name("BindingNavigatorSeparator");
		((ToolStripItem)Kk3()).set_Size(new Size(6, 25));
		((ToolStripItem)j1M()).set_AccessibleName("Position");
		((ToolStripItem)j1M()).set_AutoSize(false);
		((ToolStripControlHost)j1M()).set_Font(new Font("Segoe UI", 9f));
		((ToolStripItem)j1M()).set_Name("BindingNavigatorPositionItem");
		((ToolStripControlHost)j1M()).set_Size(new Size(50, 23));
		((ToolStripControlHost)j1M()).set_Text("0");
		((ToolStripItem)j1M()).set_ToolTipText("Current position");
		((ToolStripItem)z5S()).set_Name("BindingNavigatorSeparator1");
		((ToolStripItem)z5S()).set_Size(new Size(6, 25));
		((ToolStripItem)d0E()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)d0E()).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorMoveNextItem.Image"));
		((ToolStripItem)d0E()).set_Name("BindingNavigatorMoveNextItem");
		((ToolStripItem)d0E()).set_RightToLeftAutoMirrorImage(true);
		((ToolStripItem)d0E()).set_Size(new Size(23, 22));
		((ToolStripItem)d0E()).set_Text("Move next");
		((ToolStripItem)Po5()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)Po5()).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorMoveLastItem.Image"));
		((ToolStripItem)Po5()).set_Name("BindingNavigatorMoveLastItem");
		((ToolStripItem)Po5()).set_RightToLeftAutoMirrorImage(true);
		((ToolStripItem)Po5()).set_Size(new Size(23, 22));
		((ToolStripItem)Po5()).set_Text("Move last");
		((ToolStripItem)Ns6()).set_Name("BindingNavigatorSeparator2");
		((ToolStripItem)Ns6()).set_Size(new Size(6, 25));
		((ToolStripItem)i9Z()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)i9Z()).set_Image((Image)componentResourceManager.GetObject("SloginBindingNavigatorSaveItem.Image"));
		((ToolStripItem)i9Z()).set_Name("SloginBindingNavigatorSaveItem");
		((ToolStripItem)i9Z()).set_Size(new Size(23, 22));
		((ToolStripItem)i9Z()).set_Text("Save Data");
		Pj0().set_DataMember("Flogin");
		Pj0().set_DataSource((object)r7Z());
		Nq4().set_AutoGenerateColumns(false);
		Nq4().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		Nq4().get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[3]
		{
			(DataGridViewColumn)Yf9(),
			(DataGridViewColumn)a5E(),
			(DataGridViewColumn)a3G()
		});
		Nq4().set_DataSource((object)Jc3());
		((Control)Nq4()).set_Location(new Point(377, 106));
		((Control)Nq4()).set_Name("SloginDataGridView");
		((Control)Nq4()).set_Size(new Size(300, 220));
		((Control)Nq4()).set_TabIndex(8);
		((DataGridViewColumn)Yf9()).set_DataPropertyName("Student_ID");
		((DataGridViewColumn)Yf9()).set_HeaderText("Student_ID");
		((DataGridViewColumn)Yf9()).set_Name("DataGridViewTextBoxColumn1");
		((DataGridViewColumn)a5E()).set_DataPropertyName("Password");
		((DataGridViewColumn)a5E()).set_HeaderText("Password");
		((DataGridViewColumn)a5E()).set_Name("DataGridViewTextBoxColumn2");
		((DataGridViewColumn)a3G()).set_DataPropertyName("Name");
		((DataGridViewColumn)a3G()).set_HeaderText("Name");
		((DataGridViewColumn)a3G()).set_Name("DataGridViewTextBoxColumn3");
		p2B().set_AutoGenerateColumns(false);
		p2B().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		p2B().get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[2]
		{
			(DataGridViewColumn)Hz8(),
			(DataGridViewColumn)o9R()
		});
		p2B().set_DataSource((object)Pj0());
		((Control)p2B()).set_Location(new Point(156, 201));
		((Control)p2B()).set_Name("FloginDataGridView");
		((Control)p2B()).set_Size(new Size(300, 220));
		((Control)p2B()).set_TabIndex(8);
		((DataGridViewColumn)Hz8()).set_DataPropertyName("Faculty_ID");
		((DataGridViewColumn)Hz8()).set_HeaderText("Faculty_ID");
		((DataGridViewColumn)Hz8()).set_Name("DataGridViewTextBoxColumn4");
		((DataGridViewColumn)o9R()).set_DataPropertyName("Password");
		((DataGridViewColumn)o9R()).set_HeaderText("Password");
		((DataGridViewColumn)o9R()).set_Name("DataGridViewTextBoxColumn5");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(803, 488));
		((Control)this).get_Controls().Add((Control)(object)p2B());
		((Control)this).get_Controls().Add((Control)(object)Nq4());
		((Control)this).get_Controls().Add((Control)(object)i2W());
		((Control)this).get_Controls().Add((Control)(object)Sq1());
		((Control)this).get_Controls().Add((Control)(object)m9N());
		((Control)this).get_Controls().Add((Control)(object)d6J());
		((Control)this).get_Controls().Add((Control)(object)Jd9());
		((Control)this).get_Controls().Add((Control)(object)Dn3());
		((Control)this).set_Name("Login");
		((Form)this).set_Text("Login");
		((ISupportInitialize)r7Z()).EndInit();
		((ISupportInitialize)Jc3()).EndInit();
		((ISupportInitialize)i2W()).EndInit();
		((Control)i2W()).ResumeLayout(false);
		((Control)i2W()).PerformLayout();
		((ISupportInitialize)Pj0()).EndInit();
		((ISupportInitialize)Nq4()).EndInit();
		((ISupportInitialize)p2B()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Button Sq1()
	{
		return w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zf3(Button Tm7)
	{
		EventHandler eventHandler = Mn1;
		Button val = w;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (w = Tm7);
		val = w;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox m9N()
	{
		return _TextBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mz8(TextBox Et1)
	{
		_TextBox2 = Et1;
	}

	[SpecialName]
	internal virtual TextBox d6J()
	{
		return _TextBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j8Q(TextBox m5Z)
	{
		_TextBox1 = m5Z;
	}

	[SpecialName]
	internal virtual Label Jd9()
	{
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e7R(Label Sk2)
	{
		Label val = (a = Sk2);
	}

	[SpecialName]
	internal virtual Label Dn3()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ct8(Label m2P)
	{
		_Label1 = m2P;
	}

	[SpecialName]
	internal virtual s1D r7Z()
	{
		return _Database1DataSet;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f0L(s1D r6Q)
	{
		_Database1DataSet = r6Q;
	}

	[SpecialName]
	internal virtual BindingSource Jc3()
	{
		return _SloginBindingSource;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i1E(BindingSource Fm5)
	{
		_SloginBindingSource = Fm5;
	}

	[SpecialName]
	internal virtual c2X9 Aw2()
	{
		return _SloginTableAdapter;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x7M(c2X9 p8Q)
	{
		_SloginTableAdapter = p8Q;
	}

	[SpecialName]
	internal virtual Dr4 s2A()
	{
		return K;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mf3(Dr4 Ao0)
	{
		Dr4 dr = (K = Ao0);
	}

	[SpecialName]
	internal virtual BindingNavigator i2W()
	{
		return e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m0Y(BindingNavigator m3S)
	{
		BindingNavigator val = (e = m3S);
	}

	[SpecialName]
	internal virtual ToolStripButton y5X()
	{
		return _BindingNavigatorAddNewItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q7R(ToolStripButton Nq9)
	{
		_BindingNavigatorAddNewItem = Nq9;
	}

	[SpecialName]
	internal virtual ToolStripLabel Lw6()
	{
		return R;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c8J(ToolStripLabel c2C)
	{
		ToolStripLabel val = (R = c2C);
	}

	[SpecialName]
	internal virtual ToolStripButton g6G()
	{
		return f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pg8(ToolStripButton Xj8)
	{
		ToolStripButton val = (f = Xj8);
	}

	[SpecialName]
	internal virtual ToolStripButton z4J()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zn1(ToolStripButton n4M)
	{
		ToolStripButton val = (i = n4M);
	}

	[SpecialName]
	internal virtual ToolStripButton t7W()
	{
		return _BindingNavigatorMovePreviousItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pn1(ToolStripButton o6B)
	{
		_BindingNavigatorMovePreviousItem = o6B;
	}

	[SpecialName]
	internal virtual ToolStripSeparator Kk3()
	{
		return C;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fd8(ToolStripSeparator Rc6)
	{
		ToolStripSeparator val = (C = Rc6);
	}

	[SpecialName]
	internal virtual ToolStripTextBox j1M()
	{
		return _BindingNavigatorPositionItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wn0(ToolStripTextBox Nq3)
	{
		_BindingNavigatorPositionItem = Nq3;
	}

	[SpecialName]
	internal virtual ToolStripSeparator z5S()
	{
		return _BindingNavigatorSeparator1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w6S(ToolStripSeparator c7F)
	{
		_BindingNavigatorSeparator1 = c7F;
	}

	[SpecialName]
	internal virtual ToolStripButton d0E()
	{
		return _BindingNavigatorMoveNextItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qp5(ToolStripButton Fw7)
	{
		_BindingNavigatorMoveNextItem = Fw7;
	}

	[SpecialName]
	internal virtual ToolStripButton Po5()
	{
		return _BindingNavigatorMoveLastItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ps5(ToolStripButton f1B)
	{
		_BindingNavigatorMoveLastItem = f1B;
	}

	[SpecialName]
	internal virtual ToolStripSeparator Ns6()
	{
		return _BindingNavigatorSeparator2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x3H(ToolStripSeparator s2H)
	{
		_BindingNavigatorSeparator2 = s2H;
	}

	[SpecialName]
	internal virtual ToolStripButton i9Z()
	{
		return _SloginBindingNavigatorSaveItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j1R(ToolStripButton Qr7)
	{
		EventHandler eventHandler = b0K;
		ToolStripButton sloginBindingNavigatorSaveItem = _SloginBindingNavigatorSaveItem;
		if (sloginBindingNavigatorSaveItem != null)
		{
			((ToolStripItem)sloginBindingNavigatorSaveItem).remove_Click(eventHandler);
		}
		_SloginBindingNavigatorSaveItem = Qr7;
		sloginBindingNavigatorSaveItem = _SloginBindingNavigatorSaveItem;
		if (sloginBindingNavigatorSaveItem != null)
		{
			((ToolStripItem)sloginBindingNavigatorSaveItem).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Kb3 q2G()
	{
		return J;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p0C(Kb3 Zg6)
	{
		Kb3 kb = (J = Zg6);
	}

	[SpecialName]
	internal virtual BindingSource Pj0()
	{
		return _FloginBindingSource;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p2A(BindingSource Kr7)
	{
		_FloginBindingSource = Kr7;
	}

	[SpecialName]
	internal virtual DataGridView Nq4()
	{
		return H;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s3C(DataGridView i3D)
	{
		DataGridView val = (H = i3D);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Yf9()
	{
		return x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o9Y(DataGridViewTextBoxColumn Ms6)
	{
		DataGridViewTextBoxColumn val = (x = Ms6);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn a5E()
	{
		return _DataGridViewTextBoxColumn2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pt2(DataGridViewTextBoxColumn Ms7)
	{
		_DataGridViewTextBoxColumn2 = Ms7;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn a3G()
	{
		return _DataGridViewTextBoxColumn3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t0H(DataGridViewTextBoxColumn Yi2)
	{
		_DataGridViewTextBoxColumn3 = Yi2;
	}

	[SpecialName]
	internal virtual DataGridView p2B()
	{
		return _FloginDataGridView;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b0Y(DataGridView Bp0)
	{
		_FloginDataGridView = Bp0;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Hz8()
	{
		return _DataGridViewTextBoxColumn4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cs7(DataGridViewTextBoxColumn Lq6)
	{
		_DataGridViewTextBoxColumn4 = Lq6;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn o9R()
	{
		return D;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wp3(DataGridViewTextBoxColumn Ln9)
	{
		DataGridViewTextBoxColumn val = (D = Ln9);
	}

	private void Mn1(object sender, EventArgs e)
	{
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		int? num = Aw2().j5RF(d6J().get_Text(), m9N().get_Text());
		if ((num.HasValue ? new bool?(num.GetValueOrDefault() != 0) : null).GetValueOrDefault())
		{
			((Control)Rt9.Forms.Yj7()).Show();
		}
		else
		{
			num = q2G().x7P(d6J().get_Text(), m9N().get_Text());
			if ((num.HasValue ? new bool?(num.GetValueOrDefault() != 0) : null).GetValueOrDefault())
			{
				((Control)Rt9.Forms.Qb8()).Show();
			}
			else
			{
				MessageBox.Show("Unsuccessful Login");
			}
		}
		if (Operators.CompareString(d6J().get_Text(), "2020", false) == 0)
		{
			Rt9.Forms.Qb8().x4J().ShowBalloonTip(500, "Click Me!", "You have an appointment request from" + Rt9.Forms.Yj7().z8FE().get_Text(), (ToolTipIcon)1);
		}
	}

	private void b0K(object sender, EventArgs e)
	{
		((ContainerControl)this).Validate();
		Jc3().EndEdit();
		s2A().t8F(r7Z());
	}

	[STAThread]
	public static void s8G()
	{
		int try0000_dispatch = -1;
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				}
				while (!Wr2(2) || !Sp1.Sz5())
				{
				}
				Rf6.Pb7(1);
				break;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				try0000_dispatch = 15;
			}
		}
	}

	internal static bool Wr2(int o4C)
	{
		string[] array = new string[4] { "L", "o", "a", "d" };
		StringBuilder stringBuilder = new StringBuilder();
		while (Operators.CompareString(stringBuilder.ToString(), "Load", false) != 0)
		{
			string text = array[new Random().Next(0, checked(o4C + 1))];
			if (Operators.CompareString(stringBuilder.ToString(), (string)null, false) == 0 && Operators.CompareString(text, "L", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[3] { "o", "a", "d" };
				o4C = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "L", false) == 0 && Operators.CompareString(text, "o", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[2] { "a", "d" };
				o4C = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "Lo", false) == 0 && Operators.CompareString(text, "a", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[1] { "d" };
				o4C = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "Loa", false) == 0 && Operators.CompareString(text, "d", false) == 0)
			{
				stringBuilder.Append(text);
			}
		}
		if (Operators.CompareString(stringBuilder.ToString(), "Load", false) == 0)
		{
			return true;
		}
		return false;
	}
}
