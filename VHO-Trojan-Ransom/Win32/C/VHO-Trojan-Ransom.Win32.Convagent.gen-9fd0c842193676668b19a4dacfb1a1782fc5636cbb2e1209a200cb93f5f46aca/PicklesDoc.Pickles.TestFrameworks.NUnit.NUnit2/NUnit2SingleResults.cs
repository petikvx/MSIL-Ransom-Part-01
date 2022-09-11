using System;
using System.Linq;
using System.Xml.Linq;
using PicklesDoc.Pickles.ObjectModel;

namespace PicklesDoc.Pickles.TestFrameworks.NUnit.NUnit2;

public class NUnit2SingleResults : NUnitSingleResultsBase
{
	private readonly ILookup<string, XElement> featureElements;

	public NUnit2SingleResults(XDocument resultsDocument)
		: base(resultsDocument, new TestResultAndName[4]
		{
			new TestResultAndName((TestResult)0, "Ignored"),
			new TestResultAndName((TestResult)0, "Inconclusive"),
			new TestResultAndName((TestResult)1, "Failure"),
			new TestResultAndName((TestResult)2, "Success")
		})
	{
		featureElements = (from x in ((XContainer)resultsDocument).Descendants(XName.op_Implicit("test-suite"))
			where x.Attribute(XName.op_Implicit("description")) != null
			select x).ToLookup((XElement x) => x.Attribute(XName.op_Implicit("description")).get_Value());
	}

	protected override XElement GetScenarioElement(Scenario scenario)
	{
		XElement featureElement = GetFeatureElement(((ScenarioBase)scenario).get_Feature());
		XElement result = null;
		if (featureElement != null)
		{
			result = (from x in ((XContainer)featureElement).Descendants(XName.op_Implicit("test-case"))
				where x.Attribute(XName.op_Implicit("description")) != null
				select x).FirstOrDefault((Func<XElement, bool>)((XElement x) => x.Attribute(XName.op_Implicit("description")).get_Value() == ((ScenarioBase)scenario).get_Name()));
		}
		return result;
	}

	protected override XElement GetScenarioOutlineElement(ScenarioOutline scenarioOutline)
	{
		XElement featureElement = GetFeatureElement(((ScenarioBase)scenarioOutline).get_Feature());
		XElement result = null;
		if (featureElement != null)
		{
			result = (from x in ((XContainer)GetFeatureElement(((ScenarioBase)scenarioOutline).get_Feature())).Descendants(XName.op_Implicit("test-suite"))
				where x.Attribute(XName.op_Implicit("description")) != null
				select x).FirstOrDefault((Func<XElement, bool>)((XElement x) => x.Attribute(XName.op_Implicit("description")).get_Value() == ((ScenarioBase)scenarioOutline).get_Name()));
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
			XElement val = ((XContainer)featureElement).Descendants(XName.op_Implicit("test-suite")).FirstOrDefault((Func<XElement, bool>)((XElement x) => IsMatchingParameterizedTestElement(x, scenarioOutline)));
			if (val != null)
			{
				result = ((XContainer)val).Descendants(XName.op_Implicit("test-case")).FirstOrDefault((Func<XElement, bool>)((XElement x) => base.ScenarioOutlineExampleMatcher.IsMatch(scenarioOutline, values, x)));
			}
		}
		return result;
	}

	private static bool IsMatchingParameterizedTestElement(XElement element, ScenarioOutline scenarioOutline)
	{
		XAttribute val = element.Attribute(XName.op_Implicit("description"));
		if (val != null && val.get_Value().Equals(((ScenarioBase)scenarioOutline).get_Name(), StringComparison.OrdinalIgnoreCase))
		{
			return ((XContainer)element).Descendants(XName.op_Implicit("test-case")).Any();
		}
		return false;
	}
}
