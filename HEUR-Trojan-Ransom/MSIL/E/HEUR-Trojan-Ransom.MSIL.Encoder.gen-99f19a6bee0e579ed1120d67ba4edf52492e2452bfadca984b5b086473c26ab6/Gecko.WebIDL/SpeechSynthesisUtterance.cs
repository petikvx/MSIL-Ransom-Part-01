namespace Gecko.WebIDL;

public class SpeechSynthesisUtterance : WebIDLBase
{
	public string Text
	{
		get
		{
			return GetProperty<string>("text");
		}
		set
		{
			SetProperty("text", value);
		}
	}

	public string Lang
	{
		get
		{
			return GetProperty<string>("lang");
		}
		set
		{
			SetProperty("lang", value);
		}
	}

	public nsISupports Voice
	{
		get
		{
			return GetProperty<nsISupports>("voice");
		}
		set
		{
			SetProperty("voice", value);
		}
	}

	public float Volume
	{
		get
		{
			return GetProperty<float>("volume");
		}
		set
		{
			SetProperty("volume", value);
		}
	}

	public float Rate
	{
		get
		{
			return GetProperty<float>("rate");
		}
		set
		{
			SetProperty("rate", value);
		}
	}

	public float Pitch
	{
		get
		{
			return GetProperty<float>("pitch");
		}
		set
		{
			SetProperty("pitch", value);
		}
	}

	public string ChosenVoiceURI => GetProperty<string>("chosenVoiceURI");

	public SpeechSynthesisUtterance(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
