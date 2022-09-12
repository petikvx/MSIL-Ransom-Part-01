namespace Gecko.WebIDL;

public class SVGTransform : WebIDLBase
{
	public ushort Type => GetProperty<ushort>("type");

	public nsISupports Matrix => GetProperty<nsISupports>("matrix");

	public float Angle => GetProperty<float>("angle");

	public SVGTransform(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void SetMatrix(nsISupports matrix)
	{
		CallVoidMethod("setMatrix", matrix);
	}

	public void SetTranslate(float tx, float ty)
	{
		CallVoidMethod("setTranslate", tx, ty);
	}

	public void SetScale(float sx, float sy)
	{
		CallVoidMethod("setScale", sx, sy);
	}

	public void SetRotate(float angle, float cx, float cy)
	{
		CallVoidMethod("setRotate", angle, cx, cy);
	}

	public void SetSkewX(float angle)
	{
		CallVoidMethod("setSkewX", angle);
	}

	public void SetSkewY(float angle)
	{
		CallVoidMethod("setSkewY", angle);
	}
}
