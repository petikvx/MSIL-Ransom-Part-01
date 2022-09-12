namespace Gecko.WebIDL;

public class HTMLElement : WebIDLBase
{
	public string Title
	{
		get
		{
			return GetProperty<string>("title");
		}
		set
		{
			SetProperty("title", value);
		}
	}

	public string Lang
	{
		get
		{
			return GetProperty<string>("lang");
		}
		set
		{
			SetProperty("lang", value);
		}
	}

	public string Dir
	{
		get
		{
			return GetProperty<string>("dir");
		}
		set
		{
			SetProperty("dir", value);
		}
	}

	public nsISupports Dataset => GetProperty<nsISupports>("dataset");

	public string InnerText
	{
		get
		{
			return GetProperty<string>("innerText");
		}
		set
		{
			SetProperty("innerText", value);
		}
	}

	public bool ItemScope
	{
		get
		{
			return GetProperty<bool>("itemScope");
		}
		set
		{
			SetProperty("itemScope", value);
		}
	}

	public nsISupports ItemType => GetProperty<nsISupports>("itemType");

	public string ItemId
	{
		get
		{
			return GetProperty<string>("itemId");
		}
		set
		{
			SetProperty("itemId", value);
		}
	}

	public nsISupports ItemRef => GetProperty<nsISupports>("itemRef");

	public nsISupports ItemProp => GetProperty<nsISupports>("itemProp");

	public nsISupports Properties => GetProperty<nsISupports>("properties");

	public object ItemValue
	{
		get
		{
			return GetProperty<object>("itemValue");
		}
		set
		{
			SetProperty("itemValue", value);
		}
	}

	public bool Hidden
	{
		get
		{
			return GetProperty<bool>("hidden");
		}
		set
		{
			SetProperty("hidden", value);
		}
	}

	public int TabIndex
	{
		get
		{
			return GetProperty<int>("tabIndex");
		}
		set
		{
			SetProperty("tabIndex", value);
		}
	}

	public string AccessKey
	{
		get
		{
			return GetProperty<string>("accessKey");
		}
		set
		{
			SetProperty("accessKey", value);
		}
	}

	public string AccessKeyLabel => GetProperty<string>("accessKeyLabel");

	public bool Draggable
	{
		get
		{
			return GetProperty<bool>("draggable");
		}
		set
		{
			SetProperty("draggable", value);
		}
	}

	public string ContentEditable
	{
		get
		{
			return GetProperty<string>("contentEditable");
		}
		set
		{
			SetProperty("contentEditable", value);
		}
	}

	public bool IsContentEditable => GetProperty<bool>("isContentEditable");

	public nsISupports ContextMenu => GetProperty<nsISupports>("contextMenu");

	public bool Spellcheck
	{
		get
		{
			return GetProperty<bool>("spellcheck");
		}
		set
		{
			SetProperty("spellcheck", value);
		}
	}

	public nsIDOMCSSStyleDeclaration Style => GetProperty<nsIDOMCSSStyleDeclaration>("style");

	public nsIDOMElement OffsetParent => GetProperty<nsIDOMElement>("offsetParent");

	public int OffsetTop => GetProperty<int>("offsetTop");

	public int OffsetLeft => GetProperty<int>("offsetLeft");

	public int OffsetWidth => GetProperty<int>("offsetWidth");

	public int OffsetHeight => GetProperty<int>("offsetHeight");

	public bool Scrollgrab
	{
		get
		{
			return GetProperty<bool>("scrollgrab");
		}
		set
		{
			SetProperty("scrollgrab", value);
		}
	}

	public HTMLElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Click()
	{
		CallVoidMethod("click");
	}

	public void Focus()
	{
		CallVoidMethod("focus");
	}

	public void Blur()
	{
		CallVoidMethod("blur");
	}
}
