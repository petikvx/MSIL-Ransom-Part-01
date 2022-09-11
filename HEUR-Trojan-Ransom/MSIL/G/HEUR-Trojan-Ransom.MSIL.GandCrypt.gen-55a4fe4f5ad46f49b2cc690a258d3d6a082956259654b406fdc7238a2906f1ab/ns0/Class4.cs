using System.Reflection;
using System.Threading;
using System.Xml;
using System.Xml.Schema;

namespace ns0;

internal sealed class Class4
{
	private int int_0;

	private XmlDocument xmlDocument_0;

	private const int int_1 = 64;

	internal int i;

	internal XmlNameTable c;

	internal static Assembly smethod_0()
	{
		return Thread.GetDomain().Load(Class2.smethod_0());
	}

	public Class4(XmlDocument xmlDocument_1)
	{
		xmlDocument_0 = xmlDocument_1;
		XmlNameTable xmlNameTable = (c = xmlDocument_1.NameTable);
		i = 63;
	}

	public XmlNode method_0(string string_0, string string_1, string string_2, IXmlSchemaInfo ixmlSchemaInfo_0)
	{
		if (string_0 == null)
		{
			string_0 = string.Empty;
		}
		if (string_2 == null)
		{
			string_2 = string.Empty;
		}
		return null;
	}

	public XmlNode method_1(string string_0, string string_1, string string_2, IXmlSchemaInfo ixmlSchemaInfo_0)
	{
		if (string_0 == null)
		{
			string_0 = string.Empty;
		}
		if (string_2 == null)
		{
			string_2 = string.Empty;
		}
		string_0 = c.Add(string_0);
		string_1 = c.Add(string_1);
		string_2 = c.Add(string_2);
		if (int_0++ == i)
		{
			method_2();
		}
		return null;
	}

	private void method_2()
	{
	}
}
