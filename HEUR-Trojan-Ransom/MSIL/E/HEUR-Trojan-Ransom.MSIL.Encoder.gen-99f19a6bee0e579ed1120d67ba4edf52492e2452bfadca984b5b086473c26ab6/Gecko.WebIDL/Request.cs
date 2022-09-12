namespace Gecko.WebIDL;

public class Request : WebIDLBase
{
	public ByteString Method => GetProperty<ByteString>("method");

	public USVString Url => GetProperty<USVString>("url");

	public nsISupports Headers => GetProperty<nsISupports>("headers");

	public RequestContext Context => GetProperty<RequestContext>("context");

	public string Referrer => GetProperty<string>("referrer");

	public RequestMode Mode => GetProperty<RequestMode>("mode");

	public RequestCredentials Credentials => GetProperty<RequestCredentials>("credentials");

	public RequestCache Cache => GetProperty<RequestCache>("cache");

	public RequestRedirect Redirect => GetProperty<RequestRedirect>("redirect");

	public Request(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports Clone()
	{
		return CallMethod<nsISupports>("clone", new object[0]);
	}

	public void SetContentPolicyType(uint context)
	{
		CallVoidMethod("setContentPolicyType", context);
	}
}
