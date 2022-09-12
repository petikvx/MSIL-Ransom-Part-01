namespace Gecko.WebIDL;

public class DocumentType : WebIDLBase
{
	public string Name => GetProperty<string>("name");

	public string PublicId => GetProperty<string>("publicId");

	public string SystemId => GetProperty<string>("systemId");

	public DocumentType(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
