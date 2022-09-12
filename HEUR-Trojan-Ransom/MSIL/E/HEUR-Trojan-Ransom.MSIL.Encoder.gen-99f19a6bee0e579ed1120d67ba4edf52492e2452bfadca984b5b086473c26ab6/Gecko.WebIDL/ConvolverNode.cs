namespace Gecko.WebIDL;

public class ConvolverNode : WebIDLBase
{
	public nsISupports Buffer
	{
		get
		{
			return GetProperty<nsISupports>("buffer");
		}
		set
		{
			SetProperty("buffer", value);
		}
	}

	public bool Normalize
	{
		get
		{
			return GetProperty<bool>("normalize");
		}
		set
		{
			SetProperty("normalize", value);
		}
	}

	public ConvolverNode(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
