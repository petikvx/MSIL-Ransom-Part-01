namespace Gecko.WebIDL;

public class WEBGL_draw_buffers : WebIDLBase
{
	public WEBGL_draw_buffers(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void DrawBuffersWEBGL(uint[] buffers)
	{
		CallVoidMethod("drawBuffersWEBGL", buffers);
	}
}
