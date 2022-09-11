using System.Text.RegularExpressions;
using PicklesDoc.Pickles.ObjectModel;

namespace PicklesDoc.Pickles.TestFrameworks.MsTest;

public class MsTestExampleSignatureBuilder
{
	public Regex Build(ScenarioOutline scenarioOutline, string[] row)
	{
		return new Regex(string.Empty);
	}
}
