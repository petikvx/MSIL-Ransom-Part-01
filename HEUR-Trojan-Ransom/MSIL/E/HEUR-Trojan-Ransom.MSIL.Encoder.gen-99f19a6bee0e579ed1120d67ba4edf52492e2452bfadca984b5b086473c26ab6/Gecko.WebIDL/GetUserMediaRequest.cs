namespace Gecko.WebIDL;

public class GetUserMediaRequest : WebIDLBase
{
	public ulong WindowID => GetProperty<ulong>("windowID");

	public ulong InnerWindowID => GetProperty<ulong>("innerWindowID");

	public string CallID => GetProperty<string>("callID");

	public bool IsSecure => GetProperty<bool>("isSecure");

	public GetUserMediaRequest(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public object GetConstraints()
	{
		return CallMethod<object>("getConstraints", new object[0]);
	}
}
