using Microsoft.Kofe.IJDWP;

namespace Microsoft.Kofe.Engine;

internal class D8DD9C1C7 : E4F9B9E16, BinaryOperatorEvaluator
{
	public DF0AD6554 EB6D9FFAB => DF0AD6554.Times;

	public override BF602D4D0 B0376E8D2(BF602D4D0 C262883E6, BF602D4D0 A3107BF84)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected I4, but got Unknown
		A61F1DC01(ref C262883E6, ref A3107BF84);
		JdwpValueTag tag = C262883E6.D305911E9;
		return (tag - 68) switch
		{
			5 => new BF602D4D0(C262883E6.FF9267D3B() * A3107BF84.FF9267D3B()), 
			6 => new BF602D4D0(C262883E6.B30004D0D() * A3107BF84.B30004D0D()), 
			2 => new BF602D4D0(C262883E6.A70A83630() * A3107BF84.A70A83630()), 
			0 => new BF602D4D0(C262883E6.CDF19C4E4() * A3107BF84.CDF19C4E4()), 
			_ => throw new EEA8EDD4A(B0E4D9146.BFB0085C0), 
		};
	}
}
