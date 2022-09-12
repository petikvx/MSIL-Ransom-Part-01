using System;
using Gecko.Net;

namespace Gecko.Events;

public class GeckoRetargetedEventArgs : EventArgs
{
	public readonly Uri Uri;

	public readonly GeckoWindow DomWindow;

	public readonly Request Request;

	public bool DomWindowTopLevel => DomWindow.IsTopWindow();

	public GeckoRetargetedEventArgs(Uri uri, GeckoWindow domWind, Request req)
	{
		Uri = uri;
		DomWindow = domWind;
		Request = req;
	}
}
