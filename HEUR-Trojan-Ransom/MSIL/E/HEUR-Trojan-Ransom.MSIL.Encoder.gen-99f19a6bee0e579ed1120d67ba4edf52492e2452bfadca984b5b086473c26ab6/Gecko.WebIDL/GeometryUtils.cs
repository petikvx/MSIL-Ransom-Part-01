namespace Gecko.WebIDL;

public class GeometryUtils : WebIDLBase
{
	public GeometryUtils(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports[] GetBoxQuads()
	{
		return CallMethod<nsISupports[]>("getBoxQuads", new object[0]);
	}

	public nsISupports[] GetBoxQuads(object options)
	{
		return CallMethod<nsISupports[]>("getBoxQuads", new object[1] { options });
	}

	public nsISupports ConvertQuadFromNode(nsISupports quad, WebIDLUnion<nsIDOMText, nsIDOMElement, nsIDOMDocument> from)
	{
		return CallMethod<nsISupports>("convertQuadFromNode", new object[2] { quad, from });
	}

	public nsISupports ConvertQuadFromNode(nsISupports quad, WebIDLUnion<nsIDOMText, nsIDOMElement, nsIDOMDocument> from, object options)
	{
		return CallMethod<nsISupports>("convertQuadFromNode", new object[3] { quad, from, options });
	}

	public nsISupports ConvertRectFromNode(nsISupports rect, WebIDLUnion<nsIDOMText, nsIDOMElement, nsIDOMDocument> from)
	{
		return CallMethod<nsISupports>("convertRectFromNode", new object[2] { rect, from });
	}

	public nsISupports ConvertRectFromNode(nsISupports rect, WebIDLUnion<nsIDOMText, nsIDOMElement, nsIDOMDocument> from, object options)
	{
		return CallMethod<nsISupports>("convertRectFromNode", new object[3] { rect, from, options });
	}

	public nsISupports ConvertPointFromNode(object point, WebIDLUnion<nsIDOMText, nsIDOMElement, nsIDOMDocument> from)
	{
		return CallMethod<nsISupports>("convertPointFromNode", new object[2] { point, from });
	}

	public nsISupports ConvertPointFromNode(object point, WebIDLUnion<nsIDOMText, nsIDOMElement, nsIDOMDocument> from, object options)
	{
		return CallMethod<nsISupports>("convertPointFromNode", new object[3] { point, from, options });
	}
}
