using System;
using System.Collections;
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
using Microsoft.Office.Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using xxx.My;

namespace xxx;

[DesignerGenerated]
public class cslr : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("GroupPanel1")]
	private GroupPanel _GroupPanel1;

	[AccessedThroughProperty("lbid")]
	private ListBox _lbid;

	[AccessedThroughProperty("GroupPanel2")]
	private GroupPanel _GroupPanel2;

	[AccessedThroughProperty("lbccmc")]
	private ListBox _lbccmc;

	[AccessedThroughProperty("lbxh")]
	private ListBox _lbxh;

	[AccessedThroughProperty("lbcsmc")]
	private ListBox _lbcsmc;

	[AccessedThroughProperty("lbcsz")]
	private ListBox _lbcsz;

	[AccessedThroughProperty("lbbz")]
	private ListBox _lbbz;

	[AccessedThroughProperty("cbsddqid")]
	private CheckBoxX _cbsddqid;

	[AccessedThroughProperty("SuperTabControlPanel1")]
	private SuperTabControlPanel _SuperTabControlPanel1;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("SuperTabItem1")]
	private SuperTabItem _SuperTabItem1;

	[AccessedThroughProperty("SuperTabControlPanel2")]
	private SuperTabControlPanel _SuperTabControlPanel2;

	[AccessedThroughProperty("SuperTabItem2")]
	private SuperTabItem _SuperTabItem2;

	[AccessedThroughProperty("tbdqid")]
	private TextBoxX _tbdqid;

	[AccessedThroughProperty("lbtplb")]
	private ListBox _lbtplb;

	[AccessedThroughProperty("btncsyz")]
	private ButtonX _btncsyz;

	[AccessedThroughProperty("btntqjl")]
	private ButtonX _btntqjl;

	[AccessedThroughProperty("btngb")]
	private ButtonX _btngb;

	[AccessedThroughProperty("lslog")]
	private ListBox _lslog;

	[AccessedThroughProperty("lbcsx")]
	private ListBox _lbcsx;

	[AccessedThroughProperty("TSL")]
	private LabelX _TSL;

	[AccessedThroughProperty("lba")]
	private ListBox _lba;

	[AccessedThroughProperty("STC")]
	private SuperTabControl _STC;

	[AccessedThroughProperty("LabelX1")]
	private LabelX _LabelX1;

	[AccessedThroughProperty("LabelX3")]
	private LabelX _LabelX3;

	[AccessedThroughProperty("LabelX7")]
	private LabelX _LabelX7;

	[AccessedThroughProperty("LabelX6")]
	private LabelX _LabelX6;

	[AccessedThroughProperty("LabelX5")]
	private LabelX _LabelX5;

	[AccessedThroughProperty("LabelX4")]
	private LabelX _LabelX4;

	[AccessedThroughProperty("LabelX2")]
	private LabelX _LabelX2;

	[AccessedThroughProperty("LabelX8")]
	private LabelX _LabelX8;

	[AccessedThroughProperty("xs")]
	private LabelX _xs;

	[AccessedThroughProperty("ll_chkbmpfilter")]
	private CheckBoxX _ll_chkbmpfilter;

	[AccessedThroughProperty("btnbcjg")]
	private ButtonX _btnbcjg;

	[AccessedThroughProperty("ll_btncurjmcheck")]
	private ButtonX _ll_btncurjmcheck;

	private string[] filename;

	private bool @bool;

	private bool bcscheckok;

	private string id;

	public bool w;

	private string cstxt;

	public string strcsymname;

	public string strcsfpath;

	public string flisname;

	private bool bj;

	private string a;

	private string strcsname;

	private string fname;

	private bool @checked;

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

	internal virtual ListBox lbid
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbid;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = lbid_SelectedIndexChanged;
			if (_lbid != null)
			{
				_lbid.remove_SelectedIndexChanged(eventHandler);
			}
			_lbid = value;
			if (_lbid != null)
			{
				_lbid.add_SelectedIndexChanged(eventHandler);
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

	public virtual ListBox lbccmc
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbccmc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			EventHandler eventHandler = lbccmc_SelectedIndexChanged;
			MouseEventHandler val = new MouseEventHandler(lbccmc_MouseMove);
			if (_lbccmc != null)
			{
				_lbccmc.remove_SelectedIndexChanged(eventHandler);
				((Control)_lbccmc).remove_MouseMove(val);
			}
			_lbccmc = value;
			if (_lbccmc != null)
			{
				_lbccmc.add_SelectedIndexChanged(eventHandler);
				((Control)_lbccmc).add_MouseMove(val);
			}
		}
	}

	public virtual ListBox lbxh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbxh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(lbxh_MouseMove);
			EventHandler eventHandler = lbxh_SelectedIndexChanged;
			if (_lbxh != null)
			{
				((Control)_lbxh).remove_MouseMove(val);
				_lbxh.remove_SelectedIndexChanged(eventHandler);
			}
			_lbxh = value;
			if (_lbxh != null)
			{
				((Control)_lbxh).add_MouseMove(val);
				_lbxh.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	public virtual ListBox lbcsmc
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbcsmc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			EventHandler eventHandler = lbcsmc_SelectedIndexChanged;
			MouseEventHandler val = new MouseEventHandler(lbcsmc_MouseMove);
			if (_lbcsmc != null)
			{
				_lbcsmc.remove_SelectedIndexChanged(eventHandler);
				((Control)_lbcsmc).remove_MouseMove(val);
			}
			_lbcsmc = value;
			if (_lbcsmc != null)
			{
				_lbcsmc.add_SelectedIndexChanged(eventHandler);
				((Control)_lbcsmc).add_MouseMove(val);
			}
		}
	}

	public virtual ListBox lbcsz
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbcsz;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			EventHandler eventHandler = lbcsz_DoubleClick;
			EventHandler eventHandler2 = lbcsz_SelectedIndexChanged;
			MouseEventHandler val = new MouseEventHandler(lbcsz_MouseMove);
			if (_lbcsz != null)
			{
				((Control)_lbcsz).remove_DoubleClick(eventHandler);
				_lbcsz.remove_SelectedIndexChanged(eventHandler2);
				((Control)_lbcsz).remove_MouseMove(val);
			}
			_lbcsz = value;
			if (_lbcsz != null)
			{
				((Control)_lbcsz).add_DoubleClick(eventHandler);
				_lbcsz.add_SelectedIndexChanged(eventHandler2);
				((Control)_lbcsz).add_MouseMove(val);
			}
		}
	}

	public virtual ListBox lbbz
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbbz;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			EventHandler eventHandler = lbbz_SelectedIndexChanged;
			MouseEventHandler val = new MouseEventHandler(lbbz_MouseMove);
			if (_lbbz != null)
			{
				_lbbz.remove_SelectedIndexChanged(eventHandler);
				((Control)_lbbz).remove_MouseMove(val);
			}
			_lbbz = value;
			if (_lbbz != null)
			{
				_lbbz.add_SelectedIndexChanged(eventHandler);
				((Control)_lbbz).add_MouseMove(val);
			}
		}
	}

	internal virtual CheckBoxX cbsddqid
	{
		[DebuggerNonUserCode]
		get
		{
			return _cbsddqid;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cbsddqid_CheckedChanged;
			if (_cbsddqid != null)
			{
				_cbsddqid.remove_CheckedChanged(eventHandler);
			}
			_cbsddqid = value;
			if (_cbsddqid != null)
			{
				_cbsddqid.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual SuperTabControlPanel SuperTabControlPanel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _SuperTabControlPanel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SuperTabControlPanel1 = value;
		}
	}

	internal virtual PictureBox PictureBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PictureBox1_Click;
			if (_PictureBox1 != null)
			{
				((Control)_PictureBox1).remove_Click(eventHandler);
			}
			_PictureBox1 = value;
			if (_PictureBox1 != null)
			{
				((Control)_PictureBox1).add_Click(eventHandler);
			}
		}
	}

	internal virtual SuperTabItem SuperTabItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _SuperTabItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SuperTabItem1 = value;
		}
	}

	internal virtual SuperTabControlPanel SuperTabControlPanel2
	{
		[DebuggerNonUserCode]
		get
		{
			return _SuperTabControlPanel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SuperTabControlPanel2 = value;
		}
	}

	internal virtual SuperTabItem SuperTabItem2
	{
		[DebuggerNonUserCode]
		get
		{
			return _SuperTabItem2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SuperTabItem2 = value;
		}
	}

	internal virtual TextBoxX tbdqid
	{
		[DebuggerNonUserCode]
		get
		{
			return _tbdqid;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tbdqid = value;
		}
	}

	internal virtual ListBox lbtplb
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbtplb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = lbtplb_SelectedIndexChanged;
			if (_lbtplb != null)
			{
				_lbtplb.remove_SelectedIndexChanged(eventHandler);
			}
			_lbtplb = value;
			if (_lbtplb != null)
			{
				_lbtplb.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual ButtonX btncsyz
	{
		[DebuggerNonUserCode]
		get
		{
			return _btncsyz;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btncsyz_Click;
			if (_btncsyz != null)
			{
				((Control)_btncsyz).remove_Click(eventHandler);
			}
			_btncsyz = value;
			if (_btncsyz != null)
			{
				((Control)_btncsyz).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX btntqjl
	{
		[DebuggerNonUserCode]
		get
		{
			return _btntqjl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btntqjl_Click;
			if (_btntqjl != null)
			{
				((Control)_btntqjl).remove_Click(eventHandler);
			}
			_btntqjl = value;
			if (_btntqjl != null)
			{
				((Control)_btntqjl).add_Click(eventHandler);
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

	public virtual ListBox lslog
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
			EventHandler eventHandler = lslog_DoubleClick;
			if (_lslog != null)
			{
				((Control)_lslog).remove_DoubleClick(eventHandler);
			}
			_lslog = value;
			if (_lslog != null)
			{
				((Control)_lslog).add_DoubleClick(eventHandler);
			}
		}
	}

	public virtual ListBox lbcsx
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbcsx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			EventHandler eventHandler = lbcsx_SelectedIndexChanged;
			MouseEventHandler val = new MouseEventHandler(lbcsx_MouseUp);
			if (_lbcsx != null)
			{
				_lbcsx.remove_SelectedIndexChanged(eventHandler);
				((Control)_lbcsx).remove_MouseUp(val);
			}
			_lbcsx = value;
			if (_lbcsx != null)
			{
				_lbcsx.add_SelectedIndexChanged(eventHandler);
				((Control)_lbcsx).add_MouseUp(val);
			}
		}
	}

	internal virtual LabelX TSL
	{
		[DebuggerNonUserCode]
		get
		{
			return _TSL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TSL = value;
		}
	}

	public virtual ListBox lba
	{
		[DebuggerNonUserCode]
		get
		{
			return _lba;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = lbxh_SelectedIndexChanged;
			if (_lba != null)
			{
				_lba.remove_SelectedIndexChanged(eventHandler);
			}
			_lba = value;
			if (_lba != null)
			{
				_lba.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	public virtual SuperTabControl STC
	{
		[DebuggerNonUserCode]
		get
		{
			return _STC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_STC = value;
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

	internal virtual LabelX xs
	{
		[DebuggerNonUserCode]
		get
		{
			return _xs;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_xs = value;
		}
	}

	public virtual CheckBoxX ll_chkbmpfilter
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_chkbmpfilter;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_chkbmpfilter_CheckedChanged;
			if (_ll_chkbmpfilter != null)
			{
				_ll_chkbmpfilter.remove_CheckedChanged(eventHandler);
			}
			_ll_chkbmpfilter = value;
			if (_ll_chkbmpfilter != null)
			{
				_ll_chkbmpfilter.add_CheckedChanged(eventHandler);
			}
		}
	}

	public virtual ButtonX btnbcjg
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnbcjg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnbcjg_Click;
			if (_btnbcjg != null)
			{
				((Control)_btnbcjg).remove_Click(eventHandler);
			}
			_btnbcjg = value;
			if (_btnbcjg != null)
			{
				((Control)_btnbcjg).add_Click(eventHandler);
			}
		}
	}

	public virtual ButtonX ll_btncurjmcheck
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btncurjmcheck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btncurjmcheck_Click;
			if (_ll_btncurjmcheck != null)
			{
				((Control)_ll_btncurjmcheck).remove_Click(eventHandler);
			}
			_ll_btncurjmcheck = value;
			if (_ll_btncurjmcheck != null)
			{
				((Control)_ll_btncurjmcheck).add_Click(eventHandler);
			}
		}
	}

	public cslr()
	{
		((Form)this).add_Load((EventHandler)cslr_Load);
		@bool = false;
		bcscheckok = true;
		w = true;
		cstxt = Application.get_StartupPath() + "\\Temp\\cs.txt";
		bj = false;
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
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Expected O, but got Unknown
		//IL_0535: Unknown result type (might be due to invalid IL or missing references)
		//IL_053f: Expected O, but got Unknown
		//IL_06fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0707: Expected O, but got Unknown
		//IL_0787: Unknown result type (might be due to invalid IL or missing references)
		//IL_0791: Expected O, but got Unknown
		//IL_0b17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b21: Expected O, but got Unknown
		//IL_0bdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be5: Expected O, but got Unknown
		//IL_0c9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca6: Expected O, but got Unknown
		//IL_0d5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d67: Expected O, but got Unknown
		//IL_0e1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e25: Expected O, but got Unknown
		//IL_0ea2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eac: Expected O, but got Unknown
		//IL_0f2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f38: Expected O, but got Unknown
		//IL_0fb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc0: Expected O, but got Unknown
		//IL_1042: Unknown result type (might be due to invalid IL or missing references)
		//IL_104c: Expected O, but got Unknown
		//IL_10ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d8: Expected O, but got Unknown
		//IL_1219: Unknown result type (might be due to invalid IL or missing references)
		//IL_1223: Expected O, but got Unknown
		//IL_1269: Unknown result type (might be due to invalid IL or missing references)
		//IL_1273: Expected O, but got Unknown
		//IL_12b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_12be: Expected O, but got Unknown
		//IL_155d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1567: Expected O, but got Unknown
		//IL_1623: Unknown result type (might be due to invalid IL or missing references)
		//IL_162d: Expected O, but got Unknown
		//IL_16da: Unknown result type (might be due to invalid IL or missing references)
		//IL_16e4: Expected O, but got Unknown
		//IL_1791: Unknown result type (might be due to invalid IL or missing references)
		//IL_179b: Expected O, but got Unknown
		//IL_1848: Unknown result type (might be due to invalid IL or missing references)
		//IL_1852: Expected O, but got Unknown
		//IL_18ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1909: Expected O, but got Unknown
		//IL_19b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_19c1: Expected O, but got Unknown
		//IL_1b05: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b0f: Expected O, but got Unknown
		//IL_1bba: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bc4: Expected O, but got Unknown
		//IL_1c51: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c5b: Expected O, but got Unknown
		//IL_1cf8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d02: Expected O, but got Unknown
		//IL_1e0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e14: Expected O, but got Unknown
		GroupPanel1 = new GroupPanel();
		LabelX1 = new LabelX();
		LabelX3 = new LabelX();
		tbdqid = new TextBoxX();
		cbsddqid = new CheckBoxX();
		lbid = new ListBox();
		lbcsx = new ListBox();
		GroupPanel2 = new GroupPanel();
		LabelX7 = new LabelX();
		LabelX6 = new LabelX();
		LabelX5 = new LabelX();
		LabelX4 = new LabelX();
		LabelX2 = new LabelX();
		lbccmc = new ListBox();
		lbxh = new ListBox();
		lbcsmc = new ListBox();
		lbcsz = new ListBox();
		lbbz = new ListBox();
		STC = new SuperTabControl();
		SuperTabControlPanel1 = new SuperTabControlPanel();
		PictureBox1 = new PictureBox();
		lba = new ListBox();
		SuperTabItem1 = new SuperTabItem();
		SuperTabControlPanel2 = new SuperTabControlPanel();
		lslog = new ListBox();
		SuperTabItem2 = new SuperTabItem();
		lbtplb = new ListBox();
		btncsyz = new ButtonX();
		btntqjl = new ButtonX();
		btnbcjg = new ButtonX();
		btngb = new ButtonX();
		TSL = new LabelX();
		ll_chkbmpfilter = new CheckBoxX();
		LabelX8 = new LabelX();
		xs = new LabelX();
		ll_btncurjmcheck = new ButtonX();
		((Control)GroupPanel1).SuspendLayout();
		((Control)GroupPanel2).SuspendLayout();
		((ISupportInitialize)STC).BeginInit();
		((Control)STC).SuspendLayout();
		((Control)SuperTabControlPanel1).SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)SuperTabControlPanel2).SuspendLayout();
		((Control)this).SuspendLayout();
		((PanelControl)GroupPanel1).set_CanvasColor(SystemColors.Control);
		((PanelControl)GroupPanel1).set_ColorSchemeStyle((eDotNetBarStyle)4);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)LabelX1);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)LabelX3);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)tbdqid);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)cbsddqid);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)lbid);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)lbcsx);
		GroupPanel groupPanel = GroupPanel1;
		Point location = new Point(3, 11);
		((Control)groupPanel).set_Location(location);
		((Control)GroupPanel1).set_Name("GroupPanel1");
		GroupPanel groupPanel2 = GroupPanel1;
		Size size = new Size(187, 230);
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
		((Control)GroupPanel1).set_TabIndex(0);
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX1).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX labelX = LabelX1;
		location = new Point(6, 103);
		((Control)labelX).set_Location(location);
		((Control)LabelX1).set_Name("LabelX1");
		LabelX labelX2 = LabelX1;
		size = new Size(42, 14);
		((Control)labelX2).set_Size(size);
		((Control)LabelX1).set_TabIndex(26);
		LabelX1.set_Text("ID选择");
		((BaseItemControl)LabelX3).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX3).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX3).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX labelX3 = LabelX3;
		location = new Point(6, 0);
		((Control)labelX3).set_Location(location);
		((Control)LabelX3).set_Name("LabelX3");
		LabelX labelX4 = LabelX3;
		size = new Size(168, 14);
		((Control)labelX4).set_Size(size);
		((Control)LabelX3).set_TabIndex(25);
		LabelX3.set_Text("参数页面");
		((TextBoxBase)tbdqid).set_BackColor(SystemColors.AppWorkspace);
		tbdqid.get_Border().set_Class("TextBoxBorder");
		tbdqid.get_Border().set_CornerType((eCornerType)1);
		((TextBoxBase)tbdqid).set_ForeColor(Color.White);
		TextBoxX obj = tbdqid;
		location = new Point(51, 97);
		((Control)obj).set_Location(location);
		((Control)tbdqid).set_Name("tbdqid");
		((TextBoxBase)tbdqid).set_ReadOnly(true);
		TextBoxX obj2 = tbdqid;
		size = new Size(123, 21);
		((Control)obj2).set_Size(size);
		((Control)tbdqid).set_TabIndex(24);
		((Control)cbsddqid).set_BackColor(Color.FromArgb(194, 217, 247));
		((BaseItemControl)cbsddqid).get_BackgroundStyle().set_Class("");
		((BaseItemControl)cbsddqid).get_BackgroundStyle().set_CornerType((eCornerType)1);
		CheckBoxX obj3 = cbsddqid;
		location = new Point(48, 120);
		((Control)obj3).set_Location(location);
		((Control)cbsddqid).set_Name("cbsddqid");
		CheckBoxX obj4 = cbsddqid;
		size = new Size(100, 23);
		((Control)obj4).set_Size(size);
		((BaseItemControl)cbsddqid).set_Style((eDotNetBarStyle)7);
		((Control)cbsddqid).set_TabIndex(2);
		cbsddqid.set_Text("锁定当前ID");
		lbid.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((ListControl)lbid).set_FormattingEnabled(true);
		lbid.set_ItemHeight(12);
		ListBox obj5 = lbid;
		location = new Point(6, 148);
		((Control)obj5).set_Location(location);
		((Control)lbid).set_Name("lbid");
		ListBox obj6 = lbid;
		size = new Size(168, 64);
		((Control)obj6).set_Size(size);
		((Control)lbid).set_TabIndex(1);
		lbcsx.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((ListControl)lbcsx).set_FormattingEnabled(true);
		lbcsx.set_ItemHeight(12);
		ListBox obj7 = lbcsx;
		location = new Point(6, 15);
		((Control)obj7).set_Location(location);
		((Control)lbcsx).set_Name("lbcsx");
		ListBox obj8 = lbcsx;
		size = new Size(168, 76);
		((Control)obj8).set_Size(size);
		((Control)lbcsx).set_TabIndex(0);
		((PanelControl)GroupPanel2).set_CanvasColor(SystemColors.Control);
		((PanelControl)GroupPanel2).set_ColorSchemeStyle((eDotNetBarStyle)4);
		((Control)GroupPanel2).get_Controls().Add((Control)(object)LabelX7);
		((Control)GroupPanel2).get_Controls().Add((Control)(object)LabelX6);
		((Control)GroupPanel2).get_Controls().Add((Control)(object)LabelX5);
		((Control)GroupPanel2).get_Controls().Add((Control)(object)LabelX4);
		((Control)GroupPanel2).get_Controls().Add((Control)(object)LabelX2);
		((Control)GroupPanel2).get_Controls().Add((Control)(object)lbccmc);
		((Control)GroupPanel2).get_Controls().Add((Control)(object)lbxh);
		((Control)GroupPanel2).get_Controls().Add((Control)(object)lbcsmc);
		((Control)GroupPanel2).get_Controls().Add((Control)(object)lbcsz);
		((Control)GroupPanel2).get_Controls().Add((Control)(object)lbbz);
		GroupPanel groupPanel3 = GroupPanel2;
		location = new Point(201, 11);
		((Control)groupPanel3).set_Location(location);
		((Control)GroupPanel2).set_Name("GroupPanel2");
		GroupPanel groupPanel4 = GroupPanel2;
		size = new Size(684, 228);
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
		((Control)GroupPanel2).set_TabIndex(1);
		((Control)LabelX7).set_BackColor(SystemColors.InactiveCaptionText);
		((BaseItemControl)LabelX7).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX7).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX7).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX labelX5 = LabelX7;
		location = new Point(365, 1);
		((Control)labelX5).set_Location(location);
		((Control)LabelX7).set_Name("LabelX7");
		LabelX labelX6 = LabelX7;
		size = new Size(316, 14);
		((Control)labelX6).set_Size(size);
		((Control)LabelX7).set_TabIndex(31);
		LabelX7.set_Text("备注");
		LabelX7.set_TextAlignment((StringAlignment)1);
		((Control)LabelX6).set_BackColor(SystemColors.InactiveCaptionText);
		((BaseItemControl)LabelX6).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX6).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX6).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX labelX7 = LabelX6;
		location = new Point(290, 0);
		((Control)labelX7).set_Location(location);
		((Control)LabelX6).set_Name("LabelX6");
		LabelX labelX8 = LabelX6;
		size = new Size(73, 14);
		((Control)labelX8).set_Size(size);
		((Control)LabelX6).set_TabIndex(30);
		LabelX6.set_Text("尺寸名称");
		LabelX6.set_TextAlignment((StringAlignment)1);
		((Control)LabelX5).set_BackColor(SystemColors.InactiveCaptionText);
		((BaseItemControl)LabelX5).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX5).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX5).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX labelX9 = LabelX5;
		location = new Point(205, 1);
		((Control)labelX9).set_Location(location);
		((Control)LabelX5).set_Name("LabelX5");
		LabelX labelX10 = LabelX5;
		size = new Size(79, 14);
		((Control)labelX10).set_Size(size);
		((Control)LabelX5).set_TabIndex(29);
		LabelX5.set_Text("参数值[双击]");
		LabelX5.set_TextAlignment((StringAlignment)1);
		((Control)LabelX4).set_BackColor(SystemColors.InactiveCaptionText);
		((BaseItemControl)LabelX4).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX4).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX4).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX labelX11 = LabelX4;
		location = new Point(92, 0);
		((Control)labelX11).set_Location(location);
		((Control)LabelX4).set_Name("LabelX4");
		LabelX labelX12 = LabelX4;
		size = new Size(76, 14);
		((Control)labelX12).set_Size(size);
		((Control)LabelX4).set_TabIndex(28);
		LabelX4.set_Text("参数名称");
		LabelX4.set_TextAlignment((StringAlignment)1);
		((Control)LabelX2).set_BackColor(SystemColors.InactiveCaptionText);
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX2).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX labelX13 = LabelX2;
		location = new Point(1, 0);
		((Control)labelX13).set_Location(location);
		((Control)LabelX2).set_Name("LabelX2");
		LabelX labelX14 = LabelX2;
		size = new Size(61, 14);
		((Control)labelX14).set_Size(size);
		((Control)LabelX2).set_TabIndex(27);
		LabelX2.set_Text("序号");
		LabelX2.set_TextAlignment((StringAlignment)1);
		lbccmc.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((ListControl)lbccmc).set_FormattingEnabled(true);
		lbccmc.set_ItemHeight(12);
		ListBox obj9 = lbccmc;
		location = new Point(289, 16);
		((Control)obj9).set_Location(location);
		((Control)lbccmc).set_Name("lbccmc");
		ListBox obj10 = lbccmc;
		size = new Size(75, 196);
		((Control)obj10).set_Size(size);
		((Control)lbccmc).set_TabIndex(17);
		lbxh.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((ListControl)lbxh).set_FormattingEnabled(true);
		lbxh.set_ItemHeight(12);
		ListBox obj11 = lbxh;
		location = new Point(4, 16);
		((Control)obj11).set_Location(location);
		((Control)lbxh).set_Name("lbxh");
		ListBox obj12 = lbxh;
		size = new Size(52, 196);
		((Control)obj12).set_Size(size);
		((Control)lbxh).set_TabIndex(12);
		lbcsmc.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((ListControl)lbcsmc).set_FormattingEnabled(true);
		lbcsmc.set_ItemHeight(12);
		ListBox obj13 = lbcsmc;
		location = new Point(56, 16);
		((Control)obj13).set_Location(location);
		((Control)lbcsmc).set_Name("lbcsmc");
		ListBox obj14 = lbcsmc;
		size = new Size(150, 196);
		((Control)obj14).set_Size(size);
		((Control)lbcsmc).set_TabIndex(13);
		lbcsz.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((ListControl)lbcsz).set_FormattingEnabled(true);
		lbcsz.set_ItemHeight(12);
		ListBox obj15 = lbcsz;
		location = new Point(206, 16);
		((Control)obj15).set_Location(location);
		((Control)lbcsz).set_Name("lbcsz");
		ListBox obj16 = lbcsz;
		size = new Size(83, 196);
		((Control)obj16).set_Size(size);
		((Control)lbcsz).set_TabIndex(14);
		lbbz.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((ListControl)lbbz).set_FormattingEnabled(true);
		lbbz.set_ItemHeight(12);
		ListBox obj17 = lbbz;
		location = new Point(364, 16);
		((Control)obj17).set_Location(location);
		((Control)lbbz).set_Name("lbbz");
		ListBox obj18 = lbbz;
		size = new Size(307, 196);
		((Control)obj18).set_Size(size);
		((Control)lbbz).set_TabIndex(19);
		((BaseItem)STC.get_ControlBox().get_CloseBox()).set_Name("");
		((BaseItem)STC.get_ControlBox().get_MenuBox()).set_Name("");
		((BaseItem)STC.get_ControlBox()).set_Name("");
		((BaseItem)STC.get_ControlBox()).get_SubItems().AddRange((BaseItem[])(object)new BaseItem[2]
		{
			(BaseItem)STC.get_ControlBox().get_MenuBox(),
			(BaseItem)STC.get_ControlBox().get_CloseBox()
		});
		((Control)STC).get_Controls().Add((Control)(object)SuperTabControlPanel2);
		((Control)STC).get_Controls().Add((Control)(object)SuperTabControlPanel1);
		((Control)STC).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		SuperTabControl sTC = STC;
		location = new Point(3, 248);
		((Control)sTC).set_Location(location);
		((Control)STC).set_Name("STC");
		STC.set_ReorderTabsEnabled(true);
		STC.set_SelectedTabFont(new Font("宋体", 9f, (FontStyle)1));
		STC.set_SelectedTabIndex(1);
		SuperTabControl sTC2 = STC;
		size = new Size(656, 333);
		((Control)sTC2).set_Size(size);
		STC.set_TabFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Control)STC).set_TabIndex(22);
		STC.get_Tabs().AddRange((BaseItem[])(object)new BaseItem[2]
		{
			(BaseItem)SuperTabItem1,
			(BaseItem)SuperTabItem2
		});
		((Control)SuperTabControlPanel1).get_Controls().Add((Control)(object)PictureBox1);
		((Control)SuperTabControlPanel1).get_Controls().Add((Control)(object)lba);
		SuperTabControlPanel1.set_Dock((DockStyle)5);
		SuperTabControlPanel superTabControlPanel = SuperTabControlPanel1;
		location = new Point(0, 28);
		((Control)superTabControlPanel).set_Location(location);
		((Control)SuperTabControlPanel1).set_Name("SuperTabControlPanel1");
		SuperTabControlPanel superTabControlPanel2 = SuperTabControlPanel1;
		size = new Size(656, 305);
		((Control)superTabControlPanel2).set_Size(size);
		((Control)SuperTabControlPanel1).set_TabIndex(1);
		SuperTabControlPanel1.set_TabItem(SuperTabItem1);
		((Control)PictureBox1).set_Anchor((AnchorStyles)15);
		((Control)PictureBox1).set_BackgroundImageLayout((ImageLayout)2);
		PictureBox pictureBox = PictureBox1;
		location = new Point(2, 2);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox2 = PictureBox1;
		size = new Size(652, 300);
		((Control)pictureBox2).set_Size(size);
		PictureBox1.set_SizeMode((PictureBoxSizeMode)4);
		PictureBox1.set_TabIndex(1);
		PictureBox1.set_TabStop(false);
		((ListControl)lba).set_FormattingEnabled(true);
		lba.set_ItemHeight(12);
		ListBox obj19 = lba;
		location = new Point(583, -47);
		((Control)obj19).set_Location(location);
		((Control)lba).set_Name("lba");
		ListBox obj20 = lba;
		size = new Size(32, 40);
		((Control)obj20).set_Size(size);
		((Control)lba).set_TabIndex(12);
		SuperTabItem1.set_AttachedControl((Control)(object)SuperTabControlPanel1);
		((BaseItem)SuperTabItem1).set_GlobalItem(false);
		((BaseItem)SuperTabItem1).set_Name("SuperTabItem1");
		SuperTabItem1.set_Text("当前页面尺寸示意图");
		((Control)SuperTabControlPanel2).get_Controls().Add((Control)(object)lslog);
		SuperTabControlPanel2.set_Dock((DockStyle)5);
		SuperTabControlPanel superTabControlPanel3 = SuperTabControlPanel2;
		location = new Point(0, 28);
		((Control)superTabControlPanel3).set_Location(location);
		((Control)SuperTabControlPanel2).set_Name("SuperTabControlPanel2");
		SuperTabControlPanel superTabControlPanel4 = SuperTabControlPanel2;
		size = new Size(656, 305);
		((Control)superTabControlPanel4).set_Size(size);
		((Control)SuperTabControlPanel2).set_TabIndex(2);
		SuperTabControlPanel2.set_TabItem(SuperTabItem2);
		((Control)lslog).set_Dock((DockStyle)2);
		lslog.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((ListControl)lslog).set_FormattingEnabled(true);
		lslog.set_ItemHeight(12);
		ListBox obj21 = lslog;
		location = new Point(0, 1);
		((Control)obj21).set_Location(location);
		((Control)lslog).set_Name("lslog");
		ListBox obj22 = lslog;
		size = new Size(656, 304);
		((Control)obj22).set_Size(size);
		((Control)lslog).set_TabIndex(1);
		SuperTabItem2.set_AttachedControl((Control)(object)SuperTabControlPanel2);
		((BaseItem)SuperTabItem2).set_GlobalItem(false);
		((BaseItem)SuperTabItem2).set_Name("SuperTabItem2");
		SuperTabItem2.set_Text("当前操作记录");
		lbtplb.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((ListControl)lbtplb).set_FormattingEnabled(true);
		lbtplb.set_ItemHeight(12);
		ListBox obj23 = lbtplb;
		location = new Point(678, 265);
		((Control)obj23).set_Location(location);
		((Control)lbtplb).set_Name("lbtplb");
		ListBox obj24 = lbtplb;
		size = new Size(202, 136);
		((Control)obj24).set_Size(size);
		((Control)lbtplb).set_TabIndex(24);
		((Control)btncsyz).set_AccessibleRole((AccessibleRole)43);
		btncsyz.set_ColorTable((eButtonColor)3);
		((Control)btncsyz).set_Enabled(false);
		((Control)btncsyz).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ButtonX obj25 = btncsyz;
		location = new Point(678, 432);
		((Control)obj25).set_Location(location);
		((Control)btncsyz).set_Name("btncsyz");
		ButtonX obj26 = btncsyz;
		size = new Size(202, 27);
		((Control)obj26).set_Size(size);
		((PopupItemControl)btncsyz).set_Style((eDotNetBarStyle)7);
		((Control)btncsyz).set_TabIndex(26);
		btncsyz.set_Text("参数关系必要性验证");
		((Control)btntqjl).set_AccessibleRole((AccessibleRole)43);
		btntqjl.set_ColorTable((eButtonColor)3);
		((Control)btntqjl).set_Enabled(false);
		((Control)btntqjl).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ButtonX obj27 = btntqjl;
		location = new Point(678, 462);
		((Control)obj27).set_Location(location);
		((Control)btntqjl).set_Name("btntqjl");
		ButtonX obj28 = btntqjl;
		size = new Size(202, 27);
		((Control)obj28).set_Size(size);
		((PopupItemControl)btntqjl).set_Style((eDotNetBarStyle)7);
		((Control)btntqjl).set_TabIndex(26);
		btntqjl.set_Text("提取验证结果到记录");
		((Control)btnbcjg).set_AccessibleRole((AccessibleRole)43);
		btnbcjg.set_ColorTable((eButtonColor)3);
		((Control)btnbcjg).set_Enabled(false);
		((Control)btnbcjg).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ButtonX obj29 = btnbcjg;
		location = new Point(678, 523);
		((Control)obj29).set_Location(location);
		((Control)btnbcjg).set_Name("btnbcjg");
		ButtonX obj30 = btnbcjg;
		size = new Size(202, 27);
		((Control)obj30).set_Size(size);
		((PopupItemControl)btnbcjg).set_Style((eDotNetBarStyle)7);
		((Control)btnbcjg).set_TabIndex(26);
		btnbcjg.set_Text("保存截面数据到SET");
		((Control)btngb).set_AccessibleRole((AccessibleRole)43);
		btngb.set_ColorTable((eButtonColor)3);
		btngb.set_DialogResult((DialogResult)2);
		((Control)btngb).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ButtonX obj31 = btngb;
		location = new Point(678, 553);
		((Control)obj31).set_Location(location);
		((Control)btngb).set_Name("btngb");
		ButtonX obj32 = btngb;
		size = new Size(202, 27);
		((Control)obj32).set_Size(size);
		((PopupItemControl)btngb).set_Style((eDotNetBarStyle)7);
		((Control)btngb).set_TabIndex(26);
		btngb.set_Text("关闭当前窗口(ESC)");
		((BaseItemControl)TSL).get_BackgroundStyle().set_Class("");
		((BaseItemControl)TSL).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)TSL).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX tSL = TSL;
		location = new Point(3, 583);
		((Control)tSL).set_Location(location);
		((Control)TSL).set_Name("TSL");
		LabelX tSL2 = TSL;
		size = new Size(258, 15);
		((Control)tSL2).set_Size(size);
		((Control)TSL).set_TabIndex(27);
		((BaseItemControl)ll_chkbmpfilter).get_BackgroundStyle().set_Class("");
		((BaseItemControl)ll_chkbmpfilter).get_BackgroundStyle().set_CornerType((eCornerType)1);
		CheckBoxX obj33 = ll_chkbmpfilter;
		location = new Point(678, 407);
		((Control)obj33).set_Location(location);
		((Control)ll_chkbmpfilter).set_Name("ll_chkbmpfilter");
		CheckBoxX obj34 = ll_chkbmpfilter;
		size = new Size(198, 19);
		((Control)obj34).set_Size(size);
		((BaseItemControl)ll_chkbmpfilter).set_Style((eDotNetBarStyle)7);
		((Control)ll_chkbmpfilter).set_TabIndex(28);
		ll_chkbmpfilter.set_Text("参数示意图过滤");
		((Control)LabelX8).set_BackColor(Color.FromArgb(194, 217, 247));
		((BaseItemControl)LabelX8).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX8).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX8).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX labelX15 = LabelX8;
		location = new Point(741, 247);
		((Control)labelX15).set_Location(location);
		((Control)LabelX8).set_Name("LabelX8");
		LabelX labelX16 = LabelX8;
		size = new Size(65, 14);
		((Control)labelX16).set_Size(size);
		((Control)LabelX8).set_TabIndex(30);
		LabelX8.set_Text("图片列表");
		LabelX8.set_TextAlignment((StringAlignment)1);
		((BaseItemControl)xs).get_BackgroundStyle().set_Class("");
		((BaseItemControl)xs).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)xs).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX obj35 = xs;
		location = new Point(3, 583);
		((Control)obj35).set_Location(location);
		((Control)xs).set_Name("xs");
		LabelX obj36 = xs;
		size = new Size(882, 15);
		((Control)obj36).set_Size(size);
		((Control)xs).set_TabIndex(27);
		((Control)ll_btncurjmcheck).set_AccessibleRole((AccessibleRole)43);
		ll_btncurjmcheck.set_ColorTable((eButtonColor)3);
		((Control)ll_btncurjmcheck).set_Enabled(false);
		((Control)ll_btncurjmcheck).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ButtonX obj37 = ll_btncurjmcheck;
		location = new Point(678, 493);
		((Control)obj37).set_Location(location);
		((Control)ll_btncurjmcheck).set_Name("ll_btncurjmcheck");
		ButtonX obj38 = ll_btncurjmcheck;
		size = new Size(202, 27);
		((Control)obj38).set_Size(size);
		((PopupItemControl)ll_btncurjmcheck).set_Style((eDotNetBarStyle)7);
		((Control)ll_btncurjmcheck).set_TabIndex(26);
		ll_btncurjmcheck.set_Text("当前截面示意图查看");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_CancelButton((IButtonControl)(object)btngb);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		size = new Size(888, 600);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)ll_chkbmpfilter);
		((Control)this).get_Controls().Add((Control)(object)LabelX8);
		((Control)this).get_Controls().Add((Control)(object)xs);
		((Control)this).get_Controls().Add((Control)(object)TSL);
		((Control)this).get_Controls().Add((Control)(object)btngb);
		((Control)this).get_Controls().Add((Control)(object)ll_btncurjmcheck);
		((Control)this).get_Controls().Add((Control)(object)btnbcjg);
		((Control)this).get_Controls().Add((Control)(object)btntqjl);
		((Control)this).get_Controls().Add((Control)(object)btncsyz);
		((Control)this).get_Controls().Add((Control)(object)lbtplb);
		((Control)this).get_Controls().Add((Control)(object)STC);
		((Control)this).get_Controls().Add((Control)(object)GroupPanel2);
		((Control)this).get_Controls().Add((Control)(object)GroupPanel1);
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("cslr");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("参数录入界面");
		((Control)GroupPanel1).ResumeLayout(false);
		((Control)GroupPanel2).ResumeLayout(false);
		((ISupportInitialize)STC).EndInit();
		((Control)STC).ResumeLayout(false);
		((Control)SuperTabControlPanel1).ResumeLayout(false);
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)SuperTabControlPanel2).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void cslr_Load(object sender, EventArgs e)
	{
		((Control)LabelX1).set_BackColor(Color.Transparent);
		((Control)LabelX2).set_BackColor(Color.Transparent);
		((Control)LabelX3).set_BackColor(Color.Transparent);
		((Control)LabelX4).set_BackColor(Color.Transparent);
		((Control)LabelX5).set_BackColor(Color.Transparent);
		((Control)LabelX6).set_BackColor(Color.Transparent);
		((Control)LabelX7).set_BackColor(Color.Transparent);
		try
		{
			STC.set_SelectedTabIndex(0);
			Mod1.excelapp.DisplayAlerts = false;
			if (lbcsx.get_Items().get_Count() == 0)
			{
				if (Operators.CompareString(Mod1.pathh, "", false) != 0)
				{
					Sheets();
					Mod1.filename = Convert.ToString(Mod1.pathh.Substring(checked(Mod1.pathh.LastIndexOf("\\") + 1)));
				}
				if (lbcsx.get_Items().get_Count() != 0)
				{
					lbcsx.set_SelectedIndex(0);
				}
			}
			if (Operators.CompareString(((TextBox)tbdqid).get_Text(), "", false) != 0)
			{
				Mod1.curjmID = ((TextBox)tbdqid).get_Text();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void Sheets()
	{
		lbcsx.get_Items().Clear();
		Mod1.SheetsCount = Mod1.wb.Sheets.Count;
		int sheetsCount = Mod1.SheetsCount;
		for (int i = 1; i <= sheetsCount; i = checked(i + 1))
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(Mod1.wb.Sheets[i], (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"参数校验", false))
			{
				((Control)btncsyz).set_Enabled(true);
			}
			else
			{
				((Control)btncsyz).set_Enabled(false);
			}
			lbcsx.get_Items().Add(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Mod1.wb.Sheets[i], (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null)));
		}
		if (lbcsx.get_Items().get_Count() != 0)
		{
			lbcsx.set_SelectedIndex(0);
		}
	}

	public void Cbmp()
	{
		if (Mod1.excelsheet.Shapes.Count == 0)
		{
			return;
		}
		checked
		{
			int num = Mod1.excelsheet.Shapes.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (File.Exists(Application.get_StartupPath() + "\\Temp\\" + lbcsx.get_Text() + "Picture " + Conversions.ToString(i) + ".gif"))
				{
					continue;
				}
				float num2 = Conversions.ToSingle(NewLateBinding.LateGet(Mod1.excelsheet.Shapes.Cast<object>().ElementAtOrDefault(i), (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null));
				float num3 = Conversions.ToSingle(NewLateBinding.LateGet(Mod1.excelsheet.Shapes.Cast<object>().ElementAtOrDefault(i), (Type)null, "Width", new object[0], (string[])null, (Type[])null, (bool[])null));
				float num4 = Conversions.ToSingle(Operators.DivideObject(NewLateBinding.LateGet(Mod1.excelsheet.Shapes.Cast<object>().ElementAtOrDefault(i), (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null), (object)((Control)PictureBox1).get_Height()));
				float num5 = Conversions.ToSingle(Operators.DivideObject(NewLateBinding.LateGet(Mod1.excelsheet.Shapes.Cast<object>().ElementAtOrDefault(i), (Type)null, "Width", new object[0], (string[])null, (Type[])null, (bool[])null), (object)((Control)PictureBox1).get_Width()));
				bool[] array3;
				if ((num2 < (float)((Control)PictureBox1).get_Height()) & (num3 < (float)((Control)PictureBox1).get_Width()))
				{
					NewLateBinding.LateCall(Mod1.excelsheet.Shapes.Cast<object>().ElementAtOrDefault(i), (Type)null, "Copy", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					object obj = Mod1.excelsheet.ChartObjects(Missing.Value);
					object[] array = new object[4] { 0, 0, num3, num2 };
					object[] array2 = array;
					array3 = new bool[4] { false, false, true, true };
					object obj2 = NewLateBinding.LateGet(obj, (Type)null, "Add", array2, (string[])null, (Type[])null, array3);
					if (array3[2])
					{
						num3 = (float)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[2]), typeof(float));
					}
					if (array3[3])
					{
						num2 = (float)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[3]), typeof(float));
					}
					object obj3 = NewLateBinding.LateGet(obj2, (Type)null, "Chart", new object[0], (string[])null, (Type[])null, (bool[])null);
					NewLateBinding.LateCall(obj3, (Type)null, "Paste", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					NewLateBinding.LateCall(obj3, (Type)null, "Export", new object[2]
					{
						Application.get_StartupPath() + "\\Temp\\" + lbcsx.get_Text() + "Picture " + Conversions.ToString(i) + ".gif",
						"gif"
					}, (string[])null, (Type[])null, (bool[])null, true);
					NewLateBinding.LateCall(NewLateBinding.LateGet(obj3, (Type)null, "Parent", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Delete", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					obj3 = null;
					continue;
				}
				NewLateBinding.LateSetComplex(Mod1.excelsheet.Shapes.Cast<object>().ElementAtOrDefault(i), (Type)null, "LockAspectRatio", new object[1] { MsoTriState.msoTrue }, (string[])null, (Type[])null, false, true);
				float num7;
				float num6;
				if (num4 > num5)
				{
					num6 = ((Control)PictureBox1).get_Height();
					num7 = num3 / num4;
				}
				else
				{
					num7 = ((Control)PictureBox1).get_Width();
					num6 = num2 / num5;
				}
				NewLateBinding.LateCall(Mod1.excelsheet.Shapes.Cast<object>().ElementAtOrDefault(i), (Type)null, "Copy", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				object obj4 = Mod1.excelsheet.ChartObjects(Missing.Value);
				object[] array4 = new object[4] { 0, 0, num7, num6 };
				object[] array5 = array4;
				array3 = new bool[4] { false, false, true, true };
				object obj5 = NewLateBinding.LateGet(obj4, (Type)null, "Add", array5, (string[])null, (Type[])null, array3);
				if (array3[2])
				{
					num7 = (float)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[2]), typeof(float));
				}
				if (array3[3])
				{
					num6 = (float)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[3]), typeof(float));
				}
				object obj6 = NewLateBinding.LateGet(obj5, (Type)null, "Chart", new object[0], (string[])null, (Type[])null, (bool[])null);
				NewLateBinding.LateCall(obj6, (Type)null, "Paste", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(obj6, (Type)null, "Export", new object[2]
				{
					Application.get_StartupPath() + "\\Temp\\" + lbcsx.get_Text() + "Picture " + Conversions.ToString(i) + ".gif",
					"gif"
				}, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(obj6, (Type)null, "Parent", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Delete", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				obj6 = null;
			}
		}
	}

	public void dislplay1()
	{
		lbid.get_Items().Clear();
		Mod1.excelsheet = (Worksheet)Mod1.wb.Sheets.get_Item((object)Mod1.o);
		Mod1.excelsheet.Activate();
		Mod1.lie();
		checked
		{
			if (Operators.CompareString(MyProject.Forms.FrmOf.qyx, "qyxxn", false) == 0)
			{
				int num = Mod1.countL - 1;
				int num2 = 5;
				while (true)
				{
					if (num2 <= num)
					{
						Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[1, num2], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null)));
						if (Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[1, num2], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))), "性能计算ID_temp", false) == 0)
						{
							break;
						}
						num2++;
						continue;
					}
					return;
				}
				lbid.get_Items().Add((object)Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[1, num2], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))));
			}
			else
			{
				int num3 = Mod1.countL - 1;
				for (int num2 = 5; num2 <= num3; num2++)
				{
					Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[1, num2], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null)));
					lbid.get_Items().Add((object)Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[1, num2], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))));
				}
			}
		}
	}

	public void dislplayID()
	{
		lbxh.get_Items().Clear();
		lbcsmc.get_Items().Clear();
		lbcsz.get_Items().Clear();
		lbccmc.get_Items().Clear();
		lbbz.get_Items().Clear();
		Mod1.excelsheet = (Worksheet)Mod1.wb.Sheets.get_Item((object)Mod1.o);
		Mod1.hang(ref Mod1.ba);
		MyProject.Forms.jindu.PB1.set_Maximum(Mod1.countH);
		((Control)MyProject.Forms.jindu).Show();
		xiancheng();
		((Component)(object)MyProject.Forms.jindu).Dispose();
	}

	public void xiancheng()
	{
		int countH = Mod1.countH;
		checked
		{
			int num = default(int);
			for (int i = 2; i <= countH; i++)
			{
				if (Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[i, Mod1.ba], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null))), "1", false) == 0)
				{
					lbxh.get_Items().Add((object)Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[i, 1], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))));
					lbcsmc.get_Items().Add((object)Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[i, 2], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))));
					lbcsz.get_Items().Add((object)Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[i, 3], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))));
					lbccmc.get_Items().Add((object)Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[i, 4], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))));
					lbbz.get_Items().Add((object)Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[i, Mod1.countL], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))));
					lba.get_Items().Add((object)i);
					num++;
					if (num == 20)
					{
						lbxh.Refresh();
						lbcsmc.Refresh();
						lbcsz.Refresh();
						lbccmc.Refresh();
						lbbz.Refresh();
					}
					MyProject.Forms.jindu.PB1.set_Value(i);
				}
			}
		}
	}

	private void lbcsx_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				if (Operators.CompareString(Mod1.str1, lbcsx.get_Text(), false) != 0)
				{
					Mod1.str1 = lbcsx.get_Text();
					id = "";
					lbid.get_Items().Clear();
					lbtplb.get_Items().Clear();
					lbxh.get_Items().Clear();
					lbcsmc.get_Items().Clear();
					lbcsz.get_Items().Clear();
					lbccmc.get_Items().Clear();
					lbbz.get_Items().Clear();
					lba.get_Items().Clear();
					xs.set_Text("当前显示内容为：");
					Mod1.t = 0;
					if (!cbsddqid.get_Checked())
					{
						if (Operators.CompareString(Strings.Trim(lbcsx.get_Text()), "", false) != 0)
						{
							Mod1.o = lbcsx.get_SelectedIndex() + 1;
							dislplay1();
							lbid.set_SelectedIndex(0);
							((TextBox)tbdqid).set_Text(lbid.get_Text());
							filename = Directory.GetFiles(Application.get_StartupPath() + "\\Temp\\", "*.GIF", SearchOption.AllDirectories);
							if (filename.Count() == 0)
							{
								Cbmp();
								filename = Directory.GetFiles(Application.get_StartupPath() + "\\Temp\\", "*.GIF", SearchOption.AllDirectories);
								if (filename.Count() != 0)
								{
									PictureBox1.set_ImageLocation(filename[0].ToString());
								}
								else
								{
									PictureBox1.set_ImageLocation(Application.get_StartupPath() + "\\config\\" + Mod1.bb + "\\ll521.bmp");
								}
							}
							else if (!bj)
							{
								Cbmp();
								filename = Directory.GetFiles(Application.get_StartupPath() + "\\Temp\\", "*.GIF", SearchOption.AllDirectories);
								PictureBox1.set_ImageLocation(Application.get_StartupPath() + "\\config\\" + Mod1.bb + "\\ll521.bmp");
								int num = filename.Count() - 1;
								for (int i = 0; i <= num; i++)
								{
									a = filename[i];
									a = a.Substring(a.LastIndexOf("\\") + 1);
									if (Strings.InStr(a, lbcsx.get_Text() + "Picture", (CompareMethod)0) != 0)
									{
										PictureBox1.set_ImageLocation(filename[i].ToString());
										break;
									}
								}
							}
							Addpic();
						}
					}
					else
					{
						Mod1.o = lbcsx.get_SelectedIndex() + 1;
						dislplay1();
						if (Operators.CompareString(Strings.Trim(lbcsx.get_Text()), "", false) != 0)
						{
							Mod1.lie();
							int num2 = Mod1.countL - 1;
							Mod1.ba = 5;
							while (Mod1.ba <= num2 && Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[1, Mod1.ba], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))), Strings.Trim(((TextBox)tbdqid).get_Text()), false) != 0)
							{
								Mod1.ba++;
							}
							dislplayID();
						}
					}
				}
				if (!ll_chkbmpfilter.get_Checked())
				{
					return;
				}
				if (lbcsmc.get_Items().get_Count() != 0)
				{
					if ((lbxh.get_Items().get_Count() != 0) & (lbcsmc.get_Items().get_Count() != 0) & (lbcsz.get_Items().get_Count() != 0) & (lbccmc.get_Items().get_Count() != 0) & (lbbz.get_Items().get_Count() != 0))
					{
						lbxh.set_SelectedIndex(0);
						lbcsmc.set_SelectedIndex(0);
						lbcsz.set_SelectedIndex(0);
						lbccmc.set_SelectedIndex(0);
						lbbz.set_SelectedIndex(0);
						bmpadd_XN();
					}
				}
				else
				{
					ll_chkbmpfilter.set_Checked(false);
					Interaction.MsgBox((object)"当前参数列表为空.该选项无效！", (MsgBoxStyle)64, (object)"提示");
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void lbxh_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Mod1.index = lbxh.get_SelectedIndex();
			Mod1.TopIndex = lbxh.get_TopIndex();
			if (Mod1.ppp == 0)
			{
				Mod1.uplist();
				if (lbcsmc.get_SelectedIndex() != -1 && ll_chkbmpfilter.get_Checked())
				{
					strcsymname = Strings.Trim(Conversions.ToString(lbcsx.get_Items().get_Item(lbcsx.get_SelectedIndex())));
					strcsfpath = Mod1.path1;
					flisname = strcsfpath + "\\cs\\bmp\\" + strcsymname + "\\" + strcsymname + ".ini";
					if (!File.Exists(flisname))
					{
						Interaction.MsgBox((object)"当前参数库中不存在合法的图片列表文件.该选项无效！", (MsgBoxStyle)64, (object)"提示");
						ll_chkbmpfilter.set_Checked(false);
					}
					else
					{
						bmpadd_XN();
					}
				}
			}
			if (Operators.CompareString(lbxh.get_Text(), "", false) != 0)
			{
				xs.set_Text("当前显示内容为：" + lbxh.get_Text() + "," + lbcsmc.get_Text() + "," + lbcsz.get_Text() + "," + lbccmc.get_Text() + "," + lbbz.get_Text());
				((Control)xs).Refresh();
			}
			else
			{
				xs.set_Text("当前显示内容为空");
				((Control)xs).Refresh();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void lbcsmc_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Mod1.index = lbcsmc.get_SelectedIndex();
			Mod1.TopIndex = lbcsmc.get_TopIndex();
			if (Mod1.ppp == 0)
			{
				Mod1.uplist();
				if (lbcsmc.get_SelectedIndex() != -1 && ll_chkbmpfilter.get_Checked())
				{
					strcsymname = Strings.Trim(Conversions.ToString(lbcsx.get_Items().get_Item(lbcsx.get_SelectedIndex())));
					strcsfpath = Mod1.path1;
					flisname = strcsfpath + "\\cs\\bmp\\" + strcsymname + "\\" + strcsymname + ".ini";
					if (!File.Exists(flisname))
					{
						Interaction.MsgBox((object)"当前参数库中不存在合法的图片列表文件.该选项无效！", (MsgBoxStyle)64, (object)"提示");
						ll_chkbmpfilter.set_Checked(false);
					}
					else
					{
						bmpadd_XN();
					}
				}
			}
			if (Operators.CompareString(lbcsmc.get_Text(), "", false) != 0)
			{
				xs.set_Text("当前显示内容为：" + lbxh.get_Text() + "," + lbcsmc.get_Text() + "," + lbcsz.get_Text() + "," + lbccmc.get_Text() + "," + lbbz.get_Text());
				((Control)xs).Refresh();
			}
			else
			{
				xs.set_Text("当前显示内容为空");
				((Control)xs).Refresh();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void lbcsz_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Mod1.index = lbcsz.get_SelectedIndex();
			Mod1.TopIndex = lbcsz.get_TopIndex();
			if (Mod1.ppp == 0)
			{
				Mod1.uplist();
				if (lbcsmc.get_SelectedIndex() != -1 && ll_chkbmpfilter.get_Checked())
				{
					strcsymname = Strings.Trim(Conversions.ToString(lbcsx.get_Items().get_Item(lbcsx.get_SelectedIndex())));
					strcsfpath = Mod1.path1;
					flisname = strcsfpath + "\\cs\\bmp\\" + strcsymname + "\\" + strcsymname + ".ini";
					if (!File.Exists(flisname))
					{
						Interaction.MsgBox((object)"当前参数库中不存在合法的图片列表文件.该选项无效！", (MsgBoxStyle)64, (object)"提示");
						ll_chkbmpfilter.set_Checked(false);
					}
					else
					{
						bmpadd_XN();
					}
				}
			}
			if ((Operators.CompareString(Mod1.biaoji, "", false) == 0) & (Operators.CompareString(Mod1.biaoji, lbcsz.get_Text(), false) != 0))
			{
				Mod1.biaoji = lbcsz.get_Text();
			}
			if (Operators.CompareString(lbcsz.get_Text(), "", false) != 0)
			{
				xs.set_Text("当前显示内容为：" + lbxh.get_Text() + "," + lbcsmc.get_Text() + "," + lbcsz.get_Text() + "," + lbccmc.get_Text() + "," + lbbz.get_Text());
				((Control)xs).Refresh();
			}
			else
			{
				xs.set_Text("当前显示内容为空");
				((Control)xs).Refresh();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void lbccmc_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		Mod1.index = lbccmc.get_SelectedIndex();
		Mod1.TopIndex = lbccmc.get_TopIndex();
		if (Mod1.ppp == 0)
		{
			Mod1.uplist();
			if (lbcsmc.get_SelectedIndex() != -1 && ll_chkbmpfilter.get_Checked())
			{
				strcsymname = Strings.Trim(Conversions.ToString(lbcsx.get_Items().get_Item(lbcsx.get_SelectedIndex())));
				strcsfpath = Mod1.path1;
				flisname = strcsfpath + "\\cs\\bmp\\" + strcsymname + "\\" + strcsymname + ".ini";
				if (!File.Exists(flisname))
				{
					Interaction.MsgBox((object)"当前参数库中不存在合法的图片列表文件.该选项无效！", (MsgBoxStyle)64, (object)"提示");
					ll_chkbmpfilter.set_Checked(false);
				}
				else
				{
					bmpadd_XN();
				}
			}
		}
		if (Operators.CompareString(lbccmc.get_Text(), "", false) != 0)
		{
			xs.set_Text("当前显示内容为：" + lbxh.get_Text() + "," + lbcsmc.get_Text() + "," + lbcsz.get_Text() + "," + lbccmc.get_Text() + "," + lbbz.get_Text());
			((Control)xs).Refresh();
		}
		else
		{
			xs.set_Text("当前显示内容为空");
			((Control)xs).Refresh();
		}
	}

	private void lbbz_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		Mod1.index = lbbz.get_SelectedIndex();
		Mod1.TopIndex = lbbz.get_TopIndex();
		if (Mod1.ppp == 0)
		{
			xs.set_Text("当前显示内容为：" + lbxh.get_Text() + "," + lbcsmc.get_Text() + "," + lbcsz.get_Text() + "," + lbccmc.get_Text() + "," + lbbz.get_Text());
			((Control)xs).Refresh();
			Mod1.uplist();
			if (lbcsmc.get_SelectedIndex() != -1 && ll_chkbmpfilter.get_Checked())
			{
				strcsymname = Strings.Trim(Conversions.ToString(lbcsx.get_Items().get_Item(lbcsx.get_SelectedIndex())));
				strcsfpath = Mod1.path1;
				flisname = strcsfpath + "\\cs\\bmp\\" + strcsymname + "\\" + strcsymname + ".ini";
				if (!File.Exists(flisname))
				{
					Interaction.MsgBox((object)"当前参数库中不存在合法的图片列表文件.该选项无效！", (MsgBoxStyle)64, (object)"提示");
					ll_chkbmpfilter.set_Checked(false);
				}
				else
				{
					bmpadd_XN();
				}
			}
		}
		if (Operators.CompareString(lbbz.get_Text(), "", false) != 0)
		{
			xs.set_Text("当前显示内容为：" + lbxh.get_Text() + "," + lbcsmc.get_Text() + "," + lbcsz.get_Text() + "," + lbccmc.get_Text() + "," + lbbz.get_Text());
			((Control)xs).Refresh();
		}
		else
		{
			xs.set_Text("当前显示内容为空");
			((Control)xs).Refresh();
		}
	}

	private void lbid_SelectedIndexChanged(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				lba.get_Items().Clear();
				xs.set_Text("");
				if (Operators.CompareString(id, lbid.get_Text(), false) == 0)
				{
					return;
				}
				if (Operators.CompareString(((TextBox)tbdqid).get_Text(), lbid.get_Text(), false) != 0)
				{
					((TextBox)tbdqid).set_Text(lbid.get_Text());
					if (Operators.CompareString(Strings.Trim(lbid.get_Text()), "", false) != 0)
					{
						id = lbid.get_Text();
						((TextBox)tbdqid).set_Text(lbid.get_Text());
						Mod1.curjmID = ((TextBox)tbdqid).get_Text();
						int num = Mod1.countL - 1;
						Mod1.ba = 5;
						while (Mod1.ba <= num && !Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(Mod1.excelsheet.Cells[1, Mod1.ba], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null), (object)lbid.get_Text(), false))
						{
							Mod1.ba++;
						}
						dislplayID();
					}
					return;
				}
				((TextBox)tbdqid).set_Text(lbid.get_Text());
				if (Operators.CompareString(Strings.Trim(lbid.get_Text()), "", false) != 0)
				{
					id = lbid.get_Text();
					((TextBox)tbdqid).set_Text(lbid.get_Text());
					int num2 = Mod1.countL - 1;
					Mod1.ba = 5;
					while (Mod1.ba <= num2 && !Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(Mod1.excelsheet.Cells[1, Mod1.ba], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null), (object)lbid.get_Text(), false))
					{
						Mod1.ba++;
					}
					dislplayID();
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void cbsddqid_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (!@bool)
			{
				@bool = true;
				if (Operators.CompareString(Strings.Trim(lbid.get_Text()), "", false) == 0)
				{
					Interaction.MsgBox((object)"请选择你要锁定的ID！", (MsgBoxStyle)64, (object)"选项不能为空");
					cbsddqid.set_Checked(false);
				}
			}
			else
			{
				@bool = false;
			}
			if (!cbsddqid.get_Checked())
			{
				((TextBox)tbdqid).set_Text("");
				((Control)lbid).set_Enabled(true);
			}
			else
			{
				((Control)lbid).set_Enabled(false);
				((TextBox)tbdqid).set_Text(lbid.get_Text());
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void btngb_Click(object sender, EventArgs e)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Invalid comparison between Unknown and I4
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (!bcscheckok && (int)MessageBox.Show("当前参数关系校验没有通过或没有进行,后续的处理向导操作将被禁止.", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64) == 6)
			{
				lslog.get_Items().Add((object)"当前参数关系校验没有通过或没有进行.后续的操作将被禁止.");
				lslog.get_Items().Clear();
				((Form)this).Close();
				MyProject.Forms.Main.lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员关闭了参数编辑对话框"));
			}
			checked
			{
				if (lslog.get_Items().get_Count() != 0)
				{
					int num = lslog.get_Items().get_Count() - 1;
					for (int i = 0; i <= num; i++)
					{
						MyProject.Forms.Main.lslog.get_Items().Add(RuntimeHelpers.GetObjectValue(lslog.get_Items().get_Item(i)));
					}
					if (!Mod1.Saved)
					{
						Interaction.MsgBox((object)"参数值已被修改，请及时保存！", (MsgBoxStyle)64, (object)"参数修改");
						((Form)this).Close();
					}
				}
				lslog.get_Items().Clear();
				((Form)this).Close();
				MyProject.Forms.Main.lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员关闭了参数编辑对话框"));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void Addpic()
	{
		lbtplb.get_Items().Clear();
		filename = Directory.GetFiles(Application.get_StartupPath() + "\\Temp\\", "*.GIF", SearchOption.AllDirectories);
		if (filename.Count() == 0)
		{
			return;
		}
		checked
		{
			int num = filename.Count() - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = filename[i];
				text = text.Substring(text.LastIndexOf("\\") + 1);
				if (Strings.InStr(text, lbcsx.get_Text() + "Picture", (CompareMethod)0) != 0)
				{
					lbtplb.get_Items().Add((object)text);
					lbtplb.set_SelectedIndex(0);
				}
			}
		}
	}

	private void lbtplb_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (ll_chkbmpfilter.get_Checked())
			{
				strcsymname = Strings.Trim(Conversions.ToString(lbcsx.get_Items().get_Item(lbcsx.get_SelectedIndex())));
				strcsname = Strings.UCase(Strings.Trim(Conversions.ToString(lbcsmc.get_Items().get_Item(lbcsmc.get_SelectedIndex()))));
				fname = Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(string.Concat(string.Concat(strcsfpath + "\\cs", "\\bmp\\"), strcsymname), "\\"), lbtplb.get_Items().get_Item(lbtplb.get_SelectedIndex())));
				if (File.Exists(fname))
				{
					PictureBox1.set_ImageLocation(fname);
				}
				else if (Operators.CompareString(lbtplb.get_Text(), "", false) != 0)
				{
					Interaction.MsgBox((object)"不存在参数示意图文件!", (MsgBoxStyle)64, (object)"图片不存在");
				}
			}
			else if (File.Exists(Application.get_StartupPath() + "\\Temp\\" + lbtplb.get_Text()))
			{
				PictureBox1.set_ImageLocation(Application.get_StartupPath() + "\\Temp\\" + lbtplb.get_Text());
				Mod1.t = lbtplb.get_SelectedIndex();
			}
			else
			{
				Interaction.MsgBox((object)"不存在参数示意图文件!", (MsgBoxStyle)64, (object)"图片不存在");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void PictureBox1_Click(object sender, EventArgs e)
	{
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				if (ll_chkbmpfilter.get_Checked())
				{
					if (lbcsmc.get_Items().get_Count() != 0)
					{
						if (lbtplb.get_Items().get_Count() != 0)
						{
							if (lbtplb.get_SelectedIndex() < lbtplb.get_Items().get_Count() - 1)
							{
								lbtplb.set_SelectedIndex(lbtplb.get_SelectedIndex() + 1);
							}
							else
							{
								lbtplb.set_SelectedIndex(0);
							}
						}
						strcsymname = Strings.Trim(Conversions.ToString(lbcsx.get_Items().get_Item(lbcsx.get_SelectedIndex())));
						strcsname = Strings.UCase(Strings.Trim(Conversions.ToString(lbcsmc.get_Items().get_Item(lbcsmc.get_SelectedIndex()))));
						fname = Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(string.Concat(string.Concat(strcsfpath + "\\cs", "\\bmp\\"), strcsymname), "\\"), lbtplb.get_Items().get_Item(lbtplb.get_SelectedIndex())));
						if (File.Exists(fname))
						{
							PictureBox1.set_ImageLocation(fname);
						}
						else
						{
							Interaction.MsgBox((object)"不存在参数示意图文件!", (MsgBoxStyle)64, (object)"图片不存在");
						}
					}
					else if (lbtplb.get_Items().get_Count() != 0)
					{
						if (lbtplb.get_SelectedIndex() < lbtplb.get_Items().get_Count() - 1)
						{
							lbtplb.set_SelectedIndex(lbtplb.get_SelectedIndex() + 1);
							PictureBox1.set_ImageLocation(Application.get_StartupPath() + "\\Temp\\" + lbtplb.get_Text());
						}
						else
						{
							lbtplb.set_SelectedIndex(0);
						}
					}
					else
					{
						PictureBox1.set_ImageLocation(Application.get_StartupPath() + "\\config\\" + Mod1.bb + "\\ll521.bmp");
					}
				}
				else if (lbtplb.get_Items().get_Count() != 0)
				{
					if (lbtplb.get_SelectedIndex() < lbtplb.get_Items().get_Count() - 1)
					{
						lbtplb.set_SelectedIndex(lbtplb.get_SelectedIndex() + 1);
						PictureBox1.set_ImageLocation(Application.get_StartupPath() + "\\Temp\\" + lbtplb.get_Text());
					}
					else
					{
						lbtplb.set_SelectedIndex(0);
					}
				}
				else
				{
					PictureBox1.set_ImageLocation(Application.get_StartupPath() + "\\config\\" + Mod1.bb + "\\ll521.bmp");
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void lbcsz_DoubleClick(object sender, EventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(lbcsx.get_Text(), "参数校验", false) != 0)
		{
			w = true;
			((TextBox)MyProject.Forms.gxcs.tbycs).set_Text(Strings.Trim(lbcsz.get_Text()));
			while (w)
			{
				((Form)MyProject.Forms.gxcs).ShowDialog();
			}
		}
		else
		{
			Interaction.MsgBox((object)"当前页面为【参数校验】，不允许编辑！", (MsgBoxStyle)64, (object)"参数修改");
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void btncsyz_Click(object sender, EventArgs e)
	{
		if (File.Exists(Application.get_StartupPath() + "\\Temp\\check.ans"))
		{
			FileSystem.Kill(Application.get_StartupPath() + "\\Temp\\check.ans");
		}
		if (File.Exists(Application.get_StartupPath() + "\\Temp\\check.out"))
		{
			FileSystem.Kill(Application.get_StartupPath() + "\\Temp\\check.out");
		}
		if (File.Exists(Application.get_StartupPath() + "\\Temp\\cs.txt"))
		{
			FileSystem.Kill(Application.get_StartupPath() + "\\Temp\\cs.txt");
		}
		if (File.Exists(Application.get_StartupPath() + "\\Temp\\check.inf"))
		{
			FileSystem.Kill(Application.get_StartupPath() + "\\Temp\\check.inf");
		}
		STC.set_SelectedTabIndex(1);
		string text = Strings.Trim(((TextBox)tbdqid).get_Text());
		string text2 = "当前验证的ID:" + text;
		lslog.get_Items().Add((object)text2);
		Mod1.wr = new StreamWriter(cstxt, append: false, Encoding.Default);
		int count = Mod1.wb.Worksheets.Count;
		checked
		{
			IEnumerator enumerator = default(IEnumerator);
			int H = default(int);
			for (int i = 1; i <= count; i++)
			{
				Mod1.excelsheet = (Worksheet)Mod1.wb.Sheets.get_Item((object)i);
				if (!Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectNotEqual(NewLateBinding.LateGet(Mod1.wb.Sheets[i], (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"动参数临时", false), Operators.CompareObjectNotEqual(NewLateBinding.LateGet(Mod1.wb.Sheets[i], (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"参数校验", false))))
				{
					continue;
				}
				bool flag = true;
				try
				{
					enumerator = ((_Worksheet)Mod1.excelsheet).get_Range((object)"1:1", (object)Missing.Value).GetEnumerator();
					while (enumerator.MoveNext())
					{
						Excel.Range range = (Excel.Range)enumerator.Current;
						string text3 = Conversions.ToString(range.get_Value((object)Missing.Value));
						if (Operators.CompareString(Strings.Trim(text3), "", false) != 0)
						{
							if (Operators.CompareString(Strings.UCase(Strings.Trim(text3)), Strings.UCase(Strings.Trim(((TextBox)tbdqid).get_Text())), false) == 0)
							{
								H = range.Column;
								break;
							}
							continue;
						}
						flag = false;
						break;
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				Mod1.hang(ref H);
				if (unchecked(flag && H > 4 && H < 200))
				{
					int countH = Mod1.countH;
					for (int j = 2; j <= countH; j++)
					{
						if (Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[j, H], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))), "1", false) == 0 && ((Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[j, 2], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))), "", false) != 0) & (Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[j, 3], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))), "", false) != 0)))
						{
							Mod1.wr.WriteLine(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[j, 2], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))) + "=" + Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[j, 3], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))));
						}
					}
				}
				Mod1.wr.WriteLine("");
			}
			Mod1.wr.Close();
			Mod1.wr.Dispose();
			lslog.get_Items().Add((object)"输出当前参数到文本文件:[双击可查看当前文件]");
			lslog.get_Items().Add((object)cstxt);
			StreamWriter streamWriter = new StreamWriter(Application.get_StartupPath() + "\\Temp\\check.ans", append: false, Encoding.Default);
			streamWriter.WriteLine("/input," + cstxt);
			streamWriter.WriteLine("*cfopen," + Application.get_StartupPath() + "\\Temp\\check.inf");
			int count2 = Mod1.wb.Worksheets.Count;
			IEnumerator enumerator2 = default(IEnumerator);
			for (int k = 1; k <= count2; k++)
			{
				Mod1.excelsheet = (Worksheet)Mod1.wb.Sheets.get_Item((object)k);
				if (!Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(Mod1.wb.Sheets[k], (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"参数校验", false))
				{
					continue;
				}
				try
				{
					enumerator2 = ((_Worksheet)Mod1.excelsheet).get_Range((object)"1:1", (object)Missing.Value).GetEnumerator();
					while (enumerator2.MoveNext())
					{
						Excel.Range range = (Excel.Range)enumerator2.Current;
						string text3 = Conversions.ToString(range.get_Value((object)Missing.Value));
						if (Operators.CompareString(Strings.UCase(Strings.Trim(text3)), Strings.UCase(Strings.Trim(((TextBox)tbdqid).get_Text())), false) == 0)
						{
							H = range.Column;
							break;
						}
					}
				}
				finally
				{
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
				Mod1.hang(ref H);
				if (unchecked(H > 4 && H < 200))
				{
					int countH2 = Mod1.countH;
					for (int l = 2; l <= countH2; l++)
					{
						if (Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[l, H], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))), "1", false) == 0 && ((Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[l, 2], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))), "", false) != 0) & (Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[l, 3], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))), "", false) != 0) & (Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[l, 4], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))), "", false) != 0)))
						{
							streamWriter.WriteLine("*if," + Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[l, 2], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))) + "," + Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[l, 3], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))) + "," + Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[l, 4], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))) + ",then");
							streamWriter.WriteLine("*cfwrite,/com," + Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[l, Mod1.countL], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))));
							streamWriter.WriteLine("*endif");
						}
					}
				}
				streamWriter.WriteLine("\r\n");
				break;
			}
			streamWriter.WriteLine("*cfclos");
			streamWriter.WriteLine("/exit");
			streamWriter.Close();
			streamWriter.Dispose();
			lslog.get_Items().Add((object)"输出当前参数到文本文件:[双击可查看当前文件]");
			lslog.get_Items().Add((object)(Application.get_StartupPath() + "\\Temp\\check.ans"));
			string text4 = Application.get_StartupPath() + "\\Temp\\check.inf";
			if (File.Exists(text4))
			{
				FileSystem.Kill(text4);
			}
			Interaction.Shell(Application.get_StartupPath() + "\\config\\csCheck.bat " + Application.get_StartupPath() + "\\Temp", (AppWinStyle)2, false, -1);
			text4 = Application.get_StartupPath() + "\\Temp\\check.out";
			text2 = "验证结果见文件:[双击可查看当前文件]";
			lslog.get_Items().Add((object)text2);
			text2 = text4;
			lslog.get_Items().Add((object)text2);
			text4 = Application.get_StartupPath() + "\\Temp\\check.inf";
			text2 = "验证结果见文件:[双击可查看当前文件]";
			lslog.get_Items().Add((object)text2);
			text2 = text4;
			lslog.get_Items().Add((object)text4);
			((Control)btntqjl).set_Enabled(true);
		}
	}

	private void lslog_DoubleClick(object sender, EventArgs e)
	{
		if (File.Exists(lslog.get_Text()))
		{
			Process.Start(Interaction.Environ("windir") + "\\NOTEPAD.EXE", lslog.get_Text());
		}
	}

	private void btntqjl_Click(object sender, EventArgs e)
	{
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		string text = Application.get_StartupPath() + "\\Temp";
		string text2 = "";
		string path = text + "\\check.inf";
		int num = 0;
		if (File.Exists(path))
		{
			Mod1.lr = new StreamReader(path, Encoding.Default);
			while (!Information.IsNothing((object)text2))
			{
				text2 = Mod1.lr.ReadLine();
				if (Information.IsNothing((object)text2))
				{
					break;
				}
				if (Operators.CompareString(text2, "", false) != 0)
				{
					lslog.get_Items().Add((object)text2);
					num = checked(num + 1);
				}
			}
			Mod1.lr.Close();
			Mod1.lr.Dispose();
			if (num >= 1)
			{
				if (Operators.CompareString(Mod1.cswj, "截面i.xls", false) != 0)
				{
					((Control)btnbcjg).set_Enabled(false);
				}
				else
				{
					Mod1.Saved = true;
					((BaseItem)MyProject.Forms.Main.ToolsSave).set_Enabled(false);
				}
				string text3 = "共有" + Conversions.ToString(num) + "条参数关系不合理,请仔细检查录入的参数值.";
				lslog.get_Items().Add((object)text3);
				Interaction.MsgBox((object)(text3 + "详细的不合理信息见操作记录."), (MsgBoxStyle)48, (object)"提示");
				bcscheckok = false;
				((Control)btnbcjg).set_Enabled(false);
			}
			else
			{
				string text3 = "录入的参数值关系经初步检验是合理的.可以尝试进行模型驱动来进一步验证参数的合理性.";
				lslog.get_Items().Add((object)text3);
				if (Operators.CompareString(Mod1.cswj, "截面i.xls", false) != 0)
				{
					((Control)btnbcjg).set_Enabled(false);
					((Control)ll_btncurjmcheck).set_Enabled(false);
				}
				else
				{
					((Control)ll_btncurjmcheck).set_Enabled(true);
					((Control)btnbcjg).set_Enabled(true);
				}
				bcscheckok = true;
				Interaction.MsgBox((object)text3, (MsgBoxStyle)64, (object)"提示");
			}
		}
		else
		{
			lslog.get_Items().Add((object)"结果文件 check.inf 没有生成");
			((Control)ll_btncurjmcheck).set_Enabled(false);
			bcscheckok = false;
			((Control)btnbcjg).set_Enabled(false);
			Mod1.Saved = true;
			((BaseItem)MyProject.Forms.Main.ToolsSave).set_Enabled(false);
		}
	}

	private void btnbcjg_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		if (!bcscheckok)
		{
			Interaction.MsgBox((object)"当前参数校验没有通过,保存操作不能继续.", (MsgBoxStyle)64, (object)"提示");
			lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 当前参数校验没有通过,保存操作不能继续."));
		}
		else
		{
			STC.set_SelectedTabIndex(1);
			((Form)MyProject.Forms.jmsaveinfo).ShowDialog();
		}
	}

	private void lbxh_MouseMove(object sender, MouseEventArgs e)
	{
		try
		{
			Mod1.index = lbxh.get_SelectedIndex();
			Mod1.TopIndex = lbxh.get_TopIndex();
			if (Mod1.ppp == 0)
			{
				Mod1.uplist();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void lbcsmc_MouseMove(object sender, MouseEventArgs e)
	{
		try
		{
			Mod1.index = lbcsmc.get_SelectedIndex();
			Mod1.TopIndex = lbcsmc.get_TopIndex();
			if (Mod1.ppp == 0)
			{
				Mod1.uplist();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void lbcsz_MouseMove(object sender, MouseEventArgs e)
	{
		try
		{
			Mod1.index = lbcsz.get_SelectedIndex();
			Mod1.TopIndex = lbcsz.get_TopIndex();
			if (Mod1.ppp == 0)
			{
				Mod1.uplist();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void lbccmc_MouseMove(object sender, MouseEventArgs e)
	{
		try
		{
			Mod1.index = lbccmc.get_SelectedIndex();
			Mod1.TopIndex = lbccmc.get_TopIndex();
			if (Mod1.ppp == 0)
			{
				Mod1.uplist();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void lbbz_MouseMove(object sender, MouseEventArgs e)
	{
		try
		{
			Mod1.index = lbbz.get_SelectedIndex();
			Mod1.TopIndex = lbbz.get_TopIndex();
			if (Mod1.ppp == 0)
			{
				Mod1.uplist();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void ll_chkbmpfilter_CheckedChanged(object sender, EventArgs e)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (ll_chkbmpfilter.get_Checked())
			{
				if (lbcsmc.get_Items().get_Count() == 0)
				{
					Interaction.MsgBox((object)"当前参数列表为空.该选项无效！", (MsgBoxStyle)64, (object)"提示");
					@checked = true;
					ll_chkbmpfilter.set_Checked(false);
					return;
				}
				strcsymname = Strings.Trim(Conversions.ToString(lbcsx.get_Items().get_Item(lbcsx.get_SelectedIndex())));
				strcsfpath = Mod1.path1;
				flisname = strcsfpath + "\\cs\\bmp\\" + strcsymname + "\\" + strcsymname + ".ini";
				if (!File.Exists(flisname))
				{
					Interaction.MsgBox((object)"当前参数库中不存在合法的图片列表文件.该选项无效！", (MsgBoxStyle)64, (object)"提示");
					@checked = true;
					ll_chkbmpfilter.set_Checked(false);
				}
				else if (lbcsmc.get_SelectedIndex() == -1 && ((lbxh.get_Items().get_Count() != 0) & (lbcsmc.get_Items().get_Count() != 0) & (lbcsz.get_Items().get_Count() != 0) & (lbccmc.get_Items().get_Count() != 0) & (lbbz.get_Items().get_Count() != 0)))
				{
					lbxh.set_SelectedIndex(0);
					lbcsmc.set_SelectedIndex(0);
					lbcsz.set_SelectedIndex(0);
					lbccmc.set_SelectedIndex(0);
					lbbz.set_SelectedIndex(0);
				}
				if ((Operators.CompareString(lbcsmc.get_Text(), "", false) != 0) & ll_chkbmpfilter.get_Checked())
				{
					bmpadd_XN();
					@checked = false;
				}
			}
			else
			{
				if (@checked)
				{
					return;
				}
				filename = Directory.GetFiles(Application.get_StartupPath() + "\\Temp\\", "*.GIF", SearchOption.AllDirectories);
				if (filename.Count() == 0)
				{
					Cbmp();
					filename = Directory.GetFiles(Application.get_StartupPath() + "\\Temp\\", "*.GIF", SearchOption.AllDirectories);
					if (filename.Count() != 0)
					{
						PictureBox1.set_ImageLocation(filename[0].ToString());
					}
					else
					{
						PictureBox1.set_ImageLocation(Application.get_StartupPath() + "\\config\\" + Mod1.bb + "\\ll521.bmp");
					}
				}
				else if (!bj)
				{
					Cbmp();
					filename = Directory.GetFiles(Application.get_StartupPath() + "\\Temp\\", "*.GIF", SearchOption.AllDirectories);
					PictureBox1.set_ImageLocation(Application.get_StartupPath() + "\\config\\" + Mod1.bb + "\\ll521.bmp");
					int num = filename.Count() - 1;
					for (int i = 0; i <= num; i++)
					{
						a = filename[i];
						a = a.Substring(a.LastIndexOf("\\") + 1);
						if (Strings.InStr(a, lbcsx.get_Text() + "Picture", (CompareMethod)0) != 0)
						{
							PictureBox1.set_ImageLocation(filename[i].ToString());
							break;
						}
					}
				}
				Addpic();
			}
		}
	}

	public void bmpadd_XN()
	{
		strcsymname = Strings.Trim(Conversions.ToString(lbcsx.get_Items().get_Item(lbcsx.get_SelectedIndex())));
		string text = Strings.UCase(Strings.Trim(Conversions.ToString(lbcsmc.get_Items().get_Item(lbcsmc.get_SelectedIndex()))));
		strcsfpath = Mod1.path1;
		flisname = strcsfpath + "\\cs\\bmp\\" + strcsymname + "\\" + strcsymname + ".ini";
		Mod1.lr = new StreamReader(flisname, Encoding.Default);
		lbtplb.get_Items().Clear();
		string text2 = strcsymname + "Picture ";
		Mod1.ff = "";
		while (!Information.IsNothing((object)Mod1.ff))
		{
			Mod1.ff = Mod1.lr.ReadLine();
			if (Information.IsNothing((object)Mod1.ff))
			{
				break;
			}
			string[] array = Strings.Split(Mod1.ff, ",", -1, (CompareMethod)0);
			int num = Information.UBound((Array)array, 1);
			if (num == 1)
			{
				int num2 = Strings.InStr(1, text, Strings.UCase(Strings.Trim(array[0])), (CompareMethod)0);
				if (num2 >= 1)
				{
					lbtplb.get_Items().Add((object)(text2 + array[1] + ".gif"));
				}
			}
			if (num != 2)
			{
				continue;
			}
			if (Operators.CompareString(Strings.Trim(array[2]), "", false) == 0)
			{
				array[2] = "0";
			}
			string text3 = Strings.Trim(array[2]);
			if (Operators.CompareString(text3, "0", false) == 0)
			{
				int num2 = Strings.InStr(1, text, Strings.UCase(Strings.Trim(array[0])), (CompareMethod)0);
				if (num2 >= 1)
				{
					lbtplb.get_Items().Add((object)(text2 + array[1] + ".gif"));
				}
			}
			else if (Operators.CompareString(text3, "1", false) == 0)
			{
				int num2 = Strings.InStr(1, text, Strings.UCase(Strings.Trim(array[0])), (CompareMethod)0);
				if (num2 == 1)
				{
					lbtplb.get_Items().Add((object)(text2 + array[1] + ".gif"));
				}
			}
			else
			{
				int num2 = Strings.InStrRev(text, Strings.UCase(Strings.Trim(array[0])), -1, (CompareMethod)0);
				if ((num2 >= 1) & (num2 == checked(Strings.Len(Strings.Trim(text)) - Strings.Len(Strings.Trim(array[0])) + 1)))
				{
					lbtplb.get_Items().Add((object)(text2 + array[1] + ".gif"));
				}
			}
		}
		Mod1.lr.Close();
		Mod1.lr.Dispose();
		if (lbtplb.get_Items().get_Count() == 0)
		{
			PictureBox1.set_ImageLocation(Application.get_StartupPath() + "\\config\\" + Mod1.bb + "\\ll521.bmp");
		}
		else
		{
			lbtplb.set_SelectedIndex(0);
		}
	}

	private void lbcsmc_Click(object sender, EventArgs e)
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		if (lbcsmc.get_SelectedIndex() != -1 && ll_chkbmpfilter.get_Checked())
		{
			strcsymname = Strings.Trim(Conversions.ToString(lbcsx.get_Items().get_Item(lbcsx.get_SelectedIndex())));
			strcsfpath = Mod1.path1;
			flisname = strcsfpath + "\\cs\\bmp\\" + strcsymname + "\\" + strcsymname + ".ini";
			if (!File.Exists(flisname))
			{
				Interaction.MsgBox((object)"当前参数库中不存在合法的图片列表文件.该选项无效！", (MsgBoxStyle)64, (object)"提示");
				ll_chkbmpfilter.set_Checked(false);
			}
			else
			{
				bmpadd_XN();
			}
		}
	}

	private void ll_btncurjmcheck_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		if (!bcscheckok)
		{
			Interaction.MsgBox((object)"当前参数校验没有通过,保存操作不能继续.", (MsgBoxStyle)64, (object)"提示");
			lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 当前参数校验没有通过,保存操作不能继续."));
		}
		else
		{
			STC.set_SelectedTabIndex(1);
			((Form)MyProject.Forms.ll_ufjmcheck).ShowDialog();
			((Component)(object)MyProject.Forms.ll_ufjmcheck).Dispose();
		}
	}

	private void lbcsx_MouseUp(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Invalid comparison between Unknown and I4
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		if ((((int)e.get_Button() == 2097152) & (Operators.CompareString(lbcsx.get_Text(), "动参数2", false) == 0)) && (int)MessageBox.Show("继承 [动参数] 表中的相关参数值到 [动参数2], 是吗?", "提示", (MessageBoxButtons)4, (MessageBoxIcon)64) != 7)
		{
			string text = Application.get_StartupPath() + "\\config\\主臂动参数列表2.ini";
			if (!File.Exists(text))
			{
				Interaction.MsgBox((object)("不存在文件" + text), (MsgBoxStyle)0, (object)"提示");
				return;
			}
			lslog.get_Items().Add((object)"【动参数2】编辑功能启动.即继承来自【动参数】中的参数值.");
			((Form)MyProject.Forms.ll_ufzbdcs2enhance).ShowDialog();
			((Component)(object)MyProject.Forms.ll_ufzbdcs2enhance).Dispose();
		}
	}
}
