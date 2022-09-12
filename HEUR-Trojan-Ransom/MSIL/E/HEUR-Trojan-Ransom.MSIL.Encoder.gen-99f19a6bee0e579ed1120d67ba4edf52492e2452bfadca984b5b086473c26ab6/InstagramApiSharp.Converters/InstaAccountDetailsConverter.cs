using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;
using InstagramApiSharp.Helpers;

namespace InstagramApiSharp.Converters;

internal class InstaAccountDetailsConverter : IObjectConverter<InstaAccountDetails, InstaAccountDetailsResponse>
{
	public InstaAccountDetailsResponse SourceObject { get; set; }

	public InstaAccountDetails Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaAccountDetails instaAccountDetails = new InstaAccountDetails
		{
			DateJoined = DateTimeHelper.FromUnixTimeSeconds(SourceObject.DateJoined.GetValueOrDefault())
		};
		if (SourceObject.FormerUsernameInfo != null)
		{
			instaAccountDetails.HasFormerUsernames = SourceObject.FormerUsernameInfo.HasFormerUsernames.GetValueOrDefault();
		}
		if (SourceObject.SharedFollowerAccountsInfo != null)
		{
			instaAccountDetails.HasSharedFollowerAccounts = SourceObject.SharedFollowerAccountsInfo.HasSharedFollowerAccounts.GetValueOrDefault();
		}
		if (SourceObject.AdsInfo != null)
		{
			try
			{
				instaAccountDetails.AdsInfo = ConvertersFabric.Instance.GetAdsInfoConverter(SourceObject.AdsInfo).Convert();
			}
			catch
			{
			}
		}
		if (SourceObject.PrimaryCountryInfo != null)
		{
			try
			{
				instaAccountDetails.PrimaryCountryInfo = ConvertersFabric.Instance.GetPrimaryCountryInfoConverter(SourceObject.PrimaryCountryInfo).Convert();
				return instaAccountDetails;
			}
			catch
			{
				return instaAccountDetails;
			}
		}
		return instaAccountDetails;
	}
}
