using System;

namespace Gecko.WebIDL;

public class MediaEncryptedEvent : WebIDLBase
{
	public string InitDataType => GetProperty<string>("initDataType");

	public IntPtr InitData => GetProperty<IntPtr>("initData");

	public MediaEncryptedEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
