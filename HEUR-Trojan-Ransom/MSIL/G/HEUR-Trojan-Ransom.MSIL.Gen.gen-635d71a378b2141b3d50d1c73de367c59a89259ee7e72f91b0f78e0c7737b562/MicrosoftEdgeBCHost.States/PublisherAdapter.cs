using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class PublisherAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PublisherAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateInterfaceServer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateInterfaceServer()
	{
	}
}
