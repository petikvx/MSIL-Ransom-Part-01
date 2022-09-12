namespace Gecko.WebIDL;

public class Blob : WebIDLBase
{
	public ulong Size => GetProperty<ulong>("size");

	public string Type => GetProperty<string>("type");

	public Blob(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsIDOMBlob Slice()
	{
		return CallMethod<nsIDOMBlob>("slice", new object[0]);
	}

	public nsIDOMBlob Slice(long start)
	{
		return CallMethod<nsIDOMBlob>("slice", new object[1] { start });
	}

	public nsIDOMBlob Slice(long start, long end)
	{
		return CallMethod<nsIDOMBlob>("slice", new object[2] { start, end });
	}

	public nsIDOMBlob Slice(long start, long end, string contentType)
	{
		return CallMethod<nsIDOMBlob>("slice", new object[3] { start, end, contentType });
	}
}
