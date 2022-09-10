using System.Globalization;
using System.Resources;

namespace System.Configuration.InstallUtilResources;

internal sealed class Res
{
	internal const string InstallUtilSignOnMessage = "InstallUtilSignOnMessage";

	private static Res loader = null;

	private ResourceManager resources;

	private Res()
	{
		resources = new ResourceManager("InstallUtil", GetType().Module.Assembly);
	}

	private static Res GetLoader()
	{
		if (loader == null)
		{
			lock (typeof(Res))
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
		return GetString(null, name, args);
	}

	public static string GetString(CultureInfo culture, string name, params object[] args)
	{
		Res res = GetLoader();
		if (res == null)
		{
			return null;
		}
		string @string = res.resources.GetString(name, culture);
		if (args != null && args.Length > 0)
		{
			return string.Format(@string, args);
		}
		return @string;
	}

	public static string GetString(string name)
	{
		return GetString(null, name);
	}

	public static string GetString(CultureInfo culture, string name)
	{
		return GetLoader()?.resources.GetString(name, culture);
	}

	public static bool GetBoolean(string name)
	{
		return GetBoolean(name);
	}

	public static bool GetBoolean(CultureInfo culture, string name)
	{
		bool result = false;
		Res res = GetLoader();
		if (res != null)
		{
			object @object = res.resources.GetObject(name, culture);
			if (@object is bool)
			{
				result = (bool)@object;
			}
		}
		return result;
	}

	public static char GetChar(string name)
	{
		return GetChar(null, name);
	}

	public static char GetChar(CultureInfo culture, string name)
	{
		char result = '\0';
		Res res = GetLoader();
		if (res != null)
		{
			object @object = res.resources.GetObject(name, culture);
			if (@object is char)
			{
				result = (char)@object;
			}
		}
		return result;
	}

	public static byte GetByte(string name)
	{
		return GetByte(null, name);
	}

	public static byte GetByte(CultureInfo culture, string name)
	{
		byte result = 0;
		Res res = GetLoader();
		if (res != null)
		{
			object @object = res.resources.GetObject(name, culture);
			if (@object is byte)
			{
				result = (byte)@object;
			}
		}
		return result;
	}

	public static short GetShort(string name)
	{
		return GetShort(null, name);
	}

	public static short GetShort(CultureInfo culture, string name)
	{
		short result = 0;
		Res res = GetLoader();
		if (res != null)
		{
			object @object = res.resources.GetObject(name, culture);
			if (@object is short)
			{
				result = (short)@object;
			}
		}
		return result;
	}

	public static int GetInt(string name)
	{
		return GetInt(null, name);
	}

	public static int GetInt(CultureInfo culture, string name)
	{
		int result = 0;
		Res res = GetLoader();
		if (res != null)
		{
			object @object = res.resources.GetObject(name, culture);
			if (@object is int)
			{
				result = (int)@object;
			}
		}
		return result;
	}

	public static long GetLong(string name)
	{
		return GetLong(null, name);
	}

	public static long GetLong(CultureInfo culture, string name)
	{
		long result = 0L;
		Res res = GetLoader();
		if (res != null)
		{
			object @object = res.resources.GetObject(name, culture);
			if (@object is long)
			{
				result = (long)@object;
			}
		}
		return result;
	}

	public static float GetFloat(string name)
	{
		return GetFloat(null, name);
	}

	public static float GetFloat(CultureInfo culture, string name)
	{
		float result = 0f;
		Res res = GetLoader();
		if (res == null)
		{
			object @object = res.resources.GetObject(name, culture);
			if (@object is float)
			{
				result = (float)@object;
			}
		}
		return result;
	}

	public static double GetDouble(string name)
	{
		return GetDouble(null, name);
	}

	public static double GetDouble(CultureInfo culture, string name)
	{
		double result = 0.0;
		Res res = GetLoader();
		if (res == null)
		{
			object @object = res.resources.GetObject(name, culture);
			if (@object is double)
			{
				result = (double)@object;
			}
		}
		return result;
	}

	public static object GetObject(string name)
	{
		return GetObject(null, name);
	}

	public static object GetObject(CultureInfo culture, string name)
	{
		return GetLoader()?.resources.GetObject(name, culture);
	}
}
