namespace Gecko.WebIDL;

public class HTMLTextAreaElement : WebIDLBase
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

	public uint Cols
	{
		get
		{
			return GetProperty<uint>("cols");
		}
		set
		{
			SetProperty("cols", value);
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

	public int MaxLength
	{
		get
		{
			return GetProperty<int>("maxLength");
		}
		set
		{
			SetProperty("maxLength", value);
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

	public string Placeholder
	{
		get
		{
			return GetProperty<string>("placeholder");
		}
		set
		{
			SetProperty("placeholder", value);
		}
	}

	public bool ReadOnly
	{
		get
		{
			return GetProperty<bool>("readOnly");
		}
		set
		{
			SetProperty("readOnly", value);
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

	public uint Rows
	{
		get
		{
			return GetProperty<uint>("rows");
		}
		set
		{
			SetProperty("rows", value);
		}
	}

	public string Wrap
	{
		get
		{
			return GetProperty<string>("wrap");
		}
		set
		{
			SetProperty("wrap", value);
		}
	}

	public string Type => GetProperty<string>("type");

	public string DefaultValue
	{
		get
		{
			return GetProperty<string>("defaultValue");
		}
		set
		{
			SetProperty("defaultValue", value);
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

	public uint TextLength => GetProperty<uint>("textLength");

	public bool WillValidate => GetProperty<bool>("willValidate");

	public nsISupports Validity => GetProperty<nsISupports>("validity");

	public string ValidationMessage => GetProperty<string>("validationMessage");

	public uint SelectionStart
	{
		get
		{
			return GetProperty<uint>("selectionStart");
		}
		set
		{
			SetProperty("selectionStart", value);
		}
	}

	public uint SelectionEnd
	{
		get
		{
			return GetProperty<uint>("selectionEnd");
		}
		set
		{
			SetProperty("selectionEnd", value);
		}
	}

	public string SelectionDirection
	{
		get
		{
			return GetProperty<string>("selectionDirection");
		}
		set
		{
			SetProperty("selectionDirection", value);
		}
	}

	public nsISupports Controllers => GetProperty<nsISupports>("controllers");

	public nsISupports Editor => GetProperty<nsISupports>("editor");

	public HTMLTextAreaElement(nsIDOMWindow globalWindow, nsISupports thisObject)
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

	public void Select()
	{
		CallVoidMethod("select");
	}

	public void SetRangeText(string replacement)
	{
		CallVoidMethod("setRangeText", replacement);
	}

	public void SetRangeText(string replacement, uint start, uint end)
	{
		CallVoidMethod("setRangeText", replacement, start, end);
	}

	public void SetRangeText(string replacement, uint start, uint end, SelectionMode selectionMode)
	{
		CallVoidMethod("setRangeText", replacement, start, end, selectionMode);
	}

	public void SetSelectionRange(uint start, uint end)
	{
		CallVoidMethod("setSelectionRange", start, end);
	}

	public void SetSelectionRange(uint start, uint end, string direction)
	{
		CallVoidMethod("setSelectionRange", start, end, direction);
	}

	public void SetUserInput(string input)
	{
		CallVoidMethod("setUserInput", input);
	}
}
