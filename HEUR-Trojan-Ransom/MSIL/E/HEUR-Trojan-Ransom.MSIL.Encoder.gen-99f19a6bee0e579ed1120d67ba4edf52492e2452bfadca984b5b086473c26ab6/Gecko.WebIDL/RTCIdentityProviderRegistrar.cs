namespace Gecko.WebIDL;

public class RTCIdentityProviderRegistrar : WebIDLBase
{
	public nsISupports Idp => GetProperty<nsISupports>("idp");

	public RTCIdentityProviderRegistrar(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Register(nsISupports idp)
	{
		CallVoidMethod("register", idp);
	}

	public Promise<object> GenerateAssertion(string contents, string origin)
	{
		return CallMethod<Promise<object>>("generateAssertion", new object[2] { contents, origin });
	}

	public Promise<object> GenerateAssertion(string contents, string origin, string usernameHint)
	{
		return CallMethod<Promise<object>>("generateAssertion", new object[3] { contents, origin, usernameHint });
	}

	public Promise<object> ValidateAssertion(string assertion, string origin)
	{
		return CallMethod<Promise<object>>("validateAssertion", new object[2] { assertion, origin });
	}
}
