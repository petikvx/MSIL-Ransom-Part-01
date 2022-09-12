using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1;

public class Datum4
{
	public string id { get; set; }

	public DateTime created_at { get; set; }

	public string creator_id { get; set; }

	public CoverShot5 cover_shot { get; set; }

	public string content_type { get; set; }

	public string description { get; set; }

	public List<object> experiences { get; set; }

	public string name { get; set; }

	public string short_url { get; set; }

	public List<object> tags { get; set; }

	public DateTime updated_at { get; set; }
}
