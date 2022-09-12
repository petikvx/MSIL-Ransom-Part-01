using System;
using System.Runtime.InteropServices;
using Gecko.Collections;
using Gecko.DOM;
using Gecko.DOM.Svg;
using Gecko.DOM.Xul;
using Gecko.Interop;

namespace Gecko;

public class GeckoElement : GeckoNode
{
	private nsIDOMElement _domElement;

	private string m_cachedTagName;

	public nsIDOMElement DOMElement => _domElement;

	public string TagName
	{
		get
		{
			if (m_cachedTagName != null)
			{
				return m_cachedTagName;
			}
			return m_cachedTagName = nsString.Get(_domElement.GetTagNameAttribute);
		}
	}

	public GeckoNamedNodeMap Attributes => _domElement.GetAttributesAttribute().Wrap((nsIDOMMozNamedAttrMap x) => new GeckoNamedNodeMap(x));

	public bool HasAttributes => _domElement.HasAttributes();

	public int ScrollLeft
	{
		get
		{
			return _domElement.GetScrollLeftAttribute();
		}
		set
		{
			_domElement.SetScrollLeftAttribute(value);
		}
	}

	public int ScrollTop
	{
		get
		{
			return _domElement.GetScrollTopAttribute();
		}
		set
		{
			_domElement.SetScrollTopAttribute(value);
		}
	}

	public int ScrollWidth => _domElement.GetScrollWidthAttribute();

	public int ScrollHeight => _domElement.GetScrollHeightAttribute();

	public int ClientWidth => _domElement.GetClientWidthAttribute();

	public int ClientHeight => _domElement.GetClientHeightAttribute();

	internal GeckoElement(nsIDOMElement domElement)
		: base(domElement)
	{
		_domElement = domElement;
	}

	internal GeckoElement(object domElement)
		: base(domElement)
	{
		if (!(domElement is nsIDOMElement))
		{
			throw new ArgumentException("domDlement is not a nsIDOMElement");
		}
		_domElement = (nsIDOMElement)domElement;
	}

	public string GetAttribute(string attributeName)
	{
		if (string.IsNullOrEmpty(attributeName))
		{
			throw new ArgumentException("attributeName");
		}
		return nsString.Get(_domElement.GetAttribute, attributeName);
	}

	public bool HasAttribute(string attributeName)
	{
		if (string.IsNullOrEmpty(attributeName))
		{
			throw new ArgumentException("attributeName");
		}
		return nsString.Pass(_domElement.HasAttribute, attributeName);
	}

	public void SetAttribute(string attributeName, string value)
	{
		if (string.IsNullOrEmpty(attributeName))
		{
			throw new ArgumentException("attributeName");
		}
		nsString.Set(_domElement.SetAttribute, attributeName, value);
	}

	public void RemoveAttribute(string attributeName)
	{
		if (string.IsNullOrEmpty(attributeName))
		{
			throw new ArgumentException("attributeName");
		}
		nsString.Set(_domElement.RemoveAttribute, attributeName);
	}

	public GeckoAttribute GetAttributeNode(string name)
	{
		nsIDOMAttr nsIDOMAttr2 = nsString.Pass(_domElement.GetAttributeNode, name);
		return (nsIDOMAttr2 == null) ? null : new GeckoAttribute(nsIDOMAttr2);
	}

	public GeckoAttribute SetAttributeNode(GeckoAttribute newAttr)
	{
		nsIDOMAttr nsIDOMAttr2 = _domElement.SetAttributeNode(newAttr.DomAttr);
		return (nsIDOMAttr2 == null) ? null : new GeckoAttribute(nsIDOMAttr2);
	}

	public GeckoAttribute RemoveAttributeNode(GeckoAttribute newAttr)
	{
		nsIDOMAttr nsIDOMAttr2 = _domElement.RemoveAttributeNode(newAttr.DomAttr);
		return (nsIDOMAttr2 == null) ? null : new GeckoAttribute(nsIDOMAttr2);
	}

	public bool HasAttributeNS(string namespaceUri, string attributeName)
	{
		if (string.IsNullOrEmpty(namespaceUri))
		{
			return HasAttribute(attributeName);
		}
		if (string.IsNullOrEmpty(attributeName))
		{
			throw new ArgumentException("attributeName");
		}
		return nsString.Pass(_domElement.HasAttributeNS, namespaceUri, attributeName);
	}

