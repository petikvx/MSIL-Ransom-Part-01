namespace Gecko.WebIDL;

public class MozImageLoadingContent : WebIDLBase
{
	public bool LoadingEnabled
	{
		get
		{
			return GetProperty<bool>("loadingEnabled");
		}
		set
		{
			SetProperty("loadingEnabled", value);
		}
	}

	public short ImageBlockingStatus => GetProperty<short>("imageBlockingStatus");

	public nsISupports CurrentURI => GetProperty<nsISupports>("currentURI");

	public MozImageLoadingContent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void AddObserver(nsISupports aObserver)
	{
		CallVoidMethod("addObserver", aObserver);
	}

	public void RemoveObserver(nsISupports aObserver)
	{
		CallVoidMethod("removeObserver", aObserver);
	}

	public nsISupports GetRequest(int aRequestType)
	{
		return CallMethod<nsISupports>("getRequest", new object[1] { aRequestType });
	}

	public int GetRequestType(nsISupports aRequest)
	{
		return CallMethod<int>("getRequestType", new object[1] { aRequest });
	}

	public nsISupports LoadImageWithChannel(nsISupports aChannel)
	{
		return CallMethod<nsISupports>("loadImageWithChannel", new object[1] { aChannel });
	}

	public void ForceReload()
	{
		CallVoidMethod("forceReload");
	}

	public void ForceReload(bool aNotify)
	{
		CallVoidMethod("forceReload", aNotify);
	}

	public void ForceImageState(bool aForce, ulong aState)
	{
		CallVoidMethod("forceImageState", aForce, aState);
	}
}
