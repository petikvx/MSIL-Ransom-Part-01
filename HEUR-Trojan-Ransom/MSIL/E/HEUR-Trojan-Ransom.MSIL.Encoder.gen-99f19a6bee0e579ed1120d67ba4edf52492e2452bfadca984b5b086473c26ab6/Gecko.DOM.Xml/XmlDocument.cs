namespace Gecko.DOM.Xml;

public sealed class XmlDocument : GeckoDomDocument
{
	private nsIDOMXMLDocument _xmlDocument;

	public bool Async
	{
		get
		{
			return _xmlDocument.GetAsyncAttribute();
		}
		set
		{
			_xmlDocument.SetAsyncAttribute(value);
		}
	}

	internal XmlDocument(nsIDOMXMLDocument document)
		: base(document)
	{
		_xmlDocument = document;
	}

	public bool Load(string url)
	{
		return nsString.Pass(_xmlDocument.Load, url);
	}
}
