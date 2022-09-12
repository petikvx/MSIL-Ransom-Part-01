namespace Gecko.WebIDL;

public class HTMLFormElement : WebIDLBase
{
	public string AcceptCharset
	{
		get
		{
			return GetProperty<string>("acceptCharset");
		}
		set
		{
			SetProperty("acceptCharset", value);
		}
	}

	public string Action
	{
		get
		{
			return GetProperty<string>("action");
		}
		set
		{
			SetProperty("action", value);
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

	public string Enctype
	{
		get
		{
			return GetProperty<string>("enctype");
		}
		set
		{
			SetProperty("enctype", value);
		}
	}

	public string Encoding
	{
		get
		{
			return GetProperty<string>("encoding");
		}
		set
		{
			SetProperty("encoding", value);
		}
	}

	public string Method
	{
		get
		{
			return GetProperty<string>("method");
		}
		set
		{
			SetProperty("method", value);
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

	public bool NoValidate
	{
		get
		{
			return GetProperty<bool>("noValidate");
		}
		set
		{
			SetProperty("noValidate", value);
		}
	}

	public string Target
	{
		get
		{
			return GetProperty<string>("target");
		}
		set
		{
			SetProperty("target", value);
		}
	}

	public nsISupports Elements => GetProperty<nsISupports>("elements");

	public int Length => GetProperty<int>("length");

	public HTMLFormElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Submit()
	{
		CallVoidMethod("submit");
	}

	public void Reset()
	{
		CallVoidMethod("reset");
	}

	public bool CheckValidity()
	{
		return CallMethod<bool>("checkValidity", new object[0]);
	}

	public void RequestAutocomplete()
	{
		CallVoidMethod("requestAutocomplete");
	}
}
