using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ParamsFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamsFilter()
	{
		WriterPropertyProducer.ResolveStub();
		FillComparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillComparator()
	{
	}
}
