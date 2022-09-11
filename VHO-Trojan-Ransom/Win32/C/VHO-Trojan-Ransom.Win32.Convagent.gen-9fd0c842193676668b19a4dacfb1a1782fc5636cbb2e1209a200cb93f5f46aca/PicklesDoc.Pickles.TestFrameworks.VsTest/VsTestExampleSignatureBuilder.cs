using System.Text.RegularExpressions;
using PicklesDoc.Pickles.ObjectModel;

namespace PicklesDoc.Pickles.TestFrameworks.VsTest;

public class VsTestExampleSignatureBuilder
{
	public Regex Build(ScenarioOutline scenarioOutline, string[] row)
	{
		return new Regex(string.Empty);
	}
}
