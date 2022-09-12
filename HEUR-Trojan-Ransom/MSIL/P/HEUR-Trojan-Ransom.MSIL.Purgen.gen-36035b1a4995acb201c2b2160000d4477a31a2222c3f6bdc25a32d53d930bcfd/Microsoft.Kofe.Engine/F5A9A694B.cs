namespace Microsoft.Kofe.Engine;

internal class F5A9A694B : E4F9B9E16, BinaryOperatorEvaluator
{
	public DF0AD6554 A44A666F9 => DF0AD6554.Or;

	public override BF602D4D0 C680214BA(BF602D4D0 BF88CA204, BF602D4D0 FE8684989)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		if ((int)BF88CA204.D305911E9 != 90 || (int)FE8684989.D305911E9 != 90)
		{
			throw new EEA8EDD4A(B0E4D9146.BFB0085C0);
		}
		return new BF602D4D0(BF88CA204.CD0899617() || FE8684989.CD0899617());
	}
}
