using Microsoft.Kofe.IJDWP;

namespace Microsoft.Kofe.Engine;

internal class FA4D7ABF2 : E4F9B9E16, BinaryOperatorEvaluator
{
	public DF0AD6554 C3AF2072C => DF0AD6554.BitwiseAnd;

	public override BF602D4D0 BD898444E(BF602D4D0 E8C22E952, BF602D4D0 CEC4EA764)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Invalid comparison between Unknown and I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Invalid comparison between Unknown and I4
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Invalid comparison between Unknown and I4
		if ((int)E8C22E952.D305911E9 != 90 || (int)CEC4EA764.D305911E9 != 90)
		{
			A61F1DC01(ref E8C22E952, ref CEC4EA764);
		}
		JdwpValueTag tag = E8C22E952.D305911E9;
		if ((int)tag != 73)
		{
			if ((int)tag != 74)
			{
				if ((int)tag == 90)
				{
					return new BF602D4D0(E8C22E952.CD0899617() & CEC4EA764.CD0899617());
				}
				throw new EEA8EDD4A(B0E4D9146.BFB0085C0);
			}
			return new BF602D4D0(E8C22E952.B30004D0D() & CEC4EA764.B30004D0D());
		}
		return new BF602D4D0(E8C22E952.FF9267D3B() & CEC4EA764.FF9267D3B());
	}
}
