namespace Gecko.WebIDL;

public class DOMImplementation : WebIDLBase
{
	public DOMImplementation(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public bool HasFeature(string feature, string version)
	{
		return CallMethod<bool>("hasFeature", new object[2] { feature, version });
	}

	public nsISupports CreateDocumentType(string qualifiedName, string publicId, string systemId)
	{
		return CallMethod<nsISupports>("createDocumentType", new object[3] { qualifiedName, publicId, systemId });
	}

	public nsIDOMDocument CreateDocument(string @namespace, string qualifiedName)
	{
		return CallMethod<nsIDOMDocument>("createDocument", new object[2] { @namespace, qualifiedName });
	}

	public nsIDOMDocument CreateDocument(string @namespace, string qualifiedName, nsISupports doctype)
	{
		return CallMethod<nsIDOMDocument>("createDocument", new object[3] { @namespace, qualifiedName, doctype });
	}

	public nsIDOMDocument CreateHTMLDocument()
	{
		return CallMethod<nsIDOMDocument>("createHTMLDocument", new object[0]);
	}

	public nsIDOMDocument CreateHTMLDocument(string title)
	{
		return CallMethod<nsIDOMDocument>("createHTMLDocument", new object[1] { title });
	}
}
