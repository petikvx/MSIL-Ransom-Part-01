using System;
using System.Globalization;
using System.Threading;

namespace Microsoft.Win32.TaskScheduler;

internal class CultureSwitcher : IDisposable
{
	private CultureInfo cur;

	private CultureInfo curUI;

	public CultureSwitcher(CultureInfo culture)
	{
		cur = Thread.CurrentThread.CurrentCulture;
		curUI = Thread.CurrentThread.CurrentUICulture;
		Thread.CurrentThread.CurrentCulture = (Thread.CurrentThread.CurrentUICulture = culture);
	}

	public void Dispose()
	{
		Thread.CurrentThread.CurrentCulture = cur;
		Thread.CurrentThread.CurrentUICulture = curUI;
	}
}
