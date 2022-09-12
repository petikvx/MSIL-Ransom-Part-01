namespace Gecko.WebIDL;

public class SVGFEDiffuseLightingElement : WebIDLBase
{
	public nsISupports In1 => GetProperty<nsISupports>("in1");

	public nsISupports SurfaceScale => GetProperty<nsISupports>("surfaceScale");

	public nsISupports DiffuseConstant => GetProperty<nsISupports>("diffuseConstant");

	public nsISupports KernelUnitLengthX => GetProperty<nsISupports>("kernelUnitLengthX");

	public nsISupports KernelUnitLengthY => GetProperty<nsISupports>("kernelUnitLengthY");

	public SVGFEDiffuseLightingElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
