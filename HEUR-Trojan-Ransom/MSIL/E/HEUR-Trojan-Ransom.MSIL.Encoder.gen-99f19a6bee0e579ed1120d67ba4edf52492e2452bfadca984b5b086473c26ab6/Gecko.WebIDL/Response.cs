namespace Gecko.WebIDL;

public class Response : WebIDLBase
{
	public ResponseType Type => GetProperty<ResponseType>("type");

	public USVString Url => GetProperty<USVString>("url");

	public ushort Status => GetProperty<ushort>("status");

	public bool Ok => GetProperty<bool>("ok");

	public ByteString StatusText => GetProperty<ByteString>("statusText");

	public nsISupports Headers => GetProperty<nsISupports>("headers");

	public Response(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports Clone()
	{
		return CallMethod<nsISupports>("clone", new object[0]);
	}
}
