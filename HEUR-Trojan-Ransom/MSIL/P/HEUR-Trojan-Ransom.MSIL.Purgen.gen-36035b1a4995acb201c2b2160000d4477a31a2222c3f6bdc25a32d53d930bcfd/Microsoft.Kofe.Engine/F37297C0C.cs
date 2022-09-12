using Microsoft.Kofe.IJDWP;

namespace Microsoft.Kofe.Engine;

internal class F37297C0C : E4F9B9E16, BinaryOperatorEvaluator
{
	public DF0AD6554 DBEB6DCAC => DF0AD6554.Minus;

	public override BF602D4D0 F8FE88F6B(BF602D4D0 A3D5CCBC7, BF602D4D0 EAD0D2D59)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected I4, but got Unknown
		A61F1DC01(ref A3D5CCBC7, ref EAD0D2D59);
		JdwpValueTag tag = A3D5CCBC7.D305911E9;
		return (tag - 68) switch
		{
			5 => new BF602D4D0(A3D5CCBC7.FF9267D3B() > EAD0D2D59.FF9267D3B()), 
			6 => new BF602D4D0(A3D5CCBC7.B30004D0D() > EAD0D2D59.B30004D0D()), 
			2 => new BF602D4D0(A3D5CCBC7.A70A83630() > EAD0D2D59.A70A83630()), 
			0 => new BF602D4D0(A3D5CCBC7.CDF19C4E4() > EAD0D2D59.CDF19C4E4()), 
			_ => throw new EEA8EDD4A(B0E4D9146.BFB0085C0), 
		};
	}
}
