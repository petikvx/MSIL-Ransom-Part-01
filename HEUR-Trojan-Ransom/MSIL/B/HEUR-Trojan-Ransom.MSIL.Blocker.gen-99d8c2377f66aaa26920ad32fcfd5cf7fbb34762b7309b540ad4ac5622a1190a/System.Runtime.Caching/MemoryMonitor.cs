using System.Security;

namespace System.Runtime.Caching;

internal abstract class MemoryMonitor
{
	protected const int TERABYTE_SHIFT = 40;

	protected const long TERABYTE = 1099511627776L;

	protected const int GIGABYTE_SHIFT = 30;

	protected const long GIGABYTE = 1073741824L;

	protected const int MEGABYTE_SHIFT = 20;

	protected const long MEGABYTE = 1048576L;

	protected const int KILOBYTE_SHIFT = 10;

	protected const long KILOBYTE = 1024L;

	protected const int HISTORY_COUNT = 6;

	protected int _pressureHigh;

	protected int _pressureLow;

	protected int _i0;

	protected int[] _pressureHist;

	protected int _pressureTotal;

	private static long s_totalPhysical;

	private static long s_totalVirtual;

	internal static long TotalPhysical => s_totalPhysical;

	internal static long TotalVirtual => s_totalVirtual;

	internal int PressureLast => _pressureHist[_i0];

	internal int PressureHigh => _pressureHigh;

	internal int PressureLow => _pressureLow;

	[SecuritySafeCritical]
	static MemoryMonitor()
	{
		MEMORYSTATUSEX memoryStatusEx = default(MEMORYSTATUSEX);
		memoryStatusEx.Init();
		if (UnsafeNativeMethods.GlobalMemoryStatusEx(ref memoryStatusEx) != 0)
		{
			s_totalPhysical = memoryStatusEx.ullTotalPhys;
			s_totalVirtual = memoryStatusEx.ullTotalVirtual;
		}
	}

	internal bool IsAboveHighPressure()
	{
		return PressureLast >= PressureHigh;
	}

	protected abstract int GetCurrentPressure();

	internal abstract int GetPercentToTrim(DateTime lastTrimTime, int lastTrimPercent);

	protected void InitHistory()
	{
		int currentPressure = GetCurrentPressure();
		_pressureHist = new int[6];
		for (int i = 0; i < 6; i++)
		{
			_pressureHist[i] = currentPressure;
			_pressureTotal += currentPressure;
		}
	}

	internal void Update()
	{
		int currentPressure = GetCurrentPressure();
		_i0 = (_i0 + 1) % 6;
		_pressureTotal -= _pressureHist[_i0];
		_pressureTotal += currentPressure;
		_pressureHist[_i0] = currentPressure;
	}
}
