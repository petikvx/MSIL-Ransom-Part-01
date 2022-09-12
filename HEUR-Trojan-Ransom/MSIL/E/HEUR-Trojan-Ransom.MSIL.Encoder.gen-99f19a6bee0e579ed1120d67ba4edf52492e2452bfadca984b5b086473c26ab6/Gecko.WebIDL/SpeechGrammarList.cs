namespace Gecko.WebIDL;

public class SpeechGrammarList : WebIDLBase
{
	public uint Length => GetProperty<uint>("length");

	public SpeechGrammarList(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void AddFromURI(string src)
	{
		CallVoidMethod("addFromURI", src);
	}

	public void AddFromURI(string src, float weight)
	{
		CallVoidMethod("addFromURI", src, weight);
	}

	public void AddFromString(string @string)
	{
		CallVoidMethod("addFromString", @string);
	}

	public void AddFromString(string @string, float weight)
	{
		CallVoidMethod("addFromString", @string, weight);
	}
}
