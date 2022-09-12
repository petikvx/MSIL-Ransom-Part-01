namespace Gecko.WebIDL;

public class FileList : WebIDLBase
{
	public uint Length => GetProperty<uint>("length");

	public FileList(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
