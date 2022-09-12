using Microsoft.Kofe.IJDWP;

namespace Microsoft.Kofe.Engine;

internal class ADF2672A9 : E4F9B9E16, BinaryOperatorEvaluator
{
	public DF0AD6554 C4529FB47 => DF0AD6554.Minus;

	public override BF602D4D0 A0E221749(BF602D4D0 E2ECF9CC4, BF602D4D0 EE664A464)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected I4, but got Unknown
		A61F1DC01(ref E2ECF9CC4, ref EE664A464);
		JdwpValueTag tag = E2ECF9CC4.D305911E9;
		return (tag - 68) switch
		{
			5 => new BF602D4D0(E2ECF9CC4.FF9267D3B() - EE664A464.FF9267D3B()), 
			6 => new BF602D4D0(E2ECF9CC4.B30004D0D() - EE664A464.B30004D0D()), 
			2 => new BF602D4D0(E2ECF9CC4.A70A83630() - EE664A464.A70A83630()), 
			0 => new BF602D4D0(E2ECF9CC4.CDF19C4E4() - EE664A464.CDF19C4E4()), 
			_ => throw new EEA8EDD4A(B0E4D9146.BFB0085C0), 
		};
	}
}
