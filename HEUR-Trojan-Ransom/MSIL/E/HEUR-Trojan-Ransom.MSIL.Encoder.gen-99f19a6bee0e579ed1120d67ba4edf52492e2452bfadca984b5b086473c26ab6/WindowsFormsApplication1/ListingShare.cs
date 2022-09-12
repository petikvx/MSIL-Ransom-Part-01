using System.Collections.Generic;

namespace WindowsFormsApplication1;

public class ListingShare
{
	public List<object> directInteractionUserList { get; set; }

	public DirectSearchUserList directSearchUserList { get; set; }

	public AddPostToBundleResponse addPostToBundleResponse { get; set; }

	public AddPostResponse addPostResponse { get; set; }

	public List<object> currentParties { get; set; }

	public ExtListingShare extListingShare { get; set; }

	public object postToShare { get; set; }
}
