using System.Collections.Generic;

namespace InstagramApiSharp.Classes.Models;

public class InstaBlockedUsers : InstaDefault
{
	public List<InstaBlockedUserInfo> BlockedList { get; set; } = new List<InstaBlockedUserInfo>();


	public int? PageSize { get; set; }

	public string MaxId { get; set; }
}
