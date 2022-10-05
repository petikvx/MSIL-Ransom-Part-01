using System.Runtime.Serialization;

namespace RedLine.Reburn.Models.Serialization;

[DataContract(Name = "GeoPlugin")]
public class GeoPlugin
{
	[DataMember(Name = "geoplugin_request")]
	public string geoplugin_request { get; set; }

	[DataMember(Name = "geoplugin_city")]
	public string geoplugin_city { get; set; }

	[DataMember(Name = "geoplugin_region")]
	public string geoplugin_region { get; set; }

	[DataMember(Name = "geoplugin_countryCode")]
	public string geoplugin_countryCode { get; set; }

	[DataMember(Name = "geoplugin_latitude")]
	public string geoplugin_latitude { get; set; }

	[DataMember(Name = "geoplugin_longitude")]
	public string geoplugin_longitude { get; set; }
}
