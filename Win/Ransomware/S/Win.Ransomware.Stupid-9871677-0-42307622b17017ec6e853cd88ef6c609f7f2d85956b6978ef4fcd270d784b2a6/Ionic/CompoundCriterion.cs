using Ionic.Zip;

namespace Ionic;

internal class CompoundCriterion : SelectionCriterion
{
	internal LogicalConjunction Conjunction;

	internal SelectionCriterion Left;

	private SelectionCriterion _Right;

	internal extern SelectionCriterion Right { get; set; }

	internal override extern bool Evaluate(string filename);

	public override string ToString()
	{
		//Discarded unreachable code: IL_0007, IL_000c, IL_0012, IL_0013, IL_0019, IL_001f
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Incompatible stack heights: 0 vs 1
		/*Error near IL_0002: Invalid metadata token*/;
	}

	internal unsafe override bool Evaluate(ZipEntry entry)
	{
		//Discarded unreachable code: IL_0003, IL_000e, IL_0016, IL_001b
		//IL_0027: Incompatible stack heights: 0 vs 1
		_ = *(object*)(nint)/*Error: ldloc 3 (out-of-bounds)*/;
		/*Error near IL_0002: Unknown opcode: 0xFD*/;
	}

	public extern CompoundCriterion();
}
