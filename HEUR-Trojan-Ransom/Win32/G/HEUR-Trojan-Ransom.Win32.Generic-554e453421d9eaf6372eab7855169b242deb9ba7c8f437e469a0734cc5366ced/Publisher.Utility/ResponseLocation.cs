using System.Xml.Serialization;

namespace Publisher.Utility;

[XmlRoot(ElementName = "Response")]
public class ResponseLocation
{
	[XmlElement(ElementName = "City")]
	public string City { get; set; }

	[XmlElement(ElementName = "CountryCode")]
	public string CountryCode { get; set; }

	[XmlElement(ElementName = "CountryName")]
	public string CountryName { get; set; }

	[XmlElement(ElementName = "IP")]
	public string IP { get; set; }

	[XmlElement(ElementName = "Latitude")]
	public string Latitude { get; set; }

	[XmlElement(ElementName = "Longitude")]
	public string Longitude { get; set; }

	[XmlElement(ElementName = "MetroCode")]
	public string MetroCode { get; set; }

	[XmlElement(ElementName = "RegionCode")]
	public string RegionCode { get; set; }

	[XmlElement(ElementName = "RegionName")]
	public string RegionName { get; set; }

	[XmlElement(ElementName = "TimeZone")]
	public string TimeZone { get; set; }

	[XmlElement(ElementName = "ZipCode")]
	public string ZipCode { get; set; }

	public ResponseLocation()
	{
		GiOi69Nu40oLJlYfZtC(this);
	}

	internal static bool s5sCtbNNvi1t9aYiIdO()
	{
		return true;
	}

	internal static bool gGaiFeNZshkXynTQEZg()
	{
		return false;
	}

	internal static void GiOi69Nu40oLJlYfZtC(object object_0)
	{
		object_0._002Ector();
	}
}
