using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;
using InstagramApiSharp.Enums;

namespace InstagramApiSharp.Converters;

internal class InstaTopicalExploreClusterConverter : IObjectConverter<InstaTopicalExploreCluster, InstaTopicalExploreClusterResponse>
{
	public InstaTopicalExploreClusterResponse SourceObject { get; set; }

	public InstaTopicalExploreCluster Convert()
	{
		InstaTopicalExploreCluster instaTopicalExploreCluster = new InstaTopicalExploreCluster
		{
			CanMute = SourceObject.CanMute.GetValueOrDefault(),
			Context = SourceObject.Context,
			DebugInfo = SourceObject.DebugInfo,
			Description = SourceObject.Description,
			Id = SourceObject.Id,
			IsMuted = SourceObject.IsMuted.GetValueOrDefault(),
			Name = SourceObject.Name,
			RankedPosition = SourceObject.RankedPosition.GetValueOrDefault(),
			Title = SourceObject.Title
		};
		try
		{
			string value = SourceObject.Type.Replace("_", "");
			instaTopicalExploreCluster.Type = (InstaExploreClusterType)Enum.Parse(typeof(InstaExploreClusterType), value, ignoreCase: true);
			return instaTopicalExploreCluster;
		}
		catch
		{
			instaTopicalExploreCluster.Type = InstaExploreClusterType.ExploreAll;
			return instaTopicalExploreCluster;
		}
	}
}
