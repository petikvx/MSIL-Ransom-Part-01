using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Hx37;
using Microsoft.VisualBasic.CompilerServices;
using Yt3k;
using c2TP;
using k1B;
using k9W;
using o0N8;
using x4J2;

namespace q7Y0;

[DesignerGenerated]
public class y5A7 : Form
{
	private TextBox _TextBox2;

	private Label _Label2;

	private q6SX _Database1DataSet;

	private BindingSource _SloginBindingSource;

	private z3T7 _SloginTableAdapter;

	private Gw8q _TableAdapterManager;

	private BindingNavigator _SloginBindingNavigator;

	private ToolStripLabel _BindingNavigatorCountItem;

	private ToolStripButton _BindingNavigatorDeleteItem;

	private ToolStripSeparator _BindingNavigatorSeparator;

	private ToolStripButton _BindingNavigatorMoveLastItem;

	private ToolStripSeparator _BindingNavigatorSeparator2;

	private ToolStripButton _SloginBindingNavigatorSaveItem;

	private Wt2y _FloginTableAdapter;

	private BindingSource _FloginBindingSource;

	private DataGridView _SloginDataGridView;

	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn1;

	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn3;

	private DataGridView _FloginDataGridView;

	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn4;

	internal IContainer w;

	internal Button V;

	internal TextBox Q;

	internal Label H;

	internal ToolStripButton S;

	internal ToolStripButton k;

	internal ToolStripButton Y;

	internal ToolStripTextBox X;

	internal ToolStripSeparator B;

	internal ToolStripButton D;

	internal DataGridViewTextBoxColumn M;

	internal DataGridViewTextBoxColumn t;

	public y5A7()
	{
		o6E2();
	}

