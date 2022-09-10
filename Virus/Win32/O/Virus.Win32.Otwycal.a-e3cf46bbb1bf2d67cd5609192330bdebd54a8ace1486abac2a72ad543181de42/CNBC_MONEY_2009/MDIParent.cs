using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using CNBC.DAL;
using CNBC_MONEY_2009.My;
using CNBC_MONEY_2009.My.Resources;
using Dart.PowerTCP.Sockets;
using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinStatusBar;
using Infragistics.Win.UltraWinTabbedMdi;
using Infragistics.Win.UltraWinToolbars;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CNBC_MONEY_2009;

[DesignerGenerated]
public class MDIParent : Form
{
	private delegate void Delg_CrunchMDIData(string str);

	private delegate void Delg_CrunchEquityData(string str);

	public delegate void ChangeText(string strGroup, string strTool, string theTextString);

	public delegate void ChangeStatus(string theTextString, bool Enabled_Disabled);

	public delegate void ChangeProcess(bool Enabled_Disabled);

	public delegate void ChangeStatusText(string theTextString);

	public delegate void ChangeProcessText(string theTextString);

	public delegate void ChangeFavouriteText(Label lbl, string theTextString);

	public delegate void Equity_Method(string str);

	private static ArrayList __ENCList = new ArrayList();

	private IContainer components;

	[AccessedThroughProperty("ToolTip")]
	private ToolTip _ToolTip;

	[AccessedThroughProperty("_MDI_Toolbars_Dock_Area_Left")]
	private UltraToolbarsDockArea __MDI_Toolbars_Dock_Area_Left;

	[AccessedThroughProperty("ToolbarsManager")]
	private UltraToolbarsManager _ToolbarsManager;

	[AccessedThroughProperty("_MDI_Toolbars_Dock_Area_Right")]
	private UltraToolbarsDockArea __MDI_Toolbars_Dock_Area_Right;

	[AccessedThroughProperty("_MDI_Toolbars_Dock_Area_Top")]
	private UltraToolbarsDockArea __MDI_Toolbars_Dock_Area_Top;

	[AccessedThroughProperty("_MDI_Toolbars_Dock_Area_Bottom")]
	private UltraToolbarsDockArea __MDI_Toolbars_Dock_Area_Bottom;

	[AccessedThroughProperty("UltraStatusBar1")]
	private UltraStatusBar _UltraStatusBar1;

	[AccessedThroughProperty("UltraToolbarsManager2")]
	private UltraToolbarsManager _UltraToolbarsManager2;

	[AccessedThroughProperty("ContextMenuStrip1")]
	private ContextMenuStrip _ContextMenuStrip1;

	[AccessedThroughProperty("AddToFavouritesToolStripMenuItem")]
	private ToolStripMenuItem _AddToFavouritesToolStripMenuItem;

	[AccessedThroughProperty("UltraGroupBox1")]
	private UltraGroupBox _UltraGroupBox1;

	[AccessedThroughProperty("grFavourite5")]
	private UltraGroupBox _grFavourite5;

	[AccessedThroughProperty("grFavourite4")]
	private UltraGroupBox _grFavourite4;

	[AccessedThroughProperty("grFavourite3")]
	private UltraGroupBox _grFavourite3;

	[AccessedThroughProperty("grFavourite2")]
	private UltraGroupBox _grFavourite2;

	[AccessedThroughProperty("grFavourite1")]
	private UltraGroupBox _grFavourite1;

	[AccessedThroughProperty("PowerUDP")]
	private Udp _PowerUDP;

	[AccessedThroughProperty("UltraTabbedMdiManager1")]
	private UltraTabbedMdiManager _UltraTabbedMdiManager1;

	[AccessedThroughProperty("lbl_LP1")]
	private Label _lbl_LP1;

	[AccessedThroughProperty("lbl_PC1")]
	private Label _lbl_PC1;

	[AccessedThroughProperty("lbl_C1")]
	private Label _lbl_C1;

	[AccessedThroughProperty("lbl_PC5")]
	private Label _lbl_PC5;

	[AccessedThroughProperty("lbl_C5")]
	private Label _lbl_C5;

	[AccessedThroughProperty("lbl_LP5")]
	private Label _lbl_LP5;

	[AccessedThroughProperty("lbl_PC4")]
	private Label _lbl_PC4;

	[AccessedThroughProperty("lbl_C4")]
	private Label _lbl_C4;

	[AccessedThroughProperty("lbl_LP4")]
	private Label _lbl_LP4;

	[AccessedThroughProperty("lbl_PC3")]
	private Label _lbl_PC3;

	[AccessedThroughProperty("lbl_C3")]
	private Label _lbl_C3;

	[AccessedThroughProperty("lbl_LP3")]
	private Label _lbl_LP3;

	[AccessedThroughProperty("lbl_PC2")]
	private Label _lbl_PC2;

	[AccessedThroughProperty("lbl_C2")]
	private Label _lbl_C2;

	[AccessedThroughProperty("lbl_LP2")]
	private Label _lbl_LP2;

	[AccessedThroughProperty("lbl_CL5")]
	private Label _lbl_CL5;

	[AccessedThroughProperty("lbl_CL4")]
	private Label _lbl_CL4;

	[AccessedThroughProperty("lbl_CL3")]
	private Label _lbl_CL3;

	[AccessedThroughProperty("lbl_CL2")]
	private Label _lbl_CL2;

	[AccessedThroughProperty("lbl_CL1")]
	private Label _lbl_CL1;

	[AccessedThroughProperty("tmr_Streaming")]
	private Timer _tmr_Streaming;

	[AccessedThroughProperty("ContextMenuStrip2")]
	private ContextMenuStrip _ContextMenuStrip2;

	[AccessedThroughProperty("ShowDataToolStripMenuItem")]
	private ToolStripMenuItem _ShowDataToolStripMenuItem;

	private int m_ChildFormNumber;

	private string strSQL;

	private DataTable dt;

	private int i;

	private clsEquity objEquity;

	private DateTime dateTime_Streaming;

	private double NiftyLast;

	private double SensexLast;

	private double MIDCAPLast;

	private int ro;

	[AccessedThroughProperty("fEquity1")]
	private frmEquity _fEquity1;

	[AccessedThroughProperty("fEquity2")]
	private frmEquity _fEquity2;

	[AccessedThroughProperty("fEquity3")]
	private frmEquity _fEquity3;

	[AccessedThroughProperty("fEquity4")]
	private frmEquity _fEquity4;

	[AccessedThroughProperty("fEquity5")]
	private frmEquity _fEquity5;

	private frmFutures fFutures;

	private frmOptions fOptions;

	[AccessedThroughProperty("fFavourites")]
	private frmFavourites _fFavourites;

	private string EquityKey;

	private Form ActiveEquityForm;

	private Icon CNBCCursor;

	private const uint IDC_APPSTARTING = 32650u;

	private const uint IDC_ARROW = 32512u;

	private const uint IDC_HAND = 32649u;

	private const uint IDC_CROSS = 32515u;

	private const uint IDC_HELP = 32651u;

	private const uint IDC_IBEAM = 32513u;

	private const uint IDC_NO = 32648u;

	private const uint IDC_SIZEALL = 32646u;

	private const uint IDC_SIZENESW = 32643u;

	private const uint IDC_SIZENS = 32645u;

	private const uint IDC_SIZENWSE = 32642u;

	private const uint IDC_SIZEWE = 32644u;

	private const uint IDC_UP = 32516u;

	private const uint IDC_WAIT = 32514u;

	private string _ExchangeSymbol;

	private string _Favourites;

	private Udp UDI_1;

	private Udp UDI_2;

	private byte[] buffer;

