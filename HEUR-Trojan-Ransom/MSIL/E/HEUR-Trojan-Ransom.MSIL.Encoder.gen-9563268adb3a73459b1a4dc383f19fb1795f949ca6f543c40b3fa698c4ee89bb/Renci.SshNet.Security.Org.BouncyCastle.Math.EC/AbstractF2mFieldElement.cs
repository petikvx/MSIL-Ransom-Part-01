using System;

namespace Renci.SshNet.Security.Org.BouncyCastle.Math.EC;

internal abstract class AbstractF2mFieldElement : ECFieldElement
{
	public virtual ECFieldElement HalfTrace()
	{
		int fieldSize = FieldSize;
		if ((fieldSize & 1) == 0)
		{
			throw new InvalidOperationException("Half-trace only defined for odd m");
		}
		ECFieldElement eCFieldElement = this;
		ECFieldElement eCFieldElement2 = eCFieldElement;
		for (int i = 2; i < fieldSize; i += 2)
		{
			eCFieldElement = eCFieldElement.SquarePow(2);
			eCFieldElement2 = eCFieldElement2.Add(eCFieldElement);
		}
		return eCFieldElement2;
	}

	public virtual int Trace()
	{
		int fieldSize = FieldSize;
		ECFieldElement eCFieldElement = this;
		ECFieldElement eCFieldElement2 = eCFieldElement;
		for (int i = 1; i < fieldSize; i++)
		{
			eCFieldElement = eCFieldElement.Square();
			eCFieldElement2 = eCFieldElement2.Add(eCFieldElement);
		}
		if (eCFieldElement2.IsZero)
		{
			return 0;
		}
		if (!eCFieldElement2.IsOne)
		{
			throw new InvalidOperationException("Internal error in trace calculation");
		}
		return 1;
	}
}
