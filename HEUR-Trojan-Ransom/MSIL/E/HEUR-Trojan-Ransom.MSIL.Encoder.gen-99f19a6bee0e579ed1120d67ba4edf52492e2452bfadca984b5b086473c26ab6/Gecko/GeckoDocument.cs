using System;
using System.Collections;
using System.Collections.Generic;
using Gecko.DOM;

namespace Gecko;

public class GeckoDocument : GeckoDomDocument
{
	public class StyleSheetCollection : IEnumerable<GeckoStyleSheet>, IEnumerable
	{
		private nsIDOMStyleSheetList List;

		public int Count => (int)((List != null) ? List.GetLengthAttribute() : 0);

		public GeckoStyleSheet this[int index]
		{
			get
			{
				if (index < 0 || index >= Count)
				{
					throw new ArgumentOutOfRangeException("index");
				}
				return GeckoStyleSheet.Create((nsIDOMCSSStyleSheet)List.Item((uint)index));
			}
		}

		internal StyleSheetCollection(GeckoDocument document)
		{
			List = document._domHtmlDocument.GetStyleSheetsAttribute();
		}

		public IEnumerator<GeckoStyleSheet> GetEnumerator()
		{
			int length = Count;
			for (int i = 0; i < length; i++)
			{
				yield return GeckoStyleSheet.Create((nsIDOMCSSStyleSheet)List.Item((uint)i));
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			using IEnumerator<GeckoStyleSheet> enumerator = GetEnumerator();
			while (enumerator.MoveNext())
			{
				yield return enumerator.Current;
			}
		}
	}

	private nsIDOMHTMLDocument _domHtmlDocument;

	private StyleSheetCollection _StyleSheets;

	public override GeckoDocument OwnerDocument => this;

	public GeckoHeadElement Head => (_domHtmlDocument == null) ? null : GeckoHtmlElement.Create<GeckoHeadElement>((nsIDOMHTMLElement)_domHtmlDocument.GetHeadAttribute());

	public GeckoHtmlElement Body => (_domHtmlDocument == null) ? null : GeckoHtmlElement.Create<GeckoHtmlElement>(_domHtmlDocument.GetBodyAttribute());

	public StyleSheetCollection StyleSheets => (_StyleSheets == null) ? (_StyleSheets = new StyleSheetCollection(this)) : _StyleSheets;

	public Uri Url => (_domHtmlDocument == null) ? null : new Uri(nsString.Get(_domHtmlDocument.GetURLAttribute));

	public GeckoElementCollection Forms => (_domHtmlDocument == null) ? null : new GeckoHtmlElementCollection(_domHtmlDocument.GetFormsAttribute());

	public GeckoElementCollection Images => (_domHtmlDocument == null) ? null : new GeckoHtmlElementCollection(_domHtmlDocument.GetImagesAttribute());

	public GeckoElementCollection Anchors => (_domHtmlDocument == null) ? null : new GeckoHtmlElementCollection(_domHtmlDocument.GetAnchorsAttribute());

	public GeckoElementCollection Applets => (_domHtmlDocument == null) ? null : new GeckoHtmlElementCollection(_domHtmlDocument.GetAppletsAttribute());

	public GeckoElementCollection Links => (_domHtmlDocument == null) ? null : new GeckoHtmlElementCollection(_domHtmlDocument.GetLinksAttribute());

	public string Cookie
	{
		get
		{
			return (_domHtmlDocument == null) ? null : nsString.Get(_domHtmlDocument.GetCookieAttribute);
		}
		set
		{
			nsString.Set(_domHtmlDocument.SetCookieAttribute, value);
		}
	}

	public string Domain => (_domHtmlDocument == null) ? null : nsString.Get(_domHtmlDocument.GetDomainAttribute);

	internal GeckoDocument(nsIDOMHTMLDocument document)
		: base(document)
	{
		_domHtmlDocument = document;
	}

	internal static GeckoDocument Create(nsIDOMHTMLDocument document)
	{
		return (document == null) ? null : new GeckoDocument(document);
	}

	public GeckoElementCollection GetElementsByName(string name)
	{
		if (string.IsNullOrEmpty(name))
		{
			return null;
		}
		return new GeckoElementCollection(_domHtmlDocument.GetElementsByName(new nsAString(name)));
	}
}
