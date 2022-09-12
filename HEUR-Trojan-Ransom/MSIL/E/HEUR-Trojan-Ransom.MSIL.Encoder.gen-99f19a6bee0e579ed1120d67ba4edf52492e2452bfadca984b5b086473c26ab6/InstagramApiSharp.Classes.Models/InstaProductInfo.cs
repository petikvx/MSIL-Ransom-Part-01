using System.Collections.Generic;

namespace InstagramApiSharp.Classes.Models;

public class InstaProductInfo
{
	public InstaProduct Product { get; set; }

	public List<InstaProduct> OtherProducts { get; set; } = new List<InstaProduct>();


	public InstaUserShort User { get; set; }

	public InstaProductMediaList MoreFromBusiness { get; set; }
}
