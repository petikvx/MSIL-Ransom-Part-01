using System.Globalization;
using System.Resources;
using System.Threading;

namespace Microsoft.XslDebugger;

internal sealed class SR
{
	internal const string RTL = "RTL";

	internal const string RuntimeError = "RuntimeError";

	internal const string XslRootNodeValue = "XslRootNodeValue";

	internal const string XsltCompileError = "XsltCompileError";

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
		resources = new ResourceManager("Microsoft.XslDebugProxy", GetType().Assembly);
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
			return string.Format(CultureInfo.CurrentUICulture, @string, args);
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
