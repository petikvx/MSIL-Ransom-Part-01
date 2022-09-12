namespace Gecko.WebIDL;

public class PeerConnectionImpl : WebIDLBase
{
	public nsISupports Certificate
	{
		get
		{
			return GetProperty<nsISupports>("certificate");
		}
		set
		{
			SetProperty("certificate", value);
		}
	}

	public string Fingerprint => GetProperty<string>("fingerprint");

	public string LocalDescription => GetProperty<string>("localDescription");

	public string RemoteDescription => GetProperty<string>("remoteDescription");

	public PCImplIceConnectionState IceConnectionState => GetProperty<PCImplIceConnectionState>("iceConnectionState");

	public PCImplIceGatheringState IceGatheringState => GetProperty<PCImplIceGatheringState>("iceGatheringState");

	public PCImplSignalingState SignalingState => GetProperty<PCImplSignalingState>("signalingState");

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

	public string PeerIdentity
	{
		get
		{
			return GetProperty<string>("peerIdentity");
		}
		set
		{
			SetProperty("peerIdentity", value);
		}
	}

	public bool PrivacyRequested => GetProperty<bool>("privacyRequested");

	public PeerConnectionImpl(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Initialize(nsISupports observer, nsIDOMWindow window, object iceServers, nsISupports thread)
	{
		CallVoidMethod("initialize", observer, window, iceServers, thread);
	}

	public void CreateOffer()
	{
		CallVoidMethod("createOffer");
	}

	public void CreateOffer(object options)
	{
		CallVoidMethod("createOffer", options);
	}

	public void CreateAnswer()
	{
		CallVoidMethod("createAnswer");
	}

	public void SetLocalDescription(int action, string sdp)
	{
		CallVoidMethod("setLocalDescription", action, sdp);
	}

	public void SetRemoteDescription(int action, string sdp)
	{
		CallVoidMethod("setRemoteDescription", action, sdp);
	}

	public void GetStats(nsISupports selector)
	{
		CallVoidMethod("getStats", selector);
	}

	public void AddTrack(nsISupports track, nsISupports streams)
	{
		CallVoidMethod("addTrack", track, streams);
	}

	public void RemoveTrack(nsISupports track)
	{
		CallVoidMethod("removeTrack", track);
	}

	public void ReplaceTrack(nsISupports thisTrack, nsISupports withTrack)
	{
		CallVoidMethod("replaceTrack", thisTrack, withTrack);
	}

	public void CloseStreams()
	{
		CallVoidMethod("closeStreams");
	}

	public nsISupports[] GetLocalStreams()
	{
		return CallMethod<nsISupports[]>("getLocalStreams", new object[0]);
	}

	public nsISupports[] GetRemoteStreams()
	{
		return CallMethod<nsISupports[]>("getRemoteStreams", new object[0]);
	}

	public void AddIceCandidate(string candidate, string mid, ushort level)
	{
		CallVoidMethod("addIceCandidate", candidate, mid, level);
	}

	public void Close()
	{
		CallVoidMethod("close");
	}

	public bool PluginCrash(ulong pluginId, string name)
	{
		return CallMethod<bool>("pluginCrash", new object[2] { pluginId, name });
	}

	public nsISupports CreateDataChannel(string label, string protocol, ushort type, bool outOfOrderAllowed, ushort maxTime, ushort maxNum, bool externalNegotiated, ushort stream)
	{
		return CallMethod<nsISupports>("createDataChannel", new object[8] { label, protocol, type, outOfOrderAllowed, maxTime, maxNum, externalNegotiated, stream });
	}
}
