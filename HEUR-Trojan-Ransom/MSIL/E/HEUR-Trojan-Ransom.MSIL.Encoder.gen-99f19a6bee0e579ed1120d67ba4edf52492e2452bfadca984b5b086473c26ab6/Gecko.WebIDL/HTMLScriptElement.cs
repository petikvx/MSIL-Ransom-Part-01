namespace Gecko.WebIDL;

public class HTMLScriptElement : WebIDLBase
{
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

	public string Charset
	{
		get
		{
			return GetProperty<string>("charset");
		}
		set
		{
			SetProperty("charset", value);
		}
	}

	public bool Async
	{
		get
		{
			return GetProperty<bool>("async");
		}
		set
		{
			SetProperty("async", value);
		}
	}

	public bool Defer
	{
		get
		{
			return GetProperty<bool>("defer");
		}
		set
		{
			SetProperty("defer", value);
		}
	}

	public string CrossOrigin
	{
		get
		{
			return GetProperty<string>("crossOrigin");
		}
		set
		{
			SetProperty("crossOrigin", value);
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

	public string Event
	{
		get
		{
			return GetProperty<string>("event");
		}
		set
		{
			SetProperty("event", value);
		}
	}

	public string HtmlFor
	{
		get
		{
			return GetProperty<string>("htmlFor");
		}
		set
		{
			SetProperty("htmlFor", value);
		}
	}

	public string Integrity
	{
		get
		{
			return GetProperty<string>("integrity");
		}
		set
		{
			SetProperty("integrity", value);
		}
	}

	public HTMLScriptElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
