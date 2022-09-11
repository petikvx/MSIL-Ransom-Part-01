using PicklesDoc.Pickles.ObjectModel;

namespace PicklesDoc.Pickles.TestFrameworks.SpecRun;

public class SpecRunScenarioOutlineExampleMatcher : IScenarioOutlineExampleMatcher
{
	private readonly SpecRunExampleSignatureBuilder signatureBuilder = new SpecRunExampleSignatureBuilder();

	public bool IsMatch(ScenarioOutline scenarioOutline, string[] exampleValues, object scenarioElement)
	{
		return signatureBuilder.Build(scenarioOutline, exampleValues).IsMatch(((SpecRunScenario)scenarioElement).Title);
	}
}
