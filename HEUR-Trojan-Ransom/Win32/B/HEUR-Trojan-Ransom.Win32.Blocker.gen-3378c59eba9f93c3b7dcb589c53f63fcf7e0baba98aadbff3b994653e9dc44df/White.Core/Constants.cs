using White.Core.Configuration;

namespace White.Core;

public static class Constants
{
	public const string WPFFrameworkId = "WPF";

	public const string WinFormFrameworkId = "WinForm";

	public const string Win32FrameworkId = "Win32";

	public const string MissingFrameworkId = "";

	public const string SWT = "SWT";

	public const string SilverlightFrameworkId = "Silverlight";

	public static string BusyMessage => $", after waiting for {CoreAppXmlConfiguration.Instance.BusyTimeout} ms";
}
