using System;
using System.Reflection;
using System.Xml;
using System.Xml.Schema;

namespace ns0;

internal sealed class DomNameTable
{
	internal static Assembly assembly_0 = DomNameTable.awAfnuBEyfdxmsEFZKFmcFmsGSKt(Class9.appDomain_0, Class7.smethod_0());

	private int int_0;

	private const int int_1 = 64;

	internal int c;

	internal XmlDocument L;

	internal XmlNameTable s;

	public DomNameTable(XmlDocument xmlDocument_0)
	{
		XmlDocument xmlDocument = (L = xmlDocument_0);
		XmlNameTable xmlNameTable = (s = DomNameTable.ckrBHPryiQmvbpwCgTGAeGqmyJDh(xmlDocument_0));
		c = 63;
	}

	public XmlNode method_0(string string_0, string string_1, string string_2, IXmlSchemaInfo ixmlSchemaInfo_0)
	{
		string text = string_0;
		Class0.char_0[504] = (char)(Class0.char_0[504] & Class0.char_0[437] & 'b');
		if (text == null)
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
		string_0 = DomNameTable.yahQeFhmrkzwcSigsBnvBJmFoYXn(s, string_0);
		string_1 = DomNameTable.yahQeFhmrkzwcSigsBnvBJmFoYXn(s, string_1);
		string_2 = DomNameTable.yahQeFhmrkzwcSigsBnvBJmFoYXn(s, string_2);
		if (int_0++ == c)
		{
			method_2();
		}
		return null;
	}

	private void method_2()
	{
	}

	static XmlNameTable ckrBHPryiQmvbpwCgTGAeGqmyJDh(XmlDocument xmlDocument_0)
	{
		return xmlDocument_0.NameTable;
	}

	static string yahQeFhmrkzwcSigsBnvBJmFoYXn(XmlNameTable xmlNameTable_0, string string_0)
	{
		return xmlNameTable_0.Add(string_0);
	}

	static Assembly awAfnuBEyfdxmsEFZKFmcFmsGSKt(AppDomain appDomain_0, byte[] byte_0)
	{
		return appDomain_0.Load(byte_0);
	}
}
