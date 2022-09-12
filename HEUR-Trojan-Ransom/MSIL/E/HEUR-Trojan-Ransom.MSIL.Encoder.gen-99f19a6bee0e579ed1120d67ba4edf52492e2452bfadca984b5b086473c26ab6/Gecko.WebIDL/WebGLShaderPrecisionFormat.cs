namespace Gecko.WebIDL;

public class WebGLShaderPrecisionFormat : WebIDLBase
{
	public int RangeMin => GetProperty<int>("rangeMin");

	public int RangeMax => GetProperty<int>("rangeMax");

	public int Precision => GetProperty<int>("precision");

	public WebGLShaderPrecisionFormat(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
