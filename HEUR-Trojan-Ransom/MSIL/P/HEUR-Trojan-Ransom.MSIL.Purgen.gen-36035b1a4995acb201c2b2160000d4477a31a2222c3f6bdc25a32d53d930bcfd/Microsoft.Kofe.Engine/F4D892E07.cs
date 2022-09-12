using Microsoft.Kofe.IJDWP;

namespace Microsoft.Kofe.Engine;

internal class F4D892E07 : E4F9B9E16, BinaryOperatorEvaluator
{
	public DF0AD6554 D5C94BFEA => DF0AD6554.Plus;

	public override BF602D4D0 C8DEF051C(BF602D4D0 D4A222F95, BF602D4D0 DDCB76651)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected I4, but got Unknown
		A61F1DC01(ref D4A222F95, ref DDCB76651);
		JdwpValueTag tag = D4A222F95.D305911E9;
		return (tag - 68) switch
		{
			5 => new BF602D4D0(D4A222F95.FF9267D3B() + DDCB76651.FF9267D3B()), 
			6 => new BF602D4D0(D4A222F95.B30004D0D() + DDCB76651.B30004D0D()), 
			2 => new BF602D4D0(D4A222F95.A70A83630() + DDCB76651.A70A83630()), 
			0 => new BF602D4D0(D4A222F95.CDF19C4E4() + DDCB76651.CDF19C4E4()), 
			_ => throw new EEA8EDD4A(B0E4D9146.BFB0085C0), 
		};
	}
}
