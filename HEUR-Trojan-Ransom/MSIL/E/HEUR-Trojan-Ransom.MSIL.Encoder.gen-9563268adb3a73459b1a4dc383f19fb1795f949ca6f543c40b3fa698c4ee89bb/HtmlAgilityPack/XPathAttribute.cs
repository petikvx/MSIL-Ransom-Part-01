using System;

namespace HtmlAgilityPack;

[AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
public sealed class XPathAttribute : Attribute
{
	public string XPath { get; }

	public string AttributeName { get; set; }

	public ReturnType NodeReturnType { get; set; }

	public XPathAttribute(string xpathString)
	{
		XPath = xpathString;
		NodeReturnType = ReturnType.InnerText;
	}

	public XPathAttribute(string xpathString, ReturnType nodeReturnType)
	{
		XPath = xpathString;
		NodeReturnType = nodeReturnType;
	}

	public XPathAttribute(string xpathString, string attributeName)
	{
		XPath = xpathString;
		AttributeName = attributeName;
	}
}
