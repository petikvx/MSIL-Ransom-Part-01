namespace Gecko.WebIDL;

public class HTMLOptionElement : WebIDLBase
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

	public string Label
	{
		get
		{
			return GetProperty<string>("label");
		}
		set
		{
			SetProperty("label", value);
		}
	}

	public bool DefaultSelected
	{
		get
		{
			return GetProperty<bool>("defaultSelected");
		}
		set
		{
			SetProperty("defaultSelected", value);
		}
	}

	public bool Selected
	{
		get
		{
			return GetProperty<bool>("selected");
		}
		set
		{
			SetProperty("selected", value);
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

	public string Text
	{
		get
		{
			return GetProperty<string>("text");
		}
		set
		{
			SetProperty("text", value);
		}
	}

	public int Index => GetProperty<int>("index");

	public HTMLOptionElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
