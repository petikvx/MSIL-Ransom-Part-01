namespace Gecko.WebIDL;

public class MozMobileConnection : WebIDLBase
{
	public string LastKnownNetwork => GetProperty<string>("lastKnownNetwork");

	public string LastKnownHomeNetwork => GetProperty<string>("lastKnownHomeNetwork");

	public nsISupports Voice => GetProperty<nsISupports>("voice");

	public nsISupports Data => GetProperty<nsISupports>("data");

	public string IccId => GetProperty<string>("iccId");

	public MobileNetworkSelectionMode NetworkSelectionMode => GetProperty<MobileNetworkSelectionMode>("networkSelectionMode");

	public MobileRadioState RadioState => GetProperty<MobileRadioState>("radioState");

	public MobileNetworkType[] SupportedNetworkTypes => GetProperty<MobileNetworkType[]>("supportedNetworkTypes");

	public MozMobileConnection(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports GetNetworks()
	{
		return CallMethod<nsISupports>("getNetworks", new object[0]);
	}

	public nsISupports SelectNetwork(nsISupports network)
	{
		return CallMethod<nsISupports>("selectNetwork", new object[1] { network });
	}

	public nsISupports SelectNetworkAutomatically()
	{
		return CallMethod<nsISupports>("selectNetworkAutomatically", new object[0]);
	}

	public nsISupports SetPreferredNetworkType(MobilePreferredNetworkType type)
	{
		return CallMethod<nsISupports>("setPreferredNetworkType", new object[1] { type });
	}

	public nsISupports GetPreferredNetworkType()
	{
		return CallMethod<nsISupports>("getPreferredNetworkType", new object[0]);
	}

	public nsISupports SetRoamingPreference(MobileRoamingMode mode)
	{
		return CallMethod<nsISupports>("setRoamingPreference", new object[1] { mode });
	}

	public nsISupports GetRoamingPreference()
	{
		return CallMethod<nsISupports>("getRoamingPreference", new object[0]);
	}

	public nsISupports SetVoicePrivacyMode(bool enabled)
	{
		return CallMethod<nsISupports>("setVoicePrivacyMode", new object[1] { enabled });
	}

	public nsISupports GetVoicePrivacyMode()
	{
		return CallMethod<nsISupports>("getVoicePrivacyMode", new object[0]);
	}

	public nsISupports SetCallForwardingOption()
	{
		return CallMethod<nsISupports>("setCallForwardingOption", new object[0]);
	}

	public nsISupports SetCallForwardingOption(object options)
	{
		return CallMethod<nsISupports>("setCallForwardingOption", new object[1] { options });
	}

	public nsISupports GetCallForwardingOption(ushort reason)
	{
		return CallMethod<nsISupports>("getCallForwardingOption", new object[1] { reason });
	}

	public nsISupports SetCallBarringOption()
	{
		return CallMethod<nsISupports>("setCallBarringOption", new object[0]);
	}

	public nsISupports SetCallBarringOption(object options)
	{
		return CallMethod<nsISupports>("setCallBarringOption", new object[1] { options });
	}

	public nsISupports GetCallBarringOption()
	{
		return CallMethod<nsISupports>("getCallBarringOption", new object[0]);
	}

	public nsISupports GetCallBarringOption(object options)
	{
		return CallMethod<nsISupports>("getCallBarringOption", new object[1] { options });
	}

	public nsISupports ChangeCallBarringPassword()
	{
		return CallMethod<nsISupports>("changeCallBarringPassword", new object[0]);
	}

	public nsISupports ChangeCallBarringPassword(object options)
	{
		return CallMethod<nsISupports>("changeCallBarringPassword", new object[1] { options });
	}

	public nsISupports SetCallWaitingOption(bool enabled)
	{
		return CallMethod<nsISupports>("setCallWaitingOption", new object[1] { enabled });
	}

	public nsISupports GetCallWaitingOption()
	{
		return CallMethod<nsISupports>("getCallWaitingOption", new object[0]);
	}

	public nsISupports SetCallingLineIdRestriction(ushort mode)
	{
		return CallMethod<nsISupports>("setCallingLineIdRestriction", new object[1] { mode });
	}

	public nsISupports GetCallingLineIdRestriction()
	{
		return CallMethod<nsISupports>("getCallingLineIdRestriction", new object[0]);
	}

	public nsISupports ExitEmergencyCbMode()
	{
		return CallMethod<nsISupports>("exitEmergencyCbMode", new object[0]);
	}

	public nsISupports SetRadioEnabled(bool enabled)
	{
		return CallMethod<nsISupports>("setRadioEnabled", new object[1] { enabled });
	}
}
