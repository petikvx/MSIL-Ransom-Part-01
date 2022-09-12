namespace Gecko;

public sealed class Cookie
{
	internal nsICookie2 _cookie;

	public long CreationTime => _cookie.GetCreationTimeAttribute();

	public long Expiry => _cookie.GetExpiryAttribute();

	public string Host => nsString.Get(_cookie.GetHostAttribute);

	public bool IsDomain => _cookie.GetIsDomainAttribute();

	public bool IsHttpOnly => _cookie.GetIsHttpOnlyAttribute();

	public bool IsSecure => _cookie.GetIsSecureAttribute();

	public bool IsSession => _cookie.GetIsSessionAttribute();

	public long LastAccessed => _cookie.GetLastAccessedAttribute();

	public string Name => nsString.Get(_cookie.GetNameAttribute);

	public string Path => nsString.Get(_cookie.GetPathAttribute);

	public string RawHost => nsString.Get(_cookie.GetRawHostAttribute);

	public string Value => nsString.Get(_cookie.GetValueAttribute);

	internal Cookie(nsICookie2 cookie)
	{
		_cookie = cookie;
	}
}
