using System;

namespace Gecko.WebIDL;

public class MozTimeManager : WebIDLBase
{
	public MozTimeManager(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Set(IntPtr time)
	{
		CallVoidMethod("set", time);
	}

	public void Set(double time)
	{
		CallVoidMethod("set", time);
	}
}
