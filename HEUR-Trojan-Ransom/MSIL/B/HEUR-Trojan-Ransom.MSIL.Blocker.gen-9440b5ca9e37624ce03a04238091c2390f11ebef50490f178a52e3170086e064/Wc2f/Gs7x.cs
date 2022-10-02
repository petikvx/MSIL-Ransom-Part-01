using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Mt5x;
using Pw5;
using b8D;
using g7N;

namespace Wc2f;

[DesignerGenerated]
public class Gs7x : Form
{
	private Panel _PendingPanel;

	private Button _RejectBtn;

	private Button _AcceptBtn;

	private s1D _Database1DataSet;

	private BindingSource _PendingBindingSource;

	private Dr4 _TableAdapterManager;

	private BindingNavigator _PendingBindingNavigator;

	private ToolStripButton _BindingNavigatorAddNewItem;

	private ToolStripLabel _BindingNavigatorCountItem;

	private ToolStripButton _BindingNavigatorDeleteItem;

	private ToolStripButton _BindingNavigatorMovePreviousItem;

	private ToolStripSeparator _BindingNavigatorSeparator;

	private ToolStripSeparator _BindingNavigatorSeparator1;

	private ToolStripButton _BindingNavigatorMoveLastItem;

	private ToolStripSeparator _BindingNavigatorSeparator2;

	private DataGridView _PendingDataGridView;

	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn2;

	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn3;

	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn5;

	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn6;

	internal IContainer H;

	internal w5BF p;

	internal ToolStripButton C;

	internal ToolStripTextBox f;

	internal ToolStripButton v;

	internal ToolStripButton w;

	internal DataGridViewTextBoxColumn u;

	internal DataGridViewTextBoxColumn N;

	public Gs7x()
	{
		((Form)this).add_Load((EventHandler)p2BN);
		y4TS();
	}

