using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1;

public class Inventory
{
	public string status { get; set; }

	public DateTime status_changed_at { get; set; }

	public List<SizeQuantity> size_quantities { get; set; }

	public int size_quantity_revision { get; set; }

	public bool multi_item { get; set; }
}
