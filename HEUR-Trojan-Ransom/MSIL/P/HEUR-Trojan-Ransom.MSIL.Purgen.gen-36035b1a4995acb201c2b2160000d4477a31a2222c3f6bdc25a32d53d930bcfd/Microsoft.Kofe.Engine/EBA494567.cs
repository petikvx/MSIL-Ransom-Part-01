using Microsoft.Kofe.IJDWP;

namespace Microsoft.Kofe.Engine;

internal class EBA494567 : E4F9B9E16, BinaryOperatorEvaluator
{
	public DF0AD6554 F1137D0B2 => DF0AD6554.Modulus;

	public override BF602D4D0 D74AD09FC(BF602D4D0 F05EFF6A3, BF602D4D0 FC6E79DAE)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected I4, but got Unknown
		A61F1DC01(ref F05EFF6A3, ref FC6E79DAE);
		JdwpValueTag tag = F05EFF6A3.D305911E9;
		switch (tag - 68)
		{
		case 5:
			if (FC6E79DAE.FF9267D3B() == 0)
			{
				throw new EEA8EDD4A(B0E4D9146.C7492EDD4);
			}
			return new BF602D4D0(F05EFF6A3.FF9267D3B() % FC6E79DAE.FF9267D3B());
		case 6:
			if (FC6E79DAE.B30004D0D() == 0L)
			{
				throw new EEA8EDD4A(B0E4D9146.C7492EDD4);
			}
			return new BF602D4D0(F05EFF6A3.B30004D0D() % FC6E79DAE.B30004D0D());
		case 2:
			return new BF602D4D0(F05EFF6A3.A70A83630() % FC6E79DAE.A70A83630());
		case 0:
			return new BF602D4D0(F05EFF6A3.CDF19C4E4() % FC6E79DAE.CDF19C4E4());
		default:
			throw new EEA8EDD4A(B0E4D9146.BFB0085C0);
		}
	}
}
