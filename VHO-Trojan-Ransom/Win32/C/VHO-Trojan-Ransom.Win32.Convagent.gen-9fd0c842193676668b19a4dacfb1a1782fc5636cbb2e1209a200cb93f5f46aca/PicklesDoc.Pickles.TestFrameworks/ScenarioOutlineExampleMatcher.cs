using PicklesDoc.Pickles.ObjectModel;

namespace PicklesDoc.Pickles.TestFrameworks;

internal class ScenarioOutlineExampleMatcher : IScenarioOutlineExampleMatcher
{
	public bool IsMatch(ScenarioOutline scenarioOutline, string[] exampleValues, object scenarioElement)
	{
		return false;
	}
}
