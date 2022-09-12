namespace Gecko.WebIDL;

public class HTMLVideoElement : WebIDLBase
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

	public uint VideoWidth => GetProperty<uint>("videoWidth");

	public uint VideoHeight => GetProperty<uint>("videoHeight");

	public string Poster
	{
		get
		{
			return GetProperty<string>("poster");
		}
		set
		{
			SetProperty("poster", value);
		}
	}

	public uint MozParsedFrames => GetProperty<uint>("mozParsedFrames");

	public uint MozDecodedFrames => GetProperty<uint>("mozDecodedFrames");

	public uint MozPresentedFrames => GetProperty<uint>("mozPresentedFrames");

	public uint MozPaintedFrames => GetProperty<uint>("mozPaintedFrames");

	public double MozFrameDelay => GetProperty<double>("mozFrameDelay");

	public bool MozHasAudio => GetProperty<bool>("mozHasAudio");

	public bool MozUseScreenWakeLock
	{
		get
		{
			return GetProperty<bool>("mozUseScreenWakeLock");
		}
		set
		{
			SetProperty("mozUseScreenWakeLock", value);
		}
	}

	public HTMLVideoElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports GetVideoPlaybackQuality()
	{
		return CallMethod<nsISupports>("getVideoPlaybackQuality", new object[0]);
	}
}
