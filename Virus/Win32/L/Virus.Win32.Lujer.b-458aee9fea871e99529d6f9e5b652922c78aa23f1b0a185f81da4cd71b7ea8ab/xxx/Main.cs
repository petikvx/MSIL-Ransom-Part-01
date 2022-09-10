using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Excel;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using xxx.My;

namespace xxx;

[DesignerGenerated]
public class Main : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("RibbonPanel1")]
	private RibbonPanel _RibbonPanel1;

	[AccessedThroughProperty("RibbonBar1")]
	private RibbonBar _RibbonBar1;

	[AccessedThroughProperty("ToolsOpen")]
	private ButtonItem _ToolsOpen;

	[AccessedThroughProperty("RibbonPanel2")]
	private RibbonPanel _RibbonPanel2;

	[AccessedThroughProperty("RibbonPanel4")]
	private RibbonPanel _RibbonPanel4;

	[AccessedThroughProperty("RibbonTabItem1")]
	private RibbonTabItem _RibbonTabItem1;

	[AccessedThroughProperty("RibbonTabItem2")]
	private RibbonTabItem _RibbonTabItem2;

	[AccessedThroughProperty("RibbonTabItem4")]
	private RibbonTabItem _RibbonTabItem4;

	[AccessedThroughProperty("ButtonItem1")]
	private ButtonItem _ButtonItem1;

	[AccessedThroughProperty("ToolsExit")]
	private ButtonItem _ToolsExit;

	[AccessedThroughProperty("RCT1")]
	private RibbonControl _RCT1;

	[AccessedThroughProperty("QatCustomizeItem1")]
	private QatCustomizeItem _QatCustomizeItem1;

	[AccessedThroughProperty("lbx")]
	private LabelX _lbx;

	[AccessedThroughProperty("zdqtk")]
	private RibbonBar _zdqtk;

	[AccessedThroughProperty("zdqtmxk")]
	private ButtonItem _zdqtmxk;

	[AccessedThroughProperty("bdmr")]
	private ButtonItem _bdmr;

	[AccessedThroughProperty("ckdqk")]
	private ButtonItem _ckdqk;

	[AccessedThroughProperty("gldqk")]
	private ButtonItem _gldqk;

	[AccessedThroughProperty("ToolsInput")]
	private ButtonItem _ToolsInput;

	[AccessedThroughProperty("ToolsSave")]
	private ButtonItem _ToolsSave;

	[AccessedThroughProperty("Toolsfxxd")]
	private ButtonItem _Toolsfxxd;

	[AccessedThroughProperty("RibbonBar2")]
	private RibbonBar _RibbonBar2;

	[AccessedThroughProperty("ButtonItem4")]
	private ButtonItem _ButtonItem4;

	[AccessedThroughProperty("RibbonPanel3")]
	private RibbonPanel _RibbonPanel3;

	[AccessedThroughProperty("RibbonBar3")]
	private RibbonBar _RibbonBar3;

	[AccessedThroughProperty("help1")]
	private ButtonItem _help1;

	[AccessedThroughProperty("help2")]
	private ButtonItem _help2;

	[AccessedThroughProperty("help3")]
	private ButtonItem _help3;

	[AccessedThroughProperty("help4")]
	private ButtonItem _help4;

	[AccessedThroughProperty("RibbonTabItem3")]
	private RibbonTabItem _RibbonTabItem3;

	[AccessedThroughProperty("lslog")]
	private ListBox _lslog;

	[AccessedThroughProperty("proedgkwj")]
	private ButtonItem _proedgkwj;

	[AccessedThroughProperty("proedgkjs")]
	private ButtonItem _proedgkjs;

	[AccessedThroughProperty("proedgkjg")]
	private ButtonItem _proedgkjg;

	[AccessedThroughProperty("ansysqx")]
	private ButtonItem _ansysqx;

	[AccessedThroughProperty("ansysdxxnb")]
	private ButtonItem _ansysdxxnb;

	[AccessedThroughProperty("ansysxnbll")]
	private ButtonItem _ansysxnbll;

	[AccessedThroughProperty("ansystoword")]
	private ButtonItem _ansystoword;

	[AccessedThroughProperty("Jss")]
	private ButtonItem _Jss;

	[AccessedThroughProperty("ansysxnzj")]
	private ButtonItem _ansysxnzj;

	[AccessedThroughProperty("BIindex")]
	private ButtonItem _BIindex;

	[AccessedThroughProperty("ansysxnbmcgff")]
	private ButtonItem _ansysxnbmcgff;

	[AccessedThroughProperty("IndexVBA")]
	private ButtonItem _IndexVBA;

	private bool bj1;

	public ArrayList arr;

	private int hh;

	internal virtual RibbonPanel RibbonPanel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RibbonPanel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RibbonPanel1 = value;
		}
	}

	internal virtual RibbonBar RibbonBar1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RibbonBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RibbonBar1 = value;
		}
	}

	internal virtual ButtonItem ToolsOpen
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolsOpen;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ToolsOpen_Click;
			if (_ToolsOpen != null)
			{
				((BaseItem)_ToolsOpen).remove_Click(eventHandler);
			}
			_ToolsOpen = value;
			if (_ToolsOpen != null)
			{
				((BaseItem)_ToolsOpen).add_Click(eventHandler);
			}
		}
	}

	internal virtual RibbonPanel RibbonPanel2
	{
		[DebuggerNonUserCode]
		get
		{
			return _RibbonPanel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RibbonPanel2 = value;
		}
	}

	internal virtual RibbonPanel RibbonPanel4
	{
		[DebuggerNonUserCode]
		get
		{
			return _RibbonPanel4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RibbonPanel4 = value;
		}
	}

	internal virtual RibbonTabItem RibbonTabItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RibbonTabItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RibbonTabItem1 = value;
		}
	}

	internal virtual RibbonTabItem RibbonTabItem2
	{
		[DebuggerNonUserCode]
		get
		{
			return _RibbonTabItem2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RibbonTabItem2 = value;
		}
	}

	internal virtual RibbonTabItem RibbonTabItem4
	{
		[DebuggerNonUserCode]
		get
		{
			return _RibbonTabItem4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RibbonTabItem4 = value;
		}
	}

	internal virtual ButtonItem ButtonItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ButtonItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ButtonItem1 = value;
		}
	}

	internal virtual ButtonItem ToolsExit
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolsExit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ToolsExit_Click;
			if (_ToolsExit != null)
			{
				((BaseItem)_ToolsExit).remove_Click(eventHandler);
			}
			_ToolsExit = value;
			if (_ToolsExit != null)
			{
				((BaseItem)_ToolsExit).add_Click(eventHandler);
			}
		}
	}

	internal virtual RibbonControl RCT1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RCT1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RCT1_ItemClick;
			if (_RCT1 != null)
			{
				_RCT1.remove_ItemClick(eventHandler);
			}
			_RCT1 = value;
			if (_RCT1 != null)
			{
				_RCT1.add_ItemClick(eventHandler);
			}
		}
	}

	internal virtual QatCustomizeItem QatCustomizeItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _QatCustomizeItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_QatCustomizeItem1 = value;
		}
	}

	public virtual LabelX lbx
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbx = value;
		}
	}

	internal virtual RibbonBar zdqtk
	{
		[DebuggerNonUserCode]
		get
		{
			return _zdqtk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_zdqtk = value;
		}
	}

	internal virtual ButtonItem zdqtmxk
	{
		[DebuggerNonUserCode]
		get
		{
			return _zdqtmxk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = zdqtmxk_Click;
			if (_zdqtmxk != null)
			{
				((BaseItem)_zdqtmxk).remove_Click(eventHandler);
			}
			_zdqtmxk = value;
			if (_zdqtmxk != null)
			{
				((BaseItem)_zdqtmxk).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonItem bdmr
	{
		[DebuggerNonUserCode]
		get
		{
			return _bdmr;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = bdmr_Click;
			if (_bdmr != null)
			{
				((BaseItem)_bdmr).remove_Click(eventHandler);
			}
			_bdmr = value;
			if (_bdmr != null)
			{
				((BaseItem)_bdmr).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonItem ckdqk
	{
		[DebuggerNonUserCode]
		get
		{
			return _ckdqk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ckdqk_Click;
			if (_ckdqk != null)
			{
				((BaseItem)_ckdqk).remove_Click(eventHandler);
			}
			_ckdqk = value;
			if (_ckdqk != null)
			{
				((BaseItem)_ckdqk).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonItem gldqk
	{
		[DebuggerNonUserCode]
		get
		{
			return _gldqk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = gldqk_Click;
			if (_gldqk != null)
			{
				((BaseItem)_gldqk).remove_Click(eventHandler);
			}
			_gldqk = value;
			if (_gldqk != null)
			{
				((BaseItem)_gldqk).add_Click(eventHandler);
			}
		}
	}

	public virtual ButtonItem ToolsInput
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolsInput;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ToolsInput_Click;
			if (_ToolsInput != null)
			{
				((BaseItem)_ToolsInput).remove_Click(eventHandler);
			}
			_ToolsInput = value;
			if (_ToolsInput != null)
			{
				((BaseItem)_ToolsInput).add_Click(eventHandler);
			}
		}
	}

	public virtual ButtonItem ToolsSave
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolsSave;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ToolsSave_Click;
			if (_ToolsSave != null)
			{
				((BaseItem)_ToolsSave).remove_Click(eventHandler);
			}
			_ToolsSave = value;
			if (_ToolsSave != null)
			{
				((BaseItem)_ToolsSave).add_Click(eventHandler);
			}
		}
	}

	public virtual ButtonItem Toolsfxxd
	{
		[DebuggerNonUserCode]
		get
		{
			return _Toolsfxxd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Toolsfxxd_Click;
			if (_Toolsfxxd != null)
			{
				((BaseItem)_Toolsfxxd).remove_Click(eventHandler);
			}
			_Toolsfxxd = value;
			if (_Toolsfxxd != null)
			{
				((BaseItem)_Toolsfxxd).add_Click(eventHandler);
			}
		}
	}

	internal virtual RibbonBar RibbonBar2
	{
		[DebuggerNonUserCode]
		get
		{
			return _RibbonBar2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RibbonBar2 = value;
		}
	}

	internal virtual ButtonItem ButtonItem4
	{
		[DebuggerNonUserCode]
		get
		{
			return _ButtonItem4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ButtonItem4 = value;
		}
	}

	internal virtual RibbonPanel RibbonPanel3
	{
		[DebuggerNonUserCode]
		get
		{
			return _RibbonPanel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RibbonPanel3 = value;
		}
	}

	internal virtual RibbonBar RibbonBar3
	{
		[DebuggerNonUserCode]
		get
		{
			return _RibbonBar3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RibbonBar3 = value;
		}
	}

	internal virtual ButtonItem help1
	{
		[DebuggerNonUserCode]
		get
		{
			return _help1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = help1_Click;
			if (_help1 != null)
			{
				((BaseItem)_help1).remove_Click(eventHandler);
			}
			_help1 = value;
			if (_help1 != null)
			{
				((BaseItem)_help1).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonItem help2
	{
		[DebuggerNonUserCode]
		get
		{
			return _help2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = help2_Click;
			if (_help2 != null)
			{
				((BaseItem)_help2).remove_Click(eventHandler);
			}
			_help2 = value;
			if (_help2 != null)
			{
				((BaseItem)_help2).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonItem help3
	{
		[DebuggerNonUserCode]
		get
		{
			return _help3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = help3_Click;
			if (_help3 != null)
			{
				((BaseItem)_help3).remove_Click(eventHandler);
			}
			_help3 = value;
			if (_help3 != null)
			{
				((BaseItem)_help3).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonItem help4
	{
		[DebuggerNonUserCode]
		get
		{
			return _help4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = help4_Click;
			if (_help4 != null)
			{
				((BaseItem)_help4).remove_Click(eventHandler);
			}
			_help4 = value;
			if (_help4 != null)
			{
				((BaseItem)_help4).add_Click(eventHandler);
			}
		}
	}

	internal virtual RibbonTabItem RibbonTabItem3
	{
		[DebuggerNonUserCode]
		get
		{
			return _RibbonTabItem3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RibbonTabItem3 = value;
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

	public virtual ButtonItem proedgkwj
	{
		[DebuggerNonUserCode]
		get
		{
			return _proedgkwj;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = proedgkwj_Click;
			if (_proedgkwj != null)
			{
				((BaseItem)_proedgkwj).remove_Click(eventHandler);
			}
			_proedgkwj = value;
			if (_proedgkwj != null)
			{
				((BaseItem)_proedgkwj).add_Click(eventHandler);
			}
		}
	}

	public virtual ButtonItem proedgkjs
	{
		[DebuggerNonUserCode]
		get
		{
			return _proedgkjs;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = proedgkjs_Click;
			if (_proedgkjs != null)
			{
				((BaseItem)_proedgkjs).remove_Click(eventHandler);
			}
			_proedgkjs = value;
			if (_proedgkjs != null)
			{
				((BaseItem)_proedgkjs).add_Click(eventHandler);
			}
		}
	}

	public virtual ButtonItem proedgkjg
	{
		[DebuggerNonUserCode]
		get
		{
			return _proedgkjg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = proedgkjg_Click;
			if (_proedgkjg != null)
			{
				((BaseItem)_proedgkjg).remove_Click(eventHandler);
			}
			_proedgkjg = value;
			if (_proedgkjg != null)
			{
				((BaseItem)_proedgkjg).add_Click(eventHandler);
			}
		}
	}

	public virtual ButtonItem ansysqx
	{
		[DebuggerNonUserCode]
		get
		{
			return _ansysqx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ansysqx_Click;
			if (_ansysqx != null)
			{
				((BaseItem)_ansysqx).remove_Click(eventHandler);
			}
			_ansysqx = value;
			if (_ansysqx != null)
			{
				((BaseItem)_ansysqx).add_Click(eventHandler);
			}
		}
	}

	public virtual ButtonItem ansysdxxnb
	{
		[DebuggerNonUserCode]
		get
		{
			return _ansysdxxnb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ansysdxxnb_Click;
			if (_ansysdxxnb != null)
			{
				((BaseItem)_ansysdxxnb).remove_Click(eventHandler);
			}
			_ansysdxxnb = value;
			if (_ansysdxxnb != null)
			{
				((BaseItem)_ansysdxxnb).add_Click(eventHandler);
			}
		}
	}

	public virtual ButtonItem ansysxnbll
	{
		[DebuggerNonUserCode]
		get
		{
			return _ansysxnbll;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ansysxnbll_Click;
			if (_ansysxnbll != null)
			{
				((BaseItem)_ansysxnbll).remove_Click(eventHandler);
			}
			_ansysxnbll = value;
			if (_ansysxnbll != null)
			{
				((BaseItem)_ansysxnbll).add_Click(eventHandler);
			}
		}
	}

	public virtual ButtonItem ansystoword
	{
		[DebuggerNonUserCode]
		get
		{
			return _ansystoword;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ansystoword_Click;
			if (_ansystoword != null)
			{
				((BaseItem)_ansystoword).remove_Click(eventHandler);
			}
			_ansystoword = value;
			if (_ansystoword != null)
			{
				((BaseItem)_ansystoword).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonItem Jss
	{
		[DebuggerNonUserCode]
		get
		{
			return _Jss;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Jss_Click;
			if (_Jss != null)
			{
				((BaseItem)_Jss).remove_Click(eventHandler);
			}
			_Jss = value;
			if (_Jss != null)
			{
				((BaseItem)_Jss).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonItem ansysxnzj
	{
		[DebuggerNonUserCode]
		get
		{
			return _ansysxnzj;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ansysxnzj_Click;
			if (_ansysxnzj != null)
			{
				((BaseItem)_ansysxnzj).remove_Click(eventHandler);
			}
			_ansysxnzj = value;
			if (_ansysxnzj != null)
			{
				((BaseItem)_ansysxnzj).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonItem BIindex
	{
		[DebuggerNonUserCode]
		get
		{
			return _BIindex;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = BIindex_Click;
			if (_BIindex != null)
			{
				((BaseItem)_BIindex).remove_Click(eventHandler);
			}
			_BIindex = value;
			if (_BIindex != null)
			{
				((BaseItem)_BIindex).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonItem ansysxnbmcgff
	{
		[DebuggerNonUserCode]
		get
		{
			return _ansysxnbmcgff;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ansysxnbmcgff_Click;
			if (_ansysxnbmcgff != null)
			{
				((BaseItem)_ansysxnbmcgff).remove_Click(eventHandler);
			}
			_ansysxnbmcgff = value;
			if (_ansysxnbmcgff != null)
			{
				((BaseItem)_ansysxnbmcgff).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonItem IndexVBA
	{
		[DebuggerNonUserCode]
		get
		{
			return _IndexVBA;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = IndexVBA_Click;
			if (_IndexVBA != null)
			{
				((BaseItem)_IndexVBA).remove_Click(eventHandler);
			}
			_IndexVBA = value;
			if (_IndexVBA != null)
			{
				((BaseItem)_IndexVBA).add_Click(eventHandler);
			}
		}
	}

	public Main()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		((Form)this).add_FormClosed(new FormClosedEventHandler(Main_FormClosed));
		((Form)this).add_Load((EventHandler)Main_Load);
		((Control)this).add_Resize((EventHandler)Main_Resize);
		bj1 = false;
		arr = new ArrayList();
		hh = 28;
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
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
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected O, but got Unknown
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected O, but got Unknown
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_083c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0846: Expected O, but got Unknown
		//IL_08c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ce: Expected O, but got Unknown
		//IL_094c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0956: Expected O, but got Unknown
		//IL_09e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ea: Expected O, but got Unknown
		//IL_0a74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7e: Expected O, but got Unknown
		//IL_0b08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b12: Expected O, but got Unknown
		//IL_0b90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9a: Expected O, but got Unknown
		//IL_0c18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c22: Expected O, but got Unknown
		//IL_0ca0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0caa: Expected O, but got Unknown
		//IL_0d28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d32: Expected O, but got Unknown
		//IL_0d94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9e: Expected O, but got Unknown
		//IL_0e1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e26: Expected O, but got Unknown
		//IL_0ee0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1136: Unknown result type (might be due to invalid IL or missing references)
		//IL_1140: Expected O, but got Unknown
		//IL_11ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b8: Expected O, but got Unknown
		//IL_1226: Unknown result type (might be due to invalid IL or missing references)
		//IL_1230: Expected O, but got Unknown
		//IL_129e: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a8: Expected O, but got Unknown
		//IL_130a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1314: Expected O, but got Unknown
		//IL_13ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_160b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1615: Expected O, but got Unknown
		//IL_1677: Unknown result type (might be due to invalid IL or missing references)
		//IL_1681: Expected O, but got Unknown
		//IL_16e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ed: Expected O, but got Unknown
		//IL_174f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1759: Expected O, but got Unknown
		//IL_17f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a38: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a42: Expected O, but got Unknown
		//IL_1aa4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aae: Expected O, but got Unknown
		//IL_1b1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b26: Expected O, but got Unknown
		//IL_1b88: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b92: Expected O, but got Unknown
		//IL_1d14: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d1e: Expected O, but got Unknown
		//IL_1d97: Unknown result type (might be due to invalid IL or missing references)
		//IL_1da1: Expected O, but got Unknown
		//IL_1e09: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e13: Expected O, but got Unknown
		//IL_1e85: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e8f: Expected O, but got Unknown
		//IL_1eed: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ef7: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Main));
		RCT1 = new RibbonControl();
		RibbonPanel2 = new RibbonPanel();
		RibbonBar2 = new RibbonBar();
		proedgkwj = new ButtonItem();
		proedgkjs = new ButtonItem();
		proedgkjg = new ButtonItem();
		ansysqx = new ButtonItem();
		ansysdxxnb = new ButtonItem();
		BIindex = new ButtonItem();
		IndexVBA = new ButtonItem();
		ansysxnbll = new ButtonItem();
		ansysxnzj = new ButtonItem();
		ansysxnbmcgff = new ButtonItem();
		ansystoword = new ButtonItem();
		Jss = new ButtonItem();
		RibbonPanel1 = new RibbonPanel();
		RibbonBar1 = new RibbonBar();
		ToolsOpen = new ButtonItem();
		ToolsInput = new ButtonItem();
		Toolsfxxd = new ButtonItem();
		ToolsSave = new ButtonItem();
		ToolsExit = new ButtonItem();
		RibbonPanel4 = new RibbonPanel();
		zdqtk = new RibbonBar();
		bdmr = new ButtonItem();
		zdqtmxk = new ButtonItem();
		ckdqk = new ButtonItem();
		gldqk = new ButtonItem();
		RibbonPanel3 = new RibbonPanel();
		RibbonBar3 = new RibbonBar();
		help1 = new ButtonItem();
		help2 = new ButtonItem();
		help3 = new ButtonItem();
		help4 = new ButtonItem();
		RibbonTabItem1 = new RibbonTabItem();
		RibbonTabItem2 = new RibbonTabItem();
		RibbonTabItem4 = new RibbonTabItem();
		RibbonTabItem3 = new RibbonTabItem();
		ButtonItem1 = new ButtonItem();
		QatCustomizeItem1 = new QatCustomizeItem();
		lbx = new LabelX();
		ButtonItem4 = new ButtonItem();
		lslog = new ListBox();
		RCT1.SuspendLayout();
		((Control)RibbonPanel2).SuspendLayout();
		((Control)RibbonPanel1).SuspendLayout();
		((Control)RibbonPanel4).SuspendLayout();
		((Control)RibbonPanel3).SuspendLayout();
		((Control)this).SuspendLayout();
		RCT1.set_AutoSize(true);
		RCT1.get_BackgroundStyle().set_Class("");
		RCT1.get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)RCT1).get_Controls().Add((Control)(object)RibbonPanel2);
		((Control)RCT1).get_Controls().Add((Control)(object)RibbonPanel1);
		((Control)RCT1).get_Controls().Add((Control)(object)RibbonPanel4);
		((Control)RCT1).get_Controls().Add((Control)(object)RibbonPanel3);
		((Control)RCT1).set_Cursor(Cursors.get_Default());
		((Control)RCT1).set_Dock((DockStyle)1);
		RCT1.set_FadeEffect(false);
		((Control)RCT1).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		RCT1.get_Items().AddRange((BaseItem[])(object)new BaseItem[4]
		{
			(BaseItem)RibbonTabItem1,
			(BaseItem)RibbonTabItem2,
			(BaseItem)RibbonTabItem4,
			(BaseItem)RibbonTabItem3
		});
		RCT1.set_KeyTipsFont(new Font("Tahoma", 7f));
		RibbonControl rCT = RCT1;
		Point location = new Point(0, 0);
		((Control)rCT).set_Location(location);
		((Control)RCT1).set_Name("RCT1");
		RibbonControl rCT2 = RCT1;
		Padding padding = default(Padding);
		((Padding)(ref padding))._002Ector(0, 0, 0, 2);
		((Control)rCT2).set_Padding(padding);
		RCT1.get_QuickToolbarItems().AddRange((BaseItem[])(object)new BaseItem[2]
		{
			(BaseItem)ButtonItem1,
			(BaseItem)QatCustomizeItem1
		});
		RibbonControl rCT3 = RCT1;
		Size size = new Size(1028, 117);
		((Control)rCT3).set_Size(size);
		RCT1.set_Style((eDotNetBarStyle)7);
		RCT1.get_SystemText().set_MaximizeRibbonText("&Maximize the Ribbon");
		RCT1.get_SystemText().set_MinimizeRibbonText("Mi&nimize the Ribbon");
		RCT1.get_SystemText().set_QatAddItemText("&Add to Quick Access Toolbar");
		RCT1.get_SystemText().set_QatCustomizeMenuLabel("<b>Customize Quick Access Toolbar</b>");
		RCT1.get_SystemText().set_QatCustomizeText("&Customize Quick Access Toolbar...");
		RCT1.get_SystemText().set_QatDialogAddButton("&Add >>");
		RCT1.get_SystemText().set_QatDialogCancelButton("Cancel");
		RCT1.get_SystemText().set_QatDialogCaption("Customize Quick Access Toolbar");
		RCT1.get_SystemText().set_QatDialogCategoriesLabel("&Choose commands from:");
		RCT1.get_SystemText().set_QatDialogOkButton("OK");
		RCT1.get_SystemText().set_QatDialogPlacementCheckbox("&Place Quick Access Toolbar below the Ribbon");
		RCT1.get_SystemText().set_QatDialogRemoveButton("&Remove");
		RCT1.get_SystemText().set_QatPlaceAboveRibbonText("&Place Quick Access Toolbar above the Ribbon");
		RCT1.get_SystemText().set_QatPlaceBelowRibbonText("&Place Quick Access Toolbar below the Ribbon");
		RCT1.get_SystemText().set_QatRemoveItemText("&Remove from Quick Access Toolbar");
		RCT1.set_TabGroupHeight(14);
		((Control)RCT1).set_TabIndex(1);
		((Panel)RibbonPanel2).set_AutoSize(true);
		((PanelControl)RibbonPanel2).set_ColorSchemeStyle((eDotNetBarStyle)7);
		((Control)RibbonPanel2).get_Controls().Add((Control)(object)RibbonBar2);
		RibbonPanel2.set_Dock((DockStyle)5);
		RibbonPanel ribbonPanel = RibbonPanel2;
		location = new Point(0, 26);
		ribbonPanel.set_Location(location);
		((Control)RibbonPanel2).set_Name("RibbonPanel2");
		RibbonPanel ribbonPanel2 = RibbonPanel2;
		((Padding)(ref padding))._002Ector(3, 0, 3, 3);
		((Control)ribbonPanel2).set_Padding(padding);
		RibbonPanel ribbonPanel3 = RibbonPanel2;
		size = new Size(1028, 89);
		ribbonPanel3.set_Size(size);
		((PanelControl)RibbonPanel2).get_Style().set_Class("");
		((PanelControl)RibbonPanel2).get_Style().set_CornerType((eCornerType)1);
		((PanelControl)RibbonPanel2).get_StyleMouseDown().set_Class("");
		((PanelControl)RibbonPanel2).get_StyleMouseDown().set_CornerType((eCornerType)1);
		((PanelControl)RibbonPanel2).get_StyleMouseOver().set_Class("");
		((PanelControl)RibbonPanel2).get_StyleMouseOver().set_CornerType((eCornerType)1);
		((Control)RibbonPanel2).set_TabIndex(2);
		((ItemControl)RibbonBar2).set_AlwaysDisplayKeyAccelerators(true);
		((Control)RibbonBar2).set_Anchor((AnchorStyles)13);
		RibbonBar2.set_AutoOverflowEnabled(false);
		((ScrollableControl)RibbonBar2).set_AutoScroll(true);
		RibbonBar2.get_BackgroundMouseOverStyle().set_Class("");
		RibbonBar2.get_BackgroundMouseOverStyle().set_CornerType((eCornerType)1);
		((ItemControl)RibbonBar2).get_BackgroundStyle().set_Class("");
		((ItemControl)RibbonBar2).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((ItemControl)RibbonBar2).set_ContainerControlProcessDialogKey(true);
		RibbonBar2.get_Items().AddRange((BaseItem[])(object)new BaseItem[12]
		{
			(BaseItem)proedgkwj,
			(BaseItem)proedgkjs,
			(BaseItem)proedgkjg,
			(BaseItem)ansysqx,
			(BaseItem)ansysdxxnb,
			(BaseItem)BIindex,
			(BaseItem)IndexVBA,
			(BaseItem)ansysxnbll,
			(BaseItem)ansysxnzj,
			(BaseItem)ansysxnbmcgff,
			(BaseItem)ansystoword,
			(BaseItem)Jss
		});
		RibbonBar ribbonBar = RibbonBar2;
		location = new Point(3, 0);
		((Control)ribbonBar).set_Location(location);
		((Control)RibbonBar2).set_Name("RibbonBar2");
		RibbonBar ribbonBar2 = RibbonBar2;
		size = new Size(1013, 74);
		((Control)ribbonBar2).set_Size(size);
		RibbonBar2.set_Style((eDotNetBarStyle)7);
		((Control)RibbonBar2).set_TabIndex(1);
		((Control)RibbonBar2).set_Text("RibbonBar2");
		RibbonBar2.get_TitleStyle().set_Class("");
		RibbonBar2.get_TitleStyle().set_CornerType((eCornerType)1);
		RibbonBar2.get_TitleStyleMouseOver().set_Class("");
		RibbonBar2.get_TitleStyleMouseOver().set_CornerType((eCornerType)1);
		RibbonBar2.set_TitleVisible(false);
		proedgkwj.set_ButtonStyle((eButtonStyle)2);
		proedgkwj.set_HotFontBold(true);
		proedgkwj.set_Image((Image)componentResourceManager.GetObject("proedgkwj.Image"));
		proedgkwj.set_ImagePosition((eImagePosition)2);
		((BaseItem)proedgkwj).set_Name("proedgkwj");
		proedgkwj.set_SubItemsExpandWidth(14);
		((BaseItem)proedgkwj).set_Tag((object)"mlc2");
		proedgkwj.set_Text("PROE 多工况计算文件自动建立");
		((BaseItem)proedgkwj).set_Visible(false);
		proedgkjs.set_ButtonStyle((eButtonStyle)2);
		proedgkjs.set_HotFontBold(true);
		proedgkjs.set_Image((Image)componentResourceManager.GetObject("proedgkjs.Image"));
		proedgkjs.set_ImagePosition((eImagePosition)2);
		((BaseItem)proedgkjs).set_Name("proedgkjs");
		proedgkjs.set_SubItemsExpandWidth(14);
		((BaseItem)proedgkjs).set_Tag((object)"mlc3");
		proedgkjs.set_Text("PROE 多工况计算文件自动计算");
		((BaseItem)proedgkjs).set_Visible(false);
		proedgkjg.set_ButtonStyle((eButtonStyle)2);
		proedgkjg.set_HotFontBold(true);
		proedgkjg.set_Image((Image)componentResourceManager.GetObject("proedgkjg.Image"));
		proedgkjg.set_ImagePosition((eImagePosition)2);
		((BaseItem)proedgkjg).set_Name("proedgkjg");
		((PopupItem)proedgkjg).set_PersonalizedMenus((ePersonalizedMenus)2);
		proedgkjg.set_SubItemsExpandWidth(14);
		((BaseItem)proedgkjg).set_Tag((object)"mlc4");
		proedgkjg.set_Text("PROE 多工况计算结果汇总");
		((BaseItem)proedgkjg).set_Visible(false);
		ansysqx.set_ButtonStyle((eButtonStyle)2);
		ansysqx.set_HotFontBold(true);
		ansysqx.set_Image((Image)componentResourceManager.GetObject("ansysqx.Image"));
		ansysqx.set_ImagePosition((eImagePosition)2);
		((BaseItem)ansysqx).set_Name("ansysqx");
		((PopupItem)ansysqx).set_PersonalizedMenus((ePersonalizedMenus)2);
		ansysqx.set_SubItemsExpandWidth(14);
		((BaseItem)ansysqx).set_Tag((object)"fa2");
		ansysqx.set_Text("ANSYS 臂头曲线自动生成");
		((BaseItem)ansysqx).set_Visible(false);
		ansysdxxnb.set_ButtonStyle((eButtonStyle)2);
		ansysdxxnb.set_HotFontBold(true);
		ansysdxxnb.set_Image((Image)componentResourceManager.GetObject("ansysdxxnb.Image"));
		ansysdxxnb.set_ImagePosition((eImagePosition)2);
		((BaseItem)ansysdxxnb).set_Name("ansysdxxnb");
		((PopupItem)ansysdxxnb).set_PersonalizedMenus((ePersonalizedMenus)2);
		ansysdxxnb.set_SubItemsExpandWidth(14);
		((BaseItem)ansysdxxnb).set_Tag((object)"xn2");
		ansysdxxnb.set_Text("ANSYS11.0 单项性能表生成");
		((BaseItem)ansysdxxnb).set_Visible(false);
		BIindex.set_ButtonStyle((eButtonStyle)2);
		BIindex.set_HotFontBold(true);
		BIindex.set_Image((Image)componentResourceManager.GetObject("BIindex.Image"));
		BIindex.set_ImagePosition((eImagePosition)2);
		((BaseItem)BIindex).set_Name("BIindex");
		BIindex.set_SubItemsExpandWidth(14);
		((BaseItem)BIindex).set_Tag((object)"xn7");
		BIindex.set_Text("生成索引 文件");
		((BaseItem)BIindex).set_Visible(false);
		IndexVBA.set_ButtonStyle((eButtonStyle)2);
		IndexVBA.set_HotFontBold(true);
		IndexVBA.set_Image((Image)componentResourceManager.GetObject("IndexVBA.Image"));
		IndexVBA.set_ImagePosition((eImagePosition)2);
		((BaseItem)IndexVBA).set_Name("IndexVBA");
		IndexVBA.set_SubItemsExpandWidth(14);
		((BaseItem)IndexVBA).set_Tag((object)"xn8");
		IndexVBA.set_Text("生成索引 文件(VBA移植)");
		((BaseItem)IndexVBA).set_Visible(false);
		ansysxnbll.set_ButtonStyle((eButtonStyle)2);
		ansysxnbll.set_HotFontBold(true);
		ansysxnbll.set_Image((Image)componentResourceManager.GetObject("ansysxnbll.Image"));
		ansysxnbll.set_ImagePosition((eImagePosition)2);
		((BaseItem)ansysxnbll).set_Name("ansysxnbll");
		ansysxnbll.set_SubItemsExpandWidth(14);
		((BaseItem)ansysxnbll).set_Tag((object)"xn3");
		ansysxnbll.set_Text("ANSYS11.0 性能表浏览器");
		((BaseItem)ansysxnbll).set_Visible(false);
		ansysxnzj.set_ButtonStyle((eButtonStyle)2);
		ansysxnzj.set_HotFontBold(true);
		ansysxnzj.set_Image((Image)componentResourceManager.GetObject("ansysxnzj.Image"));
		ansysxnzj.set_ImagePosition((eImagePosition)2);
		((BaseItem)ansysxnzj).set_Name("ansysxnzj");
		ansysxnzj.set_SubItemsExpandWidth(14);
		((BaseItem)ansysxnzj).set_Tag((object)"xn4");
		ansysxnzj.set_Text("ANSYS11.0 性能表信息追加");
		((BaseItem)ansysxnzj).set_Visible(false);
		ansysxnbmcgff.set_ButtonStyle((eButtonStyle)2);
		ansysxnbmcgff.set_HotFontBold(true);
		ansysxnbmcgff.set_Image((Image)componentResourceManager.GetObject("ansysxnbmcgff.Image"));
		ansysxnbmcgff.set_ImagePosition((eImagePosition)2);
		((BaseItem)ansysxnbmcgff).set_Name("ansysxnbmcgff");
		ansysxnbmcgff.set_SubItemsExpandWidth(14);
		ansysxnbmcgff.set_Text("ANSYS11.0 性能表名称规范");
		ansystoword.set_ButtonStyle((eButtonStyle)2);
		ansystoword.set_HotFontBold(true);
		ansystoword.set_Image((Image)componentResourceManager.GetObject("ansystoword.Image"));
		ansystoword.set_ImagePosition((eImagePosition)2);
		((BaseItem)ansystoword).set_Name("ansystoword");
		ansystoword.set_SubItemsExpandWidth(14);
		((BaseItem)ansystoword).set_Tag((object)"xn5");
		ansystoword.set_Text("ANSYS11.0 性能表toWord");
		((BaseItem)ansystoword).set_Visible(false);
		Jss.set_ButtonStyle((eButtonStyle)2);
		Jss.set_HotFontBold(true);
		Jss.set_Image((Image)componentResourceManager.GetObject("Jss.Image"));
		Jss.set_ImagePosition((eImagePosition)2);
		((BaseItem)Jss).set_Name("Jss");
		Jss.set_SubItemsExpandWidth(14);
		((BaseItem)Jss).set_Tag((object)"xn6");
		Jss.set_Text("计算报告 生成");
		((BaseItem)Jss).set_Visible(false);
		((PanelControl)RibbonPanel1).set_ColorSchemeStyle((eDotNetBarStyle)7);
		((Control)RibbonPanel1).get_Controls().Add((Control)(object)RibbonBar1);
		RibbonPanel1.set_Dock((DockStyle)5);
		RibbonPanel ribbonPanel4 = RibbonPanel1;
		location = new Point(0, 26);
		ribbonPanel4.set_Location(location);
		((Control)RibbonPanel1).set_Name("RibbonPanel1");
		RibbonPanel ribbonPanel5 = RibbonPanel1;
		((Padding)(ref padding))._002Ector(3, 0, 3, 3);
		((Control)ribbonPanel5).set_Padding(padding);
		RibbonPanel ribbonPanel6 = RibbonPanel1;
		size = new Size(916, 89);
		ribbonPanel6.set_Size(size);
		((PanelControl)RibbonPanel1).get_Style().set_Class("");
		((PanelControl)RibbonPanel1).get_Style().set_CornerType((eCornerType)1);
		((PanelControl)RibbonPanel1).get_StyleMouseDown().set_Class("");
		((PanelControl)RibbonPanel1).get_StyleMouseDown().set_CornerType((eCornerType)1);
		((PanelControl)RibbonPanel1).get_StyleMouseOver().set_Class("");
		((PanelControl)RibbonPanel1).get_StyleMouseOver().set_CornerType((eCornerType)1);
		((Control)RibbonPanel1).set_TabIndex(1);
		RibbonPanel1.set_Visible(false);
		RibbonBar1.set_AutoOverflowEnabled(true);
		RibbonBar1.get_BackgroundMouseOverStyle().set_Class("");
		RibbonBar1.get_BackgroundMouseOverStyle().set_CornerType((eCornerType)1);
		((ItemControl)RibbonBar1).get_BackgroundStyle().set_Class("");
		((ItemControl)RibbonBar1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((ItemControl)RibbonBar1).set_ContainerControlProcessDialogKey(true);
		((Control)RibbonBar1).set_Dock((DockStyle)3);
		((Control)RibbonBar1).set_ImeMode((ImeMode)1);
		RibbonBar1.get_Items().AddRange((BaseItem[])(object)new BaseItem[5]
		{
			(BaseItem)ToolsOpen,
			(BaseItem)ToolsInput,
			(BaseItem)Toolsfxxd,
			(BaseItem)ToolsSave,
			(BaseItem)ToolsExit
		});
		RibbonBar ribbonBar3 = RibbonBar1;
		location = new Point(3, 0);
		((Control)ribbonBar3).set_Location(location);
		((Control)RibbonBar1).set_Name("RibbonBar1");
		RibbonBar ribbonBar4 = RibbonBar1;
		size = new Size(434, 86);
		((Control)ribbonBar4).set_Size(size);
		RibbonBar1.set_Style((eDotNetBarStyle)7);
		((Control)RibbonBar1).set_TabIndex(0);
		((Control)RibbonBar1).set_Text("打开参数文件");
		RibbonBar1.get_TitleStyle().set_Class("");
		RibbonBar1.get_TitleStyle().set_CornerType((eCornerType)1);
		RibbonBar1.get_TitleStyleMouseOver().set_Class("");
		RibbonBar1.get_TitleStyleMouseOver().set_CornerType((eCornerType)1);
		RibbonBar1.set_TitleVisible(false);
		ToolsOpen.set_ButtonStyle((eButtonStyle)2);
		ToolsOpen.set_HotFontBold(true);
		ToolsOpen.set_Image((Image)componentResourceManager.GetObject("ToolsOpen.Image"));
		ToolsOpen.set_ImagePosition((eImagePosition)2);
		((BaseItem)ToolsOpen).set_Name("ToolsOpen");
		ToolsOpen.set_SubItemsExpandWidth(14);
		ToolsOpen.set_Text("打开");
		ToolsInput.set_ButtonStyle((eButtonStyle)2);
		((BaseItem)ToolsInput).set_Enabled(false);
		ToolsInput.set_HotFontBold(true);
		ToolsInput.set_Image((Image)componentResourceManager.GetObject("ToolsInput.Image"));
		ToolsInput.set_ImagePosition((eImagePosition)2);
		((BaseItem)ToolsInput).set_Name("ToolsInput");
		ToolsInput.set_SubItemsExpandWidth(14);
		ToolsInput.set_Text("编辑");
		Toolsfxxd.set_ButtonStyle((eButtonStyle)2);
		((BaseItem)Toolsfxxd).set_Enabled(false);
		Toolsfxxd.set_HotFontBold(true);
		Toolsfxxd.set_Image((Image)componentResourceManager.GetObject("Toolsfxxd.Image"));
		Toolsfxxd.set_ImagePosition((eImagePosition)2);
		((BaseItem)Toolsfxxd).set_Name("Toolsfxxd");
		Toolsfxxd.set_SubItemsExpandWidth(14);
		Toolsfxxd.set_Text("分析向导");
		ToolsSave.set_ButtonStyle((eButtonStyle)2);
		((BaseItem)ToolsSave).set_Enabled(false);
		ToolsSave.set_HotFontBold(true);
		ToolsSave.set_Image((Image)componentResourceManager.GetObject("ToolsSave.Image"));
		ToolsSave.set_ImagePosition((eImagePosition)2);
		((BaseItem)ToolsSave).set_Name("ToolsSave");
		ToolsSave.set_SubItemsExpandWidth(14);
		ToolsSave.set_Text("保存");
		ToolsExit.set_ButtonStyle((eButtonStyle)2);
		ToolsExit.set_HotFontBold(true);
		ToolsExit.set_Image((Image)componentResourceManager.GetObject("ToolsExit.Image"));
		ToolsExit.set_ImageListSizeSelection((eButtonImageListSelection)1);
		ToolsExit.set_ImagePosition((eImagePosition)2);
		((BaseItem)ToolsExit).set_Name("ToolsExit");
		((PopupItem)ToolsExit).set_PopupAnimation((ePopupAnimation)0);
		ToolsExit.set_SubItemsExpandWidth(14);
		ToolsExit.set_Text("退出");
		((PanelControl)RibbonPanel4).set_ColorSchemeStyle((eDotNetBarStyle)7);
		((Control)RibbonPanel4).get_Controls().Add((Control)(object)zdqtk);
		RibbonPanel4.set_Dock((DockStyle)5);
		RibbonPanel ribbonPanel7 = RibbonPanel4;
		location = new Point(0, 26);
		ribbonPanel7.set_Location(location);
		((Control)RibbonPanel4).set_Name("RibbonPanel4");
		RibbonPanel ribbonPanel8 = RibbonPanel4;
		((Padding)(ref padding))._002Ector(3, 0, 3, 3);
		((Control)ribbonPanel8).set_Padding(padding);
		RibbonPanel ribbonPanel9 = RibbonPanel4;
		size = new Size(916, 62);
		ribbonPanel9.set_Size(size);
		((PanelControl)RibbonPanel4).get_Style().set_Class("");
		((PanelControl)RibbonPanel4).get_Style().set_CornerType((eCornerType)1);
		((PanelControl)RibbonPanel4).get_StyleMouseDown().set_Class("");
		((PanelControl)RibbonPanel4).get_StyleMouseDown().set_CornerType((eCornerType)1);
		((PanelControl)RibbonPanel4).get_StyleMouseOver().set_Class("");
		((PanelControl)RibbonPanel4).get_StyleMouseOver().set_CornerType((eCornerType)1);
		((Control)RibbonPanel4).set_TabIndex(4);
		RibbonPanel4.set_Visible(false);
		zdqtk.set_AutoOverflowEnabled(true);
		zdqtk.get_BackgroundMouseOverStyle().set_Class("");
		zdqtk.get_BackgroundMouseOverStyle().set_CornerType((eCornerType)1);
		((ItemControl)zdqtk).get_BackgroundStyle().set_Class("");
		((ItemControl)zdqtk).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((ItemControl)zdqtk).set_ContainerControlProcessDialogKey(true);
		((Control)zdqtk).set_Dock((DockStyle)3);
		zdqtk.get_Items().AddRange((BaseItem[])(object)new BaseItem[4]
		{
			(BaseItem)bdmr,
			(BaseItem)zdqtmxk,
			(BaseItem)ckdqk,
			(BaseItem)gldqk
		});
		RibbonBar obj = zdqtk;
		location = new Point(3, 0);
		((Control)obj).set_Location(location);
		((Control)zdqtk).set_Name("zdqtk");
		RibbonBar obj2 = zdqtk;
		size = new Size(483, 59);
		((Control)obj2).set_Size(size);
		zdqtk.set_Style((eDotNetBarStyle)7);
		((Control)zdqtk).set_TabIndex(0);
		((Control)zdqtk).set_Text("RibbonBar2");
		zdqtk.get_TitleStyle().set_Class("");
		zdqtk.get_TitleStyle().set_CornerType((eCornerType)1);
		zdqtk.get_TitleStyleMouseOver().set_Class("");
		zdqtk.get_TitleStyleMouseOver().set_CornerType((eCornerType)1);
		zdqtk.set_TitleVisible(false);
		bdmr.set_ButtonStyle((eButtonStyle)2);
		bdmr.set_HotFontBold(true);
		bdmr.set_Image((Image)componentResourceManager.GetObject("bdmr.Image"));
		bdmr.set_ImagePosition((eImagePosition)2);
		((BaseItem)bdmr).set_Name("bdmr");
		bdmr.set_SubItemsExpandWidth(14);
		bdmr.set_Text("默认");
		zdqtmxk.set_ButtonStyle((eButtonStyle)2);
		zdqtmxk.set_HotFontBold(true);
		zdqtmxk.set_Image((Image)componentResourceManager.GetObject("zdqtmxk.Image"));
		zdqtmxk.set_ImagePosition((eImagePosition)2);
		((BaseItem)zdqtmxk).set_Name("zdqtmxk");
		zdqtmxk.set_SubItemsExpandWidth(14);
		zdqtmxk.set_Text("指定");
		ckdqk.set_ButtonStyle((eButtonStyle)2);
		ckdqk.set_HotFontBold(true);
		ckdqk.set_Image((Image)componentResourceManager.GetObject("ckdqk.Image"));
		ckdqk.set_ImagePosition((eImagePosition)2);
		((BaseItem)ckdqk).set_Name("ckdqk");
		ckdqk.set_SubItemsExpandWidth(14);
		ckdqk.set_Text("查看");
		gldqk.set_ButtonStyle((eButtonStyle)2);
		gldqk.set_HotFontBold(true);
		gldqk.set_Image((Image)componentResourceManager.GetObject("gldqk.Image"));
		gldqk.set_ImagePosition((eImagePosition)2);
		((BaseItem)gldqk).set_Name("gldqk");
		gldqk.set_SubItemsExpandWidth(14);
		gldqk.set_Text("管理");
		((PanelControl)RibbonPanel3).set_ColorSchemeStyle((eDotNetBarStyle)7);
		((Control)RibbonPanel3).get_Controls().Add((Control)(object)RibbonBar3);
		RibbonPanel3.set_Dock((DockStyle)5);
		RibbonPanel ribbonPanel10 = RibbonPanel3;
		location = new Point(0, 26);
		ribbonPanel10.set_Location(location);
		((Control)RibbonPanel3).set_Name("RibbonPanel3");
		RibbonPanel ribbonPanel11 = RibbonPanel3;
		((Padding)(ref padding))._002Ector(3, 0, 3, 3);
		((Control)ribbonPanel11).set_Padding(padding);
		RibbonPanel ribbonPanel12 = RibbonPanel3;
		size = new Size(916, 62);
		ribbonPanel12.set_Size(size);
		((PanelControl)RibbonPanel3).get_Style().set_Class("");
		((PanelControl)RibbonPanel3).get_Style().set_CornerType((eCornerType)1);
		((PanelControl)RibbonPanel3).get_StyleMouseDown().set_Class("");
		((PanelControl)RibbonPanel3).get_StyleMouseDown().set_CornerType((eCornerType)1);
		((PanelControl)RibbonPanel3).get_StyleMouseOver().set_Class("");
		((PanelControl)RibbonPanel3).get_StyleMouseOver().set_CornerType((eCornerType)1);
		((Control)RibbonPanel3).set_TabIndex(5);
		RibbonPanel3.set_Visible(false);
		RibbonBar3.set_AutoOverflowEnabled(true);
		RibbonBar3.get_BackgroundMouseOverStyle().set_Class("");
		RibbonBar3.get_BackgroundMouseOverStyle().set_CornerType((eCornerType)1);
		((ItemControl)RibbonBar3).get_BackgroundStyle().set_Class("");
		((ItemControl)RibbonBar3).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((ItemControl)RibbonBar3).set_ContainerControlProcessDialogKey(true);
		((Control)RibbonBar3).set_Dock((DockStyle)3);
		RibbonBar3.get_Items().AddRange((BaseItem[])(object)new BaseItem[4]
		{
			(BaseItem)help1,
			(BaseItem)help2,
			(BaseItem)help3,
			(BaseItem)help4
		});
		RibbonBar ribbonBar5 = RibbonBar3;
		location = new Point(3, 0);
		((Control)ribbonBar5).set_Location(location);
		((Control)RibbonBar3).set_Name("RibbonBar3");
		RibbonBar ribbonBar6 = RibbonBar3;
		size = new Size(910, 59);
		((Control)ribbonBar6).set_Size(size);
		RibbonBar3.set_Style((eDotNetBarStyle)7);
		((Control)RibbonBar3).set_TabIndex(1);
		((Control)RibbonBar3).set_Text("RibbonBar2");
		RibbonBar3.get_TitleStyle().set_Class("");
		RibbonBar3.get_TitleStyle().set_CornerType((eCornerType)1);
		RibbonBar3.get_TitleStyleMouseOver().set_Class("");
		RibbonBar3.get_TitleStyleMouseOver().set_CornerType((eCornerType)1);
		RibbonBar3.set_TitleVisible(false);
		help1.set_ButtonStyle((eButtonStyle)2);
		help1.set_HotFontBold(true);
		help1.set_Image((Image)componentResourceManager.GetObject("help1.Image"));
		help1.set_ImagePosition((eImagePosition)2);
		((BaseItem)help1).set_Name("help1");
		help1.set_SubItemsExpandWidth(14);
		help1.set_Text("系统简介");
		help2.set_ButtonStyle((eButtonStyle)2);
		help2.set_HotFontBold(true);
		help2.set_Image((Image)componentResourceManager.GetObject("help2.Image"));
		help2.set_ImagePosition((eImagePosition)2);
		((BaseItem)help2).set_Name("help2");
		help2.set_SubItemsExpandWidth(14);
		help2.set_Text("安装说明");
		((BaseItem)help2).set_Visible(false);
		help3.set_ButtonStyle((eButtonStyle)2);
		help3.set_HotFontBold(true);
		help3.set_Image((Image)componentResourceManager.GetObject("help3.Image"));
		help3.set_ImagePosition((eImagePosition)2);
		((BaseItem)help3).set_Name("help3");
		help3.set_SubItemsExpandWidth(14);
		help3.set_Text("使用说明");
		help4.set_ButtonStyle((eButtonStyle)2);
		help4.set_HotFontBold(true);
		help4.set_Image((Image)componentResourceManager.GetObject("help4.Image"));
		help4.set_ImagePosition((eImagePosition)2);
		((BaseItem)help4).set_Name("help4");
		help4.set_SubItemsExpandWidth(14);
		help4.set_Text("开发说明");
		((BaseItem)RibbonTabItem1).set_Name("RibbonTabItem1");
		RibbonTabItem1.set_Panel(RibbonPanel1);
		((ButtonItem)RibbonTabItem1).set_Text("参数文件");
		RibbonTabItem2.set_Checked(true);
		((BaseItem)RibbonTabItem2).set_Name("RibbonTabItem2");
		RibbonTabItem2.set_Panel(RibbonPanel2);
		((ButtonItem)RibbonTabItem2).set_Text("高级处理");
		((BaseItem)RibbonTabItem4).set_Name("RibbonTabItem4");
		RibbonTabItem4.set_Panel(RibbonPanel4);
		((ButtonItem)RibbonTabItem4).set_Text("模型库");
		((BaseItem)RibbonTabItem3).set_Name("RibbonTabItem3");
		RibbonTabItem3.set_Panel(RibbonPanel3);
		((ButtonItem)RibbonTabItem3).set_Text("帮助");
		((BaseItem)ButtonItem1).set_Name("ButtonItem1");
		ButtonItem1.set_Text("ButtonItem1");
		((BaseItem)QatCustomizeItem1).set_Name("QatCustomizeItem1");
		((BaseItemControl)lbx).get_BackgroundStyle().set_Class("");
		((BaseItemControl)lbx).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)lbx).set_Dock((DockStyle)2);
		((Control)lbx).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX obj3 = lbx;
		location = new Point(0, 646);
		((Control)obj3).set_Location(location);
		((Control)lbx).set_Name("lbx");
		LabelX obj4 = lbx;
		size = new Size(1028, 14);
		((Control)obj4).set_Size(size);
		((Control)lbx).set_TabIndex(2);
		ButtonItem4.set_ButtonStyle((eButtonStyle)2);
		ButtonItem4.set_HotFontBold(true);
		ButtonItem4.set_Image((Image)componentResourceManager.GetObject("ButtonItem4.Image"));
		ButtonItem4.set_ImagePosition((eImagePosition)2);
		((BaseItem)ButtonItem4).set_Name("ButtonItem4");
		((PopupItem)ButtonItem4).set_PersonalizedMenus((ePersonalizedMenus)2);
		ButtonItem4.set_SubItemsExpandWidth(14);
		ButtonItem4.set_Text("ANSYS11.0臂头曲线自动生成");
		((Control)lslog).set_Dock((DockStyle)2);
		lslog.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		lslog.set_ItemHeight(12);
		ListBox obj5 = lslog;
		location = new Point(0, 90);
		((Control)obj5).set_Location(location);
		((Control)lslog).set_Name("lslog");
		ListBox obj6 = lslog;
		size = new Size(1028, 556);
		((Control)obj6).set_Size(size);
		((Control)lslog).set_TabIndex(1);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Office2007Form)this).set_CaptionFont(new Font("Arial", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		size = new Size(1028, 660);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)lslog);
		((Control)this).get_Controls().Add((Control)(object)lbx);
		((Control)this).get_Controls().Add((Control)(object)RCT1);
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Control)this).set_Name("Main");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Office2007RibbonForm)this).set_WindowState((FormWindowState)2);
		RCT1.ResumeLayout(false);
		((Control)RCT1).PerformLayout();
		((Control)RibbonPanel2).ResumeLayout(false);
		((Control)RibbonPanel1).ResumeLayout(false);
		((Control)RibbonPanel4).ResumeLayout(false);
		((Control)RibbonPanel3).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Main_FormClosed(object sender, FormClosedEventArgs e)
	{
		try
		{
			if (!bj1)
			{
				lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员退出QYX模型库管理系统"));
				Mod1.Writerlog();
			}
			Mod1.tuichu();
			if (Mod1.asyncConnection != null && Mod1.asyncConnection.IsRunning())
			{
				Mod1.asyncConnection.Disconnect(1);
				Mod1.asyncConnection = null;
			}
			Application.Exit();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void ToolsOpen_Click(object sender, EventArgs e)
	{
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		if (arr.Count == 0)
		{
			Mod1.lr = new StreamReader(Mod1.Kulujing + "mlibs.lis", Encoding.Default);
			Mod1.ff = "";
			while (!Information.IsNothing((object)Mod1.ff))
			{
				Mod1.ff = Mod1.lr.ReadLine();
				if (Information.IsNothing((object)Mod1.ff))
				{
					break;
				}
				arr.Add(Mod1.ff);
			}
			Mod1.lr.Close();
			Mod1.lr.Dispose();
			if (arr.Count == 0)
			{
				Interaction.MsgBox((object)"当前模型库中部件为空，请在管理模板库中追加部件或更换模型库！", (MsgBoxStyle)48, (object)"警告");
			}
			else
			{
				((Form)MyProject.Forms.FrmOf).ShowDialog();
			}
		}
		else
		{
			((Form)MyProject.Forms.FrmOf).ShowDialog();
		}
	}

	private void ToolsInput_Click(object sender, EventArgs e)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(Strings.Trim(Mod1.pathh), "", false) != 0)
		{
			if (Operators.CompareString(MyProject.Forms.FrmOf.qyx, "qyxxn", false) == 0)
			{
				((Form)MyProject.Forms.xn).ShowDialog();
				((Component)(object)MyProject.Forms.xn).Dispose();
			}
			else
			{
				lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员打开了录入参数对话框"));
				((Form)MyProject.Forms.cslr2).ShowDialog();
			}
		}
	}

	private void ToolsExit_Click(object sender, EventArgs e)
	{
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			bj1 = true;
			lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员退出QYX模型库管理系统"));
			Mod1.tuichu();
			Mod1.Writerlog();
			if (Mod1.asyncConnection != null && Mod1.asyncConnection.IsRunning())
			{
				Mod1.asyncConnection.Disconnect(1);
			}
			if (Mod1.excelapp != null)
			{
				Mod1.excelapp = null;
			}
			Application.Exit();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)(ex2.Message.ToString() + "\r" + ex2.StackTrace!.ToString()), (MsgBoxStyle)64, (object)"提示");
			if (Mod1.excelapp != null)
			{
				Mod1.excelapp = null;
			}
			Application.Exit();
			ProjectData.ClearProjectError();
		}
	}

	private void ToolsSave_Click(object sender, EventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(MyProject.Forms.FrmOf.qyx, "qyxxn", false) == 0)
		{
			((Form)MyProject.Forms.Save).ShowDialog();
			return;
		}
		((Control)MyProject.Forms.Save.GP1).set_Enabled(false);
		((Form)MyProject.Forms.Save).ShowDialog();
	}

	private void Main_Load(object sender, EventArgs e)
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Guid clsid = new Guid("00024500-0000-0000-C000-000000000046");
			Mod1.excelapp = (Application)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
			Mod1.excelapp.DisplayAlerts = false;
			RibbonTabItem1.Select();
			string path = Application.get_StartupPath() + "\\Temp\\";
			if (!File.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			if (!File.Exists(Application.get_StartupPath() + "\\config\\模型库路径.ini"))
			{
				Mod1.Kulujing = Directory.GetParent(Application.get_StartupPath())!.ToString() + "\\mlibs\\";
				if (Mod1.Kulujing.IndexOf(" ") != -1)
				{
					Interaction.MsgBox((object)"当前程序运行的路径中带有空格，请更换程序路径！", (MsgBoxStyle)64, (object)"提示");
					return;
				}
				xielujing();
			}
			Mod1.lr = new StreamReader(Application.get_StartupPath() + "\\config\\模型库路径.ini", Encoding.Default);
			Mod1.Kulujing = Mod1.lr.ReadLine();
			Mod1.lr.Close();
			Mod1.lr.Dispose();
			if (Operators.CompareString(Mod1.Kulujing, Directory.GetParent(Application.get_StartupPath())!.ToString() + "\\mlibs\\", false) == 0)
			{
				((BaseItem)bdmr).set_Enabled(false);
			}
			else
			{
				((BaseItem)bdmr).set_Enabled(true);
			}
			if (Operators.CompareString(Strings.Right(Mod1.Kulujing, 1), "\\", false) != 0)
			{
				Mod1.Kulujing += "\\";
			}
			Main_Resize(RuntimeHelpers.GetObjectValue(sender), e);
			if (!File.Exists(Mod1.Kulujing + "mlibs.lis"))
			{
				Interaction.MsgBox((object)"没有找到有效的模型库，程序会自动使用默认模型库位置！！", (MsgBoxStyle)64, (object)"提示");
				Mod1.Kulujing = Directory.GetParent(Application.get_StartupPath())!.ToString() + "\\mlibs\\";
				if (!File.Exists(Mod1.Kulujing + "mlibs.lis"))
				{
					Interaction.MsgBox((object)"程序没有找到默认模型库，请指定一个新位置！", (MsgBoxStyle)64, (object)"提示");
					((BaseItem)ToolsOpen).set_Enabled(false);
					Mod1.Kulujing = "";
					Klujing();
					return;
				}
				xielujing();
			}
			else
			{
				int num = Strings.Len(Mod1.Kulujing);
				for (int i = 1; i <= num; i = checked(i + 1))
				{
					string text = Conversion.Hex(Strings.Asc(Strings.Mid(Mod1.Kulujing, i, 1)));
					if (!((Strings.Asc(Strings.Left(text, 1)) >= 66) & (Strings.Asc(Strings.Left(text, 1)) <= 70)))
					{
						((BaseItem)ToolsOpen).set_Enabled(true);
						if (Mod1.Kulujing.IndexOf(" ") == -1)
						{
							((BaseItem)ToolsOpen).set_Enabled(true);
							continue;
						}
						Interaction.MsgBox((object)"路径或目标文件夹中不能包含空格，请重新指定！！", (MsgBoxStyle)64, (object)"路径错误");
						((BaseItem)ToolsOpen).set_Enabled(false);
						Klujing();
						return;
					}
					Interaction.MsgBox((object)"路径或目标文件夹中不能包含有中文，请重新指定！！", (MsgBoxStyle)64, (object)"路径错误");
					((BaseItem)ToolsOpen).set_Enabled(false);
					Klujing();
					return;
				}
			}
			lslog.get_Items().Add((object)("当前库位置;" + Mod1.Kulujing));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)(ex2.Message.ToString() + "\r" + ex2.StackTrace!.ToString()), (MsgBoxStyle)64, (object)"提示");
			ProjectData.ClearProjectError();
		}
	}

	private void Toolsfxxd_Click(object sender, EventArgs e)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员打开了分析向导"));
		if (!MyProject.Forms.cslr2.bcscheckok)
		{
			Interaction.MsgBox((object)"当前参数校验没有通过, 不能继续.", (MsgBoxStyle)64, (object)"提示");
			return;
		}
		((Form)MyProject.Forms.clxd).ShowDialog();
		((Component)(object)MyProject.Forms.clxd).Dispose();
	}

	private void lslog_DoubleClick(object sender, EventArgs e)
	{
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		string text = lslog.get_Text();
		if (lslog.get_Text().IndexOf(";") != -1)
		{
			string[] array = lslog.get_Text().Split(new char[1] { ';' });
			text = array[1];
		}
		try
		{
			if (File.Exists(text))
			{
				string[] array2 = text.Split(new char[1] { '.' });
				string text2 = array2[checked(array2.Count() - 1)];
				switch (text2.ToLower())
				{
				case "doc":
				case "xls":
				case "csv":
					Process.Start(text);
					break;
				case "txt":
				case "out":
				case "inf":
				case "ini":
				case "ans":
				case "lis":
				case "mac":
				case "log":
				case "vbs":
				case "var":
				case "sect":
					Process.Start(Interaction.Environ("windir") + "\\NOTEPAD.EXE", text);
					break;
				}
			}
			else if (Directory.Exists(text))
			{
				Process.Start(text);
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

	private void bdmr_Click(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and I4
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if ((int)MessageBox.Show("是否恢复默认库路径？", "提示", (MessageBoxButtons)4, (MessageBoxIcon)64) == 6)
		{
			if (!File.Exists(Directory.GetParent(Application.get_StartupPath())!.ToString() + "\\mlibs\\mlibs.lis"))
			{
				Interaction.MsgBox((object)"由于程序找不到有效的默认库文件，恢复失败！！！", (MsgBoxStyle)64, (object)"失败");
				((BaseItem)bdmr).set_Enabled(false);
				return;
			}
			Mod1.Kulujing = Directory.GetParent(Application.get_StartupPath())!.ToString() + "\\mlibs\\";
			Interaction.MsgBox((object)"模型库已恢复为默认路径", (MsgBoxStyle)64, (object)"提示");
			xielujing();
			lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员已将模型库恢复为默认路径"));
			((BaseItem)bdmr).set_Enabled(false);
		}
	}

	private void zdqtmxk_Click(object sender, EventArgs e)
	{
		Klujing();
	}

	private void ckdqk_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(Mod1.Kulujing, "", false) != 0)
		{
			Process.Start(Mod1.Kulujing);
		}
	}

	public void Klujing()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		FolderBrowserDialog val = new FolderBrowserDialog();
		val.set_Description("选择模型库文件夹");
		((CommonDialog)val).ShowDialog();
		if (Operators.CompareString(val.get_SelectedPath(), "", false) == 0)
		{
			return;
		}
		if (Operators.CompareString(Strings.Right(val.get_SelectedPath(), 1), "\\", false) != 0)
		{
			val.set_SelectedPath(val.get_SelectedPath() + "\\");
		}
		if (Operators.CompareString(val.get_SelectedPath(), Mod1.Kulujing, false) == 0)
		{
			Interaction.MsgBox((object)"当前模型库位置没有改变", (MsgBoxStyle)64, (object)"提示");
			return;
		}
		int num = Strings.Len(val.get_SelectedPath());
		int num2 = 1;
		while (true)
		{
			if (num2 <= num)
			{
				string text = Conversion.Hex(Strings.Asc(Strings.Mid(val.get_SelectedPath(), num2, 1)));
				if (!((Strings.Asc(Strings.Left(text, 1)) >= 66) & (Strings.Asc(Strings.Left(text, 1)) <= 70)))
				{
					((BaseItem)ToolsOpen).set_Enabled(true);
					if (val.get_SelectedPath().IndexOf(" ") != -1)
					{
						break;
					}
					num2 = checked(num2 + 1);
					continue;
				}
				((BaseItem)ToolsOpen).set_Enabled(false);
				Interaction.MsgBox((object)"路径或目标文件夹中不能包含有中文！！", (MsgBoxStyle)64, (object)"路径错误");
				Klujing();
				return;
			}
			if (File.Exists(val.get_SelectedPath() + "\\mlibs.lis"))
			{
				Mod1.Kulujing = val.get_SelectedPath();
				lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员已将模型库更改为：" + Mod1.Kulujing));
				Interaction.MsgBox((object)("指定模型库成功，当前模型库路径为：" + Mod1.Kulujing), (MsgBoxStyle)64, (object)"提示");
				xielujing();
				((Component)(object)MyProject.Forms.FrmOf).Dispose();
			}
			else
			{
				((BaseItem)ToolsOpen).set_Enabled(false);
				Interaction.MsgBox((object)"当前指定的位置无效，请重新指定！！", (MsgBoxStyle)64, (object)"失败");
				Klujing();
			}
			if (Operators.CompareString(Mod1.Kulujing, Directory.GetParent(Application.get_StartupPath())!.ToString() + "\\mlibs\\", false) == 0)
			{
				((BaseItem)bdmr).set_Enabled(false);
			}
			else
			{
				((BaseItem)bdmr).set_Enabled(true);
			}
			return;
		}
		((BaseItem)ToolsOpen).set_Enabled(false);
		Interaction.MsgBox((object)"路径或目标文件夹中不能包含空格！！", (MsgBoxStyle)64, (object)"路径错误");
		Klujing();
	}

	public void xielujing()
	{
		Mod1.wr = new StreamWriter(Application.get_StartupPath() + "\\config\\模型库路径.ini", append: false, Encoding.Default);
		Mod1.wr.WriteLine(Mod1.Kulujing);
		Mod1.wr.Close();
		Mod1.wr.Dispose();
	}

	private void gldqk_Click(object sender, EventArgs e)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员打开了 模型库管理 对话框"));
		((Form)MyProject.Forms.mxkgl).ShowDialog();
	}

	private void proedgkwj_Click(object sender, EventArgs e)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员打开了 PROE 多工况计算文件自动建立 对话框"));
		((Form)MyProject.Forms.Proezdjl).ShowDialog();
		((Component)(object)MyProject.Forms.Proezdjl).Dispose();
		lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员关闭了 PROE 多工况计算文件自动建立 对话框"));
	}

	private void proedgkjs_Click(object sender, EventArgs e)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员打开了 PROE 多工况计算文件自动计算 对话框"));
		((Form)MyProject.Forms.frmproedgkjs).ShowDialog();
		((Component)(object)MyProject.Forms.frmproedgkjs).Dispose();
		lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员关闭了 PROE 多工况计算文件自动计算 对话框"));
	}

	private void proedgkjg_Click(object sender, EventArgs e)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员打开了 PROE 多工况计算结果汇总 对话框"));
		((Form)MyProject.Forms.proejshz).ShowDialog();
		((Component)(object)MyProject.Forms.proejshz).Dispose();
		lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员关闭了 PROE 多工况计算结果汇总 对话框"));
	}

	private void ansysqx_Click(object sender, EventArgs e)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员打开了 ANSYS 臂头曲线自动生成 对话框"));
		((Form)MyProject.Forms.ll_ufbt).ShowDialog();
		((Component)(object)MyProject.Forms.ll_ufbt).Dispose();
		lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员关闭了 ANSYS 臂头曲线自动生成 对话框"));
	}

	private void help1_Click(object sender, EventArgs e)
	{
		string text = Directory.GetParent(Application.get_StartupPath())!.ToString() + "\\help\\系统简介.chm";
		if (File.Exists(text))
		{
			Process.Start(text);
		}
	}

	private void help2_Click(object sender, EventArgs e)
	{
		string text = Directory.GetParent(Application.get_StartupPath())!.ToString() + "\\help\\安装说明.chm";
		if (File.Exists(text))
		{
			Process.Start(text);
		}
	}

	private void help3_Click(object sender, EventArgs e)
	{
		string text = Directory.GetParent(Application.get_StartupPath())!.ToString() + "\\help\\使用说明.chm";
		if (File.Exists(text))
		{
			Process.Start(text);
		}
	}

	private void help4_Click(object sender, EventArgs e)
	{
		string text = Directory.GetParent(Application.get_StartupPath())!.ToString() + "\\help\\开发说明.chm";
		if (File.Exists(text))
		{
			Process.Start(text);
		}
	}

	private void RCT1_ItemClick(object sender, EventArgs e)
	{
		((Control)lslog).set_Height(checked(((Control)this).get_Height() - ((Control)RCT1).get_Height() - ((Control)lbx).get_Height() - hh));
	}

	private void ansysdxxnb_Click(object sender, EventArgs e)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员打开了 ANSYS11.0 单项性能表生成 对话框"));
		((Form)MyProject.Forms.ll_ufxnonly1).ShowDialog();
		((Component)(object)MyProject.Forms.ll_ufxnonly1).Dispose();
		lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员关闭了 ANSYS11.0 单项性能表生成 对话框"));
	}

	private void Main_Resize(object sender, EventArgs e)
	{
		((Control)lslog).set_Height(checked(((Control)this).get_Height() - ((Control)RCT1).get_Height() - ((Control)lbx).get_Height() - hh));
	}

	private void ansysxnbll_Click(object sender, EventArgs e)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员打开了 ANSYS11.0 性能表浏览器 对话框"));
		((Form)MyProject.Forms.ll_ufxnbBrowser).ShowDialog();
	}

	private void ansystoword_Click(object sender, EventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		if (Process.GetProcessesByName("WINWORD").Length > 0)
		{
			Interaction.MsgBox((object)"程序发现有 WORD 进程，为确保数据安全，请自行保存并关闭当前 WORD.", (MsgBoxStyle)64, (object)"提示");
			return;
		}
		lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员打开了 ANSYS11.0 性能表toWord 对话框"));
		((Form)MyProject.Forms.ll_uftoword).ShowDialog();
		((Component)(object)MyProject.Forms.ll_uftoword).Dispose();
		lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员关闭了 ANSYS11.0 性能表toWord 对话框"));
	}

	private void Jss_Click(object sender, EventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		if (Process.GetProcessesByName("WINWORD").Length > 0)
		{
			Interaction.MsgBox((object)"程序发现有 WORD 进程，为确保数据安全，请自行保存并关闭当前 WORD.", (MsgBoxStyle)64, (object)"提示");
			return;
		}
		lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员打开了 生成计算报告 对话框"));
		((Form)MyProject.Forms.jsbaogao).ShowDialog();
		((Component)(object)MyProject.Forms.jsbaogao).Dispose();
		lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员关闭了 生成计算报告 对话框"));
	}

	private void ansysxnzj_Click(object sender, EventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((Form)MyProject.Forms.ll_ufxnbinfoadd).ShowDialog();
		((Component)(object)MyProject.Forms.ll_ufxnbinfoadd).Dispose();
	}

	private void BIindex_Click(object sender, EventArgs e)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员打开了 生成索引 对话框"));
		((Form)MyProject.Forms.CreateINI).ShowDialog();
		((Component)(object)MyProject.Forms.CreateINI).Dispose();
		lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员关闭了 生成索引 对话框"));
	}

	private void ansysxnbmcgff_Click(object sender, EventArgs e)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员打开了 ANSYS11.0 性能表名称规范 对话框"));
		((Form)MyProject.Forms.ll_ufxnbnameformat).ShowDialog();
		((Component)(object)MyProject.Forms.ll_ufxnbnameformat).Dispose();
		lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员关闭了 ANSYS11.0 性能表名称规范 对话框"));
	}

	private void IndexVBA_Click(object sender, EventArgs e)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员打开了 生成索引 文件(VBA移植) 对话框"));
		((Form)MyProject.Forms.ll_ufxnbsearchini).ShowDialog();
		((Component)(object)MyProject.Forms.ll_ufxnbsearchini).Dispose();
		lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员关闭了 生成索引 文件(VBA移植) 对话框"));
	}
}
