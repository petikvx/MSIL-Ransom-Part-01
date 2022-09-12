namespace Gecko.WebIDL;

public class WindowTimers : WebIDLBase
{
	public WindowTimers(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public int SetTimeout(string handler)
	{
		return CallMethod<int>("setTimeout", new object[1] { handler });
	}

	public int SetTimeout(string handler, int timeout)
	{
		return CallMethod<int>("setTimeout", new object[2] { handler, timeout });
	}

	public int SetTimeout(string handler, int timeout, object unused)
	{
		return CallMethod<int>("setTimeout", new object[3] { handler, timeout, unused });
	}

	public void ClearTimeout()
	{
		CallVoidMethod("clearTimeout");
	}

	public void ClearTimeout(int handle)
	{
		CallVoidMethod("clearTimeout", handle);
	}

	public int SetInterval(string handler)
	{
		return CallMethod<int>("setInterval", new object[1] { handler });
	}

	public int SetInterval(string handler, int timeout)
	{
		return CallMethod<int>("setInterval", new object[2] { handler, timeout });
	}

	public int SetInterval(string handler, int timeout, object unused)
	{
		return CallMethod<int>("setInterval", new object[3] { handler, timeout, unused });
	}

	public void ClearInterval()
	{
		CallVoidMethod("clearInterval");
	}

	public void ClearInterval(int handle)
	{
		CallVoidMethod("clearInterval", handle);
	}
}
