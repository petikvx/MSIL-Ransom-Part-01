using Microsoft.Kofe.IJDWP;

namespace Microsoft.Kofe.Engine;

internal class D56BA77F4 : F0BF55EE3, BinaryOperatorEvaluator
{
	public DF0AD6554 C2E030FFB => DF0AD6554.LeftShift;

	public override BF602D4D0 D09FA24D5(BF602D4D0 DEAA39444, BF602D4D0 E2EADC25B)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		int num = F0BF55EE3.ShiftDistance(DEAA39444, E2EADC25B);
		JdwpValueTag tag = DEAA39444.D305911E9;
		if ((int)tag != 73)
		{
			if ((int)tag == 74)
			{
				return new BF602D4D0((float)((ulong)DEAA39444.B30004D0D() >> num));
			}
			throw new EEA8EDD4A(B0E4D9146.BFB0085C0);
		}
		return new BF602D4D0((long)((uint)DEAA39444.FF9267D3B() >> num));
	}
}
