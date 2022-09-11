using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using PicklesDoc.Pickles.ObjectModel;

namespace PicklesDoc.Pickles.TestFrameworks.NUnit;

public abstract class NUnitSingleResultsBase : SingleTestRunBase
{
	private readonly TestResultAndName[] testResultAndNames;

	protected NUnitSingleResultsBase(XDocument resultsDocument, TestResultAndName[] testResultAndNames)
	{
		this.testResultAndNames = testResultAndNames;
	}

	public override TestResult GetFeatureResult(Feature feature)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		XElement featureElement = GetFeatureElement(feature);
		if (featureElement == null)
		{
			return (TestResult)0;
		}
		return TestResultExtensions.Merge(((XContainer)featureElement).Descendants(XName.op_Implicit("test-case")).Select(GetResultFromElement), false);
	}

	public override TestResult GetScenarioResult(Scenario scenario)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		XElement scenarioElement = GetScenarioElement(scenario);
		return GetResultFromElement(scenarioElement);
	}

	public override TestResult GetScenarioOutlineResult(ScenarioOutline scenarioOutline)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		XElement scenarioOutlineElement = GetScenarioOutlineElement(scenarioOutline);
		return DetermineScenarioOutlineResult(scenarioOutlineElement);
	}

	public override TestResult GetExampleResult(ScenarioOutline scenarioOutline, string[] exampleValues)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		XElement examplesElement = GetExamplesElement(scenarioOutline, exampleValues);
		return GetResultFromElement(examplesElement);
	}

	protected static bool IsMatchingTestCase(XElement x, Regex exampleSignature)
	{
		XAttribute val = x.Attribute(XName.op_Implicit("name"));
		if (val != null)
		{
			return exampleSignature.IsMatch(val.get_Value().ToLowerInvariant().Replace("\\", string.Empty));
		}
		return false;
	}

	private TestResult DetermineScenarioOutlineResult(XElement scenarioOutlineElement)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		if (scenarioOutlineElement != null)
		{
			return TestResultExtensions.Merge(((XContainer)scenarioOutlineElement).Descendants(XName.op_Implicit("test-case")).Select(GetResultFromElement), false);
		}
		return (TestResult)0;
	}

	private TestResult GetResultFromElement(XElement element)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if (element == null)
		{
			return (TestResult)0;
		}
		TestResultAndName[] array = testResultAndNames;
		int num = 0;
		TestResultAndName testResultAndName;
		while (true)
		{
			if (num < array.Length)
			{
				testResultAndName = array[num];
				if (element.IsAttributeSetToValue("result", testResultAndName.Name))
				{
					break;
				}
				num++;
				continue;
			}
			if (element.IsAttributeSetToValue("executed", "true"))
			{
				if (element.IsAttributeSetToValue("success", "true"))
				{
					return (TestResult)2;
				}
				return (TestResult)1;
			}
			return (TestResult)0;
		}
		return testResultAndName.TestResult;
	}

	protected abstract XElement GetScenarioElement(Scenario scenario);

	protected abstract XElement GetScenarioOutlineElement(ScenarioOutline scenarioOutline);

	protected abstract XElement GetFeatureElement(Feature feature);

	protected abstract XElement GetExamplesElement(ScenarioOutline scenarioOutline, string[] values);
}
