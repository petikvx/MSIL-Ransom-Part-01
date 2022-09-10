using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace jusched;

public class cIdleTimeStool
{
	public struct LASTINPUTINFO
	{
		public uint cbSize;

		public uint dwTime;
	}

	[DebuggerNonUserCode]
	public cIdleTimeStool()
	{
	}

	[DllImport("user32.dll")]
	private static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);

	public TimeSpan? GetInactiveTime()
	{
		LASTINPUTINFO plii = default(LASTINPUTINFO);
		checked
		{
			plii.cbSize = (uint)Marshal.SizeOf((object)plii);
			if (GetLastInputInfo(ref plii))
			{
				return TimeSpan.FromMilliseconds(unchecked((long)Environment.TickCount) - unchecked((long)plii.dwTime));
			}
			TimeSpan? result = default(TimeSpan?);
			return result;
		}
	}
}
