using System.Collections.Generic;

namespace WindowsFormsApplication1;

public class Schema
{
	public string type { get; set; }

	public Properties properties { get; set; }

	public List<string> required { get; set; }
}
