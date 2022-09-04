using System;
using System.Runtime.InteropServices;

namespace Lexplorer;

public class Class5
{
	[DllImport("user32.dll")]
	private static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);

	public TimeSpan? GetInactiveTime()
	{
		LASTINPUTINFO plii = default(LASTINPUTINFO);
		plii.cbSize = (uint)Marshal.SizeOf((object)plii);
		plii.dwTime = 0u;
		if (GetLastInputInfo(ref plii))
		{
			int num = Environment.TickCount - (int)plii.dwTime;
			return TimeSpan.FromMilliseconds(num);
		}
		return null;
	}
}
