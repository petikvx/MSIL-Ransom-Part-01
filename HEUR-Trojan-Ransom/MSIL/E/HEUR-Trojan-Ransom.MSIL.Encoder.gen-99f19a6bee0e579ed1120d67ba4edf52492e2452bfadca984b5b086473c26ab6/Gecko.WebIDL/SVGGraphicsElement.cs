namespace Gecko.WebIDL;

public class SVGGraphicsElement : WebIDLBase
{
	public nsISupports Transform => GetProperty<nsISupports>("transform");

	public nsISupports NearestViewportElement => GetProperty<nsISupports>("nearestViewportElement");

	public nsISupports FarthestViewportElement => GetProperty<nsISupports>("farthestViewportElement");

	public SVGGraphicsElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports GetBBox()
	{
		return CallMethod<nsISupports>("getBBox", new object[0]);
	}

	public nsISupports GetBBox(object aOptions)
	{
		return CallMethod<nsISupports>("getBBox", new object[1] { aOptions });
	}

	public nsISupports GetCTM()
	{
		return CallMethod<nsISupports>("getCTM", new object[0]);
	}

	public nsISupports GetScreenCTM()
	{
		return CallMethod<nsISupports>("getScreenCTM", new object[0]);
	}

	public nsISupports GetTransformToElement(nsISupports element)
	{
		return CallMethod<nsISupports>("getTransformToElement", new object[1] { element });
	}
}
