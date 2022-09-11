using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using PicklesDoc.Pickles.ObjectModel;

namespace PicklesDoc.Pickles.TestFrameworks.VsTest;

public class VsTestScenarioOutlineExampleMatcher : IScenarioOutlineExampleMatcher
{
	private static readonly Regex VariantRegex = new Regex("(.*)_Variant([\\d*])", RegexOptions.IgnoreCase | RegexOptions.Compiled);

	private const int VariantNumberGroup = 2;

	public bool IsMatch(ScenarioOutline scenarioOutline, string[] exampleValues, object scenarioElement)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		XElement scenario = (XElement)scenarioElement;
		string value = exampleValues[0].Replace(" ", string.Empty).Replace(":", string.Empty).Replace("\\", string.Empty)
			.Replace("(", string.Empty)
			.Replace(")", string.Empty)
			.Replace(".", "_")
			.Replace("!", string.Empty)
			.Replace("&", string.Empty)
			.ToUpperInvariant()
			.Replace("Ä", "A")
			.Replace("Ö", "O")
			.Replace("Ü", "U")
			.Replace("ß", "B")
			.Replace("æ", "ae")
			.Replace('ø', 'o')
			.Replace('å', 'a')
			.Replace("Æ", "AE")
			.Replace('Ø', 'O')
			.Replace('Å', 'A');
		Match match = VariantRegex.Match(scenario.Name().ToUpperInvariant());
		if (match.Success && int.TryParse(match.Groups[2].Value, out var result))
		{
			List<Example> examples = ((ScenarioBase)scenarioOutline).get_Examples();
			if (examples != null && examples.Count > 0)
			{
				return ((ScenarioBase)scenarioOutline).get_Examples().SelectMany((Example x) => ((Table)x.get_TableArgument()).get_DataRows()).ElementAt(result)
					.get_Cells()
					.SequenceEqual(exampleValues);
			}
		}
		return scenario.Name().ToUpperInvariant().EndsWith(value);
	}
}
