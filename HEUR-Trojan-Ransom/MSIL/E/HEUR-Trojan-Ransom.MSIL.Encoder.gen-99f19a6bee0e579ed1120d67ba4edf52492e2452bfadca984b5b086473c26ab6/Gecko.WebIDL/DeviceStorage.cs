namespace Gecko.WebIDL;

public class DeviceStorage : WebIDLBase
{
	public string StorageName => GetProperty<string>("storageName");

	public bool CanBeMounted => GetProperty<bool>("canBeMounted");

	public bool CanBeShared => GetProperty<bool>("canBeShared");

	public bool CanBeFormatted => GetProperty<bool>("canBeFormatted");

	public bool Default => GetProperty<bool>("default");

	public bool IsRemovable => GetProperty<bool>("isRemovable");

	public bool LowDiskSpace => GetProperty<bool>("lowDiskSpace");

	public DeviceStorage(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports Add(nsIDOMBlob aBlob)
	{
		return CallMethod<nsISupports>("add", new object[1] { aBlob });
	}

	public nsISupports AddNamed(nsIDOMBlob aBlob, string aName)
	{
		return CallMethod<nsISupports>("addNamed", new object[2] { aBlob, aName });
	}

	public nsISupports AppendNamed(nsIDOMBlob aBlob, string aName)
	{
		return CallMethod<nsISupports>("appendNamed", new object[2] { aBlob, aName });
	}

	public nsISupports Get(string aName)
	{
		return CallMethod<nsISupports>("get", new object[1] { aName });
	}

	public nsISupports GetEditable(string aName)
	{
		return CallMethod<nsISupports>("getEditable", new object[1] { aName });
	}

	public nsISupports Delete(string aName)
	{
		return CallMethod<nsISupports>("delete", new object[1] { aName });
	}

	public nsISupports Enumerate()
	{
		return CallMethod<nsISupports>("enumerate", new object[0]);
	}

	public nsISupports Enumerate(object options)
	{
		return CallMethod<nsISupports>("enumerate", new object[1] { options });
	}

	public nsISupports Enumerate(string path)
	{
		return CallMethod<nsISupports>("enumerate", new object[1] { path });
	}

	public nsISupports Enumerate(string path, object options)
	{
		return CallMethod<nsISupports>("enumerate", new object[2] { path, options });
	}

	public nsISupports EnumerateEditable()
	{
		return CallMethod<nsISupports>("enumerateEditable", new object[0]);
	}

	public nsISupports EnumerateEditable(object options)
	{
		return CallMethod<nsISupports>("enumerateEditable", new object[1] { options });
	}

	public nsISupports EnumerateEditable(string path)
	{
		return CallMethod<nsISupports>("enumerateEditable", new object[1] { path });
	}

	public nsISupports EnumerateEditable(string path, object options)
	{
		return CallMethod<nsISupports>("enumerateEditable", new object[2] { path, options });
	}

	public nsISupports FreeSpace()
	{
		return CallMethod<nsISupports>("freeSpace", new object[0]);
	}

	public nsISupports UsedSpace()
	{
		return CallMethod<nsISupports>("usedSpace", new object[0]);
	}

	public nsISupports Available()
	{
		return CallMethod<nsISupports>("available", new object[0]);
	}

	public nsISupports StorageStatus()
	{
		return CallMethod<nsISupports>("storageStatus", new object[0]);
	}

	public nsISupports Format()
	{
		return CallMethod<nsISupports>("format", new object[0]);
	}

	public nsISupports Mount()
	{
		return CallMethod<nsISupports>("mount", new object[0]);
	}

	public nsISupports Unmount()
	{
		return CallMethod<nsISupports>("unmount", new object[0]);
	}

	public Promise<object> GetRoot()
	{
		return CallMethod<Promise<object>>("getRoot", new object[0]);
	}
}
