namespace Gecko.WebIDL;

public class SVGFESpecularLightingElement : WebIDLBase
{
	public nsISupports In1 => GetProperty<nsISupports>("in1");

	public nsISupports SurfaceScale => GetProperty<nsISupports>("surfaceScale");

	public nsISupports SpecularConstant => GetProperty<nsISupports>("specularConstant");

	public nsISupports SpecularExponent => GetProperty<nsISupports>("specularExponent");

	public nsISupports KernelUnitLengthX => GetProperty<nsISupports>("kernelUnitLengthX");

	public nsISupports KernelUnitLengthY => GetProperty<nsISupports>("kernelUnitLengthY");

	public SVGFESpecularLightingElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
