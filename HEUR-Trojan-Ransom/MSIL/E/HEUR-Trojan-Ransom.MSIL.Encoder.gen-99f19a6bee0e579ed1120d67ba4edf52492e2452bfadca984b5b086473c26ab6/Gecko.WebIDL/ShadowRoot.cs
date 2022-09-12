namespace Gecko.WebIDL;

public class ShadowRoot : WebIDLBase
{
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

	public nsIDOMElement Host => GetProperty<nsIDOMElement>("host");

	public nsISupports OlderShadowRoot => GetProperty<nsISupports>("olderShadowRoot");

	public bool ApplyAuthorStyles
	{
		get
		{
			return GetProperty<bool>("applyAuthorStyles");
		}
		set
		{
			SetProperty("applyAuthorStyles", value);
		}
	}

	public nsISupports StyleSheets => GetProperty<nsISupports>("styleSheets");

	public ShadowRoot(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsIDOMElement GetElementById(string elementId)
	{
		return CallMethod<nsIDOMElement>("getElementById", new object[1] { elementId });
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
}
