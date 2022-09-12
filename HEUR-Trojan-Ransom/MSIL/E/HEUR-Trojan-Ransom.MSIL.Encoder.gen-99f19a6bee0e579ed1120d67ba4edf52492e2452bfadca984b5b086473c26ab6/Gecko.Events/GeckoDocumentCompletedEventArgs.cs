using System;

namespace Gecko.Events;

public class GeckoDocumentCompletedEventArgs : EventArgs
{
	public Uri Uri { get; private set; }

	public GeckoWindow Window { get; private set; }

	public bool IsTopLevel => Window.IsTopWindow();

	public GeckoDocumentCompletedEventArgs(Uri uri, GeckoWindow window)
	{
		Uri = uri;
		Window = window;
	}
}
