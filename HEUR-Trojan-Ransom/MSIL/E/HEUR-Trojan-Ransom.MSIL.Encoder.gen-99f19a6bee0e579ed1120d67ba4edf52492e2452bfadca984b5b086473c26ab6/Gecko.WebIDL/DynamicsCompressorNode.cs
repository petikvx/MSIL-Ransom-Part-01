namespace Gecko.WebIDL;

public class DynamicsCompressorNode : WebIDLBase
{
	public nsISupports Threshold => GetProperty<nsISupports>("threshold");

	public nsISupports Knee => GetProperty<nsISupports>("knee");

	public nsISupports Ratio => GetProperty<nsISupports>("ratio");

	public float Reduction => GetProperty<float>("reduction");

	public nsISupports Attack => GetProperty<nsISupports>("attack");

	public nsISupports Release => GetProperty<nsISupports>("release");

	public DynamicsCompressorNode(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
