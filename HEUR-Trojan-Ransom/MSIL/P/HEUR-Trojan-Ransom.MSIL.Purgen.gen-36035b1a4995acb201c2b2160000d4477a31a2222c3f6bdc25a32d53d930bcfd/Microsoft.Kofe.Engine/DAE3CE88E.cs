using Microsoft.Kofe.IJDWP;

namespace Microsoft.Kofe.Engine;

internal class DAE3CE88E : UnaryOperatorEvaluator
{
	public DF0AD6554 FB081285A => DF0AD6554.Minus;

	public BF602D4D0 E4C312BB6(BF602D4D0 DD5FF9479)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected I4, but got Unknown
		DD5FF9479 = DD5FF9479.A2F95B38B();
		JdwpValueTag tag = DD5FF9479.D305911E9;
		return (tag - 68) switch
		{
			2 => new BF602D4D0(0f - DD5FF9479.A70A83630()), 
			0 => new BF602D4D0(0.0 - DD5FF9479.CDF19C4E4()), 
			5 => new BF602D4D0(-DD5FF9479.FF9267D3B()), 
			6 => new BF602D4D0(-DD5FF9479.B30004D0D()), 
			_ => throw new EEA8EDD4A(B0E4D9146.BFB0085C0), 
		};
	}
}
