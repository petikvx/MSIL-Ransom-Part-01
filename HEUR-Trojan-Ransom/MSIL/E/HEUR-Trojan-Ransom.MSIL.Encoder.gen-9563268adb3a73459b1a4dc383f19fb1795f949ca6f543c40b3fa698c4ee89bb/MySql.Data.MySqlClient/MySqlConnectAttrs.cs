using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Management;
using System.Reflection;
using System.Runtime.Versioning;

namespace MySql.Data.MySqlClient;

internal class MySqlConnectAttrs
{
	private static string _version;

	private static string _os;

	private static string _platform;

	private static string _osName;

	private static string _framework;

	private static string _osDetails;

	[DisplayName("_client_name")]
	public string ClientName => "mysql-connector-net";

	[DisplayName("_client_licence")]
	public string ClientLicence => "GPL-2.0";

	[DisplayName("_pid")]
	public string PID
	{
		get
		{
			string result = string.Empty;
			try
			{
				result = Process.GetCurrentProcess().Id.ToString(CultureInfo.InvariantCulture);
				return result;
			}
			catch (Exception)
			{
				return result;
			}
		}
	}

	[DisplayName("_client_version")]
	public string ClientVersion => _version;

	[DisplayName("_os")]
	public string OS => _os;

	[DisplayName("_thread")]
	public string Thread
	{
		get
		{
			string result = string.Empty;
			try
			{
				result = Process.GetCurrentProcess().Threads[0].Id.ToString(CultureInfo.InvariantCulture);
				return result;
			}
			catch (Exception)
			{
				return result;
			}
		}
	}

	[DisplayName("_platform")]
	public string Platform => _platform;

	[DisplayName("_os_details")]
	public string OSDetails => _osDetails;

	[DisplayName("_os")]
	public string OSName => _osName;

	[DisplayName("_framework")]
	public string Framework => _framework;

	static MySqlConnectAttrs()
	{
		InitVersion();
		InitOS();
		InitPlatform();
		InitOSName();
		InitFramework();
		InitOSDetails();
	}

	private static void InitVersion()
	{
		_version = string.Empty;
		try
		{
			_version = typeof(MySqlConnectAttrs).GetTypeInfo().Assembly.GetName().Version!.ToString();
		}
		catch (Exception)
		{
		}
	}

	private static void InitOS()
	{
		_os = string.Empty;
		try
		{
			_os = Environment.OSVersion.Platform.ToString();
			if (_os == "Win32NT")
			{
				_os = "Win";
				_os += (Is64BitOS() ? "64" : "32");
			}
		}
		catch (Exception)
		{
		}
	}

	private static void InitPlatform()
	{
		_platform = (Is64BitOS() ? "x86_64" : "x86_32");
	}

	private static void InitOSDetails()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		_osDetails = string.Empty;
		try
		{
			ManagementObjectEnumerator enumerator = new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem").Get().GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					_osDetails = enumerator.get_Current().GetPropertyValue("Caption").ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		catch (Exception)
		{
		}
	}

	private static bool Is64BitOS()
	{
		return Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE") == "AMD64";
	}

	private static void InitOSName()
	{
		_osName = _os;
		OperatingSystem oSVersion = Environment.OSVersion;
		int major = oSVersion.Version.Major;
		int minor = oSVersion.Version.Minor;
		if (oSVersion.Platform.ToString().StartsWith("Win"))
		{
			switch (major)
			{
			default:
				_osName = "Windows";
				break;
			case 10:
				_osName = "Windows-10-" + major + "." + minor;
				break;
			case 6:
				switch (minor)
				{
				case 0:
					_osName = "Windows-2008-" + major + "." + minor;
					break;
				case 1:
					_osName = "Windows-7-" + major + "." + minor;
					break;
				case 2:
					_osName = "Windows-8-" + major + "." + minor;
					break;
				case 3:
					_osName = "Windows-8.1-" + major + "." + minor;
					break;
				}
				break;
			case 5:
				_osName = "Windows-XP-" + major + "." + minor;
				break;
			}
		}
		else
		{
			_osName = _os + "-" + major + "." + minor;
		}
	}

	private static void InitFramework()
	{
		_framework = string.Empty;
		try
		{
			_framework = Assembly.GetEntryAssembly().GetCustomAttribute<TargetFrameworkAttribute>()!.FrameworkName;
		}
		catch (Exception)
		{
		}
	}
}
