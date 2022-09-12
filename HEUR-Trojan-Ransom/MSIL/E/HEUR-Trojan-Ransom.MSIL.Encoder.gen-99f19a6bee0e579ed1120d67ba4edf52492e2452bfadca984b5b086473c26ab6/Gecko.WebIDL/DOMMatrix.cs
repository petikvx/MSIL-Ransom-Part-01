namespace Gecko.WebIDL;

public class DOMMatrix : WebIDLBase
{
	public double A
	{
		get
		{
			return GetProperty<double>("a");
		}
		set
		{
			SetProperty("a", value);
		}
	}

	public double B
	{
		get
		{
			return GetProperty<double>("b");
		}
		set
		{
			SetProperty("b", value);
		}
	}

	public double C
	{
		get
		{
			return GetProperty<double>("c");
		}
		set
		{
			SetProperty("c", value);
		}
	}

	public double D
	{
		get
		{
			return GetProperty<double>("d");
		}
		set
		{
			SetProperty("d", value);
		}
	}

	public double E
	{
		get
		{
			return GetProperty<double>("e");
		}
		set
		{
			SetProperty("e", value);
		}
	}

	public double F
	{
		get
		{
			return GetProperty<double>("f");
		}
		set
		{
			SetProperty("f", value);
		}
	}

	public double M11
	{
		get
		{
			return GetProperty<double>("m11");
		}
		set
		{
			SetProperty("m11", value);
		}
	}

	public double M12
	{
		get
		{
			return GetProperty<double>("m12");
		}
		set
		{
			SetProperty("m12", value);
		}
	}

	public double M13
	{
		get
		{
			return GetProperty<double>("m13");
		}
		set
		{
			SetProperty("m13", value);
		}
	}

	public double M14
	{
		get
		{
			return GetProperty<double>("m14");
		}
		set
		{
			SetProperty("m14", value);
		}
	}

	public double M21
	{
		get
		{
			return GetProperty<double>("m21");
		}
		set
		{
			SetProperty("m21", value);
		}
	}

	public double M22
	{
		get
		{
			return GetProperty<double>("m22");
		}
		set
		{
			SetProperty("m22", value);
		}
	}

	public double M23
	{
		get
		{
			return GetProperty<double>("m23");
		}
		set
		{
			SetProperty("m23", value);
		}
	}

	public double M24
	{
		get
		{
			return GetProperty<double>("m24");
		}
		set
		{
			SetProperty("m24", value);
		}
	}

	public double M31
	{
		get
		{
			return GetProperty<double>("m31");
		}
		set
		{
			SetProperty("m31", value);
		}
	}

	public double M32
	{
		get
		{
			return GetProperty<double>("m32");
		}
		set
		{
			SetProperty("m32", value);
		}
	}

	public double M33
	{
		get
		{
			return GetProperty<double>("m33");
		}
		set
		{
			SetProperty("m33", value);
		}
	}

	public double M34
	{
		get
		{
			return GetProperty<double>("m34");
		}
		set
		{
			SetProperty("m34", value);
		}
	}

	public double M41
	{
		get
		{
			return GetProperty<double>("m41");
		}
		set
		{
			SetProperty("m41", value);
		}
	}

	public double M42
	{
		get
		{
			return GetProperty<double>("m42");
		}
		set
		{
			SetProperty("m42", value);
		}
	}

	public double M43
	{
		get
		{
			return GetProperty<double>("m43");
		}
		set
		{
			SetProperty("m43", value);
		}
	}

	public double M44
	{
		get
		{
			return GetProperty<double>("m44");
		}
		set
		{
			SetProperty("m44", value);
		}
	}

