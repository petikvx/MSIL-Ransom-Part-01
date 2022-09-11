using System.Collections.Generic;
using System.IO.Abstractions;
using System.Linq;
using PicklesDoc.Pickles.ObjectModel;

namespace PicklesDoc.Pickles.TestFrameworks;

public abstract class MultipleTestRunsBase : ITestResults
{
	private readonly ISingleResultLoader singleResultLoader;

	protected IEnumerable<SingleTestRunBase> TestResults { get; }

	protected MultipleTestRunsBase(IEnumerable<SingleTestRunBase> testResults)
	{
		TestResults = testResults;
	}

	protected MultipleTestRunsBase(IConfiguration configuration, ISingleResultLoader singleResultLoader, IScenarioOutlineExampleMatcher scenarioOutlineExampleMatcher = null)
	{
		this.singleResultLoader = singleResultLoader;
		TestResults = GetSingleTestResults(configuration);
		SetExampleSignatureBuilder(scenarioOutlineExampleMatcher ?? new ScenarioOutlineExampleMatcher());
	}

	private void SetExampleSignatureBuilder(IScenarioOutlineExampleMatcher scenarioOutlineExampleMatcher)
	{
		foreach (SingleTestRunBase testResult in TestResults)
		{
			testResult.ScenarioOutlineExampleMatcher = scenarioOutlineExampleMatcher;
		}
	}

	public TestResult GetExampleResult(ScenarioOutline scenarioOutline, string[] arguments)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		return EvaluateTestResults(TestResults.Select((SingleTestRunBase tr) => tr.GetExampleResult(scenarioOutline, arguments)).ToArray());
	}

	public TestResult GetFeatureResult(Feature feature)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		return EvaluateTestResults(TestResults.Select((SingleTestRunBase tr) => tr.GetFeatureResult(feature)).ToArray());
	}

	public TestResult GetScenarioOutlineResult(ScenarioOutline scenarioOutline)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		return EvaluateTestResults(TestResults.Select((SingleTestRunBase tr) => tr.GetScenarioOutlineResult(scenarioOutline)).ToArray());
	}

	public TestResult GetScenarioResult(Scenario scenario)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		return EvaluateTestResults(TestResults.Select((SingleTestRunBase tr) => tr.GetScenarioResult(scenario)).ToArray());
	}

	protected static TestResult EvaluateTestResults(TestResult[] results)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return TestResultExtensions.Merge((IEnumerable<TestResult>)results, true);
	}

	protected SingleTestRunBase ConstructSingleTestResult(FileInfoBase fileInfo)
	{
		return singleResultLoader.Load(fileInfo);
	}

	private IEnumerable<SingleTestRunBase> GetSingleTestResults(IConfiguration configuration)
	{
		if (configuration.get_HasTestResults())
		{
			return configuration.get_TestResultsFiles().Select(ConstructSingleTestResult).ToArray();
		}
		return new SingleTestRunBase[0];
	}
}
