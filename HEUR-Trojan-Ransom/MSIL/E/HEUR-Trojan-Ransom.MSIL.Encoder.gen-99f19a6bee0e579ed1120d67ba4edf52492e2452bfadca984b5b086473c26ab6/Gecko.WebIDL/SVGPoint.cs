namespace Gecko.WebIDL;

public class SVGPoint : WebIDLBase
{
	public float X
	{
		get
		{
			return GetProperty<float>("x");
		}
		set
		{
			SetProperty("x", value);
		}
	}

	public float Y
	{
		get
		{
			return GetProperty<float>("y");
		}
		set
		{
			SetProperty("y", value);
		}
	}

	public SVGPoint(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports MatrixTransform(nsISupports matrix)
	{
		return CallMethod<nsISupports>("matrixTransform", new object[1] { matrix });
	}
}
