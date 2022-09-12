using InstagramApiSharp.Classes.Models.Business;
using InstagramApiSharp.Classes.ResponseWrappers.Business;

namespace InstagramApiSharp.Converters.Business;

internal class InstaStatisticsDataPointConverter : IObjectConverter<InstaStatisticsDataPointItem, InstaStatisticsDataPointItemResponse>
{
	public InstaStatisticsDataPointItemResponse SourceObject { get; set; }

	public InstaStatisticsDataPointItem Convert()
	{
		return new InstaStatisticsDataPointItem
		{
			Label = SourceObject.Label,
			Value = SourceObject.Value.GetValueOrDefault()
		};
	}
}
