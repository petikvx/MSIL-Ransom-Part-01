namespace Gecko.WebIDL;

public class Attr : WebIDLBase
{
	public string LocalName => GetProperty<string>("localName");

	public string Value
	{
		get
		{
			return GetProperty<string>("value");
		}
		set
		{
			SetProperty("value", value);
		}
	}

	public string Name => GetProperty<string>("name");

	public string NamespaceURI => GetProperty<string>("namespaceURI");

	public string Prefix => GetProperty<string>("prefix");

	public bool Specified => GetProperty<bool>("specified");

	public nsIDOMElement OwnerElement => GetProperty<nsIDOMElement>("ownerElement");

	public Attr(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
