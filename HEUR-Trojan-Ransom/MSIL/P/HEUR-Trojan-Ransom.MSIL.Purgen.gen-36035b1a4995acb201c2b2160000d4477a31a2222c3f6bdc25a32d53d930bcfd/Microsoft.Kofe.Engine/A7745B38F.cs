using Microsoft.Kofe.IJDWP;

namespace Microsoft.Kofe.Engine;

internal class A7745B38F : E4F9B9E16, BinaryOperatorEvaluator
{
	public DF0AD6554 E2039171E => DF0AD6554.Minus;

	public override BF602D4D0 DCCE9663C(BF602D4D0 D1CC1CEEF, BF602D4D0 FD37BB7EB)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected I4, but got Unknown
		A61F1DC01(ref D1CC1CEEF, ref FD37BB7EB);
		JdwpValueTag tag = D1CC1CEEF.D305911E9;
		return (tag - 68) switch
		{
			5 => new BF602D4D0(D1CC1CEEF.FF9267D3B() < FD37BB7EB.FF9267D3B()), 
			6 => new BF602D4D0(D1CC1CEEF.B30004D0D() < FD37BB7EB.B30004D0D()), 
			2 => new BF602D4D0(D1CC1CEEF.A70A83630() < FD37BB7EB.A70A83630()), 
			0 => new BF602D4D0(D1CC1CEEF.CDF19C4E4() < FD37BB7EB.CDF19C4E4()), 
			_ => throw new EEA8EDD4A(B0E4D9146.BFB0085C0), 
		};
	}
}
