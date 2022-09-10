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
using xxx.My;

namespace xxx;

[DesignerGenerated]
public class fxdd : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("ll_lbleformat")]
	private LabelX _ll_lbleformat;

	[AccessedThroughProperty("ll_btnaddrow")]
	private ButtonX _ll_btnaddrow;

	[AccessedThroughProperty("ll_btninputtxt")]
	private ButtonX _ll_btninputtxt;

	[AccessedThroughProperty("ll_btnlooktxt")]
	private ButtonX _ll_btnlooktxt;

	[AccessedThroughProperty("btngb")]
	private ButtonX _btngb;

	[AccessedThroughProperty("ll_btnloadcaseremove")]
	private ButtonX _ll_btnloadcaseremove;

	[AccessedThroughProperty("ll_btnloadcaseclear")]
	private ButtonX _ll_btnloadcaseclear;

	[AccessedThroughProperty("ll_checkmsgbox")]
	private CheckBoxX _ll_checkmsgbox;

	[AccessedThroughProperty("ll_btnaz")]
	private ButtonX _ll_btnaz;

	[AccessedThroughProperty("ll_checkmselectctrlshift")]
	private CheckBoxX _ll_checkmselectctrlshift;

	[AccessedThroughProperty("ll_btncheckformat")]
	private ButtonX _ll_btncheckformat;

	[AccessedThroughProperty("ll_checkxh1")]
	private CheckBoxX _ll_checkxh1;

	[AccessedThroughProperty("ll_btncheckonly")]
	private ButtonX _ll_btncheckonly;

	[AccessedThroughProperty("ll_btnremove2")]
	private ButtonX _ll_btnremove2;

	[AccessedThroughProperty("GroupPanel2")]
	private GroupPanel _GroupPanel2;

	[AccessedThroughProperty("LabelX1")]
	private LabelX _LabelX1;

	[AccessedThroughProperty("OpenFileD")]
	private OpenFileDialog _OpenFileD;

	[AccessedThroughProperty("ll_lbloadcase")]
	private ListBox _ll_lbloadcase;

	[AccessedThroughProperty("ll_btncurlc")]
	private ButtonX _ll_btncurlc;

	[AccessedThroughProperty("lslog")]
	private ListBox _lslog;

	[AccessedThroughProperty("Checkyx")]
	private CheckBoxX _Checkyx;

	private string ndh;

	private int jj;

	private string strtemp;

	private string iren;

	private string strxh;

	private string strlc;

	private string strtemp2;

	private string iren2;

	private string strxh2;

	private string strlc2;

	private string path;

	internal virtual LabelX ll_lbleformat
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbleformat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbleformat = value;
		}
	}

	internal virtual ButtonX ll_btnaddrow
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnaddrow;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnaddrow_Click;
			if (_ll_btnaddrow != null)
			{
				((Control)_ll_btnaddrow).remove_Click(eventHandler);
			}
			_ll_btnaddrow = value;
			if (_ll_btnaddrow != null)
			{
				((Control)_ll_btnaddrow).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btninputtxt
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btninputtxt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btninputtxt_Click;
			if (_ll_btninputtxt != null)
			{
				((Control)_ll_btninputtxt).remove_Click(eventHandler);
			}
			_ll_btninputtxt = value;
			if (_ll_btninputtxt != null)
			{
				((Control)_ll_btninputtxt).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btnlooktxt
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnlooktxt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnlooktxt_Click;
			if (_ll_btnlooktxt != null)
			{
				((Control)_ll_btnlooktxt).remove_Click(eventHandler);
			}
			_ll_btnlooktxt = value;
			if (_ll_btnlooktxt != null)
			{
				((Control)_ll_btnlooktxt).add_Click(eventHandler);
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

	internal virtual ButtonX ll_btnloadcaseremove
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnloadcaseremove;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnloadcaseremove_Click;
			if (_ll_btnloadcaseremove != null)
			{
				((Control)_ll_btnloadcaseremove).remove_Click(eventHandler);
			}
			_ll_btnloadcaseremove = value;
			if (_ll_btnloadcaseremove != null)
			{
				((Control)_ll_btnloadcaseremove).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btnloadcaseclear
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnloadcaseclear;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnloadcaseclear_Click;
			if (_ll_btnloadcaseclear != null)
			{
				((Control)_ll_btnloadcaseclear).remove_Click(eventHandler);
			}
			_ll_btnloadcaseclear = value;
			if (_ll_btnloadcaseclear != null)
			{
				((Control)_ll_btnloadcaseclear).add_Click(eventHandler);
			}
		}
	}

	internal virtual CheckBoxX ll_checkmsgbox
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_checkmsgbox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_checkmsgbox = value;
		}
	}

	internal virtual ButtonX ll_btnaz
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnaz;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnaz_Click;
			if (_ll_btnaz != null)
			{
				((Control)_ll_btnaz).remove_Click(eventHandler);
			}
			_ll_btnaz = value;
			if (_ll_btnaz != null)
			{
				((Control)_ll_btnaz).add_Click(eventHandler);
			}
		}
	}

	internal virtual CheckBoxX ll_checkmselectctrlshift
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_checkmselectctrlshift;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_checkmselectctrlshift_CheckedChanged;
			if (_ll_checkmselectctrlshift != null)
			{
				_ll_checkmselectctrlshift.remove_CheckedChanged(eventHandler);
			}
			_ll_checkmselectctrlshift = value;
			if (_ll_checkmselectctrlshift != null)
			{
				_ll_checkmselectctrlshift.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btncheckformat
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btncheckformat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btncheckformat_Click;
			if (_ll_btncheckformat != null)
			{
				((Control)_ll_btncheckformat).remove_Click(eventHandler);
			}
			_ll_btncheckformat = value;
			if (_ll_btncheckformat != null)
			{
				((Control)_ll_btncheckformat).add_Click(eventHandler);
			}
		}
	}

	internal virtual CheckBoxX ll_checkxh1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_checkxh1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_checkxh1 = value;
		}
	}

	internal virtual ButtonX ll_btncheckonly
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btncheckonly;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btncheckonly_Click;
			if (_ll_btncheckonly != null)
			{
				((Control)_ll_btncheckonly).remove_Click(eventHandler);
			}
			_ll_btncheckonly = value;
			if (_ll_btncheckonly != null)
			{
				((Control)_ll_btncheckonly).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btnremove2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnremove2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnremove2_Click;
			if (_ll_btnremove2 != null)
			{
				((Control)_ll_btnremove2).remove_Click(eventHandler);
			}
			_ll_btnremove2 = value;
			if (_ll_btnremove2 != null)
			{
				((Control)_ll_btnremove2).add_Click(eventHandler);
			}
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

	internal virtual OpenFileDialog OpenFileD
	{
		[DebuggerNonUserCode]
		get
		{
			return _OpenFileD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_OpenFileD = value;
		}
	}

	public virtual ListBox ll_lbloadcase
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbloadcase;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbloadcase = value;
		}
	}

	public virtual ButtonX ll_btncurlc
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btncurlc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btncurlc_Click;
			if (_ll_btncurlc != null)
			{
				((Control)_ll_btncurlc).remove_Click(eventHandler);
			}
			_ll_btncurlc = value;
			if (_ll_btncurlc != null)
			{
				((Control)_ll_btncurlc).add_Click(eventHandler);
			}
		}
	}

	internal virtual ListBox lslog
	{
		[DebuggerNonUserCode]
		get
		{
			return _lslog;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lslog = value;
		}
	}

	internal virtual CheckBoxX Checkyx
	{
		[DebuggerNonUserCode]
		get
		{
			return _Checkyx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Checkyx_CheckedChanged;
			if (_Checkyx != null)
			{
				_Checkyx.remove_CheckedChanged(eventHandler);
			}
			_Checkyx = value;
			if (_Checkyx != null)
			{
				_Checkyx.add_CheckedChanged(eventHandler);
			}
		}
	}

	[DebuggerNonUserCode]
	public fxdd()
	{
		((Form)this).add_Load((EventHandler)fxdd_Load);
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
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected O, but got Unknown
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected O, but got Unknown
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Expected O, but got Unknown
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Expected O, but got Unknown
		//IL_04d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Expected O, but got Unknown
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_058b: Expected O, but got Unknown
		//IL_0627: Unknown result type (might be due to invalid IL or missing references)
		//IL_0631: Expected O, but got Unknown
		//IL_06db: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e5: Expected O, but got Unknown
		//IL_0785: Unknown result type (might be due to invalid IL or missing references)
		//IL_078f: Expected O, but got Unknown
		//IL_0838: Unknown result type (might be due to invalid IL or missing references)
		//IL_0842: Expected O, but got Unknown
		//IL_08e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ec: Expected O, but got Unknown
		//IL_0995: Unknown result type (might be due to invalid IL or missing references)
		//IL_099f: Expected O, but got Unknown
		//IL_0a3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a46: Expected O, but got Unknown
		//IL_0adf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae9: Expected O, but got Unknown
		//IL_0ccf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd9: Expected O, but got Unknown
		//IL_0f1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f25: Expected O, but got Unknown
		//IL_102f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1039: Expected O, but got Unknown
		//IL_10d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_10df: Expected O, but got Unknown
		//IL_1165: Unknown result type (might be due to invalid IL or missing references)
		//IL_116f: Expected O, but got Unknown
		ll_lbloadcase = new ListBox();
		ll_lbleformat = new LabelX();
		ll_btnaddrow = new ButtonX();
		ll_btninputtxt = new ButtonX();
		ll_btncurlc = new ButtonX();
		ll_btnlooktxt = new ButtonX();
		btngb = new ButtonX();
		ll_btnloadcaseremove = new ButtonX();
		ll_btnloadcaseclear = new ButtonX();
		ll_checkmsgbox = new CheckBoxX();
		ll_btnaz = new ButtonX();
		ll_checkmselectctrlshift = new CheckBoxX();
		ll_btncheckformat = new ButtonX();
		ll_checkxh1 = new CheckBoxX();
		ll_btncheckonly = new ButtonX();
		ll_btnremove2 = new ButtonX();
		GroupPanel2 = new GroupPanel();
		LabelX1 = new LabelX();
		OpenFileD = new OpenFileDialog();
		lslog = new ListBox();
		Checkyx = new CheckBoxX();
		((Control)GroupPanel2).SuspendLayout();
		((Control)this).SuspendLayout();
		((ListControl)ll_lbloadcase).set_FormattingEnabled(true);
		ll_lbloadcase.set_ItemHeight(12);
		ListBox obj = ll_lbloadcase;
		Point location = new Point(6, 3);
		((Control)obj).set_Location(location);
		((Control)ll_lbloadcase).set_Name("ll_lbloadcase");
		ListBox obj2 = ll_lbloadcase;
		Size size = new Size(449, 304);
		((Control)obj2).set_Size(size);
		((Control)ll_lbloadcase).set_TabIndex(0);
		((BaseItemControl)ll_lbleformat).get_BackgroundStyle().set_Class("");
		((BaseItemControl)ll_lbleformat).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX obj3 = ll_lbleformat;
		location = new Point(8, 313);
		((Control)obj3).set_Location(location);
		((Control)ll_lbleformat).set_Name("ll_lbleformat");
		LabelX obj4 = ll_lbleformat;
		size = new Size(447, 19);
		((Control)obj4).set_Size(size);
		((BaseItemControl)ll_lbleformat).set_Style((eDotNetBarStyle)7);
		((Control)ll_lbleformat).set_TabIndex(2);
		((Control)ll_btnaddrow).set_AccessibleRole((AccessibleRole)43);
		ll_btnaddrow.set_ColorTable((eButtonColor)3);
		((Control)ll_btnaddrow).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ButtonX obj5 = ll_btnaddrow;
		location = new Point(466, 282);
		((Control)obj5).set_Location(location);
		((Control)ll_btnaddrow).set_Name("ll_btnaddrow");
		ButtonX obj6 = ll_btnaddrow;
		size = new Size(142, 23);
		((Control)obj6).set_Size(size);
		((PopupItemControl)ll_btnaddrow).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnaddrow).set_TabIndex(1);
		ll_btnaddrow.set_Text("自定义添加当前行");
		((Control)ll_btninputtxt).set_AccessibleRole((AccessibleRole)43);
		ll_btninputtxt.set_ColorTable((eButtonColor)3);
		((Control)ll_btninputtxt).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ButtonX obj7 = ll_btninputtxt;
		location = new Point(466, 309);
		((Control)obj7).set_Location(location);
		((Control)ll_btninputtxt).set_Name("ll_btninputtxt");
		ButtonX obj8 = ll_btninputtxt;
		size = new Size(142, 23);
		((Control)obj8).set_Size(size);
		((PopupItemControl)ll_btninputtxt).set_Style((eDotNetBarStyle)7);
		((Control)ll_btninputtxt).set_TabIndex(1);
		ll_btninputtxt.set_Text("导入(从txt)");
		((Control)ll_btncurlc).set_AccessibleRole((AccessibleRole)43);
		ll_btncurlc.set_ColorTable((eButtonColor)3);
		((Control)ll_btncurlc).set_Enabled(false);
		((Control)ll_btncurlc).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ButtonX obj9 = ll_btncurlc;
		location = new Point(472, 371);
		((Control)obj9).set_Location(location);
		((Control)ll_btncurlc).set_Name("ll_btncurlc");
		ButtonX obj10 = ll_btncurlc;
		size = new Size(142, 25);
		((Control)obj10).set_Size(size);
		((PopupItemControl)ll_btncurlc).set_Style((eDotNetBarStyle)7);
		((Control)ll_btncurlc).set_TabIndex(1);
		ll_btncurlc.set_Text("输出当前工况curlc.txt");
		((Control)ll_btnlooktxt).set_AccessibleRole((AccessibleRole)43);
		ll_btnlooktxt.set_ColorTable((eButtonColor)3);
		((Control)ll_btnlooktxt).set_Enabled(false);
		((Control)ll_btnlooktxt).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ButtonX obj11 = ll_btnlooktxt;
		location = new Point(472, 400);
		((Control)obj11).set_Location(location);
		((Control)ll_btnlooktxt).set_Name("ll_btnlooktxt");
		ButtonX obj12 = ll_btnlooktxt;
		size = new Size(142, 25);
		((Control)obj12).set_Size(size);
		((PopupItemControl)ll_btnlooktxt).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnlooktxt).set_TabIndex(1);
		ll_btnlooktxt.set_Text("查看curlc.txt");
		((Control)btngb).set_AccessibleRole((AccessibleRole)43);
		btngb.set_ColorTable((eButtonColor)3);
		btngb.set_DialogResult((DialogResult)2);
		((Control)btngb).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ButtonX obj13 = btngb;
		location = new Point(472, 470);
		((Control)obj13).set_Location(location);
		((Control)btngb).set_Name("btngb");
		ButtonX obj14 = btngb;
		size = new Size(142, 25);
		((Control)obj14).set_Size(size);
		((PopupItemControl)btngb).set_Style((eDotNetBarStyle)7);
		((Control)btngb).set_TabIndex(1);
		btngb.set_Text("关闭");
		((Control)ll_btnloadcaseremove).set_AccessibleRole((AccessibleRole)43);
		ll_btnloadcaseremove.set_ColorTable((eButtonColor)3);
		((Control)ll_btnloadcaseremove).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ButtonX obj15 = ll_btnloadcaseremove;
		location = new Point(466, 3);
		((Control)obj15).set_Location(location);
		((Control)ll_btnloadcaseremove).set_Name("ll_btnloadcaseremove");
		ButtonX obj16 = ll_btnloadcaseremove;
		size = new Size(148, 23);
		((Control)obj16).set_Size(size);
		((PopupItemControl)ll_btnloadcaseremove).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnloadcaseremove).set_TabIndex(9);
		ll_btnloadcaseremove.set_Text("移除");
		((Control)ll_btnloadcaseclear).set_AccessibleRole((AccessibleRole)43);
		ll_btnloadcaseclear.set_ColorTable((eButtonColor)3);
		((Control)ll_btnloadcaseclear).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ButtonX obj17 = ll_btnloadcaseclear;
		location = new Point(466, 32);
		((Control)obj17).set_Location(location);
		((Control)ll_btnloadcaseclear).set_Name("ll_btnloadcaseclear");
		ButtonX obj18 = ll_btnloadcaseclear;
		size = new Size(148, 23);
		((Control)obj18).set_Size(size);
		((PopupItemControl)ll_btnloadcaseclear).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnloadcaseclear).set_TabIndex(10);
		ll_btnloadcaseclear.set_Text("清空");
		((BaseItemControl)ll_checkmsgbox).get_BackgroundStyle().set_Class("");
		((BaseItemControl)ll_checkmsgbox).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)ll_checkmsgbox).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		CheckBoxX obj19 = ll_checkmsgbox;
		location = new Point(459, 179);
		((Control)obj19).set_Location(location);
		((Control)ll_checkmsgbox).set_Name("ll_checkmsgbox");
		CheckBoxX obj20 = ll_checkmsgbox;
		size = new Size(158, 13);
		((Control)obj20).set_Size(size);
		((BaseItemControl)ll_checkmsgbox).set_Style((eDotNetBarStyle)7);
		((Control)ll_checkmsgbox).set_TabIndex(12);
		ll_checkmsgbox.set_Text("[移除]/[清空]需要确认");
		((Control)ll_btnaz).set_AccessibleRole((AccessibleRole)43);
		ll_btnaz.set_ColorTable((eButtonColor)3);
		((Control)ll_btnaz).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ButtonX obj21 = ll_btnaz;
		location = new Point(466, 61);
		((Control)obj21).set_Location(location);
		((Control)ll_btnaz).set_Name("ll_btnaz");
		ButtonX obj22 = ll_btnaz;
		size = new Size(148, 23);
		((Control)obj22).set_Size(size);
		((PopupItemControl)ll_btnaz).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnaz).set_TabIndex(8);
		ll_btnaz.set_Text("生成连续序号");
		((BaseItemControl)ll_checkmselectctrlshift).get_BackgroundStyle().set_Class("");
		((BaseItemControl)ll_checkmselectctrlshift).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)ll_checkmselectctrlshift).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		CheckBoxX obj23 = ll_checkmselectctrlshift;
		location = new Point(459, 198);
		((Control)obj23).set_Location(location);
		((Control)ll_checkmselectctrlshift).set_Name("ll_checkmselectctrlshift");
		CheckBoxX obj24 = ll_checkmselectctrlshift;
		size = new Size(161, 16);
		((Control)obj24).set_Size(size);
		((BaseItemControl)ll_checkmselectctrlshift).set_Style((eDotNetBarStyle)7);
		((Control)ll_checkmselectctrlshift).set_TabIndex(11);
		ll_checkmselectctrlshift.set_Text("列表多选方式ctrl,shift");
		((Control)ll_btncheckformat).set_AccessibleRole((AccessibleRole)43);
		ll_btncheckformat.set_ColorTable((eButtonColor)3);
		((Control)ll_btncheckformat).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ButtonX obj25 = ll_btncheckformat;
		location = new Point(466, 90);
		((Control)obj25).set_Location(location);
		((Control)ll_btncheckformat).set_Name("ll_btncheckformat");
		ButtonX obj26 = ll_btncheckformat;
		size = new Size(148, 23);
		((Control)obj26).set_Size(size);
		((PopupItemControl)ll_btncheckformat).set_Style((eDotNetBarStyle)7);
		((Control)ll_btncheckformat).set_TabIndex(6);
		ll_btncheckformat.set_Text("格式检查");
		((BaseItemControl)ll_checkxh1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)ll_checkxh1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)ll_checkxh1).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		CheckBoxX obj27 = ll_checkxh1;
		location = new Point(459, 156);
		((Control)obj27).set_Location(location);
		((Control)ll_checkxh1).set_Name("ll_checkxh1");
		CheckBoxX obj28 = ll_checkxh1;
		size = new Size(109, 17);
		((Control)obj28).set_Size(size);
		((BaseItemControl)ll_checkxh1).set_Style((eDotNetBarStyle)7);
		((Control)ll_checkxh1).set_TabIndex(13);
		ll_checkxh1.set_Text("新序号从1开始");
		((Control)ll_btncheckonly).set_AccessibleRole((AccessibleRole)43);
		ll_btncheckonly.set_ColorTable((eButtonColor)3);
		((Control)ll_btncheckonly).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ButtonX obj29 = ll_btncheckonly;
		location = new Point(466, 119);
		((Control)obj29).set_Location(location);
		((Control)ll_btncheckonly).set_Name("ll_btncheckonly");
		ButtonX obj30 = ll_btncheckonly;
		size = new Size(71, 23);
		((Control)obj30).set_Size(size);
		((PopupItemControl)ll_btncheckonly).set_Style((eDotNetBarStyle)7);
		((Control)ll_btncheckonly).set_TabIndex(7);
		ll_btncheckonly.set_Text("检验唯一性");
		((Control)ll_btnremove2).set_AccessibleRole((AccessibleRole)43);
		ll_btnremove2.set_ColorTable((eButtonColor)3);
		((Control)ll_btnremove2).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ButtonX obj31 = ll_btnremove2;
		location = new Point(543, 119);
		((Control)obj31).set_Location(location);
		((Control)ll_btnremove2).set_Name("ll_btnremove2");
		ButtonX obj32 = ll_btnremove2;
		size = new Size(71, 23);
		((Control)obj32).set_Size(size);
		((PopupItemControl)ll_btnremove2).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnremove2).set_TabIndex(5);
		ll_btnremove2.set_Text("移除重复值");
		((PanelControl)GroupPanel2).set_CanvasColor(SystemColors.Control);
		((PanelControl)GroupPanel2).set_ColorSchemeStyle((eDotNetBarStyle)4);
		((Control)GroupPanel2).get_Controls().Add((Control)(object)LabelX1);
		((Control)GroupPanel2).get_Controls().Add((Control)(object)ll_btnaddrow);
		((Control)GroupPanel2).get_Controls().Add((Control)(object)ll_btninputtxt);
		((Control)GroupPanel2).get_Controls().Add((Control)(object)ll_btnloadcaseremove);
		((Control)GroupPanel2).get_Controls().Add((Control)(object)Checkyx);
		((Control)GroupPanel2).get_Controls().Add((Control)(object)ll_checkmselectctrlshift);
		((Control)GroupPanel2).get_Controls().Add((Control)(object)ll_btnloadcaseclear);
		((Control)GroupPanel2).get_Controls().Add((Control)(object)ll_lbloadcase);
		((Control)GroupPanel2).get_Controls().Add((Control)(object)ll_checkmsgbox);
		((Control)GroupPanel2).get_Controls().Add((Control)(object)ll_lbleformat);
		((Control)GroupPanel2).get_Controls().Add((Control)(object)ll_btnaz);
		((Control)GroupPanel2).get_Controls().Add((Control)(object)ll_btncheckformat);
		((Control)GroupPanel2).get_Controls().Add((Control)(object)ll_btnremove2);
		((Control)GroupPanel2).get_Controls().Add((Control)(object)ll_checkxh1);
		((Control)GroupPanel2).get_Controls().Add((Control)(object)ll_btncheckonly);
		((Control)GroupPanel2).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		GroupPanel groupPanel = GroupPanel2;
		location = new Point(3, 3);
		((Control)groupPanel).set_Location(location);
		((Control)GroupPanel2).set_Name("GroupPanel2");
		GroupPanel groupPanel2 = GroupPanel2;
		size = new Size(626, 364);
		((Control)groupPanel2).set_Size(size);
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
		((Control)GroupPanel2).set_TabIndex(14);
		((PanelControl)GroupPanel2).set_Text("生成工况文本");
		((Control)LabelX1).set_BackColor(Color.FromArgb(194, 217, 247));
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX1).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX labelX = LabelX1;
		location = new Point(466, 259);
		((Control)labelX).set_Location(location);
		((Control)LabelX1).set_Name("LabelX1");
		LabelX labelX2 = LabelX1;
		size = new Size(142, 17);
		((Control)labelX2).set_Size(size);
		((Control)LabelX1).set_TabIndex(14);
		LabelX1.set_Text("计算工况表填充方式");
		((ListControl)lslog).set_FormattingEnabled(true);
		lslog.set_ItemHeight(12);
		ListBox obj33 = lslog;
		location = new Point(3, 373);
		((Control)obj33).set_Location(location);
		((Control)lslog).set_Name("lslog");
		ListBox obj34 = lslog;
		size = new Size(458, 124);
		((Control)obj34).set_Size(size);
		((Control)lslog).set_TabIndex(15);
		((BaseItemControl)Checkyx).get_BackgroundStyle().set_Class("");
		((BaseItemControl)Checkyx).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)Checkyx).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		CheckBoxX checkyx = Checkyx;
		location = new Point(459, 220);
		((Control)checkyx).set_Location(location);
		((Control)Checkyx).set_Name("Checkyx");
		CheckBoxX checkyx2 = Checkyx;
		size = new Size(161, 16);
		((Control)checkyx2).set_Size(size);
		((BaseItemControl)Checkyx).set_Style((eDotNetBarStyle)7);
		((Control)Checkyx).set_TabIndex(11);
		Checkyx.set_Text("输出时自动检查有效性");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_CancelButton((IButtonControl)(object)btngb);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		size = new Size(633, 500);
		((Form)this).set_ClientSize(size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)lslog);
		((Control)this).get_Controls().Add((Control)(object)GroupPanel2);
		((Control)this).get_Controls().Add((Control)(object)btngb);
		((Control)this).get_Controls().Add((Control)(object)ll_btncurlc);
		((Control)this).get_Controls().Add((Control)(object)ll_btnlooktxt);
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("fxdd");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("生成工况");
		((Control)GroupPanel2).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void ll_btnloadcaseremove_Click(object sender, EventArgs e)
	{
		if (((ll_lbloadcase.get_Items().get_Count() == 0) | (ll_lbloadcase.get_SelectedIndex() == -1)) || (ll_checkmsgbox.get_Checked() && !ll_checkmsgboxinfo()))
		{
			return;
		}
		checked
		{
			int num = default(int);
			for (int i = ll_lbloadcase.get_Items().get_Count() - 1; i >= 0; i += -1)
			{
				if (ll_lbloadcase.GetSelected(i))
				{
					ll_lbloadcase.get_Items().RemoveAt(i);
					num++;
				}
			}
			if (ll_lbloadcase.get_Items().get_Count() == 0)
			{
				((Control)ll_btncurlc).set_Enabled(false);
				lslog.set_ForeColor(Color.Black);
			}
			lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员移除了 " + Conversions.ToString(num) + " 条数据！！"));
			lslog.set_SelectedIndex(lslog.get_Items().get_Count() - 1);
		}
	}

	public bool ll_checkmsgboxinfo()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		bool result = false;
		if ((int)MessageBox.Show("是否要移除或清空当前列表信息?", "提示", (MessageBoxButtons)4, (MessageBoxIcon)64) == 6)
		{
			result = true;
			((Control)ll_btncurlc).set_Enabled(false);
		}
		return result;
	}

	private void ll_btnloadcaseclear_Click(object sender, EventArgs e)
	{
		if (ll_lbloadcase.get_Items().get_Count() != 0 && (!ll_checkmsgbox.get_Checked() || ll_checkmsgboxinfo()))
		{
			ll_lbloadcase.get_Items().Clear();
			((Control)ll_btncurlc).set_Enabled(false);
			lslog.set_ForeColor(Color.Black);
			lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员清空了当前数据！！"));
			lslog.set_SelectedIndex(checked(lslog.get_Items().get_Count() - 1));
		}
	}

	private void ll_btnaz_Click(object sender, EventArgs e)
	{
		checked
		{
			if (ll_lbloadcase.get_Items().get_Count() != 0)
			{
				int num = ll_lbloadcase.get_Items().get_Count() - 1;
				for (int i = 0; i <= num; i++)
				{
					Mod1.curloadcaserow = Conversions.ToString(ll_lbloadcase.get_Items().get_Item(i));
					ndh = Conversions.ToString(Strings.InStr(Mod1.curloadcaserow, ",", (CompareMethod)0));
					Mod1.curloadcaserow = Strings.Right(Mod1.curloadcaserow, (int)Math.Round((double)Strings.Len(Mod1.curloadcaserow) - Conversions.ToDouble(ndh)));
					ll_lbloadcase.get_Items().set_Item(i, (object)(Conversions.ToString(i + 1) + "," + Mod1.curloadcaserow));
				}
				lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员生成了连续序号！！"));
			}
			else
			{
				lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 当前数据为空！！"));
			}
			lslog.set_SelectedIndex(lslog.get_Items().get_Count() - 1);
		}
	}

	private void ll_btncheckformat_Click(object sender, EventArgs e)
	{
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Invalid comparison between Unknown and I4
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (ll_lbloadcase.get_Items().get_Count() != 0)
			{
				ll_lbloadcase.set_SelectedIndex(-1);
				string[] array = Strings.Split(Mod1.curloadcaseformat, ",", -1, (CompareMethod)0);
				int num = ll_lbloadcase.get_Items().get_Count() - 1;
				int num2 = default(int);
				for (int i = 0; i <= num; i++)
				{
					Mod1.curloadcaserow = Conversions.ToString(ll_lbloadcase.get_Items().get_Item(i));
					ndh = Conversions.ToString(Strings.InStr(Mod1.curloadcaserow, ",", (CompareMethod)0));
					Mod1.curloadcaserow = Strings.Right(Mod1.curloadcaserow, (int)Math.Round((double)Strings.Len(Mod1.curloadcaserow) - Conversions.ToDouble(ndh)));
					string[] array2 = Strings.Split(Mod1.curloadcaserow, ",", -1, (CompareMethod)0);
					if (Information.UBound((Array)array, 1) != Information.UBound((Array)array2, 1))
					{
						if (unchecked((int)ll_lbloadcase.get_SelectionMode()) != 3)
						{
							ll_lbloadcase.set_SelectionMode((SelectionMode)3);
							ll_checkmselectctrlshift.set_Checked(true);
						}
						ll_lbloadcase.set_SelectedIndex(i);
						num2++;
					}
				}
				if (num2 >= 1)
				{
					Interaction.MsgBox((object)"当前工况列表格式与装配列表要求不一致.", (MsgBoxStyle)64, (object)"提示");
					lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 发现非法数据！！"));
					lslog.set_ForeColor(Color.Red);
				}
				else
				{
					lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 没有发现非法数据！！"));
					lslog.set_SelectedIndex(lslog.get_Items().get_Count() - 1);
					lslog.set_ForeColor(Color.Black);
				}
			}
			else
			{
				lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 当前列表没有数据！！"));
				Mod1.curloadcaserow = "";
			}
			lslog.set_SelectedIndex(lslog.get_Items().get_Count() - 1);
		}
	}

	private void ll_btncheckonly_Click(object sender, EventArgs e)
	{
		checked
		{
			if (ll_lbloadcase.get_Items().get_Count() != 0)
			{
				ll_lbloadcase.set_SelectedIndex(-1);
				ll_lbloadcase.set_SelectionMode((SelectionMode)3);
				jj = 0;
				int num = ll_lbloadcase.get_Items().get_Count() - 1;
				for (int i = 0; i <= num; i++)
				{
					strtemp = Conversions.ToString(ll_lbloadcase.get_Items().get_Item(i));
					iren = Conversions.ToString(Strings.InStr(1, strtemp, ",", (CompareMethod)0));
					strxh = Strings.Left(strtemp, (int)Math.Round(Conversions.ToDouble(iren) - 1.0));
					strlc = Strings.Right(strtemp, (int)Math.Round((double)Strings.Len(strtemp) - Conversions.ToDouble(iren)));
					int num2 = i + 1;
					int num3 = ll_lbloadcase.get_Items().get_Count() - 1;
					for (int j = num2; j <= num3; j++)
					{
						strtemp2 = Conversions.ToString(ll_lbloadcase.get_Items().get_Item(j));
						iren2 = Conversions.ToString(Strings.InStr(1, strtemp2, ",", (CompareMethod)0));
						strxh2 = Strings.Left(strtemp2, (int)Math.Round(Conversions.ToDouble(iren2) - 1.0));
						strlc2 = Strings.Right(strtemp2, (int)Math.Round((double)Strings.Len(strtemp2) - Conversions.ToDouble(iren2)));
						if (Operators.CompareString(Strings.LCase(Strings.Trim(strlc)), Strings.LCase(Strings.Trim(strlc2)), false) == 0)
						{
							ll_lbloadcase.SetSelected(j, true);
							jj++;
						}
					}
				}
				if (jj >= 1)
				{
					lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 当前数据列表中存在重复数据！！"));
					lslog.set_ForeColor(Color.Red);
					lslog.set_SelectedIndex(lslog.get_Items().get_Count() - 1);
					ll_checkmselectctrlshift.set_Checked(true);
				}
				else
				{
					lslog.set_ForeColor(Color.Black);
					lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 当前数据列表中没有重复数据！！"));
					if (!ll_checkmselectctrlshift.get_Checked())
					{
						ll_lbloadcase.set_SelectionMode((SelectionMode)1);
					}
				}
			}
			else
			{
				lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 当前数据列表中没有数据！！"));
			}
			lslog.set_SelectedIndex(lslog.get_Items().get_Count() - 1);
		}
	}

	private void ll_btnremove2_Click(object sender, EventArgs e)
	{
		checked
		{
			if (ll_lbloadcase.get_Items().get_Count() != 0)
			{
				int num = 0;
				for (int i = ll_lbloadcase.get_Items().get_Count() - 1; i >= 0; i += -1)
				{
					jj = 0;
					strtemp = Conversions.ToString(ll_lbloadcase.get_Items().get_Item(i));
					iren = Conversions.ToString(Strings.InStr(1, strtemp, ",", (CompareMethod)0));
					strxh = Strings.Left(strtemp, (int)Math.Round(Conversions.ToDouble(iren) - 1.0));
					strlc = Strings.Right(strtemp, (int)Math.Round((double)Strings.Len(strtemp) - Conversions.ToDouble(iren)));
					for (int j = i - 1; j >= 0; j += -1)
					{
						strtemp2 = Conversions.ToString(ll_lbloadcase.get_Items().get_Item(j));
						iren2 = Conversions.ToString(Strings.InStr(1, strtemp2, ",", (CompareMethod)0));
						strxh2 = Strings.Left(strtemp2, (int)Math.Round(Conversions.ToDouble(iren2) - 1.0));
						strlc2 = Strings.Right(strtemp2, (int)Math.Round((double)Strings.Len(strtemp2) - Conversions.ToDouble(iren2)));
						if (Operators.CompareString(Strings.LCase(Strings.Trim(strlc)), Strings.LCase(Strings.Trim(strlc2)), false) == 0)
						{
							jj++;
						}
					}
					if (jj >= 1)
					{
						num++;
						ll_lbloadcase.get_Items().RemoveAt(i);
					}
				}
				lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 共删除重复数据：" + Conversions.ToString(num) + " 条"));
				lslog.set_SelectedIndex(lslog.get_Items().get_Count() - 1);
				lslog.set_ForeColor(Color.Black);
			}
			else
			{
				lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 当前数据列表为空！！"));
			}
			lslog.set_SelectedIndex(lslog.get_Items().get_Count() - 1);
		}
	}

	private void ll_checkmselectctrlshift_CheckedChanged(object sender, EventArgs e)
	{
		if (ll_checkmselectctrlshift.get_Checked())
		{
			ll_lbloadcase.set_SelectionMode((SelectionMode)3);
		}
		else
		{
			ll_lbloadcase.set_SelectionMode((SelectionMode)1);
		}
	}

	private void ll_btnaddrow_Click(object sender, EventArgs e)
	{
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (ll_checkxh1.get_Checked())
			{
				MyProject.Forms.ll_ufloadcaserow.nn = 0;
			}
			else if (ll_lbloadcase.get_Items().get_Count() == 0)
			{
				MyProject.Forms.ll_ufloadcaserow.nn = 0;
			}
			else
			{
				string[] array = Strings.Split(Conversions.ToString(ll_lbloadcase.get_Items().get_Item(ll_lbloadcase.get_Items().get_Count() - 1)), ",", -1, (CompareMethod)0);
				MyProject.Forms.ll_ufloadcaserow.nn = Conversions.ToInteger(array[0]);
			}
			if ((ll_lbloadcase.get_Items().get_Count() == 0) | (ll_lbloadcase.get_SelectedIndex() == -1))
			{
				Mod1.curloadcaserow = "";
			}
			else
			{
				Mod1.curloadcaserow = Conversions.ToString(ll_lbloadcase.get_Items().get_Item(ll_lbloadcase.get_SelectedIndex()));
				ndh = Conversions.ToString(Strings.InStr(Mod1.curloadcaserow, ",", (CompareMethod)0));
				Mod1.curloadcaserow = Strings.Right(Mod1.curloadcaserow, (int)Math.Round((double)Strings.Len(Mod1.curloadcaserow) - Conversions.ToDouble(ndh)));
			}
			((Form)MyProject.Forms.ll_ufloadcaserow).ShowDialog();
			((Component)(object)MyProject.Forms.ll_ufloadcaserow).Dispose();
			if (ll_lbloadcase.get_Items().get_Count() == 0)
			{
				((Control)ll_btncurlc).set_Enabled(false);
			}
			else
			{
				((Control)ll_btncurlc).set_Enabled(true);
			}
		}
	}

	private void ll_btninputtxt_Click(object sender, EventArgs e)
	{
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Invalid comparison between Unknown and I4
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		jj = 0;
		((FileDialog)OpenFileD).set_RestoreDirectory(false);
		string[] array = Mod1.path1.Split(new char[1] { '\\' });
		if (Operators.CompareString(array[1], "", false) == 0)
		{
			Mod1.path1 = Mod1.path1.Remove(2, 1);
		}
		OpenFileDialog openFileD = OpenFileD;
		string path = Mod1.path1;
		ListBox lbsl = MyProject.Forms.clxd.lbsl;
		string text = lbsl.get_Text();
		string text2 = Mod1.toen(ref text);
		lbsl.set_Text(text);
		((FileDialog)openFileD).set_InitialDirectory(path + "\\xn\\" + text2 + "\\source\\loadcase");
		((FileDialog)OpenFileD).set_Filter("文本文件(*.txt)|*.txt");
		if ((int)((CommonDialog)OpenFileD).ShowDialog() != 1)
		{
			return;
		}
		string fileName = ((FileDialog)OpenFileD).get_FileName();
		Mod1.lr = new StreamReader(fileName, Encoding.Default);
		Mod1.ff = "";
		checked
		{
			int num = default(int);
			while (!Information.IsNothing((object)Mod1.ff))
			{
				Mod1.ff = Mod1.lr.ReadLine();
				if (Information.IsNothing((object)Mod1.ff))
				{
					break;
				}
				jj++;
				string[] array2 = Strings.Split(Mod1.ff, ",", -1, (CompareMethod)0);
				string[] array3 = Strings.Split(Mod1.curloadcaseformat, ",", -1, (CompareMethod)0);
				ll_lbloadcase.get_Items().Add((object)Mod1.ff);
				if ((array2.Length - 1 != array3.Length) & (Operators.CompareString(Mod1.ff, "", false) != 0))
				{
					ll_lbloadcase.set_SelectionMode((SelectionMode)3);
					ll_checkmselectctrlshift.set_Checked(true);
					ll_lbloadcase.set_SelectedIndex(jj - 1);
					num++;
				}
			}
			if (ll_lbloadcase.get_Items().get_Count() != 0)
			{
				if (num >= 1)
				{
					Interaction.MsgBox((object)"导入的数据内容格式与当前要求格式不一致,请仔细核对!", (MsgBoxStyle)64, (object)"提示");
					lslog.get_Items().Add((object)DateTime.Now);
					lslog.get_Items().Add((object)("操作员导入的数据 " + fileName.Substring(fileName.LastIndexOf("\\") + 1) + " 文件中与当前数据格式不匹配，请检查~！！"));
					lslog.set_ForeColor(Color.Red);
				}
				else
				{
					lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员导入 " + fileName.Substring(fileName.LastIndexOf("\\") + 1)));
					lslog.set_ForeColor(Color.Black);
				}
				((Control)ll_btncurlc).set_Enabled(true);
			}
			else
			{
				((Control)ll_btncurlc).set_Enabled(false);
				Interaction.MsgBox((object)"导入的文件没有内容!", (MsgBoxStyle)64, (object)"提示");
			}
			Mod1.lr.Close();
			Mod1.lr.Dispose();
			lslog.set_SelectedIndex(lslog.get_Items().get_Count() - 1);
		}
	}

	private void btngb_Click(object sender, EventArgs e)
	{
		checked
		{
			int num = lslog.get_Items().get_Count() - 1;
			for (int i = 0; i <= num; i++)
			{
				MyProject.Forms.clxd.lblog.get_Items().Add(RuntimeHelpers.GetObjectValue(lslog.get_Items().get_Item(i)));
			}
			MyProject.Forms.clxd.lblog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员关闭了生成工况对话框"));
			((Component)(object)this).Dispose();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void ll_btncurlc_Click(object sender, EventArgs e)
	{
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (ll_lbloadcase.get_Items().get_Count() != 0)
			{
				((Control)ll_btnlooktxt).set_Enabled(true);
				string path = Mod1.path1;
				ListBox lbsl = MyProject.Forms.clxd.lbsl;
				string text = lbsl.get_Text();
				string text2 = Mod1.toen(ref text);
				lbsl.set_Text(text);
				this.path = path + "\\xn\\" + text2 + "\\source\\loadcase\\curlc.txt";
				FileSystem.Kill(this.path);
				Mod1.wr = new StreamWriter(this.path, append: true, Encoding.Default);
				if (ll_lbloadcase.get_Items().get_Count() != 0)
				{
					int num = ll_lbloadcase.get_Items().get_Count() - 1;
					for (int i = 0; i <= num; i++)
					{
						string value = Conversions.ToString(ll_lbloadcase.get_Items().get_Item(i));
						Mod1.wr.WriteLine(value);
					}
				}
				Mod1.wr.Close();
				Mod1.wr.Dispose();
				strtemp = "【输出当前工况curlc.txt】--已更新当前工况参数信息文件.";
				lslog.get_Items().Add((object)strtemp);
				strtemp = Conversions.ToString(DateTime.Now) + " 所在路径:";
				lslog.get_Items().Add((object)strtemp);
				lslog.get_Items().Add((object)this.path);
				lslog.set_SelectedIndex(lslog.get_Items().get_Count() - 1);
			}
			else
			{
				Interaction.MsgBox((object)"当前没有内容需要输出!", (MsgBoxStyle)64, (object)"提示");
			}
		}
	}

	private void ll_btnlooktxt_Click(object sender, EventArgs e)
	{
		if (File.Exists(path))
		{
			Process.Start(Interaction.Environ("windir") + "\\NOTEPAD.EXE", path);
		}
	}

	private void fxdd_Load(object sender, EventArgs e)
	{
		((Control)ll_lbleformat).set_BackColor(Color.Transparent);
		((Control)LabelX1).set_BackColor(Color.Transparent);
		((Control)ll_checkxh1).set_BackColor(Color.Transparent);
		((Control)ll_checkmsgbox).set_BackColor(Color.Transparent);
		((Control)ll_checkmselectctrlshift).set_BackColor(Color.Transparent);
		ll_checkmselectctrlshift.set_Checked(true);
	}

	private void Checkyx_CheckedChanged(object sender, EventArgs e)
	{
		if (Checkyx.get_Checked())
		{
			ll_btncheckonly_Click(RuntimeHelpers.GetObjectValue(sender), e);
			ll_btncheckformat_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}
	}
}
