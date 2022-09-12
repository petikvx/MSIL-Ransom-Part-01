namespace Gecko.WebIDL;

public class RTCPeerConnection : WebIDLBase
{
	public nsISupports LocalDescription => GetProperty<nsISupports>("localDescription");

	public nsISupports RemoteDescription => GetProperty<nsISupports>("remoteDescription");

	public RTCSignalingState SignalingState => GetProperty<RTCSignalingState>("signalingState");

	public RTCIceGatheringState IceGatheringState => GetProperty<RTCIceGatheringState>("iceGatheringState");

	public RTCIceConnectionState IceConnectionState => GetProperty<RTCIceConnectionState>("iceConnectionState");

	public Promise<object> PeerIdentity => GetProperty<Promise<object>>("peerIdentity");

	public string IdpLoginUrl => GetProperty<string>("idpLoginUrl");

	public string Id
	{
		get
		{
			return GetProperty<string>("id");
		}
		set
		{
			SetProperty("id", value);
		}
	}

	public RTCPeerConnection(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void SetIdentityProvider(string provider)
	{
		CallVoidMethod("setIdentityProvider", provider);
	}

	public void SetIdentityProvider(string provider, string protocol)
	{
		CallVoidMethod("setIdentityProvider", provider, protocol);
	}

	public void SetIdentityProvider(string provider, string protocol, string username)
	{
		CallVoidMethod("setIdentityProvider", provider, protocol, username);
	}

	public Promise<string> GetIdentityAssertion()
	{
		return CallMethod<Promise<string>>("getIdentityAssertion", new object[0]);
	}

	public Promise<nsISupports> CreateOffer()
	{
		return CallMethod<Promise<nsISupports>>("createOffer", new object[0]);
	}

	public Promise<nsISupports> CreateOffer(object options)
	{
		return CallMethod<Promise<nsISupports>>("createOffer", new object[1] { options });
	}

	public Promise<nsISupports> CreateAnswer()
	{
		return CallMethod<Promise<nsISupports>>("createAnswer", new object[0]);
	}

	public Promise<nsISupports> CreateAnswer(object options)
	{
		return CallMethod<Promise<nsISupports>>("createAnswer", new object[1] { options });
	}

	public Promise SetLocalDescription(nsISupports description)
	{
		return CallMethod<Promise>("setLocalDescription", new object[1] { description });
	}

	public Promise SetRemoteDescription(nsISupports description)
	{
		return CallMethod<Promise>("setRemoteDescription", new object[1] { description });
	}

	public void UpdateIce()
	{
		CallVoidMethod("updateIce");
	}

	public void UpdateIce(object configuration)
	{
		CallVoidMethod("updateIce", configuration);
	}

	public Promise AddIceCandidate(nsISupports candidate)
	{
		return CallMethod<Promise>("addIceCandidate", new object[1] { candidate });
	}

	public object GetConfiguration()
	{
		return CallMethod<object>("getConfiguration", new object[0]);
	}

	public nsISupports[] GetLocalStreams()
	{
		return CallMethod<nsISupports[]>("getLocalStreams", new object[0]);
	}

	public nsISupports[] GetRemoteStreams()
	{
		return CallMethod<nsISupports[]>("getRemoteStreams", new object[0]);
	}

	public nsISupports GetStreamById(string streamId)
	{
		return CallMethod<nsISupports>("getStreamById", new object[1] { streamId });
	}

	public void AddStream(nsISupports stream)
	{
		CallVoidMethod("addStream", stream);
	}

	public void RemoveStream(nsISupports stream)
	{
		CallVoidMethod("removeStream", stream);
	}

	public nsISupports AddTrack(nsISupports track, nsISupports stream, nsISupports moreStreams)
	{
		return CallMethod<nsISupports>("addTrack", new object[3] { track, stream, moreStreams });
	}

	public void RemoveTrack(nsISupports sender)
	{
		CallVoidMethod("removeTrack", sender);
	}

	public nsISupports[] GetSenders()
	{
		return CallMethod<nsISupports[]>("getSenders", new object[0]);
	}

	public nsISupports[] GetReceivers()
	{
		return CallMethod<nsISupports[]>("getReceivers", new object[0]);
	}

	public void Close()
	{
		CallVoidMethod("close");
	}

	public Promise<nsISupports> GetStats()
	{
		return CallMethod<Promise<nsISupports>>("getStats", new object[0]);
	}

	public Promise<nsISupports> GetStats(nsISupports selector)
	{
		return CallMethod<Promise<nsISupports>>("getStats", new object[1] { selector });
	}

	public nsISupports CreateDataChannel(string label)
	{
		return CallMethod<nsISupports>("createDataChannel", new object[1] { label });
	}

	public nsISupports CreateDataChannel(string label, object dataChannelDict)
	{
		return CallMethod<nsISupports>("createDataChannel", new object[2] { label, dataChannelDict });
	}
}
