using System.Collections.Generic;

namespace InstagramApiSharp.Classes.Models;

public class InstaUserChainingList : List<InstaUserChaining>
{
	internal string Status { get; set; }

	public bool IsBackup { get; set; }
}
