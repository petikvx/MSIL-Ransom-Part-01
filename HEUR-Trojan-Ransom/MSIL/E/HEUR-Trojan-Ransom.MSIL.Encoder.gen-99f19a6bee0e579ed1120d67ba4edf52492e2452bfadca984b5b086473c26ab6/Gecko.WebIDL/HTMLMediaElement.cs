namespace Gecko.WebIDL;

public class HTMLMediaElement : WebIDLBase
{
	public nsISupports Error => GetProperty<nsISupports>("error");

	public string Src
	{
		get
		{
			return GetProperty<string>("src");
		}
		set
		{
			SetProperty("src", value);
		}
	}

	public string CurrentSrc => GetProperty<string>("currentSrc");

	public string CrossOrigin
	{
		get
		{
			return GetProperty<string>("crossOrigin");
		}
		set
		{
			SetProperty("crossOrigin", value);
		}
	}

	public ushort NetworkState => GetProperty<ushort>("networkState");

	public string Preload
	{
		get
		{
			return GetProperty<string>("preload");
		}
		set
		{
			SetProperty("preload", value);
		}
	}

	public nsISupports Buffered => GetProperty<nsISupports>("buffered");

	public ushort ReadyState => GetProperty<ushort>("readyState");

	public bool Seeking => GetProperty<bool>("seeking");

	public double CurrentTime
	{
		get
		{
			return GetProperty<double>("currentTime");
		}
		set
		{
			SetProperty("currentTime", value);
		}
	}

	public double Duration => GetProperty<double>("duration");

	public bool IsEncrypted => GetProperty<bool>("isEncrypted");

	public bool Paused => GetProperty<bool>("paused");

	public double DefaultPlaybackRate
	{
		get
		{
			return GetProperty<double>("defaultPlaybackRate");
		}
		set
		{
			SetProperty("defaultPlaybackRate", value);
		}
	}

	public double PlaybackRate
	{
		get
		{
			return GetProperty<double>("playbackRate");
		}
		set
		{
			SetProperty("playbackRate", value);
		}
	}

	public nsISupports Played => GetProperty<nsISupports>("played");

	public nsISupports Seekable => GetProperty<nsISupports>("seekable");

	public bool Ended => GetProperty<bool>("ended");

	public bool Autoplay
	{
		get
		{
			return GetProperty<bool>("autoplay");
		}
		set
		{
			SetProperty("autoplay", value);
		}
	}

	public bool Loop
	{
		get
		{
			return GetProperty<bool>("loop");
		}
		set
		{
			SetProperty("loop", value);
		}
	}

	public bool Controls
	{
		get
		{
			return GetProperty<bool>("controls");
		}
		set
		{
			SetProperty("controls", value);
		}
	}

	public double Volume
	{
		get
		{
			return GetProperty<double>("volume");
		}
		set
		{
			SetProperty("volume", value);
		}
	}

	public bool Muted
	{
		get
		{
			return GetProperty<bool>("muted");
		}
		set
		{
			SetProperty("muted", value);
		}
	}

	public bool DefaultMuted
	{
		get
		{
			return GetProperty<bool>("defaultMuted");
		}
		set
		{
			SetProperty("defaultMuted", value);
		}
	}

	public nsISupports AudioTracks => GetProperty<nsISupports>("audioTracks");

	public nsISupports VideoTracks => GetProperty<nsISupports>("videoTracks");

	public nsISupports TextTracks => GetProperty<nsISupports>("textTracks");

	public nsISupports MozMediaSourceObject => GetProperty<nsISupports>("mozMediaSourceObject");

	public nsISupports SrcObject
	{
		get
		{
			return GetProperty<nsISupports>("srcObject");
		}
		set
		{
			SetProperty("srcObject", value);
		}
	}

	public nsISupports MozSrcObject
	{
		get
		{
			return GetProperty<nsISupports>("mozSrcObject");
		}
		set
		{
			SetProperty("mozSrcObject", value);
		}
	}

	public bool MozPreservesPitch
	{
		get
		{
			return GetProperty<bool>("mozPreservesPitch");
		}
		set
		{
			SetProperty("mozPreservesPitch", value);
		}
	}

	public bool MozAutoplayEnabled => GetProperty<bool>("mozAutoplayEnabled");

	public bool MozMediaStatisticsShowing
	{
		get
		{
			return GetProperty<bool>("mozMediaStatisticsShowing");
		}
		set
		{
			SetProperty("mozMediaStatisticsShowing", value);
		}
	}

	public bool MozAllowCasting
	{
		get
		{
			return GetProperty<bool>("mozAllowCasting");
		}
		set
		{
			SetProperty("mozAllowCasting", value);
		}
	}

	public bool MozIsCasting
	{
		get
		{
			return GetProperty<bool>("mozIsCasting");
		}
		set
		{
			SetProperty("mozIsCasting", value);
		}
	}

	public bool MozAudioCaptured => GetProperty<bool>("mozAudioCaptured");

	public double MozFragmentEnd => GetProperty<double>("mozFragmentEnd");

	public AudioChannel MozAudioChannelType
	{
		get
		{
			return GetProperty<AudioChannel>("mozAudioChannelType");
		}
		set
		{
			SetProperty("mozAudioChannelType", value);
		}
	}

	public double ComputedVolume => GetProperty<double>("computedVolume");

	public bool ComputedMuted => GetProperty<bool>("computedMuted");

	public HTMLMediaElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Load()
	{
		CallVoidMethod("load");
	}

	public string CanPlayType(string type)
	{
		return CallMethod<string>("canPlayType", new object[1] { type });
	}

	public void FastSeek(double time)
	{
		CallVoidMethod("fastSeek", time);
	}

	public void Play()
	{
		CallVoidMethod("play");
	}

	public void Pause()
	{
		CallVoidMethod("pause");
	}

	public nsISupports AddTextTrack(TextTrackKind kind)
	{
		return CallMethod<nsISupports>("addTextTrack", new object[1] { kind });
	}

	public nsISupports AddTextTrack(TextTrackKind kind, string label)
	{
		return CallMethod<nsISupports>("addTextTrack", new object[2] { kind, label });
	}

	public nsISupports AddTextTrack(TextTrackKind kind, string label, string language)
	{
		return CallMethod<nsISupports>("addTextTrack", new object[3] { kind, label, language });
	}

	public nsISupports MozCaptureStream()
	{
		return CallMethod<nsISupports>("mozCaptureStream", new object[0]);
	}

	public nsISupports MozCaptureStreamUntilEnded()
	{
		return CallMethod<nsISupports>("mozCaptureStreamUntilEnded", new object[0]);
	}

	public object MozGetMetadata()
	{
		return CallMethod<object>("mozGetMetadata", new object[0]);
	}
}
