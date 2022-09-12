namespace Gecko.WebIDL;

public class HTMLObjectElement : WebIDLBase
{
	public string Data
	{
		get
		{
			return GetProperty<string>("data");
		}
		set
		{
			SetProperty("data", value);
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

	public bool TypeMustMatch
	{
		get
		{
			return GetProperty<bool>("typeMustMatch");
		}
		set
		{
			SetProperty("typeMustMatch", value);
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

	public string UseMap
	{
		get
		{
			return GetProperty<string>("useMap");
		}
		set
		{
			SetProperty("useMap", value);
		}
	}

	public nsISupports Form => GetProperty<nsISupports>("form");

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

	public nsIDOMDocument ContentDocument => GetProperty<nsIDOMDocument>("contentDocument");

	public nsIDOMWindow ContentWindow => GetProperty<nsIDOMWindow>("contentWindow");

	public bool WillValidate => GetProperty<bool>("willValidate");

	public nsISupports Validity => GetProperty<nsISupports>("validity");

	public string ValidationMessage => GetProperty<string>("validationMessage");

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

	public string Archive
	{
		get
		{
			return GetProperty<string>("archive");
		}
		set
		{
			SetProperty("archive", value);
		}
	}

	public string Code
	{
		get
		{
			return GetProperty<string>("code");
		}
		set
		{
			SetProperty("code", value);
		}
	}

	public bool Declare
	{
		get
		{
			return GetProperty<bool>("declare");
		}
		set
		{
			SetProperty("declare", value);
		}
	}

	public uint Hspace
	{
		get
		{
			return GetProperty<uint>("hspace");
		}
		set
		{
			SetProperty("hspace", value);
		}
	}

	public string Standby
	{
		get
		{
			return GetProperty<string>("standby");
		}
		set
		{
			SetProperty("standby", value);
		}
	}

	public uint Vspace
	{
		get
		{
			return GetProperty<uint>("vspace");
		}
		set
		{
			SetProperty("vspace", value);
		}
	}

	public string CodeBase
	{
		get
		{
			return GetProperty<string>("codeBase");
		}
		set
		{
			SetProperty("codeBase", value);
		}
	}

	public string CodeType
	{
		get
		{
			return GetProperty<string>("codeType");
		}
		set
		{
			SetProperty("codeType", value);
		}
	}

	public string Border
	{
		get
		{
			return GetProperty<string>("border");
		}
		set
		{
			SetProperty("border", value);
		}
	}

	public HTMLObjectElement(nsIDOMWindow globalWindow, nsISupports thisObject)
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
