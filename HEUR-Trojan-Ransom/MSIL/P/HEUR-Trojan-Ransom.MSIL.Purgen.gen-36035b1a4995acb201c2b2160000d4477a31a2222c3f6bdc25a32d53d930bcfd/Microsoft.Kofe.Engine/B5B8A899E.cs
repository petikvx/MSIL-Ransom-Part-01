using Microsoft.Kofe.IJDWP;

namespace Microsoft.Kofe.Engine;

internal class B5B8A899E : E4F9B9E16, BinaryOperatorEvaluator
{
	public DF0AD6554 B9C3B4543 => DF0AD6554.Minus;

	public override BF602D4D0 E6A2AF363(BF602D4D0 CA2230988, BF602D4D0 DDB12C8FB)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected I4, but got Unknown
		A61F1DC01(ref CA2230988, ref DDB12C8FB);
		JdwpValueTag tag = CA2230988.D305911E9;
		return (tag - 68) switch
		{
			5 => new BF602D4D0(CA2230988.FF9267D3B() >= DDB12C8FB.FF9267D3B()), 
			6 => new BF602D4D0(CA2230988.B30004D0D() >= DDB12C8FB.B30004D0D()), 
			2 => new BF602D4D0(CA2230988.A70A83630() >= DDB12C8FB.A70A83630()), 
			0 => new BF602D4D0(CA2230988.CDF19C4E4() >= DDB12C8FB.CDF19C4E4()), 
			_ => throw new EEA8EDD4A(B0E4D9146.BFB0085C0), 
		};
	}
}
