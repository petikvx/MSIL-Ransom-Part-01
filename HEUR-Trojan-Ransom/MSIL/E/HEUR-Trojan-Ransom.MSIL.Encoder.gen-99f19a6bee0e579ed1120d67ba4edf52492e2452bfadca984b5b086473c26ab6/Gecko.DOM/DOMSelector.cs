using System;
using System.Collections.Generic;

namespace Gecko.DOM;

internal static class DOMSelector
{
	private struct GeckoClassDesc
	{
		public delegate GeckoHtmlElement ObjectCreator(object htmlElementInterface);

		public string TagName { get; set; }

		public Type InterfaceType { get; set; }

		public Type GeckoElement { get; set; }

		public ObjectCreator CreationMethod { get; set; }
	}

	private static readonly Dictionary<string, GeckoClassDesc> _dictionary;

	private static GeckoWrapperCache<nsIDOMHTMLElement, GeckoHtmlElement> m_cache;

	private static void Add(GeckoClassDesc classDesc)
	{
		_dictionary.Add(classDesc.TagName.ToLowerInvariant(), classDesc);
	}

	static DOMSelector()
	{
		_dictionary = new Dictionary<string, GeckoClassDesc>();
		m_cache = new GeckoWrapperCache<nsIDOMHTMLElement, GeckoHtmlElement>(CreateDomHtmlElementWrapper);
		Add(new GeckoClassDesc
		{
			TagName = "a",
			InterfaceType = typeof(nsIDOMHTMLAnchorElement),
			GeckoElement = typeof(GeckoAnchorElement),
			CreationMethod = (object x) => new GeckoAnchorElement((nsIDOMHTMLAnchorElement)x)
		});
		Add(new GeckoClassDesc
		{
			TagName = "applet",
			InterfaceType = typeof(nsIDOMHTMLAppletElement),
			GeckoElement = typeof(GeckoAppletElement),
			CreationMethod = (object x) => new GeckoAppletElement((nsIDOMHTMLAppletElement)x)
		});
		Add(new GeckoClassDesc
		{
			TagName = "area",
			InterfaceType = typeof(nsIDOMHTMLAreaElement),
			GeckoElement = typeof(GeckoAreaElement),
			CreationMethod = (object x) => new GeckoAreaElement((nsIDOMHTMLAreaElement)x)
		});
		Add(new GeckoClassDesc
		{
			TagName = "base",
			InterfaceType = typeof(nsIDOMHTMLBaseElement),
			GeckoElement = typeof(GeckoBaseElement),
			CreationMethod = (object x) => new GeckoBaseElement((nsIDOMHTMLBaseElement)x)
		});
		Add(new GeckoClassDesc
		{
			TagName = "body",
			InterfaceType = typeof(nsIDOMHTMLBodyElement),
			GeckoElement = typeof(GeckoBodyElement),
			CreationMethod = (object x) => new GeckoBodyElement((nsIDOMHTMLBodyElement)x)
		});
		Add(new GeckoClassDesc
		{
			TagName = "button",
			InterfaceType = typeof(nsIDOMHTMLButtonElement),
			GeckoElement = typeof(GeckoButtonElement),
			CreationMethod = (object x) => new GeckoButtonElement((nsIDOMHTMLButtonElement)x)
		});
		Add(new GeckoClassDesc
		{
			TagName = "canvas",
			InterfaceType = typeof(nsIDOMHTMLCanvasElement),
			GeckoElement = typeof(GeckoCanvasElement),
			CreationMethod = (object x) => new GeckoCanvasElement((nsIDOMHTMLCanvasElement)x)
		});
		Add(new GeckoClassDesc
		{
			TagName = "dir",
			InterfaceType = typeof(nsIDOMHTMLDirectoryElement),
			GeckoElement = typeof(GeckoDirectoryElement),
			CreationMethod = (object x) => new GeckoDirectoryElement((nsIDOMHTMLDirectoryElement)x)
		});
		Add(new GeckoClassDesc
		{
			TagName = "embed",
			InterfaceType = typeof(nsIDOMHTMLEmbedElement),
			GeckoElement = typeof(GeckoEmbedElement),
			CreationMethod = (object x) => new GeckoEmbedElement((nsIDOMHTMLEmbedElement)x)
		});
		Add(new GeckoClassDesc
		{
			TagName = "fieldset",
			InterfaceType = typeof(nsIDOMHTMLFieldSetElement),
			GeckoElement = typeof(GeckoFieldSetElement),
			CreationMethod = (object x) => new GeckoFieldSetElement((nsIDOMHTMLFieldSetElement)x)
		});
		Add(new GeckoClassDesc
		{
			TagName = "form",
			InterfaceType = typeof(nsIDOMHTMLFormElement),
			GeckoElement = typeof(GeckoFormElement),
			CreationMethod = (object x) => new GeckoFormElement((nsIDOMHTMLFormElement)x)
		});
		Add(new GeckoClassDesc
		{
			TagName = "frame",
			InterfaceType = typeof(nsIDOMHTMLFrameElement),
			GeckoElement = typeof(GeckoFrameElement),
			CreationMethod = (object x) => new GeckoFrameElement((nsIDOMHTMLFrameElement)x)
		});
		Add(new GeckoClassDesc
		{
			TagName = "frameset",
			InterfaceType = typeof(nsIDOMHTMLFrameSetElement),
			GeckoElement = typeof(GeckoFrameSetElement),
			CreationMethod = (object x) => new GeckoFrameSetElement((nsIDOMHTMLFrameSetElement)x)
		});
		Add(new GeckoClassDesc
		{
			TagName = "head",
			InterfaceType = typeof(nsIDOMHTMLHeadElement),
			GeckoElement = typeof(GeckoHeadElement),
			CreationMethod = (object x) => new GeckoHeadElement((nsIDOMHTMLHeadElement)x)
		});
		Add(new GeckoClassDesc
		{
			TagName = "hr",
			InterfaceType = typeof(nsIDOMHTMLHRElement),
			GeckoElement = typeof(GeckoHRElement),
			CreationMethod = (object x) => new GeckoHRElement((nsIDOMHTMLHRElement)x)
		});
		Add(new GeckoClassDesc
		{
			TagName = "html",
			InterfaceType = typeof(nsIDOMHTMLHtmlElement),
			GeckoElement = typeof(GeckoHtmlHtmlElement),
			CreationMethod = (object x) => new GeckoHtmlHtmlElement((nsIDOMHTMLHtmlElement)x)
		});
		Add(new GeckoClassDesc
		{
			TagName = "iframe",
			InterfaceType = typeof(nsIDOMHTMLIFrameElement),
			GeckoElement = typeof(GeckoIFrameElement),
			CreationMethod = (object x) => new GeckoIFrameElement((nsIDOMHTMLIFrameElement)x)
		});
		Add(new GeckoClassDesc
		{
			TagName = "img",
			InterfaceType = typeof(nsIDOMHTMLImageElement),
			GeckoElement = typeof(GeckoImageElement),
			CreationMethod = (object x) => new GeckoImageElement((nsIDOMHTMLImageElement)x)
		});
		Add(new GeckoClassDesc
		{
			TagName = "input",
			InterfaceType = typeof(nsIDOMHTMLInputElement),
			GeckoElement = typeof(GeckoInputElement),
			CreationMethod = (object x) => new GeckoInputElement((nsIDOMHTMLInputElement)x)
		});
		Add(new GeckoClassDesc
		{
			TagName = "label",
			InterfaceType = typeof(nsIDOMHTMLLabelElement),
			GeckoElement = typeof(GeckoLabelElement),
			CreationMethod = (object x) => new GeckoLabelElement((nsIDOMHTMLLabelElement)x)
		});
		Add(new GeckoClassDesc
		{
			TagName = "li",
			InterfaceType = typeof(nsIDOMHTMLLIElement),
			GeckoElement = typeof(GeckoLIElement),
			CreationMethod = (object x) => new GeckoLIElement((nsIDOMHTMLLIElement)x)
		});
		Add(new GeckoClassDesc
		{
			TagName = "link",
			InterfaceType = typeof(nsIDOMHTMLLinkElement),
			GeckoElement = typeof(GeckoLinkElement),
			CreationMethod = (object x) => new GeckoLinkElement((nsIDOMHTMLLinkElement)x)
		});
		Add(new GeckoClassDesc
		{
			TagName = "map",
			InterfaceType = typeof(nsIDOMHTMLMapElement),
			GeckoElement = typeof(GeckoMapElement),
			CreationMethod = (object x) => new GeckoMapElement((nsIDOMHTMLMapElement)x)
		});
		Add(new GeckoClassDesc
		{
			TagName = "menu",
			InterfaceType = typeof(nsIDOMHTMLMenuElement),
			GeckoElement = typeof(GeckoMenuElement),
			CreationMethod = (object x) => new GeckoMenuElement((nsIDOMHTMLMenuElement)x)
		});
		Add(new GeckoClassDesc
		{
			TagName = "meta",
			InterfaceType = typeof(nsIDOMHTMLMetaElement),
			GeckoElement = typeof(GeckoMetaElement),
			CreationMethod = (object x) => new GeckoMetaElement((nsIDOMHTMLMetaElement)x)
		});
		Add(new GeckoClassDesc
		{
			TagName = "object",
			InterfaceType = typeof(nsIDOMHTMLObjectElement),
			GeckoElement = typeof(GeckoObjectElement),
			CreationMethod = (object x) => new GeckoObjectElement((nsIDOMHTMLObjectElement)x)
		});
		Add(new GeckoClassDesc
		{
			TagName = "ol",
			InterfaceType = typeof(nsIDOMHTMLOListElement),
			GeckoElement = typeof(GeckoOListElement),
			CreationMethod = (object x) => new GeckoOListElement((nsIDOMHTMLOListElement)x)
		});
		Add(new GeckoClassDesc
		{
			TagName = "optgroup",
			InterfaceType = typeof(nsIDOMHTMLOptGroupElement),
			GeckoElement = typeof(GeckoOptGroupElement),
			CreationMethod = (object x) => new GeckoOptGroupElement((nsIDOMHTMLOptGroupElement)x)
		});
		Add(new GeckoClassDesc
		{
			TagName = "option",
			InterfaceType = typeof(nsIDOMHTMLOptionElement),
			GeckoElement = typeof(GeckoOptionElement),
			CreationMethod = (object x) => new GeckoOptionElement((nsIDOMHTMLOptionElement)x)
		});
		Add(new GeckoClassDesc
		{
			TagName = "p",
			InterfaceType = typeof(nsIDOMHTMLParagraphElement),
			GeckoElement = typeof(GeckoParagraphElement),
			CreationMethod = (object x) => new GeckoParagraphElement((nsIDOMHTMLParagraphElement)x)
		});
		Add(new GeckoClassDesc
		{
			TagName = "pre",
			InterfaceType = typeof(nsIDOMHTMLPreElement),
			GeckoElement = typeof(GeckoPreElement),
			CreationMethod = (object x) => new GeckoPreElement((nsIDOMHTMLPreElement)x)
		});
		Add(new GeckoClassDesc
		{
			TagName = "q",
			InterfaceType = typeof(nsIDOMHTMLQuoteElement),
			GeckoElement = typeof(GeckoQuoteElement),
			CreationMethod = (object x) => new GeckoQuoteElement((nsIDOMHTMLQuoteElement)x)
		});
		Add(new GeckoClassDesc
		{
			TagName = "script",
			InterfaceType = typeof(nsIDOMHTMLScriptElement),
			GeckoElement = typeof(GeckoScriptElement),
			CreationMethod = (object x) => new GeckoScriptElement((nsIDOMHTMLScriptElement)x)
		});
		Add(new GeckoClassDesc
		{
			TagName = "select",
			InterfaceType = typeof(nsIDOMHTMLSelectElement),
			GeckoElement = typeof(GeckoSelectElement),
			CreationMethod = (object x) => new GeckoSelectElement((nsIDOMHTMLSelectElement)x)
		});
		Add(new GeckoClassDesc
		{
			TagName = "style",
			InterfaceType = typeof(nsIDOMHTMLStyleElement),
			GeckoElement = typeof(GeckoStyleElement),
			CreationMethod = (object x) => new GeckoStyleElement((nsIDOMHTMLStyleElement)x)
		});
		Add(new GeckoClassDesc
		{
			TagName = "td",
			InterfaceType = typeof(nsIDOMHTMLTableCellElement),
			GeckoElement = typeof(GeckoTableCellElement),
			CreationMethod = (object x) => new GeckoTableCellElement((nsIDOMHTMLTableCellElement)x)
		});
		Add(new GeckoClassDesc
		{
			TagName = "textarea",
			InterfaceType = typeof(nsIDOMHTMLTextAreaElement),
			GeckoElement = typeof(GeckoTextAreaElement),
			CreationMethod = (object x) => new GeckoTextAreaElement((nsIDOMHTMLTextAreaElement)x)
		});
		Add(new GeckoClassDesc
		{
			TagName = "ul",
			InterfaceType = typeof(nsIDOMHTMLUListElement),
			GeckoElement = typeof(GeckoUListElement),
			CreationMethod = (object x) => new GeckoUListElement((nsIDOMHTMLUListElement)x)
		});
	}

