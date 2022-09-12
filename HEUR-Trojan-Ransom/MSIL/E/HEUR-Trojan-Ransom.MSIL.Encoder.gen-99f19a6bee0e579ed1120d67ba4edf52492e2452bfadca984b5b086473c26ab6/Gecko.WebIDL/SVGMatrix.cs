namespace Gecko.WebIDL;

public class SVGMatrix : WebIDLBase
{
	public float A
	{
		get
		{
			return GetProperty<float>("a");
		}
		set
		{
			SetProperty("a", value);
		}
	}

	public float B
	{
		get
		{
			return GetProperty<float>("b");
		}
		set
		{
			SetProperty("b", value);
		}
	}

	public float C
	{
		get
		{
			return GetProperty<float>("c");
		}
		set
		{
			SetProperty("c", value);
		}
	}

	public float D
	{
		get
		{
			return GetProperty<float>("d");
		}
		set
		{
			SetProperty("d", value);
		}
	}

	public float E
	{
		get
		{
			return GetProperty<float>("e");
		}
		set
		{
			SetProperty("e", value);
		}
	}

	public float F
	{
		get
		{
			return GetProperty<float>("f");
		}
		set
		{
			SetProperty("f", value);
		}
	}

	public SVGMatrix(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports Multiply(nsISupports secondMatrix)
	{
		return CallMethod<nsISupports>("multiply", new object[1] { secondMatrix });
	}

	public nsISupports Inverse()
	{
		return CallMethod<nsISupports>("inverse", new object[0]);
	}

	public nsISupports Translate(float x, float y)
	{
		return CallMethod<nsISupports>("translate", new object[2] { x, y });
	}

	public nsISupports Scale(float scaleFactor)
	{
		return CallMethod<nsISupports>("scale", new object[1] { scaleFactor });
	}

	public nsISupports ScaleNonUniform(float scaleFactorX, float scaleFactorY)
	{
		return CallMethod<nsISupports>("scaleNonUniform", new object[2] { scaleFactorX, scaleFactorY });
	}

	public nsISupports Rotate(float angle)
	{
		return CallMethod<nsISupports>("rotate", new object[1] { angle });
	}

	public nsISupports RotateFromVector(float x, float y)
	{
		return CallMethod<nsISupports>("rotateFromVector", new object[2] { x, y });
	}

	public nsISupports FlipX()
	{
		return CallMethod<nsISupports>("flipX", new object[0]);
	}

	public nsISupports FlipY()
	{
		return CallMethod<nsISupports>("flipY", new object[0]);
	}

	public nsISupports SkewX(float angle)
	{
		return CallMethod<nsISupports>("skewX", new object[1] { angle });
	}

	public nsISupports SkewY(float angle)
	{
		return CallMethod<nsISupports>("skewY", new object[1] { angle });
	}
}
