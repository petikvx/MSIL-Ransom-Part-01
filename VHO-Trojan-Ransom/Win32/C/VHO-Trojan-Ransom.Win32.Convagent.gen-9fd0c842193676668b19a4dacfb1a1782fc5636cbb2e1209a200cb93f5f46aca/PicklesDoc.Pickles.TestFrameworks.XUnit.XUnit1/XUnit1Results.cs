namespace PicklesDoc.Pickles.TestFrameworks.XUnit.XUnit1;

public class XUnit1Results : MultipleTestRunsBase
{
	public XUnit1Results(IConfiguration configuration, XUnit1SingleResultLoader singleResultLoader, XUnit1ScenarioOutlineExampleMatcher scenarioOutlineExampleMatcher)
		: base(configuration, singleResultLoader, scenarioOutlineExampleMatcher)
	{
	}
}
