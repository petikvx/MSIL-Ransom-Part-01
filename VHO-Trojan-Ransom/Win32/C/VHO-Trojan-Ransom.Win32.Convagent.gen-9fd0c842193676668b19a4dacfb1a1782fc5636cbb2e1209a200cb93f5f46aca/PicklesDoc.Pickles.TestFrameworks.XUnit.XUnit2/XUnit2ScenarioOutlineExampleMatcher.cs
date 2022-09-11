using System.Text.RegularExpressions;
using PicklesDoc.Pickles.ObjectModel;

namespace PicklesDoc.Pickles.TestFrameworks.XUnit.XUnit2;

public class XUnit2ScenarioOutlineExampleMatcher : IScenarioOutlineExampleMatcher
{
	private readonly XUnitExampleSignatureBuilder signatureBuilder = new XUnitExampleSignatureBuilder();

	public bool IsMatch(ScenarioOutline scenarioOutline, string[] exampleValues, object scenarioElement)
	{
		Regex signature = signatureBuilder.Build(scenarioOutline, exampleValues);
		return ScenarioOutlineExampleIsMatch((assembliesAssemblyCollectionTest)scenarioElement, signature);
	}

	private bool ScenarioOutlineExampleIsMatch(assembliesAssemblyCollectionTest exampleElement, Regex signature)
	{
		GroupCollection groups = new Regex("^(?<name>(.*))(\\(.*\\))$", RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant).Match(exampleElement.name).Groups;
		string oldValue = (groups["name"].Success ? groups["name"].Value : exampleElement.name);
		string text = exampleElement.name.Replace(oldValue, exampleElement.method);
		string newValue = Regex.Escape("\"");
		string input = text.Replace("\\\\\"", "\"").Replace("\\\"", newValue);
		string input2 = exampleElement.name.Replace("\\\\\"", "\"").Replace("\\\"", newValue);
		string pattern = signature.ToString().Replace("\\\"", newValue);
		if (!Regex.IsMatch(input2, pattern, RegexOptions.IgnoreCase))
		{
			return Regex.IsMatch(input, pattern, RegexOptions.IgnoreCase);
		}
		return true;
	}
}
