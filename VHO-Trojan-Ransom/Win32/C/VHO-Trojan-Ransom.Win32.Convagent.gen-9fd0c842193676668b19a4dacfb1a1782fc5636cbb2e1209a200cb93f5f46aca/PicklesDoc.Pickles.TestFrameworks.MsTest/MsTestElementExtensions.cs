using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using PicklesDoc.Pickles.ObjectModel;

namespace PicklesDoc.Pickles.TestFrameworks.MsTest;

public static class MsTestElementExtensions
{
	private const string Failed = "failed";

	private static readonly XNamespace Ns = XNamespace.op_Implicit("http://microsoft.com/schemas/VisualStudio/TeamTest/2010");

	internal static bool HasPropertyFeatureTitle(this XElement parentElement, string featureTitle)
	{
		XElement val = ((XContainer)parentElement).Element(Ns + "Properties");
		if (val == null)
		{
			return false;
		}
		return (from property in ((XContainer)val).Elements(Ns + "Property")
			let key = ((XContainer)property).Element(Ns + "Key")
			let value = ((XContainer)property).Element(Ns + "Value")
			where key.get_Value() == "FeatureTitle" && value.get_Value() == featureTitle
			select property).Any();
	}

	internal static string Name(this XElement scenario)
	{
		XElement obj = ((XContainer)scenario).Element(Ns + "Description");
		object obj2;
		if (obj == null)
		{
			obj2 = null;
		}
		else
		{
			obj2 = obj.get_Value();
			if (obj2 != null)
			{
				goto IL_002a;
			}
		}
		obj2 = string.Empty;
		goto IL_002a;
		IL_002a:
		return (string)obj2;
	}

	internal static IEnumerable<XElement> AllExecutionResults(this XDocument document)
	{
		if (((document != null) ? document.get_Root() : null) == null)
		{
			return (IEnumerable<XElement>)(object)new XElement[0];
		}
		return ((XContainer)document.get_Root()).Descendants(Ns + "UnitTestResult");
	}

	internal static IEnumerable<XElement> AllScenarios(this XDocument document)
	{
		if (((document != null) ? document.get_Root() : null) == null)
		{
			return (IEnumerable<XElement>)(object)new XElement[0];
		}
		return from s in ((XContainer)document.get_Root()).Descendants(Ns + "UnitTest")
			where ((XContainer)s).Element(Ns + "Description") != null
			select s;
	}

	public static Guid ExecutionIdElement(this XElement scenario)
	{
		XElement val = ((scenario != null) ? ((XContainer)scenario).Element(Ns + "Execution") : null);
		if (val == null)
		{
			return Guid.Empty;
		}
		return new Guid(val.Attribute(XName.op_Implicit("id")).get_Value());
	}

	internal static IEnumerable<Guid> ExecutionIdElements(this IEnumerable<XElement> scenarios)
	{
		return scenarios.Select(ExecutionIdElement);
	}

	internal static TestResult Outcome(this XElement scenarioResult)
	{
		XAttribute obj = scenarioResult.Attribute(XName.op_Implicit("outcome"));
		object obj2;
		if (obj == null)
		{
			obj2 = null;
		}
		else
		{
			obj2 = obj.get_Value();
			if (obj2 != null)
			{
				goto IL_0025;
			}
		}
		obj2 = "failed";
		goto IL_0025;
		IL_0025:
		string text = ((string)obj2).ToLowerInvariant();
		if (!(text == "passed"))
		{
			if (text == "failed")
			{
				return (TestResult)1;
			}
			return (TestResult)0;
		}
		return (TestResult)2;
	}

	internal static Guid ExecutionIdAttribute(this XElement unitTestResult)
	{
		XAttribute val = unitTestResult.Attribute(XName.op_Implicit("executionId"));
		if (val == null)
		{
			return Guid.Empty;
		}
		return new Guid(val.get_Value());
	}

	internal static string NameAttribute(this XElement element)
	{
		XAttribute obj = element.Attribute(XName.op_Implicit("name"));
		object obj2;
		if (obj == null)
		{
			obj2 = null;
		}
		else
		{
			obj2 = obj.get_Value();
			if (obj2 != null)
			{
				goto IL_0025;
			}
		}
		obj2 = string.Empty;
		goto IL_0025;
		IL_0025:
		return (string)obj2;
	}

	internal static List<string> DetermineValuesInScenario(this XElement element)
	{
		List<string> list = new List<string>();
		foreach (XElement item in ((XContainer)element).Descendants(Ns + "Property"))
		{
			XElement? obj = ((XContainer)item).Descendants(Ns + "Key").FirstOrDefault();
			object obj2;
			if (obj == null)
			{
				obj2 = null;
			}
			else
			{
				obj2 = obj!.get_Value();
				if (obj2 != null)
				{
					goto IL_005a;
				}
			}
			obj2 = string.Empty;
			goto IL_005a;
			IL_009b:
			object obj3;
			list.Add((string)obj3);
			continue;
			IL_005a:
			if (!((string)obj2).StartsWith("Parameter:"))
			{
				continue;
			}
			XElement? obj4 = ((XContainer)item).Descendants(Ns + "Value").FirstOrDefault();
			if (obj4 == null)
			{
				obj3 = null;
			}
			else
			{
				obj3 = obj4!.get_Value().Trim();
				if (obj3 != null)
				{
					goto IL_009b;
				}
			}
			obj3 = string.Empty;
			goto IL_009b;
		}
		return list;
	}
}
