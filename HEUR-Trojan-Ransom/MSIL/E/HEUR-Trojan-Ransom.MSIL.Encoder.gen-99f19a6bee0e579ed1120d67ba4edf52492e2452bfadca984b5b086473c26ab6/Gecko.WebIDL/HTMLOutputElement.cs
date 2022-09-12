namespace Gecko.WebIDL;

public class HTMLOutputElement : WebIDLBase
{
	public nsISupports HtmlFor => GetProperty<nsISupports>("htmlFor");

	public nsISupports Form => GetProperty<nsISupports>("form");

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

	public bool WillValidate => GetProperty<bool>("willValidate");

	public nsISupports Validity => GetProperty<nsISupports>("validity");

	public string ValidationMessage => GetProperty<string>("validationMessage");

	public HTMLOutputElement(nsIDOMWindow globalWindow, nsISupports thisObject)
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
