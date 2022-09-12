namespace Gecko.DOM;

public class DomDocumentType : GeckoNode
{
	private nsIDOMDocumentType _documentType;

	public string Name => nsString.Get(_documentType.GetNameAttribute);

	public string PublicID => nsString.Get(_documentType.GetPublicIdAttribute);

	public string SystemID => nsString.Get(_documentType.GetSystemIdAttribute);

	public string InternalSubset => nsString.Get(_documentType.GetInternalSubsetAttribute);

	private DomDocumentType(nsIDOMDocumentType documentType)
		: base(documentType)
	{
		_documentType = documentType;
	}

	public static DomDocumentType Create(nsIDOMDocumentType documentType)
	{
		return new DomDocumentType(documentType);
	}
}
