namespace Gecko.WebIDL;

public class MozPowerManager : WebIDLBase
{
	public bool ScreenEnabled
	{
		get
		{
			return GetProperty<bool>("screenEnabled");
		}
		set
		{
			SetProperty("screenEnabled", value);
		}
	}

	public bool KeyLightEnabled
	{
		get
		{
			return GetProperty<bool>("keyLightEnabled");
		}
		set
		{
			SetProperty("keyLightEnabled", value);
		}
	}

	public double ScreenBrightness
	{
		get
		{
			return GetProperty<double>("screenBrightness");
		}
		set
		{
			SetProperty("screenBrightness", value);
		}
	}

	public bool CpuSleepAllowed
	{
		get
		{
			return GetProperty<bool>("cpuSleepAllowed");
		}
		set
		{
			SetProperty("cpuSleepAllowed", value);
		}
	}

	public MozPowerManager(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void PowerOff()
	{
		CallVoidMethod("powerOff");
	}

	public void Reboot()
	{
		CallVoidMethod("reboot");
	}

	public void FactoryReset()
	{
		CallVoidMethod("factoryReset");
	}

	public void FactoryReset(FactoryResetReason reason)
	{
		CallVoidMethod("factoryReset", reason);
	}

	public void AddWakeLockListener(nsISupports aListener)
	{
		CallVoidMethod("addWakeLockListener", aListener);
	}

	public void RemoveWakeLockListener(nsISupports aListener)
	{
		CallVoidMethod("removeWakeLockListener", aListener);
	}

	public string GetWakeLockState(string aTopic)
	{
		return CallMethod<string>("getWakeLockState", new object[1] { aTopic });
	}
}
