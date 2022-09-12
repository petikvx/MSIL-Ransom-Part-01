using System;

namespace ExciteRAN;

internal sealed class MenuItemSet
{
	internal static bool CleanAssistant(IntPtr windowPosition, IntPtr parentLog)
	{
		return windowPosition != parentLog;
	}
}
