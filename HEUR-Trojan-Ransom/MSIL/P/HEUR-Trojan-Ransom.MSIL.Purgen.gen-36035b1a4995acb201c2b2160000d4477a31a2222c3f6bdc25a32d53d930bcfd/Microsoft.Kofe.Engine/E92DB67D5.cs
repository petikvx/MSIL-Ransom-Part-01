using Microsoft.Kofe.IJDWP;

namespace Microsoft.Kofe.Engine;

internal class E92DB67D5 : F0BF55EE3, BinaryOperatorEvaluator
{
	public DF0AD6554 E5BB45F10 => DF0AD6554.LeftShift;

	public override BF602D4D0 C8444EB0F(BF602D4D0 D24E06835, BF602D4D0 D5C4A3B56)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		int num = F0BF55EE3.ShiftDistance(D24E06835, D5C4A3B56);
		JdwpValueTag tag = D24E06835.D305911E9;
		if ((int)tag != 73)
		{
			if ((int)tag == 74)
			{
				return new BF602D4D0(D24E06835.B30004D0D() >> num);
			}
			throw new EEA8EDD4A(B0E4D9146.BFB0085C0);
		}
		return new BF602D4D0(D24E06835.FF9267D3B() >> num);
	}
}
