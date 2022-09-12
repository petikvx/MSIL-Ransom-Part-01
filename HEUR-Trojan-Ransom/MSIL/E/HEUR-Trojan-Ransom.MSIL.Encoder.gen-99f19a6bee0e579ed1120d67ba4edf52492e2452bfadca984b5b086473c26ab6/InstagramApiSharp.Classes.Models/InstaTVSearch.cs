using System.Collections.Generic;

namespace InstagramApiSharp.Classes.Models;

public class InstaTVSearch
{
	public List<InstaTVSearchResult> Results { get; set; } = new List<InstaTVSearchResult>();


	public int NumResults { get; set; }

	public string RankToken { get; set; }

	internal string Status { get; set; }
}
