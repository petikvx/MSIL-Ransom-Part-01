using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors;
using Microsoft.VisualBasic.CompilerServices;
using xxx.My;

namespace xxx;

[DesignerGenerated]
public class canzhaolie : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("btnAdd")]
	private ButtonX _btnAdd;

	[AccessedThroughProperty("lieshu")]
	private IntegerInput _lieshu;

	[AccessedThroughProperty("LabelX1")]
	private LabelX _LabelX1;

	[AccessedThroughProperty("CZDGV")]
	private DataGridViewX _CZDGV;

	[AccessedThroughProperty("btngb")]
	private ButtonX _btngb;

	[AccessedThroughProperty("btnqk")]
	private ButtonX _btnqk;

	[AccessedThroughProperty("LabelX2")]
	private LabelX _LabelX2;

	public int liehao;

	private bool zd;

	internal virtual ButtonX btnAdd
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnAdd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnAdd_Click;
			if (_btnAdd != null)
			{
				((Control)_btnAdd).remove_Click(eventHandler);
			}
			_btnAdd = value;
			if (_btnAdd != null)
			{
				((Control)_btnAdd).add_Click(eventHandler);
			}
		}
	}

	internal virtual IntegerInput lieshu
	{
		[DebuggerNonUserCode]
		get
		{
			return _lieshu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lieshu = value;
		}
	}

	internal virtual LabelX LabelX1
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX1 = value;
		}
	}

	public virtual DataGridViewX CZDGV
	{
		[DebuggerNonUserCode]
		get
		{
			return _CZDGV;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			ScrollEventHandler val = new ScrollEventHandler(CZDGV_Scroll);
			DataGridViewCellEventHandler val2 = new DataGridViewCellEventHandler(CZDGV_CellClick);
			DataGridViewCellEventHandler val3 = new DataGridViewCellEventHandler(CZDGV_RowEnter);
			DataGridViewCellMouseEventHandler val4 = new DataGridViewCellMouseEventHandler(CZDGV_ColumnHeaderMouseDoubleClick);
			if (_CZDGV != null)
			{
				((DataGridView)_CZDGV).remove_Scroll(val);
				((DataGridView)_CZDGV).remove_CellClick(val2);
				((DataGridView)_CZDGV).remove_RowEnter(val3);
				((DataGridView)_CZDGV).remove_ColumnHeaderMouseDoubleClick(val4);
			}
			_CZDGV = value;
			if (_CZDGV != null)
			{
				((DataGridView)_CZDGV).add_Scroll(val);
				((DataGridView)_CZDGV).add_CellClick(val2);
				((DataGridView)_CZDGV).add_RowEnter(val3);
				((DataGridView)_CZDGV).add_ColumnHeaderMouseDoubleClick(val4);
			}
		}
	}

	internal virtual ButtonX btngb
	{
		[DebuggerNonUserCode]
		get
		{
			return _btngb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btngb_Click;
			if (_btngb != null)
			{
				((Control)_btngb).remove_Click(eventHandler);
			}
			_btngb = value;
			if (_btngb != null)
			{
				((Control)_btngb).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX btnqk
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnqk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnqk_Click;
			if (_btnqk != null)
			{
				((Control)_btnqk).remove_Click(eventHandler);
			}
			_btnqk = value;
			if (_btnqk != null)
			{
				((Control)_btnqk).add_Click(eventHandler);
			}
		}
	}

	internal virtual LabelX LabelX2
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX2 = value;
		}
	}

	public canzhaolie()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		((Form)this).add_FormClosed(new FormClosedEventHandler(canzhaolie_FormClosed));
		zd = true;
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Office2007Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
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
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_0667: Unknown result type (might be due to invalid IL or missing references)
		//IL_0671: Expected O, but got Unknown
		//IL_071a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0724: Expected O, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		CZDGV = new DataGridViewX();
		btnAdd = new ButtonX();
		lieshu = new IntegerInput();
		LabelX1 = new LabelX();
		btngb = new ButtonX();
		btnqk = new ButtonX();
		LabelX2 = new LabelX();
		((ISupportInitialize)CZDGV).BeginInit();
		((ISupportInitialize)lieshu).BeginInit();
		((Control)this).SuspendLayout();
		((DataGridView)CZDGV).set_AllowUserToAddRows(false);
		((DataGridView)CZDGV).set_AllowUserToDeleteRows(false);
		((DataGridView)CZDGV).set_AllowUserToResizeRows(false);
		((Control)CZDGV).set_Anchor((AnchorStyles)15);
		val.set_Alignment((DataGridViewContentAlignment)16);
		val.set_BackColor(SystemColors.Control);
		val.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		val.set_ForeColor(SystemColors.WindowText);
		val.set_SelectionBackColor(SystemColors.Highlight);
		val.set_SelectionForeColor(SystemColors.HighlightText);
		val.set_WrapMode((DataGridViewTriState)1);
		((DataGridView)CZDGV).set_ColumnHeadersDefaultCellStyle(val);
		((DataGridView)CZDGV).set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)1);
		val2.set_Alignment((DataGridViewContentAlignment)16);
		val2.set_BackColor(SystemColors.Window);
		val2.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		val2.set_ForeColor(SystemColors.ControlText);
		val2.set_SelectionBackColor(SystemColors.Highlight);
		val2.set_SelectionForeColor(SystemColors.ControlText);
		val2.set_WrapMode((DataGridViewTriState)2);
		((DataGridView)CZDGV).set_DefaultCellStyle(val2);
		((DataGridView)CZDGV).set_GridColor(Color.FromArgb(208, 215, 229));
		DataGridViewX cZDGV = CZDGV;
		Point location = new Point(5, 3);
		((Control)cZDGV).set_Location(location);
		((DataGridView)CZDGV).set_MultiSelect(false);
		((Control)CZDGV).set_Name("CZDGV");
		((DataGridView)CZDGV).set_ReadOnly(true);
		val3.set_Alignment((DataGridViewContentAlignment)16);
		val3.set_BackColor(SystemColors.Control);
		val3.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		val3.set_ForeColor(SystemColors.WindowText);
		val3.set_SelectionBackColor(SystemColors.Highlight);
		val3.set_SelectionForeColor(SystemColors.HighlightText);
		val3.set_WrapMode((DataGridViewTriState)1);
		((DataGridView)CZDGV).set_RowHeadersDefaultCellStyle(val3);
		((DataGridView)CZDGV).get_RowTemplate().set_Height(23);
		((DataGridView)CZDGV).set_SelectionMode((DataGridViewSelectionMode)1);
		DataGridViewX cZDGV2 = CZDGV;
		Size size = new Size(353, 401);
		((Control)cZDGV2).set_Size(size);
		((Control)CZDGV).set_TabIndex(0);
		((Control)btnAdd).set_AccessibleRole((AccessibleRole)43);
		((Control)btnAdd).set_Anchor((AnchorStyles)2);
		btnAdd.set_ColorTable((eButtonColor)3);
		ButtonX obj = btnAdd;
		location = new Point(130, 414);
		((Control)obj).set_Location(location);
		((Control)btnAdd).set_Name("btnAdd");
		ButtonX obj2 = btnAdd;
		size = new Size(81, 23);
		((Control)obj2).set_Size(size);
		((PopupItemControl)btnAdd).set_Style((eDotNetBarStyle)7);
		((Control)btnAdd).set_TabIndex(1);
		btnAdd.set_Text("添加列");
		btnAdd.set_Tooltip("双击表头填充当前列");
		((Control)lieshu).set_Anchor((AnchorStyles)2);
		((VisualControlBase)lieshu).get_BackgroundStyle().set_Class("DateTimeInputBackground");
		((VisualControlBase)lieshu).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((NumericInputBase)lieshu).get_ButtonFreeText().set_Shortcut((eShortcut)113);
		IntegerInput obj3 = lieshu;
		location = new Point(66, 414);
		((Control)obj3).set_Location(location);
		lieshu.set_MaxValue(10);
		lieshu.set_MinValue(1);
		((Control)lieshu).set_Name("lieshu");
		((NumericInputBase)lieshu).set_ShowUpDown(true);
		IntegerInput obj4 = lieshu;
		size = new Size(58, 21);
		((Control)obj4).set_Size(size);
		((Control)lieshu).set_TabIndex(2);
		lieshu.set_Value(2);
		((Control)LabelX1).set_Anchor((AnchorStyles)2);
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX = LabelX1;
		location = new Point(3, 414);
		((Control)labelX).set_Location(location);
		((Control)LabelX1).set_Name("LabelX1");
		LabelX labelX2 = LabelX1;
		size = new Size(57, 23);
		((Control)labelX2).set_Size(size);
		((Control)LabelX1).set_TabIndex(3);
		LabelX1.set_Text("指定列数");
		((Control)btngb).set_AccessibleRole((AccessibleRole)43);
		((Control)btngb).set_Anchor((AnchorStyles)2);
		btngb.set_ColorTable((eButtonColor)3);
		btngb.set_DialogResult((DialogResult)2);
		ButtonX obj5 = btngb;
		location = new Point(304, 414);
		((Control)obj5).set_Location(location);
		((Control)btngb).set_Name("btngb");
		ButtonX obj6 = btngb;
		size = new Size(52, 23);
		((Control)obj6).set_Size(size);
		((PopupItemControl)btngb).set_Style((eDotNetBarStyle)7);
		((Control)btngb).set_TabIndex(1);
		btngb.set_Text("关闭");
		((Control)btnqk).set_AccessibleRole((AccessibleRole)43);
		((Control)btnqk).set_Anchor((AnchorStyles)2);
		btnqk.set_ColorTable((eButtonColor)3);
		ButtonX obj7 = btnqk;
		location = new Point(217, 414);
		((Control)obj7).set_Location(location);
		((Control)btnqk).set_Name("btnqk");
		ButtonX obj8 = btnqk;
		size = new Size(81, 23);
		((Control)obj8).set_Size(size);
		((PopupItemControl)btnqk).set_Style((eDotNetBarStyle)7);
		((Control)btnqk).set_TabIndex(1);
		btnqk.set_Text("清空");
		((Control)LabelX2).set_Anchor((AnchorStyles)2);
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX3 = LabelX2;
		location = new Point(4, 440);
		((Control)labelX3).set_Location(location);
		((Control)LabelX2).set_Name("LabelX2");
		LabelX labelX4 = LabelX2;
		size = new Size(352, 19);
		((Control)labelX4).set_Size(size);
		((Control)LabelX2).set_TabIndex(3);
		LabelX2.set_Text("说明：双击表头，选择相应ID，填充至当前列.");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_CancelButton((IButtonControl)(object)btngb);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		size = new Size(363, 467);
		((Form)this).set_ClientSize(size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)LabelX2);
		((Control)this).get_Controls().Add((Control)(object)LabelX1);
		((Control)this).get_Controls().Add((Control)(object)lieshu);
		((Control)this).get_Controls().Add((Control)(object)btnqk);
		((Control)this).get_Controls().Add((Control)(object)btnAdd);
		((Control)this).get_Controls().Add((Control)(object)CZDGV);
		((Control)this).get_Controls().Add((Control)(object)btngb);
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("canzhaolie");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text(" ");
		((Form)this).set_TopMost(true);
		((ISupportInitialize)CZDGV).EndInit();
		((ISupportInitialize)lieshu).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Invalid comparison between Unknown and I4
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		if (lieshu.get_Value() == 0)
		{
			return;
		}
		if (((BaseCollection)((DataGridView)CZDGV).get_Columns()).get_Count() != 0 && (int)MessageBox.Show("当前列不为空，是否保留当前列？", "提示", (MessageBoxButtons)4, (MessageBoxIcon)64) == 7)
		{
			((DataGridView)CZDGV).get_Columns().Clear();
			((DataGridView)CZDGV).get_Rows().Clear();
		}
		int value = lieshu.get_Value();
		checked
		{
			for (int i = 1; i <= value; i++)
			{
				((DataGridView)CZDGV).get_Columns().Add("", "");
			}
			if (((DataGridView)CZDGV).get_Rows().get_Count() != ((DataGridView)MyProject.Forms.cslr2.DGV).get_Rows().get_Count())
			{
				int count = ((DataGridView)MyProject.Forms.cslr2.DGV).get_Rows().get_Count();
				for (int j = 1; j <= count; j++)
				{
					((DataGridView)CZDGV).get_Rows().Add();
				}
			}
			((Form)this).set_Text(MyProject.Forms.cslr2.lbcsx.get_Text());
			DataGridView datagv = (DataGridView)(object)CZDGV;
			Mod1.Jzpx(ref datagv);
			CZDGV = (DataGridViewX)datagv;
		}
	}

	private void canzhaolie_FormClosed(object sender, FormClosedEventArgs e)
	{
		MyProject.Forms.cslr2.CBchanzhao.set_Checked(false);
	}

	private void btngb_Click(object sender, EventArgs e)
	{
		MyProject.Forms.cslr2.CBchanzhao.set_Checked(false);
		((Control)this).Hide();
	}

	private void CZDGV_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		if (Operators.CompareString(MyProject.Forms.cslr2.lbcsx.get_Text(), ((Form)this).get_Text(), false) == 0 && e.get_RowIndex() != -1 && ((DataGridView)MyProject.Forms.cslr2.DGV).get_Rows().get_Count() != 0)
		{
			((DataGridView)MyProject.Forms.cslr2.DGV).get_Rows().get_Item(e.get_RowIndex()).set_Selected(true);
		}
	}

	private void CZDGV_Scroll(object sender, ScrollEventArgs e)
	{
		if (Operators.CompareString(MyProject.Forms.cslr2.lbcsx.get_Text(), ((Form)this).get_Text(), false) == 0 && ((DataGridView)CZDGV).get_FirstDisplayedScrollingRowIndex() != -1)
		{
			((DataGridView)MyProject.Forms.cslr2.DGV).set_FirstDisplayedScrollingRowIndex(((DataGridView)CZDGV).get_FirstDisplayedScrollingRowIndex());
		}
	}

	private void btnqk_Click(object sender, EventArgs e)
	{
		((DataGridView)CZDGV).get_Columns().Clear();
		((DataGridView)CZDGV).get_Rows().Clear();
	}

	private void CZDGV_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		liehao = e.get_ColumnIndex();
		((Form)MyProject.Forms.Dblcz).ShowDialog();
		((Component)(object)MyProject.Forms.Dblcz).Dispose();
	}

	private void CZDGV_RowEnter(object sender, DataGridViewCellEventArgs e)
	{
		if (Operators.CompareString(MyProject.Forms.cslr2.lbcsx.get_Text(), ((Form)this).get_Text(), false) == 0 && e.get_RowIndex() != -1 && ((DataGridView)MyProject.Forms.cslr2.DGV).get_Rows().get_Count() != 0)
		{
			((DataGridView)MyProject.Forms.cslr2.DGV).get_Rows().get_Item(e.get_RowIndex()).set_Selected(true);
		}
	}
}
