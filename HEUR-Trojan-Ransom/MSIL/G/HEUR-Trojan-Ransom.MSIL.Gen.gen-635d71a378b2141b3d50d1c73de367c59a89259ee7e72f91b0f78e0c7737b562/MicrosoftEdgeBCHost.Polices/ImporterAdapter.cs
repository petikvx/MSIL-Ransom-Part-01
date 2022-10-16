using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ImporterAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImporterAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		SortInterfaceInstance();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortInterfaceInstance()
	{
	}
}
