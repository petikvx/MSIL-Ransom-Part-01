using System.Collections.Generic;
using System.Linq;
using PicklesDoc.Pickles.ObjectModel;

namespace PicklesDoc.Pickles.TestFrameworks.XUnit.XUnit2;

public class XUnit2SingleResults : SingleTestRunBase
{
	private readonly assemblies resultsDocument;

	public XUnit2SingleResults(assemblies resultsDocument)
	{
		this.resultsDocument = resultsDocument;
	}

	public override TestResult GetFeatureResult(Feature feature)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		assembliesAssemblyCollection featureElement = GetFeatureElement(feature);
		if (featureElement == null)
		{
			return (TestResult)0;
		}
		int passed = featureElement.passed;
		int failed = featureElement.failed;
		int skipped = featureElement.skipped;
		return GetAggregateResult(passed, failed, skipped);
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
		assembliesAssemblyCollectionTest scenarioElement = GetScenarioElement(scenario);
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
		foreach (assembliesAssemblyCollectionTest scenarioOutlineElement in GetScenarioOutlineElements(scenarioOutline))
		{
			if (base.ScenarioOutlineExampleMatcher.IsMatch(scenarioOutline, exampleValues, scenarioOutlineElement))
			{
				return GetResultFromElement(scenarioOutlineElement);
			}
		}
		return (TestResult)0;
	}

	private static bool HasDescriptionTrait(assembliesAssemblyCollectionTest test, string description)
	{
		return HasTraitWithValue(test, "Description", description);
	}

	private static bool HasFeatureTitleTrait(assembliesAssemblyCollectionTest test, string featureTitle)
	{
		return HasTraitWithValue(test, "FeatureTitle", featureTitle);
	}

	private static bool HasTraitWithValue(assembliesAssemblyCollectionTest test, string trait, string value)
	{
		if (test.traits != null)
		{
			return test.traits.Any((assembliesAssemblyCollectionTestTrait t) => t.name == trait && t.value == value);
		}
		return false;
	}

	private assembliesAssemblyCollection GetFeatureElement(Feature feature)
	{
		return (from collection in resultsDocument.assembly.collection
			from test in collection.test
			where HasFeatureTitleTrait(test, feature.get_Name())
			select collection).FirstOrDefault();
	}

	private assembliesAssemblyCollectionTest GetScenarioElement(Scenario scenario)
	{
		return GetFeatureElement(((ScenarioBase)scenario).get_Feature())?.test.Where((assembliesAssemblyCollectionTest test) => HasDescriptionTrait(test, ((ScenarioBase)scenario).get_Name())).FirstOrDefault();
	}

	private IEnumerable<assembliesAssemblyCollectionTest> GetScenarioOutlineElements(ScenarioOutline scenario)
	{
		assembliesAssemblyCollection featureElement = GetFeatureElement(((ScenarioBase)scenario).get_Feature());
		if (featureElement == null)
		{
			return Enumerable.Empty<assembliesAssemblyCollectionTest>();
		}
		return featureElement.test.Where((assembliesAssemblyCollectionTest test) => HasDescriptionTrait(test, ((ScenarioBase)scenario).get_Name()));
	}

	private TestResult GetResultFromElement(assembliesAssemblyCollectionTest element)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		return (TestResult)(element.result.ToLowerInvariant() switch
		{
			"fail" => 1, 
			"pass" => 2, 
			_ => 0, 
		});
	}
}
