using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using PicklesDoc.Pickles.ObjectModel;

namespace PicklesDoc.Pickles.TestFrameworks.MsTest;

public class MsTestScenarioOutlineExampleMatcher : IScenarioOutlineExampleMatcher
{
	public bool IsMatch(ScenarioOutline scenarioOutline, string[] exampleValues, object scenarioElement)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		List<string> source = MsTestElementExtensions.DetermineValuesInScenario((XElement)scenarioElement);
		return exampleValues.OrderBy((string e) => e).SequenceEqual(source.OrderBy((string v) => v));
	}
}
