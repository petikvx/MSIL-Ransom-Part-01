using System.Collections.Generic;

namespace Gecko.JQuery;

public static class GeckoWebBrowserExtensions
{
	public static JsVal ExecuteJQuery(this IGeckoWebBrowser browser, string jQuery)
	{
		JQueryExecutor jQueryExecutor = new JQueryExecutor(browser.Window);
		return jQueryExecutor.ExecuteJQuery(jQuery);
	}

	public static GeckoElement GetElementByJQuery(this IGeckoWebBrowser browser, string jQuery)
	{
		JQueryExecutor jQueryExecutor = new JQueryExecutor(browser.Window);
		return jQueryExecutor.GetElementByJQuery(jQuery);
	}

	public static IEnumerable<GeckoElement> GetElementsByJQuery(this IGeckoWebBrowser browser, string jQuery)
	{
		JQueryExecutor jQueryExecutor = new JQueryExecutor(browser.Window);
		return jQueryExecutor.GetElementsByJQuery(jQuery);
	}
}
