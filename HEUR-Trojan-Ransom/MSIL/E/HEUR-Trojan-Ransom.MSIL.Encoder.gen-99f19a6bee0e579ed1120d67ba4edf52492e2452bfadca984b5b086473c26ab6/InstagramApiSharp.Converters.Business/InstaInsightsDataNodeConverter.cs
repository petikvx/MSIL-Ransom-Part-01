using System;
using InstagramApiSharp.Classes.Models.Business;
using InstagramApiSharp.Classes.ResponseWrappers.Business;
using InstagramApiSharp.Enums;

namespace InstagramApiSharp.Converters.Business;

internal class InstaInsightsDataNodeConverter : IObjectConverter<InstaInsightsDataNode, InstaInsightsDataNodeResponse>
{
	public InstaInsightsDataNodeResponse SourceObject { get; set; }

	public InstaInsightsDataNode Convert()
	{
		InstaInsightsDataNode instaInsightsDataNode = new InstaInsightsDataNode
		{
			Value = SourceObject.Value.GetValueOrDefault()
		};
		try
		{
			if (Enum.TryParse<InstaInsightsNameType>(SourceObject.Name.Trim().Replace("_", ""), ignoreCase: true, out var result))
			{
				instaInsightsDataNode.NameType = result;
				return instaInsightsDataNode;
			}
			return instaInsightsDataNode;
		}
		catch
		{
			return instaInsightsDataNode;
		}
	}
}
