using System.Text.RegularExpressions;
using System.Xml.Linq;
using PicklesDoc.Pickles.ObjectModel;

namespace PicklesDoc.Pickles.TestFrameworks.NUnit.NUnit2;

public class NUnit2ScenarioOutlineExampleMatcher : IScenarioOutlineExampleMatcher
{
	private readonly NUnit2ExampleSignatureBuilder signatureBuilder = new NUnit2ExampleSignatureBuilder();

	public bool IsMatch(ScenarioOutline scenarioOutline, string[] exampleValues, object scenarioElement)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		Regex exampleSignature = signatureBuilder.Build(scenarioOutline, exampleValues);
		return IsMatchingTestCase((XElement)scenarioElement, exampleSignature);
	}

	internal static bool IsMatchingTestCase(XElement x, Regex exampleSignature)
	{
		XAttribute val = x.Attribute(XName.op_Implicit("name"));
		if (val != null)
		{
			return exampleSignature.IsMatch(val.get_Value().Replace("\\\\", "\\"));
		}
		return false;
	}
}
