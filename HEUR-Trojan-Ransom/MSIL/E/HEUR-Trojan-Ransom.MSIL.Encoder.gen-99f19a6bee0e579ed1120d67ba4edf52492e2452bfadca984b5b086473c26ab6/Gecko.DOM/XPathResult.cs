using System;
using System.Collections.Generic;
using Gecko.Interop;
using Gecko.WebIDL;

namespace Gecko.DOM;

public class XPathResult
{
	private ComPtr<nsIDOMWindow> _window;

	private ComPtr<nsIXPathResult> _xpathResult = null;

	internal XPathResult(nsIDOMWindow window, nsIXPathResult xpathResult)
	{
		_window = new ComPtr<nsIDOMWindow>(window);
		_xpathResult = new ComPtr<nsIXPathResult>(xpathResult);
	}

	public XPathResultType GetResultType()
	{
		using AutoJSContext autoJSContext = new AutoJSContext();
		IntPtr jsObject = autoJSContext.ConvertCOMObjectToJSObject((nsISupports)_xpathResult.Instance);
		return (XPathResultType)SpiderMonkey.JS_GetProperty(autoJSContext.ContextPointer, jsObject, "resultType").ToInteger();
	}

	public double GetNumberValue()
	{
		using AutoJSContext autoJSContext = new AutoJSContext();
		IntPtr jsObject = autoJSContext.ConvertCOMObjectToJSObject((nsISupports)_xpathResult.Instance);
		return SpiderMonkey.JS_GetProperty(autoJSContext.ContextPointer, jsObject, "numberValue").ToDouble();
	}

	public string GetStringValue()
	{
		using AutoJSContext autoJSContext = new AutoJSContext();
		IntPtr jsObject = autoJSContext.ConvertCOMObjectToJSObject((nsISupports)_xpathResult.Instance);
		return SpiderMonkey.JS_GetProperty(autoJSContext.ContextPointer, jsObject, "stringValue").ToString();
	}

	public bool GetBooleanValue()
	{
		using AutoJSContext autoJSContext = new AutoJSContext();
		IntPtr jsObject = autoJSContext.ConvertCOMObjectToJSObject((nsISupports)_xpathResult.Instance);
		return SpiderMonkey.JS_GetProperty(autoJSContext.ContextPointer, jsObject, "booleanValue").ToBoolean();
	}

	public GeckoNode GetSingleNodeValue()
	{
		return new Gecko.WebIDL.XPathResult(_window.Instance, _xpathResult.Instance as nsISupports).IterateNext().Wrap(GeckoNode.Create);
	}

	public IEnumerable<GeckoNode> GetNodes()
	{
		return new GeckoNodeEnumerable(new Gecko.WebIDL.XPathResult(_window.Instance, _xpathResult.Instance as nsISupports));
	}
}
