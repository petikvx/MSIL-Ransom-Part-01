using System.Text;
using System.Text.RegularExpressions;
using PicklesDoc.Pickles.ObjectModel;

namespace PicklesDoc.Pickles.TestFrameworks.NUnit.NUnit3;

public class NUnit3ExampleSignatureBuilder
{
	public Regex Build(ScenarioOutline scenarioOutline, string[] row)
	{
		StringBuilder stringBuilder = new StringBuilder();
		string value = SpecFlowNameMapping.Build(((ScenarioBase)scenarioOutline).get_Name());
		stringBuilder.Append(value).Append("\\(");
		foreach (string str in row)
		{
			stringBuilder.AppendFormat("\"{0}\",", Regex.Escape(str));
		}
		stringBuilder.Remove(stringBuilder.Length - 1, 1);
		return new Regex(stringBuilder.ToString(), RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);
	}
}
