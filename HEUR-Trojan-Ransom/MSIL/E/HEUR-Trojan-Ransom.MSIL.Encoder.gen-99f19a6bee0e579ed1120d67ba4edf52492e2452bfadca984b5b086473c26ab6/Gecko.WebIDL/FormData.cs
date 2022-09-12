namespace Gecko.WebIDL;

public class FormData : WebIDLBase
{
	public FormData(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Append(USVString name, nsIDOMBlob value)
	{
		CallVoidMethod("append", name, value);
	}

	public void Append(USVString name, nsIDOMBlob value, USVString filename)
	{
		CallVoidMethod("append", name, value, filename);
	}

	public void Append(USVString name, USVString value)
	{
		CallVoidMethod("append", name, value);
	}

	public void Delete(USVString name)
	{
		CallVoidMethod("delete", name);
	}

	public WebIDLUnion<nsISupports, USVString> Get(USVString name)
	{
		return CallMethod<WebIDLUnion<nsISupports, USVString>>("get", new object[1] { name });
	}

	public WebIDLUnion<nsISupports, USVString> GetAll(USVString name)
	{
		return CallMethod<WebIDLUnion<nsISupports, USVString>>("getAll", new object[1] { name });
	}

	public bool Has(USVString name)
	{
		return CallMethod<bool>("has", new object[1] { name });
	}

	public void Set(USVString name, nsIDOMBlob value)
	{
		CallVoidMethod("set", name, value);
	}

	public void Set(USVString name, nsIDOMBlob value, USVString filename)
	{
		CallVoidMethod("set", name, value, filename);
	}

	public void Set(USVString name, USVString value)
	{
		CallVoidMethod("set", name, value);
	}
}
