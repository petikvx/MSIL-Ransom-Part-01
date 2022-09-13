using System;
using Ionic.Zip;

namespace Ionic;

internal class TimeCriterion : SelectionCriterion
{
	internal ComparisonOperator Operator;

	internal WhichTime Which;

	internal DateTime Time;

	public override string ToString()
	{
		//Discarded unreachable code: IL_0007, IL_000c, IL_0013, IL_001d
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_003F val = ~/*Error near IL_0001: Stack underflow*/;
		_ = ((int[])/*Error near IL_0002: Stack underflow*/)[val];
		/*Error near IL_0002: Invalid metadata token*/;
	}

	internal override extern bool Evaluate(string filename);

	private extern bool _Evaluate(DateTime x);

	internal override extern bool Evaluate(ZipEntry entry);

	public extern TimeCriterion();
}
