namespace Gecko.WebIDL;

public class BatteryManager : WebIDLBase
{
	public bool Charging => GetProperty<bool>("charging");

	public double ChargingTime => GetProperty<double>("chargingTime");

	public double DischargingTime => GetProperty<double>("dischargingTime");

	public double Level => GetProperty<double>("level");

	public BatteryManager(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
