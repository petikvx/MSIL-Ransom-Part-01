namespace Gecko.WebIDL;

public class HTMLCanvasElement : WebIDLBase
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

	public bool MozOpaque
	{
		get
		{
			return GetProperty<bool>("mozOpaque");
		}
		set
		{
			SetProperty("mozOpaque", value);
		}
	}

	public HTMLCanvasElement(nsIDOMWindow globalWindow, nsISupports thisObject)
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

	public string ToDataURL()
	{
		return CallMethod<string>("toDataURL", new object[0]);
	}

	public string ToDataURL(string type)
	{
		return CallMethod<string>("toDataURL", new object[1] { type });
	}

	public string ToDataURL(string type, object encoderOptions)
	{
		return CallMethod<string>("toDataURL", new object[2] { type, encoderOptions });
	}

	public nsISupports MozGetAsFile(string name)
	{
		return CallMethod<nsISupports>("mozGetAsFile", new object[1] { name });
	}

	public nsISupports MozGetAsFile(string name, string type)
	{
		return CallMethod<nsISupports>("mozGetAsFile", new object[2] { name, type });
	}

	public nsISupports MozGetIPCContext(string contextId)
	{
		return CallMethod<nsISupports>("MozGetIPCContext", new object[1] { contextId });
	}

	public nsISupports CaptureStream()
	{
		return CallMethod<nsISupports>("captureStream", new object[0]);
	}

	public nsISupports CaptureStream(double frameRate)
	{
		return CallMethod<nsISupports>("captureStream", new object[1] { frameRate });
	}

	public nsISupports TransferControlToOffscreen()
	{
		return CallMethod<nsISupports>("transferControlToOffscreen", new object[0]);
	}
}
