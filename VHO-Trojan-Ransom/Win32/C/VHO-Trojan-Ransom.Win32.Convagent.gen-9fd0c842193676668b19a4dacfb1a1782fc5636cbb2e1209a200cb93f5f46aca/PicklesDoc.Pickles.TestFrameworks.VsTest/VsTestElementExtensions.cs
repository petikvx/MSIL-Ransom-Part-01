using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using PicklesDoc.Pickles.ObjectModel;

namespace PicklesDoc.Pickles.TestFrameworks.VsTest;

internal static class VsTestElementExtensions
{
	private const string Failed = "failed";

	private static readonly XNamespace Ns = XNamespace.op_Implicit("http://microsoft.com/schemas/VisualStudio/TeamTest/2010");

	internal static bool BelongsToFeature(this XElement parentElement, string featureTitle)
	{
		XElement val = ((XContainer)parentElement).Element(Ns + "TestMethod");
		if (val == null)
		{
			return false;
		}
		return val.Attributes(XName.op_Implicit("className")).Any((XAttribute a) => a.get_Value().ToUpperInvariant().Contains(TransformName(featureTitle) + "FEATURE"));
	}

	internal static string Name(this XElement scenario)
	{
		XAttribute obj = scenario.Attribute(XName.op_Implicit("name"));
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
		return ((XContainer)document.get_Root()).Descendants(Ns + "UnitTest");
	}

	internal static Guid ExecutionIdElement(this XElement scenario)
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

	internal static bool BelongsToScenarioOutline(this XElement xmlScenario, ScenarioOutline scenarioOutline)
	{
		return xmlScenario.Name().ToUpperInvariant().StartsWith(TransformName(((ScenarioBase)scenarioOutline).get_Name()));
	}

	internal static bool BelongsToScenario(this XElement xmlScenario, Scenario scenario)
	{
		return xmlScenario.Name().ToUpperInvariant() == TransformName(((ScenarioBase)scenario).get_Name());
	}

	private static string TransformName(string name)
	{
		return SpecFlowNameMapping.Build(name).ToUpperInvariant();
	}
}
