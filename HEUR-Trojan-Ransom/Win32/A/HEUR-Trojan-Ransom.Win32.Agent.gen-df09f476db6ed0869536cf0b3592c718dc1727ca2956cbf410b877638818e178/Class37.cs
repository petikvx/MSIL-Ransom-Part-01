using System.Globalization;
using System.Net;
using System.Text;
using System.Xml;

internal class Class37 : Class34
{
	private IPAddress ipaddress_0;

	private GClass2 gclass2_0;

	public Class37(GClass2 gclass2_1, IPAddress ipaddress_1, GClass1 gclass1_1)
	{
		Class51.smethod_0();
		base._002Ector(gclass1_1);
		gclass2_0 = gclass2_1;
		ipaddress_0 = ipaddress_1;
	}

	public override WebRequest vmethod_0(out byte[] byte_0)
	{
		CultureInfo invariantCulture = CultureInfo.InvariantCulture;
		StringBuilder stringBuilder = new StringBuilder(256);
		XmlWriter xmlWriter = Class34.smethod_2(stringBuilder);
		Class34.smethod_1(xmlWriter, "NewRemoteHost", string.Empty);
		Class34.smethod_1(xmlWriter, "NewExternalPort", gclass2_0.method_4().ToString(invariantCulture));
		Class34.smethod_1(xmlWriter, "NewProtocol", (gclass2_0.method_0() == (GEnum1)0) ? "TCP" : "UDP");
		Class34.smethod_1(xmlWriter, "NewInternalPort", gclass2_0.method_2().ToString(invariantCulture));
		Class34.smethod_1(xmlWriter, "NewInternalClient", ipaddress_0.ToString());
		Class34.smethod_1(xmlWriter, "NewEnabled", "1");
		Class34.smethod_1(xmlWriter, "NewPortMappingDescription", string.IsNullOrEmpty(gclass2_0.Description) ? "Torrent NAT" : gclass2_0.Description);
		Class34.smethod_1(xmlWriter, "NewLeaseDuration", gclass2_0.method_6().ToString());
		xmlWriter.Flush();
		return method_0("AddPortMapping", stringBuilder.ToString(), out byte_0);
	}
}
