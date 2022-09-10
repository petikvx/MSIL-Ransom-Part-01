using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using Excel;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using xxx.My;

namespace xxx;

[DesignerGenerated]
public class ll_ufxnbinfoadd : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("ll_lbconfig")]
	private ListBox _ll_lbconfig;

	[AccessedThroughProperty("ll_txtstruct")]
	private TextBoxX _ll_txtstruct;

	[AccessedThroughProperty("DGV1")]
	private DataGridViewX _DGV1;

	[AccessedThroughProperty("ll_btnpath")]
	private ButtonX _ll_btnpath;

	[AccessedThroughProperty("ll_txtpath")]
	private TextBoxX _ll_txtpath;

	[AccessedThroughProperty("ll_lbxnfilelis")]
	private ListBox _ll_lbxnfilelis;

	[AccessedThroughProperty("LabelX1")]
	private LabelX _LabelX1;

	[AccessedThroughProperty("ll_lbliucheng")]
	private ListBox _ll_lbliucheng;

	[AccessedThroughProperty("ll_btnxlsall")]
	private ButtonX _ll_btnxlsall;

	[AccessedThroughProperty("ll_btnxlsother")]
	private ButtonX _ll_btnxlsother;

	[AccessedThroughProperty("ll_btnexit")]
	private ButtonX _ll_btnexit;

	[AccessedThroughProperty("btnOutPut")]
	private ButtonX _btnOutPut;

	[AccessedThroughProperty("PBX1")]
	private ProgressBarX _PBX1;

	[AccessedThroughProperty("LabelX2")]
	private LabelX _LabelX2;

	[AccessedThroughProperty("txtjindu")]
	private LabelX _txtjindu;

	[AccessedThroughProperty("btnsave")]
	private ButtonX _btnsave;

	[AccessedThroughProperty("btndr")]
	private ButtonX _btndr;

	[AccessedThroughProperty("SFD1")]
	private SaveFileDialog _SFD1;

	[AccessedThroughProperty("OPD1")]
	private OpenFileDialog _OPD1;

	private float H0;

	private float ROTX;

	private float ROTX2;

	private float ROTY2;

	private float ROTZ2;

	private float H1;

	private float H2;

	private float LZ0;

	private float ROTZ;

	private float H4;

	private float H3;

	private float XY_GSS;

	private float XL_GSS;

	private string resxlspath;

	private string curconstpath;

	private string whichstruct;

	private bool gaibian;

	internal virtual ListBox ll_lbconfig
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbconfig;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_lbconfig_DoubleClick;
			if (_ll_lbconfig != null)
			{
				((Control)_ll_lbconfig).remove_DoubleClick(eventHandler);
			}
			_ll_lbconfig = value;
			if (_ll_lbconfig != null)
			{
				((Control)_ll_lbconfig).add_DoubleClick(eventHandler);
			}
		}
	}

	internal virtual TextBoxX ll_txtstruct
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_txtstruct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_txtstruct = value;
		}
	}

	internal virtual DataGridViewX DGV1
	{
		[DebuggerNonUserCode]
		get
		{
			return _DGV1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			DataGridViewCellEventHandler val = new DataGridViewCellEventHandler(DGV1_CellValueChanged);
			if (_DGV1 != null)
			{
				((DataGridView)_DGV1).remove_CellValueChanged(val);
			}
			_DGV1 = value;
			if (_DGV1 != null)
			{
				((DataGridView)_DGV1).add_CellValueChanged(val);
			}
		}
	}

	internal virtual ButtonX ll_btnpath
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnpath;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnpath_Click;
			if (_ll_btnpath != null)
			{
				((Control)_ll_btnpath).remove_Click(eventHandler);
			}
			_ll_btnpath = value;
			if (_ll_btnpath != null)
			{
				((Control)_ll_btnpath).add_Click(eventHandler);
			}
		}
	}

	internal virtual TextBoxX ll_txtpath
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_txtpath;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_txtpath = value;
		}
	}

	internal virtual ListBox ll_lbxnfilelis
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbxnfilelis;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbxnfilelis = value;
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

	internal virtual ListBox ll_lbliucheng
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbliucheng;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbliucheng = value;
		}
	}

	internal virtual ButtonX ll_btnxlsall
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnxlsall;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnxlsall_Click;
			if (_ll_btnxlsall != null)
			{
				((Control)_ll_btnxlsall).remove_Click(eventHandler);
			}
			_ll_btnxlsall = value;
			if (_ll_btnxlsall != null)
			{
				((Control)_ll_btnxlsall).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btnxlsother
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnxlsother;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnxlsother_Click;
			if (_ll_btnxlsother != null)
			{
				((Control)_ll_btnxlsother).remove_Click(eventHandler);
			}
			_ll_btnxlsother = value;
			if (_ll_btnxlsother != null)
			{
				((Control)_ll_btnxlsother).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btnexit
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnexit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnexit_Click;
			if (_ll_btnexit != null)
			{
				((Control)_ll_btnexit).remove_Click(eventHandler);
			}
			_ll_btnexit = value;
			if (_ll_btnexit != null)
			{
				((Control)_ll_btnexit).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX btnOutPut
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnOutPut;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnOutPut_Click;
			if (_btnOutPut != null)
			{
				((Control)_btnOutPut).remove_Click(eventHandler);
			}
			_btnOutPut = value;
			if (_btnOutPut != null)
			{
				((Control)_btnOutPut).add_Click(eventHandler);
			}
		}
	}

	internal virtual ProgressBarX PBX1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PBX1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PBX1 = value;
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

	internal virtual LabelX txtjindu
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtjindu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtjindu = value;
		}
	}

	internal virtual ButtonX btnsave
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnsave;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnsave_Click;
			if (_btnsave != null)
			{
				((Control)_btnsave).remove_Click(eventHandler);
			}
			_btnsave = value;
			if (_btnsave != null)
			{
				((Control)_btnsave).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX btndr
	{
		[DebuggerNonUserCode]
		get
		{
			return _btndr;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btndr_Click;
			if (_btndr != null)
			{
				((Control)_btndr).remove_Click(eventHandler);
			}
			_btndr = value;
			if (_btndr != null)
			{
				((Control)_btndr).add_Click(eventHandler);
			}
		}
	}

	internal virtual SaveFileDialog SFD1
	{
		[DebuggerNonUserCode]
		get
		{
			return _SFD1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SFD1 = value;
		}
	}

	internal virtual OpenFileDialog OPD1
	{
		[DebuggerNonUserCode]
		get
		{
			return _OPD1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_OPD1 = value;
		}
	}

	public ll_ufxnbinfoadd()
	{
		((Form)this).add_Load((EventHandler)ll_ufxnbinfoadd_Load);
		XL_GSS = 0.98f;
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
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected O, but got Unknown
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Expected O, but got Unknown
		//IL_0b95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9f: Expected O, but got Unknown
		//IL_0ceb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf5: Expected O, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		ll_lbconfig = new ListBox();
		ll_txtstruct = new TextBoxX();
		DGV1 = new DataGridViewX();
		ll_btnpath = new ButtonX();
		ll_txtpath = new TextBoxX();
		ll_lbxnfilelis = new ListBox();
		LabelX1 = new LabelX();
		ll_lbliucheng = new ListBox();
		ll_btnxlsall = new ButtonX();
		ll_btnxlsother = new ButtonX();
		ll_btnexit = new ButtonX();
		btnOutPut = new ButtonX();
		PBX1 = new ProgressBarX();
		LabelX2 = new LabelX();
		txtjindu = new LabelX();
		btnsave = new ButtonX();
		btndr = new ButtonX();
		SFD1 = new SaveFileDialog();
		OPD1 = new OpenFileDialog();
		((ISupportInitialize)DGV1).BeginInit();
		((Control)this).SuspendLayout();
		((ListControl)ll_lbconfig).set_FormattingEnabled(true);
		ll_lbconfig.set_ItemHeight(12);
		ListBox obj = ll_lbconfig;
		Point location = new Point(7, 12);
		((Control)obj).set_Location(location);
		((Control)ll_lbconfig).set_Name("ll_lbconfig");
		ListBox obj2 = ll_lbconfig;
		Size size = new Size(156, 232);
		((Control)obj2).set_Size(size);
		((Control)ll_lbconfig).set_TabIndex(0);
		ll_txtstruct.get_Border().set_Class("TextBoxBorder");
		ll_txtstruct.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj3 = ll_txtstruct;
		location = new Point(7, 251);
		((Control)obj3).set_Location(location);
		((Control)ll_txtstruct).set_Name("ll_txtstruct");
		((TextBoxBase)ll_txtstruct).set_ReadOnly(true);
		TextBoxX obj4 = ll_txtstruct;
		size = new Size(156, 21);
		((Control)obj4).set_Size(size);
		((Control)ll_txtstruct).set_TabIndex(1);
		((DataGridView)DGV1).set_AllowUserToAddRows(false);
		((DataGridView)DGV1).set_AllowUserToDeleteRows(false);
		((DataGridView)DGV1).set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)6);
		((DataGridView)DGV1).set_AutoSizeRowsMode((DataGridViewAutoSizeRowsMode)7);
		val.set_Alignment((DataGridViewContentAlignment)16);
		val.set_BackColor(SystemColors.Control);
		val.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		val.set_ForeColor(SystemColors.WindowText);
		val.set_SelectionBackColor(SystemColors.Highlight);
		val.set_SelectionForeColor(SystemColors.HighlightText);
		val.set_WrapMode((DataGridViewTriState)1);
		((DataGridView)DGV1).set_ColumnHeadersDefaultCellStyle(val);
		((DataGridView)DGV1).set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)1);
		val2.set_Alignment((DataGridViewContentAlignment)16);
		val2.set_BackColor(SystemColors.Window);
		val2.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		val2.set_ForeColor(SystemColors.ControlText);
		val2.set_SelectionBackColor(SystemColors.Highlight);
		val2.set_SelectionForeColor(SystemColors.ControlText);
		val2.set_WrapMode((DataGridViewTriState)2);
		((DataGridView)DGV1).set_DefaultCellStyle(val2);
		((DataGridView)DGV1).set_GridColor(Color.FromArgb(208, 215, 229));
		DataGridViewX dGV = DGV1;
		location = new Point(169, 12);
		((Control)dGV).set_Location(location);
		((DataGridView)DGV1).set_MultiSelect(false);
		((Control)DGV1).set_Name("DGV1");
		val3.set_Alignment((DataGridViewContentAlignment)16);
		val3.set_BackColor(SystemColors.Control);
		val3.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		val3.set_ForeColor(SystemColors.WindowText);
		val3.set_SelectionBackColor(SystemColors.Highlight);
		val3.set_SelectionForeColor(SystemColors.HighlightText);
		val3.set_WrapMode((DataGridViewTriState)1);
		((DataGridView)DGV1).set_RowHeadersDefaultCellStyle(val3);
		((DataGridView)DGV1).get_RowTemplate().set_Height(23);
		((DataGridView)DGV1).set_SelectionMode((DataGridViewSelectionMode)1);
		DataGridViewX dGV2 = DGV1;
		size = new Size(725, 232);
		((Control)dGV2).set_Size(size);
		((Control)DGV1).set_TabIndex(2);
		((Control)ll_btnpath).set_AccessibleRole((AccessibleRole)43);
		ll_btnpath.set_ColorTable((eButtonColor)3);
		ButtonX obj5 = ll_btnpath;
		location = new Point(7, 285);
		((Control)obj5).set_Location(location);
		((Control)ll_btnpath).set_Name("ll_btnpath");
		ButtonX obj6 = ll_btnpath;
		size = new Size(178, 23);
		((Control)obj6).set_Size(size);
		((PopupItemControl)ll_btnpath).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnpath).set_TabIndex(3);
		ll_btnpath.set_Text("指定待处理性能表所在路径...");
		ll_txtpath.get_Border().set_Class("TextBoxBorder");
		ll_txtpath.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj7 = ll_txtpath;
		location = new Point(188, 287);
		((Control)obj7).set_Location(location);
		((Control)ll_txtpath).set_Name("ll_txtpath");
		((TextBoxBase)ll_txtpath).set_ReadOnly(true);
		TextBoxX obj8 = ll_txtpath;
		size = new Size(532, 21);
		((Control)obj8).set_Size(size);
		((Control)ll_txtpath).set_TabIndex(4);
		((ListControl)ll_lbxnfilelis).set_FormattingEnabled(true);
		ll_lbxnfilelis.set_ItemHeight(12);
		ListBox obj9 = ll_lbxnfilelis;
		location = new Point(7, 313);
		((Control)obj9).set_Location(location);
		((Control)ll_lbxnfilelis).set_Name("ll_lbxnfilelis");
		ll_lbxnfilelis.set_SelectionMode((SelectionMode)2);
		ListBox obj10 = ll_lbxnfilelis;
		size = new Size(713, 100);
		((Control)obj10).set_Size(size);
		((Control)ll_lbxnfilelis).set_TabIndex(0);
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX = LabelX1;
		location = new Point(7, 419);
		((Control)labelX).set_Location(location);
		((Control)LabelX1).set_Name("LabelX1");
		LabelX labelX2 = LabelX1;
		size = new Size(156, 23);
		((Control)labelX2).set_Size(size);
		((Control)LabelX1).set_TabIndex(5);
		LabelX1.set_Text("操作流程信息");
		((ListControl)ll_lbliucheng).set_FormattingEnabled(true);
		ll_lbliucheng.set_ItemHeight(12);
		ListBox obj11 = ll_lbliucheng;
		location = new Point(7, 448);
		((Control)obj11).set_Location(location);
		((Control)ll_lbliucheng).set_Name("ll_lbliucheng");
		ListBox obj12 = ll_lbliucheng;
		size = new Size(887, 100);
		((Control)obj12).set_Size(size);
		((Control)ll_lbliucheng).set_TabIndex(0);
		((Control)ll_btnxlsall).set_AccessibleRole((AccessibleRole)43);
		ll_btnxlsall.set_ColorTable((eButtonColor)3);
		ButtonX obj13 = ll_btnxlsall;
		location = new Point(735, 313);
		((Control)obj13).set_Location(location);
		((Control)ll_btnxlsall).set_Name("ll_btnxlsall");
		ButtonX obj14 = ll_btnxlsall;
		size = new Size(159, 23);
		((Control)obj14).set_Size(size);
		((PopupItemControl)ll_btnxlsall).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnxlsall).set_TabIndex(3);
		ll_btnxlsall.set_Text("全选");
		((Control)ll_btnxlsother).set_AccessibleRole((AccessibleRole)43);
		ll_btnxlsother.set_ColorTable((eButtonColor)3);
		ButtonX obj15 = ll_btnxlsother;
		location = new Point(735, 342);
		((Control)obj15).set_Location(location);
		((Control)ll_btnxlsother).set_Name("ll_btnxlsother");
		ButtonX obj16 = ll_btnxlsother;
		size = new Size(159, 23);
		((Control)obj16).set_Size(size);
		((PopupItemControl)ll_btnxlsother).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnxlsother).set_TabIndex(3);
		ll_btnxlsother.set_Text("反选");
		((Control)ll_btnexit).set_AccessibleRole((AccessibleRole)43);
		ll_btnexit.set_ColorTable((eButtonColor)3);
		ll_btnexit.set_DialogResult((DialogResult)2);
		ButtonX obj17 = ll_btnexit;
		location = new Point(735, 419);
		((Control)obj17).set_Location(location);
		((Control)ll_btnexit).set_Name("ll_btnexit");
		ButtonX obj18 = ll_btnexit;
		size = new Size(159, 23);
		((Control)obj18).set_Size(size);
		((PopupItemControl)ll_btnexit).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnexit).set_TabIndex(3);
		ll_btnexit.set_Text("关闭");
		((Control)btnOutPut).set_AccessibleRole((AccessibleRole)43);
		btnOutPut.set_ColorTable((eButtonColor)3);
		((Control)btnOutPut).set_Enabled(false);
		ButtonX obj19 = btnOutPut;
		location = new Point(735, 371);
		((Control)obj19).set_Location(location);
		((Control)btnOutPut).set_Name("btnOutPut");
		ButtonX obj20 = btnOutPut;
		size = new Size(159, 23);
		((Control)obj20).set_Size(size);
		((PopupItemControl)btnOutPut).set_Style((eDotNetBarStyle)7);
		((Control)btnOutPut).set_TabIndex(3);
		btnOutPut.set_Text("开始追加信息");
		((BaseItemControl)PBX1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)PBX1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		ProgressBarX pBX = PBX1;
		location = new Point(243, 419);
		((Control)pBX).set_Location(location);
		((Control)PBX1).set_Name("PBX1");
		ProgressBarX pBX2 = PBX1;
		size = new Size(438, 23);
		((Control)pBX2).set_Size(size);
		((Control)PBX1).set_TabIndex(6);
		((Control)PBX1).set_Text("ProgressBarX1");
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX3 = LabelX2;
		location = new Point(169, 419);
		((Control)labelX3).set_Location(location);
		((Control)LabelX2).set_Name("LabelX2");
		LabelX labelX4 = LabelX2;
		size = new Size(68, 23);
		((Control)labelX4).set_Size(size);
		((Control)LabelX2).set_TabIndex(5);
		LabelX2.set_Text("当前进度：");
		((BaseItemControl)txtjindu).get_BackgroundStyle().set_Class("");
		((BaseItemControl)txtjindu).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX obj21 = txtjindu;
		location = new Point(687, 419);
		((Control)obj21).set_Location(location);
		((Control)txtjindu).set_Name("txtjindu");
		LabelX obj22 = txtjindu;
		size = new Size(42, 23);
		((Control)obj22).set_Size(size);
		((Control)txtjindu).set_TabIndex(5);
		txtjindu.set_Text("0%");
		((Control)btnsave).set_AccessibleRole((AccessibleRole)43);
		btnsave.set_ColorTable((eButtonColor)3);
		ButtonX obj23 = btnsave;
		location = new Point(312, 249);
		((Control)obj23).set_Location(location);
		((Control)btnsave).set_Name("btnsave");
		ButtonX obj24 = btnsave;
		size = new Size(175, 23);
		((Control)obj24).set_Size(size);
		((PopupItemControl)btnsave).set_Style((eDotNetBarStyle)7);
		((Control)btnsave).set_TabIndex(3);
		btnsave.set_Text("保存当前常量至文件...");
		((Control)btndr).set_AccessibleRole((AccessibleRole)43);
		btndr.set_ColorTable((eButtonColor)3);
		ButtonX obj25 = btndr;
		location = new Point(538, 249);
		((Control)obj25).set_Location(location);
		((Control)btndr).set_Name("btndr");
		ButtonX obj26 = btndr;
		size = new Size(182, 23);
		((Control)obj26).set_Size(size);
		((PopupItemControl)btndr).set_Style((eDotNetBarStyle)7);
		((Control)btndr).set_TabIndex(3);
		btndr.set_Text("导入常量文件至当前表格...");
		((FileDialog)SFD1).set_Filter("*.ini|*.ini");
		SizeF autoScaleDimensions = new SizeF(6f, 12f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_CancelButton((IButtonControl)(object)ll_btnexit);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		size = new Size(902, 557);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)PBX1);
		((Control)this).get_Controls().Add((Control)(object)txtjindu);
		((Control)this).get_Controls().Add((Control)(object)LabelX2);
		((Control)this).get_Controls().Add((Control)(object)LabelX1);
		((Control)this).get_Controls().Add((Control)(object)ll_txtpath);
		((Control)this).get_Controls().Add((Control)(object)btndr);
		((Control)this).get_Controls().Add((Control)(object)btnsave);
		((Control)this).get_Controls().Add((Control)(object)ll_btnexit);
		((Control)this).get_Controls().Add((Control)(object)btnOutPut);
		((Control)this).get_Controls().Add((Control)(object)ll_btnxlsother);
		((Control)this).get_Controls().Add((Control)(object)ll_btnxlsall);
		((Control)this).get_Controls().Add((Control)(object)ll_btnpath);
		((Control)this).get_Controls().Add((Control)(object)DGV1);
		((Control)this).get_Controls().Add((Control)(object)ll_txtstruct);
		((Control)this).get_Controls().Add((Control)(object)ll_lbliucheng);
		((Control)this).get_Controls().Add((Control)(object)ll_lbxnfilelis);
		((Control)this).get_Controls().Add((Control)(object)ll_lbconfig);
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("ll_ufxnbinfoadd");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("性能表信息追加.. .");
		((ISupportInitialize)DGV1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void ll_ufxnbinfoadd_Load(object sender, EventArgs e)
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		curconstpath = Application.get_StartupPath() + "\\config\\xnbinfoadd";
		string path = curconstpath + "\\config.ini";
		if (File.Exists(path))
		{
			Mod1.lr = new StreamReader(path, Encoding.Default);
			string text = "";
			while (!Information.IsNothing((object)text))
			{
				text = Mod1.lr.ReadLine();
				if (Operators.CompareString(Strings.Trim(text), "", false) != 0)
				{
					ll_lbconfig.get_Items().Add((object)text);
				}
			}
			Mod1.lr.Close();
			Mod1.lr.Dispose();
		}
		else
		{
			Interaction.MsgBox((object)(curconstpath + "\\config.ini 不存在！"), (MsgBoxStyle)64, (object)"提示");
		}
	}

	private void ll_btnpath_Click(object sender, EventArgs e)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Invalid comparison between Unknown and I4
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Invalid comparison between Unknown and I4
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (Operators.CompareString(Strings.Trim(((TextBox)ll_txtstruct).get_Text()), "", false) == 0)
			{
				Interaction.MsgBox((object)"请在列表框中双击选择一种结构形式.", (MsgBoxStyle)64, (object)"提示");
				return;
			}
			FolderBrowserDialog val = new FolderBrowserDialog();
			val.set_Description("请指定某文件夹,要求其中含有Ansys11.0 性能表浏览器输出的性能表xls文件");
			if ((int)((CommonDialog)val).ShowDialog() != 1)
			{
				return;
			}
			Mod1.strpath = val.get_SelectedPath();
			if (Operators.CompareString(Strings.Trim(Mod1.strpath), "", false) == 0)
			{
				return;
			}
			((TextBox)ll_txtpath).set_Text(Mod1.strpath);
			ll_lbliucheng.get_Items().Add((object)("指定的待处理xls文件夹为:" + Mod1.strpath));
			checked
			{
				ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
				resxlspath = Mod1.strpath + "\\results2";
				if (!Directory.Exists(resxlspath))
				{
					FileSystem.MkDir(resxlspath);
				}
				else
				{
					if (unchecked((int)MessageBox.Show("当前已经存在文件夹:" + resxlspath + " 是否继续?", "提示", (MessageBoxButtons)4, (MessageBoxIcon)64)) == 7)
					{
						ll_lbliucheng.get_Items().Add((object)("当前已经存在文件夹:" + resxlspath + "建议先删除再继续本次操作."));
						ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
						return;
					}
					ll_lbliucheng.get_Items().Add((object)("接下来的输出文件将覆盖文件夹:" + resxlspath + "中已有文件."));
					ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
				}
				string path = ((TextBox)ll_txtpath).get_Text() + "\\";
				ll_lbxnfilelis.get_Items().Clear();
				string[] files = Directory.GetFiles(path, "*.xls", SearchOption.TopDirectoryOnly);
				if (files.Count() != 0)
				{
					int num = files.Count() - 1;
					for (int i = 0; i <= num; i++)
					{
						ll_lbxnfilelis.get_Items().Add((object)files[i]);
					}
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			((TextBox)ll_txtpath).set_Text("");
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)64, (object)"提示");
			ProjectData.ClearProjectError();
		}
	}

	private void ll_btnxlsall_Click(object sender, EventArgs e)
	{
		checked
		{
			int num = ll_lbxnfilelis.get_Items().get_Count() - 1;
			for (int i = 0; i <= num; i++)
			{
				ll_lbxnfilelis.SetSelected(i, true);
			}
		}
	}

	private void ll_btnxlsother_Click(object sender, EventArgs e)
	{
		checked
		{
			int num = ll_lbxnfilelis.get_Items().get_Count() - 1;
			for (int i = 0; i <= num; i++)
			{
				if (ll_lbxnfilelis.GetSelected(i))
				{
					ll_lbxnfilelis.SetSelected(i, false);
				}
				else
				{
					ll_lbxnfilelis.SetSelected(i, true);
				}
			}
		}
	}

	private void inputconst(string whichstruct)
	{
		//IL_0930: Unknown result type (might be due to invalid IL or missing references)
		//IL_093a: Expected O, but got Unknown
		//IL_096d: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		checked
		{
			try
			{
				((DataGridView)DGV1).get_Columns().Clear();
				((DataGridView)DGV1).get_Rows().Clear();
				string text = "";
				switch (whichstruct)
				{
				case "主臂":
				{
					string text2 = curconstpath + "\\zb_const.ini";
					if (File.Exists(text2))
					{
						((DataGridView)DGV1).get_Columns().Add("参数名称", "参数名称");
						((DataGridView)DGV1).get_Columns().get_Item(0).set_ReadOnly(true);
						((DataGridView)DGV1).get_Columns().Add("参数值", "参数值");
						((DataGridView)DGV1).get_Columns().Add("备注", "备注");
						((DataGridView)DGV1).get_Columns().get_Item(2).set_ReadOnly(true);
						Mod1.lr = new StreamReader(text2, Encoding.Default);
						while (!Information.IsNothing((object)text))
						{
							text = Mod1.lr.ReadLine();
							if (Operators.CompareString(Strings.Trim(text), "", false) != 0)
							{
								string[] array = Strings.Split(text, "=", -1, (CompareMethod)0);
								string[] array2 = array[1].Split(new char[1] { '!' });
								((DataGridView)DGV1).get_Rows().Add();
								((DataGridView)DGV1).get_Rows().get_Item(num).get_Cells()
									.get_Item(0)
									.set_Value((object)Strings.Trim(array[0]));
								((DataGridView)DGV1).get_Rows().get_Item(num).get_Cells()
									.get_Item(1)
									.set_Value((object)Strings.Trim(array2[0]));
								if (array[1].IndexOf("!") != -1)
								{
									((DataGridView)DGV1).get_Rows().get_Item(num).get_Cells()
										.get_Item(2)
										.set_Value((object)Strings.Trim(array2[1]));
								}
								num++;
								switch (Strings.UCase(Strings.Trim(array[0])))
								{
								case "H0":
									H0 = Conversions.ToSingle(array2[0]);
									break;
								case "ROTX":
									ROTX = Conversions.ToSingle(array2[0]);
									break;
								case "XY_GSS":
									XY_GSS = Conversions.ToSingle(array2[0]);
									break;
								default:
									ll_lbliucheng.get_Items().Add((object)("不合法的配置项:" + array[0]));
									break;
								}
							}
						}
						Mod1.lr.Close();
						Mod1.lr.Dispose();
						ll_lbliucheng.get_Items().Add((object)("读取了常量文件:" + text2));
					}
					else
					{
						ll_lbliucheng.get_Items().Add((object)("常量文件不存在:" + text2));
					}
					break;
				}
				case "主臂+固定副臂":
				{
					string text2 = curconstpath + "\\fb_const.ini";
					if (File.Exists(text2))
					{
						((DataGridView)DGV1).get_Columns().Add("参数名称", "参数名称");
						((DataGridView)DGV1).get_Columns().get_Item(0).set_ReadOnly(true);
						((DataGridView)DGV1).get_Columns().Add("参数值", "参数值");
						((DataGridView)DGV1).get_Columns().Add("备注", "备注");
						((DataGridView)DGV1).get_Columns().get_Item(2).set_ReadOnly(true);
						Mod1.lr = new StreamReader(text2, Encoding.Default);
						while (!Information.IsNothing((object)text))
						{
							text = Mod1.lr.ReadLine();
							if (Operators.CompareString(Strings.Trim(text), "", false) != 0)
							{
								string[] array = Strings.Split(text, "=", -1, (CompareMethod)0);
								string[] array2 = array[1].Split(new char[1] { '!' });
								((DataGridView)DGV1).get_Rows().Add();
								((DataGridView)DGV1).get_Rows().get_Item(num).get_Cells()
									.get_Item(0)
									.set_Value((object)Strings.Trim(array[0]));
								((DataGridView)DGV1).get_Rows().get_Item(num).get_Cells()
									.get_Item(1)
									.set_Value((object)Strings.Trim(array2[0]));
								if (array[1].IndexOf("!") != -1)
								{
									((DataGridView)DGV1).get_Rows().get_Item(num).get_Cells()
										.get_Item(2)
										.set_Value((object)Strings.Trim(array2[1]));
								}
								num++;
								switch (Strings.UCase(Strings.Trim(array[0])))
								{
								case "ROTX2":
									ROTX2 = Conversions.ToSingle(array2[0]);
									break;
								case "ROTY2":
									ROTY2 = Conversions.ToSingle(array2[0]);
									break;
								case "ROTZ2":
									ROTZ2 = Conversions.ToSingle(array2[0]);
									break;
								case "H1":
									H1 = Conversions.ToSingle(array2[0]);
									break;
								case "H2":
									H2 = Conversions.ToSingle(array2[0]);
									break;
								case "LZ0":
									LZ0 = Conversions.ToSingle(array2[0]);
									break;
								case "ROTX":
									ROTX = Conversions.ToSingle(array2[0]);
									break;
								case "ROTZ":
									ROTZ = Conversions.ToSingle(array2[0]);
									break;
								case "XY_GSS":
									XY_GSS = Conversions.ToSingle(array2[0]);
									break;
								default:
									ll_lbliucheng.get_Items().Add((object)(text2 + "中存在不合法的配置项:" + array[0]));
									break;
								}
							}
						}
						Mod1.lr.Close();
						Mod1.lr.Dispose();
						ll_lbliucheng.get_Items().Add((object)("读取了常量文件:" + text2));
					}
					else
					{
						ll_lbliucheng.get_Items().Add((object)("常量文件不存在:" + text2));
					}
					break;
				}
				case "主臂+塔式副臂":
				{
					string text2 = curconstpath + "\\tb_const.ini";
					if (File.Exists(text2))
					{
						((DataGridView)DGV1).get_Columns().Add("参数名称", "参数名称");
						((DataGridView)DGV1).get_Columns().get_Item(0).set_ReadOnly(true);
						((DataGridView)DGV1).get_Columns().Add("参数值", "参数值");
						((DataGridView)DGV1).get_Columns().Add("备注", "备注");
						((DataGridView)DGV1).get_Columns().get_Item(2).set_ReadOnly(true);
						Mod1.lr = new StreamReader(text2, Encoding.Default);
						while (!Information.IsNothing((object)text))
						{
							text = Mod1.lr.ReadLine();
							if (Operators.CompareString(Strings.Trim(text), "", false) != 0)
							{
								string[] array = Strings.Split(text, "=", -1, (CompareMethod)0);
								string[] array2 = array[1].Split(new char[1] { '!' });
								((DataGridView)DGV1).get_Rows().Add();
								((DataGridView)DGV1).get_Rows().get_Item(num).get_Cells()
									.get_Item(0)
									.set_Value((object)Strings.Trim(array[0]));
								((DataGridView)DGV1).get_Rows().get_Item(num).get_Cells()
									.get_Item(1)
									.set_Value((object)Strings.Trim(array2[0]));
								if (array[1].IndexOf("!") != -1)
								{
									((DataGridView)DGV1).get_Rows().get_Item(num).get_Cells()
										.get_Item(2)
										.set_Value((object)Strings.Trim(array2[1]));
								}
								num++;
								switch (Strings.UCase(Strings.Trim(array[0])))
								{
								case "H4":
									H4 = Conversions.ToSingle(array2[0]);
									break;
								case "H3":
									H3 = Conversions.ToSingle(array2[0]);
									break;
								case "ROTX":
									ROTX = Conversions.ToSingle(array2[0]);
									break;
								case "XY_GSS":
									XY_GSS = Conversions.ToSingle(array2[0]);
									break;
								default:
									ll_lbliucheng.get_Items().Add((object)(text2 + "中存在不合法的配置项:" + array[0]));
									break;
								}
							}
						}
						Mod1.lr.Close();
						Mod1.lr.Dispose();
						ll_lbliucheng.get_Items().Add((object)("读取了常量文件:" + text2));
					}
					else
					{
						ll_lbliucheng.get_Items().Add((object)("常量文件不存在:" + text2));
					}
					break;
				}
				default:
					ll_lbliucheng.get_Items().Add((object)("不存在的结构形式: " + whichstruct));
					break;
				}
				gaibian = true;
				DataGridView datagv = (DataGridView)(object)DGV1;
				Mod1.Jzpx(ref datagv);
				DGV1 = (DataGridViewX)datagv;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox((object)(ex2.Message.ToString() + "\r" + ex2.StackTrace!.ToString()), (MsgBoxStyle)64, (object)"提示");
				ProjectData.ClearProjectError();
			}
		}
	}

	private void inputini(string p, string whichstruct)
	{
		//IL_0903: Unknown result type (might be due to invalid IL or missing references)
		//IL_090d: Expected O, but got Unknown
		//IL_0940: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		checked
		{
			try
			{
				((DataGridView)DGV1).get_Columns().Clear();
				((DataGridView)DGV1).get_Rows().Clear();
				string text = "";
				switch (whichstruct)
				{
				case "主臂":
				{
					string text2 = p;
					if (File.Exists(text2))
					{
						((DataGridView)DGV1).get_Columns().Add("参数名称", "参数名称");
						((DataGridView)DGV1).get_Columns().get_Item(0).set_ReadOnly(true);
						((DataGridView)DGV1).get_Columns().Add("参数值", "参数值");
						((DataGridView)DGV1).get_Columns().Add("备注", "备注");
						((DataGridView)DGV1).get_Columns().get_Item(2).set_ReadOnly(true);
						Mod1.lr = new StreamReader(text2, Encoding.Default);
						while (!Information.IsNothing((object)text))
						{
							text = Mod1.lr.ReadLine();
							if (Operators.CompareString(Strings.Trim(text), "", false) != 0)
							{
								string[] array = Strings.Split(text, "=", -1, (CompareMethod)0);
								string[] array2 = array[1].Split(new char[1] { '!' });
								((DataGridView)DGV1).get_Rows().Add();
								((DataGridView)DGV1).get_Rows().get_Item(num).get_Cells()
									.get_Item(0)
									.set_Value((object)Strings.Trim(array[0]));
								((DataGridView)DGV1).get_Rows().get_Item(num).get_Cells()
									.get_Item(1)
									.set_Value((object)Strings.Trim(array2[0]));
								if (array[1].IndexOf("!") != -1)
								{
									((DataGridView)DGV1).get_Rows().get_Item(num).get_Cells()
										.get_Item(2)
										.set_Value((object)Strings.Trim(array2[1]));
								}
								num++;
								switch (Strings.UCase(Strings.Trim(array[0])))
								{
								case "H0":
									H0 = Conversions.ToSingle(array2[0]);
									break;
								case "ROTX":
									ROTX = Conversions.ToSingle(array2[0]);
									break;
								case "XY_GSS":
									XY_GSS = Conversions.ToSingle(array2[0]);
									break;
								default:
									ll_lbliucheng.get_Items().Add((object)("不合法的配置项:" + array[0]));
									break;
								}
							}
						}
						Mod1.lr.Close();
						Mod1.lr.Dispose();
						ll_lbliucheng.get_Items().Add((object)("读取了常量文件:" + text2));
					}
					else
					{
						ll_lbliucheng.get_Items().Add((object)("常量文件不存在:" + text2));
					}
					break;
				}
				case "主臂+固定副臂":
				{
					string text2 = p;
					if (File.Exists(text2))
					{
						((DataGridView)DGV1).get_Columns().Add("参数名称", "参数名称");
						((DataGridView)DGV1).get_Columns().get_Item(0).set_ReadOnly(true);
						((DataGridView)DGV1).get_Columns().Add("参数值", "参数值");
						((DataGridView)DGV1).get_Columns().Add("备注", "备注");
						((DataGridView)DGV1).get_Columns().get_Item(2).set_ReadOnly(true);
						Mod1.lr = new StreamReader(text2, Encoding.Default);
						while (!Information.IsNothing((object)text))
						{
							text = Mod1.lr.ReadLine();
							if (Operators.CompareString(Strings.Trim(text), "", false) != 0)
							{
								string[] array = Strings.Split(text, "=", -1, (CompareMethod)0);
								string[] array2 = array[1].Split(new char[1] { '!' });
								((DataGridView)DGV1).get_Rows().Add();
								((DataGridView)DGV1).get_Rows().get_Item(num).get_Cells()
									.get_Item(0)
									.set_Value((object)Strings.Trim(array[0]));
								((DataGridView)DGV1).get_Rows().get_Item(num).get_Cells()
									.get_Item(1)
									.set_Value((object)Strings.Trim(array2[0]));
								if (array[1].IndexOf("!") != -1)
								{
									((DataGridView)DGV1).get_Rows().get_Item(num).get_Cells()
										.get_Item(2)
										.set_Value((object)Strings.Trim(array2[1]));
								}
								num++;
								switch (Strings.UCase(Strings.Trim(array[0])))
								{
								case "ROTX2":
									ROTX2 = Conversions.ToSingle(array2[0]);
									break;
								case "ROTY2":
									ROTY2 = Conversions.ToSingle(array2[0]);
									break;
								case "ROTZ2":
									ROTZ2 = Conversions.ToSingle(array2[0]);
									break;
								case "H1":
									H1 = Conversions.ToSingle(array2[0]);
									break;
								case "H2":
									H2 = Conversions.ToSingle(array2[0]);
									break;
								case "LZ0":
									LZ0 = Conversions.ToSingle(array2[0]);
									break;
								case "ROTX":
									ROTX = Conversions.ToSingle(array2[0]);
									break;
								case "ROTZ":
									ROTZ = Conversions.ToSingle(array2[0]);
									break;
								case "XY_GSS":
									XY_GSS = Conversions.ToSingle(array2[0]);
									break;
								default:
									ll_lbliucheng.get_Items().Add((object)(text2 + "中存在不合法的配置项:" + array[0]));
									break;
								}
							}
						}
						Mod1.lr.Close();
						Mod1.lr.Dispose();
						ll_lbliucheng.get_Items().Add((object)("读取了常量文件:" + text2));
					}
					else
					{
						ll_lbliucheng.get_Items().Add((object)("常量文件不存在:" + text2));
					}
					break;
				}
				case "主臂+塔式副臂":
				{
					string text2 = p;
					if (File.Exists(text2))
					{
						((DataGridView)DGV1).get_Columns().Add("参数名称", "参数名称");
						((DataGridView)DGV1).get_Columns().get_Item(0).set_ReadOnly(true);
						((DataGridView)DGV1).get_Columns().Add("参数值", "参数值");
						((DataGridView)DGV1).get_Columns().Add("备注", "备注");
						((DataGridView)DGV1).get_Columns().get_Item(2).set_ReadOnly(true);
						Mod1.lr = new StreamReader(text2, Encoding.Default);
						while (!Information.IsNothing((object)text))
						{
							text = Mod1.lr.ReadLine();
							if (Operators.CompareString(Strings.Trim(text), "", false) != 0)
							{
								string[] array = Strings.Split(text, "=", -1, (CompareMethod)0);
								string[] array2 = array[1].Split(new char[1] { '!' });
								((DataGridView)DGV1).get_Rows().Add();
								((DataGridView)DGV1).get_Rows().get_Item(num).get_Cells()
									.get_Item(0)
									.set_Value((object)Strings.Trim(array[0]));
								((DataGridView)DGV1).get_Rows().get_Item(num).get_Cells()
									.get_Item(1)
									.set_Value((object)Strings.Trim(array2[0]));
								if (array[1].IndexOf("!") != -1)
								{
									((DataGridView)DGV1).get_Rows().get_Item(num).get_Cells()
										.get_Item(2)
										.set_Value((object)Strings.Trim(array2[1]));
								}
								num++;
								switch (Strings.UCase(Strings.Trim(array[0])))
								{
								case "H4":
									H4 = Conversions.ToSingle(array2[0]);
									break;
								case "H3":
									H3 = Conversions.ToSingle(array2[0]);
									break;
								case "ROTX":
									ROTX = Conversions.ToSingle(array2[0]);
									break;
								case "XY_GSS":
									XY_GSS = Conversions.ToSingle(array2[0]);
									break;
								default:
									ll_lbliucheng.get_Items().Add((object)(text2 + "中存在不合法的配置项:" + array[0]));
									break;
								}
							}
						}
						Mod1.lr.Close();
						Mod1.lr.Dispose();
						ll_lbliucheng.get_Items().Add((object)("读取了常量文件:" + text2));
					}
					else
					{
						ll_lbliucheng.get_Items().Add((object)("常量文件不存在:" + text2));
					}
					break;
				}
				default:
					ll_lbliucheng.get_Items().Add((object)("不存在的结构形式: " + whichstruct));
					break;
				}
				gaibian = true;
				DataGridView datagv = (DataGridView)(object)DGV1;
				Mod1.Jzpx(ref datagv);
				DGV1 = (DataGridViewX)datagv;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox((object)(ex2.Message.ToString() + "\r" + ex2.StackTrace!.ToString()), (MsgBoxStyle)64, (object)"提示");
				ProjectData.ClearProjectError();
			}
		}
	}

	private void btnOutPut_Click(object sender, EventArgs e)
	{
		//IL_1c7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cb3: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				if (ll_lbxnfilelis.get_Items().get_Count() == 0 || Operators.CompareString(((TextBox)ll_txtstruct).get_Text(), "", false) == 0)
				{
					return;
				}
				((Control)this).set_Cursor(Cursors.get_AppStarting());
				PBX1.set_Value(0);
				txtjindu.set_Text("0%");
				((Control)txtjindu).Refresh();
				string text = whichstruct;
				int num = default(int);
				int num2 = default(int);
				if (Operators.CompareString(text, "主臂+固定副臂", false) == 0)
				{
					string text2 = Interaction.InputBox("请指定【安装角度】所在位置:\r\n如文件名称：主臂+固定副臂_80_全伸_0_副臂优先_12_12567.xls\r\n\r\n0 1 2 3 4 5 6\r\n如直接回车或取消，则默认为 3\r\n\r\n请输入位置序号:", "当前文件名称中的【安装角度】位置指定", "", -1, -1);
					num = ((Operators.CompareString(Strings.Trim(text2), "", false) != 0) ? Conversions.ToInteger(text2) : 3);
					text2 = Interaction.InputBox("请指定【副臂长度】所在位置:\r\n如文件名称：主臂+固定副臂_80_全伸_0_副臂优先_12_12567.xls\r\n\r\n0 1 2 3 4 5 6\r\n如直接回车或取消，则默认为 5\r\n\r\n请输入位置序号:", "当前文件名称中的【副臂长度】位置指定", "", -1, -1);
					num2 = ((Operators.CompareString(Strings.Trim(text2), "", false) != 0) ? Conversions.ToInteger(text2) : 5);
					ll_lbliucheng.get_Items().Add((object)("当前的安装角度位置为:" + Conversions.ToString(num)));
					ll_lbliucheng.get_Items().Add((object)("当前的副臂长度所在位置为:" + Conversions.ToString(num2)));
					ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
				}
				else if (Operators.CompareString(text, "主臂+塔式副臂", false) == 0)
				{
					string text2 = Interaction.InputBox("请指定【主臂仰角】所在位置:\r\n如文件名称：塔式副臂_160_13000_67_副臂优先_84_12567.xls\r\n\r\n0 1 2 3 4 5 6 7 8 9\r\n如直接回车或取消，则默认为 3\r\n\r\n请输入位置序号:", "当前文件名称中的【安装角度】位置指定", "", -1, -1);
					num = ((Operators.CompareString(Strings.Trim(text2), "", false) != 0) ? Conversions.ToInteger(text2) : 3);
					text2 = Interaction.InputBox("请指定【副臂长度】所在位置:\r\n如文件名称：塔式副臂_160_13000_67_副臂优先_84_12567.xls\r\n\r\n0 1 2 3 4 5 6 7 8 9\r\n如直接回车或取消，则默认为 5\r\n\r\n请输入位置序号:", "当前文件名称中的【副臂长度】位置指定", "", -1, -1);
					num2 = ((Operators.CompareString(Strings.Trim(text2), "", false) != 0) ? Conversions.ToInteger(text2) : 5);
					ll_lbliucheng.get_Items().Add((object)("当前的安装角度位置为:" + Conversions.ToString(num)));
					ll_lbliucheng.get_Items().Add((object)("当前的副臂长度所在位置为:" + Conversions.ToString(num2)));
					ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
				}
				if (File.Exists(Application.get_StartupPath() + "\\config\\ALL.xls"))
				{
					string filename = Application.get_StartupPath() + "\\config\\ALL.xls";
					Worksheet worksheet = (Worksheet)Mod1.excelapp.Workbooks.Open(filename, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value).Sheets["ALL"];
					Mod1.excelapp.DisplayAlerts = false;
					((Control)this).Refresh();
					int num3 = 0;
					PBX1.set_Maximum(ll_lbxnfilelis.get_Items().get_Count());
					int num4 = ll_lbxnfilelis.get_Items().get_Count() - 1;
					for (int i = 0; i <= num4; i++)
					{
						txtjindu.set_Text(Conversions.ToString(i + 1) + "/" + Conversions.ToString(ll_lbxnfilelis.get_Items().get_Count()));
						((Control)txtjindu).Refresh();
						if (!ll_lbxnfilelis.GetSelected(i))
						{
							continue;
						}
						num3++;
						PBX1.set_Value(num3);
						string text3 = Conversions.ToString(ll_lbxnfilelis.get_Items().get_Item(i));
						Mod1.excelapp.Workbooks.Open(text3, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
						string[] array = Strings.Split(text3, "\\", -1, (CompareMethod)0);
						string text4 = array[Information.UBound((Array)array, 1)];
						Workbook workbook = Mod1.excelapp.Workbooks[text4];
						Worksheet worksheet2 = (Worksheet)workbook.Worksheets["性能数据表"];
						worksheet.Cells.Delete(Missing.Value);
						worksheet2.Cells.Copy(((_Worksheet)worksheet).get_Range((object)"A1", (object)Missing.Value));
						workbook.Close(Missing.Value, Missing.Value, Missing.Value);
						Excel.Range currentRegion = ((_Worksheet)worksheet).get_Range((object)"A1", (object)Missing.Value).CurrentRegion;
						int count = currentRegion.Columns.Count;
						float num5 = currentRegion.Rows.Count;
						float num6 = 3.14159f;
						switch (((TextBox)ll_txtstruct).get_Text())
						{
						case "主臂":
						{
							worksheet.Activate();
							NewLateBinding.LateSetComplex(worksheet.Cells[num5, 1], (Type)null, "Value", new object[1] { "主臂组合" }, (string[])null, (Type[])null, false, true);
							NewLateBinding.LateSetComplex(worksheet.Cells[num5 + 1f, 1], (Type)null, "Value", new object[1] { "倍率" }, (string[])null, (Type[])null, false, true);
							NewLateBinding.LateSetComplex(worksheet.Cells[num5 + 2f, 1], (Type)null, "Value", new object[1] { "主臂最大仰角" }, (string[])null, (Type[])null, false, true);
							NewLateBinding.LateSetComplex(worksheet.Cells[num5 + 3f, 1], (Type)null, "Value", new object[1] { "主臂最小仰角" }, (string[])null, (Type[])null, false, true);
							int num24 = count;
							for (int k = 2; k <= num24; k++)
							{
								object[] array3 = new object[(int)Math.Round(num5) + 1];
								object[] array4 = new object[(int)Math.Round(num5) + 1];
								float num25 = num5 - 1f;
								for (float num26 = 2f; num26 <= num25; num26 += 1f)
								{
									if (Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[num26, k], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null))), "", false) != 0)
									{
										if (Operators.ConditionalCompareObjectGreater(Operators.SubtractObject(NewLateBinding.LateGet(worksheet.Cells[num26, k], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1E-05), (object)0, false))
										{
											float num12 = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[1, k], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
											float num13 = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[num26, 1], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
											num12 *= 1000f;
											num13 *= 1000f;
											double num27 = Math.Sqrt(num12 * num12 + H0 * H0);
											double num28 = Math.Atan(H0 / num12);
											double num15 = num13 - ROTX;
											array3[(int)Math.Round(num26)] = Mod1.excelapp.Application.WorksheetFunction.Acos(num15 / num27) + num28;
										}
										else
										{
											array3[(int)Math.Round(num26)] = 0;
										}
										array4[(int)Math.Round(num26)] = Conversions.ToSingle(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[num26, k], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null))));
									}
								}
								double num18 = Mod1.excelapp.Application.WorksheetFunction.Max(array3, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
								double num19 = num18;
								float num20 = (float)Mod1.excelapp.Application.WorksheetFunction.Max(array4, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
								double num21 = Math.Log(1f - num20 * (1f - XL_GSS) / (XY_GSS * XL_GSS)) / Math.Log(XL_GSS);
								float num29 = num5 - 1f;
								for (float num30 = 2f; num30 <= num29; num30 += 1f)
								{
									if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater(array3[(int)Math.Round(num30)], (object)0, false), Operators.CompareObjectLess(array3[(int)Math.Round(num30)], (object)num19, false))))
									{
										num19 = Conversions.ToDouble(array3[(int)Math.Round(num30)]);
									}
								}
								NewLateBinding.LateSetComplex(worksheet.Cells[num5 + 1f, k], (Type)null, "Value", new object[1] { Math.Round(num21 + 0.5) }, (string[])null, (Type[])null, false, true);
								NewLateBinding.LateSetComplex(worksheet.Cells[num5 + 2f, k], (Type)null, "Value", new object[1] { Math.Round(num18 * 180.0 / (double)num6, 1) }, (string[])null, (Type[])null, false, true);
								NewLateBinding.LateSetComplex(worksheet.Cells[num5 + 3f, k], (Type)null, "Value", new object[1] { Math.Round(num19 * 180.0 / (double)num6, 1) }, (string[])null, (Type[])null, false, true);
							}
							break;
						}
						case "主臂+固定副臂":
						{
							string[] array2 = Strings.Split(text4, "_", -1, (CompareMethod)0);
							float num7 = Conversions.ToSingle(array2[num2]);
							num7 *= 1000f;
							float num31 = Conversions.ToSingle(array2[num]);
							worksheet.Activate();
							NewLateBinding.LateSetComplex(worksheet.Cells[num5, 1], (Type)null, "Value", new object[1] { "主臂组合" }, (string[])null, (Type[])null, false, true);
							NewLateBinding.LateSetComplex(worksheet.Cells[num5 + 1f, 1], (Type)null, "Value", new object[1] { "倍率" }, (string[])null, (Type[])null, false, true);
							NewLateBinding.LateSetComplex(worksheet.Cells[num5 + 2f, 1], (Type)null, "Value", new object[1] { "主臂最大仰角" }, (string[])null, (Type[])null, false, true);
							NewLateBinding.LateSetComplex(worksheet.Cells[num5 + 3f, 1], (Type)null, "Value", new object[1] { "主臂最小仰角" }, (string[])null, (Type[])null, false, true);
							int num32 = count;
							for (int l = 2; l <= num32; l++)
							{
								object[] array3 = new object[(int)Math.Round(num5) + 1];
								object[] array4 = new object[(int)Math.Round(num5) + 1];
								float num33 = num5 - 1f;
								for (float num34 = 2f; num34 <= num33; num34 += 1f)
								{
									if (Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[num34, l], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null))), "", false) == 0)
									{
										continue;
									}
									if (Operators.ConditionalCompareObjectGreater(Operators.SubtractObject(NewLateBinding.LateGet(worksheet.Cells[num34, l], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1E-05), (object)0, false))
									{
										float num12 = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[1, l], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
										float num13 = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[num34, 1], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
										num12 *= 1000f;
										num13 *= 1000f;
										double num27 = Math.Sqrt(num12 * num12 + H1 * H1);
										double num17 = Math.Sqrt(num7 * num7 + H2 * H2);
										double num28 = Math.Abs(Math.Atan(H1 / num12));
										double num35 = Math.Atan(H2 / num7);
										double num36 = (double)ROTX2 + num17 * Math.Cos(num35 - (double)(num31 * num6 / 180f));
										double num37 = (double)ROTZ2 + num17 * Math.Sin(num35 - (double)(num31 * num6 / 180f));
										double num15 = num13 - ROTX;
										double num38 = Math.Sqrt((num36 - (double)ROTX + (double)num12 - (double)LZ0) * (num36 - (double)ROTX + (double)num12 - (double)LZ0) + (num37 - (double)ROTZ) * (num37 - (double)ROTZ));
										double num39 = Math.Atan(Math.Abs((num37 - (double)ROTZ) / (num36 - (double)ROTX + (double)num12 - (double)LZ0)));
										if (Math.Abs(num15 / num38) > 1.0)
										{
											ll_lbliucheng.get_Items().Add((object)("文件计算失败!Abs(RFP / ZC) > 1 " + text3));
											ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
										}
										else
										{
											array3[(int)Math.Round(num34)] = Mod1.excelapp.WorksheetFunction.Acos(num15 / num38) + num39;
										}
									}
									else
									{
										array3[(int)Math.Round(num34)] = 0;
									}
									array4[(int)Math.Round(num34)] = Conversions.ToSingle(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[num34, l], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null))));
								}
								double num18 = Mod1.excelapp.Application.WorksheetFunction.Max(array3, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
								double num19 = num18;
								float num20 = (float)Mod1.excelapp.Application.WorksheetFunction.Max(array4, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
								double num21 = Math.Log(1f - num20 * (1f - XL_GSS) / (XY_GSS * XL_GSS)) / Math.Log(XL_GSS);
								float num40 = num5 - 1f;
								for (float num41 = 2f; num41 <= num40; num41 += 1f)
								{
									if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater(array3[(int)Math.Round(num41)], (object)0, false), Operators.CompareObjectLess(array3[(int)Math.Round(num41)], (object)num19, false))))
									{
										num19 = Conversions.ToDouble(array3[(int)Math.Round(num41)]);
									}
								}
								NewLateBinding.LateSetComplex(worksheet.Cells[num5 + 1f, l], (Type)null, "Value", new object[1] { Math.Round(num21 + 0.5) }, (string[])null, (Type[])null, false, true);
								NewLateBinding.LateSetComplex(worksheet.Cells[num5 + 2f, l], (Type)null, "Value", new object[1] { Math.Round(num18 * 180.0 / (double)num6, 1) }, (string[])null, (Type[])null, false, true);
								NewLateBinding.LateSetComplex(worksheet.Cells[num5 + 3f, l], (Type)null, "Value", new object[1] { Math.Round(num19 * 180.0 / (double)num6, 1) }, (string[])null, (Type[])null, false, true);
							}
							break;
						}
						case "主臂+塔式副臂":
						{
							string[] array2 = Strings.Split(text4, "_", -1, (CompareMethod)0);
							float num7 = Conversions.ToSingle(array2[num2]);
							num7 *= 1000f;
							float num8 = Conversions.ToSingle(array2[num]);
							worksheet.Activate();
							NewLateBinding.LateSetComplex(worksheet.Cells[num5, 1], (Type)null, "Value", new object[1] { "主臂组合" }, (string[])null, (Type[])null, false, true);
							NewLateBinding.LateSetComplex(worksheet.Cells[num5 + 1f, 1], (Type)null, "Value", new object[1] { "倍率" }, (string[])null, (Type[])null, false, true);
							NewLateBinding.LateSetComplex(worksheet.Cells[num5 + 2f, 1], (Type)null, "Value", new object[1] { "塔臂最大仰角" }, (string[])null, (Type[])null, false, true);
							NewLateBinding.LateSetComplex(worksheet.Cells[num5 + 3f, 1], (Type)null, "Value", new object[1] { "塔臂最小仰角" }, (string[])null, (Type[])null, false, true);
							int num9 = count;
							for (int j = 2; j <= num9; j++)
							{
								object[] array3 = new object[(int)Math.Round(num5) + 1];
								object[] array4 = new object[(int)Math.Round(num5) + 1];
								float num10 = num5 - 1f;
								for (float num11 = 2f; num11 <= num10; num11 += 1f)
								{
									if (Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[num11, j], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null))), "", false) == 0)
									{
										continue;
									}
									if (Operators.ConditionalCompareObjectGreater(Operators.SubtractObject(NewLateBinding.LateGet(worksheet.Cells[num11, j], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1E-05), (object)0, false))
									{
										float num12 = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[1, j], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
										float num13 = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[num11, 1], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
										num12 *= 1000f;
										num13 *= 1000f;
										double num14 = (double)num12 * Math.Cos(num8 * num6 / 180f) + (double)H4 * Math.Sin(num8 * num6 / 180f);
										double num15 = num13 - ROTX;
										double num16 = num15 - num14;
										double num17 = Math.Sqrt(num7 * num7 + H3 * H3);
										if (Math.Abs(num16 / num17) > 1.0)
										{
											ll_lbliucheng.get_Items().Add((object)("文件计算失败!Abs(RFP / ZC) > 1 " + text3));
											ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
										}
										else
										{
											array3[(int)Math.Round(num11)] = Mod1.excelapp.WorksheetFunction.Acos(num16 / num17) + Math.Atan(H3 / num7);
										}
									}
									else
									{
										array3[(int)Math.Round(num11)] = 0;
									}
									array4[(int)Math.Round(num11)] = Conversions.ToSingle(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[num11, j], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null))));
								}
								double num18 = Mod1.excelapp.Application.WorksheetFunction.Max(array3, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
								double num19 = num18;
								float num20 = (float)Mod1.excelapp.Application.WorksheetFunction.Max(array4, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
								double num21 = Math.Log(1f - num20 * (1f - XL_GSS) / (XY_GSS * XL_GSS)) / Math.Log(XL_GSS);
								float num22 = num5 - 1f;
								for (float num23 = 2f; num23 <= num22; num23 += 1f)
								{
									if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater(array3[(int)Math.Round(num23)], (object)0, false), Operators.CompareObjectLess(array3[(int)Math.Round(num23)], (object)num19, false))))
									{
										num19 = Conversions.ToDouble(array3[(int)Math.Round(num23)]);
									}
								}
								NewLateBinding.LateSetComplex(worksheet.Cells[num5 + 1f, j], (Type)null, "Value", new object[1] { Math.Round(num21 + 0.5) }, (string[])null, (Type[])null, false, true);
								NewLateBinding.LateSetComplex(worksheet.Cells[num5 + 2f, j], (Type)null, "Value", new object[1] { Math.Round(num18 * 180.0 / (double)num6, 1) }, (string[])null, (Type[])null, false, true);
								NewLateBinding.LateSetComplex(worksheet.Cells[num5 + 3f, j], (Type)null, "Value", new object[1] { Math.Round(num19 * 180.0 / (double)num6, 1) }, (string[])null, (Type[])null, false, true);
							}
							break;
						}
						default:
							ll_lbliucheng.get_Items().Add((object)("存在不合法的结构形式:" + ll_lbconfig.get_Text()));
							ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
							break;
						}
						if (!Mod1.WorkbookIsOpen("Tempxnb.xls"))
						{
							Mod1.excelapp.Workbooks.Open(Application.get_StartupPath() + "\\config\\xnbinfoadd\\Tempxnb.xls", Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
						}
						worksheet.Cells.Copy(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Mod1.excelapp.Workbooks["Tempxnb.xls"].Sheets["性能数据表"], (Type)null, "Range", new object[1] { "A1" }, (string[])null, (Type[])null, (bool[])null)));
						Mod1.excelapp.Workbooks["Tempxnb.xls"].SaveAs(resxlspath + "\\" + text4, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, XlSaveAsAccessMode.xlNoChange, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
						Mod1.excelapp.DisplayAlerts = false;
						Mod1.excelapp.ActiveWindow.Close(Missing.Value, Missing.Value, Missing.Value);
					}
					Mod1.excelapp.DisplayAlerts = false;
					Mod1.excelapp.ActiveWindow.Close(Missing.Value, Missing.Value, Missing.Value);
					((Control)this).set_Cursor(Cursors.get_Arrow());
					ll_lbliucheng.get_Items().Add((object)("当前处理的数据表总数为：" + Conversions.ToString(num3)));
					ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
					ll_lbliucheng.get_Items().Add((object)("当前处理的数据表保存到该路径下：" + resxlspath));
					ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
				}
				else
				{
					string filename = default(string);
					Interaction.MsgBox((object)("没有找到文件：" + filename + " 程序执行失败！"), (MsgBoxStyle)64, (object)"提示");
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox((object)(ex2.Message.ToString() + "\r" + ex2.StackTrace!.ToString()), (MsgBoxStyle)64, (object)"提示");
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ll_btnexit_Click(object sender, EventArgs e)
	{
		checked
		{
			if (ll_lbliucheng.get_Items().get_Count() != 0)
			{
				int num = ll_lbliucheng.get_Items().get_Count() - 1;
				for (int i = 0; i <= num; i++)
				{
					MyProject.Forms.Main.lslog.get_Items().Add(RuntimeHelpers.GetObjectValue(ll_lbliucheng.get_Items().get_Item(i)));
				}
			}
			((Form)this).Close();
		}
	}

	private void ll_lbconfig_DoubleClick(object sender, EventArgs e)
	{
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (Operators.CompareString(Strings.Trim(ll_lbconfig.get_Text()), "", false) != 0)
			{
				((Control)btnOutPut).set_Enabled(true);
				((TextBox)ll_txtstruct).set_Text(ll_lbconfig.get_Text());
				if (Operators.CompareString(whichstruct, ((TextBox)ll_txtstruct).get_Text(), false) != 0)
				{
					whichstruct = ((TextBox)ll_txtstruct).get_Text();
					inputconst(whichstruct);
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)(ex2.Message.ToString() + "\r" + ex2.StackTrace!.ToString()), (MsgBoxStyle)64, (object)"提示");
			ProjectData.ClearProjectError();
		}
	}

	private void btnsave_Click(object sender, EventArgs e)
	{
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Invalid comparison between Unknown and I4
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (((DataGridView)DGV1).get_Rows().get_Count() != 0)
			{
				switch (((TextBox)ll_txtstruct).get_Text())
				{
				case "主臂":
					((FileDialog)SFD1).set_FileName("zb_const.ini");
					((FileDialog)SFD1).set_Filter("zb_const.ini|zb_const.ini");
					break;
				case "主臂+固定副臂":
					((FileDialog)SFD1).set_FileName("fb_const.ini");
					((FileDialog)SFD1).set_Filter("fb_const.ini|fb_const.ini");
					break;
				case "主臂+塔式副臂":
					((FileDialog)SFD1).set_FileName("tb_const.ini");
					((FileDialog)SFD1).set_Filter("tb_const.ini|tb_const.ini");
					break;
				}
				if ((int)((CommonDialog)SFD1).ShowDialog() == 1)
				{
					Mod1.wr = new StreamWriter(((FileDialog)SFD1).get_FileName(), append: false, Encoding.Default);
					checked
					{
						int num = ((DataGridView)DGV1).get_Rows().get_Count() - 1;
						for (int i = 0; i <= num; i++)
						{
							Mod1.wr.WriteLine(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(((DataGridView)DGV1).get_Rows().get_Item(i).get_Cells()
								.get_Item(0)
								.get_Value(), (object)"="), ((DataGridView)DGV1).get_Rows().get_Item(i).get_Cells()
								.get_Item(1)
								.get_Value()), (object)"!"), ((DataGridView)DGV1).get_Rows().get_Item(i).get_Cells()
								.get_Item(2)
								.get_Value()));
						}
						Mod1.wr.Close();
						Mod1.wr.Dispose();
						ll_lbliucheng.get_Items().Add((object)("文件保存在：" + ((FileDialog)SFD1).get_FileName()));
					}
				}
			}
			else
			{
				Interaction.MsgBox((object)"当前数据表中为空,不能保存！", (MsgBoxStyle)64, (object)"提示");
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)(ex2.Message.ToString() + "\r" + ex2.StackTrace!.ToString()), (MsgBoxStyle)64, (object)"提示");
			ProjectData.ClearProjectError();
		}
	}

	private void btndr_Click(object sender, EventArgs e)
	{
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Invalid comparison between Unknown and I4
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Invalid comparison between Unknown and I4
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Invalid comparison between Unknown and I4
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(Strings.Trim(((TextBox)ll_txtstruct).get_Text()), "", false) != 0)
		{
			if (((DataGridView)DGV1).get_Rows().get_Count() != 0)
			{
				switch (((TextBox)ll_txtstruct).get_Text())
				{
				case "主臂":
					((FileDialog)OPD1).set_Filter("zb_const.ini|zb_const.ini");
					break;
				case "主臂+固定副臂":
					((FileDialog)OPD1).set_Filter("fb_const.ini|fb_const.ini");
					break;
				case "主臂+塔式副臂":
					((FileDialog)OPD1).set_Filter("tb_const.ini|tb_const.ini");
					break;
				}
				if ((int)MessageBox.Show("当前表中已经存在数据是覆盖？", "提示", (MessageBoxButtons)4, (MessageBoxIcon)64) == 6 && (int)((CommonDialog)OPD1).ShowDialog() == 1)
				{
					gaibian = false;
					inputini(((FileDialog)OPD1).get_FileName(), ((TextBox)ll_txtstruct).get_Text());
				}
			}
			else
			{
				switch (((TextBox)ll_txtstruct).get_Text())
				{
				case "主臂":
					((FileDialog)OPD1).set_Filter("zb_const.ini|zb_const.ini");
					break;
				case "主臂+固定副臂":
					((FileDialog)OPD1).set_Filter("fb_const.ini|fb_const.ini");
					break;
				case "主臂+塔式副臂":
					((FileDialog)OPD1).set_Filter("tb_const.ini|tb_const.ini");
					break;
				}
				if ((int)((CommonDialog)OPD1).ShowDialog() == 1)
				{
					gaibian = false;
					inputini(((FileDialog)OPD1).get_FileName(), ((TextBox)ll_txtstruct).get_Text());
				}
			}
		}
		else
		{
			Interaction.MsgBox((object)"请在列表框中双击选择一种结构形式.", (MsgBoxStyle)64, (object)"提示");
		}
	}

	private void DGV1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
	{
		if (!gaibian)
		{
			return;
		}
		checked
		{
			switch (((TextBox)ll_txtstruct).get_Text())
			{
			case "主臂":
			{
				int num2 = ((DataGridView)DGV1).get_Rows().get_Count() - 1;
				for (int j = 0; j <= num2; j++)
				{
					switch (Strings.UCase(Strings.Trim(Conversions.ToString(((DataGridView)DGV1).get_Rows().get_Item(j).get_Cells()
						.get_Item(0)
						.get_Value()))))
					{
					case "H0":
						H0 = Conversions.ToSingle(((DataGridView)DGV1).get_Rows().get_Item(j).get_Cells()
							.get_Item(1)
							.get_Value());
						break;
					case "ROTX":
						ROTX = Conversions.ToSingle(((DataGridView)DGV1).get_Rows().get_Item(j).get_Cells()
							.get_Item(1)
							.get_Value());
						break;
					case "XY_GSS":
						XY_GSS = Conversions.ToSingle(((DataGridView)DGV1).get_Rows().get_Item(j).get_Cells()
							.get_Item(1)
							.get_Value());
						break;
					default:
						ll_lbliucheng.get_Items().Add(Operators.ConcatenateObject((object)"不合法的配置项:", ((DataGridView)DGV1).get_Rows().get_Item(j).get_Cells()
							.get_Item(0)
							.get_Value()));
						break;
					}
				}
				break;
			}
			case "主臂+固定副臂":
			{
				int num3 = ((DataGridView)DGV1).get_Rows().get_Count() - 1;
				for (int k = 0; k <= num3; k++)
				{
					switch (Strings.UCase(Strings.Trim(Conversions.ToString(((DataGridView)DGV1).get_Rows().get_Item(k).get_Cells()
						.get_Item(0)
						.get_Value()))))
					{
					case "ROTX2":
						ROTX2 = Conversions.ToSingle(((DataGridView)DGV1).get_Rows().get_Item(k).get_Cells()
							.get_Item(1)
							.get_Value());
						break;
					case "ROTY2":
						ROTY2 = Conversions.ToSingle(((DataGridView)DGV1).get_Rows().get_Item(k).get_Cells()
							.get_Item(1)
							.get_Value());
						break;
					case "ROTZ2":
						ROTZ2 = Conversions.ToSingle(((DataGridView)DGV1).get_Rows().get_Item(k).get_Cells()
							.get_Item(1)
							.get_Value());
						break;
					case "H1":
						H1 = Conversions.ToSingle(((DataGridView)DGV1).get_Rows().get_Item(k).get_Cells()
							.get_Item(1)
							.get_Value());
						break;
					case "H2":
						H2 = Conversions.ToSingle(((DataGridView)DGV1).get_Rows().get_Item(k).get_Cells()
							.get_Item(1)
							.get_Value());
						break;
					case "LZ0":
						LZ0 = Conversions.ToSingle(((DataGridView)DGV1).get_Rows().get_Item(k).get_Cells()
							.get_Item(1)
							.get_Value());
						break;
					case "ROTX":
						ROTX = Conversions.ToSingle(((DataGridView)DGV1).get_Rows().get_Item(k).get_Cells()
							.get_Item(1)
							.get_Value());
						break;
					case "ROTZ":
						ROTZ = Conversions.ToSingle(((DataGridView)DGV1).get_Rows().get_Item(k).get_Cells()
							.get_Item(1)
							.get_Value());
						break;
					case "XY_GSS":
						XY_GSS = Conversions.ToSingle(((DataGridView)DGV1).get_Rows().get_Item(k).get_Cells()
							.get_Item(1)
							.get_Value());
						break;
					default:
						ll_lbliucheng.get_Items().Add(Operators.ConcatenateObject((object)"存在不合法的配置项:", ((DataGridView)DGV1).get_Rows().get_Item(k).get_Cells()
							.get_Item(0)
							.get_Value()));
						break;
					}
				}
				break;
			}
			case "主臂+塔式副臂":
			{
				int num = ((DataGridView)DGV1).get_Rows().get_Count() - 1;
				for (int i = 0; i <= num; i++)
				{
					switch (Strings.UCase(Strings.Trim(Conversions.ToString(((DataGridView)DGV1).get_Rows().get_Item(i).get_Cells()
						.get_Item(0)
						.get_Value()))))
					{
					case "H4":
						H4 = Conversions.ToSingle(((DataGridView)DGV1).get_Rows().get_Item(i).get_Cells()
							.get_Item(1)
							.get_Value());
						break;
					case "H3":
						H3 = Conversions.ToSingle(((DataGridView)DGV1).get_Rows().get_Item(i).get_Cells()
							.get_Item(1)
							.get_Value());
						break;
					case "ROTX":
						ROTX = Conversions.ToSingle(((DataGridView)DGV1).get_Rows().get_Item(i).get_Cells()
							.get_Item(1)
							.get_Value());
						break;
					case "XY_GSS":
						XY_GSS = Conversions.ToSingle(((DataGridView)DGV1).get_Rows().get_Item(i).get_Cells()
							.get_Item(1)
							.get_Value());
						break;
					default:
						ll_lbliucheng.get_Items().Add(Operators.ConcatenateObject((object)"存在不合法的配置项:", ((DataGridView)DGV1).get_Rows().get_Item(i).get_Cells()
							.get_Item(1)
							.get_Value()));
						break;
					}
				}
				break;
			}
			default:
				ll_lbliucheng.get_Items().Add((object)("不存在的结构形式: " + ((TextBox)ll_txtstruct).get_Text()));
				break;
			}
		}
	}
}
