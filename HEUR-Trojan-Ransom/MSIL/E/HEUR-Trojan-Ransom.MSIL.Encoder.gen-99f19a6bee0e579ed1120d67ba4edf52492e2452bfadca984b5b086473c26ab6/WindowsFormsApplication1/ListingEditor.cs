using System.Collections.Generic;

namespace WindowsFormsApplication1;

public class ListingEditor
{
	public CalculatedEarnings calculatedEarnings { get; set; }

	public CatalogMeta catalogMeta { get; set; }

	public BrandSuggestions brandSuggestions { get; set; }

	public Post post { get; set; }

	public List<object> extServiceIds { get; set; }

	public List<object> eventIds { get; set; }

	public List<string> imageFiles { get; set; }

	public List<string> editedImages { get; set; }

	public List<UploadedImage> uploadedImages { get; set; }

	public bool imageFirstSelected { get; set; }

	public string postState { get; set; }

	public Presentation presentation { get; set; }

	public string mode { get; set; }

	public string postId { get; set; }
}
