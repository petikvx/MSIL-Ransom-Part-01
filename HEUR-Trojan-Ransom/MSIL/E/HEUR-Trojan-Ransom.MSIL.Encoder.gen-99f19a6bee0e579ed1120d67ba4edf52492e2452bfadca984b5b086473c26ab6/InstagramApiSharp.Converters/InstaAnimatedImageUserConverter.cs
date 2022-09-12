using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaAnimatedImageUserConverter : IObjectConverter<InstaAnimatedImageUser, InstaAnimatedImageUserResponse>
{
	public InstaAnimatedImageUserResponse SourceObject { get; set; }

	public InstaAnimatedImageUser Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		return new InstaAnimatedImageUser
		{
			IsVerified = SourceObject.IsVerified,
			Username = SourceObject.Username
		};
	}
}
