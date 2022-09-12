namespace Gecko.WebIDL;

public class SVGFEGaussianBlurElement : WebIDLBase
{
	public nsISupports In1 => GetProperty<nsISupports>("in1");

	public nsISupports StdDeviationX => GetProperty<nsISupports>("stdDeviationX");

	public nsISupports StdDeviationY => GetProperty<nsISupports>("stdDeviationY");

	public SVGFEGaussianBlurElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void SetStdDeviation(float stdDeviationX, float stdDeviationY)
	{
		CallVoidMethod("setStdDeviation", stdDeviationX, stdDeviationY);
	}
}
