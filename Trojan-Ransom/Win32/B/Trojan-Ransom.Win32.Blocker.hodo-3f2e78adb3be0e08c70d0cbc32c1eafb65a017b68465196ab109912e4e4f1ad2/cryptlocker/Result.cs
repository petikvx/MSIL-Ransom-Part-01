using System.Collections.Generic;

namespace cryptlocker;

public class Result
{
	public List<AddressComponent> address_components { get; set; }

	public string formatted_address { get; set; }

	public Geometry geometry { get; set; }

	public string place_id { get; set; }

	public List<string> types { get; set; }
}