	internal virtual ToolTip ToolTip
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolTip;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolTip = value;
		}
	}

	internal virtual UltraToolbarsDockArea _MDI_Toolbars_Dock_Area_Left
	{
		[DebuggerNonUserCode]
		get
		{
			return __MDI_Toolbars_Dock_Area_Left;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__MDI_Toolbars_Dock_Area_Left = value;
		}
	}

	internal virtual UltraToolbarsManager ToolbarsManager
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolbarsManager;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected O, but got Unknown
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Expected O, but got Unknown
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Expected O, but got Unknown
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Expected O, but got Unknown
			if (_ToolbarsManager != null)
			{
				_ToolbarsManager.remove_ToolClick(new ToolClickEventHandler(UltraToolbarsManager1_ToolClick));
				_ToolbarsManager.remove_AfterToolExitEditMode(new AfterToolExitEditModeEventHandler(UltraToolbarsManager1_AfterToolExitEditMode));
				_ToolbarsManager.remove_AfterToolActivate(new ToolEventHandler(UltraToolbarsManager1_AfterToolActivate));
			}
			_ToolbarsManager = value;
			if (_ToolbarsManager != null)
			{
				_ToolbarsManager.add_ToolClick(new ToolClickEventHandler(UltraToolbarsManager1_ToolClick));
				_ToolbarsManager.add_AfterToolExitEditMode(new AfterToolExitEditModeEventHandler(UltraToolbarsManager1_AfterToolExitEditMode));
				_ToolbarsManager.add_AfterToolActivate(new ToolEventHandler(UltraToolbarsManager1_AfterToolActivate));
			}
		}
	}

	internal virtual UltraToolbarsDockArea _MDI_Toolbars_Dock_Area_Right
	{
		[DebuggerNonUserCode]
		get
		{
			return __MDI_Toolbars_Dock_Area_Right;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__MDI_Toolbars_Dock_Area_Right = value;
		}
	}

	internal virtual UltraToolbarsDockArea _MDI_Toolbars_Dock_Area_Top
	{
		[DebuggerNonUserCode]
		get
		{
			return __MDI_Toolbars_Dock_Area_Top;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__MDI_Toolbars_Dock_Area_Top = value;
		}
	}

	internal virtual UltraToolbarsDockArea _MDI_Toolbars_Dock_Area_Bottom
	{
		[DebuggerNonUserCode]
		get
		{
			return __MDI_Toolbars_Dock_Area_Bottom;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__MDI_Toolbars_Dock_Area_Bottom = value;
		}
	}

	internal virtual UltraStatusBar UltraStatusBar1
	{
		[DebuggerNonUserCode]
		get
		{
			return _UltraStatusBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UltraStatusBar1 = value;
		}
	}

	internal virtual UltraToolbarsManager UltraToolbarsManager2
	{
		[DebuggerNonUserCode]
		get
		{
			return _UltraToolbarsManager2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UltraToolbarsManager2 = value;
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

	internal virtual ToolStripMenuItem AddToFavouritesToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _AddToFavouritesToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_AddToFavouritesToolStripMenuItem != null)
			{
				((ToolStripItem)_AddToFavouritesToolStripMenuItem).remove_Click((EventHandler)AddToFavouritesToolStripMenuItem_Click);
			}
			_AddToFavouritesToolStripMenuItem = value;
			if (_AddToFavouritesToolStripMenuItem != null)
			{
				((ToolStripItem)_AddToFavouritesToolStripMenuItem).add_Click((EventHandler)AddToFavouritesToolStripMenuItem_Click);
			}
		}
	}

	internal virtual UltraGroupBox UltraGroupBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _UltraGroupBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UltraGroupBox1 = value;
		}
	}

	internal virtual UltraGroupBox grFavourite5
	{
		[DebuggerNonUserCode]
		get
		{
			return _grFavourite5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_grFavourite5 = value;
		}
	}

	internal virtual UltraGroupBox grFavourite4
	{
		[DebuggerNonUserCode]
		get
		{
			return _grFavourite4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_grFavourite4 = value;
		}
	}

	internal virtual UltraGroupBox grFavourite3
	{
		[DebuggerNonUserCode]
		get
		{
			return _grFavourite3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_grFavourite3 = value;
		}
	}

	internal virtual UltraGroupBox grFavourite2
	{
		[DebuggerNonUserCode]
		get
		{
			return _grFavourite2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_grFavourite2 = value;
		}
	}

	internal virtual UltraGroupBox grFavourite1
	{
		[DebuggerNonUserCode]
		get
		{
			return _grFavourite1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_grFavourite1 = value;
		}
	}

	internal virtual Udp PowerUDP
	{
		[DebuggerNonUserCode]
		get
		{
			return _PowerUDP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected O, but got Unknown
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected O, but got Unknown
			if (_PowerUDP != null)
			{
				_PowerUDP.remove_EndReceive(new DatagramEventHandler(PowerUDP_EndReceive));
			}
			_PowerUDP = value;
			if (_PowerUDP != null)
			{
				_PowerUDP.add_EndReceive(new DatagramEventHandler(PowerUDP_EndReceive));
			}
		}
	}

	public virtual UltraTabbedMdiManager UltraTabbedMdiManager1
	{
		[DebuggerNonUserCode]
		get
		{
			return _UltraTabbedMdiManager1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected O, but got Unknown
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Expected O, but got Unknown
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Expected O, but got Unknown
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Expected O, but got Unknown
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Expected O, but got Unknown
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Expected O, but got Unknown
			if (_UltraTabbedMdiManager1 != null)
			{
				_UltraTabbedMdiManager1.remove_TabSelected(new MdiTabEventHandler(UltraTabbedMdiManager1_TabSelected));
				_UltraTabbedMdiManager1.remove_TabClosed(new MdiTabEventHandler(UltraTabbedMdiManager1_TabClosed));
				_UltraTabbedMdiManager1.remove_TabActivated(new MdiTabEventHandler(UltraTabbedMdiManager1_TabActivated));
				_UltraTabbedMdiManager1.remove_InitializeTabGroup(new MdiTabGroupEventHandler(UltraTabbedMdiManager1_InitializeTabGroup));
			}
			_UltraTabbedMdiManager1 = value;
			if (_UltraTabbedMdiManager1 != null)
			{
				_UltraTabbedMdiManager1.add_TabSelected(new MdiTabEventHandler(UltraTabbedMdiManager1_TabSelected));
				_UltraTabbedMdiManager1.add_TabClosed(new MdiTabEventHandler(UltraTabbedMdiManager1_TabClosed));
				_UltraTabbedMdiManager1.add_TabActivated(new MdiTabEventHandler(UltraTabbedMdiManager1_TabActivated));
				_UltraTabbedMdiManager1.add_InitializeTabGroup(new MdiTabGroupEventHandler(UltraTabbedMdiManager1_InitializeTabGroup));
			}
		}
	}

	internal virtual Label lbl_LP1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbl_LP1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbl_LP1 = value;
		}
	}

	internal virtual Label lbl_PC1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbl_PC1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbl_PC1 = value;
		}
	}

	internal virtual Label lbl_C1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbl_C1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbl_C1 = value;
		}
	}

	internal virtual Label lbl_PC5
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbl_PC5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbl_PC5 = value;
		}
	}

	internal virtual Label lbl_C5
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbl_C5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbl_C5 = value;
		}
	}

	internal virtual Label lbl_LP5
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbl_LP5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbl_LP5 = value;
		}
	}

	internal virtual Label lbl_PC4
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbl_PC4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbl_PC4 = value;
		}
	}

	internal virtual Label lbl_C4
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbl_C4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbl_C4 = value;
		}
	}

	internal virtual Label lbl_LP4
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbl_LP4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbl_LP4 = value;
		}
	}

	internal virtual Label lbl_PC3
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbl_PC3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbl_PC3 = value;
		}
	}

	internal virtual Label lbl_C3
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbl_C3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbl_C3 = value;
		}
	}

	internal virtual Label lbl_LP3
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbl_LP3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbl_LP3 = value;
		}
	}

	internal virtual Label lbl_PC2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbl_PC2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbl_PC2 = value;
		}
	}

	internal virtual Label lbl_C2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbl_C2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbl_C2 = value;
		}
	}

	internal virtual Label lbl_LP2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbl_LP2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbl_LP2 = value;
		}
	}

	internal virtual Label lbl_CL5
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbl_CL5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbl_CL5 = value;
		}
	}

	internal virtual Label lbl_CL4
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbl_CL4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbl_CL4 = value;
		}
	}

	internal virtual Label lbl_CL3
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbl_CL3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbl_CL3 = value;
		}
	}

	internal virtual Label lbl_CL2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbl_CL2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbl_CL2 = value;
		}
	}

	internal virtual Label lbl_CL1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbl_CL1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbl_CL1 = value;
		}
	}

	internal virtual Timer tmr_Streaming
	{
		[DebuggerNonUserCode]
		get
		{
			return _tmr_Streaming;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_tmr_Streaming != null)
			{
				_tmr_Streaming.remove_Tick((EventHandler)tmr_Streaming_Tick);
			}
			_tmr_Streaming = value;
			if (_tmr_Streaming != null)
			{
				_tmr_Streaming.add_Tick((EventHandler)tmr_Streaming_Tick);
			}
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

	internal virtual ToolStripMenuItem ShowDataToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _ShowDataToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_ShowDataToolStripMenuItem != null)
			{
				((ToolStripItem)_ShowDataToolStripMenuItem).remove_Click((EventHandler)ShowDataToolStripMenuItem_Click);
			}
			_ShowDataToolStripMenuItem = value;
			if (_ShowDataToolStripMenuItem != null)
			{
				((ToolStripItem)_ShowDataToolStripMenuItem).add_Click((EventHandler)ShowDataToolStripMenuItem_Click);
			}
		}
	}

	private virtual frmEquity fEquity1
	{
		[DebuggerNonUserCode]
		get
		{
			return _fEquity1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_fEquity1 != null)
			{
				_fEquity1.SendToBroadCast -= fEquity1_SendToBroadCast;
				_fEquity1.Rename_MDI_Tab -= fEquity1_Rename_MDI_Tab;
				_fEquity1.MarketWatch -= fEquity1_MarketWatch;
			}
			_fEquity1 = value;
			if (_fEquity1 != null)
			{
				_fEquity1.SendToBroadCast += fEquity1_SendToBroadCast;
				_fEquity1.Rename_MDI_Tab += fEquity1_Rename_MDI_Tab;
				_fEquity1.MarketWatch += fEquity1_MarketWatch;
			}
		}
	}

	private virtual frmEquity fEquity2
	{
		[DebuggerNonUserCode]
		get
		{
			return _fEquity2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_fEquity2 != null)
			{
				_fEquity2.SendToBroadCast -= fEquity2_SendToBroadCast;
				_fEquity2.Rename_MDI_Tab -= fEquity2_Rename_MDI_Tab;
				_fEquity2.MarketWatch -= fEquity2_MarketWatch;
			}
			_fEquity2 = value;
			if (_fEquity2 != null)
			{
				_fEquity2.SendToBroadCast += fEquity2_SendToBroadCast;
				_fEquity2.Rename_MDI_Tab += fEquity2_Rename_MDI_Tab;
				_fEquity2.MarketWatch += fEquity2_MarketWatch;
			}
		}
	}

	private virtual frmEquity fEquity3
	{
		[DebuggerNonUserCode]
		get
		{
			return _fEquity3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_fEquity3 != null)
			{
				_fEquity3.SendToBroadCast -= fEquity3_SendToBroadCast;
				_fEquity3.Rename_MDI_Tab -= fEquity3_Rename_MDI_Tab;
				_fEquity3.MarketWatch -= fEquity3_MarketWatch;
			}
			_fEquity3 = value;
			if (_fEquity3 != null)
			{
				_fEquity3.SendToBroadCast += fEquity3_SendToBroadCast;
				_fEquity3.Rename_MDI_Tab += fEquity3_Rename_MDI_Tab;
				_fEquity3.MarketWatch += fEquity3_MarketWatch;
			}
		}
	}

	private virtual frmEquity fEquity4
	{
		[DebuggerNonUserCode]
		get
		{
			return _fEquity4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_fEquity4 != null)
			{
				_fEquity4.SendToBroadCast -= fEquity4_SendToBroadCast;
				_fEquity4.Rename_MDI_Tab -= fEquity4_Rename_MDI_Tab;
				_fEquity4.MarketWatch -= fEquity4_MarketWatch;
			}
			_fEquity4 = value;
			if (_fEquity4 != null)
			{
				_fEquity4.SendToBroadCast += fEquity4_SendToBroadCast;
				_fEquity4.Rename_MDI_Tab += fEquity4_Rename_MDI_Tab;
				_fEquity4.MarketWatch += fEquity4_MarketWatch;
			}
		}
	}

	private virtual frmEquity fEquity5
	{
		[DebuggerNonUserCode]
		get
		{
			return _fEquity5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_fEquity5 != null)
			{
				_fEquity5.SendToBroadCast -= fEquity5_SendToBroadCast;
				_fEquity5.Rename_MDI_Tab -= fEquity5_Rename_MDI_Tab;
				_fEquity5.MarketWatch -= fEquity5_MarketWatch;
			}
			_fEquity5 = value;
			if (_fEquity5 != null)
			{
				_fEquity5.SendToBroadCast += fEquity5_SendToBroadCast;
				_fEquity5.Rename_MDI_Tab += fEquity5_Rename_MDI_Tab;
				_fEquity5.MarketWatch += fEquity5_MarketWatch;
			}
		}
	}

	private virtual frmFavourites fFavourites
	{
		[DebuggerNonUserCode]
		get
		{
			return _fFavourites;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_fFavourites != null)
			{
				_fFavourites.Refresh_Favourites -= fFavourites_Refresh_Favourites;
			}
			_fFavourites = value;
			if (_fFavourites != null)
			{
				_fFavourites.Refresh_Favourites += fFavourites_Refresh_Favourites;
			}
		}
	}

	private string ExchangeSymbol
	{
		get
		{
			return _ExchangeSymbol;
		}
		set
		{
			_ExchangeSymbol = value;
		}
	}

	private object Favourites
	{
		get
		{
			return _Favourites;
		}
		set
		{
			_Favourites = Conversions.ToString(value);
		}
	}

	public MDIParent()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		((Form)this).add_Activated((EventHandler)MDIParent_Activated);
		((Form)this).add_Load((EventHandler)MDIParent_Load);
		((Control)this).add_KeyUp(new KeyEventHandler(MDIParent_KeyUp));
		((Form)this).add_FormClosed(new FormClosedEventHandler(MDIParent_FormClosed));
		__ENCList.Add(new WeakReference(this));
		m_ChildFormNumber = 0;
		ro = 0;
		fEquity1 = new frmEquity();
		fEquity2 = new frmEquity();
		fEquity3 = new frmEquity();
		fEquity4 = new frmEquity();
		fEquity5 = new frmEquity();
		fFutures = new frmFutures();
		fOptions = new frmOptions();
		fFavourites = new frmFavourites();
		UDI_1 = new Udp();
		UDI_2 = new Udp();
		buffer = new byte[10001];
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if ((disposing && components != null) ? true : false)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected O, but got Unknown
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected O, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected O, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected O, but got Unknown
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected O, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected O, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected O, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected O, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected O, but got Unknown
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected O, but got Unknown
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected O, but got Unknown
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected O, but got Unknown
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected O, but got Unknown
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected O, but got Unknown
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected O, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected O, but got Unknown
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected O, but got Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected O, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected O, but got Unknown
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected O, but got Unknown
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected O, but got Unknown
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected O, but got Unknown
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Expected O, but got Unknown
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected O, but got Unknown
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected O, but got Unknown
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected O, but got Unknown
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected O, but got Unknown
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected O, but got Unknown
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Expected O, but got Unknown
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected O, but got Unknown
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected O, but got Unknown
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected O, but got Unknown
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected O, but got Unknown
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Expected O, but got Unknown
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Expected O, but got Unknown
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Expected O, but got Unknown
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected O, but got Unknown
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Expected O, but got Unknown
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected O, but got Unknown
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Expected O, but got Unknown
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected O, but got Unknown
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Expected O, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Expected O, but got Unknown
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Expected O, but got Unknown
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Expected O, but got Unknown
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected O, but got Unknown
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Expected O, but got Unknown
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Expected O, but got Unknown
		//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Expected O, but got Unknown
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Expected O, but got Unknown
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0411: Expected O, but got Unknown
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Expected O, but got Unknown
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected O, but got Unknown
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Expected O, but got Unknown
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Expected O, but got Unknown
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_043e: Expected O, but got Unknown
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Expected O, but got Unknown
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0451: Expected O, but got Unknown
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Expected O, but got Unknown
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Expected O, but got Unknown
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_0470: Expected O, but got Unknown
		//IL_0470: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Expected O, but got Unknown
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Expected O, but got Unknown
		//IL_0483: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Expected O, but got Unknown
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Expected O, but got Unknown
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Expected O, but got Unknown
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Expected O, but got Unknown
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Expected O, but got Unknown
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Expected O, but got Unknown
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04be: Expected O, but got Unknown
		//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Expected O, but got Unknown
		//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Expected O, but got Unknown
		//IL_04db: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Expected O, but got Unknown
		//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Expected O, but got Unknown
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f5: Expected O, but got Unknown
		//IL_04fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0501: Expected O, but got Unknown
		//IL_0501: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Expected O, but got Unknown
		//IL_050d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Expected O, but got Unknown
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Expected O, but got Unknown
		//IL_0520: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Expected O, but got Unknown
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052e: Expected O, but got Unknown
		//IL_0533: Unknown result type (might be due to invalid IL or missing references)
		//IL_053a: Expected O, but got Unknown
		//IL_053a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0541: Expected O, but got Unknown
		//IL_0546: Unknown result type (might be due to invalid IL or missing references)
		//IL_054d: Expected O, but got Unknown
		//IL_054d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0554: Expected O, but got Unknown
		//IL_0559: Unknown result type (might be due to invalid IL or missing references)
		//IL_0560: Expected O, but got Unknown
		//IL_0560: Unknown result type (might be due to invalid IL or missing references)
		//IL_0567: Expected O, but got Unknown
		//IL_0568: Unknown result type (might be due to invalid IL or missing references)
		//IL_056f: Expected O, but got Unknown
		//IL_0574: Unknown result type (might be due to invalid IL or missing references)
		//IL_057b: Expected O, but got Unknown
		//IL_057b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Expected O, but got Unknown
		//IL_0587: Unknown result type (might be due to invalid IL or missing references)
		//IL_058e: Expected O, but got Unknown
		//IL_058e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0595: Expected O, but got Unknown
		//IL_059a: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a1: Expected O, but got Unknown
		//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a8: Expected O, but got Unknown
		//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b4: Expected O, but got Unknown
		//IL_05b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bb: Expected O, but got Unknown
		//IL_05c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c7: Expected O, but got Unknown
		//IL_05c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Expected O, but got Unknown
		//IL_05d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05da: Expected O, but got Unknown
		//IL_05da: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e1: Expected O, but got Unknown
		//IL_05e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ed: Expected O, but got Unknown
		//IL_05ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f4: Expected O, but got Unknown
		//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0600: Expected O, but got Unknown
		//IL_0600: Unknown result type (might be due to invalid IL or missing references)
		//IL_0607: Expected O, but got Unknown
		//IL_060c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0613: Expected O, but got Unknown
		//IL_0613: Unknown result type (might be due to invalid IL or missing references)
		//IL_061a: Expected O, but got Unknown
		//IL_061f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0626: Expected O, but got Unknown
		//IL_0626: Unknown result type (might be due to invalid IL or missing references)
		//IL_062d: Expected O, but got Unknown
		//IL_0632: Unknown result type (might be due to invalid IL or missing references)
		//IL_0639: Expected O, but got Unknown
		//IL_0639: Unknown result type (might be due to invalid IL or missing references)
		//IL_0640: Expected O, but got Unknown
		//IL_0645: Unknown result type (might be due to invalid IL or missing references)
		//IL_064c: Expected O, but got Unknown
		//IL_064c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0653: Expected O, but got Unknown
		//IL_0658: Unknown result type (might be due to invalid IL or missing references)
		//IL_065f: Expected O, but got Unknown
		//IL_065f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0666: Expected O, but got Unknown
		//IL_066b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0672: Expected O, but got Unknown
		//IL_0672: Unknown result type (might be due to invalid IL or missing references)
		//IL_0679: Expected O, but got Unknown
		//IL_067e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0685: Expected O, but got Unknown
		//IL_0685: Unknown result type (might be due to invalid IL or missing references)
		//IL_068c: Expected O, but got Unknown
		//IL_0691: Unknown result type (might be due to invalid IL or missing references)
		//IL_0698: Expected O, but got Unknown
		//IL_0698: Unknown result type (might be due to invalid IL or missing references)
		//IL_069f: Expected O, but got Unknown
		//IL_06a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ab: Expected O, but got Unknown
		//IL_06b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b7: Expected O, but got Unknown
		//IL_06b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06be: Expected O, but got Unknown
		//IL_06c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ca: Expected O, but got Unknown
		//IL_06ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d1: Expected O, but got Unknown
		//IL_06d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dd: Expected O, but got Unknown
		//IL_06dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e4: Expected O, but got Unknown
		//IL_06e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f0: Expected O, but got Unknown
		//IL_06f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f7: Expected O, but got Unknown
		//IL_06fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0703: Expected O, but got Unknown
		//IL_0703: Unknown result type (might be due to invalid IL or missing references)
		//IL_070a: Expected O, but got Unknown
		//IL_070f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0716: Expected O, but got Unknown
		//IL_0716: Unknown result type (might be due to invalid IL or missing references)
		//IL_071d: Expected O, but got Unknown
		//IL_0722: Unknown result type (might be due to invalid IL or missing references)
		//IL_0729: Expected O, but got Unknown
		//IL_0729: Unknown result type (might be due to invalid IL or missing references)
		//IL_0730: Expected O, but got Unknown
		//IL_0735: Unknown result type (might be due to invalid IL or missing references)
		//IL_073c: Expected O, but got Unknown
		//IL_073c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0743: Expected O, but got Unknown
		//IL_0748: Unknown result type (might be due to invalid IL or missing references)
		//IL_074f: Expected O, but got Unknown
		//IL_074f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0756: Expected O, but got Unknown
		//IL_075b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0762: Expected O, but got Unknown
		//IL_0762: Unknown result type (might be due to invalid IL or missing references)
		//IL_0769: Expected O, but got Unknown
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Expected O, but got Unknown
		//IL_0770: Unknown result type (might be due to invalid IL or missing references)
		//IL_0777: Expected O, but got Unknown
		//IL_0777: Unknown result type (might be due to invalid IL or missing references)
		//IL_077e: Expected O, but got Unknown
		//IL_077e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0785: Expected O, but got Unknown
		//IL_0785: Unknown result type (might be due to invalid IL or missing references)
		//IL_078c: Expected O, but got Unknown
		//IL_078c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0793: Expected O, but got Unknown
		//IL_0793: Unknown result type (might be due to invalid IL or missing references)
		//IL_079a: Expected O, but got Unknown
		//IL_079a: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a1: Expected O, but got Unknown
		//IL_07a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a8: Expected O, but got Unknown
		//IL_07a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07af: Expected O, but got Unknown
		//IL_07af: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b6: Expected O, but got Unknown
		//IL_07b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bd: Expected O, but got Unknown
		//IL_07bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c4: Expected O, but got Unknown
		//IL_07c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cb: Expected O, but got Unknown
		//IL_07cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d2: Expected O, but got Unknown
		//IL_07d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d9: Expected O, but got Unknown
		//IL_07d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e0: Expected O, but got Unknown
		//IL_07e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e7: Expected O, but got Unknown
		//IL_07e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ee: Expected O, but got Unknown
		//IL_07ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f4: Expected O, but got Unknown
		//IL_07f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fb: Expected O, but got Unknown
		//IL_07fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0802: Expected O, but got Unknown
		//IL_0802: Unknown result type (might be due to invalid IL or missing references)
		//IL_0809: Expected O, but got Unknown
		//IL_0809: Unknown result type (might be due to invalid IL or missing references)
		//IL_0810: Expected O, but got Unknown
		//IL_0828: Unknown result type (might be due to invalid IL or missing references)
		//IL_0832: Expected O, but got Unknown
		//IL_0839: Unknown result type (might be due to invalid IL or missing references)
		//IL_0843: Expected O, but got Unknown
		//IL_084a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0854: Expected O, but got Unknown
		//IL_0855: Unknown result type (might be due to invalid IL or missing references)
		//IL_085f: Expected O, but got Unknown
		//IL_0860: Unknown result type (might be due to invalid IL or missing references)
		//IL_086a: Expected O, but got Unknown
		//IL_086b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0875: Expected O, but got Unknown
		//IL_0876: Unknown result type (might be due to invalid IL or missing references)
		//IL_0880: Expected O, but got Unknown
		//IL_0881: Unknown result type (might be due to invalid IL or missing references)
		//IL_088b: Expected O, but got Unknown
		//IL_0892: Unknown result type (might be due to invalid IL or missing references)
		//IL_089c: Expected O, but got Unknown
		//IL_089d: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a7: Expected O, but got Unknown
		//IL_08ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b8: Expected O, but got Unknown
		//IL_08bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c9: Expected O, but got Unknown
		//IL_08ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d4: Expected O, but got Unknown
		//IL_08d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08df: Expected O, but got Unknown
		//IL_08e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ea: Expected O, but got Unknown
		//IL_08eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f5: Expected O, but got Unknown
		//IL_08f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0900: Expected O, but got Unknown
		//IL_0901: Unknown result type (might be due to invalid IL or missing references)
		//IL_090b: Expected O, but got Unknown
		//IL_090c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0916: Expected O, but got Unknown
		//IL_0917: Unknown result type (might be due to invalid IL or missing references)
		//IL_0921: Expected O, but got Unknown
		//IL_0922: Unknown result type (might be due to invalid IL or missing references)
		//IL_092c: Expected O, but got Unknown
		//IL_092d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0937: Expected O, but got Unknown
		//IL_0938: Unknown result type (might be due to invalid IL or missing references)
		//IL_0942: Expected O, but got Unknown
		//IL_0943: Unknown result type (might be due to invalid IL or missing references)
		//IL_094d: Expected O, but got Unknown
		//IL_094e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0958: Expected O, but got Unknown
		//IL_0959: Unknown result type (might be due to invalid IL or missing references)
		//IL_0963: Expected O, but got Unknown
		//IL_0964: Unknown result type (might be due to invalid IL or missing references)
		//IL_096e: Expected O, but got Unknown
		//IL_096f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0979: Expected O, but got Unknown
		//IL_097a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0984: Expected O, but got Unknown
		//IL_0985: Unknown result type (might be due to invalid IL or missing references)
		//IL_098f: Expected O, but got Unknown
		//IL_0990: Unknown result type (might be due to invalid IL or missing references)
		//IL_099a: Expected O, but got Unknown
		//IL_099b: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a5: Expected O, but got Unknown
		//IL_09a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b0: Expected O, but got Unknown
		//IL_09b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bb: Expected O, but got Unknown
		//IL_09bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c6: Expected O, but got Unknown
		//IL_09c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d1: Expected O, but got Unknown
		//IL_09d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09dc: Expected O, but got Unknown
		//IL_09dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e7: Expected O, but got Unknown
		//IL_09e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f2: Expected O, but got Unknown
		//IL_09f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a03: Expected O, but got Unknown
		//IL_0a0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a14: Expected O, but got Unknown
		//IL_0ca6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb0: Expected O, but got Unknown
		//IL_248a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2494: Expected O, but got Unknown
		//IL_24a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_24ac: Expected O, but got Unknown
		//IL_25a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_25aa: Expected O, but got Unknown
		//IL_25b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_25c2: Expected O, but got Unknown
		//IL_2791: Unknown result type (might be due to invalid IL or missing references)
		//IL_279b: Expected O, but got Unknown
		//IL_27fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2806: Expected O, but got Unknown
		//IL_2869: Unknown result type (might be due to invalid IL or missing references)
		//IL_2873: Expected O, but got Unknown
		//IL_28d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_28de: Expected O, but got Unknown
		//IL_2aaf: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ab9: Expected O, but got Unknown
		//IL_2db8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dc2: Expected O, but got Unknown
		//IL_30c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_30cc: Expected O, but got Unknown
		//IL_33cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_33d6: Expected O, but got Unknown
		//IL_36d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_36e0: Expected O, but got Unknown
		//IL_3994: Unknown result type (might be due to invalid IL or missing references)
		//IL_399e: Expected O, but got Unknown
		//IL_3a39: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a43: Expected O, but got Unknown
		//IL_3a50: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a5a: Expected O, but got Unknown
		components = new Container();
		ComboBoxTool val = new ComboBoxTool("Equity");
		ButtonTool val2 = new ButtonTool("1");
		ButtonTool val3 = new ButtonTool("2");
		ButtonTool val4 = new ButtonTool("3");
		ButtonTool val5 = new ButtonTool("4");
		ButtonTool val6 = new ButtonTool("5");
		ButtonTool val7 = new ButtonTool("Bonds");
		ButtonTool val8 = new ButtonTool("BSEWires");
		ButtonTool val9 = new ButtonTool("Commodity");
		ButtonTool val10 = new ButtonTool("DowJonesWire");
		ButtonTool val11 = new ButtonTool("ForeignIndices");
		ButtonTool val12 = new ButtonTool("Forex");
		ButtonTool val13 = new ButtonTool("Futures");
		ButtonTool val14 = new ButtonTool("Options");
		ButtonTool val15 = new ButtonTool("BlockDeals");
		ButtonTool val16 = new ButtonTool("Stats");
		MdiWindowListTool val17 = new MdiWindowListTool("MDIWindowListTool1");
		ButtonTool val18 = new ButtonTool("Exit");
		LabelTool val19 = new LabelTool("ColorScheme");
		ListTool val20 = new ListTool("ColorSchemeList");
		Appearance val21 = new Appearance();
		RibbonTab val22 = new RibbonTab("MarketWatch", "Market Watch");
		RibbonGroup val23 = new RibbonGroup("NSE", "NSE");
		Appearance val24 = new Appearance();
		Appearance val25 = new Appearance();
		LabelTool val26 = new LabelTool("NSE_ADV");
		LabelTool val27 = new LabelTool("NSE_DEC");
		LabelTool val28 = new LabelTool("NSE_RATIO");
		RibbonGroup val29 = new RibbonGroup("BSE", "BSE");
		Appearance val30 = new Appearance();
		Appearance val31 = new Appearance();
		LabelTool val32 = new LabelTool("BSE_ADV");
		LabelTool val33 = new LabelTool("BSE_DEC");
		LabelTool val34 = new LabelTool("BSE_RATIO");
		RibbonGroup val35 = new RibbonGroup("INDICES", "INDICES");
		Appearance val36 = new Appearance();
		Appearance val37 = new Appearance();
		LabelTool val38 = new LabelTool("SENSEX");
		LabelTool val39 = new LabelTool("NIFTY");
		LabelTool val40 = new LabelTool("MIDCAP");
		LabelTool val41 = new LabelTool("SEN_LP");
		LabelTool val42 = new LabelTool("NIF_LP");
		LabelTool val43 = new LabelTool("MID_LP");
		LabelTool val44 = new LabelTool("SEN_C");
		LabelTool val45 = new LabelTool("NIF_C");
		LabelTool val46 = new LabelTool("MID_C");
		LabelTool val47 = new LabelTool("SEN_PC");
		LabelTool val48 = new LabelTool("NIF_PC");
		LabelTool val49 = new LabelTool("MID_PC");
		RibbonGroup val50 = new RibbonGroup("TURNOVER", "TURNOVER");
		Appearance val51 = new Appearance();
		Appearance val52 = new Appearance();
		LabelTool val53 = new LabelTool("BSECM");
		Appearance val54 = new Appearance();
		LabelTool val55 = new LabelTool("NSECM");
		Appearance val56 = new Appearance();
		LabelTool val57 = new LabelTool("FNO");
		Appearance val58 = new Appearance();
		LabelTool val59 = new LabelTool("BSECM_VALUE");
		LabelTool val60 = new LabelTool("NSECM_VALUE");
		LabelTool val61 = new LabelTool("FNO_VALUE");
		RibbonGroup val62 = new RibbonGroup("PCR", "PCR");
		Appearance val63 = new Appearance();
		Appearance val64 = new Appearance();
		LabelTool val65 = new LabelTool("OI PCR");
		LabelTool val66 = new LabelTool("OI PREV PCR");
		LabelTool val67 = new LabelTool("PCRBLANK");
		LabelTool val68 = new LabelTool("OI_PCR_VALUE");
		LabelTool val69 = new LabelTool("OI_PREV_PCR_VALUE");
		RibbonGroup val70 = new RibbonGroup("ribbonGroup1", "CNBC Money 2010");
		Appearance val71 = new Appearance();
		Appearance val72 = new Appearance();
		ButtonTool val73 = new ButtonTool("HELP");
		ButtonTool val74 = new ButtonTool("Restart");
		UltraToolbar val75 = new UltraToolbar("UltraToolbar1");
		Appearance val76 = new Appearance();
		Appearance val77 = new Appearance();
		LabelTool val78 = new LabelTool("BSECM");
		Appearance val79 = new Appearance();
		LabelTool val80 = new LabelTool("NSECM");
		Appearance val81 = new Appearance();
		LabelTool val82 = new LabelTool("FNO");
		Appearance val83 = new Appearance();
		ButtonTool val84 = new ButtonTool("Exit");
		Appearance val85 = new Appearance();
		LabelTool val86 = new LabelTool("SEN_LP");
		Appearance val87 = new Appearance();
		LabelTool val88 = new LabelTool("SEN_C");
		Appearance val89 = new Appearance();
		LabelTool val90 = new LabelTool("SEN_PC");
		Appearance val91 = new Appearance();
		LabelTool val92 = new LabelTool("NIF_LP");
		Appearance val93 = new Appearance();
		LabelTool val94 = new LabelTool("NIF_C");
		Appearance val95 = new Appearance();
		LabelTool val96 = new LabelTool("NIF_PC");
		Appearance val97 = new Appearance();
		LabelTool val98 = new LabelTool("MID_LP");
		Appearance val99 = new Appearance();
		LabelTool val100 = new LabelTool("MID_C");
		Appearance val101 = new Appearance();
		LabelTool val102 = new LabelTool("MID_PC");
		Appearance val103 = new Appearance();
		LabelTool val104 = new LabelTool("BSECM_VALUE");
		Appearance val105 = new Appearance();
		Appearance val106 = new Appearance();
		LabelTool val107 = new LabelTool("NSECM_VALUE");
		Appearance val108 = new Appearance();
		Appearance val109 = new Appearance();
		LabelTool val110 = new LabelTool("FNO_VALUE");
		Appearance val111 = new Appearance();
		Appearance val112 = new Appearance();
		ListTool val113 = new ListTool("ColorSchemeList");
		ListToolItem val114 = new ListToolItem("Black");
		ListToolItem val115 = new ListToolItem("Blue");
		ListToolItem val116 = new ListToolItem("Silver");
		ButtonTool val117 = new ButtonTool("Bonds");
		Appearance val118 = new Appearance();
		ButtonTool val119 = new ButtonTool("BSEWires");
		Appearance val120 = new Appearance();
		ButtonTool val121 = new ButtonTool("Commodity");
		Appearance val122 = new Appearance();
		ButtonTool val123 = new ButtonTool("DowJonesWire");
		Appearance val124 = new Appearance();
		MdiWindowListTool val125 = new MdiWindowListTool("MDIWindowListTool1");
		Appearance val126 = new Appearance();
		LabelTool val127 = new LabelTool("SENSEX");
		Appearance val128 = new Appearance();
		ComboBoxTool val129 = new ComboBoxTool("Equity");
		Appearance val130 = new Appearance();
		ValueList valueList = new ValueList(0);
		ButtonTool val131 = new ButtonTool("1");
		Appearance val132 = new Appearance();
		ButtonTool val133 = new ButtonTool("2");
		Appearance val134 = new Appearance();
		ButtonTool val135 = new ButtonTool("3");
		Appearance val136 = new Appearance();
		ButtonTool val137 = new ButtonTool("4");
		Appearance val138 = new Appearance();
		ButtonTool val139 = new ButtonTool("5");
		Appearance val140 = new Appearance();
		ButtonTool val141 = new ButtonTool("ForeignIndices");
		Appearance val142 = new Appearance();
		ButtonTool val143 = new ButtonTool("Futures");
		Appearance val144 = new Appearance();
		ButtonTool val145 = new ButtonTool("Options");
		Appearance val146 = new Appearance();
		ButtonTool val147 = new ButtonTool("Forex");
		Appearance val148 = new Appearance();
		ButtonTool val149 = new ButtonTool("Stats");
		Appearance val150 = new Appearance();
		LabelTool val151 = new LabelTool("OI_PCR_VALUE");
		Appearance val152 = new Appearance();
		LabelTool val153 = new LabelTool("OI_PREV_PCR_VALUE");
		Appearance val154 = new Appearance();
		ButtonTool val155 = new ButtonTool("HELP");
		Appearance val156 = new Appearance();
		LabelTool val157 = new LabelTool("ColorScheme");
		Appearance val158 = new Appearance();
		LabelTool val159 = new LabelTool("NSE_RATIO");
		Appearance val160 = new Appearance();
		LabelTool val161 = new LabelTool("BSE_RATIO");
		Appearance val162 = new Appearance();
		LabelTool val163 = new LabelTool("PCRBLANK");
		LabelTool val164 = new LabelTool("NIFTY");
		Appearance val165 = new Appearance();
		LabelTool val166 = new LabelTool("MIDCAP");
		Appearance val167 = new Appearance();
		LabelTool val168 = new LabelTool("NSE_ADV");
		Appearance val169 = new Appearance();
		LabelTool val170 = new LabelTool("NSE_DEC");
		Appearance val171 = new Appearance();
		LabelTool val172 = new LabelTool("BSE_ADV");
		Appearance val173 = new Appearance();
		LabelTool val174 = new LabelTool("BSE_DEC");
		Appearance val175 = new Appearance();
		LabelTool val176 = new LabelTool("OI PCR");
		Appearance val177 = new Appearance();
		LabelTool val178 = new LabelTool("OI PREV PCR");
		Appearance val179 = new Appearance();
		ButtonTool val180 = new ButtonTool("BlockDeals");
		Appearance val181 = new Appearance();
		ButtonTool val182 = new ButtonTool("Restart");
		Appearance val183 = new Appearance();
		UltraStatusPanel val184 = new UltraStatusPanel();
		Appearance val185 = new Appearance();
		UltraStatusPanel val186 = new UltraStatusPanel();
		Appearance val187 = new Appearance();
		UltraStatusPanel val188 = new UltraStatusPanel();
		Appearance val189 = new Appearance();
		UltraStatusPanel val190 = new UltraStatusPanel();
		Appearance val191 = new Appearance();
		UltraStatusPanel val192 = new UltraStatusPanel();
		Appearance val193 = new Appearance();
		UltraStatusPanel val194 = new UltraStatusPanel();
		Appearance val195 = new Appearance();
		UltraStatusPanel val196 = new UltraStatusPanel();
		Appearance val197 = new Appearance();
		UltraStatusPanel val198 = new UltraStatusPanel();
		Appearance val199 = new Appearance();
		UltraStatusPanel val200 = new UltraStatusPanel();
		Appearance val201 = new Appearance();
		UltraStatusPanel val202 = new UltraStatusPanel();
		Appearance val203 = new Appearance();
		Appearance val204 = new Appearance();
		Appearance val205 = new Appearance();
		Appearance val206 = new Appearance();
		Appearance val207 = new Appearance();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(MDIParent));
		ToolTip = new ToolTip(components);
		UltraTabbedMdiManager1 = new UltraTabbedMdiManager(components);
		ToolbarsManager = new UltraToolbarsManager(components);
		_MDI_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
		_MDI_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
		_MDI_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
		_MDI_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
		UltraStatusBar1 = new UltraStatusBar();
		ContextMenuStrip2 = new ContextMenuStrip(components);
		ShowDataToolStripMenuItem = new ToolStripMenuItem();
		UltraToolbarsManager2 = new UltraToolbarsManager(components);
		ContextMenuStrip1 = new ContextMenuStrip(components);
		AddToFavouritesToolStripMenuItem = new ToolStripMenuItem();
		UltraGroupBox1 = new UltraGroupBox();
		grFavourite5 = new UltraGroupBox();
		lbl_CL5 = new Label();
		lbl_PC5 = new Label();
		lbl_C5 = new Label();
		lbl_LP5 = new Label();
		grFavourite4 = new UltraGroupBox();
		lbl_CL4 = new Label();
		lbl_PC4 = new Label();
		lbl_C4 = new Label();
		lbl_LP4 = new Label();
		grFavourite3 = new UltraGroupBox();
		lbl_CL3 = new Label();
		lbl_PC3 = new Label();
		lbl_C3 = new Label();
		lbl_LP3 = new Label();
		grFavourite2 = new UltraGroupBox();
		lbl_CL2 = new Label();
		lbl_PC2 = new Label();
		lbl_C2 = new Label();
		lbl_LP2 = new Label();
		grFavourite1 = new UltraGroupBox();
		lbl_CL1 = new Label();
		lbl_PC1 = new Label();
		lbl_C1 = new Label();
		lbl_LP1 = new Label();
		PowerUDP = new Udp(components);
		tmr_Streaming = new Timer(components);
		((ISupportInitialize)UltraTabbedMdiManager1).BeginInit();
		((ISupportInitialize)ToolbarsManager).BeginInit();
		((Control)ContextMenuStrip2).SuspendLayout();
		((ISupportInitialize)UltraToolbarsManager2).BeginInit();
		((Control)ContextMenuStrip1).SuspendLayout();
		((ISupportInitialize)UltraGroupBox1).BeginInit();
		((Control)UltraGroupBox1).SuspendLayout();
		((ISupportInitialize)grFavourite5).BeginInit();
		((Control)grFavourite5).SuspendLayout();
		((ISupportInitialize)grFavourite4).BeginInit();
		((Control)grFavourite4).SuspendLayout();
		((ISupportInitialize)grFavourite3).BeginInit();
		((Control)grFavourite3).SuspendLayout();
		((ISupportInitialize)grFavourite2).BeginInit();
		((Control)grFavourite2).SuspendLayout();
		((ISupportInitialize)grFavourite1).BeginInit();
		((Control)grFavourite1).SuspendLayout();
		((Control)this).SuspendLayout();
		UltraTabbedMdiManager1.set_MaxTabGroups(2);
		UltraTabbedMdiManager1.set_MdiParent((Form)(object)this);
		UltraTabbedMdiManager1.get_TabGroupSettings().set_TabButtonStyle((UIElementButtonStyle)17);
		((UltraStylableComponent)UltraTabbedMdiManager1).set_UseAppStyling(false);
		((UltraComponentControlManagerBase)UltraTabbedMdiManager1).set_UseFlatMode((DefaultableBoolean)1);
		((UltraComponentControlManagerBase)UltraTabbedMdiManager1).set_UseOsThemes((DefaultableBoolean)2);
		UltraTabbedMdiManager1.set_ViewStyle((ViewStyle)4);
		ToolbarsManager.set_AlwaysShowMenusExpanded((DefaultableBoolean)2);
		ToolbarsManager.set_DesignerFlags(1);
		ToolbarsManager.set_DockWithinContainer((Control)(object)this);
		ToolbarsManager.set_FormDisplayStyle((FormDisplayStyle)1);
		ToolbarsManager.set_HideToolbars(true);
		ToolbarsManager.set_LockToolbars(true);
		ToolbarsManager.set_MenuAnimationStyle((MenuAnimationStyle)3);
		ToolbarsManager.get_MenuSettings().set_IsSideStripVisible((DefaultableBoolean)2);
		((ToolBase)val7).get_InstanceProps().set_IsFirstInGroup(true);
		((ToolBase)val12).get_InstanceProps().set_IsFirstInGroup(true);
		((ToolsCollectionBase)ToolbarsManager.get_Ribbon().get_ApplicationMenu().get_ToolAreaLeft()
			.get_Tools()).AddRange((ToolBase[])(object)new ToolBase[18]
		{
			(ToolBase)val,
			(ToolBase)val2,
			(ToolBase)val3,
			(ToolBase)val4,
			(ToolBase)val5,
			(ToolBase)val6,
			(ToolBase)val7,
			(ToolBase)val8,
			(ToolBase)val9,
			(ToolBase)val10,
			(ToolBase)val11,
			(ToolBase)val12,
			(ToolBase)val13,
			(ToolBase)val14,
			(ToolBase)val15,
			(ToolBase)val16,
			(ToolBase)val17,
			(ToolBase)val18
		});
		((ToolBase)val20).get_InstanceProps().set_IsFirstInGroup(false);
		((ToolsCollectionBase)ToolbarsManager.get_Ribbon().get_ApplicationMenu().get_ToolAreaRight()
			.get_Tools()).AddRange((ToolBase[])(object)new ToolBase[2]
		{
			(ToolBase)val19,
			(ToolBase)val20
		});
		ToolbarsManager.get_Ribbon().set_ApplicationMenuButtonImage((Image)componentResourceManager.GetObject("ToolbarsManager.Ribbon.ApplicationMenuButtonImage"));
		((AppearanceBase)val21).set_TextHAlignAsString("Center");
		ToolbarsManager.get_Ribbon().set_CaptionAreaActiveAppearance((AppearanceBase)(object)val21);
		((SettingsBase)ToolbarsManager.get_Ribbon().get_QuickAccessToolbar().get_Settings()).set_ToolDisplayStyle((ToolDisplayStyle)4);
		ToolbarsManager.get_Ribbon().get_QuickAccessToolbar().set_Visible(false);
		val23.set_Key("NSE");
		val24.set_BorderColor(Color.FromArgb(0, 192, 0));
		((SettingsBase)val23.get_Settings()).set_Appearance((AppearanceBase)(object)val24);
		val25.set_BackColor(Color.FromArgb(0, 192, 0));
		val25.get_FontData().set_BoldAsString("True");
		val25.set_TextTrimming((TextTrimming)1);
		val23.get_Settings().set_CaptionAppearance((AppearanceBase)(object)val25);
		((SettingsBase)val23.get_Settings()).set_ShowToolTips((DefaultableBoolean)1);
		((ToolsCollectionBase)val23.get_Tools()).AddRange((ToolBase[])(object)new ToolBase[3]
		{
			(ToolBase)val26,
			(ToolBase)val27,
			(ToolBase)val28
		});
		val29.set_Key("BSE");
		val30.set_BorderColor(Color.FromArgb(192, 192, 0));
		((SettingsBase)val29.get_Settings()).set_Appearance((AppearanceBase)(object)val30);
		val31.set_BackColor(Color.FromArgb(192, 192, 0));
		val31.get_FontData().set_BoldAsString("True");
		val29.get_Settings().set_CaptionAppearance((AppearanceBase)(object)val31);
		((ToolsCollectionBase)val29.get_Tools()).AddRange((ToolBase[])(object)new ToolBase[3]
		{
			(ToolBase)val32,
			(ToolBase)val33,
			(ToolBase)val34
		});
		val35.set_Key("INDICES");
		val36.set_BorderColor(Color.Teal);
		((SettingsBase)val35.get_Settings()).set_Appearance((AppearanceBase)(object)val36);
		val37.set_BackColor(Color.FromArgb(192, 192, 255));
		val37.get_FontData().set_BoldAsString("True");
		val35.get_Settings().set_CaptionAppearance((AppearanceBase)(object)val37);
		((ToolsCollectionBase)val35.get_Tools()).AddRange((ToolBase[])(object)new ToolBase[12]
		{
			(ToolBase)val38,
			(ToolBase)val39,
			(ToolBase)val40,
			(ToolBase)val41,
			(ToolBase)val42,
			(ToolBase)val43,
			(ToolBase)val44,
			(ToolBase)val45,
			(ToolBase)val46,
			(ToolBase)val47,
			(ToolBase)val48,
			(ToolBase)val49
		});
		val50.set_Key("TURNOVER");
		val51.set_BorderColor(Color.FromArgb(192, 64, 0));
		((SettingsBase)val50.get_Settings()).set_Appearance((AppearanceBase)(object)val51);
		val52.set_BackColor(Color.FromArgb(255, 128, 128));
		val52.get_FontData().set_BoldAsString("True");
		val50.get_Settings().set_CaptionAppearance((AppearanceBase)(object)val52);
		((AppearanceBase)val54).set_TextHAlignAsString("Left");
		((ToolPropsBase)((ToolBase)val53).get_InstanceProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val54);
		((ToolPropsBase)((ToolBase)val53).get_InstanceProps()).set_Width(56);
		((AppearanceBase)val56).set_TextHAlignAsString("Left");
		((ToolPropsBase)((ToolBase)val55).get_InstanceProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val56);
		((AppearanceBase)val58).set_TextHAlignAsString("Left");
		((ToolPropsBase)((ToolBase)val57).get_InstanceProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val58);
		((ToolsCollectionBase)val50.get_Tools()).AddRange((ToolBase[])(object)new ToolBase[6]
		{
			(ToolBase)val53,
			(ToolBase)val55,
			(ToolBase)val57,
			(ToolBase)val59,
			(ToolBase)val60,
			(ToolBase)val61
		});
		val62.set_Key("PCR");
		val63.set_BorderColor(Color.FromArgb(255, 128, 0));
		((SettingsBase)val62.get_Settings()).set_Appearance((AppearanceBase)(object)val63);
		val64.set_BackColor(Color.FromArgb(255, 192, 128));
		val64.get_FontData().set_BoldAsString("True");
		val62.get_Settings().set_CaptionAppearance((AppearanceBase)(object)val64);
		((ToolsCollectionBase)val62.get_Tools()).AddRange((ToolBase[])(object)new ToolBase[5]
		{
			(ToolBase)val65,
			(ToolBase)val66,
			(ToolBase)val67,
			(ToolBase)val68,
			(ToolBase)val69
		});
		val70.set_Key("ribbonGroup1");
		val71.set_BorderColor(Color.DarkMagenta);
		((SettingsBase)val70.get_Settings()).set_Appearance((AppearanceBase)(object)val71);
		val72.set_BackColor(Color.FromArgb(0, 192, 192));
		val72.get_FontData().set_BoldAsString("True");
		val70.get_Settings().set_CaptionAppearance((AppearanceBase)(object)val72);
		((ToolsCollectionBase)val70.get_Tools()).AddRange((ToolBase[])(object)new ToolBase[2]
		{
			(ToolBase)val73,
			(ToolBase)val74
		});
		val22.get_Groups().AddRange((RibbonGroup[])(object)new RibbonGroup[6] { val23, val29, val35, val50, val62, val70 });
		val22.set_Key("MarketWatch");
		((RibbonTabCollectionBase)ToolbarsManager.get_Ribbon().get_Tabs()).AddRange((RibbonTab[])(object)new RibbonTab[1] { val22 });
		ToolbarsManager.get_Ribbon().set_Visible(true);
		ToolbarsManager.set_ShowFullMenusDelay(500);
		ToolbarsManager.set_ShowQuickCustomizeButton(false);
		ToolbarsManager.set_ShowShortcutsInToolTips(true);
		ToolbarsManager.set_Style((ToolbarStyle)5);
		val75.set_DockedColumn(0);
		val75.set_DockedRow(0);
		val76.get_FontData().set_BoldAsString("True");
		((SettingsBase)val75.get_Settings()).set_Appearance((AppearanceBase)(object)val76);
		val75.get_Settings().set_ToolOrientation((ToolOrientation)3);
		val75.set_Text("UltraToolbar1");
		ToolbarsManager.get_Toolbars().AddRange((UltraToolbar[])(object)new UltraToolbar[1] { val75 });
		val77.get_FontData().set_BoldAsString("True");
		((SettingsBase)ToolbarsManager.get_ToolbarSettings()).set_Appearance((AppearanceBase)(object)val77);
		val79.get_FontData().set_BoldAsString("True");
		((AppearanceBase)val79).set_TextHAlignAsString("Left");
		((ToolPropsBase)((ToolBase)val78).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val79);
		((ToolPropsBase)((ToolBase)val78).get_SharedProps()).set_Caption("BSECM");
		val81.get_FontData().set_BoldAsString("True");
		((AppearanceBase)val81).set_TextHAlignAsString("Left");
		((ToolPropsBase)((ToolBase)val80).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val81);
		((ToolPropsBase)((ToolBase)val80).get_SharedProps()).set_Caption("NSECM");
		val83.get_FontData().set_BoldAsString("True");
		((AppearanceBase)val83).set_TextHAlignAsString("Left");
		((ToolPropsBase)((ToolBase)val82).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val83);
		((ToolPropsBase)((ToolBase)val82).get_SharedProps()).set_Caption("FNO");
		val85.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance27.Image")));
		((ToolPropsBase)((ToolBase)val84).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val85);
		((ToolPropsBase)((ToolBase)val84).get_SharedProps()).set_Caption("Exit");
		((ToolBase)val84).get_SharedProps().set_DescriptionOnMenu("<span style=\"color:Maroon;\">Close the application</span>");
		((ToolPropsBase)((ToolBase)val84).get_SharedProps()).set_DisplayStyle((ToolDisplayStyle)4);
		val87.get_FontData().set_BoldAsString("True");
		((ToolPropsBase)((ToolBase)val86).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val87);
		((ToolPropsBase)((ToolBase)val86).get_SharedProps()).set_Caption("SEN_LP");
		val89.get_FontData().set_BoldAsString("True");
		((ToolPropsBase)((ToolBase)val88).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val89);
		((ToolPropsBase)((ToolBase)val88).get_SharedProps()).set_Caption("SEN_C");
		val91.get_FontData().set_BoldAsString("True");
		((ToolPropsBase)((ToolBase)val90).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val91);
		((ToolPropsBase)((ToolBase)val90).get_SharedProps()).set_Caption("SEN_PC");
		val93.get_FontData().set_BoldAsString("True");
		((ToolPropsBase)((ToolBase)val92).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val93);
		((ToolPropsBase)((ToolBase)val92).get_SharedProps()).set_Caption("NIF_LP");
		val95.get_FontData().set_BoldAsString("True");
		((ToolPropsBase)((ToolBase)val94).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val95);
		((ToolPropsBase)((ToolBase)val94).get_SharedProps()).set_Caption("NIF_C");
		val97.get_FontData().set_BoldAsString("True");
		((ToolPropsBase)((ToolBase)val96).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val97);
		((ToolPropsBase)((ToolBase)val96).get_SharedProps()).set_Caption("NIF_PC");
		val99.get_FontData().set_BoldAsString("True");
		((ToolPropsBase)((ToolBase)val98).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val99);
		((ToolPropsBase)((ToolBase)val98).get_SharedProps()).set_Caption("MID_LP");
		val101.get_FontData().set_BoldAsString("True");
		((ToolPropsBase)((ToolBase)val100).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val101);
		((ToolPropsBase)((ToolBase)val100).get_SharedProps()).set_Caption("MID_C");
		val103.get_FontData().set_BoldAsString("True");
		((ToolPropsBase)((ToolBase)val102).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val103);
		((ToolPropsBase)((ToolBase)val102).get_SharedProps()).set_Caption("MID_PC");
		val105.get_FontData().set_BoldAsString("True");
		((AppearanceBase)val105).set_TextHAlignAsString("Right");
		((ToolPropsBase)((ToolBase)val104).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val105);
		((AppearanceBase)val106).set_TextHAlignAsString("Right");
		((ToolPropsBase)((ToolBase)val104).get_SharedProps()).get_AppearancesSmall().set_AppearanceOnToolbar((AppearanceBase)(object)val106);
		((ToolPropsBase)((ToolBase)val104).get_SharedProps()).set_Caption("BSECM_VALUE");
		((ToolPropsBase)((ToolBase)val104).get_SharedProps()).set_Width(110);
		val108.get_FontData().set_BoldAsString("True");
		((AppearanceBase)val108).set_TextHAlignAsString("Right");
		((ToolPropsBase)((ToolBase)val107).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val108);
		((AppearanceBase)val109).set_TextHAlignAsString("Right");
		((ToolPropsBase)((ToolBase)val107).get_SharedProps()).get_AppearancesSmall().set_AppearanceOnToolbar((AppearanceBase)(object)val109);
		((ToolPropsBase)((ToolBase)val107).get_SharedProps()).set_Caption("NSECM_VALUE");
		((ToolPropsBase)((ToolBase)val107).get_SharedProps()).set_Width(110);
		val111.get_FontData().set_BoldAsString("True");
		((AppearanceBase)val111).set_TextHAlignAsString("Right");
		((ToolPropsBase)((ToolBase)val110).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val111);
		((AppearanceBase)val112).set_TextHAlignAsString("Right");
		((ToolPropsBase)((ToolBase)val110).get_SharedProps()).get_AppearancesSmall().set_AppearanceOnToolbar((AppearanceBase)(object)val112);
		((ToolPropsBase)((ToolBase)val110).get_SharedProps()).set_Caption("FNO_VALUE");
		((ToolPropsBase)((ToolBase)val110).get_SharedProps()).set_Width(110);
		val114.set_Key("Black");
		val114.set_Text("Black");
		val115.set_Key("Blue");
		val115.set_Text("Blue");
		val116.set_Key("Silver");
		val116.set_Text("Silver");
		val113.get_ListToolItemsInternal().Add((object)val114);
		val113.get_ListToolItemsInternal().Add((object)val115);
		val113.get_ListToolItemsInternal().Add((object)val116);
		val118.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance43.Image")));
		((ToolPropsBase)((ToolBase)val117).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val118);
		((ToolPropsBase)((ToolBase)val117).get_SharedProps()).set_Caption("Bonds");
		val120.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance44.Image")));
		((ToolPropsBase)((ToolBase)val119).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val120);
		((ToolPropsBase)((ToolBase)val119).get_SharedProps()).set_Caption("BSE Wires");
		((ToolPropsBase)((ToolBase)val119).get_SharedProps()).set_DisplayStyle((ToolDisplayStyle)4);
		val122.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance45.Image")));
		((ToolPropsBase)((ToolBase)val121).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val122);
		((ToolPropsBase)((ToolBase)val121).get_SharedProps()).set_Caption("Commodity");
		val124.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance46.Image")));
		((ToolPropsBase)((ToolBase)val123).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val124);
		((ToolPropsBase)((ToolBase)val123).get_SharedProps()).set_Caption("Dow Jones Wire");
		val126.set_Image((object)Resources._exit);
		((ToolPropsBase)((ToolBase)val125).get_SharedProps()).get_AppearancesLarge().set_Appearance((AppearanceBase)(object)val126);
		((ToolPropsBase)((ToolBase)val125).get_SharedProps()).set_Caption("MDIWindowListTool1");
		val128.get_FontData().set_BoldAsString("True");
		((AppearanceBase)val128).set_TextHAlignAsString("Left");
		((ToolPropsBase)((ToolBase)val127).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val128);
		((ToolPropsBase)((ToolBase)val127).get_SharedProps()).set_Caption("SENSEX");
		((ToolPropsBase)((ToolBase)val127).get_SharedProps()).set_Width(30);
		val129.set_DropDownStyle((DropDownStyle)0);
		val130.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance49.Image")));
		((ToolPropsBase)((ToolBase)val129).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val130);
		((ToolPropsBase)((ToolBase)val129).get_SharedProps()).set_Caption("Create Tab");
		((ToolBase)val129).get_SharedProps().set_DescriptionOnMenu("<span style=\"color:Maroon;\">Enter/Select Tab Name&edsp;&edsp;in the Dropdown</span>");
		((ToolPropsBase)((ToolBase)val129).get_SharedProps()).set_DisplayStyle((ToolDisplayStyle)4);
		((ToolBase)val129).get_SharedProps().set_Visible(false);
		val129.set_ValueList(valueList);
		((TextEditorToolBase)val129).set_VerticalDisplayStyle((VerticalDisplayStyle)1);
		val132.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance50.Image")));
		((ToolPropsBase)((ToolBase)val131).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val132);
		((ToolPropsBase)((ToolBase)val131).get_SharedProps()).set_Caption("Equity1");
		((ToolPropsBase)((ToolBase)val131).get_SharedProps()).set_DisplayStyle((ToolDisplayStyle)1);
		val134.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance51.Image")));
		((ToolPropsBase)((ToolBase)val133).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val134);
		((ToolPropsBase)((ToolBase)val133).get_SharedProps()).set_Caption("Equity2");
		val136.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance52.Image")));
		((ToolPropsBase)((ToolBase)val135).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val136);
		((ToolPropsBase)((ToolBase)val135).get_SharedProps()).set_Caption("Equity3");
		val138.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance53.Image")));
		((ToolPropsBase)((ToolBase)val137).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val138);
		((ToolPropsBase)((ToolBase)val137).get_SharedProps()).set_Caption("Equity4");
		val140.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance54.Image")));
		((ToolPropsBase)((ToolBase)val139).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val140);
		((ToolPropsBase)((ToolBase)val139).get_SharedProps()).set_Caption("Equity5");
		val142.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance55.Image")));
		((ToolPropsBase)((ToolBase)val141).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val142);
		((ToolPropsBase)((ToolBase)val141).get_SharedProps()).set_Caption("Foreign Indices");
		val144.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance56.Image")));
		((ToolPropsBase)((ToolBase)val143).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val144);
		((ToolPropsBase)((ToolBase)val143).get_SharedProps()).set_Caption("Futures");
		val146.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance57.Image")));
		((ToolPropsBase)((ToolBase)val145).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val146);
		((ToolPropsBase)((ToolBase)val145).get_SharedProps()).set_Caption("Options");
		val148.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance58.Image")));
		((ToolPropsBase)((ToolBase)val147).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val148);
		((ToolPropsBase)((ToolBase)val147).get_SharedProps()).set_Caption("Forex");
		val150.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance59.Image")));
		((ToolPropsBase)((ToolBase)val149).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val150);
		((ToolPropsBase)((ToolBase)val149).get_SharedProps()).set_Caption("Stats");
		val152.get_FontData().set_BoldAsString("True");
		((AppearanceBase)val152).set_TextHAlignAsString("Right");
		((ToolPropsBase)((ToolBase)val151).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val152);
		((ToolPropsBase)((ToolBase)val151).get_SharedProps()).set_Caption("PCR_VL");
		((ToolPropsBase)((ToolBase)val151).get_SharedProps()).set_Width(70);
		val154.get_FontData().set_BoldAsString("True");
		((AppearanceBase)val154).set_TextHAlignAsString("Right");
		((ToolPropsBase)((ToolBase)val153).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val154);
		((ToolPropsBase)((ToolBase)val153).get_SharedProps()).set_Caption("PREV_VL");
		((ToolPropsBase)((ToolBase)val153).get_SharedProps()).set_Width(70);
		val156.get_FontData().set_BoldAsString("True");
		val156.get_FontData().set_SizeInPoints(50f);
		((ToolPropsBase)((ToolBase)val155).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val156);
		((ToolPropsBase)((ToolBase)val155).get_SharedProps()).set_Caption("HELP");
		((ToolBase)val155).get_SharedProps().set_DescriptionOnMenu("F1 for Shortcut Help");
		((ToolBase)val155).get_SharedProps().set_Shortcut((Shortcut)112);
		val158.set_BackColor(Color.FromArgb(192, 192, 255));
		val158.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance63.Image")));
		((ToolPropsBase)((ToolBase)val157).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val158);
		((ToolPropsBase)((ToolBase)val157).get_SharedProps()).set_Caption("Color Scheme");
		((ToolBase)val157).get_SharedProps().set_DescriptionOnMenu("Theme for CNBC Money 2010");
		val160.get_FontData().set_BoldAsString("True");
		((AppearanceBase)val160).set_TextHAlignAsString("Left");
		((ToolPropsBase)((ToolBase)val159).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val160);
		((ToolPropsBase)((ToolBase)val159).get_SharedProps()).set_Caption("NSE_RATIO");
		val162.get_FontData().set_BoldAsString("True");
		((AppearanceBase)val162).set_TextHAlignAsString("Left");
		((ToolPropsBase)((ToolBase)val161).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val162);
		((ToolPropsBase)((ToolBase)val161).get_SharedProps()).set_Caption("BSE_RATIO");
		val165.get_FontData().set_BoldAsString("True");
		((AppearanceBase)val165).set_TextHAlignAsString("Left");
		((ToolPropsBase)((ToolBase)val164).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val165);
		((ToolPropsBase)((ToolBase)val164).get_SharedProps()).set_Caption("NIFTY");
		((ToolPropsBase)((ToolBase)val164).get_SharedProps()).set_Width(30);
		val167.get_FontData().set_BoldAsString("True");
		((AppearanceBase)val167).set_TextHAlignAsString("Left");
		((ToolPropsBase)((ToolBase)val166).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val167);
		((ToolPropsBase)((ToolBase)val166).get_SharedProps()).set_Caption("MIDCAP");
		((ToolPropsBase)((ToolBase)val166).get_SharedProps()).set_Width(30);
		val169.get_FontData().set_BoldAsString("True");
		val169.set_ForeColor(Color.Green);
		((AppearanceBase)val169).set_TextHAlignAsString("Left");
		((ToolPropsBase)((ToolBase)val168).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val169);
		((ToolPropsBase)((ToolBase)val168).get_SharedProps()).set_Caption("ADV");
		val171.get_FontData().set_BoldAsString("True");
		val171.set_ForeColor(Color.Red);
		((AppearanceBase)val171).set_TextHAlignAsString("Left");
		((ToolPropsBase)((ToolBase)val170).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val171);
		((ToolPropsBase)((ToolBase)val170).get_SharedProps()).set_Caption("DEC");
		val173.get_FontData().set_BoldAsString("True");
		val173.set_ForeColor(Color.Green);
		((AppearanceBase)val173).set_TextHAlignAsString("Left");
		((ToolPropsBase)((ToolBase)val172).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val173);
		((ToolPropsBase)((ToolBase)val172).get_SharedProps()).set_Caption("ADV");
		val175.get_FontData().set_BoldAsString("True");
		val175.set_ForeColor(Color.Red);
		((AppearanceBase)val175).set_TextHAlignAsString("Left");
		((ToolPropsBase)((ToolBase)val174).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val175);
		((ToolPropsBase)((ToolBase)val174).get_SharedProps()).set_Caption("DEC");
		val177.get_FontData().set_BoldAsString("True");
		((AppearanceBase)val177).set_TextHAlignAsString("Left");
		((ToolPropsBase)((ToolBase)val176).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val177);
		((ToolPropsBase)((ToolBase)val176).get_SharedProps()).set_Caption("OI PCR");
		val179.get_FontData().set_BoldAsString("True");
		((AppearanceBase)val179).set_TextHAlignAsString("Left");
		((ToolPropsBase)((ToolBase)val178).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val179);
		((ToolPropsBase)((ToolBase)val178).get_SharedProps()).set_Caption("OI PREV PCR");
		val181.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance74.Image")));
		((ToolPropsBase)((ToolBase)val180).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val181);
		((ToolPropsBase)((ToolBase)val180).get_SharedProps()).set_Caption("Block Deals");
		val183.get_FontData().set_BoldAsString("True");
		((ToolPropsBase)((ToolBase)val182).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val183);
		((ToolPropsBase)((ToolBase)val182).get_SharedProps()).set_Caption("RESTART");
		ToolbarsManager.get_Tools().AddRange((ToolBase[])(object)new ToolBase[51]
		{
			(ToolBase)val78,
			(ToolBase)val80,
			(ToolBase)val82,
			(ToolBase)val84,
			(ToolBase)val86,
			(ToolBase)val88,
			(ToolBase)val90,
			(ToolBase)val92,
			(ToolBase)val94,
			(ToolBase)val96,
			(ToolBase)val98,
			(ToolBase)val100,
			(ToolBase)val102,
			(ToolBase)val104,
			(ToolBase)val107,
			(ToolBase)val110,
			(ToolBase)val113,
			(ToolBase)val117,
			(ToolBase)val119,
			(ToolBase)val121,
			(ToolBase)val123,
			(ToolBase)val125,
			(ToolBase)val127,
			(ToolBase)val129,
			(ToolBase)val131,
			(ToolBase)val133,
			(ToolBase)val135,
			(ToolBase)val137,
			(ToolBase)val139,
			(ToolBase)val141,
			(ToolBase)val143,
			(ToolBase)val145,
			(ToolBase)val147,
			(ToolBase)val149,
			(ToolBase)val151,
			(ToolBase)val153,
			(ToolBase)val155,
			(ToolBase)val157,
			(ToolBase)val159,
			(ToolBase)val161,
			(ToolBase)val163,
			(ToolBase)val164,
			(ToolBase)val166,
			(ToolBase)val168,
			(ToolBase)val170,
			(ToolBase)val172,
			(ToolBase)val174,
			(ToolBase)val176,
			(ToolBase)val178,
			(ToolBase)val180,
			(ToolBase)val182
		});
		ToolbarsManager.set_UseLargeImagesOnMenu(true);
		ToolbarsManager.set_UseLargeImagesOnToolbar(true);
		((Control)_MDI_Toolbars_Dock_Area_Left).set_AccessibleRole((AccessibleRole)20);
		((Control)_MDI_Toolbars_Dock_Area_Left).set_BackColor(Color.FromArgb(191, 219, 255));
		_MDI_Toolbars_Dock_Area_Left.set_DockedPosition((DockedPosition)2);
		((Control)_MDI_Toolbars_Dock_Area_Left).set_ForeColor(SystemColors.ControlText);
		_MDI_Toolbars_Dock_Area_Left.set_InitialResizeAreaExtent(4);
		UltraToolbarsDockArea mDI_Toolbars_Dock_Area_Left = _MDI_Toolbars_Dock_Area_Left;
		Point location = new Point(0, 147);
		((Control)mDI_Toolbars_Dock_Area_Left).set_Location(location);
		((Control)_MDI_Toolbars_Dock_Area_Left).set_Name("_MDI_Toolbars_Dock_Area_Left");
		UltraToolbarsDockArea mDI_Toolbars_Dock_Area_Left2 = _MDI_Toolbars_Dock_Area_Left;
		Size size = new Size(4, 533);
		((Control)mDI_Toolbars_Dock_Area_Left2).set_Size(size);
		_MDI_Toolbars_Dock_Area_Left.set_ToolbarsManager(ToolbarsManager);
		((Control)_MDI_Toolbars_Dock_Area_Right).set_AccessibleRole((AccessibleRole)20);
		((Control)_MDI_Toolbars_Dock_Area_Right).set_BackColor(Color.FromArgb(191, 219, 255));
		_MDI_Toolbars_Dock_Area_Right.set_DockedPosition((DockedPosition)3);
		((Control)_MDI_Toolbars_Dock_Area_Right).set_ForeColor(SystemColors.ControlText);
		_MDI_Toolbars_Dock_Area_Right.set_InitialResizeAreaExtent(4);
		UltraToolbarsDockArea mDI_Toolbars_Dock_Area_Right = _MDI_Toolbars_Dock_Area_Right;
		location = new Point(1280, 147);
		((Control)mDI_Toolbars_Dock_Area_Right).set_Location(location);
		((Control)_MDI_Toolbars_Dock_Area_Right).set_Name("_MDI_Toolbars_Dock_Area_Right");
		UltraToolbarsDockArea mDI_Toolbars_Dock_Area_Right2 = _MDI_Toolbars_Dock_Area_Right;
		size = new Size(4, 533);
		((Control)mDI_Toolbars_Dock_Area_Right2).set_Size(size);
		_MDI_Toolbars_Dock_Area_Right.set_ToolbarsManager(ToolbarsManager);
		((Control)_MDI_Toolbars_Dock_Area_Top).set_AccessibleRole((AccessibleRole)20);
		((Control)_MDI_Toolbars_Dock_Area_Top).set_BackColor(Color.FromArgb(191, 219, 255));
		_MDI_Toolbars_Dock_Area_Top.set_DockedPosition((DockedPosition)0);
		((Control)_MDI_Toolbars_Dock_Area_Top).set_ForeColor(SystemColors.ControlText);
		UltraToolbarsDockArea mDI_Toolbars_Dock_Area_Top = _MDI_Toolbars_Dock_Area_Top;
		location = new Point(0, 0);
		((Control)mDI_Toolbars_Dock_Area_Top).set_Location(location);
		((Control)_MDI_Toolbars_Dock_Area_Top).set_Name("_MDI_Toolbars_Dock_Area_Top");
		UltraToolbarsDockArea mDI_Toolbars_Dock_Area_Top2 = _MDI_Toolbars_Dock_Area_Top;
		size = new Size(1284, 147);
		((Control)mDI_Toolbars_Dock_Area_Top2).set_Size(size);
		_MDI_Toolbars_Dock_Area_Top.set_ToolbarsManager(ToolbarsManager);
		((Control)_MDI_Toolbars_Dock_Area_Bottom).set_AccessibleRole((AccessibleRole)20);
		((Control)_MDI_Toolbars_Dock_Area_Bottom).set_BackColor(Color.FromArgb(191, 219, 255));
		_MDI_Toolbars_Dock_Area_Bottom.set_DockedPosition((DockedPosition)1);
		((Control)_MDI_Toolbars_Dock_Area_Bottom).set_ForeColor(SystemColors.ControlText);
		UltraToolbarsDockArea mDI_Toolbars_Dock_Area_Bottom = _MDI_Toolbars_Dock_Area_Bottom;
		location = new Point(0, 680);
		((Control)mDI_Toolbars_Dock_Area_Bottom).set_Location(location);
		((Control)_MDI_Toolbars_Dock_Area_Bottom).set_Name("_MDI_Toolbars_Dock_Area_Bottom");
		UltraToolbarsDockArea mDI_Toolbars_Dock_Area_Bottom2 = _MDI_Toolbars_Dock_Area_Bottom;
		size = new Size(1284, 0);
		((Control)mDI_Toolbars_Dock_Area_Bottom2).set_Size(size);
		_MDI_Toolbars_Dock_Area_Bottom.set_ToolbarsManager(ToolbarsManager);
		UltraStatusBar1.set_BorderStylePanel((UIElementBorderStyle)12);
		((Control)UltraStatusBar1).set_ContextMenuStrip(ContextMenuStrip2);
		UltraStatusBar ultraStatusBar = UltraStatusBar1;
		location = new Point(0, 680);
		((Control)ultraStatusBar).set_Location(location);
		((Control)UltraStatusBar1).set_Name("UltraStatusBar1");
		val185.set_ImageBackground((Image)componentResourceManager.GetObject("Appearance76.ImageBackground"));
		val185.set_ImageBackgroundDisabled((Image)componentResourceManager.GetObject("Appearance76.ImageBackgroundDisabled"));
		val184.set_Appearance((AppearanceBase)(object)val185);
		val184.set_Enabled(false);
		val184.set_Width(30);
		((AppearanceBase)val187).set_TextHAlignAsString("Center");
		val186.set_Appearance((AppearanceBase)(object)val187);
		val186.set_Text("Disconnected");
		val186.set_Visible(false);
		val186.set_Width(85);
		((AppearanceBase)val189).set_TextHAlignAsString("Center");
		val188.set_Appearance((AppearanceBase)(object)val189);
		val188.get_MarqueeInfo().set_Delay(10);
		val188.set_Style((PanelStyle)7);
		val188.set_Text("Powered by Network18");
		val188.set_Width(140);
		((AppearanceBase)val191).set_TextHAlignAsString("Center");
		val190.set_Appearance((AppearanceBase)(object)val191);
		val190.set_Width(135);
		((AppearanceBase)val193).set_TextHAlignAsString("Center");
		val192.set_Appearance((AppearanceBase)(object)val193);
		val192.set_DateTimeFormat("dd MMM yyyy hh:mm:ss tt");
		val192.set_Style((PanelStyle)12);
		val192.set_Width(160);
		val195.set_ImageBackground((Image)componentResourceManager.GetObject("Appearance81.ImageBackground"));
		val195.set_ImageBackgroundDisabled((Image)componentResourceManager.GetObject("Appearance81.ImageBackgroundDisabled"));
		val195.set_ImageBackgroundStyle((ImageBackgroundStyle)1);
		val194.set_Appearance((AppearanceBase)(object)val195);
		val194.set_BorderStyle((UIElementBorderStyle)1);
		val194.set_Visible(false);
		val194.set_Width(30);
		val197.get_FontData().set_BoldAsString("True");
		val197.set_ForeColor(Color.Red);
		((AppearanceBase)val197).set_TextHAlignAsString("Center");
		val196.set_Appearance((AppearanceBase)(object)val197);
		val196.set_Text("0");
		val196.set_Width(25);
		val199.get_FontData().set_BoldAsString("True");
		val199.get_FontData().set_SizeInPoints(2f);
		val199.set_ForeColor(Color.Green);
		((AppearanceBase)val199).set_TextHAlignAsString("Center");
		val198.set_Appearance((AppearanceBase)(object)val199);
		val198.set_Text("Data");
		val198.set_Visible(false);
		val198.set_Width(25);
		val201.get_FontData().set_Name("Verdana");
		val201.get_FontData().set_StrikeoutAsString("False");
		val200.set_Appearance((AppearanceBase)(object)val201);
		val200.set_Text("String");
		val200.set_Width(300);
		val202.set_Text("Data");
		val202.set_Visible(false);
		val202.set_Width(300);
		UltraStatusBar1.get_Panels().AddRange((UltraStatusPanel[])(object)new UltraStatusPanel[10] { val184, val186, val188, val190, val192, val194, val196, val198, val200, val202 });
		UltraStatusBar ultraStatusBar2 = UltraStatusBar1;
		size = new Size(1284, 36);
		((Control)ultraStatusBar2).set_Size(size);
		((Control)UltraStatusBar1).set_TabIndex(6);
		UltraStatusBar1.set_ViewStyle((ViewStyle)4);
		((ToolStripDropDown)ContextMenuStrip2).set_Font(new Font("Verdana", 8.25f));
		((ToolStrip)ContextMenuStrip2).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ShowDataToolStripMenuItem });
		((Control)ContextMenuStrip2).set_Name("ContextMenuStrip1");
		ContextMenuStrip contextMenuStrip = ContextMenuStrip2;
		size = new Size(153, 42);
		((Control)contextMenuStrip).set_Size(size);
		((ToolStripItem)ShowDataToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("ShowDataToolStripMenuItem.Image"));
		((ToolStripItem)ShowDataToolStripMenuItem).set_ImageScaling((ToolStripItemImageScaling)0);
		((ToolStripItem)ShowDataToolStripMenuItem).set_Name("ShowDataToolStripMenuItem");
		ToolStripMenuItem showDataToolStripMenuItem = ShowDataToolStripMenuItem;
		size = new Size(152, 38);
		((ToolStripItem)showDataToolStripMenuItem).set_Size(size);
		((ToolStripItem)ShowDataToolStripMenuItem).set_Text("Show Data");
		UltraToolbarsManager2.set_DesignerFlags(1);
		((ToolStripDropDown)ContextMenuStrip1).set_Font(new Font("Verdana", 8.25f));
		((ToolStrip)ContextMenuStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)AddToFavouritesToolStripMenuItem });
		((Control)ContextMenuStrip1).set_Name("ContextMenuStrip1");
		ContextMenuStrip contextMenuStrip2 = ContextMenuStrip1;
		size = new Size(198, 42);
		((Control)contextMenuStrip2).set_Size(size);
		((ToolStripItem)AddToFavouritesToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("AddToFavouritesToolStripMenuItem.Image"));
		((ToolStripItem)AddToFavouritesToolStripMenuItem).set_ImageScaling((ToolStripItemImageScaling)0);
		((ToolStripItem)AddToFavouritesToolStripMenuItem).set_Name("AddToFavouritesToolStripMenuItem");
		ToolStripMenuItem addToFavouritesToolStripMenuItem = AddToFavouritesToolStripMenuItem;
		size = new Size(197, 38);
		((ToolStripItem)addToFavouritesToolStripMenuItem).set_Size(size);
		((ToolStripItem)AddToFavouritesToolStripMenuItem).set_Text("Manage Favourites");
		((Control)UltraGroupBox1).set_ContextMenuStrip(ContextMenuStrip1);
		((Control)UltraGroupBox1).get_Controls().Add((Control)(object)grFavourite5);
		((Control)UltraGroupBox1).get_Controls().Add((Control)(object)grFavourite4);
		((Control)UltraGroupBox1).get_Controls().Add((Control)(object)grFavourite3);
		((Control)UltraGroupBox1).get_Controls().Add((Control)(object)grFavourite2);
		((Control)UltraGroupBox1).get_Controls().Add((Control)(object)grFavourite1);
		((Control)UltraGroupBox1).set_Dock((DockStyle)1);
		UltraGroupBox ultraGroupBox = UltraGroupBox1;
		location = new Point(4, 147);
		((Control)ultraGroupBox).set_Location(location);
		((Control)UltraGroupBox1).set_Name("UltraGroupBox1");
		UltraGroupBox ultraGroupBox2 = UltraGroupBox1;
		size = new Size(1276, 50);
		((Control)ultraGroupBox2).set_Size(size);
		((Control)UltraGroupBox1).set_TabIndex(10);
		UltraGroupBox1.set_ViewStyle((GroupBoxViewStyle)3);
		grFavourite5.set_BorderStyle((GroupBoxBorderStyle)13);
		grFavourite5.set_CaptionAlignment((GroupBoxCaptionAlignment)1);
		((Control)grFavourite5).set_ContextMenuStrip(ContextMenuStrip1);
		((Control)grFavourite5).get_Controls().Add((Control)(object)lbl_CL5);
		((Control)grFavourite5).get_Controls().Add((Control)(object)lbl_PC5);
		((Control)grFavourite5).get_Controls().Add((Control)(object)lbl_C5);
		((Control)grFavourite5).get_Controls().Add((Control)(object)lbl_LP5);
		((Control)grFavourite5).set_Dock((DockStyle)3);
		((Control)grFavourite5).set_Font(new Font("Verdana", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		val203.set_ForeColor(Color.Black);
		grFavourite5.set_HeaderAppearance((AppearanceBase)(object)val203);
		grFavourite5.set_HeaderBorderStyle((UIElementBorderStyle)12);
		grFavourite5.set_HeaderPosition((GroupBoxHeaderPosition)3);
		UltraGroupBox obj = grFavourite5;
		location = new Point(859, 0);
		((Control)obj).set_Location(location);
		((Control)grFavourite5).set_Name("grFavourite5");
		UltraGroupBox obj2 = grFavourite5;
		size = new Size(214, 47);
		((Control)obj2).set_Size(size);
		((Control)grFavourite5).set_TabIndex(1);
		grFavourite5.set_Text("FAV");
		grFavourite5.set_ViewStyle((GroupBoxViewStyle)3);
		((Control)lbl_CL5).set_BackColor(Color.Transparent);
		Label obj3 = lbl_CL5;
		location = new Point(132, 3);
		((Control)obj3).set_Location(location);
		((Control)lbl_CL5).set_Name("lbl_CL5");
		Label obj4 = lbl_CL5;
		size = new Size(40, 13);
		((Control)obj4).set_Size(size);
		((Control)lbl_CL5).set_TabIndex(9);
		lbl_CL5.set_Text("CNBC");
		((Control)lbl_CL5).set_Visible(false);
		((Control)lbl_PC5).set_BackColor(Color.Transparent);
		Label obj5 = lbl_PC5;
		location = new Point(150, 28);
		((Control)obj5).set_Location(location);
		((Control)lbl_PC5).set_Name("lbl_PC5");
		Label obj6 = lbl_PC5;
		size = new Size(60, 13);
		((Control)obj6).set_Size(size);
		((Control)lbl_PC5).set_TabIndex(7);
		lbl_PC5.set_Text("CNBC");
		((Control)lbl_C5).set_BackColor(Color.Transparent);
		Label obj7 = lbl_C5;
		location = new Point(78, 28);
		((Control)obj7).set_Location(location);
		((Control)lbl_C5).set_Name("lbl_C5");
		Label obj8 = lbl_C5;
		size = new Size(60, 13);
		((Control)obj8).set_Size(size);
		((Control)lbl_C5).set_TabIndex(6);
		lbl_C5.set_Text("CNBC");
		((Control)lbl_LP5).set_BackColor(Color.Transparent);
		Label obj9 = lbl_LP5;
		location = new Point(6, 28);
		((Control)obj9).set_Location(location);
		((Control)lbl_LP5).set_Name("lbl_LP5");
		Label obj10 = lbl_LP5;
		size = new Size(60, 13);
		((Control)obj10).set_Size(size);
		((Control)lbl_LP5).set_TabIndex(5);
		lbl_LP5.set_Text("CNBC");
		grFavourite4.set_BorderStyle((GroupBoxBorderStyle)13);
		grFavourite4.set_CaptionAlignment((GroupBoxCaptionAlignment)1);
		((Control)grFavourite4).set_ContextMenuStrip(ContextMenuStrip1);
		((Control)grFavourite4).get_Controls().Add((Control)(object)lbl_CL4);
		((Control)grFavourite4).get_Controls().Add((Control)(object)lbl_PC4);
		((Control)grFavourite4).get_Controls().Add((Control)(object)lbl_C4);
		((Control)grFavourite4).get_Controls().Add((Control)(object)lbl_LP4);
		((Control)grFavourite4).set_Dock((DockStyle)3);
		((Control)grFavourite4).set_Font(new Font("Verdana", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		val204.set_ForeColor(Color.Black);
		grFavourite4.set_HeaderAppearance((AppearanceBase)(object)val204);
		grFavourite4.set_HeaderBorderStyle((UIElementBorderStyle)12);
		grFavourite4.set_HeaderPosition((GroupBoxHeaderPosition)3);
		UltraGroupBox obj11 = grFavourite4;
		location = new Point(645, 0);
		((Control)obj11).set_Location(location);
		((Control)grFavourite4).set_Name("grFavourite4");
		UltraGroupBox obj12 = grFavourite4;
		size = new Size(214, 47);
		((Control)obj12).set_Size(size);
		((Control)grFavourite4).set_TabIndex(1);
		grFavourite4.set_Text("FAV");
		grFavourite4.set_ViewStyle((GroupBoxViewStyle)3);
		((Control)lbl_CL4).set_BackColor(Color.Transparent);
		Label obj13 = lbl_CL4;
		location = new Point(133, 3);
		((Control)obj13).set_Location(location);
		((Control)lbl_CL4).set_Name("lbl_CL4");
		Label obj14 = lbl_CL4;
		size = new Size(40, 13);
		((Control)obj14).set_Size(size);
		((Control)lbl_CL4).set_TabIndex(8);
		lbl_CL4.set_Text("CNBC");
		((Control)lbl_CL4).set_Visible(false);
		((Control)lbl_PC4).set_BackColor(Color.Transparent);
		Label obj15 = lbl_PC4;
		location = new Point(149, 28);
		((Control)obj15).set_Location(location);
		((Control)lbl_PC4).set_Name("lbl_PC4");
		Label obj16 = lbl_PC4;
		size = new Size(60, 13);
		((Control)obj16).set_Size(size);
		((Control)lbl_PC4).set_TabIndex(7);
		lbl_PC4.set_Text("CNBC");
		((Control)lbl_C4).set_BackColor(Color.Transparent);
		Label obj17 = lbl_C4;
		location = new Point(77, 28);
		((Control)obj17).set_Location(location);
		((Control)lbl_C4).set_Name("lbl_C4");
		Label obj18 = lbl_C4;
		size = new Size(60, 13);
		((Control)obj18).set_Size(size);
		((Control)lbl_C4).set_TabIndex(6);
		lbl_C4.set_Text("CNBC");
		((Control)lbl_LP4).set_BackColor(Color.Transparent);
		Label obj19 = lbl_LP4;
		location = new Point(5, 28);
		((Control)obj19).set_Location(location);
		((Control)lbl_LP4).set_Name("lbl_LP4");
		Label obj20 = lbl_LP4;
		size = new Size(60, 13);
		((Control)obj20).set_Size(size);
		((Control)lbl_LP4).set_TabIndex(5);
		lbl_LP4.set_Text("CNBC");
		grFavourite3.set_BorderStyle((GroupBoxBorderStyle)13);
		grFavourite3.set_CaptionAlignment((GroupBoxCaptionAlignment)1);
		((Control)grFavourite3).set_ContextMenuStrip(ContextMenuStrip1);
		((Control)grFavourite3).get_Controls().Add((Control)(object)lbl_CL3);
		((Control)grFavourite3).get_Controls().Add((Control)(object)lbl_PC3);
		((Control)grFavourite3).get_Controls().Add((Control)(object)lbl_C3);
		((Control)grFavourite3).get_Controls().Add((Control)(object)lbl_LP3);
		((Control)grFavourite3).set_Dock((DockStyle)3);
		((Control)grFavourite3).set_Font(new Font("Verdana", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		val205.set_ForeColor(Color.Black);
		grFavourite3.set_HeaderAppearance((AppearanceBase)(object)val205);
		grFavourite3.set_HeaderBorderStyle((UIElementBorderStyle)12);
		grFavourite3.set_HeaderPosition((GroupBoxHeaderPosition)3);
		UltraGroupBox obj21 = grFavourite3;
		location = new Point(431, 0);
		((Control)obj21).set_Location(location);
		((Control)grFavourite3).set_Name("grFavourite3");
		UltraGroupBox obj22 = grFavourite3;
		size = new Size(214, 47);
		((Control)obj22).set_Size(size);
		((Control)grFavourite3).set_TabIndex(1);
		grFavourite3.set_Text("FAV");
		grFavourite3.set_ViewStyle((GroupBoxViewStyle)3);
		((Control)lbl_CL3).set_BackColor(Color.Transparent);
		Label obj23 = lbl_CL3;
		location = new Point(138, 3);
		((Control)obj23).set_Location(location);
		((Control)lbl_CL3).set_Name("lbl_CL3");
		Label obj24 = lbl_CL3;
		size = new Size(40, 13);
		((Control)obj24).set_Size(size);
		((Control)lbl_CL3).set_TabIndex(8);
		lbl_CL3.set_Text("CNBC");
		((Control)lbl_CL3).set_Visible(false);
		((Control)lbl_PC3).set_BackColor(Color.Transparent);
		Label obj25 = lbl_PC3;
		location = new Point(149, 28);
		((Control)obj25).set_Location(location);
		((Control)lbl_PC3).set_Name("lbl_PC3");
		Label obj26 = lbl_PC3;
		size = new Size(60, 13);
		((Control)obj26).set_Size(size);
		((Control)lbl_PC3).set_TabIndex(7);
		lbl_PC3.set_Text("CNBC");
		((Control)lbl_C3).set_BackColor(Color.Transparent);
		Label obj27 = lbl_C3;
		location = new Point(78, 28);
		((Control)obj27).set_Location(location);
		((Control)lbl_C3).set_Name("lbl_C3");
		Label obj28 = lbl_C3;
		size = new Size(60, 13);
		((Control)obj28).set_Size(size);
		((Control)lbl_C3).set_TabIndex(6);
		lbl_C3.set_Text("CNBC");
		((Control)lbl_LP3).set_BackColor(Color.Transparent);
		Label obj29 = lbl_LP3;
		location = new Point(6, 28);
		((Control)obj29).set_Location(location);
		((Control)lbl_LP3).set_Name("lbl_LP3");
		Label obj30 = lbl_LP3;
		size = new Size(60, 13);
		((Control)obj30).set_Size(size);
		((Control)lbl_LP3).set_TabIndex(5);
		lbl_LP3.set_Text("CNBC");
		grFavourite2.set_BorderStyle((GroupBoxBorderStyle)13);
		grFavourite2.set_CaptionAlignment((GroupBoxCaptionAlignment)1);
		((Control)grFavourite2).set_ContextMenuStrip(ContextMenuStrip1);
		((Control)grFavourite2).get_Controls().Add((Control)(object)lbl_CL2);
		((Control)grFavourite2).get_Controls().Add((Control)(object)lbl_PC2);
		((Control)grFavourite2).get_Controls().Add((Control)(object)lbl_C2);
		((Control)grFavourite2).get_Controls().Add((Control)(object)lbl_LP2);
		((Control)grFavourite2).set_Dock((DockStyle)3);
		((Control)grFavourite2).set_Font(new Font("Verdana", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		val206.set_ForeColor(Color.Black);
		grFavourite2.set_HeaderAppearance((AppearanceBase)(object)val206);
		grFavourite2.set_HeaderBorderStyle((UIElementBorderStyle)12);
		grFavourite2.set_HeaderPosition((GroupBoxHeaderPosition)3);
		UltraGroupBox obj31 = grFavourite2;
		location = new Point(217, 0);
		((Control)obj31).set_Location(location);
		((Control)grFavourite2).set_Name("grFavourite2");
		UltraGroupBox obj32 = grFavourite2;
		size = new Size(214, 47);
		((Control)obj32).set_Size(size);
		((Control)grFavourite2).set_TabIndex(1);
		grFavourite2.set_Text("FAV");
		grFavourite2.set_ViewStyle((GroupBoxViewStyle)3);
		((Control)lbl_CL2).set_BackColor(Color.Transparent);
		Label obj33 = lbl_CL2;
		location = new Point(141, 3);
		((Control)obj33).set_Location(location);
		((Control)lbl_CL2).set_Name("lbl_CL2");
		Label obj34 = lbl_CL2;
		size = new Size(40, 13);
		((Control)obj34).set_Size(size);
		((Control)lbl_CL2).set_TabIndex(8);
		lbl_CL2.set_Text("CNBC");
		((Control)lbl_CL2).set_Visible(false);
		((Control)lbl_PC2).set_BackColor(Color.Transparent);
		Label obj35 = lbl_PC2;
		location = new Point(149, 28);
		((Control)obj35).set_Location(location);
		((Control)lbl_PC2).set_Name("lbl_PC2");
		Label obj36 = lbl_PC2;
		size = new Size(60, 13);
		((Control)obj36).set_Size(size);
		((Control)lbl_PC2).set_TabIndex(7);
		lbl_PC2.set_Text("CNBC");
		((Control)lbl_C2).set_BackColor(Color.Transparent);
		Label obj37 = lbl_C2;
		location = new Point(77, 28);
		((Control)obj37).set_Location(location);
		((Control)lbl_C2).set_Name("lbl_C2");
		Label obj38 = lbl_C2;
		size = new Size(60, 13);
		((Control)obj38).set_Size(size);
		((Control)lbl_C2).set_TabIndex(6);
		lbl_C2.set_Text("CNBC");
		((Control)lbl_LP2).set_BackColor(Color.Transparent);
		Label obj39 = lbl_LP2;
		location = new Point(5, 28);
		((Control)obj39).set_Location(location);
		((Control)lbl_LP2).set_Name("lbl_LP2");
		Label obj40 = lbl_LP2;
		size = new Size(60, 13);
		((Control)obj40).set_Size(size);
		((Control)lbl_LP2).set_TabIndex(5);
		lbl_LP2.set_Text("CNBC");
		grFavourite1.set_BorderStyle((GroupBoxBorderStyle)13);
		grFavourite1.set_CaptionAlignment((GroupBoxCaptionAlignment)1);
		((Control)grFavourite1).set_ContextMenuStrip(ContextMenuStrip1);
		((Control)grFavourite1).get_Controls().Add((Control)(object)lbl_CL1);
		((Control)grFavourite1).get_Controls().Add((Control)(object)lbl_PC1);
		((Control)grFavourite1).get_Controls().Add((Control)(object)lbl_C1);
		((Control)grFavourite1).get_Controls().Add((Control)(object)lbl_LP1);
		((Control)grFavourite1).set_Dock((DockStyle)3);
		((Control)grFavourite1).set_Font(new Font("Verdana", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		val207.set_ForeColor(Color.Black);
		grFavourite1.set_HeaderAppearance((AppearanceBase)(object)val207);
		grFavourite1.set_HeaderBorderStyle((UIElementBorderStyle)12);
		grFavourite1.set_HeaderPosition((GroupBoxHeaderPosition)3);
		UltraGroupBox obj41 = grFavourite1;
		location = new Point(3, 0);
		((Control)obj41).set_Location(location);
		((Control)grFavourite1).set_Name("grFavourite1");
		UltraGroupBox obj42 = grFavourite1;
		size = new Size(214, 47);
		((Control)obj42).set_Size(size);
		((Control)grFavourite1).set_TabIndex(0);
		grFavourite1.set_Text("FAV");
		grFavourite1.set_ViewStyle((GroupBoxViewStyle)3);
		((Control)lbl_CL1).set_BackColor(Color.Transparent);
		Label obj43 = lbl_CL1;
		location = new Point(136, 3);
		((Control)obj43).set_Location(location);
		((Control)lbl_CL1).set_Name("lbl_CL1");
		Label obj44 = lbl_CL1;
		size = new Size(40, 13);
		((Control)obj44).set_Size(size);
		((Control)lbl_CL1).set_TabIndex(5);
		lbl_CL1.set_Text("CNBC");
		((Control)lbl_CL1).set_Visible(false);
		((Control)lbl_PC1).set_BackColor(Color.Transparent);
		Label obj45 = lbl_PC1;
		location = new Point(149, 28);
		((Control)obj45).set_Location(location);
		((Control)lbl_PC1).set_Name("lbl_PC1");
		Label obj46 = lbl_PC1;
		size = new Size(60, 13);
		((Control)obj46).set_Size(size);
		((Control)lbl_PC1).set_TabIndex(4);
		lbl_PC1.set_Text("CNBC");
		((Control)lbl_C1).set_BackColor(Color.Transparent);
		Label obj47 = lbl_C1;
		location = new Point(76, 28);
		((Control)obj47).set_Location(location);
		((Control)lbl_C1).set_Name("lbl_C1");
		Label obj48 = lbl_C1;
		size = new Size(60, 13);
		((Control)obj48).set_Size(size);
		((Control)lbl_C1).set_TabIndex(3);
		lbl_C1.set_Text("CNBC");
		((Control)lbl_LP1).set_BackColor(Color.Transparent);
		Label obj49 = lbl_LP1;
		location = new Point(5, 28);
		((Control)obj49).set_Location(location);
		((Control)lbl_LP1).set_Name("lbl_LP1");
		Label obj50 = lbl_LP1;
		size = new Size(60, 13);
		((Control)obj50).set_Size(size);
		((Control)lbl_LP1).set_TabIndex(1);
		lbl_LP1.set_Text("CNBC");
		PowerUDP.set_Editor((object)PowerUDP);
		tmr_Streaming.set_Interval(60000);
		SizeF autoScaleDimensions = new SizeF(7f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.AliceBlue);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)2);
		size = new Size(1284, 716);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)UltraGroupBox1);
		((Control)this).get_Controls().Add((Control)(object)_MDI_Toolbars_Dock_Area_Left);
		((Control)this).get_Controls().Add((Control)(object)_MDI_Toolbars_Dock_Area_Right);
		((Control)this).get_Controls().Add((Control)(object)_MDI_Toolbars_Dock_Area_Top);
		((Control)this).get_Controls().Add((Control)(object)_MDI_Toolbars_Dock_Area_Bottom);
		((Control)this).get_Controls().Add((Control)(object)UltraStatusBar1);
		((Control)this).set_DoubleBuffered(true);
		((Control)this).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_IsMdiContainer(true);
		((Control)this).set_Name("MDIParent");
		((Form)this).set_Text("CNBC Money 2010  :: 14 OCTOBER 2010 1054");
		((Form)this).set_WindowState((FormWindowState)2);
		((ISupportInitialize)UltraTabbedMdiManager1).EndInit();
		((ISupportInitialize)ToolbarsManager).EndInit();
		((Control)ContextMenuStrip2).ResumeLayout(false);
		((ISupportInitialize)UltraToolbarsManager2).EndInit();
		((Control)ContextMenuStrip1).ResumeLayout(false);
		((ISupportInitialize)UltraGroupBox1).EndInit();
		((Control)UltraGroupBox1).ResumeLayout(false);
		((ISupportInitialize)grFavourite5).EndInit();
		((Control)grFavourite5).ResumeLayout(false);
		((ISupportInitialize)grFavourite4).EndInit();
		((Control)grFavourite4).ResumeLayout(false);
		((ISupportInitialize)grFavourite3).EndInit();
		((Control)grFavourite3).ResumeLayout(false);
		((ISupportInitialize)grFavourite2).EndInit();
		((Control)grFavourite2).ResumeLayout(false);
		((ISupportInitialize)grFavourite1).EndInit();
		((Control)grFavourite1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern bool SetSystemCursor(IntPtr hCursor, int id);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr LoadCursorFromFileA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName);

	private void MDIParent_Activated(object sender, EventArgs e)
	{
		((Form)this).set_WindowState((FormWindowState)2);
	}

	private void MDIParent_Load(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).Hide();
		frmLogin frmLogin2 = new frmLogin();
		((Form)frmLogin2).ShowDialog();
		((Control)this).Show();
		File.GetLastWriteTime(Application.get_StartupPath() + "/CNBC_MONEY_2009.exe").ToString("dd MMM yyyy hhmmss");
		if (Operators.CompareString(mdlMain.gUserName, "", false) == 0)
		{
			ProjectData.EndApp();
		}
		Initialize();
		UltraStatusBar1.get_Panels().get_Item(3).set_Text(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Interaction.IIf(mdlMain.gExternal, (object)"Ext", (object)""), (object)mdlMain.gDomain), (object)" : "), (object)mdlMain.gUserName)));
		BindMarketWatch();
		BindFavourites();
		Update_Menu();
		FirstLogin();
		PowerUDP_Connect();
		SendToBroadCast();
		tmr_Streaming.set_Enabled(true);
	}

	private void MDIParent_KeyUp(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 116)
		{
			BindMarketWatch();
			BindFavourites();
		}
	}

	private void MDIParent_FormClosed(object sender, FormClosedEventArgs e)
	{
		PowerUDP.Close();
		((Component)(object)PowerUDP).Dispose();
		objEquity = new clsEquity();
		objEquity.DisConnectUser();
	}

	private void fEquity1_MarketWatch()
	{
		BindMarketWatch();
		BindFavourites();
	}

	private void fEquity2_MarketWatch()
	{
		BindMarketWatch();
		BindFavourites();
	}

	private void fEquity3_MarketWatch()
	{
		BindMarketWatch();
		BindFavourites();
	}

	private void fEquity4_MarketWatch()
	{
		BindMarketWatch();
		BindFavourites();
	}

	private void fEquity5_MarketWatch()
	{
		BindMarketWatch();
		BindFavourites();
	}

	private void fEquity1_Rename_MDI_Tab(string strTabName)
	{
		UltraTabbedMdiManager1.get_ActiveTab().get_Form().set_Text(strTabName);
		ToolbarsManager.BeginUpdate();
		((ToolPropsBase)((ToolsCollectionBase)ToolbarsManager.get_Tools()).get_Item(((KeyedSubObjectBase)UltraTabbedMdiManager1.get_ActiveTab()).get_Key()).get_SharedProps()).set_Caption(strTabName);
		((UltraComponentControlManagerBase)ToolbarsManager).EndUpdate();
	}

	private void fEquity2_Rename_MDI_Tab(string strTabName)
	{
		UltraTabbedMdiManager1.get_ActiveTab().get_Form().set_Text(strTabName);
		((ToolPropsBase)((ToolsCollectionBase)ToolbarsManager.get_Tools()).get_Item(((KeyedSubObjectBase)UltraTabbedMdiManager1.get_ActiveTab()).get_Key()).get_SharedProps()).set_Caption(strTabName);
	}

	private void fEquity3_Rename_MDI_Tab(string strTabName)
	{
		UltraTabbedMdiManager1.get_ActiveTab().get_Form().set_Text(strTabName);
		((ToolPropsBase)((ToolsCollectionBase)ToolbarsManager.get_Tools()).get_Item(((KeyedSubObjectBase)UltraTabbedMdiManager1.get_ActiveTab()).get_Key()).get_SharedProps()).set_Caption(strTabName);
	}

	private void fEquity4_Rename_MDI_Tab(string strTabName)
	{
		UltraTabbedMdiManager1.get_ActiveTab().get_Form().set_Text(strTabName);
		((ToolPropsBase)((ToolsCollectionBase)ToolbarsManager.get_Tools()).get_Item(((KeyedSubObjectBase)UltraTabbedMdiManager1.get_ActiveTab()).get_Key()).get_SharedProps()).set_Caption(strTabName);
	}

	private void fEquity5_Rename_MDI_Tab(string strTabName)
	{
		UltraTabbedMdiManager1.get_ActiveTab().get_Form().set_Text(strTabName);
		((ToolPropsBase)((ToolsCollectionBase)ToolbarsManager.get_Tools()).get_Item(((KeyedSubObjectBase)UltraTabbedMdiManager1.get_ActiveTab()).get_Key()).get_SharedProps()).set_Caption(strTabName);
	}

	private void fEquity1_SendToBroadCast()
	{
		SendToBroadCast();
	}

	private void fEquity2_SendToBroadCast()
	{
		SendToBroadCast();
	}

	private void fEquity3_SendToBroadCast()
	{
		SendToBroadCast();
	}

	private void fEquity4_SendToBroadCast()
	{
		SendToBroadCast();
	}

	private void fEquity5_SendToBroadCast()
	{
		SendToBroadCast();
	}

	private void fFavourites_Refresh_Favourites()
	{
		BindFavourites();
	}

	private void UltraToolbarsManager1_AfterToolActivate(object sender, ToolEventArgs e)
	{
	}

	private void UltraToolbarsManager1_AfterToolExitEditMode(object sender, AfterToolExitEditModeEventArgs e)
	{
		string text = Strings.UCase(((CancelableToolEventArgs)e).get_Tool().get_Key());
		if (Operators.CompareString(text, "EQUITY", false) == 0)
		{
		}
	}

	private void UltraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		if (Check_If_TabExists(((ToolPropsBase)((ToolEventArgs)e).get_Tool().get_SharedProps()).get_Caption(), ((ToolEventArgs)e).get_Tool().get_Key()))
		{
			return;
		}
		EquityKey = ((ToolEventArgs)e).get_Tool().get_Key();
		switch (Strings.UCase(((ToolEventArgs)e).get_Tool().get_Key()))
		{
		case "COLORSCHEMELIST":
		{
			ListToolItem selectedItem = ((ListTool)((ToolEventArgs)e).get_Tool()).get_SelectedItem();
			if (selectedItem != null)
			{
				Office2007ColorTable.set_ColorScheme((Office2007ColorScheme)Conversions.ToInteger(selectedItem.get_Value()));
				mdlMain.INIWrite(Application.get_StartupPath() + "/Money_Config.ini", "MAIN", "COLOR_SCHEME", Conversions.ToString(selectedItem.get_Value()));
				objEquity = new clsEquity();
				objEquity.UpdateSettingsToDB();
			}
			break;
		}
		case "1":
			fEquity1 = new frmEquity();
			fEquity1.Tab_Index = Conversions.ToInteger(((ToolEventArgs)e).get_Tool().get_Key());
			fEquity1.Tab_Name = ((ToolPropsBase)((ToolEventArgs)e).get_Tool().get_SharedProps()).get_Caption();
			ShowEquityForm((Form)(object)fEquity1, Conversions.ToInteger(((ToolEventArgs)e).get_Tool().get_Key()), ((ToolPropsBase)((ToolEventArgs)e).get_Tool().get_SharedProps()).get_Caption());
			break;
		case "2":
			fEquity2 = new frmEquity();
			fEquity2.Tab_Index = Conversions.ToInteger(((ToolEventArgs)e).get_Tool().get_Key());
			fEquity2.Tab_Name = ((ToolPropsBase)((ToolEventArgs)e).get_Tool().get_SharedProps()).get_Caption();
			ShowEquityForm((Form)(object)fEquity2, Conversions.ToInteger(((ToolEventArgs)e).get_Tool().get_Key()), ((ToolPropsBase)((ToolEventArgs)e).get_Tool().get_SharedProps()).get_Caption());
			break;
		case "3":
			fEquity3 = new frmEquity();
			fEquity3.Tab_Index = Conversions.ToInteger(((ToolEventArgs)e).get_Tool().get_Key());
			fEquity3.Tab_Name = ((ToolPropsBase)((ToolEventArgs)e).get_Tool().get_SharedProps()).get_Caption();
			ShowEquityForm((Form)(object)fEquity3, Conversions.ToInteger(((ToolEventArgs)e).get_Tool().get_Key()), ((ToolPropsBase)((ToolEventArgs)e).get_Tool().get_SharedProps()).get_Caption());
			break;
		case "4":
			fEquity4 = new frmEquity();
			fEquity4.Tab_Index = Conversions.ToInteger(((ToolEventArgs)e).get_Tool().get_Key());
			fEquity4.Tab_Name = ((ToolPropsBase)((ToolEventArgs)e).get_Tool().get_SharedProps()).get_Caption();
			ShowEquityForm((Form)(object)fEquity4, Conversions.ToInteger(((ToolEventArgs)e).get_Tool().get_Key()), ((ToolPropsBase)((ToolEventArgs)e).get_Tool().get_SharedProps()).get_Caption());
			break;
		case "5":
			fEquity5 = new frmEquity();
			fEquity5.Tab_Index = Conversions.ToInteger(((ToolEventArgs)e).get_Tool().get_Key());
			fEquity5.Tab_Name = ((ToolPropsBase)((ToolEventArgs)e).get_Tool().get_SharedProps()).get_Caption();
			ShowEquityForm((Form)(object)fEquity5, Conversions.ToInteger(((ToolEventArgs)e).get_Tool().get_Key()), ((ToolPropsBase)((ToolEventArgs)e).get_Tool().get_SharedProps()).get_Caption());
			break;
		case "BONDS":
		{
			frmBonds frmBonds2 = MyProject.Forms.frmBonds;
			((Form)frmBonds2).set_MdiParent((Form)(object)this);
			((Control)frmBonds2).Show();
			frmBonds2 = null;
			break;
		}
		case "BSEWIRES":
		{
			frmBSEWires frmBSEWires2 = MyProject.Forms.frmBSEWires;
			((Form)frmBSEWires2).set_MdiParent((Form)(object)this);
			((Control)frmBSEWires2).Show();
			frmBSEWires2 = null;
			break;
		}
		case "COMMODITY":
		{
			frmCommodity frmCommodity2 = MyProject.Forms.frmCommodity;
			((Form)frmCommodity2).set_MdiParent((Form)(object)this);
			((Control)frmCommodity2).Show();
			frmCommodity2 = null;
			break;
		}
		case "DOWJONESWIRE":
		{
			frmDJWires frmDJWires2 = MyProject.Forms.frmDJWires;
			((Form)frmDJWires2).set_MdiParent((Form)(object)this);
			((Control)frmDJWires2).Show();
			frmDJWires2 = null;
			break;
		}
		case "FOREIGNINDICES":
		{
			frmForeignIndices frmForeignIndices2 = MyProject.Forms.frmForeignIndices;
			((Form)frmForeignIndices2).set_MdiParent((Form)(object)this);
			((Control)frmForeignIndices2).Show();
			frmForeignIndices2 = null;
			break;
		}
		case "FOREX":
		{
			frmForex frmForex2 = MyProject.Forms.frmForex;
			((Form)frmForex2).set_MdiParent((Form)(object)this);
			((Control)frmForex2).Show();
			frmForex2 = null;
			break;
		}
		case "BLOCKDEALS":
		{
			frmBlockDeals frmBlockDeals2 = MyProject.Forms.frmBlockDeals;
			((Form)frmBlockDeals2).set_MdiParent((Form)(object)this);
			((Control)frmBlockDeals2).Show();
			frmBlockDeals2 = null;
			break;
		}
		case "STATS":
		{
			frmStats frmStats2 = MyProject.Forms.frmStats;
			((Form)frmStats2).set_MdiParent((Form)(object)this);
			((Control)frmStats2).Show();
			frmStats2 = null;
			break;
		}
		case "FUTURES":
		{
			EquityKey = "FUTURES";
			fFutures = new frmFutures();
			frmFutures frmFutures2 = fFutures;
			((Form)frmFutures2).set_MdiParent((Form)(object)this);
			((Control)frmFutures2).Show();
			frmFutures2 = null;
			break;
		}
		case "OPTIONS":
		{
			EquityKey = "OPTIONS";
			fOptions = new frmOptions();
			frmOptions frmOptions2 = fOptions;
			((Form)frmOptions2).set_MdiParent((Form)(object)this);
			((Control)frmOptions2).Show();
			frmOptions2 = null;
			break;
		}
		case "HELPSHORTCUTS":
		{
			frmHelp frmHelp3 = new frmHelp();
			((Control)frmHelp3).Show();
			break;
		}
		case "HELP":
		{
			frmHelp frmHelp2 = new frmHelp();
			((Control)frmHelp2).Show();
			break;
		}
		case "RESTART":
			objEquity = new clsEquity();
			objEquity.DisConnectUser();
			Process.Start("CNBC_MONEY_StartUp.exe " + Interaction.Command().Trim());
			break;
		case "EXIT":
			objEquity = new clsEquity();
			objEquity.DisConnectUser();
			Application.Exit();
			break;
		}
	}

	private void AddToFavouritesToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		fFavourites = new frmFavourites();
		((Form)fFavourites).ShowDialog();
	}

	private void ShowDataToolStripMenuItem_Click(object sender, EventArgs e)
	{
		string text = ((ToolStripItem)ShowDataToolStripMenuItem).get_Text();
		if (Operators.CompareString(text, "Show Data", false) == 0)
		{
			UltraStatusBar1.get_Panels().get_Item(8).set_Visible(false);
			UltraStatusBar1.get_Panels().get_Item(9).set_Visible(true);
			((ToolStripItem)ShowDataToolStripMenuItem).set_Text("Hide Data");
		}
		else if (Operators.CompareString(text, "Hide Data", false) == 0)
		{
			UltraStatusBar1.get_Panels().get_Item(9).set_Visible(false);
			UltraStatusBar1.get_Panels().get_Item(8).set_Visible(true);
			((ToolStripItem)ShowDataToolStripMenuItem).set_Text("Show Data");
		}
	}

	private void PowerUDP_EndReceive(object sender, DatagramEventArgs e)
	{
		byte[] array = new byte[10001];
		try
		{
			objEquity = new clsEquity();
			clsEquity obj = objEquity;
			byte[] Data = e.get_Datagram().get_Buffer();
			string text = obj.BytesToString(ref Data);
			text = Strings.Trim(text.Replace("\r\n", ""));
			if (Strings.Len(text) > 0)
			{
				dateTime_Streaming = DateAndTime.get_Now();
				Delg_CrunchMDIData delg_CrunchMDIData = CrunchMDIData;
				delg_CrunchMDIData.BeginInvoke(text, null, null);
				Thread.Sleep(1);
				Delg_CrunchEquityData delg_CrunchEquityData = DoEquityMethod;
				delg_CrunchEquityData.BeginInvoke(text, null, null);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		PowerUDP.BeginReceive(array);
	}

	private void UltraTabbedMdiManager1_InitializeTabGroup(object sender, MdiTabGroupEventArgs e)
	{
		if (((DisposableObjectCollectionBase)UltraTabbedMdiManager1.get_TabGroups()).get_Count() != 1 && UltraTabbedMdiManager1.get_ActiveTab() != null && Operators.CompareString(((KeyedSubObjectBase)UltraTabbedMdiManager1.get_ActiveTab()).get_Key(), "", false) != 0)
		{
			fFutures.IsActive = false;
			fOptions.IsActive = false;
			string key = ((KeyedSubObjectBase)UltraTabbedMdiManager1.get_ActiveTab()).get_Key();
			if (Operators.CompareString(key, "FUTURES", false) == 0)
			{
				fFutures.IsActive = true;
			}
			else if (Operators.CompareString(key, "OPTIONS", false) == 0)
			{
				fOptions.IsActive = true;
			}
		}
	}

	private void UltraTabbedMdiManager1_TabActivated(object sender, MdiTabEventArgs e)
	{
		if (Operators.CompareString(((KeyedSubObjectBase)UltraTabbedMdiManager1.get_ActiveTab()).get_Key(), "", false) == 0)
		{
			((KeyedSubObjectBase)UltraTabbedMdiManager1.get_ActiveTab()).set_Key(EquityKey);
		}
		if (Versioned.IsNumeric((object)((KeyedSubObjectBase)UltraTabbedMdiManager1.get_ActiveTab()).get_Key()))
		{
			objEquity = new clsEquity();
			objEquity.Update_DateTime(Conversions.ToInteger(((KeyedSubObjectBase)UltraTabbedMdiManager1.get_ActiveTab()).get_Key()));
		}
	}

	private void UltraTabbedMdiManager1_TabClosed(object sender, MdiTabEventArgs e)
	{
	}

	private void UltraTabbedMdiManager1_TabSelected(object sender, MdiTabEventArgs e)
	{
		if (UltraTabbedMdiManager1.get_ActiveTab() != null && Operators.CompareString(((KeyedSubObjectBase)UltraTabbedMdiManager1.get_ActiveTab()).get_Key(), "", false) != 0)
		{
			Application.DoEvents();
			fFutures.IsActive = false;
			fOptions.IsActive = false;
			if (Versioned.IsNumeric((object)((KeyedSubObjectBase)UltraTabbedMdiManager1.get_ActiveTab()).get_Key()))
			{
				objEquity = new clsEquity();
				objEquity.Update_DateTime(Conversions.ToInteger(((KeyedSubObjectBase)UltraTabbedMdiManager1.get_ActiveTab()).get_Key()));
			}
			switch (Strings.UCase(((KeyedSubObjectBase)UltraTabbedMdiManager1.get_ActiveTab()).get_Key()))
			{
			case "1":
				fEquity1.BindGridData();
				break;
			case "2":
				fEquity2.BindGridData();
				break;
			case "3":
				fEquity3.BindGridData();
				break;
			case "4":
				fEquity4.BindGridData();
				break;
			case "5":
				fEquity5.BindGridData();
				break;
			case "FUTURES":
				fFutures.IsActive = true;
				break;
			case "OPTIONS":
				fOptions.IsActive = true;
				break;
			}
			SendToBroadCast();
		}
	}

	private void tmr_Streaming_Tick(object sender, EventArgs e)
	{
		tmr_Streaming.set_Enabled(false);
		if (DateAndTime.DateDiff((DateInterval)9, dateTime_Streaming, DateAndTime.get_Now(), (FirstDayOfWeek)1, (FirstWeekOfYear)1) > 5L)
		{
			CheckDataComing("Disconnected", strflag: false);
		}
		if (UltraTabbedMdiManager1.get_ActiveTab() != null && ((Operators.CompareString(((KeyedSubObjectBase)UltraTabbedMdiManager1.get_ActiveTab()).get_Key(), "", false) != 0) & Versioned.IsNumeric((object)((KeyedSubObjectBase)UltraTabbedMdiManager1.get_ActiveTab()).get_Key())))
		{
			objEquity = new clsEquity();
			objEquity.Update_DateTime(Conversions.ToInteger(((KeyedSubObjectBase)UltraTabbedMdiManager1.get_ActiveTab()).get_Key()));
		}
		if (((DateTime.Compare(DateAndTime.get_Now(), Conversions.ToDate(Conversions.ToString(DateAndTime.get_Now().Date) + " " + mdlMain.gMktstartTime)) > 0) & (DateTime.Compare(DateAndTime.get_Now(), Conversions.ToDate(Conversions.ToString(DateAndTime.get_Now().Date) + " " + mdlMain.gMktEndTime)) < 0)) && DateAndTime.DateDiff((DateInterval)9, dateTime_Streaming, DateAndTime.get_Now(), (FirstDayOfWeek)1, (FirstWeekOfYear)1) > 30L)
		{
			ReConnect_30Seconds();
			DoChangeStatusText("");
		}
		SendToBroadCast();
		tmr_Streaming.set_Enabled(true);
	}

	private void Initialize()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		((EventManagerBase)ToolbarsManager.get_EventManager()).set_AllEventsEnabled(false);
		ListTool val = (ListTool)((ToolsCollectionBase)ToolbarsManager.get_Tools()).get_Item("ColorSchemeList");
		val.get_ListToolItems().get_Item("Blue").set_Value((object)(Office2007ColorScheme)0);
		val.get_ListToolItems().get_Item("Black").set_Value((object)(Office2007ColorScheme)1);
		val.get_ListToolItems().get_Item("Silver").set_Value((object)(Office2007ColorScheme)2);
		GetColorScheme();
		Conversions.ToInteger(mdlMain.INIRead(Application.get_StartupPath() + "/Money_Config.ini", "MAIN", "COLOR_SCHEME", ""));
		string text = "Blue";
		string text2 = mdlMain.INIRead(Application.get_StartupPath() + "/Money_Config.ini", "MAIN", "COLOR_SCHEME", "");
		if (Operators.CompareString(text2, Conversions.ToString(0), false) == 0)
		{
			text = "Blue";
		}
		else if (Operators.CompareString(text2, Conversions.ToString(1), false) == 0)
		{
			text = "Black";
		}
		else if (Operators.CompareString(text2, Conversions.ToString(2), false) == 0)
		{
			text = "Silver";
		}
		val.set_SelectedItemIndex(val.get_ListToolItems().get_Item(text).get_Index());
		Office2007ColorTable.set_ColorScheme((Office2007ColorScheme)Conversions.ToInteger(mdlMain.INIRead(Application.get_StartupPath() + "/Money_Config.ini", "MAIN", "COLOR_SCHEME", "")));
		((EventManagerBase)ToolbarsManager.get_EventManager()).set_AllEventsEnabled(true);
	}

	private void ShowEquityForm(Form fEquity, int frmKey, string frmText)
	{
		EquityKey = Conversions.ToString(frmKey);
		ActiveEquityForm = fEquity;
		if (Operators.CompareString(frmText, "", false) != 0)
		{
			Form val = fEquity;
			val.set_MdiParent((Form)(object)this);
			val.set_Text(frmText);
			((Control)val).Show();
			val = null;
		}
	}

	private void BindMarketWatch()
	{
		checked
		{
			try
			{
				strSQL = "Select ISNULL(Lastprice,0),bridgesymbol from equity_transaction_data where Bridgesymbol in ('in;bseADV','in;bseDEC','in;NseADV','in;NseDEC','in;BSECM','in;NSECM','in;FNOCM','in;TOTCM')";
				dt = new DataTable();
				dt = SqlHelper.ExecuteDataset(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL).Tables[0];
				int num = dt.Rows.Count - 1;
				i = 0;
				int num4 = default(int);
				int num5 = default(int);
				int num6 = default(int);
				int num7 = default(int);
				while (true)
				{
					int num2 = i;
					int num3 = num;
					if (num2 > num3)
					{
						break;
					}
					Type typeFromHandle = typeof(Strings);
					object[] array = new object[1];
					DataRow dataRow = dt.Rows[i];
					string columnName = "Bridgesymbol";
					array[0] = RuntimeHelpers.GetObjectValue(dataRow[columnName]);
					object[] array2 = array;
					object[] array3 = array2;
					bool[] array4 = new bool[1] { true };
					object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "UCase", array3, (string[])null, (Type[])null, array4);
					if (array4[0])
					{
						dataRow[columnName] = RuntimeHelpers.GetObjectValue(array2[0]);
					}
					object obj2 = obj;
					if (Operators.ConditionalCompareObjectEqual(obj2, (object)"IN;NSEADV", false))
					{
						((ToolPropsBase)((ToolsCollectionBase)((RibbonTabCollectionBase)ToolbarsManager.get_Ribbon().get_Tabs()).get_Item(0).get_Groups().get_Item("NSE")
							.get_Tools()).get_Item("NSE_ADV").get_SharedProps()).set_Caption(Conversions.ToString(Operators.ConcatenateObject((object)("ADV " + Strings.Space(8)), dt.Rows[i][0])));
						num4 = Conversions.ToInteger(dt.Rows[i][0]);
					}
					else if (Operators.ConditionalCompareObjectEqual(obj2, (object)"IN;NSEDEC", false))
					{
						((ToolPropsBase)((ToolsCollectionBase)((RibbonTabCollectionBase)ToolbarsManager.get_Ribbon().get_Tabs()).get_Item(0).get_Groups().get_Item("NSE")
							.get_Tools()).get_Item("NSE_DEC").get_SharedProps()).set_Caption(Conversions.ToString(Operators.ConcatenateObject((object)("DEC " + Strings.Space(8)), dt.Rows[i][0])));
						num5 = Conversions.ToInteger(dt.Rows[i][0]);
					}
					else if (Operators.ConditionalCompareObjectEqual(obj2, (object)"IN;BSEADV", false))
					{
						((ToolPropsBase)((ToolsCollectionBase)((RibbonTabCollectionBase)ToolbarsManager.get_Ribbon().get_Tabs()).get_Item(0).get_Groups().get_Item("BSE")
							.get_Tools()).get_Item("BSE_ADV").get_SharedProps()).set_Caption(Conversions.ToString(Operators.ConcatenateObject((object)("ADV " + Strings.Space(8)), dt.Rows[i][0])));
						num6 = Conversions.ToInteger(dt.Rows[i][0]);
					}
					else if (Operators.ConditionalCompareObjectEqual(obj2, (object)"IN;BSEDEC", false))
					{
						((ToolPropsBase)((ToolsCollectionBase)((RibbonTabCollectionBase)ToolbarsManager.get_Ribbon().get_Tabs()).get_Item(0).get_Groups().get_Item("BSE")
							.get_Tools()).get_Item("BSE_DEC").get_SharedProps()).set_Caption(Conversions.ToString(Operators.ConcatenateObject((object)("DEC " + Strings.Space(8)), dt.Rows[i][0])));
						num7 = Conversions.ToInteger(dt.Rows[i][0]);
					}
					else if (Operators.ConditionalCompareObjectEqual(obj2, (object)"IN;BSECM", false))
					{
						((ToolPropsBase)((ToolsCollectionBase)((RibbonTabCollectionBase)ToolbarsManager.get_Ribbon().get_Tabs()).get_Item(0).get_Groups().get_Item("TURNOVER")
							.get_Tools()).get_Item("BSECM_VALUE").get_SharedProps()).set_Caption(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateGet((object)null, typeof(Math), "Round", new object[2]
						{
							Operators.DivideObject(dt.Rows[i][0], (object)10000000),
							2
						}, (string[])null, (Type[])null, (bool[])null), (object)" cr")));
					}
					else if (Operators.ConditionalCompareObjectEqual(obj2, (object)"IN;NSECM", false))
					{
						((ToolPropsBase)((ToolsCollectionBase)((RibbonTabCollectionBase)ToolbarsManager.get_Ribbon().get_Tabs()).get_Item(0).get_Groups().get_Item("TURNOVER")
							.get_Tools()).get_Item("NSECM_VALUE").get_SharedProps()).set_Caption(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateGet((object)null, typeof(Math), "Round", new object[2]
						{
							Operators.DivideObject(dt.Rows[i][0], (object)10000000),
							2
						}, (string[])null, (Type[])null, (bool[])null), (object)" cr")));
					}
					else if (Operators.ConditionalCompareObjectEqual(obj2, (object)"IN;FNOCM", false))
					{
						((ToolPropsBase)((ToolsCollectionBase)((RibbonTabCollectionBase)ToolbarsManager.get_Ribbon().get_Tabs()).get_Item(0).get_Groups().get_Item("TURNOVER")
							.get_Tools()).get_Item("FNO_VALUE").get_SharedProps()).set_Caption(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateGet((object)null, typeof(Math), "Round", new object[2]
						{
							RuntimeHelpers.GetObjectValue(dt.Rows[i][0]),
							2
						}, (string[])null, (Type[])null, (bool[])null), (object)" cr")));
					}
					else if (Operators.ConditionalCompareObjectEqual(obj2, (object)"IN;TOTCM", false))
					{
						((RibbonTabCollectionBase)ToolbarsManager.get_Ribbon().get_Tabs()).get_Item(0).get_Groups().get_Item("TURNOVER")
							.set_Caption(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("TOTAL TOVER" + Strings.Space(6)), NewLateBinding.LateGet((object)null, typeof(Math), "Round", new object[2]
							{
								Operators.DivideObject(dt.Rows[i][0], (object)10000000),
								2
							}, (string[])null, (Type[])null, (bool[])null)), (object)" cr")));
					}
					i++;
				}
				((ToolPropsBase)((ToolsCollectionBase)((RibbonTabCollectionBase)ToolbarsManager.get_Ribbon().get_Tabs()).get_Item(0).get_Groups().get_Item("NSE")
					.get_Tools()).get_Item("NSE_RATIO").get_SharedProps()).set_Caption("RATIO" + Strings.Space(4) + "1:" + Conversions.ToString(Conversions.ToDouble(Strings.FormatNumber((object)((double)num5 / (double)num4), 2, (TriState)(-1), (TriState)0, (TriState)0))));
				((ToolPropsBase)((ToolsCollectionBase)((RibbonTabCollectionBase)ToolbarsManager.get_Ribbon().get_Tabs()).get_Item(0).get_Groups().get_Item("BSE")
					.get_Tools()).get_Item("BSE_RATIO").get_SharedProps()).set_Caption("RATIO" + Strings.Space(4) + " 1:" + Conversions.ToString(Conversions.ToDouble(Strings.FormatNumber((object)((double)num7 / (double)num6), 2, (TriState)(-1), (TriState)0, (TriState)0))));
				strSQL = "Select bridgesymbol,[Close] as closing ,ISNULL(lastprice,0) as LastPrice,ISNULL(convert(decimal(10,2), ISNULL([LastPrice],0)-ISNULL([CLOSE],0)),0) as Change,convert(decimal(10,2), ((LastPrice-[Close])/[CLOSE])*100) as PercentChange from EQUITY_TRANSACTION_DATA where bridgesymbol in ('in;sen','in;nsx','in;ccx')";
				dt = new DataTable();
				dt = SqlHelper.ExecuteDataset(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL).Tables[0];
				int num8 = dt.Rows.Count - 1;
				i = 0;
				Color foreColor = default(Color);
				while (true)
				{
					int num9 = i;
					int num3 = num8;
					if (num9 > num3)
					{
						break;
					}
					string text = "";
					string text2 = "";
					string text3 = "";
					string text4 = "";
					RibbonGroup val = ((RibbonTabCollectionBase)ToolbarsManager.get_Ribbon().get_Tabs()).get_Item(0).get_Groups().get_Item("INDICES");
					if (Operators.CompareString(Strings.LCase(Strings.Trim(Conversions.ToString(dt.Rows[i]["bridgesymbol"]))), "in;sen", false) == 0)
					{
						text = "SENSEX";
						text2 = "SEN_LP";
						text3 = "SEN_C";
						text4 = "SEN_PC";
						SensexLast = Conversions.ToDouble(dt.Rows[i]["closing"]);
						if (Conversions.ToDouble(dt.Rows[i]["change"]) > 0.0)
						{
							foreColor = Color.Green;
						}
						else if (Conversions.ToDouble(dt.Rows[i]["change"]) < 0.0)
						{
							foreColor = Color.Red;
						}
						else if (Conversions.ToDouble(dt.Rows[i]["change"]) == 0.0)
						{
							foreColor = Color.Black;
						}
					}
					if (Operators.CompareString(Strings.LCase(Strings.Trim(Conversions.ToString(dt.Rows[i]["bridgesymbol"]))), "in;nsx", false) == 0)
					{
						text = "NIFTY";
						text2 = "NIF_LP";
						text3 = "NIF_C";
						text4 = "NIF_PC";
						NiftyLast = Conversions.ToDouble(dt.Rows[i]["closing"]);
						if (Conversions.ToDouble(dt.Rows[i]["change"]) > 0.0)
						{
							foreColor = Color.Green;
						}
						else if (Conversions.ToDouble(dt.Rows[i]["change"]) < 0.0)
						{
							foreColor = Color.Red;
						}
						else if (Conversions.ToDouble(dt.Rows[i]["change"]) == 0.0)
						{
							foreColor = Color.Black;
						}
					}
					if (Operators.CompareString(Strings.LCase(Strings.Trim(Conversions.ToString(dt.Rows[i]["bridgesymbol"]))), "in;ccx", false) == 0)
					{
						text = "MIDCAP";
						text2 = "MID_LP";
						text3 = "MID_C";
						text4 = "MID_PC";
						MIDCAPLast = Conversions.ToDouble(dt.Rows[i]["closing"]);
						if (Conversions.ToDouble(dt.Rows[i]["change"]) > 0.0)
						{
							foreColor = Color.Green;
						}
						else if (Conversions.ToDouble(dt.Rows[i]["change"]) < 0.0)
						{
							foreColor = Color.Red;
						}
						else if (Conversions.ToDouble(dt.Rows[i]["change"]) == 0.0)
						{
							foreColor = Color.Black;
						}
					}
					((ToolPropsBase)((ToolsCollectionBase)val.get_Tools()).get_Item(text2).get_SharedProps()).set_Caption(Conversions.ToString(dt.Rows[i]["LastPrice"]));
					((ToolPropsBase)((ToolsCollectionBase)val.get_Tools()).get_Item(text3).get_SharedProps()).set_Caption(Strings.Trim(Conversions.ToString(dt.Rows[i]["change"])));
					((ToolPropsBase)((ToolsCollectionBase)val.get_Tools()).get_Item(text4).get_SharedProps()).set_Caption(Strings.Trim(Strings.Replace(Conversions.ToString(Operators.ConcatenateObject(dt.Rows[i]["PercentChange"], (object)"%")), "-", "", 1, -1, (CompareMethod)0)));
					((ToolPropsBase)((ToolsCollectionBase)val.get_Tools()).get_Item(text2).get_SharedProps()).get_AppearancesSmall().get_Appearance().set_ForeColor(foreColor);
					((ToolPropsBase)((ToolsCollectionBase)val.get_Tools()).get_Item(text3).get_SharedProps()).get_AppearancesSmall().get_Appearance().set_ForeColor(foreColor);
					((ToolPropsBase)((ToolsCollectionBase)val.get_Tools()).get_Item(text4).get_SharedProps()).get_AppearancesSmall().get_Appearance().set_ForeColor(foreColor);
					((ToolPropsBase)((ToolsCollectionBase)val.get_Tools()).get_Item(text).get_SharedProps()).get_AppearancesSmall().get_Appearance().set_ForeColor(foreColor);
					DataTable dataTable = new DataTable();
					strSQL = "SELECT PCR, PREV_PCR FROM vw_ADV_DEC";
					dataTable = SqlHelper.ExecuteDataset(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL).Tables[0];
					if (dataTable.Rows.Count > 0)
					{
						RibbonGroup val2 = ((RibbonTabCollectionBase)ToolbarsManager.get_Ribbon().get_Tabs()).get_Item(0).get_Groups().get_Item("PCR");
						((ToolPropsBase)((ToolsCollectionBase)val2.get_Tools()).get_Item("OI_PCR_VALUE").get_SharedProps()).set_Caption(Strings.Format(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object)null, typeof(Math), "Round", new object[2]
						{
							RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["PCR"]),
							2
						}, (string[])null, (Type[])null, (bool[])null)), "0.00"));
						((ToolPropsBase)((ToolsCollectionBase)val2.get_Tools()).get_Item("OI_PREV_PCR_VALUE").get_SharedProps()).set_Caption(Strings.Format(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object)null, typeof(Math), "Round", new object[2]
						{
							RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["PREV_PCR"]),
							2
						}, (string[])null, (Type[])null, (bool[])null)), "0.00"));
						val2 = null;
					}
					val = null;
					i++;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void BindFavourites()
	{
		checked
		{
			try
			{
				objEquity = new clsEquity();
				strSQL = "select a.tabname, b.ShortName, b.ExchangeSymbol, b.[Close] as Closing ,convert(decimal(10,2),ISNULL(b.lastprice,0)) as LastPrice,ISNULL(convert(decimal(10,2),  ISNULL(b.LastPrice,0)-ISNULL(b.[CLOSE],0)),0) as Change,case when b.[close] = 0 then 0 else convert(decimal(10,2), ((b.LastPrice-b.[Close])/b.[CLOSE])*100) end as PercentChange from vw_CNBCMONEY_DETAILS  a  inner join equity_transaction_data b on a.bridgesymbol = b.bridgesymbol and b.series in ('EQ', 'BE', 'INX') and b.market_type = 'N' where(a.tabindex = 0) AND USERNAME = '" + mdlMain.gUserName + "' ORDER BY TABNAME";
				dt = SqlHelper.ExecuteDataset(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL).Tables[0];
				((Control)grFavourite5).set_Visible(false);
				((Control)grFavourite4).set_Visible(false);
				((Control)grFavourite3).set_Visible(false);
				((Control)grFavourite2).set_Visible(false);
				((Control)grFavourite1).set_Visible(false);
				Favourites = "";
				int num = dt.Rows.Count - 1;
				i = 0;
				while (true)
				{
					int num2 = i;
					int num3 = num;
					if (num2 > num3)
					{
						break;
					}
					object obj = dt.Rows[i]["TABNAME"];
					if (Operators.ConditionalCompareObjectEqual(obj, (object)"1", false))
					{
						grFavourite1.set_Text(Conversions.ToString(dt.Rows[i]["ShortName"]));
						((Control)grFavourite1).set_Tag(RuntimeHelpers.GetObjectValue(dt.Rows[i]["ExchangeSymbol"]));
						Favourites = Operators.ConcatenateObject(Operators.ConcatenateObject(Favourites, (object)","), dt.Rows[i]["ExchangeSymbol"]);
						lbl_LP1.set_Text(Conversions.ToString(dt.Rows[i]["LastPrice"]));
						lbl_C1.set_Text(Conversions.ToString(dt.Rows[i]["Change"]));
						lbl_PC1.set_Text(Conversions.ToString(Operators.ConcatenateObject(dt.Rows[i]["PercentChange"], (object)" %")));
						lbl_CL1.set_Text(Conversions.ToString(dt.Rows[i]["Closing"]));
						if (Conversions.ToDouble(lbl_C1.get_Text()) > 0.0)
						{
							grFavourite1.get_HeaderAppearance().set_BorderColor(Color.Green);
							grFavourite1.get_HeaderAppearance().set_ForeColor(Color.Green);
							((Control)grFavourite1).set_ForeColor(Color.Green);
						}
						else if (Conversions.ToDouble(lbl_C1.get_Text()) < 0.0)
						{
							grFavourite1.get_HeaderAppearance().set_BorderColor(Color.Red);
							grFavourite1.get_HeaderAppearance().set_ForeColor(Color.Red);
							((Control)grFavourite1).set_ForeColor(Color.Red);
						}
						else
						{
							grFavourite1.get_HeaderAppearance().set_BorderColor(Color.Black);
							grFavourite1.get_HeaderAppearance().set_ForeColor(Color.Black);
							((Control)grFavourite1).set_ForeColor(Color.Black);
						}
						((Control)grFavourite1).set_Visible(true);
					}
					else if (Operators.ConditionalCompareObjectEqual(obj, (object)"2", false))
					{
						grFavourite2.set_Text(Conversions.ToString(dt.Rows[i]["ShortName"]));
						((Control)grFavourite2).set_Tag(RuntimeHelpers.GetObjectValue(dt.Rows[i]["ExchangeSymbol"]));
						Favourites = Operators.ConcatenateObject(Operators.ConcatenateObject(Favourites, (object)","), dt.Rows[i]["ExchangeSymbol"]);
						lbl_LP2.set_Text(Conversions.ToString(dt.Rows[i]["LastPrice"]));
						lbl_C2.set_Text(Conversions.ToString(dt.Rows[i]["Change"]));
						lbl_PC2.set_Text(Conversions.ToString(Operators.ConcatenateObject(dt.Rows[i]["PercentChange"], (object)"%")));
						lbl_CL2.set_Text(Conversions.ToString(dt.Rows[i]["Closing"]));
						if (Conversions.ToDouble(lbl_C2.get_Text()) > 0.0)
						{
							grFavourite2.get_HeaderAppearance().set_BorderColor(Color.Green);
							grFavourite2.get_HeaderAppearance().set_ForeColor(Color.Green);
							((Control)grFavourite2).set_ForeColor(Color.Green);
						}
						else if (Conversions.ToDouble(lbl_C2.get_Text()) < 0.0)
						{
							grFavourite2.get_HeaderAppearance().set_BorderColor(Color.Red);
							grFavourite2.get_HeaderAppearance().set_ForeColor(Color.Red);
							((Control)grFavourite2).set_ForeColor(Color.Red);
						}
						else
						{
							grFavourite2.get_HeaderAppearance().set_BorderColor(Color.Black);
							grFavourite2.get_HeaderAppearance().set_ForeColor(Color.Black);
							((Control)grFavourite2).set_ForeColor(Color.Black);
						}
						((Control)grFavourite2).set_Visible(true);
					}
					else if (Operators.ConditionalCompareObjectEqual(obj, (object)"3", false))
					{
						grFavourite3.set_Text(Conversions.ToString(dt.Rows[i]["ShortName"]));
						((Control)grFavourite3).set_Tag(RuntimeHelpers.GetObjectValue(dt.Rows[i]["ExchangeSymbol"]));
						Favourites = Operators.ConcatenateObject(Operators.ConcatenateObject(Favourites, (object)","), dt.Rows[i]["ExchangeSymbol"]);
						lbl_LP3.set_Text(Conversions.ToString(dt.Rows[i]["LastPrice"]));
						lbl_C3.set_Text(Conversions.ToString(dt.Rows[i]["Change"]));
						lbl_PC3.set_Text(Conversions.ToString(Operators.ConcatenateObject(dt.Rows[i]["PercentChange"], (object)"%")));
						lbl_CL3.set_Text(Conversions.ToString(dt.Rows[i]["Closing"]));
						if (Conversions.ToDouble(lbl_C3.get_Text()) > 0.0)
						{
							grFavourite3.get_HeaderAppearance().set_BorderColor(Color.Green);
							grFavourite3.get_HeaderAppearance().set_ForeColor(Color.Green);
							((Control)grFavourite3).set_ForeColor(Color.Green);
						}
						else if (Conversions.ToDouble(lbl_C3.get_Text()) < 0.0)
						{
							grFavourite3.get_HeaderAppearance().set_BorderColor(Color.Red);
							grFavourite3.get_HeaderAppearance().set_ForeColor(Color.Red);
							((Control)grFavourite3).set_ForeColor(Color.Red);
						}
						else
						{
							grFavourite3.get_HeaderAppearance().set_BorderColor(Color.Black);
							grFavourite3.get_HeaderAppearance().set_ForeColor(Color.Black);
							((Control)grFavourite3).set_ForeColor(Color.Black);
						}
						((Control)grFavourite3).set_Visible(true);
					}
					else if (Operators.ConditionalCompareObjectEqual(obj, (object)"4", false))
					{
						grFavourite4.set_Text(Conversions.ToString(dt.Rows[i]["ShortName"]));
						((Control)grFavourite4).set_Tag(RuntimeHelpers.GetObjectValue(dt.Rows[i]["ExchangeSymbol"]));
						Favourites = Operators.ConcatenateObject(Operators.ConcatenateObject(Favourites, (object)","), dt.Rows[i]["ExchangeSymbol"]);
						lbl_LP4.set_Text(Conversions.ToString(dt.Rows[i]["LastPrice"]));
						lbl_C4.set_Text(Conversions.ToString(dt.Rows[i]["Change"]));
						lbl_PC4.set_Text(Conversions.ToString(Operators.ConcatenateObject(dt.Rows[i]["PercentChange"], (object)"%")));
						lbl_CL4.set_Text(Conversions.ToString(dt.Rows[i]["Closing"]));
						if (Conversions.ToDouble(lbl_C4.get_Text()) > 0.0)
						{
							grFavourite4.get_HeaderAppearance().set_BorderColor(Color.Green);
							grFavourite4.get_HeaderAppearance().set_ForeColor(Color.Green);
							((Control)grFavourite4).set_ForeColor(Color.Green);
						}
						else if (Conversions.ToDouble(lbl_C4.get_Text()) < 0.0)
						{
							grFavourite4.get_HeaderAppearance().set_BorderColor(Color.Red);
							grFavourite4.get_HeaderAppearance().set_ForeColor(Color.Red);
							((Control)grFavourite4).set_ForeColor(Color.Red);
						}
						else
						{
							grFavourite4.get_HeaderAppearance().set_BorderColor(Color.Black);
							grFavourite4.get_HeaderAppearance().set_ForeColor(Color.Black);
							((Control)grFavourite4).set_ForeColor(Color.Black);
						}
						((Control)grFavourite4).set_Visible(true);
					}
					else if (Operators.ConditionalCompareObjectEqual(obj, (object)"5", false))
					{
						grFavourite5.set_Text(Conversions.ToString(dt.Rows[i]["ShortName"]));
						((Control)grFavourite5).set_Tag(RuntimeHelpers.GetObjectValue(dt.Rows[i]["ExchangeSymbol"]));
						Favourites = Operators.ConcatenateObject(Operators.ConcatenateObject(Favourites, (object)","), dt.Rows[i]["ExchangeSymbol"]);
						lbl_LP5.set_Text(Conversions.ToString(dt.Rows[i]["LastPrice"]));
						lbl_C5.set_Text(Conversions.ToString(dt.Rows[i]["Change"]));
						lbl_PC5.set_Text(Conversions.ToString(Operators.ConcatenateObject(dt.Rows[i]["PercentChange"], (object)"%")));
						lbl_CL5.set_Text(Conversions.ToString(dt.Rows[i]["Closing"]));
						if (Conversions.ToDouble(lbl_C5.get_Text()) > 0.0)
						{
							grFavourite5.get_HeaderAppearance().set_BorderColor(Color.Green);
							grFavourite5.get_HeaderAppearance().set_ForeColor(Color.Green);
							((Control)grFavourite5).set_ForeColor(Color.Green);
						}
						else if (Conversions.ToDouble(lbl_C5.get_Text()) < 0.0)
						{
							grFavourite5.get_HeaderAppearance().set_BorderColor(Color.Red);
							grFavourite5.get_HeaderAppearance().set_ForeColor(Color.Red);
							((Control)grFavourite5).set_ForeColor(Color.Red);
						}
						else
						{
							grFavourite5.get_HeaderAppearance().set_BorderColor(Color.Black);
							grFavourite5.get_HeaderAppearance().set_ForeColor(Color.Black);
							((Control)grFavourite5).set_ForeColor(Color.Black);
						}
						((Control)grFavourite5).set_Visible(true);
					}
					i++;
				}
				Favourites = Operators.ConcatenateObject(Favourites, (object)",");
				SendToBroadCast();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void BindEquity_Menu()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				new clsEquity();
				strSQL = "SELECT DISTINCT UPPER(TABNAME) AS TABNAME FROM vw_CNBCMONEY_DETAILS WHERE USERNAME = '" + mdlMain.gUserName + "'";
				dt = new DataTable();
				dt = SqlHelper.ExecuteDataset(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL).Tables[0];
				((ComboBoxTool)((ToolsCollectionBase)ToolbarsManager.get_Tools()).get_Item("Equity")).get_ValueList().get_ValueListItems().Clear();
				int num = dt.Rows.Count - 1;
				i = 0;
				while (true)
				{
					int num2 = i;
					int num3 = num;
					if (num2 > num3)
					{
						break;
					}
					((ComboBoxTool)((ToolsCollectionBase)ToolbarsManager.get_Tools()).get_Item("Equity")).get_ValueList().get_ValueListItems().Add(RuntimeHelpers.GetObjectValue(dt.Rows[i][0]), Conversions.ToString(dt.Rows[i][0]));
					i++;
				}
				((ComboBoxTool)((ToolsCollectionBase)ToolbarsManager.get_Tools()).get_Item("Equity")).set_AutoComplete(true);
				((TextBoxTool)(ComboBoxTool)((ToolsCollectionBase)ToolbarsManager.get_Tools()).get_Item("Equity")).set_Text("");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Update_Menu()
	{
		checked
		{
			try
			{
				new clsEquity();
				strSQL = "SELECT DISTINCT TABINDEX, TABNAME FROM CNBCMONEY_USERS_MST WHERE (TABINDEX > 0 and TABINDEX < 100)  AND  USERNAME = '" + mdlMain.gUserName + "'";
				dt = new DataTable();
				dt = SqlHelper.ExecuteDataset(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL).Tables[0];
				i = 1;
				int num;
				do
				{
					((ToolPropsBase)((ToolsCollectionBase)ToolbarsManager.get_Tools()).get_Item(Conversions.ToString(i)).get_SharedProps()).set_Caption("Equity-" + Conversions.ToString(i));
					i++;
					num = i;
					int num2 = 5;
				}
				while (num <= 5);
				int num3 = dt.Rows.Count - 1;
				i = 0;
				while (true)
				{
					int num4 = i;
					int num2 = num3;
					if (num4 <= num2)
					{
						((ToolPropsBase)((ToolsCollectionBase)ToolbarsManager.get_Tools()).get_Item(Conversions.ToString(dt.Rows[i][0])).get_SharedProps()).set_Caption(Conversions.ToString(dt.Rows[i][1]));
						i++;
						continue;
					}
					break;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void PowerUDP_Connect()
	{
		try
		{
			objEquity = new clsEquity();
			if (PowerUDP.get_Socket() == null)
			{
				PowerUDP.Open();
				byte[] array = new byte[10001];
				PowerUDP.BeginReceive(array);
				Thread.Sleep(2);
				SendToBroadCast();
				PowerUDP.BeginReceive(array);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			if (Information.Err().get_Number() != 5)
			{
			}
			ProjectData.ClearProjectError();
		}
	}

	private void CrunchMDIData(string aa)
	{
		Thread.Sleep(0);
		checked
		{
			try
			{
				if (Strings.InStr(1, aa, "AAA", (CompareMethod)0) <= 0)
				{
					return;
				}
				Array array = Strings.Split(aa, "AAA", -1, (CompareMethod)0);
				DoChangeProcessText(aa);
				int num = Information.UBound(array, 1);
				int num2 = 0;
				Color foreColor = default(Color);
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					string text = "";
					string text2 = "";
					string text3 = "";
					string text4 = "";
					if (Strings.InStr(1, Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { num2 }, (string[])null))), "|", (CompareMethod)0) > 0)
					{
						Array array2 = Strings.Split(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { num2 }, (string[])null)), "|", -1, (CompareMethod)0);
						Type typeFromHandle = typeof(Strings);
						object[] array3 = new object[1];
						object[] array4 = array3;
						object[] array5 = new object[1];
						object[] array6 = array5;
						int num5 = 0;
						array6[0] = 0;
						array4[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array2, array5, (string[])null));
						object[] array7 = array3;
						object[] array8 = array7;
						bool[] array9 = new bool[1] { true };
						object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "UCase", array8, (string[])null, (Type[])null, array9);
						if (array9[0])
						{
							NewLateBinding.LateIndexSetComplex((object)array2, new object[2]
							{
								num5,
								RuntimeHelpers.GetObjectValue(array7[0])
							}, (string[])null, true, false);
						}
						if ((Operators.CompareString(Strings.Trim(Conversions.ToString(obj)), "CX", false) == 0) & (Operators.CompareString(Strings.UCase(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 1 }, (string[])null)))), "S&P CNX NIFTY", false) == 0))
						{
							text = "NIFTY";
							text2 = "NIF_LP";
							text3 = "NIF_C";
							text4 = "NIF_PC";
							if (Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null)))) - NiftyLast > 0.0)
							{
								foreColor = Color.Green;
							}
							else if (Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null)))) - NiftyLast < 0.0)
							{
								foreColor = Color.Red;
							}
							else if (Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null)))) - NiftyLast == 0.0)
							{
								foreColor = Color.Black;
							}
							RibbonGroup val = ((RibbonTabCollectionBase)ToolbarsManager.get_Ribbon().get_Tabs()).get_Item(0).get_Groups().get_Item("INDICES");
							DoChangeText("INDICES", text2, Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null))));
							DoChangeText("INDICES", text3, Strings.FormatNumber((object)(Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null)))) - NiftyLast), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
							DoChangeText("INDICES", text4, Strings.Replace(Strings.FormatNumber((object)((Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null)))) - NiftyLast) / NiftyLast * 100.0), 2, (TriState)(-1), (TriState)0, (TriState)(-2)) + "%", "-", "", 1, -1, (CompareMethod)0));
							((ToolPropsBase)((ToolsCollectionBase)val.get_Tools()).get_Item(text2).get_SharedProps()).get_AppearancesSmall().get_Appearance().set_ForeColor(foreColor);
							((ToolPropsBase)((ToolsCollectionBase)val.get_Tools()).get_Item(text3).get_SharedProps()).get_AppearancesSmall().get_Appearance().set_ForeColor(foreColor);
							((ToolPropsBase)((ToolsCollectionBase)val.get_Tools()).get_Item(text4).get_SharedProps()).get_AppearancesSmall().get_Appearance().set_ForeColor(foreColor);
							((ToolPropsBase)((ToolsCollectionBase)val.get_Tools()).get_Item(text).get_SharedProps()).get_AppearancesSmall().get_Appearance().set_ForeColor(foreColor);
							val = null;
							DoChangeStatus("Connected", Enabled_Disabled: true);
						}
						if ((Strings.InStr(1, Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 0 }, (string[])null)), "1907", (CompareMethod)0) > 0) & (Operators.CompareString(Strings.UCase(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null)))), "SENSEX", false) == 0))
						{
							text = "SENSEX";
							text2 = "SEN_LP";
							text3 = "SEN_C";
							text4 = "SEN_PC";
							if (Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 3 }, (string[])null)))) / 100.0 - SensexLast > 0.0)
							{
								foreColor = Color.Green;
							}
							else if (Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 3 }, (string[])null)))) / 100.0 - SensexLast < 0.0)
							{
								foreColor = Color.Red;
							}
							else if (Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 3 }, (string[])null)))) / 100.0 - SensexLast == 0.0)
							{
								foreColor = Color.Black;
							}
							RibbonGroup val2 = ((RibbonTabCollectionBase)ToolbarsManager.get_Ribbon().get_Tabs()).get_Item(0).get_Groups().get_Item("INDICES");
							DoChangeText("INDICES", text2, Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 3 }, (string[])null)) / 100.0)), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
							DoChangeText("INDICES", text3, Strings.FormatNumber((object)(Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 3 }, (string[])null)))) / 100.0 - SensexLast), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
							DoChangeText("INDICES", text4, Strings.Replace(Strings.FormatNumber((object)((Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 3 }, (string[])null)))) / 100.0 - SensexLast) / SensexLast * 100.0), 2, (TriState)(-1), (TriState)0, (TriState)(-2)) + "%", "-", "", 1, -1, (CompareMethod)0));
							((ToolPropsBase)((ToolsCollectionBase)val2.get_Tools()).get_Item(text2).get_SharedProps()).get_AppearancesSmall().get_Appearance().set_ForeColor(foreColor);
							((ToolPropsBase)((ToolsCollectionBase)val2.get_Tools()).get_Item(text3).get_SharedProps()).get_AppearancesSmall().get_Appearance().set_ForeColor(foreColor);
							((ToolPropsBase)((ToolsCollectionBase)val2.get_Tools()).get_Item(text4).get_SharedProps()).get_AppearancesSmall().get_Appearance().set_ForeColor(foreColor);
							((ToolPropsBase)((ToolsCollectionBase)val2.get_Tools()).get_Item(text).get_SharedProps()).get_AppearancesSmall().get_Appearance().set_ForeColor(foreColor);
							val2 = null;
						}
						if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array2, new object[1] { 0 }, (string[])null), (object)"CX", false), (object)(Operators.CompareString(Strings.UCase(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 1 }, (string[])null)))), "CNX MIDCAP", false) == 0))))
						{
							text = "MIDCAP";
							text2 = "MID_LP";
							text3 = "MID_C";
							text4 = "MID_PC";
							if (Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null)))) - MIDCAPLast > 0.0)
							{
								foreColor = Color.Green;
							}
							else if (Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null)))) - MIDCAPLast < 0.0)
							{
								foreColor = Color.Red;
							}
							else if (Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null)))) - MIDCAPLast == 0.0)
							{
								foreColor = Color.Black;
							}
							RibbonGroup val3 = ((RibbonTabCollectionBase)ToolbarsManager.get_Ribbon().get_Tabs()).get_Item(0).get_Groups().get_Item("INDICES");
							DoChangeText("INDICES", text2, Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null))));
							DoChangeText("INDICES", text3, Strings.FormatNumber((object)(Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null)))) - MIDCAPLast), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
							DoChangeText("INDICES", text4, Strings.Replace(Strings.FormatNumber((object)((Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null)))) - MIDCAPLast) / MIDCAPLast * 100.0), 2, (TriState)(-1), (TriState)0, (TriState)(-2)) + "%", "-", "", 1, -1, (CompareMethod)0));
							((ToolPropsBase)((ToolsCollectionBase)val3.get_Tools()).get_Item(text2).get_SharedProps()).get_AppearancesSmall().get_Appearance().set_ForeColor(foreColor);
							((ToolPropsBase)((ToolsCollectionBase)val3.get_Tools()).get_Item(text3).get_SharedProps()).get_AppearancesSmall().get_Appearance().set_ForeColor(foreColor);
							((ToolPropsBase)((ToolsCollectionBase)val3.get_Tools()).get_Item(text4).get_SharedProps()).get_AppearancesSmall().get_Appearance().set_ForeColor(foreColor);
							((ToolPropsBase)((ToolsCollectionBase)val3.get_Tools()).get_Item(text).get_SharedProps()).get_AppearancesSmall().get_Appearance().set_ForeColor(foreColor);
							val3 = null;
						}
						if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet((object)array2, new object[1] { 0 }, (string[])null), (object)"CALC", false))
						{
							if (Operators.CompareString(Strings.UCase(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 1 }, (string[])null)))), "ADVDEC", false) == 0)
							{
								DoChangeText("NSE", "NSE_ADV", "ADV " + Strings.Space(6) + Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null))));
								DoChangeText("NSE", "NSE_DEC", "DEC" + Strings.Space(6) + Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 3 }, (string[])null))));
								DoChangeText("BSE", "BSE_ADV", "ADV" + Strings.Space(6) + Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 4 }, (string[])null))));
								DoChangeText("BSE", "BSE_DEC", "DEC" + Strings.Space(6) + Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 5 }, (string[])null))));
								DoChangeText("NSE", "NSE_RATIO", Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 6 }, (string[])null))));
								DoChangeText("BSE", "BSE_RATIO", Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 7 }, (string[])null))));
							}
							else if (Operators.CompareString(Strings.UCase(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 1 }, (string[])null)))), "TURNOVER", false) == 0)
							{
								DoChangeText("TURNOVER", "NSECM_VALUE", Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null))));
								DoChangeText("TURNOVER", "BSECM_VALUE", Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 3 }, (string[])null))));
								DoChangeText("TURNOVER", "FNO_VALUE", Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 4 }, (string[])null))));
								DoChangeText("TURNOVER", "TOTAL", "TOTAL" + Strings.Space(6) + Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 5 }, (string[])null))));
							}
							else if (Operators.CompareString(Strings.UCase(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 1 }, (string[])null)))), "OI", false) == 0)
							{
								DoChangeText("PCR", "OI_PCR_VALUE", Conversions.ToString(Conversions.ToDouble(Strings.FormatNumber(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null)), 2, (TriState)(-1), (TriState)0, (TriState)0))));
								DoChangeText("PCR", "OI_PREV_PCR_VALUE", Conversions.ToString(Conversions.ToDouble(Strings.FormatNumber(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array2, new object[1] { 3 }, (string[])null)), 2, (TriState)(-1), (TriState)0, (TriState)0))));
							}
						}
						if (Conversions.ToBoolean(Operators.OrObject(NewLateBinding.LateGet(Favourites, (Type)null, "Contains", new object[1] { Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array2, new object[1] { 1 }, (string[])null), (object)",") }, (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(Favourites, (Type)null, "Contains", new object[1] { Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null), (object)",") }, (string[])null, (Type[])null, (bool[])null))))
						{
							int num6 = 1;
							int num8;
							do
							{
								string text5 = "0";
								int num7 = num6;
								if (num7 != Conversions.ToInteger("1"))
								{
									if (num7 == Conversions.ToInteger("2"))
									{
										if (((Control)grFavourite2).get_Visible())
										{
											if (Operators.ConditionalCompareObjectEqual(((Control)grFavourite2).get_Tag(), (object)Strings.UCase(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 1 }, (string[])null)))), false) && ((Strings.InStr(1, Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 0 }, (string[])null)), "CN", (CompareMethod)0) > 0) & ((Operators.CompareString(Strings.UCase(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null)))), "EQ", false) == 0) | (Operators.CompareString(Strings.UCase(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null)))), "BE", false) == 0))))
											{
												text5 = Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 8 }, (string[])null));
											}
											if (Operators.ConditionalCompareObjectEqual(((Control)grFavourite2).get_Tag(), (object)Strings.UCase(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null)))), false))
											{
												text5 = ((Strings.InStr(1, Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 0 }, (string[])null)), "1907", (CompareMethod)0) <= 0) ? Conversions.ToString(Conversions.ToDouble(Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 11 }, (string[])null)) / 100.0)), 2, (TriState)(-1), (TriState)(-2), (TriState)0))) : Conversions.ToString(Conversions.ToDouble(Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 3 }, (string[])null)) / 100.0)), 2, (TriState)(-1), (TriState)(-2), (TriState)0))));
											}
											if (Operators.CompareString(text5, "0", false) != 0 && ((Operators.CompareString(lbl_LP2.get_Text(), Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(text5))), 2, (TriState)(-1), (TriState)(-2), (TriState)0), false) != 0) & (Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 9 }, (string[])null)))) != 0.0)))
											{
												DoChangeFavouriteText(lbl_LP2, Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(text5))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
												DoChangeFavouriteText(lbl_C2, Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(text5) - Conversions.ToDouble(Strings.Trim(lbl_CL2.get_Text())))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
												DoChangeFavouriteText(lbl_PC2, Strings.FormatNumber((object)(Conversions.ToDouble(lbl_C2.get_Text()) / Conversions.ToDouble(Strings.Trim(lbl_CL2.get_Text())) * 100.0), 2, (TriState)(-1), (TriState)(-2), (TriState)0) + "%");
												if (Conversions.ToDouble(Strings.Trim(Conversions.ToString(Conversions.ToDouble(text5) - Conversions.ToDouble(Strings.Trim(lbl_CL2.get_Text()))))) > 0.0)
												{
													grFavourite2.get_HeaderAppearance().set_BorderColor(Color.Green);
													grFavourite2.get_HeaderAppearance().set_ForeColor(Color.Green);
													((Control)grFavourite2).set_ForeColor(Color.Green);
												}
												else if (Conversions.ToDouble(Strings.Trim(Conversions.ToString(Conversions.ToDouble(text5) - Conversions.ToDouble(Strings.Trim(lbl_CL2.get_Text()))))) < 0.0)
												{
													grFavourite2.get_HeaderAppearance().set_BorderColor(Color.Red);
													grFavourite2.get_HeaderAppearance().set_ForeColor(Color.Red);
													((Control)grFavourite2).set_ForeColor(Color.Red);
												}
												else
												{
													grFavourite2.get_HeaderAppearance().set_BorderColor(Color.Black);
													grFavourite2.get_HeaderAppearance().set_ForeColor(Color.Black);
													((Control)grFavourite2).set_ForeColor(Color.Black);
												}
											}
										}
									}
									else if (num7 == Conversions.ToInteger("3"))
									{
										if (((Control)grFavourite3).get_Visible())
										{
											if (Operators.ConditionalCompareObjectEqual(((Control)grFavourite3).get_Tag(), (object)Strings.UCase(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 1 }, (string[])null)))), false) && ((Strings.InStr(1, Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 0 }, (string[])null)), "CN", (CompareMethod)0) > 0) & ((Operators.CompareString(Strings.UCase(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null)))), "EQ", false) == 0) | (Operators.CompareString(Strings.UCase(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null)))), "BE", false) == 0))))
											{
												text5 = Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 8 }, (string[])null));
											}
											if (Operators.ConditionalCompareObjectEqual(((Control)grFavourite3).get_Tag(), (object)Strings.UCase(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null)))), false))
											{
												text5 = ((Strings.InStr(1, Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 0 }, (string[])null)), "1907", (CompareMethod)0) <= 0) ? Conversions.ToString(Conversions.ToDouble(Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 11 }, (string[])null)) / 100.0)), 2, (TriState)(-1), (TriState)(-2), (TriState)0))) : Conversions.ToString(Conversions.ToDouble(Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 3 }, (string[])null)) / 100.0)), 2, (TriState)(-1), (TriState)(-2), (TriState)0))));
											}
											if (Operators.CompareString(text5, "0", false) != 0 && ((Operators.CompareString(lbl_LP3.get_Text(), Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(text5))), 2, (TriState)(-1), (TriState)(-2), (TriState)0), false) != 0) & (Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 9 }, (string[])null)))) != 0.0)))
											{
												DoChangeFavouriteText(lbl_LP3, Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(text5))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
												DoChangeFavouriteText(lbl_C3, Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(text5) - Conversions.ToDouble(Strings.Trim(lbl_CL3.get_Text())))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
												DoChangeFavouriteText(lbl_PC3, Strings.FormatNumber((object)(Conversions.ToDouble(lbl_C3.get_Text()) / Conversions.ToDouble(Strings.Trim(lbl_CL3.get_Text())) * 100.0), 2, (TriState)(-1), (TriState)(-2), (TriState)0) + "%");
												if (Conversions.ToDouble(Strings.Trim(Conversions.ToString(Conversions.ToDouble(text5) - Conversions.ToDouble(Strings.Trim(lbl_CL3.get_Text()))))) > 0.0)
												{
													grFavourite3.get_HeaderAppearance().set_BorderColor(Color.Green);
													grFavourite3.get_HeaderAppearance().set_ForeColor(Color.Green);
													((Control)grFavourite3).set_ForeColor(Color.Green);
												}
												else if (Conversions.ToDouble(Strings.Trim(Conversions.ToString(Conversions.ToDouble(text5) - Conversions.ToDouble(Strings.Trim(lbl_CL3.get_Text()))))) < 0.0)
												{
													grFavourite3.get_HeaderAppearance().set_BorderColor(Color.Red);
													grFavourite3.get_HeaderAppearance().set_ForeColor(Color.Red);
													((Control)grFavourite3).set_ForeColor(Color.Red);
												}
												else
												{
													grFavourite3.get_HeaderAppearance().set_BorderColor(Color.Black);
													grFavourite3.get_HeaderAppearance().set_ForeColor(Color.Black);
													((Control)grFavourite3).set_ForeColor(Color.Black);
												}
											}
										}
									}
									else if (num7 == Conversions.ToInteger("4"))
									{
										if (((Control)grFavourite4).get_Visible() && Operators.ConditionalCompareObjectEqual(((Control)grFavourite4).get_Tag(), (object)Strings.UCase(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 1 }, (string[])null)))), false))
										{
											if ((Strings.InStr(1, Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 0 }, (string[])null)), "CN", (CompareMethod)0) > 0) & ((Operators.CompareString(Strings.UCase(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null)))), "EQ", false) == 0) | (Operators.CompareString(Strings.UCase(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null)))), "BE", false) == 0)))
											{
												text5 = Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 8 }, (string[])null));
											}
											if (Operators.ConditionalCompareObjectEqual(((Control)grFavourite4).get_Tag(), (object)Strings.UCase(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null)))), false))
											{
												text5 = ((Strings.InStr(1, Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 0 }, (string[])null)), "1907", (CompareMethod)0) <= 0) ? Conversions.ToString(Conversions.ToDouble(Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 11 }, (string[])null)) / 100.0)), 2, (TriState)(-1), (TriState)(-2), (TriState)0))) : Conversions.ToString(Conversions.ToDouble(Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 3 }, (string[])null)) / 100.0)), 2, (TriState)(-1), (TriState)(-2), (TriState)0))));
											}
											if (Operators.CompareString(text5, "0", false) != 0 && ((Operators.CompareString(lbl_LP4.get_Text(), Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(text5))), 2, (TriState)(-1), (TriState)(-2), (TriState)0), false) != 0) & (Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 9 }, (string[])null)))) != 0.0)))
											{
												DoChangeFavouriteText(lbl_LP4, Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(text5))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
												DoChangeFavouriteText(lbl_C4, Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(text5) - Conversions.ToDouble(Strings.Trim(lbl_CL4.get_Text())))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
												DoChangeFavouriteText(lbl_PC4, Strings.FormatNumber((object)(Conversions.ToDouble(lbl_C4.get_Text()) / Conversions.ToDouble(Strings.Trim(lbl_CL4.get_Text())) * 100.0), 2, (TriState)(-1), (TriState)(-2), (TriState)0) + "%");
												if (Conversions.ToDouble(Strings.Trim(Conversions.ToString(Conversions.ToDouble(text5) - Conversions.ToDouble(Strings.Trim(lbl_CL4.get_Text()))))) > 0.0)
												{
													grFavourite4.get_HeaderAppearance().set_BorderColor(Color.Green);
													grFavourite4.get_HeaderAppearance().set_ForeColor(Color.Green);
													((Control)grFavourite4).set_ForeColor(Color.Green);
												}
												else if (Conversions.ToDouble(Strings.Trim(Conversions.ToString(Conversions.ToDouble(text5) - Conversions.ToDouble(Strings.Trim(lbl_CL4.get_Text()))))) < 0.0)
												{
													grFavourite4.get_HeaderAppearance().set_BorderColor(Color.Red);
													grFavourite4.get_HeaderAppearance().set_ForeColor(Color.Red);
													((Control)grFavourite4).set_ForeColor(Color.Red);
												}
												else
												{
													grFavourite4.get_HeaderAppearance().set_BorderColor(Color.Black);
													grFavourite4.get_HeaderAppearance().set_ForeColor(Color.Black);
													((Control)grFavourite4).set_ForeColor(Color.Black);
												}
											}
										}
									}
									else if (num7 == Conversions.ToInteger("5") && ((Control)grFavourite5).get_Visible())
									{
										if (Operators.ConditionalCompareObjectEqual(((Control)grFavourite5).get_Tag(), (object)Strings.UCase(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 1 }, (string[])null)))), false) && ((Strings.InStr(1, Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 0 }, (string[])null)), "CN", (CompareMethod)0) > 0) & ((Operators.CompareString(Strings.UCase(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null)))), "EQ", false) == 0) | (Operators.CompareString(Strings.UCase(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null)))), "BE", false) == 0))))
										{
											text5 = Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 8 }, (string[])null));
										}
										if (Operators.ConditionalCompareObjectEqual(((Control)grFavourite5).get_Tag(), (object)Strings.UCase(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null)))), false))
										{
											text5 = ((Strings.InStr(1, Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 0 }, (string[])null)), "1907", (CompareMethod)0) <= 0) ? Conversions.ToString(Conversions.ToDouble(Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 11 }, (string[])null)) / 100.0)), 2, (TriState)(-1), (TriState)(-2), (TriState)0))) : Conversions.ToString(Conversions.ToDouble(Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 3 }, (string[])null)) / 100.0)), 2, (TriState)(-1), (TriState)(-2), (TriState)0))));
										}
										if (Operators.CompareString(text5, "0", false) != 0 && ((Operators.CompareString(lbl_LP5.get_Text(), Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(text5))), 2, (TriState)(-1), (TriState)(-2), (TriState)0), false) != 0) & (Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 9 }, (string[])null)))) != 0.0)))
										{
											DoChangeFavouriteText(lbl_LP5, Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(text5))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
											DoChangeFavouriteText(lbl_C5, Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(text5) - Conversions.ToDouble(Strings.Trim(lbl_CL5.get_Text())))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
											DoChangeFavouriteText(lbl_PC5, Strings.FormatNumber((object)(Conversions.ToDouble(lbl_C5.get_Text()) / Conversions.ToDouble(Strings.Trim(lbl_CL5.get_Text())) * 100.0), 2, (TriState)(-1), (TriState)(-2), (TriState)0) + "%");
											if (Conversions.ToDouble(Strings.Trim(Conversions.ToString(Conversions.ToDouble(text5) - Conversions.ToDouble(Strings.Trim(lbl_CL5.get_Text()))))) > 0.0)
											{
												grFavourite5.get_HeaderAppearance().set_BorderColor(Color.Green);
												grFavourite5.get_HeaderAppearance().set_ForeColor(Color.Green);
												((Control)grFavourite5).set_ForeColor(Color.Green);
											}
											else if (Conversions.ToDouble(Strings.Trim(Conversions.ToString(Conversions.ToDouble(text5) - Conversions.ToDouble(Strings.Trim(lbl_CL5.get_Text()))))) < 0.0)
											{
												grFavourite5.get_HeaderAppearance().set_BorderColor(Color.Red);
												grFavourite5.get_HeaderAppearance().set_ForeColor(Color.Red);
												((Control)grFavourite5).set_ForeColor(Color.Red);
											}
											else
											{
												grFavourite5.get_HeaderAppearance().set_BorderColor(Color.Black);
												grFavourite5.get_HeaderAppearance().set_ForeColor(Color.Black);
												((Control)grFavourite5).set_ForeColor(Color.Black);
											}
										}
									}
								}
								else if (((Control)grFavourite1).get_Visible())
								{
									if (Operators.ConditionalCompareObjectEqual(((Control)grFavourite1).get_Tag(), (object)Strings.UCase(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 1 }, (string[])null)))), false) && ((Strings.InStr(1, Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 0 }, (string[])null)), "CN", (CompareMethod)0) > 0) & ((Operators.CompareString(Strings.UCase(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null)))), "EQ", false) == 0) | (Operators.CompareString(Strings.UCase(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null)))), "BE", false) == 0))))
									{
										text5 = Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 8 }, (string[])null));
									}
									if (Operators.ConditionalCompareObjectEqual(((Control)grFavourite1).get_Tag(), (object)Strings.UCase(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null)))), false))
									{
										text5 = ((Strings.InStr(1, Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 0 }, (string[])null)), "1907", (CompareMethod)0) <= 0) ? Conversions.ToString(Conversions.ToDouble(Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 11 }, (string[])null)) / 100.0)), 2, (TriState)(-1), (TriState)(-2), (TriState)0))) : Conversions.ToString(Conversions.ToDouble(Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 3 }, (string[])null)) / 100.0)), 2, (TriState)(-1), (TriState)(-2), (TriState)0))));
									}
									if (Operators.CompareString(text5, "0", false) != 0 && ((Operators.CompareString(lbl_LP1.get_Text(), Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 8 }, (string[])null)))), 2, (TriState)(-1), (TriState)(-2), (TriState)0), false) != 0) & (Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 9 }, (string[])null)))) != 0.0)))
									{
										DoChangeFavouriteText(lbl_LP1, Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(text5))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
										DoChangeFavouriteText(lbl_C1, Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(text5) - Conversions.ToDouble(Strings.Trim(lbl_CL1.get_Text())))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
										DoChangeFavouriteText(lbl_PC1, Strings.FormatNumber((object)(Conversions.ToDouble(lbl_C1.get_Text()) / Conversions.ToDouble(Strings.Trim(lbl_CL1.get_Text())) * 100.0), 2, (TriState)(-1), (TriState)(-2), (TriState)0) + "%");
										if (Conversions.ToDouble(Strings.Trim(Conversions.ToString(Conversions.ToDouble(text5) - Conversions.ToDouble(Strings.Trim(lbl_CL1.get_Text()))))) > 0.0)
										{
											grFavourite1.get_HeaderAppearance().set_BorderColor(Color.Green);
											grFavourite1.get_HeaderAppearance().set_ForeColor(Color.Green);
											((Control)grFavourite1).set_ForeColor(Color.Green);
										}
										else if (Conversions.ToDouble(Strings.Trim(Conversions.ToString(Conversions.ToDouble(text5) - Conversions.ToDouble(Strings.Trim(lbl_CL1.get_Text()))))) < 0.0)
										{
											grFavourite1.get_HeaderAppearance().set_BorderColor(Color.Red);
											grFavourite1.get_HeaderAppearance().set_ForeColor(Color.Red);
											((Control)grFavourite1).set_ForeColor(Color.Red);
										}
										else
										{
											grFavourite1.get_HeaderAppearance().set_BorderColor(Color.Black);
											grFavourite1.get_HeaderAppearance().set_ForeColor(Color.Black);
											((Control)grFavourite1).set_ForeColor(Color.Black);
										}
									}
								}
								num6++;
								num8 = num6;
								num4 = 5;
							}
							while (num8 <= 5);
						}
					}
					num2++;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void DoChangeText(string strGroup, string strTool, string theTextString)
	{
		try
		{
			if (((Control)this).get_InvokeRequired())
			{
				ChangeText changeText = DoChangeText;
				((Control)this).Invoke((Delegate)changeText, new object[3] { strGroup, strTool, theTextString });
				return;
			}
			switch (strTool)
			{
			case null:
			case "":
				((RibbonTabCollectionBase)ToolbarsManager.get_Ribbon().get_Tabs()).get_Item(0).get_Groups().get_Item(strGroup)
					.set_Caption(theTextString);
				break;
			case "TOTAL":
				((RibbonTabCollectionBase)ToolbarsManager.get_Ribbon().get_Tabs()).get_Item(0).get_Groups().get_Item(strGroup)
					.set_Caption(theTextString);
				break;
			default:
				((ToolPropsBase)((ToolsCollectionBase)((RibbonTabCollectionBase)ToolbarsManager.get_Ribbon().get_Tabs()).get_Item(0).get_Groups().get_Item(strGroup)
					.get_Tools()).get_Item(strTool).get_SharedProps()).set_Caption(theTextString);
				break;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void DoChangeStatus(string theTextString, bool Enabled_Disabled)
	{
		try
		{
			if (((Control)this).get_InvokeRequired())
			{
				Thread.Sleep(0);
				ChangeStatus changeStatus = DoChangeStatus;
				((Control)this).Invoke((Delegate)changeStatus, new object[2] { theTextString, Enabled_Disabled });
			}
			else
			{
				UltraStatusBar1.get_Panels().get_Item(1).set_Text(theTextString);
				UltraStatusBar1.get_Panels().get_Item(0).set_Enabled(Enabled_Disabled);
				UltraStatusBar1.get_Panels().get_Item(0).set_ToolTipText(theTextString);
				UltraStatusBar1.get_Panels().get_Item(0).get_Appearance()
					.ResetBackColor();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void DoChangeProcess(bool Enabled_Disabled)
	{
		try
		{
			if (((Control)this).get_InvokeRequired())
			{
				ChangeProcess changeProcess = DoChangeProcess;
				((Control)this).Invoke((Delegate)changeProcess, new object[1] { Enabled_Disabled });
			}
			else
			{
				UltraStatusBar1.get_Panels().get_Item(5).set_Enabled(Enabled_Disabled);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void DoChangeFavouriteText(Label lbl, string theTextString)
	{
		try
		{
			if (((Control)this).get_InvokeRequired())
			{
				ChangeFavouriteText changeFavouriteText = DoChangeFavouriteText;
				((Control)this).Invoke((Delegate)changeFavouriteText, new object[2] { lbl, theTextString });
			}
			else
			{
				lbl.set_Text(theTextString);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void DoChangeStatusText(string theTextString)
	{
		try
		{
			if (((Control)this).get_InvokeRequired())
			{
				ChangeStatusText changeStatusText = DoChangeStatusText;
				((Control)this).Invoke((Delegate)changeStatusText, new object[1] { theTextString });
			}
			else
			{
				UltraStatusPanel val = UltraStatusBar1.get_Panels().get_Item(6);
				val.set_Text(Conversions.ToString(Conversions.ToDouble(val.get_Text()) + 1.0));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void DoChangeProcessText(string theTextString)
	{
		try
		{
			if (((Control)this).get_InvokeRequired())
			{
				ChangeProcessText changeProcessText = DoChangeProcessText;
				((Control)this).Invoke((Delegate)changeProcessText, new object[1] { theTextString });
				return;
			}
			if (UltraStatusBar1.get_Panels().get_Item(5).get_Enabled())
			{
				UltraStatusBar1.get_Panels().get_Item(5).set_Enabled(false);
			}
			else
			{
				UltraStatusBar1.get_Panels().get_Item(5).set_Enabled(true);
			}
			if (UltraStatusBar1.get_Panels().get_Item(8).get_Visible())
			{
				UltraStatusBar1.get_Panels().get_Item(8).set_Text("String Length :: " + Conversions.ToString(theTextString.Length));
			}
			if (UltraStatusBar1.get_Panels().get_Item(9).get_Visible())
			{
				UltraStatusBar1.get_Panels().get_Item(9).set_Text(theTextString);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void DoEquityMethod(string str)
	{
		try
		{
			if (((Control)this).get_InvokeRequired())
			{
				Equity_Method equity_Method = DoEquityMethod;
				((Control)this).Invoke((Delegate)equity_Method, new object[1] { str });
			}
			else
			{
				if (UltraTabbedMdiManager1.get_ActiveTab() == null)
				{
					return;
				}
				string key = ((KeyedSubObjectBase)UltraTabbedMdiManager1.get_ActiveTab()).get_Key();
				if (((DisposableObjectCollectionBase)UltraTabbedMdiManager1.get_TabGroups()).get_Count() == 2 && ((DisposableObjectCollectionBase)UltraTabbedMdiManager1.get_TabGroups().get_Item(1).get_Tabs()).get_Count() > 0)
				{
					key = ((KeyedSubObjectBase)UltraTabbedMdiManager1.get_TabGroups().get_Item(0).get_SelectedTab()).get_Key();
				}
				Strings.Split(str, "AAA", -1, (CompareMethod)0);
				Array array = Strings.Split(str, "|", -1, (CompareMethod)0);
				if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"CN", false), Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"CX", false)), Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"1907", false)), Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"1906", false))))
				{
					CheckDataComing();
				}
				switch (key)
				{
				case "1":
					if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"CN", false), Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"CX", false))) && fEquity1.ExchangeSymbol.Contains(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null), (object)","))))
					{
						fEquity1.CrunchData(str);
					}
					if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"1907", false), Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"1906", false))) && fEquity1.ExchangeSymbol.Contains(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null), (object)","))))
					{
						fEquity1.CrunchData(str);
					}
					break;
				case "2":
					if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"CN", false), Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"CX", false))) && fEquity2.ExchangeSymbol.Contains(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null), (object)","))))
					{
						fEquity2.CrunchData(str);
					}
					if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"1907", false), Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"1906", false))) && fEquity2.ExchangeSymbol.Contains(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null), (object)","))))
					{
						fEquity2.CrunchData(str);
					}
					break;
				case "3":
					if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"CN", false), Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"CX", false))) && fEquity3.ExchangeSymbol.Contains(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null), (object)","))))
					{
						fEquity3.CrunchData(str);
					}
					if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"1907", false), Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"1906", false))) && fEquity3.ExchangeSymbol.Contains(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null), (object)","))))
					{
						fEquity3.CrunchData(str);
					}
					break;
				case "4":
					if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"CN", false), Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"CX", false))) && fEquity4.ExchangeSymbol.Contains(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null), (object)","))))
					{
						fEquity4.CrunchData(str);
					}
					if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"1907", false), Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"1906", false))) && fEquity4.ExchangeSymbol.Contains(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null), (object)","))))
					{
						fEquity4.CrunchData(str);
					}
					break;
				case "5":
					if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"CN", false), Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"CX", false))) && fEquity5.ExchangeSymbol.Contains(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null), (object)","))))
					{
						fEquity5.CrunchData(str);
					}
					if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"1907", false), Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"1906", false))) && fEquity5.ExchangeSymbol.Contains(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null), (object)","))))
					{
						fEquity5.CrunchData(str);
					}
					break;
				}
				if (((DisposableObjectCollectionBase)UltraTabbedMdiManager1.get_TabGroups()).get_Count() != 2 || ((DisposableObjectCollectionBase)UltraTabbedMdiManager1.get_TabGroups().get_Item(1).get_Tabs()).get_Count() == 0)
				{
					return;
				}
				array = Strings.Split(str, "|", -1, (CompareMethod)0);
				if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"CN", false), Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"CX", false)), Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"1907", false)), Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"1906", false))))
				{
					CheckDataComing();
				}
				switch (((KeyedSubObjectBase)UltraTabbedMdiManager1.get_TabGroups().get_Item(1).get_SelectedTab()).get_Key())
				{
				case "1":
					if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"CN", false), Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"CX", false))) && fEquity1.ExchangeSymbol.Contains(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null), (object)","))))
					{
						fEquity1.CrunchData(str);
					}
					if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"1907", false), Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"1906", false))) && fEquity1.ExchangeSymbol.Contains(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null), (object)","))))
					{
						fEquity1.CrunchData(str);
					}
					break;
				case "2":
					if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"CN", false), Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"CX", false))) && fEquity2.ExchangeSymbol.Contains(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null), (object)","))))
					{
						fEquity2.CrunchData(str);
					}
					if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"1907", false), Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"1906", false))) && fEquity2.ExchangeSymbol.Contains(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null), (object)","))))
					{
						fEquity2.CrunchData(str);
					}
					break;
				case "3":
					if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"CN", false), Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"CX", false))) && fEquity3.ExchangeSymbol.Contains(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null), (object)","))))
					{
						fEquity3.CrunchData(str);
					}
					if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"1907", false), Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"1906", false))) && fEquity3.ExchangeSymbol.Contains(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null), (object)","))))
					{
						fEquity3.CrunchData(str);
					}
					break;
				case "4":
					if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"CN", false), Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"CX", false))) && fEquity4.ExchangeSymbol.Contains(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null), (object)","))))
					{
						fEquity4.CrunchData(str);
					}
					if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"1907", false), Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"1906", false))) && fEquity4.ExchangeSymbol.Contains(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null), (object)","))))
					{
						fEquity4.CrunchData(str);
					}
					break;
				case "5":
					if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"CN", false), Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"CX", false))) && fEquity5.ExchangeSymbol.Contains(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null), (object)","))))
					{
						fEquity5.CrunchData(str);
					}
					if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"1907", false), Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"1906", false))))
					{
						if (fEquity5.ExchangeSymbol.Contains(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null), (object)","))))
						{
							fEquity5.CrunchData(str);
						}
						CheckDataComing();
					}
					break;
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void DoEquityMethod_All(string str)
	{
		checked
		{
			try
			{
				if (((Control)this).get_InvokeRequired())
				{
					Equity_Method equity_Method = DoEquityMethod_All;
					((Control)this).Invoke((Delegate)equity_Method, new object[1] { str });
				}
				else
				{
					if (UltraTabbedMdiManager1.get_ActiveTab() == null)
					{
						return;
					}
					string key = ((KeyedSubObjectBase)UltraTabbedMdiManager1.get_ActiveTab()).get_Key();
					if (((DisposableObjectCollectionBase)UltraTabbedMdiManager1.get_TabGroups()).get_Count() == 2 && ((DisposableObjectCollectionBase)UltraTabbedMdiManager1.get_TabGroups().get_Item(1).get_Tabs()).get_Count() > 0)
					{
						key = ((KeyedSubObjectBase)UltraTabbedMdiManager1.get_TabGroups().get_Item(0).get_SelectedTab()).get_Key();
					}
					Strings.Split(str, "AAA", -1, (CompareMethod)0);
					int num = ((DisposableObjectCollectionBase)UltraTabbedMdiManager1.get_TabGroups()).get_Count() - 1;
					i = 0;
					while (true)
					{
						int num2 = i;
						int num3 = num;
						if (num2 > num3)
						{
							break;
						}
						int num4 = ((DisposableObjectCollectionBase)UltraTabbedMdiManager1.get_TabGroups().get_Item(i).get_Tabs()).get_Count() - 1;
						int num5 = 0;
						while (true)
						{
							int num6 = num5;
							num3 = num4;
							if (num6 > num3)
							{
								break;
							}
							key = "";
							switch (((KeyedSubObjectBase)((MdiTabsBaseCollection)UltraTabbedMdiManager1.get_TabGroups().get_Item(i).get_Tabs()).get_Item(num5)).get_Key())
							{
							case "1":
							{
								Array array = Strings.Split(str, "|", -1, (CompareMethod)0);
								if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"CN", false), Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"CX", false))) && fEquity1.ExchangeSymbol.Contains(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null), (object)","))))
								{
									fEquity1.CrunchData(str);
								}
								if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"1907", false), Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"1906", false))) && fEquity1.ExchangeSymbol.Contains(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null), (object)","))))
								{
									fEquity1.CrunchData(str);
								}
								break;
							}
							case "2":
							{
								Array array = Strings.Split(str, "|", -1, (CompareMethod)0);
								if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"CN", false), Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"CX", false))) && fEquity2.ExchangeSymbol.Contains(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null), (object)","))))
								{
									fEquity2.CrunchData(str);
								}
								if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"1907", false), Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"1906", false))) && fEquity2.ExchangeSymbol.Contains(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null), (object)","))))
								{
									fEquity2.CrunchData(str);
								}
								break;
							}
							case "3":
							{
								Array array = Strings.Split(str, "|", -1, (CompareMethod)0);
								if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"CN", false), Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"CX", false))) && fEquity3.ExchangeSymbol.Contains(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null), (object)","))))
								{
									fEquity3.CrunchData(str);
								}
								if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"1907", false), Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"1906", false))) && fEquity3.ExchangeSymbol.Contains(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null), (object)","))))
								{
									fEquity3.CrunchData(str);
								}
								break;
							}
							case "4":
							{
								Array array = Strings.Split(str, "|", -1, (CompareMethod)0);
								if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"CN", false), Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"CX", false))) && fEquity4.ExchangeSymbol.Contains(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null), (object)","))))
								{
									fEquity4.CrunchData(str);
								}
								if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"1907", false), Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"1906", false))) && fEquity4.ExchangeSymbol.Contains(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null), (object)","))))
								{
									fEquity4.CrunchData(str);
								}
								break;
							}
							case "5":
							{
								Array array = Strings.Split(str, "|", -1, (CompareMethod)0);
								if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"CN", false), Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"CX", false))) && fEquity5.ExchangeSymbol.Contains(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null), (object)","))))
								{
									fEquity5.CrunchData(str);
								}
								if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"1907", false), Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"1906", false))) && fEquity5.ExchangeSymbol.Contains(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null), (object)","))))
								{
									fEquity5.CrunchData(str);
								}
								break;
							}
							}
							num5++;
						}
						i++;
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private bool Check_If_TabExists(string frmText, string frmKey)
	{
		checked
		{
			bool result = default(bool);
			try
			{
				if (((DisposableObjectCollectionBase)UltraTabbedMdiManager1.get_TabGroups()).get_Count() > 0)
				{
					int num = ((DisposableObjectCollectionBase)UltraTabbedMdiManager1.get_TabGroups()).get_Count() - 1;
					i = 0;
					while (true)
					{
						int num2 = i;
						int num3 = num;
						if (num2 > num3)
						{
							break;
						}
						int num4 = ((DisposableObjectCollectionBase)UltraTabbedMdiManager1.get_TabGroups().get_Item(i).get_Tabs()).get_Count() - 1;
						int num5 = 0;
						while (true)
						{
							int num6 = num5;
							num3 = num4;
							if (num6 > num3)
							{
								break;
							}
							if (Operators.CompareString(((KeyedSubObjectBase)((MdiTabsBaseCollection)UltraTabbedMdiManager1.get_TabGroups().get_Item(i).get_Tabs()).get_Item(num5)).get_Key(), frmKey, false) != 0)
							{
								num5++;
								continue;
							}
							((MdiTabsBaseCollection)UltraTabbedMdiManager1.get_TabGroups().get_Item(i).get_Tabs()).get_Item(num5).Activate();
							result = true;
							return result;
						}
						i++;
					}
				}
				result = false;
				return result;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	private void SetNewCursor(string strSet)
	{
		try
		{
			if (Operators.CompareString(strSet, "NEW", false) == 0)
			{
				CNBCCursor = Icon.FromHandle(Cursors.get_Arrow().CopyHandle());
				string lpFileName = Application.get_StartupPath() + "\\arrow_cnbc.cur";
				LoadCursorFromFileA(ref lpFileName);
			}
			else
			{
				IntPtr handle = CNBCCursor.get_Handle();
				SetSystemCursor(handle, 32512);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void ReConnect_30Seconds()
	{
		try
		{
			writeToFile("ReConnect_30Seconds :: " + Conversions.ToString(DateAndTime.get_Now()));
			Thread.Sleep(10);
			PowerUDP.get_Socket().Close();
			PowerUDP.Close();
			((Component)(object)PowerUDP).Dispose();
			Thread.Sleep(10);
			Application.DoEvents();
			PowerUDP_Connect();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void writeToFile(string aa)
	{
		StreamWriter streamWriter = File.AppendText("data.txt");
		DateAndTime.get_Now();
		string path = "data.txt";
		if (File.Exists(path))
		{
			streamWriter.WriteLine(aa);
			streamWriter.Flush();
			streamWriter.Close();
		}
	}

	private void GetColorScheme()
	{
		try
		{
			dt = new DataTable();
			strSQL = "SELECT * FROM CNBCMONEY_USERS_MST WHERE USERNAME = '" + mdlMain.gUserName + "' AND COLOR_SCHEME IS NOT NULL";
			dt = SqlHelper.ExecuteDataset(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL).Tables[0];
			if (dt.Rows.Count > 0)
			{
				mdlMain.INIWrite(Application.get_StartupPath() + "/MONEY_CONFIG.INI", "MAIN", "COLOR_SCHEME", Conversions.ToString(dt.Rows[0]["COLOR_SCHEME"]));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void FirstLogin()
	{
		try
		{
			objEquity = new clsEquity();
			objEquity.AddLookUp("CONNECTEDUSERS", "CONNECTEDUSERS", "CONNECTEDUSERS", 111);
			objEquity.AddLookUp("in;sen", "SENSEX", "CONNECTEDUSERS", 111);
			objEquity.AddLookUp("in;nsx", "S&P CNX NIFTY", "CONNECTEDUSERS", 111);
			objEquity.AddLookUp("in;ccx", "CNX MIDCAP", "CONNECTEDUSERS", 111);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void SendToBroadCast()
	{
		ExchangeSymbol = "";
		try
		{
			if (UltraTabbedMdiManager1.get_ActiveTab() != null)
			{
				string key = ((KeyedSubObjectBase)UltraTabbedMdiManager1.get_ActiveTab()).get_Key();
				if (((DisposableObjectCollectionBase)UltraTabbedMdiManager1.get_TabGroups()).get_Count() == 2 && ((DisposableObjectCollectionBase)UltraTabbedMdiManager1.get_TabGroups().get_Item(1).get_Tabs()).get_Count() > 0)
				{
					key = ((KeyedSubObjectBase)UltraTabbedMdiManager1.get_TabGroups().get_Item(0).get_SelectedTab()).get_Key();
				}
				switch (key)
				{
				case "1":
					ExchangeSymbol += fEquity1.ExchangeSymbol;
					break;
				case "2":
					ExchangeSymbol += fEquity2.ExchangeSymbol;
					break;
				case "3":
					ExchangeSymbol += fEquity3.ExchangeSymbol;
					break;
				case "4":
					ExchangeSymbol += fEquity4.ExchangeSymbol;
					break;
				case "5":
					ExchangeSymbol += fEquity5.ExchangeSymbol;
					break;
				}
				if (((DisposableObjectCollectionBase)UltraTabbedMdiManager1.get_TabGroups()).get_Count() == 2)
				{
					if (((DisposableObjectCollectionBase)UltraTabbedMdiManager1.get_TabGroups().get_Item(1).get_Tabs()).get_Count() == 0)
					{
						return;
					}
					switch (((KeyedSubObjectBase)UltraTabbedMdiManager1.get_TabGroups().get_Item(1).get_SelectedTab()).get_Key())
					{
					case "1":
						ExchangeSymbol += fEquity1.ExchangeSymbol;
						break;
					case "2":
						ExchangeSymbol += fEquity2.ExchangeSymbol;
						break;
					case "3":
						ExchangeSymbol += fEquity3.ExchangeSymbol;
						break;
					case "4":
						ExchangeSymbol += fEquity4.ExchangeSymbol;
						break;
					case "5":
						ExchangeSymbol += fEquity5.ExchangeSymbol;
						break;
					}
				}
			}
			ExchangeSymbol = Conversions.ToString(NewLateBinding.LateGet((object)null, typeof(Strings), "UCase", new object[1] { Operators.ConcatenateObject(Operators.ConcatenateObject(Favourites, (object)"SENSEX,S&P CNX NIFTY,CNX MIDCAP,"), (object)ExchangeSymbol) }, (string[])null, (Type[])null, (bool[])null));
			if (Operators.CompareString(ExchangeSymbol, "", false) != 0)
			{
				objEquity = new clsEquity();
				ExchangeSymbol = Strings.UCase(mdlMain.gUserName) + "|" + ExchangeSymbol;
				PowerUDP.Send(ExchangeSymbol, mdlMain.INIRead(Application.get_StartupPath() + "/MONEY_CONFIG.INI", mdlMain.gMain, "BC_BSE_IP", ""), mdlMain.INIRead(Application.get_StartupPath() + "/MONEY_CONFIG.INI", mdlMain.gMain, "BC_BSE_PORT", ""));
				PowerUDP.Send(ExchangeSymbol, mdlMain.INIRead(Application.get_StartupPath() + "/MONEY_CONFIG.INI", mdlMain.gMain, "BC_NSE_IP", ""), mdlMain.INIRead(Application.get_StartupPath() + "/MONEY_CONFIG.INI", mdlMain.gMain, "BC_NSE_PORT", ""));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void CheckDataComing(string strText = "Connected", bool strflag = true)
	{
		try
		{
			DoChangeStatus(strText, strflag);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
