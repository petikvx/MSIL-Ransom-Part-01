namespace Org.BouncyCastle.Math.EC.Endo;

public class GlvTypeAEndomorphism : ECEndomorphism, GlvEndomorphism
{
	protected readonly GlvTypeAParameters m_parameters;

	protected readonly ECPointMap m_pointMap;

	public virtual ECPointMap PointMap => m_pointMap;

	public virtual bool HasEfficientPointMap => true;

	public GlvTypeAEndomorphism(ECCurve curve, GlvTypeAParameters parameters)
	{
		m_parameters = parameters;
		m_pointMap = new ScaleYNegateXPointMap(curve.FromBigInteger(parameters.I));
	}

	public virtual BigInteger[] DecomposeScalar(BigInteger k)
	{
		return EndoUtilities.DecomposeScalar(m_parameters.SplitParams, k);
	}
}
