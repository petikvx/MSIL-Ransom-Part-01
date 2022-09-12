using Microsoft.Kofe.IJDWP;

namespace Microsoft.Kofe.Engine;

internal class B3CA46DA3 : E4F9B9E16, BinaryOperatorEvaluator
{
	public DF0AD6554 F0E142904 => DF0AD6554.BitwiseExclusiveOr;

	public override BF602D4D0 F99F6151C(BF602D4D0 A16AA83A3, BF602D4D0 D42800E47)
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
		if ((int)A16AA83A3.D305911E9 != 90 || (int)D42800E47.D305911E9 != 90)
		{
			A61F1DC01(ref A16AA83A3, ref D42800E47);
		}
		JdwpValueTag tag = A16AA83A3.D305911E9;
		if ((int)tag != 73)
		{
			if ((int)tag != 74)
			{
				if ((int)tag == 90)
				{
					return new BF602D4D0(A16AA83A3.CD0899617() ^ D42800E47.CD0899617());
				}
				throw new EEA8EDD4A(B0E4D9146.BFB0085C0);
			}
			return new BF602D4D0(A16AA83A3.B30004D0D() ^ D42800E47.B30004D0D());
		}
		return new BF602D4D0(A16AA83A3.FF9267D3B() ^ D42800E47.FF9267D3B());
	}
}
