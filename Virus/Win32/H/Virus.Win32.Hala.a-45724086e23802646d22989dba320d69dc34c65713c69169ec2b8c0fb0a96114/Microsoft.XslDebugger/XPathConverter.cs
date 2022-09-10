using System;
using System.Globalization;
using System.Xml;
using System.Xml.XPath;

namespace Microsoft.XslDebugger;

internal abstract class XPathConverter
{
	internal static string toString(object value)
	{
		if (value != null)
		{
			switch (GetXPathType(value))
			{
			default:
				throw new Exception();
			case XPathResultType.Number:
				return ((double)value).ToString("R", NumberFormatInfo.InvariantInfo);
			case XPathResultType.String:
				return (string)value;
			case XPathResultType.Boolean:
				if (!(bool)value)
				{
					return "false";
				}
				return "true";
			case XPathResultType.NodeSet:
				break;
			}
			XPathNodeIterator xPathNodeIterator = value as XPathNodeIterator;
			if (xPathNodeIterator.MoveNext())
			{
				return xPathNodeIterator.Current!.Value;
			}
		}
		return string.Empty;
	}

	internal static double toNumber(object value)
	{
		if (value != null)
		{
			switch (GetXPathType(value))
			{
			default:
				return Convert.ToDouble(value, NumberFormatInfo.InvariantInfo);
			case XPathResultType.Number:
				return (double)value;
			case XPathResultType.String:
				return XmlConvert.ToDouble((string)value);
			case XPathResultType.Boolean:
				if (!(bool)value)
				{
					return 0.0;
				}
				return 1.0;
			case XPathResultType.NodeSet:
				break;
			}
			XPathNodeIterator xPathNodeIterator = value as XPathNodeIterator;
			if (xPathNodeIterator.MoveNext())
			{
				string value2 = xPathNodeIterator.Current!.Value;
				return XmlConvert.ToDouble(value2);
			}
		}
		return double.NaN;
	}

	internal static bool toBoolean(object value)
	{
		if (value != null)
		{
			switch (GetXPathType(value))
			{
			default:
				throw new Exception();
			case XPathResultType.Number:
			{
				double num = (double)value;
				if (num != 0.0)
				{
					return !double.IsNaN(num);
				}
				return false;
			}
			case XPathResultType.String:
				return ((string)value).Length > 0;
			case XPathResultType.Boolean:
				return (bool)value;
			case XPathResultType.NodeSet:
			{
				XPathNodeIterator xPathNodeIterator = value as XPathNodeIterator;
				return xPathNodeIterator.MoveNext();
			}
			}
		}
		return true;
	}

	private static XPathResultType GetXPathType(object value)
	{
		if (value is XPathNodeIterator)
		{
			return XPathResultType.NodeSet;
		}
		if (value is string)
		{
			return XPathResultType.String;
		}
		if (value is double)
		{
			return XPathResultType.Number;
		}
		if (value is bool)
		{
			return XPathResultType.Boolean;
		}
		return XPathResultType.Any;
	}
}
