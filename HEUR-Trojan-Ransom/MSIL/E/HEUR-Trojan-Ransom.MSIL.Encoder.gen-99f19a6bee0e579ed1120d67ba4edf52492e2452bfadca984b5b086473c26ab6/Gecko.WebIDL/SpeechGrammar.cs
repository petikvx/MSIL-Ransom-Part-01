namespace Gecko.WebIDL;

public class SpeechGrammar : WebIDLBase
{
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

	public float Weight
	{
		get
		{
			return GetProperty<float>("weight");
		}
		set
		{
			SetProperty("weight", value);
		}
	}

	public SpeechGrammar(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
