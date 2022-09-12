namespace Gecko.WebIDL;

public class HTMLFieldSetElement : WebIDLBase
{
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

	public nsISupports Elements => GetProperty<nsISupports>("elements");

	public bool WillValidate => GetProperty<bool>("willValidate");

	public nsISupports Validity => GetProperty<nsISupports>("validity");

	public string ValidationMessage => GetProperty<string>("validationMessage");

	public HTMLFieldSetElement(nsIDOMWindow globalWindow, nsISupports thisObject)
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
