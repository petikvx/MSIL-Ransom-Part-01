namespace Gecko;

public class GeckoJavaScriptHttpChannelWrapper : nsIDOMEventListener
{
	private readonly GeckoWebBrowser m_browser;

	private readonly nsIHttpChannel m_httpChannel;

	private readonly nsIXMLHttpRequest m_notificationCallsbacks;

	public GeckoJavaScriptHttpChannelWrapper(GeckoWebBrowser p_browser, nsIHttpChannel p_httpChannel)
	{
		m_browser = p_browser;
		m_httpChannel = p_httpChannel;
		m_notificationCallsbacks = Xpcom.QueryInterface<nsIXMLHttpRequest>(m_httpChannel.GetNotificationCallbacksAttribute());
	}

	public void HandleEvent(nsIDOMEvent @event)
	{
		ushort readyStateAttribute = m_notificationCallsbacks.GetReadyStateAttribute();
		if (readyStateAttribute == 4)
		{
			m_browser.origJavaScriptHttpChannels.Remove(m_httpChannel);
		}
	}
}
