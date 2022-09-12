using System.Collections;

namespace ns3;

public static class GClass1
{
	private static volatile IComparer icomparer_0;

	private static volatile IEqualityComparer iequalityComparer_0;

	public static IComparer StructuralComparer
	{
		get
		{
			IComparer comparer = icomparer_0;
			if (comparer == null)
			{
				comparer = (icomparer_0 = new System.Collections.StructuralComparer());
			}
			return comparer;
		}
	}

	public static IEqualityComparer StructuralEqualityComparer
	{
		get
		{
			IEqualityComparer equalityComparer = iequalityComparer_0;
			if (equalityComparer == null)
			{
				equalityComparer = (iequalityComparer_0 = new System.Collections.StructuralEqualityComparer());
			}
			return equalityComparer;
		}
	}
}
