namespace Gecko.WebIDL;

public class SVGElement : WebIDLBase
{
	public string Id
	{
		get
		{
			return GetProperty<string>("id");
		}
		set
		{
			SetProperty("id", value);
		}
	}

	public nsISupports ClassName => GetProperty<nsISupports>("className");

	public nsIDOMCSSStyleDeclaration Style => GetProperty<nsIDOMCSSStyleDeclaration>("style");

	public nsISupports OwnerSVGElement => GetProperty<nsISupports>("ownerSVGElement");

	public nsISupports ViewportElement => GetProperty<nsISupports>("viewportElement");

	public SVGElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
