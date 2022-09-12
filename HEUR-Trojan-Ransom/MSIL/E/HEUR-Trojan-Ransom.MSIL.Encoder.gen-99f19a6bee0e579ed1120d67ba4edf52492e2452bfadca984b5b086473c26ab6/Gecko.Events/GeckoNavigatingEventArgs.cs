using System;
using System.ComponentModel;

namespace Gecko.Events;

public class GeckoNavigatingEventArgs : CancelEventArgs
{
	public readonly Uri Uri;

	public readonly GeckoWindow DomWindow;

	public bool DomWindowTopLevel => DomWindow.IsTopWindow();

	public GeckoNavigatingEventArgs(Uri value, GeckoWindow domWind)
	{
		Uri = value;
		DomWindow = domWind;
	}
}
