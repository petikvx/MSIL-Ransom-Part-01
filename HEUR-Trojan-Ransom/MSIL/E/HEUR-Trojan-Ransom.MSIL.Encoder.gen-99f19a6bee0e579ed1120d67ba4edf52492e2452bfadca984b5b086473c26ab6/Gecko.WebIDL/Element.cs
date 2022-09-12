namespace Gecko.WebIDL;

public class Element : WebIDLBase
{
	public string TagName => GetProperty<string>("tagName");

	public string Id
	{
		get
		{
			return GetProperty<string>("id");
		}
		set
		{
			SetProperty("id", value);
		}
	}

	public string ClassName
	{
		get
		{
			return GetProperty<string>("className");
		}
		set
		{
			SetProperty("className", value);
		}
	}

	public nsISupports ClassList => GetProperty<nsISupports>("classList");

	public nsISupports Attributes => GetProperty<nsISupports>("attributes");

	public float FontSizeInflation => GetProperty<float>("fontSizeInflation");

	public int ScrollTop
	{
		get
		{
			return GetProperty<int>("scrollTop");
		}
		set
		{
			SetProperty("scrollTop", value);
		}
	}

	public int ScrollLeft
	{
		get
		{
			return GetProperty<int>("scrollLeft");
		}
		set
		{
			SetProperty("scrollLeft", value);
		}
	}

	public int ScrollWidth => GetProperty<int>("scrollWidth");

	public int ScrollHeight => GetProperty<int>("scrollHeight");

	public int ClientTop => GetProperty<int>("clientTop");

	public int ClientLeft => GetProperty<int>("clientLeft");

	public int ClientWidth => GetProperty<int>("clientWidth");

	public int ClientHeight => GetProperty<int>("clientHeight");

	public int ScrollTopMin => GetProperty<int>("scrollTopMin");

	public int ScrollTopMax => GetProperty<int>("scrollTopMax");

	public int ScrollLeftMin => GetProperty<int>("scrollLeftMin");

	public int ScrollLeftMax => GetProperty<int>("scrollLeftMax");

	public nsISupports UndoManager => GetProperty<nsISupports>("undoManager");

	public bool UndoScope
	{
		get
		{
			return GetProperty<bool>("undoScope");
		}
		set
		{
			SetProperty("undoScope", value);
		}
	}

	public string InnerHTML
	{
		get
		{
			return GetProperty<string>("innerHTML");
		}
		set
		{
			SetProperty("innerHTML", value);
		}
	}

	public string OuterHTML
	{
		get
		{
			return GetProperty<string>("outerHTML");
		}
		set
		{
			SetProperty("outerHTML", value);
		}
	}

	public nsISupports ShadowRoot => GetProperty<nsISupports>("shadowRoot");

