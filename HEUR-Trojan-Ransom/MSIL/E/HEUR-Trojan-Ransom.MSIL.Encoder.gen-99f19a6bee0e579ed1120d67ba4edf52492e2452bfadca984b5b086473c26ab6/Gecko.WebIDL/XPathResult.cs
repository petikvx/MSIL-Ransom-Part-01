namespace Gecko.WebIDL;

public class XPathResult : WebIDLBase
{
	public ushort ResultType => GetProperty<ushort>("resultType");

	public double NumberValue => GetProperty<double>("numberValue");

	public string StringValue => GetProperty<string>("stringValue");

	public bool BooleanValue => GetProperty<bool>("booleanValue");

	public nsIDOMNode SingleNodeValue => GetProperty<nsIDOMNode>("singleNodeValue");

	public bool InvalidIteratorState => GetProperty<bool>("invalidIteratorState");

	public uint SnapshotLength => GetProperty<uint>("snapshotLength");

	public XPathResult(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsIDOMNode IterateNext()
	{
		return CallMethod<nsIDOMNode>("iterateNext", new object[0]);
	}

	public nsIDOMNode SnapshotItem(uint index)
	{
		return CallMethod<nsIDOMNode>("snapshotItem", new object[1] { index });
	}
}
