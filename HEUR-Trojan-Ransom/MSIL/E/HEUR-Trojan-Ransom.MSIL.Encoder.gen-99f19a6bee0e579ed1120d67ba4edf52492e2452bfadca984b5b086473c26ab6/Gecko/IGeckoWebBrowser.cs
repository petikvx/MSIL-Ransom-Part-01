using System;
using Gecko.Events;
using Gecko.IO;

namespace Gecko;

public interface IGeckoWebBrowser
{
	GeckoDocument Document { get; }

	GeckoWindow Window { get; }

	bool IsDisposed { get; }

	IntPtr Handle { get; }

	event EventHandler<DomEventArgs> Load;

	event EventHandler<GeckoDocumentCompletedEventArgs> DocumentCompleted;

	event EventHandler<GeckoNavigationErrorEventArgs> NavigationError;

	event EventHandler<GeckoRetargetedEventArgs> Retargeted;

	void Navigate(string url);

	bool Navigate(string url, GeckoLoadFlags loadFlags);

	bool Navigate(string url, GeckoLoadFlags loadFlags, string referrer, MimeInputStream postData);

	bool Navigate(string url, GeckoLoadFlags loadFlags, string referrer, MimeInputStream postData, MimeInputStream headers);

	bool GoBack();

	bool GoForward();

	bool Reload();

	void UserInterfaceThreadInvoke(Action action);

	T UserInterfaceThreadInvoke<T>(Func<T> func);
}
