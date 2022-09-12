using System;
using System.Windows.Forms;

namespace Gecko;

[Obsolete("Use the DocumentCompleted event instead of the NavigateFinished event.", false)]
public class NavigateFinishedNotifier : IDisposable
{
	private GeckoWebBrowser m_browser;

	[Obsolete("Use the DocumentCompleted event instead")]
	public event EventHandler NavigateFinished;

	public NavigateFinishedNotifier(GeckoWebBrowser browser)
	{
		m_browser = browser;
	}

	public void BlockUntilNavigationFinished()
	{
		bool done = false;
		m_browser.DocumentCompleted += delegate
		{
			done = true;
		};
		m_browser.NavigationError += delegate
		{
			done = true;
		};
		m_browser.Retargeted += delegate
		{
			done = true;
		};
		while (!done)
		{
			Application.DoEvents();
			Application.RaiseIdle(new EventArgs());
		}
	}

	public void Dispose()
	{
		GC.SuppressFinalize(this);
	}
}
