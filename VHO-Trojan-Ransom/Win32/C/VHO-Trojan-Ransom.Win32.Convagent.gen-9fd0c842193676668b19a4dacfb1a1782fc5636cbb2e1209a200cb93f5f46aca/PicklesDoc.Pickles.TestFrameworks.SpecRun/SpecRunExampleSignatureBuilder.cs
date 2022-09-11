using System.Text;
using System.Text.RegularExpressions;
using PicklesDoc.Pickles.ObjectModel;

namespace PicklesDoc.Pickles.TestFrameworks.SpecRun;

public class SpecRunExampleSignatureBuilder
{
	public Regex Build(ScenarioOutline scenarioOutline, string[] row)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(Regex.Escape(((ScenarioBase)scenarioOutline).get_Name()));
		stringBuilder.Append("(, Examples (\\d*))?");
		stringBuilder.Append(", " + Regex.Escape(row[0]));
		return new Regex(stringBuilder.ToString());
	}
}
