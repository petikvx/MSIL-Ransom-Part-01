namespace WindowsFormsApplication1;

public class RootObject
{
	public Common common { get; set; }

	public UserCookies userCookies { get; set; }

	public PageInfo pageInfo { get; set; }

	public ClientInfo clientInfo { get; set; }

	public bool showLoader { get; set; }

	public string loaderText { get; set; }

	public ErrorModal errorModal { get; set; }

	public bool showCaptcha { get; set; }

	public FlashMessage flashMessage { get; set; }

	public Auth auth { get; set; }

	public Ua ua { get; set; }

	public string csrftoken { get; set; }

	public object errorObj { get; set; }

	public Components components { get; set; }

	public ListingShare listingShare { get; set; }

	public Route route { get; set; }

	public ListingEditor __listing_editor { get; set; }
}
