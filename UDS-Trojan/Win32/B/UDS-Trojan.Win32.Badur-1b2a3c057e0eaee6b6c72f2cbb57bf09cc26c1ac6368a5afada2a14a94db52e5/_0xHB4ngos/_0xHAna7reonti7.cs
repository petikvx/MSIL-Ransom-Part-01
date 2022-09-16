using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using _0xHSeltze6s;

namespace _0xHB4ngos;

internal static class _0xHAna7reonti7
{
	private const string _0xHL1gals = "kernel32.dll";

	private const string _0xHJuju1sus = "kernel32.dll";

	private const int _0xHSi44lers = 512;

	private const int _0xHPuk7ng = 4096;

	private const int _0xHBai1ed = 8192;

	[DllImport("kernel32.dll", BestFitMapping = true, CharSet = CharSet.Unicode)]
	[SecurityCritical]
	internal static extern int FormatMessageW(int _0xHH2ngt2gs, IntPtr _0xH6etainers, int _0xHNig6tstick, int _0xHBre6k6ges, [Out] StringBuilder _0xHRe5owering, int _0xHParta3s, IntPtr _0xH8rains);

	[SecuritySafeCritical]
	internal static string _0xHR3laps3d(int _0xH8uphonies)
	{
		StringBuilder stringBuilder = new StringBuilder(512);
		if (FormatMessageW(12800, IntPtr.Zero, _0xH8uphonies, 0, stringBuilder, stringBuilder.Capacity, IntPtr.Zero) != 0)
		{
			return stringBuilder.ToString();
		}
		return _0xHA2eotropy._0xHAlluvi0n("UnknownError_Num", _0xH8uphonies);
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SecurityCritical]
	internal static extern uint GetCurrentProcessId();
}
