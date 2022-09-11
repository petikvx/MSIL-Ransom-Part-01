using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using White.Core.Configuration;
using White.Core.Factory;
using White.Core.Sessions;
using White.Core.UIItems.Finders;
using White.Core.UIItems.WindowItems;
using log4net;

namespace White.Core;

public class Application : IDisposable
{
	private readonly Process process;

	private readonly ApplicationSession applicationSession;

	private readonly WindowFactory windowFactory;

	private static readonly ILog Logger = LogManager.GetLogger(typeof(Application));

	public virtual string Name => process.ProcessName;

	public virtual ApplicationSession ApplicationSession => applicationSession;

	public virtual bool HasExited => process.HasExited;

	public virtual Process Process => process;

	protected Application()
	{
	}

	private Application(Process process)
	{
		this.process = process;
		applicationSession = new ApplicationSession();
		applicationSession.Register(this);
		windowFactory = WindowFactory.Desktop;
	}

	public static Application Launch(string executable)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo(executable);
		return Launch(processStartInfo);
	}

	public static Application Launch(ProcessStartInfo processStartInfo)
	{
		if (string.IsNullOrEmpty(processStartInfo.WorkingDirectory))
		{
			processStartInfo.WorkingDirectory = ".";
		}
		Logger.DebugFormat("[Launching process:{0}] [Working directory:{1}] [Process full path:{2}] [Current Directory:{3}]", new object[4]
		{
			processStartInfo.FileName,
			new DirectoryInfo(processStartInfo.WorkingDirectory).FullName,
			new FileInfo(processStartInfo.FileName).FullName,
			Environment.CurrentDirectory
		});
		Process process = Process.Start(processStartInfo);
		if (ConfigurationManager.get_AppSettings()["CaptureAUTOutput"] != null && process != null)
		{
			string text = process.StandardOutput.ReadToEnd();
			string text2 = process.StandardError.ReadToEnd();
			Logger.DebugFormat("[TestProcessOutput:{0}]", (object)text);
			Logger.DebugFormat("[TestProcessError:{0}]", (object)text2);
		}
		return Attach(process);
	}

	public static Application Attach(int processId)
	{
		Process processById = Process.GetProcessById(processId);
		if (processById == null)
		{
			throw new WhiteException("Could not find process with id: " + processId);
		}
		return new Application(processById);
	}

	public static Application Attach(Process process)
	{
		return new Application(process);
	}

	public static Application Attach(string executable)
	{
		Process[] processesByName = Process.GetProcessesByName(executable);
		if (processesByName.Length == 0)
		{
			throw new WhiteException("Could not find process named: " + executable);
		}
		return Attach(processesByName[0]);
	}

	public static Application AttachOrLaunch(ProcessStartInfo processStartInfo)
	{
		string path = ReplaceLast(processStartInfo.FileName, ".exe", string.Empty);
		path = Path.GetFileName(path);
		Process[] processesByName = Process.GetProcessesByName(path);
		if (processesByName.Length == 0)
		{
			return Launch(processStartInfo);
		}
		return Attach(processesByName[0]);
	}

	private static string ReplaceLast(string replaceIn, string replace, string with)
	{
		int num = replaceIn.LastIndexOf(replace);
		if (num == -1)
		{
			return replaceIn;
		}
		return replaceIn.Substring(0, num) + with + replaceIn.Substring(num + replace.Length);
	}

	public virtual Window GetWindow(string title, InitializeOption option)
	{
		WindowSession windowSession = applicationSession.WindowSession(option);
		return windowFactory.CreateWindow(title, process, option, windowSession);
	}

	public virtual Window GetWindow(string title)
	{
		return GetWindow(title, InitializeOption.NoCache);
	}

	public virtual Window GetWindow(SearchCriteria searchCriteria, InitializeOption initializeOption)
	{
		WindowSession windowSession = applicationSession.WindowSession(initializeOption);
		return windowFactory.CreateWindow(searchCriteria, process, initializeOption, windowSession);
	}

	public virtual void Close()
	{
		Logger.Info((object)"Closing Application");
		if (Process.HasExited)
		{
			Logger.Warn((object)"Application has already exited (crashed?)");
			Process.Dispose();
			return;
		}
		Process.CloseMainWindow();
		Process.WaitForExit(5000);
		if (!Process.HasExited)
		{
			Logger.Info((object)"Application Failed to exit, killing process");
			Process.Kill();
		}
		Process.Dispose();
	}

	public virtual void Kill()
	{
		try
		{
			process.Kill();
			process.WaitForExit();
		}
		catch
		{
		}
	}

	public virtual List<Window> GetWindows()
	{
		return windowFactory.DesktopWindows(process, new NoApplicationSession());
	}

	public override bool Equals(object obj)
	{
		if (this == obj)
		{
			return true;
		}
		if (!(obj is Application application))
		{
			return false;
		}
		return object.Equals(process, application.process);
	}

	public override int GetHashCode()
	{
		return process.GetHashCode();
	}

	public virtual void Dispose()
	{
		Kill();
	}

	public virtual Window FindSplash()
	{
		return windowFactory.SplashWindow(process);
	}

	public virtual void WaitWhileBusy()
	{
		process.WaitForInputIdle(CoreAppXmlConfiguration.Instance.BusyTimeout);
	}

	public virtual Window Find(Predicate<string> match, InitializeOption initializeOption)
	{
		WindowSession windowSession = applicationSession.WindowSession(initializeOption);
		return windowFactory.FindWindow(process, match, initializeOption, windowSession);
	}

	public virtual void KillAndSaveState()
	{
		Kill();
		ApplicationSession.Save();
	}
}
