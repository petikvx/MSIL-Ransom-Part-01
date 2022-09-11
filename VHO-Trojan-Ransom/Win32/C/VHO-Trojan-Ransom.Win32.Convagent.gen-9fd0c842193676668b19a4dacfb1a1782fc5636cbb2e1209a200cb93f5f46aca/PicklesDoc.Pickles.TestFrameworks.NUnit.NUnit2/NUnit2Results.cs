namespace PicklesDoc.Pickles.TestFrameworks.NUnit.NUnit2;

public class NUnit2Results : MultipleTestRunsBase
{
	public NUnit2Results(IConfiguration configuration, NUnit2SingleResultLoader singleResultLoader, NUnit2ScenarioOutlineExampleMatcher scenarioOutlineExampleMatcher)
		: base(configuration, singleResultLoader, scenarioOutlineExampleMatcher)
	{
	}
}
