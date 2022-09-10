using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using WY9_Tray.My;

namespace WY9_Tray;

[DesignerGenerated]
public class OptFrm : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("SaveBtn")]
	private Button _SaveBtn;

	[AccessedThroughProperty("CancelBtn")]
	private Button _CancelBtn;

	[AccessedThroughProperty("SevGpBx")]
	private GroupBox _SevGpBx;

	[AccessedThroughProperty("OpenBtn")]
	private Button _OpenBtn;

	[AccessedThroughProperty("IcdTxtBx")]
	private TextBox _IcdTxtBx;

	[AccessedThroughProperty("OpenFileDialog")]
	private OpenFileDialog _OpenFileDialog;

	[AccessedThroughProperty("IcdLab")]
	private Label _IcdLab;

	[AccessedThroughProperty("IedLab")]
	private Label _IedLab;

	[AccessedThroughProperty("IedTxtBx")]
	private TextBox _IedTxtBx;

	[AccessedThroughProperty("LdLab")]
	private Label _LdLab;

	[AccessedThroughProperty("LdTxtBx")]
	private TextBox _LdTxtBx;

	[AccessedThroughProperty("RptLab")]
	private Label _RptLab;

	[AccessedThroughProperty("RptTxtBx")]
	private TextBox _RptTxtBx;

	[AccessedThroughProperty("ApLab")]
	private Label _ApLab;

	[AccessedThroughProperty("ApTxtBx")]
	private TextBox _ApTxtBx;

	[AccessedThroughProperty("TrayGpBx")]
	private GroupBox _TrayGpBx;

	[AccessedThroughProperty("StartCkBx")]
	private CheckBox _StartCkBx;

	[AccessedThroughProperty("ServiceCkBx")]
	private CheckBox _ServiceCkBx;

	[AccessedThroughProperty("LaunchCkBx")]
	private CheckBox _LaunchCkBx;

	[AccessedThroughProperty("UnlockBtn")]
	private Button _UnlockBtn;

	[AccessedThroughProperty("PasswdBx")]
	private TextBox _PasswdBx;

	private object StartupFileName;

	private const string IcdStr = "SCLFileName";

	private const string IedStr = "IEDName";

	private const string LdStr = "LDName";

	private const string ApStr = "AccessPointName";

	private const string RptStr = "ReportScanRate";

	public object TrayRegName;

	private string IcdName;

	private string IedName;

	private bool AutoStart;

	private bool AutoLaunch;

	private bool AsService;

	private string AdminPasswd;

	internal virtual Button SaveBtn
	{
		[DebuggerNonUserCode]
		get
		{
			return _SaveBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = SaveBtn_Click;
			if (_SaveBtn != null)
			{
				((Control)_SaveBtn).remove_Click(eventHandler);
			}
			_SaveBtn = value;
			if (_SaveBtn != null)
			{
				((Control)_SaveBtn).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button CancelBtn
	{
		[DebuggerNonUserCode]
		get
		{
			return _CancelBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = CancelBtn_Click;
			if (_CancelBtn != null)
			{
				((Control)_CancelBtn).remove_Click(eventHandler);
			}
			_CancelBtn = value;
			if (_CancelBtn != null)
			{
				((Control)_CancelBtn).add_Click(eventHandler);
			}
		}
	}

	internal virtual GroupBox SevGpBx
	{
		[DebuggerNonUserCode]
		get
		{
			return _SevGpBx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SevGpBx = value;
		}
	}

	internal virtual Button OpenBtn
	{
		[DebuggerNonUserCode]
		get
		{
			return _OpenBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = OpenBtn_Click;
			if (_OpenBtn != null)
			{
				((Control)_OpenBtn).remove_Click(eventHandler);
			}
			_OpenBtn = value;
			if (_OpenBtn != null)
			{
				((Control)_OpenBtn).add_Click(eventHandler);
			}
		}
	}

	internal virtual TextBox IcdTxtBx
	{
		[DebuggerNonUserCode]
		get
		{
			return _IcdTxtBx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = IcdTxtBx_TextChanged;
			if (_IcdTxtBx != null)
			{
				((Control)_IcdTxtBx).remove_TextChanged(eventHandler);
			}
			_IcdTxtBx = value;
			if (_IcdTxtBx != null)
			{
				((Control)_IcdTxtBx).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual OpenFileDialog OpenFileDialog
	{
		[DebuggerNonUserCode]
		get
		{
			return _OpenFileDialog;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_OpenFileDialog = value;
		}
	}

	internal virtual Label IcdLab
	{
		[DebuggerNonUserCode]
		get
		{
			return _IcdLab;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_IcdLab = value;
		}
	}

	internal virtual Label IedLab
	{
		[DebuggerNonUserCode]
		get
		{
			return _IedLab;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_IedLab = value;
		}
	}

	internal virtual TextBox IedTxtBx
	{
		[DebuggerNonUserCode]
		get
		{
			return _IedTxtBx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = IedTxtBx_TextChanged;
			if (_IedTxtBx != null)
			{
				((Control)_IedTxtBx).remove_TextChanged(eventHandler);
			}
			_IedTxtBx = value;
			if (_IedTxtBx != null)
			{
				((Control)_IedTxtBx).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual Label LdLab
	{
		[DebuggerNonUserCode]
		get
		{
			return _LdLab;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LdLab = value;
		}
	}

	internal virtual TextBox LdTxtBx
	{
		[DebuggerNonUserCode]
		get
		{
			return _LdTxtBx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LdTxtBx = value;
		}
	}

	internal virtual Label RptLab
	{
		[DebuggerNonUserCode]
		get
		{
			return _RptLab;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RptLab = value;
		}
	}

	internal virtual TextBox RptTxtBx
	{
		[DebuggerNonUserCode]
		get
		{
			return _RptTxtBx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RptTxtBx = value;
		}
	}

	internal virtual Label ApLab
	{
		[DebuggerNonUserCode]
		get
		{
			return _ApLab;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ApLab = value;
		}
	}

	internal virtual TextBox ApTxtBx
	{
		[DebuggerNonUserCode]
		get
		{
			return _ApTxtBx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ApTxtBx = value;
		}
	}

	internal virtual GroupBox TrayGpBx
	{
		[DebuggerNonUserCode]
		get
		{
			return _TrayGpBx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TrayGpBx = value;
		}
	}

	internal virtual CheckBox StartCkBx
	{
		[DebuggerNonUserCode]
		get
		{
			return _StartCkBx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = StartCkBx_CheckedChanged;
			if (_StartCkBx != null)
			{
				_StartCkBx.remove_CheckedChanged(eventHandler);
			}
			_StartCkBx = value;
			if (_StartCkBx != null)
			{
				_StartCkBx.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual CheckBox ServiceCkBx
	{
		[DebuggerNonUserCode]
		get
		{
			return _ServiceCkBx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ServiceCkBx_CheckedChanged;
			if (_ServiceCkBx != null)
			{
				_ServiceCkBx.remove_CheckedChanged(eventHandler);
			}
			_ServiceCkBx = value;
			if (_ServiceCkBx != null)
			{
				_ServiceCkBx.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual CheckBox LaunchCkBx
	{
		[DebuggerNonUserCode]
		get
		{
			return _LaunchCkBx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = LaunchCkBx_CheckedChanged;
			if (_LaunchCkBx != null)
			{
				_LaunchCkBx.remove_CheckedChanged(eventHandler);
			}
			_LaunchCkBx = value;
			if (_LaunchCkBx != null)
			{
				_LaunchCkBx.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual Button UnlockBtn
	{
		[DebuggerNonUserCode]
		get
		{
			return _UnlockBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = UnlockBtn_Click;
			if (_UnlockBtn != null)
			{
				((Control)_UnlockBtn).remove_Click(eventHandler);
			}
			_UnlockBtn = value;
			if (_UnlockBtn != null)
			{
				((Control)_UnlockBtn).add_Click(eventHandler);
			}
		}
	}

	internal virtual TextBox PasswdBx
	{
		[DebuggerNonUserCode]
		get
		{
			return _PasswdBx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			KeyEventHandler val = new KeyEventHandler(PasswdBx_KeyDown);
			if (_PasswdBx != null)
			{
				((Control)_PasswdBx).remove_KeyDown(val);
			}
			_PasswdBx = value;
			if (_PasswdBx != null)
			{
				((Control)_PasswdBx).add_KeyDown(val);
			}
		}
	}

	public OptFrm()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(OptFrm_FormClosing));
		((Form)this).add_Load((EventHandler)OptFrm_Load);
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		TrayRegName = "";
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
		//IL_0b14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1e: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(OptFrm));
		SaveBtn = new Button();
		CancelBtn = new Button();
		SevGpBx = new GroupBox();
		RptLab = new Label();
		RptTxtBx = new TextBox();
		ApLab = new Label();
		ApTxtBx = new TextBox();
		LdLab = new Label();
		LdTxtBx = new TextBox();
		IedLab = new Label();
		IedTxtBx = new TextBox();
		IcdLab = new Label();
		OpenBtn = new Button();
		IcdTxtBx = new TextBox();
		OpenFileDialog = new OpenFileDialog();
		TrayGpBx = new GroupBox();
		StartCkBx = new CheckBox();
		ServiceCkBx = new CheckBox();
		LaunchCkBx = new CheckBox();
		UnlockBtn = new Button();
		PasswdBx = new TextBox();
		((Control)SevGpBx).SuspendLayout();
		((Control)TrayGpBx).SuspendLayout();
		((Control)this).SuspendLayout();
		Button saveBtn = SaveBtn;
		Point location = new Point(440, 124);
		((Control)saveBtn).set_Location(location);
		((Control)SaveBtn).set_Name("SaveBtn");
		Button saveBtn2 = SaveBtn;
		Size size = new Size(60, 23);
		((Control)saveBtn2).set_Size(size);
		((Control)SaveBtn).set_TabIndex(0);
		((ButtonBase)SaveBtn).set_Text("&Save");
		((ButtonBase)SaveBtn).set_UseVisualStyleBackColor(true);
		Button cancelBtn = CancelBtn;
		location = new Point(440, 153);
		((Control)cancelBtn).set_Location(location);
		((Control)CancelBtn).set_Name("CancelBtn");
		Button cancelBtn2 = CancelBtn;
		size = new Size(60, 23);
		((Control)cancelBtn2).set_Size(size);
		((Control)CancelBtn).set_TabIndex(1);
		((ButtonBase)CancelBtn).set_Text("&Cancel");
		((ButtonBase)CancelBtn).set_UseVisualStyleBackColor(true);
		((Control)SevGpBx).get_Controls().Add((Control)(object)RptLab);
		((Control)SevGpBx).get_Controls().Add((Control)(object)RptTxtBx);
		((Control)SevGpBx).get_Controls().Add((Control)(object)ApLab);
		((Control)SevGpBx).get_Controls().Add((Control)(object)ApTxtBx);
		((Control)SevGpBx).get_Controls().Add((Control)(object)LdLab);
		((Control)SevGpBx).get_Controls().Add((Control)(object)LdTxtBx);
		((Control)SevGpBx).get_Controls().Add((Control)(object)IedLab);
		((Control)SevGpBx).get_Controls().Add((Control)(object)IedTxtBx);
		((Control)SevGpBx).get_Controls().Add((Control)(object)IcdLab);
		((Control)SevGpBx).get_Controls().Add((Control)(object)OpenBtn);
		((Control)SevGpBx).get_Controls().Add((Control)(object)IcdTxtBx);
		GroupBox sevGpBx = SevGpBx;
		location = new Point(18, 12);
		((Control)sevGpBx).set_Location(location);
		((Control)SevGpBx).set_Name("SevGpBx");
		GroupBox sevGpBx2 = SevGpBx;
		size = new Size(406, 175);
		((Control)sevGpBx2).set_Size(size);
		((Control)SevGpBx).set_TabIndex(2);
		SevGpBx.set_TabStop(false);
		SevGpBx.set_Text("61850 Server Configure");
		RptLab.set_AutoSize(true);
		Label rptLab = RptLab;
		location = new Point(16, 141);
		((Control)rptLab).set_Location(location);
		((Control)RptLab).set_Name("RptLab");
		Label rptLab2 = RptLab;
		size = new Size(77, 12);
		((Control)rptLab2).set_Size(size);
		((Control)RptLab).set_TabIndex(10);
		RptLab.set_Text("Report Rate:");
		TextBox rptTxtBx = RptTxtBx;
		location = new Point(105, 138);
		((Control)rptTxtBx).set_Location(location);
		((Control)RptTxtBx).set_Name("RptTxtBx");
		((TextBoxBase)RptTxtBx).set_ReadOnly(true);
		TextBox rptTxtBx2 = RptTxtBx;
		size = new Size(210, 21);
		((Control)rptTxtBx2).set_Size(size);
		((Control)RptTxtBx).set_TabIndex(9);
		ApLab.set_AutoSize(true);
		Label apLab = ApLab;
		location = new Point(16, 114);
		((Control)apLab).set_Location(location);
		((Control)ApLab).set_Name("ApLab");
		Label apLab2 = ApLab;
		size = new Size(53, 12);
		((Control)apLab2).set_Size(size);
		((Control)ApLab).set_TabIndex(8);
		ApLab.set_Text("AP Name:");
		TextBox apTxtBx = ApTxtBx;
		location = new Point(105, 111);
		((Control)apTxtBx).set_Location(location);
		((Control)ApTxtBx).set_Name("ApTxtBx");
		((TextBoxBase)ApTxtBx).set_ReadOnly(true);
		TextBox apTxtBx2 = ApTxtBx;
		size = new Size(210, 21);
		((Control)apTxtBx2).set_Size(size);
		((Control)ApTxtBx).set_TabIndex(7);
		LdLab.set_AutoSize(true);
		Label ldLab = LdLab;
		location = new Point(16, 87);
		((Control)ldLab).set_Location(location);
		((Control)LdLab).set_Name("LdLab");
		Label ldLab2 = LdLab;
		size = new Size(53, 12);
		((Control)ldLab2).set_Size(size);
		((Control)LdLab).set_TabIndex(6);
		LdLab.set_Text("LD Name:");
		TextBox ldTxtBx = LdTxtBx;
		location = new Point(105, 84);
		((Control)ldTxtBx).set_Location(location);
		((Control)LdTxtBx).set_Name("LdTxtBx");
		((TextBoxBase)LdTxtBx).set_ReadOnly(true);
		TextBox ldTxtBx2 = LdTxtBx;
		size = new Size(210, 21);
		((Control)ldTxtBx2).set_Size(size);
		((Control)LdTxtBx).set_TabIndex(5);
		IedLab.set_AutoSize(true);
		Label iedLab = IedLab;
		location = new Point(16, 60);
		((Control)iedLab).set_Location(location);
		((Control)IedLab).set_Name("IedLab");
		Label iedLab2 = IedLab;
		size = new Size(59, 12);
		((Control)iedLab2).set_Size(size);
		((Control)IedLab).set_TabIndex(4);
		IedLab.set_Text("IED Name:");
		TextBox iedTxtBx = IedTxtBx;
		location = new Point(105, 57);
		((Control)iedTxtBx).set_Location(location);
		((Control)IedTxtBx).set_Name("IedTxtBx");
		TextBox iedTxtBx2 = IedTxtBx;
		size = new Size(210, 21);
		((Control)iedTxtBx2).set_Size(size);
		((Control)IedTxtBx).set_TabIndex(3);
		IcdLab.set_AutoSize(true);
		Label icdLab = IcdLab;
		location = new Point(16, 33);
		((Control)icdLab).set_Location(location);
		((Control)IcdLab).set_Name("IcdLab");
		Label icdLab2 = IcdLab;
		size = new Size(89, 12);
		((Control)icdLab2).set_Size(size);
		((Control)IcdLab).set_TabIndex(2);
		IcdLab.set_Text("ICD File Name:");
		Button openBtn = OpenBtn;
		location = new Point(331, 28);
		((Control)openBtn).set_Location(location);
		((Control)OpenBtn).set_Name("OpenBtn");
		Button openBtn2 = OpenBtn;
		size = new Size(54, 23);
		((Control)openBtn2).set_Size(size);
		((Control)OpenBtn).set_TabIndex(1);
		((ButtonBase)OpenBtn).set_Text("&Browse");
		((ButtonBase)OpenBtn).set_UseVisualStyleBackColor(true);
		TextBox icdTxtBx = IcdTxtBx;
		location = new Point(105, 30);
		((Control)icdTxtBx).set_Location(location);
		((Control)IcdTxtBx).set_Name("IcdTxtBx");
		TextBox icdTxtBx2 = IcdTxtBx;
		size = new Size(210, 21);
		((Control)icdTxtBx2).set_Size(size);
		((Control)IcdTxtBx).set_TabIndex(0);
		((FileDialog)OpenFileDialog).set_FileName("OpenFileDialog");
		((Control)TrayGpBx).get_Controls().Add((Control)(object)StartCkBx);
		((Control)TrayGpBx).get_Controls().Add((Control)(object)ServiceCkBx);
		((Control)TrayGpBx).get_Controls().Add((Control)(object)LaunchCkBx);
		((Control)TrayGpBx).set_Enabled(false);
		GroupBox trayGpBx = TrayGpBx;
		location = new Point(18, 195);
		((Control)trayGpBx).set_Location(location);
		((Control)TrayGpBx).set_Name("TrayGpBx");
		GroupBox trayGpBx2 = TrayGpBx;
		size = new Size(406, 105);
		((Control)trayGpBx2).set_Size(size);
		((Control)TrayGpBx).set_TabIndex(7);
		TrayGpBx.set_TabStop(false);
		TrayGpBx.set_Text("Tray Configure");
		((ButtonBase)StartCkBx).set_AutoSize(true);
		CheckBox startCkBx = StartCkBx;
		location = new Point(18, 29);
		((Control)startCkBx).set_Location(location);
		((Control)StartCkBx).set_Name("StartCkBx");
		CheckBox startCkBx2 = StartCkBx;
		size = new Size(282, 16);
		((Control)startCkBx2).set_Size(size);
		((Control)StartCkBx).set_TabIndex(4);
		((ButtonBase)StartCkBx).set_Text("Auto Start 61850 Server on This Tray Launch");
		((ButtonBase)StartCkBx).set_UseVisualStyleBackColor(true);
		((ButtonBase)ServiceCkBx).set_AutoSize(true);
		((Control)ServiceCkBx).set_Enabled(false);
		CheckBox serviceCkBx = ServiceCkBx;
		location = new Point(18, 73);
		((Control)serviceCkBx).set_Location(location);
		((Control)ServiceCkBx).set_Name("ServiceCkBx");
		CheckBox serviceCkBx2 = ServiceCkBx;
		size = new Size(270, 16);
		((Control)serviceCkBx2).set_Size(size);
		((Control)ServiceCkBx).set_TabIndex(6);
		((ButtonBase)ServiceCkBx).set_Text("Run This Tray as a Windows System Service");
		((ButtonBase)ServiceCkBx).set_UseVisualStyleBackColor(true);
		((ButtonBase)LaunchCkBx).set_AutoSize(true);
		CheckBox launchCkBx = LaunchCkBx;
		location = new Point(18, 51);
		((Control)launchCkBx).set_Location(location);
		((Control)LaunchCkBx).set_Name("LaunchCkBx");
		CheckBox launchCkBx2 = LaunchCkBx;
		size = new Size(276, 16);
		((Control)launchCkBx2).set_Size(size);
		((Control)LaunchCkBx).set_TabIndex(5);
		((ButtonBase)LaunchCkBx).set_Text("Auto Launch This Tray when Windows Startup");
		((ButtonBase)LaunchCkBx).set_UseVisualStyleBackColor(true);
		Button unlockBtn = UnlockBtn;
		location = new Point(440, 69);
		((Control)unlockBtn).set_Location(location);
		((Control)UnlockBtn).set_Name("UnlockBtn");
		Button unlockBtn2 = UnlockBtn;
		size = new Size(60, 23);
		((Control)unlockBtn2).set_Size(size);
		((Control)UnlockBtn).set_TabIndex(8);
		((ButtonBase)UnlockBtn).set_Text("&Unlock");
		((ButtonBase)UnlockBtn).set_UseVisualStyleBackColor(true);
		TextBox passwdBx = PasswdBx;
		location = new Point(440, 40);
		((Control)passwdBx).set_Location(location);
		((TextBoxBase)PasswdBx).set_MaxLength(8);
		((Control)PasswdBx).set_Name("PasswdBx");
		PasswdBx.set_PasswordChar('*');
		TextBox passwdBx2 = PasswdBx;
		size = new Size(60, 21);
		((Control)passwdBx2).set_Size(size);
		((Control)PasswdBx).set_TabIndex(9);
		PasswdBx.set_TextAlign((HorizontalAlignment)2);
		SizeF autoScaleDimensions = new SizeF(6f, 12f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(512, 316);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)PasswdBx);
		((Control)this).get_Controls().Add((Control)(object)UnlockBtn);
		((Control)this).get_Controls().Add((Control)(object)TrayGpBx);
		((Control)this).get_Controls().Add((Control)(object)SevGpBx);
		((Control)this).get_Controls().Add((Control)(object)CancelBtn);
		((Control)this).get_Controls().Add((Control)(object)SaveBtn);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("OptFrm");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Preferences");
		((Control)SevGpBx).ResumeLayout(false);
		((Control)SevGpBx).PerformLayout();
		((Control)TrayGpBx).ResumeLayout(false);
		((Control)TrayGpBx).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public bool CheckConfigChanged()
	{
		return (Operators.CompareString(IcdName, Strings.Trim(IcdTxtBx.get_Text()), false) != 0) | (Operators.CompareString(IedName, Strings.Trim(IedTxtBx.get_Text()), false) != 0) | (AutoStart != StartCkBx.get_Checked()) | (AutoLaunch != LaunchCkBx.get_Checked()) | (AsService != ServiceCkBx.get_Checked());
	}

	private void OptFrm_FormClosing(object sender, FormClosingEventArgs e)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected I4, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		if (!((Control)SaveBtn).get_Enabled())
		{
			return;
		}
		MsgBoxResult val = Interaction.MsgBox((object)"The setting is changed but not save, do you want saving that?", (MsgBoxStyle)3, (object)"Option Changed");
		switch (val - 2)
		{
		case 0:
			((CancelEventArgs)(object)e).Cancel = true;
			break;
		case 4:
			SaveBtn.PerformClick();
			if (MyProject.Forms.MainForm.ServerStart)
			{
				Interaction.MsgBox((object)"The Configure Changed, Must be Restart the server!", (MsgBoxStyle)64, (object)"Configure Changed");
			}
			((CancelEventArgs)(object)e).Cancel = false;
			break;
		case 5:
			((CancelEventArgs)(object)e).Cancel = false;
			break;
		case 1:
		case 2:
		case 3:
			break;
		}
	}

	private void OptFrm_Load(object sender, EventArgs e)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.Load("WY9TrayCfg.xml");
			XmlElement xmlElement = (XmlElement)xmlDocument.SelectSingleNode("Configuration/Password");
			string attribute = xmlElement.GetAttribute("type");
			string text = attribute;
			if (Operators.CompareString(text, "Admin", false) == 0)
			{
				AdminPasswd = xmlElement.InnerText;
			}
			else
			{
				Interaction.MsgBox((object)("Unknow User Type: " + attribute), (MsgBoxStyle)48, (object)"Configure Error");
			}
			xmlElement = (XmlElement)xmlDocument.SelectSingleNode("Configuration/IEC61850Config/StartupFile");
			StartupFileName = xmlElement.InnerText;
			xmlElement = (XmlElement)xmlDocument.SelectSingleNode("Configuration/TrayConfig/AutoStart");
			AutoStart = Conversions.ToBoolean(xmlElement.InnerText);
			StartCkBx.set_Checked(AutoStart);
			xmlElement = (XmlElement)xmlDocument.SelectSingleNode("Configuration/TrayConfig/AutoLaunch");
			AutoLaunch = Conversions.ToBoolean(xmlElement.InnerText);
			LaunchCkBx.set_Checked(AutoLaunch);
			xmlElement = (XmlElement)xmlDocument.SelectSingleNode("Configuration/TrayConfig/AsService");
			AsService = Conversions.ToBoolean(xmlElement.InnerText);
			ServiceCkBx.set_Checked(AsService);
			((Control)LaunchCkBx).set_Enabled(!ServiceCkBx.get_Checked());
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)"Can't read the configure file: WY9TrayCfg.xml\r\nPlease check again!", (MsgBoxStyle)48, (object)"Configure Error");
			((Form)this).Close();
			ProjectData.ClearProjectError();
		}
		int num = FileSystem.FreeFile();
		try
		{
			FileSystem.FileOpen(num, Conversions.ToString(StartupFileName), (OpenMode)1, (OpenAccess)(-1), (OpenShare)(-1), -1);
			while (!FileSystem.EOF(num))
			{
				string text2 = FileSystem.LineInput(num);
				string[] array = text2.Split(new char[1] { '\t' });
				if (array.Length != 2)
				{
					Interaction.MsgBox((object)("Argument Error: " + text2), (MsgBoxStyle)48, (object)"Configure Error");
					continue;
				}
				switch (array[0])
				{
				case "SCLFileName":
					IcdTxtBx.set_Text(array[1]);
					IcdName = IcdTxtBx.get_Text();
					break;
				case "IEDName":
					IedTxtBx.set_Text(array[1]);
					IedName = IedTxtBx.get_Text();
					break;
				case "LDName":
					LdTxtBx.set_Text(array[1]);
					break;
				case "AccessPointName":
					ApTxtBx.set_Text(array[1]);
					break;
				case "ReportScanRate":
					RptTxtBx.set_Text(array[1]);
					break;
				default:
					Interaction.MsgBox((object)("Unknow Arguments: " + array[0]), (MsgBoxStyle)48, (object)"Configure Error");
					break;
				}
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			Interaction.MsgBox(Operators.AddObject(Operators.AddObject(Operators.AddObject((object)"Can't read the configure file: ", StartupFileName), (object)"\r\n"), (object)"Please check again!"), (MsgBoxStyle)48, (object)"Configure Error");
			((Form)this).Close();
			ProjectData.ClearProjectError();
		}
		finally
		{
			FileSystem.FileClose(new int[1] { num });
		}
		((Control)SevGpBx).set_Enabled(false);
		((Control)TrayGpBx).set_Enabled(false);
		((Control)SaveBtn).set_Enabled(false);
	}

	private void CancelBtn_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void SaveBtn_Click(object sender, EventArgs e)
	{
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		int num = FileSystem.FreeFile();
		try
		{
			FileSystem.FileOpen(num, Conversions.ToString(StartupFileName), (OpenMode)2, (OpenAccess)(-1), (OpenShare)(-1), -1);
			FileSystem.PrintLine(num, new object[1] { "SCLFileName\t" + Strings.Trim(IcdTxtBx.get_Text()) });
			FileSystem.PrintLine(num, new object[1] { "IEDName\t" + Strings.Trim(IedTxtBx.get_Text()) });
			FileSystem.PrintLine(num, new object[1] { "LDName\t" + Strings.Trim(LdTxtBx.get_Text()) });
			FileSystem.PrintLine(num, new object[1] { "AccessPointName\t" + Strings.Trim(ApTxtBx.get_Text()) });
			FileSystem.PrintLine(num, new object[1] { "ReportScanRate\t" + Strings.Trim(RptTxtBx.get_Text()) });
			IcdName = Strings.Trim(IcdTxtBx.get_Text());
			IedName = Strings.Trim(IedTxtBx.get_Text());
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox(Operators.AddObject(Operators.AddObject(Operators.AddObject((object)"Can't save the configure file: ", StartupFileName), (object)"\r\n"), (object)"Please check again!"), (MsgBoxStyle)48, (object)"Configure Error");
			ProjectData.ClearProjectError();
		}
		finally
		{
			FileSystem.FileClose(new int[1] { num });
		}
		try
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.Load("WY9TrayCfg.xml");
			XmlElement xmlElement = (XmlElement)xmlDocument.SelectSingleNode("Configuration/TrayConfig/AutoStart");
			xmlElement.InnerText = StartCkBx.get_Checked().ToString();
			AutoStart = Conversions.ToBoolean(xmlElement.InnerText);
			xmlElement = (XmlElement)xmlDocument.SelectSingleNode("Configuration/TrayConfig/AutoLaunch");
			xmlElement.InnerText = LaunchCkBx.get_Checked().ToString();
			AutoLaunch = Conversions.ToBoolean(xmlElement.InnerText);
			xmlElement = (XmlElement)xmlDocument.SelectSingleNode("Configuration/TrayConfig/AsService");
			xmlElement.InnerText = ServiceCkBx.get_Checked().ToString();
			AsService = Conversions.ToBoolean(xmlElement.InnerText);
			xmlDocument.Save("WY9TrayCfg.xml");
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			Interaction.MsgBox((object)"Can't save the configure file: WY9TrayCfg.xml\r\nPlease check again!", (MsgBoxStyle)48, (object)"Configure Error");
			((Form)this).Close();
			ProjectData.ClearProjectError();
		}
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			Console.Out.WriteLine(RuntimeHelpers.GetObjectValue(registryKey.GetValue("360Safetray")));
			if (AutoLaunch & !AsService)
			{
				registryKey.SetValue("WY9Tray", Application.get_ExecutablePath(), RegistryValueKind.String);
			}
			else if (Operators.ConditionalCompareObjectNotEqual(registryKey.GetValue("WY9Tray"), (object)"", false))
			{
				registryKey.DeleteValue("WY9Tray");
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			Interaction.MsgBox((object)"Can't option the Registry: \r\nPlease check again!", (MsgBoxStyle)48, (object)"Registry Error");
			ProjectData.ClearProjectError();
		}
		((Control)SaveBtn).set_Enabled(false);
		XmlDocument xmlDocument2 = new XmlDocument();
		xmlDocument2.Load(IcdTxtBx.get_Text());
		XmlElement documentElement = xmlDocument2.DocumentElement;
		checked
		{
			int num2 = documentElement.ChildNodes.Count - 1;
			int num3 = 0;
			IEnumerator enumerator = default(IEnumerator);
			IEnumerator enumerator2 = default(IEnumerator);
			while (true)
			{
				int num4 = num3;
				int num5 = num2;
				if (num4 > num5)
				{
					break;
				}
				XmlNode xmlNode = documentElement.ChildNodes.Item(num3);
				if (Operators.CompareString(xmlNode.Name, "Communication", false) == 0)
				{
					XmlNodeList childNodes = xmlNode.ChildNodes;
					try
					{
						enumerator = childNodes.GetEnumerator();
						while (enumerator.MoveNext())
						{
							XmlNode xmlNode2 = (XmlNode)enumerator.Current;
							XmlNodeList childNodes2 = xmlNode2.ChildNodes;
							try
							{
								enumerator2 = childNodes2.GetEnumerator();
								while (enumerator2.MoveNext())
								{
									XmlNode xmlNode3 = (XmlNode)enumerator2.Current;
									if (Operators.CompareString(xmlNode3.Name, "ConnectedAP", false) == 0)
									{
										XmlElement xmlElement2 = (XmlElement)xmlNode3;
										if (Operators.CompareString(xmlElement2.GetAttribute("apName"), "AccPoint1", false) == 0)
										{
											xmlElement2.SetAttribute("iedName", IedTxtBx.get_Text());
										}
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
				if (Operators.CompareString(xmlNode.Name, "IED", false) == 0)
				{
					XmlElement xmlElement3 = (XmlElement)xmlNode;
					if (Operators.CompareString(xmlElement3.GetAttribute("type"), "WY9", false) == 0)
					{
						xmlElement3.SetAttribute("name", IedTxtBx.get_Text());
					}
				}
				num3++;
			}
			xmlDocument2.Save(IcdTxtBx.get_Text());
		}
	}

	private void OpenBtn_Click(object sender, EventArgs e)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Invalid comparison between Unknown and I4
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Invalid comparison between Unknown and I4
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		((FileDialog)OpenFileDialog).set_Filter("ICD files (*.icd)|*.icd|All files (*.*)|*.*");
		((FileDialog)OpenFileDialog).set_InitialDirectory(Application.get_StartupPath());
		((FileDialog)OpenFileDialog).set_Title("ICD File");
		if ((int)((CommonDialog)OpenFileDialog).ShowDialog() != 1)
		{
			return;
		}
		string fileName = ((FileDialog)OpenFileDialog).get_FileName();
		string fileName2 = Path.GetFileName(fileName);
		string directoryName = Path.GetDirectoryName(fileName);
		if (Operators.CompareString(directoryName.ToUpper(), Application.get_StartupPath().ToUpper(), false) != 0)
		{
			if ((int)Interaction.MsgBox((object)"This ICD file isn't in application directory, do you want copy is?", (MsgBoxStyle)68, (object)"Copy Request") == 6)
			{
				try
				{
					File.Copy(fileName, Application.get_StartupPath() + Conversions.ToString(Path.DirectorySeparatorChar) + fileName2, overwrite: true);
					IcdTxtBx.set_Text(fileName2);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					Interaction.MsgBox((object)"Can't copy the new ICD file, please check and try again!", (MsgBoxStyle)48, (object)"Copy Error");
					ProjectData.ClearProjectError();
				}
			}
		}
		else
		{
			IcdTxtBx.set_Text(fileName2);
		}
	}

	private void UnlockBtn_Click(object sender, EventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(PasswdBx.get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"You Can Try \"gdwy\" If So Luck!", (MsgBoxStyle)64, (object)"Need Password to Unlock");
			return;
		}
		byte[] array = MD5.Create().ComputeHash(Encoding.Default.GetBytes(PasswdBx.get_Text()));
		StringBuilder stringBuilder = new StringBuilder();
		checked
		{
			int num = array.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				stringBuilder.Append(array[num2].ToString("x2"));
				num2++;
			}
			if (Operators.CompareString(stringBuilder.ToString().ToUpper(), AdminPasswd, false) == 0)
			{
				((Control)SevGpBx).set_Enabled(true);
				((Control)TrayGpBx).set_Enabled(true);
				((Control)PasswdBx).set_Enabled(false);
				((Control)UnlockBtn).set_Enabled(false);
				PasswdBx.set_Text("");
			}
			else
			{
				Interaction.MsgBox((object)"Password Error, Please try it again!", (MsgBoxStyle)48, (object)"Can't Attestation");
				PasswdBx.set_Text("");
			}
		}
	}

	private void PasswdBx_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 13)
		{
			UnlockBtn.PerformClick();
		}
	}

	private void IcdTxtBx_TextChanged(object sender, EventArgs e)
	{
		((Control)SaveBtn).set_Enabled(CheckConfigChanged());
	}

	private void IedTxtBx_TextChanged(object sender, EventArgs e)
	{
		((Control)SaveBtn).set_Enabled(CheckConfigChanged());
	}

	private void StartCkBx_CheckedChanged(object sender, EventArgs e)
	{
		((Control)SaveBtn).set_Enabled(CheckConfigChanged());
	}

	private void LaunchCkBx_CheckedChanged(object sender, EventArgs e)
	{
		((Control)SaveBtn).set_Enabled(CheckConfigChanged());
	}

	private void ServiceCkBx_CheckedChanged(object sender, EventArgs e)
	{
		((Control)SaveBtn).set_Enabled(CheckConfigChanged());
		((Control)LaunchCkBx).set_Enabled(!ServiceCkBx.get_Checked());
	}
}
