using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Xml;

internal class Class45 : Class34
{
	private string string_0;

	private int int_0;

	private GEnum1 genum1_0;

	private int int_1;

	private string string_1;

	private bool bool_0;

	private string string_2;

	private int int_2;

	[SpecialName]
	public string method_1()
	{
		return string_0;
	}

	[SpecialName]
	public int method_2()
	{
		return int_0;
	}

	[SpecialName]
	public GEnum1 method_3()
	{
		return genum1_0;
	}

	[SpecialName]
	public int method_4()
	{
		return int_1;
	}

	[SpecialName]
	public string method_5()
	{
		return string_1;
	}

	[SpecialName]
	public bool method_6()
	{
		return bool_0;
	}

	[SpecialName]
	public string method_7()
	{
		return string_2;
	}

	[SpecialName]
	public int method_8()
	{
		return int_2;
	}

	public Class45(XmlNode xmlNode_0, bool bool_1)
	{
		Class51.smethod_0();
		base._002Ector(null);
		string_0 = (bool_1 ? xmlNode_0["NewRemoteHost"]!.InnerText : string.Empty);
		int_0 = (bool_1 ? Convert.ToInt32(xmlNode_0["NewExternalPort"]!.InnerText) : (-1));
		if (bool_1)
		{
			genum1_0 = ((!xmlNode_0["NewProtocol"]!.InnerText.Equals("TCP", StringComparison.InvariantCultureIgnoreCase)) ? ((GEnum1)1) : ((GEnum1)0));
		}
		else
		{
			genum1_0 = (GEnum1)1;
		}
		int_1 = Convert.ToInt32(xmlNode_0["NewInternalPort"]!.InnerText);
		string_1 = xmlNode_0["NewInternalClient"]!.InnerText;
		bool_0 = ((xmlNode_0["NewEnabled"]!.InnerText == "1") ? true : false);
		string_2 = xmlNode_0["NewPortMappingDescription"]!.InnerText;
		int_2 = Convert.ToInt32(xmlNode_0["NewLeaseDuration"]!.InnerText);
	}

	public override WebRequest vmethod_0(out byte[] byte_0)
	{
		throw new NotImplementedException();
	}
}
