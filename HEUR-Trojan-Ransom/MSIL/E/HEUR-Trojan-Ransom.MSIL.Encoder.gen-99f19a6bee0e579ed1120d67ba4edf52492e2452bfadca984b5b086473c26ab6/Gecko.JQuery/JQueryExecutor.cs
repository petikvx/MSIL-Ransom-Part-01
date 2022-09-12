using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Gecko.JQuery;

public class JQueryExecutor
{
	private readonly GeckoWindow _window;

	public JQueryExecutor(GeckoWindow window)
	{
		_window = window;
	}

	public JsVal ExecuteJQuery(string jQuery)
	{
		using AutoJSContext autoJSContext = new AutoJSContext(_window);
		return autoJSContext.EvaluateScript(jQuery, _window.DomWindow);
	}

	public GeckoElement GetElementByJQuery(string jQuery)
	{
		using AutoJSContext autoJSContext = new AutoJSContext(_window);
		JsVal jsValue = autoJSContext.EvaluateScript(jQuery, _window.DomWindow);
		if (!jsValue.IsObject)
		{
			return null;
		}
		object obj = jsValue.ToComObject(autoJSContext.ContextPointer);
		nsIDOMHTMLElement nsIDOMHTMLElement = Xpcom.QueryInterface<nsIDOMHTMLElement>(obj);
		if (nsIDOMHTMLElement != null)
		{
			return GeckoHtmlElement.Create(nsIDOMHTMLElement);
		}
		if (!SpiderMonkey.JS_HasProperty(autoJSContext.ContextPointer, jsValue.AsPtr, "length"))
		{
			return null;
		}
		if (SpiderMonkey.JS_GetProperty(autoJSContext.ContextPointer, jsValue.AsPtr, "length").ToInteger() == 0)
		{
			return null;
		}
		return CreateHtmlElementFromDom(autoJSContext, jsValue, 0);
	}

	public IEnumerable<GeckoElement> GetElementsByJQuery(string jQuery)
	{
		AutoJSContext autoContext = new AutoJSContext(_window);
		try
		{
			JsVal jsValue = autoContext.EvaluateScript(jQuery, _window.DomWindow);
			if (!jsValue.IsObject)
			{
				return new List<GeckoElement>();
			}
			if (!SpiderMonkey.JS_HasProperty(autoContext.ContextPointer, jsValue.AsPtr, "length"))
			{
				return new List<GeckoElement>();
			}
			int num = SpiderMonkey.JS_GetProperty(autoContext.ContextPointer, jsValue.AsPtr, "length").ToInteger();
			if (num == 0)
			{
				return new List<GeckoElement>();
			}
			return (from elementIndex in Enumerable.Range(0, num)
				select CreateHtmlElementFromDom(autoContext, jsValue, elementIndex) into element
				where element != null
				select element).ToList();
		}
		finally
		{
			if (autoContext != null)
			{
				((IDisposable)autoContext).Dispose();
			}
		}
	}

	private static GeckoElement CreateHtmlElementFromDom(AutoJSContext autoContext, JsVal jsValue, int elementIndex)
	{
		string name = elementIndex.ToString(CultureInfo.InvariantCulture);
		object obj = SpiderMonkey.JS_GetProperty(autoContext.ContextPointer, jsValue.AsPtr, name).ToComObject(autoContext.ContextPointer);
		nsIDOMHTMLElement nsIDOMHTMLElement = Xpcom.QueryInterface<nsIDOMHTMLElement>(obj);
		if (nsIDOMHTMLElement == null)
		{
			return null;
		}
		return GeckoHtmlElement.Create(nsIDOMHTMLElement);
	}
}
