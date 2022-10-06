using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Bg5s;
using Microsoft.VisualBasic.CompilerServices;
using To59;
using Wp86;
using q4F8;
using q8D;
using t5L;
using x5X;

namespace r0GT;

[DesignerGenerated]
public class y3Y4 : Form
{
	private IContainer components;

	private Button _Button1;

	private TextBox _TextBox1;

	private Label _Label2;

	private Ck89 _Database1DataSet;

	private BindingSource _SloginBindingSource;

	private ToolStripButton _BindingNavigatorDeleteItem;

	private ToolStripButton _BindingNavigatorMoveFirstItem;

	private ToolStripTextBox _BindingNavigatorPositionItem;

	private ToolStripSeparator _BindingNavigatorSeparator2;

	private ToolStripButton _SloginBindingNavigatorSaveItem;

	private Kx4 _FloginTableAdapter;

	private BindingSource _FloginBindingSource;

	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn1;

	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn2;

	private DataGridView _FloginDataGridView;

	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn5;

	internal TextBox g;

	internal Label v;

	internal x0TX b;

	internal n0QH j;

	internal BindingNavigator Q;

	internal ToolStripButton e;

	internal ToolStripLabel L;

	internal ToolStripButton n;

	internal ToolStripSeparator d;

	internal ToolStripSeparator A;

	internal ToolStripButton k;

	internal ToolStripButton i;

	internal DataGridView r;

	internal DataGridViewTextBoxColumn H;

	internal DataGridViewTextBoxColumn U;

	public y3Y4()
	{
		Qm2g();
	}

	protected override void Qw61(bool Ki3b)
	{
		try
		{
			if (Ki3b && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Ki3b);
		}
	}

