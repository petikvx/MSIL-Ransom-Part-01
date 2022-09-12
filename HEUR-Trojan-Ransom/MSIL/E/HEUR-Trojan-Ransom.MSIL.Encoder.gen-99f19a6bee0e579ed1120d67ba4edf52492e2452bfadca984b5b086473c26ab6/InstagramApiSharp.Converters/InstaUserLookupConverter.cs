using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;
using InstagramApiSharp.Enums;

namespace InstagramApiSharp.Converters;

internal class InstaUserLookupConverter : IObjectConverter<InstaUserLookup, InstaUserLookupResponse>
{
	public InstaUserLookupResponse SourceObject { get; set; }

	public InstaUserLookup Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaUserLookup instaUserLookup = new InstaUserLookup
		{
			CanEmailReset = SourceObject.CanEmailReset,
			CanSmsReset = SourceObject.CanSmsReset,
			CanWaReset = SourceObject.CanWaReset,
			CorrectedInput = SourceObject.CorrectedInput,
			Email = SourceObject.Email,
			EmailSent = SourceObject.EmailSent,
			HasValidPhone = SourceObject.HasValidPhone,
			MultipleUsersFound = SourceObject.MultipleUsersFound,
			PhoneNumber = SourceObject.PhoneNumber,
			SmsSent = SourceObject.SmsSent
		};
		try
		{
			if (!string.IsNullOrEmpty(SourceObject.LookupSource))
			{
				instaUserLookup.LookupSourceType = (InstaLookupType)Enum.Parse(typeof(InstaLookupType), SourceObject.LookupSource, ignoreCase: true);
			}
		}
		catch
		{
		}
		try
		{
			if (SourceObject.User != null)
			{
				instaUserLookup.User = ConvertersFabric.Instance.GetUserShortConverter(SourceObject.User).Convert();
				return instaUserLookup;
			}
			return instaUserLookup;
		}
		catch
		{
			return instaUserLookup;
		}
	}
}
