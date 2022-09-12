namespace Gecko.WebIDL;

public class Directory : WebIDLBase
{
	public string Name => GetProperty<string>("name");

	public string Path => GetProperty<string>("path");

	public Directory(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise<nsISupports> CreateFile(string path)
	{
		return CallMethod<Promise<nsISupports>>("createFile", new object[1] { path });
	}

	public Promise<nsISupports> CreateFile(string path, object options)
	{
		return CallMethod<Promise<nsISupports>>("createFile", new object[2] { path, options });
	}

	public Promise<nsISupports> CreateDirectory(string path)
	{
		return CallMethod<Promise<nsISupports>>("createDirectory", new object[1] { path });
	}

	public Promise<WebIDLUnion<nsISupports, nsISupports>> Get(string path)
	{
		return CallMethod<Promise<WebIDLUnion<nsISupports, nsISupports>>>("get", new object[1] { path });
	}

	public Promise<bool> Remove(WebIDLUnion<string, nsISupports, nsISupports> path)
	{
		return CallMethod<Promise<bool>>("remove", new object[1] { path });
	}

	public Promise<bool> RemoveDeep(WebIDLUnion<string, nsISupports, nsISupports> path)
	{
		return CallMethod<Promise<bool>>("removeDeep", new object[1] { path });
	}

	public Promise<WebIDLUnion<nsISupports, nsISupports>> GetFilesAndDirectories()
	{
		return CallMethod<Promise<WebIDLUnion<nsISupports, nsISupports>>>("getFilesAndDirectories", new object[0]);
	}
}
