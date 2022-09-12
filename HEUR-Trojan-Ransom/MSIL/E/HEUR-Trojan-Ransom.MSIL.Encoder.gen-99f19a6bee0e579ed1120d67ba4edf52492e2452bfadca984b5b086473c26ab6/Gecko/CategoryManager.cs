using System;
using System.Collections.Generic;
using Gecko.Collections;
using Gecko.Interop;

namespace Gecko;

public static class CategoryManager
{
	private static ComPtr<nsICategoryManager> _categoryManager;

	public static string ContentPolicy;

	public static IEnumerable<string> Categories => new GeckoEnumerableCollection<string, nsISupportsCString>(() => _categoryManager.Instance.EnumerateCategories(), nsSupportsPrimitiveConverter.GetString);

	static CategoryManager()
	{
		ContentPolicy = "content-policy";
		_categoryManager = Xpcom.GetService2<nsICategoryManager>("@mozilla.org/categorymanager;1");
	}

	public static string AddCategoryEntry(string aCategory, string aEntry, string aValue, bool aPersist, bool aReplace)
	{
		string text = null;
		try
		{
			text = _categoryManager.Instance.GetCategoryEntry(aCategory, aEntry);
		}
		catch (Exception)
		{
		}
		if (text != null)
		{
			_categoryManager.Instance.DeleteCategoryEntry(aCategory, aEntry, aPersist);
		}
		return _categoryManager.Instance.AddCategoryEntry(aCategory, aEntry, aValue, aPersist, aReplace);
	}

	public static void DeleteCategory(string aCategory)
	{
		_categoryManager.Instance.DeleteCategory(aCategory);
	}

	public static void DeleteCategoryEntry(string aCategory, string aEntry, bool aPersist)
	{
		_categoryManager.Instance.DeleteCategoryEntry(aCategory, aEntry, aPersist);
	}

	public static string GetCategoryEntry(string aCategory, string aEntry)
	{
		return _categoryManager.Instance.GetCategoryEntry(aCategory, aEntry);
	}

	public static IEnumerable<string> GetCategoryEntries(string category)
	{
		return new GeckoEnumerableCollection<string, nsISupportsCString>(() => _categoryManager.Instance.EnumerateCategory(category), nsSupportsPrimitiveConverter.GetString);
	}
}
