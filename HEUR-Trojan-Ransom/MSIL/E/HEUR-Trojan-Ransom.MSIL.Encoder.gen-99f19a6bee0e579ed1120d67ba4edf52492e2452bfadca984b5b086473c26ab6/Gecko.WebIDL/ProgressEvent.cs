namespace Gecko.WebIDL;

public class ProgressEvent : WebIDLBase
{
	public bool LengthComputable => GetProperty<bool>("lengthComputable");

	public ulong Loaded => GetProperty<ulong>("loaded");

	public ulong Total => GetProperty<ulong>("total");

	public ProgressEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
