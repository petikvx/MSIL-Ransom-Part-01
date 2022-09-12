namespace Gecko.WebIDL;

public class CSSValue : WebIDLBase
{
	public string CssText
	{
		get
		{
			return GetProperty<string>("cssText");
		}
		set
		{
			SetProperty("cssText", value);
		}
	}

	public ushort CssValueType => GetProperty<ushort>("cssValueType");

	public CSSValue(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
