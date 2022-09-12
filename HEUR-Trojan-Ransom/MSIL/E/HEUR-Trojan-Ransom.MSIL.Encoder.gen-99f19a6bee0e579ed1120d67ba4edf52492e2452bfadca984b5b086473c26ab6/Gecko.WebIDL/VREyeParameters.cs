namespace Gecko.WebIDL;

public class VREyeParameters : WebIDLBase
{
	public nsISupports MinimumFieldOfView => GetProperty<nsISupports>("minimumFieldOfView");

	public nsISupports MaximumFieldOfView => GetProperty<nsISupports>("maximumFieldOfView");

	public nsISupports RecommendedFieldOfView => GetProperty<nsISupports>("recommendedFieldOfView");

	public nsISupports EyeTranslation => GetProperty<nsISupports>("eyeTranslation");

	public nsISupports CurrentFieldOfView => GetProperty<nsISupports>("currentFieldOfView");

	public nsISupports RenderRect => GetProperty<nsISupports>("renderRect");

	public VREyeParameters(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
