namespace Gecko.WebIDL;

public class ArchiveReader : WebIDLBase
{
	public ArchiveReader(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports GetFilenames()
	{
		return CallMethod<nsISupports>("getFilenames", new object[0]);
	}

	public nsISupports GetFile(string filename)
	{
		return CallMethod<nsISupports>("getFile", new object[1] { filename });
	}

	public nsISupports GetFiles()
	{
		return CallMethod<nsISupports>("getFiles", new object[0]);
	}
}
