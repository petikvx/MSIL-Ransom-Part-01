namespace PicklesDoc.Pickles.TestFrameworks.VsTest;

public class VsTestResults : MultipleTestRunsBase
{
	public VsTestResults(IConfiguration configuration, VsTestSingleResultLoader singleResultLoader, VsTestScenarioOutlineExampleMatcher scenarioOutlineExampleMatcher)
		: base(configuration, singleResultLoader, scenarioOutlineExampleMatcher)
	{
	}
}
