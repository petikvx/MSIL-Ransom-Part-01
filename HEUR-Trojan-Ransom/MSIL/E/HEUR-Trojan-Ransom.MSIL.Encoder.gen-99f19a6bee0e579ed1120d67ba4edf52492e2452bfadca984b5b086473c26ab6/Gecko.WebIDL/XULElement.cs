namespace Gecko.WebIDL;

public class XULElement : WebIDLBase
{
	public string ClassName
	{
		get
		{
			return GetProperty<string>("className");
		}
		set
		{
			SetProperty("className", value);
		}
	}

	public string Align
	{
		get
		{
			return GetProperty<string>("align");
		}
		set
		{
			SetProperty("align", value);
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

	public string Flex
	{
		get
		{
			return GetProperty<string>("flex");
		}
		set
		{
			SetProperty("flex", value);
		}
	}

	public string FlexGroup
	{
		get
		{
			return GetProperty<string>("flexGroup");
		}
		set
		{
			SetProperty("flexGroup", value);
		}
	}

	public string Ordinal
	{
		get
		{
			return GetProperty<string>("ordinal");
		}
		set
		{
			SetProperty("ordinal", value);
		}
	}

	public string Orient
	{
		get
		{
			return GetProperty<string>("orient");
		}
		set
		{
			SetProperty("orient", value);
		}
	}

	public string Pack
	{
		get
		{
			return GetProperty<string>("pack");
		}
		set
		{
			SetProperty("pack", value);
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

	public bool Collapsed
	{
		get
		{
			return GetProperty<bool>("collapsed");
		}
		set
		{
			SetProperty("collapsed", value);
		}
	}

	public string Observes
	{
		get
		{
			return GetProperty<string>("observes");
		}
		set
		{
			SetProperty("observes", value);
		}
	}

	public string Menu
	{
		get
		{
			return GetProperty<string>("menu");
		}
		set
		{
			SetProperty("menu", value);
		}
	}

	public string ContextMenu
	{
		get
		{
			return GetProperty<string>("contextMenu");
		}
		set
		{
			SetProperty("contextMenu", value);
		}
	}

	public string Tooltip
	{
		get
		{
			return GetProperty<string>("tooltip");
		}
		set
		{
			SetProperty("tooltip", value);
		}
	}

	public string Width
	{
		get
		{
			return GetProperty<string>("width");
		}
		set
		{
			SetProperty("width", value);
		}
	}

	public string Height
	{
		get
		{
			return GetProperty<string>("height");
		}
		set
		{
			SetProperty("height", value);
		}
	}

	public string MinWidth
	{
		get
		{
			return GetProperty<string>("minWidth");
		}
		set
		{
			SetProperty("minWidth", value);
		}
	}

	public string MinHeight
	{
		get
		{
			return GetProperty<string>("minHeight");
		}
		set
		{
			SetProperty("minHeight", value);
		}
	}

	public string MaxWidth
	{
		get
		{
			return GetProperty<string>("maxWidth");
		}
		set
		{
			SetProperty("maxWidth", value);
		}
	}

	public string MaxHeight
	{
		get
		{
			return GetProperty<string>("maxHeight");
		}
		set
		{
			SetProperty("maxHeight", value);
		}
	}

	public string Persist
	{
		get
		{
			return GetProperty<string>("persist");
		}
		set
		{
			SetProperty("persist", value);
		}
	}

	public string Left
	{
		get
		{
			return GetProperty<string>("left");
		}
		set
		{
			SetProperty("left", value);
		}
	}

	public string Top
	{
		get
		{
			return GetProperty<string>("top");
		}
		set
		{
			SetProperty("top", value);
		}
	}

	public string Datasources
	{
		get
		{
			return GetProperty<string>("datasources");
		}
		set
		{
			SetProperty("datasources", value);
		}
	}

	public string Ref
	{
		get
		{
			return GetProperty<string>("ref");
		}
		set
		{
			SetProperty("ref", value);
		}
	}

	public string TooltipText
	{
		get
		{
			return GetProperty<string>("tooltipText");
		}
		set
		{
			SetProperty("tooltipText", value);
		}
	}

	public string StatusText
	{
		get
		{
			return GetProperty<string>("statusText");
		}
		set
		{
			SetProperty("statusText", value);
		}
	}

	public bool AllowEvents
	{
		get
		{
			return GetProperty<bool>("allowEvents");
		}
		set
		{
			SetProperty("allowEvents", value);
		}
	}

	public nsISupports Database => GetProperty<nsISupports>("database");

	public nsISupports Builder => GetProperty<nsISupports>("builder");

	public nsISupports Resource => GetProperty<nsISupports>("resource");

	public nsISupports Controllers => GetProperty<nsISupports>("controllers");

	public nsISupports BoxObject => GetProperty<nsISupports>("boxObject");

	public nsIDOMCSSStyleDeclaration Style => GetProperty<nsIDOMCSSStyleDeclaration>("style");

	public XULElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Focus()
	{
		CallVoidMethod("focus");
	}

	public void Blur()
	{
		CallVoidMethod("blur");
	}

	public void Click()
	{
		CallVoidMethod("click");
	}

	public void DoCommand()
	{
		CallVoidMethod("doCommand");
	}

	public nsISupports GetElementsByAttribute(string name, string value)
	{
		return CallMethod<nsISupports>("getElementsByAttribute", new object[2] { name, value });
	}

	public nsISupports GetElementsByAttributeNS(string namespaceURI, string name, string value)
	{
		return CallMethod<nsISupports>("getElementsByAttributeNS", new object[3] { namespaceURI, name, value });
	}
}
