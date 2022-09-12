using System.Collections.Generic;

namespace InstagramApiSharp.Classes.Models;

public class InstaWebTextData
{
	public string MaxId { get; set; }

	public List<string> Items { get; set; } = new List<string>();

}
