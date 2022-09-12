namespace Gecko.WebIDL;

public class StyleSheet : WebIDLBase
{
	public string Type => GetProperty<string>("type");

	public string Href => GetProperty<string>("href");

	public nsIDOMNode OwnerNode => GetProperty<nsIDOMNode>("ownerNode");

	public nsISupports ParentStyleSheet => GetProperty<nsISupports>("parentStyleSheet");

	public string Title => GetProperty<string>("title");

	public nsISupports Media => GetProperty<nsISupports>("media");

	public bool Disabled
	{
		get
		{
			return GetProperty<bool>("disabled");
		}
		set
		{
			SetProperty("disabled", value);
		}
	}

	public StyleSheet(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
