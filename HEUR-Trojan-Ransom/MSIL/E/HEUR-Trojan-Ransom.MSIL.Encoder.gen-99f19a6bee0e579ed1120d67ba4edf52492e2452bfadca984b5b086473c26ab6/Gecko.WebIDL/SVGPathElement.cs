namespace Gecko.WebIDL;

public class SVGPathElement : WebIDLBase
{
	public nsISupports PathLength => GetProperty<nsISupports>("pathLength");

	public SVGPathElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public float GetTotalLength()
	{
		return CallMethod<float>("getTotalLength", new object[0]);
	}

	public nsISupports GetPointAtLength(float distance)
	{
		return CallMethod<nsISupports>("getPointAtLength", new object[1] { distance });
	}

	public uint GetPathSegAtLength(float distance)
	{
		return CallMethod<uint>("getPathSegAtLength", new object[1] { distance });
	}

	public nsISupports CreateSVGPathSegClosePath()
	{
		return CallMethod<nsISupports>("createSVGPathSegClosePath", new object[0]);
	}

	public nsISupports CreateSVGPathSegMovetoAbs(float x, float y)
	{
		return CallMethod<nsISupports>("createSVGPathSegMovetoAbs", new object[2] { x, y });
	}

	public nsISupports CreateSVGPathSegMovetoRel(float x, float y)
	{
		return CallMethod<nsISupports>("createSVGPathSegMovetoRel", new object[2] { x, y });
	}

	public nsISupports CreateSVGPathSegLinetoAbs(float x, float y)
	{
		return CallMethod<nsISupports>("createSVGPathSegLinetoAbs", new object[2] { x, y });
	}

	public nsISupports CreateSVGPathSegLinetoRel(float x, float y)
	{
		return CallMethod<nsISupports>("createSVGPathSegLinetoRel", new object[2] { x, y });
	}

	public nsISupports CreateSVGPathSegCurvetoCubicAbs(float x, float y, float x1, float y1, float x2, float y2)
	{
		return CallMethod<nsISupports>("createSVGPathSegCurvetoCubicAbs", new object[6] { x, y, x1, y1, x2, y2 });
	}

	public nsISupports CreateSVGPathSegCurvetoCubicRel(float x, float y, float x1, float y1, float x2, float y2)
	{
		return CallMethod<nsISupports>("createSVGPathSegCurvetoCubicRel", new object[6] { x, y, x1, y1, x2, y2 });
	}

	public nsISupports CreateSVGPathSegCurvetoQuadraticAbs(float x, float y, float x1, float y1)
	{
		return CallMethod<nsISupports>("createSVGPathSegCurvetoQuadraticAbs", new object[4] { x, y, x1, y1 });
	}

	public nsISupports CreateSVGPathSegCurvetoQuadraticRel(float x, float y, float x1, float y1)
	{
		return CallMethod<nsISupports>("createSVGPathSegCurvetoQuadraticRel", new object[4] { x, y, x1, y1 });
	}

	public nsISupports CreateSVGPathSegArcAbs(float x, float y, float r1, float r2, float angle, bool largeArcFlag, bool sweepFlag)
	{
		return CallMethod<nsISupports>("createSVGPathSegArcAbs", new object[7] { x, y, r1, r2, angle, largeArcFlag, sweepFlag });
	}

	public nsISupports CreateSVGPathSegArcRel(float x, float y, float r1, float r2, float angle, bool largeArcFlag, bool sweepFlag)
	{
		return CallMethod<nsISupports>("createSVGPathSegArcRel", new object[7] { x, y, r1, r2, angle, largeArcFlag, sweepFlag });
	}

	public nsISupports CreateSVGPathSegLinetoHorizontalAbs(float x)
	{
		return CallMethod<nsISupports>("createSVGPathSegLinetoHorizontalAbs", new object[1] { x });
	}

	public nsISupports CreateSVGPathSegLinetoHorizontalRel(float x)
	{
		return CallMethod<nsISupports>("createSVGPathSegLinetoHorizontalRel", new object[1] { x });
	}

	public nsISupports CreateSVGPathSegLinetoVerticalAbs(float y)
	{
		return CallMethod<nsISupports>("createSVGPathSegLinetoVerticalAbs", new object[1] { y });
	}

	public nsISupports CreateSVGPathSegLinetoVerticalRel(float y)
	{
		return CallMethod<nsISupports>("createSVGPathSegLinetoVerticalRel", new object[1] { y });
	}

	public nsISupports CreateSVGPathSegCurvetoCubicSmoothAbs(float x, float y, float x2, float y2)
	{
		return CallMethod<nsISupports>("createSVGPathSegCurvetoCubicSmoothAbs", new object[4] { x, y, x2, y2 });
	}

	public nsISupports CreateSVGPathSegCurvetoCubicSmoothRel(float x, float y, float x2, float y2)
	{
		return CallMethod<nsISupports>("createSVGPathSegCurvetoCubicSmoothRel", new object[4] { x, y, x2, y2 });
	}

	public nsISupports CreateSVGPathSegCurvetoQuadraticSmoothAbs(float x, float y)
	{
		return CallMethod<nsISupports>("createSVGPathSegCurvetoQuadraticSmoothAbs", new object[2] { x, y });
	}

	public nsISupports CreateSVGPathSegCurvetoQuadraticSmoothRel(float x, float y)
	{
		return CallMethod<nsISupports>("createSVGPathSegCurvetoQuadraticSmoothRel", new object[2] { x, y });
	}
}
