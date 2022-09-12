namespace InstagramApiSharp.Classes.Models.Business;

public class InstaMediaShort
{
	public string Image { get; set; }

	public string MediaIdentifier { get; set; }

	public string InsightsState { get; set; }

	public long MetricsImpressionsOrganicValue { get; set; }

	public string Id { get; set; }

	public InstaMediaType MediaType { get; set; }
}
