using System.Collections.Generic;

namespace WindowsFormsApplication1;

public class SizeQuantity
{
	public string size_id { get; set; }

	public int quantity_available { get; set; }

	public int quantity_reserved { get; set; }

	public int quantity_sold { get; set; }

	public int size_ref { get; set; }

	public SizeObj size_obj { get; set; }

	public List<string> size_set_tags { get; set; }
}
