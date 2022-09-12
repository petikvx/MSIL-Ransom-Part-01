namespace Gecko.WebIDL;

public class HTMLButtonElement : WebIDLBase
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

	public string FormAction
	{
		get
		{
			return GetProperty<string>("formAction");
		}
		set
		{
			SetProperty("formAction", value);
		}
	}

	public string FormEnctype
	{
		get
		{
			return GetProperty<string>("formEnctype");
		}
		set
		{
			SetProperty("formEnctype", value);
		}
	}

	public string FormMethod
	{
		get
		{
			return GetProperty<string>("formMethod");
		}
		set
		{
			SetProperty("formMethod", value);
		}
	}

	public bool FormNoValidate
	{
		get
		{
			return GetProperty<bool>("formNoValidate");
		}
		set
		{
			SetProperty("formNoValidate", value);
		}
	}

	public string FormTarget
	{
		get
		{
			return GetProperty<string>("formTarget");
		}
		set
		{
			SetProperty("formTarget", value);
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

	public string Type
	{
		get
		{
			return GetProperty<string>("type");
		}
		set
		{
			SetProperty("type", value);
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

	public HTMLButtonElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public bool CheckValidity()
	{
		return CallMethod<bool>("checkValidity", new object[0]);
	}

	public void SetCustomValidity(string error)
	{
		CallVoidMethod("setCustomValidity", error);
	}
}
