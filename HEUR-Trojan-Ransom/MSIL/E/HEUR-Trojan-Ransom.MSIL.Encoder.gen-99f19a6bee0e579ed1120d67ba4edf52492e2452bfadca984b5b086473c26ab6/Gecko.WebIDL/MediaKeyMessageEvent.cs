using System;

namespace Gecko.WebIDL;

public class MediaKeyMessageEvent : WebIDLBase
{
	public MediaKeyMessageType MessageType => GetProperty<MediaKeyMessageType>("messageType");

	public IntPtr Message => GetProperty<IntPtr>("message");

	public MediaKeyMessageEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
