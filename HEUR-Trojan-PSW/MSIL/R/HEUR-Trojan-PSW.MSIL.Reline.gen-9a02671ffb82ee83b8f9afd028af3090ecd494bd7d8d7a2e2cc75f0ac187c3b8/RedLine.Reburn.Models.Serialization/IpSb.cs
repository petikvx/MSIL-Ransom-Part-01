using System.Runtime.Serialization;

namespace RedLine.Reburn.Models.Serialization;

[DataContract(Name = "IpSb")]
public class IpSb
{
	[DataMember(Name = "postal_code")]
	public string postal_code { get; set; }

	[DataMember(Name = "ip")]
	public string ip { get; set; }

	[DataMember(Name = "country_code")]
	public string country_code { get; set; }
}
