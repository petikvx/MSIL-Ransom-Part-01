using System;
using System.Linq;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaBrandedContentConverter : IObjectConverter<InstaBrandedContent, InstaBrandedContentResponse>
{
	public InstaBrandedContentResponse SourceObject { get; set; }

	public InstaBrandedContent Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("SourceObject");
		}
		InstaBrandedContent instaBrandedContent = new InstaBrandedContent
		{
			RequireApproval = SourceObject.RequireApproval
		};
		if (SourceObject.WhitelistedUsers != null && SourceObject.WhitelistedUsers.Any())
		{
			foreach (InstaUserShortResponse whitelistedUser in SourceObject.WhitelistedUsers)
			{
				try
				{
					instaBrandedContent.WhitelistedUsers.Add(ConvertersFabric.Instance.GetUserShortConverter(whitelistedUser).Convert());
				}
				catch
				{
				}
			}
			return instaBrandedContent;
		}
		return instaBrandedContent;
	}
}
