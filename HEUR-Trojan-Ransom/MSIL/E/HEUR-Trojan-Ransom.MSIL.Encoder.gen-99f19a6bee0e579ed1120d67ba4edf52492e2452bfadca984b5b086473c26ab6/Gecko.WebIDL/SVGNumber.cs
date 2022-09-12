namespace Gecko.WebIDL;

public class SVGNumber : WebIDLBase
{
	public float Value
	{
		get
		{
			return GetProperty<float>("value");
		}
		set
		{
			SetProperty("value", value);
		}
	}

	public SVGNumber(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
