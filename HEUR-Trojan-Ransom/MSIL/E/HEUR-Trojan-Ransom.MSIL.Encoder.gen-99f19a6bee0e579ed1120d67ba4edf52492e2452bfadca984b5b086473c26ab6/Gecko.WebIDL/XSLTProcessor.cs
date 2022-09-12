namespace Gecko.WebIDL;

public class XSLTProcessor : WebIDLBase
{
	public uint Flags
	{
		get
		{
			return GetProperty<uint>("flags");
		}
		set
		{
			SetProperty("flags", value);
		}
	}

	public XSLTProcessor(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void ImportStylesheet(nsIDOMNode style)
	{
		CallVoidMethod("importStylesheet", style);
	}

	public nsISupports TransformToFragment(nsIDOMNode source, nsIDOMDocument output)
	{
		return CallMethod<nsISupports>("transformToFragment", new object[2] { source, output });
	}

	public nsIDOMDocument TransformToDocument(nsIDOMNode source)
	{
		return CallMethod<nsIDOMDocument>("transformToDocument", new object[1] { source });
	}

	public void SetParameter(string namespaceURI, string localName, object value)
	{
		CallVoidMethod("setParameter", namespaceURI, localName, value);
	}

	public nsISupports GetParameter(string namespaceURI, string localName)
	{
		return CallMethod<nsISupports>("getParameter", new object[2] { namespaceURI, localName });
	}

	public void RemoveParameter(string namespaceURI, string localName)
	{
		CallVoidMethod("removeParameter", namespaceURI, localName);
	}

	public void ClearParameters()
	{
		CallVoidMethod("clearParameters");
	}

	public void Reset()
	{
		CallVoidMethod("reset");
	}
}
