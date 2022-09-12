namespace Gecko.WebIDL;

public class RTCSessionDescription : WebIDLBase
{
	public RTCSdpType Type
	{
		get
		{
			return GetProperty<RTCSdpType>("type");
		}
		set
		{
			SetProperty("type", value);
		}
	}

	public string Sdp
	{
		get
		{
			return GetProperty<string>("sdp");
		}
		set
		{
			SetProperty("sdp", value);
		}
	}

	public RTCSessionDescription(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
