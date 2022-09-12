using Microsoft.Kofe.IJDWP;

namespace Microsoft.Kofe.Engine;

internal class B3E9024A1 : E4F9B9E16, BinaryOperatorEvaluator
{
	public DF0AD6554 FDFD6ACC9 => DF0AD6554.Divide;

	public override BF602D4D0 BC4BCEF55(BF602D4D0 DC5B1CB31, BF602D4D0 D2C461C12)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected I4, but got Unknown
		A61F1DC01(ref DC5B1CB31, ref D2C461C12);
		JdwpValueTag tag = DC5B1CB31.D305911E9;
		switch (tag - 68)
		{
		case 5:
			if (D2C461C12.FF9267D3B() == 0)
			{
				throw new EEA8EDD4A(B0E4D9146.C7492EDD4);
			}
			return new BF602D4D0(DC5B1CB31.FF9267D3B() / D2C461C12.FF9267D3B());
		case 6:
			if (D2C461C12.B30004D0D() == 0L)
			{
				throw new EEA8EDD4A(B0E4D9146.C7492EDD4);
			}
			return new BF602D4D0(DC5B1CB31.B30004D0D() / D2C461C12.B30004D0D());
		case 2:
			return new BF602D4D0(DC5B1CB31.A70A83630() / D2C461C12.A70A83630());
		case 0:
			return new BF602D4D0(DC5B1CB31.CDF19C4E4() / D2C461C12.CDF19C4E4());
		default:
			throw new EEA8EDD4A(B0E4D9146.BFB0085C0);
		}
	}
}
