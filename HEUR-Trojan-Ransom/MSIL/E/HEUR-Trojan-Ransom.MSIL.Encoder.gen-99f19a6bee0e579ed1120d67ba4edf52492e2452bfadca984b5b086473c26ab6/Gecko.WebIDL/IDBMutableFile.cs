namespace Gecko.WebIDL;

public class IDBMutableFile : WebIDLBase
{
	public string Name => GetProperty<string>("name");

	public string Type => GetProperty<string>("type");

	public nsISupports Database => GetProperty<nsISupports>("database");

	public IDBMutableFile(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports Open()
	{
		return CallMethod<nsISupports>("open", new object[0]);
	}

	public nsISupports Open(FileMode mode)
	{
		return CallMethod<nsISupports>("open", new object[1] { mode });
	}

	public nsISupports GetFile()
	{
		return CallMethod<nsISupports>("getFile", new object[0]);
	}
}
