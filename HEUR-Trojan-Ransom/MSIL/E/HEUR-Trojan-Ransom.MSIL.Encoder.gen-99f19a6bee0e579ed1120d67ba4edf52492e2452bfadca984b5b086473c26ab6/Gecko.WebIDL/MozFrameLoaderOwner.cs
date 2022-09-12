namespace Gecko.WebIDL;

public class MozFrameLoaderOwner : WebIDLBase
{
	public nsISupports FrameLoader => GetProperty<nsISupports>("frameLoader");

	public MozFrameLoaderOwner(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void SetIsPrerendered()
	{
		CallVoidMethod("setIsPrerendered");
	}

	public void SwapFrameLoaders(nsISupports aOtherOwner)
	{
		CallVoidMethod("swapFrameLoaders", aOtherOwner);
	}
}