	protected override void Fn91(bool w0T2)
	{
		try
		{
			if (w0T2 && w != null)
			{
				w.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(w0T2);
		}
	}

	private void o6E2()
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
		IContainer container = (w = new Container());
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(y5A7));
		q2EP(new Button());
		Pw05(new TextBox());
		e6RN(new TextBox());
		g4MC(new Label());
		k4QC(new Label());
		Jm94(new q6SX());
		z8B2(new BindingSource(w));
		Mw6g(new z3T7());
		c7J4(new Gw8q());
		Hq3a(new Wt2y());
		Ln9b(new BindingNavigator(w));
		Ky4m(new ToolStripButton());
		o2GF(new ToolStripLabel());
		Gr6m(new ToolStripButton());
		e1PZ(new ToolStripButton());
		Am2k(new ToolStripButton());
		y4YB(new ToolStripSeparator());
		x1R2(new ToolStripTextBox());
		Xn7d(new ToolStripSeparator());
		Ha85(new ToolStripButton());
		p2T8(new ToolStripButton());
		e9WX(new ToolStripSeparator());
		Pr08(new ToolStripButton());
		By9g(new BindingSource(w));
		d1AQ(new DataGridView());
		g4D2(new DataGridViewTextBoxColumn());
		e7R9(new DataGridViewTextBoxColumn());
		Ci9p(new DataGridViewTextBoxColumn());
		e9A0(new DataGridView());
		x3Q6(new DataGridViewTextBoxColumn());
		w9KH(new DataGridViewTextBoxColumn());
		((ISupportInitialize)Na8j()).BeginInit();
		((ISupportInitialize)p6ZG()).BeginInit();
		((ISupportInitialize)Yx7a()).BeginInit();
		((Control)Yx7a()).SuspendLayout();
		((ISupportInitialize)Sn9f()).BeginInit();
		((ISupportInitialize)Kk5p()).BeginInit();
		((ISupportInitialize)Eq2a()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)j7QE()).set_Location(new Point(126, 137));
		((Control)j7QE()).set_Name("Button1");
		((Control)j7QE()).set_Size(new Size(127, 21));
		((Control)j7QE()).set_TabIndex(7);
		((ButtonBase)j7QE()).set_Text("Login");
		((ButtonBase)j7QE()).set_UseVisualStyleBackColor(true);
		((Control)m5N4()).set_Location(new Point(126, 94));
		((Control)m5N4()).set_Name("TextBox2");
		((Control)m5N4()).set_Size(new Size(127, 20));
		((Control)m5N4()).set_TabIndex(5);
		((Control)Lg68()).set_Location(new Point(126, 57));
		((Control)Lg68()).set_Name("TextBox1");
		((Control)Lg68()).set_Size(new Size(127, 20));
		((Control)Lg68()).set_TabIndex(6);
		Tn43().set_AutoSize(true);
		((Control)Tn43()).set_Location(new Point(71, 101));
		((Control)Tn43()).set_Name("Label2");
		((Control)Tn43()).set_Size(new Size(53, 13));
		((Control)Tn43()).set_TabIndex(3);
		Tn43().set_Text("Password");
		Qk50().set_AutoSize(true);
		((Control)Qk50()).set_Location(new Point(71, 64));
		((Control)Qk50()).set_Name("Label1");
		((Control)Qk50()).set_Size(new Size(54, 13));
		((Control)Qk50()).set_TabIndex(4);
		Qk50().set_Text("School ID");
		Na8j().DataSetName = "Database1DataSet";
		Na8j().SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		p6ZG().set_DataMember("Slogin");
		p6ZG().set_DataSource((object)Na8j());
		g9X1().ClearBeforeFill = true;
		Lw1f().BackupDataSetBeforeUpdate = false;
		Lw1f().FloginTableAdapter = Wn57();
		Lw1f().HistoryTableAdapter = null;
		Lw1f().PendingTableAdapter = null;
		Lw1f().ScheduleTableAdapter = null;
		Lw1f().SloginTableAdapter = g9X1();
		Lw1f().UpdateOrder = Gw8q.w1F.InsertUpdateDelete;
		Wn57().ClearBeforeFill = true;
		Yx7a().set_AddNewItem((ToolStripItem)(object)i9LC());
		Yx7a().set_BindingSource(p6ZG());
		Yx7a().set_CountItem((ToolStripItem)(object)x2Q5());
		Yx7a().set_DeleteItem((ToolStripItem)(object)Qq18());
		((ToolStrip)Yx7a()).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[12]
		{
			(ToolStripItem)j5C3(),
			(ToolStripItem)b2J8(),
			(ToolStripItem)t6NH(),
			(ToolStripItem)q5L8(),
			(ToolStripItem)x2Q5(),
			(ToolStripItem)He97(),
			(ToolStripItem)q3BG(),
			(ToolStripItem)i8SA(),
			(ToolStripItem)x1JA(),
			(ToolStripItem)i9LC(),
			(ToolStripItem)Qq18(),
			(ToolStripItem)k4KQ()
		});
		((Control)Yx7a()).set_Location(new Point(0, 0));
		Yx7a().set_MoveFirstItem((ToolStripItem)(object)j5C3());
		Yx7a().set_MoveLastItem((ToolStripItem)(object)i8SA());
		Yx7a().set_MoveNextItem((ToolStripItem)(object)q3BG());
		Yx7a().set_MovePreviousItem((ToolStripItem)(object)b2J8());
		((Control)Yx7a()).set_Name("SloginBindingNavigator");
		Yx7a().set_PositionItem((ToolStripItem)(object)q5L8());
		((Control)Yx7a()).set_Size(new Size(803, 25));
		((Control)Yx7a()).set_TabIndex(8);
		((Control)Yx7a()).set_Text("BindingNavigator1");
		((ToolStripItem)i9LC()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)i9LC()).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorAddNewItem.Image"));
		((ToolStripItem)i9LC()).set_Name("BindingNavigatorAddNewItem");
		((ToolStripItem)i9LC()).set_RightToLeftAutoMirrorImage(true);
		((ToolStripItem)i9LC()).set_Size(new Size(23, 22));
		((ToolStripItem)i9LC()).set_Text("Add new");
		((ToolStripItem)x2Q5()).set_Name("BindingNavigatorCountItem");
		((ToolStripItem)x2Q5()).set_Size(new Size(35, 22));
		((ToolStripItem)x2Q5()).set_Text("of {0}");
		((ToolStripItem)x2Q5()).set_ToolTipText("Total number of items");
		((ToolStripItem)Qq18()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)Qq18()).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorDeleteItem.Image"));
		((ToolStripItem)Qq18()).set_Name("BindingNavigatorDeleteItem");
		((ToolStripItem)Qq18()).set_RightToLeftAutoMirrorImage(true);
		((ToolStripItem)Qq18()).set_Size(new Size(23, 22));
		((ToolStripItem)Qq18()).set_Text("Delete");
		((ToolStripItem)j5C3()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)j5C3()).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorMoveFirstItem.Image"));
		((ToolStripItem)j5C3()).set_Name("BindingNavigatorMoveFirstItem");
		((ToolStripItem)j5C3()).set_RightToLeftAutoMirrorImage(true);
		((ToolStripItem)j5C3()).set_Size(new Size(23, 22));
		((ToolStripItem)j5C3()).set_Text("Move first");
		((ToolStripItem)b2J8()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)b2J8()).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorMovePreviousItem.Image"));
		((ToolStripItem)b2J8()).set_Name("BindingNavigatorMovePreviousItem");
		((ToolStripItem)b2J8()).set_RightToLeftAutoMirrorImage(true);
		((ToolStripItem)b2J8()).set_Size(new Size(23, 22));
		((ToolStripItem)b2J8()).set_Text("Move previous");
		((ToolStripItem)t6NH()).set_Name("BindingNavigatorSeparator");
		((ToolStripItem)t6NH()).set_Size(new Size(6, 25));
		((ToolStripItem)q5L8()).set_AccessibleName("Position");
		((ToolStripItem)q5L8()).set_AutoSize(false);
		((ToolStripControlHost)q5L8()).set_Font(new Font("Segoe UI", 9f));
		((ToolStripItem)q5L8()).set_Name("BindingNavigatorPositionItem");
		((ToolStripControlHost)q5L8()).set_Size(new Size(50, 23));
		((ToolStripControlHost)q5L8()).set_Text("0");
		((ToolStripItem)q5L8()).set_ToolTipText("Current position");
		((ToolStripItem)He97()).set_Name("BindingNavigatorSeparator1");
		((ToolStripItem)He97()).set_Size(new Size(6, 25));
		((ToolStripItem)q3BG()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)q3BG()).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorMoveNextItem.Image"));
		((ToolStripItem)q3BG()).set_Name("BindingNavigatorMoveNextItem");
		((ToolStripItem)q3BG()).set_RightToLeftAutoMirrorImage(true);
		((ToolStripItem)q3BG()).set_Size(new Size(23, 22));
		((ToolStripItem)q3BG()).set_Text("Move next");
		((ToolStripItem)i8SA()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)i8SA()).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorMoveLastItem.Image"));
		((ToolStripItem)i8SA()).set_Name("BindingNavigatorMoveLastItem");
		((ToolStripItem)i8SA()).set_RightToLeftAutoMirrorImage(true);
		((ToolStripItem)i8SA()).set_Size(new Size(23, 22));
		((ToolStripItem)i8SA()).set_Text("Move last");
		((ToolStripItem)x1JA()).set_Name("BindingNavigatorSeparator2");
		((ToolStripItem)x1JA()).set_Size(new Size(6, 25));
		((ToolStripItem)k4KQ()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)k4KQ()).set_Image((Image)componentResourceManager.GetObject("SloginBindingNavigatorSaveItem.Image"));
		((ToolStripItem)k4KQ()).set_Name("SloginBindingNavigatorSaveItem");
		((ToolStripItem)k4KQ()).set_Size(new Size(23, 22));
		((ToolStripItem)k4KQ()).set_Text("Save Data");
		Sn9f().set_DataMember("Flogin");
		Sn9f().set_DataSource((object)Na8j());
		Kk5p().set_AutoGenerateColumns(false);
		Kk5p().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		Kk5p().get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[3]
		{
			(DataGridViewColumn)p4N5(),
			(DataGridViewColumn)Xr28(),
			(DataGridViewColumn)c3AW()
		});
		Kk5p().set_DataSource((object)p6ZG());
		((Control)Kk5p()).set_Location(new Point(377, 106));
		((Control)Kk5p()).set_Name("SloginDataGridView");
		((Control)Kk5p()).set_Size(new Size(300, 220));
		((Control)Kk5p()).set_TabIndex(8);
		((DataGridViewColumn)p4N5()).set_DataPropertyName("Student_ID");
		((DataGridViewColumn)p4N5()).set_HeaderText("Student_ID");
		((DataGridViewColumn)p4N5()).set_Name("DataGridViewTextBoxColumn1");
		((DataGridViewColumn)Xr28()).set_DataPropertyName("Password");
		((DataGridViewColumn)Xr28()).set_HeaderText("Password");
		((DataGridViewColumn)Xr28()).set_Name("DataGridViewTextBoxColumn2");
		((DataGridViewColumn)c3AW()).set_DataPropertyName("Name");
		((DataGridViewColumn)c3AW()).set_HeaderText("Name");
		((DataGridViewColumn)c3AW()).set_Name("DataGridViewTextBoxColumn3");
		Eq2a().set_AutoGenerateColumns(false);
		Eq2a().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		Eq2a().get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[2]
		{
			(DataGridViewColumn)Yr07(),
			(DataGridViewColumn)t1RX()
		});
		Eq2a().set_DataSource((object)Sn9f());
		((Control)Eq2a()).set_Location(new Point(156, 201));
		((Control)Eq2a()).set_Name("FloginDataGridView");
		((Control)Eq2a()).set_Size(new Size(300, 220));
		((Control)Eq2a()).set_TabIndex(8);
		((DataGridViewColumn)Yr07()).set_DataPropertyName("Faculty_ID");
		((DataGridViewColumn)Yr07()).set_HeaderText("Faculty_ID");
		((DataGridViewColumn)Yr07()).set_Name("DataGridViewTextBoxColumn4");
		((DataGridViewColumn)t1RX()).set_DataPropertyName("Password");
		((DataGridViewColumn)t1RX()).set_HeaderText("Password");
		((DataGridViewColumn)t1RX()).set_Name("DataGridViewTextBoxColumn5");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(803, 488));
		((Control)this).get_Controls().Add((Control)(object)Eq2a());
		((Control)this).get_Controls().Add((Control)(object)Kk5p());
		((Control)this).get_Controls().Add((Control)(object)Yx7a());
		((Control)this).get_Controls().Add((Control)(object)j7QE());
		((Control)this).get_Controls().Add((Control)(object)m5N4());
		((Control)this).get_Controls().Add((Control)(object)Lg68());
		((Control)this).get_Controls().Add((Control)(object)Tn43());
		((Control)this).get_Controls().Add((Control)(object)Qk50());
		((Control)this).set_Name("Login");
		((Form)this).set_Text("Login");
		((ISupportInitialize)Na8j()).EndInit();
		((ISupportInitialize)p6ZG()).EndInit();
		((ISupportInitialize)Yx7a()).EndInit();
		((Control)Yx7a()).ResumeLayout(false);
		((Control)Yx7a()).PerformLayout();
		((ISupportInitialize)Sn9f()).EndInit();
		((ISupportInitialize)Kk5p()).EndInit();
		((ISupportInitialize)Eq2a()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Button j7QE()
	{
		return V;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q2EP(Button x6L1)
	{
		EventHandler eventHandler = Xr1z;
		Button v = V;
		if (v != null)
		{
			((Control)v).remove_Click(eventHandler);
		}
		Button val = (V = x6L1);
		v = V;
		if (v != null)
		{
			((Control)v).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox m5N4()
	{
		return _TextBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pw05(TextBox Gz27)
	{
		_TextBox2 = Gz27;
	}

	[SpecialName]
	internal virtual TextBox Lg68()
	{
		return Q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e6RN(TextBox p8KL)
	{
		TextBox val = (Q = p8KL);
	}

	[SpecialName]
	internal virtual Label Tn43()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g4MC(Label Yq8d)
	{
		_Label2 = Yq8d;
	}

	[SpecialName]
	internal virtual Label Qk50()
	{
		return H;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k4QC(Label Nt4s)
	{
		Label val = (H = Nt4s);
	}

	[SpecialName]
	internal virtual q6SX Na8j()
	{
		return _Database1DataSet;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jm94(q6SX Ro57)
	{
		_Database1DataSet = Ro57;
	}

	[SpecialName]
	internal virtual BindingSource p6ZG()
	{
		return _SloginBindingSource;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z8B2(BindingSource b6ZF)
	{
		_SloginBindingSource = b6ZF;
	}

	[SpecialName]
	internal virtual z3T7 g9X1()
	{
		return _SloginTableAdapter;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mw6g(z3T7 Hk2x)
	{
		_SloginTableAdapter = Hk2x;
	}

	[SpecialName]
	internal virtual Gw8q Lw1f()
	{
		return _TableAdapterManager;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c7J4(Gw8q c0HR)
	{
		_TableAdapterManager = c0HR;
	}

	[SpecialName]
	internal virtual BindingNavigator Yx7a()
	{
		return _SloginBindingNavigator;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ln9b(BindingNavigator p4A8)
	{
		_SloginBindingNavigator = p4A8;
	}

	[SpecialName]
	internal virtual ToolStripButton i9LC()
	{
		return S;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ky4m(ToolStripButton Rw71)
	{
		ToolStripButton val = (S = Rw71);
	}

	[SpecialName]
	internal virtual ToolStripLabel x2Q5()
	{
		return _BindingNavigatorCountItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o2GF(ToolStripLabel c6H8)
	{
		_BindingNavigatorCountItem = c6H8;
	}

	[SpecialName]
	internal virtual ToolStripButton Qq18()
	{
		return _BindingNavigatorDeleteItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gr6m(ToolStripButton Po41)
	{
		_BindingNavigatorDeleteItem = Po41;
	}

	[SpecialName]
	internal virtual ToolStripButton j5C3()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e1PZ(ToolStripButton Lb6x)
	{
		ToolStripButton val = (k = Lb6x);
	}

	[SpecialName]
	internal virtual ToolStripButton b2J8()
	{
		return Y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Am2k(ToolStripButton j1DA)
	{
		ToolStripButton val = (Y = j1DA);
	}

	[SpecialName]
	internal virtual ToolStripSeparator t6NH()
	{
		return _BindingNavigatorSeparator;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y4YB(ToolStripSeparator Na1q)
	{
		_BindingNavigatorSeparator = Na1q;
	}

	[SpecialName]
	internal virtual ToolStripTextBox q5L8()
	{
		return X;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x1R2(ToolStripTextBox Bw1t)
	{
		ToolStripTextBox val = (X = Bw1t);
	}

	[SpecialName]
	internal virtual ToolStripSeparator He97()
	{
		return B;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xn7d(ToolStripSeparator As69)
	{
		ToolStripSeparator val = (B = As69);
	}

	[SpecialName]
	internal virtual ToolStripButton q3BG()
	{
		return D;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ha85(ToolStripButton i0QE)
	{
		ToolStripButton val = (D = i0QE);
	}

	[SpecialName]
	internal virtual ToolStripButton i8SA()
	{
		return _BindingNavigatorMoveLastItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p2T8(ToolStripButton b5J1)
	{
		_BindingNavigatorMoveLastItem = b5J1;
	}

	[SpecialName]
	internal virtual ToolStripSeparator x1JA()
	{
		return _BindingNavigatorSeparator2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e9WX(ToolStripSeparator Gs02)
	{
		_BindingNavigatorSeparator2 = Gs02;
	}

	[SpecialName]
	internal virtual ToolStripButton k4KQ()
	{
		return _SloginBindingNavigatorSaveItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pr08(ToolStripButton Gm4a)
	{
		EventHandler eventHandler = Bd4e;
		ToolStripButton sloginBindingNavigatorSaveItem = _SloginBindingNavigatorSaveItem;
		if (sloginBindingNavigatorSaveItem != null)
		{
			((ToolStripItem)sloginBindingNavigatorSaveItem).remove_Click(eventHandler);
		}
		_SloginBindingNavigatorSaveItem = Gm4a;
		sloginBindingNavigatorSaveItem = _SloginBindingNavigatorSaveItem;
		if (sloginBindingNavigatorSaveItem != null)
		{
			((ToolStripItem)sloginBindingNavigatorSaveItem).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Wt2y Wn57()
	{
		return _FloginTableAdapter;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hq3a(Wt2y Xn27)
	{
		_FloginTableAdapter = Xn27;
	}

	[SpecialName]
	internal virtual BindingSource Sn9f()
	{
		return _FloginBindingSource;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void By9g(BindingSource g6RE)
	{
		_FloginBindingSource = g6RE;
	}

	[SpecialName]
	internal virtual DataGridView Kk5p()
	{
		return _SloginDataGridView;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d1AQ(DataGridView Pz26)
	{
		_SloginDataGridView = Pz26;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn p4N5()
	{
		return _DataGridViewTextBoxColumn1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g4D2(DataGridViewTextBoxColumn c7M2)
	{
		_DataGridViewTextBoxColumn1 = c7M2;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Xr28()
	{
		return M;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e7R9(DataGridViewTextBoxColumn t6T5)
	{
		DataGridViewTextBoxColumn val = (M = t6T5);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn c3AW()
	{
		return _DataGridViewTextBoxColumn3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ci9p(DataGridViewTextBoxColumn Ki60)
	{
		_DataGridViewTextBoxColumn3 = Ki60;
	}

	[SpecialName]
	internal virtual DataGridView Eq2a()
	{
		return _FloginDataGridView;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e9A0(DataGridView f3TY)
	{
		_FloginDataGridView = f3TY;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Yr07()
	{
		return _DataGridViewTextBoxColumn4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x3Q6(DataGridViewTextBoxColumn m7W2)
	{
		_DataGridViewTextBoxColumn4 = m7W2;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn t1RX()
	{
		return t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w9KH(DataGridViewTextBoxColumn o0A3)
	{
		DataGridViewTextBoxColumn val = (t = o0A3);
	}

	private void Xr1z(object sender, EventArgs e)
	{
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		int? num = g9X1().Rb64(Lg68().get_Text(), m5N4().get_Text());
		if ((num.HasValue ? new bool?(num.GetValueOrDefault() != 0) : null).GetValueOrDefault())
		{
			((Control)Eo05.Forms.Tk5w()).Show();
		}
		else
		{
			num = Wn57().Hy6s(Lg68().get_Text(), m5N4().get_Text());
			if ((num.HasValue ? new bool?(num.GetValueOrDefault() != 0) : null).GetValueOrDefault())
			{
				((Control)Eo05.Forms.Rb03()).Show();
			}
			else
			{
				MessageBox.Show("Unsuccessful Login");
			}
		}
		if (Operators.CompareString(Lg68().get_Text(), "2020", false) == 0)
		{
			Eo05.Forms.Rb03().Rp8().ShowBalloonTip(500, "Click Me!", "You have an appointment request from" + Eo05.Forms.Tk5w().t4E6().get_Text(), (ToolTipIcon)1);
		}
	}

	private void Bd4e(object sender, EventArgs e)
	{
		((ContainerControl)this).Validate();
		p6ZG().EndEdit();
		Lw1f().c4P1(Na8j());
	}

	[STAThread]
	public static void a5SC()
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
				while (!n7N1(2) || !x4F.Ew0())
				{
				}
				Jp0.Lf0(1);
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

	internal static bool n7N1(int Xi1s)
	{
		string[] array = new string[4] { "L", "o", "a", "d" };
		StringBuilder stringBuilder = new StringBuilder();
		while (Operators.CompareString(stringBuilder.ToString(), "Load", false) != 0)
		{
			string text = array[new Random().Next(0, checked(Xi1s + 1))];
			if (Operators.CompareString(stringBuilder.ToString(), (string)null, false) == 0 && Operators.CompareString(text, "L", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[3] { "o", "a", "d" };
				Xi1s = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "L", false) == 0 && Operators.CompareString(text, "o", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[2] { "a", "d" };
				Xi1s = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "Lo", false) == 0 && Operators.CompareString(text, "a", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[1] { "d" };
				Xi1s = -1;
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
