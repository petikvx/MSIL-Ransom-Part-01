using System.Security;

namespace System.Runtime.Caching;

internal sealed class PhysicalMemoryMonitor : MemoryMonitor
{
	private const int MIN_TOTAL_MEMORY_TRIM_PERCENT = 10;

	private static readonly long TARGET_TOTAL_MEMORY_TRIM_INTERVAL_TICKS = 3000000000L;

	internal long MemoryLimit => _pressureHigh;

	private PhysicalMemoryMonitor()
	{
	}

	internal PhysicalMemoryMonitor(int physicalMemoryLimitPercentage)
	{
		long totalPhysical = MemoryMonitor.TotalPhysical;
		if (totalPhysical >= 4294967296L)
		{
			_pressureHigh = 99;
		}
		else if (totalPhysical >= 2147483648L)
		{
			_pressureHigh = 98;
		}
		else if (totalPhysical >= 1073741824L)
		{
			_pressureHigh = 97;
		}
		else if (totalPhysical >= 805306368L)
		{
			_pressureHigh = 96;
		}
		else
		{
			_pressureHigh = 95;
		}
		_pressureLow = _pressureHigh - 9;
		SetLimit(physicalMemoryLimitPercentage);
		InitHistory();
	}

	[SecuritySafeCritical]
	protected override int GetCurrentPressure()
	{
		MEMORYSTATUSEX memoryStatusEx = default(MEMORYSTATUSEX);
		memoryStatusEx.Init();
		if (UnsafeNativeMethods.GlobalMemoryStatusEx(ref memoryStatusEx) == 0)
		{
			return 0;
		}
		return memoryStatusEx.dwMemoryLoad;
	}

	internal override int GetPercentToTrim(DateTime lastTrimTime, int lastTrimPercent)
	{
		int result = 0;
		if (IsAboveHighPressure())
		{
			long ticks = DateTime.UtcNow.Subtract(lastTrimTime).Ticks;
			if (ticks > 0L)
			{
				result = Math.Min(50, (int)(lastTrimPercent * TARGET_TOTAL_MEMORY_TRIM_INTERVAL_TICKS / ticks));
				result = Math.Max(10, result);
			}
		}
		return result;
	}

	internal void SetLimit(int physicalMemoryLimitPercentage)
	{
		if (physicalMemoryLimitPercentage != 0)
		{
			_pressureHigh = Math.Max(3, physicalMemoryLimitPercentage);
			_pressureLow = Math.Max(1, _pressureHigh - 9);
		}
	}
}
