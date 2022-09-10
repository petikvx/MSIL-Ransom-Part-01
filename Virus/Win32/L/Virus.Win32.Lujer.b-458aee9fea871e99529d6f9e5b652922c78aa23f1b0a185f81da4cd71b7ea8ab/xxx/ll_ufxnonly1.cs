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
using DevComponents.Editors;
using Excel;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using xxx.My;

namespace xxx;

[DesignerGenerated]
public class ll_ufxnonly1 : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("LabelX1")]
	private LabelX _LabelX1;

	[AccessedThroughProperty("ll_lbzplist")]
	private ListBox _ll_lbzplist;

	[AccessedThroughProperty("MultiPage")]
	private SuperTabControl _MultiPage;

	[AccessedThroughProperty("SuperTabControlPanel1")]
	private SuperTabControlPanel _SuperTabControlPanel1;

	[AccessedThroughProperty("ll_txtnameformat")]
	private TextBoxX _ll_txtnameformat;

	[AccessedThroughProperty("ll_checkLZ")]
	private CheckBoxX _ll_checkLZ;

	[AccessedThroughProperty("ll_txtchai")]
	private IntegerInput _ll_txtchai;

	[AccessedThroughProperty("ll_btnxlsother")]
	private ButtonX _ll_btnxlsother;

	[AccessedThroughProperty("ll_btncheckformat")]
	private ButtonX _ll_btncheckformat;

	[AccessedThroughProperty("ll_btnlcnamecheck")]
	private ButtonX _ll_btnlcnamecheck;

	[AccessedThroughProperty("ll_btnxlsall")]
	private ButtonX _ll_btnxlsall;

	[AccessedThroughProperty("ll_btngenformat")]
	private ButtonX _ll_btngenformat;

	[AccessedThroughProperty("ll_btnnameformat")]
	private ButtonX _ll_btnnameformat;

	[AccessedThroughProperty("ll_lbenamejxformat")]
	private LabelX _ll_lbenamejxformat;

	[AccessedThroughProperty("LabelX3")]
	private LabelX _LabelX3;

	[AccessedThroughProperty("ll_btnfbxnall")]
	private ButtonX _ll_btnfbxnall;

	[AccessedThroughProperty("ll_btnzbxnall")]
	private ButtonX _ll_btnzbxnall;

	[AccessedThroughProperty("ll_btnpicktempxls")]
	private ButtonX _ll_btnpicktempxls;

	[AccessedThroughProperty("ll_lblcnamecheckresult")]
	private ListBox _ll_lblcnamecheckresult;

	[AccessedThroughProperty("ll_lblcnamelist")]
	private ListBox _ll_lblcnamelist;

	[AccessedThroughProperty("ll_lbtempxlslist")]
	private ListBox _ll_lbtempxlslist;

	[AccessedThroughProperty("SuperTabItem1")]
	private SuperTabItem _SuperTabItem1;

	[AccessedThroughProperty("SuperTabControlPanel2")]
	private SuperTabControlPanel _SuperTabControlPanel2;

	[AccessedThroughProperty("ll_pagetemplist")]
	private SuperTabItem _ll_pagetemplist;

	[AccessedThroughProperty("LabelX2")]
	private LabelX _LabelX2;

	[AccessedThroughProperty("ll_txtstruct")]
	private TextBoxX _ll_txtstruct;

	[AccessedThroughProperty("ll_txtcurxti")]
	private TextBoxX _ll_txtcurxti;

	[AccessedThroughProperty("ll_txtzbxt")]
	private TextBoxX _ll_txtzbxt;

	[AccessedThroughProperty("ll_txtfixxt")]
	private TextBoxX _ll_txtfixxt;

	[AccessedThroughProperty("ll_txtfblf")]
	private TextBoxX _ll_txtfblf;

	[AccessedThroughProperty("ll_txtfblz")]
	private TextBoxX _ll_txtfblz;

	[AccessedThroughProperty("LabelX12")]
	private LabelX _LabelX12;

	[AccessedThroughProperty("LabelX11")]
	private LabelX _LabelX11;

	[AccessedThroughProperty("LabelX10")]
	private LabelX _LabelX10;

	[AccessedThroughProperty("ll_lbpzlist")]
	private ListBox _ll_lbpzlist;

	[AccessedThroughProperty("ll_lbztkjlist")]
	private ListBox _ll_lbztkjlist;

	[AccessedThroughProperty("ll_lbnamelist")]
	private ListBox _ll_lbnamelist;

	[AccessedThroughProperty("LabelX9")]
	private LabelX _LabelX9;

	[AccessedThroughProperty("ll_lbxtlist")]
	private ListBox _ll_lbxtlist;

	[AccessedThroughProperty("LabelX8")]
	private LabelX _LabelX8;

	[AccessedThroughProperty("ll_lbzbxtlist")]
	private ListBox _ll_lbzbxtlist;

	[AccessedThroughProperty("LabelX7")]
	private LabelX _LabelX7;

	[AccessedThroughProperty("ll_lbfixxtlist")]
	private ListBox _ll_lbfixxtlist;

	[AccessedThroughProperty("LabelX6")]
	private LabelX _LabelX6;

	[AccessedThroughProperty("ll_lbfblf")]
	private ListBox _ll_lbfblf;

	[AccessedThroughProperty("LabelX4")]
	private LabelX _LabelX4;

	[AccessedThroughProperty("ll_lbfblz")]
	private ListBox _ll_lbfblz;

	[AccessedThroughProperty("SuperTabControlPanel3")]
	private SuperTabControlPanel _SuperTabControlPanel3;

	[AccessedThroughProperty("ll_checkLZqd")]
	private CheckBoxX _ll_checkLZqd;

	[AccessedThroughProperty("ll_lbenamejxformat2")]
	private LabelX _ll_lbenamejxformat2;

	[AccessedThroughProperty("ll_btncheckformat2")]
	private ButtonX _ll_btncheckformat2;

	[AccessedThroughProperty("ll_btnfbxnallqd")]
	private ButtonX _ll_btnfbxnallqd;

	[AccessedThroughProperty("ll_btnzbxnallqd")]
	private ButtonX _ll_btnzbxnallqd;

	[AccessedThroughProperty("ll_btncheckformatandminrf")]
	private ButtonX _ll_btncheckformatandminrf;

	[AccessedThroughProperty("ll_btngenformat2")]
	private ButtonX _ll_btngenformat2;

	[AccessedThroughProperty("ll_btnnameformat2")]
	private ButtonX _ll_btnnameformat2;

	[AccessedThroughProperty("ll_frmminrf")]
	private PanelEx _ll_frmminrf;

	[AccessedThroughProperty("LabelX13")]
	private LabelX _LabelX13;

	[AccessedThroughProperty("ll_btnfromall")]
	private ButtonX _ll_btnfromall;

	[AccessedThroughProperty("ll_btnfromtxt")]
	private ButtonX _ll_btnfromtxt;

	[AccessedThroughProperty("ll_lbcheckminrf2")]
	private ListBox _ll_lbcheckminrf2;

	[AccessedThroughProperty("ll_btntotxt")]
	private ButtonX _ll_btntotxt;

	[AccessedThroughProperty("ll_lbcheckminrf")]
	private ListBox _ll_lbcheckminrf;

	[AccessedThroughProperty("ll_btncheckminrf")]
	private ButtonX _ll_btncheckminrf;

	[AccessedThroughProperty("ll_lbminrflist")]
	private ListBox _ll_lbminrflist;

	[AccessedThroughProperty("ll_txtformat2")]
	private TextBoxX _ll_txtformat2;

	[AccessedThroughProperty("ll_txtnameformat2")]
	private TextBoxX _ll_txtnameformat2;

	[AccessedThroughProperty("ll_txttempxlslist")]
	private TextBoxX _ll_txttempxlslist;

	[AccessedThroughProperty("ll_btnqdfile")]
	private ButtonX _ll_btnqdfile;

	[AccessedThroughProperty("SuperTabItem3")]
	private SuperTabItem _SuperTabItem3;

	[AccessedThroughProperty("LabelProgressTotal")]
	private ProgressBarX _LabelProgressTotal;

	[AccessedThroughProperty("LabelX15")]
	private LabelX _LabelX15;

	[AccessedThroughProperty("LabelX16")]
	private LabelX _LabelX16;

	[AccessedThroughProperty("LabelProgress")]
	private ProgressBarX _LabelProgress;

	[AccessedThroughProperty("LabelX17")]
	private LabelX _LabelX17;

	[AccessedThroughProperty("ll_lbliucheng")]
	private ListBox _ll_lbliucheng;

	[AccessedThroughProperty("btnexit")]
	private ButtonX _btnexit;

	[AccessedThroughProperty("FrameProgressTotal")]
	private LabelX _FrameProgressTotal;

	[AccessedThroughProperty("FrameProgress")]
	private LabelX _FrameProgress;

	[AccessedThroughProperty("LabelX5")]
	private LabelX _LabelX5;

	[AccessedThroughProperty("SuperTabControlPanel4")]
	private SuperTabControlPanel _SuperTabControlPanel4;

	[AccessedThroughProperty("ll_frmfb")]
	private PanelEx _ll_frmfb;

	[AccessedThroughProperty("LabelX14")]
	private LabelX _LabelX14;

	[AccessedThroughProperty("ll_btnfbcheckformat")]
	private ButtonX _ll_btnfbcheckformat;

	[AccessedThroughProperty("ll_btnfbchecklcname")]
	private ButtonX _ll_btnfbchecklcname;

	[AccessedThroughProperty("ll_btnfbgenformat")]
	private ButtonX _ll_btnfbgenformat;

	[AccessedThroughProperty("l_btnfbpicklcname")]
	private ButtonX _l_btnfbpicklcname;

	[AccessedThroughProperty("ll_lbfblcnamelist")]
	private ListBox _ll_lbfblcnamelist;

	[AccessedThroughProperty("ll_lbfblcnamecheckresult")]
	private ListBox _ll_lbfblcnamecheckresult;

	[AccessedThroughProperty("ll_txtfbformat")]
	private TextBoxX _ll_txtfbformat;

	[AccessedThroughProperty("ll_txtfbnameformat")]
	private TextBoxX _ll_txtfbnameformat;

	[AccessedThroughProperty("ll_checkshowdatalist")]
	private CheckBoxX _ll_checkshowdatalist;

	[AccessedThroughProperty("ll_btnfbcsv2tempxls")]
	private ButtonX _ll_btnfbcsv2tempxls;

	[AccessedThroughProperty("ll_btncsv2tempxls")]
	private ButtonX _ll_btncsv2tempxls;

	[AccessedThroughProperty("ll_checkthis")]
	private ButtonX _ll_checkthis;

	[AccessedThroughProperty("ll_btncsvother")]
	private ButtonX _ll_btncsvother;

	[AccessedThroughProperty("ll_btncsvall")]
	private ButtonX _ll_btncsvall;

	[AccessedThroughProperty("ll_lbcheckresult")]
	private ListBox _ll_lbcheckresult;

	[AccessedThroughProperty("ll_lbcsvlist")]
	private ListBox _ll_lbcsvlist;

	[AccessedThroughProperty("ll_txtpath")]
	private TextBoxX _ll_txtpath;

	[AccessedThroughProperty("ll_btnpath")]
	private ButtonX _ll_btnpath;

	[AccessedThroughProperty("SuperTabItem2")]
	private SuperTabItem _SuperTabItem2;

	[AccessedThroughProperty("ll_lbefbnamejxformat")]
	private LabelX _ll_lbefbnamejxformat;

	[AccessedThroughProperty("ll_lbecurxnname")]
	private LabelX _ll_lbecurxnname;

	[AccessedThroughProperty("ll_txtformat")]
	private TextBoxX _ll_txtformat;

	[AccessedThroughProperty("GetOpenFilename")]
	private OpenFileDialog _GetOpenFilename;

	[AccessedThroughProperty("GetSaveAsFilename")]
	private SaveFileDialog _GetSaveAsFilename;

	[AccessedThroughProperty("cbdisplay")]
	private CheckBoxX _cbdisplay;

	private string fname;

	private string[] curlcname;

	private string tempxlspath;

	private string curtempxlsname;

	private bool bhqz;

	private bool bnewxt;

	private string xnxlsname;

	private string xnxlspath;

	private string curstruct;

	private string curstructchname;

	private string curstructpath;

	private bool bpzT;

	private Workbook XLSALL;

	private Workbook XLSTempALL;

	private Worksheet shALL;

	private Worksheet shTemp;

	private bool bpzTglobal;

	private int curtopindexone;

	private int curindexone;

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

	internal virtual ListBox ll_lbzplist
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbzplist;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_lbzplist_DoubleClick;
			if (_ll_lbzplist != null)
			{
				((Control)_ll_lbzplist).remove_DoubleClick(eventHandler);
			}
			_ll_lbzplist = value;
			if (_ll_lbzplist != null)
			{
				((Control)_ll_lbzplist).add_DoubleClick(eventHandler);
			}
		}
	}

	internal virtual SuperTabControl MultiPage
	{
		[DebuggerNonUserCode]
		get
		{
			return _MultiPage;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler<MouseEventArgs> eventHandler = MultiPage_TabStripMouseClick;
			if (_MultiPage != null)
			{
				_MultiPage.remove_TabStripMouseClick(eventHandler);
			}
			_MultiPage = value;
			if (_MultiPage != null)
			{
				_MultiPage.add_TabStripMouseClick(eventHandler);
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

	internal virtual TextBoxX ll_txtnameformat
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_txtnameformat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_txtnameformat = value;
		}
	}

	internal virtual CheckBoxX ll_checkLZ
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_checkLZ;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_checkLZ = value;
		}
	}

	internal virtual IntegerInput ll_txtchai
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_txtchai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_txtchai = value;
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

	internal virtual ButtonX ll_btnlcnamecheck
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnlcnamecheck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnlcnamecheck_Click;
			if (_ll_btnlcnamecheck != null)
			{
				((Control)_ll_btnlcnamecheck).remove_Click(eventHandler);
			}
			_ll_btnlcnamecheck = value;
			if (_ll_btnlcnamecheck != null)
			{
				((Control)_ll_btnlcnamecheck).add_Click(eventHandler);
			}
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

	internal virtual ButtonX ll_btngenformat
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btngenformat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btngenformat_Click;
			if (_ll_btngenformat != null)
			{
				((Control)_ll_btngenformat).remove_Click(eventHandler);
			}
			_ll_btngenformat = value;
			if (_ll_btngenformat != null)
			{
				((Control)_ll_btngenformat).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btnnameformat
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnnameformat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnnameformat_Click;
			if (_ll_btnnameformat != null)
			{
				((Control)_ll_btnnameformat).remove_Click(eventHandler);
			}
			_ll_btnnameformat = value;
			if (_ll_btnnameformat != null)
			{
				((Control)_ll_btnnameformat).add_Click(eventHandler);
			}
		}
	}

	internal virtual LabelX ll_lbenamejxformat
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbenamejxformat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbenamejxformat = value;
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

	internal virtual ButtonX ll_btnfbxnall
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnfbxnall;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnfbxnall_Click;
			if (_ll_btnfbxnall != null)
			{
				((Control)_ll_btnfbxnall).remove_Click(eventHandler);
			}
			_ll_btnfbxnall = value;
			if (_ll_btnfbxnall != null)
			{
				((Control)_ll_btnfbxnall).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btnzbxnall
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnzbxnall;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnzbxnall_Click;
			if (_ll_btnzbxnall != null)
			{
				((Control)_ll_btnzbxnall).remove_Click(eventHandler);
			}
			_ll_btnzbxnall = value;
			if (_ll_btnzbxnall != null)
			{
				((Control)_ll_btnzbxnall).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btnpicktempxls
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnpicktempxls;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnpicktempxls_Click;
			if (_ll_btnpicktempxls != null)
			{
				((Control)_ll_btnpicktempxls).remove_Click(eventHandler);
			}
			_ll_btnpicktempxls = value;
			if (_ll_btnpicktempxls != null)
			{
				((Control)_ll_btnpicktempxls).add_Click(eventHandler);
			}
		}
	}

	internal virtual ListBox ll_lblcnamecheckresult
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lblcnamecheckresult;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_lblcnamecheckresult_SelectedIndexChanged;
			if (_ll_lblcnamecheckresult != null)
			{
				_ll_lblcnamecheckresult.remove_SelectedIndexChanged(eventHandler);
			}
			_ll_lblcnamecheckresult = value;
			if (_ll_lblcnamecheckresult != null)
			{
				_ll_lblcnamecheckresult.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual ListBox ll_lblcnamelist
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lblcnamelist;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_lblcnamelist_SelectedIndexChanged;
			if (_ll_lblcnamelist != null)
			{
				_ll_lblcnamelist.remove_SelectedIndexChanged(eventHandler);
			}
			_ll_lblcnamelist = value;
			if (_ll_lblcnamelist != null)
			{
				_ll_lblcnamelist.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual ListBox ll_lbtempxlslist
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbtempxlslist;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbtempxlslist = value;
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

	internal virtual SuperTabItem ll_pagetemplist
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_pagetemplist;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_pagetemplist = value;
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
			EventHandler eventHandler = ll_txtstruct_TextChanged;
			if (_ll_txtstruct != null)
			{
				((Control)_ll_txtstruct).remove_TextChanged(eventHandler);
			}
			_ll_txtstruct = value;
			if (_ll_txtstruct != null)
			{
				((Control)_ll_txtstruct).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual TextBoxX ll_txtcurxti
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_txtcurxti;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_txtcurxti = value;
		}
	}

	internal virtual TextBoxX ll_txtzbxt
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_txtzbxt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_txtzbxt = value;
		}
	}

	internal virtual TextBoxX ll_txtfixxt
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_txtfixxt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_txtfixxt = value;
		}
	}

	internal virtual TextBoxX ll_txtfblf
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_txtfblf;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_txtfblf = value;
		}
	}

	internal virtual TextBoxX ll_txtfblz
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_txtfblz;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_txtfblz = value;
		}
	}

	internal virtual LabelX LabelX12
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX12 = value;
		}
	}

	internal virtual LabelX LabelX11
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX11 = value;
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

	internal virtual ListBox ll_lbpzlist
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbpzlist;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbpzlist = value;
		}
	}

	internal virtual ListBox ll_lbztkjlist
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbztkjlist;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbztkjlist = value;
		}
	}

	internal virtual ListBox ll_lbnamelist
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbnamelist;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbnamelist = value;
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

	internal virtual ListBox ll_lbxtlist
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbxtlist;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbxtlist = value;
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

	internal virtual ListBox ll_lbzbxtlist
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbzbxtlist;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbzbxtlist = value;
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

	internal virtual ListBox ll_lbfixxtlist
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbfixxtlist;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbfixxtlist = value;
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

	internal virtual ListBox ll_lbfblf
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbfblf;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbfblf = value;
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

	internal virtual ListBox ll_lbfblz
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbfblz;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbfblz = value;
		}
	}

	internal virtual SuperTabControlPanel SuperTabControlPanel3
	{
		[DebuggerNonUserCode]
		get
		{
			return _SuperTabControlPanel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SuperTabControlPanel3 = value;
		}
	}

	internal virtual CheckBoxX ll_checkLZqd
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_checkLZqd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_checkLZqd = value;
		}
	}

	internal virtual LabelX ll_lbenamejxformat2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbenamejxformat2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbenamejxformat2 = value;
		}
	}

	internal virtual ButtonX ll_btncheckformat2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btncheckformat2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btncheckformat2_Click;
			if (_ll_btncheckformat2 != null)
			{
				((Control)_ll_btncheckformat2).remove_Click(eventHandler);
			}
			_ll_btncheckformat2 = value;
			if (_ll_btncheckformat2 != null)
			{
				((Control)_ll_btncheckformat2).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btnfbxnallqd
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnfbxnallqd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnfbxnallqd_Click;
			if (_ll_btnfbxnallqd != null)
			{
				((Control)_ll_btnfbxnallqd).remove_Click(eventHandler);
			}
			_ll_btnfbxnallqd = value;
			if (_ll_btnfbxnallqd != null)
			{
				((Control)_ll_btnfbxnallqd).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btnzbxnallqd
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnzbxnallqd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnzbxnallqd_Click;
			if (_ll_btnzbxnallqd != null)
			{
				((Control)_ll_btnzbxnallqd).remove_Click(eventHandler);
			}
			_ll_btnzbxnallqd = value;
			if (_ll_btnzbxnallqd != null)
			{
				((Control)_ll_btnzbxnallqd).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btncheckformatandminrf
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btncheckformatandminrf;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btncheckformatandminrf_Click;
			if (_ll_btncheckformatandminrf != null)
			{
				((Control)_ll_btncheckformatandminrf).remove_Click(eventHandler);
			}
			_ll_btncheckformatandminrf = value;
			if (_ll_btncheckformatandminrf != null)
			{
				((Control)_ll_btncheckformatandminrf).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btngenformat2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btngenformat2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btngenformat2_Click;
			if (_ll_btngenformat2 != null)
			{
				((Control)_ll_btngenformat2).remove_Click(eventHandler);
			}
			_ll_btngenformat2 = value;
			if (_ll_btngenformat2 != null)
			{
				((Control)_ll_btngenformat2).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btnnameformat2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnnameformat2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnnameformat2_Click;
			if (_ll_btnnameformat2 != null)
			{
				((Control)_ll_btnnameformat2).remove_Click(eventHandler);
			}
			_ll_btnnameformat2 = value;
			if (_ll_btnnameformat2 != null)
			{
				((Control)_ll_btnnameformat2).add_Click(eventHandler);
			}
		}
	}

	internal virtual PanelEx ll_frmminrf
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_frmminrf;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_frmminrf = value;
		}
	}

	internal virtual LabelX LabelX13
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX13 = value;
		}
	}

	internal virtual ButtonX ll_btnfromall
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnfromall;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnfromall_Click;
			if (_ll_btnfromall != null)
			{
				((Control)_ll_btnfromall).remove_Click(eventHandler);
			}
			_ll_btnfromall = value;
			if (_ll_btnfromall != null)
			{
				((Control)_ll_btnfromall).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btnfromtxt
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnfromtxt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnfromtxt_Click;
			if (_ll_btnfromtxt != null)
			{
				((Control)_ll_btnfromtxt).remove_Click(eventHandler);
			}
			_ll_btnfromtxt = value;
			if (_ll_btnfromtxt != null)
			{
				((Control)_ll_btnfromtxt).add_Click(eventHandler);
			}
		}
	}

	internal virtual ListBox ll_lbcheckminrf2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbcheckminrf2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_lbcheckminrf2_SelectedIndexChanged;
			if (_ll_lbcheckminrf2 != null)
			{
				_ll_lbcheckminrf2.remove_SelectedIndexChanged(eventHandler);
			}
			_ll_lbcheckminrf2 = value;
			if (_ll_lbcheckminrf2 != null)
			{
				_ll_lbcheckminrf2.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btntotxt
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btntotxt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btntotxt_Click;
			if (_ll_btntotxt != null)
			{
				((Control)_ll_btntotxt).remove_Click(eventHandler);
			}
			_ll_btntotxt = value;
			if (_ll_btntotxt != null)
			{
				((Control)_ll_btntotxt).add_Click(eventHandler);
			}
		}
	}

	internal virtual ListBox ll_lbcheckminrf
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbcheckminrf;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_lbcheckminrf_SelectedIndexChanged;
			if (_ll_lbcheckminrf != null)
			{
				_ll_lbcheckminrf.remove_SelectedIndexChanged(eventHandler);
			}
			_ll_lbcheckminrf = value;
			if (_ll_lbcheckminrf != null)
			{
				_ll_lbcheckminrf.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btncheckminrf
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btncheckminrf;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btncheckminrf_Click;
			if (_ll_btncheckminrf != null)
			{
				((Control)_ll_btncheckminrf).remove_Click(eventHandler);
			}
			_ll_btncheckminrf = value;
			if (_ll_btncheckminrf != null)
			{
				((Control)_ll_btncheckminrf).add_Click(eventHandler);
			}
		}
	}

	internal virtual ListBox ll_lbminrflist
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbminrflist;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_lbminrflist_SelectedIndexChanged;
			if (_ll_lbminrflist != null)
			{
				_ll_lbminrflist.remove_SelectedIndexChanged(eventHandler);
			}
			_ll_lbminrflist = value;
			if (_ll_lbminrflist != null)
			{
				_ll_lbminrflist.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual TextBoxX ll_txtformat2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_txtformat2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_txtformat2 = value;
		}
	}

	internal virtual TextBoxX ll_txtnameformat2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_txtnameformat2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_txtnameformat2 = value;
		}
	}

	internal virtual TextBoxX ll_txttempxlslist
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_txttempxlslist;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_txttempxlslist = value;
		}
	}

	internal virtual ButtonX ll_btnqdfile
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnqdfile;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnqdfile_Click;
			if (_ll_btnqdfile != null)
			{
				((Control)_ll_btnqdfile).remove_Click(eventHandler);
			}
			_ll_btnqdfile = value;
			if (_ll_btnqdfile != null)
			{
				((Control)_ll_btnqdfile).add_Click(eventHandler);
			}
		}
	}

	internal virtual SuperTabItem SuperTabItem3
	{
		[DebuggerNonUserCode]
		get
		{
			return _SuperTabItem3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SuperTabItem3 = value;
		}
	}

	internal virtual ProgressBarX LabelProgressTotal
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelProgressTotal;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelProgressTotal = value;
		}
	}

	internal virtual LabelX LabelX15
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX15 = value;
		}
	}

	internal virtual LabelX LabelX16
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX16 = value;
		}
	}

	internal virtual ProgressBarX LabelProgress
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelProgress;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelProgress = value;
		}
	}

	internal virtual LabelX LabelX17
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX17 = value;
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

	internal virtual ButtonX btnexit
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnexit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnexit_Click;
			if (_btnexit != null)
			{
				((Control)_btnexit).remove_Click(eventHandler);
			}
			_btnexit = value;
			if (_btnexit != null)
			{
				((Control)_btnexit).add_Click(eventHandler);
			}
		}
	}

	internal virtual LabelX FrameProgressTotal
	{
		[DebuggerNonUserCode]
		get
		{
			return _FrameProgressTotal;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_FrameProgressTotal = value;
		}
	}

	internal virtual LabelX FrameProgress
	{
		[DebuggerNonUserCode]
		get
		{
			return _FrameProgress;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_FrameProgress = value;
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

	internal virtual SuperTabControlPanel SuperTabControlPanel4
	{
		[DebuggerNonUserCode]
		get
		{
			return _SuperTabControlPanel4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SuperTabControlPanel4 = value;
		}
	}

	internal virtual PanelEx ll_frmfb
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

	internal virtual LabelX LabelX14
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX14 = value;
		}
	}

	internal virtual ButtonX ll_btnfbcheckformat
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnfbcheckformat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnfbcheckformat_Click;
			if (_ll_btnfbcheckformat != null)
			{
				((Control)_ll_btnfbcheckformat).remove_Click(eventHandler);
			}
			_ll_btnfbcheckformat = value;
			if (_ll_btnfbcheckformat != null)
			{
				((Control)_ll_btnfbcheckformat).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btnfbchecklcname
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnfbchecklcname;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnfbchecklcname_Click;
			if (_ll_btnfbchecklcname != null)
			{
				((Control)_ll_btnfbchecklcname).remove_Click(eventHandler);
			}
			_ll_btnfbchecklcname = value;
			if (_ll_btnfbchecklcname != null)
			{
				((Control)_ll_btnfbchecklcname).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btnfbgenformat
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnfbgenformat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnfbgenformat_Click;
			if (_ll_btnfbgenformat != null)
			{
				((Control)_ll_btnfbgenformat).remove_Click(eventHandler);
			}
			_ll_btnfbgenformat = value;
			if (_ll_btnfbgenformat != null)
			{
				((Control)_ll_btnfbgenformat).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX l_btnfbpicklcname
	{
		[DebuggerNonUserCode]
		get
		{
			return _l_btnfbpicklcname;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = l_btnfbpicklcname_Click;
			if (_l_btnfbpicklcname != null)
			{
				((Control)_l_btnfbpicklcname).remove_Click(eventHandler);
			}
			_l_btnfbpicklcname = value;
			if (_l_btnfbpicklcname != null)
			{
				((Control)_l_btnfbpicklcname).add_Click(eventHandler);
			}
		}
	}

	internal virtual ListBox ll_lbfblcnamelist
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbfblcnamelist;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_lbfblcnamelist_SelectedIndexChanged;
			if (_ll_lbfblcnamelist != null)
			{
				_ll_lbfblcnamelist.remove_SelectedIndexChanged(eventHandler);
			}
			_ll_lbfblcnamelist = value;
			if (_ll_lbfblcnamelist != null)
			{
				_ll_lbfblcnamelist.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual ListBox ll_lbfblcnamecheckresult
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbfblcnamecheckresult;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_lbfblcnamecheckresult_SelectedIndexChanged;
			if (_ll_lbfblcnamecheckresult != null)
			{
				_ll_lbfblcnamecheckresult.remove_SelectedIndexChanged(eventHandler);
			}
			_ll_lbfblcnamecheckresult = value;
			if (_ll_lbfblcnamecheckresult != null)
			{
				_ll_lbfblcnamecheckresult.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual TextBoxX ll_txtfbformat
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_txtfbformat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_txtfbformat = value;
		}
	}

	internal virtual TextBoxX ll_txtfbnameformat
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_txtfbnameformat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_txtfbnameformat = value;
		}
	}

	internal virtual CheckBoxX ll_checkshowdatalist
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_checkshowdatalist;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_checkshowdatalist_CheckedChanged;
			if (_ll_checkshowdatalist != null)
			{
				_ll_checkshowdatalist.remove_CheckedChanged(eventHandler);
			}
			_ll_checkshowdatalist = value;
			if (_ll_checkshowdatalist != null)
			{
				_ll_checkshowdatalist.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btnfbcsv2tempxls
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnfbcsv2tempxls;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnfbcsv2tempxls_Click;
			if (_ll_btnfbcsv2tempxls != null)
			{
				((Control)_ll_btnfbcsv2tempxls).remove_Click(eventHandler);
			}
			_ll_btnfbcsv2tempxls = value;
			if (_ll_btnfbcsv2tempxls != null)
			{
				((Control)_ll_btnfbcsv2tempxls).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btncsv2tempxls
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btncsv2tempxls;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btncsv2tempxls_Click;
			if (_ll_btncsv2tempxls != null)
			{
				((Control)_ll_btncsv2tempxls).remove_Click(eventHandler);
			}
			_ll_btncsv2tempxls = value;
			if (_ll_btncsv2tempxls != null)
			{
				((Control)_ll_btncsv2tempxls).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_checkthis
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_checkthis;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_checkthis_Click;
			if (_ll_checkthis != null)
			{
				((Control)_ll_checkthis).remove_Click(eventHandler);
			}
			_ll_checkthis = value;
			if (_ll_checkthis != null)
			{
				((Control)_ll_checkthis).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btncsvother
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btncsvother;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btncsvother_Click;
			if (_ll_btncsvother != null)
			{
				((Control)_ll_btncsvother).remove_Click(eventHandler);
			}
			_ll_btncsvother = value;
			if (_ll_btncsvother != null)
			{
				((Control)_ll_btncsvother).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btncsvall
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btncsvall;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btncsvall_Click;
			if (_ll_btncsvall != null)
			{
				((Control)_ll_btncsvall).remove_Click(eventHandler);
			}
			_ll_btncsvall = value;
			if (_ll_btncsvall != null)
			{
				((Control)_ll_btncsvall).add_Click(eventHandler);
			}
		}
	}

	internal virtual ListBox ll_lbcheckresult
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbcheckresult;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbcheckresult = value;
		}
	}

	internal virtual ListBox ll_lbcsvlist
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbcsvlist;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbcsvlist = value;
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

	internal virtual LabelX ll_lbefbnamejxformat
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbefbnamejxformat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbefbnamejxformat = value;
		}
	}

	internal virtual LabelX ll_lbecurxnname
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbecurxnname;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbecurxnname = value;
		}
	}

	internal virtual TextBoxX ll_txtformat
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_txtformat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_txtformat = value;
		}
	}

	internal virtual OpenFileDialog GetOpenFilename
	{
		[DebuggerNonUserCode]
		get
		{
			return _GetOpenFilename;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GetOpenFilename = value;
		}
	}

	internal virtual SaveFileDialog GetSaveAsFilename
	{
		[DebuggerNonUserCode]
		get
		{
			return _GetSaveAsFilename;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GetSaveAsFilename = value;
		}
	}

	internal virtual CheckBoxX cbdisplay
	{
		[DebuggerNonUserCode]
		get
		{
			return _cbdisplay;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cbdisplay_CheckedChanged;
			if (_cbdisplay != null)
			{
				_cbdisplay.remove_CheckedChanged(eventHandler);
			}
			_cbdisplay = value;
			if (_cbdisplay != null)
			{
				_cbdisplay.add_CheckedChanged(eventHandler);
			}
		}
	}

	[DebuggerNonUserCode]
	public ll_ufxnonly1()
	{
		((Form)this).add_Load((EventHandler)ll_ufxnonly1_Load);
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
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected O, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected O, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected O, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected O, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected O, but got Unknown
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected O, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected O, but got Unknown
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected O, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected O, but got Unknown
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected O, but got Unknown
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected O, but got Unknown
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected O, but got Unknown
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected O, but got Unknown
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected O, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected O, but got Unknown
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected O, but got Unknown
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected O, but got Unknown
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected O, but got Unknown
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected O, but got Unknown
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected O, but got Unknown
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected O, but got Unknown
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Expected O, but got Unknown
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected O, but got Unknown
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Expected O, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected O, but got Unknown
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected O, but got Unknown
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected O, but got Unknown
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected O, but got Unknown
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Expected O, but got Unknown
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected O, but got Unknown
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Expected O, but got Unknown
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected O, but got Unknown
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected O, but got Unknown
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Expected O, but got Unknown
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected O, but got Unknown
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Expected O, but got Unknown
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Expected O, but got Unknown
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected O, but got Unknown
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Expected O, but got Unknown
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Expected O, but got Unknown
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_0483: Expected O, but got Unknown
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected O, but got Unknown
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0499: Expected O, but got Unknown
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Expected O, but got Unknown
		//IL_0722: Unknown result type (might be due to invalid IL or missing references)
		//IL_072c: Expected O, but got Unknown
		//IL_076c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0776: Expected O, but got Unknown
		//IL_425f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4269: Expected O, but got Unknown
		//IL_43b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_43be: Expected O, but got Unknown
		LabelX1 = new LabelX();
		ll_lbzplist = new ListBox();
		MultiPage = new SuperTabControl();
		SuperTabControlPanel4 = new SuperTabControlPanel();
		ll_frmfb = new PanelEx();
		ll_lbefbnamejxformat = new LabelX();
		LabelX14 = new LabelX();
		ll_btnfbcheckformat = new ButtonX();
		ll_btnfbchecklcname = new ButtonX();
		ll_btnfbgenformat = new ButtonX();
		l_btnfbpicklcname = new ButtonX();
		ll_lbfblcnamelist = new ListBox();
		ll_lbfblcnamecheckresult = new ListBox();
		ll_txtfbformat = new TextBoxX();
		ll_txtfbnameformat = new TextBoxX();
		ll_btnfbcsv2tempxls = new ButtonX();
		ll_btncsv2tempxls = new ButtonX();
		ll_checkthis = new ButtonX();
		ll_btncsvother = new ButtonX();
		ll_btncsvall = new ButtonX();
		ll_lbcheckresult = new ListBox();
		ll_lbcsvlist = new ListBox();
		ll_txtpath = new TextBoxX();
		ll_btnpath = new ButtonX();
		SuperTabItem2 = new SuperTabItem();
		SuperTabControlPanel3 = new SuperTabControlPanel();
		ll_checkLZqd = new CheckBoxX();
		ll_lbenamejxformat2 = new LabelX();
		ll_btncheckformat2 = new ButtonX();
		ll_btnfbxnallqd = new ButtonX();
		ll_btnzbxnallqd = new ButtonX();
		ll_btncheckformatandminrf = new ButtonX();
		ll_btngenformat2 = new ButtonX();
		ll_btnnameformat2 = new ButtonX();
		ll_frmminrf = new PanelEx();
		LabelX13 = new LabelX();
		ll_btnfromall = new ButtonX();
		ll_btnfromtxt = new ButtonX();
		ll_lbcheckminrf2 = new ListBox();
		ll_btntotxt = new ButtonX();
		ll_lbcheckminrf = new ListBox();
		ll_btncheckminrf = new ButtonX();
		ll_lbminrflist = new ListBox();
		ll_txtformat2 = new TextBoxX();
		ll_txtnameformat2 = new TextBoxX();
		ll_txttempxlslist = new TextBoxX();
		ll_btnqdfile = new ButtonX();
		SuperTabItem3 = new SuperTabItem();
		SuperTabControlPanel1 = new SuperTabControlPanel();
		ll_txtformat = new TextBoxX();
		ll_txtnameformat = new TextBoxX();
		ll_checkLZ = new CheckBoxX();
		ll_txtchai = new IntegerInput();
		ll_btnxlsother = new ButtonX();
		ll_btncheckformat = new ButtonX();
		ll_btnlcnamecheck = new ButtonX();
		ll_btnxlsall = new ButtonX();
		ll_btngenformat = new ButtonX();
		ll_btnnameformat = new ButtonX();
		ll_lbenamejxformat = new LabelX();
		LabelX3 = new LabelX();
		ll_btnfbxnall = new ButtonX();
		ll_btnzbxnall = new ButtonX();
		ll_btnpicktempxls = new ButtonX();
		ll_lblcnamecheckresult = new ListBox();
		ll_lblcnamelist = new ListBox();
		ll_lbtempxlslist = new ListBox();
		SuperTabItem1 = new SuperTabItem();
		SuperTabControlPanel2 = new SuperTabControlPanel();
		ll_txtcurxti = new TextBoxX();
		ll_txtzbxt = new TextBoxX();
		ll_txtfixxt = new TextBoxX();
		ll_txtfblf = new TextBoxX();
		ll_txtfblz = new TextBoxX();
		LabelX12 = new LabelX();
		LabelX5 = new LabelX();
		LabelX11 = new LabelX();
		LabelX10 = new LabelX();
		ll_lbpzlist = new ListBox();
		ll_lbztkjlist = new ListBox();
		ll_lbnamelist = new ListBox();
		LabelX9 = new LabelX();
		ll_lbxtlist = new ListBox();
		LabelX8 = new LabelX();
		ll_lbzbxtlist = new ListBox();
		LabelX7 = new LabelX();
		ll_lbfixxtlist = new ListBox();
		LabelX6 = new LabelX();
		ll_lbfblf = new ListBox();
		LabelX4 = new LabelX();
		ll_lbfblz = new ListBox();
		ll_pagetemplist = new SuperTabItem();
		ll_checkshowdatalist = new CheckBoxX();
		LabelX2 = new LabelX();
		ll_txtstruct = new TextBoxX();
		LabelProgressTotal = new ProgressBarX();
		LabelX15 = new LabelX();
		LabelX16 = new LabelX();
		LabelProgress = new ProgressBarX();
		LabelX17 = new LabelX();
		ll_lbliucheng = new ListBox();
		btnexit = new ButtonX();
		FrameProgressTotal = new LabelX();
		FrameProgress = new LabelX();
		ll_lbecurxnname = new LabelX();
		GetOpenFilename = new OpenFileDialog();
		GetSaveAsFilename = new SaveFileDialog();
		cbdisplay = new CheckBoxX();
		((ISupportInitialize)MultiPage).BeginInit();
		((Control)MultiPage).SuspendLayout();
		((Control)SuperTabControlPanel4).SuspendLayout();
		((Control)ll_frmfb).SuspendLayout();
		((Control)SuperTabControlPanel3).SuspendLayout();
		((Control)ll_frmminrf).SuspendLayout();
		((Control)SuperTabControlPanel1).SuspendLayout();
		((ISupportInitialize)ll_txtchai).BeginInit();
		((Control)SuperTabControlPanel2).SuspendLayout();
		((Control)this).SuspendLayout();
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX = LabelX1;
		Point location = new Point(8, 0);
		((Control)labelX).set_Location(location);
		((Control)LabelX1).set_Name("LabelX1");
		LabelX labelX2 = LabelX1;
		Size size = new Size(139, 23);
		((Control)labelX2).set_Size(size);
		((Control)LabelX1).set_TabIndex(0);
		LabelX1.set_Text("结构形式[双击选定]");
		((ListControl)ll_lbzplist).set_FormattingEnabled(true);
		ll_lbzplist.set_ItemHeight(12);
		ListBox obj = ll_lbzplist;
		location = new Point(8, 29);
		((Control)obj).set_Location(location);
		((Control)ll_lbzplist).set_Name("ll_lbzplist");
		ListBox obj2 = ll_lbzplist;
		size = new Size(124, 304);
		((Control)obj2).set_Size(size);
		((Control)ll_lbzplist).set_TabIndex(1);
		((BaseItem)MultiPage.get_ControlBox().get_CloseBox()).set_Name("");
		((BaseItem)MultiPage.get_ControlBox().get_MenuBox()).set_Name("");
		((BaseItem)MultiPage.get_ControlBox()).set_Name("");
		((BaseItem)MultiPage.get_ControlBox()).get_SubItems().AddRange((BaseItem[])(object)new BaseItem[2]
		{
			(BaseItem)MultiPage.get_ControlBox().get_MenuBox(),
			(BaseItem)MultiPage.get_ControlBox().get_CloseBox()
		});
		((Control)MultiPage).get_Controls().Add((Control)(object)SuperTabControlPanel4);
		((Control)MultiPage).get_Controls().Add((Control)(object)SuperTabControlPanel1);
		((Control)MultiPage).get_Controls().Add((Control)(object)SuperTabControlPanel3);
		((Control)MultiPage).get_Controls().Add((Control)(object)SuperTabControlPanel2);
		SuperTabControl multiPage = MultiPage;
		location = new Point(137, 31);
		((Control)multiPage).set_Location(location);
		((Control)MultiPage).set_Name("MultiPage");
		MultiPage.set_ReorderTabsEnabled(true);
		MultiPage.set_SelectedTabFont(new Font("宋体", 9f, (FontStyle)1));
		MultiPage.set_SelectedTabIndex(0);
		SuperTabControl multiPage2 = MultiPage;
		size = new Size(842, 303);
		((Control)multiPage2).set_Size(size);
		MultiPage.set_TabFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Control)MultiPage).set_TabIndex(2);
		MultiPage.get_Tabs().AddRange((BaseItem[])(object)new BaseItem[4]
		{
			(BaseItem)SuperTabItem2,
			(BaseItem)SuperTabItem1,
			(BaseItem)ll_pagetemplist,
			(BaseItem)SuperTabItem3
		});
		((Control)SuperTabControlPanel4).get_Controls().Add((Control)(object)ll_frmfb);
		((Control)SuperTabControlPanel4).get_Controls().Add((Control)(object)ll_btnfbcsv2tempxls);
		((Control)SuperTabControlPanel4).get_Controls().Add((Control)(object)ll_btncsv2tempxls);
		((Control)SuperTabControlPanel4).get_Controls().Add((Control)(object)ll_checkthis);
		((Control)SuperTabControlPanel4).get_Controls().Add((Control)(object)ll_btncsvother);
		((Control)SuperTabControlPanel4).get_Controls().Add((Control)(object)ll_btncsvall);
		((Control)SuperTabControlPanel4).get_Controls().Add((Control)(object)ll_lbcheckresult);
		((Control)SuperTabControlPanel4).get_Controls().Add((Control)(object)ll_lbcsvlist);
		((Control)SuperTabControlPanel4).get_Controls().Add((Control)(object)ll_txtpath);
		((Control)SuperTabControlPanel4).get_Controls().Add((Control)(object)ll_btnpath);
		SuperTabControlPanel4.set_Dock((DockStyle)5);
		SuperTabControlPanel superTabControlPanel = SuperTabControlPanel4;
		location = new Point(0, 28);
		((Control)superTabControlPanel).set_Location(location);
		((Control)SuperTabControlPanel4).set_Name("SuperTabControlPanel4");
		SuperTabControlPanel superTabControlPanel2 = SuperTabControlPanel4;
		size = new Size(842, 275);
		((Control)superTabControlPanel2).set_Size(size);
		((Control)SuperTabControlPanel4).set_TabIndex(3);
		SuperTabControlPanel4.set_TabItem(SuperTabItem2);
		ll_frmfb.set_CanvasColor(SystemColors.Control);
		ll_frmfb.set_ColorSchemeStyle((eDotNetBarStyle)7);
		((Control)ll_frmfb).get_Controls().Add((Control)(object)ll_lbefbnamejxformat);
		((Control)ll_frmfb).get_Controls().Add((Control)(object)LabelX14);
		((Control)ll_frmfb).get_Controls().Add((Control)(object)ll_btnfbcheckformat);
		((Control)ll_frmfb).get_Controls().Add((Control)(object)ll_btnfbchecklcname);
		((Control)ll_frmfb).get_Controls().Add((Control)(object)ll_btnfbgenformat);
		((Control)ll_frmfb).get_Controls().Add((Control)(object)l_btnfbpicklcname);
		((Control)ll_frmfb).get_Controls().Add((Control)(object)ll_lbfblcnamelist);
		((Control)ll_frmfb).get_Controls().Add((Control)(object)ll_lbfblcnamecheckresult);
		((Control)ll_frmfb).get_Controls().Add((Control)(object)ll_txtfbformat);
		((Control)ll_frmfb).get_Controls().Add((Control)(object)ll_txtfbnameformat);
		PanelEx obj3 = ll_frmfb;
		location = new Point(427, 5);
		((Control)obj3).set_Location(location);
		((Control)ll_frmfb).set_Name("ll_frmfb");
		PanelEx obj4 = ll_frmfb;
		size = new Size(409, 264);
		((Control)obj4).set_Size(size);
		ll_frmfb.get_Style().set_Alignment((StringAlignment)1);
		ll_frmfb.get_Style().get_BackColor1().set_ColorSchemePart((eColorSchemePart)51);
		ll_frmfb.get_Style().get_BackColor2().set_ColorSchemePart((eColorSchemePart)52);
		ll_frmfb.get_Style().set_Border((eBorderType)1);
		ll_frmfb.get_Style().get_BorderColor().set_ColorSchemePart((eColorSchemePart)53);
		ll_frmfb.get_Style().get_ForeColor().set_ColorSchemePart((eColorSchemePart)54);
		ll_frmfb.get_Style().set_GradientAngle(90);
		((Control)ll_frmfb).set_TabIndex(4);
		((BaseItemControl)ll_lbefbnamejxformat).get_BackgroundStyle().set_Class("");
		((BaseItemControl)ll_lbefbnamejxformat).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX obj5 = ll_lbefbnamejxformat;
		location = new Point(20, 233);
		((Control)obj5).set_Location(location);
		((Control)ll_lbefbnamejxformat).set_Name("ll_lbefbnamejxformat");
		LabelX obj6 = ll_lbefbnamejxformat;
		size = new Size(375, 25);
		((Control)obj6).set_Size(size);
		((Control)ll_lbefbnamejxformat).set_TabIndex(0);
		((BaseItemControl)LabelX14).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX14).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX3 = LabelX14;
		location = new Point(19, 9);
		((Control)labelX3).set_Location(location);
		((Control)LabelX14).set_Name("LabelX14");
		LabelX labelX4 = LabelX14;
		size = new Size(75, 16);
		((Control)labelX4).set_Size(size);
		((Control)LabelX14).set_TabIndex(0);
		LabelX14.set_Text("副臂选项");
		((Control)ll_btnfbcheckformat).set_AccessibleRole((AccessibleRole)43);
		ll_btnfbcheckformat.set_ColorTable((eButtonColor)3);
		ButtonX obj7 = ll_btnfbcheckformat;
		location = new Point(226, 178);
		((Control)obj7).set_Location(location);
		((Control)ll_btnfbcheckformat).set_Name("ll_btnfbcheckformat");
		ButtonX obj8 = ll_btnfbcheckformat;
		size = new Size(169, 23);
		((Control)obj8).set_Size(size);
		((PopupItemControl)ll_btnfbcheckformat).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnfbcheckformat).set_TabIndex(2);
		ll_btnfbcheckformat.set_Text("检查解析格式正确性");
		((Control)ll_btnfbchecklcname).set_AccessibleRole((AccessibleRole)43);
		ll_btnfbchecklcname.set_ColorTable((eButtonColor)3);
		ButtonX obj9 = ll_btnfbchecklcname;
		location = new Point(226, 27);
		((Control)obj9).set_Location(location);
		((Control)ll_btnfbchecklcname).set_Name("ll_btnfbchecklcname");
		ButtonX obj10 = ll_btnfbchecklcname;
		size = new Size(169, 23);
		((Control)obj10).set_Size(size);
		((PopupItemControl)ll_btnfbchecklcname).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnfbchecklcname).set_TabIndex(2);
		ll_btnfbchecklcname.set_Text("检查工况名称格式的一致性");
		((Control)ll_btnfbgenformat).set_AccessibleRole((AccessibleRole)43);
		ll_btnfbgenformat.set_ColorTable((eButtonColor)3);
		ButtonX obj11 = ll_btnfbgenformat;
		location = new Point(19, 178);
		((Control)obj11).set_Location(location);
		((Control)ll_btnfbgenformat).set_Name("ll_btnfbgenformat");
		ButtonX obj12 = ll_btnfbgenformat;
		size = new Size(169, 23);
		((Control)obj12).set_Size(size);
		((PopupItemControl)ll_btnfbgenformat).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnfbgenformat).set_TabIndex(2);
		ll_btnfbgenformat.set_Text("指定解析格式");
		((Control)l_btnfbpicklcname).set_AccessibleRole((AccessibleRole)43);
		l_btnfbpicklcname.set_ColorTable((eButtonColor)3);
		ButtonX obj13 = l_btnfbpicklcname;
		location = new Point(19, 28);
		((Control)obj13).set_Location(location);
		((Control)l_btnfbpicklcname).set_Name("l_btnfbpicklcname");
		ButtonX obj14 = l_btnfbpicklcname;
		size = new Size(169, 23);
		((Control)obj14).set_Size(size);
		((PopupItemControl)l_btnfbpicklcname).set_Style((eDotNetBarStyle)7);
		((Control)l_btnfbpicklcname).set_TabIndex(2);
		l_btnfbpicklcname.set_Text("提取工况名称格式");
		((ListControl)ll_lbfblcnamelist).set_FormattingEnabled(true);
		ll_lbfblcnamelist.set_ItemHeight(12);
		ListBox obj15 = ll_lbfblcnamelist;
		location = new Point(19, 56);
		((Control)obj15).set_Location(location);
		((Control)ll_lbfblcnamelist).set_Name("ll_lbfblcnamelist");
		ListBox obj16 = ll_lbfblcnamelist;
		size = new Size(296, 88);
		((Control)obj16).set_Size(size);
		((Control)ll_lbfblcnamelist).set_TabIndex(1);
		((ListControl)ll_lbfblcnamecheckresult).set_FormattingEnabled(true);
		ll_lbfblcnamecheckresult.set_ItemHeight(12);
		ListBox obj17 = ll_lbfblcnamecheckresult;
		location = new Point(321, 56);
		((Control)obj17).set_Location(location);
		((Control)ll_lbfblcnamecheckresult).set_Name("ll_lbfblcnamecheckresult");
		ListBox obj18 = ll_lbfblcnamecheckresult;
		size = new Size(74, 88);
		((Control)obj18).set_Size(size);
		((Control)ll_lbfblcnamecheckresult).set_TabIndex(1);
		ll_txtfbformat.get_Border().set_Class("TextBoxBorder");
		ll_txtfbformat.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj19 = ll_txtfbformat;
		location = new Point(19, 207);
		((Control)obj19).set_Location(location);
		((Control)ll_txtfbformat).set_Name("ll_txtfbformat");
		((TextBoxBase)ll_txtfbformat).set_ReadOnly(true);
		TextBoxX obj20 = ll_txtfbformat;
		size = new Size(376, 21);
		((Control)obj20).set_Size(size);
		((Control)ll_txtfbformat).set_TabIndex(0);
		ll_txtfbnameformat.get_Border().set_Class("TextBoxBorder");
		ll_txtfbnameformat.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj21 = ll_txtfbnameformat;
		location = new Point(19, 151);
		((Control)obj21).set_Location(location);
		((Control)ll_txtfbnameformat).set_Name("ll_txtfbnameformat");
		((TextBoxBase)ll_txtfbnameformat).set_ReadOnly(true);
		TextBoxX obj22 = ll_txtfbnameformat;
		size = new Size(376, 21);
		((Control)obj22).set_Size(size);
		((Control)ll_txtfbnameformat).set_TabIndex(0);
		((Control)ll_btnfbcsv2tempxls).set_AccessibleRole((AccessibleRole)43);
		ll_btnfbcsv2tempxls.set_ColorTable((eButtonColor)3);
		ButtonX obj23 = ll_btnfbcsv2tempxls;
		location = new Point(15, 239);
		((Control)obj23).set_Location(location);
		((Control)ll_btnfbcsv2tempxls).set_Name("ll_btnfbcsv2tempxls");
		ButtonX obj24 = ll_btnfbcsv2tempxls;
		size = new Size(289, 23);
		((Control)obj24).set_Size(size);
		((PopupItemControl)ll_btnfbcsv2tempxls).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnfbcsv2tempxls).set_TabIndex(2);
		ll_btnfbcsv2tempxls.set_Text("副臂下 基本csv文件 -> 基本xls文件");
		((Control)ll_btncsv2tempxls).set_AccessibleRole((AccessibleRole)43);
		ll_btncsv2tempxls.set_ColorTable((eButtonColor)3);
		ButtonX obj25 = ll_btncsv2tempxls;
		location = new Point(15, 212);
		((Control)obj25).set_Location(location);
		((Control)ll_btncsv2tempxls).set_Name("ll_btncsv2tempxls");
		ButtonX obj26 = ll_btncsv2tempxls;
		size = new Size(289, 23);
		((Control)obj26).set_Size(size);
		((PopupItemControl)ll_btncsv2tempxls).set_Style((eDotNetBarStyle)7);
		((Control)ll_btncsv2tempxls).set_TabIndex(2);
		ll_btncsv2tempxls.set_Text("主臂下 基本csv文件 -> 基本xls文件");
		((Control)ll_checkthis).set_AccessibleRole((AccessibleRole)43);
		ll_checkthis.set_ColorTable((eButtonColor)3);
		ButtonX obj27 = ll_checkthis;
		location = new Point(15, 185);
		((Control)obj27).set_Location(location);
		((Control)ll_checkthis).set_Name("ll_checkthis");
		ButtonX obj28 = ll_checkthis;
		size = new Size(289, 23);
		((Control)obj28).set_Size(size);
		((PopupItemControl)ll_checkthis).set_Style((eDotNetBarStyle)7);
		((Control)ll_checkthis).set_TabIndex(2);
		ll_checkthis.set_Text("csv文件名正确性检查");
		((Control)ll_btncsvother).set_AccessibleRole((AccessibleRole)43);
		ll_btncsvother.set_ColorTable((eButtonColor)3);
		ButtonX obj29 = ll_btncsvother;
		location = new Point(169, 158);
		((Control)obj29).set_Location(location);
		((Control)ll_btncsvother).set_Name("ll_btncsvother");
		ButtonX obj30 = ll_btncsvother;
		size = new Size(135, 23);
		((Control)obj30).set_Size(size);
		((PopupItemControl)ll_btncsvother).set_Style((eDotNetBarStyle)7);
		((Control)ll_btncsvother).set_TabIndex(2);
		ll_btncsvother.set_Text("反选");
		((Control)ll_btncsvall).set_AccessibleRole((AccessibleRole)43);
		ll_btncsvall.set_ColorTable((eButtonColor)3);
		ButtonX obj31 = ll_btncsvall;
		location = new Point(15, 158);
		((Control)obj31).set_Location(location);
		((Control)ll_btncsvall).set_Name("ll_btncsvall");
		ButtonX obj32 = ll_btncsvall;
		size = new Size(135, 23);
		((Control)obj32).set_Size(size);
		((PopupItemControl)ll_btncsvall).set_Style((eDotNetBarStyle)7);
		((Control)ll_btncsvall).set_TabIndex(2);
		ll_btncsvall.set_Text("全选");
		((ListControl)ll_lbcheckresult).set_FormattingEnabled(true);
		ll_lbcheckresult.set_ItemHeight(12);
		ListBox obj33 = ll_lbcheckresult;
		location = new Point(310, 61);
		((Control)obj33).set_Location(location);
		((Control)ll_lbcheckresult).set_Name("ll_lbcheckresult");
		ListBox obj34 = ll_lbcheckresult;
		size = new Size(85, 88);
		((Control)obj34).set_Size(size);
		((Control)ll_lbcheckresult).set_TabIndex(1);
		((ListControl)ll_lbcsvlist).set_FormattingEnabled(true);
		ll_lbcsvlist.set_ItemHeight(12);
		ListBox obj35 = ll_lbcsvlist;
		location = new Point(15, 61);
		((Control)obj35).set_Location(location);
		((Control)ll_lbcsvlist).set_Name("ll_lbcsvlist");
		ll_lbcsvlist.set_SelectionMode((SelectionMode)2);
		ListBox obj36 = ll_lbcsvlist;
		size = new Size(289, 88);
		((Control)obj36).set_Size(size);
		((Control)ll_lbcsvlist).set_TabIndex(1);
		ll_txtpath.get_Border().set_Class("TextBoxBorder");
		ll_txtpath.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj37 = ll_txtpath;
		location = new Point(15, 34);
		((Control)obj37).set_Location(location);
		((Control)ll_txtpath).set_Name("ll_txtpath");
		((TextBoxBase)ll_txtpath).set_ReadOnly(true);
		TextBoxX obj38 = ll_txtpath;
		size = new Size(380, 21);
		((Control)obj38).set_Size(size);
		((Control)ll_txtpath).set_TabIndex(0);
		((Control)ll_btnpath).set_AccessibleRole((AccessibleRole)43);
		ll_btnpath.set_ColorTable((eButtonColor)3);
		ButtonX obj39 = ll_btnpath;
		location = new Point(15, 7);
		((Control)obj39).set_Location(location);
		((Control)ll_btnpath).set_Name("ll_btnpath");
		ButtonX obj40 = ll_btnpath;
		size = new Size(219, 23);
		((Control)obj40).set_Size(size);
		((PopupItemControl)ll_btnpath).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnpath).set_TabIndex(0);
		ll_btnpath.set_Text("指定待处理的csv文件夹");
		SuperTabItem2.set_AttachedControl((Control)(object)SuperTabControlPanel4);
		((BaseItem)SuperTabItem2).set_GlobalItem(false);
		((BaseItem)SuperTabItem2).set_Name("SuperTabItem2");
		SuperTabItem2.set_Text("【步骤1】");
		((BaseItem)SuperTabItem2).set_Tooltip(" 分解当前基本csv文件为基本xls文件");
		((Control)SuperTabControlPanel3).get_Controls().Add((Control)(object)ll_checkLZqd);
		((Control)SuperTabControlPanel3).get_Controls().Add((Control)(object)ll_lbenamejxformat2);
		((Control)SuperTabControlPanel3).get_Controls().Add((Control)(object)ll_btncheckformat2);
		((Control)SuperTabControlPanel3).get_Controls().Add((Control)(object)ll_btnfbxnallqd);
		((Control)SuperTabControlPanel3).get_Controls().Add((Control)(object)ll_btnzbxnallqd);
		((Control)SuperTabControlPanel3).get_Controls().Add((Control)(object)ll_btncheckformatandminrf);
		((Control)SuperTabControlPanel3).get_Controls().Add((Control)(object)ll_btngenformat2);
		((Control)SuperTabControlPanel3).get_Controls().Add((Control)(object)ll_btnnameformat2);
		((Control)SuperTabControlPanel3).get_Controls().Add((Control)(object)ll_frmminrf);
		((Control)SuperTabControlPanel3).get_Controls().Add((Control)(object)ll_txtformat2);
		((Control)SuperTabControlPanel3).get_Controls().Add((Control)(object)ll_txtnameformat2);
		((Control)SuperTabControlPanel3).get_Controls().Add((Control)(object)ll_txttempxlslist);
		((Control)SuperTabControlPanel3).get_Controls().Add((Control)(object)ll_btnqdfile);
		SuperTabControlPanel3.set_Dock((DockStyle)5);
		SuperTabControlPanel superTabControlPanel3 = SuperTabControlPanel3;
		location = new Point(0, 0);
		((Control)superTabControlPanel3).set_Location(location);
		((Control)SuperTabControlPanel3).set_Name("SuperTabControlPanel3");
		SuperTabControlPanel superTabControlPanel4 = SuperTabControlPanel3;
		size = new Size(842, 303);
		((Control)superTabControlPanel4).set_Size(size);
		((Control)SuperTabControlPanel3).set_TabIndex(0);
		SuperTabControlPanel3.set_TabItem(SuperTabItem3);
		((BaseItemControl)ll_checkLZqd).get_BackgroundStyle().set_Class("");
		((BaseItemControl)ll_checkLZqd).get_BackgroundStyle().set_CornerType((eCornerType)1);
		CheckBoxX obj41 = ll_checkLZqd;
		location = new Point(733, 241);
		((Control)obj41).set_Location(location);
		((Control)ll_checkLZqd).set_Name("ll_checkLZqd");
		CheckBoxX obj42 = ll_checkLZqd;
		size = new Size(85, 23);
		((Control)obj42).set_Size(size);
		((BaseItemControl)ll_checkLZqd).set_Style((eDotNetBarStyle)7);
		((Control)ll_checkLZqd).set_TabIndex(10);
		ll_checkLZqd.set_Text("主臂优先");
		((BaseItemControl)ll_lbenamejxformat2).get_BackgroundStyle().set_Class("");
		((BaseItemControl)ll_lbenamejxformat2).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX obj43 = ll_lbenamejxformat2;
		location = new Point(507, 116);
		((Control)obj43).set_Location(location);
		((Control)ll_lbenamejxformat2).set_Name("ll_lbenamejxformat2");
		LabelX obj44 = ll_lbenamejxformat2;
		size = new Size(311, 66);
		((Control)obj44).set_Size(size);
		((Control)ll_lbenamejxformat2).set_TabIndex(9);
		((Control)ll_btncheckformat2).set_AccessibleRole((AccessibleRole)43);
		ll_btncheckformat2.set_ColorTable((eButtonColor)3);
		ButtonX obj45 = ll_btncheckformat2;
		location = new Point(686, 60);
		((Control)obj45).set_Location(location);
		((Control)ll_btncheckformat2).set_Name("ll_btncheckformat2");
		ButtonX obj46 = ll_btncheckformat2;
		size = new Size(132, 23);
		((Control)obj46).set_Size(size);
		((PopupItemControl)ll_btncheckformat2).set_Style((eDotNetBarStyle)7);
		((Control)ll_btncheckformat2).set_TabIndex(8);
		ll_btncheckformat2.set_Text("检查解析格式正确性");
		((Control)ll_btnfbxnallqd).set_AccessibleRole((AccessibleRole)43);
		ll_btnfbxnallqd.set_ColorTable((eButtonColor)3);
		ButtonX obj47 = ll_btnfbxnallqd;
		location = new Point(507, 241);
		((Control)obj47).set_Location(location);
		((Control)ll_btnfbxnallqd).set_Name("ll_btnfbxnallqd");
		ButtonX obj48 = ll_btnfbxnallqd;
		size = new Size(220, 23);
		((Control)obj48).set_Size(size);
		((PopupItemControl)ll_btnfbxnallqd).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnfbxnallqd).set_TabIndex(8);
		ll_btnfbxnallqd.set_Text("更新 【副臂】 强度性能表");
		((Control)ll_btnzbxnallqd).set_AccessibleRole((AccessibleRole)43);
		ll_btnzbxnallqd.set_ColorTable((eButtonColor)3);
		ButtonX obj49 = ll_btnzbxnallqd;
		location = new Point(507, 217);
		((Control)obj49).set_Location(location);
		((Control)ll_btnzbxnallqd).set_Name("ll_btnzbxnallqd");
		ButtonX obj50 = ll_btnzbxnallqd;
		size = new Size(220, 23);
		((Control)obj50).set_Size(size);
		((PopupItemControl)ll_btnzbxnallqd).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnzbxnallqd).set_TabIndex(8);
		ll_btnzbxnallqd.set_Text("更新 【主臂】 强度性能表");
		((Control)ll_btncheckformatandminrf).set_AccessibleRole((AccessibleRole)43);
		ll_btncheckformatandminrf.set_ColorTable((eButtonColor)3);
		ButtonX obj51 = ll_btncheckformatandminrf;
		location = new Point(507, 185);
		((Control)obj51).set_Location(location);
		((Control)ll_btncheckformatandminrf).set_Name("ll_btncheckformatandminrf");
		ButtonX obj52 = ll_btncheckformatandminrf;
		size = new Size(220, 23);
		((Control)obj52).set_Size(size);
		((PopupItemControl)ll_btncheckformatandminrf).set_Style((eDotNetBarStyle)7);
		((Control)ll_btncheckformatandminrf).set_TabIndex(8);
		ll_btncheckformatandminrf.set_Text("检查解析格式与最小幅度一致性");
		((Control)ll_btngenformat2).set_AccessibleRole((AccessibleRole)43);
		ll_btngenformat2.set_ColorTable((eButtonColor)3);
		ButtonX obj53 = ll_btngenformat2;
		location = new Point(507, 60);
		((Control)obj53).set_Location(location);
		((Control)ll_btngenformat2).set_Name("ll_btngenformat2");
		ButtonX obj54 = ll_btngenformat2;
		size = new Size(132, 23);
		((Control)obj54).set_Size(size);
		((PopupItemControl)ll_btngenformat2).set_Style((eDotNetBarStyle)7);
		((Control)ll_btngenformat2).set_TabIndex(8);
		ll_btngenformat2.set_Text("指定解析格式");
		((Control)ll_btnnameformat2).set_AccessibleRole((AccessibleRole)43);
		ll_btnnameformat2.set_ColorTable((eButtonColor)3);
		ButtonX obj55 = ll_btnnameformat2;
		location = new Point(507, 5);
		((Control)obj55).set_Location(location);
		((Control)ll_btnnameformat2).set_Name("ll_btnnameformat2");
		ButtonX obj56 = ll_btnnameformat2;
		size = new Size(132, 23);
		((Control)obj56).set_Size(size);
		((PopupItemControl)ll_btnnameformat2).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnnameformat2).set_TabIndex(8);
		ll_btnnameformat2.set_Text("提取工况名称格式");
		ll_frmminrf.set_CanvasColor(SystemColors.Control);
		ll_frmminrf.set_ColorSchemeStyle((eDotNetBarStyle)7);
		((Control)ll_frmminrf).get_Controls().Add((Control)(object)LabelX13);
		((Control)ll_frmminrf).get_Controls().Add((Control)(object)ll_btnfromall);
		((Control)ll_frmminrf).get_Controls().Add((Control)(object)ll_btnfromtxt);
		((Control)ll_frmminrf).get_Controls().Add((Control)(object)ll_lbcheckminrf2);
		((Control)ll_frmminrf).get_Controls().Add((Control)(object)ll_btntotxt);
		((Control)ll_frmminrf).get_Controls().Add((Control)(object)ll_lbcheckminrf);
		((Control)ll_frmminrf).get_Controls().Add((Control)(object)ll_btncheckminrf);
		((Control)ll_frmminrf).get_Controls().Add((Control)(object)ll_lbminrflist);
		PanelEx obj57 = ll_frmminrf;
		location = new Point(21, 57);
		((Control)obj57).set_Location(location);
		((Control)ll_frmminrf).set_Name("ll_frmminrf");
		PanelEx obj58 = ll_frmminrf;
		size = new Size(462, 212);
		((Control)obj58).set_Size(size);
		ll_frmminrf.get_Style().set_Alignment((StringAlignment)1);
		ll_frmminrf.get_Style().get_BackColor1().set_ColorSchemePart((eColorSchemePart)51);
		ll_frmminrf.get_Style().get_BackColor2().set_ColorSchemePart((eColorSchemePart)52);
		ll_frmminrf.get_Style().set_Border((eBorderType)1);
		ll_frmminrf.get_Style().get_BorderColor().set_ColorSchemePart((eColorSchemePart)53);
		ll_frmminrf.get_Style().get_ForeColor().set_ColorSchemePart((eColorSchemePart)54);
		ll_frmminrf.get_Style().set_GradientAngle(90);
		((Control)ll_frmminrf).set_TabIndex(7);
		((BaseItemControl)LabelX13).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX13).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX5 = LabelX13;
		location = new Point(23, 10);
		((Control)labelX5).set_Location(location);
		((Control)LabelX13).set_Name("LabelX13");
		LabelX labelX6 = LabelX13;
		size = new Size(103, 17);
		((Control)labelX6).set_Size(size);
		((Control)LabelX13).set_TabIndex(6);
		LabelX13.set_Text("最小幅度信息处理");
		((Control)ll_btnfromall).set_AccessibleRole((AccessibleRole)43);
		ll_btnfromall.set_ColorTable((eButtonColor)3);
		ButtonX obj59 = ll_btnfromall;
		location = new Point(23, 176);
		((Control)obj59).set_Location(location);
		((Control)ll_btnfromall).set_Name("ll_btnfromall");
		ButtonX obj60 = ll_btnfromall;
		size = new Size(77, 23);
		((Control)obj60).set_Size(size);
		((PopupItemControl)ll_btnfromall).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnfromall).set_TabIndex(4);
		ll_btnfromall.set_Text("从all中提取");
		((Control)ll_btnfromtxt).set_AccessibleRole((AccessibleRole)43);
		ll_btnfromtxt.set_ColorTable((eButtonColor)3);
		ButtonX obj61 = ll_btnfromtxt;
		location = new Point(106, 176);
		((Control)obj61).set_Location(location);
		((Control)ll_btnfromtxt).set_Name("ll_btnfromtxt");
		ButtonX obj62 = ll_btnfromtxt;
		size = new Size(62, 23);
		((Control)obj62).set_Size(size);
		((PopupItemControl)ll_btnfromtxt).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnfromtxt).set_TabIndex(4);
		ll_btnfromtxt.set_Text("从txt导入");
		((ListControl)ll_lbcheckminrf2).set_FormattingEnabled(true);
		ll_lbcheckminrf2.set_ItemHeight(12);
		ListBox obj63 = ll_lbcheckminrf2;
		location = new Point(382, 34);
		((Control)obj63).set_Location(location);
		((Control)ll_lbcheckminrf2).set_Name("ll_lbcheckminrf2");
		ListBox obj64 = ll_lbcheckminrf2;
		size = new Size(64, 136);
		((Control)obj64).set_Size(size);
		((Control)ll_lbcheckminrf2).set_TabIndex(1);
		((Control)ll_btntotxt).set_AccessibleRole((AccessibleRole)43);
		ll_btntotxt.set_ColorTable((eButtonColor)3);
		ButtonX obj65 = ll_btntotxt;
		location = new Point(240, 176);
		((Control)obj65).set_Location(location);
		((Control)ll_btntotxt).set_Name("ll_btntotxt");
		ButtonX obj66 = ll_btntotxt;
		size = new Size(66, 23);
		((Control)obj66).set_Size(size);
		((PopupItemControl)ll_btntotxt).set_Style((eDotNetBarStyle)7);
		((Control)ll_btntotxt).set_TabIndex(4);
		ll_btntotxt.set_Text("导出为txt");
		((ListControl)ll_lbcheckminrf).set_FormattingEnabled(true);
		ll_lbcheckminrf.set_ItemHeight(12);
		ListBox obj67 = ll_lbcheckminrf;
		location = new Point(312, 34);
		((Control)obj67).set_Location(location);
		((Control)ll_lbcheckminrf).set_Name("ll_lbcheckminrf");
		ListBox obj68 = ll_lbcheckminrf;
		size = new Size(64, 136);
		((Control)obj68).set_Size(size);
		((Control)ll_lbcheckminrf).set_TabIndex(1);
		((Control)ll_btncheckminrf).set_AccessibleRole((AccessibleRole)43);
		ll_btncheckminrf.set_ColorTable((eButtonColor)3);
		ButtonX obj69 = ll_btncheckminrf;
		location = new Point(312, 176);
		((Control)obj69).set_Location(location);
		((Control)ll_btncheckminrf).set_Name("ll_btncheckminrf");
		ButtonX obj70 = ll_btncheckminrf;
		size = new Size(134, 23);
		((Control)obj70).set_Size(size);
		((PopupItemControl)ll_btncheckminrf).set_Style((eDotNetBarStyle)7);
		((Control)ll_btncheckminrf).set_TabIndex(4);
		ll_btncheckminrf.set_Text("一致性检验");
		((ListControl)ll_lbminrflist).set_FormattingEnabled(true);
		ll_lbminrflist.set_ItemHeight(12);
		ListBox obj71 = ll_lbminrflist;
		location = new Point(23, 34);
		((Control)obj71).set_Location(location);
		((Control)ll_lbminrflist).set_Name("ll_lbminrflist");
		ListBox obj72 = ll_lbminrflist;
		size = new Size(283, 136);
		((Control)obj72).set_Size(size);
		((Control)ll_lbminrflist).set_TabIndex(1);
		ll_txtformat2.get_Border().set_Class("TextBoxBorder");
		ll_txtformat2.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj73 = ll_txtformat2;
		location = new Point(507, 89);
		((Control)obj73).set_Location(location);
		((Control)ll_txtformat2).set_Name("ll_txtformat2");
		((TextBoxBase)ll_txtformat2).set_ReadOnly(true);
		TextBoxX obj74 = ll_txtformat2;
		size = new Size(311, 21);
		((Control)obj74).set_Size(size);
		((Control)ll_txtformat2).set_TabIndex(5);
		ll_txtnameformat2.get_Border().set_Class("TextBoxBorder");
		ll_txtnameformat2.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj75 = ll_txtnameformat2;
		location = new Point(507, 32);
		((Control)obj75).set_Location(location);
		((Control)ll_txtnameformat2).set_Name("ll_txtnameformat2");
		((TextBoxBase)ll_txtnameformat2).set_ReadOnly(true);
		TextBoxX obj76 = ll_txtnameformat2;
		size = new Size(311, 21);
		((Control)obj76).set_Size(size);
		((Control)ll_txtnameformat2).set_TabIndex(5);
		ll_txttempxlslist.get_Border().set_Class("TextBoxBorder");
		ll_txttempxlslist.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj77 = ll_txttempxlslist;
		location = new Point(21, 32);
		((Control)obj77).set_Location(location);
		((Control)ll_txttempxlslist).set_Name("ll_txttempxlslist");
		((TextBoxBase)ll_txttempxlslist).set_ReadOnly(true);
		TextBoxX obj78 = ll_txttempxlslist;
		size = new Size(462, 21);
		((Control)obj78).set_Size(size);
		((Control)ll_txttempxlslist).set_TabIndex(5);
		((Control)ll_btnqdfile).set_AccessibleRole((AccessibleRole)43);
		ll_btnqdfile.set_ColorTable((eButtonColor)3);
		ButtonX obj79 = ll_btnqdfile;
		location = new Point(21, 5);
		((Control)obj79).set_Location(location);
		((Control)ll_btnqdfile).set_Name("ll_btnqdfile");
		ButtonX obj80 = ll_btnqdfile;
		size = new Size(176, 23);
		((Control)obj80).set_Size(size);
		((PopupItemControl)ll_btnqdfile).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnqdfile).set_TabIndex(4);
		ll_btnqdfile.set_Text("指定待处理的强度性能xls...");
		SuperTabItem3.set_AttachedControl((Control)(object)SuperTabControlPanel3);
		((BaseItem)SuperTabItem3).set_GlobalItem(false);
		((BaseItem)SuperTabItem3).set_Name("SuperTabItem3");
		SuperTabItem3.set_Text("【步骤3】");
		((BaseItem)SuperTabItem3).set_Tooltip("通过强度性能结果确定各组合最小幅度");
		((Control)SuperTabControlPanel1).get_Controls().Add((Control)(object)ll_txtformat);
		((Control)SuperTabControlPanel1).get_Controls().Add((Control)(object)ll_txtnameformat);
		((Control)SuperTabControlPanel1).get_Controls().Add((Control)(object)ll_checkLZ);
		((Control)SuperTabControlPanel1).get_Controls().Add((Control)(object)ll_txtchai);
		((Control)SuperTabControlPanel1).get_Controls().Add((Control)(object)ll_btnxlsother);
		((Control)SuperTabControlPanel1).get_Controls().Add((Control)(object)ll_btncheckformat);
		((Control)SuperTabControlPanel1).get_Controls().Add((Control)(object)ll_btnlcnamecheck);
		((Control)SuperTabControlPanel1).get_Controls().Add((Control)(object)ll_btnxlsall);
		((Control)SuperTabControlPanel1).get_Controls().Add((Control)(object)ll_btngenformat);
		((Control)SuperTabControlPanel1).get_Controls().Add((Control)(object)ll_btnnameformat);
		((Control)SuperTabControlPanel1).get_Controls().Add((Control)(object)ll_lbenamejxformat);
		((Control)SuperTabControlPanel1).get_Controls().Add((Control)(object)LabelX3);
		((Control)SuperTabControlPanel1).get_Controls().Add((Control)(object)ll_btnfbxnall);
		((Control)SuperTabControlPanel1).get_Controls().Add((Control)(object)ll_btnzbxnall);
		((Control)SuperTabControlPanel1).get_Controls().Add((Control)(object)ll_btnpicktempxls);
		((Control)SuperTabControlPanel1).get_Controls().Add((Control)(object)ll_lblcnamecheckresult);
		((Control)SuperTabControlPanel1).get_Controls().Add((Control)(object)ll_lblcnamelist);
		((Control)SuperTabControlPanel1).get_Controls().Add((Control)(object)ll_lbtempxlslist);
		SuperTabControlPanel1.set_Dock((DockStyle)5);
		SuperTabControlPanel superTabControlPanel5 = SuperTabControlPanel1;
		location = new Point(0, 28);
		((Control)superTabControlPanel5).set_Location(location);
		((Control)SuperTabControlPanel1).set_Name("SuperTabControlPanel1");
		SuperTabControlPanel superTabControlPanel6 = SuperTabControlPanel1;
		size = new Size(842, 275);
		((Control)superTabControlPanel6).set_Size(size);
		((Control)SuperTabControlPanel1).set_TabIndex(1);
		SuperTabControlPanel1.set_TabItem(SuperTabItem1);
		ll_txtformat.get_Border().set_Class("TextBoxBorder");
		ll_txtformat.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj81 = ll_txtformat;
		location = new Point(434, 212);
		((Control)obj81).set_Location(location);
		((Control)ll_txtformat).set_Name("ll_txtformat");
		((TextBoxBase)ll_txtformat).set_ReadOnly(true);
		TextBoxX obj82 = ll_txtformat;
		size = new Size(374, 21);
		((Control)obj82).set_Size(size);
		((Control)ll_txtformat).set_TabIndex(4);
		ll_txtnameformat.get_Border().set_Class("TextBoxBorder");
		ll_txtnameformat.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj83 = ll_txtnameformat;
		location = new Point(434, 153);
		((Control)obj83).set_Location(location);
		((Control)ll_txtnameformat).set_Name("ll_txtnameformat");
		((TextBoxBase)ll_txtnameformat).set_ReadOnly(true);
		TextBoxX obj84 = ll_txtnameformat;
		size = new Size(374, 21);
		((Control)obj84).set_Size(size);
		((Control)ll_txtnameformat).set_TabIndex(4);
		((BaseItemControl)ll_checkLZ).get_BackgroundStyle().set_Class("");
		((BaseItemControl)ll_checkLZ).get_BackgroundStyle().set_CornerType((eCornerType)1);
		CheckBoxX obj85 = ll_checkLZ;
		location = new Point(210, 237);
		((Control)obj85).set_Location(location);
		((Control)ll_checkLZ).set_Name("ll_checkLZ");
		CheckBoxX obj86 = ll_checkLZ;
		size = new Size(178, 24);
		((Control)obj86).set_Size(size);
		((BaseItemControl)ll_checkLZ).set_Style((eDotNetBarStyle)7);
		((Control)ll_checkLZ).set_TabIndex(3);
		ll_checkLZ.set_Text("主臂优先");
		((VisualControlBase)ll_txtchai).get_BackgroundStyle().set_Class("DateTimeInputBackground");
		((VisualControlBase)ll_txtchai).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((NumericInputBase)ll_txtchai).get_ButtonFreeText().set_Shortcut((eShortcut)113);
		IntegerInput obj87 = ll_txtchai;
		location = new Point(210, 181);
		((Control)obj87).set_Location(location);
		((Control)ll_txtchai).set_Name("ll_txtchai");
		((NumericInputBase)ll_txtchai).set_ShowUpDown(true);
		IntegerInput obj88 = ll_txtchai;
		size = new Size(136, 21);
		((Control)obj88).set_Size(size);
		((Control)ll_txtchai).set_TabIndex(2);
		ll_txtchai.set_Value(1);
		((Control)ll_btnxlsother).set_AccessibleRole((AccessibleRole)43);
		ll_btnxlsother.set_ColorTable((eButtonColor)3);
		ButtonX obj89 = ll_btnxlsother;
		location = new Point(210, 151);
		((Control)obj89).set_Location(location);
		((Control)ll_btnxlsother).set_Name("ll_btnxlsother");
		ButtonX obj90 = ll_btnxlsother;
		size = new Size(178, 23);
		((Control)obj90).set_Size(size);
		((PopupItemControl)ll_btnxlsother).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnxlsother).set_TabIndex(0);
		ll_btnxlsother.set_Text("反选");
		((Control)ll_btncheckformat).set_AccessibleRole((AccessibleRole)43);
		ll_btncheckformat.set_ColorTable((eButtonColor)3);
		ButtonX obj91 = ll_btncheckformat;
		location = new Point(624, 180);
		((Control)obj91).set_Location(location);
		((Control)ll_btncheckformat).set_Name("ll_btncheckformat");
		ButtonX obj92 = ll_btncheckformat;
		size = new Size(184, 26);
		((Control)obj92).set_Size(size);
		((PopupItemControl)ll_btncheckformat).set_Style((eDotNetBarStyle)7);
		((Control)ll_btncheckformat).set_TabIndex(0);
		ll_btncheckformat.set_Text("检查解析格式正确性");
		((Control)ll_btnlcnamecheck).set_AccessibleRole((AccessibleRole)43);
		ll_btnlcnamecheck.set_ColorTable((eButtonColor)3);
		ButtonX obj93 = ll_btnlcnamecheck;
		location = new Point(624, 12);
		((Control)obj93).set_Location(location);
		((Control)ll_btnlcnamecheck).set_Name("ll_btnlcnamecheck");
		ButtonX obj94 = ll_btnlcnamecheck;
		size = new Size(184, 28);
		((Control)obj94).set_Size(size);
		((PopupItemControl)ll_btnlcnamecheck).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnlcnamecheck).set_TabIndex(0);
		ll_btnlcnamecheck.set_Text("检查工况名称格式的一致性");
		((Control)ll_btnxlsall).set_AccessibleRole((AccessibleRole)43);
		ll_btnxlsall.set_ColorTable((eButtonColor)3);
		ButtonX obj95 = ll_btnxlsall;
		location = new Point(26, 151);
		((Control)obj95).set_Location(location);
		((Control)ll_btnxlsall).set_Name("ll_btnxlsall");
		ButtonX obj96 = ll_btnxlsall;
		size = new Size(178, 23);
		((Control)obj96).set_Size(size);
		((PopupItemControl)ll_btnxlsall).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnxlsall).set_TabIndex(0);
		ll_btnxlsall.set_Text("全选");
		((Control)ll_btngenformat).set_AccessibleRole((AccessibleRole)43);
		ll_btngenformat.set_ColorTable((eButtonColor)3);
		ButtonX obj97 = ll_btngenformat;
		location = new Point(434, 180);
		((Control)obj97).set_Location(location);
		((Control)ll_btngenformat).set_Name("ll_btngenformat");
		ButtonX obj98 = ll_btngenformat;
		size = new Size(184, 26);
		((Control)obj98).set_Size(size);
		((PopupItemControl)ll_btngenformat).set_Style((eDotNetBarStyle)7);
		((Control)ll_btngenformat).set_TabIndex(0);
		ll_btngenformat.set_Text("指定解析格式");
		((Control)ll_btnnameformat).set_AccessibleRole((AccessibleRole)43);
		ll_btnnameformat.set_ColorTable((eButtonColor)3);
		ButtonX obj99 = ll_btnnameformat;
		location = new Point(434, 12);
		((Control)obj99).set_Location(location);
		((Control)ll_btnnameformat).set_Name("ll_btnnameformat");
		ButtonX obj100 = ll_btnnameformat;
		size = new Size(184, 28);
		((Control)obj100).set_Size(size);
		((PopupItemControl)ll_btnnameformat).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnnameformat).set_TabIndex(0);
		ll_btnnameformat.set_Text("提取工况名称格式");
		((BaseItemControl)ll_lbenamejxformat).get_BackgroundStyle().set_Class("");
		((BaseItemControl)ll_lbenamejxformat).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX obj101 = ll_lbenamejxformat;
		location = new Point(434, 239);
		((Control)obj101).set_Location(location);
		((Control)ll_lbenamejxformat).set_Name("ll_lbenamejxformat");
		LabelX obj102 = ll_lbenamejxformat;
		size = new Size(374, 23);
		((Control)obj102).set_Size(size);
		((Control)ll_lbenamejxformat).set_TabIndex(0);
		((BaseItemControl)LabelX3).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX3).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX7 = LabelX3;
		location = new Point(75, 180);
		((Control)labelX7).set_Location(location);
		((Control)LabelX3).set_Name("LabelX3");
		LabelX labelX8 = LabelX3;
		size = new Size(99, 23);
		((Control)labelX8).set_Size(size);
		((Control)LabelX3).set_TabIndex(0);
		LabelX3.set_Text("吊重插值次数:");
		((Control)ll_btnfbxnall).set_AccessibleRole((AccessibleRole)43);
		ll_btnfbxnall.set_ColorTable((eButtonColor)3);
		ButtonX obj103 = ll_btnfbxnall;
		location = new Point(26, 238);
		((Control)obj103).set_Location(location);
		((Control)ll_btnfbxnall).set_Name("ll_btnfbxnall");
		ButtonX obj104 = ll_btnfbxnall;
		size = new Size(178, 23);
		((Control)obj104).set_Size(size);
		((PopupItemControl)ll_btnfbxnall).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnfbxnall).set_TabIndex(0);
		ll_btnfbxnall.set_Text("生成副臂性能");
		((Control)ll_btnzbxnall).set_AccessibleRole((AccessibleRole)43);
		ll_btnzbxnall.set_ColorTable((eButtonColor)3);
		ButtonX obj105 = ll_btnzbxnall;
		location = new Point(26, 209);
		((Control)obj105).set_Location(location);
		((Control)ll_btnzbxnall).set_Name("ll_btnzbxnall");
		ButtonX obj106 = ll_btnzbxnall;
		size = new Size(178, 23);
		((Control)obj106).set_Size(size);
		((PopupItemControl)ll_btnzbxnall).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnzbxnall).set_TabIndex(0);
		ll_btnzbxnall.set_Text("生成主臂性能");
		((Control)ll_btnpicktempxls).set_AccessibleRole((AccessibleRole)43);
		ll_btnpicktempxls.set_ColorTable((eButtonColor)3);
		ButtonX obj107 = ll_btnpicktempxls;
		location = new Point(26, 12);
		((Control)obj107).set_Location(location);
		((Control)ll_btnpicktempxls).set_Name("ll_btnpicktempxls");
		ButtonX obj108 = ll_btnpicktempxls;
		size = new Size(136, 28);
		((Control)obj108).set_Size(size);
		((PopupItemControl)ll_btnpicktempxls).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnpicktempxls).set_TabIndex(0);
		ll_btnpicktempxls.set_Text("提取当前基本xls文件");
		((ListControl)ll_lblcnamecheckresult).set_FormattingEnabled(true);
		ll_lblcnamecheckresult.set_ItemHeight(12);
		ListBox obj109 = ll_lblcnamecheckresult;
		location = new Point(743, 45);
		((Control)obj109).set_Location(location);
		((Control)ll_lblcnamecheckresult).set_Name("ll_lblcnamecheckresult");
		ListBox obj110 = ll_lblcnamecheckresult;
		size = new Size(65, 100);
		((Control)obj110).set_Size(size);
		((Control)ll_lblcnamecheckresult).set_TabIndex(1);
		((ListControl)ll_lblcnamelist).set_FormattingEnabled(true);
		ll_lblcnamelist.set_ItemHeight(12);
		ListBox obj111 = ll_lblcnamelist;
		location = new Point(434, 45);
		((Control)obj111).set_Location(location);
		((Control)ll_lblcnamelist).set_Name("ll_lblcnamelist");
		ListBox obj112 = ll_lblcnamelist;
		size = new Size(303, 100);
		((Control)obj112).set_Size(size);
		((Control)ll_lblcnamelist).set_TabIndex(1);
		((ListControl)ll_lbtempxlslist).set_FormattingEnabled(true);
		ll_lbtempxlslist.set_ItemHeight(12);
		ListBox obj113 = ll_lbtempxlslist;
		location = new Point(26, 45);
		((Control)obj113).set_Location(location);
		((Control)ll_lbtempxlslist).set_Name("ll_lbtempxlslist");
		ll_lbtempxlslist.set_SelectionMode((SelectionMode)2);
		ListBox obj114 = ll_lbtempxlslist;
		size = new Size(362, 100);
		((Control)obj114).set_Size(size);
		((Control)ll_lbtempxlslist).set_TabIndex(1);
		SuperTabItem1.set_AttachedControl((Control)(object)SuperTabControlPanel1);
		((BaseItem)SuperTabItem1).set_GlobalItem(false);
		((BaseItem)SuperTabItem1).set_Name("SuperTabItem1");
		SuperTabItem1.set_Text("【步骤2】");
		((BaseItem)SuperTabItem1).set_Tooltip("转换基本xls文件为性能xls文件");
		((Control)SuperTabControlPanel2).get_Controls().Add((Control)(object)ll_txtcurxti);
		((Control)SuperTabControlPanel2).get_Controls().Add((Control)(object)ll_txtzbxt);
		((Control)SuperTabControlPanel2).get_Controls().Add((Control)(object)ll_txtfixxt);
		((Control)SuperTabControlPanel2).get_Controls().Add((Control)(object)ll_txtfblf);
		((Control)SuperTabControlPanel2).get_Controls().Add((Control)(object)ll_txtfblz);
		((Control)SuperTabControlPanel2).get_Controls().Add((Control)(object)LabelX12);
		((Control)SuperTabControlPanel2).get_Controls().Add((Control)(object)LabelX5);
		((Control)SuperTabControlPanel2).get_Controls().Add((Control)(object)LabelX11);
		((Control)SuperTabControlPanel2).get_Controls().Add((Control)(object)LabelX10);
		((Control)SuperTabControlPanel2).get_Controls().Add((Control)(object)ll_lbpzlist);
		((Control)SuperTabControlPanel2).get_Controls().Add((Control)(object)ll_lbztkjlist);
		((Control)SuperTabControlPanel2).get_Controls().Add((Control)(object)ll_lbnamelist);
		((Control)SuperTabControlPanel2).get_Controls().Add((Control)(object)LabelX9);
		((Control)SuperTabControlPanel2).get_Controls().Add((Control)(object)ll_lbxtlist);
		((Control)SuperTabControlPanel2).get_Controls().Add((Control)(object)LabelX8);
		((Control)SuperTabControlPanel2).get_Controls().Add((Control)(object)ll_lbzbxtlist);
		((Control)SuperTabControlPanel2).get_Controls().Add((Control)(object)LabelX7);
		((Control)SuperTabControlPanel2).get_Controls().Add((Control)(object)ll_lbfixxtlist);
		((Control)SuperTabControlPanel2).get_Controls().Add((Control)(object)LabelX6);
		((Control)SuperTabControlPanel2).get_Controls().Add((Control)(object)ll_lbfblf);
		((Control)SuperTabControlPanel2).get_Controls().Add((Control)(object)LabelX4);
		((Control)SuperTabControlPanel2).get_Controls().Add((Control)(object)ll_lbfblz);
		SuperTabControlPanel2.set_Dock((DockStyle)5);
		SuperTabControlPanel superTabControlPanel7 = SuperTabControlPanel2;
		location = new Point(0, 0);
		((Control)superTabControlPanel7).set_Location(location);
		((Control)SuperTabControlPanel2).set_Name("SuperTabControlPanel2");
		SuperTabControlPanel superTabControlPanel8 = SuperTabControlPanel2;
		size = new Size(842, 303);
		((Control)superTabControlPanel8).set_Size(size);
		((Control)SuperTabControlPanel2).set_TabIndex(2);
		SuperTabControlPanel2.set_TabItem(ll_pagetemplist);
		ll_txtcurxti.get_Border().set_Class("TextBoxBorder");
		ll_txtcurxti.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj115 = ll_txtcurxti;
		location = new Point(473, 244);
		((Control)obj115).set_Location(location);
		((Control)ll_txtcurxti).set_Name("ll_txtcurxti");
		TextBoxX obj116 = ll_txtcurxti;
		size = new Size(107, 21);
		((Control)obj116).set_Size(size);
		((Control)ll_txtcurxti).set_TabIndex(3);
		((TextBoxBase)ll_txtzbxt).set_BackColor(Color.Gray);
		ll_txtzbxt.get_Border().set_Class("TextBoxBorder");
		ll_txtzbxt.get_Border().set_CornerType((eCornerType)1);
		((TextBoxBase)ll_txtzbxt).set_ForeColor(Color.White);
		TextBoxX obj117 = ll_txtzbxt;
		location = new Point(360, 244);
		((Control)obj117).set_Location(location);
		((Control)ll_txtzbxt).set_Name("ll_txtzbxt");
		TextBoxX obj118 = ll_txtzbxt;
		size = new Size(107, 21);
		((Control)obj118).set_Size(size);
		((Control)ll_txtzbxt).set_TabIndex(3);
		((TextBoxBase)ll_txtfixxt).set_BackColor(Color.Gray);
		ll_txtfixxt.get_Border().set_Class("TextBoxBorder");
		ll_txtfixxt.get_Border().set_CornerType((eCornerType)1);
		((TextBoxBase)ll_txtfixxt).set_ForeColor(Color.White);
		TextBoxX obj119 = ll_txtfixxt;
		location = new Point(247, 244);
		((Control)obj119).set_Location(location);
		((Control)ll_txtfixxt).set_Name("ll_txtfixxt");
		TextBoxX obj120 = ll_txtfixxt;
		size = new Size(107, 21);
		((Control)obj120).set_Size(size);
		((Control)ll_txtfixxt).set_TabIndex(3);
		((TextBoxBase)ll_txtfblf).set_BackColor(Color.Gray);
		ll_txtfblf.get_Border().set_Class("TextBoxBorder");
		ll_txtfblf.get_Border().set_CornerType((eCornerType)1);
		((TextBoxBase)ll_txtfblf).set_ForeColor(Color.White);
		TextBoxX obj121 = ll_txtfblf;
		location = new Point(134, 244);
		((Control)obj121).set_Location(location);
		((Control)ll_txtfblf).set_Name("ll_txtfblf");
		TextBoxX obj122 = ll_txtfblf;
		size = new Size(107, 21);
		((Control)obj122).set_Size(size);
		((Control)ll_txtfblf).set_TabIndex(3);
		((TextBoxBase)ll_txtfblz).set_BackColor(Color.Gray);
		ll_txtfblz.get_Border().set_Class("TextBoxBorder");
		ll_txtfblz.get_Border().set_CornerType((eCornerType)1);
		((TextBoxBase)ll_txtfblz).set_ForeColor(Color.White);
		TextBoxX obj123 = ll_txtfblz;
		location = new Point(21, 244);
		((Control)obj123).set_Location(location);
		((Control)ll_txtfblz).set_Name("ll_txtfblz");
		TextBoxX obj124 = ll_txtfblz;
		size = new Size(107, 21);
		((Control)obj124).set_Size(size);
		((Control)ll_txtfblz).set_TabIndex(3);
		((BaseItemControl)LabelX12).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX12).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX9 = LabelX12;
		location = new Point(586, 3);
		((Control)labelX9).set_Location(location);
		((Control)LabelX12).set_Name("LabelX12");
		LabelX labelX10 = LabelX12;
		size = new Size(107, 20);
		((Control)labelX10).set_Size(size);
		((Control)LabelX12).set_TabIndex(4);
		LabelX12.set_Text("HQZ统计表");
		((BaseItemControl)LabelX5).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX5).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX11 = LabelX5;
		location = new Point(728, 28);
		((Control)labelX11).set_Location(location);
		((Control)LabelX5).set_Name("LabelX5");
		LabelX labelX12 = LabelX5;
		size = new Size(67, 20);
		((Control)labelX12).set_Size(size);
		((Control)LabelX5).set_TabIndex(4);
		LabelX5.set_Text("配重");
		((BaseItemControl)LabelX11).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX11).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX13 = LabelX11;
		location = new Point(586, 28);
		((Control)labelX13).set_Location(location);
		((Control)LabelX11).set_Name("LabelX11");
		LabelX labelX14 = LabelX11;
		size = new Size(107, 20);
		((Control)labelX14).set_Size(size);
		((Control)LabelX11).set_TabIndex(4);
		LabelX11.set_Text("名称");
		((BaseItemControl)LabelX10).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX10).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX15 = LabelX10;
		location = new Point(473, 28);
		((Control)labelX15).set_Location(location);
		((Control)LabelX10).set_Name("LabelX10");
		LabelX labelX16 = LabelX10;
		size = new Size(107, 20);
		((Control)labelX16).set_Size(size);
		((Control)LabelX10).set_TabIndex(4);
		LabelX10.set_Text("xt");
		((ListControl)ll_lbpzlist).set_FormattingEnabled(true);
		ll_lbpzlist.set_ItemHeight(12);
		ListBox obj125 = ll_lbpzlist;
		location = new Point(728, 54);
		((Control)obj125).set_Location(location);
		((Control)ll_lbpzlist).set_Name("ll_lbpzlist");
		ListBox obj126 = ll_lbpzlist;
		size = new Size(67, 184);
		((Control)obj126).set_Size(size);
		((Control)ll_lbpzlist).set_TabIndex(1);
		((ListControl)ll_lbztkjlist).set_FormattingEnabled(true);
		ll_lbztkjlist.set_ItemHeight(12);
		ListBox obj127 = ll_lbztkjlist;
		location = new Point(586, 160);
		((Control)obj127).set_Location(location);
		((Control)ll_lbztkjlist).set_Name("ll_lbztkjlist");
		ListBox obj128 = ll_lbztkjlist;
		size = new Size(136, 76);
		((Control)obj128).set_Size(size);
		((Control)ll_lbztkjlist).set_TabIndex(1);
		((ListControl)ll_lbnamelist).set_FormattingEnabled(true);
		ll_lbnamelist.set_ItemHeight(12);
		ListBox obj129 = ll_lbnamelist;
		location = new Point(586, 54);
		((Control)obj129).set_Location(location);
		((Control)ll_lbnamelist).set_Name("ll_lbnamelist");
		ListBox obj130 = ll_lbnamelist;
		size = new Size(136, 100);
		((Control)obj130).set_Size(size);
		((Control)ll_lbnamelist).set_TabIndex(1);
		((BaseItemControl)LabelX9).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX9).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX17 = LabelX9;
		location = new Point(360, 28);
		((Control)labelX17).set_Location(location);
		((Control)LabelX9).set_Name("LabelX9");
		LabelX labelX18 = LabelX9;
		size = new Size(107, 20);
		((Control)labelX18).set_Size(size);
		((Control)LabelX9).set_TabIndex(4);
		LabelX9.set_Text("主臂仰角zbxt");
		((ListControl)ll_lbxtlist).set_FormattingEnabled(true);
		ll_lbxtlist.set_ItemHeight(12);
		ListBox obj131 = ll_lbxtlist;
		location = new Point(473, 54);
		((Control)obj131).set_Location(location);
		((Control)ll_lbxtlist).set_Name("ll_lbxtlist");
		ListBox obj132 = ll_lbxtlist;
		size = new Size(107, 184);
		((Control)obj132).set_Size(size);
		((Control)ll_lbxtlist).set_TabIndex(1);
		((BaseItemControl)LabelX8).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX8).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX19 = LabelX8;
		location = new Point(247, 28);
		((Control)labelX19).set_Location(location);
		((Control)LabelX8).set_Name("LabelX8");
		LabelX labelX20 = LabelX8;
		size = new Size(107, 20);
		((Control)labelX20).set_Size(size);
		((Control)LabelX8).set_TabIndex(4);
		LabelX8.set_Text("安装角度fixxt");
		((ListControl)ll_lbzbxtlist).set_FormattingEnabled(true);
		ll_lbzbxtlist.set_ItemHeight(12);
		ListBox obj133 = ll_lbzbxtlist;
		location = new Point(360, 54);
		((Control)obj133).set_Location(location);
		((Control)ll_lbzbxtlist).set_Name("ll_lbzbxtlist");
		ListBox obj134 = ll_lbzbxtlist;
		size = new Size(107, 184);
		((Control)obj134).set_Size(size);
		((Control)ll_lbzbxtlist).set_TabIndex(1);
		((BaseItemControl)LabelX7).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX7).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX21 = LabelX7;
		location = new Point(134, 28);
		((Control)labelX21).set_Location(location);
		((Control)LabelX7).set_Name("LabelX7");
		LabelX labelX22 = LabelX7;
		size = new Size(107, 20);
		((Control)labelX22).set_Size(size);
		((Control)LabelX7).set_TabIndex(4);
		LabelX7.set_Text("副臂副臂lf");
		((ListControl)ll_lbfixxtlist).set_FormattingEnabled(true);
		ll_lbfixxtlist.set_ItemHeight(12);
		ListBox obj135 = ll_lbfixxtlist;
		location = new Point(247, 54);
		((Control)obj135).set_Location(location);
		((Control)ll_lbfixxtlist).set_Name("ll_lbfixxtlist");
		ListBox obj136 = ll_lbfixxtlist;
		size = new Size(107, 184);
		((Control)obj136).set_Size(size);
		((Control)ll_lbfixxtlist).set_TabIndex(1);
		((BaseItemControl)LabelX6).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX6).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX23 = LabelX6;
		location = new Point(21, 28);
		((Control)labelX23).set_Location(location);
		((Control)LabelX6).set_Name("LabelX6");
		LabelX labelX24 = LabelX6;
		size = new Size(107, 20);
		((Control)labelX24).set_Size(size);
		((Control)LabelX6).set_TabIndex(4);
		LabelX6.set_Text("副臂主臂lz");
		((ListControl)ll_lbfblf).set_FormattingEnabled(true);
		ll_lbfblf.set_ItemHeight(12);
		ListBox obj137 = ll_lbfblf;
		location = new Point(134, 54);
		((Control)obj137).set_Location(location);
		((Control)ll_lbfblf).set_Name("ll_lbfblf");
		ListBox obj138 = ll_lbfblf;
		size = new Size(107, 184);
		((Control)obj138).set_Size(size);
		((Control)ll_lbfblf).set_TabIndex(1);
		((BaseItemControl)LabelX4).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX4).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX25 = LabelX4;
		location = new Point(21, 3);
		((Control)labelX25).set_Location(location);
		((Control)LabelX4).set_Name("LabelX4");
		LabelX labelX26 = LabelX4;
		size = new Size(107, 20);
		((Control)labelX26).set_Size(size);
		((Control)LabelX4).set_TabIndex(4);
		LabelX4.set_Text("副臂统计表");
		((ListControl)ll_lbfblz).set_FormattingEnabled(true);
		ll_lbfblz.set_ItemHeight(12);
		ListBox obj139 = ll_lbfblz;
		location = new Point(21, 54);
		((Control)obj139).set_Location(location);
		((Control)ll_lbfblz).set_Name("ll_lbfblz");
		ListBox obj140 = ll_lbfblz;
		size = new Size(107, 184);
		((Control)obj140).set_Size(size);
		((Control)ll_lbfblz).set_TabIndex(1);
		ll_pagetemplist.set_AttachedControl((Control)(object)SuperTabControlPanel2);
		((BaseItem)ll_pagetemplist).set_GlobalItem(false);
		((BaseItem)ll_pagetemplist).set_Name("ll_pagetemplist");
		ll_pagetemplist.set_Text("统计数据列表");
		ll_pagetemplist.set_Visible(false);
		((BaseItemControl)ll_checkshowdatalist).get_BackgroundStyle().set_Class("");
		((BaseItemControl)ll_checkshowdatalist).get_BackgroundStyle().set_CornerType((eCornerType)1);
		CheckBoxX obj141 = ll_checkshowdatalist;
		location = new Point(863, 467);
		((Control)obj141).set_Location(location);
		((Control)ll_checkshowdatalist).set_Name("ll_checkshowdatalist");
		CheckBoxX obj142 = ll_checkshowdatalist;
		size = new Size(124, 23);
		((Control)obj142).set_Size(size);
		((BaseItemControl)ll_checkshowdatalist).set_Style((eDotNetBarStyle)7);
		((Control)ll_checkshowdatalist).set_TabIndex(3);
		ll_checkshowdatalist.set_Text("显示统计数据列表");
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX27 = LabelX2;
		location = new Point(8, 345);
		((Control)labelX27).set_Location(location);
		((Control)LabelX2).set_Name("LabelX2");
		LabelX labelX28 = LabelX2;
		size = new Size(139, 15);
		((Control)labelX28).set_Size(size);
		((Control)LabelX2).set_TabIndex(0);
		LabelX2.set_Text("当前待处理的结构形式");
		ll_txtstruct.get_Border().set_Class("TextBoxBorder");
		ll_txtstruct.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj143 = ll_txtstruct;
		location = new Point(8, 367);
		((Control)obj143).set_Location(location);
		((Control)ll_txtstruct).set_Name("ll_txtstruct");
		((TextBoxBase)ll_txtstruct).set_ReadOnly(true);
		TextBoxX obj144 = ll_txtstruct;
		size = new Size(124, 21);
		((Control)obj144).set_Size(size);
		((Control)ll_txtstruct).set_TabIndex(3);
		((BaseItemControl)LabelProgressTotal).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelProgressTotal).get_BackgroundStyle().set_CornerType((eCornerType)1);
		ProgressBarX labelProgressTotal = LabelProgressTotal;
		location = new Point(137, 366);
		((Control)labelProgressTotal).set_Location(location);
		((Control)LabelProgressTotal).set_Name("LabelProgressTotal");
		ProgressBarX labelProgressTotal2 = LabelProgressTotal;
		size = new Size(388, 23);
		((Control)labelProgressTotal2).set_Size(size);
		((Control)LabelProgressTotal).set_TabIndex(4);
		((BaseItemControl)LabelX15).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX15).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX29 = LabelX15;
		location = new Point(137, 341);
		((Control)labelX29).set_Location(location);
		((Control)LabelX15).set_Name("LabelX15");
		LabelX labelX30 = LabelX15;
		size = new Size(125, 23);
		((Control)labelX30).set_Size(size);
		((Control)LabelX15).set_TabIndex(0);
		LabelX15.set_Text("总进程正在进行.. .");
		((BaseItemControl)LabelX16).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX16).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX31 = LabelX16;
		location = new Point(555, 340);
		((Control)labelX31).set_Location(location);
		((Control)LabelX16).set_Name("LabelX16");
		LabelX labelX32 = LabelX16;
		size = new Size(158, 23);
		((Control)labelX32).set_Size(size);
		((Control)LabelX16).set_TabIndex(0);
		LabelX16.set_Text("当前文件处理进程已完成:");
		((BaseItemControl)LabelProgress).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelProgress).get_BackgroundStyle().set_CornerType((eCornerType)1);
		ProgressBarX labelProgress = LabelProgress;
		location = new Point(555, 366);
		((Control)labelProgress).set_Location(location);
		((Control)LabelProgress).set_Name("LabelProgress");
		ProgressBarX labelProgress2 = LabelProgress;
		size = new Size(422, 23);
		((Control)labelProgress2).set_Size(size);
		((Control)LabelProgress).set_TabIndex(4);
		((Control)LabelProgress).set_Text("ProgressBarX1");
		((BaseItemControl)LabelX17).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX17).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX33 = LabelX17;
		location = new Point(140, 415);
		((Control)labelX33).set_Location(location);
		((Control)LabelX17).set_Name("LabelX17");
		LabelX labelX34 = LabelX17;
		size = new Size(136, 14);
		((Control)labelX34).set_Size(size);
		((Control)LabelX17).set_TabIndex(0);
		LabelX17.set_Text("当前操作记录");
		((ListControl)ll_lbliucheng).set_FormattingEnabled(true);
		ll_lbliucheng.set_ItemHeight(12);
		ListBox obj145 = ll_lbliucheng;
		location = new Point(140, 435);
		((Control)obj145).set_Location(location);
		((Control)ll_lbliucheng).set_Name("ll_lbliucheng");
		ListBox obj146 = ll_lbliucheng;
		size = new Size(717, 124);
		((Control)obj146).set_Size(size);
		((Control)ll_lbliucheng).set_TabIndex(1);
		((Control)btnexit).set_AccessibleRole((AccessibleRole)43);
		btnexit.set_ColorTable((eButtonColor)3);
		btnexit.set_DialogResult((DialogResult)2);
		ButtonX obj147 = btnexit;
		location = new Point(865, 536);
		((Control)obj147).set_Location(location);
		((Control)btnexit).set_Name("btnexit");
		ButtonX obj148 = btnexit;
		size = new Size(114, 23);
		((Control)obj148).set_Size(size);
		((PopupItemControl)btnexit).set_Style((eDotNetBarStyle)7);
		((Control)btnexit).set_TabIndex(0);
		btnexit.set_Text("关闭");
		FrameProgressTotal.set_AutoSize(true);
		((BaseItemControl)FrameProgressTotal).get_BackgroundStyle().set_Class("");
		((BaseItemControl)FrameProgressTotal).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX frameProgressTotal = FrameProgressTotal;
		location = new Point(280, 343);
		((Control)frameProgressTotal).set_Location(location);
		((Control)FrameProgressTotal).set_Name("FrameProgressTotal");
		LabelX frameProgressTotal2 = FrameProgressTotal;
		size = new Size(19, 16);
		((Control)frameProgressTotal2).set_Size(size);
		((Control)FrameProgressTotal).set_TabIndex(0);
		FrameProgressTotal.set_Text("0%");
		FrameProgress.set_AutoSize(true);
		((BaseItemControl)FrameProgress).get_BackgroundStyle().set_Class("");
		((BaseItemControl)FrameProgress).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX frameProgress = FrameProgress;
		location = new Point(719, 343);
		((Control)frameProgress).set_Location(location);
		((Control)FrameProgress).set_Name("FrameProgress");
		LabelX frameProgress2 = FrameProgress;
		size = new Size(19, 16);
		((Control)frameProgress2).set_Size(size);
		((Control)FrameProgress).set_TabIndex(0);
		FrameProgress.set_Text("0%");
		((BaseItemControl)ll_lbecurxnname).get_BackgroundStyle().set_Class("");
		((BaseItemControl)ll_lbecurxnname).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX obj149 = ll_lbecurxnname;
		location = new Point(140, 395);
		((Control)obj149).set_Location(location);
		((Control)ll_lbecurxnname).set_Name("ll_lbecurxnname");
		LabelX obj150 = ll_lbecurxnname;
		size = new Size(416, 14);
		((Control)obj150).set_Size(size);
		((Control)ll_lbecurxnname).set_TabIndex(0);
		((FileDialog)GetOpenFilename).set_Filter("强度(*.xls)|*.xls");
		((FileDialog)GetSaveAsFilename).set_Filter("txt 文本文件|*.txt");
		((BaseItemControl)cbdisplay).get_BackgroundStyle().set_Class("");
		((BaseItemControl)cbdisplay).get_BackgroundStyle().set_CornerType((eCornerType)1);
		CheckBoxX obj151 = cbdisplay;
		location = new Point(863, 496);
		((Control)obj151).set_Location(location);
		((Control)cbdisplay).set_Name("cbdisplay");
		CheckBoxX obj152 = cbdisplay;
		size = new Size(106, 23);
		((Control)obj152).set_Size(size);
		((BaseItemControl)cbdisplay).set_Style((eDotNetBarStyle)7);
		((Control)cbdisplay).set_TabIndex(3);
		cbdisplay.set_Text("处理过程可见");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_CancelButton((IButtonControl)(object)btnexit);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		size = new Size(989, 570);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)LabelProgress);
		((Control)this).get_Controls().Add((Control)(object)ll_checkshowdatalist);
		((Control)this).get_Controls().Add((Control)(object)cbdisplay);
		((Control)this).get_Controls().Add((Control)(object)LabelProgressTotal);
		((Control)this).get_Controls().Add((Control)(object)ll_txtstruct);
		((Control)this).get_Controls().Add((Control)(object)MultiPage);
		((Control)this).get_Controls().Add((Control)(object)ll_lbliucheng);
		((Control)this).get_Controls().Add((Control)(object)ll_lbzplist);
		((Control)this).get_Controls().Add((Control)(object)LabelX16);
		((Control)this).get_Controls().Add((Control)(object)btnexit);
		((Control)this).get_Controls().Add((Control)(object)ll_lbecurxnname);
		((Control)this).get_Controls().Add((Control)(object)LabelX17);
		((Control)this).get_Controls().Add((Control)(object)FrameProgress);
		((Control)this).get_Controls().Add((Control)(object)FrameProgressTotal);
		((Control)this).get_Controls().Add((Control)(object)LabelX15);
		((Control)this).get_Controls().Add((Control)(object)LabelX2);
		((Control)this).get_Controls().Add((Control)(object)LabelX1);
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("ll_ufxnonly1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("ANSYS 11.0 单项性能表生成...");
		((ISupportInitialize)MultiPage).EndInit();
		((Control)MultiPage).ResumeLayout(false);
		((Control)SuperTabControlPanel4).ResumeLayout(false);
		((Control)ll_frmfb).ResumeLayout(false);
		((Control)SuperTabControlPanel3).ResumeLayout(false);
		((Control)ll_frmminrf).ResumeLayout(false);
		((Control)SuperTabControlPanel1).ResumeLayout(false);
		((ISupportInitialize)ll_txtchai).EndInit();
		((Control)SuperTabControlPanel2).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void ll_ufxnonly1_Load(object sender, EventArgs e)
	{
		((Control)ll_btncsv2tempxls).set_Enabled(false);
		((Control)ll_btnfbcsv2tempxls).set_Enabled(false);
		((Control)ll_btnzbxnall).set_Enabled(false);
		((Control)ll_btnfbxnall).set_Enabled(false);
		((Control)ll_checkshowdatalist).set_BackColor(Color.Transparent);
		((Control)LabelX3).set_BackColor(Color.Transparent);
		((Control)ll_checkLZ).set_BackColor(Color.Transparent);
		((Control)ll_lbenamejxformat).set_BackColor(Color.Transparent);
		((Control)ll_checkLZqd).set_BackColor(Color.Transparent);
		((Control)ll_lbenamejxformat2).set_BackColor(Color.Transparent);
		fname = Application.get_StartupPath() + "\\config\\装配列表说明.ini";
		Mod1.lr = new StreamReader(fname, Encoding.Default);
		string text = "";
		while (true)
		{
			if (!Information.IsNothing((object)text))
			{
				text = Mod1.lr.ReadLine();
				if (!Information.IsNothing((object)text))
				{
					if (Operators.CompareString(Strings.Trim(text), "", false) != 0)
					{
						ll_lbzplist.get_Items().Add((object)text);
						continue;
					}
					break;
				}
			}
			Mod1.lr.Close();
			Mod1.lr.Dispose();
			((Control)SuperTabControlPanel1).set_Enabled(false);
			((Control)ll_frmfb).set_Enabled(false);
			((Control)ll_btnfromall).set_Enabled(false);
			((Control)ll_btnnameformat2).set_Enabled(false);
			((Control)ll_btnzbxnallqd).set_Enabled(false);
			((Control)ll_btnfbxnallqd).set_Enabled(false);
			break;
		}
	}

	private void ll_lbzplist_DoubleClick(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectNotEqual((object)((TextBox)ll_txtstruct).get_Text(), ll_lbzplist.get_Items().get_Item(ll_lbzplist.get_SelectedIndex()), false))
		{
			((Control)ll_btncsv2tempxls).set_Enabled(false);
			((Control)ll_btnfbcsv2tempxls).set_Enabled(false);
			((Control)ll_btnzbxnall).set_Enabled(false);
			((Control)ll_btnfbxnall).set_Enabled(false);
			((Control)ll_btnzbxnallqd).set_Enabled(false);
			((Control)ll_btnfbxnallqd).set_Enabled(false);
			ll_lbcsvlist.get_Items().Clear();
			ll_lbcheckresult.get_Items().Clear();
			((TextBox)ll_txtpath).set_Text("");
			ll_lbfblcnamelist.get_Items().Clear();
			ll_lbfblcnamecheckresult.get_Items().Clear();
			((TextBox)ll_txtfbnameformat).set_Text("");
			((TextBox)ll_txtfbformat).set_Text("");
			ll_lbefbnamejxformat.set_Text("");
			ll_lbtempxlslist.get_Items().Clear();
			ll_lblcnamelist.get_Items().Clear();
			ll_lblcnamecheckresult.get_Items().Clear();
			((TextBox)ll_txtnameformat).set_Text("");
			((TextBox)ll_txtformat).set_Text("");
			ll_lbenamejxformat.set_Text("");
		}
		((TextBox)ll_txtstruct).set_Text(Conversions.ToString(ll_lbzplist.get_Items().get_Item(ll_lbzplist.get_SelectedIndex())));
		curstructchname = ((TextBox)ll_txtstruct).get_Text();
		xnxlsname = ((TextBox)ll_txtstruct).get_Text();
	}

	private void ll_btnpath_Click(object sender, EventArgs e)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Invalid comparison between Unknown and I4
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			ll_lbtempxlslist.get_Items().Clear();
			if (Operators.CompareString(Strings.Trim(((TextBox)ll_txtstruct).get_Text()), "", false) == 0)
			{
				Interaction.MsgBox((object)"请先选择结构形式.", (MsgBoxStyle)0, (object)"提示");
				return;
			}
			FolderBrowserDialog val = new FolderBrowserDialog();
			val.set_Description("请指定某文件夹,要求其中含有Ansys11.0 性能计算成功后输出的基本数据csv文件");
			((CommonDialog)val).ShowDialog();
			string selectedPath = val.get_SelectedPath();
			string text = default(string);
			if (Operators.CompareString(selectedPath, "", false) != 0)
			{
				text = selectedPath;
			}
			if (Operators.CompareString(Strings.Trim(text), "", false) == 0)
			{
				return;
			}
			((TextBox)ll_txtpath).set_Text(text);
			curstructpath = ((TextBox)ll_txtpath).get_Text();
			tempxlspath = text + "\\tempxls";
			if (!Directory.Exists(tempxlspath))
			{
				FileSystem.MkDir(tempxlspath);
			}
			else
			{
				string text2 = "当前已经存在文件夹:" + tempxlspath + " 是否继续?";
				if ((int)MessageBox.Show(text2, "提示", (MessageBoxButtons)4, (MessageBoxIcon)64) == 7)
				{
					ll_lbliucheng.get_Items().Add((object)("当前已经存在文件夹:" + tempxlspath + "建议先删除再继续本次操作."));
					return;
				}
				ll_lbliucheng.get_Items().Add((object)("接下来的输出文件将覆盖文件夹:" + tempxlspath + "中已有文件."));
			}
			string path = ((TextBox)ll_txtpath).get_Text() + "\\";
			ll_lbcsvlist.get_Items().Clear();
			ll_lbcheckresult.get_Items().Clear();
			string[] files = Directory.GetFiles(path, "*.csv", SearchOption.TopDirectoryOnly);
			checked
			{
				int num = files.Count() - 1;
				for (int i = 0; i <= num; i++)
				{
					ll_lbcsvlist.get_Items().Add((object)files[i]);
				}
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

	private void ll_btncsvall_Click(object sender, EventArgs e)
	{
		checked
		{
			int num = ll_lbcsvlist.get_Items().get_Count() - 1;
			for (int i = 0; i <= num; i++)
			{
				ll_lbcsvlist.SetSelected(i, true);
			}
		}
	}

	private void ll_btncsvother_Click(object sender, EventArgs e)
	{
		checked
		{
			int num = ll_lbcsvlist.get_Items().get_Count() - 1;
			for (int i = 0; i <= num; i++)
			{
				if (ll_lbcsvlist.GetSelected(i))
				{
					ll_lbcsvlist.SetSelected(i, false);
				}
				else
				{
					ll_lbcsvlist.SetSelected(i, true);
				}
			}
		}
	}

	private void ll_checkthis_Click(object sender, EventArgs e)
	{
		if (ll_lbcsvlist.get_Items().get_Count() == 0)
		{
			return;
		}
		ll_lbcheckresult.get_Items().Clear();
		checked
		{
			int num = ll_lbcsvlist.get_Items().get_Count() - 1;
			int num2 = 0;
			string text;
			while (true)
			{
				if (num2 > num)
				{
					return;
				}
				if (ll_lbcsvlist.GetSelected(num2))
				{
					if (Operators.CompareString(curstruct, "zb", false) == 0)
					{
						((Control)ll_btncsv2tempxls).set_Enabled(true);
						((Control)ll_btnfbcsv2tempxls).set_Enabled(false);
						((Control)ll_btncsv2tempxls).set_ForeColor(Color.Green);
					}
					text = Conversions.ToString(ll_lbcsvlist.get_Items().get_Item(num2));
					int num3 = Strings.InStrRev(text, "\\", -1, (CompareMethod)0);
					curtempxlsname = Strings.Right(text, Strings.Len(text) - num3);
					curtempxlsname = Strings.Left(curtempxlsname, Strings.Len(curtempxlsname) - 4);
					if (Operators.CompareString(Mod1.toch(Strings.UCase(curtempxlsname)), "", false) == 0)
					{
						break;
					}
					ll_lbcheckresult.get_Items().Add((object)Mod1.toch(Strings.UCase(curtempxlsname)));
				}
				else
				{
					ll_lbcheckresult.get_Items().Add((object)" ");
				}
				num2++;
			}
			ll_lbliucheng.get_Items().Add((object)("当前预处理文件名:" + text + " 不是合适的名称."));
			ll_lbliucheng.get_Items().Add((object)"注意:文件名只能为QD/GD/BFG/CQGSS/HQZ.即强度/刚度/变幅缸/超起钢丝绳/回转倾翻支腿");
			ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
			((Control)ll_btncsv2tempxls).set_Enabled(false);
			((Control)ll_btnfbcsv2tempxls).set_Enabled(false);
		}
	}

	private void ll_btncsv2tempxls_Click(object sender, EventArgs e)
	{
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		LabelProgress.set_Value(0);
		FrameProgress.set_Text("0%");
		((Control)FrameProgress).Refresh();
		LabelProgressTotal.set_Value(0);
		FrameProgressTotal.set_Text("0%");
		((Control)this).set_Cursor(Cursors.get_AppStarting());
		ll_lbfblz.get_Items().Clear();
		ll_lbfblf.get_Items().Clear();
		ll_lbfixxtlist.get_Items().Clear();
		ll_lbzbxtlist.get_Items().Clear();
		ll_lbxtlist.get_Items().Clear();
		ll_lbpzlist.get_Items().Clear();
		ll_lbnamelist.get_Items().Clear();
		bpzTglobal = true;
		int num = 0;
		checked
		{
			int num2 = ll_lbcsvlist.get_Items().get_Count() - 1;
			for (int i = 0; i <= num2; i++)
			{
				if (ll_lbcsvlist.GetSelected(i))
				{
					num++;
				}
			}
			if (num == 0)
			{
				Interaction.MsgBox((object)"当前没有选择任何合法的csv文件,本次操作终止.", (MsgBoxStyle)0, (object)"提示");
				return;
			}
			int num3 = 0;
			LabelProgressTotal.set_Maximum(num);
			int num4 = ll_lbcsvlist.get_Items().get_Count() - 1;
			bool flag = default(bool);
			bool flag2 = default(bool);
			for (int j = 0; j <= num4; j++)
			{
				if (!ll_lbcsvlist.GetSelected(j))
				{
					continue;
				}
				ll_lbecurxnname.set_Text(Conversions.ToString(ll_lbcsvlist.get_Items().get_Item(j)));
				((Control)ll_lbecurxnname).Refresh();
				num3++;
				LabelProgressTotal.set_Value(num3);
				((Control)LabelProgressTotal).Refresh();
				FrameProgressTotal.set_Text(Conversions.ToString(Convert.ToInt32((double)num3 / (double)num * 100.0)) + ".0%");
				((Control)FrameProgressTotal).Refresh();
				string text = Conversions.ToString(ll_lbcsvlist.get_Items().get_Item(j));
				int num5 = Strings.InStrRev(text, "\\", -1, (CompareMethod)0);
				curtempxlsname = Strings.Right(text, Strings.Len(text) - num5);
				curtempxlsname = Strings.Left(curtempxlsname, Strings.Len(curtempxlsname) - 4);
				string text2 = Conversions.ToString(ll_lbcsvlist.get_Items().get_Item(j));
				LabelProgress.set_Value(10);
				FrameProgress.set_Text("10.0%");
				((Control)FrameProgress).Refresh();
				curcsv2curall(text2);
				shALL = (Worksheet)XLSALL.Sheets[1];
				shALL.Activate();
				Excel.Range currentRegion = ((_Worksheet)shALL).get_Range((object)"A1", (object)Missing.Value).CurrentRegion;
				int count = currentRegion.Columns.Count;
				int count2 = currentRegion.Rows.Count;
				bhqz = false;
				int num6 = count;
				for (int k = 2; k <= num6; k++)
				{
					text = Conversions.ToString(NewLateBinding.LateGet(shALL.Cells[1, k], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null));
					if (Operators.CompareString(Strings.Trim(text), "", false) != 0)
					{
						num5 = Strings.InStr(1, text, "_配重", (CompareMethod)0);
						if (num5 > 0)
						{
							bhqz = true;
							break;
						}
					}
				}
				LabelProgress.set_Value(20);
				FrameProgress.set_Text("20.0%");
				((Control)FrameProgress).Refresh();
				curlcname = new string[count2 + 1];
				int num7 = count2;
				for (int l = 2; l <= num7; l++)
				{
					curlcname[l] = Conversions.ToString(NewLateBinding.LateGet(shALL.Cells[l, 1], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null));
				}
				LabelProgress.set_Value(30);
				FrameProgress.set_Text("30.0%");
				((Control)FrameProgress).Refresh();
				if (bhqz)
				{
					currentRegion = ((_Worksheet)shALL).get_Range(RuntimeHelpers.GetObjectValue(shALL.Cells[1, 2]), RuntimeHelpers.GetObjectValue(shALL.Cells[1, count]));
					currentRegion.Select();
					CurRangeNameDef();
					ll_lbnamelist.get_Items().Clear();
					ll_lbpzlist.get_Items().Clear();
					int num8 = count;
					for (int m = 1; m <= num8; m++)
					{
						Mod1.curvalue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(shALL.Cells[1, m], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null));
						num5 = Strings.InStr(1, Conversions.ToString(Mod1.curvalue), "配重", (CompareMethod)0);
						if (num5 <= 0)
						{
							continue;
						}
						if (Operators.CompareString(Strings.Right(Strings.UCase(Strings.Trim(Conversions.ToString(Mod1.curvalue))), 1), "T", false) != 0)
						{
							bpzTglobal = false;
						}
						string[] array = Strings.Split(Conversions.ToString(Mod1.curvalue), "_配重", -1, (CompareMethod)0);
						int num9 = ll_lbnamelist.get_Items().get_Count() - 1;
						for (int n = 0; n <= num9; n++)
						{
							flag = false;
							if (Operators.ConditionalCompareObjectEqual((object)Strings.Trim(array[0]), ll_lbnamelist.get_Items().get_Item(n), false))
							{
								flag = true;
								break;
							}
						}
						if (!flag)
						{
							ll_lbnamelist.get_Items().Add((object)array[0]);
						}
						int num10 = ll_lbpzlist.get_Items().get_Count() - 1;
						for (int num11 = 0; num11 <= num10; num11++)
						{
							flag2 = false;
							if (Operators.ConditionalCompareObjectEqual((object)Strings.Trim(array[1]), ll_lbpzlist.get_Items().get_Item(num11), false))
							{
								flag2 = true;
								break;
							}
						}
						if (!flag2)
						{
							ll_lbpzlist.get_Items().Add((object)array[1]);
						}
					}
					int num12 = ll_lbpzlist.get_Items().get_Count() - 1;
					for (int num13 = 0; num13 <= num12; num13++)
					{
						text = Conversions.ToString(ll_lbpzlist.get_Items().get_Item(num13));
						bpzT = false;
						if (Operators.CompareString(Strings.Right(Strings.UCase(Strings.Trim(text)), 1), "T", false) == 0)
						{
							bpzT = true;
						}
						if (bpzT)
						{
							text = Strings.Left(text, Strings.Len(text) - 1);
						}
						ll_lbpzlist.get_Items().set_Item(num13, (object)text);
					}
					LabelProgress.set_Value(50);
					FrameProgress.set_Text("50.0%");
					((Control)FrameProgress).Refresh();
					for (int num14 = ll_lbpzlist.get_Items().get_Count() - 1; num14 <= 0; num14++)
					{
						text = Conversions.ToString(ll_lbpzlist.get_Items().get_Item(num14));
						if (num14 < 1)
						{
							continue;
						}
						int num15 = num14 - 1;
						for (int num16 = 0; num16 <= num15; num16++)
						{
							if (Operators.ConditionalCompareObjectEqual((object)text, ll_lbpzlist.get_Items().get_Item(num16), false))
							{
								ll_lbpzlist.get_Items().RemoveAt(num14);
								break;
							}
						}
					}
					int num17 = ll_lbnamelist.get_Items().get_Count() - 1;
					for (int num18 = 0; num18 <= num17; num18++)
					{
						int num19 = ll_lbpzlist.get_Items().get_Count() - 1;
						for (int num20 = 0; num20 <= num19; num20++)
						{
							string text3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(ll_lbnamelist.get_Items().get_Item(num18), (object)"_配重"), ll_lbpzlist.get_Items().get_Item(num20)));
							if (bpzTglobal)
							{
								text3 += "T";
							}
							GenSheets(Conversions.ToString(ll_lbpzlist.get_Items().get_Item(num20)), text3, "ALL");
						}
					}
					LabelProgress.set_Value(60);
					FrameProgress.set_Text("60.0%");
					((Control)FrameProgress).Refresh();
					int num21 = ll_lbnamelist.get_Items().get_Count() - 1;
					for (int num22 = 0; num22 <= num21; num22++)
					{
						mergenamei(Conversions.ToString(ll_lbnamelist.get_Items().get_Item(num22)), tempxlspath);
						ll_lbliucheng.get_Items().Add(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat("输出基本xls文件;" + tempxlspath, "\\"), ll_lbnamelist.get_Items().get_Item(num22)), (object)".xls"));
						ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
						ll_lbliucheng.Refresh();
					}
					int num23 = ll_lbnamelist.get_Items().get_Count() - 1;
					for (int num24 = 0; num24 <= num23; num24++)
					{
						int num25 = ll_lbpzlist.get_Items().get_Count() - 1;
						for (int num26 = 0; num26 <= num25; num26++)
						{
							string text3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(ll_lbnamelist.get_Items().get_Item(num24), (object)"_配重"), ll_lbpzlist.get_Items().get_Item(num26)));
							if (bpzTglobal)
							{
								text3 += "T";
							}
							Mod1.excelapp.DisplayAlerts = false;
							NewLateBinding.LateCall(Mod1.excelapp.Sheets[text3], (Type)null, "Delete", new object[0], (string[])null, (Type[])null, (bool[])null, true);
							Mod1.excelapp.DisplayAlerts = true;
						}
					}
					LabelProgress.set_Value(70);
					FrameProgress.set_Text("70.0%");
					((Control)FrameProgress).Refresh();
				}
				else if (Operators.CompareString(curstruct, "zb", false) == 0)
				{
					int num27 = count2;
					for (int num28 = 2; num28 <= num27; num28++)
					{
						NewLateBinding.LateSetComplex(shALL.Cells[num28, 1], (Type)null, "Value", new object[1] { curlcname[num28] + "_PZ" }, (string[])null, (Type[])null, false, true);
					}
					Worksheet worksheet = (Worksheet)XLSALL.Worksheets["ALL"];
					string filename = Application.get_StartupPath() + "\\config\\TempALL.xls";
					if (!Mod1.WorkbookIsOpen("TempALL.xls"))
					{
						Mod1.excelapp.Workbooks.Open(filename, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
					}
					else
					{
						Mod1.excelapp.Windows["TempALL.xls"].Activate();
					}
					object obj = Mod1.excelapp.Worksheets["ALL"];
					worksheet.Cells.Copy(Missing.Value);
					NewLateBinding.LateCall(NewLateBinding.LateGet(obj, (Type)null, "Range", new object[1] { "A1" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Select", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					NewLateBinding.LateCall(obj, (Type)null, "Paste", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					obj = null;
					LabelProgress.set_Value(80);
					FrameProgress.set_Text("80.0%");
					((Control)FrameProgress).Refresh();
					Mod1.excelapp.Windows["TempALL.xls"].Activate();
					Mod1.excelapp.DisplayAlerts = false;
					Mod1.excelapp.ActiveWorkbook.SaveAs(tempxlspath + "\\" + Mod1.toch(Strings.UCase(curtempxlsname)) + ".xls", Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, XlSaveAsAccessMode.xlNoChange, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
					Mod1.excelapp.ActiveWindow.Close(Missing.Value, Missing.Value, Missing.Value);
					ll_lbliucheng.get_Items().Add((object)("输出基本xls文件;" + tempxlspath + "\\" + Mod1.toch(Strings.UCase(curtempxlsname)) + ".xls"));
					ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
					ll_lbliucheng.Refresh();
				}
				LabelProgress.set_Value(100);
				FrameProgress.set_Text("100%");
				((Control)FrameProgress).Refresh();
				Mod1.excelapp.DisplayAlerts = false;
				XLSALL.Close(Missing.Value, Missing.Value, Missing.Value);
				ll_lbliucheng.get_Items().Add((object)(ll_lbecurxnname.get_Text() + "当前处理总进程:" + Conversions.ToString((double)num3 / (double)num * 100.0) + "%"));
				ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
				ll_lbliucheng.Refresh();
			}
			FrameProgressTotal.set_Text("100%");
			zbini();
			((Control)this).set_Cursor(Cursors.get_Arrow());
		}
	}

	public void UpdateProgressTotal(object Pct)
	{
		ll_ufxnonly1 ll_ufxnonly2 = this;
		ll_ufxnonly2.FrameProgressTotal.set_Text(Strings.Format(RuntimeHelpers.GetObjectValue(Pct), "0"));
		ll_ufxnonly2.LabelProgressTotal.set_Value(Convert.ToInt32(Operators.MultiplyObject(Pct, (object)(Conversions.ToDouble(FrameProgressTotal.get_Text()) - 10.0))));
		((Control)ll_ufxnonly2).Refresh();
		ll_ufxnonly2 = null;
	}

	public void UpdateProgress(object Pct)
	{
		ll_ufxnonly1 ll_ufxnonly2 = this;
		ll_ufxnonly2.FrameProgress.set_Text(Strings.Format(RuntimeHelpers.GetObjectValue(Pct), "0"));
		ll_ufxnonly2.LabelProgress.set_Value(Convert.ToInt32(Operators.MultiplyObject(Pct, (object)(Conversions.ToDouble(FrameProgress.get_Text()) - 10.0))));
		((Control)ll_ufxnonly2).Refresh();
		ll_ufxnonly2 = null;
	}

	private void curcsv2curall(string fname)
	{
		if (Operators.CompareString(Strings.Trim(fname), "", false) == 0 || !File.Exists(Application.get_StartupPath() + "\\config\\ALL.xls"))
		{
			return;
		}
		XLSALL = Mod1.excelapp.Workbooks.Open(Application.get_StartupPath() + "\\config\\ALL.xls", Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
		shALL = (Worksheet)XLSALL.Sheets["ALL"];
		shALL.Cells.Delete(Missing.Value);
		checked
		{
			if (File.Exists(fname))
			{
				int num = 0;
				Mod1.lr = new StreamReader(fname, Encoding.Default);
				string text = "";
				while (!Information.IsNothing((object)text))
				{
					text = Mod1.lr.ReadLine();
					if (Information.IsNothing((object)text))
					{
						break;
					}
					if (Operators.CompareString(Strings.Trim(text), "", false) != 0)
					{
						num++;
						string[] array = Strings.Split(text, ",", -1, (CompareMethod)0);
						int num2 = Information.UBound((Array)array, 1);
						for (int i = 0; i <= num2; i++)
						{
							NewLateBinding.LateSetComplex(shALL.Cells[num, i + 1], (Type)null, "value", new object[1] { Strings.Trim(array[i]) }, (string[])null, (Type[])null, false, true);
						}
					}
				}
				Mod1.lr.Close();
				Mod1.lr.Dispose();
			}
			string text2 = "导入当前csv文件:" + fname + "到临时工作表[ALL]";
			ll_lbliucheng.get_Items().Add((object)text2);
			ll_lbliucheng.Refresh();
			shALL.Activate();
		}
	}

	public void CurRangeNameDef()
	{
		checked
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = ((IEnumerable)Mod1.excelapp.Selection).GetEnumerator();
				while (enumerator.MoveNext())
				{
					Excel.Range range = (Excel.Range)enumerator.Current;
					if (range == null)
					{
						continue;
					}
					string text = Conversions.ToString(range.get_Value((object)Missing.Value));
					if (Q_JS.RangeNameExists(text))
					{
						int num = Mod1.excelapp.ActiveWorkbook.Names.Count - 1;
						int i;
						for (i = 0; i <= num; i++)
						{
							Name name = (Name)Mod1.excelapp.ActiveWorkbook.Names.Cast<object>().ElementAtOrDefault(i);
							if (Operators.CompareString(Strings.UCase(name.Name), Strings.UCase(text), false) == 0)
							{
								break;
							}
						}
						NewLateBinding.LateCall(Mod1.excelapp.ActiveWorkbook.Names.Cast<object>().ElementAtOrDefault(i), (Type)null, "Delete", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					}
					if (!Q_JS.RangeNameExists(text))
					{
						range.Select();
						string text2 = Conversions.ToString(NewLateBinding.LateGet(XLSALL.ActiveSheet, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null));
						int row = Mod1.excelapp.ActiveCell.Row;
						int column = Mod1.excelapp.ActiveCell.Column;
						string refersToR1C = "=" + text2 + "!R" + Conversions.ToString(row) + "C" + Conversions.ToString(column);
						Mod1.excelapp.ActiveWorkbook.Names.Add(RuntimeHelpers.GetObjectValue(range.get_Value((object)Missing.Value)), Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, refersToR1C, Missing.Value);
					}
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
	}

	private void mergenamei(string namei, string hqztemps)
	{
		string filename = Application.get_StartupPath() + "\\config\\TempALL.xls";
		if (!Mod1.WorkbookIsOpen("TempALL.xls"))
		{
			XLSTempALL = Mod1.excelapp.Workbooks.Open(filename, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
		}
		else
		{
			Mod1.excelapp.Windows["TempALL.xls"].Activate();
		}
		Mod1.excelapp.Windows["TempALL.xls"].Activate();
		shTemp = (Worksheet)XLSTempALL.Worksheets["ALL"];
		int num = 0;
		_ = XLSTempALL.Worksheets["ALL"];
		checked
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = XLSALL.Sheets.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Worksheet worksheet = (Worksheet)enumerator.Current;
					if (Strings.InStr(1, worksheet.Name, namei, (CompareMethod)0) != 0)
					{
						num++;
						if (num == 1)
						{
							worksheet.Cells.Copy(Missing.Value);
							((_Worksheet)shTemp).get_Range((object)"A1", (object)Missing.Value).Select();
							shTemp.Paste(Missing.Value, Missing.Value);
							continue;
						}
						shTemp = (Worksheet)XLSTempALL.Worksheets["ALL"];
						int count = ((_Worksheet)shTemp).get_Range((object)"A1", (object)Missing.Value).CurrentRegion.Rows.Count;
						int count2 = ((_Worksheet)worksheet).get_Range((object)"A1", (object)Missing.Value).CurrentRegion.Rows.Count;
						string rowIndex = "2:" + Conversions.ToString(count2);
						NewLateBinding.LateCall(worksheet.Rows[rowIndex, Missing.Value], (Type)null, "Copy", new object[0], (string[])null, (Type[])null, (bool[])null, true);
						NewLateBinding.LateCall(shTemp.Cells[count + 1, 1], (Type)null, "Select", new object[0], (string[])null, (Type[])null, (bool[])null, true);
						shTemp.Paste(Missing.Value, Missing.Value);
					}
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			Mod1.excelapp.Windows["TempALL.xls"].Activate();
			Mod1.excelapp.DisplayAlerts = false;
			Mod1.excelapp.ActiveWorkbook.SaveAs(hqztemps + "\\" + namei + ".xls", Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, XlSaveAsAccessMode.xlNoChange, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
			Mod1.excelapp.ActiveWindow.Close(Missing.Value, Missing.Value, Missing.Value);
			Mod1.excelapp.DisplayAlerts = true;
		}
	}

	private void GenSheets(string curpz, string currangename, string hqzname)
	{
		Worksheet worksheet = (Worksheet)XLSALL.Sheets[hqzname];
		int column = ((_Worksheet)worksheet).get_Range((object)currangename, (object)Missing.Value).Column;
		NewLateBinding.LateCall(worksheet.Columns[column, Missing.Value], (Type)null, "Select", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		Mod1.excelapp.CutCopyMode = (XlCutCopyMode)0;
		NewLateBinding.LateCall(Mod1.excelapp.Selection, (Type)null, "Copy", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		column = ((_Worksheet)worksheet).get_Range((object)"计算吊重", (object)Missing.Value).Column;
		NewLateBinding.LateCall(worksheet.Columns[column, Missing.Value], (Type)null, "Select", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		worksheet.Paste(Missing.Value, Missing.Value);
		int count = ((_Worksheet)worksheet).get_Range((object)"A1", (object)Missing.Value).CurrentRegion.Rows.Count;
		int num = count;
		for (int i = 2; i <= num; i = checked(i + 1))
		{
			worksheet.Cells[i, 1] = Strings.Trim(curlcname[i]) + "_" + curpz;
		}
		if (Q_JS.SheetExists(currangename))
		{
			Mod1.excelapp.DisplayAlerts = false;
			Mod1.excelapp.DisplayAlerts = true;
		}
		shALL = (Worksheet)XLSALL.Sheets.Add(Missing.Value, Missing.Value, Missing.Value, Missing.Value);
		shALL.Name = currangename;
		worksheet.Cells.Copy(Missing.Value);
		shALL.Select(Missing.Value);
		shALL.Paste(Missing.Value, Missing.Value);
		worksheet.Activate();
	}

	private void zbini()
	{
		if (!Directory.Exists(curstructpath + "\\" + xnxlsname))
		{
			FileSystem.MkDir(curstructpath + "\\" + xnxlsname);
		}
		fname = curstructpath + "\\" + xnxlsname + "\\" + xnxlsname + ".ini";
		Mod1.wr = new StreamWriter(fname, append: false, Encoding.Default);
		Mod1.wr.WriteLine(strlist2ini("配重_", ll_lbpzlist));
		checked
		{
			int num = ll_lbnamelist.get_Items().get_Count() - 1;
			for (int i = 0; i <= num; i++)
			{
				bool flag = true;
				string text = Conversions.ToString(ll_lbnamelist.get_Items().get_Item(i));
				string[] array = Strings.Split(text, "_", -1, (CompareMethod)0);
				if (Information.UBound((Array)array, 1) < 1)
				{
					continue;
				}
				int num2 = ll_lbztkjlist.get_Items().get_Count() - 1;
				for (int j = 0; j <= num2; j++)
				{
					if (Operators.ConditionalCompareObjectEqual((object)array[0], ll_lbztkjlist.get_Items().get_Item(j), false))
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					ll_lbztkjlist.get_Items().Add((object)array[0]);
				}
			}
			Mod1.wr.WriteLine(strlist2ini("支腿跨距_", ll_lbztkjlist));
			Mod1.wr.Close();
			Mod1.wr.Dispose();
			ll_lbliucheng.get_Items().Add((object)("生成索引文件;" + fname));
			ll_lbliucheng.Refresh();
			ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
		}
	}

	private string strlist2ini(string namei, ListBox lb)
	{
		string text = namei;
		checked
		{
			int num = lb.get_Items().get_Count() - 1;
			for (int i = 0; i <= num; i++)
			{
				if (Operators.CompareString(Strings.Trim(Conversions.ToString(lb.get_Items().get_Item(i))), "", false) != 0)
				{
					text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)text, lb.get_Items().get_Item(i)), (object)","));
				}
			}
			return text + "ALL";
		}
	}

	private void ll_btnfbcsv2tempxls_Click(object sender, EventArgs e)
	{
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		ll_lbfblz.get_Items().Clear();
		ll_lbfblf.get_Items().Clear();
		ll_lbfixxtlist.get_Items().Clear();
		ll_lbzbxtlist.get_Items().Clear();
		ll_lbxtlist.get_Items().Clear();
		ll_lbpzlist.get_Items().Clear();
		ll_lbnamelist.get_Items().Clear();
		bpzTglobal = true;
		((Control)this).set_Cursor(Cursors.get_AppStarting());
		LabelProgress.set_Value(0);
		FrameProgress.set_Text("0%");
		((Control)FrameProgress).Refresh();
		LabelProgressTotal.set_Value(0);
		FrameProgressTotal.set_Text("0%");
		int num = 0;
		checked
		{
			int num2 = ll_lbcsvlist.get_Items().get_Count() - 1;
			for (int i = 0; i <= num2; i++)
			{
				if (ll_lbcsvlist.GetSelected(i))
				{
					num++;
				}
			}
			if (num == 0)
			{
				Interaction.MsgBox((object)"当前没有选择任何合法的csv文件,本次操作终止.", (MsgBoxStyle)0, (object)"提示");
				return;
			}
			int num3 = 0;
			LabelProgressTotal.set_Maximum(num);
			int num4 = ll_lbcsvlist.get_Items().get_Count() - 1;
			int num6 = default(int);
			int num8 = default(int);
			bool flag = default(bool);
			bool flag2 = default(bool);
			for (int j = 0; j <= num4; j++)
			{
				((Control)this).Refresh();
				if (!ll_lbcsvlist.GetSelected(j))
				{
					continue;
				}
				num3++;
				LabelProgressTotal.set_Value(num3);
				((Control)LabelProgressTotal).Refresh();
				FrameProgressTotal.set_Text(Conversions.ToString(Convert.ToInt32((double)num3 / (double)num * 100.0)) + ".0%");
				((Control)FrameProgressTotal).Refresh();
				ll_lbliucheng.get_Items().Add((object)(ll_lbecurxnname.get_Text() + "处理进程:" + Conversions.ToString((double)num3 / (double)num)));
				ll_lbecurxnname.set_Text(Conversions.ToString(ll_lbcsvlist.get_Items().get_Item(j)));
				((Control)ll_lbecurxnname).Refresh();
				ll_lbliucheng.Refresh();
				string text = Conversions.ToString(ll_lbcsvlist.get_Items().get_Item(j));
				int num5 = Strings.InStrRev(text, "\\", -1, (CompareMethod)0);
				curtempxlsname = Strings.Right(text, Strings.Len(text) - num5);
				curtempxlsname = Strings.Left(curtempxlsname, Strings.Len(curtempxlsname) - 4);
				LabelProgress.set_Value(10);
				FrameProgress.set_Text("10.0%");
				((Control)FrameProgress).Refresh();
				string text2 = (fname = Conversions.ToString(ll_lbcsvlist.get_Items().get_Item(j)));
				if (Operators.CompareString(Strings.Trim(fname), "", false) == 0)
				{
					return;
				}
				if (File.Exists(fname))
				{
					Mod1.lr = new StreamReader(fname, Encoding.Default);
					string text3 = "";
					num6 = 0;
					while (!Information.IsNothing((object)text3))
					{
						text3 = Mod1.lr.ReadLine();
						if (Information.IsNothing((object)text3))
						{
							break;
						}
						if (Operators.CompareString(Strings.Trim(text3), "", false) != 0)
						{
							num6++;
						}
					}
					Mod1.lr.Close();
					Mod1.lr.Dispose();
					curlcname = new string[num6 + 1];
					num6 = 1;
					Mod1.lr = new StreamReader(fname, Encoding.Default);
					text3 = "";
					while (!Information.IsNothing((object)text3))
					{
						text3 = Mod1.lr.ReadLine();
						if (Information.IsNothing((object)text3))
						{
							break;
						}
						if (Operators.CompareString(Strings.Trim(text3), "", false) != 0)
						{
							if (num6 == 1)
							{
								curlcname[1] = text3;
								num6++;
							}
							else
							{
								string[] array = Strings.Split(text3, ",", -1, (CompareMethod)0);
								curlcname[num6] = Strings.Trim(array[0]);
								num6++;
							}
						}
					}
					Mod1.lr.Close();
					Mod1.lr.Dispose();
				}
				num6--;
				int num7 = num6;
				for (int k = 2; k <= num7; k++)
				{
					bnewxt = true;
					string[] array = Strings.Split(curlcname[k], "_", -1, (CompareMethod)0);
					num8 = Conversions.ToInteger(((TextBox)ll_txtfblz).get_Text()) - 1;
					if (Information.UBound((Array)array, 1) < num8)
					{
						continue;
					}
					int num9 = ll_lbfblz.get_Items().get_Count() - 1;
					for (int l = 0; l <= num9; l++)
					{
						if (Operators.ConditionalCompareObjectEqual(ll_lbfblz.get_Items().get_Item(l), (object)array[num8], false))
						{
							bnewxt = false;
							break;
						}
					}
					if (bnewxt)
					{
						ll_lbfblz.get_Items().Add((object)array[num8]);
					}
				}
				LabelProgress.set_Value(20);
				FrameProgress.set_Text("20.0%");
				((Control)FrameProgress).Refresh();
				int num10 = num6;
				for (int m = 2; m <= num10; m++)
				{
					bnewxt = true;
					string[] array = Strings.Split(curlcname[m], "_", -1, (CompareMethod)0);
					num8 = Conversions.ToInteger(((TextBox)ll_txtfblf).get_Text()) - 1;
					if (Information.UBound((Array)array, 1) < num8)
					{
						continue;
					}
					int num11 = ll_lbfblf.get_Items().get_Count() - 1;
					for (int n = 0; n <= num11; n++)
					{
						if (Operators.ConditionalCompareObjectEqual(ll_lbfblf.get_Items().get_Item(n), (object)array[num8], false))
						{
							bnewxt = false;
							break;
						}
					}
					if (bnewxt)
					{
						ll_lbfblf.get_Items().Add((object)array[num8]);
					}
				}
				int num12 = num6;
				for (int num13 = 2; num13 <= num12; num13++)
				{
					bnewxt = true;
					string[] array = Strings.Split(curlcname[num13], "_", -1, (CompareMethod)0);
					num8 = Conversions.ToInteger(((TextBox)ll_txtcurxti).get_Text()) - 1;
					if (Information.UBound((Array)array, 1) < num8)
					{
						continue;
					}
					int num14 = ll_lbxtlist.get_Items().get_Count() - 1;
					for (int num15 = 0; num15 <= num14; num15++)
					{
						if (Operators.ConditionalCompareObjectEqual(ll_lbxtlist.get_Items().get_Item(num15), (object)array[num8], false))
						{
							bnewxt = false;
							break;
						}
					}
					if (bnewxt)
					{
						ll_lbxtlist.get_Items().Add((object)array[num8]);
					}
				}
				if (Operators.CompareString(curstruct, "gdfb", false) == 0)
				{
					ll_lbfixxtlist.get_Items().Clear();
					int num16 = ll_lbxtlist.get_Items().get_Count() - 1;
					for (int num17 = 0; num17 <= num16; num17++)
					{
						ll_lbfixxtlist.get_Items().Add(RuntimeHelpers.GetObjectValue(ll_lbxtlist.get_Items().get_Item(num17)));
					}
				}
				if (Operators.CompareString(curstruct, "tsfb", false) == 0)
				{
					ll_lbzbxtlist.get_Items().Clear();
					int num18 = ll_lbxtlist.get_Items().get_Count() - 1;
					for (int num19 = 0; num19 <= num18; num19++)
					{
						ll_lbzbxtlist.get_Items().Add(RuntimeHelpers.GetObjectValue(ll_lbxtlist.get_Items().get_Item(num19)));
					}
				}
				bhqz = false;
				text = curlcname[0];
				if (Operators.CompareString(Strings.Trim(text), "", false) != 0)
				{
					num5 = Strings.InStr(1, text, "_配重", (CompareMethod)0);
					if (num5 > 0)
					{
						bhqz = true;
					}
				}
				if (bhqz)
				{
					string[] array2 = Strings.Split(curlcname[0], "控制标识,", -1, (CompareMethod)0);
					string text4 = array2[1];
					array2 = Strings.Split(text4, ",", -1, (CompareMethod)0);
					int num20 = Information.UBound((Array)array2, 1);
					for (int num21 = 0; num21 <= num20; num21++)
					{
						Mod1.curvalue = array2[num21];
						num5 = Strings.InStr(1, Conversions.ToString(Mod1.curvalue), "配重", (CompareMethod)0);
						if (num5 <= 0)
						{
							continue;
						}
						if (Operators.CompareString(Strings.Right(Strings.UCase(Strings.Trim(Conversions.ToString(Mod1.curvalue))), 1), "T", false) != 0)
						{
							bpzTglobal = false;
						}
						string[] array = Strings.Split(Conversions.ToString(Mod1.curvalue), "_配重", -1, (CompareMethod)0);
						int num22 = ll_lbnamelist.get_Items().get_Count() - 1;
						for (int num23 = 0; num23 <= num22; num23++)
						{
							flag = false;
							if (Operators.ConditionalCompareObjectEqual((object)Strings.Trim(array[0]), ll_lbnamelist.get_Items().get_Item(num23), false))
							{
								flag = true;
								break;
							}
						}
						if (!flag)
						{
							ll_lbnamelist.get_Items().Add((object)array[0]);
						}
						int num24 = ll_lbpzlist.get_Items().get_Count() - 1;
						for (int num25 = 0; num25 <= num24; num25++)
						{
							flag2 = false;
							if (Operators.ConditionalCompareObjectEqual((object)Strings.Trim(array[1]), ll_lbpzlist.get_Items().get_Item(num25), false))
							{
								flag2 = true;
								break;
							}
						}
						if (!flag2)
						{
							ll_lbpzlist.get_Items().Add((object)array[1]);
						}
					}
					int num26 = ll_lbpzlist.get_Items().get_Count() - 1;
					for (int num27 = 0; num27 <= num26; num27++)
					{
						text = Conversions.ToString(ll_lbpzlist.get_Items().get_Item(num27));
						bpzT = false;
						if (Operators.CompareString(Strings.Right(Strings.UCase(Strings.Trim(text)), 1), "T", false) == 0)
						{
							bpzT = true;
						}
						if (bpzT)
						{
							text = Strings.Left(text, Strings.Len(text) - 1);
						}
						ll_lbpzlist.get_Items().set_Item(num27, (object)text);
					}
					for (int num28 = ll_lbpzlist.get_Items().get_Count() - 1; num28 <= 0; num28++)
					{
						text = Conversions.ToString(ll_lbpzlist.get_Items().get_Item(num28));
						if (num28 < 1)
						{
							continue;
						}
						int num29 = num28 - 1;
						for (int num30 = 0; num30 <= num29; num30++)
						{
							if (Operators.ConditionalCompareObjectEqual((object)text, ll_lbpzlist.get_Items().get_Item(num30), false))
							{
								ll_lbpzlist.get_Items().RemoveAt(num28);
								break;
							}
						}
					}
				}
				int num31 = ll_lbxtlist.get_Items().get_Count() - 1;
				for (int num32 = 0; num32 <= num31; num32++)
				{
					ll_lbecurxnname.set_Text(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(ll_lbcsvlist.get_Items().get_Item(j), (object)" 当前角度:"), ll_lbxtlist.get_Items().get_Item(num32))));
					float num33 = (float)((double)(num32 + 1) / (double)(ll_lbxtlist.get_Items().get_Count() + 1));
					LabelProgress.set_Value((int)Math.Round(num33 * 100f));
					FrameProgress.set_Text(Conversions.ToString((int)Math.Round(num33 * 100f)) + ".0%");
					((Control)FrameProgress).Refresh();
					ll_lbliucheng.get_Items().Add((object)(ll_lbecurxnname.get_Text() + " 处理进程:" + Conversions.ToString(num33)));
					ll_lbliucheng.Refresh();
					if (curfbcsv2curall(text2, num8, Conversions.ToString(ll_lbxtlist.get_Items().get_Item(num32))))
					{
						shALL = (Worksheet)XLSALL.Worksheets["ALL"];
						shALL.Activate();
						Mod1.rng = ((_Worksheet)shALL).get_Range((object)"A1", (object)Missing.Value).CurrentRegion;
						int count = Mod1.rng.Columns.Count;
						int count2 = Mod1.rng.Rows.Count;
						curlcname = new string[count2 + 1];
						int num34 = count2;
						for (int num35 = 2; num35 <= num34; num35++)
						{
							curlcname[num35] = Conversions.ToString(NewLateBinding.LateGet(shALL.Cells[num35, 1], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
						}
						if (bhqz)
						{
							Mod1.rng = ((_Worksheet)shALL).get_Range(RuntimeHelpers.GetObjectValue(shALL.Cells[1, 2]), RuntimeHelpers.GetObjectValue(shALL.Cells[1, count]));
							Mod1.rng.Select();
							CurRangeNameDef();
							int num36 = ll_lbnamelist.get_Items().get_Count() - 1;
							for (int num37 = 0; num37 <= num36; num37++)
							{
								int num38 = ll_lbpzlist.get_Items().get_Count() - 1;
								for (int num39 = 0; num39 <= num38; num39++)
								{
									string text5 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(ll_lbnamelist.get_Items().get_Item(num37), (object)"_配重"), ll_lbpzlist.get_Items().get_Item(num39)));
									if (bpzTglobal)
									{
										text5 += "T";
									}
									GenSheets(Conversions.ToString(ll_lbpzlist.get_Items().get_Item(num39)), text5, "ALL");
								}
							}
							int num40 = ll_lbnamelist.get_Items().get_Count() - 1;
							for (int num41 = 0; num41 <= num40; num41++)
							{
								string text6 = Conversions.ToString(Operators.ConcatenateObject((object)(tempxlspath + "\\"), ll_lbxtlist.get_Items().get_Item(num32)));
								if (!Directory.Exists(text6))
								{
									FileSystem.MkDir(text6);
								}
								mergenamei(Conversions.ToString(ll_lbnamelist.get_Items().get_Item(num41)), text6);
								ll_lbliucheng.get_Items().Add(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat("输出基本xls文件;" + text6, "\\"), ll_lbnamelist.get_Items().get_Item(num41)), (object)".xls"));
								ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
								ll_lbliucheng.Refresh();
							}
							int num42 = ll_lbnamelist.get_Items().get_Count() - 1;
							for (int num43 = 0; num43 <= num42; num43++)
							{
								int num44 = ll_lbpzlist.get_Items().get_Count() - 1;
								for (int num45 = 0; num45 <= num44; num45++)
								{
									string text5 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(ll_lbnamelist.get_Items().get_Item(num43), (object)"_配重"), ll_lbpzlist.get_Items().get_Item(num45)));
									if (bpzTglobal)
									{
										text5 += "T";
									}
									Mod1.excelapp.DisplayAlerts = false;
									if (Q_JS.SheetExists(text5))
									{
										NewLateBinding.LateCall(Mod1.excelapp.Sheets[text5], (Type)null, "Delete", new object[0], (string[])null, (Type[])null, (bool[])null, true);
									}
									Mod1.excelapp.DisplayAlerts = true;
								}
							}
						}
						else
						{
							int num46 = count2;
							for (int num47 = 2; num47 <= num46; num47++)
							{
								NewLateBinding.LateSetComplex(shALL.Cells[num47, 1], (Type)null, "Value", new object[1] { curlcname[num47] + "_PZ" }, (string[])null, (Type[])null, false, true);
							}
							Worksheet worksheet = (Worksheet)XLSALL.Worksheets["ALL"];
							string filename = Application.get_StartupPath() + "\\config\\TempALL.xls";
							if (!Mod1.WorkbookIsOpen("TempALL.xls"))
							{
								Mod1.excelapp.Workbooks.Open(filename, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
							}
							else
							{
								Mod1.excelapp.Windows["TempALL.xls"].Activate();
							}
							Workbook workbook = Mod1.excelapp.Workbooks["TempALL.xls"];
							worksheet.Cells.Copy(Missing.Value);
							NewLateBinding.LateCall(NewLateBinding.LateGet(workbook.Sheets["ALL"], (Type)null, "Range", new object[1] { "A1" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Select", new object[0], (string[])null, (Type[])null, (bool[])null, true);
							NewLateBinding.LateCall(workbook.Sheets["ALL"], (Type)null, "Paste", new object[0], (string[])null, (Type[])null, (bool[])null, true);
							workbook = null;
							Mod1.excelapp.Windows["TempALL.xls"].Activate();
							Mod1.excelapp.DisplayAlerts = false;
							string text6 = Conversions.ToString(Operators.ConcatenateObject((object)(tempxlspath + "\\"), ll_lbxtlist.get_Items().get_Item(num32)));
							if (!Directory.Exists(text6))
							{
								FileSystem.MkDir(text6);
							}
							Mod1.excelapp.ActiveWorkbook.SaveAs(text6 + "\\" + Mod1.toch(Strings.UCase(curtempxlsname)) + ".xls", Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, XlSaveAsAccessMode.xlNoChange, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
							Mod1.excelapp.ActiveWindow.Close(Missing.Value, Missing.Value, Missing.Value);
							Mod1.excelapp.DisplayAlerts = true;
							ll_lbliucheng.get_Items().Add((object)("输出基本xls文件;" + tempxlspath + "\\" + Mod1.toch(Strings.UCase(curtempxlsname)) + ".xls"));
							ll_lbliucheng.Refresh();
						}
					}
					ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
				}
				LabelProgress.set_Value(100);
				FrameProgress.set_Text("100%");
				((Control)FrameProgress).Refresh();
				Mod1.excelapp.DisplayAlerts = false;
				XLSALL.Close(Missing.Value, Missing.Value, Missing.Value);
				ll_lbliucheng.Refresh();
			}
			FrameProgressTotal.set_Text("100%");
			fbini();
			((Control)this).set_Cursor(Cursors.get_Arrow());
			ll_lbliucheng.get_Items().Add((object)("当前 " + curstruct + " 处理完毕."));
			ll_lbliucheng.Refresh();
		}
	}

	private bool curfbcsv2curall(string fname, int curxti, string curxt)
	{
		bool result = true;
		checked
		{
			if (Operators.CompareString(Strings.Trim(fname), "", false) == 0)
			{
				result = false;
			}
			else
			{
				string filename = Application.get_StartupPath() + "\\config\\ALL.xls";
				if (!Mod1.WorkbookIsOpen("ALL.xls"))
				{
					XLSALL = Mod1.excelapp.Workbooks.Open(filename, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
				}
				else
				{
					Mod1.excelapp.Windows["ALL.xls"].Activate();
				}
				shTemp = (Worksheet)XLSALL.Worksheets["ALL"];
				shTemp.Cells.Delete(Missing.Value);
				int num = default(int);
				if (File.Exists(fname))
				{
					num = 0;
					Mod1.lr = new StreamReader(fname, Encoding.Default);
					string text = "";
					while (!Information.IsNothing((object)text))
					{
						text = Mod1.lr.ReadLine();
						if (Operators.CompareString(Strings.Trim(text), "", false) == 0)
						{
							continue;
						}
						string[] array = Strings.Split(text, ",", -1, (CompareMethod)0);
						if (num == 0)
						{
							num++;
							int num2 = Information.UBound((Array)array, 1);
							for (int i = 0; i <= num2; i++)
							{
								shTemp.Cells[num, i + 1] = Strings.Trim(Strings.Trim(array[i]));
							}
							continue;
						}
						string[] array2 = Strings.Split(Strings.Trim(array[0]), "_", -1, (CompareMethod)0);
						if ((Information.UBound((Array)array2, 1) >= curxti) & (Operators.CompareString(Strings.Trim(array2[curxti]), curxt, false) == 0))
						{
							num++;
							int num3 = Information.UBound((Array)array, 1);
							for (int j = 0; j <= num3; j++)
							{
								shTemp.Cells[num, j + 1] = Strings.Trim(Strings.Trim(array[j]));
							}
						}
					}
					Mod1.lr.Close();
					Mod1.lr.Dispose();
				}
				if (num <= 2)
				{
					result = false;
					string text2 = "当前角度值:" + curxt + " 当前csv文件中没有相关数据." + fname;
					ll_lbliucheng.get_Items().Add((object)text2);
				}
				else
				{
					string text2 = "导入当前csv文件:" + fname + "到临时工作表[ALL].角度位置序号:" + Conversions.ToString(curxti) + ", 当前角度值:" + curxt;
					ll_lbliucheng.get_Items().Add((object)text2);
					shTemp.Activate();
				}
			}
			return result;
		}
	}

	private void fbini()
	{
		if (!Directory.Exists(curstructpath + "\\" + xnxlsname))
		{
			FileSystem.MkDir(curstructpath + "\\" + xnxlsname);
		}
		fname = curstructpath + "\\" + xnxlsname + "\\" + xnxlsname + ".ini";
		Mod1.wr = new StreamWriter(fname, append: false, Encoding.Default);
		if (Operators.CompareString(curstruct, "gdfb", false) == 0)
		{
			Mod1.wr.WriteLine(strlist2ini("副臂主臂安装角列表_", ll_lbfixxtlist));
		}
		else
		{
			Mod1.wr.WriteLine(strlist2ini("副臂主臂仰角列表_", ll_lbzbxtlist));
		}
		Mod1.wr.WriteLine(strlist2ini("副臂主臂长度列表_", ll_lbfblz));
		Mod1.wr.WriteLine(strlist2ini("副臂副臂长度列表_", ll_lbfblf));
		Mod1.wr.WriteLine(strlist2ini("配重_", ll_lbpzlist));
		checked
		{
			int num = ll_lbnamelist.get_Items().get_Count() - 1;
			for (int i = 0; i <= num; i++)
			{
				bool flag = true;
				string text = Conversions.ToString(ll_lbnamelist.get_Items().get_Item(i));
				string[] array = Strings.Split(text, "_", -1, (CompareMethod)0);
				if (Information.UBound((Array)array, 1) < 1)
				{
					continue;
				}
				int num2 = ll_lbztkjlist.get_Items().get_Count() - 1;
				for (int j = 0; j <= num2; j++)
				{
					if (Operators.ConditionalCompareObjectEqual((object)array[0], ll_lbztkjlist.get_Items().get_Item(j), false))
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					ll_lbztkjlist.get_Items().Add((object)array[0]);
				}
			}
			Mod1.wr.WriteLine(strlist2ini("支腿跨距_", ll_lbztkjlist));
			Mod1.wr.Close();
			Mod1.wr.Dispose();
			ll_lbliucheng.get_Items().Add((object)("生成索引文件;" + fname));
			ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
		}
	}

	private void l_btnfbpicklcname_Click(object sender, EventArgs e)
	{
		checked
		{
			if (ll_lbcsvlist.get_Items().get_Count() != 0)
			{
				ll_lbfblcnamelist.get_Items().Clear();
				ll_lbfblcnamecheckresult.get_Items().Clear();
				int num = ll_lbcsvlist.get_Items().get_Count() - 1;
				for (int i = 0; i <= num; i++)
				{
					if (ll_lbcsvlist.GetSelected(i))
					{
						fname = Conversions.ToString(ll_lbcsvlist.get_Items().get_Item(i));
						Mod1.lr = new StreamReader(fname, Encoding.Default);
						string text = Mod1.lr.ReadLine();
						while (!Information.IsNothing((object)text))
						{
							text = Mod1.lr.ReadLine();
							text = Mod1.lr.ReadLine();
							if (Operators.CompareString(Strings.Trim(text), "", false) != 0)
							{
								string[] array = Strings.Split(text, ",", -1, (CompareMethod)0);
								ll_lbfblcnamelist.get_Items().Add((object)array[0]);
								((TextBox)ll_txtfbnameformat).set_Text(array[0]);
								break;
							}
						}
						Mod1.lr.Close();
						Mod1.lr.Dispose();
					}
					else
					{
						ll_lbfblcnamelist.get_Items().Add((object)"");
					}
				}
			}
			if (ll_lbfblcnamelist.get_Items().get_Count() == 0)
			{
				return;
			}
			int num2 = ll_lbfblcnamelist.get_Items().get_Count() - 1;
			int num3 = 0;
			while (true)
			{
				if (num3 <= num2)
				{
					if (Operators.ConditionalCompareObjectNotEqual(ll_lbfblcnamelist.get_Items().get_Item(num3), (object)"", false))
					{
						break;
					}
					num3++;
					continue;
				}
				return;
			}
			((TextBox)ll_txtfbnameformat).set_Text(Conversions.ToString(ll_lbfblcnamelist.get_Items().get_Item(num3)));
		}
	}

	private void ll_btnfbchecklcname_Click(object sender, EventArgs e)
	{
		ll_lbfblcnamecheckresult.get_Items().Clear();
		checked
		{
			int num = ll_lbfblcnamelist.get_Items().get_Count() - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Conversions.ToString(ll_lbfblcnamelist.get_Items().get_Item(i));
				if (Operators.CompareString(text, "", false) != 0)
				{
					string[] array = Strings.Split(text, "_", -1, (CompareMethod)0);
					ll_lbfblcnamecheckresult.get_Items().Add((object)Information.UBound((Array)array, 1));
				}
				else
				{
					ll_lbfblcnamecheckresult.get_Items().Add((object)"");
				}
			}
		}
	}

	private void ll_lbfblcnamelist_SelectedIndexChanged(object sender, EventArgs e)
	{
		((TextBox)ll_txtfbnameformat).set_Text(Conversions.ToString(ll_lbfblcnamelist.get_Items().get_Item(ll_lbfblcnamelist.get_SelectedIndex())));
		if (ll_lbfblcnamecheckresult.get_Items().get_Count() != 0)
		{
			ll_lbfblcnamecheckresult.set_SelectedIndex(ll_lbfblcnamelist.get_SelectedIndex());
			ll_lbfblcnamecheckresult.set_TopIndex(ll_lbfblcnamelist.get_TopIndex());
		}
	}

	private void ll_btnfbgenformat_Click(object sender, EventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((Form)MyProject.Forms.ll_uffbnamejxformat).ShowDialog();
		((Component)(object)MyProject.Forms.ll_uffbnamejxformat).Dispose();
		ll_lbliucheng.get_Items().Add((object)("当前副臂选项解析格式:" + ((TextBox)ll_txtfbformat).get_Text()));
		ll_lbliucheng.set_SelectedIndex(checked(ll_lbliucheng.get_Items().get_Count() - 1));
		ll_btnfbcheckformat_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void ll_btnfbcheckformat_Click(object sender, EventArgs e)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				if (!((Operators.CompareString(((TextBox)ll_txtfbnameformat).get_Text(), "", false) != 0) & (Operators.CompareString(((TextBox)ll_txtfbformat).get_Text(), "", false) != 0)))
				{
					return;
				}
				((Control)ll_btnfbcheckformat).set_ForeColor(Color.Green);
				string[] array = Strings.Split(((TextBox)ll_txtfbformat).get_Text(), ",", -1, (CompareMethod)0);
				if (Operators.CompareString(array[0], "_", false) != 0)
				{
					string text = "不正确的解析格式 " + ((TextBox)ll_txtfbformat).get_Text() + " 第一个字符应为下划线:_";
					Interaction.MsgBox((object)text, (MsgBoxStyle)0, (object)"提示");
					ll_lbliucheng.get_Items().Add((object)text);
					((Control)ll_btnfbcheckformat).set_ForeColor(Color.Red);
					return;
				}
				int num = Information.UBound((Array)array, 1);
				array = Strings.Split(((TextBox)ll_txtfbnameformat).get_Text(), "_", -1, (CompareMethod)0);
				int num2 = Information.UBound((Array)array, 1);
				if (num != num2 + 1)
				{
					string text = "不正确的解析格式 " + ((TextBox)ll_txtfbformat).get_Text() + " 没有与" + ((TextBox)ll_txtfbnameformat).get_Text() + "一一对应.";
					Interaction.MsgBox((object)text, (MsgBoxStyle)0, (object)"提示");
					ll_lbliucheng.get_Items().Add((object)text);
					((Control)ll_btnfbcheckformat).set_ForeColor(Color.Red);
					return;
				}
				array = Strings.Split(((TextBox)ll_txtfbformat).get_Text(), ",", -1, (CompareMethod)0);
				int num3 = Information.UBound((Array)array, 1);
				for (num = 0; num <= num3; num++)
				{
					switch (Strings.UCase(array[num]))
					{
					case "LZ":
						((TextBox)ll_txtfblz).set_Text(Conversions.ToString(num));
						break;
					case "LF":
						((TextBox)ll_txtfblf).set_Text(Conversions.ToString(num));
						break;
					case "FIXXT":
						((TextBox)ll_txtfixxt).set_Text(Conversions.ToString(num));
						((TextBox)ll_txtcurxti).set_Text(Conversions.ToString(num));
						break;
					case "ZBXT":
						((TextBox)ll_txtzbxt).set_Text(Conversions.ToString(num));
						((TextBox)ll_txtcurxti).set_Text(Conversions.ToString(num));
						break;
					}
				}
				((Control)ll_btnfbcsv2tempxls).set_Enabled(true);
				((Control)ll_btncsv2tempxls).set_Enabled(false);
				((Control)ll_btnfbcsv2tempxls).set_ForeColor(Color.Green);
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

	private void ll_checkshowdatalist_CheckedChanged(object sender, EventArgs e)
	{
		if (ll_checkshowdatalist.get_Checked())
		{
			ll_pagetemplist.set_Visible(true);
		}
		else
		{
			ll_pagetemplist.set_Visible(false);
		}
	}

	private void ll_txtstruct_TextChanged(object sender, EventArgs e)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(((TextBox)ll_txtstruct).get_Text(), "", false) != 0)
		{
			switch (((TextBox)ll_txtstruct).get_Text())
			{
			default:
				Interaction.MsgBox((object)"当前装配文件夹名称不合法,请联系开发人员.. .", (MsgBoxStyle)0, (object)"提示");
				return;
			case "主臂+塔式副臂":
			case "主臂+塔式副臂+超起":
				((Control)ll_frmfb).set_Enabled(true);
				curstruct = "tsfb";
				break;
			case "主臂+固定副臂":
			case "主臂+固定副臂+超起":
				((Control)ll_frmfb).set_Enabled(true);
				curstruct = "gdfb";
				break;
			case "主臂":
			case "主臂+超起":
				((Control)ll_frmfb).set_Enabled(false);
				curstruct = "zb";
				break;
			}
			((Control)SuperTabControlPanel1).set_Enabled(true);
			string text = "【装配列表】-- " + ((TextBox)ll_txtstruct).get_Text();
			ll_lbliucheng.get_Items().Add((object)text);
		}
	}

	private void ll_btnpicktempxls_Click(object sender, EventArgs e)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		ll_lbtempxlslist.get_Items().Clear();
		checked
		{
			if (Operators.CompareString(Strings.Trim(((TextBox)ll_txtpath).get_Text()), "", false) != 0)
			{
				string text = ((TextBox)ll_txtpath).get_Text() + "\\tempxls";
				if (!Directory.Exists(text))
				{
					Interaction.MsgBox((object)("当前默认路径不存在.请联系开发人员.. ." + text), (MsgBoxStyle)0, (object)"提示");
				}
				else if (Operators.CompareString(Strings.Trim(text), "", false) != 0)
				{
					ll_lbliucheng.get_Items().Add((object)("当前基本xls文件所在路径:" + text));
					ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
					string path = text + "\\";
					string[] files = Directory.GetFiles(path, "*.xls", SearchOption.AllDirectories);
					int num = files.Count() - 1;
					for (int i = 0; i <= num; i++)
					{
						ll_lbtempxlslist.get_Items().Add((object)files[i]);
					}
				}
			}
			else
			{
				Interaction.MsgBox((object)"需要成功执行 [步骤1] 后方可使用当前默认路径.", (MsgBoxStyle)0, (object)"提示");
			}
		}
	}

	private void ll_btnxlsall_Click(object sender, EventArgs e)
	{
		checked
		{
			int num = ll_lbtempxlslist.get_Items().get_Count() - 1;
			for (int i = 0; i <= num; i++)
			{
				ll_lbtempxlslist.SetSelected(i, true);
			}
		}
	}

	private void ll_btnxlsother_Click(object sender, EventArgs e)
	{
		checked
		{
			int num = ll_lbtempxlslist.get_Items().get_Count() - 1;
			for (int i = 0; i <= num; i++)
			{
				if (ll_lbtempxlslist.GetSelected(i))
				{
					ll_lbtempxlslist.SetSelected(i, false);
				}
				else
				{
					ll_lbtempxlslist.SetSelected(i, true);
				}
			}
		}
	}

	private void ll_btnzbxnall_Click(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and I4
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		if ((int)MessageBox.Show("开始进行主臂的单项性能生成,是否继续?", "提示", (MessageBoxButtons)4, (MessageBoxIcon)64) == 7)
		{
			return;
		}
		LabelProgress.set_Value(0);
		FrameProgress.set_Text("0%");
		((Control)FrameProgress).Refresh();
		LabelProgressTotal.set_Value(0);
		FrameProgressTotal.set_Text("0%");
		((Control)this).set_Cursor(Cursors.get_AppStarting());
		if (Operators.CompareString(Strings.Trim(((TextBox)ll_txtstruct).get_Text()), "", false) == 0)
		{
			Interaction.MsgBox((object)"请选择当前要处理的结构形式.", (MsgBoxStyle)0, (object)"提示");
			return;
		}
		int num = 0;
		checked
		{
			int num2 = ll_lbtempxlslist.get_Items().get_Count() - 1;
			for (int i = 0; i <= num2; i++)
			{
				if (ll_lbtempxlslist.GetSelected(i))
				{
					num++;
				}
			}
			if (num == 0)
			{
				Interaction.MsgBox((object)"当前没有选择任何合法的xls文件,本次操作终止.", (MsgBoxStyle)0, (object)"提示");
				return;
			}
			int num3 = 0;
			LabelProgressTotal.set_Maximum(num);
			int num4 = ll_lbtempxlslist.get_Items().get_Count() - 1;
			for (int j = 0; j <= num4; j++)
			{
				if (!ll_lbtempxlslist.GetSelected(j))
				{
					continue;
				}
				ll_lbecurxnname.set_Text(Conversions.ToString(ll_lbtempxlslist.get_Items().get_Item(j)));
				((Control)ll_lbecurxnname).Refresh();
				num3++;
				LabelProgressTotal.set_Value(num3);
				((Control)LabelProgressTotal).Refresh();
				FrameProgressTotal.set_Text(Conversions.ToString(Convert.ToInt32((double)num3 / (double)num * 100.0)) + ".0%");
				((Control)FrameProgressTotal).Refresh();
				LabelProgressTotal.set_Value(num3);
				LabelProgress.set_Value(30);
				FrameProgress.set_Text("30.0%");
				((Control)FrameProgress).Refresh();
				Workbook workbook = Mod1.excelapp.Workbooks.Open(Conversions.ToString(ll_lbtempxlslist.get_Items().get_Item(j)), Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
				NewLateBinding.LateSetComplex(workbook.Worksheets["ALL"], (Type)null, "Range", new object[2]
				{
					"A1",
					((TextBox)ll_txtformat).get_Text()
				}, (string[])null, (Type[])null, false, true);
				if (!Q_JS.mainjs(ll_lbliucheng, ll_txtchai.get_Value(), workbook))
				{
					ll_lbliucheng.get_Items().Add((object)"本次吊重插值计算失败.");
					ll_lbliucheng.Refresh();
				}
				else
				{
					ll_lbliucheng.get_Items().Add((object)"本次吊重插值计算成功.");
					ll_lbliucheng.Refresh();
				}
				ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
				LabelProgress.set_Value(80);
				FrameProgress.set_Text("80.0%");
				((Control)FrameProgress).Refresh();
				if (!Q_JS.xnFormat_zball(ll_lbliucheng, workbook))
				{
					ll_lbliucheng.get_Items().Add((object)"本次主臂性能提取终止.");
					ll_lbliucheng.Refresh();
					((Control)ll_btnzbxnall).set_ForeColor(Color.Red);
				}
				else
				{
					ll_lbliucheng.get_Items().Add((object)"本次主臂性能提取成功.");
					ll_lbliucheng.Refresh();
					((Control)ll_btnzbxnall).set_ForeColor(Color.Green);
					string text = Strings.Left(workbook.Name, Strings.Len(workbook.Name) - 4);
					switch (text)
					{
					default:
						ll_lbliucheng.get_Items().Add((object)("当前性能表名称为系列配重的数值." + workbook.Name));
						ll_lbliucheng.Refresh();
						break;
					case "强度":
					case "刚度":
					case "变幅缸":
					case "超起钢丝绳":
						NewLateBinding.LateSetComplex(workbook.Worksheets["PZ"], (Type)null, "Name", new object[1] { text }, (string[])null, (Type[])null, false, true);
						ll_lbliucheng.get_Items().Add((object)("成功修改性能表名称为:" + text));
						ll_lbliucheng.Refresh();
						break;
					}
				}
				LabelProgress.set_Value(90);
				FrameProgress.set_Text("90.0%");
				((Control)FrameProgress).Refresh();
				Mod1.excelapp.DisplayAlerts = false;
				xnxlspath = Strings.Replace(workbook.Path, "tempxls", xnxlsname, 1, -1, (CompareMethod)0);
				if (!Directory.Exists(xnxlspath))
				{
					string[] array = Strings.Split(xnxlspath, "\\", -1, (CompareMethod)0);
					string text = array[0];
					int num5 = Information.UBound((Array)array, 1);
					for (int k = 1; k <= num5; k++)
					{
						text = text + "\\" + array[k];
						if (!Directory.Exists(text))
						{
							FileSystem.MkDir(text);
						}
					}
				}
				string text2 = xnxlspath + "\\" + workbook.Name;
				workbook.SaveAs(xnxlspath + "\\" + workbook.Name, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, XlSaveAsAccessMode.xlNoChange, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
				Mod1.excelapp.DisplayAlerts = true;
				workbook.Close(Missing.Value, Missing.Value, Missing.Value);
				LabelProgress.set_Value(100);
				FrameProgress.set_Text("100%");
				((Control)FrameProgress).Refresh();
				ll_lbliucheng.get_Items().Add((object)("生成单项性能文件;" + text2));
				ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
			}
			FrameProgressTotal.set_Text("100%");
			((Control)this).set_Cursor(Cursors.get_Arrow());
			ll_lbliucheng.get_Items().Add((object)("本次批量生成单项性能成功,请查看输出文件夹:" + xnxlspath));
			ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
			ll_lbliucheng.Refresh();
		}
	}

	private void ll_btnnameformat_Click(object sender, EventArgs e)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(ll_lbtempxlslist.get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"请选择一个 .xls 文件！", (MsgBoxStyle)64, (object)"提示");
			return;
		}
		checked
		{
			if (ll_lbtempxlslist.get_Items().get_Count() != 0)
			{
				ll_lblcnamelist.get_Items().Clear();
				ll_lblcnamecheckresult.get_Items().Clear();
				int num = ll_lbtempxlslist.get_Items().get_Count() - 1;
				for (int i = 0; i <= num; i++)
				{
					if (ll_lbtempxlslist.GetSelected(i))
					{
						Workbook workbook = Mod1.excelapp.Workbooks.Open(Conversions.ToString(ll_lbtempxlslist.get_Items().get_Item(i)), Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
						ll_lblcnamelist.get_Items().Add(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(workbook.Worksheets["ALL"], (Type)null, "Range", new object[1] { "A2" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null)));
						workbook.Close(Missing.Value, Missing.Value, Missing.Value);
					}
					else
					{
						ll_lblcnamelist.get_Items().Add((object)"");
					}
				}
			}
			if (ll_lblcnamelist.get_Items().get_Count() == 0)
			{
				return;
			}
			int num2 = ll_lblcnamelist.get_Items().get_Count() - 1;
			int num3 = 0;
			while (true)
			{
				if (num3 <= num2)
				{
					if (Operators.ConditionalCompareObjectNotEqual(ll_lblcnamelist.get_Items().get_Item(num3), (object)"", false))
					{
						break;
					}
					num3++;
					continue;
				}
				return;
			}
			((TextBox)ll_txtnameformat).set_Text(Conversions.ToString(ll_lblcnamelist.get_Items().get_Item(num3)));
			ll_lblcnamelist.set_SelectedIndex(num3);
		}
	}

	private void ll_btnlcnamecheck_Click(object sender, EventArgs e)
	{
		ll_lblcnamecheckresult.get_Items().Clear();
		checked
		{
			int num = ll_lblcnamelist.get_Items().get_Count() - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Conversions.ToString(ll_lblcnamelist.get_Items().get_Item(i));
				string[] array = Strings.Split(text, "_", -1, (CompareMethod)0);
				ll_lblcnamecheckresult.get_Items().Add((object)Information.UBound((Array)array, 1));
			}
		}
	}

	private void ll_lblcnamelist_SelectedIndexChanged(object sender, EventArgs e)
	{
		if ((ll_lblcnamelist.get_SelectedIndex() != -1) & (ll_lblcnamelist.get_Items().get_Count() != 0))
		{
			((TextBox)ll_txtnameformat).set_Text(Conversions.ToString(ll_lblcnamelist.get_Items().get_Item(ll_lblcnamelist.get_SelectedIndex())));
			ll_lbliucheng.get_Items().Add((object)("当前名称格式:" + ((TextBox)ll_txtnameformat).get_Text()));
			ll_lbliucheng.set_SelectedIndex(checked(ll_lbliucheng.get_Items().get_Count() - 1));
			((TextBox)ll_txtnameformat).set_Text(ll_lblcnamelist.get_Text());
		}
		if (ll_lblcnamecheckresult.get_Items().get_Count() != 0)
		{
			ll_lblcnamecheckresult.set_SelectedIndex(ll_lblcnamelist.get_SelectedIndex());
			ll_lblcnamecheckresult.set_TopIndex(ll_lblcnamelist.get_TopIndex());
		}
	}

	private void ll_btngenformat_Click(object sender, EventArgs e)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		MyProject.Forms.ll_uffbnamejxformat.bz = "【步骤2】";
		((Form)MyProject.Forms.ll_uffbnamejxformat).ShowDialog();
		((TextBox)ll_txtformat).set_Text(Q_JS.strjxen);
		ll_lbenamejxformat.set_Text(Q_JS.strjxch);
		ll_lbliucheng.get_Items().Add((object)("当前解析格式:" + ((TextBox)ll_txtformat).get_Text()));
		ll_lbliucheng.set_SelectedIndex(checked(ll_lbliucheng.get_Items().get_Count() - 1));
		ll_btncheckformat_Click(RuntimeHelpers.GetObjectValue(sender), e);
		((Component)(object)MyProject.Forms.ll_uffbnamejxformat).Dispose();
	}

	private void ll_btncheckformat_Click(object sender, EventArgs e)
	{
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		if (!((Operators.CompareString(((TextBox)ll_txtnameformat).get_Text(), "", false) != 0) & (Operators.CompareString(((TextBox)ll_txtformat).get_Text(), "", false) != 0)))
		{
			return;
		}
		((Control)ll_btncheckformat).set_ForeColor(Color.Green);
		string[] array = Strings.Split(((TextBox)ll_txtformat).get_Text(), ",", -1, (CompareMethod)0);
		if (Operators.CompareString(array[0], "_", false) != 0)
		{
			string text = "不正确的解析格式 " + ((TextBox)ll_txtformat).get_Text() + " 第一个字符应为下划线:_";
			Interaction.MsgBox((object)text, (MsgBoxStyle)0, (object)"提示");
			ll_lbliucheng.get_Items().Add((object)text);
			((Control)ll_btncheckformat).set_ForeColor(Color.Red);
			return;
		}
		int num = Information.UBound((Array)array, 1);
		array = Strings.Split(((TextBox)ll_txtnameformat).get_Text(), "_", -1, (CompareMethod)0);
		int num2 = Information.UBound((Array)array, 1);
		if (num != checked(num2 + 1))
		{
			string text = "不正确的解析格式 " + ((TextBox)ll_txtformat).get_Text() + " 没有与" + ((TextBox)ll_txtnameformat).get_Text() + "一一对应.";
			Interaction.MsgBox((object)text, (MsgBoxStyle)0, (object)"提示");
			ll_lbliucheng.get_Items().Add((object)text);
			((Control)ll_btncheckformat).set_ForeColor(Color.Red);
			return;
		}
		curstruct = "zb";
		int num3 = Strings.InStr(1, Strings.UCase(((TextBox)ll_txtformat).get_Text()), "ZBXT", (CompareMethod)0);
		if (num3 > 0)
		{
			curstruct = "tsfb";
		}
		num3 = Strings.InStr(1, Strings.UCase(((TextBox)ll_txtformat).get_Text()), "FIXXT", (CompareMethod)0);
		if (num3 > 0)
		{
			curstruct = "gdfb";
		}
		if (Operators.CompareString(curstruct, "zb", false) == 0)
		{
			((Control)ll_btnzbxnall).set_Enabled(true);
			((Control)ll_btnzbxnall).set_ForeColor(Color.Green);
		}
		else
		{
			((Control)ll_btnfbxnall).set_Enabled(true);
			((Control)ll_btnfbxnall).set_ForeColor(Color.Green);
		}
	}

	private void ll_btnfbxnall_Click(object sender, EventArgs e)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Invalid comparison between Unknown and I4
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		string text = "LF";
		if (ll_checkLZ.get_Checked())
		{
			text = "LZ";
		}
		if ((int)MessageBox.Show("开始进行副臂的单项性能生成, 优先选项为 " + Mod1.toch(text) + ", 是否继续?", "提示", (MessageBoxButtons)4, (MessageBoxIcon)64) == 7)
		{
			return;
		}
		LabelProgress.set_Value(0);
		FrameProgress.set_Text("0%");
		((Control)FrameProgress).Refresh();
		LabelProgressTotal.set_Value(0);
		FrameProgressTotal.set_Text("0%");
		((Control)this).set_Cursor(Cursors.get_AppStarting());
		int num = 0;
		checked
		{
			int num2 = ll_lbtempxlslist.get_Items().get_Count() - 1;
			for (int i = 0; i <= num2; i++)
			{
				if (ll_lbtempxlslist.GetSelected(i))
				{
					num++;
				}
			}
			if (num == 0)
			{
				Interaction.MsgBox((object)"当前没有选择任何合法的xls文件,本次操作终止.", (MsgBoxStyle)0, (object)"提示");
				return;
			}
			int num3 = 0;
			LabelProgressTotal.set_Maximum(num);
			int num4 = ll_lbtempxlslist.get_Items().get_Count() - 1;
			IEnumerator enumerator = default(IEnumerator);
			for (int j = 0; j <= num4; j++)
			{
				((Control)this).Refresh();
				if (!ll_lbtempxlslist.GetSelected(j))
				{
					continue;
				}
				ll_lbecurxnname.set_Text(Conversions.ToString(ll_lbtempxlslist.get_Items().get_Item(j)));
				((Control)ll_lbecurxnname).Refresh();
				num3++;
				LabelProgressTotal.set_Value(num3);
				((Control)LabelProgressTotal).Refresh();
				FrameProgressTotal.set_Text(Conversions.ToString(Convert.ToInt32((double)num3 / (double)num * 100.0)) + ".0%");
				((Control)FrameProgressTotal).Refresh();
				LabelProgressTotal.set_Value(num3);
				LabelProgress.set_Value(30);
				FrameProgress.set_Text("30.0%");
				((Control)FrameProgress).Refresh();
				Workbook workbook = Mod1.excelapp.Workbooks.Open(Conversions.ToString(ll_lbtempxlslist.get_Items().get_Item(j)), Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
				NewLateBinding.LateSetComplex(workbook.Worksheets["ALL"], (Type)null, "Range", new object[2]
				{
					"A1",
					((TextBox)ll_txtformat).get_Text()
				}, (string[])null, (Type[])null, false, true);
				if (!Q_JS.mainjs(ll_lbliucheng, ll_txtchai.get_Value(), workbook))
				{
					ll_lbliucheng.get_Items().Add((object)"本次吊重插值计算失败.");
					ll_lbliucheng.Refresh();
				}
				else
				{
					ll_lbliucheng.get_Items().Add((object)"本次吊重插值计算成功.");
					ll_lbliucheng.Refresh();
				}
				ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
				LabelProgress.set_Value(80);
				FrameProgress.set_Text("80.0%");
				((Control)FrameProgress).Refresh();
				if (!Q_JS.xnFormat_bffball(ll_lbliucheng, text, workbook))
				{
					ll_lbliucheng.get_Items().Add((object)"本次副臂性能提取终止.");
					ll_lbliucheng.Refresh();
					((Control)ll_btnfbxnall).set_ForeColor(Color.Red);
				}
				else
				{
					ll_lbliucheng.get_Items().Add((object)"本次副臂性能提取成功.");
					ll_lbliucheng.Refresh();
					((Control)ll_btnfbxnall).set_ForeColor(Color.Green);
					string text2 = Strings.Left(workbook.Name, Strings.Len(workbook.Name) - 4);
					switch (text2)
					{
					default:
						ll_lbliucheng.get_Items().Add((object)"当前性能表名称为系列配重的数值.");
						ll_lbliucheng.Refresh();
						break;
					case "强度":
					case "刚度":
					case "变幅缸":
					case "超起钢丝绳":
						try
						{
							enumerator = workbook.Worksheets.GetEnumerator();
							while (enumerator.MoveNext())
							{
								Worksheet worksheet = (Worksheet)enumerator.Current;
								if (Operators.CompareString(Strings.UCase(Strings.Trim(worksheet.Name)), "ALL", false) != 0)
								{
									string text4 = (worksheet.Name = Strings.Replace(worksheet.Name, "PZ", text2, 1, -1, (CompareMethod)0));
								}
							}
						}
						finally
						{
							if (enumerator is IDisposable)
							{
								(enumerator as IDisposable).Dispose();
							}
						}
						ll_lbliucheng.get_Items().Add((object)("成功修改性能表名称为:" + text2));
						ll_lbliucheng.Refresh();
						break;
					}
				}
				xnxlspath = Strings.Replace(workbook.Path, "tempxls", xnxlsname + "\\" + Mod1.toch(text), 1, -1, (CompareMethod)0);
				if (!Directory.Exists(xnxlspath))
				{
					string[] array = Strings.Split(xnxlspath, "\\", -1, (CompareMethod)0);
					string text2 = array[0];
					int num5 = Information.UBound((Array)array, 1);
					for (int k = 1; k <= num5; k++)
					{
						text2 = text2 + "\\" + array[k];
						if (!Directory.Exists(text2))
						{
							FileSystem.MkDir(text2);
						}
					}
				}
				workbook.SaveAs(xnxlspath + "\\" + workbook.Name, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, XlSaveAsAccessMode.xlNoChange, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
				workbook.Close(Missing.Value, Missing.Value, Missing.Value);
				ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
				LabelProgress.set_Value(100);
				FrameProgress.set_Text("100%");
				((Control)FrameProgress).Refresh();
			}
			FrameProgressTotal.set_Text("100%");
			((Control)this).set_Cursor(Cursors.get_Arrow());
			ll_lbliucheng.get_Items().Add((object)("本次批量生成单项性能成功,请查看输出文件夹:" + xnxlspath));
			ll_lbliucheng.Refresh();
			ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
		}
	}

	private void ll_btnqdfile_Click(object sender, EventArgs e)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Invalid comparison between Unknown and I4
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		((FileDialog)GetOpenFilename).set_Filter("强度(*.xls)|*.xls");
		if ((int)((CommonDialog)GetOpenFilename).ShowDialog() == 1)
		{
			string fileName = ((FileDialog)GetOpenFilename).get_FileName();
			int num = Strings.InStr(1, Strings.LCase(fileName), "强度.xls", (CompareMethod)0);
			if (num < 0)
			{
				Interaction.MsgBox((object)("当前选择的文件不是强度性能xls文件,请重新选择.. ." + fileName), (MsgBoxStyle)0, (object)"提示");
				((Control)ll_frmminrf).set_Enabled(false);
				((Control)ll_btnfromall).set_Enabled(false);
				((Control)ll_btnnameformat2).set_Enabled(false);
				return;
			}
			if (!File.Exists(fileName))
			{
				Interaction.MsgBox((object)("不存在文件:" + fileName), (MsgBoxStyle)0, (object)"提示");
				((Control)ll_btnfromall).set_Enabled(false);
				((Control)ll_btnnameformat2).set_Enabled(false);
				return;
			}
			ll_lbminrflist.get_Items().Clear();
			ll_lbcheckminrf.get_Items().Clear();
			ll_lbcheckminrf2.get_Items().Clear();
			((TextBox)ll_txtnameformat2).set_Text("");
			((TextBox)ll_txtformat2).set_Text("");
			ll_lbenamejxformat2.set_Text("");
			((TextBox)ll_txttempxlslist).set_Text(fileName);
			((Control)ll_frmminrf).set_Enabled(true);
			((Control)ll_btnfromall).set_Enabled(true);
			((Control)ll_btnnameformat2).set_Enabled(true);
		}
	}

	private void ll_lbminrflist_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (ll_lbminrflist.get_Items().get_Count() != 0)
		{
			curindexone = ll_lbminrflist.get_SelectedIndex();
			curtopindexone = ll_lbminrflist.get_TopIndex();
			IndexOne();
		}
	}

	private void IndexOne()
	{
		ll_lbminrflist.set_TopIndex(curtopindexone);
		ll_lbcheckminrf.set_TopIndex(curtopindexone);
		ll_lbcheckminrf2.set_TopIndex(curtopindexone);
		ll_lbminrflist.set_SelectedIndex(curindexone);
		ll_lbcheckminrf.set_SelectedIndex(curindexone);
		ll_lbcheckminrf2.set_SelectedIndex(curindexone);
	}

	private void ll_lbcheckminrf_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (ll_lbcheckminrf.get_Items().get_Count() != 0)
		{
			curindexone = ll_lbcheckminrf.get_SelectedIndex();
			curtopindexone = ll_lbcheckminrf.get_TopIndex();
			IndexOne();
		}
	}

	private void ll_lbcheckminrf2_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (ll_lbcheckminrf2.get_Items().get_Count() != 0)
		{
			curindexone = ll_lbcheckminrf2.get_SelectedIndex();
			curtopindexone = ll_lbcheckminrf2.get_TopIndex();
			IndexOne();
		}
	}

	private void ll_btnfromall_Click(object sender, EventArgs e)
	{
		checked
		{
			if (Operators.CompareString(((TextBox)ll_txttempxlslist).get_Text(), "", false) != 0)
			{
				ll_lbminrflist.get_Items().Clear();
				Workbook workbook = Mod1.excelapp.Workbooks.Open(((TextBox)ll_txttempxlslist).get_Text(), Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
				Worksheet worksheet = (Worksheet)workbook.Worksheets["ALL"];
				Excel.Range currentRegion = ((_Worksheet)worksheet).get_Range((object)"A1", (object)Missing.Value).CurrentRegion;
				long num = currentRegion.Rows.Count;
				int column = ((_Worksheet)worksheet).get_Range((object)"Source_RF", (object)Missing.Value).Column;
				Excel.Range range = (Excel.Range)worksheet.Cells[2, column - 1];
				int num2 = Conversions.ToInteger(range.Interior.ColorIndex);
				ll_lbminrflist.get_Items().Add((object)(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[2, 1], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null))) + "," + Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[2, column], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)))));
				long num3 = num;
				for (long num4 = 3L; num4 <= num3; num4++)
				{
					Excel.Range range2 = (Excel.Range)worksheet.Cells[num4, column - 1];
					int num5 = Conversions.ToInteger(range2.Interior.ColorIndex);
					if (num5 != num2)
					{
						num2 = num5;
						ll_lbminrflist.get_Items().Add((object)(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[num4, 1], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null))) + "," + Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[num4, column], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)))));
					}
				}
				workbook.Close(Missing.Value, Missing.Value, Missing.Value);
			}
			ll_btncheckminrf_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}
	}

	private void ll_btnfromtxt_Click(object sender, EventArgs e)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Invalid comparison between Unknown and I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		((FileDialog)GetOpenFilename).set_Filter("minrf(*.txt)|*.txt");
		if ((int)((CommonDialog)GetOpenFilename).ShowDialog() != 1)
		{
			return;
		}
		string fileName = ((FileDialog)GetOpenFilename).get_FileName();
		if (!File.Exists(fileName))
		{
			Interaction.MsgBox((object)"没有指定合法的最小幅度信息文件.", (MsgBoxStyle)0, (object)"提示");
			return;
		}
		ll_lbminrflist.get_Items().Clear();
		Mod1.lr = new StreamReader(fileName, Encoding.Default);
		string text = "";
		while (true)
		{
			if (!Information.IsNothing((object)text))
			{
				text = Mod1.lr.ReadLine();
				if (!Information.IsNothing((object)text))
				{
					if (Operators.CompareString(Strings.Trim(text), "", false) != 0)
					{
						ll_lbminrflist.get_Items().Add((object)text);
						continue;
					}
					break;
				}
			}
			Mod1.lr.Close();
			Mod1.lr.Dispose();
			ll_btncheckminrf_Click(RuntimeHelpers.GetObjectValue(sender), e);
			break;
		}
	}

	private void ll_btntotxt_Click(object sender, EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		if ((int)((CommonDialog)GetSaveAsFilename).ShowDialog() == 1)
		{
			((FileDialog)GetSaveAsFilename).set_Filter("*.txt|*.txt");
			string fileName = ((FileDialog)GetSaveAsFilename).get_FileName();
			Mod1.wr = new StreamWriter(fileName, append: false, Encoding.Default);
			checked
			{
				int num = ll_lbminrflist.get_Items().get_Count() - 1;
				for (int i = 0; i <= num; i++)
				{
					Mod1.wr.WriteLine(RuntimeHelpers.GetObjectValue(ll_lbminrflist.get_Items().get_Item(i)));
				}
				Mod1.wr.Close();
				Mod1.wr.Dispose();
			}
		}
	}

	private void ll_btncheckminrf_Click(object sender, EventArgs e)
	{
		if (ll_lbminrflist.get_Items().get_Count() <= 0)
		{
			return;
		}
		ll_lbcheckminrf.get_Items().Clear();
		ll_lbcheckminrf2.get_Items().Clear();
		((Control)ll_btncheckminrf).set_ForeColor(Color.Green);
		checked
		{
			int num = ll_lbminrflist.get_Items().get_Count() - 1;
			int num2 = default(int);
			int num3 = default(int);
			for (int i = 0; i <= num; i++)
			{
				string[] array = Strings.Split(Conversions.ToString(ll_lbminrflist.get_Items().get_Item(i)), ",", -1, (CompareMethod)0);
				num2 = Information.UBound((Array)array, 1);
				string[] array2 = Strings.Split(array[0], "_", -1, (CompareMethod)0);
				num3 = Information.UBound((Array)array2, 1);
				ll_lbcheckminrf.get_Items().Add((object)num2);
				ll_lbcheckminrf2.get_Items().Add((object)num3);
			}
			int num4 = ll_lbminrflist.get_Items().get_Count() - 1;
			int num5 = 0;
			while (true)
			{
				if (num5 <= num4)
				{
					if ((Conversions.ToInteger(ll_lbcheckminrf.get_Items().get_Item(num5)) != num2) | (Conversions.ToInteger(ll_lbcheckminrf2.get_Items().get_Item(num5)) != num3))
					{
						break;
					}
					num5++;
					continue;
				}
				return;
			}
			((Control)ll_btncheckminrf).set_BackColor(Color.Red);
		}
	}

	private void ll_btnnameformat2_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(((TextBox)ll_txttempxlslist).get_Text(), "", false) != 0)
		{
			Workbook workbook = Mod1.excelapp.Workbooks.Open(((TextBox)ll_txttempxlslist).get_Text(), Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
			((TextBox)ll_txtnameformat2).set_Text(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(workbook.Worksheets["ALL"], (Type)null, "Range", new object[1] { "A2" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)));
			workbook.Close(Missing.Value, Missing.Value, Missing.Value);
		}
	}

	private void ll_btngenformat2_Click(object sender, EventArgs e)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		MyProject.Forms.ll_uffbnamejxformat.bz = "【步骤3】";
		((Form)MyProject.Forms.ll_uffbnamejxformat).ShowDialog();
		((TextBox)ll_txtformat2).set_Text(Q_JS.strjxen);
		ll_lbenamejxformat2.set_Text(Q_JS.strjxch);
		ll_lbliucheng.get_Items().Add((object)("当前解析格式:" + ((TextBox)ll_txtformat2).get_Text()));
		ll_lbliucheng.set_SelectedIndex(checked(ll_lbliucheng.get_Items().get_Count() - 1));
		ll_btncheckformat2_Click(RuntimeHelpers.GetObjectValue(sender), e);
		((Component)(object)MyProject.Forms.ll_uffbnamejxformat).Dispose();
	}

	private void ll_btncheckformat2_Click(object sender, EventArgs e)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		if (!((Operators.CompareString(((TextBox)ll_txtnameformat2).get_Text(), "", false) != 0) & (Operators.CompareString(((TextBox)ll_txtformat2).get_Text(), "", false) != 0)))
		{
			return;
		}
		((Control)ll_btncheckformat2).set_ForeColor(Color.Green);
		string[] array = Strings.Split(((TextBox)ll_txtformat2).get_Text(), ",", -1, (CompareMethod)0);
		if (Operators.CompareString(array[0], "_", false) != 0)
		{
			string text = "不正确的解析格式 " + ((TextBox)ll_txtformat2).get_Text() + " 第一个字符应为下划线:_";
			Interaction.MsgBox((object)text, (MsgBoxStyle)0, (object)"提示");
			ll_lbliucheng.get_Items().Add((object)text);
			((Control)ll_btncheckformat2).set_ForeColor(Color.Red);
			return;
		}
		int num = Information.UBound((Array)array, 1);
		array = Strings.Split(((TextBox)ll_txtnameformat2).get_Text(), "_", -1, (CompareMethod)0);
		int num2 = Information.UBound((Array)array, 1);
		if (num != checked(num2 + 1))
		{
			string text = "不正确的解析格式 " + ((TextBox)ll_txtformat2).get_Text() + " 没有与" + ((TextBox)ll_txtnameformat2).get_Text() + "一一对应.";
			Interaction.MsgBox((object)text, (MsgBoxStyle)0, (object)"提示");
			ll_lbliucheng.get_Items().Add((object)text);
			((Control)ll_btncheckformat2).set_ForeColor(Color.Red);
		}
	}

	private void ll_btncheckformatandminrf_Click(object sender, EventArgs e)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		if ((((Control)ll_btncheckminrf).get_ForeColor() != Color.Green) | (((Control)ll_btncheckformat2).get_ForeColor() != Color.Green))
		{
			Interaction.MsgBox((object)"请先进行最小幅度信息列表的一致性检验和解析格式正确性检查.", (MsgBoxStyle)0, (object)"提示");
		}
		else
		{
			if (!((ll_lbminrflist.get_Items().get_Count() > 0) & (Operators.CompareString(((TextBox)ll_txtformat2).get_Text(), "", false) != 0)))
			{
				return;
			}
			((Control)ll_btncheckformatandminrf).set_ForeColor(Color.Green);
			string[] array = Strings.Split(((TextBox)ll_txtformat2).get_Text(), ",", -1, (CompareMethod)0);
			int num = Information.UBound((Array)array, 1);
			if (num != checked(Conversions.ToInteger(ll_lbcheckminrf2.get_Items().get_Item(0)) + 1))
			{
				string text = "指定的解析格式与当前最小幅度列表信息中的组合格式不一致.";
				Interaction.MsgBox((object)text, (MsgBoxStyle)0, (object)"提示");
				ll_lbliucheng.get_Items().Add((object)text);
				((Control)ll_btncheckformatandminrf).set_ForeColor(Color.Red);
				return;
			}
			curstruct = "zb";
			int num2 = Strings.InStr(1, Strings.UCase(((TextBox)ll_txtformat2).get_Text()), "ZBXT", (CompareMethod)0);
			if (num2 > 0)
			{
				curstruct = "tsfb";
			}
			num2 = Strings.InStr(1, Strings.UCase(((TextBox)ll_txtformat2).get_Text()), "FIXXT", (CompareMethod)0);
			if (num2 > 0)
			{
				curstruct = "gdfb";
			}
			if (Operators.CompareString(curstruct, "zb", false) == 0)
			{
				((Control)ll_btnzbxnallqd).set_Enabled(true);
				((Control)ll_btnzbxnallqd).set_BackColor(Color.Green);
				((Control)ll_btnfbxnallqd).set_Enabled(false);
			}
			else
			{
				((Control)ll_btnfbxnallqd).set_Enabled(true);
				((Control)ll_btnfbxnallqd).set_BackColor(Color.Green);
				((Control)ll_btnzbxnallqd).set_Enabled(false);
			}
		}
	}

	private void ll_btnzbxnallqd_Click(object sender, EventArgs e)
	{
		LabelProgress.set_Value(0);
		FrameProgress.set_Text("0%");
		((Control)FrameProgress).Refresh();
		LabelProgressTotal.set_Value(0);
		FrameProgressTotal.set_Text("0%");
		((Control)this).set_Cursor(Cursors.get_AppStarting());
		if (Operators.CompareString(((TextBox)ll_txttempxlslist).get_Text(), "", false) == 0)
		{
			return;
		}
		string text = "开始更新强度性能表文件;" + ((TextBox)ll_txttempxlslist).get_Text();
		ll_lbliucheng.get_Items().Add((object)text);
		Workbook workbook = Mod1.excelapp.Workbooks.Open(((TextBox)ll_txttempxlslist).get_Text(), Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
		Worksheet worksheet = (Worksheet)workbook.Worksheets["强度"];
		LabelProgress.set_Maximum(1);
		LabelProgress.set_Value(1);
		FrameProgress.set_Text("100%");
		((Control)FrameProgress).Refresh();
		LabelProgressTotal.set_Maximum(1);
		LabelProgressTotal.set_Value(1);
		FrameProgressTotal.set_Text("100%");
		Excel.Range currentRegion = ((_Worksheet)worksheet).get_Range((object)"A1", (object)Missing.Value).CurrentRegion;
		int count = currentRegion.Rows.Count;
		int count2 = currentRegion.Columns.Count;
		float num = 0f;
		int num2 = count2;
		checked
		{
			for (int i = 2; i <= num2; i++)
			{
				((Control)this).Refresh();
				string text2 = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[1, i], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
				string text3 = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[count, i], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
				string text4 = Conversions.ToString(searchzbminrf(Conversions.ToSingle(text2), Conversions.ToSingle(text3)));
				if (Conversions.ToDouble(text4) < 0.1)
				{
					text = "文件" + ((TextBox)ll_txttempxlslist).get_Text() + "中的工作表【强度】中的" + text2 + "," + text3 + "没有搜索到对应的最小幅度.";
					ll_lbliucheng.get_Items().Add((object)text);
					continue;
				}
				if ((double)num <= Conversions.ToDouble(text4))
				{
					num = Conversions.ToSingle(text4);
				}
				int num3 = count - 1;
				for (int j = 2; j <= num3; j++)
				{
					float num4 = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[j, 1], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
					if (num4 < num)
					{
						NewLateBinding.LateSetComplex(worksheet.Cells[j, i], (Type)null, "Value", new object[1] { "" }, (string[])null, (Type[])null, false, true);
					}
				}
			}
			Mod1.excelapp.DisplayAlerts = false;
			workbook.Save();
			workbook.Close(Missing.Value, Missing.Value, Missing.Value);
			((Control)this).set_Cursor(Cursors.get_Arrow());
			text = "强度性能文件处理完毕;" + ((TextBox)ll_txttempxlslist).get_Text();
			ll_lbliucheng.get_Items().Add((object)text);
			ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
		}
	}

	private float searchzbminrf(float zbl, float zbcomb)
	{
		double num = 1E-06;
		checked
		{
			if (ll_lbminrflist.get_Items().get_Count() > 0)
			{
				int num2 = ll_lbminrflist.get_Items().get_Count() - 1;
				int num3 = 0;
				string[] array;
				while (true)
				{
					if (num3 <= num2)
					{
						array = Strings.Split(Conversions.ToString(ll_lbminrflist.get_Items().get_Item(num3)), ",", -1, (CompareMethod)0);
						string[] array2 = Strings.Split(array[0], "_", -1, (CompareMethod)0);
						float num4 = Conversions.ToSingle(array2[0]);
						float num5 = Conversions.ToSingle(array2[1]);
						if (((double)Math.Abs(num4 - zbl) < num) & ((double)Math.Abs(num5 - zbcomb) < num))
						{
							break;
						}
						num3++;
						continue;
					}
					return 0f;
				}
				return Conversions.ToSingle(array[1]);
			}
			float result = default(float);
			return result;
		}
	}

	private void ll_btnfbxnallqd_Click(object sender, EventArgs e)
	{
		((Control)this).set_Cursor(Cursors.get_AppStarting());
		if (Operators.CompareString(((TextBox)ll_txttempxlslist).get_Text(), "", false) == 0)
		{
			return;
		}
		string text = "开始更新强度性能表文件;" + ((TextBox)ll_txttempxlslist).get_Text();
		ll_lbliucheng.get_Items().Add((object)text);
		Workbook workbook = Mod1.excelapp.Workbooks.Open(((TextBox)ll_txttempxlslist).get_Text(), Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
		checked
		{
			LabelProgressTotal.set_Maximum(workbook.Worksheets.Count - 2);
			LabelProgress.set_Maximum(workbook.Worksheets.Count - 2);
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = workbook.Worksheets.GetEnumerator();
				int num = default(int);
				while (enumerator.MoveNext())
				{
					Worksheet worksheet = (Worksheet)enumerator.Current;
					((Control)this).Refresh();
					string[] array = Strings.Split(worksheet.Name, "_", -1, (CompareMethod)0);
					if (Operators.CompareString(array[0], "强度", false) != 0)
					{
						continue;
					}
					num++;
					LabelProgressTotal.set_Value(num);
					FrameProgressTotal.set_Text(Conversions.ToString((int)Math.Round((double)num / (double)(workbook.Worksheets.Count - 2) * 100.0)) + "%");
					((Control)FrameProgressTotal).Refresh();
					LabelProgress.set_Value(num);
					FrameProgress.set_Text(Conversions.ToString((int)Math.Round((double)num / (double)(workbook.Worksheets.Count - 2) * 100.0)) + "%");
					((Control)FrameProgress).Refresh();
					Excel.Range currentRegion = ((_Worksheet)worksheet).get_Range((object)"A1", (object)Missing.Value).CurrentRegion;
					int count = currentRegion.Rows.Count;
					int count2 = currentRegion.Columns.Count;
					string text2;
					float num2;
					if (ll_checkLZqd.get_Checked())
					{
						float zbl = Conversions.ToSingle(array[1]);
						num2 = 0f;
						int num3 = count2;
						for (int i = 2; i <= num3; i++)
						{
							text2 = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[1, i], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
							string text3 = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[count, i], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
							float num4 = searchfbzbyxminrf(Conversions.ToSingle(text2), Conversions.ToSingle(text3), zbl);
							if ((double)num4 < 0.1)
							{
								text = "文件" + ((TextBox)ll_txttempxlslist).get_Text() + "中的工作表" + worksheet.Name + "中的 " + text2 + "," + text3 + "没有搜索到对应的最小幅度.";
								ll_lbliucheng.get_Items().Add((object)text);
								continue;
							}
							if (num2 <= num4)
							{
								num2 = num4;
							}
							int num5 = count - 1;
							for (int j = 2; j <= num5; j++)
							{
								float num6 = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[j, 1], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
								if (num6 < num2)
								{
									NewLateBinding.LateSetComplex(worksheet.Cells[j, i], (Type)null, "Value", new object[1] { "" }, (string[])null, (Type[])null, false, true);
								}
							}
						}
						continue;
					}
					text2 = Conversions.ToString(Conversions.ToSingle(array[1]));
					num2 = 0f;
					int num7 = count2;
					for (int k = 2; k <= num7; k++)
					{
						float zbl = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[1, k], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
						string text4 = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[count, k], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
						float num4 = searchfbfbyxminrf(zbl, Conversions.ToSingle(text4), Conversions.ToSingle(text2));
						if ((double)num4 < 0.1)
						{
							text = "文件" + ((TextBox)ll_txttempxlslist).get_Text() + "中的工作表" + worksheet.Name + "中的 " + Conversions.ToString(zbl) + "," + text4 + "没有搜索到对应的最小幅度.";
							ll_lbliucheng.get_Items().Add((object)text);
							continue;
						}
						if (num2 <= num4)
						{
							num2 = num4;
						}
						int num8 = count - 1;
						for (int l = 2; l <= num8; l++)
						{
							float num6 = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[l, 1], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
							if (num6 < num2)
							{
								NewLateBinding.LateSetComplex(worksheet.Cells[l, k], (Type)null, "Value", new object[1] { "" }, (string[])null, (Type[])null, false, true);
							}
						}
					}
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			Mod1.excelapp.DisplayAlerts = false;
			workbook.Save();
			workbook.Close(Missing.Value, Missing.Value, Missing.Value);
			((Control)this).set_Cursor(Cursors.get_Arrow());
			text = "强度性能文件处理完毕;" + ((TextBox)ll_txttempxlslist).get_Text();
			ll_lbliucheng.get_Items().Add((object)text);
			ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
		}
	}

	private float searchfbzbyxminrf(float fbl, float fbcomb, float zbl)
	{
		double num = 1E-06;
		checked
		{
			if (ll_lbminrflist.get_Items().get_Count() > 0)
			{
				int num2 = ll_lbminrflist.get_Items().get_Count() - 1;
				int num3 = 0;
				string[] array;
				while (true)
				{
					if (num3 <= num2)
					{
						array = Strings.Split(Conversions.ToString(ll_lbminrflist.get_Items().get_Item(num3)), ",", -1, (CompareMethod)0);
						string[] array2 = Strings.Split(array[0], "_", -1, (CompareMethod)0);
						float num4 = Conversions.ToSingle(array2[0]);
						float num5 = Conversions.ToSingle(array2[2]);
						float num6 = Conversions.ToSingle(array2[3]);
						if (((double)Math.Abs(num4 - zbl) < num) & ((double)Math.Abs(num6 - fbcomb) < num) & ((double)Math.Abs(num5 - fbl) < num))
						{
							break;
						}
						num3++;
						continue;
					}
					return 0f;
				}
				return Conversions.ToSingle(array[1]);
			}
			float result = default(float);
			return result;
		}
	}

	private float searchfbfbyxminrf(float zbl, float zbcomb, float fbl)
	{
		double num = 1E-06;
		checked
		{
			if (ll_lbminrflist.get_Items().get_Count() > 0)
			{
				int num2 = ll_lbminrflist.get_Items().get_Count() - 1;
				int num3 = 0;
				string[] array;
				while (true)
				{
					if (num3 <= num2)
					{
						array = Strings.Split(Conversions.ToString(ll_lbminrflist.get_Items().get_Item(num3)), ",", -1, (CompareMethod)0);
						string[] array2 = Strings.Split(array[0], "_", -1, (CompareMethod)0);
						float num4 = Conversions.ToSingle(array2[0]);
						float num5 = Conversions.ToSingle(array2[1]);
						float num6 = Conversions.ToSingle(array2[2]);
						if (((double)Math.Abs(num4 - zbl) < num) & ((double)Math.Abs(num5 - zbcomb) < num) & ((double)Math.Abs(num6 - fbl) < num))
						{
							break;
						}
						num3++;
						continue;
					}
					return 0f;
				}
				return Conversions.ToSingle(array[1]);
			}
			float result = default(float);
			return result;
		}
	}

	private void cbdisplay_CheckedChanged(object sender, EventArgs e)
	{
		if (cbdisplay.get_Checked())
		{
			Mod1.excelapp.Visible = true;
		}
		else
		{
			Mod1.excelapp.Visible = false;
		}
	}

	private void MultiPage_TabStripMouseClick(object sender, MouseEventArgs e)
	{
		LabelProgress.set_Value(0);
		FrameProgress.set_Text("0%");
		((Control)FrameProgress).Refresh();
		LabelProgressTotal.set_Value(0);
		FrameProgressTotal.set_Text("0%");
		ll_lbecurxnname.set_Text("");
		((Control)this).Refresh();
	}

	private void ll_lbfblcnamecheckresult_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (ll_lbfblcnamecheckresult.get_Items().get_Count() != 0)
		{
			ll_lbfblcnamelist.set_SelectedIndex(ll_lbfblcnamecheckresult.get_SelectedIndex());
			ll_lbfblcnamelist.set_TopIndex(ll_lbfblcnamecheckresult.get_TopIndex());
		}
	}

	private void ll_lblcnamecheckresult_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (ll_lblcnamecheckresult.get_Items().get_Count() != 0)
		{
			ll_lblcnamelist.set_SelectedIndex(ll_lblcnamecheckresult.get_SelectedIndex());
			ll_lblcnamelist.set_TopIndex(ll_lblcnamecheckresult.get_TopIndex());
		}
	}

	private void btnexit_Click(object sender, EventArgs e)
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
}
