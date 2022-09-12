using Microsoft.Kofe.IJDWP;

namespace Microsoft.Kofe.Engine;

internal class D688EC2D2 : UnaryOperatorEvaluator
{
	public DF0AD6554 D2F5E8E47 => DF0AD6554.Plus;

	public BF602D4D0 C1A706943(BF602D4D0 F2CE87720)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected I4, but got Unknown
		F2CE87720 = F2CE87720.A2F95B38B();
		JdwpValueTag tag = F2CE87720.D305911E9;
		switch (tag - 68)
		{
		case 0:
		case 2:
		case 5:
		case 6:
			return F2CE87720;
		default:
			throw new EEA8EDD4A(B0E4D9146.BFB0085C0);
		}
	}
}
