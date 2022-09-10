using System;
using System.Collections.Generic;

namespace Microsoft.Tools.ServiceModel.ComSvcConfig;

internal class EndpointConfig
{
	private Guid appid;

	private Guid clsid;

	private Guid iid;

	private string bindingType;

	private string bindingName;

	private Uri address;

	private bool isMexEndpoint;

	private List<string> methods;

	private EndpointConfigContainer container;

	public static readonly string TempURI = "http://tempuri.org/";

	public static readonly string MexEndpointSuffix = "mex";

	public Guid Appid
	{
		get
		{
			return appid;
		}
		set
		{
			appid = value;
		}
	}

	public Guid Clsid => clsid;

	public Guid Iid => iid;

	public string BindingType => bindingType;

	public string BindingName => bindingName;

	public Uri Address => address;

	public bool IsMexEndpoint => isMexEndpoint;

	public EndpointConfigContainer Container
	{
		get
		{
			return container;
		}
		set
		{
			container = value;
		}
	}

	public IList<string> Methods
	{
		get
		{
			return methods;
		}
		set
		{
			methods = (List<string>)value;
		}
	}

	public string ContractType
	{
		get
		{
			if (isMexEndpoint)
			{
				return "IMetadataExchange";
			}
			return iid.ToString("B").ToUpperInvariant();
		}
	}

	public string ServiceType => Appid.ToString("B").ToUpperInvariant() + "," + Clsid.ToString("B").ToUpperInvariant();

	public string ApplicationName => ComAdminWrapper.GetAppInfo(appid.ToString("B"))?.Name;

	public string ComponentProgID => ComAdminWrapper.GetAppInfo(appid.ToString("B"))?.FindClass(clsid.ToString("B"))?.Name;

	public string InterfaceName
	{
		get
		{
			if (!isMexEndpoint)
			{
				return ComAdminWrapper.GetAppInfo(appid.ToString("B"))?.FindClass(clsid.ToString("B"))?.FindInterface(iid.ToString("B"))?.Name;
			}
			return ContractType;
		}
	}

	public bool MatchServiceType(string serviceType)
	{
		string[] array = serviceType.Split(new char[1] { ',' });
		if (array.Length != 2)
		{
			return false;
		}
		try
		{
			Guid guid = new Guid(array[0]);
			if (guid != Appid)
			{
				return false;
			}
			guid = new Guid(array[1]);
			if (guid != Clsid)
			{
				return false;
			}
			return true;
		}
		catch (FormatException)
		{
		}
		return false;
	}

	public bool MatchContract(string contract)
	{
		if (isMexEndpoint)
		{
			if (ContractType == contract)
			{
				return true;
			}
			return false;
		}
		try
		{
			Guid guid = new Guid(contract);
			if (guid == Iid)
			{
				return true;
			}
		}
		catch (FormatException)
		{
		}
		return false;
	}

	public EndpointConfig(Guid appid, Guid clsid, Guid iid, string bindingType, string bindingName, Uri address, bool isMexEndpoint, List<string> methods)
	{
		this.appid = appid;
		this.clsid = clsid;
		this.iid = iid;
		this.bindingType = bindingType;
		this.bindingName = bindingName;
		this.address = address;
		this.isMexEndpoint = isMexEndpoint;
		this.methods = methods;
		container = null;
	}
}
