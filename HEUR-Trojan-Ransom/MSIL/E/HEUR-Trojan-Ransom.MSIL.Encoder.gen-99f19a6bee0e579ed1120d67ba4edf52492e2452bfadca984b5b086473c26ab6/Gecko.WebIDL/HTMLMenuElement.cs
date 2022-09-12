namespace Gecko.WebIDL;

public class HTMLMenuElement : WebIDLBase
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

	public bool Compact
	{
		get
		{
			return GetProperty<bool>("compact");
		}
		set
		{
			SetProperty("compact", value);
		}
	}

	public HTMLMenuElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void SendShowEvent()
	{
		CallVoidMethod("sendShowEvent");
	}

	public nsISupports CreateBuilder()
	{
		return CallMethod<nsISupports>("createBuilder", new object[0]);
	}

	public void Build(nsISupports aBuilder)
	{
		CallVoidMethod("build", aBuilder);
	}
}