	internal static GeckoHtmlElement GetClassFor(nsIDOMHTMLElement element)
	{
		GeckoHtmlElement geckoHtmlElement = GetClassFor<GeckoHtmlElement>(element);
		if (geckoHtmlElement == null)
		{
			geckoHtmlElement = new GeckoHtmlElement(element);
		}
		return geckoHtmlElement;
	}

	internal static T GetClassFor<T>(nsIDOMHTMLElement element) where T : GeckoHtmlElement
	{
		return (T)m_cache.Get(element);
	}

	internal static GeckoNode CreateDomNodeWrapper(nsIDOMNode domObject)
	{
		if (domObject == null)
		{
			return null;
		}
		switch (domObject.GetNodeTypeAttribute())
		{
		case 2:
		{
			nsIDOMAttr nsIDOMAttr = Xpcom.QueryInterface<nsIDOMAttr>(domObject);
			if (nsIDOMAttr != null)
			{
				return GeckoAttribute.CreateAttributeWrapper(nsIDOMAttr);
			}
			break;
		}
		case 1:
		{
			nsIDOMHTMLElement nsIDOMHTMLElement = Xpcom.QueryInterface<nsIDOMHTMLElement>(domObject);
			if (nsIDOMHTMLElement != null)
			{
				return GeckoHtmlElement.Create(nsIDOMHTMLElement);
			}
			nsIDOMElement nsIDOMElement = Xpcom.QueryInterface<nsIDOMElement>(domObject);
			if (nsIDOMElement != null)
			{
				return GeckoElement.CreateDomElementWrapper(nsIDOMElement);
			}
			break;
		}
		case 11:
		{
			nsIDOMDocumentFragment nsIDOMDocumentFragment = Xpcom.QueryInterface<nsIDOMDocumentFragment>(domObject);
			if (nsIDOMDocumentFragment != null)
			{
				return DocumentFragment.CreateDocumentFragmentWrapper(nsIDOMDocumentFragment);
			}
			break;
		}
		case 8:
		{
			nsIDOMComment nsIDOMComment = Xpcom.QueryInterface<nsIDOMComment>(domObject);
			if (nsIDOMComment != null)
			{
				return GeckoComment.CreateCommentWrapper(nsIDOMComment);
			}
			break;
		}
		}
		return new GeckoNode(domObject);
	}

	internal static GeckoHtmlElement CreateDomHtmlElementWrapper(nsIDOMHTMLElement instance)
	{
		string key = nsString.Get(instance.GetTagNameAttribute).ToLowerInvariant();
		if (_dictionary.TryGetValue(key, out var value))
		{
			object obj = Xpcom.QueryInterface(instance, value.InterfaceType.GUID);
			if (obj != null)
			{
				return value.CreationMethod(obj);
			}
		}
		return null;
	}
}
