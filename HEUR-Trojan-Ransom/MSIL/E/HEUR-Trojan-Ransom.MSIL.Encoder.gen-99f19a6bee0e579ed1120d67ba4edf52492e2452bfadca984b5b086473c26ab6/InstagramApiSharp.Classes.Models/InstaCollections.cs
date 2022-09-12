using System.Collections.Generic;

namespace InstagramApiSharp.Classes.Models;

public class InstaCollections
{
	public bool MoreCollectionsAvailable { get; set; }

	public int Pages { get; set; }

	public List<InstaCollectionItem> Items { get; set; }

	public string NextMaxId { get; set; }
}
