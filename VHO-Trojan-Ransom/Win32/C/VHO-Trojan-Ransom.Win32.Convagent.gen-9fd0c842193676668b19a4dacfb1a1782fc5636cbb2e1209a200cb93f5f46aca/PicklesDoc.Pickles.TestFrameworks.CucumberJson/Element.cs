using System.Collections.Generic;

namespace PicklesDoc.Pickles.TestFrameworks.CucumberJson;

public class Element
{
	public string keyword { get; set; }

	public string id { get; set; }

	public string name { get; set; }

	public int line { get; set; }

	public string description { get; set; }

	public List<Tag> tags { get; set; }

	public string type { get; set; }

	public List<Step> steps { get; set; }
}
