using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.MyServices;
using xxx.My;

namespace xxx;

[DesignerGenerated]
public class drclk : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("LabelX1")]
	private LabelX _LabelX1;

	[AccessedThroughProperty("ButtonX1")]
	private ButtonX _ButtonX1;

	[AccessedThroughProperty("LabelX2")]
	private LabelX _LabelX2;

	[AccessedThroughProperty("LabelX3")]
	private LabelX _LabelX3;

	[AccessedThroughProperty("btnmblj")]
	private ButtonX _btnmblj;

	[AccessedThroughProperty("LabelX4")]
	private LabelX _LabelX4;

	[AccessedThroughProperty("cmbcshsl")]
	private ComboBoxEx _cmbcshsl;

	[AccessedThroughProperty("cmbclgn")]
	private ComboBoxEx _cmbclgn;

	[AccessedThroughProperty("txtxlslj")]
	private TextBoxX _txtxlslj;

	[AccessedThroughProperty("LabelX5")]
	private LabelX _LabelX5;

	[AccessedThroughProperty("txtslwj")]
	private TextBoxX _txtslwj;

	[AccessedThroughProperty("PB")]
	private PictureBox _PB;

	[AccessedThroughProperty("GroupPanel1")]
	private GroupPanel _GroupPanel1;

	[AccessedThroughProperty("LabelX6")]
	private LabelX _LabelX6;

	[AccessedThroughProperty("LabelX7")]
	private LabelX _LabelX7;

	[AccessedThroughProperty("lstsllb")]
	private ListBox _lstsllb;

	[AccessedThroughProperty("Rbmp")]
	private RadioButton _Rbmp;

	[AccessedThroughProperty("LabelX8")]
	private LabelX _LabelX8;

	[AccessedThroughProperty("Rjpg")]
	private RadioButton _Rjpg;

	[AccessedThroughProperty("btnck")]
	private ButtonX _btnck;

	[AccessedThroughProperty("LabelX9")]
	private LabelX _LabelX9;

	[AccessedThroughProperty("lsttplb")]
	private ListBox _lsttplb;

	[AccessedThroughProperty("LabelX10")]
	private LabelX _LabelX10;

	[AccessedThroughProperty("btnzj")]
	private ButtonX _btnzj;

	[AccessedThroughProperty("btnckk")]
	private ButtonX _btnckk;

	[AccessedThroughProperty("gb")]
	private ButtonX _gb;

	[AccessedThroughProperty("txtjs")]
	private TextBoxX _txtjs;

	[AccessedThroughProperty("txtkname")]
	private TextBoxX _txtkname;

	[AccessedThroughProperty("GroupPanel2")]
	private GroupPanel _GroupPanel2;

	private string f;

	private string[] ff;

	private string[] Bmporjpg;

	private string tmp;

	private string pshili;

	private string pxls;

	private int pp;

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

	internal virtual ButtonX ButtonX1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ButtonX1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ButtonX1_Click;
			if (_ButtonX1 != null)
			{
				((Control)_ButtonX1).remove_Click(eventHandler);
			}
			_ButtonX1 = value;
			if (_ButtonX1 != null)
			{
				((Control)_ButtonX1).add_Click(eventHandler);
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

	internal virtual LabelX LabelX3
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX3 = value;
		}
	}

	internal virtual ButtonX btnmblj
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnmblj;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnmblj_Click;
			if (_btnmblj != null)
			{
				((Control)_btnmblj).remove_Click(eventHandler);
			}
			_btnmblj = value;
			if (_btnmblj != null)
			{
				((Control)_btnmblj).add_Click(eventHandler);
			}
		}
	}

	internal virtual LabelX LabelX4
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX4 = value;
		}
	}

	internal virtual ComboBoxEx cmbcshsl
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbcshsl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cmbcshsl = value;
		}
	}

	internal virtual ComboBoxEx cmbclgn
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbclgn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cmbclgn = value;
		}
	}

	internal virtual TextBoxX txtxlslj
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtxlslj;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtxlslj = value;
		}
	}

	internal virtual LabelX LabelX5
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX5 = value;
		}
	}

	internal virtual TextBoxX txtslwj
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtslwj;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtslwj = value;
		}
	}

	internal virtual PictureBox PB
	{
		[DebuggerNonUserCode]
		get
		{
			return _PB;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PB_Click;
			if (_PB != null)
			{
				((Control)_PB).remove_Click(eventHandler);
			}
			_PB = value;
			if (_PB != null)
			{
				((Control)_PB).add_Click(eventHandler);
			}
		}
	}

	internal virtual GroupPanel GroupPanel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupPanel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupPanel1 = value;
		}
	}

	internal virtual LabelX LabelX6
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX6 = value;
		}
	}

	internal virtual LabelX LabelX7
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX7 = value;
		}
	}

	internal virtual ListBox lstsllb
	{
		[DebuggerNonUserCode]
		get
		{
			return _lstsllb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = lstsllb_SelectedIndexChanged;
			if (_lstsllb != null)
			{
				_lstsllb.remove_SelectedIndexChanged(eventHandler);
			}
			_lstsllb = value;
			if (_lstsllb != null)
			{
				_lstsllb.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual RadioButton Rbmp
	{
		[DebuggerNonUserCode]
		get
		{
			return _Rbmp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Rbmp_CheckedChanged;
			if (_Rbmp != null)
			{
				_Rbmp.remove_CheckedChanged(eventHandler);
			}
			_Rbmp = value;
			if (_Rbmp != null)
			{
				_Rbmp.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual LabelX LabelX8
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX8 = value;
		}
	}

	internal virtual RadioButton Rjpg
	{
		[DebuggerNonUserCode]
		get
		{
			return _Rjpg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Rjpg_CheckedChanged;
			if (_Rjpg != null)
			{
				_Rjpg.remove_CheckedChanged(eventHandler);
			}
			_Rjpg = value;
			if (_Rjpg != null)
			{
				_Rjpg.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual ButtonX btnck
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnck_Click;
			if (_btnck != null)
			{
				((Control)_btnck).remove_Click(eventHandler);
			}
			_btnck = value;
			if (_btnck != null)
			{
				((Control)_btnck).add_Click(eventHandler);
			}
		}
	}

	internal virtual LabelX LabelX9
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX9 = value;
		}
	}

	internal virtual ListBox lsttplb
	{
		[DebuggerNonUserCode]
		get
		{
			return _lsttplb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = lsttplb_SelectedIndexChanged;
			if (_lsttplb != null)
			{
				_lsttplb.remove_SelectedIndexChanged(eventHandler);
			}
			_lsttplb = value;
			if (_lsttplb != null)
			{
				_lsttplb.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual LabelX LabelX10
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX10 = value;
		}
	}

	internal virtual ButtonX btnzj
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnzj;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnzj_Click;
			if (_btnzj != null)
			{
				((Control)_btnzj).remove_Click(eventHandler);
			}
			_btnzj = value;
			if (_btnzj != null)
			{
				((Control)_btnzj).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX btnckk
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnckk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnckk_Click;
			if (_btnckk != null)
			{
				((Control)_btnckk).remove_Click(eventHandler);
			}
			_btnckk = value;
			if (_btnckk != null)
			{
				((Control)_btnckk).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX gb
	{
		[DebuggerNonUserCode]
		get
		{
			return _gb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = gb_Click;
			if (_gb != null)
			{
				((Control)_gb).remove_Click(eventHandler);
			}
			_gb = value;
			if (_gb != null)
			{
				((Control)_gb).add_Click(eventHandler);
			}
		}
	}

	internal virtual TextBoxX txtjs
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtjs;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtjs = value;
		}
	}

	public virtual TextBoxX txtkname
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtkname;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtkname = value;
		}
	}

	internal virtual GroupPanel GroupPanel2
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupPanel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupPanel2 = value;
		}
	}

	[DebuggerNonUserCode]
	public drclk()
	{
		((Form)this).add_Load((EventHandler)drclk_Load);
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Expected O, but got Unknown
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_067b: Expected O, but got Unknown
		//IL_072c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0736: Expected O, but got Unknown
		//IL_07db: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e5: Expected O, but got Unknown
		//IL_0968: Unknown result type (might be due to invalid IL or missing references)
		//IL_0972: Expected O, but got Unknown
		//IL_1568: Unknown result type (might be due to invalid IL or missing references)
		//IL_1572: Expected O, but got Unknown
		//IL_16f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_16fa: Expected O, but got Unknown
		LabelX1 = new LabelX();
		txtkname = new TextBoxX();
		ButtonX1 = new ButtonX();
		LabelX2 = new LabelX();
		LabelX3 = new LabelX();
		btnmblj = new ButtonX();
		LabelX4 = new LabelX();
		cmbcshsl = new ComboBoxEx();
		cmbclgn = new ComboBoxEx();
		txtxlslj = new TextBoxX();
		LabelX5 = new LabelX();
		txtslwj = new TextBoxX();
		PB = new PictureBox();
		GroupPanel1 = new GroupPanel();
		LabelX6 = new LabelX();
		LabelX7 = new LabelX();
		lstsllb = new ListBox();
		Rbmp = new RadioButton();
		LabelX8 = new LabelX();
		Rjpg = new RadioButton();
		btnck = new ButtonX();
		LabelX9 = new LabelX();
		lsttplb = new ListBox();
		LabelX10 = new LabelX();
		btnzj = new ButtonX();
		btnckk = new ButtonX();
		gb = new ButtonX();
		txtjs = new TextBoxX();
		GroupPanel2 = new GroupPanel();
		((ISupportInitialize)PB).BeginInit();
		((Control)GroupPanel1).SuspendLayout();
		((Control)GroupPanel2).SuspendLayout();
		((Control)this).SuspendLayout();
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX = LabelX1;
		Point location = new Point(7, 7);
		((Control)labelX).set_Location(location);
		((Control)LabelX1).set_Name("LabelX1");
		LabelX labelX2 = LabelX1;
		Size size = new Size(100, 23);
		((Control)labelX2).set_Size(size);
		((Control)LabelX1).set_TabIndex(0);
		LabelX1.set_Text("新部件英文名称:");
		txtkname.get_Border().set_Class("TextBoxBorder");
		txtkname.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj = txtkname;
		location = new Point(8, 36);
		((Control)obj).set_Location(location);
		((Control)txtkname).set_Name("txtkname");
		TextBoxX obj2 = txtkname;
		size = new Size(100, 21);
		((Control)obj2).set_Size(size);
		((Control)txtkname).set_TabIndex(1);
		((Control)ButtonX1).set_AccessibleRole((AccessibleRole)43);
		ButtonX1.set_ColorTable((eButtonColor)3);
		ButtonX buttonX = ButtonX1;
		location = new Point(120, 35);
		((Control)buttonX).set_Location(location);
		((Control)ButtonX1).set_Name("ButtonX1");
		ButtonX buttonX2 = ButtonX1;
		size = new Size(98, 23);
		((Control)buttonX2).set_Size(size);
		((PopupItemControl)ButtonX1).set_Style((eDotNetBarStyle)7);
		((Control)ButtonX1).set_TabIndex(2);
		ButtonX1.set_Text("选择已有名称");
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX3 = LabelX2;
		location = new Point(7, 63);
		((Control)labelX3).set_Location(location);
		((Control)LabelX2).set_Name("LabelX2");
		LabelX labelX4 = LabelX2;
		size = new Size(112, 18);
		((Control)labelX4).set_Size(size);
		((Control)LabelX2).set_TabIndex(0);
		LabelX2.set_Text("参数化库/实例库:");
		((BaseItemControl)LabelX3).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX3).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX5 = LabelX3;
		location = new Point(8, 114);
		((Control)labelX5).set_Location(location);
		((Control)LabelX3).set_Name("LabelX3");
		LabelX labelX6 = LabelX3;
		size = new Size(75, 19);
		((Control)labelX6).set_Size(size);
		((Control)LabelX3).set_TabIndex(0);
		LabelX3.set_Text("处理功能:");
		((Control)btnmblj).set_AccessibleRole((AccessibleRole)43);
		btnmblj.set_ColorTable((eButtonColor)3);
		ButtonX obj3 = btnmblj;
		location = new Point(8, 166);
		((Control)obj3).set_Location(location);
		((Control)btnmblj).set_Name("btnmblj");
		ButtonX obj4 = btnmblj;
		size = new Size(212, 23);
		((Control)obj4).set_Size(size);
		((PopupItemControl)btnmblj).set_Style((eDotNetBarStyle)7);
		((Control)btnmblj).set_TabIndex(2);
		btnmblj.set_Text("指定[新建库x模板]路径");
		((BaseItemControl)LabelX4).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX4).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX4).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		LabelX labelX7 = LabelX4;
		location = new Point(0, 14);
		((Control)labelX7).set_Location(location);
		((Control)LabelX4).set_Name("LabelX4");
		LabelX labelX8 = LabelX4;
		size = new Size(155, 18);
		((Control)labelX8).set_Size(size);
		((Control)LabelX4).set_TabIndex(0);
		LabelX4.set_Text("指定xls文件路径");
		((ListControl)cmbcshsl).set_DisplayMember("Text");
		((ComboBox)cmbcshsl).set_DrawMode((DrawMode)1);
		((ComboBox)cmbcshsl).set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)cmbcshsl).set_FormattingEnabled(true);
		((ComboBox)cmbcshsl).set_ItemHeight(15);
		ComboBoxEx obj5 = cmbcshsl;
		location = new Point(8, 87);
		((Control)obj5).set_Location(location);
		((Control)cmbcshsl).set_Name("cmbcshsl");
		ComboBoxEx obj6 = cmbcshsl;
		size = new Size(212, 21);
		((Control)obj6).set_Size(size);
		cmbcshsl.set_Style((eDotNetBarStyle)7);
		((Control)cmbcshsl).set_TabIndex(0);
		((ListControl)cmbclgn).set_DisplayMember("Text");
		((ComboBox)cmbclgn).set_DrawMode((DrawMode)1);
		((ComboBox)cmbclgn).set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)cmbclgn).set_FormattingEnabled(true);
		((ComboBox)cmbclgn).set_ItemHeight(15);
		ComboBoxEx obj7 = cmbclgn;
		location = new Point(7, 139);
		((Control)obj7).set_Location(location);
		((Control)cmbclgn).set_Name("cmbclgn");
		ComboBoxEx obj8 = cmbclgn;
		size = new Size(212, 21);
		((Control)obj8).set_Size(size);
		cmbclgn.set_Style((eDotNetBarStyle)7);
		((Control)cmbclgn).set_TabIndex(0);
		((TextBoxBase)txtxlslj).set_BackColor(Color.Gray);
		txtxlslj.get_Border().set_Class("TextBoxBorder");
		txtxlslj.get_Border().set_CornerType((eCornerType)1);
		((Control)txtxlslj).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)txtxlslj).set_ForeColor(Color.White);
		TextBoxX obj9 = txtxlslj;
		location = new Point(0, 46);
		((Control)obj9).set_Location(location);
		((Control)txtxlslj).set_Name("txtxlslj");
		((TextBoxBase)txtxlslj).set_ReadOnly(true);
		TextBoxX obj10 = txtxlslj;
		size = new Size(194, 21);
		((Control)obj10).set_Size(size);
		((Control)txtxlslj).set_TabIndex(1);
		txtxlslj.set_WatermarkColor(Color.White);
		((BaseItemControl)LabelX5).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX5).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX5).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		LabelX labelX9 = LabelX5;
		location = new Point(0, 82);
		((Control)labelX9).set_Location(location);
		((Control)LabelX5).set_Name("LabelX5");
		LabelX labelX10 = LabelX5;
		size = new Size(153, 17);
		((Control)labelX10).set_Size(size);
		((Control)LabelX5).set_TabIndex(0);
		LabelX5.set_Text("指定实例文件夹");
		((TextBoxBase)txtslwj).set_BackColor(Color.Gray);
		txtslwj.get_Border().set_Class("TextBoxBorder");
		txtslwj.get_Border().set_CornerType((eCornerType)1);
		((Control)txtslwj).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)txtslwj).set_ForeColor(Color.White);
		TextBoxX obj11 = txtslwj;
		location = new Point(0, 112);
		((Control)obj11).set_Location(location);
		((Control)txtslwj).set_Name("txtslwj");
		((TextBoxBase)txtslwj).set_ReadOnly(true);
		TextBoxX obj12 = txtslwj;
		size = new Size(194, 21);
		((Control)obj12).set_Size(size);
		((Control)txtslwj).set_TabIndex(1);
		txtslwj.set_WatermarkColor(Color.White);
		((Control)PB).set_BackgroundImageLayout((ImageLayout)0);
		PB.set_BorderStyle((BorderStyle)2);
		PictureBox pB = PB;
		location = new Point(236, 36);
		((Control)pB).set_Location(location);
		((Control)PB).set_Name("PB");
		PictureBox pB2 = PB;
		size = new Size(396, 340);
		((Control)pB2).set_Size(size);
		PB.set_SizeMode((PictureBoxSizeMode)3);
		PB.set_TabIndex(11);
		PB.set_TabStop(false);
		((PanelControl)GroupPanel1).set_CanvasColor(SystemColors.Control);
		((PanelControl)GroupPanel1).set_ColorSchemeStyle((eDotNetBarStyle)4);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)LabelX4);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)LabelX5);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)txtxlslj);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)txtslwj);
		((Control)GroupPanel1).set_Font(new Font("Arial Narrow", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		GroupPanel groupPanel = GroupPanel1;
		location = new Point(8, 195);
		((Control)groupPanel).set_Location(location);
		((Control)GroupPanel1).set_Name("GroupPanel1");
		GroupPanel groupPanel2 = GroupPanel1;
		size = new Size(212, 181);
		((Control)groupPanel2).set_Size(size);
		((PanelControl)GroupPanel1).get_Style().set_BackColor2SchemePart((eColorSchemePart)52);
		((PanelControl)GroupPanel1).get_Style().set_BackColorGradientAngle(90);
		((PanelControl)GroupPanel1).get_Style().set_BackColorSchemePart((eColorSchemePart)51);
		((PanelControl)GroupPanel1).get_Style().set_BorderBottom((eStyleBorderType)1);
		((PanelControl)GroupPanel1).get_Style().set_BorderBottomWidth(1);
		((PanelControl)GroupPanel1).get_Style().set_BorderColorSchemePart((eColorSchemePart)53);
		((PanelControl)GroupPanel1).get_Style().set_BorderLeft((eStyleBorderType)1);
		((PanelControl)GroupPanel1).get_Style().set_BorderLeftWidth(1);
		((PanelControl)GroupPanel1).get_Style().set_BorderRight((eStyleBorderType)1);
		((PanelControl)GroupPanel1).get_Style().set_BorderRightWidth(1);
		((PanelControl)GroupPanel1).get_Style().set_BorderTop((eStyleBorderType)1);
		((PanelControl)GroupPanel1).get_Style().set_BorderTopWidth(1);
		((PanelControl)GroupPanel1).get_Style().set_Class("");
		((PanelControl)GroupPanel1).get_Style().set_CornerDiameter(4);
		((PanelControl)GroupPanel1).get_Style().set_CornerType((eCornerType)2);
		((PanelControl)GroupPanel1).get_Style().set_TextAlignment((eStyleTextAlignment)1);
		((PanelControl)GroupPanel1).get_Style().set_TextColorSchemePart((eColorSchemePart)54);
		((PanelControl)GroupPanel1).get_Style().set_TextLineAlignment((eStyleTextAlignment)0);
		((PanelControl)GroupPanel1).get_StyleMouseDown().set_Class("");
		((PanelControl)GroupPanel1).get_StyleMouseDown().set_CornerType((eCornerType)1);
		((PanelControl)GroupPanel1).get_StyleMouseOver().set_Class("");
		((PanelControl)GroupPanel1).get_StyleMouseOver().set_CornerType((eCornerType)1);
		((Control)GroupPanel1).set_TabIndex(12);
		((PanelControl)GroupPanel1).set_Text("新建库x模板");
		((BaseItemControl)LabelX6).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX6).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX11 = LabelX6;
		location = new Point(236, 7);
		((Control)labelX11).set_Location(location);
		((Control)LabelX6).set_Name("LabelX6");
		LabelX labelX12 = LabelX6;
		size = new Size(95, 23);
		((Control)labelX12).set_Size(size);
		((Control)LabelX6).set_TabIndex(0);
		LabelX6.set_Text("部件示意图");
		((BaseItemControl)LabelX7).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX7).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX13 = LabelX7;
		location = new Point(7, 384);
		((Control)labelX13).set_Location(location);
		((Control)LabelX7).set_Name("LabelX7");
		LabelX labelX14 = LabelX7;
		size = new Size(148, 16);
		((Control)labelX14).set_Size(size);
		((Control)LabelX7).set_TabIndex(0);
		LabelX7.set_Text("实例文件夹下实例列表");
		((ListControl)lstsllb).set_FormattingEnabled(true);
		lstsllb.set_ItemHeight(12);
		ListBox obj13 = lstsllb;
		location = new Point(6, 405);
		((Control)obj13).set_Location(location);
		((Control)lstsllb).set_Name("lstsllb");
		ListBox obj14 = lstsllb;
		size = new Size(213, 64);
		((Control)obj14).set_Size(size);
		((Control)lstsllb).set_TabIndex(13);
		((ButtonBase)Rbmp).set_AutoSize(true);
		((Control)Rbmp).set_Enabled(false);
		((Control)Rbmp).set_ForeColor(SystemColors.Highlight);
		RadioButton rbmp = Rbmp;
		location = new Point(82, 93);
		((Control)rbmp).set_Location(location);
		((Control)Rbmp).set_Name("Rbmp");
		RadioButton rbmp2 = Rbmp;
		size = new Size(53, 16);
		((Control)rbmp2).set_Size(size);
		((Control)Rbmp).set_TabIndex(14);
		Rbmp.set_TabStop(true);
		((ButtonBase)Rbmp).set_Text("*.bmp");
		((ButtonBase)Rbmp).set_UseVisualStyleBackColor(true);
		((BaseItemControl)LabelX8).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX8).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX15 = LabelX8;
		location = new Point(3, 93);
		((Control)labelX15).set_Location(location);
		((Control)LabelX8).set_Name("LabelX8");
		LabelX labelX16 = LabelX8;
		size = new Size(75, 16);
		((Control)labelX16).set_Size(size);
		((Control)LabelX8).set_TabIndex(0);
		LabelX8.set_Text("图片格式");
		((ButtonBase)Rjpg).set_AutoSize(true);
		((Control)Rjpg).set_Enabled(false);
		((Control)Rjpg).set_ForeColor(Color.RoyalBlue);
		RadioButton rjpg = Rjpg;
		location = new Point(141, 93);
		((Control)rjpg).set_Location(location);
		((Control)Rjpg).set_Name("Rjpg");
		RadioButton rjpg2 = Rjpg;
		size = new Size(53, 16);
		((Control)rjpg2).set_Size(size);
		((Control)Rjpg).set_TabIndex(14);
		Rjpg.set_TabStop(true);
		((ButtonBase)Rjpg).set_Text("*.jpg");
		((ButtonBase)Rjpg).set_UseVisualStyleBackColor(true);
		((Control)btnck).set_AccessibleRole((AccessibleRole)43);
		btnck.set_ColorTable((eButtonColor)3);
		ButtonX obj15 = btnck;
		location = new Point(638, 353);
		((Control)obj15).set_Location(location);
		((Control)btnck).set_Name("btnck");
		ButtonX obj16 = btnck;
		size = new Size(204, 23);
		((Control)obj16).set_Size(size);
		((PopupItemControl)btnck).set_Style((eDotNetBarStyle)7);
		((Control)btnck).set_TabIndex(2);
		btnck.set_Text("查看说明信息");
		((BaseItemControl)LabelX9).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX9).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX17 = LabelX9;
		location = new Point(3, 3);
		((Control)labelX17).set_Location(location);
		((Control)LabelX9).set_Name("LabelX9");
		LabelX labelX18 = LabelX9;
		size = new Size(85, 16);
		((Control)labelX18).set_Size(size);
		((Control)LabelX9).set_TabIndex(0);
		LabelX9.set_Text("图片列表");
		((ListControl)lsttplb).set_FormattingEnabled(true);
		lsttplb.set_ItemHeight(12);
		ListBox obj17 = lsttplb;
		location = new Point(3, 24);
		((Control)obj17).set_Location(location);
		((Control)lsttplb).set_Name("lsttplb");
		ListBox obj18 = lsttplb;
		size = new Size(191, 64);
		((Control)obj18).set_Size(size);
		((Control)lsttplb).set_TabIndex(13);
		((BaseItemControl)LabelX10).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX10).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX19 = LabelX10;
		location = new Point(638, 175);
		((Control)labelX19).set_Location(location);
		((Control)LabelX10).set_Name("LabelX10");
		LabelX labelX20 = LabelX10;
		size = new Size(97, 16);
		((Control)labelX20).set_Size(size);
		((Control)LabelX10).set_TabIndex(0);
		LabelX10.set_Text("介绍信息");
		((Control)btnzj).set_AccessibleRole((AccessibleRole)43);
		btnzj.set_ColorTable((eButtonColor)3);
		ButtonX obj19 = btnzj;
		location = new Point(236, 427);
		((Control)obj19).set_Location(location);
		((Control)btnzj).set_Name("btnzj");
		ButtonX obj20 = btnzj;
		size = new Size(152, 23);
		((Control)obj20).set_Size(size);
		((PopupItemControl)btnzj).set_Style((eDotNetBarStyle)7);
		((Control)btnzj).set_TabIndex(2);
		btnzj.set_Text("追加模型文件至当前库");
		((Control)btnckk).set_AccessibleRole((AccessibleRole)43);
		btnckk.set_ColorTable((eButtonColor)3);
		ButtonX obj21 = btnckk;
		location = new Point(566, 427);
		((Control)obj21).set_Location(location);
		((Control)btnckk).set_Name("btnckk");
		ButtonX obj22 = btnckk;
		size = new Size(141, 23);
		((Control)obj22).set_Size(size);
		((PopupItemControl)btnckk).set_Style((eDotNetBarStyle)7);
		((Control)btnckk).set_TabIndex(2);
		btnckk.set_Text("查看当前库");
		((Control)gb).set_AccessibleRole((AccessibleRole)43);
		gb.set_ColorTable((eButtonColor)3);
		gb.set_DialogResult((DialogResult)2);
		ButtonX obj23 = gb;
		location = new Point(713, 427);
		((Control)obj23).set_Location(location);
		((Control)gb).set_Name("gb");
		ButtonX obj24 = gb;
		size = new Size(129, 23);
		((Control)obj24).set_Size(size);
		((PopupItemControl)gb).set_Style((eDotNetBarStyle)7);
		((Control)gb).set_TabIndex(2);
		gb.set_Text("关闭");
		((TextBox)txtjs).set_AcceptsReturn(true);
		((TextBoxBase)txtjs).set_AcceptsTab(true);
		txtjs.get_Border().set_Class("TextBoxBorder");
		txtjs.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj25 = txtjs;
		location = new Point(638, 197);
		((Control)obj25).set_Location(location);
		((TextBox)txtjs).set_Multiline(true);
		((Control)txtjs).set_Name("txtjs");
		((TextBoxBase)txtjs).set_ReadOnly(true);
		TextBoxX obj26 = txtjs;
		size = new Size(204, 150);
		((Control)obj26).set_Size(size);
		((Control)txtjs).set_TabIndex(15);
		((PanelControl)GroupPanel2).set_CanvasColor(SystemColors.Control);
		((PanelControl)GroupPanel2).set_ColorSchemeStyle((eDotNetBarStyle)4);
		((Control)GroupPanel2).get_Controls().Add((Control)(object)LabelX9);
		((Control)GroupPanel2).get_Controls().Add((Control)(object)lsttplb);
		((Control)GroupPanel2).get_Controls().Add((Control)(object)Rjpg);
		((Control)GroupPanel2).get_Controls().Add((Control)(object)LabelX8);
		((Control)GroupPanel2).get_Controls().Add((Control)(object)Rbmp);
		GroupPanel groupPanel3 = GroupPanel2;
		location = new Point(638, 35);
		((Control)groupPanel3).set_Location(location);
		((Control)GroupPanel2).set_Name("GroupPanel2");
		GroupPanel groupPanel4 = GroupPanel2;
		size = new Size(204, 134);
		((Control)groupPanel4).set_Size(size);
		((PanelControl)GroupPanel2).get_Style().set_BackColor2SchemePart((eColorSchemePart)52);
		((PanelControl)GroupPanel2).get_Style().set_BackColorGradientAngle(90);
		((PanelControl)GroupPanel2).get_Style().set_BackColorSchemePart((eColorSchemePart)51);
		((PanelControl)GroupPanel2).get_Style().set_BorderBottom((eStyleBorderType)1);
		((PanelControl)GroupPanel2).get_Style().set_BorderBottomWidth(1);
		((PanelControl)GroupPanel2).get_Style().set_BorderColorSchemePart((eColorSchemePart)53);
		((PanelControl)GroupPanel2).get_Style().set_BorderLeft((eStyleBorderType)1);
		((PanelControl)GroupPanel2).get_Style().set_BorderLeftWidth(1);
		((PanelControl)GroupPanel2).get_Style().set_BorderRight((eStyleBorderType)1);
		((PanelControl)GroupPanel2).get_Style().set_BorderRightWidth(1);
		((PanelControl)GroupPanel2).get_Style().set_BorderTop((eStyleBorderType)1);
		((PanelControl)GroupPanel2).get_Style().set_BorderTopWidth(1);
		((PanelControl)GroupPanel2).get_Style().set_Class("");
		((PanelControl)GroupPanel2).get_Style().set_CornerDiameter(4);
		((PanelControl)GroupPanel2).get_Style().set_CornerType((eCornerType)2);
		((PanelControl)GroupPanel2).get_Style().set_TextAlignment((eStyleTextAlignment)1);
		((PanelControl)GroupPanel2).get_Style().set_TextColorSchemePart((eColorSchemePart)54);
		((PanelControl)GroupPanel2).get_Style().set_TextLineAlignment((eStyleTextAlignment)0);
		((PanelControl)GroupPanel2).get_StyleMouseDown().set_Class("");
		((PanelControl)GroupPanel2).get_StyleMouseDown().set_CornerType((eCornerType)1);
		((PanelControl)GroupPanel2).get_StyleMouseOver().set_Class("");
		((PanelControl)GroupPanel2).get_StyleMouseOver().set_CornerType((eCornerType)1);
		((Control)GroupPanel2).set_TabIndex(16);
		((PanelControl)GroupPanel2).set_Text("示意图信息");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_CancelButton((IButtonControl)(object)gb);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		size = new Size(849, 475);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)GroupPanel2);
		((Control)this).get_Controls().Add((Control)(object)txtjs);
		((Control)this).get_Controls().Add((Control)(object)lstsllb);
		((Control)this).get_Controls().Add((Control)(object)LabelX10);
		((Control)this).get_Controls().Add((Control)(object)LabelX7);
		((Control)this).get_Controls().Add((Control)(object)GroupPanel1);
		((Control)this).get_Controls().Add((Control)(object)PB);
		((Control)this).get_Controls().Add((Control)(object)cmbclgn);
		((Control)this).get_Controls().Add((Control)(object)cmbcshsl);
		((Control)this).get_Controls().Add((Control)(object)gb);
		((Control)this).get_Controls().Add((Control)(object)btnckk);
		((Control)this).get_Controls().Add((Control)(object)btnzj);
		((Control)this).get_Controls().Add((Control)(object)btnck);
		((Control)this).get_Controls().Add((Control)(object)btnmblj);
		((Control)this).get_Controls().Add((Control)(object)ButtonX1);
		((Control)this).get_Controls().Add((Control)(object)txtkname);
		((Control)this).get_Controls().Add((Control)(object)LabelX3);
		((Control)this).get_Controls().Add((Control)(object)LabelX2);
		((Control)this).get_Controls().Add((Control)(object)LabelX6);
		((Control)this).get_Controls().Add((Control)(object)LabelX1);
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("drclk");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("追加到当前模型库...");
		((ISupportInitialize)PB).EndInit();
		((Control)GroupPanel1).ResumeLayout(false);
		((Control)GroupPanel2).ResumeLayout(false);
		((Control)GroupPanel2).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void drclk_Load(object sender, EventArgs e)
	{
		((Control)LabelX4).set_BackColor(Color.Transparent);
		((Control)LabelX5).set_BackColor(Color.Transparent);
		((Control)LabelX9).set_BackColor(Color.Transparent);
		((Control)LabelX8).set_BackColor(Color.Transparent);
		((ButtonBase)Rbmp).set_BackColor(Color.Transparent);
		((ButtonBase)Rjpg).set_BackColor(Color.Transparent);
		Mod1.lr = new StreamReader(Application.get_StartupPath() + "\\config\\参数化实例列表.ini", Encoding.Default);
		cmbcshsl.get_Items().Clear();
		f = "";
		while (!Information.IsNothing((object)f))
		{
			f = Mod1.lr.ReadLine();
			if (Information.IsNothing((object)f))
			{
				break;
			}
			ff = f.Split(new char[1] { ',' });
			cmbcshsl.get_Items().Add((object)ff[0]);
		}
		Mod1.lr.Close();
		Mod1.lr.Dispose();
		Mod1.lr = new StreamReader(Application.get_StartupPath() + "\\config\\处理功能列表.ini", Encoding.Default);
		f = "";
		while (!Information.IsNothing((object)f))
		{
			f = Mod1.lr.ReadLine();
			if (Information.IsNothing((object)f))
			{
				break;
			}
			ff = f.Split(new char[1] { ',' });
			cmbclgn.get_Items().Add((object)ff[0]);
		}
		Mod1.lr.Close();
		Mod1.lr.Dispose();
		((TextBox)txtkname).set_Text("newx");
	}

	private void gb_Click(object sender, EventArgs e)
	{
		MyProject.Forms.mxkgl.log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员关闭了导入块对话框"));
		((Form)this).Close();
	}

	private void btnmblj_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		FolderBrowserDialog val = new FolderBrowserDialog();
		val.set_Description("请指定新建库x模板所在路径");
		((CommonDialog)val).ShowDialog();
		lstsllb.get_Items().Clear();
		if (Operators.CompareString(val.get_SelectedPath(), "", false) == 0)
		{
			((TextBox)txtxlslj).set_Text("");
			((TextBox)txtslwj).set_Text("");
			((Control)Rbmp).set_Enabled(false);
			((Control)Rjpg).set_Enabled(false);
			lsttplb.get_Items().Clear();
			((TextBox)txtjs).set_Text("");
			return;
		}
		if (Operators.CompareString(Strings.Right(val.get_SelectedPath(), 1), "\\", false) != 0)
		{
			val.set_SelectedPath(val.get_SelectedPath() + "\\");
		}
		pshili = val.get_SelectedPath() + "实例文件夹";
		pxls = val.get_SelectedPath() + "xls文件";
		if (!Directory.Exists(pxls))
		{
			Interaction.MsgBox((object)"当前打开的路径不是【新建库x模板】.", (MsgBoxStyle)64, (object)"提示");
			return;
		}
		((TextBox)txtxlslj).set_Text(val.get_SelectedPath() + "xls文件");
		if (!Directory.Exists(pshili))
		{
			Interaction.MsgBox((object)"没有找到实例文件夹.", (MsgBoxStyle)64, (object)"提示");
			return;
		}
		string[] directories = Directory.GetDirectories(val.get_SelectedPath() + "实例文件夹");
		tmp = directories[0].Substring(checked(directories[0].LastIndexOf("\\") + 1));
		((TextBox)txtslwj).set_Text(tmp);
		lstsllb.get_Items().Add((object)tmp);
		if (lstsllb.get_Items().get_Count() != 0)
		{
			lstsllb.set_SelectedIndex(0);
		}
	}

	private void lstsllb_SelectedIndexChanged(object sender, EventArgs e)
	{
		string[] files = Directory.GetFiles(pshili + "\\" + lstsllb.get_Text(), "*.bmp", SearchOption.TopDirectoryOnly);
		string[] files2 = Directory.GetFiles(pshili + "\\" + lstsllb.get_Text(), "*.jpg", SearchOption.TopDirectoryOnly);
		if ((files2.Length != 0) & (files.Length != 0))
		{
			Rbmp.set_Checked(true);
			((Control)Rbmp).set_Enabled(true);
			((Control)Rjpg).set_Enabled(true);
			return;
		}
		if (files2.Length == 0)
		{
			((Control)Rjpg).set_Enabled(false);
		}
		else
		{
			((Control)Rjpg).set_Enabled(true);
			Rjpg.set_Checked(true);
		}
		if (files.Length == 0)
		{
			((Control)Rbmp).set_Enabled(false);
			return;
		}
		Rbmp.set_Checked(true);
		((Control)Rbmp).set_Enabled(true);
	}

	private void Rbmp_CheckedChanged(object sender, EventArgs e)
	{
		pp = 0;
		if (!Rbmp.get_Checked() || Operators.CompareString(lstsllb.get_Text(), "", false) == 0)
		{
			return;
		}
		Bmporjpg = Directory.GetFiles(pshili + "\\" + lstsllb.get_Text(), "*.bmp", SearchOption.TopDirectoryOnly);
		checked
		{
			if (Bmporjpg.Length != 0)
			{
				lsttplb.get_Items().Clear();
				int num = Bmporjpg.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					tmp = Bmporjpg[i].Substring(Bmporjpg[i].LastIndexOf("\\") + 1);
					lsttplb.get_Items().Add((object)tmp);
				}
				lsttplb.set_SelectedIndex(0);
				PB.set_ImageLocation(pshili + "\\" + lstsllb.get_Text() + "\\" + lsttplb.get_Text());
			}
		}
	}

	private void Rjpg_CheckedChanged(object sender, EventArgs e)
	{
		pp = 0;
		if (!Rjpg.get_Checked() || Operators.CompareString(lstsllb.get_Text(), "", false) == 0)
		{
			return;
		}
		Bmporjpg = Directory.GetFiles(pshili + "\\" + lstsllb.get_Text(), "*.jpg", SearchOption.TopDirectoryOnly);
		checked
		{
			if (Bmporjpg.Length != 0)
			{
				lsttplb.get_Items().Clear();
				int num = Bmporjpg.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					tmp = Bmporjpg[i].Substring(Bmporjpg[i].LastIndexOf("\\") + 1);
					lsttplb.get_Items().Add((object)tmp);
				}
				lsttplb.set_SelectedIndex(0);
				PB.set_ImageLocation(pshili + "\\" + lstsllb.get_Text() + "\\" + lsttplb.get_Text());
			}
		}
	}

	private void lsttplb_SelectedIndexChanged(object sender, EventArgs e)
	{
		PB.set_ImageLocation(pshili + "\\" + lstsllb.get_Text() + "\\" + lsttplb.get_Text());
		pp = lsttplb.get_SelectedIndex();
	}

	private void btnck_Click(object sender, EventArgs e)
	{
		if (File.Exists(pshili + "\\" + lstsllb.get_Text() + "\\Readme.txt"))
		{
			Mod1.lr = new StreamReader(pshili + "\\" + lstsllb.get_Text() + "\\Readme.txt", Encoding.Default);
			((TextBox)txtjs).set_Text(Mod1.lr.ReadLine());
			Mod1.lr.Close();
			Mod1.lr.Dispose();
		}
	}

	private void PB_Click(object sender, EventArgs e)
	{
		checked
		{
			if (lsttplb.get_Items().get_Count() != 0)
			{
				pp++;
				if (pp < lsttplb.get_Items().get_Count())
				{
					lsttplb.set_SelectedIndex(pp);
				}
				else if (lsttplb.get_Items().get_Count() != 0)
				{
					pp = 0;
					lsttplb.set_SelectedIndex(0);
				}
			}
		}
	}

	private void btnckk_Click(object sender, EventArgs e)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Invalid comparison between Unknown and I4
		if ((int)MessageBox.Show("当前模型库为：" + Mod1.Kulujing + ",是否打开该文件夹？", "提示", (MessageBoxButtons)4, (MessageBoxIcon)64) == 6)
		{
			Process.Start(Mod1.Kulujing);
		}
	}

	private void ButtonX1_Click(object sender, EventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((Form)MyProject.Forms.liulk).ShowDialog();
		((Component)(object)MyProject.Forms.liulk).Dispose();
	}

	private void btnzj_Click(object sender, EventArgs e)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		if ((((ComboBox)cmbcshsl).get_SelectedIndex() == -1) | (((ComboBox)cmbclgn).get_SelectedIndex() == -1))
		{
			Interaction.MsgBox((object)"【参数化库/实例库】或【处理功能】不能为空！", (MsgBoxStyle)64, (object)"选择错误");
			return;
		}
		if (Operators.CompareString(((TextBox)txtxlslj).get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"你必须指定【新建库x模板】路径!", (MsgBoxStyle)64, (object)"路径错误");
			return;
		}
		if (((TextBox)txtkname).get_Text().IndexOf(" ") != -1)
		{
			Interaction.MsgBox((object)"新部件名字当中不能有空格！！", (MsgBoxStyle)64, (object)"名称错误");
			return;
		}
		int num = Strings.Len(((TextBox)txtkname).get_Text());
		int num2 = 1;
		while (true)
		{
			if (num2 <= num)
			{
				string text = Conversion.Hex(Strings.Asc(Strings.Mid(((TextBox)txtkname).get_Text(), num2, 1)));
				if ((Strings.Asc(Strings.Left(text, 1)) >= 66) & (Strings.Asc(Strings.Left(text, 1)) <= 70))
				{
					break;
				}
				num2 = checked(num2 + 1);
				continue;
			}
			if (!Operators.ConditionalCompareObjectEqual(CheckShili(), (object)false, false))
			{
				((Control)this).set_Cursor(Cursors.get_AppStarting());
				if (Directory.Exists(Mod1.Kulujing + ((TextBox)txtkname).get_Text()))
				{
					Add();
					Interaction.MsgBox((object)"追加成功！！", (MsgBoxStyle)64, (object)"成功");
					((Component)(object)MyProject.Forms.FrmOf).Dispose();
				}
				else
				{
					Add();
					MyProject.Forms.Updtmlibs.n = ((TextBox)txtkname).get_Text();
					((Component)(object)MyProject.Forms.FrmOf).Dispose();
					((Form)MyProject.Forms.Updtmlibs).ShowDialog();
					Interaction.MsgBox((object)"追加成功！！", (MsgBoxStyle)64, (object)"成功");
				}
				((Control)this).set_Cursor(Cursors.get_Arrow());
			}
			return;
		}
		Interaction.MsgBox((object)"新部件名字当中不能有中文！！", (MsgBoxStyle)64, (object)"名称错误");
	}

	public void Add()
	{
		if (Operators.CompareString(((ComboBox)cmbcshsl).get_Text(), "参数化模型", false) == 0)
		{
			string text = Mod1.Kulujing + ((TextBox)txtkname).get_Text();
			Directory.CreateDirectory(text);
			string path = text + "\\" + ((TextBox)txtkname).get_Text() + ".lis";
			if (File.Exists(path))
			{
				if (Operators.ConditionalCompareObjectNotEqual(CheckNR(ref path), (object)false, false))
				{
					Mod1.wr = new StreamWriter(path, append: true, Encoding.Default);
					Mod1.wr.WriteLine(((ComboBox)cmbcshsl).get_Text());
					Mod1.wr.Close();
					Mod1.wr.Dispose();
				}
			}
			else
			{
				Mod1.wr = new StreamWriter(path, append: true, Encoding.Default);
				Mod1.wr.WriteLine(((ComboBox)cmbcshsl).get_Text());
				Mod1.wr.Close();
				Mod1.wr.Dispose();
			}
			ComboBoxEx val = cmbcshsl;
			string text2 = ((ComboBox)val).get_Text();
			string text3 = Mod1.toen(ref text2);
			((ComboBox)val).set_Text(text2);
			ComboBoxEx val2;
			string text5;
			if (Operators.CompareString(text3, "", false) != 0)
			{
				string text4 = text;
				val2 = cmbcshsl;
				text5 = ((ComboBox)val2).get_Text();
				string text6 = Mod1.toen(ref text5);
				((ComboBox)val2).set_Text(text5);
				Directory.CreateDirectory(text4 + "\\" + text6);
				string text7 = text;
				val2 = cmbcshsl;
				text5 = ((ComboBox)val2).get_Text();
				string text8 = Mod1.toen(ref text5);
				((ComboBox)val2).set_Text(text5);
				Directory.CreateDirectory(text7 + "\\" + text8 + "\\cstemp");
			}
			string[] array = new string[6] { text, "\\", null, null, null, null };
			string[] array2 = array;
			val = cmbcshsl;
			text2 = ((ComboBox)val).get_Text();
			string text9 = Mod1.toen(ref text2);
			((ComboBox)val).set_Text(text2);
			array2[2] = text9;
			array[3] = "\\";
			string[] array3 = array;
			val2 = cmbcshsl;
			text5 = ((ComboBox)val2).get_Text();
			string text10 = Mod1.toen(ref text5);
			((ComboBox)val2).set_Text(text5);
			array3[4] = text10;
			array[5] = ".lis";
			path = string.Concat(array);
			if (File.Exists(path))
			{
				if (Operators.ConditionalCompareObjectNotEqual(CheckNR(ref path), (object)false, false))
				{
					Mod1.wr = new StreamWriter(path, append: true, Encoding.Default);
					Mod1.wr.WriteLine(((ComboBox)cmbclgn).get_Text());
					Mod1.wr.Close();
					Mod1.wr.Dispose();
				}
			}
			else
			{
				Mod1.wr = new StreamWriter(path, append: true, Encoding.Default);
				Mod1.wr.WriteLine(((ComboBox)cmbclgn).get_Text());
				Mod1.wr.Close();
				Mod1.wr.Dispose();
			}
			val2 = cmbcshsl;
			text5 = ((ComboBox)val2).get_Text();
			string text11 = Mod1.toen(ref text5);
			((ComboBox)val2).set_Text(text5);
			bool num = Operators.CompareString(text11, "", false) != 0;
			val = cmbclgn;
			text2 = ((ComboBox)val).get_Text();
			string text12 = Mod1.toen(ref text2);
			((ComboBox)val).set_Text(text2);
			if (num & (Operators.CompareString(text12, "", false) != 0))
			{
				string text13 = text;
				ComboBoxEx val3 = cmbcshsl;
				string text14 = ((ComboBox)val3).get_Text();
				string text15 = Mod1.toen(ref text14);
				((ComboBox)val3).set_Text(text14);
				string text16 = text13 + "\\" + text15 + "\\";
				string text17 = text16;
				val3 = cmbclgn;
				text14 = ((ComboBox)val3).get_Text();
				string text18 = Mod1.toen(ref text14);
				((ComboBox)val3).set_Text(text14);
				Directory.CreateDirectory(text17 + text18);
				FileSystemProxy fileSystem = ((ServerComputer)MyProject.Computer).get_FileSystem();
				string text19 = pshili + "\\" + lstsllb.get_Text();
				string text20 = text16;
				val3 = cmbclgn;
				text14 = ((ComboBox)val3).get_Text();
				string text21 = Mod1.toen(ref text14);
				((ComboBox)val3).set_Text(text14);
				fileSystem.CopyDirectory(text19, text20 + text21 + "\\" + lstsllb.get_Text(), true);
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyDirectory(pxls + "\\", text16 + "\\cs", true);
			}
		}
		else if (Operators.CompareString(((ComboBox)cmbcshsl).get_Text(), "实例模型", false) == 0)
		{
			string text = Mod1.Kulujing + ((TextBox)txtkname).get_Text();
			Directory.CreateDirectory(text);
			string path = text + "\\" + ((TextBox)txtkname).get_Text() + ".lis";
			Mod1.wr = new StreamWriter(path, append: true, Encoding.Default);
			Mod1.wr.WriteLine(((ComboBox)cmbcshsl).get_Text());
			Mod1.wr.Close();
			Mod1.wr.Dispose();
			string text22 = text;
			ComboBoxEx val3 = cmbcshsl;
			string text14 = ((ComboBox)val3).get_Text();
			string text23 = Mod1.toen(ref text14);
			((ComboBox)val3).set_Text(text14);
			Directory.CreateDirectory(text22 + "\\" + text23);
			string[] array = new string[6] { text, "\\", null, null, null, null };
			string[] array4 = array;
			ComboBoxEx val2 = cmbcshsl;
			string text5 = ((ComboBox)val2).get_Text();
			string text24 = Mod1.toen(ref text5);
			((ComboBox)val2).set_Text(text5);
			array4[2] = text24;
			array[3] = "\\";
			string[] array5 = array;
			val3 = cmbcshsl;
			text14 = ((ComboBox)val3).get_Text();
			string text25 = Mod1.toen(ref text14);
			((ComboBox)val3).set_Text(text14);
			array5[4] = text25;
			array[5] = ".lis";
			path = string.Concat(array);
			Mod1.wr = new StreamWriter(path, append: true, Encoding.Default);
			Mod1.wr.WriteLine(((ComboBox)cmbclgn).get_Text());
			Mod1.wr.Close();
			Mod1.wr.Dispose();
			string text26 = text;
			val3 = cmbcshsl;
			text14 = ((ComboBox)val3).get_Text();
			string text27 = Mod1.toen(ref text14);
			((ComboBox)val3).set_Text(text14);
			string text16 = text26 + "\\" + text27 + "\\";
			string text28 = text16;
			val3 = cmbclgn;
			text14 = ((ComboBox)val3).get_Text();
			string text29 = Mod1.toen(ref text14);
			((ComboBox)val3).set_Text(text14);
			Directory.CreateDirectory(text28 + text29);
			FileSystemProxy fileSystem2 = ((ServerComputer)MyProject.Computer).get_FileSystem();
			string text30 = pshili + "\\" + lstsllb.get_Text();
			string text31 = text16;
			val3 = cmbclgn;
			text14 = ((ComboBox)val3).get_Text();
			string text32 = Mod1.toen(ref text14);
			((ComboBox)val3).set_Text(text14);
			fileSystem2.CopyDirectory(text30, text31 + text32 + "\\" + lstsllb.get_Text(), true);
		}
	}

	public object CheckShili()
	{
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		object result = default(object);
		if ((Operators.CompareString(((ComboBox)cmbclgn).get_Text(), "ansys性能计算", false) != 0) & (Operators.CompareString(((ComboBox)cmbclgn).get_Text(), "nsys校核计算", false) != 0) & (Operators.CompareString(((ComboBox)cmbclgn).get_Text(), "ansys方案计算", false) != 0))
		{
			if (Directory.Exists(pshili + "\\" + lstsllb.get_Text() + "\\source"))
			{
				string[] files = Directory.GetFiles(pshili + "\\" + lstsllb.get_Text() + "\\source", lstsllb.get_Text() + ".asm.*", SearchOption.TopDirectoryOnly);
				if (files.Length == 0)
				{
					files = Directory.GetFiles(pshili + "\\" + lstsllb.get_Text() + "\\source", lstsllb.get_Text() + ".prt.*", SearchOption.TopDirectoryOnly);
					if (files.Length == 0)
					{
						Interaction.MsgBox((object)"实例目录下没有找到与文件夹对应的.asm文件", (MsgBoxStyle)64, (object)"提示");
						result = false;
					}
					else
					{
						result = true;
					}
				}
				else
				{
					result = true;
				}
			}
			else
			{
				Interaction.MsgBox((object)(pshili + "\\" + lstsllb.get_Text() + "\\source"), (MsgBoxStyle)64, (object)"提示");
				result = false;
			}
		}
		else
		{
			if (Operators.CompareString(((ComboBox)cmbclgn).get_Text(), "ansys方案计算", false) == 0 && Directory.Exists(pshili + "\\" + lstsllb.get_Text() + "\\source"))
			{
				string[] files = Directory.GetFiles(pshili + "\\" + lstsllb.get_Text() + "\\source", "臂头曲线计算_1.BAT", SearchOption.TopDirectoryOnly);
				if (files.Length == 0)
				{
					Interaction.MsgBox((object)"没有找到【臂头曲线计算_1.BAT】文件！", (MsgBoxStyle)64, (object)"提示");
					result = false;
				}
				else
				{
					result = true;
					files = Directory.GetFiles(pshili + "\\" + lstsllb.get_Text() + "\\source", "方案计算_2.BAT", SearchOption.TopDirectoryOnly);
					if (files.Length == 0)
					{
						Interaction.MsgBox((object)"没有找到【方案计算_2.BAT】文件！", (MsgBoxStyle)64, (object)"提示");
						result = false;
					}
					else
					{
						result = true;
					}
				}
			}
			if (Operators.CompareString(((ComboBox)cmbclgn).get_Text(), "ansys性能计算", false) == 0)
			{
				if (Directory.Exists(pshili + "\\" + lstsllb.get_Text() + "\\source"))
				{
					string[] files = Directory.GetFiles(pshili + "\\" + lstsllb.get_Text() + "\\source", "RUN.BAT", SearchOption.TopDirectoryOnly);
					if (files.Length == 0)
					{
						Interaction.MsgBox((object)"没有找到【RUN.BAT】文件！", (MsgBoxStyle)64, (object)"提示");
						result = false;
					}
					else
					{
						result = true;
					}
				}
				else
				{
					result = false;
				}
			}
		}
		return result;
	}

	public object CheckNR(ref string path)
	{
		Mod1.lr = new StreamReader(path, Encoding.Default);
		f = "";
		object result = default(object);
		while (!Information.IsNothing((object)f))
		{
			f = Mod1.lr.ReadLine();
			if (Information.IsNothing((object)f))
			{
				break;
			}
			if (!((Operators.CompareString(f, ((ComboBox)cmbcshsl).get_Text(), false) == 0) | (Operators.CompareString(f, ((ComboBox)cmbclgn).get_Text(), false) == 0)))
			{
				result = true;
				continue;
			}
			result = false;
			break;
		}
		Mod1.lr.Close();
		Mod1.lr.Dispose();
		return result;
	}
}
