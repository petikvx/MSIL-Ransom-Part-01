using System;
using System.Runtime.InteropServices;

namespace jusched;

public class cIdleTimeStool
{
	public struct LASTINPUTINFO
	{
		public uint cbSize;

		public uint dwTime;
	}

	[DllImport("user32.dll")]
	private static extern bool GetLastInputInfo(ref LASTINPUTINFO lastinputinfo_0);

	public TimeSpan? GetInactiveTime()
	{
		LASTINPUTINFO lastinputinfo_ = default(LASTINPUTINFO);
		checked
		{
			lastinputinfo_.cbSize = (uint)Marshal.SizeOf((object)lastinputinfo_);
			if (GetLastInputInfo(ref lastinputinfo_))
			{
				return TimeSpan.FromMilliseconds(unchecked((long)Environment.TickCount) - unchecked((long)lastinputinfo_.dwTime));
			}
			TimeSpan? result = default(TimeSpan?);
			return result;
		}
	}
}
