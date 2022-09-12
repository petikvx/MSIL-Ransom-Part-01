namespace Gecko.WebIDL;

public class HTMLParamElement : WebIDLBase
{
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

	public string ValueType
	{
		get
		{
			return GetProperty<string>("valueType");
		}
		set
		{
			SetProperty("valueType", value);
		}
	}

	public HTMLParamElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
