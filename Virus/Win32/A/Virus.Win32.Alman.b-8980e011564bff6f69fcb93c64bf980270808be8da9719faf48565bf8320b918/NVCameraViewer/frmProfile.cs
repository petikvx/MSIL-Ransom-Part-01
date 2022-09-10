using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using NVCameraControl;

namespace NVCameraViewer;

[DesignerGenerated]
public class frmProfile : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("GroupBox3")]
	private GroupBox _GroupBox3;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("txtLoginPassword")]
	private TextBox _txtLoginPassword;

	[AccessedThroughProperty("txtLoginAccount")]
	private TextBox _txtLoginAccount;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("radioDirectAccess")]
	private RadioButton _radioDirectAccess;

	[AccessedThroughProperty("radioNVCCServer")]
	private RadioButton _radioNVCCServer;

	[AccessedThroughProperty("radioNVCCforNVideo")]
	private RadioButton _radioNVCCforNVideo;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("txtProfileName")]
	private TextBox _txtProfileName;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("cboCompress")]
	private ComboBox _cboCompress;

	[AccessedThroughProperty("cboSplit")]
	private ComboBox _cboSplit;

	[AccessedThroughProperty("dgvProfileDetail")]
	private DataGridView _dgvProfileDetail;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("GroupBox2")]
	private GroupBox _GroupBox2;

	[AccessedThroughProperty("btnAdd")]
	private Button _btnAdd;

	[AccessedThroughProperty("txtServerIP")]
	private MaskedTextBox _txtServerIP;

	[AccessedThroughProperty("cboCameraID")]
	private ComboBox _cboCameraID;

	[AccessedThroughProperty("txtPort")]
	private TextBox _txtPort;

	[AccessedThroughProperty("txtCameraName")]
	private TextBox _txtCameraName;

	[AccessedThroughProperty("Preview")]
	private CameraControl _Preview;

	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[AccessedThroughProperty("btnUpdate")]
	private Button _btnUpdate;

	[AccessedThroughProperty("btnDelete")]
	private Button _btnDelete;

	[AccessedThroughProperty("Button5")]
	private Button _Button5;

	[AccessedThroughProperty("Button6")]
	private Button _Button6;

	[AccessedThroughProperty("CamName")]
	private DataGridViewTextBoxColumn _CamName;

	[AccessedThroughProperty("IP")]
	private DataGridViewTextBoxColumn _IP;

	[AccessedThroughProperty("Port")]
	private DataGridViewTextBoxColumn _Port;

	[AccessedThroughProperty("CamID")]
	private DataGridViewTextBoxColumn _CamID;

	[AccessedThroughProperty("Index")]
	private DataGridViewTextBoxColumn _Index;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("lblProfileKey")]
	private Label _lblProfileKey;

	private bool iCameraCountLoaded;

	private int iCameraCount;

	public ProfileClass Profile;

	private ProfileClass iCurrentProfile;

	internal virtual GroupBox GroupBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox3 = value;
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

	internal virtual TextBox txtLoginPassword
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtLoginPassword;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtLoginPassword = value;
		}
	}

	internal virtual TextBox txtLoginAccount
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtLoginAccount;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtLoginAccount = value;
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

	internal virtual RadioButton radioDirectAccess
	{
		[DebuggerNonUserCode]
		get
		{
			return _radioDirectAccess;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = radioDirectAccess_CheckedChanged;
			if (_radioDirectAccess != null)
			{
				_radioDirectAccess.remove_CheckedChanged(eventHandler);
			}
			_radioDirectAccess = value;
			if (_radioDirectAccess != null)
			{
				_radioDirectAccess.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual RadioButton radioNVCCServer
	{
		[DebuggerNonUserCode]
		get
		{
			return _radioNVCCServer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = radioNVCCServer_CheckedChanged;
			if (_radioNVCCServer != null)
			{
				_radioNVCCServer.remove_CheckedChanged(eventHandler);
			}
			_radioNVCCServer = value;
			if (_radioNVCCServer != null)
			{
				_radioNVCCServer.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual RadioButton radioNVCCforNVideo
	{
		[DebuggerNonUserCode]
		get
		{
			return _radioNVCCforNVideo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = radioNVCCforNVideo_CheckedChanged;
			if (_radioNVCCforNVideo != null)
			{
				_radioNVCCforNVideo.remove_CheckedChanged(eventHandler);
			}
			_radioNVCCforNVideo = value;
			if (_radioNVCCforNVideo != null)
			{
				_radioNVCCforNVideo.add_CheckedChanged(eventHandler);
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

	internal virtual TextBox txtProfileName
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtProfileName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtProfileName = value;
		}
	}

	internal virtual Label Label6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label6 = value;
		}
	}

	internal virtual ComboBox cboCompress
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboCompress;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboCompress = value;
		}
	}

	internal virtual ComboBox cboSplit
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboSplit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboSplit = value;
		}
	}

	internal virtual DataGridView dgvProfileDetail
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvProfileDetail;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = dgvProfileDetail_Click;
			if (_dgvProfileDetail != null)
			{
				((Control)_dgvProfileDetail).remove_Click(eventHandler);
			}
			_dgvProfileDetail = value;
			if (_dgvProfileDetail != null)
			{
				((Control)_dgvProfileDetail).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label Label7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label7 = value;
		}
	}

	internal virtual Label Label8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label8 = value;
		}
	}

	internal virtual Label Label9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label9 = value;
		}
	}

	internal virtual Label Label10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label10 = value;
		}
	}

	internal virtual GroupBox GroupBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox2 = value;
		}
	}

	internal virtual Button btnAdd
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnAdd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnAdd_Click;
			if (_btnAdd != null)
			{
				((Control)_btnAdd).remove_Click(eventHandler);
			}
			_btnAdd = value;
			if (_btnAdd != null)
			{
				((Control)_btnAdd).add_Click(eventHandler);
			}
		}
	}

	internal virtual MaskedTextBox txtServerIP
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtServerIP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MaskInputRejectedEventHandler val = new MaskInputRejectedEventHandler(txtServerIP_MaskInputRejected);
			if (_txtServerIP != null)
			{
				_txtServerIP.remove_MaskInputRejected(val);
			}
			_txtServerIP = value;
			if (_txtServerIP != null)
			{
				_txtServerIP.add_MaskInputRejected(val);
			}
		}
	}

	internal virtual ComboBox cboCameraID
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboCameraID;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cboCameraID_SelectedIndexChanged;
			if (_cboCameraID != null)
			{
				_cboCameraID.remove_SelectedIndexChanged(eventHandler);
			}
			_cboCameraID = value;
			if (_cboCameraID != null)
			{
				_cboCameraID.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual TextBox txtPort
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPort;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtPort_TextChanged;
			if (_txtPort != null)
			{
				((Control)_txtPort).remove_TextChanged(eventHandler);
			}
			_txtPort = value;
			if (_txtPort != null)
			{
				((Control)_txtPort).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual TextBox txtCameraName
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtCameraName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtCameraName_TextChanged;
			if (_txtCameraName != null)
			{
				((Control)_txtCameraName).remove_TextChanged(eventHandler);
			}
			_txtCameraName = value;
			if (_txtCameraName != null)
			{
				((Control)_txtCameraName).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual CameraControl Preview
	{
		[DebuggerNonUserCode]
		get
		{
			return _Preview;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Preview = value;
		}
	}

	internal virtual Button Button4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button4_Click;
			if (_Button4 != null)
			{
				((Control)_Button4).remove_Click(eventHandler);
			}
			_Button4 = value;
			if (_Button4 != null)
			{
				((Control)_Button4).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button btnUpdate
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnUpdate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnUpdate_Click;
			if (_btnUpdate != null)
			{
				((Control)_btnUpdate).remove_Click(eventHandler);
			}
			_btnUpdate = value;
			if (_btnUpdate != null)
			{
				((Control)_btnUpdate).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button btnDelete
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnDelete;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnDelete_Click;
			if (_btnDelete != null)
			{
				((Control)_btnDelete).remove_Click(eventHandler);
			}
			_btnDelete = value;
			if (_btnDelete != null)
			{
				((Control)_btnDelete).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Button5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button5_Click;
			if (_Button5 != null)
			{
				((Control)_Button5).remove_Click(eventHandler);
			}
			_Button5 = value;
			if (_Button5 != null)
			{
				((Control)_Button5).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Button6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button6_Click;
			if (_Button6 != null)
			{
				((Control)_Button6).remove_Click(eventHandler);
			}
			_Button6 = value;
			if (_Button6 != null)
			{
				((Control)_Button6).add_Click(eventHandler);
			}
		}
	}

	internal virtual DataGridViewTextBoxColumn CamName
	{
		[DebuggerNonUserCode]
		get
		{
			return _CamName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CamName = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn IP
	{
		[DebuggerNonUserCode]
		get
		{
			return _IP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_IP = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Port
	{
		[DebuggerNonUserCode]
		get
		{
			return _Port;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Port = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn CamID
	{
		[DebuggerNonUserCode]
		get
		{
			return _CamID;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CamID = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Index
	{
		[DebuggerNonUserCode]
		get
		{
			return _Index;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Index = value;
		}
	}

	internal virtual Label Label11
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label11 = value;
		}
	}

	internal virtual Button Button1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button1_Click;
			if (_Button1 != null)
			{
				((Control)_Button1).remove_Click(eventHandler);
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				((Control)_Button1).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label lblProfileKey
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblProfileKey;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblProfileKey = value;
		}
	}

	public frmProfile()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(frmProfile_FormClosing));
		((Form)this).add_Load((EventHandler)frmProfile_Load);
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		iCameraCountLoaded = false;
		iCameraCount = 32;
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
		GroupBox3 = new GroupBox();
		Label4 = new Label();
		txtLoginPassword = new TextBox();
		txtLoginAccount = new TextBox();
		Label3 = new Label();
		Label2 = new Label();
		radioDirectAccess = new RadioButton();
		radioNVCCServer = new RadioButton();
		radioNVCCforNVideo = new RadioButton();
		GroupBox1 = new GroupBox();
		Button1 = new Button();
		lblProfileKey = new Label();
		Label11 = new Label();
		txtProfileName = new TextBox();
		Label6 = new Label();
		cboCompress = new ComboBox();
		cboSplit = new ComboBox();
		Label5 = new Label();
		Label1 = new Label();
		dgvProfileDetail = new DataGridView();
		CamName = new DataGridViewTextBoxColumn();
		IP = new DataGridViewTextBoxColumn();
		Port = new DataGridViewTextBoxColumn();
		CamID = new DataGridViewTextBoxColumn();
		Index = new DataGridViewTextBoxColumn();
		Label7 = new Label();
		Label8 = new Label();
		Label9 = new Label();
		Label10 = new Label();
		GroupBox2 = new GroupBox();
		Preview = new CameraControl();
		Button4 = new Button();
		btnUpdate = new Button();
		btnDelete = new Button();
		btnAdd = new Button();
		txtServerIP = new MaskedTextBox();
		cboCameraID = new ComboBox();
		txtPort = new TextBox();
		txtCameraName = new TextBox();
		Button5 = new Button();
		Button6 = new Button();
		((Control)GroupBox3).SuspendLayout();
		((Control)GroupBox1).SuspendLayout();
		((ISupportInitialize)dgvProfileDetail).BeginInit();
		((Control)GroupBox2).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)GroupBox3).get_Controls().Add((Control)(object)Label4);
		((Control)GroupBox3).get_Controls().Add((Control)(object)txtLoginPassword);
		((Control)GroupBox3).get_Controls().Add((Control)(object)txtLoginAccount);
		((Control)GroupBox3).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox3).get_Controls().Add((Control)(object)Label2);
		((Control)GroupBox3).get_Controls().Add((Control)(object)radioDirectAccess);
		((Control)GroupBox3).get_Controls().Add((Control)(object)radioNVCCServer);
		((Control)GroupBox3).get_Controls().Add((Control)(object)radioNVCCforNVideo);
		GroupBox groupBox = GroupBox3;
		Point location = new Point(12, 102);
		((Control)groupBox).set_Location(location);
		((Control)GroupBox3).set_Name("GroupBox3");
		GroupBox groupBox2 = GroupBox3;
		Size size = new Size(603, 141);
		((Control)groupBox2).set_Size(size);
		((Control)GroupBox3).set_TabIndex(10);
		GroupBox3.set_TabStop(false);
		GroupBox3.set_Text("連線方式");
		Label4.set_AutoSize(true);
		Label label = Label4;
		location = new Point(311, 79);
		((Control)label).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label2 = Label4;
		size = new Size(91, 12);
		((Control)label2).set_Size(size);
		((Control)Label4).set_TabIndex(7);
		Label4.set_Text("(最大 20 個字元)");
		TextBox obj = txtLoginPassword;
		location = new Point(150, 103);
		((Control)obj).set_Location(location);
		((TextBoxBase)txtLoginPassword).set_MaxLength(20);
		((Control)txtLoginPassword).set_Name("txtLoginPassword");
		TextBox obj2 = txtLoginPassword;
		size = new Size(155, 22);
		((Control)obj2).set_Size(size);
		((Control)txtLoginPassword).set_TabIndex(6);
		TextBox obj3 = txtLoginAccount;
		location = new Point(150, 76);
		((Control)obj3).set_Location(location);
		((TextBoxBase)txtLoginAccount).set_MaxLength(20);
		((Control)txtLoginAccount).set_Name("txtLoginAccount");
		TextBox obj4 = txtLoginAccount;
		size = new Size(155, 22);
		((Control)obj4).set_Size(size);
		((Control)txtLoginAccount).set_TabIndex(5);
		Label3.set_AutoSize(true);
		Label label3 = Label3;
		location = new Point(23, 106);
		((Control)label3).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label4 = Label3;
		size = new Size(119, 12);
		((Control)label4).set_Size(size);
		((Control)Label3).set_TabIndex(4);
		Label3.set_Text("NVCC Server password:");
		Label2.set_AutoSize(true);
		Label label5 = Label2;
		location = new Point(23, 79);
		((Control)label5).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label6 = Label2;
		size = new Size(112, 12);
		((Control)label6).set_Size(size);
		((Control)Label2).set_TabIndex(3);
		Label2.set_Text("NVCC Server account:");
		((ButtonBase)radioDirectAccess).set_AutoSize(true);
		RadioButton obj5 = radioDirectAccess;
		location = new Point(6, 43);
		((Control)obj5).set_Location(location);
		((Control)radioDirectAccess).set_Name("radioDirectAccess");
		RadioButton obj6 = radioDirectAccess;
		size = new Size(327, 16);
		((Control)obj6).set_Size(size);
		((Control)radioDirectAccess).set_TabIndex(2);
		radioDirectAccess.set_TabStop(true);
		((ButtonBase)radioDirectAccess).set_Text("Direct Camera Access (較快, 可能造成不穩, 且無法統計流量)");
		((ButtonBase)radioDirectAccess).set_UseVisualStyleBackColor(true);
		((ButtonBase)radioNVCCServer).set_AutoSize(true);
		RadioButton obj7 = radioNVCCServer;
		location = new Point(245, 21);
		((Control)obj7).set_Location(location);
		((Control)radioNVCCServer).set_Name("radioNVCCServer");
		RadioButton obj8 = radioNVCCServer;
		size = new Size(88, 16);
		((Control)obj8).set_Size(size);
		((Control)radioNVCCServer).set_TabIndex(1);
		radioNVCCServer.set_TabStop(true);
		((ButtonBase)radioNVCCServer).set_Text("NVCC Server");
		((ButtonBase)radioNVCCServer).set_UseVisualStyleBackColor(true);
		((ButtonBase)radioNVCCforNVideo).set_AutoSize(true);
		RadioButton obj9 = radioNVCCforNVideo;
		location = new Point(6, 21);
		((Control)obj9).set_Location(location);
		((Control)radioNVCCforNVideo).set_Name("radioNVCCforNVideo");
		RadioButton obj10 = radioNVCCforNVideo;
		size = new Size(111, 16);
		((Control)obj10).set_Size(size);
		((Control)radioNVCCforNVideo).set_TabIndex(0);
		radioNVCCforNVideo.set_TabStop(true);
		((ButtonBase)radioNVCCforNVideo).set_Text("NVCC for NVideo");
		((ButtonBase)radioNVCCforNVideo).set_UseVisualStyleBackColor(true);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Button1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)lblProfileKey);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label11);
		((Control)GroupBox1).get_Controls().Add((Control)(object)txtProfileName);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label6);
		((Control)GroupBox1).get_Controls().Add((Control)(object)cboCompress);
		((Control)GroupBox1).get_Controls().Add((Control)(object)cboSplit);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label5);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label1);
		GroupBox groupBox3 = GroupBox1;
		location = new Point(12, 12);
		((Control)groupBox3).set_Location(location);
		((Control)GroupBox1).set_Name("GroupBox1");
		GroupBox groupBox4 = GroupBox1;
		size = new Size(603, 84);
		((Control)groupBox4).set_Size(size);
		((Control)GroupBox1).set_TabIndex(11);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("設定");
		Button button = Button1;
		location = new Point(377, 19);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(75, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(8);
		((ButtonBase)Button1).set_Text("設定");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		lblProfileKey.set_AutoSize(true);
		Label obj11 = lblProfileKey;
		location = new Point(305, 24);
		((Control)obj11).set_Location(location);
		((Control)lblProfileKey).set_Name("lblProfileKey");
		Label obj12 = lblProfileKey;
		size = new Size(25, 12);
		((Control)obj12).set_Size(size);
		((Control)lblProfileKey).set_TabIndex(7);
		lblProfileKey.set_Text("(無)");
		Label11.set_AutoSize(true);
		Label label7 = Label11;
		location = new Point(244, 24);
		((Control)label7).set_Location(location);
		((Control)Label11).set_Name("Label11");
		Label label8 = Label11;
		size = new Size(44, 12);
		((Control)label8).set_Size(size);
		((Control)Label11).set_TabIndex(6);
		Label11.set_Text("快速鍵:");
		TextBox obj13 = txtProfileName;
		location = new Point(79, 21);
		((Control)obj13).set_Location(location);
		((Control)txtProfileName).set_Name("txtProfileName");
		TextBox obj14 = txtProfileName;
		size = new Size(145, 22);
		((Control)obj14).set_Size(size);
		((Control)txtProfileName).set_TabIndex(5);
		Label6.set_AutoSize(true);
		Label label9 = Label6;
		location = new Point(6, 24);
		((Control)label9).set_Location(location);
		((Control)Label6).set_Name("Label6");
		Label label10 = Label6;
		size = new Size(67, 12);
		((Control)label10).set_Size(size);
		((Control)Label6).set_TabIndex(4);
		Label6.set_Text("Profile name:");
		((ListControl)cboCompress).set_FormattingEnabled(true);
		cboCompress.get_Items().AddRange(new object[5] { "Level 0 (品質好)", "Level 1", "Level 2", "Level 3", "Level 4 (傳輸快)" });
		ComboBox obj15 = cboCompress;
		location = new Point(305, 56);
		((Control)obj15).set_Location(location);
		((Control)cboCompress).set_Name("cboCompress");
		ComboBox obj16 = cboCompress;
		size = new Size(121, 20);
		((Control)obj16).set_Size(size);
		((Control)cboCompress).set_TabIndex(3);
		((ListControl)cboSplit).set_FormattingEnabled(true);
		cboSplit.get_Items().AddRange(new object[7] { "(自動)", "1 畫面", "2x2 (4 畫面)", "3x3 (9 畫面)", "4x4 (16 畫面)", "5x5 (25 畫面)", "6x6 (36 畫面)" });
		ComboBox obj17 = cboSplit;
		location = new Point(79, 56);
		((Control)obj17).set_Location(location);
		((Control)cboSplit).set_Name("cboSplit");
		ComboBox obj18 = cboSplit;
		size = new Size(121, 20);
		((Control)obj18).set_Size(size);
		((Control)cboSplit).set_TabIndex(2);
		Label5.set_AutoSize(true);
		Label label11 = Label5;
		location = new Point(243, 59);
		((Control)label11).set_Location(location);
		((Control)Label5).set_Name("Label5");
		Label label12 = Label5;
		size = new Size(56, 12);
		((Control)label12).set_Size(size);
		((Control)Label5).set_TabIndex(1);
		Label5.set_Text("壓縮等級:");
		Label1.set_AutoSize(true);
		Label label13 = Label1;
		location = new Point(6, 59);
		((Control)label13).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label14 = Label1;
		size = new Size(56, 12);
		((Control)label14).set_Size(size);
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("畫面分割:");
		dgvProfileDetail.set_AllowUserToAddRows(false);
		dgvProfileDetail.set_AllowUserToDeleteRows(false);
		dgvProfileDetail.set_AllowUserToResizeRows(false);
		dgvProfileDetail.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		dgvProfileDetail.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[5]
		{
			(DataGridViewColumn)CamName,
			(DataGridViewColumn)IP,
			(DataGridViewColumn)Port,
			(DataGridViewColumn)CamID,
			(DataGridViewColumn)Index
		});
		DataGridView obj19 = dgvProfileDetail;
		location = new Point(12, 249);
		((Control)obj19).set_Location(location);
		dgvProfileDetail.set_MultiSelect(false);
		((Control)dgvProfileDetail).set_Name("dgvProfileDetail");
		dgvProfileDetail.set_ReadOnly(true);
		dgvProfileDetail.set_RowHeadersVisible(false);
		dgvProfileDetail.get_RowTemplate().set_Height(24);
		dgvProfileDetail.set_SelectionMode((DataGridViewSelectionMode)1);
		DataGridView obj20 = dgvProfileDetail;
		size = new Size(240, 260);
		((Control)obj20).set_Size(size);
		((Control)dgvProfileDetail).set_TabIndex(12);
		((DataGridViewColumn)CamName).set_FillWeight(80f);
		((DataGridViewColumn)CamName).set_HeaderText("CamName");
		((DataGridViewColumn)CamName).set_Name("CamName");
		((DataGridViewColumn)CamName).set_ReadOnly(true);
		((DataGridViewColumn)CamName).set_Width(80);
		((DataGridViewColumn)IP).set_FillWeight(60f);
		((DataGridViewColumn)IP).set_HeaderText("IP");
		((DataGridViewColumn)IP).set_Name("IP");
		((DataGridViewColumn)IP).set_ReadOnly(true);
		((DataGridViewColumn)IP).set_Width(60);
		((DataGridViewColumn)Port).set_FillWeight(50f);
		((DataGridViewColumn)Port).set_HeaderText("Port");
		((DataGridViewColumn)Port).set_Name("Port");
		((DataGridViewColumn)Port).set_ReadOnly(true);
		((DataGridViewColumn)Port).set_Width(50);
		((DataGridViewColumn)CamID).set_FillWeight(40f);
		((DataGridViewColumn)CamID).set_HeaderText("CamID");
		((DataGridViewColumn)CamID).set_Name("CamID");
		((DataGridViewColumn)CamID).set_ReadOnly(true);
		((DataGridViewColumn)CamID).set_Width(40);
		((DataGridViewColumn)Index).set_HeaderText("Index");
		((DataGridViewColumn)Index).set_Name("Index");
		((DataGridViewColumn)Index).set_ReadOnly(true);
		((DataGridViewColumn)Index).set_Visible(false);
		Label7.set_AutoSize(true);
		Label label15 = Label7;
		location = new Point(6, 46);
		((Control)label15).set_Location(location);
		((Control)Label7).set_Name("Label7");
		Label label16 = Label7;
		size = new Size(51, 12);
		((Control)label16).set_Size(size);
		((Control)Label7).set_TabIndex(13);
		Label7.set_Text("Server IP:");
		Label8.set_AutoSize(true);
		Label label17 = Label8;
		location = new Point(6, 74);
		((Control)label17).set_Location(location);
		((Control)Label8).set_Name("Label8");
		Label label18 = Label8;
		size = new Size(27, 12);
		((Control)label18).set_Size(size);
		((Control)Label8).set_TabIndex(14);
		Label8.set_Text("Port:");
		Label9.set_AutoSize(true);
		Label label19 = Label9;
		location = new Point(6, 102);
		((Control)label19).set_Location(location);
		((Control)Label9).set_Name("Label9");
		Label label20 = Label9;
		size = new Size(59, 12);
		((Control)label20).set_Size(size);
		((Control)Label9).set_TabIndex(15);
		Label9.set_Text("Camera ID:");
		Label10.set_AutoSize(true);
		Label label21 = Label10;
		location = new Point(6, 18);
		((Control)label21).set_Location(location);
		((Control)Label10).set_Name("Label10");
		Label label22 = Label10;
		size = new Size(72, 12);
		((Control)label22).set_Size(size);
		((Control)Label10).set_TabIndex(16);
		Label10.set_Text("Camera name:");
		((Control)GroupBox2).get_Controls().Add((Control)(object)Preview);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Button4);
		((Control)GroupBox2).get_Controls().Add((Control)(object)btnUpdate);
		((Control)GroupBox2).get_Controls().Add((Control)(object)btnDelete);
		((Control)GroupBox2).get_Controls().Add((Control)(object)btnAdd);
		((Control)GroupBox2).get_Controls().Add((Control)(object)txtServerIP);
		((Control)GroupBox2).get_Controls().Add((Control)(object)cboCameraID);
		((Control)GroupBox2).get_Controls().Add((Control)(object)txtPort);
		((Control)GroupBox2).get_Controls().Add((Control)(object)txtCameraName);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label10);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label7);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label9);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label8);
		GroupBox groupBox5 = GroupBox2;
		location = new Point(258, 249);
		((Control)groupBox5).set_Location(location);
		((Control)GroupBox2).set_Name("GroupBox2");
		GroupBox groupBox6 = GroupBox2;
		size = new Size(357, 220);
		((Control)groupBox6).set_Size(size);
		((Control)GroupBox2).set_TabIndex(17);
		GroupBox2.set_TabStop(false);
		Preview.set_ChannelID(1);
		Preview.set_CompressLevel((enumCompressLevel)0);
		Preview.set_DisplayName("");
		Preview.set_DisplayType((enumDisplayType)2);
		CameraControl preview = Preview;
		location = new Point(171, 71);
		((Control)preview).set_Location(location);
		((Control)Preview).set_Name("Preview");
		Preview.set_PackageType((enumPackageType)0);
		Preview.set_RemoteIP("127.0.0.1");
		Preview.set_RemotePort(20900);
		Preview.set_ShowArchiveButton(false);
		CameraControl preview2 = Preview;
		size = new Size(180, 143);
		((Control)preview2).set_Size(size);
		((Control)Preview).set_TabIndex(25);
		Button button3 = Button4;
		location = new Point(77, 191);
		((Control)button3).set_Location(location);
		((Control)Button4).set_Name("Button4");
		Button button4 = Button4;
		size = new Size(79, 23);
		((Control)button4).set_Size(size);
		((Control)Button4).set_TabIndex(24);
		((ButtonBase)Button4).set_Text("預覽");
		((ButtonBase)Button4).set_UseVisualStyleBackColor(true);
		Button obj21 = btnUpdate;
		location = new Point(6, 162);
		((Control)obj21).set_Location(location);
		((Control)btnUpdate).set_Name("btnUpdate");
		Button obj22 = btnUpdate;
		size = new Size(59, 23);
		((Control)obj22).set_Size(size);
		((Control)btnUpdate).set_TabIndex(23);
		((ButtonBase)btnUpdate).set_Text("Update");
		((ButtonBase)btnUpdate).set_UseVisualStyleBackColor(true);
		Button obj23 = btnDelete;
		location = new Point(6, 191);
		((Control)obj23).set_Location(location);
		((Control)btnDelete).set_Name("btnDelete");
		Button obj24 = btnDelete;
		size = new Size(59, 23);
		((Control)obj24).set_Size(size);
		((Control)btnDelete).set_TabIndex(22);
		((ButtonBase)btnDelete).set_Text("Delete");
		((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
		Button obj25 = btnAdd;
		location = new Point(6, 133);
		((Control)obj25).set_Location(location);
		((Control)btnAdd).set_Name("btnAdd");
		Button obj26 = btnAdd;
		size = new Size(59, 23);
		((Control)obj26).set_Size(size);
		((Control)btnAdd).set_TabIndex(21);
		((ButtonBase)btnAdd).set_Text("Add");
		((ButtonBase)btnAdd).set_UseVisualStyleBackColor(true);
		MaskedTextBox obj27 = txtServerIP;
		location = new Point(84, 43);
		((Control)obj27).set_Location(location);
		((Control)txtServerIP).set_Name("txtServerIP");
		MaskedTextBox obj28 = txtServerIP;
		size = new Size(100, 22);
		((Control)obj28).set_Size(size);
		((Control)txtServerIP).set_TabIndex(20);
		txtServerIP.set_Text("127.0.0.1");
		cboCameraID.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)cboCameraID).set_FormattingEnabled(true);
		ComboBox obj29 = cboCameraID;
		location = new Point(84, 99);
		((Control)obj29).set_Location(location);
		((Control)cboCameraID).set_Name("cboCameraID");
		ComboBox obj30 = cboCameraID;
		size = new Size(72, 20);
		((Control)obj30).set_Size(size);
		((Control)cboCameraID).set_TabIndex(19);
		TextBox obj31 = txtPort;
		location = new Point(84, 71);
		((Control)obj31).set_Location(location);
		((Control)txtPort).set_Name("txtPort");
		TextBox obj32 = txtPort;
		size = new Size(72, 22);
		((Control)obj32).set_Size(size);
		((Control)txtPort).set_TabIndex(18);
		txtPort.set_Text("20900");
		TextBox obj33 = txtCameraName;
		location = new Point(84, 15);
		((Control)obj33).set_Location(location);
		((Control)txtCameraName).set_Name("txtCameraName");
		TextBox obj34 = txtCameraName;
		size = new Size(122, 22);
		((Control)obj34).set_Size(size);
		((Control)txtCameraName).set_TabIndex(17);
		Button button5 = Button5;
		location = new Point(459, 475);
		((Control)button5).set_Location(location);
		((Control)Button5).set_Name("Button5");
		Button button6 = Button5;
		size = new Size(75, 34);
		((Control)button6).set_Size(size);
		((Control)Button5).set_TabIndex(18);
		((ButtonBase)Button5).set_Text("OK");
		((ButtonBase)Button5).set_UseVisualStyleBackColor(true);
		Button6.set_DialogResult((DialogResult)2);
		Button button7 = Button6;
		location = new Point(540, 475);
		((Control)button7).set_Location(location);
		((Control)Button6).set_Name("Button6");
		Button button8 = Button6;
		size = new Size(75, 34);
		((Control)button8).set_Size(size);
		((Control)Button6).set_TabIndex(19);
		((ButtonBase)Button6).set_Text("Cancel");
		((ButtonBase)Button6).set_UseVisualStyleBackColor(true);
		((Form)this).set_AcceptButton((IButtonControl)(object)Button5);
		SizeF autoScaleDimensions = new SizeF(6f, 12f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_CancelButton((IButtonControl)(object)Button6);
		size = new Size(627, 521);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Button6);
		((Control)this).get_Controls().Add((Control)(object)Button5);
		((Control)this).get_Controls().Add((Control)(object)GroupBox2);
		((Control)this).get_Controls().Add((Control)(object)dgvProfileDetail);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)GroupBox3);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("frmProfile");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("frmProfileAdd");
		((Control)GroupBox3).ResumeLayout(false);
		((Control)GroupBox3).PerformLayout();
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((ISupportInitialize)dgvProfileDetail).EndInit();
		((Control)GroupBox2).ResumeLayout(false);
		((Control)GroupBox2).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private bool CheckPreview()
	{
		bool result = false;
		if (Operators.CompareString(txtServerIP.get_Text(), string.Empty, false) != 0 && Operators.CompareString(txtPort.get_Text(), string.Empty, false) != 0 && cboCameraID.get_SelectedIndex() != -1)
		{
			result = true;
		}
		return result;
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		Preview.Close();
		if (CheckPreview())
		{
			Preview.set_CompressLevel((enumCompressLevel)4);
			Preview.set_PackageType((enumPackageType)2);
			Preview.set_RemoteIP(txtServerIP.get_Text());
			Preview.set_RemotePort(checked((int)Conversions.ToLong(txtPort.get_Text())));
			Preview.set_ChannelID(Conversions.ToInteger(cboCameraID.get_SelectedItem()));
			Preview.Connect();
		}
	}

	private void frmProfile_FormClosing(object sender, FormClosingEventArgs e)
	{
		Preview.Close();
	}

	private void frmProfile_Load(object sender, EventArgs e)
	{
		if (!Information.IsNothing((object)Profile))
		{
			iCurrentProfile = (ProfileClass)Module1.XMLDeserial(Module1.XMLSerial(Profile), typeof(ProfileClass));
		}
		else
		{
			iCurrentProfile = new ProfileClass();
		}
		cboCameraID.get_Items().Clear();
		int num = iCameraCount;
		int num2 = 1;
		while (true)
		{
			int num3 = num2;
			int num4 = num;
			if (num3 > num4)
			{
				break;
			}
			cboCameraID.get_Items().Add((object)num2);
			num2 = checked(num2 + 1);
		}
		txtProfileName.set_Text(iCurrentProfile.ProfileName);
		switch (iCurrentProfile.SplitType)
		{
		case ProfileClass.enumSplitType.Auto:
			cboSplit.set_SelectedIndex(0);
			break;
		case ProfileClass.enumSplitType.Split_1:
			cboSplit.set_SelectedIndex(1);
			break;
		case ProfileClass.enumSplitType.Split_2x2:
			cboSplit.set_SelectedIndex(2);
			break;
		case ProfileClass.enumSplitType.Split_3x3:
			cboSplit.set_SelectedIndex(3);
			break;
		case ProfileClass.enumSplitType.Split_4x4:
			cboSplit.set_SelectedIndex(4);
			break;
		case ProfileClass.enumSplitType.Split_5x5:
			cboSplit.set_SelectedIndex(5);
			break;
		case ProfileClass.enumSplitType.Split_6x6:
			cboSplit.set_SelectedIndex(6);
			break;
		}
		switch (iCurrentProfile.CompressType)
		{
		case ProfileClass.enumCompressType.Level_0:
			cboCompress.set_SelectedIndex(0);
			break;
		case ProfileClass.enumCompressType.Level_1:
			cboCompress.set_SelectedIndex(1);
			break;
		case ProfileClass.enumCompressType.Level_2:
			cboCompress.set_SelectedIndex(2);
			break;
		case ProfileClass.enumCompressType.Level_3:
			cboCompress.set_SelectedIndex(3);
			break;
		case ProfileClass.enumCompressType.Level_4:
			cboCompress.set_SelectedIndex(4);
			break;
		}
		switch (iCurrentProfile.ServerType)
		{
		case ProfileClass.enumServerType.NVideoType:
			radioDirectAccess.set_Checked(true);
			break;
		case ProfileClass.enumServerType.NVCCTypeForNVCCServer:
			radioNVCCServer.set_Checked(true);
			break;
		case ProfileClass.enumServerType.NVCCTypeForNVideoServer:
			radioNVCCforNVideo.set_Checked(true);
			break;
		}
		dgvProfileDetailShow();
		dgvClearSelection();
		InitUI();
	}

	private void Button6_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		ArrayList arrayList = new ArrayList();
		if (Information.IsNothing((object)Profile))
		{
			Profile = new ProfileClass();
		}
		if (!Information.IsNothing((object)iCurrentProfile.CameraList))
		{
			ProfileCameraItemClass[] cameraList = iCurrentProfile.CameraList;
			foreach (ProfileCameraItemClass value in cameraList)
			{
				arrayList.Add(value);
			}
			Profile.CameraList = (ProfileCameraItemClass[])arrayList.ToArray(typeof(ProfileCameraItemClass));
		}
		switch (cboCompress.get_SelectedIndex())
		{
		case 0:
			Profile.CompressType = ProfileClass.enumCompressType.Level_0;
			break;
		case 1:
			Profile.CompressType = ProfileClass.enumCompressType.Level_1;
			break;
		case 2:
			Profile.CompressType = ProfileClass.enumCompressType.Level_2;
			break;
		case 3:
			Profile.CompressType = ProfileClass.enumCompressType.Level_3;
			break;
		case 4:
			Profile.CompressType = ProfileClass.enumCompressType.Level_4;
			break;
		}
		switch (cboSplit.get_SelectedIndex())
		{
		case 0:
			Profile.SplitType = ProfileClass.enumSplitType.Auto;
			break;
		case 1:
			Profile.SplitType = ProfileClass.enumSplitType.Split_1;
			break;
		case 2:
			Profile.SplitType = ProfileClass.enumSplitType.Split_2x2;
			break;
		case 3:
			Profile.SplitType = ProfileClass.enumSplitType.Split_3x3;
			break;
		case 4:
			Profile.SplitType = ProfileClass.enumSplitType.Split_4x4;
			break;
		case 5:
			Profile.SplitType = ProfileClass.enumSplitType.Split_5x5;
			break;
		case 6:
			Profile.SplitType = ProfileClass.enumSplitType.Split_6x6;
			break;
		}
		if (radioNVCCServer.get_Checked())
		{
			Profile.ServerType = ProfileClass.enumServerType.NVCCTypeForNVCCServer;
		}
		else if (radioNVCCforNVideo.get_Checked())
		{
			Profile.ServerType = ProfileClass.enumServerType.NVCCTypeForNVideoServer;
		}
		else if (radioDirectAccess.get_Checked())
		{
			Profile.ServerType = ProfileClass.enumServerType.NVideoType;
		}
		Profile.LoginAccount = txtLoginAccount.get_Text();
		Profile.LoginPassword = txtLoginPassword.get_Text();
		Profile.ProfileName = txtProfileName.get_Text();
		((Form)this).Close();
	}

	private void dgvClearSelection()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((BaseCollection)dgvProfileDetail.get_SelectedRows()).GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow val = (DataGridViewRow)enumerator.Current;
				val.set_Selected(false);
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

	private void dgvProfileDetailShow()
	{
		dgvProfileDetail.get_Rows().Clear();
		if (Information.IsNothing((object)iCurrentProfile.CameraList))
		{
			return;
		}
		checked
		{
			int num = iCurrentProfile.CameraList.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					ProfileCameraItemClass profileCameraItemClass = iCurrentProfile.CameraList[num2];
					int num5 = dgvProfileDetail.get_Rows().Add();
					dgvProfileDetail.get_Rows().get_Item(num5).get_Cells()
						.get_Item("CamName")
						.set_Value((object)profileCameraItemClass.CameraName);
					dgvProfileDetail.get_Rows().get_Item(num5).get_Cells()
						.get_Item("IP")
						.set_Value((object)profileCameraItemClass.CameraIP);
					dgvProfileDetail.get_Rows().get_Item(num5).get_Cells()
						.get_Item("Port")
						.set_Value((object)profileCameraItemClass.CameraPort);
					dgvProfileDetail.get_Rows().get_Item(num5).get_Cells()
						.get_Item("CamID")
						.set_Value((object)profileCameraItemClass.CameraID);
					dgvProfileDetail.get_Rows().get_Item(num5).get_Cells()
						.get_Item("Index")
						.set_Value((object)num2);
					num2++;
					continue;
				}
				break;
			}
		}
	}

	private void InitUI()
	{
		if (radioNVCCServer.get_Checked())
		{
			((Control)txtLoginAccount).set_Enabled(true);
			((Control)txtLoginPassword).set_Enabled(true);
		}
		else
		{
			((Control)txtLoginAccount).set_Enabled(false);
			((Control)txtLoginPassword).set_Enabled(false);
		}
		if (Operators.CompareString(txtCameraName.get_Text(), string.Empty, false) == 0)
		{
			((Control)btnAdd).set_Enabled(false);
		}
		else
		{
			((Control)btnAdd).set_Enabled(true);
		}
		if (((BaseCollection)dgvProfileDetail.get_SelectedRows()).get_Count() > 0)
		{
			((Control)btnUpdate).set_Enabled(true);
			((Control)btnDelete).set_Enabled(true);
		}
		else
		{
			((Control)btnUpdate).set_Enabled(false);
			((Control)btnDelete).set_Enabled(false);
		}
		if (CheckPreview())
		{
			((Control)Button4).set_Enabled(true);
		}
		else
		{
			((Control)Button4).set_Enabled(false);
		}
		if (Operators.CompareString(txtProfileName.get_Text(), string.Empty, false) != 0)
		{
			if (dgvProfileDetail.get_Rows().get_Count() > 0)
			{
				((Control)Button5).set_Enabled(true);
			}
			else
			{
				((Control)Button5).set_Enabled(false);
			}
		}
		else
		{
			((Control)Button5).set_Enabled(false);
		}
		ShowProfileKey();
	}

	private void btnDelete_Click(object sender, EventArgs e)
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		ArrayList arrayList = new ArrayList();
		if (((BaseCollection)dgvProfileDetail.get_SelectedRows()).get_Count() <= 0)
		{
			return;
		}
		int num = Conversions.ToInteger(dgvProfileDetail.get_SelectedRows().get_Item(0).get_Cells()
			.get_Item("Index")
			.get_Value());
		if (!Information.IsNothing((object)iCurrentProfile.CameraList))
		{
			arrayList.AddRange(iCurrentProfile.CameraList);
			arrayList.RemoveAt(num);
			iCurrentProfile.CameraList = (ProfileCameraItemClass[])arrayList.ToArray(typeof(ProfileCameraItemClass));
		}
		dgvProfileDetailShow();
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((IEnumerable)dgvProfileDetail.get_Rows()).GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow val = (DataGridViewRow)enumerator.Current;
				if (Conversions.ToInteger(val.get_Cells().get_Item("Index").get_Value()) >= num)
				{
					val.set_Selected(true);
					break;
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
		if (((BaseCollection)dgvProfileDetail.get_SelectedRows()).get_Count() <= 0 && dgvProfileDetail.get_Rows().get_Count() > 0)
		{
			dgvProfileDetail.get_Rows().get_Item(checked(dgvProfileDetail.get_Rows().get_Count() - 1)).set_Selected(true);
		}
		dgvSelectItem();
		InitUI();
	}

	private void btnUpdate_Click(object sender, EventArgs e)
	{
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		if (((BaseCollection)dgvProfileDetail.get_SelectedRows()).get_Count() <= 0)
		{
			return;
		}
		int num = Conversions.ToInteger(dgvProfileDetail.get_SelectedRows().get_Item(0).get_Cells()
			.get_Item("Index")
			.get_Value());
		ProfileCameraItemClass profileCameraItemClass = iCurrentProfile.CameraList[num];
		profileCameraItemClass.CameraID = Conversions.ToInteger(cboCameraID.get_SelectedItem());
		profileCameraItemClass.CameraIP = txtServerIP.get_Text();
		profileCameraItemClass.CameraPort = Conversions.ToInteger(txtPort.get_Text());
		profileCameraItemClass.CameraName = txtCameraName.get_Text();
		dgvProfileDetailShow();
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((IEnumerable)dgvProfileDetail.get_Rows()).GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow val = (DataGridViewRow)enumerator.Current;
				if (Conversions.ToInteger(val.get_Cells().get_Item("Index").get_Value()) == num)
				{
					val.set_Selected(true);
					break;
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
		dgvSelectItem();
		InitUI();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		ArrayList arrayList = new ArrayList();
		ProfileCameraItemClass profileCameraItemClass = new ProfileCameraItemClass();
		profileCameraItemClass.CameraID = Conversions.ToInteger(cboCameraID.get_SelectedItem());
		profileCameraItemClass.CameraIP = txtServerIP.get_Text();
		profileCameraItemClass.CameraPort = Conversions.ToInteger(txtPort.get_Text());
		profileCameraItemClass.CameraName = txtCameraName.get_Text();
		if (!Information.IsNothing((object)iCurrentProfile.CameraList))
		{
			arrayList.AddRange(iCurrentProfile.CameraList);
		}
		arrayList.Add(profileCameraItemClass);
		iCurrentProfile.CameraList = (ProfileCameraItemClass[])arrayList.ToArray(typeof(ProfileCameraItemClass));
		dgvProfileDetailShow();
		if (dgvProfileDetail.get_Rows().get_Count() > 0)
		{
			dgvProfileDetail.get_Rows().get_Item(checked(dgvProfileDetail.get_Rows().get_Count() - 1)).set_Selected(true);
		}
		dgvSelectItem();
		InitUI();
	}

	private void dgvSelectItem()
	{
		if (((BaseCollection)dgvProfileDetail.get_SelectedRows()).get_Count() > 0 && ((BaseCollection)dgvProfileDetail.get_SelectedRows()).get_Count() > 0)
		{
			int num = Conversions.ToInteger(dgvProfileDetail.get_SelectedRows().get_Item(0).get_Cells()
				.get_Item("Index")
				.get_Value());
			ProfileCameraItemClass profileCameraItemClass = iCurrentProfile.CameraList[num];
			txtCameraName.set_Text(profileCameraItemClass.CameraName);
			txtServerIP.set_Text(profileCameraItemClass.CameraIP);
			txtPort.set_Text(Conversions.ToString(profileCameraItemClass.CameraPort));
			cboCameraID.set_SelectedItem((object)profileCameraItemClass.CameraID);
		}
	}

	private void txtCameraName_TextChanged(object sender, EventArgs e)
	{
		InitUI();
	}

	private void txtServerIP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
	{
		InitUI();
	}

	private void txtPort_TextChanged(object sender, EventArgs e)
	{
		InitUI();
	}

	private void cboCameraID_SelectedIndexChanged(object sender, EventArgs e)
	{
		InitUI();
	}

	private void radioNVCCforNVideo_CheckedChanged(object sender, EventArgs e)
	{
		InitUI();
	}

	private void radioNVCCServer_CheckedChanged(object sender, EventArgs e)
	{
		InitUI();
	}

	private void radioDirectAccess_CheckedChanged(object sender, EventArgs e)
	{
		InitUI();
	}

	private void dgvProfileDetail_Click(object sender, EventArgs e)
	{
		dgvSelectItem();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		frmKeySet frmKeySet2 = new frmKeySet();
		((Form)frmKeySet2).ShowDialog();
		if (frmKeySet2.IsClearSetting)
		{
			Profile.ProfileKey = null;
		}
		else if (!frmKeySet2.IsCancel & !frmKeySet2.IsClearSetting)
		{
			ProfileKeyClass profileKeyClass = new ProfileKeyClass();
			profileKeyClass.AltKey = frmKeySet2.AltPress;
			profileKeyClass.CtrlKey = frmKeySet2.CtrlPress;
			profileKeyClass.ShiftKey = frmKeySet2.ShiftPress;
			profileKeyClass.KeyCode = frmKeySet2.KeyCode;
			Profile.ProfileKey = profileKeyClass;
		}
		ShowProfileKey();
	}

	private void ShowProfileKey()
	{
		string empty = string.Empty;
		empty = "(無)";
		if (!Information.IsNothing((object)Profile) && !Information.IsNothing((object)Profile.ProfileKey))
		{
			empty = string.Empty;
			if (Profile.ProfileKey.AltKey)
			{
				empty = "Alt";
			}
			if (Profile.ProfileKey.CtrlKey)
			{
				if (Operators.CompareString(empty, string.Empty, false) != 0)
				{
					empty += "+";
				}
				empty += "Ctrl";
			}
			if (Profile.ProfileKey.ShiftKey)
			{
				if (Operators.CompareString(empty, string.Empty, false) != 0)
				{
					empty += "+";
				}
				empty += "Shift";
			}
			if (Operators.CompareString(empty, string.Empty, false) != 0)
			{
				empty += "+";
			}
			empty += Conversions.ToString(Strings.Chr(Profile.ProfileKey.KeyCode));
		}
		lblProfileKey.set_Text(empty);
	}
}
