namespace Gecko.WebIDL;

public class DOMTokenList : WebIDLBase
{
	public uint Length => GetProperty<uint>("length");

	public DOMTokenList(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public bool Contains(string token)
	{
		return CallMethod<bool>("contains", new object[1] { token });
	}

	public void Add(string tokens)
	{
		CallVoidMethod("add", tokens);
	}

	public void Remove(string tokens)
	{
		CallVoidMethod("remove", tokens);
	}

	public bool Toggle(string token)
	{
		return CallMethod<bool>("toggle", new object[1] { token });
	}

	public bool Toggle(string token, bool force)
	{
		return CallMethod<bool>("toggle", new object[2] { token, force });
	}
}
