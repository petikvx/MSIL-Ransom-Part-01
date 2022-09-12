namespace Gecko.WebIDL;

public class HTMLSelectElement : WebIDLBase
{
	public bool Autofocus
	{
		get
		{
			return GetProperty<bool>("autofocus");
		}
		set
		{
			SetProperty("autofocus", value);
		}
	}

	public string Autocomplete
	{
		get
		{
			return GetProperty<string>("autocomplete");
		}
		set
		{
			SetProperty("autocomplete", value);
		}
	}

	public bool Disabled
	{
		get
		{
			return GetProperty<bool>("disabled");
		}
		set
		{
			SetProperty("disabled", value);
		}
	}

	public nsISupports Form => GetProperty<nsISupports>("form");

	public bool Multiple
	{
		get
		{
			return GetProperty<bool>("multiple");
		}
		set
		{
			SetProperty("multiple", value);
		}
	}

	public string Name
	{
		get
		{
			return GetProperty<string>("name");
		}
		set
		{
			SetProperty("name", value);
		}
	}

	public bool Required
	{
		get
		{
			return GetProperty<bool>("required");
		}
		set
		{
			SetProperty("required", value);
		}
	}

	public uint Size
	{
		get
		{
			return GetProperty<uint>("size");
		}
		set
		{
			SetProperty("size", value);
		}
	}

	public string Type => GetProperty<string>("type");

	public nsISupports Options => GetProperty<nsISupports>("options");

	public uint Length
	{
		get
		{
			return GetProperty<uint>("length");
		}
		set
		{
			SetProperty("length", value);
		}
	}

	public nsISupports SelectedOptions => GetProperty<nsISupports>("selectedOptions");

	public int SelectedIndex
	{
		get
		{
			return GetProperty<int>("selectedIndex");
		}
		set
		{
			SetProperty("selectedIndex", value);
		}
	}

	public string Value
	{
		get
		{
			return GetProperty<string>("value");
		}
		set
		{
			SetProperty("value", value);
		}
	}

	public bool WillValidate => GetProperty<bool>("willValidate");

	public nsISupports Validity => GetProperty<nsISupports>("validity");

	public string ValidationMessage => GetProperty<string>("validationMessage");

	public HTMLSelectElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports NamedItem(string name)
	{
		return CallMethod<nsISupports>("namedItem", new object[1] { name });
	}

	public void Add(WebIDLUnion<nsISupports, nsISupports> element)
	{
		CallVoidMethod("add", element);
	}

	public void Add(WebIDLUnion<nsISupports, nsISupports> element, WebIDLUnion<nsISupports, int> before)
	{
		CallVoidMethod("add", element, before);
	}

	public void Remove(int index)
	{
		CallVoidMethod("remove", index);
	}
}
