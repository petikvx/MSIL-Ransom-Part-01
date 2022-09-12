namespace Gecko.WebIDL;

public class URLSearchParams : WebIDLBase
{
	public URLSearchParams(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Append(USVString name, USVString value)
	{
		CallVoidMethod("append", name, value);
	}

	public void Delete(USVString name)
	{
		CallVoidMethod("delete", name);
	}

	public USVString Get(USVString name)
	{
		return CallMethod<USVString>("get", new object[1] { name });
	}

	public USVString[] GetAll(USVString name)
	{
		return CallMethod<USVString[]>("getAll", new object[1] { name });
	}

	public bool Has(USVString name)
	{
		return CallMethod<bool>("has", new object[1] { name });
	}

	public void Set(USVString name, USVString value)
	{
		CallVoidMethod("set", name, value);
	}
}
