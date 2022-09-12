namespace Gecko.WebIDL;

public class AudioNodePassThrough : WebIDLBase
{
	public bool PassThrough
	{
		get
		{
			return GetProperty<bool>("passThrough");
		}
		set
		{
			SetProperty("passThrough", value);
		}
	}

	public AudioNodePassThrough(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
