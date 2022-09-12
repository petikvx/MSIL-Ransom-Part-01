using System;
using System.ComponentModel;

namespace Gecko;

public class GeckoRedirectingEventArgs : CancelEventArgs
{
	public readonly Uri Uri;

	public readonly GeckoWindow DomWindow;

	public bool DomWindowTopLevel => DomWindow.IsTopWindow();

	public GeckoRedirectingEventArgs(Uri value, GeckoWindow domWind)
	{
		Uri = value;
		DomWindow = domWind;
	}
}
