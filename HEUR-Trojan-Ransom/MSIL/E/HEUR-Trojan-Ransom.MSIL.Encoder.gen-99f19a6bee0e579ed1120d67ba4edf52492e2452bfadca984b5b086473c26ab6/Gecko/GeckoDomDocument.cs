using System;
using System.Runtime.InteropServices;
using Gecko.DOM;
using Gecko.Interop;

namespace Gecko;

public class GeckoDomDocument : GeckoNode
{
	internal nsIDOMDocument _domDocument;

	public nsIDOMDocument NativeDomDocument => _domDocument;

	public DomDocumentType Doctype => _domDocument.GetDoctypeAttribute().Wrap(DomDocumentType.Create);

	public GeckoElement DocumentElement
	{
		get
		{
			nsIDOMElement documentElementAttribute = _domDocument.GetDocumentElementAttribute();
			return documentElementAttribute.Wrap(GeckoElement.CreateDomElementWrapper);
		}
	}

	public string InputEncoding => nsString.Get(_domDocument.GetInputEncodingAttribute);

	public string Uri => nsString.Get(_domDocument.GetDocumentURIAttribute);

	public GeckoWindow DefaultView => _domDocument.GetDefaultViewAttribute().Wrap((nsIDOMWindow x) => new GeckoWindow(x));

	public string CharacterSet => nsString.Get(_domDocument.GetCharacterSetAttribute);

	public string Dir
	{
		get
		{
			return nsString.Get(_domDocument.GetDirAttribute);
		}
		set
		{
			nsString.Set(_domDocument.SetDirAttribute, value);
		}
	}

	public Location Location => _domDocument.GetLocationAttribute().Wrap(Location.Create);

	public string Title
	{
		get
		{
			return nsString.Get(_domDocument.GetTitleAttribute);
		}
		set
		{
			nsString.Set(_domDocument.SetTitleAttribute, value);
		}
	}

	public string ReadyState => nsString.Get(_domDocument.GetReadyStateAttribute);

	public string Referrer => nsString.Get(_domDocument.GetReferrerAttribute);

	public GeckoHtmlElement ActiveElement => (GeckoHtmlElement)_domDocument.GetActiveElementAttribute().Wrap(GeckoNode.Create);

	public string PreferredStyleSheetSet => nsString.Get(_domDocument.GetPreferredStyleSheetSetAttribute);

	public string SelectedStyleSheetSet
	{
		get
		{
			return nsString.Get(_domDocument.GetSelectedStyleSheetSetAttribute);
		}
		set
		{
			nsString.Set(_domDocument.SetSelectedStyleSheetSetAttribute, value);
		}
	}

	public string LastStyleSheetSet => nsString.Get(_domDocument.GetLastStyleSheetSetAttribute);

	public string ContentType => nsString.Get(_domDocument.GetContentTypeAttribute);

	public bool MozSyntheticDocument => _domDocument.GetMozSyntheticDocumentAttribute();

	public GeckoNode CurrentScript => _domDocument.GetCurrentScriptAttribute().Wrap(GeckoNode.Create);

	public bool MozFullScreen => _domDocument.GetMozFullScreenAttribute();

	public bool MozFullScreenEnabled => _domDocument.GetMozFullScreenEnabledAttribute();

	public bool MozHidden => _domDocument.GetMozHiddenAttribute();

	public string MozVisibilityState => nsString.Get(_domDocument.GetMozVisibilityStateAttribute);

	internal GeckoDomDocument(nsIDOMDocument document)
		: base(document)
	{
		_domDocument = document;
	}

	public GeckoHtmlElement CreateHtmlElement(string tagName)
	{
		if (string.IsNullOrEmpty(tagName))
		{
			throw new ArgumentException("tagName");
		}
		nsIDOMElement nsIDOMElement2 = nsString.Pass(_domDocument.CreateElement, tagName);
		return GeckoHtmlElement.Create((nsIDOMHTMLElement)nsIDOMElement2);
	}

	public GeckoElement CreateElement(string tagName)
	{
		if (string.IsNullOrEmpty(tagName))
		{
			throw new ArgumentException("tagName");
		}
		return nsString.Pass(_domDocument.CreateElement, tagName).Wrap(GeckoElement.CreateDomElementWrapper);
	}

	public DocumentFragment CreateDocumentFragment()
	{
		return _domDocument.CreateDocumentFragment().Wrap(DocumentFragment.CreateDocumentFragmentWrapper);
	}

	public GeckoTextNode CreateTextNode(string data)
	{
		return nsString.Pass(_domDocument.CreateTextNode, data).Wrap(GeckoTextNode.CreateTextNodeWrapper);
	}

	public GeckoComment CreateComment(string data)
	{
		return nsString.Pass(_domDocument.CreateComment, data).Wrap(GeckoComment.CreateCommentWrapper);
	}

