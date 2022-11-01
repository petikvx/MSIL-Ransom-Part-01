using System;
using System.Collections.Generic;
using RestSharp.Deserializers;

namespace VirusTotalNET.Objects;

public class DomainReport
{
	[DeserializeAs(Name = "Alexa category")]
	public string AlexaCategory { get; set; }

	[DeserializeAs(Name = "Alexa domain info")]
	public string AlexaDomainInfo { get; set; }

	[DeserializeAs(Name = "Alexa rank")]
	public int AlexaRank { get; set; }

	[DeserializeAs(Name = "BitDefender category")]
	public string BitDefenderCategory { get; set; }

	[DeserializeAs(Name = "BitDefender domain info")]
	public string BitDefenderDomainInfo { get; set; }

	public List<string> Categories { get; set; }

	public List<Sample> DetectedCommunicatingSamples { get; set; }

	public List<Sample> DetectedDownloadedSamples { get; set; }

	public List<Sample> DetectedReferrerSamples { get; set; }

	public List<DetectedUrl> DetectedUrls { get; set; }

	[DeserializeAs(Name = "Dr.Web category")]
	public string DrWebCategory { get; set; }

	[DeserializeAs(Name = "Opera domain info")]
	public string OperaDomainInfo { get; set; }

	public List<string> Pcaps { get; set; }

	public List<Resolution> Resolutions { get; set; }

	public ReportResponseCode ResponseCode { get; set; }

	public List<string> Subdomains { get; set; }

	[DeserializeAs(Name = "TrendMicro category")]
	public string TrendMicroCategory { get; set; }

	public List<Sample> UndetectedCommunicatingSamples { get; set; }

	public List<Sample> UndetectedDownloadedSamples { get; set; }

	public List<Sample> UndetectedReferrerSamples { get; set; }

	public string VerboseMsg { get; set; }

	[DeserializeAs(Name = "Websense ThreatSeeker category")]
	public string WebsenseThreatSeekerCategory { get; set; }

	[DeserializeAs(Name = "Webutation domain info")]
	public WebutationInfo WebutationDomainInfo { get; set; }

	[DeserializeAs(Name = "whois")]
	public string WhoIs { get; set; }

	[DeserializeAs(Name = "whois_timestamp")]
	public string WhoIsTimestamp { get; set; }

	public DateTime WhoIsDateTime
	{
		get
		{
			return UnixTimeHelper.FromUnix(double.Parse(WhoIsTimestamp));
		}
		set
		{
			WhoIsTimestamp = UnixTimeHelper.FromDateTime(value).ToString();
		}
	}

	[DeserializeAs(Name = "WOT domain info")]
	public WotInfo WOTDomainInfo { get; set; }
}
