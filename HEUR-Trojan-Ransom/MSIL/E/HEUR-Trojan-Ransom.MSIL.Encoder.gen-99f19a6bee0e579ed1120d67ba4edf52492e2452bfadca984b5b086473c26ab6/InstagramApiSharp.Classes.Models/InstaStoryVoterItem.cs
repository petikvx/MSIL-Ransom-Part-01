using System;

namespace InstagramApiSharp.Classes.Models;

public class InstaStoryVoterItem
{
	public InstaUserShortFriendship User { get; set; }

	public double Vote { get; set; }

	public DateTime Time { get; set; }
}
