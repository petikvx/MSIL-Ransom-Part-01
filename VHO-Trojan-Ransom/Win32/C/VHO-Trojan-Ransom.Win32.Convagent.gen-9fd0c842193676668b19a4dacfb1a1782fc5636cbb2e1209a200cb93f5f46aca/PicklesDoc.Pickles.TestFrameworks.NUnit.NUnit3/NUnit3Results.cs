namespace PicklesDoc.Pickles.TestFrameworks.NUnit.NUnit3;

public class NUnit3Results : MultipleTestRunsBase
{
	public NUnit3Results(IConfiguration configuration, NUnit3SingleResultLoader singleResultLoader, NUnit3ScenarioOutlineExampleMatcher scenarioOutlineExampleMatcher)
		: base(configuration, singleResultLoader, scenarioOutlineExampleMatcher)
	{
	}
}
