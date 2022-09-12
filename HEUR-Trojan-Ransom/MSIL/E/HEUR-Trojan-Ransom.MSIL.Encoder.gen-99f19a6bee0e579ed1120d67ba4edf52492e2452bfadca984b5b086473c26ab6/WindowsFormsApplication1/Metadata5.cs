using System.Collections.Generic;

namespace WindowsFormsApplication1;

public class Metadata5
{
	public string name { get; set; }

	public List<string> admin_edit_roles { get; set; }

	public string notes { get; set; }

	public Schema5 schema { get; set; }

	public bool locked { get; set; }

	public string expiry_date { get; set; }

	public string type { get; set; }
}
