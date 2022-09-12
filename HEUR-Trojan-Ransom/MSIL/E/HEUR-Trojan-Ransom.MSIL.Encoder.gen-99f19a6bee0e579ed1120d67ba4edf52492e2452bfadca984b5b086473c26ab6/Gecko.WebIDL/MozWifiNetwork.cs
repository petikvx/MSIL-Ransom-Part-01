namespace Gecko.WebIDL;

public class MozWifiNetwork : WebIDLBase
{
	public string Ssid => GetProperty<string>("ssid");

	public int Mode => GetProperty<int>("mode");

	public int Frequency => GetProperty<int>("frequency");

	public string[] Security => GetProperty<string[]>("security");

	public string[] Capabilities => GetProperty<string[]>("capabilities");

	public bool Known => GetProperty<bool>("known");

	public bool Connected => GetProperty<bool>("connected");

	public bool Hidden => GetProperty<bool>("hidden");

	public string Bssid
	{
		get
		{
			return GetProperty<string>("bssid");
		}
		set
		{
			SetProperty("bssid", value);
		}
	}

	public string SignalStrength
	{
		get
		{
			return GetProperty<string>("signalStrength");
		}
		set
		{
			SetProperty("signalStrength", value);
		}
	}

	public int? RelSignalStrength
	{
		get
		{
			return GetProperty<int?>("relSignalStrength");
		}
		set
		{
			SetProperty("relSignalStrength", value);
		}
	}

	public string Psk
	{
		get
		{
			return GetProperty<string>("psk");
		}
		set
		{
			SetProperty("psk", value);
		}
	}

	public string Wep
	{
		get
		{
			return GetProperty<string>("wep");
		}
		set
		{
			SetProperty("wep", value);
		}
	}

	public string Wep_key0
	{
		get
		{
			return GetProperty<string>("wep_key0");
		}
		set
		{
			SetProperty("wep_key0", value);
		}
	}

	public string Wep_key1
	{
		get
		{
			return GetProperty<string>("wep_key1");
		}
		set
		{
			SetProperty("wep_key1", value);
		}
	}

	public string Wep_key2
	{
		get
		{
			return GetProperty<string>("wep_key2");
		}
		set
		{
			SetProperty("wep_key2", value);
		}
	}

	public string Wep_key3
	{
		get
		{
			return GetProperty<string>("wep_key3");
		}
		set
		{
			SetProperty("wep_key3", value);
		}
	}

	public int? Wep_tx_keyidx
	{
		get
		{
			return GetProperty<int?>("wep_tx_keyidx");
		}
		set
		{
			SetProperty("wep_tx_keyidx", value);
		}
	}

	public int? Priority
	{
		get
		{
			return GetProperty<int?>("priority");
		}
		set
		{
			SetProperty("priority", value);
		}
	}

	public int? Scan_ssid
	{
		get
		{
			return GetProperty<int?>("scan_ssid");
		}
		set
		{
			SetProperty("scan_ssid", value);
		}
	}

	public string KeyManagement
	{
		get
		{
			return GetProperty<string>("keyManagement");
		}
		set
		{
			SetProperty("keyManagement", value);
		}
	}

	public string Identity
	{
		get
		{
			return GetProperty<string>("identity");
		}
		set
		{
			SetProperty("identity", value);
		}
	}

	public string Password
	{
		get
		{
			return GetProperty<string>("password");
		}
		set
		{
			SetProperty("password", value);
		}
	}

	public string Auth_alg
	{
		get
		{
			return GetProperty<string>("auth_alg");
		}
		set
		{
			SetProperty("auth_alg", value);
		}
	}

	public string Phase1
	{
		get
		{
			return GetProperty<string>("phase1");
		}
		set
		{
			SetProperty("phase1", value);
		}
	}

	public string Phase2
	{
		get
		{
			return GetProperty<string>("phase2");
		}
		set
		{
			SetProperty("phase2", value);
		}
	}

	public string Eap
	{
		get
		{
			return GetProperty<string>("eap");
		}
		set
		{
			SetProperty("eap", value);
		}
	}

	public string Pin
	{
		get
		{
			return GetProperty<string>("pin");
		}
		set
		{
			SetProperty("pin", value);
		}
	}

	public bool? DontConnect
	{
		get
		{
			return GetProperty<bool?>("dontConnect");
		}
		set
		{
			SetProperty("dontConnect", value);
		}
	}

	public string ServerCertificate
	{
		get
		{
			return GetProperty<string>("serverCertificate");
		}
		set
		{
			SetProperty("serverCertificate", value);
		}
	}

	public string SubjectMatch
	{
		get
		{
			return GetProperty<string>("subjectMatch");
		}
		set
		{
			SetProperty("subjectMatch", value);
		}
	}

	public string UserCertificate
	{
		get
		{
			return GetProperty<string>("userCertificate");
		}
		set
		{
			SetProperty("userCertificate", value);
		}
	}

	public MozWifiNetwork(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
