namespace Gecko.WebIDL;

public class MozTetheringManager : WebIDLBase
{
	public MozTetheringManager(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise<object> SetTetheringEnabled(bool enabled, TetheringType type)
	{
		return CallMethod<Promise<object>>("setTetheringEnabled", new object[2] { enabled, type });
	}

	public Promise<object> SetTetheringEnabled(bool enabled, TetheringType type, object config)
	{
		return CallMethod<Promise<object>>("setTetheringEnabled", new object[3] { enabled, type, config });
	}
}
