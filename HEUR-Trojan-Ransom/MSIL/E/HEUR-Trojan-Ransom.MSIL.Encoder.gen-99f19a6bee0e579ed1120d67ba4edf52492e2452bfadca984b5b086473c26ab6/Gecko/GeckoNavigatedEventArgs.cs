using System;

namespace Gecko;

public class GeckoNavigatedEventArgs : EventArgs
{
	private readonly nsIRequest _response;

	private GeckoResponse _wrapper;

	public readonly GeckoWindow DomWindow;

	public readonly Uri Uri;

	public readonly bool IsSameDocument;

	public readonly bool IsErrorPage;

	public bool DomWindowTopLevel
	{
		get
		{
			using GeckoWindow geckoWindow = DomWindow.Top;
			return DomWindow == null || DomWindow.DomWindow.Equals(geckoWindow.DomWindow);
		}
	}

	public GeckoResponse Response => _wrapper ?? (_wrapper = new GeckoResponse(_response));

	internal GeckoNavigatedEventArgs(Uri value, nsIRequest response, GeckoWindow domWind, bool _sameDocument, bool _errorPage)
	{
		Uri = value;
		_response = response;
		DomWindow = domWind;
		IsSameDocument = _sameDocument;
		IsErrorPage = _errorPage;
	}
}
