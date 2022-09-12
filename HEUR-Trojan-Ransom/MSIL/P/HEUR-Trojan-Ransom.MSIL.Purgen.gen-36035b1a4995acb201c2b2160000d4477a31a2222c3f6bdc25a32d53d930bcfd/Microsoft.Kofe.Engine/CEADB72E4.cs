using Microsoft.Kofe.IJDWP;

namespace Microsoft.Kofe.Engine;

internal class CEADB72E4 : E4F9B9E16, BinaryOperatorEvaluator
{
	public DF0AD6554 D7CFD5306 => DF0AD6554.BitwiseOr;

	public override BF602D4D0 B96D8E90A(BF602D4D0 EAD2F1D99, BF602D4D0 C0262FC10)
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
		if ((int)EAD2F1D99.D305911E9 != 90 || (int)C0262FC10.D305911E9 != 90)
		{
			A61F1DC01(ref EAD2F1D99, ref C0262FC10);
		}
		JdwpValueTag tag = EAD2F1D99.D305911E9;
		if ((int)tag != 73)
		{
			if ((int)tag != 74)
			{
				if ((int)tag == 90)
				{
					return new BF602D4D0(EAD2F1D99.CD0899617() | C0262FC10.CD0899617());
				}
				throw new EEA8EDD4A(B0E4D9146.BFB0085C0);
			}
			return new BF602D4D0(EAD2F1D99.B30004D0D() | C0262FC10.B30004D0D());
		}
		return new BF602D4D0(EAD2F1D99.FF9267D3B() | C0262FC10.FF9267D3B());
	}
}
