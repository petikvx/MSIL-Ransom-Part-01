using System;

namespace Microsoft.Win32.TaskScheduler.V1Interop;

internal struct MonthlyDOW
{
	public ushort WhichWeek;

	public DaysOfTheWeek DaysOfTheWeek;

	public MonthsOfTheYear Months;

	public WhichWeek V2WhichWeek
	{
		get
		{
			return (WhichWeek)(1 << (short)WhichWeek - 1);
		}
		set
		{
			int num = Array.IndexOf(new short[5] { 1, 2, 4, 8, 16 }, (short)value);
			if (num < 0)
			{
				throw new NotV1SupportedException("Only a single week can be set with Task Scheduler 1.0.");
			}
			WhichWeek = (ushort)(num + 1);
		}
	}
}
