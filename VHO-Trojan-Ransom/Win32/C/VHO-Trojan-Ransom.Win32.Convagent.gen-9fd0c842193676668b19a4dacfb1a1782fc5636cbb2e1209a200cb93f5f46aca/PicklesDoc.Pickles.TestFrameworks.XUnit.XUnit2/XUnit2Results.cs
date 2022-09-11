namespace PicklesDoc.Pickles.TestFrameworks.XUnit.XUnit2;

public class XUnit2Results : MultipleTestRunsBase
{
	public XUnit2Results(IConfiguration configuration, XUnit2SingleResultLoader singleResultLoader, XUnit2ScenarioOutlineExampleMatcher scenarioOutlineExampleMatcher)
		: base(configuration, singleResultLoader, scenarioOutlineExampleMatcher)
	{
	}
}
