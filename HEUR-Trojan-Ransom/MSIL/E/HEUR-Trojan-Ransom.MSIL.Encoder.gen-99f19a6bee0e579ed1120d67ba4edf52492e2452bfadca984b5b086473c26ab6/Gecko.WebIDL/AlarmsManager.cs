namespace Gecko.WebIDL;

public class AlarmsManager : WebIDLBase
{
	public AlarmsManager(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports GetAll()
	{
		return CallMethod<nsISupports>("getAll", new object[0]);
	}

	public nsISupports Add(object date, string respectTimezone)
	{
		return CallMethod<nsISupports>("add", new object[2] { date, respectTimezone });
	}

	public nsISupports Add(object date, string respectTimezone, object data)
	{
		return CallMethod<nsISupports>("add", new object[3] { date, respectTimezone, data });
	}

	public void Remove(uint id)
	{
		CallVoidMethod("remove", id);
	}
}
