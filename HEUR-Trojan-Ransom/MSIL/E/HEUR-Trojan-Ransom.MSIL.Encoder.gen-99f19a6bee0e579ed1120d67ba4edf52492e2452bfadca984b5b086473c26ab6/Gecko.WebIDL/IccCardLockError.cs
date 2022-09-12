namespace Gecko.WebIDL;

public class IccCardLockError : WebIDLBase
{
	public short RetryCount => GetProperty<short>("retryCount");

	public IccCardLockError(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
