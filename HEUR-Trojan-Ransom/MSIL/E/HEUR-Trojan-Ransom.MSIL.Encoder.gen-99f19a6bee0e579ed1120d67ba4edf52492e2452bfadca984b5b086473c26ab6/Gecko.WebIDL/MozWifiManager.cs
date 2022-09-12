namespace Gecko.WebIDL;

public class MozWifiManager : WebIDLBase
{
	public bool Enabled => GetProperty<bool>("enabled");

	public string MacAddress => GetProperty<string>("macAddress");

	public nsISupports Connection => GetProperty<nsISupports>("connection");

	public nsISupports ConnectionInformation => GetProperty<nsISupports>("connectionInformation");

	public nsISupports Capabilities => GetProperty<nsISupports>("capabilities");

	public MozWifiManager(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports SetWifiEnabled(bool enabled)
	{
		return CallMethod<nsISupports>("setWifiEnabled", new object[1] { enabled });
	}

	public nsISupports GetNetworks()
	{
		return CallMethod<nsISupports>("getNetworks", new object[0]);
	}

	public nsISupports GetKnownNetworks()
	{
		return CallMethod<nsISupports>("getKnownNetworks", new object[0]);
	}

	public nsISupports Associate(nsISupports network)
	{
		return CallMethod<nsISupports>("associate", new object[1] { network });
	}

	public nsISupports Forget(nsISupports network)
	{
		return CallMethod<nsISupports>("forget", new object[1] { network });
	}

	public nsISupports Wps()
	{
		return CallMethod<nsISupports>("wps", new object[0]);
	}

	public nsISupports Wps(object detail)
	{
		return CallMethod<nsISupports>("wps", new object[1] { detail });
	}

	public nsISupports SetPowerSavingMode(bool enabled)
	{
		return CallMethod<nsISupports>("setPowerSavingMode", new object[1] { enabled });
	}

	public nsISupports SetStaticIpMode(nsISupports network)
	{
		return CallMethod<nsISupports>("setStaticIpMode", new object[1] { network });
	}

	public nsISupports SetStaticIpMode(nsISupports network, object info)
	{
		return CallMethod<nsISupports>("setStaticIpMode", new object[2] { network, info });
	}

	public nsISupports SetHttpProxy(nsISupports network, object info)
	{
		return CallMethod<nsISupports>("setHttpProxy", new object[2] { network, info });
	}

	public nsISupports ImportCert(nsIDOMBlob certBlob, string certPassword, string certNickname)
	{
		return CallMethod<nsISupports>("importCert", new object[3] { certBlob, certPassword, certNickname });
	}

	public nsISupports GetImportedCerts()
	{
		return CallMethod<nsISupports>("getImportedCerts", new object[0]);
	}

	public nsISupports DeleteCert(string certNickname)
	{
		return CallMethod<nsISupports>("deleteCert", new object[1] { certNickname });
	}
}
