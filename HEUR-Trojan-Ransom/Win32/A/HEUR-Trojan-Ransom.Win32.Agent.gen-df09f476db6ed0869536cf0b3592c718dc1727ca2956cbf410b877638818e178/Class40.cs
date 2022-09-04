using System.Net;
using System.Text;
using System.Xml;

internal class Class40 : Class34
{
	private int int_0;

	public Class40(int int_1, GClass1 gclass1_1)
	{
		Class51.smethod_0();
		base._002Ector(gclass1_1);
		int_0 = int_1;
	}

	public override WebRequest vmethod_0(out byte[] byte_0)
	{
		StringBuilder stringBuilder = new StringBuilder(128);
		XmlWriter xmlWriter = Class34.smethod_2(stringBuilder);
		Class34.smethod_1(xmlWriter, "NewPortMappingIndex", int_0.ToString());
		xmlWriter.Flush();
		return method_0("GetGenericPortMappingEntry", stringBuilder.ToString(), out byte_0);
	}
}
