using System;

namespace Gecko.WebIDL;

public class IDBFileHandle : WebIDLBase
{
	public nsISupports MutableFile => GetProperty<nsISupports>("mutableFile");

	public nsISupports FileHandle => GetProperty<nsISupports>("fileHandle");

	public FileMode Mode => GetProperty<FileMode>("mode");

	public bool Active => GetProperty<bool>("active");

	public ulong? Location
	{
		get
		{
			return GetProperty<ulong?>("location");
		}
		set
		{
			SetProperty("location", value);
		}
	}

	public IDBFileHandle(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports GetMetadata()
	{
		return CallMethod<nsISupports>("getMetadata", new object[0]);
	}

	public nsISupports GetMetadata(object parameters)
	{
		return CallMethod<nsISupports>("getMetadata", new object[1] { parameters });
	}

	public nsISupports ReadAsArrayBuffer(ulong size)
	{
		return CallMethod<nsISupports>("readAsArrayBuffer", new object[1] { size });
	}

	public nsISupports ReadAsText(ulong size)
	{
		return CallMethod<nsISupports>("readAsText", new object[1] { size });
	}

	public nsISupports ReadAsText(ulong size, string encoding)
	{
		return CallMethod<nsISupports>("readAsText", new object[2] { size, encoding });
	}

	public nsISupports Write(WebIDLUnion<string, IntPtr, IntPtr, nsIDOMBlob> value)
	{
		return CallMethod<nsISupports>("write", new object[1] { value });
	}

	public nsISupports Append(WebIDLUnion<string, IntPtr, IntPtr, nsIDOMBlob> value)
	{
		return CallMethod<nsISupports>("append", new object[1] { value });
	}

	public nsISupports Truncate()
	{
		return CallMethod<nsISupports>("truncate", new object[0]);
	}

	public nsISupports Truncate(ulong size)
	{
		return CallMethod<nsISupports>("truncate", new object[1] { size });
	}

	public nsISupports Flush()
	{
		return CallMethod<nsISupports>("flush", new object[0]);
	}

	public void Abort()
	{
		CallVoidMethod("abort");
	}
}
