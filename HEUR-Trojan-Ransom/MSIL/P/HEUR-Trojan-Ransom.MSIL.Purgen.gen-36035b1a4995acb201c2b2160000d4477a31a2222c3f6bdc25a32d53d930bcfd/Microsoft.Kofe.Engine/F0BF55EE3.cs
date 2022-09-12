using Microsoft.Kofe.IJDWP;

namespace Microsoft.Kofe.Engine;

internal abstract class F0BF55EE3
{
	public Value B4D595B63(Value C189F6892, Value A59EF1954)
	{
		if (C189F6892.Kind != 0 || A59EF1954.Kind != 0)
		{
			throw new EEA8EDD4A(B0E4D9146.BFB0085C0);
		}
		BF602D4D0 bF602D4D = ((BF602D4D0)C189F6892).A2F95B38B();
		BF602D4D0 bF602D4D2 = ((BF602D4D0)A59EF1954).A2F95B38B();
		if (!bF602D4D.FC5DF890C || !bF602D4D2.FC5DF890C)
		{
			throw new EEA8EDD4A(B0E4D9146.BFB0085C0);
		}
		return C9B8542FD(bF602D4D, bF602D4D2);
	}

	public abstract BF602D4D0 C9B8542FD(BF602D4D0 FD798FD46, BF602D4D0 AAB0C3619);

	protected static int ShiftDistance(BF602D4D0 l, BF602D4D0 r)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Invalid comparison between Unknown and I4
		JdwpValueTag tag = l.D305911E9;
		if ((int)tag != 73)
		{
			if ((int)tag == 74)
			{
				return (int)r.DBA29F744().B30004D0D() & 0x3F;
			}
			return 0;
		}
		return (int)r.DBA29F744().B30004D0D() & 0x1F;
	}
}
