namespace Gecko.WebIDL;

public class XULDocument : WebIDLBase
{
	public nsIDOMNode PopupNode
	{
		get
		{
			return GetProperty<nsIDOMNode>("popupNode");
		}
		set
		{
			SetProperty("popupNode", value);
		}
	}

	public nsIDOMNode PopupRangeParent => GetProperty<nsIDOMNode>("popupRangeParent");

	public int PopupRangeOffset => GetProperty<int>("popupRangeOffset");

	public nsIDOMNode TooltipNode
	{
		get
		{
			return GetProperty<nsIDOMNode>("tooltipNode");
		}
		set
		{
			SetProperty("tooltipNode", value);
		}
	}

	public nsISupports CommandDispatcher => GetProperty<nsISupports>("commandDispatcher");

	public int Width => GetProperty<int>("width");

	public int Height => GetProperty<int>("height");

	public XULDocument(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports GetElementsByAttribute(string name, string value)
	{
		return CallMethod<nsISupports>("getElementsByAttribute", new object[2] { name, value });
	}

	public nsISupports GetElementsByAttributeNS(string namespaceURI, string name, string value)
	{
		return CallMethod<nsISupports>("getElementsByAttributeNS", new object[3] { namespaceURI, name, value });
	}

	public void AddBroadcastListenerFor(nsIDOMElement broadcaster, nsIDOMElement observer, string attr)
	{
		CallVoidMethod("addBroadcastListenerFor", broadcaster, observer, attr);
	}

	public void RemoveBroadcastListenerFor(nsIDOMElement broadcaster, nsIDOMElement observer, string attr)
	{
		CallVoidMethod("removeBroadcastListenerFor", broadcaster, observer, attr);
	}

	public void Persist(string id, string attr)
	{
		CallVoidMethod("persist", id, attr);
	}

	public nsISupports GetBoxObjectFor(nsIDOMElement element)
	{
		return CallMethod<nsISupports>("getBoxObjectFor", new object[1] { element });
	}

	public void LoadOverlay(string url, nsISupports observer)
	{
		CallVoidMethod("loadOverlay", url, observer);
	}
}
