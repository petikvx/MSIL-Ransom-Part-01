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
using NVCameraViewer.My;

namespace NVCameraViewer;

[DesignerGenerated]
public class frmConfig : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("LstProfile")]
	private ListBox _LstProfile;

	[AccessedThroughProperty("btnProfileRemove")]
	private Button _btnProfileRemove;

	[AccessedThroughProperty("btnProfileAdd")]
	private Button _btnProfileAdd;

	[AccessedThroughProperty("rdoGDI")]
	private RadioButton _rdoGDI;

	[AccessedThroughProperty("rdoOverlay")]
	private RadioButton _rdoOverlay;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[AccessedThroughProperty("GroupBox2")]
	private GroupBox _GroupBox2;

	[AccessedThroughProperty("btnProfileEdit")]
	private Button _btnProfileEdit;

	[AccessedThroughProperty("dgvDetail")]
	private DataGridView _dgvDetail;

	[AccessedThroughProperty("CamName")]
	private DataGridViewTextBoxColumn _CamName;

	[AccessedThroughProperty("IP")]
	private DataGridViewTextBoxColumn _IP;

	[AccessedThroughProperty("CamID")]
	private DataGridViewTextBoxColumn _CamID;

	[AccessedThroughProperty("GroupBox3")]
	private GroupBox _GroupBox3;

	[AccessedThroughProperty("txtRecordPath")]
	private TextBox _txtRecordPath;

	[AccessedThroughProperty("txtCapturePath")]
	private TextBox _txtCapturePath;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("btnRecordPath")]
	private Button _btnRecordPath;

	[AccessedThroughProperty("btnCapturePath")]
	private Button _btnCapturePath;

	[AccessedThroughProperty("FolderBrowser")]
	private FolderBrowserDialog _FolderBrowser;

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

	internal virtual ListBox LstProfile
	{
		[DebuggerNonUserCode]
		get
		{
			return _LstProfile;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = LstProfile_SelectedIndexChanged;
			if (_LstProfile != null)
			{
				_LstProfile.remove_SelectedIndexChanged(eventHandler);
			}
			_LstProfile = value;
			if (_LstProfile != null)
			{
				_LstProfile.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual Button btnProfileRemove
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnProfileRemove;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnProfileRemove_Click;
			if (_btnProfileRemove != null)
			{
				((Control)_btnProfileRemove).remove_Click(eventHandler);
			}
			_btnProfileRemove = value;
			if (_btnProfileRemove != null)
			{
				((Control)_btnProfileRemove).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button btnProfileAdd
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnProfileAdd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnProfileAdd_Click;
			if (_btnProfileAdd != null)
			{
				((Control)_btnProfileAdd).remove_Click(eventHandler);
			}
			_btnProfileAdd = value;
			if (_btnProfileAdd != null)
			{
				((Control)_btnProfileAdd).add_Click(eventHandler);
			}
		}
	}

	internal virtual RadioButton rdoGDI
	{
		[DebuggerNonUserCode]
		get
		{
			return _rdoGDI;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_rdoGDI = value;
		}
	}

	internal virtual RadioButton rdoOverlay
	{
		[DebuggerNonUserCode]
		get
		{
			return _rdoOverlay;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_rdoOverlay = value;
		}
	}

	internal virtual Button Button3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button3_Click;
			if (_Button3 != null)
			{
				((Control)_Button3).remove_Click(eventHandler);
			}
			_Button3 = value;
			if (_Button3 != null)
			{
				((Control)_Button3).add_Click(eventHandler);
			}
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

	internal virtual Button btnProfileEdit
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnProfileEdit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnProfileEdit_Click;
			if (_btnProfileEdit != null)
			{
				((Control)_btnProfileEdit).remove_Click(eventHandler);
			}
			_btnProfileEdit = value;
			if (_btnProfileEdit != null)
			{
				((Control)_btnProfileEdit).add_Click(eventHandler);
			}
		}
	}

	internal virtual DataGridView dgvDetail
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvDetail;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvDetail = value;
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

	internal virtual TextBox txtRecordPath
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtRecordPath;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtRecordPath = value;
		}
	}

	internal virtual TextBox txtCapturePath
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtCapturePath;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtCapturePath = value;
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

	internal virtual Button btnRecordPath
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnRecordPath;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnRecordPath_Click;
			if (_btnRecordPath != null)
			{
				((Control)_btnRecordPath).remove_Click(eventHandler);
			}
			_btnRecordPath = value;
			if (_btnRecordPath != null)
			{
				((Control)_btnRecordPath).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button btnCapturePath
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnCapturePath;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnCapturePath_Click;
			if (_btnCapturePath != null)
			{
				((Control)_btnCapturePath).remove_Click(eventHandler);
			}
			_btnCapturePath = value;
			if (_btnCapturePath != null)
			{
				((Control)_btnCapturePath).add_Click(eventHandler);
			}
		}
	}

	internal virtual FolderBrowserDialog FolderBrowser
	{
		[DebuggerNonUserCode]
		get
		{
			return _FolderBrowser;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_FolderBrowser = value;
		}
	}

	[DebuggerNonUserCode]
	public frmConfig()
	{
		((Form)this).add_Load((EventHandler)frmConfig_Load);
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
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
		GroupBox1 = new GroupBox();
		dgvDetail = new DataGridView();
		CamName = new DataGridViewTextBoxColumn();
		IP = new DataGridViewTextBoxColumn();
		CamID = new DataGridViewTextBoxColumn();
		btnProfileEdit = new Button();
		btnProfileRemove = new Button();
		btnProfileAdd = new Button();
		Label1 = new Label();
		LstProfile = new ListBox();
		rdoGDI = new RadioButton();
		rdoOverlay = new RadioButton();
		Button3 = new Button();
		Button4 = new Button();
		GroupBox2 = new GroupBox();
		GroupBox3 = new GroupBox();
		btnRecordPath = new Button();
		btnCapturePath = new Button();
		txtRecordPath = new TextBox();
		txtCapturePath = new TextBox();
		Label3 = new Label();
		Label2 = new Label();
		FolderBrowser = new FolderBrowserDialog();
		((Control)GroupBox1).SuspendLayout();
		((ISupportInitialize)dgvDetail).BeginInit();
		((Control)GroupBox2).SuspendLayout();
		((Control)GroupBox3).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)GroupBox1).get_Controls().Add((Control)(object)dgvDetail);
		((Control)GroupBox1).get_Controls().Add((Control)(object)btnProfileEdit);
		((Control)GroupBox1).get_Controls().Add((Control)(object)btnProfileRemove);
		((Control)GroupBox1).get_Controls().Add((Control)(object)btnProfileAdd);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)LstProfile);
		GroupBox groupBox = GroupBox1;
		Point location = new Point(12, 12);
		((Control)groupBox).set_Location(location);
		((Control)GroupBox1).set_Name("GroupBox1");
		GroupBox groupBox2 = GroupBox1;
		Size size = new Size(456, 215);
		((Control)groupBox2).set_Size(size);
		((Control)GroupBox1).set_TabIndex(0);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("Profile");
		dgvDetail.set_AllowUserToAddRows(false);
		dgvDetail.set_AllowUserToDeleteRows(false);
		dgvDetail.set_AllowUserToResizeRows(false);
		dgvDetail.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		dgvDetail.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[3]
		{
			(DataGridViewColumn)CamName,
			(DataGridViewColumn)IP,
			(DataGridViewColumn)CamID
		});
		DataGridView obj = dgvDetail;
		location = new Point(261, 36);
		((Control)obj).set_Location(location);
		((Control)dgvDetail).set_Name("dgvDetail");
		dgvDetail.set_ReadOnly(true);
		dgvDetail.set_RowHeadersVisible(false);
		dgvDetail.get_RowTemplate().set_Height(24);
		DataGridView obj2 = dgvDetail;
		size = new Size(189, 172);
		((Control)obj2).set_Size(size);
		((Control)dgvDetail).set_TabIndex(13);
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
		((DataGridViewColumn)CamID).set_FillWeight(40f);
		((DataGridViewColumn)CamID).set_HeaderText("CamID");
		((DataGridViewColumn)CamID).set_Name("CamID");
		((DataGridViewColumn)CamID).set_ReadOnly(true);
		((DataGridViewColumn)CamID).set_Width(40);
		Button obj3 = btnProfileEdit;
		location = new Point(9, 104);
		((Control)obj3).set_Location(location);
		((Control)btnProfileEdit).set_Name("btnProfileEdit");
		Button obj4 = btnProfileEdit;
		size = new Size(75, 37);
		((Control)obj4).set_Size(size);
		((Control)btnProfileEdit).set_TabIndex(5);
		((ButtonBase)btnProfileEdit).set_Text("Edit Profile");
		((ButtonBase)btnProfileEdit).set_UseVisualStyleBackColor(true);
		Button obj5 = btnProfileRemove;
		location = new Point(9, 147);
		((Control)obj5).set_Location(location);
		((Control)btnProfileRemove).set_Name("btnProfileRemove");
		Button obj6 = btnProfileRemove;
		size = new Size(75, 38);
		((Control)obj6).set_Size(size);
		((Control)btnProfileRemove).set_TabIndex(3);
		((ButtonBase)btnProfileRemove).set_Text("Remove Profile");
		((ButtonBase)btnProfileRemove).set_UseVisualStyleBackColor(true);
		Button obj7 = btnProfileAdd;
		location = new Point(9, 61);
		((Control)obj7).set_Location(location);
		((Control)btnProfileAdd).set_Name("btnProfileAdd");
		Button obj8 = btnProfileAdd;
		size = new Size(75, 37);
		((Control)obj8).set_Size(size);
		((Control)btnProfileAdd).set_TabIndex(2);
		((ButtonBase)btnProfileAdd).set_Text("Add Profile");
		((ButtonBase)btnProfileAdd).set_UseVisualStyleBackColor(true);
		Label1.set_AutoSize(true);
		Label label = Label1;
		location = new Point(90, 18);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(36, 12);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(1);
		Label1.set_Text("Profile");
		((ListControl)LstProfile).set_FormattingEnabled(true);
		LstProfile.set_ItemHeight(12);
		ListBox lstProfile = LstProfile;
		location = new Point(90, 36);
		((Control)lstProfile).set_Location(location);
		((Control)LstProfile).set_Name("LstProfile");
		ListBox lstProfile2 = LstProfile;
		size = new Size(165, 172);
		((Control)lstProfile2).set_Size(size);
		((Control)LstProfile).set_TabIndex(0);
		((ButtonBase)rdoGDI).set_AutoSize(true);
		RadioButton obj9 = rdoGDI;
		location = new Point(6, 21);
		((Control)obj9).set_Location(location);
		((Control)rdoGDI).set_Name("rdoGDI");
		RadioButton obj10 = rdoGDI;
		size = new Size(216, 16);
		((Control)obj10).set_Size(size);
		((Control)rdoGDI).set_TabIndex(2);
		rdoGDI.set_TabStop(true);
		((ButtonBase)rdoGDI).set_Text("GDI (顯示較慢, 多數顯示卡均可使用)");
		((ButtonBase)rdoGDI).set_UseVisualStyleBackColor(true);
		((ButtonBase)rdoOverlay).set_AutoSize(true);
		RadioButton obj11 = rdoOverlay;
		location = new Point(245, 21);
		((Control)obj11).set_Location(location);
		((Control)rdoOverlay).set_Name("rdoOverlay");
		RadioButton obj12 = rdoOverlay;
		size = new Size(119, 16);
		((Control)obj12).set_Size(size);
		((Control)rdoOverlay).set_TabIndex(3);
		rdoOverlay.set_TabStop(true);
		((ButtonBase)rdoOverlay).set_Text("Overlay (顯示較快)");
		((ButtonBase)rdoOverlay).set_UseVisualStyleBackColor(true);
		Button3.set_DialogResult((DialogResult)2);
		Button button = Button3;
		location = new Point(366, 415);
		((Control)button).set_Location(location);
		((Control)Button3).set_Name("Button3");
		Button button2 = Button3;
		size = new Size(96, 42);
		((Control)button2).set_Size(size);
		((Control)Button3).set_TabIndex(4);
		((ButtonBase)Button3).set_Text("Cancel");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(true);
		Button button3 = Button4;
		location = new Point(257, 415);
		((Control)button3).set_Location(location);
		((Control)Button4).set_Name("Button4");
		Button button4 = Button4;
		size = new Size(97, 42);
		((Control)button4).set_Size(size);
		((Control)Button4).set_TabIndex(5);
		((ButtonBase)Button4).set_Text("OK");
		((ButtonBase)Button4).set_UseVisualStyleBackColor(true);
		((Control)GroupBox2).get_Controls().Add((Control)(object)rdoGDI);
		((Control)GroupBox2).get_Controls().Add((Control)(object)rdoOverlay);
		GroupBox groupBox3 = GroupBox2;
		location = new Point(12, 233);
		((Control)groupBox3).set_Location(location);
		((Control)GroupBox2).set_Name("GroupBox2");
		GroupBox groupBox4 = GroupBox2;
		size = new Size(456, 48);
		((Control)groupBox4).set_Size(size);
		((Control)GroupBox2).set_TabIndex(8);
		GroupBox2.set_TabStop(false);
		GroupBox2.set_Text("顯示模式");
		((Control)GroupBox3).get_Controls().Add((Control)(object)btnRecordPath);
		((Control)GroupBox3).get_Controls().Add((Control)(object)btnCapturePath);
		((Control)GroupBox3).get_Controls().Add((Control)(object)txtRecordPath);
		((Control)GroupBox3).get_Controls().Add((Control)(object)txtCapturePath);
		((Control)GroupBox3).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox3).get_Controls().Add((Control)(object)Label2);
		GroupBox groupBox5 = GroupBox3;
		location = new Point(12, 287);
		((Control)groupBox5).set_Location(location);
		((Control)GroupBox3).set_Name("GroupBox3");
		GroupBox groupBox6 = GroupBox3;
		size = new Size(456, 97);
		((Control)groupBox6).set_Size(size);
		((Control)GroupBox3).set_TabIndex(9);
		GroupBox3.set_TabStop(false);
		GroupBox3.set_Text("路徑設定");
		Button obj13 = btnRecordPath;
		location = new Point(370, 61);
		((Control)obj13).set_Location(location);
		((Control)btnRecordPath).set_Name("btnRecordPath");
		Button obj14 = btnRecordPath;
		size = new Size(63, 22);
		((Control)obj14).set_Size(size);
		((Control)btnRecordPath).set_TabIndex(5);
		((ButtonBase)btnRecordPath).set_Text("瀏覽");
		((ButtonBase)btnRecordPath).set_UseVisualStyleBackColor(true);
		Button obj15 = btnCapturePath;
		location = new Point(370, 21);
		((Control)obj15).set_Location(location);
		((Control)btnCapturePath).set_Name("btnCapturePath");
		Button obj16 = btnCapturePath;
		size = new Size(63, 22);
		((Control)obj16).set_Size(size);
		((Control)btnCapturePath).set_TabIndex(4);
		((ButtonBase)btnCapturePath).set_Text("瀏覽");
		((ButtonBase)btnCapturePath).set_UseVisualStyleBackColor(true);
		TextBox obj17 = txtRecordPath;
		location = new Point(92, 61);
		((Control)obj17).set_Location(location);
		((Control)txtRecordPath).set_Name("txtRecordPath");
		TextBox obj18 = txtRecordPath;
		size = new Size(272, 22);
		((Control)obj18).set_Size(size);
		((Control)txtRecordPath).set_TabIndex(3);
		TextBox obj19 = txtCapturePath;
		location = new Point(92, 21);
		((Control)obj19).set_Location(location);
		((Control)txtCapturePath).set_Name("txtCapturePath");
		TextBox obj20 = txtCapturePath;
		size = new Size(272, 22);
		((Control)obj20).set_Size(size);
		((Control)txtCapturePath).set_TabIndex(2);
		Label3.set_AutoSize(true);
		Label label3 = Label3;
		location = new Point(6, 64);
		((Control)label3).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label4 = Label3;
		size = new Size(80, 12);
		((Control)label4).set_Size(size);
		((Control)Label3).set_TabIndex(1);
		Label3.set_Text("遠端錄影路徑:");
		Label2.set_AutoSize(true);
		Label label5 = Label2;
		location = new Point(6, 28);
		((Control)label5).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label6 = Label2;
		size = new Size(80, 12);
		((Control)label6).set_Size(size);
		((Control)Label2).set_TabIndex(0);
		Label2.set_Text("拍照存檔路徑:");
		((Form)this).set_AcceptButton((IButtonControl)(object)Button4);
		SizeF autoScaleDimensions = new SizeF(6f, 12f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_CancelButton((IButtonControl)(object)Button3);
		size = new Size(474, 469);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)GroupBox3);
		((Control)this).get_Controls().Add((Control)(object)GroupBox2);
		((Control)this).get_Controls().Add((Control)(object)Button4);
		((Control)this).get_Controls().Add((Control)(object)Button3);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("frmConfig");
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Form)this).set_Text("frmConfig");
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((ISupportInitialize)dgvDetail).EndInit();
		((Control)GroupBox2).ResumeLayout(false);
		((Control)GroupBox2).PerformLayout();
		((Control)GroupBox3).ResumeLayout(false);
		((Control)GroupBox3).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void frmConfig_Load(object sender, EventArgs e)
	{
		LoadProfile();
		switch (Module1.SettingObject.DisplayType)
		{
		case SettingClass.enumDisplayType.GDI:
			rdoGDI.set_Checked(true);
			break;
		case SettingClass.enumDisplayType.Overlay:
			rdoOverlay.set_Checked(true);
			break;
		}
		txtCapturePath.set_Text(Module1.SettingObject.CapturePath);
		txtRecordPath.set_Text(Module1.SettingObject.RecordPath);
		InitUI();
	}

	public void LoadProfile()
	{
		LstProfile.get_Items().Clear();
		if (!Information.IsNothing((object)Module1.SettingObject.Profiles))
		{
			ProfileClass[] profiles = Module1.SettingObject.Profiles;
			foreach (ProfileClass profileClass in profiles)
			{
				LstProfile.get_Items().Add((object)profileClass.ProfileName);
			}
		}
		ShowSelectedDetail();
	}

	public void ShowSelectedDetail()
	{
		if (LstProfile.get_SelectedIndex() != -1 && !Information.IsNothing((object)Module1.SettingObject.Profiles) && LstProfile.get_SelectedIndex() <= checked(Module1.SettingObject.Profiles.Length - 1))
		{
			ProfileClass pC = Module1.SettingObject.Profiles[LstProfile.get_SelectedIndex()];
			dgvDetailShow(pC);
		}
	}

	public void dgvDetailShow(ProfileClass PC)
	{
		dgvDetail.get_Rows().Clear();
		if (!Information.IsNothing((object)PC) && !Information.IsNothing((object)PC.CameraList))
		{
			ProfileCameraItemClass[] cameraList = PC.CameraList;
			foreach (ProfileCameraItemClass profileCameraItemClass in cameraList)
			{
				int num = dgvDetail.get_Rows().Add();
				dgvDetail.get_Rows().get_Item(num).get_Cells()
					.get_Item("CamName")
					.set_Value((object)profileCameraItemClass.CameraName);
				dgvDetail.get_Rows().get_Item(num).get_Cells()
					.get_Item("IP")
					.set_Value((object)profileCameraItemClass.CameraIP);
				dgvDetail.get_Rows().get_Item(num).get_Cells()
					.get_Item("CamID")
					.set_Value((object)profileCameraItemClass.CameraID);
			}
		}
	}

	private void LstProfile_SelectedIndexChanged(object sender, EventArgs e)
	{
		ShowSelectedDetail();
		InitUI();
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		if (rdoGDI.get_Checked())
		{
			Module1.SettingObject.DisplayType = SettingClass.enumDisplayType.GDI;
		}
		else
		{
			Module1.SettingObject.DisplayType = SettingClass.enumDisplayType.Overlay;
		}
		Module1.SettingObject.CapturePath = txtCapturePath.get_Text();
		Module1.SettingObject.RecordPath = txtRecordPath.get_Text();
		Module1.SaveSetting();
		((Form)this).Close();
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		Module1.LoadSetting();
		((Form)this).Close();
	}

	private void btnProfileRemove_Click(object sender, EventArgs e)
	{
		ArrayList arrayList = new ArrayList();
		if (LstProfile.get_SelectedIndex() != -1 && !Information.IsNothing((object)Module1.SettingObject.Profiles))
		{
			arrayList.AddRange(Module1.SettingObject.Profiles);
			arrayList.RemoveAt(LstProfile.get_SelectedIndex());
			Module1.SettingObject.Profiles = (ProfileClass[])arrayList.ToArray(typeof(ProfileClass));
		}
		LoadProfile();
		InitUI();
	}

	private void InitUI()
	{
		if (LstProfile.get_SelectedIndex() == -1)
		{
			((Control)btnProfileRemove).set_Enabled(false);
			((Control)btnProfileEdit).set_Enabled(false);
			dgvDetail.get_Rows().Clear();
		}
		else
		{
			((Control)btnProfileRemove).set_Enabled(true);
			((Control)btnProfileEdit).set_Enabled(true);
		}
	}

	private void btnProfileAdd_Click(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		ArrayList arrayList = new ArrayList();
		MyProject.Forms.frmProfile.Profile = null;
		((Form)MyProject.Forms.frmProfile).ShowDialog();
		if (!Information.IsNothing((object)MyProject.Forms.frmProfile.Profile))
		{
			if (!Information.IsNothing((object)Module1.SettingObject.Profiles))
			{
				arrayList.AddRange(Module1.SettingObject.Profiles);
			}
			arrayList.Add(MyProject.Forms.frmProfile.Profile);
			Module1.SettingObject.Profiles = (ProfileClass[])arrayList.ToArray(typeof(ProfileClass));
		}
		LoadProfile();
		InitUI();
	}

	private void btnProfileEdit_Click(object sender, EventArgs e)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if (LstProfile.get_SelectedIndex() != -1)
		{
			ProfileClass profile = Module1.SettingObject.Profiles[LstProfile.get_SelectedIndex()];
			MyProject.Forms.frmProfile.Profile = profile;
			((Form)MyProject.Forms.frmProfile).ShowDialog();
			LoadProfile();
			InitUI();
		}
	}

	private void btnCapturePath_Click(object sender, EventArgs e)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		FolderBrowser.set_SelectedPath(txtCapturePath.get_Text());
		FolderBrowser.set_Description("拍照存檔路徑");
		((CommonDialog)FolderBrowser).ShowDialog();
		txtCapturePath.set_Text(FolderBrowser.get_SelectedPath());
	}

	private void btnRecordPath_Click(object sender, EventArgs e)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		FolderBrowser.set_SelectedPath(txtRecordPath.get_Text());
		FolderBrowser.set_Description("遠端錄影路徑");
		((CommonDialog)FolderBrowser).ShowDialog();
		txtRecordPath.set_Text(FolderBrowser.get_SelectedPath());
	}
}
