namespace Microsoft.Kofe.Engine;

internal class EEFCB628A : E4F9B9E16, BinaryOperatorEvaluator
{
	public DF0AD6554 F3C86A8DE => DF0AD6554.And;

	public override BF602D4D0 ABB3C7374(BF602D4D0 B91F02702, BF602D4D0 BD6708BBC)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		if ((int)B91F02702.D305911E9 != 90 || (int)BD6708BBC.D305911E9 != 90)
		{
			throw new EEA8EDD4A(B0E4D9146.BFB0085C0);
		}
		return new BF602D4D0(B91F02702.CD0899617() && BD6708BBC.CD0899617());
	}
}
