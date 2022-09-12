namespace Gecko.WebIDL;

public class SVGAElement : WebIDLBase
{
	public nsISupports Target => GetProperty<nsISupports>("target");

	public string Download
	{
		get
		{
			return GetProperty<string>("download");
		}
		set
		{
			SetProperty("download", value);
		}
	}

	public SVGAElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
