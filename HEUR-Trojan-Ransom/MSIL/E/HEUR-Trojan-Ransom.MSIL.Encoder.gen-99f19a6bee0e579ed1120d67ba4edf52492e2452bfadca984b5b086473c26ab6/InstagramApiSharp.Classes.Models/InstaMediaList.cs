using System.Collections.Generic;

namespace InstagramApiSharp.Classes.Models;

public class InstaMediaList : List<InstaMedia>, IInstaBaseList
{
	public int Pages { get; set; }

	public int PageSize { get; set; }

	public string NextMaxId { get; set; }
}
