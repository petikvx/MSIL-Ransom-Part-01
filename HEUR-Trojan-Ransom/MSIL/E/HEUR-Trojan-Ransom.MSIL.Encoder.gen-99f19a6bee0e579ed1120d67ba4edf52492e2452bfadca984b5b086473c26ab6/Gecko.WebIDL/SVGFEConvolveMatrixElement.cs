namespace Gecko.WebIDL;

public class SVGFEConvolveMatrixElement : WebIDLBase
{
	public nsISupports In1 => GetProperty<nsISupports>("in1");

	public nsISupports OrderX => GetProperty<nsISupports>("orderX");

	public nsISupports OrderY => GetProperty<nsISupports>("orderY");

	public nsISupports KernelMatrix => GetProperty<nsISupports>("kernelMatrix");

	public nsISupports Divisor => GetProperty<nsISupports>("divisor");

	public nsISupports Bias => GetProperty<nsISupports>("bias");

	public nsISupports TargetX => GetProperty<nsISupports>("targetX");

	public nsISupports TargetY => GetProperty<nsISupports>("targetY");

	public nsISupports EdgeMode => GetProperty<nsISupports>("edgeMode");

	public nsISupports KernelUnitLengthX => GetProperty<nsISupports>("kernelUnitLengthX");

	public nsISupports KernelUnitLengthY => GetProperty<nsISupports>("kernelUnitLengthY");

	public nsISupports PreserveAlpha => GetProperty<nsISupports>("preserveAlpha");

	public SVGFEConvolveMatrixElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
