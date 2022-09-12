namespace Gecko.WebIDL;

public class PeerConnectionObserver : WebIDLBase
{
	public PeerConnectionObserver(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void OnCreateOfferSuccess(string offer)
	{
		CallVoidMethod("onCreateOfferSuccess", offer);
	}

	public void OnCreateOfferError(uint name, string message)
	{
		CallVoidMethod("onCreateOfferError", name, message);
	}

	public void OnCreateAnswerSuccess(string answer)
	{
		CallVoidMethod("onCreateAnswerSuccess", answer);
	}

	public void OnCreateAnswerError(uint name, string message)
	{
		CallVoidMethod("onCreateAnswerError", name, message);
	}

	public void OnSetLocalDescriptionSuccess()
	{
		CallVoidMethod("onSetLocalDescriptionSuccess");
	}

	public void OnSetRemoteDescriptionSuccess()
	{
		CallVoidMethod("onSetRemoteDescriptionSuccess");
	}

	public void OnSetLocalDescriptionError(uint name, string message)
	{
		CallVoidMethod("onSetLocalDescriptionError", name, message);
	}

	public void OnSetRemoteDescriptionError(uint name, string message)
	{
		CallVoidMethod("onSetRemoteDescriptionError", name, message);
	}

	public void OnAddIceCandidateSuccess()
	{
		CallVoidMethod("onAddIceCandidateSuccess");
	}

	public void OnAddIceCandidateError(uint name, string message)
	{
		CallVoidMethod("onAddIceCandidateError", name, message);
	}

	public void OnIceCandidate(ushort level, string mid, string candidate)
	{
		CallVoidMethod("onIceCandidate", level, mid, candidate);
	}

	public void OnNegotiationNeeded()
	{
		CallVoidMethod("onNegotiationNeeded");
	}

	public void OnGetStatsSuccess()
	{
		CallVoidMethod("onGetStatsSuccess");
	}

	public void OnGetStatsSuccess(object report)
	{
		CallVoidMethod("onGetStatsSuccess", report);
	}

	public void OnGetStatsError(uint name, string message)
	{
		CallVoidMethod("onGetStatsError", name, message);
	}

	public void OnReplaceTrackSuccess()
	{
		CallVoidMethod("onReplaceTrackSuccess");
	}

	public void OnReplaceTrackError(uint name, string message)
	{
		CallVoidMethod("onReplaceTrackError", name, message);
	}

	public void NotifyDataChannel(nsISupports channel)
	{
		CallVoidMethod("notifyDataChannel", channel);
	}

	public void OnStateChange(PCObserverStateType state)
	{
		CallVoidMethod("onStateChange", state);
	}

	public void OnAddStream(nsISupports stream)
	{
		CallVoidMethod("onAddStream", stream);
	}

	public void OnRemoveStream(nsISupports stream)
	{
		CallVoidMethod("onRemoveStream", stream);
	}

	public void OnAddTrack(nsISupports track)
	{
		CallVoidMethod("onAddTrack", track);
	}

	public void OnRemoveTrack(nsISupports track)
	{
		CallVoidMethod("onRemoveTrack", track);
	}
}