	public string GetAttributeNS(string namespaceUri, string attributeName)
	{
		if (string.IsNullOrEmpty(namespaceUri))
		{
			return GetAttribute(attributeName);
		}
		if (string.IsNullOrEmpty(attributeName))
		{
			throw new ArgumentException("attributeName");
		}
		nsAString nsAString2 = new nsAString();
		_domElement.GetAttributeNS(new nsAString(namespaceUri), new nsAString(attributeName), nsAString2);
		return nsAString2.ToString();
	}

	public void SetAttributeNS(string namespaceUri, string attributeName, string value)
	{
		if (string.IsNullOrEmpty(namespaceUri))
		{
			SetAttribute(attributeName, value);
			return;
		}
		if (string.IsNullOrEmpty(attributeName))
		{
			throw new ArgumentException("attributeName");
		}
		_domElement.SetAttributeNS(new nsAString(namespaceUri), new nsAString(attributeName), new nsAString(value));
	}

	public GeckoAttribute GetAttributeNodeNS(string namespaceUri, string localName)
	{
		if (string.IsNullOrEmpty(namespaceUri))
		{
			return GetAttributeNode(localName);
		}
		nsIDOMAttr nsIDOMAttr2 = nsString.Pass(_domElement.GetAttributeNodeNS, namespaceUri, localName);
		return (nsIDOMAttr2 == null) ? null : new GeckoAttribute(nsIDOMAttr2);
	}

	public GeckoAttribute SetAttributeNodeNS(GeckoAttribute attribute)
	{
		nsIDOMAttr nsIDOMAttr2 = _domElement.SetAttributeNodeNS(attribute.DomAttr);
		return (nsIDOMAttr2 == null) ? null : new GeckoAttribute(nsIDOMAttr2);
	}

	public IDomHtmlCollection<GeckoElement> GetElementsByTagName(string tagName)
	{
		if (string.IsNullOrEmpty(tagName))
		{
			return null;
		}
		return nsString.Pass(_domElement.GetElementsByTagName, tagName).Wrap((nsIDOMHTMLCollection x) => new DomHtmlCollection<GeckoElement, nsIDOMHTMLElement>(x, CreateDomElementWrapper));
	}

	public IDomHtmlCollection<GeckoElement> GetElementsByTagNameNS(string namespaceURI, string localName)
	{
		if (string.IsNullOrEmpty(namespaceURI))
		{
			return GetElementsByTagName(localName);
		}
		if (string.IsNullOrEmpty(localName))
		{
			return null;
		}
		return nsString.Pass(_domElement.GetElementsByTagNameNS, namespaceURI, localName).Wrap((nsIDOMHTMLCollection x) => new DomHtmlCollection<GeckoElement, nsIDOMHTMLElement>(x, CreateDomElementWrapper));
	}

	public static GeckoElement CreateDomElementWrapper(nsIDOMElement element)
	{
		if (element == null)
		{
			return null;
		}
		nsIDOMHTMLElement nsIDOMHTMLElement2 = Xpcom.QueryInterface<nsIDOMHTMLElement>(element);
		if (nsIDOMHTMLElement2 != null)
		{
			Marshal.ReleaseComObject(nsIDOMHTMLElement2);
			return GeckoHtmlElement.Create((nsIDOMHTMLElement)element);
		}
		nsIDOMSVGElement nsIDOMSVGElement2 = Xpcom.QueryInterface<nsIDOMSVGElement>(element);
		if (nsIDOMSVGElement2 != null)
		{
			Marshal.ReleaseComObject(nsIDOMSVGElement2);
			return SvgElement.CreateSvgElementWrapper((nsIDOMSVGElement)element);
		}
		nsIDOMXULElement nsIDOMXULElement2 = Xpcom.QueryInterface<nsIDOMXULElement>(element);
		if (nsIDOMXULElement2 != null)
		{
			Marshal.ReleaseComObject(nsIDOMXULElement2);
			return XulElement.CreateXulElementWrapper((nsIDOMXULElement)element);
		}
		return new GeckoElement(element);
	}

	public GeckoElement QuerySelector(string selectors)
	{
		return nsString.Pass(_domElement.QuerySelector, selectors).Wrap(CreateDomElementWrapper);
	}
}
