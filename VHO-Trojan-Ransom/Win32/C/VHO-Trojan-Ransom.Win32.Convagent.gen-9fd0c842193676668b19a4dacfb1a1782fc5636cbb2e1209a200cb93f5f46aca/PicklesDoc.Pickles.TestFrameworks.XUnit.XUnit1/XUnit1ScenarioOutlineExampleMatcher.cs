using System.Text.RegularExpressions;
using System.Xml.Linq;
using PicklesDoc.Pickles.ObjectModel;

namespace PicklesDoc.Pickles.TestFrameworks.XUnit.XUnit1;

public class XUnit1ScenarioOutlineExampleMatcher : IScenarioOutlineExampleMatcher
{
	private readonly XUnitExampleSignatureBuilder signatureBuilder = new XUnitExampleSignatureBuilder();

	public bool IsMatch(ScenarioOutline scenarioOutline, string[] exampleValues, object scenarioElement)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		Regex exampleSignature = signatureBuilder.Build(scenarioOutline, exampleValues);
		return IsMatchingTestCase((XElement)scenarioElement, exampleSignature);
	}

	internal static bool IsMatchingTestCase(XElement x, Regex exampleSignature)
	{
		return exampleSignature.IsMatch(x.Attribute(XName.op_Implicit("name")).get_Value());
	}
}
