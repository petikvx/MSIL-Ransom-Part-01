namespace Gecko.WebIDL;

public class XPathEvaluator : WebIDLBase
{
	public XPathEvaluator(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports CreateExpression(string expression, nsISupports resolver)
	{
		return CallMethod<nsISupports>("createExpression", new object[2] { expression, resolver });
	}

	public nsIDOMNode CreateNSResolver(nsIDOMNode nodeResolver)
	{
		return CallMethod<nsIDOMNode>("createNSResolver", new object[1] { nodeResolver });
	}

	public nsISupports Evaluate(string expression, nsIDOMNode contextNode, nsISupports resolver, ushort type, object result)
	{
		return CallMethod<nsISupports>("evaluate", new object[5] { expression, contextNode, resolver, type, result });
	}
}
