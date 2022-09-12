using System.Collections.Generic;

namespace WindowsFormsApplication1;

public class Metadata7
{
	public string name { get; set; }

	public Schema7 schema { get; set; }

	public string type { get; set; }

	public string notes { get; set; }

	public bool locked { get; set; }

	public List<string> admin_edit_roles { get; set; }

	public string expiry_date { get; set; }
}
