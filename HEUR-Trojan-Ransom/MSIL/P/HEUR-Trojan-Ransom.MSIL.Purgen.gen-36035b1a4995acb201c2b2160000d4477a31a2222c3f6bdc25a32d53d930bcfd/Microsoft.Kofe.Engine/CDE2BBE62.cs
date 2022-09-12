using Microsoft.Kofe.IJDWP;

namespace Microsoft.Kofe.Engine;

internal class CDE2BBE62 : UnaryOperatorEvaluator
{
	public DF0AD6554 D2E334F49 => DF0AD6554.Minus;

	public BF602D4D0 F0875838B(BF602D4D0 A9E5FADAF)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		A9E5FADAF = A9E5FADAF.A2F95B38B();
		JdwpValueTag tag = A9E5FADAF.D305911E9;
		if ((int)tag != 73)
		{
			if ((int)tag == 74)
			{
				return new BF602D4D0(~A9E5FADAF.B30004D0D());
			}
			throw new EEA8EDD4A(B0E4D9146.BFB0085C0);
		}
		return new BF602D4D0(~A9E5FADAF.FF9267D3B());
	}
}
