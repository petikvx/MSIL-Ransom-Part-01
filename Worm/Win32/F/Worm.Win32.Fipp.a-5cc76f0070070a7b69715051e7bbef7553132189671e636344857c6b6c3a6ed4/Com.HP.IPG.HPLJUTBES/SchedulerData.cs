using System.Xml.Serialization;

namespace Com.HP.IPG.HPLJUTBES;

public class SchedulerData
{
	[XmlElement("FID")]
	public string FirstInstallDate { get; set; }

	[XmlElement("OI")]
	public bool OptedIn { get; set; }

	[XmlElement("TN")]
	public bool TransmissionNotification { get; set; }

	[XmlElement("OID")]
	public bool OptInDisplayed { get; set; }

	[XmlElement("OIRL")]
	public bool OptInRemindLater { get; set; }

	[XmlElement("OISD")]
	public string OptInRemindStartDate { get; set; }

	[XmlElement("OITD")]
	public string OptInTransmissionDate { get; set; }

	[XmlElement("OITA")]
	public bool OptInTransmitApproved { get; set; }
}
