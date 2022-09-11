using System.Collections.Generic;
using PicklesDoc.Pickles.ObjectModel;

namespace PicklesDoc.Pickles.TestFrameworks;

public abstract class SingleTestRunBase : ITestResults
{
	internal IScenarioOutlineExampleMatcher ScenarioOutlineExampleMatcher { get; set; }

	public abstract TestResult GetFeatureResult(Feature feature);

	public abstract TestResult GetScenarioOutlineResult(ScenarioOutline scenarioOutline);

	public abstract TestResult GetScenarioResult(Scenario scenario);

	public abstract TestResult GetExampleResult(ScenarioOutline scenario, string[] exampleValues);

	protected TestResult GetAggregateResult(int passedCount, int failedCount, int skippedCount)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		if (passedCount > 0 && failedCount == 0)
		{
			return (TestResult)2;
		}
		if (failedCount > 0)
		{
			return (TestResult)1;
		}
		return (TestResult)0;
	}

	protected TestResult DetermineAggregateResult(IEnumerable<TestResult> exampleResults)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Invalid comparison between Unknown and I4
		//IL_0026: Invalid comparison between Unknown and I4
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		foreach (TestResult exampleResult in exampleResults)
		{
			if ((int)exampleResult == 0)
			{
				num3++;
			}
			if ((int)exampleResult == 2)
			{
				num++;
			}
			if ((int)exampleResult == 1)
			{
				num2++;
			}
		}
		return GetAggregateResult(num, num2, num3);
	}
}
