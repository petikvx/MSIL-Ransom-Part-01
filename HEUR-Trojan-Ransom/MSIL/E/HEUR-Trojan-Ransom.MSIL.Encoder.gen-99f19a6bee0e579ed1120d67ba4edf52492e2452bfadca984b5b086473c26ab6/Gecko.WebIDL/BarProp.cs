namespace Gecko.WebIDL;

public class BarProp : WebIDLBase
{
	public bool Visible
	{
		get
		{
			return GetProperty<bool>("visible");
		}
		set
		{
			SetProperty("visible", value);
		}
	}

	public BarProp(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