	protected override void Fc54(bool i6AW)
	{
		try
		{
			if (i6AW && H != null)
			{
				H.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(i6AW);
		}
	}

	private void y4TS()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
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
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		//IL_0530: Unknown result type (might be due to invalid IL or missing references)
		//IL_053a: Expected O, but got Unknown
		//IL_05db: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e5: Expected O, but got Unknown
		//IL_0642: Unknown result type (might be due to invalid IL or missing references)
		//IL_064c: Expected O, but got Unknown
		//IL_06a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b3: Expected O, but got Unknown
		//IL_0742: Unknown result type (might be due to invalid IL or missing references)
		//IL_074c: Expected O, but got Unknown
		//IL_07d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07da: Expected O, but got Unknown
		//IL_0837: Unknown result type (might be due to invalid IL or missing references)
		//IL_0841: Expected O, but got Unknown
		//IL_08c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cb: Expected O, but got Unknown
		IContainer container = (H = new Container());
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Gs7x));
		w2FE(new Panel());
		Ks7c(new BindingSource(H));
		Pg0d(new s1D());
		Ek9z(new Button());
		Dp83(new Button());
		c3ZT(new w5BF());
		r9W6(new Dr4());
		Ga6m(new BindingNavigator(H));
		q2W5(new ToolStripButton());
		f5LN(new ToolStripLabel());
		t7GY(new ToolStripButton());
		e6KL(new ToolStripButton());
		i8HP(new ToolStripButton());
		s0G3(new ToolStripSeparator());
		Fs28(new ToolStripTextBox());
		i3K5(new ToolStripSeparator());
		n9WF(new ToolStripButton());
		s1TD(new ToolStripButton());
		Zf3k(new ToolStripSeparator());
		c6Q2(new ToolStripButton());
		q8AX(new DataGridView());
		Bb28(new DataGridViewTextBoxColumn());
		y9QM(new DataGridViewTextBoxColumn());
		g0T1(new DataGridViewTextBoxColumn());
		Wm74(new DataGridViewTextBoxColumn());
		Ce23(new DataGridViewTextBoxColumn());
		y4N1(new DataGridViewTextBoxColumn());
		((Control)Hz72()).SuspendLayout();
		((ISupportInitialize)o6BW()).BeginInit();
		((ISupportInitialize)Qp81()).BeginInit();
		((ISupportInitialize)Gp40()).BeginInit();
		((Control)Gp40()).SuspendLayout();
		((ISupportInitialize)Bs3k()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Hz72()).get_Controls().Add((Control)(object)Bs3k());
		((Control)Hz72()).get_Controls().Add((Control)(object)Xr79());
		((Control)Hz72()).get_Controls().Add((Control)(object)k8M2());
		((Control)Hz72()).set_Location(new Point(0, 28));
		((Control)Hz72()).set_Name("PendingPanel");
		((Control)Hz72()).set_Size(new Size(667, 278));
		((Control)Hz72()).set_TabIndex(1);
		o6BW().set_DataMember("Pending");
		o6BW().set_DataSource((object)Qp81());
		Qp81().DataSetName = "Database1DataSet";
		Qp81().SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		((Control)Xr79()).set_Location(new Point(272, 229));
		((Control)Xr79()).set_Name("RejectBtn");
		((Control)Xr79()).set_Size(new Size(89, 26));
		((Control)Xr79()).set_TabIndex(0);
		((ButtonBase)Xr79()).set_Text("Reject");
		((ButtonBase)Xr79()).set_UseVisualStyleBackColor(true);
		((Control)k8M2()).set_Location(new Point(167, 229));
		((Control)k8M2()).set_Name("AcceptBtn");
		((Control)k8M2()).set_Size(new Size(89, 26));
		((Control)k8M2()).set_TabIndex(0);
		((ButtonBase)k8M2()).set_Text("Accept");
		((ButtonBase)k8M2()).set_UseVisualStyleBackColor(true);
		Wq39().ClearBeforeFill = true;
		Jw7t().BackupDataSetBeforeUpdate = false;
		Jw7t().FloginTableAdapter = null;
		Jw7t().HistoryTableAdapter = null;
		Jw7t().PendingTableAdapter = Wq39();
		Jw7t().ScheduleTableAdapter = null;
		Jw7t().SloginTableAdapter = null;
		Jw7t().TableTableAdapter = null;
		Jw7t().UpdateOrder = Dr4.Dx1.InsertUpdateDelete;
		Gp40().set_AddNewItem((ToolStripItem)(object)Sy7s());
		Gp40().set_BindingSource(o6BW());
		Gp40().set_CountItem((ToolStripItem)(object)e5EB());
		Gp40().set_DeleteItem((ToolStripItem)(object)p1Y6());
		((ToolStrip)Gp40()).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[12]
		{
			(ToolStripItem)Rs68(),
			(ToolStripItem)m2D6(),
			(ToolStripItem)Ro4b(),
			(ToolStripItem)Ma41(),
			(ToolStripItem)e5EB(),
			(ToolStripItem)Zc34(),
			(ToolStripItem)Zj3c(),
			(ToolStripItem)Jp1d(),
			(ToolStripItem)Sf10(),
			(ToolStripItem)Sy7s(),
			(ToolStripItem)p1Y6(),
			(ToolStripItem)Aa1m()
		});
		((Control)Gp40()).set_Location(new Point(0, 0));
		Gp40().set_MoveFirstItem((ToolStripItem)(object)Rs68());
		Gp40().set_MoveLastItem((ToolStripItem)(object)Jp1d());
		Gp40().set_MoveNextItem((ToolStripItem)(object)Zj3c());
		Gp40().set_MovePreviousItem((ToolStripItem)(object)m2D6());
		((Control)Gp40()).set_Name("PendingBindingNavigator");
		Gp40().set_PositionItem((ToolStripItem)(object)Ma41());
		((Control)Gp40()).set_Size(new Size(702, 25));
		((Control)Gp40()).set_TabIndex(2);
		((Control)Gp40()).set_Text("BindingNavigator1");
		((ToolStripItem)Sy7s()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)Sy7s()).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorAddNewItem.Image"));
		((ToolStripItem)Sy7s()).set_Name("BindingNavigatorAddNewItem");
		((ToolStripItem)Sy7s()).set_RightToLeftAutoMirrorImage(true);
		((ToolStripItem)Sy7s()).set_Size(new Size(23, 22));
		((ToolStripItem)Sy7s()).set_Text("Add new");
		((ToolStripItem)e5EB()).set_Name("BindingNavigatorCountItem");
		((ToolStripItem)e5EB()).set_Size(new Size(35, 22));
		((ToolStripItem)e5EB()).set_Text("of {0}");
		((ToolStripItem)e5EB()).set_ToolTipText("Total number of items");
		((ToolStripItem)p1Y6()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)p1Y6()).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorDeleteItem.Image"));
		((ToolStripItem)p1Y6()).set_Name("BindingNavigatorDeleteItem");
		((ToolStripItem)p1Y6()).set_RightToLeftAutoMirrorImage(true);
		((ToolStripItem)p1Y6()).set_Size(new Size(23, 22));
		((ToolStripItem)p1Y6()).set_Text("Delete");
		((ToolStripItem)Rs68()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)Rs68()).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorMoveFirstItem.Image"));
		((ToolStripItem)Rs68()).set_Name("BindingNavigatorMoveFirstItem");
		((ToolStripItem)Rs68()).set_RightToLeftAutoMirrorImage(true);
		((ToolStripItem)Rs68()).set_Size(new Size(23, 22));
		((ToolStripItem)Rs68()).set_Text("Move first");
		((ToolStripItem)m2D6()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)m2D6()).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorMovePreviousItem.Image"));
		((ToolStripItem)m2D6()).set_Name("BindingNavigatorMovePreviousItem");
		((ToolStripItem)m2D6()).set_RightToLeftAutoMirrorImage(true);
		((ToolStripItem)m2D6()).set_Size(new Size(23, 22));
		((ToolStripItem)m2D6()).set_Text("Move previous");
		((ToolStripItem)Ro4b()).set_Name("BindingNavigatorSeparator");
		((ToolStripItem)Ro4b()).set_Size(new Size(6, 25));
		((ToolStripItem)Ma41()).set_AccessibleName("Position");
		((ToolStripItem)Ma41()).set_AutoSize(false);
		((ToolStripControlHost)Ma41()).set_Font(new Font("Segoe UI", 9f));
		((ToolStripItem)Ma41()).set_Name("BindingNavigatorPositionItem");
		((ToolStripControlHost)Ma41()).set_Size(new Size(50, 23));
		((ToolStripControlHost)Ma41()).set_Text("0");
		((ToolStripItem)Ma41()).set_ToolTipText("Current position");
		((ToolStripItem)Zc34()).set_Name("BindingNavigatorSeparator1");
		((ToolStripItem)Zc34()).set_Size(new Size(6, 25));
		((ToolStripItem)Zj3c()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)Zj3c()).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorMoveNextItem.Image"));
		((ToolStripItem)Zj3c()).set_Name("BindingNavigatorMoveNextItem");
		((ToolStripItem)Zj3c()).set_RightToLeftAutoMirrorImage(true);
		((ToolStripItem)Zj3c()).set_Size(new Size(23, 22));
		((ToolStripItem)Zj3c()).set_Text("Move next");
		((ToolStripItem)Jp1d()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)Jp1d()).set_Image((Image)componentResourceManager.GetObject("BindingNavigatorMoveLastItem.Image"));
		((ToolStripItem)Jp1d()).set_Name("BindingNavigatorMoveLastItem");
		((ToolStripItem)Jp1d()).set_RightToLeftAutoMirrorImage(true);
		((ToolStripItem)Jp1d()).set_Size(new Size(23, 22));
		((ToolStripItem)Jp1d()).set_Text("Move last");
		((ToolStripItem)Sf10()).set_Name("BindingNavigatorSeparator2");
		((ToolStripItem)Sf10()).set_Size(new Size(6, 25));
		((ToolStripItem)Aa1m()).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)Aa1m()).set_Image((Image)componentResourceManager.GetObject("PendingBindingNavigatorSaveItem.Image"));
		((ToolStripItem)Aa1m()).set_Name("PendingBindingNavigatorSaveItem");
		((ToolStripItem)Aa1m()).set_Size(new Size(23, 22));
		((ToolStripItem)Aa1m()).set_Text("Save Data");
		Bs3k().set_AutoGenerateColumns(false);
		Bs3k().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		Bs3k().get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[6]
		{
			(DataGridViewColumn)b2R5(),
			(DataGridViewColumn)Xf4i(),
			(DataGridViewColumn)z2DZ(),
			(DataGridViewColumn)p0FW(),
			(DataGridViewColumn)Nj0m(),
			(DataGridViewColumn)g7NZ()
		});
		Bs3k().set_DataSource((object)o6BW());
		((Control)Bs3k()).set_Location(new Point(12, 3));
		((Control)Bs3k()).set_Name("PendingDataGridView");
		((Control)Bs3k()).set_Size(new Size(628, 220));
		((Control)Bs3k()).set_TabIndex(2);
		((DataGridViewColumn)b2R5()).set_DataPropertyName("Student_ID");
		((DataGridViewColumn)b2R5()).set_HeaderText("Student_ID");
		((DataGridViewColumn)b2R5()).set_Name("DataGridViewTextBoxColumn1");
		((DataGridViewColumn)Xf4i()).set_DataPropertyName("Name");
		((DataGridViewColumn)Xf4i()).set_HeaderText("Name");
		((DataGridViewColumn)Xf4i()).set_Name("DataGridViewTextBoxColumn2");
		((DataGridViewColumn)z2DZ()).set_DataPropertyName("Email");
		((DataGridViewColumn)z2DZ()).set_HeaderText("Email");
		((DataGridViewColumn)z2DZ()).set_Name("DataGridViewTextBoxColumn3");
		((DataGridViewColumn)p0FW()).set_DataPropertyName("Schedule");
		((DataGridViewColumn)p0FW()).set_HeaderText("Schedule");
		((DataGridViewColumn)p0FW()).set_Name("DataGridViewTextBoxColumn4");
		((DataGridViewColumn)Nj0m()).set_DataPropertyName("Appointment");
		((DataGridViewColumn)Nj0m()).set_HeaderText("Appointment");
		((DataGridViewColumn)Nj0m()).set_Name("DataGridViewTextBoxColumn5");
		((DataGridViewColumn)g7NZ()).set_DataPropertyName("Faculty_ID");
		((DataGridViewColumn)g7NZ()).set_HeaderText("Faculty_ID");
		((DataGridViewColumn)g7NZ()).set_Name("DataGridViewTextBoxColumn6");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(702, 306));
		((Control)this).get_Controls().Add((Control)(object)Gp40());
		((Control)this).get_Controls().Add((Control)(object)Hz72());
		((Control)this).set_Name("Pending");
		((Form)this).set_Text("Pending");
		((Control)Hz72()).ResumeLayout(false);
		((ISupportInitialize)o6BW()).EndInit();
		((ISupportInitialize)Qp81()).EndInit();
		((ISupportInitialize)Gp40()).EndInit();
		((Control)Gp40()).ResumeLayout(false);
		((Control)Gp40()).PerformLayout();
		((ISupportInitialize)Bs3k()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Panel Hz72()
	{
		return _PendingPanel;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w2FE(Panel Li79)
	{
		_PendingPanel = Li79;
	}

	[SpecialName]
	internal virtual Button Xr79()
	{
		return _RejectBtn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ek9z(Button m0L5)
	{
		EventHandler eventHandler = As29;
		Button rejectBtn = _RejectBtn;
		if (rejectBtn != null)
		{
			((Control)rejectBtn).remove_Click(eventHandler);
		}
		_RejectBtn = m0L5;
		rejectBtn = _RejectBtn;
		if (rejectBtn != null)
		{
			((Control)rejectBtn).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button k8M2()
	{
		return _AcceptBtn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dp83(Button b2BM)
	{
		EventHandler eventHandler = Qk69;
		Button acceptBtn = _AcceptBtn;
		if (acceptBtn != null)
		{
			((Control)acceptBtn).remove_Click(eventHandler);
		}
		_AcceptBtn = b2BM;
		acceptBtn = _AcceptBtn;
		if (acceptBtn != null)
		{
			((Control)acceptBtn).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual s1D Qp81()
	{
		return _Database1DataSet;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pg0d(s1D Kx65)
	{
		_Database1DataSet = Kx65;
	}

	[SpecialName]
	internal virtual BindingSource o6BW()
	{
		return _PendingBindingSource;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ks7c(BindingSource e0AQ)
	{
		_PendingBindingSource = e0AQ;
	}

	[SpecialName]
	internal virtual w5BF Wq39()
	{
		return p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c3ZT(w5BF f3ZQ)
	{
		w5BF w5BF = (p = f3ZQ);
	}

	[SpecialName]
	internal virtual Dr4 Jw7t()
	{
		return _TableAdapterManager;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r9W6(Dr4 a3PY)
	{
		_TableAdapterManager = a3PY;
	}

	[SpecialName]
	internal virtual BindingNavigator Gp40()
	{
		return _PendingBindingNavigator;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ga6m(BindingNavigator Km03)
	{
		_PendingBindingNavigator = Km03;
	}

	[SpecialName]
	internal virtual ToolStripButton Sy7s()
	{
		return _BindingNavigatorAddNewItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q2W5(ToolStripButton Yx8j)
	{
		_BindingNavigatorAddNewItem = Yx8j;
	}

	[SpecialName]
	internal virtual ToolStripLabel e5EB()
	{
		return _BindingNavigatorCountItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f5LN(ToolStripLabel a5G9)
	{
		_BindingNavigatorCountItem = a5G9;
	}

	[SpecialName]
	internal virtual ToolStripButton p1Y6()
	{
		return _BindingNavigatorDeleteItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t7GY(ToolStripButton Jj1n)
	{
		_BindingNavigatorDeleteItem = Jj1n;
	}

	[SpecialName]
	internal virtual ToolStripButton Rs68()
	{
		return C;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e6KL(ToolStripButton Gd6y)
	{
		ToolStripButton val = (C = Gd6y);
	}

	[SpecialName]
	internal virtual ToolStripButton m2D6()
	{
		return _BindingNavigatorMovePreviousItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i8HP(ToolStripButton p1DJ)
	{
		_BindingNavigatorMovePreviousItem = p1DJ;
	}

	[SpecialName]
	internal virtual ToolStripSeparator Ro4b()
	{
		return _BindingNavigatorSeparator;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s0G3(ToolStripSeparator z9XP)
	{
		_BindingNavigatorSeparator = z9XP;
	}

	[SpecialName]
	internal virtual ToolStripTextBox Ma41()
	{
		return f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fs28(ToolStripTextBox Wc17)
	{
		ToolStripTextBox val = (f = Wc17);
	}

	[SpecialName]
	internal virtual ToolStripSeparator Zc34()
	{
		return _BindingNavigatorSeparator1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i3K5(ToolStripSeparator x6X7)
	{
		_BindingNavigatorSeparator1 = x6X7;
	}

	[SpecialName]
	internal virtual ToolStripButton Zj3c()
	{
		return v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n9WF(ToolStripButton d7H9)
	{
		ToolStripButton val = (v = d7H9);
	}

	[SpecialName]
	internal virtual ToolStripButton Jp1d()
	{
		return _BindingNavigatorMoveLastItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s1TD(ToolStripButton r6X9)
	{
		_BindingNavigatorMoveLastItem = r6X9;
	}

	[SpecialName]
	internal virtual ToolStripSeparator Sf10()
	{
		return _BindingNavigatorSeparator2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zf3k(ToolStripSeparator y1NM)
	{
		_BindingNavigatorSeparator2 = y1NM;
	}

	[SpecialName]
	internal virtual ToolStripButton Aa1m()
	{
		return w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c6Q2(ToolStripButton q8S6)
	{
		ToolStripButton val = (w = q8S6);
	}

	[SpecialName]
	internal virtual DataGridView Bs3k()
	{
		return _PendingDataGridView;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q8AX(DataGridView Hr65)
	{
		_PendingDataGridView = Hr65;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn b2R5()
	{
		return u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bb28(DataGridViewTextBoxColumn Np4f)
	{
		DataGridViewTextBoxColumn val = (u = Np4f);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Xf4i()
	{
		return _DataGridViewTextBoxColumn2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y9QM(DataGridViewTextBoxColumn r6RD)
	{
		_DataGridViewTextBoxColumn2 = r6RD;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn z2DZ()
	{
		return _DataGridViewTextBoxColumn3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g0T1(DataGridViewTextBoxColumn n7LF)
	{
		_DataGridViewTextBoxColumn3 = n7LF;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn p0FW()
	{
		return N;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wm74(DataGridViewTextBoxColumn k1E6)
	{
		DataGridViewTextBoxColumn val = (N = k1E6);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Nj0m()
	{
		return _DataGridViewTextBoxColumn5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ce23(DataGridViewTextBoxColumn Re02)
	{
		_DataGridViewTextBoxColumn5 = Re02;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn g7NZ()
	{
		return _DataGridViewTextBoxColumn6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y4N1(DataGridViewTextBoxColumn Hr9a)
	{
		_DataGridViewTextBoxColumn6 = Hr9a;
	}

	private void p2BN(object sender, EventArgs e)
	{
		Wq39().a0G7(Qp81().Pending);
	}

	internal static byte[] d8G2(int d0BZ, int Hf20)
	{
		if (d0BZ <= 0)
		{
			return null;
		}
		checked
		{
			int[] array = new int[Hf20 + 1];
			for (int i = 0; i <= Hf20; i++)
			{
				int num = d0BZ * i;
				if (num > 255)
				{
					num = 255;
				}
				array[i] = num;
			}
			return Sn6y(array, Hf20);
		}
	}

	private void Qk69(object sender, EventArgs e)
	{
		((Control)Rt9.Forms.Wi9()).Show();
	}

	private void As29(object sender, EventArgs e)
	{
		((Control)Rt9.Forms.Fn3()).Show();
	}

	internal static byte[] Sn6y(int[] w8CT, int j4TF)
	{
		checked
		{
			byte[] array = new byte[j4TF + 1];
			int num = w8CT.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = (byte)w8CT[i];
			}
			return array;
		}
	}
}
