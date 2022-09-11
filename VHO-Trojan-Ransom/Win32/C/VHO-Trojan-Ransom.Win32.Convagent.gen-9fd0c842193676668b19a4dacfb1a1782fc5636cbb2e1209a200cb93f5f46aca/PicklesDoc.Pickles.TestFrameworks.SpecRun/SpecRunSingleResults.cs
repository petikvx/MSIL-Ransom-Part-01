using System.Collections.Generic;
using System.Linq;
using PicklesDoc.Pickles.ObjectModel;

namespace PicklesDoc.Pickles.TestFrameworks.SpecRun;

public class SpecRunSingleResults : SingleTestRunBase
{
	private readonly List<SpecRunFeature> specRunFeatures;

	public SpecRunSingleResults(IEnumerable<SpecRunFeature> specRunFeatures)
	{
		this.specRunFeatures = specRunFeatures.ToList();
	}

	public override TestResult GetFeatureResult(Feature feature)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		SpecRunFeature specRunFeature = FindSpecRunFeature(feature);
		if (specRunFeature == null)
		{
			return (TestResult)0;
		}
		return TestResultExtensions.Merge(specRunFeature.Scenarios.Select((SpecRunScenario specRunScenario) => StringToTestResult(specRunScenario.Result)), false);
	}

	public override TestResult GetScenarioOutlineResult(ScenarioOutline scenarioOutline)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		SpecRunFeature specRunFeature = FindSpecRunFeature(((ScenarioBase)scenarioOutline).get_Feature());
		if (specRunFeature == null)
		{
			return (TestResult)0;
		}
		SpecRunScenario[] array = FindSpecRunScenarios(scenarioOutline, specRunFeature);
		if (array.Length == 0)
		{
			return (TestResult)0;
		}
		return StringsToTestResult(array.Select((SpecRunScenario srs) => srs.Result));
	}

	public override TestResult GetScenarioResult(Scenario scenario)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		SpecRunFeature specRunFeature = FindSpecRunFeature(((ScenarioBase)scenario).get_Feature());
		if (specRunFeature == null)
		{
			return (TestResult)0;
		}
		SpecRunScenario specRunScenario = FindSpecRunScenario(scenario, specRunFeature);
		if (specRunScenario == null)
		{
			return (TestResult)0;
		}
		return StringToTestResult(specRunScenario.Result);
	}

	public override TestResult GetExampleResult(ScenarioOutline scenario, string[] exampleValues)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		SpecRunFeature specRunFeature = FindSpecRunFeature(((ScenarioBase)scenario).get_Feature());
		if (specRunFeature == null)
		{
			return (TestResult)0;
		}
		SpecRunScenario[] array = FindSpecRunScenarios(scenario, specRunFeature);
		int num = 0;
		SpecRunScenario specRunScenario;
		while (true)
		{
			if (num >= array.Length)
			{
				return (TestResult)0;
			}
			specRunScenario = array[num];
			if (base.ScenarioOutlineExampleMatcher.IsMatch(scenario, exampleValues, specRunScenario))
			{
				break;
			}
			num++;
		}
		return StringToTestResult(specRunScenario.Result);
	}

	private static TestResult StringsToTestResult(IEnumerable<string> results)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (results == null)
		{
			return (TestResult)0;
		}
		return TestResultExtensions.Merge(results.Select(StringToTestResult), false);
	}

	private static TestResult StringToTestResult(string result)
	{
		if (result != null)
		{
			string text = result.ToLowerInvariant();
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
		return (TestResult)0;
	}

	private static SpecRunScenario[] FindSpecRunScenarios(ScenarioOutline scenarioOutline, SpecRunFeature specRunFeature)
	{
		return specRunFeature.Scenarios.Where((SpecRunScenario d) => d.Title.StartsWith(((ScenarioBase)scenarioOutline).get_Name() + ", ")).ToArray();
	}

	private static SpecRunScenario FindSpecRunScenario(Scenario scenario, SpecRunFeature specRunFeature)
	{
		return specRunFeature.Scenarios.FirstOrDefault((SpecRunScenario d) => d.Title.Equals(((ScenarioBase)scenario).get_Name()));
	}

	private SpecRunFeature FindSpecRunFeature(Feature feature)
	{
		return specRunFeatures.FirstOrDefault((SpecRunFeature specRunFeature) => specRunFeature.Title == feature.get_Name());
	}
}
