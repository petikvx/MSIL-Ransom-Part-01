using Microsoft.Kofe.IJDWP;

namespace Microsoft.Kofe.Engine;

internal class EFC45D15C : E4F9B9E16, BinaryOperatorEvaluator
{
	public DF0AD6554 FE4F249BE => DF0AD6554.Minus;

	public override BF602D4D0 BF150495D(BF602D4D0 C1E3FFC0F, BF602D4D0 A5EB3CAC4)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected I4, but got Unknown
		A61F1DC01(ref C1E3FFC0F, ref A5EB3CAC4);
		JdwpValueTag tag = C1E3FFC0F.D305911E9;
		return (tag - 68) switch
		{
			5 => new BF602D4D0(C1E3FFC0F.FF9267D3B() <= A5EB3CAC4.FF9267D3B()), 
			6 => new BF602D4D0(C1E3FFC0F.B30004D0D() <= A5EB3CAC4.B30004D0D()), 
			2 => new BF602D4D0(C1E3FFC0F.A70A83630() <= A5EB3CAC4.A70A83630()), 
			0 => new BF602D4D0(C1E3FFC0F.CDF19C4E4() <= A5EB3CAC4.CDF19C4E4()), 
			_ => throw new EEA8EDD4A(B0E4D9146.BFB0085C0), 
		};
	}
}
