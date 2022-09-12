using Microsoft.Kofe.IJDWP;

namespace Microsoft.Kofe.Engine;

internal class D928DB23E : F0BF55EE3, BinaryOperatorEvaluator
{
	public DF0AD6554 FC9E3978E => DF0AD6554.LeftShift;

	public override BF602D4D0 E9A53C9C0(BF602D4D0 B18F40C41, BF602D4D0 A54B31B47)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		int num = F0BF55EE3.ShiftDistance(B18F40C41, A54B31B47);
		JdwpValueTag tag = B18F40C41.D305911E9;
		if ((int)tag != 73)
		{
			if ((int)tag == 74)
			{
				return new BF602D4D0(B18F40C41.B30004D0D() << num);
			}
			throw new EEA8EDD4A(B0E4D9146.BFB0085C0);
		}
		return new BF602D4D0(B18F40C41.FF9267D3B() << num);
	}
}
