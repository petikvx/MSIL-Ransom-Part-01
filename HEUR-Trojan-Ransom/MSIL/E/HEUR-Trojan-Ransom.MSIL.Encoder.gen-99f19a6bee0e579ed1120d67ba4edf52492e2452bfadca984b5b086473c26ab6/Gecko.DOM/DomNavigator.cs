namespace Gecko.DOM;

public sealed class DomNavigator
{
	private nsIDOMNavigator _navigator;

	public string AppCodeName => nsString.Get(_navigator.GetAppCodeNameAttribute);

	public string AppName => nsString.Get(_navigator.GetAppNameAttribute);

	public string AppVersion => nsString.Get(_navigator.GetAppVersionAttribute);

	public string BuildID => nsString.Get(_navigator.GetBuildIDAttribute);

	public string DoNotTrack => nsString.Get(_navigator.GetDoNotTrackAttribute);

	public string Language => nsString.Get(_navigator.GetLanguageAttribute);

	public string Oscpu => nsString.Get(_navigator.GetOscpuAttribute);

	public string Platform => nsString.Get(_navigator.GetPlatformAttribute);

	public string Product => nsString.Get(_navigator.GetProductAttribute);

	public string ProductSub => nsString.Get(_navigator.GetProductSubAttribute);

	public string UserAgent => nsString.Get(_navigator.GetUserAgentAttribute);

	public string Vendor => nsString.Get(_navigator.GetVendorAttribute);

	public string GetVendorSub => nsString.Get(_navigator.GetVendorSubAttribute);

	internal DomNavigator(nsIDOMNavigator navigator)
	{
		_navigator = navigator;
	}
}
