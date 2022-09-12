namespace Gecko.WebIDL;

public class HTMLMetaElement : WebIDLBase
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

	public string HttpEquiv
	{
		get
		{
			return GetProperty<string>("httpEquiv");
		}
		set
		{
			SetProperty("httpEquiv", value);
		}
	}

	public string Content
	{
		get
		{
			return GetProperty<string>("content");
		}
		set
		{
			SetProperty("content", value);
		}
	}

	public string Scheme
	{
		get
		{
			return GetProperty<string>("scheme");
		}
		set
		{
			SetProperty("scheme", value);
		}
	}

	public HTMLMetaElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
