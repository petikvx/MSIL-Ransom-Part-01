using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
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
public class ll_ufxnbBrowser : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("ll_btnspecialxnlibs")]
	private ButtonX _ll_btnspecialxnlibs;

	[AccessedThroughProperty("ll_txtxnlibspath")]
	private TextBoxX _ll_txtxnlibspath;

	[AccessedThroughProperty("LabelX2")]
	private LabelX _LabelX2;

	[AccessedThroughProperty("ll_CB_JieGouXingShi")]
	private ComboBoxEx _ll_CB_JieGouXingShi;

	[AccessedThroughProperty("LabelX3")]
	private LabelX _LabelX3;

	[AccessedThroughProperty("ll_CB_PeiZhong")]
	private ComboBoxEx _ll_CB_PeiZhong;

	[AccessedThroughProperty("LabelX4")]
	private LabelX _LabelX4;

	[AccessedThroughProperty("ll_CB_ZhiTuiKuaJu")]
	private ComboBoxEx _ll_CB_ZhiTuiKuaJu;

	[AccessedThroughProperty("GroupPanel1")]
	private GroupPanel _GroupPanel1;

	[AccessedThroughProperty("ll_frmfb")]
	private GroupPanel _ll_frmfb;

	[AccessedThroughProperty("ll_checkzbyx")]
	private CheckBoxX _ll_checkzbyx;

	[AccessedThroughProperty("ll_lbXT")]
	private LabelX _ll_lbXT;

	[AccessedThroughProperty("ll_CB_FuBiFuBi")]
	private ComboBoxEx _ll_CB_FuBiFuBi;

	[AccessedThroughProperty("ll_CB_FuBiZBXT")]
	private ComboBoxEx _ll_CB_FuBiZBXT;

	[AccessedThroughProperty("ll_CB_FuBiZhuBi")]
	private ComboBoxEx _ll_CB_FuBiZhuBi;

	[AccessedThroughProperty("LabelX5")]
	private LabelX _LabelX5;

	[AccessedThroughProperty("LabelX6")]
	private LabelX _LabelX6;

	[AccessedThroughProperty("LabelX7")]
	private LabelX _LabelX7;

	[AccessedThroughProperty("LabelX8")]
	private LabelX _LabelX8;

	[AccessedThroughProperty("ll_lbxlslist")]
	private ListBox _ll_lbxlslist;

	[AccessedThroughProperty("ll_btnshowxls")]
	private ButtonX _ll_btnshowxls;

	[AccessedThroughProperty("ll_btn_Check")]
	private ButtonX _ll_btn_Check;

	[AccessedThroughProperty("ll_btn_OutPut")]
	private ButtonX _ll_btn_OutPut;

	[AccessedThroughProperty("ll_btn_Exit")]
	private ButtonX _ll_btn_Exit;

	[AccessedThroughProperty("LabelX9")]
	private LabelX _LabelX9;

	[AccessedThroughProperty("ll_LB_ControlOpt")]
	private ListBox _ll_LB_ControlOpt;

	[AccessedThroughProperty("cldisplay")]
	private CheckBoxX _cldisplay;

	[AccessedThroughProperty("liulan")]
	private ButtonX _liulan;

	[AccessedThroughProperty("ll_CheckQDflag")]
	private CheckBoxX _ll_CheckQDflag;

	[AccessedThroughProperty("ll_LB_Results")]
	private ListBox _ll_LB_Results;

	[AccessedThroughProperty("ButtonX1")]
	private ButtonX _ButtonX1;

	private bool curJieGouXingShiChange;

	private string JieGouXingShi;

	private string PeiZhong;

	private string ZhiTuiKuaJu;

	private bool blnFuBiZhuBi;

	private string FuBiZBXT;

	private string FuBiZhuBi;

	private string FuBiFuBi;

	private string ControlOpt;

	private string ControlOpti;

	private string ControlList;

	private string ZhuBiZhuBi;

	private string strLBXT;

	private bool curDataCheckOK;

	private bool curPZDataCheckOK;

	private bool dbOpen;

	private bool bnewpath;

	private bool bhqz;

	private bool bfb;

	internal virtual ButtonX ll_btnspecialxnlibs
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnspecialxnlibs;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnspecialxnlibs_Click;
			if (_ll_btnspecialxnlibs != null)
			{
				((Control)_ll_btnspecialxnlibs).remove_Click(eventHandler);
			}
			_ll_btnspecialxnlibs = value;
			if (_ll_btnspecialxnlibs != null)
			{
				((Control)_ll_btnspecialxnlibs).add_Click(eventHandler);
			}
		}
	}

	internal virtual TextBoxX ll_txtxnlibspath
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_txtxnlibspath;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_txtxnlibspath = value;
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

	internal virtual ComboBoxEx ll_CB_JieGouXingShi
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_CB_JieGouXingShi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_CB_JieGouXingShi_SelectedIndexChanged;
			EventHandler eventHandler2 = ll_CB_JieGouXingShi_DropDown;
			if (_ll_CB_JieGouXingShi != null)
			{
				((ComboBox)_ll_CB_JieGouXingShi).remove_SelectedIndexChanged(eventHandler);
				((ComboBox)_ll_CB_JieGouXingShi).remove_DropDown(eventHandler2);
			}
			_ll_CB_JieGouXingShi = value;
			if (_ll_CB_JieGouXingShi != null)
			{
				((ComboBox)_ll_CB_JieGouXingShi).add_SelectedIndexChanged(eventHandler);
				((ComboBox)_ll_CB_JieGouXingShi).add_DropDown(eventHandler2);
			}
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

	internal virtual ComboBoxEx ll_CB_PeiZhong
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_CB_PeiZhong;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_CB_PeiZhong_DropDown;
			if (_ll_CB_PeiZhong != null)
			{
				((ComboBox)_ll_CB_PeiZhong).remove_DropDown(eventHandler);
			}
			_ll_CB_PeiZhong = value;
			if (_ll_CB_PeiZhong != null)
			{
				((ComboBox)_ll_CB_PeiZhong).add_DropDown(eventHandler);
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

	internal virtual ComboBoxEx ll_CB_ZhiTuiKuaJu
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_CB_ZhiTuiKuaJu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_CB_ZhiTuiKuaJu_DropDown;
			if (_ll_CB_ZhiTuiKuaJu != null)
			{
				((ComboBox)_ll_CB_ZhiTuiKuaJu).remove_DropDown(eventHandler);
			}
			_ll_CB_ZhiTuiKuaJu = value;
			if (_ll_CB_ZhiTuiKuaJu != null)
			{
				((ComboBox)_ll_CB_ZhiTuiKuaJu).add_DropDown(eventHandler);
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

	internal virtual GroupPanel ll_frmfb
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_frmfb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_frmfb = value;
		}
	}

	internal virtual CheckBoxX ll_checkzbyx
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_checkzbyx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_checkzbyx_CheckedChanged;
			if (_ll_checkzbyx != null)
			{
				_ll_checkzbyx.remove_CheckedChanged(eventHandler);
			}
			_ll_checkzbyx = value;
			if (_ll_checkzbyx != null)
			{
				_ll_checkzbyx.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual LabelX ll_lbXT
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbXT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbXT = value;
		}
	}

	internal virtual ComboBoxEx ll_CB_FuBiFuBi
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_CB_FuBiFuBi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_CB_FuBiFuBi_SelectedIndexChanged;
			if (_ll_CB_FuBiFuBi != null)
			{
				((ComboBox)_ll_CB_FuBiFuBi).remove_SelectedIndexChanged(eventHandler);
			}
			_ll_CB_FuBiFuBi = value;
			if (_ll_CB_FuBiFuBi != null)
			{
				((ComboBox)_ll_CB_FuBiFuBi).add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual ComboBoxEx ll_CB_FuBiZBXT
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_CB_FuBiZBXT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_CB_FuBiZBXT_DropDown;
			if (_ll_CB_FuBiZBXT != null)
			{
				((ComboBox)_ll_CB_FuBiZBXT).remove_DropDown(eventHandler);
			}
			_ll_CB_FuBiZBXT = value;
			if (_ll_CB_FuBiZBXT != null)
			{
				((ComboBox)_ll_CB_FuBiZBXT).add_DropDown(eventHandler);
			}
		}
	}

	internal virtual ComboBoxEx ll_CB_FuBiZhuBi
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_CB_FuBiZhuBi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_CB_FuBiZhuBi_SelectedIndexChanged;
			if (_ll_CB_FuBiZhuBi != null)
			{
				((ComboBox)_ll_CB_FuBiZhuBi).remove_SelectedIndexChanged(eventHandler);
			}
			_ll_CB_FuBiZhuBi = value;
			if (_ll_CB_FuBiZhuBi != null)
			{
				((ComboBox)_ll_CB_FuBiZhuBi).add_SelectedIndexChanged(eventHandler);
			}
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

	internal virtual ListBox ll_lbxlslist
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbxlslist;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbxlslist = value;
		}
	}

	internal virtual ButtonX ll_btnshowxls
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnshowxls;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnshowxls_Click;
			if (_ll_btnshowxls != null)
			{
				((Control)_ll_btnshowxls).remove_Click(eventHandler);
			}
			_ll_btnshowxls = value;
			if (_ll_btnshowxls != null)
			{
				((Control)_ll_btnshowxls).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btn_Check
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btn_Check;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btn_Check_Click;
			if (_ll_btn_Check != null)
			{
				((Control)_ll_btn_Check).remove_Click(eventHandler);
			}
			_ll_btn_Check = value;
			if (_ll_btn_Check != null)
			{
				((Control)_ll_btn_Check).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btn_OutPut
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btn_OutPut;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btn_OutPut_Click;
			if (_ll_btn_OutPut != null)
			{
				((Control)_ll_btn_OutPut).remove_Click(eventHandler);
			}
			_ll_btn_OutPut = value;
			if (_ll_btn_OutPut != null)
			{
				((Control)_ll_btn_OutPut).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btn_Exit
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btn_Exit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btn_Exit_Click;
			if (_ll_btn_Exit != null)
			{
				((Control)_ll_btn_Exit).remove_Click(eventHandler);
			}
			_ll_btn_Exit = value;
			if (_ll_btn_Exit != null)
			{
				((Control)_ll_btn_Exit).add_Click(eventHandler);
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

	internal virtual ListBox ll_LB_ControlOpt
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_LB_ControlOpt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_LB_ControlOpt = value;
		}
	}

	internal virtual CheckBoxX cldisplay
	{
		[DebuggerNonUserCode]
		get
		{
			return _cldisplay;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cldisplay_CheckedChanged;
			if (_cldisplay != null)
			{
				_cldisplay.remove_CheckedChanged(eventHandler);
			}
			_cldisplay = value;
			if (_cldisplay != null)
			{
				_cldisplay.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual ButtonX liulan
	{
		[DebuggerNonUserCode]
		get
		{
			return _liulan;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = liulan_Click;
			if (_liulan != null)
			{
				((Control)_liulan).remove_Click(eventHandler);
			}
			_liulan = value;
			if (_liulan != null)
			{
				((Control)_liulan).add_Click(eventHandler);
			}
		}
	}

	internal virtual CheckBoxX ll_CheckQDflag
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_CheckQDflag;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_CheckQDflag = value;
		}
	}

	public virtual ListBox ll_LB_Results
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_LB_Results;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_LB_Results = value;
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
			_ButtonX1 = value;
		}
	}

	[DebuggerNonUserCode]
	public ll_ufxnbBrowser()
	{
		((Form)this).add_Load((EventHandler)ll_ufxnbBrowser_Load);
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
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_1638: Unknown result type (might be due to invalid IL or missing references)
		//IL_1642: Expected O, but got Unknown
		//IL_178d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1797: Expected O, but got Unknown
		ll_btnspecialxnlibs = new ButtonX();
		ll_txtxnlibspath = new TextBoxX();
		LabelX2 = new LabelX();
		ll_CB_JieGouXingShi = new ComboBoxEx();
		LabelX3 = new LabelX();
		ll_CB_PeiZhong = new ComboBoxEx();
		LabelX4 = new LabelX();
		ll_CB_ZhiTuiKuaJu = new ComboBoxEx();
		GroupPanel1 = new GroupPanel();
		ll_frmfb = new GroupPanel();
		ll_checkzbyx = new CheckBoxX();
		ll_lbXT = new LabelX();
		ll_CB_FuBiFuBi = new ComboBoxEx();
		ll_CB_FuBiZBXT = new ComboBoxEx();
		ll_CB_FuBiZhuBi = new ComboBoxEx();
		LabelX5 = new LabelX();
		LabelX6 = new LabelX();
		LabelX7 = new LabelX();
		LabelX8 = new LabelX();
		ll_lbxlslist = new ListBox();
		ll_btnshowxls = new ButtonX();
		ll_btn_Check = new ButtonX();
		ll_btn_OutPut = new ButtonX();
		ll_btn_Exit = new ButtonX();
		LabelX9 = new LabelX();
		ll_LB_Results = new ListBox();
		ll_LB_ControlOpt = new ListBox();
		cldisplay = new CheckBoxX();
		liulan = new ButtonX();
		ll_CheckQDflag = new CheckBoxX();
		ButtonX1 = new ButtonX();
		((Control)GroupPanel1).SuspendLayout();
		((Control)ll_frmfb).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)ll_btnspecialxnlibs).set_AccessibleRole((AccessibleRole)43);
		ll_btnspecialxnlibs.set_ColorTable((eButtonColor)3);
		ButtonX obj = ll_btnspecialxnlibs;
		Point location = new Point(3, 5);
		((Control)obj).set_Location(location);
		((Control)ll_btnspecialxnlibs).set_Name("ll_btnspecialxnlibs");
		ButtonX obj2 = ll_btnspecialxnlibs;
		Size size = new Size(143, 30);
		((Control)obj2).set_Size(size);
		((PopupItemControl)ll_btnspecialxnlibs).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnspecialxnlibs).set_TabIndex(0);
		ll_btnspecialxnlibs.set_Text("指定单项性能文件夹");
		ll_txtxnlibspath.get_Border().set_Class("TextBoxBorder");
		ll_txtxnlibspath.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj3 = ll_txtxnlibspath;
		location = new Point(3, 41);
		((Control)obj3).set_Location(location);
		((Control)ll_txtxnlibspath).set_Name("ll_txtxnlibspath");
		((TextBoxBase)ll_txtxnlibspath).set_ReadOnly(true);
		TextBoxX obj4 = ll_txtxnlibspath;
		size = new Size(626, 21);
		((Control)obj4).set_Size(size);
		((Control)ll_txtxnlibspath).set_TabIndex(1);
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX = LabelX2;
		location = new Point(12, 20);
		((Control)labelX).set_Location(location);
		((Control)LabelX2).set_Name("LabelX2");
		LabelX labelX2 = LabelX2;
		size = new Size(75, 23);
		((Control)labelX2).set_Size(size);
		((Control)LabelX2).set_TabIndex(2);
		LabelX2.set_Text("结构形式");
		((ListControl)ll_CB_JieGouXingShi).set_DisplayMember("Text");
		((ComboBox)ll_CB_JieGouXingShi).set_DrawMode((DrawMode)1);
		((ComboBox)ll_CB_JieGouXingShi).set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)ll_CB_JieGouXingShi).set_FormattingEnabled(true);
		((ComboBox)ll_CB_JieGouXingShi).set_ItemHeight(15);
		ComboBoxEx obj5 = ll_CB_JieGouXingShi;
		location = new Point(98, 20);
		((Control)obj5).set_Location(location);
		((Control)ll_CB_JieGouXingShi).set_Name("ll_CB_JieGouXingShi");
		ComboBoxEx obj6 = ll_CB_JieGouXingShi;
		size = new Size(199, 21);
		((Control)obj6).set_Size(size);
		ll_CB_JieGouXingShi.set_Style((eDotNetBarStyle)7);
		((Control)ll_CB_JieGouXingShi).set_TabIndex(3);
		((BaseItemControl)LabelX3).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX3).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX3 = LabelX3;
		location = new Point(12, 49);
		((Control)labelX3).set_Location(location);
		((Control)LabelX3).set_Name("LabelX3");
		LabelX labelX4 = LabelX3;
		size = new Size(75, 23);
		((Control)labelX4).set_Size(size);
		((Control)LabelX3).set_TabIndex(2);
		LabelX3.set_Text("配重");
		((ListControl)ll_CB_PeiZhong).set_DisplayMember("Text");
		((ComboBox)ll_CB_PeiZhong).set_DrawMode((DrawMode)1);
		((ComboBox)ll_CB_PeiZhong).set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)ll_CB_PeiZhong).set_FormattingEnabled(true);
		((ComboBox)ll_CB_PeiZhong).set_ItemHeight(15);
		ComboBoxEx obj7 = ll_CB_PeiZhong;
		location = new Point(98, 49);
		((Control)obj7).set_Location(location);
		((Control)ll_CB_PeiZhong).set_Name("ll_CB_PeiZhong");
		ComboBoxEx obj8 = ll_CB_PeiZhong;
		size = new Size(199, 21);
		((Control)obj8).set_Size(size);
		ll_CB_PeiZhong.set_Style((eDotNetBarStyle)7);
		((Control)ll_CB_PeiZhong).set_TabIndex(3);
		((BaseItemControl)LabelX4).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX4).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX5 = LabelX4;
		location = new Point(12, 78);
		((Control)labelX5).set_Location(location);
		((Control)LabelX4).set_Name("LabelX4");
		LabelX labelX6 = LabelX4;
		size = new Size(75, 23);
		((Control)labelX6).set_Size(size);
		((Control)LabelX4).set_TabIndex(2);
		LabelX4.set_Text("支腿跨距");
		((ListControl)ll_CB_ZhiTuiKuaJu).set_DisplayMember("Text");
		((ComboBox)ll_CB_ZhiTuiKuaJu).set_DrawMode((DrawMode)1);
		((ComboBox)ll_CB_ZhiTuiKuaJu).set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)ll_CB_ZhiTuiKuaJu).set_FormattingEnabled(true);
		((ComboBox)ll_CB_ZhiTuiKuaJu).set_ItemHeight(15);
		ComboBoxEx obj9 = ll_CB_ZhiTuiKuaJu;
		location = new Point(98, 78);
		((Control)obj9).set_Location(location);
		((Control)ll_CB_ZhiTuiKuaJu).set_Name("ll_CB_ZhiTuiKuaJu");
		ComboBoxEx obj10 = ll_CB_ZhiTuiKuaJu;
		size = new Size(199, 21);
		((Control)obj10).set_Size(size);
		ll_CB_ZhiTuiKuaJu.set_Style((eDotNetBarStyle)7);
		((Control)ll_CB_ZhiTuiKuaJu).set_TabIndex(3);
		((PanelControl)GroupPanel1).set_CanvasColor(SystemColors.Control);
		((PanelControl)GroupPanel1).set_ColorSchemeStyle((eDotNetBarStyle)4);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)ButtonX1);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)LabelX2);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)ll_CB_ZhiTuiKuaJu);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)ll_CB_JieGouXingShi);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)ll_CB_PeiZhong);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)LabelX3);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)LabelX4);
		GroupPanel groupPanel = GroupPanel1;
		location = new Point(3, 68);
		((Control)groupPanel).set_Location(location);
		((Control)GroupPanel1).set_Name("GroupPanel1");
		GroupPanel groupPanel2 = GroupPanel1;
		size = new Size(310, 165);
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
		((Control)GroupPanel1).set_TabIndex(4);
		((PanelControl)GroupPanel1).set_Text("基本配置选项");
		((PanelControl)ll_frmfb).set_CanvasColor(SystemColors.Control);
		((PanelControl)ll_frmfb).set_ColorSchemeStyle((eDotNetBarStyle)4);
		((Control)ll_frmfb).get_Controls().Add((Control)(object)ll_checkzbyx);
		((Control)ll_frmfb).get_Controls().Add((Control)(object)ll_lbXT);
		((Control)ll_frmfb).get_Controls().Add((Control)(object)ll_CB_FuBiFuBi);
		((Control)ll_frmfb).get_Controls().Add((Control)(object)ll_CB_FuBiZBXT);
		((Control)ll_frmfb).get_Controls().Add((Control)(object)ll_CB_FuBiZhuBi);
		((Control)ll_frmfb).get_Controls().Add((Control)(object)LabelX5);
		((Control)ll_frmfb).get_Controls().Add((Control)(object)LabelX6);
		GroupPanel obj11 = ll_frmfb;
		location = new Point(319, 68);
		((Control)obj11).set_Location(location);
		((Control)ll_frmfb).set_Name("ll_frmfb");
		GroupPanel obj12 = ll_frmfb;
		size = new Size(310, 166);
		((Control)obj12).set_Size(size);
		((PanelControl)ll_frmfb).get_Style().set_BackColor2SchemePart((eColorSchemePart)52);
		((PanelControl)ll_frmfb).get_Style().set_BackColorGradientAngle(90);
		((PanelControl)ll_frmfb).get_Style().set_BackColorSchemePart((eColorSchemePart)51);
		((PanelControl)ll_frmfb).get_Style().set_BorderBottom((eStyleBorderType)1);
		((PanelControl)ll_frmfb).get_Style().set_BorderBottomWidth(1);
		((PanelControl)ll_frmfb).get_Style().set_BorderColorSchemePart((eColorSchemePart)53);
		((PanelControl)ll_frmfb).get_Style().set_BorderLeft((eStyleBorderType)1);
		((PanelControl)ll_frmfb).get_Style().set_BorderLeftWidth(1);
		((PanelControl)ll_frmfb).get_Style().set_BorderRight((eStyleBorderType)1);
		((PanelControl)ll_frmfb).get_Style().set_BorderRightWidth(1);
		((PanelControl)ll_frmfb).get_Style().set_BorderTop((eStyleBorderType)1);
		((PanelControl)ll_frmfb).get_Style().set_BorderTopWidth(1);
		((PanelControl)ll_frmfb).get_Style().set_Class("");
		((PanelControl)ll_frmfb).get_Style().set_CornerDiameter(4);
		((PanelControl)ll_frmfb).get_Style().set_CornerType((eCornerType)2);
		((PanelControl)ll_frmfb).get_Style().set_TextAlignment((eStyleTextAlignment)1);
		((PanelControl)ll_frmfb).get_Style().set_TextColorSchemePart((eColorSchemePart)54);
		((PanelControl)ll_frmfb).get_Style().set_TextLineAlignment((eStyleTextAlignment)0);
		((PanelControl)ll_frmfb).get_StyleMouseDown().set_Class("");
		((PanelControl)ll_frmfb).get_StyleMouseDown().set_CornerType((eCornerType)1);
		((PanelControl)ll_frmfb).get_StyleMouseOver().set_Class("");
		((PanelControl)ll_frmfb).get_StyleMouseOver().set_CornerType((eCornerType)1);
		((Control)ll_frmfb).set_TabIndex(4);
		((PanelControl)ll_frmfb).set_Text("针对副臂结构的性能排序选项");
		((BaseItemControl)ll_checkzbyx).get_BackgroundStyle().set_Class("");
		((BaseItemControl)ll_checkzbyx).get_BackgroundStyle().set_CornerType((eCornerType)1);
		CheckBoxX obj13 = ll_checkzbyx;
		location = new Point(12, 47);
		((Control)obj13).set_Location(location);
		((Control)ll_checkzbyx).set_Name("ll_checkzbyx");
		CheckBoxX obj14 = ll_checkzbyx;
		size = new Size(106, 23);
		((Control)obj14).set_Size(size);
		((BaseItemControl)ll_checkzbyx).set_Style((eDotNetBarStyle)7);
		((Control)ll_checkzbyx).set_TabIndex(4);
		ll_checkzbyx.set_Text("主臂优先");
		((BaseItemControl)ll_lbXT).get_BackgroundStyle().set_Class("");
		((BaseItemControl)ll_lbXT).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX obj15 = ll_lbXT;
		location = new Point(12, 20);
		((Control)obj15).set_Location(location);
		((Control)ll_lbXT).set_Name("ll_lbXT");
		LabelX obj16 = ll_lbXT;
		size = new Size(106, 23);
		((Control)obj16).set_Size(size);
		((Control)ll_lbXT).set_TabIndex(2);
		ll_lbXT.set_Text("主臂仰角列表");
		((ListControl)ll_CB_FuBiFuBi).set_DisplayMember("Text");
		((ComboBox)ll_CB_FuBiFuBi).set_DrawMode((DrawMode)1);
		((ComboBox)ll_CB_FuBiFuBi).set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)ll_CB_FuBiFuBi).set_FormattingEnabled(true);
		((ComboBox)ll_CB_FuBiFuBi).set_ItemHeight(15);
		ComboBoxEx obj17 = ll_CB_FuBiFuBi;
		location = new Point(124, 103);
		((Control)obj17).set_Location(location);
		((Control)ll_CB_FuBiFuBi).set_Name("ll_CB_FuBiFuBi");
		ComboBoxEx obj18 = ll_CB_FuBiFuBi;
		size = new Size(173, 21);
		((Control)obj18).set_Size(size);
		ll_CB_FuBiFuBi.set_Style((eDotNetBarStyle)7);
		((Control)ll_CB_FuBiFuBi).set_TabIndex(3);
		((ListControl)ll_CB_FuBiZBXT).set_DisplayMember("Text");
		((ComboBox)ll_CB_FuBiZBXT).set_DrawMode((DrawMode)1);
		((ComboBox)ll_CB_FuBiZBXT).set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)ll_CB_FuBiZBXT).set_FormattingEnabled(true);
		((ComboBox)ll_CB_FuBiZBXT).set_ItemHeight(15);
		ComboBoxEx obj19 = ll_CB_FuBiZBXT;
		location = new Point(124, 20);
		((Control)obj19).set_Location(location);
		((Control)ll_CB_FuBiZBXT).set_Name("ll_CB_FuBiZBXT");
		ComboBoxEx obj20 = ll_CB_FuBiZBXT;
		size = new Size(173, 21);
		((Control)obj20).set_Size(size);
		ll_CB_FuBiZBXT.set_Style((eDotNetBarStyle)7);
		((Control)ll_CB_FuBiZBXT).set_TabIndex(3);
		((ListControl)ll_CB_FuBiZhuBi).set_DisplayMember("Text");
		((ComboBox)ll_CB_FuBiZhuBi).set_DrawMode((DrawMode)1);
		((ComboBox)ll_CB_FuBiZhuBi).set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)ll_CB_FuBiZhuBi).set_FormattingEnabled(true);
		((ComboBox)ll_CB_FuBiZhuBi).set_ItemHeight(15);
		ComboBoxEx obj21 = ll_CB_FuBiZhuBi;
		location = new Point(124, 74);
		((Control)obj21).set_Location(location);
		((Control)ll_CB_FuBiZhuBi).set_Name("ll_CB_FuBiZhuBi");
		ComboBoxEx obj22 = ll_CB_FuBiZhuBi;
		size = new Size(173, 21);
		((Control)obj22).set_Size(size);
		ll_CB_FuBiZhuBi.set_Style((eDotNetBarStyle)7);
		((Control)ll_CB_FuBiZhuBi).set_TabIndex(3);
		((BaseItemControl)LabelX5).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX5).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX7 = LabelX5;
		location = new Point(12, 74);
		((Control)labelX7).set_Location(location);
		((Control)LabelX5).set_Name("LabelX5");
		LabelX labelX8 = LabelX5;
		size = new Size(106, 23);
		((Control)labelX8).set_Size(size);
		((Control)LabelX5).set_TabIndex(2);
		LabelX5.set_Text("主臂长度列表");
		((BaseItemControl)LabelX6).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX6).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX9 = LabelX6;
		location = new Point(12, 103);
		((Control)labelX9).set_Location(location);
		((Control)LabelX6).set_Name("LabelX6");
		LabelX labelX10 = LabelX6;
		size = new Size(106, 23);
		((Control)labelX10).set_Size(size);
		((Control)LabelX6).set_TabIndex(2);
		LabelX6.set_Text("副臂长度列表");
		((BaseItemControl)LabelX7).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX7).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX11 = LabelX7;
		location = new Point(655, 68);
		((Control)labelX11).set_Location(location);
		((Control)LabelX7).set_Name("LabelX7");
		LabelX labelX12 = LabelX7;
		size = new Size(87, 23);
		((Control)labelX12).set_Size(size);
		((Control)LabelX7).set_TabIndex(2);
		LabelX7.set_Text("控制准则选项");
		((BaseItemControl)LabelX8).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX8).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX13 = LabelX8;
		location = new Point(3, 250);
		((Control)labelX13).set_Location(location);
		((Control)LabelX8).set_Name("LabelX8");
		LabelX labelX14 = LabelX8;
		size = new Size(188, 17);
		((Control)labelX14).set_Size(size);
		((Control)LabelX8).set_TabIndex(2);
		LabelX8.set_Text("当前选项下合法的单项性能表");
		((ListControl)ll_lbxlslist).set_FormattingEnabled(true);
		ll_lbxlslist.set_ItemHeight(12);
		ListBox obj23 = ll_lbxlslist;
		location = new Point(3, 268);
		((Control)obj23).set_Location(location);
		((Control)ll_lbxlslist).set_Name("ll_lbxlslist");
		ListBox obj24 = ll_lbxlslist;
		size = new Size(752, 64);
		((Control)obj24).set_Size(size);
		((Control)ll_lbxlslist).set_TabIndex(5);
		((Control)ll_btnshowxls).set_AccessibleRole((AccessibleRole)43);
		ll_btnshowxls.set_ColorTable((eButtonColor)3);
		ButtonX obj25 = ll_btnshowxls;
		location = new Point(16, 347);
		((Control)obj25).set_Location(location);
		((Control)ll_btnshowxls).set_Name("ll_btnshowxls");
		ButtonX obj26 = ll_btnshowxls;
		size = new Size(143, 30);
		((Control)obj26).set_Size(size);
		((PopupItemControl)ll_btnshowxls).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnshowxls).set_TabIndex(6);
		ll_btnshowxls.set_Text("显示合法的性能表");
		((Control)ll_btn_Check).set_AccessibleRole((AccessibleRole)43);
		ll_btn_Check.set_ColorTable((eButtonColor)3);
		ButtonX obj27 = ll_btn_Check;
		location = new Point(208, 347);
		((Control)obj27).set_Location(location);
		((Control)ll_btn_Check).set_Name("ll_btn_Check");
		ButtonX obj28 = ll_btn_Check;
		size = new Size(143, 30);
		((Control)obj28).set_Size(size);
		((PopupItemControl)ll_btn_Check).set_Style((eDotNetBarStyle)7);
		((Control)ll_btn_Check).set_TabIndex(6);
		ll_btn_Check.set_Text("验证当前配置.. .");
		((Control)ll_btn_OutPut).set_AccessibleRole((AccessibleRole)43);
		ll_btn_OutPut.set_ColorTable((eButtonColor)3);
		ButtonX obj29 = ll_btn_OutPut;
		location = new Point(400, 347);
		((Control)obj29).set_Location(location);
		((Control)ll_btn_OutPut).set_Name("ll_btn_OutPut");
		ButtonX obj30 = ll_btn_OutPut;
		size = new Size(143, 30);
		((Control)obj30).set_Size(size);
		((PopupItemControl)ll_btn_OutPut).set_Style((eDotNetBarStyle)7);
		((Control)ll_btn_OutPut).set_TabIndex(6);
		ll_btn_OutPut.set_Text("合成性能表.. .");
		((Control)ll_btn_Exit).set_AccessibleRole((AccessibleRole)43);
		ll_btn_Exit.set_ColorTable((eButtonColor)3);
		ll_btn_Exit.set_DialogResult((DialogResult)2);
		ButtonX obj31 = ll_btn_Exit;
		location = new Point(592, 347);
		((Control)obj31).set_Location(location);
		((Control)ll_btn_Exit).set_Name("ll_btn_Exit");
		ButtonX obj32 = ll_btn_Exit;
		size = new Size(143, 30);
		((Control)obj32).set_Size(size);
		((PopupItemControl)ll_btn_Exit).set_Style((eDotNetBarStyle)7);
		((Control)ll_btn_Exit).set_TabIndex(6);
		ll_btn_Exit.set_Text("关闭");
		((BaseItemControl)LabelX9).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX9).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX15 = LabelX9;
		location = new Point(3, 405);
		((Control)labelX15).set_Location(location);
		((Control)LabelX9).set_Name("LabelX9");
		LabelX labelX16 = LabelX9;
		size = new Size(156, 17);
		((Control)labelX16).set_Size(size);
		((Control)LabelX9).set_TabIndex(2);
		LabelX9.set_Text("当前选项下合成的性能表");
		((ListControl)ll_LB_Results).set_FormattingEnabled(true);
		ll_LB_Results.set_ItemHeight(12);
		ListBox obj33 = ll_LB_Results;
		location = new Point(3, 422);
		((Control)obj33).set_Location(location);
		((Control)ll_LB_Results).set_Name("ll_LB_Results");
		ListBox obj34 = ll_LB_Results;
		size = new Size(752, 136);
		((Control)obj34).set_Size(size);
		((Control)ll_LB_Results).set_TabIndex(5);
		((ListControl)ll_LB_ControlOpt).set_FormattingEnabled(true);
		ll_LB_ControlOpt.set_ItemHeight(12);
		ListBox obj35 = ll_LB_ControlOpt;
		location = new Point(635, 96);
		((Control)obj35).set_Location(location);
		((Control)ll_LB_ControlOpt).set_Name("ll_LB_ControlOpt");
		ll_LB_ControlOpt.set_SelectionMode((SelectionMode)2);
		ListBox obj36 = ll_LB_ControlOpt;
		size = new Size(120, 136);
		((Control)obj36).set_Size(size);
		((Control)ll_LB_ControlOpt).set_TabIndex(8);
		((BaseItemControl)cldisplay).get_BackgroundStyle().set_Class("");
		((BaseItemControl)cldisplay).get_BackgroundStyle().set_CornerType((eCornerType)1);
		CheckBoxX obj37 = cldisplay;
		location = new Point(3, 564);
		((Control)obj37).set_Location(location);
		((Control)cldisplay).set_Name("cldisplay");
		CheckBoxX obj38 = cldisplay;
		size = new Size(115, 23);
		((Control)obj38).set_Size(size);
		((BaseItemControl)cldisplay).set_Style((eDotNetBarStyle)7);
		((Control)cldisplay).set_TabIndex(7);
		cldisplay.set_Text("处理过程可见");
		((Control)liulan).set_AccessibleRole((AccessibleRole)43);
		liulan.set_ColorTable((eButtonColor)3);
		ButtonX obj39 = liulan;
		location = new Point(400, 383);
		((Control)obj39).set_Location(location);
		((Control)liulan).set_Name("liulan");
		ButtonX obj40 = liulan;
		size = new Size(143, 30);
		((Control)obj40).set_Size(size);
		((PopupItemControl)liulan).set_Style((eDotNetBarStyle)7);
		((Control)liulan).set_TabIndex(6);
		liulan.set_Text("浏览性能表文件夹");
		((BaseItemControl)ll_CheckQDflag).get_BackgroundStyle().set_Class("");
		((BaseItemControl)ll_CheckQDflag).get_BackgroundStyle().set_CornerType((eCornerType)1);
		CheckBoxX obj41 = ll_CheckQDflag;
		location = new Point(208, 383);
		((Control)obj41).set_Location(location);
		((Control)ll_CheckQDflag).set_Name("ll_CheckQDflag");
		CheckBoxX obj42 = ll_CheckQDflag;
		size = new Size(186, 23);
		((Control)obj42).set_Size(size);
		((BaseItemControl)ll_CheckQDflag).set_Style((eDotNetBarStyle)7);
		((Control)ll_CheckQDflag).set_TabIndex(9);
		ll_CheckQDflag.set_Text("强度性能表经过了人工处理");
		((Control)ButtonX1).set_AccessibleRole((AccessibleRole)43);
		ButtonX1.set_ColorTable((eButtonColor)3);
		((Control)ButtonX1).set_Enabled(false);
		ButtonX buttonX = ButtonX1;
		location = new Point(98, 105);
		((Control)buttonX).set_Location(location);
		((Control)ButtonX1).set_Name("ButtonX1");
		ButtonX buttonX2 = ButtonX1;
		size = new Size(143, 30);
		((Control)buttonX2).set_Size(size);
		((PopupItemControl)ButtonX1).set_Style((eDotNetBarStyle)7);
		((Control)ButtonX1).set_TabIndex(10);
		ButtonX1.set_Text("生成索引文件");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_CancelButton((IButtonControl)(object)ll_btn_Exit);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		size = new Size(758, 591);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)ll_CheckQDflag);
		((Control)this).get_Controls().Add((Control)(object)ll_LB_ControlOpt);
		((Control)this).get_Controls().Add((Control)(object)cldisplay);
		((Control)this).get_Controls().Add((Control)(object)ll_btn_Exit);
		((Control)this).get_Controls().Add((Control)(object)liulan);
		((Control)this).get_Controls().Add((Control)(object)ll_btn_OutPut);
		((Control)this).get_Controls().Add((Control)(object)ll_btn_Check);
		((Control)this).get_Controls().Add((Control)(object)ll_btnshowxls);
		((Control)this).get_Controls().Add((Control)(object)ll_LB_Results);
		((Control)this).get_Controls().Add((Control)(object)ll_lbxlslist);
		((Control)this).get_Controls().Add((Control)(object)ll_frmfb);
		((Control)this).get_Controls().Add((Control)(object)LabelX7);
		((Control)this).get_Controls().Add((Control)(object)GroupPanel1);
		((Control)this).get_Controls().Add((Control)(object)ll_txtxnlibspath);
		((Control)this).get_Controls().Add((Control)(object)ll_btnspecialxnlibs);
		((Control)this).get_Controls().Add((Control)(object)LabelX9);
		((Control)this).get_Controls().Add((Control)(object)LabelX8);
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("ll_ufxnbBrowser");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("性能表浏览器...");
		((Control)GroupPanel1).ResumeLayout(false);
		((Control)ll_frmfb).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void ll_btnspecialxnlibs_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				FolderBrowserDialog val = new FolderBrowserDialog();
				val.set_Description("请指定单项性能表所在路径");
				((CommonDialog)val).ShowDialog();
				string selectedPath = val.get_SelectedPath();
				if (Operators.CompareString(selectedPath, "", false) == 0)
				{
					return;
				}
				string text = selectedPath;
				ll_CB_JieGouXingShi.get_Items().Clear();
				ll_CB_PeiZhong.get_Items().Clear();
				ll_CB_ZhiTuiKuaJu.get_Items().Clear();
				ll_lbxlslist.get_Items().Clear();
				ll_CB_FuBiZBXT.get_Items().Clear();
				ll_CB_FuBiZhuBi.get_Items().Clear();
				ll_CB_FuBiFuBi.get_Items().Clear();
				if (Operators.CompareString(Strings.Trim(text), "", false) != 0)
				{
					int num = Strings.InStrRev(text, "\\", -1, (CompareMethod)0);
					string text2 = Strings.Right(text, Strings.Len(text) - num);
					switch (Strings.Trim(text2))
					{
					case "主臂":
					case "主臂+固定副臂":
					case "主臂+塔式副臂":
					case "主臂+超起":
					case "主臂+固定副臂+超起":
					case "主臂+塔式副臂+超起":
						text = Strings.Left(text, num - 1);
						Interaction.MsgBox((object)("当前选择的路径不合适,已自动更改为：" + text), (MsgBoxStyle)0, (object)null);
						break;
					}
					xnbbrowser.curxnlibs = text;
					((TextBox)ll_txtxnlibspath).set_Text(text);
					string path = xnbbrowser.curxnlibs + "\\结构形式.ini";
					Mod1.wr = new StreamWriter(path, append: false, Encoding.Default);
					bool flag = false;
					if (Directory.Exists(xnbbrowser.curxnlibs + "\\主臂"))
					{
						Mod1.wr.WriteLine("主臂");
						flag = true;
					}
					if (Directory.Exists(xnbbrowser.curxnlibs + "\\主臂+固定副臂"))
					{
						Mod1.wr.WriteLine("主臂+固定副臂");
						flag = true;
					}
					if (Directory.Exists(xnbbrowser.curxnlibs + "\\主臂+塔式副臂"))
					{
						Mod1.wr.WriteLine("主臂+塔式副臂");
						flag = true;
					}
					if (Directory.Exists(xnbbrowser.curxnlibs + "\\主臂+超起"))
					{
						Mod1.wr.WriteLine("主臂+超起");
						flag = true;
					}
					if (Directory.Exists(xnbbrowser.curxnlibs + "\\主臂+固定副臂+超起"))
					{
						Mod1.wr.WriteLine("主臂+固定副臂+超起");
						flag = true;
					}
					if (Directory.Exists(xnbbrowser.curxnlibs + "\\主臂+塔式副臂+超起"))
					{
						Mod1.wr.WriteLine("主臂+塔式副臂+超起");
						flag = true;
					}
					Mod1.wr.Close();
					Mod1.wr.Dispose();
					if (!flag)
					{
						((Control)ll_btnspecialxnlibs).set_ForeColor(Color.Red);
						return;
					}
					((Control)ll_btnspecialxnlibs).set_ForeColor(Color.Green);
					((Control)GroupPanel1).set_Enabled(true);
				}
				else
				{
					((Control)ll_btnspecialxnlibs).set_ForeColor(Color.Red);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)64, (object)"提示");
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ll_CB_JieGouXingShi_SelectedIndexChanged(object sender, EventArgs e)
	{
		curJieGouXingShiChange = true;
		((Control)ll_frmfb).set_Enabled(false);
		int num = Strings.InStr(1, ((ComboBox)ll_CB_JieGouXingShi).get_Text(), "塔式副臂", (CompareMethod)0);
		if (num > 0)
		{
			ll_lbXT.set_Text("主臂仰角列表");
			strLBXT = "主臂仰角";
			((Control)ll_frmfb).set_Enabled(true);
		}
		num = Strings.InStr(1, ((ComboBox)ll_CB_JieGouXingShi).get_Text(), "固定副臂", (CompareMethod)0);
		if (num > 0)
		{
			ll_lbXT.set_Text("副臂安装角列表");
			strLBXT = "副臂安装角";
			((Control)ll_frmfb).set_Enabled(true);
		}
		ll_CB_PeiZhong_DropDown(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void ll_checkzbyx_CheckedChanged(object sender, EventArgs e)
	{
		if (ll_checkzbyx.get_Checked())
		{
			((ComboBox)ll_CB_FuBiZhuBi).set_ForeColor(Color.Green);
			((ComboBox)ll_CB_FuBiFuBi).set_ForeColor(Color.Gray);
			((Control)ll_CB_FuBiZhuBi).set_Enabled(true);
			((Control)ll_CB_FuBiFuBi).set_Enabled(false);
		}
		else
		{
			((Control)ll_CB_FuBiZhuBi).set_Enabled(false);
			((Control)ll_CB_FuBiFuBi).set_Enabled(true);
			((ComboBox)ll_CB_FuBiFuBi).set_ForeColor(Color.Green);
			((ComboBox)ll_CB_FuBiZhuBi).set_ForeColor(Color.Gray);
		}
	}

	private void ll_CB_FuBiZhuBi_SelectedIndexChanged(object sender, EventArgs e)
	{
		ll_CB_PeiZhong_DropDown(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void ll_CB_FuBiFuBi_SelectedIndexChanged(object sender, EventArgs e)
	{
		ll_CB_PeiZhong_DropDown(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void ll_ufxnbBrowser_Load(object sender, EventArgs e)
	{
		((Control)ll_btn_OutPut).set_Enabled(false);
		dbOpen = true;
		if (((Control)ll_btnspecialxnlibs).get_ForeColor() == Color.Green)
		{
			((Control)GroupPanel1).set_Enabled(true);
		}
		else
		{
			((Control)GroupPanel1).set_Enabled(false);
		}
		((Control)ll_frmfb).set_Enabled(false);
		int num = Strings.InStr(1, ((ComboBox)ll_CB_JieGouXingShi).get_Text(), "塔式副臂", (CompareMethod)0);
		if (num > 0)
		{
			ll_lbXT.set_Text("主臂仰角列表");
			strLBXT = "主臂仰角";
			((Control)ll_frmfb).set_Enabled(true);
		}
		num = Strings.InStr(1, ((ComboBox)ll_CB_JieGouXingShi).get_Text(), "固定副臂", (CompareMethod)0);
		if (num > 0)
		{
			ll_lbXT.set_Text("副臂安装角列表");
			strLBXT = "副臂安装角";
			((Control)ll_frmfb).set_Enabled(true);
		}
		((Control)ll_CB_FuBiZhuBi).set_Enabled(false);
		((Control)ll_CB_FuBiFuBi).set_Enabled(true);
		((ComboBox)ll_CB_FuBiFuBi).set_ForeColor(Color.Green);
		((ComboBox)ll_CB_FuBiZhuBi).set_ForeColor(Color.Gray);
		ll_LB_ControlOpt.get_Items().Clear();
		ll_LB_Results.get_Items().Clear();
		string path = Application.get_StartupPath() + "\\config\\控制准则.ini";
		if (!File.Exists(path))
		{
			return;
		}
		int num2 = 0;
		Mod1.lr = new StreamReader(path, Encoding.Default);
		string text = "";
		checked
		{
			while (!Information.IsNothing((object)text))
			{
				text = Mod1.lr.ReadLine();
				if (Information.IsNothing((object)text))
				{
					break;
				}
				if (Operators.CompareString(text, "", false) != 0)
				{
					num2++;
				}
			}
			Mod1.lr.Close();
			Mod1.lr.Dispose();
			string[] array = new string[num2 - 1 + 1];
			num2 = 0;
			Mod1.lr = new StreamReader(path, Encoding.Default);
			text = "";
			while (!Information.IsNothing((object)text))
			{
				text = Mod1.lr.ReadLine();
				if (Operators.CompareString(text, "", false) != 0)
				{
					array[num2] = text;
					num2++;
				}
			}
			Mod1.lr.Close();
			Mod1.lr.Dispose();
			int num3 = Information.UBound((Array)array, 1);
			for (num2 = 0; num2 <= num3; num2++)
			{
				string text2 = array[num2];
				ll_LB_ControlOpt.get_Items().Add((object)text2);
			}
		}
	}

	private void ll_btn_Exit_Click(object sender, EventArgs e)
	{
		checked
		{
			if (ll_LB_Results.get_Items().get_Count() != 0)
			{
				int num = ll_LB_Results.get_Items().get_Count() - 1;
				for (int i = 0; i <= num; i++)
				{
					MyProject.Forms.Main.lslog.get_Items().Add(RuntimeHelpers.GetObjectValue(ll_LB_Results.get_Items().get_Item(i)));
				}
			}
			MyProject.Forms.Main.lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员关闭了 ANSYS11.0 性能表浏览器 对话框"));
			((Form)this).Close();
		}
	}

	private void ll_btnshowxls_Click(object sender, EventArgs e)
	{
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		string text = default(string);
		string text2 = default(string);
		string path;
		if (!bfb)
		{
			path = xnbbrowser.curxnlibs + "\\" + ((ComboBox)ll_CB_JieGouXingShi).get_Text();
		}
		else
		{
			text = "副臂优先";
			if (ll_checkzbyx.get_Checked())
			{
				text = "主臂优先";
			}
			if (!((ll_CB_FuBiZBXT.get_Items().get_Count() != 0) & (((ComboBox)ll_CB_FuBiZBXT).get_SelectedIndex() != -1)))
			{
				Interaction.MsgBox((object)"当前角度不合法,请重新选择.", (MsgBoxStyle)0, (object)"提示");
				return;
			}
			text2 = ((ComboBox)ll_CB_FuBiZBXT).get_Text();
			path = xnbbrowser.curxnlibs + "\\" + ((ComboBox)ll_CB_JieGouXingShi).get_Text() + "\\" + text + "\\" + text2;
		}
		ll_lbxlslist.get_Items().Clear();
		checked
		{
			if (Operators.CompareString(Strings.UCase(text2), "ALL", false) == 0)
			{
				int num = ll_CB_FuBiZBXT.get_Items().get_Count() - 2;
				for (int i = 0; i <= num; i++)
				{
					text2 = Conversions.ToString(ll_CB_FuBiZBXT.get_Items().get_Item(i));
					path = xnbbrowser.curxnlibs + "\\" + ((ComboBox)ll_CB_JieGouXingShi).get_Text() + "\\" + text + "\\" + text2;
					if (Directory.Exists(path))
					{
						string[] files = Directory.GetFiles(path, "*.xls", SearchOption.TopDirectoryOnly);
						int num2 = files.Count() - 1;
						for (int j = 0; j <= num2; j++)
						{
							string text3 = files[j];
							Strings.Split(text3, "\\", -1, (CompareMethod)0);
							ll_lbxlslist.get_Items().Add((object)text3);
						}
					}
				}
			}
			else if (Directory.Exists(path))
			{
				string[] files = Directory.GetFiles(path, "*.xls", SearchOption.TopDirectoryOnly);
				int num3 = files.Count() - 1;
				for (int k = 0; k <= num3; k++)
				{
					string text3 = files[k];
					Strings.Split(text3, "\\", -1, (CompareMethod)0);
					ll_lbxlslist.get_Items().Add((object)text3);
				}
			}
		}
	}

	private void ll_btn_Check_Click(object sender, EventArgs e)
	{
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca8: Unknown result type (might be due to invalid IL or missing references)
		//IL_135d: Unknown result type (might be due to invalid IL or missing references)
		JieGouXingShi = ((ComboBox)ll_CB_JieGouXingShi).get_Text();
		PeiZhong = ((ComboBox)ll_CB_PeiZhong).get_Text();
		ZhiTuiKuaJu = ((ComboBox)ll_CB_ZhiTuiKuaJu).get_Text();
		FuBiZBXT = ((ComboBox)ll_CB_FuBiZBXT).get_Text();
		FuBiZhuBi = ((ComboBox)ll_CB_FuBiZhuBi).get_Text();
		FuBiFuBi = ((ComboBox)ll_CB_FuBiFuBi).get_Text();
		blnFuBiZhuBi = ll_checkzbyx.get_Checked();
		int num = 0;
		ControlOpt = "";
		ControlOpti = "";
		ControlList = "";
		checked
		{
			int num2 = ll_LB_ControlOpt.get_Items().get_Count() - 1;
			for (int i = 0; i <= num2; i++)
			{
				if (ll_LB_ControlOpt.GetSelected(i))
				{
					string text = ControlOpt + "第";
					ObjectCollection items = ll_LB_ControlOpt.get_Items();
					ObjectCollection obj = items;
					int num3 = i;
					string str = Conversions.ToString(obj.get_Item(num3));
					object obj2 = conlist0(ref str);
					items.set_Item(num3, (object)str);
					ControlOpt = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)text, obj2), (object)"项. "), ll_LB_ControlOpt.get_Items().get_Item(i)), (object)"\r\n"));
					string controlOpti = ControlOpti;
					items = ll_LB_ControlOpt.get_Items();
					ObjectCollection obj3 = items;
					num3 = i;
					str = Conversions.ToString(obj3.get_Item(num3));
					object obj4 = conlist0(ref str);
					items.set_Item(num3, (object)str);
					ControlOpti = Conversions.ToString(Operators.ConcatenateObject((object)controlOpti, obj4));
					if (num == 0)
					{
						ControlList = Conversions.ToString(ll_LB_ControlOpt.get_Items().get_Item(i));
					}
					else
					{
						ControlList = Conversions.ToString(Operators.ConcatenateObject((object)(ControlList + ","), ll_LB_ControlOpt.get_Items().get_Item(i)));
					}
					num++;
				}
			}
			int num4 = num;
			string text2 = "验证通过.. .";
			curDataCheckOK = true;
			if (ll_CheckQDflag.get_Checked())
			{
				int num5 = Strings.InStr(1, ControlList, "强度", (CompareMethod)0);
				if (num5 != 1)
				{
					Interaction.MsgBox((object)"控制准则中应包括强度准则,因为用户选择了[强度性能表经过了人工处理]选项.", (MsgBoxStyle)0, (object)"提示");
					text2 = "?? ?当前配置不完整";
					curDataCheckOK = false;
				}
			}
			if (((Control)ll_CB_PeiZhong).get_Enabled() | (Operators.CompareString(((ComboBox)ll_CB_PeiZhong).get_Text(), "", false) != 0))
			{
				curPZDataCheckOK = true;
				if ((Operators.CompareString(JieGouXingShi, "", false) == 0) | (Operators.CompareString(PeiZhong, "", false) == 0) | (Operators.CompareString(ZhiTuiKuaJu, "", false) == 0) | (Operators.CompareString(ControlOpt, "", false) == 0))
				{
					text2 = "?? ?当前配置不完整";
					curDataCheckOK = false;
				}
			}
			else
			{
				curPZDataCheckOK = false;
			}
			xnbbrowser.filei = 1;
			if ((Operators.CompareString(JieGouXingShi, "主臂", false) == 0) | (Operators.CompareString(JieGouXingShi, "主臂+超起", false) == 0))
			{
				if (curDataCheckOK)
				{
					if (curPZDataCheckOK)
					{
						int num6 = ll_CB_PeiZhong.get_Items().get_Count() - 2;
						for (int j = 0; j <= num6; j++)
						{
							int num7 = ll_CB_ZhiTuiKuaJu.get_Items().get_Count() - 2;
							for (int k = 0; k <= num7; k++)
							{
								object obj5 = ((ComboBox)ll_CB_PeiZhong).get_Text();
								object obj6 = ((ComboBox)ll_CB_ZhiTuiKuaJu).get_Text();
								Type typeFromHandle = typeof(Strings);
								object[] array = new object[1] { RuntimeHelpers.GetObjectValue(obj5) };
								object[] array2 = array;
								bool[] array3 = new bool[1] { true };
								object obj7 = NewLateBinding.LateGet((object)null, typeFromHandle, "UCase", array2, (string[])null, (Type[])null, array3);
								if (array3[0])
								{
									obj5 = RuntimeHelpers.GetObjectValue(array[0]);
								}
								if (Operators.CompareString(Strings.Trim(Conversions.ToString(obj7)), "ALL", false) == 0)
								{
									obj5 = RuntimeHelpers.GetObjectValue(ll_CB_PeiZhong.get_Items().get_Item(j));
								}
								else
								{
									j = ll_CB_PeiZhong.get_Items().get_Count();
								}
								Type typeFromHandle2 = typeof(Strings);
								object[] array4 = new object[1] { RuntimeHelpers.GetObjectValue(obj6) };
								object[] array5 = array4;
								array3 = new bool[1] { true };
								object obj8 = NewLateBinding.LateGet((object)null, typeFromHandle2, "UCase", array5, (string[])null, (Type[])null, array3);
								if (array3[0])
								{
									obj6 = RuntimeHelpers.GetObjectValue(array4[0]);
								}
								if (Operators.CompareString(Strings.Trim(Conversions.ToString(obj8)), "ALL", false) == 0)
								{
									obj6 = RuntimeHelpers.GetObjectValue(ll_CB_ZhiTuiKuaJu.get_Items().get_Item(k));
								}
								else
								{
									k = ll_CB_ZhiTuiKuaJu.get_Items().get_Count();
								}
								if (!xnbbrowser.zbOutFiles(JieGouXingShi, Conversions.ToString(obj5), Conversions.ToString(obj6), ControlOpti, ControlList))
								{
									text2 = "?? ?当前配置不完整";
									curDataCheckOK = false;
								}
							}
						}
					}
					else
					{
						object obj5 = "ALL";
						object obj6 = "ALL";
						if (!xnbbrowser.zbOutFiles_all(JieGouXingShi, Conversions.ToString(obj5), Conversions.ToString(obj6), ControlOpti, ControlList))
						{
							text2 = "?? ?当前配置不完整";
							curDataCheckOK = false;
						}
					}
				}
				Interaction.MsgBox((object)("【结构形式】：" + JieGouXingShi + "\r\n【配重吨位】：" + PeiZhong + "\r\n【支腿跨距】：" + ZhiTuiKuaJu + "\r\n\r\n【控制准则】：\r\n" + ControlOpt + "当前选择了" + Conversions.ToString(num4) + "/" + Conversions.ToString(ll_LB_ControlOpt.get_Items().get_Count()) + "项控制准则."), (MsgBoxStyle)0, (object)text2);
			}
			else if (blnFuBiZhuBi)
			{
				if ((Operators.CompareString(FuBiZhuBi, "", false) == 0) | (Operators.CompareString(FuBiZBXT, "", false) == 0))
				{
					text2 = "?? ?当前配置不完整";
					curDataCheckOK = false;
				}
				if (curDataCheckOK)
				{
					string yxxx = "主臂优先";
					if (curPZDataCheckOK)
					{
						int num8 = ll_CB_PeiZhong.get_Items().get_Count() - 2;
						for (int l = 0; l <= num8; l++)
						{
							int num9 = ll_CB_ZhiTuiKuaJu.get_Items().get_Count() - 2;
							for (int m = 0; m <= num9; m++)
							{
								int num10 = ll_CB_FuBiZBXT.get_Items().get_Count() - 2;
								for (int n = 0; n <= num10; n++)
								{
									int num11 = ll_CB_FuBiZhuBi.get_Items().get_Count() - 2;
									Mod1.L = 0;
									while (Mod1.L <= num11)
									{
										object obj5 = ((ComboBox)ll_CB_PeiZhong).get_Text();
										object obj6 = ((ComboBox)ll_CB_ZhiTuiKuaJu).get_Text();
										object obj9 = ((ComboBox)ll_CB_FuBiZBXT).get_Text();
										object obj10 = ((ComboBox)ll_CB_FuBiZhuBi).get_Text();
										Type typeFromHandle3 = typeof(Strings);
										object[] array4 = new object[1] { RuntimeHelpers.GetObjectValue(obj5) };
										object[] array6 = array4;
										bool[] array3 = new bool[1] { true };
										object obj11 = NewLateBinding.LateGet((object)null, typeFromHandle3, "UCase", array6, (string[])null, (Type[])null, array3);
										if (array3[0])
										{
											obj5 = RuntimeHelpers.GetObjectValue(array4[0]);
										}
										if (Operators.CompareString(Strings.Trim(Conversions.ToString(obj11)), "ALL", false) == 0)
										{
											obj5 = RuntimeHelpers.GetObjectValue(ll_CB_PeiZhong.get_Items().get_Item(l));
										}
										else
										{
											l = ll_CB_PeiZhong.get_Items().get_Count();
										}
										Type typeFromHandle4 = typeof(Strings);
										array4 = new object[1] { RuntimeHelpers.GetObjectValue(obj6) };
										object[] array7 = array4;
										array3 = new bool[1] { true };
										object obj12 = NewLateBinding.LateGet((object)null, typeFromHandle4, "UCase", array7, (string[])null, (Type[])null, array3);
										if (array3[0])
										{
											obj6 = RuntimeHelpers.GetObjectValue(array4[0]);
										}
										if (Operators.CompareString(Strings.Trim(Conversions.ToString(obj12)), "ALL", false) == 0)
										{
											obj6 = RuntimeHelpers.GetObjectValue(ll_CB_ZhiTuiKuaJu.get_Items().get_Item(m));
										}
										else
										{
											m = ll_CB_ZhiTuiKuaJu.get_Items().get_Count();
										}
										Type typeFromHandle5 = typeof(Strings);
										array4 = new object[1] { RuntimeHelpers.GetObjectValue(obj9) };
										object[] array8 = array4;
										array3 = new bool[1] { true };
										object obj13 = NewLateBinding.LateGet((object)null, typeFromHandle5, "UCase", array8, (string[])null, (Type[])null, array3);
										if (array3[0])
										{
											obj9 = RuntimeHelpers.GetObjectValue(array4[0]);
										}
										if (Operators.CompareString(Strings.Trim(Conversions.ToString(obj13)), "ALL", false) == 0)
										{
											obj9 = RuntimeHelpers.GetObjectValue(ll_CB_FuBiZBXT.get_Items().get_Item(n));
										}
										else
										{
											n = ll_CB_FuBiZBXT.get_Items().get_Count();
										}
										Type typeFromHandle6 = typeof(Strings);
										array4 = new object[1] { RuntimeHelpers.GetObjectValue(obj10) };
										object[] array9 = array4;
										array3 = new bool[1] { true };
										object obj14 = NewLateBinding.LateGet((object)null, typeFromHandle6, "UCase", array9, (string[])null, (Type[])null, array3);
										if (array3[0])
										{
											obj10 = RuntimeHelpers.GetObjectValue(array4[0]);
										}
										if (Operators.CompareString(Strings.Trim(Conversions.ToString(obj14)), "ALL", false) == 0)
										{
											obj10 = RuntimeHelpers.GetObjectValue(ll_CB_FuBiZhuBi.get_Items().get_Item(Mod1.L));
										}
										else
										{
											Mod1.L = ll_CB_FuBiZhuBi.get_Items().get_Count();
										}
										if (!xnbbrowser.bffbOutFiles(JieGouXingShi, Conversions.ToString(obj5), Conversions.ToString(obj6), Conversions.ToString(obj9), yxxx, Conversions.ToString(obj10), ControlOpti, ControlList))
										{
											text2 = "?? ?当前配置不完整";
											curDataCheckOK = false;
										}
										Mod1.L++;
									}
								}
							}
						}
					}
					else
					{
						object obj5 = "ALL";
						object obj6 = "ALL";
						int num12 = ll_CB_FuBiZBXT.get_Items().get_Count() - 2;
						for (int num13 = 0; num13 <= num12; num13++)
						{
							int num14 = ll_CB_FuBiZhuBi.get_Items().get_Count() - 2;
							Mod1.L = 0;
							while (Mod1.L <= num14)
							{
								object obj9 = ((ComboBox)ll_CB_FuBiZBXT).get_Text();
								object obj10 = ((ComboBox)ll_CB_FuBiZhuBi).get_Text();
								Type typeFromHandle7 = typeof(Strings);
								object[] array4 = new object[1] { RuntimeHelpers.GetObjectValue(obj9) };
								object[] array10 = array4;
								bool[] array3 = new bool[1] { true };
								object obj15 = NewLateBinding.LateGet((object)null, typeFromHandle7, "UCase", array10, (string[])null, (Type[])null, array3);
								if (array3[0])
								{
									obj9 = RuntimeHelpers.GetObjectValue(array4[0]);
								}
								if (Operators.CompareString(Strings.Trim(Conversions.ToString(obj15)), "ALL", false) == 0)
								{
									obj9 = RuntimeHelpers.GetObjectValue(ll_CB_FuBiZBXT.get_Items().get_Item(num13));
								}
								else
								{
									num13 = ll_CB_FuBiZBXT.get_Items().get_Count();
								}
								Type typeFromHandle8 = typeof(Strings);
								array4 = new object[1] { RuntimeHelpers.GetObjectValue(obj10) };
								object[] array11 = array4;
								array3 = new bool[1] { true };
								object obj16 = NewLateBinding.LateGet((object)null, typeFromHandle8, "UCase", array11, (string[])null, (Type[])null, array3);
								if (array3[0])
								{
									obj10 = RuntimeHelpers.GetObjectValue(array4[0]);
								}
								if (Operators.CompareString(Strings.Trim(Conversions.ToString(obj16)), "ALL", false) == 0)
								{
									obj10 = RuntimeHelpers.GetObjectValue(ll_CB_FuBiZhuBi.get_Items().get_Item(Mod1.L));
								}
								else
								{
									Mod1.L = ll_CB_FuBiZhuBi.get_Items().get_Count();
								}
								if (!xnbbrowser.bffbOutFiles(JieGouXingShi, Conversions.ToString(obj5), Conversions.ToString(obj6), Conversions.ToString(obj9), yxxx, Conversions.ToString(obj10), ControlOpti, ControlList))
								{
									text2 = "?? ?当前配置不完整";
									curDataCheckOK = false;
								}
								Mod1.L++;
							}
						}
					}
				}
				Interaction.MsgBox((object)("【结构形式】：" + JieGouXingShi + "\r\n【" + strLBXT + "】：" + FuBiZBXT + "\r\n【优先排序】：主臂\r\n【主臂长度】：" + FuBiZhuBi + "\r\n【配重吨位】：" + PeiZhong + "\r\n【支腿跨距】：" + ZhiTuiKuaJu + "\r\n\r\n【控制准则】：\r\n" + ControlOpt + "当前选择了" + Conversions.ToString(num4) + "/" + Conversions.ToString(ll_LB_ControlOpt.get_Items().get_Count()) + "项控制准则."), (MsgBoxStyle)0, (object)text2);
			}
			else
			{
				if ((Operators.CompareString(FuBiFuBi, "", false) == 0) | (Operators.CompareString(FuBiZBXT, "", false) == 0))
				{
					text2 = "?? ?当前配置不完整";
					curDataCheckOK = false;
				}
				if (curDataCheckOK)
				{
					string yxxx = "副臂优先";
					if (curPZDataCheckOK)
					{
						int num15 = ll_CB_PeiZhong.get_Items().get_Count() - 2;
						for (int num16 = 0; num16 <= num15; num16++)
						{
							int num17 = ll_CB_ZhiTuiKuaJu.get_Items().get_Count() - 2;
							for (int num18 = 0; num18 <= num17; num18++)
							{
								int num19 = ll_CB_FuBiZBXT.get_Items().get_Count() - 2;
								for (int num20 = 0; num20 <= num19; num20++)
								{
									int num21 = ll_CB_FuBiFuBi.get_Items().get_Count() - 2;
									Mod1.L = 0;
									while (Mod1.L <= num21)
									{
										object obj5 = ((ComboBox)ll_CB_PeiZhong).get_Text();
										object obj6 = ((ComboBox)ll_CB_ZhiTuiKuaJu).get_Text();
										object obj9 = ((ComboBox)ll_CB_FuBiZBXT).get_Text();
										object obj10 = ((ComboBox)ll_CB_FuBiFuBi).get_Text();
										Type typeFromHandle9 = typeof(Strings);
										object[] array4 = new object[1] { RuntimeHelpers.GetObjectValue(obj5) };
										object[] array12 = array4;
										bool[] array3 = new bool[1] { true };
										object obj17 = NewLateBinding.LateGet((object)null, typeFromHandle9, "UCase", array12, (string[])null, (Type[])null, array3);
										if (array3[0])
										{
											obj5 = RuntimeHelpers.GetObjectValue(array4[0]);
										}
										if (Operators.CompareString(Strings.Trim(Conversions.ToString(obj17)), "ALL", false) == 0)
										{
											obj5 = RuntimeHelpers.GetObjectValue(ll_CB_PeiZhong.get_Items().get_Item(num16));
										}
										else
										{
											num16 = ll_CB_PeiZhong.get_Items().get_Count();
										}
										Type typeFromHandle10 = typeof(Strings);
										array4 = new object[1] { RuntimeHelpers.GetObjectValue(obj6) };
										object[] array13 = array4;
										array3 = new bool[1] { true };
										object obj18 = NewLateBinding.LateGet((object)null, typeFromHandle10, "UCase", array13, (string[])null, (Type[])null, array3);
										if (array3[0])
										{
											obj6 = RuntimeHelpers.GetObjectValue(array4[0]);
										}
										if (Operators.CompareString(Strings.Trim(Conversions.ToString(obj18)), "ALL", false) == 0)
										{
											obj6 = RuntimeHelpers.GetObjectValue(ll_CB_ZhiTuiKuaJu.get_Items().get_Item(num18));
										}
										else
										{
											num18 = ll_CB_ZhiTuiKuaJu.get_Items().get_Count();
										}
										Type typeFromHandle11 = typeof(Strings);
										array4 = new object[1] { RuntimeHelpers.GetObjectValue(obj9) };
										object[] array14 = array4;
										array3 = new bool[1] { true };
										object obj19 = NewLateBinding.LateGet((object)null, typeFromHandle11, "UCase", array14, (string[])null, (Type[])null, array3);
										if (array3[0])
										{
											obj9 = RuntimeHelpers.GetObjectValue(array4[0]);
										}
										if (Operators.CompareString(Strings.Trim(Conversions.ToString(obj19)), "ALL", false) == 0)
										{
											obj9 = RuntimeHelpers.GetObjectValue(ll_CB_FuBiZBXT.get_Items().get_Item(num20));
										}
										else
										{
											num20 = ll_CB_FuBiZBXT.get_Items().get_Count();
										}
										Type typeFromHandle12 = typeof(Strings);
										array4 = new object[1] { RuntimeHelpers.GetObjectValue(obj10) };
										object[] array15 = array4;
										array3 = new bool[1] { true };
										object obj20 = NewLateBinding.LateGet((object)null, typeFromHandle12, "UCase", array15, (string[])null, (Type[])null, array3);
										if (array3[0])
										{
											obj10 = RuntimeHelpers.GetObjectValue(array4[0]);
										}
										if (Operators.CompareString(Strings.Trim(Conversions.ToString(obj20)), "ALL", false) == 0)
										{
											obj10 = RuntimeHelpers.GetObjectValue(ll_CB_FuBiFuBi.get_Items().get_Item(Mod1.L));
										}
										else
										{
											Mod1.L = ll_CB_FuBiFuBi.get_Items().get_Count();
										}
										if (!xnbbrowser.bffbOutFiles(JieGouXingShi, Conversions.ToString(obj5), Conversions.ToString(obj6), Conversions.ToString(obj9), yxxx, Conversions.ToString(obj10), ControlOpti, ControlList))
										{
											text2 = "?? ?当前配置不完整";
											curDataCheckOK = false;
										}
										Mod1.L++;
									}
								}
							}
						}
					}
					else
					{
						object obj5 = "ALL";
						object obj6 = "ALL";
						int num22 = ll_CB_FuBiZBXT.get_Items().get_Count() - 2;
						for (int num23 = 0; num23 <= num22; num23++)
						{
							int num24 = ll_CB_FuBiFuBi.get_Items().get_Count() - 2;
							Mod1.L = 0;
							while (Mod1.L <= num24)
							{
								object obj9 = ((ComboBox)ll_CB_FuBiZBXT).get_Text();
								object obj10 = ((ComboBox)ll_CB_FuBiFuBi).get_Text();
								Type typeFromHandle13 = typeof(Strings);
								object[] array4 = new object[1] { RuntimeHelpers.GetObjectValue(obj9) };
								object[] array16 = array4;
								bool[] array3 = new bool[1] { true };
								object obj21 = NewLateBinding.LateGet((object)null, typeFromHandle13, "UCase", array16, (string[])null, (Type[])null, array3);
								if (array3[0])
								{
									obj9 = RuntimeHelpers.GetObjectValue(array4[0]);
								}
								if (Operators.CompareString(Strings.Trim(Conversions.ToString(obj21)), "ALL", false) == 0)
								{
									obj9 = RuntimeHelpers.GetObjectValue(ll_CB_FuBiZBXT.get_Items().get_Item(num23));
								}
								else
								{
									num23 = ll_CB_FuBiZBXT.get_Items().get_Count();
								}
								Type typeFromHandle14 = typeof(Strings);
								array4 = new object[1] { RuntimeHelpers.GetObjectValue(obj10) };
								object[] array17 = array4;
								array3 = new bool[1] { true };
								object obj22 = NewLateBinding.LateGet((object)null, typeFromHandle14, "UCase", array17, (string[])null, (Type[])null, array3);
								if (array3[0])
								{
									obj10 = RuntimeHelpers.GetObjectValue(array4[0]);
								}
								if (Operators.CompareString(Strings.Trim(Conversions.ToString(obj22)), "ALL", false) == 0)
								{
									obj10 = RuntimeHelpers.GetObjectValue(ll_CB_FuBiFuBi.get_Items().get_Item(Mod1.L));
								}
								else
								{
									Mod1.L = ll_CB_FuBiFuBi.get_Items().get_Count();
								}
								if (!xnbbrowser.bffbOutFiles(JieGouXingShi, Conversions.ToString(obj5), Conversions.ToString(obj6), Conversions.ToString(obj9), yxxx, Conversions.ToString(obj10), ControlOpti, ControlList))
								{
									text2 = "?? ?当前配置不完整";
									curDataCheckOK = false;
								}
								Mod1.L++;
							}
						}
					}
				}
				Interaction.MsgBox((object)("【结构形式】：" + JieGouXingShi + "\r\n【" + strLBXT + "】：" + FuBiZBXT + "\r\n【优先排序】：副臂\r\n【副臂长度】：" + FuBiFuBi + "\r\n【配重吨位】：" + PeiZhong + "\r\n【支腿跨距】：" + ZhiTuiKuaJu + "\r\n\r\n【控制准则】：\r\n" + ControlOpt + "当前选择了" + Conversions.ToString(num4) + "/" + Conversions.ToString(ll_LB_ControlOpt.get_Items().get_Count()) + "项控制准则."), (MsgBoxStyle)0, (object)text2);
			}
			((Control)ll_btn_OutPut).set_Enabled(curDataCheckOK);
		}
	}

	private void ll_btn_OutPut_Click(object sender, EventArgs e)
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		if (curDataCheckOK)
		{
			((Control)this).set_Cursor(Cursors.get_AppStarting());
			Color foreColor = ((Control)ll_btn_OutPut).get_ForeColor();
			((Control)ll_btn_OutPut).set_ForeColor(Color.Red);
			Mod1.excelapp.EnableCancelKey = XlEnableCancelKey.xlDisabled;
			((Control)ll_btn_Exit).set_Enabled(false);
			Mod1.QDflag = ll_CheckQDflag.get_Checked();
			if (!xnbbrowser.zbInFiles(ll_btn_OutPut, ll_LB_Results))
			{
				Interaction.MsgBox((object)"处理不完全，详情看temp.log!", (MsgBoxStyle)0, (object)"提示");
			}
			((Control)ll_btn_OutPut).set_Enabled(false);
			((Control)ll_btn_Exit).set_Enabled(true);
			((Control)ll_btn_OutPut).set_ForeColor(foreColor);
			((Control)this).set_Cursor(Cursors.get_Arrow());
		}
		else
		{
			Interaction.MsgBox((object)"当前性能配置数据不完整，点击【验证.. .】,查看不完整项.. .", (MsgBoxStyle)0, (object)"提示");
		}
	}

	private void ll_CB_PeiZhong_Click(object sender, EventArgs e)
	{
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (curJieGouXingShiChange & (ll_CB_JieGouXingShi.get_Items().get_Count() != 0))
			{
				ll_CB_PeiZhong.get_Items().Clear();
				ll_CB_ZhiTuiKuaJu.get_Items().Clear();
				ll_CB_FuBiZhuBi.get_Items().Clear();
				ll_CB_FuBiFuBi.get_Items().Clear();
				ll_CB_FuBiZBXT.get_Items().Clear();
				bhqz = true;
				bfb = false;
				string text = xnbbrowser.curxnlibs + "\\" + ((ComboBox)ll_CB_JieGouXingShi).get_Text() + "\\" + ((ComboBox)ll_CB_JieGouXingShi).get_Text() + ".ini";
				if (File.Exists(text))
				{
					Mod1.lr = new StreamReader(text, Encoding.Default);
					string text2 = "";
					while (!Information.IsNothing((object)text2))
					{
						text2 = Mod1.lr.ReadLine();
						if (Operators.CompareString(text2, "", false) == 0)
						{
							continue;
						}
						string[] array = Strings.Split(text2, "_", -1, (CompareMethod)0);
						if (Operators.CompareString(array[0], "配重", false) == 0)
						{
							string[] array2 = Strings.Split(array[1], ",", -1, (CompareMethod)0);
							if (Information.UBound((Array)array2, 1) < 1)
							{
								bhqz = false;
							}
							string[] array3 = array2;
							for (int i = 0; i < array3.Length; i++)
							{
								text2 = array3[i];
								ll_CB_PeiZhong.get_Items().Add((object)text2);
							}
						}
						if (Operators.CompareString(array[0], "支腿跨距", false) == 0)
						{
							string[] array2 = Strings.Split(array[1], ",", -1, (CompareMethod)0);
							if (Information.UBound((Array)array2, 1) < 1)
							{
								bhqz = false;
							}
							string[] array4 = array2;
							for (int j = 0; j < array4.Length; j++)
							{
								text2 = array4[j];
								ll_CB_ZhiTuiKuaJu.get_Items().Add((object)text2);
							}
						}
						if (Operators.CompareString(array[0], "副臂主臂长度列表", false) == 0)
						{
							bfb = true;
							string[] array2 = Strings.Split(array[1], ",", -1, (CompareMethod)0);
							string[] array5 = array2;
							for (int k = 0; k < array5.Length; k++)
							{
								text2 = array5[k];
								ll_CB_FuBiZhuBi.get_Items().Add((object)text2);
							}
						}
						if (Operators.CompareString(array[0], "副臂副臂长度列表", false) == 0)
						{
							bfb = true;
							string[] array2 = Strings.Split(array[1], ",", -1, (CompareMethod)0);
							string[] array6 = array2;
							for (int l = 0; l < array6.Length; l++)
							{
								text2 = array6[l];
								ll_CB_FuBiFuBi.get_Items().Add((object)text2);
							}
						}
						if (Operators.CompareString(array[0], "副臂主臂仰角列表", false) == 0)
						{
							bfb = true;
							string[] array2 = Strings.Split(array[1], ",", -1, (CompareMethod)0);
							string[] array7 = array2;
							for (int m = 0; m < array7.Length; m++)
							{
								text2 = array7[m];
								ll_CB_FuBiZBXT.get_Items().Add((object)text2);
							}
						}
						if (Operators.CompareString(array[0], "副臂主臂安装角列表", false) == 0)
						{
							bfb = true;
							string[] array2 = Strings.Split(array[1], ",", -1, (CompareMethod)0);
							string[] array8 = array2;
							for (int n = 0; n < array8.Length; n++)
							{
								text2 = array8[n];
								ll_CB_FuBiZBXT.get_Items().Add((object)text2);
							}
						}
					}
					Mod1.lr.Close();
					Mod1.lr.Dispose();
				}
				else
				{
					Interaction.MsgBox((object)("当前文件不存在,请仔细查看!" + text), (MsgBoxStyle)0, (object)"提示");
				}
				curJieGouXingShiChange = false;
			}
			if (bhqz)
			{
				((Control)ll_CB_PeiZhong).set_Enabled(true);
				((Control)ll_CB_ZhiTuiKuaJu).set_Enabled(true);
			}
			else
			{
				((Control)ll_CB_PeiZhong).set_Enabled(false);
				((Control)ll_CB_ZhiTuiKuaJu).set_Enabled(false);
			}
		}
	}

	public object conlist0(ref string str)
	{
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		switch (str)
		{
		case "强度":
			return 1;
		case "刚度":
			return 2;
		case "变幅缸":
			return 3;
		case "超起钢丝绳":
			return 4;
		case "回转支承":
			return 5;
		case "倾翻":
			return 6;
		case "支腿":
			return 7;
		default:
		{
			Interaction.MsgBox((object)"控制名字不正确！", (MsgBoxStyle)0, (object)null);
			object result = default(object);
			return result;
		}
		}
	}

	private void ll_CB_JieGouXingShi_StyleChanged(object sender, EventArgs e)
	{
	}

	private void ll_CB_JieGouXingShi_DropDown(object sender, EventArgs e)
	{
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		if (!((ll_CB_JieGouXingShi.get_Items().get_Count() == 0) | bnewpath))
		{
			return;
		}
		bhqz = true;
		bfb = false;
		ll_CB_JieGouXingShi.get_Items().Clear();
		string text = xnbbrowser.curxnlibs + "\\结构形式.ini";
		if (File.Exists(text))
		{
			Mod1.lr = new StreamReader(text, Encoding.Default);
			string text2 = "";
			while (!Information.IsNothing((object)text2))
			{
				text2 = Mod1.lr.ReadLine();
				if (Operators.CompareString(text2, "", false) != 0)
				{
					ll_CB_JieGouXingShi.get_Items().Add((object)text2);
				}
			}
			Mod1.lr.Close();
			Mod1.lr.Dispose();
			bnewpath = false;
		}
		else
		{
			Interaction.MsgBox((object)("当前文件不存在,请仔细查看!" + text), (MsgBoxStyle)0, (object)"提示");
		}
	}

	private void ll_CB_PeiZhong_DropDown(object sender, EventArgs e)
	{
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (curJieGouXingShiChange & (ll_CB_JieGouXingShi.get_Items().get_Count() != 0))
			{
				ll_CB_PeiZhong.get_Items().Clear();
				ll_CB_ZhiTuiKuaJu.get_Items().Clear();
				ll_CB_FuBiZhuBi.get_Items().Clear();
				ll_CB_FuBiFuBi.get_Items().Clear();
				ll_CB_FuBiZBXT.get_Items().Clear();
				bhqz = true;
				bfb = false;
				string text = xnbbrowser.curxnlibs + "\\" + ((ComboBox)ll_CB_JieGouXingShi).get_Text() + "\\" + ((ComboBox)ll_CB_JieGouXingShi).get_Text() + ".ini";
				if (File.Exists(text))
				{
					Mod1.lr = new StreamReader(text, Encoding.Default);
					string text2 = "";
					while (!Information.IsNothing((object)text2))
					{
						text2 = Mod1.lr.ReadLine();
						if (Operators.CompareString(text2, "", false) == 0)
						{
							continue;
						}
						string[] array = Strings.Split(text2, "_", -1, (CompareMethod)0);
						if (Operators.CompareString(array[0], "配重", false) == 0)
						{
							string[] array2 = Strings.Split(array[1], ",", -1, (CompareMethod)0);
							if (Information.UBound((Array)array2, 1) < 1)
							{
								bhqz = false;
							}
							string[] array3 = array2;
							for (int i = 0; i < array3.Length; i++)
							{
								text2 = array3[i];
								ll_CB_PeiZhong.get_Items().Add((object)text2);
							}
						}
						if (Operators.CompareString(array[0], "支腿跨距", false) == 0)
						{
							string[] array2 = Strings.Split(array[1], ",", -1, (CompareMethod)0);
							if (Information.UBound((Array)array2, 1) < 1)
							{
								bhqz = false;
							}
							string[] array4 = array2;
							for (int j = 0; j < array4.Length; j++)
							{
								text2 = array4[j];
								ll_CB_ZhiTuiKuaJu.get_Items().Add((object)text2);
							}
						}
						if (Operators.CompareString(array[0], "副臂主臂长度列表", false) == 0)
						{
							bfb = true;
							string[] array2 = Strings.Split(array[1], ",", -1, (CompareMethod)0);
							string[] array5 = array2;
							for (int k = 0; k < array5.Length; k++)
							{
								text2 = array5[k];
								ll_CB_FuBiZhuBi.get_Items().Add((object)text2);
							}
						}
						if (Operators.CompareString(array[0], "副臂副臂长度列表", false) == 0)
						{
							bfb = true;
							string[] array2 = Strings.Split(array[1], ",", -1, (CompareMethod)0);
							string[] array6 = array2;
							for (int l = 0; l < array6.Length; l++)
							{
								text2 = array6[l];
								ll_CB_FuBiFuBi.get_Items().Add((object)text2);
							}
						}
						if (Operators.CompareString(array[0], "副臂主臂仰角列表", false) == 0)
						{
							bfb = true;
							string[] array2 = Strings.Split(array[1], ",", -1, (CompareMethod)0);
							string[] array7 = array2;
							for (int m = 0; m < array7.Length; m++)
							{
								text2 = array7[m];
								ll_CB_FuBiZBXT.get_Items().Add((object)text2);
							}
						}
						if (Operators.CompareString(array[0], "副臂主臂安装角列表", false) == 0)
						{
							bfb = true;
							string[] array2 = Strings.Split(array[1], ",", -1, (CompareMethod)0);
							string[] array8 = array2;
							for (int n = 0; n < array8.Length; n++)
							{
								text2 = array8[n];
								ll_CB_FuBiZBXT.get_Items().Add((object)text2);
							}
						}
					}
					Mod1.lr.Close();
					Mod1.lr.Dispose();
				}
				else
				{
					Interaction.MsgBox((object)("当前文件不存在,请仔细查看!" + text), (MsgBoxStyle)0, (object)"提示");
				}
				curJieGouXingShiChange = false;
			}
			if (bhqz)
			{
				((Control)ll_CB_PeiZhong).set_Enabled(true);
				((Control)ll_CB_ZhiTuiKuaJu).set_Enabled(true);
			}
			else
			{
				((Control)ll_CB_PeiZhong).set_Enabled(false);
				((Control)ll_CB_ZhiTuiKuaJu).set_Enabled(false);
			}
		}
	}

	private void ll_CB_ZhiTuiKuaJu_DropDown(object sender, EventArgs e)
	{
		ll_CB_PeiZhong_DropDown(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void ll_CB_FuBiZBXT_DropDown(object sender, EventArgs e)
	{
		ll_CB_PeiZhong_DropDown(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void cldisplay_CheckedChanged(object sender, EventArgs e)
	{
		if (cldisplay.get_Checked())
		{
			Mod1.excelapp.Visible = true;
		}
		else
		{
			Mod1.excelapp.Visible = false;
		}
	}

	private void liulan_Click(object sender, EventArgs e)
	{
		if (Directory.Exists(xnbbrowser.curxnlibs + "\\Results"))
		{
			string fileName = xnbbrowser.curxnlibs + "\\Results\\";
			Process.Start(fileName);
		}
	}
}
