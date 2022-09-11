using System;
using System.Linq;
using System.Xml.Linq;
using PicklesDoc.Pickles.ObjectModel;

namespace PicklesDoc.Pickles.TestFrameworks.NUnit.NUnit3;

public class NUnit3SingleResult : NUnitSingleResultsBase
{
	private readonly ILookup<string, XElement> featureElements;

	public NUnit3SingleResult(XDocument resultsDocument)
		: base(resultsDocument, new TestResultAndName[4]
		{
			new TestResultAndName((TestResult)0, "Skipped"),
			new TestResultAndName((TestResult)0, "Inconclusive"),
			new TestResultAndName((TestResult)1, "Failed"),
			new TestResultAndName((TestResult)2, "Passed")
		})
	{
		featureElements = (from x in ((XContainer)resultsDocument).Descendants(XName.op_Implicit("test-suite"))
			select new
			{
				DescriptionAttribute = Extensions.Elements<XElement>(((XContainer)x).Elements(XName.op_Implicit("properties")), XName.op_Implicit("property")).FirstOrDefault((Func<XElement, bool>)((XElement p) => IsDescriptionAttribute(p))),
				Element = x
			} into x
			where x.DescriptionAttribute != null
			select x).ToLookup(x => x.DescriptionAttribute.Attribute(XName.op_Implicit("value")).get_Value(), x => x.Element);
	}

	protected override XElement GetScenarioElement(Scenario scenario)
	{
		XElement featureElement = GetFeatureElement(((ScenarioBase)scenario).get_Feature());
		XElement result = null;
		if (featureElement != null)
		{
			result = ((XContainer)featureElement).Descendants(XName.op_Implicit("test-case")).FirstOrDefault((Func<XElement, bool>)((XElement ts) => Extensions.Elements<XElement>(((XContainer)ts).Elements(XName.op_Implicit("properties")), XName.op_Implicit("property")).Any((XElement p) => IsDescriptionAttribute(p) && p.Attribute(XName.op_Implicit("value")).get_Value() == ((ScenarioBase)scenario).get_Name())));
		}
		return result;
	}

	protected override XElement GetScenarioOutlineElement(ScenarioOutline scenarioOutline)
	{
		XElement featureElement = GetFeatureElement(((ScenarioBase)scenarioOutline).get_Feature());
		XElement result = null;
		if (featureElement != null)
		{
			result = ((XContainer)GetFeatureElement(((ScenarioBase)scenarioOutline).get_Feature())).Descendants(XName.op_Implicit("test-suite")).FirstOrDefault((Func<XElement, bool>)((XElement ts) => Extensions.Elements<XElement>(((XContainer)ts).Elements(XName.op_Implicit("properties")), XName.op_Implicit("property")).Any((XElement p) => IsDescriptionAttribute(p) && p.Attribute(XName.op_Implicit("value")).get_Value() == ((ScenarioBase)scenarioOutline).get_Name())));
		}
		return result;
	}

	protected override XElement GetFeatureElement(Feature feature)
	{
		return featureElements[feature.get_Name()].FirstOrDefault();
	}

	protected override XElement GetExamplesElement(ScenarioOutline scenarioOutline, string[] values)
	{
		XElement featureElement = GetFeatureElement(((ScenarioBase)scenarioOutline).get_Feature());
		XElement result = null;
		if (featureElement != null)
		{
			XElement val = ((XContainer)featureElement).Descendants(XName.op_Implicit("test-suite")).FirstOrDefault((Func<XElement, bool>)((XElement ts) => Extensions.Elements<XElement>(((XContainer)ts).Elements(XName.op_Implicit("properties")), XName.op_Implicit("property")).Any((XElement p) => IsDescriptionAttribute(p) && p.Attribute(XName.op_Implicit("value")).get_Value() == ((ScenarioBase)scenarioOutline).get_Name())));
			if (val != null)
			{
				result = ((XContainer)val).Descendants(XName.op_Implicit("test-case")).FirstOrDefault((Func<XElement, bool>)((XElement x) => base.ScenarioOutlineExampleMatcher.IsMatch(scenarioOutline, values, x)));
			}
		}
		return result;
	}

	private static bool IsDescriptionAttribute(XElement p)
	{
		if (!(p.Attribute(XName.op_Implicit("name")).get_Value() == "Description"))
		{
			return p.Attribute(XName.op_Implicit("name")).get_Value() == "_DESCRIPTION";
		}
		return true;
	}
}
