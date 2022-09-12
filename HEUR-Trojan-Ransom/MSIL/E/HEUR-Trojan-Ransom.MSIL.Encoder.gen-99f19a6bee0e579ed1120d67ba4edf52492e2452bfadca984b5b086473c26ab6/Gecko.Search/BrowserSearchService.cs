using System;
using Gecko.Interop;

namespace Gecko.Search;

public static class BrowserSearchService
{
	private static ComPtr<nsIBrowserSearchService> _browserSearchService;

	public static SearchEngine DefaultEngine => SearchEngine.Create(_browserSearchService.Instance.GetDefaultEngineAttribute());

	public static SearchEngine CurrentEngine
	{
		get
		{
			return SearchEngine.Create(_browserSearchService.Instance.GetCurrentEngineAttribute());
		}
		set
		{
			_browserSearchService.Instance.SetCurrentEngineAttribute(value._searchEngine);
		}
	}

	static BrowserSearchService()
	{
		_browserSearchService = Xpcom.GetService2<nsIBrowserSearchService>("@mozilla.org/browser/search-service;1");
	}

	public static void AddEngine(string engineUrl, int dataType, string iconUrl, bool confirm)
	{
		using nsAString engineURL = new nsAString(engineUrl);
		using nsAString iconURL = new nsAString(iconUrl);
		_browserSearchService.Instance.AddEngine(engineURL, dataType, iconURL, confirm, null);
	}

	public static void AddEngineWithDetails(string name, string iconUrl, string alias, string description, string method, string url)
	{
		if (string.IsNullOrEmpty(name))
		{
			throw new ArgumentException("Must not be null", "name");
		}
		using nsAString name2 = new nsAString(name);
		using nsAString iconURL = new nsAString(iconUrl);
		using nsAString alias2 = new nsAString(alias);
		using nsAString description2 = new nsAString(description);
		using nsAString method2 = new nsAString(method);
		using nsAString url2 = new nsAString(url);
		using nsAString extensionID = new nsAString(string.Empty);
		_browserSearchService.Instance.AddEngineWithDetails(name2, iconURL, alias2, description2, method2, url2, extensionID);
	}

	public static void RestoreDefaultEngines()
	{
		_browserSearchService.Instance.RestoreDefaultEngines();
	}

	public static SearchEngine GetEngineByAlias(string alias)
	{
		nsISearchEngine searchEngine = nsString.Pass(_browserSearchService.Instance.GetEngineByAlias, alias);
		return SearchEngine.Create(searchEngine);
	}

	public static SearchEngine GetEngineByName(string engineName)
	{
		nsISearchEngine searchEngine = nsString.Pass(_browserSearchService.Instance.GetEngineByName, engineName);
		return SearchEngine.Create(searchEngine);
	}

	public static void MoveEngine(SearchEngine engine, int newIndex)
	{
		_browserSearchService.Instance.MoveEngine(engine._searchEngine, newIndex);
	}

	public static void RemoveEngine(SearchEngine engine)
	{
		_browserSearchService.Instance.RemoveEngine(engine._searchEngine);
	}
}
