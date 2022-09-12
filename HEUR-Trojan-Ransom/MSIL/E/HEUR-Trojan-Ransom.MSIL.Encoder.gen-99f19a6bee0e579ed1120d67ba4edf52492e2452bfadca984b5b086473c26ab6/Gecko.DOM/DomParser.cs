using Gecko.Interop;

namespace Gecko.DOM;

public sealed class DomParser
{
	private ComPtr<nsIDOMParser> _domParser;

	public DomParser()
	{
		_domParser = Xpcom.CreateInstance2<nsIDOMParser>("@mozilla.org/xmlextras/domparser;1");
	}

	public GeckoDomDocument ParseFromString(string str, string contentType = "text/html")
	{
		return _domParser.Instance.ParseFromString(str, contentType).Wrap(GeckoDomDocument.CreateDomDocumentWraper);
	}

	public GeckoDomDocument ParseFromBuffer(byte[] buffer, int count, string contentType = "text/html")
	{
		return _domParser.Instance.ParseFromBuffer(buffer, (uint)count, contentType).Wrap(GeckoDomDocument.CreateDomDocumentWraper);
	}

	public GeckoDomDocument ParseFromBuffer(byte[] buffer, string contentType = "text/html")
	{
		return _domParser.Instance.ParseFromBuffer(buffer, (uint)buffer.Length, contentType).Wrap(GeckoDomDocument.CreateDomDocumentWraper);
	}
}
