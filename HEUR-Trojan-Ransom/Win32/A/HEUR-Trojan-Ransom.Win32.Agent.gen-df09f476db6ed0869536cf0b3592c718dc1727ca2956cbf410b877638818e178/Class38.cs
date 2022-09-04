using System.Net;
using System.Text;
using System.Xml;

internal class Class38 : Class34
{
	private GClass2 gclass2_0;

	public Class38(GClass2 gclass2_1, GClass1 gclass1_1)
	{
		Class51.smethod_0();
		base._002Ector(gclass1_1);
		gclass2_0 = gclass2_1;
	}

	public override WebRequest vmethod_0(out byte[] byte_0)
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		XmlWriter xmlWriter = Class34.smethod_2(stringBuilder);
		Class34.smethod_1(xmlWriter, "NewRemoteHost", string.Empty);
		Class34.smethod_1(xmlWriter, "NewExternalPort", gclass2_0.method_4().ToString(Class34.cultureInfo_0));
		Class34.smethod_1(xmlWriter, "NewProtocol", (gclass2_0.method_0() == (GEnum1)0) ? "TCP" : "UDP");
		xmlWriter.Flush();
		return method_0("DeletePortMapping", stringBuilder.ToString(), out byte_0);
	}
}