	public GeckoAttribute CreateAttribute(string name)
	{
		if (string.IsNullOrEmpty(name))
		{
			throw new ArgumentException("name");
		}
		return nsString.Pass(_domDocument.CreateAttribute, name).Wrap(GeckoAttribute.CreateAttributeWrapper);
	}

	public GeckoElementCollection GetElementsByTagName(string tagName)
	{
		if (string.IsNullOrEmpty(tagName))
		{
			return null;
		}
		return nsString.Pass(_domDocument.GetElementsByTagName, tagName).Wrap((nsIDOMNodeList x) => new GeckoElementCollection(x));
	}

	public GeckoNode ImportNode(GeckoNode node, bool deep)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		return _domDocument.ImportNode(node.DomObject, deep, 1).Wrap(GeckoNode.Create);
	}

	public GeckoHtmlElement CreateElement(string namespaceUri, string qualifiedName)
	{
		if (string.IsNullOrEmpty(namespaceUri))
		{
			throw new ArgumentException("namespaceUri");
		}
		if (string.IsNullOrEmpty(qualifiedName))
		{
			throw new ArgumentException("qualifiedName");
		}
		nsIDOMElement nsIDOMElement2 = nsString.Pass(_domDocument.CreateElementNS, namespaceUri, qualifiedName);
		return GeckoHtmlElement.Create((nsIDOMHTMLElement)nsIDOMElement2);
	}

	public GeckoAttribute CreateAttribute(string namespaceUri, string qualifiedName)
	{
		if (string.IsNullOrEmpty(namespaceUri))
		{
			throw new ArgumentException("namespaceUri");
		}
		if (string.IsNullOrEmpty(qualifiedName))
		{
			throw new ArgumentException("qualifiedName");
		}
		return nsString.Pass(_domDocument.CreateAttributeNS, namespaceUri, qualifiedName).Wrap(GeckoAttribute.CreateAttributeWrapper);
	}

	public DomEventArgs CreateEvent(string name)
	{
		nsIDOMEvent obj = nsString.Pass(_domDocument.CreateEvent, name);
		return obj.Wrap(DomEventArgs.Create);
	}

	public GeckoElementCollection GetElementsByTagNameNS(string namespaceUri, string localName)
	{
		if (string.IsNullOrEmpty(namespaceUri))
		{
			throw new ArgumentException("namespaceUri");
		}
		if (string.IsNullOrEmpty(localName))
		{
			throw new ArgumentException("localName");
		}
		nsIDOMNodeList list = nsString.Pass(_domDocument.GetElementsByTagNameNS, namespaceUri, localName);
		return new GeckoElementCollection(list);
	}

	public GeckoElement GetElementById(string id)
	{
		if (string.IsNullOrEmpty(id))
		{
			return null;
		}
		return nsString.Pass(_domDocument.GetElementById, id).Wrap(GeckoElement.CreateDomElementWrapper);
	}

	public GeckoHtmlElement GetHtmlElementById(string id)
	{
		if (string.IsNullOrEmpty(id))
		{
			return null;
		}
		return (GeckoHtmlElement)nsString.Pass(_domDocument.GetElementById, id).Wrap(GeckoNode.Create);
	}

	public GeckoRange CreateRange()
	{
		return new GeckoRange(_domDocument.CreateRange());
	}

	public bool HasFocus()
	{
		return _domDocument.HasFocus();
	}

	public GeckoNodeCollection GetElementsByClassName(string classes)
	{
		nsIDOMNodeList list = nsString.Pass(_domDocument.GetElementsByClassName, classes);
		return GeckoNodeCollection.Create(list);
	}

	public void EnableStyleSheetsForSet(string name)
	{
		nsString.Set(_domDocument.EnableStyleSheetsForSet, name);
	}

	public GeckoElement ElementFromPoint(int x, int y)
	{
		return _domDocument.ElementFromPoint(x, y).Wrap(GeckoElement.CreateDomElementWrapper);
	}

	public void ReleaseCapture()
	{
		_domDocument.ReleaseCapture();
	}

	public void MozCancelFullScreen()
	{
		_domDocument.MozCancelFullScreen();
	}

	public static GeckoDomDocument CreateDomDocumentWraper(nsIDOMDocument domDocument)
	{
		nsIDOMHTMLDocument nsIDOMHTMLDocument2 = Xpcom.QueryInterface<nsIDOMHTMLDocument>(domDocument);
		if (nsIDOMHTMLDocument2 != null)
		{
			Marshal.ReleaseComObject(nsIDOMHTMLDocument2);
			return new GeckoDocument((nsIDOMHTMLDocument)domDocument);
		}
		return new GeckoDomDocument(domDocument);
	}
}
