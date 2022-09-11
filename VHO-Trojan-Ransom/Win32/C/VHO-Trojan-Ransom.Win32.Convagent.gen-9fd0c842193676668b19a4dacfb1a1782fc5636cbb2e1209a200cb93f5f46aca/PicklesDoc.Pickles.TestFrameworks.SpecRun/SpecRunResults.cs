namespace PicklesDoc.Pickles.TestFrameworks.SpecRun;

public class SpecRunResults : MultipleTestRunsBase
{
	public SpecRunResults(IConfiguration configuration, SpecRunSingleResultLoader singleResultLoader, SpecRunScenarioOutlineExampleMatcher scenarioOutlineExampleMatcher)
		: base(configuration, singleResultLoader, scenarioOutlineExampleMatcher)
	{
	}
}
