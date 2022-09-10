using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using NVCameraControl;
using NVCameraViewer.My;
using NVCameraViewer.My.Resources;

namespace NVCameraViewer;

[DesignerGenerated]
public class frmMain : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Status")]
	private StatusStrip _Status;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("ContextMenu")]
	private ContextMenuStrip _ContextMenu;

	[AccessedThroughProperty("tsmReconnect")]
	private ToolStripMenuItem _tsmReconnect;

	[AccessedThroughProperty("tsmCloseCamera")]
	private ToolStripMenuItem _tsmCloseCamera;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("cboProfile")]
	private ComboBox _cboProfile;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("lblBPSOut")]
	private Label _lblBPSOut;

	[AccessedThroughProperty("lblBPSIn")]
	private Label _lblBPSIn;

	[AccessedThroughProperty("lblTotalIn")]
	private Label _lblTotalIn;

	[AccessedThroughProperty("lblTotalOut")]
	private Label _lblTotalOut;

	[AccessedThroughProperty("CameraMonitor")]
	private SplitMonitorControl _CameraMonitor;

	[AccessedThroughProperty("FlowTimer")]
	private Timer _FlowTimer;

	[AccessedThroughProperty("FlowMRTG")]
	private MRTGControl _FlowMRTG;

	[AccessedThroughProperty("btnConfig")]
	private Button _btnConfig;

	[AccessedThroughProperty("btnConnect")]
	private Button _btnConnect;

	[AccessedThroughProperty("btnExit")]
	private Button _btnExit;

	[AccessedThroughProperty("btnPlayback")]
	private Button _btnPlayback;

	[AccessedThroughProperty("btnCapture")]
	private Button _btnCapture;

	[AccessedThroughProperty("CurrentDateTime")]
	private ToolStripStatusLabel _CurrentDateTime;

	[AccessedThroughProperty("ToolStripSeparator1")]
	private ToolStripSeparator _ToolStripSeparator1;

	[AccessedThroughProperty("tsmCloseMenu")]
	private ToolStripMenuItem _tsmCloseMenu;

	[AccessedThroughProperty("tsmStopPlayback")]
	private ToolStripMenuItem _tsmStopPlayback;

	[AccessedThroughProperty("tsmCameraName")]
	private ToolStripMenuItem _tsmCameraName;

	[AccessedThroughProperty("ToolStripSeparator2")]
	private ToolStripSeparator _ToolStripSeparator2;

	[AccessedThroughProperty("tsmCapture")]
	private ToolStripMenuItem _tsmCapture;

	[AccessedThroughProperty("ToolStripSeparator3")]
	private ToolStripSeparator _ToolStripSeparator3;

	[AccessedThroughProperty("tsmPlayback")]
	private ToolStripMenuItem _tsmPlayback;

	private long iTotalIn;

	private long iTotalOut;

	private bool IsArchiveMode;

	private CameraControl iClickedCamera;

	private ProfileClass.enumSplitType iCurrentSplit;

	internal virtual StatusStrip Status
	{
		[DebuggerNonUserCode]
		get
		{
			return _Status;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Status = value;
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

	internal virtual Label Label1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label1 = value;
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

	internal virtual ContextMenuStrip ContextMenu
	{
		[DebuggerNonUserCode]
		get
		{
			return _ContextMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ContextMenu = value;
		}
	}

	internal virtual ToolStripMenuItem tsmReconnect
	{
		[DebuggerNonUserCode]
		get
		{
			return _tsmReconnect;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = tsmReconnect_Click;
			if (_tsmReconnect != null)
			{
				((ToolStripItem)_tsmReconnect).remove_Click(eventHandler);
			}
			_tsmReconnect = value;
			if (_tsmReconnect != null)
			{
				((ToolStripItem)_tsmReconnect).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem tsmCloseCamera
	{
		[DebuggerNonUserCode]
		get
		{
			return _tsmCloseCamera;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = tsmCloseCamera_Click;
			if (_tsmCloseCamera != null)
			{
				((ToolStripItem)_tsmCloseCamera).remove_Click(eventHandler);
			}
			_tsmCloseCamera = value;
			if (_tsmCloseCamera != null)
			{
				((ToolStripItem)_tsmCloseCamera).add_Click(eventHandler);
			}
		}
	}

	internal virtual GroupBox GroupBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox1 = value;
		}
	}

	internal virtual ComboBox cboProfile
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboProfile;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboProfile = value;
		}
	}

	internal virtual Label Label5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label5 = value;
		}
	}

	internal virtual Label Label4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label4 = value;
		}
	}

	internal virtual Label Label3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label3 = value;
		}
	}

	internal virtual Label Label2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual Label lblBPSOut
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblBPSOut;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblBPSOut = value;
		}
	}

	internal virtual Label lblBPSIn
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblBPSIn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblBPSIn = value;
		}
	}

	internal virtual Label lblTotalIn
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTotalIn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTotalIn = value;
		}
	}

	internal virtual Label lblTotalOut
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTotalOut;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTotalOut = value;
		}
	}

	internal virtual SplitMonitorControl CameraMonitor
	{
		[DebuggerNonUserCode]
		get
		{
			return _CameraMonitor;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			CameraClickEventHandler val = new CameraClickEventHandler(CameraMonitor_CameraClick);
			if (_CameraMonitor != null)
			{
				_CameraMonitor.remove_CameraClick(val);
			}
			_CameraMonitor = value;
			if (_CameraMonitor != null)
			{
				_CameraMonitor.add_CameraClick(val);
			}
		}
	}

	internal virtual Timer FlowTimer
	{
		[DebuggerNonUserCode]
		get
		{
			return _FlowTimer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = FlowTimer_Tick;
			if (_FlowTimer != null)
			{
				_FlowTimer.remove_Tick(eventHandler);
			}
			_FlowTimer = value;
			if (_FlowTimer != null)
			{
				_FlowTimer.add_Tick(eventHandler);
			}
		}
	}

	internal virtual MRTGControl FlowMRTG
	{
		[DebuggerNonUserCode]
		get
		{
			return _FlowMRTG;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_FlowMRTG = value;
		}
	}

	internal virtual Button btnConfig
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnConfig;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnConfig_Click;
			if (_btnConfig != null)
			{
				((Control)_btnConfig).remove_Click(eventHandler);
			}
			_btnConfig = value;
			if (_btnConfig != null)
			{
				((Control)_btnConfig).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button btnConnect
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnConnect;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnConnect_Click;
			if (_btnConnect != null)
			{
				((Control)_btnConnect).remove_Click(eventHandler);
			}
			_btnConnect = value;
			if (_btnConnect != null)
			{
				((Control)_btnConnect).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button btnExit
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnExit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnExit_Click;
			if (_btnExit != null)
			{
				((Control)_btnExit).remove_Click(eventHandler);
			}
			_btnExit = value;
			if (_btnExit != null)
			{
				((Control)_btnExit).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button btnPlayback
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnPlayback;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnPlayback_Click;
			if (_btnPlayback != null)
			{
				((Control)_btnPlayback).remove_Click(eventHandler);
			}
			_btnPlayback = value;
			if (_btnPlayback != null)
			{
				((Control)_btnPlayback).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button btnCapture
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnCapture;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnCapture_Click;
			if (_btnCapture != null)
			{
				((Control)_btnCapture).remove_Click(eventHandler);
			}
			_btnCapture = value;
			if (_btnCapture != null)
			{
				((Control)_btnCapture).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripStatusLabel CurrentDateTime
	{
		[DebuggerNonUserCode]
		get
		{
			return _CurrentDateTime;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CurrentDateTime = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripSeparator1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripSeparator1 = value;
		}
	}

	internal virtual ToolStripMenuItem tsmCloseMenu
	{
		[DebuggerNonUserCode]
		get
		{
			return _tsmCloseMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = tsmCloseMenu_Click;
			if (_tsmCloseMenu != null)
			{
				((ToolStripItem)_tsmCloseMenu).remove_Click(eventHandler);
			}
			_tsmCloseMenu = value;
			if (_tsmCloseMenu != null)
			{
				((ToolStripItem)_tsmCloseMenu).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem tsmStopPlayback
	{
		[DebuggerNonUserCode]
		get
		{
			return _tsmStopPlayback;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = tsmStopPlayback_Click;
			if (_tsmStopPlayback != null)
			{
				((ToolStripItem)_tsmStopPlayback).remove_Click(eventHandler);
			}
			_tsmStopPlayback = value;
			if (_tsmStopPlayback != null)
			{
				((ToolStripItem)_tsmStopPlayback).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem tsmCameraName
	{
		[DebuggerNonUserCode]
		get
		{
			return _tsmCameraName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tsmCameraName = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripSeparator2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripSeparator2 = value;
		}
	}

	internal virtual ToolStripMenuItem tsmCapture
	{
		[DebuggerNonUserCode]
		get
		{
			return _tsmCapture;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = tsmCapture_Click;
			if (_tsmCapture != null)
			{
				((ToolStripItem)_tsmCapture).remove_Click(eventHandler);
			}
			_tsmCapture = value;
			if (_tsmCapture != null)
			{
				((ToolStripItem)_tsmCapture).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator3
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripSeparator3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripSeparator3 = value;
		}
	}

	internal virtual ToolStripMenuItem tsmPlayback
	{
		[DebuggerNonUserCode]
		get
		{
			return _tsmPlayback;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = tsmPlayback_Click;
			if (_tsmPlayback != null)
			{
				((ToolStripItem)_tsmPlayback).remove_Click(eventHandler);
			}
			_tsmPlayback = value;
			if (_tsmPlayback != null)
			{
				((ToolStripItem)_tsmPlayback).add_Click(eventHandler);
			}
		}
	}

	public frmMain()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(frmMain_FormClosing));
		((Control)this).add_KeyDown(new KeyEventHandler(frmMain_KeyDown));
		((Form)this).add_ResizeEnd((EventHandler)frmMain_ResizeEnd);
		((Control)this).add_SizeChanged((EventHandler)frmMain_SizeChanged);
		((Form)this).add_Load((EventHandler)frmMain_Load);
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		iTotalIn = 0L;
		iTotalOut = 0L;
		IsArchiveMode = false;
		iClickedCamera = null;
		iCurrentSplit = ProfileClass.enumSplitType.Split_2x2;
		InitializeComponent();
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
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		components = new Container();
		Status = new StatusStrip();
		CurrentDateTime = new ToolStripStatusLabel();
		Panel1 = new Panel();
		GroupBox1 = new GroupBox();
		lblBPSOut = new Label();
		lblBPSIn = new Label();
		lblTotalIn = new Label();
		lblTotalOut = new Label();
		Label5 = new Label();
		Label4 = new Label();
		Label3 = new Label();
		Label2 = new Label();
		cboProfile = new ComboBox();
		Label1 = new Label();
		Panel2 = new Panel();
		CameraMonitor = new SplitMonitorControl();
		ContextMenu = new ContextMenuStrip(components);
		tsmCameraName = new ToolStripMenuItem();
		ToolStripSeparator2 = new ToolStripSeparator();
		tsmReconnect = new ToolStripMenuItem();
		tsmCloseCamera = new ToolStripMenuItem();
		tsmCapture = new ToolStripMenuItem();
		ToolStripSeparator3 = new ToolStripSeparator();
		tsmPlayback = new ToolStripMenuItem();
		tsmStopPlayback = new ToolStripMenuItem();
		ToolStripSeparator1 = new ToolStripSeparator();
		tsmCloseMenu = new ToolStripMenuItem();
		FlowTimer = new Timer(components);
		btnExit = new Button();
		btnPlayback = new Button();
		btnCapture = new Button();
		btnConfig = new Button();
		btnConnect = new Button();
		FlowMRTG = new MRTGControl();
		((Control)Status).SuspendLayout();
		((Control)Panel1).SuspendLayout();
		((Control)GroupBox1).SuspendLayout();
		((Control)Panel2).SuspendLayout();
		((Control)ContextMenu).SuspendLayout();
		((Control)this).SuspendLayout();
		((ToolStrip)Status).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)CurrentDateTime });
		StatusStrip status = Status;
		Point location = new Point(0, 544);
		((Control)status).set_Location(location);
		((Control)Status).set_Name("Status");
		StatusStrip status2 = Status;
		Size size = new Size(792, 22);
		((Control)status2).set_Size(size);
		((Control)Status).set_TabIndex(0);
		((Control)Status).set_Text("StatusStrip1");
		((ToolStripItem)CurrentDateTime).set_Name("CurrentDateTime");
		ToolStripStatusLabel currentDateTime = CurrentDateTime;
		size = new Size(0, 17);
		((ToolStripItem)currentDateTime).set_Size(size);
		((Control)Panel1).get_Controls().Add((Control)(object)btnExit);
		((Control)Panel1).get_Controls().Add((Control)(object)btnPlayback);
		((Control)Panel1).get_Controls().Add((Control)(object)btnCapture);
		((Control)Panel1).get_Controls().Add((Control)(object)btnConfig);
		((Control)Panel1).get_Controls().Add((Control)(object)btnConnect);
		((Control)Panel1).get_Controls().Add((Control)(object)GroupBox1);
		((Control)Panel1).get_Controls().Add((Control)(object)cboProfile);
		((Control)Panel1).get_Controls().Add((Control)(object)Label1);
		((Control)Panel1).set_Dock((DockStyle)4);
		Panel panel = Panel1;
		location = new Point(591, 0);
		((Control)panel).set_Location(location);
		((Control)Panel1).set_Name("Panel1");
		Panel panel2 = Panel1;
		size = new Size(201, 544);
		((Control)panel2).set_Size(size);
		((Control)Panel1).set_TabIndex(1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)FlowMRTG);
		((Control)GroupBox1).get_Controls().Add((Control)(object)lblBPSOut);
		((Control)GroupBox1).get_Controls().Add((Control)(object)lblBPSIn);
		((Control)GroupBox1).get_Controls().Add((Control)(object)lblTotalIn);
		((Control)GroupBox1).get_Controls().Add((Control)(object)lblTotalOut);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label5);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label4);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label2);
		GroupBox groupBox = GroupBox1;
		location = new Point(8, 74);
		((Control)groupBox).set_Location(location);
		((Control)GroupBox1).set_Name("GroupBox1");
		GroupBox groupBox2 = GroupBox1;
		size = new Size(190, 128);
		((Control)groupBox2).set_Size(size);
		((Control)GroupBox1).set_TabIndex(2);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("網路流量");
		lblBPSOut.set_AutoSize(true);
		Label obj = lblBPSOut;
		location = new Point(147, 22);
		((Control)obj).set_Location(location);
		((Control)lblBPSOut).set_Name("lblBPSOut");
		Label obj2 = lblBPSOut;
		size = new Size(11, 12);
		((Control)obj2).set_Size(size);
		((Control)lblBPSOut).set_TabIndex(7);
		lblBPSOut.set_Text("0");
		lblBPSIn.set_AutoSize(true);
		Label obj3 = lblBPSIn;
		location = new Point(47, 22);
		((Control)obj3).set_Location(location);
		((Control)lblBPSIn).set_Name("lblBPSIn");
		Label obj4 = lblBPSIn;
		size = new Size(11, 12);
		((Control)obj4).set_Size(size);
		((Control)lblBPSIn).set_TabIndex(6);
		lblBPSIn.set_Text("0");
		lblTotalIn.set_AutoSize(true);
		Label obj5 = lblTotalIn;
		location = new Point(47, 48);
		((Control)obj5).set_Location(location);
		((Control)lblTotalIn).set_Name("lblTotalIn");
		Label obj6 = lblTotalIn;
		size = new Size(11, 12);
		((Control)obj6).set_Size(size);
		((Control)lblTotalIn).set_TabIndex(5);
		lblTotalIn.set_Text("0");
		lblTotalOut.set_AutoSize(true);
		Label obj7 = lblTotalOut;
		location = new Point(147, 48);
		((Control)obj7).set_Location(location);
		((Control)lblTotalOut).set_Name("lblTotalOut");
		Label obj8 = lblTotalOut;
		size = new Size(11, 12);
		((Control)obj8).set_Size(size);
		((Control)lblTotalOut).set_TabIndex(4);
		lblTotalOut.set_Text("0");
		Label5.set_AutoSize(true);
		Label label = Label5;
		location = new Point(96, 48);
		((Control)label).set_Location(location);
		((Control)Label5).set_Name("Label5");
		Label label2 = Label5;
		size = new Size(52, 12);
		((Control)label2).set_Size(size);
		((Control)Label5).set_TabIndex(3);
		Label5.set_Text("Total Out:");
		Label4.set_AutoSize(true);
		Label label3 = Label4;
		location = new Point(3, 48);
		((Control)label3).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label4 = Label4;
		size = new Size(45, 12);
		((Control)label4).set_Size(size);
		((Control)Label4).set_TabIndex(2);
		Label4.set_Text("Total In:");
		Label3.set_AutoSize(true);
		Label label5 = Label3;
		location = new Point(96, 22);
		((Control)label5).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label6 = Label3;
		size = new Size(48, 12);
		((Control)label6).set_Size(size);
		((Control)Label3).set_TabIndex(1);
		Label3.set_Text("BPS Out:");
		Label2.set_AutoSize(true);
		Label label7 = Label2;
		location = new Point(3, 22);
		((Control)label7).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label8 = Label2;
		size = new Size(41, 12);
		((Control)label8).set_Size(size);
		((Control)Label2).set_TabIndex(0);
		Label2.set_Text("BPS In:");
		cboProfile.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)cboProfile).set_FormattingEnabled(true);
		ComboBox obj9 = cboProfile;
		location = new Point(51, 6);
		((Control)obj9).set_Location(location);
		((Control)cboProfile).set_Name("cboProfile");
		ComboBox obj10 = cboProfile;
		size = new Size(121, 20);
		((Control)obj10).set_Size(size);
		((Control)cboProfile).set_TabIndex(1);
		Label1.set_AutoSize(true);
		Label label9 = Label1;
		location = new Point(6, 9);
		((Control)label9).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label10 = Label1;
		size = new Size(39, 12);
		((Control)label10).set_Size(size);
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("Profile:");
		((Control)Panel2).get_Controls().Add((Control)(object)CameraMonitor);
		((Control)Panel2).set_Dock((DockStyle)5);
		Panel panel3 = Panel2;
		location = new Point(0, 0);
		((Control)panel3).set_Location(location);
		((Control)Panel2).set_Name("Panel2");
		Panel panel4 = Panel2;
		size = new Size(591, 544);
		((Control)panel4).set_Size(size);
		((Control)Panel2).set_TabIndex(2);
		CameraMonitor.set_DisplayType((enumDisplayType)0);
		CameraMonitor.set_HeightCount(4);
		SplitMonitorControl cameraMonitor = CameraMonitor;
		location = new Point(0, 0);
		((Control)cameraMonitor).set_Location(location);
		((Control)CameraMonitor).set_Name("CameraMonitor");
		SplitMonitorControl cameraMonitor2 = CameraMonitor;
		size = new Size(494, 431);
		((Control)cameraMonitor2).set_Size(size);
		((Control)CameraMonitor).set_TabIndex(0);
		CameraMonitor.set_WidthCount(4);
		((ToolStrip)ContextMenu).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[10]
		{
			(ToolStripItem)tsmCameraName,
			(ToolStripItem)ToolStripSeparator2,
			(ToolStripItem)tsmReconnect,
			(ToolStripItem)tsmCloseCamera,
			(ToolStripItem)tsmCapture,
			(ToolStripItem)ToolStripSeparator3,
			(ToolStripItem)tsmPlayback,
			(ToolStripItem)tsmStopPlayback,
			(ToolStripItem)ToolStripSeparator1,
			(ToolStripItem)tsmCloseMenu
		});
		((Control)ContextMenu).set_Name("ContextMenuStrip1");
		ContextMenuStrip contextMenu = ContextMenu;
		size = new Size(169, 176);
		((Control)contextMenu).set_Size(size);
		tsmCameraName.set_Enabled(false);
		((ToolStripItem)tsmCameraName).set_Name("tsmCameraName");
		ToolStripMenuItem obj11 = tsmCameraName;
		size = new Size(168, 22);
		((ToolStripItem)obj11).set_Size(size);
		((ToolStripItem)tsmCameraName).set_Text("ToolStripMenuItem2");
		((ToolStripItem)ToolStripSeparator2).set_Name("ToolStripSeparator2");
		ToolStripSeparator toolStripSeparator = ToolStripSeparator2;
		size = new Size(165, 6);
		((ToolStripItem)toolStripSeparator).set_Size(size);
		((ToolStripItem)tsmReconnect).set_Name("tsmReconnect");
		ToolStripMenuItem obj12 = tsmReconnect;
		size = new Size(168, 22);
		((ToolStripItem)obj12).set_Size(size);
		((ToolStripItem)tsmReconnect).set_Text("重新連線");
		((ToolStripItem)tsmCloseCamera).set_Name("tsmCloseCamera");
		ToolStripMenuItem obj13 = tsmCloseCamera;
		size = new Size(168, 22);
		((ToolStripItem)obj13).set_Size(size);
		((ToolStripItem)tsmCloseCamera).set_Text("關閉視訊");
		((ToolStripItem)tsmCapture).set_Name("tsmCapture");
		ToolStripMenuItem obj14 = tsmCapture;
		size = new Size(168, 22);
		((ToolStripItem)obj14).set_Size(size);
		((ToolStripItem)tsmCapture).set_Text("拍照");
		((ToolStripItem)ToolStripSeparator3).set_Name("ToolStripSeparator3");
		ToolStripSeparator toolStripSeparator2 = ToolStripSeparator3;
		size = new Size(165, 6);
		((ToolStripItem)toolStripSeparator2).set_Size(size);
		((ToolStripItem)tsmPlayback).set_Name("tsmPlayback");
		ToolStripMenuItem obj15 = tsmPlayback;
		size = new Size(168, 22);
		((ToolStripItem)obj15).set_Size(size);
		((ToolStripItem)tsmPlayback).set_Text("回放影像");
		((ToolStripItem)tsmStopPlayback).set_Name("tsmStopPlayback");
		ToolStripMenuItem obj16 = tsmStopPlayback;
		size = new Size(168, 22);
		((ToolStripItem)obj16).set_Size(size);
		((ToolStripItem)tsmStopPlayback).set_Text("停止回放");
		((ToolStripItem)ToolStripSeparator1).set_Name("ToolStripSeparator1");
		ToolStripSeparator toolStripSeparator3 = ToolStripSeparator1;
		size = new Size(165, 6);
		((ToolStripItem)toolStripSeparator3).set_Size(size);
		((ToolStripItem)tsmCloseMenu).set_Name("tsmCloseMenu");
		ToolStripMenuItem obj17 = tsmCloseMenu;
		size = new Size(168, 22);
		((ToolStripItem)obj17).set_Size(size);
		((ToolStripItem)tsmCloseMenu).set_Text("關閉選單");
		FlowTimer.set_Interval(1000);
		((ButtonBase)btnExit).set_Image((Image)(object)Resources._exit);
		Button obj18 = btnExit;
		location = new Point(15, 440);
		((Control)obj18).set_Location(location);
		((Control)btnExit).set_Name("btnExit");
		Button obj19 = btnExit;
		size = new Size(110, 60);
		((Control)obj19).set_Size(size);
		((Control)btnExit).set_TabIndex(7);
		((ButtonBase)btnExit).set_Text("Exit");
		((ButtonBase)btnExit).set_TextImageRelation((TextImageRelation)4);
		((ButtonBase)btnExit).set_UseVisualStyleBackColor(true);
		((ButtonBase)btnPlayback).set_Image((Image)(object)Resources.Playback);
		Button obj20 = btnPlayback;
		location = new Point(15, 374);
		((Control)obj20).set_Location(location);
		((Control)btnPlayback).set_Name("btnPlayback");
		Button obj21 = btnPlayback;
		size = new Size(110, 60);
		((Control)obj21).set_Size(size);
		((Control)btnPlayback).set_TabIndex(6);
		((ButtonBase)btnPlayback).set_Text("Playback");
		((ButtonBase)btnPlayback).set_TextImageRelation((TextImageRelation)4);
		((ButtonBase)btnPlayback).set_UseVisualStyleBackColor(true);
		((ButtonBase)btnCapture).set_Image((Image)(object)Resources.camera);
		Button obj22 = btnCapture;
		location = new Point(15, 308);
		((Control)obj22).set_Location(location);
		((Control)btnCapture).set_Name("btnCapture");
		Button obj23 = btnCapture;
		size = new Size(110, 60);
		((Control)obj23).set_Size(size);
		((Control)btnCapture).set_TabIndex(5);
		((ButtonBase)btnCapture).set_Text("Capture");
		((ButtonBase)btnCapture).set_TextImageRelation((TextImageRelation)4);
		((ButtonBase)btnCapture).set_UseVisualStyleBackColor(true);
		((ButtonBase)btnConfig).set_Image((Image)(object)Resources.Config);
		Button obj24 = btnConfig;
		location = new Point(15, 242);
		((Control)obj24).set_Location(location);
		((Control)btnConfig).set_Name("btnConfig");
		Button obj25 = btnConfig;
		size = new Size(110, 60);
		((Control)obj25).set_Size(size);
		((Control)btnConfig).set_TabIndex(4);
		((ButtonBase)btnConfig).set_Text("Config");
		((ButtonBase)btnConfig).set_TextImageRelation((TextImageRelation)4);
		((ButtonBase)btnConfig).set_UseVisualStyleBackColor(true);
		((ButtonBase)btnConnect).set_Image((Image)(object)Resources.gg_connecting);
		((ButtonBase)btnConnect).set_ImageAlign((ContentAlignment)64);
		Button obj26 = btnConnect;
		location = new Point(6, 32);
		((Control)obj26).set_Location(location);
		((Control)btnConnect).set_Name("btnConnect");
		Button obj27 = btnConnect;
		size = new Size(192, 22);
		((Control)obj27).set_Size(size);
		((Control)btnConnect).set_TabIndex(3);
		((ButtonBase)btnConnect).set_Text("Connect");
		((ButtonBase)btnConnect).set_TextImageRelation((TextImageRelation)4);
		((ButtonBase)btnConnect).set_UseVisualStyleBackColor(true);
		((Control)FlowMRTG).set_BackColor(Color.Transparent);
		((Control)FlowMRTG).set_BackgroundImageLayout((ImageLayout)0);
		((UserControl)FlowMRTG).set_BorderStyle((BorderStyle)1);
		MRTGControl flowMRTG = FlowMRTG;
		location = new Point(7, 64);
		((Control)flowMRTG).set_Location(location);
		((Control)FlowMRTG).set_Name("FlowMRTG");
		MRTGControl flowMRTG2 = FlowMRTG;
		size = new Size(174, 58);
		((Control)flowMRTG2).set_Size(size);
		((Control)FlowMRTG).set_TabIndex(8);
		SizeF autoScaleDimensions = new SizeF(6f, 12f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(792, 566);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Panel2);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).get_Controls().Add((Control)(object)Status);
		((Form)this).set_KeyPreview(true);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("frmMain");
		((Form)this).set_Text("Form1");
		((Form)this).set_WindowState((FormWindowState)2);
		((Control)Status).ResumeLayout(false);
		((Control)Status).PerformLayout();
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)Panel2).ResumeLayout(false);
		((Control)ContextMenu).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
	{
		CloseServer();
		CameraMonitor.ClearControl();
	}

	private void frmMain_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Invalid comparison between I4 and Unknown
		int num = checked(Module1.SettingObject.Profiles.Length - 1);
		int num2 = 0;
		while (true)
		{
			int num3 = num2;
			int num4 = num;
			if (num3 <= num4)
			{
				ProfileClass profileClass = Module1.SettingObject.Profiles[num2];
				if (!Information.IsNothing((object)profileClass.ProfileKey) && profileClass.ProfileKey.AltKey == ((Computer)MyProject.Computer).get_Keyboard().get_AltKeyDown() && profileClass.ProfileKey.CtrlKey == ((Computer)MyProject.Computer).get_Keyboard().get_CtrlKeyDown() && profileClass.ProfileKey.ShiftKey == ((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown() && profileClass.ProfileKey.KeyCode == (int)e.get_KeyCode())
				{
					break;
				}
				num2 = checked(num2 + 1);
				continue;
			}
			return;
		}
		cboProfile.set_SelectedIndex(num2);
		btnConnect_Click(RuntimeHelpers.GetObjectValue(sender), null);
	}

	private void frmMain_Load(object sender, EventArgs e)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		if (!Module1.SettingFileExist())
		{
			Interaction.MsgBox((object)"第一次啟動, 請先進行設定!", (MsgBoxStyle)0, (object)null);
			((Form)MyProject.Forms.frmConfig).ShowDialog();
		}
		else if (!Module1.LoadSetting())
		{
			Interaction.MsgBox((object)"警告: 設定檔毀損, 將會重建設定檔! 所有設定將回復預設值!", (MsgBoxStyle)0, (object)null);
			Module1.SaveSetting();
		}
		switch (Module1.SettingObject.DisplayType)
		{
		case SettingClass.enumDisplayType.GDI:
			CameraMonitor.set_DisplayType((enumDisplayType)0);
			break;
		case SettingClass.enumDisplayType.Overlay:
			CameraMonitor.set_DisplayType((enumDisplayType)2);
			break;
		}
		CameraMonitor.set_WidthCount(2);
		CameraMonitor.set_HeightCount(2);
		LoadProfile();
		CameraMonitor.set_Tag((object)(-1));
		CameraMonitor.UpdateGraph();
		FlowTimer.set_Interval(1000);
		FlowTimer.Start();
		InitUI();
		MonitorResize();
	}

	private void ConnectServer()
	{
		if (cboProfile.get_SelectedIndex() == -1)
		{
			return;
		}
		ProfileClass profileClass = Module1.SettingObject.Profiles[cboProfile.get_SelectedIndex()];
		checked
		{
			if (Operators.ConditionalCompareObjectNotEqual((object)cboProfile.get_SelectedIndex(), CameraMonitor.get_Tag(), false))
			{
				((Control)CameraMonitor).set_Visible(false);
				CloseServer();
				CameraMonitor.ClearControl();
				CameraMonitor.set_Tag((object)cboProfile.get_SelectedIndex());
				switch (profileClass.SplitType)
				{
				case ProfileClass.enumSplitType.Auto:
				{
					int num = profileClass.CameraList.Length;
					if (num > 25)
					{
						CameraMonitor.set_WidthCount(6);
						CameraMonitor.set_HeightCount(6);
					}
					else if (num > 16)
					{
						CameraMonitor.set_WidthCount(5);
						CameraMonitor.set_HeightCount(5);
					}
					else if (num > 9)
					{
						CameraMonitor.set_WidthCount(4);
						CameraMonitor.set_HeightCount(4);
					}
					else if (num > 4)
					{
						CameraMonitor.set_WidthCount(3);
						CameraMonitor.set_HeightCount(3);
					}
					else if (num > 1)
					{
						CameraMonitor.set_WidthCount(2);
						CameraMonitor.set_HeightCount(2);
					}
					else
					{
						CameraMonitor.set_WidthCount(1);
						CameraMonitor.set_HeightCount(1);
					}
					break;
				}
				case ProfileClass.enumSplitType.Split_1:
					CameraMonitor.set_WidthCount(1);
					CameraMonitor.set_HeightCount(1);
					break;
				case ProfileClass.enumSplitType.Split_2x2:
					CameraMonitor.set_WidthCount(2);
					CameraMonitor.set_HeightCount(2);
					break;
				case ProfileClass.enumSplitType.Split_3x3:
					CameraMonitor.set_WidthCount(3);
					CameraMonitor.set_HeightCount(3);
					break;
				case ProfileClass.enumSplitType.Split_4x4:
					CameraMonitor.set_WidthCount(4);
					CameraMonitor.set_HeightCount(4);
					break;
				case ProfileClass.enumSplitType.Split_5x5:
					CameraMonitor.set_WidthCount(5);
					CameraMonitor.set_HeightCount(5);
					break;
				case ProfileClass.enumSplitType.Split_6x6:
					CameraMonitor.set_WidthCount(6);
					CameraMonitor.set_HeightCount(6);
					break;
				}
				ProfileCameraItemClass[] cameraList = profileClass.CameraList;
				foreach (ProfileCameraItemClass profileCameraItemClass in cameraList)
				{
					CameraMonitor.AddCameraControl(profileCameraItemClass.CameraIP, profileCameraItemClass.CameraPort, profileCameraItemClass.CameraID, (enumCompressLevel)profileClass.CompressType, profileCameraItemClass.CameraName);
				}
				int num2 = CameraMonitor.get_HeightCount() * CameraMonitor.get_WidthCount() - profileClass.CameraList.Length;
				int num3 = 1;
				while (true)
				{
					int num4 = num3;
					int num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					CameraMonitor.AddCameraControl("", 0, 0, (enumCompressLevel)4, "");
					num3++;
				}
				CameraMonitor.UpdateGraph();
				((Control)CameraMonitor).set_Visible(true);
			}
			if (!CameraMonitor.get_IsConnected())
			{
				CameraMonitor.Connect((enumPackageType)profileClass.ServerType);
			}
		}
	}

	private void CloseServer()
	{
		IsArchiveMode = false;
		CameraMonitor.Disconnect();
		GC.Collect();
		GC.Collect();
	}

	public void LoadProfile()
	{
		cboProfile.get_Items().Clear();
		if (!Information.IsNothing((object)Module1.SettingObject.Profiles))
		{
			ProfileClass[] profiles = Module1.SettingObject.Profiles;
			foreach (ProfileClass profileClass in profiles)
			{
				cboProfile.get_Items().Add((object)profileClass.ProfileName);
			}
		}
		if (cboProfile.get_Items().get_Count() > 0)
		{
			cboProfile.set_SelectedIndex(0);
		}
	}

	private void FlowTimer_Tick(object sender, EventArgs e)
	{
		checked
		{
			long num = CameraMonitor.get_PackageFlowIn() * 8L;
			long num2 = CameraMonitor.get_PackageFlowOut() * 8L;
			iTotalIn += num;
			iTotalOut += num2;
			lblBPSIn.set_Text(FlowText(num));
			lblBPSOut.set_Text(FlowText(num2));
			lblTotalIn.set_Text(FlowText(iTotalIn));
			lblTotalOut.set_Text(FlowText(iTotalOut));
			FlowMRTG.AddFlow(num, num2);
			((ToolStripItem)CurrentDateTime).set_Text(Conversions.ToString(DateAndTime.get_Now()));
		}
	}

	private string FlowText(long FlowCount)
	{
		if (FlowCount > 1073741824L)
		{
			return Strings.FormatNumber((object)((double)FlowCount / 1073741824.0), 1, (TriState)(-2), (TriState)(-2), (TriState)(-2)) + " G";
		}
		if (FlowCount > 1048576L)
		{
			return Strings.FormatNumber((object)((double)FlowCount / 1048576.0), 1, (TriState)(-2), (TriState)(-2), (TriState)(-2)) + " M";
		}
		if (FlowCount > 1024L)
		{
			return Strings.FormatNumber((object)((double)FlowCount / 1024.0), 0, (TriState)(-2), (TriState)(-2), (TriState)(-2)) + " K";
		}
		return Strings.FormatNumber((object)FlowCount, 0, (TriState)(-2), (TriState)(-2), (TriState)(-2));
	}

	private void btnConnect_Click(object sender, EventArgs e)
	{
		if (CameraMonitor.get_IsConnected())
		{
			CloseServer();
		}
		else
		{
			ConnectServer();
		}
		InitUI();
	}

	private void InitUI()
	{
		if (CameraMonitor.get_IsConnected())
		{
			((ButtonBase)btnConnect).set_Text("Disconnect");
			((Control)cboProfile).set_Enabled(false);
		}
		else
		{
			((ButtonBase)btnConnect).set_Text("Connect");
			((Control)cboProfile).set_Enabled(true);
		}
		if (IsArchiveMode)
		{
			((ButtonBase)btnPlayback).set_Text("Stop Playback");
		}
		else
		{
			((ButtonBase)btnPlayback).set_Text("Playback");
		}
	}

	private void btnConfig_Click(object sender, EventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((Form)MyProject.Forms.frmConfig).ShowDialog();
		LoadProfile();
	}

	private void btnExit_Click(object sender, EventArgs e)
	{
		CloseServer();
		CameraMonitor.ClearControl();
		Application.Exit();
	}

	private void btnCapture_Click(object sender, EventArgs e)
	{
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		string text = Module1.SettingObject.CapturePath;
		if (Operators.CompareString(text, string.Empty, false) == 0)
		{
			text = Module1.GetRunPath();
		}
		checked
		{
			int num = CameraMonitor.get_GetItemCount() - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				CameraControl val = CameraMonitor.get_GetItem(num2);
				if (val.get_IsConnect())
				{
					val.MakePicture(text + "\\" + ConvertFilename(val.get_DisplayName()) + "_" + DateAndTime.get_Now().ToString("yyyy-MM-dd_HH-mm-ss") + "_" + Conversions.ToString(val.get_ChannelID()) + ".bmp");
					flag = true;
				}
				num2++;
			}
			if (flag)
			{
				Interaction.MsgBox((object)"拍照存檔完成", (MsgBoxStyle)0, (object)null);
				Process.Start("Explorer.exe", "\"" + text + "\"");
			}
			else
			{
				Interaction.MsgBox((object)"沒有產生任何拍照檔案, 可能是尚未連線", (MsgBoxStyle)0, (object)null);
			}
		}
	}

	private string ConvertFilename(string S)
	{
		string text = S;
		string text2 = "?*<>|\":";
		string text3 = text2;
		int i = 0;
		for (int length = text3.Length; i < length; i = checked(i + 1))
		{
			char c = text3[i];
			text = text.Replace(Conversions.ToString(c), "_");
		}
		return text;
	}

	private void btnPlayback_Click(object sender, EventArgs e)
	{
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (IsArchiveMode)
			{
				int num = CameraMonitor.get_GetItemCount() - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					CameraControl val = CameraMonitor.get_GetItem(num2);
					val.StopArchive();
					num2++;
				}
				IsArchiveMode = false;
			}
			else if (cboProfile.get_SelectedIndex() != -1)
			{
				ProfileClass profile = Module1.SettingObject.Profiles[cboProfile.get_SelectedIndex()];
				MyProject.Forms.frmPlayback.Profile = profile;
				MyProject.Forms.frmPlayback.IsPlaybackSplit = false;
				((Form)MyProject.Forms.frmPlayback).ShowDialog();
				if (MyProject.Forms.frmPlayback.IsPlaybackSplit)
				{
					DateTime playbackDate = MyProject.Forms.frmPlayback.PlaybackDate;
					if (!CameraMonitor.get_IsConnected())
					{
						ConnectServer();
					}
					int num5 = CameraMonitor.get_GetItemCount() - 1;
					int num6 = 0;
					while (true)
					{
						int num7 = num6;
						int num4 = num5;
						if (num7 > num4)
						{
							break;
						}
						CameraControl val = CameraMonitor.get_GetItem(num6);
						val.PlayArchive(playbackDate);
						num6++;
					}
					IsArchiveMode = true;
				}
			}
			InitUI();
		}
	}

	private void CameraMonitor_CameraClick(SplitMonitorControl sender, CameraControl ClickedCamera, int x, int y, int MouseButton)
	{
		if (MouseButton == 2)
		{
			iClickedCamera = ClickedCamera;
			((ToolStripItem)tsmCameraName).set_Text(iClickedCamera.get_DisplayName());
			if (iClickedCamera.get_IsArchiveMode())
			{
				tsmStopPlayback.set_Enabled(true);
			}
			else
			{
				tsmStopPlayback.set_Enabled(false);
			}
			((ToolStripDropDown)ContextMenu).Show((Control)(object)ClickedCamera, x, y);
		}
	}

	private void tsmReconnect_Click(object sender, EventArgs e)
	{
		if (!Information.IsNothing((object)iClickedCamera))
		{
			iClickedCamera.Close();
			iClickedCamera.Connect();
		}
	}

	private void tsmCloseCamera_Click(object sender, EventArgs e)
	{
		if (!Information.IsNothing((object)iClickedCamera))
		{
			iClickedCamera.Close();
		}
	}

	private void tsmCloseMenu_Click(object sender, EventArgs e)
	{
		((ToolStripDropDown)ContextMenu).Close();
	}

	private void tsmCapture_Click(object sender, EventArgs e)
	{
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		if (!Information.IsNothing((object)iClickedCamera))
		{
			string text = Module1.SettingObject.CapturePath;
			if (Operators.CompareString(text, string.Empty, false) == 0)
			{
				text = Module1.GetRunPath();
			}
			if (iClickedCamera.get_IsConnect())
			{
				iClickedCamera.MakePicture(text + "\\" + ConvertFilename(iClickedCamera.get_DisplayName()) + "_" + DateAndTime.get_Now().ToString("yyyy-MM-dd_HH-mm-ss") + "_" + Conversions.ToString(iClickedCamera.get_ChannelID()) + ".bmp");
				flag = true;
			}
			if (flag)
			{
				Interaction.MsgBox((object)"拍照存檔完成", (MsgBoxStyle)0, (object)null);
				Process.Start("Explorer.exe", "\"" + text + "\"");
			}
			else
			{
				Interaction.MsgBox((object)"沒有產生任何拍照檔案, 可能是尚未連線", (MsgBoxStyle)0, (object)null);
			}
		}
	}

	private void tsmStopPlayback_Click(object sender, EventArgs e)
	{
		if (!Information.IsNothing((object)iClickedCamera))
		{
			iClickedCamera.StopArchive();
		}
	}

	private void tsmPlayback_Click(object sender, EventArgs e)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (!Information.IsNothing((object)iClickedCamera))
		{
			MyProject.Forms.frmPlayback.Profile = null;
			MyProject.Forms.frmPlayback.IsPlaybackSplit = false;
			MyProject.Forms.frmPlayback.ForceInSplitMode = true;
			((Form)MyProject.Forms.frmPlayback).ShowDialog();
			if (MyProject.Forms.frmPlayback.IsPlaybackSplit)
			{
				DateTime playbackDate = MyProject.Forms.frmPlayback.PlaybackDate;
				iClickedCamera.PlayArchive(playbackDate);
			}
		}
	}

	private void MonitorResize()
	{
		((Control)CameraMonitor).set_Visible(false);
		((Control)CameraMonitor).SetBounds(0, 0, ((Control)Panel2).get_Width(), ((Control)Panel2).get_Height());
		((Control)CameraMonitor).set_Visible(true);
	}

	private void frmMain_ResizeEnd(object sender, EventArgs e)
	{
		MonitorResize();
	}

	private void frmMain_SizeChanged(object sender, EventArgs e)
	{
		MonitorResize();
	}
}
