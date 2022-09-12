namespace Gecko.WebIDL;

public class OffscreenCanvas : WebIDLBase
{
	public uint Width
	{
		get
		{
			return GetProperty<uint>("width");
		}
		set
		{
			SetProperty("width", value);
		}
	}

	public uint Height
	{
		get
		{
			return GetProperty<uint>("height");
		}
		set
		{
			SetProperty("height", value);
		}
	}

	public OffscreenCanvas(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports GetContext(string contextId)
	{
		return CallMethod<nsISupports>("getContext", new object[1] { contextId });
	}

	public nsISupports GetContext(string contextId, object contextOptions)
	{
		return CallMethod<nsISupports>("getContext", new object[2] { contextId, contextOptions });
	}
}
