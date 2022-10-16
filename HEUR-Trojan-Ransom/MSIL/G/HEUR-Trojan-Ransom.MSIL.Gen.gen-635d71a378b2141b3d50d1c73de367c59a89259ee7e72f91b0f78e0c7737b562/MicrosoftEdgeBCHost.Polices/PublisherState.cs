using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class PublisherState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PublisherState()
	{
		WriterPropertyProducer.ResolveStub();
		InitInterfaceDefinition();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitInterfaceDefinition()
	{
	}
}
