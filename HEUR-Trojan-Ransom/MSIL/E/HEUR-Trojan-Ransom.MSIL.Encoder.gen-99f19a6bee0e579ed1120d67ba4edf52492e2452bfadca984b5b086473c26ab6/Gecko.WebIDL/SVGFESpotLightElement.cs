namespace Gecko.WebIDL;

public class SVGFESpotLightElement : WebIDLBase
{
	public nsISupports X => GetProperty<nsISupports>("x");

	public nsISupports Y => GetProperty<nsISupports>("y");

	public nsISupports Z => GetProperty<nsISupports>("z");

	public nsISupports PointsAtX => GetProperty<nsISupports>("pointsAtX");

	public nsISupports PointsAtY => GetProperty<nsISupports>("pointsAtY");

	public nsISupports PointsAtZ => GetProperty<nsISupports>("pointsAtZ");

	public nsISupports SpecularExponent => GetProperty<nsISupports>("specularExponent");

	public nsISupports LimitingConeAngle => GetProperty<nsISupports>("limitingConeAngle");

	public SVGFESpotLightElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
