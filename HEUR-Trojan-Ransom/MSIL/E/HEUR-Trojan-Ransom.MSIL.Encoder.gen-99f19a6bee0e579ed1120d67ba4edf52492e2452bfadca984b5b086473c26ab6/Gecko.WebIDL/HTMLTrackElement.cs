namespace Gecko.WebIDL;

public class HTMLTrackElement : WebIDLBase
{
	public string Kind
	{
		get
		{
			return GetProperty<string>("kind");
		}
		set
		{
			SetProperty("kind", value);
		}
	}

	public string Src
	{
		get
		{
			return GetProperty<string>("src");
		}
		set
		{
			SetProperty("src", value);
		}
	}

	public string Srclang
	{
		get
		{
			return GetProperty<string>("srclang");
		}
		set
		{
			SetProperty("srclang", value);
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

	public bool Default
	{
		get
		{
			return GetProperty<bool>("default");
		}
		set
		{
			SetProperty("default", value);
		}
	}

	public ushort ReadyState => GetProperty<ushort>("readyState");

	public nsISupports Track => GetProperty<nsISupports>("track");

	public HTMLTrackElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
