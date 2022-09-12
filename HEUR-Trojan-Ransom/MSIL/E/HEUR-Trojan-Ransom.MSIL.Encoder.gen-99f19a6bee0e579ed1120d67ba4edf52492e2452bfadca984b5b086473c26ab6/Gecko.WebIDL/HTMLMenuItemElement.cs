namespace Gecko.WebIDL;

public class HTMLMenuItemElement : WebIDLBase
{
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

	public string Icon
	{
		get
		{
			return GetProperty<string>("icon");
		}
		set
		{
			SetProperty("icon", value);
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

	public bool Checked
	{
		get
		{
			return GetProperty<bool>("checked");
		}
		set
		{
			SetProperty("checked", value);
		}
	}

	public string Radiogroup
	{
		get
		{
			return GetProperty<string>("radiogroup");
		}
		set
		{
			SetProperty("radiogroup", value);
		}
	}

	public bool DefaultChecked
	{
		get
		{
			return GetProperty<bool>("defaultChecked");
		}
		set
		{
			SetProperty("defaultChecked", value);
		}
	}

	public HTMLMenuItemElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
