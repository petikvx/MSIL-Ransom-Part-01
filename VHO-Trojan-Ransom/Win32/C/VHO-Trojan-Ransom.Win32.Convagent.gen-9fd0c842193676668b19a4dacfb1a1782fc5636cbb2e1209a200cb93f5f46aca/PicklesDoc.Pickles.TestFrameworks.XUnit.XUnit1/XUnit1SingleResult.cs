using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using PicklesDoc.Pickles.ObjectModel;

namespace PicklesDoc.Pickles.TestFrameworks.XUnit.XUnit1;

public class XUnit1SingleResult : SingleTestRunBase
{
	private readonly XDocument resultsDocument;

	public XUnit1SingleResult(XDocument resultsDocument)
	{
		this.resultsDocument = resultsDocument;
	}

	public override TestResult GetFeatureResult(Feature feature)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		XElement featureElement = GetFeatureElement(feature);
		if (featureElement == null)
		{
			return (TestResult)0;
		}
		int passedCount = int.Parse(featureElement.Attribute(XName.op_Implicit("passed")).get_Value());
		int failedCount = int.Parse(featureElement.Attribute(XName.op_Implicit("failed")).get_Value());
		int skippedCount = int.Parse(featureElement.Attribute(XName.op_Implicit("skipped")).get_Value());
		return GetAggregateResult(passedCount, failedCount, skippedCount);
	}

	public override TestResult GetScenarioOutlineResult(ScenarioOutline scenarioOutline)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		IEnumerable<TestResult> exampleResults = GetScenarioOutlineElements(scenarioOutline).Select(GetResultFromElement);
		return DetermineAggregateResult(exampleResults);
	}

	public override TestResult GetScenarioResult(Scenario scenario)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		XElement scenarioElement = GetScenarioElement(scenario);
		if (scenarioElement == null)
		{
			return (TestResult)0;
		}
		return GetResultFromElement(scenarioElement);
	}

	public override TestResult GetExampleResult(ScenarioOutline scenarioOutline, string[] exampleValues)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		foreach (XElement scenarioOutlineElement in GetScenarioOutlineElements(scenarioOutline))
		{
			if (base.ScenarioOutlineExampleMatcher.IsMatch(scenarioOutline, exampleValues, scenarioOutlineElement))
			{
				return GetResultFromElement(scenarioOutlineElement);
			}
		}
		return (TestResult)0;
	}

	private bool ScenarioOutlineExampleIsMatch(Regex signature, XElement exampleElement)
	{
		return signature.IsMatch(exampleElement.Attribute(XName.op_Implicit("name")).get_Value().ToLowerInvariant()
			.Replace("\\", string.Empty));
	}

	private XElement GetFeatureElement(Feature feature)
	{
		return (from clazz in ((XContainer)resultsDocument.get_Root()).Descendants(XName.op_Implicit("class"))
			from test in ((XContainer)clazz).Descendants(XName.op_Implicit("test"))
			from trait in Extensions.Descendants<XElement>(((XContainer)clazz).Descendants(XName.op_Implicit("traits")), XName.op_Implicit("trait"))
			where trait.Attribute(XName.op_Implicit("name")).get_Value() == "FeatureTitle" && trait.Attribute(XName.op_Implicit("value")).get_Value() == feature.get_Name()
			select clazz).FirstOrDefault();
	}

	private XElement GetScenarioElement(Scenario scenario)
	{
		return (from test in ((XContainer)GetFeatureElement(((ScenarioBase)scenario).get_Feature())).Descendants(XName.op_Implicit("test"))
			from trait in Extensions.Descendants<XElement>(((XContainer)test).Descendants(XName.op_Implicit("traits")), XName.op_Implicit("trait"))
			where trait.Attribute(XName.op_Implicit("name")).get_Value() == "Description" && trait.Attribute(XName.op_Implicit("value")).get_Value() == ((ScenarioBase)scenario).get_Name()
			select test).FirstOrDefault();
	}

	private IEnumerable<XElement> GetScenarioOutlineElements(ScenarioOutline scenario)
	{
		return from test in ((XContainer)GetFeatureElement(((ScenarioBase)scenario).get_Feature())).Descendants(XName.op_Implicit("test"))
			from trait in Extensions.Descendants<XElement>(((XContainer)test).Descendants(XName.op_Implicit("traits")), XName.op_Implicit("trait"))
			where trait.Attribute(XName.op_Implicit("name")).get_Value() == "Description" && trait.Attribute(XName.op_Implicit("value")).get_Value() == ((ScenarioBase)scenario).get_Name()
			select test;
	}

	private TestResult GetResultFromElement(XElement element)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		return (TestResult)(element.Attribute(XName.op_Implicit("result")).get_Value().ToLowerInvariant() switch
		{
			"fail" => 1, 
			"pass" => 2, 
			_ => 0, 
		});
	}
}
