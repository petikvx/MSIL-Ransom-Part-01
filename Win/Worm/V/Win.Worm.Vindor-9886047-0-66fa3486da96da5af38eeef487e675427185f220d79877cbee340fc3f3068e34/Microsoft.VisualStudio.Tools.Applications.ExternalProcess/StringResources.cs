using System.Globalization;
using System.Resources;
using System.Threading;

namespace Microsoft.VisualStudio.Tools.Applications.ExternalProcess;

internal sealed class StringResources
{
	internal const string ErrorCaption = "ErrorCaption";

	internal const string ErrorString = "ErrorString";

	private static StringResources loader;

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

	internal StringResources()
	{
		resources = new ResourceManager("strings", GetType().Assembly);
	}

	private static StringResources GetLoader()
	{
		if (loader == null)
		{
			lock (InternalSyncObject)
			{
				if (loader == null)
				{
					loader = new StringResources();
				}
			}
		}
		return loader;
	}

	public static string GetString(string name, params object[] args)
	{
		StringResources stringResources = GetLoader();
		if (stringResources == null)
		{
			return null;
		}
		string @string = stringResources.resources.GetString(name, Culture);
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
