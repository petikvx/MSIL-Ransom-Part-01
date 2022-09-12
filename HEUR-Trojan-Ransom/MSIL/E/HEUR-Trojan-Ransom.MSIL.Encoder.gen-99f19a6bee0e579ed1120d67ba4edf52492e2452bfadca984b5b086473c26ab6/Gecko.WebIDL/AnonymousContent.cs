namespace Gecko.WebIDL;

public class AnonymousContent : WebIDLBase
{
	public AnonymousContent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public string GetTextContentForElement(string elementId)
	{
		return CallMethod<string>("getTextContentForElement", new object[1] { elementId });
	}

	public void SetTextContentForElement(string elementId, string text)
	{
		CallVoidMethod("setTextContentForElement", elementId, text);
	}

	public string GetAttributeForElement(string elementId, string attributeName)
	{
		return CallMethod<string>("getAttributeForElement", new object[2] { elementId, attributeName });
	}

	public void SetAttributeForElement(string elementId, string attributeName, string value)
	{
		CallVoidMethod("setAttributeForElement", elementId, attributeName, value);
	}

	public void RemoveAttributeForElement(string elementId, string attributeName)
	{
		CallVoidMethod("removeAttributeForElement", elementId, attributeName);
	}

	public nsISupports GetCanvasContext(string elementId, string contextId)
	{
		return CallMethod<nsISupports>("getCanvasContext", new object[2] { elementId, contextId });
	}
}