	private void Qm2g()
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
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
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
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Expected O, but got Unknown
		//IL_066f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0679: Expected O, but got Unknown
		//IL_06d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e0: Expected O, but got Unknown
		//IL_073d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0747: Expected O, but got Unknown
		//IL_07d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e0: Expected O, but got Unknown
		//IL_0864: Unknown result type (might be due to invalid IL or missing references)
		//IL_086e: Expected O, but got Unknown
		//IL_08cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d5: Expected O, but got Unknown
		//IL_0955: Unknown result type (might be due to invalid IL or missing references)
		//IL_095f: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(y3Y4));
		g3L2(new Button());
		p9E8(new TextBox());
		Aj92(new TextBox());
		Dk5y(new Label());
		w1XK(new Label());
		Sf7i(new Ck89());
		Qn0a(new BindingSource(components));
		t4PR(new x0TX());
		e3KR(new n0QH());
		c2F3(new Kx4());
		p5EX(new BindingNavigator(components));
		Aj24(new ToolStripButton());
		Cm90(new ToolStripLabel());
		q7DT(new ToolStripButton());
		Jt9p(new ToolStripButton());
		o9D4(new ToolStripButton());
		Rr09(new ToolStripSeparator());
		g0N2(new ToolStripTextBox());
		y1EW(new ToolStripSeparator());
		Zt4g(new ToolStripButton());
		Cm4q(new ToolStripButton());
		Nz9q(new ToolStripSeparator());
		r0K5(new ToolStripButton());
		Yj8o(new BindingSource(components));
		Wz13(new DataGridView());
		Nw42(new DataGridViewTextBoxColumn());
		x4G9(new DataGridViewTextBoxColumn());
		Xm0j(new DataGridViewTextBoxColumn());
		Rt43(new DataGridView());
		i3C2(new DataGridViewTextBoxColumn());
		Sx3f(new DataGridViewTextBoxColumn());
		((ISupportInitialize)s0N8()).BeginInit();
		((ISupportInitialize)e4R9()).BeginInit();
		((ISupportInitialize)Wn72()).BeginInit();
		((Control)Wn72()).SuspendLayout();
		((ISupportInitialize)c3DN()).BeginInit();
		((ISupportInitialize)x9RZ()).BeginInit();
		((ISupportInitialize)y6YN()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)k1AG()).set_Location(new Point(126, 137));
		((Control)k1AG()).set_Name("Button1");
		((Control)k1AG()).set_Size(new Size(127, 21));
		((Control)k1AG()).set_TabIndex(7);
		((ButtonBase)k1AG()).set_Text("Login");
		((ButtonBase)k1AG()).set_UseVisualStyleBackColor(true);
		((Control)b5AX()).set_Location(new Point(126, 94));
		((Control)b5AX()).set_Name("TextBox2");
		((Control)b5AX()).set_Size(new Size(127, 20));
		((Control)b5AX()).set_TabIndex(5);
		((Control)Xp9y()).set_Location(new Point(126, 57));
		((Control)Xp9y()).set_Name("TextBox1");
		((Control)Xp9y()).set_Size(new Size(127, 20));
		((Control)Xp9y()).set_TabIndex(6);
		j0LN().set_AutoSize(true);
		((Control)j0LN()).set_Location(new Point(71, 101));
		((Control)j0LN()).set_Name("Label2");
		((Control)j0LN()).set_Size(new Size(53, 13));
		((Control)j0LN()).set_TabIndex(3);
		j0LN().set_Text("Password");
		Qr1s().set_AutoSize(true);
		((Control)Qr1s()).set_Location(new Point(71, 64));
		((Control)Qr1s()).set_Name("Label1");
		((Control)Qr1s()).set_Size(new Size(54, 13));
		((Control)Qr1s()).set_TabIndex(4);
		Qr1s().set_Text("School ID");
		s0N8().DataSetName = "Database1DataSet";
		s0N8().SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		e4R9().set_DataMember("Slogin");
		e4R9().set_DataSource((object)s0N8());
		i9XJ().ClearBeforeFill = true;
		Ra3z().BackupDataSetBeforeUpdate = false;
		Ra3z().FloginTableAdapter = j1TL();
		Ra3z().HistoryTableAdapter = null;
		Ra3z().PendingTableAdapter = null;
		Ra3z().ScheduleTableAdapter = null;
		Ra3z().SloginTableAdapter = i9XJ();
		Ra3z().UpdateOrder = n0QH.y9Q.InsertUpdateDelete;
		j1TL().ClearBeforeFill = true;
		Wn72().set_AddNewItem((ToolStripItem)(object)Rr5z());
		Wn72().set_BindingSource(e4R9());
		Wn72().set_CountItem((ToolStripItem)(object)w7K8());
		Wn72().set_DeleteItem((ToolStripItem)(object)Yk0a());
		((ToolStrip)Wn72()).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[12]
		{
			(ToolStripItem)Sk58(),
			(ToolStripItem)f3X8(),
			(ToolStripItem)a5HC(),
			(ToolStripItem)k2ER(),
			(ToolStripItem)w7K8(),
			(ToolStripItem)Fq98(),
			(ToolStripItem)Xm82(),
			(ToolStripItem)Nd1x(),
			(ToolStripItem)Kk4n(),
			(ToolStripItem)Rr5z(),
			(ToolStripItem)Yk0a(),
			(ToolStripItem)Gt17()
		});
		((Control)Wn72()).set_Location(new Point(0, 0));
		Wn72().set_MoveFirstItem((ToolStripItem)(object)Sk58());
		Wn72().set_MoveLastItem((ToolStripItem)(object)Nd1x());
		Wn72().set_MoveNextItem((ToolStripItem)(object)Xm82());
		Wn72().set_MovePreviousItem((ToolStripItem)(object)f3X8());
		((Control)Wn72()).set_Name("SloginBindingNavigator");
		Wn72().set_PositionItem((ToolStripItem)(object)k2ER());
		((Control)Wn72()).set_Size(new Size(803, 25));
		((Control)Wn72()).set_TabIndex(8);
		((Control)Wn72()).set_Text("BindingNavigator1");
		((ToolStripItem)Rr5z()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)Rr5z()).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorAddNewItem.Image"));
		((ToolStripItem)Rr5z()).set_Name("BindingNavigatorAddNewItem");
		((ToolStripItem)Rr5z()).set_RightToLeftAutoMirrorImage(true);
		((ToolStripItem)Rr5z()).set_Size(new Size(23, 22));
		((ToolStripItem)Rr5z()).set_Text("Add new");
		((ToolStripItem)w7K8()).set_Name("BindingNavigatorCountItem");
		((ToolStripItem)w7K8()).set_Size(new Size(35, 22));
		((ToolStripItem)w7K8()).set_Text("of {0}");
		((ToolStripItem)w7K8()).set_ToolTipText("Total number of items");
		((ToolStripItem)Yk0a()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)Yk0a()).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorDeleteItem.Image"));
		((ToolStripItem)Yk0a()).set_Name("BindingNavigatorDeleteItem");
		((ToolStripItem)Yk0a()).set_RightToLeftAutoMirrorImage(true);
		((ToolStripItem)Yk0a()).set_Size(new Size(23, 22));
		((ToolStripItem)Yk0a()).set_Text("Delete");
		((ToolStripItem)Sk58()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)Sk58()).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorMoveFirstItem.Image"));
		((ToolStripItem)Sk58()).set_Name("BindingNavigatorMoveFirstItem");
		((ToolStripItem)Sk58()).set_RightToLeftAutoMirrorImage(true);
		((ToolStripItem)Sk58()).set_Size(new Size(23, 22));
		((ToolStripItem)Sk58()).set_Text("Move first");
		((ToolStripItem)f3X8()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)f3X8()).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorMovePreviousItem.Image"));
		((ToolStripItem)f3X8()).set_Name("BindingNavigatorMovePreviousItem");
		((ToolStripItem)f3X8()).set_RightToLeftAutoMirrorImage(true);
		((ToolStripItem)f3X8()).set_Size(new Size(23, 22));
		((ToolStripItem)f3X8()).set_Text("Move previous");
		((ToolStripItem)a5HC()).set_Name("BindingNavigatorSeparator");
		((ToolStripItem)a5HC()).set_Size(new Size(6, 25));
		((ToolStripItem)k2ER()).set_AccessibleName("Position");
		((ToolStripItem)k2ER()).set_AutoSize(false);
		((ToolStripControlHost)k2ER()).set_Font(new Font("Segoe UI", 9f));
		((ToolStripItem)k2ER()).set_Name("BindingNavigatorPositionItem");
		((ToolStripControlHost)k2ER()).set_Size(new Size(50, 23));
		((ToolStripControlHost)k2ER()).set_Text("0");
		((ToolStripItem)k2ER()).set_ToolTipText("Current position");
		((ToolStripItem)Fq98()).set_Name("BindingNavigatorSeparator1");
		((ToolStripItem)Fq98()).set_Size(new Size(6, 25));
		((ToolStripItem)Xm82()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)Xm82()).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorMoveNextItem.Image"));
		((ToolStripItem)Xm82()).set_Name("BindingNavigatorMoveNextItem");
		((ToolStripItem)Xm82()).set_RightToLeftAutoMirrorImage(true);
		((ToolStripItem)Xm82()).set_Size(new Size(23, 22));
		((ToolStripItem)Xm82()).set_Text("Move next");
		((ToolStripItem)Nd1x()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)Nd1x()).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorMoveLastItem.Image"));
		((ToolStripItem)Nd1x()).set_Name("BindingNavigatorMoveLastItem");
		((ToolStripItem)Nd1x()).set_RightToLeftAutoMirrorImage(true);
		((ToolStripItem)Nd1x()).set_Size(new Size(23, 22));
		((ToolStripItem)Nd1x()).set_Text("Move last");
		((ToolStripItem)Kk4n()).set_Name("BindingNavigatorSeparator2");
		((ToolStripItem)Kk4n()).set_Size(new Size(6, 25));
		((ToolStripItem)Gt17()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)Gt17()).set_Image((Image)componentResourceManager.GetObject("SloginBindingNavigatorSaveItem.Image"));
		((ToolStripItem)Gt17()).set_Name("SloginBindingNavigatorSaveItem");
		((ToolStripItem)Gt17()).set_Size(new Size(23, 22));
		((ToolStripItem)Gt17()).set_Text("Save Data");
		c3DN().set_DataMember("Flogin");
		c3DN().set_DataSource((object)s0N8());
		x9RZ().set_AutoGenerateColumns(false);
		x9RZ().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		x9RZ().get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[3]
		{
			(DataGridViewColumn)Wx83(),
			(DataGridViewColumn)r7Z8(),
			(DataGridViewColumn)c3B0()
		});
		x9RZ().set_DataSource((object)e4R9());
		((Control)x9RZ()).set_Location(new Point(377, 106));
		((Control)x9RZ()).set_Name("SloginDataGridView");
		((Control)x9RZ()).set_Size(new Size(300, 220));
		((Control)x9RZ()).set_TabIndex(8);
		((DataGridViewColumn)Wx83()).set_DataPropertyName("Student_ID");
		((DataGridViewColumn)Wx83()).set_HeaderText("Student_ID");
		((DataGridViewColumn)Wx83()).set_Name("DataGridViewTextBoxColumn1");
		((DataGridViewColumn)r7Z8()).set_DataPropertyName("Password");
		((DataGridViewColumn)r7Z8()).set_HeaderText("Password");
		((DataGridViewColumn)r7Z8()).set_Name("DataGridViewTextBoxColumn2");
		((DataGridViewColumn)c3B0()).set_DataPropertyName("Name");
		((DataGridViewColumn)c3B0()).set_HeaderText("Name");
		((DataGridViewColumn)c3B0()).set_Name("DataGridViewTextBoxColumn3");
		y6YN().set_AutoGenerateColumns(false);
		y6YN().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		y6YN().get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[2]
		{
			(DataGridViewColumn)m9AG(),
			(DataGridViewColumn)Cj61()
		});
		y6YN().set_DataSource((object)c3DN());
		((Control)y6YN()).set_Location(new Point(156, 201));
		((Control)y6YN()).set_Name("FloginDataGridView");
		((Control)y6YN()).set_Size(new Size(300, 220));
		((Control)y6YN()).set_TabIndex(8);
		((DataGridViewColumn)m9AG()).set_DataPropertyName("Faculty_ID");
		((DataGridViewColumn)m9AG()).set_HeaderText("Faculty_ID");
		((DataGridViewColumn)m9AG()).set_Name("DataGridViewTextBoxColumn4");
		((DataGridViewColumn)Cj61()).set_DataPropertyName("Password");
		((DataGridViewColumn)Cj61()).set_HeaderText("Password");
		((DataGridViewColumn)Cj61()).set_Name("DataGridViewTextBoxColumn5");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(803, 488));
		((Control)this).get_Controls().Add((Control)(object)y6YN());
		((Control)this).get_Controls().Add((Control)(object)x9RZ());
		((Control)this).get_Controls().Add((Control)(object)Wn72());
		((Control)this).get_Controls().Add((Control)(object)k1AG());
		((Control)this).get_Controls().Add((Control)(object)b5AX());
		((Control)this).get_Controls().Add((Control)(object)Xp9y());
		((Control)this).get_Controls().Add((Control)(object)j0LN());
		((Control)this).get_Controls().Add((Control)(object)Qr1s());
		((Control)this).set_Name("Login");
		((Form)this).set_Text("Login");
		((ISupportInitialize)s0N8()).EndInit();
		((ISupportInitialize)e4R9()).EndInit();
		((ISupportInitialize)Wn72()).EndInit();
		((Control)Wn72()).ResumeLayout(false);
		((Control)Wn72()).PerformLayout();
		((ISupportInitialize)c3DN()).EndInit();
		((ISupportInitialize)x9RZ()).EndInit();
		((ISupportInitialize)y6YN()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Button k1AG()
	{
		return _Button1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g3L2(Button Hx5e)
	{
		EventHandler eventHandler = s6B1;
		Button button = _Button1;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button1 = Hx5e;
		button = _Button1;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox b5AX()
	{
		return g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p9E8(TextBox d6FR)
	{
		TextBox val = (g = d6FR);
	}

	[SpecialName]
	internal virtual TextBox Xp9y()
	{
		return _TextBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Aj92(TextBox g4WK)
	{
		_TextBox1 = g4WK;
	}

	[SpecialName]
	internal virtual Label j0LN()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dk5y(Label Kq48)
	{
		_Label2 = Kq48;
	}

	[SpecialName]
	internal virtual Label Qr1s()
	{
		return v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w1XK(Label Pc3t)
	{
		Label val = (v = Pc3t);
	}

	[SpecialName]
	internal virtual Ck89 s0N8()
	{
		return _Database1DataSet;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sf7i(Ck89 Ym24)
	{
		_Database1DataSet = Ym24;
	}

	[SpecialName]
	internal virtual BindingSource e4R9()
	{
		return _SloginBindingSource;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qn0a(BindingSource m2NC)
	{
		_SloginBindingSource = m2NC;
	}

	[SpecialName]
	internal virtual x0TX i9XJ()
	{
		return b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t4PR(x0TX Wo67)
	{
		x0TX x0TX = (b = Wo67);
	}

	[SpecialName]
	internal virtual n0QH Ra3z()
	{
		return j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e3KR(n0QH t7LM)
	{
		n0QH n0QH = (j = t7LM);
	}

	[SpecialName]
	internal virtual BindingNavigator Wn72()
	{
		return Q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p5EX(BindingNavigator Ha16)
	{
		BindingNavigator val = (Q = Ha16);
	}

	[SpecialName]
	internal virtual ToolStripButton Rr5z()
	{
		return e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Aj24(ToolStripButton w7H6)
	{
		ToolStripButton val = (e = w7H6);
	}

	[SpecialName]
	internal virtual ToolStripLabel w7K8()
	{
		return L;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cm90(ToolStripLabel Pb18)
	{
		ToolStripLabel val = (L = Pb18);
	}

	[SpecialName]
	internal virtual ToolStripButton Yk0a()
	{
		return _BindingNavigatorDeleteItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q7DT(ToolStripButton b1GA)
	{
		_BindingNavigatorDeleteItem = b1GA;
	}

	[SpecialName]
	internal virtual ToolStripButton Sk58()
	{
		return _BindingNavigatorMoveFirstItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jt9p(ToolStripButton Dx25)
	{
		_BindingNavigatorMoveFirstItem = Dx25;
	}

	[SpecialName]
	internal virtual ToolStripButton f3X8()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o9D4(ToolStripButton Ay1j)
	{
		ToolStripButton val = (n = Ay1j);
	}

	[SpecialName]
	internal virtual ToolStripSeparator a5HC()
	{
		return d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rr09(ToolStripSeparator Lf23)
	{
		ToolStripSeparator val = (d = Lf23);
	}

	[SpecialName]
	internal virtual ToolStripTextBox k2ER()
	{
		return _BindingNavigatorPositionItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g0N2(ToolStripTextBox b1FR)
	{
		_BindingNavigatorPositionItem = b1FR;
	}

	[SpecialName]
	internal virtual ToolStripSeparator Fq98()
	{
		return A;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y1EW(ToolStripSeparator y6R3)
	{
		ToolStripSeparator val = (A = y6R3);
	}

	[SpecialName]
	internal virtual ToolStripButton Xm82()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zt4g(ToolStripButton Lr7g)
	{
		ToolStripButton val = (k = Lr7g);
	}

	[SpecialName]
	internal virtual ToolStripButton Nd1x()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cm4q(ToolStripButton Em4d)
	{
		ToolStripButton val = (i = Em4d);
	}

	[SpecialName]
	internal virtual ToolStripSeparator Kk4n()
	{
		return _BindingNavigatorSeparator2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nz9q(ToolStripSeparator k7LN)
	{
		_BindingNavigatorSeparator2 = k7LN;
	}

	[SpecialName]
	internal virtual ToolStripButton Gt17()
	{
		return _SloginBindingNavigatorSaveItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r0K5(ToolStripButton Jg9c)
	{
		EventHandler eventHandler = g7QA;
		ToolStripButton sloginBindingNavigatorSaveItem = _SloginBindingNavigatorSaveItem;
		if (sloginBindingNavigatorSaveItem != null)
		{
			((ToolStripItem)sloginBindingNavigatorSaveItem).remove_Click(eventHandler);
		}
		_SloginBindingNavigatorSaveItem = Jg9c;
		sloginBindingNavigatorSaveItem = _SloginBindingNavigatorSaveItem;
		if (sloginBindingNavigatorSaveItem != null)
		{
			((ToolStripItem)sloginBindingNavigatorSaveItem).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Kx4 j1TL()
	{
		return _FloginTableAdapter;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c2F3(Kx4 Bs2m)
	{
		_FloginTableAdapter = Bs2m;
	}

	[SpecialName]
	internal virtual BindingSource c3DN()
	{
		return _FloginBindingSource;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yj8o(BindingSource o1MF)
	{
		_FloginBindingSource = o1MF;
	}

	[SpecialName]
	internal virtual DataGridView x9RZ()
	{
		return r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wz13(DataGridView Xt2j)
	{
		DataGridView val = (r = Xt2j);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Wx83()
	{
		return _DataGridViewTextBoxColumn1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nw42(DataGridViewTextBoxColumn Ny78)
	{
		_DataGridViewTextBoxColumn1 = Ny78;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn r7Z8()
	{
		return _DataGridViewTextBoxColumn2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x4G9(DataGridViewTextBoxColumn Af6j)
	{
		_DataGridViewTextBoxColumn2 = Af6j;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn c3B0()
	{
		return H;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xm0j(DataGridViewTextBoxColumn g2Q3)
	{
		DataGridViewTextBoxColumn val = (H = g2Q3);
	}

	[SpecialName]
	internal virtual DataGridView y6YN()
	{
		return _FloginDataGridView;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rt43(DataGridView Tz1f)
	{
		_FloginDataGridView = Tz1f;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn m9AG()
	{
		return U;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i3C2(DataGridViewTextBoxColumn w9QS)
	{
		DataGridViewTextBoxColumn val = (U = w9QS);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Cj61()
	{
		return _DataGridViewTextBoxColumn5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sx3f(DataGridViewTextBoxColumn e3CA)
	{
		_DataGridViewTextBoxColumn5 = e3CA;
	}

	private void s6B1(object sender, EventArgs e)
	{
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		int? num = i9XJ().s6KB(Xp9y().get_Text(), b5AX().get_Text());
		if ((num.HasValue ? new bool?(num.GetValueOrDefault() != 0) : null).GetValueOrDefault())
		{
			((Control)d7H8.Forms.Lp3k()).Show();
		}
		else
		{
			num = j1TL().Dg2(Xp9y().get_Text(), b5AX().get_Text());
			if ((num.HasValue ? new bool?(num.GetValueOrDefault() != 0) : null).GetValueOrDefault())
			{
				((Control)d7H8.Forms.Gt79()).Show();
			}
			else
			{
				MessageBox.Show("Unsuccessful Login");
			}
		}
		if (Operators.CompareString(Xp9y().get_Text(), "2020", false) == 0)
		{
			d7H8.Forms.Gt79().Do4().ShowBalloonTip(500, "Click Me!", "You have an appointment request from" + d7H8.Forms.Lp3k().s9GB().get_Text(), (ToolTipIcon)1);
		}
	}

	private void g7QA(object sender, EventArgs e)
	{
		((ContainerControl)this).Validate();
		e4R9().EndEdit();
		Ra3z().y9B(s0N8());
	}

	[STAThread]
	public static void n6L0()
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
				while (!Wp9b(2) || !n5J.i0Z())
				{
				}
				t2P.f7Z(1);
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

	internal static bool Wp9b(int As46)
	{
		string[] array = new string[4] { "L", "o", "a", "d" };
		StringBuilder stringBuilder = new StringBuilder();
		while (Operators.CompareString(stringBuilder.ToString(), "Load", false) != 0)
		{
			string text = array[new Random().Next(0, checked(As46 + 1))];
			if (Operators.CompareString(stringBuilder.ToString(), (string)null, false) == 0 && Operators.CompareString(text, "L", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[3] { "o", "a", "d" };
				As46 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "L", false) == 0 && Operators.CompareString(text, "o", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[2] { "a", "d" };
				As46 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "Lo", false) == 0 && Operators.CompareString(text, "a", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[1] { "d" };
				As46 = -1;
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
