namespace Gecko.WebIDL;

public class SpeechRecognition : WebIDLBase
{
	public nsISupports Grammars
	{
		get
		{
			return GetProperty<nsISupports>("grammars");
		}
		set
		{
			SetProperty("grammars", value);
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

	public bool Continuous
	{
		get
		{
			return GetProperty<bool>("continuous");
		}
		set
		{
			SetProperty("continuous", value);
		}
	}

	public bool InterimResults
	{
		get
		{
			return GetProperty<bool>("interimResults");
		}
		set
		{
			SetProperty("interimResults", value);
		}
	}

	public uint MaxAlternatives
	{
		get
		{
			return GetProperty<uint>("maxAlternatives");
		}
		set
		{
			SetProperty("maxAlternatives", value);
		}
	}

	public string ServiceURI
	{
		get
		{
			return GetProperty<string>("serviceURI");
		}
		set
		{
			SetProperty("serviceURI", value);
		}
	}

	public SpeechRecognition(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Start()
	{
		CallVoidMethod("start");
	}

	public void Start(nsISupports stream)
	{
		CallVoidMethod("start", stream);
	}

	public void Stop()
	{
		CallVoidMethod("stop");
	}

	public void Abort()
	{
		CallVoidMethod("abort");
	}
}
