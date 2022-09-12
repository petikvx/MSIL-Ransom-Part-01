using Gecko.Interop;
using Gecko.WebIDL;

namespace Gecko.DOM.Xul;

public class XulElement : GeckoElement
{
	public GeckoStyle Style => GeckoStyle.Create(Xpcom.QueryInterface<nsIDOMElementCSSInlineStyle>(base.DomObject).GetStyleAttribute());

	public GeckoStyle ComputedStyle
	{
		get
		{
			nsIDOMCSSStyleDeclaration computedStyle;
			using (ComPtr<nsIDOMElement> comPtr = new ComPtr<nsIDOMElement>(Xpcom.QueryInterface<nsIDOMElement>(base.DomObject)))
			{
				Window window = new Window(OwnerDocument.DefaultView.DomWindow, (nsISupports)OwnerDocument.DefaultView.DomWindow);
				computedStyle = window.GetComputedStyle(comPtr.Instance);
			}
			return GeckoStyle.Create(computedStyle);
		}
	}

	protected XulElement(nsIDOMXULElement xulElement)
		: base(xulElement)
	{
	}

	public static XulElement CreateXulElementWrapper(nsIDOMXULElement xulElement)
	{
		return (xulElement == null) ? null : new XulElement(xulElement);
	}
}
