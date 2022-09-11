using System.Collections.Generic;

namespace PicklesDoc.Pickles.TestFrameworks.SpecRun;

public class SpecRunFeature
{
	public string Title { get; set; }

	public List<SpecRunScenario> Scenarios { get; set; }
}
