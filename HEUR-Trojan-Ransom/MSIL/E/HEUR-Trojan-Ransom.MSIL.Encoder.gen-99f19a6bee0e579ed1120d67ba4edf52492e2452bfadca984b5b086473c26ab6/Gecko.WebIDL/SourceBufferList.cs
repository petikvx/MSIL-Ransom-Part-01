namespace Gecko.WebIDL;

public class SourceBufferList : WebIDLBase
{
	public uint Length => GetProperty<uint>("length");

	public SourceBufferList(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
