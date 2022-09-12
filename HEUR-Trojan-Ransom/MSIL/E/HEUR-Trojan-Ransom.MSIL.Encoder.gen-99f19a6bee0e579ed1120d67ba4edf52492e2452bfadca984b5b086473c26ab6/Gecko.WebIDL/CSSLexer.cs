namespace Gecko.WebIDL;

public class CSSLexer : WebIDLBase
{
	public uint LineNumber => GetProperty<uint>("lineNumber");

	public uint ColumnNumber => GetProperty<uint>("columnNumber");

	public CSSLexer(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public string PerformEOFFixup(string inputString, bool preserveBackslash)
	{
		return CallMethod<string>("performEOFFixup", new object[2] { inputString, preserveBackslash });
	}

	public object NextToken()
	{
		return CallMethod<object>("nextToken", new object[0]);
	}
}
