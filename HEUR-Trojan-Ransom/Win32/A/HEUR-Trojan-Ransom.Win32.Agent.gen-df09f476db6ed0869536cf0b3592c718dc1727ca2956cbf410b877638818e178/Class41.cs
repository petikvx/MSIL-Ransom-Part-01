using System.Net;
using System.Text;
using System.Xml;

internal class Class41 : Class34
{
	internal GEnum1 genum1_0;

	internal int int_0;

	public Class41(GEnum1 genum1_1, int int_1, GClass1 gclass1_1)
	{
		Class51.smethod_0();
		base._002Ector(gclass1_1);
		genum1_0 = genum1_1;
		int_0 = int_1;
	}

	public override WebRequest vmethod_0(out byte[] byte_0)
	{
		StringBuilder stringBuilder = new StringBuilder(64);
		XmlWriter xmlWriter = Class34.smethod_2(stringBuilder);
		Class34.smethod_1(xmlWriter, "NewRemoteHost", string.Empty);
		Class34.smethod_1(xmlWriter, "NewExternalPort", int_0.ToString());
		Class34.smethod_1(xmlWriter, "NewProtocol", (genum1_0 == (GEnum1)0) ? "TCP" : "UDP");
		xmlWriter.Flush();
		return method_0("GetSpecificPortMappingEntry", stringBuilder.ToString(), out byte_0);
	}
}
