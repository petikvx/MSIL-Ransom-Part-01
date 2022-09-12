namespace Gecko.WebIDL;

public class ScriptProcessorNode : WebIDLBase
{
	public int BufferSize => GetProperty<int>("bufferSize");

	public ScriptProcessorNode(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
