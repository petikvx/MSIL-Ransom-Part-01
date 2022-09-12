using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace Examine.LuceneEngine;

public static class ExamineXmlExtensions
{
	public static XElement ToExamineXml(this Dictionary<string, string> data, int nodeId, string nodeType)
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		List<XElement> list = new List<XElement>();
		foreach (KeyValuePair<string, string> datum in data)
		{
			if (!string.IsNullOrWhiteSpace(datum.Value))
			{
				XName obj = XName.op_Implicit("data");
				object[] array = new object[Convert.ToInt32(2.0)];
				array[0] = (object)new XAttribute(XName.op_Implicit("alias"), (object)datum.Key);
				array[1] = (object)new XCData(datum.Value);
				list.Add(new XElement(obj, array));
			}
		}
		XName obj2 = XName.op_Implicit("node");
		object[] array2 = new object[Convert.ToInt32(2.0 + Math.Truncate(1.5))];
		array2[0] = (object)new XAttribute(XName.op_Implicit("id"), (object)nodeId);
		array2[1] = (object)new XAttribute(XName.op_Implicit("nodeTypeAlias"), (object)nodeType);
		array2[Convert.ToInt32(3.5574077246549023 - Math.Tan(1.0))] = list;
		return new XElement(obj2, array2);
	}

	public static XElement ToXElement(this XmlNode node)
	{
		using XmlNodeReader xmlNodeReader = new XmlNodeReader(node);
		xmlNodeReader.MoveToContent();
		return XElement.Load((XmlReader)xmlNodeReader);
	}

	public static XDocument ToXDocument(this IEnumerable<XElement> elements)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		if (elements.Any())
		{
			return new XDocument(new object[1] { (object)new XElement(XName.op_Implicit("nodes"), (object)elements) });
		}
		return null;
	}

	public static XDocument ToXDocument(this XPathNodeIterator xml)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		if (xml.Count == 1)
		{
			if (xml.MoveNext())
			{
				XPathNavigator xPathNavigator = xml.Current!.CreateNavigator();
				if (xPathNavigator.MoveToFirstChild() && xPathNavigator.LocalName == "root")
				{
					return null;
				}
				return XDocument.Load(xml.Current!.ReadSubtree());
			}
			return null;
		}
		if (xml.Count > 1)
		{
			XDocument val = new XDocument(new object[1] { (object)new XElement(XName.op_Implicit("nodes")) });
			XElement val2 = ((XContainer)val).Elements().First();
			while (xml.MoveNext())
			{
				((XContainer)val2).Add((object)XElement.Load(xml.Current!.ReadSubtree()));
			}
			return val;
		}
		return null;
	}

	public static bool IsExamineProperty(this XElement x, string alias)
	{
		if (!(x.get_Name() == XName.op_Implicit(alias)) && (!(x.get_Name() == XName.op_Implicit("data")) || !((string)x.Attribute(XName.op_Implicit("nodeTypeAlias")) == alias)))
		{
			return false;
		}
		return true;
	}

	public static bool IsExamineElement(this XElement x)
	{
		string text = (string)x.Attribute(XName.op_Implicit("id"));
		if (string.IsNullOrEmpty(text))
		{
			return false;
		}
		if (int.TryParse(text, out var result) && result > 0)
		{
			return true;
		}
		return false;
	}

	public static string ExamineNodeTypeAlias(this XElement x)
	{
		if (!string.IsNullOrEmpty((string)x.Attribute(XName.op_Implicit("nodeTypeAlias"))))
		{
			return (string)x.Attribute(XName.op_Implicit("nodeTypeAlias"));
		}
		return x.get_Name().get_LocalName();
	}

	public static string SelectExaminePropertyValue(this XElement x, string alias)
	{
		if (alias == "nodeTypeAlias")
		{
			return x.ExamineNodeTypeAlias();
		}
		return (string)x.Attribute(XName.op_Implicit(alias));
	}

	internal static string SelectExaminePropertyValue(this XElement x, IDictionary<string, string> attributeValues, string alias)
	{
		if (alias == "nodeTypeAlias")
		{
			return x.ExamineNodeTypeAlias();
		}
		attributeValues.TryGetValue(alias, out var value);
		return value;
	}

	public static string SelectExamineDataValue(this XElement xml, string alias)
	{
		XElement val = null;
		val = ((!((XContainer)xml).Elements(XName.op_Implicit("data")).Any((XElement x) => x.get_HasAttributes())) ? ((XContainer)xml).Elements().FirstOrDefault((Func<XElement, bool>)((XElement x) => string.Equals(((object)x.get_Name()).ToString(), alias, StringComparison.InvariantCultureIgnoreCase))) : ((XContainer)xml).Elements(XName.op_Implicit("data")).SingleOrDefault((Func<XElement, bool>)((XElement x) => string.Equals((string)x.Attribute(XName.op_Implicit("alias")), alias, StringComparison.InvariantCultureIgnoreCase))));
		if (val == null)
		{
			return string.Empty;
		}
		if (!val.get_HasElements())
		{
			return val.get_Value();
		}
		XmlReader xmlReader = ((XNode)val).CreateReader();
		xmlReader.MoveToContent();
		return xmlReader.ReadInnerXml();
	}

	internal static Dictionary<string, string> SelectExamineDataValues(this XElement xml)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		foreach (XElement item in ((XContainer)xml).Elements())
		{
			string text = ((!(item.get_Name().get_LocalName() == "data")) ? item.get_Name().get_LocalName() : ((string)item.Attribute(XName.op_Implicit("alias"))));
			if (string.IsNullOrEmpty(text))
			{
				continue;
			}
			if (!item.get_HasElements())
			{
				dictionary[text] = item.get_Value();
				continue;
			}
			using XmlReader xmlReader = ((XNode)item).CreateReader();
			xmlReader.MoveToContent();
			dictionary[text] = xmlReader.ReadInnerXml();
		}
		return dictionary;
	}
}
