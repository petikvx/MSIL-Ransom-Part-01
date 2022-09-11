using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace PicklesDoc.Pickles.TestFrameworks.SpecRun;

internal static class Factory
{
	internal static SpecRunFeature ToSpecRunFeature(XElement featureXml)
	{
		XElement val = ((XContainer)featureXml).Element(XName.op_Implicit("title"));
		XElement val2 = ((XContainer)featureXml).Element(XName.op_Implicit("scenarios"));
		return new SpecRunFeature
		{
			Title = ((val != null) ? val.get_Value() : string.Empty),
			Scenarios = ((val2 != null) ? ((XContainer)val2).Elements(XName.op_Implicit("scenario")).Select(ToSpecRunScenario).ToList() : new List<SpecRunScenario>())
		};
	}

	internal static SpecRunScenario ToSpecRunScenario(XElement scenarioXml)
	{
		XElement val = ((XContainer)scenarioXml).Element(XName.op_Implicit("title"));
		XElement val2 = ((XContainer)scenarioXml).Element(XName.op_Implicit("result"));
		return new SpecRunScenario
		{
			Title = ((val != null) ? val.get_Value() : string.Empty),
			Result = ((val2 != null) ? val2.get_Value() : string.Empty)
		};
	}
}
