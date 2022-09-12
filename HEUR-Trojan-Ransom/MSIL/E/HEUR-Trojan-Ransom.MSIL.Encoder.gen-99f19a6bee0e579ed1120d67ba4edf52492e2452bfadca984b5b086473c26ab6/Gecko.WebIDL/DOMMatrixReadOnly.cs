using System;

namespace Gecko.WebIDL;

public class DOMMatrixReadOnly : WebIDLBase
{
	public double A => GetProperty<double>("a");

	public double B => GetProperty<double>("b");

	public double C => GetProperty<double>("c");

	public double D => GetProperty<double>("d");

	public double E => GetProperty<double>("e");

	public double F => GetProperty<double>("f");

	public double M11 => GetProperty<double>("m11");

	public double M12 => GetProperty<double>("m12");

	public double M13 => GetProperty<double>("m13");

	public double M14 => GetProperty<double>("m14");

	public double M21 => GetProperty<double>("m21");

	public double M22 => GetProperty<double>("m22");

	public double M23 => GetProperty<double>("m23");

	public double M24 => GetProperty<double>("m24");

	public double M31 => GetProperty<double>("m31");

	public double M32 => GetProperty<double>("m32");

	public double M33 => GetProperty<double>("m33");

	public double M34 => GetProperty<double>("m34");

	public double M41 => GetProperty<double>("m41");

	public double M42 => GetProperty<double>("m42");

	public double M43 => GetProperty<double>("m43");

	public double M44 => GetProperty<double>("m44");

	public bool Is2D => GetProperty<bool>("is2D");

	public bool Identity => GetProperty<bool>("identity");

	public DOMMatrixReadOnly(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports Translate(double tx, double ty)
	{
		return CallMethod<nsISupports>("translate", new object[2] { tx, ty });
	}

	public nsISupports Translate(double tx, double ty, double tz)
	{
		return CallMethod<nsISupports>("translate", new object[3] { tx, ty, tz });
	}

	public nsISupports Scale(double scale)
	{
		return CallMethod<nsISupports>("scale", new object[1] { scale });
	}

	public nsISupports Scale(double scale, double originX)
	{
		return CallMethod<nsISupports>("scale", new object[2] { scale, originX });
	}

	public nsISupports Scale(double scale, double originX, double originY)
	{
		return CallMethod<nsISupports>("scale", new object[3] { scale, originX, originY });
	}

	public nsISupports Scale3d(double scale)
	{
		return CallMethod<nsISupports>("scale3d", new object[1] { scale });
	}

	public nsISupports Scale3d(double scale, double originX)
	{
		return CallMethod<nsISupports>("scale3d", new object[2] { scale, originX });
	}

	public nsISupports Scale3d(double scale, double originX, double originY)
	{
		return CallMethod<nsISupports>("scale3d", new object[3] { scale, originX, originY });
	}

	public nsISupports Scale3d(double scale, double originX, double originY, double originZ)
	{
		return CallMethod<nsISupports>("scale3d", new object[4] { scale, originX, originY, originZ });
	}

	public nsISupports ScaleNonUniform(double scaleX)
	{
		return CallMethod<nsISupports>("scaleNonUniform", new object[1] { scaleX });
	}

	public nsISupports ScaleNonUniform(double scaleX, double scaleY)
	{
		return CallMethod<nsISupports>("scaleNonUniform", new object[2] { scaleX, scaleY });
	}

	public nsISupports ScaleNonUniform(double scaleX, double scaleY, double scaleZ)
	{
		return CallMethod<nsISupports>("scaleNonUniform", new object[3] { scaleX, scaleY, scaleZ });
	}

	public nsISupports ScaleNonUniform(double scaleX, double scaleY, double scaleZ, double originX)
	{
		return CallMethod<nsISupports>("scaleNonUniform", new object[4] { scaleX, scaleY, scaleZ, originX });
	}

	public nsISupports ScaleNonUniform(double scaleX, double scaleY, double scaleZ, double originX, double originY)
	{
		return CallMethod<nsISupports>("scaleNonUniform", new object[5] { scaleX, scaleY, scaleZ, originX, originY });
	}

	public nsISupports ScaleNonUniform(double scaleX, double scaleY, double scaleZ, double originX, double originY, double originZ)
	{
		return CallMethod<nsISupports>("scaleNonUniform", new object[6] { scaleX, scaleY, scaleZ, originX, originY, originZ });
	}

	public nsISupports Rotate(double angle)
	{
		return CallMethod<nsISupports>("rotate", new object[1] { angle });
	}

	public nsISupports Rotate(double angle, double originX)
	{
		return CallMethod<nsISupports>("rotate", new object[2] { angle, originX });
	}

	public nsISupports Rotate(double angle, double originX, double originY)
	{
		return CallMethod<nsISupports>("rotate", new object[3] { angle, originX, originY });
	}

	public nsISupports RotateFromVector(double x, double y)
	{
		return CallMethod<nsISupports>("rotateFromVector", new object[2] { x, y });
	}

	public nsISupports RotateAxisAngle(double x, double y, double z, double angle)
	{
		return CallMethod<nsISupports>("rotateAxisAngle", new object[4] { x, y, z, angle });
	}

	public nsISupports SkewX(double sx)
	{
		return CallMethod<nsISupports>("skewX", new object[1] { sx });
	}

	public nsISupports SkewY(double sy)
	{
		return CallMethod<nsISupports>("skewY", new object[1] { sy });
	}

	public nsISupports Multiply(nsISupports other)
	{
		return CallMethod<nsISupports>("multiply", new object[1] { other });
	}

	public nsISupports FlipX()
	{
		return CallMethod<nsISupports>("flipX", new object[0]);
	}

	public nsISupports FlipY()
	{
		return CallMethod<nsISupports>("flipY", new object[0]);
	}

	public nsISupports Inverse()
	{
		return CallMethod<nsISupports>("inverse", new object[0]);
	}

	public nsISupports TransformPoint()
	{
		return CallMethod<nsISupports>("transformPoint", new object[0]);
	}

	public nsISupports TransformPoint(object point)
	{
		return CallMethod<nsISupports>("transformPoint", new object[1] { point });
	}

	public IntPtr ToFloat32Array()
	{
		return CallMethod<IntPtr>("toFloat32Array", new object[0]);
	}

	public IntPtr ToFloat64Array()
	{
		return CallMethod<IntPtr>("toFloat64Array", new object[0]);
	}
}
