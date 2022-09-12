namespace Gecko.WebIDL;

public class Telephony : WebIDLBase
{
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

	public bool SpeakerEnabled
	{
		get
		{
			return GetProperty<bool>("speakerEnabled");
		}
		set
		{
			SetProperty("speakerEnabled", value);
		}
	}

	public WebIDLUnion<nsISupports, nsISupports> Active => GetProperty<WebIDLUnion<nsISupports, nsISupports>>("active");

	public nsISupports Calls => GetProperty<nsISupports>("calls");

	public nsISupports ConferenceGroup => GetProperty<nsISupports>("conferenceGroup");

	public Promise Ready => GetProperty<Promise>("ready");

	public Telephony(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise<WebIDLUnion<nsISupports, nsISupports>> Dial(string number)
	{
		return CallMethod<Promise<WebIDLUnion<nsISupports, nsISupports>>>("dial", new object[1] { number });
	}

	public Promise<WebIDLUnion<nsISupports, nsISupports>> Dial(string number, uint serviceId)
	{
		return CallMethod<Promise<WebIDLUnion<nsISupports, nsISupports>>>("dial", new object[2] { number, serviceId });
	}

	public Promise<nsISupports> DialEmergency(string number)
	{
		return CallMethod<Promise<nsISupports>>("dialEmergency", new object[1] { number });
	}

	public Promise<nsISupports> DialEmergency(string number, uint serviceId)
	{
		return CallMethod<Promise<nsISupports>>("dialEmergency", new object[2] { number, serviceId });
	}

	public Promise SendTones(string tones)
	{
		return CallMethod<Promise>("sendTones", new object[1] { tones });
	}

	public Promise SendTones(string tones, uint pauseDuration)
	{
		return CallMethod<Promise>("sendTones", new object[2] { tones, pauseDuration });
	}

	public Promise SendTones(string tones, uint pauseDuration, uint toneDuration)
	{
		return CallMethod<Promise>("sendTones", new object[3] { tones, pauseDuration, toneDuration });
	}

	public Promise SendTones(string tones, uint pauseDuration, uint toneDuration, uint serviceId)
	{
		return CallMethod<Promise>("sendTones", new object[4] { tones, pauseDuration, toneDuration, serviceId });
	}

	public void StartTone(string tone)
	{
		CallVoidMethod("startTone", tone);
	}

	public void StartTone(string tone, uint serviceId)
	{
		CallVoidMethod("startTone", tone, serviceId);
	}

	public void StopTone()
	{
		CallVoidMethod("stopTone");
	}

	public void StopTone(uint serviceId)
	{
		CallVoidMethod("stopTone", serviceId);
	}

	public void OwnAudioChannel()
	{
		CallVoidMethod("ownAudioChannel");
	}
}
