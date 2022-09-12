namespace Gecko.WebIDL;

public class XPathExpression : WebIDLBase
{
	public XPathExpression(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports Evaluate(nsIDOMNode contextNode, ushort type, object result)
	{
		return CallMethod<nsISupports>("evaluate", new object[3] { contextNode, type, result });
	}

	public nsISupports EvaluateWithContext(nsIDOMNode contextNode, uint contextPosition, uint contextSize, ushort type, object result)
	{
		return CallMethod<nsISupports>("evaluateWithContext", new object[5] { contextNode, contextPosition, contextSize, type, result });
	}
}
