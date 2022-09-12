namespace Gecko.WebIDL;

public class SVGFETurbulenceElement : WebIDLBase
{
	public nsISupports BaseFrequencyX => GetProperty<nsISupports>("baseFrequencyX");

	public nsISupports BaseFrequencyY => GetProperty<nsISupports>("baseFrequencyY");

	public nsISupports NumOctaves => GetProperty<nsISupports>("numOctaves");

	public nsISupports Seed => GetProperty<nsISupports>("seed");

	public nsISupports StitchTiles => GetProperty<nsISupports>("stitchTiles");

	public nsISupports Type => GetProperty<nsISupports>("type");

	public SVGFETurbulenceElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
