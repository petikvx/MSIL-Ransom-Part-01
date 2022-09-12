using System;

namespace InstagramApiSharp.Classes.Models;

public class InstaAccountDetails
{
	public DateTime DateJoined { get; set; }

	public bool HasFormerUsernames { get; set; }

	public InstaPrimaryCountryInfo PrimaryCountryInfo { get; set; }

	public bool HasSharedFollowerAccounts { get; set; }

	public InstaAdsInfo AdsInfo { get; set; }
}
