using Microsoft.Kofe.IJDWP;

namespace Microsoft.Kofe.Engine;

internal class A88C352C6 : BinaryOperatorEvaluator
{
	public DF0AD6554 EE48BC3DC => DF0AD6554.Equals;

	public Value B33E81F51(Value F6A748F47, Value B9DCFD805)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Invalid comparison between Unknown and I4
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Invalid comparison between Unknown and I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected I4, but got Unknown
		bool b;
		if (F6A748F47.Kind == F18024EA9.Simple && B9DCFD805.Kind == F18024EA9.Simple)
		{
			BF602D4D0 E1A030A = (BF602D4D0)F6A748F47;
			BF602D4D0 A5B486F8B = (BF602D4D0)B9DCFD805;
			if ((int)E1A030A.D305911E9 == 90 && (int)A5B486F8B.D305911E9 == 90)
			{
				b = E1A030A.CD0899617() == A5B486F8B.CD0899617();
			}
			else
			{
				BF602D4D0.DFF30C2C2(ref E1A030A, ref A5B486F8B);
				JdwpValueTag tag = E1A030A.D305911E9;
				b = (tag - 68) switch
				{
					5 => E1A030A.FF9267D3B() == A5B486F8B.FF9267D3B(), 
					6 => E1A030A.B30004D0D() == A5B486F8B.B30004D0D(), 
					2 => E1A030A.A70A83630() == A5B486F8B.A70A83630(), 
					0 => E1A030A.CDF19C4E4() == A5B486F8B.CDF19C4E4(), 
					_ => throw new EEA8EDD4A(B0E4D9146.BFB0085C0), 
				};
			}
		}
		else if (F6A748F47.Kind == F18024EA9.Object && B9DCFD805.Kind == F18024EA9.Object)
		{
			if (F6A748F47 is CC18CEB1F && B9DCFD805 is CC18CEB1F)
			{
				b = true;
			}
			else if (F6A748F47 is CC18CEB1F || B9DCFD805 is CC18CEB1F)
			{
				b = false;
			}
			else
			{
				if (!(F6A748F47 is C4CC2394A) || !(B9DCFD805 is C4CC2394A))
				{
					throw new EEA8EDD4A(B0E4D9146.BFB0085C0);
				}
				b = ((C4CC2394A)F6A748F47).A5CC0F68A == ((C4CC2394A)B9DCFD805).A5CC0F68A;
			}
		}
		else if (F6A748F47.Kind == F18024EA9.Array && B9DCFD805.Kind == F18024EA9.Array)
		{
			b = ((C61B1F4EE)F6A748F47).A5CC0F68A == ((C61B1F4EE)B9DCFD805).A5CC0F68A;
		}
		else
		{
			if (F6A748F47.Kind != F18024EA9.String || B9DCFD805.Kind != F18024EA9.String)
			{
				throw new EEA8EDD4A(B0E4D9146.BFB0085C0);
			}
			F34C80160 f34C = (F34C80160)F6A748F47;
			F34C80160 f34C2 = (F34C80160)B9DCFD805;
			b = f34C.FC592E1A6 && f34C2.FC592E1A6 && f34C.D44B6A2C2 == f34C2.D44B6A2C2;
		}
		return new BF602D4D0(b);
	}
}
