namespace Gecko.WebIDL;

public class FontFaceSet : WebIDLBase
{
	public uint Size => GetProperty<uint>("size");

	public Promise Ready => GetProperty<Promise>("ready");

	public FontFaceSetLoadStatus Status => GetProperty<FontFaceSetLoadStatus>("status");

	public FontFaceSet(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Add(nsISupports font)
	{
		CallVoidMethod("add", font);
	}

	public bool Has(nsISupports font)
	{
		return CallMethod<bool>("has", new object[1] { font });
	}

	public bool Delete(nsISupports font)
	{
		return CallMethod<bool>("delete", new object[1] { font });
	}

	public void Clear()
	{
		CallVoidMethod("clear");
	}

	public nsISupports Entries()
	{
		return CallMethod<nsISupports>("entries", new object[0]);
	}

	public nsISupports Values()
	{
		return CallMethod<nsISupports>("values", new object[0]);
	}

	public Promise<nsISupports[]> Load(string font)
	{
		return CallMethod<Promise<nsISupports[]>>("load", new object[1] { font });
	}

	public Promise<nsISupports[]> Load(string font, string text)
	{
		return CallMethod<Promise<nsISupports[]>>("load", new object[2] { font, text });
	}

	public bool Check(string font)
	{
		return CallMethod<bool>("check", new object[1] { font });
	}

	public bool Check(string font, string text)
	{
		return CallMethod<bool>("check", new object[2] { font, text });
	}
}
