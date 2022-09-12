using System.ComponentModel;

namespace Gecko;

public class GeckoCreateWindowEventArgs : CancelEventArgs
{
	private GeckoWebBrowser _webBrowser;

	public readonly GeckoWindowFlags Flags;

	public readonly string Uri;

	public int InitialWidth = -1;

	public int InitialHeight = -1;

	public GeckoWebBrowser WebBrowser
	{
		get
		{
			return _webBrowser;
		}
		set
		{
			_webBrowser = value;
		}
	}

	public GeckoCreateWindowEventArgs(GeckoWindowFlags flags, string uri)
		: base(cancel: false)
	{
		Flags = flags;
		Uri = uri;
	}
}
