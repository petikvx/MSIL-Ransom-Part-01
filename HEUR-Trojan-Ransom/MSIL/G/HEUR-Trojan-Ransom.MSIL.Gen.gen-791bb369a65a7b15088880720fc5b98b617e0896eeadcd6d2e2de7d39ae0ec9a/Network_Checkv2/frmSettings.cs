using System;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Network_Checkv2.My;

namespace Network_Checkv2;

[DesignerGenerated]
public class frmSettings : Form
{
	private IContainer components;

	private bool bolStarting;

	private int intpTime;

	[field: AccessedThroughProperty("grpBox1")]
	internal virtual GroupBox grpBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual RadioButton RadioButton5
	{
		[CompilerGenerated]
		get
		{
			return _RadioButton5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = RadioButton5_Click;
			RadioButton radioButton = _RadioButton5;
			if (radioButton != null)
			{
				((Control)radioButton).remove_Click(eventHandler);
			}
			_RadioButton5 = value;
			radioButton = _RadioButton5;
			if (radioButton != null)
			{
				((Control)radioButton).add_Click(eventHandler);
			}
		}
	}

	internal virtual RadioButton RadioButton4
	{
		[CompilerGenerated]
		get
		{
			return _RadioButton4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = RadioButton4_Click;
			RadioButton radioButton = _RadioButton4;
			if (radioButton != null)
			{
				((Control)radioButton).remove_Click(eventHandler);
			}
			_RadioButton4 = value;
			radioButton = _RadioButton4;
			if (radioButton != null)
			{
				((Control)radioButton).add_Click(eventHandler);
			}
		}
	}

	internal virtual RadioButton RadioButton3
	{
		[CompilerGenerated]
		get
		{
			return _RadioButton3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = RadioButton3_Click;
			RadioButton radioButton = _RadioButton3;
			if (radioButton != null)
			{
				((Control)radioButton).remove_Click(eventHandler);
			}
			_RadioButton3 = value;
			radioButton = _RadioButton3;
			if (radioButton != null)
			{
				((Control)radioButton).add_Click(eventHandler);
			}
		}
	}

	internal virtual RadioButton RadioButton2
	{
		[CompilerGenerated]
		get
		{
			return _RadioButton2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = RadioButton2_Click;
			RadioButton radioButton = _RadioButton2;
			if (radioButton != null)
			{
				((Control)radioButton).remove_Click(eventHandler);
			}
			_RadioButton2 = value;
			radioButton = _RadioButton2;
			if (radioButton != null)
			{
				((Control)radioButton).add_Click(eventHandler);
			}
		}
	}

	internal virtual RadioButton RadioButton1
	{
		[CompilerGenerated]
		get
		{
			return _RadioButton1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = RadioButton1_Click;
			RadioButton radioButton = _RadioButton1;
			if (radioButton != null)
			{
				((Control)radioButton).remove_Click(eventHandler);
			}
			_RadioButton1 = value;
			radioButton = _RadioButton1;
			if (radioButton != null)
			{
				((Control)radioButton).add_Click(eventHandler);
			}
		}
	}

