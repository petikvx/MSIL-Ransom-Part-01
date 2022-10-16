using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ListFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListFilter()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeStrategy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeStrategy()
	{
	}
}
