using System;
using System.Drawing;
using System.Runtime.InteropServices;
using Gecko.DOM;
using Gecko.Interop;
using Gecko.WebIDL;

namespace Gecko;

public class GeckoHtmlElement : GeckoElement
{
	private nsIDOMHTMLElement _domHtmlElement;

	public nsIDOMHTMLElement DOMHtmlElement => _domHtmlElement;

	public GeckoStyle Style
	{
		get
		{
			nsIDOMElementCSSInlineStyle nsIDOMElementCSSInlineStyle2 = Xpcom.QueryInterface<nsIDOMElementCSSInlineStyle>(base.DomObject);
			if (nsIDOMElementCSSInlineStyle2 == null)
			{
				return null;
			}
			GeckoStyle result = nsIDOMElementCSSInlineStyle2.GetStyleAttribute().Wrap(GeckoStyle.Create);
			Marshal.ReleaseComObject(nsIDOMElementCSSInlineStyle2);
			return result;
		}
	}

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

	public GeckoHtmlElement Parent => Create(Xpcom.QueryInterface<nsIDOMHTMLElement>(_domHtmlElement.GetParentNodeAttribute()));

	public string Id
	{
		get
		{
			return nsString.Get(_domHtmlElement.GetIdAttribute);
		}
		set
		{
			if (string.IsNullOrEmpty(value))
			{
				RemoveAttribute("id");
			}
			else
			{
				nsString.Set(_domHtmlElement.SetIdAttribute, value);
			}
		}
	}

	public string ClassName
	{
		get
		{
			return nsString.Get(_domHtmlElement.GetClassNameAttribute);
		}
		set
		{
			if (string.IsNullOrEmpty(value))
			{
				RemoveAttribute("class");
			}
			else
			{
				nsString.Set(_domHtmlElement.SetClassNameAttribute, value);
			}
		}
	}

	public string AccessKey
	{
		get
		{
			return nsString.Get(_domHtmlElement.GetAccessKeyAttribute);
		}
		set
		{
			_domHtmlElement.SetAccessKeyAttribute(new nsAString(value));
		}
	}

	public bool Draggable
	{
		get
		{
			return _domHtmlElement.GetDraggableAttribute();
		}
		set
		{
			_domHtmlElement.SetDraggableAttribute(value);
		}
	}

	public string ContentEditable
	{
		get
		{
			return nsString.Get(_domHtmlElement.GetContentEditableAttribute);
		}
		set
		{
			nsString.Set(_domHtmlElement.GetContentEditableAttribute, value);
		}
	}

	public Rectangle[] ClientRects
	{
		get
		{
			nsIDOMClientRectList clientRects = DOMHtmlElement.GetClientRects();
			uint lengthAttribute = clientRects.GetLengthAttribute();
			Rectangle[] array = new Rectangle[lengthAttribute];
			for (uint num = 0u; num < lengthAttribute; num++)
			{
				nsIDOMClientRect nsIDOMClientRect2 = clientRects.Item(num);
				array[num] = new Rectangle((int)Math.Round(nsIDOMClientRect2.GetLeftAttribute()), (int)Math.Round(nsIDOMClientRect2.GetTopAttribute()), (int)Math.Round(nsIDOMClientRect2.GetWidthAttribute()), (int)Math.Round(nsIDOMClientRect2.GetHeightAttribute()));
			}
			return array;
		}
	}

	public int OffsetLeft => _domHtmlElement.GetOffsetLeftAttribute();

	public int OffsetTop => _domHtmlElement.GetOffsetTopAttribute();

	public int OffsetWidth => _domHtmlElement.GetOffsetWidthAttribute();

	public int OffsetHeight => _domHtmlElement.GetOffsetHeightAttribute();

	public GeckoHtmlElement OffsetParent => Create((nsIDOMHTMLElement)_domHtmlElement.GetOffsetParentAttribute());

	public bool Spellcheck
	{
		get
		{
			return _domHtmlElement.GetSpellcheckAttribute();
		}
		set
		{
			_domHtmlElement.SetSpellcheckAttribute(value);
		}
	}

	public string InnerHtml
	{
		get
		{
			return nsString.Get(_domHtmlElement.GetInnerHTMLAttribute);
		}
		set
		{
			nsString.Set(_domHtmlElement.SetInnerHTMLAttribute, value);
		}
	}

	public virtual string OuterHtml => nsString.Get(_domHtmlElement.GetOuterHTMLAttribute);

	public int TabIndex
	{
		get
		{
			return _domHtmlElement.GetTabIndexAttribute();
		}
		set
		{
			_domHtmlElement.SetTabIndexAttribute(value);
		}
	}

	internal GeckoHtmlElement(nsIDOMHTMLElement element)
		: base(element)
	{
		_domHtmlElement = element;
	}

	internal GeckoHtmlElement(object element)
		: base(element)
	{
		if (!(element is nsIDOMHTMLElement))
		{
			throw new ArgumentException("element is not a nsIDOMHTMLElement");
		}
		_domHtmlElement = (nsIDOMHTMLElement)element;
	}

	internal static GeckoHtmlElement Create(nsIDOMHTMLElement element)
	{
		return (element == null) ? null : DOMSelector.GetClassFor(element);
	}

	internal static T Create<T>(nsIDOMHTMLElement element) where T : GeckoHtmlElement
	{
		return (element == null) ? null : DOMSelector.GetClassFor<T>(element);
	}

	public void Blur()
	{
		_domHtmlElement.Blur();
	}

	public void Focus()
	{
		_domHtmlElement.Focus();
	}

	public void Click()
	{
		_domHtmlElement.Click();
	}

	public void ScrollIntoView(bool top)
	{
		_domHtmlElement.ScrollIntoView(top, 1);
	}

	public void InsertAdjacentHTML(string position, string text)
	{
		using nsAString position2 = new nsAString(position);
		using nsAString text2 = new nsAString(text);
		_domHtmlElement.InsertAdjacentHTML(position2, text2);
	}

	public void MozRequestFullScreen()
	{
		_domHtmlElement.MozRequestFullScreen();
	}
}
