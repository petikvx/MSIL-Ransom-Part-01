namespace Gecko.WebIDL;

public class WebrtcGlobalInformation : WebIDLBase
{
	public int DebugLevel
	{
		get
		{
			return GetProperty<int>("debugLevel");
		}
		set
		{
			SetProperty("debugLevel", value);
		}
	}

	public bool AecDebug
	{
		get
		{
			return GetProperty<bool>("aecDebug");
		}
		set
		{
			SetProperty("aecDebug", value);
		}
	}

	public WebrtcGlobalInformation(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
