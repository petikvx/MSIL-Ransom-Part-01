namespace Gecko.WebIDL;

public class XMLSerializer : WebIDLBase
{
	public XMLSerializer(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public string SerializeToString(nsIDOMNode root)
	{
		return CallMethod<string>("serializeToString", new object[1] { root });
	}

	public void SerializeToStream(nsIDOMNode root, nsISupports stream, string charset)
	{
		CallVoidMethod("serializeToStream", root, stream, charset);
	}
}
