namespace PicklesDoc.Pickles.TestFrameworks.MsTest;

public class MsTestResults : MultipleTestRunsBase
{
	public MsTestResults(IConfiguration configuration, MsTestSingleResultLoader singleResultLoader, MsTestScenarioOutlineExampleMatcher scenarioOutlineExampleMatcher)
		: base(configuration, singleResultLoader, scenarioOutlineExampleMatcher)
	{
	}
}
