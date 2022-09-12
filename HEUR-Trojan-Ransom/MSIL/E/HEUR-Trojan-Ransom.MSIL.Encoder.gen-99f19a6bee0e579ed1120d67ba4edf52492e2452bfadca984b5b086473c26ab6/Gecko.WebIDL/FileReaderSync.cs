using System;

namespace Gecko.WebIDL;

public class FileReaderSync : WebIDLBase
{
	public FileReaderSync(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public IntPtr ReadAsArrayBuffer(nsIDOMBlob blob)
	{
		return CallMethod<IntPtr>("readAsArrayBuffer", new object[1] { blob });
	}

	public string ReadAsBinaryString(nsIDOMBlob blob)
	{
		return CallMethod<string>("readAsBinaryString", new object[1] { blob });
	}

	public string ReadAsText(nsIDOMBlob blob)
	{
		return CallMethod<string>("readAsText", new object[1] { blob });
	}

	public string ReadAsText(nsIDOMBlob blob, string encoding)
	{
		return CallMethod<string>("readAsText", new object[2] { blob, encoding });
	}

	public string ReadAsDataURL(nsIDOMBlob blob)
	{
		return CallMethod<string>("readAsDataURL", new object[1] { blob });
	}
}