	public DOMMatrix(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports MultiplySelf(nsISupports other)
	{
		return CallMethod<nsISupports>("multiplySelf", new object[1] { other });
	}

	public nsISupports PreMultiplySelf(nsISupports other)
	{
		return CallMethod<nsISupports>("preMultiplySelf", new object[1] { other });
	}

	public nsISupports TranslateSelf(double tx, double ty)
	{
		return CallMethod<nsISupports>("translateSelf", new object[2] { tx, ty });
	}

	public nsISupports TranslateSelf(double tx, double ty, double tz)
	{
		return CallMethod<nsISupports>("translateSelf", new object[3] { tx, ty, tz });
	}

	public nsISupports ScaleSelf(double scale)
	{
		return CallMethod<nsISupports>("scaleSelf", new object[1] { scale });
	}

	public nsISupports ScaleSelf(double scale, double originX)
	{
		return CallMethod<nsISupports>("scaleSelf", new object[2] { scale, originX });
	}

	public nsISupports ScaleSelf(double scale, double originX, double originY)
	{
		return CallMethod<nsISupports>("scaleSelf", new object[3] { scale, originX, originY });
	}

	public nsISupports Scale3dSelf(double scale)
	{
		return CallMethod<nsISupports>("scale3dSelf", new object[1] { scale });
	}

	public nsISupports Scale3dSelf(double scale, double originX)
	{
		return CallMethod<nsISupports>("scale3dSelf", new object[2] { scale, originX });
	}

	public nsISupports Scale3dSelf(double scale, double originX, double originY)
	{
		return CallMethod<nsISupports>("scale3dSelf", new object[3] { scale, originX, originY });
	}

	public nsISupports Scale3dSelf(double scale, double originX, double originY, double originZ)
	{
		return CallMethod<nsISupports>("scale3dSelf", new object[4] { scale, originX, originY, originZ });
	}

	public nsISupports ScaleNonUniformSelf(double scaleX)
	{
		return CallMethod<nsISupports>("scaleNonUniformSelf", new object[1] { scaleX });
	}

	public nsISupports ScaleNonUniformSelf(double scaleX, double scaleY)
	{
		return CallMethod<nsISupports>("scaleNonUniformSelf", new object[2] { scaleX, scaleY });
	}

	public nsISupports ScaleNonUniformSelf(double scaleX, double scaleY, double scaleZ)
	{
		return CallMethod<nsISupports>("scaleNonUniformSelf", new object[3] { scaleX, scaleY, scaleZ });
	}

	public nsISupports ScaleNonUniformSelf(double scaleX, double scaleY, double scaleZ, double originX)
	{
		return CallMethod<nsISupports>("scaleNonUniformSelf", new object[4] { scaleX, scaleY, scaleZ, originX });
	}

	public nsISupports ScaleNonUniformSelf(double scaleX, double scaleY, double scaleZ, double originX, double originY)
	{
		return CallMethod<nsISupports>("scaleNonUniformSelf", new object[5] { scaleX, scaleY, scaleZ, originX, originY });
	}

	public nsISupports ScaleNonUniformSelf(double scaleX, double scaleY, double scaleZ, double originX, double originY, double originZ)
	{
		return CallMethod<nsISupports>("scaleNonUniformSelf", new object[6] { scaleX, scaleY, scaleZ, originX, originY, originZ });
	}

	public nsISupports RotateSelf(double angle)
	{
		return CallMethod<nsISupports>("rotateSelf", new object[1] { angle });
	}

	public nsISupports RotateSelf(double angle, double originX)
	{
		return CallMethod<nsISupports>("rotateSelf", new object[2] { angle, originX });
	}

	public nsISupports RotateSelf(double angle, double originX, double originY)
	{
		return CallMethod<nsISupports>("rotateSelf", new object[3] { angle, originX, originY });
	}

	public nsISupports RotateFromVectorSelf(double x, double y)
	{
		return CallMethod<nsISupports>("rotateFromVectorSelf", new object[2] { x, y });
	}

	public nsISupports RotateAxisAngleSelf(double x, double y, double z, double angle)
	{
		return CallMethod<nsISupports>("rotateAxisAngleSelf", new object[4] { x, y, z, angle });
	}

	public nsISupports SkewXSelf(double sx)
	{
		return CallMethod<nsISupports>("skewXSelf", new object[1] { sx });
	}

	public nsISupports SkewYSelf(double sy)
	{
		return CallMethod<nsISupports>("skewYSelf", new object[1] { sy });
	}

	public nsISupports InvertSelf()
	{
		return CallMethod<nsISupports>("invertSelf", new object[0]);
	}

	public nsISupports SetMatrixValue(string transformList)
	{
		return CallMethod<nsISupports>("setMatrixValue", new object[1] { transformList });
	}
}
