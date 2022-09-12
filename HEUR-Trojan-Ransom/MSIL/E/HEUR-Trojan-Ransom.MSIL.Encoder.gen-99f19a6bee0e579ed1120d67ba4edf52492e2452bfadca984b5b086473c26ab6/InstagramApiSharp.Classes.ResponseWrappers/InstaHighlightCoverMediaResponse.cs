using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaHighlightCoverMediaResponse
{
	[JsonProperty("cropped_image_version")]
	public ImageResponse CroppedImageVersion { get; set; }

	[JsonProperty("crop_rect")]
	public float[] CropRect { get; set; }

	[JsonProperty("media_id")]
	public string MediaId { get; set; }

	[JsonProperty("full_image_version")]
	public ImageResponse FullImageVersion { get; set; }
}
