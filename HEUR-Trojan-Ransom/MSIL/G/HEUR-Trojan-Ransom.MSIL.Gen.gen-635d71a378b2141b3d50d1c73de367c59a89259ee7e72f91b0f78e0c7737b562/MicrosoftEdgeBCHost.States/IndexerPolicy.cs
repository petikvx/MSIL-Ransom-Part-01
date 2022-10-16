using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class IndexerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IndexerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		NewInterfaceCallback();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewInterfaceCallback()
	{
	}
}
