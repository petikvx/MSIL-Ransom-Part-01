namespace Gecko.WebIDL;

public class Node : WebIDLBase
{
	public ushort NodeType => GetProperty<ushort>("nodeType");

	public string NodeName => GetProperty<string>("nodeName");

	public string BaseURI => GetProperty<string>("baseURI");

	public nsIDOMDocument OwnerDocument => GetProperty<nsIDOMDocument>("ownerDocument");

	public nsIDOMNode ParentNode => GetProperty<nsIDOMNode>("parentNode");

	public nsIDOMElement ParentElement => GetProperty<nsIDOMElement>("parentElement");

	public nsISupports ChildNodes => GetProperty<nsISupports>("childNodes");

	public nsIDOMNode FirstChild => GetProperty<nsIDOMNode>("firstChild");

	public nsIDOMNode LastChild => GetProperty<nsIDOMNode>("lastChild");

	public nsIDOMNode PreviousSibling => GetProperty<nsIDOMNode>("previousSibling");

	public nsIDOMNode NextSibling => GetProperty<nsIDOMNode>("nextSibling");

	public string NodeValue
	{
		get
		{
			return GetProperty<string>("nodeValue");
		}
		set
		{
			SetProperty("nodeValue", value);
		}
	}

	public string TextContent
	{
		get
		{
			return GetProperty<string>("textContent");
		}
		set
		{
			SetProperty("textContent", value);
		}
	}

	public string NamespaceURI => GetProperty<string>("namespaceURI");

	public string Prefix => GetProperty<string>("prefix");

	public string LocalName => GetProperty<string>("localName");

	public nsISupports NodePrincipal => GetProperty<nsISupports>("nodePrincipal");

	public nsISupports BaseURIObject => GetProperty<nsISupports>("baseURIObject");

	public Node(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public bool HasChildNodes()
	{
		return CallMethod<bool>("hasChildNodes", new object[0]);
	}

	public nsIDOMNode InsertBefore(nsIDOMNode node, nsIDOMNode child)
	{
		return CallMethod<nsIDOMNode>("insertBefore", new object[2] { node, child });
	}

	public nsIDOMNode AppendChild(nsIDOMNode node)
	{
		return CallMethod<nsIDOMNode>("appendChild", new object[1] { node });
	}

	public nsIDOMNode ReplaceChild(nsIDOMNode node, nsIDOMNode child)
	{
		return CallMethod<nsIDOMNode>("replaceChild", new object[2] { node, child });
	}

	public nsIDOMNode RemoveChild(nsIDOMNode child)
	{
		return CallMethod<nsIDOMNode>("removeChild", new object[1] { child });
	}

	public void Normalize()
	{
		CallVoidMethod("normalize");
	}

	public nsIDOMNode CloneNode()
	{
		return CallMethod<nsIDOMNode>("cloneNode", new object[0]);
	}

	public nsIDOMNode CloneNode(bool deep)
	{
		return CallMethod<nsIDOMNode>("cloneNode", new object[1] { deep });
	}

	public bool IsEqualNode(nsIDOMNode node)
	{
		return CallMethod<bool>("isEqualNode", new object[1] { node });
	}

	public ushort CompareDocumentPosition(nsIDOMNode other)
	{
		return CallMethod<ushort>("compareDocumentPosition", new object[1] { other });
	}

	public bool Contains(nsIDOMNode other)
	{
		return CallMethod<bool>("contains", new object[1] { other });
	}

	public string LookupPrefix(string @namespace)
	{
		return CallMethod<string>("lookupPrefix", new object[1] { @namespace });
	}

	public string LookupNamespaceURI(string prefix)
	{
		return CallMethod<string>("lookupNamespaceURI", new object[1] { prefix });
	}

	public bool IsDefaultNamespace(string @namespace)
	{
		return CallMethod<bool>("isDefaultNamespace", new object[1] { @namespace });
	}

	public object SetUserData(string key, object data)
	{
		return CallMethod<object>("setUserData", new object[2] { key, data });
	}

	public object GetUserData(string key)
	{
		return CallMethod<object>("getUserData", new object[1] { key });
	}

	public nsISupports[] GetBoundMutationObservers()
	{
		return CallMethod<nsISupports[]>("getBoundMutationObservers", new object[0]);
	}
}
