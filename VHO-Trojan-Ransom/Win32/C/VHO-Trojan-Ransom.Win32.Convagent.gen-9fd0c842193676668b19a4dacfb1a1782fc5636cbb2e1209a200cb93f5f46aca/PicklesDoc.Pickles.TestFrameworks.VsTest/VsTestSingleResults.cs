using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using PicklesDoc.Pickles.ObjectModel;

namespace PicklesDoc.Pickles.TestFrameworks.VsTest;

public class VsTestSingleResults : SingleTestRunBase
{
	private readonly XDocument resultsDocument;

	public VsTestSingleResults(XDocument resultsDocument)
	{
		this.resultsDocument = resultsDocument;
	}

	public override TestResult GetFeatureResult(Feature feature)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		IEnumerable<Guid> featureExecutionIds = GetScenariosForFeature(feature).ExecutionIdElements();
		return GetExecutionResult(featureExecutionIds);
	}

	private IEnumerable<XElement> GetScenariosForFeature(Feature feature)
	{
		return from scenario in resultsDocument.AllScenarios()
			where scenario.BelongsToFeature(feature.get_Name())
			select scenario;
	}

	private TestResult GetExecutionResult(IEnumerable<Guid> featureExecutionIds)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		return TestResultExtensions.Merge(featureExecutionIds.Select(GetExecutionResult), false);
	}

	private TestResult GetExecutionResult(Guid scenarioExecutionId)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		return (from er in resultsDocument.AllExecutionResults()
			where er.ExecutionIdAttribute() == scenarioExecutionId
			select er into sr
			select sr.Outcome()).FirstOrDefault();
	}

	public override TestResult GetScenarioOutlineResult(ScenarioOutline scenarioOutline)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		IEnumerable<Guid> featureExecutionIds = from scenario in GetScenariosForScenarioOutline(scenarioOutline)
			select scenario.ExecutionIdElement();
		return GetExecutionResult(featureExecutionIds);
	}

	private IEnumerable<XElement> GetScenariosForScenarioOutline(ScenarioOutline scenarioOutline)
	{
		return from scenario in GetScenariosForFeature(((ScenarioBase)scenarioOutline).get_Feature())
			where scenario.BelongsToScenarioOutline(scenarioOutline)
			select scenario;
	}

	public override TestResult GetScenarioResult(Scenario scenario)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		Guid scenarioExecutionId = (from s in GetScenariosForScenario(scenario)
			select s.ExecutionIdElement()).FirstOrDefault();
		return GetExecutionResult(scenarioExecutionId);
	}

	private IEnumerable<XElement> GetScenariosForScenario(Scenario scenario)
	{
		return from s in GetScenariosForFeature(((ScenarioBase)scenario).get_Feature())
			where s.BelongsToScenario(scenario)
			select s;
	}

	public override TestResult GetExampleResult(ScenarioOutline scenario, string[] exampleValues)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		IEnumerable<XElement> scenariosForScenarioOutline = GetScenariosForScenarioOutline(scenario);
		Guid scenarioExecutionId = GetScenarioThatMatchesTheExampleValues(scenario, exampleValues, scenariosForScenarioOutline).ExecutionIdElement();
		return GetExecutionResult(scenarioExecutionId);
	}

	private XElement GetScenarioThatMatchesTheExampleValues(ScenarioOutline scenarioOutline, string[] exampleValues, IEnumerable<XElement> scenarioElements)
	{
		XElement result = null;
		foreach (XElement scenarioElement in scenarioElements)
		{
			if (base.ScenarioOutlineExampleMatcher.IsMatch(scenarioOutline, exampleValues, scenarioElement))
			{
				return scenarioElement;
			}
		}
		return result;
	}
}