	public Element(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public string[] GetAttributeNames()
	{
		return CallMethod<string[]>("getAttributeNames", new object[0]);
	}

	public string GetAttribute(string name)
	{
		return CallMethod<string>("getAttribute", new object[1] { name });
	}

	public string GetAttributeNS(string @namespace, string localName)
	{
		return CallMethod<string>("getAttributeNS", new object[2] { @namespace, localName });
	}

	public void SetAttribute(string name, string value)
	{
		CallVoidMethod("setAttribute", name, value);
	}

	public void SetAttributeNS(string @namespace, string name, string value)
	{
		CallVoidMethod("setAttributeNS", @namespace, name, value);
	}

	public void RemoveAttribute(string name)
	{
		CallVoidMethod("removeAttribute", name);
	}

	public void RemoveAttributeNS(string @namespace, string localName)
	{
		CallVoidMethod("removeAttributeNS", @namespace, localName);
	}

	public bool HasAttribute(string name)
	{
		return CallMethod<bool>("hasAttribute", new object[1] { name });
	}

	public bool HasAttributeNS(string @namespace, string localName)
	{
		return CallMethod<bool>("hasAttributeNS", new object[2] { @namespace, localName });
	}

	public bool HasAttributes()
	{
		return CallMethod<bool>("hasAttributes", new object[0]);
	}

	public nsIDOMElement Closest(string selector)
	{
		return CallMethod<nsIDOMElement>("closest", new object[1] { selector });
	}

	public bool Matches(string selector)
	{
		return CallMethod<bool>("matches", new object[1] { selector });
	}

	public bool WebkitMatchesSelector(string selector)
	{
		return CallMethod<bool>("webkitMatchesSelector", new object[1] { selector });
	}

	public nsISupports GetElementsByTagName(string localName)
	{
		return CallMethod<nsISupports>("getElementsByTagName", new object[1] { localName });
	}

	public nsISupports GetElementsByTagNameNS(string @namespace, string localName)
	{
		return CallMethod<nsISupports>("getElementsByTagNameNS", new object[2] { @namespace, localName });
	}

	public nsISupports GetElementsByClassName(string classNames)
	{
		return CallMethod<nsISupports>("getElementsByClassName", new object[1] { classNames });
	}

	public bool MozMatchesSelector(string selector)
	{
		return CallMethod<bool>("mozMatchesSelector", new object[1] { selector });
	}

	public void SetPointerCapture(int pointerId)
	{
		CallVoidMethod("setPointerCapture", pointerId);
	}

	public void ReleasePointerCapture(int pointerId)
	{
		CallVoidMethod("releasePointerCapture", pointerId);
	}

	public void SetCapture()
	{
		CallVoidMethod("setCapture");
	}

	public void SetCapture(bool retargetToElement)
	{
		CallVoidMethod("setCapture", retargetToElement);
	}

	public void ReleaseCapture()
	{
		CallVoidMethod("releaseCapture");
	}

	public void MozRequestFullScreen()
	{
		CallVoidMethod("mozRequestFullScreen");
	}

	public void MozRequestFullScreen(object options)
	{
		CallVoidMethod("mozRequestFullScreen", options);
	}

	public void MozRequestPointerLock()
	{
		CallVoidMethod("mozRequestPointerLock");
	}

	public nsISupports GetAttributeNode(string name)
	{
		return CallMethod<nsISupports>("getAttributeNode", new object[1] { name });
	}

	public nsISupports SetAttributeNode(nsISupports newAttr)
	{
		return CallMethod<nsISupports>("setAttributeNode", new object[1] { newAttr });
	}

	public nsISupports RemoveAttributeNode(nsISupports oldAttr)
	{
		return CallMethod<nsISupports>("removeAttributeNode", new object[1] { oldAttr });
	}

	public nsISupports GetAttributeNodeNS(string namespaceURI, string localName)
	{
		return CallMethod<nsISupports>("getAttributeNodeNS", new object[2] { namespaceURI, localName });
	}

	public nsISupports SetAttributeNodeNS(nsISupports newAttr)
	{
		return CallMethod<nsISupports>("setAttributeNodeNS", new object[1] { newAttr });
	}

	public bool ScrollByNoFlush(int dx, int dy)
	{
		return CallMethod<bool>("scrollByNoFlush", new object[2] { dx, dy });
	}

	public nsISupports GetClientRects()
	{
		return CallMethod<nsISupports>("getClientRects", new object[0]);
	}

	public nsISupports GetBoundingClientRect()
	{
		return CallMethod<nsISupports>("getBoundingClientRect", new object[0]);
	}

	public void ScrollIntoView(bool top)
	{
		CallVoidMethod("scrollIntoView", top);
	}

	public void ScrollIntoView()
	{
		CallVoidMethod("scrollIntoView");
	}

	public void ScrollIntoView(object options)
	{
		CallVoidMethod("scrollIntoView", options);
	}

	public void Scroll(double x, double y)
	{
		CallVoidMethod("scroll", x, y);
	}

	public void Scroll()
	{
		CallVoidMethod("scroll");
	}

	public void Scroll(object options)
	{
		CallVoidMethod("scroll", options);
	}

	public void ScrollTo(double x, double y)
	{
		CallVoidMethod("scrollTo", x, y);
	}

	public void ScrollTo()
	{
		CallVoidMethod("scrollTo");
	}

	public void ScrollTo(object options)
	{
		CallVoidMethod("scrollTo", options);
	}

	public void ScrollBy(double x, double y)
	{
		CallVoidMethod("scrollBy", x, y);
	}

	public void ScrollBy()
	{
		CallVoidMethod("scrollBy");
	}

	public void ScrollBy(object options)
	{
		CallVoidMethod("scrollBy", options);
	}

	public void MozScrollSnap()
	{
		CallVoidMethod("mozScrollSnap");
	}

	public void InsertAdjacentHTML(string position, string text)
	{
		CallVoidMethod("insertAdjacentHTML", position, text);
	}

	public nsIDOMElement QuerySelector(string selectors)
	{
		return CallMethod<nsIDOMElement>("querySelector", new object[1] { selectors });
	}

	public nsISupports QuerySelectorAll(string selectors)
	{
		return CallMethod<nsISupports>("querySelectorAll", new object[1] { selectors });
	}

	public nsISupports CreateShadowRoot()
	{
		return CallMethod<nsISupports>("createShadowRoot", new object[0]);
	}

	public nsISupports GetDestinationInsertionPoints()
	{
		return CallMethod<nsISupports>("getDestinationInsertionPoints", new object[0]);
	}
}
