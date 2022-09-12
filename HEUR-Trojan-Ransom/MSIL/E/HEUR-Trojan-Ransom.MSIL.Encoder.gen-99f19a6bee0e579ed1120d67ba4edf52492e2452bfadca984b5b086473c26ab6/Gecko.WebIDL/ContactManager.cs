namespace Gecko.WebIDL;

public class ContactManager : WebIDLBase
{
	public ContactManager(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports Find()
	{
		return CallMethod<nsISupports>("find", new object[0]);
	}

	public nsISupports Find(object options)
	{
		return CallMethod<nsISupports>("find", new object[1] { options });
	}

	public nsISupports GetAll()
	{
		return CallMethod<nsISupports>("getAll", new object[0]);
	}

	public nsISupports GetAll(object options)
	{
		return CallMethod<nsISupports>("getAll", new object[1] { options });
	}

	public nsISupports Clear()
	{
		return CallMethod<nsISupports>("clear", new object[0]);
	}

	public nsISupports Save(nsISupports contact)
	{
		return CallMethod<nsISupports>("save", new object[1] { contact });
	}

	public nsISupports Remove(WebIDLUnion<nsISupports, string> contactOrId)
	{
		return CallMethod<nsISupports>("remove", new object[1] { contactOrId });
	}

	public nsISupports GetRevision()
	{
		return CallMethod<nsISupports>("getRevision", new object[0]);
	}

	public nsISupports GetCount()
	{
		return CallMethod<nsISupports>("getCount", new object[0]);
	}
}
