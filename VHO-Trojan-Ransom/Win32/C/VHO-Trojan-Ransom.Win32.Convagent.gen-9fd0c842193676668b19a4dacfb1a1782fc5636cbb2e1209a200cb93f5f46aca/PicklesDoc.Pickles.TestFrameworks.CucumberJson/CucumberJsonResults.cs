namespace PicklesDoc.Pickles.TestFrameworks.CucumberJson;

public class CucumberJsonResults : MultipleTestRunsBase
{
	public CucumberJsonResults(IConfiguration configuration, CucumberJsonSingleResultLoader singleResultLoader)
		: base(configuration, singleResultLoader)
	{
	}
}
