using Ionic.Zip;

namespace Ionic;

internal class SizeCriterion : SelectionCriterion
{
	internal ComparisonOperator Operator;

	internal long Size;

	public override extern string ToString();

	internal override bool Evaluate(string filename)
	{
		//Discarded unreachable code: IL_0009
		//IL_0004: Incompatible stack heights: 0 vs 1
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			_ = ((sbyte[])/*Error: ldloc 0 (out-of-bounds)*/)[/*Error near IL_0002: ldarg 3 (out-of-bounds)*/];
		}
	}

	private extern bool _Evaluate(long Length);

	internal override extern bool Evaluate(ZipEntry entry);

	public extern SizeCriterion();
}
