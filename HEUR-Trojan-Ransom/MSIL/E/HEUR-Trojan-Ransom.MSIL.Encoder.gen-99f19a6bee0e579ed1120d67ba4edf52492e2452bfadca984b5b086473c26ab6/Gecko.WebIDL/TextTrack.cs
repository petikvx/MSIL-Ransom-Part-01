namespace Gecko.WebIDL;

public class TextTrack : WebIDLBase
{
	public TextTrackKind Kind => GetProperty<TextTrackKind>("kind");

	public string Label => GetProperty<string>("label");

	public string Language => GetProperty<string>("language");

	public string Id => GetProperty<string>("id");

	public string InBandMetadataTrackDispatchType => GetProperty<string>("inBandMetadataTrackDispatchType");

	public TextTrackMode Mode
	{
		get
		{
			return GetProperty<TextTrackMode>("mode");
		}
		set
		{
			SetProperty("mode", value);
		}
	}

	public nsISupports Cues => GetProperty<nsISupports>("cues");

	public nsISupports ActiveCues => GetProperty<nsISupports>("activeCues");

	public nsISupports TextTrackList => GetProperty<nsISupports>("textTrackList");

	public TextTrack(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void AddCue(nsISupports cue)
	{
		CallVoidMethod("addCue", cue);
	}

	public void RemoveCue(nsISupports cue)
	{
		CallVoidMethod("removeCue", cue);
	}
}
