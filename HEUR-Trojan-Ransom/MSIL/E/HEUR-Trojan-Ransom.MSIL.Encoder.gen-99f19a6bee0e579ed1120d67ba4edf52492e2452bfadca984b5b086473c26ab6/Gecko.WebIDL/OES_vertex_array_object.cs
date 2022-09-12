namespace Gecko.WebIDL;

public class OES_vertex_array_object : WebIDLBase
{
	public OES_vertex_array_object(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports CreateVertexArrayOES()
	{
		return CallMethod<nsISupports>("createVertexArrayOES", new object[0]);
	}

	public void DeleteVertexArrayOES(nsISupports arrayObject)
	{
		CallVoidMethod("deleteVertexArrayOES", arrayObject);
	}

	public bool IsVertexArrayOES(nsISupports arrayObject)
	{
		return CallMethod<bool>("isVertexArrayOES", new object[1] { arrayObject });
	}

	public void BindVertexArrayOES(nsISupports arrayObject)
	{
		CallVoidMethod("bindVertexArrayOES", arrayObject);
	}
}
