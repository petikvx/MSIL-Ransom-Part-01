namespace Gecko.WebIDL;

public class SVGFEDropShadowElement : WebIDLBase
{
	public nsISupports In1 => GetProperty<nsISupports>("in1");

	public nsISupports Dx => GetProperty<nsISupports>("dx");

	public nsISupports Dy => GetProperty<nsISupports>("dy");

	public nsISupports StdDeviationX => GetProperty<nsISupports>("stdDeviationX");

	public nsISupports StdDeviationY => GetProperty<nsISupports>("stdDeviationY");

	public SVGFEDropShadowElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void SetStdDeviation(float stdDeviationX, float stdDeviationY)
	{
		CallVoidMethod("setStdDeviation", stdDeviationX, stdDeviationY);
	}
}
