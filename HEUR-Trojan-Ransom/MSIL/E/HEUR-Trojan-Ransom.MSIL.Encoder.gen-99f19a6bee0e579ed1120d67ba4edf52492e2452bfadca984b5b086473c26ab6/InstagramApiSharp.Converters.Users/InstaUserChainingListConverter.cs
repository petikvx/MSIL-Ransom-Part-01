using System;
using System.Linq;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters.Users;

internal class InstaUserChainingListConverter : IObjectConverter<InstaUserChainingList, InstaUserChainingContainerResponse>
{
	public InstaUserChainingContainerResponse SourceObject { get; set; }

	public InstaUserChainingList Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaUserChainingList instaUserChainingList = new InstaUserChainingList
		{
			Status = SourceObject.Status,
			IsBackup = SourceObject.IsBackup
		};
		if (SourceObject.Users != null && SourceObject.Users.Any())
		{
			foreach (InstaUserChainingResponse user in SourceObject.Users)
			{
				try
				{
					instaUserChainingList.Add(ConvertersFabric.Instance.GetSingleUserChainingConverter(user).Convert());
				}
				catch
				{
				}
			}
			return instaUserChainingList;
		}
		return instaUserChainingList;
	}
}
