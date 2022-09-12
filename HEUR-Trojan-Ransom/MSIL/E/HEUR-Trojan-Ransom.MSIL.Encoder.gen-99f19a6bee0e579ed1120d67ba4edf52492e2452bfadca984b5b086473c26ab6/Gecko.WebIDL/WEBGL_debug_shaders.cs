namespace Gecko.WebIDL;

public class WEBGL_debug_shaders : WebIDLBase
{
	public WEBGL_debug_shaders(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public string GetTranslatedShaderSource(nsISupports shader)
	{
		return CallMethod<string>("getTranslatedShaderSource", new object[1] { shader });
	}
}
