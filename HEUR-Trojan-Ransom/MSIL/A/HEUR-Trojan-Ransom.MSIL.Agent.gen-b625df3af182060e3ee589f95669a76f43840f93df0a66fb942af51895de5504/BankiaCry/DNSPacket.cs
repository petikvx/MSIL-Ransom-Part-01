using System.Collections.Generic;
using System.Text;

namespace BankiaCry;

internal class DNSPacket
{
	public byte[] TrackID { get; set; }

	public List<string> SubDomains { get; set; }

	public ushort PacketNo { get; set; }

	public DNSInfo.PacketType packetType { get; set; }

	public string Domain { get; set; }

	public DNSPacket(byte[] trackID, List<string> SubDs, ushort pcktNo, DNSInfo.PacketType pcktType, string Domain)
	{
		TrackID = trackID;
		SubDomains = SubDs;
		PacketNo = pcktNo;
		packetType = pcktType;
		this.Domain = Domain;
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (string subDomain in SubDomains)
		{
			stringBuilder.Append(subDomain);
			stringBuilder.Append(".");
		}
		return Encoding.UTF8.GetString(TrackID) + "." + stringBuilder.ToString() + PacketNo + "." + packetType.ToString() + "." + Domain;
	}
}
