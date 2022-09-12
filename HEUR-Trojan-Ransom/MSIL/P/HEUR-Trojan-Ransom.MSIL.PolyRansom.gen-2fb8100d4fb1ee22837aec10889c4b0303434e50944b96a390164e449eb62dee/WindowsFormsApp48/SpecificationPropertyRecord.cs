using WindowsFormsApp48.Google;

namespace WindowsFormsApp48;

internal class SpecificationPropertyRecord
{
	internal static SpecificationPropertyRecord SortDefinition;

	private static int Main()
	{
		Visitor.NewPredicate();
		return 0;
	}

	internal static bool ResolveDefinition()
	{
		return SortDefinition == null;
	}

	internal static SpecificationPropertyRecord ListDefinition()
	{
		return SortDefinition;
	}
}
