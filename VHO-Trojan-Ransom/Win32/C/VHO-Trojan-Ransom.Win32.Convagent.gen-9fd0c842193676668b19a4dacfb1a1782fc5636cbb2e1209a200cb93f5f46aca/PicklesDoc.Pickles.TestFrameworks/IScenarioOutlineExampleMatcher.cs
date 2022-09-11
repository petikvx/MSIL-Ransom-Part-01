using PicklesDoc.Pickles.ObjectModel;

namespace PicklesDoc.Pickles.TestFrameworks;

public interface IScenarioOutlineExampleMatcher
{
	bool IsMatch(ScenarioOutline scenarioOutline, string[] exampleValues, object scenarioElement);
}
