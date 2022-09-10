using System.Globalization;
using System.Resources;
using System.Threading;

namespace System.Web.RegBrowsers;

internal sealed class SR
{
	internal const string _sep01_ = "_sep01_";

	internal const string Header_text = "Header_text";

	internal const string Copyright = "Copyright";

	internal const string Short_usage_text = "Short_usage_text";

	internal const string Usage = "Usage";

	internal const string Directory_does_not_exist = "Directory_does_not_exist";

	internal const string Directory_has_no_browser_files = "Directory_has_no_browser_files";

	internal const string BrowserAssembly_Not_Installed = "BrowserAssembly_Not_Installed";

	internal const string Uninstallation_failed = "Uninstallation_failed";

	internal const string questionmark_help = "questionmark_help";

	internal const string RegBrowser_install_usage = "RegBrowser_install_usage";

	internal const string RegBrowser_uninstall_usage = "RegBrowser_uninstall_usage";

	internal const string RegBrowser_installed = "RegBrowser_installed";

	internal const string RegBrowser_uninstalled = "RegBrowser_uninstalled";

	private static SR loader;

	private ResourceManager resources;

	private static object s_InternalSyncObject;

	private static object InternalSyncObject
	{
		get
		{
			if (s_InternalSyncObject == null)
			{
				object value = new object();
				Interlocked.CompareExchange(ref s_InternalSyncObject, value, null);
			}
			return s_InternalSyncObject;
		}
	}

	private static CultureInfo Culture => null;

	public static ResourceManager Resources => GetLoader().resources;

	internal SR()
	{
		resources = new ResourceManager("aspnet_regbrowsers", GetType().Assembly);
	}

	private static SR GetLoader()
	{
		if (loader == null)
		{
			lock (InternalSyncObject)
			{
				if (loader == null)
				{
					loader = new SR();
				}
			}
		}
		return loader;
	}

	public static string GetString(string name, params object[] args)
	{
		SR sR = GetLoader();
		if (sR == null)
		{
			return null;
		}
		string @string = sR.resources.GetString(name, Culture);
		if (args != null && args.Length > 0)
		{
			for (int i = 0; i < args.Length; i++)
			{
				if (args[i] is string text && text.Length > 1024)
				{
					args[i] = text.Substring(0, 1021) + "...";
				}
			}
			return string.Format(CultureInfo.CurrentCulture, @string, args);
		}
		return @string;
	}

	public static string GetString(string name)
	{
		return GetLoader()?.resources.GetString(name, Culture);
	}

	public static object GetObject(string name)
	{
		return GetLoader()?.resources.GetObject(name, Culture);
	}
}
