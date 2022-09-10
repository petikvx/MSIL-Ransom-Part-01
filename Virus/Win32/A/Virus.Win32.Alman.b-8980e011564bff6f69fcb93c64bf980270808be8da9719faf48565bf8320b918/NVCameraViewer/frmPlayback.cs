using System;
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
public class frmPlayback : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("dtpTime")]
	private DateTimePicker _dtpTime;

	[AccessedThroughProperty("dtpDate")]
	private DateTimePicker _dtpDate;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("radioCamera")]
	private RadioButton _radioCamera;

	[AccessedThroughProperty("radioSplit")]
	private RadioButton _radioSplit;

	[AccessedThroughProperty("btnClose")]
	private Button _btnClose;

	[AccessedThroughProperty("btnConfirm")]
	private Button _btnConfirm;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("cboDetail")]
	private ComboBox _cboDetail;

	[AccessedThroughProperty("CameraControl1")]
	private CameraControl _CameraControl1;

	public ProfileClass Profile;

	public bool IsPlaybackSplit;

	public bool ForceInSplitMode;

	public DateTime PlaybackDate;

	internal virtual DateTimePicker dtpTime
	{
		[DebuggerNonUserCode]
		get
		{
			return _dtpTime;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dtpTime = value;
		}
	}

	internal virtual DateTimePicker dtpDate
	{
		[DebuggerNonUserCode]
		get
		{
			return _dtpDate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dtpDate = value;
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

	internal virtual RadioButton radioCamera
	{
		[DebuggerNonUserCode]
		get
		{
			return _radioCamera;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_radioCamera = value;
		}
	}

	internal virtual RadioButton radioSplit
	{
		[DebuggerNonUserCode]
		get
		{
			return _radioSplit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_radioSplit = value;
		}
	}

	internal virtual Button btnClose
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnClose;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnClose_Click;
			if (_btnClose != null)
			{
				((Control)_btnClose).remove_Click(eventHandler);
			}
			_btnClose = value;
			if (_btnClose != null)
			{
				((Control)_btnClose).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button btnConfirm
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnConfirm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnConfirm_Click;
			if (_btnConfirm != null)
			{
				((Control)_btnConfirm).remove_Click(eventHandler);
			}
			_btnConfirm = value;
			if (_btnConfirm != null)
			{
				((Control)_btnConfirm).add_Click(eventHandler);
			}
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

	internal virtual ComboBox cboDetail
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboDetail;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cboDetail_Click;
			if (_cboDetail != null)
			{
				((Control)_cboDetail).remove_Click(eventHandler);
			}
			_cboDetail = value;
			if (_cboDetail != null)
			{
				((Control)_cboDetail).add_Click(eventHandler);
			}
		}
	}

	internal virtual CameraControl CameraControl1
	{
		[DebuggerNonUserCode]
		get
		{
			return _CameraControl1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CameraControl1 = value;
		}
	}

	public frmPlayback()
	{
		((Form)this).add_Load((EventHandler)frmPlayback_Load);
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		IsPlaybackSplit = false;
		ForceInSplitMode = false;
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
		dtpTime = new DateTimePicker();
		dtpDate = new DateTimePicker();
		Label1 = new Label();
		GroupBox1 = new GroupBox();
		cboDetail = new ComboBox();
		btnClose = new Button();
		btnConfirm = new Button();
		radioCamera = new RadioButton();
		radioSplit = new RadioButton();
		Panel1 = new Panel();
		Panel2 = new Panel();
		CameraControl1 = new CameraControl();
		((Control)GroupBox1).SuspendLayout();
		((Control)Panel1).SuspendLayout();
		((Control)Panel2).SuspendLayout();
		((Control)this).SuspendLayout();
		dtpTime.set_Format((DateTimePickerFormat)4);
		DateTimePicker obj = dtpTime;
		Point location = new Point(274, 26);
		((Control)obj).set_Location(location);
		((Control)dtpTime).set_Name("dtpTime");
		dtpTime.set_ShowUpDown(true);
		DateTimePicker obj2 = dtpTime;
		Size size = new Size(103, 22);
		((Control)obj2).set_Size(size);
		((Control)dtpTime).set_TabIndex(0);
		dtpDate.set_Format((DateTimePickerFormat)2);
		DateTimePicker obj3 = dtpDate;
		location = new Point(68, 26);
		((Control)obj3).set_Location(location);
		((Control)dtpDate).set_Name("dtpDate");
		DateTimePicker obj4 = dtpDate;
		size = new Size(200, 22);
		((Control)obj4).set_Size(size);
		((Control)dtpDate).set_TabIndex(1);
		Label1.set_AutoSize(true);
		Label label = Label1;
		location = new Point(6, 31);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(56, 12);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(2);
		Label1.set_Text("回放時間:");
		((Control)GroupBox1).get_Controls().Add((Control)(object)cboDetail);
		((Control)GroupBox1).get_Controls().Add((Control)(object)btnClose);
		((Control)GroupBox1).get_Controls().Add((Control)(object)btnConfirm);
		((Control)GroupBox1).get_Controls().Add((Control)(object)radioCamera);
		((Control)GroupBox1).get_Controls().Add((Control)(object)radioSplit);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)dtpTime);
		((Control)GroupBox1).get_Controls().Add((Control)(object)dtpDate);
		((Control)GroupBox1).set_Dock((DockStyle)5);
		GroupBox groupBox = GroupBox1;
		location = new Point(0, 0);
		((Control)groupBox).set_Location(location);
		((Control)GroupBox1).set_Name("GroupBox1");
		GroupBox groupBox2 = GroupBox1;
		size = new Size(532, 130);
		((Control)groupBox2).set_Size(size);
		((Control)GroupBox1).set_TabIndex(3);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("回放設定");
		cboDetail.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)cboDetail).set_FormattingEnabled(true);
		ComboBox obj5 = cboDetail;
		location = new Point(109, 95);
		((Control)obj5).set_Location(location);
		((Control)cboDetail).set_Name("cboDetail");
		ComboBox obj6 = cboDetail;
		size = new Size(220, 20);
		((Control)obj6).set_Size(size);
		((Control)cboDetail).set_TabIndex(7);
		Button obj7 = btnClose;
		location = new Point(445, 96);
		((Control)obj7).set_Location(location);
		((Control)btnClose).set_Name("btnClose");
		Button obj8 = btnClose;
		size = new Size(75, 23);
		((Control)obj8).set_Size(size);
		((Control)btnClose).set_TabIndex(6);
		((ButtonBase)btnClose).set_Text("關閉");
		((ButtonBase)btnClose).set_UseVisualStyleBackColor(true);
		Button obj9 = btnConfirm;
		location = new Point(355, 96);
		((Control)obj9).set_Location(location);
		((Control)btnConfirm).set_Name("btnConfirm");
		Button obj10 = btnConfirm;
		size = new Size(75, 23);
		((Control)obj10).set_Size(size);
		((Control)btnConfirm).set_TabIndex(5);
		((ButtonBase)btnConfirm).set_Text("播放");
		((ButtonBase)btnConfirm).set_UseVisualStyleBackColor(true);
		((ButtonBase)radioCamera).set_AutoSize(true);
		RadioButton obj11 = radioCamera;
		location = new Point(8, 99);
		((Control)obj11).set_Location(location);
		((Control)radioCamera).set_Name("radioCamera");
		RadioButton obj12 = radioCamera;
		size = new Size(95, 16);
		((Control)obj12).set_Size(size);
		((Control)radioCamera).set_TabIndex(4);
		((ButtonBase)radioCamera).set_Text("指定鏡頭播放");
		((ButtonBase)radioCamera).set_UseVisualStyleBackColor(true);
		((ButtonBase)radioSplit).set_AutoSize(true);
		radioSplit.set_Checked(true);
		RadioButton obj13 = radioSplit;
		location = new Point(8, 65);
		((Control)obj13).set_Location(location);
		((Control)radioSplit).set_Name("radioSplit");
		RadioButton obj14 = radioSplit;
		size = new Size(95, 16);
		((Control)obj14).set_Size(size);
		((Control)radioSplit).set_TabIndex(3);
		radioSplit.set_TabStop(true);
		((ButtonBase)radioSplit).set_Text("播放目前分割");
		((ButtonBase)radioSplit).set_UseVisualStyleBackColor(true);
		((Control)Panel1).get_Controls().Add((Control)(object)GroupBox1);
		((Control)Panel1).set_Dock((DockStyle)1);
		Panel panel = Panel1;
		location = new Point(0, 0);
		((Control)panel).set_Location(location);
		((Control)Panel1).set_Name("Panel1");
		Panel panel2 = Panel1;
		size = new Size(532, 130);
		((Control)panel2).set_Size(size);
		((Control)Panel1).set_TabIndex(4);
		((Control)Panel2).get_Controls().Add((Control)(object)CameraControl1);
		((Control)Panel2).set_Dock((DockStyle)5);
		Panel panel3 = Panel2;
		location = new Point(0, 130);
		((Control)panel3).set_Location(location);
		((Control)Panel2).set_Name("Panel2");
		Panel panel4 = Panel2;
		size = new Size(532, 390);
		((Control)panel4).set_Size(size);
		((Control)Panel2).set_TabIndex(5);
		CameraControl1.set_ChannelID(1);
		CameraControl1.set_CompressLevel((enumCompressLevel)0);
		CameraControl1.set_DisplayName("");
		CameraControl1.set_DisplayType((enumDisplayType)2);
		((Control)CameraControl1).set_Dock((DockStyle)5);
		CameraControl cameraControl = CameraControl1;
		location = new Point(0, 0);
		((Control)cameraControl).set_Location(location);
		((Control)CameraControl1).set_Name("CameraControl1");
		CameraControl1.set_PackageType((enumPackageType)0);
		CameraControl1.set_RemoteIP("127.0.0.1");
		CameraControl1.set_RemotePort(20900);
		CameraControl1.set_ShowArchiveButton(false);
		CameraControl cameraControl2 = CameraControl1;
		size = new Size(532, 390);
		((Control)cameraControl2).set_Size(size);
		((Control)CameraControl1).set_TabIndex(0);
		SizeF autoScaleDimensions = new SizeF(6f, 12f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(532, 520);
		((Form)this).set_ClientSize(size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)Panel2);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Control)this).set_Name("frmPlayback");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("frmPlayback");
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel2).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void btnClose_Click(object sender, EventArgs e)
	{
		CameraControl1.Close();
		((Form)this).Close();
	}

	private void frmPlayback_Load(object sender, EventArgs e)
	{
		((Control)Panel2).set_Visible(false);
		((Control)this).set_Height(165);
		cboDetail.get_Items().Clear();
		if (!Information.IsNothing((object)Profile) && !Information.IsNothing((object)Profile.CameraList))
		{
			ProfileCameraItemClass[] cameraList = Profile.CameraList;
			foreach (ProfileCameraItemClass profileCameraItemClass in cameraList)
			{
				cboDetail.get_Items().Add((object)(profileCameraItemClass.CameraName + " (" + profileCameraItemClass.CameraIP + " [" + Conversions.ToString(profileCameraItemClass.CameraID) + "])"));
			}
		}
		if (ForceInSplitMode)
		{
			((Control)radioCamera).set_Enabled(false);
			((Control)radioSplit).set_Enabled(false);
			((Control)cboDetail).set_Enabled(false);
			radioSplit.set_Checked(true);
		}
		else
		{
			((Control)radioCamera).set_Enabled(true);
			((Control)radioSplit).set_Enabled(true);
			((Control)cboDetail).set_Enabled(true);
		}
	}

	private void btnConfirm_Click(object sender, EventArgs e)
	{
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Invalid comparison between Unknown and I4
		bool flag = false;
		ref DateTime playbackDate = ref PlaybackDate;
		playbackDate = new DateTime(dtpDate.get_Value().Year, dtpDate.get_Value().Month, dtpDate.get_Value().Day, dtpTime.get_Value().Hour, dtpTime.get_Value().Minute, dtpTime.get_Value().Second);
		if (DateTime.Compare(PlaybackDate, DateAndTime.get_Now()) > 0)
		{
			if ((int)MessageBox.Show("指定的時間比目前的時間要晚, 您確定要嘗試撥放這個時間的紀錄嗎?", "播放時間警告", (MessageBoxButtons)4) == 6)
			{
				flag = true;
			}
		}
		else
		{
			flag = true;
		}
		if (!flag)
		{
			return;
		}
		if (radioSplit.get_Checked())
		{
			CameraControl1.Close();
			IsPlaybackSplit = true;
			((Form)this).Close();
		}
		else if (radioCamera.get_Checked() && cboDetail.get_SelectedIndex() != -1)
		{
			if (!((Control)Panel2).get_Visible())
			{
				((Control)this).set_Height(550);
				((Control)Panel2).set_Visible(true);
			}
			ProfileCameraItemClass profileCameraItemClass = Profile.CameraList[cboDetail.get_SelectedIndex()];
			if (CameraControl1.get_IsConnect())
			{
				CameraControl1.Close();
			}
			CameraControl1.set_DisplayName(profileCameraItemClass.CameraName);
			CameraControl1.set_RemoteIP(profileCameraItemClass.CameraIP);
			CameraControl1.set_RemotePort(profileCameraItemClass.CameraPort);
			CameraControl1.set_ChannelID(profileCameraItemClass.CameraID);
			CameraControl1.set_ShowArchiveButton(true);
			CameraControl1.PlayArchive(PlaybackDate);
		}
	}

	private void cboDetail_Click(object sender, EventArgs e)
	{
		radioCamera.set_Checked(true);
	}
}
