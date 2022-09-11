using System.Collections.Generic;
using System.Linq;
using PicklesDoc.Pickles.ObjectModel;

namespace PicklesDoc.Pickles.TestFrameworks.CucumberJson;

public class CucumberJsonSingleResults : SingleTestRunBase
{
	private class FeatureAndBackground
	{
		public Feature Feature { get; }

		public Element Background { get; }

		public FeatureAndBackground(Feature feature, Element background)
		{
			Feature = feature;
			Background = background;
		}
	}

	private class ScenarioBaseAndBackground
	{
		public Element ScenarioBase { get; }

		public Element Background { get; }

		public ScenarioBaseAndBackground(Element scenarioBase, Element background)
		{
			ScenarioBase = scenarioBase;
			Background = background;
		}
	}

	private readonly List<Feature> resultsDocument;

	public CucumberJsonSingleResults(IEnumerable<Feature> cucumberFeatures)
	{
		resultsDocument = cucumberFeatures.ToList();
	}

	public override TestResult GetExampleResult(ScenarioOutline scenario, string[] exampleValues)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		return (from cs in GetCucumberScenarios(scenario)
			where ScenarioHasStepsForAllExampleValues(cs.ScenarioBase, exampleValues)
			select ToTestResult(cs.ScenarioBase, cs.Background)).FirstOrDefault();
	}

	private bool ScenarioHasStepsForAllExampleValues(Element cucumberScenario, string[] exampleValues)
	{
		return exampleValues.All((string exampleValue) => ScenarioHasAStepWithThisExampleValue(cucumberScenario, exampleValue));
	}

	private bool ScenarioHasAStepWithThisExampleValue(Element cucumberScenario, string exampleValue)
	{
		return cucumberScenario.steps.Any((Step step) => step.name.Contains(exampleValue));
	}

	public override TestResult GetFeatureResult(Feature feature)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		FeatureAndBackground cucumberFeature = GetCucumberFeature(feature);
		return GetResultFromFeature(cucumberFeature.Feature, cucumberFeature.Background);
	}

	private FeatureAndBackground GetCucumberFeature(Feature feature)
	{
		Feature? feature2 = resultsDocument.FirstOrDefault((Feature f) => f.name == feature.get_Name());
		Element background = feature2?.elements?.FirstOrDefault((Element e) => e.type == "background");
		return new FeatureAndBackground(feature2, background);
	}

	private TestResult GetResultFromFeature(Feature cucumberFeature, Element background)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (cucumberFeature?.elements == null)
		{
			return (TestResult)0;
		}
		return ToTestResult(cucumberFeature, background);
	}

	private TestResult ToTestResult(Feature feature, Element background)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		return TestResultExtensions.Merge(feature.elements.Select((Element e) => ToTestResult(e, background)), false);
	}

	private TestResult ToTestResult(Element scenario, Element background)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		object obj;
		if (background == null)
		{
			obj = null;
		}
		else
		{
			obj = background.steps;
			if (obj != null)
			{
				goto IL_0015;
			}
		}
		obj = new List<Step>();
		goto IL_0015;
		IL_0015:
		return TestResultExtensions.Merge((from s in ((IEnumerable<Step>)obj).Concat(scenario.steps)
			where s.result != null
			select s).Select(ToTestResult), false);
	}

	private TestResult ToTestResult(Step step)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return ToTestResult(step.result.status);
	}

	private TestResult ToTestResult(string cucumberResult)
	{
		switch (cucumberResult)
		{
		case "passed":
			return (TestResult)2;
		case "ambiguous":
		case "failed":
			return (TestResult)1;
		default:
			return (TestResult)0;
		}
	}

	public override TestResult GetScenarioOutlineResult(ScenarioOutline scenarioOutline)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		return TestResultExtensions.Merge(from cs in GetCucumberScenarios(scenarioOutline)
			select ToTestResult(cs.ScenarioBase, cs.Background), false);
	}

	public override TestResult GetScenarioResult(Scenario scenario)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		ScenarioBaseAndBackground cucumberScenario = GetCucumberScenario(scenario);
		return GetResultFromScenario(cucumberScenario.ScenarioBase, cucumberScenario.Background);
	}

	private ScenarioBaseAndBackground GetCucumberScenario(Scenario scenario)
	{
		Element scenarioBase = null;
		FeatureAndBackground cucumberFeature = GetCucumberFeature(((ScenarioBase)scenario).get_Feature());
		if (cucumberFeature?.Feature != null)
		{
			scenarioBase = cucumberFeature.Feature.elements?.FirstOrDefault((Element x) => x.name == ((ScenarioBase)scenario).get_Name());
		}
		return new ScenarioBaseAndBackground(scenarioBase, cucumberFeature?.Background);
	}

	private IEnumerable<ScenarioBaseAndBackground> GetCucumberScenarios(ScenarioOutline scenarioOutline)
	{
		IEnumerable<Element> enumerable = null;
		FeatureAndBackground cucumberFeature = GetCucumberFeature(((ScenarioBase)scenarioOutline).get_Feature());
		if (cucumberFeature?.Feature != null)
		{
			enumerable = cucumberFeature.Feature.elements.Where((Element x) => x.name == ((ScenarioBase)scenarioOutline).get_Name());
		}
		return (enumerable ?? new Element[0]).Select((Element cs) => new ScenarioBaseAndBackground(cs, cucumberFeature?.Background));
	}

	private TestResult GetResultFromScenario(Element cucumberScenario, Element background)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		if (cucumberScenario == null)
		{
			return (TestResult)0;
		}
		return ToTestResult(cucumberScenario, background);
	}
}
