using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1;

public class Datum2
{
	public string id { get; set; }

	public DateTime created_at { get; set; }

	public string creator_id { get; set; }

	public CoverShot3 cover_shot { get; set; }

	public string content_type { get; set; }

	public string description { get; set; }

	public List<string> experiences { get; set; }

	public string name { get; set; }

	public string short_url { get; set; }

	public List<object> tags { get; set; }

	public DateTime updated_at { get; set; }
}
