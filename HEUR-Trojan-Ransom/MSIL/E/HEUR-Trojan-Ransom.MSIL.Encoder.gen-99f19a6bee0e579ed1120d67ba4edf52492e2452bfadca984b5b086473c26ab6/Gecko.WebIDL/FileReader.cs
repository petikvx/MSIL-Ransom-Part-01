namespace Gecko.WebIDL;

public class FileReader : WebIDLBase
{
	public ushort ReadyState => GetProperty<ushort>("readyState");

	public object Result => GetProperty<object>("result");

	public nsISupports Error => GetProperty<nsISupports>("error");

	public FileReader(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void ReadAsArrayBuffer(nsIDOMBlob blob)
	{
		CallVoidMethod("readAsArrayBuffer", blob);
	}

	public void ReadAsText(nsIDOMBlob blob)
	{
		CallVoidMethod("readAsText", blob);
	}

	public void ReadAsText(nsIDOMBlob blob, string label)
	{
		CallVoidMethod("readAsText", blob, label);
	}

	public void ReadAsDataURL(nsIDOMBlob blob)
	{
		CallVoidMethod("readAsDataURL", blob);
	}

	public void Abort()
	{
		CallVoidMethod("abort");
	}

	public void ReadAsBinaryString(nsIDOMBlob filedata)
	{
		CallVoidMethod("readAsBinaryString", filedata);
	}
}
