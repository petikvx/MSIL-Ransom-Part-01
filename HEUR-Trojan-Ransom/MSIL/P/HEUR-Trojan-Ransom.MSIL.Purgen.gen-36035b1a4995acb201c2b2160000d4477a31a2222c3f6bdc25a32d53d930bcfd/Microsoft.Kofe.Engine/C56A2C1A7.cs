using Microsoft.Kofe.IJDWP;

namespace Microsoft.Kofe.Engine;

internal class C56A2C1A7 : UnaryOperatorEvaluator
{
	public DF0AD6554 A04A3518E => DF0AD6554.Minus;

	public BF602D4D0 E3FAA7B14(BF602D4D0 F5AF89046)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		JdwpValueTag tag = F5AF89046.D305911E9;
		if ((int)tag == 90)
		{
			return new BF602D4D0(!F5AF89046.CD0899617());
		}
		throw new EEA8EDD4A(B0E4D9146.BFB0085C0);
	}
}
