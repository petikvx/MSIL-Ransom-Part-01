using System.Globalization;
using System.Resources;
using System.Threading;

namespace System.Configuration.InstallUtilResources;

internal sealed class Res
{
	internal const string InstallUtilSignOnMessage = "InstallUtilSignOnMessage";

	private static Res loader;

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

	internal Res()
	{
		resources = new ResourceManager("InstallUtil", GetType().Assembly);
	}

	private static Res GetLoader()
	{
		if (loader == null)
		{
			lock (InternalSyncObject)
			{
				if (loader == null)
				{
					loader = new Res();
				}
			}
		}
		return loader;
	}

	public static string GetString(string name, params object[] args)
	{
		Res res = GetLoader();
		if (res == null)
		{
			return null;
		}
		string @string = res.resources.GetString(name, Culture);
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