	internal virtual CheckBox CheckBox1
	{
		[CompilerGenerated]
		get
		{
			return _CheckBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = CheckBox1_CheckedChanged;
			CheckBox checkBox = _CheckBox1;
			if (checkBox != null)
			{
				checkBox.remove_CheckedChanged(eventHandler);
			}
			_CheckBox1 = value;
			checkBox = _CheckBox1;
			if (checkBox != null)
			{
				checkBox.add_CheckedChanged(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("txtPingUrl")]
	internal virtual TextBox txtPingUrl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox txtTimeout
	{
		[CompilerGenerated]
		get
		{
			return _txtTimeout;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = txtTimeout_LostFocus;
			TextBox val = _txtTimeout;
			if (val != null)
			{
				((Control)val).remove_LostFocus(eventHandler);
			}
			_txtTimeout = value;
			val = _txtTimeout;
			if (val != null)
			{
				((Control)val).add_LostFocus(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnCancel
	{
		[CompilerGenerated]
		get
		{
			return _btnCancel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnCancel_Click;
			Button val = _btnCancel;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnCancel = value;
			val = _btnCancel;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button btnOk
	{
		[CompilerGenerated]
		get
		{
			return _btnOk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnOk_Click;
			Button val = _btnOk;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnOk = value;
			val = _btnOk;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("txtDDNS_URL")]
	internal virtual TextBox txtDDNS_URL
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public frmSettings()
	{
		((Form)this).add_Deactivate((EventHandler)frmSettings_Deactivate);
		((Form)this).add_Load((EventHandler)frmSettings_Load);
		bolStarting = true;
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
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		grpBox1 = new GroupBox();
		txtDDNS_URL = new TextBox();
		Label4 = new Label();
		GroupBox1 = new GroupBox();
		RadioButton5 = new RadioButton();
		RadioButton4 = new RadioButton();
		RadioButton3 = new RadioButton();
		RadioButton2 = new RadioButton();
		RadioButton1 = new RadioButton();
		CheckBox1 = new CheckBox();
		txtPingUrl = new TextBox();
		txtTimeout = new TextBox();
		Label3 = new Label();
		Label2 = new Label();
		Label1 = new Label();
		btnCancel = new Button();
		btnOk = new Button();
		((Control)grpBox1).SuspendLayout();
		((Control)GroupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)grpBox1).get_Controls().Add((Control)(object)txtDDNS_URL);
		((Control)grpBox1).get_Controls().Add((Control)(object)Label4);
		((Control)grpBox1).get_Controls().Add((Control)(object)GroupBox1);
		((Control)grpBox1).get_Controls().Add((Control)(object)CheckBox1);
		((Control)grpBox1).get_Controls().Add((Control)(object)txtPingUrl);
		((Control)grpBox1).get_Controls().Add((Control)(object)txtTimeout);
		((Control)grpBox1).get_Controls().Add((Control)(object)Label3);
		((Control)grpBox1).get_Controls().Add((Control)(object)Label2);
		((Control)grpBox1).get_Controls().Add((Control)(object)Label1);
		((Control)grpBox1).set_Location(new Point(15, 12));
		((Control)grpBox1).set_Name("grpBox1");
		((Control)grpBox1).set_Size(new Size(224, 408));
		((Control)grpBox1).set_TabIndex(5);
		grpBox1.set_TabStop(false);
		grpBox1.set_Text("Common Settings");
		((Control)txtDDNS_URL).set_Enabled(false);
		((Control)txtDDNS_URL).set_Location(new Point(77, 107));
		((Control)txtDDNS_URL).set_Name("txtDDNS_URL");
		((Control)txtDDNS_URL).set_Size(new Size(128, 20));
		((Control)txtDDNS_URL).set_TabIndex(12);
		Label4.set_AutoSize(true);
		((Control)Label4).set_Location(new Point(17, 110));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(54, 13));
		((Control)Label4).set_TabIndex(11);
		Label4.set_Text("DDNS Url");
		((Control)GroupBox1).get_Controls().Add((Control)(object)RadioButton5);
		((Control)GroupBox1).get_Controls().Add((Control)(object)RadioButton4);
		((Control)GroupBox1).get_Controls().Add((Control)(object)RadioButton3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)RadioButton2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)RadioButton1);
		((Control)GroupBox1).set_Location(new Point(12, 198));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Size(new Size(200, 194));
		((Control)GroupBox1).set_TabIndex(10);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("Url Address Timeout");
		RadioButton5.set_AutoCheck(false);
		((ButtonBase)RadioButton5).set_AutoSize(true);
		((Control)RadioButton5).set_Location(new Point(16, 162));
		((Control)RadioButton5).set_Name("RadioButton5");
		((Control)RadioButton5).set_Size(new Size(111, 17));
		((Control)RadioButton5).set_TabIndex(14);
		((ButtonBase)RadioButton5).set_Text("5m/s Testing Only");
		((ButtonBase)RadioButton5).set_UseVisualStyleBackColor(true);
		RadioButton4.set_AutoCheck(false);
		((ButtonBase)RadioButton4).set_AutoSize(true);
		((Control)RadioButton4).set_Location(new Point(16, 129));
		((Control)RadioButton4).set_Name("RadioButton4");
		((Control)RadioButton4).set_Size(new Size(82, 17));
		((Control)RadioButton4).set_TabIndex(13);
		((ButtonBase)RadioButton4).set_Text("10 Seconds");
		((ButtonBase)RadioButton4).set_UseVisualStyleBackColor(true);
		RadioButton3.set_AutoCheck(false);
		((ButtonBase)RadioButton3).set_AutoSize(true);
		((Control)RadioButton3).set_Location(new Point(16, 96));
		((Control)RadioButton3).set_Name("RadioButton3");
		((Control)RadioButton3).set_Size(new Size(76, 17));
		((Control)RadioButton3).set_TabIndex(12);
		((ButtonBase)RadioButton3).set_Text("4 Seconds");
		((ButtonBase)RadioButton3).set_UseVisualStyleBackColor(true);
		RadioButton2.set_AutoCheck(false);
		((ButtonBase)RadioButton2).set_AutoSize(true);
		((Control)RadioButton2).set_Location(new Point(16, 62));
		((Control)RadioButton2).set_Name("RadioButton2");
		((Control)RadioButton2).set_Size(new Size(76, 17));
		((Control)RadioButton2).set_TabIndex(11);
		((ButtonBase)RadioButton2).set_Text("2 Seconds");
		((ButtonBase)RadioButton2).set_UseVisualStyleBackColor(true);
		RadioButton1.set_AutoCheck(false);
		((ButtonBase)RadioButton1).set_AutoSize(true);
		((Control)RadioButton1).set_Location(new Point(16, 30));
		((Control)RadioButton1).set_Name("RadioButton1");
		((Control)RadioButton1).set_Size(new Size(71, 17));
		((Control)RadioButton1).set_TabIndex(10);
		((ButtonBase)RadioButton1).set_Text("1 Second");
		((ButtonBase)RadioButton1).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox1).set_AutoSize(true);
		((Control)CheckBox1).set_Location(new Point(113, 148));
		((Control)CheckBox1).set_Name("CheckBox1");
		((Control)CheckBox1).set_Size(new Size(15, 14));
		((Control)CheckBox1).set_TabIndex(5);
		((ButtonBase)CheckBox1).set_UseVisualStyleBackColor(true);
		((Control)txtPingUrl).set_Location(new Point(113, 68));
		((Control)txtPingUrl).set_Name("txtPingUrl");
		((Control)txtPingUrl).set_Size(new Size(92, 20));
		((Control)txtPingUrl).set_TabIndex(4);
		((Control)txtTimeout).set_Location(new Point(113, 37));
		((Control)txtTimeout).set_Name("txtTimeout");
		((Control)txtTimeout).set_Size(new Size(65, 20));
		((Control)txtTimeout).set_TabIndex(3);
		Label3.set_AutoSize(true);
		((Control)Label3).set_Location(new Point(17, 148));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(87, 13));
		((Control)Label3).set_TabIndex(2);
		Label3.set_Text("Logging Enabled");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Location(new Point(17, 72));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(44, 13));
		((Control)Label2).set_TabIndex(1);
		Label2.set_Text("Ping Url");
		Label1.set_AutoSize(true);
		((Control)Label1).set_Location(new Point(17, 40));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(90, 13));
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("Ping Timeout m/s");
		((Control)btnCancel).set_Location(new Point(15, 439));
		((Control)btnCancel).set_Name("btnCancel");
		((Control)btnCancel).set_Size(new Size(75, 23));
		((Control)btnCancel).set_TabIndex(4);
		((ButtonBase)btnCancel).set_Text("&Cancel");
		((ButtonBase)btnCancel).set_UseVisualStyleBackColor(true);
		((Control)btnOk).set_Location(new Point(164, 439));
		((Control)btnOk).set_Name("btnOk");
		((Control)btnOk).set_Size(new Size(75, 23));
		((Control)btnOk).set_TabIndex(3);
		((ButtonBase)btnOk).set_Text("&Ok");
		((ButtonBase)btnOk).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(254, 484));
		((Control)this).get_Controls().Add((Control)(object)grpBox1);
		((Control)this).get_Controls().Add((Control)(object)btnCancel);
		((Control)this).get_Controls().Add((Control)(object)btnOk);
		((Control)this).set_Name("frmSettings");
		((Form)this).set_Text("frmSettings");
		((Control)grpBox1).ResumeLayout(false);
		((Control)grpBox1).PerformLayout();
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void frmSettings_Deactivate(object sender, EventArgs e)
	{
		Out_Data();
		((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
	}

	private void Out_Data()
	{
		string text = txtPingUrl.get_Text();
		int num = checked((int)Math.Round((double)ModBase.intTimeout / 1000.0));
		if (ModBase.intTimeout == 5)
		{
			num = 5;
		}
		if (CheckBox1.get_Checked())
		{
			bool flag = true;
		}
		else if (!CheckBox1.get_Checked())
		{
			bool flag = false;
		}
	}

	private void frmSettings_Load(object sender, EventArgs e)
	{
		intpTime = MySettingsProperty.Settings.pingTimeout;
		txtTimeout.set_Text(Conversions.ToString(intpTime));
		txtPingUrl.set_Text(MySettingsProperty.Settings.pingURL);
		if (intpTime == 1000)
		{
			RadioButton1.set_Checked(true);
		}
		else if (intpTime == 2000)
		{
			RadioButton2.set_Checked(true);
		}
		else if (intpTime == 4000)
		{
			RadioButton3.set_Checked(true);
		}
		else if (intpTime == 10000)
		{
			RadioButton4.set_Checked(true);
		}
		else if (intpTime == 5)
		{
			RadioButton5.set_Checked(true);
		}
		if (MySettingsProperty.Settings.logEventsEnabled)
		{
			CheckBox1.set_Checked(true);
		}
		else
		{
			CheckBox1.set_Checked(false);
		}
		txtDDNS_URL.set_Text(MySettingsProperty.Settings.ddns_URL);
	}

	private void btnOk_Click(object sender, EventArgs e)
	{
		Check_Timeout();
		MySettingsProperty.Settings.pingURL = txtPingUrl.get_Text();
		MySettingsProperty.Settings.logEventsEnabled = CheckBox1.get_Checked();
		((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
		Out_Data();
		((Form)this).Close();
	}

	private void txtTimeout_LostFocus(object sender, EventArgs e)
	{
		Check_Timeout();
		((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
	}

	private void Check_Timeout()
	{
		if ((Conversion.Val(txtTimeout.get_Text()) >= 5.0) & (Conversion.Val(txtTimeout.get_Text()) < 100001.0))
		{
			MySettingsProperty.Settings.pingTimeout = checked((int)Math.Round(Conversion.Val(txtTimeout.get_Text())));
			((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
			ModBase.intTimeout = MySettingsProperty.Settings.pingTimeout;
		}
		else
		{
			txtTimeout.set_Text("2000");
		}
	}

	private void CheckBox1_CheckedChanged(object sender, EventArgs e)
	{
		if (!CheckBox1.get_Checked())
		{
			MySettingsProperty.Settings.logEventsEnabled = false;
			MyProject.Forms.Form1.LoggingOnToolStripMenuItem.set_Checked(false);
		}
		else
		{
			MySettingsProperty.Settings.logEventsEnabled = true;
			MyProject.Forms.Form1.LoggingOnToolStripMenuItem.set_Checked(true);
		}
		MyProject.Forms.Form1.Logging_Select(MySettingsProperty.Settings.logEventsEnabled);
		((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
	}

	private void RadioButton1_Click(object sender, EventArgs e)
	{
		ModBase.intTimeout = 1000;
		RadioButton1.set_Checked(true);
		RadioButton2.set_Checked(false);
		RadioButton3.set_Checked(false);
		RadioButton4.set_Checked(false);
		RadioButton5.set_Checked(false);
		txtTimeout.set_Text(Conversions.ToString(ModBase.intTimeout));
		if (ModBase.intTimeout != intpTime)
		{
			Write_Time_Change(1000);
		}
	}

	private void RadioButton2_Click(object sender, EventArgs e)
	{
		ModBase.intTimeout = 2000;
		RadioButton2.set_Checked(true);
		RadioButton1.set_Checked(false);
		RadioButton3.set_Checked(false);
		RadioButton4.set_Checked(false);
		RadioButton5.set_Checked(false);
		txtTimeout.set_Text(Conversions.ToString(ModBase.intTimeout));
		if (ModBase.intTimeout != intpTime)
		{
			Write_Time_Change(2000);
		}
	}

	private void RadioButton3_Click(object sender, EventArgs e)
	{
		ModBase.intTimeout = 4000;
		RadioButton3.set_Checked(true);
		RadioButton1.set_Checked(false);
		RadioButton2.set_Checked(false);
		RadioButton4.set_Checked(false);
		RadioButton5.set_Checked(false);
		txtTimeout.set_Text(Conversions.ToString(ModBase.intTimeout));
		if (ModBase.intTimeout != intpTime)
		{
			Write_Time_Change(4000);
		}
	}

	private void RadioButton4_Click(object sender, EventArgs e)
	{
		ModBase.intTimeout = 10000;
		txtTimeout.set_Text(Conversions.ToString(ModBase.intTimeout));
		RadioButton4.set_Checked(true);
		RadioButton1.set_Checked(false);
		RadioButton2.set_Checked(false);
		RadioButton3.set_Checked(false);
		RadioButton5.set_Checked(false);
		if (ModBase.intTimeout != intpTime)
		{
			Write_Time_Change(10000);
		}
	}

	private void RadioButton5_Click(object sender, EventArgs e)
	{
		ModBase.intTimeout = 5;
		txtTimeout.set_Text(Conversions.ToString(ModBase.intTimeout));
		RadioButton4.set_Checked(false);
		RadioButton1.set_Checked(false);
		RadioButton2.set_Checked(false);
		RadioButton3.set_Checked(false);
		RadioButton5.set_Checked(true);
		if (ModBase.intTimeout != intpTime)
		{
			Write_Time_Change(5);
		}
	}

	private void Write_Time_Change(int num)
	{
		string text = " Sec(s)";
		if (num == 5)
		{
			text = " mSecs for Testing";
		}
		ModBase.Write_ToFile("Network Timeout changed to " + Conversions.ToString(num) + text);
		MySettingsProperty.Settings.pingTimeout = num;
		txtTimeout.set_Text(Conversions.ToString(num));
		((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
