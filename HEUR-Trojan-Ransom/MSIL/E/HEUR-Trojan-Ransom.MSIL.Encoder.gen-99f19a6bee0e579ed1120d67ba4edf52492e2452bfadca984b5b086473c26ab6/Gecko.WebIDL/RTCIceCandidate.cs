namespace Gecko.WebIDL;

public class RTCIceCandidate : WebIDLBase
{
	public string Candidate
	{
		get
		{
			return GetProperty<string>("candidate");
		}
		set
		{
			SetProperty("candidate", value);
		}
	}

	public string SdpMid
	{
		get
		{
			return GetProperty<string>("sdpMid");
		}
		set
		{
			SetProperty("sdpMid", value);
		}
	}

	public ushort? SdpMLineIndex
	{
		get
		{
			return GetProperty<ushort?>("sdpMLineIndex");
		}
		set
		{
			SetProperty("sdpMLineIndex", value);
		}
	}

	public RTCIceCandidate(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
